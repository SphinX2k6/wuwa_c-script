using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002041 RID: 8257
	public class ISetAreaTimeLock : ISetAreaTimeBase
	{
		// Token: 0x0600AF41 RID: 44865 RVA: 0x0018ADB0 File Offset: 0x00188FB0
		private ISetAreaTimeLock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAreaTimeLock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAreaTimeLock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAreaTimeLock_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x0018ADE8 File Offset: 0x00188FE8
		public static ISetAreaTimeLock Create([Nullable(2)] ISetAreaTimeLock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeLock
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x0018ADFB File Offset: 0x00188FFB
		public static ISetAreaTimeLock CreateFromSetValue([Nullable(2)] ISetAreaTimeLock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAreaTimeLock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x0018AE0E File Offset: 0x0018900E
		public new ISetAreaTimeLock_SetValue ToSetValue()
		{
			return new ISetAreaTimeLock_SetValue
			{
				Type = this.Type,
				AreaIds = this.AreaIds,
				LockTime = this.LockTime
			};
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x0018AE39 File Offset: 0x00189039
		// (set) Token: 0x0600AF46 RID: 44870 RVA: 0x0018AE64 File Offset: 0x00189064
		public override ESetAreaTime Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetAreaTime.Lock;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x0018AE72 File Offset: 0x00189072
		// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x0018AE99 File Offset: 0x00189099
		public virtual List<int> AreaIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				ISetAreaTimeLock_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x0018AEA8 File Offset: 0x001890A8
		// (set) Token: 0x0600AF4A RID: 44874 RVA: 0x0018AF09 File Offset: 0x00189109
		public virtual IFixedTime LockTime
		{
			get
			{
				if (this._LockTimeInited)
				{
					return this._LockTimeCache;
				}
				this._LockTimeInited = true;
				if (this.FbInstance != null)
				{
					this._LockTimeCache = IFixedTime.Create(this.FbInstance.LockTime);
				}
				else
				{
					ISetAreaTimeLock_SetValue pocoInterface = this.PocoInterface;
					this._LockTimeCache = ((pocoInterface != null) ? pocoInterface.LockTime : null);
				}
				return this._LockTimeCache;
			}
			set
			{
				this.GetOrCreatePoco().LockTime = value;
				this._LockTimeInited = false;
			}
		}

		// Token: 0x04006860 RID: 26720
		[Nullable(2)]
		protected new ISetAreaTimeLock FbInstance;

		// Token: 0x04006861 RID: 26721
		[Nullable(2)]
		protected new ISetAreaTimeLock_SetValue PocoInterface;

		// Token: 0x04006862 RID: 26722
		private IFixedTime _LockTimeCache;

		// Token: 0x04006863 RID: 26723
		private bool _LockTimeInited;
	}
}
