using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010F5 RID: 4341
public class ArtemisSubView : ActivitySubViewBase
{
	// Token: 0x06007137 RID: 28983 RVA: 0x00171D94 File Offset: 0x0016FF94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x06007138 RID: 28984 RVA: 0x00171EB8 File Offset: 0x001700B8
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007139 RID: 28985 RVA: 0x00171EFB File Offset: 0x001700FB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnArtemisStateRefresh, new Action(this.RefreshAircraftStatus));
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x00171F19 File Offset: 0x00170119
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnArtemisStateRefresh, new Action(this.RefreshAircraftStatus));
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x00171F37 File Offset: 0x00170137
	protected override void OnBeforeShow()
	{
		this.RefreshAircraftStatus();
	}

	// Token: 0x0600713C RID: 28988 RVA: 0x00171F3F File Offset: 0x0017013F
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x0600713D RID: 28989 RVA: 0x00171F58 File Offset: 0x00170158
	[NullableContext(1)]
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Loop_Stop")
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopSequenceByKey("Loop", false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopSequenceByKey("Loop_Last", false, false);
			}
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(!this.FullPlaneVisible);
			}
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(this.FullPlaneVisible);
			}
		}
		if (eventName == "Loop_Play")
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.PlaySequencePurely(this.FullPlaneVisible ? "Loop_Last" : "Loop", false, false, null, null, false);
			}
		}
		if (eventName == "Day_Start")
		{
			ArtemisActivityData artemisActivityData = this.ActivityBaseData as ArtemisActivityData;
			if (artemisActivityData != null && artemisActivityData.GetRewardedIndex > 0 && !this.AlreadyPlayedPlaneAnim(artemisActivityData.GetRewardedIndex))
			{
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Day");
					defaultInterpolatedStringHandler.AppendFormatted<int>(artemisActivityData.GetRewardedIndex);
					levelSequencePlayer4.PlaySequencePurely(defaultInterpolatedStringHandler.ToStringAndClear(), false, false, null, null, false);
				}
				this.SetPlayedPlaneAnim(artemisActivityData.GetRewardedIndex);
			}
		}
	}

	// Token: 0x0600713E RID: 28990 RVA: 0x0017209B File Offset: 0x0017029B
	private void ClickCommonInfo()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			ArtemisActivityData artemisActivityData = this.ActivityBaseData as ArtemisActivityData;
			int artemisDefaultOpenIndex = artemisActivityData.GetArtemisDefaultOpenIndex();
			ArtemisActivityRoleChatViewParams param = new ArtemisActivityRoleChatViewParams
			{
				Data = artemisActivityData,
				DefaultIndex = artemisDefaultOpenIndex
			};
			UiManager.Instance.OpenView(EUiViewName.ArtemisActivityRoleChatView, param, null);
		});
	}

	// Token: 0x0600713F RID: 28991 RVA: 0x001720BC File Offset: 0x001702BC
	private void RefreshAircraftStatus()
	{
		ArtemisActivityData artemisActivityData = this.ActivityBaseData as ArtemisActivityData;
		if (artemisActivityData != null)
		{
			IReadOnlyList<Artemis> artemisGroupByActivityId = ArtemisActivityConfig.Instance.GetArtemisGroupByActivityId(artemisActivityData.GetCacheActivityId);
			this.MaxDay = ((artemisGroupByActivityId != null) ? artemisGroupByActivityId.Count : 0);
			this.FullPlaneVisible = (artemisActivityData.GetRewardedIndex >= this.MaxDay);
			this.SetPlaneVisibleVisible(artemisActivityData.GetRewardedIndex);
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(artemisActivityData.GetRewardedIndex);
				artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UUIArtText artText2 = base.GetArtText(1);
			if (artText2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.MaxDay);
				artText2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			bool canReceive = artemisActivityData.GetCanReceive();
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.SetBtnText("FarmGoldEnterText", Array.Empty<object>());
			}
			ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
			if (commonInfoPanel2 == null)
			{
				return;
			}
			commonInfoPanel2.SetFunctionRedDotVisible(canReceive);
		}
	}

	// Token: 0x06007140 RID: 28992 RVA: 0x001721CC File Offset: 0x001703CC
	private void SetPlaneVisibleVisible(int targetIndex)
	{
		int num = this.AlreadyPlayedPlaneAnim(targetIndex) ? targetIndex : (targetIndex - 1);
		for (int i = 0; i < this.MaxDay; i++)
		{
			bool flag = num > i;
			UUIItem item = base.GetItem(4 + i);
			if (item != null)
			{
				item.SetAlpha(flag > false);
			}
		}
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x00172218 File Offset: 0x00170418
	private bool AlreadyPlayedPlaneAnim(int index)
	{
		ArtemisActivityData artemisActivityData = this.ActivityBaseData as ArtemisActivityData;
		if (artemisActivityData == null)
		{
			return false;
		}
		int getCacheActivityId = artemisActivityData.GetCacheActivityId;
		Dictionary<int, int> player = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.FirstPlayArtemisPlaneAnimMap, null);
		int num;
		return player != null && player.TryGetValue(getCacheActivityId, out num) && num >= index;
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x00172260 File Offset: 0x00170460
	private void SetPlayedPlaneAnim(int index)
	{
		ArtemisActivityData artemisActivityData = this.ActivityBaseData as ArtemisActivityData;
		if (artemisActivityData == null)
		{
			return;
		}
		int getCacheActivityId = artemisActivityData.GetCacheActivityId;
		Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.FirstPlayArtemisPlaneAnimMap, null) ?? new Dictionary<int, int>();
		dictionary[getCacheActivityId] = index;
		LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.FirstPlayArtemisPlaneAnimMap, dictionary);
	}

	// Token: 0x0400346E RID: 13422
	[Nullable(2)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0400346F RID: 13423
	private bool FullPlaneVisible;

	// Token: 0x04003470 RID: 13424
	private int MaxDay;

	// Token: 0x020076BC RID: 30396
	private class EComponent
	{
		// Token: 0x040272FC RID: 160508
		public const int CurrentDayText = 0;

		// Token: 0x040272FD RID: 160509
		public const int TargetDayText = 1;

		// Token: 0x040272FE RID: 160510
		public const int ActivityInfoUiItem = 2;

		// Token: 0x040272FF RID: 160511
		public const int AircraftTexture = 3;

		// Token: 0x04027300 RID: 160512
		public const int AirPoint1Item = 4;

		// Token: 0x04027301 RID: 160513
		public const int AirPoint2Item = 5;

		// Token: 0x04027302 RID: 160514
		public const int AirPoint3Item = 6;

		// Token: 0x04027303 RID: 160515
		public const int AirPoint4Item = 7;

		// Token: 0x04027304 RID: 160516
		public const int AirPoint5Item = 8;

		// Token: 0x04027305 RID: 160517
		public const int AirPoint6Item = 9;

		// Token: 0x04027306 RID: 160518
		public const int AirPoint7Item = 10;

		// Token: 0x04027307 RID: 160519
		public const int GitchItem = 11;
	}
}
