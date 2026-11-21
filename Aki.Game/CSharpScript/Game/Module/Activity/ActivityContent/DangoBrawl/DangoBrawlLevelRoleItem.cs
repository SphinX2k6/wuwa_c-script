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
	// Token: 0x0200576F RID: 22383
	public class DangoBrawlLevelRoleItem : UiPanelBase
	{
		// Token: 0x06037385 RID: 226181 RVA: 0x00F6A940 File Offset: 0x00F68B40
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

		// Token: 0x06037386 RID: 226182 RVA: 0x00F6AA28 File Offset: 0x00F68C28
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

		// Token: 0x06037387 RID: 226183 RVA: 0x00F6AAAC File Offset: 0x00F68CAC
		private void OnBtnRoleClick()
		{
			DangoBrawlRoleViewOpenData dangoBrawlRoleViewOpenData = new DangoBrawlRoleViewOpenData();
			DangoBrawlRoleData roleData = this.RoleData;
			dangoBrawlRoleViewOpenData.RoleId = ((roleData != null) ? new int?(roleData.RoleId) : null);
			DangoBrawlRoleViewOpenData param = dangoBrawlRoleViewOpenData;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRoleHandBookView, param, null);
		}

		// Token: 0x0401D2E4 RID: 119524
		[Nullable(2)]
		private DangoBrawlRoleData RoleData;

		// Token: 0x0200B384 RID: 45956
		private enum EComponent
		{
			// Token: 0x040377E9 RID: 227305
			BtnRole,
			// Token: 0x040377EA RID: 227306
			TexRole,
			// Token: 0x040377EB RID: 227307
			LockItem,
			// Token: 0x040377EC RID: 227308
			UnlockItem
		}
	}
}
