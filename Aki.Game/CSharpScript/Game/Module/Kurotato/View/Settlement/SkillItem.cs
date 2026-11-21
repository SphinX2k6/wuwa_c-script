using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004709 RID: 18185
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkillItem : GridProxyAbstract<string>
	{
		// Token: 0x0602DB09 RID: 187145 RVA: 0x00CC6BE8 File Offset: 0x00CC4DE8
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

		// Token: 0x0602DB0A RID: 187146 RVA: 0x00CC6C30 File Offset: 0x00CC4E30
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

		// Token: 0x0602DB0B RID: 187147 RVA: 0x00CC6C6B File Offset: 0x00CC4E6B
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200A325 RID: 41765
		private class ESkillComps
		{
			// Token: 0x04032966 RID: 207206
			public const int TextDes = 0;
		}
	}
}
