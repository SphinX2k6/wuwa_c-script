using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200505B RID: 20571
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewDynamicScrollItem : UiPanelBase, IDynamicScrollItem<PlotReviewItemData>
	{
		// Token: 0x06034A41 RID: 215617 RVA: 0x00C70744 File Offset: 0x00C6E944
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034A42 RID: 215618 RVA: 0x00C707B0 File Offset: 0x00C6E9B0
		public UniTask Init(UUIItem actor)
		{
			PlotReviewDynamicScrollItem.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<PlotReviewDynamicScrollItem.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06034A43 RID: 215619 RVA: 0x00C707FC File Offset: 0x00C6E9FC
		private UniTask InitChildItem()
		{
			PlotReviewDynamicScrollItem.<InitChildItem>d__7 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<PlotReviewDynamicScrollItem.<InitChildItem>d__7>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x06034A44 RID: 215620 RVA: 0x00C70840 File Offset: 0x00C6EA40
		public AUIBaseActor GetUsingItem(PlotReviewItemData data)
		{
			int? num = null;
			EPlotReviewItemType type = data.Type;
			if (type != EPlotReviewItemType.Talk)
			{
				if (type == EPlotReviewItemType.Option)
				{
					num = new int?(1);
				}
			}
			else
			{
				num = new int?(0);
			}
			return base.GetItem(num.GetValueOrDefault()).GetOwner() as AUIBaseActor;
		}

		// Token: 0x06034A45 RID: 215621 RVA: 0x00C7088E File Offset: 0x00C6EA8E
		public void Update(PlotReviewItemData data, int index)
		{
			this.Data = data;
			this.Index = index;
			this.Refresh();
		}

		// Token: 0x06034A46 RID: 215622 RVA: 0x00C708A4 File Offset: 0x00C6EAA4
		public void Refresh()
		{
			bool uiactive = false;
			bool uiactive2 = false;
			EPlotReviewItemType type = this.Data.Type;
			if (type != EPlotReviewItemType.Talk)
			{
				if (type == EPlotReviewItemType.Option)
				{
					uiactive2 = true;
					this.RefreshOptionItem();
				}
			}
			else
			{
				uiactive = true;
				this.RefreshTalkItem();
			}
			base.GetItem(0).SetUIActive(uiactive);
			base.GetItem(1).SetUIActive(uiactive2);
		}

		// Token: 0x06034A47 RID: 215623 RVA: 0x00C708F8 File Offset: 0x00C6EAF8
		public void RefreshTalkItem()
		{
			PlotReviewTalkItemData data = (PlotReviewTalkItemData)this.Data.Data;
			this.TalkItem.Update(data, this.Index);
		}

		// Token: 0x06034A48 RID: 215624 RVA: 0x00C70928 File Offset: 0x00C6EB28
		public void RefreshOptionItem()
		{
			PlotReviewOptionItemData data = (PlotReviewOptionItemData)this.Data.Data;
			this.OptionItem.Update(data, this.Index);
		}

		// Token: 0x06034A49 RID: 215625 RVA: 0x00C70958 File Offset: 0x00C6EB58
		public void SetTalkItemToggleClickCallBack(Action<int> onToggleClick)
		{
			this.TalkItem.OnToggleClick = onToggleClick;
		}

		// Token: 0x06034A4A RID: 215626 RVA: 0x00C70966 File Offset: 0x00C6EB66
		public void SetTalkItemCanToggleChangeCallBack(Func<int, bool> canToggleChange)
		{
			this.TalkItem.CanToggleChange = canToggleChange;
		}

		// Token: 0x06034A4B RID: 215627 RVA: 0x00C70974 File Offset: 0x00C6EB74
		public void SetTalkItemToggleState(EToggleState state)
		{
			this.TalkItem.SetToggleState(state);
		}

		// Token: 0x06034A4C RID: 215628 RVA: 0x00C70982 File Offset: 0x00C6EB82
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401C0E2 RID: 114914
		protected int Index = -1;

		// Token: 0x0401C0E3 RID: 114915
		[Nullable(2)]
		private PlotReviewItemData Data;

		// Token: 0x0401C0E4 RID: 114916
		private readonly PlotReviewTalkItem TalkItem = new PlotReviewTalkItem();

		// Token: 0x0401C0E5 RID: 114917
		private readonly PlotReviewOptionItem OptionItem = new PlotReviewOptionItem();

		// Token: 0x0200B1C0 RID: 45504
		[NullableContext(0)]
		private static class EPlotReviewDynamicScrollItemComponent
		{
			// Token: 0x04035E81 RID: 220801
			public const int TalkItem = 0;

			// Token: 0x04035E82 RID: 220802
			public const int OptionItem = 1;
		}
	}
}
