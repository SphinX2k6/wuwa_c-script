using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EA3 RID: 20131
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleGridElementComponent : MediumItemGridComponent
	{
		// Token: 0x06033BAD RID: 211885 RVA: 0x00C1E6C1 File Offset: 0x00C1C8C1
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueElement";
		}

		// Token: 0x06033BAE RID: 211886 RVA: 0x00C1E6C8 File Offset: 0x00C1C8C8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout))
			};
		}

		// Token: 0x06033BAF RID: 211887 RVA: 0x00C1E6EB File Offset: 0x00C1C8EB
		protected override void OnActivate()
		{
			this.GenericLayout = new GenericLayout<RogueBattleTokenElement, int>(base.GetVerticalLayout(0), new Func<RogueBattleTokenElement>(this.CreateElement), null, false, true);
		}

		// Token: 0x06033BB0 RID: 211888 RVA: 0x00C1E70E File Offset: 0x00C1C90E
		private RogueBattleTokenElement CreateElement()
		{
			return new RogueBattleTokenElement();
		}

		// Token: 0x06033BB1 RID: 211889 RVA: 0x00C1E718 File Offset: 0x00C1C918
		protected override void OnRefresh(object data)
		{
			int[] tokenSortElementInfoByCount = RogueBattleUtils.GetTokenSortElementInfoByCount((RogueResGainData)data);
			GenericLayout<RogueBattleTokenElement, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByData(tokenSortElementInfoByCount.ToList<int>(), null, false);
		}

		// Token: 0x0401B7AC RID: 112556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleTokenElement, int> GenericLayout;
	}
}
