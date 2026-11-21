using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E72 RID: 15986
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleTokenDetailGridBottom : MediumItemGridComponent
	{
		// Token: 0x06028A26 RID: 166438 RVA: 0x00B67E40 File Offset: 0x00B66040
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogue";
		}

		// Token: 0x06028A27 RID: 166439 RVA: 0x00B67E47 File Offset: 0x00B66047
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06028A28 RID: 166440 RVA: 0x00B67E80 File Offset: 0x00B66080
		protected override void OnActivate()
		{
			this.CommonElementItem = new RogueBattleTokenElement();
			this.CommonElementItem.CreateThenShowByActorAsync(base.GetItem(0).GetOwner());
		}

		// Token: 0x06028A29 RID: 166441 RVA: 0x00B67EA8 File Offset: 0x00B660A8
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

		// Token: 0x04016188 RID: 90504
		[Nullable(2)]
		private RogueBattleTokenElement CommonElementItem;
	}
}
