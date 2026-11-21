using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02004754 RID: 18260
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DesItem : SyncGridProxyAbstract<string>
	{
		// Token: 0x0602DD6A RID: 187754 RVA: 0x00CD494C File Offset: 0x00CD2B4C
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

		// Token: 0x0602DD6B RID: 187755 RVA: 0x00CD4994 File Offset: 0x00CD2B94
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

		// Token: 0x0602DD6C RID: 187756 RVA: 0x00CD49CF File Offset: 0x00CD2BCF
		[NullableContext(1)]
		public override void Refresh(string data)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200A3B0 RID: 41904
		private class EDesItemComp
		{
			// Token: 0x04032BE2 RID: 207842
			public const int TextDes = 0;
		}
	}
}
