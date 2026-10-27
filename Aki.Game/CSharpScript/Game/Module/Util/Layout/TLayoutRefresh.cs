using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util.Layout
{
	// Token: 0x020048E4 RID: 18660
	// (Invoke) Token: 0x06030C93 RID: 199827
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public delegate ILayoutItem<TLayoutRefreshItem> TLayoutRefresh<[Nullable(2)] TLayoutRefreshItem>(object data, UUIItem uiItem, int index);
}
