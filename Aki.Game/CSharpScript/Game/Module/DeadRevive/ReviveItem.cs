using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AA9 RID: 19113
	[NullableContext(1)]
	[Nullable(0)]
	public class ReviveItem : UiPanelBase
	{
		// Token: 0x0602FD32 RID: 195890 RVA: 0x00D58810 File Offset: 0x00D56A10
		public ReviveItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FD33 RID: 195891 RVA: 0x00D58874 File Offset: 0x00D56A74
		public void ShowReviveItem(int itemId, int itemCount)
		{
			this.ItemId = new int?(itemId);
			base.SetItemIcon(base.GetTexture(1), this.ItemId.Value, null, null);
			base.GetText(4).SetText("x" + itemCount.ToString(), true);
			base.SetItemQualityIcon(base.GetSprite(2), this.ItemId.Value, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
			this.CountDownInit();
		}

		// Token: 0x0602FD34 RID: 195892 RVA: 0x00D588F8 File Offset: 0x00D56AF8
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

		// Token: 0x0602FD35 RID: 195893 RVA: 0x00D58A48 File Offset: 0x00D56C48
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(9);
		}

		// Token: 0x0602FD36 RID: 195894 RVA: 0x00D58A58 File Offset: 0x00D56C58
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

		// Token: 0x0602FD37 RID: 195895 RVA: 0x00D58AB1 File Offset: 0x00D56CB1
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

		// Token: 0x0602FD38 RID: 195896 RVA: 0x00D58AD8 File Offset: 0x00D56CD8
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

		// Token: 0x0602FD39 RID: 195897 RVA: 0x00D58BB0 File Offset: 0x00D56DB0
		public void SetToggleState(bool bSelected, bool bFire = true)
		{
			EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			this.Toggle.SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0602FD3A RID: 195898 RVA: 0x00D58BD5 File Offset: 0x00D56DD5
		public void BindClickCallback(TItemClickCallback bindClickCallback)
		{
			this.ClickCallback = bindClickCallback;
		}

		// Token: 0x0602FD3B RID: 195899 RVA: 0x00D58BE0 File Offset: 0x00D56DE0
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

		// Token: 0x0401962F RID: 103983
		private int? ItemId;

		// Token: 0x04019630 RID: 103984
		private TItemClickCallback ClickCallback = delegate(int itemConfigId)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemConfigId, true, null, false);
		};

		// Token: 0x04019631 RID: 103985
		[Nullable(2)]
		private UUIExtendToggle Toggle;

		// Token: 0x04019632 RID: 103986
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x04019633 RID: 103987
		private double RemainCdTime = -1.0;

		// Token: 0x04019634 RID: 103988
		private double TotalCdTime = 1.0;

		// Token: 0x0200A722 RID: 42786
		[NullableContext(0)]
		private class EReviveItemDefine
		{
			// Token: 0x04033A55 RID: 211541
			public const int IconTexture = 1;

			// Token: 0x04033A56 RID: 211542
			public const int IconSprite = 2;

			// Token: 0x04033A57 RID: 211543
			public const int TextCount = 4;

			// Token: 0x04033A58 RID: 211544
			public const int Toggle = 9;

			// Token: 0x04033A59 RID: 211545
			public const int ItemCountDown = 14;

			// Token: 0x04033A5A RID: 211546
			public const int TextCountDown = 15;

			// Token: 0x04033A5B RID: 211547
			public const int SpriteCountDown = 16;
		}
	}
}
