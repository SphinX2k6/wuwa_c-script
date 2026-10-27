using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.SplineClimb
{
	// Token: 0x02003F06 RID: 16134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class BP_SplineClimbConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E69 RID: 167529 RVA: 0x009B7258 File Offset: 0x009B5458
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineClimbConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C");
			}
			return BP_SplineClimbConfig_C._ClassPtr;
		}

		// Token: 0x06028E6A RID: 167530 RVA: 0x009B727C File Offset: 0x009B547C
		public BP_SplineClimbConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineClimbConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E6B RID: 167531 RVA: 0x009B72A4 File Offset: 0x009B54A4
		public BP_SplineClimbConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineClimbConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700603A RID: 24634
		// (get) Token: 0x06028E6C RID: 167532 RVA: 0x009B72D8 File Offset: 0x009B54D8
		// (set) Token: 0x06028E6D RID: 167533 RVA: 0x009B7311 File Offset: 0x009B5511
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700603B RID: 24635
		// (get) Token: 0x06028E6E RID: 167534 RVA: 0x009B7334 File Offset: 0x009B5534
		// (set) Token: 0x06028E6F RID: 167535 RVA: 0x009B736D File Offset: 0x009B556D
		public TArray<int> 打断技能
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._打断技能) == null)
				{
					result = (this._打断技能 = new TArray<int>(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.打断技能.CopyAssign(value);
			}
		}

		// Token: 0x1700603C RID: 24636
		// (get) Token: 0x06028E70 RID: 167536 RVA: 0x009B737B File Offset: 0x009B557B
		// (set) Token: 0x06028E71 RID: 167537 RVA: 0x009B738B File Offset: 0x009B558B
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x06028E72 RID: 167538 RVA: 0x009B739C File Offset: 0x009B559C
		// (set) Token: 0x06028E73 RID: 167539 RVA: 0x009B73AC File Offset: 0x009B55AC
		public unsafe float 采样长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x06028E74 RID: 167540 RVA: 0x009B73BD File Offset: 0x009B55BD
		// (set) Token: 0x06028E75 RID: 167541 RVA: 0x009B73CD File Offset: 0x009B55CD
		public unsafe float 采样间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x06028E76 RID: 167542 RVA: 0x009B73DE File Offset: 0x009B55DE
		// (set) Token: 0x06028E77 RID: 167543 RVA: 0x009B73EE File Offset: 0x009B55EE
		public unsafe float 检测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x06028E78 RID: 167544 RVA: 0x009B73FF File Offset: 0x009B55FF
		// (set) Token: 0x06028E79 RID: 167545 RVA: 0x009B740F File Offset: 0x009B560F
		public unsafe float 检测起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x06028E7A RID: 167546 RVA: 0x009B7420 File Offset: 0x009B5620
		// (set) Token: 0x06028E7B RID: 167547 RVA: 0x009B7430 File Offset: 0x009B5630
		public unsafe float 离墙额外距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06028E7C RID: 167548 RVA: 0x009B7441 File Offset: 0x009B5641
		protected BP_SplineClimbConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014EB0 RID: 85680
		public new const string __ObjectPath = "/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C";

		// Token: 0x04014EB1 RID: 85681
		private static IntPtr _ClassPtr;

		// Token: 0x04014EB2 RID: 85682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014EB3 RID: 85683
		internal static int __PropertyOffset_0;

		// Token: 0x04014EB4 RID: 85684
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;

		// Token: 0x04014EB5 RID: 85685
		internal static int __PropertyOffset_1;

		// Token: 0x04014EB6 RID: 85686
		[Nullable(2)]
		private TArray<int> _打断技能;

		// Token: 0x04014EB7 RID: 85687
		internal static int __PropertyOffset_2;

		// Token: 0x04014EB8 RID: 85688
		internal static int __PropertyOffset_3;

		// Token: 0x04014EB9 RID: 85689
		internal static int __PropertyOffset_4;

		// Token: 0x04014EBA RID: 85690
		internal static int __PropertyOffset_5;

		// Token: 0x04014EBB RID: 85691
		internal static int __PropertyOffset_6;

		// Token: 0x04014EBC RID: 85692
		internal static int __PropertyOffset_7;
	}
}
