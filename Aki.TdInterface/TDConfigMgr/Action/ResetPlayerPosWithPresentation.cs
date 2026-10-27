using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002164 RID: 8548
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ResetPlayerPosWithPresentationConverter))]
	public class ResetPlayerPosWithPresentation : ActionParams
	{
		// Token: 0x0600BC10 RID: 48144 RVA: 0x001B1D3C File Offset: 0x001AFF3C
		private ResetPlayerPosWithPresentation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ResetPlayerPosWithPresentation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ResetPlayerPosWithPresentation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ResetPlayerPosWithPresentation_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x001B1D74 File Offset: 0x001AFF74
		public static ResetPlayerPosWithPresentation Create([Nullable(2)] ResetPlayerPosWithPresentation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ResetPlayerPosWithPresentation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x001B1D87 File Offset: 0x001AFF87
		public static ResetPlayerPosWithPresentation CreateFromSetValue([Nullable(2)] ResetPlayerPosWithPresentation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ResetPlayerPosWithPresentation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x001B1D9A File Offset: 0x001AFF9A
		public ResetPlayerPosWithPresentation_SetValue ToSetValue()
		{
			return new ResetPlayerPosWithPresentation_SetValue
			{
				Presentation = this.Presentation,
				ResetPosConfig = this.ResetPosConfig,
				NeedWaitResetPos = this.NeedWaitResetPos
			};
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x001B1DC8 File Offset: 0x001AFFC8
		// (set) Token: 0x0600BC15 RID: 48149 RVA: 0x001B1E29 File Offset: 0x001B0029
		public virtual IResetPresentationFailure Presentation
		{
			get
			{
				if (this._PresentationInited)
				{
					return this._PresentationCache;
				}
				this._PresentationInited = true;
				if (this.FbInstance != null)
				{
					this._PresentationCache = IResetPresentationFailure.Create(this.FbInstance.Presentation);
				}
				else
				{
					ResetPlayerPosWithPresentation_SetValue pocoInterface = this.PocoInterface;
					this._PresentationCache = ((pocoInterface != null) ? pocoInterface.Presentation : null);
				}
				return this._PresentationCache;
			}
			set
			{
				this.GetOrCreatePoco().Presentation = value;
				this._PresentationInited = false;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x001B1E3E File Offset: 0x001B003E
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x001B1E65 File Offset: 0x001B0065
		public virtual IResetPosType ResetPosConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetPosConfig;
				}
				ResetPlayerPosWithPresentation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ResetPosConfig;
			}
			set
			{
				this.GetOrCreatePoco().ResetPosConfig = value;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x001B1E74 File Offset: 0x001B0074
		// (set) Token: 0x0600BC19 RID: 48153 RVA: 0x001B1EAE File Offset: 0x001B00AE
		public virtual bool? NeedWaitResetPos
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NeedWaitResetPos;
				}
				ResetPlayerPosWithPresentation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NeedWaitResetPos;
			}
			set
			{
				this.GetOrCreatePoco().NeedWaitResetPos = value;
			}
		}

		// Token: 0x0400705B RID: 28763
		[Nullable(2)]
		protected new ResetPlayerPosWithPresentation FbInstance;

		// Token: 0x0400705C RID: 28764
		[Nullable(2)]
		protected ResetPlayerPosWithPresentation_SetValue PocoInterface;

		// Token: 0x0400705D RID: 28765
		private IResetPresentationFailure _PresentationCache;

		// Token: 0x0400705E RID: 28766
		private bool _PresentationInited;
	}
}
