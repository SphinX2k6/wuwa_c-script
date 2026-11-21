using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D1D RID: 7453
[NullableContext(2)]
[Nullable(0)]
public class RoleElementItem : UiPanelBase
{
	// Token: 0x0601273A RID: 75578 RVA: 0x0057355C File Offset: 0x0057175C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUITexture))
		};
	}

	// Token: 0x0601273B RID: 75579 RVA: 0x005735E4 File Offset: 0x005717E4
	protected override void OnStart()
	{
		this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Bind(() => false);
			extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnToggleClick));
		}
	}

	// Token: 0x0601273C RID: 75580 RVA: 0x00573650 File Offset: 0x00571850
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.OnPointUpCallBack.Unbind();
			extendToggle.CanExecuteChange.Unbind();
		}
	}

	// Token: 0x0601273D RID: 75581 RVA: 0x0057367E File Offset: 0x0057187E
	private void OnToggleClick(EToggleState _)
	{
		Action<int> onClickAttach = this.OnClickAttach;
		if (onClickAttach == null)
		{
			return;
		}
		onClickAttach(this.Index);
	}

	// Token: 0x0601273E RID: 75582 RVA: 0x00573696 File Offset: 0x00571896
	[NullableContext(1)]
	public void SetRoleViewAgent(RoleViewAgent roleViewAgent)
	{
		this.RoleViewAgent = roleViewAgent;
	}

	// Token: 0x0601273F RID: 75583 RVA: 0x0057369F File Offset: 0x0057189F
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x06012740 RID: 75584 RVA: 0x005736A8 File Offset: 0x005718A8
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x06012741 RID: 75585 RVA: 0x005736B0 File Offset: 0x005718B0
	public MainRoleConfig? GetData()
	{
		return this.MainRoleConfig;
	}

	// Token: 0x06012742 RID: 75586 RVA: 0x005736B8 File Offset: 0x005718B8
	public void Update(MainRoleConfig mainRoleConfig)
	{
		this.MainRoleConfig = new MainRoleConfig?(mainRoleConfig);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(mainRoleConfig.Id);
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
		base.SetTextureByPath(elementInfo.Value.Icon, base.GetTexture(2), null, null);
		base.SetTextureByPath(elementInfo.Value.ElementChangeTexture, base.GetTexture(0), null, null);
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetColor(FColor.FromHex(elementInfo.Value.ElementChangeColor));
		}
		UUITexture texture2 = base.GetTexture(4);
		if (texture2 != null)
		{
			texture2.SetColor(FColor.FromHex(elementInfo.Value.ElementChangeIconBgColor));
		}
		this.SetHighlight(false);
	}

	// Token: 0x06012743 RID: 75587 RVA: 0x005737B8 File Offset: 0x005719B8
	public void SetIconBgAlpha(float alpha)
	{
		UUITexture texture = base.GetTexture(4);
		if (texture == null)
		{
			return;
		}
		texture.SetAlpha(Math.Clamp(alpha, 0f, 1f));
	}

	// Token: 0x06012744 RID: 75588 RVA: 0x005737DB File Offset: 0x005719DB
	public void SetHighlight(bool isHighlight)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isHighlight ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
	}

	// Token: 0x06012745 RID: 75589 RVA: 0x005737F8 File Offset: 0x005719F8
	public void PlayShow()
	{
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x06012746 RID: 75590 RVA: 0x00573811 File Offset: 0x00571A11
	public void PlayClose()
	{
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlaySequencePurely("Close", false, false);
	}

	// Token: 0x06012747 RID: 75591 RVA: 0x0057382A File Offset: 0x00571A2A
	public void PlayActivate()
	{
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey("ActivateOut", false, false);
		}
		UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlaySequencePurely("Activate", false, false);
	}

	// Token: 0x06012748 RID: 75592 RVA: 0x0057385B File Offset: 0x00571A5B
	public void PlayActivateOut()
	{
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey("Activate", false, false);
		}
		UiSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlaySequencePurely("ActivateOut", false, false);
	}

	// Token: 0x0400A09C RID: 41116
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A09D RID: 41117
	private MainRoleConfig? MainRoleConfig;

	// Token: 0x0400A09E RID: 41118
	private int Index = -1;

	// Token: 0x0400A09F RID: 41119
	private UiSequencePlayer SequencePlayer;

	// Token: 0x0400A0A0 RID: 41120
	public Action<int> OnClickAttach;

	// Token: 0x0200805B RID: 32859
	[NullableContext(0)]
	private enum ERoleElementItemDefine
	{
		// Token: 0x04029875 RID: 170101
		ElementBgTexture,
		// Token: 0x04029876 RID: 170102
		ElementHighlightTexture,
		// Token: 0x04029877 RID: 170103
		ElementIconTexture,
		// Token: 0x04029878 RID: 170104
		Toggle,
		// Token: 0x04029879 RID: 170105
		ElementIconBgTexture
	}
}
