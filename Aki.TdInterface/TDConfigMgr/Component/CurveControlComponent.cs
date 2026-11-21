using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004E RID: 78
	public class CurveControlComponent : IComponentBase
	{
		// Token: 0x0600028C RID: 652 RVA: 0x0001A410 File Offset: 0x00018610
		private CurveControlComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CurveControlComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CurveControlComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CurveControlComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001A448 File Offset: 0x00018648
		public static CurveControlComponent Create([Nullable(2)] CurveControlComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CurveControlComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001A45B File Offset: 0x0001865B
		public static CurveControlComponent CreateFromSetValue([Nullable(2)] CurveControlComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CurveControlComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001A46E File Offset: 0x0001866E
		public new CurveControlComponent_SetValue ToSetValue()
		{
			return new CurveControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				CurveControlConfig = this.CurveControlConfig
			};
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001A49C File Offset: 0x0001869C
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0001A4D6 File Offset: 0x000186D6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CurveControlComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0001A4E4 File Offset: 0x000186E4
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0001A50E File Offset: 0x0001870E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0001A51C File Offset: 0x0001871C
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0001A57D File Offset: 0x0001877D
		[Nullable(2)]
		public virtual IChargeSlashControl CurveControlConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._CurveControlConfigInited)
				{
					return this._CurveControlConfigCache;
				}
				this._CurveControlConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CurveControlConfigCache = IChargeSlashControl.Create(this.FbInstance.CurveControlConfig);
				}
				else
				{
					CurveControlComponent_SetValue pocoInterface = this.PocoInterface;
					this._CurveControlConfigCache = ((pocoInterface != null) ? pocoInterface.CurveControlConfig : null);
				}
				return this._CurveControlConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CurveControlConfig = value;
				this._CurveControlConfigInited = false;
			}
		}

		// Token: 0x04000199 RID: 409
		[Nullable(2)]
		protected new CurveControlComponent FbInstance;

		// Token: 0x0400019A RID: 410
		[Nullable(2)]
		protected new CurveControlComponent_SetValue PocoInterface;

		// Token: 0x0400019B RID: 411
		private IChargeSlashControl _CurveControlConfigCache;

		// Token: 0x0400019C RID: 412
		private bool _CurveControlConfigInited;
	}
}
