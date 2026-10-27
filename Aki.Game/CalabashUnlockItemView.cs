using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200177B RID: 6011
[NullableContext(1)]
[Nullable(0)]
public class CalabashUnlockItemView : UiTickViewBase
{
	// Token: 0x0600AEB0 RID: 44720 RVA: 0x002774C9 File Offset: 0x002756C9
	public CalabashUnlockItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17000E7E RID: 3710
	// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x002774DD File Offset: 0x002756DD
	protected IList<VisionUnlockQualityData> UnlockTipsList
	{
		get
		{
			if (this.UnLockData.IsUnlockMonster)
			{
				return CalabashModel.Instance.CalabashUnlockTipsList;
			}
			return PhantomBattleModel.Instance.QualityUnlockTipsList;
		}
	}

	// Token: 0x0600AEB2 RID: 44722 RVA: 0x00277504 File Offset: 0x00275704
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(8, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.JumpToCalabashCollectTab))
		};
	}

	// Token: 0x0600AEB3 RID: 44723 RVA: 0x00277605 File Offset: 0x00275805
	protected override void OnBeforeCreate()
	{
		this.UnLockData = (VisionUnlockQualityData)this.OpenParam;
	}

	// Token: 0x0600AEB4 RID: 44724 RVA: 0x00277618 File Offset: 0x00275818
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashUnlockItemView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashUnlockItemView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AEB5 RID: 44725 RVA: 0x0027765C File Offset: 0x0027585C
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetLayoutBase(7));
		base.GetButton(4).RootUIComp.Get().SetRaycastTarget(!GameModeController.Instance.IsInInstance());
		base.GetText(5).SetUIActive(!GameModeController.Instance.IsInInstance());
	}

	// Token: 0x0600AEB6 RID: 44726 RVA: 0x002776BA File Offset: 0x002758BA
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600AEB7 RID: 44727 RVA: 0x002776C4 File Offset: 0x002758C4
	protected void Refresh()
	{
		IList<VisionUnlockQualityData> unlockTipsList = this.UnlockTipsList;
		if (unlockTipsList.Count > 0)
		{
			this.UnLockData = unlockTipsList[0];
			unlockTipsList.RemoveAt(0);
		}
		else
		{
			this.UnLockData = null;
		}
		this.RefreshView();
	}

	// Token: 0x0600AEB8 RID: 44728 RVA: 0x00277704 File Offset: 0x00275904
	private UniTask CreateItemGrid()
	{
		CalabashUnlockItemView.<CreateItemGrid>d__16 <CreateItemGrid>d__;
		<CreateItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateItemGrid>d__.<>4__this = this;
		<CreateItemGrid>d__.<>1__state = -1;
		<CreateItemGrid>d__.<>t__builder.Start<CalabashUnlockItemView.<CreateItemGrid>d__16>(ref <CreateItemGrid>d__);
		return <CreateItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x0600AEB9 RID: 44729 RVA: 0x00277748 File Offset: 0x00275948
	private UniTask Delay()
	{
		CalabashUnlockItemView.<Delay>d__17 <Delay>d__;
		<Delay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Delay>d__.<>4__this = this;
		<Delay>d__.<>1__state = -1;
		<Delay>d__.<>t__builder.Start<CalabashUnlockItemView.<Delay>d__17>(ref <Delay>d__);
		return <Delay>d__.<>t__builder.Task;
	}

	// Token: 0x0600AEBA RID: 44730 RVA: 0x0027778C File Offset: 0x0027598C
	private void RefreshView()
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.UnLockData.MonsterItemId);
		this.ConfigData = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(phantomItemById.Value.MonsterId);
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(this.ConfigData.Value.MonsterInfoId);
		this.TipCountDown = (float)CalabashConfig.Instance.MaxTipCd;
		base.GetText(1).ShowTextNew(monsterInfoConfig.Value.Name);
		this.RefreshGridItem();
		this.RefreshStar();
		this.RefreshNewTagText();
		this.RefreshBgTexture();
		this.RefreshDesc();
	}

	// Token: 0x0600AEBB RID: 44731 RVA: 0x00277837 File Offset: 0x00275A37
	private void RefreshGridItem()
	{
		this.ItemGrid.RefreshByData(this.UnLockData.MonsterItemId);
	}

	// Token: 0x0600AEBC RID: 44732 RVA: 0x00277850 File Offset: 0x00275A50
	private void RefreshStar()
	{
		bool flag = this.UnLockData.UnlockQuality == 0;
		SimpleGenericLayout starLayout = this.StarLayout;
		if (starLayout != null)
		{
			starLayout.SetActive(flag);
		}
		if (flag)
		{
			SimpleGenericLayout starLayout2 = this.StarLayout;
			if (starLayout2 == null)
			{
				return;
			}
			starLayout2.RebuildLayout(this.UnLockData.UnlockQuality);
		}
	}

	// Token: 0x0600AEBD RID: 44733 RVA: 0x0027789C File Offset: 0x00275A9C
	private void RefreshBgTexture()
	{
		QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(this.UnLockData.UnlockQuality);
		base.SetTextureByPath(itemQualityConfig.Value.TextureVisionQuailtyBg, base.GetTexture(3), null, null);
		base.SetTextureByPath(itemQualityConfig.Value.TextureVisionQuailtyFlow, base.GetTexture(8), null, null);
	}

	// Token: 0x0600AEBE RID: 44734 RVA: 0x0027790C File Offset: 0x00275B0C
	private void RefreshNewTagText()
	{
		if (this.UnLockData.IsUnlockMonster)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "New_Echo_Unlocked", Array.Empty<object>());
			return;
		}
		string textStringId = (this.UnLockData.SkinId == 0) ? "UnLockNewVisionQuality" : "UnLockNewVisionSkin";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
	}

	// Token: 0x0600AEBF RID: 44735 RVA: 0x00277974 File Offset: 0x00275B74
	private void RefreshDesc()
	{
		PhantomBattleInstance phantomInstanceByItemId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.UnLockData.MonsterItemId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomInstanceByItemId.GetPhantomSkillInfoByLevel().Value.SimplyDescription, Array.Empty<object>());
	}

	// Token: 0x0600AEC0 RID: 44736 RVA: 0x002779C4 File Offset: 0x00275BC4
	private void JumpToCalabashCollectTab()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Calabash;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "跳转到鸣域终端收集页签";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("目标幻象Id", this.ConfigData.Value.MonsterId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.CloseViewOrShowNextData();
		CalabashController.Instance.JumpToCalabashCollectTabView(this.ConfigData.Value.MonsterId);
	}

	// Token: 0x0600AEC1 RID: 44737 RVA: 0x00277A38 File Offset: 0x00275C38
	protected void CloseViewOrShowNextData()
	{
		if (this.UnlockTipsList.Count > 0)
		{
			Log.Instance.Info(ELogModule.Calabash, ELogAuthor.XXJ, "刷新下个声骸数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.Refresh();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600AEC2 RID: 44738 RVA: 0x00277A80 File Offset: 0x00275C80
	protected override void OnTick(float delta)
	{
		if (this.TipCountDown <= 0f)
		{
			return;
		}
		this.TipCountDown -= delta;
		if (this.TipCountDown <= 0f)
		{
			this.CloseViewOrShowNextData();
		}
	}

	// Token: 0x04004F4C RID: 20300
	private float TipCountDown;

	// Token: 0x04004F4D RID: 20301
	[Nullable(2)]
	private VisionUnlockQualityData UnLockData;

	// Token: 0x04004F4E RID: 20302
	private CalabashDevelopReward? ConfigData;

	// Token: 0x04004F4F RID: 20303
	private readonly CustomPromise<bool> DelayPromise = new CustomPromise<bool>();

	// Token: 0x04004F50 RID: 20304
	[Nullable(2)]
	private VisionGridItem ItemGrid;

	// Token: 0x04004F51 RID: 20305
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02007D81 RID: 32129
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04029190 RID: 168336
		public const int ItemGrid = 0;

		// Token: 0x04029191 RID: 168337
		public const int Name = 1;

		// Token: 0x04029192 RID: 168338
		public const int Desc = 2;

		// Token: 0x04029193 RID: 168339
		public const int BgTexture = 3;

		// Token: 0x04029194 RID: 168340
		public const int Button = 4;

		// Token: 0x04029195 RID: 168341
		public const int JumpDesc = 5;

		// Token: 0x04029196 RID: 168342
		public const int NewTagText = 6;

		// Token: 0x04029197 RID: 168343
		public const int StarLayout = 7;

		// Token: 0x04029198 RID: 168344
		public const int BgFlowTexture = 8;
	}
}
