using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011C RID: 284
	[NullableContext(2)]
	[Nullable(0)]
	public static class FKuroAIPerceptionUtils
	{
		// Token: 0x06000A34 RID: 2612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartAsyncAiPerception_Internal(IntPtr callback, int dataId, double nowTime, IntPtr lineElement);

		// Token: 0x06000A35 RID: 2613 RVA: 0x00033A10 File Offset: 0x00031C10
		public static void StartAsyncAiPerception(in FAIAsyncPerceptionCallback callback, int dataId, double nowTime, UTraceLineElement lineElement)
		{
			if (callback == null || !callback.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroAIPerceptionUtils.StartAsyncAiPerception] callback", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (lineElement == null || !lineElement.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroAIPerceptionUtils.StartAsyncAiPerception] lineElement", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroAIPerceptionUtils.StartAsyncAiPerception_Internal(callback.NativePtr, dataId, nowTime, lineElement.NativePtr);
		}

		// Token: 0x06000A36 RID: 2614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Initialize_Internal(IntPtr entityTypeQueryNames, int eEntityTypeQueryCharacter, int eEntityTypeQuerySceneItem, int eEntityTypeQueryMaxIndex, int eCharMoveStateOther, int eCharMoveStateStand, int eCharMoveStateWalk, int eCharMoveStateWalkStop, int eCharMoveStateGlide, int eCharPositionStateGround, int eSenseTargetTypeCharacter);

		// Token: 0x06000A37 RID: 2615 RVA: 0x00033A84 File Offset: 0x00031C84
		public static void Initialize(in TArray<FName> entityTypeQueryNames, int eEntityTypeQueryCharacter, int eEntityTypeQuerySceneItem, int eEntityTypeQueryMaxIndex, int eCharMoveStateOther, int eCharMoveStateStand, int eCharMoveStateWalk, int eCharMoveStateWalkStop, int eCharMoveStateGlide, int eCharPositionStateGround, int eSenseTargetTypeCharacter)
		{
			if (entityTypeQueryNames == null || !entityTypeQueryNames.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroAIPerceptionUtils.Initialize] EntityTypeQueryNames无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroAIPerceptionUtils.Initialize_Internal(entityTypeQueryNames.NativePtr, eEntityTypeQueryCharacter, eEntityTypeQuerySceneItem, eEntityTypeQueryMaxIndex, eCharMoveStateOther, eCharMoveStateStand, eCharMoveStateWalk, eCharMoveStateWalkStop, eCharMoveStateGlide, eCharPositionStateGround, eSenseTargetTypeCharacter);
		}

		// Token: 0x06000A38 RID: 2616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Clear_Internal();

		// Token: 0x06000A39 RID: 2617 RVA: 0x00033AD7 File Offset: 0x00031CD7
		public static void Clear()
		{
			FKuroAIPerceptionUtils.Clear_Internal();
		}
	}
}
