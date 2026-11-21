using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007098 RID: 28824
	public class ILeisureInteractType_UnionUnion
	{
		// Token: 0x1700D325 RID: 54053
		// (get) Token: 0x0603203B RID: 204859 RVA: 0x006C54B1 File Offset: 0x006C36B1
		// (set) Token: 0x0603203C RID: 204860 RVA: 0x006C54B9 File Offset: 0x006C36B9
		public ILeisureInteractType_Union Type { get; set; }

		// Token: 0x1700D326 RID: 54054
		// (get) Token: 0x0603203D RID: 204861 RVA: 0x006C54C2 File Offset: 0x006C36C2
		// (set) Token: 0x0603203E RID: 204862 RVA: 0x006C54CA File Offset: 0x006C36CA
		public object Value { get; set; }

		// Token: 0x0603203F RID: 204863 RVA: 0x006C54D3 File Offset: 0x006C36D3
		public ILeisureInteractType_UnionUnion()
		{
			this.Type = ILeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032040 RID: 204864 RVA: 0x006C54E9 File Offset: 0x006C36E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032041 RID: 204865 RVA: 0x006C54FB File Offset: 0x006C36FB
		public ILeisureInteractTypeT AsILeisureInteractType()
		{
			return this.As<ILeisureInteractTypeT>();
		}

		// Token: 0x06032042 RID: 204866 RVA: 0x006C5503 File Offset: 0x006C3703
		public static ILeisureInteractType_UnionUnion FromILeisureInteractType(ILeisureInteractTypeT _ileisureinteracttype)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILeisureInteractType,
				Value = _ileisureinteracttype
			};
		}

		// Token: 0x06032043 RID: 204867 RVA: 0x006C5518 File Offset: 0x006C3718
		public ICustomSkillT AsICustomSkill()
		{
			return this.As<ICustomSkillT>();
		}

		// Token: 0x06032044 RID: 204868 RVA: 0x006C5520 File Offset: 0x006C3720
		public static ILeisureInteractType_UnionUnion FromICustomSkill(ICustomSkillT _icustomskill)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ICustomSkill,
				Value = _icustomskill
			};
		}

		// Token: 0x06032045 RID: 204869 RVA: 0x006C5535 File Offset: 0x006C3735
		public ISitDownT AsISitDown()
		{
			return this.As<ISitDownT>();
		}

		// Token: 0x06032046 RID: 204870 RVA: 0x006C553D File Offset: 0x006C373D
		public static ILeisureInteractType_UnionUnion FromISitDown(ISitDownT _isitdown)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISitDown,
				Value = _isitdown
			};
		}

		// Token: 0x06032047 RID: 204871 RVA: 0x006C5552 File Offset: 0x006C3752
		public ISitOnGroundT AsISitOnGround()
		{
			return this.As<ISitOnGroundT>();
		}

		// Token: 0x06032048 RID: 204872 RVA: 0x006C555A File Offset: 0x006C375A
		public static ILeisureInteractType_UnionUnion FromISitOnGround(ISitOnGroundT _isitonground)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISitOnGround,
				Value = _isitonground
			};
		}

		// Token: 0x06032049 RID: 204873 RVA: 0x006C556F File Offset: 0x006C376F
		public IBounceT AsIBounce()
		{
			return this.As<IBounceT>();
		}

		// Token: 0x0603204A RID: 204874 RVA: 0x006C5577 File Offset: 0x006C3777
		public static ILeisureInteractType_UnionUnion FromIBounce(IBounceT _ibounce)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IBounce,
				Value = _ibounce
			};
		}

		// Token: 0x0603204B RID: 204875 RVA: 0x006C558C File Offset: 0x006C378C
		public IMotorBounceT AsIMotorBounce()
		{
			return this.As<IMotorBounceT>();
		}

		// Token: 0x0603204C RID: 204876 RVA: 0x006C5594 File Offset: 0x006C3794
		public static ILeisureInteractType_UnionUnion FromIMotorBounce(IMotorBounceT _imotorbounce)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorBounce,
				Value = _imotorbounce
			};
		}

		// Token: 0x0603204D RID: 204877 RVA: 0x006C55A9 File Offset: 0x006C37A9
		public IMotorCatapultT AsIMotorCatapult()
		{
			return this.As<IMotorCatapultT>();
		}

		// Token: 0x0603204E RID: 204878 RVA: 0x006C55B1 File Offset: 0x006C37B1
		public static ILeisureInteractType_UnionUnion FromIMotorCatapult(IMotorCatapultT _imotorcatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorCatapult,
				Value = _imotorcatapult
			};
		}

		// Token: 0x0603204F RID: 204879 RVA: 0x006C55C6 File Offset: 0x006C37C6
		public ICatapultT AsICatapult()
		{
			return this.As<ICatapultT>();
		}

		// Token: 0x06032050 RID: 204880 RVA: 0x006C55CE File Offset: 0x006C37CE
		public static ILeisureInteractType_UnionUnion FromICatapult(ICatapultT _icatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ICatapult,
				Value = _icatapult
			};
		}

		// Token: 0x06032051 RID: 204881 RVA: 0x006C55E3 File Offset: 0x006C37E3
		public ISuperCatapultT AsISuperCatapult()
		{
			return this.As<ISuperCatapultT>();
		}

		// Token: 0x06032052 RID: 204882 RVA: 0x006C55EB File Offset: 0x006C37EB
		public static ILeisureInteractType_UnionUnion FromISuperCatapult(ISuperCatapultT _isupercatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISuperCatapult,
				Value = _isupercatapult
			};
		}

		// Token: 0x06032053 RID: 204883 RVA: 0x006C5601 File Offset: 0x006C3801
		public IManipulateT AsIManipulate()
		{
			return this.As<IManipulateT>();
		}

		// Token: 0x06032054 RID: 204884 RVA: 0x006C5609 File Offset: 0x006C3809
		public static ILeisureInteractType_UnionUnion FromIManipulate(IManipulateT _imanipulate)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IManipulate,
				Value = _imanipulate
			};
		}

		// Token: 0x06032055 RID: 204885 RVA: 0x006C561F File Offset: 0x006C381F
		public IStandControlT AsIStandControl()
		{
			return this.As<IStandControlT>();
		}

		// Token: 0x06032056 RID: 204886 RVA: 0x006C5627 File Offset: 0x006C3827
		public static ILeisureInteractType_UnionUnion FromIStandControl(IStandControlT _istandcontrol)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IStandControl,
				Value = _istandcontrol
			};
		}

		// Token: 0x06032057 RID: 204887 RVA: 0x006C563D File Offset: 0x006C383D
		public IStandControl2T AsIStandControl2()
		{
			return this.As<IStandControl2T>();
		}

		// Token: 0x06032058 RID: 204888 RVA: 0x006C5645 File Offset: 0x006C3845
		public static ILeisureInteractType_UnionUnion FromIStandControl2(IStandControl2T _istandcontrol2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IStandControl2,
				Value = _istandcontrol2
			};
		}

		// Token: 0x06032059 RID: 204889 RVA: 0x006C565B File Offset: 0x006C385B
		public ISoarT AsISoar()
		{
			return this.As<ISoarT>();
		}

		// Token: 0x0603205A RID: 204890 RVA: 0x006C5663 File Offset: 0x006C3863
		public static ILeisureInteractType_UnionUnion FromISoar(ISoarT _isoar)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISoar,
				Value = _isoar
			};
		}

		// Token: 0x0603205B RID: 204891 RVA: 0x006C5679 File Offset: 0x006C3879
		public ISoar2T AsISoar2()
		{
			return this.As<ISoar2T>();
		}

		// Token: 0x0603205C RID: 204892 RVA: 0x006C5681 File Offset: 0x006C3881
		public static ILeisureInteractType_UnionUnion FromISoar2(ISoar2T _isoar2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISoar2,
				Value = _isoar2
			};
		}

		// Token: 0x0603205D RID: 204893 RVA: 0x006C5697 File Offset: 0x006C3897
		public IGlideT AsIGlide()
		{
			return this.As<IGlideT>();
		}

		// Token: 0x0603205E RID: 204894 RVA: 0x006C569F File Offset: 0x006C389F
		public static ILeisureInteractType_UnionUnion FromIGlide(IGlideT _iglide)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGlide,
				Value = _iglide
			};
		}

		// Token: 0x0603205F RID: 204895 RVA: 0x006C56B5 File Offset: 0x006C38B5
		public IGetUpT AsIGetUp()
		{
			return this.As<IGetUpT>();
		}

		// Token: 0x06032060 RID: 204896 RVA: 0x006C56BD File Offset: 0x006C38BD
		public static ILeisureInteractType_UnionUnion FromIGetUp(IGetUpT _igetup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGetUp,
				Value = _igetup
			};
		}

		// Token: 0x06032061 RID: 204897 RVA: 0x006C56D3 File Offset: 0x006C38D3
		public IHookLockInteractT AsIHookLockInteract()
		{
			return this.As<IHookLockInteractT>();
		}

		// Token: 0x06032062 RID: 204898 RVA: 0x006C56DB File Offset: 0x006C38DB
		public static ILeisureInteractType_UnionUnion FromIHookLockInteract(IHookLockInteractT _ihooklockinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IHookLockInteract,
				Value = _ihooklockinteract
			};
		}

		// Token: 0x06032063 RID: 204899 RVA: 0x006C56F1 File Offset: 0x006C38F1
		public IKiteHookInteractT AsIKiteHookInteract()
		{
			return this.As<IKiteHookInteractT>();
		}

		// Token: 0x06032064 RID: 204900 RVA: 0x006C56F9 File Offset: 0x006C38F9
		public static ILeisureInteractType_UnionUnion FromIKiteHookInteract(IKiteHookInteractT _ikitehookinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IKiteHookInteract,
				Value = _ikitehookinteract
			};
		}

		// Token: 0x06032065 RID: 204901 RVA: 0x006C570F File Offset: 0x006C390F
		public IFailurePoseInteractT AsIFailurePoseInteract()
		{
			return this.As<IFailurePoseInteractT>();
		}

		// Token: 0x06032066 RID: 204902 RVA: 0x006C5717 File Offset: 0x006C3917
		public static ILeisureInteractType_UnionUnion FromIFailurePoseInteract(IFailurePoseInteractT _ifailureposeinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFailurePoseInteract,
				Value = _ifailureposeinteract
			};
		}

		// Token: 0x06032067 RID: 204903 RVA: 0x006C572D File Offset: 0x006C392D
		public IGameplayPose1InteractT AsIGameplayPose1Interact()
		{
			return this.As<IGameplayPose1InteractT>();
		}

		// Token: 0x06032068 RID: 204904 RVA: 0x006C5735 File Offset: 0x006C3935
		public static ILeisureInteractType_UnionUnion FromIGameplayPose1Interact(IGameplayPose1InteractT _igameplaypose1interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose1Interact,
				Value = _igameplaypose1interact
			};
		}

		// Token: 0x06032069 RID: 204905 RVA: 0x006C574B File Offset: 0x006C394B
		public IGameplayPose2InteractT AsIGameplayPose2Interact()
		{
			return this.As<IGameplayPose2InteractT>();
		}

		// Token: 0x0603206A RID: 204906 RVA: 0x006C5753 File Offset: 0x006C3953
		public static ILeisureInteractType_UnionUnion FromIGameplayPose2Interact(IGameplayPose2InteractT _igameplaypose2interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose2Interact,
				Value = _igameplaypose2interact
			};
		}

		// Token: 0x0603206B RID: 204907 RVA: 0x006C5769 File Offset: 0x006C3969
		public IGameplayPose3InteractT AsIGameplayPose3Interact()
		{
			return this.As<IGameplayPose3InteractT>();
		}

		// Token: 0x0603206C RID: 204908 RVA: 0x006C5771 File Offset: 0x006C3971
		public static ILeisureInteractType_UnionUnion FromIGameplayPose3Interact(IGameplayPose3InteractT _igameplaypose3interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose3Interact,
				Value = _igameplaypose3interact
			};
		}

		// Token: 0x0603206D RID: 204909 RVA: 0x006C5787 File Offset: 0x006C3987
		public IFaithJumpT AsIFaithJump()
		{
			return this.As<IFaithJumpT>();
		}

		// Token: 0x0603206E RID: 204910 RVA: 0x006C578F File Offset: 0x006C398F
		public static ILeisureInteractType_UnionUnion FromIFaithJump(IFaithJumpT _ifaithjump)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFaithJump,
				Value = _ifaithjump
			};
		}

		// Token: 0x0603206F RID: 204911 RVA: 0x006C57A5 File Offset: 0x006C39A5
		public IWindProtagonistParkour1T AsIWindProtagonistParkour1()
		{
			return this.As<IWindProtagonistParkour1T>();
		}

		// Token: 0x06032070 RID: 204912 RVA: 0x006C57AD File Offset: 0x006C39AD
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour1(IWindProtagonistParkour1T _iwindprotagonistparkour1)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour1,
				Value = _iwindprotagonistparkour1
			};
		}

		// Token: 0x06032071 RID: 204913 RVA: 0x006C57C3 File Offset: 0x006C39C3
		public IWindProtagonistParkour2T AsIWindProtagonistParkour2()
		{
			return this.As<IWindProtagonistParkour2T>();
		}

		// Token: 0x06032072 RID: 204914 RVA: 0x006C57CB File Offset: 0x006C39CB
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour2(IWindProtagonistParkour2T _iwindprotagonistparkour2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour2,
				Value = _iwindprotagonistparkour2
			};
		}

		// Token: 0x06032073 RID: 204915 RVA: 0x006C57E1 File Offset: 0x006C39E1
		public IWindProtagonistParkour3T AsIWindProtagonistParkour3()
		{
			return this.As<IWindProtagonistParkour3T>();
		}

		// Token: 0x06032074 RID: 204916 RVA: 0x006C57E9 File Offset: 0x006C39E9
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour3(IWindProtagonistParkour3T _iwindprotagonistparkour3)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour3,
				Value = _iwindprotagonistparkour3
			};
		}

		// Token: 0x06032075 RID: 204917 RVA: 0x006C57FF File Offset: 0x006C39FF
		public IWindProtagonistParkour4T AsIWindProtagonistParkour4()
		{
			return this.As<IWindProtagonistParkour4T>();
		}

		// Token: 0x06032076 RID: 204918 RVA: 0x006C5807 File Offset: 0x006C3A07
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour4(IWindProtagonistParkour4T _iwindprotagonistparkour4)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour4,
				Value = _iwindprotagonistparkour4
			};
		}

		// Token: 0x06032077 RID: 204919 RVA: 0x006C581D File Offset: 0x006C3A1D
		public IWindProtagonistParkour5T AsIWindProtagonistParkour5()
		{
			return this.As<IWindProtagonistParkour5T>();
		}

		// Token: 0x06032078 RID: 204920 RVA: 0x006C5825 File Offset: 0x006C3A25
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour5(IWindProtagonistParkour5T _iwindprotagonistparkour5)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour5,
				Value = _iwindprotagonistparkour5
			};
		}

		// Token: 0x06032079 RID: 204921 RVA: 0x006C583B File Offset: 0x006C3A3B
		public IPainCoveringHeadT AsIPainCoveringHead()
		{
			return this.As<IPainCoveringHeadT>();
		}

		// Token: 0x0603207A RID: 204922 RVA: 0x006C5843 File Offset: 0x006C3A43
		public static ILeisureInteractType_UnionUnion FromIPainCoveringHead(IPainCoveringHeadT _ipaincoveringhead)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IPainCoveringHead,
				Value = _ipaincoveringhead
			};
		}

		// Token: 0x0603207B RID: 204923 RVA: 0x006C5859 File Offset: 0x006C3A59
		public ISwingT AsISwing()
		{
			return this.As<ISwingT>();
		}

		// Token: 0x0603207C RID: 204924 RVA: 0x006C5861 File Offset: 0x006C3A61
		public static ILeisureInteractType_UnionUnion FromISwing(ISwingT _iswing)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISwing,
				Value = _iswing
			};
		}

		// Token: 0x0603207D RID: 204925 RVA: 0x006C5877 File Offset: 0x006C3A77
		public ISwingGetUpT AsISwingGetUp()
		{
			return this.As<ISwingGetUpT>();
		}

		// Token: 0x0603207E RID: 204926 RVA: 0x006C587F File Offset: 0x006C3A7F
		public static ILeisureInteractType_UnionUnion FromISwingGetUp(ISwingGetUpT _iswinggetup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISwingGetUp,
				Value = _iswinggetup
			};
		}

		// Token: 0x0603207F RID: 204927 RVA: 0x006C5895 File Offset: 0x006C3A95
		public IMotorEnterSlideT AsIMotorEnterSlide()
		{
			return this.As<IMotorEnterSlideT>();
		}

		// Token: 0x06032080 RID: 204928 RVA: 0x006C589D File Offset: 0x006C3A9D
		public static ILeisureInteractType_UnionUnion FromIMotorEnterSlide(IMotorEnterSlideT _imotorenterslide)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorEnterSlide,
				Value = _imotorenterslide
			};
		}

		// Token: 0x06032081 RID: 204929 RVA: 0x006C58B3 File Offset: 0x006C3AB3
		public IQiuyuanLongPressQinggongT AsIQiuyuanLongPressQinggong()
		{
			return this.As<IQiuyuanLongPressQinggongT>();
		}

		// Token: 0x06032082 RID: 204930 RVA: 0x006C58BB File Offset: 0x006C3ABB
		public static ILeisureInteractType_UnionUnion FromIQiuyuanLongPressQinggong(IQiuyuanLongPressQinggongT _iqiuyuanlongpressqinggong)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanLongPressQinggong,
				Value = _iqiuyuanlongpressqinggong
			};
		}

		// Token: 0x06032083 RID: 204931 RVA: 0x006C58D1 File Offset: 0x006C3AD1
		public IQiuyuanQinggongEndT AsIQiuyuanQinggongEnd()
		{
			return this.As<IQiuyuanQinggongEndT>();
		}

		// Token: 0x06032084 RID: 204932 RVA: 0x006C58D9 File Offset: 0x006C3AD9
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongEnd(IQiuyuanQinggongEndT _iqiuyuanqinggongend)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongEnd,
				Value = _iqiuyuanqinggongend
			};
		}

		// Token: 0x06032085 RID: 204933 RVA: 0x006C58EF File Offset: 0x006C3AEF
		public IQiuyuanQinggongExploration1T AsIQiuyuanQinggongExploration1()
		{
			return this.As<IQiuyuanQinggongExploration1T>();
		}

		// Token: 0x06032086 RID: 204934 RVA: 0x006C58F7 File Offset: 0x006C3AF7
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration1(IQiuyuanQinggongExploration1T _iqiuyuanqinggongexploration1)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration1,
				Value = _iqiuyuanqinggongexploration1
			};
		}

		// Token: 0x06032087 RID: 204935 RVA: 0x006C590D File Offset: 0x006C3B0D
		public IQiuyuanQinggongExploration2T AsIQiuyuanQinggongExploration2()
		{
			return this.As<IQiuyuanQinggongExploration2T>();
		}

		// Token: 0x06032088 RID: 204936 RVA: 0x006C5915 File Offset: 0x006C3B15
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration2(IQiuyuanQinggongExploration2T _iqiuyuanqinggongexploration2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration2,
				Value = _iqiuyuanqinggongexploration2
			};
		}

		// Token: 0x06032089 RID: 204937 RVA: 0x006C592B File Offset: 0x006C3B2B
		public IQiuyuanQinggongExploration3T AsIQiuyuanQinggongExploration3()
		{
			return this.As<IQiuyuanQinggongExploration3T>();
		}

		// Token: 0x0603208A RID: 204938 RVA: 0x006C5933 File Offset: 0x006C3B33
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration3(IQiuyuanQinggongExploration3T _iqiuyuanqinggongexploration3)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration3,
				Value = _iqiuyuanqinggongexploration3
			};
		}

		// Token: 0x0603208B RID: 204939 RVA: 0x006C5949 File Offset: 0x006C3B49
		public IQiuyuanQinggongExploration4T AsIQiuyuanQinggongExploration4()
		{
			return this.As<IQiuyuanQinggongExploration4T>();
		}

		// Token: 0x0603208C RID: 204940 RVA: 0x006C5951 File Offset: 0x006C3B51
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration4(IQiuyuanQinggongExploration4T _iqiuyuanqinggongexploration4)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration4,
				Value = _iqiuyuanqinggongexploration4
			};
		}

		// Token: 0x0603208D RID: 204941 RVA: 0x006C5967 File Offset: 0x006C3B67
		public IQiuyuanQinggongStraightT AsIQiuyuanQinggongStraight()
		{
			return this.As<IQiuyuanQinggongStraightT>();
		}

		// Token: 0x0603208E RID: 204942 RVA: 0x006C596F File Offset: 0x006C3B6F
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongStraight(IQiuyuanQinggongStraightT _iqiuyuanqinggongstraight)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongStraight,
				Value = _iqiuyuanqinggongstraight
			};
		}

		// Token: 0x0603208F RID: 204943 RVA: 0x006C5985 File Offset: 0x006C3B85
		public IQiuyuanQinggongHoveringT AsIQiuyuanQinggongHovering()
		{
			return this.As<IQiuyuanQinggongHoveringT>();
		}

		// Token: 0x06032090 RID: 204944 RVA: 0x006C598D File Offset: 0x006C3B8D
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongHovering(IQiuyuanQinggongHoveringT _iqiuyuanqinggonghovering)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongHovering,
				Value = _iqiuyuanqinggonghovering
			};
		}

		// Token: 0x06032091 RID: 204945 RVA: 0x006C59A3 File Offset: 0x006C3BA3
		public ISunPalaceInteractT AsISunPalaceInteract()
		{
			return this.As<ISunPalaceInteractT>();
		}

		// Token: 0x06032092 RID: 204946 RVA: 0x006C59AB File Offset: 0x006C3BAB
		public static ILeisureInteractType_UnionUnion FromISunPalaceInteract(ISunPalaceInteractT _isunpalaceinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISunPalaceInteract,
				Value = _isunpalaceinteract
			};
		}

		// Token: 0x06032093 RID: 204947 RVA: 0x006C59C1 File Offset: 0x006C3BC1
		public ILandSlideInteractT AsILandSlideInteract()
		{
			return this.As<ILandSlideInteractT>();
		}

		// Token: 0x06032094 RID: 204948 RVA: 0x006C59C9 File Offset: 0x006C3BC9
		public static ILeisureInteractType_UnionUnion FromILandSlideInteract(ILandSlideInteractT _ilandslideinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILandSlideInteract,
				Value = _ilandslideinteract
			};
		}

		// Token: 0x06032095 RID: 204949 RVA: 0x006C59DF File Offset: 0x006C3BDF
		public ILandSlideEndInteractT AsILandSlideEndInteract()
		{
			return this.As<ILandSlideEndInteractT>();
		}

		// Token: 0x06032096 RID: 204950 RVA: 0x006C59E7 File Offset: 0x006C3BE7
		public static ILeisureInteractType_UnionUnion FromILandSlideEndInteract(ILandSlideEndInteractT _ilandslideendinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILandSlideEndInteract,
				Value = _ilandslideendinteract
			};
		}

		// Token: 0x06032097 RID: 204951 RVA: 0x006C59FD File Offset: 0x006C3BFD
		public IRideMotorcycleInteractT AsIRideMotorcycleInteract()
		{
			return this.As<IRideMotorcycleInteractT>();
		}

		// Token: 0x06032098 RID: 204952 RVA: 0x006C5A05 File Offset: 0x006C3C05
		public static ILeisureInteractType_UnionUnion FromIRideMotorcycleInteract(IRideMotorcycleInteractT _iridemotorcycleinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IRideMotorcycleInteract,
				Value = _iridemotorcycleinteract
			};
		}

		// Token: 0x06032099 RID: 204953 RVA: 0x006C5A1B File Offset: 0x006C3C1B
		public IGetOffMotorcycleInteractT AsIGetOffMotorcycleInteract()
		{
			return this.As<IGetOffMotorcycleInteractT>();
		}

		// Token: 0x0603209A RID: 204954 RVA: 0x006C5A23 File Offset: 0x006C3C23
		public static ILeisureInteractType_UnionUnion FromIGetOffMotorcycleInteract(IGetOffMotorcycleInteractT _igetoffmotorcycleinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGetOffMotorcycleInteract,
				Value = _igetoffmotorcycleinteract
			};
		}

		// Token: 0x0603209B RID: 204955 RVA: 0x006C5A39 File Offset: 0x006C3C39
		public IMoneHackingDoorInteractT AsIMoneHackingDoorInteract()
		{
			return this.As<IMoneHackingDoorInteractT>();
		}

		// Token: 0x0603209C RID: 204956 RVA: 0x006C5A41 File Offset: 0x006C3C41
		public static ILeisureInteractType_UnionUnion FromIMoneHackingDoorInteract(IMoneHackingDoorInteractT _imonehackingdoorinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMoneHackingDoorInteract,
				Value = _imonehackingdoorinteract
			};
		}

		// Token: 0x0603209D RID: 204957 RVA: 0x006C5A57 File Offset: 0x006C3C57
		public IMotorSoarInteractT AsIMotorSoarInteract()
		{
			return this.As<IMotorSoarInteractT>();
		}

		// Token: 0x0603209E RID: 204958 RVA: 0x006C5A5F File Offset: 0x006C3C5F
		public static ILeisureInteractType_UnionUnion FromIMotorSoarInteract(IMotorSoarInteractT _imotorsoarinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorSoarInteract,
				Value = _imotorsoarinteract
			};
		}

		// Token: 0x0603209F RID: 204959 RVA: 0x006C5A75 File Offset: 0x006C3C75
		public IParticipateGroupPatrolT AsIParticipateGroupPatrol()
		{
			return this.As<IParticipateGroupPatrolT>();
		}

		// Token: 0x060320A0 RID: 204960 RVA: 0x006C5A7D File Offset: 0x006C3C7D
		public static ILeisureInteractType_UnionUnion FromIParticipateGroupPatrol(IParticipateGroupPatrolT _iparticipategrouppatrol)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IParticipateGroupPatrol,
				Value = _iparticipategrouppatrol
			};
		}

		// Token: 0x060320A1 RID: 204961 RVA: 0x006C5A93 File Offset: 0x006C3C93
		public IFoxPickUpT AsIFoxPickUp()
		{
			return this.As<IFoxPickUpT>();
		}

		// Token: 0x060320A2 RID: 204962 RVA: 0x006C5A9B File Offset: 0x006C3C9B
		public static ILeisureInteractType_UnionUnion FromIFoxPickUp(IFoxPickUpT _ifoxpickup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPickUp,
				Value = _ifoxpickup
			};
		}

		// Token: 0x060320A3 RID: 204963 RVA: 0x006C5AB1 File Offset: 0x006C3CB1
		public IFoxPutDownT AsIFoxPutDown()
		{
			return this.As<IFoxPutDownT>();
		}

		// Token: 0x060320A4 RID: 204964 RVA: 0x006C5AB9 File Offset: 0x006C3CB9
		public static ILeisureInteractType_UnionUnion FromIFoxPutDown(IFoxPutDownT _ifoxputdown)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPutDown,
				Value = _ifoxputdown
			};
		}

		// Token: 0x060320A5 RID: 204965 RVA: 0x006C5ACF File Offset: 0x006C3CCF
		public IFoxPushBoxT AsIFoxPushBox()
		{
			return this.As<IFoxPushBoxT>();
		}

		// Token: 0x060320A6 RID: 204966 RVA: 0x006C5AD7 File Offset: 0x006C3CD7
		public static ILeisureInteractType_UnionUnion FromIFoxPushBox(IFoxPushBoxT _ifoxpushbox)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPushBox,
				Value = _ifoxpushbox
			};
		}

		// Token: 0x060320A7 RID: 204967 RVA: 0x006C5AED File Offset: 0x006C3CED
		public IFoxReversePushT AsIFoxReversePush()
		{
			return this.As<IFoxReversePushT>();
		}

		// Token: 0x060320A8 RID: 204968 RVA: 0x006C5AF5 File Offset: 0x006C3CF5
		public static ILeisureInteractType_UnionUnion FromIFoxReversePush(IFoxReversePushT _ifoxreversepush)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxReversePush,
				Value = _ifoxreversepush
			};
		}

		// Token: 0x060320A9 RID: 204969 RVA: 0x006C5B0B File Offset: 0x006C3D0B
		public IFoxAutoJumpT AsIFoxAutoJump()
		{
			return this.As<IFoxAutoJumpT>();
		}

		// Token: 0x060320AA RID: 204970 RVA: 0x006C5B13 File Offset: 0x006C3D13
		public static ILeisureInteractType_UnionUnion FromIFoxAutoJump(IFoxAutoJumpT _ifoxautojump)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxAutoJump,
				Value = _ifoxautojump
			};
		}

		// Token: 0x060320AB RID: 204971 RVA: 0x006C5B29 File Offset: 0x006C3D29
		public IMechStuntT AsIMechStunt()
		{
			return this.As<IMechStuntT>();
		}

		// Token: 0x060320AC RID: 204972 RVA: 0x006C5B31 File Offset: 0x006C3D31
		public static ILeisureInteractType_UnionUnion FromIMechStunt(IMechStuntT _imechstunt)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMechStunt,
				Value = _imechstunt
			};
		}

		// Token: 0x060320AD RID: 204973 RVA: 0x006C5B47 File Offset: 0x006C3D47
		public IMechEscortFlyT AsIMechEscortFly()
		{
			return this.As<IMechEscortFlyT>();
		}

		// Token: 0x060320AE RID: 204974 RVA: 0x006C5B4F File Offset: 0x006C3D4F
		public static ILeisureInteractType_UnionUnion FromIMechEscortFly(IMechEscortFlyT _imechescortfly)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMechEscortFly,
				Value = _imechescortfly
			};
		}

		// Token: 0x060320AF RID: 204975 RVA: 0x006C5B68 File Offset: 0x006C3D68
		public static int Pack(FlatBufferBuilder builder, ILeisureInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILeisureInteractType_Union.ILeisureInteractType:
				return ILeisureInteractType.Pack(builder, _o.AsILeisureInteractType()).Value;
			case ILeisureInteractType_Union.ICustomSkill:
				return ICustomSkill.Pack(builder, _o.AsICustomSkill()).Value;
			case ILeisureInteractType_Union.ISitDown:
				return ISitDown.Pack(builder, _o.AsISitDown()).Value;
			case ILeisureInteractType_Union.ISitOnGround:
				return ISitOnGround.Pack(builder, _o.AsISitOnGround()).Value;
			case ILeisureInteractType_Union.IBounce:
				return IBounce.Pack(builder, _o.AsIBounce()).Value;
			case ILeisureInteractType_Union.IMotorBounce:
				return IMotorBounce.Pack(builder, _o.AsIMotorBounce()).Value;
			case ILeisureInteractType_Union.IMotorCatapult:
				return IMotorCatapult.Pack(builder, _o.AsIMotorCatapult()).Value;
			case ILeisureInteractType_Union.ICatapult:
				return ICatapult.Pack(builder, _o.AsICatapult()).Value;
			case ILeisureInteractType_Union.ISuperCatapult:
				return ISuperCatapult.Pack(builder, _o.AsISuperCatapult()).Value;
			case ILeisureInteractType_Union.IManipulate:
				return IManipulate.Pack(builder, _o.AsIManipulate()).Value;
			case ILeisureInteractType_Union.IStandControl:
				return IStandControl.Pack(builder, _o.AsIStandControl()).Value;
			case ILeisureInteractType_Union.IStandControl2:
				return IStandControl2.Pack(builder, _o.AsIStandControl2()).Value;
			case ILeisureInteractType_Union.ISoar:
				return ISoar.Pack(builder, _o.AsISoar()).Value;
			case ILeisureInteractType_Union.ISoar2:
				return ISoar2.Pack(builder, _o.AsISoar2()).Value;
			case ILeisureInteractType_Union.IGlide:
				return IGlide.Pack(builder, _o.AsIGlide()).Value;
			case ILeisureInteractType_Union.IGetUp:
				return IGetUp.Pack(builder, _o.AsIGetUp()).Value;
			case ILeisureInteractType_Union.IHookLockInteract:
				return IHookLockInteract.Pack(builder, _o.AsIHookLockInteract()).Value;
			case ILeisureInteractType_Union.IKiteHookInteract:
				return IKiteHookInteract.Pack(builder, _o.AsIKiteHookInteract()).Value;
			case ILeisureInteractType_Union.IFailurePoseInteract:
				return IFailurePoseInteract.Pack(builder, _o.AsIFailurePoseInteract()).Value;
			case ILeisureInteractType_Union.IGameplayPose1Interact:
				return IGameplayPose1Interact.Pack(builder, _o.AsIGameplayPose1Interact()).Value;
			case ILeisureInteractType_Union.IGameplayPose2Interact:
				return IGameplayPose2Interact.Pack(builder, _o.AsIGameplayPose2Interact()).Value;
			case ILeisureInteractType_Union.IGameplayPose3Interact:
				return IGameplayPose3Interact.Pack(builder, _o.AsIGameplayPose3Interact()).Value;
			case ILeisureInteractType_Union.IFaithJump:
				return IFaithJump.Pack(builder, _o.AsIFaithJump()).Value;
			case ILeisureInteractType_Union.IWindProtagonistParkour1:
				return IWindProtagonistParkour1.Pack(builder, _o.AsIWindProtagonistParkour1()).Value;
			case ILeisureInteractType_Union.IWindProtagonistParkour2:
				return IWindProtagonistParkour2.Pack(builder, _o.AsIWindProtagonistParkour2()).Value;
			case ILeisureInteractType_Union.IWindProtagonistParkour3:
				return IWindProtagonistParkour3.Pack(builder, _o.AsIWindProtagonistParkour3()).Value;
			case ILeisureInteractType_Union.IWindProtagonistParkour4:
				return IWindProtagonistParkour4.Pack(builder, _o.AsIWindProtagonistParkour4()).Value;
			case ILeisureInteractType_Union.IWindProtagonistParkour5:
				return IWindProtagonistParkour5.Pack(builder, _o.AsIWindProtagonistParkour5()).Value;
			case ILeisureInteractType_Union.IPainCoveringHead:
				return IPainCoveringHead.Pack(builder, _o.AsIPainCoveringHead()).Value;
			case ILeisureInteractType_Union.ISwing:
				return ISwing.Pack(builder, _o.AsISwing()).Value;
			case ILeisureInteractType_Union.ISwingGetUp:
				return ISwingGetUp.Pack(builder, _o.AsISwingGetUp()).Value;
			case ILeisureInteractType_Union.IMotorEnterSlide:
				return IMotorEnterSlide.Pack(builder, _o.AsIMotorEnterSlide()).Value;
			case ILeisureInteractType_Union.IQiuyuanLongPressQinggong:
				return IQiuyuanLongPressQinggong.Pack(builder, _o.AsIQiuyuanLongPressQinggong()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongEnd:
				return IQiuyuanQinggongEnd.Pack(builder, _o.AsIQiuyuanQinggongEnd()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongExploration1:
				return IQiuyuanQinggongExploration1.Pack(builder, _o.AsIQiuyuanQinggongExploration1()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongExploration2:
				return IQiuyuanQinggongExploration2.Pack(builder, _o.AsIQiuyuanQinggongExploration2()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongExploration3:
				return IQiuyuanQinggongExploration3.Pack(builder, _o.AsIQiuyuanQinggongExploration3()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongExploration4:
				return IQiuyuanQinggongExploration4.Pack(builder, _o.AsIQiuyuanQinggongExploration4()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongStraight:
				return IQiuyuanQinggongStraight.Pack(builder, _o.AsIQiuyuanQinggongStraight()).Value;
			case ILeisureInteractType_Union.IQiuyuanQinggongHovering:
				return IQiuyuanQinggongHovering.Pack(builder, _o.AsIQiuyuanQinggongHovering()).Value;
			case ILeisureInteractType_Union.ISunPalaceInteract:
				return ISunPalaceInteract.Pack(builder, _o.AsISunPalaceInteract()).Value;
			case ILeisureInteractType_Union.ILandSlideInteract:
				return ILandSlideInteract.Pack(builder, _o.AsILandSlideInteract()).Value;
			case ILeisureInteractType_Union.ILandSlideEndInteract:
				return ILandSlideEndInteract.Pack(builder, _o.AsILandSlideEndInteract()).Value;
			case ILeisureInteractType_Union.IRideMotorcycleInteract:
				return IRideMotorcycleInteract.Pack(builder, _o.AsIRideMotorcycleInteract()).Value;
			case ILeisureInteractType_Union.IGetOffMotorcycleInteract:
				return IGetOffMotorcycleInteract.Pack(builder, _o.AsIGetOffMotorcycleInteract()).Value;
			case ILeisureInteractType_Union.IMoneHackingDoorInteract:
				return IMoneHackingDoorInteract.Pack(builder, _o.AsIMoneHackingDoorInteract()).Value;
			case ILeisureInteractType_Union.IMotorSoarInteract:
				return IMotorSoarInteract.Pack(builder, _o.AsIMotorSoarInteract()).Value;
			case ILeisureInteractType_Union.IParticipateGroupPatrol:
				return IParticipateGroupPatrol.Pack(builder, _o.AsIParticipateGroupPatrol()).Value;
			case ILeisureInteractType_Union.IFoxPickUp:
				return IFoxPickUp.Pack(builder, _o.AsIFoxPickUp()).Value;
			case ILeisureInteractType_Union.IFoxPutDown:
				return IFoxPutDown.Pack(builder, _o.AsIFoxPutDown()).Value;
			case ILeisureInteractType_Union.IFoxPushBox:
				return IFoxPushBox.Pack(builder, _o.AsIFoxPushBox()).Value;
			case ILeisureInteractType_Union.IFoxReversePush:
				return IFoxReversePush.Pack(builder, _o.AsIFoxReversePush()).Value;
			case ILeisureInteractType_Union.IFoxAutoJump:
				return IFoxAutoJump.Pack(builder, _o.AsIFoxAutoJump()).Value;
			case ILeisureInteractType_Union.IMechStunt:
				return IMechStunt.Pack(builder, _o.AsIMechStunt()).Value;
			case ILeisureInteractType_Union.IMechEscortFly:
				return IMechEscortFly.Pack(builder, _o.AsIMechEscortFly()).Value;
			default:
				return 0;
			}
		}
	}
}
