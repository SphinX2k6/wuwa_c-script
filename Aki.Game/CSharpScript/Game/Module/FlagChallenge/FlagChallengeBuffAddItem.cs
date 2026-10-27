using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A55 RID: 23125
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeBuffAddItem : GridProxyAbstract<FlagChallengeBuffAddItemData>
	{
		// Token: 0x0603AA09 RID: 240137 RVA: 0x00DF4E94 File Offset: 0x00DF3094
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0603AA0A RID: 240138 RVA: 0x00DF4EF0 File Offset: 0x00DF30F0
		public override void Refresh(FlagChallengeBuffAddItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(data.IconPath, texture, null, null);
			base.GetText(1).ShowTextNew(data.NameKey);
			base.GetText(2).SetText(data.Value, true);
		}

		// Token: 0x0401E8F3 RID: 125171
		public FlagChallengeBuffAddItemData ItemData;
	}
}
