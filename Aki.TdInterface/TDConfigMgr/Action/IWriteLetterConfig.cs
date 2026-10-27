using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C3 RID: 8387
	[NullableContext(1)]
	[Nullable(0)]
	public class IWriteLetterConfig
	{
		// Token: 0x0600B85E RID: 47198 RVA: 0x001AAAC0 File Offset: 0x001A8CC0
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

		// Token: 0x0600B85F RID: 47199 RVA: 0x001AAAF8 File Offset: 0x001A8CF8
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

		// Token: 0x0600B860 RID: 47200 RVA: 0x001AAB0B File Offset: 0x001A8D0B
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

		// Token: 0x0600B861 RID: 47201 RVA: 0x001AAB1E File Offset: 0x001A8D1E
		public IWriteLetterConfig_SetValue ToSetValue()
		{
			return new IWriteLetterConfig_SetValue
			{
				LetterId = this.LetterId
			};
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600B862 RID: 47202 RVA: 0x001AAB31 File Offset: 0x001A8D31
		// (set) Token: 0x0600B863 RID: 47203 RVA: 0x001AAB5C File Offset: 0x001A8D5C
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

		// Token: 0x04006E84 RID: 28292
		[Nullable(2)]
		protected IWriteLetterConfig FbInstance;

		// Token: 0x04006E85 RID: 28293
		[Nullable(2)]
		protected IWriteLetterConfig_SetValue PocoInterface;
	}
}
