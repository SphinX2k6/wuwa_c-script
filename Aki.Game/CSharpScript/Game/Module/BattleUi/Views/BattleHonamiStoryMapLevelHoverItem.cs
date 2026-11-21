using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D33 RID: 19763
	public class BattleHonamiStoryMapLevelHoverItem : UiPanelBase
	{
		// Token: 0x060319BF RID: 203199 RVA: 0x00DDEDB0 File Offset: 0x00DDCFB0
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

		// Token: 0x060319C0 RID: 203200 RVA: 0x00DDEE1C File Offset: 0x00DDD01C
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryMapLevelHoverItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319C1 RID: 203201 RVA: 0x00DDEE60 File Offset: 0x00DDD060
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			rootItem.SetAnchorHAlign(UIAnchorHorizontalAlign.Center);
			rootItem.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
			rootItem.SetAnchorOffsetX(0f);
			rootItem.SetAnchorOffsetY(0f);
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x060319C2 RID: 203202 RVA: 0x00DDEEA4 File Offset: 0x00DDD0A4
		protected override void OnBeforeShow()
		{
			this.SequencePlayer.StopPrevSequence(false, true);
			this.SequencePlayer.PlaySequencePurely("Start", false, false);
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				UiSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopPrevSequence(false, true);
				}
				this.SetActive(false);
				Action onAutoClose = this.OnAutoClose;
				if (onAutoClose == null)
				{
					return;
				}
				onAutoClose();
			}, 8000f, null, null, true, 1f);
		}

		// Token: 0x060319C3 RID: 203203 RVA: 0x00DDEEFC File Offset: 0x00DDD0FC
		protected override UniTask OnBeforeHideAsync()
		{
			BattleHonamiStoryMapLevelHoverItem.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319C4 RID: 203204 RVA: 0x00DDEF3F File Offset: 0x00DDD13F
		public void Refresh()
		{
			BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem infoItem = this.InfoItem;
			if (infoItem == null)
			{
				return;
			}
			infoItem.Refresh();
		}

		// Token: 0x060319C5 RID: 203205 RVA: 0x00DDEF51 File Offset: 0x00DDD151
		[NullableContext(1)]
		public void RegisterOnAutoClose(Action onAutoClose)
		{
			this.OnAutoClose = onAutoClose;
		}

		// Token: 0x0401A434 RID: 107572
		[Nullable(2)]
		private BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem InfoItem;

		// Token: 0x0401A435 RID: 107573
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401A436 RID: 107574
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401A437 RID: 107575
		[Nullable(2)]
		private Action OnAutoClose;

		// Token: 0x0200A9FD RID: 43517
		private enum EHoverItemType
		{
			// Token: 0x0403489D RID: 215197
			SpriteBg,
			// Token: 0x0403489E RID: 215198
			ItemInfo
		}

		// Token: 0x0200A9FE RID: 43518
		private enum EInfoItemType
		{
			// Token: 0x040348A0 RID: 215200
			TxtTitle,
			// Token: 0x040348A1 RID: 215201
			ItemDescInfo,
			// Token: 0x040348A2 RID: 215202
			LayoutContent
		}

		// Token: 0x0200A9FF RID: 43519
		private enum EDescItemType
		{
			// Token: 0x040348A4 RID: 215204
			TitleText,
			// Token: 0x040348A5 RID: 215205
			DescText
		}

		// Token: 0x0200AA00 RID: 43520
		public class HonamiStoryHoverDescItem : UiPanelBase
		{
			// Token: 0x060467CA RID: 288714 RVA: 0x0153B6F4 File Offset: 0x015398F4
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

			// Token: 0x060467CB RID: 288715 RVA: 0x0153B75D File Offset: 0x0153995D
			protected override void OnStart()
			{
				base.GetText(0).SetUIActive(false);
			}

			// Token: 0x060467CC RID: 288716 RVA: 0x0153B76C File Offset: 0x0153996C
			public void Refresh()
			{
				int pollutionLevel = HonamiStoryModel.Instance.PollutionLevel;
				Dictionary<int, IHonamiStoryPollution> pollutionLevelMap = HonamiStoryModel.Instance.PollutionLevelMap;
				IHonamiStoryPollution honamiStoryPollution = (pollutionLevelMap != null) ? pollutionLevelMap.GetValueOrDefault(pollutionLevel) : null;
				int num = (int)Math.Floor(0.5 + (double)((float)((honamiStoryPollution != null) ? honamiStoryPollution.PersistMilliseconds : 0) * 0.001f));
				int num2 = (honamiStoryPollution != null) ? honamiStoryPollution.MonsterEnhanceLevel : 0;
				if (HonamiStoryUtil.CheckInHonamiStoryTopTower())
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "HonamiStory_PollutionTowerLevelTips", new <>z__ReadOnlyArray<object>(new object[]
					{
						pollutionLevel,
						num2
					}));
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "HonamiStory_PollutionLevelTips", new <>z__ReadOnlyArray<object>(new object[]
				{
					pollutionLevel,
					num,
					num2
				}));
			}
		}

		// Token: 0x0200AA01 RID: 43521
		public class HonamiStoryHoverInfoItem : UiPanelBase
		{
			// Token: 0x060467CE RID: 288718 RVA: 0x0153B850 File Offset: 0x01539A50
			protected unsafe override void OnRegisterComponent()
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x060467CF RID: 288719 RVA: 0x0153B8DC File Offset: 0x01539ADC
			protected override UniTask OnBeforeStartAsync()
			{
				BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
				<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<OnBeforeStartAsync>d__.<>4__this = this;
				<OnBeforeStartAsync>d__.<>1__state = -1;
				<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
				return <OnBeforeStartAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060467D0 RID: 288720 RVA: 0x0153B91F File Offset: 0x01539B1F
			protected override void OnStart()
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "HonamiStory_PollutionLevel", Array.Empty<object>());
			}

			// Token: 0x060467D1 RID: 288721 RVA: 0x0153B93C File Offset: 0x01539B3C
			protected override void OnBeforeShow()
			{
				this.Refresh();
			}

			// Token: 0x060467D2 RID: 288722 RVA: 0x0153B944 File Offset: 0x01539B44
			public void Refresh()
			{
				BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverDescItem descItem = this.DescItem;
				if (descItem == null)
				{
					return;
				}
				descItem.Refresh();
			}

			// Token: 0x040348A6 RID: 215206
			[Nullable(2)]
			private BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverDescItem DescItem;
		}
	}
}
