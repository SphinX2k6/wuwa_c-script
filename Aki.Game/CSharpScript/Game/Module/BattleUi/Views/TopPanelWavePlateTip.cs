using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E24 RID: 20004
	public class TopPanelWavePlateTip : BattleVisibleChildView
	{
		// Token: 0x0603252A RID: 206122 RVA: 0x00E1B8E0 File Offset: 0x00E19AE0
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

		// Token: 0x0603252B RID: 206123 RVA: 0x00E1B949 File Offset: 0x00E19B49
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x0603252C RID: 206124 RVA: 0x00E1B963 File Offset: 0x00E19B63
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.MiniMap);
			base.SetVisible(0, true);
		}

		// Token: 0x0603252D RID: 206125 RVA: 0x00E1B97C File Offset: 0x00E19B7C
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

		// Token: 0x0603252E RID: 206126 RVA: 0x00E1BADC File Offset: 0x00E19CDC
		protected override void OnHideBattleChildView()
		{
			Log.Instance.Info(ELogModule.PowerModule, ELogAuthor.BB, "TopPanelWavePlateTip-OnHide", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsRefresh = false;
		}

		// Token: 0x0401AACB RID: 109259
		[Nullable(2)]
		private UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401AACC RID: 109260
		private bool IsRefresh;

		// Token: 0x0200ABCE RID: 43982
		private enum EComponent
		{
			// Token: 0x040352BA RID: 217786
			WavePlateCrystalCount,
			// Token: 0x040352BB RID: 217787
			WavePlateCount
		}
	}
}
