using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E45 RID: 28229
	public class FishingQteRingBgSingleItem : UiPanelBase
	{
		// Token: 0x06044CFC RID: 281852 RVA: 0x010FAEA0 File Offset: 0x010F90A0
		public FishingQteRingBgSingleItem(int StartIndex, int EndIndex, bool IsWholeRing)
		{
			this.StartIndex = StartIndex;
			this.EndIndex = EndIndex;
			this.IsWholeRing = IsWholeRing;
		}

		// Token: 0x06044CFD RID: 281853 RVA: 0x010FAEC0 File Offset: 0x010F90C0
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

		// Token: 0x06044CFE RID: 281854 RVA: 0x010FAF6B File Offset: 0x010F916B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.Init();
		}

		// Token: 0x06044CFF RID: 281855 RVA: 0x010FAF84 File Offset: 0x010F9184
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06044D00 RID: 281856 RVA: 0x010FAFA0 File Offset: 0x010F91A0
		private void Init()
		{
			UUITexture texture = base.GetTexture(0);
			UUITexture texture2 = base.GetTexture(1);
			int num = Math.Max(this.StartIndex - 1, 0) * 10;
			FRotator frotator = Rotator.Create(0f, (float)(-(float)num), 0f).ToUeRotator();
			texture.SetUIRelativeRotation(frotator);
			texture2.SetUIRelativeRotation(frotator);
			int num2 = FishingQteDefine.calculateCellSize(this.StartIndex, this.EndIndex) / 36;
			texture.SetFillAmount((float)num2);
			texture2.SetFillAmount((float)num2);
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
			int num3 = this.EndIndex * 10;
			UUIItem uuiitem2 = item2;
			frotator2 = Rotator.Create(0f, (float)(-(float)num3) - 0.5f, 0f).ToUeRotator();
			uuiitem2.SetUIRelativeRotation(frotator2);
			item2.SetUIActive(true);
			item2.SetAsLastHierarchy();
		}

		// Token: 0x06044D01 RID: 281857 RVA: 0x010FB0C0 File Offset: 0x010F92C0
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

		// Token: 0x04023CC8 RID: 146632
		protected int StartIndex;

		// Token: 0x04023CC9 RID: 146633
		protected int EndIndex;

		// Token: 0x04023CCA RID: 146634
		protected bool IsWholeRing;

		// Token: 0x04023CCB RID: 146635
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CCFD RID: 52477
		private class EComponents
		{
			// Token: 0x0403DCF8 RID: 253176
			public const int TexBg = 0;

			// Token: 0x0403DCF9 RID: 253177
			public const int TexBgRed = 1;

			// Token: 0x0403DCFA RID: 253178
			public const int PanelLine1 = 2;

			// Token: 0x0403DCFB RID: 253179
			public const int PanelLine2 = 3;
		}
	}
}
