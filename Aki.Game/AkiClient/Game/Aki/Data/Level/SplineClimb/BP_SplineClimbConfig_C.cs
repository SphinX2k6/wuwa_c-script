using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.SplineClimb
{
	// Token: 0x020031C2 RID: 12738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class BP_SplineClimbConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7FC RID: 129020 RVA: 0x0092F22C File Offset: 0x0092D42C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineClimbConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C");
			}
			return BP_SplineClimbConfig_C._ClassPtr;
		}

		// Token: 0x0601F7FD RID: 129021 RVA: 0x0092F250 File Offset: 0x0092D450
		public BP_SplineClimbConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineClimbConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7FE RID: 129022 RVA: 0x0092F278 File Offset: 0x0092D478
		public BP_SplineClimbConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineClimbConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0601F7FF RID: 129023 RVA: 0x0092F2AC File Offset: 0x0092D4AC
		// (set) Token: 0x0601F800 RID: 129024 RVA: 0x0092F2E5 File Offset: 0x0092D4E5
		public FGameplayTagContainer 期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._期间Tag) == null)
				{
					result = (this._期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_期间Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_期间Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0601F801 RID: 129025 RVA: 0x0092F308 File Offset: 0x0092D508
		// (set) Token: 0x0601F802 RID: 129026 RVA: 0x0092F341 File Offset: 0x0092D541
		public TArray<int> 打断技能
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._打断技能) == null)
				{
					result = (this._打断技能 = new TArray<int>(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_打断技能, this));
				}
				return result;
			}
			set
			{
				this.打断技能.CopyAssign(value);
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0601F803 RID: 129027 RVA: 0x0092F34F File Offset: 0x0092D54F
		// (set) Token: 0x0601F804 RID: 129028 RVA: 0x0092F35F File Offset: 0x0092D55F
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_DebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0601F805 RID: 129029 RVA: 0x0092F370 File Offset: 0x0092D570
		// (set) Token: 0x0601F806 RID: 129030 RVA: 0x0092F380 File Offset: 0x0092D580
		public unsafe float 采样长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_采样长度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_采样长度) = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0601F807 RID: 129031 RVA: 0x0092F391 File Offset: 0x0092D591
		// (set) Token: 0x0601F808 RID: 129032 RVA: 0x0092F3A1 File Offset: 0x0092D5A1
		public unsafe float 采样间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_采样间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_采样间隔) = value;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0601F809 RID: 129033 RVA: 0x0092F3B2 File Offset: 0x0092D5B2
		// (set) Token: 0x0601F80A RID: 129034 RVA: 0x0092F3C2 File Offset: 0x0092D5C2
		public unsafe float 检测距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_检测距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_检测距离) = value;
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0601F80B RID: 129035 RVA: 0x0092F3D3 File Offset: 0x0092D5D3
		// (set) Token: 0x0601F80C RID: 129036 RVA: 0x0092F3E3 File Offset: 0x0092D5E3
		public unsafe float 检测起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_检测起始偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_检测起始偏移) = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0601F80D RID: 129037 RVA: 0x0092F3F4 File Offset: 0x0092D5F4
		// (set) Token: 0x0601F80E RID: 129038 RVA: 0x0092F404 File Offset: 0x0092D604
		public unsafe float 离墙额外距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_离墙额外距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineClimbConfig_C.__PropertyOffset_离墙额外距离) = value;
			}
		}

		// Token: 0x0601F80F RID: 129039 RVA: 0x0092F415 File Offset: 0x0092D615
		protected BP_SplineClimbConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E50 RID: 69200
		public new const string __ObjectPath = "/Game/Aki/Data/Level/SplineClimb/BP_SplineClimbConfig.BP_SplineClimbConfig_C";

		// Token: 0x04010E51 RID: 69201
		private static IntPtr _ClassPtr;

		// Token: 0x04010E52 RID: 69202
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E53 RID: 69203
		internal static int __PropertyOffset_期间Tag;

		// Token: 0x04010E54 RID: 69204
		[Nullable(2)]
		private FGameplayTagContainer _期间Tag;

		// Token: 0x04010E55 RID: 69205
		internal static int __PropertyOffset_打断技能;

		// Token: 0x04010E56 RID: 69206
		[Nullable(2)]
		private TArray<int> _打断技能;

		// Token: 0x04010E57 RID: 69207
		internal static int __PropertyOffset_DebugDraw;

		// Token: 0x04010E58 RID: 69208
		internal static int __PropertyOffset_采样长度;

		// Token: 0x04010E59 RID: 69209
		internal static int __PropertyOffset_采样间隔;

		// Token: 0x04010E5A RID: 69210
		internal static int __PropertyOffset_检测距离;

		// Token: 0x04010E5B RID: 69211
		internal static int __PropertyOffset_检测起始偏移;

		// Token: 0x04010E5C RID: 69212
		internal static int __PropertyOffset_离墙额外距离;
	}
}
