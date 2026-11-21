using System;
using System.Collections.Generic;
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
	// Token: 0x0200474F RID: 18255
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCardInfoItem : UiPanelBase
	{
		// Token: 0x0602DD38 RID: 187704 RVA: 0x00CD31F8 File Offset: 0x00CD13F8
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

		// Token: 0x0602DD39 RID: 187705 RVA: 0x00CD3698 File Offset: 0x00CD1898
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

		// Token: 0x0602DD3A RID: 187706 RVA: 0x00CD36FD File Offset: 0x00CD18FD
		protected override void OnBeforeDestroy()
		{
			Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> attrPreviewCb = this.AttrPreviewCb;
			if (attrPreviewCb == null)
			{
				return;
			}
			attrPreviewCb(false, new List<IKurotatoAttrPreviewDelta>());
		}

		// Token: 0x0602DD3B RID: 187707 RVA: 0x00CD3718 File Offset: 0x00CD1918
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoCardInfoItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoCardInfoItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD3C RID: 187708 RVA: 0x00CD375C File Offset: 0x00CD195C
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

		// Token: 0x0602DD3D RID: 187709 RVA: 0x00CD3798 File Offset: 0x00CD1998
		private UniTask CreateBuildTagItem()
		{
			KurotatoCardInfoItem.<CreateBuildTagItem>d__16 <CreateBuildTagItem>d__;
			<CreateBuildTagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildTagItem>d__.<>4__this = this;
			<CreateBuildTagItem>d__.<>1__state = -1;
			<CreateBuildTagItem>d__.<>t__builder.Start<KurotatoCardInfoItem.<CreateBuildTagItem>d__16>(ref <CreateBuildTagItem>d__);
			return <CreateBuildTagItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602DD3E RID: 187710 RVA: 0x00CD37DB File Offset: 0x00CD19DB
		private void CreateAttrMultiScrollView()
		{
			this.AttrMultiScrollView = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(4));
		}

		// Token: 0x0602DD3F RID: 187711 RVA: 0x00CD37F0 File Offset: 0x00CD19F0
		private void CreateBuildInfoPanel()
		{
			this.BuildLeftInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(13), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
			this.BuildRightInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(14), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
		}

		// Token: 0x0602DD40 RID: 187712 RVA: 0x00CD3867 File Offset: 0x00CD1A67
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

		// Token: 0x0602DD41 RID: 187713 RVA: 0x00CD3885 File Offset: 0x00CD1A85
		public void SetLockToggleCb(Action<int, bool> cb)
		{
			this.LockToggleCb = cb;
		}

		// Token: 0x0602DD42 RID: 187714 RVA: 0x00CD388E File Offset: 0x00CD1A8E
		public void SetBuildTagClickCb(Action<EToggleState> cb)
		{
			this.BuildTagClickCb = cb;
		}

		// Token: 0x0602DD43 RID: 187715 RVA: 0x00CD3897 File Offset: 0x00CD1A97
		public void SetAttrPreviewCb(Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> cb)
		{
			this.AttrPreviewCb = cb;
		}

		// Token: 0x0602DD44 RID: 187716 RVA: 0x00CD38A0 File Offset: 0x00CD1AA0
		public void ClearAttrPreviewSelection()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(29);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602DD45 RID: 187717 RVA: 0x00CD38B8 File Offset: 0x00CD1AB8
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

		// Token: 0x0602DD46 RID: 187718 RVA: 0x00CD3904 File Offset: 0x00CD1B04
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

		// Token: 0x0602DD47 RID: 187719 RVA: 0x00CD392A File Offset: 0x00CD1B2A
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

		// Token: 0x0602DD48 RID: 187720 RVA: 0x00CD3950 File Offset: 0x00CD1B50
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
			foreach (IKurotatoAttrDisplay kurotatoAttrDisplay in KurotatoUtil.GetItemAttrPreviewList(new List<int>(itemConfigByItemId.Value.EffectIter())))
			{
				list.Add(new KurotatoAttrPreviewDelta
				{
					PropertyId = kurotatoAttrDisplay.PropertyId,
					ValueStr = kurotatoAttrDisplay.Text
				});
			}
			foreach (ValueTuple<int, int> valueTuple in KurotatoUtil.GetItemAttrLockPreviewList(new List<int>(itemConfigByItemId.Value.EffectIter())))
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

		// Token: 0x0602DD49 RID: 187721 RVA: 0x00CD3A9C File Offset: 0x00CD1C9C
		private void RefreshItemInfo()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoItem value = instance.GetItemConfigByItemId(this.Data.Id).Value;
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(new List<int>(value.EffectIter()), true, true, false);
			string cardDesc = KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), 0, 0, false);
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
			base.GetText(3).SetText(KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), 0, 0, false), true);
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

		// Token: 0x0602DD4A RID: 187722 RVA: 0x00CD3DAC File Offset: 0x00CD1FAC
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

		// Token: 0x0602DD4B RID: 187723 RVA: 0x00CD3E74 File Offset: 0x00CD2074
		private void RefreshWeaponData()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoWeapon value = instance.GetWeaponConfigByWeaponId(this.Data.Id).Value;
			KurotatoWeaponGroup value2 = instance.GetWeaponGroupConfigByWeaponId(this.Data.Id).Value;
			bool flag = false;
			using (IEnumerator<int> enumerator = value2.WeaponBuildIdsIter().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					flag = true;
				}
			}
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
			base.GetText(3).SetText(KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), 0, 0, false), true);
			base.GetItem(6).SetUIActive(this.Data.IsRecommend);
			base.GetExtendToggle(7).GetRootComponent().SetUIActive(this.Data.ShowLock && !this.Data.HasBuy);
			base.GetExtendToggle(7).SetToggleState(this.Data.HasLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
			base.GetItem(22).SetUIActive(false);
			int id = this.Data.Id;
			List<IKurotatoAttrDisplay> weaponPropertyDisplayList = KurotatoUtil.GetWeaponPropertyDisplayList(new List<int>(value.ShowPropertyIter()), id, 0);
			if (!string.IsNullOrEmpty(value.AttackDes))
			{
				string cardDesc = KurotatoUtil.GetCardDesc(value.AttackDes, new List<string>(value.AttackDesParamIter()), id, 0, true);
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
			string cardDesc2 = KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), id, 0, false);
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

		// Token: 0x0602DD4C RID: 187724 RVA: 0x00CD4334 File Offset: 0x00CD2534
		public void SetComposeUpgradeVisible(bool visible)
		{
			base.GetSprite(25).SetUIActive(visible);
		}

		// Token: 0x0602DD4D RID: 187725 RVA: 0x00CD4344 File Offset: 0x00CD2544
		public void RefreshBuildTagLevel()
		{
			if (this.Data == null || this.Data.CardType != EKurotatoCardType.Weapon)
			{
				return;
			}
			KurotatoWeaponGroup? weaponGroupConfigByWeaponId = KurotatoConfig.Instance.GetWeaponGroupConfigByWeaponId(this.Data.Id);
			bool flag = false;
			if (weaponGroupConfigByWeaponId != null)
			{
				using (IEnumerator<int> enumerator = weaponGroupConfigByWeaponId.Value.WeaponBuildIdsIter().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						int num = enumerator.Current;
						flag = true;
					}
				}
			}
			if (!flag)
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

		// Token: 0x0602DD4E RID: 187726 RVA: 0x00CD4450 File Offset: 0x00CD2650
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

		// Token: 0x0602DD4F RID: 187727 RVA: 0x00CD4518 File Offset: 0x00CD2718
		public void ClearBuildTagSelection()
		{
			this.BuildTagItem.SetChecked(false);
			this.CloseBuildInfo();
		}

		// Token: 0x0602DD50 RID: 187728 RVA: 0x00CD452C File Offset: 0x00CD272C
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

		// Token: 0x0602DD51 RID: 187729 RVA: 0x00CD4545 File Offset: 0x00CD2745
		public void ShowBuildInfoLeft(List<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildLeftInfoLayout.SetActive(true);
			this.BuildRightInfoLayout.SetActive(false);
			this.BuildLeftInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602DD52 RID: 187730 RVA: 0x00CD456D File Offset: 0x00CD276D
		public void ShowBuildInfoRight(List<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildRightInfoLayout.SetActive(true);
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602DD53 RID: 187731 RVA: 0x00CD4595 File Offset: 0x00CD2795
		public void CloseBuildInfo()
		{
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.SetActive(false);
		}

		// Token: 0x0602DD54 RID: 187732 RVA: 0x00CD45AF File Offset: 0x00CD27AF
		private void OnToggleClickLock(EToggleState state)
		{
			Action<int, bool> lockToggleCb = this.LockToggleCb;
			if (lockToggleCb == null)
			{
				return;
			}
			lockToggleCb(this.Data.SelectionId, state == EToggleState.ETT_Checked);
		}

		// Token: 0x0602DD55 RID: 187733 RVA: 0x00CD45D0 File Offset: 0x00CD27D0
		public bool HasBuildTag()
		{
			if (this.Data == null || this.Data.CardType != EKurotatoCardType.Weapon)
			{
				return false;
			}
			KurotatoWeaponGroup? weaponGroupConfigByWeaponId = KurotatoConfig.Instance.GetWeaponGroupConfigByWeaponId(this.Data.Id);
			if (weaponGroupConfigByWeaponId == null)
			{
				return false;
			}
			using (IEnumerator<int> enumerator = weaponGroupConfigByWeaponId.Value.WeaponBuildIdsIter().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602DD56 RID: 187734 RVA: 0x00CD4660 File Offset: 0x00CD2860
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

		// Token: 0x040187DC RID: 100316
		private const int INFINITE_STACK_COUNT = 999;

		// Token: 0x040187DD RID: 100317
		[Nullable(2)]
		private IKurotatoCardItemData Data;

		// Token: 0x040187DE RID: 100318
		[Nullable(2)]
		private MultiTemplateScrollView AttrMultiScrollView;

		// Token: 0x040187DF RID: 100319
		private readonly List<IMultiTemplateGridData> AttrScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x040187E0 RID: 100320
		private readonly KurotatoWeaponTagItem BuildTagItem = new KurotatoWeaponTagItem();

		// Token: 0x040187E1 RID: 100321
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildLeftInfoLayout;

		// Token: 0x040187E2 RID: 100322
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildRightInfoLayout;

		// Token: 0x040187E3 RID: 100323
		[Nullable(2)]
		private Action<int, bool> LockToggleCb;

		// Token: 0x040187E4 RID: 100324
		[Nullable(2)]
		private Action<EToggleState> BuildTagClickCb;

		// Token: 0x040187E5 RID: 100325
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, IReadOnlyList<IKurotatoAttrPreviewDelta>> AttrPreviewCb;

		// Token: 0x0200A3AA RID: 41898
		[NullableContext(0)]
		private class EChildComp
		{
			// Token: 0x04032BB4 RID: 207796
			public const int TextureQuality = 0;

			// Token: 0x04032BB5 RID: 207797
			public const int TextureIcon = 1;

			// Token: 0x04032BB6 RID: 207798
			public const int TextName = 2;

			// Token: 0x04032BB7 RID: 207799
			public const int TextProp = 3;

			// Token: 0x04032BB8 RID: 207800
			public const int MultiTemplateScrollViewInfo = 4;

			// Token: 0x04032BB9 RID: 207801
			public const int PanelItemAttr = 5;

			// Token: 0x04032BBA RID: 207802
			public const int PanelRecommend = 6;

			// Token: 0x04032BBB RID: 207803
			public const int ToggleLock = 7;

			// Token: 0x04032BBC RID: 207804
			public const int PanelTag = 8;

			// Token: 0x04032BBD RID: 207805
			public const int ToggleTag = 9;

			// Token: 0x04032BBE RID: 207806
			public const int PanelType = 10;

			// Token: 0x04032BBF RID: 207807
			public const int PanelDone = 11;

			// Token: 0x04032BC0 RID: 207808
			public const int TextType = 12;

			// Token: 0x04032BC1 RID: 207809
			public const int VerticalTipsLeft = 13;

			// Token: 0x04032BC2 RID: 207810
			public const int VerticalTipsRight = 14;

			// Token: 0x04032BC3 RID: 207811
			public const int PanelTipsLeft = 15;

			// Token: 0x04032BC4 RID: 207812
			public const int PanelTipsRight = 16;

			// Token: 0x04032BC5 RID: 207813
			public const int PanelDes = 17;

			// Token: 0x04032BC6 RID: 207814
			public const int PanelWeaponAttr = 18;

			// Token: 0x04032BC7 RID: 207815
			public const int PanelInfoDes = 19;

			// Token: 0x04032BC8 RID: 207816
			public const int SpriteItemBg = 20;

			// Token: 0x04032BC9 RID: 207817
			public const int TextLimitNum = 21;

			// Token: 0x04032BCA RID: 207818
			public const int PanelLimitNum = 22;

			// Token: 0x04032BCB RID: 207819
			public const int SpriteDone = 23;

			// Token: 0x04032BCC RID: 207820
			public const int NiagaraFxGlow = 24;

			// Token: 0x04032BCD RID: 207821
			public const int SpriteUpgrade = 25;

			// Token: 0x04032BCE RID: 207822
			public const int PanelWeaponTag = 26;

			// Token: 0x04032BCF RID: 207823
			public const int SpriteWeaponTagBg = 27;

			// Token: 0x04032BD0 RID: 207824
			public const int SpriteWeaponTagIcon = 28;

			// Token: 0x04032BD1 RID: 207825
			public const int TogglePreview = 29;

			// Token: 0x04032BD2 RID: 207826
			public const int DescriptionItem = 30;
		}
	}
}
