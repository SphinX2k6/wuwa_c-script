using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020028D0 RID: 10448
public class RoleTagSmallIconItem : GridProxyAbstract<int>
{
	// Token: 0x0601591A RID: 88346 RVA: 0x00572725 File Offset: 0x00570925
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0601591B RID: 88347 RVA: 0x00572748 File Offset: 0x00570948
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
		UUISprite sprite = base.GetSprite(0);
		this.SetActive(false);
		this.SetSpriteByPath(roleTagConfig.Value.TagIcon, sprite, false, null, delegate(bool _)
		{
			this.SetActive(true);
		});
	}

	// Token: 0x02008EE7 RID: 36583
	private enum EComponent
	{
		// Token: 0x0402E56F RID: 189807
		TagIcon
	}
}
