using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005749 RID: 22345
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SkillInfoItem : GridProxyAbstract<string>
	{
		// Token: 0x06038CD6 RID: 232662 RVA: 0x00D7D6D8 File Offset: 0x00D7B8D8
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

		// Token: 0x06038CD7 RID: 232663 RVA: 0x00D7D720 File Offset: 0x00D7B920
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

		// Token: 0x06038CD8 RID: 232664 RVA: 0x00D7D75B File Offset: 0x00D7B95B
		[NullableContext(1)]
		public override void Refresh(string text, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(text, true);
		}

		// Token: 0x0200B93C RID: 47420
		private enum ESkillInfoComp
		{
			// Token: 0x0403806F RID: 229487
			TextSkillInfo
		}
	}
}
