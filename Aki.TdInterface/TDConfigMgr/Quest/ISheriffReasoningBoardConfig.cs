using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001260 RID: 4704
	public class ISheriffReasoningBoardConfig
	{
		// Token: 0x060069F7 RID: 27127 RVA: 0x000FDCA8 File Offset: 0x000FBEA8
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

		// Token: 0x060069F8 RID: 27128 RVA: 0x000FDCE0 File Offset: 0x000FBEE0
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

		// Token: 0x060069F9 RID: 27129 RVA: 0x000FDCF3 File Offset: 0x000FBEF3
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

		// Token: 0x060069FA RID: 27130 RVA: 0x000FDD06 File Offset: 0x000FBF06
		public ISheriffReasoningBoardConfig_SetValue ToSetValue()
		{
			return new ISheriffReasoningBoardConfig_SetValue
			{
				Id = this.Id
			};
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x000FDD19 File Offset: 0x000FBF19
		// (set) Token: 0x060069FC RID: 27132 RVA: 0x000FDD44 File Offset: 0x000FBF44
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

		// Token: 0x04003F73 RID: 16243
		[Nullable(2)]
		protected ISheriffReasoningBoardConfig FbInstance;

		// Token: 0x04003F74 RID: 16244
		[Nullable(2)]
		protected ISheriffReasoningBoardConfig_SetValue PocoInterface;
	}
}
