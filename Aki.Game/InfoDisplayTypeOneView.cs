using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA1 RID: 8097
public class InfoDisplayTypeOneView : UiTickViewBase
{
	// Token: 0x0600FB72 RID: 64370 RVA: 0x003CF073 File Offset: 0x003CD273
	[NullableContext(1)]
	public InfoDisplayTypeOneView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB73 RID: 64371 RVA: 0x003CF07C File Offset: 0x003CD27C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent));
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
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickInformationDetailBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickSwitchLeftBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickSwitchRightBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB74 RID: 64372 RVA: 0x003CF320 File Offset: 0x003CD520
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
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		this.RefreshElement(id);
		this.AudioPlayer.Refresh(InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id));
		this.RefreshPageSwitch();
	}

	// Token: 0x0600FB75 RID: 64373 RVA: 0x003CF3A6 File Offset: 0x003CD5A6
	private void RefreshElement(int id)
	{
		this.RefreshShowImg(id);
		this.RefreshShowText(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600FB76 RID: 64374 RVA: 0x003CF3C0 File Offset: 0x003CD5C0
	private void RefreshShowImg(int id)
	{
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(id);
		if (infoDisplayPictures != null && infoDisplayPictures.Length != 0)
		{
			string text = infoDisplayPictures[0];
			if (text != "")
			{
				UUITextureTransitionComponent tempTexture = base.GetUiTextureTransitionComponent(1);
				if (tempTexture != null)
				{
					ResourceSystem.Instance.LoadAsync<UTexture>(text, delegate([Nullable(2)] UTexture texture, string path)
					{
						if (texture != null && texture.IsValid() && tempTexture != null && tempTexture.IsValid())
						{
							tempTexture.SetAllStateTexture(texture);
							UUITexture texture2 = this.GetTexture(10);
							if (texture2 != null)
							{
								texture2.SetTexture(texture);
								texture2.SetSizeFromTexture();
							}
						}
					}, 100, this.MemoryTag);
				}
			}
		}
	}

	// Token: 0x0600FB77 RID: 64375 RVA: 0x003CF434 File Offset: 0x003CD634
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

	// Token: 0x0600FB78 RID: 64376 RVA: 0x003CF480 File Offset: 0x003CD680
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

	// Token: 0x0600FB79 RID: 64377 RVA: 0x003CF4DE File Offset: 0x003CD6DE
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600FB7A RID: 64378 RVA: 0x003CF4F4 File Offset: 0x003CD6F4
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

	// Token: 0x0600FB7B RID: 64379 RVA: 0x003CF529 File Offset: 0x003CD729
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FB7C RID: 64380 RVA: 0x003CF532 File Offset: 0x003CD732
	private void OnClickSwitchLeftBtn()
	{
		this.SwitchGroupPage(-1);
	}

	// Token: 0x0600FB7D RID: 64381 RVA: 0x003CF53B File Offset: 0x003CD73B
	private void OnClickSwitchRightBtn()
	{
		this.SwitchGroupPage(1);
	}

	// Token: 0x0600FB7E RID: 64382 RVA: 0x003CF544 File Offset: 0x003CD744
	private void SwitchGroupPage(int offset)
	{
		InfoDisplayModel instance = InfoDisplayModel.Instance;
		int groupPageIndex = instance.GetGroupPageIndex() + offset;
		int displayId = instance.CurrentInformationId();
		if (!instance.SetGroupPageIndex(groupPageIndex))
		{
			return;
		}
		InfoDisplayController.Instance.RequestReadDisplayInfo(displayId);
		int id = instance.CurrentInformationId();
		this.RefreshElement(id);
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Refresh(InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id));
		}
		this.RefreshPageSwitch();
	}

	// Token: 0x0600FB7F RID: 64383 RVA: 0x003CF5B0 File Offset: 0x003CD7B0
	private void RefreshPageSwitch()
	{
		InfoDisplayModel instance = InfoDisplayModel.Instance;
		bool flag = instance.IsInGroupMode();
		int groupPageIndex = instance.GetGroupPageIndex();
		int groupPageCount = instance.GetGroupPageCount();
		UUIButtonComponent button = base.GetButton(11);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && groupPageIndex > 0);
		}
		UUIButtonComponent button2 = base.GetButton(12);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(flag && groupPageIndex < groupPageCount - 1);
		}
		UUIText text = base.GetText(13);
		if (text != null)
		{
			text.SetUIActive(flag);
		}
		if (flag && text != null)
		{
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupPageIndex + 1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(groupPageCount);
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x0600FB80 RID: 64384 RVA: 0x003CF67C File Offset: 0x003CD87C
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

	// Token: 0x0600FB81 RID: 64385 RVA: 0x003CF6C0 File Offset: 0x003CD8C0
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeOneView.<OnBeforeHideAsync>d__17 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeOneView.<OnBeforeHideAsync>d__17>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400750E RID: 29966
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x02008590 RID: 34192
	private class EInfoDisplayTypeOneComponents
	{
		// Token: 0x0402B7B9 RID: 178105
		public const int InformationBtn = 0;

		// Token: 0x0402B7BA RID: 178106
		public const int InformationTexture = 1;

		// Token: 0x0402B7BB RID: 178107
		public const int Name = 2;

		// Token: 0x0402B7BC RID: 178108
		public const int BackBtn = 3;

		// Token: 0x0402B7BD RID: 178109
		public const int Desc = 4;

		// Token: 0x0402B7BE RID: 178110
		public const int DescItem = 5;

		// Token: 0x0402B7BF RID: 178111
		public const int TimeText = 6;

		// Token: 0x0402B7C0 RID: 178112
		public const int BgStampImg = 7;

		// Token: 0x0402B7C1 RID: 178113
		public const int PlayItem = 8;

		// Token: 0x0402B7C2 RID: 178114
		public const int TimeLineItem = 9;

		// Token: 0x0402B7C3 RID: 178115
		public const int Texture = 10;

		// Token: 0x0402B7C4 RID: 178116
		public const int BtnSwitchLeft = 11;

		// Token: 0x0402B7C5 RID: 178117
		public const int BtnSwitchRight = 12;

		// Token: 0x0402B7C6 RID: 178118
		public const int TextPageCount = 13;
	}
}
