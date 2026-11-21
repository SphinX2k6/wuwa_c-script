using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012D0 RID: 4816
[NullableContext(1)]
[Nullable(0)]
public class HandBookPhotoView : UiViewBase
{
	// Token: 0x0600BE1C RID: 48668 RVA: 0x00381AD9 File Offset: 0x0037FCD9
	public HandBookPhotoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BE1D RID: 48669 RVA: 0x00381AE4 File Offset: 0x0037FCE4
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

	// Token: 0x0600BE1E RID: 48670 RVA: 0x00381C8C File Offset: 0x0037FE8C
	protected override UniTask OnBeforeStartAsync()
	{
		HandBookPhotoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HandBookPhotoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BE1F RID: 48671 RVA: 0x00381CCF File Offset: 0x0037FECF
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

	// Token: 0x0600BE20 RID: 48672 RVA: 0x00381D0E File Offset: 0x0037FF0E
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

	// Token: 0x0600BE21 RID: 48673 RVA: 0x00381D40 File Offset: 0x0037FF40
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

	// Token: 0x0600BE22 RID: 48674 RVA: 0x00381EE8 File Offset: 0x003800E8
	private void SetTexture(string texturePath)
	{
		base.SetTextureByPath(texturePath, base.GetTexture(3), null, null);
	}

	// Token: 0x0600BE23 RID: 48675 RVA: 0x00381F0D File Offset: 0x0038010D
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

	// Token: 0x0600BE24 RID: 48676 RVA: 0x00381F35 File Offset: 0x00380135
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

	// Token: 0x0600BE25 RID: 48677 RVA: 0x00381F70 File Offset: 0x00380170
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

	// Token: 0x0600BE26 RID: 48678 RVA: 0x00381FD0 File Offset: 0x003801D0
	private void RefreshChipPhoto(int index)
	{
		string texture = this.HandBookPhotoData.TextureList[index];
		this.SetTexture(texture);
	}

	// Token: 0x0600BE27 RID: 48679 RVA: 0x00381FF6 File Offset: 0x003801F6
	private void RefreshGeographyPhoto(int index)
	{
		this.ReadGeographyHandBook(index);
		this.RefreshAllInfoByIndex(index);
	}

	// Token: 0x0600BE28 RID: 48680 RVA: 0x00382008 File Offset: 0x00380208
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

	// Token: 0x0600BE29 RID: 48681 RVA: 0x00382048 File Offset: 0x00380248
	private void RefreshPlotPhoto(int index)
	{
		this.ReadPlotHandBook(index);
		this.RefreshAllInfoByIndex(index);
	}

	// Token: 0x0600BE2A RID: 48682 RVA: 0x00382058 File Offset: 0x00380258
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

	// Token: 0x0600BE2B RID: 48683 RVA: 0x00382098 File Offset: 0x00380298
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BE2C RID: 48684 RVA: 0x003820A1 File Offset: 0x003802A1
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnPhotoSelect, this.HandBookPhotoData.ConfigId[this.CurIndex]);
		this.HandBookPhotoData = null;
		this.CurIndex = 0;
	}

	// Token: 0x04006D78 RID: 28024
	[Nullable(2)]
	private HandBookPhotoData HandBookPhotoData;

	// Token: 0x04006D79 RID: 28025
	[Nullable(2)]
	private ShareBtnItem ShareBtnItem;

	// Token: 0x04006D7A RID: 28026
	private int CurIndex;
}
