using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016BA RID: 5818
public class SilentResultItem : UiPanelBase
{
	// Token: 0x0600A607 RID: 42503 RVA: 0x00251D01 File Offset: 0x0024FF01
	[NullableContext(1)]
	public SilentResultItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A608 RID: 42504 RVA: 0x00251D18 File Offset: 0x0024FF18
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

	// Token: 0x0600A609 RID: 42505 RVA: 0x00251E64 File Offset: 0x00250064
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

	// Token: 0x0600A60A RID: 42506 RVA: 0x00251EC6 File Offset: 0x002500C6
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
		this.Data = null;
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x0600A60B RID: 42507 RVA: 0x00251EF8 File Offset: 0x002500F8
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

	// Token: 0x0600A60C RID: 42508 RVA: 0x00251F94 File Offset: 0x00250194
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.AdventureFirstAwardResult, base.GetItem(6), null, this.Data.Conf.Id);
	}

	// Token: 0x0600A60D RID: 42509 RVA: 0x00251FC8 File Offset: 0x002501C8
	private void UnbindRedDot()
	{
		if (this.Data == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.AdventureFirstAwardResult, base.GetItem(6), this.Data.Conf.Id);
	}

	// Token: 0x0600A60E RID: 42510 RVA: 0x00252004 File Offset: 0x00250204
	public void BindResultCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<int, UUIExtendToggle> onResultCallback)
	{
		this.ResultCallback = onResultCallback;
	}

	// Token: 0x0600A60F RID: 42511 RVA: 0x00252010 File Offset: 0x00250210
	public void OnClickExtendToggle(EToggleState state)
	{
		if (this.ResultCallback != null)
		{
			this.ResultCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x04004AFA RID: 19194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ResultCallback;

	// Token: 0x04004AFB RID: 19195
	[Nullable(2)]
	private SilentAreaDetectionRecord Data;

	// Token: 0x04004AFC RID: 19196
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x02007C8E RID: 31886
	private enum ESilentResultDefine
	{
		// Token: 0x04028DD8 RID: 167384
		ExtendToggle,
		// Token: 0x04028DD9 RID: 167385
		TargetPic,
		// Token: 0x04028DDA RID: 167386
		NotFoundItem,
		// Token: 0x04028DDB RID: 167387
		LvlTxt,
		// Token: 0x04028DDC RID: 167388
		NameTxt,
		// Token: 0x04028DDD RID: 167389
		TargetingIco,
		// Token: 0x04028DDE RID: 167390
		RedDotItem
	}
}
