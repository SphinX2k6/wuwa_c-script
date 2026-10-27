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
	// Token: 0x02006396 RID: 25494
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorMainView : UiTickViewBase
	{
		// Token: 0x060401CC RID: 262604 RVA: 0x00F84A17 File Offset: 0x00F82C17
		public MultiMotorMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060401CD RID: 262605 RVA: 0x00F84A38 File Offset: 0x00F82C38
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

		// Token: 0x060401CE RID: 262606 RVA: 0x00F84BAC File Offset: 0x00F82DAC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MultiMotorRankInfoRefresh, new Action(this.OnMultiMotorLevelRankBattleUpdate));
			EventSystem.Instance.Add(EEventName.MultiMotorStart, new Action(this.ShowAfterMatchStart));
			EventSystem.Instance.Add<int>(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
			EventSystem.Instance.Add<int, int>(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
		}

		// Token: 0x060401CF RID: 262607 RVA: 0x00F84C2C File Offset: 0x00F82E2C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MultiMotorRankInfoRefresh, new Action(this.OnMultiMotorLevelRankBattleUpdate));
			EventSystem.Instance.Remove(EEventName.MultiMotorStart, new Action(this.ShowAfterMatchStart));
			EventSystem.Instance.Remove(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
			EventSystem.Instance.Remove(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
		}

		// Token: 0x060401D0 RID: 262608 RVA: 0x00F84CAC File Offset: 0x00F82EAC
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorMainView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorMainView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060401D1 RID: 262609 RVA: 0x00F84CEF File Offset: 0x00F82EEF
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

		// Token: 0x060401D2 RID: 262610 RVA: 0x00F84D24 File Offset: 0x00F82F24
		private UniTask InitMoveCurve()
		{
			MultiMotorMainView.<InitMoveCurve>d__20 <InitMoveCurve>d__;
			<InitMoveCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveCurve>d__.<>4__this = this;
			<InitMoveCurve>d__.<>1__state = -1;
			<InitMoveCurve>d__.<>t__builder.Start<MultiMotorMainView.<InitMoveCurve>d__20>(ref <InitMoveCurve>d__);
			return <InitMoveCurve>d__.<>t__builder.Task;
		}

		// Token: 0x060401D3 RID: 262611 RVA: 0x00F84D68 File Offset: 0x00F82F68
		private UniTask InitLayout()
		{
			MultiMotorMainView.<InitLayout>d__21 <InitLayout>d__;
			<InitLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLayout>d__.<>4__this = this;
			<InitLayout>d__.<>1__state = -1;
			<InitLayout>d__.<>t__builder.Start<MultiMotorMainView.<InitLayout>d__21>(ref <InitLayout>d__);
			return <InitLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060401D4 RID: 262612 RVA: 0x00F84DAB File Offset: 0x00F82FAB
		private void InitGridItemHeight()
		{
			this.GridItemHeight = (int)base.GetItem(4).Height;
		}

		// Token: 0x060401D5 RID: 262613 RVA: 0x00F84DC0 File Offset: 0x00F82FC0
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

		// Token: 0x060401D6 RID: 262614 RVA: 0x00F84E14 File Offset: 0x00F83014
		private UUIItem CreateItemActor()
		{
			UUIItem item = base.GetItem(4);
			return LguiUtil.Instance.CopyItem(item, base.GetItem(3));
		}

		// Token: 0x060401D7 RID: 262615 RVA: 0x00F84E3B File Offset: 0x00F8303B
		protected override void OnStart()
		{
			base.GetItem(5).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			this.ShowBeforeMatchStart();
			MoonTogetherModel.Instance.IsInMoonTogether = true;
		}

		// Token: 0x060401D8 RID: 262616 RVA: 0x00F84E68 File Offset: 0x00F83068
		protected override void OnBeforeShow()
		{
			MultiMotorController instance = MultiMotorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.OnMultiMotorMainViewOpened();
		}

		// Token: 0x060401D9 RID: 262617 RVA: 0x00F84E7C File Offset: 0x00F8307C
		private void ShowBeforeMatchStart()
		{
			Log.Instance.Info(ELogModule.MotorParkour, ELogAuthor.LJQ, "ShowBeforeMatchStart", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.GetItem(9).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x060401DA RID: 262618 RVA: 0x00F84EC4 File Offset: 0x00F830C4
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

		// Token: 0x060401DB RID: 262619 RVA: 0x00F84F3C File Offset: 0x00F8313C
		private void OnMultiMotorPassLine(int playerId)
		{
			Dictionary<int, int> levelRankBattleMap = MultiMotorModel.Instance.GetLevelRankBattleMap();
			int num;
			int key = (levelRankBattleMap != null && levelRankBattleMap.TryGetValue(playerId, out num)) ? num : 0;
			EMultiMotorBroadcastGroup emultiMotorBroadcastGroup;
			int broadcastGroup = (int)(MultiMotorDefine.MultiMotorRankToBroadcastGroup.TryGetValue(key, out emultiMotorBroadcastGroup) ? emultiMotorBroadcastGroup : EMultiMotorBroadcastGroup.MatchPassLine);
			this.ShowBroadcast(broadcastGroup);
		}

		// Token: 0x060401DC RID: 262620 RVA: 0x00F84F84 File Offset: 0x00F83184
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

		// Token: 0x060401DD RID: 262621 RVA: 0x00F84FF0 File Offset: 0x00F831F0
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

		// Token: 0x060401DE RID: 262622 RVA: 0x00F85124 File Offset: 0x00F83324
		private void OnMultiMotorLevelRankBattleUpdate()
		{
			this.RefreshRankInfo();
		}

		// Token: 0x060401DF RID: 262623 RVA: 0x00F8512C File Offset: 0x00F8332C
		protected override void OnTick(float delta)
		{
			this.MapItem.UpdatePlayerPosition();
			this.RefreshTimeText();
			foreach (KeyValuePair<int, MultiMotorRankItem> keyValuePair in this.RankItemMap)
			{
				keyValuePair.Value.TickAccelerateCountdown(delta);
			}
		}

		// Token: 0x060401E0 RID: 262624 RVA: 0x00F85198 File Offset: 0x00F83398
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

		// Token: 0x060401E1 RID: 262625 RVA: 0x00F85273 File Offset: 0x00F83473
		private void OnBroadcastSequenceClose(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetItem(5).SetUIActive(false);
			}
		}

		// Token: 0x060401E2 RID: 262626 RVA: 0x00F8528F File Offset: 0x00F8348F
		private void ClearBroadcastTimer()
		{
			if (this.BroadcastTimerHandle != null)
			{
				this.BroadcastTimerHandle.Remove();
				this.BroadcastTimerHandle = null;
			}
		}

		// Token: 0x060401E3 RID: 262627 RVA: 0x00F852AC File Offset: 0x00F834AC
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

		// Token: 0x0402167C RID: 136828
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x0402167D RID: 136829
		private const int ITEM_HEIGHT_INTERVAL = 20;

		// Token: 0x0402167E RID: 136830
		private const int BROADCAST_TIME = 5000;

		// Token: 0x0402167F RID: 136831
		private MultiMotorLevelData LevelData;

		// Token: 0x04021680 RID: 136832
		private readonly Dictionary<int, MultiMotorRankItem> RankItemMap = new Dictionary<int, MultiMotorRankItem>();

		// Token: 0x04021681 RID: 136833
		private readonly HashSet<int> CreatingRankItemSet = new HashSet<int>();

		// Token: 0x04021682 RID: 136834
		protected UCurveFloat LerpCurve;

		// Token: 0x04021683 RID: 136835
		protected float DefaultOffsetY;

		// Token: 0x04021684 RID: 136836
		protected int GridItemHeight;

		// Token: 0x04021685 RID: 136837
		private MultiMotorParkourMapItem MapItem;

		// Token: 0x04021686 RID: 136838
		private long StartFlowTime;

		// Token: 0x04021687 RID: 136839
		private LevelSequencePlayer BroadcastSequencePlayer;

		// Token: 0x04021688 RID: 136840
		[Nullable(2)]
		private TimerHandle BroadcastTimerHandle;

		// Token: 0x0200C5A8 RID: 50600
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BAC4 RID: 244420
			public const int TopMapItem = 0;

			// Token: 0x0403BAC5 RID: 244421
			public const int LapCountText = 1;

			// Token: 0x0403BAC6 RID: 244422
			public const int TimeText = 2;

			// Token: 0x0403BAC7 RID: 244423
			public const int ContentItem = 3;

			// Token: 0x0403BAC8 RID: 244424
			public const int RankTempItem = 4;

			// Token: 0x0403BAC9 RID: 244425
			public const int BroadcastItem = 5;

			// Token: 0x0403BACA RID: 244426
			public const int BroadcastTitleText = 6;

			// Token: 0x0403BACB RID: 244427
			public const int BroadcastDesText = 7;

			// Token: 0x0403BACC RID: 244428
			public const int MissionItem = 8;

			// Token: 0x0403BACD RID: 244429
			public const int TimeItem = 9;
		}
	}
}
