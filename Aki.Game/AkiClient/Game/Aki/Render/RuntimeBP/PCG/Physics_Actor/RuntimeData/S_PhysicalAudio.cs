using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor.RuntimeData
{
	// Token: 0x02003C3B RID: 15419
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/RuntimeData/S_PhysicalAudio.S_PhysicalAudio")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class S_PhysicalAudio : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023788 RID: 145288 RVA: 0x00924C67 File Offset: 0x00922E67
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_PhysicalAudio._ScriptStructPtr != 0) ? S_PhysicalAudio._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/RuntimeData/S_PhysicalAudio.S_PhysicalAudio", ref S_PhysicalAudio._ScriptStructPtr);
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06023789 RID: 145289 RVA: 0x00924C8B File Offset: 0x00922E8B
		// (set) Token: 0x0602378A RID: 145290 RVA: 0x00924C9F File Offset: 0x00922E9F
		public unsafe UPhysicalMaterial ObjectMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x0602378B RID: 145291 RVA: 0x00924CB4 File Offset: 0x00922EB4
		// (set) Token: 0x0602378C RID: 145292 RVA: 0x00924CC8 File Offset: 0x00922EC8
		public unsafe UPhysicalMaterial SurfaceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0602378D RID: 145293 RVA: 0x00924CDD File Offset: 0x00922EDD
		// (set) Token: 0x0602378E RID: 145294 RVA: 0x00924CF1 File Offset: 0x00922EF1
		public unsafe UAkAudioEvent Sound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_PhysicalAudio.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x0602378F RID: 145295 RVA: 0x00924D06 File Offset: 0x00922F06
		// (set) Token: 0x06023790 RID: 145296 RVA: 0x00924D16 File Offset: 0x00922F16
		public unsafe float Cooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_PhysicalAudio.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_PhysicalAudio.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06023791 RID: 145297 RVA: 0x00924D27 File Offset: 0x00922F27
		public S_PhysicalAudio()
		{
		}

		// Token: 0x06023792 RID: 145298 RVA: 0x00924D2F File Offset: 0x00922F2F
		[NullableContext(1)]
		public S_PhysicalAudio(UPhysicalMaterial ObjectMaterial, UPhysicalMaterial SurfaceMaterial, UAkAudioEvent Sound, float Cooldown)
		{
			this.ObjectMaterial = ObjectMaterial;
			this.SurfaceMaterial = SurfaceMaterial;
			this.Sound = Sound;
			this.Cooldown = Cooldown;
		}

		// Token: 0x06023793 RID: 145299 RVA: 0x00924D54 File Offset: 0x00922F54
		protected override IntPtr GetUStructPtr()
		{
			return S_PhysicalAudio.StaticStruct();
		}

		// Token: 0x06023794 RID: 145300 RVA: 0x00924D60 File Offset: 0x00922F60
		public S_PhysicalAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023795 RID: 145301 RVA: 0x00924D6A File Offset: 0x00922F6A
		public S_PhysicalAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023796 RID: 145302 RVA: 0x00924D75 File Offset: 0x00922F75
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_PhysicalAudio(Pointer, false, true);
		}

		// Token: 0x06023797 RID: 145303 RVA: 0x00924D7F File Offset: 0x00922F7F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_PhysicalAudio(Pointer, MemoryOwner);
		}

		// Token: 0x0401182D RID: 71725
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/RuntimeData/S_PhysicalAudio.S_PhysicalAudio";

		// Token: 0x0401182E RID: 71726
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401182F RID: 71727
		internal static int __PropertyOffset_0;

		// Token: 0x04011830 RID: 71728
		internal static int __PropertyOffset_1;

		// Token: 0x04011831 RID: 71729
		internal static int __PropertyOffset_2;

		// Token: 0x04011832 RID: 71730
		internal static int __PropertyOffset_3;
	}
}
