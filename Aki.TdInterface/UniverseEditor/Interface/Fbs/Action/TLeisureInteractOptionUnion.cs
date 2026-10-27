using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007702 RID: 30466
	public class TLeisureInteractOptionUnion
	{
		// Token: 0x1700E645 RID: 58949
		// (get) Token: 0x060375EE RID: 226798 RVA: 0x0077FC10 File Offset: 0x0077DE10
		// (set) Token: 0x060375EF RID: 226799 RVA: 0x0077FC18 File Offset: 0x0077DE18
		public TLeisureInteractOption Type { get; set; }

		// Token: 0x1700E646 RID: 58950
		// (get) Token: 0x060375F0 RID: 226800 RVA: 0x0077FC21 File Offset: 0x0077DE21
		// (set) Token: 0x060375F1 RID: 226801 RVA: 0x0077FC29 File Offset: 0x0077DE29
		public object Value { get; set; }

		// Token: 0x060375F2 RID: 226802 RVA: 0x0077FC32 File Offset: 0x0077DE32
		public TLeisureInteractOptionUnion()
		{
			this.Type = TLeisureInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x060375F3 RID: 226803 RVA: 0x0077FC48 File Offset: 0x0077DE48
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375F4 RID: 226804 RVA: 0x0077FC5A File Offset: 0x0077DE5A
		public IBounceT AsIBounce()
		{
			return this.As<IBounceT>();
		}

		// Token: 0x060375F5 RID: 226805 RVA: 0x0077FC62 File Offset: 0x0077DE62
		public static TLeisureInteractOptionUnion FromIBounce(IBounceT _ibounce)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IBounce,
				Value = _ibounce
			};
		}

		// Token: 0x060375F6 RID: 226806 RVA: 0x0077FC77 File Offset: 0x0077DE77
		public ICatapultT AsICatapult()
		{
			return this.As<ICatapultT>();
		}

		// Token: 0x060375F7 RID: 226807 RVA: 0x0077FC7F File Offset: 0x0077DE7F
		public static TLeisureInteractOptionUnion FromICatapult(ICatapultT _icatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ICatapult,
				Value = _icatapult
			};
		}

		// Token: 0x060375F8 RID: 226808 RVA: 0x0077FC94 File Offset: 0x0077DE94
		public ICustomSkillT AsICustomSkill()
		{
			return this.As<ICustomSkillT>();
		}

		// Token: 0x060375F9 RID: 226809 RVA: 0x0077FC9C File Offset: 0x0077DE9C
		public static TLeisureInteractOptionUnion FromICustomSkill(ICustomSkillT _icustomskill)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ICustomSkill,
				Value = _icustomskill
			};
		}

		// Token: 0x060375FA RID: 226810 RVA: 0x0077FCB1 File Offset: 0x0077DEB1
		public IFailurePoseInteractT AsIFailurePoseInteract()
		{
			return this.As<IFailurePoseInteractT>();
		}

		// Token: 0x060375FB RID: 226811 RVA: 0x0077FCB9 File Offset: 0x0077DEB9
		public static TLeisureInteractOptionUnion FromIFailurePoseInteract(IFailurePoseInteractT _ifailureposeinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFailurePoseInteract,
				Value = _ifailureposeinteract
			};
		}

		// Token: 0x060375FC RID: 226812 RVA: 0x0077FCCE File Offset: 0x0077DECE
		public IFaithJumpT AsIFaithJump()
		{
			return this.As<IFaithJumpT>();
		}

		// Token: 0x060375FD RID: 226813 RVA: 0x0077FCD6 File Offset: 0x0077DED6
		public static TLeisureInteractOptionUnion FromIFaithJump(IFaithJumpT _ifaithjump)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFaithJump,
				Value = _ifaithjump
			};
		}

		// Token: 0x060375FE RID: 226814 RVA: 0x0077FCEB File Offset: 0x0077DEEB
		public IFoxAutoJumpT AsIFoxAutoJump()
		{
			return this.As<IFoxAutoJumpT>();
		}

		// Token: 0x060375FF RID: 226815 RVA: 0x0077FCF3 File Offset: 0x0077DEF3
		public static TLeisureInteractOptionUnion FromIFoxAutoJump(IFoxAutoJumpT _ifoxautojump)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxAutoJump,
				Value = _ifoxautojump
			};
		}

		// Token: 0x06037600 RID: 226816 RVA: 0x0077FD08 File Offset: 0x0077DF08
		public IFoxPickUpT AsIFoxPickUp()
		{
			return this.As<IFoxPickUpT>();
		}

		// Token: 0x06037601 RID: 226817 RVA: 0x0077FD10 File Offset: 0x0077DF10
		public static TLeisureInteractOptionUnion FromIFoxPickUp(IFoxPickUpT _ifoxpickup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPickUp,
				Value = _ifoxpickup
			};
		}

		// Token: 0x06037602 RID: 226818 RVA: 0x0077FD25 File Offset: 0x0077DF25
		public IFoxPushBoxT AsIFoxPushBox()
		{
			return this.As<IFoxPushBoxT>();
		}

		// Token: 0x06037603 RID: 226819 RVA: 0x0077FD2D File Offset: 0x0077DF2D
		public static TLeisureInteractOptionUnion FromIFoxPushBox(IFoxPushBoxT _ifoxpushbox)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPushBox,
				Value = _ifoxpushbox
			};
		}

		// Token: 0x06037604 RID: 226820 RVA: 0x0077FD42 File Offset: 0x0077DF42
		public IFoxPutDownT AsIFoxPutDown()
		{
			return this.As<IFoxPutDownT>();
		}

		// Token: 0x06037605 RID: 226821 RVA: 0x0077FD4A File Offset: 0x0077DF4A
		public static TLeisureInteractOptionUnion FromIFoxPutDown(IFoxPutDownT _ifoxputdown)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPutDown,
				Value = _ifoxputdown
			};
		}

		// Token: 0x06037606 RID: 226822 RVA: 0x0077FD60 File Offset: 0x0077DF60
		public IFoxReversePushT AsIFoxReversePush()
		{
			return this.As<IFoxReversePushT>();
		}

		// Token: 0x06037607 RID: 226823 RVA: 0x0077FD68 File Offset: 0x0077DF68
		public static TLeisureInteractOptionUnion FromIFoxReversePush(IFoxReversePushT _ifoxreversepush)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxReversePush,
				Value = _ifoxreversepush
			};
		}

		// Token: 0x06037608 RID: 226824 RVA: 0x0077FD7E File Offset: 0x0077DF7E
		public IGameplayPose1InteractT AsIGameplayPose1Interact()
		{
			return this.As<IGameplayPose1InteractT>();
		}

		// Token: 0x06037609 RID: 226825 RVA: 0x0077FD86 File Offset: 0x0077DF86
		public static TLeisureInteractOptionUnion FromIGameplayPose1Interact(IGameplayPose1InteractT _igameplaypose1interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose1Interact,
				Value = _igameplaypose1interact
			};
		}

		// Token: 0x0603760A RID: 226826 RVA: 0x0077FD9C File Offset: 0x0077DF9C
		public IGameplayPose2InteractT AsIGameplayPose2Interact()
		{
			return this.As<IGameplayPose2InteractT>();
		}

		// Token: 0x0603760B RID: 226827 RVA: 0x0077FDA4 File Offset: 0x0077DFA4
		public static TLeisureInteractOptionUnion FromIGameplayPose2Interact(IGameplayPose2InteractT _igameplaypose2interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose2Interact,
				Value = _igameplaypose2interact
			};
		}

		// Token: 0x0603760C RID: 226828 RVA: 0x0077FDBA File Offset: 0x0077DFBA
		public IGameplayPose3InteractT AsIGameplayPose3Interact()
		{
			return this.As<IGameplayPose3InteractT>();
		}

		// Token: 0x0603760D RID: 226829 RVA: 0x0077FDC2 File Offset: 0x0077DFC2
		public static TLeisureInteractOptionUnion FromIGameplayPose3Interact(IGameplayPose3InteractT _igameplaypose3interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose3Interact,
				Value = _igameplaypose3interact
			};
		}

		// Token: 0x0603760E RID: 226830 RVA: 0x0077FDD8 File Offset: 0x0077DFD8
		public IGetOffMotorcycleInteractT AsIGetOffMotorcycleInteract()
		{
			return this.As<IGetOffMotorcycleInteractT>();
		}

		// Token: 0x0603760F RID: 226831 RVA: 0x0077FDE0 File Offset: 0x0077DFE0
		public static TLeisureInteractOptionUnion FromIGetOffMotorcycleInteract(IGetOffMotorcycleInteractT _igetoffmotorcycleinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGetOffMotorcycleInteract,
				Value = _igetoffmotorcycleinteract
			};
		}

		// Token: 0x06037610 RID: 226832 RVA: 0x0077FDF6 File Offset: 0x0077DFF6
		public IGetUpT AsIGetUp()
		{
			return this.As<IGetUpT>();
		}

		// Token: 0x06037611 RID: 226833 RVA: 0x0077FDFE File Offset: 0x0077DFFE
		public static TLeisureInteractOptionUnion FromIGetUp(IGetUpT _igetup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGetUp,
				Value = _igetup
			};
		}

		// Token: 0x06037612 RID: 226834 RVA: 0x0077FE14 File Offset: 0x0077E014
		public IGlideT AsIGlide()
		{
			return this.As<IGlideT>();
		}

		// Token: 0x06037613 RID: 226835 RVA: 0x0077FE1C File Offset: 0x0077E01C
		public static TLeisureInteractOptionUnion FromIGlide(IGlideT _iglide)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGlide,
				Value = _iglide
			};
		}

		// Token: 0x06037614 RID: 226836 RVA: 0x0077FE32 File Offset: 0x0077E032
		public IHookLockInteractT AsIHookLockInteract()
		{
			return this.As<IHookLockInteractT>();
		}

		// Token: 0x06037615 RID: 226837 RVA: 0x0077FE3A File Offset: 0x0077E03A
		public static TLeisureInteractOptionUnion FromIHookLockInteract(IHookLockInteractT _ihooklockinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IHookLockInteract,
				Value = _ihooklockinteract
			};
		}

		// Token: 0x06037616 RID: 226838 RVA: 0x0077FE50 File Offset: 0x0077E050
		public IKiteHookInteractT AsIKiteHookInteract()
		{
			return this.As<IKiteHookInteractT>();
		}

		// Token: 0x06037617 RID: 226839 RVA: 0x0077FE58 File Offset: 0x0077E058
		public static TLeisureInteractOptionUnion FromIKiteHookInteract(IKiteHookInteractT _ikitehookinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IKiteHookInteract,
				Value = _ikitehookinteract
			};
		}

		// Token: 0x06037618 RID: 226840 RVA: 0x0077FE6E File Offset: 0x0077E06E
		public ILandSlideEndInteractT AsILandSlideEndInteract()
		{
			return this.As<ILandSlideEndInteractT>();
		}

		// Token: 0x06037619 RID: 226841 RVA: 0x0077FE76 File Offset: 0x0077E076
		public static TLeisureInteractOptionUnion FromILandSlideEndInteract(ILandSlideEndInteractT _ilandslideendinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ILandSlideEndInteract,
				Value = _ilandslideendinteract
			};
		}

		// Token: 0x0603761A RID: 226842 RVA: 0x0077FE8C File Offset: 0x0077E08C
		public ILandSlideInteractT AsILandSlideInteract()
		{
			return this.As<ILandSlideInteractT>();
		}

		// Token: 0x0603761B RID: 226843 RVA: 0x0077FE94 File Offset: 0x0077E094
		public static TLeisureInteractOptionUnion FromILandSlideInteract(ILandSlideInteractT _ilandslideinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ILandSlideInteract,
				Value = _ilandslideinteract
			};
		}

		// Token: 0x0603761C RID: 226844 RVA: 0x0077FEAA File Offset: 0x0077E0AA
		public IManipulateT AsIManipulate()
		{
			return this.As<IManipulateT>();
		}

		// Token: 0x0603761D RID: 226845 RVA: 0x0077FEB2 File Offset: 0x0077E0B2
		public static TLeisureInteractOptionUnion FromIManipulate(IManipulateT _imanipulate)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IManipulate,
				Value = _imanipulate
			};
		}

		// Token: 0x0603761E RID: 226846 RVA: 0x0077FEC8 File Offset: 0x0077E0C8
		public IMechEscortFlyT AsIMechEscortFly()
		{
			return this.As<IMechEscortFlyT>();
		}

		// Token: 0x0603761F RID: 226847 RVA: 0x0077FED0 File Offset: 0x0077E0D0
		public static TLeisureInteractOptionUnion FromIMechEscortFly(IMechEscortFlyT _imechescortfly)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMechEscortFly,
				Value = _imechescortfly
			};
		}

		// Token: 0x06037620 RID: 226848 RVA: 0x0077FEE6 File Offset: 0x0077E0E6
		public IMechStuntT AsIMechStunt()
		{
			return this.As<IMechStuntT>();
		}

		// Token: 0x06037621 RID: 226849 RVA: 0x0077FEEE File Offset: 0x0077E0EE
		public static TLeisureInteractOptionUnion FromIMechStunt(IMechStuntT _imechstunt)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMechStunt,
				Value = _imechstunt
			};
		}

		// Token: 0x06037622 RID: 226850 RVA: 0x0077FF04 File Offset: 0x0077E104
		public IMoneHackingDoorInteractT AsIMoneHackingDoorInteract()
		{
			return this.As<IMoneHackingDoorInteractT>();
		}

		// Token: 0x06037623 RID: 226851 RVA: 0x0077FF0C File Offset: 0x0077E10C
		public static TLeisureInteractOptionUnion FromIMoneHackingDoorInteract(IMoneHackingDoorInteractT _imonehackingdoorinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMoneHackingDoorInteract,
				Value = _imonehackingdoorinteract
			};
		}

		// Token: 0x06037624 RID: 226852 RVA: 0x0077FF22 File Offset: 0x0077E122
		public IMotorBounceT AsIMotorBounce()
		{
			return this.As<IMotorBounceT>();
		}

		// Token: 0x06037625 RID: 226853 RVA: 0x0077FF2A File Offset: 0x0077E12A
		public static TLeisureInteractOptionUnion FromIMotorBounce(IMotorBounceT _imotorbounce)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorBounce,
				Value = _imotorbounce
			};
		}

		// Token: 0x06037626 RID: 226854 RVA: 0x0077FF40 File Offset: 0x0077E140
		public IMotorCatapultT AsIMotorCatapult()
		{
			return this.As<IMotorCatapultT>();
		}

		// Token: 0x06037627 RID: 226855 RVA: 0x0077FF48 File Offset: 0x0077E148
		public static TLeisureInteractOptionUnion FromIMotorCatapult(IMotorCatapultT _imotorcatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorCatapult,
				Value = _imotorcatapult
			};
		}

		// Token: 0x06037628 RID: 226856 RVA: 0x0077FF5E File Offset: 0x0077E15E
		public IMotorEnterSlideT AsIMotorEnterSlide()
		{
			return this.As<IMotorEnterSlideT>();
		}

		// Token: 0x06037629 RID: 226857 RVA: 0x0077FF66 File Offset: 0x0077E166
		public static TLeisureInteractOptionUnion FromIMotorEnterSlide(IMotorEnterSlideT _imotorenterslide)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorEnterSlide,
				Value = _imotorenterslide
			};
		}

		// Token: 0x0603762A RID: 226858 RVA: 0x0077FF7C File Offset: 0x0077E17C
		public IMotorSoarInteractT AsIMotorSoarInteract()
		{
			return this.As<IMotorSoarInteractT>();
		}

		// Token: 0x0603762B RID: 226859 RVA: 0x0077FF84 File Offset: 0x0077E184
		public static TLeisureInteractOptionUnion FromIMotorSoarInteract(IMotorSoarInteractT _imotorsoarinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorSoarInteract,
				Value = _imotorsoarinteract
			};
		}

		// Token: 0x0603762C RID: 226860 RVA: 0x0077FF9A File Offset: 0x0077E19A
		public IPainCoveringHeadT AsIPainCoveringHead()
		{
			return this.As<IPainCoveringHeadT>();
		}

		// Token: 0x0603762D RID: 226861 RVA: 0x0077FFA2 File Offset: 0x0077E1A2
		public static TLeisureInteractOptionUnion FromIPainCoveringHead(IPainCoveringHeadT _ipaincoveringhead)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IPainCoveringHead,
				Value = _ipaincoveringhead
			};
		}

		// Token: 0x0603762E RID: 226862 RVA: 0x0077FFB8 File Offset: 0x0077E1B8
		public IParticipateGroupPatrolT AsIParticipateGroupPatrol()
		{
			return this.As<IParticipateGroupPatrolT>();
		}

		// Token: 0x0603762F RID: 226863 RVA: 0x0077FFC0 File Offset: 0x0077E1C0
		public static TLeisureInteractOptionUnion FromIParticipateGroupPatrol(IParticipateGroupPatrolT _iparticipategrouppatrol)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IParticipateGroupPatrol,
				Value = _iparticipategrouppatrol
			};
		}

		// Token: 0x06037630 RID: 226864 RVA: 0x0077FFD6 File Offset: 0x0077E1D6
		public IQiuyuanLongPressQinggongT AsIQiuyuanLongPressQinggong()
		{
			return this.As<IQiuyuanLongPressQinggongT>();
		}

		// Token: 0x06037631 RID: 226865 RVA: 0x0077FFDE File Offset: 0x0077E1DE
		public static TLeisureInteractOptionUnion FromIQiuyuanLongPressQinggong(IQiuyuanLongPressQinggongT _iqiuyuanlongpressqinggong)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanLongPressQinggong,
				Value = _iqiuyuanlongpressqinggong
			};
		}

		// Token: 0x06037632 RID: 226866 RVA: 0x0077FFF4 File Offset: 0x0077E1F4
		public IQiuyuanQinggongEndT AsIQiuyuanQinggongEnd()
		{
			return this.As<IQiuyuanQinggongEndT>();
		}

		// Token: 0x06037633 RID: 226867 RVA: 0x0077FFFC File Offset: 0x0077E1FC
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongEnd(IQiuyuanQinggongEndT _iqiuyuanqinggongend)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongEnd,
				Value = _iqiuyuanqinggongend
			};
		}

		// Token: 0x06037634 RID: 226868 RVA: 0x00780012 File Offset: 0x0077E212
		public IQiuyuanQinggongExploration1T AsIQiuyuanQinggongExploration1()
		{
			return this.As<IQiuyuanQinggongExploration1T>();
		}

		// Token: 0x06037635 RID: 226869 RVA: 0x0078001A File Offset: 0x0077E21A
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration1(IQiuyuanQinggongExploration1T _iqiuyuanqinggongexploration1)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration1,
				Value = _iqiuyuanqinggongexploration1
			};
		}

		// Token: 0x06037636 RID: 226870 RVA: 0x00780030 File Offset: 0x0077E230
		public IQiuyuanQinggongExploration2T AsIQiuyuanQinggongExploration2()
		{
			return this.As<IQiuyuanQinggongExploration2T>();
		}

		// Token: 0x06037637 RID: 226871 RVA: 0x00780038 File Offset: 0x0077E238
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration2(IQiuyuanQinggongExploration2T _iqiuyuanqinggongexploration2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration2,
				Value = _iqiuyuanqinggongexploration2
			};
		}

		// Token: 0x06037638 RID: 226872 RVA: 0x0078004E File Offset: 0x0077E24E
		public IQiuyuanQinggongExploration3T AsIQiuyuanQinggongExploration3()
		{
			return this.As<IQiuyuanQinggongExploration3T>();
		}

		// Token: 0x06037639 RID: 226873 RVA: 0x00780056 File Offset: 0x0077E256
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration3(IQiuyuanQinggongExploration3T _iqiuyuanqinggongexploration3)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration3,
				Value = _iqiuyuanqinggongexploration3
			};
		}

		// Token: 0x0603763A RID: 226874 RVA: 0x0078006C File Offset: 0x0077E26C
		public IQiuyuanQinggongExploration4T AsIQiuyuanQinggongExploration4()
		{
			return this.As<IQiuyuanQinggongExploration4T>();
		}

		// Token: 0x0603763B RID: 226875 RVA: 0x00780074 File Offset: 0x0077E274
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration4(IQiuyuanQinggongExploration4T _iqiuyuanqinggongexploration4)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration4,
				Value = _iqiuyuanqinggongexploration4
			};
		}

		// Token: 0x0603763C RID: 226876 RVA: 0x0078008A File Offset: 0x0077E28A
		public IQiuyuanQinggongHoveringT AsIQiuyuanQinggongHovering()
		{
			return this.As<IQiuyuanQinggongHoveringT>();
		}

		// Token: 0x0603763D RID: 226877 RVA: 0x00780092 File Offset: 0x0077E292
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongHovering(IQiuyuanQinggongHoveringT _iqiuyuanqinggonghovering)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongHovering,
				Value = _iqiuyuanqinggonghovering
			};
		}

		// Token: 0x0603763E RID: 226878 RVA: 0x007800A8 File Offset: 0x0077E2A8
		public IQiuyuanQinggongStraightT AsIQiuyuanQinggongStraight()
		{
			return this.As<IQiuyuanQinggongStraightT>();
		}

		// Token: 0x0603763F RID: 226879 RVA: 0x007800B0 File Offset: 0x0077E2B0
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongStraight(IQiuyuanQinggongStraightT _iqiuyuanqinggongstraight)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongStraight,
				Value = _iqiuyuanqinggongstraight
			};
		}

		// Token: 0x06037640 RID: 226880 RVA: 0x007800C6 File Offset: 0x0077E2C6
		public IRideMotorcycleInteractT AsIRideMotorcycleInteract()
		{
			return this.As<IRideMotorcycleInteractT>();
		}

		// Token: 0x06037641 RID: 226881 RVA: 0x007800CE File Offset: 0x0077E2CE
		public static TLeisureInteractOptionUnion FromIRideMotorcycleInteract(IRideMotorcycleInteractT _iridemotorcycleinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IRideMotorcycleInteract,
				Value = _iridemotorcycleinteract
			};
		}

		// Token: 0x06037642 RID: 226882 RVA: 0x007800E4 File Offset: 0x0077E2E4
		public ISitDownT AsISitDown()
		{
			return this.As<ISitDownT>();
		}

		// Token: 0x06037643 RID: 226883 RVA: 0x007800EC File Offset: 0x0077E2EC
		public static TLeisureInteractOptionUnion FromISitDown(ISitDownT _isitdown)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISitDown,
				Value = _isitdown
			};
		}

		// Token: 0x06037644 RID: 226884 RVA: 0x00780102 File Offset: 0x0077E302
		public ISitOnGroundT AsISitOnGround()
		{
			return this.As<ISitOnGroundT>();
		}

		// Token: 0x06037645 RID: 226885 RVA: 0x0078010A File Offset: 0x0077E30A
		public static TLeisureInteractOptionUnion FromISitOnGround(ISitOnGroundT _isitonground)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISitOnGround,
				Value = _isitonground
			};
		}

		// Token: 0x06037646 RID: 226886 RVA: 0x00780120 File Offset: 0x0077E320
		public ISoarT AsISoar()
		{
			return this.As<ISoarT>();
		}

		// Token: 0x06037647 RID: 226887 RVA: 0x00780128 File Offset: 0x0077E328
		public static TLeisureInteractOptionUnion FromISoar(ISoarT _isoar)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISoar,
				Value = _isoar
			};
		}

		// Token: 0x06037648 RID: 226888 RVA: 0x0078013E File Offset: 0x0077E33E
		public ISoar2T AsISoar2()
		{
			return this.As<ISoar2T>();
		}

		// Token: 0x06037649 RID: 226889 RVA: 0x00780146 File Offset: 0x0077E346
		public static TLeisureInteractOptionUnion FromISoar2(ISoar2T _isoar2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISoar2,
				Value = _isoar2
			};
		}

		// Token: 0x0603764A RID: 226890 RVA: 0x0078015C File Offset: 0x0077E35C
		public IStandControlT AsIStandControl()
		{
			return this.As<IStandControlT>();
		}

		// Token: 0x0603764B RID: 226891 RVA: 0x00780164 File Offset: 0x0077E364
		public static TLeisureInteractOptionUnion FromIStandControl(IStandControlT _istandcontrol)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IStandControl,
				Value = _istandcontrol
			};
		}

		// Token: 0x0603764C RID: 226892 RVA: 0x0078017A File Offset: 0x0077E37A
		public IStandControl2T AsIStandControl2()
		{
			return this.As<IStandControl2T>();
		}

		// Token: 0x0603764D RID: 226893 RVA: 0x00780182 File Offset: 0x0077E382
		public static TLeisureInteractOptionUnion FromIStandControl2(IStandControl2T _istandcontrol2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IStandControl2,
				Value = _istandcontrol2
			};
		}

		// Token: 0x0603764E RID: 226894 RVA: 0x00780198 File Offset: 0x0077E398
		public ISunPalaceInteractT AsISunPalaceInteract()
		{
			return this.As<ISunPalaceInteractT>();
		}

		// Token: 0x0603764F RID: 226895 RVA: 0x007801A0 File Offset: 0x0077E3A0
		public static TLeisureInteractOptionUnion FromISunPalaceInteract(ISunPalaceInteractT _isunpalaceinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISunPalaceInteract,
				Value = _isunpalaceinteract
			};
		}

		// Token: 0x06037650 RID: 226896 RVA: 0x007801B6 File Offset: 0x0077E3B6
		public ISuperCatapultT AsISuperCatapult()
		{
			return this.As<ISuperCatapultT>();
		}

		// Token: 0x06037651 RID: 226897 RVA: 0x007801BE File Offset: 0x0077E3BE
		public static TLeisureInteractOptionUnion FromISuperCatapult(ISuperCatapultT _isupercatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISuperCatapult,
				Value = _isupercatapult
			};
		}

		// Token: 0x06037652 RID: 226898 RVA: 0x007801D4 File Offset: 0x0077E3D4
		public ISwingT AsISwing()
		{
			return this.As<ISwingT>();
		}

		// Token: 0x06037653 RID: 226899 RVA: 0x007801DC File Offset: 0x0077E3DC
		public static TLeisureInteractOptionUnion FromISwing(ISwingT _iswing)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISwing,
				Value = _iswing
			};
		}

		// Token: 0x06037654 RID: 226900 RVA: 0x007801F2 File Offset: 0x0077E3F2
		public ISwingGetUpT AsISwingGetUp()
		{
			return this.As<ISwingGetUpT>();
		}

		// Token: 0x06037655 RID: 226901 RVA: 0x007801FA File Offset: 0x0077E3FA
		public static TLeisureInteractOptionUnion FromISwingGetUp(ISwingGetUpT _iswinggetup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISwingGetUp,
				Value = _iswinggetup
			};
		}

		// Token: 0x06037656 RID: 226902 RVA: 0x00780210 File Offset: 0x0077E410
		public IWindProtagonistParkour1T AsIWindProtagonistParkour1()
		{
			return this.As<IWindProtagonistParkour1T>();
		}

		// Token: 0x06037657 RID: 226903 RVA: 0x00780218 File Offset: 0x0077E418
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour1(IWindProtagonistParkour1T _iwindprotagonistparkour1)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour1,
				Value = _iwindprotagonistparkour1
			};
		}

		// Token: 0x06037658 RID: 226904 RVA: 0x0078022E File Offset: 0x0077E42E
		public IWindProtagonistParkour2T AsIWindProtagonistParkour2()
		{
			return this.As<IWindProtagonistParkour2T>();
		}

		// Token: 0x06037659 RID: 226905 RVA: 0x00780236 File Offset: 0x0077E436
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour2(IWindProtagonistParkour2T _iwindprotagonistparkour2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour2,
				Value = _iwindprotagonistparkour2
			};
		}

		// Token: 0x0603765A RID: 226906 RVA: 0x0078024C File Offset: 0x0077E44C
		public IWindProtagonistParkour3T AsIWindProtagonistParkour3()
		{
			return this.As<IWindProtagonistParkour3T>();
		}

		// Token: 0x0603765B RID: 226907 RVA: 0x00780254 File Offset: 0x0077E454
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour3(IWindProtagonistParkour3T _iwindprotagonistparkour3)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour3,
				Value = _iwindprotagonistparkour3
			};
		}

		// Token: 0x0603765C RID: 226908 RVA: 0x0078026A File Offset: 0x0077E46A
		public IWindProtagonistParkour4T AsIWindProtagonistParkour4()
		{
			return this.As<IWindProtagonistParkour4T>();
		}

		// Token: 0x0603765D RID: 226909 RVA: 0x00780272 File Offset: 0x0077E472
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour4(IWindProtagonistParkour4T _iwindprotagonistparkour4)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour4,
				Value = _iwindprotagonistparkour4
			};
		}

		// Token: 0x0603765E RID: 226910 RVA: 0x00780288 File Offset: 0x0077E488
		public IWindProtagonistParkour5T AsIWindProtagonistParkour5()
		{
			return this.As<IWindProtagonistParkour5T>();
		}

		// Token: 0x0603765F RID: 226911 RVA: 0x00780290 File Offset: 0x0077E490
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour5(IWindProtagonistParkour5T _iwindprotagonistparkour5)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour5,
				Value = _iwindprotagonistparkour5
			};
		}

		// Token: 0x06037660 RID: 226912 RVA: 0x007802A8 File Offset: 0x0077E4A8
		public static int Pack(FlatBufferBuilder builder, TLeisureInteractOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TLeisureInteractOption.IBounce:
				return IBounce.Pack(builder, _o.AsIBounce()).Value;
			case TLeisureInteractOption.ICatapult:
				return ICatapult.Pack(builder, _o.AsICatapult()).Value;
			case TLeisureInteractOption.ICustomSkill:
				return ICustomSkill.Pack(builder, _o.AsICustomSkill()).Value;
			case TLeisureInteractOption.IFailurePoseInteract:
				return IFailurePoseInteract.Pack(builder, _o.AsIFailurePoseInteract()).Value;
			case TLeisureInteractOption.IFaithJump:
				return IFaithJump.Pack(builder, _o.AsIFaithJump()).Value;
			case TLeisureInteractOption.IFoxAutoJump:
				return IFoxAutoJump.Pack(builder, _o.AsIFoxAutoJump()).Value;
			case TLeisureInteractOption.IFoxPickUp:
				return IFoxPickUp.Pack(builder, _o.AsIFoxPickUp()).Value;
			case TLeisureInteractOption.IFoxPushBox:
				return IFoxPushBox.Pack(builder, _o.AsIFoxPushBox()).Value;
			case TLeisureInteractOption.IFoxPutDown:
				return IFoxPutDown.Pack(builder, _o.AsIFoxPutDown()).Value;
			case TLeisureInteractOption.IFoxReversePush:
				return IFoxReversePush.Pack(builder, _o.AsIFoxReversePush()).Value;
			case TLeisureInteractOption.IGameplayPose1Interact:
				return IGameplayPose1Interact.Pack(builder, _o.AsIGameplayPose1Interact()).Value;
			case TLeisureInteractOption.IGameplayPose2Interact:
				return IGameplayPose2Interact.Pack(builder, _o.AsIGameplayPose2Interact()).Value;
			case TLeisureInteractOption.IGameplayPose3Interact:
				return IGameplayPose3Interact.Pack(builder, _o.AsIGameplayPose3Interact()).Value;
			case TLeisureInteractOption.IGetOffMotorcycleInteract:
				return IGetOffMotorcycleInteract.Pack(builder, _o.AsIGetOffMotorcycleInteract()).Value;
			case TLeisureInteractOption.IGetUp:
				return IGetUp.Pack(builder, _o.AsIGetUp()).Value;
			case TLeisureInteractOption.IGlide:
				return IGlide.Pack(builder, _o.AsIGlide()).Value;
			case TLeisureInteractOption.IHookLockInteract:
				return IHookLockInteract.Pack(builder, _o.AsIHookLockInteract()).Value;
			case TLeisureInteractOption.IKiteHookInteract:
				return IKiteHookInteract.Pack(builder, _o.AsIKiteHookInteract()).Value;
			case TLeisureInteractOption.ILandSlideEndInteract:
				return ILandSlideEndInteract.Pack(builder, _o.AsILandSlideEndInteract()).Value;
			case TLeisureInteractOption.ILandSlideInteract:
				return ILandSlideInteract.Pack(builder, _o.AsILandSlideInteract()).Value;
			case TLeisureInteractOption.IManipulate:
				return IManipulate.Pack(builder, _o.AsIManipulate()).Value;
			case TLeisureInteractOption.IMechEscortFly:
				return IMechEscortFly.Pack(builder, _o.AsIMechEscortFly()).Value;
			case TLeisureInteractOption.IMechStunt:
				return IMechStunt.Pack(builder, _o.AsIMechStunt()).Value;
			case TLeisureInteractOption.IMoneHackingDoorInteract:
				return IMoneHackingDoorInteract.Pack(builder, _o.AsIMoneHackingDoorInteract()).Value;
			case TLeisureInteractOption.IMotorBounce:
				return IMotorBounce.Pack(builder, _o.AsIMotorBounce()).Value;
			case TLeisureInteractOption.IMotorCatapult:
				return IMotorCatapult.Pack(builder, _o.AsIMotorCatapult()).Value;
			case TLeisureInteractOption.IMotorEnterSlide:
				return IMotorEnterSlide.Pack(builder, _o.AsIMotorEnterSlide()).Value;
			case TLeisureInteractOption.IMotorSoarInteract:
				return IMotorSoarInteract.Pack(builder, _o.AsIMotorSoarInteract()).Value;
			case TLeisureInteractOption.IPainCoveringHead:
				return IPainCoveringHead.Pack(builder, _o.AsIPainCoveringHead()).Value;
			case TLeisureInteractOption.IParticipateGroupPatrol:
				return IParticipateGroupPatrol.Pack(builder, _o.AsIParticipateGroupPatrol()).Value;
			case TLeisureInteractOption.IQiuyuanLongPressQinggong:
				return IQiuyuanLongPressQinggong.Pack(builder, _o.AsIQiuyuanLongPressQinggong()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongEnd:
				return IQiuyuanQinggongEnd.Pack(builder, _o.AsIQiuyuanQinggongEnd()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongExploration1:
				return IQiuyuanQinggongExploration1.Pack(builder, _o.AsIQiuyuanQinggongExploration1()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongExploration2:
				return IQiuyuanQinggongExploration2.Pack(builder, _o.AsIQiuyuanQinggongExploration2()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongExploration3:
				return IQiuyuanQinggongExploration3.Pack(builder, _o.AsIQiuyuanQinggongExploration3()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongExploration4:
				return IQiuyuanQinggongExploration4.Pack(builder, _o.AsIQiuyuanQinggongExploration4()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongHovering:
				return IQiuyuanQinggongHovering.Pack(builder, _o.AsIQiuyuanQinggongHovering()).Value;
			case TLeisureInteractOption.IQiuyuanQinggongStraight:
				return IQiuyuanQinggongStraight.Pack(builder, _o.AsIQiuyuanQinggongStraight()).Value;
			case TLeisureInteractOption.IRideMotorcycleInteract:
				return IRideMotorcycleInteract.Pack(builder, _o.AsIRideMotorcycleInteract()).Value;
			case TLeisureInteractOption.ISitDown:
				return ISitDown.Pack(builder, _o.AsISitDown()).Value;
			case TLeisureInteractOption.ISitOnGround:
				return ISitOnGround.Pack(builder, _o.AsISitOnGround()).Value;
			case TLeisureInteractOption.ISoar:
				return ISoar.Pack(builder, _o.AsISoar()).Value;
			case TLeisureInteractOption.ISoar2:
				return ISoar2.Pack(builder, _o.AsISoar2()).Value;
			case TLeisureInteractOption.IStandControl:
				return IStandControl.Pack(builder, _o.AsIStandControl()).Value;
			case TLeisureInteractOption.IStandControl2:
				return IStandControl2.Pack(builder, _o.AsIStandControl2()).Value;
			case TLeisureInteractOption.ISunPalaceInteract:
				return ISunPalaceInteract.Pack(builder, _o.AsISunPalaceInteract()).Value;
			case TLeisureInteractOption.ISuperCatapult:
				return ISuperCatapult.Pack(builder, _o.AsISuperCatapult()).Value;
			case TLeisureInteractOption.ISwing:
				return ISwing.Pack(builder, _o.AsISwing()).Value;
			case TLeisureInteractOption.ISwingGetUp:
				return ISwingGetUp.Pack(builder, _o.AsISwingGetUp()).Value;
			case TLeisureInteractOption.IWindProtagonistParkour1:
				return IWindProtagonistParkour1.Pack(builder, _o.AsIWindProtagonistParkour1()).Value;
			case TLeisureInteractOption.IWindProtagonistParkour2:
				return IWindProtagonistParkour2.Pack(builder, _o.AsIWindProtagonistParkour2()).Value;
			case TLeisureInteractOption.IWindProtagonistParkour3:
				return IWindProtagonistParkour3.Pack(builder, _o.AsIWindProtagonistParkour3()).Value;
			case TLeisureInteractOption.IWindProtagonistParkour4:
				return IWindProtagonistParkour4.Pack(builder, _o.AsIWindProtagonistParkour4()).Value;
			case TLeisureInteractOption.IWindProtagonistParkour5:
				return IWindProtagonistParkour5.Pack(builder, _o.AsIWindProtagonistParkour5()).Value;
			default:
				return 0;
			}
		}
	}
}
