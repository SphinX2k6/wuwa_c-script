using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000125 RID: 293
	[NullableContext(1)]
	[Nullable(0)]
	public static class GameplayTagsManager
	{
		// Token: 0x06000AF3 RID: 2803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetOriginalTag_Internal(in FName tagName);

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00034A3B File Offset: 0x00032C3B
		public static string GetOriginalTag(in FName tagName)
		{
			return GameplayTagsManager.GetOriginalTag_Internal(tagName);
		}
	}
}
