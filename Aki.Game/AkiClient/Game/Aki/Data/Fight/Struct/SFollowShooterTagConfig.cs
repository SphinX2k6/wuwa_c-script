using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003207 RID: 12807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 66)]
	public class SFollowShooterTagConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE50 RID: 130640 RVA: 0x0093872C File Offset: 0x0093692C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowShooterTagConfig._ScriptStructPtr != 0) ? SFollowShooterTagConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig", ref SFollowShooterTagConfig._ScriptStructPtr);
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0601FE51 RID: 130641 RVA: 0x00938750 File Offset: 0x00936950
		// (set) Token: 0x0601FE52 RID: 130642 RVA: 0x00938793 File Offset: 0x00936993
		public FGameplayTagContainer AddTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_AddTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_AddTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0601FE53 RID: 130643 RVA: 0x009387B4 File Offset: 0x009369B4
		// (set) Token: 0x0601FE54 RID: 130644 RVA: 0x009387F7 File Offset: 0x009369F7
		public FGameplayTagContainer CheckTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CheckTags) == null)
				{
					result = (this._CheckTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_CheckTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_CheckTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0601FE55 RID: 130645 RVA: 0x00938818 File Offset: 0x00936A18
		// (set) Token: 0x0601FE56 RID: 130646 RVA: 0x00938828 File Offset: 0x00936A28
		public unsafe bool CheckHasTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_CheckHasTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_CheckHasTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0601FE57 RID: 130647 RVA: 0x00938839 File Offset: 0x00936A39
		// (set) Token: 0x0601FE58 RID: 130648 RVA: 0x0093884D File Offset: 0x00936A4D
		[Nullable(0)]
		public unsafe TEnumAsByte<ETagLogicType> LogicType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_LogicType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SFollowShooterTagConfig.__PropertyOffset_LogicType) = value;
			}
		}

		// Token: 0x0601FE59 RID: 130649 RVA: 0x00938862 File Offset: 0x00936A62
		public SFollowShooterTagConfig()
		{
		}

		// Token: 0x0601FE5A RID: 130650 RVA: 0x0093886A File Offset: 0x00936A6A
		protected override IntPtr GetUStructPtr()
		{
			return SFollowShooterTagConfig.StaticStruct();
		}

		// Token: 0x0601FE5B RID: 130651 RVA: 0x00938876 File Offset: 0x00936A76
		[NullableContext(2)]
		public SFollowShooterTagConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE5C RID: 130652 RVA: 0x00938880 File Offset: 0x00936A80
		public SFollowShooterTagConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE5D RID: 130653 RVA: 0x0093888B File Offset: 0x00936A8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowShooterTagConfig(Pointer, false, true);
		}

		// Token: 0x0601FE5E RID: 130654 RVA: 0x00938895 File Offset: 0x00936A95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowShooterTagConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401120F RID: 70159
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SFollowShooterTagConfig.SFollowShooterTagConfig";

		// Token: 0x04011210 RID: 70160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011211 RID: 70161
		internal static int __PropertyOffset_AddTags;

		// Token: 0x04011212 RID: 70162
		[Nullable(2)]
		private FGameplayTagContainer _AddTags;

		// Token: 0x04011213 RID: 70163
		internal static int __PropertyOffset_CheckTags;

		// Token: 0x04011214 RID: 70164
		[Nullable(2)]
		private FGameplayTagContainer _CheckTags;

		// Token: 0x04011215 RID: 70165
		internal static int __PropertyOffset_CheckHasTag;

		// Token: 0x04011216 RID: 70166
		internal static int __PropertyOffset_LogicType;
	}
}
