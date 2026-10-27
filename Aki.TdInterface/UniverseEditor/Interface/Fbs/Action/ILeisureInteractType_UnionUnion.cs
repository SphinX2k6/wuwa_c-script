using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E8 RID: 27112
	public class ILeisureInteractType_UnionUnion
	{
		// Token: 0x1700C925 RID: 51493
		// (get) Token: 0x0602F67B RID: 194171 RVA: 0x00675159 File Offset: 0x00673359
		// (set) Token: 0x0602F67C RID: 194172 RVA: 0x00675161 File Offset: 0x00673361
		public ILeisureInteractType_Union Type { get; set; }

		// Token: 0x1700C926 RID: 51494
		// (get) Token: 0x0602F67D RID: 194173 RVA: 0x0067516A File Offset: 0x0067336A
		// (set) Token: 0x0602F67E RID: 194174 RVA: 0x00675172 File Offset: 0x00673372
		public object Value { get; set; }

		// Token: 0x0602F67F RID: 194175 RVA: 0x0067517B File Offset: 0x0067337B
		public ILeisureInteractType_UnionUnion()
		{
			this.Type = ILeisureInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F680 RID: 194176 RVA: 0x00675191 File Offset: 0x00673391
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F681 RID: 194177 RVA: 0x006751A3 File Offset: 0x006733A3
		public ILeisureInteractTypeT AsILeisureInteractType()
		{
			return this.As<ILeisureInteractTypeT>();
		}

		// Token: 0x0602F682 RID: 194178 RVA: 0x006751AB File Offset: 0x006733AB
		public static ILeisureInteractType_UnionUnion FromILeisureInteractType(ILeisureInteractTypeT _ileisureinteracttype)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILeisureInteractType,
				Value = _ileisureinteracttype
			};
		}

		// Token: 0x0602F683 RID: 194179 RVA: 0x006751C0 File Offset: 0x006733C0
		public ICustomSkillT AsICustomSkill()
		{
			return this.As<ICustomSkillT>();
		}

		// Token: 0x0602F684 RID: 194180 RVA: 0x006751C8 File Offset: 0x006733C8
		public static ILeisureInteractType_UnionUnion FromICustomSkill(ICustomSkillT _icustomskill)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ICustomSkill,
				Value = _icustomskill
			};
		}

		// Token: 0x0602F685 RID: 194181 RVA: 0x006751DD File Offset: 0x006733DD
		public ISitDownT AsISitDown()
		{
			return this.As<ISitDownT>();
		}

		// Token: 0x0602F686 RID: 194182 RVA: 0x006751E5 File Offset: 0x006733E5
		public static ILeisureInteractType_UnionUnion FromISitDown(ISitDownT _isitdown)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISitDown,
				Value = _isitdown
			};
		}

		// Token: 0x0602F687 RID: 194183 RVA: 0x006751FA File Offset: 0x006733FA
		public ISitOnGroundT AsISitOnGround()
		{
			return this.As<ISitOnGroundT>();
		}

		// Token: 0x0602F688 RID: 194184 RVA: 0x00675202 File Offset: 0x00673402
		public static ILeisureInteractType_UnionUnion FromISitOnGround(ISitOnGroundT _isitonground)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISitOnGround,
				Value = _isitonground
			};
		}

		// Token: 0x0602F689 RID: 194185 RVA: 0x00675217 File Offset: 0x00673417
		public IBounceT AsIBounce()
		{
			return this.As<IBounceT>();
		}

		// Token: 0x0602F68A RID: 194186 RVA: 0x0067521F File Offset: 0x0067341F
		public static ILeisureInteractType_UnionUnion FromIBounce(IBounceT _ibounce)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IBounce,
				Value = _ibounce
			};
		}

		// Token: 0x0602F68B RID: 194187 RVA: 0x00675234 File Offset: 0x00673434
		public IMotorBounceT AsIMotorBounce()
		{
			return this.As<IMotorBounceT>();
		}

		// Token: 0x0602F68C RID: 194188 RVA: 0x0067523C File Offset: 0x0067343C
		public static ILeisureInteractType_UnionUnion FromIMotorBounce(IMotorBounceT _imotorbounce)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorBounce,
				Value = _imotorbounce
			};
		}

		// Token: 0x0602F68D RID: 194189 RVA: 0x00675251 File Offset: 0x00673451
		public IMotorCatapultT AsIMotorCatapult()
		{
			return this.As<IMotorCatapultT>();
		}

		// Token: 0x0602F68E RID: 194190 RVA: 0x00675259 File Offset: 0x00673459
		public static ILeisureInteractType_UnionUnion FromIMotorCatapult(IMotorCatapultT _imotorcatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorCatapult,
				Value = _imotorcatapult
			};
		}

		// Token: 0x0602F68F RID: 194191 RVA: 0x0067526E File Offset: 0x0067346E
		public ICatapultT AsICatapult()
		{
			return this.As<ICatapultT>();
		}

		// Token: 0x0602F690 RID: 194192 RVA: 0x00675276 File Offset: 0x00673476
		public static ILeisureInteractType_UnionUnion FromICatapult(ICatapultT _icatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ICatapult,
				Value = _icatapult
			};
		}

		// Token: 0x0602F691 RID: 194193 RVA: 0x0067528B File Offset: 0x0067348B
		public ISuperCatapultT AsISuperCatapult()
		{
			return this.As<ISuperCatapultT>();
		}

		// Token: 0x0602F692 RID: 194194 RVA: 0x00675293 File Offset: 0x00673493
		public static ILeisureInteractType_UnionUnion FromISuperCatapult(ISuperCatapultT _isupercatapult)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISuperCatapult,
				Value = _isupercatapult
			};
		}

		// Token: 0x0602F693 RID: 194195 RVA: 0x006752A9 File Offset: 0x006734A9
		public IManipulateT AsIManipulate()
		{
			return this.As<IManipulateT>();
		}

		// Token: 0x0602F694 RID: 194196 RVA: 0x006752B1 File Offset: 0x006734B1
		public static ILeisureInteractType_UnionUnion FromIManipulate(IManipulateT _imanipulate)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IManipulate,
				Value = _imanipulate
			};
		}

		// Token: 0x0602F695 RID: 194197 RVA: 0x006752C7 File Offset: 0x006734C7
		public IStandControlT AsIStandControl()
		{
			return this.As<IStandControlT>();
		}

		// Token: 0x0602F696 RID: 194198 RVA: 0x006752CF File Offset: 0x006734CF
		public static ILeisureInteractType_UnionUnion FromIStandControl(IStandControlT _istandcontrol)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IStandControl,
				Value = _istandcontrol
			};
		}

		// Token: 0x0602F697 RID: 194199 RVA: 0x006752E5 File Offset: 0x006734E5
		public IStandControl2T AsIStandControl2()
		{
			return this.As<IStandControl2T>();
		}

		// Token: 0x0602F698 RID: 194200 RVA: 0x006752ED File Offset: 0x006734ED
		public static ILeisureInteractType_UnionUnion FromIStandControl2(IStandControl2T _istandcontrol2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IStandControl2,
				Value = _istandcontrol2
			};
		}

		// Token: 0x0602F699 RID: 194201 RVA: 0x00675303 File Offset: 0x00673503
		public ISoarT AsISoar()
		{
			return this.As<ISoarT>();
		}

		// Token: 0x0602F69A RID: 194202 RVA: 0x0067530B File Offset: 0x0067350B
		public static ILeisureInteractType_UnionUnion FromISoar(ISoarT _isoar)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISoar,
				Value = _isoar
			};
		}

		// Token: 0x0602F69B RID: 194203 RVA: 0x00675321 File Offset: 0x00673521
		public ISoar2T AsISoar2()
		{
			return this.As<ISoar2T>();
		}

		// Token: 0x0602F69C RID: 194204 RVA: 0x00675329 File Offset: 0x00673529
		public static ILeisureInteractType_UnionUnion FromISoar2(ISoar2T _isoar2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISoar2,
				Value = _isoar2
			};
		}

		// Token: 0x0602F69D RID: 194205 RVA: 0x0067533F File Offset: 0x0067353F
		public IGlideT AsIGlide()
		{
			return this.As<IGlideT>();
		}

		// Token: 0x0602F69E RID: 194206 RVA: 0x00675347 File Offset: 0x00673547
		public static ILeisureInteractType_UnionUnion FromIGlide(IGlideT _iglide)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGlide,
				Value = _iglide
			};
		}

		// Token: 0x0602F69F RID: 194207 RVA: 0x0067535D File Offset: 0x0067355D
		public IGetUpT AsIGetUp()
		{
			return this.As<IGetUpT>();
		}

		// Token: 0x0602F6A0 RID: 194208 RVA: 0x00675365 File Offset: 0x00673565
		public static ILeisureInteractType_UnionUnion FromIGetUp(IGetUpT _igetup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGetUp,
				Value = _igetup
			};
		}

		// Token: 0x0602F6A1 RID: 194209 RVA: 0x0067537B File Offset: 0x0067357B
		public IHookLockInteractT AsIHookLockInteract()
		{
			return this.As<IHookLockInteractT>();
		}

		// Token: 0x0602F6A2 RID: 194210 RVA: 0x00675383 File Offset: 0x00673583
		public static ILeisureInteractType_UnionUnion FromIHookLockInteract(IHookLockInteractT _ihooklockinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IHookLockInteract,
				Value = _ihooklockinteract
			};
		}

		// Token: 0x0602F6A3 RID: 194211 RVA: 0x00675399 File Offset: 0x00673599
		public IKiteHookInteractT AsIKiteHookInteract()
		{
			return this.As<IKiteHookInteractT>();
		}

		// Token: 0x0602F6A4 RID: 194212 RVA: 0x006753A1 File Offset: 0x006735A1
		public static ILeisureInteractType_UnionUnion FromIKiteHookInteract(IKiteHookInteractT _ikitehookinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IKiteHookInteract,
				Value = _ikitehookinteract
			};
		}

		// Token: 0x0602F6A5 RID: 194213 RVA: 0x006753B7 File Offset: 0x006735B7
		public IFailurePoseInteractT AsIFailurePoseInteract()
		{
			return this.As<IFailurePoseInteractT>();
		}

		// Token: 0x0602F6A6 RID: 194214 RVA: 0x006753BF File Offset: 0x006735BF
		public static ILeisureInteractType_UnionUnion FromIFailurePoseInteract(IFailurePoseInteractT _ifailureposeinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFailurePoseInteract,
				Value = _ifailureposeinteract
			};
		}

		// Token: 0x0602F6A7 RID: 194215 RVA: 0x006753D5 File Offset: 0x006735D5
		public IGameplayPose1InteractT AsIGameplayPose1Interact()
		{
			return this.As<IGameplayPose1InteractT>();
		}

		// Token: 0x0602F6A8 RID: 194216 RVA: 0x006753DD File Offset: 0x006735DD
		public static ILeisureInteractType_UnionUnion FromIGameplayPose1Interact(IGameplayPose1InteractT _igameplaypose1interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose1Interact,
				Value = _igameplaypose1interact
			};
		}

		// Token: 0x0602F6A9 RID: 194217 RVA: 0x006753F3 File Offset: 0x006735F3
		public IGameplayPose2InteractT AsIGameplayPose2Interact()
		{
			return this.As<IGameplayPose2InteractT>();
		}

		// Token: 0x0602F6AA RID: 194218 RVA: 0x006753FB File Offset: 0x006735FB
		public static ILeisureInteractType_UnionUnion FromIGameplayPose2Interact(IGameplayPose2InteractT _igameplaypose2interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose2Interact,
				Value = _igameplaypose2interact
			};
		}

		// Token: 0x0602F6AB RID: 194219 RVA: 0x00675411 File Offset: 0x00673611
		public IGameplayPose3InteractT AsIGameplayPose3Interact()
		{
			return this.As<IGameplayPose3InteractT>();
		}

		// Token: 0x0602F6AC RID: 194220 RVA: 0x00675419 File Offset: 0x00673619
		public static ILeisureInteractType_UnionUnion FromIGameplayPose3Interact(IGameplayPose3InteractT _igameplaypose3interact)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGameplayPose3Interact,
				Value = _igameplaypose3interact
			};
		}

		// Token: 0x0602F6AD RID: 194221 RVA: 0x0067542F File Offset: 0x0067362F
		public IFaithJumpT AsIFaithJump()
		{
			return this.As<IFaithJumpT>();
		}

		// Token: 0x0602F6AE RID: 194222 RVA: 0x00675437 File Offset: 0x00673637
		public static ILeisureInteractType_UnionUnion FromIFaithJump(IFaithJumpT _ifaithjump)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFaithJump,
				Value = _ifaithjump
			};
		}

		// Token: 0x0602F6AF RID: 194223 RVA: 0x0067544D File Offset: 0x0067364D
		public IWindProtagonistParkour1T AsIWindProtagonistParkour1()
		{
			return this.As<IWindProtagonistParkour1T>();
		}

		// Token: 0x0602F6B0 RID: 194224 RVA: 0x00675455 File Offset: 0x00673655
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour1(IWindProtagonistParkour1T _iwindprotagonistparkour1)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour1,
				Value = _iwindprotagonistparkour1
			};
		}

		// Token: 0x0602F6B1 RID: 194225 RVA: 0x0067546B File Offset: 0x0067366B
		public IWindProtagonistParkour2T AsIWindProtagonistParkour2()
		{
			return this.As<IWindProtagonistParkour2T>();
		}

		// Token: 0x0602F6B2 RID: 194226 RVA: 0x00675473 File Offset: 0x00673673
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour2(IWindProtagonistParkour2T _iwindprotagonistparkour2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour2,
				Value = _iwindprotagonistparkour2
			};
		}

		// Token: 0x0602F6B3 RID: 194227 RVA: 0x00675489 File Offset: 0x00673689
		public IWindProtagonistParkour3T AsIWindProtagonistParkour3()
		{
			return this.As<IWindProtagonistParkour3T>();
		}

		// Token: 0x0602F6B4 RID: 194228 RVA: 0x00675491 File Offset: 0x00673691
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour3(IWindProtagonistParkour3T _iwindprotagonistparkour3)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour3,
				Value = _iwindprotagonistparkour3
			};
		}

		// Token: 0x0602F6B5 RID: 194229 RVA: 0x006754A7 File Offset: 0x006736A7
		public IWindProtagonistParkour4T AsIWindProtagonistParkour4()
		{
			return this.As<IWindProtagonistParkour4T>();
		}

		// Token: 0x0602F6B6 RID: 194230 RVA: 0x006754AF File Offset: 0x006736AF
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour4(IWindProtagonistParkour4T _iwindprotagonistparkour4)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour4,
				Value = _iwindprotagonistparkour4
			};
		}

		// Token: 0x0602F6B7 RID: 194231 RVA: 0x006754C5 File Offset: 0x006736C5
		public IWindProtagonistParkour5T AsIWindProtagonistParkour5()
		{
			return this.As<IWindProtagonistParkour5T>();
		}

		// Token: 0x0602F6B8 RID: 194232 RVA: 0x006754CD File Offset: 0x006736CD
		public static ILeisureInteractType_UnionUnion FromIWindProtagonistParkour5(IWindProtagonistParkour5T _iwindprotagonistparkour5)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IWindProtagonistParkour5,
				Value = _iwindprotagonistparkour5
			};
		}

		// Token: 0x0602F6B9 RID: 194233 RVA: 0x006754E3 File Offset: 0x006736E3
		public IPainCoveringHeadT AsIPainCoveringHead()
		{
			return this.As<IPainCoveringHeadT>();
		}

		// Token: 0x0602F6BA RID: 194234 RVA: 0x006754EB File Offset: 0x006736EB
		public static ILeisureInteractType_UnionUnion FromIPainCoveringHead(IPainCoveringHeadT _ipaincoveringhead)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IPainCoveringHead,
				Value = _ipaincoveringhead
			};
		}

		// Token: 0x0602F6BB RID: 194235 RVA: 0x00675501 File Offset: 0x00673701
		public ISwingT AsISwing()
		{
			return this.As<ISwingT>();
		}

		// Token: 0x0602F6BC RID: 194236 RVA: 0x00675509 File Offset: 0x00673709
		public static ILeisureInteractType_UnionUnion FromISwing(ISwingT _iswing)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISwing,
				Value = _iswing
			};
		}

		// Token: 0x0602F6BD RID: 194237 RVA: 0x0067551F File Offset: 0x0067371F
		public ISwingGetUpT AsISwingGetUp()
		{
			return this.As<ISwingGetUpT>();
		}

		// Token: 0x0602F6BE RID: 194238 RVA: 0x00675527 File Offset: 0x00673727
		public static ILeisureInteractType_UnionUnion FromISwingGetUp(ISwingGetUpT _iswinggetup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISwingGetUp,
				Value = _iswinggetup
			};
		}

		// Token: 0x0602F6BF RID: 194239 RVA: 0x0067553D File Offset: 0x0067373D
		public IMotorEnterSlideT AsIMotorEnterSlide()
		{
			return this.As<IMotorEnterSlideT>();
		}

		// Token: 0x0602F6C0 RID: 194240 RVA: 0x00675545 File Offset: 0x00673745
		public static ILeisureInteractType_UnionUnion FromIMotorEnterSlide(IMotorEnterSlideT _imotorenterslide)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorEnterSlide,
				Value = _imotorenterslide
			};
		}

		// Token: 0x0602F6C1 RID: 194241 RVA: 0x0067555B File Offset: 0x0067375B
		public IQiuyuanLongPressQinggongT AsIQiuyuanLongPressQinggong()
		{
			return this.As<IQiuyuanLongPressQinggongT>();
		}

		// Token: 0x0602F6C2 RID: 194242 RVA: 0x00675563 File Offset: 0x00673763
		public static ILeisureInteractType_UnionUnion FromIQiuyuanLongPressQinggong(IQiuyuanLongPressQinggongT _iqiuyuanlongpressqinggong)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanLongPressQinggong,
				Value = _iqiuyuanlongpressqinggong
			};
		}

		// Token: 0x0602F6C3 RID: 194243 RVA: 0x00675579 File Offset: 0x00673779
		public IQiuyuanQinggongEndT AsIQiuyuanQinggongEnd()
		{
			return this.As<IQiuyuanQinggongEndT>();
		}

		// Token: 0x0602F6C4 RID: 194244 RVA: 0x00675581 File Offset: 0x00673781
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongEnd(IQiuyuanQinggongEndT _iqiuyuanqinggongend)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongEnd,
				Value = _iqiuyuanqinggongend
			};
		}

		// Token: 0x0602F6C5 RID: 194245 RVA: 0x00675597 File Offset: 0x00673797
		public IQiuyuanQinggongExploration1T AsIQiuyuanQinggongExploration1()
		{
			return this.As<IQiuyuanQinggongExploration1T>();
		}

		// Token: 0x0602F6C6 RID: 194246 RVA: 0x0067559F File Offset: 0x0067379F
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration1(IQiuyuanQinggongExploration1T _iqiuyuanqinggongexploration1)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration1,
				Value = _iqiuyuanqinggongexploration1
			};
		}

		// Token: 0x0602F6C7 RID: 194247 RVA: 0x006755B5 File Offset: 0x006737B5
		public IQiuyuanQinggongExploration2T AsIQiuyuanQinggongExploration2()
		{
			return this.As<IQiuyuanQinggongExploration2T>();
		}

		// Token: 0x0602F6C8 RID: 194248 RVA: 0x006755BD File Offset: 0x006737BD
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration2(IQiuyuanQinggongExploration2T _iqiuyuanqinggongexploration2)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration2,
				Value = _iqiuyuanqinggongexploration2
			};
		}

		// Token: 0x0602F6C9 RID: 194249 RVA: 0x006755D3 File Offset: 0x006737D3
		public IQiuyuanQinggongExploration3T AsIQiuyuanQinggongExploration3()
		{
			return this.As<IQiuyuanQinggongExploration3T>();
		}

		// Token: 0x0602F6CA RID: 194250 RVA: 0x006755DB File Offset: 0x006737DB
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration3(IQiuyuanQinggongExploration3T _iqiuyuanqinggongexploration3)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration3,
				Value = _iqiuyuanqinggongexploration3
			};
		}

		// Token: 0x0602F6CB RID: 194251 RVA: 0x006755F1 File Offset: 0x006737F1
		public IQiuyuanQinggongExploration4T AsIQiuyuanQinggongExploration4()
		{
			return this.As<IQiuyuanQinggongExploration4T>();
		}

		// Token: 0x0602F6CC RID: 194252 RVA: 0x006755F9 File Offset: 0x006737F9
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongExploration4(IQiuyuanQinggongExploration4T _iqiuyuanqinggongexploration4)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongExploration4,
				Value = _iqiuyuanqinggongexploration4
			};
		}

		// Token: 0x0602F6CD RID: 194253 RVA: 0x0067560F File Offset: 0x0067380F
		public IQiuyuanQinggongStraightT AsIQiuyuanQinggongStraight()
		{
			return this.As<IQiuyuanQinggongStraightT>();
		}

		// Token: 0x0602F6CE RID: 194254 RVA: 0x00675617 File Offset: 0x00673817
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongStraight(IQiuyuanQinggongStraightT _iqiuyuanqinggongstraight)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongStraight,
				Value = _iqiuyuanqinggongstraight
			};
		}

		// Token: 0x0602F6CF RID: 194255 RVA: 0x0067562D File Offset: 0x0067382D
		public IQiuyuanQinggongHoveringT AsIQiuyuanQinggongHovering()
		{
			return this.As<IQiuyuanQinggongHoveringT>();
		}

		// Token: 0x0602F6D0 RID: 194256 RVA: 0x00675635 File Offset: 0x00673835
		public static ILeisureInteractType_UnionUnion FromIQiuyuanQinggongHovering(IQiuyuanQinggongHoveringT _iqiuyuanqinggonghovering)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IQiuyuanQinggongHovering,
				Value = _iqiuyuanqinggonghovering
			};
		}

		// Token: 0x0602F6D1 RID: 194257 RVA: 0x0067564B File Offset: 0x0067384B
		public ISunPalaceInteractT AsISunPalaceInteract()
		{
			return this.As<ISunPalaceInteractT>();
		}

		// Token: 0x0602F6D2 RID: 194258 RVA: 0x00675653 File Offset: 0x00673853
		public static ILeisureInteractType_UnionUnion FromISunPalaceInteract(ISunPalaceInteractT _isunpalaceinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ISunPalaceInteract,
				Value = _isunpalaceinteract
			};
		}

		// Token: 0x0602F6D3 RID: 194259 RVA: 0x00675669 File Offset: 0x00673869
		public ILandSlideInteractT AsILandSlideInteract()
		{
			return this.As<ILandSlideInteractT>();
		}

		// Token: 0x0602F6D4 RID: 194260 RVA: 0x00675671 File Offset: 0x00673871
		public static ILeisureInteractType_UnionUnion FromILandSlideInteract(ILandSlideInteractT _ilandslideinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILandSlideInteract,
				Value = _ilandslideinteract
			};
		}

		// Token: 0x0602F6D5 RID: 194261 RVA: 0x00675687 File Offset: 0x00673887
		public ILandSlideEndInteractT AsILandSlideEndInteract()
		{
			return this.As<ILandSlideEndInteractT>();
		}

		// Token: 0x0602F6D6 RID: 194262 RVA: 0x0067568F File Offset: 0x0067388F
		public static ILeisureInteractType_UnionUnion FromILandSlideEndInteract(ILandSlideEndInteractT _ilandslideendinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.ILandSlideEndInteract,
				Value = _ilandslideendinteract
			};
		}

		// Token: 0x0602F6D7 RID: 194263 RVA: 0x006756A5 File Offset: 0x006738A5
		public IRideMotorcycleInteractT AsIRideMotorcycleInteract()
		{
			return this.As<IRideMotorcycleInteractT>();
		}

		// Token: 0x0602F6D8 RID: 194264 RVA: 0x006756AD File Offset: 0x006738AD
		public static ILeisureInteractType_UnionUnion FromIRideMotorcycleInteract(IRideMotorcycleInteractT _iridemotorcycleinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IRideMotorcycleInteract,
				Value = _iridemotorcycleinteract
			};
		}

		// Token: 0x0602F6D9 RID: 194265 RVA: 0x006756C3 File Offset: 0x006738C3
		public IGetOffMotorcycleInteractT AsIGetOffMotorcycleInteract()
		{
			return this.As<IGetOffMotorcycleInteractT>();
		}

		// Token: 0x0602F6DA RID: 194266 RVA: 0x006756CB File Offset: 0x006738CB
		public static ILeisureInteractType_UnionUnion FromIGetOffMotorcycleInteract(IGetOffMotorcycleInteractT _igetoffmotorcycleinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IGetOffMotorcycleInteract,
				Value = _igetoffmotorcycleinteract
			};
		}

		// Token: 0x0602F6DB RID: 194267 RVA: 0x006756E1 File Offset: 0x006738E1
		public IMoneHackingDoorInteractT AsIMoneHackingDoorInteract()
		{
			return this.As<IMoneHackingDoorInteractT>();
		}

		// Token: 0x0602F6DC RID: 194268 RVA: 0x006756E9 File Offset: 0x006738E9
		public static ILeisureInteractType_UnionUnion FromIMoneHackingDoorInteract(IMoneHackingDoorInteractT _imonehackingdoorinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMoneHackingDoorInteract,
				Value = _imonehackingdoorinteract
			};
		}

		// Token: 0x0602F6DD RID: 194269 RVA: 0x006756FF File Offset: 0x006738FF
		public IMotorSoarInteractT AsIMotorSoarInteract()
		{
			return this.As<IMotorSoarInteractT>();
		}

		// Token: 0x0602F6DE RID: 194270 RVA: 0x00675707 File Offset: 0x00673907
		public static ILeisureInteractType_UnionUnion FromIMotorSoarInteract(IMotorSoarInteractT _imotorsoarinteract)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMotorSoarInteract,
				Value = _imotorsoarinteract
			};
		}

		// Token: 0x0602F6DF RID: 194271 RVA: 0x0067571D File Offset: 0x0067391D
		public IParticipateGroupPatrolT AsIParticipateGroupPatrol()
		{
			return this.As<IParticipateGroupPatrolT>();
		}

		// Token: 0x0602F6E0 RID: 194272 RVA: 0x00675725 File Offset: 0x00673925
		public static ILeisureInteractType_UnionUnion FromIParticipateGroupPatrol(IParticipateGroupPatrolT _iparticipategrouppatrol)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IParticipateGroupPatrol,
				Value = _iparticipategrouppatrol
			};
		}

		// Token: 0x0602F6E1 RID: 194273 RVA: 0x0067573B File Offset: 0x0067393B
		public IFoxPickUpT AsIFoxPickUp()
		{
			return this.As<IFoxPickUpT>();
		}

		// Token: 0x0602F6E2 RID: 194274 RVA: 0x00675743 File Offset: 0x00673943
		public static ILeisureInteractType_UnionUnion FromIFoxPickUp(IFoxPickUpT _ifoxpickup)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPickUp,
				Value = _ifoxpickup
			};
		}

		// Token: 0x0602F6E3 RID: 194275 RVA: 0x00675759 File Offset: 0x00673959
		public IFoxPutDownT AsIFoxPutDown()
		{
			return this.As<IFoxPutDownT>();
		}

		// Token: 0x0602F6E4 RID: 194276 RVA: 0x00675761 File Offset: 0x00673961
		public static ILeisureInteractType_UnionUnion FromIFoxPutDown(IFoxPutDownT _ifoxputdown)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPutDown,
				Value = _ifoxputdown
			};
		}

		// Token: 0x0602F6E5 RID: 194277 RVA: 0x00675777 File Offset: 0x00673977
		public IFoxPushBoxT AsIFoxPushBox()
		{
			return this.As<IFoxPushBoxT>();
		}

		// Token: 0x0602F6E6 RID: 194278 RVA: 0x0067577F File Offset: 0x0067397F
		public static ILeisureInteractType_UnionUnion FromIFoxPushBox(IFoxPushBoxT _ifoxpushbox)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxPushBox,
				Value = _ifoxpushbox
			};
		}

		// Token: 0x0602F6E7 RID: 194279 RVA: 0x00675795 File Offset: 0x00673995
		public IFoxReversePushT AsIFoxReversePush()
		{
			return this.As<IFoxReversePushT>();
		}

		// Token: 0x0602F6E8 RID: 194280 RVA: 0x0067579D File Offset: 0x0067399D
		public static ILeisureInteractType_UnionUnion FromIFoxReversePush(IFoxReversePushT _ifoxreversepush)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxReversePush,
				Value = _ifoxreversepush
			};
		}

		// Token: 0x0602F6E9 RID: 194281 RVA: 0x006757B3 File Offset: 0x006739B3
		public IFoxAutoJumpT AsIFoxAutoJump()
		{
			return this.As<IFoxAutoJumpT>();
		}

		// Token: 0x0602F6EA RID: 194282 RVA: 0x006757BB File Offset: 0x006739BB
		public static ILeisureInteractType_UnionUnion FromIFoxAutoJump(IFoxAutoJumpT _ifoxautojump)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IFoxAutoJump,
				Value = _ifoxautojump
			};
		}

		// Token: 0x0602F6EB RID: 194283 RVA: 0x006757D1 File Offset: 0x006739D1
		public IMechStuntT AsIMechStunt()
		{
			return this.As<IMechStuntT>();
		}

		// Token: 0x0602F6EC RID: 194284 RVA: 0x006757D9 File Offset: 0x006739D9
		public static ILeisureInteractType_UnionUnion FromIMechStunt(IMechStuntT _imechstunt)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMechStunt,
				Value = _imechstunt
			};
		}

		// Token: 0x0602F6ED RID: 194285 RVA: 0x006757EF File Offset: 0x006739EF
		public IMechEscortFlyT AsIMechEscortFly()
		{
			return this.As<IMechEscortFlyT>();
		}

		// Token: 0x0602F6EE RID: 194286 RVA: 0x006757F7 File Offset: 0x006739F7
		public static ILeisureInteractType_UnionUnion FromIMechEscortFly(IMechEscortFlyT _imechescortfly)
		{
			return new ILeisureInteractType_UnionUnion
			{
				Type = ILeisureInteractType_Union.IMechEscortFly,
				Value = _imechescortfly
			};
		}

		// Token: 0x0602F6EF RID: 194287 RVA: 0x00675810 File Offset: 0x00673A10
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
