using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A31 RID: 18993
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeBuffAddItem : GridProxyAbstract<FlagChallengeBuffAddItemData>
	{
		// Token: 0x0602F952 RID: 194898 RVA: 0x00D45418 File Offset: 0x00D43618
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602F953 RID: 194899 RVA: 0x00D45474 File Offset: 0x00D43674
		public override void Refresh(FlagChallengeBuffAddItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(0);
			base.SetTextureByPath(data.IconPath, texture, null, null);
			base.GetText(1).ShowTextNew(data.NameKey);
			base.GetText(2).SetText(data.Value, true);
		}

		// Token: 0x0401939A RID: 103322
		public FlagChallengeBuffAddItemData ItemData;
	}
}
