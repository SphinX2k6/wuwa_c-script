using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FA8 RID: 8104
[NullableContext(2)]
[Nullable(0)]
public class RoleSkinShareView : UiPanelBase
{
	// Token: 0x0601417F RID: 82303 RVA: 0x005DC010 File Offset: 0x005DA210
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

	// Token: 0x06014180 RID: 82304 RVA: 0x005DC09A File Offset: 0x005DA29A
	protected override void OnStart()
	{
		this.CurrentData = (this.OpenParam as RoleSkinData);
		this.RefreshView();
	}

	// Token: 0x06014181 RID: 82305 RVA: 0x005DC0B3 File Offset: 0x005DA2B3
	private void RefreshView()
	{
		this.RefreshRoleTexture(this.CurrentData);
		this.RefreshTitleText(this.CurrentData);
		this.RefreshSubTitleText(this.CurrentData);
	}

	// Token: 0x06014182 RID: 82306 RVA: 0x005DC0DC File Offset: 0x005DA2DC
	private void RefreshRoleTexture(RoleSkinData data)
	{
		if (data == null)
		{
			return;
		}
		string shareTexturePath = data.GetShareTexturePath();
		base.SetTextureByPath(shareTexturePath, base.GetTexture(0), null, null);
	}

	// Token: 0x06014183 RID: 82307 RVA: 0x005DC10C File Offset: 0x005DA30C
	private void RefreshTitleText(RoleSkinData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.GetTitleName(), Array.Empty<object>());
	}

	// Token: 0x06014184 RID: 82308 RVA: 0x005DC12A File Offset: 0x005DA32A
	private void RefreshSubTitleText(RoleSkinData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.GetSubTitle(), Array.Empty<object>());
	}

	// Token: 0x0400AAD5 RID: 43733
	private RoleSkinData CurrentData;

	// Token: 0x020082B6 RID: 33462
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A3D3 RID: 173011
		RoleTexture,
		// Token: 0x0402A3D4 RID: 173012
		TitleText,
		// Token: 0x0402A3D5 RID: 173013
		SubTitleText
	}
}
