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
	// Token: 0x020050C0 RID: 20672
	public class RoverlikeTopCurrencyItem : UiPanelBase
	{
		// Token: 0x06033BBE RID: 211902 RVA: 0x00E7AC8C File Offset: 0x00E78E8C
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

		// Token: 0x06033BBF RID: 211903 RVA: 0x00E7AD74 File Offset: 0x00E78F74
		public void SetBtnEnable(bool bEnable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(bEnable);
		}

		// Token: 0x06033BC0 RID: 211904 RVA: 0x00E7AD88 File Offset: 0x00E78F88
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

		// Token: 0x06033BC1 RID: 211905 RVA: 0x00E7ADCC File Offset: 0x00E78FCC
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

		// Token: 0x06033BC2 RID: 211906 RVA: 0x00E7AE5B File Offset: 0x00E7905B
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

		// Token: 0x06033BC3 RID: 211907 RVA: 0x00E7AE80 File Offset: 0x00E79080
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

		// Token: 0x06033BC4 RID: 211908 RVA: 0x00E7AEBE File Offset: 0x00E790BE
		private void OnBtnCurrencyClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CurrencyItemId, true, null, false);
		}

		// Token: 0x06033BC5 RID: 211909 RVA: 0x00E7AED3 File Offset: 0x00E790D3
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAddNumAnimFinish), false);
			this.InitCurrency();
		}

		// Token: 0x06033BC6 RID: 211910 RVA: 0x00E7AF04 File Offset: 0x00E79104
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

		// Token: 0x06033BC7 RID: 211911 RVA: 0x00E7AF64 File Offset: 0x00E79164
		public void BeginShow()
		{
			this.Refresh(false);
			EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x06033BC8 RID: 211912 RVA: 0x00E7AF89 File Offset: 0x00E79189
		public void BeginHide()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnCurrencyChange));
		}

		// Token: 0x06033BC9 RID: 211913 RVA: 0x00E7AFA7 File Offset: 0x00E791A7
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0401B6C9 RID: 112329
		private int TempCurrencyCount;

		// Token: 0x0401B6CA RID: 112330
		private int CurrencyItemId;

		// Token: 0x0401B6CB RID: 112331
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AD85 RID: 44421
		private class EComponents
		{
			// Token: 0x040359DD RID: 219613
			public const int BtnCurrency = 0;

			// Token: 0x040359DE RID: 219614
			public const int TxtNum = 1;

			// Token: 0x040359DF RID: 219615
			public const int TxtAddNum = 2;

			// Token: 0x040359E0 RID: 219616
			public const int TexIcon = 3;
		}
	}
}
