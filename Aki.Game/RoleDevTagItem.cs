using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020027FB RID: 10235
public class RoleDevTagItem : UiPanelBase
{
	// Token: 0x06015025 RID: 86053 RVA: 0x005523A4 File Offset: 0x005505A4
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

	// Token: 0x06015026 RID: 86054 RVA: 0x00552410 File Offset: 0x00550610
	public void SetData(ERoleTypeTag typeTag)
	{
		string textStringId;
		switch (typeTag)
		{
		case ERoleTypeTag.Forecast:
			textStringId = "RoleProject_Prospect";
			break;
		case ERoleTypeTag.Rerun:
			textStringId = "RoleProject_Review";
			break;
		case ERoleTypeTag.Summon:
			textStringId = "RoleProject_Popular";
			break;
		default:
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x02008E48 RID: 36424
	private enum EComponent
	{
		// Token: 0x0402E27B RID: 189051
		TexBg,
		// Token: 0x0402E27C RID: 189052
		TxtTagState
	}
}
