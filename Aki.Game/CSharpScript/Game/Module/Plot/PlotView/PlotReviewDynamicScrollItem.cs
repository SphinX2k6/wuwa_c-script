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
	// Token: 0x0200402B RID: 16427
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewDynamicScrollItem : UiPanelBase, IDynamicScrollItem<PlotReviewItemData>
	{
		// Token: 0x06029934 RID: 170292 RVA: 0x00BBD9E4 File Offset: 0x00BBBBE4
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

		// Token: 0x06029935 RID: 170293 RVA: 0x00BBDA50 File Offset: 0x00BBBC50
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

		// Token: 0x06029936 RID: 170294 RVA: 0x00BBDA9C File Offset: 0x00BBBC9C
		private UniTask InitChildItem()
		{
			PlotReviewDynamicScrollItem.<InitChildItem>d__7 <InitChildItem>d__;
			<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChildItem>d__.<>4__this = this;
			<InitChildItem>d__.<>1__state = -1;
			<InitChildItem>d__.<>t__builder.Start<PlotReviewDynamicScrollItem.<InitChildItem>d__7>(ref <InitChildItem>d__);
			return <InitChildItem>d__.<>t__builder.Task;
		}

		// Token: 0x06029937 RID: 170295 RVA: 0x00BBDAE0 File Offset: 0x00BBBCE0
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

		// Token: 0x06029938 RID: 170296 RVA: 0x00BBDB2E File Offset: 0x00BBBD2E
		public void Update(PlotReviewItemData data, int index)
		{
			this.Data = data;
			this.Index = index;
			this.Refresh();
		}

		// Token: 0x06029939 RID: 170297 RVA: 0x00BBDB44 File Offset: 0x00BBBD44
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

		// Token: 0x0602993A RID: 170298 RVA: 0x00BBDB98 File Offset: 0x00BBBD98
		public void RefreshTalkItem()
		{
			PlotReviewTalkItemData data = (PlotReviewTalkItemData)this.Data.Data;
			this.TalkItem.Update(data, this.Index);
		}

		// Token: 0x0602993B RID: 170299 RVA: 0x00BBDBC8 File Offset: 0x00BBBDC8
		public void RefreshOptionItem()
		{
			PlotReviewOptionItemData data = (PlotReviewOptionItemData)this.Data.Data;
			this.OptionItem.Update(data, this.Index);
		}

		// Token: 0x0602993C RID: 170300 RVA: 0x00BBDBF8 File Offset: 0x00BBBDF8
		public void SetTalkItemToggleClickCallBack(Action<int> onToggleClick)
		{
			this.TalkItem.OnToggleClick = onToggleClick;
		}

		// Token: 0x0602993D RID: 170301 RVA: 0x00BBDC06 File Offset: 0x00BBBE06
		public void SetTalkItemCanToggleChangeCallBack(Func<int, bool> canToggleChange)
		{
			this.TalkItem.CanToggleChange = canToggleChange;
		}

		// Token: 0x0602993E RID: 170302 RVA: 0x00BBDC14 File Offset: 0x00BBBE14
		public void SetTalkItemToggleState(EToggleState state)
		{
			this.TalkItem.SetToggleState(state);
		}

		// Token: 0x0602993F RID: 170303 RVA: 0x00BBDC22 File Offset: 0x00BBBE22
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x04016B0D RID: 92941
		protected int Index = -1;

		// Token: 0x04016B0E RID: 92942
		[Nullable(2)]
		private PlotReviewItemData Data;

		// Token: 0x04016B0F RID: 92943
		private readonly PlotReviewTalkItem TalkItem = new PlotReviewTalkItem();

		// Token: 0x04016B10 RID: 92944
		private readonly PlotReviewOptionItem OptionItem = new PlotReviewOptionItem();

		// Token: 0x02009BFA RID: 39930
		[NullableContext(0)]
		private static class EPlotReviewDynamicScrollItemComponent
		{
			// Token: 0x040308D6 RID: 198870
			public const int TalkItem = 0;

			// Token: 0x040308D7 RID: 198871
			public const int OptionItem = 1;
		}
	}
}
