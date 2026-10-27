using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200520E RID: 21006
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardDetailFactorDescItem : GridProxyAbstract<CardDetailFactorDescItemData>
	{
		// Token: 0x06035B9D RID: 220061 RVA: 0x00CB850B File Offset: 0x00CB670B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06035B9E RID: 220062 RVA: 0x00CB8544 File Offset: 0x00CB6744
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
			string[] source = data.IsActive ? phantomBattleFactorConfig.DescriptionParams() : phantomBattleFactorConfig.DeActiveDescriptionParams();
			string str = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(id, null), source.ToArray<string>());
			text += str;
			UUIText text2 = base.GetText(0);
			text2.SetText(text, true);
			text2.SetAlpha(data.IsActive ? 1f : 0.5f);
			base.GetSprite(1).SetUIActive(!data.IsActive);
		}

		// Token: 0x0401C7B6 RID: 116662
		protected CardDetailFactorDescItemData Data;

		// Token: 0x0200B3AF RID: 45999
		[NullableContext(0)]
		private static class EDescItemComponents
		{
			// Token: 0x04036754 RID: 223060
			public const int DescText = 0;

			// Token: 0x04036755 RID: 223061
			public const int BgSprite = 1;
		}
	}
}
