using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200472D RID: 18221
	public class KurotatoLevelHistoryRolePanel : UiPanelBase
	{
		// Token: 0x0602DC27 RID: 187431 RVA: 0x00CCD4D0 File Offset: 0x00CCB6D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DC28 RID: 187432 RVA: 0x00CCD57C File Offset: 0x00CCB77C
		public void Refresh(int roleId)
		{
			bool flag = roleId == 0;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				return;
			}
			KurotatoRoleData kurotatoRoleData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoRoleData(roleId);
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(kurotatoRoleData.RealRoleId).Value;
			base.SetTextureByPath(SkinConfig.Instance.GetRoleSkinConfig(kurotatoRoleData.RealRoleSkinId).Value.FormationRoleCard, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value.Name, Array.Empty<object>());
		}

		// Token: 0x0200A36C RID: 41836
		private enum EComponent
		{
			// Token: 0x04032AB4 RID: 207540
			ItemEmpty,
			// Token: 0x04032AB5 RID: 207541
			ItemRolePanel,
			// Token: 0x04032AB6 RID: 207542
			TextureRole,
			// Token: 0x04032AB7 RID: 207543
			TextName
		}
	}
}
