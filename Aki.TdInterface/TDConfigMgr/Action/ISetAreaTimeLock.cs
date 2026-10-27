using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E0E RID: 7694
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAreaTimeLock : ISetAreaTimeBase
	{
		// Token: 0x0600A499 RID: 42137 RVA: 0x001753A8 File Offset: 0x001735A8
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

		// Token: 0x0600A49A RID: 42138 RVA: 0x001753E0 File Offset: 0x001735E0
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

		// Token: 0x0600A49B RID: 42139 RVA: 0x001753F3 File Offset: 0x001735F3
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

		// Token: 0x0600A49C RID: 42140 RVA: 0x00175406 File Offset: 0x00173606
		public new ISetAreaTimeLock_SetValue ToSetValue()
		{
			return new ISetAreaTimeLock_SetValue
			{
				Type = this.Type,
				AreaIds = this.AreaIds,
				LockTime = this.LockTime
			};
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A49D RID: 42141 RVA: 0x00175431 File Offset: 0x00173631
		// (set) Token: 0x0600A49E RID: 42142 RVA: 0x0017545C File Offset: 0x0017365C
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

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A49F RID: 42143 RVA: 0x0017546A File Offset: 0x0017366A
		// (set) Token: 0x0600A4A0 RID: 42144 RVA: 0x00175491 File Offset: 0x00173691
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

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x001754A0 File Offset: 0x001736A0
		// (set) Token: 0x0600A4A2 RID: 42146 RVA: 0x00175501 File Offset: 0x00173701
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

		// Token: 0x04006289 RID: 25225
		[Nullable(2)]
		protected new ISetAreaTimeLock FbInstance;

		// Token: 0x0400628A RID: 25226
		[Nullable(2)]
		protected new ISetAreaTimeLock_SetValue PocoInterface;

		// Token: 0x0400628B RID: 25227
		private IFixedTime _LockTimeCache;

		// Token: 0x0400628C RID: 25228
		private bool _LockTimeInited;
	}
}
