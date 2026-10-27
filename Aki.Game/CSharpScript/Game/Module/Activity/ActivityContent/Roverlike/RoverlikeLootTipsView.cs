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
	// Token: 0x0200614A RID: 24906
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootTipsView : UiViewBase
	{
		// Token: 0x0603EF53 RID: 257875 RVA: 0x00F355AB File Offset: 0x00F337AB
		public RoverlikeLootTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF54 RID: 257876 RVA: 0x00F355B4 File Offset: 0x00F337B4
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

		// Token: 0x0603EF55 RID: 257877 RVA: 0x00F356E0 File Offset: 0x00F338E0
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLootTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLootTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EF56 RID: 257878 RVA: 0x00F35724 File Offset: 0x00F33924
		protected override void OnStart()
		{
			AUIBaseActor gridActor = base.GetItem(3).GetOwner() as AUIBaseActor;
			this.BeforeStarLayout = new GenericLayout<RoverlikeLootTipsStarItem, bool>(base.GetHorizontalLayout(1), new Func<RoverlikeLootTipsStarItem>(this.CreateStarItem), gridActor, false, true);
			this.AfterStarLayout = new GenericLayout<RoverlikeLootTipsStarItem, bool>(base.GetHorizontalLayout(2), new Func<RoverlikeLootTipsStarItem>(this.CreateStarItem), gridActor, false, true);
		}

		// Token: 0x0603EF57 RID: 257879 RVA: 0x00F35788 File Offset: 0x00F33988
		protected override void OnBeforeShow()
		{
			RoverlikeLootGainEntry roverlikeLootGainEntry = this.OpenParam as RoverlikeLootGainEntry;
			if (roverlikeLootGainEntry == null)
			{
				return;
			}
			this.RefreshTips(roverlikeLootGainEntry);
		}

		// Token: 0x0603EF58 RID: 257880 RVA: 0x00F357AC File Offset: 0x00F339AC
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603EF59 RID: 257881 RVA: 0x00F357B5 File Offset: 0x00F339B5
		private void OnBtnSelfClick()
		{
			RoverlikeController.Instance.OpenGameInfoView(new EUiTabViewName?(EUiTabViewName.RoverlikeDetailRoleTabView));
		}

		// Token: 0x0603EF5A RID: 257882 RVA: 0x00F357CC File Offset: 0x00F339CC
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

		// Token: 0x0603EF5B RID: 257883 RVA: 0x00F35898 File Offset: 0x00F33A98
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

		// Token: 0x0603EF5C RID: 257884 RVA: 0x00F358CA File Offset: 0x00F33ACA
		private RoverlikeLootTipsStarItem CreateStarItem()
		{
			return new RoverlikeLootTipsStarItem();
		}

		// Token: 0x04020DB9 RID: 134585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootTipsStarItem, bool> BeforeStarLayout;

		// Token: 0x04020DBA RID: 134586
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootTipsStarItem, bool> AfterStarLayout;

		// Token: 0x04020DBB RID: 134587
		[Nullable(2)]
		private RoverlikeLootTipsIconItem IconItem;

		// Token: 0x0200C3A9 RID: 50089
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B0A2 RID: 241826
			public const int TxtName = 0;

			// Token: 0x0403B0A3 RID: 241827
			public const int StarLayoutBefore = 1;

			// Token: 0x0403B0A4 RID: 241828
			public const int StarLayoutAfter = 2;

			// Token: 0x0403B0A5 RID: 241829
			public const int StarTemplate = 3;

			// Token: 0x0403B0A6 RID: 241830
			public const int IconContainer = 4;

			// Token: 0x0403B0A7 RID: 241831
			public const int BtnSelf = 5;
		}
	}
}
