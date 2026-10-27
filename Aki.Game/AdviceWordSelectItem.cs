using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DF RID: 5855
public class AdviceWordSelectItem : UiPanelBase
{
	// Token: 0x0600A7C8 RID: 42952 RVA: 0x0025AA71 File Offset: 0x00258C71
	[NullableContext(1)]
	public AdviceWordSelectItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A7C9 RID: 42953 RVA: 0x0025AA88 File Offset: 0x00258C88
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

	// Token: 0x0600A7CA RID: 42954 RVA: 0x0025AB05 File Offset: 0x00258D05
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceWord, new Action(this.OnClickAdviceWord));
	}

	// Token: 0x0600A7CB RID: 42955 RVA: 0x0025AB23 File Offset: 0x00258D23
	private void OnClickAdviceWord()
	{
		this.RefreshView();
	}

	// Token: 0x0600A7CC RID: 42956 RVA: 0x0025AB2B File Offset: 0x00258D2B
	private void OnClickItem(EToggleState state)
	{
		AdviceModel.Instance.CurrentPreSelectWordId = this.WordId;
		EventSystem.Instance.Emit(EEventName.OnClickAdviceWord);
	}

	// Token: 0x0600A7CD RID: 42957 RVA: 0x0025AB4D File Offset: 0x00258D4D
	public void Update(int wordId, EChangeWordType type)
	{
		this.WordId = wordId;
		this.Type = type;
		this.RefreshView();
		this.RefreshText();
	}

	// Token: 0x0600A7CE RID: 42958 RVA: 0x0025AB6C File Offset: 0x00258D6C
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

	// Token: 0x0600A7CF RID: 42959 RVA: 0x0025ABC4 File Offset: 0x00258DC4
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

	// Token: 0x0600A7D0 RID: 42960 RVA: 0x0025AC4C File Offset: 0x00258E4C
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

	// Token: 0x0600A7D1 RID: 42961 RVA: 0x0025AC85 File Offset: 0x00258E85
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceWord, new Action(this.OnClickAdviceWord));
	}

	// Token: 0x04004B9E RID: 19358
	private int WordId;

	// Token: 0x04004B9F RID: 19359
	private EChangeWordType Type;

	// Token: 0x02007CB3 RID: 31923
	private static class EChildType
	{
		// Token: 0x04028E72 RID: 167538
		public const int Toggle = 0;

		// Token: 0x04028E73 RID: 167539
		public const int Text = 1;

		// Token: 0x04028E74 RID: 167540
		public const int SelectItem = 2;
	}
}
