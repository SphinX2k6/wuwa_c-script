using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C6 RID: 20678
	public class FloatTipsItem : SliderItem
	{
		// Token: 0x06033C03 RID: 211971 RVA: 0x00E7C1C8 File Offset: 0x00E7A3C8
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

		// Token: 0x06033C04 RID: 211972 RVA: 0x00E7C210 File Offset: 0x00E7A410
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x06033C05 RID: 211973 RVA: 0x00E7C23B File Offset: 0x00E7A43B
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x06033C06 RID: 211974 RVA: 0x00E7C257 File Offset: 0x00E7A457
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

		// Token: 0x06033C07 RID: 211975 RVA: 0x00E7C280 File Offset: 0x00E7A480
		protected override void PlayStart()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06033C08 RID: 211976 RVA: 0x00E7C2A8 File Offset: 0x00E7A4A8
		public override void PlayEnd()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06033C09 RID: 211977 RVA: 0x00E7C2D0 File Offset: 0x00E7A4D0
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x06033C0A RID: 211978 RVA: 0x00E7C2D4 File Offset: 0x00E7A4D4
		public override UniTask AsyncLoadUiResource()
		{
			FloatTipsItem.<AsyncLoadUiResource>d__10 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<FloatTipsItem.<AsyncLoadUiResource>d__10>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x0401B6E3 RID: 112355
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B6E4 RID: 112356
		[Nullable(2)]
		private IRoverlikeFloatTextData Data;

		// Token: 0x0200AD8C RID: 44428
		private class EFloatTipsItemCom
		{
			// Token: 0x040359FA RID: 219642
			public const int TxtTips = 0;
		}
	}
}
