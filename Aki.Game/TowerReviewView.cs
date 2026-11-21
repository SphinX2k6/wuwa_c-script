using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200217E RID: 8574
public class TowerReviewView : UiViewBase
{
	// Token: 0x0601509B RID: 86171 RVA: 0x00621F18 File Offset: 0x00620118
	[NullableContext(1)]
	public TowerReviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601509C RID: 86172 RVA: 0x00621F24 File Offset: 0x00620124
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601509D RID: 86173 RVA: 0x00621FD0 File Offset: 0x006201D0
	protected override UniTask OnBeforeStartAsync()
	{
		TowerReviewView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerReviewView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601509E RID: 86174 RVA: 0x00622013 File Offset: 0x00620213
	protected override void OnStart()
	{
		this.AreaLayout = new GenericLayout<TowerReviewItem, int>(base.GetVerticalLayout(1), new Func<TowerReviewItem>(this.RefreshItem), null, false, true);
		this.RefreshView();
	}

	// Token: 0x0601509F RID: 86175 RVA: 0x0062203C File Offset: 0x0062023C
	protected override void OnBeforeDestroy()
	{
		this.AreaLayout = null;
		if (this.HasQuickPass)
		{
			EventSystem.Instance.Emit(EEventName.OnTowerReviewGoToReward);
		}
	}

	// Token: 0x060150A0 RID: 86176 RVA: 0x00622060 File Offset: 0x00620260
	private void RefreshView()
	{
		int difficulty = 3;
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(difficulty, true);
		if (difficultyAllAreaFirstFloor == null)
		{
			return;
		}
		this.AreaLayout.RefreshByData(difficultyAllAreaFirstFloor, null, false);
		base.GetText(2).SetText(TowerModel.Instance.GetDifficultyMaxStars(difficulty, true).ToString() + "/" + TowerModel.Instance.GetDifficultyAllStars(difficulty, true).ToString(), true);
		this.HasQuickPass = false;
		foreach (int floorId in TowerModel.Instance.GetDifficultyAllFloor(difficulty))
		{
			TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(floorId);
			if (floorData != null && floorData.IsQuickPass)
			{
				this.HasQuickPass = true;
				break;
			}
		}
		base.GetText(3).SetUIActive(this.HasQuickPass);
		if (this.HasQuickPass)
		{
			int quickPassId = TowerModel.Instance.QuickPassId;
			TowerQuickPass? config = ConfigTowerQuickPassById.GetConfig(quickPassId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CycleTower;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "TowerReviewView: QuickPass config not found";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QuickPassId", quickPassId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), config.Value.TipText, Array.Empty<object>());
			}
		}
		string textId = this.HasQuickPass ? "CycleTowerReward" : "CycleTowerConfirm";
		this.ConfirmBtnItem.SetLocalTextNew(textId, Array.Empty<object>());
	}

	// Token: 0x060150A1 RID: 86177 RVA: 0x006221D8 File Offset: 0x006203D8
	[NullableContext(1)]
	private TowerReviewItem RefreshItem()
	{
		return new TowerReviewItem();
	}

	// Token: 0x060150A2 RID: 86178 RVA: 0x006221DF File Offset: 0x006203DF
	private void OnClickConfirmBtn(int _)
	{
		TowerModel.Instance.ClearHandleData();
		base.CloseMe(null);
	}

	// Token: 0x0400B311 RID: 45841
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400B312 RID: 45842
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerReviewItem, int> AreaLayout;

	// Token: 0x0400B313 RID: 45843
	private bool HasQuickPass;

	// Token: 0x0200840D RID: 33805
	private enum EChildType
	{
		// Token: 0x0402A9C1 RID: 174529
		ConfirmBtnItem,
		// Token: 0x0402A9C2 RID: 174530
		ScrollView,
		// Token: 0x0402A9C3 RID: 174531
		ReceivedStarText,
		// Token: 0x0402A9C4 RID: 174532
		QuickPassTipText
	}
}
