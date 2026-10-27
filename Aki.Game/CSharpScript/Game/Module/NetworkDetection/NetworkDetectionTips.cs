using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02005365 RID: 21349
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionTips : UiPanelBase
	{
		// Token: 0x060368A2 RID: 223394 RVA: 0x00CE9C50 File Offset: 0x00CE7E50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060368A3 RID: 223395 RVA: 0x00CE9CB9 File Offset: 0x00CE7EB9
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x060368A4 RID: 223396 RVA: 0x00CE9CCC File Offset: 0x00CE7ECC
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Loop", false, null);
		}

		// Token: 0x060368A5 RID: 223397 RVA: 0x00CE9CF8 File Offset: 0x00CE7EF8
		public void SetTextureIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x060368A6 RID: 223398 RVA: 0x00CE9D0C File Offset: 0x00CE7F0C
		public void SetTipsText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x060368A7 RID: 223399 RVA: 0x00CE9D21 File Offset: 0x00CE7F21
		public void SetTipsLocalText(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x060368A8 RID: 223400 RVA: 0x00CE9D3A File Offset: 0x00CE7F3A
		protected override void OnAfterHide()
		{
			this.RemoveTipTimer();
		}

		// Token: 0x060368A9 RID: 223401 RVA: 0x00CE9D44 File Offset: 0x00CE7F44
		public void ShowTip(string textKey)
		{
			this.SetTipsLocalText(textKey);
			base.Show(null);
			this.RemoveTipTimer();
			this.TipTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				base.Hide(null);
			}, (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x060368AA RID: 223402 RVA: 0x00CE9D94 File Offset: 0x00CE7F94
		private void RemoveTipTimer()
		{
			if (this.TipTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.TipTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TipTimerHandle);
			}
		}

		// Token: 0x0401CD60 RID: 118112
		[Nullable(2)]
		private TimerHandle TipTimerHandle;

		// Token: 0x0401CD61 RID: 118113
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B5CD RID: 46541
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04037127 RID: 225575
			TxtTips,
			// Token: 0x04037128 RID: 225576
			TexIcon
		}
	}
}
