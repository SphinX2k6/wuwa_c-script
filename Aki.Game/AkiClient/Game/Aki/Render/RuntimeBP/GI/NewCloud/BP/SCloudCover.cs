using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D65 RID: 15717
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudCover.SCloudCover")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SCloudCover : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268E5 RID: 157925 RVA: 0x009784F0 File Offset: 0x009766F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCloudCover._ScriptStructPtr != 0) ? SCloudCover._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudCover.SCloudCover", ref SCloudCover._ScriptStructPtr);
		}

		// Token: 0x170052F5 RID: 21237
		// (get) Token: 0x060268E6 RID: 157926 RVA: 0x00978514 File Offset: 0x00976714
		// (set) Token: 0x060268E7 RID: 157927 RVA: 0x00978528 File Offset: 0x00976728
		[Nullable(2)]
		public unsafe UMaterialInterface CoverMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + SCloudCover.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCloudCover.__PropertyOffset_0, value);
			}
		}

		// Token: 0x060268E8 RID: 157928 RVA: 0x0097853D File Offset: 0x0097673D
		public SCloudCover()
		{
		}

		// Token: 0x060268E9 RID: 157929 RVA: 0x00978545 File Offset: 0x00976745
		[NullableContext(1)]
		public SCloudCover(UMaterialInterface CoverMaterial)
		{
			this.CoverMaterial = CoverMaterial;
		}

		// Token: 0x060268EA RID: 157930 RVA: 0x00978554 File Offset: 0x00976754
		protected override IntPtr GetUStructPtr()
		{
			return SCloudCover.StaticStruct();
		}

		// Token: 0x060268EB RID: 157931 RVA: 0x00978560 File Offset: 0x00976760
		[NullableContext(2)]
		public SCloudCover(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060268EC RID: 157932 RVA: 0x0097856A File Offset: 0x0097676A
		public SCloudCover(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060268ED RID: 157933 RVA: 0x00978575 File Offset: 0x00976775
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCloudCover(Pointer, false, true);
		}

		// Token: 0x060268EE RID: 157934 RVA: 0x0097857F File Offset: 0x0097677F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCloudCover(Pointer, MemoryOwner);
		}

		// Token: 0x04013609 RID: 79369
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/SCloudCover.SCloudCover";

		// Token: 0x0401360A RID: 79370
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401360B RID: 79371
		internal static int __PropertyOffset_0;
	}
}
