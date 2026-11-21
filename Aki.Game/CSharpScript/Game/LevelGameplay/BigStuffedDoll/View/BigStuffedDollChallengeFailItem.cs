using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060D4 RID: 24788
	public class BigStuffedDollChallengeFailItem : UiPanelBase
	{
		// Token: 0x0603B70B RID: 243467 RVA: 0x010D1F04 File Offset: 0x010D0104
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

		// Token: 0x0603B70C RID: 243468 RVA: 0x010D1F4C File Offset: 0x010D014C
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0603B70D RID: 243469 RVA: 0x010D1F7D File Offset: 0x010D017D
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603B70E RID: 243470 RVA: 0x010D1F98 File Offset: 0x010D0198
		[NullableContext(1)]
		public void ShowTip(string key)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, key, Array.Empty<object>());
			base.ShowAsync();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B70F RID: 243471 RVA: 0x010D1FE0 File Offset: 0x010D01E0
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

		// Token: 0x0401F552 RID: 128338
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B97D RID: 47485
		private class EViewComponent
		{
			// Token: 0x04039328 RID: 234280
			public const int TextTip = 0;
		}
	}
}
