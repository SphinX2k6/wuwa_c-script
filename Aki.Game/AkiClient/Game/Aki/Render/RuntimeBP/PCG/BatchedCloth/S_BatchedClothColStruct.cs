using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedCloth
{
	// Token: 0x02003CD6 RID: 15574
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColStruct.S_BatchedClothColStruct")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class S_BatchedClothColStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F08 RID: 151304 RVA: 0x0094CB64 File Offset: 0x0094AD64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BatchedClothColStruct._ScriptStructPtr != 0) ? S_BatchedClothColStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColStruct.S_BatchedClothColStruct", ref S_BatchedClothColStruct._ScriptStructPtr);
		}

		// Token: 0x170049EF RID: 18927
		// (get) Token: 0x06024F09 RID: 151305 RVA: 0x0094CB88 File Offset: 0x0094AD88
		// (set) Token: 0x06024F0A RID: 151306 RVA: 0x0094CB9C File Offset: 0x0094AD9C
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + S_BatchedClothColStruct.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_BatchedClothColStruct.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170049F0 RID: 18928
		// (get) Token: 0x06024F0B RID: 151307 RVA: 0x0094CBB1 File Offset: 0x0094ADB1
		// (set) Token: 0x06024F0C RID: 151308 RVA: 0x0094CBC5 File Offset: 0x0094ADC5
		public unsafe FTransform SMTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_BatchedClothColStruct.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_BatchedClothColStruct.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06024F0D RID: 151309 RVA: 0x0094CBDA File Offset: 0x0094ADDA
		public S_BatchedClothColStruct()
		{
		}

		// Token: 0x06024F0E RID: 151310 RVA: 0x0094CBE2 File Offset: 0x0094ADE2
		[NullableContext(1)]
		public S_BatchedClothColStruct(UStaticMesh StaticMesh, FTransform SMTransform)
		{
			this.StaticMesh = StaticMesh;
			this.SMTransform = SMTransform;
		}

		// Token: 0x06024F0F RID: 151311 RVA: 0x0094CBF8 File Offset: 0x0094ADF8
		protected override IntPtr GetUStructPtr()
		{
			return S_BatchedClothColStruct.StaticStruct();
		}

		// Token: 0x06024F10 RID: 151312 RVA: 0x0094CC04 File Offset: 0x0094AE04
		[NullableContext(2)]
		public S_BatchedClothColStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F11 RID: 151313 RVA: 0x0094CC0E File Offset: 0x0094AE0E
		public S_BatchedClothColStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F12 RID: 151314 RVA: 0x0094CC19 File Offset: 0x0094AE19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_BatchedClothColStruct(Pointer, false, true);
		}

		// Token: 0x06024F13 RID: 151315 RVA: 0x0094CC23 File Offset: 0x0094AE23
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_BatchedClothColStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040125E6 RID: 75238
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColStruct.S_BatchedClothColStruct";

		// Token: 0x040125E7 RID: 75239
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125E8 RID: 75240
		internal static int __PropertyOffset_0;

		// Token: 0x040125E9 RID: 75241
		internal static int __PropertyOffset_1;
	}
}
