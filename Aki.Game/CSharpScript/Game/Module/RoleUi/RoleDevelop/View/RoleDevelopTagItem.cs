using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D58 RID: 19800
	public class RoleDevelopTagItem : UiPanelBase
	{
		// Token: 0x060332A0 RID: 209568 RVA: 0x00BEF424 File Offset: 0x00BED624
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

		// Token: 0x060332A1 RID: 209569 RVA: 0x00BEF490 File Offset: 0x00BED690
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

		// Token: 0x0200AECF RID: 44751
		public static class EComponentType
		{
			// Token: 0x04035188 RID: 217480
			public const int BgTex = 0;

			// Token: 0x04035189 RID: 217481
			public const int TagStateTxt = 1;
		}
	}
}
