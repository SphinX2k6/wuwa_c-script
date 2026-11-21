using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D20 RID: 15648
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopTabItem : SyncGridProxyAbstract<RoleDevelopTabItemCellData>
	{
		// Token: 0x060280FB RID: 164091 RVA: 0x00B380D4 File Offset: 0x00B362D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnAddButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnChangeButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060280FC RID: 164092 RVA: 0x00B38286 File Offset: 0x00B36486
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		}

		// Token: 0x060280FD RID: 164093 RVA: 0x00B382B6 File Offset: 0x00B364B6
		public void BindOnToggleFunc(Action<int, UUIExtendToggle> toggleFunc)
		{
			this.ToggleFunc = toggleFunc;
		}

		// Token: 0x060280FE RID: 164094 RVA: 0x00B382BF File Offset: 0x00B364BF
		public void BindCanToggleExecuteChange(Func<int, bool> toggle)
		{
			this.OnCanToggleClicked = toggle;
		}

		// Token: 0x060280FF RID: 164095 RVA: 0x00B382C8 File Offset: 0x00B364C8
		private bool CanToggleExecuteChange()
		{
			return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.TypeId);
		}

		// Token: 0x06028100 RID: 164096 RVA: 0x00B382E5 File Offset: 0x00B364E5
		public override void Refresh(RoleDevelopTabItemCellData data)
		{
			this.TypeId = data.TypeId;
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshView();
		}

		// Token: 0x06028101 RID: 164097 RVA: 0x00B3830C File Offset: 0x00B3650C
		private void RefreshView()
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			bool flag = devTargetRoleId > 0;
			base.GetTexture(1).SetUIActive(flag);
			base.GetTexture(3).SetUIActive(!flag);
			base.GetButton(6).RootUIComp.Get().SetUIActive(!flag);
			base.GetButton(7).RootUIComp.Get().SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RoleProject_Target", Array.Empty<object>());
			if (flag)
			{
				RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(devTargetRoleId);
				base.GetText(5).SetText(roleDevelopData.GetDevelopRoleData().GetName(), true);
				this.RefreshDevelopTagItem(roleDevelopData.GetHotRoleTag());
				base.SetRoleIcon(roleDevelopData.GetDevelopRoleData().GetRoleIconPath(), base.GetTexture(1), devTargetRoleId, null, null);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_NoneTarget", Array.Empty<object>());
			this.RefreshDevelopTagItem(ERoleDevelopHotRoleTag.None);
		}

		// Token: 0x06028102 RID: 164098 RVA: 0x00B38414 File Offset: 0x00B36614
		private void RefreshDevelopTagItem(ERoleDevelopHotRoleTag roleTagType)
		{
			RoleDevelopTagItem roleDevelopTagItem = new RoleDevelopTagItem();
			this.DevelopTagItem = roleDevelopTagItem;
			this.LoadDevelopTagItemAsync(roleDevelopTagItem, roleTagType).Forget();
		}

		// Token: 0x06028103 RID: 164099 RVA: 0x00B3843C File Offset: 0x00B3663C
		private UniTask LoadDevelopTagItemAsync(RoleDevelopTagItem item, ERoleDevelopHotRoleTag roleTagType)
		{
			RoleDevelopTabItem.<LoadDevelopTagItemAsync>d__14 <LoadDevelopTagItemAsync>d__;
			<LoadDevelopTagItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDevelopTagItemAsync>d__.<>4__this = this;
			<LoadDevelopTagItemAsync>d__.item = item;
			<LoadDevelopTagItemAsync>d__.roleTagType = roleTagType;
			<LoadDevelopTagItemAsync>d__.<>1__state = -1;
			<LoadDevelopTagItemAsync>d__.<>t__builder.Start<RoleDevelopTabItem.<LoadDevelopTagItemAsync>d__14>(ref <LoadDevelopTagItemAsync>d__);
			return <LoadDevelopTagItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028104 RID: 164100 RVA: 0x00B3848F File Offset: 0x00B3668F
		public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, true);
			this.ToggleFunc(this.TypeId, this.Toggle);
		}

		// Token: 0x06028105 RID: 164101 RVA: 0x00B384B8 File Offset: 0x00B366B8
		[NullableContext(2)]
		public UUIItem GetButtonItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (extendToggle != null) ? new TWeakObjectPtr<UUIItem>?(extendToggle.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x06028106 RID: 164102 RVA: 0x00B384FD File Offset: 0x00B366FD
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ToggleFunc(this.TypeId, this.Toggle);
			}
		}

		// Token: 0x06028107 RID: 164103 RVA: 0x00B3851C File Offset: 0x00B3671C
		private void OnAddButtonClick()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, null);
		}

		// Token: 0x06028108 RID: 164104 RVA: 0x00B38538 File Offset: 0x00B36738
		private void OnChangeButtonClick()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, new int?(RoleDevelopModel.Instance.DevTargetRoleId));
		}

		// Token: 0x04015CD1 RID: 89297
		private int TypeId;

		// Token: 0x04015CD2 RID: 89298
		[Nullable(2)]
		private UUIExtendToggle Toggle;

		// Token: 0x04015CD3 RID: 89299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle> ToggleFunc;

		// Token: 0x04015CD4 RID: 89300
		[Nullable(2)]
		private Func<int, bool> OnCanToggleClicked;

		// Token: 0x04015CD5 RID: 89301
		[Nullable(2)]
		private RoleDevelopTagItem DevelopTagItem;

		// Token: 0x02009900 RID: 39168
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FBA9 RID: 195497
			Toggle,
			// Token: 0x0402FBAA RID: 195498
			RoleTexture,
			// Token: 0x0402FBAB RID: 195499
			DevelopTagItem,
			// Token: 0x0402FBAC RID: 195500
			EmptyTexture,
			// Token: 0x0402FBAD RID: 195501
			TitleText,
			// Token: 0x0402FBAE RID: 195502
			NameText,
			// Token: 0x0402FBAF RID: 195503
			AddButton,
			// Token: 0x0402FBB0 RID: 195504
			ChangeButton
		}
	}
}
