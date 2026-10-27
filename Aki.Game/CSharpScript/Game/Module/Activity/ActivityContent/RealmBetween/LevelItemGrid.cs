using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006275 RID: 25205
	public class LevelItemGrid : GridProxyAbstract<int>
	{
		// Token: 0x0603F755 RID: 259925 RVA: 0x00F572C4 File Offset: 0x00F554C4
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

		// Token: 0x0603F756 RID: 259926 RVA: 0x00F57334 File Offset: 0x00F55534
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603F757 RID: 259927 RVA: 0x00F57347 File Offset: 0x00F55547
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

		// Token: 0x0603F758 RID: 259928 RVA: 0x00F57382 File Offset: 0x00F55582
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

		// Token: 0x0603F759 RID: 259929 RVA: 0x00F573AC File Offset: 0x00F555AC
		public override void OnSelected(bool fireEvent)
		{
			this.SetIsCurrentLevelItem(true);
		}

		// Token: 0x0603F75A RID: 259930 RVA: 0x00F573B8 File Offset: 0x00F555B8
		public void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("LevelUp", false, null, false);
		}

		// Token: 0x0603F75B RID: 259931 RVA: 0x00F573E8 File Offset: 0x00F555E8
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

		// Token: 0x0603F75C RID: 259932 RVA: 0x00F5743C File Offset: 0x00F5563C
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

		// Token: 0x04021280 RID: 135808
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
