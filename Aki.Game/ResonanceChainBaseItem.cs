using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002899 RID: 10393
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainBaseItem : UiPanelBase
{
	// Token: 0x17001CC6 RID: 7366
	// (get) Token: 0x0601570F RID: 87823 RVA: 0x00568CDD File Offset: 0x00566EDD
	protected virtual string ActivateSequenceName
	{
		get
		{
			return null;
		}
	}

	// Token: 0x06015710 RID: 87824 RVA: 0x00568CE0 File Offset: 0x00566EE0
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

	// Token: 0x06015711 RID: 87825 RVA: 0x00568DB5 File Offset: 0x00566FB5
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06015712 RID: 87826 RVA: 0x00568DC8 File Offset: 0x00566FC8
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.Clear();
	}

	// Token: 0x06015713 RID: 87827 RVA: 0x00568DDA File Offset: 0x00566FDA
	public void Update(int roleId, int resonanceId, bool isActivate)
	{
		this.ResonanceId = resonanceId;
		this.RoleId = roleId;
		this.IsActivate = isActivate;
		this.Refresh();
	}

	// Token: 0x06015714 RID: 87828 RVA: 0x00568DF7 File Offset: 0x00566FF7
	public void Refresh()
	{
		this.RefreshToggleState(false);
		this.RefreshIcon();
		this.RefreshActivateItem();
		this.RefreshRedDot();
	}

	// Token: 0x06015715 RID: 87829 RVA: 0x00568E12 File Offset: 0x00567012
	public void ShowItem()
	{
		base.SetUiActive(true);
		this.PlayStartSequence();
	}

	// Token: 0x06015716 RID: 87830 RVA: 0x00568E21 File Offset: 0x00567021
	[NullableContext(1)]
	public UUIItem GetUiItemForGuide()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return ((extendToggle != null) ? extendToggle.GetOwner().GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
	}

	// Token: 0x06015717 RID: 87831 RVA: 0x00568E4A File Offset: 0x0056704A
	private void OnItemClick(EToggleState toggleState)
	{
		if (this.ToggleCallBack != null)
		{
			this.ToggleCallBack(this.ResonanceId);
		}
	}

	// Token: 0x06015718 RID: 87832 RVA: 0x00568E65 File Offset: 0x00567065
	[NullableContext(1)]
	public void BindToggleCallBack(Action<int> callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x06015719 RID: 87833 RVA: 0x00568E70 File Offset: 0x00567070
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

	// Token: 0x0601571A RID: 87834 RVA: 0x00568EAF File Offset: 0x005670AF
	public void SetSelectState(bool isSelect)
	{
		this.IsSelect = isSelect;
	}

	// Token: 0x0601571B RID: 87835 RVA: 0x00568EB8 File Offset: 0x005670B8
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

	// Token: 0x0601571C RID: 87836 RVA: 0x00568F62 File Offset: 0x00567162
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

	// Token: 0x0601571D RID: 87837 RVA: 0x00568F96 File Offset: 0x00567196
	public void RefreshMaxActivateItem(bool isAllActive)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isAllActive);
	}

	// Token: 0x0601571E RID: 87838 RVA: 0x00568FAC File Offset: 0x005671AC
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

	// Token: 0x0601571F RID: 87839 RVA: 0x00568FFC File Offset: 0x005671FC
	public int GetResonanceId()
	{
		return this.ResonanceId;
	}

	// Token: 0x06015720 RID: 87840 RVA: 0x00569004 File Offset: 0x00567204
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(5);
	}

	// Token: 0x06015721 RID: 87841 RVA: 0x00569010 File Offset: 0x00567210
	public void PlayActivateSequence()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
	}

	// Token: 0x06015722 RID: 87842 RVA: 0x00569038 File Offset: 0x00567238
	private void PlayStartSequence()
	{
		if (this.IsActivate)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("ActiveSet", false, null);
			return;
		}
		this.SequencePlayer.PlayOrReplaySequenceByName("LockSet", false, null);
	}

	// Token: 0x04009FE6 RID: 40934
	protected int ResonanceId;

	// Token: 0x04009FE7 RID: 40935
	protected int RoleId;

	// Token: 0x04009FE8 RID: 40936
	protected bool IsActivate;

	// Token: 0x04009FE9 RID: 40937
	private bool IsSelect;

	// Token: 0x04009FEA RID: 40938
	private Action<int> ToggleCallBack;

	// Token: 0x04009FEB RID: 40939
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009FEC RID: 40940
	protected UniTask? LoadPromise;

	// Token: 0x02008EA2 RID: 36514
	[NullableContext(0)]
	public enum EResonanceChainItemCom
	{
		// Token: 0x0402E402 RID: 189442
		Toggle,
		// Token: 0x0402E403 RID: 189443
		MaxActivateItem,
		// Token: 0x0402E404 RID: 189444
		DeActivateItem,
		// Token: 0x0402E405 RID: 189445
		ActivateItem,
		// Token: 0x0402E406 RID: 189446
		DeActivateIconTexture,
		// Token: 0x0402E407 RID: 189447
		RedDot,
		// Token: 0x0402E408 RID: 189448
		ActivateIconTexture
	}
}
