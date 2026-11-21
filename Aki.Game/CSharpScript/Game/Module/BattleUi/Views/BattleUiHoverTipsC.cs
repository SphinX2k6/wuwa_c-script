using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D75 RID: 19829
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiHoverTipsC : BattleChildView
	{
		// Token: 0x06031C14 RID: 203796 RVA: 0x00DE994C File Offset: 0x00DE7B4C
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleUiHoverTipsC.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleUiHoverTipsC.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C15 RID: 203797 RVA: 0x00DE9990 File Offset: 0x00DE7B90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031C16 RID: 203798 RVA: 0x00DE99FC File Offset: 0x00DE7BFC
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorHAlign(UIAnchorHorizontalAlign.Center);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 != null)
			{
				rootItem2.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
			}
			UUIItem rootItem3 = this.RootItem;
			if (rootItem3 != null)
			{
				rootItem3.SetAnchorOffsetX(0f);
			}
			UUIItem rootItem4 = this.RootItem;
			if (rootItem4 != null)
			{
				rootItem4.SetAnchorOffsetY(0f);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.SetActive(false);
				}
			}, false);
		}

		// Token: 0x06031C17 RID: 203799 RVA: 0x00DE9A84 File Offset: 0x00DE7C84
		[NullableContext(1)]
		public void CreateAndShow(UUIItem parent, IBattleUiHoverTipsC info)
		{
			string resourceId = "UiItem_HoverTipsC";
			if (this.Created)
			{
				this.UpdateInfo(info);
				this.SetActive(true);
				this.StartCountdown();
				return;
			}
			base.NewByResourceId(parent, resourceId, false, null).ContinueWith(delegate()
			{
				this.Created = true;
				this.UpdateInfo(info);
				this.StartCountdown();
			}).Forget();
		}

		// Token: 0x06031C18 RID: 203800 RVA: 0x00DE9AF0 File Offset: 0x00DE7CF0
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06031C19 RID: 203801 RVA: 0x00DE9B27 File Offset: 0x00DE7D27
		[NullableContext(1)]
		public void UpdateInfo(IBattleUiHoverTipsC info)
		{
			this.Info = info;
			if (!this.Created)
			{
				return;
			}
			BattleUiInfoItem infoItem = this.InfoItem;
			if (infoItem == null)
			{
				return;
			}
			infoItem.Refresh(info);
		}

		// Token: 0x06031C1A RID: 203802 RVA: 0x00DE9B4C File Offset: 0x00DE7D4C
		private void StartCountdown()
		{
			int num = 8000;
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), (float)num, null, null, true, 1f);
		}

		// Token: 0x06031C1B RID: 203803 RVA: 0x00DE9B88 File Offset: 0x00DE7D88
		public void EndShow()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06031C1C RID: 203804 RVA: 0x00DE9BE8 File Offset: 0x00DE7DE8
		private void OnTimerEnd(float _ = 0f)
		{
			if (this.TimerHandle == null)
			{
				return;
			}
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleMoraleBuffInfo);
		}

		// Token: 0x06031C1D RID: 203805 RVA: 0x00DE9C09 File Offset: 0x00DE7E09
		protected override void OnBeforeDestroy()
		{
			this.OnTimerEnd(0f);
		}

		// Token: 0x0401A574 RID: 107892
		private bool Created;

		// Token: 0x0401A575 RID: 107893
		private TimerHandle TimerHandle;

		// Token: 0x0401A576 RID: 107894
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A577 RID: 107895
		private IBattleUiHoverTipsC Info;

		// Token: 0x0401A578 RID: 107896
		private BattleUiInfoItem InfoItem;

		// Token: 0x0200AA54 RID: 43604
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034A52 RID: 215634
			SpriteBg,
			// Token: 0x04034A53 RID: 215635
			ItemInfo
		}
	}
}
