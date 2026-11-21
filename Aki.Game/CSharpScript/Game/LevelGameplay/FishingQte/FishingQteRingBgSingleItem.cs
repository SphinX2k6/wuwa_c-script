using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC6 RID: 24518
	public class FishingQteRingBgSingleItem : UiPanelBase
	{
		// Token: 0x0603AE89 RID: 241289 RVA: 0x010A5420 File Offset: 0x010A3620
		public FishingQteRingBgSingleItem(int StartIndex, int EndIndex, bool IsWholeRing)
		{
			this.StartIndex = StartIndex;
			this.EndIndex = EndIndex;
			this.IsWholeRing = IsWholeRing;
		}

		// Token: 0x0603AE8A RID: 241290 RVA: 0x010A5440 File Offset: 0x010A3640
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE8B RID: 241291 RVA: 0x010A54EB File Offset: 0x010A36EB
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.Init();
		}

		// Token: 0x0603AE8C RID: 241292 RVA: 0x010A5504 File Offset: 0x010A3704
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603AE8D RID: 241293 RVA: 0x010A5520 File Offset: 0x010A3720
		private void Init()
		{
			UUITexture texture = base.GetTexture(0);
			UUITexture texture2 = base.GetTexture(1);
			int num = Math.Max(this.StartIndex - 1, 0) * 10;
			FRotator frotator = Rotator.Create(0f, (float)(-(float)num), 0f).ToUeRotator();
			texture.SetUIRelativeRotation(frotator);
			texture2.SetUIRelativeRotation(frotator);
			float fillAmount = (float)FishingQteDefine.calculateCellSize(this.StartIndex, this.EndIndex) / 36f;
			texture.SetFillAmount(fillAmount);
			texture2.SetFillAmount(fillAmount);
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(3);
			if (this.IsWholeRing)
			{
				item.SetUIActive(false);
				item2.SetUIActive(false);
				return;
			}
			UUIItem uuiitem = item;
			FRotator frotator2 = Rotator.Create(0f, (float)(-(float)num) + 0.5f, 0f).ToUeRotator();
			uuiitem.SetUIRelativeRotation(frotator2);
			item.SetUIActive(true);
			item.SetAsLastHierarchy();
			int num2 = this.EndIndex * 10;
			UUIItem uuiitem2 = item2;
			frotator2 = Rotator.Create(0f, (float)(-(float)num2) - 0.5f, 0f).ToUeRotator();
			uuiitem2.SetUIRelativeRotation(frotator2);
			item2.SetUIActive(true);
			item2.SetAsLastHierarchy();
		}

		// Token: 0x0603AE8E RID: 241294 RVA: 0x010A5644 File Offset: 0x010A3844
		[NullableContext(1)]
		public void PlayAnim(string sequenceName)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.LevelSequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0401EF7D RID: 126845
		protected int StartIndex;

		// Token: 0x0401EF7E RID: 126846
		protected int EndIndex;

		// Token: 0x0401EF7F RID: 126847
		protected bool IsWholeRing;

		// Token: 0x0401EF80 RID: 126848
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B8ED RID: 47341
		private class EComponents
		{
			// Token: 0x0403911A RID: 233754
			public const int TexBg = 0;

			// Token: 0x0403911B RID: 233755
			public const int TexBgRed = 1;

			// Token: 0x0403911C RID: 233756
			public const int PanelLine1 = 2;

			// Token: 0x0403911D RID: 233757
			public const int PanelLine2 = 3;
		}
	}
}
