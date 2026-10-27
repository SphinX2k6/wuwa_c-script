using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E0E RID: 7694
[NullableContext(1)]
[Nullable(0)]
public class HandBookPhotoView : UiViewBase
{
	// Token: 0x0600E9FD RID: 59901 RVA: 0x00375DD1 File Offset: 0x00373FD1
	public HandBookPhotoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E9FE RID: 59902 RVA: 0x00375DDC File Offset: 0x00373FDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickLeftButton)),
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickRightButton)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnClickCloseButton))
		};
	}

	// Token: 0x0600E9FF RID: 59903 RVA: 0x00375F84 File Offset: 0x00374184
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookPhotoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookPhotoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA00 RID: 59904 RVA: 0x00375FC7 File Offset: 0x003741C7
	protected override void OnStart()
	{
		this.HandBookPhotoData = (this.OpenParam as HandBookPhotoData);
		if (this.HandBookPhotoData == null)
		{
			return;
		}
		this.CurIndex = this.HandBookPhotoData.Index;
		this.RefreshAllInfoByIndex(this.CurIndex);
		this.UpdateShareBtnItem();
	}

	// Token: 0x0600EA01 RID: 59905 RVA: 0x00376006 File Offset: 0x00374206
	private void UpdateShareBtnItem()
	{
		if (this.ShareBtnItem == null)
		{
			return;
		}
		this.ShareBtnItem.SetShareActionId(EShareActionId.HandBookPhoto);
		this.ShareBtnItem.SetClickCallBack(delegate
		{
			EHandBookTabType handBookType = this.HandBookPhotoData.HandBookType;
			EShareReportExtraType value = EShareReportExtraType.None;
			if (handBookType == EHandBookTabType.Geography)
			{
				value = EShareReportExtraType.HandBookGeography;
			}
			else if (handBookType == EHandBookTabType.Quest)
			{
				value = EShareReportExtraType.HandBookQuest;
			}
			this.HandBookPhotoData.Index = this.CurIndex;
			PhotoSaveViewParam param = new PhotoSaveViewParam
			{
				ScreenShot = false,
				IsHiddenBattleView = false,
				ShareId = 15,
				HandBookPhotoData = this.HandBookPhotoData,
				ReportExtraType = new EShareReportExtraType?(value)
			};
			UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
		});
	}

	// Token: 0x0600EA02 RID: 59906 RVA: 0x00376038 File Offset: 0x00374238
	private void RefreshAllInfoByIndex(int index)
	{
		int count = this.HandBookPhotoData.TextureList.Count;
		base.GetButton(9).RootUIComp.Get().SetUIActive(index != 0);
		base.GetButton(10).RootUIComp.Get().SetUIActive(index != count - 1);
		UUIText text = base.GetText(6);
		if (this.HandBookPhotoData.DateText != null)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "DateOfAcquisition", new <>z__ReadOnlySingleElementList<object>(this.HandBookPhotoData.DateText[index]));
		}
		else
		{
			text.SetUIActive(false);
		}
		UUIText text2 = base.GetText(5);
		if (this.HandBookPhotoData.NameText != null)
		{
			text2.SetUIActive(true);
			text2.SetText(this.HandBookPhotoData.NameText[index], true);
		}
		else
		{
			text2.SetUIActive(false);
		}
		UUIText text3 = base.GetText(4);
		if (this.HandBookPhotoData.TypeText != null)
		{
			text3.SetUIActive(true);
			text3.SetText(this.HandBookPhotoData.TypeText[index], true);
		}
		else
		{
			text3.SetUIActive(false);
		}
		UUIText text4 = base.GetText(8);
		if (this.HandBookPhotoData.DescrtptionText != null)
		{
			text4.SetUIActive(true);
			text4.SetText(this.HandBookPhotoData.DescrtptionText[index], true);
		}
		else
		{
			text4.SetUIActive(false);
		}
		UUITexture texture = base.GetTexture(3);
		if (this.HandBookPhotoData.TextureList != null)
		{
			texture.SetUIActive(true);
			this.SetTexture(this.HandBookPhotoData.TextureList[index]);
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x0600EA03 RID: 59907 RVA: 0x003761E0 File Offset: 0x003743E0
	private void SetTexture(string texturePath)
	{
		base.SetTextureByPath(texturePath, base.GetTexture(3), null, null);
	}

	// Token: 0x0600EA04 RID: 59908 RVA: 0x00376205 File Offset: 0x00374405
	private void OnClickLeftButton()
	{
		if (this.HandBookPhotoData == null)
		{
			return;
		}
		if (this.CurIndex == 0)
		{
			return;
		}
		this.CurIndex--;
		this.Refresh();
	}

	// Token: 0x0600EA05 RID: 59909 RVA: 0x0037622D File Offset: 0x0037442D
	private void OnClickRightButton()
	{
		if (this.HandBookPhotoData == null)
		{
			return;
		}
		if (this.CurIndex == this.HandBookPhotoData.TextureList.Count - 1)
		{
			return;
		}
		this.CurIndex++;
		this.Refresh();
	}

	// Token: 0x0600EA06 RID: 59910 RVA: 0x00376268 File Offset: 0x00374468
	private void Refresh()
	{
		if (this.HandBookPhotoData.HandBookType == EHandBookTabType.Geography)
		{
			this.RefreshGeographyPhoto(this.CurIndex);
			return;
		}
		if (this.HandBookPhotoData.HandBookType == EHandBookTabType.Chip)
		{
			this.RefreshChipPhoto(this.CurIndex);
			return;
		}
		if (this.HandBookPhotoData.HandBookType == EHandBookTabType.Quest)
		{
			this.RefreshPlotPhoto(this.CurIndex);
		}
	}

	// Token: 0x0600EA07 RID: 59911 RVA: 0x003762C8 File Offset: 0x003744C8
	private void RefreshChipPhoto(int index)
	{
		string texture = this.HandBookPhotoData.TextureList[index];
		this.SetTexture(texture);
	}

	// Token: 0x0600EA08 RID: 59912 RVA: 0x003762EE File Offset: 0x003744EE
	private void RefreshGeographyPhoto(int index)
	{
		this.ReadGeographyHandBook(index);
		this.RefreshAllInfoByIndex(index);
	}

	// Token: 0x0600EA09 RID: 59913 RVA: 0x00376300 File Offset: 0x00374500
	private void ReadGeographyHandBook(int index)
	{
		int id = this.HandBookPhotoData.ConfigId[index];
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Geography, id);
		if (handBookInfo == null)
		{
			return;
		}
		if (!handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Geography, id);
		}
	}

	// Token: 0x0600EA0A RID: 59914 RVA: 0x00376340 File Offset: 0x00374540
	private void RefreshPlotPhoto(int index)
	{
		this.ReadPlotHandBook(index);
		this.RefreshAllInfoByIndex(index);
	}

	// Token: 0x0600EA0B RID: 59915 RVA: 0x00376350 File Offset: 0x00374550
	private void ReadPlotHandBook(int index)
	{
		int id = this.HandBookPhotoData.ConfigId[index];
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Quest, id);
		if (handBookInfo == null)
		{
			return;
		}
		if (!handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Quest, id);
		}
	}

	// Token: 0x0600EA0C RID: 59916 RVA: 0x00376390 File Offset: 0x00374590
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600EA0D RID: 59917 RVA: 0x00376399 File Offset: 0x00374599
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnPhotoSelect, this.HandBookPhotoData.ConfigId[this.CurIndex]);
		this.HandBookPhotoData = null;
		this.CurIndex = 0;
	}

	// Token: 0x04006C97 RID: 27799
	[Nullable(2)]
	private HandBookPhotoData HandBookPhotoData;

	// Token: 0x04006C98 RID: 27800
	[Nullable(2)]
	private ShareBtnItem ShareBtnItem;

	// Token: 0x04006C99 RID: 27801
	private int CurIndex;
}
