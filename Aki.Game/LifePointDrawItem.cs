using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200074E RID: 1870
public class LifePointDrawItem : UiPanelBase
{
	// Token: 0x060055EC RID: 21996 RVA: 0x001C30E4 File Offset: 0x001C12E4
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

	// Token: 0x060055ED RID: 21997 RVA: 0x001C344E File Offset: 0x001C164E
	protected override void OnStart()
	{
		this.SequencePlayer = new UiSequencePlayer(base.GetButton(0).RootUIComp);
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x001C346C File Offset: 0x001C166C
	[NullableContext(1)]
	public void PlaySequence(string sequenceType)
	{
		if (this.SequencePlayer != null)
		{
			this.SequencePlayer.PlaySequence(sequenceType, false, null);
		}
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x001C3498 File Offset: 0x001C1698
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

	// Token: 0x060055F0 RID: 22000 RVA: 0x001C350A File Offset: 0x001C170A
	public void SetIndex(int index)
	{
		if (index % 2 == 0)
		{
			this.IfUpItem = true;
			return;
		}
		this.IfUpItem = false;
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x001C3520 File Offset: 0x001C1720
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

	// Token: 0x060055F2 RID: 22002 RVA: 0x001C35CC File Offset: 0x001C17CC
	private void RefreshRedDot(int groupId)
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), groupId);
		RedDotController.Instance.BindRedDot(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), null, groupId);
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x001C3600 File Offset: 0x001C1800
	private void RefreshLine(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		bool ifUpItem = this.IfUpItem;
		base.GetItem(4).SetUIActive(groupUnlockState && ifUpItem);
		base.GetItem(5).SetUIActive(groupUnlockState && !ifUpItem);
		base.GetItem(6).SetUIActive(!groupUnlockState && ifUpItem);
		base.GetItem(7).SetUIActive(!groupUnlockState && !ifUpItem);
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x001C3670 File Offset: 0x001C1870
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

	// Token: 0x060055F5 RID: 22005 RVA: 0x001C36C4 File Offset: 0x001C18C4
	private void RefreshColorTexture(int activityId, int groupId)
	{
		string resourceId = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId) ? "T_ColorBoardUnLock" : "T_ColorBoardLock";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x001C3710 File Offset: 0x001C1910
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

	// Token: 0x060055F7 RID: 22007 RVA: 0x001C3754 File Offset: 0x001C1954
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

	// Token: 0x060055F8 RID: 22008 RVA: 0x001C37E8 File Offset: 0x001C19E8
	private void RefreshTitleBgSprite(int activityId, int groupId)
	{
		bool groupUnlockState = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId);
		base.GetSprite(12).SetUIActive(groupUnlockState);
		base.GetItem(22).SetUIActive(!groupUnlockState);
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x001C3824 File Offset: 0x001C1A24
	private void RefreshNameTextColor(int activityId, int groupId)
	{
		string hexStr = LifePointDrawModel.Instance.GetGroupUnlockState(activityId, groupId) ? "654A17" : "354061";
		base.GetText(13).outlineColor = FColor.FromHex(hexStr);
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x001C3860 File Offset: 0x001C1A60
	private void RefreshName(int groupId)
	{
		string name = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId).Value.Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), name, Array.Empty<object>());
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x001C38A4 File Offset: 0x001C1AA4
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

	// Token: 0x060055FC RID: 22012 RVA: 0x001C3908 File Offset: 0x001C1B08
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

	// Token: 0x060055FD RID: 22013 RVA: 0x001C396C File Offset: 0x001C1B6C
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

	// Token: 0x060055FE RID: 22014 RVA: 0x001C39E2 File Offset: 0x001C1BE2
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawGroupRedDot, base.GetItem(17), this.GroupId);
	}

	// Token: 0x04003B7B RID: 15227
	[Nullable(2)]
	private UiSequencePlayer SequencePlayer;

	// Token: 0x04003B7C RID: 15228
	private bool IfUpItem;

	// Token: 0x04003B7D RID: 15229
	private int GroupId;

	// Token: 0x04003B7E RID: 15230
	[Nullable(2)]
	private LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x02006A3C RID: 27196
	private class ELifePointDrawItemComponent
	{
		// Token: 0x04022F5F RID: 143199
		public const int Button = 0;

		// Token: 0x04022F60 RID: 143200
		public const int RoundUnlockItem = 1;

		// Token: 0x04022F61 RID: 143201
		public const int RoundLockItem = 2;

		// Token: 0x04022F62 RID: 143202
		public const int ColorTexture = 3;

		// Token: 0x04022F63 RID: 143203
		public const int LineUpActiveItem = 4;

		// Token: 0x04022F64 RID: 143204
		public const int LineDownActiveItem = 5;

		// Token: 0x04022F65 RID: 143205
		public const int LineUpInActiveItem = 6;

		// Token: 0x04022F66 RID: 143206
		public const int LineDownInActiveItem = 7;

		// Token: 0x04022F67 RID: 143207
		public const int LevelNumSprite = 8;

		// Token: 0x04022F68 RID: 143208
		public const int LevelNumBg = 9;

		// Token: 0x04022F69 RID: 143209
		public const int ArrowItem1 = 10;

		// Token: 0x04022F6A RID: 143210
		public const int ArrowItem2 = 11;

		// Token: 0x04022F6B RID: 143211
		public const int TitleBgSprite = 12;

		// Token: 0x04022F6C RID: 143212
		public const int TitleName = 13;

		// Token: 0x04022F6D RID: 143213
		public const int PassItem = 14;

		// Token: 0x04022F6E RID: 143214
		public const int ProgressItem = 15;

		// Token: 0x04022F6F RID: 143215
		public const int LockItem = 16;

		// Token: 0x04022F70 RID: 143216
		public const int TitleRedDot = 17;

		// Token: 0x04022F71 RID: 143217
		public const int ProgressDesc = 18;

		// Token: 0x04022F72 RID: 143218
		public const int UnlockDesc = 19;

		// Token: 0x04022F73 RID: 143219
		public const int LevelNumSpriteTransition = 20;

		// Token: 0x04022F74 RID: 143220
		public const int TitleBgSpriteTransition = 21;

		// Token: 0x04022F75 RID: 143221
		public const int LockBgItem = 22;
	}
}
