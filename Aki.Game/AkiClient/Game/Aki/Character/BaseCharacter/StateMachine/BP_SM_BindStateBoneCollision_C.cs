using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004368 RID: 17256
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_BindStateBoneCollision_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB94 RID: 183188 RVA: 0x00A26E29 File Offset: 0x00A25029
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBoneCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C");
			}
			return BP_SM_BindStateBoneCollision_C._ClassPtr;
		}

		// Token: 0x0602CB95 RID: 183189 RVA: 0x00A26E50 File Offset: 0x00A25050
		public BP_SM_BindStateBoneCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB96 RID: 183190 RVA: 0x00A26E78 File Offset: 0x00A25078
		public BP_SM_BindStateBoneCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007092 RID: 28818
		// (get) Token: 0x0602CB97 RID: 183191 RVA: 0x00A26EAB File Offset: 0x00A250AB
		// (set) Token: 0x0602CB98 RID: 183192 RVA: 0x00A26EBF File Offset: 0x00A250BF
		public unsafe string 骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17007093 RID: 28819
		// (get) Token: 0x0602CB99 RID: 183193 RVA: 0x00A26ED4 File Offset: 0x00A250D4
		// (set) Token: 0x0602CB9A RID: 183194 RVA: 0x00A26EE4 File Offset: 0x00A250E4
		public unsafe bool 阻挡角色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007094 RID: 28820
		// (get) Token: 0x0602CB9B RID: 183195 RVA: 0x00A26EF5 File Offset: 0x00A250F5
		// (set) Token: 0x0602CB9C RID: 183196 RVA: 0x00A26F05 File Offset: 0x00A25105
		public unsafe bool 阻挡子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007095 RID: 28821
		// (get) Token: 0x0602CB9D RID: 183197 RVA: 0x00A26F16 File Offset: 0x00A25116
		// (set) Token: 0x0602CB9E RID: 183198 RVA: 0x00A26F26 File Offset: 0x00A25126
		public unsafe bool 阻挡镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007096 RID: 28822
		// (get) Token: 0x0602CB9F RID: 183199 RVA: 0x00A26F37 File Offset: 0x00A25137
		// (set) Token: 0x0602CBA0 RID: 183200 RVA: 0x00A26F47 File Offset: 0x00A25147
		public unsafe bool 退出节点时阻挡角色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007097 RID: 28823
		// (get) Token: 0x0602CBA1 RID: 183201 RVA: 0x00A26F58 File Offset: 0x00A25158
		// (set) Token: 0x0602CBA2 RID: 183202 RVA: 0x00A26F68 File Offset: 0x00A25168
		public unsafe bool 退出节点时阻挡子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007098 RID: 28824
		// (get) Token: 0x0602CBA3 RID: 183203 RVA: 0x00A26F79 File Offset: 0x00A25179
		// (set) Token: 0x0602CBA4 RID: 183204 RVA: 0x00A26F89 File Offset: 0x00A25189
		public unsafe bool 退出节点时阻挡镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007099 RID: 28825
		// (get) Token: 0x0602CBA5 RID: 183205 RVA: 0x00A26F9A File Offset: 0x00A2519A
		// (set) Token: 0x0602CBA6 RID: 183206 RVA: 0x00A26FAA File Offset: 0x00A251AA
		public unsafe bool 激活部位半透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700709A RID: 28826
		// (get) Token: 0x0602CBA7 RID: 183207 RVA: 0x00A26FBB File Offset: 0x00A251BB
		// (set) Token: 0x0602CBA8 RID: 183208 RVA: 0x00A26FCB File Offset: 0x00A251CB
		public unsafe bool 退出节点时激活部位半透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CBA9 RID: 183209 RVA: 0x00A26FDC File Offset: 0x00A251DC
		protected BP_SM_BindStateBoneCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017958 RID: 96600
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C";

		// Token: 0x04017959 RID: 96601
		private static IntPtr _ClassPtr;

		// Token: 0x0401795A RID: 96602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401795B RID: 96603
		internal static int __PropertyOffset_0;

		// Token: 0x0401795C RID: 96604
		internal static int __PropertyOffset_1;

		// Token: 0x0401795D RID: 96605
		internal static int __PropertyOffset_2;

		// Token: 0x0401795E RID: 96606
		internal static int __PropertyOffset_3;

		// Token: 0x0401795F RID: 96607
		internal static int __PropertyOffset_4;

		// Token: 0x04017960 RID: 96608
		internal static int __PropertyOffset_5;

		// Token: 0x04017961 RID: 96609
		internal static int __PropertyOffset_6;

		// Token: 0x04017962 RID: 96610
		internal static int __PropertyOffset_7;

		// Token: 0x04017963 RID: 96611
		internal static int __PropertyOffset_8;
	}
}
