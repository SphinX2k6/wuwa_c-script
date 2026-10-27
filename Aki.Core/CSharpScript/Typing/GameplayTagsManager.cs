using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	public static class GameplayTagsManager
	{
		// Token: 0x06000A9C RID: 2716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetOriginalTag_Internal(in FName tagName);

		// Token: 0x06000A9D RID: 2717 RVA: 0x00033FC7 File Offset: 0x000321C7
		public static string GetOriginalTag(in FName tagName)
		{
			return GameplayTagsManager.GetOriginalTag_Internal(tagName);
		}
	}
}
