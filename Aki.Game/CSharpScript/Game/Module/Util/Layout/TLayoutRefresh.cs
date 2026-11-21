using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util.Layout
{
	// Token: 0x0200385B RID: 14427
	// (Invoke) Token: 0x060257C0 RID: 153536
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public delegate ILayoutItem<TLayoutRefreshItem> TLayoutRefresh<[Nullable(2)] TLayoutRefreshItem>(object data, UUIItem uiItem, int index);
}
