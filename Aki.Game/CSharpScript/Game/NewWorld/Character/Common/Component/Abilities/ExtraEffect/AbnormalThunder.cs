using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006381 RID: 25473
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalThunder : PeriodExecution
	{
		// Token: 0x0603DB92 RID: 252818 RVA: 0x011E29BF File Offset: 0x011E0BBF
		public AbnormalThunder(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x0603DB93 RID: 252819 RVA: 0x011E29C8 File Offset: 0x011E0BC8
		protected override void InitParameters(ExtraEffectParameters parameters)
		{
			if (parameters.ExtraEffectParameters_ == null)
			{
				return;
			}
			this.ReductionRateThunder = float.Parse(((parameters.ExtraEffectParameters_.Length != 0) ? parameters.ExtraEffectParameters_[0] : null) ?? "0") * 0.0001f;
			this.ReductionRateExplode = float.Parse(((parameters.ExtraEffectParameters_.Length > 1) ? parameters.ExtraEffectParameters_[1] : null) ?? "0") * 0.0001f;
			this.ExplodeBuffId = long.Parse(((parameters.ExtraEffectParameters_.Length > 2) ? parameters.ExtraEffectParameters_[2] : null) ?? "0");
			this.ExecuteAddBuffId = long.Parse(((parameters.ExtraEffectParameters_.Length > 5) ? parameters.ExtraEffectParameters_[5] : null) ?? "0");
		}

		// Token: 0x0603DB94 RID: 252820 RVA: 0x011E2A90 File Offset: 0x011E0C90
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			base.BuffEffectExecutePush();
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			BaseTagComponent tagComponent = ownerBuffComponent.GetTagComponent();
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["战斗状态.异常状态.基础元素异常.屏蔽消层.电磁效应"]))
			{
				int num = (int)Math.Ceiling((double)((float)this.Buff.StackCount * this.ReductionRateThunder));
				if (num > 0)
				{
					ownerBuffComponent.RemoveBuff(this.BuffId, num, "电磁效应触发时移除buff", null, null, null);
				}
			}
			ActiveBuffInternal buffById = ownerBuffComponent.GetBuffById(this.ExplodeBuffId);
			if (buffById != null)
			{
				int stackCount = (int)Math.Ceiling((double)((float)buffById.StackCount * this.ReductionRateExplode));
				ownerBuffComponent.RemoveBuff(this.ExplodeBuffId, stackCount, "电磁效应触发时移除buff", null, null, null);
			}
			if (this.ExecuteAddBuffId > 0L)
			{
				IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
				if (ownerBuffComponent2 != null)
				{
					ownerBuffComponent2.AddIterativeBuff(this.ExecuteAddBuffId, this.Buff, null, true, "电磁效应触发时buff添加", null, null);
				}
			}
			return null;
		}

		// Token: 0x0603DB95 RID: 252821 RVA: 0x011E2BB4 File Offset: 0x011E0DB4
		protected override void DoBuffStackOverflow(int oldStack, int newStack, int stackLimitMax)
		{
			int num = newStack - stackLimitMax;
			if (num > 0 && this.ExplodeBuffId > 0L)
			{
				IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
				if (ownerBuffComponent == null)
				{
					return;
				}
				ownerBuffComponent.AddIterativeBuff(this.ExplodeBuffId, this.Buff, new int?(num), true, "电磁效应叠层溢出添加", null, null);
			}
		}

		// Token: 0x04020BA3 RID: 134051
		protected float ReductionRateThunder;

		// Token: 0x04020BA4 RID: 134052
		protected float ReductionRateExplode;

		// Token: 0x04020BA5 RID: 134053
		protected long ExplodeBuffId;

		// Token: 0x04020BA6 RID: 134054
		protected long ExecuteAddBuffId;
	}
}
