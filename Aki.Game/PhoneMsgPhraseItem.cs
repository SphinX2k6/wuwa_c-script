using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200251B RID: 9499
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgPhraseItem : GridProxyAbstract<string>
{
	// Token: 0x06013190 RID: 78224 RVA: 0x004BC3EF File Offset: 0x004BA5EF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06013191 RID: 78225 RVA: 0x004BC428 File Offset: 0x004BA628
	protected override void OnStart()
	{
		base.OnStart();
		UUIText text = base.GetText(1);
		text.bGameRichText = true;
		text.richText = true;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnClickToggle));
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06013192 RID: 78226 RVA: 0x004BC483 File Offset: 0x004BA683
	[NullableContext(1)]
	public override void Refresh(string contentText, bool isSelected, int gridIndex)
	{
		this.Data = contentText;
		base.GetText(1).SetText(contentText, true);
	}

	// Token: 0x06013193 RID: 78227 RVA: 0x004BC49A File Offset: 0x004BA69A
	private void OnClickToggle(EToggleState state)
	{
		Action<int> onClickDelegate = this.OnClickDelegate;
		if (onClickDelegate == null)
		{
			return;
		}
		onClickDelegate(base.GridIndex);
	}

	// Token: 0x06013194 RID: 78228 RVA: 0x004BC4B2 File Offset: 0x004BA6B2
	private bool CanExecuteChange()
	{
		return false;
	}

	// Token: 0x04009031 RID: 36913
	protected string Data;

	// Token: 0x04009032 RID: 36914
	public Action<int> OnClickDelegate;

	// Token: 0x02008AAA RID: 35498
	[NullableContext(0)]
	private enum ETogPhraseComponent
	{
		// Token: 0x0402D07F RID: 184447
		TogPhrase,
		// Token: 0x0402D080 RID: 184448
		TxtPhrase
	}
}
