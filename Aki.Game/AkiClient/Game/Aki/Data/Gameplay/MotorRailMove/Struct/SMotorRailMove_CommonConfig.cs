using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031EC RID: 12780
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class SMotorRailMove_CommonConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC91 RID: 130193 RVA: 0x00935A8F File Offset: 0x00933C8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMove_CommonConfig._ScriptStructPtr != 0) ? SMotorRailMove_CommonConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig", ref SMotorRailMove_CommonConfig._ScriptStructPtr);
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0601FC92 RID: 130194 RVA: 0x00935AB4 File Offset: 0x00933CB4
		// (set) Token: 0x0601FC93 RID: 130195 RVA: 0x00935AF7 File Offset: 0x00933CF7
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnEnter) == null)
				{
					result = (this._ModifyVehicleTagsOnEnter = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_ModifyVehicleTagsOnEnter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnEnter.CopyAssign(value);
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0601FC94 RID: 130196 RVA: 0x00935B08 File Offset: 0x00933D08
		// (set) Token: 0x0601FC95 RID: 130197 RVA: 0x00935B4B File Offset: 0x00933D4B
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnExit
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnExit) == null)
				{
					result = (this._ModifyVehicleTagsOnExit = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_ModifyVehicleTagsOnExit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnExit.CopyAssign(value);
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0601FC96 RID: 130198 RVA: 0x00935B59 File Offset: 0x00933D59
		// (set) Token: 0x0601FC97 RID: 130199 RVA: 0x00935B69 File Offset: 0x00933D69
		public unsafe bool EnableBlockingCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_EnableBlockingCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_EnableBlockingCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0601FC98 RID: 130200 RVA: 0x00935B7A File Offset: 0x00933D7A
		// (set) Token: 0x0601FC99 RID: 130201 RVA: 0x00935B8A File Offset: 0x00933D8A
		public unsafe float MaxBlockingTimeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_MaxBlockingTimeOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMove_CommonConfig.__PropertyOffset_MaxBlockingTimeOut) = value;
			}
		}

		// Token: 0x0601FC9A RID: 130202 RVA: 0x00935B9B File Offset: 0x00933D9B
		public SMotorRailMove_CommonConfig()
		{
		}

		// Token: 0x0601FC9B RID: 130203 RVA: 0x00935BA3 File Offset: 0x00933DA3
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMove_CommonConfig.StaticStruct();
		}

		// Token: 0x0601FC9C RID: 130204 RVA: 0x00935BAF File Offset: 0x00933DAF
		[NullableContext(2)]
		public SMotorRailMove_CommonConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC9D RID: 130205 RVA: 0x00935BB9 File Offset: 0x00933DB9
		public SMotorRailMove_CommonConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC9E RID: 130206 RVA: 0x00935BC4 File Offset: 0x00933DC4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMove_CommonConfig(Pointer, false, true);
		}

		// Token: 0x0601FC9F RID: 130207 RVA: 0x00935BCE File Offset: 0x00933DCE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMove_CommonConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040110E7 RID: 69863
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMove_CommonConfig.SMotorRailMove_CommonConfig";

		// Token: 0x040110E8 RID: 69864
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110E9 RID: 69865
		internal static int __PropertyOffset_ModifyVehicleTagsOnEnter;

		// Token: 0x040110EA RID: 69866
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnEnter;

		// Token: 0x040110EB RID: 69867
		internal static int __PropertyOffset_ModifyVehicleTagsOnExit;

		// Token: 0x040110EC RID: 69868
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnExit;

		// Token: 0x040110ED RID: 69869
		internal static int __PropertyOffset_EnableBlockingCheck;

		// Token: 0x040110EE RID: 69870
		internal static int __PropertyOffset_MaxBlockingTimeOut;
	}
}
