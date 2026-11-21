using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011A RID: 282
	public static class FBulletHitActorInterface
	{
		// Token: 0x06000A73 RID: 2675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_OnBulletHit_Internal(IntPtr obj, int bulletEntityId, FVector hitPoint);

		// Token: 0x06000A74 RID: 2676 RVA: 0x000343B0 File Offset: 0x000325B0
		[NullableContext(2)]
		public static void Execute_OnBulletHit(UObject obj, int bulletEntityId, FVector hitPoint)
		{
			if (obj == null || !obj.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Core;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "[FBulletHitActorInterface.Execute_OnBulletHit] UObject为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BulletEntityId", bulletEntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FBulletHitActorInterface.Execute_OnBulletHit_Internal(obj.NativePtr, bulletEntityId, hitPoint);
		}
	}
}
