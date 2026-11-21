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
	// Token: 0x02003D49 RID: 15689
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangCustomLangFilter : UiPanelBase
	{
		// Token: 0x06028313 RID: 164627 RVA: 0x00B4183C File Offset: 0x00B3FA3C
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

		// Token: 0x06028314 RID: 164628 RVA: 0x00B4192C File Offset: 0x00B3FB2C
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

		// Token: 0x06028315 RID: 164629 RVA: 0x00B419D4 File Offset: 0x00B3FBD4
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

		// Token: 0x06028316 RID: 164630 RVA: 0x00B41A24 File Offset: 0x00B3FC24
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

		// Token: 0x06028317 RID: 164631 RVA: 0x00B41AA0 File Offset: 0x00B3FCA0
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

		// Token: 0x06028318 RID: 164632 RVA: 0x00B41B2C File Offset: 0x00B3FD2C
		private UniTask ShowMaskButton()
		{
			RoleLangCustomLangFilter.<ShowMaskButton>d__10 <ShowMaskButton>d__;
			<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowMaskButton>d__.<>4__this = this;
			<ShowMaskButton>d__.<>1__state = -1;
			<ShowMaskButton>d__.<>t__builder.Start<RoleLangCustomLangFilter.<ShowMaskButton>d__10>(ref <ShowMaskButton>d__);
			return <ShowMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x06028319 RID: 164633 RVA: 0x00B41B6F File Offset: 0x00B3FD6F
		private void HideMaskButton()
		{
			if (this.MaskButton == null)
			{
				return;
			}
			this.MaskButton.ResetItemParent();
			this.MaskButton.SetActive(false);
		}

		// Token: 0x0602831A RID: 164634 RVA: 0x00B41B91 File Offset: 0x00B3FD91
		private RoleLangCustomFilterTabItem CreateItem()
		{
			return new RoleLangCustomFilterTabItem
			{
				OnClickedCallback = new Action<int>(this.OnClickedToggleItem),
				CheckIsSelected = new Func<int, bool>(this.CheckIsSelected)
			};
		}

		// Token: 0x0602831B RID: 164635 RVA: 0x00B41BBC File Offset: 0x00B3FDBC
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

		// Token: 0x0602831C RID: 164636 RVA: 0x00B41BDF File Offset: 0x00B3FDDF
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

		// Token: 0x0602831D RID: 164637 RVA: 0x00B41C0A File Offset: 0x00B3FE0A
		private bool CheckIsSelected(int data)
		{
			return data == this.CurrentSelectedId;
		}

		// Token: 0x0602831E RID: 164638 RVA: 0x00B41C15 File Offset: 0x00B3FE15
		private void OnClickedMask()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x04015D56 RID: 89430
		protected GenericScrollViewNew<RoleLangCustomFilterTabItem, int> ScrollView;

		// Token: 0x04015D57 RID: 89431
		[Nullable(2)]
		public Action<int> OnToggleChange;

		// Token: 0x04015D58 RID: 89432
		protected int CurrentSelectedId = -1;

		// Token: 0x04015D59 RID: 89433
		private DynamicMaskButton MaskButton;

		// Token: 0x0200992A RID: 39210
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402FC80 RID: 195712
			TogSort,
			// Token: 0x0402FC81 RID: 195713
			TxtSort,
			// Token: 0x0402FC82 RID: 195714
			BtnInfo,
			// Token: 0x0402FC83 RID: 195715
			BtnSetting,
			// Token: 0x0402FC84 RID: 195716
			ScrollView,
			// Token: 0x0402FC85 RID: 195717
			ToggleItem
		}
	}
}
