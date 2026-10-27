using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001F3 RID: 499
	[NullableContext(1)]
	[Nullable(0)]
	public class IBeamLayoutConfigWall : IBeamLayoutConfig
	{
		// Token: 0x06000826 RID: 2086 RVA: 0x0002643C File Offset: 0x0002463C
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

		// Token: 0x06000827 RID: 2087 RVA: 0x00026474 File Offset: 0x00024674
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

		// Token: 0x06000828 RID: 2088 RVA: 0x00026487 File Offset: 0x00024687
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

		// Token: 0x06000829 RID: 2089 RVA: 0x0002649A File Offset: 0x0002469A
		public new IBeamLayoutConfigWall_SetValue ToSetValue()
		{
			return new IBeamLayoutConfigWall_SetValue
			{
				Type = this.Type,
				Count = this.Count,
				Distance = this.Distance
			};
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000264C5 File Offset: 0x000246C5
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x000264F0 File Offset: 0x000246F0
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000264FE File Offset: 0x000246FE
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00026529 File Offset: 0x00024729
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00026537 File Offset: 0x00024737
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00026566 File Offset: 0x00024766
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

		// Token: 0x040008FE RID: 2302
		[Nullable(2)]
		protected new IBeamLayoutConfigWall FbInstance;

		// Token: 0x040008FF RID: 2303
		[Nullable(2)]
		protected new IBeamLayoutConfigWall_SetValue PocoInterface;
	}
}
