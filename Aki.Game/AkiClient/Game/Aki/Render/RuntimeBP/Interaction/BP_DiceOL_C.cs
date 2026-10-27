using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0F RID: 15631
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_DiceOL_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025751 RID: 153425 RVA: 0x0095A478 File Offset: 0x00958678
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DiceOL_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C");
			}
			return BP_DiceOL_C._ClassPtr;
		}

		// Token: 0x06025752 RID: 153426 RVA: 0x0095A49C File Offset: 0x0095869C
		public BP_DiceOL_C() : this(BuiltinUtils.AllocNativeUObject(BP_DiceOL_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025753 RID: 153427 RVA: 0x0095A4C4 File Offset: 0x009586C4
		[NullableContext(1)]
		public BP_DiceOL_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DiceOL_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x06025754 RID: 153428 RVA: 0x0095A4F7 File Offset: 0x009586F7
		// (set) Token: 0x06025755 RID: 153429 RVA: 0x0095A50B File Offset: 0x0095870B
		public unsafe UStaticMeshComponent DiceOL1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x06025756 RID: 153430 RVA: 0x0095A520 File Offset: 0x00958720
		// (set) Token: 0x06025757 RID: 153431 RVA: 0x0095A534 File Offset: 0x00958734
		public unsafe UStaticMeshComponent DiceOL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x06025758 RID: 153432 RVA: 0x0095A549 File Offset: 0x00958749
		// (set) Token: 0x06025759 RID: 153433 RVA: 0x0095A55D File Offset: 0x0095875D
		public unsafe UStaticMeshComponent Dice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602575A RID: 153434 RVA: 0x0095A572 File Offset: 0x00958772
		protected BP_DiceOL_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B08 RID: 76552
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C";

		// Token: 0x04012B09 RID: 76553
		private static IntPtr _ClassPtr;

		// Token: 0x04012B0A RID: 76554
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B0B RID: 76555
		internal static int __PropertyOffset_0;

		// Token: 0x04012B0C RID: 76556
		internal static int __PropertyOffset_1;

		// Token: 0x04012B0D RID: 76557
		internal static int __PropertyOffset_2;
	}
}
