using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C5 RID: 9157
	[JsonConverter(typeof(ResetPlayerPosWithPresentationConverter))]
	public class ResetPlayerPosWithPresentation : ActionParams
	{
		// Token: 0x0600C79E RID: 51102 RVA: 0x001C8EF0 File Offset: 0x001C70F0
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

		// Token: 0x0600C79F RID: 51103 RVA: 0x001C8F28 File Offset: 0x001C7128
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

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x001C8F3B File Offset: 0x001C713B
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

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x001C8F4E File Offset: 0x001C714E
		public ResetPlayerPosWithPresentation_SetValue ToSetValue()
		{
			return new ResetPlayerPosWithPresentation_SetValue
			{
				Presentation = this.Presentation,
				ResetPosConfig = this.ResetPosConfig,
				NeedWaitResetPos = this.NeedWaitResetPos
			};
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x001C8F7C File Offset: 0x001C717C
		// (set) Token: 0x0600C7A3 RID: 51107 RVA: 0x001C8FDD File Offset: 0x001C71DD
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

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600C7A4 RID: 51108 RVA: 0x001C8FF2 File Offset: 0x001C71F2
		// (set) Token: 0x0600C7A5 RID: 51109 RVA: 0x001C9019 File Offset: 0x001C7219
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

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x001C9028 File Offset: 0x001C7228
		// (set) Token: 0x0600C7A7 RID: 51111 RVA: 0x001C9062 File Offset: 0x001C7262
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

		// Token: 0x04007690 RID: 30352
		[Nullable(2)]
		protected new ResetPlayerPosWithPresentation FbInstance;

		// Token: 0x04007691 RID: 30353
		[Nullable(2)]
		protected ResetPlayerPosWithPresentation_SetValue PocoInterface;

		// Token: 0x04007692 RID: 30354
		private IResetPresentationFailure _PresentationCache;

		// Token: 0x04007693 RID: 30355
		private bool _PresentationInited;
	}
}
