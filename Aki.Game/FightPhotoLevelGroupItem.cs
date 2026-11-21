using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02000733 RID: 1843
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoLevelGroupItem : AutoAttachItem<FightPhotoLevelGroupData>
{
	// Token: 0x060054DA RID: 21722 RVA: 0x001BF705 File Offset: 0x001BD905
	public FightPhotoLevelGroupItem(AActor uiItem = null) : base(null)
	{
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x001BF710 File Offset: 0x001BD910
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

	// Token: 0x060054DC RID: 21724 RVA: 0x001BF815 File Offset: 0x001BDA15
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x001BF839 File Offset: 0x001BDA39
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x001BF857 File Offset: 0x001BDA57
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshFightPhotoLevelRedDot, new Action(this.OnRefreshFightPhotoLevelRedDot));
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x001BF875 File Offset: 0x001BDA75
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

	// Token: 0x060054E0 RID: 21728 RVA: 0x001BF8B3 File Offset: 0x001BDAB3
	protected override void OnUnSelect()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x001BF8CC File Offset: 0x001BDACC
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

	// Token: 0x060054E2 RID: 21730 RVA: 0x001BFA51 File Offset: 0x001BDC51
	private void UpdateUnlock(float delta)
	{
		if (this.Data != null && this.Data.IsUnLock)
		{
			this.OnRefreshItem(this.Data);
		}
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x001BFA74 File Offset: 0x001BDC74
	private void AddTimer()
	{
		this.RemoveTimer();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateUnlock), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x001BFAAB File Offset: 0x001BDCAB
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x001BFACD File Offset: 0x001BDCCD
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveTimer();
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x001BFADC File Offset: 0x001BDCDC
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

	// Token: 0x060054E7 RID: 21735 RVA: 0x001BFB12 File Offset: 0x001BDD12
	private void OnRefreshFightPhotoLevelRedDot()
	{
		this.RefreshRedDot();
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x001BFB1A File Offset: 0x001BDD1A
	protected override void OnMoveItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x001BFB31 File Offset: 0x001BDD31
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

	// Token: 0x060054EA RID: 21738 RVA: 0x001BFB65 File Offset: 0x001BDD65
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x04003B30 RID: 15152
	private FightPhotoLevelGroupData Data;

	// Token: 0x04003B31 RID: 15153
	private TimerHandle TimerHandle;

	// Token: 0x04003B32 RID: 15154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, FightPhotoLevelGroupData> OnToggleClickCallback;

	// Token: 0x04003B33 RID: 15155
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, FightPhotoLevelGroupData> OnSelectCallback;

	// Token: 0x04003B34 RID: 15156
	public Func<bool> CheckToggleCanClick;

	// Token: 0x02006A20 RID: 27168
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x04022EE3 RID: 143075
		ToggleRoot,
		// Token: 0x04022EE4 RID: 143076
		TextureRole,
		// Token: 0x04022EE5 RID: 143077
		ItemFinished,
		// Token: 0x04022EE6 RID: 143078
		ItemLock,
		// Token: 0x04022EE7 RID: 143079
		TextureNum,
		// Token: 0x04022EE8 RID: 143080
		TextureNum2,
		// Token: 0x04022EE9 RID: 143081
		TextName,
		// Token: 0x04022EEA RID: 143082
		ItemRedDot
	}
}
