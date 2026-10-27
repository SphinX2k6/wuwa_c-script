using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025B0 RID: 9648
public class FightPhotoResultView : UiViewBase
{
	// Token: 0x060138EC RID: 80108 RVA: 0x004E3233 File Offset: 0x004E1433
	[NullableContext(1)]
	public FightPhotoResultView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060138ED RID: 80109 RVA: 0x004E323C File Offset: 0x004E143C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClicked)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnContinueBtnClicked)),
			new ValueTuple<int, Delegate>(12, new Action(this.OnBackBtnClicked)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnLevelSelectBtnClicked))
		};
	}

	// Token: 0x060138EE RID: 80110 RVA: 0x004E3440 File Offset: 0x004E1640
	protected override void OnStart()
	{
		List<UTexture2D> savedFightPhotos = PhotographController.Instance.GetSavedFightPhotos();
		int count = savedFightPhotos.Count;
		for (int i = 0; i < count; i++)
		{
			UTexture2D texture = savedFightPhotos[i];
			UUITexture texture2 = base.GetTexture(6 + i);
			this.SetTextureWithAutoFit(texture2, texture);
			UUITexture texture3 = base.GetTexture(2 + i);
			this.SetTextureWithAutoFit(texture3, texture);
		}
		FightPhotoActivityData activityData = FightPhotoController.Instance.GetActivityData();
		FightPhotoLevelData currentLevelData = activityData.GetCurrentLevelData(true);
		base.SetTextureByPath(currentLevelData.NpcHeadIcon, base.GetTexture(9), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), currentLevelData.NpcDialogue, Array.Empty<object>());
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(currentLevelData.Name, null);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(currentLevelData.IsDifficulty ? "FightPhotoDifficulty" : "FightPhotoEasy", null);
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(localTextNew + "-" + localTextNew2, true);
		}
		FightPhotoLevelData nextLevelData = activityData.GetNextLevelData(currentLevelData.LevelId);
		bool flag = nextLevelData != null && nextLevelData.IsUnLock;
		UUIButtonComponent button = base.GetButton(15);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		if (flag)
		{
			string localTextNew3 = ConfigMultiTextLang.GetLocalTextNew(nextLevelData.LevelSimpleName, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "FightPhoto_Nextlevel_Buttun", new <>z__ReadOnlySingleElementList<object>(localTextNew3));
		}
	}

	// Token: 0x060138EF RID: 80111 RVA: 0x004E35B4 File Offset: 0x004E17B4
	[NullableContext(1)]
	private void SetTextureWithAutoFit(UUITexture uiTexture, UTexture2D texture)
	{
		uiTexture.SetTexture(texture);
		int num = texture.Blueprint_GetSizeX();
		int num2 = texture.Blueprint_GetSizeY();
		float width = uiTexture.GetWidth();
		float height = uiTexture.GetHeight();
		int num3 = num / num2;
		float num4 = width / height;
		FVector4 uvrect = new FVector4(0f, 0f, 1f, 1f);
		if ((float)num3 > num4)
		{
			float num5 = height / (float)num2;
			float num6 = width / num5;
			float x = ((float)num - num6) / 2f / (float)num;
			float z = num6 / (float)num;
			uvrect = new FVector4(x, 0f, z, 1f);
		}
		else
		{
			float num7 = width / (float)num;
			float num8 = height / num7;
			float y = ((float)num2 - num8) / 2f / (float)num2;
			float w = num8 / (float)num2;
			uvrect = new FVector4(0f, y, 1f, w);
		}
		uiTexture.SetUVRect(uvrect);
	}

	// Token: 0x060138F0 RID: 80112 RVA: 0x004E368A File Offset: 0x004E188A
	protected override void OnBeforeDestroy()
	{
		PhotographController.Instance.ClearAllSavedFightPhotos();
	}

	// Token: 0x060138F1 RID: 80113 RVA: 0x004E3696 File Offset: 0x004E1896
	private void OnCloseBtnClicked()
	{
		PhotographController.Instance.CloseFightPhotographMode();
	}

	// Token: 0x060138F2 RID: 80114 RVA: 0x004E36A2 File Offset: 0x004E18A2
	private void OnContinueBtnClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x060138F3 RID: 80115 RVA: 0x004E36AB File Offset: 0x004E18AB
	protected override void OnAfterPlayStartSequence()
	{
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RepeatMove();
	}

	// Token: 0x060138F4 RID: 80116 RVA: 0x004E36BC File Offset: 0x004E18BC
	private void OnBackBtnClicked()
	{
		FightPhotoController.Instance.LeaveInstanceDungeon(true);
	}

	// Token: 0x060138F5 RID: 80117 RVA: 0x004E36CC File Offset: 0x004E18CC
	private void OnLevelSelectBtnClicked()
	{
		FightPhotoActivityData activityData = FightPhotoController.Instance.GetActivityData();
		if (activityData == null)
		{
			return;
		}
		FightPhotoLevelData currentLevelData = activityData.GetCurrentLevelData(true);
		if (currentLevelData == null)
		{
			return;
		}
		FightPhotoLevelData nextLevelData = activityData.GetNextLevelData(currentLevelData.LevelId);
		FightPhotoLevelData fightPhotoLevelData = (nextLevelData != null && nextLevelData.IsUnLock) ? nextLevelData : currentLevelData;
		activityData.SetCurrentLevelId(fightPhotoLevelData.LevelId);
		UiManager.Instance.OpenView(EUiViewName.FightPhotoMainView, activityData, null);
	}

	// Token: 0x02008BB0 RID: 35760
	private enum EComponents
	{
		// Token: 0x0402D564 RID: 185700
		BtnClose,
		// Token: 0x0402D565 RID: 185701
		ItemPhotoSingleShowPanel,
		// Token: 0x0402D566 RID: 185702
		TextureBigPhoto1,
		// Token: 0x0402D567 RID: 185703
		TextureBigPhoto2,
		// Token: 0x0402D568 RID: 185704
		TextureBigPhoto3,
		// Token: 0x0402D569 RID: 185705
		TextTitle,
		// Token: 0x0402D56A RID: 185706
		TextureSmallPhoto1,
		// Token: 0x0402D56B RID: 185707
		TextureSmallPhoto2,
		// Token: 0x0402D56C RID: 185708
		TextureSmallPhoto3,
		// Token: 0x0402D56D RID: 185709
		TextureRoleHead,
		// Token: 0x0402D56E RID: 185710
		TextDialogue,
		// Token: 0x0402D56F RID: 185711
		BtnContinue,
		// Token: 0x0402D570 RID: 185712
		BtnBack,
		// Token: 0x0402D571 RID: 185713
		ItemPhotoAllShowPanel,
		// Token: 0x0402D572 RID: 185714
		ItemSuccessPanel,
		// Token: 0x0402D573 RID: 185715
		BtnLevelSelect,
		// Token: 0x0402D574 RID: 185716
		TextBtn
	}
}
