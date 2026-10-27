using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002261 RID: 8801
	[NullableContext(1)]
	[Nullable(0)]
	public class UnlockDungeonEntry : ActionParams
	{
		// Token: 0x0600C114 RID: 49428 RVA: 0x001BB38C File Offset: 0x001B958C
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

		// Token: 0x0600C115 RID: 49429 RVA: 0x001BB3C4 File Offset: 0x001B95C4
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

		// Token: 0x0600C116 RID: 49430 RVA: 0x001BB3D7 File Offset: 0x001B95D7
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

		// Token: 0x0600C117 RID: 49431 RVA: 0x001BB3EA File Offset: 0x001B95EA
		public UnlockDungeonEntry_SetValue ToSetValue()
		{
			return new UnlockDungeonEntry_SetValue
			{
				DungeonEntryId = this.DungeonEntryId
			};
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600C118 RID: 49432 RVA: 0x001BB3FD File Offset: 0x001B95FD
		// (set) Token: 0x0600C119 RID: 49433 RVA: 0x001BB428 File Offset: 0x001B9628
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

		// Token: 0x04007311 RID: 29457
		[Nullable(2)]
		protected new UnlockDungeonEntry FbInstance;

		// Token: 0x04007312 RID: 29458
		[Nullable(2)]
		protected UnlockDungeonEntry_SetValue PocoInterface;
	}
}
