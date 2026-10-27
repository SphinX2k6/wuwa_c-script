using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020016AF RID: 5807
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundTypeItem : SyncGridProxyAbstract<INewSoundTypeItemData>
{
	// Token: 0x0600A59A RID: 42394 RVA: 0x0025045C File Offset: 0x0024E65C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A59B RID: 42395 RVA: 0x002505C8 File Offset: 0x0024E7C8
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(3);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle != null)
		{
			toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			this.Tag = new NewSoundTypeTagItem();
			this.Tag.CreateByActorAsync(item.GetOwner(), null, false).Forget();
		}
	}

	// Token: 0x0600A59C RID: 42396 RVA: 0x00250634 File Offset: 0x0024E834
	[NullableContext(1)]
	public void BindOnToggleFunc(Action<int, UUIExtendToggle> toggleFunc)
	{
		this.ToggleFunc = delegate(int curId, UUIExtendToggle toggle)
		{
			toggleFunc(curId, toggle);
			if (this.GetRedDotState())
			{
				AdventureGuideModel.Instance.RecordAllDetectionBySecondary(this.TypeId);
				this.RefreshRedDotState();
				if (this.FromTabViewName != null)
				{
					if (this.FromTabViewName == EUiTabViewName.NewSoundAreaView)
					{
						EventSystem.Instance.Emit(EEventName.RedDotNewSoundAreaTabUpdate);
						return;
					}
					if (this.FromTabViewName == EUiTabViewName.DisposableChallengeView)
					{
						EventSystem.Instance.Emit(EEventName.RedDotAdventureChallengeTabUpdate);
					}
				}
			}
		};
	}

	// Token: 0x0600A59D RID: 42397 RVA: 0x00250667 File Offset: 0x0024E867
	[NullableContext(1)]
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0600A59E RID: 42398 RVA: 0x00250670 File Offset: 0x0024E870
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked((int)this.TypeId);
	}

	// Token: 0x0600A59F RID: 42399 RVA: 0x00250690 File Offset: 0x0024E890
	[NullableContext(1)]
	public override void Refresh(INewSoundTypeItemData data)
	{
		this.TypeId = data.TypeId;
		this.FromTabViewName = data.FromTabViewName;
		SecondaryGuideData value = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf((int)this.TypeId).Value;
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, value.Text, Array.Empty<object>());
		UUIText text2 = base.GetText(2);
		LguiUtil.Instance.TrySetLocalTextNew(text2, value.SubText, Array.Empty<object>());
		this.SetSpriteByPath(value.Icon, base.GetSprite(0), false, null, null);
		this.SetSpriteByPath(value.Icon, base.GetSprite(6), false, null, null);
		this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshDoubleIcon();
		this.RefreshRedDotState();
	}

	// Token: 0x0600A5A0 RID: 42400 RVA: 0x00250768 File Offset: 0x0024E968
	public void RefreshDoubleIcon()
	{
		this.RefreshAllTagState();
	}

	// Token: 0x0600A5A1 RID: 42401 RVA: 0x00250770 File Offset: 0x0024E970
	public void RefreshRedDotState()
	{
		bool flag = AdventureGuideModel.Instance.CheckRedDotSecondary(this.TypeId);
		bool flag2 = AdventureGuideModel.Instance.CheckExtraRedDotSecondary(this.TypeId);
		this.RedDotState = (flag || flag2);
		this.RefreshAllTagState();
	}

	// Token: 0x0600A5A2 RID: 42402 RVA: 0x002507AE File Offset: 0x0024E9AE
	public bool GetRedDotState()
	{
		return this.RedDotState;
	}

	// Token: 0x0600A5A3 RID: 42403 RVA: 0x002507B8 File Offset: 0x0024E9B8
	private void RefreshAllTagState()
	{
		bool flag = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(this.TypeId) != null || ActivityRegressModel.Instance.IsHasDoubleDrop(this.TypeId);
		bool flag2 = !flag && this.CheckIsActivityTag();
		bool flag3 = !flag && !flag2 && AdventureGuideModel.Instance.GetIsDetectionPreOpenByDungeonType(this.TypeId);
		bool uiactive = !flag && !flag2 && !flag3 && this.RedDotState;
		base.GetItem(4).SetUIActive(flag);
		base.GetItem(5).SetUIActive(uiactive);
		if (flag2)
		{
			base.GetItem(7).SetUIActive(true);
			NewSoundTypeTagItem tag = this.Tag;
			if (tag == null)
			{
				return;
			}
			tag.RefreshItem(true);
			return;
		}
		else
		{
			if (!flag3)
			{
				base.GetItem(7).SetUIActive(false);
				return;
			}
			base.GetItem(7).SetUIActive(true);
			NewSoundTypeTagItem tag2 = this.Tag;
			if (tag2 == null)
			{
				return;
			}
			tag2.RefreshItem(false);
			return;
		}
	}

	// Token: 0x0600A5A4 RID: 42404 RVA: 0x00250890 File Offset: 0x0024EA90
	private bool CheckIsActivityTag()
	{
		if (this.TypeId != EDungeonType.NoSoundArea)
		{
			return false;
		}
		List<EAdventurePreOpenPlayType> playerType = AdventureGuideController.Instance.GetPlayerType();
		return playerType.Contains(EAdventurePreOpenPlayType.Regress) || playerType.Contains(EAdventurePreOpenPlayType.Beginner);
	}

	// Token: 0x0600A5A5 RID: 42405 RVA: 0x002508C6 File Offset: 0x0024EAC6
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunc((int)this.TypeId, this.Toggle);
		}
	}

	// Token: 0x0600A5A6 RID: 42406 RVA: 0x002508E3 File Offset: 0x0024EAE3
	public void OnSelected(bool bFireEvent)
	{
		if (bFireEvent)
		{
			this.SetSelectToggle(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600A5A7 RID: 42407 RVA: 0x002508EF File Offset: 0x0024EAEF
	public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(3).SetToggleStateForce(state, false, false, true);
		this.ToggleFunc((int)this.TypeId, this.Toggle);
	}

	// Token: 0x0600A5A8 RID: 42408 RVA: 0x00250918 File Offset: 0x0024EB18
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(3);
	}

	// Token: 0x0600A5A9 RID: 42409 RVA: 0x00250924 File Offset: 0x0024EB24
	public UUIItem GetButtonItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x04004ADC RID: 19164
	private EDungeonType TypeId = EDungeonType.Mat;

	// Token: 0x04004ADD RID: 19165
	private EUiTabViewName? FromTabViewName;

	// Token: 0x04004ADE RID: 19166
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004ADF RID: 19167
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04004AE0 RID: 19168
	private UUIExtendToggle Toggle;

	// Token: 0x04004AE1 RID: 19169
	private bool RedDotState;

	// Token: 0x04004AE2 RID: 19170
	private NewSoundTypeTagItem Tag;

	// Token: 0x02007C84 RID: 31876
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x04028DA1 RID: 167329
		Icon,
		// Token: 0x04028DA2 RID: 167330
		TypeText,
		// Token: 0x04028DA3 RID: 167331
		SubText,
		// Token: 0x04028DA4 RID: 167332
		Toggle,
		// Token: 0x04028DA5 RID: 167333
		DoubleTip,
		// Token: 0x04028DA6 RID: 167334
		RedDotItem,
		// Token: 0x04028DA7 RID: 167335
		SprIconR,
		// Token: 0x04028DA8 RID: 167336
		TagItem
	}
}
