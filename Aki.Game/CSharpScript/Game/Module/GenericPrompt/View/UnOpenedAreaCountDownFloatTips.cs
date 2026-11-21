using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200498B RID: 18827
	public class UnOpenedAreaCountDownFloatTips : UiTickViewBase
	{
		// Token: 0x0602F2C6 RID: 193222 RVA: 0x00D25EDB File Offset: 0x00D240DB
		[NullableContext(1)]
		public UnOpenedAreaCountDownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2C7 RID: 193223 RVA: 0x00D25EEC File Offset: 0x00D240EC
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

		// Token: 0x0602F2C8 RID: 193224 RVA: 0x00D25F58 File Offset: 0x00D24158
		protected override void OnStart()
		{
			this.CountDownText = base.GetText(0);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			UnOpenedAreaCountDownFloatTipsParam unOpenedAreaCountDownFloatTipsParam = this.OpenParam as UnOpenedAreaCountDownFloatTipsParam;
			if (!string.IsNullOrEmpty((unOpenedAreaCountDownFloatTipsParam != null) ? unOpenedAreaCountDownFloatTipsParam.TidCountDownTip : null))
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(unOpenedAreaCountDownFloatTipsParam.TidCountDownTip);
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(configTextByKey, true);
				}
			}
			if (unOpenedAreaCountDownFloatTipsParam != null)
			{
				this.SetRemainTime(unOpenedAreaCountDownFloatTipsParam.RemainSec);
			}
		}

		// Token: 0x0602F2C9 RID: 193225 RVA: 0x00D25FD6 File Offset: 0x00D241D6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<float>(EEventName.OnUnOpenedAreaCountDownUpdate, new Action<float>(this.OnCountDownUpdate));
		}

		// Token: 0x0602F2CA RID: 193226 RVA: 0x00D25FF4 File Offset: 0x00D241F4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<float>(EEventName.OnUnOpenedAreaCountDownUpdate, new Action<float>(this.OnCountDownUpdate));
		}

		// Token: 0x0602F2CB RID: 193227 RVA: 0x00D26014 File Offset: 0x00D24214
		protected override void OnTick(float delta)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() != "Loop")
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}

		// Token: 0x0602F2CC RID: 193228 RVA: 0x00D26054 File Offset: 0x00D24254
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

		// Token: 0x0602F2CD RID: 193229 RVA: 0x00D26094 File Offset: 0x00D24294
		private void SetRemainTime(float remainTimeSec)
		{
			if (remainTimeSec <= 0f)
			{
				this.UpdateCountDown(0);
				return;
			}
			int num = (int)Math.Ceiling((double)remainTimeSec);
			if (num != this.LastDisplayNum)
			{
				this.UpdateCountDown(num);
			}
		}

		// Token: 0x0602F2CE RID: 193230 RVA: 0x00D260CA File Offset: 0x00D242CA
		private void UpdateCountDown(int second)
		{
			this.LastDisplayNum = second;
			this.CountDownText.SetText(second.ToString(), true);
		}

		// Token: 0x04019093 RID: 102547
		[Nullable(2)]
		private UUIText CountDownText;

		// Token: 0x04019094 RID: 102548
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019095 RID: 102549
		private int LastDisplayNum = -1;

		// Token: 0x0200A628 RID: 42536
		private class EChildComponent
		{
			// Token: 0x04033632 RID: 210482
			public const int CountDownText = 0;

			// Token: 0x04033633 RID: 210483
			public const int TipText = 1;
		}
	}
}
