using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Ski
{
	// Token: 0x020031C3 RID: 12739
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_SkiConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F810 RID: 129040 RVA: 0x0092F41E File Offset: 0x0092D61E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SkiConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C");
			}
			return BP_SkiConfig_C._ClassPtr;
		}

		// Token: 0x0601F811 RID: 129041 RVA: 0x0092F444 File Offset: 0x0092D644
		public BP_SkiConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SkiConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F812 RID: 129042 RVA: 0x0092F46C File Offset: 0x0092D66C
		public BP_SkiConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SkiConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0601F813 RID: 129043 RVA: 0x0092F49F File Offset: 0x0092D69F
		// (set) Token: 0x0601F814 RID: 129044 RVA: 0x0092F4AF File Offset: 0x0092D6AF
		public unsafe float 初始速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_初始速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_初始速度) = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0601F815 RID: 129045 RVA: 0x0092F4C0 File Offset: 0x0092D6C0
		// (set) Token: 0x0601F816 RID: 129046 RVA: 0x0092F4D0 File Offset: 0x0092D6D0
		public unsafe float 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_转向速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_转向速度) = value;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0601F817 RID: 129047 RVA: 0x0092F4E1 File Offset: 0x0092D6E1
		// (set) Token: 0x0601F818 RID: 129048 RVA: 0x0092F4F1 File Offset: 0x0092D6F1
		public unsafe float 基础加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础加速度) = value;
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0601F819 RID: 129049 RVA: 0x0092F502 File Offset: 0x0092D702
		// (set) Token: 0x0601F81A RID: 129050 RVA: 0x0092F512 File Offset: 0x0092D712
		public unsafe float 基础减速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础减速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础减速度) = value;
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0601F81B RID: 129051 RVA: 0x0092F523 File Offset: 0x0092D723
		// (set) Token: 0x0601F81C RID: 129052 RVA: 0x0092F533 File Offset: 0x0092D733
		public unsafe float 基础目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_基础目标速度) = value;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0601F81D RID: 129053 RVA: 0x0092F544 File Offset: 0x0092D744
		// (set) Token: 0x0601F81E RID: 129054 RVA: 0x0092F554 File Offset: 0x0092D754
		public unsafe float 斜坡额外加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_斜坡额外加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_斜坡额外加速度) = value;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0601F81F RID: 129055 RVA: 0x0092F565 File Offset: 0x0092D765
		// (set) Token: 0x0601F820 RID: 129056 RVA: 0x0092F575 File Offset: 0x0092D775
		public unsafe float 斜坡额外目标速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_斜坡额外目标速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_斜坡额外目标速度) = value;
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0601F821 RID: 129057 RVA: 0x0092F586 File Offset: 0x0092D786
		// (set) Token: 0x0601F822 RID: 129058 RVA: 0x0092F596 File Offset: 0x0092D796
		public unsafe float 忽视阶梯高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_忽视阶梯高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_忽视阶梯高度) = value;
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0601F823 RID: 129059 RVA: 0x0092F5A7 File Offset: 0x0092D7A7
		// (set) Token: 0x0601F824 RID: 129060 RVA: 0x0092F5B7 File Offset: 0x0092D7B7
		public unsafe float 跳跃转向速度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃转向速度系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃转向速度系数) = value;
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x0601F825 RID: 129061 RVA: 0x0092F5C8 File Offset: 0x0092D7C8
		// (set) Token: 0x0601F826 RID: 129062 RVA: 0x0092F5D8 File Offset: 0x0092D7D8
		public unsafe float 跳跃滞空缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃滞空缩放系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃滞空缩放系数) = value;
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0601F827 RID: 129063 RVA: 0x0092F5E9 File Offset: 0x0092D7E9
		// (set) Token: 0x0601F828 RID: 129064 RVA: 0x0092F5F9 File Offset: 0x0092D7F9
		public unsafe float 跳跃高度缩放系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃高度缩放系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃高度缩放系数) = value;
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0601F829 RID: 129065 RVA: 0x0092F60A File Offset: 0x0092D80A
		// (set) Token: 0x0601F82A RID: 129066 RVA: 0x0092F61A File Offset: 0x0092D81A
		public unsafe float 跳跃下落最大平面速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃下落最大平面速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_跳跃下落最大平面速度) = value;
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0601F82B RID: 129067 RVA: 0x0092F62C File Offset: 0x0092D82C
		// (set) Token: 0x0601F82C RID: 129068 RVA: 0x0092F665 File Offset: 0x0092D865
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_期间Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_SkiConfig_C.__PropertyOffset_期间Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F82D RID: 129069 RVA: 0x0092F686 File Offset: 0x0092D886
		protected BP_SkiConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E5D RID: 69213
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Ski/BP_SkiConfig.BP_SkiConfig_C";

		// Token: 0x04010E5E RID: 69214
		private static IntPtr _ClassPtr;

		// Token: 0x04010E5F RID: 69215
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E60 RID: 69216
		internal static int __PropertyOffset_初始速度;

		// Token: 0x04010E61 RID: 69217
		internal static int __PropertyOffset_转向速度;

		// Token: 0x04010E62 RID: 69218
		internal static int __PropertyOffset_基础加速度;

		// Token: 0x04010E63 RID: 69219
		internal static int __PropertyOffset_基础减速度;

		// Token: 0x04010E64 RID: 69220
		internal static int __PropertyOffset_基础目标速度;

		// Token: 0x04010E65 RID: 69221
		internal static int __PropertyOffset_斜坡额外加速度;

		// Token: 0x04010E66 RID: 69222
		internal static int __PropertyOffset_斜坡额外目标速度;

		// Token: 0x04010E67 RID: 69223
		internal static int __PropertyOffset_忽视阶梯高度;

		// Token: 0x04010E68 RID: 69224
		internal static int __PropertyOffset_跳跃转向速度系数;

		// Token: 0x04010E69 RID: 69225
		internal static int __PropertyOffset_跳跃滞空缩放系数;

		// Token: 0x04010E6A RID: 69226
		internal static int __PropertyOffset_跳跃高度缩放系数;

		// Token: 0x04010E6B RID: 69227
		internal static int __PropertyOffset_跳跃下落最大平面速度;

		// Token: 0x04010E6C RID: 69228
		internal static int __PropertyOffset_期间Tag;

		// Token: 0x04010E6D RID: 69229
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;
	}
}
