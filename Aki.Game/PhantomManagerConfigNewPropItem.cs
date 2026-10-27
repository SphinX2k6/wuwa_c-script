using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200242E RID: 9262
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PhantomManagerConfigNewPropItem : GridProxyAbstract<IPhantomManagerConfigNewSettingDetailInfo>
{
	// Token: 0x06012931 RID: 76081 RVA: 0x00494230 File Offset: 0x00492430
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06012932 RID: 76082 RVA: 0x00494384 File Offset: 0x00492584
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(base.GetRootItem());
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnClickedDiscard));
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(8);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.OnStateChange.Add(new Action<EToggleState>(this.OnClickedLock));
	}

	// Token: 0x06012933 RID: 76083 RVA: 0x004943E8 File Offset: 0x004925E8
	public override void Refresh(IPhantomManagerConfigNewSettingDetailInfo data, bool isSelected, int gridIndex)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.MainPropId);
		this.CurData = data;
		base.GetText(2).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(1), null, null);
		this.RefreshState(data.IsEdit, false);
	}

	// Token: 0x06012934 RID: 76084 RVA: 0x0049445C File Offset: 0x0049265C
	public void RefreshState(bool isEdit, bool needAnim = false)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(isEdit);
		}
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(!isEdit);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(isEdit);
		}
		EPhantomManagerConfigState propCurrentState = PhantomBattleModel.Instance.GetPhantomConfigData().GetPropCurrentState(this.CurData);
		if (needAnim && propCurrentState != this.CurState)
		{
			LevelSequencePlayer levelSequence = this.LevelSequence;
			if (levelSequence != null)
			{
				levelSequence.PlayOrReplaySequenceByName("Refresh", false, null);
			}
		}
		this.CurState = propCurrentState;
		if (isEdit)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(8);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState((propCurrentState == EPhantomManagerConfigState.Lock) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(7);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleState((propCurrentState == EPhantomManagerConfigState.Discard) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		else
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(propCurrentState == EPhantomManagerConfigState.Lock);
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(propCurrentState == EPhantomManagerConfigState.Discard);
			return;
		}
	}

	// Token: 0x06012935 RID: 76085 RVA: 0x00494558 File Offset: 0x00492758
	private void OnClickedDiscard(EToggleState state)
	{
		PhantomManagerConfigData phantomConfigData = PhantomBattleModel.Instance.GetPhantomConfigData();
		if (state == EToggleState.ETT_UnChecked)
		{
			phantomConfigData.SetPropCurrentState(this.CurData, EPhantomManagerConfigState.Default, true);
			this.CurState = EPhantomManagerConfigState.Default;
			return;
		}
		EPhantomManagerConfigState propCurrentState = phantomConfigData.GetPropCurrentState(this.CurData);
		ScrollingTipsController.Instance.ShowTipsByTextId((propCurrentState == EPhantomManagerConfigState.Default) ? "PhantomProject_ModifyPlan_Des_3" : "PhantomProject_ModifyPlan_Des_5", Array.Empty<object>());
		UUIExtendToggle extendToggle = base.GetExtendToggle(8);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		phantomConfigData.SetPropCurrentState(this.CurData, EPhantomManagerConfigState.Discard, true);
		this.CurState = EPhantomManagerConfigState.Discard;
	}

	// Token: 0x06012936 RID: 76086 RVA: 0x004945E0 File Offset: 0x004927E0
	private void OnClickedLock(EToggleState state)
	{
		PhantomManagerConfigData phantomConfigData = PhantomBattleModel.Instance.GetPhantomConfigData();
		if (state == EToggleState.ETT_UnChecked)
		{
			phantomConfigData.SetPropCurrentState(this.CurData, EPhantomManagerConfigState.Default, true);
			this.CurState = EPhantomManagerConfigState.Default;
			return;
		}
		EPhantomManagerConfigState propCurrentState = phantomConfigData.GetPropCurrentState(this.CurData);
		ScrollingTipsController.Instance.ShowTipsByTextId((propCurrentState == EPhantomManagerConfigState.Default) ? "PhantomProject_ModifyPlan_Des_2" : "PhantomProject_ModifyPlan_Des_4", Array.Empty<object>());
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		phantomConfigData.SetPropCurrentState(this.CurData, EPhantomManagerConfigState.Lock, true);
		this.CurState = EPhantomManagerConfigState.Lock;
	}

	// Token: 0x04008BFC RID: 35836
	protected IPhantomManagerConfigNewSettingDetailInfo CurData = new PhantomManagerConfigNewSettingDetailInfo();

	// Token: 0x04008BFD RID: 35837
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008BFE RID: 35838
	protected EPhantomManagerConfigState CurState;

	// Token: 0x020089B0 RID: 35248
	[NullableContext(0)]
	private enum EItem
	{
		// Token: 0x0402CBCF RID: 183247
		BtnSetProp,
		// Token: 0x0402CBD0 RID: 183248
		TexIcon,
		// Token: 0x0402CBD1 RID: 183249
		TxtName,
		// Token: 0x0402CBD2 RID: 183250
		PanelPreviewState,
		// Token: 0x0402CBD3 RID: 183251
		SpriteLock,
		// Token: 0x0402CBD4 RID: 183252
		SpriteDiscard,
		// Token: 0x0402CBD5 RID: 183253
		PanelEdit,
		// Token: 0x0402CBD6 RID: 183254
		ToggleDiscard,
		// Token: 0x0402CBD7 RID: 183255
		ToggleLock
	}
}
