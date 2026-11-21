using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D2 RID: 466
	public class IAirWallBothSidesStyle : IAirWallSpawnStyle
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x00024F00 File Offset: 0x00023100
		private IAirWallBothSidesStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAirWallBothSidesStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAirWallBothSidesStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAirWallBothSidesStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00024F38 File Offset: 0x00023138
		public static IAirWallBothSidesStyle Create([Nullable(2)] IAirWallBothSidesStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallBothSidesStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00024F4B File Offset: 0x0002314B
		public static IAirWallBothSidesStyle CreateFromSetValue([Nullable(2)] IAirWallBothSidesStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAirWallBothSidesStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00024F5E File Offset: 0x0002315E
		public new IAirWallBothSidesStyle_SetValue ToSetValue()
		{
			return new IAirWallBothSidesStyle_SetValue
			{
				Type = this.Type,
				GapWidth = this.GapWidth
			};
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00024F7D File Offset: 0x0002317D
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00024FA8 File Offset: 0x000231A8
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00024FB6 File Offset: 0x000231B6
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00024FE5 File Offset: 0x000231E5
		public virtual float GapWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GapWidth;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.GapWidth;
			}
			set
			{
				this.GetOrCreatePoco().GapWidth = value;
			}
		}

		// Token: 0x040008C4 RID: 2244
		[Nullable(2)]
		protected new IAirWallBothSidesStyle FbInstance;

		// Token: 0x040008C5 RID: 2245
		[Nullable(2)]
		protected new IAirWallBothSidesStyle_SetValue PocoInterface;
	}
}
