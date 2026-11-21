using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014D0 RID: 5328
	public class IDungeonCondition
	{
		// Token: 0x060078DA RID: 30938 RVA: 0x00121480 File Offset: 0x0011F680
		public static IDungeonCondition Create(IDungeonCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x0012149F File Offset: 0x0011F69F
		public virtual EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x001214AC File Offset: 0x0011F6AC
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x060078DD RID: 30941 RVA: 0x001214BC File Offset: 0x0011F6BC
		public virtual bool? IsExitDungeon
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

		// Token: 0x04004588 RID: 17800
		private IDungeonCondition Instance;
	}
}
