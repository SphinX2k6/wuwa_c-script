using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB2 RID: 19634
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleDungeonGuideButton : BattleEntranceButton
	{
		// Token: 0x06031148 RID: 201032 RVA: 0x00DB47EE File Offset: 0x00DB29EE
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

		// Token: 0x06031149 RID: 201033 RVA: 0x00DB4812 File Offset: 0x00DB2A12
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

		// Token: 0x0603114A RID: 201034 RVA: 0x00DB4838 File Offset: 0x00DB2A38
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.RoleIntroductionViewHide, new Action(this.OnRoleIntroductionViewHide));
		}

		// Token: 0x0603114B RID: 201035 RVA: 0x00DB4856 File Offset: 0x00DB2A56
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.RoleIntroductionViewHide, new Action(this.OnRoleIntroductionViewHide));
		}

		// Token: 0x0603114C RID: 201036 RVA: 0x00DB4874 File Offset: 0x00DB2A74
		private void OnRoleIntroductionViewHide()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Shouqi", false, null, false);
		}

		// Token: 0x0401A042 RID: 106562
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
