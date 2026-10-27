using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x02003B4D RID: 15181
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SSceneInteractionMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219E1 RID: 137697 RVA: 0x008F10A3 File Offset: 0x008EF2A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionMontage._ScriptStructPtr != 0) ? SSceneInteractionMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage", ref SSceneInteractionMontage._ScriptStructPtr);
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x060219E2 RID: 137698 RVA: 0x008F10C7 File Offset: 0x008EF2C7
		// (set) Token: 0x060219E3 RID: 137699 RVA: 0x008F10DB File Offset: 0x008EF2DB
		public unsafe ASkeletalMeshActor SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x060219E4 RID: 137700 RVA: 0x008F10F0 File Offset: 0x008EF2F0
		// (set) Token: 0x060219E5 RID: 137701 RVA: 0x008F1104 File Offset: 0x008EF304
		public unsafe UAnimMontage Montage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x060219E6 RID: 137702 RVA: 0x008F1119 File Offset: 0x008EF319
		// (set) Token: 0x060219E7 RID: 137703 RVA: 0x008F1129 File Offset: 0x008EF329
		public unsafe bool Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x060219E8 RID: 137704 RVA: 0x008F113A File Offset: 0x008EF33A
		// (set) Token: 0x060219E9 RID: 137705 RVA: 0x008F114A File Offset: 0x008EF34A
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x008F115B File Offset: 0x008EF35B
		public SSceneInteractionMontage()
		{
		}

		// Token: 0x060219EB RID: 137707 RVA: 0x008F1163 File Offset: 0x008EF363
		[NullableContext(1)]
		public SSceneInteractionMontage(ASkeletalMeshActor SkeletalMesh, UAnimMontage Montage, bool Loop, float PlayRate)
		{
			this.SkeletalMesh = SkeletalMesh;
			this.Montage = Montage;
			this.Loop = Loop;
			this.PlayRate = PlayRate;
		}

		// Token: 0x060219EC RID: 137708 RVA: 0x008F1188 File Offset: 0x008EF388
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionMontage.StaticStruct();
		}

		// Token: 0x060219ED RID: 137709 RVA: 0x008F1194 File Offset: 0x008EF394
		public SSceneInteractionMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219EE RID: 137710 RVA: 0x008F119E File Offset: 0x008EF39E
		public SSceneInteractionMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219EF RID: 137711 RVA: 0x008F11A9 File Offset: 0x008EF3A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionMontage(Pointer, false, true);
		}

		// Token: 0x060219F0 RID: 137712 RVA: 0x008F11B3 File Offset: 0x008EF3B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04010643 RID: 67139
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage";

		// Token: 0x04010644 RID: 67140
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010645 RID: 67141
		internal static int __PropertyOffset_0;

		// Token: 0x04010646 RID: 67142
		internal static int __PropertyOffset_1;

		// Token: 0x04010647 RID: 67143
		internal static int __PropertyOffset_2;

		// Token: 0x04010648 RID: 67144
		internal static int __PropertyOffset_3;
	}
}
