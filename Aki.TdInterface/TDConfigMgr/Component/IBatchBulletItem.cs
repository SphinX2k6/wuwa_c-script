using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000216 RID: 534
	public class IBatchBulletItem
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x00027AA8 File Offset: 0x00025CA8
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

		// Token: 0x0600088D RID: 2189 RVA: 0x00027AE0 File Offset: 0x00025CE0
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

		// Token: 0x0600088E RID: 2190 RVA: 0x00027AF3 File Offset: 0x00025CF3
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

		// Token: 0x0600088F RID: 2191 RVA: 0x00027B06 File Offset: 0x00025D06
		public IBatchBulletItem_SetValue ToSetValue()
		{
			return new IBatchBulletItem_SetValue
			{
				Time = this.Time,
				CasterList = this.CasterList
			};
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00027B25 File Offset: 0x00025D25
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00027B50 File Offset: 0x00025D50
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00027B60 File Offset: 0x00025D60
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00027BF3 File Offset: 0x00025DF3
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

		// Token: 0x04000983 RID: 2435
		[Nullable(2)]
		protected IBatchBulletItem FbInstance;

		// Token: 0x04000984 RID: 2436
		[Nullable(2)]
		protected IBatchBulletItem_SetValue PocoInterface;

		// Token: 0x04000985 RID: 2437
		private List<IBatchBulletCaster> _CasterListCache;

		// Token: 0x04000986 RID: 2438
		private bool _CasterListInited;
	}
}
