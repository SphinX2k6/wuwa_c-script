using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F76 RID: 20342
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillInstance
	{
		// Token: 0x06034190 RID: 213392 RVA: 0x00C39DD4 File Offset: 0x00C37FD4
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

		// Token: 0x06034191 RID: 213393 RVA: 0x00C39ED8 File Offset: 0x00C380D8
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

		// Token: 0x06034192 RID: 213394 RVA: 0x00C39F16 File Offset: 0x00C38116
		public void Clear()
		{
			this.OnCheckSkillCanUseSet.Clear();
			this.UnRegisterSkillCanUseListener();
		}

		// Token: 0x06034193 RID: 213395 RVA: 0x00C39F29 File Offset: 0x00C38129
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

		// Token: 0x06034194 RID: 213396 RVA: 0x00C39F67 File Offset: 0x00C38167
		public void UnRegisterSkillCanUseListener()
		{
			if (!this.IsRegisterConditionListener)
			{
				return;
			}
			this.IsRegisterConditionListener = false;
			QuickHackModel.Instance.ConditionHelper.UnRegisterConditionsListener(this.ConditionMap.Keys, new GenericEventHandler(this.OnReceiveConditionEvent));
		}

		// Token: 0x06034195 RID: 213397 RVA: 0x00C39F9F File Offset: 0x00C3819F
		public QuickHackSkill GetConfig()
		{
			return this.Config.Value;
		}

		// Token: 0x06034196 RID: 213398 RVA: 0x00C39FAC File Offset: 0x00C381AC
		public int GetUsageCount()
		{
			return this.UsageCount;
		}

		// Token: 0x06034197 RID: 213399 RVA: 0x00C39FB4 File Offset: 0x00C381B4
		public void ReduceUsageCount()
		{
			if (this.UsageCount > 0)
			{
				this.UsageCount--;
				this.CheckSkillCanUse();
			}
		}

		// Token: 0x06034198 RID: 213400 RVA: 0x00C39FD3 File Offset: 0x00C381D3
		public QuickHackSkillConditionResult GetSkillCanUseInfo()
		{
			return this.CanUseResult;
		}

		// Token: 0x06034199 RID: 213401 RVA: 0x00C39FDC File Offset: 0x00C381DC
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

		// Token: 0x0603419A RID: 213402 RVA: 0x00C3A060 File Offset: 0x00C38260
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

		// Token: 0x0603419B RID: 213403 RVA: 0x00C3A108 File Offset: 0x00C38308
		private void OnReceiveConditionEvent(params object[] args)
		{
			this.CheckSkillCanUse();
		}

		// Token: 0x0603419C RID: 213404 RVA: 0x00C3A110 File Offset: 0x00C38310
		public void RegisterOnCheckSkillCanUse(Action<QuickHackSkillConditionResult> onCheckSkillCanUse)
		{
			this.OnCheckSkillCanUseSet.Add(onCheckSkillCanUse);
		}

		// Token: 0x0603419D RID: 213405 RVA: 0x00C3A11F File Offset: 0x00C3831F
		public void UnRegisterOnCheckSkillCanUse(Action<QuickHackSkillConditionResult> onCheckSkillCanUse)
		{
			this.OnCheckSkillCanUseSet.Remove(onCheckSkillCanUse);
		}

		// Token: 0x0401BB39 RID: 113465
		private QuickHackSkill? Config;

		// Token: 0x0401BB3A RID: 113466
		private readonly Dictionary<EQuickHackSkillCondition, QuickHackConditionInfo> ConditionMap = new Dictionary<EQuickHackSkillCondition, QuickHackConditionInfo>();

		// Token: 0x0401BB3B RID: 113467
		private readonly List<QuickHackConditionInfo> ConditionInfos = new List<QuickHackConditionInfo>();

		// Token: 0x0401BB3C RID: 113468
		private readonly List<QuickHackConditionInfo> TargetConditionInfos = new List<QuickHackConditionInfo>();

		// Token: 0x0401BB3D RID: 113469
		private int UsageCount = -1;

		// Token: 0x0401BB3E RID: 113470
		[Nullable(2)]
		private QuickHackSkillConditionResult CanUseResult;

		// Token: 0x0401BB3F RID: 113471
		private readonly HashSet<Action<QuickHackSkillConditionResult>> OnCheckSkillCanUseSet = new HashSet<Action<QuickHackSkillConditionResult>>();

		// Token: 0x0401BB40 RID: 113472
		private bool IsRegisterConditionListener;

		// Token: 0x0401BB41 RID: 113473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<EntityHandle> TargetArray;
	}
}
