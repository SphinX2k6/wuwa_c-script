using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E9C RID: 20124
	[NullableContext(1)]
	[Nullable(0)]
	internal class <RogueBattleSettleInfoRoleGrid>F4C055BC0C396696E7E5BAE8054587EF69924311750C95E1C4B8449D42628F438__RogueBattleSettleInfoRoleGridLevelComponent : MediumItemGridComponent
	{
		// Token: 0x06033B96 RID: 211862 RVA: 0x00C1DF58 File Offset: 0x00C1C158
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

		// Token: 0x06033B97 RID: 211863 RVA: 0x00C1DFC8 File Offset: 0x00C1C1C8
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleInfo";
		}

		// Token: 0x06033B98 RID: 211864 RVA: 0x00C1DFD0 File Offset: 0x00C1C1D0
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
