using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F1 RID: 12529
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_DiceOL_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E6DF RID: 124639 RVA: 0x00913AB7 File Offset: 0x00911CB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DiceOL_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C");
			}
			return BP_DiceOL_C._ClassPtr;
		}

		// Token: 0x0601E6E0 RID: 124640 RVA: 0x00913ADC File Offset: 0x00911CDC
		public BP_DiceOL_C() : this(BuiltinUtils.AllocNativeUObject(BP_DiceOL_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E6E1 RID: 124641 RVA: 0x00913B04 File Offset: 0x00911D04
		[NullableContext(1)]
		public BP_DiceOL_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DiceOL_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0601E6E2 RID: 124642 RVA: 0x00913B37 File Offset: 0x00911D37
		// (set) Token: 0x0601E6E3 RID: 124643 RVA: 0x00913B4B File Offset: 0x00911D4B
		public unsafe UStaticMeshComponent DiceOL1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_DiceOL1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_DiceOL1, value);
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0601E6E4 RID: 124644 RVA: 0x00913B60 File Offset: 0x00911D60
		// (set) Token: 0x0601E6E5 RID: 124645 RVA: 0x00913B74 File Offset: 0x00911D74
		public unsafe UStaticMeshComponent DiceOL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_DiceOL);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_DiceOL, value);
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0601E6E6 RID: 124646 RVA: 0x00913B89 File Offset: 0x00911D89
		// (set) Token: 0x0601E6E7 RID: 124647 RVA: 0x00913B9D File Offset: 0x00911D9D
		public unsafe UStaticMeshComponent Dice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_Dice);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceOL_C.__PropertyOffset_Dice, value);
			}
		}

		// Token: 0x0601E6E8 RID: 124648 RVA: 0x00913BB2 File Offset: 0x00911DB2
		protected BP_DiceOL_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040101D9 RID: 66009
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceOL.BP_DiceOL_C";

		// Token: 0x040101DA RID: 66010
		private static IntPtr _ClassPtr;

		// Token: 0x040101DB RID: 66011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040101DC RID: 66012
		internal static int __PropertyOffset_DiceOL1;

		// Token: 0x040101DD RID: 66013
		internal static int __PropertyOffset_DiceOL;

		// Token: 0x040101DE RID: 66014
		internal static int __PropertyOffset_Dice;
	}
}
