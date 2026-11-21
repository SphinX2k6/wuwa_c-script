using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A02 RID: 6658
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhoneMsgPhraseItem : GridProxyAbstract<string>
{
	// Token: 0x0601064F RID: 67151 RVA: 0x004CA0E7 File Offset: 0x004C82E7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06010650 RID: 67152 RVA: 0x004CA120 File Offset: 0x004C8320
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

	// Token: 0x06010651 RID: 67153 RVA: 0x004CA17B File Offset: 0x004C837B
	[NullableContext(1)]
	public override void Refresh(string contentText, bool isSelected, int gridIndex)
	{
		this.Data = contentText;
		base.GetText(1).SetText(contentText, true);
	}

	// Token: 0x06010652 RID: 67154 RVA: 0x004CA192 File Offset: 0x004C8392
	private void OnClickToggle(EToggleState state)
	{
		Action<int> onClickDelegate = this.OnClickDelegate;
		if (onClickDelegate == null)
		{
			return;
		}
		onClickDelegate(base.GridIndex);
	}

	// Token: 0x06010653 RID: 67155 RVA: 0x004CA1AA File Offset: 0x004C83AA
	private bool CanExecuteChange()
	{
		return false;
	}

	// Token: 0x04009186 RID: 37254
	protected string Data;

	// Token: 0x04009187 RID: 37255
	public Action<int> OnClickDelegate;

	// Token: 0x02007C31 RID: 31793
	[NullableContext(0)]
	private enum ETogPhraseComponent
	{
		// Token: 0x04028393 RID: 164755
		TogPhrase,
		// Token: 0x04028394 RID: 164756
		TxtPhrase
	}
}
