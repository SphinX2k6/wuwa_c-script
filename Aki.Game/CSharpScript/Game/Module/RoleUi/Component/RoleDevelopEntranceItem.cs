using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.Component
{
	// Token: 0x02003D2D RID: 15661
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopEntranceItem : UiPanelBase
	{
		// Token: 0x060281EE RID: 164334 RVA: 0x00B3AECF File Offset: 0x00B390CF
		public RoleDevelopEntranceItem(RoleViewAgent rootViewAgent)
		{
			this.RoleViewAgent = rootViewAgent;
		}

		// Token: 0x060281EF RID: 164335 RVA: 0x00B3AEE0 File Offset: 0x00B390E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnRoleBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060281F0 RID: 164336 RVA: 0x00B3AFC8 File Offset: 0x00B391C8
		public void RefreshView()
		{
			FunctionModel instance = FunctionModel.Instance;
			bool flag = instance != null && instance.IsOpen(10097);
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			bool flag2 = this.RoleViewAgent.GetCurSelectTabName() == EUiTabViewName.RoleAttributeTabView;
			if (!flag || !flag2 || RoleUtils.IsTrialRole(curSelectRoleId))
			{
				this.RootItem.SetUIActive(false);
				return;
			}
			this.RootItem.SetUIActive(true);
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			UUITexture texture = base.GetTexture(1);
			UUITexture texture2 = base.GetTexture(2);
			if (devTargetRoleId > 0)
			{
				texture2.SetUIActive(true);
				texture.SetUIActive(false);
				base.SetTextureShowUntilLoaded(RoleDevelopModel.Instance.GetDevelopRoleSmallIconPath(), texture2, null);
			}
			else
			{
				texture2.SetUIActive(false);
				texture.SetUIActive(true);
			}
			this.RefreshNewNotifyItem();
		}

		// Token: 0x060281F1 RID: 164337 RVA: 0x00B3B0A0 File Offset: 0x00B392A0
		private void RefreshNewNotifyItem()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			bool uiactive = RoleDevelopModel.Instance.GetRoleDevelopNewState() == ERoleDevelopNewState.New;
			item.SetUIActive(uiactive);
		}

		// Token: 0x060281F2 RID: 164338 RVA: 0x00B3B0D0 File Offset: 0x00B392D0
		private void OnRoleBtnClick()
		{
			RoleDevelopModel.Instance.MarkRoleDevelopNewDismissed();
			this.RefreshNewNotifyItem();
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			RoleController.OpenRoleDevelopView(new int?((devTargetRoleId > 0) ? devTargetRoleId : this.RoleViewAgent.GetCurSelectRoleId()));
		}

		// Token: 0x04015CE2 RID: 89314
		private readonly RoleViewAgent RoleViewAgent;
	}
}
