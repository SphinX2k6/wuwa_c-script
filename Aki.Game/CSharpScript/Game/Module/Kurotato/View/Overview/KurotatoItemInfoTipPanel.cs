using System;
using System.Collections.Generic;
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
	// Token: 0x0200471C RID: 18204
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoItemInfoTipPanel : UiPanelBase
	{
		// Token: 0x0602DBC4 RID: 187332 RVA: 0x00CCAAF0 File Offset: 0x00CC8CF0
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

		// Token: 0x0602DBC5 RID: 187333 RVA: 0x00CCAE64 File Offset: 0x00CC9064
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoItemInfoTipPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBC6 RID: 187334 RVA: 0x00CCAEA7 File Offset: 0x00CC90A7
		private void CreateAttrSelectLayout()
		{
			this.PropertyLayout = new GenericLayout<PropertyInfoItem, IKurotatoAttrDisplay>(base.GetVerticalLayout(3), () => new PropertyInfoItem(), null, false, true);
		}

		// Token: 0x0602DBC7 RID: 187335 RVA: 0x00CCAEE0 File Offset: 0x00CC90E0
		private UniTask CreateToggleTabItemAsync()
		{
			KurotatoItemInfoTipPanel.<CreateToggleTabItemAsync>d__17 <CreateToggleTabItemAsync>d__;
			<CreateToggleTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateToggleTabItemAsync>d__.<>4__this = this;
			<CreateToggleTabItemAsync>d__.<>1__state = -1;
			<CreateToggleTabItemAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateToggleTabItemAsync>d__17>(ref <CreateToggleTabItemAsync>d__);
			return <CreateToggleTabItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBC8 RID: 187336 RVA: 0x00CCAF24 File Offset: 0x00CC9124
		private UniTask CreateLockPanelAsync()
		{
			KurotatoItemInfoTipPanel.<CreateLockPanelAsync>d__18 <CreateLockPanelAsync>d__;
			<CreateLockPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateLockPanelAsync>d__.<>4__this = this;
			<CreateLockPanelAsync>d__.<>1__state = -1;
			<CreateLockPanelAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateLockPanelAsync>d__18>(ref <CreateLockPanelAsync>d__);
			return <CreateLockPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBC9 RID: 187337 RVA: 0x00CCAF68 File Offset: 0x00CC9168
		private void CreateBuildInfoPanel()
		{
			this.BuildLeftInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(11), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
			this.BuildRightInfoLayout = new GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel>(base.GetVerticalLayout(12), () => new KurotatoPopupWeaponBuildItem(), null, false, true);
		}

		// Token: 0x0602DBCA RID: 187338 RVA: 0x00CCAFE0 File Offset: 0x00CC91E0
		private UniTask CreateBuildTagItemAsync()
		{
			KurotatoItemInfoTipPanel.<CreateBuildTagItemAsync>d__20 <CreateBuildTagItemAsync>d__;
			<CreateBuildTagItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuildTagItemAsync>d__.<>4__this = this;
			<CreateBuildTagItemAsync>d__.<>1__state = -1;
			<CreateBuildTagItemAsync>d__.<>t__builder.Start<KurotatoItemInfoTipPanel.<CreateBuildTagItemAsync>d__20>(ref <CreateBuildTagItemAsync>d__);
			return <CreateBuildTagItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DBCB RID: 187339 RVA: 0x00CCB023 File Offset: 0x00CC9223
		private void CreateSkillLayout()
		{
			this.SkillLayout = new GenericLayout<SkillItem, string>(base.GetVerticalLayout(15), () => new SkillItem(), null, false, true);
		}

		// Token: 0x0602DBCC RID: 187340 RVA: 0x00CCB05A File Offset: 0x00CC925A
		protected override void OnStart()
		{
			this.ToggleTabItem.SetUiActive(false);
		}

		// Token: 0x0602DBCD RID: 187341 RVA: 0x00CCB068 File Offset: 0x00CC9268
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
			List<IKurotatoWeaponBuildInfoPanel> list = new List<IKurotatoWeaponBuildInfoPanel>(dataList.Count);
			foreach (IKurotatoWeaponBuildData kurotatoWeaponBuildData in dataList)
			{
				list.Add(new KurotatoWeaponBuildInfoPanel
				{
					BuildId = kurotatoWeaponBuildData.BuildId,
					BuildLevel = KurotatoModel.Instance.GetWeaponBuildLevelByBuildId(kurotatoWeaponBuildData.BuildId)
				});
			}
			if (this.TipShowLeft)
			{
				this.ShowBuildInfoLeft(list);
				return;
			}
			this.ShowBuildInfoRight(list);
		}

		// Token: 0x0602DBCE RID: 187342 RVA: 0x00CCB134 File Offset: 0x00CC9334
		public void ShowBuildInfoLeft(IReadOnlyList<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildLeftInfoLayout.SetActive(true);
			this.BuildRightInfoLayout.SetActive(false);
			this.BuildLeftInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602DBCF RID: 187343 RVA: 0x00CCB15C File Offset: 0x00CC935C
		public void ShowBuildInfoRight(IReadOnlyList<IKurotatoWeaponBuildInfoPanel> data)
		{
			this.BuildRightInfoLayout.SetActive(true);
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602DBD0 RID: 187344 RVA: 0x00CCB184 File Offset: 0x00CC9384
		public void CloseBuildInfo()
		{
			this.BuildLeftInfoLayout.SetActive(false);
			this.BuildRightInfoLayout.SetActive(false);
		}

		// Token: 0x0602DBD1 RID: 187345 RVA: 0x00CCB19E File Offset: 0x00CC939E
		private void OnClickBuildTag(IReadOnlyList<IKurotatoWeaponBuildData> dataList, EToggleState state)
		{
			this.RefreshBuildInfoByCheckedTags();
		}

		// Token: 0x0602DBD2 RID: 187346 RVA: 0x00CCB1A6 File Offset: 0x00CC93A6
		public void Refresh(EKurotatoCardType selectedType, int selectedId, bool tipShowLeft = true, bool showBuildInfo = true, int? preWaveDealtDamage = null)
		{
			this.SelectedType = selectedType;
			this.SelectedId = selectedId;
			this.TipShowLeft = tipShowLeft;
			this.PreWaveDealtDamage = preWaveDealtDamage;
			this.RefreshInfo(showBuildInfo);
		}

		// Token: 0x0602DBD3 RID: 187347 RVA: 0x00CCB1CD File Offset: 0x00CC93CD
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

		// Token: 0x0602DBD4 RID: 187348 RVA: 0x00CCB204 File Offset: 0x00CC9404
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
			List<IKurotatoAttrDisplay> itemAttrDisplayList = KurotatoUtil.GetItemAttrDisplayList(new List<int>(value.EffectIter()), false, false, true);
			this.PropertyLayout.RefreshByData(itemAttrDisplayList, null, false);
			string cardDesc = KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), 0, 0, false);
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

		// Token: 0x0602DBD5 RID: 187349 RVA: 0x00CCB438 File Offset: 0x00CC9638
		private void RefreshWeaponInfo(bool showBuildInfo = true)
		{
			KurotatoConfig instance = KurotatoConfig.Instance;
			KurotatoModel instance2 = KurotatoModel.Instance;
			IKurotatoWeaponData weaponDataByIncId = instance2.GetWeaponDataByIncId(this.SelectedId);
			bool flag = !this.IsOutside && weaponDataByIncId != null;
			int weaponId = flag ? weaponDataByIncId.WeaponId : this.SelectedId;
			KurotatoWeapon value = instance.GetWeaponConfigByWeaponId(weaponId).Value;
			KurotatoWeaponGroup value2 = instance.GetWeaponGroupConfigByWeaponId(weaponId).Value;
			KurotatoQuality value3 = instance.GetQualityByQuality(value.Quality).Value;
			bool flag2 = false;
			using (IEnumerator<int> enumerator = value2.WeaponBuildIdsIter().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					flag2 = true;
				}
			}
			this.BuildTagItem.SetUiActive(flag2);
			base.GetItem(9).SetUIActive(false);
			base.GetText(0).ShowTextNew(value.Name);
			base.GetText(1).ShowTextNew(value3.QualityName);
			base.GetText(1).SetColor(FColor.FromHex(value3.QualityColor));
			base.SetTextureByPath(value3.InfoQualityTexture, base.GetTexture(17), null, null);
			base.SetTextureByPath(value2.Icon, base.GetTexture(2), null, null);
			int weaponIncId = flag ? this.SelectedId : 0;
			List<IKurotatoAttrDisplay> weaponPropertyDisplayList = KurotatoUtil.GetWeaponPropertyDisplayList(new List<int>(value.ShowPropertyIter()), weaponId, weaponIncId);
			if (!StringUtils.IsEmpty(value.AttackDes))
			{
				string cardDesc = KurotatoUtil.GetCardDesc(value.AttackDes, new List<string>(value.AttackDesParamIter()), weaponId, weaponIncId, true);
				KurotatoProperty? propertyById = instance.GetPropertyById(7);
				weaponPropertyDisplayList.Insert(0, new KurotatoAttrDisplay
				{
					Icon = (((propertyById != null) ? propertyById.GetValueOrDefault().Icon : null) ?? ""),
					Text = cardDesc,
					PropertyId = ((propertyById != null) ? propertyById.GetValueOrDefault().Id : 0)
				});
			}
			this.PropertyLayout.RefreshByData(weaponPropertyDisplayList, null, false);
			string cardDesc2 = KurotatoUtil.GetCardDesc(value.Desc, new List<string>(value.DescParamsIter()), weaponId, weaponIncId, false);
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
				List<IKurotatoWeaponBuildInfoPanel> list = new List<IKurotatoWeaponBuildInfoPanel>();
				foreach (int num2 in value2.WeaponBuildIdsIter())
				{
					list.Add(new KurotatoWeaponBuildInfoPanel
					{
						BuildId = num2,
						BuildLevel = instance2.GetWeaponBuildLevelByBuildId(num2)
					});
				}
				this.ShowBuildInfoLeft(list);
			}
			if (flag2)
			{
				List<IKurotatoWeaponBuildData> list2 = new List<IKurotatoWeaponBuildData>();
				foreach (int buildId in value2.WeaponBuildIdsIter())
				{
					list2.Add(new KurotatoWeaponBuildData
					{
						BuildId = buildId,
						WeaponId = weaponId
					});
				}
				this.BuildTagItem.Refresh(list2);
			}
			base.GetItem(18).SetUIActive(!this.IsOutside || this.PreWaveDealtDamage != null);
			int num3 = this.PreWaveDealtDamage ?? ((weaponDataByIncId != null) ? weaponDataByIncId.PreWaveDealtDamage : 0);
			base.GetText(19).SetText(num3.ToString(), true);
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

		// Token: 0x0602DBD6 RID: 187350 RVA: 0x00CCB8B0 File Offset: 0x00CC9AB0
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

		// Token: 0x0401872F RID: 100143
		private readonly PopupCaptionToggleItem ToggleTabItem = new PopupCaptionToggleItem();

		// Token: 0x04018730 RID: 100144
		private readonly FunctionalPanelConditionLock LockPanel = new FunctionalPanelConditionLock();

		// Token: 0x04018731 RID: 100145
		private readonly KurotatoWeaponTagItem BuildTagItem = new KurotatoWeaponTagItem();

		// Token: 0x04018732 RID: 100146
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PropertyInfoItem, IKurotatoAttrDisplay> PropertyLayout;

		// Token: 0x04018733 RID: 100147
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildLeftInfoLayout;

		// Token: 0x04018734 RID: 100148
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoPopupWeaponBuildItem, IKurotatoWeaponBuildInfoPanel> BuildRightInfoLayout;

		// Token: 0x04018735 RID: 100149
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkillItem, string> SkillLayout;

		// Token: 0x04018736 RID: 100150
		private EKurotatoCardType SelectedType;

		// Token: 0x04018737 RID: 100151
		private int SelectedId;

		// Token: 0x04018738 RID: 100152
		private bool TipShowLeft = true;

		// Token: 0x04018739 RID: 100153
		private int? PreWaveDealtDamage;

		// Token: 0x0401873A RID: 100154
		public bool IsOutside;

		// Token: 0x0401873B RID: 100155
		public bool IsInHandBook;

		// Token: 0x0200A34E RID: 41806
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032A2D RID: 207405
			TextName,
			// Token: 0x04032A2E RID: 207406
			TextQuality,
			// Token: 0x04032A2F RID: 207407
			TextureIcon,
			// Token: 0x04032A30 RID: 207408
			VerticalLayoutAttr,
			// Token: 0x04032A31 RID: 207409
			AttrItem,
			// Token: 0x04032A32 RID: 207410
			ItemMiddleLine,
			// Token: 0x04032A33 RID: 207411
			PanelTag,
			// Token: 0x04032A34 RID: 207412
			ItemTog,
			// Token: 0x04032A35 RID: 207413
			ToggleTabNameItem,
			// Token: 0x04032A36 RID: 207414
			PanelType,
			// Token: 0x04032A37 RID: 207415
			TextType,
			// Token: 0x04032A38 RID: 207416
			PanelTipsLeft,
			// Token: 0x04032A39 RID: 207417
			PanelTipsRight,
			// Token: 0x04032A3A RID: 207418
			TagTipLeftItem,
			// Token: 0x04032A3B RID: 207419
			TagTipRightItem,
			// Token: 0x04032A3C RID: 207420
			VerticalSkillData,
			// Token: 0x04032A3D RID: 207421
			SkillInfo,
			// Token: 0x04032A3E RID: 207422
			TextureQuality,
			// Token: 0x04032A3F RID: 207423
			PanelHarm,
			// Token: 0x04032A40 RID: 207424
			TextHarm,
			// Token: 0x04032A41 RID: 207425
			SpriteLockIcon,
			// Token: 0x04032A42 RID: 207426
			ItemBgDescLine,
			// Token: 0x04032A43 RID: 207427
			ItemBgDescPanel,
			// Token: 0x04032A44 RID: 207428
			TextBgDesc,
			// Token: 0x04032A45 RID: 207429
			ItemLockPanel
		}
	}
}
