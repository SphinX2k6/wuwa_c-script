using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020027A2 RID: 10146
[NullableContext(2)]
[Nullable(0)]
public class RoleElementItem : GridProxyAbstract<MainRoleConfig>
{
	// Token: 0x06014D61 RID: 85345 RVA: 0x005493C8 File Offset: 0x005475C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		Action<EToggleState> item = delegate(EToggleState toggleState)
		{
			Action<int> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(base.GridIndex);
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, item)
		};
	}

	// Token: 0x06014D62 RID: 85346 RVA: 0x00549473 File Offset: 0x00547673
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
	}

	// Token: 0x06014D63 RID: 85347 RVA: 0x00549498 File Offset: 0x00547698
	public void Update(MainRoleConfig mainRoleConfig)
	{
		this.MainRoleConfig = new MainRoleConfig?(mainRoleConfig);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.MainRoleConfig.Value.Id);
		if (roleConfig == null)
		{
			return;
		}
		int elementId = roleConfig.Value.ElementId;
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null)
		{
			return;
		}
		base.GetText(2).ShowTextNew(elementInfo.Value.Name);
		base.SetElementIcon("", base.GetTexture(1), elementId, null);
		base.SetTextureByPath(elementInfo.Value.ElementChangeTexture, base.GetTexture(0), null, null);
		this.RefreshState();
	}

	// Token: 0x06014D64 RID: 85348 RVA: 0x00549567 File Offset: 0x00547767
	public override void Refresh(MainRoleConfig data, bool isSelected, int gridIndex)
	{
		this.MainRoleConfig = new MainRoleConfig?(data);
		this.Update(data);
	}

	// Token: 0x06014D65 RID: 85349 RVA: 0x0054957C File Offset: 0x0054777C
	public void RefreshState()
	{
		int id = this.MainRoleConfig.Value.Id;
		bool uiactive = this.RoleViewAgent.GetCurSelectRoleId() == id;
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x06014D66 RID: 85350 RVA: 0x005495B9 File Offset: 0x005477B9
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014D67 RID: 85351 RVA: 0x005495D1 File Offset: 0x005477D1
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014D68 RID: 85352 RVA: 0x005495E9 File Offset: 0x005477E9
	[NullableContext(1)]
	public void SetRoleViewAgent(RoleViewAgent roleViewAgent)
	{
		this.RoleViewAgent = roleViewAgent;
	}

	// Token: 0x04009CC9 RID: 40137
	private RoleViewAgent RoleViewAgent;

	// Token: 0x04009CCA RID: 40138
	private MainRoleConfig? MainRoleConfig;

	// Token: 0x04009CCB RID: 40139
	public Action<int> OnToggleCallback;

	// Token: 0x04009CCC RID: 40140
	public Func<int, bool> CanToggleChange;

	// Token: 0x02008E16 RID: 36374
	[NullableContext(0)]
	private enum ERoleElementItemDefine
	{
		// Token: 0x0402E199 RID: 188825
		ElementBgTexture,
		// Token: 0x0402E19A RID: 188826
		ElementIconTexture,
		// Token: 0x0402E19B RID: 188827
		ElementText,
		// Token: 0x0402E19C RID: 188828
		Toggle,
		// Token: 0x0402E19D RID: 188829
		MyItem
	}
}
