using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001463 RID: 5219
public class InfoDisplayTypeOneView : UiTickViewBase
{
	// Token: 0x0600CF94 RID: 53140 RVA: 0x003DAC33 File Offset: 0x003D8E33
	[NullableContext(1)]
	public InfoDisplayTypeOneView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CF95 RID: 53141 RVA: 0x003DAC3C File Offset: 0x003D8E3C
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

	// Token: 0x0600CF96 RID: 53142 RVA: 0x003DAEE0 File Offset: 0x003D90E0
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

	// Token: 0x0600CF97 RID: 53143 RVA: 0x003DAF66 File Offset: 0x003D9166
	private void RefreshElement(int id)
	{
		this.RefreshShowImg(id);
		this.RefreshShowText(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600CF98 RID: 53144 RVA: 0x003DAF80 File Offset: 0x003D9180
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

	// Token: 0x0600CF99 RID: 53145 RVA: 0x003DAFF4 File Offset: 0x003D91F4
	private void RefreshShowText(int id)
	{
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(id);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(infoDisplayTitle, true);
		}
		string text2 = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(id);
		string extraTopDesc = InfoDisplayModel.Instance.GetExtraTopDesc();
		if (!string.IsNullOrEmpty(extraTopDesc))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted("ffd12f");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(extraTopDesc);
			defaultInterpolatedStringHandler.AppendLiteral("</color>\n");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		UUIText text3 = base.GetText(4);
		if (text3 != null)
		{
			text3.SetText(text2, true);
		}
	}

	// Token: 0x0600CF9A RID: 53146 RVA: 0x003DB0A8 File Offset: 0x003D92A8
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

	// Token: 0x0600CF9B RID: 53147 RVA: 0x003DB106 File Offset: 0x003D9306
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600CF9C RID: 53148 RVA: 0x003DB11C File Offset: 0x003D931C
	protected override void OnBeforeDestroy()
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer != null)
		{
			audioPlayer.Destroy(null);
		}
		InfoDisplayModel.Instance.SetExtraTopDesc(null);
		int displayId = InfoDisplayModel.Instance.CurrentInformationId();
		InfoDisplayController.Instance.RequestReadDisplayInfo(displayId);
	}

	// Token: 0x0600CF9D RID: 53149 RVA: 0x003DB15C File Offset: 0x003D935C
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CF9E RID: 53150 RVA: 0x003DB165 File Offset: 0x003D9365
	private void OnClickSwitchLeftBtn()
	{
		this.SwitchGroupPage(-1);
	}

	// Token: 0x0600CF9F RID: 53151 RVA: 0x003DB16E File Offset: 0x003D936E
	private void OnClickSwitchRightBtn()
	{
		this.SwitchGroupPage(1);
	}

	// Token: 0x0600CFA0 RID: 53152 RVA: 0x003DB178 File Offset: 0x003D9378
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

	// Token: 0x0600CFA1 RID: 53153 RVA: 0x003DB1E4 File Offset: 0x003D93E4
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

	// Token: 0x0600CFA2 RID: 53154 RVA: 0x003DB2B0 File Offset: 0x003D94B0
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

	// Token: 0x0600CFA3 RID: 53155 RVA: 0x003DB2F4 File Offset: 0x003D94F4
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeOneView.<OnBeforeHideAsync>d__18 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeOneView.<OnBeforeHideAsync>d__18>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040075F0 RID: 30192
	[Nullable(1)]
	private const string EXTRA_TOP_DESC_COLOR = "ffd12f";

	// Token: 0x040075F1 RID: 30193
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x02007715 RID: 30485
	private class EInfoDisplayTypeOneComponents
	{
		// Token: 0x04026ADC RID: 158428
		public const int InformationBtn = 0;

		// Token: 0x04026ADD RID: 158429
		public const int InformationTexture = 1;

		// Token: 0x04026ADE RID: 158430
		public const int Name = 2;

		// Token: 0x04026ADF RID: 158431
		public const int BackBtn = 3;

		// Token: 0x04026AE0 RID: 158432
		public const int Desc = 4;

		// Token: 0x04026AE1 RID: 158433
		public const int DescItem = 5;

		// Token: 0x04026AE2 RID: 158434
		public const int TimeText = 6;

		// Token: 0x04026AE3 RID: 158435
		public const int BgStampImg = 7;

		// Token: 0x04026AE4 RID: 158436
		public const int PlayItem = 8;

		// Token: 0x04026AE5 RID: 158437
		public const int TimeLineItem = 9;

		// Token: 0x04026AE6 RID: 158438
		public const int Texture = 10;

		// Token: 0x04026AE7 RID: 158439
		public const int BtnSwitchLeft = 11;

		// Token: 0x04026AE8 RID: 158440
		public const int BtnSwitchRight = 12;

		// Token: 0x04026AE9 RID: 158441
		public const int TextPageCount = 13;
	}
}
