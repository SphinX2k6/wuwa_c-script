using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x020046FB RID: 18171
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkillInfoItem : GridProxyAbstract<string>
	{
		// Token: 0x0602DA96 RID: 187030 RVA: 0x00CC4240 File Offset: 0x00CC2440
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

		// Token: 0x0602DA97 RID: 187031 RVA: 0x00CC4288 File Offset: 0x00CC2488
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

		// Token: 0x0602DA98 RID: 187032 RVA: 0x00CC42C3 File Offset: 0x00CC24C3
		[NullableContext(1)]
		public override void Refresh(string text, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(text, true);
		}

		// Token: 0x0200A302 RID: 41730
		private class ESkillInfoComp
		{
			// Token: 0x040328DC RID: 207068
			public const int TextSkillInfo = 0;
		}
	}
}
