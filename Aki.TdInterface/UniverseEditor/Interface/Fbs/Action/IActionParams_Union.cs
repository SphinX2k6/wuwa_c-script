using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E8 RID: 26344
	public struct IActionParams_Union : IFlatbufferObject
	{
		// Token: 0x1700BF8D RID: 49037
		// (get) Token: 0x0602C465 RID: 181349 RVA: 0x00607172 File Offset: 0x00605372
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C466 RID: 181350 RVA: 0x0060717F File Offset: 0x0060537F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C467 RID: 181351 RVA: 0x00607188 File Offset: 0x00605388
		public static IActionParams_Union GetRootAsIActionParams_Union(ByteBuffer _bb)
		{
			return IActionParams_Union.GetRootAsIActionParams_Union(_bb, default(IActionParams_Union));
		}

		// Token: 0x0602C468 RID: 181352 RVA: 0x006071A4 File Offset: 0x006053A4
		public static IActionParams_Union GetRootAsIActionParams_Union(ByteBuffer _bb, IActionParams_Union obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C469 RID: 181353 RVA: 0x006071C1 File Offset: 0x006053C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C46A RID: 181354 RVA: 0x006071D0 File Offset: 0x006053D0
		public IActionParams_Union __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF8E RID: 49038
		// (get) Token: 0x0602C46B RID: 181355 RVA: 0x006071E0 File Offset: 0x006053E0
		public byte UnionIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF8F RID: 49039
		// (get) Token: 0x0602C46C RID: 181356 RVA: 0x0060721C File Offset: 0x0060541C
		public IActionParams_Union_0 Data0Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IActionParams_Union_0.NONE;
				}
				return (IActionParams_Union_0)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C46D RID: 181357 RVA: 0x00607258 File Offset: 0x00605458
		public TTable? Data0<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C46E RID: 181358 RVA: 0x0060729C File Offset: 0x0060549C
		public IActionParams Data0AsIActionParams()
		{
			return this.Data0<IActionParams>().Value;
		}

		// Token: 0x0602C46F RID: 181359 RVA: 0x006072B8 File Offset: 0x006054B8
		public IInvoke Data0AsIInvoke()
		{
			return this.Data0<IInvoke>().Value;
		}

		// Token: 0x0602C470 RID: 181360 RVA: 0x006072D4 File Offset: 0x006054D4
		public IInteract Data0AsIInteract()
		{
			return this.Data0<IInteract>().Value;
		}

		// Token: 0x0602C471 RID: 181361 RVA: 0x006072F0 File Offset: 0x006054F0
		public IFinishCondition Data0AsIFinishCondition()
		{
			return this.Data0<IFinishCondition>().Value;
		}

		// Token: 0x0602C472 RID: 181362 RVA: 0x0060730C File Offset: 0x0060550C
		public IGetRewardByInteract Data0AsIGetRewardByInteract()
		{
			return this.Data0<IGetRewardByInteract>().Value;
		}

		// Token: 0x0602C473 RID: 181363 RVA: 0x00607328 File Offset: 0x00605528
		public IWaitUntilLevelSequenceReachMark Data0AsIWaitUntilLevelSequenceReachMark()
		{
			return this.Data0<IWaitUntilLevelSequenceReachMark>().Value;
		}

		// Token: 0x0602C474 RID: 181364 RVA: 0x00607344 File Offset: 0x00605544
		public IClearEntityVisibleTag Data0AsIClearEntityVisibleTag()
		{
			return this.Data0<IClearEntityVisibleTag>().Value;
		}

		// Token: 0x0602C475 RID: 181365 RVA: 0x00607360 File Offset: 0x00605560
		public ISetEntityPos Data0AsISetEntityPos()
		{
			return this.Data0<ISetEntityPos>().Value;
		}

		// Token: 0x0602C476 RID: 181366 RVA: 0x0060737C File Offset: 0x0060557C
		public IResetEntityPos Data0AsIResetEntityPos()
		{
			return this.Data0<IResetEntityPos>().Value;
		}

		// Token: 0x0602C477 RID: 181367 RVA: 0x00607398 File Offset: 0x00605598
		public IServerSetPlayerPos Data0AsIServerSetPlayerPos()
		{
			return this.Data0<IServerSetPlayerPos>().Value;
		}

		// Token: 0x0602C478 RID: 181368 RVA: 0x006073B4 File Offset: 0x006055B4
		public IFixTeleControllerPos Data0AsIFixTeleControllerPos()
		{
			return this.Data0<IFixTeleControllerPos>().Value;
		}

		// Token: 0x0602C479 RID: 181369 RVA: 0x006073D0 File Offset: 0x006055D0
		public IFixTeleControllerResetPos Data0AsIFixTeleControllerResetPos()
		{
			return this.Data0<IFixTeleControllerResetPos>().Value;
		}

		// Token: 0x0602C47A RID: 181370 RVA: 0x006073EC File Offset: 0x006055EC
		public IFixFoundationRelation Data0AsIFixFoundationRelation()
		{
			return this.Data0<IFixFoundationRelation>().Value;
		}

		// Token: 0x0602C47B RID: 181371 RVA: 0x00607408 File Offset: 0x00605608
		public ITraceCurrentQuest Data0AsITraceCurrentQuest()
		{
			return this.Data0<ITraceCurrentQuest>().Value;
		}

		// Token: 0x0602C47C RID: 181372 RVA: 0x00607424 File Offset: 0x00605624
		public IFixShowTargetRange Data0AsIFixShowTargetRange()
		{
			return this.Data0<IFixShowTargetRange>().Value;
		}

		// Token: 0x0602C47D RID: 181373 RVA: 0x00607440 File Offset: 0x00605640
		public IFixGetItem Data0AsIFixGetItem()
		{
			return this.Data0<IFixGetItem>().Value;
		}

		// Token: 0x0602C47E RID: 181374 RVA: 0x0060745C File Offset: 0x0060565C
		public ILog Data0AsILog()
		{
			return this.Data0<ILog>().Value;
		}

		// Token: 0x0602C47F RID: 181375 RVA: 0x00607478 File Offset: 0x00605678
		public IShowMessage Data0AsIShowMessage()
		{
			return this.Data0<IShowMessage>().Value;
		}

		// Token: 0x0602C480 RID: 181376 RVA: 0x00607494 File Offset: 0x00605694
		public IPrompt Data0AsIPrompt()
		{
			return this.Data0<IPrompt>().Value;
		}

		// Token: 0x0602C481 RID: 181377 RVA: 0x006074B0 File Offset: 0x006056B0
		public ISendNpcMail Data0AsISendNpcMail()
		{
			return this.Data0<ISendNpcMail>().Value;
		}

		// Token: 0x0602C482 RID: 181378 RVA: 0x006074CC File Offset: 0x006056CC
		public IAdjustTodTime Data0AsIAdjustTodTime()
		{
			return this.Data0<IAdjustTodTime>().Value;
		}

		// Token: 0x0602C483 RID: 181379 RVA: 0x006074E8 File Offset: 0x006056E8
		public ISetAreaTimeState Data0AsISetAreaTimeState()
		{
			return this.Data0<ISetAreaTimeState>().Value;
		}

		// Token: 0x0602C484 RID: 181380 RVA: 0x00607504 File Offset: 0x00605704
		public ISetTimeScale Data0AsISetTimeScale()
		{
			return this.Data0<ISetTimeScale>().Value;
		}

		// Token: 0x0602C485 RID: 181381 RVA: 0x00607520 File Offset: 0x00605720
		public IJumpTalk Data0AsIJumpTalk()
		{
			return this.Data0<IJumpTalk>().Value;
		}

		// Token: 0x0602C486 RID: 181382 RVA: 0x0060753C File Offset: 0x0060573C
		public ISetHeadIconVisible Data0AsISetHeadIconVisible()
		{
			return this.Data0<ISetHeadIconVisible>().Value;
		}

		// Token: 0x0602C487 RID: 181383 RVA: 0x00607558 File Offset: 0x00605758
		public IPlayMontage Data0AsIPlayMontage()
		{
			return this.Data0<IPlayMontage>().Value;
		}

		// Token: 0x0602C488 RID: 181384 RVA: 0x00607574 File Offset: 0x00605774
		public IAvgPlayRoleAction Data0AsIAvgPlayRoleAction()
		{
			return this.Data0<IAvgPlayRoleAction>().Value;
		}

		// Token: 0x0602C489 RID: 181385 RVA: 0x00607590 File Offset: 0x00605790
		public IAvgMoveRole Data0AsIAvgMoveRole()
		{
			return this.Data0<IAvgMoveRole>().Value;
		}

		// Token: 0x0602C48A RID: 181386 RVA: 0x006075AC File Offset: 0x006057AC
		public IAvgFocusRole Data0AsIAvgFocusRole()
		{
			return this.Data0<IAvgFocusRole>().Value;
		}

		// Token: 0x0602C48B RID: 181387 RVA: 0x006075C8 File Offset: 0x006057C8
		public IAvgShakeUi Data0AsIAvgShakeUi()
		{
			return this.Data0<IAvgShakeUi>().Value;
		}

		// Token: 0x0602C48C RID: 181388 RVA: 0x006075E4 File Offset: 0x006057E4
		public IDestroyDynamicEntities Data0AsIDestroyDynamicEntities()
		{
			return this.Data0<IDestroyDynamicEntities>().Value;
		}

		// Token: 0x0602C48D RID: 181389 RVA: 0x00607600 File Offset: 0x00605800
		public IActorLookAt Data0AsIActorLookAt()
		{
			return this.Data0<IActorLookAt>().Value;
		}

		// Token: 0x0602C48E RID: 181390 RVA: 0x0060761C File Offset: 0x0060581C
		public IActorTurnTo Data0AsIActorTurnTo()
		{
			return this.Data0<IActorTurnTo>().Value;
		}

		// Token: 0x0602C48F RID: 181391 RVA: 0x00607638 File Offset: 0x00605838
		public IShowTalk Data0AsIShowTalk()
		{
			return this.Data0<IShowTalk>().Value;
		}

		// Token: 0x0602C490 RID: 181392 RVA: 0x00607654 File Offset: 0x00605854
		public IFinishTalk Data0AsIFinishTalk()
		{
			return this.Data0<IFinishTalk>().Value;
		}

		// Token: 0x0602C491 RID: 181393 RVA: 0x00607670 File Offset: 0x00605870
		public IShowCenterText Data0AsIShowCenterText()
		{
			return this.Data0<IShowCenterText>().Value;
		}

		// Token: 0x0602C492 RID: 181394 RVA: 0x0060768C File Offset: 0x0060588C
		public IFinishState Data0AsIFinishState()
		{
			return this.Data0<IFinishState>().Value;
		}

		// Token: 0x0602C493 RID: 181395 RVA: 0x006076A8 File Offset: 0x006058A8
		public IChangeState Data0AsIChangeState()
		{
			return this.Data0<IChangeState>().Value;
		}

		// Token: 0x0602C494 RID: 181396 RVA: 0x006076C4 File Offset: 0x006058C4
		public IChangeBehaviorState Data0AsIChangeBehaviorState()
		{
			return this.Data0<IChangeBehaviorState>().Value;
		}

		// Token: 0x0602C495 RID: 181397 RVA: 0x006076E0 File Offset: 0x006058E0
		public ISetBehaviorIsPaused Data0AsISetBehaviorIsPaused()
		{
			return this.Data0<ISetBehaviorIsPaused>().Value;
		}

		// Token: 0x0602C496 RID: 181398 RVA: 0x006076FC File Offset: 0x006058FC
		public IChangeRandomState Data0AsIChangeRandomState()
		{
			return this.Data0<IChangeRandomState>().Value;
		}

		// Token: 0x0602C497 RID: 181399 RVA: 0x00607718 File Offset: 0x00605918
		public IChangeActorState Data0AsIChangeActorState()
		{
			return this.Data0<IChangeActorState>().Value;
		}

		// Token: 0x0602C498 RID: 181400 RVA: 0x00607734 File Offset: 0x00605934
		public IChangeOtherState Data0AsIChangeOtherState()
		{
			return this.Data0<IChangeOtherState>().Value;
		}

		// Token: 0x0602C499 RID: 181401 RVA: 0x00607750 File Offset: 0x00605950
		public ISetCameraMode Data0AsISetCameraMode()
		{
			return this.Data0<ISetCameraMode>().Value;
		}

		// Token: 0x0602C49A RID: 181402 RVA: 0x0060776C File Offset: 0x0060596C
		public IModifySceneUiSubtitle Data0AsIModifySceneUiSubtitle()
		{
			return this.Data0<IModifySceneUiSubtitle>().Value;
		}

		// Token: 0x0602C49B RID: 181403 RVA: 0x00607788 File Offset: 0x00605988
		public ISetPlotMode Data0AsISetPlotMode()
		{
			return this.Data0<ISetPlotMode>().Value;
		}

		// Token: 0x0602C49C RID: 181404 RVA: 0x006077A4 File Offset: 0x006059A4
		public IPlaySequenceData Data0AsIPlaySequenceData()
		{
			return this.Data0<IPlaySequenceData>().Value;
		}

		// Token: 0x0602C49D RID: 181405 RVA: 0x006077C0 File Offset: 0x006059C0
		public IPlayCustomSequence Data0AsIPlayCustomSequence()
		{
			return this.Data0<IPlayCustomSequence>().Value;
		}

		// Token: 0x0602C49E RID: 181406 RVA: 0x006077DC File Offset: 0x006059DC
		public IPlayMovie Data0AsIPlayMovie()
		{
			return this.Data0<IPlayMovie>().Value;
		}

		// Token: 0x0602C49F RID: 181407 RVA: 0x006077F8 File Offset: 0x006059F8
		public IPlayEffect Data0AsIPlayEffect()
		{
			return this.Data0<IPlayEffect>().Value;
		}

		// Token: 0x0602C4A0 RID: 181408 RVA: 0x00607814 File Offset: 0x00605A14
		public IPlayEffect2 Data0AsIPlayEffect2()
		{
			return this.Data0<IPlayEffect2>().Value;
		}

		// Token: 0x0602C4A1 RID: 181409 RVA: 0x00607830 File Offset: 0x00605A30
		public IPlayCommonEffect Data0AsIPlayCommonEffect()
		{
			return this.Data0<IPlayCommonEffect>().Value;
		}

		// Token: 0x0602C4A2 RID: 181410 RVA: 0x0060784C File Offset: 0x00605A4C
		public IPlayScreenEffect Data0AsIPlayScreenEffect()
		{
			return this.Data0<IPlayScreenEffect>().Value;
		}

		// Token: 0x0602C4A3 RID: 181411 RVA: 0x00607868 File Offset: 0x00605A68
		public ISwitchEffectState Data0AsISwitchEffectState()
		{
			return this.Data0<ISwitchEffectState>().Value;
		}

		// Token: 0x0602C4A4 RID: 181412 RVA: 0x00607884 File Offset: 0x00605A84
		public IPlayDissolveEffect Data0AsIPlayDissolveEffect()
		{
			return this.Data0<IPlayDissolveEffect>().Value;
		}

		// Token: 0x0602C4A5 RID: 181413 RVA: 0x006078A0 File Offset: 0x00605AA0
		public IPlayMpcEffect Data0AsIPlayMpcEffect()
		{
			return this.Data0<IPlayMpcEffect>().Value;
		}

		// Token: 0x0602C4A6 RID: 181414 RVA: 0x006078BC File Offset: 0x00605ABC
		public IRemoveEffect Data0AsIRemoveEffect()
		{
			return this.Data0<IRemoveEffect>().Value;
		}

		// Token: 0x0602C4A7 RID: 181415 RVA: 0x006078D8 File Offset: 0x00605AD8
		public IWait Data0AsIWait()
		{
			return this.Data0<IWait>().Value;
		}

		// Token: 0x0602C4A8 RID: 181416 RVA: 0x006078F4 File Offset: 0x00605AF4
		public IMoveToPosA Data0AsIMoveToPosA()
		{
			return this.Data0<IMoveToPosA>().Value;
		}

		// Token: 0x0602C4A9 RID: 181417 RVA: 0x00607910 File Offset: 0x00605B10
		public ISetMoveSpeed Data0AsISetMoveSpeed()
		{
			return this.Data0<ISetMoveSpeed>().Value;
		}

		// Token: 0x0602C4AA RID: 181418 RVA: 0x0060792C File Offset: 0x00605B2C
		public ISetPosA Data0AsISetPosA()
		{
			return this.Data0<ISetPosA>().Value;
		}

		// Token: 0x0602C4AB RID: 181419 RVA: 0x00607948 File Offset: 0x00605B48
		public IFaceToPos Data0AsIFaceToPos()
		{
			return this.Data0<IFaceToPos>().Value;
		}

		// Token: 0x0602C4AC RID: 181420 RVA: 0x00607964 File Offset: 0x00605B64
		public ISpawnChild Data0AsISpawnChild()
		{
			return this.Data0<ISpawnChild>().Value;
		}

		// Token: 0x0602C4AD RID: 181421 RVA: 0x00607980 File Offset: 0x00605B80
		public ISimpleMove Data0AsISimpleMove()
		{
			return this.Data0<ISimpleMove>().Value;
		}

		// Token: 0x0602C4AE RID: 181422 RVA: 0x0060799C File Offset: 0x00605B9C
		public ISetNumberVar Data0AsISetNumberVar()
		{
			return this.Data0<ISetNumberVar>().Value;
		}

		// Token: 0x0602C4AF RID: 181423 RVA: 0x006079B8 File Offset: 0x00605BB8
		public ISyncVarToActorState Data0AsISyncVarToActorState()
		{
			return this.Data0<ISyncVarToActorState>().Value;
		}

		// Token: 0x0602C4B0 RID: 181424 RVA: 0x006079D4 File Offset: 0x00605BD4
		public IDoCalculate Data0AsIDoCalculate()
		{
			return this.Data0<IDoCalculate>().Value;
		}

		// Token: 0x0602C4B1 RID: 181425 RVA: 0x006079F0 File Offset: 0x00605BF0
		public ICallByCondition Data0AsICallByCondition()
		{
			return this.Data0<ICallByCondition>().Value;
		}

		// Token: 0x0602C4B2 RID: 181426 RVA: 0x00607A0C File Offset: 0x00605C0C
		public ICallFunction Data0AsICallFunction()
		{
			return this.Data0<ICallFunction>().Value;
		}

		// Token: 0x0602C4B3 RID: 181427 RVA: 0x00607A28 File Offset: 0x00605C28
		public IAddFlowInteractOption Data0AsIAddFlowInteractOption()
		{
			return this.Data0<IAddFlowInteractOption>().Value;
		}

		// Token: 0x0602C4B4 RID: 181428 RVA: 0x00607A44 File Offset: 0x00605C44
		public IRemoveFlowInteractOption Data0AsIRemoveFlowInteractOption()
		{
			return this.Data0<IRemoveFlowInteractOption>().Value;
		}

		// Token: 0x0602C4B5 RID: 181429 RVA: 0x00607A60 File Offset: 0x00605C60
		public IChangeInteractOptionText Data0AsIChangeInteractOptionText()
		{
			return this.Data0<IChangeInteractOptionText>().Value;
		}

		// Token: 0x0602C4B6 RID: 181430 RVA: 0x00607A7C File Offset: 0x00605C7C
		public ISpawnEntity Data0AsISpawnEntity()
		{
			return this.Data0<ISpawnEntity>().Value;
		}

		// Token: 0x0602C4B7 RID: 181431 RVA: 0x00607A98 File Offset: 0x00605C98
		public IDestroyAllChild Data0AsIDestroyAllChild()
		{
			return this.Data0<IDestroyAllChild>().Value;
		}

		// Token: 0x0602C4B8 RID: 181432 RVA: 0x00607AB4 File Offset: 0x00605CB4
		public IDestroyEntity Data0AsIDestroyEntity()
		{
			return this.Data0<IDestroyEntity>().Value;
		}

		// Token: 0x0602C4B9 RID: 181433 RVA: 0x00607AD0 File Offset: 0x00605CD0
		public IPlayFlow Data0AsIPlayFlow()
		{
			return this.Data0<IPlayFlow>().Value;
		}

		// Token: 0x0602C4BA RID: 181434 RVA: 0x00607AEC File Offset: 0x00605CEC
		public IBubbleData Data0AsIBubbleData()
		{
			return this.Data0<IBubbleData>().Value;
		}

		// Token: 0x0602C4BB RID: 181435 RVA: 0x00607B08 File Offset: 0x00605D08
		public IPlayerLookAt Data0AsIPlayerLookAt()
		{
			return this.Data0<IPlayerLookAt>().Value;
		}

		// Token: 0x0602C4BC RID: 181436 RVA: 0x00607B24 File Offset: 0x00605D24
		public IEntityLookAt Data0AsIEntityLookAt()
		{
			return this.Data0<IEntityLookAt>().Value;
		}

		// Token: 0x0602C4BD RID: 181437 RVA: 0x00607B40 File Offset: 0x00605D40
		public ICharacterLookAt Data0AsICharacterLookAt()
		{
			return this.Data0<ICharacterLookAt>().Value;
		}

		// Token: 0x0602C4BE RID: 181438 RVA: 0x00607B5C File Offset: 0x00605D5C
		public IPlayerLookTowards Data0AsIPlayerLookTowards()
		{
			return this.Data0<IPlayerLookTowards>().Value;
		}

		// Token: 0x0602C4BF RID: 181439 RVA: 0x00607B78 File Offset: 0x00605D78
		public IEntityTurnTo Data0AsIEntityTurnTo()
		{
			return this.Data0<IEntityTurnTo>().Value;
		}

		// Token: 0x0602C4C0 RID: 181440 RVA: 0x00607B94 File Offset: 0x00605D94
		public ICameraLookAt Data0AsICameraLookAt()
		{
			return this.Data0<ICameraLookAt>().Value;
		}

		// Token: 0x0602C4C1 RID: 181441 RVA: 0x00607BB0 File Offset: 0x00605DB0
		public IStopCameraLookAt Data0AsIStopCameraLookAt()
		{
			return this.Data0<IStopCameraLookAt>().Value;
		}

		// Token: 0x0602C4C2 RID: 181442 RVA: 0x00607BCC File Offset: 0x00605DCC
		public ISetVar Data0AsISetVar()
		{
			return this.Data0<ISetVar>().Value;
		}

		// Token: 0x0602C4C3 RID: 181443 RVA: 0x00607BE8 File Offset: 0x00605DE8
		public ISetActorVar Data0AsISetActorVar()
		{
			return this.Data0<ISetActorVar>().Value;
		}

		// Token: 0x0602C4C4 RID: 181444 RVA: 0x00607C04 File Offset: 0x00605E04
		public ICalculateVar Data0AsICalculateVar()
		{
			return this.Data0<ICalculateVar>().Value;
		}

		// Token: 0x0602C4C5 RID: 181445 RVA: 0x00607C20 File Offset: 0x00605E20
		public IRandomVar Data0AsIRandomVar()
		{
			return this.Data0<IRandomVar>().Value;
		}

		// Token: 0x0602C4C6 RID: 181446 RVA: 0x00607C3C File Offset: 0x00605E3C
		public IGuideTrigger Data0AsIGuideTrigger()
		{
			return this.Data0<IGuideTrigger>().Value;
		}

		// Token: 0x0602C4C7 RID: 181447 RVA: 0x00607C58 File Offset: 0x00605E58
		public ICompleteGuide Data0AsICompleteGuide()
		{
			return this.Data0<ICompleteGuide>().Value;
		}

		// Token: 0x0602C4C8 RID: 181448 RVA: 0x00607C74 File Offset: 0x00605E74
		public IGetItem Data0AsIGetItem()
		{
			return this.Data0<IGetItem>().Value;
		}

		// Token: 0x0602C4C9 RID: 181449 RVA: 0x00607C90 File Offset: 0x00605E90
		public IDestroyQuestItem Data0AsIDestroyQuestItem()
		{
			return this.Data0<IDestroyQuestItem>().Value;
		}

		// Token: 0x0602C4CA RID: 181450 RVA: 0x00607CAC File Offset: 0x00605EAC
		public IAwakeEntity Data0AsIAwakeEntity()
		{
			return this.Data0<IAwakeEntity>().Value;
		}

		// Token: 0x0602C4CB RID: 181451 RVA: 0x00607CC8 File Offset: 0x00605EC8
		public ISetEntityVisible Data0AsISetEntityVisible()
		{
			return this.Data0<ISetEntityVisible>().Value;
		}

		// Token: 0x0602C4CC RID: 181452 RVA: 0x00607CE4 File Offset: 0x00605EE4
		public ISetEntityClientVisible Data0AsISetEntityClientVisible()
		{
			return this.Data0<ISetEntityClientVisible>().Value;
		}

		// Token: 0x0602C4CD RID: 181453 RVA: 0x00607D00 File Offset: 0x00605F00
		public ISetEntityClientVisibleSave Data0AsISetEntityClientVisibleSave()
		{
			return this.Data0<ISetEntityClientVisibleSave>().Value;
		}

		// Token: 0x0602C4CE RID: 181454 RVA: 0x00607D1C File Offset: 0x00605F1C
		public ILockEntity Data0AsILockEntity()
		{
			return this.Data0<ILockEntity>().Value;
		}

		// Token: 0x0602C4CF RID: 181455 RVA: 0x00607D38 File Offset: 0x00605F38
		public IUnlockEntity Data0AsIUnlockEntity()
		{
			return this.Data0<IUnlockEntity>().Value;
		}

		// Token: 0x0602C4D0 RID: 181456 RVA: 0x00607D54 File Offset: 0x00605F54
		public ICompleteChildQuest Data0AsICompleteChildQuest()
		{
			return this.Data0<ICompleteChildQuest>().Value;
		}

		// Token: 0x0602C4D1 RID: 181457 RVA: 0x00607D70 File Offset: 0x00605F70
		public IAcceptCurrentQuest Data0AsIAcceptCurrentQuest()
		{
			return this.Data0<IAcceptCurrentQuest>().Value;
		}

		// Token: 0x0602C4D2 RID: 181458 RVA: 0x00607D8C File Offset: 0x00605F8C
		public IFinishDoInteract Data0AsIFinishDoInteract()
		{
			return this.Data0<IFinishDoInteract>().Value;
		}

		// Token: 0x0602C4D3 RID: 181459 RVA: 0x00607DA8 File Offset: 0x00605FA8
		public IModifyEntityDecoration Data0AsIModifyEntityDecoration()
		{
			return this.Data0<IModifyEntityDecoration>().Value;
		}

		// Token: 0x0602C4D4 RID: 181460 RVA: 0x00607DC4 File Offset: 0x00605FC4
		public IAddBuffToEntity Data0AsIAddBuffToEntity()
		{
			return this.Data0<IAddBuffToEntity>().Value;
		}

		// Token: 0x0602C4D5 RID: 181461 RVA: 0x00607DE0 File Offset: 0x00605FE0
		public IAddBuffToPlayer Data0AsIAddBuffToPlayer()
		{
			return this.Data0<IAddBuffToPlayer>().Value;
		}

		// Token: 0x0602C4D6 RID: 181462 RVA: 0x00607DFC File Offset: 0x00605FFC
		public IAddBuffToFollowShooter Data0AsIAddBuffToFollowShooter()
		{
			return this.Data0<IAddBuffToFollowShooter>().Value;
		}

		// Token: 0x0602C4D7 RID: 181463 RVA: 0x00607E18 File Offset: 0x00606018
		public IOpenSystemBoard Data0AsIOpenSystemBoard()
		{
			return this.Data0<IOpenSystemBoard>().Value;
		}

		// Token: 0x0602C4D8 RID: 181464 RVA: 0x00607E34 File Offset: 0x00606034
		public IOpenSystemFunction Data0AsIOpenSystemFunction()
		{
			return this.Data0<IOpenSystemFunction>().Value;
		}

		// Token: 0x0602C4D9 RID: 181465 RVA: 0x00607E50 File Offset: 0x00606050
		public IChangeEntityState Data0AsIChangeEntityState()
		{
			return this.Data0<IChangeEntityState>().Value;
		}

		// Token: 0x0602C4DA RID: 181466 RVA: 0x00607E6C File Offset: 0x0060606C
		public IChangeEntityStateDirectly Data0AsIChangeEntityStateDirectly()
		{
			return this.Data0<IChangeEntityStateDirectly>().Value;
		}

		// Token: 0x0602C4DB RID: 181467 RVA: 0x00607E88 File Offset: 0x00606088
		public IChangeEntityStateBatchDirectly Data0AsIChangeEntityStateBatchDirectly()
		{
			return this.Data0<IChangeEntityStateBatchDirectly>().Value;
		}

		// Token: 0x0602C4DC RID: 181468 RVA: 0x00607EA4 File Offset: 0x006060A4
		public IChangeEntityStateLoop Data0AsIChangeEntityStateLoop()
		{
			return this.Data0<IChangeEntityStateLoop>().Value;
		}

		// Token: 0x0602C4DD RID: 181469 RVA: 0x00607EC0 File Offset: 0x006060C0
		public IChangeNpcPerformState Data0AsIChangeNpcPerformState()
		{
			return this.Data0<IChangeNpcPerformState>().Value;
		}

		// Token: 0x0602C4DE RID: 181470 RVA: 0x00607EDC File Offset: 0x006060DC
		public ISetForceLock Data0AsISetForceLock()
		{
			return this.Data0<ISetForceLock>().Value;
		}

		// Token: 0x0602C4DF RID: 181471 RVA: 0x00607EF8 File Offset: 0x006060F8
		public ISetAreaState Data0AsISetAreaState()
		{
			return this.Data0<ISetAreaState>().Value;
		}

		// Token: 0x0602C4E0 RID: 181472 RVA: 0x00607F14 File Offset: 0x00606114
		public ISetWuYinQuState Data0AsISetWuYinQuState()
		{
			return this.Data0<ISetWuYinQuState>().Value;
		}

		// Token: 0x0602C4E1 RID: 181473 RVA: 0x00607F30 File Offset: 0x00606130
		public IRemoveBuffFromEntity Data0AsIRemoveBuffFromEntity()
		{
			return this.Data0<IRemoveBuffFromEntity>().Value;
		}

		// Token: 0x0602C4E2 RID: 181474 RVA: 0x00607F4C File Offset: 0x0060614C
		public IRemoveBuffFromPlayer Data0AsIRemoveBuffFromPlayer()
		{
			return this.Data0<IRemoveBuffFromPlayer>().Value;
		}

		// Token: 0x0602C4E3 RID: 181475 RVA: 0x00607F68 File Offset: 0x00606168
		public ICollect Data0AsICollect()
		{
			return this.Data0<ICollect>().Value;
		}

		// Token: 0x0602C4E4 RID: 181476 RVA: 0x00607F84 File Offset: 0x00606184
		public IDestroy Data0AsIDestroy()
		{
			return this.Data0<IDestroy>().Value;
		}

		// Token: 0x0602C4E5 RID: 181477 RVA: 0x00607FA0 File Offset: 0x006061A0
		public IDestroySelf Data0AsIDestroySelf()
		{
			return this.Data0<IDestroySelf>().Value;
		}

		// Token: 0x0602C4E6 RID: 181478 RVA: 0x00607FBC File Offset: 0x006061BC
		public ISetPlayerMoveControl Data0AsISetPlayerMoveControl()
		{
			return this.Data0<ISetPlayerMoveControl>().Value;
		}

		// Token: 0x0602C4E7 RID: 181479 RVA: 0x00607FD8 File Offset: 0x006061D8
		public IUnlockTeleportTrigger Data0AsIUnlockTeleportTrigger()
		{
			return this.Data0<IUnlockTeleportTrigger>().Value;
		}

		// Token: 0x0602C4E8 RID: 181480 RVA: 0x00607FF4 File Offset: 0x006061F4
		public IChangeTeamPosition Data0AsIChangeTeamPosition()
		{
			return this.Data0<IChangeTeamPosition>().Value;
		}

		// Token: 0x0602C4E9 RID: 181481 RVA: 0x00608010 File Offset: 0x00606210
		public IClientChangeTeamPosition Data0AsIClientChangeTeamPosition()
		{
			return this.Data0<IClientChangeTeamPosition>().Value;
		}

		// Token: 0x0602C4EA RID: 181482 RVA: 0x0060802C File Offset: 0x0060622C
		public IClaimLevelPlayReward Data0AsIClaimLevelPlayReward()
		{
			return this.Data0<IClaimLevelPlayReward>().Value;
		}

		// Token: 0x0602C4EB RID: 181483 RVA: 0x00608048 File Offset: 0x00606248
		public IClaimDynamicEntityReward Data0AsIClaimDynamicEntityReward()
		{
			return this.Data0<IClaimDynamicEntityReward>().Value;
		}

		// Token: 0x0602C4EC RID: 181484 RVA: 0x00608064 File Offset: 0x00606264
		public IClearFishingCabinInSaleItems Data0AsIClearFishingCabinInSaleItems()
		{
			return this.Data0<IClearFishingCabinInSaleItems>().Value;
		}

		// Token: 0x0602C4ED RID: 181485 RVA: 0x00608080 File Offset: 0x00606280
		public IAcceptFishingEntrust Data0AsIAcceptFishingEntrust()
		{
			return this.Data0<IAcceptFishingEntrust>().Value;
		}

		// Token: 0x0602C4EE RID: 181486 RVA: 0x0060809C File Offset: 0x0060629C
		public IDestroyFishingBoat Data0AsIDestroyFishingBoat()
		{
			return this.Data0<IDestroyFishingBoat>().Value;
		}

		// Token: 0x0602C4EF RID: 181487 RVA: 0x006080B8 File Offset: 0x006062B8
		public ITeleportDungeon Data0AsITeleportDungeon()
		{
			return this.Data0<ITeleportDungeon>().Value;
		}

		// Token: 0x0602C4F0 RID: 181488 RVA: 0x006080D4 File Offset: 0x006062D4
		public IStopUiScreenEffect Data0AsIStopUiScreenEffect()
		{
			return this.Data0<IStopUiScreenEffect>().Value;
		}

		// Token: 0x0602C4F1 RID: 181489 RVA: 0x006080F0 File Offset: 0x006062F0
		public IClaimDungeonReward Data0AsIClaimDungeonReward()
		{
			return this.Data0<IClaimDungeonReward>().Value;
		}

		// Token: 0x0602C4F2 RID: 181490 RVA: 0x0060810C File Offset: 0x0060630C
		public ISettlementDungeon Data0AsISettlementDungeon()
		{
			return this.Data0<ISettlementDungeon>().Value;
		}

		// Token: 0x0602C4F3 RID: 181491 RVA: 0x00608128 File Offset: 0x00606328
		public IExitDungeon Data0AsIExitDungeon()
		{
			return this.Data0<IExitDungeon>().Value;
		}

		// Token: 0x0602C4F4 RID: 181492 RVA: 0x00608144 File Offset: 0x00606344
		public IUnlockDungeonEntry Data0AsIUnlockDungeonEntry()
		{
			return this.Data0<IUnlockDungeonEntry>().Value;
		}

		// Token: 0x0602C4F5 RID: 181493 RVA: 0x00608160 File Offset: 0x00606360
		public IFinishDungeon Data0AsIFinishDungeon()
		{
			return this.Data0<IFinishDungeon>().Value;
		}

		// Token: 0x0602C4F6 RID: 181494 RVA: 0x0060817C File Offset: 0x0060637C
		public ISetReviveRegion Data0AsISetReviveRegion()
		{
			return this.Data0<ISetReviveRegion>().Value;
		}

		// Token: 0x0602C4F7 RID: 181495 RVA: 0x00608198 File Offset: 0x00606398
		public IPromptQuestChapterUI Data0AsIPromptQuestChapterUI()
		{
			return this.Data0<IPromptQuestChapterUI>().Value;
		}

		// Token: 0x0602C4F8 RID: 181496 RVA: 0x006081B4 File Offset: 0x006063B4
		public IFireBullet Data0AsIFireBullet()
		{
			return this.Data0<IFireBullet>().Value;
		}

		// Token: 0x0602C4F9 RID: 181497 RVA: 0x006081D0 File Offset: 0x006063D0
		public IFireBulletEffect Data0AsIFireBulletEffect()
		{
			return this.Data0<IFireBulletEffect>().Value;
		}

		// Token: 0x0602C4FA RID: 181498 RVA: 0x006081EC File Offset: 0x006063EC
		public ISetAssistCharacterPos Data0AsISetAssistCharacterPos()
		{
			return this.Data0<ISetAssistCharacterPos>().Value;
		}

		// Token: 0x0602C4FB RID: 181499 RVA: 0x00608208 File Offset: 0x00606408
		public ISetPlayerPos Data0AsISetPlayerPos()
		{
			return this.Data0<ISetPlayerPos>().Value;
		}

		// Token: 0x0602C4FC RID: 181500 RVA: 0x00608224 File Offset: 0x00606424
		public IClientSetPlayerPos Data0AsIClientSetPlayerPos()
		{
			return this.Data0<IClientSetPlayerPos>().Value;
		}

		// Token: 0x0602C4FD RID: 181501 RVA: 0x00608240 File Offset: 0x00606440
		public IClientPreEnableSubLevels Data0AsIClientPreEnableSubLevels()
		{
			return this.Data0<IClientPreEnableSubLevels>().Value;
		}

		// Token: 0x0602C4FE RID: 181502 RVA: 0x0060825C File Offset: 0x0060645C
		public IRogueGotoNextFloor Data0AsIRogueGotoNextFloor()
		{
			return this.Data0<IRogueGotoNextFloor>().Value;
		}

		// Token: 0x0602C4FF RID: 181503 RVA: 0x00608278 File Offset: 0x00606478
		public IRogueSelectRoom Data0AsIRogueSelectRoom()
		{
			return this.Data0<IRogueSelectRoom>().Value;
		}

		// Token: 0x0602C500 RID: 181504 RVA: 0x00608294 File Offset: 0x00606494
		public IRogueActivatePortal Data0AsIRogueActivatePortal()
		{
			return this.Data0<IRogueActivatePortal>().Value;
		}

		// Token: 0x0602C501 RID: 181505 RVA: 0x006082B0 File Offset: 0x006064B0
		public IRogueReceiveReward Data0AsIRogueReceiveReward()
		{
			return this.Data0<IRogueReceiveReward>().Value;
		}

		// Token: 0x0602C502 RID: 181506 RVA: 0x006082CC File Offset: 0x006064CC
		public IChangeSelfEntityState Data0AsIChangeSelfEntityState()
		{
			return this.Data0<IChangeSelfEntityState>().Value;
		}

		// Token: 0x0602C503 RID: 181507 RVA: 0x006082E8 File Offset: 0x006064E8
		public IInterludeActions Data0AsIInterludeActions()
		{
			return this.Data0<IInterludeActions>().Value;
		}

		// Token: 0x0602C504 RID: 181508 RVA: 0x00608304 File Offset: 0x00606504
		public IAddBuffToTriggeredEntity Data0AsIAddBuffToTriggeredEntity()
		{
			return this.Data0<IAddBuffToTriggeredEntity>().Value;
		}

		// Token: 0x0602C505 RID: 181509 RVA: 0x00608320 File Offset: 0x00606520
		public IRemoveBuffToTriggeredEntity Data0AsIRemoveBuffToTriggeredEntity()
		{
			return this.Data0<IRemoveBuffToTriggeredEntity>().Value;
		}

		// Token: 0x0602C506 RID: 181510 RVA: 0x0060833C File Offset: 0x0060653C
		public IDetectTrigger Data0AsIDetectTrigger()
		{
			return this.Data0<IDetectTrigger>().Value;
		}

		// Token: 0x0602C507 RID: 181511 RVA: 0x00608358 File Offset: 0x00606558
		public IItemFoundationMatch Data0AsIItemFoundationMatch()
		{
			return this.Data0<IItemFoundationMatch>().Value;
		}

		// Token: 0x0602C508 RID: 181512 RVA: 0x00608374 File Offset: 0x00606574
		public ISetBattleState Data0AsISetBattleState()
		{
			return this.Data0<ISetBattleState>().Value;
		}

		// Token: 0x0602C509 RID: 181513 RVA: 0x00608390 File Offset: 0x00606590
		public IExecBattleAction Data0AsIExecBattleAction()
		{
			return this.Data0<IExecBattleAction>().Value;
		}

		// Token: 0x0602C50A RID: 181514 RVA: 0x006083AC File Offset: 0x006065AC
		public IExecClientMonsterNpcInteract Data0AsIExecClientMonsterNpcInteract()
		{
			return this.Data0<IExecClientMonsterNpcInteract>().Value;
		}

		// Token: 0x0602C50B RID: 181515 RVA: 0x006083C8 File Offset: 0x006065C8
		public IExecClientBattleAction Data0AsIExecClientBattleAction()
		{
			return this.Data0<IExecClientBattleAction>().Value;
		}

		// Token: 0x0602C50C RID: 181516 RVA: 0x006083E4 File Offset: 0x006065E4
		public IWaitBattleCondition Data0AsIWaitBattleCondition()
		{
			return this.Data0<IWaitBattleCondition>().Value;
		}

		// Token: 0x0602C50D RID: 181517 RVA: 0x00608400 File Offset: 0x00606600
		public IEnableHostility Data0AsIEnableHostility()
		{
			return this.Data0<IEnableHostility>().Value;
		}

		// Token: 0x0602C50E RID: 181518 RVA: 0x0060841C File Offset: 0x0060661C
		public IUnlockSystemItem Data0AsIUnlockSystemItem()
		{
			return this.Data0<IUnlockSystemItem>().Value;
		}

		// Token: 0x0602C50F RID: 181519 RVA: 0x00608438 File Offset: 0x00606638
		public IClientUnlockAchievementSystemItem Data0AsIClientUnlockAchievementSystemItem()
		{
			return this.Data0<IClientUnlockAchievementSystemItem>().Value;
		}

		// Token: 0x0602C510 RID: 181520 RVA: 0x00608454 File Offset: 0x00606654
		public IAddPlayBubble Data0AsIAddPlayBubble()
		{
			return this.Data0<IAddPlayBubble>().Value;
		}

		// Token: 0x0602C511 RID: 181521 RVA: 0x00608470 File Offset: 0x00606670
		public IPlayBubble Data0AsIPlayBubble()
		{
			return this.Data0<IPlayBubble>().Value;
		}

		// Token: 0x0602C512 RID: 181522 RVA: 0x0060848C File Offset: 0x0060668C
		public IClearPlayBubble Data0AsIClearPlayBubble()
		{
			return this.Data0<IClearPlayBubble>().Value;
		}

		// Token: 0x0602C513 RID: 181523 RVA: 0x006084A8 File Offset: 0x006066A8
		public IMoveWithSpline Data0AsIMoveWithSpline()
		{
			return this.Data0<IMoveWithSpline>().Value;
		}

		// Token: 0x0602C514 RID: 181524 RVA: 0x006084C4 File Offset: 0x006066C4
		public INewMoveWithSpline Data0AsINewMoveWithSpline()
		{
			return this.Data0<INewMoveWithSpline>().Value;
		}

		// Token: 0x0602C515 RID: 181525 RVA: 0x006084E0 File Offset: 0x006066E0
		public IStopNewMoveWithSpline Data0AsIStopNewMoveWithSpline()
		{
			return this.Data0<IStopNewMoveWithSpline>().Value;
		}

		// Token: 0x0602C516 RID: 181526 RVA: 0x006084FC File Offset: 0x006066FC
		public ICharacterMoveToPoint Data0AsICharacterMoveToPoint()
		{
			return this.Data0<ICharacterMoveToPoint>().Value;
		}

		// Token: 0x0602C517 RID: 181527 RVA: 0x00608518 File Offset: 0x00606718
		public IPlayerMoveToPoint Data0AsIPlayerMoveToPoint()
		{
			return this.Data0<IPlayerMoveToPoint>().Value;
		}

		// Token: 0x0602C518 RID: 181528 RVA: 0x00608534 File Offset: 0x00606734
		public INpcMoveToPoint Data0AsINpcMoveToPoint()
		{
			return this.Data0<INpcMoveToPoint>().Value;
		}

		// Token: 0x0602C519 RID: 181529 RVA: 0x00608550 File Offset: 0x00606750
		public IToggleScanSplineEffect Data0AsIToggleScanSplineEffect()
		{
			return this.Data0<IToggleScanSplineEffect>().Value;
		}

		// Token: 0x0602C51A RID: 181530 RVA: 0x0060856C File Offset: 0x0060676C
		public IOpenTraceSpline Data0AsIOpenTraceSpline()
		{
			return this.Data0<IOpenTraceSpline>().Value;
		}

		// Token: 0x0602C51B RID: 181531 RVA: 0x00608588 File Offset: 0x00606788
		public ICloseTraceSpline Data0AsICloseTraceSpline()
		{
			return this.Data0<ICloseTraceSpline>().Value;
		}

		// Token: 0x0602C51C RID: 181532 RVA: 0x006085A4 File Offset: 0x006067A4
		public ITraceSpline Data0AsITraceSpline()
		{
			return this.Data0<ITraceSpline>().Value;
		}

		// Token: 0x0602C51D RID: 181533 RVA: 0x006085C0 File Offset: 0x006067C0
		public IEnableAI Data0AsIEnableAI()
		{
			return this.Data0<IEnableAI>().Value;
		}

		// Token: 0x0602C51E RID: 181534 RVA: 0x006085DC File Offset: 0x006067DC
		public IRunActions Data0AsIRunActions()
		{
			return this.Data0<IRunActions>().Value;
		}

		// Token: 0x0602C51F RID: 181535 RVA: 0x006085F8 File Offset: 0x006067F8
		public ICommonTip Data0AsICommonTip()
		{
			return this.Data0<ICommonTip>().Value;
		}

		// Token: 0x0602C520 RID: 181536 RVA: 0x00608614 File Offset: 0x00606814
		public ICommonTip2 Data0AsICommonTip2()
		{
			return this.Data0<ICommonTip2>().Value;
		}

		// Token: 0x0602C521 RID: 181537 RVA: 0x00608630 File Offset: 0x00606830
		public IEndCommonTip Data0AsIEndCommonTip()
		{
			return this.Data0<IEndCommonTip>().Value;
		}

		// Token: 0x0602C522 RID: 181538 RVA: 0x0060864C File Offset: 0x0060684C
		public IEnableNearbyTracking Data0AsIEnableNearbyTracking()
		{
			return this.Data0<IEnableNearbyTracking>().Value;
		}

		// Token: 0x0602C523 RID: 181539 RVA: 0x00608668 File Offset: 0x00606868
		public ISendAiEvent Data0AsISendAiEvent()
		{
			return this.Data0<ISendAiEvent>().Value;
		}

		// Token: 0x0602C524 RID: 181540 RVA: 0x00608684 File Offset: 0x00606884
		public IEnableLevelPlay Data0AsIEnableLevelPlay()
		{
			return this.Data0<IEnableLevelPlay>().Value;
		}

		// Token: 0x0602C525 RID: 181541 RVA: 0x006086A0 File Offset: 0x006068A0
		public IServerForceEnableLevelPlay Data0AsIServerForceEnableLevelPlay()
		{
			return this.Data0<IServerForceEnableLevelPlay>().Value;
		}

		// Token: 0x0602C526 RID: 181542 RVA: 0x006086BC File Offset: 0x006068BC
		public ITeleportDungeonPos Data0AsITeleportDungeonPos()
		{
			return this.Data0<ITeleportDungeonPos>().Value;
		}

		// Token: 0x0602C527 RID: 181543 RVA: 0x006086D8 File Offset: 0x006068D8
		public IFadeInScreen Data0AsIFadeInScreen()
		{
			return this.Data0<IFadeInScreen>().Value;
		}

		// Token: 0x0602C528 RID: 181544 RVA: 0x006086F4 File Offset: 0x006068F4
		public IFadeOutScreen Data0AsIFadeOutScreen()
		{
			return this.Data0<IFadeOutScreen>().Value;
		}

		// Token: 0x0602C529 RID: 181545 RVA: 0x00608710 File Offset: 0x00606910
		public IStartFlowTemplate Data0AsIStartFlowTemplate()
		{
			return this.Data0<IStartFlowTemplate>().Value;
		}

		// Token: 0x0602C52A RID: 181546 RVA: 0x0060872C File Offset: 0x0060692C
		public IEndFlowTemplate Data0AsIEndFlowTemplate()
		{
			return this.Data0<IEndFlowTemplate>().Value;
		}

		// Token: 0x0602C52B RID: 181547 RVA: 0x00608748 File Offset: 0x00606948
		public ICloseFlowTemplate Data0AsICloseFlowTemplate()
		{
			return this.Data0<ICloseFlowTemplate>().Value;
		}

		// Token: 0x0602C52C RID: 181548 RVA: 0x00608764 File Offset: 0x00606964
		public IChangeFlowTemplate Data0AsIChangeFlowTemplate()
		{
			return this.Data0<IChangeFlowTemplate>().Value;
		}

		// Token: 0x0602C52D RID: 181549 RVA: 0x00608780 File Offset: 0x00606980
		public IBeginFlowTemplate Data0AsIBeginFlowTemplate()
		{
			return this.Data0<IBeginFlowTemplate>().Value;
		}

		// Token: 0x0602C52E RID: 181550 RVA: 0x0060879C File Offset: 0x0060699C
		public ISetFlowTemplate Data0AsISetFlowTemplate()
		{
			return this.Data0<ISetFlowTemplate>().Value;
		}

		// Token: 0x0602C52F RID: 181551 RVA: 0x006087B8 File Offset: 0x006069B8
		public IHideTargetRange Data0AsIHideTargetRange()
		{
			return this.Data0<IHideTargetRange>().Value;
		}

		// Token: 0x0602C530 RID: 181552 RVA: 0x006087D4 File Offset: 0x006069D4
		public IShowTargetRange Data0AsIShowTargetRange()
		{
			return this.Data0<IShowTargetRange>().Value;
		}

		// Token: 0x0602C531 RID: 181553 RVA: 0x006087F0 File Offset: 0x006069F0
		public IHideSpecificEntities Data0AsIHideSpecificEntities()
		{
			return this.Data0<IHideSpecificEntities>().Value;
		}

		// Token: 0x0602C532 RID: 181554 RVA: 0x0060880C File Offset: 0x00606A0C
		public IShowSpecificEntities Data0AsIShowSpecificEntities()
		{
			return this.Data0<IShowSpecificEntities>().Value;
		}

		// Token: 0x0602C533 RID: 181555 RVA: 0x00608828 File Offset: 0x00606A28
		public IHideGroup Data0AsIHideGroup()
		{
			return this.Data0<IHideGroup>().Value;
		}

		// Token: 0x0602C534 RID: 181556 RVA: 0x00608844 File Offset: 0x00606A44
		public IShowHidedGroup Data0AsIShowHidedGroup()
		{
			return this.Data0<IShowHidedGroup>().Value;
		}

		// Token: 0x0602C535 RID: 181557 RVA: 0x00608860 File Offset: 0x00606A60
		public ISetSubScreenMode Data0AsISetSubScreenMode()
		{
			return this.Data0<ISetSubScreenMode>().Value;
		}

		// Token: 0x0602C536 RID: 181558 RVA: 0x0060887C File Offset: 0x00606A7C
		public IToggleDragActorPlay Data0AsIToggleDragActorPlay()
		{
			return this.Data0<IToggleDragActorPlay>().Value;
		}

		// Token: 0x0602C537 RID: 181559 RVA: 0x00608898 File Offset: 0x00606A98
		public IDarkTideSetMapMarkState Data0AsIDarkTideSetMapMarkState()
		{
			return this.Data0<IDarkTideSetMapMarkState>().Value;
		}

		// Token: 0x0602C538 RID: 181560 RVA: 0x006088B4 File Offset: 0x00606AB4
		public IManualOccupations Data0AsIManualOccupations()
		{
			return this.Data0<IManualOccupations>().Value;
		}

		// Token: 0x0602C539 RID: 181561 RVA: 0x006088D0 File Offset: 0x00606AD0
		public IForceOccupations Data0AsIForceOccupations()
		{
			return this.Data0<IForceOccupations>().Value;
		}

		// Token: 0x0602C53A RID: 181562 RVA: 0x006088EC File Offset: 0x00606AEC
		public IChangeFightTeam Data0AsIChangeFightTeam()
		{
			return this.Data0<IChangeFightTeam>().Value;
		}

		// Token: 0x0602C53B RID: 181563 RVA: 0x00608908 File Offset: 0x00606B08
		public IActiveRange Data0AsIActiveRange()
		{
			return this.Data0<IActiveRange>().Value;
		}

		// Token: 0x0602C53C RID: 181564 RVA: 0x00608924 File Offset: 0x00606B24
		public IAddTrialCharacter Data0AsIAddTrialCharacter()
		{
			return this.Data0<IAddTrialCharacter>().Value;
		}

		// Token: 0x0602C53D RID: 181565 RVA: 0x00608940 File Offset: 0x00606B40
		public IUpdateTrialCharacter Data0AsIUpdateTrialCharacter()
		{
			return this.Data0<IUpdateTrialCharacter>().Value;
		}

		// Token: 0x0602C53E RID: 181566 RVA: 0x0060895C File Offset: 0x00606B5C
		public IRestoreTrialCharacter Data0AsIRestoreTrialCharacter()
		{
			return this.Data0<IRestoreTrialCharacter>().Value;
		}

		// Token: 0x0602C53F RID: 181567 RVA: 0x00608978 File Offset: 0x00606B78
		public IRemoveTrialCharacter Data0AsIRemoveTrialCharacter()
		{
			return this.Data0<IRemoveTrialCharacter>().Value;
		}

		// Token: 0x0602C540 RID: 181568 RVA: 0x00608994 File Offset: 0x00606B94
		public IAddGuestCharacter Data0AsIAddGuestCharacter()
		{
			return this.Data0<IAddGuestCharacter>().Value;
		}

		// Token: 0x0602C541 RID: 181569 RVA: 0x006089B0 File Offset: 0x00606BB0
		public IRemoveGuestCharacter Data0AsIRemoveGuestCharacter()
		{
			return this.Data0<IRemoveGuestCharacter>().Value;
		}

		// Token: 0x0602C542 RID: 181570 RVA: 0x006089CC File Offset: 0x00606BCC
		public IDestroyQuest Data0AsIDestroyQuest()
		{
			return this.Data0<IDestroyQuest>().Value;
		}

		// Token: 0x0602C543 RID: 181571 RVA: 0x006089E8 File Offset: 0x00606BE8
		public ISetCameraAnim Data0AsISetCameraAnim()
		{
			return this.Data0<ISetCameraAnim>().Value;
		}

		// Token: 0x0602C544 RID: 181572 RVA: 0x00608A04 File Offset: 0x00606C04
		public IChangeTimer Data0AsIChangeTimer()
		{
			return this.Data0<IChangeTimer>().Value;
		}

		// Token: 0x0602C545 RID: 181573 RVA: 0x00608A20 File Offset: 0x00606C20
		public IToggleTimerPauseState Data0AsIToggleTimerPauseState()
		{
			return this.Data0<IToggleTimerPauseState>().Value;
		}

		// Token: 0x0602C546 RID: 181574 RVA: 0x00608A3C File Offset: 0x00606C3C
		public IRotatorEntity Data0AsIRotatorEntity()
		{
			return this.Data0<IRotatorEntity>().Value;
		}

		// Token: 0x0602C547 RID: 181575 RVA: 0x00608A58 File Offset: 0x00606C58
		public IUnLimitPlayerOperation Data0AsIUnLimitPlayerOperation()
		{
			return this.Data0<IUnLimitPlayerOperation>().Value;
		}

		// Token: 0x0602C548 RID: 181576 RVA: 0x00608A74 File Offset: 0x00606C74
		public ILimitPlayerOperation Data0AsILimitPlayerOperation()
		{
			return this.Data0<ILimitPlayerOperation>().Value;
		}

		// Token: 0x0602C549 RID: 181577 RVA: 0x00608A90 File Offset: 0x00606C90
		public IEnableSystem Data0AsIEnableSystem()
		{
			return this.Data0<IEnableSystem>().Value;
		}

		// Token: 0x0602C54A RID: 181578 RVA: 0x00608AAC File Offset: 0x00606CAC
		public ILeisureInteract Data0AsILeisureInteract()
		{
			return this.Data0<ILeisureInteract>().Value;
		}

		// Token: 0x0602C54B RID: 181579 RVA: 0x00608AC8 File Offset: 0x00606CC8
		public INpcLeisureInteract Data0AsINpcLeisureInteract()
		{
			return this.Data0<INpcLeisureInteract>().Value;
		}

		// Token: 0x0602C54C RID: 181580 RVA: 0x00608AE4 File Offset: 0x00606CE4
		public IPostAkEvent Data0AsIPostAkEvent()
		{
			return this.Data0<IPostAkEvent>().Value;
		}

		// Token: 0x0602C54D RID: 181581 RVA: 0x00608B00 File Offset: 0x00606D00
		public IMoveSceneItem Data0AsIMoveSceneItem()
		{
			return this.Data0<IMoveSceneItem>().Value;
		}

		// Token: 0x0602C54E RID: 181582 RVA: 0x00608B1C File Offset: 0x00606D1C
		public IStopSceneItemMove Data0AsIStopSceneItemMove()
		{
			return this.Data0<IStopSceneItemMove>().Value;
		}

		// Token: 0x0602C54F RID: 181583 RVA: 0x00608B38 File Offset: 0x00606D38
		public IChangeLiftTarget Data0AsIChangeLiftTarget()
		{
			return this.Data0<IChangeLiftTarget>().Value;
		}

		// Token: 0x0602C550 RID: 181584 RVA: 0x00608B54 File Offset: 0x00606D54
		public IHideByRangeInFlow Data0AsIHideByRangeInFlow()
		{
			return this.Data0<IHideByRangeInFlow>().Value;
		}

		// Token: 0x0602C551 RID: 181585 RVA: 0x00608B70 File Offset: 0x00606D70
		public IShowAllHidedGroupInFlow Data0AsIShowAllHidedGroupInFlow()
		{
			return this.Data0<IShowAllHidedGroupInFlow>().Value;
		}

		// Token: 0x0602C552 RID: 181586 RVA: 0x00608B8C File Offset: 0x00606D8C
		public IOpenSimpleGameplay Data0AsIOpenSimpleGameplay()
		{
			return this.Data0<IOpenSimpleGameplay>().Value;
		}

		// Token: 0x0602C553 RID: 181587 RVA: 0x00608BA8 File Offset: 0x00606DA8
		public IToggleRideFlyingCarUiGameplay Data0AsIToggleRideFlyingCarUiGameplay()
		{
			return this.Data0<IToggleRideFlyingCarUiGameplay>().Value;
		}

		// Token: 0x0602C554 RID: 181588 RVA: 0x00608BC4 File Offset: 0x00606DC4
		public IChangePhantom Data0AsIChangePhantom()
		{
			return this.Data0<IChangePhantom>().Value;
		}

		// Token: 0x0602C555 RID: 181589 RVA: 0x00608BE0 File Offset: 0x00606DE0
		public IRestorePhantom Data0AsIRestorePhantom()
		{
			return this.Data0<IRestorePhantom>().Value;
		}

		// Token: 0x0602C556 RID: 181590 RVA: 0x00608BFC File Offset: 0x00606DFC
		public ITakePlotPhoto Data0AsITakePlotPhoto()
		{
			return this.Data0<ITakePlotPhoto>().Value;
		}

		// Token: 0x0602C557 RID: 181591 RVA: 0x00608C18 File Offset: 0x00606E18
		public IChangeActorTalker Data0AsIChangeActorTalker()
		{
			return this.Data0<IChangeActorTalker>().Value;
		}

		// Token: 0x0602C558 RID: 181592 RVA: 0x00608C34 File Offset: 0x00606E34
		public ISwitchSubLevels Data0AsISwitchSubLevels()
		{
			return this.Data0<ISwitchSubLevels>().Value;
		}

		// Token: 0x0602C559 RID: 181593 RVA: 0x00608C50 File Offset: 0x00606E50
		public ISwitchSubLevelsDirectly Data0AsISwitchSubLevelsDirectly()
		{
			return this.Data0<ISwitchSubLevelsDirectly>().Value;
		}

		// Token: 0x0602C55A RID: 181594 RVA: 0x00608C6C File Offset: 0x00606E6C
		public IPreloadSubLevels Data0AsIPreloadSubLevels()
		{
			return this.Data0<IPreloadSubLevels>().Value;
		}

		// Token: 0x0602C55B RID: 181595 RVA: 0x00608C88 File Offset: 0x00606E88
		public ISwitchPermission Data0AsISwitchPermission()
		{
			return this.Data0<ISwitchPermission>().Value;
		}

		// Token: 0x0602C55C RID: 181596 RVA: 0x00608CA4 File Offset: 0x00606EA4
		public ISwitchDataLayers Data0AsISwitchDataLayers()
		{
			return this.Data0<ISwitchDataLayers>().Value;
		}

		// Token: 0x0602C55D RID: 181597 RVA: 0x00608CC0 File Offset: 0x00606EC0
		public IActivateResetPoint Data0AsIActivateResetPoint()
		{
			return this.Data0<IActivateResetPoint>().Value;
		}

		// Token: 0x0602C55E RID: 181598 RVA: 0x00608CDC File Offset: 0x00606EDC
		public ITeleportToLatestResetPoint Data0AsITeleportToLatestResetPoint()
		{
			return this.Data0<ITeleportToLatestResetPoint>().Value;
		}

		// Token: 0x0602C55F RID: 181599 RVA: 0x00608CF8 File Offset: 0x00606EF8
		public ISetWeather Data0AsISetWeather()
		{
			return this.Data0<ISetWeather>().Value;
		}

		// Token: 0x0602C560 RID: 181600 RVA: 0x00608D14 File Offset: 0x00606F14
		public ISetTimeLockState Data0AsISetTimeLockState()
		{
			return this.Data0<ISetTimeLockState>().Value;
		}

		// Token: 0x0602C561 RID: 181601 RVA: 0x00608D30 File Offset: 0x00606F30
		public ISetWeatherLockState Data0AsISetWeatherLockState()
		{
			return this.Data0<ISetWeatherLockState>().Value;
		}

		// Token: 0x0602C562 RID: 181602 RVA: 0x00608D4C File Offset: 0x00606F4C
		public IClientSetSeasonState Data0AsIClientSetSeasonState()
		{
			return this.Data0<IClientSetSeasonState>().Value;
		}

		// Token: 0x0602C563 RID: 181603 RVA: 0x00608D68 File Offset: 0x00606F68
		public IAxisLockScreenConfig Data0AsIAxisLockScreenConfig()
		{
			return this.Data0<IAxisLockScreenConfig>().Value;
		}

		// Token: 0x0602C564 RID: 181604 RVA: 0x00608D84 File Offset: 0x00606F84
		public IAdjustPlayerCamera Data0AsIAdjustPlayerCamera()
		{
			return this.Data0<IAdjustPlayerCamera>().Value;
		}

		// Token: 0x0602C565 RID: 181605 RVA: 0x00608DA0 File Offset: 0x00606FA0
		public IRestorePlayerCameraAdjustment Data0AsIRestorePlayerCameraAdjustment()
		{
			return this.Data0<IRestorePlayerCameraAdjustment>().Value;
		}

		// Token: 0x0602C566 RID: 181606 RVA: 0x00608DBC File Offset: 0x00606FBC
		public IAdjustPlayerCameraGravity Data0AsIAdjustPlayerCameraGravity()
		{
			return this.Data0<IAdjustPlayerCameraGravity>().Value;
		}

		// Token: 0x0602C567 RID: 181607 RVA: 0x00608DD8 File Offset: 0x00606FD8
		public IEnterMovieCamera Data0AsIEnterMovieCamera()
		{
			return this.Data0<IEnterMovieCamera>().Value;
		}

		// Token: 0x0602C568 RID: 181608 RVA: 0x00608DF4 File Offset: 0x00606FF4
		public IExitMovieCamera Data0AsIExitMovieCamera()
		{
			return this.Data0<IExitMovieCamera>().Value;
		}

		// Token: 0x0602C569 RID: 181609 RVA: 0x00608E10 File Offset: 0x00607010
		public IResetPlayerCameraFocus Data0AsIResetPlayerCameraFocus()
		{
			return this.Data0<IResetPlayerCameraFocus>().Value;
		}

		// Token: 0x0602C56A RID: 181610 RVA: 0x00608E2C File Offset: 0x0060702C
		public IUsePhantomSkill Data0AsIUsePhantomSkill()
		{
			return this.Data0<IUsePhantomSkill>().Value;
		}

		// Token: 0x0602C56B RID: 181611 RVA: 0x00608E48 File Offset: 0x00607048
		public IChangePhantomFormation Data0AsIChangePhantomFormation()
		{
			return this.Data0<IChangePhantomFormation>().Value;
		}

		// Token: 0x0602C56C RID: 181612 RVA: 0x00608E64 File Offset: 0x00607064
		public IRestorePhantomFormation Data0AsIRestorePhantomFormation()
		{
			return this.Data0<IRestorePhantomFormation>().Value;
		}

		// Token: 0x1700BF90 RID: 49040
		// (get) Token: 0x0602C56D RID: 181613 RVA: 0x00608E80 File Offset: 0x00607080
		public IActionParams_Union_1 Data1Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return IActionParams_Union_1.NONE;
				}
				return (IActionParams_Union_1)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C56E RID: 181614 RVA: 0x00608EC0 File Offset: 0x006070C0
		public TTable? Data1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C56F RID: 181615 RVA: 0x00608F08 File Offset: 0x00607108
		public IEnterOrbitalCamera Data1AsIEnterOrbitalCamera()
		{
			return this.Data1<IEnterOrbitalCamera>().Value;
		}

		// Token: 0x0602C570 RID: 181616 RVA: 0x00608F24 File Offset: 0x00607124
		public IExitOrbitalCamera Data1AsIExitOrbitalCamera()
		{
			return this.Data1<IExitOrbitalCamera>().Value;
		}

		// Token: 0x0602C571 RID: 181617 RVA: 0x00608F40 File Offset: 0x00607140
		public IEnableSplineMoveModel Data1AsIEnableSplineMoveModel()
		{
			return this.Data1<IEnableSplineMoveModel>().Value;
		}

		// Token: 0x0602C572 RID: 181618 RVA: 0x00608F5C File Offset: 0x0060715C
		public IEnableActor Data1AsIEnableActor()
		{
			return this.Data1<IEnableActor>().Value;
		}

		// Token: 0x0602C573 RID: 181619 RVA: 0x00608F78 File Offset: 0x00607178
		public ISetSportsState Data1AsISetSportsState()
		{
			return this.Data1<ISetSportsState>().Value;
		}

		// Token: 0x0602C574 RID: 181620 RVA: 0x00608F94 File Offset: 0x00607194
		public ISetExploreState Data1AsISetExploreState()
		{
			return this.Data1<ISetExploreState>().Value;
		}

		// Token: 0x0602C575 RID: 181621 RVA: 0x00608FB0 File Offset: 0x006071B0
		public IModifyActorMaterial Data1AsIModifyActorMaterial()
		{
			return this.Data1<IModifyActorMaterial>().Value;
		}

		// Token: 0x0602C576 RID: 181622 RVA: 0x00608FCC File Offset: 0x006071CC
		public IModifyActorMaterialParamBySplineProgress Data1AsIModifyActorMaterialParamBySplineProgress()
		{
			return this.Data1<IModifyActorMaterialParamBySplineProgress>().Value;
		}

		// Token: 0x0602C577 RID: 181623 RVA: 0x00608FE8 File Offset: 0x006071E8
		public IModifyActorMedia Data1AsIModifyActorMedia()
		{
			return this.Data1<IModifyActorMedia>().Value;
		}

		// Token: 0x0602C578 RID: 181624 RVA: 0x00609004 File Offset: 0x00607204
		public IPlayLevelSequence Data1AsIPlayLevelSequence()
		{
			return this.Data1<IPlayLevelSequence>().Value;
		}

		// Token: 0x0602C579 RID: 181625 RVA: 0x00609020 File Offset: 0x00607220
		public IEnableTakePhotoClip Data1AsIEnableTakePhotoClip()
		{
			return this.Data1<IEnableTakePhotoClip>().Value;
		}

		// Token: 0x0602C57A RID: 181626 RVA: 0x0060903C File Offset: 0x0060723C
		public IToggleAirWall Data1AsIToggleAirWall()
		{
			return this.Data1<IToggleAirWall>().Value;
		}

		// Token: 0x0602C57B RID: 181627 RVA: 0x00609058 File Offset: 0x00607258
		public ITriggerCameraShake Data1AsITriggerCameraShake()
		{
			return this.Data1<ITriggerCameraShake>().Value;
		}

		// Token: 0x0602C57C RID: 181628 RVA: 0x00609074 File Offset: 0x00607274
		public ITriggerGamepadShake Data1AsITriggerGamepadShake()
		{
			return this.Data1<ITriggerGamepadShake>().Value;
		}

		// Token: 0x0602C57D RID: 181629 RVA: 0x00609090 File Offset: 0x00607290
		public IPlayRegisteredMontage Data1AsIPlayRegisteredMontage()
		{
			return this.Data1<IPlayRegisteredMontage>().Value;
		}

		// Token: 0x0602C57E RID: 181630 RVA: 0x006090AC File Offset: 0x006072AC
		public ICreatePrefab Data1AsICreatePrefab()
		{
			return this.Data1<ICreatePrefab>().Value;
		}

		// Token: 0x0602C57F RID: 181631 RVA: 0x006090C8 File Offset: 0x006072C8
		public IDestroyPrefab Data1AsIDestroyPrefab()
		{
			return this.Data1<IDestroyPrefab>().Value;
		}

		// Token: 0x0602C580 RID: 181632 RVA: 0x006090E4 File Offset: 0x006072E4
		public ISetDataLayerTransitions Data1AsISetDataLayerTransitions()
		{
			return this.Data1<ISetDataLayerTransitions>().Value;
		}

		// Token: 0x0602C581 RID: 181633 RVA: 0x00609100 File Offset: 0x00607300
		public IEnableAoiNotify Data1AsIEnableAoiNotify()
		{
			return this.Data1<IEnableAoiNotify>().Value;
		}

		// Token: 0x0602C582 RID: 181634 RVA: 0x0060911C File Offset: 0x0060731C
		public IRecoverDurability Data1AsIRecoverDurability()
		{
			return this.Data1<IRecoverDurability>().Value;
		}

		// Token: 0x0602C583 RID: 181635 RVA: 0x00609138 File Offset: 0x00607338
		public ISetPlayerOperationRestriction Data1AsISetPlayerOperationRestriction()
		{
			return this.Data1<ISetPlayerOperationRestriction>().Value;
		}

		// Token: 0x0602C584 RID: 181636 RVA: 0x00609154 File Offset: 0x00607354
		public IEnableAllPlayerOperation Data1AsIEnableAllPlayerOperation()
		{
			return this.Data1<IEnableAllPlayerOperation>().Value;
		}

		// Token: 0x0602C585 RID: 181637 RVA: 0x00609170 File Offset: 0x00607370
		public IDisableAllPlayerOperation Data1AsIDisableAllPlayerOperation()
		{
			return this.Data1<IDisableAllPlayerOperation>().Value;
		}

		// Token: 0x0602C586 RID: 181638 RVA: 0x0060918C File Offset: 0x0060738C
		public IDisableModulePlayerOperation Data1AsIDisableModulePlayerOperation()
		{
			return this.Data1<IDisableModulePlayerOperation>().Value;
		}

		// Token: 0x0602C587 RID: 181639 RVA: 0x006091A8 File Offset: 0x006073A8
		public IClientSetPlayerOperationRestriction Data1AsIClientSetPlayerOperationRestriction()
		{
			return this.Data1<IClientSetPlayerOperationRestriction>().Value;
		}

		// Token: 0x0602C588 RID: 181640 RVA: 0x006091C4 File Offset: 0x006073C4
		public IClientEnableAllPlayerOperation Data1AsIClientEnableAllPlayerOperation()
		{
			return this.Data1<IClientEnableAllPlayerOperation>().Value;
		}

		// Token: 0x0602C589 RID: 181641 RVA: 0x006091E0 File Offset: 0x006073E0
		public IClientDisableAllPlayerOperation Data1AsIClientDisableAllPlayerOperation()
		{
			return this.Data1<IClientDisableAllPlayerOperation>().Value;
		}

		// Token: 0x0602C58A RID: 181642 RVA: 0x006091FC File Offset: 0x006073FC
		public IClientDisableModulePlayerOperation Data1AsIClientDisableModulePlayerOperation()
		{
			return this.Data1<IClientDisableModulePlayerOperation>().Value;
		}

		// Token: 0x0602C58B RID: 181643 RVA: 0x00609218 File Offset: 0x00607418
		public IEnableFunction Data1AsIEnableFunction()
		{
			return this.Data1<IEnableFunction>().Value;
		}

		// Token: 0x0602C58C RID: 181644 RVA: 0x00609234 File Offset: 0x00607434
		public ITeleportDungeonFunction Data1AsITeleportDungeonFunction()
		{
			return this.Data1<ITeleportDungeonFunction>().Value;
		}

		// Token: 0x0602C58D RID: 181645 RVA: 0x00609250 File Offset: 0x00607450
		public IMotorRadioUiFunction Data1AsIMotorRadioUiFunction()
		{
			return this.Data1<IMotorRadioUiFunction>().Value;
		}

		// Token: 0x0602C58E RID: 181646 RVA: 0x0060926C File Offset: 0x0060746C
		public IInteractiveItemsFunction Data1AsIInteractiveItemsFunction()
		{
			return this.Data1<IInteractiveItemsFunction>().Value;
		}

		// Token: 0x0602C58F RID: 181647 RVA: 0x00609288 File Offset: 0x00607488
		public IEnableClientFunction Data1AsIEnableClientFunction()
		{
			return this.Data1<IEnableClientFunction>().Value;
		}

		// Token: 0x0602C590 RID: 181648 RVA: 0x006092A4 File Offset: 0x006074A4
		public IHealthBarDisplayClientFunction Data1AsIHealthBarDisplayClientFunction()
		{
			return this.Data1<IHealthBarDisplayClientFunction>().Value;
		}

		// Token: 0x0602C591 RID: 181649 RVA: 0x006092C0 File Offset: 0x006074C0
		public IChangeEntityPrefabPerformance Data1AsIChangeEntityPrefabPerformance()
		{
			return this.Data1<IChangeEntityPrefabPerformance>().Value;
		}

		// Token: 0x0602C592 RID: 181650 RVA: 0x006092DC File Offset: 0x006074DC
		public IChangeTargetEntityPrefabPerformance Data1AsIChangeTargetEntityPrefabPerformance()
		{
			return this.Data1<IChangeTargetEntityPrefabPerformance>().Value;
		}

		// Token: 0x0602C593 RID: 181651 RVA: 0x006092F8 File Offset: 0x006074F8
		public IChangeSelfEntityPrefabPerformance Data1AsIChangeSelfEntityPrefabPerformance()
		{
			return this.Data1<IChangeSelfEntityPrefabPerformance>().Value;
		}

		// Token: 0x0602C594 RID: 181652 RVA: 0x00609314 File Offset: 0x00607514
		public IModifySceneItemAttributeTag Data1AsIModifySceneItemAttributeTag()
		{
			return this.Data1<IModifySceneItemAttributeTag>().Value;
		}

		// Token: 0x0602C595 RID: 181653 RVA: 0x00609330 File Offset: 0x00607530
		public IModifySelfSceneItemAttributeTag Data1AsIModifySelfSceneItemAttributeTag()
		{
			return this.Data1<IModifySelfSceneItemAttributeTag>().Value;
		}

		// Token: 0x0602C596 RID: 181654 RVA: 0x0060934C File Offset: 0x0060754C
		public IModifyTargetSceneItemAttributeTag Data1AsIModifyTargetSceneItemAttributeTag()
		{
			return this.Data1<IModifyTargetSceneItemAttributeTag>().Value;
		}

		// Token: 0x0602C597 RID: 181655 RVA: 0x00609368 File Offset: 0x00607568
		public IClientModifyTargetTag Data1AsIClientModifyTargetTag()
		{
			return this.Data1<IClientModifyTargetTag>().Value;
		}

		// Token: 0x0602C598 RID: 181656 RVA: 0x00609384 File Offset: 0x00607584
		public IToggleMapMarkState Data1AsIToggleMapMarkState()
		{
			return this.Data1<IToggleMapMarkState>().Value;
		}

		// Token: 0x0602C599 RID: 181657 RVA: 0x006093A0 File Offset: 0x006075A0
		public IShowMapMark Data1AsIShowMapMark()
		{
			return this.Data1<IShowMapMark>().Value;
		}

		// Token: 0x0602C59A RID: 181658 RVA: 0x006093BC File Offset: 0x006075BC
		public IHideMapMark Data1AsIHideMapMark()
		{
			return this.Data1<IHideMapMark>().Value;
		}

		// Token: 0x0602C59B RID: 181659 RVA: 0x006093D8 File Offset: 0x006075D8
		public IDisableMapMark Data1AsIDisableMapMark()
		{
			return this.Data1<IDisableMapMark>().Value;
		}

		// Token: 0x0602C59C RID: 181660 RVA: 0x006093F4 File Offset: 0x006075F4
		public IFocusOnMapMarkAction Data1AsIFocusOnMapMarkAction()
		{
			return this.Data1<IFocusOnMapMarkAction>().Value;
		}

		// Token: 0x0602C59D RID: 181661 RVA: 0x00609410 File Offset: 0x00607610
		public IEnableTemporaryTeleport Data1AsIEnableTemporaryTeleport()
		{
			return this.Data1<IEnableTemporaryTeleport>().Value;
		}

		// Token: 0x0602C59E RID: 181662 RVA: 0x0060942C File Offset: 0x0060762C
		public ISetRegionConfig Data1AsISetRegionConfig()
		{
			return this.Data1<ISetRegionConfig>().Value;
		}

		// Token: 0x0602C59F RID: 181663 RVA: 0x00609448 File Offset: 0x00607648
		public ISetRegionMpc Data1AsISetRegionMpc()
		{
			return this.Data1<ISetRegionMpc>().Value;
		}

		// Token: 0x0602C5A0 RID: 181664 RVA: 0x00609464 File Offset: 0x00607664
		public ISetJigsawItem Data1AsISetJigsawItem()
		{
			return this.Data1<ISetJigsawItem>().Value;
		}

		// Token: 0x0602C5A1 RID: 181665 RVA: 0x00609480 File Offset: 0x00607680
		public ISetJigsawFoundation Data1AsISetJigsawFoundation()
		{
			return this.Data1<ISetJigsawFoundation>().Value;
		}

		// Token: 0x0602C5A2 RID: 181666 RVA: 0x0060949C File Offset: 0x0060769C
		public IToggleHighlightExploreUi Data1AsIToggleHighlightExploreUi()
		{
			return this.Data1<IToggleHighlightExploreUi>().Value;
		}

		// Token: 0x0602C5A3 RID: 181667 RVA: 0x006094B8 File Offset: 0x006076B8
		public IShowHighlightExploreSkillIcon Data1AsIShowHighlightExploreSkillIcon()
		{
			return this.Data1<IShowHighlightExploreSkillIcon>().Value;
		}

		// Token: 0x0602C5A4 RID: 181668 RVA: 0x006094D4 File Offset: 0x006076D4
		public IHideHighlightExploreSkillIcon Data1AsIHideHighlightExploreSkillIcon()
		{
			return this.Data1<IHideHighlightExploreSkillIcon>().Value;
		}

		// Token: 0x0602C5A5 RID: 181669 RVA: 0x006094F0 File Offset: 0x006076F0
		public IToggleAndHighlightItem Data1AsIToggleAndHighlightItem()
		{
			return this.Data1<IToggleAndHighlightItem>().Value;
		}

		// Token: 0x0602C5A6 RID: 181670 RVA: 0x0060950C File Offset: 0x0060770C
		public IResetEntity Data1AsIResetEntity()
		{
			return this.Data1<IResetEntity>().Value;
		}

		// Token: 0x0602C5A7 RID: 181671 RVA: 0x00609528 File Offset: 0x00607728
		public IResetLevelPlay Data1AsIResetLevelPlay()
		{
			return this.Data1<IResetLevelPlay>().Value;
		}

		// Token: 0x0602C5A8 RID: 181672 RVA: 0x00609544 File Offset: 0x00607744
		public IPlayDynamicSettlement Data1AsIPlayDynamicSettlement()
		{
			return this.Data1<IPlayDynamicSettlement>().Value;
		}

		// Token: 0x0602C5A9 RID: 181673 RVA: 0x00609560 File Offset: 0x00607760
		public ISetInteractionLockState Data1AsISetInteractionLockState()
		{
			return this.Data1<ISetInteractionLockState>().Value;
		}

		// Token: 0x0602C5AA RID: 181674 RVA: 0x0060957C File Offset: 0x0060777C
		public ISetAudioState Data1AsISetAudioState()
		{
			return this.Data1<ISetAudioState>().Value;
		}

		// Token: 0x0602C5AB RID: 181675 RVA: 0x00609598 File Offset: 0x00607798
		public ISendBattleTag Data1AsISendBattleTag()
		{
			return this.Data1<ISendBattleTag>().Value;
		}

		// Token: 0x0602C5AC RID: 181676 RVA: 0x006095B4 File Offset: 0x006077B4
		public IPerformerAiSplineMove Data1AsIPerformerAiSplineMove()
		{
			return this.Data1<IPerformerAiSplineMove>().Value;
		}

		// Token: 0x0602C5AD RID: 181677 RVA: 0x006095D0 File Offset: 0x006077D0
		public IPerformerAiMoveTo Data1AsIPerformerAiMoveTo()
		{
			return this.Data1<IPerformerAiMoveTo>().Value;
		}

		// Token: 0x0602C5AE RID: 181678 RVA: 0x006095EC File Offset: 0x006077EC
		public IAddTrialFollowShooter Data1AsIAddTrialFollowShooter()
		{
			return this.Data1<IAddTrialFollowShooter>().Value;
		}

		// Token: 0x0602C5AF RID: 181679 RVA: 0x00609608 File Offset: 0x00607808
		public IRemoveTrialFollowShooter Data1AsIRemoveTrialFollowShooter()
		{
			return this.Data1<IRemoveTrialFollowShooter>().Value;
		}

		// Token: 0x0602C5B0 RID: 181680 RVA: 0x00609624 File Offset: 0x00607824
		public IEnableFollowShooterAbility Data1AsIEnableFollowShooterAbility()
		{
			return this.Data1<IEnableFollowShooterAbility>().Value;
		}

		// Token: 0x0602C5B1 RID: 181681 RVA: 0x00609640 File Offset: 0x00607840
		public IFollowShooterLeisureInteract Data1AsIFollowShooterLeisureInteract()
		{
			return this.Data1<IFollowShooterLeisureInteract>().Value;
		}

		// Token: 0x0602C5B2 RID: 181682 RVA: 0x0060965C File Offset: 0x0060785C
		public IClientFollowShooterLeisureInteract Data1AsIClientFollowShooterLeisureInteract()
		{
			return this.Data1<IClientFollowShooterLeisureInteract>().Value;
		}

		// Token: 0x0602C5B3 RID: 181683 RVA: 0x00609678 File Offset: 0x00607878
		public ICustomJson Data1AsICustomJson()
		{
			return this.Data1<ICustomJson>().Value;
		}

		// Token: 0x0602C5B4 RID: 181684 RVA: 0x00609694 File Offset: 0x00607894
		public IExecResurrection Data1AsIExecResurrection()
		{
			return this.Data1<IExecResurrection>().Value;
		}

		// Token: 0x0602C5B5 RID: 181685 RVA: 0x006096B0 File Offset: 0x006078B0
		public IOpenSystemBoardWithReturn Data1AsIOpenSystemBoardWithReturn()
		{
			return this.Data1<IOpenSystemBoardWithReturn>().Value;
		}

		// Token: 0x0602C5B6 RID: 181686 RVA: 0x006096CC File Offset: 0x006078CC
		public IResumeSystemRewardPopup Data1AsIResumeSystemRewardPopup()
		{
			return this.Data1<IResumeSystemRewardPopup>().Value;
		}

		// Token: 0x0602C5B7 RID: 181687 RVA: 0x006096E8 File Offset: 0x006078E8
		public IExecRiskHarvestEffect Data1AsIExecRiskHarvestEffect()
		{
			return this.Data1<IExecRiskHarvestEffect>().Value;
		}

		// Token: 0x0602C5B8 RID: 181688 RVA: 0x00609704 File Offset: 0x00607904
		public ISetTeleControl Data1AsISetTeleControl()
		{
			return this.Data1<ISetTeleControl>().Value;
		}

		// Token: 0x0602C5B9 RID: 181689 RVA: 0x00609720 File Offset: 0x00607920
		public IMowingTowerGotoNextFloor Data1AsIMowingTowerGotoNextFloor()
		{
			return this.Data1<IMowingTowerGotoNextFloor>().Value;
		}

		// Token: 0x0602C5BA RID: 181690 RVA: 0x0060973C File Offset: 0x0060793C
		public ISlashAndTowerGotoNextFloor Data1AsISlashAndTowerGotoNextFloor()
		{
			return this.Data1<ISlashAndTowerGotoNextFloor>().Value;
		}

		// Token: 0x0602C5BB RID: 181691 RVA: 0x00609758 File Offset: 0x00607958
		public IRoleTowerGotoNextFloor Data1AsIRoleTowerGotoNextFloor()
		{
			return this.Data1<IRoleTowerGotoNextFloor>().Value;
		}

		// Token: 0x0602C5BC RID: 181692 RVA: 0x00609774 File Offset: 0x00607974
		public IVehicleEnter Data1AsIVehicleEnter()
		{
			return this.Data1<IVehicleEnter>().Value;
		}

		// Token: 0x0602C5BD RID: 181693 RVA: 0x00609790 File Offset: 0x00607990
		public IEnterNpcVehicle Data1AsIEnterNpcVehicle()
		{
			return this.Data1<IEnterNpcVehicle>().Value;
		}

		// Token: 0x0602C5BE RID: 181694 RVA: 0x006097AC File Offset: 0x006079AC
		public IVehicleExitPlayer Data1AsIVehicleExitPlayer()
		{
			return this.Data1<IVehicleExitPlayer>().Value;
		}

		// Token: 0x0602C5BF RID: 181695 RVA: 0x006097C8 File Offset: 0x006079C8
		public IVehicleExitNpc Data1AsIVehicleExitNpc()
		{
			return this.Data1<IVehicleExitNpc>().Value;
		}

		// Token: 0x0602C5C0 RID: 181696 RVA: 0x006097E4 File Offset: 0x006079E4
		public ITeleportVehicle Data1AsITeleportVehicle()
		{
			return this.Data1<ITeleportVehicle>().Value;
		}

		// Token: 0x0602C5C1 RID: 181697 RVA: 0x00609800 File Offset: 0x00607A00
		public IClientTeleportVehicle Data1AsIClientTeleportVehicle()
		{
			return this.Data1<IClientTeleportVehicle>().Value;
		}

		// Token: 0x0602C5C2 RID: 181698 RVA: 0x0060981C File Offset: 0x00607A1C
		public IVehiclePlayPassengerVoice Data1AsIVehiclePlayPassengerVoice()
		{
			return this.Data1<IVehiclePlayPassengerVoice>().Value;
		}

		// Token: 0x0602C5C3 RID: 181699 RVA: 0x00609838 File Offset: 0x00607A38
		public IVehicleWaterfallClimbing Data1AsIVehicleWaterfallClimbing()
		{
			return this.Data1<IVehicleWaterfallClimbing>().Value;
		}

		// Token: 0x0602C5C4 RID: 181700 RVA: 0x00609854 File Offset: 0x00607A54
		public ITeleportToAndEnterVehicle Data1AsITeleportToAndEnterVehicle()
		{
			return this.Data1<ITeleportToAndEnterVehicle>().Value;
		}

		// Token: 0x0602C5C5 RID: 181701 RVA: 0x00609870 File Offset: 0x00607A70
		public IVehicleMoveWithPathLine Data1AsIVehicleMoveWithPathLine()
		{
			return this.Data1<IVehicleMoveWithPathLine>().Value;
		}

		// Token: 0x0602C5C6 RID: 181702 RVA: 0x0060988C File Offset: 0x00607A8C
		public IVehicleSprint Data1AsIVehicleSprint()
		{
			return this.Data1<IVehicleSprint>().Value;
		}

		// Token: 0x0602C5C7 RID: 181703 RVA: 0x006098A8 File Offset: 0x00607AA8
		public IOpenQteAction Data1AsIOpenQteAction()
		{
			return this.Data1<IOpenQteAction>().Value;
		}

		// Token: 0x0602C5C8 RID: 181704 RVA: 0x006098C4 File Offset: 0x00607AC4
		public IPlayerInput Data1AsIPlayerInput()
		{
			return this.Data1<IPlayerInput>().Value;
		}

		// Token: 0x0602C5C9 RID: 181705 RVA: 0x006098E0 File Offset: 0x00607AE0
		public IPreloadAction Data1AsIPreloadAction()
		{
			return this.Data1<IPreloadAction>().Value;
		}

		// Token: 0x0602C5CA RID: 181706 RVA: 0x006098FC File Offset: 0x00607AFC
		public IRemovePreloadResourceAction Data1AsIRemovePreloadResourceAction()
		{
			return this.Data1<IRemovePreloadResourceAction>().Value;
		}

		// Token: 0x0602C5CB RID: 181707 RVA: 0x00609918 File Offset: 0x00607B18
		public IExecAlertSystemAction Data1AsIExecAlertSystemAction()
		{
			return this.Data1<IExecAlertSystemAction>().Value;
		}

		// Token: 0x0602C5CC RID: 181708 RVA: 0x00609934 File Offset: 0x00607B34
		public ISetSpineAnimation Data1AsISetSpineAnimation()
		{
			return this.Data1<ISetSpineAnimation>().Value;
		}

		// Token: 0x0602C5CD RID: 181709 RVA: 0x00609950 File Offset: 0x00607B50
		public IChangeEntityCamp Data1AsIChangeEntityCamp()
		{
			return this.Data1<IChangeEntityCamp>().Value;
		}

		// Token: 0x0602C5CE RID: 181710 RVA: 0x0060996C File Offset: 0x00607B6C
		public IRecordDungeonEvent Data1AsIRecordDungeonEvent()
		{
			return this.Data1<IRecordDungeonEvent>().Value;
		}

		// Token: 0x0602C5CF RID: 181711 RVA: 0x00609988 File Offset: 0x00607B88
		public IDangoAbyssGotoNextFloor Data1AsIDangoAbyssGotoNextFloor()
		{
			return this.Data1<IDangoAbyssGotoNextFloor>().Value;
		}

		// Token: 0x0602C5D0 RID: 181712 RVA: 0x006099A4 File Offset: 0x00607BA4
		public IDangoAbyssCreateRewardTreasureBox Data1AsIDangoAbyssCreateRewardTreasureBox()
		{
			return this.Data1<IDangoAbyssCreateRewardTreasureBox>().Value;
		}

		// Token: 0x0602C5D1 RID: 181713 RVA: 0x006099C0 File Offset: 0x00607BC0
		public IDangoAbyssActivatePortal Data1AsIDangoAbyssActivatePortal()
		{
			return this.Data1<IDangoAbyssActivatePortal>().Value;
		}

		// Token: 0x0602C5D2 RID: 181714 RVA: 0x006099DC File Offset: 0x00607BDC
		public IDangoAbyssReceiveReward Data1AsIDangoAbyssReceiveReward()
		{
			return this.Data1<IDangoAbyssReceiveReward>().Value;
		}

		// Token: 0x0602C5D3 RID: 181715 RVA: 0x006099F8 File Offset: 0x00607BF8
		public IRoverRogueActivate Data1AsIRoverRogueActivate()
		{
			return this.Data1<IRoverRogueActivate>().Value;
		}

		// Token: 0x0602C5D4 RID: 181716 RVA: 0x00609A14 File Offset: 0x00607C14
		public IRoverRogueRoomFinish Data1AsIRoverRogueRoomFinish()
		{
			return this.Data1<IRoverRogueRoomFinish>().Value;
		}

		// Token: 0x0602C5D5 RID: 181717 RVA: 0x00609A30 File Offset: 0x00607C30
		public IRoverRogueCreateRoomReward Data1AsIRoverRogueCreateRoomReward()
		{
			return this.Data1<IRoverRogueCreateRoomReward>().Value;
		}

		// Token: 0x0602C5D6 RID: 181718 RVA: 0x00609A4C File Offset: 0x00607C4C
		public IGuestOperateUiAnimation Data1AsIGuestOperateUiAnimation()
		{
			return this.Data1<IGuestOperateUiAnimation>().Value;
		}

		// Token: 0x0602C5D7 RID: 181719 RVA: 0x00609A68 File Offset: 0x00607C68
		public ISlideRailStart Data1AsISlideRailStart()
		{
			return this.Data1<ISlideRailStart>().Value;
		}

		// Token: 0x0602C5D8 RID: 181720 RVA: 0x00609A84 File Offset: 0x00607C84
		public ISlideRailEnd Data1AsISlideRailEnd()
		{
			return this.Data1<ISlideRailEnd>().Value;
		}

		// Token: 0x0602C5D9 RID: 181721 RVA: 0x00609AA0 File Offset: 0x00607CA0
		public ISlidePerformStart Data1AsISlidePerformStart()
		{
			return this.Data1<ISlidePerformStart>().Value;
		}

		// Token: 0x0602C5DA RID: 181722 RVA: 0x00609ABC File Offset: 0x00607CBC
		public IBvbSendSystemEvent Data1AsIBvbSendSystemEvent()
		{
			return this.Data1<IBvbSendSystemEvent>().Value;
		}

		// Token: 0x0602C5DB RID: 181723 RVA: 0x00609AD8 File Offset: 0x00607CD8
		public IBvbSendAiEvent Data1AsIBvbSendAiEvent()
		{
			return this.Data1<IBvbSendAiEvent>().Value;
		}

		// Token: 0x0602C5DC RID: 181724 RVA: 0x00609AF4 File Offset: 0x00607CF4
		public IBvbPlayDialog Data1AsIBvbPlayDialog()
		{
			return this.Data1<IBvbPlayDialog>().Value;
		}

		// Token: 0x0602C5DD RID: 181725 RVA: 0x00609B10 File Offset: 0x00607D10
		public IBvbPlayerOperationConstraint Data1AsIBvbPlayerOperationConstraint()
		{
			return this.Data1<IBvbPlayerOperationConstraint>().Value;
		}

		// Token: 0x0602C5DE RID: 181726 RVA: 0x00609B2C File Offset: 0x00607D2C
		public IBvbSkipChallenge Data1AsIBvbSkipChallenge()
		{
			return this.Data1<IBvbSkipChallenge>().Value;
		}

		// Token: 0x0602C5DF RID: 181727 RVA: 0x00609B48 File Offset: 0x00607D48
		public IActiveAntiGravitySafePoint Data1AsIActiveAntiGravitySafePoint()
		{
			return this.Data1<IActiveAntiGravitySafePoint>().Value;
		}

		// Token: 0x0602C5E0 RID: 181728 RVA: 0x00609B64 File Offset: 0x00607D64
		public ISummonEntity Data1AsISummonEntity()
		{
			return this.Data1<ISummonEntity>().Value;
		}

		// Token: 0x0602C5E1 RID: 181729 RVA: 0x00609B80 File Offset: 0x00607D80
		public IDestroySummonedEntities Data1AsIDestroySummonedEntities()
		{
			return this.Data1<IDestroySummonedEntities>().Value;
		}

		// Token: 0x0602C5E2 RID: 181730 RVA: 0x00609B9C File Offset: 0x00607D9C
		public ISetupMoraleSystem Data1AsISetupMoraleSystem()
		{
			return this.Data1<ISetupMoraleSystem>().Value;
		}

		// Token: 0x0602C5E3 RID: 181731 RVA: 0x00609BB8 File Offset: 0x00607DB8
		public IGiantToggleModel Data1AsIGiantToggleModel()
		{
			return this.Data1<IGiantToggleModel>().Value;
		}

		// Token: 0x0602C5E4 RID: 181732 RVA: 0x00609BD4 File Offset: 0x00607DD4
		public IGiantTriggerResponse Data1AsIGiantTriggerResponse()
		{
			return this.Data1<IGiantTriggerResponse>().Value;
		}

		// Token: 0x0602C5E5 RID: 181733 RVA: 0x00609BF0 File Offset: 0x00607DF0
		public IActivateGiantTotalProgressNode Data1AsIActivateGiantTotalProgressNode()
		{
			return this.Data1<IActivateGiantTotalProgressNode>().Value;
		}

		// Token: 0x0602C5E6 RID: 181734 RVA: 0x00609C0C File Offset: 0x00607E0C
		public IRunActorCustomEvent Data1AsIRunActorCustomEvent()
		{
			return this.Data1<IRunActorCustomEvent>().Value;
		}

		// Token: 0x0602C5E7 RID: 181735 RVA: 0x00609C28 File Offset: 0x00607E28
		public ITriggerSpecificScanEffect Data1AsITriggerSpecificScanEffect()
		{
			return this.Data1<ITriggerSpecificScanEffect>().Value;
		}

		// Token: 0x0602C5E8 RID: 181736 RVA: 0x00609C44 File Offset: 0x00607E44
		public ISendClientEvent Data1AsISendClientEvent()
		{
			return this.Data1<ISendClientEvent>().Value;
		}

		// Token: 0x0602C5E9 RID: 181737 RVA: 0x00609C60 File Offset: 0x00607E60
		public IScanEnrichmentArea Data1AsIScanEnrichmentArea()
		{
			return this.Data1<IScanEnrichmentArea>().Value;
		}

		// Token: 0x0602C5EA RID: 181738 RVA: 0x00609C7C File Offset: 0x00607E7C
		public IRequestSystemFunction Data1AsIRequestSystemFunction()
		{
			return this.Data1<IRequestSystemFunction>().Value;
		}

		// Token: 0x0602C5EB RID: 181739 RVA: 0x00609C98 File Offset: 0x00607E98
		public IReignsSetPropertyVisible Data1AsIReignsSetPropertyVisible()
		{
			return this.Data1<IReignsSetPropertyVisible>().Value;
		}

		// Token: 0x0602C5EC RID: 181740 RVA: 0x00609CB4 File Offset: 0x00607EB4
		public IReignsChangeBackground Data1AsIReignsChangeBackground()
		{
			return this.Data1<IReignsChangeBackground>().Value;
		}

		// Token: 0x0602C5ED RID: 181741 RVA: 0x00609CD0 File Offset: 0x00607ED0
		public IReignsSetUiEffect Data1AsIReignsSetUiEffect()
		{
			return this.Data1<IReignsSetUiEffect>().Value;
		}

		// Token: 0x0602C5EE RID: 181742 RVA: 0x00609CEC File Offset: 0x00607EEC
		public IReignsChangePlayerName Data1AsIReignsChangePlayerName()
		{
			return this.Data1<IReignsChangePlayerName>().Value;
		}

		// Token: 0x0602C5EF RID: 181743 RVA: 0x00609D08 File Offset: 0x00607F08
		public IReignsCallCard Data1AsIReignsCallCard()
		{
			return this.Data1<IReignsCallCard>().Value;
		}

		// Token: 0x0602C5F0 RID: 181744 RVA: 0x00609D24 File Offset: 0x00607F24
		public IReignsTriggerGuide Data1AsIReignsTriggerGuide()
		{
			return this.Data1<IReignsTriggerGuide>().Value;
		}

		// Token: 0x0602C5F1 RID: 181745 RVA: 0x00609D40 File Offset: 0x00607F40
		public IReignsAddBuff Data1AsIReignsAddBuff()
		{
			return this.Data1<IReignsAddBuff>().Value;
		}

		// Token: 0x0602C5F2 RID: 181746 RVA: 0x00609D5C File Offset: 0x00607F5C
		public IReignsCheckSettle Data1AsIReignsCheckSettle()
		{
			return this.Data1<IReignsCheckSettle>().Value;
		}

		// Token: 0x0602C5F3 RID: 181747 RVA: 0x00609D78 File Offset: 0x00607F78
		public ISetNpcGroupPerform Data1AsISetNpcGroupPerform()
		{
			return this.Data1<ISetNpcGroupPerform>().Value;
		}

		// Token: 0x0602C5F4 RID: 181748 RVA: 0x00609D94 File Offset: 0x00607F94
		public IRemoveNpcGroupPerform Data1AsIRemoveNpcGroupPerform()
		{
			return this.Data1<IRemoveNpcGroupPerform>().Value;
		}

		// Token: 0x0602C5F5 RID: 181749 RVA: 0x00609DB0 File Offset: 0x00607FB0
		public IEnableEntityLookAt Data1AsIEnableEntityLookAt()
		{
			return this.Data1<IEnableEntityLookAt>().Value;
		}

		// Token: 0x0602C5F6 RID: 181750 RVA: 0x00609DCC File Offset: 0x00607FCC
		public IDisableEntityLookAt Data1AsIDisableEntityLookAt()
		{
			return this.Data1<IDisableEntityLookAt>().Value;
		}

		// Token: 0x0602C5F7 RID: 181751 RVA: 0x00609DE8 File Offset: 0x00607FE8
		public IOverrideAiBehaviorTree Data1AsIOverrideAiBehaviorTree()
		{
			return this.Data1<IOverrideAiBehaviorTree>().Value;
		}

		// Token: 0x0602C5F8 RID: 181752 RVA: 0x00609E04 File Offset: 0x00608004
		public IRestoreAiBehaviorTree Data1AsIRestoreAiBehaviorTree()
		{
			return this.Data1<IRestoreAiBehaviorTree>().Value;
		}

		// Token: 0x0602C5F9 RID: 181753 RVA: 0x00609E20 File Offset: 0x00608020
		public IFlowDefineNpcGroupPerform Data1AsIFlowDefineNpcGroupPerform()
		{
			return this.Data1<IFlowDefineNpcGroupPerform>().Value;
		}

		// Token: 0x0602C5FA RID: 181754 RVA: 0x00609E3C File Offset: 0x0060803C
		public ISeqEventAddTagToSelf Data1AsISeqEventAddTagToSelf()
		{
			return this.Data1<ISeqEventAddTagToSelf>().Value;
		}

		// Token: 0x0602C5FB RID: 181755 RVA: 0x00609E58 File Offset: 0x00608058
		public ISeqEventFireBullet Data1AsISeqEventFireBullet()
		{
			return this.Data1<ISeqEventFireBullet>().Value;
		}

		// Token: 0x0602C5FC RID: 181756 RVA: 0x00609E74 File Offset: 0x00608074
		public ITrapDefenseChangeMiniMap Data1AsITrapDefenseChangeMiniMap()
		{
			return this.Data1<ITrapDefenseChangeMiniMap>().Value;
		}

		// Token: 0x0602C5FD RID: 181757 RVA: 0x00609E90 File Offset: 0x00608090
		public ITrapDefensePlayerOperationConstraint Data1AsITrapDefensePlayerOperationConstraint()
		{
			return this.Data1<ITrapDefensePlayerOperationConstraint>().Value;
		}

		// Token: 0x0602C5FE RID: 181758 RVA: 0x00609EAC File Offset: 0x006080AC
		public IHonamiStoryInteractPickUp Data1AsIHonamiStoryInteractPickUp()
		{
			return this.Data1<IHonamiStoryInteractPickUp>().Value;
		}

		// Token: 0x0602C5FF RID: 181759 RVA: 0x00609EC8 File Offset: 0x006080C8
		public IHonamiStoryReceiveCorruptedChestReward Data1AsIHonamiStoryReceiveCorruptedChestReward()
		{
			return this.Data1<IHonamiStoryReceiveCorruptedChestReward>().Value;
		}

		// Token: 0x0602C600 RID: 181760 RVA: 0x00609EE4 File Offset: 0x006080E4
		public IHonamiStoryActivateSafeEvacuation Data1AsIHonamiStoryActivateSafeEvacuation()
		{
			return this.Data1<IHonamiStoryActivateSafeEvacuation>().Value;
		}

		// Token: 0x0602C601 RID: 181761 RVA: 0x00609F00 File Offset: 0x00608100
		public IHonamiStorySetFormation Data1AsIHonamiStorySetFormation()
		{
			return this.Data1<IHonamiStorySetFormation>().Value;
		}

		// Token: 0x0602C602 RID: 181762 RVA: 0x00609F1C File Offset: 0x0060811C
		public IHonamiStoryGetItem Data1AsIHonamiStoryGetItem()
		{
			return this.Data1<IHonamiStoryGetItem>().Value;
		}

		// Token: 0x0602C603 RID: 181763 RVA: 0x00609F38 File Offset: 0x00608138
		public IInfrActivityUpgradeInfrastructure Data1AsIInfrActivityUpgradeInfrastructure()
		{
			return this.Data1<IInfrActivityUpgradeInfrastructure>().Value;
		}

		// Token: 0x0602C604 RID: 181764 RVA: 0x00609F54 File Offset: 0x00608154
		public IPlayWalkingOverlayMontage Data1AsIPlayWalkingOverlayMontage()
		{
			return this.Data1<IPlayWalkingOverlayMontage>().Value;
		}

		// Token: 0x0602C605 RID: 181765 RVA: 0x00609F70 File Offset: 0x00608170
		public IEnableKey4Func Data1AsIEnableKey4Func()
		{
			return this.Data1<IEnableKey4Func>().Value;
		}

		// Token: 0x0602C606 RID: 181766 RVA: 0x00609F8C File Offset: 0x0060818C
		public IChangeNpcAbpState Data1AsIChangeNpcAbpState()
		{
			return this.Data1<IChangeNpcAbpState>().Value;
		}

		// Token: 0x0602C607 RID: 181767 RVA: 0x00609FA8 File Offset: 0x006081A8
		public IOverrideAbpAnimScheme Data1AsIOverrideAbpAnimScheme()
		{
			return this.Data1<IOverrideAbpAnimScheme>().Value;
		}

		// Token: 0x0602C608 RID: 181768 RVA: 0x00609FC4 File Offset: 0x006081C4
		public ICloseWalkingOverlayMontage Data1AsICloseWalkingOverlayMontage()
		{
			return this.Data1<ICloseWalkingOverlayMontage>().Value;
		}

		// Token: 0x0602C609 RID: 181769 RVA: 0x00609FE0 File Offset: 0x006081E0
		public ISetMotorSpeed Data1AsISetMotorSpeed()
		{
			return this.Data1<ISetMotorSpeed>().Value;
		}

		// Token: 0x0602C60A RID: 181770 RVA: 0x00609FFC File Offset: 0x006081FC
		public IVehicleSetSpeedImmediately Data1AsIVehicleSetSpeedImmediately()
		{
			return this.Data1<IVehicleSetSpeedImmediately>().Value;
		}

		// Token: 0x0602C60B RID: 181771 RVA: 0x0060A018 File Offset: 0x00608218
		public IStartMotorCruise Data1AsIStartMotorCruise()
		{
			return this.Data1<IStartMotorCruise>().Value;
		}

		// Token: 0x0602C60C RID: 181772 RVA: 0x0060A034 File Offset: 0x00608234
		public IStopMotorCruise Data1AsIStopMotorCruise()
		{
			return this.Data1<IStopMotorCruise>().Value;
		}

		// Token: 0x0602C60D RID: 181773 RVA: 0x0060A050 File Offset: 0x00608250
		public IDriveMotorInSpecConfig Data1AsIDriveMotorInSpecConfig()
		{
			return this.Data1<IDriveMotorInSpecConfig>().Value;
		}

		// Token: 0x0602C60E RID: 181774 RVA: 0x0060A06C File Offset: 0x0060826C
		public IMotorSoarInWindField Data1AsIMotorSoarInWindField()
		{
			return this.Data1<IMotorSoarInWindField>().Value;
		}

		// Token: 0x0602C60F RID: 181775 RVA: 0x0060A088 File Offset: 0x00608288
		public ISetSkillBtnEffect Data1AsISetSkillBtnEffect()
		{
			return this.Data1<ISetSkillBtnEffect>().Value;
		}

		// Token: 0x0602C610 RID: 181776 RVA: 0x0060A0A4 File Offset: 0x006082A4
		public ICollectSunSpirit Data1AsICollectSunSpirit()
		{
			return this.Data1<ICollectSunSpirit>().Value;
		}

		// Token: 0x0602C611 RID: 181777 RVA: 0x0060A0C0 File Offset: 0x006082C0
		public IPerformSunSpiritGearRoundTrip Data1AsIPerformSunSpiritGearRoundTrip()
		{
			return this.Data1<IPerformSunSpiritGearRoundTrip>().Value;
		}

		// Token: 0x0602C612 RID: 181778 RVA: 0x0060A0DC File Offset: 0x006082DC
		public ITriggerDeadeyeMode Data1AsITriggerDeadeyeMode()
		{
			return this.Data1<ITriggerDeadeyeMode>().Value;
		}

		// Token: 0x0602C613 RID: 181779 RVA: 0x0060A0F8 File Offset: 0x006082F8
		public ITriggerSystemRandomPlot Data1AsITriggerSystemRandomPlot()
		{
			return this.Data1<ITriggerSystemRandomPlot>().Value;
		}

		// Token: 0x0602C614 RID: 181780 RVA: 0x0060A114 File Offset: 0x00608314
		public ISetAudioEnable Data1AsISetAudioEnable()
		{
			return this.Data1<ISetAudioEnable>().Value;
		}

		// Token: 0x0602C615 RID: 181781 RVA: 0x0060A130 File Offset: 0x00608330
		public IPhoneSystemInteract Data1AsIPhoneSystemInteract()
		{
			return this.Data1<IPhoneSystemInteract>().Value;
		}

		// Token: 0x0602C616 RID: 181782 RVA: 0x0060A14C File Offset: 0x0060834C
		public IRollBlockGetReward Data1AsIRollBlockGetReward()
		{
			return this.Data1<IRollBlockGetReward>().Value;
		}

		// Token: 0x0602C617 RID: 181783 RVA: 0x0060A168 File Offset: 0x00608368
		public IEnterMovieMode Data1AsIEnterMovieMode()
		{
			return this.Data1<IEnterMovieMode>().Value;
		}

		// Token: 0x0602C618 RID: 181784 RVA: 0x0060A184 File Offset: 0x00608384
		public IExitMovieMode Data1AsIExitMovieMode()
		{
			return this.Data1<IExitMovieMode>().Value;
		}

		// Token: 0x0602C619 RID: 181785 RVA: 0x0060A1A0 File Offset: 0x006083A0
		public IStartRoadNetworkNavigation Data1AsIStartRoadNetworkNavigation()
		{
			return this.Data1<IStartRoadNetworkNavigation>().Value;
		}

		// Token: 0x0602C61A RID: 181786 RVA: 0x0060A1BC File Offset: 0x006083BC
		public ISetWayOccupancyState Data1AsISetWayOccupancyState()
		{
			return this.Data1<ISetWayOccupancyState>().Value;
		}

		// Token: 0x0602C61B RID: 181787 RVA: 0x0060A1D8 File Offset: 0x006083D8
		public IEnterPatrolState Data1AsIEnterPatrolState()
		{
			return this.Data1<IEnterPatrolState>().Value;
		}

		// Token: 0x0602C61C RID: 181788 RVA: 0x0060A1F4 File Offset: 0x006083F4
		public IPerformAiHideSelf Data1AsIPerformAiHideSelf()
		{
			return this.Data1<IPerformAiHideSelf>().Value;
		}

		// Token: 0x0602C61D RID: 181789 RVA: 0x0060A210 File Offset: 0x00608410
		public ISendSceneActorEvent Data1AsISendSceneActorEvent()
		{
			return this.Data1<ISendSceneActorEvent>().Value;
		}

		// Token: 0x0602C61E RID: 181790 RVA: 0x0060A22C File Offset: 0x0060842C
		public IExecBpActorFunc Data1AsIExecBpActorFunc()
		{
			return this.Data1<IExecBpActorFunc>().Value;
		}

		// Token: 0x0602C61F RID: 181791 RVA: 0x0060A248 File Offset: 0x00608448
		public IResetPlayerPosWithPresentation Data1AsIResetPlayerPosWithPresentation()
		{
			return this.Data1<IResetPlayerPosWithPresentation>().Value;
		}

		// Token: 0x0602C620 RID: 181792 RVA: 0x0060A264 File Offset: 0x00608464
		public IDrinksRollRoleRequirement Data1AsIDrinksRollRoleRequirement()
		{
			return this.Data1<IDrinksRollRoleRequirement>().Value;
		}

		// Token: 0x0602C621 RID: 181793 RVA: 0x0060A280 File Offset: 0x00608480
		public ISetBlendAnim Data1AsISetBlendAnim()
		{
			return this.Data1<ISetBlendAnim>().Value;
		}

		// Token: 0x0602C622 RID: 181794 RVA: 0x0060A29C File Offset: 0x0060849C
		public IReportTrackingEvent Data1AsIReportTrackingEvent()
		{
			return this.Data1<IReportTrackingEvent>().Value;
		}

		// Token: 0x0602C623 RID: 181795 RVA: 0x0060A2B8 File Offset: 0x006084B8
		public ITetrisThrowBlock Data1AsITetrisThrowBlock()
		{
			return this.Data1<ITetrisThrowBlock>().Value;
		}

		// Token: 0x0602C624 RID: 181796 RVA: 0x0060A2D4 File Offset: 0x006084D4
		public ITetrisGameComplete Data1AsITetrisGameComplete()
		{
			return this.Data1<ITetrisGameComplete>().Value;
		}

		// Token: 0x0602C625 RID: 181797 RVA: 0x0060A2F0 File Offset: 0x006084F0
		public ITetrisTriggerDelayFall Data1AsITetrisTriggerDelayFall()
		{
			return this.Data1<ITetrisTriggerDelayFall>().Value;
		}

		// Token: 0x0602C626 RID: 181798 RVA: 0x0060A30C File Offset: 0x0060850C
		public IBossPilingRandomBuff Data1AsIBossPilingRandomBuff()
		{
			return this.Data1<IBossPilingRandomBuff>().Value;
		}

		// Token: 0x0602C627 RID: 181799 RVA: 0x0060A328 File Offset: 0x00608528
		public IBossPilingEnterNextInst Data1AsIBossPilingEnterNextInst()
		{
			return this.Data1<IBossPilingEnterNextInst>().Value;
		}

		// Token: 0x0602C628 RID: 181800 RVA: 0x0060A344 File Offset: 0x00608544
		public IOpenQuickHackSystem Data1AsIOpenQuickHackSystem()
		{
			return this.Data1<IOpenQuickHackSystem>().Value;
		}

		// Token: 0x0602C629 RID: 181801 RVA: 0x0060A360 File Offset: 0x00608560
		public IDollGrabItemDelivery Data1AsIDollGrabItemDelivery()
		{
			return this.Data1<IDollGrabItemDelivery>().Value;
		}

		// Token: 0x0602C62A RID: 181802 RVA: 0x0060A37C File Offset: 0x0060857C
		public ISheriffUnlockClue Data1AsISheriffUnlockClue()
		{
			return this.Data1<ISheriffUnlockClue>().Value;
		}

		// Token: 0x0602C62B RID: 181803 RVA: 0x0060A398 File Offset: 0x00608598
		public ISheriffUnlockProgress Data1AsISheriffUnlockProgress()
		{
			return this.Data1<ISheriffUnlockProgress>().Value;
		}

		// Token: 0x0602C62C RID: 181804 RVA: 0x0060A3B4 File Offset: 0x006085B4
		public ISheriffChangeCriminalState Data1AsISheriffChangeCriminalState()
		{
			return this.Data1<ISheriffChangeCriminalState>().Value;
		}

		// Token: 0x0602C62D RID: 181805 RVA: 0x0060A3D0 File Offset: 0x006085D0
		public ISheriffChangeCriminalIdentity Data1AsISheriffChangeCriminalIdentity()
		{
			return this.Data1<ISheriffChangeCriminalIdentity>().Value;
		}

		// Token: 0x0602C62E RID: 181806 RVA: 0x0060A3EC File Offset: 0x006085EC
		public ISheriffUnlockEnding Data1AsISheriffUnlockEnding()
		{
			return this.Data1<ISheriffUnlockEnding>().Value;
		}

		// Token: 0x0602C62F RID: 181807 RVA: 0x0060A408 File Offset: 0x00608608
		public ISetTargetElementalAbility Data1AsISetTargetElementalAbility()
		{
			return this.Data1<ISetTargetElementalAbility>().Value;
		}

		// Token: 0x0602C630 RID: 181808 RVA: 0x0060A424 File Offset: 0x00608624
		public IToggleEntityElementalAbility Data1AsIToggleEntityElementalAbility()
		{
			return this.Data1<IToggleEntityElementalAbility>().Value;
		}

		// Token: 0x0602C631 RID: 181809 RVA: 0x0060A440 File Offset: 0x00608640
		public ICaptureElementalBox Data1AsICaptureElementalBox()
		{
			return this.Data1<ICaptureElementalBox>().Value;
		}

		// Token: 0x0602C632 RID: 181810 RVA: 0x0060A45C File Offset: 0x0060865C
		public IChangeElementalBoxState Data1AsIChangeElementalBoxState()
		{
			return this.Data1<IChangeElementalBoxState>().Value;
		}

		// Token: 0x0602C633 RID: 181811 RVA: 0x0060A478 File Offset: 0x00608678
		public ISetElementalBoxToTarget Data1AsISetElementalBoxToTarget()
		{
			return this.Data1<ISetElementalBoxToTarget>().Value;
		}

		// Token: 0x0602C634 RID: 181812 RVA: 0x0060A494 File Offset: 0x00608694
		public ISeasonWeatherSetRotationLock Data1AsISeasonWeatherSetRotationLock()
		{
			return this.Data1<ISeasonWeatherSetRotationLock>().Value;
		}

		// Token: 0x0602C635 RID: 181813 RVA: 0x0060A4B0 File Offset: 0x006086B0
		public ISeasonWeatherChangeTo Data1AsISeasonWeatherChangeTo()
		{
			return this.Data1<ISeasonWeatherChangeTo>().Value;
		}

		// Token: 0x0602C636 RID: 181814 RVA: 0x0060A4CC File Offset: 0x006086CC
		public ISeasonWeatherUnlockSpecial Data1AsISeasonWeatherUnlockSpecial()
		{
			return this.Data1<ISeasonWeatherUnlockSpecial>().Value;
		}

		// Token: 0x0602C637 RID: 181815 RVA: 0x0060A4E8 File Offset: 0x006086E8
		public IHandBookModifySystemProgress Data1AsIHandBookModifySystemProgress()
		{
			return this.Data1<IHandBookModifySystemProgress>().Value;
		}

		// Token: 0x0602C638 RID: 181816 RVA: 0x0060A504 File Offset: 0x00608704
		public IClientExecEntityPrefabAction Data1AsIClientExecEntityPrefabAction()
		{
			return this.Data1<IClientExecEntityPrefabAction>().Value;
		}

		// Token: 0x0602C639 RID: 181817 RVA: 0x0060A520 File Offset: 0x00608720
		public ILiveSetUi Data1AsILiveSetUi()
		{
			return this.Data1<ILiveSetUi>().Value;
		}

		// Token: 0x0602C63A RID: 181818 RVA: 0x0060A53C File Offset: 0x0060873C
		public ILiveSetDanmaku Data1AsILiveSetDanmaku()
		{
			return this.Data1<ILiveSetDanmaku>().Value;
		}

		// Token: 0x0602C63B RID: 181819 RVA: 0x0060A558 File Offset: 0x00608758
		public ILiveSetParam Data1AsILiveSetParam()
		{
			return this.Data1<ILiveSetParam>().Value;
		}

		// Token: 0x0602C63C RID: 181820 RVA: 0x0060A574 File Offset: 0x00608774
		public ILiveSetSc Data1AsILiveSetSc()
		{
			return this.Data1<ILiveSetSc>().Value;
		}

		// Token: 0x0602C63D RID: 181821 RVA: 0x0060A58F File Offset: 0x0060878F
		public static Offset<IActionParams_Union> CreateIActionParams_Union(FlatBufferBuilder builder, byte union_index = 0, IActionParams_Union_0 data_0_type = IActionParams_Union_0.NONE, int data_0Offset = 0, IActionParams_Union_1 data_1_type = IActionParams_Union_1.NONE, int data_1Offset = 0)
		{
			builder.StartTable(5);
			IActionParams_Union.AddData1(builder, data_1Offset);
			IActionParams_Union.AddData0(builder, data_0Offset);
			IActionParams_Union.AddData1Type(builder, data_1_type);
			IActionParams_Union.AddData0Type(builder, data_0_type);
			IActionParams_Union.AddUnionIndex(builder, union_index);
			return IActionParams_Union.EndIActionParams_Union(builder);
		}

		// Token: 0x0602C63E RID: 181822 RVA: 0x0060A5C3 File Offset: 0x006087C3
		public static void StartIActionParams_Union(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602C63F RID: 181823 RVA: 0x0060A5CC File Offset: 0x006087CC
		public static void AddUnionIndex(FlatBufferBuilder builder, byte unionIndex)
		{
			builder.AddByte(0, unionIndex, 0);
		}

		// Token: 0x0602C640 RID: 181824 RVA: 0x0060A5D7 File Offset: 0x006087D7
		public static void AddData0Type(FlatBufferBuilder builder, IActionParams_Union_0 data0Type)
		{
			builder.AddByte(1, (byte)data0Type, 0);
		}

		// Token: 0x0602C641 RID: 181825 RVA: 0x0060A5E2 File Offset: 0x006087E2
		public static void AddData0(FlatBufferBuilder builder, int data0Offset)
		{
			builder.AddOffset(2, data0Offset, 0);
		}

		// Token: 0x0602C642 RID: 181826 RVA: 0x0060A5ED File Offset: 0x006087ED
		public static void AddData1Type(FlatBufferBuilder builder, IActionParams_Union_1 data1Type)
		{
			builder.AddByte(3, (byte)data1Type, 0);
		}

		// Token: 0x0602C643 RID: 181827 RVA: 0x0060A5F8 File Offset: 0x006087F8
		public static void AddData1(FlatBufferBuilder builder, int data1Offset)
		{
			builder.AddOffset(4, data1Offset, 0);
		}

		// Token: 0x0602C644 RID: 181828 RVA: 0x0060A603 File Offset: 0x00608803
		public static Offset<IActionParams_Union> EndIActionParams_Union(FlatBufferBuilder builder)
		{
			return new Offset<IActionParams_Union>(builder.EndTable());
		}

		// Token: 0x0602C645 RID: 181829 RVA: 0x0060A610 File Offset: 0x00608810
		public IActionParams_UnionT UnPack()
		{
			IActionParams_UnionT actionParams_UnionT = new IActionParams_UnionT();
			this.UnPackTo(actionParams_UnionT);
			return actionParams_UnionT;
		}

		// Token: 0x0602C646 RID: 181830 RVA: 0x0060A62C File Offset: 0x0060882C
		public void UnPackTo(IActionParams_UnionT _o)
		{
			_o.UnionIndex = this.UnionIndex;
			_o.Data0 = new IActionParams_Union_0Union();
			_o.Data0.Type = this.Data0Type;
			switch (this.Data0Type)
			{
			case IActionParams_Union_0.IActionParams:
				_o.Data0.Value = ((this.Data0<IActionParams>() != null) ? this.Data0<IActionParams>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IInvoke:
				_o.Data0.Value = ((this.Data0<IInvoke>() != null) ? this.Data0<IInvoke>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IInteract:
				_o.Data0.Value = ((this.Data0<IInteract>() != null) ? this.Data0<IInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFinishCondition:
				_o.Data0.Value = ((this.Data0<IFinishCondition>() != null) ? this.Data0<IFinishCondition>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IGetRewardByInteract:
				_o.Data0.Value = ((this.Data0<IGetRewardByInteract>() != null) ? this.Data0<IGetRewardByInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IWaitUntilLevelSequenceReachMark:
				_o.Data0.Value = ((this.Data0<IWaitUntilLevelSequenceReachMark>() != null) ? this.Data0<IWaitUntilLevelSequenceReachMark>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClearEntityVisibleTag:
				_o.Data0.Value = ((this.Data0<IClearEntityVisibleTag>() != null) ? this.Data0<IClearEntityVisibleTag>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetEntityPos:
				_o.Data0.Value = ((this.Data0<ISetEntityPos>() != null) ? this.Data0<ISetEntityPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IResetEntityPos:
				_o.Data0.Value = ((this.Data0<IResetEntityPos>() != null) ? this.Data0<IResetEntityPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IServerSetPlayerPos:
				_o.Data0.Value = ((this.Data0<IServerSetPlayerPos>() != null) ? this.Data0<IServerSetPlayerPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFixTeleControllerPos:
				_o.Data0.Value = ((this.Data0<IFixTeleControllerPos>() != null) ? this.Data0<IFixTeleControllerPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFixTeleControllerResetPos:
				_o.Data0.Value = ((this.Data0<IFixTeleControllerResetPos>() != null) ? this.Data0<IFixTeleControllerResetPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFixFoundationRelation:
				_o.Data0.Value = ((this.Data0<IFixFoundationRelation>() != null) ? this.Data0<IFixFoundationRelation>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITraceCurrentQuest:
				_o.Data0.Value = ((this.Data0<ITraceCurrentQuest>() != null) ? this.Data0<ITraceCurrentQuest>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFixShowTargetRange:
				_o.Data0.Value = ((this.Data0<IFixShowTargetRange>() != null) ? this.Data0<IFixShowTargetRange>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFixGetItem:
				_o.Data0.Value = ((this.Data0<IFixGetItem>() != null) ? this.Data0<IFixGetItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ILog:
				_o.Data0.Value = ((this.Data0<ILog>() != null) ? this.Data0<ILog>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowMessage:
				_o.Data0.Value = ((this.Data0<IShowMessage>() != null) ? this.Data0<IShowMessage>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPrompt:
				_o.Data0.Value = ((this.Data0<IPrompt>() != null) ? this.Data0<IPrompt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISendNpcMail:
				_o.Data0.Value = ((this.Data0<ISendNpcMail>() != null) ? this.Data0<ISendNpcMail>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAdjustTodTime:
				_o.Data0.Value = ((this.Data0<IAdjustTodTime>() != null) ? this.Data0<IAdjustTodTime>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetAreaTimeState:
				_o.Data0.Value = ((this.Data0<ISetAreaTimeState>() != null) ? this.Data0<ISetAreaTimeState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetTimeScale:
				_o.Data0.Value = ((this.Data0<ISetTimeScale>() != null) ? this.Data0<ISetTimeScale>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IJumpTalk:
				_o.Data0.Value = ((this.Data0<IJumpTalk>() != null) ? this.Data0<IJumpTalk>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetHeadIconVisible:
				_o.Data0.Value = ((this.Data0<ISetHeadIconVisible>() != null) ? this.Data0<ISetHeadIconVisible>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayMontage:
				_o.Data0.Value = ((this.Data0<IPlayMontage>() != null) ? this.Data0<IPlayMontage>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAvgPlayRoleAction:
				_o.Data0.Value = ((this.Data0<IAvgPlayRoleAction>() != null) ? this.Data0<IAvgPlayRoleAction>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAvgMoveRole:
				_o.Data0.Value = ((this.Data0<IAvgMoveRole>() != null) ? this.Data0<IAvgMoveRole>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAvgFocusRole:
				_o.Data0.Value = ((this.Data0<IAvgFocusRole>() != null) ? this.Data0<IAvgFocusRole>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAvgShakeUi:
				_o.Data0.Value = ((this.Data0<IAvgShakeUi>() != null) ? this.Data0<IAvgShakeUi>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyDynamicEntities:
				_o.Data0.Value = ((this.Data0<IDestroyDynamicEntities>() != null) ? this.Data0<IDestroyDynamicEntities>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IActorLookAt:
				_o.Data0.Value = ((this.Data0<IActorLookAt>() != null) ? this.Data0<IActorLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IActorTurnTo:
				_o.Data0.Value = ((this.Data0<IActorTurnTo>() != null) ? this.Data0<IActorTurnTo>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowTalk:
				_o.Data0.Value = ((this.Data0<IShowTalk>() != null) ? this.Data0<IShowTalk>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFinishTalk:
				_o.Data0.Value = ((this.Data0<IFinishTalk>() != null) ? this.Data0<IFinishTalk>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowCenterText:
				_o.Data0.Value = ((this.Data0<IShowCenterText>() != null) ? this.Data0<IShowCenterText>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFinishState:
				_o.Data0.Value = ((this.Data0<IFinishState>() != null) ? this.Data0<IFinishState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeState:
				_o.Data0.Value = ((this.Data0<IChangeState>() != null) ? this.Data0<IChangeState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeBehaviorState:
				_o.Data0.Value = ((this.Data0<IChangeBehaviorState>() != null) ? this.Data0<IChangeBehaviorState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetBehaviorIsPaused:
				_o.Data0.Value = ((this.Data0<ISetBehaviorIsPaused>() != null) ? this.Data0<ISetBehaviorIsPaused>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeRandomState:
				_o.Data0.Value = ((this.Data0<IChangeRandomState>() != null) ? this.Data0<IChangeRandomState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeActorState:
				_o.Data0.Value = ((this.Data0<IChangeActorState>() != null) ? this.Data0<IChangeActorState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeOtherState:
				_o.Data0.Value = ((this.Data0<IChangeOtherState>() != null) ? this.Data0<IChangeOtherState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetCameraMode:
				_o.Data0.Value = ((this.Data0<ISetCameraMode>() != null) ? this.Data0<ISetCameraMode>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IModifySceneUiSubtitle:
				_o.Data0.Value = ((this.Data0<IModifySceneUiSubtitle>() != null) ? this.Data0<IModifySceneUiSubtitle>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetPlotMode:
				_o.Data0.Value = ((this.Data0<ISetPlotMode>() != null) ? this.Data0<ISetPlotMode>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlaySequenceData:
				_o.Data0.Value = ((this.Data0<IPlaySequenceData>() != null) ? this.Data0<IPlaySequenceData>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayCustomSequence:
				_o.Data0.Value = ((this.Data0<IPlayCustomSequence>() != null) ? this.Data0<IPlayCustomSequence>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayMovie:
				_o.Data0.Value = ((this.Data0<IPlayMovie>() != null) ? this.Data0<IPlayMovie>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayEffect:
				_o.Data0.Value = ((this.Data0<IPlayEffect>() != null) ? this.Data0<IPlayEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayEffect2:
				_o.Data0.Value = ((this.Data0<IPlayEffect2>() != null) ? this.Data0<IPlayEffect2>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayCommonEffect:
				_o.Data0.Value = ((this.Data0<IPlayCommonEffect>() != null) ? this.Data0<IPlayCommonEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayScreenEffect:
				_o.Data0.Value = ((this.Data0<IPlayScreenEffect>() != null) ? this.Data0<IPlayScreenEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISwitchEffectState:
				_o.Data0.Value = ((this.Data0<ISwitchEffectState>() != null) ? this.Data0<ISwitchEffectState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayDissolveEffect:
				_o.Data0.Value = ((this.Data0<IPlayDissolveEffect>() != null) ? this.Data0<IPlayDissolveEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayMpcEffect:
				_o.Data0.Value = ((this.Data0<IPlayMpcEffect>() != null) ? this.Data0<IPlayMpcEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveEffect:
				_o.Data0.Value = ((this.Data0<IRemoveEffect>() != null) ? this.Data0<IRemoveEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IWait:
				_o.Data0.Value = ((this.Data0<IWait>() != null) ? this.Data0<IWait>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IMoveToPosA:
				_o.Data0.Value = ((this.Data0<IMoveToPosA>() != null) ? this.Data0<IMoveToPosA>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetMoveSpeed:
				_o.Data0.Value = ((this.Data0<ISetMoveSpeed>() != null) ? this.Data0<ISetMoveSpeed>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetPosA:
				_o.Data0.Value = ((this.Data0<ISetPosA>() != null) ? this.Data0<ISetPosA>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFaceToPos:
				_o.Data0.Value = ((this.Data0<IFaceToPos>() != null) ? this.Data0<IFaceToPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISpawnChild:
				_o.Data0.Value = ((this.Data0<ISpawnChild>() != null) ? this.Data0<ISpawnChild>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISimpleMove:
				_o.Data0.Value = ((this.Data0<ISimpleMove>() != null) ? this.Data0<ISimpleMove>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetNumberVar:
				_o.Data0.Value = ((this.Data0<ISetNumberVar>() != null) ? this.Data0<ISetNumberVar>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISyncVarToActorState:
				_o.Data0.Value = ((this.Data0<ISyncVarToActorState>() != null) ? this.Data0<ISyncVarToActorState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDoCalculate:
				_o.Data0.Value = ((this.Data0<IDoCalculate>() != null) ? this.Data0<IDoCalculate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICallByCondition:
				_o.Data0.Value = ((this.Data0<ICallByCondition>() != null) ? this.Data0<ICallByCondition>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICallFunction:
				_o.Data0.Value = ((this.Data0<ICallFunction>() != null) ? this.Data0<ICallFunction>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddFlowInteractOption:
				_o.Data0.Value = ((this.Data0<IAddFlowInteractOption>() != null) ? this.Data0<IAddFlowInteractOption>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveFlowInteractOption:
				_o.Data0.Value = ((this.Data0<IRemoveFlowInteractOption>() != null) ? this.Data0<IRemoveFlowInteractOption>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeInteractOptionText:
				_o.Data0.Value = ((this.Data0<IChangeInteractOptionText>() != null) ? this.Data0<IChangeInteractOptionText>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISpawnEntity:
				_o.Data0.Value = ((this.Data0<ISpawnEntity>() != null) ? this.Data0<ISpawnEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyAllChild:
				_o.Data0.Value = ((this.Data0<IDestroyAllChild>() != null) ? this.Data0<IDestroyAllChild>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyEntity:
				_o.Data0.Value = ((this.Data0<IDestroyEntity>() != null) ? this.Data0<IDestroyEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayFlow:
				_o.Data0.Value = ((this.Data0<IPlayFlow>() != null) ? this.Data0<IPlayFlow>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IBubbleData:
				_o.Data0.Value = ((this.Data0<IBubbleData>() != null) ? this.Data0<IBubbleData>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayerLookAt:
				_o.Data0.Value = ((this.Data0<IPlayerLookAt>() != null) ? this.Data0<IPlayerLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEntityLookAt:
				_o.Data0.Value = ((this.Data0<IEntityLookAt>() != null) ? this.Data0<IEntityLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICharacterLookAt:
				_o.Data0.Value = ((this.Data0<ICharacterLookAt>() != null) ? this.Data0<ICharacterLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayerLookTowards:
				_o.Data0.Value = ((this.Data0<IPlayerLookTowards>() != null) ? this.Data0<IPlayerLookTowards>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEntityTurnTo:
				_o.Data0.Value = ((this.Data0<IEntityTurnTo>() != null) ? this.Data0<IEntityTurnTo>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICameraLookAt:
				_o.Data0.Value = ((this.Data0<ICameraLookAt>() != null) ? this.Data0<ICameraLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IStopCameraLookAt:
				_o.Data0.Value = ((this.Data0<IStopCameraLookAt>() != null) ? this.Data0<IStopCameraLookAt>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetVar:
				_o.Data0.Value = ((this.Data0<ISetVar>() != null) ? this.Data0<ISetVar>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetActorVar:
				_o.Data0.Value = ((this.Data0<ISetActorVar>() != null) ? this.Data0<ISetActorVar>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICalculateVar:
				_o.Data0.Value = ((this.Data0<ICalculateVar>() != null) ? this.Data0<ICalculateVar>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRandomVar:
				_o.Data0.Value = ((this.Data0<IRandomVar>() != null) ? this.Data0<IRandomVar>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IGuideTrigger:
				_o.Data0.Value = ((this.Data0<IGuideTrigger>() != null) ? this.Data0<IGuideTrigger>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICompleteGuide:
				_o.Data0.Value = ((this.Data0<ICompleteGuide>() != null) ? this.Data0<ICompleteGuide>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IGetItem:
				_o.Data0.Value = ((this.Data0<IGetItem>() != null) ? this.Data0<IGetItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyQuestItem:
				_o.Data0.Value = ((this.Data0<IDestroyQuestItem>() != null) ? this.Data0<IDestroyQuestItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAwakeEntity:
				_o.Data0.Value = ((this.Data0<IAwakeEntity>() != null) ? this.Data0<IAwakeEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetEntityVisible:
				_o.Data0.Value = ((this.Data0<ISetEntityVisible>() != null) ? this.Data0<ISetEntityVisible>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetEntityClientVisible:
				_o.Data0.Value = ((this.Data0<ISetEntityClientVisible>() != null) ? this.Data0<ISetEntityClientVisible>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetEntityClientVisibleSave:
				_o.Data0.Value = ((this.Data0<ISetEntityClientVisibleSave>() != null) ? this.Data0<ISetEntityClientVisibleSave>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ILockEntity:
				_o.Data0.Value = ((this.Data0<ILockEntity>() != null) ? this.Data0<ILockEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUnlockEntity:
				_o.Data0.Value = ((this.Data0<IUnlockEntity>() != null) ? this.Data0<IUnlockEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICompleteChildQuest:
				_o.Data0.Value = ((this.Data0<ICompleteChildQuest>() != null) ? this.Data0<ICompleteChildQuest>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAcceptCurrentQuest:
				_o.Data0.Value = ((this.Data0<IAcceptCurrentQuest>() != null) ? this.Data0<IAcceptCurrentQuest>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFinishDoInteract:
				_o.Data0.Value = ((this.Data0<IFinishDoInteract>() != null) ? this.Data0<IFinishDoInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IModifyEntityDecoration:
				_o.Data0.Value = ((this.Data0<IModifyEntityDecoration>() != null) ? this.Data0<IModifyEntityDecoration>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddBuffToEntity:
				_o.Data0.Value = ((this.Data0<IAddBuffToEntity>() != null) ? this.Data0<IAddBuffToEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddBuffToPlayer:
				_o.Data0.Value = ((this.Data0<IAddBuffToPlayer>() != null) ? this.Data0<IAddBuffToPlayer>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddBuffToFollowShooter:
				_o.Data0.Value = ((this.Data0<IAddBuffToFollowShooter>() != null) ? this.Data0<IAddBuffToFollowShooter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IOpenSystemBoard:
				_o.Data0.Value = ((this.Data0<IOpenSystemBoard>() != null) ? this.Data0<IOpenSystemBoard>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IOpenSystemFunction:
				_o.Data0.Value = ((this.Data0<IOpenSystemFunction>() != null) ? this.Data0<IOpenSystemFunction>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeEntityState:
				_o.Data0.Value = ((this.Data0<IChangeEntityState>() != null) ? this.Data0<IChangeEntityState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeEntityStateDirectly:
				_o.Data0.Value = ((this.Data0<IChangeEntityStateDirectly>() != null) ? this.Data0<IChangeEntityStateDirectly>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeEntityStateBatchDirectly:
				_o.Data0.Value = ((this.Data0<IChangeEntityStateBatchDirectly>() != null) ? this.Data0<IChangeEntityStateBatchDirectly>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeEntityStateLoop:
				_o.Data0.Value = ((this.Data0<IChangeEntityStateLoop>() != null) ? this.Data0<IChangeEntityStateLoop>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeNpcPerformState:
				_o.Data0.Value = ((this.Data0<IChangeNpcPerformState>() != null) ? this.Data0<IChangeNpcPerformState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetForceLock:
				_o.Data0.Value = ((this.Data0<ISetForceLock>() != null) ? this.Data0<ISetForceLock>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetAreaState:
				_o.Data0.Value = ((this.Data0<ISetAreaState>() != null) ? this.Data0<ISetAreaState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetWuYinQuState:
				_o.Data0.Value = ((this.Data0<ISetWuYinQuState>() != null) ? this.Data0<ISetWuYinQuState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveBuffFromEntity:
				_o.Data0.Value = ((this.Data0<IRemoveBuffFromEntity>() != null) ? this.Data0<IRemoveBuffFromEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveBuffFromPlayer:
				_o.Data0.Value = ((this.Data0<IRemoveBuffFromPlayer>() != null) ? this.Data0<IRemoveBuffFromPlayer>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICollect:
				_o.Data0.Value = ((this.Data0<ICollect>() != null) ? this.Data0<ICollect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroy:
				_o.Data0.Value = ((this.Data0<IDestroy>() != null) ? this.Data0<IDestroy>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroySelf:
				_o.Data0.Value = ((this.Data0<IDestroySelf>() != null) ? this.Data0<IDestroySelf>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetPlayerMoveControl:
				_o.Data0.Value = ((this.Data0<ISetPlayerMoveControl>() != null) ? this.Data0<ISetPlayerMoveControl>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUnlockTeleportTrigger:
				_o.Data0.Value = ((this.Data0<IUnlockTeleportTrigger>() != null) ? this.Data0<IUnlockTeleportTrigger>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeTeamPosition:
				_o.Data0.Value = ((this.Data0<IChangeTeamPosition>() != null) ? this.Data0<IChangeTeamPosition>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClientChangeTeamPosition:
				_o.Data0.Value = ((this.Data0<IClientChangeTeamPosition>() != null) ? this.Data0<IClientChangeTeamPosition>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClaimLevelPlayReward:
				_o.Data0.Value = ((this.Data0<IClaimLevelPlayReward>() != null) ? this.Data0<IClaimLevelPlayReward>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClaimDynamicEntityReward:
				_o.Data0.Value = ((this.Data0<IClaimDynamicEntityReward>() != null) ? this.Data0<IClaimDynamicEntityReward>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClearFishingCabinInSaleItems:
				_o.Data0.Value = ((this.Data0<IClearFishingCabinInSaleItems>() != null) ? this.Data0<IClearFishingCabinInSaleItems>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAcceptFishingEntrust:
				_o.Data0.Value = ((this.Data0<IAcceptFishingEntrust>() != null) ? this.Data0<IAcceptFishingEntrust>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyFishingBoat:
				_o.Data0.Value = ((this.Data0<IDestroyFishingBoat>() != null) ? this.Data0<IDestroyFishingBoat>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITeleportDungeon:
				_o.Data0.Value = ((this.Data0<ITeleportDungeon>() != null) ? this.Data0<ITeleportDungeon>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IStopUiScreenEffect:
				_o.Data0.Value = ((this.Data0<IStopUiScreenEffect>() != null) ? this.Data0<IStopUiScreenEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClaimDungeonReward:
				_o.Data0.Value = ((this.Data0<IClaimDungeonReward>() != null) ? this.Data0<IClaimDungeonReward>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISettlementDungeon:
				_o.Data0.Value = ((this.Data0<ISettlementDungeon>() != null) ? this.Data0<ISettlementDungeon>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExitDungeon:
				_o.Data0.Value = ((this.Data0<IExitDungeon>() != null) ? this.Data0<IExitDungeon>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUnlockDungeonEntry:
				_o.Data0.Value = ((this.Data0<IUnlockDungeonEntry>() != null) ? this.Data0<IUnlockDungeonEntry>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFinishDungeon:
				_o.Data0.Value = ((this.Data0<IFinishDungeon>() != null) ? this.Data0<IFinishDungeon>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetReviveRegion:
				_o.Data0.Value = ((this.Data0<ISetReviveRegion>() != null) ? this.Data0<ISetReviveRegion>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPromptQuestChapterUI:
				_o.Data0.Value = ((this.Data0<IPromptQuestChapterUI>() != null) ? this.Data0<IPromptQuestChapterUI>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFireBullet:
				_o.Data0.Value = ((this.Data0<IFireBullet>() != null) ? this.Data0<IFireBullet>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFireBulletEffect:
				_o.Data0.Value = ((this.Data0<IFireBulletEffect>() != null) ? this.Data0<IFireBulletEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetAssistCharacterPos:
				_o.Data0.Value = ((this.Data0<ISetAssistCharacterPos>() != null) ? this.Data0<ISetAssistCharacterPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetPlayerPos:
				_o.Data0.Value = ((this.Data0<ISetPlayerPos>() != null) ? this.Data0<ISetPlayerPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClientSetPlayerPos:
				_o.Data0.Value = ((this.Data0<IClientSetPlayerPos>() != null) ? this.Data0<IClientSetPlayerPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClientPreEnableSubLevels:
				_o.Data0.Value = ((this.Data0<IClientPreEnableSubLevels>() != null) ? this.Data0<IClientPreEnableSubLevels>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRogueGotoNextFloor:
				_o.Data0.Value = ((this.Data0<IRogueGotoNextFloor>() != null) ? this.Data0<IRogueGotoNextFloor>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRogueSelectRoom:
				_o.Data0.Value = ((this.Data0<IRogueSelectRoom>() != null) ? this.Data0<IRogueSelectRoom>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRogueActivatePortal:
				_o.Data0.Value = ((this.Data0<IRogueActivatePortal>() != null) ? this.Data0<IRogueActivatePortal>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRogueReceiveReward:
				_o.Data0.Value = ((this.Data0<IRogueReceiveReward>() != null) ? this.Data0<IRogueReceiveReward>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeSelfEntityState:
				_o.Data0.Value = ((this.Data0<IChangeSelfEntityState>() != null) ? this.Data0<IChangeSelfEntityState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IInterludeActions:
				_o.Data0.Value = ((this.Data0<IInterludeActions>() != null) ? this.Data0<IInterludeActions>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddBuffToTriggeredEntity:
				_o.Data0.Value = ((this.Data0<IAddBuffToTriggeredEntity>() != null) ? this.Data0<IAddBuffToTriggeredEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveBuffToTriggeredEntity:
				_o.Data0.Value = ((this.Data0<IRemoveBuffToTriggeredEntity>() != null) ? this.Data0<IRemoveBuffToTriggeredEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDetectTrigger:
				_o.Data0.Value = ((this.Data0<IDetectTrigger>() != null) ? this.Data0<IDetectTrigger>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IItemFoundationMatch:
				_o.Data0.Value = ((this.Data0<IItemFoundationMatch>() != null) ? this.Data0<IItemFoundationMatch>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetBattleState:
				_o.Data0.Value = ((this.Data0<ISetBattleState>() != null) ? this.Data0<ISetBattleState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExecBattleAction:
				_o.Data0.Value = ((this.Data0<IExecBattleAction>() != null) ? this.Data0<IExecBattleAction>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExecClientMonsterNpcInteract:
				_o.Data0.Value = ((this.Data0<IExecClientMonsterNpcInteract>() != null) ? this.Data0<IExecClientMonsterNpcInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExecClientBattleAction:
				_o.Data0.Value = ((this.Data0<IExecClientBattleAction>() != null) ? this.Data0<IExecClientBattleAction>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IWaitBattleCondition:
				_o.Data0.Value = ((this.Data0<IWaitBattleCondition>() != null) ? this.Data0<IWaitBattleCondition>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableHostility:
				_o.Data0.Value = ((this.Data0<IEnableHostility>() != null) ? this.Data0<IEnableHostility>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUnlockSystemItem:
				_o.Data0.Value = ((this.Data0<IUnlockSystemItem>() != null) ? this.Data0<IUnlockSystemItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClientUnlockAchievementSystemItem:
				_o.Data0.Value = ((this.Data0<IClientUnlockAchievementSystemItem>() != null) ? this.Data0<IClientUnlockAchievementSystemItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddPlayBubble:
				_o.Data0.Value = ((this.Data0<IAddPlayBubble>() != null) ? this.Data0<IAddPlayBubble>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayBubble:
				_o.Data0.Value = ((this.Data0<IPlayBubble>() != null) ? this.Data0<IPlayBubble>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClearPlayBubble:
				_o.Data0.Value = ((this.Data0<IClearPlayBubble>() != null) ? this.Data0<IClearPlayBubble>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IMoveWithSpline:
				_o.Data0.Value = ((this.Data0<IMoveWithSpline>() != null) ? this.Data0<IMoveWithSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.INewMoveWithSpline:
				_o.Data0.Value = ((this.Data0<INewMoveWithSpline>() != null) ? this.Data0<INewMoveWithSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IStopNewMoveWithSpline:
				_o.Data0.Value = ((this.Data0<IStopNewMoveWithSpline>() != null) ? this.Data0<IStopNewMoveWithSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICharacterMoveToPoint:
				_o.Data0.Value = ((this.Data0<ICharacterMoveToPoint>() != null) ? this.Data0<ICharacterMoveToPoint>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPlayerMoveToPoint:
				_o.Data0.Value = ((this.Data0<IPlayerMoveToPoint>() != null) ? this.Data0<IPlayerMoveToPoint>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.INpcMoveToPoint:
				_o.Data0.Value = ((this.Data0<INpcMoveToPoint>() != null) ? this.Data0<INpcMoveToPoint>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IToggleScanSplineEffect:
				_o.Data0.Value = ((this.Data0<IToggleScanSplineEffect>() != null) ? this.Data0<IToggleScanSplineEffect>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IOpenTraceSpline:
				_o.Data0.Value = ((this.Data0<IOpenTraceSpline>() != null) ? this.Data0<IOpenTraceSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICloseTraceSpline:
				_o.Data0.Value = ((this.Data0<ICloseTraceSpline>() != null) ? this.Data0<ICloseTraceSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITraceSpline:
				_o.Data0.Value = ((this.Data0<ITraceSpline>() != null) ? this.Data0<ITraceSpline>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableAI:
				_o.Data0.Value = ((this.Data0<IEnableAI>() != null) ? this.Data0<IEnableAI>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRunActions:
				_o.Data0.Value = ((this.Data0<IRunActions>() != null) ? this.Data0<IRunActions>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICommonTip:
				_o.Data0.Value = ((this.Data0<ICommonTip>() != null) ? this.Data0<ICommonTip>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICommonTip2:
				_o.Data0.Value = ((this.Data0<ICommonTip2>() != null) ? this.Data0<ICommonTip2>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEndCommonTip:
				_o.Data0.Value = ((this.Data0<IEndCommonTip>() != null) ? this.Data0<IEndCommonTip>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableNearbyTracking:
				_o.Data0.Value = ((this.Data0<IEnableNearbyTracking>() != null) ? this.Data0<IEnableNearbyTracking>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISendAiEvent:
				_o.Data0.Value = ((this.Data0<ISendAiEvent>() != null) ? this.Data0<ISendAiEvent>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableLevelPlay:
				_o.Data0.Value = ((this.Data0<IEnableLevelPlay>() != null) ? this.Data0<IEnableLevelPlay>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IServerForceEnableLevelPlay:
				_o.Data0.Value = ((this.Data0<IServerForceEnableLevelPlay>() != null) ? this.Data0<IServerForceEnableLevelPlay>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITeleportDungeonPos:
				_o.Data0.Value = ((this.Data0<ITeleportDungeonPos>() != null) ? this.Data0<ITeleportDungeonPos>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFadeInScreen:
				_o.Data0.Value = ((this.Data0<IFadeInScreen>() != null) ? this.Data0<IFadeInScreen>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IFadeOutScreen:
				_o.Data0.Value = ((this.Data0<IFadeOutScreen>() != null) ? this.Data0<IFadeOutScreen>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IStartFlowTemplate:
				_o.Data0.Value = ((this.Data0<IStartFlowTemplate>() != null) ? this.Data0<IStartFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEndFlowTemplate:
				_o.Data0.Value = ((this.Data0<IEndFlowTemplate>() != null) ? this.Data0<IEndFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ICloseFlowTemplate:
				_o.Data0.Value = ((this.Data0<ICloseFlowTemplate>() != null) ? this.Data0<ICloseFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeFlowTemplate:
				_o.Data0.Value = ((this.Data0<IChangeFlowTemplate>() != null) ? this.Data0<IChangeFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IBeginFlowTemplate:
				_o.Data0.Value = ((this.Data0<IBeginFlowTemplate>() != null) ? this.Data0<IBeginFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetFlowTemplate:
				_o.Data0.Value = ((this.Data0<ISetFlowTemplate>() != null) ? this.Data0<ISetFlowTemplate>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IHideTargetRange:
				_o.Data0.Value = ((this.Data0<IHideTargetRange>() != null) ? this.Data0<IHideTargetRange>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowTargetRange:
				_o.Data0.Value = ((this.Data0<IShowTargetRange>() != null) ? this.Data0<IShowTargetRange>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IHideSpecificEntities:
				_o.Data0.Value = ((this.Data0<IHideSpecificEntities>() != null) ? this.Data0<IHideSpecificEntities>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowSpecificEntities:
				_o.Data0.Value = ((this.Data0<IShowSpecificEntities>() != null) ? this.Data0<IShowSpecificEntities>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IHideGroup:
				_o.Data0.Value = ((this.Data0<IHideGroup>() != null) ? this.Data0<IHideGroup>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowHidedGroup:
				_o.Data0.Value = ((this.Data0<IShowHidedGroup>() != null) ? this.Data0<IShowHidedGroup>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetSubScreenMode:
				_o.Data0.Value = ((this.Data0<ISetSubScreenMode>() != null) ? this.Data0<ISetSubScreenMode>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IToggleDragActorPlay:
				_o.Data0.Value = ((this.Data0<IToggleDragActorPlay>() != null) ? this.Data0<IToggleDragActorPlay>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDarkTideSetMapMarkState:
				_o.Data0.Value = ((this.Data0<IDarkTideSetMapMarkState>() != null) ? this.Data0<IDarkTideSetMapMarkState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IManualOccupations:
				_o.Data0.Value = ((this.Data0<IManualOccupations>() != null) ? this.Data0<IManualOccupations>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IForceOccupations:
				_o.Data0.Value = ((this.Data0<IForceOccupations>() != null) ? this.Data0<IForceOccupations>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeFightTeam:
				_o.Data0.Value = ((this.Data0<IChangeFightTeam>() != null) ? this.Data0<IChangeFightTeam>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IActiveRange:
				_o.Data0.Value = ((this.Data0<IActiveRange>() != null) ? this.Data0<IActiveRange>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddTrialCharacter:
				_o.Data0.Value = ((this.Data0<IAddTrialCharacter>() != null) ? this.Data0<IAddTrialCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUpdateTrialCharacter:
				_o.Data0.Value = ((this.Data0<IUpdateTrialCharacter>() != null) ? this.Data0<IUpdateTrialCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRestoreTrialCharacter:
				_o.Data0.Value = ((this.Data0<IRestoreTrialCharacter>() != null) ? this.Data0<IRestoreTrialCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveTrialCharacter:
				_o.Data0.Value = ((this.Data0<IRemoveTrialCharacter>() != null) ? this.Data0<IRemoveTrialCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAddGuestCharacter:
				_o.Data0.Value = ((this.Data0<IAddGuestCharacter>() != null) ? this.Data0<IAddGuestCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRemoveGuestCharacter:
				_o.Data0.Value = ((this.Data0<IRemoveGuestCharacter>() != null) ? this.Data0<IRemoveGuestCharacter>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IDestroyQuest:
				_o.Data0.Value = ((this.Data0<IDestroyQuest>() != null) ? this.Data0<IDestroyQuest>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetCameraAnim:
				_o.Data0.Value = ((this.Data0<ISetCameraAnim>() != null) ? this.Data0<ISetCameraAnim>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeTimer:
				_o.Data0.Value = ((this.Data0<IChangeTimer>() != null) ? this.Data0<IChangeTimer>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IToggleTimerPauseState:
				_o.Data0.Value = ((this.Data0<IToggleTimerPauseState>() != null) ? this.Data0<IToggleTimerPauseState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRotatorEntity:
				_o.Data0.Value = ((this.Data0<IRotatorEntity>() != null) ? this.Data0<IRotatorEntity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUnLimitPlayerOperation:
				_o.Data0.Value = ((this.Data0<IUnLimitPlayerOperation>() != null) ? this.Data0<IUnLimitPlayerOperation>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ILimitPlayerOperation:
				_o.Data0.Value = ((this.Data0<ILimitPlayerOperation>() != null) ? this.Data0<ILimitPlayerOperation>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableSystem:
				_o.Data0.Value = ((this.Data0<IEnableSystem>() != null) ? this.Data0<IEnableSystem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ILeisureInteract:
				_o.Data0.Value = ((this.Data0<ILeisureInteract>() != null) ? this.Data0<ILeisureInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.INpcLeisureInteract:
				_o.Data0.Value = ((this.Data0<INpcLeisureInteract>() != null) ? this.Data0<INpcLeisureInteract>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPostAkEvent:
				_o.Data0.Value = ((this.Data0<IPostAkEvent>() != null) ? this.Data0<IPostAkEvent>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IMoveSceneItem:
				_o.Data0.Value = ((this.Data0<IMoveSceneItem>() != null) ? this.Data0<IMoveSceneItem>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IStopSceneItemMove:
				_o.Data0.Value = ((this.Data0<IStopSceneItemMove>() != null) ? this.Data0<IStopSceneItemMove>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeLiftTarget:
				_o.Data0.Value = ((this.Data0<IChangeLiftTarget>() != null) ? this.Data0<IChangeLiftTarget>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IHideByRangeInFlow:
				_o.Data0.Value = ((this.Data0<IHideByRangeInFlow>() != null) ? this.Data0<IHideByRangeInFlow>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IShowAllHidedGroupInFlow:
				_o.Data0.Value = ((this.Data0<IShowAllHidedGroupInFlow>() != null) ? this.Data0<IShowAllHidedGroupInFlow>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IOpenSimpleGameplay:
				_o.Data0.Value = ((this.Data0<IOpenSimpleGameplay>() != null) ? this.Data0<IOpenSimpleGameplay>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IToggleRideFlyingCarUiGameplay:
				_o.Data0.Value = ((this.Data0<IToggleRideFlyingCarUiGameplay>() != null) ? this.Data0<IToggleRideFlyingCarUiGameplay>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangePhantom:
				_o.Data0.Value = ((this.Data0<IChangePhantom>() != null) ? this.Data0<IChangePhantom>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRestorePhantom:
				_o.Data0.Value = ((this.Data0<IRestorePhantom>() != null) ? this.Data0<IRestorePhantom>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITakePlotPhoto:
				_o.Data0.Value = ((this.Data0<ITakePlotPhoto>() != null) ? this.Data0<ITakePlotPhoto>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangeActorTalker:
				_o.Data0.Value = ((this.Data0<IChangeActorTalker>() != null) ? this.Data0<IChangeActorTalker>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISwitchSubLevels:
				_o.Data0.Value = ((this.Data0<ISwitchSubLevels>() != null) ? this.Data0<ISwitchSubLevels>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISwitchSubLevelsDirectly:
				_o.Data0.Value = ((this.Data0<ISwitchSubLevelsDirectly>() != null) ? this.Data0<ISwitchSubLevelsDirectly>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IPreloadSubLevels:
				_o.Data0.Value = ((this.Data0<IPreloadSubLevels>() != null) ? this.Data0<IPreloadSubLevels>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISwitchPermission:
				_o.Data0.Value = ((this.Data0<ISwitchPermission>() != null) ? this.Data0<ISwitchPermission>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISwitchDataLayers:
				_o.Data0.Value = ((this.Data0<ISwitchDataLayers>() != null) ? this.Data0<ISwitchDataLayers>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IActivateResetPoint:
				_o.Data0.Value = ((this.Data0<IActivateResetPoint>() != null) ? this.Data0<IActivateResetPoint>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ITeleportToLatestResetPoint:
				_o.Data0.Value = ((this.Data0<ITeleportToLatestResetPoint>() != null) ? this.Data0<ITeleportToLatestResetPoint>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetWeather:
				_o.Data0.Value = ((this.Data0<ISetWeather>() != null) ? this.Data0<ISetWeather>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetTimeLockState:
				_o.Data0.Value = ((this.Data0<ISetTimeLockState>() != null) ? this.Data0<ISetTimeLockState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.ISetWeatherLockState:
				_o.Data0.Value = ((this.Data0<ISetWeatherLockState>() != null) ? this.Data0<ISetWeatherLockState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IClientSetSeasonState:
				_o.Data0.Value = ((this.Data0<IClientSetSeasonState>() != null) ? this.Data0<IClientSetSeasonState>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAxisLockScreenConfig:
				_o.Data0.Value = ((this.Data0<IAxisLockScreenConfig>() != null) ? this.Data0<IAxisLockScreenConfig>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAdjustPlayerCamera:
				_o.Data0.Value = ((this.Data0<IAdjustPlayerCamera>() != null) ? this.Data0<IAdjustPlayerCamera>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRestorePlayerCameraAdjustment:
				_o.Data0.Value = ((this.Data0<IRestorePlayerCameraAdjustment>() != null) ? this.Data0<IRestorePlayerCameraAdjustment>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IAdjustPlayerCameraGravity:
				_o.Data0.Value = ((this.Data0<IAdjustPlayerCameraGravity>() != null) ? this.Data0<IAdjustPlayerCameraGravity>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnterMovieCamera:
				_o.Data0.Value = ((this.Data0<IEnterMovieCamera>() != null) ? this.Data0<IEnterMovieCamera>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExitMovieCamera:
				_o.Data0.Value = ((this.Data0<IExitMovieCamera>() != null) ? this.Data0<IExitMovieCamera>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IResetPlayerCameraFocus:
				_o.Data0.Value = ((this.Data0<IResetPlayerCameraFocus>() != null) ? this.Data0<IResetPlayerCameraFocus>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IUsePhantomSkill:
				_o.Data0.Value = ((this.Data0<IUsePhantomSkill>() != null) ? this.Data0<IUsePhantomSkill>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IChangePhantomFormation:
				_o.Data0.Value = ((this.Data0<IChangePhantomFormation>() != null) ? this.Data0<IChangePhantomFormation>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IRestorePhantomFormation:
				_o.Data0.Value = ((this.Data0<IRestorePhantomFormation>() != null) ? this.Data0<IRestorePhantomFormation>().Value.UnPack() : null);
				break;
			}
			_o.Data1 = new IActionParams_Union_1Union();
			_o.Data1.Type = this.Data1Type;
			switch (this.Data1Type)
			{
			case IActionParams_Union_1.IEnterOrbitalCamera:
				_o.Data1.Value = ((this.Data1<IEnterOrbitalCamera>() != null) ? this.Data1<IEnterOrbitalCamera>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExitOrbitalCamera:
				_o.Data1.Value = ((this.Data1<IExitOrbitalCamera>() != null) ? this.Data1<IExitOrbitalCamera>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableSplineMoveModel:
				_o.Data1.Value = ((this.Data1<IEnableSplineMoveModel>() != null) ? this.Data1<IEnableSplineMoveModel>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableActor:
				_o.Data1.Value = ((this.Data1<IEnableActor>() != null) ? this.Data1<IEnableActor>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetSportsState:
				_o.Data1.Value = ((this.Data1<ISetSportsState>() != null) ? this.Data1<ISetSportsState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetExploreState:
				_o.Data1.Value = ((this.Data1<ISetExploreState>() != null) ? this.Data1<ISetExploreState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifyActorMaterial:
				_o.Data1.Value = ((this.Data1<IModifyActorMaterial>() != null) ? this.Data1<IModifyActorMaterial>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifyActorMaterialParamBySplineProgress:
				_o.Data1.Value = ((this.Data1<IModifyActorMaterialParamBySplineProgress>() != null) ? this.Data1<IModifyActorMaterialParamBySplineProgress>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifyActorMedia:
				_o.Data1.Value = ((this.Data1<IModifyActorMedia>() != null) ? this.Data1<IModifyActorMedia>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPlayLevelSequence:
				_o.Data1.Value = ((this.Data1<IPlayLevelSequence>() != null) ? this.Data1<IPlayLevelSequence>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableTakePhotoClip:
				_o.Data1.Value = ((this.Data1<IEnableTakePhotoClip>() != null) ? this.Data1<IEnableTakePhotoClip>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IToggleAirWall:
				_o.Data1.Value = ((this.Data1<IToggleAirWall>() != null) ? this.Data1<IToggleAirWall>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITriggerCameraShake:
				_o.Data1.Value = ((this.Data1<ITriggerCameraShake>() != null) ? this.Data1<ITriggerCameraShake>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITriggerGamepadShake:
				_o.Data1.Value = ((this.Data1<ITriggerGamepadShake>() != null) ? this.Data1<ITriggerGamepadShake>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPlayRegisteredMontage:
				_o.Data1.Value = ((this.Data1<IPlayRegisteredMontage>() != null) ? this.Data1<IPlayRegisteredMontage>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ICreatePrefab:
				_o.Data1.Value = ((this.Data1<ICreatePrefab>() != null) ? this.Data1<ICreatePrefab>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDestroyPrefab:
				_o.Data1.Value = ((this.Data1<IDestroyPrefab>() != null) ? this.Data1<IDestroyPrefab>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetDataLayerTransitions:
				_o.Data1.Value = ((this.Data1<ISetDataLayerTransitions>() != null) ? this.Data1<ISetDataLayerTransitions>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableAoiNotify:
				_o.Data1.Value = ((this.Data1<IEnableAoiNotify>() != null) ? this.Data1<IEnableAoiNotify>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRecoverDurability:
				_o.Data1.Value = ((this.Data1<IRecoverDurability>() != null) ? this.Data1<IRecoverDurability>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetPlayerOperationRestriction:
				_o.Data1.Value = ((this.Data1<ISetPlayerOperationRestriction>() != null) ? this.Data1<ISetPlayerOperationRestriction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableAllPlayerOperation:
				_o.Data1.Value = ((this.Data1<IEnableAllPlayerOperation>() != null) ? this.Data1<IEnableAllPlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDisableAllPlayerOperation:
				_o.Data1.Value = ((this.Data1<IDisableAllPlayerOperation>() != null) ? this.Data1<IDisableAllPlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDisableModulePlayerOperation:
				_o.Data1.Value = ((this.Data1<IDisableModulePlayerOperation>() != null) ? this.Data1<IDisableModulePlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientSetPlayerOperationRestriction:
				_o.Data1.Value = ((this.Data1<IClientSetPlayerOperationRestriction>() != null) ? this.Data1<IClientSetPlayerOperationRestriction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientEnableAllPlayerOperation:
				_o.Data1.Value = ((this.Data1<IClientEnableAllPlayerOperation>() != null) ? this.Data1<IClientEnableAllPlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientDisableAllPlayerOperation:
				_o.Data1.Value = ((this.Data1<IClientDisableAllPlayerOperation>() != null) ? this.Data1<IClientDisableAllPlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientDisableModulePlayerOperation:
				_o.Data1.Value = ((this.Data1<IClientDisableModulePlayerOperation>() != null) ? this.Data1<IClientDisableModulePlayerOperation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableFunction:
				_o.Data1.Value = ((this.Data1<IEnableFunction>() != null) ? this.Data1<IEnableFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITeleportDungeonFunction:
				_o.Data1.Value = ((this.Data1<ITeleportDungeonFunction>() != null) ? this.Data1<ITeleportDungeonFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IMotorRadioUiFunction:
				_o.Data1.Value = ((this.Data1<IMotorRadioUiFunction>() != null) ? this.Data1<IMotorRadioUiFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IInteractiveItemsFunction:
				_o.Data1.Value = ((this.Data1<IInteractiveItemsFunction>() != null) ? this.Data1<IInteractiveItemsFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableClientFunction:
				_o.Data1.Value = ((this.Data1<IEnableClientFunction>() != null) ? this.Data1<IEnableClientFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHealthBarDisplayClientFunction:
				_o.Data1.Value = ((this.Data1<IHealthBarDisplayClientFunction>() != null) ? this.Data1<IHealthBarDisplayClientFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeEntityPrefabPerformance:
				_o.Data1.Value = ((this.Data1<IChangeEntityPrefabPerformance>() != null) ? this.Data1<IChangeEntityPrefabPerformance>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeTargetEntityPrefabPerformance:
				_o.Data1.Value = ((this.Data1<IChangeTargetEntityPrefabPerformance>() != null) ? this.Data1<IChangeTargetEntityPrefabPerformance>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeSelfEntityPrefabPerformance:
				_o.Data1.Value = ((this.Data1<IChangeSelfEntityPrefabPerformance>() != null) ? this.Data1<IChangeSelfEntityPrefabPerformance>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifySceneItemAttributeTag:
				_o.Data1.Value = ((this.Data1<IModifySceneItemAttributeTag>() != null) ? this.Data1<IModifySceneItemAttributeTag>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifySelfSceneItemAttributeTag:
				_o.Data1.Value = ((this.Data1<IModifySelfSceneItemAttributeTag>() != null) ? this.Data1<IModifySelfSceneItemAttributeTag>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IModifyTargetSceneItemAttributeTag:
				_o.Data1.Value = ((this.Data1<IModifyTargetSceneItemAttributeTag>() != null) ? this.Data1<IModifyTargetSceneItemAttributeTag>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientModifyTargetTag:
				_o.Data1.Value = ((this.Data1<IClientModifyTargetTag>() != null) ? this.Data1<IClientModifyTargetTag>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IToggleMapMarkState:
				_o.Data1.Value = ((this.Data1<IToggleMapMarkState>() != null) ? this.Data1<IToggleMapMarkState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IShowMapMark:
				_o.Data1.Value = ((this.Data1<IShowMapMark>() != null) ? this.Data1<IShowMapMark>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHideMapMark:
				_o.Data1.Value = ((this.Data1<IHideMapMark>() != null) ? this.Data1<IHideMapMark>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDisableMapMark:
				_o.Data1.Value = ((this.Data1<IDisableMapMark>() != null) ? this.Data1<IDisableMapMark>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IFocusOnMapMarkAction:
				_o.Data1.Value = ((this.Data1<IFocusOnMapMarkAction>() != null) ? this.Data1<IFocusOnMapMarkAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableTemporaryTeleport:
				_o.Data1.Value = ((this.Data1<IEnableTemporaryTeleport>() != null) ? this.Data1<IEnableTemporaryTeleport>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetRegionConfig:
				_o.Data1.Value = ((this.Data1<ISetRegionConfig>() != null) ? this.Data1<ISetRegionConfig>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetRegionMpc:
				_o.Data1.Value = ((this.Data1<ISetRegionMpc>() != null) ? this.Data1<ISetRegionMpc>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetJigsawItem:
				_o.Data1.Value = ((this.Data1<ISetJigsawItem>() != null) ? this.Data1<ISetJigsawItem>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetJigsawFoundation:
				_o.Data1.Value = ((this.Data1<ISetJigsawFoundation>() != null) ? this.Data1<ISetJigsawFoundation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IToggleHighlightExploreUi:
				_o.Data1.Value = ((this.Data1<IToggleHighlightExploreUi>() != null) ? this.Data1<IToggleHighlightExploreUi>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IShowHighlightExploreSkillIcon:
				_o.Data1.Value = ((this.Data1<IShowHighlightExploreSkillIcon>() != null) ? this.Data1<IShowHighlightExploreSkillIcon>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHideHighlightExploreSkillIcon:
				_o.Data1.Value = ((this.Data1<IHideHighlightExploreSkillIcon>() != null) ? this.Data1<IHideHighlightExploreSkillIcon>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IToggleAndHighlightItem:
				_o.Data1.Value = ((this.Data1<IToggleAndHighlightItem>() != null) ? this.Data1<IToggleAndHighlightItem>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IResetEntity:
				_o.Data1.Value = ((this.Data1<IResetEntity>() != null) ? this.Data1<IResetEntity>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IResetLevelPlay:
				_o.Data1.Value = ((this.Data1<IResetLevelPlay>() != null) ? this.Data1<IResetLevelPlay>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPlayDynamicSettlement:
				_o.Data1.Value = ((this.Data1<IPlayDynamicSettlement>() != null) ? this.Data1<IPlayDynamicSettlement>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetInteractionLockState:
				_o.Data1.Value = ((this.Data1<ISetInteractionLockState>() != null) ? this.Data1<ISetInteractionLockState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetAudioState:
				_o.Data1.Value = ((this.Data1<ISetAudioState>() != null) ? this.Data1<ISetAudioState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISendBattleTag:
				_o.Data1.Value = ((this.Data1<ISendBattleTag>() != null) ? this.Data1<ISendBattleTag>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPerformerAiSplineMove:
				_o.Data1.Value = ((this.Data1<IPerformerAiSplineMove>() != null) ? this.Data1<IPerformerAiSplineMove>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPerformerAiMoveTo:
				_o.Data1.Value = ((this.Data1<IPerformerAiMoveTo>() != null) ? this.Data1<IPerformerAiMoveTo>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IAddTrialFollowShooter:
				_o.Data1.Value = ((this.Data1<IAddTrialFollowShooter>() != null) ? this.Data1<IAddTrialFollowShooter>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRemoveTrialFollowShooter:
				_o.Data1.Value = ((this.Data1<IRemoveTrialFollowShooter>() != null) ? this.Data1<IRemoveTrialFollowShooter>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableFollowShooterAbility:
				_o.Data1.Value = ((this.Data1<IEnableFollowShooterAbility>() != null) ? this.Data1<IEnableFollowShooterAbility>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IFollowShooterLeisureInteract:
				_o.Data1.Value = ((this.Data1<IFollowShooterLeisureInteract>() != null) ? this.Data1<IFollowShooterLeisureInteract>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientFollowShooterLeisureInteract:
				_o.Data1.Value = ((this.Data1<IClientFollowShooterLeisureInteract>() != null) ? this.Data1<IClientFollowShooterLeisureInteract>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ICustomJson:
				_o.Data1.Value = ((this.Data1<ICustomJson>() != null) ? this.Data1<ICustomJson>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExecResurrection:
				_o.Data1.Value = ((this.Data1<IExecResurrection>() != null) ? this.Data1<IExecResurrection>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IOpenSystemBoardWithReturn:
				_o.Data1.Value = ((this.Data1<IOpenSystemBoardWithReturn>() != null) ? this.Data1<IOpenSystemBoardWithReturn>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IResumeSystemRewardPopup:
				_o.Data1.Value = ((this.Data1<IResumeSystemRewardPopup>() != null) ? this.Data1<IResumeSystemRewardPopup>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExecRiskHarvestEffect:
				_o.Data1.Value = ((this.Data1<IExecRiskHarvestEffect>() != null) ? this.Data1<IExecRiskHarvestEffect>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetTeleControl:
				_o.Data1.Value = ((this.Data1<ISetTeleControl>() != null) ? this.Data1<ISetTeleControl>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IMowingTowerGotoNextFloor:
				_o.Data1.Value = ((this.Data1<IMowingTowerGotoNextFloor>() != null) ? this.Data1<IMowingTowerGotoNextFloor>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISlashAndTowerGotoNextFloor:
				_o.Data1.Value = ((this.Data1<ISlashAndTowerGotoNextFloor>() != null) ? this.Data1<ISlashAndTowerGotoNextFloor>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRoleTowerGotoNextFloor:
				_o.Data1.Value = ((this.Data1<IRoleTowerGotoNextFloor>() != null) ? this.Data1<IRoleTowerGotoNextFloor>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleEnter:
				_o.Data1.Value = ((this.Data1<IVehicleEnter>() != null) ? this.Data1<IVehicleEnter>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnterNpcVehicle:
				_o.Data1.Value = ((this.Data1<IEnterNpcVehicle>() != null) ? this.Data1<IEnterNpcVehicle>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleExitPlayer:
				_o.Data1.Value = ((this.Data1<IVehicleExitPlayer>() != null) ? this.Data1<IVehicleExitPlayer>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleExitNpc:
				_o.Data1.Value = ((this.Data1<IVehicleExitNpc>() != null) ? this.Data1<IVehicleExitNpc>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITeleportVehicle:
				_o.Data1.Value = ((this.Data1<ITeleportVehicle>() != null) ? this.Data1<ITeleportVehicle>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientTeleportVehicle:
				_o.Data1.Value = ((this.Data1<IClientTeleportVehicle>() != null) ? this.Data1<IClientTeleportVehicle>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehiclePlayPassengerVoice:
				_o.Data1.Value = ((this.Data1<IVehiclePlayPassengerVoice>() != null) ? this.Data1<IVehiclePlayPassengerVoice>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleWaterfallClimbing:
				_o.Data1.Value = ((this.Data1<IVehicleWaterfallClimbing>() != null) ? this.Data1<IVehicleWaterfallClimbing>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITeleportToAndEnterVehicle:
				_o.Data1.Value = ((this.Data1<ITeleportToAndEnterVehicle>() != null) ? this.Data1<ITeleportToAndEnterVehicle>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleMoveWithPathLine:
				_o.Data1.Value = ((this.Data1<IVehicleMoveWithPathLine>() != null) ? this.Data1<IVehicleMoveWithPathLine>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleSprint:
				_o.Data1.Value = ((this.Data1<IVehicleSprint>() != null) ? this.Data1<IVehicleSprint>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IOpenQteAction:
				_o.Data1.Value = ((this.Data1<IOpenQteAction>() != null) ? this.Data1<IOpenQteAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPlayerInput:
				_o.Data1.Value = ((this.Data1<IPlayerInput>() != null) ? this.Data1<IPlayerInput>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPreloadAction:
				_o.Data1.Value = ((this.Data1<IPreloadAction>() != null) ? this.Data1<IPreloadAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRemovePreloadResourceAction:
				_o.Data1.Value = ((this.Data1<IRemovePreloadResourceAction>() != null) ? this.Data1<IRemovePreloadResourceAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExecAlertSystemAction:
				_o.Data1.Value = ((this.Data1<IExecAlertSystemAction>() != null) ? this.Data1<IExecAlertSystemAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetSpineAnimation:
				_o.Data1.Value = ((this.Data1<ISetSpineAnimation>() != null) ? this.Data1<ISetSpineAnimation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeEntityCamp:
				_o.Data1.Value = ((this.Data1<IChangeEntityCamp>() != null) ? this.Data1<IChangeEntityCamp>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRecordDungeonEvent:
				_o.Data1.Value = ((this.Data1<IRecordDungeonEvent>() != null) ? this.Data1<IRecordDungeonEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDangoAbyssGotoNextFloor:
				_o.Data1.Value = ((this.Data1<IDangoAbyssGotoNextFloor>() != null) ? this.Data1<IDangoAbyssGotoNextFloor>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDangoAbyssCreateRewardTreasureBox:
				_o.Data1.Value = ((this.Data1<IDangoAbyssCreateRewardTreasureBox>() != null) ? this.Data1<IDangoAbyssCreateRewardTreasureBox>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDangoAbyssActivatePortal:
				_o.Data1.Value = ((this.Data1<IDangoAbyssActivatePortal>() != null) ? this.Data1<IDangoAbyssActivatePortal>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDangoAbyssReceiveReward:
				_o.Data1.Value = ((this.Data1<IDangoAbyssReceiveReward>() != null) ? this.Data1<IDangoAbyssReceiveReward>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRoverRogueActivate:
				_o.Data1.Value = ((this.Data1<IRoverRogueActivate>() != null) ? this.Data1<IRoverRogueActivate>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRoverRogueRoomFinish:
				_o.Data1.Value = ((this.Data1<IRoverRogueRoomFinish>() != null) ? this.Data1<IRoverRogueRoomFinish>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRoverRogueCreateRoomReward:
				_o.Data1.Value = ((this.Data1<IRoverRogueCreateRoomReward>() != null) ? this.Data1<IRoverRogueCreateRoomReward>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IGuestOperateUiAnimation:
				_o.Data1.Value = ((this.Data1<IGuestOperateUiAnimation>() != null) ? this.Data1<IGuestOperateUiAnimation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISlideRailStart:
				_o.Data1.Value = ((this.Data1<ISlideRailStart>() != null) ? this.Data1<ISlideRailStart>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISlideRailEnd:
				_o.Data1.Value = ((this.Data1<ISlideRailEnd>() != null) ? this.Data1<ISlideRailEnd>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISlidePerformStart:
				_o.Data1.Value = ((this.Data1<ISlidePerformStart>() != null) ? this.Data1<ISlidePerformStart>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBvbSendSystemEvent:
				_o.Data1.Value = ((this.Data1<IBvbSendSystemEvent>() != null) ? this.Data1<IBvbSendSystemEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBvbSendAiEvent:
				_o.Data1.Value = ((this.Data1<IBvbSendAiEvent>() != null) ? this.Data1<IBvbSendAiEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBvbPlayDialog:
				_o.Data1.Value = ((this.Data1<IBvbPlayDialog>() != null) ? this.Data1<IBvbPlayDialog>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBvbPlayerOperationConstraint:
				_o.Data1.Value = ((this.Data1<IBvbPlayerOperationConstraint>() != null) ? this.Data1<IBvbPlayerOperationConstraint>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBvbSkipChallenge:
				_o.Data1.Value = ((this.Data1<IBvbSkipChallenge>() != null) ? this.Data1<IBvbSkipChallenge>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IActiveAntiGravitySafePoint:
				_o.Data1.Value = ((this.Data1<IActiveAntiGravitySafePoint>() != null) ? this.Data1<IActiveAntiGravitySafePoint>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISummonEntity:
				_o.Data1.Value = ((this.Data1<ISummonEntity>() != null) ? this.Data1<ISummonEntity>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDestroySummonedEntities:
				_o.Data1.Value = ((this.Data1<IDestroySummonedEntities>() != null) ? this.Data1<IDestroySummonedEntities>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetupMoraleSystem:
				_o.Data1.Value = ((this.Data1<ISetupMoraleSystem>() != null) ? this.Data1<ISetupMoraleSystem>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IGiantToggleModel:
				_o.Data1.Value = ((this.Data1<IGiantToggleModel>() != null) ? this.Data1<IGiantToggleModel>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IGiantTriggerResponse:
				_o.Data1.Value = ((this.Data1<IGiantTriggerResponse>() != null) ? this.Data1<IGiantTriggerResponse>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IActivateGiantTotalProgressNode:
				_o.Data1.Value = ((this.Data1<IActivateGiantTotalProgressNode>() != null) ? this.Data1<IActivateGiantTotalProgressNode>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRunActorCustomEvent:
				_o.Data1.Value = ((this.Data1<IRunActorCustomEvent>() != null) ? this.Data1<IRunActorCustomEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITriggerSpecificScanEffect:
				_o.Data1.Value = ((this.Data1<ITriggerSpecificScanEffect>() != null) ? this.Data1<ITriggerSpecificScanEffect>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISendClientEvent:
				_o.Data1.Value = ((this.Data1<ISendClientEvent>() != null) ? this.Data1<ISendClientEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IScanEnrichmentArea:
				_o.Data1.Value = ((this.Data1<IScanEnrichmentArea>() != null) ? this.Data1<IScanEnrichmentArea>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRequestSystemFunction:
				_o.Data1.Value = ((this.Data1<IRequestSystemFunction>() != null) ? this.Data1<IRequestSystemFunction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsSetPropertyVisible:
				_o.Data1.Value = ((this.Data1<IReignsSetPropertyVisible>() != null) ? this.Data1<IReignsSetPropertyVisible>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsChangeBackground:
				_o.Data1.Value = ((this.Data1<IReignsChangeBackground>() != null) ? this.Data1<IReignsChangeBackground>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsSetUiEffect:
				_o.Data1.Value = ((this.Data1<IReignsSetUiEffect>() != null) ? this.Data1<IReignsSetUiEffect>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsChangePlayerName:
				_o.Data1.Value = ((this.Data1<IReignsChangePlayerName>() != null) ? this.Data1<IReignsChangePlayerName>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsCallCard:
				_o.Data1.Value = ((this.Data1<IReignsCallCard>() != null) ? this.Data1<IReignsCallCard>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsTriggerGuide:
				_o.Data1.Value = ((this.Data1<IReignsTriggerGuide>() != null) ? this.Data1<IReignsTriggerGuide>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsAddBuff:
				_o.Data1.Value = ((this.Data1<IReignsAddBuff>() != null) ? this.Data1<IReignsAddBuff>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReignsCheckSettle:
				_o.Data1.Value = ((this.Data1<IReignsCheckSettle>() != null) ? this.Data1<IReignsCheckSettle>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetNpcGroupPerform:
				_o.Data1.Value = ((this.Data1<ISetNpcGroupPerform>() != null) ? this.Data1<ISetNpcGroupPerform>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRemoveNpcGroupPerform:
				_o.Data1.Value = ((this.Data1<IRemoveNpcGroupPerform>() != null) ? this.Data1<IRemoveNpcGroupPerform>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableEntityLookAt:
				_o.Data1.Value = ((this.Data1<IEnableEntityLookAt>() != null) ? this.Data1<IEnableEntityLookAt>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDisableEntityLookAt:
				_o.Data1.Value = ((this.Data1<IDisableEntityLookAt>() != null) ? this.Data1<IDisableEntityLookAt>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IOverrideAiBehaviorTree:
				_o.Data1.Value = ((this.Data1<IOverrideAiBehaviorTree>() != null) ? this.Data1<IOverrideAiBehaviorTree>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRestoreAiBehaviorTree:
				_o.Data1.Value = ((this.Data1<IRestoreAiBehaviorTree>() != null) ? this.Data1<IRestoreAiBehaviorTree>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IFlowDefineNpcGroupPerform:
				_o.Data1.Value = ((this.Data1<IFlowDefineNpcGroupPerform>() != null) ? this.Data1<IFlowDefineNpcGroupPerform>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISeqEventAddTagToSelf:
				_o.Data1.Value = ((this.Data1<ISeqEventAddTagToSelf>() != null) ? this.Data1<ISeqEventAddTagToSelf>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISeqEventFireBullet:
				_o.Data1.Value = ((this.Data1<ISeqEventFireBullet>() != null) ? this.Data1<ISeqEventFireBullet>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITrapDefenseChangeMiniMap:
				_o.Data1.Value = ((this.Data1<ITrapDefenseChangeMiniMap>() != null) ? this.Data1<ITrapDefenseChangeMiniMap>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITrapDefensePlayerOperationConstraint:
				_o.Data1.Value = ((this.Data1<ITrapDefensePlayerOperationConstraint>() != null) ? this.Data1<ITrapDefensePlayerOperationConstraint>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHonamiStoryInteractPickUp:
				_o.Data1.Value = ((this.Data1<IHonamiStoryInteractPickUp>() != null) ? this.Data1<IHonamiStoryInteractPickUp>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHonamiStoryReceiveCorruptedChestReward:
				_o.Data1.Value = ((this.Data1<IHonamiStoryReceiveCorruptedChestReward>() != null) ? this.Data1<IHonamiStoryReceiveCorruptedChestReward>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHonamiStoryActivateSafeEvacuation:
				_o.Data1.Value = ((this.Data1<IHonamiStoryActivateSafeEvacuation>() != null) ? this.Data1<IHonamiStoryActivateSafeEvacuation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHonamiStorySetFormation:
				_o.Data1.Value = ((this.Data1<IHonamiStorySetFormation>() != null) ? this.Data1<IHonamiStorySetFormation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHonamiStoryGetItem:
				_o.Data1.Value = ((this.Data1<IHonamiStoryGetItem>() != null) ? this.Data1<IHonamiStoryGetItem>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IInfrActivityUpgradeInfrastructure:
				_o.Data1.Value = ((this.Data1<IInfrActivityUpgradeInfrastructure>() != null) ? this.Data1<IInfrActivityUpgradeInfrastructure>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPlayWalkingOverlayMontage:
				_o.Data1.Value = ((this.Data1<IPlayWalkingOverlayMontage>() != null) ? this.Data1<IPlayWalkingOverlayMontage>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnableKey4Func:
				_o.Data1.Value = ((this.Data1<IEnableKey4Func>() != null) ? this.Data1<IEnableKey4Func>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeNpcAbpState:
				_o.Data1.Value = ((this.Data1<IChangeNpcAbpState>() != null) ? this.Data1<IChangeNpcAbpState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IOverrideAbpAnimScheme:
				_o.Data1.Value = ((this.Data1<IOverrideAbpAnimScheme>() != null) ? this.Data1<IOverrideAbpAnimScheme>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ICloseWalkingOverlayMontage:
				_o.Data1.Value = ((this.Data1<ICloseWalkingOverlayMontage>() != null) ? this.Data1<ICloseWalkingOverlayMontage>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetMotorSpeed:
				_o.Data1.Value = ((this.Data1<ISetMotorSpeed>() != null) ? this.Data1<ISetMotorSpeed>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IVehicleSetSpeedImmediately:
				_o.Data1.Value = ((this.Data1<IVehicleSetSpeedImmediately>() != null) ? this.Data1<IVehicleSetSpeedImmediately>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IStartMotorCruise:
				_o.Data1.Value = ((this.Data1<IStartMotorCruise>() != null) ? this.Data1<IStartMotorCruise>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IStopMotorCruise:
				_o.Data1.Value = ((this.Data1<IStopMotorCruise>() != null) ? this.Data1<IStopMotorCruise>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDriveMotorInSpecConfig:
				_o.Data1.Value = ((this.Data1<IDriveMotorInSpecConfig>() != null) ? this.Data1<IDriveMotorInSpecConfig>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IMotorSoarInWindField:
				_o.Data1.Value = ((this.Data1<IMotorSoarInWindField>() != null) ? this.Data1<IMotorSoarInWindField>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetSkillBtnEffect:
				_o.Data1.Value = ((this.Data1<ISetSkillBtnEffect>() != null) ? this.Data1<ISetSkillBtnEffect>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ICollectSunSpirit:
				_o.Data1.Value = ((this.Data1<ICollectSunSpirit>() != null) ? this.Data1<ICollectSunSpirit>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPerformSunSpiritGearRoundTrip:
				_o.Data1.Value = ((this.Data1<IPerformSunSpiritGearRoundTrip>() != null) ? this.Data1<IPerformSunSpiritGearRoundTrip>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITriggerDeadeyeMode:
				_o.Data1.Value = ((this.Data1<ITriggerDeadeyeMode>() != null) ? this.Data1<ITriggerDeadeyeMode>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITriggerSystemRandomPlot:
				_o.Data1.Value = ((this.Data1<ITriggerSystemRandomPlot>() != null) ? this.Data1<ITriggerSystemRandomPlot>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetAudioEnable:
				_o.Data1.Value = ((this.Data1<ISetAudioEnable>() != null) ? this.Data1<ISetAudioEnable>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPhoneSystemInteract:
				_o.Data1.Value = ((this.Data1<IPhoneSystemInteract>() != null) ? this.Data1<IPhoneSystemInteract>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IRollBlockGetReward:
				_o.Data1.Value = ((this.Data1<IRollBlockGetReward>() != null) ? this.Data1<IRollBlockGetReward>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnterMovieMode:
				_o.Data1.Value = ((this.Data1<IEnterMovieMode>() != null) ? this.Data1<IEnterMovieMode>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExitMovieMode:
				_o.Data1.Value = ((this.Data1<IExitMovieMode>() != null) ? this.Data1<IExitMovieMode>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IStartRoadNetworkNavigation:
				_o.Data1.Value = ((this.Data1<IStartRoadNetworkNavigation>() != null) ? this.Data1<IStartRoadNetworkNavigation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetWayOccupancyState:
				_o.Data1.Value = ((this.Data1<ISetWayOccupancyState>() != null) ? this.Data1<ISetWayOccupancyState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IEnterPatrolState:
				_o.Data1.Value = ((this.Data1<IEnterPatrolState>() != null) ? this.Data1<IEnterPatrolState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IPerformAiHideSelf:
				_o.Data1.Value = ((this.Data1<IPerformAiHideSelf>() != null) ? this.Data1<IPerformAiHideSelf>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISendSceneActorEvent:
				_o.Data1.Value = ((this.Data1<ISendSceneActorEvent>() != null) ? this.Data1<ISendSceneActorEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IExecBpActorFunc:
				_o.Data1.Value = ((this.Data1<IExecBpActorFunc>() != null) ? this.Data1<IExecBpActorFunc>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IResetPlayerPosWithPresentation:
				_o.Data1.Value = ((this.Data1<IResetPlayerPosWithPresentation>() != null) ? this.Data1<IResetPlayerPosWithPresentation>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDrinksRollRoleRequirement:
				_o.Data1.Value = ((this.Data1<IDrinksRollRoleRequirement>() != null) ? this.Data1<IDrinksRollRoleRequirement>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetBlendAnim:
				_o.Data1.Value = ((this.Data1<ISetBlendAnim>() != null) ? this.Data1<ISetBlendAnim>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IReportTrackingEvent:
				_o.Data1.Value = ((this.Data1<IReportTrackingEvent>() != null) ? this.Data1<IReportTrackingEvent>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITetrisThrowBlock:
				_o.Data1.Value = ((this.Data1<ITetrisThrowBlock>() != null) ? this.Data1<ITetrisThrowBlock>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITetrisGameComplete:
				_o.Data1.Value = ((this.Data1<ITetrisGameComplete>() != null) ? this.Data1<ITetrisGameComplete>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ITetrisTriggerDelayFall:
				_o.Data1.Value = ((this.Data1<ITetrisTriggerDelayFall>() != null) ? this.Data1<ITetrisTriggerDelayFall>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBossPilingRandomBuff:
				_o.Data1.Value = ((this.Data1<IBossPilingRandomBuff>() != null) ? this.Data1<IBossPilingRandomBuff>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IBossPilingEnterNextInst:
				_o.Data1.Value = ((this.Data1<IBossPilingEnterNextInst>() != null) ? this.Data1<IBossPilingEnterNextInst>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IOpenQuickHackSystem:
				_o.Data1.Value = ((this.Data1<IOpenQuickHackSystem>() != null) ? this.Data1<IOpenQuickHackSystem>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IDollGrabItemDelivery:
				_o.Data1.Value = ((this.Data1<IDollGrabItemDelivery>() != null) ? this.Data1<IDollGrabItemDelivery>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISheriffUnlockClue:
				_o.Data1.Value = ((this.Data1<ISheriffUnlockClue>() != null) ? this.Data1<ISheriffUnlockClue>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISheriffUnlockProgress:
				_o.Data1.Value = ((this.Data1<ISheriffUnlockProgress>() != null) ? this.Data1<ISheriffUnlockProgress>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISheriffChangeCriminalState:
				_o.Data1.Value = ((this.Data1<ISheriffChangeCriminalState>() != null) ? this.Data1<ISheriffChangeCriminalState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISheriffChangeCriminalIdentity:
				_o.Data1.Value = ((this.Data1<ISheriffChangeCriminalIdentity>() != null) ? this.Data1<ISheriffChangeCriminalIdentity>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISheriffUnlockEnding:
				_o.Data1.Value = ((this.Data1<ISheriffUnlockEnding>() != null) ? this.Data1<ISheriffUnlockEnding>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetTargetElementalAbility:
				_o.Data1.Value = ((this.Data1<ISetTargetElementalAbility>() != null) ? this.Data1<ISetTargetElementalAbility>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IToggleEntityElementalAbility:
				_o.Data1.Value = ((this.Data1<IToggleEntityElementalAbility>() != null) ? this.Data1<IToggleEntityElementalAbility>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ICaptureElementalBox:
				_o.Data1.Value = ((this.Data1<ICaptureElementalBox>() != null) ? this.Data1<ICaptureElementalBox>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IChangeElementalBoxState:
				_o.Data1.Value = ((this.Data1<IChangeElementalBoxState>() != null) ? this.Data1<IChangeElementalBoxState>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISetElementalBoxToTarget:
				_o.Data1.Value = ((this.Data1<ISetElementalBoxToTarget>() != null) ? this.Data1<ISetElementalBoxToTarget>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISeasonWeatherSetRotationLock:
				_o.Data1.Value = ((this.Data1<ISeasonWeatherSetRotationLock>() != null) ? this.Data1<ISeasonWeatherSetRotationLock>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISeasonWeatherChangeTo:
				_o.Data1.Value = ((this.Data1<ISeasonWeatherChangeTo>() != null) ? this.Data1<ISeasonWeatherChangeTo>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ISeasonWeatherUnlockSpecial:
				_o.Data1.Value = ((this.Data1<ISeasonWeatherUnlockSpecial>() != null) ? this.Data1<ISeasonWeatherUnlockSpecial>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IHandBookModifySystemProgress:
				_o.Data1.Value = ((this.Data1<IHandBookModifySystemProgress>() != null) ? this.Data1<IHandBookModifySystemProgress>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.IClientExecEntityPrefabAction:
				_o.Data1.Value = ((this.Data1<IClientExecEntityPrefabAction>() != null) ? this.Data1<IClientExecEntityPrefabAction>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ILiveSetUi:
				_o.Data1.Value = ((this.Data1<ILiveSetUi>() != null) ? this.Data1<ILiveSetUi>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ILiveSetDanmaku:
				_o.Data1.Value = ((this.Data1<ILiveSetDanmaku>() != null) ? this.Data1<ILiveSetDanmaku>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ILiveSetParam:
				_o.Data1.Value = ((this.Data1<ILiveSetParam>() != null) ? this.Data1<ILiveSetParam>().Value.UnPack() : null);
				return;
			case IActionParams_Union_1.ILiveSetSc:
				_o.Data1.Value = ((this.Data1<ILiveSetSc>() != null) ? this.Data1<ILiveSetSc>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602C647 RID: 181831 RVA: 0x006135F8 File Offset: 0x006117F8
		public static Offset<IActionParams_Union> Pack(FlatBufferBuilder builder, IActionParams_UnionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionParams_Union>);
			}
			IActionParams_Union_0 data_0_type = (_o.Data0 == null) ? IActionParams_Union_0.NONE : _o.Data0.Type;
			int data_0Offset = (_o.Data0 == null) ? 0 : IActionParams_Union_0Union.Pack(builder, _o.Data0);
			IActionParams_Union_1 data_1_type = (_o.Data1 == null) ? IActionParams_Union_1.NONE : _o.Data1.Type;
			int data_1Offset = (_o.Data1 == null) ? 0 : IActionParams_Union_1Union.Pack(builder, _o.Data1);
			return IActionParams_Union.CreateIActionParams_Union(builder, _o.UnionIndex, data_0_type, data_0Offset, data_1_type, data_1Offset);
		}

		// Token: 0x04011053 RID: 69715
		private Table __p;
	}
}
