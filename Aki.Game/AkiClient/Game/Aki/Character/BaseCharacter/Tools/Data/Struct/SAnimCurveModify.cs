using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools.Data.Struct
{
	// Token: 0x02004349 RID: 17225
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SAnimCurveModify.SAnimCurveModify")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SAnimCurveModify : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CAAC RID: 182956 RVA: 0x00A25520 File Offset: 0x00A23720
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAnimCurveModify._ScriptStructPtr != 0) ? SAnimCurveModify._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SAnimCurveModify.SAnimCurveModify", ref SAnimCurveModify._ScriptStructPtr);
		}

		// Token: 0x17007064 RID: 28772
		// (get) Token: 0x0602CAAD RID: 182957 RVA: 0x00A25544 File Offset: 0x00A23744
		// (set) Token: 0x0602CAAE RID: 182958 RVA: 0x00A25558 File Offset: 0x00A23758
		public unsafe string AnimSequenceNamePreFix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAnimCurveModify.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAnimCurveModify.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17007065 RID: 28773
		// (get) Token: 0x0602CAAF RID: 182959 RVA: 0x00A2556D File Offset: 0x00A2376D
		// (set) Token: 0x0602CAB0 RID: 182960 RVA: 0x00A25581 File Offset: 0x00A23781
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimCurveModify.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimCurveModify.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007066 RID: 28774
		// (get) Token: 0x0602CAB1 RID: 182961 RVA: 0x00A25596 File Offset: 0x00A23796
		// (set) Token: 0x0602CAB2 RID: 182962 RVA: 0x00A255A6 File Offset: 0x00A237A6
		public unsafe float CurveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimCurveModify.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimCurveModify.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CAB3 RID: 182963 RVA: 0x00A255B7 File Offset: 0x00A237B7
		public SAnimCurveModify()
		{
		}

		// Token: 0x0602CAB4 RID: 182964 RVA: 0x00A255BF File Offset: 0x00A237BF
		public SAnimCurveModify(string AnimSequenceNamePreFix, FName CurveName, float CurveValue)
		{
			this.AnimSequenceNamePreFix = AnimSequenceNamePreFix;
			this.CurveName = CurveName;
			this.CurveValue = CurveValue;
		}

		// Token: 0x0602CAB5 RID: 182965 RVA: 0x00A255DC File Offset: 0x00A237DC
		protected override IntPtr GetUStructPtr()
		{
			return SAnimCurveModify.StaticStruct();
		}

		// Token: 0x0602CAB6 RID: 182966 RVA: 0x00A255E8 File Offset: 0x00A237E8
		[NullableContext(2)]
		public SAnimCurveModify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CAB7 RID: 182967 RVA: 0x00A255F2 File Offset: 0x00A237F2
		public SAnimCurveModify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CAB8 RID: 182968 RVA: 0x00A255FD File Offset: 0x00A237FD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAnimCurveModify(Pointer, false, true);
		}

		// Token: 0x0602CAB9 RID: 182969 RVA: 0x00A25607 File Offset: 0x00A23807
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAnimCurveModify(Pointer, MemoryOwner);
		}

		// Token: 0x040178C4 RID: 96452
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SAnimCurveModify.SAnimCurveModify";

		// Token: 0x040178C5 RID: 96453
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178C6 RID: 96454
		internal static int __PropertyOffset_0;

		// Token: 0x040178C7 RID: 96455
		internal static int __PropertyOffset_1;

		// Token: 0x040178C8 RID: 96456
		internal static int __PropertyOffset_2;
	}
}
