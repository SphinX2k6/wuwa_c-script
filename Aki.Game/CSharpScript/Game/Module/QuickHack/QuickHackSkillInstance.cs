using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F3F RID: 16191
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillInstance
	{
		// Token: 0x06028FFE RID: 167934 RVA: 0x00B83580 File Offset: 0x00B81780
		public void Init(QuickHackSkill config)
		{
			this.Config = new QuickHackSkill?(config);
			int usageCount = config.UsageCount;
			if (usageCount > 0)
			{
				this.UsageCount = usageCount;
				this.AddCondition(EQuickHackSkillCondition.CheckUsageCountEnough, null, 0);
			}
			EQuickHackTargetType targetType = (EQuickHackTargetType)config.TargetType;
			if (targetType == EQuickHackTargetType.SceneItem)
			{
				this.AddCondition(EQuickHackSkillCondition.CheckAnySceneItemCanHack, null, 0);
			}
			this.AddCondition(EQuickHackSkillCondition.CheckTargetTypeMatch, null, 0);
			this.AddCondition(EQuickHackSkillCondition.CheckRamEnough, null, 0);
			string extraConditionType = config.ExtraConditionType;
			if (!StringUtils.IsBlank(extraConditionType))
			{
				this.AddCondition((EQuickHackSkillCondition)Enum.Parse(typeof(EQuickHackSkillCondition), extraConditionType), config.ExtraConditionParamsIter(), config.ExtraConditionParamsLength);
			}
			List<EQuickHackSkillCondition> targetExtraConditions = QuickHackModel.Instance.ConditionHelper.GetTargetExtraConditions(targetType);
			if (targetExtraConditions != null)
			{
				foreach (EQuickHackSkillCondition key in targetExtraConditions)
				{
					QuickHackConditionInfo item;
					if (this.ConditionMap.TryGetValue(key, out item))
					{
						this.TargetConditionInfos.Add(item);
					}
				}
			}
		}

		// Token: 0x06028FFF RID: 167935 RVA: 0x00B83684 File Offset: 0x00B81884
		private void AddCondition(EQuickHackSkillCondition type, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<string> extraParams = null, int paramsLength = 0)
		{
			if (this.ConditionMap.ContainsKey(type))
			{
				return;
			}
			QuickHackConditionInfo quickHackConditionInfo = new QuickHackConditionInfo(type, extraParams, paramsLength);
			this.ConditionMap[type] = quickHackConditionInfo;
			this.ConditionInfos.Add(quickHackConditionInfo);
		}

		// Token: 0x06029000 RID: 167936 RVA: 0x00B836C2 File Offset: 0x00B818C2
		public void Clear()
		{
			this.OnCheckSkillCanUseSet.Clear();
			this.UnRegisterSkillCanUseListener();
		}

		// Token: 0x06029001 RID: 167937 RVA: 0x00B836D5 File Offset: 0x00B818D5
		public void RegisterSkillCanUseListener()
		{
			if (this.IsRegisterConditionListener)
			{
				return;
			}
			this.IsRegisterConditionListener = true;
			this.CheckSkillCanUse();
			QuickHackModel.Instance.ConditionHelper.RegisterConditionsListener(this.ConditionMap.Keys, new GenericEventHandler(this.OnReceiveConditionEvent));
		}

		// Token: 0x06029002 RID: 167938 RVA: 0x00B83713 File Offset: 0x00B81913
		public void UnRegisterSkillCanUseListener()
		{
			if (!this.IsRegisterConditionListener)
			{
				return;
			}
			this.IsRegisterConditionListener = false;
			QuickHackModel.Instance.ConditionHelper.UnRegisterConditionsListener(this.ConditionMap.Keys, new GenericEventHandler(this.OnReceiveConditionEvent));
		}

		// Token: 0x06029003 RID: 167939 RVA: 0x00B8374B File Offset: 0x00B8194B
		public QuickHackSkill GetConfig()
		{
			return this.Config.Value;
		}

		// Token: 0x06029004 RID: 167940 RVA: 0x00B83758 File Offset: 0x00B81958
		public int GetUsageCount()
		{
			return this.UsageCount;
		}

		// Token: 0x06029005 RID: 167941 RVA: 0x00B83760 File Offset: 0x00B81960
		public void ReduceUsageCount()
		{
			if (this.UsageCount > 0)
			{
				this.UsageCount--;
				this.CheckSkillCanUse();
			}
		}

		// Token: 0x06029006 RID: 167942 RVA: 0x00B8377F File Offset: 0x00B8197F
		public QuickHackSkillConditionResult GetSkillCanUseInfo()
		{
			return this.CanUseResult;
		}

		// Token: 0x06029007 RID: 167943 RVA: 0x00B83788 File Offset: 0x00B81988
		public bool CheckTargetExtraConditions(EntityHandle target)
		{
			if (this.TargetConditionInfos.Count <= 0)
			{
				return true;
			}
			if (this.TargetArray != null)
			{
				this.TargetArray.Clear();
			}
			else
			{
				this.TargetArray = new List<EntityHandle>();
			}
			this.TargetArray.Add(target);
			return QuickHackModel.Instance.ConditionHelper.CheckConditions(this.TargetConditionInfos, this, new EQuickHackTargetType?((EQuickHackTargetType)this.Config.Value.TargetType), this.TargetArray).IsSuccess;
		}

		// Token: 0x06029008 RID: 167944 RVA: 0x00B8380C File Offset: 0x00B81A0C
		public void CheckSkillCanUse()
		{
			QuickHackModel instance = QuickHackModel.Instance;
			QuickHackTargetSelector targetSelector = instance.TargetSelector;
			IQuickHackLockTargetInfo quickHackLockTargetInfo = (targetSelector != null) ? targetSelector.GetLockTargetInfo() : null;
			this.CanUseResult = instance.ConditionHelper.CheckConditions(this.ConditionInfos, this, (quickHackLockTargetInfo != null) ? quickHackLockTargetInfo.HackType : null, (quickHackLockTargetInfo != null) ? quickHackLockTargetInfo.Targets : null);
			foreach (Action<QuickHackSkillConditionResult> action in this.OnCheckSkillCanUseSet)
			{
				action(this.CanUseResult);
			}
		}

		// Token: 0x06029009 RID: 167945 RVA: 0x00B838B4 File Offset: 0x00B81AB4
		private void OnReceiveConditionEvent(params object[] args)
		{
			this.CheckSkillCanUse();
		}

		// Token: 0x0602900A RID: 167946 RVA: 0x00B838BC File Offset: 0x00B81ABC
		public void RegisterOnCheckSkillCanUse(Action<QuickHackSkillConditionResult> onCheckSkillCanUse)
		{
			this.OnCheckSkillCanUseSet.Add(onCheckSkillCanUse);
		}

		// Token: 0x0602900B RID: 167947 RVA: 0x00B838CB File Offset: 0x00B81ACB
		public void UnRegisterOnCheckSkillCanUse(Action<QuickHackSkillConditionResult> onCheckSkillCanUse)
		{
			this.OnCheckSkillCanUseSet.Remove(onCheckSkillCanUse);
		}

		// Token: 0x0401650E RID: 91406
		private QuickHackSkill? Config;

		// Token: 0x0401650F RID: 91407
		private readonly Dictionary<EQuickHackSkillCondition, QuickHackConditionInfo> ConditionMap = new Dictionary<EQuickHackSkillCondition, QuickHackConditionInfo>();

		// Token: 0x04016510 RID: 91408
		private readonly List<QuickHackConditionInfo> ConditionInfos = new List<QuickHackConditionInfo>();

		// Token: 0x04016511 RID: 91409
		private readonly List<QuickHackConditionInfo> TargetConditionInfos = new List<QuickHackConditionInfo>();

		// Token: 0x04016512 RID: 91410
		private int UsageCount = -1;

		// Token: 0x04016513 RID: 91411
		[Nullable(2)]
		private QuickHackSkillConditionResult CanUseResult;

		// Token: 0x04016514 RID: 91412
		private readonly HashSet<Action<QuickHackSkillConditionResult>> OnCheckSkillCanUseSet = new HashSet<Action<QuickHackSkillConditionResult>>();

		// Token: 0x04016515 RID: 91413
		private bool IsRegisterConditionListener;

		// Token: 0x04016516 RID: 91414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<EntityHandle> TargetArray;
	}
}
