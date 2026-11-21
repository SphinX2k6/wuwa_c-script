using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005994 RID: 22932
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDoubleCheckItem : UiPanelBase
	{
		// Token: 0x060388C2 RID: 231618 RVA: 0x00FD2118 File Offset: 0x00FD0318
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060388C3 RID: 231619 RVA: 0x00FD22C8 File Offset: 0x00FD04C8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolDoubleCheckItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolDoubleCheckItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060388C4 RID: 231620 RVA: 0x00FD230C File Offset: 0x00FD050C
		protected override void OnStart()
		{
			this.AttrScroll = new GenericScrollViewNew<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData>(base.GetScrollViewWithScrollbar(6), () => new SolarSchoolAttrDeltaItem(), base.GetItem(7).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x060388C5 RID: 231621 RVA: 0x00FD2360 File Offset: 0x00FD0560
		public void ShowBehaviorCheck(int behaviorId, Action onConfirm)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			string text;
			bool flag = this.CheckCanExecute(behaviorId, out text);
			this.ConfirmCallback = (flag ? onConfirm : null);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			bool flag2 = !flag && !string.IsNullOrEmpty(text);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			if (flag2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), text, Array.Empty<object>());
			}
			SolarSchoolBehavior? currentLevelRow = instance.PlayerData.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				this.RefreshDetail(string.Empty, string.Empty, 0, 0, new List<SolarSchoolAttrDeltaItemData>());
				return;
			}
			int fatigueDelta = 0;
			List<SolarSchoolAttrDeltaItemData> list = new List<SolarSchoolAttrDeltaItemData>();
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetBehaviorSuccessAttrDeltas(currentLevelRow.Value))
			{
				ESolarSchoolSecondAttr item2 = valueTuple.Item1;
				int item3 = valueTuple.Item2;
				if (item2 == ESolarSchoolSecondAttr.Fatigue)
				{
					fatigueDelta = item3;
				}
				else
				{
					list.Add(new SolarSchoolAttrDeltaItemData(item2, item3));
				}
			}
			this.RefreshDetail(SolarSchoolUtils.GetOccupyTagText(instance.GetBehaviorOccupySlot(currentLevelRow)), SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.ShortDescText), fatigueDelta, instance.GetFatigueAfterBehavior(behaviorId), list);
		}

		// Token: 0x060388C6 RID: 231622 RVA: 0x00FD24C4 File Offset: 0x00FD06C4
		private unsafe bool CheckCanExecute(int behaviorId, out string failTextId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.CanExecuteBehavior(behaviorId))
			{
				SolarSchoolBehavior? currentLevelRow = instance.PlayerData.GetCurrentLevelRow(behaviorId);
				Aki.Config.ActivityConditionGroup? activityConditionGroup = (currentLevelRow == null) ? null : ActivityConditionConfig.Instance.GetConditionGroupConfig(currentLevelRow.Value.ExecuteConditionGroupId);
				failTextId = (((activityConditionGroup != null) ? activityConditionGroup.GetValueOrDefault().HintText : null) ?? string.Empty);
				if (string.IsNullOrEmpty(failTextId))
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 行为不可执行但缺少提示文本，检查行为等级行与条件组 HintText";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionGroupId", (currentLevelRow != null) ? currentLevelRow.GetValueOrDefault().ExecuteConditionGroupId : 0);
					instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return false;
			}
			if (instance.IsBehaviorFatigueOverflow(behaviorId))
			{
				failTextId = "SolarSchool_Tired_1";
				return false;
			}
			failTextId = string.Empty;
			return true;
		}

		// Token: 0x060388C7 RID: 231623 RVA: 0x00FD25E8 File Offset: 0x00FD07E8
		private void RefreshDetail(string takeupText, string descText, int fatigueDelta, int fatigueAfter, List<SolarSchoolAttrDeltaItemData> attrDeltas)
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(takeupText, true);
			}
			SolarSchoolAttrDeltaItem fatigueItem = this.FatigueItem;
			if (fatigueItem != null)
			{
				fatigueItem.Refresh(new SolarSchoolAttrDeltaItemData(ESolarSchoolSecondAttr.Fatigue, fatigueDelta, fatigueAfter), false, 0);
			}
			bool flag = !string.IsNullOrEmpty(descText);
			if (flag)
			{
				attrDeltas = new List<SolarSchoolAttrDeltaItemData>();
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(attrDeltas.Count > 0);
			}
			GenericScrollViewNew<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData> attrScroll = this.AttrScroll;
			if (attrScroll != null)
			{
				attrScroll.RefreshByData(attrDeltas, null, false);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text2 = base.GetText(9);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(descText, true);
		}

		// Token: 0x060388C8 RID: 231624 RVA: 0x00FD2691 File Offset: 0x00FD0891
		public void CancelCheck()
		{
			this.ConfirmCallback = null;
		}

		// Token: 0x060388C9 RID: 231625 RVA: 0x00FD269A File Offset: 0x00FD089A
		private void OnConfirmClick()
		{
			Action confirmCallback = this.ConfirmCallback;
			this.ConfirmCallback = null;
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback();
		}

		// Token: 0x0401DC8B RID: 121995
		[Nullable(2)]
		private Action ConfirmCallback;

		// Token: 0x0401DC8C RID: 121996
		[Nullable(2)]
		private SolarSchoolAttrDeltaItem FatigueItem;

		// Token: 0x0401DC8D RID: 121997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SolarSchoolAttrDeltaItem, SolarSchoolAttrDeltaItemData> AttrScroll;

		// Token: 0x0200B53A RID: 46394
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038088 RID: 229512
			public const int BtnConfirm = 0;

			// Token: 0x04038089 RID: 229513
			public const int PnlTips = 1;

			// Token: 0x0403808A RID: 229514
			public const int TxtTips = 2;

			// Token: 0x0403808B RID: 229515
			public const int TxtTakeup = 3;

			// Token: 0x0403808C RID: 229516
			public const int FatigueItem = 4;

			// Token: 0x0403808D RID: 229517
			public const int PnlAttribute = 5;

			// Token: 0x0403808E RID: 229518
			public const int SvDefault = 6;

			// Token: 0x0403808F RID: 229519
			public const int PnlItem = 7;

			// Token: 0x04038090 RID: 229520
			public const int PnlDescri = 8;

			// Token: 0x04038091 RID: 229521
			public const int TxtDescri = 9;
		}
	}
}
