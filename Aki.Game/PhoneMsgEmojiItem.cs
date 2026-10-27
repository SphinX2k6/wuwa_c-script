using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002518 RID: 9496
public class PhoneMsgEmojiItem : GridProxyAbstract<int>
{
	// Token: 0x06013153 RID: 78163 RVA: 0x004BAD16 File Offset: 0x004B8F16
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06013154 RID: 78164 RVA: 0x004BAD4F File Offset: 0x004B8F4F
	protected override void OnStart()
	{
		base.OnStart();
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnClickToggle));
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06013155 RID: 78165 RVA: 0x004BAD8C File Offset: 0x004B8F8C
	public override void Refresh(int emojiId, bool isSelected, int gridIndex)
	{
		this.Data = emojiId;
		UUITexture texture = base.GetTexture(1);
		string emojiTexturePathByEmojiId = PhoneMsgModel.Instance.GetEmojiTexturePathByEmojiId(emojiId);
		base.SetTextureByPath(emojiTexturePathByEmojiId, texture, null, null);
	}

	// Token: 0x06013156 RID: 78166 RVA: 0x004BADC6 File Offset: 0x004B8FC6
	private void OnClickToggle(EToggleState state)
	{
		Action<int> onClickDelegate = this.OnClickDelegate;
		if (onClickDelegate == null)
		{
			return;
		}
		onClickDelegate(base.GridIndex);
	}

	// Token: 0x06013157 RID: 78167 RVA: 0x004BADDE File Offset: 0x004B8FDE
	private bool CanExecuteChange()
	{
		return false;
	}

	// Token: 0x0400900E RID: 36878
	protected int Data;

	// Token: 0x0400900F RID: 36879
	[Nullable(2)]
	public Action<int> OnClickDelegate;

	// Token: 0x02008A9B RID: 35483
	private enum ETogEmojiComponent
	{
		// Token: 0x0402D019 RID: 184345
		TogEmoji,
		// Token: 0x0402D01A RID: 184346
		TexEmoji
	}
}
