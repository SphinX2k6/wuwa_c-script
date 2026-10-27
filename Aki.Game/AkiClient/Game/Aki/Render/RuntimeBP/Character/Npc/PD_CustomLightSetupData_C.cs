using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFF RID: 15871
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/PD_CustomLightSetupData.PD_CustomLightSetupData_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class PD_CustomLightSetupData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A5B RID: 162395 RVA: 0x009976E9 File Offset: 0x009958E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CustomLightSetupData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_CustomLightSetupData.PD_CustomLightSetupData_C");
			}
			return PD_CustomLightSetupData_C._ClassPtr;
		}

		// Token: 0x06027A5C RID: 162396 RVA: 0x00997710 File Offset: 0x00995910
		public PD_CustomLightSetupData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CustomLightSetupData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A5D RID: 162397 RVA: 0x00997738 File Offset: 0x00995938
		public PD_CustomLightSetupData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CustomLightSetupData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700592C RID: 22828
		// (get) Token: 0x06027A5E RID: 162398 RVA: 0x0099776B File Offset: 0x0099596B
		// (set) Token: 0x06027A5F RID: 162399 RVA: 0x0099777B File Offset: 0x0099597B
		public unsafe bool Target_UseCustomLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700592D RID: 22829
		// (get) Token: 0x06027A60 RID: 162400 RVA: 0x0099778C File Offset: 0x0099598C
		// (set) Token: 0x06027A61 RID: 162401 RVA: 0x0099779C File Offset: 0x0099599C
		public unsafe float Target_LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x06027A62 RID: 162402 RVA: 0x009977AD File Offset: 0x009959AD
		// (set) Token: 0x06027A63 RID: 162403 RVA: 0x009977BD File Offset: 0x009959BD
		public unsafe float Target_LightPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x06027A64 RID: 162404 RVA: 0x009977CE File Offset: 0x009959CE
		// (set) Token: 0x06027A65 RID: 162405 RVA: 0x009977DE File Offset: 0x009959DE
		public unsafe float Target_FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x06027A66 RID: 162406 RVA: 0x009977EF File Offset: 0x009959EF
		// (set) Token: 0x06027A67 RID: 162407 RVA: 0x009977FF File Offset: 0x009959FF
		public unsafe bool Target_UsePointLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005931 RID: 22833
		// (get) Token: 0x06027A68 RID: 162408 RVA: 0x00997810 File Offset: 0x00995A10
		// (set) Token: 0x06027A69 RID: 162409 RVA: 0x00997849 File Offset: 0x00995A49
		public TArray<PD_CharacterControllerData_C> 材质控制器特效
		{
			get
			{
				base.FastCheckIsValid();
				TArray<PD_CharacterControllerData_C> result;
				if ((result = this._材质控制器特效) == null)
				{
					result = (this._材质控制器特效 = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)PD_CustomLightSetupData_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.材质控制器特效.CopyAssign(value);
			}
		}

		// Token: 0x06027A6A RID: 162410 RVA: 0x00997857 File Offset: 0x00995A57
		protected PD_CustomLightSetupData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014103 RID: 82179
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/PD_CustomLightSetupData.PD_CustomLightSetupData_C";

		// Token: 0x04014104 RID: 82180
		private static IntPtr _ClassPtr;

		// Token: 0x04014105 RID: 82181
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014106 RID: 82182
		internal static int __PropertyOffset_0;

		// Token: 0x04014107 RID: 82183
		internal static int __PropertyOffset_1;

		// Token: 0x04014108 RID: 82184
		internal static int __PropertyOffset_2;

		// Token: 0x04014109 RID: 82185
		internal static int __PropertyOffset_3;

		// Token: 0x0401410A RID: 82186
		internal static int __PropertyOffset_4;

		// Token: 0x0401410B RID: 82187
		internal static int __PropertyOffset_5;

		// Token: 0x0401410C RID: 82188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _材质控制器特效;
	}
}
