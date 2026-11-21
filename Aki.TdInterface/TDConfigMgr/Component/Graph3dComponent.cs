using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200019C RID: 412
	public class Graph3dComponent : IComponentBase
	{
		// Token: 0x06000584 RID: 1412 RVA: 0x0002137C File Offset: 0x0001F57C
		private Graph3dComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Graph3dComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Graph3dComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Graph3dComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000213B4 File Offset: 0x0001F5B4
		public static Graph3dComponent Create([Nullable(2)] Graph3dComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Graph3dComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000213C7 File Offset: 0x0001F5C7
		public static Graph3dComponent CreateFromSetValue([Nullable(2)] Graph3dComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Graph3dComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000213DA File Offset: 0x0001F5DA
		public new Graph3dComponent_SetValue ToSetValue()
		{
			return new Graph3dComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				GraphConfig = this.GraphConfig
			};
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00021408 File Offset: 0x0001F608
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00021442 File Offset: 0x0001F642
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				Graph3dComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00021450 File Offset: 0x0001F650
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0002147A File Offset: 0x0001F67A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00021488 File Offset: 0x0001F688
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000214E9 File Offset: 0x0001F6E9
		public virtual IGraph3dNormal GraphConfig
		{
			get
			{
				if (this._GraphConfigInited)
				{
					return this._GraphConfigCache;
				}
				this._GraphConfigInited = true;
				if (this.FbInstance != null)
				{
					this._GraphConfigCache = IGraph3dNormal.Create(this.FbInstance.GraphConfig);
				}
				else
				{
					Graph3dComponent_SetValue pocoInterface = this.PocoInterface;
					this._GraphConfigCache = ((pocoInterface != null) ? pocoInterface.GraphConfig : null);
				}
				return this._GraphConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().GraphConfig = value;
				this._GraphConfigInited = false;
			}
		}

		// Token: 0x040007C0 RID: 1984
		[Nullable(2)]
		protected new Graph3dComponent FbInstance;

		// Token: 0x040007C1 RID: 1985
		[Nullable(2)]
		protected new Graph3dComponent_SetValue PocoInterface;

		// Token: 0x040007C2 RID: 1986
		private IGraph3dNormal _GraphConfigCache;

		// Token: 0x040007C3 RID: 1987
		private bool _GraphConfigInited;
	}
}
