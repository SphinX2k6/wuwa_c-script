using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007091 RID: 28817
	public struct ILeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700D31B RID: 54043
		// (get) Token: 0x06031FD7 RID: 204759 RVA: 0x006C3C75 File Offset: 0x006C1E75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031FD8 RID: 204760 RVA: 0x006C3C82 File Offset: 0x006C1E82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031FD9 RID: 204761 RVA: 0x006C3C8C File Offset: 0x006C1E8C
		public static ILeisureInteract GetRootAsILeisureInteract(ByteBuffer _bb)
		{
			return ILeisureInteract.GetRootAsILeisureInteract(_bb, default(ILeisureInteract));
		}

		// Token: 0x06031FDA RID: 204762 RVA: 0x006C3CA8 File Offset: 0x006C1EA8
		public static ILeisureInteract GetRootAsILeisureInteract(ByteBuffer _bb, ILeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FDB RID: 204763 RVA: 0x006C3CC5 File Offset: 0x006C1EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FDC RID: 204764 RVA: 0x006C3CD4 File Offset: 0x006C1ED4
		public ILeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D31C RID: 54044
		// (get) Token: 0x06031FDD RID: 204765 RVA: 0x006C3CE4 File Offset: 0x006C1EE4
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

		// Token: 0x06031FDE RID: 204766 RVA: 0x006C3D20 File Offset: 0x006C1F20
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031FDF RID: 204767 RVA: 0x006C3D64 File Offset: 0x006C1F64
		public IBounce OptionAsIBounce()
		{
			return this.Option<IBounce>().Value;
		}

		// Token: 0x06031FE0 RID: 204768 RVA: 0x006C3D80 File Offset: 0x006C1F80
		public ICatapult OptionAsICatapult()
		{
			return this.Option<ICatapult>().Value;
		}

		// Token: 0x06031FE1 RID: 204769 RVA: 0x006C3D9C File Offset: 0x006C1F9C
		public ICustomSkill OptionAsICustomSkill()
		{
			return this.Option<ICustomSkill>().Value;
		}

		// Token: 0x06031FE2 RID: 204770 RVA: 0x006C3DB8 File Offset: 0x006C1FB8
		public IFailurePoseInteract OptionAsIFailurePoseInteract()
		{
			return this.Option<IFailurePoseInteract>().Value;
		}

		// Token: 0x06031FE3 RID: 204771 RVA: 0x006C3DD4 File Offset: 0x006C1FD4
		public IFaithJump OptionAsIFaithJump()
		{
			return this.Option<IFaithJump>().Value;
		}

		// Token: 0x06031FE4 RID: 204772 RVA: 0x006C3DF0 File Offset: 0x006C1FF0
		public IFoxAutoJump OptionAsIFoxAutoJump()
		{
			return this.Option<IFoxAutoJump>().Value;
		}

		// Token: 0x06031FE5 RID: 204773 RVA: 0x006C3E0C File Offset: 0x006C200C
		public IFoxPickUp OptionAsIFoxPickUp()
		{
			return this.Option<IFoxPickUp>().Value;
		}

		// Token: 0x06031FE6 RID: 204774 RVA: 0x006C3E28 File Offset: 0x006C2028
		public IFoxPushBox OptionAsIFoxPushBox()
		{
			return this.Option<IFoxPushBox>().Value;
		}

		// Token: 0x06031FE7 RID: 204775 RVA: 0x006C3E44 File Offset: 0x006C2044
		public IFoxPutDown OptionAsIFoxPutDown()
		{
			return this.Option<IFoxPutDown>().Value;
		}

		// Token: 0x06031FE8 RID: 204776 RVA: 0x006C3E60 File Offset: 0x006C2060
		public IFoxReversePush OptionAsIFoxReversePush()
		{
			return this.Option<IFoxReversePush>().Value;
		}

		// Token: 0x06031FE9 RID: 204777 RVA: 0x006C3E7C File Offset: 0x006C207C
		public IGameplayPose1Interact OptionAsIGameplayPose1Interact()
		{
			return this.Option<IGameplayPose1Interact>().Value;
		}

		// Token: 0x06031FEA RID: 204778 RVA: 0x006C3E98 File Offset: 0x006C2098
		public IGameplayPose2Interact OptionAsIGameplayPose2Interact()
		{
			return this.Option<IGameplayPose2Interact>().Value;
		}

		// Token: 0x06031FEB RID: 204779 RVA: 0x006C3EB4 File Offset: 0x006C20B4
		public IGameplayPose3Interact OptionAsIGameplayPose3Interact()
		{
			return this.Option<IGameplayPose3Interact>().Value;
		}

		// Token: 0x06031FEC RID: 204780 RVA: 0x006C3ED0 File Offset: 0x006C20D0
		public IGetOffMotorcycleInteract OptionAsIGetOffMotorcycleInteract()
		{
			return this.Option<IGetOffMotorcycleInteract>().Value;
		}

		// Token: 0x06031FED RID: 204781 RVA: 0x006C3EEC File Offset: 0x006C20EC
		public IGetUp OptionAsIGetUp()
		{
			return this.Option<IGetUp>().Value;
		}

		// Token: 0x06031FEE RID: 204782 RVA: 0x006C3F08 File Offset: 0x006C2108
		public IGlide OptionAsIGlide()
		{
			return this.Option<IGlide>().Value;
		}

		// Token: 0x06031FEF RID: 204783 RVA: 0x006C3F24 File Offset: 0x006C2124
		public IHookLockInteract OptionAsIHookLockInteract()
		{
			return this.Option<IHookLockInteract>().Value;
		}

		// Token: 0x06031FF0 RID: 204784 RVA: 0x006C3F40 File Offset: 0x006C2140
		public IKiteHookInteract OptionAsIKiteHookInteract()
		{
			return this.Option<IKiteHookInteract>().Value;
		}

		// Token: 0x06031FF1 RID: 204785 RVA: 0x006C3F5C File Offset: 0x006C215C
		public ILandSlideEndInteract OptionAsILandSlideEndInteract()
		{
			return this.Option<ILandSlideEndInteract>().Value;
		}

		// Token: 0x06031FF2 RID: 204786 RVA: 0x006C3F78 File Offset: 0x006C2178
		public ILandSlideInteract OptionAsILandSlideInteract()
		{
			return this.Option<ILandSlideInteract>().Value;
		}

		// Token: 0x06031FF3 RID: 204787 RVA: 0x006C3F94 File Offset: 0x006C2194
		public IManipulate OptionAsIManipulate()
		{
			return this.Option<IManipulate>().Value;
		}

		// Token: 0x06031FF4 RID: 204788 RVA: 0x006C3FB0 File Offset: 0x006C21B0
		public IMechEscortFly OptionAsIMechEscortFly()
		{
			return this.Option<IMechEscortFly>().Value;
		}

		// Token: 0x06031FF5 RID: 204789 RVA: 0x006C3FCC File Offset: 0x006C21CC
		public IMechStunt OptionAsIMechStunt()
		{
			return this.Option<IMechStunt>().Value;
		}

		// Token: 0x06031FF6 RID: 204790 RVA: 0x006C3FE8 File Offset: 0x006C21E8
		public IMoneHackingDoorInteract OptionAsIMoneHackingDoorInteract()
		{
			return this.Option<IMoneHackingDoorInteract>().Value;
		}

		// Token: 0x06031FF7 RID: 204791 RVA: 0x006C4004 File Offset: 0x006C2204
		public IMotorBounce OptionAsIMotorBounce()
		{
			return this.Option<IMotorBounce>().Value;
		}

		// Token: 0x06031FF8 RID: 204792 RVA: 0x006C4020 File Offset: 0x006C2220
		public IMotorCatapult OptionAsIMotorCatapult()
		{
			return this.Option<IMotorCatapult>().Value;
		}

		// Token: 0x06031FF9 RID: 204793 RVA: 0x006C403C File Offset: 0x006C223C
		public IMotorEnterSlide OptionAsIMotorEnterSlide()
		{
			return this.Option<IMotorEnterSlide>().Value;
		}

		// Token: 0x06031FFA RID: 204794 RVA: 0x006C4058 File Offset: 0x006C2258
		public IMotorSoarInteract OptionAsIMotorSoarInteract()
		{
			return this.Option<IMotorSoarInteract>().Value;
		}

		// Token: 0x06031FFB RID: 204795 RVA: 0x006C4074 File Offset: 0x006C2274
		public IPainCoveringHead OptionAsIPainCoveringHead()
		{
			return this.Option<IPainCoveringHead>().Value;
		}

		// Token: 0x06031FFC RID: 204796 RVA: 0x006C4090 File Offset: 0x006C2290
		public IParticipateGroupPatrol OptionAsIParticipateGroupPatrol()
		{
			return this.Option<IParticipateGroupPatrol>().Value;
		}

		// Token: 0x06031FFD RID: 204797 RVA: 0x006C40AC File Offset: 0x006C22AC
		public IQiuyuanLongPressQinggong OptionAsIQiuyuanLongPressQinggong()
		{
			return this.Option<IQiuyuanLongPressQinggong>().Value;
		}

		// Token: 0x06031FFE RID: 204798 RVA: 0x006C40C8 File Offset: 0x006C22C8
		public IQiuyuanQinggongEnd OptionAsIQiuyuanQinggongEnd()
		{
			return this.Option<IQiuyuanQinggongEnd>().Value;
		}

		// Token: 0x06031FFF RID: 204799 RVA: 0x006C40E4 File Offset: 0x006C22E4
		public IQiuyuanQinggongExploration1 OptionAsIQiuyuanQinggongExploration1()
		{
			return this.Option<IQiuyuanQinggongExploration1>().Value;
		}

		// Token: 0x06032000 RID: 204800 RVA: 0x006C4100 File Offset: 0x006C2300
		public IQiuyuanQinggongExploration2 OptionAsIQiuyuanQinggongExploration2()
		{
			return this.Option<IQiuyuanQinggongExploration2>().Value;
		}

		// Token: 0x06032001 RID: 204801 RVA: 0x006C411C File Offset: 0x006C231C
		public IQiuyuanQinggongExploration3 OptionAsIQiuyuanQinggongExploration3()
		{
			return this.Option<IQiuyuanQinggongExploration3>().Value;
		}

		// Token: 0x06032002 RID: 204802 RVA: 0x006C4138 File Offset: 0x006C2338
		public IQiuyuanQinggongExploration4 OptionAsIQiuyuanQinggongExploration4()
		{
			return this.Option<IQiuyuanQinggongExploration4>().Value;
		}

		// Token: 0x06032003 RID: 204803 RVA: 0x006C4154 File Offset: 0x006C2354
		public IQiuyuanQinggongHovering OptionAsIQiuyuanQinggongHovering()
		{
			return this.Option<IQiuyuanQinggongHovering>().Value;
		}

		// Token: 0x06032004 RID: 204804 RVA: 0x006C4170 File Offset: 0x006C2370
		public IQiuyuanQinggongStraight OptionAsIQiuyuanQinggongStraight()
		{
			return this.Option<IQiuyuanQinggongStraight>().Value;
		}

		// Token: 0x06032005 RID: 204805 RVA: 0x006C418C File Offset: 0x006C238C
		public IRideMotorcycleInteract OptionAsIRideMotorcycleInteract()
		{
			return this.Option<IRideMotorcycleInteract>().Value;
		}

		// Token: 0x06032006 RID: 204806 RVA: 0x006C41A8 File Offset: 0x006C23A8
		public ISitDown OptionAsISitDown()
		{
			return this.Option<ISitDown>().Value;
		}

		// Token: 0x06032007 RID: 204807 RVA: 0x006C41C4 File Offset: 0x006C23C4
		public ISitOnGround OptionAsISitOnGround()
		{
			return this.Option<ISitOnGround>().Value;
		}

		// Token: 0x06032008 RID: 204808 RVA: 0x006C41E0 File Offset: 0x006C23E0
		public ISoar OptionAsISoar()
		{
			return this.Option<ISoar>().Value;
		}

		// Token: 0x06032009 RID: 204809 RVA: 0x006C41FC File Offset: 0x006C23FC
		public ISoar2 OptionAsISoar2()
		{
			return this.Option<ISoar2>().Value;
		}

		// Token: 0x0603200A RID: 204810 RVA: 0x006C4218 File Offset: 0x006C2418
		public IStandControl OptionAsIStandControl()
		{
			return this.Option<IStandControl>().Value;
		}

		// Token: 0x0603200B RID: 204811 RVA: 0x006C4234 File Offset: 0x006C2434
		public IStandControl2 OptionAsIStandControl2()
		{
			return this.Option<IStandControl2>().Value;
		}

		// Token: 0x0603200C RID: 204812 RVA: 0x006C4250 File Offset: 0x006C2450
		public ISunPalaceInteract OptionAsISunPalaceInteract()
		{
			return this.Option<ISunPalaceInteract>().Value;
		}

		// Token: 0x0603200D RID: 204813 RVA: 0x006C426C File Offset: 0x006C246C
		public ISuperCatapult OptionAsISuperCatapult()
		{
			return this.Option<ISuperCatapult>().Value;
		}

		// Token: 0x0603200E RID: 204814 RVA: 0x006C4288 File Offset: 0x006C2488
		public ISwing OptionAsISwing()
		{
			return this.Option<ISwing>().Value;
		}

		// Token: 0x0603200F RID: 204815 RVA: 0x006C42A4 File Offset: 0x006C24A4
		public ISwingGetUp OptionAsISwingGetUp()
		{
			return this.Option<ISwingGetUp>().Value;
		}

		// Token: 0x06032010 RID: 204816 RVA: 0x006C42C0 File Offset: 0x006C24C0
		public IWindProtagonistParkour1 OptionAsIWindProtagonistParkour1()
		{
			return this.Option<IWindProtagonistParkour1>().Value;
		}

		// Token: 0x06032011 RID: 204817 RVA: 0x006C42DC File Offset: 0x006C24DC
		public IWindProtagonistParkour2 OptionAsIWindProtagonistParkour2()
		{
			return this.Option<IWindProtagonistParkour2>().Value;
		}

		// Token: 0x06032012 RID: 204818 RVA: 0x006C42F8 File Offset: 0x006C24F8
		public IWindProtagonistParkour3 OptionAsIWindProtagonistParkour3()
		{
			return this.Option<IWindProtagonistParkour3>().Value;
		}

		// Token: 0x06032013 RID: 204819 RVA: 0x006C4314 File Offset: 0x006C2514
		public IWindProtagonistParkour4 OptionAsIWindProtagonistParkour4()
		{
			return this.Option<IWindProtagonistParkour4>().Value;
		}

		// Token: 0x06032014 RID: 204820 RVA: 0x006C4330 File Offset: 0x006C2530
		public IWindProtagonistParkour5 OptionAsIWindProtagonistParkour5()
		{
			return this.Option<IWindProtagonistParkour5>().Value;
		}

		// Token: 0x1700D31D RID: 54045
		// (get) Token: 0x06032015 RID: 204821 RVA: 0x006C434C File Offset: 0x006C254C
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

		// Token: 0x1700D31E RID: 54046
		// (get) Token: 0x06032016 RID: 204822 RVA: 0x006C4388 File Offset: 0x006C2588
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

		// Token: 0x06032017 RID: 204823 RVA: 0x006C43C5 File Offset: 0x006C25C5
		public static Offset<ILeisureInteract> CreateILeisureInteract(FlatBufferBuilder builder, TLeisureInteractOption Option_type = TLeisureInteractOption.NONE, int OptionOffset = 0, int SceneEntity = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILeisureInteract.AddSceneEntity(builder, SceneEntity);
			ILeisureInteract.AddOption(builder, OptionOffset);
			ILeisureInteract.AddNullMask(builder, NullMask);
			ILeisureInteract.AddOptionType(builder, Option_type);
			return ILeisureInteract.EndILeisureInteract(builder);
		}

		// Token: 0x06032018 RID: 204824 RVA: 0x006C43F1 File Offset: 0x006C25F1
		public static void StartILeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032019 RID: 204825 RVA: 0x006C43FA File Offset: 0x006C25FA
		public static void AddOptionType(FlatBufferBuilder builder, TLeisureInteractOption optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x0603201A RID: 204826 RVA: 0x006C4405 File Offset: 0x006C2605
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x0603201B RID: 204827 RVA: 0x006C4410 File Offset: 0x006C2610
		public static void AddSceneEntity(FlatBufferBuilder builder, int sceneEntity)
		{
			builder.AddInt(2, sceneEntity, 0);
		}

		// Token: 0x0603201C RID: 204828 RVA: 0x006C441B File Offset: 0x006C261B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603201D RID: 204829 RVA: 0x006C4426 File Offset: 0x006C2626
		public static Offset<ILeisureInteract> EndILeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILeisureInteract>(builder.EndTable());
		}

		// Token: 0x0603201E RID: 204830 RVA: 0x006C4434 File Offset: 0x006C2634
		public ILeisureInteractT UnPack()
		{
			ILeisureInteractT leisureInteractT = new ILeisureInteractT();
			this.UnPackTo(leisureInteractT);
			return leisureInteractT;
		}

		// Token: 0x0603201F RID: 204831 RVA: 0x006C4450 File Offset: 0x006C2650
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

		// Token: 0x06032020 RID: 204832 RVA: 0x006C5218 File Offset: 0x006C3418
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

		// Token: 0x04012008 RID: 73736
		private Table __p;
	}
}
