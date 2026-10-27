using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02004D80 RID: 19840
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomLangFilter : UiPanelBase
	{
		// Token: 0x060334A6 RID: 210086 RVA: 0x00BF8240 File Offset: 0x00BF6440
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060334A7 RID: 210087 RVA: 0x00BF8330 File Offset: 0x00BF6530
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(false);
			}
			this.ScrollView = new GenericScrollViewNew<RoleLangCustomFilterTabItem, int>(base.GetScrollViewWithScrollbar(4), new Func<RoleLangCustomFilterTabItem>(this.CreateItem), null, false, null);
			List<int> roleLangCustomInfo = this.GetRoleLangCustomInfo();
			this.ScrollView.RefreshByData(roleLangCustomInfo, null, false);
			this.Refresh(-1);
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060334A8 RID: 210088 RVA: 0x00BF83D8 File Offset: 0x00BF65D8
		protected override void OnBeforeDestroy()
		{
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton != null)
			{
				maskButton.Destroy(null);
			}
			base.GetExtendToggle(0).CanExecuteChange.Unbind();
			base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x060334A9 RID: 210089 RVA: 0x00BF8428 File Offset: 0x00BF6628
		public void Refresh(int data)
		{
			this.CurrentSelectedId = data;
			if (data < 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Btn_VoiceDIY_Filter_All", Array.Empty<object>());
			}
			else
			{
				RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(data);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleLangCustomConfigById.Value.Text, Array.Empty<object>());
			}
			List<int> roleLangCustomInfo = this.GetRoleLangCustomInfo();
			this.ScrollView.RefreshByData(roleLangCustomInfo, null, false);
		}

		// Token: 0x060334AA RID: 210090 RVA: 0x00BF84A4 File Offset: 0x00BF66A4
		protected List<int> GetRoleLangCustomInfo()
		{
			List<int> list = new List<int>
			{
				-1
			};
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			foreach (int item in allLanguageTypeForAudio)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x060334AB RID: 210091 RVA: 0x00BF8530 File Offset: 0x00BF6730
		private UniTask ShowMaskButton()
		{
			RoleLangCustomLangFilter.<ShowMaskButton>d__10 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<RoleLangCustomLangFilter.<ShowMaskButton>d__10>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x060334AC RID: 210092 RVA: 0x00BF8573 File Offset: 0x00BF6773
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x060334AD RID: 210093 RVA: 0x00BF8595 File Offset: 0x00BF6795
		private RoleLangCustomFilterTabItem CreateItem()
		{
			return new RoleLangCustomFilterTabItem
			{
				OnClickedCallback = new Action<int>(this.OnClickedToggleItem),
				CheckIsSelected = new Func<int, bool>(this.CheckIsSelected)
			};
		}

		// Token: 0x060334AE RID: 210094 RVA: 0x00BF85C0 File Offset: 0x00BF67C0
		private void OnToggleStateChanged(EToggleState state)
		{
			this.ScrollView.SetActive(state == EToggleState.ETT_Checked);
			if (state == EToggleState.ETT_Checked)
			{
				this.ShowMaskButton();
				return;
			}
			this.HideMaskButton();
		}

		// Token: 0x060334AF RID: 210095 RVA: 0x00BF85E3 File Offset: 0x00BF67E3
		private void OnClickedToggleItem(int data)
		{
			this.Refresh(data);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			Action<int> onToggleChange = this.OnToggleChange;
			if (onToggleChange == null)
			{
				return;
			}
			onToggleChange(data);
		}

		// Token: 0x060334B0 RID: 210096 RVA: 0x00BF860E File Offset: 0x00BF680E
		private bool CheckIsSelected(int data)
		{
			return data == this.CurrentSelectedId;
		}

		// Token: 0x060334B1 RID: 210097 RVA: 0x00BF8619 File Offset: 0x00BF6819
		private void OnClickedMask()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x0401B383 RID: 111491
		protected GenericScrollViewNew<RoleLangCustomFilterTabItem, int> ScrollView;

		// Token: 0x0401B384 RID: 111492
		[Nullable(2)]
		public Action<int> OnToggleChange;

		// Token: 0x0401B385 RID: 111493
		protected int CurrentSelectedId = -1;

		// Token: 0x0401B386 RID: 111494
		private DynamicMaskButton MaskButton;

		// Token: 0x0200AEF6 RID: 44790
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403524C RID: 217676
			TogSort,
			// Token: 0x0403524D RID: 217677
			TxtSort,
			// Token: 0x0403524E RID: 217678
			BtnInfo,
			// Token: 0x0403524F RID: 217679
			BtnSetting,
			// Token: 0x04035250 RID: 217680
			ScrollView,
			// Token: 0x04035251 RID: 217681
			ToggleItem
		}
	}
}
