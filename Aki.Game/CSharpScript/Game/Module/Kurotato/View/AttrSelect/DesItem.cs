using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200577D RID: 22397
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DesItem : SyncGridProxyAbstract<string>
	{
		// Token: 0x06038E5A RID: 233050 RVA: 0x00D85C8C File Offset: 0x00D83E8C
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

		// Token: 0x06038E5B RID: 233051 RVA: 0x00D85CD4 File Offset: 0x00D83ED4
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

		// Token: 0x06038E5C RID: 233052 RVA: 0x00D85D0F File Offset: 0x00D83F0F
		[NullableContext(1)]
		public override void Refresh(string data)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200B998 RID: 47512
		private class EDesItemComp
		{
			// Token: 0x040381ED RID: 229869
			public const int TextDes = 0;
		}
	}
}
