using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006142 RID: 24898
	public class RoverlikeTopCurrencyItem : UiPanelBase
	{
		// Token: 0x0603EEFE RID: 257790 RVA: 0x00F33DAC File Offset: 0x00F31FAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCurrencyClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EEFF RID: 257791 RVA: 0x00F33E94 File Offset: 0x00F32094
		public void SetBtnEnable(bool bEnable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(bEnable);
		}

		// Token: 0x0603EF00 RID: 257792 RVA: 0x00F33EA8 File Offset: 0x00F320A8
		private void Refresh(bool emitAnim = false)
		{
			int gold = RoverlikeModel.Instance.Gold;
			base.GetText(1).SetText(gold.ToString(), true);
			if (emitAnim)
			{
				this.ShowAddNumAnim(gold - this.TempCurrencyCount);
			}
			this.TempCurrencyCount = gold;
		}

		// Token: 0x0603EF01 RID: 257793 RVA: 0x00F33EEC File Offset: 0x00F320EC
		private void ShowAddNumAnim(int delta)
		{
			if (delta == 0)
			{
				return;
			}
			UUIText text = base.GetText(2);
			UUIText uuitext = text;
			string newText;
			if (delta <= 0)
			{
				newText = delta.ToString();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(delta);
				newText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			uuitext.SetText(newText, true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = delta < 0;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text.SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Up", false, null);
		}

		// Token: 0x0603EF02 RID: 257794 RVA: 0x00F33F7B File Offset: 0x00F3217B
		[NullableContext(1)]
		private void OnAddNumAnimFinish(string sequenceName)
		{
			if (sequenceName != "Up")
			{
				return;
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603EF03 RID: 257795 RVA: 0x00F33FA0 File Offset: 0x00F321A0
		private void OnCurrencyChange(int itemId)
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			if (instance.InstanceData != null)
			{
				int? goldItemId = instance.GoldItemId;
				if (itemId == goldItemId.GetValueOrDefault() & goldItemId != null)
				{
					this.Refresh(true);
					return;
				}
			}
		}

		// Token: 0x0603EF04 RID: 257796 RVA: 0x00F33FDE File Offset: 0x00F321DE
		private void OnBtnCurrencyClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CurrencyItemId, true, null);
		}

		// Token: 0x0603EF05 RID: 257797 RVA: 0x00F33FF2 File Offset: 0x00F321F2
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAddNumAnimFinish), false);
			this.InitCurrency();
		}

		// Token: 0x0603EF06 RID: 257798 RVA: 0x00F34024 File Offset: 0x00F32224
		public void InitCurrency()
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			this.CurrencyItemId = instance.GoldItemId.GetValueOrDefault();
			if (this.CurrencyItemId != 0)
			{
				base.SetItemIcon(base.GetTexture(3), this.CurrencyItemId, null, null);
			}
			base.GetText(2).SetUIActive(false);
			this.Refresh(false);
		}

		// Token: 0x0603EF07 RID: 257799 RVA: 0x00F34084 File Offset: 0x00F32284
		public void BeginShow()
		{
			this.Refresh(false);
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603EF08 RID: 257800 RVA: 0x00F340A9 File Offset: 0x00F322A9
		public void BeginHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x0603EF09 RID: 257801 RVA: 0x00F340C7 File Offset: 0x00F322C7
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x04020D9C RID: 134556
		private int TempCurrencyCount;

		// Token: 0x04020D9D RID: 134557
		private int CurrencyItemId;

		// Token: 0x04020D9E RID: 134558
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C39E RID: 50078
		private class EComponents
		{
			// Token: 0x0403B07C RID: 241788
			public const int BtnCurrency = 0;

			// Token: 0x0403B07D RID: 241789
			public const int TxtNum = 1;

			// Token: 0x0403B07E RID: 241790
			public const int TxtAddNum = 2;

			// Token: 0x0403B07F RID: 241791
			public const int TexIcon = 3;
		}
	}
}
