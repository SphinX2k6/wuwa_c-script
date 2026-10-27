using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200129A RID: 4762
public class LifePointDrawItem : UiPanelBase
{
	// Token: 0x06008255 RID: 33365 RVA: 0x001BA414 File Offset: 0x001B8614
	protected unsafe override void OnRegisterComponent()
	{
		int num = 23;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUISpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008256 RID: 33366 RVA: 0x001BA77E File Offset: 0x001B897E
	protected override void OnStart()
	{
		this.SequencePlayer = new UiSequencePlayer(base.GetButton(0).RootUIComp);
	}

	// Token: 0x06008257 RID: 33367 RVA: 0x001BA79C File Offset: 0x001B899C
	[NullableContext(1)]
	public void PlaySequence(string sequenceType)
	{
		if (this.SequencePlayer != null)
		{
			this.SequencePlayer.PlaySequence(sequenceType, false, null);
		}
	}

	// Token: 0x06008258 RID: 33368 RVA: 0x001BA7C8 File Offset: 0x001B89C8
	private void OnClickBtn()
	{
		int id = this.LifePointDrawActivityData.Id;
		int groupId = this.GroupId;
		if (!LifePointDrawModel.Instance.GetGroupUnlockState(id, groupId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Colorful_Challenge_LockTime", Array.Empty<object>());
			return;
		}
		LifePointDrawViewModel lifePointDrawViewModel = new LifePointDrawViewModel();
		lifePointDrawViewModel.GroupId = this.GroupId;
		lifePointDrawViewModel.LifePointDrawActivityData = this.LifePointDrawActivityData;
		UiManager.Instance.OpenView(EUiViewName.LifePointDrawDetailView, lifePointDrawViewModel, null);
	}

	// Token: 0x06008259 RID: 33369 RVA: 0x001BA83A File Offset: 0x001B8A3A
	public void SetIndex(int index)
	{
		if (index % 2 == 0)
		{
			this.IfUpItem = true;
			return;
		}
		this.IfUpItem = false;
	}

	// Token: 0x0600825A RID: 33370 RVA: 0x001BA850 File Offset: 0x001B8A50
	[NullableContext(1)]
	public void RefreshView(int groupId, LifePointDrawActivityData data)
	{
		this.GroupId = groupId;
		this.LifePointDrawActivityData = data;
		this.RefreshColorTexture(data.Id, groupId);
		this.RefreshLine(data.Id, groupId);
		this.RefreshLevelNumSpriteTransition(data.Id, groupId);
		this.RefreshSpriteColor(data.Id, groupId);
		this.RefreshRoundItem(data.Id, groupId);
		this.RefreshTitleBgSprite(data.Id, groupId);
		this.RefreshNameTextColor(data.Id, groupId);
		this.RefreshName(groupId);
		this.RefreshHintItem(data.Id, groupId);
		this.RefreshProgressDesc(data.Id, groupId);
		this.RefreshUnlockDesc(data.Id, groupId);
		this.RefreshRedDot(groupId);
	}

	// Token: 0x0600825B RID: 33371 RVA: 0x001BA8FC File Offset: 0x001B8AFC
	private void RefreshRedDot(int groupId)
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), groupId);
		RedDotController.Instance.BindRedDot(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), null, groupId);
	}

	// Token: 0x0600825C RID: 33372 RVA: 0x001BA930 File Offset: 0x001B8B30
	private void RefreshLine(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		bool ifUpItem = this.IfUpItem;
		base.GetItem(4).SetUIActive(groupUnlockState && ifUpItem);
		base.GetItem(5).SetUIActive(groupUnlockState && !ifUpItem);
		base.GetItem(6).SetUIActive(!groupUnlockState && ifUpItem);
		base.GetItem(7).SetUIActive(!groupUnlockState && !ifUpItem);
	}

	// Token: 0x0600825D RID: 33373 RVA: 0x001BA9A0 File Offset: 0x001B8BA0
	private UniTask RefreshLevelNumSpriteTransition(int activityId, int groupId)
	{
		LifePointDrawItem.<RefreshLevelNumSpriteTransition>d__12 <RefreshLevelNumSpriteTransition>d__;
		<RefreshLevelNumSpriteTransition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshLevelNumSpriteTransition>d__.<>4__this = this;
		<RefreshLevelNumSpriteTransition>d__.activityId = activityId;
		<RefreshLevelNumSpriteTransition>d__.groupId = groupId;
		<RefreshLevelNumSpriteTransition>d__.<>1__state = -1;
		<RefreshLevelNumSpriteTransition>d__.<>t__builder.Start<LifePointDrawItem.<RefreshLevelNumSpriteTransition>d__12>(ref <RefreshLevelNumSpriteTransition>d__);
		return <RefreshLevelNumSpriteTransition>d__.<>t__builder.Task;
	}

	// Token: 0x0600825E RID: 33374 RVA: 0x001BA9F4 File Offset: 0x001B8BF4
	private void RefreshColorTexture(int activityId, int groupId)
	{
		string resourceId = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId) ? "T_ColorBoardUnLock" : "T_ColorBoardLock";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
	}

	// Token: 0x0600825F RID: 33375 RVA: 0x001BAA40 File Offset: 0x001B8C40
	private void RefreshRoundItem(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(groupUnlockState);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!groupUnlockState);
	}

	// Token: 0x06008260 RID: 33376 RVA: 0x001BAA84 File Offset: 0x001B8C84
	private void RefreshSpriteColor(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		UUISprite sprite = base.GetSprite(9);
		FColor? fcolor;
		if (sprite != null)
		{
			bool bUseChangeColor = groupUnlockState;
			fcolor = new FColor?(base.GetSprite(9).changeColor);
			sprite.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUITexture texture = base.GetTexture(10);
		if (texture != null)
		{
			bool bUseChangeColor2 = groupUnlockState;
			fcolor = new FColor?(base.GetTexture(10).changeColor);
			texture.SetChangeColor(bUseChangeColor2, fcolor);
		}
		UUITexture texture2 = base.GetTexture(11);
		if (texture2 == null)
		{
			return;
		}
		bool bUseChangeColor3 = groupUnlockState;
		fcolor = new FColor?(base.GetTexture(10).changeColor);
		texture2.SetChangeColor(bUseChangeColor3, fcolor);
	}

	// Token: 0x06008261 RID: 33377 RVA: 0x001BAB18 File Offset: 0x001B8D18
	private void RefreshTitleBgSprite(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		base.GetSprite(12).SetUIActive(groupUnlockState);
		base.GetItem(22).SetUIActive(!groupUnlockState);
	}

	// Token: 0x06008262 RID: 33378 RVA: 0x001BAB54 File Offset: 0x001B8D54
	private void RefreshNameTextColor(int activityId, int groupId)
	{
		string hexStr = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId) ? "654A17" : "354061";
		base.GetText(13).outlineColor = FColor.FromHex(hexStr);
	}

	// Token: 0x06008263 RID: 33379 RVA: 0x001BAB90 File Offset: 0x001B8D90
	private void RefreshName(int groupId)
	{
		string name = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), name, Array.Empty<object>());
	}

	// Token: 0x06008264 RID: 33380 RVA: 0x001BABD4 File Offset: 0x001B8DD4
	private void RefreshHintItem(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		bool groupRewardState = LifePointDrawModel.Instance.GetGroupRewardState(activityId, groupId);
		bool uiactive = groupUnlockState && groupRewardState;
		bool uiactive2 = groupUnlockState && !groupRewardState;
		bool uiactive3 = !groupUnlockState;
		base.GetItem(14).SetUIActive(uiactive);
		base.GetItem(15).SetUIActive(uiactive2);
		base.GetItem(16).SetUIActive(uiactive3);
	}

	// Token: 0x06008265 RID: 33381 RVA: 0x001BAC38 File Offset: 0x001B8E38
	private void RefreshProgressDesc(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		bool groupRewardState = LifePointDrawModel.Instance.GetGroupRewardState(activityId, groupId);
		if (!groupUnlockState || groupRewardState)
		{
			base.GetText(18).SetText("", true);
			return;
		}
		string groupRewardProgress = LifePointDrawModel.Instance.GetGroupRewardProgress(activityId, groupId);
		base.GetText(18).SetText(groupRewardProgress, true);
	}

	// Token: 0x06008266 RID: 33382 RVA: 0x001BAC9C File Offset: 0x001B8E9C
	private void RefreshUnlockDesc(int activityId, int groupId)
	{
		if (LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId))
		{
			base.GetText(19).SetText("", true);
			return;
		}
		long groupUnlockTime = LifePointDrawModel.Instance.GetGroupUnlockTime(activityId, groupId);
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat((double)groupUnlockTime - TimeUtil.Instance.GetServerTime());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "LifePointUnlockText", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
	}

	// Token: 0x06008267 RID: 33383 RVA: 0x001BAD12 File Offset: 0x001B8F12
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), this.GroupId);
	}

	// Token: 0x04003AE3 RID: 15075
	[Nullable(2)]
	private UiSequencePlayer SequencePlayer;

	// Token: 0x04003AE4 RID: 15076
	private bool IfUpItem;

	// Token: 0x04003AE5 RID: 15077
	private int GroupId;

	// Token: 0x04003AE6 RID: 15078
	[Nullable(2)]
	private LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x020078B1 RID: 30897
	private class ELifePointDrawItemComponent
	{
		// Token: 0x04027C2E RID: 162862
		public const int Button = 0;

		// Token: 0x04027C2F RID: 162863
		public const int RoundUnlockItem = 1;

		// Token: 0x04027C30 RID: 162864
		public const int RoundLockItem = 2;

		// Token: 0x04027C31 RID: 162865
		public const int ColorTexture = 3;

		// Token: 0x04027C32 RID: 162866
		public const int LineUpActiveItem = 4;

		// Token: 0x04027C33 RID: 162867
		public const int LineDownActiveItem = 5;

		// Token: 0x04027C34 RID: 162868
		public const int LineUpInActiveItem = 6;

		// Token: 0x04027C35 RID: 162869
		public const int LineDownInActiveItem = 7;

		// Token: 0x04027C36 RID: 162870
		public const int LevelNumSprite = 8;

		// Token: 0x04027C37 RID: 162871
		public const int LevelNumBg = 9;

		// Token: 0x04027C38 RID: 162872
		public const int ArrowItem1 = 10;

		// Token: 0x04027C39 RID: 162873
		public const int ArrowItem2 = 11;

		// Token: 0x04027C3A RID: 162874
		public const int TitleBgSprite = 12;

		// Token: 0x04027C3B RID: 162875
		public const int TitleName = 13;

		// Token: 0x04027C3C RID: 162876
		public const int PassItem = 14;

		// Token: 0x04027C3D RID: 162877
		public const int ProgressItem = 15;

		// Token: 0x04027C3E RID: 162878
		public const int LockItem = 16;

		// Token: 0x04027C3F RID: 162879
		public const int TitleRedDot = 17;

		// Token: 0x04027C40 RID: 162880
		public const int ProgressDesc = 18;

		// Token: 0x04027C41 RID: 162881
		public const int UnlockDesc = 19;

		// Token: 0x04027C42 RID: 162882
		public const int LevelNumSpriteTransition = 20;

		// Token: 0x04027C43 RID: 162883
		public const int TitleBgSpriteTransition = 21;

		// Token: 0x04027C44 RID: 162884
		public const int LockBgItem = 22;
	}
}
