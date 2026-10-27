using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001309 RID: 4873
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterNameItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x0600870B RID: 34571 RVA: 0x001CD2F8 File Offset: 0x001CB4F8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600870C RID: 34572 RVA: 0x001CD352 File Offset: 0x001CB552
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600870D RID: 34573 RVA: 0x001CD368 File Offset: 0x001CB568
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

	// Token: 0x0600870E RID: 34574 RVA: 0x001CD3E2 File Offset: 0x001CB5E2
	public void SetGoodItemActive(bool value)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(value);
	}

	// Token: 0x02007948 RID: 31048
	private static class EComponentDefine
	{
		// Token: 0x04027F25 RID: 163621
		public const int Name = 0;

		// Token: 0x04027F26 RID: 163622
		public const int Sprite = 1;

		// Token: 0x04027F27 RID: 163623
		public const int GoodItem = 2;
	}
}
