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
	// Token: 0x02005AAF RID: 23215
	public class DreamLinkWhiteCatSettlePanel : UiPanelBase
	{
		// Token: 0x0603ACEA RID: 240874 RVA: 0x00E032B8 File Offset: 0x00E014B8
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

		// Token: 0x0603ACEB RID: 240875 RVA: 0x00E03324 File Offset: 0x00E01524
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatSettlePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatSettlePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ACEC RID: 240876 RVA: 0x00E03367 File Offset: 0x00E01567
		[NullableContext(1)]
		protected DreamLinkWhiteCatSettleItem OnCreateItem()
		{
			return new DreamLinkWhiteCatSettleItem();
		}

		// Token: 0x0401EB0D RID: 125709
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DreamLinkWhiteCatSettleItem, IDreamLinkReachedData> Layout;

		// Token: 0x0401EB0E RID: 125710
		[Nullable(2)]
		protected DreamLinkWhiteCatSettleRecordItem RecordPanel;

		// Token: 0x0401EB0F RID: 125711
		[Nullable(2)]
		public RogueBossLinkSettleNotify Data;

		// Token: 0x0200BD02 RID: 48386
		private class EChildType
		{
			// Token: 0x04038FFF RID: 233471
			public const int BarVerticalItem = 0;

			// Token: 0x04039000 RID: 233472
			public const int RecordItem = 1;
		}
	}
}
