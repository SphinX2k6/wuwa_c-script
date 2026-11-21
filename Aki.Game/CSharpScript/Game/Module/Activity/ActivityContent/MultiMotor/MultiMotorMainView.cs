using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005314 RID: 21268
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorMainView : UiTickViewBase
	{
		// Token: 0x06034E8D RID: 216717 RVA: 0x00ECB98B File Offset: 0x00EC9B8B
		public MultiMotorMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034E8E RID: 216718 RVA: 0x00ECB9AC File Offset: 0x00EC9BAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034E8F RID: 216719 RVA: 0x00ECBB20 File Offset: 0x00EC9D20
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MultiMotorRankInfoRefresh, new Action(this.OnMultiMotorLevelRankBattleUpdate));
			EventSystem.Instance.Add(EEventName.MultiMotorStart, new Action(this.ShowAfterMatchStart));
			EventSystem.Instance.Add<int>(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
			EventSystem.Instance.Add<int, int>(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
		}

		// Token: 0x06034E90 RID: 216720 RVA: 0x00ECBBA0 File Offset: 0x00EC9DA0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MultiMotorRankInfoRefresh, new Action(this.OnMultiMotorLevelRankBattleUpdate));
			EventSystem.Instance.Remove(EEventName.MultiMotorStart, new Action(this.ShowAfterMatchStart));
			EventSystem.Instance.Remove(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
			EventSystem.Instance.Remove(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
		}

		// Token: 0x06034E91 RID: 216721 RVA: 0x00ECBC20 File Offset: 0x00EC9E20
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorMainView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorMainView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034E92 RID: 216722 RVA: 0x00ECBC63 File Offset: 0x00EC9E63
		protected override void OnBeforeDestroy()
		{
			this.ClearBroadcastTimer();
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.DriveMotorcycle, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
			{
				EBattleUiChild.Mission,
				EBattleUiChild.MiniMap,
				EBattleUiChild.Formation,
				EBattleUiChild.GamepadFormation,
				EBattleUiChild.TopButton,
				EBattleUiChild.HomeButton,
				EBattleUiChild.RoleState
			}), true, true, 0);
		}

		// Token: 0x06034E93 RID: 216723 RVA: 0x00ECBC98 File Offset: 0x00EC9E98
		private UniTask InitMoveCurve()
		{
			MultiMotorMainView.<InitMoveCurve>d__20 <InitMoveCurve>d__;
			<InitMoveCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveCurve>d__.<>4__this = this;
			<InitMoveCurve>d__.<>1__state = -1;
			<InitMoveCurve>d__.<>t__builder.Start<MultiMotorMainView.<InitMoveCurve>d__20>(ref <InitMoveCurve>d__);
			return <InitMoveCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06034E94 RID: 216724 RVA: 0x00ECBCDC File Offset: 0x00EC9EDC
		private UniTask InitLayout()
		{
			MultiMotorMainView.<InitLayout>d__21 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<MultiMotorMainView.<InitLayout>d__21>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06034E95 RID: 216725 RVA: 0x00ECBD1F File Offset: 0x00EC9F1F
		private void InitGridItemHeight()
		{
			this.GridItemHeight = (int)base.GetItem(4).Height;
		}

		// Token: 0x06034E96 RID: 216726 RVA: 0x00ECBD34 File Offset: 0x00EC9F34
		private UniTask CreateRankItem(int playerId, int index)
		{
			MultiMotorMainView.<CreateRankItem>d__23 <CreateRankItem>d__;
			<CreateRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRankItem>d__.<>4__this = this;
			<CreateRankItem>d__.playerId = playerId;
			<CreateRankItem>d__.index = index;
			<CreateRankItem>d__.<>1__state = -1;
			<CreateRankItem>d__.<>t__builder.Start<MultiMotorMainView.<CreateRankItem>d__23>(ref <CreateRankItem>d__);
			return <CreateRankItem>d__.<>t__builder.Task;
		}

		// Token: 0x06034E97 RID: 216727 RVA: 0x00ECBD88 File Offset: 0x00EC9F88
		private UUIItem CreateItemActor()
		{
			UUIItem item = base.GetItem(4);
			return LguiUtil.Instance.CopyItem(item, base.GetItem(3));
		}

		// Token: 0x06034E98 RID: 216728 RVA: 0x00ECBDAF File Offset: 0x00EC9FAF
		protected override void OnStart()
		{
			base.GetItem(5).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			this.ShowBeforeMatchStart();
			MoonTogetherModel.Instance.IsInMoonTogether = true;
		}

		// Token: 0x06034E99 RID: 216729 RVA: 0x00ECBDDC File Offset: 0x00EC9FDC
		protected override void OnBeforeShow()
		{
			MultiMotorController instance = MultiMotorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OnMultiMotorMainViewOpened();
		}

		// Token: 0x06034E9A RID: 216730 RVA: 0x00ECBDF0 File Offset: 0x00EC9FF0
		private void ShowBeforeMatchStart()
		{
			Log.Instance.Info(ELogModule.MotorParkour, ELogAuthor.LJQ, "ShowBeforeMatchStart", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.GetItem(9).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x06034E9B RID: 216731 RVA: 0x00ECBE38 File Offset: 0x00ECA038
		private void ShowAfterMatchStart()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorParkour;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "ShowAfterMatchStart";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("StartFlowTime", MultiMotorModel.Instance.StartFlowTime);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetItem(9).SetUIActive(true);
			base.GetItem(8).SetUIActive(true);
			this.ShowBroadcast(1);
			this.StartFlowTime = MultiMotorModel.Instance.StartFlowTime;
		}

		// Token: 0x06034E9C RID: 216732 RVA: 0x00ECBEB0 File Offset: 0x00ECA0B0
		private void OnMultiMotorPassLine(int playerId)
		{
			Dictionary<int, int> levelRankBattleMap = MultiMotorModel.Instance.GetLevelRankBattleMap();
			int num;
			int key = (levelRankBattleMap != null && levelRankBattleMap.TryGetValue(playerId, out num)) ? num : 0;
			EMultiMotorBroadcastGroup emultiMotorBroadcastGroup;
			int broadcastGroup = (int)(MultiMotorDefine.MultiMotorRankToBroadcastGroup.TryGetValue(key, out emultiMotorBroadcastGroup) ? emultiMotorBroadcastGroup : EMultiMotorBroadcastGroup.MatchPassLine);
			this.ShowBroadcast(broadcastGroup);
		}

		// Token: 0x06034E9D RID: 216733 RVA: 0x00ECBEF8 File Offset: 0x00ECA0F8
		private void OnMultiMotorBuffRefresh(int playerId, int buffId)
		{
			int? id = PlayerInfoModel.Instance.GetId();
			if (!(playerId == id.GetValueOrDefault() & id != null))
			{
				return;
			}
			MotorOnlineBuff? motorBuffById = MultiMotorConfig.Instance.GetMotorBuffById(buffId);
			if (motorBuffById == null || motorBuffById.Value.BroadcastGroup == 0)
			{
				return;
			}
			this.ShowBroadcast(motorBuffById.Value.BroadcastGroup);
		}

		// Token: 0x06034E9E RID: 216734 RVA: 0x00ECBF64 File Offset: 0x00ECA164
		private void RefreshRankInfo()
		{
			Dictionary<int, int> levelRankBattleMap = MultiMotorModel.Instance.GetLevelRankBattleMap();
			if (levelRankBattleMap == null)
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair in levelRankBattleMap)
			{
				int playerId = keyValuePair.Key;
				int rankNumber = keyValuePair.Value;
				MultiMotorRankItem multiMotorRankItem;
				if (!this.RankItemMap.TryGetValue(playerId, out multiMotorRankItem) && !this.CreatingRankItemSet.Contains(playerId))
				{
					this.CreatingRankItemSet.Add(playerId);
					int index = this.RankItemMap.Count + this.CreatingRankItemSet.Count - 1;
					this.CreateRankItem(playerId, index).ContinueWith(delegate()
					{
						this.CreatingRankItemSet.Remove(playerId);
						MultiMotorRankItem multiMotorRankItem2;
						if (this.RankItemMap.TryGetValue(playerId, out multiMotorRankItem2))
						{
							multiMotorRankItem2.RefreshRankNumber(rankNumber);
							float offsetY2 = this.DefaultOffsetY - (float)((rankNumber - 1) * (this.GridItemHeight + 20));
							multiMotorRankItem2.RefreshOffsetY(offsetY2);
						}
					});
				}
				else
				{
					if (multiMotorRankItem != null)
					{
						multiMotorRankItem.RefreshRankNumber(rankNumber);
					}
					float offsetY = this.DefaultOffsetY - (float)((rankNumber - 1) * (this.GridItemHeight + 20));
					if (multiMotorRankItem != null)
					{
						multiMotorRankItem.RefreshOffsetY(offsetY);
					}
				}
			}
		}

		// Token: 0x06034E9F RID: 216735 RVA: 0x00ECC098 File Offset: 0x00ECA298
		private void OnMultiMotorLevelRankBattleUpdate()
		{
			this.RefreshRankInfo();
		}

		// Token: 0x06034EA0 RID: 216736 RVA: 0x00ECC0A0 File Offset: 0x00ECA2A0
		protected override void OnTick(float delta)
		{
			this.MapItem.UpdatePlayerPosition();
			this.RefreshTimeText();
			foreach (KeyValuePair<int, MultiMotorRankItem> keyValuePair in this.RankItemMap)
			{
				keyValuePair.Value.TickAccelerateCountdown(delta);
			}
		}

		// Token: 0x06034EA1 RID: 216737 RVA: 0x00ECC10C File Offset: 0x00ECA30C
		public void ShowBroadcast(int broadcastGroup)
		{
			IReadOnlyList<OnlineMotorBroadcast> motorBroadcastByGroup = MultiMotorConfig.Instance.GetMotorBroadcastByGroup(broadcastGroup);
			if (motorBroadcastByGroup == null || motorBroadcastByGroup.Count <= 0)
			{
				return;
			}
			OnlineMotorBroadcast onlineMotorBroadcast = motorBroadcastByGroup[(int)MathUtils.Instance.GetRandomRange(0.0, (double)(motorBroadcastByGroup.Count - 1))];
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), onlineMotorBroadcast.Speaker, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), onlineMotorBroadcast.Content, Array.Empty<object>());
			base.GetItem(5).SetUIActive(true);
			this.BroadcastSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			this.ClearBroadcastTimer();
			this.BroadcastTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.BroadcastTimerHandle = null;
				this.BroadcastSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			}, 5000f, null, null, true, 1f);
		}

		// Token: 0x06034EA2 RID: 216738 RVA: 0x00ECC1E7 File Offset: 0x00ECA3E7
		private void OnBroadcastSequenceClose(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetItem(5).SetUIActive(false);
			}
		}

		// Token: 0x06034EA3 RID: 216739 RVA: 0x00ECC203 File Offset: 0x00ECA403
		private void ClearBroadcastTimer()
		{
			if (this.BroadcastTimerHandle != null)
			{
				this.BroadcastTimerHandle.Remove();
				this.BroadcastTimerHandle = null;
			}
		}

		// Token: 0x06034EA4 RID: 216740 RVA: 0x00ECC220 File Offset: 0x00ECA420
		private void RefreshTimeText()
		{
			if (this.StartFlowTime == 0L)
			{
				return;
			}
			double num = (TimeUtil.Instance.GetServerTimeStamp() - (double)this.StartFlowTime) * TimeUtil.Instance.Millisecond;
			if (Time.Instance.FlowTimeDilation == 0f)
			{
				return;
			}
			long num2 = (long)Math.Floor(num % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			string value = ((num2 < 10L) ? "0" : "") + num2.ToString();
			long num3 = (long)Math.Floor(num % TimeUtil.Instance.Minute);
			string value2 = ((num3 < 10L) ? "0" : "") + num3.ToString();
			long num4 = (long)Math.Floor((num - Math.Floor(num)) * 100.0);
			string value3 = ((num4 < 10L) ? "0" : "") + num4.ToString();
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0401BFAB RID: 114603
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x0401BFAC RID: 114604
		private const int ITEM_HEIGHT_INTERVAL = 20;

		// Token: 0x0401BFAD RID: 114605
		private const int BROADCAST_TIME = 5000;

		// Token: 0x0401BFAE RID: 114606
		private MultiMotorLevelData LevelData;

		// Token: 0x0401BFAF RID: 114607
		private readonly Dictionary<int, MultiMotorRankItem> RankItemMap = new Dictionary<int, MultiMotorRankItem>();

		// Token: 0x0401BFB0 RID: 114608
		private readonly HashSet<int> CreatingRankItemSet = new HashSet<int>();

		// Token: 0x0401BFB1 RID: 114609
		protected UCurveFloat LerpCurve;

		// Token: 0x0401BFB2 RID: 114610
		protected float DefaultOffsetY;

		// Token: 0x0401BFB3 RID: 114611
		protected int GridItemHeight;

		// Token: 0x0401BFB4 RID: 114612
		private MultiMotorParkourMapItem MapItem;

		// Token: 0x0401BFB5 RID: 114613
		private long StartFlowTime;

		// Token: 0x0401BFB6 RID: 114614
		private LevelSequencePlayer BroadcastSequencePlayer;

		// Token: 0x0401BFB7 RID: 114615
		[Nullable(2)]
		private TimerHandle BroadcastTimerHandle;

		// Token: 0x0200AF8F RID: 44943
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036425 RID: 222245
			public const int TopMapItem = 0;

			// Token: 0x04036426 RID: 222246
			public const int LapCountText = 1;

			// Token: 0x04036427 RID: 222247
			public const int TimeText = 2;

			// Token: 0x04036428 RID: 222248
			public const int ContentItem = 3;

			// Token: 0x04036429 RID: 222249
			public const int RankTempItem = 4;

			// Token: 0x0403642A RID: 222250
			public const int BroadcastItem = 5;

			// Token: 0x0403642B RID: 222251
			public const int BroadcastTitleText = 6;

			// Token: 0x0403642C RID: 222252
			public const int BroadcastDesText = 7;

			// Token: 0x0403642D RID: 222253
			public const int MissionItem = 8;

			// Token: 0x0403642E RID: 222254
			public const int TimeItem = 9;
		}
	}
}
