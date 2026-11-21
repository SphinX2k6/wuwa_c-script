using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001464 RID: 5220
public class InfoDisplayTypeThreeView : UiTickViewBase
{
	// Token: 0x0600CFA4 RID: 53156 RVA: 0x003DB337 File Offset: 0x003D9537
	[NullableContext(1)]
	public InfoDisplayTypeThreeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CFA5 RID: 53157 RVA: 0x003DB340 File Offset: 0x003D9540
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

	// Token: 0x0600CFA6 RID: 53158 RVA: 0x003DB5C0 File Offset: 0x003D97C0
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

	// Token: 0x0600CFA7 RID: 53159 RVA: 0x003DB648 File Offset: 0x003D9848
	protected override void OnBeforeShow()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		string infoDisplayEntryAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayEntryAudio(id);
		if (infoDisplayEntryAudio != "")
		{
			AudioSystem.Instance.PostEvent(infoDisplayEntryAudio);
		}
	}

	// Token: 0x0600CFA8 RID: 53160 RVA: 0x003DB688 File Offset: 0x003D9888
	protected override void OnBeforeHide()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		string infoDisplayExitAudio = InfoDisplayModuleConfig.Instance.GetInfoDisplayExitAudio(id);
		if (infoDisplayExitAudio != "")
		{
			AudioSystem.Instance.PostEvent(infoDisplayExitAudio);
		}
	}

	// Token: 0x0600CFA9 RID: 53161 RVA: 0x003DB6C5 File Offset: 0x003D98C5
	private void RefreshElement(int id)
	{
		this.RefreshShowText(id);
		this.RefreshBgStamp(id);
		this.RefreshAudioShow(id);
	}

	// Token: 0x0600CFAA RID: 53162 RVA: 0x003DB6DC File Offset: 0x003D98DC
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

	// Token: 0x0600CFAB RID: 53163 RVA: 0x003DB73C File Offset: 0x003D993C
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

	// Token: 0x0600CFAC RID: 53164 RVA: 0x003DB788 File Offset: 0x003D9988
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

	// Token: 0x0600CFAD RID: 53165 RVA: 0x003DB809 File Offset: 0x003D9A09
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CFAE RID: 53166 RVA: 0x003DB812 File Offset: 0x003D9A12
	private void OnClickSwitchLeftBtn()
	{
		this.SwitchGroupPage(-1);
	}

	// Token: 0x0600CFAF RID: 53167 RVA: 0x003DB81B File Offset: 0x003D9A1B
	private void OnClickSwitchRightBtn()
	{
		this.SwitchGroupPage(1);
	}

	// Token: 0x0600CFB0 RID: 53168 RVA: 0x003DB824 File Offset: 0x003D9A24
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

	// Token: 0x0600CFB1 RID: 53169 RVA: 0x003DB890 File Offset: 0x003D9A90
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

	// Token: 0x0600CFB2 RID: 53170 RVA: 0x003DB95C File Offset: 0x003D9B5C
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

	// Token: 0x0600CFB3 RID: 53171 RVA: 0x003DB991 File Offset: 0x003D9B91
	protected override void OnTick(float delta)
	{
		InfoDisplayAudioPlayer audioPlayer = this.AudioPlayer;
		if (audioPlayer == null)
		{
			return;
		}
		audioPlayer.OnTick(delta);
	}

	// Token: 0x0600CFB4 RID: 53172 RVA: 0x003DB9A4 File Offset: 0x003D9BA4
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeThreeView.<OnBeforeHideAsync>d__18 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeThreeView.<OnBeforeHideAsync>d__18>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040075F2 RID: 30194
	[Nullable(2)]
	private InfoDisplayAudioPlayer AudioPlayer;

	// Token: 0x02007718 RID: 30488
	private class EInfoDisplayTypeThreeComponents
	{
		// Token: 0x04026AF0 RID: 158448
		public const int Name = 0;

		// Token: 0x04026AF1 RID: 158449
		public const int BgStampImg = 1;

		// Token: 0x04026AF2 RID: 158450
		public const int Desc = 2;

		// Token: 0x04026AF3 RID: 158451
		public const int TimeText = 3;

		// Token: 0x04026AF4 RID: 158452
		public const int BackBtn = 4;

		// Token: 0x04026AF5 RID: 158453
		public const int PlayItem = 5;

		// Token: 0x04026AF6 RID: 158454
		public const int DescItem = 6;

		// Token: 0x04026AF7 RID: 158455
		public const int TimeLineItem = 7;

		// Token: 0x04026AF8 RID: 158456
		public const int TexBg = 8;

		// Token: 0x04026AF9 RID: 158457
		public const int BgMaskItem = 9;

		// Token: 0x04026AFA RID: 158458
		public const int BgMaskBlack = 10;

		// Token: 0x04026AFB RID: 158459
		public const int BtnSwitchLeft = 11;

		// Token: 0x04026AFC RID: 158460
		public const int BtnSwitchRight = 12;

		// Token: 0x04026AFD RID: 158461
		public const int TextPageCount = 13;
	}
}
