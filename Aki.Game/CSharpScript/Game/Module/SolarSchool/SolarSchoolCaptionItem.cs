using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005991 RID: 22929
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolCaptionItem : UiPanelBase
	{
		// Token: 0x0603888B RID: 231563 RVA: 0x00FD154C File Offset: 0x00FCF74C
		public void SetNavCallbacks(Action onBack, Action onClose)
		{
			this.BackCallback = onBack;
			this.CloseCallback = onClose;
		}

		// Token: 0x0603888C RID: 231564 RVA: 0x00FD155C File Offset: 0x00FCF75C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnBackClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnSetClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnCloseClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBtnOverviewClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnBtnBackpackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603888D RID: 231565 RVA: 0x00FD1778 File Offset: 0x00FCF978
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolCaptionItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolCaptionItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603888E RID: 231566 RVA: 0x00FD17BB File Offset: 0x00FCF9BB
		protected override void OnStart()
		{
			this.ResetToDefault();
		}

		// Token: 0x0603888F RID: 231567 RVA: 0x00FD17C3 File Offset: 0x00FCF9C3
		protected override void OnBeforeDestroy()
		{
			this.BackCallback = null;
			this.CloseCallback = null;
			this.TipCost = null;
		}

		// Token: 0x06038890 RID: 231568 RVA: 0x00FD17DA File Offset: 0x00FCF9DA
		public void ResetToDefault()
		{
			this.SetBackVisible(false);
			this.SetCloseVisible(false);
			this.SetHelpGroupId(0);
			this.SetSetVisible(false);
			this.SetTipCostVisible(false);
			this.SetOverviewVisible(false);
			this.SetBackpackVisible(false);
		}

		// Token: 0x06038891 RID: 231569 RVA: 0x00FD180D File Offset: 0x00FCFA0D
		[NullableContext(1)]
		public void SetTitle(string title)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(title, true);
		}

		// Token: 0x06038892 RID: 231570 RVA: 0x00FD1822 File Offset: 0x00FCFA22
		public void SetTitleIconVisible(bool visible)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(visible);
		}

		// Token: 0x06038893 RID: 231571 RVA: 0x00FD1836 File Offset: 0x00FCFA36
		public void SetBackVisible(bool visible)
		{
			this.SetButtonVisible(2, visible);
		}

		// Token: 0x06038894 RID: 231572 RVA: 0x00FD1840 File Offset: 0x00FCFA40
		public void SetCloseVisible(bool visible)
		{
			this.SetButtonVisible(6, visible);
		}

		// Token: 0x06038895 RID: 231573 RVA: 0x00FD184A File Offset: 0x00FCFA4A
		public void SetSetVisible(bool visible)
		{
			this.SetButtonVisible(4, visible);
		}

		// Token: 0x06038896 RID: 231574 RVA: 0x00FD1854 File Offset: 0x00FCFA54
		public void SetTipCostVisible(bool visible)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(visible);
			}
			if (visible)
			{
				SolarSchoolTipCostItem tipCost = this.TipCost;
				if (tipCost == null)
				{
					return;
				}
				tipCost.Refresh();
			}
		}

		// Token: 0x06038897 RID: 231575 RVA: 0x00FD187C File Offset: 0x00FCFA7C
		public void SetHelpGroupId(int helpGroupId)
		{
			UUIItem item = base.GetItem(3);
			bool flag = helpGroupId != 0;
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = helpGroupId;
			}
		}

		// Token: 0x06038898 RID: 231576 RVA: 0x00FD18D8 File Offset: 0x00FCFAD8
		public void SetOverviewVisible(bool visible)
		{
			bool flag = SolarSchoolGamePlayModel.Instance.IsFunctionUnlocked(ESolarSchoolFunction.RoleInfo);
			this.SetButtonVisible(7, visible && flag);
		}

		// Token: 0x06038899 RID: 231577 RVA: 0x00FD18FB File Offset: 0x00FCFAFB
		public void SetBackpackVisible(bool visible)
		{
			this.SetButtonVisible(8, visible);
		}

		// Token: 0x0603889A RID: 231578 RVA: 0x00FD1905 File Offset: 0x00FCFB05
		public void SetFatiguePreview(int fatigue)
		{
			SolarSchoolTipCostItem tipCost = this.TipCost;
			if (tipCost == null)
			{
				return;
			}
			tipCost.SetFatiguePreview(fatigue);
		}

		// Token: 0x0603889B RID: 231579 RVA: 0x00FD1918 File Offset: 0x00FCFB18
		public void ClearFatiguePreview()
		{
			SolarSchoolTipCostItem tipCost = this.TipCost;
			if (tipCost == null)
			{
				return;
			}
			tipCost.ClearFatiguePreview();
		}

		// Token: 0x0603889C RID: 231580 RVA: 0x00FD192A File Offset: 0x00FCFB2A
		public void HoldFatigueUntilSettled(int fatigue)
		{
			SolarSchoolTipCostItem tipCost = this.TipCost;
			if (tipCost == null)
			{
				return;
			}
			tipCost.HoldFatigueUntilSettled(fatigue);
		}

		// Token: 0x0603889D RID: 231581 RVA: 0x00FD1940 File Offset: 0x00FCFB40
		private void SetButtonVisible(int component, bool visible)
		{
			UUIButtonComponent button = base.GetButton(component);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x0603889E RID: 231582 RVA: 0x00FD1971 File Offset: 0x00FCFB71
		private void OnBtnBackClick()
		{
			Action backCallback = this.BackCallback;
			if (backCallback == null)
			{
				return;
			}
			backCallback();
		}

		// Token: 0x0603889F RID: 231583 RVA: 0x00FD1983 File Offset: 0x00FCFB83
		private void OnBtnCloseClick()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x060388A0 RID: 231584 RVA: 0x00FD1995 File Offset: 0x00FCFB95
		private void OnBtnSetClick()
		{
			SolarSchoolModel.Instance.ShowSettingView();
		}

		// Token: 0x060388A1 RID: 231585 RVA: 0x00FD19A1 File Offset: 0x00FCFBA1
		private void OnBtnOverviewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolInfoOverviewView, null, null);
		}

		// Token: 0x060388A2 RID: 231586 RVA: 0x00FD19B4 File Offset: 0x00FCFBB4
		private void OnBtnBackpackClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolBagView, null, null);
		}

		// Token: 0x0401DC7E RID: 121982
		private SolarSchoolTipCostItem TipCost;

		// Token: 0x0401DC7F RID: 121983
		private Action BackCallback;

		// Token: 0x0401DC80 RID: 121984
		private Action CloseCallback;

		// Token: 0x0200B536 RID: 46390
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038072 RID: 229490
			public const int SprTitleIcon = 0;

			// Token: 0x04038073 RID: 229491
			public const int TxtTitle = 1;

			// Token: 0x04038074 RID: 229492
			public const int BtnBack = 2;

			// Token: 0x04038075 RID: 229493
			public const int BtnHelpInfo = 3;

			// Token: 0x04038076 RID: 229494
			public const int BtnSet = 4;

			// Token: 0x04038077 RID: 229495
			public const int BtnSolarSchoolTipCost = 5;

			// Token: 0x04038078 RID: 229496
			public const int BtnSolarSchoolBack = 6;

			// Token: 0x04038079 RID: 229497
			public const int BtnOverview = 7;

			// Token: 0x0403807A RID: 229498
			public const int BtnBackpack = 8;
		}
	}
}
