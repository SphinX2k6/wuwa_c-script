using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.AssestStruct
{
	// Token: 0x0200321C RID: 12828
	[UnrealObjectPath("/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class BP_KiteConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FFD4 RID: 131028 RVA: 0x0093A799 File Offset: 0x00938999
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KiteConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C");
			}
			return BP_KiteConfig_C._ClassPtr;
		}

		// Token: 0x0601FFD5 RID: 131029 RVA: 0x0093A7C0 File Offset: 0x009389C0
		public BP_KiteConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_KiteConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFD6 RID: 131030 RVA: 0x0093A7E8 File Offset: 0x009389E8
		[NullableContext(1)]
		public BP_KiteConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KiteConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0601FFD7 RID: 131031 RVA: 0x0093A81B File Offset: 0x00938A1B
		// (set) Token: 0x0601FFD8 RID: 131032 RVA: 0x0093A82B File Offset: 0x00938A2B
		public unsafe float 收缩速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_收缩速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_收缩速度) = value;
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0601FFD9 RID: 131033 RVA: 0x0093A83C File Offset: 0x00938A3C
		// (set) Token: 0x0601FFDA RID: 131034 RVA: 0x0093A84C File Offset: 0x00938A4C
		public unsafe float 最短收缩距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_最短收缩距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_最短收缩距离) = value;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0601FFDB RID: 131035 RVA: 0x0093A85D File Offset: 0x00938A5D
		// (set) Token: 0x0601FFDC RID: 131036 RVA: 0x0093A86D File Offset: 0x00938A6D
		public unsafe float 重力强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_重力强度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_重力强度) = value;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0601FFDD RID: 131037 RVA: 0x0093A87E File Offset: 0x00938A7E
		// (set) Token: 0x0601FFDE RID: 131038 RVA: 0x0093A88E File Offset: 0x00938A8E
		public unsafe float 速度衰减系数_每秒保留比例_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_速度衰减系数_每秒保留比例_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KiteConfig_C.__PropertyOffset_速度衰减系数_每秒保留比例_) = value;
			}
		}

		// Token: 0x0601FFDF RID: 131039 RVA: 0x0093A89F File Offset: 0x00938A9F
		protected BP_KiteConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112FA RID: 70394
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/AssestStruct/BP_KiteConfig.BP_KiteConfig_C";

		// Token: 0x040112FB RID: 70395
		private static IntPtr _ClassPtr;

		// Token: 0x040112FC RID: 70396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112FD RID: 70397
		internal static int __PropertyOffset_收缩速度;

		// Token: 0x040112FE RID: 70398
		internal static int __PropertyOffset_最短收缩距离;

		// Token: 0x040112FF RID: 70399
		internal static int __PropertyOffset_重力强度;

		// Token: 0x04011300 RID: 70400
		internal static int __PropertyOffset_速度衰减系数_每秒保留比例_;
	}
}
