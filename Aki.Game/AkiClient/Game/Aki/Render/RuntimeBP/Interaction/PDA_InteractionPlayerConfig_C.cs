using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F4 RID: 12532
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class PDA_InteractionPlayerConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E70E RID: 124686 RVA: 0x00914175 File Offset: 0x00912375
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_InteractionPlayerConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C");
			}
			return PDA_InteractionPlayerConfig_C._ClassPtr;
		}

		// Token: 0x0601E70F RID: 124687 RVA: 0x0091419C File Offset: 0x0091239C
		public PDA_InteractionPlayerConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionPlayerConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E710 RID: 124688 RVA: 0x009141C4 File Offset: 0x009123C4
		[NullableContext(1)]
		public PDA_InteractionPlayerConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionPlayerConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0601E711 RID: 124689 RVA: 0x009141F7 File Offset: 0x009123F7
		// (set) Token: 0x0601E712 RID: 124690 RVA: 0x00914207 File Offset: 0x00912407
		public unsafe bool 启用植被交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用植被交互) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用植被交互) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0601E713 RID: 124691 RVA: 0x00914218 File Offset: 0x00912418
		// (set) Token: 0x0601E714 RID: 124692 RVA: 0x00914228 File Offset: 0x00912428
		public unsafe float 植被交互半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_植被交互半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_植被交互半径) = value;
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0601E715 RID: 124693 RVA: 0x00914239 File Offset: 0x00912439
		// (set) Token: 0x0601E716 RID: 124694 RVA: 0x00914249 File Offset: 0x00912449
		public unsafe bool 启用水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用水面交互) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用水面交互) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0601E717 RID: 124695 RVA: 0x0091425A File Offset: 0x0091245A
		// (set) Token: 0x0601E718 RID: 124696 RVA: 0x0091426E File Offset: 0x0091246E
		[Nullable(2)]
		public unsafe PDA_WaterEffectConfigs_C 水特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WaterEffectConfigs_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_水特效);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_水特效, value);
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0601E719 RID: 124697 RVA: 0x00914283 File Offset: 0x00912483
		// (set) Token: 0x0601E71A RID: 124698 RVA: 0x00914293 File Offset: 0x00912493
		public unsafe float 射线向下延长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_射线向下延长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_射线向下延长) = value;
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0601E71B RID: 124699 RVA: 0x009142A4 File Offset: 0x009124A4
		// (set) Token: 0x0601E71C RID: 124700 RVA: 0x009142B4 File Offset: 0x009124B4
		public unsafe bool 自动草集群
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_自动草集群) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_自动草集群) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0601E71D RID: 124701 RVA: 0x009142C5 File Offset: 0x009124C5
		// (set) Token: 0x0601E71E RID: 124702 RVA: 0x009142D5 File Offset: 0x009124D5
		public unsafe bool 启用简易水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用简易水面交互) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_启用简易水面交互) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0601E71F RID: 124703 RVA: 0x009142E6 File Offset: 0x009124E6
		// (set) Token: 0x0601E720 RID: 124704 RVA: 0x009142FA File Offset: 0x009124FA
		public unsafe FVector 植被交互相对位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_植被交互相对位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_植被交互相对位置) = value;
			}
		}

		// Token: 0x0601E721 RID: 124705 RVA: 0x0091430F File Offset: 0x0091250F
		protected PDA_InteractionPlayerConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010201 RID: 66049
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C";

		// Token: 0x04010202 RID: 66050
		private static IntPtr _ClassPtr;

		// Token: 0x04010203 RID: 66051
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010204 RID: 66052
		internal static int __PropertyOffset_启用植被交互;

		// Token: 0x04010205 RID: 66053
		internal static int __PropertyOffset_植被交互半径;

		// Token: 0x04010206 RID: 66054
		internal static int __PropertyOffset_启用水面交互;

		// Token: 0x04010207 RID: 66055
		internal static int __PropertyOffset_水特效;

		// Token: 0x04010208 RID: 66056
		internal static int __PropertyOffset_射线向下延长;

		// Token: 0x04010209 RID: 66057
		internal static int __PropertyOffset_自动草集群;

		// Token: 0x0401020A RID: 66058
		internal static int __PropertyOffset_启用简易水面交互;

		// Token: 0x0401020B RID: 66059
		internal static int __PropertyOffset_植被交互相对位置;
	}
}
