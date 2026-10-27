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
	// Token: 0x0200503D RID: 20541
	[NullableContext(1)]
	[Nullable(0)]
	public class BlackScreenTextView : UiViewBase
	{
		// Token: 0x06034932 RID: 215346 RVA: 0x00C6A2A7 File Offset: 0x00C684A7
		public BlackScreenTextView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034933 RID: 215347 RVA: 0x00C6A2B0 File Offset: 0x00C684B0
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

		// Token: 0x06034934 RID: 215348 RVA: 0x00C6A35C File Offset: 0x00C6855C
		protected override UniTask OnBeforeStartAsync()
		{
			BlackScreenTextView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BlackScreenTextView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034935 RID: 215349 RVA: 0x00C6A3A0 File Offset: 0x00C685A0
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			BlackScreenTextView.<OnPlayingStartSequenceAsync>d__5 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<BlackScreenTextView.<OnPlayingStartSequenceAsync>d__5>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034936 RID: 215350 RVA: 0x00C6A3E3 File Offset: 0x00C685E3
		protected override void OnBeforeDestroy()
		{
			this.StopAudio();
		}

		// Token: 0x06034937 RID: 215351 RVA: 0x00C6A3EC File Offset: 0x00C685EC
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

		// Token: 0x06034938 RID: 215352 RVA: 0x00C6A438 File Offset: 0x00C68638
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

		// Token: 0x06034939 RID: 215353 RVA: 0x00C6A4A4 File Offset: 0x00C686A4
		private void StopAudio()
		{
			if (this.AudioHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
			this.AudioHandle = 0;
		}

		// Token: 0x0401C03D RID: 114749
		private int AudioHandle;

		// Token: 0x0401C03E RID: 114750
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;
	}
}
