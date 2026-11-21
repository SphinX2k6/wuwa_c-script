using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E5 RID: 13029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class BP_ReplaceHitEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060211AD RID: 135597 RVA: 0x00959473 File Offset: 0x00957673
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ReplaceHitEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C");
			}
			return BP_ReplaceHitEffect_C._ClassPtr;
		}

		// Token: 0x060211AE RID: 135598 RVA: 0x00959498 File Offset: 0x00957698
		public BP_ReplaceHitEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_ReplaceHitEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211AF RID: 135599 RVA: 0x009594C0 File Offset: 0x009576C0
		public BP_ReplaceHitEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ReplaceHitEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x060211B0 RID: 135600 RVA: 0x009594F3 File Offset: 0x009576F3
		// (set) Token: 0x060211B1 RID: 135601 RVA: 0x00959508 File Offset: 0x00957708
		public TSoftClassPtr<UKuroCameraShake> 震屏
		{
			get
			{
				return new TSoftClassPtr<UKuroCameraShake>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_震屏, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_震屏, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x060211B2 RID: 135602 RVA: 0x0095952D File Offset: 0x0095772D
		// (set) Token: 0x060211B3 RID: 135603 RVA: 0x00959542 File Offset: 0x00957742
		public TSoftObjectPtr<UEffectModelBase> 受击特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_受击特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_受击特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x060211B4 RID: 135604 RVA: 0x00959567 File Offset: 0x00957767
		// (set) Token: 0x060211B5 RID: 135605 RVA: 0x0095957C File Offset: 0x0095777C
		public TSoftObjectPtr<EffectModelAudio> 受击音效
		{
			get
			{
				return new TSoftObjectPtr<EffectModelAudio>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_受击音效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_受击音效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x060211B6 RID: 135606 RVA: 0x009595A1 File Offset: 0x009577A1
		// (set) Token: 0x060211B7 RID: 135607 RVA: 0x009595B6 File Offset: 0x009577B6
		public TSoftObjectPtr<UEffectModelBase> 命中特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_命中特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_命中特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x060211B8 RID: 135608 RVA: 0x009595DB File Offset: 0x009577DB
		// (set) Token: 0x060211B9 RID: 135609 RVA: 0x009595EB File Offset: 0x009577EB
		public unsafe bool 替换近战子弹顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_替换近战子弹顿帧) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_替换近战子弹顿帧) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x060211BA RID: 135610 RVA: 0x009595FC File Offset: 0x009577FC
		// (set) Token: 0x060211BB RID: 135611 RVA: 0x00959635 File Offset: 0x00957835
		public STimeScale 顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._顿帧) == null)
				{
					result = (this._顿帧 = new STimeScale(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_顿帧, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_顿帧, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x060211BC RID: 135612 RVA: 0x00959658 File Offset: 0x00957858
		// (set) Token: 0x060211BD RID: 135613 RVA: 0x00959691 File Offset: 0x00957891
		public TArray<FName> 不替换的部位
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._不替换的部位) == null)
				{
					result = (this._不替换的部位 = new TArray<FName>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_不替换的部位, this));
				}
				return result;
			}
			set
			{
				this.不替换的部位.CopyAssign(value);
			}
		}

		// Token: 0x060211BE RID: 135614 RVA: 0x0095969F File Offset: 0x0095789F
		protected BP_ReplaceHitEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F6D RID: 73581
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C";

		// Token: 0x04011F6E RID: 73582
		private static IntPtr _ClassPtr;

		// Token: 0x04011F6F RID: 73583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F70 RID: 73584
		internal static int __PropertyOffset_震屏;

		// Token: 0x04011F71 RID: 73585
		internal static int __PropertyOffset_受击特效;

		// Token: 0x04011F72 RID: 73586
		internal static int __PropertyOffset_受击音效;

		// Token: 0x04011F73 RID: 73587
		internal static int __PropertyOffset_命中特效;

		// Token: 0x04011F74 RID: 73588
		internal static int __PropertyOffset_替换近战子弹顿帧;

		// Token: 0x04011F75 RID: 73589
		internal static int __PropertyOffset_顿帧;

		// Token: 0x04011F76 RID: 73590
		[Nullable(2)]
		private STimeScale _顿帧;

		// Token: 0x04011F77 RID: 73591
		internal static int __PropertyOffset_不替换的部位;

		// Token: 0x04011F78 RID: 73592
		[Nullable(2)]
		private TArray<FName> _不替换的部位;
	}
}
