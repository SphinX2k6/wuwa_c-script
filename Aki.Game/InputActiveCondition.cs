using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020030AF RID: 12463
[NullableContext(1)]
[Nullable(0)]
public class InputActiveCondition
{
	// Token: 0x0601AB49 RID: 109385 RVA: 0x00731600 File Offset: 0x0072F800
	public InputActiveCondition(BaseTagComponent tagComp, BaseAttributeComponent attributeComp, InputActiveResultCallback callback)
	{
		if (tagComp == null || attributeComp == null || callback == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "InputActiveCondition 缺少参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.TagComp = tagComp;
		this.AttributeComp = attributeComp;
		this.Callback = callback;
		this.Inited = true;
	}

	// Token: 0x0601AB4A RID: 109386 RVA: 0x0073168C File Offset: 0x0072F88C
	[NullableContext(2)]
	public void SetActiveCondition(SInputActive activeCondition)
	{
		if (!this.Inited)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "InputActiveCondition 未正确初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.Clear();
		if (activeCondition == null)
		{
			return;
		}
		this.ConditionFormula = activeCondition.InputActiveConditionFormula;
		TArray<SInputActiveCondition> inputActiveConditionGroup = activeCondition.InputActiveConditionGroup;
		for (int i = 0; i < inputActiveConditionGroup.Num(); i++)
		{
			this.InputActiveConditionList.Add(new CfgInputActiveCondition(inputActiveConditionGroup.Get(i)));
		}
		this.ConditionResultArray = new bool[this.InputActiveConditionList.Count];
		int j = 0;
		while (j < this.InputActiveConditionList.Count)
		{
			int conditionIndex = j;
			CfgInputActiveCondition condition = this.InputActiveConditionList[conditionIndex];
			if (condition.ConditionType == EInputActiveConditionType.施法者标签检测)
			{
				IList<int> tagIds = condition.TagToCheck;
				using (IEnumerator<int> enumerator = tagIds.GetEnumerator())
				{
					BaseTagComponent.TTagSwitchedCallback <>9__0;
					while (enumerator.MoveNext())
					{
						int value = enumerator.Current;
						BaseTagComponent tagComp = this.TagComp;
						int? tagId2 = new int?(value);
						BaseTagComponent.TTagSwitchedCallback callback;
						if ((callback = <>9__0) == null)
						{
							callback = (<>9__0 = delegate(int tagId, bool tagExists)
							{
								this.ConditionTag(conditionIndex, condition, tagIds);
							});
						}
						ITagTask item = tagComp.ListenForTagAddOrRemove(tagId2, callback, null);
						this.TagTaskList.Add(item);
					}
					goto IL_23E;
				}
				goto IL_16F;
			}
			goto IL_16F;
			IL_23E:
			j++;
			continue;
			IL_16F:
			if (condition.ConditionType != EInputActiveConditionType.施法者属性检测)
			{
				goto IL_23E;
			}
			if (condition.AttributeId1 == EAttributeType.None)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "InputActiveCondition 属性1的id不能配0", default(ReadOnlySpan<ValueTuple<string, object>>));
				goto IL_23E;
			}
			Action<EAttributeType, float, float> callback2 = delegate(EAttributeType attribute, float newValue, float oldValue)
			{
				this.ConditionAttribute(conditionIndex, condition);
			};
			this.AttributeComp.AddListener(condition.AttributeId1, callback2, null);
			this.AttributeListenerHandles.Add(new AttributeListenerHandle(condition.AttributeId1, callback2));
			if (condition.AttributeId2 > EAttributeType.None)
			{
				this.AttributeComp.AddListener(condition.AttributeId2, callback2, null);
				this.AttributeListenerHandles.Add(new AttributeListenerHandle(condition.AttributeId2, callback2));
				goto IL_23E;
			}
			goto IL_23E;
		}
		for (int k = 0; k < this.InputActiveConditionList.Count; k++)
		{
			CfgInputActiveCondition cfgInputActiveCondition = this.InputActiveConditionList[k];
			if (cfgInputActiveCondition.ConditionType == EInputActiveConditionType.施法者标签检测)
			{
				this.ConditionTag(k, cfgInputActiveCondition, cfgInputActiveCondition.TagToCheck);
			}
			else if (cfgInputActiveCondition.ConditionType == EInputActiveConditionType.施法者属性检测)
			{
				this.ConditionAttribute(k, cfgInputActiveCondition);
			}
		}
		this.Callback(this.CurrentResult);
	}

	// Token: 0x0601AB4B RID: 109387 RVA: 0x00731968 File Offset: 0x0072FB68
	public void Clear()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
		if (this.AttributeComp != null)
		{
			foreach (AttributeListenerHandle attributeListenerHandle in this.AttributeListenerHandles)
			{
				this.AttributeComp.RemoveListener(attributeListenerHandle.Id, attributeListenerHandle.Callback);
			}
			this.AttributeListenerHandles.Clear();
		}
		this.InputActiveConditionList.Clear();
		Array.Clear(this.ConditionResultArray);
	}

	// Token: 0x0601AB4C RID: 109388 RVA: 0x00731A44 File Offset: 0x0072FC44
	private void ConditionTag(int index, CfgInputActiveCondition condition, IList<int> tagIds)
	{
		bool flag = condition.AnyTag ? this.TagComp.HasAnyTag(tagIds) : this.TagComp.HasAllTag(tagIds);
		bool flag2 = condition.Reverse ? (!flag) : flag;
		this.ConditionResultArray[index] = flag2;
		this.UpdateResult();
	}

	// Token: 0x0601AB4D RID: 109389 RVA: 0x00731A94 File Offset: 0x0072FC94
	private void ConditionAttribute(int index, CfgInputActiveCondition condition)
	{
		float currentValue = this.AttributeComp.GetCurrentValue(condition.AttributeId1);
		float num = (condition.AttributeId2 > EAttributeType.None) ? this.AttributeComp.GetCurrentValue(condition.AttributeId2) : 0f;
		bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, currentValue, condition.Value + num * (float)condition.AttributeRate * 0.0001f, condition.RangeL, condition.RangeR);
		bool flag2 = condition.Reverse ? (!flag) : flag;
		this.ConditionResultArray[index] = flag2;
		this.UpdateResult();
	}

	// Token: 0x0601AB4E RID: 109390 RVA: 0x00731B24 File Offset: 0x0072FD24
	private bool CalcResult()
	{
		if (string.IsNullOrEmpty(this.ConditionFormula))
		{
			return this.ConditionResultArray.Length != 0 && this.ConditionResultArray[0];
		}
		if (this.BooleanListSolver == null)
		{
			try
			{
				ILogicalStructure structure = new Parser(this.ConditionFormula).Parse();
				this.BooleanListSolver = new ConditionArray(this.ConditionResultArray, structure);
			}
			catch (Exception ex)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Control;
				BaseTagComponent tagComp = this.TagComp;
				Entity entity = (tagComp != null) ? tagComp.Entity : null;
				string message = "InputActiveCondition 输入激活条件公式解析异常";
				Exception e = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formula", this.ConditionFormula);
				instance.ErrorWithStack(flag, entity, message, e, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return this.BooleanListSolver.Evaluate();
		}
		return this.BooleanListSolver.EvaluateByConditions(this.ConditionResultArray);
	}

	// Token: 0x0601AB4F RID: 109391 RVA: 0x00731BF4 File Offset: 0x0072FDF4
	private void UpdateResult()
	{
		bool flag = this.CalcResult();
		if (this.CurrentResult != flag)
		{
			this.CurrentResult = flag;
			this.Callback(this.CurrentResult);
		}
	}

	// Token: 0x0400CE16 RID: 52758
	private readonly BaseTagComponent TagComp;

	// Token: 0x0400CE17 RID: 52759
	private readonly BaseAttributeComponent AttributeComp;

	// Token: 0x0400CE18 RID: 52760
	private readonly InputActiveResultCallback Callback;

	// Token: 0x0400CE19 RID: 52761
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400CE1A RID: 52762
	private readonly List<AttributeListenerHandle> AttributeListenerHandles = new List<AttributeListenerHandle>();

	// Token: 0x0400CE1B RID: 52763
	private string ConditionFormula = "";

	// Token: 0x0400CE1C RID: 52764
	private readonly List<CfgInputActiveCondition> InputActiveConditionList = new List<CfgInputActiveCondition>();

	// Token: 0x0400CE1D RID: 52765
	private bool[] ConditionResultArray = Array.Empty<bool>();

	// Token: 0x0400CE1E RID: 52766
	private bool CurrentResult;

	// Token: 0x0400CE1F RID: 52767
	private bool Inited;

	// Token: 0x0400CE20 RID: 52768
	private ConditionArray BooleanListSolver;
}
