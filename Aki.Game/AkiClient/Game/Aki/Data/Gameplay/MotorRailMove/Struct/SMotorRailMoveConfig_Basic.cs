using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct
{
	// Token: 0x02003F3A RID: 16186
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 816)]
	public class SMotorRailMoveConfig_Basic : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060292FA RID: 168698 RVA: 0x009BDE4B File Offset: 0x009BC04B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMotorRailMoveConfig_Basic._ScriptStructPtr != 0) ? SMotorRailMoveConfig_Basic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic", ref SMotorRailMoveConfig_Basic._ScriptStructPtr);
		}

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x060292FB RID: 168699 RVA: 0x009BDE6F File Offset: 0x009BC06F
		// (set) Token: 0x060292FC RID: 168700 RVA: 0x009BDE7F File Offset: 0x009BC07F
		public unsafe float MaxDeltaTimeForMoveUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x060292FD RID: 168701 RVA: 0x009BDE90 File Offset: 0x009BC090
		// (set) Token: 0x060292FE RID: 168702 RVA: 0x009BDEA0 File Offset: 0x009BC0A0
		public unsafe float DefaultMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x060292FF RID: 168703 RVA: 0x009BDEB4 File Offset: 0x009BC0B4
		// (set) Token: 0x06029300 RID: 168704 RVA: 0x009BDEF7 File Offset: 0x009BC0F7
		public TSet<int> AllowUseSkillIds
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._AllowUseSkillIds) == null)
				{
					result = (this._AllowUseSkillIds = new TSet<int>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllowUseSkillIds.CopyAssign(value);
			}
		}

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x06029301 RID: 168705 RVA: 0x009BDF05 File Offset: 0x009BC105
		// (set) Token: 0x06029302 RID: 168706 RVA: 0x009BDF15 File Offset: 0x009BC115
		public unsafe float AutoEnterRailCdAfterLeaveRailMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x06029303 RID: 168707 RVA: 0x009BDF26 File Offset: 0x009BC126
		// (set) Token: 0x06029304 RID: 168708 RVA: 0x009BDF36 File Offset: 0x009BC136
		public unsafe float AutoEnterRailCdAfterLeaveRail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x06029305 RID: 168709 RVA: 0x009BDF48 File Offset: 0x009BC148
		// (set) Token: 0x06029306 RID: 168710 RVA: 0x009BDF8B File Offset: 0x009BC18B
		public TMap<FGameplayTag, SMotorRailMove_EventHandler> ClientEventHandlers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SMotorRailMove_EventHandler> result;
				if ((result = this._ClientEventHandlers) == null)
				{
					result = (this._ClientEventHandlers = new TMap<FGameplayTag, SMotorRailMove_EventHandler>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClientEventHandlers.CopyAssign(value);
			}
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x06029307 RID: 168711 RVA: 0x009BDF9C File Offset: 0x009BC19C
		// (set) Token: 0x06029308 RID: 168712 RVA: 0x009BDFDF File Offset: 0x009BC1DF
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnEnterRail) == null)
				{
					result = (this._ModifyVehicleTagsOnEnterRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17006205 RID: 25093
		// (get) Token: 0x06029309 RID: 168713 RVA: 0x009BDFF0 File Offset: 0x009BC1F0
		// (set) Token: 0x0602930A RID: 168714 RVA: 0x009BE033 File Offset: 0x009BC233
		public TMap<FGameplayTag, bool> ModifyVehicleTagsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyVehicleTagsOnLeaveRail) == null)
				{
					result = (this._ModifyVehicleTagsOnLeaveRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleTagsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x17006206 RID: 25094
		// (get) Token: 0x0602930B RID: 168715 RVA: 0x009BE044 File Offset: 0x009BC244
		// (set) Token: 0x0602930C RID: 168716 RVA: 0x009BE087 File Offset: 0x009BC287
		public TMap<long, bool> ModifyVehicleBuffsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyVehicleBuffsOnEnterRail) == null)
				{
					result = (this._ModifyVehicleBuffsOnEnterRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleBuffsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x0602930D RID: 168717 RVA: 0x009BE098 File Offset: 0x009BC298
		// (set) Token: 0x0602930E RID: 168718 RVA: 0x009BE0DB File Offset: 0x009BC2DB
		public TMap<long, bool> ModifyVehicleBuffsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyVehicleBuffsOnLeaveRail) == null)
				{
					result = (this._ModifyVehicleBuffsOnLeaveRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyVehicleBuffsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x0602930F RID: 168719 RVA: 0x009BE0EC File Offset: 0x009BC2EC
		// (set) Token: 0x06029310 RID: 168720 RVA: 0x009BE12F File Offset: 0x009BC32F
		public TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyDriverPlayerTagsOnEnterRail) == null)
				{
					result = (this._ModifyDriverPlayerTagsOnEnterRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverPlayerTagsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x06029311 RID: 168721 RVA: 0x009BE140 File Offset: 0x009BC340
		// (set) Token: 0x06029312 RID: 168722 RVA: 0x009BE183 File Offset: 0x009BC383
		public TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, bool> result;
				if ((result = this._ModifyDriverPlayerTagsOnLeaveRail) == null)
				{
					result = (this._ModifyDriverPlayerTagsOnLeaveRail = new TMap<FGameplayTag, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverPlayerTagsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x1700620A RID: 25098
		// (get) Token: 0x06029313 RID: 168723 RVA: 0x009BE194 File Offset: 0x009BC394
		// (set) Token: 0x06029314 RID: 168724 RVA: 0x009BE1D7 File Offset: 0x009BC3D7
		public TMap<long, bool> ModifyDriverBuffsOnEnterRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyDriverBuffsOnEnterRail) == null)
				{
					result = (this._ModifyDriverBuffsOnEnterRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverBuffsOnEnterRail.CopyAssign(value);
			}
		}

		// Token: 0x1700620B RID: 25099
		// (get) Token: 0x06029315 RID: 168725 RVA: 0x009BE1E8 File Offset: 0x009BC3E8
		// (set) Token: 0x06029316 RID: 168726 RVA: 0x009BE22B File Offset: 0x009BC42B
		public TMap<long, bool> ModifyDriverBuffsOnLeaveRail
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, bool> result;
				if ((result = this._ModifyDriverBuffsOnLeaveRail) == null)
				{
					result = (this._ModifyDriverBuffsOnLeaveRail = new TMap<long, bool>(base.NativePtr + (IntPtr)SMotorRailMoveConfig_Basic.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifyDriverBuffsOnLeaveRail.CopyAssign(value);
			}
		}

		// Token: 0x06029317 RID: 168727 RVA: 0x009BE239 File Offset: 0x009BC439
		public SMotorRailMoveConfig_Basic()
		{
		}

		// Token: 0x06029318 RID: 168728 RVA: 0x009BE244 File Offset: 0x009BC444
		public SMotorRailMoveConfig_Basic(float MaxDeltaTimeForMoveUpdate, float DefaultMoveSpeed, TSet<int> AllowUseSkillIds, float AutoEnterRailCdAfterLeaveRailMove, float AutoEnterRailCdAfterLeaveRail, TMap<FGameplayTag, SMotorRailMove_EventHandler> ClientEventHandlers, TMap<FGameplayTag, bool> ModifyVehicleTagsOnEnterRail, TMap<FGameplayTag, bool> ModifyVehicleTagsOnLeaveRail, TMap<long, bool> ModifyVehicleBuffsOnEnterRail, TMap<long, bool> ModifyVehicleBuffsOnLeaveRail, TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnEnterRail, TMap<FGameplayTag, bool> ModifyDriverPlayerTagsOnLeaveRail, TMap<long, bool> ModifyDriverBuffsOnEnterRail, TMap<long, bool> ModifyDriverBuffsOnLeaveRail)
		{
			this.MaxDeltaTimeForMoveUpdate = MaxDeltaTimeForMoveUpdate;
			this.DefaultMoveSpeed = DefaultMoveSpeed;
			this.AllowUseSkillIds = AllowUseSkillIds;
			this.AutoEnterRailCdAfterLeaveRailMove = AutoEnterRailCdAfterLeaveRailMove;
			this.AutoEnterRailCdAfterLeaveRail = AutoEnterRailCdAfterLeaveRail;
			this.ClientEventHandlers = ClientEventHandlers;
			this.ModifyVehicleTagsOnEnterRail = ModifyVehicleTagsOnEnterRail;
			this.ModifyVehicleTagsOnLeaveRail = ModifyVehicleTagsOnLeaveRail;
			this.ModifyVehicleBuffsOnEnterRail = ModifyVehicleBuffsOnEnterRail;
			this.ModifyVehicleBuffsOnLeaveRail = ModifyVehicleBuffsOnLeaveRail;
			this.ModifyDriverPlayerTagsOnEnterRail = ModifyDriverPlayerTagsOnEnterRail;
			this.ModifyDriverPlayerTagsOnLeaveRail = ModifyDriverPlayerTagsOnLeaveRail;
			this.ModifyDriverBuffsOnEnterRail = ModifyDriverBuffsOnEnterRail;
			this.ModifyDriverBuffsOnLeaveRail = ModifyDriverBuffsOnLeaveRail;
		}

		// Token: 0x06029319 RID: 168729 RVA: 0x009BE2C4 File Offset: 0x009BC4C4
		protected override IntPtr GetUStructPtr()
		{
			return SMotorRailMoveConfig_Basic.StaticStruct();
		}

		// Token: 0x0602931A RID: 168730 RVA: 0x009BE2D0 File Offset: 0x009BC4D0
		[NullableContext(2)]
		public SMotorRailMoveConfig_Basic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602931B RID: 168731 RVA: 0x009BE2DA File Offset: 0x009BC4DA
		public SMotorRailMoveConfig_Basic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602931C RID: 168732 RVA: 0x009BE2E5 File Offset: 0x009BC4E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMotorRailMoveConfig_Basic(Pointer, false, true);
		}

		// Token: 0x0602931D RID: 168733 RVA: 0x009BE2EF File Offset: 0x009BC4EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMotorRailMoveConfig_Basic(Pointer, MemoryOwner);
		}

		// Token: 0x0401516F RID: 86383
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/MotorRailMove/Struct/SMotorRailMoveConfig_Basic.SMotorRailMoveConfig_Basic";

		// Token: 0x04015170 RID: 86384
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015171 RID: 86385
		internal static int __PropertyOffset_0;

		// Token: 0x04015172 RID: 86386
		internal static int __PropertyOffset_1;

		// Token: 0x04015173 RID: 86387
		internal static int __PropertyOffset_2;

		// Token: 0x04015174 RID: 86388
		[Nullable(2)]
		private TSet<int> _AllowUseSkillIds;

		// Token: 0x04015175 RID: 86389
		internal static int __PropertyOffset_3;

		// Token: 0x04015176 RID: 86390
		internal static int __PropertyOffset_4;

		// Token: 0x04015177 RID: 86391
		internal static int __PropertyOffset_5;

		// Token: 0x04015178 RID: 86392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SMotorRailMove_EventHandler> _ClientEventHandlers;

		// Token: 0x04015179 RID: 86393
		internal static int __PropertyOffset_6;

		// Token: 0x0401517A RID: 86394
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnEnterRail;

		// Token: 0x0401517B RID: 86395
		internal static int __PropertyOffset_7;

		// Token: 0x0401517C RID: 86396
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyVehicleTagsOnLeaveRail;

		// Token: 0x0401517D RID: 86397
		internal static int __PropertyOffset_8;

		// Token: 0x0401517E RID: 86398
		[Nullable(2)]
		private TMap<long, bool> _ModifyVehicleBuffsOnEnterRail;

		// Token: 0x0401517F RID: 86399
		internal static int __PropertyOffset_9;

		// Token: 0x04015180 RID: 86400
		[Nullable(2)]
		private TMap<long, bool> _ModifyVehicleBuffsOnLeaveRail;

		// Token: 0x04015181 RID: 86401
		internal static int __PropertyOffset_10;

		// Token: 0x04015182 RID: 86402
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyDriverPlayerTagsOnEnterRail;

		// Token: 0x04015183 RID: 86403
		internal static int __PropertyOffset_11;

		// Token: 0x04015184 RID: 86404
		[Nullable(2)]
		private TMap<FGameplayTag, bool> _ModifyDriverPlayerTagsOnLeaveRail;

		// Token: 0x04015185 RID: 86405
		internal static int __PropertyOffset_12;

		// Token: 0x04015186 RID: 86406
		[Nullable(2)]
		private TMap<long, bool> _ModifyDriverBuffsOnEnterRail;

		// Token: 0x04015187 RID: 86407
		internal static int __PropertyOffset_13;

		// Token: 0x04015188 RID: 86408
		[Nullable(2)]
		private TMap<long, bool> _ModifyDriverBuffsOnLeaveRail;
	}
}
