using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004C8 RID: 1224
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftFloorSeqMark
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0004A148 File Offset: 0x00048348
		private ILiftFloorSeqMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftFloorSeqMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftFloorSeqMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftFloorSeqMark_SetValue());
			}
			return result;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0004A180 File Offset: 0x00048380
		public static ILiftFloorSeqMark Create([Nullable(2)] ILiftFloorSeqMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftFloorSeqMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0004A193 File Offset: 0x00048393
		public static ILiftFloorSeqMark CreateFromSetValue([Nullable(2)] ILiftFloorSeqMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftFloorSeqMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0004A1A6 File Offset: 0x000483A6
		public ILiftFloorSeqMark_SetValue ToSetValue()
		{
			return new ILiftFloorSeqMark_SetValue
			{
				Floor = this.Floor,
				Mark = this.Mark
			};
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x0004A1C5 File Offset: 0x000483C5
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x0004A1F0 File Offset: 0x000483F0
		public virtual int Floor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Floor;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Floor;
			}
			set
			{
				this.GetOrCreatePoco().Floor = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0004A1FE File Offset: 0x000483FE
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x0004A229 File Offset: 0x00048429
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x04001261 RID: 4705
		[Nullable(2)]
		protected ILiftFloorSeqMark FbInstance;

		// Token: 0x04001262 RID: 4706
		[Nullable(2)]
		protected ILiftFloorSeqMark_SetValue PocoInterface;
	}
}
