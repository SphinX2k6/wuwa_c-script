using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using UnrealEngine;

// Token: 0x0200192F RID: 6447
public class MediumItemGridRoleDevTagComponent : MediumItemGridComponent
{
	// Token: 0x0600BCA6 RID: 48294 RVA: 0x002AAF94 File Offset: 0x002A9194
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

	// Token: 0x0600BCA7 RID: 48295 RVA: 0x002AAFFD File Offset: 0x002A91FD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_RoleDevelopTag";
	}

	// Token: 0x0600BCA8 RID: 48296 RVA: 0x002AB004 File Offset: 0x002A9204
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

	// Token: 0x0600BCA9 RID: 48297 RVA: 0x002AB093 File Offset: 0x002A9293
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007E93 RID: 32403
	private class EChildType
	{
		// Token: 0x0402966D RID: 169581
		public const int TexBg = 0;

		// Token: 0x0402966E RID: 169582
		public const int TxtTagState = 1;
	}
}
