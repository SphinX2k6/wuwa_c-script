using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200400C RID: 16396
	[NullableContext(1)]
	[Nullable(0)]
	public class BlackScreenTextView : UiViewBase
	{
		// Token: 0x0602980E RID: 169998 RVA: 0x00BB7347 File Offset: 0x00BB5547
		public BlackScreenTextView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602980F RID: 169999 RVA: 0x00BB7350 File Offset: 0x00BB5550
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029810 RID: 170000 RVA: 0x00BB73FC File Offset: 0x00BB55FC
		protected override UniTask OnBeforeStartAsync()
		{
			BlackScreenTextView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BlackScreenTextView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029811 RID: 170001 RVA: 0x00BB7440 File Offset: 0x00BB5640
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			BlackScreenTextView.<OnPlayingStartSequenceAsync>d__5 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<BlackScreenTextView.<OnPlayingStartSequenceAsync>d__5>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029812 RID: 170002 RVA: 0x00BB7483 File Offset: 0x00BB5683
		protected override void OnBeforeDestroy()
		{
			this.StopAudio();
		}

		// Token: 0x06029813 RID: 170003 RVA: 0x00BB748C File Offset: 0x00BB568C
		private UniTask InitText(IFadeBackgroundUiPrefabBlackScreenWhiteText param)
		{
			BlackScreenTextView.<InitText>d__7 <InitText>d__;
			<InitText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitText>d__.<>4__this = this;
			<InitText>d__.param = param;
			<InitText>d__.<>1__state = -1;
			<InitText>d__.<>t__builder.Start<BlackScreenTextView.<InitText>d__7>(ref <InitText>d__);
			return <InitText>d__.<>t__builder.Task;
		}

		// Token: 0x06029814 RID: 170004 RVA: 0x00BB74D8 File Offset: 0x00BB56D8
		[NullableContext(2)]
		private void PlayAudio(string audioEvent)
		{
			if (string.IsNullOrEmpty(audioEvent))
			{
				return;
			}
			string text = AudioSystem.Instance.parseAudioEventPath(audioEvent);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			this.AudioHandle = AudioSystem.Instance.PostEvent(text);
			if (this.AudioHandle == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[BlackScreenText] 音频播放失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("akEvent", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06029815 RID: 170005 RVA: 0x00BB7544 File Offset: 0x00BB5744
		private void StopAudio()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
			this.AudioHandle = 0;
		}

		// Token: 0x04016A60 RID: 92768
		private int AudioHandle;

		// Token: 0x04016A61 RID: 92769
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
