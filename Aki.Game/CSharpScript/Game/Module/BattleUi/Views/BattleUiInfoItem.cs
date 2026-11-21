using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D76 RID: 19830
	public class BattleUiInfoItem : UiPanelBase
	{
		// Token: 0x06031C20 RID: 203808 RVA: 0x00DE9C34 File Offset: 0x00DE7E34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031C21 RID: 203809 RVA: 0x00DE9CC0 File Offset: 0x00DE7EC0
		protected override UniTask OnBeforeStartAsync()
		{
			BattleUiInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleUiInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C22 RID: 203810 RVA: 0x00DE9D03 File Offset: 0x00DE7F03
		[NullableContext(1)]
		private static BattleUiDescInfoItem CreateItem()
		{
			return new BattleUiDescInfoItem();
		}

		// Token: 0x06031C23 RID: 203811 RVA: 0x00DE9D0C File Offset: 0x00DE7F0C
		[NullableContext(1)]
		public void Refresh(IBattleUiHoverTipsC info)
		{
			this.ContentLayout.RefreshByData(info.DescInfoList, null, false);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(!string.IsNullOrEmpty(info.TitleKey));
			}
			if (!string.IsNullOrEmpty(info.TitleKey))
			{
				LguiUtil.Instance.SetLocalTextNew(text, info.TitleKey, Array.Empty<object>());
			}
		}

		// Token: 0x0401A579 RID: 107897
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BattleUiDescInfoItem, IBattleUiHoverTipsDescInfoC> ContentLayout;

		// Token: 0x0200AA57 RID: 43607
		private enum EItemChildType
		{
			// Token: 0x04034A5B RID: 215643
			TxtTitle,
			// Token: 0x04034A5C RID: 215644
			ItemDescInfo,
			// Token: 0x04034A5D RID: 215645
			LayoutContent
		}

		// Token: 0x0200AA58 RID: 43608
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034A5E RID: 215646
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<BattleUiDescInfoItem> <0>__CreateItem;
		}
	}
}
