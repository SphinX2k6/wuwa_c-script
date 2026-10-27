using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001380 RID: 4992
	public class IDungeonIdCondition : IDungeonCondition
	{
		// Token: 0x06007239 RID: 29241 RVA: 0x00112E76 File Offset: 0x00111076
		[NullableContext(1)]
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

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600723A RID: 29242 RVA: 0x00112E95 File Offset: 0x00111095
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x00112EA2 File Offset: 0x001110A2
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600723C RID: 29244 RVA: 0x00112EB0 File Offset: 0x001110B0
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

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x00112EE6 File Offset: 0x001110E6
		public virtual int DungeonId
		{
			get
			{
				return this.Instance.DungeonId;
			}
		}

		// Token: 0x04004208 RID: 16904
		private IDungeonIdCondition Instance;
	}
}
