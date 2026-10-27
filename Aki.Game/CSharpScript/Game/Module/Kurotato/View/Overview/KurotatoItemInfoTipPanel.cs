using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.AttrSelect;
using CSharpScript.Game.Module.Kurotato.View.PopupItemDetail;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005745 RID: 22341
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoItemInfoTipPanel : UiPanelBase
	{
		// Token: 0x06038CB4 RID: 232628 RVA: 0x00D7C31C File Offset: 0x00D7A51C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038CB5 RID: 232629 RVA: 0x00D7C690 File Offset: 0x00D7A890
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoItemInfoTipPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CB6 RID: 232630 RVA: 0x00D7C6D3 File Offset: 0x00D7A8D3
		private void CreateAttrSelectLayout()
		{
			this.PropertyLayout = new GenericLayout<PropertyInfoItem, IKurotatoAttrDisplay>(base.GetVerticalLayout(3), () => new PropertyInfoItem(), null, false, true);
		}

		// Token: 0x06038CB7 RID: 232631 RVA: 0x00D7C70C File Offset: 0x00D7A90C
		private UniTask CreateToggleTabItemAsync()
		{
			KurotatoItemInfoTipPanel.<CreateToggleTabItemAsync>d__17 <CreateToggleTabItemAsync>d__;
			<CreateToggleTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateToggleTabItemAsync>d__.<>4__this = this;
			<CreateToggleTabItemAsync>d__.<>1__state = -1;
			<CreateToggleTabItemAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateToggleTabItemAsync>d__17>(ref <CreateToggleTabItemAsync>d__);
			return <CreateToggleTabItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CB8 RID: 232632 RVA: 0x00D7C750 File Offset: 0x00D7A950
		private UniTask CreateLockPanelAsync()
		{
			KurotatoItemInfoTipPanel.<CreateLockPanelAsync>d__18 <CreateLockPanelAsync>d__;
			<CreateLockPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLockPanelAsync>d__.<>4__this = this;
			<CreateLockPanelAsync>d__.<>1__state = -1;
			<CreateLockPanelAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateLockPanelAsync>d__18>(ref <CreateLockPanelAsync>d__);
			return <CreateLockPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CB9 RID: 232633 RVA: 0x00D7C794 File Offset: 0x00D7A994
		private void CreateBuildInfoPanel()
		{
			this.BuildLeftInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(11), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
			this.BuildRightInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(12), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
		}

		// Token: 0x06038CBA RID: 232634 RVA: 0x00D7C80C File Offset: 0x00D7AA0C
		private UniTask CreateBuildTagItemAsync()
		{
			KurotatoItemInfoTipPanel.<CreateBuildTagItemAsync>d__20 <CreateBuildTagItemAsync>d__;
			<CreateBuildTagItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildTagItemAsync>d__.<>4__this = this;
			<CreateBuildTagItemAsync>d__.<>1__state = -1;
			<CreateBuildTagItemAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateBuildTagItemAsync>d__20>(ref <CreateBuildTagItemAsync>d__);
			return <CreateBuildTagItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CBB RID: 232635 RVA: 0x00D7C84F File Offset: 0x00D7AA4F
		private void CreateSkillLayout()
		{
			this.SkillLayout = new GenericLayout<SkillItem, string>(base.GetVerticalLayout(15), () => new SkillItem(), null, false, true);
		}

		// Token: 0x06038CBC RID: 232636 RVA: 0x00D7C886 File Offset: 0x00D7AA86
		protected override void OnStart()
		{
			this.ToggleTabItem.SetUiActive(false);
		}

		// Token: 0x06038CBD RID: 232637 RVA: 0x00D7C894 File Offset: 0x00D7AA94
		public void RefreshBuildInfoByCheckedTags()
		{
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
			List<IKurotatoWeaponBuildInfoPanel> data = (from tagData in dataList
			select new KurotatoWeaponBuildInfoPanel
			{
				BuildId = tagData.BuildId,
				BuildLevel = KurotatoModel.Instance.GetWeaponBuildLevelByBuildId(tagData.BuildId)
			}).ToList<IKurotatoWeaponBuildInfoPanel>();
			if (this.TipShowLeft)
			{
				this.ShowBuildInfoLeft(data);
				return;
			}
			this.ShowBuildInfoRight(data);
		}

		// Token: 0x06038CBE RID: 232638 RVA: 0x00D7C915 File Offset: 0x00D7AB15
		public void ShowBuildInfoLeft(IReadOnlyList<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildLeftInfoLayout.SetActive(true);
			this.BuildRightInfoLayout.SetActive(false);
			this.BuildLeftInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06038CBF RID: 232639 RVA: 0x00D7C93D File Offset: 0x00D7AB3D
		public void ShowBuildInfoRight(IReadOnlyList<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildRightInfoLayout.SetActive(true);
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06038CC0 RID: 232640 RVA: 0x00D7C965 File Offset: 0x00D7AB65
		public void CloseBuildInfo()
		{
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.SetActive(false);
		}

		// Token: 0x06038CC1 RID: 232641 RVA: 0x00D7C97F File Offset: 0x00D7AB7F
		private void OnClickBuildTag(IReadOnlyList<IKurotatoWeaponBuildData> dataList, EToggleState state)
		{
			this.RefreshBuildInfoByCheckedTags();
		}

		// Token: 0x06038CC2 RID: 232642 RVA: 0x00D7C987 File Offset: 0x00D7AB87
		public void Refresh(EKurotatoCardType selectedType, int selectedId, bool tipShowLeft = true, bool showBuildInfo = true, int? preWaveDealtDamage = null)
		{
			this.SelectedType = selectedType;
			this.SelectedId = selectedId;
			this.TipShowLeft = tipShowLeft;
			this.PreWaveDealtDamage = preWaveDealtDamage;
			this.RefreshInfo(showBuildInfo);
		}

		// Token: 0x06038CC3 RID: 232643 RVA: 0x00D7C9AE File Offset: 0x00D7ABAE
		private void RefreshInfo(bool showBuildInfo = true)
		{
			this.CloseBuildInfo();
			this.BuildTagItem.SetChecked(false);
			if (this.SelectedId <= 0)
			{
				return;
			}
			if (this.SelectedType == EKurotatoCardType.Weapon)
			{
				this.RefreshWeaponInfo(showBuildInfo);
				return;
			}
			this.RefreshItemInfo();
		}

		// Token: 0x06038CC4 RID: 232644 RVA: 0x00D7C9E4 File Offset: 0x00D7ABE4
		private void RefreshItemInfo()
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoItem value = instance.GetItemConfigByItemId(this.SelectedId).Value;
			KurotatoQuality value2 = instance.GetQualityByQuality(value.Quality).Value;
			this.BuildTagItem.SetUiActive(false);
			base.GetItem(9).SetUIActive(!StringUtils.IsEmpty(value.Tag));
			base.GetText(0).ShowTextNew(value.Name);
			base.GetText(1).ShowTextNew(value2.QualityName);
			base.GetText(1).SetColor(FColor.FromHex(value2.QualityColor));
			base.SetTextureByPath(value2.InfoQualityTexture, base.GetTexture(17), null, null);
			base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(value.EffectIter().ToList<int>(), false, false, true);
			this.PropertyLayout.RefreshByData(itemAttrDisplayList, null, false);
			string cardDesc = KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), 0, 0, false);
			bool flag = cardDesc != "";
			GenericLayout<SkillItem, string> skillLayout = this.SkillLayout;
			List<string> data;
			if (!flag)
			{
				data = new List<string>();
			}
			else
			{
				(data = new List<string>()).Add(cardDesc);
			}
			skillLayout.RefreshByData(data, null, false);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(itemAttrDisplayList.Count > 0 && flag);
			}
			if (!StringUtils.IsEmpty(value.Tag))
			{
				base.GetText(10).ShowTextNew(value.Tag);
			}
			base.GetItem(18).SetUIActive(false);
			this.RefreshBgDesc(value.BgDesc);
			if (this.IsInHandBook)
			{
				KurotatoItemData kurotatoItemData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoItemData(this.SelectedId);
				FunctionalPanelConditionLock lockPanel = this.LockPanel;
				if (lockPanel != null)
				{
					lockPanel.SetUiActive(!kurotatoItemData.IsUnLock);
				}
				UUISprite sprite = base.GetSprite(20);
				if (sprite != null)
				{
					sprite.SetUIActive(!kurotatoItemData.IsUnLock);
				}
				if (!kurotatoItemData.IsUnLock)
				{
					string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(kurotatoItemData.ConditionId);
					FunctionalPanelConditionLock lockPanel2 = this.LockPanel;
					if (lockPanel2 == null)
					{
						return;
					}
					lockPanel2.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
				}
			}
		}

		// Token: 0x06038CC5 RID: 232645 RVA: 0x00D7CC18 File Offset: 0x00D7AE18
		private void RefreshWeaponInfo(bool showBuildInfo = true)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoModel kurotatoModel = KurotatoModel.Instance;
			IKurotatoWeaponData weaponDataByIncId = kurotatoModel.GetWeaponDataByIncId(this.SelectedId);
			bool flag = !this.IsOutside && weaponDataByIncId != null;
			int weaponId = flag ? weaponDataByIncId.WeaponId : this.SelectedId;
			KurotatoWeapon value = instance.GetWeaponConfigByWeaponId(weaponId).Value;
			KurotatoWeaponGroup value2 = instance.GetWeaponGroupConfigByWeaponId(weaponId).Value;
			KurotatoQuality value3 = instance.GetQualityByQuality(value.Quality).Value;
			bool flag2 = value2.WeaponBuildIdsIter().Any<int>();
			this.BuildTagItem.SetUiActive(flag2);
			base.GetItem(9).SetUIActive(false);
			base.GetText(0).ShowTextNew(value.Name);
			base.GetText(1).ShowTextNew(value3.QualityName);
			base.GetText(1).SetColor(FColor.FromHex(value3.QualityColor));
			base.SetTextureByPath(value3.InfoQualityTexture, base.GetTexture(17), null, null);
			base.SetTextureByPath(value2.Icon, base.GetTexture(2), null, null);
			int weaponIncId = flag ? this.SelectedId : 0;
			List<IKurotatoAttrDisplay> weaponPropertyDisplayList = KurotatoUtil.GetWeaponPropertyDisplayList(value.ShowPropertyIter().ToList<int>(), weaponId, weaponIncId);
			if (!StringUtils.IsEmpty(value.AttackDes))
			{
				string cardDesc = KurotatoUtil.GetCardDesc(value.AttackDes, value.AttackDesParamIter().ToList<string>(), weaponId, weaponIncId, true);
				KurotatoProperty? propertyById = instance.GetPropertyById(7);
				weaponPropertyDisplayList.Insert(0, new KurotatoAttrDisplay
				{
					Icon = (((propertyById != null) ? propertyById.GetValueOrDefault().Icon : null) ?? ""),
					Text = cardDesc,
					PropertyId = ((propertyById != null) ? propertyById.GetValueOrDefault().Id : 0)
				});
			}
			this.PropertyLayout.RefreshByData(weaponPropertyDisplayList, null, false);
			string cardDesc2 = KurotatoUtil.GetCardDesc(value.Desc, value.DescParamsIter().ToList<string>(), weaponId, weaponIncId, false);
			bool flag3 = cardDesc2 != "";
			GenericLayout<SkillItem, string> skillLayout = this.SkillLayout;
			List<string> data;
			if (!flag3)
			{
				data = new List<string>();
			}
			else
			{
				(data = new List<string>()).Add(cardDesc2);
			}
			skillLayout.RefreshByData(data, null, false);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(weaponPropertyDisplayList.Count > 0 && flag3);
			}
			if (showBuildInfo)
			{
				this.ShowBuildInfoLeft((from buildId in value2.WeaponBuildIdsIter()
				select new KurotatoWeaponBuildInfoPanel
				{
					BuildId = buildId,
					BuildLevel = kurotatoModel.GetWeaponBuildLevelByBuildId(buildId)
				}).ToList<IKurotatoWeaponBuildInfoPanel>());
			}
			if (flag2)
			{
				this.BuildTagItem.Refresh((from buildId in value2.WeaponBuildIdsIter()
				select new KurotatoWeaponBuildData
				{
					BuildId = buildId,
					WeaponId = weaponId
				}).ToList<IKurotatoWeaponBuildData>());
			}
			base.GetItem(18).SetUIActive(!this.IsOutside || this.PreWaveDealtDamage != null);
			int num = this.PreWaveDealtDamage ?? ((weaponDataByIncId != null) ? weaponDataByIncId.PreWaveDealtDamage : 0);
			base.GetText(19).SetText(num.ToString(), true);
			this.RefreshBgDesc(value.BgDesc);
			if (this.IsInHandBook)
			{
				KurotatoWeaponData kurotatoWeaponData = KurotatoActivityController.Instance.GetActivityData().GetKurotatoWeaponData(this.SelectedId);
				FunctionalPanelConditionLock lockPanel = this.LockPanel;
				if (lockPanel != null)
				{
					lockPanel.SetUiActive(!kurotatoWeaponData.IsUnLock);
				}
				UUISprite sprite = base.GetSprite(20);
				if (sprite != null)
				{
					sprite.SetUIActive(!kurotatoWeaponData.IsUnLock);
				}
				if (!kurotatoWeaponData.IsUnLock)
				{
					string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(kurotatoWeaponData.ConditionId);
					FunctionalPanelConditionLock lockPanel2 = this.LockPanel;
					if (lockPanel2 == null)
					{
						return;
					}
					lockPanel2.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
				}
			}
		}

		// Token: 0x06038CC6 RID: 232646 RVA: 0x00D7CFF4 File Offset: 0x00D7B1F4
		private void RefreshBgDesc(string text)
		{
			bool flag = text == "";
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(!flag && this.IsInHandBook);
			}
			UUIItem item2 = base.GetItem(22);
			if (item2 != null)
			{
				item2.SetUIActive(!flag && this.IsInHandBook);
			}
			if (flag)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(23), text, Array.Empty<object>());
		}

		// Token: 0x0401DC99 RID: 122009
		private readonly PopupCaptionToggleItem ToggleTabItem = new PopupCaptionToggleItem();

		// Token: 0x0401DC9A RID: 122010
		private readonly FunctionalPanelConditionLock LockPanel = new FunctionalPanelConditionLock();

		// Token: 0x0401DC9B RID: 122011
		private readonly KurotatoWeaponTagItem BuildTagItem = new KurotatoWeaponTagItem();

		// Token: 0x0401DC9C RID: 122012
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PropertyInfoItem, IKurotatoAttrDisplay> PropertyLayout;

		// Token: 0x0401DC9D RID: 122013
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildLeftInfoLayout;

		// Token: 0x0401DC9E RID: 122014
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildRightInfoLayout;

		// Token: 0x0401DC9F RID: 122015
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkillItem, string> SkillLayout;

		// Token: 0x0401DCA0 RID: 122016
		private EKurotatoCardType SelectedType;

		// Token: 0x0401DCA1 RID: 122017
		private int SelectedId;

		// Token: 0x0401DCA2 RID: 122018
		private bool TipShowLeft = true;

		// Token: 0x0401DCA3 RID: 122019
		private int? PreWaveDealtDamage;

		// Token: 0x0401DCA4 RID: 122020
		public bool IsOutside;

		// Token: 0x0401DCA5 RID: 122021
		public bool IsInHandBook;

		// Token: 0x0200B92E RID: 47406
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04038020 RID: 229408
			TextName,
			// Token: 0x04038021 RID: 229409
			TextQuality,
			// Token: 0x04038022 RID: 229410
			TextureIcon,
			// Token: 0x04038023 RID: 229411
			VerticalLayoutAttr,
			// Token: 0x04038024 RID: 229412
			AttrItem,
			// Token: 0x04038025 RID: 229413
			ItemMiddleLine,
			// Token: 0x04038026 RID: 229414
			PanelTag,
			// Token: 0x04038027 RID: 229415
			ItemTog,
			// Token: 0x04038028 RID: 229416
			ToggleTabNameItem,
			// Token: 0x04038029 RID: 229417
			PanelType,
			// Token: 0x0403802A RID: 229418
			TextType,
			// Token: 0x0403802B RID: 229419
			PanelTipsLeft,
			// Token: 0x0403802C RID: 229420
			PanelTipsRight,
			// Token: 0x0403802D RID: 229421
			TagTipLeftItem,
			// Token: 0x0403802E RID: 229422
			TagTipRightItem,
			// Token: 0x0403802F RID: 229423
			VerticalSkillData,
			// Token: 0x04038030 RID: 229424
			SkillInfo,
			// Token: 0x04038031 RID: 229425
			TextureQuality,
			// Token: 0x04038032 RID: 229426
			PanelHarm,
			// Token: 0x04038033 RID: 229427
			TextHarm,
			// Token: 0x04038034 RID: 229428
			SpriteLockIcon,
			// Token: 0x04038035 RID: 229429
			ItemBgDescLine,
			// Token: 0x04038036 RID: 229430
			ItemBgDescPanel,
			// Token: 0x04038037 RID: 229431
			TextBgDesc,
			// Token: 0x04038038 RID: 229432
			ItemLockPanel
		}
	}
}
