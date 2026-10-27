using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D21 RID: 15649
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class PDA_InteractionPlayerConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025961 RID: 153953 RVA: 0x0095DDB9 File Offset: 0x0095BFB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_InteractionPlayerConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C");
			}
			return PDA_InteractionPlayerConfig_C._ClassPtr;
		}

		// Token: 0x06025962 RID: 153954 RVA: 0x0095DDE0 File Offset: 0x0095BFE0
		public PDA_InteractionPlayerConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionPlayerConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025963 RID: 153955 RVA: 0x0095DE08 File Offset: 0x0095C008
		[NullableContext(1)]
		public PDA_InteractionPlayerConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_InteractionPlayerConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x06025964 RID: 153956 RVA: 0x0095DE3B File Offset: 0x0095C03B
		// (set) Token: 0x06025965 RID: 153957 RVA: 0x0095DE4B File Offset: 0x0095C04B
		public unsafe bool 启用植被交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x06025966 RID: 153958 RVA: 0x0095DE5C File Offset: 0x0095C05C
		// (set) Token: 0x06025967 RID: 153959 RVA: 0x0095DE6C File Offset: 0x0095C06C
		public unsafe float 植被交互半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x06025968 RID: 153960 RVA: 0x0095DE7D File Offset: 0x0095C07D
		// (set) Token: 0x06025969 RID: 153961 RVA: 0x0095DE8D File Offset: 0x0095C08D
		public unsafe bool 启用水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x0602596A RID: 153962 RVA: 0x0095DE9E File Offset: 0x0095C09E
		// (set) Token: 0x0602596B RID: 153963 RVA: 0x0095DEB2 File Offset: 0x0095C0B2
		public unsafe PDA_WaterEffectConfigs_C 水特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_WaterEffectConfigs_C>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x0602596C RID: 153964 RVA: 0x0095DEC7 File Offset: 0x0095C0C7
		// (set) Token: 0x0602596D RID: 153965 RVA: 0x0095DED7 File Offset: 0x0095C0D7
		public unsafe float 射线向下延长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x0602596E RID: 153966 RVA: 0x0095DEE8 File Offset: 0x0095C0E8
		// (set) Token: 0x0602596F RID: 153967 RVA: 0x0095DEF8 File Offset: 0x0095C0F8
		public unsafe bool 自动草集群
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D7A RID: 19834
		// (get) Token: 0x06025970 RID: 153968 RVA: 0x0095DF09 File Offset: 0x0095C109
		// (set) Token: 0x06025971 RID: 153969 RVA: 0x0095DF1D File Offset: 0x0095C11D
		public unsafe UClusteredStuffDataAsset 草集群特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClusteredStuffDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_InteractionPlayerConfig_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004D7B RID: 19835
		// (get) Token: 0x06025972 RID: 153970 RVA: 0x0095DF32 File Offset: 0x0095C132
		// (set) Token: 0x06025973 RID: 153971 RVA: 0x0095DF42 File Offset: 0x0095C142
		public unsafe bool 启用简易水面交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06025974 RID: 153972 RVA: 0x0095DF53 File Offset: 0x0095C153
		// (set) Token: 0x06025975 RID: 153973 RVA: 0x0095DF67 File Offset: 0x0095C167
		public unsafe FVector 植被交互相对位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_InteractionPlayerConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06025976 RID: 153974 RVA: 0x0095DF7C File Offset: 0x0095C17C
		protected PDA_InteractionPlayerConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012C4B RID: 76875
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/PDA_InteractionPlayerConfig.PDA_InteractionPlayerConfig_C";

		// Token: 0x04012C4C RID: 76876
		private static IntPtr _ClassPtr;

		// Token: 0x04012C4D RID: 76877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012C4E RID: 76878
		internal static int __PropertyOffset_0;

		// Token: 0x04012C4F RID: 76879
		internal static int __PropertyOffset_1;

		// Token: 0x04012C50 RID: 76880
		internal static int __PropertyOffset_2;

		// Token: 0x04012C51 RID: 76881
		internal static int __PropertyOffset_3;

		// Token: 0x04012C52 RID: 76882
		internal static int __PropertyOffset_4;

		// Token: 0x04012C53 RID: 76883
		internal static int __PropertyOffset_5;

		// Token: 0x04012C54 RID: 76884
		internal static int __PropertyOffset_6;

		// Token: 0x04012C55 RID: 76885
		internal static int __PropertyOffset_7;

		// Token: 0x04012C56 RID: 76886
		internal static int __PropertyOffset_8;
	}
}
