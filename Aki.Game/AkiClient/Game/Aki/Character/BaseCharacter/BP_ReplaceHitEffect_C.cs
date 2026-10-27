using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004283 RID: 17027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class BP_ReplaceHitEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C360 RID: 181088 RVA: 0x00A1A18B File Offset: 0x00A1838B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ReplaceHitEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C");
			}
			return BP_ReplaceHitEffect_C._ClassPtr;
		}

		// Token: 0x0602C361 RID: 181089 RVA: 0x00A1A1B0 File Offset: 0x00A183B0
		public BP_ReplaceHitEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_ReplaceHitEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C362 RID: 181090 RVA: 0x00A1A1D8 File Offset: 0x00A183D8
		public BP_ReplaceHitEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ReplaceHitEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E2E RID: 28206
		// (get) Token: 0x0602C363 RID: 181091 RVA: 0x00A1A20B File Offset: 0x00A1840B
		// (set) Token: 0x0602C364 RID: 181092 RVA: 0x00A1A220 File Offset: 0x00A18420
		public TSoftClassPtr<UKuroCameraShake> 震屏
		{
			get
			{
				return new TSoftClassPtr<UKuroCameraShake>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x0602C365 RID: 181093 RVA: 0x00A1A245 File Offset: 0x00A18445
		// (set) Token: 0x0602C366 RID: 181094 RVA: 0x00A1A25A File Offset: 0x00A1845A
		public TSoftObjectPtr<UEffectModelBase> 受击特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x0602C367 RID: 181095 RVA: 0x00A1A27F File Offset: 0x00A1847F
		// (set) Token: 0x0602C368 RID: 181096 RVA: 0x00A1A294 File Offset: 0x00A18494
		public TSoftObjectPtr<EffectModelAudio> 受击音效
		{
			get
			{
				return new TSoftObjectPtr<EffectModelAudio>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_2, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x0602C369 RID: 181097 RVA: 0x00A1A2B9 File Offset: 0x00A184B9
		// (set) Token: 0x0602C36A RID: 181098 RVA: 0x00A1A2CE File Offset: 0x00A184CE
		public TSoftObjectPtr<UEffectModelBase> 命中特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_3, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x0602C36B RID: 181099 RVA: 0x00A1A2F3 File Offset: 0x00A184F3
		// (set) Token: 0x0602C36C RID: 181100 RVA: 0x00A1A303 File Offset: 0x00A18503
		public unsafe bool 替换近战子弹顿帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x0602C36D RID: 181101 RVA: 0x00A1A314 File Offset: 0x00A18514
		// (set) Token: 0x0602C36E RID: 181102 RVA: 0x00A1A34D File Offset: 0x00A1854D
		public STimeScale 顿帧
		{
			get
			{
				base.FastCheckIsValid();
				STimeScale result;
				if ((result = this._顿帧) == null)
				{
					result = (this._顿帧 = new STimeScale(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x0602C36F RID: 181103 RVA: 0x00A1A370 File Offset: 0x00A18570
		// (set) Token: 0x0602C370 RID: 181104 RVA: 0x00A1A3A9 File Offset: 0x00A185A9
		public TArray<FName> 不替换的部位
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._不替换的部位) == null)
				{
					result = (this._不替换的部位 = new TArray<FName>(base.NativePtr + (IntPtr)BP_ReplaceHitEffect_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.不替换的部位.CopyAssign(value);
			}
		}

		// Token: 0x0602C371 RID: 181105 RVA: 0x00A1A3B7 File Offset: 0x00A185B7
		protected BP_ReplaceHitEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017246 RID: 94790
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_ReplaceHitEffect.BP_ReplaceHitEffect_C";

		// Token: 0x04017247 RID: 94791
		private static IntPtr _ClassPtr;

		// Token: 0x04017248 RID: 94792
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017249 RID: 94793
		internal static int __PropertyOffset_0;

		// Token: 0x0401724A RID: 94794
		internal static int __PropertyOffset_1;

		// Token: 0x0401724B RID: 94795
		internal static int __PropertyOffset_2;

		// Token: 0x0401724C RID: 94796
		internal static int __PropertyOffset_3;

		// Token: 0x0401724D RID: 94797
		internal static int __PropertyOffset_4;

		// Token: 0x0401724E RID: 94798
		internal static int __PropertyOffset_5;

		// Token: 0x0401724F RID: 94799
		[Nullable(2)]
		private STimeScale _顿帧;

		// Token: 0x04017250 RID: 94800
		internal static int __PropertyOffset_6;

		// Token: 0x04017251 RID: 94801
		[Nullable(2)]
		private TArray<FName> _不替换的部位;
	}
}
