using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000435 RID: 1077
	public class IGraph3dEdgeBase
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x00043E8C File Offset: 0x0004208C
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

		// Token: 0x06001576 RID: 5494 RVA: 0x00043EC4 File Offset: 0x000420C4
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

		// Token: 0x06001577 RID: 5495 RVA: 0x00043ED7 File Offset: 0x000420D7
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

		// Token: 0x06001578 RID: 5496 RVA: 0x00043EEA File Offset: 0x000420EA
		public IGraph3dEdgeBase_SetValue ToSetValue()
		{
			return new IGraph3dEdgeBase_SetValue
			{
				Id = this.Id,
				From = this.From,
				To = this.To
			};
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00043F15 File Offset: 0x00042115
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00043F40 File Offset: 0x00042140
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00043F4E File Offset: 0x0004214E
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x00043F79 File Offset: 0x00042179
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00043F87 File Offset: 0x00042187
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00043FB2 File Offset: 0x000421B2
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

		// Token: 0x040010E0 RID: 4320
		[Nullable(2)]
		protected IGraph3dEdgeBase FbInstance;

		// Token: 0x040010E1 RID: 4321
		[Nullable(2)]
		protected IGraph3dEdgeBase_SetValue PocoInterface;
	}
}
