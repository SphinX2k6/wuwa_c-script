using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200520B RID: 21003
	public class CardDetailEntryDescItem : GridProxyAbstract<int>
	{
		// Token: 0x06035B95 RID: 220053 RVA: 0x00CB839F File Offset: 0x00CB659F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035B96 RID: 220054 RVA: 0x00CB83D8 File Offset: 0x00CB65D8
		public override void Refresh(int entryId, bool isSelected, int gridIndex)
		{
			PhantomBattleEntry phantomBattleEntryConfig = PhantomArenaConfig.Instance.GetPhantomBattleEntryConfig(entryId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phantomBattleEntryConfig.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomBattleEntryConfig.Description, Array.Empty<object>());
		}

		// Token: 0x0200B3AE RID: 45998
		private static class EComponents
		{
			// Token: 0x04036752 RID: 223058
			public const int NameText = 0;

			// Token: 0x04036753 RID: 223059
			public const int DescText = 1;
		}
	}
}
