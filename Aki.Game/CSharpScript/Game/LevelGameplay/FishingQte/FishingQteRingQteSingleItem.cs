using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC8 RID: 24520
	public class FishingQteRingQteSingleItem : UiPanelBase
	{
		// Token: 0x0603AEA2 RID: 241314 RVA: 0x010A5DE0 File Offset: 0x010A3FE0
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

		// Token: 0x0603AEA3 RID: 241315 RVA: 0x010A5EAC File Offset: 0x010A40AC
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603AEA4 RID: 241316 RVA: 0x010A5EBF File Offset: 0x010A40BF
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

		// Token: 0x0603AEA5 RID: 241317 RVA: 0x010A5EE8 File Offset: 0x010A40E8
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

		// Token: 0x0603AEA6 RID: 241318 RVA: 0x010A5F3C File Offset: 0x010A413C
		public void SetRotation(float angle)
		{
			foreach (UUIItem uuiitem in this.GetAllTextures())
			{
				FRotator frotator = Rotator.Create(0f, angle, 0f).ToUeRotator();
				uuiitem.SetUIRelativeRotation(frotator);
			}
		}

		// Token: 0x0603AEA7 RID: 241319 RVA: 0x010A5FA4 File Offset: 0x010A41A4
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

		// Token: 0x0603AEA8 RID: 241320 RVA: 0x010A5FE4 File Offset: 0x010A41E4
		public void SetFill(float amount)
		{
			foreach (UUITexture uuitexture in this.GetAllTextures())
			{
				uuitexture.SetFillAmount(amount);
				uuitexture.SetCustomMaterialScalarParameter(this.ProgressParamName.Value, amount);
			}
		}

		// Token: 0x0603AEA9 RID: 241321 RVA: 0x010A6048 File Offset: 0x010A4248
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

		// Token: 0x0401EF88 RID: 126856
		private FName? ProgressParamName = new FName?(new FName("Progress"));

		// Token: 0x0401EF89 RID: 126857
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B8F1 RID: 47345
		private class EComponents
		{
			// Token: 0x0403912F RID: 233775
			public const int TexBg = 0;

			// Token: 0x04039130 RID: 233776
			public const int TexBgFail = 1;

			// Token: 0x04039131 RID: 233777
			public const int TexBgSuccess = 2;

			// Token: 0x04039132 RID: 233778
			public const int TexPerfect = 3;

			// Token: 0x04039133 RID: 233779
			public const int TexPerfect2 = 4;
		}
	}
}
