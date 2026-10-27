using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.AssestStruct
{
	// Token: 0x02003F85 RID: 16261
	[UnrealObjectPath("/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class BP_KiteConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029828 RID: 170024 RVA: 0x009C5D48 File Offset: 0x009C3F48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KiteConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C");
			}
			return BP_KiteConfig_C._ClassPtr;
		}

		// Token: 0x06029829 RID: 170025 RVA: 0x009C5D6C File Offset: 0x009C3F6C
		public BP_KiteConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_KiteConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602982A RID: 170026 RVA: 0x009C5D94 File Offset: 0x009C3F94
		[NullableContext(1)]
		public BP_KiteConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KiteConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170063A4 RID: 25508
		// (get) Token: 0x0602982B RID: 170027 RVA: 0x009C5DC7 File Offset: 0x009C3FC7
		// (set) Token: 0x0602982C RID: 170028 RVA: 0x009C5DD7 File Offset: 0x009C3FD7
		public unsafe float 收缩速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170063A5 RID: 25509
		// (get) Token: 0x0602982D RID: 170029 RVA: 0x009C5DE8 File Offset: 0x009C3FE8
		// (set) Token: 0x0602982E RID: 170030 RVA: 0x009C5DF8 File Offset: 0x009C3FF8
		public unsafe float 最短收缩距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170063A6 RID: 25510
		// (get) Token: 0x0602982F RID: 170031 RVA: 0x009C5E09 File Offset: 0x009C4009
		// (set) Token: 0x06029830 RID: 170032 RVA: 0x009C5E19 File Offset: 0x009C4019
		public unsafe float 重力强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170063A7 RID: 25511
		// (get) Token: 0x06029831 RID: 170033 RVA: 0x009C5E2A File Offset: 0x009C402A
		// (set) Token: 0x06029832 RID: 170034 RVA: 0x009C5E3A File Offset: 0x009C403A
		public unsafe float 速度衰减系数_每秒保留比例_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029833 RID: 170035 RVA: 0x009C5E4B File Offset: 0x009C404B
		protected BP_KiteConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401546C RID: 87148
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C";

		// Token: 0x0401546D RID: 87149
		private static IntPtr _ClassPtr;

		// Token: 0x0401546E RID: 87150
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401546F RID: 87151
		internal static int __PropertyOffset_0;

		// Token: 0x04015470 RID: 87152
		internal static int __PropertyOffset_1;

		// Token: 0x04015471 RID: 87153
		internal static int __PropertyOffset_2;

		// Token: 0x04015472 RID: 87154
		internal static int __PropertyOffset_3;
	}
}
