using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594E RID: 22862
	public struct IHookLockPoint : IFlatbufferObject
	{
		// Token: 0x1700A5E1 RID: 42465
		// (get) Token: 0x06025364 RID: 152420 RVA: 0x0051B398 File Offset: 0x00519598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025365 RID: 152421 RVA: 0x0051B3A5 File Offset: 0x005195A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025366 RID: 152422 RVA: 0x0051B3AC File Offset: 0x005195AC
		public static IHookLockPoint GetRootAsIHookLockPoint(ByteBuffer _bb)
		{
			return IHookLockPoint.GetRootAsIHookLockPoint(_bb, default(IHookLockPoint));
		}

		// Token: 0x06025367 RID: 152423 RVA: 0x0051B3C8 File Offset: 0x005195C8
		public static IHookLockPoint GetRootAsIHookLockPoint(ByteBuffer _bb, IHookLockPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025368 RID: 152424 RVA: 0x0051B3E5 File Offset: 0x005195E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025369 RID: 152425 RVA: 0x0051B3F4 File Offset: 0x005195F4
		public IHookLockPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5E2 RID: 42466
		// (get) Token: 0x0602536A RID: 152426 RVA: 0x0051B404 File Offset: 0x00519604
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5E3 RID: 42467
		// (get) Token: 0x0602536B RID: 152427 RVA: 0x0051B444 File Offset: 0x00519644
		public ISphereTriggerShape? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISphereTriggerShape?(default(ISphereTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5E4 RID: 42468
		// (get) Token: 0x0602536C RID: 152428 RVA: 0x0051B4A4 File Offset: 0x005196A4
		public float NonInteractiveInnerRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602536D RID: 152429 RVA: 0x0051B4E4 File Offset: 0x005196E4
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A5E5 RID: 42469
		// (get) Token: 0x0602536E RID: 152430 RVA: 0x0051B524 File Offset: 0x00519724
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602536F RID: 152431 RVA: 0x0051B550 File Offset: 0x00519750
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(10, 1);
		}

		// Token: 0x06025370 RID: 152432 RVA: 0x0051B560 File Offset: 0x00519760
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06025371 RID: 152433 RVA: 0x0051B5CC File Offset: 0x005197CC
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A5E6 RID: 42470
		// (get) Token: 0x06025372 RID: 152434 RVA: 0x0051B614 File Offset: 0x00519814
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A5E7 RID: 42471
		// (get) Token: 0x06025373 RID: 152435 RVA: 0x0051B640 File Offset: 0x00519840
		public bool IgnorePlayCollision
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5E8 RID: 42472
		// (get) Token: 0x06025374 RID: 152436 RVA: 0x0051B680 File Offset: 0x00519880
		public bool UseRangeComponent
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5E9 RID: 42473
		// (get) Token: 0x06025375 RID: 152437 RVA: 0x0051B6C0 File Offset: 0x005198C0
		public ICameraGaze? CameraGaze
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new ICameraGaze?(default(ICameraGaze).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5EA RID: 42474
		// (get) Token: 0x06025376 RID: 152438 RVA: 0x0051B720 File Offset: 0x00519920
		public IGazeNextPointAfterInteract? GazeNextPointAfterInteract
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IGazeNextPointAfterInteract?(default(IGazeNextPointAfterInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5EB RID: 42475
		// (get) Token: 0x06025377 RID: 152439 RVA: 0x0051B780 File Offset: 0x00519980
		public bool InheritSpeed
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5EC RID: 42476
		// (get) Token: 0x06025378 RID: 152440 RVA: 0x0051B7C0 File Offset: 0x005199C0
		public string NormalEffect
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025379 RID: 152441 RVA: 0x0051B7F8 File Offset: 0x005199F8
		public Span<byte> GetNormalEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0602537A RID: 152442 RVA: 0x0051B808 File Offset: 0x00519A08
		public byte[] GetNormalEffectArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x1700A5ED RID: 42477
		// (get) Token: 0x0602537B RID: 152443 RVA: 0x0051B818 File Offset: 0x00519A18
		public bool IsClimb
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5EE RID: 42478
		// (get) Token: 0x0602537C RID: 152444 RVA: 0x0051B858 File Offset: 0x00519A58
		public int PlayerStateRestritionId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5EF RID: 42479
		// (get) Token: 0x0602537D RID: 152445 RVA: 0x0051B898 File Offset: 0x00519A98
		public IConditionGroup? HookEnableCondition
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5F0 RID: 42480
		// (get) Token: 0x0602537E RID: 152446 RVA: 0x0051B8F8 File Offset: 0x00519AF8
		public float HookLockCd
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5F1 RID: 42481
		// (get) Token: 0x0602537F RID: 152447 RVA: 0x0051B93C File Offset: 0x00519B3C
		public bool IsDestroyedSelf
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5F2 RID: 42482
		// (get) Token: 0x06025380 RID: 152448 RVA: 0x0051B97C File Offset: 0x00519B7C
		public bool IsHideSelf
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5F3 RID: 42483
		// (get) Token: 0x06025381 RID: 152449 RVA: 0x0051B9BC File Offset: 0x00519BBC
		public THookLockScreenDetectType ScreenDetectTypeType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return THookLockScreenDetectType.NONE;
				}
				return (THookLockScreenDetectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025382 RID: 152450 RVA: 0x0051B9FC File Offset: 0x00519BFC
		public TTable? ScreenDetectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025383 RID: 152451 RVA: 0x0051BA44 File Offset: 0x00519C44
		public IHookLockScreenDetectTypeCentralEllipse ScreenDetectTypeAsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value;
		}

		// Token: 0x06025384 RID: 152452 RVA: 0x0051BA60 File Offset: 0x00519C60
		public IHookLockScreenDetectTypeFullScreen ScreenDetectTypeAsIHookLockScreenDetectTypeFullScreen()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value;
		}

		// Token: 0x1700A5F4 RID: 42484
		// (get) Token: 0x06025385 RID: 152453 RVA: 0x0051BA7C File Offset: 0x00519C7C
		public THookInteractConfig HookInteractConfigType
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return THookInteractConfig.NONE;
				}
				return (THookInteractConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025386 RID: 152454 RVA: 0x0051BABC File Offset: 0x00519CBC
		public TTable? HookInteractConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025387 RID: 152455 RVA: 0x0051BB04 File Offset: 0x00519D04
		public ICableWay HookInteractConfigAsICableWay()
		{
			return this.HookInteractConfig<ICableWay>().Value;
		}

		// Token: 0x06025388 RID: 152456 RVA: 0x0051BB20 File Offset: 0x00519D20
		public IChargeSlashHook HookInteractConfigAsIChargeSlashHook()
		{
			return this.HookInteractConfig<IChargeSlashHook>().Value;
		}

		// Token: 0x06025389 RID: 152457 RVA: 0x0051BB3C File Offset: 0x00519D3C
		public IChongLouHook HookInteractConfigAsIChongLouHook()
		{
			return this.HookInteractConfig<IChongLouHook>().Value;
		}

		// Token: 0x0602538A RID: 152458 RVA: 0x0051BB58 File Offset: 0x00519D58
		public IFixedPointHook HookInteractConfigAsIFixedPointHook()
		{
			return this.HookInteractConfig<IFixedPointHook>().Value;
		}

		// Token: 0x0602538B RID: 152459 RVA: 0x0051BB74 File Offset: 0x00519D74
		public IFlyingFeather HookInteractConfigAsIFlyingFeather()
		{
			return this.HookInteractConfig<IFlyingFeather>().Value;
		}

		// Token: 0x0602538C RID: 152460 RVA: 0x0051BB90 File Offset: 0x00519D90
		public IFollowerShoot HookInteractConfigAsIFollowerShoot()
		{
			return this.HookInteractConfig<IFollowerShoot>().Value;
		}

		// Token: 0x0602538D RID: 152461 RVA: 0x0051BBAC File Offset: 0x00519DAC
		public IFoxJumpingPoint HookInteractConfigAsIFoxJumpingPoint()
		{
			return this.HookInteractConfig<IFoxJumpingPoint>().Value;
		}

		// Token: 0x0602538E RID: 152462 RVA: 0x0051BBC8 File Offset: 0x00519DC8
		public IGravityHook HookInteractConfigAsIGravityHook()
		{
			return this.HookInteractConfig<IGravityHook>().Value;
		}

		// Token: 0x0602538F RID: 152463 RVA: 0x0051BBE4 File Offset: 0x00519DE4
		public IHookSpaceStationEnergyCore HookInteractConfigAsIHookSpaceStationEnergyCore()
		{
			return this.HookInteractConfig<IHookSpaceStationEnergyCore>().Value;
		}

		// Token: 0x06025390 RID: 152464 RVA: 0x0051BC00 File Offset: 0x00519E00
		public IKiteHook HookInteractConfigAsIKiteHook()
		{
			return this.HookInteractConfig<IKiteHook>().Value;
		}

		// Token: 0x06025391 RID: 152465 RVA: 0x0051BC1C File Offset: 0x00519E1C
		public IMechTransformHook HookInteractConfigAsIMechTransformHook()
		{
			return this.HookInteractConfig<IMechTransformHook>().Value;
		}

		// Token: 0x06025392 RID: 152466 RVA: 0x0051BC38 File Offset: 0x00519E38
		public IMotorEjectHook HookInteractConfigAsIMotorEjectHook()
		{
			return this.HookInteractConfig<IMotorEjectHook>().Value;
		}

		// Token: 0x06025393 RID: 152467 RVA: 0x0051BC54 File Offset: 0x00519E54
		public IMotorPullInteract HookInteractConfigAsIMotorPullInteract()
		{
			return this.HookInteractConfig<IMotorPullInteract>().Value;
		}

		// Token: 0x06025394 RID: 152468 RVA: 0x0051BC70 File Offset: 0x00519E70
		public IMovementPointHook HookInteractConfigAsIMovementPointHook()
		{
			return this.HookInteractConfig<IMovementPointHook>().Value;
		}

		// Token: 0x06025395 RID: 152469 RVA: 0x0051BC8C File Offset: 0x00519E8C
		public IPilotThrow HookInteractConfigAsIPilotThrow()
		{
			return this.HookInteractConfig<IPilotThrow>().Value;
		}

		// Token: 0x06025396 RID: 152470 RVA: 0x0051BCA8 File Offset: 0x00519EA8
		public IRagDollClimbingPoint HookInteractConfigAsIRagDollClimbingPoint()
		{
			return this.HookInteractConfig<IRagDollClimbingPoint>().Value;
		}

		// Token: 0x06025397 RID: 152471 RVA: 0x0051BCC4 File Offset: 0x00519EC4
		public IRagDollJumpingPoint HookInteractConfigAsIRagDollJumpingPoint()
		{
			return this.HookInteractConfig<IRagDollJumpingPoint>().Value;
		}

		// Token: 0x06025398 RID: 152472 RVA: 0x0051BCE0 File Offset: 0x00519EE0
		public ISlashHook HookInteractConfigAsISlashHook()
		{
			return this.HookInteractConfig<ISlashHook>().Value;
		}

		// Token: 0x06025399 RID: 152473 RVA: 0x0051BCFC File Offset: 0x00519EFC
		public ISuiGuangHook HookInteractConfigAsISuiGuangHook()
		{
			return this.HookInteractConfig<ISuiGuangHook>().Value;
		}

		// Token: 0x0602539A RID: 152474 RVA: 0x0051BD18 File Offset: 0x00519F18
		public ISunSpiritLauncher HookInteractConfigAsISunSpiritLauncher()
		{
			return this.HookInteractConfig<ISunSpiritLauncher>().Value;
		}

		// Token: 0x0602539B RID: 152475 RVA: 0x0051BD34 File Offset: 0x00519F34
		public IWaterBoxBigWeaponHook HookInteractConfigAsIWaterBoxBigWeaponHook()
		{
			return this.HookInteractConfig<IWaterBoxBigWeaponHook>().Value;
		}

		// Token: 0x1700A5F5 RID: 42485
		// (get) Token: 0x0602539C RID: 152476 RVA: 0x0051BD50 File Offset: 0x00519F50
		public IMechHookInteractConfig? MechHookInteractConfig
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IMechHookInteractConfig?(default(IMechHookInteractConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5F6 RID: 42486
		// (get) Token: 0x0602539D RID: 152477 RVA: 0x0051BDB0 File Offset: 0x00519FB0
		public IMotorHookConfig? MotorHookConfig
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IMotorHookConfig?(default(IMotorHookConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5F7 RID: 42487
		// (get) Token: 0x0602539E RID: 152478 RVA: 0x0051BE10 File Offset: 0x0051A010
		public IHookGravityConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new IHookGravityConfig?(default(IHookGravityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5F8 RID: 42488
		// (get) Token: 0x0602539F RID: 152479 RVA: 0x0051BE70 File Offset: 0x0051A070
		public bool DisableAtCreateStage
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5F9 RID: 42489
		// (get) Token: 0x060253A0 RID: 152480 RVA: 0x0051BEB0 File Offset: 0x0051A0B0
		public IHookPerformanceConfig? HookPerformanceConfig
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IHookPerformanceConfig?(default(IHookPerformanceConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5FA RID: 42490
		// (get) Token: 0x060253A1 RID: 152481 RVA: 0x0051BF10 File Offset: 0x0051A110
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060253A2 RID: 152482 RVA: 0x0051BF50 File Offset: 0x0051A150
		public static Offset<IHookLockPoint> CreateIHookLockPoint(FlatBufferBuilder builder, bool Disabled = false, Offset<ISphereTriggerShape> RangeOffset = default(Offset<ISphereTriggerShape>), float NonInteractiveInnerRadius = 0f, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), bool IgnorePlayCollision = false, bool UseRangeComponent = false, Offset<ICameraGaze> CameraGazeOffset = default(Offset<ICameraGaze>), Offset<IGazeNextPointAfterInteract> GazeNextPointAfterInteractOffset = default(Offset<IGazeNextPointAfterInteract>), bool InheritSpeed = false, StringOffset NormalEffectOffset = default(StringOffset), bool IsClimb = false, int PlayerStateRestritionId = 0, Offset<IConditionGroup> HookEnableConditionOffset = default(Offset<IConditionGroup>), float HookLockCd = 0f, bool IsDestroyedSelf = false, bool IsHideSelf = false, THookLockScreenDetectType ScreenDetectType_type = THookLockScreenDetectType.NONE, int ScreenDetectTypeOffset = 0, THookInteractConfig HookInteractConfig_type = THookInteractConfig.NONE, int HookInteractConfigOffset = 0, Offset<IMechHookInteractConfig> MechHookInteractConfigOffset = default(Offset<IMechHookInteractConfig>), Offset<IMotorHookConfig> MotorHookConfigOffset = default(Offset<IMotorHookConfig>), Offset<IHookGravityConfig> GravityConfigOffset = default(Offset<IHookGravityConfig>), bool DisableAtCreateStage = false, Offset<IHookPerformanceConfig> HookPerformanceConfigOffset = default(Offset<IHookPerformanceConfig>), ushort NullMask = 0)
		{
			builder.StartTable(27);
			IHookLockPoint.AddHookPerformanceConfig(builder, HookPerformanceConfigOffset);
			IHookLockPoint.AddGravityConfig(builder, GravityConfigOffset);
			IHookLockPoint.AddMotorHookConfig(builder, MotorHookConfigOffset);
			IHookLockPoint.AddMechHookInteractConfig(builder, MechHookInteractConfigOffset);
			IHookLockPoint.AddHookInteractConfig(builder, HookInteractConfigOffset);
			IHookLockPoint.AddScreenDetectType(builder, ScreenDetectTypeOffset);
			IHookLockPoint.AddHookLockCd(builder, HookLockCd);
			IHookLockPoint.AddHookEnableCondition(builder, HookEnableConditionOffset);
			IHookLockPoint.AddPlayerStateRestritionId(builder, PlayerStateRestritionId);
			IHookLockPoint.AddNormalEffect(builder, NormalEffectOffset);
			IHookLockPoint.AddGazeNextPointAfterInteract(builder, GazeNextPointAfterInteractOffset);
			IHookLockPoint.AddCameraGaze(builder, CameraGazeOffset);
			IHookLockPoint.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			IHookLockPoint.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			IHookLockPoint.AddNonInteractiveInnerRadius(builder, NonInteractiveInnerRadius);
			IHookLockPoint.AddRange(builder, RangeOffset);
			IHookLockPoint.AddNullMask(builder, NullMask);
			IHookLockPoint.AddDisableAtCreateStage(builder, DisableAtCreateStage);
			IHookLockPoint.AddHookInteractConfigType(builder, HookInteractConfig_type);
			IHookLockPoint.AddScreenDetectTypeType(builder, ScreenDetectType_type);
			IHookLockPoint.AddIsHideSelf(builder, IsHideSelf);
			IHookLockPoint.AddIsDestroyedSelf(builder, IsDestroyedSelf);
			IHookLockPoint.AddIsClimb(builder, IsClimb);
			IHookLockPoint.AddInheritSpeed(builder, InheritSpeed);
			IHookLockPoint.AddUseRangeComponent(builder, UseRangeComponent);
			IHookLockPoint.AddIgnorePlayCollision(builder, IgnorePlayCollision);
			IHookLockPoint.AddDisabled(builder, Disabled);
			return IHookLockPoint.EndIHookLockPoint(builder);
		}

		// Token: 0x060253A3 RID: 152483 RVA: 0x0051C040 File Offset: 0x0051A240
		public static void StartIHookLockPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(27);
		}

		// Token: 0x060253A4 RID: 152484 RVA: 0x0051C04A File Offset: 0x0051A24A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060253A5 RID: 152485 RVA: 0x0051C055 File Offset: 0x0051A255
		public static void AddRange(FlatBufferBuilder builder, Offset<ISphereTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x060253A6 RID: 152486 RVA: 0x0051C065 File Offset: 0x0051A265
		public static void AddNonInteractiveInnerRadius(FlatBufferBuilder builder, float nonInteractiveInnerRadius)
		{
			builder.AddFloat(2, nonInteractiveInnerRadius, 0.0);
		}

		// Token: 0x060253A7 RID: 152487 RVA: 0x0051C078 File Offset: 0x0051A278
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(3, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060253A8 RID: 152488 RVA: 0x0051C088 File Offset: 0x0051A288
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060253A9 RID: 152489 RVA: 0x0051C0BF File Offset: 0x0051A2BF
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060253AA RID: 152490 RVA: 0x0051C0D9 File Offset: 0x0051A2D9
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060253AB RID: 152491 RVA: 0x0051C0F7 File Offset: 0x0051A2F7
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060253AC RID: 152492 RVA: 0x0051C110 File Offset: 0x0051A310
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060253AD RID: 152493 RVA: 0x0051C11B File Offset: 0x0051A31B
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(4, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x060253AE RID: 152494 RVA: 0x0051C12C File Offset: 0x0051A32C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060253AF RID: 152495 RVA: 0x0051C163 File Offset: 0x0051A363
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060253B0 RID: 152496 RVA: 0x0051C17D File Offset: 0x0051A37D
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060253B1 RID: 152497 RVA: 0x0051C19B File Offset: 0x0051A39B
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060253B2 RID: 152498 RVA: 0x0051C1B4 File Offset: 0x0051A3B4
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060253B3 RID: 152499 RVA: 0x0051C1BF File Offset: 0x0051A3BF
		public static void AddIgnorePlayCollision(FlatBufferBuilder builder, bool ignorePlayCollision)
		{
			builder.AddBool(5, ignorePlayCollision, false);
		}

		// Token: 0x060253B4 RID: 152500 RVA: 0x0051C1CA File Offset: 0x0051A3CA
		public static void AddUseRangeComponent(FlatBufferBuilder builder, bool useRangeComponent)
		{
			builder.AddBool(6, useRangeComponent, false);
		}

		// Token: 0x060253B5 RID: 152501 RVA: 0x0051C1D5 File Offset: 0x0051A3D5
		public static void AddCameraGaze(FlatBufferBuilder builder, Offset<ICameraGaze> cameraGazeOffset)
		{
			builder.AddOffset(7, cameraGazeOffset.Value, 0);
		}

		// Token: 0x060253B6 RID: 152502 RVA: 0x0051C1E5 File Offset: 0x0051A3E5
		public static void AddGazeNextPointAfterInteract(FlatBufferBuilder builder, Offset<IGazeNextPointAfterInteract> gazeNextPointAfterInteractOffset)
		{
			builder.AddOffset(8, gazeNextPointAfterInteractOffset.Value, 0);
		}

		// Token: 0x060253B7 RID: 152503 RVA: 0x0051C1F5 File Offset: 0x0051A3F5
		public static void AddInheritSpeed(FlatBufferBuilder builder, bool inheritSpeed)
		{
			builder.AddBool(9, inheritSpeed, false);
		}

		// Token: 0x060253B8 RID: 152504 RVA: 0x0051C201 File Offset: 0x0051A401
		public static void AddNormalEffect(FlatBufferBuilder builder, StringOffset normalEffectOffset)
		{
			builder.AddOffset(10, normalEffectOffset.Value, 0);
		}

		// Token: 0x060253B9 RID: 152505 RVA: 0x0051C212 File Offset: 0x0051A412
		public static void AddIsClimb(FlatBufferBuilder builder, bool isClimb)
		{
			builder.AddBool(11, isClimb, false);
		}

		// Token: 0x060253BA RID: 152506 RVA: 0x0051C21E File Offset: 0x0051A41E
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(12, playerStateRestritionId, 0);
		}

		// Token: 0x060253BB RID: 152507 RVA: 0x0051C22A File Offset: 0x0051A42A
		public static void AddHookEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> hookEnableConditionOffset)
		{
			builder.AddOffset(13, hookEnableConditionOffset.Value, 0);
		}

		// Token: 0x060253BC RID: 152508 RVA: 0x0051C23B File Offset: 0x0051A43B
		public static void AddHookLockCd(FlatBufferBuilder builder, float hookLockCd)
		{
			builder.AddFloat(14, hookLockCd, 0.0);
		}

		// Token: 0x060253BD RID: 152509 RVA: 0x0051C24F File Offset: 0x0051A44F
		public static void AddIsDestroyedSelf(FlatBufferBuilder builder, bool isDestroyedSelf)
		{
			builder.AddBool(15, isDestroyedSelf, false);
		}

		// Token: 0x060253BE RID: 152510 RVA: 0x0051C25B File Offset: 0x0051A45B
		public static void AddIsHideSelf(FlatBufferBuilder builder, bool isHideSelf)
		{
			builder.AddBool(16, isHideSelf, false);
		}

		// Token: 0x060253BF RID: 152511 RVA: 0x0051C267 File Offset: 0x0051A467
		public static void AddScreenDetectTypeType(FlatBufferBuilder builder, THookLockScreenDetectType screenDetectTypeType)
		{
			builder.AddByte(17, (byte)screenDetectTypeType, 0);
		}

		// Token: 0x060253C0 RID: 152512 RVA: 0x0051C273 File Offset: 0x0051A473
		public static void AddScreenDetectType(FlatBufferBuilder builder, int screenDetectTypeOffset)
		{
			builder.AddOffset(18, screenDetectTypeOffset, 0);
		}

		// Token: 0x060253C1 RID: 152513 RVA: 0x0051C27F File Offset: 0x0051A47F
		public static void AddHookInteractConfigType(FlatBufferBuilder builder, THookInteractConfig hookInteractConfigType)
		{
			builder.AddByte(19, (byte)hookInteractConfigType, 0);
		}

		// Token: 0x060253C2 RID: 152514 RVA: 0x0051C28B File Offset: 0x0051A48B
		public static void AddHookInteractConfig(FlatBufferBuilder builder, int hookInteractConfigOffset)
		{
			builder.AddOffset(20, hookInteractConfigOffset, 0);
		}

		// Token: 0x060253C3 RID: 152515 RVA: 0x0051C297 File Offset: 0x0051A497
		public static void AddMechHookInteractConfig(FlatBufferBuilder builder, Offset<IMechHookInteractConfig> mechHookInteractConfigOffset)
		{
			builder.AddOffset(21, mechHookInteractConfigOffset.Value, 0);
		}

		// Token: 0x060253C4 RID: 152516 RVA: 0x0051C2A8 File Offset: 0x0051A4A8
		public static void AddMotorHookConfig(FlatBufferBuilder builder, Offset<IMotorHookConfig> motorHookConfigOffset)
		{
			builder.AddOffset(22, motorHookConfigOffset.Value, 0);
		}

		// Token: 0x060253C5 RID: 152517 RVA: 0x0051C2B9 File Offset: 0x0051A4B9
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IHookGravityConfig> gravityConfigOffset)
		{
			builder.AddOffset(23, gravityConfigOffset.Value, 0);
		}

		// Token: 0x060253C6 RID: 152518 RVA: 0x0051C2CA File Offset: 0x0051A4CA
		public static void AddDisableAtCreateStage(FlatBufferBuilder builder, bool disableAtCreateStage)
		{
			builder.AddBool(24, disableAtCreateStage, false);
		}

		// Token: 0x060253C7 RID: 152519 RVA: 0x0051C2D6 File Offset: 0x0051A4D6
		public static void AddHookPerformanceConfig(FlatBufferBuilder builder, Offset<IHookPerformanceConfig> hookPerformanceConfigOffset)
		{
			builder.AddOffset(25, hookPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x060253C8 RID: 152520 RVA: 0x0051C2E7 File Offset: 0x0051A4E7
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(26, nullMask, 0);
		}

		// Token: 0x060253C9 RID: 152521 RVA: 0x0051C2F3 File Offset: 0x0051A4F3
		public static Offset<IHookLockPoint> EndIHookLockPoint(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockPoint>(builder.EndTable());
		}

		// Token: 0x060253CA RID: 152522 RVA: 0x0051C300 File Offset: 0x0051A500
		public IHookLockPointT UnPack()
		{
			IHookLockPointT hookLockPointT = new IHookLockPointT();
			this.UnPackTo(hookLockPointT);
			return hookLockPointT;
		}

		// Token: 0x060253CB RID: 152523 RVA: 0x0051C31C File Offset: 0x0051A51C
		public void UnPackTo(IHookLockPointT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.NonInteractiveInnerRadius = this.NonInteractiveInnerRadius;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.IgnorePlayCollision = this.IgnorePlayCollision;
			_o.UseRangeComponent = this.UseRangeComponent;
			_o.CameraGaze = ((this.CameraGaze != null) ? this.CameraGaze.Value.UnPack() : null);
			_o.GazeNextPointAfterInteract = ((this.GazeNextPointAfterInteract != null) ? this.GazeNextPointAfterInteract.Value.UnPack() : null);
			_o.InheritSpeed = this.InheritSpeed;
			_o.NormalEffect = this.NormalEffect;
			_o.IsClimb = this.IsClimb;
			_o.PlayerStateRestritionId = this.PlayerStateRestritionId;
			_o.HookEnableCondition = ((this.HookEnableCondition != null) ? this.HookEnableCondition.Value.UnPack() : null);
			_o.HookLockCd = this.HookLockCd;
			_o.IsDestroyedSelf = this.IsDestroyedSelf;
			_o.IsHideSelf = this.IsHideSelf;
			_o.ScreenDetectType = new THookLockScreenDetectTypeUnion();
			_o.ScreenDetectType.Type = this.ScreenDetectTypeType;
			THookLockScreenDetectType screenDetectTypeType = this.ScreenDetectTypeType;
			if (screenDetectTypeType != THookLockScreenDetectType.IHookLockScreenDetectTypeCentralEllipse)
			{
				if (screenDetectTypeType == THookLockScreenDetectType.IHookLockScreenDetectTypeFullScreen)
				{
					_o.ScreenDetectType.Value = ((this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>() != null) ? this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ScreenDetectType.Value = ((this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>() != null) ? this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value.UnPack() : null);
			}
			_o.HookInteractConfig = new THookInteractConfigUnion();
			_o.HookInteractConfig.Type = this.HookInteractConfigType;
			switch (this.HookInteractConfigType)
			{
			case THookInteractConfig.ICableWay:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<ICableWay>() != null) ? this.HookInteractConfig<ICableWay>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IChargeSlashHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IChargeSlashHook>() != null) ? this.HookInteractConfig<IChargeSlashHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IChongLouHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IChongLouHook>() != null) ? this.HookInteractConfig<IChongLouHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IFixedPointHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IFixedPointHook>() != null) ? this.HookInteractConfig<IFixedPointHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IFlyingFeather:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IFlyingFeather>() != null) ? this.HookInteractConfig<IFlyingFeather>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IFollowerShoot:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IFollowerShoot>() != null) ? this.HookInteractConfig<IFollowerShoot>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IFoxJumpingPoint:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IFoxJumpingPoint>() != null) ? this.HookInteractConfig<IFoxJumpingPoint>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IGravityHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IGravityHook>() != null) ? this.HookInteractConfig<IGravityHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IHookSpaceStationEnergyCore:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IHookSpaceStationEnergyCore>() != null) ? this.HookInteractConfig<IHookSpaceStationEnergyCore>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IKiteHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IKiteHook>() != null) ? this.HookInteractConfig<IKiteHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IMechTransformHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMechTransformHook>() != null) ? this.HookInteractConfig<IMechTransformHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IMotorEjectHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMotorEjectHook>() != null) ? this.HookInteractConfig<IMotorEjectHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IMotorPullInteract:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMotorPullInteract>() != null) ? this.HookInteractConfig<IMotorPullInteract>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IMovementPointHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMovementPointHook>() != null) ? this.HookInteractConfig<IMovementPointHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IPilotThrow:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IPilotThrow>() != null) ? this.HookInteractConfig<IPilotThrow>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IRagDollClimbingPoint:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IRagDollClimbingPoint>() != null) ? this.HookInteractConfig<IRagDollClimbingPoint>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IRagDollJumpingPoint:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IRagDollJumpingPoint>() != null) ? this.HookInteractConfig<IRagDollJumpingPoint>().Value.UnPack() : null);
				break;
			case THookInteractConfig.ISlashHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<ISlashHook>() != null) ? this.HookInteractConfig<ISlashHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.ISuiGuangHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<ISuiGuangHook>() != null) ? this.HookInteractConfig<ISuiGuangHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.ISunSpiritLauncher:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<ISunSpiritLauncher>() != null) ? this.HookInteractConfig<ISunSpiritLauncher>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IWaterBoxBigWeaponHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IWaterBoxBigWeaponHook>() != null) ? this.HookInteractConfig<IWaterBoxBigWeaponHook>().Value.UnPack() : null);
				break;
			}
			_o.MechHookInteractConfig = ((this.MechHookInteractConfig != null) ? this.MechHookInteractConfig.Value.UnPack() : null);
			_o.MotorHookConfig = ((this.MotorHookConfig != null) ? this.MotorHookConfig.Value.UnPack() : null);
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.DisableAtCreateStage = this.DisableAtCreateStage;
			_o.HookPerformanceConfig = ((this.HookPerformanceConfig != null) ? this.HookPerformanceConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060253CC RID: 152524 RVA: 0x0051CC60 File Offset: 0x0051AE60
		public static Offset<IHookLockPoint> Pack(FlatBufferBuilder builder, IHookLockPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookLockPoint>);
			}
			Offset<ISphereTriggerShape> rangeOffset = (_o.Range == null) ? default(Offset<ISphereTriggerShape>) : ISphereTriggerShape.Pack(builder, _o.Range);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = IHookLockPoint.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = IHookLockPoint.CreateMatchRoleOptionVector(builder, array2);
			}
			Offset<ICameraGaze> cameraGazeOffset = (_o.CameraGaze == null) ? default(Offset<ICameraGaze>) : ICameraGaze.Pack(builder, _o.CameraGaze);
			Offset<IGazeNextPointAfterInteract> gazeNextPointAfterInteractOffset = (_o.GazeNextPointAfterInteract == null) ? default(Offset<IGazeNextPointAfterInteract>) : IGazeNextPointAfterInteract.Pack(builder, _o.GazeNextPointAfterInteract);
			StringOffset normalEffectOffset = (_o.NormalEffect == null) ? default(StringOffset) : builder.CreateString(_o.NormalEffect);
			Offset<IConditionGroup> hookEnableConditionOffset = (_o.HookEnableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.HookEnableCondition);
			THookLockScreenDetectType screenDetectType_type = (_o.ScreenDetectType == null) ? THookLockScreenDetectType.NONE : _o.ScreenDetectType.Type;
			int screenDetectTypeOffset = (_o.ScreenDetectType == null) ? 0 : THookLockScreenDetectTypeUnion.Pack(builder, _o.ScreenDetectType);
			THookInteractConfig hookInteractConfig_type = (_o.HookInteractConfig == null) ? THookInteractConfig.NONE : _o.HookInteractConfig.Type;
			int hookInteractConfigOffset = (_o.HookInteractConfig == null) ? 0 : THookInteractConfigUnion.Pack(builder, _o.HookInteractConfig);
			Offset<IMechHookInteractConfig> mechHookInteractConfigOffset = (_o.MechHookInteractConfig == null) ? default(Offset<IMechHookInteractConfig>) : IMechHookInteractConfig.Pack(builder, _o.MechHookInteractConfig);
			Offset<IMotorHookConfig> motorHookConfigOffset = (_o.MotorHookConfig == null) ? default(Offset<IMotorHookConfig>) : IMotorHookConfig.Pack(builder, _o.MotorHookConfig);
			Offset<IHookGravityConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IHookGravityConfig>) : IHookGravityConfig.Pack(builder, _o.GravityConfig);
			Offset<IHookPerformanceConfig> hookPerformanceConfigOffset = (_o.HookPerformanceConfig == null) ? default(Offset<IHookPerformanceConfig>) : IHookPerformanceConfig.Pack(builder, _o.HookPerformanceConfig);
			return IHookLockPoint.CreateIHookLockPoint(builder, _o.Disabled, rangeOffset, _o.NonInteractiveInnerRadius, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.IgnorePlayCollision, _o.UseRangeComponent, cameraGazeOffset, gazeNextPointAfterInteractOffset, _o.InheritSpeed, normalEffectOffset, _o.IsClimb, _o.PlayerStateRestritionId, hookEnableConditionOffset, _o.HookLockCd, _o.IsDestroyedSelf, _o.IsHideSelf, screenDetectType_type, screenDetectTypeOffset, hookInteractConfig_type, hookInteractConfigOffset, mechHookInteractConfigOffset, motorHookConfigOffset, gravityConfigOffset, _o.DisableAtCreateStage, hookPerformanceConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F217 RID: 61975
		private Table __p;
	}
}
