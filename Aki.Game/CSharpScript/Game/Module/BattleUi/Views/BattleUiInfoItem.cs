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
	// Token: 0x02005D94 RID: 23956
	public class BattleUiInfoItem : UiPanelBase
	{
		// Token: 0x0603CCC3 RID: 249027 RVA: 0x00E9937C File Offset: 0x00E9757C
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

		// Token: 0x0603CCC4 RID: 249028 RVA: 0x00E99408 File Offset: 0x00E97608
		protected override UniTask OnBeforeStartAsync()
		{
			BattleUiInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleUiInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CCC5 RID: 249029 RVA: 0x00E9944B File Offset: 0x00E9764B
		[NullableContext(1)]
		private static BattleUiDescInfoItem CreateItem()
		{
			return new BattleUiDescInfoItem();
		}

		// Token: 0x0603CCC6 RID: 249030 RVA: 0x00E99454 File Offset: 0x00E97654
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

		// Token: 0x0401FAC1 RID: 129729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<BattleUiDescInfoItem, IBattleUiHoverTipsDescInfoC> ContentLayout;

		// Token: 0x0200C051 RID: 49233
		private enum EItemChildType
		{
			// Token: 0x0403A098 RID: 237720
			TxtTitle,
			// Token: 0x0403A099 RID: 237721
			ItemDescInfo,
			// Token: 0x0403A09A RID: 237722
			LayoutContent
		}

		// Token: 0x0200C052 RID: 49234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403A09B RID: 237723
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<BattleUiDescInfoItem> <0>__CreateItem;
		}
	}
}
