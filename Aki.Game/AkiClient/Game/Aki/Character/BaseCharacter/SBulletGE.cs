using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FC RID: 17148
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletGE.SBulletGE")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SBulletGE : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C516 RID: 181526 RVA: 0x00A1CF6D File Offset: 0x00A1B16D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletGE._ScriptStructPtr != 0) ? SBulletGE._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletGE.SBulletGE", ref SBulletGE._ScriptStructPtr);
		}

		// Token: 0x17006EB3 RID: 28339
		// (get) Token: 0x0602C517 RID: 181527 RVA: 0x00A1CF91 File Offset: 0x00A1B191
		// (set) Token: 0x0602C518 RID: 181528 RVA: 0x00A1CFB0 File Offset: 0x00A1B1B0
		public TSoftClassPtr<UGameplayEffect> GE的类型
		{
			get
			{
				return new TSoftClassPtr<UGameplayEffect>(base.NativePtr + (IntPtr)SBulletGE.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SBulletGE.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006EB4 RID: 28340
		// (get) Token: 0x0602C519 RID: 181529 RVA: 0x00A1CFD8 File Offset: 0x00A1B1D8
		// (set) Token: 0x0602C51A RID: 181530 RVA: 0x00A1D01B File Offset: 0x00A1B21B
		public FKuroGameplayParameterContainer GE的参数
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGameplayParameterContainer result;
				if ((result = this._GE的参数) == null)
				{
					result = (this._GE的参数 = new FKuroGameplayParameterContainer(base.NativePtr + (IntPtr)SBulletGE.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGameplayParameterContainer.StaticStruct(), base.NativePtr + (IntPtr)SBulletGE.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C51B RID: 181531 RVA: 0x00A1D03C File Offset: 0x00A1B23C
		public SBulletGE()
		{
		}

		// Token: 0x0602C51C RID: 181532 RVA: 0x00A1D044 File Offset: 0x00A1B244
		public SBulletGE(TSoftClassPtr<UGameplayEffect> GE的类型, FKuroGameplayParameterContainer GE的参数)
		{
			this.GE的类型 = GE的类型;
			this.GE的参数 = GE的参数;
		}

		// Token: 0x0602C51D RID: 181533 RVA: 0x00A1D05A File Offset: 0x00A1B25A
		protected override IntPtr GetUStructPtr()
		{
			return SBulletGE.StaticStruct();
		}

		// Token: 0x0602C51E RID: 181534 RVA: 0x00A1D066 File Offset: 0x00A1B266
		[NullableContext(2)]
		public SBulletGE(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C51F RID: 181535 RVA: 0x00A1D070 File Offset: 0x00A1B270
		public SBulletGE(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C520 RID: 181536 RVA: 0x00A1D07B File Offset: 0x00A1B27B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletGE(Pointer, false, true);
		}

		// Token: 0x0602C521 RID: 181537 RVA: 0x00A1D085 File Offset: 0x00A1B285
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletGE(Pointer, MemoryOwner);
		}

		// Token: 0x040175E6 RID: 95718
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletGE.SBulletGE";

		// Token: 0x040175E7 RID: 95719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175E8 RID: 95720
		internal static int __PropertyOffset_0;

		// Token: 0x040175E9 RID: 95721
		internal static int __PropertyOffset_1;

		// Token: 0x040175EA RID: 95722
		[Nullable(2)]
		private FKuroGameplayParameterContainer _GE的参数;
	}
}
