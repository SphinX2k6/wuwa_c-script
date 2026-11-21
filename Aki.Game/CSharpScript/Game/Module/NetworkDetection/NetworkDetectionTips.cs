using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02004348 RID: 17224
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionTips : UiPanelBase
	{
		// Token: 0x0602B7E8 RID: 178152 RVA: 0x00C38AD8 File Offset: 0x00C36CD8
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

		// Token: 0x0602B7E9 RID: 178153 RVA: 0x00C38B41 File Offset: 0x00C36D41
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0602B7EA RID: 178154 RVA: 0x00C38B54 File Offset: 0x00C36D54
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Loop", false, null);
		}

		// Token: 0x0602B7EB RID: 178155 RVA: 0x00C38B80 File Offset: 0x00C36D80
		public void SetTextureIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x0602B7EC RID: 178156 RVA: 0x00C38B94 File Offset: 0x00C36D94
		public void SetTipsText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0602B7ED RID: 178157 RVA: 0x00C38BA9 File Offset: 0x00C36DA9
		public void SetTipsLocalText(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x0602B7EE RID: 178158 RVA: 0x00C38BC2 File Offset: 0x00C36DC2
		protected override void OnAfterHide()
		{
			this.RemoveTipTimer();
		}

		// Token: 0x0602B7EF RID: 178159 RVA: 0x00C38BCC File Offset: 0x00C36DCC
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

		// Token: 0x0602B7F0 RID: 178160 RVA: 0x00C38C1C File Offset: 0x00C36E1C
		private void RemoveTipTimer()
		{
			if (this.TipTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.TipTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TipTimerHandle);
			}
		}

		// Token: 0x040177F4 RID: 96244
		[Nullable(2)]
		private TimerHandle TipTimerHandle;

		// Token: 0x040177F5 RID: 96245
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200A006 RID: 40966
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04031B7F RID: 203647
			TxtTips,
			// Token: 0x04031B80 RID: 203648
			TexIcon
		}
	}
}
