using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x0200321F RID: 12831
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SDecorationConfig_Effect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020019 RID: 131097 RVA: 0x0093AF2D File Offset: 0x0093912D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDecorationConfig_Effect._ScriptStructPtr != 0) ? SDecorationConfig_Effect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect", ref SDecorationConfig_Effect._ScriptStructPtr);
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0602001A RID: 131098 RVA: 0x0093AF51 File Offset: 0x00939151
		// (set) Token: 0x0602001B RID: 131099 RVA: 0x0093AF70 File Offset: 0x00939170
		public TSoftObjectPtr<UEffectModelBase> EffectData
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectData, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectData, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0602001C RID: 131100 RVA: 0x0093AF95 File Offset: 0x00939195
		// (set) Token: 0x0602001D RID: 131101 RVA: 0x0093AFA9 File Offset: 0x009391A9
		public unsafe string EffectSocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectSocketName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectSocketName)), value);
			}
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x0602001E RID: 131102 RVA: 0x0093AFBE File Offset: 0x009391BE
		// (set) Token: 0x0602001F RID: 131103 RVA: 0x0093AFD2 File Offset: 0x009391D2
		public unsafe FTransform EffectTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_EffectTrans) = value;
			}
		}

		// Token: 0x06020020 RID: 131104 RVA: 0x0093AFE7 File Offset: 0x009391E7
		public SDecorationConfig_Effect()
		{
		}

		// Token: 0x06020021 RID: 131105 RVA: 0x0093AFEF File Offset: 0x009391EF
		protected override IntPtr GetUStructPtr()
		{
			return SDecorationConfig_Effect.StaticStruct();
		}

		// Token: 0x06020022 RID: 131106 RVA: 0x0093AFFB File Offset: 0x009391FB
		[NullableContext(2)]
		public SDecorationConfig_Effect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020023 RID: 131107 RVA: 0x0093B005 File Offset: 0x00939205
		public SDecorationConfig_Effect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020024 RID: 131108 RVA: 0x0093B010 File Offset: 0x00939210
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDecorationConfig_Effect(Pointer, false, true);
		}

		// Token: 0x06020025 RID: 131109 RVA: 0x0093B01A File Offset: 0x0093921A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDecorationConfig_Effect(Pointer, MemoryOwner);
		}

		// Token: 0x04011326 RID: 70438
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect";

		// Token: 0x04011327 RID: 70439
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011328 RID: 70440
		internal static int __PropertyOffset_EffectData;

		// Token: 0x04011329 RID: 70441
		internal static int __PropertyOffset_EffectSocketName;

		// Token: 0x0401132A RID: 70442
		internal static int __PropertyOffset_EffectTrans;
	}
}
