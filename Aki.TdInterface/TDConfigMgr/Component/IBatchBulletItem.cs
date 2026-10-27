using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001ED RID: 493
	[NullableContext(1)]
	[Nullable(0)]
	public class IBatchBulletItem
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x00026154 File Offset: 0x00024354
		private IBatchBulletItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBatchBulletItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBatchBulletItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBatchBulletItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0002618C File Offset: 0x0002438C
		public static IBatchBulletItem Create([Nullable(2)] IBatchBulletItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBatchBulletItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0002619F File Offset: 0x0002439F
		public static IBatchBulletItem CreateFromSetValue([Nullable(2)] IBatchBulletItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBatchBulletItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000261B2 File Offset: 0x000243B2
		public IBatchBulletItem_SetValue ToSetValue()
		{
			return new IBatchBulletItem_SetValue
			{
				Time = this.Time,
				CasterList = this.CasterList
			};
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000261D1 File Offset: 0x000243D1
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x000261FC File Offset: 0x000243FC
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0002620C File Offset: 0x0002440C
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0002629F File Offset: 0x0002449F
		public virtual List<IBatchBulletCaster> CasterList
		{
			get
			{
				if (this._CasterListInited)
				{
					return this._CasterListCache;
				}
				this._CasterListInited = true;
				if (this.FbInstance != null)
				{
					List<IBatchBulletCaster> casterList = this.FbInstance.CasterList;
					if (casterList != null)
					{
						this._CasterListCache = new List<IBatchBulletCaster>(casterList.Count);
						for (int i = 0; i < casterList.Count; i++)
						{
							this._CasterListCache.Add(IBatchBulletCaster.Create(casterList[i]));
						}
					}
				}
				else
				{
					IBatchBulletItem_SetValue pocoInterface = this.PocoInterface;
					this._CasterListCache = ((pocoInterface != null) ? pocoInterface.CasterList : null);
				}
				return this._CasterListCache;
			}
			set
			{
				this.GetOrCreatePoco().CasterList = value;
				this._CasterListInited = false;
			}
		}

		// Token: 0x040008F2 RID: 2290
		[Nullable(2)]
		protected IBatchBulletItem FbInstance;

		// Token: 0x040008F3 RID: 2291
		[Nullable(2)]
		protected IBatchBulletItem_SetValue PocoInterface;

		// Token: 0x040008F4 RID: 2292
		private List<IBatchBulletCaster> _CasterListCache;

		// Token: 0x040008F5 RID: 2293
		private bool _CasterListInited;
	}
}
