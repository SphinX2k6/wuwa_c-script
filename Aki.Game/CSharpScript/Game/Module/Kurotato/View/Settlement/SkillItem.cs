using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005732 RID: 22322
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class SkillItem : GridProxyAbstract<string>
	{
		// Token: 0x06038BF9 RID: 232441 RVA: 0x00D7853C File Offset: 0x00D7673C
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

		// Token: 0x06038BFA RID: 232442 RVA: 0x00D78584 File Offset: 0x00D76784
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

		// Token: 0x06038BFB RID: 232443 RVA: 0x00D785BF File Offset: 0x00D767BF
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200B904 RID: 47364
		private class ESkillComps
		{
			// Token: 0x04037F56 RID: 229206
			public const int TextDes = 0;
		}
	}
}
