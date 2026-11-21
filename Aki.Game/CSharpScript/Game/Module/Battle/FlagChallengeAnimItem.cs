using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C14 RID: 19476
	public class FlagChallengeAnimItem : UiPanelBase
	{
		// Token: 0x0603098F RID: 199055 RVA: 0x00D8B9B4 File Offset: 0x00D89BB4
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

		// Token: 0x06030990 RID: 199056 RVA: 0x00D8BA3E File Offset: 0x00D89C3E
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

		// Token: 0x06030991 RID: 199057 RVA: 0x00D8BA6E File Offset: 0x00D89C6E
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			base.SetUiActive(false);
		}

		// Token: 0x06030992 RID: 199058 RVA: 0x00D8BA77 File Offset: 0x00D89C77
		public void Clear()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x06030993 RID: 199059 RVA: 0x00D8BA8C File Offset: 0x00D89C8C
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_32_title_41", Array.Empty<object>());
		}

		// Token: 0x06030994 RID: 199060 RVA: 0x00D8BAF8 File Offset: 0x00D89CF8
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_32_title_42", Array.Empty<object>());
		}

		// Token: 0x06030995 RID: 199061 RVA: 0x00D8BB60 File Offset: 0x00D89D60
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
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Morale_32_title_40", Array.Empty<object>());
		}

		// Token: 0x06030996 RID: 199062 RVA: 0x00D8BBC3 File Offset: 0x00D89DC3
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

		// Token: 0x06030997 RID: 199063 RVA: 0x00D8BBD8 File Offset: 0x00D89DD8
		private void SetArrowVisible(bool visible)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(visible);
		}

		// Token: 0x04019B79 RID: 105337
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A82E RID: 43054
		private enum EAnimItemComponentType
		{
			// Token: 0x04033F38 RID: 212792
			ArrowTexture,
			// Token: 0x04033F39 RID: 212793
			BgSprite,
			// Token: 0x04033F3A RID: 212794
			DescText
		}
	}
}
