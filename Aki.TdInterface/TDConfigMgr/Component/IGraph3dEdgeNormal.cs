using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DE RID: 990
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dEdgeNormal : IGraph3dEdgeBase
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x00040288 File Offset: 0x0003E488
		private IGraph3dEdgeNormal_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dEdgeNormal 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dEdgeNormal_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dEdgeNormal_SetValue());
			}
			return result;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000402C0 File Offset: 0x0003E4C0
		public static IGraph3dEdgeNormal Create([Nullable(2)] IGraph3dEdgeNormal instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEdgeNormal
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000402D3 File Offset: 0x0003E4D3
		public static IGraph3dEdgeNormal CreateFromSetValue([Nullable(2)] IGraph3dEdgeNormal_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dEdgeNormal
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000402E6 File Offset: 0x0003E4E6
		public new IGraph3dEdgeNormal_SetValue ToSetValue()
		{
			return new IGraph3dEdgeNormal_SetValue
			{
				Id = this.Id,
				From = this.From,
				To = this.To
			};
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00040311 File Offset: 0x0003E511
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0004033C File Offset: 0x0003E53C
		public override int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0004034A File Offset: 0x0003E54A
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x00040375 File Offset: 0x0003E575
		public override int From
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.From;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.From;
			}
			set
			{
				this.GetOrCreatePoco().From = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00040383 File Offset: 0x0003E583
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x000403AE File Offset: 0x0003E5AE
		public override int To
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.To;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.To;
			}
			set
			{
				this.GetOrCreatePoco().To = value;
			}
		}

		// Token: 0x04000FC3 RID: 4035
		[Nullable(2)]
		protected new IGraph3dEdgeNormal FbInstance;

		// Token: 0x04000FC4 RID: 4036
		[Nullable(2)]
		protected new IGraph3dEdgeNormal_SetValue PocoInterface;
	}
}
