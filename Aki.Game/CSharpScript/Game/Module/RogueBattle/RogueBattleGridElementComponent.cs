using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E6C RID: 15980
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleGridElementComponent : MediumItemGridComponent
	{
		// Token: 0x06028A18 RID: 166424 RVA: 0x00B67BDD File Offset: 0x00B65DDD
		protected override string GetResourceId()
		{
			return "UiItem_ItemRogueElement";
		}

		// Token: 0x06028A19 RID: 166425 RVA: 0x00B67BE4 File Offset: 0x00B65DE4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout))
			};
		}

		// Token: 0x06028A1A RID: 166426 RVA: 0x00B67C07 File Offset: 0x00B65E07
		protected override void OnActivate()
		{
			this.GenericLayout = new GenericLayout<RogueBattleTokenElement, int>(base.GetVerticalLayout(0), new Func<RogueBattleTokenElement>(this.CreateElement), null, false, true);
		}

		// Token: 0x06028A1B RID: 166427 RVA: 0x00B67C2A File Offset: 0x00B65E2A
		private RogueBattleTokenElement CreateElement()
		{
			return new RogueBattleTokenElement();
		}

		// Token: 0x06028A1C RID: 166428 RVA: 0x00B67C34 File Offset: 0x00B65E34
		protected override void OnRefresh(object data)
		{
			int[] tokenSortElementInfoByCount = RogueBattleUtils.GetTokenSortElementInfoByCount((RogueResGainData)data);
			GenericLayout<RogueBattleTokenElement, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByData(tokenSortElementInfoByCount, null, false);
		}

		// Token: 0x0401617F RID: 90495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RogueBattleTokenElement, int> GenericLayout;
	}
}
