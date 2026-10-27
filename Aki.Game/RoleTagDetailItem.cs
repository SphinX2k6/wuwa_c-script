using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020028CD RID: 10445
public class RoleTagDetailItem : GridProxyAbstract<int>
{
	// Token: 0x0601590F RID: 88335 RVA: 0x005722CC File Offset: 0x005704CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06015910 RID: 88336 RVA: 0x00572354 File Offset: 0x00570554
	public override void Refresh(int tagId, bool isSelected, int gridIndex)
	{
		RoleTag? roleTagConfig = RoleConfig.Instance.GetRoleTagConfig(tagId);
		if (roleTagConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleTagSmallIconItem无效tagId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", tagId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		base.GetItem(0).SetUIActive(gridIndex % 2 == 0);
		base.GetItem(4).SetUIActive(gridIndex % 2 == 1);
		UUISprite sprite = base.GetSprite(1);
		this.SetSpriteByPath(roleTagConfig.Value.TagIcon, sprite, false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roleTagConfig.Value.TagName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), roleTagConfig.Value.TagDesc, Array.Empty<object>());
	}

	// Token: 0x02008EE3 RID: 36579
	private enum EComponent
	{
		// Token: 0x0402E55F RID: 189791
		BackGroundItem,
		// Token: 0x0402E560 RID: 189792
		TagIcon,
		// Token: 0x0402E561 RID: 189793
		TagName,
		// Token: 0x0402E562 RID: 189794
		TagDesc,
		// Token: 0x0402E563 RID: 189795
		BackGroundItem2
	}
}
