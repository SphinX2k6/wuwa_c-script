using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E8 RID: 2280
	[NullableContext(1)]
	[Nullable(0)]
	public class WindSourceComponent : IComponentBase
	{
		// Token: 0x060033BD RID: 13245 RVA: 0x00084674 File Offset: 0x00082874
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

		// Token: 0x060033BE RID: 13246 RVA: 0x000846AC File Offset: 0x000828AC
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

		// Token: 0x060033BF RID: 13247 RVA: 0x000846BF File Offset: 0x000828BF
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

		// Token: 0x060033C0 RID: 13248 RVA: 0x000846D2 File Offset: 0x000828D2
		public new WindSourceComponent_SetValue ToSetValue()
		{
			return new WindSourceComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WindSource = this.WindSource
			};
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x00084700 File Offset: 0x00082900
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x0008473A File Offset: 0x0008293A
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

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x00084748 File Offset: 0x00082948
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x00084772 File Offset: 0x00082972
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

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x00084780 File Offset: 0x00082980
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x000847E1 File Offset: 0x000829E1
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

		// Token: 0x040021DF RID: 8671
		[Nullable(2)]
		protected new WindSourceComponent FbInstance;

		// Token: 0x040021E0 RID: 8672
		[Nullable(2)]
		protected new WindSourceComponent_SetValue PocoInterface;

		// Token: 0x040021E1 RID: 8673
		private IWindDirectional _WindSourceCache;

		// Token: 0x040021E2 RID: 8674
		private bool _WindSourceInited;
	}
}
