using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D9 RID: 217
	[NullableContext(2)]
	[Nullable(0)]
	public class HotFixLguiUtils
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x00039EB8 File Offset: 0x000380B8
		public static UUIItem CopyItem([Nullable(1)] UUIItem item, USceneComponent parent)
		{
			AActor aactor = HotFixLguiUtils.DuplicateActor(item.GetOwner(), parent);
			if (aactor == null)
			{
				return null;
			}
			return aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00039EEC File Offset: 0x000380EC
		public static AActor DuplicateActor([Nullable(1)] AActor actor, USceneComponent parent)
		{
			return ULGUIBPLibrary.DuplicateActor(actor, parent);
		}
	}
}
