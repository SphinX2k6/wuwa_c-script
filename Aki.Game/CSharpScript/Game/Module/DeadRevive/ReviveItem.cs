using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC8 RID: 23240
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItem : UiPanelBase
	{
		// Token: 0x0603ADC0 RID: 241088 RVA: 0x00E07B30 File Offset: 0x00E05D30
		public ReviveItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603ADC1 RID: 241089 RVA: 0x00E07B94 File Offset: 0x00E05D94
		public void ShowReviveItem(int itemId, int itemCount)
		{
			this.ItemId = new int?(itemId);
			base.SetItemIcon(base.GetTexture(1), this.ItemId.Value, null, null);
			base.GetText(4).SetText("x" + itemCount.ToString(), true);
			base.SetItemQualityIcon(base.GetSprite(2), this.ItemId.Value, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
			this.CountDownInit();
		}

		// Token: 0x0603ADC2 RID: 241090 RVA: 0x00E07C18 File Offset: 0x00E05E18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADC3 RID: 241091 RVA: 0x00E07D68 File Offset: 0x00E05F68
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(9);
		}

		// Token: 0x0603ADC4 RID: 241092 RVA: 0x00E07D78 File Offset: 0x00E05F78
		protected override void OnBeforeDestroy()
		{
			this.ItemId = null;
			this.Toggle = null;
			if (this.Timer != null)
			{
				this.Timer.Remove();
			}
			this.Timer = null;
			this.RemainCdTime = -1.0;
			this.TotalCdTime = 1.0;
		}

		// Token: 0x0603ADC5 RID: 241093 RVA: 0x00E07DD1 File Offset: 0x00E05FD1
		protected void ToggleClick(EToggleState state)
		{
			if (this.ClickCallback == null)
			{
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				this.ClickCallback(this.ItemId.Value);
			}
		}

		// Token: 0x0603ADC6 RID: 241094 RVA: 0x00E07DF8 File Offset: 0x00E05FF8
		private void CountDownInit()
		{
			double buffItemRemainCdTime = BuffItemModel.Instance.GetBuffItemRemainCdTime(this.ItemId.Value);
			if (buffItemRemainCdTime <= 0.0)
			{
				return;
			}
			this.RemainCdTime = buffItemRemainCdTime;
			this.TotalCdTime = BuffItemModel.Instance.GetBuffItemTotalCdTime(this.ItemId.Value);
			base.GetItem(14).SetUIActive(true);
			base.GetText(15).SetText(TimeUtil.Instance.GetCoolDown(this.RemainCdTime), true);
			base.GetSprite(16).SetFillAmount((float)(this.RemainCdTime / this.TotalCdTime));
			if (this.Timer != null)
			{
				this.Timer.Remove();
			}
			this.Timer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TimerHandle), 20f, 1f, null, null, true);
		}

		// Token: 0x0603ADC7 RID: 241095 RVA: 0x00E07ED0 File Offset: 0x00E060D0
		public void SetToggleState(bool bSelected, bool bFire = true)
		{
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.Toggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0603ADC8 RID: 241096 RVA: 0x00E07EF5 File Offset: 0x00E060F5
		public void BindClickCallback(TItemClickCallback bindClickCallback)
		{
			this.ClickCallback = bindClickCallback;
		}

		// Token: 0x0603ADC9 RID: 241097 RVA: 0x00E07F00 File Offset: 0x00E06100
		private void TimerHandle(float delta)
		{
			if (this.RemainCdTime <= 0.0)
			{
				if (this.Timer != null)
				{
					this.Timer.Remove();
				}
				this.Timer = null;
				if (UiManager.Instance.IsViewShow(EUiViewName.UseReviveItemView))
				{
					base.GetItem(14).SetUIActive(false);
				}
				return;
			}
			base.GetText(15).SetText(TimeUtil.Instance.GetCoolDown(this.RemainCdTime), true);
			base.GetSprite(16).SetFillAmount((float)(this.RemainCdTime / this.TotalCdTime));
			this.RemainCdTime -= 0.02;
		}

		// Token: 0x0401EB73 RID: 125811
		private int? ItemId;

		// Token: 0x0401EB74 RID: 125812
		private TItemClickCallback ClickCallback = delegate(int itemConfigId)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null);
		};

		// Token: 0x0401EB75 RID: 125813
		[Nullable(2)]
		private UUIExtendToggle Toggle;

		// Token: 0x0401EB76 RID: 125814
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401EB77 RID: 125815
		private double RemainCdTime = -1.0;

		// Token: 0x0401EB78 RID: 125816
		private double TotalCdTime = 1.0;

		// Token: 0x0200BD1A RID: 48410
		[NullableContext(0)]
		private class EReviveItemDefine
		{
			// Token: 0x0403908B RID: 233611
			public const int IconTexture = 1;

			// Token: 0x0403908C RID: 233612
			public const int IconSprite = 2;

			// Token: 0x0403908D RID: 233613
			public const int TextCount = 4;

			// Token: 0x0403908E RID: 233614
			public const int Toggle = 9;

			// Token: 0x0403908F RID: 233615
			public const int ItemCountDown = 14;

			// Token: 0x04039090 RID: 233616
			public const int TextCountDown = 15;

			// Token: 0x04039091 RID: 233617
			public const int SpriteCountDown = 16;
		}
	}
}
