using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E14 RID: 15892
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 162)]
	public class PD_CharacterControllerDataGroup_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027CD0 RID: 163024 RVA: 0x0099B85F File Offset: 0x00999A5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CharacterControllerDataGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C");
			}
			return PD_CharacterControllerDataGroup_C._ClassPtr;
		}

		// Token: 0x06027CD1 RID: 163025 RVA: 0x0099B884 File Offset: 0x00999A84
		public PD_CharacterControllerDataGroup_C() : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerDataGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027CD2 RID: 163026 RVA: 0x0099B8AC File Offset: 0x00999AAC
		public PD_CharacterControllerDataGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerDataGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x06027CD3 RID: 163027 RVA: 0x0099B8E0 File Offset: 0x00999AE0
		// (set) Token: 0x06027CD4 RID: 163028 RVA: 0x0099B919 File Offset: 0x00999B19
		public TMap<PD_CharacterControllerData_C, float> DataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<PD_CharacterControllerData_C, float> result;
				if ((result = this._DataMap) == null)
				{
					result = (this._DataMap = new TMap<PD_CharacterControllerData_C, float>(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.DataMap.CopyAssign(value);
			}
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x06027CD5 RID: 163029 RVA: 0x0099B927 File Offset: 0x00999B27
		// (set) Token: 0x06027CD6 RID: 163030 RVA: 0x0099B937 File Offset: 0x00999B37
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x06027CD7 RID: 163031 RVA: 0x0099B948 File Offset: 0x00999B48
		// (set) Token: 0x06027CD8 RID: 163032 RVA: 0x0099B958 File Offset: 0x00999B58
		public unsafe bool CleanOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027CD9 RID: 163033 RVA: 0x0099B969 File Offset: 0x00999B69
		protected PD_CharacterControllerDataGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040142B0 RID: 82608
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C";

		// Token: 0x040142B1 RID: 82609
		private static IntPtr _ClassPtr;

		// Token: 0x040142B2 RID: 82610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040142B3 RID: 82611
		internal static int __PropertyOffset_0;

		// Token: 0x040142B4 RID: 82612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<PD_CharacterControllerData_C, float> _DataMap;

		// Token: 0x040142B5 RID: 82613
		internal static int __PropertyOffset_1;

		// Token: 0x040142B6 RID: 82614
		internal static int __PropertyOffset_2;
	}
}
