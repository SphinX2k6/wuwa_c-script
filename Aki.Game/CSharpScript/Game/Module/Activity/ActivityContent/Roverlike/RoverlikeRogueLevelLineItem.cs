using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050BC RID: 20668
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeRogueLevelLineItem : GridProxyAbstract<IRoverlikeRogueLevelLineData>
	{
		// Token: 0x06033B9D RID: 211869 RVA: 0x00E7A334 File Offset: 0x00E78534
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033B9E RID: 211870 RVA: 0x00E7A4EB File Offset: 0x00E786EB
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033B9F RID: 211871 RVA: 0x00E7A500 File Offset: 0x00E78700
		public void PlayCurrentNodeSequence(string sequenceName)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x06033BA0 RID: 211872 RVA: 0x00E7A564 File Offset: 0x00E78764
		public override void Refresh(IRoverlikeRogueLevelLineData data, bool isSelected, int gridIndex)
		{
			bool isPassed = data.IsPassed;
			bool uiactive = data.IsCurrent && data.ShowCurrent;
			bool uiactive2 = !data.IsPassed && !data.IsCurrent;
			bool uiactive3 = data.LayerType == ERoverlikeRoadLayerType.Normal;
			bool uiactive4 = data.LayerType == ERoverlikeRoadLayerType.Elite;
			bool uiactive5 = data.LayerType == ERoverlikeRoadLayerType.Boss;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(uiactive3);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive4);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive5);
			}
			UUIItem item4 = base.GetItem(2);
			if (item4 != null)
			{
				item4.SetUIActive(uiactive);
			}
			UUIItem item5 = base.GetItem(9);
			if (item5 != null)
			{
				item5.SetUIActive(isPassed);
			}
			UUIItem item6 = base.GetItem(5);
			if (item6 != null)
			{
				item6.SetUIActive(uiactive);
			}
			UUIItem item7 = base.GetItem(10);
			if (item7 != null)
			{
				item7.SetUIActive(isPassed);
			}
			UUIItem item8 = base.GetItem(4);
			if (item8 != null)
			{
				item8.SetUIActive(uiactive2);
			}
			UUIItem item9 = base.GetItem(8);
			if (item9 != null)
			{
				item9.SetUIActive(uiactive);
			}
			UUIItem item10 = base.GetItem(11);
			if (item10 != null)
			{
				item10.SetUIActive(isPassed);
			}
			UUIItem item11 = base.GetItem(7);
			if (item11 != null)
			{
				item11.SetUIActive(uiactive2);
			}
			UUIItem item12 = base.GetItem(0);
			if (item12 == null)
			{
				return;
			}
			item12.SetUIActive(data.IsPassed);
		}

		// Token: 0x06033BA1 RID: 211873 RVA: 0x00E7A6AC File Offset: 0x00E788AC
		public override object GetKey(IRoverlikeRogueLevelLineData data, int gridIndex)
		{
			return gridIndex;
		}

		// Token: 0x0401B6C2 RID: 112322
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AD81 RID: 44417
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359C5 RID: 219589
			public const int SpriteLight = 0;

			// Token: 0x040359C6 RID: 219590
			public const int PanelPos = 1;

			// Token: 0x040359C7 RID: 219591
			public const int SpritePosLight = 2;

			// Token: 0x040359C8 RID: 219592
			public const int PanelMonster = 3;

			// Token: 0x040359C9 RID: 219593
			public const int PanelMonsterDark = 4;

			// Token: 0x040359CA RID: 219594
			public const int PanelMonsterLight = 5;

			// Token: 0x040359CB RID: 219595
			public const int PanelMonsterBoss = 6;

			// Token: 0x040359CC RID: 219596
			public const int PanelBossDark = 7;

			// Token: 0x040359CD RID: 219597
			public const int PanelBossLight = 8;

			// Token: 0x040359CE RID: 219598
			public const int SpritePosDone = 9;

			// Token: 0x040359CF RID: 219599
			public const int PanelMonsterDone = 10;

			// Token: 0x040359D0 RID: 219600
			public const int PanelBossDone = 11;
		}
	}
}
