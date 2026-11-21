using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014F9 RID: 5369
[NullableContext(1)]
[Nullable(0)]
public class PhantomTipsView : UiViewBase
{
	// Token: 0x0600D672 RID: 54898 RVA: 0x003F989C File Offset: 0x003F7A9C
	public PhantomTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D673 RID: 54899 RVA: 0x003F98A8 File Offset: 0x003F7AA8
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

	// Token: 0x0600D674 RID: 54900 RVA: 0x003F99CC File Offset: 0x003F7BCC
	private UniTask CreateVisionItem()
	{
		PhantomTipsView.<CreateVisionItem>d__9 <CreateVisionItem>d__;
		<CreateVisionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateVisionItem>d__.<>4__this = this;
		<CreateVisionItem>d__.<>1__state = -1;
		<CreateVisionItem>d__.<>t__builder.Start<PhantomTipsView.<CreateVisionItem>d__9>(ref <CreateVisionItem>d__);
		return <CreateVisionItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D675 RID: 54901 RVA: 0x003F9A10 File Offset: 0x003F7C10
	private UniTask CreateMainAttributeItem()
	{
		PhantomTipsView.<CreateMainAttributeItem>d__10 <CreateMainAttributeItem>d__;
		<CreateMainAttributeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMainAttributeItem>d__.<>4__this = this;
		<CreateMainAttributeItem>d__.<>1__state = -1;
		<CreateMainAttributeItem>d__.<>t__builder.Start<PhantomTipsView.<CreateMainAttributeItem>d__10>(ref <CreateMainAttributeItem>d__);
		return <CreateMainAttributeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D676 RID: 54902 RVA: 0x003F9A54 File Offset: 0x003F7C54
	private UniTask CreateSubAttributeItem()
	{
		PhantomTipsView.<CreateSubAttributeItem>d__11 <CreateSubAttributeItem>d__;
		<CreateSubAttributeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSubAttributeItem>d__.<>4__this = this;
		<CreateSubAttributeItem>d__.<>1__state = -1;
		<CreateSubAttributeItem>d__.<>t__builder.Start<PhantomTipsView.<CreateSubAttributeItem>d__11>(ref <CreateSubAttributeItem>d__);
		return <CreateSubAttributeItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D677 RID: 54903 RVA: 0x003F9A98 File Offset: 0x003F7C98
	private UniTask CreateVisionFetterSuitItem()
	{
		PhantomTipsView.<CreateVisionFetterSuitItem>d__12 <CreateVisionFetterSuitItem>d__;
		<CreateVisionFetterSuitItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateVisionFetterSuitItem>d__.<>4__this = this;
		<CreateVisionFetterSuitItem>d__.<>1__state = -1;
		<CreateVisionFetterSuitItem>d__.<>t__builder.Start<PhantomTipsView.<CreateVisionFetterSuitItem>d__12>(ref <CreateVisionFetterSuitItem>d__);
		return <CreateVisionFetterSuitItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D678 RID: 54904 RVA: 0x003F9ADC File Offset: 0x003F7CDC
	private UniTask CreateStateItem()
	{
		PhantomTipsView.<CreateStateItem>d__13 <CreateStateItem>d__;
		<CreateStateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateStateItem>d__.<>4__this = this;
		<CreateStateItem>d__.<>1__state = -1;
		<CreateStateItem>d__.<>t__builder.Start<PhantomTipsView.<CreateStateItem>d__13>(ref <CreateStateItem>d__);
		return <CreateStateItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D679 RID: 54905 RVA: 0x003F9B20 File Offset: 0x003F7D20
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomTipsView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomTipsView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D67A RID: 54906 RVA: 0x003F9B64 File Offset: 0x003F7D64
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

	// Token: 0x0600D67B RID: 54907 RVA: 0x003F9C48 File Offset: 0x003F7E48
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

	// Token: 0x0600D67C RID: 54908 RVA: 0x003F9D3C File Offset: 0x003F7F3C
	private void RefreshState(PhantomDataBase phantomData)
	{
		bool isLock = phantomData.GetIsLock();
		bool isDeprecated = phantomData.GetIsDeprecated();
		this.StateItem.SetLock(new bool?(isLock));
		this.StateItem.SetDeprecate(new bool?(isDeprecated));
		base.GetButton(8).SetSelfInteractive(true);
	}

	// Token: 0x0600D67D RID: 54909 RVA: 0x003F9D88 File Offset: 0x003F7F88
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

	// Token: 0x0600D67E RID: 54910 RVA: 0x003F9DD0 File Offset: 0x003F7FD0
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

	// Token: 0x0600D67F RID: 54911 RVA: 0x003F9E4B File Offset: 0x003F804B
	private void OnViewShowSequenceFinish(string _)
	{
		if (base.IsPendingDestroy)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D680 RID: 54912 RVA: 0x003F9E5D File Offset: 0x003F805D
	protected override void OnBeforeDestroy()
	{
		ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x04007846 RID: 30790
	private bool IsGolden;

	// Token: 0x04007847 RID: 30791
	[Nullable(2)]
	private PhantomTipsAttributeItem MainAttributeItem;

	// Token: 0x04007848 RID: 30792
	[Nullable(2)]
	private PhantomTipsAttributeItem SubMainAttributeItem;

	// Token: 0x04007849 RID: 30793
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x0400784A RID: 30794
	[Nullable(2)]
	private MediumItemGridLevelAndLockComponent StateItem;

	// Token: 0x0400784B RID: 30795
	[Nullable(2)]
	private VisionGridItem VisionItem;

	// Token: 0x0200779F RID: 30623
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026D3F RID: 159039
		PhantomName,
		// Token: 0x04026D40 RID: 159040
		PhantomCost,
		// Token: 0x04026D41 RID: 159041
		VisionItem,
		// Token: 0x04026D42 RID: 159042
		QualityTexture,
		// Token: 0x04026D43 RID: 159043
		ElementItem,
		// Token: 0x04026D44 RID: 159044
		MainAttributeItem,
		// Token: 0x04026D45 RID: 159045
		SubAttributeItem,
		// Token: 0x04026D46 RID: 159046
		Niagara,
		// Token: 0x04026D47 RID: 159047
		BtnClick,
		// Token: 0x04026D48 RID: 159048
		PanelTips,
		// Token: 0x04026D49 RID: 159049
		ItemState,
		// Token: 0x04026D4A RID: 159050
		FlowTexture
	}
}
