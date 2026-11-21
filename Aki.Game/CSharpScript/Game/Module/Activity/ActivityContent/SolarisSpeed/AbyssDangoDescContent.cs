using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005045 RID: 20549
	[NullableContext(1)]
	[Nullable(0)]
	internal class AbyssDangoDescContent : UiPanelBase
	{
		// Token: 0x06033705 RID: 210693 RVA: 0x00E678D4 File Offset: 0x00E65AD4
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

		// Token: 0x06033706 RID: 210694 RVA: 0x00E6795E File Offset: 0x00E65B5E
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<AbyssDangoDescItem, IAbyssDescData>(base.GetScrollViewWithScrollbar(1), new Func<AbyssDangoDescItem>(this.InitScrollItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x06033707 RID: 210695 RVA: 0x00E67991 File Offset: 0x00E65B91
		private AbyssDangoDescItem InitScrollItem()
		{
			return new AbyssDangoDescItem();
		}

		// Token: 0x06033708 RID: 210696 RVA: 0x00E67998 File Offset: 0x00E65B98
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

		// Token: 0x06033709 RID: 210697 RVA: 0x00E679DC File Offset: 0x00E65BDC
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
				int[] array = new int[count];
				abyssSettleById.Value.Title().Keys.CopyTo(array, 0);
				int key = array[num];
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

		// Token: 0x0401B52F RID: 111919
		protected GenericScrollViewNew<AbyssDangoDescItem, IAbyssDescData> Scroll;

		// Token: 0x0200ACFC RID: 44284
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x040357DD RID: 219101
			Title,
			// Token: 0x040357DE RID: 219102
			DescScroll,
			// Token: 0x040357DF RID: 219103
			DescItem
		}
	}
}
