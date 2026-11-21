using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E48 RID: 7752
public class RoleTagDetailItem : GridProxyAbstract<int>
{
	// Token: 0x0601330F RID: 78607 RVA: 0x0059D184 File Offset: 0x0059B384
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

	// Token: 0x06013310 RID: 78608 RVA: 0x0059D20C File Offset: 0x0059B40C
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

	// Token: 0x0200812B RID: 33067
	private enum EComponent
	{
		// Token: 0x04029C5A RID: 171098
		BackGroundItem,
		// Token: 0x04029C5B RID: 171099
		TagIcon,
		// Token: 0x04029C5C RID: 171100
		TagName,
		// Token: 0x04029C5D RID: 171101
		TagDesc,
		// Token: 0x04029C5E RID: 171102
		BackGroundItem2
	}
}
