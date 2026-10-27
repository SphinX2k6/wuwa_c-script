using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020028CF RID: 10447
public class RoleTagMediumIconItem : GridProxyAbstract<int>
{
	// Token: 0x06015917 RID: 88343 RVA: 0x005725BC File Offset: 0x005707BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06015918 RID: 88344 RVA: 0x00572618 File Offset: 0x00570818
	public override void Refresh(int tagId, bool isSelected, int gridIndex)
	{
		RoleTag? roleTagConfig = RoleConfig.Instance.GetRoleTagConfig(tagId);
		if (roleTagConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleTagMediumIconItem无效tagId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", tagId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUISprite sprite = base.GetSprite(2);
		UUIText text = base.GetText(1);
		UUISprite sprite2 = sprite;
		if (sprite2 != null)
		{
			sprite2.SetUIActive(false);
		}
		this.SetSpriteByPath(roleTagConfig.Value.TagIcon, sprite, false, null, delegate(bool _)
		{
			sprite.SetUIActive(true);
		});
		LguiUtil.Instance.SetLocalTextNew(text, roleTagConfig.Value.TagName, Array.Empty<object>());
		FColor color = FColor.FromHex(roleTagConfig.Value.TagNameColor);
		base.GetSprite(0).SetColor(color);
		sprite.SetColor(color);
		text.SetColor(color);
	}

	// Token: 0x02008EE5 RID: 36581
	private enum EComponent
	{
		// Token: 0x0402E56A RID: 189802
		TagBg,
		// Token: 0x0402E56B RID: 189803
		TagName,
		// Token: 0x0402E56C RID: 189804
		TagIcon
	}
}
