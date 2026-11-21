using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200471E RID: 18206
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SkillItem : GridProxyAbstract<string>
	{
		// Token: 0x0602DBDB RID: 187355 RVA: 0x00CCBAAC File Offset: 0x00CC9CAC
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

		// Token: 0x0602DBDC RID: 187356 RVA: 0x00CCBAF4 File Offset: 0x00CC9CF4
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

		// Token: 0x0602DBDD RID: 187357 RVA: 0x00CCBB2F File Offset: 0x00CC9D2F
		[NullableContext(1)]
		public override void Refresh(string descText, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(descText, true);
		}

		// Token: 0x0200A355 RID: 41813
		private enum ESkillComps
		{
			// Token: 0x04032A61 RID: 207457
			TextName
		}
	}
}
