using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B0E RID: 19214
	[NullableContext(1)]
	[Nullable(0)]
	public class AmountItem : UiPanelBase
	{
		// Token: 0x06030105 RID: 196869 RVA: 0x00D68C50 File Offset: 0x00D66E50
		public AmountItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06030106 RID: 196870 RVA: 0x00D68C6C File Offset: 0x00D66E6C
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(delegate()
			{
				this.OnAdd();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(delegate()
			{
				this.OnDel();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(delegate()
			{
				this.OnShowBtnClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030107 RID: 196871 RVA: 0x00D68D9A File Offset: 0x00D66F9A
		protected override void OnStart()
		{
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x06030108 RID: 196872 RVA: 0x00D68DB4 File Offset: 0x00D66FB4
		private UniTask InitCommonItemCountPanel()
		{
			AmountItem.<InitCommonItemCountPanel>d__7 <InitCommonItemCountPanel>d__;
			<InitCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonItemCountPanel>d__.<>4__this = this;
			<InitCommonItemCountPanel>d__.<>1__state = -1;
			<InitCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<InitCommonItemCountPanel>d__7>(ref <InitCommonItemCountPanel>d__);
			return <InitCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06030109 RID: 196873 RVA: 0x00D68DF8 File Offset: 0x00D66FF8
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

		// Token: 0x0603010A RID: 196874 RVA: 0x00D68E61 File Offset: 0x00D67061
		public void ResetSum()
		{
			this.Sum = 1;
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0603010B RID: 196875 RVA: 0x00D68E84 File Offset: 0x00D67084
		public void RefreshAddAndDelButton()
		{
			((base.GetButton(1).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum != 1);
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum < this.GetMaxCallback());
		}

		// Token: 0x0603010C RID: 196876 RVA: 0x00D68EFF File Offset: 0x00D670FF
		public void BindGetMaxCallback(Func<int> onGetMaxCallback)
		{
			this.OnGetMaxCallback = onGetMaxCallback;
		}

		// Token: 0x0603010D RID: 196877 RVA: 0x00D68F08 File Offset: 0x00D67108
		public void BindSetSumCallback(Action<int> onSetSumCallback)
		{
			this.OnSetSumCallback = onSetSumCallback;
		}

		// Token: 0x0603010E RID: 196878 RVA: 0x00D68F14 File Offset: 0x00D67114
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

		// Token: 0x0603010F RID: 196879 RVA: 0x00D68F3C File Offset: 0x00D6713C
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

		// Token: 0x06030110 RID: 196880 RVA: 0x00D68F90 File Offset: 0x00D67190
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

		// Token: 0x06030111 RID: 196881 RVA: 0x00D68FE2 File Offset: 0x00D671E2
		private void OnShowBtnClick()
		{
			this.OnShowCommonItemCountPanel().Forget();
		}

		// Token: 0x06030112 RID: 196882 RVA: 0x00D68FF0 File Offset: 0x00D671F0
		private UniTask OnShowCommonItemCountPanel()
		{
			AmountItem.<OnShowCommonItemCountPanel>d__17 <OnShowCommonItemCountPanel>d__;
			<OnShowCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowCommonItemCountPanel>d__.<>4__this = this;
			<OnShowCommonItemCountPanel>d__.<>1__state = -1;
			<OnShowCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<OnShowCommonItemCountPanel>d__17>(ref <OnShowCommonItemCountPanel>d__);
			return <OnShowCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x040197BF RID: 104383
		private int Sum = 1;

		// Token: 0x040197C0 RID: 104384
		[Nullable(2)]
		private Func<int> OnGetMaxCallback;

		// Token: 0x040197C1 RID: 104385
		[Nullable(2)]
		private Action<int> OnSetSumCallback;

		// Token: 0x040197C2 RID: 104386
		[Nullable(2)]
		private CommonItemCountPanel CommonItemCountPanel;
	}
}
