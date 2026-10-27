using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060C7 RID: 24775
	[NullableContext(1)]
	[Nullable(0)]
	internal class AbyssDangoDescContent : UiPanelBase
	{
		// Token: 0x0603EA41 RID: 256577 RVA: 0x00F20B10 File Offset: 0x00F1ED10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EA42 RID: 256578 RVA: 0x00F20B9A File Offset: 0x00F1ED9A
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<AbyssDangoDescItem, IAbyssDescData>(base.GetScrollViewWithScrollbar(1), new Func<AbyssDangoDescItem>(this.InitScrollItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603EA43 RID: 256579 RVA: 0x00F20BCD File Offset: 0x00F1EDCD
		private AbyssDangoDescItem InitScrollItem()
		{
			return new AbyssDangoDescItem();
		}

		// Token: 0x0603EA44 RID: 256580 RVA: 0x00F20BD4 File Offset: 0x00F1EDD4
		private void RefreshDescLayout(List<IAbyssDescData> data)
		{
			AbyssDangoDescContent.<>c__DisplayClass5_0 CS$<>8__locals1 = new AbyssDangoDescContent.<>c__DisplayClass5_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("AbyssDangoDescContent.Refresh", delegate()
			{
				AbyssDangoDescContent.<>c__DisplayClass5_0.<<RefreshDescLayout>b__0>d <<RefreshDescLayout>b__0>d;
				<<RefreshDescLayout>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshDescLayout>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshDescLayout>b__0>d.<>1__state = -1;
				<<RefreshDescLayout>b__0>d.<>t__builder.Start<AbyssDangoDescContent.<>c__DisplayClass5_0.<<RefreshDescLayout>b__0>d>(ref <<RefreshDescLayout>b__0>d);
				return <<RefreshDescLayout>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603EA45 RID: 256581 RVA: 0x00F20C18 File Offset: 0x00F1EE18
		public void Refresh(IAbyssRolePanelData data)
		{
			List<IAbyssDescData> mainDescData = data.MainDescData;
			if (mainDescData.Count > 0)
			{
				int mainHonorRank = DangoAbyssModel.Instance.GetMainHonorRank(mainDescData, true);
				IAbyssDescData abyssDescData = mainDescData[0];
				AbyssSettle? abyssSettleById = DangoAbyssConfig.Instance.GetAbyssSettleById(abyssDescData.Id);
				int count = abyssSettleById.Value.Title().Count;
				int num = (mainHonorRank >= count - 1) ? (count - 1) : mainHonorRank;
				int key = abyssSettleById.Value.Title().Keys.ToArray<int>()[num];
				string text;
				string textStringId;
				if (abyssSettleById.Value.Title().TryGetValue(key, out text))
				{
					textStringId = (text ?? "");
				}
				else
				{
					textStringId = "";
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textStringId, Array.Empty<object>());
			}
			this.RefreshDescLayout(data.SubDescData);
		}

		// Token: 0x04020C02 RID: 134146
		protected GenericScrollViewNew<AbyssDangoDescItem, IAbyssDescData> Scroll;

		// Token: 0x0200C311 RID: 49937
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0403AE75 RID: 241269
			Title,
			// Token: 0x0403AE76 RID: 241270
			DescScroll,
			// Token: 0x0403AE77 RID: 241271
			DescItem
		}
	}
}
