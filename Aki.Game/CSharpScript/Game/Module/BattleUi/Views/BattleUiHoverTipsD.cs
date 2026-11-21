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
	// Token: 0x02004DA1 RID: 19873
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiHoverTipsD : BattleChildView
	{
		// Token: 0x06031F22 RID: 204578 RVA: 0x00DFA290 File Offset: 0x00DF8490
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleUiHoverTipsD.<InitializeAsync>d__6 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleUiHoverTipsD.<InitializeAsync>d__6>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F23 RID: 204579 RVA: 0x00DFA2D4 File Offset: 0x00DF84D4
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

		// Token: 0x06031F24 RID: 204580 RVA: 0x00DFA360 File Offset: 0x00DF8560
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

		// Token: 0x06031F25 RID: 204581 RVA: 0x00DFA3E8 File Offset: 0x00DF85E8
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

		// Token: 0x06031F26 RID: 204582 RVA: 0x00DFA454 File Offset: 0x00DF8654
		protected override void OnShowBattleChildView()
		{
			this.LevelSequencePlayer.StopCurrentSequence(false, false);
			this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06031F27 RID: 204583 RVA: 0x00DFA48C File Offset: 0x00DF868C
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

		// Token: 0x06031F28 RID: 204584 RVA: 0x00DFA4EE File Offset: 0x00DF86EE
		private void StartCountdown()
		{
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerEnd), 8000f, null, null, true, 1f);
		}

		// Token: 0x06031F29 RID: 204585 RVA: 0x00DFA51C File Offset: 0x00DF871C
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

		// Token: 0x06031F2A RID: 204586 RVA: 0x00DFA57C File Offset: 0x00DF877C
		private void OnTimerEnd(float _ = 0f)
		{
			if (this.TimerHandle == null)
			{
				return;
			}
			this.EndShow();
			EventSystem.Instance.Emit(EEventName.BattleUiToggleShipTowerBuffInfo);
		}

		// Token: 0x06031F2B RID: 204587 RVA: 0x00DFA59D File Offset: 0x00DF879D
		protected override void OnBeforeDestroy()
		{
			this.OnTimerEnd(0f);
		}

		// Token: 0x0401A71F RID: 108319
		private bool Created;

		// Token: 0x0401A720 RID: 108320
		private TimerHandle TimerHandle;

		// Token: 0x0401A721 RID: 108321
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A722 RID: 108322
		private IBattleUiHoverTipsD Info;

		// Token: 0x0401A723 RID: 108323
		private BattleUiHoverTipsD.BattleUiInfoItem InfoItem;

		// Token: 0x0200AABF RID: 43711
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034C40 RID: 216128
			SpriteBg,
			// Token: 0x04034C41 RID: 216129
			ItemInfo,
			// Token: 0x04034C42 RID: 216130
			TxtDescTitle
		}

		// Token: 0x0200AAC0 RID: 43712
		[NullableContext(0)]
		public class BattleUiInfoItem : UiPanelBase
		{
			// Token: 0x060468CF RID: 288975 RVA: 0x01545D88 File Offset: 0x01543F88
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

			// Token: 0x060468D0 RID: 288976 RVA: 0x01545E54 File Offset: 0x01544054
			protected override UniTask OnBeforeStartAsync()
			{
				BattleUiHoverTipsD.BattleUiInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
				<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<OnBeforeStartAsync>d__.<>4__this = this;
				<OnBeforeStartAsync>d__.<>1__state = -1;
				<OnBeforeStartAsync>d__.<>t__builder.Start<BattleUiHoverTipsD.BattleUiInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
				return <OnBeforeStartAsync>d__.<>t__builder.Task;
			}

			// Token: 0x060468D1 RID: 288977 RVA: 0x01545E97 File Offset: 0x01544097
			[NullableContext(1)]
			private static BattleUiHoverTipsD.BattleUiDescInfoItem CreateItem()
			{
				return new BattleUiHoverTipsD.BattleUiDescInfoItem();
			}

			// Token: 0x060468D2 RID: 288978 RVA: 0x01545EA0 File Offset: 0x015440A0
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

			// Token: 0x04034C43 RID: 216131
			[Nullable(2)]
			private SmallItemGrid IconItem;

			// Token: 0x04034C44 RID: 216132
			[Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			private GenericLayout<BattleUiHoverTipsD.BattleUiDescInfoItem, IBattleUiHoverTipsDescInfo> ContentLayout;

			// Token: 0x0200BD6A RID: 48490
			private enum EItemChildType
			{
				// Token: 0x0403A25F RID: 238175
				TxtSubTitle,
				// Token: 0x0403A260 RID: 238176
				ItemGrid,
				// Token: 0x0403A261 RID: 238177
				VLayoutContent,
				// Token: 0x0403A262 RID: 238178
				ItemDescInfo,
				// Token: 0x0403A263 RID: 238179
				TxtTitle
			}

			// Token: 0x0200BD6B RID: 48491
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x0403A264 RID: 238180
				[Nullable(new byte[]
				{
					0,
					1
				})]
				public static Func<BattleUiHoverTipsD.BattleUiDescInfoItem> <0>__CreateItem;
			}
		}

		// Token: 0x0200AAC1 RID: 43713
		[NullableContext(1)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class BattleUiDescInfoItem : GridProxyAbstract<IBattleUiHoverTipsDescInfo>
		{
			// Token: 0x060468D4 RID: 288980 RVA: 0x01545F74 File Offset: 0x01544174
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

			// Token: 0x060468D5 RID: 288981 RVA: 0x01546040 File Offset: 0x01544240
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

			// Token: 0x04034C45 RID: 216133
			private const string EGridCompleteHexColor_Done = "adfb5aff";

			// Token: 0x04034C46 RID: 216134
			private const string EGridCompleteHexColor_NotDone = "adadadff";

			// Token: 0x0200BD6D RID: 48493
			[NullableContext(0)]
			private enum EDescChildType
			{
				// Token: 0x0403A26B RID: 238187
				SpriteUnlock,
				// Token: 0x0403A26C RID: 238188
				TxtState,
				// Token: 0x0403A26D RID: 238189
				TxtDesc,
				// Token: 0x0403A26E RID: 238190
				SpriteLock,
				// Token: 0x0403A26F RID: 238191
				ItemStateRoot
			}
		}
	}
}
