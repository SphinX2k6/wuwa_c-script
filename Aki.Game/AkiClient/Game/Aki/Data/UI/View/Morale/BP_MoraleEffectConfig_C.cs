using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UI.View.Morale
{
	// Token: 0x02003E84 RID: 16004
	[UnrealObjectPath("/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class BP_MoraleEffectConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028675 RID: 165493 RVA: 0x009AB9F0 File Offset: 0x009A9BF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MoraleEffectConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C");
			}
			return BP_MoraleEffectConfig_C._ClassPtr;
		}

		// Token: 0x06028676 RID: 165494 RVA: 0x009ABA14 File Offset: 0x009A9C14
		public BP_MoraleEffectConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MoraleEffectConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028677 RID: 165495 RVA: 0x009ABA3C File Offset: 0x009A9C3C
		[NullableContext(1)]
		public BP_MoraleEffectConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MoraleEffectConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x06028678 RID: 165496 RVA: 0x009ABA6F File Offset: 0x009A9C6F
		// (set) Token: 0x06028679 RID: 165497 RVA: 0x009ABA7F File Offset: 0x009A9C7F
		public unsafe int 格子入场批次
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x0602867A RID: 165498 RVA: 0x009ABA90 File Offset: 0x009A9C90
		// (set) Token: 0x0602867B RID: 165499 RVA: 0x009ABAA0 File Offset: 0x009A9CA0
		public unsafe int 格子入场批次间隔时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x0602867C RID: 165500 RVA: 0x009ABAB1 File Offset: 0x009A9CB1
		// (set) Token: 0x0602867D RID: 165501 RVA: 0x009ABAC5 File Offset: 0x009A9CC5
		[Nullable(2)]
		public unsafe UCurveFloat 格子入场曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoraleEffectConfig_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoraleEffectConfig_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x0602867E RID: 165502 RVA: 0x009ABADA File Offset: 0x009A9CDA
		// (set) Token: 0x0602867F RID: 165503 RVA: 0x009ABAEA File Offset: 0x009A9CEA
		public unsafe int 解锁新格子播放前间隔时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x06028680 RID: 165504 RVA: 0x009ABAFB File Offset: 0x009A9CFB
		// (set) Token: 0x06028681 RID: 165505 RVA: 0x009ABB0B File Offset: 0x009A9D0B
		public unsafe int 解锁新格子播放所需时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06028682 RID: 165506 RVA: 0x009ABB1C File Offset: 0x009A9D1C
		protected BP_MoraleEffectConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014984 RID: 84356
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C";

		// Token: 0x04014985 RID: 84357
		private static IntPtr _ClassPtr;

		// Token: 0x04014986 RID: 84358
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014987 RID: 84359
		internal static int __PropertyOffset_0;

		// Token: 0x04014988 RID: 84360
		internal static int __PropertyOffset_1;

		// Token: 0x04014989 RID: 84361
		internal static int __PropertyOffset_2;

		// Token: 0x0401498A RID: 84362
		internal static int __PropertyOffset_3;

		// Token: 0x0401498B RID: 84363
		internal static int __PropertyOffset_4;
	}
}
