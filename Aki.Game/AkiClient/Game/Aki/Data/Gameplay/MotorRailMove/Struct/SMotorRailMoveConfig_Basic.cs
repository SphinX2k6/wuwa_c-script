using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x020031E6 RID: 12774
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 816)]
	public class SMotorRailMoveConfig_Basic : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC25 RID: 130085 RVA: 0x0093507D File Offset: 0x0093327D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_Basic._ScriptStructPtr != 0) ? SMotorRailMoveConfig_Basic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic", ref SMotorRailMoveConfig_Basic._ScriptStructPtr);
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0601FC26 RID: 130086 RVA: 0x009350A1 File Offset: 0x009332A1
		// (set) Token: 0x0601FC27 RID: 130087 RVA: 0x009350B1 File Offset: 0x009332B1
		public unsafe float MaxDeltaTimeForMoveUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_MaxDeltaTimeForMoveUpdate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_MaxDeltaTimeForMoveUpdate) = value;
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0601FC28 RID: 130088 RVA: 0x009350C2 File Offset: 0x009332C2
		// (set) Token: 0x0601FC29 RID: 130089 RVA: 0x009350D2 File Offset: 0x009332D2
		public unsafe float DefaultMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_DefaultMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_DefaultMoveSpeed) = value;
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0601FC2A RID: 130090 RVA: 0x009350E4 File Offset: 0x009332E4
		// (set) Token: 0x0601FC2B RID: 130091 RVA: 0x00935127 File Offset: 0x00933327
		public TSet<int> AllowUseSkillIds
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._AllowUseSkillIds) == null)
				{
					result = (this._AllowUseSkillIds = new TSet<int>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_AllowUseSkillIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllowUseSkillIds.CopyAssign(value);
			}
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0601FC2C RID: 130092 RVA: 0x00935135 File Offset: 0x00933335
		// (set) Token: 0x0601FC2D RID: 130093 RVA: 0x00935145 File Offset: 0x00933345
		public unsafe float AutoEnterRailCdAfterLeaveRailMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_AutoEnterRailCdAfterLeaveRailMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_AutoEnterRailCdAfterLeaveRailMove) = value;
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0601FC2E RID: 130094 RVA: 0x00935156 File Offset: 0x00933356
		// (set) Token: 0x0601FC2F RID: 130095 RVA: 0x00935166 File Offset: 0x00933366
		public unsafe float AutoEnterRailCdAfterLeaveRail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_AutoEnterRailCdAfterLeaveRail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_AutoEnterRailCdAfterLeaveRail) = value;
			}
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0601FC30 RID: 130096 RVA: 0x00935178 File Offset: 0x00933378
		// (set) Token: 0x0601FC31 RID: 130097 RVA: 0x009351BB File Offset: 0x009333BB
		public TMap<FGameplayTag, SMotorRailMove_EventHandler> ClientEventHandlers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SMotorRailMove_EventHandler> result;
				if ((result = this._ClientEventHandlers) == null)
				{
					result = (this._ClientEventHandlers = new TMap<FGameplayTag, SMotorRailMove_EventHandler>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ClientEventHandlers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClientEventHandlers.CopyAssign(value);
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0601FC32 RID: 130098 RVA: 0x009351CC File Offset: 0x009333CC
		// (set) Token: 0x0601FC33 RID: 130099 RVA: 0x0093520F File Offset: 0x0093340F
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnEnterRail) == null)
				{
					result = (this._ModifyVehicleTagsOnEnterRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyVehicleTagsOnEnterRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0601FC34 RID: 130100 RVA: 0x00935220 File Offset: 0x00933420
		// (set) Token: 0x0601FC35 RID: 130101 RVA: 0x00935263 File Offset: 0x00933463
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnLeaveRail) == null)
				{
					result = (this._ModifyVehicleTagsOnLeaveRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyVehicleTagsOnLeaveRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0601FC36 RID: 130102 RVA: 0x00935274 File Offset: 0x00933474
		// (set) Token: 0x0601FC37 RID: 130103 RVA: 0x009352B7 File Offset: 0x009334B7
		public TMap<long, bool> ModifyVehicleBuffsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyVehicleBuffsOnEnterRail) == null)
				{
					result = (this._ModifyVehicleBuffsOnEnterRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyVehicleBuffsOnEnterRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleBuffsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0601FC38 RID: 130104 RVA: 0x009352C8 File Offset: 0x009334C8
		// (set) Token: 0x0601FC39 RID: 130105 RVA: 0x0093530B File Offset: 0x0093350B
		public TMap<long, bool> ModifyVehicleBuffsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyVehicleBuffsOnLeaveRail) == null)
				{
					result = (this._ModifyVehicleBuffsOnLeaveRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyVehicleBuffsOnLeaveRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleBuffsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0601FC3A RID: 130106 RVA: 0x0093531C File Offset: 0x0093351C
		// (set) Token: 0x0601FC3B RID: 130107 RVA: 0x0093535F File Offset: 0x0093355F
		public TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyDriverPlayerTagsOnEnterRail) == null)
				{
					result = (this._ModifyDriverPlayerTagsOnEnterRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyDriverPlayerTagsOnEnterRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverPlayerTagsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0601FC3C RID: 130108 RVA: 0x00935370 File Offset: 0x00933570
		// (set) Token: 0x0601FC3D RID: 130109 RVA: 0x009353B3 File Offset: 0x009335B3
		public TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyDriverPlayerTagsOnLeaveRail) == null)
				{
					result = (this._ModifyDriverPlayerTagsOnLeaveRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyDriverPlayerTagsOnLeaveRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverPlayerTagsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0601FC3E RID: 130110 RVA: 0x009353C4 File Offset: 0x009335C4
		// (set) Token: 0x0601FC3F RID: 130111 RVA: 0x00935407 File Offset: 0x00933607
		public TMap<long, bool> ModifyDriverBuffsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyDriverBuffsOnEnterRail) == null)
				{
					result = (this._ModifyDriverBuffsOnEnterRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyDriverBuffsOnEnterRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverBuffsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0601FC40 RID: 130112 RVA: 0x00935418 File Offset: 0x00933618
		// (set) Token: 0x0601FC41 RID: 130113 RVA: 0x0093545B File Offset: 0x0093365B
		public TMap<long, bool> ModifyDriverBuffsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyDriverBuffsOnLeaveRail) == null)
				{
					result = (this._ModifyDriverBuffsOnLeaveRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_ModifyDriverBuffsOnLeaveRail, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverBuffsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x0601FC42 RID: 130114 RVA: 0x00935469 File Offset: 0x00933669
		public SMotorRailMoveConfig_Basic()
		{
		}

		// Token: 0x0601FC43 RID: 130115 RVA: 0x00935471 File Offset: 0x00933671
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_Basic.StaticStruct();
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x0093547D File Offset: 0x0093367D
		[NullableContext(2)]
		public SMotorRailMoveConfig_Basic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC45 RID: 130117 RVA: 0x00935487 File Offset: 0x00933687
		public SMotorRailMoveConfig_Basic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC46 RID: 130118 RVA: 0x00935492 File Offset: 0x00933692
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_Basic(Pointer, false, true);
		}

		// Token: 0x0601FC47 RID: 130119 RVA: 0x0093549C File Offset: 0x0093369C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_Basic(Pointer, MemoryOwner);
		}

		// Token: 0x040110AB RID: 69803
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic";

		// Token: 0x040110AC RID: 69804
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040110AD RID: 69805
		internal static int __PropertyOffset_MaxDeltaTimeForMoveUpdate;

		// Token: 0x040110AE RID: 69806
		internal static int __PropertyOffset_DefaultMoveSpeed;

		// Token: 0x040110AF RID: 69807
		internal static int __PropertyOffset_AllowUseSkillIds;

		// Token: 0x040110B0 RID: 69808
		[Nullable(2)]
		private TSet<int> _AllowUseSkillIds;

		// Token: 0x040110B1 RID: 69809
		internal static int __PropertyOffset_AutoEnterRailCdAfterLeaveRailMove;

		// Token: 0x040110B2 RID: 69810
		internal static int __PropertyOffset_AutoEnterRailCdAfterLeaveRail;

		// Token: 0x040110B3 RID: 69811
		internal static int __PropertyOffset_ClientEventHandlers;

		// Token: 0x040110B4 RID: 69812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SMotorRailMove_EventHandler> _ClientEventHandlers;

		// Token: 0x040110B5 RID: 69813
		internal static int __PropertyOffset_ModifyVehicleTagsOnEnterRail;

		// Token: 0x040110B6 RID: 69814
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnEnterRail;

		// Token: 0x040110B7 RID: 69815
		internal static int __PropertyOffset_ModifyVehicleTagsOnLeaveRail;

		// Token: 0x040110B8 RID: 69816
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnLeaveRail;

		// Token: 0x040110B9 RID: 69817
		internal static int __PropertyOffset_ModifyVehicleBuffsOnEnterRail;

		// Token: 0x040110BA RID: 69818
		[Nullable(2)]
		private TMap<long, bool> _ModifyVehicleBuffsOnEnterRail;

		// Token: 0x040110BB RID: 69819
		internal static int __PropertyOffset_ModifyVehicleBuffsOnLeaveRail;

		// Token: 0x040110BC RID: 69820
		[Nullable(2)]
		private TMap<long, bool> _ModifyVehicleBuffsOnLeaveRail;

		// Token: 0x040110BD RID: 69821
		internal static int __PropertyOffset_ModifyDriverPlayerTagsOnEnterRail;

		// Token: 0x040110BE RID: 69822
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyDriverPlayerTagsOnEnterRail;

		// Token: 0x040110BF RID: 69823
		internal static int __PropertyOffset_ModifyDriverPlayerTagsOnLeaveRail;

		// Token: 0x040110C0 RID: 69824
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyDriverPlayerTagsOnLeaveRail;

		// Token: 0x040110C1 RID: 69825
		internal static int __PropertyOffset_ModifyDriverBuffsOnEnterRail;

		// Token: 0x040110C2 RID: 69826
		[Nullable(2)]
		private TMap<long, bool> _ModifyDriverBuffsOnEnterRail;

		// Token: 0x040110C3 RID: 69827
		internal static int __PropertyOffset_ModifyDriverBuffsOnLeaveRail;

		// Token: 0x040110C4 RID: 69828
		[Nullable(2)]
		private TMap<long, bool> _ModifyDriverBuffsOnLeaveRail;
	}
}
