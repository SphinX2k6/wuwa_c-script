using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200130A RID: 4874
public class CharacterNameWithBg : GridProxyAbstract<int>
{
	// Token: 0x06008710 RID: 34576 RVA: 0x001CD3FE File Offset: 0x001CB5FE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06008711 RID: 34577 RVA: 0x001CD438 File Offset: 0x001CB638
	public override void Refresh(int characterId, bool isSelected, int gridIndex)
	{
		Character characterConfig = BusinessConfig.Instance.GetCharacterConfig(characterId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), characterConfig.Name, Array.Empty<object>());
		base.GetSprite(0).SetColor(FColor.FromHex(characterConfig.Color));
	}

	// Token: 0x02007949 RID: 31049
	private static class EComponentDefine
	{
		// Token: 0x04027F28 RID: 163624
		public const int Sprite = 0;

		// Token: 0x04027F29 RID: 163625
		public const int Name = 1;
	}
}
