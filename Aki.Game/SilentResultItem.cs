using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B72 RID: 2930
public class SilentResultItem : UiPanelBase
{
	// Token: 0x060079E7 RID: 31207 RVA: 0x0025C111 File Offset: 0x0025A311
	[NullableContext(1)]
	public SilentResultItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060079E8 RID: 31208 RVA: 0x0025C128 File Offset: 0x0025A328
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060079E9 RID: 31209 RVA: 0x0025C274 File Offset: 0x0025A474
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ExtendToggle.OnPostAudioEvent.Bind(delegate(string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
		this.ExtendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
	}

	// Token: 0x060079EA RID: 31210 RVA: 0x0025C2D6 File Offset: 0x0025A4D6
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
		this.Data = null;
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x060079EB RID: 31211 RVA: 0x0025C308 File Offset: 0x0025A508
	[NullableContext(1)]
	public void Update(SilentAreaDetectionRecord data)
	{
		this.Data = data;
		UUIText text = base.GetText(4);
		string name = data.Conf.Name;
		LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
		base.GetText(3).SetUIActive(false);
		base.GetTexture(1).SetUIActive(false);
		UUIItem item = base.GetItem(2);
		if (data.IsLock)
		{
			item.SetUIActive(true);
			text.SetUIActive(false);
		}
		else
		{
			item.SetUIActive(false);
			text.SetUIActive(true);
		}
		base.GetSprite(5).SetUIActive(data.IsTargeting);
		this.BindRedDot();
	}

	// Token: 0x060079EC RID: 31212 RVA: 0x0025C3A4 File Offset: 0x0025A5A4
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.AdventureFirstAwardResult, base.GetItem(6), null, this.Data.Conf.Id);
	}

	// Token: 0x060079ED RID: 31213 RVA: 0x0025C3D8 File Offset: 0x0025A5D8
	private void UnbindRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.AdventureFirstAwardResult, base.GetItem(6), this.Data.Conf.Id);
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x0025C414 File Offset: 0x0025A614
	public void BindResultCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<int, UUIExtendToggle> onResultCallback)
	{
		this.ResultCallback = onResultCallback;
	}

	// Token: 0x060079EF RID: 31215 RVA: 0x0025C420 File Offset: 0x0025A620
	public void OnClickExtendToggle(EToggleState state)
	{
		if (this.ResultCallback != null)
		{
			this.ResultCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x04004BA1 RID: 19361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ResultCallback;

	// Token: 0x04004BA2 RID: 19362
	[Nullable(2)]
	private SilentAreaDetectionRecord Data;

	// Token: 0x04004BA3 RID: 19363
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x02006E13 RID: 28179
	private enum ESilentResultDefine
	{
		// Token: 0x04024101 RID: 147713
		ExtendToggle,
		// Token: 0x04024102 RID: 147714
		TargetPic,
		// Token: 0x04024103 RID: 147715
		NotFoundItem,
		// Token: 0x04024104 RID: 147716
		LvlTxt,
		// Token: 0x04024105 RID: 147717
		NameTxt,
		// Token: 0x04024106 RID: 147718
		TargetingIco,
		// Token: 0x04024107 RID: 147719
		RedDotItem
	}
}
