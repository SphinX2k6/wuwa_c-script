using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x0200127F RID: 4735
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoLevelGroupItem : AutoAttachItem<FightPhotoLevelGroupData>
{
	// Token: 0x06008143 RID: 33091 RVA: 0x001B6A35 File Offset: 0x001B4C35
	public FightPhotoLevelGroupItem(AActor uiItem = null) : base(null)
	{
	}

	// Token: 0x06008144 RID: 33092 RVA: 0x001B6A40 File Offset: 0x001B4C40
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list;
	}

	// Token: 0x06008145 RID: 33093 RVA: 0x001B6B45 File Offset: 0x001B4D45
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x06008146 RID: 33094 RVA: 0x001B6B69 File Offset: 0x001B4D69
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x06008147 RID: 33095 RVA: 0x001B6B87 File Offset: 0x001B4D87
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x06008148 RID: 33096 RVA: 0x001B6BA5 File Offset: 0x001B4DA5
	public override void OnSelect()
	{
		if (this.Data != null && this.OnSelectCallback != null)
		{
			this.OnSelectCallback(base.GetItemIndex(), this.Data);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06008149 RID: 33097 RVA: 0x001B6BE3 File Offset: 0x001B4DE3
	protected override void OnUnSelect()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600814A RID: 33098 RVA: 0x001B6BFC File Offset: 0x001B4DFC
	protected override void OnRefreshItem(FightPhotoLevelGroupData data)
	{
		this.Data = data;
		bool flag = data != null;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag && data.IsFinished);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(flag && !data.IsUnLock);
		}
		UUITexture texture = base.GetTexture(4);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUITexture texture2 = base.GetTexture(5);
		if (texture2 != null)
		{
			texture2.SetUIActive(flag);
		}
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		this.RefreshRedDot();
		if (!flag)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_BattlePhotoRoleEmpty");
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			base.GetExtendToggle(0).SetSelfInteractive(false);
		}
		else
		{
			base.GetExtendToggle(0).SetSelfInteractive(true);
			string path = this.Data.IsUnLock ? this.Data.RoleTextureLight : this.Data.RoleTextureDark;
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			base.SetTextureByPath(this.Data.NumTexture, base.GetTexture(4), null, null);
			base.SetTextureByPath(this.Data.NumTexture2, base.GetTexture(5), null, null);
		}
		if (this.Data != null && !this.Data.IsUnLock)
		{
			this.AddTimer();
			return;
		}
		this.RemoveTimer();
	}

	// Token: 0x0600814B RID: 33099 RVA: 0x001B6D81 File Offset: 0x001B4F81
	private void UpdateUnlock(float delta)
	{
		if (this.Data != null && this.Data.IsUnLock)
		{
			this.OnRefreshItem(this.Data);
		}
	}

	// Token: 0x0600814C RID: 33100 RVA: 0x001B6DA4 File Offset: 0x001B4FA4
	private void AddTimer()
	{
		this.RemoveTimer();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateUnlock), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x0600814D RID: 33101 RVA: 0x001B6DDB File Offset: 0x001B4FDB
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600814E RID: 33102 RVA: 0x001B6DFD File Offset: 0x001B4FFD
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveTimer();
	}

	// Token: 0x0600814F RID: 33103 RVA: 0x001B6E0C File Offset: 0x001B500C
	public void RefreshRedDot()
	{
		bool uiactive = this.Data != null && this.Data.HasRedDot;
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06008150 RID: 33104 RVA: 0x001B6E42 File Offset: 0x001B5042
	private void OnRefreshFightPhotoLevelRedDot()
	{
		this.RefreshRedDot();
	}

	// Token: 0x06008151 RID: 33105 RVA: 0x001B6E4A File Offset: 0x001B504A
	protected override void OnMoveItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x001B6E61 File Offset: 0x001B5061
	private void OnToggleClick(EToggleState toggleState)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		Action<int, FightPhotoLevelGroupData> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(base.GetItemIndex(), this.Data);
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x001B6E95 File Offset: 0x001B5095
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x04003A98 RID: 15000
	private FightPhotoLevelGroupData Data;

	// Token: 0x04003A99 RID: 15001
	private TimerHandle TimerHandle;

	// Token: 0x04003A9A RID: 15002
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, FightPhotoLevelGroupData> OnToggleClickCallback;

	// Token: 0x04003A9B RID: 15003
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, FightPhotoLevelGroupData> OnSelectCallback;

	// Token: 0x04003A9C RID: 15004
	public Func<bool> CheckToggleCanClick;

	// Token: 0x02007895 RID: 30869
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x04027BB2 RID: 162738
		ToggleRoot,
		// Token: 0x04027BB3 RID: 162739
		TextureRole,
		// Token: 0x04027BB4 RID: 162740
		ItemFinished,
		// Token: 0x04027BB5 RID: 162741
		ItemLock,
		// Token: 0x04027BB6 RID: 162742
		TextureNum,
		// Token: 0x04027BB7 RID: 162743
		TextureNum2,
		// Token: 0x04027BB8 RID: 162744
		TextName,
		// Token: 0x04027BB9 RID: 162745
		ItemRedDot
	}
}
