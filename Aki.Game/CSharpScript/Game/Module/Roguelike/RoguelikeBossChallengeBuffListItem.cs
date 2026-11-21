using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D8D RID: 15757
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeBossChallengeBuffListItem : UiPanelBase
	{
		// Token: 0x060284B3 RID: 165043 RVA: 0x00B48FC4 File Offset: 0x00B471C4
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

		// Token: 0x060284B4 RID: 165044 RVA: 0x00B4904E File Offset: 0x00B4724E
		protected override void OnStart()
		{
			this.DebuffScrollView = new GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData>(base.GetScrollViewWithScrollbar(1), new Func<RoguelikeBossChallengeDebuffItem>(this.CreateDebuffItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x060284B5 RID: 165045 RVA: 0x00B49081 File Offset: 0x00B47281
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

		// Token: 0x060284B6 RID: 165046 RVA: 0x00B4909D File Offset: 0x00B4729D
		protected override void OnBeforeDestroy()
		{
			this.DebuffScrollView = null;
			this.CurrentDataList = new List<RoguelikeBossChallengeBuffData>();
		}

		// Token: 0x060284B7 RID: 165047 RVA: 0x00B490B1 File Offset: 0x00B472B1
		private RoguelikeBossChallengeDebuffItem CreateDebuffItem()
		{
			return new RoguelikeBossChallengeDebuffItem();
		}

		// Token: 0x04015E6F RID: 89711
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoguelikeBossChallengeDebuffItem, RoguelikeBossChallengeBuffData> DebuffScrollView;

		// Token: 0x04015E70 RID: 89712
		protected List<RoguelikeBossChallengeBuffData> CurrentDataList = new List<RoguelikeBossChallengeBuffData>();

		// Token: 0x02009970 RID: 39280
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD96 RID: 195990
			public const int TxtTitle = 0;

			// Token: 0x0402FD97 RID: 195991
			public const int DebuffItemScroll = 1;

			// Token: 0x0402FD98 RID: 195992
			public const int ItemBossDebuffItem = 2;
		}
	}
}
