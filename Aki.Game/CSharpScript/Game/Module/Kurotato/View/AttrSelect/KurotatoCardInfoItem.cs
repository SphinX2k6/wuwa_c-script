using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Kurotato.View.PopupItemDetail;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005778 RID: 22392
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCardInfoItem : UiPanelBase
	{
		// Token: 0x06038E28 RID: 233000 RVA: 0x00D845D4 File Offset: 0x00D827D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 31;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleClickLock));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(29, new Action<EToggleState>(this.OnTogglePreviewState));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038E29 RID: 233001 RVA: 0x00D84A74 File Offset: 0x00D82C74
		protected override void OnStart()
		{
			this.CreateAttrMultiScrollView();
			this.CreateBuildInfoPanel();
			this.RegisterTextPropTermExplanation();
			this.CloseBuildInfo();
			UUIExtendToggle extendToggle = base.GetExtendToggle(29);
			if (extendToggle != null)
			{
				extendToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPreviewHoverEnter));
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPreviewHoverExit));
		}

		// Token: 0x06038E2A RID: 233002 RVA: 0x00D84AD9 File Offset: 0x00D82CD9
		protected override void OnBeforeDestroy()
		{
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x06038E2B RID: 233003 RVA: 0x00D84AF4 File Offset: 0x00D82CF4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoCardInfoItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoCardInfoItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E2C RID: 233004 RVA: 0x00D84B38 File Offset: 0x00D82D38
		private void RegisterTextPropTermExplanation()
		{
			TermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(3),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Kurotato
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x06038E2D RID: 233005 RVA: 0x00D84B74 File Offset: 0x00D82D74
		private UniTask CreateBuildTagItem()
		{
			KurotatoCardInfoItem.<CreateBuildTagItem>d__16 <CreateBuildTagItem>d__;
			<CreateBuildTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildTagItem>d__.<>4__this = this;
			<CreateBuildTagItem>d__.<>1__state = -1;
			<CreateBuildTagItem>d__.<>t__builder.Start<KurotatoCardInfoItem.<CreateBuildTagItem>d__16>(ref <CreateBuildTagItem>d__);
			return <CreateBuildTagItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038E2E RID: 233006 RVA: 0x00D84BB7 File Offset: 0x00D82DB7
		private void CreateAttrMultiScrollView()
		{
			this.AttrMultiScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(4));
		}

		// Token: 0x06038E2F RID: 233007 RVA: 0x00D84BCC File Offset: 0x00D82DCC
		private void CreateBuildInfoPanel()
		{
			this.BuildLeftInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(13), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
			this.BuildRightInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(14), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
		}

		// Token: 0x06038E30 RID: 233008 RVA: 0x00D84C43 File Offset: 0x00D82E43
		public void Refresh(IKurotatoCardItemData data)
		{
			this.Data = data;
			if (data.CardType == EKurotatoCardType.Weapon)
			{
				this.RefreshWeaponData();
				return;
			}
			this.RefreshItemInfo();
		}

		// Token: 0x06038E31 RID: 233009 RVA: 0x00D84C61 File Offset: 0x00D82E61
		public void SetLockToggleCb(Action<int, bool> cb)
		{
			this.LockToggleCb = cb;
		}

		// Token: 0x06038E32 RID: 233010 RVA: 0x00D84C6A File Offset: 0x00D82E6A
		public void SetBuildTagClickCb(Action<EToggleState> cb)
		{
			this.BuildTagClickCb = cb;
		}

		// Token: 0x06038E33 RID: 233011 RVA: 0x00D84C73 File Offset: 0x00D82E73
		public void SetAttrPreviewCb(Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x06038E34 RID: 233012 RVA: 0x00D84C7C File Offset: 0x00D82E7C
		public void ClearAttrPreviewSelection()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(29);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038E35 RID: 233013 RVA: 0x00D84C94 File Offset: 0x00D82E94
		private void OnTogglePreviewState(EToggleState state)
		{
			if (!Info.Instance.IsInTouch())
			{
				return;
			}
			if (state == EToggleState.ETT_Checked)
			{
				Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
				if (attrPreviewCb == null)
				{
					return;
				}
				attrPreviewCb(true, this.BuildPreviewDeltas());
				return;
			}
			else
			{
				Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb2 = this.AttrPreviewCb;
				if (attrPreviewCb2 == null)
				{
					return;
				}
				attrPreviewCb2(false, new List<IKurotatoAttrPreviewDelta>());
				return;
			}
		}

		// Token: 0x06038E36 RID: 233014 RVA: 0x00D84CE0 File Offset: 0x00D82EE0
		private void OnPreviewHoverEnter(EToggleState state)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(true, this.BuildPreviewDeltas());
		}

		// Token: 0x06038E37 RID: 233015 RVA: 0x00D84D06 File Offset: 0x00D82F06
		private void OnPreviewHoverExit(EToggleState state)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x06038E38 RID: 233016 RVA: 0x00D84D2C File Offset: 0x00D82F2C
		private IReadOnlyList<IKurotatoAttrPreviewDelta> BuildPreviewDeltas()
		{
			List<IKurotatoAttrPreviewDelta> list = new List<IKurotatoAttrPreviewDelta>();
			if (this.Data == null || this.Data.CardType == EKurotatoCardType.Weapon)
			{
				return list;
			}
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(this.Data.Id);
			if (itemConfigByItemId == null)
			{
				return list;
			}
			foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in KurotatoUtil.GetItemAttrPreviewList(itemConfigByItemId.Value.EffectIter().ToList<int>()))
			{
				list.Add(new KurotatoAttrPreviewDelta
				{
					PropertyId = kurotatoAttrDisplay.PropertyId,
					ValueStr = kurotatoAttrDisplay.Text
				});
			}
			foreach (ValueTuple<int, int> valueTuple in KurotatoUtil.GetItemAttrLockPreviewList(itemConfigByItemId.Value.EffectIter().ToList<int>()))
			{
				list.Add(new KurotatoAttrPreviewDelta
				{
					PropertyId = valueTuple.Item1,
					ValueStr = "",
					LockValue = new int?(valueTuple.Item2)
				});
			}
			return list;
		}

		// Token: 0x06038E39 RID: 233017 RVA: 0x00D84E78 File Offset: 0x00D83078
		private void RefreshItemInfo()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoItem value = instance.GetItemConfigByItemId(this.Data.Id).Value;
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(value.EffectIter().ToList<int>(), true, true, false);
			string cardDesc = KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false);
			this.AttrScrollDataList.Clear();
			foreach (IKurotatoAttrDisplay data in itemAttrDisplayList)
			{
				this.AttrScrollDataList.Add(new AttrInfoItemData(data));
			}
			this.AttrScrollDataList.Add(new DesItemData(cardDesc));
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.AttrScrollDataList);
			this.AttrMultiScrollView.RefreshByData(context);
			this.BuildTagItem.SetUiActive(false);
			bool flag = !StringUtils.IsEmpty(value.Tag);
			base.GetItem(10).SetUIActive(flag);
			base.GetItem(11).SetUIActive(this.Data.HasBuy);
			base.GetSprite(23).SetUIActive(this.Data.HasBuy);
			base.GetText(3).SetUIActive(true);
			base.GetItem(17).SetUIActive(itemAttrDisplayList.Count == 0);
			UUIItem uuiitem = base.GetMultiTemplateScrollViewComponent(4).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(itemAttrDisplayList.Count > 0);
			}
			KurotatoQuality value2 = instance.GetQualityByQuality(value.Quality).Value;
			base.SetTextureByPath(value2.CardQualityTexture, base.GetTexture(0), null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
			base.GetSprite(20).SetColor(FColor.FromHex(value2.QualityBoxColor));
			UUINiagara uiNiagara = base.GetUiNiagara(24);
			if (uiNiagara != null)
			{
				uiNiagara.SetColor(FColor.FromHex(value2.ItemGridNiagaraColor));
			}
			base.GetText(2).ShowTextNew(value.Name);
			base.GetText(2).SetColor(FColor.FromHex(value2.QualityColor));
			base.GetText(3).SetText(KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false), true);
			if (flag)
			{
				base.GetText(12).ShowTextNew(value.Tag);
			}
			base.GetItem(6).SetUIActive(this.Data.IsRecommend);
			base.GetExtendToggle(7).GetRootComponent().SetUIActive(this.Data.ShowLock && !this.Data.HasBuy);
			base.GetExtendToggle(7).SetToggleState(this.Data.HasLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
			this.RefreshHoldNum();
			base.GetSprite(25).SetUIActive(false);
			base.GetItem(26).SetUIActive(false);
		}

		// Token: 0x06038E3A RID: 233018 RVA: 0x00D85188 File Offset: 0x00D83388
		public void RefreshHoldNum()
		{
			if (this.Data == null || this.Data.CardType == EKurotatoCardType.Weapon)
			{
				return;
			}
			KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(this.Data.Id);
			if (itemConfigByItemId == null)
			{
				return;
			}
			int holdItemCount = KurotatoModel.Instance.GetHoldItemCount(itemConfigByItemId.Value.Id);
			base.GetItem(22).SetUIActive(itemConfigByItemId.Value.MaxStackCount < 999);
			UUIText text = base.GetText(21);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(holdItemCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemConfigByItemId.Value.MaxStackCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06038E3B RID: 233019 RVA: 0x00D85250 File Offset: 0x00D83450
		private void RefreshWeaponData()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoWeapon value = instance.GetWeaponConfigByWeaponId(this.Data.Id).Value;
			KurotatoWeaponGroup value2 = instance.GetWeaponGroupConfigByWeaponId(this.Data.Id).Value;
			bool flag = value2.WeaponBuildIdsIter().Any<int>();
			this.BuildTagItem.SetUiActive(flag);
			base.GetItem(10).SetUIActive(false);
			base.GetItem(11).SetUIActive(this.Data.HasBuy);
			base.GetSprite(23).SetUIActive(this.Data.HasBuy);
			base.GetText(3).SetUIActive(true);
			base.GetItem(17).SetUIActive(false);
			UUIItem uuiitem = base.GetMultiTemplateScrollViewComponent(4).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
			KurotatoQuality value3 = instance.GetQualityByQuality(value.Quality).Value;
			base.SetTextureByPath(value3.CardQualityTexture, base.GetTexture(0), null, null);
			base.SetTextureByPath(value2.Icon, base.GetTexture(1), null, null);
			base.GetSprite(20).SetColor(FColor.FromHex(value3.QualityBoxColor));
			UUINiagara uiNiagara = base.GetUiNiagara(24);
			if (uiNiagara != null)
			{
				uiNiagara.SetColor(FColor.FromHex(value3.ItemGridNiagaraColor));
			}
			base.GetText(2).ShowTextNew(value.Name);
			base.GetText(2).SetColor(FColor.FromHex(value3.QualityColor));
			base.GetText(3).SetText(KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false), true);
			base.GetItem(6).SetUIActive(this.Data.IsRecommend);
			base.GetExtendToggle(7).GetRootComponent().SetUIActive(this.Data.ShowLock && !this.Data.HasBuy);
			base.GetExtendToggle(7).SetToggleState(this.Data.HasLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
			base.GetItem(22).SetUIActive(false);
			int id = this.Data.Id;
			List<IKurotatoAttrDisplay> weaponPropertyDisplayList = KurotatoUtil.GetWeaponPropertyDisplayList(value.ShowPropertyIter().ToList<int>(), id, 0);
			if (!string.IsNullOrEmpty(value.AttackDes))
			{
				string cardDesc = KurotatoUtil.GetCardDesc(value.AttackDes, value.AttackDesParamIter().ToList<string>(), id, 0, true);
				KurotatoProperty? propertyById = instance.GetPropertyById(7);
				weaponPropertyDisplayList.Insert(0, new KurotatoAttrDisplay
				{
					Icon = (((propertyById != null) ? propertyById.GetValueOrDefault().Icon : null) ?? ""),
					Text = cardDesc,
					PropertyId = ((propertyById != null) ? propertyById.GetValueOrDefault().Id : 0)
				});
			}
			this.AttrScrollDataList.Clear();
			foreach (IKurotatoAttrDisplay data in weaponPropertyDisplayList)
			{
				this.AttrScrollDataList.Add(new WeaponAttrInfoItemData(data));
			}
			string cardDesc2 = KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), id, 0, false);
			this.AttrScrollDataList.Add(new DesItemData(cardDesc2));
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.AttrScrollDataList);
			this.AttrMultiScrollView.RefreshByData(context);
			this.CloseBuildInfo();
			List<IKurotatoWeaponBuildData> list = new List<IKurotatoWeaponBuildData>();
			foreach (int buildId in value2.WeaponBuildIdsIter())
			{
				list.Add(new KurotatoWeaponBuildData
				{
					BuildId = buildId,
					WeaponId = this.Data.Id
				});
			}
			this.BuildTagItem.SetChecked(false);
			if (flag)
			{
				this.BuildTagItem.Refresh(list);
			}
			this.SetComposeUpgradeVisible(false);
			base.GetItem(26).SetUIActive(true);
			UUISprite sprite = base.GetSprite(27);
			UUISprite sprite2 = base.GetSprite(28);
			UUIItem uuiitem2 = sprite;
			bool hasBuy = this.Data.HasBuy;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(hasBuy, fcolor);
			UUIItem uuiitem3 = sprite2;
			bool hasBuy2 = this.Data.HasBuy;
			fcolor = new FColor?(sprite2.changeColor);
			uuiitem3.SetChangeColor(hasBuy2, fcolor);
		}

		// Token: 0x06038E3C RID: 233020 RVA: 0x00D856DC File Offset: 0x00D838DC
		public void SetComposeUpgradeVisible(bool visible)
		{
			base.GetSprite(25).SetUIActive(visible);
		}

		// Token: 0x06038E3D RID: 233021 RVA: 0x00D856EC File Offset: 0x00D838EC
		public void RefreshBuildTagLevel()
		{
			if (this.Data == null || this.Data.CardType != EKurotatoCardType.Weapon)
			{
				return;
			}
			KurotatoWeaponGroup? weaponGroupConfigByWeaponId = KurotatoConfig.Instance.GetWeaponGroupConfigByWeaponId(this.Data.Id);
			if (weaponGroupConfigByWeaponId == null || !weaponGroupConfigByWeaponId.Value.WeaponBuildIdsIter().Any<int>())
			{
				return;
			}
			List<IKurotatoWeaponBuildData> list = new List<IKurotatoWeaponBuildData>();
			foreach (int buildId in weaponGroupConfigByWeaponId.Value.WeaponBuildIdsIter())
			{
				list.Add(new KurotatoWeaponBuildData
				{
					BuildId = buildId,
					WeaponId = this.Data.Id
				});
			}
			this.BuildTagItem.Refresh(list);
			this.RefreshBuildInfoByCheckedTags();
		}

		// Token: 0x06038E3E RID: 233022 RVA: 0x00D857C4 File Offset: 0x00D839C4
		public void RefreshBuildInfoByCheckedTags()
		{
			if (this.Data.CardType != EKurotatoCardType.Weapon)
			{
				return;
			}
			if (!this.BuildTagItem.IsChecked())
			{
				this.CloseBuildInfo();
				return;
			}
			List<IKurotatoWeaponBuildData> dataList = this.BuildTagItem.GetDataList();
			if (dataList == null || dataList.Count == 0)
			{
				this.CloseBuildInfo();
				return;
			}
			KurotatoModel instance = KurotatoModel.Instance;
			List<IKurotatoWeaponBuildInfoPanel> list = new List<IKurotatoWeaponBuildInfoPanel>();
			foreach (IKurotatoWeaponBuildData kurotatoWeaponBuildData in dataList)
			{
				list.Add(new KurotatoWeaponBuildInfoPanel
				{
					BuildId = kurotatoWeaponBuildData.BuildId,
					BuildLevel = instance.GetWeaponBuildLevelByBuildId(kurotatoWeaponBuildData.BuildId)
				});
			}
			this.ShowBuildInfoLeft(list);
		}

		// Token: 0x06038E3F RID: 233023 RVA: 0x00D8588C File Offset: 0x00D83A8C
		public void ClearBuildTagSelection()
		{
			this.BuildTagItem.SetChecked(false);
			this.CloseBuildInfo();
		}

		// Token: 0x06038E40 RID: 233024 RVA: 0x00D858A0 File Offset: 0x00D83AA0
		private void OnClickBuildTag(List<IKurotatoWeaponBuildData> dataList, EToggleState state)
		{
			this.RefreshBuildInfoByCheckedTags();
			Action<EToggleState> buildTagClickCb = this.BuildTagClickCb;
			if (buildTagClickCb == null)
			{
				return;
			}
			buildTagClickCb(state);
		}

		// Token: 0x06038E41 RID: 233025 RVA: 0x00D858B9 File Offset: 0x00D83AB9
		public void ShowBuildInfoLeft(List<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildLeftInfoLayout.SetActive(true);
			this.BuildRightInfoLayout.SetActive(false);
			this.BuildLeftInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06038E42 RID: 233026 RVA: 0x00D858E1 File Offset: 0x00D83AE1
		public void ShowBuildInfoRight(List<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildRightInfoLayout.SetActive(true);
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06038E43 RID: 233027 RVA: 0x00D85909 File Offset: 0x00D83B09
		public void CloseBuildInfo()
		{
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.SetActive(false);
		}

		// Token: 0x06038E44 RID: 233028 RVA: 0x00D85923 File Offset: 0x00D83B23
		private void OnToggleClickLock(EToggleState state)
		{
			Action<int, bool> lockToggleCb = this.LockToggleCb;
			if (lockToggleCb == null)
			{
				return;
			}
			lockToggleCb(this.Data.SelectionId, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06038E45 RID: 233029 RVA: 0x00D85944 File Offset: 0x00D83B44
		public bool HasBuildTag()
		{
			if (this.Data == null || this.Data.CardType != EKurotatoCardType.Weapon)
			{
				return false;
			}
			KurotatoWeaponGroup? weaponGroupConfigByWeaponId = KurotatoConfig.Instance.GetWeaponGroupConfigByWeaponId(this.Data.Id);
			return weaponGroupConfigByWeaponId != null && weaponGroupConfigByWeaponId.Value.WeaponBuildIdsIter().Any<int>();
		}

		// Token: 0x06038E46 RID: 233030 RVA: 0x00D859A0 File Offset: 0x00D83BA0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "ShopRecommend")
			{
				UUIItem item = base.GetItem(6);
				if (item == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					item,
					item
				};
			}
			else if (a == "ShopCardLock")
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(7);
				UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else if (a == "ShopBuildTag")
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(9);
				UUIItem uuiitem2 = (extendToggle2 != null) ? extendToggle2.GetRootComponent() : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else
			{
				if (!(a == "ShopCardDes"))
				{
					return null;
				}
				UUIItem item2 = base.GetItem(30);
				if (item2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					item2,
					item2
				};
			}
		}

		// Token: 0x0401DD46 RID: 122182
		private const int INFINITE_STACK_COUNT = 999;

		// Token: 0x0401DD47 RID: 122183
		[Nullable(2)]
		private IKurotatoCardItemData Data;

		// Token: 0x0401DD48 RID: 122184
		[Nullable(2)]
		private MultiTemplateScrollView AttrMultiScrollView;

		// Token: 0x0401DD49 RID: 122185
		private readonly List<IMultiTemplateGridData> AttrScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401DD4A RID: 122186
		private readonly KurotatoWeaponTagItem BuildTagItem = new KurotatoWeaponTagItem();

		// Token: 0x0401DD4B RID: 122187
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildLeftInfoLayout;

		// Token: 0x0401DD4C RID: 122188
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildRightInfoLayout;

		// Token: 0x0401DD4D RID: 122189
		[Nullable(2)]
		private Action<int, bool> LockToggleCb;

		// Token: 0x0401DD4E RID: 122190
		[Nullable(2)]
		private Action<EToggleState> BuildTagClickCb;

		// Token: 0x0401DD4F RID: 122191
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200B992 RID: 47506
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x040381BF RID: 229823
			public const int TextureQuality = 0;

			// Token: 0x040381C0 RID: 229824
			public const int TextureIcon = 1;

			// Token: 0x040381C1 RID: 229825
			public const int TextName = 2;

			// Token: 0x040381C2 RID: 229826
			public const int TextProp = 3;

			// Token: 0x040381C3 RID: 229827
			public const int MultiTemplateScrollViewInfo = 4;

			// Token: 0x040381C4 RID: 229828
			public const int PanelItemAttr = 5;

			// Token: 0x040381C5 RID: 229829
			public const int PanelRecommend = 6;

			// Token: 0x040381C6 RID: 229830
			public const int ToggleLock = 7;

			// Token: 0x040381C7 RID: 229831
			public const int PanelTag = 8;

			// Token: 0x040381C8 RID: 229832
			public const int ToggleTag = 9;

			// Token: 0x040381C9 RID: 229833
			public const int PanelType = 10;

			// Token: 0x040381CA RID: 229834
			public const int PanelDone = 11;

			// Token: 0x040381CB RID: 229835
			public const int TextType = 12;

			// Token: 0x040381CC RID: 229836
			public const int VerticalTipsLeft = 13;

			// Token: 0x040381CD RID: 229837
			public const int VerticalTipsRight = 14;

			// Token: 0x040381CE RID: 229838
			public const int PanelTipsLeft = 15;

			// Token: 0x040381CF RID: 229839
			public const int PanelTipsRight = 16;

			// Token: 0x040381D0 RID: 229840
			public const int PanelDes = 17;

			// Token: 0x040381D1 RID: 229841
			public const int PanelWeaponAttr = 18;

			// Token: 0x040381D2 RID: 229842
			public const int PanelInfoDes = 19;

			// Token: 0x040381D3 RID: 229843
			public const int SpriteItemBg = 20;

			// Token: 0x040381D4 RID: 229844
			public const int TextLimitNum = 21;

			// Token: 0x040381D5 RID: 229845
			public const int PanelLimitNum = 22;

			// Token: 0x040381D6 RID: 229846
			public const int SpriteDone = 23;

			// Token: 0x040381D7 RID: 229847
			public const int NiagaraFxGlow = 24;

			// Token: 0x040381D8 RID: 229848
			public const int SpriteUpgrade = 25;

			// Token: 0x040381D9 RID: 229849
			public const int PanelWeaponTag = 26;

			// Token: 0x040381DA RID: 229850
			public const int SpriteWeaponTagBg = 27;

			// Token: 0x040381DB RID: 229851
			public const int SpriteWeaponTagIcon = 28;

			// Token: 0x040381DC RID: 229852
			public const int TogglePreview = 29;

			// Token: 0x040381DD RID: 229853
			public const int DescriptionItem = 30;
		}
	}
}
