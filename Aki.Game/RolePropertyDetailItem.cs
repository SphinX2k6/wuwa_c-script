using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C84 RID: 7300
public class RolePropertyDetailItem : GridProxyAbstract<int>
{
	// Token: 0x060121F4 RID: 74228 RVA: 0x005570A8 File Offset: 0x005552A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060121F5 RID: 74229 RVA: 0x00557114 File Offset: 0x00555314
	public override void Refresh(int tagId, bool isSelected, int gridIndex)
	{
		RoleTag? roleTagConfig = RoleConfig.Instance.GetRoleTagConfig(tagId);
		if (roleTagConfig == null)
		{
			return;
		}
		UUISprite attrIcon = base.GetSprite(0);
		this.SetSpriteByPath(roleTagConfig.Value.TagIcon, attrIcon, false, null, delegate(bool success)
		{
			if (!success)
			{
				return;
			}
			AActor owner = attrIcon.GetOwner();
			UUISpriteTransition uuispriteTransition = ((owner != null) ? owner.GetComponentByClass(UUISpriteTransition.StaticClass()) : null) as UUISpriteTransition;
			if (uuispriteTransition == null)
			{
				return;
			}
			uuispriteTransition.SetAllTransitionSprite(attrIcon.GetSprite());
		});
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleTagConfig.Value.TagName, Array.Empty<object>());
	}

	// Token: 0x02007F93 RID: 32659
	private enum EPropertyDetailComponent
	{
		// Token: 0x04029485 RID: 169093
		AttrIcon,
		// Token: 0x04029486 RID: 169094
		AttrTxt
	}
}
