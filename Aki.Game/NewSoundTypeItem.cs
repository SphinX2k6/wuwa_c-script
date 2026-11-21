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

// Token: 0x02000B67 RID: 2919
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class NewSoundTypeItem : SyncGridProxyAbstract<INewSoundTypeItemData>
{
	// Token: 0x0600797A RID: 31098 RVA: 0x0025A870 File Offset: 0x00258A70
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

	// Token: 0x0600797B RID: 31099 RVA: 0x0025A9DC File Offset: 0x00258BDC
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

	// Token: 0x0600797C RID: 31100 RVA: 0x0025AA48 File Offset: 0x00258C48
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

	// Token: 0x0600797D RID: 31101 RVA: 0x0025AA7B File Offset: 0x00258C7B
	[NullableContext(1)]
	public void BindCanToggleExecuteChange(Func<int, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0600797E RID: 31102 RVA: 0x0025AA84 File Offset: 0x00258C84
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked((int)this.TypeId);
	}

	// Token: 0x0600797F RID: 31103 RVA: 0x0025AAA4 File Offset: 0x00258CA4
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

	// Token: 0x06007980 RID: 31104 RVA: 0x0025AB7C File Offset: 0x00258D7C
	public void RefreshDoubleIcon()
	{
		this.RefreshAllTagState();
	}

	// Token: 0x06007981 RID: 31105 RVA: 0x0025AB84 File Offset: 0x00258D84
	public void RefreshRedDotState()
	{
		bool flag = AdventureGuideModel.Instance.CheckRedDotSecondary(this.TypeId);
		bool flag2 = AdventureGuideModel.Instance.CheckExtraRedDotSecondary(this.TypeId);
		this.RedDotState = (flag || flag2);
		this.RefreshAllTagState();
	}

	// Token: 0x06007982 RID: 31106 RVA: 0x0025ABC2 File Offset: 0x00258DC2
	public bool GetRedDotState()
	{
		return this.RedDotState;
	}

	// Token: 0x06007983 RID: 31107 RVA: 0x0025ABCC File Offset: 0x00258DCC
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

	// Token: 0x06007984 RID: 31108 RVA: 0x0025ACA4 File Offset: 0x00258EA4
	private bool CheckIsActivityTag()
	{
		if (this.TypeId != EDungeonType.NoSoundArea)
		{
			return false;
		}
		List<EAdventurePreOpenPlayType> playerType = AdventureGuideController.Instance.GetPlayerType();
		return playerType.Contains(EAdventurePreOpenPlayType.Regress) || playerType.Contains(EAdventurePreOpenPlayType.Beginner);
	}

	// Token: 0x06007985 RID: 31109 RVA: 0x0025ACDA File Offset: 0x00258EDA
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunc((int)this.TypeId, this.Toggle);
		}
	}

	// Token: 0x06007986 RID: 31110 RVA: 0x0025ACF7 File Offset: 0x00258EF7
	public void OnSelected(bool bFireEvent)
	{
		if (bFireEvent)
		{
			this.SetSelectToggle(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x06007987 RID: 31111 RVA: 0x0025AD03 File Offset: 0x00258F03
	public void SetSelectToggle(EToggleState state = EToggleState.ETT_Checked)
	{
		base.GetExtendToggle(3).SetToggleStateForce(state, false, false, true);
		this.ToggleFunc((int)this.TypeId, this.Toggle);
	}

	// Token: 0x06007988 RID: 31112 RVA: 0x0025AD2C File Offset: 0x00258F2C
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(3);
	}

	// Token: 0x06007989 RID: 31113 RVA: 0x0025AD38 File Offset: 0x00258F38
	public UUIItem GetButtonItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x04004B83 RID: 19331
	private EDungeonType TypeId = EDungeonType.Mat;

	// Token: 0x04004B84 RID: 19332
	private EUiTabViewName? FromTabViewName;

	// Token: 0x04004B85 RID: 19333
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> ToggleFunc;

	// Token: 0x04004B86 RID: 19334
	private Func<int, bool> OnCanToggleClicked;

	// Token: 0x04004B87 RID: 19335
	private UUIExtendToggle Toggle;

	// Token: 0x04004B88 RID: 19336
	private bool RedDotState;

	// Token: 0x04004B89 RID: 19337
	private NewSoundTypeTagItem Tag;

	// Token: 0x02006E09 RID: 28169
	[NullableContext(0)]
	private enum ENodeDefine
	{
		// Token: 0x040240CA RID: 147658
		Icon,
		// Token: 0x040240CB RID: 147659
		TypeText,
		// Token: 0x040240CC RID: 147660
		SubText,
		// Token: 0x040240CD RID: 147661
		Toggle,
		// Token: 0x040240CE RID: 147662
		DoubleTip,
		// Token: 0x040240CF RID: 147663
		RedDotItem,
		// Token: 0x040240D0 RID: 147664
		SprIconR,
		// Token: 0x040240D1 RID: 147665
		TagItem
	}
}
