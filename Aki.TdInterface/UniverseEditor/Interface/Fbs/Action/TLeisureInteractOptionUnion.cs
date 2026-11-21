using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F16 RID: 32534
	public class TLeisureInteractOptionUnion
	{
		// Token: 0x1700F287 RID: 62087
		// (get) Token: 0x0603AABB RID: 240315 RVA: 0x007E411C File Offset: 0x007E231C
		// (set) Token: 0x0603AABC RID: 240316 RVA: 0x007E4124 File Offset: 0x007E2324
		public TLeisureInteractOption Type { get; set; }

		// Token: 0x1700F288 RID: 62088
		// (get) Token: 0x0603AABD RID: 240317 RVA: 0x007E412D File Offset: 0x007E232D
		// (set) Token: 0x0603AABE RID: 240318 RVA: 0x007E4135 File Offset: 0x007E2335
		public object Value { get; set; }

		// Token: 0x0603AABF RID: 240319 RVA: 0x007E413E File Offset: 0x007E233E
		public TLeisureInteractOptionUnion()
		{
			this.Type = TLeisureInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AAC0 RID: 240320 RVA: 0x007E4154 File Offset: 0x007E2354
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AAC1 RID: 240321 RVA: 0x007E4166 File Offset: 0x007E2366
		public IBounceT AsIBounce()
		{
			return this.As<IBounceT>();
		}

		// Token: 0x0603AAC2 RID: 240322 RVA: 0x007E416E File Offset: 0x007E236E
		public static TLeisureInteractOptionUnion FromIBounce(IBounceT _ibounce)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IBounce,
				Value = _ibounce
			};
		}

		// Token: 0x0603AAC3 RID: 240323 RVA: 0x007E4183 File Offset: 0x007E2383
		public ICatapultT AsICatapult()
		{
			return this.As<ICatapultT>();
		}

		// Token: 0x0603AAC4 RID: 240324 RVA: 0x007E418B File Offset: 0x007E238B
		public static TLeisureInteractOptionUnion FromICatapult(ICatapultT _icatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ICatapult,
				Value = _icatapult
			};
		}

		// Token: 0x0603AAC5 RID: 240325 RVA: 0x007E41A0 File Offset: 0x007E23A0
		public ICustomSkillT AsICustomSkill()
		{
			return this.As<ICustomSkillT>();
		}

		// Token: 0x0603AAC6 RID: 240326 RVA: 0x007E41A8 File Offset: 0x007E23A8
		public static TLeisureInteractOptionUnion FromICustomSkill(ICustomSkillT _icustomskill)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ICustomSkill,
				Value = _icustomskill
			};
		}

		// Token: 0x0603AAC7 RID: 240327 RVA: 0x007E41BD File Offset: 0x007E23BD
		public IFailurePoseInteractT AsIFailurePoseInteract()
		{
			return this.As<IFailurePoseInteractT>();
		}

		// Token: 0x0603AAC8 RID: 240328 RVA: 0x007E41C5 File Offset: 0x007E23C5
		public static TLeisureInteractOptionUnion FromIFailurePoseInteract(IFailurePoseInteractT _ifailureposeinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFailurePoseInteract,
				Value = _ifailureposeinteract
			};
		}

		// Token: 0x0603AAC9 RID: 240329 RVA: 0x007E41DA File Offset: 0x007E23DA
		public IFaithJumpT AsIFaithJump()
		{
			return this.As<IFaithJumpT>();
		}

		// Token: 0x0603AACA RID: 240330 RVA: 0x007E41E2 File Offset: 0x007E23E2
		public static TLeisureInteractOptionUnion FromIFaithJump(IFaithJumpT _ifaithjump)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFaithJump,
				Value = _ifaithjump
			};
		}

		// Token: 0x0603AACB RID: 240331 RVA: 0x007E41F7 File Offset: 0x007E23F7
		public IFoxAutoJumpT AsIFoxAutoJump()
		{
			return this.As<IFoxAutoJumpT>();
		}

		// Token: 0x0603AACC RID: 240332 RVA: 0x007E41FF File Offset: 0x007E23FF
		public static TLeisureInteractOptionUnion FromIFoxAutoJump(IFoxAutoJumpT _ifoxautojump)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxAutoJump,
				Value = _ifoxautojump
			};
		}

		// Token: 0x0603AACD RID: 240333 RVA: 0x007E4214 File Offset: 0x007E2414
		public IFoxPickUpT AsIFoxPickUp()
		{
			return this.As<IFoxPickUpT>();
		}

		// Token: 0x0603AACE RID: 240334 RVA: 0x007E421C File Offset: 0x007E241C
		public static TLeisureInteractOptionUnion FromIFoxPickUp(IFoxPickUpT _ifoxpickup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPickUp,
				Value = _ifoxpickup
			};
		}

		// Token: 0x0603AACF RID: 240335 RVA: 0x007E4231 File Offset: 0x007E2431
		public IFoxPushBoxT AsIFoxPushBox()
		{
			return this.As<IFoxPushBoxT>();
		}

		// Token: 0x0603AAD0 RID: 240336 RVA: 0x007E4239 File Offset: 0x007E2439
		public static TLeisureInteractOptionUnion FromIFoxPushBox(IFoxPushBoxT _ifoxpushbox)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPushBox,
				Value = _ifoxpushbox
			};
		}

		// Token: 0x0603AAD1 RID: 240337 RVA: 0x007E424E File Offset: 0x007E244E
		public IFoxPutDownT AsIFoxPutDown()
		{
			return this.As<IFoxPutDownT>();
		}

		// Token: 0x0603AAD2 RID: 240338 RVA: 0x007E4256 File Offset: 0x007E2456
		public static TLeisureInteractOptionUnion FromIFoxPutDown(IFoxPutDownT _ifoxputdown)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxPutDown,
				Value = _ifoxputdown
			};
		}

		// Token: 0x0603AAD3 RID: 240339 RVA: 0x007E426C File Offset: 0x007E246C
		public IFoxReversePushT AsIFoxReversePush()
		{
			return this.As<IFoxReversePushT>();
		}

		// Token: 0x0603AAD4 RID: 240340 RVA: 0x007E4274 File Offset: 0x007E2474
		public static TLeisureInteractOptionUnion FromIFoxReversePush(IFoxReversePushT _ifoxreversepush)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IFoxReversePush,
				Value = _ifoxreversepush
			};
		}

		// Token: 0x0603AAD5 RID: 240341 RVA: 0x007E428A File Offset: 0x007E248A
		public IGameplayPose1InteractT AsIGameplayPose1Interact()
		{
			return this.As<IGameplayPose1InteractT>();
		}

		// Token: 0x0603AAD6 RID: 240342 RVA: 0x007E4292 File Offset: 0x007E2492
		public static TLeisureInteractOptionUnion FromIGameplayPose1Interact(IGameplayPose1InteractT _igameplaypose1interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose1Interact,
				Value = _igameplaypose1interact
			};
		}

		// Token: 0x0603AAD7 RID: 240343 RVA: 0x007E42A8 File Offset: 0x007E24A8
		public IGameplayPose2InteractT AsIGameplayPose2Interact()
		{
			return this.As<IGameplayPose2InteractT>();
		}

		// Token: 0x0603AAD8 RID: 240344 RVA: 0x007E42B0 File Offset: 0x007E24B0
		public static TLeisureInteractOptionUnion FromIGameplayPose2Interact(IGameplayPose2InteractT _igameplaypose2interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose2Interact,
				Value = _igameplaypose2interact
			};
		}

		// Token: 0x0603AAD9 RID: 240345 RVA: 0x007E42C6 File Offset: 0x007E24C6
		public IGameplayPose3InteractT AsIGameplayPose3Interact()
		{
			return this.As<IGameplayPose3InteractT>();
		}

		// Token: 0x0603AADA RID: 240346 RVA: 0x007E42CE File Offset: 0x007E24CE
		public static TLeisureInteractOptionUnion FromIGameplayPose3Interact(IGameplayPose3InteractT _igameplaypose3interact)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGameplayPose3Interact,
				Value = _igameplaypose3interact
			};
		}

		// Token: 0x0603AADB RID: 240347 RVA: 0x007E42E4 File Offset: 0x007E24E4
		public IGetOffMotorcycleInteractT AsIGetOffMotorcycleInteract()
		{
			return this.As<IGetOffMotorcycleInteractT>();
		}

		// Token: 0x0603AADC RID: 240348 RVA: 0x007E42EC File Offset: 0x007E24EC
		public static TLeisureInteractOptionUnion FromIGetOffMotorcycleInteract(IGetOffMotorcycleInteractT _igetoffmotorcycleinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGetOffMotorcycleInteract,
				Value = _igetoffmotorcycleinteract
			};
		}

		// Token: 0x0603AADD RID: 240349 RVA: 0x007E4302 File Offset: 0x007E2502
		public IGetUpT AsIGetUp()
		{
			return this.As<IGetUpT>();
		}

		// Token: 0x0603AADE RID: 240350 RVA: 0x007E430A File Offset: 0x007E250A
		public static TLeisureInteractOptionUnion FromIGetUp(IGetUpT _igetup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGetUp,
				Value = _igetup
			};
		}

		// Token: 0x0603AADF RID: 240351 RVA: 0x007E4320 File Offset: 0x007E2520
		public IGlideT AsIGlide()
		{
			return this.As<IGlideT>();
		}

		// Token: 0x0603AAE0 RID: 240352 RVA: 0x007E4328 File Offset: 0x007E2528
		public static TLeisureInteractOptionUnion FromIGlide(IGlideT _iglide)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IGlide,
				Value = _iglide
			};
		}

		// Token: 0x0603AAE1 RID: 240353 RVA: 0x007E433E File Offset: 0x007E253E
		public IHookLockInteractT AsIHookLockInteract()
		{
			return this.As<IHookLockInteractT>();
		}

		// Token: 0x0603AAE2 RID: 240354 RVA: 0x007E4346 File Offset: 0x007E2546
		public static TLeisureInteractOptionUnion FromIHookLockInteract(IHookLockInteractT _ihooklockinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IHookLockInteract,
				Value = _ihooklockinteract
			};
		}

		// Token: 0x0603AAE3 RID: 240355 RVA: 0x007E435C File Offset: 0x007E255C
		public IKiteHookInteractT AsIKiteHookInteract()
		{
			return this.As<IKiteHookInteractT>();
		}

		// Token: 0x0603AAE4 RID: 240356 RVA: 0x007E4364 File Offset: 0x007E2564
		public static TLeisureInteractOptionUnion FromIKiteHookInteract(IKiteHookInteractT _ikitehookinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IKiteHookInteract,
				Value = _ikitehookinteract
			};
		}

		// Token: 0x0603AAE5 RID: 240357 RVA: 0x007E437A File Offset: 0x007E257A
		public ILandSlideEndInteractT AsILandSlideEndInteract()
		{
			return this.As<ILandSlideEndInteractT>();
		}

		// Token: 0x0603AAE6 RID: 240358 RVA: 0x007E4382 File Offset: 0x007E2582
		public static TLeisureInteractOptionUnion FromILandSlideEndInteract(ILandSlideEndInteractT _ilandslideendinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ILandSlideEndInteract,
				Value = _ilandslideendinteract
			};
		}

		// Token: 0x0603AAE7 RID: 240359 RVA: 0x007E4398 File Offset: 0x007E2598
		public ILandSlideInteractT AsILandSlideInteract()
		{
			return this.As<ILandSlideInteractT>();
		}

		// Token: 0x0603AAE8 RID: 240360 RVA: 0x007E43A0 File Offset: 0x007E25A0
		public static TLeisureInteractOptionUnion FromILandSlideInteract(ILandSlideInteractT _ilandslideinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ILandSlideInteract,
				Value = _ilandslideinteract
			};
		}

		// Token: 0x0603AAE9 RID: 240361 RVA: 0x007E43B6 File Offset: 0x007E25B6
		public IManipulateT AsIManipulate()
		{
			return this.As<IManipulateT>();
		}

		// Token: 0x0603AAEA RID: 240362 RVA: 0x007E43BE File Offset: 0x007E25BE
		public static TLeisureInteractOptionUnion FromIManipulate(IManipulateT _imanipulate)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IManipulate,
				Value = _imanipulate
			};
		}

		// Token: 0x0603AAEB RID: 240363 RVA: 0x007E43D4 File Offset: 0x007E25D4
		public IMechEscortFlyT AsIMechEscortFly()
		{
			return this.As<IMechEscortFlyT>();
		}

		// Token: 0x0603AAEC RID: 240364 RVA: 0x007E43DC File Offset: 0x007E25DC
		public static TLeisureInteractOptionUnion FromIMechEscortFly(IMechEscortFlyT _imechescortfly)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMechEscortFly,
				Value = _imechescortfly
			};
		}

		// Token: 0x0603AAED RID: 240365 RVA: 0x007E43F2 File Offset: 0x007E25F2
		public IMechStuntT AsIMechStunt()
		{
			return this.As<IMechStuntT>();
		}

		// Token: 0x0603AAEE RID: 240366 RVA: 0x007E43FA File Offset: 0x007E25FA
		public static TLeisureInteractOptionUnion FromIMechStunt(IMechStuntT _imechstunt)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMechStunt,
				Value = _imechstunt
			};
		}

		// Token: 0x0603AAEF RID: 240367 RVA: 0x007E4410 File Offset: 0x007E2610
		public IMoneHackingDoorInteractT AsIMoneHackingDoorInteract()
		{
			return this.As<IMoneHackingDoorInteractT>();
		}

		// Token: 0x0603AAF0 RID: 240368 RVA: 0x007E4418 File Offset: 0x007E2618
		public static TLeisureInteractOptionUnion FromIMoneHackingDoorInteract(IMoneHackingDoorInteractT _imonehackingdoorinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMoneHackingDoorInteract,
				Value = _imonehackingdoorinteract
			};
		}

		// Token: 0x0603AAF1 RID: 240369 RVA: 0x007E442E File Offset: 0x007E262E
		public IMotorBounceT AsIMotorBounce()
		{
			return this.As<IMotorBounceT>();
		}

		// Token: 0x0603AAF2 RID: 240370 RVA: 0x007E4436 File Offset: 0x007E2636
		public static TLeisureInteractOptionUnion FromIMotorBounce(IMotorBounceT _imotorbounce)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorBounce,
				Value = _imotorbounce
			};
		}

		// Token: 0x0603AAF3 RID: 240371 RVA: 0x007E444C File Offset: 0x007E264C
		public IMotorCatapultT AsIMotorCatapult()
		{
			return this.As<IMotorCatapultT>();
		}

		// Token: 0x0603AAF4 RID: 240372 RVA: 0x007E4454 File Offset: 0x007E2654
		public static TLeisureInteractOptionUnion FromIMotorCatapult(IMotorCatapultT _imotorcatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorCatapult,
				Value = _imotorcatapult
			};
		}

		// Token: 0x0603AAF5 RID: 240373 RVA: 0x007E446A File Offset: 0x007E266A
		public IMotorEnterSlideT AsIMotorEnterSlide()
		{
			return this.As<IMotorEnterSlideT>();
		}

		// Token: 0x0603AAF6 RID: 240374 RVA: 0x007E4472 File Offset: 0x007E2672
		public static TLeisureInteractOptionUnion FromIMotorEnterSlide(IMotorEnterSlideT _imotorenterslide)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorEnterSlide,
				Value = _imotorenterslide
			};
		}

		// Token: 0x0603AAF7 RID: 240375 RVA: 0x007E4488 File Offset: 0x007E2688
		public IMotorSoarInteractT AsIMotorSoarInteract()
		{
			return this.As<IMotorSoarInteractT>();
		}

		// Token: 0x0603AAF8 RID: 240376 RVA: 0x007E4490 File Offset: 0x007E2690
		public static TLeisureInteractOptionUnion FromIMotorSoarInteract(IMotorSoarInteractT _imotorsoarinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IMotorSoarInteract,
				Value = _imotorsoarinteract
			};
		}

		// Token: 0x0603AAF9 RID: 240377 RVA: 0x007E44A6 File Offset: 0x007E26A6
		public IPainCoveringHeadT AsIPainCoveringHead()
		{
			return this.As<IPainCoveringHeadT>();
		}

		// Token: 0x0603AAFA RID: 240378 RVA: 0x007E44AE File Offset: 0x007E26AE
		public static TLeisureInteractOptionUnion FromIPainCoveringHead(IPainCoveringHeadT _ipaincoveringhead)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IPainCoveringHead,
				Value = _ipaincoveringhead
			};
		}

		// Token: 0x0603AAFB RID: 240379 RVA: 0x007E44C4 File Offset: 0x007E26C4
		public IParticipateGroupPatrolT AsIParticipateGroupPatrol()
		{
			return this.As<IParticipateGroupPatrolT>();
		}

		// Token: 0x0603AAFC RID: 240380 RVA: 0x007E44CC File Offset: 0x007E26CC
		public static TLeisureInteractOptionUnion FromIParticipateGroupPatrol(IParticipateGroupPatrolT _iparticipategrouppatrol)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IParticipateGroupPatrol,
				Value = _iparticipategrouppatrol
			};
		}

		// Token: 0x0603AAFD RID: 240381 RVA: 0x007E44E2 File Offset: 0x007E26E2
		public IQiuyuanLongPressQinggongT AsIQiuyuanLongPressQinggong()
		{
			return this.As<IQiuyuanLongPressQinggongT>();
		}

		// Token: 0x0603AAFE RID: 240382 RVA: 0x007E44EA File Offset: 0x007E26EA
		public static TLeisureInteractOptionUnion FromIQiuyuanLongPressQinggong(IQiuyuanLongPressQinggongT _iqiuyuanlongpressqinggong)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanLongPressQinggong,
				Value = _iqiuyuanlongpressqinggong
			};
		}

		// Token: 0x0603AAFF RID: 240383 RVA: 0x007E4500 File Offset: 0x007E2700
		public IQiuyuanQinggongEndT AsIQiuyuanQinggongEnd()
		{
			return this.As<IQiuyuanQinggongEndT>();
		}

		// Token: 0x0603AB00 RID: 240384 RVA: 0x007E4508 File Offset: 0x007E2708
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongEnd(IQiuyuanQinggongEndT _iqiuyuanqinggongend)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongEnd,
				Value = _iqiuyuanqinggongend
			};
		}

		// Token: 0x0603AB01 RID: 240385 RVA: 0x007E451E File Offset: 0x007E271E
		public IQiuyuanQinggongExploration1T AsIQiuyuanQinggongExploration1()
		{
			return this.As<IQiuyuanQinggongExploration1T>();
		}

		// Token: 0x0603AB02 RID: 240386 RVA: 0x007E4526 File Offset: 0x007E2726
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration1(IQiuyuanQinggongExploration1T _iqiuyuanqinggongexploration1)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration1,
				Value = _iqiuyuanqinggongexploration1
			};
		}

		// Token: 0x0603AB03 RID: 240387 RVA: 0x007E453C File Offset: 0x007E273C
		public IQiuyuanQinggongExploration2T AsIQiuyuanQinggongExploration2()
		{
			return this.As<IQiuyuanQinggongExploration2T>();
		}

		// Token: 0x0603AB04 RID: 240388 RVA: 0x007E4544 File Offset: 0x007E2744
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration2(IQiuyuanQinggongExploration2T _iqiuyuanqinggongexploration2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration2,
				Value = _iqiuyuanqinggongexploration2
			};
		}

		// Token: 0x0603AB05 RID: 240389 RVA: 0x007E455A File Offset: 0x007E275A
		public IQiuyuanQinggongExploration3T AsIQiuyuanQinggongExploration3()
		{
			return this.As<IQiuyuanQinggongExploration3T>();
		}

		// Token: 0x0603AB06 RID: 240390 RVA: 0x007E4562 File Offset: 0x007E2762
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration3(IQiuyuanQinggongExploration3T _iqiuyuanqinggongexploration3)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration3,
				Value = _iqiuyuanqinggongexploration3
			};
		}

		// Token: 0x0603AB07 RID: 240391 RVA: 0x007E4578 File Offset: 0x007E2778
		public IQiuyuanQinggongExploration4T AsIQiuyuanQinggongExploration4()
		{
			return this.As<IQiuyuanQinggongExploration4T>();
		}

		// Token: 0x0603AB08 RID: 240392 RVA: 0x007E4580 File Offset: 0x007E2780
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongExploration4(IQiuyuanQinggongExploration4T _iqiuyuanqinggongexploration4)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongExploration4,
				Value = _iqiuyuanqinggongexploration4
			};
		}

		// Token: 0x0603AB09 RID: 240393 RVA: 0x007E4596 File Offset: 0x007E2796
		public IQiuyuanQinggongHoveringT AsIQiuyuanQinggongHovering()
		{
			return this.As<IQiuyuanQinggongHoveringT>();
		}

		// Token: 0x0603AB0A RID: 240394 RVA: 0x007E459E File Offset: 0x007E279E
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongHovering(IQiuyuanQinggongHoveringT _iqiuyuanqinggonghovering)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongHovering,
				Value = _iqiuyuanqinggonghovering
			};
		}

		// Token: 0x0603AB0B RID: 240395 RVA: 0x007E45B4 File Offset: 0x007E27B4
		public IQiuyuanQinggongStraightT AsIQiuyuanQinggongStraight()
		{
			return this.As<IQiuyuanQinggongStraightT>();
		}

		// Token: 0x0603AB0C RID: 240396 RVA: 0x007E45BC File Offset: 0x007E27BC
		public static TLeisureInteractOptionUnion FromIQiuyuanQinggongStraight(IQiuyuanQinggongStraightT _iqiuyuanqinggongstraight)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IQiuyuanQinggongStraight,
				Value = _iqiuyuanqinggongstraight
			};
		}

		// Token: 0x0603AB0D RID: 240397 RVA: 0x007E45D2 File Offset: 0x007E27D2
		public IRideMotorcycleInteractT AsIRideMotorcycleInteract()
		{
			return this.As<IRideMotorcycleInteractT>();
		}

		// Token: 0x0603AB0E RID: 240398 RVA: 0x007E45DA File Offset: 0x007E27DA
		public static TLeisureInteractOptionUnion FromIRideMotorcycleInteract(IRideMotorcycleInteractT _iridemotorcycleinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IRideMotorcycleInteract,
				Value = _iridemotorcycleinteract
			};
		}

		// Token: 0x0603AB0F RID: 240399 RVA: 0x007E45F0 File Offset: 0x007E27F0
		public ISitDownT AsISitDown()
		{
			return this.As<ISitDownT>();
		}

		// Token: 0x0603AB10 RID: 240400 RVA: 0x007E45F8 File Offset: 0x007E27F8
		public static TLeisureInteractOptionUnion FromISitDown(ISitDownT _isitdown)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISitDown,
				Value = _isitdown
			};
		}

		// Token: 0x0603AB11 RID: 240401 RVA: 0x007E460E File Offset: 0x007E280E
		public ISitOnGroundT AsISitOnGround()
		{
			return this.As<ISitOnGroundT>();
		}

		// Token: 0x0603AB12 RID: 240402 RVA: 0x007E4616 File Offset: 0x007E2816
		public static TLeisureInteractOptionUnion FromISitOnGround(ISitOnGroundT _isitonground)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISitOnGround,
				Value = _isitonground
			};
		}

		// Token: 0x0603AB13 RID: 240403 RVA: 0x007E462C File Offset: 0x007E282C
		public ISoarT AsISoar()
		{
			return this.As<ISoarT>();
		}

		// Token: 0x0603AB14 RID: 240404 RVA: 0x007E4634 File Offset: 0x007E2834
		public static TLeisureInteractOptionUnion FromISoar(ISoarT _isoar)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISoar,
				Value = _isoar
			};
		}

		// Token: 0x0603AB15 RID: 240405 RVA: 0x007E464A File Offset: 0x007E284A
		public ISoar2T AsISoar2()
		{
			return this.As<ISoar2T>();
		}

		// Token: 0x0603AB16 RID: 240406 RVA: 0x007E4652 File Offset: 0x007E2852
		public static TLeisureInteractOptionUnion FromISoar2(ISoar2T _isoar2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISoar2,
				Value = _isoar2
			};
		}

		// Token: 0x0603AB17 RID: 240407 RVA: 0x007E4668 File Offset: 0x007E2868
		public IStandControlT AsIStandControl()
		{
			return this.As<IStandControlT>();
		}

		// Token: 0x0603AB18 RID: 240408 RVA: 0x007E4670 File Offset: 0x007E2870
		public static TLeisureInteractOptionUnion FromIStandControl(IStandControlT _istandcontrol)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IStandControl,
				Value = _istandcontrol
			};
		}

		// Token: 0x0603AB19 RID: 240409 RVA: 0x007E4686 File Offset: 0x007E2886
		public IStandControl2T AsIStandControl2()
		{
			return this.As<IStandControl2T>();
		}

		// Token: 0x0603AB1A RID: 240410 RVA: 0x007E468E File Offset: 0x007E288E
		public static TLeisureInteractOptionUnion FromIStandControl2(IStandControl2T _istandcontrol2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IStandControl2,
				Value = _istandcontrol2
			};
		}

		// Token: 0x0603AB1B RID: 240411 RVA: 0x007E46A4 File Offset: 0x007E28A4
		public ISunPalaceInteractT AsISunPalaceInteract()
		{
			return this.As<ISunPalaceInteractT>();
		}

		// Token: 0x0603AB1C RID: 240412 RVA: 0x007E46AC File Offset: 0x007E28AC
		public static TLeisureInteractOptionUnion FromISunPalaceInteract(ISunPalaceInteractT _isunpalaceinteract)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISunPalaceInteract,
				Value = _isunpalaceinteract
			};
		}

		// Token: 0x0603AB1D RID: 240413 RVA: 0x007E46C2 File Offset: 0x007E28C2
		public ISuperCatapultT AsISuperCatapult()
		{
			return this.As<ISuperCatapultT>();
		}

		// Token: 0x0603AB1E RID: 240414 RVA: 0x007E46CA File Offset: 0x007E28CA
		public static TLeisureInteractOptionUnion FromISuperCatapult(ISuperCatapultT _isupercatapult)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISuperCatapult,
				Value = _isupercatapult
			};
		}

		// Token: 0x0603AB1F RID: 240415 RVA: 0x007E46E0 File Offset: 0x007E28E0
		public ISwingT AsISwing()
		{
			return this.As<ISwingT>();
		}

		// Token: 0x0603AB20 RID: 240416 RVA: 0x007E46E8 File Offset: 0x007E28E8
		public static TLeisureInteractOptionUnion FromISwing(ISwingT _iswing)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISwing,
				Value = _iswing
			};
		}

		// Token: 0x0603AB21 RID: 240417 RVA: 0x007E46FE File Offset: 0x007E28FE
		public ISwingGetUpT AsISwingGetUp()
		{
			return this.As<ISwingGetUpT>();
		}

		// Token: 0x0603AB22 RID: 240418 RVA: 0x007E4706 File Offset: 0x007E2906
		public static TLeisureInteractOptionUnion FromISwingGetUp(ISwingGetUpT _iswinggetup)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.ISwingGetUp,
				Value = _iswinggetup
			};
		}

		// Token: 0x0603AB23 RID: 240419 RVA: 0x007E471C File Offset: 0x007E291C
		public IWindProtagonistParkour1T AsIWindProtagonistParkour1()
		{
			return this.As<IWindProtagonistParkour1T>();
		}

		// Token: 0x0603AB24 RID: 240420 RVA: 0x007E4724 File Offset: 0x007E2924
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour1(IWindProtagonistParkour1T _iwindprotagonistparkour1)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour1,
				Value = _iwindprotagonistparkour1
			};
		}

		// Token: 0x0603AB25 RID: 240421 RVA: 0x007E473A File Offset: 0x007E293A
		public IWindProtagonistParkour2T AsIWindProtagonistParkour2()
		{
			return this.As<IWindProtagonistParkour2T>();
		}

		// Token: 0x0603AB26 RID: 240422 RVA: 0x007E4742 File Offset: 0x007E2942
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour2(IWindProtagonistParkour2T _iwindprotagonistparkour2)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour2,
				Value = _iwindprotagonistparkour2
			};
		}

		// Token: 0x0603AB27 RID: 240423 RVA: 0x007E4758 File Offset: 0x007E2958
		public IWindProtagonistParkour3T AsIWindProtagonistParkour3()
		{
			return this.As<IWindProtagonistParkour3T>();
		}

		// Token: 0x0603AB28 RID: 240424 RVA: 0x007E4760 File Offset: 0x007E2960
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour3(IWindProtagonistParkour3T _iwindprotagonistparkour3)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour3,
				Value = _iwindprotagonistparkour3
			};
		}

		// Token: 0x0603AB29 RID: 240425 RVA: 0x007E4776 File Offset: 0x007E2976
		public IWindProtagonistParkour4T AsIWindProtagonistParkour4()
		{
			return this.As<IWindProtagonistParkour4T>();
		}

		// Token: 0x0603AB2A RID: 240426 RVA: 0x007E477E File Offset: 0x007E297E
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour4(IWindProtagonistParkour4T _iwindprotagonistparkour4)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour4,
				Value = _iwindprotagonistparkour4
			};
		}

		// Token: 0x0603AB2B RID: 240427 RVA: 0x007E4794 File Offset: 0x007E2994
		public IWindProtagonistParkour5T AsIWindProtagonistParkour5()
		{
			return this.As<IWindProtagonistParkour5T>();
		}

		// Token: 0x0603AB2C RID: 240428 RVA: 0x007E479C File Offset: 0x007E299C
		public static TLeisureInteractOptionUnion FromIWindProtagonistParkour5(IWindProtagonistParkour5T _iwindprotagonistparkour5)
		{
			return new TLeisureInteractOptionUnion
			{
				Type = TLeisureInteractOption.IWindProtagonistParkour5,
				Value = _iwindprotagonistparkour5
			};
		}

		// Token: 0x0603AB2D RID: 240429 RVA: 0x007E47B4 File Offset: 0x007E29B4
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
