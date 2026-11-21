using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C5B RID: 3163
public class ChatExpressionGroupItem : UiPanelBase
{
	// Token: 0x06008434 RID: 33844 RVA: 0x002879D7 File Offset: 0x00285BD7
	[NullableContext(1)]
	public ChatExpressionGroupItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06008435 RID: 33845 RVA: 0x002879E8 File Offset: 0x00285BE8
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

	// Token: 0x06008436 RID: 33846 RVA: 0x00287A8E File Offset: 0x00285C8E
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

	// Token: 0x06008437 RID: 33847 RVA: 0x00287AAC File Offset: 0x00285CAC
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

	// Token: 0x06008438 RID: 33848 RVA: 0x00287B0F File Offset: 0x00285D0F
	public void SetState(EToggleState state, bool bFireEvent = false)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x06008439 RID: 33849 RVA: 0x00287B22 File Offset: 0x00285D22
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x040050C3 RID: 20675
	private int ExpressionGroupId;

	// Token: 0x040050C4 RID: 20676
	[Nullable(2)]
	private Action<int> OnClicked;

	// Token: 0x02006F36 RID: 28470
	private class EChildType
	{
		// Token: 0x04024596 RID: 148886
		public const int ExpressionGroupTexture = 0;

		// Token: 0x04024597 RID: 148887
		public const int ExpressionGroupButton = 1;
	}
}
