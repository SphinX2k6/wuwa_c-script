using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020016D1 RID: 5841
public class AdviceExpressionItem : GridProxyAbstract<ChatExpression>
{
	// Token: 0x0600A70D RID: 42765 RVA: 0x002574CC File Offset: 0x002556CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedExpressionButton))
		};
	}

	// Token: 0x0600A70E RID: 42766 RVA: 0x0025755F File Offset: 0x0025575F
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceExpression, new Action(this.OnClickedExpression));
	}

	// Token: 0x0600A70F RID: 42767 RVA: 0x0025757D File Offset: 0x0025577D
	private void OnClickedExpression()
	{
		this.RefreshSelectState();
		this.RefreshToggleView();
	}

	// Token: 0x0600A710 RID: 42768 RVA: 0x0025758B File Offset: 0x0025578B
	private void OnClickedExpressionButton(EToggleState state)
	{
		AdviceModel.Instance.PreSelectExpressionId = this.ExpressionId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceExpression);
	}

	// Token: 0x0600A711 RID: 42769 RVA: 0x002575B0 File Offset: 0x002557B0
	public override void Refresh(ChatExpression expressionConfig, bool isSelected, int gridIndex)
	{
		this.ExpressionId = expressionConfig.Id;
		string expressionTexturePath = expressionConfig.ExpressionTexturePath;
		base.SetTextureByPath(expressionTexturePath, base.GetTexture(2), null, null);
		string name = expressionConfig.Name;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(name);
		}
		this.RefreshSelectState();
		this.RefreshToggleView();
	}

	// Token: 0x0600A712 RID: 42770 RVA: 0x00257614 File Offset: 0x00255814
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (AdviceModel.Instance.PreSelectExpressionId == this.ExpressionId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x0600A713 RID: 42771 RVA: 0x0025765C File Offset: 0x0025585C
	private void RefreshSelectState()
	{
		int currentExpressionId = AdviceModel.Instance.CurrentExpressionId;
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(currentExpressionId == this.ExpressionId);
	}

	// Token: 0x0600A714 RID: 42772 RVA: 0x0025768E File Offset: 0x0025588E
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceExpression, new Action(this.OnClickedExpression));
	}

	// Token: 0x04004B78 RID: 19320
	private int ExpressionId;

	// Token: 0x02007CA4 RID: 31908
	private static class EChildType
	{
		// Token: 0x04028E26 RID: 167462
		public const int ExpressionToggle = 0;

		// Token: 0x04028E27 RID: 167463
		public const int ExpressionNameText = 1;

		// Token: 0x04028E28 RID: 167464
		public const int ExpressionTexture = 2;

		// Token: 0x04028E29 RID: 167465
		public const int SelectItem = 3;
	}
}
