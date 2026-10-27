using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DC4 RID: 19908
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeBuffListItem : UiPanelBase
	{
		// Token: 0x06033646 RID: 210502 RVA: 0x00BFFA84 File Offset: 0x00BFDC84
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

		// Token: 0x06033647 RID: 210503 RVA: 0x00BFFB0E File Offset: 0x00BFDD0E
		protected override void OnStart()
		{
			this.DebuffScrollView = new GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData>(base.GetScrollViewWithScrollbar(1), new Func<RoguelikeBossChallengeDebuffItem>(this.CreateDebuffItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x06033648 RID: 210504 RVA: 0x00BFFB41 File Offset: 0x00BFDD41
		public void RefreshBuffList(List<RoguelikeBossChallengeBuffData> dataList)
		{
			this.CurrentDataList = dataList;
			GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> debuffScrollView = this.DebuffScrollView;
			if (debuffScrollView == null)
			{
				return;
			}
			debuffScrollView.RefreshByData(dataList, null, false);
		}

		// Token: 0x06033649 RID: 210505 RVA: 0x00BFFB5D File Offset: 0x00BFDD5D
		protected override void OnBeforeDestroy()
		{
			this.DebuffScrollView = null;
			this.CurrentDataList = new List<RoguelikeBossChallengeBuffData>();
		}

		// Token: 0x0603364A RID: 210506 RVA: 0x00BFFB71 File Offset: 0x00BFDD71
		private RoguelikeBossChallengeDebuffItem CreateDebuffItem()
		{
			return new RoguelikeBossChallengeDebuffItem();
		}

		// Token: 0x0401B49C RID: 111772
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> DebuffScrollView;

		// Token: 0x0401B49D RID: 111773
		protected List<RoguelikeBossChallengeBuffData> CurrentDataList = new List<RoguelikeBossChallengeBuffData>();

		// Token: 0x0200AF3B RID: 44859
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035361 RID: 217953
			public const int TxtTitle = 0;

			// Token: 0x04035362 RID: 217954
			public const int DebuffItemScroll = 1;

			// Token: 0x04035363 RID: 217955
			public const int ItemBossDebuffItem = 2;
		}
	}
}
