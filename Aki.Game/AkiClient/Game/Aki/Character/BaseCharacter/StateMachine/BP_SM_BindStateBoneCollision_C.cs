using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003389 RID: 13193
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_BindStateBoneCollision_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217B2 RID: 137138 RVA: 0x00961C7D File Offset: 0x0095FE7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBoneCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C");
			}
			return BP_SM_BindStateBoneCollision_C._ClassPtr;
		}

		// Token: 0x060217B3 RID: 137139 RVA: 0x00961CA4 File Offset: 0x0095FEA4
		public BP_SM_BindStateBoneCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217B4 RID: 137140 RVA: 0x00961CCC File Offset: 0x0095FECC
		public BP_SM_BindStateBoneCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004494 RID: 17556
		// (get) Token: 0x060217B5 RID: 137141 RVA: 0x00961CFF File Offset: 0x0095FEFF
		// (set) Token: 0x060217B6 RID: 137142 RVA: 0x00961D13 File Offset: 0x0095FF13
		public unsafe string 骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_骨骼名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_骨骼名)), value);
			}
		}

		// Token: 0x17004495 RID: 17557
		// (get) Token: 0x060217B7 RID: 137143 RVA: 0x00961D28 File Offset: 0x0095FF28
		// (set) Token: 0x060217B8 RID: 137144 RVA: 0x00961D38 File Offset: 0x0095FF38
		public unsafe bool 阻挡角色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡角色) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡角色) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004496 RID: 17558
		// (get) Token: 0x060217B9 RID: 137145 RVA: 0x00961D49 File Offset: 0x0095FF49
		// (set) Token: 0x060217BA RID: 137146 RVA: 0x00961D59 File Offset: 0x0095FF59
		public unsafe bool 阻挡子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡子弹) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡子弹) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004497 RID: 17559
		// (get) Token: 0x060217BB RID: 137147 RVA: 0x00961D6A File Offset: 0x0095FF6A
		// (set) Token: 0x060217BC RID: 137148 RVA: 0x00961D7A File Offset: 0x0095FF7A
		public unsafe bool 阻挡镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_阻挡镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x060217BD RID: 137149 RVA: 0x00961D8B File Offset: 0x0095FF8B
		// (set) Token: 0x060217BE RID: 137150 RVA: 0x00961D9B File Offset: 0x0095FF9B
		public unsafe bool 退出节点时阻挡角色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡角色) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡角色) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004499 RID: 17561
		// (get) Token: 0x060217BF RID: 137151 RVA: 0x00961DAC File Offset: 0x0095FFAC
		// (set) Token: 0x060217C0 RID: 137152 RVA: 0x00961DBC File Offset: 0x0095FFBC
		public unsafe bool 退出节点时阻挡子弹
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡子弹) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡子弹) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700449A RID: 17562
		// (get) Token: 0x060217C1 RID: 137153 RVA: 0x00961DCD File Offset: 0x0095FFCD
		// (set) Token: 0x060217C2 RID: 137154 RVA: 0x00961DDD File Offset: 0x0095FFDD
		public unsafe bool 退出节点时阻挡镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时阻挡镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700449B RID: 17563
		// (get) Token: 0x060217C3 RID: 137155 RVA: 0x00961DEE File Offset: 0x0095FFEE
		// (set) Token: 0x060217C4 RID: 137156 RVA: 0x00961DFE File Offset: 0x0095FFFE
		public unsafe bool 激活部位半透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_激活部位半透) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_激活部位半透) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700449C RID: 17564
		// (get) Token: 0x060217C5 RID: 137157 RVA: 0x00961E0F File Offset: 0x0096000F
		// (set) Token: 0x060217C6 RID: 137158 RVA: 0x00961E1F File Offset: 0x0096001F
		public unsafe bool 退出节点时激活部位半透
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时激活部位半透) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneCollision_C.__PropertyOffset_退出节点时激活部位半透) = (value ? 1 : 0);
			}
		}

		// Token: 0x060217C7 RID: 137159 RVA: 0x00961E30 File Offset: 0x00960030
		protected BP_SM_BindStateBoneCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124D9 RID: 74969
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneCollision.BP_SM_BindStateBoneCollision_C";

		// Token: 0x040124DA RID: 74970
		private static IntPtr _ClassPtr;

		// Token: 0x040124DB RID: 74971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124DC RID: 74972
		internal static int __PropertyOffset_骨骼名;

		// Token: 0x040124DD RID: 74973
		internal static int __PropertyOffset_阻挡角色;

		// Token: 0x040124DE RID: 74974
		internal static int __PropertyOffset_阻挡子弹;

		// Token: 0x040124DF RID: 74975
		internal static int __PropertyOffset_阻挡镜头;

		// Token: 0x040124E0 RID: 74976
		internal static int __PropertyOffset_退出节点时阻挡角色;

		// Token: 0x040124E1 RID: 74977
		internal static int __PropertyOffset_退出节点时阻挡子弹;

		// Token: 0x040124E2 RID: 74978
		internal static int __PropertyOffset_退出节点时阻挡镜头;

		// Token: 0x040124E3 RID: 74979
		internal static int __PropertyOffset_激活部位半透;

		// Token: 0x040124E4 RID: 74980
		internal static int __PropertyOffset_退出节点时激活部位半透;
	}
}
