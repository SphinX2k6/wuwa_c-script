using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000F9 RID: 249
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityBundleComponent : IComponentBase
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0001CDBC File Offset: 0x0001AFBC
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

		// Token: 0x060003E7 RID: 999 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001CE07 File Offset: 0x0001B007
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001CE1A File Offset: 0x0001B01A
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001CE54 File Offset: 0x0001B054
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0001CE8E File Offset: 0x0001B08E
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0001CE9C File Offset: 0x0001B09C
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0001CEC6 File Offset: 0x0001B0C6
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001CED4 File Offset: 0x0001B0D4
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0001CEFF File Offset: 0x0001B0FF
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001CF10 File Offset: 0x0001B110
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0001CFA3 File Offset: 0x0001B1A3
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

		// Token: 0x04000538 RID: 1336
		[Nullable(2)]
		protected new EntityBundleComponent FbInstance;

		// Token: 0x04000539 RID: 1337
		[Nullable(2)]
		protected new EntityBundleComponent_SetValue PocoInterface;

		// Token: 0x0400053A RID: 1338
		private List<IEntityBundleChildInfo> _ChildInfosCache;

		// Token: 0x0400053B RID: 1339
		private bool _ChildInfosInited;
	}
}
