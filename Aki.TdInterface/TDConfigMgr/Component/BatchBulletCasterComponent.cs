using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200002A RID: 42
	public class BatchBulletCasterComponent : IComponentBase
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00017870 File Offset: 0x00015A70
		private BatchBulletCasterComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BatchBulletCasterComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BatchBulletCasterComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BatchBulletCasterComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000178A8 File Offset: 0x00015AA8
		public static BatchBulletCasterComponent Create([Nullable(2)] BatchBulletCasterComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BatchBulletCasterComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000178BB File Offset: 0x00015ABB
		public static BatchBulletCasterComponent CreateFromSetValue([Nullable(2)] BatchBulletCasterComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BatchBulletCasterComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000178D0 File Offset: 0x00015AD0
		public new BatchBulletCasterComponent_SetValue ToSetValue()
		{
			return new BatchBulletCasterComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WarningEffect = this.WarningEffect,
				MovementType = this.MovementType,
				BulletList = this.BulletList,
				BatchList = this.BatchList
			};
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001792C File Offset: 0x00015B2C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00017966 File Offset: 0x00015B66
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				BatchBulletCasterComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00017974 File Offset: 0x00015B74
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0001799E File Offset: 0x00015B9E
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000179AC File Offset: 0x00015BAC
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000179D7 File Offset: 0x00015BD7
		public virtual string WarningEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningEffect;
			}
			set
			{
				this.GetOrCreatePoco().WarningEffect = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000179E8 File Offset: 0x00015BE8
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00017A22 File Offset: 0x00015C22
		public virtual EBatchBulletMovementType? MovementType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MovementType;
				}
				BatchBulletCasterComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MovementType;
			}
			set
			{
				this.GetOrCreatePoco().MovementType = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00017A30 File Offset: 0x00015C30
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00017AC3 File Offset: 0x00015CC3
		public virtual List<Aki.TDConfigMgr.Action.IPosRot> BulletList
		{
			get
			{
				if (this._BulletListInited)
				{
					return this._BulletListCache;
				}
				this._BulletListInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.IPosRot> bulletList = this.FbInstance.BulletList;
					if (bulletList != null)
					{
						this._BulletListCache = new List<Aki.TDConfigMgr.Action.IPosRot>(bulletList.Count);
						for (int i = 0; i < bulletList.Count; i++)
						{
							this._BulletListCache.Add(Aki.TDConfigMgr.Action.IPosRot.Create(bulletList[i]));
						}
					}
				}
				else
				{
					BatchBulletCasterComponent_SetValue pocoInterface = this.PocoInterface;
					this._BulletListCache = ((pocoInterface != null) ? pocoInterface.BulletList : null);
				}
				return this._BulletListCache;
			}
			set
			{
				this.GetOrCreatePoco().BulletList = value;
				this._BulletListInited = false;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00017AD8 File Offset: 0x00015CD8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00017B6B File Offset: 0x00015D6B
		public virtual List<IBatchBulletItem> BatchList
		{
			get
			{
				if (this._BatchListInited)
				{
					return this._BatchListCache;
				}
				this._BatchListInited = true;
				if (this.FbInstance != null)
				{
					List<IBatchBulletItem> batchList = this.FbInstance.BatchList;
					if (batchList != null)
					{
						this._BatchListCache = new List<IBatchBulletItem>(batchList.Count);
						for (int i = 0; i < batchList.Count; i++)
						{
							this._BatchListCache.Add(IBatchBulletItem.Create(batchList[i]));
						}
					}
				}
				else
				{
					BatchBulletCasterComponent_SetValue pocoInterface = this.PocoInterface;
					this._BatchListCache = ((pocoInterface != null) ? pocoInterface.BatchList : null);
				}
				return this._BatchListCache;
			}
			set
			{
				this.GetOrCreatePoco().BatchList = value;
				this._BatchListInited = false;
			}
		}

		// Token: 0x040000EA RID: 234
		[Nullable(2)]
		protected new BatchBulletCasterComponent FbInstance;

		// Token: 0x040000EB RID: 235
		[Nullable(2)]
		protected new BatchBulletCasterComponent_SetValue PocoInterface;

		// Token: 0x040000EC RID: 236
		private List<Aki.TDConfigMgr.Action.IPosRot> _BulletListCache;

		// Token: 0x040000ED RID: 237
		private bool _BulletListInited;

		// Token: 0x040000EE RID: 238
		private List<IBatchBulletItem> _BatchListCache;

		// Token: 0x040000EF RID: 239
		private bool _BatchListInited;
	}
}
