using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002799 RID: 10137
public class RolePropertyDetailItem : GridProxyAbstract<int>
{
	// Token: 0x06014D08 RID: 85256 RVA: 0x00547F84 File Offset: 0x00546184
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

	// Token: 0x06014D09 RID: 85257 RVA: 0x00547FF0 File Offset: 0x005461F0
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

	// Token: 0x02008E0C RID: 36364
	private enum EPropertyDetailComponent
	{
		// Token: 0x0402E172 RID: 188786
		AttrIcon,
		// Token: 0x0402E173 RID: 188787
		AttrTxt
	}
}
