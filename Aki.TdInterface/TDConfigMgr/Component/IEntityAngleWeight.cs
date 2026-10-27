using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000309 RID: 777
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityAngleWeight
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x00035864 File Offset: 0x00033A64
		private IEntityAngleWeight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityAngleWeight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityAngleWeight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityAngleWeight_SetValue());
			}
			return result;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0003589C File Offset: 0x00033A9C
		public static IEntityAngleWeight Create([Nullable(2)] IEntityAngleWeight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000358AF File Offset: 0x00033AAF
		public static IEntityAngleWeight CreateFromSetValue([Nullable(2)] IEntityAngleWeight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityAngleWeight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000358C2 File Offset: 0x00033AC2
		public IEntityAngleWeight_SetValue ToSetValue()
		{
			return new IEntityAngleWeight_SetValue
			{
				Angle = this.Angle,
				Weight = this.Weight
			};
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000358E1 File Offset: 0x00033AE1
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x0003590C File Offset: 0x00033B0C
		public virtual int Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0003591A File Offset: 0x00033B1A
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00035945 File Offset: 0x00033B45
		public virtual int Weight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Weight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Weight;
			}
			set
			{
				this.GetOrCreatePoco().Weight = value;
			}
		}

		// Token: 0x04000D13 RID: 3347
		[Nullable(2)]
		protected IEntityAngleWeight FbInstance;

		// Token: 0x04000D14 RID: 3348
		[Nullable(2)]
		protected IEntityAngleWeight_SetValue PocoInterface;
	}
}
