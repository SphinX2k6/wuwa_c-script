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
	// Token: 0x0200554A RID: 21834
	public class FishingFullTipItem : UiPanelBase
	{
		// Token: 0x0603629A RID: 221850 RVA: 0x00F1E238 File Offset: 0x00F1C438
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

		// Token: 0x0603629B RID: 221851 RVA: 0x00F1E280 File Offset: 0x00F1C480
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603629C RID: 221852 RVA: 0x00F1E293 File Offset: 0x00F1C493
		[NullableContext(1)]
		public void SetTxtInfo(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
		}

		// Token: 0x0603629D RID: 221853 RVA: 0x00F1E2A8 File Offset: 0x00F1C4A8
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

		// Token: 0x0401C953 RID: 117075
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B1D6 RID: 45526
		private class EComponentDefine
		{
			// Token: 0x04036F8A RID: 225162
			public const int TxtInfo = 0;
		}
	}
}
