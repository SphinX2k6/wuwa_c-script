using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A8B RID: 19083
	public class DreamLinkWhiteCatSettlePanel : UiPanelBase
	{
		// Token: 0x0602FC36 RID: 195638 RVA: 0x00D53880 File Offset: 0x00D51A80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FC37 RID: 195639 RVA: 0x00D538EC File Offset: 0x00D51AEC
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatSettlePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettlePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC38 RID: 195640 RVA: 0x00D5392F File Offset: 0x00D51B2F
		[NullableContext(1)]
		protected DreamLinkWhiteCatSettleItem OnCreateItem()
		{
			return new DreamLinkWhiteCatSettleItem();
		}

		// Token: 0x040195B4 RID: 103860
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DreamLinkWhiteCatSettleItem, IDreamLinkReachedData> Layout;

		// Token: 0x040195B5 RID: 103861
		[Nullable(2)]
		protected DreamLinkWhiteCatSettleRecordItem RecordPanel;

		// Token: 0x040195B6 RID: 103862
		[Nullable(2)]
		public RogueBossLinkSettleNotify Data;

		// Token: 0x0200A70A RID: 42762
		private class EChildType
		{
			// Token: 0x040339C9 RID: 211401
			public const int BarVerticalItem = 0;

			// Token: 0x040339CA RID: 211402
			public const int RecordItem = 1;
		}
	}
}
