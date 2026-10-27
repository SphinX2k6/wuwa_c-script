using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200445B RID: 17499
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/json2struct/ExampleNested.ExampleNested")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class ExampleNested : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D48D RID: 185485 RVA: 0x00A3869A File Offset: 0x00A3689A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ExampleNested._ScriptStructPtr != 0) ? ExampleNested._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/json2struct/ExampleNested.ExampleNested", ref ExampleNested._ScriptStructPtr);
		}

		// Token: 0x170072DC RID: 29404
		// (get) Token: 0x0602D48E RID: 185486 RVA: 0x00A386BE File Offset: 0x00A368BE
		// (set) Token: 0x0602D48F RID: 185487 RVA: 0x00A386D2 File Offset: 0x00A368D2
		public unsafe string StringNest
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ExampleNested.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ExampleNested.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170072DD RID: 29405
		// (get) Token: 0x0602D490 RID: 185488 RVA: 0x00A386E7 File Offset: 0x00A368E7
		// (set) Token: 0x0602D491 RID: 185489 RVA: 0x00A386F7 File Offset: 0x00A368F7
		public unsafe int IntegerNest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ExampleNested.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ExampleNested.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602D492 RID: 185490 RVA: 0x00A38708 File Offset: 0x00A36908
		public ExampleNested()
		{
		}

		// Token: 0x0602D493 RID: 185491 RVA: 0x00A38710 File Offset: 0x00A36910
		public ExampleNested(string StringNest, int IntegerNest)
		{
			this.StringNest = StringNest;
			this.IntegerNest = IntegerNest;
		}

		// Token: 0x0602D494 RID: 185492 RVA: 0x00A38726 File Offset: 0x00A36926
		protected override IntPtr GetUStructPtr()
		{
			return ExampleNested.StaticStruct();
		}

		// Token: 0x0602D495 RID: 185493 RVA: 0x00A38732 File Offset: 0x00A36932
		[NullableContext(2)]
		public ExampleNested(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D496 RID: 185494 RVA: 0x00A3873C File Offset: 0x00A3693C
		public ExampleNested(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D497 RID: 185495 RVA: 0x00A38747 File Offset: 0x00A36947
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ExampleNested(Pointer, false, true);
		}

		// Token: 0x0602D498 RID: 185496 RVA: 0x00A38751 File Offset: 0x00A36951
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ExampleNested(Pointer, MemoryOwner);
		}

		// Token: 0x040181A7 RID: 98727
		public const string __ObjectPath = "/json2struct/ExampleNested.ExampleNested";

		// Token: 0x040181A8 RID: 98728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040181A9 RID: 98729
		internal static int __PropertyOffset_0;

		// Token: 0x040181AA RID: 98730
		internal static int __PropertyOffset_1;
	}
}
