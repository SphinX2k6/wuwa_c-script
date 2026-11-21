using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005590 RID: 21904
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingHandBookDesItem : GridProxyAbstract<IFishingHandBookDesData>
	{
		// Token: 0x06036481 RID: 222337 RVA: 0x00F2369C File Offset: 0x00F2189C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036482 RID: 222338 RVA: 0x00F23748 File Offset: 0x00F21948
		[NullableContext(1)]
		public override void Refresh(IFishingHandBookDesData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DesText, Array.Empty<object>());
			base.GetText(1).SetText(data.DataText, true);
			base.GetItem(2).SetUIActive(data.IsGolden.GetValueOrDefault());
			base.GetItem(3).SetUIActive(data.IsSliver.GetValueOrDefault());
		}

		// Token: 0x0200B204 RID: 45572
		private class EComponentDefine
		{
			// Token: 0x0403705A RID: 225370
			public const int DesText = 0;

			// Token: 0x0403705B RID: 225371
			public const int DataText = 1;

			// Token: 0x0403705C RID: 225372
			public const int GoldenItem = 2;

			// Token: 0x0403705D RID: 225373
			public const int SilverItem = 3;
		}
	}
}
