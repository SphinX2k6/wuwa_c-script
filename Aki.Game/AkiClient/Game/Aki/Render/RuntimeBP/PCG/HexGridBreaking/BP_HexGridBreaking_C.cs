using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x02003CA1 RID: 15521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_HexGridBreaking.BP_HexGridBreaking_C")]
	[UnrealStructLayout(1832, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1825)]
	public class BP_HexGridBreaking_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060246DA RID: 149210 RVA: 0x0093E4E2 File Offset: 0x0093C6E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_HexGridBreaking_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_HexGridBreaking.BP_HexGridBreaking_C");
			}
			return BP_HexGridBreaking_C._ClassPtr;
		}

		// Token: 0x060246DB RID: 149211 RVA: 0x0093E508 File Offset: 0x0093C708
		public BP_HexGridBreaking_C() : this(BuiltinUtils.AllocNativeUObject(BP_HexGridBreaking_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060246DC RID: 149212 RVA: 0x0093E530 File Offset: 0x0093C730
		public BP_HexGridBreaking_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_HexGridBreaking_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x060246DD RID: 149213 RVA: 0x0093E563 File Offset: 0x0093C763
		// (set) Token: 0x060246DE RID: 149214 RVA: 0x0093E577 File Offset: 0x0093C777
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_HexGridBreaking_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_HexGridBreaking_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x060246DF RID: 149215 RVA: 0x0093E58C File Offset: 0x0093C78C
		// (set) Token: 0x060246E0 RID: 149216 RVA: 0x0093E5C5 File Offset: 0x0093C7C5
		public TMap<BP_RuntimeCellPieces_C, float> HitCellPieceActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<BP_RuntimeCellPieces_C, float> result;
				if ((result = this._HitCellPieceActors) == null)
				{
					result = (this._HitCellPieceActors = new TMap<BP_RuntimeCellPieces_C, float>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.HitCellPieceActors.CopyAssign(value);
			}
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x060246E1 RID: 149217 RVA: 0x0093E5D4 File Offset: 0x0093C7D4
		// (set) Token: 0x060246E2 RID: 149218 RVA: 0x0093E60D File Offset: 0x0093C80D
		public TMap<UStaticMesh, UStaticMesh> SMPiecesMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, UStaticMesh> result;
				if ((result = this._SMPiecesMap) == null)
				{
					result = (this._SMPiecesMap = new TMap<UStaticMesh, UStaticMesh>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.SMPiecesMap.CopyAssign(value);
			}
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x060246E3 RID: 149219 RVA: 0x0093E61B File Offset: 0x0093C81B
		// (set) Token: 0x060246E4 RID: 149220 RVA: 0x0093E62B File Offset: 0x0093C82B
		public unsafe float In_Delta_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x060246E5 RID: 149221 RVA: 0x0093E63C File Offset: 0x0093C83C
		// (set) Token: 0x060246E6 RID: 149222 RVA: 0x0093E64C File Offset: 0x0093C84C
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x060246E7 RID: 149223 RVA: 0x0093E660 File Offset: 0x0093C860
		// (set) Token: 0x060246E8 RID: 149224 RVA: 0x0093E699 File Offset: 0x0093C899
		public TArray<FVector> DirectoryList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._DirectoryList) == null)
				{
					result = (this._DirectoryList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.DirectoryList.CopyAssign(value);
			}
		}

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x060246E9 RID: 149225 RVA: 0x0093E6A7 File Offset: 0x0093C8A7
		// (set) Token: 0x060246EA RID: 149226 RVA: 0x0093E6BB File Offset: 0x0093C8BB
		public unsafe FVectorDouble OriginPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x060246EB RID: 149227 RVA: 0x0093E6D0 File Offset: 0x0093C8D0
		// (set) Token: 0x060246EC RID: 149228 RVA: 0x0093E6E4 File Offset: 0x0093C8E4
		public unsafe FVectorDouble OffsetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x060246ED RID: 149229 RVA: 0x0093E6FC File Offset: 0x0093C8FC
		// (set) Token: 0x060246EE RID: 149230 RVA: 0x0093E735 File Offset: 0x0093C935
		public TArray<BP_RuntimeCellPieces_C> CellPieceActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_RuntimeCellPieces_C> result;
				if ((result = this._CellPieceActors) == null)
				{
					result = (this._CellPieceActors = new TArray<BP_RuntimeCellPieces_C>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.CellPieceActors.CopyAssign(value);
			}
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x060246EF RID: 149231 RVA: 0x0093E743 File Offset: 0x0093C943
		// (set) Token: 0x060246F0 RID: 149232 RVA: 0x0093E753 File Offset: 0x0093C953
		public unsafe bool Ready
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x060246F1 RID: 149233 RVA: 0x0093E764 File Offset: 0x0093C964
		// (set) Token: 0x060246F2 RID: 149234 RVA: 0x0093E79D File Offset: 0x0093C99D
		public TMap<string, AStaticMeshActor> CellActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, AStaticMeshActor> result;
				if ((result = this._CellActors) == null)
				{
					result = (this._CellActors = new TMap<string, AStaticMeshActor>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.CellActors.CopyAssign(value);
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x060246F3 RID: 149235 RVA: 0x0093E7AC File Offset: 0x0093C9AC
		// (set) Token: 0x060246F4 RID: 149236 RVA: 0x0093E7E5 File Offset: 0x0093C9E5
		public TArray<int> NewVar_0
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NewVar_0) == null)
				{
					result = (this._NewVar_0 = new TArray<int>(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.NewVar_0.CopyAssign(value);
			}
		}

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x060246F5 RID: 149237 RVA: 0x0093E7F3 File Offset: 0x0093C9F3
		// (set) Token: 0x060246F6 RID: 149238 RVA: 0x0093E803 File Offset: 0x0093CA03
		public unsafe bool IsMonster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_HexGridBreaking_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x060246F7 RID: 149239 RVA: 0x0093E814 File Offset: 0x0093CA14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialization()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__Initialization_NativeFunctionPtr, null);
		}

		// Token: 0x060246F8 RID: 149240 RVA: 0x0093E828 File Offset: 0x0093CA28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBreakActor(FVectorDouble Position, ref BP_RuntimeCellPieces_C Actor)
		{
			BP_HexGridBreaking_C.__GetBreakActor_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__GetBreakActor_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_HexGridBreaking_C.__GetBreakActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__GetBreakActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			ref BP_HexGridBreaking_C.__GetBreakActor_FunctionParams ptr2 = ref *ptr;
			BP_RuntimeCellPieces_C bp_RuntimeCellPieces_C = Actor;
			ptr2.Actor = ((bp_RuntimeCellPieces_C != null) ? bp_RuntimeCellPieces_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__GetBreakActor_NativeFunctionPtr, (void*)ptr);
			Actor = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_RuntimeCellPieces_C>(ptr->Actor);
		}

		// Token: 0x060246F9 RID: 149241 RVA: 0x0093E898 File Offset: 0x0093CA98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetOffsetPosition(int Index, float OffsetDistance, ref FVectorDouble OffsetPosition)
		{
			BP_HexGridBreaking_C.__GetOffsetPosition_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__GetOffsetPosition_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_HexGridBreaking_C.__GetOffsetPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__GetOffsetPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->OffsetDistance = OffsetDistance;
			ptr->OffsetPosition = OffsetPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__GetOffsetPosition_NativeFunctionPtr, (void*)ptr);
			OffsetPosition = ptr->OffsetPosition;
		}

		// Token: 0x060246FA RID: 149242 RVA: 0x0093E900 File Offset: 0x0093CB00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void WorldToHexCoord(FVectorDouble Position, float Size, ref FIntVector HexCoord)
		{
			BP_HexGridBreaking_C.__WorldToHexCoord_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__WorldToHexCoord_FunctionParams[(UIntPtr)431] + 15L / (long)sizeof(BP_HexGridBreaking_C.__WorldToHexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__WorldToHexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			ptr->Size = Size;
			ptr->HexCoord = HexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__WorldToHexCoord_NativeFunctionPtr, (void*)ptr);
			HexCoord = ptr->HexCoord;
		}

		// Token: 0x060246FB RID: 149243 RVA: 0x0093E968 File Offset: 0x0093CB68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060246FC RID: 149244 RVA: 0x0093E97C File Offset: 0x0093CB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HexGridBreaking_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060246FD RID: 149245 RVA: 0x0093E994 File Offset: 0x0093CB94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_HexGridBreaking_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HexGridBreaking_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246FE RID: 149246 RVA: 0x0093E9DC File Offset: 0x0093CBDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_HexGridBreaking_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_HexGridBreaking_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_HexGridBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060246FF RID: 149247 RVA: 0x0093EA24 File Offset: 0x0093CC24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_HexGridBreaking_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_HexGridBreaking_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_HexGridBreaking_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_HexGridBreaking_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_HexGridBreaking_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024700 RID: 149248 RVA: 0x0093EA87 File Offset: 0x0093CC87
		protected BP_HexGridBreaking_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012136 RID: 74038
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_HexGridBreaking.BP_HexGridBreaking_C";

		// Token: 0x04012137 RID: 74039
		private static IntPtr _ClassPtr;

		// Token: 0x04012138 RID: 74040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012139 RID: 74041
		internal static int __PropertyOffset_1;

		// Token: 0x0401213A RID: 74042
		internal static int __PropertyOffset_2;

		// Token: 0x0401213B RID: 74043
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<BP_RuntimeCellPieces_C, float> _HitCellPieceActors;

		// Token: 0x0401213C RID: 74044
		internal static int __PropertyOffset_3;

		// Token: 0x0401213D RID: 74045
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMesh, UStaticMesh> _SMPiecesMap;

		// Token: 0x0401213E RID: 74046
		internal static int __PropertyOffset_4;

		// Token: 0x0401213F RID: 74047
		internal static int __PropertyOffset_5;

		// Token: 0x04012140 RID: 74048
		internal static int __PropertyOffset_6;

		// Token: 0x04012141 RID: 74049
		[Nullable(2)]
		private TArray<FVector> _DirectoryList;

		// Token: 0x04012142 RID: 74050
		internal static int __PropertyOffset_7;

		// Token: 0x04012143 RID: 74051
		internal static int __PropertyOffset_8;

		// Token: 0x04012144 RID: 74052
		internal static int __PropertyOffset_9;

		// Token: 0x04012145 RID: 74053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_RuntimeCellPieces_C> _CellPieceActors;

		// Token: 0x04012146 RID: 74054
		internal static int __PropertyOffset_10;

		// Token: 0x04012147 RID: 74055
		internal static int __PropertyOffset_11;

		// Token: 0x04012148 RID: 74056
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, AStaticMeshActor> _CellActors;

		// Token: 0x04012149 RID: 74057
		internal static int __PropertyOffset_12;

		// Token: 0x0401214A RID: 74058
		[Nullable(2)]
		private TArray<int> _NewVar_0;

		// Token: 0x0401214B RID: 74059
		internal static int __PropertyOffset_13;

		// Token: 0x0401214C RID: 74060
		private static IntPtr __Initialization_NativeFunctionPtr;

		// Token: 0x0401214D RID: 74061
		private static IntPtr __GetBreakActor_NativeFunctionPtr;

		// Token: 0x0401214E RID: 74062
		private static IntPtr __GetOffsetPosition_NativeFunctionPtr;

		// Token: 0x0401214F RID: 74063
		private static IntPtr __WorldToHexCoord_NativeFunctionPtr;

		// Token: 0x04012150 RID: 74064
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012151 RID: 74065
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012152 RID: 74066
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009F1A RID: 40730
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __GetBreakActor_FunctionParams
		{
			// Token: 0x0403187B RID: 202875
			[FieldOffset(0)]
			public FVectorDouble Position;

			// Token: 0x0403187C RID: 202876
			[FieldOffset(24)]
			public IntPtr Actor;
		}

		// Token: 0x02009F1B RID: 40731
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __GetOffsetPosition_FunctionParams
		{
			// Token: 0x0403187D RID: 202877
			[FieldOffset(0)]
			public int Index;

			// Token: 0x0403187E RID: 202878
			[FieldOffset(4)]
			public float OffsetDistance;

			// Token: 0x0403187F RID: 202879
			[FieldOffset(8)]
			public FVectorDouble OffsetPosition;
		}

		// Token: 0x02009F1C RID: 40732
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __WorldToHexCoord_FunctionParams
		{
			// Token: 0x04031880 RID: 202880
			[FieldOffset(0)]
			public FVectorDouble Position;

			// Token: 0x04031881 RID: 202881
			[FieldOffset(24)]
			public float Size;

			// Token: 0x04031882 RID: 202882
			[FieldOffset(28)]
			public FIntVector HexCoord;
		}

		// Token: 0x02009F1D RID: 40733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031883 RID: 202883
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F1E RID: 40734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031884 RID: 202884
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031885 RID: 202885
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031886 RID: 202886
			[FieldOffset(32)]
			public int Id;
		}
	}
}
