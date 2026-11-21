using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x020031BD RID: 12733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 157)]
	public class BP_BaseSwingConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7BD RID: 128957 RVA: 0x0092EC5E File Offset: 0x0092CE5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C");
			}
			return BP_BaseSwingConfig_C._ClassPtr;
		}

		// Token: 0x0601F7BE RID: 128958 RVA: 0x0092EC84 File Offset: 0x0092CE84
		public BP_BaseSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7BF RID: 128959 RVA: 0x0092ECAC File Offset: 0x0092CEAC
		public BP_BaseSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0601F7C0 RID: 128960 RVA: 0x0092ECDF File Offset: 0x0092CEDF
		// (set) Token: 0x0601F7C1 RID: 128961 RVA: 0x0092ECF3 File Offset: 0x0092CEF3
		public unsafe FVector AttachLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachLocation) = value;
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0601F7C2 RID: 128962 RVA: 0x0092ED08 File Offset: 0x0092CF08
		// (set) Token: 0x0601F7C3 RID: 128963 RVA: 0x0092ED18 File Offset: 0x0092CF18
		public unsafe int SitOnModelBufferTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_SitOnModelBufferTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_SitOnModelBufferTime) = value;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0601F7C4 RID: 128964 RVA: 0x0092ED29 File Offset: 0x0092CF29
		// (set) Token: 0x0601F7C5 RID: 128965 RVA: 0x0092ED39 File Offset: 0x0092CF39
		public unsafe int StandUpModelBufferTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_StandUpModelBufferTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_StandUpModelBufferTime) = value;
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0601F7C6 RID: 128966 RVA: 0x0092ED4A File Offset: 0x0092CF4A
		// (set) Token: 0x0601F7C7 RID: 128967 RVA: 0x0092ED5E File Offset: 0x0092CF5E
		public unsafe string AttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachSocket)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachSocket)), value);
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0601F7C8 RID: 128968 RVA: 0x0092ED73 File Offset: 0x0092CF73
		// (set) Token: 0x0601F7C9 RID: 128969 RVA: 0x0092ED87 File Offset: 0x0092CF87
		public unsafe FVector AttachRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_AttachRotator) = value;
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0601F7CA RID: 128970 RVA: 0x0092ED9C File Offset: 0x0092CF9C
		// (set) Token: 0x0601F7CB RID: 128971 RVA: 0x0092EDB0 File Offset: 0x0092CFB0
		public unsafe string ReferenceActor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_ReferenceActor)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_ReferenceActor)), value);
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0601F7CC RID: 128972 RVA: 0x0092EDC5 File Offset: 0x0092CFC5
		// (set) Token: 0x0601F7CD RID: 128973 RVA: 0x0092EDD5 File Offset: 0x0092CFD5
		public unsafe int StandUpMoveAwayDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_StandUpMoveAwayDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_StandUpMoveAwayDist) = value;
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0601F7CE RID: 128974 RVA: 0x0092EDE6 File Offset: 0x0092CFE6
		// (set) Token: 0x0601F7CF RID: 128975 RVA: 0x0092EDF6 File Offset: 0x0092CFF6
		public unsafe bool ExitImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_ExitImmediately) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_ExitImmediately) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F7D0 RID: 128976 RVA: 0x0092EE07 File Offset: 0x0092D007
		protected BP_BaseSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E2C RID: 69164
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C";

		// Token: 0x04010E2D RID: 69165
		private static IntPtr _ClassPtr;

		// Token: 0x04010E2E RID: 69166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E2F RID: 69167
		internal static int __PropertyOffset_AttachLocation;

		// Token: 0x04010E30 RID: 69168
		internal static int __PropertyOffset_SitOnModelBufferTime;

		// Token: 0x04010E31 RID: 69169
		internal static int __PropertyOffset_StandUpModelBufferTime;

		// Token: 0x04010E32 RID: 69170
		internal static int __PropertyOffset_AttachSocket;

		// Token: 0x04010E33 RID: 69171
		internal static int __PropertyOffset_AttachRotator;

		// Token: 0x04010E34 RID: 69172
		internal static int __PropertyOffset_ReferenceActor;

		// Token: 0x04010E35 RID: 69173
		internal static int __PropertyOffset_StandUpMoveAwayDist;

		// Token: 0x04010E36 RID: 69174
		internal static int __PropertyOffset_ExitImmediately;
	}
}
