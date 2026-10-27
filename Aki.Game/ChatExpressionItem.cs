using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017A3 RID: 6051
public class ChatExpressionItem : GridProxyAbstract<ChatExpression>
{
	// Token: 0x0600B053 RID: 45139 RVA: 0x0027D59C File Offset: 0x0027B79C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedExpressionButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B054 RID: 45140 RVA: 0x0027D663 File Offset: 0x0027B863
	private void OnClickedExpressionButton()
	{
		Action<int> onClicked = this.OnClicked;
		if (onClicked == null)
		{
			return;
		}
		onClicked(this.ExpressionId);
	}

	// Token: 0x0600B055 RID: 45141 RVA: 0x0027D67C File Offset: 0x0027B87C
	public override void Refresh(ChatExpression expressionConfig, bool isSelected, int gridIndex)
	{
		this.ExpressionId = expressionConfig.Id;
		string expressionTexturePath = expressionConfig.ExpressionTexturePath;
		UUITexture expressionTexture = base.GetTexture(2);
		expressionTexture.SetUIActive(false);
		base.SetTextureByPath(expressionTexturePath, expressionTexture, null, delegate(bool _)
		{
			expressionTexture.SetUIActive(true);
		});
		string name = expressionConfig.Name;
		base.GetText(1).ShowTextNew(name);
	}

	// Token: 0x0600B056 RID: 45142 RVA: 0x0027D6F4 File Offset: 0x0027B8F4
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x0400501B RID: 20507
	private int ExpressionId;

	// Token: 0x0400501C RID: 20508
	[Nullable(2)]
	private Action<int> OnClicked;

	// Token: 0x02007DB2 RID: 32178
	private class EChildType
	{
		// Token: 0x0402926E RID: 168558
		public const int ExpressionButton = 0;

		// Token: 0x0402926F RID: 168559
		public const int ExpressionNameText = 1;

		// Token: 0x04029270 RID: 168560
		public const int ExpressionTexture = 2;
	}
}
