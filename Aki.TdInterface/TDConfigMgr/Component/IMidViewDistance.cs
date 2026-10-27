using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F6 RID: 1270
	[NullableContext(1)]
	[Nullable(0)]
	public class IMidViewDistance : IViewDistanceMode
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x0004C190 File Offset: 0x0004A390
		private IMidViewDistance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMidViewDistance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMidViewDistance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMidViewDistance_SetValue());
			}
			return result;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0004C1C8 File Offset: 0x0004A3C8
		public static IMidViewDistance Create([Nullable(2)] IMidViewDistance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0004C1DB File Offset: 0x0004A3DB
		public static IMidViewDistance CreateFromSetValue([Nullable(2)] IMidViewDistance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMidViewDistance
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0004C1EE File Offset: 0x0004A3EE
		public new IMidViewDistance_SetValue ToSetValue()
		{
			return new IMidViewDistance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0004C201 File Offset: 0x0004A401
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0004C22C File Offset: 0x0004A42C
		public override EViewDistanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EViewDistanceType.Low;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040012E7 RID: 4839
		[Nullable(2)]
		protected new IMidViewDistance FbInstance;

		// Token: 0x040012E8 RID: 4840
		[Nullable(2)]
		protected new IMidViewDistance_SetValue PocoInterface;
	}
}
