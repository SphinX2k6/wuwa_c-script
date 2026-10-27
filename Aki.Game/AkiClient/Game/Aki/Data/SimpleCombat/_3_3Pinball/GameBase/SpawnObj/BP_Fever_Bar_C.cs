using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.SimpleCombat._3_3Pinball.GameBase.SpawnObj
{
	// Token: 0x02003E96 RID: 16022
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_Fever_Bar_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028813 RID: 165907 RVA: 0x009ADF6D File Offset: 0x009AC16D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fever_Bar_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C");
			}
			return BP_Fever_Bar_C._ClassPtr;
		}

		// Token: 0x06028814 RID: 165908 RVA: 0x009ADF94 File Offset: 0x009AC194
		public BP_Fever_Bar_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fever_Bar_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028815 RID: 165909 RVA: 0x009ADFBC File Offset: 0x009AC1BC
		[NullableContext(1)]
		public BP_Fever_Bar_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fever_Bar_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E38 RID: 24120
		// (get) Token: 0x06028816 RID: 165910 RVA: 0x009ADFEF File Offset: 0x009AC1EF
		// (set) Token: 0x06028817 RID: 165911 RVA: 0x009AE003 File Offset: 0x009AC203
		public unsafe UStaticMeshComponent Bg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005E39 RID: 24121
		// (get) Token: 0x06028818 RID: 165912 RVA: 0x009AE018 File Offset: 0x009AC218
		// (set) Token: 0x06028819 RID: 165913 RVA: 0x009AE02C File Offset: 0x009AC22C
		public unsafe UStaticMeshComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005E3A RID: 24122
		// (get) Token: 0x0602881A RID: 165914 RVA: 0x009AE041 File Offset: 0x009AC241
		// (set) Token: 0x0602881B RID: 165915 RVA: 0x009AE055 File Offset: 0x009AC255
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602881C RID: 165916 RVA: 0x009AE06A File Offset: 0x009AC26A
		protected BP_Fever_Bar_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014A94 RID: 84628
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C";

		// Token: 0x04014A95 RID: 84629
		private static IntPtr _ClassPtr;

		// Token: 0x04014A96 RID: 84630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014A97 RID: 84631
		internal static int __PropertyOffset_0;

		// Token: 0x04014A98 RID: 84632
		internal static int __PropertyOffset_1;

		// Token: 0x04014A99 RID: 84633
		internal static int __PropertyOffset_2;
	}
}
