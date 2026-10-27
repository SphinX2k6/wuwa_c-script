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
	// Token: 0x02005D51 RID: 23889
	public class BattleHonamiStoryMapLevelHoverItem : UiPanelBase
	{
		// Token: 0x0603CA66 RID: 248422 RVA: 0x00E8E5FC File Offset: 0x00E8C7FC
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

		// Token: 0x0603CA67 RID: 248423 RVA: 0x00E8E668 File Offset: 0x00E8C868
		protected override UniTask OnBeforeStartAsync()
		{
			BattleHonamiStoryMapLevelHoverItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA68 RID: 248424 RVA: 0x00E8E6AC File Offset: 0x00E8C8AC
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			rootItem.SetAnchorHAlign(UIAnchorHorizontalAlign.Center);
			rootItem.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
			rootItem.SetAnchorOffsetX(0f);
			rootItem.SetAnchorOffsetY(0f);
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x0603CA69 RID: 248425 RVA: 0x00E8E6F0 File Offset: 0x00E8C8F0
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

		// Token: 0x0603CA6A RID: 248426 RVA: 0x00E8E748 File Offset: 0x00E8C948
		protected override UniTask OnBeforeHideAsync()
		{
			BattleHonamiStoryMapLevelHoverItem.<OnBeforeHideAsync>d__13 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.<OnBeforeHideAsync>d__13>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CA6B RID: 248427 RVA: 0x00E8E78B File Offset: 0x00E8C98B
		public void Refresh()
		{
			BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem infoItem = this.InfoItem;
			if (infoItem == null)
			{
				return;
			}
			infoItem.Refresh();
		}

		// Token: 0x0603CA6C RID: 248428 RVA: 0x00E8E79D File Offset: 0x00E8C99D
		[NullableContext(1)]
		public void RegisterOnAutoClose(Action onAutoClose)
		{
			this.OnAutoClose = onAutoClose;
		}

		// Token: 0x0401F97B RID: 129403
		[Nullable(2)]
		private BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem InfoItem;

		// Token: 0x0401F97C RID: 129404
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401F97D RID: 129405
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401F97E RID: 129406
		[Nullable(2)]
		private Action OnAutoClose;

		// Token: 0x0200BFF7 RID: 49143
		private enum EHoverItemType
		{
			// Token: 0x04039EDB RID: 237275
			SpriteBg,
			// Token: 0x04039EDC RID: 237276
			ItemInfo
		}

		// Token: 0x0200BFF8 RID: 49144
		private enum EInfoItemType
		{
			// Token: 0x04039EDE RID: 237278
			TxtTitle,
			// Token: 0x04039EDF RID: 237279
			ItemDescInfo,
			// Token: 0x04039EE0 RID: 237280
			LayoutContent
		}

		// Token: 0x0200BFF9 RID: 49145
		private enum EDescItemType
		{
			// Token: 0x04039EE2 RID: 237282
			TitleText,
			// Token: 0x04039EE3 RID: 237283
			DescText
		}

		// Token: 0x0200BFFA RID: 49146
		public class HonamiStoryHoverDescItem : UiPanelBase
		{
			// Token: 0x06050287 RID: 328327 RVA: 0x0158235C File Offset: 0x0158055C
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

			// Token: 0x06050288 RID: 328328 RVA: 0x015823C5 File Offset: 0x015805C5
			protected override void OnStart()
			{
				base.GetText(0).SetUIActive(false);
			}

			// Token: 0x06050289 RID: 328329 RVA: 0x015823D4 File Offset: 0x015805D4
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

		// Token: 0x0200BFFB RID: 49147
		public class HonamiStoryHoverInfoItem : UiPanelBase
		{
			// Token: 0x0605028B RID: 328331 RVA: 0x015824B8 File Offset: 0x015806B8
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

			// Token: 0x0605028C RID: 328332 RVA: 0x01582544 File Offset: 0x01580744
			protected override UniTask OnBeforeStartAsync()
			{
				BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
				<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<OnBeforeStartAsync>d__.<>4__this = this;
				<OnBeforeStartAsync>d__.<>1__state = -1;
				<OnBeforeStartAsync>d__.<>t__builder.Start<BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverInfoItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
				return <OnBeforeStartAsync>d__.<>t__builder.Task;
			}

			// Token: 0x0605028D RID: 328333 RVA: 0x01582587 File Offset: 0x01580787
			protected override void OnStart()
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "HonamiStory_PollutionLevel", Array.Empty<object>());
			}

			// Token: 0x0605028E RID: 328334 RVA: 0x015825A4 File Offset: 0x015807A4
			protected override void OnBeforeShow()
			{
				this.Refresh();
			}

			// Token: 0x0605028F RID: 328335 RVA: 0x015825AC File Offset: 0x015807AC
			public void Refresh()
			{
				BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverDescItem descItem = this.DescItem;
				if (descItem == null)
				{
					return;
				}
				descItem.Refresh();
			}

			// Token: 0x04039EE4 RID: 237284
			[Nullable(2)]
			private BattleHonamiStoryMapLevelHoverItem.HonamiStoryHoverDescItem DescItem;
		}
	}
}
