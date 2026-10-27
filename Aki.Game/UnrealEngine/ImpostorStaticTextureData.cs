using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02004459 RID: 17497
	[HasGetTypeHash]
	[UnrealObjectPath("/ImpostorBaker/ImpostorBaker/BP/Structs/ImpostorStaticTextureData.ImpostorStaticTextureData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class ImpostorStaticTextureData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D475 RID: 185461 RVA: 0x00A38512 File Offset: 0x00A36712
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ImpostorStaticTextureData._ScriptStructPtr != 0) ? ImpostorStaticTextureData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/ImpostorBaker/ImpostorBaker/BP/Structs/ImpostorStaticTextureData.ImpostorStaticTextureData", ref ImpostorStaticTextureData._ScriptStructPtr);
		}

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x0602D476 RID: 185462 RVA: 0x00A38536 File Offset: 0x00A36736
		// (set) Token: 0x0602D477 RID: 185463 RVA: 0x00A3854A File Offset: 0x00A3674A
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ImpostorStaticTextureData.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ImpostorStaticTextureData.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x0602D478 RID: 185464 RVA: 0x00A3855F File Offset: 0x00A3675F
		// (set) Token: 0x0602D479 RID: 185465 RVA: 0x00A38573 File Offset: 0x00A36773
		public unsafe TEnumAsByte<EImpostorBakeTypes> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ImpostorStaticTextureData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ImpostorStaticTextureData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602D47A RID: 185466 RVA: 0x00A38588 File Offset: 0x00A36788
		public ImpostorStaticTextureData()
		{
		}

		// Token: 0x0602D47B RID: 185467 RVA: 0x00A38590 File Offset: 0x00A36790
		public ImpostorStaticTextureData([Nullable(1)] UTexture2D Texture, TEnumAsByte<EImpostorBakeTypes> Type)
		{
			this.Texture = Texture;
			this.Type = Type;
		}

		// Token: 0x0602D47C RID: 185468 RVA: 0x00A385A6 File Offset: 0x00A367A6
		protected override IntPtr GetUStructPtr()
		{
			return ImpostorStaticTextureData.StaticStruct();
		}

		// Token: 0x0602D47D RID: 185469 RVA: 0x00A385B2 File Offset: 0x00A367B2
		[NullableContext(2)]
		public ImpostorStaticTextureData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D47E RID: 185470 RVA: 0x00A385BC File Offset: 0x00A367BC
		public ImpostorStaticTextureData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D47F RID: 185471 RVA: 0x00A385C7 File Offset: 0x00A367C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ImpostorStaticTextureData(Pointer, false, true);
		}

		// Token: 0x0602D480 RID: 185472 RVA: 0x00A385D1 File Offset: 0x00A367D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ImpostorStaticTextureData(Pointer, MemoryOwner);
		}

		// Token: 0x0401819F RID: 98719
		[Nullable(1)]
		public const string __ObjectPath = "/ImpostorBaker/ImpostorBaker/BP/Structs/ImpostorStaticTextureData.ImpostorStaticTextureData";

		// Token: 0x040181A0 RID: 98720
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040181A1 RID: 98721
		internal static int __PropertyOffset_0;

		// Token: 0x040181A2 RID: 98722
		internal static int __PropertyOffset_1;
	}
}
