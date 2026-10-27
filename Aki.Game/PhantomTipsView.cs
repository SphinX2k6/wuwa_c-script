using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002026 RID: 8230
[NullableContext(1)]
[Nullable(0)]
public class PhantomTipsView : UiViewBase
{
	// Token: 0x0601020A RID: 66058 RVA: 0x003ED2A4 File Offset: 0x003EB4A4
	public PhantomTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601020B RID: 66059 RVA: 0x003ED2B0 File Offset: 0x003EB4B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUITexture))
		};
	}

	// Token: 0x0601020C RID: 66060 RVA: 0x003ED3D4 File Offset: 0x003EB5D4
	private UniTask CreateVisionItem()
	{
		PhantomTipsView.<CreateVisionItem>d__9 <CreateVisionItem>d__;
		<CreateVisionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateVisionItem>d__.<>4__this = this;
		<CreateVisionItem>d__.<>1__state = -1;
		<CreateVisionItem>d__.<>t__builder.Start<PhantomTipsView.<CreateVisionItem>d__9>(ref <CreateVisionItem>d__);
		return <CreateVisionItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601020D RID: 66061 RVA: 0x003ED418 File Offset: 0x003EB618
	private UniTask CreateMainAttributeItem()
	{
		PhantomTipsView.<CreateMainAttributeItem>d__10 <CreateMainAttributeItem>d__;
		<CreateMainAttributeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainAttributeItem>d__.<>4__this = this;
		<CreateMainAttributeItem>d__.<>1__state = -1;
		<CreateMainAttributeItem>d__.<>t__builder.Start<PhantomTipsView.<CreateMainAttributeItem>d__10>(ref <CreateMainAttributeItem>d__);
		return <CreateMainAttributeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601020E RID: 66062 RVA: 0x003ED45C File Offset: 0x003EB65C
	private UniTask CreateSubAttributeItem()
	{
		PhantomTipsView.<CreateSubAttributeItem>d__11 <CreateSubAttributeItem>d__;
		<CreateSubAttributeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSubAttributeItem>d__.<>4__this = this;
		<CreateSubAttributeItem>d__.<>1__state = -1;
		<CreateSubAttributeItem>d__.<>t__builder.Start<PhantomTipsView.<CreateSubAttributeItem>d__11>(ref <CreateSubAttributeItem>d__);
		return <CreateSubAttributeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0601020F RID: 66063 RVA: 0x003ED4A0 File Offset: 0x003EB6A0
	private UniTask CreateVisionFetterSuitItem()
	{
		PhantomTipsView.<CreateVisionFetterSuitItem>d__12 <CreateVisionFetterSuitItem>d__;
		<CreateVisionFetterSuitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateVisionFetterSuitItem>d__.<>4__this = this;
		<CreateVisionFetterSuitItem>d__.<>1__state = -1;
		<CreateVisionFetterSuitItem>d__.<>t__builder.Start<PhantomTipsView.<CreateVisionFetterSuitItem>d__12>(ref <CreateVisionFetterSuitItem>d__);
		return <CreateVisionFetterSuitItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010210 RID: 66064 RVA: 0x003ED4E4 File Offset: 0x003EB6E4
	private UniTask CreateStateItem()
	{
		PhantomTipsView.<CreateStateItem>d__13 <CreateStateItem>d__;
		<CreateStateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateStateItem>d__.<>4__this = this;
		<CreateStateItem>d__.<>1__state = -1;
		<CreateStateItem>d__.<>t__builder.Start<PhantomTipsView.<CreateStateItem>d__13>(ref <CreateStateItem>d__);
		return <CreateStateItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010211 RID: 66065 RVA: 0x003ED528 File Offset: 0x003EB728
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomTipsView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomTipsView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010212 RID: 66066 RVA: 0x003ED56C File Offset: 0x003EB76C
	protected override void OnStart()
	{
		int? num = this.OpenParam as int?;
		if (num == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.BB, "PhantomTipsView无效输入", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(num.Value);
		if (phantomDataBase == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.BB;
			string message = "PhantomTipsView无效uniqueId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uniqueId", num.Value);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.CloseMe(null);
			return;
		}
		this.RefreshUi(phantomDataBase);
		this.RefreshState(phantomDataBase);
		string text = this.IsGolden ? "Golden" : "Start01";
		this.UiViewSequence.StartSequenceName = text;
		this.UiViewSequence.AddSequenceFinishEvent(text, new Action<string>(this.OnViewShowSequenceFinish), false);
	}

	// Token: 0x06010213 RID: 66067 RVA: 0x003ED650 File Offset: 0x003EB850
	private void RefreshUi(PhantomDataBase phantomData)
	{
		QualityInfo value = ItemConfig.Instance.GetQualityConfig(phantomData.GetQuality()).Value;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, phantomData.GetMonsterName(), Array.Empty<object>());
		base.GetText(1).SetText(phantomData.GetCost().ToString(), true);
		this.VisionItem.RefreshByData(phantomData.GetConfigId(true));
		base.SetTextureByPath(value.TextureAcquireBg, base.GetTexture(3), null, null);
		base.SetTextureByPath(value.TextureAcquireFlow, base.GetTexture(11), null, null);
		this.IsGolden = (value.Id == 5);
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(phantomData.GetFetterGroupId());
		this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
		this.RefreshAttribute(phantomData);
		this.RefreshNiagara(value);
	}

	// Token: 0x06010214 RID: 66068 RVA: 0x003ED744 File Offset: 0x003EB944
	private void RefreshState(PhantomDataBase phantomData)
	{
		bool isLock = phantomData.GetIsLock();
		bool isDeprecated = phantomData.GetIsDeprecated();
		this.StateItem.SetLock(new bool?(isLock));
		this.StateItem.SetDeprecate(new bool?(isDeprecated));
		base.GetButton(8).SetSelfInteractive(true);
	}

	// Token: 0x06010215 RID: 66069 RVA: 0x003ED790 File Offset: 0x003EB990
	private void RefreshAttribute(PhantomDataBase phantomData)
	{
		List<AttrListScrollData> mainPropShowAttributeList = phantomData.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false);
		if (mainPropShowAttributeList == null || mainPropShowAttributeList.Count < 2)
		{
			return;
		}
		this.MainAttributeItem.RefreshUi(mainPropShowAttributeList[0]);
		this.SubMainAttributeItem.RefreshUi(mainPropShowAttributeList[1]);
	}

	// Token: 0x06010216 RID: 66070 RVA: 0x003ED7D8 File Offset: 0x003EB9D8
	private void RefreshNiagara(QualityInfo qualityInfo)
	{
		FColor color = FColor.FromHex(qualityInfo.TextColor);
		this.IsGolden = (qualityInfo.Id == 5);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.IsGolden ? "NS_Fx_LGUI_Item_Golden" : "NS_Fx_LGUI_Item_Other");
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(resourcePath, delegate([Nullable(2)] UNiagaraSystem niagaraSystem, string _)
		{
			if (niagaraSystem == null || !UiManager.Instance.IsViewOpen(EUiViewName.PhantomTipsView) || this.RootItem == null)
			{
				return;
			}
			UUINiagara uiNiagara = this.GetUiNiagara(7);
			uiNiagara.SetNiagaraSystem(niagaraSystem);
			if (!this.IsGolden)
			{
				uiNiagara.ColorParameter.Get("Color").Constant = FLinearColor.FromSRGBColor(color);
			}
		}, 100, this.MemoryTag);
	}

	// Token: 0x06010217 RID: 66071 RVA: 0x003ED853 File Offset: 0x003EBA53
	private void OnViewShowSequenceFinish(string _)
	{
		if (base.IsPendingDestroy)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06010218 RID: 66072 RVA: 0x003ED865 File Offset: 0x003EBA65
	protected override void OnBeforeDestroy()
	{
		ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x0400775D RID: 30557
	private bool IsGolden;

	// Token: 0x0400775E RID: 30558
	[Nullable(2)]
	private PhantomTipsAttributeItem MainAttributeItem;

	// Token: 0x0400775F RID: 30559
	[Nullable(2)]
	private PhantomTipsAttributeItem SubMainAttributeItem;

	// Token: 0x04007760 RID: 30560
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x04007761 RID: 30561
	[Nullable(2)]
	private MediumItemGridLevelAndLockComponent StateItem;

	// Token: 0x04007762 RID: 30562
	[Nullable(2)]
	private VisionGridItem VisionItem;

	// Token: 0x02008618 RID: 34328
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402BA30 RID: 178736
		PhantomName,
		// Token: 0x0402BA31 RID: 178737
		PhantomCost,
		// Token: 0x0402BA32 RID: 178738
		VisionItem,
		// Token: 0x0402BA33 RID: 178739
		QualityTexture,
		// Token: 0x0402BA34 RID: 178740
		ElementItem,
		// Token: 0x0402BA35 RID: 178741
		MainAttributeItem,
		// Token: 0x0402BA36 RID: 178742
		SubAttributeItem,
		// Token: 0x0402BA37 RID: 178743
		Niagara,
		// Token: 0x0402BA38 RID: 178744
		BtnClick,
		// Token: 0x0402BA39 RID: 178745
		PanelTips,
		// Token: 0x0402BA3A RID: 178746
		ItemState,
		// Token: 0x0402BA3B RID: 178747
		FlowTexture
	}
}
