using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001132 RID: 4402
	[NullableContext(1)]
	[Nullable(0)]
	public class ISheriffReasoningBoardConfig
	{
		// Token: 0x060063FC RID: 25596 RVA: 0x000F0B34 File Offset: 0x000EED34
		private ISheriffReasoningBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffReasoningBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffReasoningBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffReasoningBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x000F0B6C File Offset: 0x000EED6C
		public static ISheriffReasoningBoardConfig Create([Nullable(2)] ISheriffReasoningBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoningBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x000F0B7F File Offset: 0x000EED7F
		public static ISheriffReasoningBoardConfig CreateFromSetValue([Nullable(2)] ISheriffReasoningBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffReasoningBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x000F0B92 File Offset: 0x000EED92
		public ISheriffReasoningBoardConfig_SetValue ToSetValue()
		{
			return new ISheriffReasoningBoardConfig_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006400 RID: 25600 RVA: 0x000F0BA5 File Offset: 0x000EEDA5
		// (set) Token: 0x06006401 RID: 25601 RVA: 0x000F0BD0 File Offset: 0x000EEDD0
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04003C25 RID: 15397
		[Nullable(2)]
		protected ISheriffReasoningBoardConfig FbInstance;

		// Token: 0x04003C26 RID: 15398
		[Nullable(2)]
		protected ISheriffReasoningBoardConfig_SetValue PocoInterface;
	}
}
