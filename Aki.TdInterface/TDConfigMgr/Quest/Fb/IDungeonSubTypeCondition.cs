using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014D2 RID: 5330
	public class IDungeonSubTypeCondition : IDungeonCondition
	{
		// Token: 0x060078E5 RID: 30949 RVA: 0x0012157F File Offset: 0x0011F77F
		public static IDungeonSubTypeCondition Create(IDungeonSubTypeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonSubTypeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x0012159E File Offset: 0x0011F79E
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x060078E7 RID: 30951 RVA: 0x001215AB File Offset: 0x0011F7AB
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x060078E8 RID: 30952 RVA: 0x001215B8 File Offset: 0x0011F7B8
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

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x060078E9 RID: 30953 RVA: 0x001215EE File Offset: 0x0011F7EE
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				return (EDungeonSubType)this.Instance.DungeonSubType;
			}
		}

		// Token: 0x0400458A RID: 17802
		private IDungeonSubTypeCondition Instance;
	}
}
