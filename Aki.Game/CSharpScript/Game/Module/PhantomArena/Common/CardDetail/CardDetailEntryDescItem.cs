using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041DB RID: 16859
	public class CardDetailEntryDescItem : GridProxyAbstract<int>
	{
		// Token: 0x0602AA90 RID: 174736 RVA: 0x00C059DB File Offset: 0x00C03BDB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AA91 RID: 174737 RVA: 0x00C05A14 File Offset: 0x00C03C14
		public override void Refresh(int entryId, bool isSelected, int gridIndex)
		{
			PhantomBattleEntry phantomBattleEntryConfig = PhantomArenaConfig.Instance.GetPhantomBattleEntryConfig(entryId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phantomBattleEntryConfig.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomBattleEntryConfig.Description, Array.Empty<object>());
		}

		// Token: 0x02009DE6 RID: 40422
		private static class EComponents
		{
			// Token: 0x040311A5 RID: 201125
			public const int NameText = 0;

			// Token: 0x040311A6 RID: 201126
			public const int DescText = 1;
		}
	}
}
