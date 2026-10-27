using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA2 RID: 8098
public class InfoDisplayTypeThreeView : UiTickViewBase
{
	// Token: 0x0600FB82 RID: 64386 RVA: 0x003CF703 File Offset: 0x003CD903
	[NullableContext(1)]
	public InfoDisplayTypeThreeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB83 RID: 64387 RVA: 0x003CF70C File Offset: 0x003CD90C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickCloseBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickSwitchLeftBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickSwitchRightBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB84 RID: 64388 RVA: 0x003CF98C File Offset: 0x003CDB8C
	protected override void OnStart()
	{
		this.AudioPlayer = new InfoDisplayAudioPlayer();
		UUIItem item = base.GetItem(5);
		if (((item != null) ? item.GetOwner() : null) == null)
		{
			return;
		}
		this.AudioPlayer.Initialize(item.GetOwner());
		UUIText text = base.GetText(3);
		if (text != null)
		{
			this.AudioPlayer.SetShowTextComponent(text);
		}
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		this.RefreshElement(id);
		this.AudioPlayer.Refresh(InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id));
		this.RefreshPageSwitch();
	}

	// Token: 0x0600FB85 RID: 64389 RVA: 0x003CFA14 File Offset: 0x003CDC14
	protected override void OnBeforeShow()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		string infoDisplayEntryAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayEntryAudio(id);
		if (infoDisplayEntryAudio != "")
		{
			AudioSystem.Instance.PostEvent(infoDisplayEntryAudio);
		}
	}

	// Token: 0x0600FB86 RID: 64390 RVA: 0x003CFA54 File Offset: 0x003CDC54
	protected override void OnBeforeHide()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		string infoDisplayExitAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayExitAudio(id);
		if (infoDisplayExitAudio != "")
		{
			AudioSystem.Instance.PostEvent(infoDisplayExitAudio);
		}
	}

	// Token: 0x0600FB87 RID: 64391 RVA: 0x003CFA91 File Offset: 0x003CDC91
	private void RefreshElement(int id)
	{
		this.RefreshShowText(id);
		this.RefreshBgStamp(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600FB88 RID: 64392 RVA: 0x003CFAA8 File Offset: 0x003CDCA8
	private void RefreshAudioShow(int id)
	{
		string infoDisplayAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayAudio(id);
		UUIItem item = base.GetItem(5);
		UUIItem item2 = base.GetItem(7);
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

	// Token: 0x0600FB89 RID: 64393 RVA: 0x003CFB08 File Offset: 0x003CDD08
	private void RefreshShowText(int id)
	{
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(id);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(infoDisplayTitle, true);
		}
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(id);
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(infoDisplayDesc, true);
		}
	}

	// Token: 0x0600FB8A RID: 64394 RVA: 0x003CFB54 File Offset: 0x003CDD54
	private void RefreshBgStamp(int id)
	{
		string infoDisplayBgStamp = InfoDisplayModuleConfig.Instance.GetInfoDisplayBgStamp(id);
		UUIItem item = base.GetItem(9);
		if (infoDisplayBgStamp != "")
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUITexture textureBg = base.GetTexture(8);
			if (textureBg != null)
			{
				base.SetTextureByPath(infoDisplayBgStamp, textureBg, null, delegate(bool success)
				{
					if (success)
					{
						textureBg.SetSizeFromTexture();
						textureBg.SetUIActive(true);
					}
				});
				return;
			}
		}
		else if (item != null)
		{
			item.SetUIActive(false);
		}
	}

	// Token: 0x0600FB8B RID: 64395 RVA: 0x003CFBD5 File Offset: 0x003CDDD5
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FB8C RID: 64396 RVA: 0x003CFBDE File Offset: 0x003CDDDE
	private void OnClickSwitchLeftBtn()
	{
		this.SwitchGroupPage(-1);
	}

	// Token: 0x0600FB8D RID: 64397 RVA: 0x003CFBE7 File Offset: 0x003CDDE7
	private void OnClickSwitchRightBtn()
	{
		this.SwitchGroupPage(1);
	}

	// Token: 0x0600FB8E RID: 64398 RVA: 0x003CFBF0 File Offset: 0x003CDDF0
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

	// Token: 0x0600FB8F RID: 64399 RVA: 0x003CFC5C File Offset: 0x003CDE5C
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

	// Token: 0x0600FB90 RID: 64400 RVA: 0x003CFD28 File Offset: 0x003CDF28
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

	// Token: 0x0600FB91 RID: 64401 RVA: 0x003CFD5D File Offset: 0x003CDF5D
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600FB92 RID: 64402 RVA: 0x003CFD70 File Offset: 0x003CDF70
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeThreeView.<OnBeforeHideAsync>d__18 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeThreeView.<OnBeforeHideAsync>d__18>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400750F RID: 29967
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x02008593 RID: 34195
	private class EInfoDisplayTypeThreeComponents
	{
		// Token: 0x0402B7CD RID: 178125
		public const int Name = 0;

		// Token: 0x0402B7CE RID: 178126
		public const int BgStampImg = 1;

		// Token: 0x0402B7CF RID: 178127
		public const int Desc = 2;

		// Token: 0x0402B7D0 RID: 178128
		public const int TimeText = 3;

		// Token: 0x0402B7D1 RID: 178129
		public const int BackBtn = 4;

		// Token: 0x0402B7D2 RID: 178130
		public const int PlayItem = 5;

		// Token: 0x0402B7D3 RID: 178131
		public const int DescItem = 6;

		// Token: 0x0402B7D4 RID: 178132
		public const int TimeLineItem = 7;

		// Token: 0x0402B7D5 RID: 178133
		public const int TexBg = 8;

		// Token: 0x0402B7D6 RID: 178134
		public const int BgMaskItem = 9;

		// Token: 0x0402B7D7 RID: 178135
		public const int BgMaskBlack = 10;

		// Token: 0x0402B7D8 RID: 178136
		public const int BtnSwitchLeft = 11;

		// Token: 0x0402B7D9 RID: 178137
		public const int BtnSwitchRight = 12;

		// Token: 0x0402B7DA RID: 178138
		public const int TextPageCount = 13;
	}
}
