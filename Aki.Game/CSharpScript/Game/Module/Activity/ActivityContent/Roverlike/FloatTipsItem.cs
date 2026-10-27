using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006148 RID: 24904
	public class FloatTipsItem : SliderItem
	{
		// Token: 0x0603EF43 RID: 257859 RVA: 0x00F352E8 File Offset: 0x00F334E8
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

		// Token: 0x0603EF44 RID: 257860 RVA: 0x00F35330 File Offset: 0x00F33530
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x0603EF45 RID: 257861 RVA: 0x00F3535B File Offset: 0x00F3355B
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x0603EF46 RID: 257862 RVA: 0x00F35377 File Offset: 0x00F33577
		[NullableContext(1)]
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				base.FinishPlayStart();
				return;
			}
			if (sequenceName == "Close")
			{
				base.FinishPlayEnd();
			}
		}

		// Token: 0x0603EF47 RID: 257863 RVA: 0x00F353A0 File Offset: 0x00F335A0
		protected override void PlayStart()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603EF48 RID: 257864 RVA: 0x00F353C8 File Offset: 0x00F335C8
		public override void PlayEnd()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603EF49 RID: 257865 RVA: 0x00F353F0 File Offset: 0x00F335F0
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x0603EF4A RID: 257866 RVA: 0x00F353F4 File Offset: 0x00F335F4
		public override UniTask AsyncLoadUiResource()
		{
			FloatTipsItem.<AsyncLoadUiResource>d__10 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<FloatTipsItem.<AsyncLoadUiResource>d__10>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x04020DB6 RID: 134582
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020DB7 RID: 134583
		[Nullable(2)]
		private IRoverlikeFloatTextData Data;

		// Token: 0x0200C3A5 RID: 50085
		private class EFloatTipsItemCom
		{
			// Token: 0x0403B099 RID: 241817
			public const int TxtTips = 0;
		}
	}
}
