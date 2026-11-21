using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E4A RID: 7754
public class RoleTagMediumIconItem : GridProxyAbstract<int>
{
	// Token: 0x06013317 RID: 78615 RVA: 0x0059D474 File Offset: 0x0059B674
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06013318 RID: 78616 RVA: 0x0059D4D0 File Offset: 0x0059B6D0
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

	// Token: 0x0200812D RID: 33069
	private enum EComponent
	{
		// Token: 0x04029C65 RID: 171109
		TagBg,
		// Token: 0x04029C66 RID: 171110
		TagName,
		// Token: 0x04029C67 RID: 171111
		TagIcon
	}
}
