using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C34 RID: 23604
	public class FlagChallengeAnimItem : UiPanelBase
	{
		// Token: 0x0603BA44 RID: 244292 RVA: 0x00E3B644 File Offset: 0x00E39844
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

		// Token: 0x0603BA45 RID: 244293 RVA: 0x00E3B6CE File Offset: 0x00E398CE
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

		// Token: 0x0603BA46 RID: 244294 RVA: 0x00E3B6FE File Offset: 0x00E398FE
		[NullableContext(1)]
		private void OnSequenceEnd(string sequenceName)
		{
			base.SetUiActive(false);
		}

		// Token: 0x0603BA47 RID: 244295 RVA: 0x00E3B707 File Offset: 0x00E39907
		public void Clear()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603BA48 RID: 244296 RVA: 0x00E3B71C File Offset: 0x00E3991C
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

		// Token: 0x0603BA49 RID: 244297 RVA: 0x00E3B788 File Offset: 0x00E39988
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

		// Token: 0x0603BA4A RID: 244298 RVA: 0x00E3B7F0 File Offset: 0x00E399F0
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

		// Token: 0x0603BA4B RID: 244299 RVA: 0x00E3B853 File Offset: 0x00E39A53
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

		// Token: 0x0603BA4C RID: 244300 RVA: 0x00E3B868 File Offset: 0x00E39A68
		private void SetArrowVisible(bool visible)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(visible);
		}

		// Token: 0x0401F0C8 RID: 127176
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BE26 RID: 48678
		private enum EAnimItemComponentType
		{
			// Token: 0x04039575 RID: 234869
			ArrowTexture,
			// Token: 0x04039576 RID: 234870
			BgSprite,
			// Token: 0x04039577 RID: 234871
			DescText
		}
	}
}
