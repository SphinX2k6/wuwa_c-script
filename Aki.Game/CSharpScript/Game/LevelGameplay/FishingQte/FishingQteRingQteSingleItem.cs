using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E47 RID: 28231
	public class FishingQteRingQteSingleItem : UiPanelBase
	{
		// Token: 0x06044D15 RID: 281877 RVA: 0x010FB864 File Offset: 0x010F9A64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044D16 RID: 281878 RVA: 0x010FB930 File Offset: 0x010F9B30
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06044D17 RID: 281879 RVA: 0x010FB943 File Offset: 0x010F9B43
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.ProgressParamName = null;
		}

		// Token: 0x06044D18 RID: 281880 RVA: 0x010FB96C File Offset: 0x010F9B6C
		[NullableContext(1)]
		private List<UUITexture> GetAllTextures()
		{
			return new List<UUITexture>
			{
				base.GetTexture(0),
				base.GetTexture(1),
				base.GetTexture(2),
				base.GetTexture(3),
				base.GetTexture(4)
			};
		}

		// Token: 0x06044D19 RID: 281881 RVA: 0x010FB9C0 File Offset: 0x010F9BC0
		public void SetRotation(float angle)
		{
			foreach (UUIItem uuiitem in this.GetAllTextures())
			{
				FRotator frotator = Rotator.Create(0f, angle, 0f).ToUeRotator();
				uuiitem.SetUIRelativeRotation(frotator);
			}
		}

		// Token: 0x06044D1A RID: 281882 RVA: 0x010FBA28 File Offset: 0x010F9C28
		public void SetType(EFishingAreaType type)
		{
			if (type == EFishingAreaType.QteArea)
			{
				base.GetTexture(0).SetUIActive(true);
				base.GetTexture(3).SetUIActive(false);
				return;
			}
			if (type != EFishingAreaType.PerfectArea)
			{
				return;
			}
			base.GetTexture(0).SetUIActive(false);
			base.GetTexture(3).SetUIActive(true);
		}

		// Token: 0x06044D1B RID: 281883 RVA: 0x010FBA68 File Offset: 0x010F9C68
		public void SetFill(float amount)
		{
			foreach (UUITexture uuitexture in this.GetAllTextures())
			{
				uuitexture.SetFillAmount(amount);
				uuitexture.SetCustomMaterialScalarParameter(this.ProgressParamName.Value, amount);
			}
		}

		// Token: 0x06044D1C RID: 281884 RVA: 0x010FBACC File Offset: 0x010F9CCC
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

		// Token: 0x04023CD3 RID: 146643
		private FName? ProgressParamName = new FName?(new FName("Progress"));

		// Token: 0x04023CD4 RID: 146644
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CD01 RID: 52481
		private class EComponents
		{
			// Token: 0x0403DD0D RID: 253197
			public const int TexBg = 0;

			// Token: 0x0403DD0E RID: 253198
			public const int TexBgFail = 1;

			// Token: 0x0403DD0F RID: 253199
			public const int TexBgSuccess = 2;

			// Token: 0x0403DD10 RID: 253200
			public const int TexPerfect = 3;

			// Token: 0x0403DD11 RID: 253201
			public const int TexPerfect2 = 4;
		}
	}
}
