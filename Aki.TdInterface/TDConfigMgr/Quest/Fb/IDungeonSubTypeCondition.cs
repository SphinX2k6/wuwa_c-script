using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001381 RID: 4993
	public class IDungeonSubTypeCondition : IDungeonCondition
	{
		// Token: 0x0600723F RID: 29247 RVA: 0x00112EFB File Offset: 0x001110FB
		[NullableContext(1)]
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

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x00112F1A File Offset: 0x0011111A
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x00112F27 File Offset: 0x00111127
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x00112F34 File Offset: 0x00111134
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

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06007243 RID: 29251 RVA: 0x00112F6A File Offset: 0x0011116A
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				return (EDungeonSubType)this.Instance.DungeonSubType;
			}
		}

		// Token: 0x04004209 RID: 16905
		private IDungeonSubTypeCondition Instance;
	}
}
