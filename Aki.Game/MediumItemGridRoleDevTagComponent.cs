using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

// Token: 0x02000DE8 RID: 3560
public class MediumItemGridRoleDevTagComponent : MediumItemGridComponent
{
	// Token: 0x06009090 RID: 37008 RVA: 0x002B56F0 File Offset: 0x002B38F0
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

	// Token: 0x06009091 RID: 37009 RVA: 0x002B5759 File Offset: 0x002B3959
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleDevelopTag";
	}

	// Token: 0x06009092 RID: 37010 RVA: 0x002B5760 File Offset: 0x002B3960
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is ERoleDevelopHotRoleTag)
		{
			ERoleDevelopHotRoleTag eroleDevelopHotRoleTag = (ERoleDevelopHotRoleTag)data;
			bool flag = true;
			this.SetActive(flag);
			if (flag)
			{
				string textStringId;
				if (eroleDevelopHotRoleTag == ERoleDevelopHotRoleTag.Forecast)
				{
					textStringId = "RoleProject_Prospect";
				}
				else if (eroleDevelopHotRoleTag == ERoleDevelopHotRoleTag.Rerun)
				{
					textStringId = "RoleProject_Review";
				}
				else
				{
					if (eroleDevelopHotRoleTag != ERoleDevelopHotRoleTag.Summon)
					{
						this.SetActive(false);
						return;
					}
					textStringId = "RoleProject_Popular";
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
				base.GetTexture(0).SetColor(FColor.FromHex(RoleDevelopDefine.roleDevelopHotRoleTagColor[eroleDevelopHotRoleTag]));
			}
			return;
		}
	}

	// Token: 0x06009093 RID: 37011 RVA: 0x002B57EF File Offset: 0x002B39EF
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0200701A RID: 28698
	private class EChildType
	{
		// Token: 0x04024999 RID: 149913
		public const int TexBg = 0;

		// Token: 0x0402499A RID: 149914
		public const int TxtTagState = 1;
	}
}
