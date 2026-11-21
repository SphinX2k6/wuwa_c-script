using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005150 RID: 20816
	public class LevelItemGrid : GridProxyAbstract<int>
	{
		// Token: 0x0603409D RID: 213149 RVA: 0x00E8EA70 File Offset: 0x00E8CC70
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

		// Token: 0x0603409E RID: 213150 RVA: 0x00E8EAE0 File Offset: 0x00E8CCE0
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603409F RID: 213151 RVA: 0x00E8EAF3 File Offset: 0x00E8CCF3
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

		// Token: 0x060340A0 RID: 213152 RVA: 0x00E8EB2E File Offset: 0x00E8CD2E
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

		// Token: 0x060340A1 RID: 213153 RVA: 0x00E8EB58 File Offset: 0x00E8CD58
		public override void OnSelected(bool fireEvent)
		{
			this.SetIsCurrentLevelItem(true);
		}

		// Token: 0x060340A2 RID: 213154 RVA: 0x00E8EB64 File Offset: 0x00E8CD64
		public void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("LevelUp", false, null, false);
		}

		// Token: 0x060340A3 RID: 213155 RVA: 0x00E8EB94 File Offset: 0x00E8CD94
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

		// Token: 0x060340A4 RID: 213156 RVA: 0x00E8EBE8 File Offset: 0x00E8CDE8
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

		// Token: 0x0401B8A0 RID: 112800
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
