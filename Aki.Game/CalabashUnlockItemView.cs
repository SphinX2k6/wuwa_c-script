using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C34 RID: 3124
[NullableContext(1)]
[Nullable(0)]
public class CalabashUnlockItemView : UiTickViewBase
{
	// Token: 0x06008297 RID: 33431 RVA: 0x0028198D File Offset: 0x0027FB8D
	public CalabashUnlockItemView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17000EA1 RID: 3745
	// (get) Token: 0x06008298 RID: 33432 RVA: 0x002819A1 File Offset: 0x0027FBA1
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

	// Token: 0x06008299 RID: 33433 RVA: 0x002819C8 File Offset: 0x0027FBC8
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

	// Token: 0x0600829A RID: 33434 RVA: 0x00281AC9 File Offset: 0x0027FCC9
	protected override void OnBeforeCreate()
	{
		this.UnLockData = (VisionUnlockQualityData)this.OpenParam;
	}

	// Token: 0x0600829B RID: 33435 RVA: 0x00281ADC File Offset: 0x0027FCDC
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashUnlockItemView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashUnlockItemView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600829C RID: 33436 RVA: 0x00281B20 File Offset: 0x0027FD20
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetLayoutBase(7));
		base.GetButton(4).RootUIComp.Get().SetRaycastTarget(!GameModeController.Instance.IsInInstance());
		base.GetText(5).SetUIActive(!GameModeController.Instance.IsInInstance());
	}

	// Token: 0x0600829D RID: 33437 RVA: 0x00281B7E File Offset: 0x0027FD7E
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600829E RID: 33438 RVA: 0x00281B88 File Offset: 0x0027FD88
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

	// Token: 0x0600829F RID: 33439 RVA: 0x00281BC8 File Offset: 0x0027FDC8
	private UniTask CreateItemGrid()
	{
		CalabashUnlockItemView.<CreateItemGrid>d__16 <CreateItemGrid>d__;
		<CreateItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateItemGrid>d__.<>4__this = this;
		<CreateItemGrid>d__.<>1__state = -1;
		<CreateItemGrid>d__.<>t__builder.Start<CalabashUnlockItemView.<CreateItemGrid>d__16>(ref <CreateItemGrid>d__);
		return <CreateItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x060082A0 RID: 33440 RVA: 0x00281C0C File Offset: 0x0027FE0C
	private UniTask Delay()
	{
		CalabashUnlockItemView.<Delay>d__17 <Delay>d__;
		<Delay>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Delay>d__.<>4__this = this;
		<Delay>d__.<>1__state = -1;
		<Delay>d__.<>t__builder.Start<CalabashUnlockItemView.<Delay>d__17>(ref <Delay>d__);
		return <Delay>d__.<>t__builder.Task;
	}

	// Token: 0x060082A1 RID: 33441 RVA: 0x00281C50 File Offset: 0x0027FE50
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

	// Token: 0x060082A2 RID: 33442 RVA: 0x00281CFB File Offset: 0x0027FEFB
	private void RefreshGridItem()
	{
		this.ItemGrid.RefreshByData(this.UnLockData.MonsterItemId);
	}

	// Token: 0x060082A3 RID: 33443 RVA: 0x00281D14 File Offset: 0x0027FF14
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

	// Token: 0x060082A4 RID: 33444 RVA: 0x00281D60 File Offset: 0x0027FF60
	private void RefreshBgTexture()
	{
		QualityInfo? itemQualityConfig = InventoryConfig.Instance.GetItemQualityConfig(this.UnLockData.UnlockQuality);
		base.SetTextureByPath(itemQualityConfig.Value.TextureVisionQuailtyBg, base.GetTexture(3), null, null);
		base.SetTextureByPath(itemQualityConfig.Value.TextureVisionQuailtyFlow, base.GetTexture(8), null, null);
	}

	// Token: 0x060082A5 RID: 33445 RVA: 0x00281DD0 File Offset: 0x0027FFD0
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

	// Token: 0x060082A6 RID: 33446 RVA: 0x00281E38 File Offset: 0x00280038
	private void RefreshDesc()
	{
		PhantomBattleInstance phantomInstanceByItemId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.UnLockData.MonsterItemId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomInstanceByItemId.GetPhantomSkillInfoByLevel().Value.SimplyDescription, Array.Empty<object>());
	}

	// Token: 0x060082A7 RID: 33447 RVA: 0x00281E88 File Offset: 0x00280088
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

	// Token: 0x060082A8 RID: 33448 RVA: 0x00281EFC File Offset: 0x002800FC
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

	// Token: 0x060082A9 RID: 33449 RVA: 0x00281F44 File Offset: 0x00280144
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

	// Token: 0x04004FF6 RID: 20470
	private float TipCountDown;

	// Token: 0x04004FF7 RID: 20471
	[Nullable(2)]
	private VisionUnlockQualityData UnLockData;

	// Token: 0x04004FF8 RID: 20472
	private CalabashDevelopReward? ConfigData;

	// Token: 0x04004FF9 RID: 20473
	private readonly CustomPromise<bool> DelayPromise = new CustomPromise<bool>();

	// Token: 0x04004FFA RID: 20474
	[Nullable(2)]
	private VisionGridItem ItemGrid;

	// Token: 0x04004FFB RID: 20475
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02006F07 RID: 28423
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x040244BB RID: 148667
		public const int ItemGrid = 0;

		// Token: 0x040244BC RID: 148668
		public const int Name = 1;

		// Token: 0x040244BD RID: 148669
		public const int Desc = 2;

		// Token: 0x040244BE RID: 148670
		public const int BgTexture = 3;

		// Token: 0x040244BF RID: 148671
		public const int Button = 4;

		// Token: 0x040244C0 RID: 148672
		public const int JumpDesc = 5;

		// Token: 0x040244C1 RID: 148673
		public const int NewTagText = 6;

		// Token: 0x040244C2 RID: 148674
		public const int StarLayout = 7;

		// Token: 0x040244C3 RID: 148675
		public const int BgFlowTexture = 8;
	}
}
