using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002398 RID: 9112
	public class ReignsAddBuff : ActionParams
	{
		// Token: 0x0600C6D2 RID: 50898 RVA: 0x001C7A30 File Offset: 0x001C5C30
		private ReignsAddBuff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsAddBuff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsAddBuff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsAddBuff_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x001C7A68 File Offset: 0x001C5C68
		public static ReignsAddBuff Create([Nullable(2)] ReignsAddBuff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x001C7A7B File Offset: 0x001C5C7B
		public static ReignsAddBuff CreateFromSetValue([Nullable(2)] ReignsAddBuff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x001C7A8E File Offset: 0x001C5C8E
		public ReignsAddBuff_SetValue ToSetValue()
		{
			return new ReignsAddBuff_SetValue
			{
				BuffId = this.BuffId
			};
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600C6D6 RID: 50902 RVA: 0x001C7AA1 File Offset: 0x001C5CA1
		// (set) Token: 0x0600C6D7 RID: 50903 RVA: 0x001C7ACC File Offset: 0x001C5CCC
		public virtual int BuffId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BuffId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BuffId;
			}
			set
			{
				this.GetOrCreatePoco().BuffId = value;
			}
		}

		// Token: 0x0400763A RID: 30266
		[Nullable(2)]
		protected new ReignsAddBuff FbInstance;

		// Token: 0x0400763B RID: 30267
		[Nullable(2)]
		protected ReignsAddBuff_SetValue PocoInterface;
	}
}
