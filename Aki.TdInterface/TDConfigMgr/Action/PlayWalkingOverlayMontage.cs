using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002121 RID: 8481
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600BAC6 RID: 47814 RVA: 0x001AF9AC File Offset: 0x001ADBAC
		private PlayWalkingOverlayMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayWalkingOverlayMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayWalkingOverlayMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayWalkingOverlayMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x001AF9E4 File Offset: 0x001ADBE4
		public static PlayWalkingOverlayMontage Create([Nullable(2)] PlayWalkingOverlayMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayWalkingOverlayMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x001AF9F7 File Offset: 0x001ADBF7
		public static PlayWalkingOverlayMontage CreateFromSetValue([Nullable(2)] PlayWalkingOverlayMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayWalkingOverlayMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x001AFA0A File Offset: 0x001ADC0A
		public PlayWalkingOverlayMontage_SetValue ToSetValue()
		{
			return new PlayWalkingOverlayMontage_SetValue
			{
				EntityId = this.EntityId,
				OverlapMontageId = this.OverlapMontageId,
				LoopDuration = this.LoopDuration,
				RepeatTimes = this.RepeatTimes
			};
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x001AFA41 File Offset: 0x001ADC41
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x001AFA6C File Offset: 0x001ADC6C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x001AFA7A File Offset: 0x001ADC7A
		// (set) Token: 0x0600BACD RID: 47821 RVA: 0x001AFAA5 File Offset: 0x001ADCA5
		public virtual int OverlapMontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.OverlapMontageId;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600BACE RID: 47822 RVA: 0x001AFAB4 File Offset: 0x001ADCB4
		// (set) Token: 0x0600BACF RID: 47823 RVA: 0x001AFAEE File Offset: 0x001ADCEE
		public virtual float? LoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopDuration;
				}
				PlayWalkingOverlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopDuration;
			}
			set
			{
				this.GetOrCreatePoco().LoopDuration = value;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x001AFAFC File Offset: 0x001ADCFC
		// (set) Token: 0x0600BAD1 RID: 47825 RVA: 0x001AFB36 File Offset: 0x001ADD36
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				PlayWalkingOverlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x04006FCC RID: 28620
		[Nullable(2)]
		protected new PlayWalkingOverlayMontage FbInstance;

		// Token: 0x04006FCD RID: 28621
		[Nullable(2)]
		protected PlayWalkingOverlayMontage_SetValue PocoInterface;
	}
}
