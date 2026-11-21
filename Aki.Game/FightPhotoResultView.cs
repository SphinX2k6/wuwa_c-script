using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A9B RID: 6811
public class FightPhotoResultView : UiViewBase
{
	// Token: 0x06010DCC RID: 69068 RVA: 0x004F1E33 File Offset: 0x004F0033
	[NullableContext(1)]
	public FightPhotoResultView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06010DCD RID: 69069 RVA: 0x004F1E3C File Offset: 0x004F003C
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

	// Token: 0x06010DCE RID: 69070 RVA: 0x004F2040 File Offset: 0x004F0240
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

	// Token: 0x06010DCF RID: 69071 RVA: 0x004F21B4 File Offset: 0x004F03B4
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

	// Token: 0x06010DD0 RID: 69072 RVA: 0x004F228A File Offset: 0x004F048A
	protected override void OnBeforeDestroy()
	{
		PhotographController.Instance.ClearAllSavedFightPhotos();
	}

	// Token: 0x06010DD1 RID: 69073 RVA: 0x004F2296 File Offset: 0x004F0496
	private void OnCloseBtnClicked()
	{
		PhotographController.Instance.CloseFightPhotographMode();
	}

	// Token: 0x06010DD2 RID: 69074 RVA: 0x004F22A2 File Offset: 0x004F04A2
	private void OnContinueBtnClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010DD3 RID: 69075 RVA: 0x004F22AB File Offset: 0x004F04AB
	protected override void OnAfterPlayStartSequence()
	{
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RepeatMove();
	}

	// Token: 0x06010DD4 RID: 69076 RVA: 0x004F22BC File Offset: 0x004F04BC
	private void OnBackBtnClicked()
	{
		FightPhotoController.Instance.LeaveInstanceDungeon(true);
	}

	// Token: 0x06010DD5 RID: 69077 RVA: 0x004F22CC File Offset: 0x004F04CC
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

	// Token: 0x02007D38 RID: 32056
	private enum EComponents
	{
		// Token: 0x04028879 RID: 166009
		BtnClose,
		// Token: 0x0402887A RID: 166010
		ItemPhotoSingleShowPanel,
		// Token: 0x0402887B RID: 166011
		TextureBigPhoto1,
		// Token: 0x0402887C RID: 166012
		TextureBigPhoto2,
		// Token: 0x0402887D RID: 166013
		TextureBigPhoto3,
		// Token: 0x0402887E RID: 166014
		TextTitle,
		// Token: 0x0402887F RID: 166015
		TextureSmallPhoto1,
		// Token: 0x04028880 RID: 166016
		TextureSmallPhoto2,
		// Token: 0x04028881 RID: 166017
		TextureSmallPhoto3,
		// Token: 0x04028882 RID: 166018
		TextureRoleHead,
		// Token: 0x04028883 RID: 166019
		TextDialogue,
		// Token: 0x04028884 RID: 166020
		BtnContinue,
		// Token: 0x04028885 RID: 166021
		BtnBack,
		// Token: 0x04028886 RID: 166022
		ItemPhotoAllShowPanel,
		// Token: 0x04028887 RID: 166023
		ItemSuccessPanel,
		// Token: 0x04028888 RID: 166024
		BtnLevelSelect,
		// Token: 0x04028889 RID: 166025
		TextBtn
	}
}
