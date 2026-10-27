using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200444E RID: 17486
	[UnrealObjectPath("/Engine/ArtTools/RenderToTexture/Blueprints/PhysMesh.PhysMesh")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class PhysMesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D431 RID: 185393 RVA: 0x00A37FC8 File Offset: 0x00A361C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (PhysMesh._ScriptStructPtr != 0) ? PhysMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Engine/ArtTools/RenderToTexture/Blueprints/PhysMesh.PhysMesh", ref PhysMesh._ScriptStructPtr);
		}

		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x0602D432 RID: 185394 RVA: 0x00A37FEC File Offset: 0x00A361EC
		// (set) Token: 0x0602D433 RID: 185395 RVA: 0x00A38000 File Offset: 0x00A36200
		[Nullable(2)]
		public unsafe UStaticMesh SMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PhysMesh.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PhysMesh.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x0602D434 RID: 185396 RVA: 0x00A38015 File Offset: 0x00A36215
		// (set) Token: 0x0602D435 RID: 185397 RVA: 0x00A38029 File Offset: 0x00A36229
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PhysMesh.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PhysMesh.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602D436 RID: 185398 RVA: 0x00A3803E File Offset: 0x00A3623E
		public PhysMesh()
		{
		}

		// Token: 0x0602D437 RID: 185399 RVA: 0x00A38046 File Offset: 0x00A36246
		[NullableContext(1)]
		public PhysMesh(UStaticMesh SMesh, FTransform Transform)
		{
			this.SMesh = SMesh;
			this.Transform = Transform;
		}

		// Token: 0x0602D438 RID: 185400 RVA: 0x00A3805C File Offset: 0x00A3625C
		protected override IntPtr GetUStructPtr()
		{
			return PhysMesh.StaticStruct();
		}

		// Token: 0x0602D439 RID: 185401 RVA: 0x00A38068 File Offset: 0x00A36268
		[NullableContext(2)]
		public PhysMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D43A RID: 185402 RVA: 0x00A38072 File Offset: 0x00A36272
		public PhysMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D43B RID: 185403 RVA: 0x00A3807D File Offset: 0x00A3627D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new PhysMesh(Pointer, false, true);
		}

		// Token: 0x0602D43C RID: 185404 RVA: 0x00A38087 File Offset: 0x00A36287
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new PhysMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04018151 RID: 98641
		[Nullable(1)]
		public const string __ObjectPath = "/Engine/ArtTools/RenderToTexture/Blueprints/PhysMesh.PhysMesh";

		// Token: 0x04018152 RID: 98642
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018153 RID: 98643
		internal static int __PropertyOffset_0;

		// Token: 0x04018154 RID: 98644
		internal static int __PropertyOffset_1;
	}
}
