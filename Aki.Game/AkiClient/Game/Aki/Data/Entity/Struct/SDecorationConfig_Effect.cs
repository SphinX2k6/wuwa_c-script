using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8A RID: 16266
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SDecorationConfig_Effect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029885 RID: 170117 RVA: 0x009C67E8 File Offset: 0x009C49E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDecorationConfig_Effect._ScriptStructPtr != 0) ? SDecorationConfig_Effect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect", ref SDecorationConfig_Effect._ScriptStructPtr);
		}

		// Token: 0x170063C5 RID: 25541
		// (get) Token: 0x06029886 RID: 170118 RVA: 0x009C680C File Offset: 0x009C4A0C
		// (set) Token: 0x06029887 RID: 170119 RVA: 0x009C682B File Offset: 0x009C4A2B
		public TSoftObjectPtr<UEffectModelBase> EffectData
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063C6 RID: 25542
		// (get) Token: 0x06029888 RID: 170120 RVA: 0x009C6850 File Offset: 0x009C4A50
		// (set) Token: 0x06029889 RID: 170121 RVA: 0x009C6864 File Offset: 0x009C4A64
		public unsafe string EffectSocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig_Effect.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig_Effect.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170063C7 RID: 25543
		// (get) Token: 0x0602988A RID: 170122 RVA: 0x009C6879 File Offset: 0x009C4A79
		// (set) Token: 0x0602988B RID: 170123 RVA: 0x009C688D File Offset: 0x009C4A8D
		public unsafe FTransform EffectTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig_Effect.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602988C RID: 170124 RVA: 0x009C68A2 File Offset: 0x009C4AA2
		public SDecorationConfig_Effect()
		{
		}

		// Token: 0x0602988D RID: 170125 RVA: 0x009C68AA File Offset: 0x009C4AAA
		public SDecorationConfig_Effect(TSoftObjectPtr<UEffectModelBase> EffectData, string EffectSocketName, FTransform EffectTrans)
		{
			this.EffectData = EffectData;
			this.EffectSocketName = EffectSocketName;
			this.EffectTrans = EffectTrans;
		}

		// Token: 0x0602988E RID: 170126 RVA: 0x009C68C7 File Offset: 0x009C4AC7
		protected override IntPtr GetUStructPtr()
		{
			return SDecorationConfig_Effect.StaticStruct();
		}

		// Token: 0x0602988F RID: 170127 RVA: 0x009C68D3 File Offset: 0x009C4AD3
		[NullableContext(2)]
		public SDecorationConfig_Effect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029890 RID: 170128 RVA: 0x009C68DD File Offset: 0x009C4ADD
		public SDecorationConfig_Effect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029891 RID: 170129 RVA: 0x009C68E8 File Offset: 0x009C4AE8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDecorationConfig_Effect(Pointer, false, true);
		}

		// Token: 0x06029892 RID: 170130 RVA: 0x009C68F2 File Offset: 0x009C4AF2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDecorationConfig_Effect(Pointer, MemoryOwner);
		}

		// Token: 0x040154A7 RID: 87207
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SDecorationConfig_Effect.SDecorationConfig_Effect";

		// Token: 0x040154A8 RID: 87208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154A9 RID: 87209
		internal static int __PropertyOffset_0;

		// Token: 0x040154AA RID: 87210
		internal static int __PropertyOffset_1;

		// Token: 0x040154AB RID: 87211
		internal static int __PropertyOffset_2;
	}
}
