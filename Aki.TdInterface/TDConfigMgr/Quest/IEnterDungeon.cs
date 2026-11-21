using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200107D RID: 4221
	public class IEnterDungeon
	{
		// Token: 0x06005D08 RID: 23816 RVA: 0x000E20C8 File Offset: 0x000E02C8
		private IEnterDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x000E2100 File Offset: 0x000E0300
		public static IEnterDungeon Create([Nullable(2)] IEnterDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x000E2113 File Offset: 0x000E0313
		public static IEnterDungeon CreateFromSetValue([Nullable(2)] IEnterDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x000E2126 File Offset: 0x000E0326
		public IEnterDungeon_SetValue ToSetValue()
		{
			return new IEnterDungeon_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x000E2139 File Offset: 0x000E0339
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x000E2164 File Offset: 0x000E0364
		public virtual EDungeonConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040037F9 RID: 14329
		[Nullable(2)]
		protected IEnterDungeon FbInstance;

		// Token: 0x040037FA RID: 14330
		[Nullable(2)]
		protected IEnterDungeon_SetValue PocoInterface;
	}
}
