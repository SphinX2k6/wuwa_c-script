using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Kpose.Blueprint
{
	// Token: 0x02004257 RID: 16983
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Kpose/Blueprint/SKposeEffect.SKposeEffect")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SKposeEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C02F RID: 180271 RVA: 0x00A11C74 File Offset: 0x00A0FE74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SKposeEffect._ScriptStructPtr != 0) ? SKposeEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Kpose/Blueprint/SKposeEffect.SKposeEffect", ref SKposeEffect._ScriptStructPtr);
		}

		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x0602C030 RID: 180272 RVA: 0x00A11C98 File Offset: 0x00A0FE98
		// (set) Token: 0x0602C031 RID: 180273 RVA: 0x00A11CB7 File Offset: 0x00A0FEB7
		public TSoftObjectPtr<UEffectModelBase> EffectData
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x0602C032 RID: 180274 RVA: 0x00A11CDC File Offset: 0x00A0FEDC
		// (set) Token: 0x0602C033 RID: 180275 RVA: 0x00A11CEC File Offset: 0x00A0FEEC
		public unsafe bool Attach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D53 RID: 27987
		// (get) Token: 0x0602C034 RID: 180276 RVA: 0x00A11CFD File Offset: 0x00A0FEFD
		// (set) Token: 0x0602C035 RID: 180277 RVA: 0x00A11D11 File Offset: 0x00A0FF11
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006D54 RID: 27988
		// (get) Token: 0x0602C036 RID: 180278 RVA: 0x00A11D26 File Offset: 0x00A0FF26
		// (set) Token: 0x0602C037 RID: 180279 RVA: 0x00A11D3A File Offset: 0x00A0FF3A
		public unsafe FName SkeletalTag_Optional_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006D55 RID: 27989
		// (get) Token: 0x0602C038 RID: 180280 RVA: 0x00A11D4F File Offset: 0x00A0FF4F
		// (set) Token: 0x0602C039 RID: 180281 RVA: 0x00A11D63 File Offset: 0x00A0FF63
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SKposeEffect.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602C03A RID: 180282 RVA: 0x00A11D78 File Offset: 0x00A0FF78
		public SKposeEffect()
		{
		}

		// Token: 0x0602C03B RID: 180283 RVA: 0x00A11D80 File Offset: 0x00A0FF80
		public SKposeEffect(TSoftObjectPtr<UEffectModelBase> EffectData, bool Attach, FName AttachSocketName, FName SkeletalTag_Optional_, FTransform Transform)
		{
			this.EffectData = EffectData;
			this.Attach = Attach;
			this.AttachSocketName = AttachSocketName;
			this.SkeletalTag_Optional_ = SkeletalTag_Optional_;
			this.Transform = Transform;
		}

		// Token: 0x0602C03C RID: 180284 RVA: 0x00A11DAD File Offset: 0x00A0FFAD
		protected override IntPtr GetUStructPtr()
		{
			return SKposeEffect.StaticStruct();
		}

		// Token: 0x0602C03D RID: 180285 RVA: 0x00A11DB9 File Offset: 0x00A0FFB9
		[NullableContext(2)]
		public SKposeEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C03E RID: 180286 RVA: 0x00A11DC3 File Offset: 0x00A0FFC3
		public SKposeEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C03F RID: 180287 RVA: 0x00A11DCE File Offset: 0x00A0FFCE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SKposeEffect(Pointer, false, true);
		}

		// Token: 0x0602C040 RID: 180288 RVA: 0x00A11DD8 File Offset: 0x00A0FFD8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SKposeEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04016FDC RID: 94172
		public const string __ObjectPath = "/Game/Aki/Character/Kpose/Blueprint/SKposeEffect.SKposeEffect";

		// Token: 0x04016FDD RID: 94173
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016FDE RID: 94174
		internal static int __PropertyOffset_0;

		// Token: 0x04016FDF RID: 94175
		internal static int __PropertyOffset_1;

		// Token: 0x04016FE0 RID: 94176
		internal static int __PropertyOffset_2;

		// Token: 0x04016FE1 RID: 94177
		internal static int __PropertyOffset_3;

		// Token: 0x04016FE2 RID: 94178
		internal static int __PropertyOffset_4;
	}
}
