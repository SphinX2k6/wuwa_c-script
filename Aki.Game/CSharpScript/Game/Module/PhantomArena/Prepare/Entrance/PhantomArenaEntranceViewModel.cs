using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200413E RID: 16702
	public class PhantomArenaEntranceViewModel : ViewModelBase<EViewData>, IPhantomArenaTabViewModelBase, IStaticVariableResetter
	{
		// Token: 0x0602A3B9 RID: 172985 RVA: 0x00BEC3AA File Offset: 0x00BEA5AA
		public PhantomArenaEntranceViewModel()
		{
			this.DataMap[EViewData.TabViewName] = EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView;
		}

		// Token: 0x0602A3BA RID: 172986 RVA: 0x00BEC3C4 File Offset: 0x00BEA5C4
		static PhantomArenaEntranceViewModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaEntranceViewModel.CreateStaticDefaultValue), new Action(PhantomArenaEntranceViewModel.ResetStaticDefaultValue));
		}

		// Token: 0x0602A3BB RID: 172987 RVA: 0x00BEC3E3 File Offset: 0x00BEA5E3
		public static void CreateStaticDefaultValue()
		{
			PhantomArenaEntranceViewModel.tabViewList = new EPhantomArenaChildViewName[]
			{
				EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView,
				EPhantomArenaChildViewName.PhantomArenaEntranceRepeatTabView
			};
		}

		// Token: 0x0602A3BC RID: 172988 RVA: 0x00BEC3F8 File Offset: 0x00BEA5F8
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaEntranceViewModel.tabViewList = null;
		}

		// Token: 0x0602A3BD RID: 172989 RVA: 0x00BEC400 File Offset: 0x00BEA600
		public void SetTabView(EPhantomArenaChildViewName tabView, bool notNotify = false)
		{
			if (!Array.Exists<EPhantomArenaChildViewName>(PhantomArenaEntranceViewModel.tabViewList, (EPhantomArenaChildViewName x) => x == tabView))
			{
				return;
			}
			base.SetData(EViewData.TabViewName, tabView, notNotify);
		}

		// Token: 0x0602A3BE RID: 172990 RVA: 0x00BEC446 File Offset: 0x00BEA646
		public EPhantomArenaChildViewName GetTabView()
		{
			return (EPhantomArenaChildViewName)base.GetData(EViewData.TabViewName);
		}

		// Token: 0x0602A3BF RID: 172991 RVA: 0x00BEC454 File Offset: 0x00BEA654
		public int GetRepeatChallenge()
		{
			return (int)(base.GetData(EViewData.RepeatChallengeId) ?? 0);
		}

		// Token: 0x0602A3C0 RID: 172992 RVA: 0x00BEC46C File Offset: 0x00BEA66C
		public void SetRepeatChallenge(int challengeId, bool notNotify = false)
		{
			base.SetData(EViewData.RepeatChallengeId, challengeId, notNotify);
		}

		// Token: 0x04016FBF RID: 94143
		[Nullable(1)]
		private static EPhantomArenaChildViewName[] tabViewList;
	}
}
