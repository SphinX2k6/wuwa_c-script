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
	// Token: 0x0200569A RID: 22170
	[NullableContext(1)]
	[Nullable(0)]
	public class AmountItem : UiPanelBase
	{
		// Token: 0x060386A6 RID: 231078 RVA: 0x00D64AF0 File Offset: 0x00D62CF0
		public AmountItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060386A7 RID: 231079 RVA: 0x00D64B0C File Offset: 0x00D62D0C
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

		// Token: 0x060386A8 RID: 231080 RVA: 0x00D64C3C File Offset: 0x00D62E3C
		private UniTask InitCommonItemCountPanel()
		{
			AmountItem.<InitCommonItemCountPanel>d__7 <InitCommonItemCountPanel>d__;
			<InitCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonItemCountPanel>d__.<>4__this = this;
			<InitCommonItemCountPanel>d__.<>1__state = -1;
			<InitCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<InitCommonItemCountPanel>d__7>(ref <InitCommonItemCountPanel>d__);
			return <InitCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060386A9 RID: 231081 RVA: 0x00D64C80 File Offset: 0x00D62E80
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

		// Token: 0x060386AA RID: 231082 RVA: 0x00D64CE9 File Offset: 0x00D62EE9
		protected override void OnStart()
		{
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x060386AB RID: 231083 RVA: 0x00D64D03 File Offset: 0x00D62F03
		public void ResetSum()
		{
			this.Sum = 1;
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x060386AC RID: 231084 RVA: 0x00D64D24 File Offset: 0x00D62F24
		public void RefreshAddAndDelButton()
		{
			((base.GetButton(1).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum != 1);
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum < this.GetMaxCallback());
		}

		// Token: 0x060386AD RID: 231085 RVA: 0x00D64D9F File Offset: 0x00D62F9F
		public void BindGetMaxCallback(Func<int> onGetMaxCallback)
		{
			this.OnGetMaxCallback = onGetMaxCallback;
		}

		// Token: 0x060386AE RID: 231086 RVA: 0x00D64DA8 File Offset: 0x00D62FA8
		public void BindSetSumCallback(Action<int> onSetSumCallback)
		{
			this.OnSetSumCallback = onSetSumCallback;
		}

		// Token: 0x060386AF RID: 231087 RVA: 0x00D64DB4 File Offset: 0x00D62FB4
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

		// Token: 0x060386B0 RID: 231088 RVA: 0x00D64DDC File Offset: 0x00D62FDC
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

		// Token: 0x060386B1 RID: 231089 RVA: 0x00D64E30 File Offset: 0x00D63030
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

		// Token: 0x060386B2 RID: 231090 RVA: 0x00D64E82 File Offset: 0x00D63082
		private void OnShowButtonClick()
		{
			this.OnShowCommonItemCountPanel();
		}

		// Token: 0x060386B3 RID: 231091 RVA: 0x00D64E8C File Offset: 0x00D6308C
		private UniTask OnShowCommonItemCountPanel()
		{
			AmountItem.<OnShowCommonItemCountPanel>d__18 <OnShowCommonItemCountPanel>d__;
			<OnShowCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowCommonItemCountPanel>d__.<>4__this = this;
			<OnShowCommonItemCountPanel>d__.<>1__state = -1;
			<OnShowCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<OnShowCommonItemCountPanel>d__18>(ref <OnShowCommonItemCountPanel>d__);
			return <OnShowCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0401DA26 RID: 121382
		private int Sum = 1;

		// Token: 0x0401DA27 RID: 121383
		[Nullable(2)]
		private Func<int> OnGetMaxCallback;

		// Token: 0x0401DA28 RID: 121384
		[Nullable(2)]
		private Action<int> OnSetSumCallback;

		// Token: 0x0401DA29 RID: 121385
		[Nullable(2)]
		private CommonItemCountPanel CommonItemCountPanel;

		// Token: 0x0200B85C RID: 47196
		[NullableContext(0)]
		private class EAmountItemDefine
		{
			// Token: 0x04037CD4 RID: 228564
			public const int AddButton = 0;

			// Token: 0x04037CD5 RID: 228565
			public const int DelButton = 1;

			// Token: 0x04037CD6 RID: 228566
			public const int ShowButton = 2;

			// Token: 0x04037CD7 RID: 228567
			public const int SumText = 3;
		}
	}
}
