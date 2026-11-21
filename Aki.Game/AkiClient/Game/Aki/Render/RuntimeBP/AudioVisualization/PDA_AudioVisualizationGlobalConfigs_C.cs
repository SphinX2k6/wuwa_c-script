using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization
{
	// Token: 0x02003143 RID: 12611
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class PDA_AudioVisualizationGlobalConfigs_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F034 RID: 127028 RVA: 0x0092402E File Offset: 0x0092222E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_AudioVisualizationGlobalConfigs_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C");
			}
			return PDA_AudioVisualizationGlobalConfigs_C._ClassPtr;
		}

		// Token: 0x0601F035 RID: 127029 RVA: 0x00924054 File Offset: 0x00922254
		public PDA_AudioVisualizationGlobalConfigs_C() : this(BuiltinUtils.AllocNativeUObject(PDA_AudioVisualizationGlobalConfigs_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F036 RID: 127030 RVA: 0x0092407C File Offset: 0x0092227C
		[NullableContext(1)]
		public PDA_AudioVisualizationGlobalConfigs_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_AudioVisualizationGlobalConfigs_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0601F037 RID: 127031 RVA: 0x009240AF File Offset: 0x009222AF
		// (set) Token: 0x0601F038 RID: 127032 RVA: 0x009240C3 File Offset: 0x009222C3
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPCFile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_AudioVisualizationGlobalConfigs_C.__PropertyOffset_MPCFile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_AudioVisualizationGlobalConfigs_C.__PropertyOffset_MPCFile, value);
			}
		}

		// Token: 0x0601F039 RID: 127033 RVA: 0x009240D8 File Offset: 0x009222D8
		protected PDA_AudioVisualizationGlobalConfigs_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010875 RID: 67701
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C";

		// Token: 0x04010876 RID: 67702
		private static IntPtr _ClassPtr;

		// Token: 0x04010877 RID: 67703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010878 RID: 67704
		internal static int __PropertyOffset_MPCFile;
	}
}
