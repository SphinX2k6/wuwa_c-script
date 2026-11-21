using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005769 RID: 22377
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DangoBrawlItemTipsDescItem : GridProxyAbstract<DangoBrawlItemTipsDescData>
	{
		// Token: 0x06037321 RID: 226081 RVA: 0x00F68CF0 File Offset: 0x00F66EF0
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

		// Token: 0x06037322 RID: 226082 RVA: 0x00F68D38 File Offset: 0x00F66F38
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(0));
		}

		// Token: 0x06037323 RID: 226083 RVA: 0x00F68D4C File Offset: 0x00F66F4C
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(0));
		}

		// Token: 0x06037324 RID: 226084 RVA: 0x00F68D5F File Offset: 0x00F66F5F
		[NullableContext(1)]
		public override void Refresh(DangoBrawlItemTipsDescData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.DescParams);
		}

		// Token: 0x0200B378 RID: 45944
		private enum EDescComponent
		{
			// Token: 0x04037790 RID: 227216
			TxtDesc
		}
	}
}
