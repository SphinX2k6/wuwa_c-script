using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011D RID: 285
	[NullableContext(2)]
	[Nullable(0)]
	public static class FKuroAIPerceptionUtils
	{
		// Token: 0x06000A8B RID: 2699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartAsyncAiPerception_Internal(IntPtr callback, int dataId, double nowTime, IntPtr lineElement);

		// Token: 0x06000A8C RID: 2700 RVA: 0x00034484 File Offset: 0x00032684
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

		// Token: 0x06000A8D RID: 2701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Initialize_Internal(IntPtr entityTypeQueryNames, int eEntityTypeQueryCharacter, int eEntityTypeQuerySceneItem, int eEntityTypeQueryMaxIndex, int eCharMoveStateOther, int eCharMoveStateStand, int eCharMoveStateWalk, int eCharMoveStateWalkStop, int eCharMoveStateGlide, int eCharPositionStateGround, int eSenseTargetTypeCharacter);

		// Token: 0x06000A8E RID: 2702 RVA: 0x000344F8 File Offset: 0x000326F8
		public static void Initialize(in TArray<FName> entityTypeQueryNames, int eEntityTypeQueryCharacter, int eEntityTypeQuerySceneItem, int eEntityTypeQueryMaxIndex, int eCharMoveStateOther, int eCharMoveStateStand, int eCharMoveStateWalk, int eCharMoveStateWalkStop, int eCharMoveStateGlide, int eCharPositionStateGround, int eSenseTargetTypeCharacter)
		{
			if (entityTypeQueryNames == null || !entityTypeQueryNames.IsValid())
			{
				Log.Instance.Error(ELogModule.Core, ELogAuthor.LRX, "[FKuroAIPerceptionUtils.Initialize] EntityTypeQueryNames无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FKuroAIPerceptionUtils.Initialize_Internal(entityTypeQueryNames.NativePtr, eEntityTypeQueryCharacter, eEntityTypeQuerySceneItem, eEntityTypeQueryMaxIndex, eCharMoveStateOther, eCharMoveStateStand, eCharMoveStateWalk, eCharMoveStateWalkStop, eCharMoveStateGlide, eCharPositionStateGround, eSenseTargetTypeCharacter);
		}

		// Token: 0x06000A8F RID: 2703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Clear_Internal();

		// Token: 0x06000A90 RID: 2704 RVA: 0x0003454B File Offset: 0x0003274B
		public static void Clear()
		{
			FKuroAIPerceptionUtils.Clear_Internal();
		}
	}
}
