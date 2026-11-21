using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E65 RID: 15973
	[NullableContext(1)]
	[Nullable(0)]
	internal class <RogueBattleSettleInfoRoleGrid>F4C055BC0C396696E7E5BAE8054587EF69924311750C95E1C4B8449D42628F438__RogueBattleSettleInfoRoleGridLevelComponent : MediumItemGridComponent
	{
		// Token: 0x06028A01 RID: 166401 RVA: 0x00B67474 File Offset: 0x00B65674
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06028A02 RID: 166402 RVA: 0x00B674E4 File Offset: 0x00B656E4
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleInfo";
		}

		// Token: 0x06028A03 RID: 166403 RVA: 0x00B674EC File Offset: 0x00B656EC
		protected override void OnRefresh(object data)
		{
			RogueResGainData rogueResGainData = (RogueResGainData)data;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(string.Empty, true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(rogueResGainData.RogueResRole.Level.ToString(), true);
		}
	}
}
