using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098D RID: 2445
	public class WindSourceComponent : IComponentBase
	{
		// Token: 0x06003705 RID: 14085 RVA: 0x0008BCB0 File Offset: 0x00089EB0
		private WindSourceComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("WindSourceComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			WindSourceComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new WindSourceComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0008BCE8 File Offset: 0x00089EE8
		public static WindSourceComponent Create([Nullable(2)] WindSourceComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WindSourceComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0008BCFB File Offset: 0x00089EFB
		public static WindSourceComponent CreateFromSetValue([Nullable(2)] WindSourceComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new WindSourceComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0008BD0E File Offset: 0x00089F0E
		public new WindSourceComponent_SetValue ToSetValue()
		{
			return new WindSourceComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WindSource = this.WindSource
			};
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x0008BD3C File Offset: 0x00089F3C
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x0008BD76 File Offset: 0x00089F76
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				WindSourceComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x0008BD84 File Offset: 0x00089F84
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0008BDAE File Offset: 0x00089FAE
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

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0008BDBC File Offset: 0x00089FBC
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x0008BE1D File Offset: 0x0008A01D
		public virtual IWindDirectional WindSource
		{
			get
			{
				if (this._WindSourceInited)
				{
					return this._WindSourceCache;
				}
				this._WindSourceInited = true;
				if (this.FbInstance != null)
				{
					this._WindSourceCache = IWindDirectional.Create(this.FbInstance.WindSource);
				}
				else
				{
					WindSourceComponent_SetValue pocoInterface = this.PocoInterface;
					this._WindSourceCache = ((pocoInterface != null) ? pocoInterface.WindSource : null);
				}
				return this._WindSourceCache;
			}
			set
			{
				this.GetOrCreatePoco().WindSource = value;
				this._WindSourceInited = false;
			}
		}

		// Token: 0x040023F6 RID: 9206
		[Nullable(2)]
		protected new WindSourceComponent FbInstance;

		// Token: 0x040023F7 RID: 9207
		[Nullable(2)]
		protected new WindSourceComponent_SetValue PocoInterface;

		// Token: 0x040023F8 RID: 9208
		private IWindDirectional _WindSourceCache;

		// Token: 0x040023F9 RID: 9209
		private bool _WindSourceInited;
	}
}
