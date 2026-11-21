using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D76 RID: 7542
public class RoleDevTagItem : UiPanelBase
{
	// Token: 0x06012A25 RID: 76325 RVA: 0x0057D118 File Offset: 0x0057B318
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

	// Token: 0x06012A26 RID: 76326 RVA: 0x0057D184 File Offset: 0x0057B384
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

	// Token: 0x02008091 RID: 32913
	private enum EComponent
	{
		// Token: 0x04029978 RID: 170360
		TexBg,
		// Token: 0x04029979 RID: 170361
		TxtTagState
	}
}
