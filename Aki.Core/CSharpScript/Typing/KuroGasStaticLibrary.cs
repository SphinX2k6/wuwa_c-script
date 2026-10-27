using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000126 RID: 294
	public static class KuroGasStaticLibrary
	{
		// Token: 0x06000AA3 RID: 2723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetMultiAttributesValue_Internal(IntPtr attributeSet, IntPtr multiAttributes, IntPtr baseValues, IntPtr currentValues);

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00033FE8 File Offset: 0x000321E8
		[NullableContext(1)]
		public static void SetMultiAttributesValue([Nullable(2)] UBaseAttributeSet attributeSet, ref TArray<int> multiAttributes, ref TArray<float> baseValues, ref TArray<float> currentValues)
		{
			if (attributeSet == null || !attributeSet.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[KuroGasStaticLibrary.SetMultiAttributesValue] attributeSet", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			KuroGasStaticLibrary.SetMultiAttributesValue_Internal(attributeSet.NativePtr, multiAttributes.NativePtr, baseValues.NativePtr, currentValues.NativePtr);
		}
	}
}
