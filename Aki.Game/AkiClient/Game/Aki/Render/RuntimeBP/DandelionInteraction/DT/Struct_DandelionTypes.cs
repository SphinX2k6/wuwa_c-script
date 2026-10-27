using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DandelionInteraction.DT
{
	// Token: 0x02003DEB RID: 15851
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionTypes.Struct_DandelionTypes")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 57)]
	public class Struct_DandelionTypes : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060278D1 RID: 162001 RVA: 0x009947C3 File Offset: 0x009929C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_DandelionTypes._ScriptStructPtr != 0) ? Struct_DandelionTypes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionTypes.Struct_DandelionTypes", ref Struct_DandelionTypes._ScriptStructPtr);
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x060278D2 RID: 162002 RVA: 0x009947E7 File Offset: 0x009929E7
		// (set) Token: 0x060278D3 RID: 162003 RVA: 0x009947FB File Offset: 0x009929FB
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x060278D4 RID: 162004 RVA: 0x00994810 File Offset: 0x00992A10
		// (set) Token: 0x060278D5 RID: 162005 RVA: 0x00994824 File Offset: 0x00992A24
		public unsafe USkeletalMesh SkeletonMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x060278D6 RID: 162006 RVA: 0x00994839 File Offset: 0x00992A39
		// (set) Token: 0x060278D7 RID: 162007 RVA: 0x00994849 File Offset: 0x00992A49
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_DandelionTypes.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_DandelionTypes.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x060278D8 RID: 162008 RVA: 0x0099485A File Offset: 0x00992A5A
		// (set) Token: 0x060278D9 RID: 162009 RVA: 0x0099486E File Offset: 0x00992A6E
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x060278DA RID: 162010 RVA: 0x00994883 File Offset: 0x00992A83
		// (set) Token: 0x060278DB RID: 162011 RVA: 0x00994897 File Offset: 0x00992A97
		public unsafe UNiagaraSystem NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_DandelionTypes.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x060278DC RID: 162012 RVA: 0x009948AC File Offset: 0x00992AAC
		// (set) Token: 0x060278DD RID: 162013 RVA: 0x009948EF File Offset: 0x00992AEF
		[Nullable(1)]
		public TArray<FName> ParentSocketNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ParentSocketNames) == null)
				{
					result = (this._ParentSocketNames = new TArray<FName>(base.NativePtr + (IntPtr)Struct_DandelionTypes.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParentSocketNames.CopyAssign(value);
			}
		}

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x060278DE RID: 162014 RVA: 0x009948FD File Offset: 0x00992AFD
		// (set) Token: 0x060278DF RID: 162015 RVA: 0x0099490D File Offset: 0x00992B0D
		public unsafe bool OpenWeaponInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_DandelionTypes.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_DandelionTypes.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x060278E0 RID: 162016 RVA: 0x0099491E File Offset: 0x00992B1E
		public Struct_DandelionTypes()
		{
		}

		// Token: 0x060278E1 RID: 162017 RVA: 0x00994926 File Offset: 0x00992B26
		[NullableContext(1)]
		public Struct_DandelionTypes(UStaticMesh StaticMesh, USkeletalMesh SkeletonMesh, float TraceRadius, KUROInteractFoliage_C FoliageType, UNiagaraSystem NiagaraSystem, TArray<FName> ParentSocketNames, bool OpenWeaponInteraction)
		{
			this.StaticMesh = StaticMesh;
			this.SkeletonMesh = SkeletonMesh;
			this.TraceRadius = TraceRadius;
			this.FoliageType = FoliageType;
			this.NiagaraSystem = NiagaraSystem;
			this.ParentSocketNames = ParentSocketNames;
			this.OpenWeaponInteraction = OpenWeaponInteraction;
		}

		// Token: 0x060278E2 RID: 162018 RVA: 0x00994963 File Offset: 0x00992B63
		protected override IntPtr GetUStructPtr()
		{
			return Struct_DandelionTypes.StaticStruct();
		}

		// Token: 0x060278E3 RID: 162019 RVA: 0x0099496F File Offset: 0x00992B6F
		public Struct_DandelionTypes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060278E4 RID: 162020 RVA: 0x00994979 File Offset: 0x00992B79
		public Struct_DandelionTypes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060278E5 RID: 162021 RVA: 0x00994984 File Offset: 0x00992B84
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_DandelionTypes(Pointer, false, true);
		}

		// Token: 0x060278E6 RID: 162022 RVA: 0x0099498E File Offset: 0x00992B8E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_DandelionTypes(Pointer, MemoryOwner);
		}

		// Token: 0x04013FF9 RID: 81913
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DandelionInteraction/DT/Struct_DandelionTypes.Struct_DandelionTypes";

		// Token: 0x04013FFA RID: 81914
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FFB RID: 81915
		internal static int __PropertyOffset_0;

		// Token: 0x04013FFC RID: 81916
		internal static int __PropertyOffset_1;

		// Token: 0x04013FFD RID: 81917
		internal static int __PropertyOffset_2;

		// Token: 0x04013FFE RID: 81918
		internal static int __PropertyOffset_3;

		// Token: 0x04013FFF RID: 81919
		internal static int __PropertyOffset_4;

		// Token: 0x04014000 RID: 81920
		internal static int __PropertyOffset_5;

		// Token: 0x04014001 RID: 81921
		private TArray<FName> _ParentSocketNames;

		// Token: 0x04014002 RID: 81922
		internal static int __PropertyOffset_6;
	}
}
