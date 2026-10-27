using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007153 RID: 29011
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalThunder : PeriodExecution
	{
		// Token: 0x06046D38 RID: 290104 RVA: 0x011D980B File Offset: 0x011D7A0B
		public AbnormalThunder(RequireAndLimits requireAndLimits) : base(requireAndLimits)
		{
		}

		// Token: 0x06046D39 RID: 290105 RVA: 0x011D9814 File Offset: 0x011D7A14
		protected override void InitParameters(ExtraEffectParameters parameters)
		{
			if (parameters.ExtraEffectParameters_ == null)
			{
				return;
			}
			this.ReductionRateThunder = float.Parse(parameters.ExtraEffectParameters_.ElementAtOrDefault(0) ?? "0") * 0.0001f;
			this.ReductionRateExplode = float.Parse(parameters.ExtraEffectParameters_.ElementAtOrDefault(1) ?? "0") * 0.0001f;
			this.ExplodeBuffId = long.Parse(parameters.ExtraEffectParameters_.ElementAtOrDefault(2) ?? "0");
			this.ExecuteAddBuffId = long.Parse(parameters.ExtraEffectParameters_.ElementAtOrDefault(5) ?? "0");
		}

		// Token: 0x06046D3A RID: 290106 RVA: 0x011D98B8 File Offset: 0x011D7AB8
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

		// Token: 0x06046D3B RID: 290107 RVA: 0x011D99DC File Offset: 0x011D7BDC
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

		// Token: 0x040252C0 RID: 152256
		protected float ReductionRateThunder;

		// Token: 0x040252C1 RID: 152257
		protected float ReductionRateExplode;

		// Token: 0x040252C2 RID: 152258
		protected long ExplodeBuffId;

		// Token: 0x040252C3 RID: 152259
		protected long ExecuteAddBuffId;
	}
}
