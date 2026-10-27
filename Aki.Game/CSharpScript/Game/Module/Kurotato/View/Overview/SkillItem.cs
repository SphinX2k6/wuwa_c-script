using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005747 RID: 22343
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SkillItem : GridProxyAbstract<string>
	{
		// Token: 0x06038CCB RID: 232651 RVA: 0x00D7D1F0 File Offset: 0x00D7B3F0
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

		// Token: 0x06038CCC RID: 232652 RVA: 0x00D7D238 File Offset: 0x00D7B438
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

		// Token: 0x06038CCD RID: 232653 RVA: 0x00D7D273 File Offset: 0x00D7B473
		[NullableContext(1)]
		public override void Refresh(string descText, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(descText, true);
		}

		// Token: 0x0200B936 RID: 47414
		private enum ESkillComps
		{
			// Token: 0x04038057 RID: 229463
			TextName
		}
	}
}
