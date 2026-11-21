using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.AttachMove
{
	// Token: 0x020031CE RID: 12750
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class BP_AttachMoveConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F99A RID: 129434 RVA: 0x0093133B File Offset: 0x0092F53B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AttachMoveConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C");
			}
			return BP_AttachMoveConfig_C._ClassPtr;
		}

		// Token: 0x0601F99B RID: 129435 RVA: 0x00931360 File Offset: 0x0092F560
		public BP_AttachMoveConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_AttachMoveConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F99C RID: 129436 RVA: 0x00931388 File Offset: 0x0092F588
		public BP_AttachMoveConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AttachMoveConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0601F99D RID: 129437 RVA: 0x009313BB File Offset: 0x0092F5BB
		// (set) Token: 0x0601F99E RID: 129438 RVA: 0x009313CF File Offset: 0x0092F5CF
		public unsafe string AttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_AttachSocket)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_AttachSocket)), value);
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0601F99F RID: 129439 RVA: 0x009313E4 File Offset: 0x0092F5E4
		// (set) Token: 0x0601F9A0 RID: 129440 RVA: 0x0093141D File Offset: 0x0092F61D
		public FGameplayTagContainer GameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._GameplayTagList) == null)
				{
					result = (this._GameplayTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_GameplayTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_GameplayTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0601F9A1 RID: 129441 RVA: 0x0093143E File Offset: 0x0092F63E
		// (set) Token: 0x0601F9A2 RID: 129442 RVA: 0x0093144E File Offset: 0x0092F64E
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_Debug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_Debug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0601F9A3 RID: 129443 RVA: 0x0093145F File Offset: 0x0092F65F
		// (set) Token: 0x0601F9A4 RID: 129444 RVA: 0x00931473 File Offset: 0x0092F673
		public unsafe FTransform AttachTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_AttachTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AttachMoveConfig_C.__PropertyOffset_AttachTransform) = value;
			}
		}

		// Token: 0x0601F9A5 RID: 129445 RVA: 0x00931488 File Offset: 0x0092F688
		protected BP_AttachMoveConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F34 RID: 69428
		public new const string __ObjectPath = "/Game/Aki/Data/Level/AttachMove/BP_AttachMoveConfig.BP_AttachMoveConfig_C";

		// Token: 0x04010F35 RID: 69429
		private static IntPtr _ClassPtr;

		// Token: 0x04010F36 RID: 69430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F37 RID: 69431
		internal static int __PropertyOffset_AttachSocket;

		// Token: 0x04010F38 RID: 69432
		internal static int __PropertyOffset_GameplayTagList;

		// Token: 0x04010F39 RID: 69433
		[Nullable(2)]
		private FGameplayTagContainer _GameplayTagList;

		// Token: 0x04010F3A RID: 69434
		internal static int __PropertyOffset_Debug;

		// Token: 0x04010F3B RID: 69435
		internal static int __PropertyOffset_AttachTransform;
	}
}
