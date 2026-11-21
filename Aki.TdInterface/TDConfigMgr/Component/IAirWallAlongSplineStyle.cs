using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D0 RID: 464
	public class IAirWallAlongSplineStyle : IAirWallSpawnStyle
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00024D7C File Offset: 0x00022F7C
		private IAirWallAlongSplineStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallAlongSplineStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallAlongSplineStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallAlongSplineStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00024DB4 File Offset: 0x00022FB4
		public static IAirWallAlongSplineStyle Create([Nullable(2)] IAirWallAlongSplineStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallAlongSplineStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00024DC7 File Offset: 0x00022FC7
		public static IAirWallAlongSplineStyle CreateFromSetValue([Nullable(2)] IAirWallAlongSplineStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallAlongSplineStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00024DDA File Offset: 0x00022FDA
		public new IAirWallAlongSplineStyle_SetValue ToSetValue()
		{
			return new IAirWallAlongSplineStyle_SetValue
			{
				Type = this.Type,
				AlignType = this.AlignType,
				Cover = this.Cover
			};
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00024E05 File Offset: 0x00023005
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00024E30 File Offset: 0x00023030
		public override EAirWallSpawnStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallSpawnStyle.AlongSpline;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00024E3E File Offset: 0x0002303E
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00024E69 File Offset: 0x00023069
		public virtual EAirWallAlignType AlignType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AlignType;
				}
				if (this.PocoInterface == null)
				{
					return EAirWallAlignType.Center;
				}
				return this.PocoInterface.AlignType;
			}
			set
			{
				this.GetOrCreatePoco().AlignType = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00024E78 File Offset: 0x00023078
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00024ED9 File Offset: 0x000230D9
		[Nullable(2)]
		public virtual IAirWallCover Cover
		{
			[NullableContext(2)]
			get
			{
				if (this._CoverInited)
				{
					return this._CoverCache;
				}
				this._CoverInited = true;
				if (this.FbInstance != null)
				{
					this._CoverCache = IAirWallCover.Create(this.FbInstance.Cover);
				}
				else
				{
					IAirWallAlongSplineStyle_SetValue pocoInterface = this.PocoInterface;
					this._CoverCache = ((pocoInterface != null) ? pocoInterface.Cover : null);
				}
				return this._CoverCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Cover = value;
				this._CoverInited = false;
			}
		}

		// Token: 0x040008BD RID: 2237
		[Nullable(2)]
		protected new IAirWallAlongSplineStyle FbInstance;

		// Token: 0x040008BE RID: 2238
		[Nullable(2)]
		protected new IAirWallAlongSplineStyle_SetValue PocoInterface;

		// Token: 0x040008BF RID: 2239
		private IAirWallCover _CoverCache;

		// Token: 0x040008C0 RID: 2240
		private bool _CoverInited;
	}
}
