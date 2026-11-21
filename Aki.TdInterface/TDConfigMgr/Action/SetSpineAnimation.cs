using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002445 RID: 9285
	public class SetSpineAnimation : ActionParams
	{
		// Token: 0x0600CA2B RID: 51755 RVA: 0x001CDDB4 File Offset: 0x001CBFB4
		private SetSpineAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSpineAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSpineAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSpineAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x001CDDEC File Offset: 0x001CBFEC
		public static SetSpineAnimation Create([Nullable(2)] SetSpineAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSpineAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x001CDDFF File Offset: 0x001CBFFF
		public static SetSpineAnimation CreateFromSetValue([Nullable(2)] SetSpineAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSpineAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x001CDE12 File Offset: 0x001CC012
		public SetSpineAnimation_SetValue ToSetValue()
		{
			return new SetSpineAnimation_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600CA2F RID: 51759 RVA: 0x001CDE28 File Offset: 0x001CC028
		// (set) Token: 0x0600CA30 RID: 51760 RVA: 0x001CDE89 File Offset: 0x001CC089
		public virtual IPlaySpineAnimation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IPlaySpineAnimation.Create(this.FbInstance.Config);
				}
				else
				{
					SetSpineAnimation_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x040077EF RID: 30703
		[Nullable(2)]
		protected new SetSpineAnimation FbInstance;

		// Token: 0x040077F0 RID: 30704
		[Nullable(2)]
		protected SetSpineAnimation_SetValue PocoInterface;

		// Token: 0x040077F1 RID: 30705
		private IPlaySpineAnimation _ConfigCache;

		// Token: 0x040077F2 RID: 30706
		private bool _ConfigInited;
	}
}
