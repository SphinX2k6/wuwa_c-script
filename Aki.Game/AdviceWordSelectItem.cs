using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B97 RID: 2967
public class AdviceWordSelectItem : UiPanelBase
{
	// Token: 0x06007BA8 RID: 31656 RVA: 0x00264E79 File Offset: 0x00263079
	[NullableContext(1)]
	public AdviceWordSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007BA9 RID: 31657 RVA: 0x00264E90 File Offset: 0x00263090
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x06007BAA RID: 31658 RVA: 0x00264F0D File Offset: 0x0026310D
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceWord, new Action(this.OnClickAdviceWord));
	}

	// Token: 0x06007BAB RID: 31659 RVA: 0x00264F2B File Offset: 0x0026312B
	private void OnClickAdviceWord()
	{
		this.RefreshView();
	}

	// Token: 0x06007BAC RID: 31660 RVA: 0x00264F33 File Offset: 0x00263133
	private void OnClickItem(EToggleState state)
	{
		AdviceModel.Instance.CurrentPreSelectWordId = this.WordId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceWord);
	}

	// Token: 0x06007BAD RID: 31661 RVA: 0x00264F55 File Offset: 0x00263155
	public void Update(int wordId, EChangeWordType type)
	{
		this.WordId = wordId;
		this.Type = type;
		this.RefreshView();
		this.RefreshText();
	}

	// Token: 0x06007BAE RID: 31662 RVA: 0x00264F74 File Offset: 0x00263174
	private void RefreshToggleView()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		if (this.WordId == AdviceModel.Instance.CurrentPreSelectWordId)
		{
			if (toggleState != EToggleState.ETT_Checked)
			{
				base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
				return;
			}
		}
		else if (toggleState != EToggleState.ETT_UnChecked)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06007BAF RID: 31663 RVA: 0x00264FCC File Offset: 0x002631CC
	private void RefreshText()
	{
		if (this.Type == EChangeWordType.Sentence)
		{
			string text = AdviceConfig.Instance.GetAdviceSentenceText(this.WordId);
			text = (((text != null) ? text.Replace("{}", "_") : null) ?? "");
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
			return;
		}
		else
		{
			string adviceConjunctionText = AdviceConfig.Instance.GetAdviceConjunctionText(this.WordId);
			UUIText text3 = base.GetText(1);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(adviceConjunctionText ?? "", true);
			return;
		}
	}

	// Token: 0x06007BB0 RID: 31664 RVA: 0x00265054 File Offset: 0x00263254
	private void RefreshView()
	{
		bool uiactive = this.WordId == AdviceModel.Instance.CurrentSelectWordId;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		this.RefreshToggleView();
	}

	// Token: 0x06007BB1 RID: 31665 RVA: 0x0026508D File Offset: 0x0026328D
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceWord, new Action(this.OnClickAdviceWord));
	}

	// Token: 0x04004C45 RID: 19525
	private int WordId;

	// Token: 0x04004C46 RID: 19526
	private EChangeWordType Type;

	// Token: 0x02006E38 RID: 28216
	private static class EChildType
	{
		// Token: 0x0402419B RID: 147867
		public const int Toggle = 0;

		// Token: 0x0402419C RID: 147868
		public const int Text = 1;

		// Token: 0x0402419D RID: 147869
		public const int SelectItem = 2;
	}
}
