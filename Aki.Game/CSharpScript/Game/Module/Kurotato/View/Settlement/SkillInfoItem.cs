using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005724 RID: 22308
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkillInfoItem : GridProxyAbstract<string>
	{
		// Token: 0x06038B87 RID: 232327 RVA: 0x00D75C0C File Offset: 0x00D73E0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038B88 RID: 232328 RVA: 0x00D75C54 File Offset: 0x00D73E54
		protected override void OnStart()
		{
			TermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(0),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Kurotato
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x06038B89 RID: 232329 RVA: 0x00D75C8F File Offset: 0x00D73E8F
		[NullableContext(1)]
		public override void Refresh(string text, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(text, true);
		}

		// Token: 0x0200B8E0 RID: 47328
		private class ESkillInfoComp
		{
			// Token: 0x04037ECA RID: 229066
			public const int TextSkillInfo = 0;
		}
	}
}
