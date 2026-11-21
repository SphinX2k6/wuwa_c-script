using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019FF RID: 6655
public class PhoneMsgEmojiItem : GridProxyAbstract<int>
{
	// Token: 0x06010612 RID: 67090 RVA: 0x004C8A7A File Offset: 0x004C6C7A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06010613 RID: 67091 RVA: 0x004C8AB3 File Offset: 0x004C6CB3
	protected override void OnStart()
	{
		base.OnStart();
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnClickToggle));
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06010614 RID: 67092 RVA: 0x004C8AF0 File Offset: 0x004C6CF0
	public override void Refresh(int emojiId, bool isSelected, int gridIndex)
	{
		this.Data = emojiId;
		UUITexture texture = base.GetTexture(1);
		string emojiTexturePathByEmojiId = PhoneMsgModel.Instance.GetEmojiTexturePathByEmojiId(emojiId);
		base.SetTextureByPath(emojiTexturePathByEmojiId, texture, null, null);
	}

	// Token: 0x06010615 RID: 67093 RVA: 0x004C8B2A File Offset: 0x004C6D2A
	private void OnClickToggle(EToggleState state)
	{
		Action<int> onClickDelegate = this.OnClickDelegate;
		if (onClickDelegate == null)
		{
			return;
		}
		onClickDelegate(base.GridIndex);
	}

	// Token: 0x06010616 RID: 67094 RVA: 0x004C8B42 File Offset: 0x004C6D42
	private bool CanExecuteChange()
	{
		return false;
	}

	// Token: 0x04009162 RID: 37218
	protected int Data;

	// Token: 0x04009163 RID: 37219
	[Nullable(2)]
	public Action<int> OnClickDelegate;

	// Token: 0x02007C23 RID: 31779
	private enum ETogEmojiComponent
	{
		// Token: 0x04028331 RID: 164657
		TogEmoji,
		// Token: 0x04028332 RID: 164658
		TexEmoji
	}
}
