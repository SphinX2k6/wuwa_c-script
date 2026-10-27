using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020017A0 RID: 6048
[NullableContext(1)]
[Nullable(0)]
public class ChatContentBase : UiPanelBase
{
	// Token: 0x0600B044 RID: 45124 RVA: 0x0027D111 File Offset: 0x0027B311
	public ChatContentBase(string resourceId, UUIItem parentItem, ChatContentData chatContentData, [Nullable(new byte[]
	{
		2,
		1
	})] Action<ChatContentBase> onLoaded = null)
	{
		this.ChatContentData = chatContentData;
		this.OnLoadedCallback = onLoaded;
		base.CreateThenShowByResourceIdAsync(resourceId, parentItem, true).ContinueWith(delegate()
		{
			Action<ChatContentBase> onLoadedCallback = this.OnLoadedCallback;
			if (onLoadedCallback == null)
			{
				return;
			}
			onLoadedCallback(this);
		});
	}

	// Token: 0x04005015 RID: 20501
	protected readonly ChatContentData ChatContentData;

	// Token: 0x04005016 RID: 20502
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<ChatContentBase> OnLoadedCallback;
}
