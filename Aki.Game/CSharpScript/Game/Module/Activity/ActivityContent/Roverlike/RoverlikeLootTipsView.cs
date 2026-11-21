using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C8 RID: 20680
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootTipsView : UiViewBase
	{
		// Token: 0x06033C13 RID: 211987 RVA: 0x00E7C48B File Offset: 0x00E7A68B
		public RoverlikeLootTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033C14 RID: 211988 RVA: 0x00E7C494 File Offset: 0x00E7A694
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnBtnSelfClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033C15 RID: 211989 RVA: 0x00E7C5C0 File Offset: 0x00E7A7C0
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLootTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLootTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033C16 RID: 211990 RVA: 0x00E7C604 File Offset: 0x00E7A804
		protected override void OnStart()
		{
			AUIBaseActor gridActor = base.GetItem(3).GetOwner() as AUIBaseActor;
			this.BeforeStarLayout = new GenericLayout<RoverlikeLootTipsStarItem, bool>(base.GetHorizontalLayout(1), new Func<RoverlikeLootTipsStarItem>(this.CreateStarItem), gridActor, false, true);
			this.AfterStarLayout = new GenericLayout<RoverlikeLootTipsStarItem, bool>(base.GetHorizontalLayout(2), new Func<RoverlikeLootTipsStarItem>(this.CreateStarItem), gridActor, false, true);
		}

		// Token: 0x06033C17 RID: 211991 RVA: 0x00E7C668 File Offset: 0x00E7A868
		protected override void OnBeforeShow()
		{
			RoverlikeLootGainEntry roverlikeLootGainEntry = this.OpenParam as RoverlikeLootGainEntry;
			if (roverlikeLootGainEntry == null)
			{
				return;
			}
			this.RefreshTips(roverlikeLootGainEntry);
		}

		// Token: 0x06033C18 RID: 211992 RVA: 0x00E7C68C File Offset: 0x00E7A88C
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033C19 RID: 211993 RVA: 0x00E7C695 File Offset: 0x00E7A895
		private void OnBtnSelfClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(new EUiTabViewName?(EUiTabViewName.RoverlikeDetailRoleTabView));
		}

		// Token: 0x06033C1A RID: 211994 RVA: 0x00E7C6AC File Offset: 0x00E7A8AC
		private void RefreshTips(RoverlikeLootGainEntry entry)
		{
			RoverRogueLoot? lootConfig = RoverlikeConfig.Instance.GetLootConfig(entry.ConfigId);
			if (lootConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), lootConfig.Value.Name, Array.Empty<object>());
			RoverlikeLootTipsIconItem iconItem = this.IconItem;
			if (iconItem != null)
			{
				iconItem.Refresh(lootConfig.Value.Icon);
			}
			GenericLayout<RoverlikeLootTipsStarItem, bool> beforeStarLayout = this.BeforeStarLayout;
			if (beforeStarLayout != null)
			{
				beforeStarLayout.RefreshByData(this.BuildStars(entry.LootLv - 1, lootConfig.Value.MaxLevel), null, false);
			}
			GenericLayout<RoverlikeLootTipsStarItem, bool> afterStarLayout = this.AfterStarLayout;
			if (afterStarLayout == null)
			{
				return;
			}
			afterStarLayout.RefreshByData(this.BuildStars(entry.LootLv, lootConfig.Value.MaxLevel), null, false);
		}

		// Token: 0x06033C1B RID: 211995 RVA: 0x00E7C778 File Offset: 0x00E7A978
		private List<bool> BuildStars(int level, int maxLevel)
		{
			int num = Math.Max(0, level);
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				list.Add(i < num);
			}
			return list;
		}

		// Token: 0x06033C1C RID: 211996 RVA: 0x00E7C7AA File Offset: 0x00E7A9AA
		private RoverlikeLootTipsStarItem CreateStarItem()
		{
			return new RoverlikeLootTipsStarItem();
		}

		// Token: 0x0401B6E6 RID: 112358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootTipsStarItem, bool> BeforeStarLayout;

		// Token: 0x0401B6E7 RID: 112359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootTipsStarItem, bool> AfterStarLayout;

		// Token: 0x0401B6E8 RID: 112360
		[Nullable(2)]
		private RoverlikeLootTipsIconItem IconItem;

		// Token: 0x0200AD90 RID: 44432
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A03 RID: 219651
			public const int TxtName = 0;

			// Token: 0x04035A04 RID: 219652
			public const int StarLayoutBefore = 1;

			// Token: 0x04035A05 RID: 219653
			public const int StarLayoutAfter = 2;

			// Token: 0x04035A06 RID: 219654
			public const int StarTemplate = 3;

			// Token: 0x04035A07 RID: 219655
			public const int IconContainer = 4;

			// Token: 0x04035A08 RID: 219656
			public const int BtnSelf = 5;
		}
	}
}
