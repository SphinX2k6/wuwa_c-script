using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010D9 RID: 4313
	public class IHandInItemRange
	{
		// Token: 0x06005F4E RID: 24398 RVA: 0x000E69F0 File Offset: 0x000E4BF0
		private IHandInItemRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandInItemRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandInItemRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandInItemRange_SetValue());
			}
			return result;
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x000E6A28 File Offset: 0x000E4C28
		public static IHandInItemRange Create([Nullable(2)] IHandInItemRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInItemRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x000E6A3B File Offset: 0x000E4C3B
		public static IHandInItemRange CreateFromSetValue([Nullable(2)] IHandInItemRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandInItemRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x000E6A4E File Offset: 0x000E4C4E
		public IHandInItemRange_SetValue ToSetValue()
		{
			return new IHandInItemRange_SetValue
			{
				HandInType = this.HandInType,
				ItemIds = this.ItemIds
			};
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x000E6A6D File Offset: 0x000E4C6D
		// (set) Token: 0x06005F53 RID: 24403 RVA: 0x000E6A98 File Offset: 0x000E4C98
		public virtual EHandInItemType HandInType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandInType;
				}
				if (this.PocoInterface == null)
				{
					return EHandInItemType.ItemIds;
				}
				return this.PocoInterface.HandInType;
			}
			set
			{
				this.GetOrCreatePoco().HandInType = value;
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x000E6AA6 File Offset: 0x000E4CA6
		// (set) Token: 0x06005F55 RID: 24405 RVA: 0x000E6ACD File Offset: 0x000E4CCD
		public virtual List<int> ItemIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemIds;
				}
				IHandInItemRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemIds;
			}
			set
			{
				this.GetOrCreatePoco().ItemIds = value;
			}
		}

		// Token: 0x04003930 RID: 14640
		[Nullable(2)]
		protected IHandInItemRange FbInstance;

		// Token: 0x04003931 RID: 14641
		[Nullable(2)]
		protected IHandInItemRange_SetValue PocoInterface;
	}
}
