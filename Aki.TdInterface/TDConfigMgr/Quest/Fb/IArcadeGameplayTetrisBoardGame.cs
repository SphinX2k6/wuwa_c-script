using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015CC RID: 5580
	public class IArcadeGameplayTetrisBoardGame : IArcadeGameplayBase
	{
		// Token: 0x06007DE4 RID: 32228 RVA: 0x0012B5CC File Offset: 0x001297CC
		public static IArcadeGameplayTetrisBoardGame Create(IArcadeGameplayTetrisBoardGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayTetrisBoardGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x06007DE5 RID: 32229 RVA: 0x0012B5EB File Offset: 0x001297EB
		public override EArcadeGameplayType Type
		{
			get
			{
				return (EArcadeGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x0012B5F8 File Offset: 0x001297F8
		public virtual int LevelId
		{
			get
			{
				return this.Instance.LevelId;
			}
		}

		// Token: 0x040048DC RID: 18652
		private IArcadeGameplayTetrisBoardGame Instance;
	}
}
