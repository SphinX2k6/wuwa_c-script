using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200681F RID: 26655
	public class DangoBrawlLevelRoleItem : UiPanelBase
	{
		// Token: 0x06042830 RID: 272432 RVA: 0x010293FC File Offset: 0x010275FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnRoleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042831 RID: 272433 RVA: 0x010294E4 File Offset: 0x010276E4
		[NullableContext(1)]
		public void Refresh(DangoBrawlRoleData roleData)
		{
			this.RoleData = roleData;
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(roleData.RoleId);
			if (roleConfigById == null)
			{
				return;
			}
			base.SetTextureTransitionByPath(roleConfigById.Value.RoleUnlockIcon, base.GetUiTextureTransitionComponent(1), EUISelectableSelectionState.EUISelectableSelectionState_MAX).Forget();
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!roleData.IsUnlocked);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(roleData.IsUnlocked);
		}

		// Token: 0x06042832 RID: 272434 RVA: 0x01029568 File Offset: 0x01027768
		private void OnBtnRoleClick()
		{
			DangoBrawlRoleViewOpenData dangoBrawlRoleViewOpenData = new DangoBrawlRoleViewOpenData();
			DangoBrawlRoleData roleData = this.RoleData;
			dangoBrawlRoleViewOpenData.RoleId = ((roleData != null) ? new int?(roleData.RoleId) : null);
			DangoBrawlRoleViewOpenData param = dangoBrawlRoleViewOpenData;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleHandBookView, param, null);
		}

		// Token: 0x04022A87 RID: 141959
		[Nullable(2)]
		private DangoBrawlRoleData RoleData;

		// Token: 0x0200C9B7 RID: 51639
		private enum EComponent
		{
			// Token: 0x0403CEFC RID: 249596
			BtnRole,
			// Token: 0x0403CEFD RID: 249597
			TexRole,
			// Token: 0x0403CEFE RID: 249598
			LockItem,
			// Token: 0x0403CEFF RID: 249599
			UnlockItem
		}
	}
}
