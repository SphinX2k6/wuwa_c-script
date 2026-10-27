using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065CC RID: 26060
	public class FishingFullTipItem : UiPanelBase
	{
		// Token: 0x060415D5 RID: 267733 RVA: 0x00FD71F8 File Offset: 0x00FD53F8
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

		// Token: 0x060415D6 RID: 267734 RVA: 0x00FD7240 File Offset: 0x00FD5440
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060415D7 RID: 267735 RVA: 0x00FD7253 File Offset: 0x00FD5453
		[NullableContext(1)]
		public void SetTxtInfo(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x060415D8 RID: 267736 RVA: 0x00FD7268 File Offset: 0x00FD5468
		[NullableContext(1)]
		public void PlayTipSequence([Nullable(2)] Action callback = null, string sequenceName = "Start", bool blockClick = true)
		{
			this.SetActive(true);
			this.LevelSequencePlayer.PlaySequenceAsync(sequenceName, new CustomPromise<bool>(), blockClick, false, null, false).Finally(delegate()
			{
				this.SetActive(false);
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}).Forget();
		}

		// Token: 0x04022022 RID: 139298
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C7F3 RID: 51187
		private class EComponentDefine
		{
			// Token: 0x0403C63C RID: 247356
			public const int TxtInfo = 0;
		}
	}
}
