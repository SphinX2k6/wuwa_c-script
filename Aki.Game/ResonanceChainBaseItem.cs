using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001E14 RID: 7700
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainBaseItem : UiPanelBase
{
	// Token: 0x17001D1E RID: 7454
	// (get) Token: 0x0601310F RID: 78095 RVA: 0x00593B25 File Offset: 0x00591D25
	protected virtual string ActivateSequenceName
	{
		get
		{
			return null;
		}
	}

	// Token: 0x06013110 RID: 78096 RVA: 0x00593B28 File Offset: 0x00591D28
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemClick))
		};
	}

	// Token: 0x06013111 RID: 78097 RVA: 0x00593BFD File Offset: 0x00591DFD
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06013112 RID: 78098 RVA: 0x00593C10 File Offset: 0x00591E10
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.Clear();
	}

	// Token: 0x06013113 RID: 78099 RVA: 0x00593C22 File Offset: 0x00591E22
	public void Update(int roleId, int resonanceId, bool isActivate)
	{
		this.ResonanceId = resonanceId;
		this.RoleId = roleId;
		this.IsActivate = isActivate;
		this.Refresh();
	}

	// Token: 0x06013114 RID: 78100 RVA: 0x00593C3F File Offset: 0x00591E3F
	public void Refresh()
	{
		this.RefreshToggleState(false);
		this.RefreshIcon();
		this.RefreshActivateItem();
		this.RefreshRedDot();
	}

	// Token: 0x06013115 RID: 78101 RVA: 0x00593C5A File Offset: 0x00591E5A
	public void ShowItem()
	{
		base.SetUiActive(true);
		this.PlayStartSequence();
	}

	// Token: 0x06013116 RID: 78102 RVA: 0x00593C69 File Offset: 0x00591E69
	[NullableContext(1)]
	public UUIItem GetUiItemForGuide()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return ((extendToggle != null) ? extendToggle.GetOwner().GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
	}

	// Token: 0x06013117 RID: 78103 RVA: 0x00593C92 File Offset: 0x00591E92
	private void OnItemClick(EToggleState toggleState)
	{
		if (this.ToggleCallBack != null)
		{
			this.ToggleCallBack(this.ResonanceId);
		}
	}

	// Token: 0x06013118 RID: 78104 RVA: 0x00593CAD File Offset: 0x00591EAD
	[NullableContext(1)]
	public void BindToggleCallBack(Action<int> callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x06013119 RID: 78105 RVA: 0x00593CB8 File Offset: 0x00591EB8
	public void RefreshToggleState(bool force = false)
	{
		EToggleState state = this.IsSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (force)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
			return;
		}
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0601311A RID: 78106 RVA: 0x00593CF7 File Offset: 0x00591EF7
	public void SetSelectState(bool isSelect)
	{
		this.IsSelect = isSelect;
	}

	// Token: 0x0601311B RID: 78107 RVA: 0x00593D00 File Offset: 0x00591F00
	private void RefreshIcon()
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(this.ResonanceId);
		UUITexture texture = base.GetTexture(6);
		UUITexture texture2 = base.GetTexture(4);
		if (roleResonanceById != null && !StringUtils.IsBlank(roleResonanceById.Value.NodeIcon))
		{
			base.SetTextureByPath(roleResonanceById.Value.NodeIcon, texture2, null, null);
			base.SetTextureByPath(roleResonanceById.Value.NodeIcon, texture, null, null);
		}
		texture2.SetUIActive(!this.IsActivate);
		texture.SetUIActive(this.IsActivate);
	}

	// Token: 0x0601311C RID: 78108 RVA: 0x00593DAA File Offset: 0x00591FAA
	private void RefreshActivateItem()
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!this.IsActivate);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(this.IsActivate);
	}

	// Token: 0x0601311D RID: 78109 RVA: 0x00593DDE File Offset: 0x00591FDE
	public void RefreshMaxActivateItem(bool isAllActive)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isAllActive);
	}

	// Token: 0x0601311E RID: 78110 RVA: 0x00593DF4 File Offset: 0x00591FF4
	public void RefreshRedDot()
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(this.ResonanceId);
		bool uiactive = RoleModel.Instance.RedDotResonanceTabHoleCondition(this.RoleId, roleResonanceById.Value.GroupIndex);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0601311F RID: 78111 RVA: 0x00593E44 File Offset: 0x00592044
	public int GetResonanceId()
	{
		return this.ResonanceId;
	}

	// Token: 0x06013120 RID: 78112 RVA: 0x00593E4C File Offset: 0x0059204C
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(5);
	}

	// Token: 0x06013121 RID: 78113 RVA: 0x00593E58 File Offset: 0x00592058
	public void PlayActivateSequence()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
	}

	// Token: 0x06013122 RID: 78114 RVA: 0x00593E80 File Offset: 0x00592080
	private void PlayStartSequence()
	{
		if (this.IsActivate)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("ActiveSet", false, null);
			return;
		}
		this.SequencePlayer.PlayOrReplaySequenceByName("LockSet", false, null);
	}

	// Token: 0x0400A3CF RID: 41935
	protected int ResonanceId;

	// Token: 0x0400A3D0 RID: 41936
	protected int RoleId;

	// Token: 0x0400A3D1 RID: 41937
	protected bool IsActivate;

	// Token: 0x0400A3D2 RID: 41938
	private bool IsSelect;

	// Token: 0x0400A3D3 RID: 41939
	private Action<int> ToggleCallBack;

	// Token: 0x0400A3D4 RID: 41940
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A3D5 RID: 41941
	protected UniTask? LoadPromise;

	// Token: 0x020080E9 RID: 33001
	[NullableContext(0)]
	public enum EResonanceChainItemCom
	{
		// Token: 0x04029AFF RID: 170751
		Toggle,
		// Token: 0x04029B00 RID: 170752
		MaxActivateItem,
		// Token: 0x04029B01 RID: 170753
		DeActivateItem,
		// Token: 0x04029B02 RID: 170754
		ActivateItem,
		// Token: 0x04029B03 RID: 170755
		DeActivateIconTexture,
		// Token: 0x04029B04 RID: 170756
		RedDot,
		// Token: 0x04029B05 RID: 170757
		ActivateIconTexture
	}
}
