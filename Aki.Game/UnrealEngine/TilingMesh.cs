using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200444F RID: 17487
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Engine/ArtTools/RenderToTexture/Blueprints/TilingMesh.TilingMesh")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class TilingMesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D43D RID: 185405 RVA: 0x00A38090 File Offset: 0x00A36290
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (TilingMesh._ScriptStructPtr != 0) ? TilingMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Engine/ArtTools/RenderToTexture/Blueprints/TilingMesh.TilingMesh", ref TilingMesh._ScriptStructPtr);
		}

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x0602D43E RID: 185406 RVA: 0x00A380B4 File Offset: 0x00A362B4
		// (set) Token: 0x0602D43F RID: 185407 RVA: 0x00A380C8 File Offset: 0x00A362C8
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x0602D440 RID: 185408 RVA: 0x00A380DD File Offset: 0x00A362DD
		// (set) Token: 0x0602D441 RID: 185409 RVA: 0x00A380F1 File Offset: 0x00A362F1
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TilingMesh.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)TilingMesh.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072CA RID: 29386
		// (get) Token: 0x0602D442 RID: 185410 RVA: 0x00A38106 File Offset: 0x00A36306
		// (set) Token: 0x0602D443 RID: 185411 RVA: 0x00A3811A File Offset: 0x00A3631A
		public unsafe UMaterialInstanceConstant Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170072CB RID: 29387
		// (get) Token: 0x0602D444 RID: 185412 RVA: 0x00A3812F File Offset: 0x00A3632F
		// (set) Token: 0x0602D445 RID: 185413 RVA: 0x00A3813F File Offset: 0x00A3633F
		public unsafe bool Visible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)TilingMesh.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)TilingMesh.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072CC RID: 29388
		// (get) Token: 0x0602D446 RID: 185414 RVA: 0x00A38150 File Offset: 0x00A36350
		// (set) Token: 0x0602D447 RID: 185415 RVA: 0x00A38164 File Offset: 0x00A36364
		public unsafe UTexture DisplacementTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TilingMesh.__PropertyOffset_4, value);
			}
		}

		// Token: 0x0602D448 RID: 185416 RVA: 0x00A38179 File Offset: 0x00A36379
		public TilingMesh()
		{
		}

		// Token: 0x0602D449 RID: 185417 RVA: 0x00A38181 File Offset: 0x00A36381
		[NullableContext(1)]
		public TilingMesh(UStaticMesh StaticMesh, FTransform Transform, UMaterialInstanceConstant Material, bool Visible, UTexture DisplacementTexture)
		{
			this.StaticMesh = StaticMesh;
			this.Transform = Transform;
			this.Material = Material;
			this.Visible = Visible;
			this.DisplacementTexture = DisplacementTexture;
		}

		// Token: 0x0602D44A RID: 185418 RVA: 0x00A381AE File Offset: 0x00A363AE
		protected override IntPtr GetUStructPtr()
		{
			return TilingMesh.StaticStruct();
		}

		// Token: 0x0602D44B RID: 185419 RVA: 0x00A381BA File Offset: 0x00A363BA
		public TilingMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D44C RID: 185420 RVA: 0x00A381C4 File Offset: 0x00A363C4
		public TilingMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D44D RID: 185421 RVA: 0x00A381CF File Offset: 0x00A363CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new TilingMesh(Pointer, false, true);
		}

		// Token: 0x0602D44E RID: 185422 RVA: 0x00A381D9 File Offset: 0x00A363D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new TilingMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04018155 RID: 98645
		[Nullable(1)]
		public const string __ObjectPath = "/Engine/ArtTools/RenderToTexture/Blueprints/TilingMesh.TilingMesh";

		// Token: 0x04018156 RID: 98646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018157 RID: 98647
		internal static int __PropertyOffset_0;

		// Token: 0x04018158 RID: 98648
		internal static int __PropertyOffset_1;

		// Token: 0x04018159 RID: 98649
		internal static int __PropertyOffset_2;

		// Token: 0x0401815A RID: 98650
		internal static int __PropertyOffset_3;

		// Token: 0x0401815B RID: 98651
		internal static int __PropertyOffset_4;
	}
}
