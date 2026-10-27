using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001B6F RID: 7023
public class FloroRanchPhaseTargetView : UiViewBase
{
	// Token: 0x0600D0E2 RID: 53474 RVA: 0x002FBD6B File Offset: 0x002F9F6B
	[NullableContext(1)]
	public FloroRanchPhaseTargetView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D0E3 RID: 53475 RVA: 0x002FBD74 File Offset: 0x002F9F74
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickSureBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x002FBEC0 File Offset: 0x002FA0C0
	protected override void OnBeforeShow()
	{
		FloroRanchPhaseTargetViewParam floroRanchPhaseTargetViewParam = (FloroRanchPhaseTargetViewParam)this.OpenParam;
		FloroRanchStageStart stageStartData = floroRanchPhaseTargetViewParam.StageStartData;
		this.CloseCallback = floroRanchPhaseTargetViewParam.CloseCallback;
		FloroRanchGamePlayModel.Instance.SetStageTarget(stageStartData.Target);
		int curStage = FloroRanchGamePlayModel.Instance.CurStage;
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		int maxStage = currentActivityData.GetFloroRanchSubDungeonData(subInstanceId).GetMaxStage();
		bool isEndlessMode = FloroRanchGamePlayModel.Instance.IsEndlessMode;
		UUIText text = base.GetText(1);
		if (isEndlessMode)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "FloroRanchStageTarget2", new <>z__ReadOnlySingleElementList<object>(curStage));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text, "FloroRanchStageTarget", new <>z__ReadOnlyArray<object>(new object[]
			{
				curStage,
				maxStage
			}));
		}
		UUIItem uuiitem = text;
		bool bUseChangeColor = isEndlessMode;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(isEndlessMode);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "FloroRanchDayNum", new <>z__ReadOnlySingleElementList<object>(stageStartData.DayCount));
		string coinText = FloroRanchModel.Instance.GetCoinText(stageStartData.Target);
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(coinText, true);
		}
		UUIText text3 = base.GetText(5);
		if (text3 == null)
		{
			return;
		}
		text3.SetText(stageStartData.Reward.ToString(), true);
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x002FC032 File Offset: 0x002FA232
	private void OnClickSureBtn()
	{
		base.CloseMe(null);
		if (this.CloseCallback != null)
		{
			this.CloseCallback();
		}
	}

	// Token: 0x04005FDB RID: 24539
	[Nullable(2)]
	private Func<UniTask> CloseCallback;

	// Token: 0x020080E2 RID: 32994
	private class EComponents
	{
		// Token: 0x0402A0D2 RID: 172242
		public const int TextureTitleBg = 0;

		// Token: 0x0402A0D3 RID: 172243
		public const int TextTitle = 1;

		// Token: 0x0402A0D4 RID: 172244
		public const int TextDescription = 2;

		// Token: 0x0402A0D5 RID: 172245
		public const int TextDayNum = 3;

		// Token: 0x0402A0D6 RID: 172246
		public const int TextTarget = 4;

		// Token: 0x0402A0D7 RID: 172247
		public const int TextReward = 5;

		// Token: 0x0402A0D8 RID: 172248
		public const int BtnSure = 6;

		// Token: 0x0402A0D9 RID: 172249
		public const int EndlessTitleItem = 7;
	}
}
