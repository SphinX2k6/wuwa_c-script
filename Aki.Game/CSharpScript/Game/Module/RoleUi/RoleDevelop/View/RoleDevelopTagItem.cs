using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D21 RID: 15649
	public class RoleDevelopTagItem : UiPanelBase
	{
		// Token: 0x0602810A RID: 164106 RVA: 0x00B38558 File Offset: 0x00B36758
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602810B RID: 164107 RVA: 0x00B385C4 File Offset: 0x00B367C4
		public void RefreshByData(ERoleDevelopHotRoleTag tagType)
		{
			if (tagType == ERoleDevelopHotRoleTag.None)
			{
				base.SetUiActive(false);
				return;
			}
			string textStringId;
			if (tagType == ERoleDevelopHotRoleTag.Summon)
			{
				textStringId = "RoleProject_Popular";
			}
			else if (tagType == ERoleDevelopHotRoleTag.Forecast)
			{
				textStringId = "RoleProject_Prospect";
			}
			else
			{
				if (tagType != ERoleDevelopHotRoleTag.Rerun)
				{
					base.SetUiActive(false);
					return;
				}
				textStringId = "RoleProject_Review";
			}
			base.SetUiActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
			base.GetTexture(0).SetColor(FColor.FromHex(RoleDevelopDefine.roleDevelopHotRoleTagColor[tagType]));
		}

		// Token: 0x02009902 RID: 39170
		private enum EComponentType
		{
			// Token: 0x0402FBB8 RID: 195512
			BgTex,
			// Token: 0x0402FBB9 RID: 195513
			TagStateTxt
		}
	}
}
