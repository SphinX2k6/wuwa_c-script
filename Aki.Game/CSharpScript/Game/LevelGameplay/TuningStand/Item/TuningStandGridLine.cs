using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B2E RID: 23342
	public class TuningStandGridLine : UiPanelBase
	{
		// Token: 0x060396B1 RID: 235185 RVA: 0x0101D091 File Offset: 0x0101B291
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060396B2 RID: 235186 RVA: 0x0101D0CA File Offset: 0x0101B2CA
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

		// Token: 0x060396B3 RID: 235187 RVA: 0x0101D102 File Offset: 0x0101B302
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer = null;
		}

		// Token: 0x060396B4 RID: 235188 RVA: 0x0101D10C File Offset: 0x0101B30C
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

		// Token: 0x060396B5 RID: 235189 RVA: 0x0101D1D3 File Offset: 0x0101B3D3
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

		// Token: 0x0401E49F RID: 124063
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E4A0 RID: 124064
		protected bool CurVisible;
	}
}
