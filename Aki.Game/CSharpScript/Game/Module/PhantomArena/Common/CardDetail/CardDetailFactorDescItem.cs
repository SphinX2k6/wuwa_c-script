using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041DE RID: 16862
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardDetailFactorDescItem : GridProxyAbstract<CardDetailFactorDescItemData>
	{
		// Token: 0x0602AA98 RID: 174744 RVA: 0x00C05B47 File Offset: 0x00C03D47
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x0602AA99 RID: 174745 RVA: 0x00C05B80 File Offset: 0x00C03D80
		public override void Refresh(CardDetailFactorDescItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			string text = "";
			PhantomBattleFactor phantomBattleFactorConfig = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(data.FactorConfigId);
			int entryId = phantomBattleFactorConfig.EntryId;
			if (entryId > 0)
			{
				text = ConfigMultiTextLang.GetLocalTextNew(PhantomArenaConfig.Instance.GetPhantomBattleEntryConfig(entryId).Name, null) + text;
			}
			string id = data.IsActive ? phantomBattleFactorConfig.Description : phantomBattleFactorConfig.DeActiveDescription;
			string[] array = data.IsActive ? phantomBattleFactorConfig.DescriptionParams() : phantomBattleFactorConfig.DeActiveDescriptionParams();
			string str = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(id, null), (string[])array.Clone());
			text += str;
			UUIText text2 = base.GetText(0);
			text2.SetText(text, true);
			text2.SetAlpha(data.IsActive ? 1f : 0.5f);
			base.GetSprite(1).SetUIActive(!data.IsActive);
		}

		// Token: 0x040171EB RID: 94699
		protected CardDetailFactorDescItemData Data;

		// Token: 0x02009DE7 RID: 40423
		[NullableContext(0)]
		private static class EDescItemComponents
		{
			// Token: 0x040311A7 RID: 201127
			public const int DescText = 0;

			// Token: 0x040311A8 RID: 201128
			public const int BgSprite = 1;
		}
	}
}
