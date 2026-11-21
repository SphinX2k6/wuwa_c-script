using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x0200312C RID: 12588
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 162)]
	public class PD_CharacterControllerDataGroup_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EEDF RID: 126687 RVA: 0x0092148B File Offset: 0x0091F68B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CharacterControllerDataGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C");
			}
			return PD_CharacterControllerDataGroup_C._ClassPtr;
		}

		// Token: 0x0601EEE0 RID: 126688 RVA: 0x009214B0 File Offset: 0x0091F6B0
		public PD_CharacterControllerDataGroup_C() : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerDataGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EEE1 RID: 126689 RVA: 0x009214D8 File Offset: 0x0091F6D8
		public PD_CharacterControllerDataGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerDataGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0601EEE2 RID: 126690 RVA: 0x0092150C File Offset: 0x0091F70C
		// (set) Token: 0x0601EEE3 RID: 126691 RVA: 0x00921545 File Offset: 0x0091F745
		public TMap<PD_CharacterControllerData_C, float> DataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<PD_CharacterControllerData_C, float> result;
				if ((result = this._DataMap) == null)
				{
					result = (this._DataMap = new TMap<PD_CharacterControllerData_C, float>(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_DataMap, this));
				}
				return result;
			}
			set
			{
				this.DataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0601EEE4 RID: 126692 RVA: 0x00921553 File Offset: 0x0091F753
		// (set) Token: 0x0601EEE5 RID: 126693 RVA: 0x00921563 File Offset: 0x0091F763
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_IgnoreTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_IgnoreTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0601EEE6 RID: 126694 RVA: 0x00921574 File Offset: 0x0091F774
		// (set) Token: 0x0601EEE7 RID: 126695 RVA: 0x00921584 File Offset: 0x0091F784
		public unsafe bool CleanOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_CleanOriginEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerDataGroup_C.__PropertyOffset_CleanOriginEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EEE8 RID: 126696 RVA: 0x00921595 File Offset: 0x0091F795
		protected PD_CharacterControllerDataGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401075B RID: 67419
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerDataGroup.PD_CharacterControllerDataGroup_C";

		// Token: 0x0401075C RID: 67420
		private static IntPtr _ClassPtr;

		// Token: 0x0401075D RID: 67421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401075E RID: 67422
		internal static int __PropertyOffset_DataMap;

		// Token: 0x0401075F RID: 67423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<PD_CharacterControllerData_C, float> _DataMap;

		// Token: 0x04010760 RID: 67424
		internal static int __PropertyOffset_IgnoreTimeDilation;

		// Token: 0x04010761 RID: 67425
		internal static int __PropertyOffset_CleanOriginEffect;
	}
}
