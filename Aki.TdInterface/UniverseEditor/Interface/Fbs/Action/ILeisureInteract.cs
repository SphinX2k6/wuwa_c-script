using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E1 RID: 27105
	public struct ILeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700C91B RID: 51483
		// (get) Token: 0x0602F617 RID: 194071 RVA: 0x0067391D File Offset: 0x00671B1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F618 RID: 194072 RVA: 0x0067392A File Offset: 0x00671B2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F619 RID: 194073 RVA: 0x00673934 File Offset: 0x00671B34
		public static ILeisureInteract GetRootAsILeisureInteract(ByteBuffer _bb)
		{
			return ILeisureInteract.GetRootAsILeisureInteract(_bb, default(ILeisureInteract));
		}

		// Token: 0x0602F61A RID: 194074 RVA: 0x00673950 File Offset: 0x00671B50
		public static ILeisureInteract GetRootAsILeisureInteract(ByteBuffer _bb, ILeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F61B RID: 194075 RVA: 0x0067396D File Offset: 0x00671B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F61C RID: 194076 RVA: 0x0067397C File Offset: 0x00671B7C
		public ILeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C91C RID: 51484
		// (get) Token: 0x0602F61D RID: 194077 RVA: 0x0067398C File Offset: 0x00671B8C
		public TLeisureInteractOption OptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLeisureInteractOption.NONE;
				}
				return (TLeisureInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F61E RID: 194078 RVA: 0x006739C8 File Offset: 0x00671BC8
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F61F RID: 194079 RVA: 0x00673A0C File Offset: 0x00671C0C
		public IBounce OptionAsIBounce()
		{
			return this.Option<IBounce>().Value;
		}

		// Token: 0x0602F620 RID: 194080 RVA: 0x00673A28 File Offset: 0x00671C28
		public ICatapult OptionAsICatapult()
		{
			return this.Option<ICatapult>().Value;
		}

		// Token: 0x0602F621 RID: 194081 RVA: 0x00673A44 File Offset: 0x00671C44
		public ICustomSkill OptionAsICustomSkill()
		{
			return this.Option<ICustomSkill>().Value;
		}

		// Token: 0x0602F622 RID: 194082 RVA: 0x00673A60 File Offset: 0x00671C60
		public IFailurePoseInteract OptionAsIFailurePoseInteract()
		{
			return this.Option<IFailurePoseInteract>().Value;
		}

		// Token: 0x0602F623 RID: 194083 RVA: 0x00673A7C File Offset: 0x00671C7C
		public IFaithJump OptionAsIFaithJump()
		{
			return this.Option<IFaithJump>().Value;
		}

		// Token: 0x0602F624 RID: 194084 RVA: 0x00673A98 File Offset: 0x00671C98
		public IFoxAutoJump OptionAsIFoxAutoJump()
		{
			return this.Option<IFoxAutoJump>().Value;
		}

		// Token: 0x0602F625 RID: 194085 RVA: 0x00673AB4 File Offset: 0x00671CB4
		public IFoxPickUp OptionAsIFoxPickUp()
		{
			return this.Option<IFoxPickUp>().Value;
		}

		// Token: 0x0602F626 RID: 194086 RVA: 0x00673AD0 File Offset: 0x00671CD0
		public IFoxPushBox OptionAsIFoxPushBox()
		{
			return this.Option<IFoxPushBox>().Value;
		}

		// Token: 0x0602F627 RID: 194087 RVA: 0x00673AEC File Offset: 0x00671CEC
		public IFoxPutDown OptionAsIFoxPutDown()
		{
			return this.Option<IFoxPutDown>().Value;
		}

		// Token: 0x0602F628 RID: 194088 RVA: 0x00673B08 File Offset: 0x00671D08
		public IFoxReversePush OptionAsIFoxReversePush()
		{
			return this.Option<IFoxReversePush>().Value;
		}

		// Token: 0x0602F629 RID: 194089 RVA: 0x00673B24 File Offset: 0x00671D24
		public IGameplayPose1Interact OptionAsIGameplayPose1Interact()
		{
			return this.Option<IGameplayPose1Interact>().Value;
		}

		// Token: 0x0602F62A RID: 194090 RVA: 0x00673B40 File Offset: 0x00671D40
		public IGameplayPose2Interact OptionAsIGameplayPose2Interact()
		{
			return this.Option<IGameplayPose2Interact>().Value;
		}

		// Token: 0x0602F62B RID: 194091 RVA: 0x00673B5C File Offset: 0x00671D5C
		public IGameplayPose3Interact OptionAsIGameplayPose3Interact()
		{
			return this.Option<IGameplayPose3Interact>().Value;
		}

		// Token: 0x0602F62C RID: 194092 RVA: 0x00673B78 File Offset: 0x00671D78
		public IGetOffMotorcycleInteract OptionAsIGetOffMotorcycleInteract()
		{
			return this.Option<IGetOffMotorcycleInteract>().Value;
		}

		// Token: 0x0602F62D RID: 194093 RVA: 0x00673B94 File Offset: 0x00671D94
		public IGetUp OptionAsIGetUp()
		{
			return this.Option<IGetUp>().Value;
		}

		// Token: 0x0602F62E RID: 194094 RVA: 0x00673BB0 File Offset: 0x00671DB0
		public IGlide OptionAsIGlide()
		{
			return this.Option<IGlide>().Value;
		}

		// Token: 0x0602F62F RID: 194095 RVA: 0x00673BCC File Offset: 0x00671DCC
		public IHookLockInteract OptionAsIHookLockInteract()
		{
			return this.Option<IHookLockInteract>().Value;
		}

		// Token: 0x0602F630 RID: 194096 RVA: 0x00673BE8 File Offset: 0x00671DE8
		public IKiteHookInteract OptionAsIKiteHookInteract()
		{
			return this.Option<IKiteHookInteract>().Value;
		}

		// Token: 0x0602F631 RID: 194097 RVA: 0x00673C04 File Offset: 0x00671E04
		public ILandSlideEndInteract OptionAsILandSlideEndInteract()
		{
			return this.Option<ILandSlideEndInteract>().Value;
		}

		// Token: 0x0602F632 RID: 194098 RVA: 0x00673C20 File Offset: 0x00671E20
		public ILandSlideInteract OptionAsILandSlideInteract()
		{
			return this.Option<ILandSlideInteract>().Value;
		}

		// Token: 0x0602F633 RID: 194099 RVA: 0x00673C3C File Offset: 0x00671E3C
		public IManipulate OptionAsIManipulate()
		{
			return this.Option<IManipulate>().Value;
		}

		// Token: 0x0602F634 RID: 194100 RVA: 0x00673C58 File Offset: 0x00671E58
		public IMechEscortFly OptionAsIMechEscortFly()
		{
			return this.Option<IMechEscortFly>().Value;
		}

		// Token: 0x0602F635 RID: 194101 RVA: 0x00673C74 File Offset: 0x00671E74
		public IMechStunt OptionAsIMechStunt()
		{
			return this.Option<IMechStunt>().Value;
		}

		// Token: 0x0602F636 RID: 194102 RVA: 0x00673C90 File Offset: 0x00671E90
		public IMoneHackingDoorInteract OptionAsIMoneHackingDoorInteract()
		{
			return this.Option<IMoneHackingDoorInteract>().Value;
		}

		// Token: 0x0602F637 RID: 194103 RVA: 0x00673CAC File Offset: 0x00671EAC
		public IMotorBounce OptionAsIMotorBounce()
		{
			return this.Option<IMotorBounce>().Value;
		}

		// Token: 0x0602F638 RID: 194104 RVA: 0x00673CC8 File Offset: 0x00671EC8
		public IMotorCatapult OptionAsIMotorCatapult()
		{
			return this.Option<IMotorCatapult>().Value;
		}

		// Token: 0x0602F639 RID: 194105 RVA: 0x00673CE4 File Offset: 0x00671EE4
		public IMotorEnterSlide OptionAsIMotorEnterSlide()
		{
			return this.Option<IMotorEnterSlide>().Value;
		}

		// Token: 0x0602F63A RID: 194106 RVA: 0x00673D00 File Offset: 0x00671F00
		public IMotorSoarInteract OptionAsIMotorSoarInteract()
		{
			return this.Option<IMotorSoarInteract>().Value;
		}

		// Token: 0x0602F63B RID: 194107 RVA: 0x00673D1C File Offset: 0x00671F1C
		public IPainCoveringHead OptionAsIPainCoveringHead()
		{
			return this.Option<IPainCoveringHead>().Value;
		}

		// Token: 0x0602F63C RID: 194108 RVA: 0x00673D38 File Offset: 0x00671F38
		public IParticipateGroupPatrol OptionAsIParticipateGroupPatrol()
		{
			return this.Option<IParticipateGroupPatrol>().Value;
		}

		// Token: 0x0602F63D RID: 194109 RVA: 0x00673D54 File Offset: 0x00671F54
		public IQiuyuanLongPressQinggong OptionAsIQiuyuanLongPressQinggong()
		{
			return this.Option<IQiuyuanLongPressQinggong>().Value;
		}

		// Token: 0x0602F63E RID: 194110 RVA: 0x00673D70 File Offset: 0x00671F70
		public IQiuyuanQinggongEnd OptionAsIQiuyuanQinggongEnd()
		{
			return this.Option<IQiuyuanQinggongEnd>().Value;
		}

		// Token: 0x0602F63F RID: 194111 RVA: 0x00673D8C File Offset: 0x00671F8C
		public IQiuyuanQinggongExploration1 OptionAsIQiuyuanQinggongExploration1()
		{
			return this.Option<IQiuyuanQinggongExploration1>().Value;
		}

		// Token: 0x0602F640 RID: 194112 RVA: 0x00673DA8 File Offset: 0x00671FA8
		public IQiuyuanQinggongExploration2 OptionAsIQiuyuanQinggongExploration2()
		{
			return this.Option<IQiuyuanQinggongExploration2>().Value;
		}

		// Token: 0x0602F641 RID: 194113 RVA: 0x00673DC4 File Offset: 0x00671FC4
		public IQiuyuanQinggongExploration3 OptionAsIQiuyuanQinggongExploration3()
		{
			return this.Option<IQiuyuanQinggongExploration3>().Value;
		}

		// Token: 0x0602F642 RID: 194114 RVA: 0x00673DE0 File Offset: 0x00671FE0
		public IQiuyuanQinggongExploration4 OptionAsIQiuyuanQinggongExploration4()
		{
			return this.Option<IQiuyuanQinggongExploration4>().Value;
		}

		// Token: 0x0602F643 RID: 194115 RVA: 0x00673DFC File Offset: 0x00671FFC
		public IQiuyuanQinggongHovering OptionAsIQiuyuanQinggongHovering()
		{
			return this.Option<IQiuyuanQinggongHovering>().Value;
		}

		// Token: 0x0602F644 RID: 194116 RVA: 0x00673E18 File Offset: 0x00672018
		public IQiuyuanQinggongStraight OptionAsIQiuyuanQinggongStraight()
		{
			return this.Option<IQiuyuanQinggongStraight>().Value;
		}

		// Token: 0x0602F645 RID: 194117 RVA: 0x00673E34 File Offset: 0x00672034
		public IRideMotorcycleInteract OptionAsIRideMotorcycleInteract()
		{
			return this.Option<IRideMotorcycleInteract>().Value;
		}

		// Token: 0x0602F646 RID: 194118 RVA: 0x00673E50 File Offset: 0x00672050
		public ISitDown OptionAsISitDown()
		{
			return this.Option<ISitDown>().Value;
		}

		// Token: 0x0602F647 RID: 194119 RVA: 0x00673E6C File Offset: 0x0067206C
		public ISitOnGround OptionAsISitOnGround()
		{
			return this.Option<ISitOnGround>().Value;
		}

		// Token: 0x0602F648 RID: 194120 RVA: 0x00673E88 File Offset: 0x00672088
		public ISoar OptionAsISoar()
		{
			return this.Option<ISoar>().Value;
		}

		// Token: 0x0602F649 RID: 194121 RVA: 0x00673EA4 File Offset: 0x006720A4
		public ISoar2 OptionAsISoar2()
		{
			return this.Option<ISoar2>().Value;
		}

		// Token: 0x0602F64A RID: 194122 RVA: 0x00673EC0 File Offset: 0x006720C0
		public IStandControl OptionAsIStandControl()
		{
			return this.Option<IStandControl>().Value;
		}

		// Token: 0x0602F64B RID: 194123 RVA: 0x00673EDC File Offset: 0x006720DC
		public IStandControl2 OptionAsIStandControl2()
		{
			return this.Option<IStandControl2>().Value;
		}

		// Token: 0x0602F64C RID: 194124 RVA: 0x00673EF8 File Offset: 0x006720F8
		public ISunPalaceInteract OptionAsISunPalaceInteract()
		{
			return this.Option<ISunPalaceInteract>().Value;
		}

		// Token: 0x0602F64D RID: 194125 RVA: 0x00673F14 File Offset: 0x00672114
		public ISuperCatapult OptionAsISuperCatapult()
		{
			return this.Option<ISuperCatapult>().Value;
		}

		// Token: 0x0602F64E RID: 194126 RVA: 0x00673F30 File Offset: 0x00672130
		public ISwing OptionAsISwing()
		{
			return this.Option<ISwing>().Value;
		}

		// Token: 0x0602F64F RID: 194127 RVA: 0x00673F4C File Offset: 0x0067214C
		public ISwingGetUp OptionAsISwingGetUp()
		{
			return this.Option<ISwingGetUp>().Value;
		}

		// Token: 0x0602F650 RID: 194128 RVA: 0x00673F68 File Offset: 0x00672168
		public IWindProtagonistParkour1 OptionAsIWindProtagonistParkour1()
		{
			return this.Option<IWindProtagonistParkour1>().Value;
		}

		// Token: 0x0602F651 RID: 194129 RVA: 0x00673F84 File Offset: 0x00672184
		public IWindProtagonistParkour2 OptionAsIWindProtagonistParkour2()
		{
			return this.Option<IWindProtagonistParkour2>().Value;
		}

		// Token: 0x0602F652 RID: 194130 RVA: 0x00673FA0 File Offset: 0x006721A0
		public IWindProtagonistParkour3 OptionAsIWindProtagonistParkour3()
		{
			return this.Option<IWindProtagonistParkour3>().Value;
		}

		// Token: 0x0602F653 RID: 194131 RVA: 0x00673FBC File Offset: 0x006721BC
		public IWindProtagonistParkour4 OptionAsIWindProtagonistParkour4()
		{
			return this.Option<IWindProtagonistParkour4>().Value;
		}

		// Token: 0x0602F654 RID: 194132 RVA: 0x00673FD8 File Offset: 0x006721D8
		public IWindProtagonistParkour5 OptionAsIWindProtagonistParkour5()
		{
			return this.Option<IWindProtagonistParkour5>().Value;
		}

		// Token: 0x1700C91D RID: 51485
		// (get) Token: 0x0602F655 RID: 194133 RVA: 0x00673FF4 File Offset: 0x006721F4
		public int SceneEntity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C91E RID: 51486
		// (get) Token: 0x0602F656 RID: 194134 RVA: 0x00674030 File Offset: 0x00672230
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F657 RID: 194135 RVA: 0x0067406D File Offset: 0x0067226D
		public static Offset<ILeisureInteract> CreateILeisureInteract(FlatBufferBuilder builder, TLeisureInteractOption Option_type = TLeisureInteractOption.NONE, int OptionOffset = 0, int SceneEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILeisureInteract.AddSceneEntity(builder, SceneEntity);
			ILeisureInteract.AddOption(builder, OptionOffset);
			ILeisureInteract.AddNullMask(builder, NullMask);
			ILeisureInteract.AddOptionType(builder, Option_type);
			return ILeisureInteract.EndILeisureInteract(builder);
		}

		// Token: 0x0602F658 RID: 194136 RVA: 0x00674099 File Offset: 0x00672299
		public static void StartILeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F659 RID: 194137 RVA: 0x006740A2 File Offset: 0x006722A2
		public static void AddOptionType(FlatBufferBuilder builder, TLeisureInteractOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x0602F65A RID: 194138 RVA: 0x006740AD File Offset: 0x006722AD
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x0602F65B RID: 194139 RVA: 0x006740B8 File Offset: 0x006722B8
		public static void AddSceneEntity(FlatBufferBuilder builder, int sceneEntity)
		{
			builder.AddInt(2, sceneEntity, 0);
		}

		// Token: 0x0602F65C RID: 194140 RVA: 0x006740C3 File Offset: 0x006722C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F65D RID: 194141 RVA: 0x006740CE File Offset: 0x006722CE
		public static Offset<ILeisureInteract> EndILeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILeisureInteract>(builder.EndTable());
		}

		// Token: 0x0602F65E RID: 194142 RVA: 0x006740DC File Offset: 0x006722DC
		public ILeisureInteractT UnPack()
		{
			ILeisureInteractT leisureInteractT = new ILeisureInteractT();
			this.UnPackTo(leisureInteractT);
			return leisureInteractT;
		}

		// Token: 0x0602F65F RID: 194143 RVA: 0x006740F8 File Offset: 0x006722F8
		public void UnPackTo(ILeisureInteractT _o)
		{
			_o.Option = new TLeisureInteractOptionUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TLeisureInteractOption.IBounce:
				_o.Option.Value = ((this.Option<IBounce>() != null) ? this.Option<IBounce>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ICatapult:
				_o.Option.Value = ((this.Option<ICatapult>() != null) ? this.Option<ICatapult>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ICustomSkill:
				_o.Option.Value = ((this.Option<ICustomSkill>() != null) ? this.Option<ICustomSkill>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFailurePoseInteract:
				_o.Option.Value = ((this.Option<IFailurePoseInteract>() != null) ? this.Option<IFailurePoseInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFaithJump:
				_o.Option.Value = ((this.Option<IFaithJump>() != null) ? this.Option<IFaithJump>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFoxAutoJump:
				_o.Option.Value = ((this.Option<IFoxAutoJump>() != null) ? this.Option<IFoxAutoJump>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFoxPickUp:
				_o.Option.Value = ((this.Option<IFoxPickUp>() != null) ? this.Option<IFoxPickUp>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFoxPushBox:
				_o.Option.Value = ((this.Option<IFoxPushBox>() != null) ? this.Option<IFoxPushBox>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFoxPutDown:
				_o.Option.Value = ((this.Option<IFoxPutDown>() != null) ? this.Option<IFoxPutDown>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IFoxReversePush:
				_o.Option.Value = ((this.Option<IFoxReversePush>() != null) ? this.Option<IFoxReversePush>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGameplayPose1Interact:
				_o.Option.Value = ((this.Option<IGameplayPose1Interact>() != null) ? this.Option<IGameplayPose1Interact>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGameplayPose2Interact:
				_o.Option.Value = ((this.Option<IGameplayPose2Interact>() != null) ? this.Option<IGameplayPose2Interact>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGameplayPose3Interact:
				_o.Option.Value = ((this.Option<IGameplayPose3Interact>() != null) ? this.Option<IGameplayPose3Interact>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGetOffMotorcycleInteract:
				_o.Option.Value = ((this.Option<IGetOffMotorcycleInteract>() != null) ? this.Option<IGetOffMotorcycleInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGetUp:
				_o.Option.Value = ((this.Option<IGetUp>() != null) ? this.Option<IGetUp>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IGlide:
				_o.Option.Value = ((this.Option<IGlide>() != null) ? this.Option<IGlide>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IHookLockInteract:
				_o.Option.Value = ((this.Option<IHookLockInteract>() != null) ? this.Option<IHookLockInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IKiteHookInteract:
				_o.Option.Value = ((this.Option<IKiteHookInteract>() != null) ? this.Option<IKiteHookInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ILandSlideEndInteract:
				_o.Option.Value = ((this.Option<ILandSlideEndInteract>() != null) ? this.Option<ILandSlideEndInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ILandSlideInteract:
				_o.Option.Value = ((this.Option<ILandSlideInteract>() != null) ? this.Option<ILandSlideInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IManipulate:
				_o.Option.Value = ((this.Option<IManipulate>() != null) ? this.Option<IManipulate>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMechEscortFly:
				_o.Option.Value = ((this.Option<IMechEscortFly>() != null) ? this.Option<IMechEscortFly>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMechStunt:
				_o.Option.Value = ((this.Option<IMechStunt>() != null) ? this.Option<IMechStunt>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMoneHackingDoorInteract:
				_o.Option.Value = ((this.Option<IMoneHackingDoorInteract>() != null) ? this.Option<IMoneHackingDoorInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMotorBounce:
				_o.Option.Value = ((this.Option<IMotorBounce>() != null) ? this.Option<IMotorBounce>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMotorCatapult:
				_o.Option.Value = ((this.Option<IMotorCatapult>() != null) ? this.Option<IMotorCatapult>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMotorEnterSlide:
				_o.Option.Value = ((this.Option<IMotorEnterSlide>() != null) ? this.Option<IMotorEnterSlide>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IMotorSoarInteract:
				_o.Option.Value = ((this.Option<IMotorSoarInteract>() != null) ? this.Option<IMotorSoarInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IPainCoveringHead:
				_o.Option.Value = ((this.Option<IPainCoveringHead>() != null) ? this.Option<IPainCoveringHead>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IParticipateGroupPatrol:
				_o.Option.Value = ((this.Option<IParticipateGroupPatrol>() != null) ? this.Option<IParticipateGroupPatrol>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanLongPressQinggong:
				_o.Option.Value = ((this.Option<IQiuyuanLongPressQinggong>() != null) ? this.Option<IQiuyuanLongPressQinggong>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongEnd:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongEnd>() != null) ? this.Option<IQiuyuanQinggongEnd>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongExploration1:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongExploration1>() != null) ? this.Option<IQiuyuanQinggongExploration1>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongExploration2:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongExploration2>() != null) ? this.Option<IQiuyuanQinggongExploration2>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongExploration3:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongExploration3>() != null) ? this.Option<IQiuyuanQinggongExploration3>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongExploration4:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongExploration4>() != null) ? this.Option<IQiuyuanQinggongExploration4>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongHovering:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongHovering>() != null) ? this.Option<IQiuyuanQinggongHovering>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IQiuyuanQinggongStraight:
				_o.Option.Value = ((this.Option<IQiuyuanQinggongStraight>() != null) ? this.Option<IQiuyuanQinggongStraight>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IRideMotorcycleInteract:
				_o.Option.Value = ((this.Option<IRideMotorcycleInteract>() != null) ? this.Option<IRideMotorcycleInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISitDown:
				_o.Option.Value = ((this.Option<ISitDown>() != null) ? this.Option<ISitDown>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISitOnGround:
				_o.Option.Value = ((this.Option<ISitOnGround>() != null) ? this.Option<ISitOnGround>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISoar:
				_o.Option.Value = ((this.Option<ISoar>() != null) ? this.Option<ISoar>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISoar2:
				_o.Option.Value = ((this.Option<ISoar2>() != null) ? this.Option<ISoar2>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IStandControl:
				_o.Option.Value = ((this.Option<IStandControl>() != null) ? this.Option<IStandControl>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IStandControl2:
				_o.Option.Value = ((this.Option<IStandControl2>() != null) ? this.Option<IStandControl2>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISunPalaceInteract:
				_o.Option.Value = ((this.Option<ISunPalaceInteract>() != null) ? this.Option<ISunPalaceInteract>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISuperCatapult:
				_o.Option.Value = ((this.Option<ISuperCatapult>() != null) ? this.Option<ISuperCatapult>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISwing:
				_o.Option.Value = ((this.Option<ISwing>() != null) ? this.Option<ISwing>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.ISwingGetUp:
				_o.Option.Value = ((this.Option<ISwingGetUp>() != null) ? this.Option<ISwingGetUp>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IWindProtagonistParkour1:
				_o.Option.Value = ((this.Option<IWindProtagonistParkour1>() != null) ? this.Option<IWindProtagonistParkour1>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IWindProtagonistParkour2:
				_o.Option.Value = ((this.Option<IWindProtagonistParkour2>() != null) ? this.Option<IWindProtagonistParkour2>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IWindProtagonistParkour3:
				_o.Option.Value = ((this.Option<IWindProtagonistParkour3>() != null) ? this.Option<IWindProtagonistParkour3>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IWindProtagonistParkour4:
				_o.Option.Value = ((this.Option<IWindProtagonistParkour4>() != null) ? this.Option<IWindProtagonistParkour4>().Value.UnPack() : null);
				break;
			case TLeisureInteractOption.IWindProtagonistParkour5:
				_o.Option.Value = ((this.Option<IWindProtagonistParkour5>() != null) ? this.Option<IWindProtagonistParkour5>().Value.UnPack() : null);
				break;
			}
			_o.SceneEntity = this.SceneEntity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F660 RID: 194144 RVA: 0x00674EC0 File Offset: 0x006730C0
		public static Offset<ILeisureInteract> Pack(FlatBufferBuilder builder, ILeisureInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILeisureInteract>);
			}
			TLeisureInteractOption option_type = (_o.Option == null) ? TLeisureInteractOption.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TLeisureInteractOptionUnion.Pack(builder, _o.Option);
			return ILeisureInteract.CreateILeisureInteract(builder, option_type, optionOffset, _o.SceneEntity, _o.NullMask);
		}

		// Token: 0x0401119E RID: 70046
		private Table __p;
	}
}
