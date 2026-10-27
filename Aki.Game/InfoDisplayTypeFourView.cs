using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA0 RID: 8096
public class InfoDisplayTypeFourView : UiTickViewBase
{
	// Token: 0x0600FB65 RID: 64357 RVA: 0x003CEAF4 File Offset: 0x003CCCF4
	[NullableContext(1)]
	public InfoDisplayTypeFourView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB66 RID: 64358 RVA: 0x003CEB00 File Offset: 0x003CCD00
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickInformationDetailBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB67 RID: 64359 RVA: 0x003CECF8 File Offset: 0x003CCEF8
	protected override void OnStart()
	{
		this.AudioPlayer = new InfoDisplayAudioPlayer();
		UUIItem item = base.GetItem(8);
		if (((item != null) ? item.GetOwner() : null) == null)
		{
			return;
		}
		this.AudioPlayer.Initialize(item.GetOwner());
		UUIText text = base.GetText(6);
		if (text != null)
		{
			this.AudioPlayer.SetShowTextComponent(text);
		}
		this.AudioPlayer.SetSpectrumCallBack(new Action<TArray<float>, float>(this.OnSpectrumCall));
		this.ShowAudioItems = new List<UUIItem>();
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			for (int i = 0; i < item2.UIChildren.Num(); i++)
			{
				UUIItem uuiitem = item2.UIChildren.Get(i);
				if (uuiitem != null)
				{
					this.ShowAudioItems.Add(uuiitem);
					if (i == 0)
					{
						this.OriginalHeight = uuiitem.Height;
					}
				}
			}
		}
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		this.RefreshElement(id);
		this.AudioPlayer.Refresh(InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id));
	}

	// Token: 0x0600FB68 RID: 64360 RVA: 0x003CEDF1 File Offset: 0x003CCFF1
	private void RefreshElement(int id)
	{
		this.RefreshShowImg(id);
		this.RefreshShowText(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600FB69 RID: 64361 RVA: 0x003CEE08 File Offset: 0x003CD008
	[NullableContext(1)]
	private void OnSpectrumCall(TArray<float> array, float deltaTime)
	{
		if (this.ShowAudioItems == null)
		{
			return;
		}
		for (int i = 0; i < array.Num(); i++)
		{
			if (this.ShowAudioItems.Count > i)
			{
				float height = this.ShowAudioItems[i].Height;
				string s = array.Get(i).ToString("F1");
				float to = this.OriginalHeight * float.Parse(s);
				float height2 = MathUtils.Instance.Lerp(height, to, 0.3f);
				this.ShowAudioItems[i].SetHeight(height2);
			}
		}
	}

	// Token: 0x0600FB6A RID: 64362 RVA: 0x003CEE9C File Offset: 0x003CD09C
	private void RefreshShowImg(int id)
	{
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(id);
		if (infoDisplayPictures != null && infoDisplayPictures.Length != 0)
		{
			string text = infoDisplayPictures[0];
			if (text != "")
			{
				UUITexture texture = base.GetTexture(1);
				if (texture != null)
				{
					base.SetTextureByPath(text, texture, null, null);
				}
			}
		}
	}

	// Token: 0x0600FB6B RID: 64363 RVA: 0x003CEEEC File Offset: 0x003CD0EC
	private void RefreshShowText(int id)
	{
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(id);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(infoDisplayTitle, true);
		}
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(id);
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(infoDisplayDesc, true);
		}
	}

	// Token: 0x0600FB6C RID: 64364 RVA: 0x003CEF37 File Offset: 0x003CD137
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600FB6D RID: 64365 RVA: 0x003CEF4C File Offset: 0x003CD14C
	private void RefreshAudioShow(int id)
	{
		string infoDisplayAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id);
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(9);
		if (infoDisplayAudio != "")
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (item2 != null)
			{
				item2.SetUIActive(true);
				return;
			}
		}
		else
		{
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
	}

	// Token: 0x0600FB6E RID: 64366 RVA: 0x003CEFAC File Offset: 0x003CD1AC
	protected override void OnBeforeDestroy()
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Destroy(null);
		}
		int displayId = InfoDisplayModel.Instance.CurrentInformationId();
		InfoDisplayController.Instance.RequestReadDisplayInfo(displayId);
	}

	// Token: 0x0600FB6F RID: 64367 RVA: 0x003CEFE1 File Offset: 0x003CD1E1
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FB70 RID: 64368 RVA: 0x003CEFEC File Offset: 0x003CD1EC
	private void OnClickInformationDetailBtn()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(id);
		if (infoDisplayPictures != null && infoDisplayPictures.Length != 0)
		{
			InfoDisplayModel.Instance.SetCurrentOpenInformationTexture(infoDisplayPictures[0]);
			InfoDisplayController.Instance.OpenInfoDisplayImgView();
		}
	}

	// Token: 0x0600FB71 RID: 64369 RVA: 0x003CF030 File Offset: 0x003CD230
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeFourView.<OnBeforeHideAsync>d__17 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeFourView.<OnBeforeHideAsync>d__17>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400750A RID: 29962
	private const float LERP_PERCENTAGE = 0.3f;

	// Token: 0x0400750B RID: 29963
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x0400750C RID: 29964
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> ShowAudioItems;

	// Token: 0x0400750D RID: 29965
	private float OriginalHeight;

	// Token: 0x0200858E RID: 34190
	private class EInfoDisplayTypeFourComponents
	{
		// Token: 0x0402B7AA RID: 178090
		public const int InformationBtn = 0;

		// Token: 0x0402B7AB RID: 178091
		public const int InformationTexture = 1;

		// Token: 0x0402B7AC RID: 178092
		public const int Name = 2;

		// Token: 0x0402B7AD RID: 178093
		public const int BackBtn = 3;

		// Token: 0x0402B7AE RID: 178094
		public const int Desc = 4;

		// Token: 0x0402B7AF RID: 178095
		public const int DescItem = 5;

		// Token: 0x0402B7B0 RID: 178096
		public const int TimeText = 6;

		// Token: 0x0402B7B1 RID: 178097
		public const int BgStampImg = 7;

		// Token: 0x0402B7B2 RID: 178098
		public const int PlayItem = 8;

		// Token: 0x0402B7B3 RID: 178099
		public const int TimeLineItem = 9;

		// Token: 0x0402B7B4 RID: 178100
		public const int Puzzle = 10;
	}
}
