using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E3F RID: 24127
	public class TopPanelWavePlateTip : BattleVisibleChildView
	{
		// Token: 0x0603D59A RID: 251290 RVA: 0x00ECA374 File Offset: 0x00EC8574
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

		// Token: 0x0603D59B RID: 251291 RVA: 0x00ECA3DD File Offset: 0x00EC85DD
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x0603D59C RID: 251292 RVA: 0x00ECA3F7 File Offset: 0x00EC85F7
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(0, true);
		}

		// Token: 0x0603D59D RID: 251293 RVA: 0x00ECA410 File Offset: 0x00EC8610
		protected override void OnShowBattleChildView()
		{
			if (this.IsRefresh)
			{
				Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-OnShow Return", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!PowerModel.Instance.GetCanShowPowerTip())
			{
				Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-Hide", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetVisible(0, false);
				return;
			}
			this.IsRefresh = true;
			base.SetVisible(0, true);
			PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
			PowerData powerDataById2 = PowerModel.Instance.GetPowerDataById(6);
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(powerDataById.GetCurrentPower());
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(powerDataById.GetPowerLimit());
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetText(0).SetText(powerDataById2.GetCurrentPower().ToString(), true);
			int value = ConfigCommonParamById.GetIntConfig("PowerTipShowTime").Value;
			PowerModel.Instance.SetCanShowPowerTip(false);
			Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-PlaySequence Show", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.UiLevelSequence.PlaySequence("Show", false, null);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
				if (uiLevelSequence != null)
				{
					uiLevelSequence.PlaySequence("Hide", false, null);
				}
				Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-PlaySequence Hide", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, (float)value, null, null, true, 1f);
		}

		// Token: 0x0603D59E RID: 251294 RVA: 0x00ECA570 File Offset: 0x00EC8770
		protected override void OnHideBattleChildView()
		{
			Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-OnHide", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsRefresh = false;
		}

		// Token: 0x04020004 RID: 131076
		[Nullable(2)]
		private UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x04020005 RID: 131077
		private bool IsRefresh;

		// Token: 0x0200C1BF RID: 49599
		private enum EComponent
		{
			// Token: 0x0403A8C8 RID: 239816
			WavePlateCrystalCount,
			// Token: 0x0403A8C9 RID: 239817
			WavePlateCount
		}
	}
}
