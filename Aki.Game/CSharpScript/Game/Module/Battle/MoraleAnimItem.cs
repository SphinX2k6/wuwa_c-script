using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C50 RID: 23632
	public class MoraleAnimItem : UiPanelBase
	{
		// Token: 0x0603BBB2 RID: 244658 RVA: 0x00E44200 File Offset: 0x00E42400
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BBB3 RID: 244659 RVA: 0x00E4428A File Offset: 0x00E4248A
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnd), false);
		}

		// Token: 0x0603BBB4 RID: 244660 RVA: 0x00E442BA File Offset: 0x00E424BA
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			base.SetUiActive(false);
		}

		// Token: 0x0603BBB5 RID: 244661 RVA: 0x00E442C3 File Offset: 0x00E424C3
		public void Clear()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603BBB6 RID: 244662 RVA: 0x00E442D8 File Offset: 0x00E424D8
		public void PlayStartShowAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
			}
			base.SetUiActive(true);
			this.SetArrowVisible(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_title_41", Array.Empty<object>());
		}

		// Token: 0x0603BBB7 RID: 244663 RVA: 0x00E44344 File Offset: 0x00E42544
		public void PlayEndShowAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("StartR", false, false, null, null, false);
			}
			this.SetArrowVisible(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_title_42", Array.Empty<object>());
		}

		// Token: 0x0603BBB8 RID: 244664 RVA: 0x00E443AC File Offset: 0x00E425AC
		public void PlayLevelUpAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
			}
			this.SetArrowVisible(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_title_40", Array.Empty<object>());
		}

		// Token: 0x0603BBB9 RID: 244665 RVA: 0x00E4440F File Offset: 0x00E4260F
		[NullableContext(1)]
		public void SetText(string text)
		{
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0603BBBA RID: 244666 RVA: 0x00E44424 File Offset: 0x00E42624
		private void SetArrowVisible(bool visible)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(visible);
		}

		// Token: 0x0401F19A RID: 127386
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BE60 RID: 48736
		private enum EAnimItemChildType
		{
			// Token: 0x0403969A RID: 235162
			ArrowTexture,
			// Token: 0x0403969B RID: 235163
			BgSprite,
			// Token: 0x0403969C RID: 235164
			DescText
		}
	}
}
