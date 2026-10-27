using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AAC RID: 15020
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailDrawInfo.STrailDrawInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class STrailDrawInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060202BB RID: 131771 RVA: 0x008CBB97 File Offset: 0x008C9D97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STrailDrawInfo._ScriptStructPtr != 0) ? STrailDrawInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailDrawInfo.STrailDrawInfo", ref STrailDrawInfo._ScriptStructPtr);
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x060202BC RID: 131772 RVA: 0x008CBBBB File Offset: 0x008C9DBB
		// (set) Token: 0x060202BD RID: 131773 RVA: 0x008CBBCF File Offset: 0x008C9DCF
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x060202BE RID: 131774 RVA: 0x008CBBE4 File Offset: 0x008C9DE4
		// (set) Token: 0x060202BF RID: 131775 RVA: 0x008CBBF8 File Offset: 0x008C9DF8
		[Nullable(2)]
		public unsafe UTexture texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + STrailDrawInfo.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + STrailDrawInfo.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x060202C0 RID: 131776 RVA: 0x008CBC0D File Offset: 0x008C9E0D
		// (set) Token: 0x060202C1 RID: 131777 RVA: 0x008CBC21 File Offset: 0x008C9E21
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x060202C2 RID: 131778 RVA: 0x008CBC36 File Offset: 0x008C9E36
		// (set) Token: 0x060202C3 RID: 131779 RVA: 0x008CBC46 File Offset: 0x008C9E46
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x060202C4 RID: 131780 RVA: 0x008CBC57 File Offset: 0x008C9E57
		// (set) Token: 0x060202C5 RID: 131781 RVA: 0x008CBC67 File Offset: 0x008C9E67
		public unsafe float Depth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)STrailDrawInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x060202C6 RID: 131782 RVA: 0x008CBC78 File Offset: 0x008C9E78
		public STrailDrawInfo()
		{
		}

		// Token: 0x060202C7 RID: 131783 RVA: 0x008CBC80 File Offset: 0x008C9E80
		[NullableContext(1)]
		public STrailDrawInfo(FVector2D Position, UTexture texture, FVector2D Size, float Rotation, float Depth)
		{
			this.Position = Position;
			this.texture = texture;
			this.Size = Size;
			this.Rotation = Rotation;
			this.Depth = Depth;
		}

		// Token: 0x060202C8 RID: 131784 RVA: 0x008CBCAD File Offset: 0x008C9EAD
		protected override IntPtr GetUStructPtr()
		{
			return STrailDrawInfo.StaticStruct();
		}

		// Token: 0x060202C9 RID: 131785 RVA: 0x008CBCB9 File Offset: 0x008C9EB9
		[NullableContext(2)]
		public STrailDrawInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060202CA RID: 131786 RVA: 0x008CBCC3 File Offset: 0x008C9EC3
		public STrailDrawInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060202CB RID: 131787 RVA: 0x008CBCCE File Offset: 0x008C9ECE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STrailDrawInfo(Pointer, false, true);
		}

		// Token: 0x060202CC RID: 131788 RVA: 0x008CBCD8 File Offset: 0x008C9ED8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STrailDrawInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400F8C6 RID: 63686
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/STrailDrawInfo.STrailDrawInfo";

		// Token: 0x0400F8C7 RID: 63687
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F8C8 RID: 63688
		internal static int __PropertyOffset_0;

		// Token: 0x0400F8C9 RID: 63689
		internal static int __PropertyOffset_1;

		// Token: 0x0400F8CA RID: 63690
		internal static int __PropertyOffset_2;

		// Token: 0x0400F8CB RID: 63691
		internal static int __PropertyOffset_3;

		// Token: 0x0400F8CC RID: 63692
		internal static int __PropertyOffset_4;
	}
}
