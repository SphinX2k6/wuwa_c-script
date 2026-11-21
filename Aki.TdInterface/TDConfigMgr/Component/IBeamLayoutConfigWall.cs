using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200021C RID: 540
	public class IBeamLayoutConfigWall : IBeamLayoutConfig
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x00027D90 File Offset: 0x00025F90
		private IBeamLayoutConfigWall_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBeamLayoutConfigWall 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBeamLayoutConfigWall_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBeamLayoutConfigWall_SetValue());
			}
			return result;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00027DC8 File Offset: 0x00025FC8
		public static IBeamLayoutConfigWall Create([Nullable(2)] IBeamLayoutConfigWall instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfigWall
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00027DDB File Offset: 0x00025FDB
		public static IBeamLayoutConfigWall CreateFromSetValue([Nullable(2)] IBeamLayoutConfigWall_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBeamLayoutConfigWall
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00027DEE File Offset: 0x00025FEE
		public new IBeamLayoutConfigWall_SetValue ToSetValue()
		{
			return new IBeamLayoutConfigWall_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				Distance = this.Distance
			};
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00027E19 File Offset: 0x00026019
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00027E44 File Offset: 0x00026044
		public override EBeamLayoutType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBeamLayoutType.BeamWall;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00027E52 File Offset: 0x00026052
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00027E7D File Offset: 0x0002607D
		public virtual int Count
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Count;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Count;
			}
			set
			{
				this.GetOrCreatePoco().Count = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x00027E8B File Offset: 0x0002608B
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00027EBA File Offset: 0x000260BA
		public virtual float Distance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Distance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Distance;
			}
			set
			{
				this.GetOrCreatePoco().Distance = value;
			}
		}

		// Token: 0x0400098F RID: 2447
		[Nullable(2)]
		protected new IBeamLayoutConfigWall FbInstance;

		// Token: 0x04000990 RID: 2448
		[Nullable(2)]
		protected new IBeamLayoutConfigWall_SetValue PocoInterface;
	}
}
