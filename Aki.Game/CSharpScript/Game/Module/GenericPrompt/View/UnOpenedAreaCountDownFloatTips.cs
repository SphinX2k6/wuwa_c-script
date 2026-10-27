using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059B2 RID: 22962
	public class UnOpenedAreaCountDownFloatTips : UiTickViewBase
	{
		// Token: 0x0603A3A0 RID: 238496 RVA: 0x00DD6A4B File Offset: 0x00DD4C4B
		[NullableContext(1)]
		public UnOpenedAreaCountDownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3A1 RID: 238497 RVA: 0x00DD6A5C File Offset: 0x00DD4C5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A3A2 RID: 238498 RVA: 0x00DD6AC8 File Offset: 0x00DD4CC8
		protected override void OnStart()
		{
			this.CountDownText = base.GetText(0);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			UnOpenedAreaCountDownFloatTipsParam unOpenedAreaCountDownFloatTipsParam = this.OpenParam as UnOpenedAreaCountDownFloatTipsParam;
			if (!string.IsNullOrEmpty((unOpenedAreaCountDownFloatTipsParam != null) ? unOpenedAreaCountDownFloatTipsParam.TidCountDownTip : null))
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(unOpenedAreaCountDownFloatTipsParam.TidCountDownTip);
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(configTextByKey, true);
			}
		}

		// Token: 0x0603A3A3 RID: 238499 RVA: 0x00DD6B36 File Offset: 0x00DD4D36
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<float>(EEventName.OnUnOpenedAreaCountDownUpdate, new Action<float>(this.OnCountDownUpdate));
		}

		// Token: 0x0603A3A4 RID: 238500 RVA: 0x00DD6B54 File Offset: 0x00DD4D54
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<float>(EEventName.OnUnOpenedAreaCountDownUpdate, new Action<float>(this.OnCountDownUpdate));
		}

		// Token: 0x0603A3A5 RID: 238501 RVA: 0x00DD6B74 File Offset: 0x00DD4D74
		protected override void OnTick(float delta)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() != "Loop")
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}

		// Token: 0x0603A3A6 RID: 238502 RVA: 0x00DD6BB4 File Offset: 0x00DD4DB4
		private void OnCountDownUpdate(float remainTimeSec)
		{
			if (remainTimeSec <= 0f)
			{
				this.UpdateCountDown(0);
				base.CloseMe(null);
				return;
			}
			int num = (int)Math.Ceiling((double)remainTimeSec);
			if (num != this.LastDisplayNum)
			{
				this.UpdateCountDown(num);
			}
		}

		// Token: 0x0603A3A7 RID: 238503 RVA: 0x00DD6BF1 File Offset: 0x00DD4DF1
		private void UpdateCountDown(int second)
		{
			this.LastDisplayNum = second;
			this.CountDownText.SetText(second.ToString(), true);
		}

		// Token: 0x0401E5F4 RID: 124404
		[Nullable(2)]
		private UUIText CountDownText;

		// Token: 0x0401E5F5 RID: 124405
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E5F6 RID: 124406
		private int LastDisplayNum = -1;

		// Token: 0x0200BC1D RID: 48157
		private class EChildComponent
		{
			// Token: 0x04038C63 RID: 232547
			public const int CountDownText = 0;

			// Token: 0x04038C64 RID: 232548
			public const int TipText = 1;
		}
	}
}
