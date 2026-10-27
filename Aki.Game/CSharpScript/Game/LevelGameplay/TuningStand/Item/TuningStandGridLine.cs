using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069D2 RID: 27090
	public class TuningStandGridLine : UiPanelBase
	{
		// Token: 0x06043675 RID: 276085 RVA: 0x01078BDD File Offset: 0x01076DDD
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06043676 RID: 276086 RVA: 0x01078C16 File Offset: 0x01076E16
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06043677 RID: 276087 RVA: 0x01078C4E File Offset: 0x01076E4E
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06043678 RID: 276088 RVA: 0x01078C58 File Offset: 0x01076E58
		public void Refresh(bool isVisible, EGridBelongType type = EGridBelongType.Empty)
		{
			if (isVisible)
			{
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(type == EGridBelongType.Type1);
				}
				UUIItem item2 = base.GetItem(0);
				if (item2 != null)
				{
					item2.SetUIActive(type == EGridBelongType.Type2);
				}
			}
			if (!isVisible || this.CurVisible)
			{
				if (!isVisible && this.CurVisible)
				{
					this.CurVisible = false;
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopCurrentSequence(false, false);
					}
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
				}
				return;
			}
			this.CurVisible = true;
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06043679 RID: 276089 RVA: 0x01078D1F File Offset: 0x01076F1F
		public void HideLine()
		{
			this.CurVisible = false;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x040232AF RID: 144047
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040232B0 RID: 144048
		protected bool CurVisible;
	}
}
