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

// Token: 0x020005A9 RID: 1449
public class ArtemisSubView : ActivitySubViewBase
{
	// Token: 0x060044CD RID: 17613 RVA: 0x0017A750 File Offset: 0x00178950
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

	// Token: 0x060044CE RID: 17614 RVA: 0x0017A874 File Offset: 0x00178A74
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x0017A8B7 File Offset: 0x00178AB7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnArtemisStateRefresh, new Action(this.RefreshAircraftStatus));
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x0017A8D5 File Offset: 0x00178AD5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnArtemisStateRefresh, new Action(this.RefreshAircraftStatus));
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x0017A8F3 File Offset: 0x00178AF3
	protected override void OnBeforeShow()
	{
		this.RefreshAircraftStatus();
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x0017A8FB File Offset: 0x00178AFB
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x0017A914 File Offset: 0x00178B14
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

	// Token: 0x060044D4 RID: 17620 RVA: 0x0017AA57 File Offset: 0x00178C57
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

	// Token: 0x060044D5 RID: 17621 RVA: 0x0017AA78 File Offset: 0x00178C78
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

	// Token: 0x060044D6 RID: 17622 RVA: 0x0017AB88 File Offset: 0x00178D88
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

	// Token: 0x060044D7 RID: 17623 RVA: 0x0017ABD4 File Offset: 0x00178DD4
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

	// Token: 0x060044D8 RID: 17624 RVA: 0x0017AC1C File Offset: 0x00178E1C
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

	// Token: 0x04003507 RID: 13575
	[Nullable(2)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003508 RID: 13576
	private bool FullPlaneVisible;

	// Token: 0x04003509 RID: 13577
	private int MaxDay;

	// Token: 0x02006850 RID: 26704
	private class EComponent
	{
		// Token: 0x04022645 RID: 140869
		public const int CurrentDayText = 0;

		// Token: 0x04022646 RID: 140870
		public const int TargetDayText = 1;

		// Token: 0x04022647 RID: 140871
		public const int ActivityInfoUiItem = 2;

		// Token: 0x04022648 RID: 140872
		public const int AircraftTexture = 3;

		// Token: 0x04022649 RID: 140873
		public const int AirPoint1Item = 4;

		// Token: 0x0402264A RID: 140874
		public const int AirPoint2Item = 5;

		// Token: 0x0402264B RID: 140875
		public const int AirPoint3Item = 6;

		// Token: 0x0402264C RID: 140876
		public const int AirPoint4Item = 7;

		// Token: 0x0402264D RID: 140877
		public const int AirPoint5Item = 8;

		// Token: 0x0402264E RID: 140878
		public const int AirPoint6Item = 9;

		// Token: 0x0402264F RID: 140879
		public const int AirPoint7Item = 10;

		// Token: 0x04022650 RID: 140880
		public const int GitchItem = 11;
	}
}
