using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.AssistedWalk
{
	// Token: 0x02003F15 RID: 16149
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class BP_AssistedWalkConfig_C : BP_AttachMoveConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602902A RID: 167978 RVA: 0x009B9859 File Offset: 0x009B7A59
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AssistedWalkConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C");
			}
			return BP_AssistedWalkConfig_C._ClassPtr;
		}

		// Token: 0x0602902B RID: 167979 RVA: 0x009B9880 File Offset: 0x009B7A80
		public BP_AssistedWalkConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_AssistedWalkConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602902C RID: 167980 RVA: 0x009B98A8 File Offset: 0x009B7AA8
		public BP_AssistedWalkConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AssistedWalkConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x0602902D RID: 167981 RVA: 0x009B98DB File Offset: 0x009B7ADB
		// (set) Token: 0x0602902E RID: 167982 RVA: 0x009B98EB File Offset: 0x009B7AEB
		public unsafe int BaseMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x0602902F RID: 167983 RVA: 0x009B98FC File Offset: 0x009B7AFC
		// (set) Token: 0x06029030 RID: 167984 RVA: 0x009B990C File Offset: 0x009B7B0C
		public unsafe int LeaderTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x06029031 RID: 167985 RVA: 0x009B991D File Offset: 0x009B7B1D
		// (set) Token: 0x06029032 RID: 167986 RVA: 0x009B9931 File Offset: 0x009B7B31
		public unsafe FTransform StartTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x06029033 RID: 167987 RVA: 0x009B9946 File Offset: 0x009B7B46
		// (set) Token: 0x06029034 RID: 167988 RVA: 0x009B995A File Offset: 0x009B7B5A
		public unsafe FVector2D AnimSpeedRateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x06029035 RID: 167989 RVA: 0x009B9970 File Offset: 0x009B7B70
		// (set) Token: 0x06029036 RID: 167990 RVA: 0x009B99A9 File Offset: 0x009B7BA9
		public FGameplayTagContainer LeaderGameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._LeaderGameplayTagList) == null)
				{
					result = (this._LeaderGameplayTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029037 RID: 167991 RVA: 0x009B99CA File Offset: 0x009B7BCA
		protected BP_AssistedWalkConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014FAA RID: 85930
		public new const string __ObjectPath = "/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C";

		// Token: 0x04014FAB RID: 85931
		private static IntPtr _ClassPtr;

		// Token: 0x04014FAC RID: 85932
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014FAD RID: 85933
		internal new static int __PropertyOffset_0;

		// Token: 0x04014FAE RID: 85934
		internal new static int __PropertyOffset_1;

		// Token: 0x04014FAF RID: 85935
		internal new static int __PropertyOffset_2;

		// Token: 0x04014FB0 RID: 85936
		internal new static int __PropertyOffset_3;

		// Token: 0x04014FB1 RID: 85937
		internal static int __PropertyOffset_4;

		// Token: 0x04014FB2 RID: 85938
		[Nullable(2)]
		private FGameplayTagContainer _LeaderGameplayTagList;
	}
}
