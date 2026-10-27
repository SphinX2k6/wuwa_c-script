using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000187 RID: 391
	[NullableContext(1)]
	[Nullable(0)]
	public class Graph3dEffectComponent : IComponentBase
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x00020934 File Offset: 0x0001EB34
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

		// Token: 0x0600057D RID: 1405 RVA: 0x0002096C File Offset: 0x0001EB6C
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

		// Token: 0x0600057E RID: 1406 RVA: 0x0002097F File Offset: 0x0001EB7F
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

		// Token: 0x0600057F RID: 1407 RVA: 0x00020992 File Offset: 0x0001EB92
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000209CC File Offset: 0x0001EBCC
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00020A06 File Offset: 0x0001EC06
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00020A14 File Offset: 0x0001EC14
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00020A3E File Offset: 0x0001EC3E
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00020A4C File Offset: 0x0001EC4C
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00020A77 File Offset: 0x0001EC77
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00020A88 File Offset: 0x0001EC88
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00020AE9 File Offset: 0x0001ECE9
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

		// Token: 0x04000771 RID: 1905
		[Nullable(2)]
		protected new Graph3dEffectComponent FbInstance;

		// Token: 0x04000772 RID: 1906
		[Nullable(2)]
		protected new Graph3dEffectComponent_SetValue PocoInterface;

		// Token: 0x04000773 RID: 1907
		private IFireBoxFishEffect _EffectTypeCache;

		// Token: 0x04000774 RID: 1908
		private bool _EffectTypeInited;
	}
}
