using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006819 RID: 26649
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlItemTipsDescItem : GridProxyAbstract<DangoBrawlItemTipsDescData>
	{
		// Token: 0x060427CC RID: 272332 RVA: 0x010277AC File Offset: 0x010259AC
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

		// Token: 0x060427CD RID: 272333 RVA: 0x010277F4 File Offset: 0x010259F4
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(0));
		}

		// Token: 0x060427CE RID: 272334 RVA: 0x01027808 File Offset: 0x01025A08
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(0));
		}

		// Token: 0x060427CF RID: 272335 RVA: 0x0102781B File Offset: 0x01025A1B
		[NullableContext(1)]
		public override void Refresh(DangoBrawlItemTipsDescData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.DescParams);
		}

		// Token: 0x0200C9AB RID: 51627
		private enum EDescComponent
		{
			// Token: 0x0403CEA3 RID: 249507
			TxtDesc
		}
	}
}
