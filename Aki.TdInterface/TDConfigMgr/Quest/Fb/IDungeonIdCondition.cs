using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014D1 RID: 5329
	public class IDungeonIdCondition : IDungeonCondition
	{
		// Token: 0x060078DF RID: 30943 RVA: 0x001214FA File Offset: 0x0011F6FA
		public static IDungeonIdCondition Create(IDungeonIdCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonIdCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x00121519 File Offset: 0x0011F719
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x00121526 File Offset: 0x0011F726
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x00121534 File Offset: 0x0011F734
		public override bool? IsExitDungeon
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsExitDungeon);
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x0012156A File Offset: 0x0011F76A
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x04004589 RID: 17801
		private IDungeonIdCondition Instance;
	}
}
