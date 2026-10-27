using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBD RID: 23997
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiHoverTipsD : BattleChildView
	{
		// Token: 0x0603CFAB RID: 249771 RVA: 0x00EA93B4 File Offset: 0x00EA75B4
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleUiHoverTipsD.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleUiHoverTipsD.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CFAC RID: 249772 RVA: 0x00EA93F8 File Offset: 0x00EA75F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CFAD RID: 249773 RVA: 0x00EA9484 File Offset: 0x00EA7684
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

		// Token: 0x0603CFAE RID: 249774 RVA: 0x00EA950C File Offset: 0x00EA770C
		[NullableContext(1)]
		public void CreateAndShow(UUIItem parent, IBattleUiHoverTipsD info)
		{
			string resourceId = "UiItem_HoverTipsD";
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

		// Token: 0x0603CFAF RID: 249775 RVA: 0x00EA9578 File Offset: 0x00EA7778
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603CFB0 RID: 249776 RVA: 0x00EA95B0 File Offset: 0x00EA77B0
		[NullableContext(1)]
		public void UpdateInfo(IBattleUiHoverTipsD info)
		{
			this.Info = info;
			if (!this.Created)
			{
				return;
			}
			BattleUiHoverTipsD.BattleUiInfoItem infoItem = this.InfoItem;
			if (infoItem != null)
			{
				infoItem.Refresh(this.Info);
			}
			if (!string.IsNullOrEmpty(this.Info.DescTitleKey))
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew(this.Info.DescTitleKey);
			}
		}

		// Token: 0x0603CFB1 RID: 249777 RVA: 0x00EA9612 File Offset: 0x00EA7812
		private void StartCountdown()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), 8000f, null, null, true, 1f);
		}

		// Token: 0x0603CFB2 RID: 249778 RVA: 0x00EA9640 File Offset: 0x00EA7840
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

		// Token: 0x0603CFB3 RID: 249779 RVA: 0x00EA96A0 File Offset: 0x00EA78A0
		private void OnTimerEnd(float _ = 0f)
		{
			if (this.TimerHandle == null)
			{
				return;
			}
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleShipTowerBuffInfo);
		}

		// Token: 0x0603CFB4 RID: 249780 RVA: 0x00EA96C1 File Offset: 0x00EA78C1
		protected override void OnBeforeDestroy()
		{
			this.OnTimerEnd(0f);
		}

		// Token: 0x0401FC62 RID: 130146
		private bool Created;

		// Token: 0x0401FC63 RID: 130147
		private TimerHandle TimerHandle;

		// Token: 0x0401FC64 RID: 130148
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC65 RID: 130149
		private IBattleUiHoverTipsD Info;

		// Token: 0x0401FC66 RID: 130150
		private BattleUiHoverTipsD.BattleUiInfoItem InfoItem;

		// Token: 0x0200C0B6 RID: 49334
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A26E RID: 238190
			SpriteBg,
			// Token: 0x0403A26F RID: 238191
			ItemInfo,
			// Token: 0x0403A270 RID: 238192
			TxtDescTitle
		}

		// Token: 0x0200C0B7 RID: 49335
		[NullableContext(0)]
		public class BattleUiInfoItem : UiPanelBase
		{
			// Token: 0x06050388 RID: 328584 RVA: 0x0158C774 File Offset: 0x0158A974
			protected unsafe override void OnRegisterComponent()
			{
				int num = 5;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x06050389 RID: 328585 RVA: 0x0158C840 File Offset: 0x0158AA40
			protected override UniTask OnBeforeStartAsync()
			{
				BattleUiHoverTipsD.BattleUiInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
				<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<OnBeforeStartAsync>d__.<>4__this = this;
				<OnBeforeStartAsync>d__.<>1__state = -1;
				<OnBeforeStartAsync>d__.<>t__builder.Start<BattleUiHoverTipsD.BattleUiInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
				return <OnBeforeStartAsync>d__.<>t__builder.Task;
			}

			// Token: 0x0605038A RID: 328586 RVA: 0x0158C883 File Offset: 0x0158AA83
			[NullableContext(1)]
			private static BattleUiHoverTipsD.BattleUiDescInfoItem CreateItem()
			{
				return new BattleUiHoverTipsD.BattleUiDescInfoItem();
			}

			// Token: 0x0605038B RID: 328587 RVA: 0x0158C88C File Offset: 0x0158AA8C
			[NullableContext(1)]
			public void Refresh(IBattleUiHoverTipsD info)
			{
				SmallItemGrid iconItem = this.IconItem;
				if (iconItem != null)
				{
					iconItem.Apply<IMediumItemGridBase>(info.ItemInfo);
				}
				SmallItemGrid iconItem2 = this.IconItem;
				if (iconItem2 != null)
				{
					iconItem2.SetToggleInteractive(false);
				}
				this.ContentLayout.RefreshByData(info.DescInfoList, null, false);
				UUIText text = base.GetText(0);
				if (!string.IsNullOrEmpty(info.SubTitleKey))
				{
					LguiUtil.Instance.SetLocalTextNew(text, info.SubTitleKey, Array.Empty<object>());
				}
				else if (text != null)
				{
					text.SetText(string.Empty, true);
				}
				UUIText text2 = base.GetText(4);
				LguiUtil.Instance.SetLocalTextNew(text2, info.TitleKey, Array.Empty<object>());
				if (info.TitleColor != null && text2 != null)
				{
					text2.SetColor(info.TitleColor.Value);
				}
			}

			// Token: 0x0403A271 RID: 238193
			[Nullable(2)]
			private SmallItemGrid IconItem;

			// Token: 0x0403A272 RID: 238194
			[Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			private GenericLayout<BattleUiHoverTipsD.BattleUiDescInfoItem, IBattleUiHoverTipsDescInfo> ContentLayout;

			// Token: 0x0200D18C RID: 53644
			private enum EItemChildType
			{
				// Token: 0x0403EE17 RID: 257559
				TxtSubTitle,
				// Token: 0x0403EE18 RID: 257560
				ItemGrid,
				// Token: 0x0403EE19 RID: 257561
				VLayoutContent,
				// Token: 0x0403EE1A RID: 257562
				ItemDescInfo,
				// Token: 0x0403EE1B RID: 257563
				TxtTitle
			}

			// Token: 0x0200D18D RID: 53645
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x0403EE1C RID: 257564
				[Nullable(new byte[]
				{
					0,
					1
				})]
				public static Func<BattleUiHoverTipsD.BattleUiDescInfoItem> <0>__CreateItem;
			}
		}

		// Token: 0x0200C0B8 RID: 49336
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class BattleUiDescInfoItem : GridProxyAbstract<IBattleUiHoverTipsDescInfo>
		{
			// Token: 0x0605038D RID: 328589 RVA: 0x0158C960 File Offset: 0x0158AB60
			protected unsafe override void OnRegisterComponent()
			{
				int num = 5;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x0605038E RID: 328590 RVA: 0x0158CA2C File Offset: 0x0158AC2C
			public override void Refresh(IBattleUiHoverTipsDescInfo data, bool isSelected, int gridIndex)
			{
				UUIText text = base.GetText(2);
				UUIText text2 = base.GetText(1);
				LguiUtil.Instance.SetLocalTextNew(text, data.DescKey, Array.Empty<object>());
				if (text != null)
				{
					UUIItem uuiitem = text;
					bool valueOrDefault = data.DescUseChangeColor.GetValueOrDefault();
					FColor? fcolor = new FColor?(text.changeColor);
					uuiitem.SetChangeColor(valueOrDefault, fcolor);
				}
				base.GetItem(4).SetUIActive(data.IsShowState.GetValueOrDefault());
				if (data.IsShowState.GetValueOrDefault())
				{
					bool valueOrDefault2 = data.IsUnlock.GetValueOrDefault();
					FColor color = FColor.FromHex(valueOrDefault2 ? "adfb5aff" : "adadadff");
					if (text2 != null)
					{
						text2.SetColor(color);
					}
					base.GetSprite(0).SetUIActive(valueOrDefault2);
					base.GetSprite(3).SetUIActive(!valueOrDefault2);
					if (!string.IsNullOrEmpty(data.StateTitleKey))
					{
						LguiUtil.Instance.SetLocalTextNew(text2, data.StateTitleKey, Array.Empty<object>());
					}
				}
			}

			// Token: 0x0403A273 RID: 238195
			private const string EGridCompleteHexColor_Done = "adfb5aff";

			// Token: 0x0403A274 RID: 238196
			private const string EGridCompleteHexColor_NotDone = "adadadff";

			// Token: 0x0200D18F RID: 53647
			[NullableContext(0)]
			private enum EDescChildType
			{
				// Token: 0x0403EE23 RID: 257571
				SpriteUnlock,
				// Token: 0x0403EE24 RID: 257572
				TxtState,
				// Token: 0x0403EE25 RID: 257573
				TxtDesc,
				// Token: 0x0403EE26 RID: 257574
				SpriteLock,
				// Token: 0x0403EE27 RID: 257575
				ItemStateRoot
			}
		}
	}
}
