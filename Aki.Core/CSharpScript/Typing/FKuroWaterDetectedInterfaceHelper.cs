using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000121 RID: 289
	[NullableContext(2)]
	[Nullable(0)]
	public static class FKuroWaterDetectedInterfaceHelper
	{
		// Token: 0x06000A81 RID: 2689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedTick_Internal(IntPtr obj, float deltaTime, float waterSurface, FVector location);

		// Token: 0x06000A82 RID: 2690 RVA: 0x00033EAC File Offset: 0x000320AC
		public static void Execute_BroadcastWaterDetectedTick(UObject obj, float deltaTime, float waterSurface, FVector location)
		{
			if (obj == null || !obj.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedTick] UObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedTick_Internal(obj.NativePtr, deltaTime, waterSurface, location);
		}

		// Token: 0x06000A83 RID: 2691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedStart_Internal(IntPtr obj);

		// Token: 0x06000A84 RID: 2692 RVA: 0x00033EF0 File Offset: 0x000320F0
		public static void Execute_BroadcastWaterDetectedStart(UObject obj)
		{
			if (obj == null || !obj.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedStart] UObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedStart_Internal(obj.NativePtr);
		}

		// Token: 0x06000A85 RID: 2693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedEnd_Internal(IntPtr obj);

		// Token: 0x06000A86 RID: 2694 RVA: 0x00033F30 File Offset: 0x00032130
		public static void Execute_BroadcastWaterDetectedEnd(UObject obj)
		{
			if (obj == null || !obj.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedEnd] UObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedEnd_Internal(obj.NativePtr);
		}
	}
}
