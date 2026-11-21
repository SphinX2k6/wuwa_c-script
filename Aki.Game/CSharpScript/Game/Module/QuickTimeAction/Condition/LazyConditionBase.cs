using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F17 RID: 16151
	[NullableContext(1)]
	[Nullable(0)]
	public class LazyConditionBase
	{
		// Token: 0x06028F5B RID: 167771 RVA: 0x00B7EADC File Offset: 0x00B7CCDC
		public LazyConditionBase(TLazyConditionResultCallback callback)
		{
			if (callback == null)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少回调参数", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ResultCallback = callback;
		}

		// Token: 0x06028F5C RID: 167772 RVA: 0x00B7EB63 File Offset: 0x00B7CD63
		public void SetParam(BaseTagComponent tagComp, BaseAttributeComponent attributeComp)
		{
			this.TagComp = tagComp;
			this.AttributeComp = attributeComp;
		}

		// Token: 0x06028F5D RID: 167773 RVA: 0x00B7EB73 File Offset: 0x00B7CD73
		[NullableContext(2)]
		public void SetParamWithEntity(Entity entity = null)
		{
			if (entity != null)
			{
				this.Entity = entity;
				this.TagComp = entity.GetComponent<BaseTagComponent>();
				this.AttributeComp = entity.GetComponent<BaseAttributeComponent>();
			}
		}

		// Token: 0x06028F5E RID: 167774 RVA: 0x00B7EB98 File Offset: 0x00B7CD98
		[NullableContext(2)]
		public void SetCondition(CfgLazyConditionGroup inCondition = null, bool immediatelyCheck = true)
		{
			if (this.ResultCallback == null)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少回调", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Clear();
			if (inCondition == null)
			{
				return;
			}
			this.ConditionFormula = inCondition.ConditionFormula;
			if (this.ConditionFormula == "" && inCondition.ConditionGroup.Count > 1)
			{
				this.ConditionFormula = "0";
				for (int i = 1; i < inCondition.ConditionGroup.Count; i++)
				{
					this.ConditionFormula = this.ConditionFormula + "||" + i.ToString();
				}
			}
			this.ConditionPayloadId = inCondition.PayloadId;
			foreach (CfgLazyConditionBase item in inCondition.ConditionGroup)
			{
				this.LazyConditionList.Add(item);
			}
			this.ConditionResultList.Clear();
			for (int j = 0; j < this.LazyConditionList.Count; j++)
			{
				this.ConditionResultList.Add(false);
			}
			int k = 0;
			while (k < this.LazyConditionList.Count)
			{
				LazyConditionBase.<>c__DisplayClass16_0 CS$<>8__locals1 = new LazyConditionBase.<>c__DisplayClass16_0();
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.idx = k;
				CS$<>8__locals1.condition = this.LazyConditionList[k];
				if (CS$<>8__locals1.condition.ConditionType.GetValueOrDefault() != ELazyConditionType.标签检测)
				{
					goto IL_22F;
				}
				if (this.TagComp != null)
				{
					IEnumerable<int> tagIds = ((CfgLazyConditionForTag)CS$<>8__locals1.condition).TagToCheck;
					using (IEnumerator<int> enumerator2 = tagIds.GetEnumerator())
					{
						BaseTagComponent.TTagSwitchedCallback <>9__0;
						while (enumerator2.MoveNext())
						{
							int value = enumerator2.Current;
							BaseTagComponent tagComp = this.TagComp;
							int? tagId2 = new int?(value);
							BaseTagComponent.TTagSwitchedCallback callback;
							if ((callback = <>9__0) == null)
							{
								callback = (<>9__0 = delegate(int tagId, bool tagExists)
								{
									CS$<>8__locals1.<>4__this.ConditionTag(CS$<>8__locals1.idx, (CfgLazyConditionForTag)CS$<>8__locals1.condition, tagIds);
								});
							}
							ITagTask tagTask = tagComp.ListenForTagAddOrRemove(tagId2, callback, null);
							if (tagTask != null)
							{
								this.TagTaskList.Add(tagTask);
							}
						}
						goto IL_515;
					}
					goto IL_22F;
				}
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少TagComp", default(ReadOnlySpan<ValueTuple<string, object>>));
				IL_515:
				k++;
				continue;
				IL_22F:
				if (CS$<>8__locals1.condition.ConditionType.GetValueOrDefault() == ELazyConditionType.属性检测)
				{
					CfgLazyConditionForAttribute attributeCondition = (CfgLazyConditionForAttribute)CS$<>8__locals1.condition;
					if (this.AttributeComp == null)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少AttributeComp", default(ReadOnlySpan<ValueTuple<string, object>>));
						goto IL_515;
					}
					if (attributeCondition.AttributeId1 == 0)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 属性1的id不能配0", default(ReadOnlySpan<ValueTuple<string, object>>));
						goto IL_515;
					}
					Action<EAttributeType, float, float> callback2 = delegate(EAttributeType attribute, float newValue, float oldValue)
					{
						CS$<>8__locals1.<>4__this.ConditionAttribute(CS$<>8__locals1.idx, attributeCondition);
					};
					this.AttributeComp.AddListener((EAttributeType)attributeCondition.AttributeId1, callback2, null);
					this.AttributeListenerHandles.Add(new AttributeListenerHandle(attributeCondition.AttributeId1, callback2));
					if (attributeCondition.AttributeId2 > 0)
					{
						this.AttributeComp.AddListener((EAttributeType)attributeCondition.AttributeId2, callback2, null);
						this.AttributeListenerHandles.Add(new AttributeListenerHandle(attributeCondition.AttributeId2, callback2));
						goto IL_515;
					}
					goto IL_515;
				}
				else if (CS$<>8__locals1.condition.ConditionType.GetValueOrDefault() == ELazyConditionType.输入检测)
				{
					CfgLazyConditionForInput inputCondition = (CfgLazyConditionForInput)CS$<>8__locals1.condition;
					if (string.IsNullOrEmpty(inputCondition.ActionName))
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少ActionName", default(ReadOnlySpan<ValueTuple<string, object>>));
						goto IL_515;
					}
					TInputHandle<InputDistributeDefine.EActionType> tinputHandle = delegate(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
					{
						CS$<>8__locals1.<>4__this.ConditionInput(CS$<>8__locals1.idx, inputCondition, new InputDistributeDefine.EActionType?(actionType));
					};
					InputDistributeController.Instance.BindActionIgnoreLimit(inputCondition.ActionName, tinputHandle);
					this.InputListenerHandles.Add(new InputListenerHandle(inputCondition.ActionName, tinputHandle));
					goto IL_515;
				}
				else
				{
					if (CS$<>8__locals1.condition.ConditionType.GetValueOrDefault() != ELazyConditionType.事件变化)
					{
						goto IL_515;
					}
					CfgLazyConditionForEntityEvent cfgLazyConditionForEntityEvent = (CfgLazyConditionForEntityEvent)CS$<>8__locals1.condition;
					if (this.Entity == null)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "LazyCondition 缺少Entity", default(ReadOnlySpan<ValueTuple<string, object>>));
						goto IL_515;
					}
					if (this.EntityEventToIndexMap.ContainsKey(cfgLazyConditionForEntityEvent.EventName))
					{
						goto IL_515;
					}
					this.EntityEventToIndexMap[cfgLazyConditionForEntityEvent.EventName] = CS$<>8__locals1.idx;
					if (cfgLazyConditionForEntityEvent.EventName == ELazyConditionEventName.角色死亡)
					{
						EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
						goto IL_515;
					}
					if (cfgLazyConditionForEntityEvent.EventName == ELazyConditionEventName.当前技能结束)
					{
						EventSystem.Instance.AddWithTarget<int, int>(this.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
						goto IL_515;
					}
					if (cfgLazyConditionForEntityEvent.EventName == ELazyConditionEventName.相机模式变更)
					{
						EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModeChanged));
						goto IL_515;
					}
					goto IL_515;
				}
			}
			if (immediatelyCheck)
			{
				this.ForceCheckOnce();
			}
		}

		// Token: 0x06028F5F RID: 167775 RVA: 0x00B7F0F8 File Offset: 0x00B7D2F8
		public void ForceCheckOnce()
		{
			if (this.ResultCallback != null)
			{
				for (int i = 0; i < this.LazyConditionList.Count; i++)
				{
					CfgLazyConditionBase cfgLazyConditionBase = this.LazyConditionList[i];
					if (cfgLazyConditionBase.ConditionType.GetValueOrDefault() == ELazyConditionType.标签检测)
					{
						this.ConditionTag(i, (CfgLazyConditionForTag)cfgLazyConditionBase, ((CfgLazyConditionForTag)cfgLazyConditionBase).TagToCheck);
					}
					else if (cfgLazyConditionBase.ConditionType.GetValueOrDefault() == ELazyConditionType.属性检测)
					{
						this.ConditionAttribute(i, (CfgLazyConditionForAttribute)cfgLazyConditionBase);
					}
					else if (cfgLazyConditionBase.ConditionType.GetValueOrDefault() == ELazyConditionType.输入检测)
					{
						this.ConditionInput(i, (CfgLazyConditionForInput)cfgLazyConditionBase, null);
					}
				}
				this.ResultCallback(this.CurrentResult, this.ConditionPayloadId);
			}
		}

		// Token: 0x06028F60 RID: 167776 RVA: 0x00B7F1B8 File Offset: 0x00B7D3B8
		protected void ConditionTag(int index, CfgLazyConditionForTag condition, IEnumerable<int> tagIds)
		{
			bool flag = condition.AnyTag ? this.TagComp.HasAnyTag(tagIds) : this.TagComp.HasAllTag(tagIds);
			bool value = condition.Reverse ? (!flag) : flag;
			this.ConditionResultList[index] = value;
			this.UpdateResult();
		}

		// Token: 0x06028F61 RID: 167777 RVA: 0x00B7F20C File Offset: 0x00B7D40C
		protected void ConditionAttribute(int index, CfgLazyConditionForAttribute condition)
		{
			float currentValue = this.AttributeComp.GetCurrentValue((EAttributeType)condition.AttributeId1);
			float num = (condition.AttributeId2 > 0) ? this.AttributeComp.GetCurrentValue((EAttributeType)condition.AttributeId2) : 0f;
			bool flag = SkillBehaviorMisc.Compare(condition.ComparisonLogic, currentValue, (float)condition.Value + num * (float)condition.AttributeRate * 0.0001f, (float)condition.RangeL, (float)condition.RangeR);
			bool value = condition.Reverse ? (!flag) : flag;
			this.ConditionResultList[index] = value;
			this.UpdateResult();
		}

		// Token: 0x06028F62 RID: 167778 RVA: 0x00B7F2A4 File Offset: 0x00B7D4A4
		protected void ConditionInput(int index, CfgLazyConditionForInput condition, InputDistributeDefine.EActionType? actionType)
		{
			bool flag = false;
			switch (condition.KeyMatchType)
			{
			case ELazyConditionKeyMatchType.按下按键:
			{
				InputDistributeDefine.EActionType? eactionType = actionType;
				InputDistributeDefine.EActionType eactionType2 = InputDistributeDefine.EActionType.Press;
				flag = (eactionType.GetValueOrDefault() == eactionType2 & eactionType != null);
				break;
			}
			case ELazyConditionKeyMatchType.抬起按键:
				flag = (actionType.GetValueOrDefault() == InputDistributeDefine.EActionType.Release);
				break;
			case ELazyConditionKeyMatchType.已按键:
			{
				InputDistributeModel instance = InputDistributeModel.Instance;
				flag = (instance != null && instance.IsActionInPress(condition.ActionName));
				break;
			}
			case ELazyConditionKeyMatchType.没按键:
			{
				InputDistributeModel instance2 = InputDistributeModel.Instance;
				flag = (instance2 == null || !instance2.IsActionInPress(condition.ActionName));
				break;
			}
			}
			bool value = condition.Reverse ? (!flag) : flag;
			this.ConditionResultList[index] = value;
			this.UpdateResult();
		}

		// Token: 0x06028F63 RID: 167779 RVA: 0x00B7F354 File Offset: 0x00B7D554
		protected void ConditionCheckEvent(int index)
		{
			bool value = true;
			this.ConditionResultList[index] = value;
			this.UpdateResult();
		}

		// Token: 0x06028F64 RID: 167780 RVA: 0x00B7F376 File Offset: 0x00B7D576
		private void OnRoleDead()
		{
			TLazyConditionResultCallback resultCallback = this.ResultCallback;
			if (resultCallback == null)
			{
				return;
			}
			resultCallback(false, this.ConditionPayloadId);
		}

		// Token: 0x06028F65 RID: 167781 RVA: 0x00B7F390 File Offset: 0x00B7D590
		private void OnCharSkillEnd(int entityId, int skillId)
		{
			int index;
			if (this.EntityEventToIndexMap.TryGetValue(ELazyConditionEventName.当前技能结束, out index))
			{
				this.ConditionCheckEvent(index);
			}
		}

		// Token: 0x06028F66 RID: 167782 RVA: 0x00B7F3B4 File Offset: 0x00B7D5B4
		private void OnCameraModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
		{
			if (cameraName != "MainCamera")
			{
				return;
			}
			int index;
			if (this.EntityEventToIndexMap.TryGetValue(ELazyConditionEventName.相机模式变更, out index))
			{
				this.ConditionCheckEvent(index);
			}
		}

		// Token: 0x06028F67 RID: 167783 RVA: 0x00B7F3E8 File Offset: 0x00B7D5E8
		private bool CalcResult()
		{
			if (string.IsNullOrEmpty(this.ConditionFormula))
			{
				return this.ConditionResultList.Count > 0 && this.ConditionResultList[0];
			}
			if (this.BooleanListSolver == null)
			{
				try
				{
					ILogicalStructure structure = new Parser(this.ConditionFormula).Parse();
					this.BooleanListSolver = new ConditionArray(this.ConditionResultList.ToArray(), structure);
				}
				catch (Exception ex)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Control;
					BaseTagComponent tagComp = this.TagComp;
					Entity entity = (tagComp != null) ? tagComp.Entity : null;
					string message = "LazyConditionBase 激活条件公式解析异常";
					Exception e = ex;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formula", this.ConditionFormula);
					instance.ErrorWithStack(flag, entity, message, e, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				return this.BooleanListSolver.Evaluate();
			}
			return this.BooleanListSolver.EvaluateByConditions(this.ConditionResultList.ToArray());
		}

		// Token: 0x06028F68 RID: 167784 RVA: 0x00B7F4CC File Offset: 0x00B7D6CC
		protected void UpdateResult()
		{
			bool flag = this.CalcResult();
			if (this.CurrentResult != flag)
			{
				this.CurrentResult = flag;
				TLazyConditionResultCallback resultCallback = this.ResultCallback;
				if (resultCallback == null)
				{
					return;
				}
				resultCallback(this.CurrentResult, this.ConditionPayloadId);
			}
		}

		// Token: 0x06028F69 RID: 167785 RVA: 0x00B7F50C File Offset: 0x00B7D70C
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
					this.AttributeComp.RemoveListener((EAttributeType)attributeListenerHandle.Id, attributeListenerHandle.Callback);
				}
				this.AttributeListenerHandles.Clear();
			}
			foreach (InputListenerHandle inputListenerHandle in this.InputListenerHandles)
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit(inputListenerHandle.ActionName, inputListenerHandle.Callback);
			}
			this.InputListenerHandles.Clear();
			if (this.Entity != null)
			{
				if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead)))
				{
					EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
				}
				if (EventSystem.Instance.HasWithTarget(this.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd)))
				{
					EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
				}
			}
			if (EventSystem.Instance.Has(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModeChanged)))
			{
				EventSystem.Instance.Remove(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnCameraModeChanged));
			}
			this.EntityEventToIndexMap.Clear();
			this.BooleanListSolver = null;
			this.LazyConditionList.Clear();
			this.ConditionResultList.Clear();
		}

		// Token: 0x0401643C RID: 91196
		[Nullable(2)]
		protected BaseTagComponent TagComp;

		// Token: 0x0401643D RID: 91197
		[Nullable(2)]
		protected BaseAttributeComponent AttributeComp;

		// Token: 0x0401643E RID: 91198
		[Nullable(2)]
		protected Entity Entity;

		// Token: 0x0401643F RID: 91199
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x04016440 RID: 91200
		private readonly List<AttributeListenerHandle> AttributeListenerHandles = new List<AttributeListenerHandle>();

		// Token: 0x04016441 RID: 91201
		private readonly List<InputListenerHandle> InputListenerHandles = new List<InputListenerHandle>();

		// Token: 0x04016442 RID: 91202
		private readonly Dictionary<ELazyConditionEventName, int> EntityEventToIndexMap = new Dictionary<ELazyConditionEventName, int>();

		// Token: 0x04016443 RID: 91203
		private readonly List<CfgLazyConditionBase> LazyConditionList = new List<CfgLazyConditionBase>();

		// Token: 0x04016444 RID: 91204
		protected string ConditionFormula = string.Empty;

		// Token: 0x04016445 RID: 91205
		protected int ConditionPayloadId;

		// Token: 0x04016446 RID: 91206
		[Nullable(2)]
		private readonly TLazyConditionResultCallback ResultCallback;

		// Token: 0x04016447 RID: 91207
		protected readonly List<bool> ConditionResultList = new List<bool>();

		// Token: 0x04016448 RID: 91208
		protected bool CurrentResult;

		// Token: 0x04016449 RID: 91209
		[Nullable(2)]
		protected ConditionArray BooleanListSolver;
	}
}
