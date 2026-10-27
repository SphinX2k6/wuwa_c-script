using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B4E RID: 15182
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSceneInteractionSequence : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219F1 RID: 137713 RVA: 0x008F11BC File Offset: 0x008EF3BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionSequence._ScriptStructPtr != 0) ? SSceneInteractionSequence._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence", ref SSceneInteractionSequence._ScriptStructPtr);
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x060219F2 RID: 137714 RVA: 0x008F11E0 File Offset: 0x008EF3E0
		// (set) Token: 0x060219F3 RID: 137715 RVA: 0x008F11F4 File Offset: 0x008EF3F4
		[Nullable(2)]
		public unsafe ULevelSequence Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionSequence.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionSequence.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x060219F4 RID: 137716 RVA: 0x008F1209 File Offset: 0x008EF409
		// (set) Token: 0x060219F5 RID: 137717 RVA: 0x008F1219 File Offset: 0x008EF419
		public unsafe bool IsLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x060219F6 RID: 137718 RVA: 0x008F122A File Offset: 0x008EF42A
		// (set) Token: 0x060219F7 RID: 137719 RVA: 0x008F123A File Offset: 0x008EF43A
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x060219F8 RID: 137720 RVA: 0x008F124B File Offset: 0x008EF44B
		// (set) Token: 0x060219F9 RID: 137721 RVA: 0x008F125B File Offset: 0x008EF45B
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionSequence.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060219FA RID: 137722 RVA: 0x008F126C File Offset: 0x008EF46C
		public SSceneInteractionSequence()
		{
		}

		// Token: 0x060219FB RID: 137723 RVA: 0x008F1274 File Offset: 0x008EF474
		[NullableContext(1)]
		public SSceneInteractionSequence(ULevelSequence Sequence, bool IsLoop, bool Reverse, float PlayRate)
		{
			this.Sequence = Sequence;
			this.IsLoop = IsLoop;
			this.Reverse = Reverse;
			this.PlayRate = PlayRate;
		}

		// Token: 0x060219FC RID: 137724 RVA: 0x008F1299 File Offset: 0x008EF499
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionSequence.StaticStruct();
		}

		// Token: 0x060219FD RID: 137725 RVA: 0x008F12A5 File Offset: 0x008EF4A5
		[NullableContext(2)]
		public SSceneInteractionSequence(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x008F12AF File Offset: 0x008EF4AF
		public SSceneInteractionSequence(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x008F12BA File Offset: 0x008EF4BA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionSequence(Pointer, false, true);
		}

		// Token: 0x06021A00 RID: 137728 RVA: 0x008F12C4 File Offset: 0x008EF4C4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionSequence(Pointer, MemoryOwner);
		}

		// Token: 0x04010649 RID: 67145
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionSequence.SSceneInteractionSequence";

		// Token: 0x0401064A RID: 67146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401064B RID: 67147
		internal static int __PropertyOffset_0;

		// Token: 0x0401064C RID: 67148
		internal static int __PropertyOffset_1;

		// Token: 0x0401064D RID: 67149
		internal static int __PropertyOffset_2;

		// Token: 0x0401064E RID: 67150
		internal static int __PropertyOffset_3;
	}
}
