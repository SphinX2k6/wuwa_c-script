using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DC RID: 988
	[NullableContext(1)]
	[Nullable(0)]
	public class IGraph3dEdgeBase
	{
		// Token: 0x060013DB RID: 5083 RVA: 0x00040144 File Offset: 0x0003E344
		private IGraph3dEdgeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dEdgeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dEdgeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dEdgeBase_SetValue());
			}
			return result;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0004017C File Offset: 0x0003E37C
		public static IGraph3dEdgeBase Create([Nullable(2)] IGraph3dEdgeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEdgeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0004018F File Offset: 0x0003E38F
		public static IGraph3dEdgeBase CreateFromSetValue([Nullable(2)] IGraph3dEdgeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dEdgeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000401A2 File Offset: 0x0003E3A2
		public IGraph3dEdgeBase_SetValue ToSetValue()
		{
			return new IGraph3dEdgeBase_SetValue
			{
				Id = this.Id,
				From = this.From,
				To = this.To
			};
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000401CD File Offset: 0x0003E3CD
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x000401F8 File Offset: 0x0003E3F8
		public virtual int Id
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00040206 File Offset: 0x0003E406
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00040231 File Offset: 0x0003E431
		public virtual int From
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0004023F File Offset: 0x0003E43F
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0004026A File Offset: 0x0003E46A
		public virtual int To
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

		// Token: 0x04000FBE RID: 4030
		[Nullable(2)]
		protected IGraph3dEdgeBase FbInstance;

		// Token: 0x04000FBF RID: 4031
		[Nullable(2)]
		protected IGraph3dEdgeBase_SetValue PocoInterface;
	}
}
