using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030C5 RID: 12485
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SSceneInteractionMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E06F RID: 122991 RVA: 0x00908CE5 File Offset: 0x00906EE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSceneInteractionMontage._ScriptStructPtr != 0) ? SSceneInteractionMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage", ref SSceneInteractionMontage._ScriptStructPtr);
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0601E070 RID: 122992 RVA: 0x00908D09 File Offset: 0x00906F09
		// (set) Token: 0x0601E071 RID: 122993 RVA: 0x00908D1D File Offset: 0x00906F1D
		public unsafe ASkeletalMeshActor SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0601E072 RID: 122994 RVA: 0x00908D32 File Offset: 0x00906F32
		// (set) Token: 0x0601E073 RID: 122995 RVA: 0x00908D46 File Offset: 0x00906F46
		public unsafe UAnimMontage Montage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimMontage>(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_Montage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSceneInteractionMontage.__PropertyOffset_Montage, value);
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0601E074 RID: 122996 RVA: 0x00908D5B File Offset: 0x00906F5B
		// (set) Token: 0x0601E075 RID: 122997 RVA: 0x00908D6B File Offset: 0x00906F6B
		public unsafe bool Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_Loop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_Loop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0601E076 RID: 122998 RVA: 0x00908D7C File Offset: 0x00906F7C
		// (set) Token: 0x0601E077 RID: 122999 RVA: 0x00908D8C File Offset: 0x00906F8C
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSceneInteractionMontage.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x0601E078 RID: 123000 RVA: 0x00908D9D File Offset: 0x00906F9D
		public SSceneInteractionMontage()
		{
		}

		// Token: 0x0601E079 RID: 123001 RVA: 0x00908DA5 File Offset: 0x00906FA5
		protected override IntPtr GetUStructPtr()
		{
			return SSceneInteractionMontage.StaticStruct();
		}

		// Token: 0x0601E07A RID: 123002 RVA: 0x00908DB1 File Offset: 0x00906FB1
		public SSceneInteractionMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E07B RID: 123003 RVA: 0x00908DBB File Offset: 0x00906FBB
		public SSceneInteractionMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E07C RID: 123004 RVA: 0x00908DC6 File Offset: 0x00906FC6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSceneInteractionMontage(Pointer, false, true);
		}

		// Token: 0x0601E07D RID: 123005 RVA: 0x00908DD0 File Offset: 0x00906FD0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSceneInteractionMontage(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDE6 RID: 64998
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/SSceneInteractionMontage.SSceneInteractionMontage";

		// Token: 0x0400FDE7 RID: 64999
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDE8 RID: 65000
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0400FDE9 RID: 65001
		internal static int __PropertyOffset_Montage;

		// Token: 0x0400FDEA RID: 65002
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400FDEB RID: 65003
		internal static int __PropertyOffset_PlayRate;
	}
}
