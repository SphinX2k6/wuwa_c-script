using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Furniture.Structure
{
	// Token: 0x02003F4D RID: 16205
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Furniture/Structure/FurnitureLevelGenerateInfo.FurnitureLevelGenerateInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FurnitureLevelGenerateInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029416 RID: 168982 RVA: 0x009BF924 File Offset: 0x009BDB24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FurnitureLevelGenerateInfo._ScriptStructPtr != 0) ? FurnitureLevelGenerateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Furniture/Structure/FurnitureLevelGenerateInfo.FurnitureLevelGenerateInfo", ref FurnitureLevelGenerateInfo._ScriptStructPtr);
		}

		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x06029417 RID: 168983 RVA: 0x009BF948 File Offset: 0x009BDB48
		// (set) Token: 0x06029418 RID: 168984 RVA: 0x009BF967 File Offset: 0x009BDB67
		public TSoftObjectPtr<UStaticMesh> SourcePath
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FurnitureLevelGenerateInfo.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FurnitureLevelGenerateInfo.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x06029419 RID: 168985 RVA: 0x009BF98C File Offset: 0x009BDB8C
		// (set) Token: 0x0602941A RID: 168986 RVA: 0x009BF9A0 File Offset: 0x009BDBA0
		public unsafe string TargetSubPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FurnitureLevelGenerateInfo.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FurnitureLevelGenerateInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x0602941B RID: 168987 RVA: 0x009BF9B5 File Offset: 0x009BDBB5
		public FurnitureLevelGenerateInfo()
		{
		}

		// Token: 0x0602941C RID: 168988 RVA: 0x009BF9BD File Offset: 0x009BDBBD
		public FurnitureLevelGenerateInfo(TSoftObjectPtr<UStaticMesh> SourcePath, string TargetSubPath)
		{
			this.SourcePath = SourcePath;
			this.TargetSubPath = TargetSubPath;
		}

		// Token: 0x0602941D RID: 168989 RVA: 0x009BF9D3 File Offset: 0x009BDBD3
		protected override IntPtr GetUStructPtr()
		{
			return FurnitureLevelGenerateInfo.StaticStruct();
		}

		// Token: 0x0602941E RID: 168990 RVA: 0x009BF9DF File Offset: 0x009BDBDF
		[NullableContext(2)]
		public FurnitureLevelGenerateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602941F RID: 168991 RVA: 0x009BF9E9 File Offset: 0x009BDBE9
		public FurnitureLevelGenerateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029420 RID: 168992 RVA: 0x009BF9F4 File Offset: 0x009BDBF4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FurnitureLevelGenerateInfo(Pointer, false, true);
		}

		// Token: 0x06029421 RID: 168993 RVA: 0x009BF9FE File Offset: 0x009BDBFE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FurnitureLevelGenerateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04015213 RID: 86547
		public const string __ObjectPath = "/Game/Aki/Data/Furniture/Structure/FurnitureLevelGenerateInfo.FurnitureLevelGenerateInfo";

		// Token: 0x04015214 RID: 86548
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015215 RID: 86549
		internal static int __PropertyOffset_0;

		// Token: 0x04015216 RID: 86550
		internal static int __PropertyOffset_1;
	}
}
