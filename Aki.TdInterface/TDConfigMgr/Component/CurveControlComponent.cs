using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004E RID: 78
	[NullableContext(1)]
	[Nullable(0)]
	public class CurveControlComponent : IComponentBase
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00019A9C File Offset: 0x00017C9C
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

		// Token: 0x06000289 RID: 649 RVA: 0x00019AD4 File Offset: 0x00017CD4
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

		// Token: 0x0600028A RID: 650 RVA: 0x00019AE7 File Offset: 0x00017CE7
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

		// Token: 0x0600028B RID: 651 RVA: 0x00019AFA File Offset: 0x00017CFA
		public new CurveControlComponent_SetValue ToSetValue()
		{
			return new CurveControlComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				CurveControlConfig = this.CurveControlConfig
			};
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00019B28 File Offset: 0x00017D28
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00019B62 File Offset: 0x00017D62
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00019B70 File Offset: 0x00017D70
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00019B9A File Offset: 0x00017D9A
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00019BA8 File Offset: 0x00017DA8
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00019C09 File Offset: 0x00017E09
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

		// Token: 0x04000194 RID: 404
		[Nullable(2)]
		protected new CurveControlComponent FbInstance;

		// Token: 0x04000195 RID: 405
		[Nullable(2)]
		protected new CurveControlComponent_SetValue PocoInterface;

		// Token: 0x04000196 RID: 406
		private IChargeSlashControl _CurveControlConfigCache;

		// Token: 0x04000197 RID: 407
		private bool _CurveControlConfigInited;
	}
}
