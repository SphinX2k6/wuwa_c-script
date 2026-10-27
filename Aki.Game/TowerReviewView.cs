using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C03 RID: 11267
public class TowerReviewView : UiViewBase
{
	// Token: 0x0601766A RID: 95850 RVA: 0x005F53F0 File Offset: 0x005F35F0
	[NullableContext(1)]
	public TowerReviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601766B RID: 95851 RVA: 0x005F53FC File Offset: 0x005F35FC
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

	// Token: 0x0601766C RID: 95852 RVA: 0x005F54A8 File Offset: 0x005F36A8
	protected override UniTask OnBeforeStartAsync()
	{
		TowerReviewView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerReviewView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601766D RID: 95853 RVA: 0x005F54EB File Offset: 0x005F36EB
	protected override void OnStart()
	{
		this.AreaLayout = new GenericLayout<TowerReviewItem, int>(base.GetVerticalLayout(1), new Func<TowerReviewItem>(this.RefreshItem), null, false, true);
		this.RefreshView();
	}

	// Token: 0x0601766E RID: 95854 RVA: 0x005F5514 File Offset: 0x005F3714
	protected override void OnBeforeDestroy()
	{
		this.AreaLayout = null;
		if (this.HasQuickPass)
		{
			EventSystem.Instance.Emit(EEventName.OnTowerReviewGoToReward);
		}
	}

	// Token: 0x0601766F RID: 95855 RVA: 0x005F5538 File Offset: 0x005F3738
	private void RefreshView()
	{
		int difficulty = 3;
		int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(difficulty, true);
		if (difficultyAllAreaFirstFloor == null)
		{
			return;
		}
		this.AreaLayout.RefreshByData(difficultyAllAreaFirstFloor.ToList<int>(), null, false);
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

	// Token: 0x06017670 RID: 95856 RVA: 0x005F56B5 File Offset: 0x005F38B5
	[NullableContext(1)]
	private TowerReviewItem RefreshItem()
	{
		return new TowerReviewItem();
	}

	// Token: 0x06017671 RID: 95857 RVA: 0x005F56BC File Offset: 0x005F38BC
	private void OnClickConfirmBtn(int _)
	{
		TowerModel.Instance.ClearHandleData();
		base.CloseMe(null);
	}

	// Token: 0x0400AF0C RID: 44812
	[Nullable(2)]
	private ButtonItem ConfirmBtnItem;

	// Token: 0x0400AF0D RID: 44813
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerReviewItem, int> AreaLayout;

	// Token: 0x0400AF0E RID: 44814
	private bool HasQuickPass;

	// Token: 0x020091CA RID: 37322
	private enum EChildType
	{
		// Token: 0x0402F2C0 RID: 193216
		ConfirmBtnItem,
		// Token: 0x0402F2C1 RID: 193217
		ScrollView,
		// Token: 0x0402F2C2 RID: 193218
		ReceivedStarText,
		// Token: 0x0402F2C3 RID: 193219
		QuickPassTipText
	}
}
