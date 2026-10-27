using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DandelionInteraction.DT
{
	// Token: 0x02003DEA RID: 15850
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionFT.Struct_DandelionFT")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class Struct_DandelionFT : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060278C5 RID: 161989 RVA: 0x009946D0 File Offset: 0x009928D0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_DandelionFT._ScriptStructPtr != 0) ? Struct_DandelionFT._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionFT.Struct_DandelionFT", ref Struct_DandelionFT._ScriptStructPtr);
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x060278C6 RID: 161990 RVA: 0x009946F4 File Offset: 0x009928F4
		// (set) Token: 0x060278C7 RID: 161991 RVA: 0x00994708 File Offset: 0x00992908
		[Nullable(2)]
		public unsafe UFoliageType_InstancedStaticMesh FT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType_InstancedStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionFT.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionFT.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x060278C8 RID: 161992 RVA: 0x00994720 File Offset: 0x00992920
		// (set) Token: 0x060278C9 RID: 161993 RVA: 0x00994763 File Offset: 0x00992963
		public TArray<FVector4> PointsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._PointsArray) == null)
				{
					result = (this._PointsArray = new TArray<FVector4>(base.NativePtr + (IntPtr)Struct_DandelionFT.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PointsArray.CopyAssign(value);
			}
		}

		// Token: 0x060278CA RID: 161994 RVA: 0x00994771 File Offset: 0x00992971
		public Struct_DandelionFT()
		{
		}

		// Token: 0x060278CB RID: 161995 RVA: 0x00994779 File Offset: 0x00992979
		public Struct_DandelionFT(UFoliageType_InstancedStaticMesh FT, TArray<FVector4> PointsArray)
		{
			this.FT = FT;
			this.PointsArray = PointsArray;
		}

		// Token: 0x060278CC RID: 161996 RVA: 0x0099478F File Offset: 0x0099298F
		protected override IntPtr GetUStructPtr()
		{
			return Struct_DandelionFT.StaticStruct();
		}

		// Token: 0x060278CD RID: 161997 RVA: 0x0099479B File Offset: 0x0099299B
		[NullableContext(2)]
		public Struct_DandelionFT(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060278CE RID: 161998 RVA: 0x009947A5 File Offset: 0x009929A5
		public Struct_DandelionFT(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060278CF RID: 161999 RVA: 0x009947B0 File Offset: 0x009929B0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_DandelionFT(Pointer, false, true);
		}

		// Token: 0x060278D0 RID: 162000 RVA: 0x009947BA File Offset: 0x009929BA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_DandelionFT(Pointer, MemoryOwner);
		}

		// Token: 0x04013FF4 RID: 81908
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionFT.Struct_DandelionFT";

		// Token: 0x04013FF5 RID: 81909
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FF6 RID: 81910
		internal static int __PropertyOffset_0;

		// Token: 0x04013FF7 RID: 81911
		internal static int __PropertyOffset_1;

		// Token: 0x04013FF8 RID: 81912
		[Nullable(2)]
		private TArray<FVector4> _PointsArray;
	}
}
