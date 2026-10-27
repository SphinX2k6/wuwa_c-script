using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011D RID: 285
	public static class FKuroCrashCollectionController
	{
		// Token: 0x06000A3A RID: 2618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Initialize_Internal(IntPtr world, FName actorLocationName, FName actorRotationName, FName cameraLocationName, FName cameraRotationName, FName worldName);

		// Token: 0x06000A3B RID: 2619 RVA: 0x00033AE0 File Offset: 0x00031CE0
		[NullableContext(2)]
		public static void Initialize(UWorld world, FName actorLocationName, FName actorRotationName, FName cameraLocationName, FName cameraRotationName, FName worldName)
		{
			if (world == null || !world.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroCrashCollectionController.Initialize] World为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroCrashCollectionController.Initialize_Internal(world.NativePtr, actorLocationName, actorRotationName, cameraLocationName, cameraRotationName, worldName);
		}
	}
}
