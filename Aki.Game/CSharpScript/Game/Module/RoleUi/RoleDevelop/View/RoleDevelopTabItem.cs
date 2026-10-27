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
	// Token: 0x02004D57 RID: 19799
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopTabItem : SyncGridProxyAbstract<RoleDevelopTabItemCellData>
	{
		// Token: 0x06033291 RID: 209553 RVA: 0x00BEEFA0 File Offset: 0x00BED1A0
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

		// Token: 0x06033292 RID: 209554 RVA: 0x00BEF152 File Offset: 0x00BED352
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

		// Token: 0x06033293 RID: 209555 RVA: 0x00BEF182 File Offset: 0x00BED382
		public void BindOnToggleFunc(Action<int, UUIExtendToggle> toggleFunc)
		{
			this.ToggleFunc = toggleFunc;
		}

		// Token: 0x06033294 RID: 209556 RVA: 0x00BEF18B File Offset: 0x00BED38B
		public void BindCanToggleExecuteChange(Func<int, bool> toggle)
		{
			this.OnCanToggleClicked = toggle;
		}

		// Token: 0x06033295 RID: 209557 RVA: 0x00BEF194 File Offset: 0x00BED394
		private bool CanToggleExecuteChange()
		{
			return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.TypeId);
		}

		// Token: 0x06033296 RID: 209558 RVA: 0x00BEF1B1 File Offset: 0x00BED3B1
		public override void Refresh(RoleDevelopTabItemCellData data)
		{
			this.TypeId = data.TypeId;
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshView();
		}

		// Token: 0x06033297 RID: 209559 RVA: 0x00BEF1D8 File Offset: 0x00BED3D8
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

		// Token: 0x06033298 RID: 209560 RVA: 0x00BEF2E0 File Offset: 0x00BED4E0
		private void RefreshDevelopTagItem(ERoleDevelopHotRoleTag roleTagType)
		{
			RoleDevelopTagItem roleDevelopTagItem = new RoleDevelopTagItem();
			this.DevelopTagItem = roleDevelopTagItem;
			this.LoadDevelopTagItemAsync(roleDevelopTagItem, roleTagType).Forget();
		}

		// Token: 0x06033299 RID: 209561 RVA: 0x00BEF308 File Offset: 0x00BED508
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

		// Token: 0x0603329A RID: 209562 RVA: 0x00BEF35B File Offset: 0x00BED55B
		public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, true);
			this.ToggleFunc(this.TypeId, this.Toggle);
		}

		// Token: 0x0603329B RID: 209563 RVA: 0x00BEF384 File Offset: 0x00BED584
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

		// Token: 0x0603329C RID: 209564 RVA: 0x00BEF3C9 File Offset: 0x00BED5C9
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ToggleFunc(this.TypeId, this.Toggle);
			}
		}

		// Token: 0x0603329D RID: 209565 RVA: 0x00BEF3E8 File Offset: 0x00BED5E8
		private void OnAddButtonClick()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, null);
		}

		// Token: 0x0603329E RID: 209566 RVA: 0x00BEF404 File Offset: 0x00BED604
		private void OnChangeButtonClick()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, new int?(RoleDevelopModel.Instance.DevTargetRoleId));
		}

		// Token: 0x0401B300 RID: 111360
		private int TypeId;

		// Token: 0x0401B301 RID: 111361
		[Nullable(2)]
		private UUIExtendToggle Toggle;

		// Token: 0x0401B302 RID: 111362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle> ToggleFunc;

		// Token: 0x0401B303 RID: 111363
		[Nullable(2)]
		private Func<int, bool> OnCanToggleClicked;

		// Token: 0x0401B304 RID: 111364
		[Nullable(2)]
		private RoleDevelopTagItem DevelopTagItem;

		// Token: 0x0200AECD RID: 44749
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x0403517A RID: 217466
			public const int Toggle = 0;

			// Token: 0x0403517B RID: 217467
			public const int RoleTexture = 1;

			// Token: 0x0403517C RID: 217468
			public const int DevelopTagItem = 2;

			// Token: 0x0403517D RID: 217469
			public const int EmptyTexture = 3;

			// Token: 0x0403517E RID: 217470
			public const int TitleText = 4;

			// Token: 0x0403517F RID: 217471
			public const int NameText = 5;

			// Token: 0x04035180 RID: 217472
			public const int AddButton = 6;

			// Token: 0x04035181 RID: 217473
			public const int ChangeButton = 7;
		}
	}
}
