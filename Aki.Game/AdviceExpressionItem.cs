using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B89 RID: 2953
public class AdviceExpressionItem : GridProxyAbstract<ChatExpression>
{
	// Token: 0x06007AED RID: 31469 RVA: 0x002618D8 File Offset: 0x0025FAD8
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

	// Token: 0x06007AEE RID: 31470 RVA: 0x0026196B File Offset: 0x0025FB6B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceExpression, new Action(this.OnClickedExpression));
	}

	// Token: 0x06007AEF RID: 31471 RVA: 0x00261989 File Offset: 0x0025FB89
	private void OnClickedExpression()
	{
		this.RefreshSelectState();
		this.RefreshToggleView();
	}

	// Token: 0x06007AF0 RID: 31472 RVA: 0x00261997 File Offset: 0x0025FB97
	private void OnClickedExpressionButton(EToggleState state)
	{
		AdviceModel.Instance.PreSelectExpressionId = this.ExpressionId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceExpression);
	}

	// Token: 0x06007AF1 RID: 31473 RVA: 0x002619BC File Offset: 0x0025FBBC
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

	// Token: 0x06007AF2 RID: 31474 RVA: 0x00261A20 File Offset: 0x0025FC20
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		EToggleState etoggleState = (AdviceModel.Instance.PreSelectExpressionId == this.ExpressionId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (toggleState != etoggleState)
		{
			base.GetExtendToggle(0).SetToggleStateForce(etoggleState, false, false, false);
		}
	}

	// Token: 0x06007AF3 RID: 31475 RVA: 0x00261A68 File Offset: 0x0025FC68
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

	// Token: 0x06007AF4 RID: 31476 RVA: 0x00261A9A File Offset: 0x0025FC9A
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceExpression, new Action(this.OnClickedExpression));
	}

	// Token: 0x04004C1F RID: 19487
	private int ExpressionId;

	// Token: 0x02006E29 RID: 28201
	private static class EChildType
	{
		// Token: 0x0402414F RID: 147791
		public const int ExpressionToggle = 0;

		// Token: 0x04024150 RID: 147792
		public const int ExpressionNameText = 1;

		// Token: 0x04024151 RID: 147793
		public const int ExpressionTexture = 2;

		// Token: 0x04024152 RID: 147794
		public const int SelectItem = 3;
	}
}
