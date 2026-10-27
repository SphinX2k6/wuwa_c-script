using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017A2 RID: 6050
public class ChatExpressionGroupItem : UiPanelBase
{
	// Token: 0x0600B04C RID: 45132 RVA: 0x0027D43F File Offset: 0x0027B63F
	[NullableContext(1)]
	public ChatExpressionGroupItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600B04D RID: 45133 RVA: 0x0027D450 File Offset: 0x0027B650
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedExpressionGroupExtendToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B04E RID: 45134 RVA: 0x0027D4F6 File Offset: 0x0027B6F6
	private void OnClickedExpressionGroupExtendToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<int> onClicked = this.OnClicked;
		if (onClicked == null)
		{
			return;
		}
		onClicked(this.ExpressionGroupId);
	}

	// Token: 0x0600B04F RID: 45135 RVA: 0x0027D514 File Offset: 0x0027B714
	public void Refresh(ChatExpressionGroup expressionGroupConfig)
	{
		this.ExpressionGroupId = expressionGroupConfig.Id;
		string groupTexturePath = expressionGroupConfig.GroupTexturePath;
		UUITexture expressionGroupTexture = base.GetTexture(0);
		expressionGroupTexture.SetUIActive(false);
		base.SetTextureByPath(groupTexturePath, expressionGroupTexture, null, delegate(bool _)
		{
			expressionGroupTexture.SetUIActive(true);
		});
	}

	// Token: 0x0600B050 RID: 45136 RVA: 0x0027D577 File Offset: 0x0027B777
	public void SetState(EToggleState state, bool bFireEvent = false)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x0600B051 RID: 45137 RVA: 0x0027D58A File Offset: 0x0027B78A
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x04005019 RID: 20505
	private int ExpressionGroupId;

	// Token: 0x0400501A RID: 20506
	[Nullable(2)]
	private Action<int> OnClicked;

	// Token: 0x02007DB0 RID: 32176
	private class EChildType
	{
		// Token: 0x0402926B RID: 168555
		public const int ExpressionGroupTexture = 0;

		// Token: 0x0402926C RID: 168556
		public const int ExpressionGroupButton = 1;
	}
}
