using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000C59 RID: 3161
[NullableContext(1)]
[Nullable(0)]
public class ChatContentBase : UiPanelBase
{
	// Token: 0x0600842C RID: 33836 RVA: 0x002876A9 File Offset: 0x002858A9
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

	// Token: 0x040050BF RID: 20671
	protected readonly ChatContentData ChatContentData;

	// Token: 0x040050C0 RID: 20672
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly Action<ChatContentBase> OnLoadedCallback;
}
