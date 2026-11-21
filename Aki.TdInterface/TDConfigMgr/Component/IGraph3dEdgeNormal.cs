using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000437 RID: 1079
	public class IGraph3dEdgeNormal : IGraph3dEdgeBase
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x00043FD0 File Offset: 0x000421D0
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

		// Token: 0x06001582 RID: 5506 RVA: 0x00044008 File Offset: 0x00042208
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

		// Token: 0x06001583 RID: 5507 RVA: 0x0004401B File Offset: 0x0004221B
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

		// Token: 0x06001584 RID: 5508 RVA: 0x0004402E File Offset: 0x0004222E
		public new IGraph3dEdgeNormal_SetValue ToSetValue()
		{
			return new IGraph3dEdgeNormal_SetValue
			{
				Id = this.Id,
				From = this.From,
				To = this.To
			};
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00044059 File Offset: 0x00042259
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x00044084 File Offset: 0x00042284
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00044092 File Offset: 0x00042292
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x000440BD File Offset: 0x000422BD
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

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x000440CB File Offset: 0x000422CB
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x000440F6 File Offset: 0x000422F6
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

		// Token: 0x040010E5 RID: 4325
		[Nullable(2)]
		protected new IGraph3dEdgeNormal FbInstance;

		// Token: 0x040010E6 RID: 4326
		[Nullable(2)]
		protected new IGraph3dEdgeNormal_SetValue PocoInterface;
	}
}
