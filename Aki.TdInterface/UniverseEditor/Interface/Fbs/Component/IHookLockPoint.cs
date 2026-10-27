using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C8 RID: 21448
	public struct IHookLockPoint : IFlatbufferObject
	{
		// Token: 0x17009DA9 RID: 40361
		// (get) Token: 0x060232B0 RID: 144048 RVA: 0x004DE4C4 File Offset: 0x004DC6C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060232B1 RID: 144049 RVA: 0x004DE4D1 File Offset: 0x004DC6D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060232B2 RID: 144050 RVA: 0x004DE4D8 File Offset: 0x004DC6D8
		public static IHookLockPoint GetRootAsIHookLockPoint(ByteBuffer _bb)
		{
			return IHookLockPoint.GetRootAsIHookLockPoint(_bb, default(IHookLockPoint));
		}

		// Token: 0x060232B3 RID: 144051 RVA: 0x004DE4F4 File Offset: 0x004DC6F4
		public static IHookLockPoint GetRootAsIHookLockPoint(ByteBuffer _bb, IHookLockPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060232B4 RID: 144052 RVA: 0x004DE511 File Offset: 0x004DC711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060232B5 RID: 144053 RVA: 0x004DE520 File Offset: 0x004DC720
		public IHookLockPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DAA RID: 40362
		// (get) Token: 0x060232B6 RID: 144054 RVA: 0x004DE530 File Offset: 0x004DC730
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DAB RID: 40363
		// (get) Token: 0x060232B7 RID: 144055 RVA: 0x004DE570 File Offset: 0x004DC770
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

		// Token: 0x17009DAC RID: 40364
		// (get) Token: 0x060232B8 RID: 144056 RVA: 0x004DE5D0 File Offset: 0x004DC7D0
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

		// Token: 0x060232B9 RID: 144057 RVA: 0x004DE610 File Offset: 0x004DC810
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009DAD RID: 40365
		// (get) Token: 0x060232BA RID: 144058 RVA: 0x004DE650 File Offset: 0x004DC850
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

		// Token: 0x060232BB RID: 144059 RVA: 0x004DE67C File Offset: 0x004DC87C
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(10, 1);
		}

		// Token: 0x060232BC RID: 144060 RVA: 0x004DE68C File Offset: 0x004DC88C
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

		// Token: 0x060232BD RID: 144061 RVA: 0x004DE6F8 File Offset: 0x004DC8F8
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009DAE RID: 40366
		// (get) Token: 0x060232BE RID: 144062 RVA: 0x004DE740 File Offset: 0x004DC940
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

		// Token: 0x17009DAF RID: 40367
		// (get) Token: 0x060232BF RID: 144063 RVA: 0x004DE76C File Offset: 0x004DC96C
		public bool IgnorePlayCollision
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DB0 RID: 40368
		// (get) Token: 0x060232C0 RID: 144064 RVA: 0x004DE7AC File Offset: 0x004DC9AC
		public bool UseRangeComponent
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DB1 RID: 40369
		// (get) Token: 0x060232C1 RID: 144065 RVA: 0x004DE7EC File Offset: 0x004DC9EC
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

		// Token: 0x17009DB2 RID: 40370
		// (get) Token: 0x060232C2 RID: 144066 RVA: 0x004DE84C File Offset: 0x004DCA4C
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

		// Token: 0x17009DB3 RID: 40371
		// (get) Token: 0x060232C3 RID: 144067 RVA: 0x004DE8AC File Offset: 0x004DCAAC
		public bool InheritSpeed
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DB4 RID: 40372
		// (get) Token: 0x060232C4 RID: 144068 RVA: 0x004DE8EC File Offset: 0x004DCAEC
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

		// Token: 0x060232C5 RID: 144069 RVA: 0x004DE924 File Offset: 0x004DCB24
		public Span<byte> GetNormalEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060232C6 RID: 144070 RVA: 0x004DE934 File Offset: 0x004DCB34
		public byte[] GetNormalEffectArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17009DB5 RID: 40373
		// (get) Token: 0x060232C7 RID: 144071 RVA: 0x004DE944 File Offset: 0x004DCB44
		public bool IsClimb
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DB6 RID: 40374
		// (get) Token: 0x060232C8 RID: 144072 RVA: 0x004DE984 File Offset: 0x004DCB84
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

		// Token: 0x17009DB7 RID: 40375
		// (get) Token: 0x060232C9 RID: 144073 RVA: 0x004DE9C4 File Offset: 0x004DCBC4
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

		// Token: 0x17009DB8 RID: 40376
		// (get) Token: 0x060232CA RID: 144074 RVA: 0x004DEA24 File Offset: 0x004DCC24
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

		// Token: 0x17009DB9 RID: 40377
		// (get) Token: 0x060232CB RID: 144075 RVA: 0x004DEA68 File Offset: 0x004DCC68
		public bool IsDestroyedSelf
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DBA RID: 40378
		// (get) Token: 0x060232CC RID: 144076 RVA: 0x004DEAA8 File Offset: 0x004DCCA8
		public bool IsHideSelf
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DBB RID: 40379
		// (get) Token: 0x060232CD RID: 144077 RVA: 0x004DEAE8 File Offset: 0x004DCCE8
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

		// Token: 0x060232CE RID: 144078 RVA: 0x004DEB28 File Offset: 0x004DCD28
		public TTable? ScreenDetectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060232CF RID: 144079 RVA: 0x004DEB70 File Offset: 0x004DCD70
		public IHookLockScreenDetectTypeCentralEllipse ScreenDetectTypeAsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value;
		}

		// Token: 0x060232D0 RID: 144080 RVA: 0x004DEB8C File Offset: 0x004DCD8C
		public IHookLockScreenDetectTypeFullScreen ScreenDetectTypeAsIHookLockScreenDetectTypeFullScreen()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value;
		}

		// Token: 0x17009DBC RID: 40380
		// (get) Token: 0x060232D1 RID: 144081 RVA: 0x004DEBA8 File Offset: 0x004DCDA8
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

		// Token: 0x060232D2 RID: 144082 RVA: 0x004DEBE8 File Offset: 0x004DCDE8
		public TTable? HookInteractConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060232D3 RID: 144083 RVA: 0x004DEC30 File Offset: 0x004DCE30
		public ICableWay HookInteractConfigAsICableWay()
		{
			return this.HookInteractConfig<ICableWay>().Value;
		}

		// Token: 0x060232D4 RID: 144084 RVA: 0x004DEC4C File Offset: 0x004DCE4C
		public IChargeSlashHook HookInteractConfigAsIChargeSlashHook()
		{
			return this.HookInteractConfig<IChargeSlashHook>().Value;
		}

		// Token: 0x060232D5 RID: 144085 RVA: 0x004DEC68 File Offset: 0x004DCE68
		public IFixedPointHook HookInteractConfigAsIFixedPointHook()
		{
			return this.HookInteractConfig<IFixedPointHook>().Value;
		}

		// Token: 0x060232D6 RID: 144086 RVA: 0x004DEC84 File Offset: 0x004DCE84
		public IFlyingFeather HookInteractConfigAsIFlyingFeather()
		{
			return this.HookInteractConfig<IFlyingFeather>().Value;
		}

		// Token: 0x060232D7 RID: 144087 RVA: 0x004DECA0 File Offset: 0x004DCEA0
		public IFollowerShoot HookInteractConfigAsIFollowerShoot()
		{
			return this.HookInteractConfig<IFollowerShoot>().Value;
		}

		// Token: 0x060232D8 RID: 144088 RVA: 0x004DECBC File Offset: 0x004DCEBC
		public IFoxJumpingPoint HookInteractConfigAsIFoxJumpingPoint()
		{
			return this.HookInteractConfig<IFoxJumpingPoint>().Value;
		}

		// Token: 0x060232D9 RID: 144089 RVA: 0x004DECD8 File Offset: 0x004DCED8
		public IGravityHook HookInteractConfigAsIGravityHook()
		{
			return this.HookInteractConfig<IGravityHook>().Value;
		}

		// Token: 0x060232DA RID: 144090 RVA: 0x004DECF4 File Offset: 0x004DCEF4
		public IHookSpaceStationEnergyCore HookInteractConfigAsIHookSpaceStationEnergyCore()
		{
			return this.HookInteractConfig<IHookSpaceStationEnergyCore>().Value;
		}

		// Token: 0x060232DB RID: 144091 RVA: 0x004DED10 File Offset: 0x004DCF10
		public IKiteHook HookInteractConfigAsIKiteHook()
		{
			return this.HookInteractConfig<IKiteHook>().Value;
		}

		// Token: 0x060232DC RID: 144092 RVA: 0x004DED2C File Offset: 0x004DCF2C
		public IMechHook HookInteractConfigAsIMechHook()
		{
			return this.HookInteractConfig<IMechHook>().Value;
		}

		// Token: 0x060232DD RID: 144093 RVA: 0x004DED48 File Offset: 0x004DCF48
		public IMechPullInteract HookInteractConfigAsIMechPullInteract()
		{
			return this.HookInteractConfig<IMechPullInteract>().Value;
		}

		// Token: 0x060232DE RID: 144094 RVA: 0x004DED64 File Offset: 0x004DCF64
		public IMotorEjectHook HookInteractConfigAsIMotorEjectHook()
		{
			return this.HookInteractConfig<IMotorEjectHook>().Value;
		}

		// Token: 0x060232DF RID: 144095 RVA: 0x004DED80 File Offset: 0x004DCF80
		public IMotorPullInteract HookInteractConfigAsIMotorPullInteract()
		{
			return this.HookInteractConfig<IMotorPullInteract>().Value;
		}

		// Token: 0x060232E0 RID: 144096 RVA: 0x004DED9C File Offset: 0x004DCF9C
		public IMovementPointHook HookInteractConfigAsIMovementPointHook()
		{
			return this.HookInteractConfig<IMovementPointHook>().Value;
		}

		// Token: 0x060232E1 RID: 144097 RVA: 0x004DEDB8 File Offset: 0x004DCFB8
		public IPilotThrow HookInteractConfigAsIPilotThrow()
		{
			return this.HookInteractConfig<IPilotThrow>().Value;
		}

		// Token: 0x060232E2 RID: 144098 RVA: 0x004DEDD4 File Offset: 0x004DCFD4
		public IRagDollClimbingPoint HookInteractConfigAsIRagDollClimbingPoint()
		{
			return this.HookInteractConfig<IRagDollClimbingPoint>().Value;
		}

		// Token: 0x060232E3 RID: 144099 RVA: 0x004DEDF0 File Offset: 0x004DCFF0
		public IRagDollJumpingPoint HookInteractConfigAsIRagDollJumpingPoint()
		{
			return this.HookInteractConfig<IRagDollJumpingPoint>().Value;
		}

		// Token: 0x060232E4 RID: 144100 RVA: 0x004DEE0C File Offset: 0x004DD00C
		public ISlashHook HookInteractConfigAsISlashHook()
		{
			return this.HookInteractConfig<ISlashHook>().Value;
		}

		// Token: 0x060232E5 RID: 144101 RVA: 0x004DEE28 File Offset: 0x004DD028
		public ISuiGuangHook HookInteractConfigAsISuiGuangHook()
		{
			return this.HookInteractConfig<ISuiGuangHook>().Value;
		}

		// Token: 0x060232E6 RID: 144102 RVA: 0x004DEE44 File Offset: 0x004DD044
		public ISunSpiritLauncher HookInteractConfigAsISunSpiritLauncher()
		{
			return this.HookInteractConfig<ISunSpiritLauncher>().Value;
		}

		// Token: 0x060232E7 RID: 144103 RVA: 0x004DEE60 File Offset: 0x004DD060
		public IWaterBoxBigWeaponHook HookInteractConfigAsIWaterBoxBigWeaponHook()
		{
			return this.HookInteractConfig<IWaterBoxBigWeaponHook>().Value;
		}

		// Token: 0x17009DBD RID: 40381
		// (get) Token: 0x060232E8 RID: 144104 RVA: 0x004DEE7C File Offset: 0x004DD07C
		public IMotorHookConfig? MotorHookConfig
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new IMotorHookConfig?(default(IMotorHookConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DBE RID: 40382
		// (get) Token: 0x060232E9 RID: 144105 RVA: 0x004DEEDC File Offset: 0x004DD0DC
		public IHookGravityConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IHookGravityConfig?(default(IHookGravityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DBF RID: 40383
		// (get) Token: 0x060232EA RID: 144106 RVA: 0x004DEF3C File Offset: 0x004DD13C
		public bool DisableAtCreateStage
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009DC0 RID: 40384
		// (get) Token: 0x060232EB RID: 144107 RVA: 0x004DEF7C File Offset: 0x004DD17C
		public IHookPerformanceConfig? HookPerformanceConfig
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return new IHookPerformanceConfig?(default(IHookPerformanceConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DC1 RID: 40385
		// (get) Token: 0x060232EC RID: 144108 RVA: 0x004DEFDC File Offset: 0x004DD1DC
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232ED RID: 144109 RVA: 0x004DF01C File Offset: 0x004DD21C
		public static Offset<IHookLockPoint> CreateIHookLockPoint(FlatBufferBuilder builder, bool Disabled = false, Offset<ISphereTriggerShape> RangeOffset = default(Offset<ISphereTriggerShape>), float NonInteractiveInnerRadius = 0f, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), bool IgnorePlayCollision = false, bool UseRangeComponent = false, Offset<ICameraGaze> CameraGazeOffset = default(Offset<ICameraGaze>), Offset<IGazeNextPointAfterInteract> GazeNextPointAfterInteractOffset = default(Offset<IGazeNextPointAfterInteract>), bool InheritSpeed = false, StringOffset NormalEffectOffset = default(StringOffset), bool IsClimb = false, int PlayerStateRestritionId = 0, Offset<IConditionGroup> HookEnableConditionOffset = default(Offset<IConditionGroup>), float HookLockCd = 0f, bool IsDestroyedSelf = false, bool IsHideSelf = false, THookLockScreenDetectType ScreenDetectType_type = THookLockScreenDetectType.NONE, int ScreenDetectTypeOffset = 0, THookInteractConfig HookInteractConfig_type = THookInteractConfig.NONE, int HookInteractConfigOffset = 0, Offset<IMotorHookConfig> MotorHookConfigOffset = default(Offset<IMotorHookConfig>), Offset<IHookGravityConfig> GravityConfigOffset = default(Offset<IHookGravityConfig>), bool DisableAtCreateStage = false, Offset<IHookPerformanceConfig> HookPerformanceConfigOffset = default(Offset<IHookPerformanceConfig>), ushort NullMask = 0)
		{
			builder.StartTable(26);
			IHookLockPoint.AddHookPerformanceConfig(builder, HookPerformanceConfigOffset);
			IHookLockPoint.AddGravityConfig(builder, GravityConfigOffset);
			IHookLockPoint.AddMotorHookConfig(builder, MotorHookConfigOffset);
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

		// Token: 0x060232EE RID: 144110 RVA: 0x004DF104 File Offset: 0x004DD304
		public static void StartIHookLockPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(26);
		}

		// Token: 0x060232EF RID: 144111 RVA: 0x004DF10E File Offset: 0x004DD30E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060232F0 RID: 144112 RVA: 0x004DF119 File Offset: 0x004DD319
		public static void AddRange(FlatBufferBuilder builder, Offset<ISphereTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x060232F1 RID: 144113 RVA: 0x004DF129 File Offset: 0x004DD329
		public static void AddNonInteractiveInnerRadius(FlatBufferBuilder builder, float nonInteractiveInnerRadius)
		{
			builder.AddFloat(2, nonInteractiveInnerRadius, 0.0);
		}

		// Token: 0x060232F2 RID: 144114 RVA: 0x004DF13C File Offset: 0x004DD33C
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(3, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060232F3 RID: 144115 RVA: 0x004DF14C File Offset: 0x004DD34C
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060232F4 RID: 144116 RVA: 0x004DF183 File Offset: 0x004DD383
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060232F5 RID: 144117 RVA: 0x004DF19D File Offset: 0x004DD39D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060232F6 RID: 144118 RVA: 0x004DF1BB File Offset: 0x004DD3BB
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060232F7 RID: 144119 RVA: 0x004DF1D4 File Offset: 0x004DD3D4
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060232F8 RID: 144120 RVA: 0x004DF1DF File Offset: 0x004DD3DF
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(4, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x060232F9 RID: 144121 RVA: 0x004DF1F0 File Offset: 0x004DD3F0
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060232FA RID: 144122 RVA: 0x004DF227 File Offset: 0x004DD427
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060232FB RID: 144123 RVA: 0x004DF241 File Offset: 0x004DD441
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060232FC RID: 144124 RVA: 0x004DF25F File Offset: 0x004DD45F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060232FD RID: 144125 RVA: 0x004DF278 File Offset: 0x004DD478
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060232FE RID: 144126 RVA: 0x004DF283 File Offset: 0x004DD483
		public static void AddIgnorePlayCollision(FlatBufferBuilder builder, bool ignorePlayCollision)
		{
			builder.AddBool(5, ignorePlayCollision, false);
		}

		// Token: 0x060232FF RID: 144127 RVA: 0x004DF28E File Offset: 0x004DD48E
		public static void AddUseRangeComponent(FlatBufferBuilder builder, bool useRangeComponent)
		{
			builder.AddBool(6, useRangeComponent, false);
		}

		// Token: 0x06023300 RID: 144128 RVA: 0x004DF299 File Offset: 0x004DD499
		public static void AddCameraGaze(FlatBufferBuilder builder, Offset<ICameraGaze> cameraGazeOffset)
		{
			builder.AddOffset(7, cameraGazeOffset.Value, 0);
		}

		// Token: 0x06023301 RID: 144129 RVA: 0x004DF2A9 File Offset: 0x004DD4A9
		public static void AddGazeNextPointAfterInteract(FlatBufferBuilder builder, Offset<IGazeNextPointAfterInteract> gazeNextPointAfterInteractOffset)
		{
			builder.AddOffset(8, gazeNextPointAfterInteractOffset.Value, 0);
		}

		// Token: 0x06023302 RID: 144130 RVA: 0x004DF2B9 File Offset: 0x004DD4B9
		public static void AddInheritSpeed(FlatBufferBuilder builder, bool inheritSpeed)
		{
			builder.AddBool(9, inheritSpeed, false);
		}

		// Token: 0x06023303 RID: 144131 RVA: 0x004DF2C5 File Offset: 0x004DD4C5
		public static void AddNormalEffect(FlatBufferBuilder builder, StringOffset normalEffectOffset)
		{
			builder.AddOffset(10, normalEffectOffset.Value, 0);
		}

		// Token: 0x06023304 RID: 144132 RVA: 0x004DF2D6 File Offset: 0x004DD4D6
		public static void AddIsClimb(FlatBufferBuilder builder, bool isClimb)
		{
			builder.AddBool(11, isClimb, false);
		}

		// Token: 0x06023305 RID: 144133 RVA: 0x004DF2E2 File Offset: 0x004DD4E2
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(12, playerStateRestritionId, 0);
		}

		// Token: 0x06023306 RID: 144134 RVA: 0x004DF2EE File Offset: 0x004DD4EE
		public static void AddHookEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> hookEnableConditionOffset)
		{
			builder.AddOffset(13, hookEnableConditionOffset.Value, 0);
		}

		// Token: 0x06023307 RID: 144135 RVA: 0x004DF2FF File Offset: 0x004DD4FF
		public static void AddHookLockCd(FlatBufferBuilder builder, float hookLockCd)
		{
			builder.AddFloat(14, hookLockCd, 0.0);
		}

		// Token: 0x06023308 RID: 144136 RVA: 0x004DF313 File Offset: 0x004DD513
		public static void AddIsDestroyedSelf(FlatBufferBuilder builder, bool isDestroyedSelf)
		{
			builder.AddBool(15, isDestroyedSelf, false);
		}

		// Token: 0x06023309 RID: 144137 RVA: 0x004DF31F File Offset: 0x004DD51F
		public static void AddIsHideSelf(FlatBufferBuilder builder, bool isHideSelf)
		{
			builder.AddBool(16, isHideSelf, false);
		}

		// Token: 0x0602330A RID: 144138 RVA: 0x004DF32B File Offset: 0x004DD52B
		public static void AddScreenDetectTypeType(FlatBufferBuilder builder, THookLockScreenDetectType screenDetectTypeType)
		{
			builder.AddByte(17, (byte)screenDetectTypeType, 0);
		}

		// Token: 0x0602330B RID: 144139 RVA: 0x004DF337 File Offset: 0x004DD537
		public static void AddScreenDetectType(FlatBufferBuilder builder, int screenDetectTypeOffset)
		{
			builder.AddOffset(18, screenDetectTypeOffset, 0);
		}

		// Token: 0x0602330C RID: 144140 RVA: 0x004DF343 File Offset: 0x004DD543
		public static void AddHookInteractConfigType(FlatBufferBuilder builder, THookInteractConfig hookInteractConfigType)
		{
			builder.AddByte(19, (byte)hookInteractConfigType, 0);
		}

		// Token: 0x0602330D RID: 144141 RVA: 0x004DF34F File Offset: 0x004DD54F
		public static void AddHookInteractConfig(FlatBufferBuilder builder, int hookInteractConfigOffset)
		{
			builder.AddOffset(20, hookInteractConfigOffset, 0);
		}

		// Token: 0x0602330E RID: 144142 RVA: 0x004DF35B File Offset: 0x004DD55B
		public static void AddMotorHookConfig(FlatBufferBuilder builder, Offset<IMotorHookConfig> motorHookConfigOffset)
		{
			builder.AddOffset(21, motorHookConfigOffset.Value, 0);
		}

		// Token: 0x0602330F RID: 144143 RVA: 0x004DF36C File Offset: 0x004DD56C
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IHookGravityConfig> gravityConfigOffset)
		{
			builder.AddOffset(22, gravityConfigOffset.Value, 0);
		}

		// Token: 0x06023310 RID: 144144 RVA: 0x004DF37D File Offset: 0x004DD57D
		public static void AddDisableAtCreateStage(FlatBufferBuilder builder, bool disableAtCreateStage)
		{
			builder.AddBool(23, disableAtCreateStage, false);
		}

		// Token: 0x06023311 RID: 144145 RVA: 0x004DF389 File Offset: 0x004DD589
		public static void AddHookPerformanceConfig(FlatBufferBuilder builder, Offset<IHookPerformanceConfig> hookPerformanceConfigOffset)
		{
			builder.AddOffset(24, hookPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x06023312 RID: 144146 RVA: 0x004DF39A File Offset: 0x004DD59A
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(25, nullMask, 0);
		}

		// Token: 0x06023313 RID: 144147 RVA: 0x004DF3A6 File Offset: 0x004DD5A6
		public static Offset<IHookLockPoint> EndIHookLockPoint(FlatBufferBuilder builder)
		{
			return new Offset<IHookLockPoint>(builder.EndTable());
		}

		// Token: 0x06023314 RID: 144148 RVA: 0x004DF3B4 File Offset: 0x004DD5B4
		public IHookLockPointT UnPack()
		{
			IHookLockPointT hookLockPointT = new IHookLockPointT();
			this.UnPackTo(hookLockPointT);
			return hookLockPointT;
		}

		// Token: 0x06023315 RID: 144149 RVA: 0x004DF3D0 File Offset: 0x004DD5D0
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
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
			case THookInteractConfig.IMechHook:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMechHook>() != null) ? this.HookInteractConfig<IMechHook>().Value.UnPack() : null);
				break;
			case THookInteractConfig.IMechPullInteract:
				_o.HookInteractConfig.Value = ((this.HookInteractConfig<IMechPullInteract>() != null) ? this.HookInteractConfig<IMechPullInteract>().Value.UnPack() : null);
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
			_o.MotorHookConfig = ((this.MotorHookConfig != null) ? this.MotorHookConfig.Value.UnPack() : null);
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.DisableAtCreateStage = this.DisableAtCreateStage;
			_o.HookPerformanceConfig = ((this.HookPerformanceConfig != null) ? this.HookPerformanceConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023316 RID: 144150 RVA: 0x004DFC9C File Offset: 0x004DDE9C
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
			Offset<IMotorHookConfig> motorHookConfigOffset = (_o.MotorHookConfig == null) ? default(Offset<IMotorHookConfig>) : IMotorHookConfig.Pack(builder, _o.MotorHookConfig);
			Offset<IHookGravityConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IHookGravityConfig>) : IHookGravityConfig.Pack(builder, _o.GravityConfig);
			Offset<IHookPerformanceConfig> hookPerformanceConfigOffset = (_o.HookPerformanceConfig == null) ? default(Offset<IHookPerformanceConfig>) : IHookPerformanceConfig.Pack(builder, _o.HookPerformanceConfig);
			return IHookLockPoint.CreateIHookLockPoint(builder, _o.Disabled, rangeOffset, _o.NonInteractiveInnerRadius, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.IgnorePlayCollision, _o.UseRangeComponent, cameraGazeOffset, gazeNextPointAfterInteractOffset, _o.InheritSpeed, normalEffectOffset, _o.IsClimb, _o.PlayerStateRestritionId, hookEnableConditionOffset, _o.HookLockCd, _o.IsDestroyedSelf, _o.IsHideSelf, screenDetectType_type, screenDetectTypeOffset, hookInteractConfig_type, hookInteractConfigOffset, motorHookConfigOffset, gravityConfigOffset, _o.DisableAtCreateStage, hookPerformanceConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E5E7 RID: 58855
		private Table __p;
	}
}
