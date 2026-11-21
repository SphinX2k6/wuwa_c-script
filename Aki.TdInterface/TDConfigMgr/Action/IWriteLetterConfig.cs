using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002318 RID: 8984
	public class IWriteLetterConfig
	{
		// Token: 0x0600C3B6 RID: 50102 RVA: 0x001C1708 File Offset: 0x001BF908
		private IWriteLetterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWriteLetterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWriteLetterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWriteLetterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x001C1740 File Offset: 0x001BF940
		public static IWriteLetterConfig Create([Nullable(2)] IWriteLetterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWriteLetterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x001C1753 File Offset: 0x001BF953
		public static IWriteLetterConfig CreateFromSetValue([Nullable(2)] IWriteLetterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWriteLetterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x001C1766 File Offset: 0x001BF966
		public IWriteLetterConfig_SetValue ToSetValue()
		{
			return new IWriteLetterConfig_SetValue
			{
				LetterId = this.LetterId
			};
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600C3BA RID: 50106 RVA: 0x001C1779 File Offset: 0x001BF979
		// (set) Token: 0x0600C3BB RID: 50107 RVA: 0x001C17A4 File Offset: 0x001BF9A4
		public virtual int LetterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LetterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LetterId;
			}
			set
			{
				this.GetOrCreatePoco().LetterId = value;
			}
		}

		// Token: 0x040074A2 RID: 29858
		[Nullable(2)]
		protected IWriteLetterConfig FbInstance;

		// Token: 0x040074A3 RID: 29859
		[Nullable(2)]
		protected IWriteLetterConfig_SetValue PocoInterface;
	}
}
