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
	// Token: 0x02005B2D RID: 23341
	[NullableContext(1)]
	[Nullable(0)]
	public class AmountItem : UiPanelBase
	{
		// Token: 0x0603B193 RID: 242067 RVA: 0x00E17F38 File Offset: 0x00E16138
		public AmountItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B194 RID: 242068 RVA: 0x00E17F54 File Offset: 0x00E16154
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

		// Token: 0x0603B195 RID: 242069 RVA: 0x00E18082 File Offset: 0x00E16282
		protected override void OnStart()
		{
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0603B196 RID: 242070 RVA: 0x00E1809C File Offset: 0x00E1629C
		private UniTask InitCommonItemCountPanel()
		{
			AmountItem.<InitCommonItemCountPanel>d__7 <InitCommonItemCountPanel>d__;
			<InitCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonItemCountPanel>d__.<>4__this = this;
			<InitCommonItemCountPanel>d__.<>1__state = -1;
			<InitCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<InitCommonItemCountPanel>d__7>(ref <InitCommonItemCountPanel>d__);
			return <InitCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603B197 RID: 242071 RVA: 0x00E180E0 File Offset: 0x00E162E0
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

		// Token: 0x0603B198 RID: 242072 RVA: 0x00E18149 File Offset: 0x00E16349
		public void ResetSum()
		{
			this.Sum = 1;
			base.GetText(3).SetText(this.Sum.ToString(), true);
		}

		// Token: 0x0603B199 RID: 242073 RVA: 0x00E1816C File Offset: 0x00E1636C
		public void RefreshAddAndDelButton()
		{
			((base.GetButton(1).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum != 1);
			((base.GetButton(0).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup).SetInteractable(this.Sum < this.GetMaxCallback());
		}

		// Token: 0x0603B19A RID: 242074 RVA: 0x00E181E7 File Offset: 0x00E163E7
		public void BindGetMaxCallback(Func<int> onGetMaxCallback)
		{
			this.OnGetMaxCallback = onGetMaxCallback;
		}

		// Token: 0x0603B19B RID: 242075 RVA: 0x00E181F0 File Offset: 0x00E163F0
		public void BindSetSumCallback(Action<int> onSetSumCallback)
		{
			this.OnSetSumCallback = onSetSumCallback;
		}

		// Token: 0x0603B19C RID: 242076 RVA: 0x00E181FC File Offset: 0x00E163FC
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

		// Token: 0x0603B19D RID: 242077 RVA: 0x00E18224 File Offset: 0x00E16424
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

		// Token: 0x0603B19E RID: 242078 RVA: 0x00E18278 File Offset: 0x00E16478
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

		// Token: 0x0603B19F RID: 242079 RVA: 0x00E182CA File Offset: 0x00E164CA
		private void OnShowBtnClick()
		{
			this.OnShowCommonItemCountPanel().Forget();
		}

		// Token: 0x0603B1A0 RID: 242080 RVA: 0x00E182D8 File Offset: 0x00E164D8
		private UniTask OnShowCommonItemCountPanel()
		{
			AmountItem.<OnShowCommonItemCountPanel>d__17 <OnShowCommonItemCountPanel>d__;
			<OnShowCommonItemCountPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowCommonItemCountPanel>d__.<>4__this = this;
			<OnShowCommonItemCountPanel>d__.<>1__state = -1;
			<OnShowCommonItemCountPanel>d__.<>t__builder.Start<AmountItem.<OnShowCommonItemCountPanel>d__17>(ref <OnShowCommonItemCountPanel>d__);
			return <OnShowCommonItemCountPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0401ED03 RID: 126211
		private int Sum = 1;

		// Token: 0x0401ED04 RID: 126212
		[Nullable(2)]
		private Func<int> OnGetMaxCallback;

		// Token: 0x0401ED05 RID: 126213
		[Nullable(2)]
		private Action<int> OnSetSumCallback;

		// Token: 0x0401ED06 RID: 126214
		[Nullable(2)]
		private CommonItemCountPanel CommonItemCountPanel;
	}
}
