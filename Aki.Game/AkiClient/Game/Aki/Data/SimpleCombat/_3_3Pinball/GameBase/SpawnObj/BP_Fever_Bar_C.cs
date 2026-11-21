using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.SimpleCombat._3_3Pinball.GameBase.SpawnObj
{
	// Token: 0x02003170 RID: 12656
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_Fever_Bar_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F382 RID: 127874 RVA: 0x00928E60 File Offset: 0x00927060
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fever_Bar_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C");
			}
			return BP_Fever_Bar_C._ClassPtr;
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x00928E84 File Offset: 0x00927084
		public BP_Fever_Bar_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fever_Bar_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F384 RID: 127876 RVA: 0x00928EAC File Offset: 0x009270AC
		[NullableContext(1)]
		public BP_Fever_Bar_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fever_Bar_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0601F385 RID: 127877 RVA: 0x00928EDF File Offset: 0x009270DF
		// (set) Token: 0x0601F386 RID: 127878 RVA: 0x00928EF3 File Offset: 0x009270F3
		public unsafe UStaticMeshComponent Bg
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_Bg);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_Bg, value);
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0601F387 RID: 127879 RVA: 0x00928F08 File Offset: 0x00927108
		// (set) Token: 0x0601F388 RID: 127880 RVA: 0x00928F1C File Offset: 0x0092711C
		public unsafe UStaticMeshComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0601F389 RID: 127881 RVA: 0x00928F31 File Offset: 0x00927131
		// (set) Token: 0x0601F38A RID: 127882 RVA: 0x00928F45 File Offset: 0x00927145
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fever_Bar_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601F38B RID: 127883 RVA: 0x00928F5A File Offset: 0x0092715A
		protected BP_Fever_Bar_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B24 RID: 68388
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/SimpleCombat/3_3Pinball/GameBase/SpawnObj/BP_Fever_Bar.BP_Fever_Bar_C";

		// Token: 0x04010B25 RID: 68389
		private static IntPtr _ClassPtr;

		// Token: 0x04010B26 RID: 68390
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B27 RID: 68391
		internal static int __PropertyOffset_Bg;

		// Token: 0x04010B28 RID: 68392
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04010B29 RID: 68393
		internal static int __PropertyOffset_DefaultSceneRoot;
	}
}
