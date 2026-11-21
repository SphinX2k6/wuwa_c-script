using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D08 RID: 15624
	public class RoleDevelopProjectOverviewFormationItem : UiPanelBase
	{
		// Token: 0x06027FDA RID: 163802 RVA: 0x00B30C14 File Offset: 0x00B2EE14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027FDB RID: 163803 RVA: 0x00B30C5C File Offset: 0x00B2EE5C
		public void Refresh(int roleId, bool isSmallIcon = false)
		{
			RoleInfo? roleInfo = (roleId != 0) ? RoleConfig.Instance.GetRoleConfig(roleId) : null;
			if (roleInfo == null)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			UUITexture iconTexture = base.GetTexture(0);
			iconTexture.SetUIActive(false);
			string path = isSmallIcon ? roleInfo.Value.Card : roleInfo.Value.RoleHeadIconCircle;
			base.SetRoleIcon(path, iconTexture, roleId, null, delegate(bool _)
			{
				iconTexture.SetUIActive(true);
			});
		}

		// Token: 0x020098D1 RID: 39121
		private enum EComponentType
		{
			// Token: 0x0402FA7D RID: 195197
			RoleIconTexture
		}
	}
}
