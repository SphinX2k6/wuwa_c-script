using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001913 RID: 6419
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class PhantomManagerConfigNewPropItem : GridProxyAbstract<IPhantomManagerConfigNewSettingDetailInfo>
{
	// Token: 0x0600FDE7 RID: 64999 RVA: 0x004A17FC File Offset: 0x0049F9FC
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

	// Token: 0x0600FDE8 RID: 65000 RVA: 0x004A1950 File Offset: 0x0049FB50
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

	// Token: 0x0600FDE9 RID: 65001 RVA: 0x004A19B4 File Offset: 0x0049FBB4
	public override void Refresh(IPhantomManagerConfigNewSettingDetailInfo data, bool isSelected, int gridIndex)
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(data.MainPropId);
		this.CurData = data;
		base.GetText(2).ShowTextNew(propertyIndexInfo.Value.Name);
		base.SetTextureByPath(propertyIndexInfo.Value.Icon, base.GetTexture(1), null, null);
		this.RefreshState(data.IsEdit, false);
	}

	// Token: 0x0600FDEA RID: 65002 RVA: 0x004A1A28 File Offset: 0x0049FC28
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

	// Token: 0x0600FDEB RID: 65003 RVA: 0x004A1B24 File Offset: 0x0049FD24
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

	// Token: 0x0600FDEC RID: 65004 RVA: 0x004A1BAC File Offset: 0x0049FDAC
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

	// Token: 0x04008D43 RID: 36163
	protected IPhantomManagerConfigNewSettingDetailInfo CurData = new PhantomManagerConfigNewSettingDetailInfo();

	// Token: 0x04008D44 RID: 36164
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04008D45 RID: 36165
	protected EPhantomManagerConfigState CurState;

	// Token: 0x02007B37 RID: 31543
	[NullableContext(0)]
	private enum EItem
	{
		// Token: 0x04027EE5 RID: 163557
		BtnSetProp,
		// Token: 0x04027EE6 RID: 163558
		TexIcon,
		// Token: 0x04027EE7 RID: 163559
		TxtName,
		// Token: 0x04027EE8 RID: 163560
		PanelPreviewState,
		// Token: 0x04027EE9 RID: 163561
		SpriteLock,
		// Token: 0x04027EEA RID: 163562
		SpriteDiscard,
		// Token: 0x04027EEB RID: 163563
		PanelEdit,
		// Token: 0x04027EEC RID: 163564
		ToggleDiscard,
		// Token: 0x04027EED RID: 163565
		ToggleLock
	}
}
