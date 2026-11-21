using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007BD RID: 1981
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterNameItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005AA6 RID: 23206 RVA: 0x001D6164 File Offset: 0x001D4364
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06005AA7 RID: 23207 RVA: 0x001D61BE File Offset: 0x001D43BE
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06005AA8 RID: 23208 RVA: 0x001D61D4 File Offset: 0x001D43D4
	[NullableContext(1)]
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		Character characterConfig = BusinessConfig.Instance.GetCharacterConfig(data.Id);
		if (data.UseScoreName)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), characterConfig.ScoreName, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), characterConfig.Name, Array.Empty<object>());
		}
		base.GetSprite(1).SetColor(FColor.FromHex(characterConfig.Color));
	}

	// Token: 0x06005AA9 RID: 23209 RVA: 0x001D624E File Offset: 0x001D444E
	public void SetGoodItemActive(bool value)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x02006AD2 RID: 27346
	private static class EComponentDefine
	{
		// Token: 0x04023252 RID: 143954
		public const int Name = 0;

		// Token: 0x04023253 RID: 143955
		public const int Sprite = 1;

		// Token: 0x04023254 RID: 143956
		public const int GoodItem = 2;
	}
}
