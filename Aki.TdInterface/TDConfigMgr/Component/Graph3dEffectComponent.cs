using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200019E RID: 414
	public class Graph3dEffectComponent : IComponentBase
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00021510 File Offset: 0x0001F710
		private Graph3dEffectComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Graph3dEffectComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Graph3dEffectComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Graph3dEffectComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00021548 File Offset: 0x0001F748
		public static Graph3dEffectComponent Create([Nullable(2)] Graph3dEffectComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Graph3dEffectComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0002155B File Offset: 0x0001F75B
		public static Graph3dEffectComponent CreateFromSetValue([Nullable(2)] Graph3dEffectComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Graph3dEffectComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002156E File Offset: 0x0001F76E
		public new Graph3dEffectComponent_SetValue ToSetValue()
		{
			return new Graph3dEffectComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Graph3dEntityId = this.Graph3dEntityId,
				EffectType = this.EffectType
			};
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000215A8 File Offset: 0x0001F7A8
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000215E2 File Offset: 0x0001F7E2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				Graph3dEffectComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000215F0 File Offset: 0x0001F7F0
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0002161A File Offset: 0x0001F81A
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00021628 File Offset: 0x0001F828
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00021653 File Offset: 0x0001F853
		public virtual int Graph3dEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Graph3dEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Graph3dEntityId;
			}
			set
			{
				this.GetOrCreatePoco().Graph3dEntityId = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00021664 File Offset: 0x0001F864
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x000216C5 File Offset: 0x0001F8C5
		public virtual IFireBoxFishEffect EffectType
		{
			get
			{
				if (this._EffectTypeInited)
				{
					return this._EffectTypeCache;
				}
				this._EffectTypeInited = true;
				if (this.FbInstance != null)
				{
					this._EffectTypeCache = IFireBoxFishEffect.Create(this.FbInstance.EffectType);
				}
				else
				{
					Graph3dEffectComponent_SetValue pocoInterface = this.PocoInterface;
					this._EffectTypeCache = ((pocoInterface != null) ? pocoInterface.EffectType : null);
				}
				return this._EffectTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectType = value;
				this._EffectTypeInited = false;
			}
		}

		// Token: 0x040007C7 RID: 1991
		[Nullable(2)]
		protected new Graph3dEffectComponent FbInstance;

		// Token: 0x040007C8 RID: 1992
		[Nullable(2)]
		protected new Graph3dEffectComponent_SetValue PocoInterface;

		// Token: 0x040007C9 RID: 1993
		private IFireBoxFishEffect _EffectTypeCache;

		// Token: 0x040007CA RID: 1994
		private bool _EffectTypeInited;
	}
}
