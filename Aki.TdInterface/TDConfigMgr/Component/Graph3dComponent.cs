using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000185 RID: 389
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph3dComponent : IComponentBase
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x000207A0 File Offset: 0x0001E9A0
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

		// Token: 0x06000571 RID: 1393 RVA: 0x000207D8 File Offset: 0x0001E9D8
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

		// Token: 0x06000572 RID: 1394 RVA: 0x000207EB File Offset: 0x0001E9EB
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

		// Token: 0x06000573 RID: 1395 RVA: 0x000207FE File Offset: 0x0001E9FE
		public new Graph3dComponent_SetValue ToSetValue()
		{
			return new Graph3dComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				GraphConfig = this.GraphConfig
			};
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0002082C File Offset: 0x0001EA2C
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00020866 File Offset: 0x0001EA66
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00020874 File Offset: 0x0001EA74
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0002089E File Offset: 0x0001EA9E
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000208AC File Offset: 0x0001EAAC
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0002090D File Offset: 0x0001EB0D
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

		// Token: 0x0400076A RID: 1898
		[Nullable(2)]
		protected new Graph3dComponent FbInstance;

		// Token: 0x0400076B RID: 1899
		[Nullable(2)]
		protected new Graph3dComponent_SetValue PocoInterface;

		// Token: 0x0400076C RID: 1900
		private IGraph3dNormal _GraphConfigCache;

		// Token: 0x0400076D RID: 1901
		private bool _GraphConfigInited;
	}
}
