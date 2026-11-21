using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000DC RID: 220
	[NullableContext(2)]
	[Nullable(0)]
	public class HotFixLguiUtils
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0003B9E8 File Offset: 0x00039BE8
		public static UUIItem CopyItem([Nullable(1)] UUIItem item, USceneComponent parent)
		{
			AActor aactor = HotFixLguiUtils.DuplicateActor(item.GetOwner(), parent);
			if (aactor == null)
			{
				return null;
			}
			return aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003BA1C File Offset: 0x00039C1C
		public static AActor DuplicateActor([Nullable(1)] AActor actor, USceneComponent parent)
		{
			return ULGUIBPLibrary.DuplicateActor(actor, parent);
		}
	}
}
