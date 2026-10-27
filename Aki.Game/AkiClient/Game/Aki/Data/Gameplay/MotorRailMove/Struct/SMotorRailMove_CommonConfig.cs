using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F40 RID: 16192
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class SMotorRailMove_CommonConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602936C RID: 168812 RVA: 0x009BE98C File Offset: 0x009BCB8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_CommonConfig._ScriptStructPtr != 0) ? SMotorRailMove_CommonConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig", ref SMotorRailMove_CommonConfig._ScriptStructPtr);
		}

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x0602936D RID: 168813 RVA: 0x009BE9B0 File Offset: 0x009BCBB0
		// (set) Token: 0x0602936E RID: 168814 RVA: 0x009BE9F3 File Offset: 0x009BCBF3
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnEnter) == null)
				{
					result = (this._ModifyVehicleTagsOnEnter = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnEnter.CopyAssign(value);
			}
		}

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x0602936F RID: 168815 RVA: 0x009BEA04 File Offset: 0x009BCC04
		// (set) Token: 0x06029370 RID: 168816 RVA: 0x009BEA47 File Offset: 0x009BCC47
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnExit
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnExit) == null)
				{
					result = (this._ModifyVehicleTagsOnExit = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnExit.CopyAssign(value);
			}
		}

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x06029371 RID: 168817 RVA: 0x009BEA55 File Offset: 0x009BCC55
		// (set) Token: 0x06029372 RID: 168818 RVA: 0x009BEA65 File Offset: 0x009BCC65
		public unsafe bool EnableBlockingCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x06029373 RID: 168819 RVA: 0x009BEA76 File Offset: 0x009BCC76
		// (set) Token: 0x06029374 RID: 168820 RVA: 0x009BEA86 File Offset: 0x009BCC86
		public unsafe float MaxBlockingTimeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029375 RID: 168821 RVA: 0x009BEA97 File Offset: 0x009BCC97
		public SMotorRailMove_CommonConfig()
		{
		}

		// Token: 0x06029376 RID: 168822 RVA: 0x009BEA9F File Offset: 0x009BCC9F
		public SMotorRailMove_CommonConfig(TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnter, TMap<FGameplayTag, bool> ModifyVehicleTagsOnExit, bool EnableBlockingCheck, float MaxBlockingTimeOut)
		{
			this.ModifyVehicleTagsOnEnter = ModifyVehicleTagsOnEnter;
			this.ModifyVehicleTagsOnExit = ModifyVehicleTagsOnExit;
			this.EnableBlockingCheck = EnableBlockingCheck;
			this.MaxBlockingTimeOut = MaxBlockingTimeOut;
		}

		// Token: 0x06029377 RID: 168823 RVA: 0x009BEAC4 File Offset: 0x009BCCC4
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMove_CommonConfig.StaticStruct();
		}

		// Token: 0x06029378 RID: 168824 RVA: 0x009BEAD0 File Offset: 0x009BCCD0
		[NullableContext(2)]
		public SMotorRailMove_CommonConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029379 RID: 168825 RVA: 0x009BEADA File Offset: 0x009BCCDA
		public SMotorRailMove_CommonConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602937A RID: 168826 RVA: 0x009BEAE5 File Offset: 0x009BCCE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMove_CommonConfig(Pointer, false, true);
		}

		// Token: 0x0602937B RID: 168827 RVA: 0x009BEAEF File Offset: 0x009BCCEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMove_CommonConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040151AB RID: 86443
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig";

		// Token: 0x040151AC RID: 86444
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151AD RID: 86445
		internal static int __PropertyOffset_0;

		// Token: 0x040151AE RID: 86446
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnEnter;

		// Token: 0x040151AF RID: 86447
		internal static int __PropertyOffset_1;

		// Token: 0x040151B0 RID: 86448
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnExit;

		// Token: 0x040151B1 RID: 86449
		internal static int __PropertyOffset_2;

		// Token: 0x040151B2 RID: 86450
		internal static int __PropertyOffset_3;
	}
}
