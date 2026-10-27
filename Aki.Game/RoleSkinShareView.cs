using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A2D RID: 10797
[NullableContext(2)]
[Nullable(0)]
public class RoleSkinShareView : UiPanelBase
{
	// Token: 0x06016776 RID: 92022 RVA: 0x005B0FC8 File Offset: 0x005AF1C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06016777 RID: 92023 RVA: 0x005B1052 File Offset: 0x005AF252
	protected override void OnStart()
	{
		this.CurrentData = (this.OpenParam as RoleSkinData);
		this.RefreshView();
	}

	// Token: 0x06016778 RID: 92024 RVA: 0x005B106B File Offset: 0x005AF26B
	private void RefreshView()
	{
		this.RefreshRoleTexture(this.CurrentData);
		this.RefreshTitleText(this.CurrentData);
		this.RefreshSubTitleText(this.CurrentData);
	}

	// Token: 0x06016779 RID: 92025 RVA: 0x005B1094 File Offset: 0x005AF294
	private void RefreshRoleTexture(RoleSkinData data)
	{
		if (data == null)
		{
			return;
		}
		string shareTexturePath = data.GetShareTexturePath();
		base.SetTextureByPath(shareTexturePath, base.GetTexture(0), null, null);
	}

	// Token: 0x0601677A RID: 92026 RVA: 0x005B10C4 File Offset: 0x005AF2C4
	private void RefreshTitleText(RoleSkinData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.GetTitleName(), Array.Empty<object>());
	}

	// Token: 0x0601677B RID: 92027 RVA: 0x005B10E2 File Offset: 0x005AF2E2
	private void RefreshSubTitleText(RoleSkinData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.GetSubTitle(), Array.Empty<object>());
	}

	// Token: 0x0400A6EB RID: 42731
	private RoleSkinData CurrentData;

	// Token: 0x0200906F RID: 36975
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ECDB RID: 191707
		RoleTexture,
		// Token: 0x0402ECDC RID: 191708
		TitleText,
		// Token: 0x0402ECDD RID: 191709
		SubTitleText
	}
}
