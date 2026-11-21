using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004670 RID: 18032
	[NullableContext(1)]
	[Nullable(0)]
	public class AmountItem : UiPanelBase
	{
		// Token: 0x0602D5A3 RID: 185763 RVA: 0x00CB2C40 File Offset: 0x00CB0E40
		public AmountItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D5A4 RID: 185764 RVA: 0x00CB2C5C File Offset: 0x00CB0E5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnAdd));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnDel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnShowButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D5A5 RID: 185765 RVA: 0x00CB2D8C File Offset: 0x00CB0F8C
		private UniTask InitCommonItemCountPanel()
		{
			AmountItem.<InitCommonItemCountPanel>d__7 <InitCommonItemCountPanel>d__;
			<InitCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonItemCountPanel>d__.<>4__this = this;
			<InitCommonItemCountPanel>d__.<>1__state = -1;
			<InitCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<InitCommonItemCountPanel>d__7>(ref <InitCommonItemCountPanel>d__);
			return <InitCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602D5A6 RID: 185766 RVA: 0x00CB2DD0 File Offset: 0x00CB0FD0
		private void SetSumText(int sum)
		{
			int maxCallback = this.GetMaxCallback();
			this.Sum = ((maxCallback < sum) ? maxCallback : sum);
			if (this.Sum < 1)
			{
				this.Sum = 1;
			}
			if (this.OnSetSumCallback != null)
			{
				this.OnSetSumCallback(this.Sum);
			}
			base.GetText(3).SetText(this.Sum.ToString(), true);
			this.RefreshAddAndDelButton();
		}

		// Token: 0x0602D5A7 RID: 185767 RVA: 0x00CB2E39 File Offset: 0x00CB1039
		protected override void OnStart()
		{
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0602D5A8 RID: 185768 RVA: 0x00CB2E53 File Offset: 0x00CB1053
		public void ResetSum()
		{
			this.Sum = 1;
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0602D5A9 RID: 185769 RVA: 0x00CB2E74 File Offset: 0x00CB1074
		public void RefreshAddAndDelButton()
		{
			((base.GetButton(1).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum != 1);
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum < this.GetMaxCallback());
		}

		// Token: 0x0602D5AA RID: 185770 RVA: 0x00CB2EEF File Offset: 0x00CB10EF
		public void BindGetMaxCallback(Func<int> onGetMaxCallback)
		{
			this.OnGetMaxCallback = onGetMaxCallback;
		}

		// Token: 0x0602D5AB RID: 185771 RVA: 0x00CB2EF8 File Offset: 0x00CB10F8
		public void BindSetSumCallback(Action<int> onSetSumCallback)
		{
			this.OnSetSumCallback = onSetSumCallback;
		}

		// Token: 0x0602D5AC RID: 185772 RVA: 0x00CB2F04 File Offset: 0x00CB1104
		private int GetMaxCallback()
		{
			if (this.OnGetMaxCallback != null)
			{
				int num = this.OnGetMaxCallback();
				if (num != 0)
				{
					return num;
				}
			}
			return 1;
		}

		// Token: 0x0602D5AD RID: 185773 RVA: 0x00CB2F2C File Offset: 0x00CB112C
		private void OnAdd()
		{
			this.Sum++;
			if (this.OnSetSumCallback != null)
			{
				this.OnSetSumCallback(this.Sum);
			}
			this.RefreshAddAndDelButton();
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0602D5AE RID: 185774 RVA: 0x00CB2F80 File Offset: 0x00CB1180
		private void OnDel()
		{
			this.Sum--;
			if (this.OnSetSumCallback != null)
			{
				this.OnSetSumCallback(this.Sum);
			}
			this.RefreshAddAndDelButton();
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0602D5AF RID: 185775 RVA: 0x00CB2FD2 File Offset: 0x00CB11D2
		private void OnShowButtonClick()
		{
			this.OnShowCommonItemCountPanel();
		}

		// Token: 0x0602D5B0 RID: 185776 RVA: 0x00CB2FDC File Offset: 0x00CB11DC
		private UniTask OnShowCommonItemCountPanel()
		{
			AmountItem.<OnShowCommonItemCountPanel>d__18 <OnShowCommonItemCountPanel>d__;
			<OnShowCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowCommonItemCountPanel>d__.<>4__this = this;
			<OnShowCommonItemCountPanel>d__.<>1__state = -1;
			<OnShowCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<OnShowCommonItemCountPanel>d__18>(ref <OnShowCommonItemCountPanel>d__);
			return <OnShowCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x040184B1 RID: 99505
		private int Sum = 1;

		// Token: 0x040184B2 RID: 99506
		[Nullable(2)]
		private Func<int> OnGetMaxCallback;

		// Token: 0x040184B3 RID: 99507
		[Nullable(2)]
		private Action<int> OnSetSumCallback;

		// Token: 0x040184B4 RID: 99508
		[Nullable(2)]
		private CommonItemCountPanel CommonItemCountPanel;

		// Token: 0x0200A284 RID: 41604
		[NullableContext(0)]
		private class EAmountItemDefine
		{
			// Token: 0x040326F1 RID: 206577
			public const int AddButton = 0;

			// Token: 0x040326F2 RID: 206578
			public const int DelButton = 1;

			// Token: 0x040326F3 RID: 206579
			public const int ShowButton = 2;

			// Token: 0x040326F4 RID: 206580
			public const int SumText = 3;
		}
	}
}
