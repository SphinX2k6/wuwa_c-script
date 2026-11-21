using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004720 RID: 18208
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SkillInfoItem : GridProxyAbstract<string>
	{
		// Token: 0x0602DBE6 RID: 187366 RVA: 0x00CCBF94 File Offset: 0x00CCA194
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

		// Token: 0x0602DBE7 RID: 187367 RVA: 0x00CCBFDC File Offset: 0x00CCA1DC
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

		// Token: 0x0602DBE8 RID: 187368 RVA: 0x00CCC017 File Offset: 0x00CCA217
		[NullableContext(1)]
		public override void Refresh(string text, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(text, true);
		}

		// Token: 0x0200A35B RID: 41819
		private enum ESkillInfoComp
		{
			// Token: 0x04032A79 RID: 207481
			TextSkillInfo
		}
	}
}
