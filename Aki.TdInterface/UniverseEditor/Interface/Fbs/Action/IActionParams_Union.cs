using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006086 RID: 24710
	public struct IActionParams_Union : IFlatbufferObject
	{
		// Token: 0x1700B622 RID: 46626
		// (get) Token: 0x06029DB1 RID: 171441 RVA: 0x005BDC8E File Offset: 0x005BBE8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029DB2 RID: 171442 RVA: 0x005BDC9B File Offset: 0x005BBE9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029DB3 RID: 171443 RVA: 0x005BDCA4 File Offset: 0x005BBEA4
		public static IActionParams_Union GetRootAsIActionParams_Union(ByteBuffer _bb)
		{
			return IActionParams_Union.GetRootAsIActionParams_Union(_bb, default(IActionParams_Union));
		}

		// Token: 0x06029DB4 RID: 171444 RVA: 0x005BDCC0 File Offset: 0x005BBEC0
		public static IActionParams_Union GetRootAsIActionParams_Union(ByteBuffer _bb, IActionParams_Union obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029DB5 RID: 171445 RVA: 0x005BDCDD File Offset: 0x005BBEDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029DB6 RID: 171446 RVA: 0x005BDCEC File Offset: 0x005BBEEC
		public IActionParams_Union __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B623 RID: 46627
		// (get) Token: 0x06029DB7 RID: 171447 RVA: 0x005BDCFC File Offset: 0x005BBEFC
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

		// Token: 0x1700B624 RID: 46628
		// (get) Token: 0x06029DB8 RID: 171448 RVA: 0x005BDD38 File Offset: 0x005BBF38
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

		// Token: 0x06029DB9 RID: 171449 RVA: 0x005BDD74 File Offset: 0x005BBF74
		public TTable? Data0<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029DBA RID: 171450 RVA: 0x005BDDB8 File Offset: 0x005BBFB8
		public IActionParams Data0AsIActionParams()
		{
			return this.Data0<IActionParams>().Value;
		}

		// Token: 0x06029DBB RID: 171451 RVA: 0x005BDDD4 File Offset: 0x005BBFD4
		public IInvoke Data0AsIInvoke()
		{
			return this.Data0<IInvoke>().Value;
		}

		// Token: 0x06029DBC RID: 171452 RVA: 0x005BDDF0 File Offset: 0x005BBFF0
		public IInteract Data0AsIInteract()
		{
			return this.Data0<IInteract>().Value;
		}

		// Token: 0x06029DBD RID: 171453 RVA: 0x005BDE0C File Offset: 0x005BC00C
		public IFinishCondition Data0AsIFinishCondition()
		{
			return this.Data0<IFinishCondition>().Value;
		}

		// Token: 0x06029DBE RID: 171454 RVA: 0x005BDE28 File Offset: 0x005BC028
		public IGetRewardByInteract Data0AsIGetRewardByInteract()
		{
			return this.Data0<IGetRewardByInteract>().Value;
		}

		// Token: 0x06029DBF RID: 171455 RVA: 0x005BDE44 File Offset: 0x005BC044
		public IWaitUntilLevelSequenceReachMark Data0AsIWaitUntilLevelSequenceReachMark()
		{
			return this.Data0<IWaitUntilLevelSequenceReachMark>().Value;
		}

		// Token: 0x06029DC0 RID: 171456 RVA: 0x005BDE60 File Offset: 0x005BC060
		public IClearEntityVisibleTag Data0AsIClearEntityVisibleTag()
		{
			return this.Data0<IClearEntityVisibleTag>().Value;
		}

		// Token: 0x06029DC1 RID: 171457 RVA: 0x005BDE7C File Offset: 0x005BC07C
		public ISetEntityPos Data0AsISetEntityPos()
		{
			return this.Data0<ISetEntityPos>().Value;
		}

		// Token: 0x06029DC2 RID: 171458 RVA: 0x005BDE98 File Offset: 0x005BC098
		public IResetEntityPos Data0AsIResetEntityPos()
		{
			return this.Data0<IResetEntityPos>().Value;
		}

		// Token: 0x06029DC3 RID: 171459 RVA: 0x005BDEB4 File Offset: 0x005BC0B4
		public IServerSetPlayerPos Data0AsIServerSetPlayerPos()
		{
			return this.Data0<IServerSetPlayerPos>().Value;
		}

		// Token: 0x06029DC4 RID: 171460 RVA: 0x005BDED0 File Offset: 0x005BC0D0
		public IFixTeleControllerPos Data0AsIFixTeleControllerPos()
		{
			return this.Data0<IFixTeleControllerPos>().Value;
		}

		// Token: 0x06029DC5 RID: 171461 RVA: 0x005BDEEC File Offset: 0x005BC0EC
		public IFixTeleControllerResetPos Data0AsIFixTeleControllerResetPos()
		{
			return this.Data0<IFixTeleControllerResetPos>().Value;
		}

		// Token: 0x06029DC6 RID: 171462 RVA: 0x005BDF08 File Offset: 0x005BC108
		public IFixFoundationRelation Data0AsIFixFoundationRelation()
		{
			return this.Data0<IFixFoundationRelation>().Value;
		}

		// Token: 0x06029DC7 RID: 171463 RVA: 0x005BDF24 File Offset: 0x005BC124
		public ITraceCurrentQuest Data0AsITraceCurrentQuest()
		{
			return this.Data0<ITraceCurrentQuest>().Value;
		}

		// Token: 0x06029DC8 RID: 171464 RVA: 0x005BDF40 File Offset: 0x005BC140
		public IFixShowTargetRange Data0AsIFixShowTargetRange()
		{
			return this.Data0<IFixShowTargetRange>().Value;
		}

		// Token: 0x06029DC9 RID: 171465 RVA: 0x005BDF5C File Offset: 0x005BC15C
		public IFixGetItem Data0AsIFixGetItem()
		{
			return this.Data0<IFixGetItem>().Value;
		}

		// Token: 0x06029DCA RID: 171466 RVA: 0x005BDF78 File Offset: 0x005BC178
		public ILog Data0AsILog()
		{
			return this.Data0<ILog>().Value;
		}

		// Token: 0x06029DCB RID: 171467 RVA: 0x005BDF94 File Offset: 0x005BC194
		public IShowMessage Data0AsIShowMessage()
		{
			return this.Data0<IShowMessage>().Value;
		}

		// Token: 0x06029DCC RID: 171468 RVA: 0x005BDFB0 File Offset: 0x005BC1B0
		public IPrompt Data0AsIPrompt()
		{
			return this.Data0<IPrompt>().Value;
		}

		// Token: 0x06029DCD RID: 171469 RVA: 0x005BDFCC File Offset: 0x005BC1CC
		public ISendNpcMail Data0AsISendNpcMail()
		{
			return this.Data0<ISendNpcMail>().Value;
		}

		// Token: 0x06029DCE RID: 171470 RVA: 0x005BDFE8 File Offset: 0x005BC1E8
		public IAdjustTodTime Data0AsIAdjustTodTime()
		{
			return this.Data0<IAdjustTodTime>().Value;
		}

		// Token: 0x06029DCF RID: 171471 RVA: 0x005BE004 File Offset: 0x005BC204
		public ISetAreaTimeState Data0AsISetAreaTimeState()
		{
			return this.Data0<ISetAreaTimeState>().Value;
		}

		// Token: 0x06029DD0 RID: 171472 RVA: 0x005BE020 File Offset: 0x005BC220
		public ISetTimeScale Data0AsISetTimeScale()
		{
			return this.Data0<ISetTimeScale>().Value;
		}

		// Token: 0x06029DD1 RID: 171473 RVA: 0x005BE03C File Offset: 0x005BC23C
		public IJumpTalk Data0AsIJumpTalk()
		{
			return this.Data0<IJumpTalk>().Value;
		}

		// Token: 0x06029DD2 RID: 171474 RVA: 0x005BE058 File Offset: 0x005BC258
		public ISetHeadIconVisible Data0AsISetHeadIconVisible()
		{
			return this.Data0<ISetHeadIconVisible>().Value;
		}

		// Token: 0x06029DD3 RID: 171475 RVA: 0x005BE074 File Offset: 0x005BC274
		public IPlayMontage Data0AsIPlayMontage()
		{
			return this.Data0<IPlayMontage>().Value;
		}

		// Token: 0x06029DD4 RID: 171476 RVA: 0x005BE090 File Offset: 0x005BC290
		public IAvgPlayRoleAction Data0AsIAvgPlayRoleAction()
		{
			return this.Data0<IAvgPlayRoleAction>().Value;
		}

		// Token: 0x06029DD5 RID: 171477 RVA: 0x005BE0AC File Offset: 0x005BC2AC
		public IAvgMoveRole Data0AsIAvgMoveRole()
		{
			return this.Data0<IAvgMoveRole>().Value;
		}

		// Token: 0x06029DD6 RID: 171478 RVA: 0x005BE0C8 File Offset: 0x005BC2C8
		public IAvgFocusRole Data0AsIAvgFocusRole()
		{
			return this.Data0<IAvgFocusRole>().Value;
		}

		// Token: 0x06029DD7 RID: 171479 RVA: 0x005BE0E4 File Offset: 0x005BC2E4
		public IAvgShakeUi Data0AsIAvgShakeUi()
		{
			return this.Data0<IAvgShakeUi>().Value;
		}

		// Token: 0x06029DD8 RID: 171480 RVA: 0x005BE100 File Offset: 0x005BC300
		public IDestroyDynamicEntities Data0AsIDestroyDynamicEntities()
		{
			return this.Data0<IDestroyDynamicEntities>().Value;
		}

		// Token: 0x06029DD9 RID: 171481 RVA: 0x005BE11C File Offset: 0x005BC31C
		public IActorLookAt Data0AsIActorLookAt()
		{
			return this.Data0<IActorLookAt>().Value;
		}

		// Token: 0x06029DDA RID: 171482 RVA: 0x005BE138 File Offset: 0x005BC338
		public IActorTurnTo Data0AsIActorTurnTo()
		{
			return this.Data0<IActorTurnTo>().Value;
		}

		// Token: 0x06029DDB RID: 171483 RVA: 0x005BE154 File Offset: 0x005BC354
		public IShowTalk Data0AsIShowTalk()
		{
			return this.Data0<IShowTalk>().Value;
		}

		// Token: 0x06029DDC RID: 171484 RVA: 0x005BE170 File Offset: 0x005BC370
		public IFinishTalk Data0AsIFinishTalk()
		{
			return this.Data0<IFinishTalk>().Value;
		}

		// Token: 0x06029DDD RID: 171485 RVA: 0x005BE18C File Offset: 0x005BC38C
		public IShowCenterText Data0AsIShowCenterText()
		{
			return this.Data0<IShowCenterText>().Value;
		}

		// Token: 0x06029DDE RID: 171486 RVA: 0x005BE1A8 File Offset: 0x005BC3A8
		public IFinishState Data0AsIFinishState()
		{
			return this.Data0<IFinishState>().Value;
		}

		// Token: 0x06029DDF RID: 171487 RVA: 0x005BE1C4 File Offset: 0x005BC3C4
		public IChangeState Data0AsIChangeState()
		{
			return this.Data0<IChangeState>().Value;
		}

		// Token: 0x06029DE0 RID: 171488 RVA: 0x005BE1E0 File Offset: 0x005BC3E0
		public IChangeBehaviorState Data0AsIChangeBehaviorState()
		{
			return this.Data0<IChangeBehaviorState>().Value;
		}

		// Token: 0x06029DE1 RID: 171489 RVA: 0x005BE1FC File Offset: 0x005BC3FC
		public ISetBehaviorIsPaused Data0AsISetBehaviorIsPaused()
		{
			return this.Data0<ISetBehaviorIsPaused>().Value;
		}

		// Token: 0x06029DE2 RID: 171490 RVA: 0x005BE218 File Offset: 0x005BC418
		public IChangeRandomState Data0AsIChangeRandomState()
		{
			return this.Data0<IChangeRandomState>().Value;
		}

		// Token: 0x06029DE3 RID: 171491 RVA: 0x005BE234 File Offset: 0x005BC434
		public IChangeActorState Data0AsIChangeActorState()
		{
			return this.Data0<IChangeActorState>().Value;
		}

		// Token: 0x06029DE4 RID: 171492 RVA: 0x005BE250 File Offset: 0x005BC450
		public IChangeOtherState Data0AsIChangeOtherState()
		{
			return this.Data0<IChangeOtherState>().Value;
		}

		// Token: 0x06029DE5 RID: 171493 RVA: 0x005BE26C File Offset: 0x005BC46C
		public ISetCameraMode Data0AsISetCameraMode()
		{
			return this.Data0<ISetCameraMode>().Value;
		}

		// Token: 0x06029DE6 RID: 171494 RVA: 0x005BE288 File Offset: 0x005BC488
		public ISetPlotMode Data0AsISetPlotMode()
		{
			return this.Data0<ISetPlotMode>().Value;
		}

		// Token: 0x06029DE7 RID: 171495 RVA: 0x005BE2A4 File Offset: 0x005BC4A4
		public IPlaySequenceData Data0AsIPlaySequenceData()
		{
			return this.Data0<IPlaySequenceData>().Value;
		}

		// Token: 0x06029DE8 RID: 171496 RVA: 0x005BE2C0 File Offset: 0x005BC4C0
		public IPlayCustomSequence Data0AsIPlayCustomSequence()
		{
			return this.Data0<IPlayCustomSequence>().Value;
		}

		// Token: 0x06029DE9 RID: 171497 RVA: 0x005BE2DC File Offset: 0x005BC4DC
		public IPlayMovie Data0AsIPlayMovie()
		{
			return this.Data0<IPlayMovie>().Value;
		}

		// Token: 0x06029DEA RID: 171498 RVA: 0x005BE2F8 File Offset: 0x005BC4F8
		public IPlayEffect Data0AsIPlayEffect()
		{
			return this.Data0<IPlayEffect>().Value;
		}

		// Token: 0x06029DEB RID: 171499 RVA: 0x005BE314 File Offset: 0x005BC514
		public IPlayEffect2 Data0AsIPlayEffect2()
		{
			return this.Data0<IPlayEffect2>().Value;
		}

		// Token: 0x06029DEC RID: 171500 RVA: 0x005BE330 File Offset: 0x005BC530
		public IPlayCommonEffect Data0AsIPlayCommonEffect()
		{
			return this.Data0<IPlayCommonEffect>().Value;
		}

		// Token: 0x06029DED RID: 171501 RVA: 0x005BE34C File Offset: 0x005BC54C
		public IPlayScreenEffect Data0AsIPlayScreenEffect()
		{
			return this.Data0<IPlayScreenEffect>().Value;
		}

		// Token: 0x06029DEE RID: 171502 RVA: 0x005BE368 File Offset: 0x005BC568
		public ISwitchEffectState Data0AsISwitchEffectState()
		{
			return this.Data0<ISwitchEffectState>().Value;
		}

		// Token: 0x06029DEF RID: 171503 RVA: 0x005BE384 File Offset: 0x005BC584
		public IPlayDissolveEffect Data0AsIPlayDissolveEffect()
		{
			return this.Data0<IPlayDissolveEffect>().Value;
		}

		// Token: 0x06029DF0 RID: 171504 RVA: 0x005BE3A0 File Offset: 0x005BC5A0
		public IPlayMpcEffect Data0AsIPlayMpcEffect()
		{
			return this.Data0<IPlayMpcEffect>().Value;
		}

		// Token: 0x06029DF1 RID: 171505 RVA: 0x005BE3BC File Offset: 0x005BC5BC
		public IRemoveEffect Data0AsIRemoveEffect()
		{
			return this.Data0<IRemoveEffect>().Value;
		}

		// Token: 0x06029DF2 RID: 171506 RVA: 0x005BE3D8 File Offset: 0x005BC5D8
		public IWait Data0AsIWait()
		{
			return this.Data0<IWait>().Value;
		}

		// Token: 0x06029DF3 RID: 171507 RVA: 0x005BE3F4 File Offset: 0x005BC5F4
		public IMoveToPosA Data0AsIMoveToPosA()
		{
			return this.Data0<IMoveToPosA>().Value;
		}

		// Token: 0x06029DF4 RID: 171508 RVA: 0x005BE410 File Offset: 0x005BC610
		public ISetMoveSpeed Data0AsISetMoveSpeed()
		{
			return this.Data0<ISetMoveSpeed>().Value;
		}

		// Token: 0x06029DF5 RID: 171509 RVA: 0x005BE42C File Offset: 0x005BC62C
		public ISetPosA Data0AsISetPosA()
		{
			return this.Data0<ISetPosA>().Value;
		}

		// Token: 0x06029DF6 RID: 171510 RVA: 0x005BE448 File Offset: 0x005BC648
		public IFaceToPos Data0AsIFaceToPos()
		{
			return this.Data0<IFaceToPos>().Value;
		}

		// Token: 0x06029DF7 RID: 171511 RVA: 0x005BE464 File Offset: 0x005BC664
		public ISpawnChild Data0AsISpawnChild()
		{
			return this.Data0<ISpawnChild>().Value;
		}

		// Token: 0x06029DF8 RID: 171512 RVA: 0x005BE480 File Offset: 0x005BC680
		public ISimpleMove Data0AsISimpleMove()
		{
			return this.Data0<ISimpleMove>().Value;
		}

		// Token: 0x06029DF9 RID: 171513 RVA: 0x005BE49C File Offset: 0x005BC69C
		public ISetNumberVar Data0AsISetNumberVar()
		{
			return this.Data0<ISetNumberVar>().Value;
		}

		// Token: 0x06029DFA RID: 171514 RVA: 0x005BE4B8 File Offset: 0x005BC6B8
		public ISyncVarToActorState Data0AsISyncVarToActorState()
		{
			return this.Data0<ISyncVarToActorState>().Value;
		}

		// Token: 0x06029DFB RID: 171515 RVA: 0x005BE4D4 File Offset: 0x005BC6D4
		public IDoCalculate Data0AsIDoCalculate()
		{
			return this.Data0<IDoCalculate>().Value;
		}

		// Token: 0x06029DFC RID: 171516 RVA: 0x005BE4F0 File Offset: 0x005BC6F0
		public ICallByCondition Data0AsICallByCondition()
		{
			return this.Data0<ICallByCondition>().Value;
		}

		// Token: 0x06029DFD RID: 171517 RVA: 0x005BE50C File Offset: 0x005BC70C
		public ICallFunction Data0AsICallFunction()
		{
			return this.Data0<ICallFunction>().Value;
		}

		// Token: 0x06029DFE RID: 171518 RVA: 0x005BE528 File Offset: 0x005BC728
		public IAddFlowInteractOption Data0AsIAddFlowInteractOption()
		{
			return this.Data0<IAddFlowInteractOption>().Value;
		}

		// Token: 0x06029DFF RID: 171519 RVA: 0x005BE544 File Offset: 0x005BC744
		public IRemoveFlowInteractOption Data0AsIRemoveFlowInteractOption()
		{
			return this.Data0<IRemoveFlowInteractOption>().Value;
		}

		// Token: 0x06029E00 RID: 171520 RVA: 0x005BE560 File Offset: 0x005BC760
		public IChangeInteractOptionText Data0AsIChangeInteractOptionText()
		{
			return this.Data0<IChangeInteractOptionText>().Value;
		}

		// Token: 0x06029E01 RID: 171521 RVA: 0x005BE57C File Offset: 0x005BC77C
		public ISpawnEntity Data0AsISpawnEntity()
		{
			return this.Data0<ISpawnEntity>().Value;
		}

		// Token: 0x06029E02 RID: 171522 RVA: 0x005BE598 File Offset: 0x005BC798
		public IDestroyAllChild Data0AsIDestroyAllChild()
		{
			return this.Data0<IDestroyAllChild>().Value;
		}

		// Token: 0x06029E03 RID: 171523 RVA: 0x005BE5B4 File Offset: 0x005BC7B4
		public IDestroyEntity Data0AsIDestroyEntity()
		{
			return this.Data0<IDestroyEntity>().Value;
		}

		// Token: 0x06029E04 RID: 171524 RVA: 0x005BE5D0 File Offset: 0x005BC7D0
		public IPlayFlow Data0AsIPlayFlow()
		{
			return this.Data0<IPlayFlow>().Value;
		}

		// Token: 0x06029E05 RID: 171525 RVA: 0x005BE5EC File Offset: 0x005BC7EC
		public IBubbleData Data0AsIBubbleData()
		{
			return this.Data0<IBubbleData>().Value;
		}

		// Token: 0x06029E06 RID: 171526 RVA: 0x005BE608 File Offset: 0x005BC808
		public IPlayerLookAt Data0AsIPlayerLookAt()
		{
			return this.Data0<IPlayerLookAt>().Value;
		}

		// Token: 0x06029E07 RID: 171527 RVA: 0x005BE624 File Offset: 0x005BC824
		public IEntityLookAt Data0AsIEntityLookAt()
		{
			return this.Data0<IEntityLookAt>().Value;
		}

		// Token: 0x06029E08 RID: 171528 RVA: 0x005BE640 File Offset: 0x005BC840
		public ICharacterLookAt Data0AsICharacterLookAt()
		{
			return this.Data0<ICharacterLookAt>().Value;
		}

		// Token: 0x06029E09 RID: 171529 RVA: 0x005BE65C File Offset: 0x005BC85C
		public IPlayerLookTowards Data0AsIPlayerLookTowards()
		{
			return this.Data0<IPlayerLookTowards>().Value;
		}

		// Token: 0x06029E0A RID: 171530 RVA: 0x005BE678 File Offset: 0x005BC878
		public IEntityTurnTo Data0AsIEntityTurnTo()
		{
			return this.Data0<IEntityTurnTo>().Value;
		}

		// Token: 0x06029E0B RID: 171531 RVA: 0x005BE694 File Offset: 0x005BC894
		public ICameraLookAt Data0AsICameraLookAt()
		{
			return this.Data0<ICameraLookAt>().Value;
		}

		// Token: 0x06029E0C RID: 171532 RVA: 0x005BE6B0 File Offset: 0x005BC8B0
		public IStopCameraLookAt Data0AsIStopCameraLookAt()
		{
			return this.Data0<IStopCameraLookAt>().Value;
		}

		// Token: 0x06029E0D RID: 171533 RVA: 0x005BE6CC File Offset: 0x005BC8CC
		public ISetVar Data0AsISetVar()
		{
			return this.Data0<ISetVar>().Value;
		}

		// Token: 0x06029E0E RID: 171534 RVA: 0x005BE6E8 File Offset: 0x005BC8E8
		public ISetActorVar Data0AsISetActorVar()
		{
			return this.Data0<ISetActorVar>().Value;
		}

		// Token: 0x06029E0F RID: 171535 RVA: 0x005BE704 File Offset: 0x005BC904
		public ICalculateVar Data0AsICalculateVar()
		{
			return this.Data0<ICalculateVar>().Value;
		}

		// Token: 0x06029E10 RID: 171536 RVA: 0x005BE720 File Offset: 0x005BC920
		public IRandomVar Data0AsIRandomVar()
		{
			return this.Data0<IRandomVar>().Value;
		}

		// Token: 0x06029E11 RID: 171537 RVA: 0x005BE73C File Offset: 0x005BC93C
		public IGuideTrigger Data0AsIGuideTrigger()
		{
			return this.Data0<IGuideTrigger>().Value;
		}

		// Token: 0x06029E12 RID: 171538 RVA: 0x005BE758 File Offset: 0x005BC958
		public ICompleteGuide Data0AsICompleteGuide()
		{
			return this.Data0<ICompleteGuide>().Value;
		}

		// Token: 0x06029E13 RID: 171539 RVA: 0x005BE774 File Offset: 0x005BC974
		public IGetItem Data0AsIGetItem()
		{
			return this.Data0<IGetItem>().Value;
		}

		// Token: 0x06029E14 RID: 171540 RVA: 0x005BE790 File Offset: 0x005BC990
		public IDestroyQuestItem Data0AsIDestroyQuestItem()
		{
			return this.Data0<IDestroyQuestItem>().Value;
		}

		// Token: 0x06029E15 RID: 171541 RVA: 0x005BE7AC File Offset: 0x005BC9AC
		public IAwakeEntity Data0AsIAwakeEntity()
		{
			return this.Data0<IAwakeEntity>().Value;
		}

		// Token: 0x06029E16 RID: 171542 RVA: 0x005BE7C8 File Offset: 0x005BC9C8
		public ISetEntityVisible Data0AsISetEntityVisible()
		{
			return this.Data0<ISetEntityVisible>().Value;
		}

		// Token: 0x06029E17 RID: 171543 RVA: 0x005BE7E4 File Offset: 0x005BC9E4
		public ISetEntityClientVisible Data0AsISetEntityClientVisible()
		{
			return this.Data0<ISetEntityClientVisible>().Value;
		}

		// Token: 0x06029E18 RID: 171544 RVA: 0x005BE800 File Offset: 0x005BCA00
		public ISetEntityClientVisibleSave Data0AsISetEntityClientVisibleSave()
		{
			return this.Data0<ISetEntityClientVisibleSave>().Value;
		}

		// Token: 0x06029E19 RID: 171545 RVA: 0x005BE81C File Offset: 0x005BCA1C
		public ILockEntity Data0AsILockEntity()
		{
			return this.Data0<ILockEntity>().Value;
		}

		// Token: 0x06029E1A RID: 171546 RVA: 0x005BE838 File Offset: 0x005BCA38
		public IUnlockEntity Data0AsIUnlockEntity()
		{
			return this.Data0<IUnlockEntity>().Value;
		}

		// Token: 0x06029E1B RID: 171547 RVA: 0x005BE854 File Offset: 0x005BCA54
		public ICompleteChildQuest Data0AsICompleteChildQuest()
		{
			return this.Data0<ICompleteChildQuest>().Value;
		}

		// Token: 0x06029E1C RID: 171548 RVA: 0x005BE870 File Offset: 0x005BCA70
		public IAcceptCurrentQuest Data0AsIAcceptCurrentQuest()
		{
			return this.Data0<IAcceptCurrentQuest>().Value;
		}

		// Token: 0x06029E1D RID: 171549 RVA: 0x005BE88C File Offset: 0x005BCA8C
		public IFinishDoInteract Data0AsIFinishDoInteract()
		{
			return this.Data0<IFinishDoInteract>().Value;
		}

		// Token: 0x06029E1E RID: 171550 RVA: 0x005BE8A8 File Offset: 0x005BCAA8
		public IAddBuffToEntity Data0AsIAddBuffToEntity()
		{
			return this.Data0<IAddBuffToEntity>().Value;
		}

		// Token: 0x06029E1F RID: 171551 RVA: 0x005BE8C4 File Offset: 0x005BCAC4
		public IAddBuffToPlayer Data0AsIAddBuffToPlayer()
		{
			return this.Data0<IAddBuffToPlayer>().Value;
		}

		// Token: 0x06029E20 RID: 171552 RVA: 0x005BE8E0 File Offset: 0x005BCAE0
		public IAddBuffToFollowShooter Data0AsIAddBuffToFollowShooter()
		{
			return this.Data0<IAddBuffToFollowShooter>().Value;
		}

		// Token: 0x06029E21 RID: 171553 RVA: 0x005BE8FC File Offset: 0x005BCAFC
		public IOpenSystemBoard Data0AsIOpenSystemBoard()
		{
			return this.Data0<IOpenSystemBoard>().Value;
		}

		// Token: 0x06029E22 RID: 171554 RVA: 0x005BE918 File Offset: 0x005BCB18
		public IOpenSystemFunction Data0AsIOpenSystemFunction()
		{
			return this.Data0<IOpenSystemFunction>().Value;
		}

		// Token: 0x06029E23 RID: 171555 RVA: 0x005BE934 File Offset: 0x005BCB34
		public IChangeEntityState Data0AsIChangeEntityState()
		{
			return this.Data0<IChangeEntityState>().Value;
		}

		// Token: 0x06029E24 RID: 171556 RVA: 0x005BE950 File Offset: 0x005BCB50
		public IChangeEntityStateDirectly Data0AsIChangeEntityStateDirectly()
		{
			return this.Data0<IChangeEntityStateDirectly>().Value;
		}

		// Token: 0x06029E25 RID: 171557 RVA: 0x005BE96C File Offset: 0x005BCB6C
		public IChangeEntityStateBatchDirectly Data0AsIChangeEntityStateBatchDirectly()
		{
			return this.Data0<IChangeEntityStateBatchDirectly>().Value;
		}

		// Token: 0x06029E26 RID: 171558 RVA: 0x005BE988 File Offset: 0x005BCB88
		public IChangeEntityStateLoop Data0AsIChangeEntityStateLoop()
		{
			return this.Data0<IChangeEntityStateLoop>().Value;
		}

		// Token: 0x06029E27 RID: 171559 RVA: 0x005BE9A4 File Offset: 0x005BCBA4
		public IChangeNpcPerformState Data0AsIChangeNpcPerformState()
		{
			return this.Data0<IChangeNpcPerformState>().Value;
		}

		// Token: 0x06029E28 RID: 171560 RVA: 0x005BE9C0 File Offset: 0x005BCBC0
		public ISetForceLock Data0AsISetForceLock()
		{
			return this.Data0<ISetForceLock>().Value;
		}

		// Token: 0x06029E29 RID: 171561 RVA: 0x005BE9DC File Offset: 0x005BCBDC
		public ISetAreaState Data0AsISetAreaState()
		{
			return this.Data0<ISetAreaState>().Value;
		}

		// Token: 0x06029E2A RID: 171562 RVA: 0x005BE9F8 File Offset: 0x005BCBF8
		public ISetWuYinQuState Data0AsISetWuYinQuState()
		{
			return this.Data0<ISetWuYinQuState>().Value;
		}

		// Token: 0x06029E2B RID: 171563 RVA: 0x005BEA14 File Offset: 0x005BCC14
		public IRemoveBuffFromEntity Data0AsIRemoveBuffFromEntity()
		{
			return this.Data0<IRemoveBuffFromEntity>().Value;
		}

		// Token: 0x06029E2C RID: 171564 RVA: 0x005BEA30 File Offset: 0x005BCC30
		public IRemoveBuffFromPlayer Data0AsIRemoveBuffFromPlayer()
		{
			return this.Data0<IRemoveBuffFromPlayer>().Value;
		}

		// Token: 0x06029E2D RID: 171565 RVA: 0x005BEA4C File Offset: 0x005BCC4C
		public ICollect Data0AsICollect()
		{
			return this.Data0<ICollect>().Value;
		}

		// Token: 0x06029E2E RID: 171566 RVA: 0x005BEA68 File Offset: 0x005BCC68
		public IDestroy Data0AsIDestroy()
		{
			return this.Data0<IDestroy>().Value;
		}

		// Token: 0x06029E2F RID: 171567 RVA: 0x005BEA84 File Offset: 0x005BCC84
		public IDestroySelf Data0AsIDestroySelf()
		{
			return this.Data0<IDestroySelf>().Value;
		}

		// Token: 0x06029E30 RID: 171568 RVA: 0x005BEAA0 File Offset: 0x005BCCA0
		public ISetPlayerMoveControl Data0AsISetPlayerMoveControl()
		{
			return this.Data0<ISetPlayerMoveControl>().Value;
		}

		// Token: 0x06029E31 RID: 171569 RVA: 0x005BEABC File Offset: 0x005BCCBC
		public IUnlockTeleportTrigger Data0AsIUnlockTeleportTrigger()
		{
			return this.Data0<IUnlockTeleportTrigger>().Value;
		}

		// Token: 0x06029E32 RID: 171570 RVA: 0x005BEAD8 File Offset: 0x005BCCD8
		public IChangeTeamPosition Data0AsIChangeTeamPosition()
		{
			return this.Data0<IChangeTeamPosition>().Value;
		}

		// Token: 0x06029E33 RID: 171571 RVA: 0x005BEAF4 File Offset: 0x005BCCF4
		public IClientChangeTeamPosition Data0AsIClientChangeTeamPosition()
		{
			return this.Data0<IClientChangeTeamPosition>().Value;
		}

		// Token: 0x06029E34 RID: 171572 RVA: 0x005BEB10 File Offset: 0x005BCD10
		public IClaimLevelPlayReward Data0AsIClaimLevelPlayReward()
		{
			return this.Data0<IClaimLevelPlayReward>().Value;
		}

		// Token: 0x06029E35 RID: 171573 RVA: 0x005BEB2C File Offset: 0x005BCD2C
		public IClaimDynamicEntityReward Data0AsIClaimDynamicEntityReward()
		{
			return this.Data0<IClaimDynamicEntityReward>().Value;
		}

		// Token: 0x06029E36 RID: 171574 RVA: 0x005BEB48 File Offset: 0x005BCD48
		public IClearFishingCabinInSaleItems Data0AsIClearFishingCabinInSaleItems()
		{
			return this.Data0<IClearFishingCabinInSaleItems>().Value;
		}

		// Token: 0x06029E37 RID: 171575 RVA: 0x005BEB64 File Offset: 0x005BCD64
		public IAcceptFishingEntrust Data0AsIAcceptFishingEntrust()
		{
			return this.Data0<IAcceptFishingEntrust>().Value;
		}

		// Token: 0x06029E38 RID: 171576 RVA: 0x005BEB80 File Offset: 0x005BCD80
		public IDestroyFishingBoat Data0AsIDestroyFishingBoat()
		{
			return this.Data0<IDestroyFishingBoat>().Value;
		}

		// Token: 0x06029E39 RID: 171577 RVA: 0x005BEB9C File Offset: 0x005BCD9C
		public ITeleportDungeon Data0AsITeleportDungeon()
		{
			return this.Data0<ITeleportDungeon>().Value;
		}

		// Token: 0x06029E3A RID: 171578 RVA: 0x005BEBB8 File Offset: 0x005BCDB8
		public IStopUiScreenEffect Data0AsIStopUiScreenEffect()
		{
			return this.Data0<IStopUiScreenEffect>().Value;
		}

		// Token: 0x06029E3B RID: 171579 RVA: 0x005BEBD4 File Offset: 0x005BCDD4
		public IClaimDungeonReward Data0AsIClaimDungeonReward()
		{
			return this.Data0<IClaimDungeonReward>().Value;
		}

		// Token: 0x06029E3C RID: 171580 RVA: 0x005BEBF0 File Offset: 0x005BCDF0
		public ISettlementDungeon Data0AsISettlementDungeon()
		{
			return this.Data0<ISettlementDungeon>().Value;
		}

		// Token: 0x06029E3D RID: 171581 RVA: 0x005BEC0C File Offset: 0x005BCE0C
		public IExitDungeon Data0AsIExitDungeon()
		{
			return this.Data0<IExitDungeon>().Value;
		}

		// Token: 0x06029E3E RID: 171582 RVA: 0x005BEC28 File Offset: 0x005BCE28
		public IUnlockDungeonEntry Data0AsIUnlockDungeonEntry()
		{
			return this.Data0<IUnlockDungeonEntry>().Value;
		}

		// Token: 0x06029E3F RID: 171583 RVA: 0x005BEC44 File Offset: 0x005BCE44
		public IFinishDungeon Data0AsIFinishDungeon()
		{
			return this.Data0<IFinishDungeon>().Value;
		}

		// Token: 0x06029E40 RID: 171584 RVA: 0x005BEC60 File Offset: 0x005BCE60
		public ISetReviveRegion Data0AsISetReviveRegion()
		{
			return this.Data0<ISetReviveRegion>().Value;
		}

		// Token: 0x06029E41 RID: 171585 RVA: 0x005BEC7C File Offset: 0x005BCE7C
		public IPromptQuestChapterUI Data0AsIPromptQuestChapterUI()
		{
			return this.Data0<IPromptQuestChapterUI>().Value;
		}

		// Token: 0x06029E42 RID: 171586 RVA: 0x005BEC98 File Offset: 0x005BCE98
		public IFireBullet Data0AsIFireBullet()
		{
			return this.Data0<IFireBullet>().Value;
		}

		// Token: 0x06029E43 RID: 171587 RVA: 0x005BECB4 File Offset: 0x005BCEB4
		public IFireBulletEffect Data0AsIFireBulletEffect()
		{
			return this.Data0<IFireBulletEffect>().Value;
		}

		// Token: 0x06029E44 RID: 171588 RVA: 0x005BECD0 File Offset: 0x005BCED0
		public ISetPlayerPos Data0AsISetPlayerPos()
		{
			return this.Data0<ISetPlayerPos>().Value;
		}

		// Token: 0x06029E45 RID: 171589 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public IClientSetPlayerPos Data0AsIClientSetPlayerPos()
		{
			return this.Data0<IClientSetPlayerPos>().Value;
		}

		// Token: 0x06029E46 RID: 171590 RVA: 0x005BED08 File Offset: 0x005BCF08
		public IClientPreEnableSubLevels Data0AsIClientPreEnableSubLevels()
		{
			return this.Data0<IClientPreEnableSubLevels>().Value;
		}

		// Token: 0x06029E47 RID: 171591 RVA: 0x005BED24 File Offset: 0x005BCF24
		public IRogueGotoNextFloor Data0AsIRogueGotoNextFloor()
		{
			return this.Data0<IRogueGotoNextFloor>().Value;
		}

		// Token: 0x06029E48 RID: 171592 RVA: 0x005BED40 File Offset: 0x005BCF40
		public IRogueSelectRoom Data0AsIRogueSelectRoom()
		{
			return this.Data0<IRogueSelectRoom>().Value;
		}

		// Token: 0x06029E49 RID: 171593 RVA: 0x005BED5C File Offset: 0x005BCF5C
		public IRogueActivatePortal Data0AsIRogueActivatePortal()
		{
			return this.Data0<IRogueActivatePortal>().Value;
		}

		// Token: 0x06029E4A RID: 171594 RVA: 0x005BED78 File Offset: 0x005BCF78
		public IRogueReceiveReward Data0AsIRogueReceiveReward()
		{
			return this.Data0<IRogueReceiveReward>().Value;
		}

		// Token: 0x06029E4B RID: 171595 RVA: 0x005BED94 File Offset: 0x005BCF94
		public IChangeSelfEntityState Data0AsIChangeSelfEntityState()
		{
			return this.Data0<IChangeSelfEntityState>().Value;
		}

		// Token: 0x06029E4C RID: 171596 RVA: 0x005BEDB0 File Offset: 0x005BCFB0
		public IInterludeActions Data0AsIInterludeActions()
		{
			return this.Data0<IInterludeActions>().Value;
		}

		// Token: 0x06029E4D RID: 171597 RVA: 0x005BEDCC File Offset: 0x005BCFCC
		public IAddBuffToTriggeredEntity Data0AsIAddBuffToTriggeredEntity()
		{
			return this.Data0<IAddBuffToTriggeredEntity>().Value;
		}

		// Token: 0x06029E4E RID: 171598 RVA: 0x005BEDE8 File Offset: 0x005BCFE8
		public IRemoveBuffToTriggeredEntity Data0AsIRemoveBuffToTriggeredEntity()
		{
			return this.Data0<IRemoveBuffToTriggeredEntity>().Value;
		}

		// Token: 0x06029E4F RID: 171599 RVA: 0x005BEE04 File Offset: 0x005BD004
		public IDetectTrigger Data0AsIDetectTrigger()
		{
			return this.Data0<IDetectTrigger>().Value;
		}

		// Token: 0x06029E50 RID: 171600 RVA: 0x005BEE20 File Offset: 0x005BD020
		public IItemFoundationMatch Data0AsIItemFoundationMatch()
		{
			return this.Data0<IItemFoundationMatch>().Value;
		}

		// Token: 0x06029E51 RID: 171601 RVA: 0x005BEE3C File Offset: 0x005BD03C
		public ISetBattleState Data0AsISetBattleState()
		{
			return this.Data0<ISetBattleState>().Value;
		}

		// Token: 0x06029E52 RID: 171602 RVA: 0x005BEE58 File Offset: 0x005BD058
		public IExecBattleAction Data0AsIExecBattleAction()
		{
			return this.Data0<IExecBattleAction>().Value;
		}

		// Token: 0x06029E53 RID: 171603 RVA: 0x005BEE74 File Offset: 0x005BD074
		public IExecClientMonsterNpcInteract Data0AsIExecClientMonsterNpcInteract()
		{
			return this.Data0<IExecClientMonsterNpcInteract>().Value;
		}

		// Token: 0x06029E54 RID: 171604 RVA: 0x005BEE90 File Offset: 0x005BD090
		public IExecClientBattleAction Data0AsIExecClientBattleAction()
		{
			return this.Data0<IExecClientBattleAction>().Value;
		}

		// Token: 0x06029E55 RID: 171605 RVA: 0x005BEEAC File Offset: 0x005BD0AC
		public IWaitBattleCondition Data0AsIWaitBattleCondition()
		{
			return this.Data0<IWaitBattleCondition>().Value;
		}

		// Token: 0x06029E56 RID: 171606 RVA: 0x005BEEC8 File Offset: 0x005BD0C8
		public IEnableHostility Data0AsIEnableHostility()
		{
			return this.Data0<IEnableHostility>().Value;
		}

		// Token: 0x06029E57 RID: 171607 RVA: 0x005BEEE4 File Offset: 0x005BD0E4
		public IUnlockSystemItem Data0AsIUnlockSystemItem()
		{
			return this.Data0<IUnlockSystemItem>().Value;
		}

		// Token: 0x06029E58 RID: 171608 RVA: 0x005BEF00 File Offset: 0x005BD100
		public IClientUnlockAchievementSystemItem Data0AsIClientUnlockAchievementSystemItem()
		{
			return this.Data0<IClientUnlockAchievementSystemItem>().Value;
		}

		// Token: 0x06029E59 RID: 171609 RVA: 0x005BEF1C File Offset: 0x005BD11C
		public IAddPlayBubble Data0AsIAddPlayBubble()
		{
			return this.Data0<IAddPlayBubble>().Value;
		}

		// Token: 0x06029E5A RID: 171610 RVA: 0x005BEF38 File Offset: 0x005BD138
		public IPlayBubble Data0AsIPlayBubble()
		{
			return this.Data0<IPlayBubble>().Value;
		}

		// Token: 0x06029E5B RID: 171611 RVA: 0x005BEF54 File Offset: 0x005BD154
		public IClearPlayBubble Data0AsIClearPlayBubble()
		{
			return this.Data0<IClearPlayBubble>().Value;
		}

		// Token: 0x06029E5C RID: 171612 RVA: 0x005BEF70 File Offset: 0x005BD170
		public IMoveWithSpline Data0AsIMoveWithSpline()
		{
			return this.Data0<IMoveWithSpline>().Value;
		}

		// Token: 0x06029E5D RID: 171613 RVA: 0x005BEF8C File Offset: 0x005BD18C
		public INewMoveWithSpline Data0AsINewMoveWithSpline()
		{
			return this.Data0<INewMoveWithSpline>().Value;
		}

		// Token: 0x06029E5E RID: 171614 RVA: 0x005BEFA8 File Offset: 0x005BD1A8
		public IStopNewMoveWithSpline Data0AsIStopNewMoveWithSpline()
		{
			return this.Data0<IStopNewMoveWithSpline>().Value;
		}

		// Token: 0x06029E5F RID: 171615 RVA: 0x005BEFC4 File Offset: 0x005BD1C4
		public ICharacterMoveToPoint Data0AsICharacterMoveToPoint()
		{
			return this.Data0<ICharacterMoveToPoint>().Value;
		}

		// Token: 0x06029E60 RID: 171616 RVA: 0x005BEFE0 File Offset: 0x005BD1E0
		public IPlayerMoveToPoint Data0AsIPlayerMoveToPoint()
		{
			return this.Data0<IPlayerMoveToPoint>().Value;
		}

		// Token: 0x06029E61 RID: 171617 RVA: 0x005BEFFC File Offset: 0x005BD1FC
		public INpcMoveToPoint Data0AsINpcMoveToPoint()
		{
			return this.Data0<INpcMoveToPoint>().Value;
		}

		// Token: 0x06029E62 RID: 171618 RVA: 0x005BF018 File Offset: 0x005BD218
		public IToggleScanSplineEffect Data0AsIToggleScanSplineEffect()
		{
			return this.Data0<IToggleScanSplineEffect>().Value;
		}

		// Token: 0x06029E63 RID: 171619 RVA: 0x005BF034 File Offset: 0x005BD234
		public IOpenTraceSpline Data0AsIOpenTraceSpline()
		{
			return this.Data0<IOpenTraceSpline>().Value;
		}

		// Token: 0x06029E64 RID: 171620 RVA: 0x005BF050 File Offset: 0x005BD250
		public ICloseTraceSpline Data0AsICloseTraceSpline()
		{
			return this.Data0<ICloseTraceSpline>().Value;
		}

		// Token: 0x06029E65 RID: 171621 RVA: 0x005BF06C File Offset: 0x005BD26C
		public ITraceSpline Data0AsITraceSpline()
		{
			return this.Data0<ITraceSpline>().Value;
		}

		// Token: 0x06029E66 RID: 171622 RVA: 0x005BF088 File Offset: 0x005BD288
		public IEnableAI Data0AsIEnableAI()
		{
			return this.Data0<IEnableAI>().Value;
		}

		// Token: 0x06029E67 RID: 171623 RVA: 0x005BF0A4 File Offset: 0x005BD2A4
		public IRunActions Data0AsIRunActions()
		{
			return this.Data0<IRunActions>().Value;
		}

		// Token: 0x06029E68 RID: 171624 RVA: 0x005BF0C0 File Offset: 0x005BD2C0
		public ICommonTip Data0AsICommonTip()
		{
			return this.Data0<ICommonTip>().Value;
		}

		// Token: 0x06029E69 RID: 171625 RVA: 0x005BF0DC File Offset: 0x005BD2DC
		public ICommonTip2 Data0AsICommonTip2()
		{
			return this.Data0<ICommonTip2>().Value;
		}

		// Token: 0x06029E6A RID: 171626 RVA: 0x005BF0F8 File Offset: 0x005BD2F8
		public IEndCommonTip Data0AsIEndCommonTip()
		{
			return this.Data0<IEndCommonTip>().Value;
		}

		// Token: 0x06029E6B RID: 171627 RVA: 0x005BF114 File Offset: 0x005BD314
		public IEnableNearbyTracking Data0AsIEnableNearbyTracking()
		{
			return this.Data0<IEnableNearbyTracking>().Value;
		}

		// Token: 0x06029E6C RID: 171628 RVA: 0x005BF130 File Offset: 0x005BD330
		public ISendAiEvent Data0AsISendAiEvent()
		{
			return this.Data0<ISendAiEvent>().Value;
		}

		// Token: 0x06029E6D RID: 171629 RVA: 0x005BF14C File Offset: 0x005BD34C
		public IEnableLevelPlay Data0AsIEnableLevelPlay()
		{
			return this.Data0<IEnableLevelPlay>().Value;
		}

		// Token: 0x06029E6E RID: 171630 RVA: 0x005BF168 File Offset: 0x005BD368
		public IServerForceEnableLevelPlay Data0AsIServerForceEnableLevelPlay()
		{
			return this.Data0<IServerForceEnableLevelPlay>().Value;
		}

		// Token: 0x06029E6F RID: 171631 RVA: 0x005BF184 File Offset: 0x005BD384
		public ITeleportDungeonPos Data0AsITeleportDungeonPos()
		{
			return this.Data0<ITeleportDungeonPos>().Value;
		}

		// Token: 0x06029E70 RID: 171632 RVA: 0x005BF1A0 File Offset: 0x005BD3A0
		public IFadeInScreen Data0AsIFadeInScreen()
		{
			return this.Data0<IFadeInScreen>().Value;
		}

		// Token: 0x06029E71 RID: 171633 RVA: 0x005BF1BC File Offset: 0x005BD3BC
		public IFadeOutScreen Data0AsIFadeOutScreen()
		{
			return this.Data0<IFadeOutScreen>().Value;
		}

		// Token: 0x06029E72 RID: 171634 RVA: 0x005BF1D8 File Offset: 0x005BD3D8
		public IStartFlowTemplate Data0AsIStartFlowTemplate()
		{
			return this.Data0<IStartFlowTemplate>().Value;
		}

		// Token: 0x06029E73 RID: 171635 RVA: 0x005BF1F4 File Offset: 0x005BD3F4
		public IEndFlowTemplate Data0AsIEndFlowTemplate()
		{
			return this.Data0<IEndFlowTemplate>().Value;
		}

		// Token: 0x06029E74 RID: 171636 RVA: 0x005BF210 File Offset: 0x005BD410
		public ICloseFlowTemplate Data0AsICloseFlowTemplate()
		{
			return this.Data0<ICloseFlowTemplate>().Value;
		}

		// Token: 0x06029E75 RID: 171637 RVA: 0x005BF22C File Offset: 0x005BD42C
		public IChangeFlowTemplate Data0AsIChangeFlowTemplate()
		{
			return this.Data0<IChangeFlowTemplate>().Value;
		}

		// Token: 0x06029E76 RID: 171638 RVA: 0x005BF248 File Offset: 0x005BD448
		public IBeginFlowTemplate Data0AsIBeginFlowTemplate()
		{
			return this.Data0<IBeginFlowTemplate>().Value;
		}

		// Token: 0x06029E77 RID: 171639 RVA: 0x005BF264 File Offset: 0x005BD464
		public ISetFlowTemplate Data0AsISetFlowTemplate()
		{
			return this.Data0<ISetFlowTemplate>().Value;
		}

		// Token: 0x06029E78 RID: 171640 RVA: 0x005BF280 File Offset: 0x005BD480
		public IHideTargetRange Data0AsIHideTargetRange()
		{
			return this.Data0<IHideTargetRange>().Value;
		}

		// Token: 0x06029E79 RID: 171641 RVA: 0x005BF29C File Offset: 0x005BD49C
		public IShowTargetRange Data0AsIShowTargetRange()
		{
			return this.Data0<IShowTargetRange>().Value;
		}

		// Token: 0x06029E7A RID: 171642 RVA: 0x005BF2B8 File Offset: 0x005BD4B8
		public IHideSpecificEntities Data0AsIHideSpecificEntities()
		{
			return this.Data0<IHideSpecificEntities>().Value;
		}

		// Token: 0x06029E7B RID: 171643 RVA: 0x005BF2D4 File Offset: 0x005BD4D4
		public IShowSpecificEntities Data0AsIShowSpecificEntities()
		{
			return this.Data0<IShowSpecificEntities>().Value;
		}

		// Token: 0x06029E7C RID: 171644 RVA: 0x005BF2F0 File Offset: 0x005BD4F0
		public IHideGroup Data0AsIHideGroup()
		{
			return this.Data0<IHideGroup>().Value;
		}

		// Token: 0x06029E7D RID: 171645 RVA: 0x005BF30C File Offset: 0x005BD50C
		public IShowHidedGroup Data0AsIShowHidedGroup()
		{
			return this.Data0<IShowHidedGroup>().Value;
		}

		// Token: 0x06029E7E RID: 171646 RVA: 0x005BF328 File Offset: 0x005BD528
		public ISetSubScreenMode Data0AsISetSubScreenMode()
		{
			return this.Data0<ISetSubScreenMode>().Value;
		}

		// Token: 0x06029E7F RID: 171647 RVA: 0x005BF344 File Offset: 0x005BD544
		public IToggleDragActorPlay Data0AsIToggleDragActorPlay()
		{
			return this.Data0<IToggleDragActorPlay>().Value;
		}

		// Token: 0x06029E80 RID: 171648 RVA: 0x005BF360 File Offset: 0x005BD560
		public IManualOccupations Data0AsIManualOccupations()
		{
			return this.Data0<IManualOccupations>().Value;
		}

		// Token: 0x06029E81 RID: 171649 RVA: 0x005BF37C File Offset: 0x005BD57C
		public IForceOccupations Data0AsIForceOccupations()
		{
			return this.Data0<IForceOccupations>().Value;
		}

		// Token: 0x06029E82 RID: 171650 RVA: 0x005BF398 File Offset: 0x005BD598
		public IChangeFightTeam Data0AsIChangeFightTeam()
		{
			return this.Data0<IChangeFightTeam>().Value;
		}

		// Token: 0x06029E83 RID: 171651 RVA: 0x005BF3B4 File Offset: 0x005BD5B4
		public IActiveRange Data0AsIActiveRange()
		{
			return this.Data0<IActiveRange>().Value;
		}

		// Token: 0x06029E84 RID: 171652 RVA: 0x005BF3D0 File Offset: 0x005BD5D0
		public IAddTrialCharacter Data0AsIAddTrialCharacter()
		{
			return this.Data0<IAddTrialCharacter>().Value;
		}

		// Token: 0x06029E85 RID: 171653 RVA: 0x005BF3EC File Offset: 0x005BD5EC
		public IUpdateTrialCharacter Data0AsIUpdateTrialCharacter()
		{
			return this.Data0<IUpdateTrialCharacter>().Value;
		}

		// Token: 0x06029E86 RID: 171654 RVA: 0x005BF408 File Offset: 0x005BD608
		public IRestoreTrialCharacter Data0AsIRestoreTrialCharacter()
		{
			return this.Data0<IRestoreTrialCharacter>().Value;
		}

		// Token: 0x06029E87 RID: 171655 RVA: 0x005BF424 File Offset: 0x005BD624
		public IRemoveTrialCharacter Data0AsIRemoveTrialCharacter()
		{
			return this.Data0<IRemoveTrialCharacter>().Value;
		}

		// Token: 0x06029E88 RID: 171656 RVA: 0x005BF440 File Offset: 0x005BD640
		public IAddGuestCharacter Data0AsIAddGuestCharacter()
		{
			return this.Data0<IAddGuestCharacter>().Value;
		}

		// Token: 0x06029E89 RID: 171657 RVA: 0x005BF45C File Offset: 0x005BD65C
		public IRemoveGuestCharacter Data0AsIRemoveGuestCharacter()
		{
			return this.Data0<IRemoveGuestCharacter>().Value;
		}

		// Token: 0x06029E8A RID: 171658 RVA: 0x005BF478 File Offset: 0x005BD678
		public IDestroyQuest Data0AsIDestroyQuest()
		{
			return this.Data0<IDestroyQuest>().Value;
		}

		// Token: 0x06029E8B RID: 171659 RVA: 0x005BF494 File Offset: 0x005BD694
		public ISetCameraAnim Data0AsISetCameraAnim()
		{
			return this.Data0<ISetCameraAnim>().Value;
		}

		// Token: 0x06029E8C RID: 171660 RVA: 0x005BF4B0 File Offset: 0x005BD6B0
		public IChangeTimer Data0AsIChangeTimer()
		{
			return this.Data0<IChangeTimer>().Value;
		}

		// Token: 0x06029E8D RID: 171661 RVA: 0x005BF4CC File Offset: 0x005BD6CC
		public IToggleTimerPauseState Data0AsIToggleTimerPauseState()
		{
			return this.Data0<IToggleTimerPauseState>().Value;
		}

		// Token: 0x06029E8E RID: 171662 RVA: 0x005BF4E8 File Offset: 0x005BD6E8
		public IRotatorEntity Data0AsIRotatorEntity()
		{
			return this.Data0<IRotatorEntity>().Value;
		}

		// Token: 0x06029E8F RID: 171663 RVA: 0x005BF504 File Offset: 0x005BD704
		public IUnLimitPlayerOperation Data0AsIUnLimitPlayerOperation()
		{
			return this.Data0<IUnLimitPlayerOperation>().Value;
		}

		// Token: 0x06029E90 RID: 171664 RVA: 0x005BF520 File Offset: 0x005BD720
		public ILimitPlayerOperation Data0AsILimitPlayerOperation()
		{
			return this.Data0<ILimitPlayerOperation>().Value;
		}

		// Token: 0x06029E91 RID: 171665 RVA: 0x005BF53C File Offset: 0x005BD73C
		public IEnableSystem Data0AsIEnableSystem()
		{
			return this.Data0<IEnableSystem>().Value;
		}

		// Token: 0x06029E92 RID: 171666 RVA: 0x005BF558 File Offset: 0x005BD758
		public ILeisureInteract Data0AsILeisureInteract()
		{
			return this.Data0<ILeisureInteract>().Value;
		}

		// Token: 0x06029E93 RID: 171667 RVA: 0x005BF574 File Offset: 0x005BD774
		public INpcLeisureInteract Data0AsINpcLeisureInteract()
		{
			return this.Data0<INpcLeisureInteract>().Value;
		}

		// Token: 0x06029E94 RID: 171668 RVA: 0x005BF590 File Offset: 0x005BD790
		public IPostAkEvent Data0AsIPostAkEvent()
		{
			return this.Data0<IPostAkEvent>().Value;
		}

		// Token: 0x06029E95 RID: 171669 RVA: 0x005BF5AC File Offset: 0x005BD7AC
		public IMoveSceneItem Data0AsIMoveSceneItem()
		{
			return this.Data0<IMoveSceneItem>().Value;
		}

		// Token: 0x06029E96 RID: 171670 RVA: 0x005BF5C8 File Offset: 0x005BD7C8
		public IStopSceneItemMove Data0AsIStopSceneItemMove()
		{
			return this.Data0<IStopSceneItemMove>().Value;
		}

		// Token: 0x06029E97 RID: 171671 RVA: 0x005BF5E4 File Offset: 0x005BD7E4
		public IChangeLiftTarget Data0AsIChangeLiftTarget()
		{
			return this.Data0<IChangeLiftTarget>().Value;
		}

		// Token: 0x06029E98 RID: 171672 RVA: 0x005BF600 File Offset: 0x005BD800
		public IHideByRangeInFlow Data0AsIHideByRangeInFlow()
		{
			return this.Data0<IHideByRangeInFlow>().Value;
		}

		// Token: 0x06029E99 RID: 171673 RVA: 0x005BF61C File Offset: 0x005BD81C
		public IShowAllHidedGroupInFlow Data0AsIShowAllHidedGroupInFlow()
		{
			return this.Data0<IShowAllHidedGroupInFlow>().Value;
		}

		// Token: 0x06029E9A RID: 171674 RVA: 0x005BF638 File Offset: 0x005BD838
		public IOpenSimpleGameplay Data0AsIOpenSimpleGameplay()
		{
			return this.Data0<IOpenSimpleGameplay>().Value;
		}

		// Token: 0x06029E9B RID: 171675 RVA: 0x005BF654 File Offset: 0x005BD854
		public ICloseSimpleGameplay Data0AsICloseSimpleGameplay()
		{
			return this.Data0<ICloseSimpleGameplay>().Value;
		}

		// Token: 0x06029E9C RID: 171676 RVA: 0x005BF670 File Offset: 0x005BD870
		public IChangePhantom Data0AsIChangePhantom()
		{
			return this.Data0<IChangePhantom>().Value;
		}

		// Token: 0x06029E9D RID: 171677 RVA: 0x005BF68C File Offset: 0x005BD88C
		public IRestorePhantom Data0AsIRestorePhantom()
		{
			return this.Data0<IRestorePhantom>().Value;
		}

		// Token: 0x06029E9E RID: 171678 RVA: 0x005BF6A8 File Offset: 0x005BD8A8
		public ITakePlotPhoto Data0AsITakePlotPhoto()
		{
			return this.Data0<ITakePlotPhoto>().Value;
		}

		// Token: 0x06029E9F RID: 171679 RVA: 0x005BF6C4 File Offset: 0x005BD8C4
		public IChangeActorTalker Data0AsIChangeActorTalker()
		{
			return this.Data0<IChangeActorTalker>().Value;
		}

		// Token: 0x06029EA0 RID: 171680 RVA: 0x005BF6E0 File Offset: 0x005BD8E0
		public ISwitchSubLevels Data0AsISwitchSubLevels()
		{
			return this.Data0<ISwitchSubLevels>().Value;
		}

		// Token: 0x06029EA1 RID: 171681 RVA: 0x005BF6FC File Offset: 0x005BD8FC
		public ISwitchSubLevelsDirectly Data0AsISwitchSubLevelsDirectly()
		{
			return this.Data0<ISwitchSubLevelsDirectly>().Value;
		}

		// Token: 0x06029EA2 RID: 171682 RVA: 0x005BF718 File Offset: 0x005BD918
		public IPreloadSubLevels Data0AsIPreloadSubLevels()
		{
			return this.Data0<IPreloadSubLevels>().Value;
		}

		// Token: 0x06029EA3 RID: 171683 RVA: 0x005BF734 File Offset: 0x005BD934
		public ISwitchPermission Data0AsISwitchPermission()
		{
			return this.Data0<ISwitchPermission>().Value;
		}

		// Token: 0x06029EA4 RID: 171684 RVA: 0x005BF750 File Offset: 0x005BD950
		public ISwitchDataLayers Data0AsISwitchDataLayers()
		{
			return this.Data0<ISwitchDataLayers>().Value;
		}

		// Token: 0x06029EA5 RID: 171685 RVA: 0x005BF76C File Offset: 0x005BD96C
		public IActivateResetPoint Data0AsIActivateResetPoint()
		{
			return this.Data0<IActivateResetPoint>().Value;
		}

		// Token: 0x06029EA6 RID: 171686 RVA: 0x005BF788 File Offset: 0x005BD988
		public ITeleportToLatestResetPoint Data0AsITeleportToLatestResetPoint()
		{
			return this.Data0<ITeleportToLatestResetPoint>().Value;
		}

		// Token: 0x06029EA7 RID: 171687 RVA: 0x005BF7A4 File Offset: 0x005BD9A4
		public ISetWeather Data0AsISetWeather()
		{
			return this.Data0<ISetWeather>().Value;
		}

		// Token: 0x06029EA8 RID: 171688 RVA: 0x005BF7C0 File Offset: 0x005BD9C0
		public ISetTimeLockState Data0AsISetTimeLockState()
		{
			return this.Data0<ISetTimeLockState>().Value;
		}

		// Token: 0x06029EA9 RID: 171689 RVA: 0x005BF7DC File Offset: 0x005BD9DC
		public ISetWeatherLockState Data0AsISetWeatherLockState()
		{
			return this.Data0<ISetWeatherLockState>().Value;
		}

		// Token: 0x06029EAA RID: 171690 RVA: 0x005BF7F8 File Offset: 0x005BD9F8
		public IClientSetSeasonState Data0AsIClientSetSeasonState()
		{
			return this.Data0<IClientSetSeasonState>().Value;
		}

		// Token: 0x06029EAB RID: 171691 RVA: 0x005BF814 File Offset: 0x005BDA14
		public IAxisLockScreenConfig Data0AsIAxisLockScreenConfig()
		{
			return this.Data0<IAxisLockScreenConfig>().Value;
		}

		// Token: 0x06029EAC RID: 171692 RVA: 0x005BF830 File Offset: 0x005BDA30
		public IAdjustPlayerCamera Data0AsIAdjustPlayerCamera()
		{
			return this.Data0<IAdjustPlayerCamera>().Value;
		}

		// Token: 0x06029EAD RID: 171693 RVA: 0x005BF84C File Offset: 0x005BDA4C
		public IRestorePlayerCameraAdjustment Data0AsIRestorePlayerCameraAdjustment()
		{
			return this.Data0<IRestorePlayerCameraAdjustment>().Value;
		}

		// Token: 0x06029EAE RID: 171694 RVA: 0x005BF868 File Offset: 0x005BDA68
		public IAdjustPlayerCameraGravity Data0AsIAdjustPlayerCameraGravity()
		{
			return this.Data0<IAdjustPlayerCameraGravity>().Value;
		}

		// Token: 0x06029EAF RID: 171695 RVA: 0x005BF884 File Offset: 0x005BDA84
		public IEnterMovieCamera Data0AsIEnterMovieCamera()
		{
			return this.Data0<IEnterMovieCamera>().Value;
		}

		// Token: 0x06029EB0 RID: 171696 RVA: 0x005BF8A0 File Offset: 0x005BDAA0
		public IExitMovieCamera Data0AsIExitMovieCamera()
		{
			return this.Data0<IExitMovieCamera>().Value;
		}

		// Token: 0x06029EB1 RID: 171697 RVA: 0x005BF8BC File Offset: 0x005BDABC
		public IResetPlayerCameraFocus Data0AsIResetPlayerCameraFocus()
		{
			return this.Data0<IResetPlayerCameraFocus>().Value;
		}

		// Token: 0x06029EB2 RID: 171698 RVA: 0x005BF8D8 File Offset: 0x005BDAD8
		public IUsePhantomSkill Data0AsIUsePhantomSkill()
		{
			return this.Data0<IUsePhantomSkill>().Value;
		}

		// Token: 0x06029EB3 RID: 171699 RVA: 0x005BF8F4 File Offset: 0x005BDAF4
		public IChangePhantomFormation Data0AsIChangePhantomFormation()
		{
			return this.Data0<IChangePhantomFormation>().Value;
		}

		// Token: 0x06029EB4 RID: 171700 RVA: 0x005BF910 File Offset: 0x005BDB10
		public IRestorePhantomFormation Data0AsIRestorePhantomFormation()
		{
			return this.Data0<IRestorePhantomFormation>().Value;
		}

		// Token: 0x06029EB5 RID: 171701 RVA: 0x005BF92C File Offset: 0x005BDB2C
		public IEnterOrbitalCamera Data0AsIEnterOrbitalCamera()
		{
			return this.Data0<IEnterOrbitalCamera>().Value;
		}

		// Token: 0x06029EB6 RID: 171702 RVA: 0x005BF948 File Offset: 0x005BDB48
		public IExitOrbitalCamera Data0AsIExitOrbitalCamera()
		{
			return this.Data0<IExitOrbitalCamera>().Value;
		}

		// Token: 0x06029EB7 RID: 171703 RVA: 0x005BF964 File Offset: 0x005BDB64
		public IEnableSplineMoveModel Data0AsIEnableSplineMoveModel()
		{
			return this.Data0<IEnableSplineMoveModel>().Value;
		}

		// Token: 0x06029EB8 RID: 171704 RVA: 0x005BF980 File Offset: 0x005BDB80
		public IEnableActor Data0AsIEnableActor()
		{
			return this.Data0<IEnableActor>().Value;
		}

		// Token: 0x1700B625 RID: 46629
		// (get) Token: 0x06029EB9 RID: 171705 RVA: 0x005BF99C File Offset: 0x005BDB9C
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

		// Token: 0x06029EBA RID: 171706 RVA: 0x005BF9DC File Offset: 0x005BDBDC
		public TTable? Data1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029EBB RID: 171707 RVA: 0x005BFA24 File Offset: 0x005BDC24
		public ISetSportsState Data1AsISetSportsState()
		{
			return this.Data1<ISetSportsState>().Value;
		}

		// Token: 0x06029EBC RID: 171708 RVA: 0x005BFA40 File Offset: 0x005BDC40
		public ISetExploreState Data1AsISetExploreState()
		{
			return this.Data1<ISetExploreState>().Value;
		}

		// Token: 0x06029EBD RID: 171709 RVA: 0x005BFA5C File Offset: 0x005BDC5C
		public IModifyActorMaterial Data1AsIModifyActorMaterial()
		{
			return this.Data1<IModifyActorMaterial>().Value;
		}

		// Token: 0x06029EBE RID: 171710 RVA: 0x005BFA78 File Offset: 0x005BDC78
		public IModifyActorMaterialParamBySplineProgress Data1AsIModifyActorMaterialParamBySplineProgress()
		{
			return this.Data1<IModifyActorMaterialParamBySplineProgress>().Value;
		}

		// Token: 0x06029EBF RID: 171711 RVA: 0x005BFA94 File Offset: 0x005BDC94
		public IModifyActorMedia Data1AsIModifyActorMedia()
		{
			return this.Data1<IModifyActorMedia>().Value;
		}

		// Token: 0x06029EC0 RID: 171712 RVA: 0x005BFAB0 File Offset: 0x005BDCB0
		public IPlayLevelSequence Data1AsIPlayLevelSequence()
		{
			return this.Data1<IPlayLevelSequence>().Value;
		}

		// Token: 0x06029EC1 RID: 171713 RVA: 0x005BFACC File Offset: 0x005BDCCC
		public IEnableTakePhotoClip Data1AsIEnableTakePhotoClip()
		{
			return this.Data1<IEnableTakePhotoClip>().Value;
		}

		// Token: 0x06029EC2 RID: 171714 RVA: 0x005BFAE8 File Offset: 0x005BDCE8
		public IToggleAirWall Data1AsIToggleAirWall()
		{
			return this.Data1<IToggleAirWall>().Value;
		}

		// Token: 0x06029EC3 RID: 171715 RVA: 0x005BFB04 File Offset: 0x005BDD04
		public ITriggerCameraShake Data1AsITriggerCameraShake()
		{
			return this.Data1<ITriggerCameraShake>().Value;
		}

		// Token: 0x06029EC4 RID: 171716 RVA: 0x005BFB20 File Offset: 0x005BDD20
		public ITriggerGamepadShake Data1AsITriggerGamepadShake()
		{
			return this.Data1<ITriggerGamepadShake>().Value;
		}

		// Token: 0x06029EC5 RID: 171717 RVA: 0x005BFB3C File Offset: 0x005BDD3C
		public IPlayRegisteredMontage Data1AsIPlayRegisteredMontage()
		{
			return this.Data1<IPlayRegisteredMontage>().Value;
		}

		// Token: 0x06029EC6 RID: 171718 RVA: 0x005BFB58 File Offset: 0x005BDD58
		public ICreatePrefab Data1AsICreatePrefab()
		{
			return this.Data1<ICreatePrefab>().Value;
		}

		// Token: 0x06029EC7 RID: 171719 RVA: 0x005BFB74 File Offset: 0x005BDD74
		public IDestroyPrefab Data1AsIDestroyPrefab()
		{
			return this.Data1<IDestroyPrefab>().Value;
		}

		// Token: 0x06029EC8 RID: 171720 RVA: 0x005BFB90 File Offset: 0x005BDD90
		public ISetDataLayerTransitions Data1AsISetDataLayerTransitions()
		{
			return this.Data1<ISetDataLayerTransitions>().Value;
		}

		// Token: 0x06029EC9 RID: 171721 RVA: 0x005BFBAC File Offset: 0x005BDDAC
		public IEnableAoiNotify Data1AsIEnableAoiNotify()
		{
			return this.Data1<IEnableAoiNotify>().Value;
		}

		// Token: 0x06029ECA RID: 171722 RVA: 0x005BFBC8 File Offset: 0x005BDDC8
		public IRecoverDurability Data1AsIRecoverDurability()
		{
			return this.Data1<IRecoverDurability>().Value;
		}

		// Token: 0x06029ECB RID: 171723 RVA: 0x005BFBE4 File Offset: 0x005BDDE4
		public ISetPlayerOperationRestriction Data1AsISetPlayerOperationRestriction()
		{
			return this.Data1<ISetPlayerOperationRestriction>().Value;
		}

		// Token: 0x06029ECC RID: 171724 RVA: 0x005BFC00 File Offset: 0x005BDE00
		public IEnableAllPlayerOperation Data1AsIEnableAllPlayerOperation()
		{
			return this.Data1<IEnableAllPlayerOperation>().Value;
		}

		// Token: 0x06029ECD RID: 171725 RVA: 0x005BFC1C File Offset: 0x005BDE1C
		public IDisableAllPlayerOperation Data1AsIDisableAllPlayerOperation()
		{
			return this.Data1<IDisableAllPlayerOperation>().Value;
		}

		// Token: 0x06029ECE RID: 171726 RVA: 0x005BFC38 File Offset: 0x005BDE38
		public IDisableModulePlayerOperation Data1AsIDisableModulePlayerOperation()
		{
			return this.Data1<IDisableModulePlayerOperation>().Value;
		}

		// Token: 0x06029ECF RID: 171727 RVA: 0x005BFC54 File Offset: 0x005BDE54
		public IClientSetPlayerOperationRestriction Data1AsIClientSetPlayerOperationRestriction()
		{
			return this.Data1<IClientSetPlayerOperationRestriction>().Value;
		}

		// Token: 0x06029ED0 RID: 171728 RVA: 0x005BFC70 File Offset: 0x005BDE70
		public IClientEnableAllPlayerOperation Data1AsIClientEnableAllPlayerOperation()
		{
			return this.Data1<IClientEnableAllPlayerOperation>().Value;
		}

		// Token: 0x06029ED1 RID: 171729 RVA: 0x005BFC8C File Offset: 0x005BDE8C
		public IClientDisableAllPlayerOperation Data1AsIClientDisableAllPlayerOperation()
		{
			return this.Data1<IClientDisableAllPlayerOperation>().Value;
		}

		// Token: 0x06029ED2 RID: 171730 RVA: 0x005BFCA8 File Offset: 0x005BDEA8
		public IClientDisableModulePlayerOperation Data1AsIClientDisableModulePlayerOperation()
		{
			return this.Data1<IClientDisableModulePlayerOperation>().Value;
		}

		// Token: 0x06029ED3 RID: 171731 RVA: 0x005BFCC4 File Offset: 0x005BDEC4
		public IEnableFunction Data1AsIEnableFunction()
		{
			return this.Data1<IEnableFunction>().Value;
		}

		// Token: 0x06029ED4 RID: 171732 RVA: 0x005BFCE0 File Offset: 0x005BDEE0
		public ITeleportDungeonFunction Data1AsITeleportDungeonFunction()
		{
			return this.Data1<ITeleportDungeonFunction>().Value;
		}

		// Token: 0x06029ED5 RID: 171733 RVA: 0x005BFCFC File Offset: 0x005BDEFC
		public IMotorRadioUiFunction Data1AsIMotorRadioUiFunction()
		{
			return this.Data1<IMotorRadioUiFunction>().Value;
		}

		// Token: 0x06029ED6 RID: 171734 RVA: 0x005BFD18 File Offset: 0x005BDF18
		public IInteractiveItemsFunction Data1AsIInteractiveItemsFunction()
		{
			return this.Data1<IInteractiveItemsFunction>().Value;
		}

		// Token: 0x06029ED7 RID: 171735 RVA: 0x005BFD34 File Offset: 0x005BDF34
		public IEnableClientFunction Data1AsIEnableClientFunction()
		{
			return this.Data1<IEnableClientFunction>().Value;
		}

		// Token: 0x06029ED8 RID: 171736 RVA: 0x005BFD50 File Offset: 0x005BDF50
		public IHealthBarDisplayClientFunction Data1AsIHealthBarDisplayClientFunction()
		{
			return this.Data1<IHealthBarDisplayClientFunction>().Value;
		}

		// Token: 0x06029ED9 RID: 171737 RVA: 0x005BFD6C File Offset: 0x005BDF6C
		public IChangeEntityPrefabPerformance Data1AsIChangeEntityPrefabPerformance()
		{
			return this.Data1<IChangeEntityPrefabPerformance>().Value;
		}

		// Token: 0x06029EDA RID: 171738 RVA: 0x005BFD88 File Offset: 0x005BDF88
		public IChangeTargetEntityPrefabPerformance Data1AsIChangeTargetEntityPrefabPerformance()
		{
			return this.Data1<IChangeTargetEntityPrefabPerformance>().Value;
		}

		// Token: 0x06029EDB RID: 171739 RVA: 0x005BFDA4 File Offset: 0x005BDFA4
		public IChangeSelfEntityPrefabPerformance Data1AsIChangeSelfEntityPrefabPerformance()
		{
			return this.Data1<IChangeSelfEntityPrefabPerformance>().Value;
		}

		// Token: 0x06029EDC RID: 171740 RVA: 0x005BFDC0 File Offset: 0x005BDFC0
		public IModifySceneItemAttributeTag Data1AsIModifySceneItemAttributeTag()
		{
			return this.Data1<IModifySceneItemAttributeTag>().Value;
		}

		// Token: 0x06029EDD RID: 171741 RVA: 0x005BFDDC File Offset: 0x005BDFDC
		public IModifySelfSceneItemAttributeTag Data1AsIModifySelfSceneItemAttributeTag()
		{
			return this.Data1<IModifySelfSceneItemAttributeTag>().Value;
		}

		// Token: 0x06029EDE RID: 171742 RVA: 0x005BFDF8 File Offset: 0x005BDFF8
		public IModifyTargetSceneItemAttributeTag Data1AsIModifyTargetSceneItemAttributeTag()
		{
			return this.Data1<IModifyTargetSceneItemAttributeTag>().Value;
		}

		// Token: 0x06029EDF RID: 171743 RVA: 0x005BFE14 File Offset: 0x005BE014
		public IClientModifyTargetTag Data1AsIClientModifyTargetTag()
		{
			return this.Data1<IClientModifyTargetTag>().Value;
		}

		// Token: 0x06029EE0 RID: 171744 RVA: 0x005BFE30 File Offset: 0x005BE030
		public IToggleMapMarkState Data1AsIToggleMapMarkState()
		{
			return this.Data1<IToggleMapMarkState>().Value;
		}

		// Token: 0x06029EE1 RID: 171745 RVA: 0x005BFE4C File Offset: 0x005BE04C
		public IShowMapMark Data1AsIShowMapMark()
		{
			return this.Data1<IShowMapMark>().Value;
		}

		// Token: 0x06029EE2 RID: 171746 RVA: 0x005BFE68 File Offset: 0x005BE068
		public IHideMapMark Data1AsIHideMapMark()
		{
			return this.Data1<IHideMapMark>().Value;
		}

		// Token: 0x06029EE3 RID: 171747 RVA: 0x005BFE84 File Offset: 0x005BE084
		public IDisableMapMark Data1AsIDisableMapMark()
		{
			return this.Data1<IDisableMapMark>().Value;
		}

		// Token: 0x06029EE4 RID: 171748 RVA: 0x005BFEA0 File Offset: 0x005BE0A0
		public IFocusOnMapMarkAction Data1AsIFocusOnMapMarkAction()
		{
			return this.Data1<IFocusOnMapMarkAction>().Value;
		}

		// Token: 0x06029EE5 RID: 171749 RVA: 0x005BFEBC File Offset: 0x005BE0BC
		public IEnableTemporaryTeleport Data1AsIEnableTemporaryTeleport()
		{
			return this.Data1<IEnableTemporaryTeleport>().Value;
		}

		// Token: 0x06029EE6 RID: 171750 RVA: 0x005BFED8 File Offset: 0x005BE0D8
		public ISetRegionConfig Data1AsISetRegionConfig()
		{
			return this.Data1<ISetRegionConfig>().Value;
		}

		// Token: 0x06029EE7 RID: 171751 RVA: 0x005BFEF4 File Offset: 0x005BE0F4
		public ISetRegionMpc Data1AsISetRegionMpc()
		{
			return this.Data1<ISetRegionMpc>().Value;
		}

		// Token: 0x06029EE8 RID: 171752 RVA: 0x005BFF10 File Offset: 0x005BE110
		public ISetJigsawItem Data1AsISetJigsawItem()
		{
			return this.Data1<ISetJigsawItem>().Value;
		}

		// Token: 0x06029EE9 RID: 171753 RVA: 0x005BFF2C File Offset: 0x005BE12C
		public ISetJigsawFoundation Data1AsISetJigsawFoundation()
		{
			return this.Data1<ISetJigsawFoundation>().Value;
		}

		// Token: 0x06029EEA RID: 171754 RVA: 0x005BFF48 File Offset: 0x005BE148
		public IToggleHighlightExploreUi Data1AsIToggleHighlightExploreUi()
		{
			return this.Data1<IToggleHighlightExploreUi>().Value;
		}

		// Token: 0x06029EEB RID: 171755 RVA: 0x005BFF64 File Offset: 0x005BE164
		public IShowHighlightExploreSkillIcon Data1AsIShowHighlightExploreSkillIcon()
		{
			return this.Data1<IShowHighlightExploreSkillIcon>().Value;
		}

		// Token: 0x06029EEC RID: 171756 RVA: 0x005BFF80 File Offset: 0x005BE180
		public IHideHighlightExploreSkillIcon Data1AsIHideHighlightExploreSkillIcon()
		{
			return this.Data1<IHideHighlightExploreSkillIcon>().Value;
		}

		// Token: 0x06029EED RID: 171757 RVA: 0x005BFF9C File Offset: 0x005BE19C
		public IToggleAndHighlightItem Data1AsIToggleAndHighlightItem()
		{
			return this.Data1<IToggleAndHighlightItem>().Value;
		}

		// Token: 0x06029EEE RID: 171758 RVA: 0x005BFFB8 File Offset: 0x005BE1B8
		public IResetEntity Data1AsIResetEntity()
		{
			return this.Data1<IResetEntity>().Value;
		}

		// Token: 0x06029EEF RID: 171759 RVA: 0x005BFFD4 File Offset: 0x005BE1D4
		public IResetLevelPlay Data1AsIResetLevelPlay()
		{
			return this.Data1<IResetLevelPlay>().Value;
		}

		// Token: 0x06029EF0 RID: 171760 RVA: 0x005BFFF0 File Offset: 0x005BE1F0
		public IPlayDynamicSettlement Data1AsIPlayDynamicSettlement()
		{
			return this.Data1<IPlayDynamicSettlement>().Value;
		}

		// Token: 0x06029EF1 RID: 171761 RVA: 0x005C000C File Offset: 0x005BE20C
		public ISetInteractionLockState Data1AsISetInteractionLockState()
		{
			return this.Data1<ISetInteractionLockState>().Value;
		}

		// Token: 0x06029EF2 RID: 171762 RVA: 0x005C0028 File Offset: 0x005BE228
		public ISetAudioState Data1AsISetAudioState()
		{
			return this.Data1<ISetAudioState>().Value;
		}

		// Token: 0x06029EF3 RID: 171763 RVA: 0x005C0044 File Offset: 0x005BE244
		public IPerformerAiSplineMove Data1AsIPerformerAiSplineMove()
		{
			return this.Data1<IPerformerAiSplineMove>().Value;
		}

		// Token: 0x06029EF4 RID: 171764 RVA: 0x005C0060 File Offset: 0x005BE260
		public IPerformerAiMoveTo Data1AsIPerformerAiMoveTo()
		{
			return this.Data1<IPerformerAiMoveTo>().Value;
		}

		// Token: 0x06029EF5 RID: 171765 RVA: 0x005C007C File Offset: 0x005BE27C
		public IAddTrialFollowShooter Data1AsIAddTrialFollowShooter()
		{
			return this.Data1<IAddTrialFollowShooter>().Value;
		}

		// Token: 0x06029EF6 RID: 171766 RVA: 0x005C0098 File Offset: 0x005BE298
		public IRemoveTrialFollowShooter Data1AsIRemoveTrialFollowShooter()
		{
			return this.Data1<IRemoveTrialFollowShooter>().Value;
		}

		// Token: 0x06029EF7 RID: 171767 RVA: 0x005C00B4 File Offset: 0x005BE2B4
		public IEnableFollowShooterAbility Data1AsIEnableFollowShooterAbility()
		{
			return this.Data1<IEnableFollowShooterAbility>().Value;
		}

		// Token: 0x06029EF8 RID: 171768 RVA: 0x005C00D0 File Offset: 0x005BE2D0
		public IClientFollowShooterLeisureInteract Data1AsIClientFollowShooterLeisureInteract()
		{
			return this.Data1<IClientFollowShooterLeisureInteract>().Value;
		}

		// Token: 0x06029EF9 RID: 171769 RVA: 0x005C00EC File Offset: 0x005BE2EC
		public ICustomJson Data1AsICustomJson()
		{
			return this.Data1<ICustomJson>().Value;
		}

		// Token: 0x06029EFA RID: 171770 RVA: 0x005C0108 File Offset: 0x005BE308
		public IExecResurrection Data1AsIExecResurrection()
		{
			return this.Data1<IExecResurrection>().Value;
		}

		// Token: 0x06029EFB RID: 171771 RVA: 0x005C0124 File Offset: 0x005BE324
		public IOpenSystemBoardWithReturn Data1AsIOpenSystemBoardWithReturn()
		{
			return this.Data1<IOpenSystemBoardWithReturn>().Value;
		}

		// Token: 0x06029EFC RID: 171772 RVA: 0x005C0140 File Offset: 0x005BE340
		public IResumeSystemRewardPopup Data1AsIResumeSystemRewardPopup()
		{
			return this.Data1<IResumeSystemRewardPopup>().Value;
		}

		// Token: 0x06029EFD RID: 171773 RVA: 0x005C015C File Offset: 0x005BE35C
		public IExecRiskHarvestEffect Data1AsIExecRiskHarvestEffect()
		{
			return this.Data1<IExecRiskHarvestEffect>().Value;
		}

		// Token: 0x06029EFE RID: 171774 RVA: 0x005C0178 File Offset: 0x005BE378
		public ISetTeleControl Data1AsISetTeleControl()
		{
			return this.Data1<ISetTeleControl>().Value;
		}

		// Token: 0x06029EFF RID: 171775 RVA: 0x005C0194 File Offset: 0x005BE394
		public IMowingTowerGotoNextFloor Data1AsIMowingTowerGotoNextFloor()
		{
			return this.Data1<IMowingTowerGotoNextFloor>().Value;
		}

		// Token: 0x06029F00 RID: 171776 RVA: 0x005C01B0 File Offset: 0x005BE3B0
		public ISlashAndTowerGotoNextFloor Data1AsISlashAndTowerGotoNextFloor()
		{
			return this.Data1<ISlashAndTowerGotoNextFloor>().Value;
		}

		// Token: 0x06029F01 RID: 171777 RVA: 0x005C01CC File Offset: 0x005BE3CC
		public IRoleTowerGotoNextFloor Data1AsIRoleTowerGotoNextFloor()
		{
			return this.Data1<IRoleTowerGotoNextFloor>().Value;
		}

		// Token: 0x06029F02 RID: 171778 RVA: 0x005C01E8 File Offset: 0x005BE3E8
		public IVehicleEnter Data1AsIVehicleEnter()
		{
			return this.Data1<IVehicleEnter>().Value;
		}

		// Token: 0x06029F03 RID: 171779 RVA: 0x005C0204 File Offset: 0x005BE404
		public IEnterNpcVehicle Data1AsIEnterNpcVehicle()
		{
			return this.Data1<IEnterNpcVehicle>().Value;
		}

		// Token: 0x06029F04 RID: 171780 RVA: 0x005C0220 File Offset: 0x005BE420
		public IVehicleExitPlayer Data1AsIVehicleExitPlayer()
		{
			return this.Data1<IVehicleExitPlayer>().Value;
		}

		// Token: 0x06029F05 RID: 171781 RVA: 0x005C023C File Offset: 0x005BE43C
		public IVehicleExitNpc Data1AsIVehicleExitNpc()
		{
			return this.Data1<IVehicleExitNpc>().Value;
		}

		// Token: 0x06029F06 RID: 171782 RVA: 0x005C0258 File Offset: 0x005BE458
		public ITeleportVehicle Data1AsITeleportVehicle()
		{
			return this.Data1<ITeleportVehicle>().Value;
		}

		// Token: 0x06029F07 RID: 171783 RVA: 0x005C0274 File Offset: 0x005BE474
		public IClientTeleportVehicle Data1AsIClientTeleportVehicle()
		{
			return this.Data1<IClientTeleportVehicle>().Value;
		}

		// Token: 0x06029F08 RID: 171784 RVA: 0x005C0290 File Offset: 0x005BE490
		public IVehiclePlayPassengerVoice Data1AsIVehiclePlayPassengerVoice()
		{
			return this.Data1<IVehiclePlayPassengerVoice>().Value;
		}

		// Token: 0x06029F09 RID: 171785 RVA: 0x005C02AC File Offset: 0x005BE4AC
		public IVehicleWaterfallClimbing Data1AsIVehicleWaterfallClimbing()
		{
			return this.Data1<IVehicleWaterfallClimbing>().Value;
		}

		// Token: 0x06029F0A RID: 171786 RVA: 0x005C02C8 File Offset: 0x005BE4C8
		public ITeleportToAndEnterVehicle Data1AsITeleportToAndEnterVehicle()
		{
			return this.Data1<ITeleportToAndEnterVehicle>().Value;
		}

		// Token: 0x06029F0B RID: 171787 RVA: 0x005C02E4 File Offset: 0x005BE4E4
		public IVehicleMoveWithPathLine Data1AsIVehicleMoveWithPathLine()
		{
			return this.Data1<IVehicleMoveWithPathLine>().Value;
		}

		// Token: 0x06029F0C RID: 171788 RVA: 0x005C0300 File Offset: 0x005BE500
		public IVehicleSprint Data1AsIVehicleSprint()
		{
			return this.Data1<IVehicleSprint>().Value;
		}

		// Token: 0x06029F0D RID: 171789 RVA: 0x005C031C File Offset: 0x005BE51C
		public IOpenQteAction Data1AsIOpenQteAction()
		{
			return this.Data1<IOpenQteAction>().Value;
		}

		// Token: 0x06029F0E RID: 171790 RVA: 0x005C0338 File Offset: 0x005BE538
		public IPlayerInput Data1AsIPlayerInput()
		{
			return this.Data1<IPlayerInput>().Value;
		}

		// Token: 0x06029F0F RID: 171791 RVA: 0x005C0354 File Offset: 0x005BE554
		public IPreloadAction Data1AsIPreloadAction()
		{
			return this.Data1<IPreloadAction>().Value;
		}

		// Token: 0x06029F10 RID: 171792 RVA: 0x005C0370 File Offset: 0x005BE570
		public IRemovePreloadResourceAction Data1AsIRemovePreloadResourceAction()
		{
			return this.Data1<IRemovePreloadResourceAction>().Value;
		}

		// Token: 0x06029F11 RID: 171793 RVA: 0x005C038C File Offset: 0x005BE58C
		public IExecAlertSystemAction Data1AsIExecAlertSystemAction()
		{
			return this.Data1<IExecAlertSystemAction>().Value;
		}

		// Token: 0x06029F12 RID: 171794 RVA: 0x005C03A8 File Offset: 0x005BE5A8
		public ISetSpineAnimation Data1AsISetSpineAnimation()
		{
			return this.Data1<ISetSpineAnimation>().Value;
		}

		// Token: 0x06029F13 RID: 171795 RVA: 0x005C03C4 File Offset: 0x005BE5C4
		public IChangeEntityCamp Data1AsIChangeEntityCamp()
		{
			return this.Data1<IChangeEntityCamp>().Value;
		}

		// Token: 0x06029F14 RID: 171796 RVA: 0x005C03E0 File Offset: 0x005BE5E0
		public IRecordDungeonEvent Data1AsIRecordDungeonEvent()
		{
			return this.Data1<IRecordDungeonEvent>().Value;
		}

		// Token: 0x06029F15 RID: 171797 RVA: 0x005C03FC File Offset: 0x005BE5FC
		public IDangoAbyssGotoNextFloor Data1AsIDangoAbyssGotoNextFloor()
		{
			return this.Data1<IDangoAbyssGotoNextFloor>().Value;
		}

		// Token: 0x06029F16 RID: 171798 RVA: 0x005C0418 File Offset: 0x005BE618
		public IDangoAbyssCreateRewardTreasureBox Data1AsIDangoAbyssCreateRewardTreasureBox()
		{
			return this.Data1<IDangoAbyssCreateRewardTreasureBox>().Value;
		}

		// Token: 0x06029F17 RID: 171799 RVA: 0x005C0434 File Offset: 0x005BE634
		public IDangoAbyssActivatePortal Data1AsIDangoAbyssActivatePortal()
		{
			return this.Data1<IDangoAbyssActivatePortal>().Value;
		}

		// Token: 0x06029F18 RID: 171800 RVA: 0x005C0450 File Offset: 0x005BE650
		public IDangoAbyssReceiveReward Data1AsIDangoAbyssReceiveReward()
		{
			return this.Data1<IDangoAbyssReceiveReward>().Value;
		}

		// Token: 0x06029F19 RID: 171801 RVA: 0x005C046C File Offset: 0x005BE66C
		public IRoverRogueActivate Data1AsIRoverRogueActivate()
		{
			return this.Data1<IRoverRogueActivate>().Value;
		}

		// Token: 0x06029F1A RID: 171802 RVA: 0x005C0488 File Offset: 0x005BE688
		public IRoverRogueRoomFinish Data1AsIRoverRogueRoomFinish()
		{
			return this.Data1<IRoverRogueRoomFinish>().Value;
		}

		// Token: 0x06029F1B RID: 171803 RVA: 0x005C04A4 File Offset: 0x005BE6A4
		public IRoverRogueCreateRoomReward Data1AsIRoverRogueCreateRoomReward()
		{
			return this.Data1<IRoverRogueCreateRoomReward>().Value;
		}

		// Token: 0x06029F1C RID: 171804 RVA: 0x005C04C0 File Offset: 0x005BE6C0
		public IGuestOperateUiAnimation Data1AsIGuestOperateUiAnimation()
		{
			return this.Data1<IGuestOperateUiAnimation>().Value;
		}

		// Token: 0x06029F1D RID: 171805 RVA: 0x005C04DC File Offset: 0x005BE6DC
		public ISlideRailStart Data1AsISlideRailStart()
		{
			return this.Data1<ISlideRailStart>().Value;
		}

		// Token: 0x06029F1E RID: 171806 RVA: 0x005C04F8 File Offset: 0x005BE6F8
		public ISlideRailEnd Data1AsISlideRailEnd()
		{
			return this.Data1<ISlideRailEnd>().Value;
		}

		// Token: 0x06029F1F RID: 171807 RVA: 0x005C0514 File Offset: 0x005BE714
		public ISlidePerformStart Data1AsISlidePerformStart()
		{
			return this.Data1<ISlidePerformStart>().Value;
		}

		// Token: 0x06029F20 RID: 171808 RVA: 0x005C0530 File Offset: 0x005BE730
		public IBvbSendSystemEvent Data1AsIBvbSendSystemEvent()
		{
			return this.Data1<IBvbSendSystemEvent>().Value;
		}

		// Token: 0x06029F21 RID: 171809 RVA: 0x005C054C File Offset: 0x005BE74C
		public IBvbSendAiEvent Data1AsIBvbSendAiEvent()
		{
			return this.Data1<IBvbSendAiEvent>().Value;
		}

		// Token: 0x06029F22 RID: 171810 RVA: 0x005C0568 File Offset: 0x005BE768
		public IBvbPlayDialog Data1AsIBvbPlayDialog()
		{
			return this.Data1<IBvbPlayDialog>().Value;
		}

		// Token: 0x06029F23 RID: 171811 RVA: 0x005C0584 File Offset: 0x005BE784
		public IBvbPlayerOperationConstraint Data1AsIBvbPlayerOperationConstraint()
		{
			return this.Data1<IBvbPlayerOperationConstraint>().Value;
		}

		// Token: 0x06029F24 RID: 171812 RVA: 0x005C05A0 File Offset: 0x005BE7A0
		public IBvbSkipChallenge Data1AsIBvbSkipChallenge()
		{
			return this.Data1<IBvbSkipChallenge>().Value;
		}

		// Token: 0x06029F25 RID: 171813 RVA: 0x005C05BC File Offset: 0x005BE7BC
		public IActiveAntiGravitySafePoint Data1AsIActiveAntiGravitySafePoint()
		{
			return this.Data1<IActiveAntiGravitySafePoint>().Value;
		}

		// Token: 0x06029F26 RID: 171814 RVA: 0x005C05D8 File Offset: 0x005BE7D8
		public ISummonEntity Data1AsISummonEntity()
		{
			return this.Data1<ISummonEntity>().Value;
		}

		// Token: 0x06029F27 RID: 171815 RVA: 0x005C05F4 File Offset: 0x005BE7F4
		public IDestroySummonedEntities Data1AsIDestroySummonedEntities()
		{
			return this.Data1<IDestroySummonedEntities>().Value;
		}

		// Token: 0x06029F28 RID: 171816 RVA: 0x005C0610 File Offset: 0x005BE810
		public ISetupMoraleSystem Data1AsISetupMoraleSystem()
		{
			return this.Data1<ISetupMoraleSystem>().Value;
		}

		// Token: 0x06029F29 RID: 171817 RVA: 0x005C062C File Offset: 0x005BE82C
		public IGiantToggleModel Data1AsIGiantToggleModel()
		{
			return this.Data1<IGiantToggleModel>().Value;
		}

		// Token: 0x06029F2A RID: 171818 RVA: 0x005C0648 File Offset: 0x005BE848
		public IGiantTriggerResponse Data1AsIGiantTriggerResponse()
		{
			return this.Data1<IGiantTriggerResponse>().Value;
		}

		// Token: 0x06029F2B RID: 171819 RVA: 0x005C0664 File Offset: 0x005BE864
		public IActivateGiantTotalProgressNode Data1AsIActivateGiantTotalProgressNode()
		{
			return this.Data1<IActivateGiantTotalProgressNode>().Value;
		}

		// Token: 0x06029F2C RID: 171820 RVA: 0x005C0680 File Offset: 0x005BE880
		public IRunActorCustomEvent Data1AsIRunActorCustomEvent()
		{
			return this.Data1<IRunActorCustomEvent>().Value;
		}

		// Token: 0x06029F2D RID: 171821 RVA: 0x005C069C File Offset: 0x005BE89C
		public ITriggerSpecificScanEffect Data1AsITriggerSpecificScanEffect()
		{
			return this.Data1<ITriggerSpecificScanEffect>().Value;
		}

		// Token: 0x06029F2E RID: 171822 RVA: 0x005C06B8 File Offset: 0x005BE8B8
		public ISendClientEvent Data1AsISendClientEvent()
		{
			return this.Data1<ISendClientEvent>().Value;
		}

		// Token: 0x06029F2F RID: 171823 RVA: 0x005C06D4 File Offset: 0x005BE8D4
		public IScanEnrichmentArea Data1AsIScanEnrichmentArea()
		{
			return this.Data1<IScanEnrichmentArea>().Value;
		}

		// Token: 0x06029F30 RID: 171824 RVA: 0x005C06F0 File Offset: 0x005BE8F0
		public IRequestSystemFunction Data1AsIRequestSystemFunction()
		{
			return this.Data1<IRequestSystemFunction>().Value;
		}

		// Token: 0x06029F31 RID: 171825 RVA: 0x005C070C File Offset: 0x005BE90C
		public IReignsSetPropertyVisible Data1AsIReignsSetPropertyVisible()
		{
			return this.Data1<IReignsSetPropertyVisible>().Value;
		}

		// Token: 0x06029F32 RID: 171826 RVA: 0x005C0728 File Offset: 0x005BE928
		public IReignsChangeBackground Data1AsIReignsChangeBackground()
		{
			return this.Data1<IReignsChangeBackground>().Value;
		}

		// Token: 0x06029F33 RID: 171827 RVA: 0x005C0744 File Offset: 0x005BE944
		public IReignsSetUiEffect Data1AsIReignsSetUiEffect()
		{
			return this.Data1<IReignsSetUiEffect>().Value;
		}

		// Token: 0x06029F34 RID: 171828 RVA: 0x005C0760 File Offset: 0x005BE960
		public IReignsChangePlayerName Data1AsIReignsChangePlayerName()
		{
			return this.Data1<IReignsChangePlayerName>().Value;
		}

		// Token: 0x06029F35 RID: 171829 RVA: 0x005C077C File Offset: 0x005BE97C
		public IReignsCallCard Data1AsIReignsCallCard()
		{
			return this.Data1<IReignsCallCard>().Value;
		}

		// Token: 0x06029F36 RID: 171830 RVA: 0x005C0798 File Offset: 0x005BE998
		public IReignsTriggerGuide Data1AsIReignsTriggerGuide()
		{
			return this.Data1<IReignsTriggerGuide>().Value;
		}

		// Token: 0x06029F37 RID: 171831 RVA: 0x005C07B4 File Offset: 0x005BE9B4
		public IReignsAddBuff Data1AsIReignsAddBuff()
		{
			return this.Data1<IReignsAddBuff>().Value;
		}

		// Token: 0x06029F38 RID: 171832 RVA: 0x005C07D0 File Offset: 0x005BE9D0
		public IReignsCheckSettle Data1AsIReignsCheckSettle()
		{
			return this.Data1<IReignsCheckSettle>().Value;
		}

		// Token: 0x06029F39 RID: 171833 RVA: 0x005C07EC File Offset: 0x005BE9EC
		public ISetNpcGroupPerform Data1AsISetNpcGroupPerform()
		{
			return this.Data1<ISetNpcGroupPerform>().Value;
		}

		// Token: 0x06029F3A RID: 171834 RVA: 0x005C0808 File Offset: 0x005BEA08
		public IRemoveNpcGroupPerform Data1AsIRemoveNpcGroupPerform()
		{
			return this.Data1<IRemoveNpcGroupPerform>().Value;
		}

		// Token: 0x06029F3B RID: 171835 RVA: 0x005C0824 File Offset: 0x005BEA24
		public IEnableEntityLookAt Data1AsIEnableEntityLookAt()
		{
			return this.Data1<IEnableEntityLookAt>().Value;
		}

		// Token: 0x06029F3C RID: 171836 RVA: 0x005C0840 File Offset: 0x005BEA40
		public IDisableEntityLookAt Data1AsIDisableEntityLookAt()
		{
			return this.Data1<IDisableEntityLookAt>().Value;
		}

		// Token: 0x06029F3D RID: 171837 RVA: 0x005C085C File Offset: 0x005BEA5C
		public IOverrideAiBehaviorTree Data1AsIOverrideAiBehaviorTree()
		{
			return this.Data1<IOverrideAiBehaviorTree>().Value;
		}

		// Token: 0x06029F3E RID: 171838 RVA: 0x005C0878 File Offset: 0x005BEA78
		public IRestoreAiBehaviorTree Data1AsIRestoreAiBehaviorTree()
		{
			return this.Data1<IRestoreAiBehaviorTree>().Value;
		}

		// Token: 0x06029F3F RID: 171839 RVA: 0x005C0894 File Offset: 0x005BEA94
		public IFlowDefineNpcGroupPerform Data1AsIFlowDefineNpcGroupPerform()
		{
			return this.Data1<IFlowDefineNpcGroupPerform>().Value;
		}

		// Token: 0x06029F40 RID: 171840 RVA: 0x005C08B0 File Offset: 0x005BEAB0
		public ISeqEventAddTagToSelf Data1AsISeqEventAddTagToSelf()
		{
			return this.Data1<ISeqEventAddTagToSelf>().Value;
		}

		// Token: 0x06029F41 RID: 171841 RVA: 0x005C08CC File Offset: 0x005BEACC
		public ISeqEventFireBullet Data1AsISeqEventFireBullet()
		{
			return this.Data1<ISeqEventFireBullet>().Value;
		}

		// Token: 0x06029F42 RID: 171842 RVA: 0x005C08E8 File Offset: 0x005BEAE8
		public ITrapDefenseChangeMiniMap Data1AsITrapDefenseChangeMiniMap()
		{
			return this.Data1<ITrapDefenseChangeMiniMap>().Value;
		}

		// Token: 0x06029F43 RID: 171843 RVA: 0x005C0904 File Offset: 0x005BEB04
		public ITrapDefensePlayerOperationConstraint Data1AsITrapDefensePlayerOperationConstraint()
		{
			return this.Data1<ITrapDefensePlayerOperationConstraint>().Value;
		}

		// Token: 0x06029F44 RID: 171844 RVA: 0x005C0920 File Offset: 0x005BEB20
		public IHonamiStoryInteractPickUp Data1AsIHonamiStoryInteractPickUp()
		{
			return this.Data1<IHonamiStoryInteractPickUp>().Value;
		}

		// Token: 0x06029F45 RID: 171845 RVA: 0x005C093C File Offset: 0x005BEB3C
		public IHonamiStoryReceiveCorruptedChestReward Data1AsIHonamiStoryReceiveCorruptedChestReward()
		{
			return this.Data1<IHonamiStoryReceiveCorruptedChestReward>().Value;
		}

		// Token: 0x06029F46 RID: 171846 RVA: 0x005C0958 File Offset: 0x005BEB58
		public IHonamiStoryActivateSafeEvacuation Data1AsIHonamiStoryActivateSafeEvacuation()
		{
			return this.Data1<IHonamiStoryActivateSafeEvacuation>().Value;
		}

		// Token: 0x06029F47 RID: 171847 RVA: 0x005C0974 File Offset: 0x005BEB74
		public IHonamiStorySetFormation Data1AsIHonamiStorySetFormation()
		{
			return this.Data1<IHonamiStorySetFormation>().Value;
		}

		// Token: 0x06029F48 RID: 171848 RVA: 0x005C0990 File Offset: 0x005BEB90
		public IHonamiStoryGetItem Data1AsIHonamiStoryGetItem()
		{
			return this.Data1<IHonamiStoryGetItem>().Value;
		}

		// Token: 0x06029F49 RID: 171849 RVA: 0x005C09AC File Offset: 0x005BEBAC
		public IInfrActivityUpgradeInfrastructure Data1AsIInfrActivityUpgradeInfrastructure()
		{
			return this.Data1<IInfrActivityUpgradeInfrastructure>().Value;
		}

		// Token: 0x06029F4A RID: 171850 RVA: 0x005C09C8 File Offset: 0x005BEBC8
		public IPlayWalkingOverlayMontage Data1AsIPlayWalkingOverlayMontage()
		{
			return this.Data1<IPlayWalkingOverlayMontage>().Value;
		}

		// Token: 0x06029F4B RID: 171851 RVA: 0x005C09E4 File Offset: 0x005BEBE4
		public IEnableKey4Func Data1AsIEnableKey4Func()
		{
			return this.Data1<IEnableKey4Func>().Value;
		}

		// Token: 0x06029F4C RID: 171852 RVA: 0x005C0A00 File Offset: 0x005BEC00
		public IChangeNpcAbpState Data1AsIChangeNpcAbpState()
		{
			return this.Data1<IChangeNpcAbpState>().Value;
		}

		// Token: 0x06029F4D RID: 171853 RVA: 0x005C0A1C File Offset: 0x005BEC1C
		public IOverrideAbpAnimScheme Data1AsIOverrideAbpAnimScheme()
		{
			return this.Data1<IOverrideAbpAnimScheme>().Value;
		}

		// Token: 0x06029F4E RID: 171854 RVA: 0x005C0A38 File Offset: 0x005BEC38
		public ICloseWalkingOverlayMontage Data1AsICloseWalkingOverlayMontage()
		{
			return this.Data1<ICloseWalkingOverlayMontage>().Value;
		}

		// Token: 0x06029F4F RID: 171855 RVA: 0x005C0A54 File Offset: 0x005BEC54
		public ISetMotorSpeed Data1AsISetMotorSpeed()
		{
			return this.Data1<ISetMotorSpeed>().Value;
		}

		// Token: 0x06029F50 RID: 171856 RVA: 0x005C0A70 File Offset: 0x005BEC70
		public IVehicleSetSpeedImmediately Data1AsIVehicleSetSpeedImmediately()
		{
			return this.Data1<IVehicleSetSpeedImmediately>().Value;
		}

		// Token: 0x06029F51 RID: 171857 RVA: 0x005C0A8C File Offset: 0x005BEC8C
		public IStartMotorCruise Data1AsIStartMotorCruise()
		{
			return this.Data1<IStartMotorCruise>().Value;
		}

		// Token: 0x06029F52 RID: 171858 RVA: 0x005C0AA8 File Offset: 0x005BECA8
		public IStopMotorCruise Data1AsIStopMotorCruise()
		{
			return this.Data1<IStopMotorCruise>().Value;
		}

		// Token: 0x06029F53 RID: 171859 RVA: 0x005C0AC4 File Offset: 0x005BECC4
		public IDriveMotorInSpecConfig Data1AsIDriveMotorInSpecConfig()
		{
			return this.Data1<IDriveMotorInSpecConfig>().Value;
		}

		// Token: 0x06029F54 RID: 171860 RVA: 0x005C0AE0 File Offset: 0x005BECE0
		public IMotorSoarInWindField Data1AsIMotorSoarInWindField()
		{
			return this.Data1<IMotorSoarInWindField>().Value;
		}

		// Token: 0x06029F55 RID: 171861 RVA: 0x005C0AFC File Offset: 0x005BECFC
		public ISetSkillBtnEffect Data1AsISetSkillBtnEffect()
		{
			return this.Data1<ISetSkillBtnEffect>().Value;
		}

		// Token: 0x06029F56 RID: 171862 RVA: 0x005C0B18 File Offset: 0x005BED18
		public ICollectSunSpirit Data1AsICollectSunSpirit()
		{
			return this.Data1<ICollectSunSpirit>().Value;
		}

		// Token: 0x06029F57 RID: 171863 RVA: 0x005C0B34 File Offset: 0x005BED34
		public IPerformSunSpiritGearRoundTrip Data1AsIPerformSunSpiritGearRoundTrip()
		{
			return this.Data1<IPerformSunSpiritGearRoundTrip>().Value;
		}

		// Token: 0x06029F58 RID: 171864 RVA: 0x005C0B50 File Offset: 0x005BED50
		public ITriggerDeadeyeMode Data1AsITriggerDeadeyeMode()
		{
			return this.Data1<ITriggerDeadeyeMode>().Value;
		}

		// Token: 0x06029F59 RID: 171865 RVA: 0x005C0B6C File Offset: 0x005BED6C
		public ITriggerSystemRandomPlot Data1AsITriggerSystemRandomPlot()
		{
			return this.Data1<ITriggerSystemRandomPlot>().Value;
		}

		// Token: 0x06029F5A RID: 171866 RVA: 0x005C0B88 File Offset: 0x005BED88
		public ISetAudioEnable Data1AsISetAudioEnable()
		{
			return this.Data1<ISetAudioEnable>().Value;
		}

		// Token: 0x06029F5B RID: 171867 RVA: 0x005C0BA4 File Offset: 0x005BEDA4
		public IPhoneSystemInteract Data1AsIPhoneSystemInteract()
		{
			return this.Data1<IPhoneSystemInteract>().Value;
		}

		// Token: 0x06029F5C RID: 171868 RVA: 0x005C0BC0 File Offset: 0x005BEDC0
		public IRollBlockGetReward Data1AsIRollBlockGetReward()
		{
			return this.Data1<IRollBlockGetReward>().Value;
		}

		// Token: 0x06029F5D RID: 171869 RVA: 0x005C0BDC File Offset: 0x005BEDDC
		public IEnterMovieMode Data1AsIEnterMovieMode()
		{
			return this.Data1<IEnterMovieMode>().Value;
		}

		// Token: 0x06029F5E RID: 171870 RVA: 0x005C0BF8 File Offset: 0x005BEDF8
		public IExitMovieMode Data1AsIExitMovieMode()
		{
			return this.Data1<IExitMovieMode>().Value;
		}

		// Token: 0x06029F5F RID: 171871 RVA: 0x005C0C14 File Offset: 0x005BEE14
		public IStartRoadNetworkNavigation Data1AsIStartRoadNetworkNavigation()
		{
			return this.Data1<IStartRoadNetworkNavigation>().Value;
		}

		// Token: 0x06029F60 RID: 171872 RVA: 0x005C0C30 File Offset: 0x005BEE30
		public ISetWayOccupancyState Data1AsISetWayOccupancyState()
		{
			return this.Data1<ISetWayOccupancyState>().Value;
		}

		// Token: 0x06029F61 RID: 171873 RVA: 0x005C0C4C File Offset: 0x005BEE4C
		public IEnterPatrolState Data1AsIEnterPatrolState()
		{
			return this.Data1<IEnterPatrolState>().Value;
		}

		// Token: 0x06029F62 RID: 171874 RVA: 0x005C0C68 File Offset: 0x005BEE68
		public IPerformAiHideSelf Data1AsIPerformAiHideSelf()
		{
			return this.Data1<IPerformAiHideSelf>().Value;
		}

		// Token: 0x06029F63 RID: 171875 RVA: 0x005C0C84 File Offset: 0x005BEE84
		public ISendSceneActorEvent Data1AsISendSceneActorEvent()
		{
			return this.Data1<ISendSceneActorEvent>().Value;
		}

		// Token: 0x06029F64 RID: 171876 RVA: 0x005C0CA0 File Offset: 0x005BEEA0
		public IExecBpActorFunc Data1AsIExecBpActorFunc()
		{
			return this.Data1<IExecBpActorFunc>().Value;
		}

		// Token: 0x06029F65 RID: 171877 RVA: 0x005C0CBC File Offset: 0x005BEEBC
		public IResetPlayerPosWithPresentation Data1AsIResetPlayerPosWithPresentation()
		{
			return this.Data1<IResetPlayerPosWithPresentation>().Value;
		}

		// Token: 0x06029F66 RID: 171878 RVA: 0x005C0CD8 File Offset: 0x005BEED8
		public IDrinksRollRoleRequirement Data1AsIDrinksRollRoleRequirement()
		{
			return this.Data1<IDrinksRollRoleRequirement>().Value;
		}

		// Token: 0x06029F67 RID: 171879 RVA: 0x005C0CF4 File Offset: 0x005BEEF4
		public ISetBlendAnim Data1AsISetBlendAnim()
		{
			return this.Data1<ISetBlendAnim>().Value;
		}

		// Token: 0x06029F68 RID: 171880 RVA: 0x005C0D10 File Offset: 0x005BEF10
		public IReportTrackingEvent Data1AsIReportTrackingEvent()
		{
			return this.Data1<IReportTrackingEvent>().Value;
		}

		// Token: 0x06029F69 RID: 171881 RVA: 0x005C0D2C File Offset: 0x005BEF2C
		public ITetrisThrowBlock Data1AsITetrisThrowBlock()
		{
			return this.Data1<ITetrisThrowBlock>().Value;
		}

		// Token: 0x06029F6A RID: 171882 RVA: 0x005C0D48 File Offset: 0x005BEF48
		public ITetrisGameComplete Data1AsITetrisGameComplete()
		{
			return this.Data1<ITetrisGameComplete>().Value;
		}

		// Token: 0x06029F6B RID: 171883 RVA: 0x005C0D64 File Offset: 0x005BEF64
		public ITetrisTriggerDelayFall Data1AsITetrisTriggerDelayFall()
		{
			return this.Data1<ITetrisTriggerDelayFall>().Value;
		}

		// Token: 0x06029F6C RID: 171884 RVA: 0x005C0D80 File Offset: 0x005BEF80
		public IBossPilingRandomBuff Data1AsIBossPilingRandomBuff()
		{
			return this.Data1<IBossPilingRandomBuff>().Value;
		}

		// Token: 0x06029F6D RID: 171885 RVA: 0x005C0D9C File Offset: 0x005BEF9C
		public IBossPilingEnterNextInst Data1AsIBossPilingEnterNextInst()
		{
			return this.Data1<IBossPilingEnterNextInst>().Value;
		}

		// Token: 0x06029F6E RID: 171886 RVA: 0x005C0DB8 File Offset: 0x005BEFB8
		public IOpenQuickHackSystem Data1AsIOpenQuickHackSystem()
		{
			return this.Data1<IOpenQuickHackSystem>().Value;
		}

		// Token: 0x06029F6F RID: 171887 RVA: 0x005C0DD4 File Offset: 0x005BEFD4
		public IDollGrabItemDelivery Data1AsIDollGrabItemDelivery()
		{
			return this.Data1<IDollGrabItemDelivery>().Value;
		}

		// Token: 0x06029F70 RID: 171888 RVA: 0x005C0DF0 File Offset: 0x005BEFF0
		public ISheriffUnlockClue Data1AsISheriffUnlockClue()
		{
			return this.Data1<ISheriffUnlockClue>().Value;
		}

		// Token: 0x06029F71 RID: 171889 RVA: 0x005C0E0C File Offset: 0x005BF00C
		public ISheriffUnlockProgress Data1AsISheriffUnlockProgress()
		{
			return this.Data1<ISheriffUnlockProgress>().Value;
		}

		// Token: 0x06029F72 RID: 171890 RVA: 0x005C0E28 File Offset: 0x005BF028
		public ISheriffChangeCriminalState Data1AsISheriffChangeCriminalState()
		{
			return this.Data1<ISheriffChangeCriminalState>().Value;
		}

		// Token: 0x06029F73 RID: 171891 RVA: 0x005C0E44 File Offset: 0x005BF044
		public ISheriffChangeCriminalIdentity Data1AsISheriffChangeCriminalIdentity()
		{
			return this.Data1<ISheriffChangeCriminalIdentity>().Value;
		}

		// Token: 0x06029F74 RID: 171892 RVA: 0x005C0E60 File Offset: 0x005BF060
		public ISheriffUnlockEnding Data1AsISheriffUnlockEnding()
		{
			return this.Data1<ISheriffUnlockEnding>().Value;
		}

		// Token: 0x06029F75 RID: 171893 RVA: 0x005C0E7C File Offset: 0x005BF07C
		public ISetTargetElementalAbility Data1AsISetTargetElementalAbility()
		{
			return this.Data1<ISetTargetElementalAbility>().Value;
		}

		// Token: 0x06029F76 RID: 171894 RVA: 0x005C0E98 File Offset: 0x005BF098
		public IToggleEntityElementalAbility Data1AsIToggleEntityElementalAbility()
		{
			return this.Data1<IToggleEntityElementalAbility>().Value;
		}

		// Token: 0x06029F77 RID: 171895 RVA: 0x005C0EB4 File Offset: 0x005BF0B4
		public ICaptureElementalBox Data1AsICaptureElementalBox()
		{
			return this.Data1<ICaptureElementalBox>().Value;
		}

		// Token: 0x06029F78 RID: 171896 RVA: 0x005C0ED0 File Offset: 0x005BF0D0
		public IChangeElementalBoxState Data1AsIChangeElementalBoxState()
		{
			return this.Data1<IChangeElementalBoxState>().Value;
		}

		// Token: 0x06029F79 RID: 171897 RVA: 0x005C0EEC File Offset: 0x005BF0EC
		public ISetElementalBoxToTarget Data1AsISetElementalBoxToTarget()
		{
			return this.Data1<ISetElementalBoxToTarget>().Value;
		}

		// Token: 0x06029F7A RID: 171898 RVA: 0x005C0F07 File Offset: 0x005BF107
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

		// Token: 0x06029F7B RID: 171899 RVA: 0x005C0F3B File Offset: 0x005BF13B
		public static void StartIActionParams_Union(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029F7C RID: 171900 RVA: 0x005C0F44 File Offset: 0x005BF144
		public static void AddUnionIndex(FlatBufferBuilder builder, byte unionIndex)
		{
			builder.AddByte(0, unionIndex, 0);
		}

		// Token: 0x06029F7D RID: 171901 RVA: 0x005C0F4F File Offset: 0x005BF14F
		public static void AddData0Type(FlatBufferBuilder builder, IActionParams_Union_0 data0Type)
		{
			builder.AddByte(1, (byte)data0Type, 0);
		}

		// Token: 0x06029F7E RID: 171902 RVA: 0x005C0F5A File Offset: 0x005BF15A
		public static void AddData0(FlatBufferBuilder builder, int data0Offset)
		{
			builder.AddOffset(2, data0Offset, 0);
		}

		// Token: 0x06029F7F RID: 171903 RVA: 0x005C0F65 File Offset: 0x005BF165
		public static void AddData1Type(FlatBufferBuilder builder, IActionParams_Union_1 data1Type)
		{
			builder.AddByte(3, (byte)data1Type, 0);
		}

		// Token: 0x06029F80 RID: 171904 RVA: 0x005C0F70 File Offset: 0x005BF170
		public static void AddData1(FlatBufferBuilder builder, int data1Offset)
		{
			builder.AddOffset(4, data1Offset, 0);
		}

		// Token: 0x06029F81 RID: 171905 RVA: 0x005C0F7B File Offset: 0x005BF17B
		public static Offset<IActionParams_Union> EndIActionParams_Union(FlatBufferBuilder builder)
		{
			return new Offset<IActionParams_Union>(builder.EndTable());
		}

		// Token: 0x06029F82 RID: 171906 RVA: 0x005C0F88 File Offset: 0x005BF188
		public IActionParams_UnionT UnPack()
		{
			IActionParams_UnionT actionParams_UnionT = new IActionParams_UnionT();
			this.UnPackTo(actionParams_UnionT);
			return actionParams_UnionT;
		}

		// Token: 0x06029F83 RID: 171907 RVA: 0x005C0FA4 File Offset: 0x005BF1A4
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
			case IActionParams_Union_0.ICloseSimpleGameplay:
				_o.Data0.Value = ((this.Data0<ICloseSimpleGameplay>() != null) ? this.Data0<ICloseSimpleGameplay>().Value.UnPack() : null);
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
			case IActionParams_Union_0.IEnterOrbitalCamera:
				_o.Data0.Value = ((this.Data0<IEnterOrbitalCamera>() != null) ? this.Data0<IEnterOrbitalCamera>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IExitOrbitalCamera:
				_o.Data0.Value = ((this.Data0<IExitOrbitalCamera>() != null) ? this.Data0<IExitOrbitalCamera>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableSplineMoveModel:
				_o.Data0.Value = ((this.Data0<IEnableSplineMoveModel>() != null) ? this.Data0<IEnableSplineMoveModel>().Value.UnPack() : null);
				break;
			case IActionParams_Union_0.IEnableActor:
				_o.Data0.Value = ((this.Data0<IEnableActor>() != null) ? this.Data0<IEnableActor>().Value.UnPack() : null);
				break;
			}
			_o.Data1 = new IActionParams_Union_1Union();
			_o.Data1.Type = this.Data1Type;
			switch (this.Data1Type)
			{
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
			default:
				return;
			}
		}

		// Token: 0x06029F84 RID: 171908 RVA: 0x005C9A84 File Offset: 0x005C7C84
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

		// Token: 0x0401025E RID: 66142
		private Table __p;
	}
}
