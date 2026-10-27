using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02004458 RID: 17496
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/ImpostorBaker/ImpostorBaker/BP/Structs/BPTextureData.BPTextureData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class BPTextureData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D467 RID: 185447 RVA: 0x00A38400 File Offset: 0x00A36600
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BPTextureData._ScriptStructPtr != 0) ? BPTextureData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/ImpostorBaker/ImpostorBaker/BP/Structs/BPTextureData.BPTextureData", ref BPTextureData._ScriptStructPtr);
		}

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x0602D468 RID: 185448 RVA: 0x00A38424 File Offset: 0x00A36624
		// (set) Token: 0x0602D469 RID: 185449 RVA: 0x00A38434 File Offset: 0x00A36634
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPTextureData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPTextureData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x0602D46A RID: 185450 RVA: 0x00A38445 File Offset: 0x00A36645
		// (set) Token: 0x0602D46B RID: 185451 RVA: 0x00A38455 File Offset: 0x00A36655
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BPTextureData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BPTextureData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x0602D46C RID: 185452 RVA: 0x00A38468 File Offset: 0x00A36668
		// (set) Token: 0x0602D46D RID: 185453 RVA: 0x00A384AB File Offset: 0x00A366AB
		public TArray<FLinearColor> ColorData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._ColorData) == null)
				{
					result = (this._ColorData = new TArray<FLinearColor>(base.NativePtr + (IntPtr)BPTextureData.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorData.CopyAssign(value);
			}
		}

		// Token: 0x0602D46E RID: 185454 RVA: 0x00A384B9 File Offset: 0x00A366B9
		public BPTextureData()
		{
		}

		// Token: 0x0602D46F RID: 185455 RVA: 0x00A384C1 File Offset: 0x00A366C1
		public BPTextureData(int SizeX, int SizeY, TArray<FLinearColor> ColorData)
		{
			this.SizeX = SizeX;
			this.SizeY = SizeY;
			this.ColorData = ColorData;
		}

		// Token: 0x0602D470 RID: 185456 RVA: 0x00A384DE File Offset: 0x00A366DE
		protected override IntPtr GetUStructPtr()
		{
			return BPTextureData.StaticStruct();
		}

		// Token: 0x0602D471 RID: 185457 RVA: 0x00A384EA File Offset: 0x00A366EA
		[NullableContext(2)]
		public BPTextureData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D472 RID: 185458 RVA: 0x00A384F4 File Offset: 0x00A366F4
		public BPTextureData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D473 RID: 185459 RVA: 0x00A384FF File Offset: 0x00A366FF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BPTextureData(Pointer, false, true);
		}

		// Token: 0x0602D474 RID: 185460 RVA: 0x00A38509 File Offset: 0x00A36709
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BPTextureData(Pointer, MemoryOwner);
		}

		// Token: 0x04018199 RID: 98713
		public const string __ObjectPath = "/ImpostorBaker/ImpostorBaker/BP/Structs/BPTextureData.BPTextureData";

		// Token: 0x0401819A RID: 98714
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401819B RID: 98715
		internal static int __PropertyOffset_0;

		// Token: 0x0401819C RID: 98716
		internal static int __PropertyOffset_1;

		// Token: 0x0401819D RID: 98717
		internal static int __PropertyOffset_2;

		// Token: 0x0401819E RID: 98718
		[Nullable(2)]
		private TArray<FLinearColor> _ColorData;
	}
}
