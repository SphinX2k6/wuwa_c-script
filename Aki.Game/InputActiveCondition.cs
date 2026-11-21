using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002606 RID: 9734
[NullableContext(1)]
[Nullable(0)]
public class InputActiveCondition
{
	// Token: 0x06018557 RID: 99671 RVA: 0x00756B00 File Offset: 0x00754D00
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

	// Token: 0x06018558 RID: 99672 RVA: 0x00756B8C File Offset: 0x00754D8C
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

	// Token: 0x06018559 RID: 99673 RVA: 0x00756E68 File Offset: 0x00755068
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

	// Token: 0x0601855A RID: 99674 RVA: 0x00756F44 File Offset: 0x00755144
	private void ConditionTag(int index, CfgInputActiveCondition condition, IList<int> tagIds)
	{
		bool flag = condition.AnyTag ? this.TagComp.HasAnyTag(tagIds) : this.TagComp.HasAllTag(tagIds);
		bool flag2 = condition.Reverse ? (!flag) : flag;
		this.ConditionResultArray[index] = flag2;
		this.UpdateResult();
	}

	// Token: 0x0601855B RID: 99675 RVA: 0x00756F94 File Offset: 0x00755194
	private void ConditionAttribute(int index, CfgInputActiveCondition condition)
	{
		float currentValue = this.AttributeComp.GetCurrentValue(condition.AttributeId1);
		float num = (condition.AttributeId2 > EAttributeType.None) ? this.AttributeComp.GetCurrentValue(condition.AttributeId2) : 0f;
		bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, currentValue, condition.Value + num * (float)condition.AttributeRate * 0.0001f, condition.RangeL, condition.RangeR);
		bool flag2 = condition.Reverse ? (!flag) : flag;
		this.ConditionResultArray[index] = flag2;
		this.UpdateResult();
	}

	// Token: 0x0601855C RID: 99676 RVA: 0x00757024 File Offset: 0x00755224
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

	// Token: 0x0601855D RID: 99677 RVA: 0x007570F4 File Offset: 0x007552F4
	private void UpdateResult()
	{
		bool flag = this.CalcResult();
		if (this.CurrentResult != flag)
		{
			this.CurrentResult = flag;
			this.Callback(this.CurrentResult);
		}
	}

	// Token: 0x0400D1FA RID: 53754
	private readonly BaseTagComponent TagComp;

	// Token: 0x0400D1FB RID: 53755
	private readonly BaseAttributeComponent AttributeComp;

	// Token: 0x0400D1FC RID: 53756
	private readonly InputActiveResultCallback Callback;

	// Token: 0x0400D1FD RID: 53757
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400D1FE RID: 53758
	private readonly List<AttributeListenerHandle> AttributeListenerHandles = new List<AttributeListenerHandle>();

	// Token: 0x0400D1FF RID: 53759
	private string ConditionFormula = "";

	// Token: 0x0400D200 RID: 53760
	private readonly List<CfgInputActiveCondition> InputActiveConditionList = new List<CfgInputActiveCondition>();

	// Token: 0x0400D201 RID: 53761
	private bool[] ConditionResultArray = Array.Empty<bool>();

	// Token: 0x0400D202 RID: 53762
	private bool CurrentResult;

	// Token: 0x0400D203 RID: 53763
	private bool Inited;

	// Token: 0x0400D204 RID: 53764
	private ConditionArray BooleanListSolver;
}
