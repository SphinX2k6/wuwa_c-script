using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001548 RID: 5448
public class ActivityWeaponDescribeComponent : UiPanelBase
{
	// Token: 0x06009BB3 RID: 39859 RVA: 0x0021B504 File Offset: 0x00219704
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.LookButtonClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x0021B650 File Offset: 0x00219850
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
		this.SetLookButtonVisible(false);
	}

	// Token: 0x06009BB5 RID: 39861 RVA: 0x0021B69C File Offset: 0x0021989C
	public void Refresh(int weaponId, bool isUp = false)
	{
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(weaponId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		base.GetText(0).ShowTextNew(weaponConfigByItemId.Value.WeaponName);
		base.GetItem(1).SetUIActive(isUp);
		this.UpdateWeaponIcon(weaponConfigByItemId.Value.WeaponType);
		this.UpdateQuality(weaponConfigByItemId.Value.QualityId);
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x0021B714 File Offset: 0x00219914
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_WeaponAttributeQualityBg");
		defaultInterpolatedStringHandler.AppendFormatted<int>(quality);
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		if (string.IsNullOrEmpty(resourcePath))
		{
			return;
		}
		this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x0021B780 File Offset: 0x00219980
	private void UpdateWeaponIcon(int weaponType)
	{
		foreach (Mapping mapping in MappingConfig.Instance.GetWeaponConfList())
		{
			if (weaponType == mapping.Value)
			{
				this.SetSpriteByPath(mapping.Icon, base.GetSprite(5), false, null, null);
				break;
			}
		}
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x0021B7F8 File Offset: 0x002199F8
	private void LookButtonClicked()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x0021B80A File Offset: 0x00219A0A
	[NullableContext(1)]
	public void BindButtonFunction(Action func)
	{
		this.ButtonFunction = func;
	}

	// Token: 0x06009BBA RID: 39866 RVA: 0x0021B814 File Offset: 0x00219A14
	public void SetLookButtonVisible(bool bVisible)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06009BBB RID: 39867 RVA: 0x0021B840 File Offset: 0x00219A40
	[NullableContext(1)]
	public void BindWeaponPreviewFunction(int[] previewWeaponIdList, int selectedIndex = 0)
	{
		Action func = delegate()
		{
			if (previewWeaponIdList.Length == 0)
			{
				return;
			}
			List<WeaponTrialData> list = new List<WeaponTrialData>();
			foreach (int trialId in previewWeaponIdList)
			{
				WeaponTrialData weaponTrialData = new WeaponTrialData();
				weaponTrialData.SetTrialId(trialId, true);
				list.Add(weaponTrialData);
			}
			WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
			WeaponDataBase[] weaponDataList = list.ToArray();
			weaponPreviewViewParam.WeaponDataList = weaponDataList;
			weaponPreviewViewParam.SelectedIndex = selectedIndex;
			WeaponPreviewViewParam param = weaponPreviewViewParam;
			UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
		};
		this.BindButtonFunction(func);
	}

	// Token: 0x04004467 RID: 17511
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x04004468 RID: 17512
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x02007B7C RID: 31612
	private class EComponent
	{
		// Token: 0x0402899A RID: 166298
		public const int NameText = 0;

		// Token: 0x0402899B RID: 166299
		public const int UpItem = 1;

		// Token: 0x0402899C RID: 166300
		public const int StarLayout = 2;

		// Token: 0x0402899D RID: 166301
		public const int WeaponIconTexture = 3;

		// Token: 0x0402899E RID: 166302
		public const int WeaponBgSprite = 4;

		// Token: 0x0402899F RID: 166303
		public const int WeaponIconSprite = 5;

		// Token: 0x040289A0 RID: 166304
		public const int LookButton = 6;
	}
}
