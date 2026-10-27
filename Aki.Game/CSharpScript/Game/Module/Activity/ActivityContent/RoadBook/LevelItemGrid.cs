using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061D2 RID: 25042
	public class LevelItemGrid : GridProxyAbstract<int>
	{
		// Token: 0x0603F3DC RID: 259036 RVA: 0x00F47B18 File Offset: 0x00F45D18
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIArtText))
			};
		}

		// Token: 0x0603F3DD RID: 259037 RVA: 0x00F47B88 File Offset: 0x00F45D88
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603F3DE RID: 259038 RVA: 0x00F47B9B File Offset: 0x00F45D9B
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText != null)
			{
				artText.SetText(data.ToString());
			}
			UUIArtText artText2 = base.GetArtText(3);
			if (artText2 != null)
			{
				artText2.SetText(data.ToString());
			}
			this.SetIsCurrentLevelItem(isSelected);
		}

		// Token: 0x0603F3DF RID: 259039 RVA: 0x00F47BD6 File Offset: 0x00F45DD6
		public void SetIsCurrentLevelItem(bool isActive)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(isActive);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!isActive);
		}

		// Token: 0x0603F3E0 RID: 259040 RVA: 0x00F47C00 File Offset: 0x00F45E00
		public override void OnSelected(bool fireEvent)
		{
			this.SetIsCurrentLevelItem(true);
		}

		// Token: 0x0603F3E1 RID: 259041 RVA: 0x00F47C0C File Offset: 0x00F45E0C
		public void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("LevelUp", false, null, false);
		}

		// Token: 0x0603F3E2 RID: 259042 RVA: 0x00F47C3C File Offset: 0x00F45E3C
		public void PlayBigAnim()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("TtoA", false, null, false);
		}

		// Token: 0x0603F3E3 RID: 259043 RVA: 0x00F47C90 File Offset: 0x00F45E90
		public void PlaySmallAnim()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("AtoT", false, null, false);
		}

		// Token: 0x04020F71 RID: 135025
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
