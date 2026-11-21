using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000102 RID: 258
	public class EntityBundleComponent : IComponentBase
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x0001D730 File Offset: 0x0001B930
		private EntityBundleComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EntityBundleComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EntityBundleComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EntityBundleComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001D768 File Offset: 0x0001B968
		public static EntityBundleComponent Create([Nullable(2)] EntityBundleComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityBundleComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001D77B File Offset: 0x0001B97B
		public static EntityBundleComponent CreateFromSetValue([Nullable(2)] EntityBundleComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EntityBundleComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001D78E File Offset: 0x0001B98E
		public new EntityBundleComponent_SetValue ToSetValue()
		{
			return new EntityBundleComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				BundleId = this.BundleId,
				ChildInfos = this.ChildInfos
			};
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0001D802 File Offset: 0x0001BA02
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				EntityBundleComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001D810 File Offset: 0x0001BA10
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0001D83A File Offset: 0x0001BA3A
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0001D848 File Offset: 0x0001BA48
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0001D873 File Offset: 0x0001BA73
		public virtual int BundleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BundleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BundleId;
			}
			set
			{
				this.GetOrCreatePoco().BundleId = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0001D884 File Offset: 0x0001BA84
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0001D917 File Offset: 0x0001BB17
		public virtual List<IEntityBundleChildInfo> ChildInfos
		{
			get
			{
				if (this._ChildInfosInited)
				{
					return this._ChildInfosCache;
				}
				this._ChildInfosInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityBundleChildInfo> childInfos = this.FbInstance.ChildInfos;
					if (childInfos != null)
					{
						this._ChildInfosCache = new List<IEntityBundleChildInfo>(childInfos.Count);
						for (int i = 0; i < childInfos.Count; i++)
						{
							this._ChildInfosCache.Add(IEntityBundleChildInfo.Create(childInfos[i]));
						}
					}
				}
				else
				{
					EntityBundleComponent_SetValue pocoInterface = this.PocoInterface;
					this._ChildInfosCache = ((pocoInterface != null) ? pocoInterface.ChildInfos : null);
				}
				return this._ChildInfosCache;
			}
			set
			{
				this.GetOrCreatePoco().ChildInfos = value;
				this._ChildInfosInited = false;
			}
		}

		// Token: 0x04000562 RID: 1378
		[Nullable(2)]
		protected new EntityBundleComponent FbInstance;

		// Token: 0x04000563 RID: 1379
		[Nullable(2)]
		protected new EntityBundleComponent_SetValue PocoInterface;

		// Token: 0x04000564 RID: 1380
		private List<IEntityBundleChildInfo> _ChildInfosCache;

		// Token: 0x04000565 RID: 1381
		private bool _ChildInfosInited;
	}
}
