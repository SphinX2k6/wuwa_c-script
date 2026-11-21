using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000122 RID: 290
	[NullableContext(2)]
	[Nullable(0)]
	public static class FKuroWaterDetectedInterfaceHelper
	{
		// Token: 0x06000AD8 RID: 2776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedTick_Internal(IntPtr obj, float deltaTime, float waterSurface, FVector location);

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00034920 File Offset: 0x00032B20
		public static void Execute_BroadcastWaterDetectedTick(UObject obj, float deltaTime, float waterSurface, FVector location)
		{
			if (obj == null || !obj.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedTick] UObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedTick_Internal(obj.NativePtr, deltaTime, waterSurface, location);
		}

		// Token: 0x06000ADA RID: 2778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedStart_Internal(IntPtr obj);

		// Token: 0x06000ADB RID: 2779 RVA: 0x00034964 File Offset: 0x00032B64
		public static void Execute_BroadcastWaterDetectedStart(UObject obj)
		{
			if (obj == null || !obj.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedStart] UObject为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroWaterDetectedInterfaceHelper.Execute_BroadcastWaterDetectedStart_Internal(obj.NativePtr);
		}

		// Token: 0x06000ADC RID: 2780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Execute_BroadcastWaterDetectedEnd_Internal(IntPtr obj);

		// Token: 0x06000ADD RID: 2781 RVA: 0x000349A4 File Offset: 0x00032BA4
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
