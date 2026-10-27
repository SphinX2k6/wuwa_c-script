using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization
{
	// Token: 0x02003E3D RID: 15933
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class PDA_AudioVisualizationGlobalConfigs_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028083 RID: 163971 RVA: 0x009A2592 File Offset: 0x009A0792
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_AudioVisualizationGlobalConfigs_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C");
			}
			return PDA_AudioVisualizationGlobalConfigs_C._ClassPtr;
		}

		// Token: 0x06028084 RID: 163972 RVA: 0x009A25B8 File Offset: 0x009A07B8
		public PDA_AudioVisualizationGlobalConfigs_C() : this(BuiltinUtils.AllocNativeUObject(PDA_AudioVisualizationGlobalConfigs_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028085 RID: 163973 RVA: 0x009A25E0 File Offset: 0x009A07E0
		public PDA_AudioVisualizationGlobalConfigs_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_AudioVisualizationGlobalConfigs_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x06028086 RID: 163974 RVA: 0x009A2614 File Offset: 0x009A0814
		// (set) Token: 0x06028087 RID: 163975 RVA: 0x009A264D File Offset: 0x009A084D
		public TArray<SGlobalRtpcEntry> GlobalRtpcs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SGlobalRtpcEntry> result;
				if ((result = this._GlobalRtpcs) == null)
				{
					result = (this._GlobalRtpcs = new TArray<SGlobalRtpcEntry>(base.NativePtr + (IntPtr)PDA_AudioVisualizationGlobalConfigs_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.GlobalRtpcs.CopyAssign(value);
			}
		}

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x06028088 RID: 163976 RVA: 0x009A265B File Offset: 0x009A085B
		// (set) Token: 0x06028089 RID: 163977 RVA: 0x009A266F File Offset: 0x009A086F
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPCFile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_AudioVisualizationGlobalConfigs_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_AudioVisualizationGlobalConfigs_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602808A RID: 163978 RVA: 0x009A2684 File Offset: 0x009A0884
		protected PDA_AudioVisualizationGlobalConfigs_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014544 RID: 83268
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/AudioVisualization/PDA_AudioVisualizationGlobalConfigs.PDA_AudioVisualizationGlobalConfigs_C";

		// Token: 0x04014545 RID: 83269
		private static IntPtr _ClassPtr;

		// Token: 0x04014546 RID: 83270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014547 RID: 83271
		internal static int __PropertyOffset_0;

		// Token: 0x04014548 RID: 83272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SGlobalRtpcEntry> _GlobalRtpcs;

		// Token: 0x04014549 RID: 83273
		internal static int __PropertyOffset_1;
	}
}
