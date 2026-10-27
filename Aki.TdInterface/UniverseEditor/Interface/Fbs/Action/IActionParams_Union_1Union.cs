using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608D RID: 24717
	public class IActionParams_Union_1Union
	{
		// Token: 0x1700B62B RID: 46635
		// (get) Token: 0x0602A193 RID: 172435 RVA: 0x005CE295 File Offset: 0x005CC495
		// (set) Token: 0x0602A194 RID: 172436 RVA: 0x005CE29D File Offset: 0x005CC49D
		public IActionParams_Union_1 Type { get; set; }

		// Token: 0x1700B62C RID: 46636
		// (get) Token: 0x0602A195 RID: 172437 RVA: 0x005CE2A6 File Offset: 0x005CC4A6
		// (set) Token: 0x0602A196 RID: 172438 RVA: 0x005CE2AE File Offset: 0x005CC4AE
		public object Value { get; set; }

		// Token: 0x0602A197 RID: 172439 RVA: 0x005CE2B7 File Offset: 0x005CC4B7
		public IActionParams_Union_1Union()
		{
			this.Type = IActionParams_Union_1.NONE;
			this.Value = null;
		}

		// Token: 0x0602A198 RID: 172440 RVA: 0x005CE2CD File Offset: 0x005CC4CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A199 RID: 172441 RVA: 0x005CE2DF File Offset: 0x005CC4DF
		public ISetSportsStateT AsISetSportsState()
		{
			return this.As<ISetSportsStateT>();
		}

		// Token: 0x0602A19A RID: 172442 RVA: 0x005CE2E7 File Offset: 0x005CC4E7
		public static IActionParams_Union_1Union FromISetSportsState(ISetSportsStateT _isetsportsstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSportsState,
				Value = _isetsportsstate
			};
		}

		// Token: 0x0602A19B RID: 172443 RVA: 0x005CE2FC File Offset: 0x005CC4FC
		public ISetExploreStateT AsISetExploreState()
		{
			return this.As<ISetExploreStateT>();
		}

		// Token: 0x0602A19C RID: 172444 RVA: 0x005CE304 File Offset: 0x005CC504
		public static IActionParams_Union_1Union FromISetExploreState(ISetExploreStateT _isetexplorestate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetExploreState,
				Value = _isetexplorestate
			};
		}

		// Token: 0x0602A19D RID: 172445 RVA: 0x005CE319 File Offset: 0x005CC519
		public IModifyActorMaterialT AsIModifyActorMaterial()
		{
			return this.As<IModifyActorMaterialT>();
		}

		// Token: 0x0602A19E RID: 172446 RVA: 0x005CE321 File Offset: 0x005CC521
		public static IActionParams_Union_1Union FromIModifyActorMaterial(IModifyActorMaterialT _imodifyactormaterial)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMaterial,
				Value = _imodifyactormaterial
			};
		}

		// Token: 0x0602A19F RID: 172447 RVA: 0x005CE336 File Offset: 0x005CC536
		public IModifyActorMaterialParamBySplineProgressT AsIModifyActorMaterialParamBySplineProgress()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressT>();
		}

		// Token: 0x0602A1A0 RID: 172448 RVA: 0x005CE33E File Offset: 0x005CC53E
		public static IActionParams_Union_1Union FromIModifyActorMaterialParamBySplineProgress(IModifyActorMaterialParamBySplineProgressT _imodifyactormaterialparambysplineprogress)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMaterialParamBySplineProgress,
				Value = _imodifyactormaterialparambysplineprogress
			};
		}

		// Token: 0x0602A1A1 RID: 172449 RVA: 0x005CE353 File Offset: 0x005CC553
		public IModifyActorMediaT AsIModifyActorMedia()
		{
			return this.As<IModifyActorMediaT>();
		}

		// Token: 0x0602A1A2 RID: 172450 RVA: 0x005CE35B File Offset: 0x005CC55B
		public static IActionParams_Union_1Union FromIModifyActorMedia(IModifyActorMediaT _imodifyactormedia)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMedia,
				Value = _imodifyactormedia
			};
		}

		// Token: 0x0602A1A3 RID: 172451 RVA: 0x005CE370 File Offset: 0x005CC570
		public IPlayLevelSequenceT AsIPlayLevelSequence()
		{
			return this.As<IPlayLevelSequenceT>();
		}

		// Token: 0x0602A1A4 RID: 172452 RVA: 0x005CE378 File Offset: 0x005CC578
		public static IActionParams_Union_1Union FromIPlayLevelSequence(IPlayLevelSequenceT _iplaylevelsequence)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayLevelSequence,
				Value = _iplaylevelsequence
			};
		}

		// Token: 0x0602A1A5 RID: 172453 RVA: 0x005CE38D File Offset: 0x005CC58D
		public IEnableTakePhotoClipT AsIEnableTakePhotoClip()
		{
			return this.As<IEnableTakePhotoClipT>();
		}

		// Token: 0x0602A1A6 RID: 172454 RVA: 0x005CE395 File Offset: 0x005CC595
		public static IActionParams_Union_1Union FromIEnableTakePhotoClip(IEnableTakePhotoClipT _ienabletakephotoclip)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableTakePhotoClip,
				Value = _ienabletakephotoclip
			};
		}

		// Token: 0x0602A1A7 RID: 172455 RVA: 0x005CE3AA File Offset: 0x005CC5AA
		public IToggleAirWallT AsIToggleAirWall()
		{
			return this.As<IToggleAirWallT>();
		}

		// Token: 0x0602A1A8 RID: 172456 RVA: 0x005CE3B2 File Offset: 0x005CC5B2
		public static IActionParams_Union_1Union FromIToggleAirWall(IToggleAirWallT _itoggleairwall)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleAirWall,
				Value = _itoggleairwall
			};
		}

		// Token: 0x0602A1A9 RID: 172457 RVA: 0x005CE3C7 File Offset: 0x005CC5C7
		public ITriggerCameraShakeT AsITriggerCameraShake()
		{
			return this.As<ITriggerCameraShakeT>();
		}

		// Token: 0x0602A1AA RID: 172458 RVA: 0x005CE3CF File Offset: 0x005CC5CF
		public static IActionParams_Union_1Union FromITriggerCameraShake(ITriggerCameraShakeT _itriggercamerashake)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerCameraShake,
				Value = _itriggercamerashake
			};
		}

		// Token: 0x0602A1AB RID: 172459 RVA: 0x005CE3E5 File Offset: 0x005CC5E5
		public ITriggerGamepadShakeT AsITriggerGamepadShake()
		{
			return this.As<ITriggerGamepadShakeT>();
		}

		// Token: 0x0602A1AC RID: 172460 RVA: 0x005CE3ED File Offset: 0x005CC5ED
		public static IActionParams_Union_1Union FromITriggerGamepadShake(ITriggerGamepadShakeT _itriggergamepadshake)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerGamepadShake,
				Value = _itriggergamepadshake
			};
		}

		// Token: 0x0602A1AD RID: 172461 RVA: 0x005CE403 File Offset: 0x005CC603
		public IPlayRegisteredMontageT AsIPlayRegisteredMontage()
		{
			return this.As<IPlayRegisteredMontageT>();
		}

		// Token: 0x0602A1AE RID: 172462 RVA: 0x005CE40B File Offset: 0x005CC60B
		public static IActionParams_Union_1Union FromIPlayRegisteredMontage(IPlayRegisteredMontageT _iplayregisteredmontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayRegisteredMontage,
				Value = _iplayregisteredmontage
			};
		}

		// Token: 0x0602A1AF RID: 172463 RVA: 0x005CE421 File Offset: 0x005CC621
		public ICreatePrefabT AsICreatePrefab()
		{
			return this.As<ICreatePrefabT>();
		}

		// Token: 0x0602A1B0 RID: 172464 RVA: 0x005CE429 File Offset: 0x005CC629
		public static IActionParams_Union_1Union FromICreatePrefab(ICreatePrefabT _icreateprefab)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICreatePrefab,
				Value = _icreateprefab
			};
		}

		// Token: 0x0602A1B1 RID: 172465 RVA: 0x005CE43F File Offset: 0x005CC63F
		public IDestroyPrefabT AsIDestroyPrefab()
		{
			return this.As<IDestroyPrefabT>();
		}

		// Token: 0x0602A1B2 RID: 172466 RVA: 0x005CE447 File Offset: 0x005CC647
		public static IActionParams_Union_1Union FromIDestroyPrefab(IDestroyPrefabT _idestroyprefab)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDestroyPrefab,
				Value = _idestroyprefab
			};
		}

		// Token: 0x0602A1B3 RID: 172467 RVA: 0x005CE45D File Offset: 0x005CC65D
		public ISetDataLayerTransitionsT AsISetDataLayerTransitions()
		{
			return this.As<ISetDataLayerTransitionsT>();
		}

		// Token: 0x0602A1B4 RID: 172468 RVA: 0x005CE465 File Offset: 0x005CC665
		public static IActionParams_Union_1Union FromISetDataLayerTransitions(ISetDataLayerTransitionsT _isetdatalayertransitions)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetDataLayerTransitions,
				Value = _isetdatalayertransitions
			};
		}

		// Token: 0x0602A1B5 RID: 172469 RVA: 0x005CE47B File Offset: 0x005CC67B
		public IEnableAoiNotifyT AsIEnableAoiNotify()
		{
			return this.As<IEnableAoiNotifyT>();
		}

		// Token: 0x0602A1B6 RID: 172470 RVA: 0x005CE483 File Offset: 0x005CC683
		public static IActionParams_Union_1Union FromIEnableAoiNotify(IEnableAoiNotifyT _ienableaoinotify)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableAoiNotify,
				Value = _ienableaoinotify
			};
		}

		// Token: 0x0602A1B7 RID: 172471 RVA: 0x005CE499 File Offset: 0x005CC699
		public IRecoverDurabilityT AsIRecoverDurability()
		{
			return this.As<IRecoverDurabilityT>();
		}

		// Token: 0x0602A1B8 RID: 172472 RVA: 0x005CE4A1 File Offset: 0x005CC6A1
		public static IActionParams_Union_1Union FromIRecoverDurability(IRecoverDurabilityT _irecoverdurability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRecoverDurability,
				Value = _irecoverdurability
			};
		}

		// Token: 0x0602A1B9 RID: 172473 RVA: 0x005CE4B7 File Offset: 0x005CC6B7
		public ISetPlayerOperationRestrictionT AsISetPlayerOperationRestriction()
		{
			return this.As<ISetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602A1BA RID: 172474 RVA: 0x005CE4BF File Offset: 0x005CC6BF
		public static IActionParams_Union_1Union FromISetPlayerOperationRestriction(ISetPlayerOperationRestrictionT _isetplayeroperationrestriction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetPlayerOperationRestriction,
				Value = _isetplayeroperationrestriction
			};
		}

		// Token: 0x0602A1BB RID: 172475 RVA: 0x005CE4D5 File Offset: 0x005CC6D5
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x0602A1BC RID: 172476 RVA: 0x005CE4DD File Offset: 0x005CC6DD
		public static IActionParams_Union_1Union FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x0602A1BD RID: 172477 RVA: 0x005CE4F3 File Offset: 0x005CC6F3
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x0602A1BE RID: 172478 RVA: 0x005CE4FB File Offset: 0x005CC6FB
		public static IActionParams_Union_1Union FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x0602A1BF RID: 172479 RVA: 0x005CE511 File Offset: 0x005CC711
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x0602A1C0 RID: 172480 RVA: 0x005CE519 File Offset: 0x005CC719
		public static IActionParams_Union_1Union FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x0602A1C1 RID: 172481 RVA: 0x005CE52F File Offset: 0x005CC72F
		public IClientSetPlayerOperationRestrictionT AsIClientSetPlayerOperationRestriction()
		{
			return this.As<IClientSetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602A1C2 RID: 172482 RVA: 0x005CE537 File Offset: 0x005CC737
		public static IActionParams_Union_1Union FromIClientSetPlayerOperationRestriction(IClientSetPlayerOperationRestrictionT _iclientsetplayeroperationrestriction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientSetPlayerOperationRestriction,
				Value = _iclientsetplayeroperationrestriction
			};
		}

		// Token: 0x0602A1C3 RID: 172483 RVA: 0x005CE54D File Offset: 0x005CC74D
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x0602A1C4 RID: 172484 RVA: 0x005CE555 File Offset: 0x005CC755
		public static IActionParams_Union_1Union FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x0602A1C5 RID: 172485 RVA: 0x005CE56B File Offset: 0x005CC76B
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0602A1C6 RID: 172486 RVA: 0x005CE573 File Offset: 0x005CC773
		public static IActionParams_Union_1Union FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0602A1C7 RID: 172487 RVA: 0x005CE589 File Offset: 0x005CC789
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0602A1C8 RID: 172488 RVA: 0x005CE591 File Offset: 0x005CC791
		public static IActionParams_Union_1Union FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x0602A1C9 RID: 172489 RVA: 0x005CE5A7 File Offset: 0x005CC7A7
		public IEnableFunctionT AsIEnableFunction()
		{
			return this.As<IEnableFunctionT>();
		}

		// Token: 0x0602A1CA RID: 172490 RVA: 0x005CE5AF File Offset: 0x005CC7AF
		public static IActionParams_Union_1Union FromIEnableFunction(IEnableFunctionT _ienablefunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableFunction,
				Value = _ienablefunction
			};
		}

		// Token: 0x0602A1CB RID: 172491 RVA: 0x005CE5C5 File Offset: 0x005CC7C5
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x0602A1CC RID: 172492 RVA: 0x005CE5CD File Offset: 0x005CC7CD
		public static IActionParams_Union_1Union FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x0602A1CD RID: 172493 RVA: 0x005CE5E3 File Offset: 0x005CC7E3
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x0602A1CE RID: 172494 RVA: 0x005CE5EB File Offset: 0x005CC7EB
		public static IActionParams_Union_1Union FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x0602A1CF RID: 172495 RVA: 0x005CE601 File Offset: 0x005CC801
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x0602A1D0 RID: 172496 RVA: 0x005CE609 File Offset: 0x005CC809
		public static IActionParams_Union_1Union FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x0602A1D1 RID: 172497 RVA: 0x005CE61F File Offset: 0x005CC81F
		public IEnableClientFunctionT AsIEnableClientFunction()
		{
			return this.As<IEnableClientFunctionT>();
		}

		// Token: 0x0602A1D2 RID: 172498 RVA: 0x005CE627 File Offset: 0x005CC827
		public static IActionParams_Union_1Union FromIEnableClientFunction(IEnableClientFunctionT _ienableclientfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableClientFunction,
				Value = _ienableclientfunction
			};
		}

		// Token: 0x0602A1D3 RID: 172499 RVA: 0x005CE63D File Offset: 0x005CC83D
		public IHealthBarDisplayClientFunctionT AsIHealthBarDisplayClientFunction()
		{
			return this.As<IHealthBarDisplayClientFunctionT>();
		}

		// Token: 0x0602A1D4 RID: 172500 RVA: 0x005CE645 File Offset: 0x005CC845
		public static IActionParams_Union_1Union FromIHealthBarDisplayClientFunction(IHealthBarDisplayClientFunctionT _ihealthbardisplayclientfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHealthBarDisplayClientFunction,
				Value = _ihealthbardisplayclientfunction
			};
		}

		// Token: 0x0602A1D5 RID: 172501 RVA: 0x005CE65B File Offset: 0x005CC85B
		public IChangeEntityPrefabPerformanceT AsIChangeEntityPrefabPerformance()
		{
			return this.As<IChangeEntityPrefabPerformanceT>();
		}

		// Token: 0x0602A1D6 RID: 172502 RVA: 0x005CE663 File Offset: 0x005CC863
		public static IActionParams_Union_1Union FromIChangeEntityPrefabPerformance(IChangeEntityPrefabPerformanceT _ichangeentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeEntityPrefabPerformance,
				Value = _ichangeentityprefabperformance
			};
		}

		// Token: 0x0602A1D7 RID: 172503 RVA: 0x005CE679 File Offset: 0x005CC879
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x0602A1D8 RID: 172504 RVA: 0x005CE681 File Offset: 0x005CC881
		public static IActionParams_Union_1Union FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x0602A1D9 RID: 172505 RVA: 0x005CE697 File Offset: 0x005CC897
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x0602A1DA RID: 172506 RVA: 0x005CE69F File Offset: 0x005CC89F
		public static IActionParams_Union_1Union FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x0602A1DB RID: 172507 RVA: 0x005CE6B5 File Offset: 0x005CC8B5
		public IModifySceneItemAttributeTagT AsIModifySceneItemAttributeTag()
		{
			return this.As<IModifySceneItemAttributeTagT>();
		}

		// Token: 0x0602A1DC RID: 172508 RVA: 0x005CE6BD File Offset: 0x005CC8BD
		public static IActionParams_Union_1Union FromIModifySceneItemAttributeTag(IModifySceneItemAttributeTagT _imodifysceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifySceneItemAttributeTag,
				Value = _imodifysceneitemattributetag
			};
		}

		// Token: 0x0602A1DD RID: 172509 RVA: 0x005CE6D3 File Offset: 0x005CC8D3
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x0602A1DE RID: 172510 RVA: 0x005CE6DB File Offset: 0x005CC8DB
		public static IActionParams_Union_1Union FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x0602A1DF RID: 172511 RVA: 0x005CE6F1 File Offset: 0x005CC8F1
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x0602A1E0 RID: 172512 RVA: 0x005CE6F9 File Offset: 0x005CC8F9
		public static IActionParams_Union_1Union FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x0602A1E1 RID: 172513 RVA: 0x005CE70F File Offset: 0x005CC90F
		public IClientModifyTargetTagT AsIClientModifyTargetTag()
		{
			return this.As<IClientModifyTargetTagT>();
		}

		// Token: 0x0602A1E2 RID: 172514 RVA: 0x005CE717 File Offset: 0x005CC917
		public static IActionParams_Union_1Union FromIClientModifyTargetTag(IClientModifyTargetTagT _iclientmodifytargettag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientModifyTargetTag,
				Value = _iclientmodifytargettag
			};
		}

		// Token: 0x0602A1E3 RID: 172515 RVA: 0x005CE72D File Offset: 0x005CC92D
		public IToggleMapMarkStateT AsIToggleMapMarkState()
		{
			return this.As<IToggleMapMarkStateT>();
		}

		// Token: 0x0602A1E4 RID: 172516 RVA: 0x005CE735 File Offset: 0x005CC935
		public static IActionParams_Union_1Union FromIToggleMapMarkState(IToggleMapMarkStateT _itogglemapmarkstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleMapMarkState,
				Value = _itogglemapmarkstate
			};
		}

		// Token: 0x0602A1E5 RID: 172517 RVA: 0x005CE74B File Offset: 0x005CC94B
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x0602A1E6 RID: 172518 RVA: 0x005CE753 File Offset: 0x005CC953
		public static IActionParams_Union_1Union FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x0602A1E7 RID: 172519 RVA: 0x005CE769 File Offset: 0x005CC969
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x0602A1E8 RID: 172520 RVA: 0x005CE771 File Offset: 0x005CC971
		public static IActionParams_Union_1Union FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x0602A1E9 RID: 172521 RVA: 0x005CE787 File Offset: 0x005CC987
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x0602A1EA RID: 172522 RVA: 0x005CE78F File Offset: 0x005CC98F
		public static IActionParams_Union_1Union FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x0602A1EB RID: 172523 RVA: 0x005CE7A5 File Offset: 0x005CC9A5
		public IFocusOnMapMarkActionT AsIFocusOnMapMarkAction()
		{
			return this.As<IFocusOnMapMarkActionT>();
		}

		// Token: 0x0602A1EC RID: 172524 RVA: 0x005CE7AD File Offset: 0x005CC9AD
		public static IActionParams_Union_1Union FromIFocusOnMapMarkAction(IFocusOnMapMarkActionT _ifocusonmapmarkaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IFocusOnMapMarkAction,
				Value = _ifocusonmapmarkaction
			};
		}

		// Token: 0x0602A1ED RID: 172525 RVA: 0x005CE7C3 File Offset: 0x005CC9C3
		public IEnableTemporaryTeleportT AsIEnableTemporaryTeleport()
		{
			return this.As<IEnableTemporaryTeleportT>();
		}

		// Token: 0x0602A1EE RID: 172526 RVA: 0x005CE7CB File Offset: 0x005CC9CB
		public static IActionParams_Union_1Union FromIEnableTemporaryTeleport(IEnableTemporaryTeleportT _ienabletemporaryteleport)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableTemporaryTeleport,
				Value = _ienabletemporaryteleport
			};
		}

		// Token: 0x0602A1EF RID: 172527 RVA: 0x005CE7E1 File Offset: 0x005CC9E1
		public ISetRegionConfigT AsISetRegionConfig()
		{
			return this.As<ISetRegionConfigT>();
		}

		// Token: 0x0602A1F0 RID: 172528 RVA: 0x005CE7E9 File Offset: 0x005CC9E9
		public static IActionParams_Union_1Union FromISetRegionConfig(ISetRegionConfigT _isetregionconfig)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetRegionConfig,
				Value = _isetregionconfig
			};
		}

		// Token: 0x0602A1F1 RID: 172529 RVA: 0x005CE7FF File Offset: 0x005CC9FF
		public ISetRegionMpcT AsISetRegionMpc()
		{
			return this.As<ISetRegionMpcT>();
		}

		// Token: 0x0602A1F2 RID: 172530 RVA: 0x005CE807 File Offset: 0x005CCA07
		public static IActionParams_Union_1Union FromISetRegionMpc(ISetRegionMpcT _isetregionmpc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetRegionMpc,
				Value = _isetregionmpc
			};
		}

		// Token: 0x0602A1F3 RID: 172531 RVA: 0x005CE81D File Offset: 0x005CCA1D
		public ISetJigsawItemT AsISetJigsawItem()
		{
			return this.As<ISetJigsawItemT>();
		}

		// Token: 0x0602A1F4 RID: 172532 RVA: 0x005CE825 File Offset: 0x005CCA25
		public static IActionParams_Union_1Union FromISetJigsawItem(ISetJigsawItemT _isetjigsawitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetJigsawItem,
				Value = _isetjigsawitem
			};
		}

		// Token: 0x0602A1F5 RID: 172533 RVA: 0x005CE83B File Offset: 0x005CCA3B
		public ISetJigsawFoundationT AsISetJigsawFoundation()
		{
			return this.As<ISetJigsawFoundationT>();
		}

		// Token: 0x0602A1F6 RID: 172534 RVA: 0x005CE843 File Offset: 0x005CCA43
		public static IActionParams_Union_1Union FromISetJigsawFoundation(ISetJigsawFoundationT _isetjigsawfoundation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetJigsawFoundation,
				Value = _isetjigsawfoundation
			};
		}

		// Token: 0x0602A1F7 RID: 172535 RVA: 0x005CE859 File Offset: 0x005CCA59
		public IToggleHighlightExploreUiT AsIToggleHighlightExploreUi()
		{
			return this.As<IToggleHighlightExploreUiT>();
		}

		// Token: 0x0602A1F8 RID: 172536 RVA: 0x005CE861 File Offset: 0x005CCA61
		public static IActionParams_Union_1Union FromIToggleHighlightExploreUi(IToggleHighlightExploreUiT _itogglehighlightexploreui)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleHighlightExploreUi,
				Value = _itogglehighlightexploreui
			};
		}

		// Token: 0x0602A1F9 RID: 172537 RVA: 0x005CE877 File Offset: 0x005CCA77
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x0602A1FA RID: 172538 RVA: 0x005CE87F File Offset: 0x005CCA7F
		public static IActionParams_Union_1Union FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x0602A1FB RID: 172539 RVA: 0x005CE895 File Offset: 0x005CCA95
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x0602A1FC RID: 172540 RVA: 0x005CE89D File Offset: 0x005CCA9D
		public static IActionParams_Union_1Union FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x0602A1FD RID: 172541 RVA: 0x005CE8B3 File Offset: 0x005CCAB3
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x0602A1FE RID: 172542 RVA: 0x005CE8BB File Offset: 0x005CCABB
		public static IActionParams_Union_1Union FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x0602A1FF RID: 172543 RVA: 0x005CE8D1 File Offset: 0x005CCAD1
		public IResetEntityT AsIResetEntity()
		{
			return this.As<IResetEntityT>();
		}

		// Token: 0x0602A200 RID: 172544 RVA: 0x005CE8D9 File Offset: 0x005CCAD9
		public static IActionParams_Union_1Union FromIResetEntity(IResetEntityT _iresetentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetEntity,
				Value = _iresetentity
			};
		}

		// Token: 0x0602A201 RID: 172545 RVA: 0x005CE8EF File Offset: 0x005CCAEF
		public IResetLevelPlayT AsIResetLevelPlay()
		{
			return this.As<IResetLevelPlayT>();
		}

		// Token: 0x0602A202 RID: 172546 RVA: 0x005CE8F7 File Offset: 0x005CCAF7
		public static IActionParams_Union_1Union FromIResetLevelPlay(IResetLevelPlayT _iresetlevelplay)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetLevelPlay,
				Value = _iresetlevelplay
			};
		}

		// Token: 0x0602A203 RID: 172547 RVA: 0x005CE90D File Offset: 0x005CCB0D
		public IPlayDynamicSettlementT AsIPlayDynamicSettlement()
		{
			return this.As<IPlayDynamicSettlementT>();
		}

		// Token: 0x0602A204 RID: 172548 RVA: 0x005CE915 File Offset: 0x005CCB15
		public static IActionParams_Union_1Union FromIPlayDynamicSettlement(IPlayDynamicSettlementT _iplaydynamicsettlement)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayDynamicSettlement,
				Value = _iplaydynamicsettlement
			};
		}

		// Token: 0x0602A205 RID: 172549 RVA: 0x005CE92B File Offset: 0x005CCB2B
		public ISetInteractionLockStateT AsISetInteractionLockState()
		{
			return this.As<ISetInteractionLockStateT>();
		}

		// Token: 0x0602A206 RID: 172550 RVA: 0x005CE933 File Offset: 0x005CCB33
		public static IActionParams_Union_1Union FromISetInteractionLockState(ISetInteractionLockStateT _isetinteractionlockstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetInteractionLockState,
				Value = _isetinteractionlockstate
			};
		}

		// Token: 0x0602A207 RID: 172551 RVA: 0x005CE949 File Offset: 0x005CCB49
		public ISetAudioStateT AsISetAudioState()
		{
			return this.As<ISetAudioStateT>();
		}

		// Token: 0x0602A208 RID: 172552 RVA: 0x005CE951 File Offset: 0x005CCB51
		public static IActionParams_Union_1Union FromISetAudioState(ISetAudioStateT _isetaudiostate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetAudioState,
				Value = _isetaudiostate
			};
		}

		// Token: 0x0602A209 RID: 172553 RVA: 0x005CE967 File Offset: 0x005CCB67
		public IPerformerAiSplineMoveT AsIPerformerAiSplineMove()
		{
			return this.As<IPerformerAiSplineMoveT>();
		}

		// Token: 0x0602A20A RID: 172554 RVA: 0x005CE96F File Offset: 0x005CCB6F
		public static IActionParams_Union_1Union FromIPerformerAiSplineMove(IPerformerAiSplineMoveT _iperformeraisplinemove)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformerAiSplineMove,
				Value = _iperformeraisplinemove
			};
		}

		// Token: 0x0602A20B RID: 172555 RVA: 0x005CE985 File Offset: 0x005CCB85
		public IPerformerAiMoveToT AsIPerformerAiMoveTo()
		{
			return this.As<IPerformerAiMoveToT>();
		}

		// Token: 0x0602A20C RID: 172556 RVA: 0x005CE98D File Offset: 0x005CCB8D
		public static IActionParams_Union_1Union FromIPerformerAiMoveTo(IPerformerAiMoveToT _iperformeraimoveto)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformerAiMoveTo,
				Value = _iperformeraimoveto
			};
		}

		// Token: 0x0602A20D RID: 172557 RVA: 0x005CE9A3 File Offset: 0x005CCBA3
		public IAddTrialFollowShooterT AsIAddTrialFollowShooter()
		{
			return this.As<IAddTrialFollowShooterT>();
		}

		// Token: 0x0602A20E RID: 172558 RVA: 0x005CE9AB File Offset: 0x005CCBAB
		public static IActionParams_Union_1Union FromIAddTrialFollowShooter(IAddTrialFollowShooterT _iaddtrialfollowshooter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IAddTrialFollowShooter,
				Value = _iaddtrialfollowshooter
			};
		}

		// Token: 0x0602A20F RID: 172559 RVA: 0x005CE9C1 File Offset: 0x005CCBC1
		public IRemoveTrialFollowShooterT AsIRemoveTrialFollowShooter()
		{
			return this.As<IRemoveTrialFollowShooterT>();
		}

		// Token: 0x0602A210 RID: 172560 RVA: 0x005CE9C9 File Offset: 0x005CCBC9
		public static IActionParams_Union_1Union FromIRemoveTrialFollowShooter(IRemoveTrialFollowShooterT _iremovetrialfollowshooter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemoveTrialFollowShooter,
				Value = _iremovetrialfollowshooter
			};
		}

		// Token: 0x0602A211 RID: 172561 RVA: 0x005CE9DF File Offset: 0x005CCBDF
		public IEnableFollowShooterAbilityT AsIEnableFollowShooterAbility()
		{
			return this.As<IEnableFollowShooterAbilityT>();
		}

		// Token: 0x0602A212 RID: 172562 RVA: 0x005CE9E7 File Offset: 0x005CCBE7
		public static IActionParams_Union_1Union FromIEnableFollowShooterAbility(IEnableFollowShooterAbilityT _ienablefollowshooterability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableFollowShooterAbility,
				Value = _ienablefollowshooterability
			};
		}

		// Token: 0x0602A213 RID: 172563 RVA: 0x005CE9FD File Offset: 0x005CCBFD
		public IClientFollowShooterLeisureInteractT AsIClientFollowShooterLeisureInteract()
		{
			return this.As<IClientFollowShooterLeisureInteractT>();
		}

		// Token: 0x0602A214 RID: 172564 RVA: 0x005CEA05 File Offset: 0x005CCC05
		public static IActionParams_Union_1Union FromIClientFollowShooterLeisureInteract(IClientFollowShooterLeisureInteractT _iclientfollowshooterleisureinteract)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientFollowShooterLeisureInteract,
				Value = _iclientfollowshooterleisureinteract
			};
		}

		// Token: 0x0602A215 RID: 172565 RVA: 0x005CEA1B File Offset: 0x005CCC1B
		public ICustomJsonT AsICustomJson()
		{
			return this.As<ICustomJsonT>();
		}

		// Token: 0x0602A216 RID: 172566 RVA: 0x005CEA23 File Offset: 0x005CCC23
		public static IActionParams_Union_1Union FromICustomJson(ICustomJsonT _icustomjson)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICustomJson,
				Value = _icustomjson
			};
		}

		// Token: 0x0602A217 RID: 172567 RVA: 0x005CEA39 File Offset: 0x005CCC39
		public IExecResurrectionT AsIExecResurrection()
		{
			return this.As<IExecResurrectionT>();
		}

		// Token: 0x0602A218 RID: 172568 RVA: 0x005CEA41 File Offset: 0x005CCC41
		public static IActionParams_Union_1Union FromIExecResurrection(IExecResurrectionT _iexecresurrection)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecResurrection,
				Value = _iexecresurrection
			};
		}

		// Token: 0x0602A219 RID: 172569 RVA: 0x005CEA57 File Offset: 0x005CCC57
		public IOpenSystemBoardWithReturnT AsIOpenSystemBoardWithReturn()
		{
			return this.As<IOpenSystemBoardWithReturnT>();
		}

		// Token: 0x0602A21A RID: 172570 RVA: 0x005CEA5F File Offset: 0x005CCC5F
		public static IActionParams_Union_1Union FromIOpenSystemBoardWithReturn(IOpenSystemBoardWithReturnT _iopensystemboardwithreturn)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenSystemBoardWithReturn,
				Value = _iopensystemboardwithreturn
			};
		}

		// Token: 0x0602A21B RID: 172571 RVA: 0x005CEA75 File Offset: 0x005CCC75
		public IResumeSystemRewardPopupT AsIResumeSystemRewardPopup()
		{
			return this.As<IResumeSystemRewardPopupT>();
		}

		// Token: 0x0602A21C RID: 172572 RVA: 0x005CEA7D File Offset: 0x005CCC7D
		public static IActionParams_Union_1Union FromIResumeSystemRewardPopup(IResumeSystemRewardPopupT _iresumesystemrewardpopup)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResumeSystemRewardPopup,
				Value = _iresumesystemrewardpopup
			};
		}

		// Token: 0x0602A21D RID: 172573 RVA: 0x005CEA93 File Offset: 0x005CCC93
		public IExecRiskHarvestEffectT AsIExecRiskHarvestEffect()
		{
			return this.As<IExecRiskHarvestEffectT>();
		}

		// Token: 0x0602A21E RID: 172574 RVA: 0x005CEA9B File Offset: 0x005CCC9B
		public static IActionParams_Union_1Union FromIExecRiskHarvestEffect(IExecRiskHarvestEffectT _iexecriskharvesteffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecRiskHarvestEffect,
				Value = _iexecriskharvesteffect
			};
		}

		// Token: 0x0602A21F RID: 172575 RVA: 0x005CEAB1 File Offset: 0x005CCCB1
		public ISetTeleControlT AsISetTeleControl()
		{
			return this.As<ISetTeleControlT>();
		}

		// Token: 0x0602A220 RID: 172576 RVA: 0x005CEAB9 File Offset: 0x005CCCB9
		public static IActionParams_Union_1Union FromISetTeleControl(ISetTeleControlT _isettelecontrol)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetTeleControl,
				Value = _isettelecontrol
			};
		}

		// Token: 0x0602A221 RID: 172577 RVA: 0x005CEACF File Offset: 0x005CCCCF
		public IMowingTowerGotoNextFloorT AsIMowingTowerGotoNextFloor()
		{
			return this.As<IMowingTowerGotoNextFloorT>();
		}

		// Token: 0x0602A222 RID: 172578 RVA: 0x005CEAD7 File Offset: 0x005CCCD7
		public static IActionParams_Union_1Union FromIMowingTowerGotoNextFloor(IMowingTowerGotoNextFloorT _imowingtowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMowingTowerGotoNextFloor,
				Value = _imowingtowergotonextfloor
			};
		}

		// Token: 0x0602A223 RID: 172579 RVA: 0x005CEAED File Offset: 0x005CCCED
		public ISlashAndTowerGotoNextFloorT AsISlashAndTowerGotoNextFloor()
		{
			return this.As<ISlashAndTowerGotoNextFloorT>();
		}

		// Token: 0x0602A224 RID: 172580 RVA: 0x005CEAF5 File Offset: 0x005CCCF5
		public static IActionParams_Union_1Union FromISlashAndTowerGotoNextFloor(ISlashAndTowerGotoNextFloorT _islashandtowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlashAndTowerGotoNextFloor,
				Value = _islashandtowergotonextfloor
			};
		}

		// Token: 0x0602A225 RID: 172581 RVA: 0x005CEB0B File Offset: 0x005CCD0B
		public IRoleTowerGotoNextFloorT AsIRoleTowerGotoNextFloor()
		{
			return this.As<IRoleTowerGotoNextFloorT>();
		}

		// Token: 0x0602A226 RID: 172582 RVA: 0x005CEB13 File Offset: 0x005CCD13
		public static IActionParams_Union_1Union FromIRoleTowerGotoNextFloor(IRoleTowerGotoNextFloorT _iroletowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoleTowerGotoNextFloor,
				Value = _iroletowergotonextfloor
			};
		}

		// Token: 0x0602A227 RID: 172583 RVA: 0x005CEB29 File Offset: 0x005CCD29
		public IVehicleEnterT AsIVehicleEnter()
		{
			return this.As<IVehicleEnterT>();
		}

		// Token: 0x0602A228 RID: 172584 RVA: 0x005CEB31 File Offset: 0x005CCD31
		public static IActionParams_Union_1Union FromIVehicleEnter(IVehicleEnterT _ivehicleenter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleEnter,
				Value = _ivehicleenter
			};
		}

		// Token: 0x0602A229 RID: 172585 RVA: 0x005CEB47 File Offset: 0x005CCD47
		public IEnterNpcVehicleT AsIEnterNpcVehicle()
		{
			return this.As<IEnterNpcVehicleT>();
		}

		// Token: 0x0602A22A RID: 172586 RVA: 0x005CEB4F File Offset: 0x005CCD4F
		public static IActionParams_Union_1Union FromIEnterNpcVehicle(IEnterNpcVehicleT _ienternpcvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterNpcVehicle,
				Value = _ienternpcvehicle
			};
		}

		// Token: 0x0602A22B RID: 172587 RVA: 0x005CEB65 File Offset: 0x005CCD65
		public IVehicleExitPlayerT AsIVehicleExitPlayer()
		{
			return this.As<IVehicleExitPlayerT>();
		}

		// Token: 0x0602A22C RID: 172588 RVA: 0x005CEB6D File Offset: 0x005CCD6D
		public static IActionParams_Union_1Union FromIVehicleExitPlayer(IVehicleExitPlayerT _ivehicleexitplayer)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleExitPlayer,
				Value = _ivehicleexitplayer
			};
		}

		// Token: 0x0602A22D RID: 172589 RVA: 0x005CEB83 File Offset: 0x005CCD83
		public IVehicleExitNpcT AsIVehicleExitNpc()
		{
			return this.As<IVehicleExitNpcT>();
		}

		// Token: 0x0602A22E RID: 172590 RVA: 0x005CEB8B File Offset: 0x005CCD8B
		public static IActionParams_Union_1Union FromIVehicleExitNpc(IVehicleExitNpcT _ivehicleexitnpc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleExitNpc,
				Value = _ivehicleexitnpc
			};
		}

		// Token: 0x0602A22F RID: 172591 RVA: 0x005CEBA1 File Offset: 0x005CCDA1
		public ITeleportVehicleT AsITeleportVehicle()
		{
			return this.As<ITeleportVehicleT>();
		}

		// Token: 0x0602A230 RID: 172592 RVA: 0x005CEBA9 File Offset: 0x005CCDA9
		public static IActionParams_Union_1Union FromITeleportVehicle(ITeleportVehicleT _iteleportvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportVehicle,
				Value = _iteleportvehicle
			};
		}

		// Token: 0x0602A231 RID: 172593 RVA: 0x005CEBBF File Offset: 0x005CCDBF
		public IClientTeleportVehicleT AsIClientTeleportVehicle()
		{
			return this.As<IClientTeleportVehicleT>();
		}

		// Token: 0x0602A232 RID: 172594 RVA: 0x005CEBC7 File Offset: 0x005CCDC7
		public static IActionParams_Union_1Union FromIClientTeleportVehicle(IClientTeleportVehicleT _iclientteleportvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientTeleportVehicle,
				Value = _iclientteleportvehicle
			};
		}

		// Token: 0x0602A233 RID: 172595 RVA: 0x005CEBDD File Offset: 0x005CCDDD
		public IVehiclePlayPassengerVoiceT AsIVehiclePlayPassengerVoice()
		{
			return this.As<IVehiclePlayPassengerVoiceT>();
		}

		// Token: 0x0602A234 RID: 172596 RVA: 0x005CEBE5 File Offset: 0x005CCDE5
		public static IActionParams_Union_1Union FromIVehiclePlayPassengerVoice(IVehiclePlayPassengerVoiceT _ivehicleplaypassengervoice)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehiclePlayPassengerVoice,
				Value = _ivehicleplaypassengervoice
			};
		}

		// Token: 0x0602A235 RID: 172597 RVA: 0x005CEBFB File Offset: 0x005CCDFB
		public IVehicleWaterfallClimbingT AsIVehicleWaterfallClimbing()
		{
			return this.As<IVehicleWaterfallClimbingT>();
		}

		// Token: 0x0602A236 RID: 172598 RVA: 0x005CEC03 File Offset: 0x005CCE03
		public static IActionParams_Union_1Union FromIVehicleWaterfallClimbing(IVehicleWaterfallClimbingT _ivehiclewaterfallclimbing)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleWaterfallClimbing,
				Value = _ivehiclewaterfallclimbing
			};
		}

		// Token: 0x0602A237 RID: 172599 RVA: 0x005CEC19 File Offset: 0x005CCE19
		public ITeleportToAndEnterVehicleT AsITeleportToAndEnterVehicle()
		{
			return this.As<ITeleportToAndEnterVehicleT>();
		}

		// Token: 0x0602A238 RID: 172600 RVA: 0x005CEC21 File Offset: 0x005CCE21
		public static IActionParams_Union_1Union FromITeleportToAndEnterVehicle(ITeleportToAndEnterVehicleT _iteleporttoandentervehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportToAndEnterVehicle,
				Value = _iteleporttoandentervehicle
			};
		}

		// Token: 0x0602A239 RID: 172601 RVA: 0x005CEC37 File Offset: 0x005CCE37
		public IVehicleMoveWithPathLineT AsIVehicleMoveWithPathLine()
		{
			return this.As<IVehicleMoveWithPathLineT>();
		}

		// Token: 0x0602A23A RID: 172602 RVA: 0x005CEC3F File Offset: 0x005CCE3F
		public static IActionParams_Union_1Union FromIVehicleMoveWithPathLine(IVehicleMoveWithPathLineT _ivehiclemovewithpathline)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleMoveWithPathLine,
				Value = _ivehiclemovewithpathline
			};
		}

		// Token: 0x0602A23B RID: 172603 RVA: 0x005CEC55 File Offset: 0x005CCE55
		public IVehicleSprintT AsIVehicleSprint()
		{
			return this.As<IVehicleSprintT>();
		}

		// Token: 0x0602A23C RID: 172604 RVA: 0x005CEC5D File Offset: 0x005CCE5D
		public static IActionParams_Union_1Union FromIVehicleSprint(IVehicleSprintT _ivehiclesprint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleSprint,
				Value = _ivehiclesprint
			};
		}

		// Token: 0x0602A23D RID: 172605 RVA: 0x005CEC73 File Offset: 0x005CCE73
		public IOpenQteActionT AsIOpenQteAction()
		{
			return this.As<IOpenQteActionT>();
		}

		// Token: 0x0602A23E RID: 172606 RVA: 0x005CEC7B File Offset: 0x005CCE7B
		public static IActionParams_Union_1Union FromIOpenQteAction(IOpenQteActionT _iopenqteaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenQteAction,
				Value = _iopenqteaction
			};
		}

		// Token: 0x0602A23F RID: 172607 RVA: 0x005CEC91 File Offset: 0x005CCE91
		public IPlayerInputT AsIPlayerInput()
		{
			return this.As<IPlayerInputT>();
		}

		// Token: 0x0602A240 RID: 172608 RVA: 0x005CEC99 File Offset: 0x005CCE99
		public static IActionParams_Union_1Union FromIPlayerInput(IPlayerInputT _iplayerinput)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayerInput,
				Value = _iplayerinput
			};
		}

		// Token: 0x0602A241 RID: 172609 RVA: 0x005CECAF File Offset: 0x005CCEAF
		public IPreloadActionT AsIPreloadAction()
		{
			return this.As<IPreloadActionT>();
		}

		// Token: 0x0602A242 RID: 172610 RVA: 0x005CECB7 File Offset: 0x005CCEB7
		public static IActionParams_Union_1Union FromIPreloadAction(IPreloadActionT _ipreloadaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPreloadAction,
				Value = _ipreloadaction
			};
		}

		// Token: 0x0602A243 RID: 172611 RVA: 0x005CECCD File Offset: 0x005CCECD
		public IRemovePreloadResourceActionT AsIRemovePreloadResourceAction()
		{
			return this.As<IRemovePreloadResourceActionT>();
		}

		// Token: 0x0602A244 RID: 172612 RVA: 0x005CECD5 File Offset: 0x005CCED5
		public static IActionParams_Union_1Union FromIRemovePreloadResourceAction(IRemovePreloadResourceActionT _iremovepreloadresourceaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemovePreloadResourceAction,
				Value = _iremovepreloadresourceaction
			};
		}

		// Token: 0x0602A245 RID: 172613 RVA: 0x005CECEB File Offset: 0x005CCEEB
		public IExecAlertSystemActionT AsIExecAlertSystemAction()
		{
			return this.As<IExecAlertSystemActionT>();
		}

		// Token: 0x0602A246 RID: 172614 RVA: 0x005CECF3 File Offset: 0x005CCEF3
		public static IActionParams_Union_1Union FromIExecAlertSystemAction(IExecAlertSystemActionT _iexecalertsystemaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecAlertSystemAction,
				Value = _iexecalertsystemaction
			};
		}

		// Token: 0x0602A247 RID: 172615 RVA: 0x005CED09 File Offset: 0x005CCF09
		public ISetSpineAnimationT AsISetSpineAnimation()
		{
			return this.As<ISetSpineAnimationT>();
		}

		// Token: 0x0602A248 RID: 172616 RVA: 0x005CED11 File Offset: 0x005CCF11
		public static IActionParams_Union_1Union FromISetSpineAnimation(ISetSpineAnimationT _isetspineanimation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSpineAnimation,
				Value = _isetspineanimation
			};
		}

		// Token: 0x0602A249 RID: 172617 RVA: 0x005CED27 File Offset: 0x005CCF27
		public IChangeEntityCampT AsIChangeEntityCamp()
		{
			return this.As<IChangeEntityCampT>();
		}

		// Token: 0x0602A24A RID: 172618 RVA: 0x005CED2F File Offset: 0x005CCF2F
		public static IActionParams_Union_1Union FromIChangeEntityCamp(IChangeEntityCampT _ichangeentitycamp)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeEntityCamp,
				Value = _ichangeentitycamp
			};
		}

		// Token: 0x0602A24B RID: 172619 RVA: 0x005CED45 File Offset: 0x005CCF45
		public IRecordDungeonEventT AsIRecordDungeonEvent()
		{
			return this.As<IRecordDungeonEventT>();
		}

		// Token: 0x0602A24C RID: 172620 RVA: 0x005CED4D File Offset: 0x005CCF4D
		public static IActionParams_Union_1Union FromIRecordDungeonEvent(IRecordDungeonEventT _irecorddungeonevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRecordDungeonEvent,
				Value = _irecorddungeonevent
			};
		}

		// Token: 0x0602A24D RID: 172621 RVA: 0x005CED63 File Offset: 0x005CCF63
		public IDangoAbyssGotoNextFloorT AsIDangoAbyssGotoNextFloor()
		{
			return this.As<IDangoAbyssGotoNextFloorT>();
		}

		// Token: 0x0602A24E RID: 172622 RVA: 0x005CED6B File Offset: 0x005CCF6B
		public static IActionParams_Union_1Union FromIDangoAbyssGotoNextFloor(IDangoAbyssGotoNextFloorT _idangoabyssgotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssGotoNextFloor,
				Value = _idangoabyssgotonextfloor
			};
		}

		// Token: 0x0602A24F RID: 172623 RVA: 0x005CED81 File Offset: 0x005CCF81
		public IDangoAbyssCreateRewardTreasureBoxT AsIDangoAbyssCreateRewardTreasureBox()
		{
			return this.As<IDangoAbyssCreateRewardTreasureBoxT>();
		}

		// Token: 0x0602A250 RID: 172624 RVA: 0x005CED89 File Offset: 0x005CCF89
		public static IActionParams_Union_1Union FromIDangoAbyssCreateRewardTreasureBox(IDangoAbyssCreateRewardTreasureBoxT _idangoabysscreaterewardtreasurebox)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssCreateRewardTreasureBox,
				Value = _idangoabysscreaterewardtreasurebox
			};
		}

		// Token: 0x0602A251 RID: 172625 RVA: 0x005CED9F File Offset: 0x005CCF9F
		public IDangoAbyssActivatePortalT AsIDangoAbyssActivatePortal()
		{
			return this.As<IDangoAbyssActivatePortalT>();
		}

		// Token: 0x0602A252 RID: 172626 RVA: 0x005CEDA7 File Offset: 0x005CCFA7
		public static IActionParams_Union_1Union FromIDangoAbyssActivatePortal(IDangoAbyssActivatePortalT _idangoabyssactivateportal)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssActivatePortal,
				Value = _idangoabyssactivateportal
			};
		}

		// Token: 0x0602A253 RID: 172627 RVA: 0x005CEDBD File Offset: 0x005CCFBD
		public IDangoAbyssReceiveRewardT AsIDangoAbyssReceiveReward()
		{
			return this.As<IDangoAbyssReceiveRewardT>();
		}

		// Token: 0x0602A254 RID: 172628 RVA: 0x005CEDC5 File Offset: 0x005CCFC5
		public static IActionParams_Union_1Union FromIDangoAbyssReceiveReward(IDangoAbyssReceiveRewardT _idangoabyssreceivereward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssReceiveReward,
				Value = _idangoabyssreceivereward
			};
		}

		// Token: 0x0602A255 RID: 172629 RVA: 0x005CEDDB File Offset: 0x005CCFDB
		public IRoverRogueActivateT AsIRoverRogueActivate()
		{
			return this.As<IRoverRogueActivateT>();
		}

		// Token: 0x0602A256 RID: 172630 RVA: 0x005CEDE3 File Offset: 0x005CCFE3
		public static IActionParams_Union_1Union FromIRoverRogueActivate(IRoverRogueActivateT _iroverrogueactivate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueActivate,
				Value = _iroverrogueactivate
			};
		}

		// Token: 0x0602A257 RID: 172631 RVA: 0x005CEDF9 File Offset: 0x005CCFF9
		public IRoverRogueRoomFinishT AsIRoverRogueRoomFinish()
		{
			return this.As<IRoverRogueRoomFinishT>();
		}

		// Token: 0x0602A258 RID: 172632 RVA: 0x005CEE01 File Offset: 0x005CD001
		public static IActionParams_Union_1Union FromIRoverRogueRoomFinish(IRoverRogueRoomFinishT _iroverrogueroomfinish)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueRoomFinish,
				Value = _iroverrogueroomfinish
			};
		}

		// Token: 0x0602A259 RID: 172633 RVA: 0x005CEE17 File Offset: 0x005CD017
		public IRoverRogueCreateRoomRewardT AsIRoverRogueCreateRoomReward()
		{
			return this.As<IRoverRogueCreateRoomRewardT>();
		}

		// Token: 0x0602A25A RID: 172634 RVA: 0x005CEE1F File Offset: 0x005CD01F
		public static IActionParams_Union_1Union FromIRoverRogueCreateRoomReward(IRoverRogueCreateRoomRewardT _iroverroguecreateroomreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueCreateRoomReward,
				Value = _iroverroguecreateroomreward
			};
		}

		// Token: 0x0602A25B RID: 172635 RVA: 0x005CEE35 File Offset: 0x005CD035
		public IGuestOperateUiAnimationT AsIGuestOperateUiAnimation()
		{
			return this.As<IGuestOperateUiAnimationT>();
		}

		// Token: 0x0602A25C RID: 172636 RVA: 0x005CEE3D File Offset: 0x005CD03D
		public static IActionParams_Union_1Union FromIGuestOperateUiAnimation(IGuestOperateUiAnimationT _iguestoperateuianimation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGuestOperateUiAnimation,
				Value = _iguestoperateuianimation
			};
		}

		// Token: 0x0602A25D RID: 172637 RVA: 0x005CEE53 File Offset: 0x005CD053
		public ISlideRailStartT AsISlideRailStart()
		{
			return this.As<ISlideRailStartT>();
		}

		// Token: 0x0602A25E RID: 172638 RVA: 0x005CEE5B File Offset: 0x005CD05B
		public static IActionParams_Union_1Union FromISlideRailStart(ISlideRailStartT _isliderailstart)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlideRailStart,
				Value = _isliderailstart
			};
		}

		// Token: 0x0602A25F RID: 172639 RVA: 0x005CEE71 File Offset: 0x005CD071
		public ISlideRailEndT AsISlideRailEnd()
		{
			return this.As<ISlideRailEndT>();
		}

		// Token: 0x0602A260 RID: 172640 RVA: 0x005CEE79 File Offset: 0x005CD079
		public static IActionParams_Union_1Union FromISlideRailEnd(ISlideRailEndT _isliderailend)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlideRailEnd,
				Value = _isliderailend
			};
		}

		// Token: 0x0602A261 RID: 172641 RVA: 0x005CEE8F File Offset: 0x005CD08F
		public ISlidePerformStartT AsISlidePerformStart()
		{
			return this.As<ISlidePerformStartT>();
		}

		// Token: 0x0602A262 RID: 172642 RVA: 0x005CEE97 File Offset: 0x005CD097
		public static IActionParams_Union_1Union FromISlidePerformStart(ISlidePerformStartT _islideperformstart)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlidePerformStart,
				Value = _islideperformstart
			};
		}

		// Token: 0x0602A263 RID: 172643 RVA: 0x005CEEAD File Offset: 0x005CD0AD
		public IBvbSendSystemEventT AsIBvbSendSystemEvent()
		{
			return this.As<IBvbSendSystemEventT>();
		}

		// Token: 0x0602A264 RID: 172644 RVA: 0x005CEEB5 File Offset: 0x005CD0B5
		public static IActionParams_Union_1Union FromIBvbSendSystemEvent(IBvbSendSystemEventT _ibvbsendsystemevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSendSystemEvent,
				Value = _ibvbsendsystemevent
			};
		}

		// Token: 0x0602A265 RID: 172645 RVA: 0x005CEECB File Offset: 0x005CD0CB
		public IBvbSendAiEventT AsIBvbSendAiEvent()
		{
			return this.As<IBvbSendAiEventT>();
		}

		// Token: 0x0602A266 RID: 172646 RVA: 0x005CEED3 File Offset: 0x005CD0D3
		public static IActionParams_Union_1Union FromIBvbSendAiEvent(IBvbSendAiEventT _ibvbsendaievent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSendAiEvent,
				Value = _ibvbsendaievent
			};
		}

		// Token: 0x0602A267 RID: 172647 RVA: 0x005CEEE9 File Offset: 0x005CD0E9
		public IBvbPlayDialogT AsIBvbPlayDialog()
		{
			return this.As<IBvbPlayDialogT>();
		}

		// Token: 0x0602A268 RID: 172648 RVA: 0x005CEEF1 File Offset: 0x005CD0F1
		public static IActionParams_Union_1Union FromIBvbPlayDialog(IBvbPlayDialogT _ibvbplaydialog)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbPlayDialog,
				Value = _ibvbplaydialog
			};
		}

		// Token: 0x0602A269 RID: 172649 RVA: 0x005CEF07 File Offset: 0x005CD107
		public IBvbPlayerOperationConstraintT AsIBvbPlayerOperationConstraint()
		{
			return this.As<IBvbPlayerOperationConstraintT>();
		}

		// Token: 0x0602A26A RID: 172650 RVA: 0x005CEF0F File Offset: 0x005CD10F
		public static IActionParams_Union_1Union FromIBvbPlayerOperationConstraint(IBvbPlayerOperationConstraintT _ibvbplayeroperationconstraint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbPlayerOperationConstraint,
				Value = _ibvbplayeroperationconstraint
			};
		}

		// Token: 0x0602A26B RID: 172651 RVA: 0x005CEF25 File Offset: 0x005CD125
		public IBvbSkipChallengeT AsIBvbSkipChallenge()
		{
			return this.As<IBvbSkipChallengeT>();
		}

		// Token: 0x0602A26C RID: 172652 RVA: 0x005CEF2D File Offset: 0x005CD12D
		public static IActionParams_Union_1Union FromIBvbSkipChallenge(IBvbSkipChallengeT _ibvbskipchallenge)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSkipChallenge,
				Value = _ibvbskipchallenge
			};
		}

		// Token: 0x0602A26D RID: 172653 RVA: 0x005CEF43 File Offset: 0x005CD143
		public IActiveAntiGravitySafePointT AsIActiveAntiGravitySafePoint()
		{
			return this.As<IActiveAntiGravitySafePointT>();
		}

		// Token: 0x0602A26E RID: 172654 RVA: 0x005CEF4B File Offset: 0x005CD14B
		public static IActionParams_Union_1Union FromIActiveAntiGravitySafePoint(IActiveAntiGravitySafePointT _iactiveantigravitysafepoint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IActiveAntiGravitySafePoint,
				Value = _iactiveantigravitysafepoint
			};
		}

		// Token: 0x0602A26F RID: 172655 RVA: 0x005CEF61 File Offset: 0x005CD161
		public ISummonEntityT AsISummonEntity()
		{
			return this.As<ISummonEntityT>();
		}

		// Token: 0x0602A270 RID: 172656 RVA: 0x005CEF69 File Offset: 0x005CD169
		public static IActionParams_Union_1Union FromISummonEntity(ISummonEntityT _isummonentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISummonEntity,
				Value = _isummonentity
			};
		}

		// Token: 0x0602A271 RID: 172657 RVA: 0x005CEF7F File Offset: 0x005CD17F
		public IDestroySummonedEntitiesT AsIDestroySummonedEntities()
		{
			return this.As<IDestroySummonedEntitiesT>();
		}

		// Token: 0x0602A272 RID: 172658 RVA: 0x005CEF87 File Offset: 0x005CD187
		public static IActionParams_Union_1Union FromIDestroySummonedEntities(IDestroySummonedEntitiesT _idestroysummonedentities)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDestroySummonedEntities,
				Value = _idestroysummonedentities
			};
		}

		// Token: 0x0602A273 RID: 172659 RVA: 0x005CEF9D File Offset: 0x005CD19D
		public ISetupMoraleSystemT AsISetupMoraleSystem()
		{
			return this.As<ISetupMoraleSystemT>();
		}

		// Token: 0x0602A274 RID: 172660 RVA: 0x005CEFA5 File Offset: 0x005CD1A5
		public static IActionParams_Union_1Union FromISetupMoraleSystem(ISetupMoraleSystemT _isetupmoralesystem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetupMoraleSystem,
				Value = _isetupmoralesystem
			};
		}

		// Token: 0x0602A275 RID: 172661 RVA: 0x005CEFBB File Offset: 0x005CD1BB
		public IGiantToggleModelT AsIGiantToggleModel()
		{
			return this.As<IGiantToggleModelT>();
		}

		// Token: 0x0602A276 RID: 172662 RVA: 0x005CEFC3 File Offset: 0x005CD1C3
		public static IActionParams_Union_1Union FromIGiantToggleModel(IGiantToggleModelT _igianttogglemodel)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGiantToggleModel,
				Value = _igianttogglemodel
			};
		}

		// Token: 0x0602A277 RID: 172663 RVA: 0x005CEFD9 File Offset: 0x005CD1D9
		public IGiantTriggerResponseT AsIGiantTriggerResponse()
		{
			return this.As<IGiantTriggerResponseT>();
		}

		// Token: 0x0602A278 RID: 172664 RVA: 0x005CEFE1 File Offset: 0x005CD1E1
		public static IActionParams_Union_1Union FromIGiantTriggerResponse(IGiantTriggerResponseT _igianttriggerresponse)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGiantTriggerResponse,
				Value = _igianttriggerresponse
			};
		}

		// Token: 0x0602A279 RID: 172665 RVA: 0x005CEFF7 File Offset: 0x005CD1F7
		public IActivateGiantTotalProgressNodeT AsIActivateGiantTotalProgressNode()
		{
			return this.As<IActivateGiantTotalProgressNodeT>();
		}

		// Token: 0x0602A27A RID: 172666 RVA: 0x005CEFFF File Offset: 0x005CD1FF
		public static IActionParams_Union_1Union FromIActivateGiantTotalProgressNode(IActivateGiantTotalProgressNodeT _iactivategianttotalprogressnode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IActivateGiantTotalProgressNode,
				Value = _iactivategianttotalprogressnode
			};
		}

		// Token: 0x0602A27B RID: 172667 RVA: 0x005CF015 File Offset: 0x005CD215
		public IRunActorCustomEventT AsIRunActorCustomEvent()
		{
			return this.As<IRunActorCustomEventT>();
		}

		// Token: 0x0602A27C RID: 172668 RVA: 0x005CF01D File Offset: 0x005CD21D
		public static IActionParams_Union_1Union FromIRunActorCustomEvent(IRunActorCustomEventT _irunactorcustomevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRunActorCustomEvent,
				Value = _irunactorcustomevent
			};
		}

		// Token: 0x0602A27D RID: 172669 RVA: 0x005CF033 File Offset: 0x005CD233
		public ITriggerSpecificScanEffectT AsITriggerSpecificScanEffect()
		{
			return this.As<ITriggerSpecificScanEffectT>();
		}

		// Token: 0x0602A27E RID: 172670 RVA: 0x005CF03B File Offset: 0x005CD23B
		public static IActionParams_Union_1Union FromITriggerSpecificScanEffect(ITriggerSpecificScanEffectT _itriggerspecificscaneffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerSpecificScanEffect,
				Value = _itriggerspecificscaneffect
			};
		}

		// Token: 0x0602A27F RID: 172671 RVA: 0x005CF051 File Offset: 0x005CD251
		public ISendClientEventT AsISendClientEvent()
		{
			return this.As<ISendClientEventT>();
		}

		// Token: 0x0602A280 RID: 172672 RVA: 0x005CF059 File Offset: 0x005CD259
		public static IActionParams_Union_1Union FromISendClientEvent(ISendClientEventT _isendclientevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISendClientEvent,
				Value = _isendclientevent
			};
		}

		// Token: 0x0602A281 RID: 172673 RVA: 0x005CF06F File Offset: 0x005CD26F
		public IScanEnrichmentAreaT AsIScanEnrichmentArea()
		{
			return this.As<IScanEnrichmentAreaT>();
		}

		// Token: 0x0602A282 RID: 172674 RVA: 0x005CF077 File Offset: 0x005CD277
		public static IActionParams_Union_1Union FromIScanEnrichmentArea(IScanEnrichmentAreaT _iscanenrichmentarea)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IScanEnrichmentArea,
				Value = _iscanenrichmentarea
			};
		}

		// Token: 0x0602A283 RID: 172675 RVA: 0x005CF08D File Offset: 0x005CD28D
		public IRequestSystemFunctionT AsIRequestSystemFunction()
		{
			return this.As<IRequestSystemFunctionT>();
		}

		// Token: 0x0602A284 RID: 172676 RVA: 0x005CF095 File Offset: 0x005CD295
		public static IActionParams_Union_1Union FromIRequestSystemFunction(IRequestSystemFunctionT _irequestsystemfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRequestSystemFunction,
				Value = _irequestsystemfunction
			};
		}

		// Token: 0x0602A285 RID: 172677 RVA: 0x005CF0AB File Offset: 0x005CD2AB
		public IReignsSetPropertyVisibleT AsIReignsSetPropertyVisible()
		{
			return this.As<IReignsSetPropertyVisibleT>();
		}

		// Token: 0x0602A286 RID: 172678 RVA: 0x005CF0B3 File Offset: 0x005CD2B3
		public static IActionParams_Union_1Union FromIReignsSetPropertyVisible(IReignsSetPropertyVisibleT _ireignssetpropertyvisible)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsSetPropertyVisible,
				Value = _ireignssetpropertyvisible
			};
		}

		// Token: 0x0602A287 RID: 172679 RVA: 0x005CF0C9 File Offset: 0x005CD2C9
		public IReignsChangeBackgroundT AsIReignsChangeBackground()
		{
			return this.As<IReignsChangeBackgroundT>();
		}

		// Token: 0x0602A288 RID: 172680 RVA: 0x005CF0D1 File Offset: 0x005CD2D1
		public static IActionParams_Union_1Union FromIReignsChangeBackground(IReignsChangeBackgroundT _ireignschangebackground)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsChangeBackground,
				Value = _ireignschangebackground
			};
		}

		// Token: 0x0602A289 RID: 172681 RVA: 0x005CF0E7 File Offset: 0x005CD2E7
		public IReignsSetUiEffectT AsIReignsSetUiEffect()
		{
			return this.As<IReignsSetUiEffectT>();
		}

		// Token: 0x0602A28A RID: 172682 RVA: 0x005CF0EF File Offset: 0x005CD2EF
		public static IActionParams_Union_1Union FromIReignsSetUiEffect(IReignsSetUiEffectT _ireignssetuieffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsSetUiEffect,
				Value = _ireignssetuieffect
			};
		}

		// Token: 0x0602A28B RID: 172683 RVA: 0x005CF105 File Offset: 0x005CD305
		public IReignsChangePlayerNameT AsIReignsChangePlayerName()
		{
			return this.As<IReignsChangePlayerNameT>();
		}

		// Token: 0x0602A28C RID: 172684 RVA: 0x005CF10D File Offset: 0x005CD30D
		public static IActionParams_Union_1Union FromIReignsChangePlayerName(IReignsChangePlayerNameT _ireignschangeplayername)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsChangePlayerName,
				Value = _ireignschangeplayername
			};
		}

		// Token: 0x0602A28D RID: 172685 RVA: 0x005CF123 File Offset: 0x005CD323
		public IReignsCallCardT AsIReignsCallCard()
		{
			return this.As<IReignsCallCardT>();
		}

		// Token: 0x0602A28E RID: 172686 RVA: 0x005CF12B File Offset: 0x005CD32B
		public static IActionParams_Union_1Union FromIReignsCallCard(IReignsCallCardT _ireignscallcard)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsCallCard,
				Value = _ireignscallcard
			};
		}

		// Token: 0x0602A28F RID: 172687 RVA: 0x005CF141 File Offset: 0x005CD341
		public IReignsTriggerGuideT AsIReignsTriggerGuide()
		{
			return this.As<IReignsTriggerGuideT>();
		}

		// Token: 0x0602A290 RID: 172688 RVA: 0x005CF149 File Offset: 0x005CD349
		public static IActionParams_Union_1Union FromIReignsTriggerGuide(IReignsTriggerGuideT _ireignstriggerguide)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsTriggerGuide,
				Value = _ireignstriggerguide
			};
		}

		// Token: 0x0602A291 RID: 172689 RVA: 0x005CF15F File Offset: 0x005CD35F
		public IReignsAddBuffT AsIReignsAddBuff()
		{
			return this.As<IReignsAddBuffT>();
		}

		// Token: 0x0602A292 RID: 172690 RVA: 0x005CF167 File Offset: 0x005CD367
		public static IActionParams_Union_1Union FromIReignsAddBuff(IReignsAddBuffT _ireignsaddbuff)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsAddBuff,
				Value = _ireignsaddbuff
			};
		}

		// Token: 0x0602A293 RID: 172691 RVA: 0x005CF17D File Offset: 0x005CD37D
		public IReignsCheckSettleT AsIReignsCheckSettle()
		{
			return this.As<IReignsCheckSettleT>();
		}

		// Token: 0x0602A294 RID: 172692 RVA: 0x005CF185 File Offset: 0x005CD385
		public static IActionParams_Union_1Union FromIReignsCheckSettle(IReignsCheckSettleT _ireignschecksettle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsCheckSettle,
				Value = _ireignschecksettle
			};
		}

		// Token: 0x0602A295 RID: 172693 RVA: 0x005CF19B File Offset: 0x005CD39B
		public ISetNpcGroupPerformT AsISetNpcGroupPerform()
		{
			return this.As<ISetNpcGroupPerformT>();
		}

		// Token: 0x0602A296 RID: 172694 RVA: 0x005CF1A3 File Offset: 0x005CD3A3
		public static IActionParams_Union_1Union FromISetNpcGroupPerform(ISetNpcGroupPerformT _isetnpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetNpcGroupPerform,
				Value = _isetnpcgroupperform
			};
		}

		// Token: 0x0602A297 RID: 172695 RVA: 0x005CF1B9 File Offset: 0x005CD3B9
		public IRemoveNpcGroupPerformT AsIRemoveNpcGroupPerform()
		{
			return this.As<IRemoveNpcGroupPerformT>();
		}

		// Token: 0x0602A298 RID: 172696 RVA: 0x005CF1C1 File Offset: 0x005CD3C1
		public static IActionParams_Union_1Union FromIRemoveNpcGroupPerform(IRemoveNpcGroupPerformT _iremovenpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemoveNpcGroupPerform,
				Value = _iremovenpcgroupperform
			};
		}

		// Token: 0x0602A299 RID: 172697 RVA: 0x005CF1DA File Offset: 0x005CD3DA
		public IEnableEntityLookAtT AsIEnableEntityLookAt()
		{
			return this.As<IEnableEntityLookAtT>();
		}

		// Token: 0x0602A29A RID: 172698 RVA: 0x005CF1E2 File Offset: 0x005CD3E2
		public static IActionParams_Union_1Union FromIEnableEntityLookAt(IEnableEntityLookAtT _ienableentitylookat)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableEntityLookAt,
				Value = _ienableentitylookat
			};
		}

		// Token: 0x0602A29B RID: 172699 RVA: 0x005CF1FB File Offset: 0x005CD3FB
		public IDisableEntityLookAtT AsIDisableEntityLookAt()
		{
			return this.As<IDisableEntityLookAtT>();
		}

		// Token: 0x0602A29C RID: 172700 RVA: 0x005CF203 File Offset: 0x005CD403
		public static IActionParams_Union_1Union FromIDisableEntityLookAt(IDisableEntityLookAtT _idisableentitylookat)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableEntityLookAt,
				Value = _idisableentitylookat
			};
		}

		// Token: 0x0602A29D RID: 172701 RVA: 0x005CF21C File Offset: 0x005CD41C
		public IOverrideAiBehaviorTreeT AsIOverrideAiBehaviorTree()
		{
			return this.As<IOverrideAiBehaviorTreeT>();
		}

		// Token: 0x0602A29E RID: 172702 RVA: 0x005CF224 File Offset: 0x005CD424
		public static IActionParams_Union_1Union FromIOverrideAiBehaviorTree(IOverrideAiBehaviorTreeT _ioverrideaibehaviortree)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOverrideAiBehaviorTree,
				Value = _ioverrideaibehaviortree
			};
		}

		// Token: 0x0602A29F RID: 172703 RVA: 0x005CF23D File Offset: 0x005CD43D
		public IRestoreAiBehaviorTreeT AsIRestoreAiBehaviorTree()
		{
			return this.As<IRestoreAiBehaviorTreeT>();
		}

		// Token: 0x0602A2A0 RID: 172704 RVA: 0x005CF245 File Offset: 0x005CD445
		public static IActionParams_Union_1Union FromIRestoreAiBehaviorTree(IRestoreAiBehaviorTreeT _irestoreaibehaviortree)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRestoreAiBehaviorTree,
				Value = _irestoreaibehaviortree
			};
		}

		// Token: 0x0602A2A1 RID: 172705 RVA: 0x005CF25E File Offset: 0x005CD45E
		public IFlowDefineNpcGroupPerformT AsIFlowDefineNpcGroupPerform()
		{
			return this.As<IFlowDefineNpcGroupPerformT>();
		}

		// Token: 0x0602A2A2 RID: 172706 RVA: 0x005CF266 File Offset: 0x005CD466
		public static IActionParams_Union_1Union FromIFlowDefineNpcGroupPerform(IFlowDefineNpcGroupPerformT _iflowdefinenpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IFlowDefineNpcGroupPerform,
				Value = _iflowdefinenpcgroupperform
			};
		}

		// Token: 0x0602A2A3 RID: 172707 RVA: 0x005CF27F File Offset: 0x005CD47F
		public ISeqEventAddTagToSelfT AsISeqEventAddTagToSelf()
		{
			return this.As<ISeqEventAddTagToSelfT>();
		}

		// Token: 0x0602A2A4 RID: 172708 RVA: 0x005CF287 File Offset: 0x005CD487
		public static IActionParams_Union_1Union FromISeqEventAddTagToSelf(ISeqEventAddTagToSelfT _iseqeventaddtagtoself)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeqEventAddTagToSelf,
				Value = _iseqeventaddtagtoself
			};
		}

		// Token: 0x0602A2A5 RID: 172709 RVA: 0x005CF2A0 File Offset: 0x005CD4A0
		public ISeqEventFireBulletT AsISeqEventFireBullet()
		{
			return this.As<ISeqEventFireBulletT>();
		}

		// Token: 0x0602A2A6 RID: 172710 RVA: 0x005CF2A8 File Offset: 0x005CD4A8
		public static IActionParams_Union_1Union FromISeqEventFireBullet(ISeqEventFireBulletT _iseqeventfirebullet)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeqEventFireBullet,
				Value = _iseqeventfirebullet
			};
		}

		// Token: 0x0602A2A7 RID: 172711 RVA: 0x005CF2C1 File Offset: 0x005CD4C1
		public ITrapDefenseChangeMiniMapT AsITrapDefenseChangeMiniMap()
		{
			return this.As<ITrapDefenseChangeMiniMapT>();
		}

		// Token: 0x0602A2A8 RID: 172712 RVA: 0x005CF2C9 File Offset: 0x005CD4C9
		public static IActionParams_Union_1Union FromITrapDefenseChangeMiniMap(ITrapDefenseChangeMiniMapT _itrapdefensechangeminimap)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITrapDefenseChangeMiniMap,
				Value = _itrapdefensechangeminimap
			};
		}

		// Token: 0x0602A2A9 RID: 172713 RVA: 0x005CF2E2 File Offset: 0x005CD4E2
		public ITrapDefensePlayerOperationConstraintT AsITrapDefensePlayerOperationConstraint()
		{
			return this.As<ITrapDefensePlayerOperationConstraintT>();
		}

		// Token: 0x0602A2AA RID: 172714 RVA: 0x005CF2EA File Offset: 0x005CD4EA
		public static IActionParams_Union_1Union FromITrapDefensePlayerOperationConstraint(ITrapDefensePlayerOperationConstraintT _itrapdefenseplayeroperationconstraint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITrapDefensePlayerOperationConstraint,
				Value = _itrapdefenseplayeroperationconstraint
			};
		}

		// Token: 0x0602A2AB RID: 172715 RVA: 0x005CF303 File Offset: 0x005CD503
		public IHonamiStoryInteractPickUpT AsIHonamiStoryInteractPickUp()
		{
			return this.As<IHonamiStoryInteractPickUpT>();
		}

		// Token: 0x0602A2AC RID: 172716 RVA: 0x005CF30B File Offset: 0x005CD50B
		public static IActionParams_Union_1Union FromIHonamiStoryInteractPickUp(IHonamiStoryInteractPickUpT _ihonamistoryinteractpickup)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryInteractPickUp,
				Value = _ihonamistoryinteractpickup
			};
		}

		// Token: 0x0602A2AD RID: 172717 RVA: 0x005CF324 File Offset: 0x005CD524
		public IHonamiStoryReceiveCorruptedChestRewardT AsIHonamiStoryReceiveCorruptedChestReward()
		{
			return this.As<IHonamiStoryReceiveCorruptedChestRewardT>();
		}

		// Token: 0x0602A2AE RID: 172718 RVA: 0x005CF32C File Offset: 0x005CD52C
		public static IActionParams_Union_1Union FromIHonamiStoryReceiveCorruptedChestReward(IHonamiStoryReceiveCorruptedChestRewardT _ihonamistoryreceivecorruptedchestreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryReceiveCorruptedChestReward,
				Value = _ihonamistoryreceivecorruptedchestreward
			};
		}

		// Token: 0x0602A2AF RID: 172719 RVA: 0x005CF345 File Offset: 0x005CD545
		public IHonamiStoryActivateSafeEvacuationT AsIHonamiStoryActivateSafeEvacuation()
		{
			return this.As<IHonamiStoryActivateSafeEvacuationT>();
		}

		// Token: 0x0602A2B0 RID: 172720 RVA: 0x005CF34D File Offset: 0x005CD54D
		public static IActionParams_Union_1Union FromIHonamiStoryActivateSafeEvacuation(IHonamiStoryActivateSafeEvacuationT _ihonamistoryactivatesafeevacuation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryActivateSafeEvacuation,
				Value = _ihonamistoryactivatesafeevacuation
			};
		}

		// Token: 0x0602A2B1 RID: 172721 RVA: 0x005CF366 File Offset: 0x005CD566
		public IHonamiStorySetFormationT AsIHonamiStorySetFormation()
		{
			return this.As<IHonamiStorySetFormationT>();
		}

		// Token: 0x0602A2B2 RID: 172722 RVA: 0x005CF36E File Offset: 0x005CD56E
		public static IActionParams_Union_1Union FromIHonamiStorySetFormation(IHonamiStorySetFormationT _ihonamistorysetformation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStorySetFormation,
				Value = _ihonamistorysetformation
			};
		}

		// Token: 0x0602A2B3 RID: 172723 RVA: 0x005CF387 File Offset: 0x005CD587
		public IHonamiStoryGetItemT AsIHonamiStoryGetItem()
		{
			return this.As<IHonamiStoryGetItemT>();
		}

		// Token: 0x0602A2B4 RID: 172724 RVA: 0x005CF38F File Offset: 0x005CD58F
		public static IActionParams_Union_1Union FromIHonamiStoryGetItem(IHonamiStoryGetItemT _ihonamistorygetitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryGetItem,
				Value = _ihonamistorygetitem
			};
		}

		// Token: 0x0602A2B5 RID: 172725 RVA: 0x005CF3A8 File Offset: 0x005CD5A8
		public IInfrActivityUpgradeInfrastructureT AsIInfrActivityUpgradeInfrastructure()
		{
			return this.As<IInfrActivityUpgradeInfrastructureT>();
		}

		// Token: 0x0602A2B6 RID: 172726 RVA: 0x005CF3B0 File Offset: 0x005CD5B0
		public static IActionParams_Union_1Union FromIInfrActivityUpgradeInfrastructure(IInfrActivityUpgradeInfrastructureT _iinfractivityupgradeinfrastructure)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IInfrActivityUpgradeInfrastructure,
				Value = _iinfractivityupgradeinfrastructure
			};
		}

		// Token: 0x0602A2B7 RID: 172727 RVA: 0x005CF3C9 File Offset: 0x005CD5C9
		public IPlayWalkingOverlayMontageT AsIPlayWalkingOverlayMontage()
		{
			return this.As<IPlayWalkingOverlayMontageT>();
		}

		// Token: 0x0602A2B8 RID: 172728 RVA: 0x005CF3D1 File Offset: 0x005CD5D1
		public static IActionParams_Union_1Union FromIPlayWalkingOverlayMontage(IPlayWalkingOverlayMontageT _iplaywalkingoverlaymontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayWalkingOverlayMontage,
				Value = _iplaywalkingoverlaymontage
			};
		}

		// Token: 0x0602A2B9 RID: 172729 RVA: 0x005CF3EA File Offset: 0x005CD5EA
		public IEnableKey4FuncT AsIEnableKey4Func()
		{
			return this.As<IEnableKey4FuncT>();
		}

		// Token: 0x0602A2BA RID: 172730 RVA: 0x005CF3F2 File Offset: 0x005CD5F2
		public static IActionParams_Union_1Union FromIEnableKey4Func(IEnableKey4FuncT _ienablekey4func)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableKey4Func,
				Value = _ienablekey4func
			};
		}

		// Token: 0x0602A2BB RID: 172731 RVA: 0x005CF40B File Offset: 0x005CD60B
		public IChangeNpcAbpStateT AsIChangeNpcAbpState()
		{
			return this.As<IChangeNpcAbpStateT>();
		}

		// Token: 0x0602A2BC RID: 172732 RVA: 0x005CF413 File Offset: 0x005CD613
		public static IActionParams_Union_1Union FromIChangeNpcAbpState(IChangeNpcAbpStateT _ichangenpcabpstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeNpcAbpState,
				Value = _ichangenpcabpstate
			};
		}

		// Token: 0x0602A2BD RID: 172733 RVA: 0x005CF42C File Offset: 0x005CD62C
		public IOverrideAbpAnimSchemeT AsIOverrideAbpAnimScheme()
		{
			return this.As<IOverrideAbpAnimSchemeT>();
		}

		// Token: 0x0602A2BE RID: 172734 RVA: 0x005CF434 File Offset: 0x005CD634
		public static IActionParams_Union_1Union FromIOverrideAbpAnimScheme(IOverrideAbpAnimSchemeT _ioverrideabpanimscheme)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOverrideAbpAnimScheme,
				Value = _ioverrideabpanimscheme
			};
		}

		// Token: 0x0602A2BF RID: 172735 RVA: 0x005CF44D File Offset: 0x005CD64D
		public ICloseWalkingOverlayMontageT AsICloseWalkingOverlayMontage()
		{
			return this.As<ICloseWalkingOverlayMontageT>();
		}

		// Token: 0x0602A2C0 RID: 172736 RVA: 0x005CF455 File Offset: 0x005CD655
		public static IActionParams_Union_1Union FromICloseWalkingOverlayMontage(ICloseWalkingOverlayMontageT _iclosewalkingoverlaymontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICloseWalkingOverlayMontage,
				Value = _iclosewalkingoverlaymontage
			};
		}

		// Token: 0x0602A2C1 RID: 172737 RVA: 0x005CF46E File Offset: 0x005CD66E
		public ISetMotorSpeedT AsISetMotorSpeed()
		{
			return this.As<ISetMotorSpeedT>();
		}

		// Token: 0x0602A2C2 RID: 172738 RVA: 0x005CF476 File Offset: 0x005CD676
		public static IActionParams_Union_1Union FromISetMotorSpeed(ISetMotorSpeedT _isetmotorspeed)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetMotorSpeed,
				Value = _isetmotorspeed
			};
		}

		// Token: 0x0602A2C3 RID: 172739 RVA: 0x005CF48F File Offset: 0x005CD68F
		public IVehicleSetSpeedImmediatelyT AsIVehicleSetSpeedImmediately()
		{
			return this.As<IVehicleSetSpeedImmediatelyT>();
		}

		// Token: 0x0602A2C4 RID: 172740 RVA: 0x005CF497 File Offset: 0x005CD697
		public static IActionParams_Union_1Union FromIVehicleSetSpeedImmediately(IVehicleSetSpeedImmediatelyT _ivehiclesetspeedimmediately)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleSetSpeedImmediately,
				Value = _ivehiclesetspeedimmediately
			};
		}

		// Token: 0x0602A2C5 RID: 172741 RVA: 0x005CF4B0 File Offset: 0x005CD6B0
		public IStartMotorCruiseT AsIStartMotorCruise()
		{
			return this.As<IStartMotorCruiseT>();
		}

		// Token: 0x0602A2C6 RID: 172742 RVA: 0x005CF4B8 File Offset: 0x005CD6B8
		public static IActionParams_Union_1Union FromIStartMotorCruise(IStartMotorCruiseT _istartmotorcruise)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStartMotorCruise,
				Value = _istartmotorcruise
			};
		}

		// Token: 0x0602A2C7 RID: 172743 RVA: 0x005CF4D1 File Offset: 0x005CD6D1
		public IStopMotorCruiseT AsIStopMotorCruise()
		{
			return this.As<IStopMotorCruiseT>();
		}

		// Token: 0x0602A2C8 RID: 172744 RVA: 0x005CF4D9 File Offset: 0x005CD6D9
		public static IActionParams_Union_1Union FromIStopMotorCruise(IStopMotorCruiseT _istopmotorcruise)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStopMotorCruise,
				Value = _istopmotorcruise
			};
		}

		// Token: 0x0602A2C9 RID: 172745 RVA: 0x005CF4F2 File Offset: 0x005CD6F2
		public IDriveMotorInSpecConfigT AsIDriveMotorInSpecConfig()
		{
			return this.As<IDriveMotorInSpecConfigT>();
		}

		// Token: 0x0602A2CA RID: 172746 RVA: 0x005CF4FA File Offset: 0x005CD6FA
		public static IActionParams_Union_1Union FromIDriveMotorInSpecConfig(IDriveMotorInSpecConfigT _idrivemotorinspecconfig)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDriveMotorInSpecConfig,
				Value = _idrivemotorinspecconfig
			};
		}

		// Token: 0x0602A2CB RID: 172747 RVA: 0x005CF513 File Offset: 0x005CD713
		public IMotorSoarInWindFieldT AsIMotorSoarInWindField()
		{
			return this.As<IMotorSoarInWindFieldT>();
		}

		// Token: 0x0602A2CC RID: 172748 RVA: 0x005CF51B File Offset: 0x005CD71B
		public static IActionParams_Union_1Union FromIMotorSoarInWindField(IMotorSoarInWindFieldT _imotorsoarinwindfield)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMotorSoarInWindField,
				Value = _imotorsoarinwindfield
			};
		}

		// Token: 0x0602A2CD RID: 172749 RVA: 0x005CF534 File Offset: 0x005CD734
		public ISetSkillBtnEffectT AsISetSkillBtnEffect()
		{
			return this.As<ISetSkillBtnEffectT>();
		}

		// Token: 0x0602A2CE RID: 172750 RVA: 0x005CF53C File Offset: 0x005CD73C
		public static IActionParams_Union_1Union FromISetSkillBtnEffect(ISetSkillBtnEffectT _isetskillbtneffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSkillBtnEffect,
				Value = _isetskillbtneffect
			};
		}

		// Token: 0x0602A2CF RID: 172751 RVA: 0x005CF555 File Offset: 0x005CD755
		public ICollectSunSpiritT AsICollectSunSpirit()
		{
			return this.As<ICollectSunSpiritT>();
		}

		// Token: 0x0602A2D0 RID: 172752 RVA: 0x005CF55D File Offset: 0x005CD75D
		public static IActionParams_Union_1Union FromICollectSunSpirit(ICollectSunSpiritT _icollectsunspirit)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICollectSunSpirit,
				Value = _icollectsunspirit
			};
		}

		// Token: 0x0602A2D1 RID: 172753 RVA: 0x005CF576 File Offset: 0x005CD776
		public IPerformSunSpiritGearRoundTripT AsIPerformSunSpiritGearRoundTrip()
		{
			return this.As<IPerformSunSpiritGearRoundTripT>();
		}

		// Token: 0x0602A2D2 RID: 172754 RVA: 0x005CF57E File Offset: 0x005CD77E
		public static IActionParams_Union_1Union FromIPerformSunSpiritGearRoundTrip(IPerformSunSpiritGearRoundTripT _iperformsunspiritgearroundtrip)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformSunSpiritGearRoundTrip,
				Value = _iperformsunspiritgearroundtrip
			};
		}

		// Token: 0x0602A2D3 RID: 172755 RVA: 0x005CF597 File Offset: 0x005CD797
		public ITriggerDeadeyeModeT AsITriggerDeadeyeMode()
		{
			return this.As<ITriggerDeadeyeModeT>();
		}

		// Token: 0x0602A2D4 RID: 172756 RVA: 0x005CF59F File Offset: 0x005CD79F
		public static IActionParams_Union_1Union FromITriggerDeadeyeMode(ITriggerDeadeyeModeT _itriggerdeadeyemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerDeadeyeMode,
				Value = _itriggerdeadeyemode
			};
		}

		// Token: 0x0602A2D5 RID: 172757 RVA: 0x005CF5B8 File Offset: 0x005CD7B8
		public ITriggerSystemRandomPlotT AsITriggerSystemRandomPlot()
		{
			return this.As<ITriggerSystemRandomPlotT>();
		}

		// Token: 0x0602A2D6 RID: 172758 RVA: 0x005CF5C0 File Offset: 0x005CD7C0
		public static IActionParams_Union_1Union FromITriggerSystemRandomPlot(ITriggerSystemRandomPlotT _itriggersystemrandomplot)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerSystemRandomPlot,
				Value = _itriggersystemrandomplot
			};
		}

		// Token: 0x0602A2D7 RID: 172759 RVA: 0x005CF5D9 File Offset: 0x005CD7D9
		public ISetAudioEnableT AsISetAudioEnable()
		{
			return this.As<ISetAudioEnableT>();
		}

		// Token: 0x0602A2D8 RID: 172760 RVA: 0x005CF5E1 File Offset: 0x005CD7E1
		public static IActionParams_Union_1Union FromISetAudioEnable(ISetAudioEnableT _isetaudioenable)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetAudioEnable,
				Value = _isetaudioenable
			};
		}

		// Token: 0x0602A2D9 RID: 172761 RVA: 0x005CF5FA File Offset: 0x005CD7FA
		public IPhoneSystemInteractT AsIPhoneSystemInteract()
		{
			return this.As<IPhoneSystemInteractT>();
		}

		// Token: 0x0602A2DA RID: 172762 RVA: 0x005CF602 File Offset: 0x005CD802
		public static IActionParams_Union_1Union FromIPhoneSystemInteract(IPhoneSystemInteractT _iphonesysteminteract)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPhoneSystemInteract,
				Value = _iphonesysteminteract
			};
		}

		// Token: 0x0602A2DB RID: 172763 RVA: 0x005CF61B File Offset: 0x005CD81B
		public IRollBlockGetRewardT AsIRollBlockGetReward()
		{
			return this.As<IRollBlockGetRewardT>();
		}

		// Token: 0x0602A2DC RID: 172764 RVA: 0x005CF623 File Offset: 0x005CD823
		public static IActionParams_Union_1Union FromIRollBlockGetReward(IRollBlockGetRewardT _irollblockgetreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRollBlockGetReward,
				Value = _irollblockgetreward
			};
		}

		// Token: 0x0602A2DD RID: 172765 RVA: 0x005CF63C File Offset: 0x005CD83C
		public IEnterMovieModeT AsIEnterMovieMode()
		{
			return this.As<IEnterMovieModeT>();
		}

		// Token: 0x0602A2DE RID: 172766 RVA: 0x005CF644 File Offset: 0x005CD844
		public static IActionParams_Union_1Union FromIEnterMovieMode(IEnterMovieModeT _ientermoviemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterMovieMode,
				Value = _ientermoviemode
			};
		}

		// Token: 0x0602A2DF RID: 172767 RVA: 0x005CF65D File Offset: 0x005CD85D
		public IExitMovieModeT AsIExitMovieMode()
		{
			return this.As<IExitMovieModeT>();
		}

		// Token: 0x0602A2E0 RID: 172768 RVA: 0x005CF665 File Offset: 0x005CD865
		public static IActionParams_Union_1Union FromIExitMovieMode(IExitMovieModeT _iexitmoviemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExitMovieMode,
				Value = _iexitmoviemode
			};
		}

		// Token: 0x0602A2E1 RID: 172769 RVA: 0x005CF67E File Offset: 0x005CD87E
		public IStartRoadNetworkNavigationT AsIStartRoadNetworkNavigation()
		{
			return this.As<IStartRoadNetworkNavigationT>();
		}

		// Token: 0x0602A2E2 RID: 172770 RVA: 0x005CF686 File Offset: 0x005CD886
		public static IActionParams_Union_1Union FromIStartRoadNetworkNavigation(IStartRoadNetworkNavigationT _istartroadnetworknavigation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStartRoadNetworkNavigation,
				Value = _istartroadnetworknavigation
			};
		}

		// Token: 0x0602A2E3 RID: 172771 RVA: 0x005CF69F File Offset: 0x005CD89F
		public ISetWayOccupancyStateT AsISetWayOccupancyState()
		{
			return this.As<ISetWayOccupancyStateT>();
		}

		// Token: 0x0602A2E4 RID: 172772 RVA: 0x005CF6A7 File Offset: 0x005CD8A7
		public static IActionParams_Union_1Union FromISetWayOccupancyState(ISetWayOccupancyStateT _isetwayoccupancystate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetWayOccupancyState,
				Value = _isetwayoccupancystate
			};
		}

		// Token: 0x0602A2E5 RID: 172773 RVA: 0x005CF6C0 File Offset: 0x005CD8C0
		public IEnterPatrolStateT AsIEnterPatrolState()
		{
			return this.As<IEnterPatrolStateT>();
		}

		// Token: 0x0602A2E6 RID: 172774 RVA: 0x005CF6C8 File Offset: 0x005CD8C8
		public static IActionParams_Union_1Union FromIEnterPatrolState(IEnterPatrolStateT _ienterpatrolstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterPatrolState,
				Value = _ienterpatrolstate
			};
		}

		// Token: 0x0602A2E7 RID: 172775 RVA: 0x005CF6E1 File Offset: 0x005CD8E1
		public IPerformAiHideSelfT AsIPerformAiHideSelf()
		{
			return this.As<IPerformAiHideSelfT>();
		}

		// Token: 0x0602A2E8 RID: 172776 RVA: 0x005CF6E9 File Offset: 0x005CD8E9
		public static IActionParams_Union_1Union FromIPerformAiHideSelf(IPerformAiHideSelfT _iperformaihideself)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformAiHideSelf,
				Value = _iperformaihideself
			};
		}

		// Token: 0x0602A2E9 RID: 172777 RVA: 0x005CF702 File Offset: 0x005CD902
		public ISendSceneActorEventT AsISendSceneActorEvent()
		{
			return this.As<ISendSceneActorEventT>();
		}

		// Token: 0x0602A2EA RID: 172778 RVA: 0x005CF70A File Offset: 0x005CD90A
		public static IActionParams_Union_1Union FromISendSceneActorEvent(ISendSceneActorEventT _isendsceneactorevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISendSceneActorEvent,
				Value = _isendsceneactorevent
			};
		}

		// Token: 0x0602A2EB RID: 172779 RVA: 0x005CF723 File Offset: 0x005CD923
		public IExecBpActorFuncT AsIExecBpActorFunc()
		{
			return this.As<IExecBpActorFuncT>();
		}

		// Token: 0x0602A2EC RID: 172780 RVA: 0x005CF72B File Offset: 0x005CD92B
		public static IActionParams_Union_1Union FromIExecBpActorFunc(IExecBpActorFuncT _iexecbpactorfunc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecBpActorFunc,
				Value = _iexecbpactorfunc
			};
		}

		// Token: 0x0602A2ED RID: 172781 RVA: 0x005CF744 File Offset: 0x005CD944
		public IResetPlayerPosWithPresentationT AsIResetPlayerPosWithPresentation()
		{
			return this.As<IResetPlayerPosWithPresentationT>();
		}

		// Token: 0x0602A2EE RID: 172782 RVA: 0x005CF74C File Offset: 0x005CD94C
		public static IActionParams_Union_1Union FromIResetPlayerPosWithPresentation(IResetPlayerPosWithPresentationT _iresetplayerposwithpresentation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetPlayerPosWithPresentation,
				Value = _iresetplayerposwithpresentation
			};
		}

		// Token: 0x0602A2EF RID: 172783 RVA: 0x005CF765 File Offset: 0x005CD965
		public IDrinksRollRoleRequirementT AsIDrinksRollRoleRequirement()
		{
			return this.As<IDrinksRollRoleRequirementT>();
		}

		// Token: 0x0602A2F0 RID: 172784 RVA: 0x005CF76D File Offset: 0x005CD96D
		public static IActionParams_Union_1Union FromIDrinksRollRoleRequirement(IDrinksRollRoleRequirementT _idrinksrollrolerequirement)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDrinksRollRoleRequirement,
				Value = _idrinksrollrolerequirement
			};
		}

		// Token: 0x0602A2F1 RID: 172785 RVA: 0x005CF786 File Offset: 0x005CD986
		public ISetBlendAnimT AsISetBlendAnim()
		{
			return this.As<ISetBlendAnimT>();
		}

		// Token: 0x0602A2F2 RID: 172786 RVA: 0x005CF78E File Offset: 0x005CD98E
		public static IActionParams_Union_1Union FromISetBlendAnim(ISetBlendAnimT _isetblendanim)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetBlendAnim,
				Value = _isetblendanim
			};
		}

		// Token: 0x0602A2F3 RID: 172787 RVA: 0x005CF7A7 File Offset: 0x005CD9A7
		public IReportTrackingEventT AsIReportTrackingEvent()
		{
			return this.As<IReportTrackingEventT>();
		}

		// Token: 0x0602A2F4 RID: 172788 RVA: 0x005CF7AF File Offset: 0x005CD9AF
		public static IActionParams_Union_1Union FromIReportTrackingEvent(IReportTrackingEventT _ireporttrackingevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReportTrackingEvent,
				Value = _ireporttrackingevent
			};
		}

		// Token: 0x0602A2F5 RID: 172789 RVA: 0x005CF7C8 File Offset: 0x005CD9C8
		public ITetrisThrowBlockT AsITetrisThrowBlock()
		{
			return this.As<ITetrisThrowBlockT>();
		}

		// Token: 0x0602A2F6 RID: 172790 RVA: 0x005CF7D0 File Offset: 0x005CD9D0
		public static IActionParams_Union_1Union FromITetrisThrowBlock(ITetrisThrowBlockT _itetristhrowblock)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisThrowBlock,
				Value = _itetristhrowblock
			};
		}

		// Token: 0x0602A2F7 RID: 172791 RVA: 0x005CF7E9 File Offset: 0x005CD9E9
		public ITetrisGameCompleteT AsITetrisGameComplete()
		{
			return this.As<ITetrisGameCompleteT>();
		}

		// Token: 0x0602A2F8 RID: 172792 RVA: 0x005CF7F1 File Offset: 0x005CD9F1
		public static IActionParams_Union_1Union FromITetrisGameComplete(ITetrisGameCompleteT _itetrisgamecomplete)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisGameComplete,
				Value = _itetrisgamecomplete
			};
		}

		// Token: 0x0602A2F9 RID: 172793 RVA: 0x005CF80A File Offset: 0x005CDA0A
		public ITetrisTriggerDelayFallT AsITetrisTriggerDelayFall()
		{
			return this.As<ITetrisTriggerDelayFallT>();
		}

		// Token: 0x0602A2FA RID: 172794 RVA: 0x005CF812 File Offset: 0x005CDA12
		public static IActionParams_Union_1Union FromITetrisTriggerDelayFall(ITetrisTriggerDelayFallT _itetristriggerdelayfall)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisTriggerDelayFall,
				Value = _itetristriggerdelayfall
			};
		}

		// Token: 0x0602A2FB RID: 172795 RVA: 0x005CF82B File Offset: 0x005CDA2B
		public IBossPilingRandomBuffT AsIBossPilingRandomBuff()
		{
			return this.As<IBossPilingRandomBuffT>();
		}

		// Token: 0x0602A2FC RID: 172796 RVA: 0x005CF833 File Offset: 0x005CDA33
		public static IActionParams_Union_1Union FromIBossPilingRandomBuff(IBossPilingRandomBuffT _ibosspilingrandombuff)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBossPilingRandomBuff,
				Value = _ibosspilingrandombuff
			};
		}

		// Token: 0x0602A2FD RID: 172797 RVA: 0x005CF84C File Offset: 0x005CDA4C
		public IBossPilingEnterNextInstT AsIBossPilingEnterNextInst()
		{
			return this.As<IBossPilingEnterNextInstT>();
		}

		// Token: 0x0602A2FE RID: 172798 RVA: 0x005CF854 File Offset: 0x005CDA54
		public static IActionParams_Union_1Union FromIBossPilingEnterNextInst(IBossPilingEnterNextInstT _ibosspilingenternextinst)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBossPilingEnterNextInst,
				Value = _ibosspilingenternextinst
			};
		}

		// Token: 0x0602A2FF RID: 172799 RVA: 0x005CF86D File Offset: 0x005CDA6D
		public IOpenQuickHackSystemT AsIOpenQuickHackSystem()
		{
			return this.As<IOpenQuickHackSystemT>();
		}

		// Token: 0x0602A300 RID: 172800 RVA: 0x005CF875 File Offset: 0x005CDA75
		public static IActionParams_Union_1Union FromIOpenQuickHackSystem(IOpenQuickHackSystemT _iopenquickhacksystem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenQuickHackSystem,
				Value = _iopenquickhacksystem
			};
		}

		// Token: 0x0602A301 RID: 172801 RVA: 0x005CF88E File Offset: 0x005CDA8E
		public IDollGrabItemDeliveryT AsIDollGrabItemDelivery()
		{
			return this.As<IDollGrabItemDeliveryT>();
		}

		// Token: 0x0602A302 RID: 172802 RVA: 0x005CF896 File Offset: 0x005CDA96
		public static IActionParams_Union_1Union FromIDollGrabItemDelivery(IDollGrabItemDeliveryT _idollgrabitemdelivery)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDollGrabItemDelivery,
				Value = _idollgrabitemdelivery
			};
		}

		// Token: 0x0602A303 RID: 172803 RVA: 0x005CF8AF File Offset: 0x005CDAAF
		public ISheriffUnlockClueT AsISheriffUnlockClue()
		{
			return this.As<ISheriffUnlockClueT>();
		}

		// Token: 0x0602A304 RID: 172804 RVA: 0x005CF8B7 File Offset: 0x005CDAB7
		public static IActionParams_Union_1Union FromISheriffUnlockClue(ISheriffUnlockClueT _isheriffunlockclue)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockClue,
				Value = _isheriffunlockclue
			};
		}

		// Token: 0x0602A305 RID: 172805 RVA: 0x005CF8D0 File Offset: 0x005CDAD0
		public ISheriffUnlockProgressT AsISheriffUnlockProgress()
		{
			return this.As<ISheriffUnlockProgressT>();
		}

		// Token: 0x0602A306 RID: 172806 RVA: 0x005CF8D8 File Offset: 0x005CDAD8
		public static IActionParams_Union_1Union FromISheriffUnlockProgress(ISheriffUnlockProgressT _isheriffunlockprogress)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockProgress,
				Value = _isheriffunlockprogress
			};
		}

		// Token: 0x0602A307 RID: 172807 RVA: 0x005CF8F1 File Offset: 0x005CDAF1
		public ISheriffChangeCriminalStateT AsISheriffChangeCriminalState()
		{
			return this.As<ISheriffChangeCriminalStateT>();
		}

		// Token: 0x0602A308 RID: 172808 RVA: 0x005CF8F9 File Offset: 0x005CDAF9
		public static IActionParams_Union_1Union FromISheriffChangeCriminalState(ISheriffChangeCriminalStateT _isheriffchangecriminalstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffChangeCriminalState,
				Value = _isheriffchangecriminalstate
			};
		}

		// Token: 0x0602A309 RID: 172809 RVA: 0x005CF912 File Offset: 0x005CDB12
		public ISheriffChangeCriminalIdentityT AsISheriffChangeCriminalIdentity()
		{
			return this.As<ISheriffChangeCriminalIdentityT>();
		}

		// Token: 0x0602A30A RID: 172810 RVA: 0x005CF91A File Offset: 0x005CDB1A
		public static IActionParams_Union_1Union FromISheriffChangeCriminalIdentity(ISheriffChangeCriminalIdentityT _isheriffchangecriminalidentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffChangeCriminalIdentity,
				Value = _isheriffchangecriminalidentity
			};
		}

		// Token: 0x0602A30B RID: 172811 RVA: 0x005CF933 File Offset: 0x005CDB33
		public ISheriffUnlockEndingT AsISheriffUnlockEnding()
		{
			return this.As<ISheriffUnlockEndingT>();
		}

		// Token: 0x0602A30C RID: 172812 RVA: 0x005CF93B File Offset: 0x005CDB3B
		public static IActionParams_Union_1Union FromISheriffUnlockEnding(ISheriffUnlockEndingT _isheriffunlockending)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockEnding,
				Value = _isheriffunlockending
			};
		}

		// Token: 0x0602A30D RID: 172813 RVA: 0x005CF954 File Offset: 0x005CDB54
		public ISetTargetElementalAbilityT AsISetTargetElementalAbility()
		{
			return this.As<ISetTargetElementalAbilityT>();
		}

		// Token: 0x0602A30E RID: 172814 RVA: 0x005CF95C File Offset: 0x005CDB5C
		public static IActionParams_Union_1Union FromISetTargetElementalAbility(ISetTargetElementalAbilityT _isettargetelementalability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetTargetElementalAbility,
				Value = _isettargetelementalability
			};
		}

		// Token: 0x0602A30F RID: 172815 RVA: 0x005CF975 File Offset: 0x005CDB75
		public IToggleEntityElementalAbilityT AsIToggleEntityElementalAbility()
		{
			return this.As<IToggleEntityElementalAbilityT>();
		}

		// Token: 0x0602A310 RID: 172816 RVA: 0x005CF97D File Offset: 0x005CDB7D
		public static IActionParams_Union_1Union FromIToggleEntityElementalAbility(IToggleEntityElementalAbilityT _itoggleentityelementalability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleEntityElementalAbility,
				Value = _itoggleentityelementalability
			};
		}

		// Token: 0x0602A311 RID: 172817 RVA: 0x005CF996 File Offset: 0x005CDB96
		public ICaptureElementalBoxT AsICaptureElementalBox()
		{
			return this.As<ICaptureElementalBoxT>();
		}

		// Token: 0x0602A312 RID: 172818 RVA: 0x005CF99E File Offset: 0x005CDB9E
		public static IActionParams_Union_1Union FromICaptureElementalBox(ICaptureElementalBoxT _icaptureelementalbox)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICaptureElementalBox,
				Value = _icaptureelementalbox
			};
		}

		// Token: 0x0602A313 RID: 172819 RVA: 0x005CF9B7 File Offset: 0x005CDBB7
		public IChangeElementalBoxStateT AsIChangeElementalBoxState()
		{
			return this.As<IChangeElementalBoxStateT>();
		}

		// Token: 0x0602A314 RID: 172820 RVA: 0x005CF9BF File Offset: 0x005CDBBF
		public static IActionParams_Union_1Union FromIChangeElementalBoxState(IChangeElementalBoxStateT _ichangeelementalboxstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeElementalBoxState,
				Value = _ichangeelementalboxstate
			};
		}

		// Token: 0x0602A315 RID: 172821 RVA: 0x005CF9D8 File Offset: 0x005CDBD8
		public ISetElementalBoxToTargetT AsISetElementalBoxToTarget()
		{
			return this.As<ISetElementalBoxToTargetT>();
		}

		// Token: 0x0602A316 RID: 172822 RVA: 0x005CF9E0 File Offset: 0x005CDBE0
		public static IActionParams_Union_1Union FromISetElementalBoxToTarget(ISetElementalBoxToTargetT _isetelementalboxtotarget)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetElementalBoxToTarget,
				Value = _isetelementalboxtotarget
			};
		}

		// Token: 0x0602A317 RID: 172823 RVA: 0x005CF9FC File Offset: 0x005CDBFC
		public static int Pack(FlatBufferBuilder builder, IActionParams_Union_1Union _o)
		{
			switch (_o.Type)
			{
			case IActionParams_Union_1.ISetSportsState:
				return ISetSportsState.Pack(builder, _o.AsISetSportsState()).Value;
			case IActionParams_Union_1.ISetExploreState:
				return ISetExploreState.Pack(builder, _o.AsISetExploreState()).Value;
			case IActionParams_Union_1.IModifyActorMaterial:
				return IModifyActorMaterial.Pack(builder, _o.AsIModifyActorMaterial()).Value;
			case IActionParams_Union_1.IModifyActorMaterialParamBySplineProgress:
				return IModifyActorMaterialParamBySplineProgress.Pack(builder, _o.AsIModifyActorMaterialParamBySplineProgress()).Value;
			case IActionParams_Union_1.IModifyActorMedia:
				return IModifyActorMedia.Pack(builder, _o.AsIModifyActorMedia()).Value;
			case IActionParams_Union_1.IPlayLevelSequence:
				return IPlayLevelSequence.Pack(builder, _o.AsIPlayLevelSequence()).Value;
			case IActionParams_Union_1.IEnableTakePhotoClip:
				return IEnableTakePhotoClip.Pack(builder, _o.AsIEnableTakePhotoClip()).Value;
			case IActionParams_Union_1.IToggleAirWall:
				return IToggleAirWall.Pack(builder, _o.AsIToggleAirWall()).Value;
			case IActionParams_Union_1.ITriggerCameraShake:
				return ITriggerCameraShake.Pack(builder, _o.AsITriggerCameraShake()).Value;
			case IActionParams_Union_1.ITriggerGamepadShake:
				return ITriggerGamepadShake.Pack(builder, _o.AsITriggerGamepadShake()).Value;
			case IActionParams_Union_1.IPlayRegisteredMontage:
				return IPlayRegisteredMontage.Pack(builder, _o.AsIPlayRegisteredMontage()).Value;
			case IActionParams_Union_1.ICreatePrefab:
				return ICreatePrefab.Pack(builder, _o.AsICreatePrefab()).Value;
			case IActionParams_Union_1.IDestroyPrefab:
				return IDestroyPrefab.Pack(builder, _o.AsIDestroyPrefab()).Value;
			case IActionParams_Union_1.ISetDataLayerTransitions:
				return ISetDataLayerTransitions.Pack(builder, _o.AsISetDataLayerTransitions()).Value;
			case IActionParams_Union_1.IEnableAoiNotify:
				return IEnableAoiNotify.Pack(builder, _o.AsIEnableAoiNotify()).Value;
			case IActionParams_Union_1.IRecoverDurability:
				return IRecoverDurability.Pack(builder, _o.AsIRecoverDurability()).Value;
			case IActionParams_Union_1.ISetPlayerOperationRestriction:
				return ISetPlayerOperationRestriction.Pack(builder, _o.AsISetPlayerOperationRestriction()).Value;
			case IActionParams_Union_1.IEnableAllPlayerOperation:
				return IEnableAllPlayerOperation.Pack(builder, _o.AsIEnableAllPlayerOperation()).Value;
			case IActionParams_Union_1.IDisableAllPlayerOperation:
				return IDisableAllPlayerOperation.Pack(builder, _o.AsIDisableAllPlayerOperation()).Value;
			case IActionParams_Union_1.IDisableModulePlayerOperation:
				return IDisableModulePlayerOperation.Pack(builder, _o.AsIDisableModulePlayerOperation()).Value;
			case IActionParams_Union_1.IClientSetPlayerOperationRestriction:
				return IClientSetPlayerOperationRestriction.Pack(builder, _o.AsIClientSetPlayerOperationRestriction()).Value;
			case IActionParams_Union_1.IClientEnableAllPlayerOperation:
				return IClientEnableAllPlayerOperation.Pack(builder, _o.AsIClientEnableAllPlayerOperation()).Value;
			case IActionParams_Union_1.IClientDisableAllPlayerOperation:
				return IClientDisableAllPlayerOperation.Pack(builder, _o.AsIClientDisableAllPlayerOperation()).Value;
			case IActionParams_Union_1.IClientDisableModulePlayerOperation:
				return IClientDisableModulePlayerOperation.Pack(builder, _o.AsIClientDisableModulePlayerOperation()).Value;
			case IActionParams_Union_1.IEnableFunction:
				return IEnableFunction.Pack(builder, _o.AsIEnableFunction()).Value;
			case IActionParams_Union_1.ITeleportDungeonFunction:
				return ITeleportDungeonFunction.Pack(builder, _o.AsITeleportDungeonFunction()).Value;
			case IActionParams_Union_1.IMotorRadioUiFunction:
				return IMotorRadioUiFunction.Pack(builder, _o.AsIMotorRadioUiFunction()).Value;
			case IActionParams_Union_1.IInteractiveItemsFunction:
				return IInteractiveItemsFunction.Pack(builder, _o.AsIInteractiveItemsFunction()).Value;
			case IActionParams_Union_1.IEnableClientFunction:
				return IEnableClientFunction.Pack(builder, _o.AsIEnableClientFunction()).Value;
			case IActionParams_Union_1.IHealthBarDisplayClientFunction:
				return IHealthBarDisplayClientFunction.Pack(builder, _o.AsIHealthBarDisplayClientFunction()).Value;
			case IActionParams_Union_1.IChangeEntityPrefabPerformance:
				return IChangeEntityPrefabPerformance.Pack(builder, _o.AsIChangeEntityPrefabPerformance()).Value;
			case IActionParams_Union_1.IChangeTargetEntityPrefabPerformance:
				return IChangeTargetEntityPrefabPerformance.Pack(builder, _o.AsIChangeTargetEntityPrefabPerformance()).Value;
			case IActionParams_Union_1.IChangeSelfEntityPrefabPerformance:
				return IChangeSelfEntityPrefabPerformance.Pack(builder, _o.AsIChangeSelfEntityPrefabPerformance()).Value;
			case IActionParams_Union_1.IModifySceneItemAttributeTag:
				return IModifySceneItemAttributeTag.Pack(builder, _o.AsIModifySceneItemAttributeTag()).Value;
			case IActionParams_Union_1.IModifySelfSceneItemAttributeTag:
				return IModifySelfSceneItemAttributeTag.Pack(builder, _o.AsIModifySelfSceneItemAttributeTag()).Value;
			case IActionParams_Union_1.IModifyTargetSceneItemAttributeTag:
				return IModifyTargetSceneItemAttributeTag.Pack(builder, _o.AsIModifyTargetSceneItemAttributeTag()).Value;
			case IActionParams_Union_1.IClientModifyTargetTag:
				return IClientModifyTargetTag.Pack(builder, _o.AsIClientModifyTargetTag()).Value;
			case IActionParams_Union_1.IToggleMapMarkState:
				return IToggleMapMarkState.Pack(builder, _o.AsIToggleMapMarkState()).Value;
			case IActionParams_Union_1.IShowMapMark:
				return IShowMapMark.Pack(builder, _o.AsIShowMapMark()).Value;
			case IActionParams_Union_1.IHideMapMark:
				return IHideMapMark.Pack(builder, _o.AsIHideMapMark()).Value;
			case IActionParams_Union_1.IDisableMapMark:
				return IDisableMapMark.Pack(builder, _o.AsIDisableMapMark()).Value;
			case IActionParams_Union_1.IFocusOnMapMarkAction:
				return IFocusOnMapMarkAction.Pack(builder, _o.AsIFocusOnMapMarkAction()).Value;
			case IActionParams_Union_1.IEnableTemporaryTeleport:
				return IEnableTemporaryTeleport.Pack(builder, _o.AsIEnableTemporaryTeleport()).Value;
			case IActionParams_Union_1.ISetRegionConfig:
				return ISetRegionConfig.Pack(builder, _o.AsISetRegionConfig()).Value;
			case IActionParams_Union_1.ISetRegionMpc:
				return ISetRegionMpc.Pack(builder, _o.AsISetRegionMpc()).Value;
			case IActionParams_Union_1.ISetJigsawItem:
				return ISetJigsawItem.Pack(builder, _o.AsISetJigsawItem()).Value;
			case IActionParams_Union_1.ISetJigsawFoundation:
				return ISetJigsawFoundation.Pack(builder, _o.AsISetJigsawFoundation()).Value;
			case IActionParams_Union_1.IToggleHighlightExploreUi:
				return IToggleHighlightExploreUi.Pack(builder, _o.AsIToggleHighlightExploreUi()).Value;
			case IActionParams_Union_1.IShowHighlightExploreSkillIcon:
				return IShowHighlightExploreSkillIcon.Pack(builder, _o.AsIShowHighlightExploreSkillIcon()).Value;
			case IActionParams_Union_1.IHideHighlightExploreSkillIcon:
				return IHideHighlightExploreSkillIcon.Pack(builder, _o.AsIHideHighlightExploreSkillIcon()).Value;
			case IActionParams_Union_1.IToggleAndHighlightItem:
				return IToggleAndHighlightItem.Pack(builder, _o.AsIToggleAndHighlightItem()).Value;
			case IActionParams_Union_1.IResetEntity:
				return IResetEntity.Pack(builder, _o.AsIResetEntity()).Value;
			case IActionParams_Union_1.IResetLevelPlay:
				return IResetLevelPlay.Pack(builder, _o.AsIResetLevelPlay()).Value;
			case IActionParams_Union_1.IPlayDynamicSettlement:
				return IPlayDynamicSettlement.Pack(builder, _o.AsIPlayDynamicSettlement()).Value;
			case IActionParams_Union_1.ISetInteractionLockState:
				return ISetInteractionLockState.Pack(builder, _o.AsISetInteractionLockState()).Value;
			case IActionParams_Union_1.ISetAudioState:
				return ISetAudioState.Pack(builder, _o.AsISetAudioState()).Value;
			case IActionParams_Union_1.IPerformerAiSplineMove:
				return IPerformerAiSplineMove.Pack(builder, _o.AsIPerformerAiSplineMove()).Value;
			case IActionParams_Union_1.IPerformerAiMoveTo:
				return IPerformerAiMoveTo.Pack(builder, _o.AsIPerformerAiMoveTo()).Value;
			case IActionParams_Union_1.IAddTrialFollowShooter:
				return IAddTrialFollowShooter.Pack(builder, _o.AsIAddTrialFollowShooter()).Value;
			case IActionParams_Union_1.IRemoveTrialFollowShooter:
				return IRemoveTrialFollowShooter.Pack(builder, _o.AsIRemoveTrialFollowShooter()).Value;
			case IActionParams_Union_1.IEnableFollowShooterAbility:
				return IEnableFollowShooterAbility.Pack(builder, _o.AsIEnableFollowShooterAbility()).Value;
			case IActionParams_Union_1.IClientFollowShooterLeisureInteract:
				return IClientFollowShooterLeisureInteract.Pack(builder, _o.AsIClientFollowShooterLeisureInteract()).Value;
			case IActionParams_Union_1.ICustomJson:
				return ICustomJson.Pack(builder, _o.AsICustomJson()).Value;
			case IActionParams_Union_1.IExecResurrection:
				return IExecResurrection.Pack(builder, _o.AsIExecResurrection()).Value;
			case IActionParams_Union_1.IOpenSystemBoardWithReturn:
				return IOpenSystemBoardWithReturn.Pack(builder, _o.AsIOpenSystemBoardWithReturn()).Value;
			case IActionParams_Union_1.IResumeSystemRewardPopup:
				return IResumeSystemRewardPopup.Pack(builder, _o.AsIResumeSystemRewardPopup()).Value;
			case IActionParams_Union_1.IExecRiskHarvestEffect:
				return IExecRiskHarvestEffect.Pack(builder, _o.AsIExecRiskHarvestEffect()).Value;
			case IActionParams_Union_1.ISetTeleControl:
				return ISetTeleControl.Pack(builder, _o.AsISetTeleControl()).Value;
			case IActionParams_Union_1.IMowingTowerGotoNextFloor:
				return IMowingTowerGotoNextFloor.Pack(builder, _o.AsIMowingTowerGotoNextFloor()).Value;
			case IActionParams_Union_1.ISlashAndTowerGotoNextFloor:
				return ISlashAndTowerGotoNextFloor.Pack(builder, _o.AsISlashAndTowerGotoNextFloor()).Value;
			case IActionParams_Union_1.IRoleTowerGotoNextFloor:
				return IRoleTowerGotoNextFloor.Pack(builder, _o.AsIRoleTowerGotoNextFloor()).Value;
			case IActionParams_Union_1.IVehicleEnter:
				return IVehicleEnter.Pack(builder, _o.AsIVehicleEnter()).Value;
			case IActionParams_Union_1.IEnterNpcVehicle:
				return IEnterNpcVehicle.Pack(builder, _o.AsIEnterNpcVehicle()).Value;
			case IActionParams_Union_1.IVehicleExitPlayer:
				return IVehicleExitPlayer.Pack(builder, _o.AsIVehicleExitPlayer()).Value;
			case IActionParams_Union_1.IVehicleExitNpc:
				return IVehicleExitNpc.Pack(builder, _o.AsIVehicleExitNpc()).Value;
			case IActionParams_Union_1.ITeleportVehicle:
				return ITeleportVehicle.Pack(builder, _o.AsITeleportVehicle()).Value;
			case IActionParams_Union_1.IClientTeleportVehicle:
				return IClientTeleportVehicle.Pack(builder, _o.AsIClientTeleportVehicle()).Value;
			case IActionParams_Union_1.IVehiclePlayPassengerVoice:
				return IVehiclePlayPassengerVoice.Pack(builder, _o.AsIVehiclePlayPassengerVoice()).Value;
			case IActionParams_Union_1.IVehicleWaterfallClimbing:
				return IVehicleWaterfallClimbing.Pack(builder, _o.AsIVehicleWaterfallClimbing()).Value;
			case IActionParams_Union_1.ITeleportToAndEnterVehicle:
				return ITeleportToAndEnterVehicle.Pack(builder, _o.AsITeleportToAndEnterVehicle()).Value;
			case IActionParams_Union_1.IVehicleMoveWithPathLine:
				return IVehicleMoveWithPathLine.Pack(builder, _o.AsIVehicleMoveWithPathLine()).Value;
			case IActionParams_Union_1.IVehicleSprint:
				return IVehicleSprint.Pack(builder, _o.AsIVehicleSprint()).Value;
			case IActionParams_Union_1.IOpenQteAction:
				return IOpenQteAction.Pack(builder, _o.AsIOpenQteAction()).Value;
			case IActionParams_Union_1.IPlayerInput:
				return IPlayerInput.Pack(builder, _o.AsIPlayerInput()).Value;
			case IActionParams_Union_1.IPreloadAction:
				return IPreloadAction.Pack(builder, _o.AsIPreloadAction()).Value;
			case IActionParams_Union_1.IRemovePreloadResourceAction:
				return IRemovePreloadResourceAction.Pack(builder, _o.AsIRemovePreloadResourceAction()).Value;
			case IActionParams_Union_1.IExecAlertSystemAction:
				return IExecAlertSystemAction.Pack(builder, _o.AsIExecAlertSystemAction()).Value;
			case IActionParams_Union_1.ISetSpineAnimation:
				return ISetSpineAnimation.Pack(builder, _o.AsISetSpineAnimation()).Value;
			case IActionParams_Union_1.IChangeEntityCamp:
				return IChangeEntityCamp.Pack(builder, _o.AsIChangeEntityCamp()).Value;
			case IActionParams_Union_1.IRecordDungeonEvent:
				return IRecordDungeonEvent.Pack(builder, _o.AsIRecordDungeonEvent()).Value;
			case IActionParams_Union_1.IDangoAbyssGotoNextFloor:
				return IDangoAbyssGotoNextFloor.Pack(builder, _o.AsIDangoAbyssGotoNextFloor()).Value;
			case IActionParams_Union_1.IDangoAbyssCreateRewardTreasureBox:
				return IDangoAbyssCreateRewardTreasureBox.Pack(builder, _o.AsIDangoAbyssCreateRewardTreasureBox()).Value;
			case IActionParams_Union_1.IDangoAbyssActivatePortal:
				return IDangoAbyssActivatePortal.Pack(builder, _o.AsIDangoAbyssActivatePortal()).Value;
			case IActionParams_Union_1.IDangoAbyssReceiveReward:
				return IDangoAbyssReceiveReward.Pack(builder, _o.AsIDangoAbyssReceiveReward()).Value;
			case IActionParams_Union_1.IRoverRogueActivate:
				return IRoverRogueActivate.Pack(builder, _o.AsIRoverRogueActivate()).Value;
			case IActionParams_Union_1.IRoverRogueRoomFinish:
				return IRoverRogueRoomFinish.Pack(builder, _o.AsIRoverRogueRoomFinish()).Value;
			case IActionParams_Union_1.IRoverRogueCreateRoomReward:
				return IRoverRogueCreateRoomReward.Pack(builder, _o.AsIRoverRogueCreateRoomReward()).Value;
			case IActionParams_Union_1.IGuestOperateUiAnimation:
				return IGuestOperateUiAnimation.Pack(builder, _o.AsIGuestOperateUiAnimation()).Value;
			case IActionParams_Union_1.ISlideRailStart:
				return ISlideRailStart.Pack(builder, _o.AsISlideRailStart()).Value;
			case IActionParams_Union_1.ISlideRailEnd:
				return ISlideRailEnd.Pack(builder, _o.AsISlideRailEnd()).Value;
			case IActionParams_Union_1.ISlidePerformStart:
				return ISlidePerformStart.Pack(builder, _o.AsISlidePerformStart()).Value;
			case IActionParams_Union_1.IBvbSendSystemEvent:
				return IBvbSendSystemEvent.Pack(builder, _o.AsIBvbSendSystemEvent()).Value;
			case IActionParams_Union_1.IBvbSendAiEvent:
				return IBvbSendAiEvent.Pack(builder, _o.AsIBvbSendAiEvent()).Value;
			case IActionParams_Union_1.IBvbPlayDialog:
				return IBvbPlayDialog.Pack(builder, _o.AsIBvbPlayDialog()).Value;
			case IActionParams_Union_1.IBvbPlayerOperationConstraint:
				return IBvbPlayerOperationConstraint.Pack(builder, _o.AsIBvbPlayerOperationConstraint()).Value;
			case IActionParams_Union_1.IBvbSkipChallenge:
				return IBvbSkipChallenge.Pack(builder, _o.AsIBvbSkipChallenge()).Value;
			case IActionParams_Union_1.IActiveAntiGravitySafePoint:
				return IActiveAntiGravitySafePoint.Pack(builder, _o.AsIActiveAntiGravitySafePoint()).Value;
			case IActionParams_Union_1.ISummonEntity:
				return ISummonEntity.Pack(builder, _o.AsISummonEntity()).Value;
			case IActionParams_Union_1.IDestroySummonedEntities:
				return IDestroySummonedEntities.Pack(builder, _o.AsIDestroySummonedEntities()).Value;
			case IActionParams_Union_1.ISetupMoraleSystem:
				return ISetupMoraleSystem.Pack(builder, _o.AsISetupMoraleSystem()).Value;
			case IActionParams_Union_1.IGiantToggleModel:
				return IGiantToggleModel.Pack(builder, _o.AsIGiantToggleModel()).Value;
			case IActionParams_Union_1.IGiantTriggerResponse:
				return IGiantTriggerResponse.Pack(builder, _o.AsIGiantTriggerResponse()).Value;
			case IActionParams_Union_1.IActivateGiantTotalProgressNode:
				return IActivateGiantTotalProgressNode.Pack(builder, _o.AsIActivateGiantTotalProgressNode()).Value;
			case IActionParams_Union_1.IRunActorCustomEvent:
				return IRunActorCustomEvent.Pack(builder, _o.AsIRunActorCustomEvent()).Value;
			case IActionParams_Union_1.ITriggerSpecificScanEffect:
				return ITriggerSpecificScanEffect.Pack(builder, _o.AsITriggerSpecificScanEffect()).Value;
			case IActionParams_Union_1.ISendClientEvent:
				return ISendClientEvent.Pack(builder, _o.AsISendClientEvent()).Value;
			case IActionParams_Union_1.IScanEnrichmentArea:
				return IScanEnrichmentArea.Pack(builder, _o.AsIScanEnrichmentArea()).Value;
			case IActionParams_Union_1.IRequestSystemFunction:
				return IRequestSystemFunction.Pack(builder, _o.AsIRequestSystemFunction()).Value;
			case IActionParams_Union_1.IReignsSetPropertyVisible:
				return IReignsSetPropertyVisible.Pack(builder, _o.AsIReignsSetPropertyVisible()).Value;
			case IActionParams_Union_1.IReignsChangeBackground:
				return IReignsChangeBackground.Pack(builder, _o.AsIReignsChangeBackground()).Value;
			case IActionParams_Union_1.IReignsSetUiEffect:
				return IReignsSetUiEffect.Pack(builder, _o.AsIReignsSetUiEffect()).Value;
			case IActionParams_Union_1.IReignsChangePlayerName:
				return IReignsChangePlayerName.Pack(builder, _o.AsIReignsChangePlayerName()).Value;
			case IActionParams_Union_1.IReignsCallCard:
				return IReignsCallCard.Pack(builder, _o.AsIReignsCallCard()).Value;
			case IActionParams_Union_1.IReignsTriggerGuide:
				return IReignsTriggerGuide.Pack(builder, _o.AsIReignsTriggerGuide()).Value;
			case IActionParams_Union_1.IReignsAddBuff:
				return IReignsAddBuff.Pack(builder, _o.AsIReignsAddBuff()).Value;
			case IActionParams_Union_1.IReignsCheckSettle:
				return IReignsCheckSettle.Pack(builder, _o.AsIReignsCheckSettle()).Value;
			case IActionParams_Union_1.ISetNpcGroupPerform:
				return ISetNpcGroupPerform.Pack(builder, _o.AsISetNpcGroupPerform()).Value;
			case IActionParams_Union_1.IRemoveNpcGroupPerform:
				return IRemoveNpcGroupPerform.Pack(builder, _o.AsIRemoveNpcGroupPerform()).Value;
			case IActionParams_Union_1.IEnableEntityLookAt:
				return IEnableEntityLookAt.Pack(builder, _o.AsIEnableEntityLookAt()).Value;
			case IActionParams_Union_1.IDisableEntityLookAt:
				return IDisableEntityLookAt.Pack(builder, _o.AsIDisableEntityLookAt()).Value;
			case IActionParams_Union_1.IOverrideAiBehaviorTree:
				return IOverrideAiBehaviorTree.Pack(builder, _o.AsIOverrideAiBehaviorTree()).Value;
			case IActionParams_Union_1.IRestoreAiBehaviorTree:
				return IRestoreAiBehaviorTree.Pack(builder, _o.AsIRestoreAiBehaviorTree()).Value;
			case IActionParams_Union_1.IFlowDefineNpcGroupPerform:
				return IFlowDefineNpcGroupPerform.Pack(builder, _o.AsIFlowDefineNpcGroupPerform()).Value;
			case IActionParams_Union_1.ISeqEventAddTagToSelf:
				return ISeqEventAddTagToSelf.Pack(builder, _o.AsISeqEventAddTagToSelf()).Value;
			case IActionParams_Union_1.ISeqEventFireBullet:
				return ISeqEventFireBullet.Pack(builder, _o.AsISeqEventFireBullet()).Value;
			case IActionParams_Union_1.ITrapDefenseChangeMiniMap:
				return ITrapDefenseChangeMiniMap.Pack(builder, _o.AsITrapDefenseChangeMiniMap()).Value;
			case IActionParams_Union_1.ITrapDefensePlayerOperationConstraint:
				return ITrapDefensePlayerOperationConstraint.Pack(builder, _o.AsITrapDefensePlayerOperationConstraint()).Value;
			case IActionParams_Union_1.IHonamiStoryInteractPickUp:
				return IHonamiStoryInteractPickUp.Pack(builder, _o.AsIHonamiStoryInteractPickUp()).Value;
			case IActionParams_Union_1.IHonamiStoryReceiveCorruptedChestReward:
				return IHonamiStoryReceiveCorruptedChestReward.Pack(builder, _o.AsIHonamiStoryReceiveCorruptedChestReward()).Value;
			case IActionParams_Union_1.IHonamiStoryActivateSafeEvacuation:
				return IHonamiStoryActivateSafeEvacuation.Pack(builder, _o.AsIHonamiStoryActivateSafeEvacuation()).Value;
			case IActionParams_Union_1.IHonamiStorySetFormation:
				return IHonamiStorySetFormation.Pack(builder, _o.AsIHonamiStorySetFormation()).Value;
			case IActionParams_Union_1.IHonamiStoryGetItem:
				return IHonamiStoryGetItem.Pack(builder, _o.AsIHonamiStoryGetItem()).Value;
			case IActionParams_Union_1.IInfrActivityUpgradeInfrastructure:
				return IInfrActivityUpgradeInfrastructure.Pack(builder, _o.AsIInfrActivityUpgradeInfrastructure()).Value;
			case IActionParams_Union_1.IPlayWalkingOverlayMontage:
				return IPlayWalkingOverlayMontage.Pack(builder, _o.AsIPlayWalkingOverlayMontage()).Value;
			case IActionParams_Union_1.IEnableKey4Func:
				return IEnableKey4Func.Pack(builder, _o.AsIEnableKey4Func()).Value;
			case IActionParams_Union_1.IChangeNpcAbpState:
				return IChangeNpcAbpState.Pack(builder, _o.AsIChangeNpcAbpState()).Value;
			case IActionParams_Union_1.IOverrideAbpAnimScheme:
				return IOverrideAbpAnimScheme.Pack(builder, _o.AsIOverrideAbpAnimScheme()).Value;
			case IActionParams_Union_1.ICloseWalkingOverlayMontage:
				return ICloseWalkingOverlayMontage.Pack(builder, _o.AsICloseWalkingOverlayMontage()).Value;
			case IActionParams_Union_1.ISetMotorSpeed:
				return ISetMotorSpeed.Pack(builder, _o.AsISetMotorSpeed()).Value;
			case IActionParams_Union_1.IVehicleSetSpeedImmediately:
				return IVehicleSetSpeedImmediately.Pack(builder, _o.AsIVehicleSetSpeedImmediately()).Value;
			case IActionParams_Union_1.IStartMotorCruise:
				return IStartMotorCruise.Pack(builder, _o.AsIStartMotorCruise()).Value;
			case IActionParams_Union_1.IStopMotorCruise:
				return IStopMotorCruise.Pack(builder, _o.AsIStopMotorCruise()).Value;
			case IActionParams_Union_1.IDriveMotorInSpecConfig:
				return IDriveMotorInSpecConfig.Pack(builder, _o.AsIDriveMotorInSpecConfig()).Value;
			case IActionParams_Union_1.IMotorSoarInWindField:
				return IMotorSoarInWindField.Pack(builder, _o.AsIMotorSoarInWindField()).Value;
			case IActionParams_Union_1.ISetSkillBtnEffect:
				return ISetSkillBtnEffect.Pack(builder, _o.AsISetSkillBtnEffect()).Value;
			case IActionParams_Union_1.ICollectSunSpirit:
				return ICollectSunSpirit.Pack(builder, _o.AsICollectSunSpirit()).Value;
			case IActionParams_Union_1.IPerformSunSpiritGearRoundTrip:
				return IPerformSunSpiritGearRoundTrip.Pack(builder, _o.AsIPerformSunSpiritGearRoundTrip()).Value;
			case IActionParams_Union_1.ITriggerDeadeyeMode:
				return ITriggerDeadeyeMode.Pack(builder, _o.AsITriggerDeadeyeMode()).Value;
			case IActionParams_Union_1.ITriggerSystemRandomPlot:
				return ITriggerSystemRandomPlot.Pack(builder, _o.AsITriggerSystemRandomPlot()).Value;
			case IActionParams_Union_1.ISetAudioEnable:
				return ISetAudioEnable.Pack(builder, _o.AsISetAudioEnable()).Value;
			case IActionParams_Union_1.IPhoneSystemInteract:
				return IPhoneSystemInteract.Pack(builder, _o.AsIPhoneSystemInteract()).Value;
			case IActionParams_Union_1.IRollBlockGetReward:
				return IRollBlockGetReward.Pack(builder, _o.AsIRollBlockGetReward()).Value;
			case IActionParams_Union_1.IEnterMovieMode:
				return IEnterMovieMode.Pack(builder, _o.AsIEnterMovieMode()).Value;
			case IActionParams_Union_1.IExitMovieMode:
				return IExitMovieMode.Pack(builder, _o.AsIExitMovieMode()).Value;
			case IActionParams_Union_1.IStartRoadNetworkNavigation:
				return IStartRoadNetworkNavigation.Pack(builder, _o.AsIStartRoadNetworkNavigation()).Value;
			case IActionParams_Union_1.ISetWayOccupancyState:
				return ISetWayOccupancyState.Pack(builder, _o.AsISetWayOccupancyState()).Value;
			case IActionParams_Union_1.IEnterPatrolState:
				return IEnterPatrolState.Pack(builder, _o.AsIEnterPatrolState()).Value;
			case IActionParams_Union_1.IPerformAiHideSelf:
				return IPerformAiHideSelf.Pack(builder, _o.AsIPerformAiHideSelf()).Value;
			case IActionParams_Union_1.ISendSceneActorEvent:
				return ISendSceneActorEvent.Pack(builder, _o.AsISendSceneActorEvent()).Value;
			case IActionParams_Union_1.IExecBpActorFunc:
				return IExecBpActorFunc.Pack(builder, _o.AsIExecBpActorFunc()).Value;
			case IActionParams_Union_1.IResetPlayerPosWithPresentation:
				return IResetPlayerPosWithPresentation.Pack(builder, _o.AsIResetPlayerPosWithPresentation()).Value;
			case IActionParams_Union_1.IDrinksRollRoleRequirement:
				return IDrinksRollRoleRequirement.Pack(builder, _o.AsIDrinksRollRoleRequirement()).Value;
			case IActionParams_Union_1.ISetBlendAnim:
				return ISetBlendAnim.Pack(builder, _o.AsISetBlendAnim()).Value;
			case IActionParams_Union_1.IReportTrackingEvent:
				return IReportTrackingEvent.Pack(builder, _o.AsIReportTrackingEvent()).Value;
			case IActionParams_Union_1.ITetrisThrowBlock:
				return ITetrisThrowBlock.Pack(builder, _o.AsITetrisThrowBlock()).Value;
			case IActionParams_Union_1.ITetrisGameComplete:
				return ITetrisGameComplete.Pack(builder, _o.AsITetrisGameComplete()).Value;
			case IActionParams_Union_1.ITetrisTriggerDelayFall:
				return ITetrisTriggerDelayFall.Pack(builder, _o.AsITetrisTriggerDelayFall()).Value;
			case IActionParams_Union_1.IBossPilingRandomBuff:
				return IBossPilingRandomBuff.Pack(builder, _o.AsIBossPilingRandomBuff()).Value;
			case IActionParams_Union_1.IBossPilingEnterNextInst:
				return IBossPilingEnterNextInst.Pack(builder, _o.AsIBossPilingEnterNextInst()).Value;
			case IActionParams_Union_1.IOpenQuickHackSystem:
				return IOpenQuickHackSystem.Pack(builder, _o.AsIOpenQuickHackSystem()).Value;
			case IActionParams_Union_1.IDollGrabItemDelivery:
				return IDollGrabItemDelivery.Pack(builder, _o.AsIDollGrabItemDelivery()).Value;
			case IActionParams_Union_1.ISheriffUnlockClue:
				return ISheriffUnlockClue.Pack(builder, _o.AsISheriffUnlockClue()).Value;
			case IActionParams_Union_1.ISheriffUnlockProgress:
				return ISheriffUnlockProgress.Pack(builder, _o.AsISheriffUnlockProgress()).Value;
			case IActionParams_Union_1.ISheriffChangeCriminalState:
				return ISheriffChangeCriminalState.Pack(builder, _o.AsISheriffChangeCriminalState()).Value;
			case IActionParams_Union_1.ISheriffChangeCriminalIdentity:
				return ISheriffChangeCriminalIdentity.Pack(builder, _o.AsISheriffChangeCriminalIdentity()).Value;
			case IActionParams_Union_1.ISheriffUnlockEnding:
				return ISheriffUnlockEnding.Pack(builder, _o.AsISheriffUnlockEnding()).Value;
			case IActionParams_Union_1.ISetTargetElementalAbility:
				return ISetTargetElementalAbility.Pack(builder, _o.AsISetTargetElementalAbility()).Value;
			case IActionParams_Union_1.IToggleEntityElementalAbility:
				return IToggleEntityElementalAbility.Pack(builder, _o.AsIToggleEntityElementalAbility()).Value;
			case IActionParams_Union_1.ICaptureElementalBox:
				return ICaptureElementalBox.Pack(builder, _o.AsICaptureElementalBox()).Value;
			case IActionParams_Union_1.IChangeElementalBoxState:
				return IChangeElementalBoxState.Pack(builder, _o.AsIChangeElementalBoxState()).Value;
			case IActionParams_Union_1.ISetElementalBoxToTarget:
				return ISetElementalBoxToTarget.Pack(builder, _o.AsISetElementalBoxToTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
