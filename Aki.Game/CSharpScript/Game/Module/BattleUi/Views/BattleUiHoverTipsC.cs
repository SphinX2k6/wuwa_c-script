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
	// Token: 0x02005D93 RID: 23955
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiHoverTipsC : BattleChildView
	{
		// Token: 0x0603CCB7 RID: 249015 RVA: 0x00E99094 File Offset: 0x00E97294
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleUiHoverTipsC.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleUiHoverTipsC.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCB8 RID: 249016 RVA: 0x00E990D8 File Offset: 0x00E972D8
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

		// Token: 0x0603CCB9 RID: 249017 RVA: 0x00E99144 File Offset: 0x00E97344
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

		// Token: 0x0603CCBA RID: 249018 RVA: 0x00E991CC File Offset: 0x00E973CC
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

		// Token: 0x0603CCBB RID: 249019 RVA: 0x00E99238 File Offset: 0x00E97438
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603CCBC RID: 249020 RVA: 0x00E9926F File Offset: 0x00E9746F
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

		// Token: 0x0603CCBD RID: 249021 RVA: 0x00E99294 File Offset: 0x00E97494
		private void StartCountdown()
		{
			int num = 8000;
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), (float)num, null, null, true, 1f);
		}

		// Token: 0x0603CCBE RID: 249022 RVA: 0x00E992D0 File Offset: 0x00E974D0
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

		// Token: 0x0603CCBF RID: 249023 RVA: 0x00E99330 File Offset: 0x00E97530
		private void OnTimerEnd(float _ = 0f)
		{
			if (this.TimerHandle == null)
			{
				return;
			}
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleMoraleBuffInfo);
		}

		// Token: 0x0603CCC0 RID: 249024 RVA: 0x00E99351 File Offset: 0x00E97551
		protected override void OnBeforeDestroy()
		{
			this.OnTimerEnd(0f);
		}

		// Token: 0x0401FABC RID: 129724
		private bool Created;

		// Token: 0x0401FABD RID: 129725
		private TimerHandle TimerHandle;

		// Token: 0x0401FABE RID: 129726
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FABF RID: 129727
		private IBattleUiHoverTipsC Info;

		// Token: 0x0401FAC0 RID: 129728
		private BattleUiInfoItem InfoItem;

		// Token: 0x0200C04E RID: 49230
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A08F RID: 237711
			SpriteBg,
			// Token: 0x0403A090 RID: 237712
			ItemInfo
		}
	}
}
