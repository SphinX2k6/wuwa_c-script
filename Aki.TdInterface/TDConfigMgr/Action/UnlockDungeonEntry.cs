using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024CE RID: 9422
	public class UnlockDungeonEntry : ActionParams
	{
		// Token: 0x0600CCDA RID: 52442 RVA: 0x001D2B10 File Offset: 0x001D0D10
		private UnlockDungeonEntry_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("UnlockDungeonEntry 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			UnlockDungeonEntry_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new UnlockDungeonEntry_SetValue());
			}
			return result;
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x001D2B48 File Offset: 0x001D0D48
		public static UnlockDungeonEntry Create([Nullable(2)] UnlockDungeonEntry instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new UnlockDungeonEntry
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x001D2B5B File Offset: 0x001D0D5B
		public static UnlockDungeonEntry CreateFromSetValue([Nullable(2)] UnlockDungeonEntry_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new UnlockDungeonEntry
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x001D2B6E File Offset: 0x001D0D6E
		public UnlockDungeonEntry_SetValue ToSetValue()
		{
			return new UnlockDungeonEntry_SetValue
			{
				DungeonEntryId = this.DungeonEntryId
			};
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600CCDE RID: 52446 RVA: 0x001D2B81 File Offset: 0x001D0D81
		// (set) Token: 0x0600CCDF RID: 52447 RVA: 0x001D2BAC File Offset: 0x001D0DAC
		public virtual int DungeonEntryId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DungeonEntryId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DungeonEntryId;
			}
			set
			{
				this.GetOrCreatePoco().DungeonEntryId = value;
			}
		}

		// Token: 0x0400795E RID: 31070
		[Nullable(2)]
		protected new UnlockDungeonEntry FbInstance;

		// Token: 0x0400795F RID: 31071
		[Nullable(2)]
		protected UnlockDungeonEntry_SetValue PocoInterface;
	}
}
