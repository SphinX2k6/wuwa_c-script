using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020007BE RID: 1982
public class CharacterNameWithBg : GridProxyAbstract<int>
{
	// Token: 0x06005AAB RID: 23211 RVA: 0x001D626A File Offset: 0x001D446A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06005AAC RID: 23212 RVA: 0x001D62A4 File Offset: 0x001D44A4
	public override void Refresh(int characterId, bool isSelected, int gridIndex)
	{
		Character characterConfig = BusinessConfig.Instance.GetCharacterConfig(characterId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), characterConfig.Name, Array.Empty<object>());
		base.GetSprite(0).SetColor(FColor.FromHex(characterConfig.Color));
	}

	// Token: 0x02006AD3 RID: 27347
	private static class EComponentDefine
	{
		// Token: 0x04023255 RID: 143957
		public const int Sprite = 0;

		// Token: 0x04023256 RID: 143958
		public const int Name = 1;
	}
}
