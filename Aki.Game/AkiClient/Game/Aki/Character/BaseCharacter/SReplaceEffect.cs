using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004329 RID: 17193
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReplaceEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C861 RID: 182369 RVA: 0x00A21CFA File Offset: 0x00A1FEFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReplaceEffect._ScriptStructPtr != 0) ? SReplaceEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect", ref SReplaceEffect._ScriptStructPtr);
		}

		// Token: 0x17006FA9 RID: 28585
		// (get) Token: 0x0602C862 RID: 182370 RVA: 0x00A21D1E File Offset: 0x00A1FF1E
		// (set) Token: 0x0602C863 RID: 182371 RVA: 0x00A21D3D File Offset: 0x00A1FF3D
		public TSoftObjectPtr<UObject> OldEffect
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006FAA RID: 28586
		// (get) Token: 0x0602C864 RID: 182372 RVA: 0x00A21D62 File Offset: 0x00A1FF62
		// (set) Token: 0x0602C865 RID: 182373 RVA: 0x00A21D81 File Offset: 0x00A1FF81
		public TSoftObjectPtr<UObject> NewEffect
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602C866 RID: 182374 RVA: 0x00A21DA6 File Offset: 0x00A1FFA6
		public SReplaceEffect()
		{
		}

		// Token: 0x0602C867 RID: 182375 RVA: 0x00A21DAE File Offset: 0x00A1FFAE
		public SReplaceEffect(TSoftObjectPtr<UObject> OldEffect, TSoftObjectPtr<UObject> NewEffect)
		{
			this.OldEffect = OldEffect;
			this.NewEffect = NewEffect;
		}

		// Token: 0x0602C868 RID: 182376 RVA: 0x00A21DC4 File Offset: 0x00A1FFC4
		protected override IntPtr GetUStructPtr()
		{
			return SReplaceEffect.StaticStruct();
		}

		// Token: 0x0602C869 RID: 182377 RVA: 0x00A21DD0 File Offset: 0x00A1FFD0
		[NullableContext(2)]
		public SReplaceEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C86A RID: 182378 RVA: 0x00A21DDA File Offset: 0x00A1FFDA
		public SReplaceEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C86B RID: 182379 RVA: 0x00A21DE5 File Offset: 0x00A1FFE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReplaceEffect(Pointer, false, true);
		}

		// Token: 0x0602C86C RID: 182380 RVA: 0x00A21DEF File Offset: 0x00A1FFEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReplaceEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04017788 RID: 96136
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect";

		// Token: 0x04017789 RID: 96137
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401778A RID: 96138
		internal static int __PropertyOffset_0;

		// Token: 0x0401778B RID: 96139
		internal static int __PropertyOffset_1;
	}
}
