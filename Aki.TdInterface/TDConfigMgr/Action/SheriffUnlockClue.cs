using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002464 RID: 9316
	public class SheriffUnlockClue : ActionParams
	{
		// Token: 0x0600CABB RID: 51899 RVA: 0x001CEC20 File Offset: 0x001CCE20
		private SheriffUnlockClue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SheriffUnlockClue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SheriffUnlockClue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SheriffUnlockClue_SetValue());
			}
			return result;
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x001CEC58 File Offset: 0x001CCE58
		public static SheriffUnlockClue Create([Nullable(2)] SheriffUnlockClue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x001CEC6B File Offset: 0x001CCE6B
		public static SheriffUnlockClue CreateFromSetValue([Nullable(2)] SheriffUnlockClue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x001CEC7E File Offset: 0x001CCE7E
		public SheriffUnlockClue_SetValue ToSetValue()
		{
			return new SheriffUnlockClue_SetValue
			{
				ClueId = this.ClueId
			};
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600CABF RID: 51903 RVA: 0x001CEC91 File Offset: 0x001CCE91
		// (set) Token: 0x0600CAC0 RID: 51904 RVA: 0x001CECBC File Offset: 0x001CCEBC
		public virtual int ClueId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ClueId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ClueId;
			}
			set
			{
				this.GetOrCreatePoco().ClueId = value;
			}
		}

		// Token: 0x0400782C RID: 30764
		[Nullable(2)]
		protected new SheriffUnlockClue FbInstance;

		// Token: 0x0400782D RID: 30765
		[Nullable(2)]
		protected SheriffUnlockClue_SetValue PocoInterface;
	}
}
