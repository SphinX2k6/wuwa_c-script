using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EA9 RID: 20137
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTokenDetailGridBottom : MediumItemGridComponent
	{
		// Token: 0x06033BBB RID: 211899 RVA: 0x00C1E928 File Offset: 0x00C1CB28
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogue";
		}

		// Token: 0x06033BBC RID: 211900 RVA: 0x00C1E92F File Offset: 0x00C1CB2F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033BBD RID: 211901 RVA: 0x00C1E968 File Offset: 0x00C1CB68
		protected override void OnActivate()
		{
			this.CommonElementItem = new RogueBattleTokenElement();
			this.CommonElementItem.CreateThenShowByActorAsync(base.GetItem(0).GetOwner());
		}

		// Token: 0x06033BBE RID: 211902 RVA: 0x00C1E990 File Offset: 0x00C1CB90
		protected override void OnRefresh(object data)
		{
			List<IRogueBattleElementInfo> tokenSortElementInfo = RogueBattleUtils.GetTokenSortElementInfo((RogueResGainData)data);
			if (tokenSortElementInfo.Count <= 0)
			{
				return;
			}
			this.CommonElementItem.Refresh(tokenSortElementInfo[0].ElementId, false, 0);
			base.GetText(1).SetText(tokenSortElementInfo[0].Count.ToString(), true);
		}

		// Token: 0x0401B7B5 RID: 112565
		[Nullable(2)]
		private RogueBattleTokenElement CommonElementItem;
	}
}
