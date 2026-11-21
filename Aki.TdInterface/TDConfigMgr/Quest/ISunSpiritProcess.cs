using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001280 RID: 4736
	public class ISunSpiritProcess
	{
		// Token: 0x06006ABF RID: 27327 RVA: 0x000FF36C File Offset: 0x000FD56C
		private ISunSpiritProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritProcess_SetValue());
			}
			return result;
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x000FF3A4 File Offset: 0x000FD5A4
		public static ISunSpiritProcess Create([Nullable(2)] ISunSpiritProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x000FF3B7 File Offset: 0x000FD5B7
		public static ISunSpiritProcess CreateFromSetValue([Nullable(2)] ISunSpiritProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x000FF3CA File Offset: 0x000FD5CA
		public ISunSpiritProcess_SetValue ToSetValue()
		{
			return new ISunSpiritProcess_SetValue
			{
				LauncherId = this.LauncherId,
				IsRecycle = this.IsRecycle
			};
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x000FF3E9 File Offset: 0x000FD5E9
		// (set) Token: 0x06006AC4 RID: 27332 RVA: 0x000FF414 File Offset: 0x000FD614
		public virtual int LauncherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LauncherId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LauncherId;
			}
			set
			{
				this.GetOrCreatePoco().LauncherId = value;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x000FF424 File Offset: 0x000FD624
		// (set) Token: 0x06006AC6 RID: 27334 RVA: 0x000FF45E File Offset: 0x000FD65E
		public virtual bool? IsRecycle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRecycle;
				}
				ISunSpiritProcess_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRecycle;
			}
			set
			{
				this.GetOrCreatePoco().IsRecycle = value;
			}
		}

		// Token: 0x04003FD1 RID: 16337
		[Nullable(2)]
		protected ISunSpiritProcess FbInstance;

		// Token: 0x04003FD2 RID: 16338
		[Nullable(2)]
		protected ISunSpiritProcess_SetValue PocoInterface;
	}
}
