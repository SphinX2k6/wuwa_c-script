using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.AttachMove
{
	// Token: 0x02003F14 RID: 16148
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class BP_AttachMoveConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602901E RID: 167966 RVA: 0x009B9704 File Offset: 0x009B7904
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AttachMoveConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C");
			}
			return BP_AttachMoveConfig_C._ClassPtr;
		}

		// Token: 0x0602901F RID: 167967 RVA: 0x009B9728 File Offset: 0x009B7928
		public BP_AttachMoveConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_AttachMoveConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029020 RID: 167968 RVA: 0x009B9750 File Offset: 0x009B7950
		public BP_AttachMoveConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AttachMoveConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x06029021 RID: 167969 RVA: 0x009B9783 File Offset: 0x009B7983
		// (set) Token: 0x06029022 RID: 167970 RVA: 0x009B9797 File Offset: 0x009B7997
		public unsafe string AttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x06029023 RID: 167971 RVA: 0x009B97AC File Offset: 0x009B79AC
		// (set) Token: 0x06029024 RID: 167972 RVA: 0x009B97E5 File Offset: 0x009B79E5
		public FGameplayTagContainer GameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._GameplayTagList) == null)
				{
					result = (this._GameplayTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x06029025 RID: 167973 RVA: 0x009B9806 File Offset: 0x009B7A06
		// (set) Token: 0x06029026 RID: 167974 RVA: 0x009B9816 File Offset: 0x009B7A16
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x06029027 RID: 167975 RVA: 0x009B9827 File Offset: 0x009B7A27
		// (set) Token: 0x06029028 RID: 167976 RVA: 0x009B983B File Offset: 0x009B7A3B
		public unsafe FTransform AttachTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029029 RID: 167977 RVA: 0x009B9850 File Offset: 0x009B7A50
		protected BP_AttachMoveConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014FA2 RID: 85922
		public new const string __ObjectPath = "/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C";

		// Token: 0x04014FA3 RID: 85923
		private static IntPtr _ClassPtr;

		// Token: 0x04014FA4 RID: 85924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014FA5 RID: 85925
		internal static int __PropertyOffset_0;

		// Token: 0x04014FA6 RID: 85926
		internal static int __PropertyOffset_1;

		// Token: 0x04014FA7 RID: 85927
		[Nullable(2)]
		private FGameplayTagContainer _GameplayTagList;

		// Token: 0x04014FA8 RID: 85928
		internal static int __PropertyOffset_2;

		// Token: 0x04014FA9 RID: 85929
		internal static int __PropertyOffset_3;
	}
}
