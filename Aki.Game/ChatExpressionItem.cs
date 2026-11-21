using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C5C RID: 3164
public class ChatExpressionItem : GridProxyAbstract<ChatExpression>
{
	// Token: 0x0600843B RID: 33851 RVA: 0x00287B34 File Offset: 0x00285D34
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

	// Token: 0x0600843C RID: 33852 RVA: 0x00287BFB File Offset: 0x00285DFB
	private void OnClickedExpressionButton()
	{
		Action<int> onClicked = this.OnClicked;
		if (onClicked == null)
		{
			return;
		}
		onClicked(this.ExpressionId);
	}

	// Token: 0x0600843D RID: 33853 RVA: 0x00287C14 File Offset: 0x00285E14
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

	// Token: 0x0600843E RID: 33854 RVA: 0x00287C8C File Offset: 0x00285E8C
	[NullableContext(1)]
	public void BindOnClicked(Action<int> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x040050C5 RID: 20677
	private int ExpressionId;

	// Token: 0x040050C6 RID: 20678
	[Nullable(2)]
	private Action<int> OnClicked;

	// Token: 0x02006F38 RID: 28472
	private class EChildType
	{
		// Token: 0x04024599 RID: 148889
		public const int ExpressionButton = 0;

		// Token: 0x0402459A RID: 148890
		public const int ExpressionNameText = 1;

		// Token: 0x0402459B RID: 148891
		public const int ExpressionTexture = 2;
	}
}
