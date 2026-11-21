using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001462 RID: 5218
public class InfoDisplayTypeFourView : UiTickViewBase
{
	// Token: 0x0600CF87 RID: 53127 RVA: 0x003DA6B4 File Offset: 0x003D88B4
	[NullableContext(1)]
	public InfoDisplayTypeFourView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CF88 RID: 53128 RVA: 0x003DA6C0 File Offset: 0x003D88C0
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

	// Token: 0x0600CF89 RID: 53129 RVA: 0x003DA8B8 File Offset: 0x003D8AB8
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

	// Token: 0x0600CF8A RID: 53130 RVA: 0x003DA9B1 File Offset: 0x003D8BB1
	private void RefreshElement(int id)
	{
		this.RefreshShowImg(id);
		this.RefreshShowText(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600CF8B RID: 53131 RVA: 0x003DA9C8 File Offset: 0x003D8BC8
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

	// Token: 0x0600CF8C RID: 53132 RVA: 0x003DAA5C File Offset: 0x003D8C5C
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

	// Token: 0x0600CF8D RID: 53133 RVA: 0x003DAAAC File Offset: 0x003D8CAC
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

	// Token: 0x0600CF8E RID: 53134 RVA: 0x003DAAF7 File Offset: 0x003D8CF7
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600CF8F RID: 53135 RVA: 0x003DAB0C File Offset: 0x003D8D0C
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

	// Token: 0x0600CF90 RID: 53136 RVA: 0x003DAB6C File Offset: 0x003D8D6C
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

	// Token: 0x0600CF91 RID: 53137 RVA: 0x003DABA1 File Offset: 0x003D8DA1
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CF92 RID: 53138 RVA: 0x003DABAC File Offset: 0x003D8DAC
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

	// Token: 0x0600CF93 RID: 53139 RVA: 0x003DABF0 File Offset: 0x003D8DF0
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeFourView.<OnBeforeHideAsync>d__17 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeFourView.<OnBeforeHideAsync>d__17>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040075EC RID: 30188
	private const float LERP_PERCENTAGE = 0.3f;

	// Token: 0x040075ED RID: 30189
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x040075EE RID: 30190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> ShowAudioItems;

	// Token: 0x040075EF RID: 30191
	private float OriginalHeight;

	// Token: 0x02007713 RID: 30483
	private class EInfoDisplayTypeFourComponents
	{
		// Token: 0x04026ACD RID: 158413
		public const int InformationBtn = 0;

		// Token: 0x04026ACE RID: 158414
		public const int InformationTexture = 1;

		// Token: 0x04026ACF RID: 158415
		public const int Name = 2;

		// Token: 0x04026AD0 RID: 158416
		public const int BackBtn = 3;

		// Token: 0x04026AD1 RID: 158417
		public const int Desc = 4;

		// Token: 0x04026AD2 RID: 158418
		public const int DescItem = 5;

		// Token: 0x04026AD3 RID: 158419
		public const int TimeText = 6;

		// Token: 0x04026AD4 RID: 158420
		public const int BgStampImg = 7;

		// Token: 0x04026AD5 RID: 158421
		public const int PlayItem = 8;

		// Token: 0x04026AD6 RID: 158422
		public const int TimeLineItem = 9;

		// Token: 0x04026AD7 RID: 158423
		public const int Puzzle = 10;
	}
}
