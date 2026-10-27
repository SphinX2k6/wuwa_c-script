using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200516E RID: 20846
	public class PhantomArenaEntranceViewModel : ViewModelBase<EViewData>, IPhantomArenaTabViewModelBase, IStaticVariableResetter
	{
		// Token: 0x060354BD RID: 218301 RVA: 0x00C9EE5E File Offset: 0x00C9D05E
		public PhantomArenaEntranceViewModel()
		{
			this.DataMap[EViewData.TabViewName] = EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView;
		}

		// Token: 0x060354BE RID: 218302 RVA: 0x00C9EE78 File Offset: 0x00C9D078
		static PhantomArenaEntranceViewModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaEntranceViewModel.CreateStaticDefaultValue), new Action(PhantomArenaEntranceViewModel.ResetStaticDefaultValue));
		}

		// Token: 0x060354BF RID: 218303 RVA: 0x00C9EE97 File Offset: 0x00C9D097
		public static void CreateStaticDefaultValue()
		{
			PhantomArenaEntranceViewModel.tabViewList = new EPhantomArenaChildViewName[]
			{
				EPhantomArenaChildViewName.PhantomArenaEntranceGymTabView,
				EPhantomArenaChildViewName.PhantomArenaEntranceRepeatTabView
			};
		}

		// Token: 0x060354C0 RID: 218304 RVA: 0x00C9EEAC File Offset: 0x00C9D0AC
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaEntranceViewModel.tabViewList = null;
		}

		// Token: 0x060354C1 RID: 218305 RVA: 0x00C9EEB4 File Offset: 0x00C9D0B4
		public void SetTabView(EPhantomArenaChildViewName tabView, bool notNotify = false)
		{
			if (!Array.Exists<EPhantomArenaChildViewName>(PhantomArenaEntranceViewModel.tabViewList, (EPhantomArenaChildViewName x) => x == tabView))
			{
				return;
			}
			base.SetData(EViewData.TabViewName, tabView, notNotify);
		}

		// Token: 0x060354C2 RID: 218306 RVA: 0x00C9EEFA File Offset: 0x00C9D0FA
		public EPhantomArenaChildViewName GetTabView()
		{
			return (EPhantomArenaChildViewName)base.GetData(EViewData.TabViewName);
		}

		// Token: 0x060354C3 RID: 218307 RVA: 0x00C9EF08 File Offset: 0x00C9D108
		public int GetRepeatChallenge()
		{
			return (int)(base.GetData(EViewData.RepeatChallengeId) ?? 0);
		}

		// Token: 0x060354C4 RID: 218308 RVA: 0x00C9EF20 File Offset: 0x00C9D120
		public void SetRepeatChallenge(int challengeId, bool notNotify = false)
		{
			base.SetData(EViewData.RepeatChallengeId, challengeId, notNotify);
		}

		// Token: 0x0401C58A RID: 116106
		[Nullable(1)]
		private static EPhantomArenaChildViewName[] tabViewList;
	}
}
