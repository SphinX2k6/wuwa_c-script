using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F53 RID: 28499
	public class BigStuffedDollChallengeFailItem : UiPanelBase
	{
		// Token: 0x0604555D RID: 283997 RVA: 0x01128124 File Offset: 0x01126324
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604555E RID: 283998 RVA: 0x0112816C File Offset: 0x0112636C
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0604555F RID: 283999 RVA: 0x0112819D File Offset: 0x0112639D
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06045560 RID: 284000 RVA: 0x011281B8 File Offset: 0x011263B8
		[NullableContext(1)]
		public void ShowTip(string key)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, key, Array.Empty<object>());
			base.ShowAsync();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06045561 RID: 284001 RVA: 0x01128200 File Offset: 0x01126400
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
				return;
			}
			if (!(sequenceName == "Close"))
			{
				return;
			}
			base.HideAsync();
			BigStuffedDollModel.Instance.SetGameStage(EGameStage.Destroy);
		}

		// Token: 0x0402429D RID: 148125
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CD8B RID: 52619
		private class EViewComponent
		{
			// Token: 0x0403DEF9 RID: 253689
			public const int TextTip = 0;
		}
	}
}
