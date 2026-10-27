using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.Component
{
	// Token: 0x02004D64 RID: 19812
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopEntranceItem : UiPanelBase
	{
		// Token: 0x06033381 RID: 209793 RVA: 0x00BF1D13 File Offset: 0x00BEFF13
		public RoleDevelopEntranceItem(RoleViewAgent rootViewAgent)
		{
			this.RoleViewAgent = rootViewAgent;
		}

		// Token: 0x06033382 RID: 209794 RVA: 0x00BF1D24 File Offset: 0x00BEFF24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnRoleBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033383 RID: 209795 RVA: 0x00BF1DEC File Offset: 0x00BEFFEC
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
				return;
			}
			texture2.SetUIActive(false);
			texture.SetUIActive(true);
		}

		// Token: 0x06033384 RID: 209796 RVA: 0x00BF1EBC File Offset: 0x00BF00BC
		private void OnRoleBtnClick()
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			RoleController.OpenRoleDevelopView(new int?((devTargetRoleId > 0) ? devTargetRoleId : this.RoleViewAgent.GetCurSelectRoleId()));
		}

		// Token: 0x0401B310 RID: 111376
		private readonly RoleViewAgent RoleViewAgent;
	}
}
