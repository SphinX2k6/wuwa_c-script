using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD0 RID: 23760
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleDungeonGuideButton : BattleEntranceButton
	{
		// Token: 0x0603C1F2 RID: 246258 RVA: 0x00E64212 File Offset: 0x00E62412
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			if (param == null)
			{
				return;
			}
			this.AddEvents();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603C1F3 RID: 246259 RVA: 0x00E64236 File Offset: 0x00E62436
		public override void Reset()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603C1F4 RID: 246260 RVA: 0x00E6425C File Offset: 0x00E6245C
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.RoleIntroductionViewHide, new Action(this.OnRoleIntroductionViewHide));
		}

		// Token: 0x0603C1F5 RID: 246261 RVA: 0x00E6427A File Offset: 0x00E6247A
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.RoleIntroductionViewHide, new Action(this.OnRoleIntroductionViewHide));
		}

		// Token: 0x0603C1F6 RID: 246262 RVA: 0x00E64298 File Offset: 0x00E62498
		private void OnRoleIntroductionViewHide()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Shouqi", false, null, false);
		}

		// Token: 0x0401F589 RID: 128393
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
