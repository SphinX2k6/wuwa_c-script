using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.ItemInspect
{
	// Token: 0x020031CC RID: 12748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_ItemInspectGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F961 RID: 129377 RVA: 0x00930EC3 File Offset: 0x0092F0C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ItemInspectGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C");
			}
			return BP_ItemInspectGlobalConfig_C._ClassPtr;
		}

		// Token: 0x0601F962 RID: 129378 RVA: 0x00930EE8 File Offset: 0x0092F0E8
		public BP_ItemInspectGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_ItemInspectGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F963 RID: 129379 RVA: 0x00930F10 File Offset: 0x0092F110
		public BP_ItemInspectGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ItemInspectGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0601F964 RID: 129380 RVA: 0x00930F43 File Offset: 0x0092F143
		// (set) Token: 0x0601F965 RID: 129381 RVA: 0x00930F53 File Offset: 0x0092F153
		public unsafe float 输入速度限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_输入速度限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_输入速度限制) = value;
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0601F966 RID: 129382 RVA: 0x00930F64 File Offset: 0x0092F164
		// (set) Token: 0x0601F967 RID: 129383 RVA: 0x00930F74 File Offset: 0x0092F174
		public unsafe float 平滑插值旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_平滑插值旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_平滑插值旋转速度) = value;
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0601F968 RID: 129384 RVA: 0x00930F85 File Offset: 0x0092F185
		// (set) Token: 0x0601F969 RID: 129385 RVA: 0x00930F95 File Offset: 0x0092F195
		public unsafe float 重置旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_重置旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_重置旋转速度) = value;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0601F96A RID: 129386 RVA: 0x00930FA6 File Offset: 0x0092F1A6
		// (set) Token: 0x0601F96B RID: 129387 RVA: 0x00930FBB File Offset: 0x0092F1BB
		public TSoftObjectPtr<UStaticMesh> 压暗网格体
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗网格体, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗网格体, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0601F96C RID: 129388 RVA: 0x00930FE0 File Offset: 0x0092F1E0
		// (set) Token: 0x0601F96D RID: 129389 RVA: 0x00930FF5 File Offset: 0x0092F1F5
		public TSoftObjectPtr<UMaterialInstance> 压暗材质
		{
			get
			{
				return new TSoftObjectPtr<UMaterialInstance>(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗材质, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗材质, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0601F96E RID: 129390 RVA: 0x0093101A File Offset: 0x0092F21A
		// (set) Token: 0x0601F96F RID: 129391 RVA: 0x0093102A File Offset: 0x0092F22A
		public unsafe float 压暗不透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗不透明度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗不透明度) = value;
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0601F970 RID: 129392 RVA: 0x0093103B File Offset: 0x0092F23B
		// (set) Token: 0x0601F971 RID: 129393 RVA: 0x0093104B File Offset: 0x0092F24B
		public unsafe float 压暗过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗过渡时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗过渡时间) = value;
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0601F972 RID: 129394 RVA: 0x0093105C File Offset: 0x0092F25C
		// (set) Token: 0x0601F973 RID: 129395 RVA: 0x0093106C File Offset: 0x0092F26C
		public unsafe float 压暗过渡间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗过渡间隔);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗过渡间隔) = value;
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0601F974 RID: 129396 RVA: 0x0093107D File Offset: 0x0092F27D
		// (set) Token: 0x0601F975 RID: 129397 RVA: 0x0093108D File Offset: 0x0092F28D
		public unsafe float 压暗屏幕深度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗屏幕深度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ItemInspectGlobalConfig_C.__PropertyOffset_压暗屏幕深度) = value;
			}
		}

		// Token: 0x0601F976 RID: 129398 RVA: 0x0093109E File Offset: 0x0092F29E
		protected BP_ItemInspectGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F18 RID: 69400
		public new const string __ObjectPath = "/Game/Aki/Data/Level/ItemInspect/BP_ItemInspectGlobalConfig.BP_ItemInspectGlobalConfig_C";

		// Token: 0x04010F19 RID: 69401
		private static IntPtr _ClassPtr;

		// Token: 0x04010F1A RID: 69402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F1B RID: 69403
		internal static int __PropertyOffset_输入速度限制;

		// Token: 0x04010F1C RID: 69404
		internal static int __PropertyOffset_平滑插值旋转速度;

		// Token: 0x04010F1D RID: 69405
		internal static int __PropertyOffset_重置旋转速度;

		// Token: 0x04010F1E RID: 69406
		internal static int __PropertyOffset_压暗网格体;

		// Token: 0x04010F1F RID: 69407
		internal static int __PropertyOffset_压暗材质;

		// Token: 0x04010F20 RID: 69408
		internal static int __PropertyOffset_压暗不透明度;

		// Token: 0x04010F21 RID: 69409
		internal static int __PropertyOffset_压暗过渡时间;

		// Token: 0x04010F22 RID: 69410
		internal static int __PropertyOffset_压暗过渡间隔;

		// Token: 0x04010F23 RID: 69411
		internal static int __PropertyOffset_压暗屏幕深度;
	}
}
