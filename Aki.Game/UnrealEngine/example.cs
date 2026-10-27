using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200445C RID: 17500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/json2struct/example.example")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class example : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D499 RID: 185497 RVA: 0x00A3875A File Offset: 0x00A3695A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (example._ScriptStructPtr != 0) ? example._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/json2struct/example.example", ref example._ScriptStructPtr);
		}

		// Token: 0x170072DE RID: 29406
		// (get) Token: 0x0602D49A RID: 185498 RVA: 0x00A3877E File Offset: 0x00A3697E
		// (set) Token: 0x0602D49B RID: 185499 RVA: 0x00A38792 File Offset: 0x00A36992
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)example.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)example.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170072DF RID: 29407
		// (get) Token: 0x0602D49C RID: 185500 RVA: 0x00A387A7 File Offset: 0x00A369A7
		// (set) Token: 0x0602D49D RID: 185501 RVA: 0x00A387B7 File Offset: 0x00A369B7
		public unsafe bool Boolean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)example.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)example.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170072E0 RID: 29408
		// (get) Token: 0x0602D49E RID: 185502 RVA: 0x00A387C8 File Offset: 0x00A369C8
		// (set) Token: 0x0602D49F RID: 185503 RVA: 0x00A387D8 File Offset: 0x00A369D8
		public unsafe int Integer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)example.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)example.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170072E1 RID: 29409
		// (get) Token: 0x0602D4A0 RID: 185504 RVA: 0x00A387E9 File Offset: 0x00A369E9
		// (set) Token: 0x0602D4A1 RID: 185505 RVA: 0x00A387F9 File Offset: 0x00A369F9
		public unsafe float Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)example.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)example.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170072E2 RID: 29410
		// (get) Token: 0x0602D4A2 RID: 185506 RVA: 0x00A3880C File Offset: 0x00A36A0C
		// (set) Token: 0x0602D4A3 RID: 185507 RVA: 0x00A3884F File Offset: 0x00A36A4F
		public ExampleNested Struct
		{
			get
			{
				base.FastCheckIsValid();
				ExampleNested result;
				if ((result = this._Struct) == null)
				{
					result = (this._Struct = new ExampleNested(base.NativePtr + (IntPtr)example.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(ExampleNested.StaticStruct(), base.NativePtr + (IntPtr)example.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170072E3 RID: 29411
		// (get) Token: 0x0602D4A4 RID: 185508 RVA: 0x00A38870 File Offset: 0x00A36A70
		// (set) Token: 0x0602D4A5 RID: 185509 RVA: 0x00A388B3 File Offset: 0x00A36AB3
		public TArray<ExampleNested> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ExampleNested> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<ExampleNested>(base.NativePtr + (IntPtr)example.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x170072E4 RID: 29412
		// (get) Token: 0x0602D4A6 RID: 185510 RVA: 0x00A388C4 File Offset: 0x00A36AC4
		// (set) Token: 0x0602D4A7 RID: 185511 RVA: 0x00A38907 File Offset: 0x00A36B07
		public TMap<string, ExampleNested> Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, ExampleNested> result;
				if ((result = this._Map) == null)
				{
					result = (this._Map = new TMap<string, ExampleNested>(base.NativePtr + (IntPtr)example.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Map.CopyAssign(value);
			}
		}

		// Token: 0x0602D4A8 RID: 185512 RVA: 0x00A38915 File Offset: 0x00A36B15
		public example()
		{
		}

		// Token: 0x0602D4A9 RID: 185513 RVA: 0x00A3891D File Offset: 0x00A36B1D
		public example(string String, bool Boolean, int Integer, float Float, ExampleNested Struct, TArray<ExampleNested> Array, TMap<string, ExampleNested> Map)
		{
			this.String = String;
			this.Boolean = Boolean;
			this.Integer = Integer;
			this.Float = Float;
			this.Struct = Struct;
			this.Array = Array;
			this.Map = Map;
		}

		// Token: 0x0602D4AA RID: 185514 RVA: 0x00A3895A File Offset: 0x00A36B5A
		protected override IntPtr GetUStructPtr()
		{
			return example.StaticStruct();
		}

		// Token: 0x0602D4AB RID: 185515 RVA: 0x00A38966 File Offset: 0x00A36B66
		[NullableContext(2)]
		public example(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D4AC RID: 185516 RVA: 0x00A38970 File Offset: 0x00A36B70
		public example(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D4AD RID: 185517 RVA: 0x00A3897B File Offset: 0x00A36B7B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new example(Pointer, false, true);
		}

		// Token: 0x0602D4AE RID: 185518 RVA: 0x00A38985 File Offset: 0x00A36B85
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new example(Pointer, MemoryOwner);
		}

		// Token: 0x040181AB RID: 98731
		public const string __ObjectPath = "/json2struct/example.example";

		// Token: 0x040181AC RID: 98732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040181AD RID: 98733
		internal static int __PropertyOffset_0;

		// Token: 0x040181AE RID: 98734
		internal static int __PropertyOffset_1;

		// Token: 0x040181AF RID: 98735
		internal static int __PropertyOffset_2;

		// Token: 0x040181B0 RID: 98736
		internal static int __PropertyOffset_3;

		// Token: 0x040181B1 RID: 98737
		internal static int __PropertyOffset_4;

		// Token: 0x040181B2 RID: 98738
		[Nullable(2)]
		private ExampleNested _Struct;

		// Token: 0x040181B3 RID: 98739
		internal static int __PropertyOffset_5;

		// Token: 0x040181B4 RID: 98740
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ExampleNested> _Array;

		// Token: 0x040181B5 RID: 98741
		internal static int __PropertyOffset_6;

		// Token: 0x040181B6 RID: 98742
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, ExampleNested> _Map;
	}
}
