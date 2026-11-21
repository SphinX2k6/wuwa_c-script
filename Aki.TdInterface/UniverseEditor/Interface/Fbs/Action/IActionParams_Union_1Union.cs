using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EF RID: 26351
	public class IActionParams_Union_1Union
	{
		// Token: 0x1700BF96 RID: 49046
		// (get) Token: 0x0602C856 RID: 182358 RVA: 0x00617E09 File Offset: 0x00616009
		// (set) Token: 0x0602C857 RID: 182359 RVA: 0x00617E11 File Offset: 0x00616011
		public IActionParams_Union_1 Type { get; set; }

		// Token: 0x1700BF97 RID: 49047
		// (get) Token: 0x0602C858 RID: 182360 RVA: 0x00617E1A File Offset: 0x0061601A
		// (set) Token: 0x0602C859 RID: 182361 RVA: 0x00617E22 File Offset: 0x00616022
		public object Value { get; set; }

		// Token: 0x0602C85A RID: 182362 RVA: 0x00617E2B File Offset: 0x0061602B
		public IActionParams_Union_1Union()
		{
			this.Type = IActionParams_Union_1.NONE;
			this.Value = null;
		}

		// Token: 0x0602C85B RID: 182363 RVA: 0x00617E41 File Offset: 0x00616041
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C85C RID: 182364 RVA: 0x00617E53 File Offset: 0x00616053
		public IEnterOrbitalCameraT AsIEnterOrbitalCamera()
		{
			return this.As<IEnterOrbitalCameraT>();
		}

		// Token: 0x0602C85D RID: 182365 RVA: 0x00617E5B File Offset: 0x0061605B
		public static IActionParams_Union_1Union FromIEnterOrbitalCamera(IEnterOrbitalCameraT _ienterorbitalcamera)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterOrbitalCamera,
				Value = _ienterorbitalcamera
			};
		}

		// Token: 0x0602C85E RID: 182366 RVA: 0x00617E70 File Offset: 0x00616070
		public IExitOrbitalCameraT AsIExitOrbitalCamera()
		{
			return this.As<IExitOrbitalCameraT>();
		}

		// Token: 0x0602C85F RID: 182367 RVA: 0x00617E78 File Offset: 0x00616078
		public static IActionParams_Union_1Union FromIExitOrbitalCamera(IExitOrbitalCameraT _iexitorbitalcamera)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExitOrbitalCamera,
				Value = _iexitorbitalcamera
			};
		}

		// Token: 0x0602C860 RID: 182368 RVA: 0x00617E8D File Offset: 0x0061608D
		public IEnableSplineMoveModelT AsIEnableSplineMoveModel()
		{
			return this.As<IEnableSplineMoveModelT>();
		}

		// Token: 0x0602C861 RID: 182369 RVA: 0x00617E95 File Offset: 0x00616095
		public static IActionParams_Union_1Union FromIEnableSplineMoveModel(IEnableSplineMoveModelT _ienablesplinemovemodel)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableSplineMoveModel,
				Value = _ienablesplinemovemodel
			};
		}

		// Token: 0x0602C862 RID: 182370 RVA: 0x00617EAA File Offset: 0x006160AA
		public IEnableActorT AsIEnableActor()
		{
			return this.As<IEnableActorT>();
		}

		// Token: 0x0602C863 RID: 182371 RVA: 0x00617EB2 File Offset: 0x006160B2
		public static IActionParams_Union_1Union FromIEnableActor(IEnableActorT _ienableactor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableActor,
				Value = _ienableactor
			};
		}

		// Token: 0x0602C864 RID: 182372 RVA: 0x00617EC7 File Offset: 0x006160C7
		public ISetSportsStateT AsISetSportsState()
		{
			return this.As<ISetSportsStateT>();
		}

		// Token: 0x0602C865 RID: 182373 RVA: 0x00617ECF File Offset: 0x006160CF
		public static IActionParams_Union_1Union FromISetSportsState(ISetSportsStateT _isetsportsstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSportsState,
				Value = _isetsportsstate
			};
		}

		// Token: 0x0602C866 RID: 182374 RVA: 0x00617EE4 File Offset: 0x006160E4
		public ISetExploreStateT AsISetExploreState()
		{
			return this.As<ISetExploreStateT>();
		}

		// Token: 0x0602C867 RID: 182375 RVA: 0x00617EEC File Offset: 0x006160EC
		public static IActionParams_Union_1Union FromISetExploreState(ISetExploreStateT _isetexplorestate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetExploreState,
				Value = _isetexplorestate
			};
		}

		// Token: 0x0602C868 RID: 182376 RVA: 0x00617F01 File Offset: 0x00616101
		public IModifyActorMaterialT AsIModifyActorMaterial()
		{
			return this.As<IModifyActorMaterialT>();
		}

		// Token: 0x0602C869 RID: 182377 RVA: 0x00617F09 File Offset: 0x00616109
		public static IActionParams_Union_1Union FromIModifyActorMaterial(IModifyActorMaterialT _imodifyactormaterial)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMaterial,
				Value = _imodifyactormaterial
			};
		}

		// Token: 0x0602C86A RID: 182378 RVA: 0x00617F1E File Offset: 0x0061611E
		public IModifyActorMaterialParamBySplineProgressT AsIModifyActorMaterialParamBySplineProgress()
		{
			return this.As<IModifyActorMaterialParamBySplineProgressT>();
		}

		// Token: 0x0602C86B RID: 182379 RVA: 0x00617F26 File Offset: 0x00616126
		public static IActionParams_Union_1Union FromIModifyActorMaterialParamBySplineProgress(IModifyActorMaterialParamBySplineProgressT _imodifyactormaterialparambysplineprogress)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMaterialParamBySplineProgress,
				Value = _imodifyactormaterialparambysplineprogress
			};
		}

		// Token: 0x0602C86C RID: 182380 RVA: 0x00617F3B File Offset: 0x0061613B
		public IModifyActorMediaT AsIModifyActorMedia()
		{
			return this.As<IModifyActorMediaT>();
		}

		// Token: 0x0602C86D RID: 182381 RVA: 0x00617F43 File Offset: 0x00616143
		public static IActionParams_Union_1Union FromIModifyActorMedia(IModifyActorMediaT _imodifyactormedia)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyActorMedia,
				Value = _imodifyactormedia
			};
		}

		// Token: 0x0602C86E RID: 182382 RVA: 0x00617F59 File Offset: 0x00616159
		public IPlayLevelSequenceT AsIPlayLevelSequence()
		{
			return this.As<IPlayLevelSequenceT>();
		}

		// Token: 0x0602C86F RID: 182383 RVA: 0x00617F61 File Offset: 0x00616161
		public static IActionParams_Union_1Union FromIPlayLevelSequence(IPlayLevelSequenceT _iplaylevelsequence)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayLevelSequence,
				Value = _iplaylevelsequence
			};
		}

		// Token: 0x0602C870 RID: 182384 RVA: 0x00617F77 File Offset: 0x00616177
		public IEnableTakePhotoClipT AsIEnableTakePhotoClip()
		{
			return this.As<IEnableTakePhotoClipT>();
		}

		// Token: 0x0602C871 RID: 182385 RVA: 0x00617F7F File Offset: 0x0061617F
		public static IActionParams_Union_1Union FromIEnableTakePhotoClip(IEnableTakePhotoClipT _ienabletakephotoclip)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableTakePhotoClip,
				Value = _ienabletakephotoclip
			};
		}

		// Token: 0x0602C872 RID: 182386 RVA: 0x00617F95 File Offset: 0x00616195
		public IToggleAirWallT AsIToggleAirWall()
		{
			return this.As<IToggleAirWallT>();
		}

		// Token: 0x0602C873 RID: 182387 RVA: 0x00617F9D File Offset: 0x0061619D
		public static IActionParams_Union_1Union FromIToggleAirWall(IToggleAirWallT _itoggleairwall)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleAirWall,
				Value = _itoggleairwall
			};
		}

		// Token: 0x0602C874 RID: 182388 RVA: 0x00617FB3 File Offset: 0x006161B3
		public ITriggerCameraShakeT AsITriggerCameraShake()
		{
			return this.As<ITriggerCameraShakeT>();
		}

		// Token: 0x0602C875 RID: 182389 RVA: 0x00617FBB File Offset: 0x006161BB
		public static IActionParams_Union_1Union FromITriggerCameraShake(ITriggerCameraShakeT _itriggercamerashake)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerCameraShake,
				Value = _itriggercamerashake
			};
		}

		// Token: 0x0602C876 RID: 182390 RVA: 0x00617FD1 File Offset: 0x006161D1
		public ITriggerGamepadShakeT AsITriggerGamepadShake()
		{
			return this.As<ITriggerGamepadShakeT>();
		}

		// Token: 0x0602C877 RID: 182391 RVA: 0x00617FD9 File Offset: 0x006161D9
		public static IActionParams_Union_1Union FromITriggerGamepadShake(ITriggerGamepadShakeT _itriggergamepadshake)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerGamepadShake,
				Value = _itriggergamepadshake
			};
		}

		// Token: 0x0602C878 RID: 182392 RVA: 0x00617FEF File Offset: 0x006161EF
		public IPlayRegisteredMontageT AsIPlayRegisteredMontage()
		{
			return this.As<IPlayRegisteredMontageT>();
		}

		// Token: 0x0602C879 RID: 182393 RVA: 0x00617FF7 File Offset: 0x006161F7
		public static IActionParams_Union_1Union FromIPlayRegisteredMontage(IPlayRegisteredMontageT _iplayregisteredmontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayRegisteredMontage,
				Value = _iplayregisteredmontage
			};
		}

		// Token: 0x0602C87A RID: 182394 RVA: 0x0061800D File Offset: 0x0061620D
		public ICreatePrefabT AsICreatePrefab()
		{
			return this.As<ICreatePrefabT>();
		}

		// Token: 0x0602C87B RID: 182395 RVA: 0x00618015 File Offset: 0x00616215
		public static IActionParams_Union_1Union FromICreatePrefab(ICreatePrefabT _icreateprefab)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICreatePrefab,
				Value = _icreateprefab
			};
		}

		// Token: 0x0602C87C RID: 182396 RVA: 0x0061802B File Offset: 0x0061622B
		public IDestroyPrefabT AsIDestroyPrefab()
		{
			return this.As<IDestroyPrefabT>();
		}

		// Token: 0x0602C87D RID: 182397 RVA: 0x00618033 File Offset: 0x00616233
		public static IActionParams_Union_1Union FromIDestroyPrefab(IDestroyPrefabT _idestroyprefab)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDestroyPrefab,
				Value = _idestroyprefab
			};
		}

		// Token: 0x0602C87E RID: 182398 RVA: 0x00618049 File Offset: 0x00616249
		public ISetDataLayerTransitionsT AsISetDataLayerTransitions()
		{
			return this.As<ISetDataLayerTransitionsT>();
		}

		// Token: 0x0602C87F RID: 182399 RVA: 0x00618051 File Offset: 0x00616251
		public static IActionParams_Union_1Union FromISetDataLayerTransitions(ISetDataLayerTransitionsT _isetdatalayertransitions)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetDataLayerTransitions,
				Value = _isetdatalayertransitions
			};
		}

		// Token: 0x0602C880 RID: 182400 RVA: 0x00618067 File Offset: 0x00616267
		public IEnableAoiNotifyT AsIEnableAoiNotify()
		{
			return this.As<IEnableAoiNotifyT>();
		}

		// Token: 0x0602C881 RID: 182401 RVA: 0x0061806F File Offset: 0x0061626F
		public static IActionParams_Union_1Union FromIEnableAoiNotify(IEnableAoiNotifyT _ienableaoinotify)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableAoiNotify,
				Value = _ienableaoinotify
			};
		}

		// Token: 0x0602C882 RID: 182402 RVA: 0x00618085 File Offset: 0x00616285
		public IRecoverDurabilityT AsIRecoverDurability()
		{
			return this.As<IRecoverDurabilityT>();
		}

		// Token: 0x0602C883 RID: 182403 RVA: 0x0061808D File Offset: 0x0061628D
		public static IActionParams_Union_1Union FromIRecoverDurability(IRecoverDurabilityT _irecoverdurability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRecoverDurability,
				Value = _irecoverdurability
			};
		}

		// Token: 0x0602C884 RID: 182404 RVA: 0x006180A3 File Offset: 0x006162A3
		public ISetPlayerOperationRestrictionT AsISetPlayerOperationRestriction()
		{
			return this.As<ISetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602C885 RID: 182405 RVA: 0x006180AB File Offset: 0x006162AB
		public static IActionParams_Union_1Union FromISetPlayerOperationRestriction(ISetPlayerOperationRestrictionT _isetplayeroperationrestriction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetPlayerOperationRestriction,
				Value = _isetplayeroperationrestriction
			};
		}

		// Token: 0x0602C886 RID: 182406 RVA: 0x006180C1 File Offset: 0x006162C1
		public IEnableAllPlayerOperationT AsIEnableAllPlayerOperation()
		{
			return this.As<IEnableAllPlayerOperationT>();
		}

		// Token: 0x0602C887 RID: 182407 RVA: 0x006180C9 File Offset: 0x006162C9
		public static IActionParams_Union_1Union FromIEnableAllPlayerOperation(IEnableAllPlayerOperationT _ienableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableAllPlayerOperation,
				Value = _ienableallplayeroperation
			};
		}

		// Token: 0x0602C888 RID: 182408 RVA: 0x006180DF File Offset: 0x006162DF
		public IDisableAllPlayerOperationT AsIDisableAllPlayerOperation()
		{
			return this.As<IDisableAllPlayerOperationT>();
		}

		// Token: 0x0602C889 RID: 182409 RVA: 0x006180E7 File Offset: 0x006162E7
		public static IActionParams_Union_1Union FromIDisableAllPlayerOperation(IDisableAllPlayerOperationT _idisableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableAllPlayerOperation,
				Value = _idisableallplayeroperation
			};
		}

		// Token: 0x0602C88A RID: 182410 RVA: 0x006180FD File Offset: 0x006162FD
		public IDisableModulePlayerOperationT AsIDisableModulePlayerOperation()
		{
			return this.As<IDisableModulePlayerOperationT>();
		}

		// Token: 0x0602C88B RID: 182411 RVA: 0x00618105 File Offset: 0x00616305
		public static IActionParams_Union_1Union FromIDisableModulePlayerOperation(IDisableModulePlayerOperationT _idisablemoduleplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableModulePlayerOperation,
				Value = _idisablemoduleplayeroperation
			};
		}

		// Token: 0x0602C88C RID: 182412 RVA: 0x0061811B File Offset: 0x0061631B
		public IClientSetPlayerOperationRestrictionT AsIClientSetPlayerOperationRestriction()
		{
			return this.As<IClientSetPlayerOperationRestrictionT>();
		}

		// Token: 0x0602C88D RID: 182413 RVA: 0x00618123 File Offset: 0x00616323
		public static IActionParams_Union_1Union FromIClientSetPlayerOperationRestriction(IClientSetPlayerOperationRestrictionT _iclientsetplayeroperationrestriction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientSetPlayerOperationRestriction,
				Value = _iclientsetplayeroperationrestriction
			};
		}

		// Token: 0x0602C88E RID: 182414 RVA: 0x00618139 File Offset: 0x00616339
		public IClientEnableAllPlayerOperationT AsIClientEnableAllPlayerOperation()
		{
			return this.As<IClientEnableAllPlayerOperationT>();
		}

		// Token: 0x0602C88F RID: 182415 RVA: 0x00618141 File Offset: 0x00616341
		public static IActionParams_Union_1Union FromIClientEnableAllPlayerOperation(IClientEnableAllPlayerOperationT _iclientenableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientEnableAllPlayerOperation,
				Value = _iclientenableallplayeroperation
			};
		}

		// Token: 0x0602C890 RID: 182416 RVA: 0x00618157 File Offset: 0x00616357
		public IClientDisableAllPlayerOperationT AsIClientDisableAllPlayerOperation()
		{
			return this.As<IClientDisableAllPlayerOperationT>();
		}

		// Token: 0x0602C891 RID: 182417 RVA: 0x0061815F File Offset: 0x0061635F
		public static IActionParams_Union_1Union FromIClientDisableAllPlayerOperation(IClientDisableAllPlayerOperationT _iclientdisableallplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientDisableAllPlayerOperation,
				Value = _iclientdisableallplayeroperation
			};
		}

		// Token: 0x0602C892 RID: 182418 RVA: 0x00618175 File Offset: 0x00616375
		public IClientDisableModulePlayerOperationT AsIClientDisableModulePlayerOperation()
		{
			return this.As<IClientDisableModulePlayerOperationT>();
		}

		// Token: 0x0602C893 RID: 182419 RVA: 0x0061817D File Offset: 0x0061637D
		public static IActionParams_Union_1Union FromIClientDisableModulePlayerOperation(IClientDisableModulePlayerOperationT _iclientdisablemoduleplayeroperation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientDisableModulePlayerOperation,
				Value = _iclientdisablemoduleplayeroperation
			};
		}

		// Token: 0x0602C894 RID: 182420 RVA: 0x00618193 File Offset: 0x00616393
		public IEnableFunctionT AsIEnableFunction()
		{
			return this.As<IEnableFunctionT>();
		}

		// Token: 0x0602C895 RID: 182421 RVA: 0x0061819B File Offset: 0x0061639B
		public static IActionParams_Union_1Union FromIEnableFunction(IEnableFunctionT _ienablefunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableFunction,
				Value = _ienablefunction
			};
		}

		// Token: 0x0602C896 RID: 182422 RVA: 0x006181B1 File Offset: 0x006163B1
		public ITeleportDungeonFunctionT AsITeleportDungeonFunction()
		{
			return this.As<ITeleportDungeonFunctionT>();
		}

		// Token: 0x0602C897 RID: 182423 RVA: 0x006181B9 File Offset: 0x006163B9
		public static IActionParams_Union_1Union FromITeleportDungeonFunction(ITeleportDungeonFunctionT _iteleportdungeonfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportDungeonFunction,
				Value = _iteleportdungeonfunction
			};
		}

		// Token: 0x0602C898 RID: 182424 RVA: 0x006181CF File Offset: 0x006163CF
		public IMotorRadioUiFunctionT AsIMotorRadioUiFunction()
		{
			return this.As<IMotorRadioUiFunctionT>();
		}

		// Token: 0x0602C899 RID: 182425 RVA: 0x006181D7 File Offset: 0x006163D7
		public static IActionParams_Union_1Union FromIMotorRadioUiFunction(IMotorRadioUiFunctionT _imotorradiouifunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMotorRadioUiFunction,
				Value = _imotorradiouifunction
			};
		}

		// Token: 0x0602C89A RID: 182426 RVA: 0x006181ED File Offset: 0x006163ED
		public IInteractiveItemsFunctionT AsIInteractiveItemsFunction()
		{
			return this.As<IInteractiveItemsFunctionT>();
		}

		// Token: 0x0602C89B RID: 182427 RVA: 0x006181F5 File Offset: 0x006163F5
		public static IActionParams_Union_1Union FromIInteractiveItemsFunction(IInteractiveItemsFunctionT _iinteractiveitemsfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IInteractiveItemsFunction,
				Value = _iinteractiveitemsfunction
			};
		}

		// Token: 0x0602C89C RID: 182428 RVA: 0x0061820B File Offset: 0x0061640B
		public IEnableClientFunctionT AsIEnableClientFunction()
		{
			return this.As<IEnableClientFunctionT>();
		}

		// Token: 0x0602C89D RID: 182429 RVA: 0x00618213 File Offset: 0x00616413
		public static IActionParams_Union_1Union FromIEnableClientFunction(IEnableClientFunctionT _ienableclientfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableClientFunction,
				Value = _ienableclientfunction
			};
		}

		// Token: 0x0602C89E RID: 182430 RVA: 0x00618229 File Offset: 0x00616429
		public IHealthBarDisplayClientFunctionT AsIHealthBarDisplayClientFunction()
		{
			return this.As<IHealthBarDisplayClientFunctionT>();
		}

		// Token: 0x0602C89F RID: 182431 RVA: 0x00618231 File Offset: 0x00616431
		public static IActionParams_Union_1Union FromIHealthBarDisplayClientFunction(IHealthBarDisplayClientFunctionT _ihealthbardisplayclientfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHealthBarDisplayClientFunction,
				Value = _ihealthbardisplayclientfunction
			};
		}

		// Token: 0x0602C8A0 RID: 182432 RVA: 0x00618247 File Offset: 0x00616447
		public IChangeEntityPrefabPerformanceT AsIChangeEntityPrefabPerformance()
		{
			return this.As<IChangeEntityPrefabPerformanceT>();
		}

		// Token: 0x0602C8A1 RID: 182433 RVA: 0x0061824F File Offset: 0x0061644F
		public static IActionParams_Union_1Union FromIChangeEntityPrefabPerformance(IChangeEntityPrefabPerformanceT _ichangeentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeEntityPrefabPerformance,
				Value = _ichangeentityprefabperformance
			};
		}

		// Token: 0x0602C8A2 RID: 182434 RVA: 0x00618265 File Offset: 0x00616465
		public IChangeTargetEntityPrefabPerformanceT AsIChangeTargetEntityPrefabPerformance()
		{
			return this.As<IChangeTargetEntityPrefabPerformanceT>();
		}

		// Token: 0x0602C8A3 RID: 182435 RVA: 0x0061826D File Offset: 0x0061646D
		public static IActionParams_Union_1Union FromIChangeTargetEntityPrefabPerformance(IChangeTargetEntityPrefabPerformanceT _ichangetargetentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeTargetEntityPrefabPerformance,
				Value = _ichangetargetentityprefabperformance
			};
		}

		// Token: 0x0602C8A4 RID: 182436 RVA: 0x00618283 File Offset: 0x00616483
		public IChangeSelfEntityPrefabPerformanceT AsIChangeSelfEntityPrefabPerformance()
		{
			return this.As<IChangeSelfEntityPrefabPerformanceT>();
		}

		// Token: 0x0602C8A5 RID: 182437 RVA: 0x0061828B File Offset: 0x0061648B
		public static IActionParams_Union_1Union FromIChangeSelfEntityPrefabPerformance(IChangeSelfEntityPrefabPerformanceT _ichangeselfentityprefabperformance)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeSelfEntityPrefabPerformance,
				Value = _ichangeselfentityprefabperformance
			};
		}

		// Token: 0x0602C8A6 RID: 182438 RVA: 0x006182A1 File Offset: 0x006164A1
		public IModifySceneItemAttributeTagT AsIModifySceneItemAttributeTag()
		{
			return this.As<IModifySceneItemAttributeTagT>();
		}

		// Token: 0x0602C8A7 RID: 182439 RVA: 0x006182A9 File Offset: 0x006164A9
		public static IActionParams_Union_1Union FromIModifySceneItemAttributeTag(IModifySceneItemAttributeTagT _imodifysceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifySceneItemAttributeTag,
				Value = _imodifysceneitemattributetag
			};
		}

		// Token: 0x0602C8A8 RID: 182440 RVA: 0x006182BF File Offset: 0x006164BF
		public IModifySelfSceneItemAttributeTagT AsIModifySelfSceneItemAttributeTag()
		{
			return this.As<IModifySelfSceneItemAttributeTagT>();
		}

		// Token: 0x0602C8A9 RID: 182441 RVA: 0x006182C7 File Offset: 0x006164C7
		public static IActionParams_Union_1Union FromIModifySelfSceneItemAttributeTag(IModifySelfSceneItemAttributeTagT _imodifyselfsceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifySelfSceneItemAttributeTag,
				Value = _imodifyselfsceneitemattributetag
			};
		}

		// Token: 0x0602C8AA RID: 182442 RVA: 0x006182DD File Offset: 0x006164DD
		public IModifyTargetSceneItemAttributeTagT AsIModifyTargetSceneItemAttributeTag()
		{
			return this.As<IModifyTargetSceneItemAttributeTagT>();
		}

		// Token: 0x0602C8AB RID: 182443 RVA: 0x006182E5 File Offset: 0x006164E5
		public static IActionParams_Union_1Union FromIModifyTargetSceneItemAttributeTag(IModifyTargetSceneItemAttributeTagT _imodifytargetsceneitemattributetag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IModifyTargetSceneItemAttributeTag,
				Value = _imodifytargetsceneitemattributetag
			};
		}

		// Token: 0x0602C8AC RID: 182444 RVA: 0x006182FB File Offset: 0x006164FB
		public IClientModifyTargetTagT AsIClientModifyTargetTag()
		{
			return this.As<IClientModifyTargetTagT>();
		}

		// Token: 0x0602C8AD RID: 182445 RVA: 0x00618303 File Offset: 0x00616503
		public static IActionParams_Union_1Union FromIClientModifyTargetTag(IClientModifyTargetTagT _iclientmodifytargettag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientModifyTargetTag,
				Value = _iclientmodifytargettag
			};
		}

		// Token: 0x0602C8AE RID: 182446 RVA: 0x00618319 File Offset: 0x00616519
		public IToggleMapMarkStateT AsIToggleMapMarkState()
		{
			return this.As<IToggleMapMarkStateT>();
		}

		// Token: 0x0602C8AF RID: 182447 RVA: 0x00618321 File Offset: 0x00616521
		public static IActionParams_Union_1Union FromIToggleMapMarkState(IToggleMapMarkStateT _itogglemapmarkstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleMapMarkState,
				Value = _itogglemapmarkstate
			};
		}

		// Token: 0x0602C8B0 RID: 182448 RVA: 0x00618337 File Offset: 0x00616537
		public IShowMapMarkT AsIShowMapMark()
		{
			return this.As<IShowMapMarkT>();
		}

		// Token: 0x0602C8B1 RID: 182449 RVA: 0x0061833F File Offset: 0x0061653F
		public static IActionParams_Union_1Union FromIShowMapMark(IShowMapMarkT _ishowmapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IShowMapMark,
				Value = _ishowmapmark
			};
		}

		// Token: 0x0602C8B2 RID: 182450 RVA: 0x00618355 File Offset: 0x00616555
		public IHideMapMarkT AsIHideMapMark()
		{
			return this.As<IHideMapMarkT>();
		}

		// Token: 0x0602C8B3 RID: 182451 RVA: 0x0061835D File Offset: 0x0061655D
		public static IActionParams_Union_1Union FromIHideMapMark(IHideMapMarkT _ihidemapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHideMapMark,
				Value = _ihidemapmark
			};
		}

		// Token: 0x0602C8B4 RID: 182452 RVA: 0x00618373 File Offset: 0x00616573
		public IDisableMapMarkT AsIDisableMapMark()
		{
			return this.As<IDisableMapMarkT>();
		}

		// Token: 0x0602C8B5 RID: 182453 RVA: 0x0061837B File Offset: 0x0061657B
		public static IActionParams_Union_1Union FromIDisableMapMark(IDisableMapMarkT _idisablemapmark)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableMapMark,
				Value = _idisablemapmark
			};
		}

		// Token: 0x0602C8B6 RID: 182454 RVA: 0x00618391 File Offset: 0x00616591
		public IFocusOnMapMarkActionT AsIFocusOnMapMarkAction()
		{
			return this.As<IFocusOnMapMarkActionT>();
		}

		// Token: 0x0602C8B7 RID: 182455 RVA: 0x00618399 File Offset: 0x00616599
		public static IActionParams_Union_1Union FromIFocusOnMapMarkAction(IFocusOnMapMarkActionT _ifocusonmapmarkaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IFocusOnMapMarkAction,
				Value = _ifocusonmapmarkaction
			};
		}

		// Token: 0x0602C8B8 RID: 182456 RVA: 0x006183AF File Offset: 0x006165AF
		public IEnableTemporaryTeleportT AsIEnableTemporaryTeleport()
		{
			return this.As<IEnableTemporaryTeleportT>();
		}

		// Token: 0x0602C8B9 RID: 182457 RVA: 0x006183B7 File Offset: 0x006165B7
		public static IActionParams_Union_1Union FromIEnableTemporaryTeleport(IEnableTemporaryTeleportT _ienabletemporaryteleport)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableTemporaryTeleport,
				Value = _ienabletemporaryteleport
			};
		}

		// Token: 0x0602C8BA RID: 182458 RVA: 0x006183CD File Offset: 0x006165CD
		public ISetRegionConfigT AsISetRegionConfig()
		{
			return this.As<ISetRegionConfigT>();
		}

		// Token: 0x0602C8BB RID: 182459 RVA: 0x006183D5 File Offset: 0x006165D5
		public static IActionParams_Union_1Union FromISetRegionConfig(ISetRegionConfigT _isetregionconfig)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetRegionConfig,
				Value = _isetregionconfig
			};
		}

		// Token: 0x0602C8BC RID: 182460 RVA: 0x006183EB File Offset: 0x006165EB
		public ISetRegionMpcT AsISetRegionMpc()
		{
			return this.As<ISetRegionMpcT>();
		}

		// Token: 0x0602C8BD RID: 182461 RVA: 0x006183F3 File Offset: 0x006165F3
		public static IActionParams_Union_1Union FromISetRegionMpc(ISetRegionMpcT _isetregionmpc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetRegionMpc,
				Value = _isetregionmpc
			};
		}

		// Token: 0x0602C8BE RID: 182462 RVA: 0x00618409 File Offset: 0x00616609
		public ISetJigsawItemT AsISetJigsawItem()
		{
			return this.As<ISetJigsawItemT>();
		}

		// Token: 0x0602C8BF RID: 182463 RVA: 0x00618411 File Offset: 0x00616611
		public static IActionParams_Union_1Union FromISetJigsawItem(ISetJigsawItemT _isetjigsawitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetJigsawItem,
				Value = _isetjigsawitem
			};
		}

		// Token: 0x0602C8C0 RID: 182464 RVA: 0x00618427 File Offset: 0x00616627
		public ISetJigsawFoundationT AsISetJigsawFoundation()
		{
			return this.As<ISetJigsawFoundationT>();
		}

		// Token: 0x0602C8C1 RID: 182465 RVA: 0x0061842F File Offset: 0x0061662F
		public static IActionParams_Union_1Union FromISetJigsawFoundation(ISetJigsawFoundationT _isetjigsawfoundation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetJigsawFoundation,
				Value = _isetjigsawfoundation
			};
		}

		// Token: 0x0602C8C2 RID: 182466 RVA: 0x00618445 File Offset: 0x00616645
		public IToggleHighlightExploreUiT AsIToggleHighlightExploreUi()
		{
			return this.As<IToggleHighlightExploreUiT>();
		}

		// Token: 0x0602C8C3 RID: 182467 RVA: 0x0061844D File Offset: 0x0061664D
		public static IActionParams_Union_1Union FromIToggleHighlightExploreUi(IToggleHighlightExploreUiT _itogglehighlightexploreui)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleHighlightExploreUi,
				Value = _itogglehighlightexploreui
			};
		}

		// Token: 0x0602C8C4 RID: 182468 RVA: 0x00618463 File Offset: 0x00616663
		public IShowHighlightExploreSkillIconT AsIShowHighlightExploreSkillIcon()
		{
			return this.As<IShowHighlightExploreSkillIconT>();
		}

		// Token: 0x0602C8C5 RID: 182469 RVA: 0x0061846B File Offset: 0x0061666B
		public static IActionParams_Union_1Union FromIShowHighlightExploreSkillIcon(IShowHighlightExploreSkillIconT _ishowhighlightexploreskillicon)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IShowHighlightExploreSkillIcon,
				Value = _ishowhighlightexploreskillicon
			};
		}

		// Token: 0x0602C8C6 RID: 182470 RVA: 0x00618481 File Offset: 0x00616681
		public IHideHighlightExploreSkillIconT AsIHideHighlightExploreSkillIcon()
		{
			return this.As<IHideHighlightExploreSkillIconT>();
		}

		// Token: 0x0602C8C7 RID: 182471 RVA: 0x00618489 File Offset: 0x00616689
		public static IActionParams_Union_1Union FromIHideHighlightExploreSkillIcon(IHideHighlightExploreSkillIconT _ihidehighlightexploreskillicon)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHideHighlightExploreSkillIcon,
				Value = _ihidehighlightexploreskillicon
			};
		}

		// Token: 0x0602C8C8 RID: 182472 RVA: 0x0061849F File Offset: 0x0061669F
		public IToggleAndHighlightItemT AsIToggleAndHighlightItem()
		{
			return this.As<IToggleAndHighlightItemT>();
		}

		// Token: 0x0602C8C9 RID: 182473 RVA: 0x006184A7 File Offset: 0x006166A7
		public static IActionParams_Union_1Union FromIToggleAndHighlightItem(IToggleAndHighlightItemT _itoggleandhighlightitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleAndHighlightItem,
				Value = _itoggleandhighlightitem
			};
		}

		// Token: 0x0602C8CA RID: 182474 RVA: 0x006184BD File Offset: 0x006166BD
		public IResetEntityT AsIResetEntity()
		{
			return this.As<IResetEntityT>();
		}

		// Token: 0x0602C8CB RID: 182475 RVA: 0x006184C5 File Offset: 0x006166C5
		public static IActionParams_Union_1Union FromIResetEntity(IResetEntityT _iresetentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetEntity,
				Value = _iresetentity
			};
		}

		// Token: 0x0602C8CC RID: 182476 RVA: 0x006184DB File Offset: 0x006166DB
		public IResetLevelPlayT AsIResetLevelPlay()
		{
			return this.As<IResetLevelPlayT>();
		}

		// Token: 0x0602C8CD RID: 182477 RVA: 0x006184E3 File Offset: 0x006166E3
		public static IActionParams_Union_1Union FromIResetLevelPlay(IResetLevelPlayT _iresetlevelplay)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetLevelPlay,
				Value = _iresetlevelplay
			};
		}

		// Token: 0x0602C8CE RID: 182478 RVA: 0x006184F9 File Offset: 0x006166F9
		public IPlayDynamicSettlementT AsIPlayDynamicSettlement()
		{
			return this.As<IPlayDynamicSettlementT>();
		}

		// Token: 0x0602C8CF RID: 182479 RVA: 0x00618501 File Offset: 0x00616701
		public static IActionParams_Union_1Union FromIPlayDynamicSettlement(IPlayDynamicSettlementT _iplaydynamicsettlement)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayDynamicSettlement,
				Value = _iplaydynamicsettlement
			};
		}

		// Token: 0x0602C8D0 RID: 182480 RVA: 0x00618517 File Offset: 0x00616717
		public ISetInteractionLockStateT AsISetInteractionLockState()
		{
			return this.As<ISetInteractionLockStateT>();
		}

		// Token: 0x0602C8D1 RID: 182481 RVA: 0x0061851F File Offset: 0x0061671F
		public static IActionParams_Union_1Union FromISetInteractionLockState(ISetInteractionLockStateT _isetinteractionlockstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetInteractionLockState,
				Value = _isetinteractionlockstate
			};
		}

		// Token: 0x0602C8D2 RID: 182482 RVA: 0x00618535 File Offset: 0x00616735
		public ISetAudioStateT AsISetAudioState()
		{
			return this.As<ISetAudioStateT>();
		}

		// Token: 0x0602C8D3 RID: 182483 RVA: 0x0061853D File Offset: 0x0061673D
		public static IActionParams_Union_1Union FromISetAudioState(ISetAudioStateT _isetaudiostate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetAudioState,
				Value = _isetaudiostate
			};
		}

		// Token: 0x0602C8D4 RID: 182484 RVA: 0x00618553 File Offset: 0x00616753
		public ISendBattleTagT AsISendBattleTag()
		{
			return this.As<ISendBattleTagT>();
		}

		// Token: 0x0602C8D5 RID: 182485 RVA: 0x0061855B File Offset: 0x0061675B
		public static IActionParams_Union_1Union FromISendBattleTag(ISendBattleTagT _isendbattletag)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISendBattleTag,
				Value = _isendbattletag
			};
		}

		// Token: 0x0602C8D6 RID: 182486 RVA: 0x00618571 File Offset: 0x00616771
		public IPerformerAiSplineMoveT AsIPerformerAiSplineMove()
		{
			return this.As<IPerformerAiSplineMoveT>();
		}

		// Token: 0x0602C8D7 RID: 182487 RVA: 0x00618579 File Offset: 0x00616779
		public static IActionParams_Union_1Union FromIPerformerAiSplineMove(IPerformerAiSplineMoveT _iperformeraisplinemove)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformerAiSplineMove,
				Value = _iperformeraisplinemove
			};
		}

		// Token: 0x0602C8D8 RID: 182488 RVA: 0x0061858F File Offset: 0x0061678F
		public IPerformerAiMoveToT AsIPerformerAiMoveTo()
		{
			return this.As<IPerformerAiMoveToT>();
		}

		// Token: 0x0602C8D9 RID: 182489 RVA: 0x00618597 File Offset: 0x00616797
		public static IActionParams_Union_1Union FromIPerformerAiMoveTo(IPerformerAiMoveToT _iperformeraimoveto)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformerAiMoveTo,
				Value = _iperformeraimoveto
			};
		}

		// Token: 0x0602C8DA RID: 182490 RVA: 0x006185AD File Offset: 0x006167AD
		public IAddTrialFollowShooterT AsIAddTrialFollowShooter()
		{
			return this.As<IAddTrialFollowShooterT>();
		}

		// Token: 0x0602C8DB RID: 182491 RVA: 0x006185B5 File Offset: 0x006167B5
		public static IActionParams_Union_1Union FromIAddTrialFollowShooter(IAddTrialFollowShooterT _iaddtrialfollowshooter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IAddTrialFollowShooter,
				Value = _iaddtrialfollowshooter
			};
		}

		// Token: 0x0602C8DC RID: 182492 RVA: 0x006185CB File Offset: 0x006167CB
		public IRemoveTrialFollowShooterT AsIRemoveTrialFollowShooter()
		{
			return this.As<IRemoveTrialFollowShooterT>();
		}

		// Token: 0x0602C8DD RID: 182493 RVA: 0x006185D3 File Offset: 0x006167D3
		public static IActionParams_Union_1Union FromIRemoveTrialFollowShooter(IRemoveTrialFollowShooterT _iremovetrialfollowshooter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemoveTrialFollowShooter,
				Value = _iremovetrialfollowshooter
			};
		}

		// Token: 0x0602C8DE RID: 182494 RVA: 0x006185E9 File Offset: 0x006167E9
		public IEnableFollowShooterAbilityT AsIEnableFollowShooterAbility()
		{
			return this.As<IEnableFollowShooterAbilityT>();
		}

		// Token: 0x0602C8DF RID: 182495 RVA: 0x006185F1 File Offset: 0x006167F1
		public static IActionParams_Union_1Union FromIEnableFollowShooterAbility(IEnableFollowShooterAbilityT _ienablefollowshooterability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableFollowShooterAbility,
				Value = _ienablefollowshooterability
			};
		}

		// Token: 0x0602C8E0 RID: 182496 RVA: 0x00618607 File Offset: 0x00616807
		public IFollowShooterLeisureInteractT AsIFollowShooterLeisureInteract()
		{
			return this.As<IFollowShooterLeisureInteractT>();
		}

		// Token: 0x0602C8E1 RID: 182497 RVA: 0x0061860F File Offset: 0x0061680F
		public static IActionParams_Union_1Union FromIFollowShooterLeisureInteract(IFollowShooterLeisureInteractT _ifollowshooterleisureinteract)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IFollowShooterLeisureInteract,
				Value = _ifollowshooterleisureinteract
			};
		}

		// Token: 0x0602C8E2 RID: 182498 RVA: 0x00618625 File Offset: 0x00616825
		public IClientFollowShooterLeisureInteractT AsIClientFollowShooterLeisureInteract()
		{
			return this.As<IClientFollowShooterLeisureInteractT>();
		}

		// Token: 0x0602C8E3 RID: 182499 RVA: 0x0061862D File Offset: 0x0061682D
		public static IActionParams_Union_1Union FromIClientFollowShooterLeisureInteract(IClientFollowShooterLeisureInteractT _iclientfollowshooterleisureinteract)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientFollowShooterLeisureInteract,
				Value = _iclientfollowshooterleisureinteract
			};
		}

		// Token: 0x0602C8E4 RID: 182500 RVA: 0x00618643 File Offset: 0x00616843
		public ICustomJsonT AsICustomJson()
		{
			return this.As<ICustomJsonT>();
		}

		// Token: 0x0602C8E5 RID: 182501 RVA: 0x0061864B File Offset: 0x0061684B
		public static IActionParams_Union_1Union FromICustomJson(ICustomJsonT _icustomjson)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICustomJson,
				Value = _icustomjson
			};
		}

		// Token: 0x0602C8E6 RID: 182502 RVA: 0x00618661 File Offset: 0x00616861
		public IExecResurrectionT AsIExecResurrection()
		{
			return this.As<IExecResurrectionT>();
		}

		// Token: 0x0602C8E7 RID: 182503 RVA: 0x00618669 File Offset: 0x00616869
		public static IActionParams_Union_1Union FromIExecResurrection(IExecResurrectionT _iexecresurrection)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecResurrection,
				Value = _iexecresurrection
			};
		}

		// Token: 0x0602C8E8 RID: 182504 RVA: 0x0061867F File Offset: 0x0061687F
		public IOpenSystemBoardWithReturnT AsIOpenSystemBoardWithReturn()
		{
			return this.As<IOpenSystemBoardWithReturnT>();
		}

		// Token: 0x0602C8E9 RID: 182505 RVA: 0x00618687 File Offset: 0x00616887
		public static IActionParams_Union_1Union FromIOpenSystemBoardWithReturn(IOpenSystemBoardWithReturnT _iopensystemboardwithreturn)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenSystemBoardWithReturn,
				Value = _iopensystemboardwithreturn
			};
		}

		// Token: 0x0602C8EA RID: 182506 RVA: 0x0061869D File Offset: 0x0061689D
		public IResumeSystemRewardPopupT AsIResumeSystemRewardPopup()
		{
			return this.As<IResumeSystemRewardPopupT>();
		}

		// Token: 0x0602C8EB RID: 182507 RVA: 0x006186A5 File Offset: 0x006168A5
		public static IActionParams_Union_1Union FromIResumeSystemRewardPopup(IResumeSystemRewardPopupT _iresumesystemrewardpopup)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResumeSystemRewardPopup,
				Value = _iresumesystemrewardpopup
			};
		}

		// Token: 0x0602C8EC RID: 182508 RVA: 0x006186BB File Offset: 0x006168BB
		public IExecRiskHarvestEffectT AsIExecRiskHarvestEffect()
		{
			return this.As<IExecRiskHarvestEffectT>();
		}

		// Token: 0x0602C8ED RID: 182509 RVA: 0x006186C3 File Offset: 0x006168C3
		public static IActionParams_Union_1Union FromIExecRiskHarvestEffect(IExecRiskHarvestEffectT _iexecriskharvesteffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecRiskHarvestEffect,
				Value = _iexecriskharvesteffect
			};
		}

		// Token: 0x0602C8EE RID: 182510 RVA: 0x006186D9 File Offset: 0x006168D9
		public ISetTeleControlT AsISetTeleControl()
		{
			return this.As<ISetTeleControlT>();
		}

		// Token: 0x0602C8EF RID: 182511 RVA: 0x006186E1 File Offset: 0x006168E1
		public static IActionParams_Union_1Union FromISetTeleControl(ISetTeleControlT _isettelecontrol)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetTeleControl,
				Value = _isettelecontrol
			};
		}

		// Token: 0x0602C8F0 RID: 182512 RVA: 0x006186F7 File Offset: 0x006168F7
		public IMowingTowerGotoNextFloorT AsIMowingTowerGotoNextFloor()
		{
			return this.As<IMowingTowerGotoNextFloorT>();
		}

		// Token: 0x0602C8F1 RID: 182513 RVA: 0x006186FF File Offset: 0x006168FF
		public static IActionParams_Union_1Union FromIMowingTowerGotoNextFloor(IMowingTowerGotoNextFloorT _imowingtowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMowingTowerGotoNextFloor,
				Value = _imowingtowergotonextfloor
			};
		}

		// Token: 0x0602C8F2 RID: 182514 RVA: 0x00618715 File Offset: 0x00616915
		public ISlashAndTowerGotoNextFloorT AsISlashAndTowerGotoNextFloor()
		{
			return this.As<ISlashAndTowerGotoNextFloorT>();
		}

		// Token: 0x0602C8F3 RID: 182515 RVA: 0x0061871D File Offset: 0x0061691D
		public static IActionParams_Union_1Union FromISlashAndTowerGotoNextFloor(ISlashAndTowerGotoNextFloorT _islashandtowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlashAndTowerGotoNextFloor,
				Value = _islashandtowergotonextfloor
			};
		}

		// Token: 0x0602C8F4 RID: 182516 RVA: 0x00618733 File Offset: 0x00616933
		public IRoleTowerGotoNextFloorT AsIRoleTowerGotoNextFloor()
		{
			return this.As<IRoleTowerGotoNextFloorT>();
		}

		// Token: 0x0602C8F5 RID: 182517 RVA: 0x0061873B File Offset: 0x0061693B
		public static IActionParams_Union_1Union FromIRoleTowerGotoNextFloor(IRoleTowerGotoNextFloorT _iroletowergotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoleTowerGotoNextFloor,
				Value = _iroletowergotonextfloor
			};
		}

		// Token: 0x0602C8F6 RID: 182518 RVA: 0x00618751 File Offset: 0x00616951
		public IVehicleEnterT AsIVehicleEnter()
		{
			return this.As<IVehicleEnterT>();
		}

		// Token: 0x0602C8F7 RID: 182519 RVA: 0x00618759 File Offset: 0x00616959
		public static IActionParams_Union_1Union FromIVehicleEnter(IVehicleEnterT _ivehicleenter)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleEnter,
				Value = _ivehicleenter
			};
		}

		// Token: 0x0602C8F8 RID: 182520 RVA: 0x0061876F File Offset: 0x0061696F
		public IEnterNpcVehicleT AsIEnterNpcVehicle()
		{
			return this.As<IEnterNpcVehicleT>();
		}

		// Token: 0x0602C8F9 RID: 182521 RVA: 0x00618777 File Offset: 0x00616977
		public static IActionParams_Union_1Union FromIEnterNpcVehicle(IEnterNpcVehicleT _ienternpcvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterNpcVehicle,
				Value = _ienternpcvehicle
			};
		}

		// Token: 0x0602C8FA RID: 182522 RVA: 0x0061878D File Offset: 0x0061698D
		public IVehicleExitPlayerT AsIVehicleExitPlayer()
		{
			return this.As<IVehicleExitPlayerT>();
		}

		// Token: 0x0602C8FB RID: 182523 RVA: 0x00618795 File Offset: 0x00616995
		public static IActionParams_Union_1Union FromIVehicleExitPlayer(IVehicleExitPlayerT _ivehicleexitplayer)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleExitPlayer,
				Value = _ivehicleexitplayer
			};
		}

		// Token: 0x0602C8FC RID: 182524 RVA: 0x006187AB File Offset: 0x006169AB
		public IVehicleExitNpcT AsIVehicleExitNpc()
		{
			return this.As<IVehicleExitNpcT>();
		}

		// Token: 0x0602C8FD RID: 182525 RVA: 0x006187B3 File Offset: 0x006169B3
		public static IActionParams_Union_1Union FromIVehicleExitNpc(IVehicleExitNpcT _ivehicleexitnpc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleExitNpc,
				Value = _ivehicleexitnpc
			};
		}

		// Token: 0x0602C8FE RID: 182526 RVA: 0x006187C9 File Offset: 0x006169C9
		public ITeleportVehicleT AsITeleportVehicle()
		{
			return this.As<ITeleportVehicleT>();
		}

		// Token: 0x0602C8FF RID: 182527 RVA: 0x006187D1 File Offset: 0x006169D1
		public static IActionParams_Union_1Union FromITeleportVehicle(ITeleportVehicleT _iteleportvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportVehicle,
				Value = _iteleportvehicle
			};
		}

		// Token: 0x0602C900 RID: 182528 RVA: 0x006187E7 File Offset: 0x006169E7
		public IClientTeleportVehicleT AsIClientTeleportVehicle()
		{
			return this.As<IClientTeleportVehicleT>();
		}

		// Token: 0x0602C901 RID: 182529 RVA: 0x006187EF File Offset: 0x006169EF
		public static IActionParams_Union_1Union FromIClientTeleportVehicle(IClientTeleportVehicleT _iclientteleportvehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientTeleportVehicle,
				Value = _iclientteleportvehicle
			};
		}

		// Token: 0x0602C902 RID: 182530 RVA: 0x00618805 File Offset: 0x00616A05
		public IVehiclePlayPassengerVoiceT AsIVehiclePlayPassengerVoice()
		{
			return this.As<IVehiclePlayPassengerVoiceT>();
		}

		// Token: 0x0602C903 RID: 182531 RVA: 0x0061880D File Offset: 0x00616A0D
		public static IActionParams_Union_1Union FromIVehiclePlayPassengerVoice(IVehiclePlayPassengerVoiceT _ivehicleplaypassengervoice)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehiclePlayPassengerVoice,
				Value = _ivehicleplaypassengervoice
			};
		}

		// Token: 0x0602C904 RID: 182532 RVA: 0x00618823 File Offset: 0x00616A23
		public IVehicleWaterfallClimbingT AsIVehicleWaterfallClimbing()
		{
			return this.As<IVehicleWaterfallClimbingT>();
		}

		// Token: 0x0602C905 RID: 182533 RVA: 0x0061882B File Offset: 0x00616A2B
		public static IActionParams_Union_1Union FromIVehicleWaterfallClimbing(IVehicleWaterfallClimbingT _ivehiclewaterfallclimbing)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleWaterfallClimbing,
				Value = _ivehiclewaterfallclimbing
			};
		}

		// Token: 0x0602C906 RID: 182534 RVA: 0x00618841 File Offset: 0x00616A41
		public ITeleportToAndEnterVehicleT AsITeleportToAndEnterVehicle()
		{
			return this.As<ITeleportToAndEnterVehicleT>();
		}

		// Token: 0x0602C907 RID: 182535 RVA: 0x00618849 File Offset: 0x00616A49
		public static IActionParams_Union_1Union FromITeleportToAndEnterVehicle(ITeleportToAndEnterVehicleT _iteleporttoandentervehicle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITeleportToAndEnterVehicle,
				Value = _iteleporttoandentervehicle
			};
		}

		// Token: 0x0602C908 RID: 182536 RVA: 0x0061885F File Offset: 0x00616A5F
		public IVehicleMoveWithPathLineT AsIVehicleMoveWithPathLine()
		{
			return this.As<IVehicleMoveWithPathLineT>();
		}

		// Token: 0x0602C909 RID: 182537 RVA: 0x00618867 File Offset: 0x00616A67
		public static IActionParams_Union_1Union FromIVehicleMoveWithPathLine(IVehicleMoveWithPathLineT _ivehiclemovewithpathline)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleMoveWithPathLine,
				Value = _ivehiclemovewithpathline
			};
		}

		// Token: 0x0602C90A RID: 182538 RVA: 0x0061887D File Offset: 0x00616A7D
		public IVehicleSprintT AsIVehicleSprint()
		{
			return this.As<IVehicleSprintT>();
		}

		// Token: 0x0602C90B RID: 182539 RVA: 0x00618885 File Offset: 0x00616A85
		public static IActionParams_Union_1Union FromIVehicleSprint(IVehicleSprintT _ivehiclesprint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleSprint,
				Value = _ivehiclesprint
			};
		}

		// Token: 0x0602C90C RID: 182540 RVA: 0x0061889B File Offset: 0x00616A9B
		public IOpenQteActionT AsIOpenQteAction()
		{
			return this.As<IOpenQteActionT>();
		}

		// Token: 0x0602C90D RID: 182541 RVA: 0x006188A3 File Offset: 0x00616AA3
		public static IActionParams_Union_1Union FromIOpenQteAction(IOpenQteActionT _iopenqteaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenQteAction,
				Value = _iopenqteaction
			};
		}

		// Token: 0x0602C90E RID: 182542 RVA: 0x006188B9 File Offset: 0x00616AB9
		public IPlayerInputT AsIPlayerInput()
		{
			return this.As<IPlayerInputT>();
		}

		// Token: 0x0602C90F RID: 182543 RVA: 0x006188C1 File Offset: 0x00616AC1
		public static IActionParams_Union_1Union FromIPlayerInput(IPlayerInputT _iplayerinput)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayerInput,
				Value = _iplayerinput
			};
		}

		// Token: 0x0602C910 RID: 182544 RVA: 0x006188D7 File Offset: 0x00616AD7
		public IPreloadActionT AsIPreloadAction()
		{
			return this.As<IPreloadActionT>();
		}

		// Token: 0x0602C911 RID: 182545 RVA: 0x006188DF File Offset: 0x00616ADF
		public static IActionParams_Union_1Union FromIPreloadAction(IPreloadActionT _ipreloadaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPreloadAction,
				Value = _ipreloadaction
			};
		}

		// Token: 0x0602C912 RID: 182546 RVA: 0x006188F5 File Offset: 0x00616AF5
		public IRemovePreloadResourceActionT AsIRemovePreloadResourceAction()
		{
			return this.As<IRemovePreloadResourceActionT>();
		}

		// Token: 0x0602C913 RID: 182547 RVA: 0x006188FD File Offset: 0x00616AFD
		public static IActionParams_Union_1Union FromIRemovePreloadResourceAction(IRemovePreloadResourceActionT _iremovepreloadresourceaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemovePreloadResourceAction,
				Value = _iremovepreloadresourceaction
			};
		}

		// Token: 0x0602C914 RID: 182548 RVA: 0x00618913 File Offset: 0x00616B13
		public IExecAlertSystemActionT AsIExecAlertSystemAction()
		{
			return this.As<IExecAlertSystemActionT>();
		}

		// Token: 0x0602C915 RID: 182549 RVA: 0x0061891B File Offset: 0x00616B1B
		public static IActionParams_Union_1Union FromIExecAlertSystemAction(IExecAlertSystemActionT _iexecalertsystemaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecAlertSystemAction,
				Value = _iexecalertsystemaction
			};
		}

		// Token: 0x0602C916 RID: 182550 RVA: 0x00618931 File Offset: 0x00616B31
		public ISetSpineAnimationT AsISetSpineAnimation()
		{
			return this.As<ISetSpineAnimationT>();
		}

		// Token: 0x0602C917 RID: 182551 RVA: 0x00618939 File Offset: 0x00616B39
		public static IActionParams_Union_1Union FromISetSpineAnimation(ISetSpineAnimationT _isetspineanimation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSpineAnimation,
				Value = _isetspineanimation
			};
		}

		// Token: 0x0602C918 RID: 182552 RVA: 0x0061894F File Offset: 0x00616B4F
		public IChangeEntityCampT AsIChangeEntityCamp()
		{
			return this.As<IChangeEntityCampT>();
		}

		// Token: 0x0602C919 RID: 182553 RVA: 0x00618957 File Offset: 0x00616B57
		public static IActionParams_Union_1Union FromIChangeEntityCamp(IChangeEntityCampT _ichangeentitycamp)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeEntityCamp,
				Value = _ichangeentitycamp
			};
		}

		// Token: 0x0602C91A RID: 182554 RVA: 0x0061896D File Offset: 0x00616B6D
		public IRecordDungeonEventT AsIRecordDungeonEvent()
		{
			return this.As<IRecordDungeonEventT>();
		}

		// Token: 0x0602C91B RID: 182555 RVA: 0x00618975 File Offset: 0x00616B75
		public static IActionParams_Union_1Union FromIRecordDungeonEvent(IRecordDungeonEventT _irecorddungeonevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRecordDungeonEvent,
				Value = _irecorddungeonevent
			};
		}

		// Token: 0x0602C91C RID: 182556 RVA: 0x0061898B File Offset: 0x00616B8B
		public IDangoAbyssGotoNextFloorT AsIDangoAbyssGotoNextFloor()
		{
			return this.As<IDangoAbyssGotoNextFloorT>();
		}

		// Token: 0x0602C91D RID: 182557 RVA: 0x00618993 File Offset: 0x00616B93
		public static IActionParams_Union_1Union FromIDangoAbyssGotoNextFloor(IDangoAbyssGotoNextFloorT _idangoabyssgotonextfloor)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssGotoNextFloor,
				Value = _idangoabyssgotonextfloor
			};
		}

		// Token: 0x0602C91E RID: 182558 RVA: 0x006189A9 File Offset: 0x00616BA9
		public IDangoAbyssCreateRewardTreasureBoxT AsIDangoAbyssCreateRewardTreasureBox()
		{
			return this.As<IDangoAbyssCreateRewardTreasureBoxT>();
		}

		// Token: 0x0602C91F RID: 182559 RVA: 0x006189B1 File Offset: 0x00616BB1
		public static IActionParams_Union_1Union FromIDangoAbyssCreateRewardTreasureBox(IDangoAbyssCreateRewardTreasureBoxT _idangoabysscreaterewardtreasurebox)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssCreateRewardTreasureBox,
				Value = _idangoabysscreaterewardtreasurebox
			};
		}

		// Token: 0x0602C920 RID: 182560 RVA: 0x006189C7 File Offset: 0x00616BC7
		public IDangoAbyssActivatePortalT AsIDangoAbyssActivatePortal()
		{
			return this.As<IDangoAbyssActivatePortalT>();
		}

		// Token: 0x0602C921 RID: 182561 RVA: 0x006189CF File Offset: 0x00616BCF
		public static IActionParams_Union_1Union FromIDangoAbyssActivatePortal(IDangoAbyssActivatePortalT _idangoabyssactivateportal)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssActivatePortal,
				Value = _idangoabyssactivateportal
			};
		}

		// Token: 0x0602C922 RID: 182562 RVA: 0x006189E5 File Offset: 0x00616BE5
		public IDangoAbyssReceiveRewardT AsIDangoAbyssReceiveReward()
		{
			return this.As<IDangoAbyssReceiveRewardT>();
		}

		// Token: 0x0602C923 RID: 182563 RVA: 0x006189ED File Offset: 0x00616BED
		public static IActionParams_Union_1Union FromIDangoAbyssReceiveReward(IDangoAbyssReceiveRewardT _idangoabyssreceivereward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDangoAbyssReceiveReward,
				Value = _idangoabyssreceivereward
			};
		}

		// Token: 0x0602C924 RID: 182564 RVA: 0x00618A03 File Offset: 0x00616C03
		public IRoverRogueActivateT AsIRoverRogueActivate()
		{
			return this.As<IRoverRogueActivateT>();
		}

		// Token: 0x0602C925 RID: 182565 RVA: 0x00618A0B File Offset: 0x00616C0B
		public static IActionParams_Union_1Union FromIRoverRogueActivate(IRoverRogueActivateT _iroverrogueactivate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueActivate,
				Value = _iroverrogueactivate
			};
		}

		// Token: 0x0602C926 RID: 182566 RVA: 0x00618A21 File Offset: 0x00616C21
		public IRoverRogueRoomFinishT AsIRoverRogueRoomFinish()
		{
			return this.As<IRoverRogueRoomFinishT>();
		}

		// Token: 0x0602C927 RID: 182567 RVA: 0x00618A29 File Offset: 0x00616C29
		public static IActionParams_Union_1Union FromIRoverRogueRoomFinish(IRoverRogueRoomFinishT _iroverrogueroomfinish)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueRoomFinish,
				Value = _iroverrogueroomfinish
			};
		}

		// Token: 0x0602C928 RID: 182568 RVA: 0x00618A3F File Offset: 0x00616C3F
		public IRoverRogueCreateRoomRewardT AsIRoverRogueCreateRoomReward()
		{
			return this.As<IRoverRogueCreateRoomRewardT>();
		}

		// Token: 0x0602C929 RID: 182569 RVA: 0x00618A47 File Offset: 0x00616C47
		public static IActionParams_Union_1Union FromIRoverRogueCreateRoomReward(IRoverRogueCreateRoomRewardT _iroverroguecreateroomreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRoverRogueCreateRoomReward,
				Value = _iroverroguecreateroomreward
			};
		}

		// Token: 0x0602C92A RID: 182570 RVA: 0x00618A5D File Offset: 0x00616C5D
		public IGuestOperateUiAnimationT AsIGuestOperateUiAnimation()
		{
			return this.As<IGuestOperateUiAnimationT>();
		}

		// Token: 0x0602C92B RID: 182571 RVA: 0x00618A65 File Offset: 0x00616C65
		public static IActionParams_Union_1Union FromIGuestOperateUiAnimation(IGuestOperateUiAnimationT _iguestoperateuianimation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGuestOperateUiAnimation,
				Value = _iguestoperateuianimation
			};
		}

		// Token: 0x0602C92C RID: 182572 RVA: 0x00618A7B File Offset: 0x00616C7B
		public ISlideRailStartT AsISlideRailStart()
		{
			return this.As<ISlideRailStartT>();
		}

		// Token: 0x0602C92D RID: 182573 RVA: 0x00618A83 File Offset: 0x00616C83
		public static IActionParams_Union_1Union FromISlideRailStart(ISlideRailStartT _isliderailstart)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlideRailStart,
				Value = _isliderailstart
			};
		}

		// Token: 0x0602C92E RID: 182574 RVA: 0x00618A99 File Offset: 0x00616C99
		public ISlideRailEndT AsISlideRailEnd()
		{
			return this.As<ISlideRailEndT>();
		}

		// Token: 0x0602C92F RID: 182575 RVA: 0x00618AA1 File Offset: 0x00616CA1
		public static IActionParams_Union_1Union FromISlideRailEnd(ISlideRailEndT _isliderailend)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlideRailEnd,
				Value = _isliderailend
			};
		}

		// Token: 0x0602C930 RID: 182576 RVA: 0x00618AB7 File Offset: 0x00616CB7
		public ISlidePerformStartT AsISlidePerformStart()
		{
			return this.As<ISlidePerformStartT>();
		}

		// Token: 0x0602C931 RID: 182577 RVA: 0x00618ABF File Offset: 0x00616CBF
		public static IActionParams_Union_1Union FromISlidePerformStart(ISlidePerformStartT _islideperformstart)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISlidePerformStart,
				Value = _islideperformstart
			};
		}

		// Token: 0x0602C932 RID: 182578 RVA: 0x00618AD5 File Offset: 0x00616CD5
		public IBvbSendSystemEventT AsIBvbSendSystemEvent()
		{
			return this.As<IBvbSendSystemEventT>();
		}

		// Token: 0x0602C933 RID: 182579 RVA: 0x00618ADD File Offset: 0x00616CDD
		public static IActionParams_Union_1Union FromIBvbSendSystemEvent(IBvbSendSystemEventT _ibvbsendsystemevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSendSystemEvent,
				Value = _ibvbsendsystemevent
			};
		}

		// Token: 0x0602C934 RID: 182580 RVA: 0x00618AF3 File Offset: 0x00616CF3
		public IBvbSendAiEventT AsIBvbSendAiEvent()
		{
			return this.As<IBvbSendAiEventT>();
		}

		// Token: 0x0602C935 RID: 182581 RVA: 0x00618AFB File Offset: 0x00616CFB
		public static IActionParams_Union_1Union FromIBvbSendAiEvent(IBvbSendAiEventT _ibvbsendaievent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSendAiEvent,
				Value = _ibvbsendaievent
			};
		}

		// Token: 0x0602C936 RID: 182582 RVA: 0x00618B11 File Offset: 0x00616D11
		public IBvbPlayDialogT AsIBvbPlayDialog()
		{
			return this.As<IBvbPlayDialogT>();
		}

		// Token: 0x0602C937 RID: 182583 RVA: 0x00618B19 File Offset: 0x00616D19
		public static IActionParams_Union_1Union FromIBvbPlayDialog(IBvbPlayDialogT _ibvbplaydialog)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbPlayDialog,
				Value = _ibvbplaydialog
			};
		}

		// Token: 0x0602C938 RID: 182584 RVA: 0x00618B2F File Offset: 0x00616D2F
		public IBvbPlayerOperationConstraintT AsIBvbPlayerOperationConstraint()
		{
			return this.As<IBvbPlayerOperationConstraintT>();
		}

		// Token: 0x0602C939 RID: 182585 RVA: 0x00618B37 File Offset: 0x00616D37
		public static IActionParams_Union_1Union FromIBvbPlayerOperationConstraint(IBvbPlayerOperationConstraintT _ibvbplayeroperationconstraint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbPlayerOperationConstraint,
				Value = _ibvbplayeroperationconstraint
			};
		}

		// Token: 0x0602C93A RID: 182586 RVA: 0x00618B4D File Offset: 0x00616D4D
		public IBvbSkipChallengeT AsIBvbSkipChallenge()
		{
			return this.As<IBvbSkipChallengeT>();
		}

		// Token: 0x0602C93B RID: 182587 RVA: 0x00618B55 File Offset: 0x00616D55
		public static IActionParams_Union_1Union FromIBvbSkipChallenge(IBvbSkipChallengeT _ibvbskipchallenge)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBvbSkipChallenge,
				Value = _ibvbskipchallenge
			};
		}

		// Token: 0x0602C93C RID: 182588 RVA: 0x00618B6B File Offset: 0x00616D6B
		public IActiveAntiGravitySafePointT AsIActiveAntiGravitySafePoint()
		{
			return this.As<IActiveAntiGravitySafePointT>();
		}

		// Token: 0x0602C93D RID: 182589 RVA: 0x00618B73 File Offset: 0x00616D73
		public static IActionParams_Union_1Union FromIActiveAntiGravitySafePoint(IActiveAntiGravitySafePointT _iactiveantigravitysafepoint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IActiveAntiGravitySafePoint,
				Value = _iactiveantigravitysafepoint
			};
		}

		// Token: 0x0602C93E RID: 182590 RVA: 0x00618B89 File Offset: 0x00616D89
		public ISummonEntityT AsISummonEntity()
		{
			return this.As<ISummonEntityT>();
		}

		// Token: 0x0602C93F RID: 182591 RVA: 0x00618B91 File Offset: 0x00616D91
		public static IActionParams_Union_1Union FromISummonEntity(ISummonEntityT _isummonentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISummonEntity,
				Value = _isummonentity
			};
		}

		// Token: 0x0602C940 RID: 182592 RVA: 0x00618BA7 File Offset: 0x00616DA7
		public IDestroySummonedEntitiesT AsIDestroySummonedEntities()
		{
			return this.As<IDestroySummonedEntitiesT>();
		}

		// Token: 0x0602C941 RID: 182593 RVA: 0x00618BAF File Offset: 0x00616DAF
		public static IActionParams_Union_1Union FromIDestroySummonedEntities(IDestroySummonedEntitiesT _idestroysummonedentities)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDestroySummonedEntities,
				Value = _idestroysummonedentities
			};
		}

		// Token: 0x0602C942 RID: 182594 RVA: 0x00618BC5 File Offset: 0x00616DC5
		public ISetupMoraleSystemT AsISetupMoraleSystem()
		{
			return this.As<ISetupMoraleSystemT>();
		}

		// Token: 0x0602C943 RID: 182595 RVA: 0x00618BCD File Offset: 0x00616DCD
		public static IActionParams_Union_1Union FromISetupMoraleSystem(ISetupMoraleSystemT _isetupmoralesystem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetupMoraleSystem,
				Value = _isetupmoralesystem
			};
		}

		// Token: 0x0602C944 RID: 182596 RVA: 0x00618BE3 File Offset: 0x00616DE3
		public IGiantToggleModelT AsIGiantToggleModel()
		{
			return this.As<IGiantToggleModelT>();
		}

		// Token: 0x0602C945 RID: 182597 RVA: 0x00618BEB File Offset: 0x00616DEB
		public static IActionParams_Union_1Union FromIGiantToggleModel(IGiantToggleModelT _igianttogglemodel)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGiantToggleModel,
				Value = _igianttogglemodel
			};
		}

		// Token: 0x0602C946 RID: 182598 RVA: 0x00618C01 File Offset: 0x00616E01
		public IGiantTriggerResponseT AsIGiantTriggerResponse()
		{
			return this.As<IGiantTriggerResponseT>();
		}

		// Token: 0x0602C947 RID: 182599 RVA: 0x00618C09 File Offset: 0x00616E09
		public static IActionParams_Union_1Union FromIGiantTriggerResponse(IGiantTriggerResponseT _igianttriggerresponse)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IGiantTriggerResponse,
				Value = _igianttriggerresponse
			};
		}

		// Token: 0x0602C948 RID: 182600 RVA: 0x00618C1F File Offset: 0x00616E1F
		public IActivateGiantTotalProgressNodeT AsIActivateGiantTotalProgressNode()
		{
			return this.As<IActivateGiantTotalProgressNodeT>();
		}

		// Token: 0x0602C949 RID: 182601 RVA: 0x00618C27 File Offset: 0x00616E27
		public static IActionParams_Union_1Union FromIActivateGiantTotalProgressNode(IActivateGiantTotalProgressNodeT _iactivategianttotalprogressnode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IActivateGiantTotalProgressNode,
				Value = _iactivategianttotalprogressnode
			};
		}

		// Token: 0x0602C94A RID: 182602 RVA: 0x00618C3D File Offset: 0x00616E3D
		public IRunActorCustomEventT AsIRunActorCustomEvent()
		{
			return this.As<IRunActorCustomEventT>();
		}

		// Token: 0x0602C94B RID: 182603 RVA: 0x00618C45 File Offset: 0x00616E45
		public static IActionParams_Union_1Union FromIRunActorCustomEvent(IRunActorCustomEventT _irunactorcustomevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRunActorCustomEvent,
				Value = _irunactorcustomevent
			};
		}

		// Token: 0x0602C94C RID: 182604 RVA: 0x00618C5B File Offset: 0x00616E5B
		public ITriggerSpecificScanEffectT AsITriggerSpecificScanEffect()
		{
			return this.As<ITriggerSpecificScanEffectT>();
		}

		// Token: 0x0602C94D RID: 182605 RVA: 0x00618C63 File Offset: 0x00616E63
		public static IActionParams_Union_1Union FromITriggerSpecificScanEffect(ITriggerSpecificScanEffectT _itriggerspecificscaneffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerSpecificScanEffect,
				Value = _itriggerspecificscaneffect
			};
		}

		// Token: 0x0602C94E RID: 182606 RVA: 0x00618C79 File Offset: 0x00616E79
		public ISendClientEventT AsISendClientEvent()
		{
			return this.As<ISendClientEventT>();
		}

		// Token: 0x0602C94F RID: 182607 RVA: 0x00618C81 File Offset: 0x00616E81
		public static IActionParams_Union_1Union FromISendClientEvent(ISendClientEventT _isendclientevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISendClientEvent,
				Value = _isendclientevent
			};
		}

		// Token: 0x0602C950 RID: 182608 RVA: 0x00618C97 File Offset: 0x00616E97
		public IScanEnrichmentAreaT AsIScanEnrichmentArea()
		{
			return this.As<IScanEnrichmentAreaT>();
		}

		// Token: 0x0602C951 RID: 182609 RVA: 0x00618C9F File Offset: 0x00616E9F
		public static IActionParams_Union_1Union FromIScanEnrichmentArea(IScanEnrichmentAreaT _iscanenrichmentarea)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IScanEnrichmentArea,
				Value = _iscanenrichmentarea
			};
		}

		// Token: 0x0602C952 RID: 182610 RVA: 0x00618CB5 File Offset: 0x00616EB5
		public IRequestSystemFunctionT AsIRequestSystemFunction()
		{
			return this.As<IRequestSystemFunctionT>();
		}

		// Token: 0x0602C953 RID: 182611 RVA: 0x00618CBD File Offset: 0x00616EBD
		public static IActionParams_Union_1Union FromIRequestSystemFunction(IRequestSystemFunctionT _irequestsystemfunction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRequestSystemFunction,
				Value = _irequestsystemfunction
			};
		}

		// Token: 0x0602C954 RID: 182612 RVA: 0x00618CD3 File Offset: 0x00616ED3
		public IReignsSetPropertyVisibleT AsIReignsSetPropertyVisible()
		{
			return this.As<IReignsSetPropertyVisibleT>();
		}

		// Token: 0x0602C955 RID: 182613 RVA: 0x00618CDB File Offset: 0x00616EDB
		public static IActionParams_Union_1Union FromIReignsSetPropertyVisible(IReignsSetPropertyVisibleT _ireignssetpropertyvisible)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsSetPropertyVisible,
				Value = _ireignssetpropertyvisible
			};
		}

		// Token: 0x0602C956 RID: 182614 RVA: 0x00618CF1 File Offset: 0x00616EF1
		public IReignsChangeBackgroundT AsIReignsChangeBackground()
		{
			return this.As<IReignsChangeBackgroundT>();
		}

		// Token: 0x0602C957 RID: 182615 RVA: 0x00618CF9 File Offset: 0x00616EF9
		public static IActionParams_Union_1Union FromIReignsChangeBackground(IReignsChangeBackgroundT _ireignschangebackground)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsChangeBackground,
				Value = _ireignschangebackground
			};
		}

		// Token: 0x0602C958 RID: 182616 RVA: 0x00618D0F File Offset: 0x00616F0F
		public IReignsSetUiEffectT AsIReignsSetUiEffect()
		{
			return this.As<IReignsSetUiEffectT>();
		}

		// Token: 0x0602C959 RID: 182617 RVA: 0x00618D17 File Offset: 0x00616F17
		public static IActionParams_Union_1Union FromIReignsSetUiEffect(IReignsSetUiEffectT _ireignssetuieffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsSetUiEffect,
				Value = _ireignssetuieffect
			};
		}

		// Token: 0x0602C95A RID: 182618 RVA: 0x00618D2D File Offset: 0x00616F2D
		public IReignsChangePlayerNameT AsIReignsChangePlayerName()
		{
			return this.As<IReignsChangePlayerNameT>();
		}

		// Token: 0x0602C95B RID: 182619 RVA: 0x00618D35 File Offset: 0x00616F35
		public static IActionParams_Union_1Union FromIReignsChangePlayerName(IReignsChangePlayerNameT _ireignschangeplayername)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsChangePlayerName,
				Value = _ireignschangeplayername
			};
		}

		// Token: 0x0602C95C RID: 182620 RVA: 0x00618D4E File Offset: 0x00616F4E
		public IReignsCallCardT AsIReignsCallCard()
		{
			return this.As<IReignsCallCardT>();
		}

		// Token: 0x0602C95D RID: 182621 RVA: 0x00618D56 File Offset: 0x00616F56
		public static IActionParams_Union_1Union FromIReignsCallCard(IReignsCallCardT _ireignscallcard)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsCallCard,
				Value = _ireignscallcard
			};
		}

		// Token: 0x0602C95E RID: 182622 RVA: 0x00618D6F File Offset: 0x00616F6F
		public IReignsTriggerGuideT AsIReignsTriggerGuide()
		{
			return this.As<IReignsTriggerGuideT>();
		}

		// Token: 0x0602C95F RID: 182623 RVA: 0x00618D77 File Offset: 0x00616F77
		public static IActionParams_Union_1Union FromIReignsTriggerGuide(IReignsTriggerGuideT _ireignstriggerguide)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsTriggerGuide,
				Value = _ireignstriggerguide
			};
		}

		// Token: 0x0602C960 RID: 182624 RVA: 0x00618D90 File Offset: 0x00616F90
		public IReignsAddBuffT AsIReignsAddBuff()
		{
			return this.As<IReignsAddBuffT>();
		}

		// Token: 0x0602C961 RID: 182625 RVA: 0x00618D98 File Offset: 0x00616F98
		public static IActionParams_Union_1Union FromIReignsAddBuff(IReignsAddBuffT _ireignsaddbuff)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsAddBuff,
				Value = _ireignsaddbuff
			};
		}

		// Token: 0x0602C962 RID: 182626 RVA: 0x00618DB1 File Offset: 0x00616FB1
		public IReignsCheckSettleT AsIReignsCheckSettle()
		{
			return this.As<IReignsCheckSettleT>();
		}

		// Token: 0x0602C963 RID: 182627 RVA: 0x00618DB9 File Offset: 0x00616FB9
		public static IActionParams_Union_1Union FromIReignsCheckSettle(IReignsCheckSettleT _ireignschecksettle)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReignsCheckSettle,
				Value = _ireignschecksettle
			};
		}

		// Token: 0x0602C964 RID: 182628 RVA: 0x00618DD2 File Offset: 0x00616FD2
		public ISetNpcGroupPerformT AsISetNpcGroupPerform()
		{
			return this.As<ISetNpcGroupPerformT>();
		}

		// Token: 0x0602C965 RID: 182629 RVA: 0x00618DDA File Offset: 0x00616FDA
		public static IActionParams_Union_1Union FromISetNpcGroupPerform(ISetNpcGroupPerformT _isetnpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetNpcGroupPerform,
				Value = _isetnpcgroupperform
			};
		}

		// Token: 0x0602C966 RID: 182630 RVA: 0x00618DF3 File Offset: 0x00616FF3
		public IRemoveNpcGroupPerformT AsIRemoveNpcGroupPerform()
		{
			return this.As<IRemoveNpcGroupPerformT>();
		}

		// Token: 0x0602C967 RID: 182631 RVA: 0x00618DFB File Offset: 0x00616FFB
		public static IActionParams_Union_1Union FromIRemoveNpcGroupPerform(IRemoveNpcGroupPerformT _iremovenpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRemoveNpcGroupPerform,
				Value = _iremovenpcgroupperform
			};
		}

		// Token: 0x0602C968 RID: 182632 RVA: 0x00618E14 File Offset: 0x00617014
		public IEnableEntityLookAtT AsIEnableEntityLookAt()
		{
			return this.As<IEnableEntityLookAtT>();
		}

		// Token: 0x0602C969 RID: 182633 RVA: 0x00618E1C File Offset: 0x0061701C
		public static IActionParams_Union_1Union FromIEnableEntityLookAt(IEnableEntityLookAtT _ienableentitylookat)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableEntityLookAt,
				Value = _ienableentitylookat
			};
		}

		// Token: 0x0602C96A RID: 182634 RVA: 0x00618E35 File Offset: 0x00617035
		public IDisableEntityLookAtT AsIDisableEntityLookAt()
		{
			return this.As<IDisableEntityLookAtT>();
		}

		// Token: 0x0602C96B RID: 182635 RVA: 0x00618E3D File Offset: 0x0061703D
		public static IActionParams_Union_1Union FromIDisableEntityLookAt(IDisableEntityLookAtT _idisableentitylookat)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDisableEntityLookAt,
				Value = _idisableentitylookat
			};
		}

		// Token: 0x0602C96C RID: 182636 RVA: 0x00618E56 File Offset: 0x00617056
		public IOverrideAiBehaviorTreeT AsIOverrideAiBehaviorTree()
		{
			return this.As<IOverrideAiBehaviorTreeT>();
		}

		// Token: 0x0602C96D RID: 182637 RVA: 0x00618E5E File Offset: 0x0061705E
		public static IActionParams_Union_1Union FromIOverrideAiBehaviorTree(IOverrideAiBehaviorTreeT _ioverrideaibehaviortree)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOverrideAiBehaviorTree,
				Value = _ioverrideaibehaviortree
			};
		}

		// Token: 0x0602C96E RID: 182638 RVA: 0x00618E77 File Offset: 0x00617077
		public IRestoreAiBehaviorTreeT AsIRestoreAiBehaviorTree()
		{
			return this.As<IRestoreAiBehaviorTreeT>();
		}

		// Token: 0x0602C96F RID: 182639 RVA: 0x00618E7F File Offset: 0x0061707F
		public static IActionParams_Union_1Union FromIRestoreAiBehaviorTree(IRestoreAiBehaviorTreeT _irestoreaibehaviortree)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRestoreAiBehaviorTree,
				Value = _irestoreaibehaviortree
			};
		}

		// Token: 0x0602C970 RID: 182640 RVA: 0x00618E98 File Offset: 0x00617098
		public IFlowDefineNpcGroupPerformT AsIFlowDefineNpcGroupPerform()
		{
			return this.As<IFlowDefineNpcGroupPerformT>();
		}

		// Token: 0x0602C971 RID: 182641 RVA: 0x00618EA0 File Offset: 0x006170A0
		public static IActionParams_Union_1Union FromIFlowDefineNpcGroupPerform(IFlowDefineNpcGroupPerformT _iflowdefinenpcgroupperform)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IFlowDefineNpcGroupPerform,
				Value = _iflowdefinenpcgroupperform
			};
		}

		// Token: 0x0602C972 RID: 182642 RVA: 0x00618EB9 File Offset: 0x006170B9
		public ISeqEventAddTagToSelfT AsISeqEventAddTagToSelf()
		{
			return this.As<ISeqEventAddTagToSelfT>();
		}

		// Token: 0x0602C973 RID: 182643 RVA: 0x00618EC1 File Offset: 0x006170C1
		public static IActionParams_Union_1Union FromISeqEventAddTagToSelf(ISeqEventAddTagToSelfT _iseqeventaddtagtoself)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeqEventAddTagToSelf,
				Value = _iseqeventaddtagtoself
			};
		}

		// Token: 0x0602C974 RID: 182644 RVA: 0x00618EDA File Offset: 0x006170DA
		public ISeqEventFireBulletT AsISeqEventFireBullet()
		{
			return this.As<ISeqEventFireBulletT>();
		}

		// Token: 0x0602C975 RID: 182645 RVA: 0x00618EE2 File Offset: 0x006170E2
		public static IActionParams_Union_1Union FromISeqEventFireBullet(ISeqEventFireBulletT _iseqeventfirebullet)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeqEventFireBullet,
				Value = _iseqeventfirebullet
			};
		}

		// Token: 0x0602C976 RID: 182646 RVA: 0x00618EFB File Offset: 0x006170FB
		public ITrapDefenseChangeMiniMapT AsITrapDefenseChangeMiniMap()
		{
			return this.As<ITrapDefenseChangeMiniMapT>();
		}

		// Token: 0x0602C977 RID: 182647 RVA: 0x00618F03 File Offset: 0x00617103
		public static IActionParams_Union_1Union FromITrapDefenseChangeMiniMap(ITrapDefenseChangeMiniMapT _itrapdefensechangeminimap)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITrapDefenseChangeMiniMap,
				Value = _itrapdefensechangeminimap
			};
		}

		// Token: 0x0602C978 RID: 182648 RVA: 0x00618F1C File Offset: 0x0061711C
		public ITrapDefensePlayerOperationConstraintT AsITrapDefensePlayerOperationConstraint()
		{
			return this.As<ITrapDefensePlayerOperationConstraintT>();
		}

		// Token: 0x0602C979 RID: 182649 RVA: 0x00618F24 File Offset: 0x00617124
		public static IActionParams_Union_1Union FromITrapDefensePlayerOperationConstraint(ITrapDefensePlayerOperationConstraintT _itrapdefenseplayeroperationconstraint)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITrapDefensePlayerOperationConstraint,
				Value = _itrapdefenseplayeroperationconstraint
			};
		}

		// Token: 0x0602C97A RID: 182650 RVA: 0x00618F3D File Offset: 0x0061713D
		public IHonamiStoryInteractPickUpT AsIHonamiStoryInteractPickUp()
		{
			return this.As<IHonamiStoryInteractPickUpT>();
		}

		// Token: 0x0602C97B RID: 182651 RVA: 0x00618F45 File Offset: 0x00617145
		public static IActionParams_Union_1Union FromIHonamiStoryInteractPickUp(IHonamiStoryInteractPickUpT _ihonamistoryinteractpickup)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryInteractPickUp,
				Value = _ihonamistoryinteractpickup
			};
		}

		// Token: 0x0602C97C RID: 182652 RVA: 0x00618F5E File Offset: 0x0061715E
		public IHonamiStoryReceiveCorruptedChestRewardT AsIHonamiStoryReceiveCorruptedChestReward()
		{
			return this.As<IHonamiStoryReceiveCorruptedChestRewardT>();
		}

		// Token: 0x0602C97D RID: 182653 RVA: 0x00618F66 File Offset: 0x00617166
		public static IActionParams_Union_1Union FromIHonamiStoryReceiveCorruptedChestReward(IHonamiStoryReceiveCorruptedChestRewardT _ihonamistoryreceivecorruptedchestreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryReceiveCorruptedChestReward,
				Value = _ihonamistoryreceivecorruptedchestreward
			};
		}

		// Token: 0x0602C97E RID: 182654 RVA: 0x00618F7F File Offset: 0x0061717F
		public IHonamiStoryActivateSafeEvacuationT AsIHonamiStoryActivateSafeEvacuation()
		{
			return this.As<IHonamiStoryActivateSafeEvacuationT>();
		}

		// Token: 0x0602C97F RID: 182655 RVA: 0x00618F87 File Offset: 0x00617187
		public static IActionParams_Union_1Union FromIHonamiStoryActivateSafeEvacuation(IHonamiStoryActivateSafeEvacuationT _ihonamistoryactivatesafeevacuation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryActivateSafeEvacuation,
				Value = _ihonamistoryactivatesafeevacuation
			};
		}

		// Token: 0x0602C980 RID: 182656 RVA: 0x00618FA0 File Offset: 0x006171A0
		public IHonamiStorySetFormationT AsIHonamiStorySetFormation()
		{
			return this.As<IHonamiStorySetFormationT>();
		}

		// Token: 0x0602C981 RID: 182657 RVA: 0x00618FA8 File Offset: 0x006171A8
		public static IActionParams_Union_1Union FromIHonamiStorySetFormation(IHonamiStorySetFormationT _ihonamistorysetformation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStorySetFormation,
				Value = _ihonamistorysetformation
			};
		}

		// Token: 0x0602C982 RID: 182658 RVA: 0x00618FC1 File Offset: 0x006171C1
		public IHonamiStoryGetItemT AsIHonamiStoryGetItem()
		{
			return this.As<IHonamiStoryGetItemT>();
		}

		// Token: 0x0602C983 RID: 182659 RVA: 0x00618FC9 File Offset: 0x006171C9
		public static IActionParams_Union_1Union FromIHonamiStoryGetItem(IHonamiStoryGetItemT _ihonamistorygetitem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHonamiStoryGetItem,
				Value = _ihonamistorygetitem
			};
		}

		// Token: 0x0602C984 RID: 182660 RVA: 0x00618FE2 File Offset: 0x006171E2
		public IInfrActivityUpgradeInfrastructureT AsIInfrActivityUpgradeInfrastructure()
		{
			return this.As<IInfrActivityUpgradeInfrastructureT>();
		}

		// Token: 0x0602C985 RID: 182661 RVA: 0x00618FEA File Offset: 0x006171EA
		public static IActionParams_Union_1Union FromIInfrActivityUpgradeInfrastructure(IInfrActivityUpgradeInfrastructureT _iinfractivityupgradeinfrastructure)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IInfrActivityUpgradeInfrastructure,
				Value = _iinfractivityupgradeinfrastructure
			};
		}

		// Token: 0x0602C986 RID: 182662 RVA: 0x00619003 File Offset: 0x00617203
		public IPlayWalkingOverlayMontageT AsIPlayWalkingOverlayMontage()
		{
			return this.As<IPlayWalkingOverlayMontageT>();
		}

		// Token: 0x0602C987 RID: 182663 RVA: 0x0061900B File Offset: 0x0061720B
		public static IActionParams_Union_1Union FromIPlayWalkingOverlayMontage(IPlayWalkingOverlayMontageT _iplaywalkingoverlaymontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPlayWalkingOverlayMontage,
				Value = _iplaywalkingoverlaymontage
			};
		}

		// Token: 0x0602C988 RID: 182664 RVA: 0x00619024 File Offset: 0x00617224
		public IEnableKey4FuncT AsIEnableKey4Func()
		{
			return this.As<IEnableKey4FuncT>();
		}

		// Token: 0x0602C989 RID: 182665 RVA: 0x0061902C File Offset: 0x0061722C
		public static IActionParams_Union_1Union FromIEnableKey4Func(IEnableKey4FuncT _ienablekey4func)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnableKey4Func,
				Value = _ienablekey4func
			};
		}

		// Token: 0x0602C98A RID: 182666 RVA: 0x00619045 File Offset: 0x00617245
		public IChangeNpcAbpStateT AsIChangeNpcAbpState()
		{
			return this.As<IChangeNpcAbpStateT>();
		}

		// Token: 0x0602C98B RID: 182667 RVA: 0x0061904D File Offset: 0x0061724D
		public static IActionParams_Union_1Union FromIChangeNpcAbpState(IChangeNpcAbpStateT _ichangenpcabpstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeNpcAbpState,
				Value = _ichangenpcabpstate
			};
		}

		// Token: 0x0602C98C RID: 182668 RVA: 0x00619066 File Offset: 0x00617266
		public IOverrideAbpAnimSchemeT AsIOverrideAbpAnimScheme()
		{
			return this.As<IOverrideAbpAnimSchemeT>();
		}

		// Token: 0x0602C98D RID: 182669 RVA: 0x0061906E File Offset: 0x0061726E
		public static IActionParams_Union_1Union FromIOverrideAbpAnimScheme(IOverrideAbpAnimSchemeT _ioverrideabpanimscheme)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOverrideAbpAnimScheme,
				Value = _ioverrideabpanimscheme
			};
		}

		// Token: 0x0602C98E RID: 182670 RVA: 0x00619087 File Offset: 0x00617287
		public ICloseWalkingOverlayMontageT AsICloseWalkingOverlayMontage()
		{
			return this.As<ICloseWalkingOverlayMontageT>();
		}

		// Token: 0x0602C98F RID: 182671 RVA: 0x0061908F File Offset: 0x0061728F
		public static IActionParams_Union_1Union FromICloseWalkingOverlayMontage(ICloseWalkingOverlayMontageT _iclosewalkingoverlaymontage)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICloseWalkingOverlayMontage,
				Value = _iclosewalkingoverlaymontage
			};
		}

		// Token: 0x0602C990 RID: 182672 RVA: 0x006190A8 File Offset: 0x006172A8
		public ISetMotorSpeedT AsISetMotorSpeed()
		{
			return this.As<ISetMotorSpeedT>();
		}

		// Token: 0x0602C991 RID: 182673 RVA: 0x006190B0 File Offset: 0x006172B0
		public static IActionParams_Union_1Union FromISetMotorSpeed(ISetMotorSpeedT _isetmotorspeed)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetMotorSpeed,
				Value = _isetmotorspeed
			};
		}

		// Token: 0x0602C992 RID: 182674 RVA: 0x006190C9 File Offset: 0x006172C9
		public IVehicleSetSpeedImmediatelyT AsIVehicleSetSpeedImmediately()
		{
			return this.As<IVehicleSetSpeedImmediatelyT>();
		}

		// Token: 0x0602C993 RID: 182675 RVA: 0x006190D1 File Offset: 0x006172D1
		public static IActionParams_Union_1Union FromIVehicleSetSpeedImmediately(IVehicleSetSpeedImmediatelyT _ivehiclesetspeedimmediately)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IVehicleSetSpeedImmediately,
				Value = _ivehiclesetspeedimmediately
			};
		}

		// Token: 0x0602C994 RID: 182676 RVA: 0x006190EA File Offset: 0x006172EA
		public IStartMotorCruiseT AsIStartMotorCruise()
		{
			return this.As<IStartMotorCruiseT>();
		}

		// Token: 0x0602C995 RID: 182677 RVA: 0x006190F2 File Offset: 0x006172F2
		public static IActionParams_Union_1Union FromIStartMotorCruise(IStartMotorCruiseT _istartmotorcruise)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStartMotorCruise,
				Value = _istartmotorcruise
			};
		}

		// Token: 0x0602C996 RID: 182678 RVA: 0x0061910B File Offset: 0x0061730B
		public IStopMotorCruiseT AsIStopMotorCruise()
		{
			return this.As<IStopMotorCruiseT>();
		}

		// Token: 0x0602C997 RID: 182679 RVA: 0x00619113 File Offset: 0x00617313
		public static IActionParams_Union_1Union FromIStopMotorCruise(IStopMotorCruiseT _istopmotorcruise)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStopMotorCruise,
				Value = _istopmotorcruise
			};
		}

		// Token: 0x0602C998 RID: 182680 RVA: 0x0061912C File Offset: 0x0061732C
		public IDriveMotorInSpecConfigT AsIDriveMotorInSpecConfig()
		{
			return this.As<IDriveMotorInSpecConfigT>();
		}

		// Token: 0x0602C999 RID: 182681 RVA: 0x00619134 File Offset: 0x00617334
		public static IActionParams_Union_1Union FromIDriveMotorInSpecConfig(IDriveMotorInSpecConfigT _idrivemotorinspecconfig)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDriveMotorInSpecConfig,
				Value = _idrivemotorinspecconfig
			};
		}

		// Token: 0x0602C99A RID: 182682 RVA: 0x0061914D File Offset: 0x0061734D
		public IMotorSoarInWindFieldT AsIMotorSoarInWindField()
		{
			return this.As<IMotorSoarInWindFieldT>();
		}

		// Token: 0x0602C99B RID: 182683 RVA: 0x00619155 File Offset: 0x00617355
		public static IActionParams_Union_1Union FromIMotorSoarInWindField(IMotorSoarInWindFieldT _imotorsoarinwindfield)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IMotorSoarInWindField,
				Value = _imotorsoarinwindfield
			};
		}

		// Token: 0x0602C99C RID: 182684 RVA: 0x0061916E File Offset: 0x0061736E
		public ISetSkillBtnEffectT AsISetSkillBtnEffect()
		{
			return this.As<ISetSkillBtnEffectT>();
		}

		// Token: 0x0602C99D RID: 182685 RVA: 0x00619176 File Offset: 0x00617376
		public static IActionParams_Union_1Union FromISetSkillBtnEffect(ISetSkillBtnEffectT _isetskillbtneffect)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetSkillBtnEffect,
				Value = _isetskillbtneffect
			};
		}

		// Token: 0x0602C99E RID: 182686 RVA: 0x0061918F File Offset: 0x0061738F
		public ICollectSunSpiritT AsICollectSunSpirit()
		{
			return this.As<ICollectSunSpiritT>();
		}

		// Token: 0x0602C99F RID: 182687 RVA: 0x00619197 File Offset: 0x00617397
		public static IActionParams_Union_1Union FromICollectSunSpirit(ICollectSunSpiritT _icollectsunspirit)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICollectSunSpirit,
				Value = _icollectsunspirit
			};
		}

		// Token: 0x0602C9A0 RID: 182688 RVA: 0x006191B0 File Offset: 0x006173B0
		public IPerformSunSpiritGearRoundTripT AsIPerformSunSpiritGearRoundTrip()
		{
			return this.As<IPerformSunSpiritGearRoundTripT>();
		}

		// Token: 0x0602C9A1 RID: 182689 RVA: 0x006191B8 File Offset: 0x006173B8
		public static IActionParams_Union_1Union FromIPerformSunSpiritGearRoundTrip(IPerformSunSpiritGearRoundTripT _iperformsunspiritgearroundtrip)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformSunSpiritGearRoundTrip,
				Value = _iperformsunspiritgearroundtrip
			};
		}

		// Token: 0x0602C9A2 RID: 182690 RVA: 0x006191D1 File Offset: 0x006173D1
		public ITriggerDeadeyeModeT AsITriggerDeadeyeMode()
		{
			return this.As<ITriggerDeadeyeModeT>();
		}

		// Token: 0x0602C9A3 RID: 182691 RVA: 0x006191D9 File Offset: 0x006173D9
		public static IActionParams_Union_1Union FromITriggerDeadeyeMode(ITriggerDeadeyeModeT _itriggerdeadeyemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerDeadeyeMode,
				Value = _itriggerdeadeyemode
			};
		}

		// Token: 0x0602C9A4 RID: 182692 RVA: 0x006191F2 File Offset: 0x006173F2
		public ITriggerSystemRandomPlotT AsITriggerSystemRandomPlot()
		{
			return this.As<ITriggerSystemRandomPlotT>();
		}

		// Token: 0x0602C9A5 RID: 182693 RVA: 0x006191FA File Offset: 0x006173FA
		public static IActionParams_Union_1Union FromITriggerSystemRandomPlot(ITriggerSystemRandomPlotT _itriggersystemrandomplot)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITriggerSystemRandomPlot,
				Value = _itriggersystemrandomplot
			};
		}

		// Token: 0x0602C9A6 RID: 182694 RVA: 0x00619213 File Offset: 0x00617413
		public ISetAudioEnableT AsISetAudioEnable()
		{
			return this.As<ISetAudioEnableT>();
		}

		// Token: 0x0602C9A7 RID: 182695 RVA: 0x0061921B File Offset: 0x0061741B
		public static IActionParams_Union_1Union FromISetAudioEnable(ISetAudioEnableT _isetaudioenable)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetAudioEnable,
				Value = _isetaudioenable
			};
		}

		// Token: 0x0602C9A8 RID: 182696 RVA: 0x00619234 File Offset: 0x00617434
		public IPhoneSystemInteractT AsIPhoneSystemInteract()
		{
			return this.As<IPhoneSystemInteractT>();
		}

		// Token: 0x0602C9A9 RID: 182697 RVA: 0x0061923C File Offset: 0x0061743C
		public static IActionParams_Union_1Union FromIPhoneSystemInteract(IPhoneSystemInteractT _iphonesysteminteract)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPhoneSystemInteract,
				Value = _iphonesysteminteract
			};
		}

		// Token: 0x0602C9AA RID: 182698 RVA: 0x00619255 File Offset: 0x00617455
		public IRollBlockGetRewardT AsIRollBlockGetReward()
		{
			return this.As<IRollBlockGetRewardT>();
		}

		// Token: 0x0602C9AB RID: 182699 RVA: 0x0061925D File Offset: 0x0061745D
		public static IActionParams_Union_1Union FromIRollBlockGetReward(IRollBlockGetRewardT _irollblockgetreward)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IRollBlockGetReward,
				Value = _irollblockgetreward
			};
		}

		// Token: 0x0602C9AC RID: 182700 RVA: 0x00619276 File Offset: 0x00617476
		public IEnterMovieModeT AsIEnterMovieMode()
		{
			return this.As<IEnterMovieModeT>();
		}

		// Token: 0x0602C9AD RID: 182701 RVA: 0x0061927E File Offset: 0x0061747E
		public static IActionParams_Union_1Union FromIEnterMovieMode(IEnterMovieModeT _ientermoviemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterMovieMode,
				Value = _ientermoviemode
			};
		}

		// Token: 0x0602C9AE RID: 182702 RVA: 0x00619297 File Offset: 0x00617497
		public IExitMovieModeT AsIExitMovieMode()
		{
			return this.As<IExitMovieModeT>();
		}

		// Token: 0x0602C9AF RID: 182703 RVA: 0x0061929F File Offset: 0x0061749F
		public static IActionParams_Union_1Union FromIExitMovieMode(IExitMovieModeT _iexitmoviemode)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExitMovieMode,
				Value = _iexitmoviemode
			};
		}

		// Token: 0x0602C9B0 RID: 182704 RVA: 0x006192B8 File Offset: 0x006174B8
		public IStartRoadNetworkNavigationT AsIStartRoadNetworkNavigation()
		{
			return this.As<IStartRoadNetworkNavigationT>();
		}

		// Token: 0x0602C9B1 RID: 182705 RVA: 0x006192C0 File Offset: 0x006174C0
		public static IActionParams_Union_1Union FromIStartRoadNetworkNavigation(IStartRoadNetworkNavigationT _istartroadnetworknavigation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IStartRoadNetworkNavigation,
				Value = _istartroadnetworknavigation
			};
		}

		// Token: 0x0602C9B2 RID: 182706 RVA: 0x006192D9 File Offset: 0x006174D9
		public ISetWayOccupancyStateT AsISetWayOccupancyState()
		{
			return this.As<ISetWayOccupancyStateT>();
		}

		// Token: 0x0602C9B3 RID: 182707 RVA: 0x006192E1 File Offset: 0x006174E1
		public static IActionParams_Union_1Union FromISetWayOccupancyState(ISetWayOccupancyStateT _isetwayoccupancystate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetWayOccupancyState,
				Value = _isetwayoccupancystate
			};
		}

		// Token: 0x0602C9B4 RID: 182708 RVA: 0x006192FA File Offset: 0x006174FA
		public IEnterPatrolStateT AsIEnterPatrolState()
		{
			return this.As<IEnterPatrolStateT>();
		}

		// Token: 0x0602C9B5 RID: 182709 RVA: 0x00619302 File Offset: 0x00617502
		public static IActionParams_Union_1Union FromIEnterPatrolState(IEnterPatrolStateT _ienterpatrolstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IEnterPatrolState,
				Value = _ienterpatrolstate
			};
		}

		// Token: 0x0602C9B6 RID: 182710 RVA: 0x0061931B File Offset: 0x0061751B
		public IPerformAiHideSelfT AsIPerformAiHideSelf()
		{
			return this.As<IPerformAiHideSelfT>();
		}

		// Token: 0x0602C9B7 RID: 182711 RVA: 0x00619323 File Offset: 0x00617523
		public static IActionParams_Union_1Union FromIPerformAiHideSelf(IPerformAiHideSelfT _iperformaihideself)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IPerformAiHideSelf,
				Value = _iperformaihideself
			};
		}

		// Token: 0x0602C9B8 RID: 182712 RVA: 0x0061933C File Offset: 0x0061753C
		public ISendSceneActorEventT AsISendSceneActorEvent()
		{
			return this.As<ISendSceneActorEventT>();
		}

		// Token: 0x0602C9B9 RID: 182713 RVA: 0x00619344 File Offset: 0x00617544
		public static IActionParams_Union_1Union FromISendSceneActorEvent(ISendSceneActorEventT _isendsceneactorevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISendSceneActorEvent,
				Value = _isendsceneactorevent
			};
		}

		// Token: 0x0602C9BA RID: 182714 RVA: 0x0061935D File Offset: 0x0061755D
		public IExecBpActorFuncT AsIExecBpActorFunc()
		{
			return this.As<IExecBpActorFuncT>();
		}

		// Token: 0x0602C9BB RID: 182715 RVA: 0x00619365 File Offset: 0x00617565
		public static IActionParams_Union_1Union FromIExecBpActorFunc(IExecBpActorFuncT _iexecbpactorfunc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IExecBpActorFunc,
				Value = _iexecbpactorfunc
			};
		}

		// Token: 0x0602C9BC RID: 182716 RVA: 0x0061937E File Offset: 0x0061757E
		public IResetPlayerPosWithPresentationT AsIResetPlayerPosWithPresentation()
		{
			return this.As<IResetPlayerPosWithPresentationT>();
		}

		// Token: 0x0602C9BD RID: 182717 RVA: 0x00619386 File Offset: 0x00617586
		public static IActionParams_Union_1Union FromIResetPlayerPosWithPresentation(IResetPlayerPosWithPresentationT _iresetplayerposwithpresentation)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IResetPlayerPosWithPresentation,
				Value = _iresetplayerposwithpresentation
			};
		}

		// Token: 0x0602C9BE RID: 182718 RVA: 0x0061939F File Offset: 0x0061759F
		public IDrinksRollRoleRequirementT AsIDrinksRollRoleRequirement()
		{
			return this.As<IDrinksRollRoleRequirementT>();
		}

		// Token: 0x0602C9BF RID: 182719 RVA: 0x006193A7 File Offset: 0x006175A7
		public static IActionParams_Union_1Union FromIDrinksRollRoleRequirement(IDrinksRollRoleRequirementT _idrinksrollrolerequirement)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDrinksRollRoleRequirement,
				Value = _idrinksrollrolerequirement
			};
		}

		// Token: 0x0602C9C0 RID: 182720 RVA: 0x006193C0 File Offset: 0x006175C0
		public ISetBlendAnimT AsISetBlendAnim()
		{
			return this.As<ISetBlendAnimT>();
		}

		// Token: 0x0602C9C1 RID: 182721 RVA: 0x006193C8 File Offset: 0x006175C8
		public static IActionParams_Union_1Union FromISetBlendAnim(ISetBlendAnimT _isetblendanim)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetBlendAnim,
				Value = _isetblendanim
			};
		}

		// Token: 0x0602C9C2 RID: 182722 RVA: 0x006193E1 File Offset: 0x006175E1
		public IReportTrackingEventT AsIReportTrackingEvent()
		{
			return this.As<IReportTrackingEventT>();
		}

		// Token: 0x0602C9C3 RID: 182723 RVA: 0x006193E9 File Offset: 0x006175E9
		public static IActionParams_Union_1Union FromIReportTrackingEvent(IReportTrackingEventT _ireporttrackingevent)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IReportTrackingEvent,
				Value = _ireporttrackingevent
			};
		}

		// Token: 0x0602C9C4 RID: 182724 RVA: 0x00619402 File Offset: 0x00617602
		public ITetrisThrowBlockT AsITetrisThrowBlock()
		{
			return this.As<ITetrisThrowBlockT>();
		}

		// Token: 0x0602C9C5 RID: 182725 RVA: 0x0061940A File Offset: 0x0061760A
		public static IActionParams_Union_1Union FromITetrisThrowBlock(ITetrisThrowBlockT _itetristhrowblock)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisThrowBlock,
				Value = _itetristhrowblock
			};
		}

		// Token: 0x0602C9C6 RID: 182726 RVA: 0x00619423 File Offset: 0x00617623
		public ITetrisGameCompleteT AsITetrisGameComplete()
		{
			return this.As<ITetrisGameCompleteT>();
		}

		// Token: 0x0602C9C7 RID: 182727 RVA: 0x0061942B File Offset: 0x0061762B
		public static IActionParams_Union_1Union FromITetrisGameComplete(ITetrisGameCompleteT _itetrisgamecomplete)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisGameComplete,
				Value = _itetrisgamecomplete
			};
		}

		// Token: 0x0602C9C8 RID: 182728 RVA: 0x00619444 File Offset: 0x00617644
		public ITetrisTriggerDelayFallT AsITetrisTriggerDelayFall()
		{
			return this.As<ITetrisTriggerDelayFallT>();
		}

		// Token: 0x0602C9C9 RID: 182729 RVA: 0x0061944C File Offset: 0x0061764C
		public static IActionParams_Union_1Union FromITetrisTriggerDelayFall(ITetrisTriggerDelayFallT _itetristriggerdelayfall)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ITetrisTriggerDelayFall,
				Value = _itetristriggerdelayfall
			};
		}

		// Token: 0x0602C9CA RID: 182730 RVA: 0x00619465 File Offset: 0x00617665
		public IBossPilingRandomBuffT AsIBossPilingRandomBuff()
		{
			return this.As<IBossPilingRandomBuffT>();
		}

		// Token: 0x0602C9CB RID: 182731 RVA: 0x0061946D File Offset: 0x0061766D
		public static IActionParams_Union_1Union FromIBossPilingRandomBuff(IBossPilingRandomBuffT _ibosspilingrandombuff)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBossPilingRandomBuff,
				Value = _ibosspilingrandombuff
			};
		}

		// Token: 0x0602C9CC RID: 182732 RVA: 0x00619486 File Offset: 0x00617686
		public IBossPilingEnterNextInstT AsIBossPilingEnterNextInst()
		{
			return this.As<IBossPilingEnterNextInstT>();
		}

		// Token: 0x0602C9CD RID: 182733 RVA: 0x0061948E File Offset: 0x0061768E
		public static IActionParams_Union_1Union FromIBossPilingEnterNextInst(IBossPilingEnterNextInstT _ibosspilingenternextinst)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IBossPilingEnterNextInst,
				Value = _ibosspilingenternextinst
			};
		}

		// Token: 0x0602C9CE RID: 182734 RVA: 0x006194A7 File Offset: 0x006176A7
		public IOpenQuickHackSystemT AsIOpenQuickHackSystem()
		{
			return this.As<IOpenQuickHackSystemT>();
		}

		// Token: 0x0602C9CF RID: 182735 RVA: 0x006194AF File Offset: 0x006176AF
		public static IActionParams_Union_1Union FromIOpenQuickHackSystem(IOpenQuickHackSystemT _iopenquickhacksystem)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IOpenQuickHackSystem,
				Value = _iopenquickhacksystem
			};
		}

		// Token: 0x0602C9D0 RID: 182736 RVA: 0x006194C8 File Offset: 0x006176C8
		public IDollGrabItemDeliveryT AsIDollGrabItemDelivery()
		{
			return this.As<IDollGrabItemDeliveryT>();
		}

		// Token: 0x0602C9D1 RID: 182737 RVA: 0x006194D0 File Offset: 0x006176D0
		public static IActionParams_Union_1Union FromIDollGrabItemDelivery(IDollGrabItemDeliveryT _idollgrabitemdelivery)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IDollGrabItemDelivery,
				Value = _idollgrabitemdelivery
			};
		}

		// Token: 0x0602C9D2 RID: 182738 RVA: 0x006194E9 File Offset: 0x006176E9
		public ISheriffUnlockClueT AsISheriffUnlockClue()
		{
			return this.As<ISheriffUnlockClueT>();
		}

		// Token: 0x0602C9D3 RID: 182739 RVA: 0x006194F1 File Offset: 0x006176F1
		public static IActionParams_Union_1Union FromISheriffUnlockClue(ISheriffUnlockClueT _isheriffunlockclue)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockClue,
				Value = _isheriffunlockclue
			};
		}

		// Token: 0x0602C9D4 RID: 182740 RVA: 0x0061950A File Offset: 0x0061770A
		public ISheriffUnlockProgressT AsISheriffUnlockProgress()
		{
			return this.As<ISheriffUnlockProgressT>();
		}

		// Token: 0x0602C9D5 RID: 182741 RVA: 0x00619512 File Offset: 0x00617712
		public static IActionParams_Union_1Union FromISheriffUnlockProgress(ISheriffUnlockProgressT _isheriffunlockprogress)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockProgress,
				Value = _isheriffunlockprogress
			};
		}

		// Token: 0x0602C9D6 RID: 182742 RVA: 0x0061952B File Offset: 0x0061772B
		public ISheriffChangeCriminalStateT AsISheriffChangeCriminalState()
		{
			return this.As<ISheriffChangeCriminalStateT>();
		}

		// Token: 0x0602C9D7 RID: 182743 RVA: 0x00619533 File Offset: 0x00617733
		public static IActionParams_Union_1Union FromISheriffChangeCriminalState(ISheriffChangeCriminalStateT _isheriffchangecriminalstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffChangeCriminalState,
				Value = _isheriffchangecriminalstate
			};
		}

		// Token: 0x0602C9D8 RID: 182744 RVA: 0x0061954C File Offset: 0x0061774C
		public ISheriffChangeCriminalIdentityT AsISheriffChangeCriminalIdentity()
		{
			return this.As<ISheriffChangeCriminalIdentityT>();
		}

		// Token: 0x0602C9D9 RID: 182745 RVA: 0x00619554 File Offset: 0x00617754
		public static IActionParams_Union_1Union FromISheriffChangeCriminalIdentity(ISheriffChangeCriminalIdentityT _isheriffchangecriminalidentity)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffChangeCriminalIdentity,
				Value = _isheriffchangecriminalidentity
			};
		}

		// Token: 0x0602C9DA RID: 182746 RVA: 0x0061956D File Offset: 0x0061776D
		public ISheriffUnlockEndingT AsISheriffUnlockEnding()
		{
			return this.As<ISheriffUnlockEndingT>();
		}

		// Token: 0x0602C9DB RID: 182747 RVA: 0x00619575 File Offset: 0x00617775
		public static IActionParams_Union_1Union FromISheriffUnlockEnding(ISheriffUnlockEndingT _isheriffunlockending)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISheriffUnlockEnding,
				Value = _isheriffunlockending
			};
		}

		// Token: 0x0602C9DC RID: 182748 RVA: 0x0061958E File Offset: 0x0061778E
		public ISetTargetElementalAbilityT AsISetTargetElementalAbility()
		{
			return this.As<ISetTargetElementalAbilityT>();
		}

		// Token: 0x0602C9DD RID: 182749 RVA: 0x00619596 File Offset: 0x00617796
		public static IActionParams_Union_1Union FromISetTargetElementalAbility(ISetTargetElementalAbilityT _isettargetelementalability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetTargetElementalAbility,
				Value = _isettargetelementalability
			};
		}

		// Token: 0x0602C9DE RID: 182750 RVA: 0x006195AF File Offset: 0x006177AF
		public IToggleEntityElementalAbilityT AsIToggleEntityElementalAbility()
		{
			return this.As<IToggleEntityElementalAbilityT>();
		}

		// Token: 0x0602C9DF RID: 182751 RVA: 0x006195B7 File Offset: 0x006177B7
		public static IActionParams_Union_1Union FromIToggleEntityElementalAbility(IToggleEntityElementalAbilityT _itoggleentityelementalability)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IToggleEntityElementalAbility,
				Value = _itoggleentityelementalability
			};
		}

		// Token: 0x0602C9E0 RID: 182752 RVA: 0x006195D0 File Offset: 0x006177D0
		public ICaptureElementalBoxT AsICaptureElementalBox()
		{
			return this.As<ICaptureElementalBoxT>();
		}

		// Token: 0x0602C9E1 RID: 182753 RVA: 0x006195D8 File Offset: 0x006177D8
		public static IActionParams_Union_1Union FromICaptureElementalBox(ICaptureElementalBoxT _icaptureelementalbox)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ICaptureElementalBox,
				Value = _icaptureelementalbox
			};
		}

		// Token: 0x0602C9E2 RID: 182754 RVA: 0x006195F1 File Offset: 0x006177F1
		public IChangeElementalBoxStateT AsIChangeElementalBoxState()
		{
			return this.As<IChangeElementalBoxStateT>();
		}

		// Token: 0x0602C9E3 RID: 182755 RVA: 0x006195F9 File Offset: 0x006177F9
		public static IActionParams_Union_1Union FromIChangeElementalBoxState(IChangeElementalBoxStateT _ichangeelementalboxstate)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IChangeElementalBoxState,
				Value = _ichangeelementalboxstate
			};
		}

		// Token: 0x0602C9E4 RID: 182756 RVA: 0x00619612 File Offset: 0x00617812
		public ISetElementalBoxToTargetT AsISetElementalBoxToTarget()
		{
			return this.As<ISetElementalBoxToTargetT>();
		}

		// Token: 0x0602C9E5 RID: 182757 RVA: 0x0061961A File Offset: 0x0061781A
		public static IActionParams_Union_1Union FromISetElementalBoxToTarget(ISetElementalBoxToTargetT _isetelementalboxtotarget)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISetElementalBoxToTarget,
				Value = _isetelementalboxtotarget
			};
		}

		// Token: 0x0602C9E6 RID: 182758 RVA: 0x00619633 File Offset: 0x00617833
		public ISeasonWeatherSetRotationLockT AsISeasonWeatherSetRotationLock()
		{
			return this.As<ISeasonWeatherSetRotationLockT>();
		}

		// Token: 0x0602C9E7 RID: 182759 RVA: 0x0061963B File Offset: 0x0061783B
		public static IActionParams_Union_1Union FromISeasonWeatherSetRotationLock(ISeasonWeatherSetRotationLockT _iseasonweathersetrotationlock)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeasonWeatherSetRotationLock,
				Value = _iseasonweathersetrotationlock
			};
		}

		// Token: 0x0602C9E8 RID: 182760 RVA: 0x00619654 File Offset: 0x00617854
		public ISeasonWeatherChangeToT AsISeasonWeatherChangeTo()
		{
			return this.As<ISeasonWeatherChangeToT>();
		}

		// Token: 0x0602C9E9 RID: 182761 RVA: 0x0061965C File Offset: 0x0061785C
		public static IActionParams_Union_1Union FromISeasonWeatherChangeTo(ISeasonWeatherChangeToT _iseasonweatherchangeto)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeasonWeatherChangeTo,
				Value = _iseasonweatherchangeto
			};
		}

		// Token: 0x0602C9EA RID: 182762 RVA: 0x00619675 File Offset: 0x00617875
		public ISeasonWeatherUnlockSpecialT AsISeasonWeatherUnlockSpecial()
		{
			return this.As<ISeasonWeatherUnlockSpecialT>();
		}

		// Token: 0x0602C9EB RID: 182763 RVA: 0x0061967D File Offset: 0x0061787D
		public static IActionParams_Union_1Union FromISeasonWeatherUnlockSpecial(ISeasonWeatherUnlockSpecialT _iseasonweatherunlockspecial)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ISeasonWeatherUnlockSpecial,
				Value = _iseasonweatherunlockspecial
			};
		}

		// Token: 0x0602C9EC RID: 182764 RVA: 0x00619696 File Offset: 0x00617896
		public IHandBookModifySystemProgressT AsIHandBookModifySystemProgress()
		{
			return this.As<IHandBookModifySystemProgressT>();
		}

		// Token: 0x0602C9ED RID: 182765 RVA: 0x0061969E File Offset: 0x0061789E
		public static IActionParams_Union_1Union FromIHandBookModifySystemProgress(IHandBookModifySystemProgressT _ihandbookmodifysystemprogress)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IHandBookModifySystemProgress,
				Value = _ihandbookmodifysystemprogress
			};
		}

		// Token: 0x0602C9EE RID: 182766 RVA: 0x006196B7 File Offset: 0x006178B7
		public IClientExecEntityPrefabActionT AsIClientExecEntityPrefabAction()
		{
			return this.As<IClientExecEntityPrefabActionT>();
		}

		// Token: 0x0602C9EF RID: 182767 RVA: 0x006196BF File Offset: 0x006178BF
		public static IActionParams_Union_1Union FromIClientExecEntityPrefabAction(IClientExecEntityPrefabActionT _iclientexecentityprefabaction)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.IClientExecEntityPrefabAction,
				Value = _iclientexecentityprefabaction
			};
		}

		// Token: 0x0602C9F0 RID: 182768 RVA: 0x006196D8 File Offset: 0x006178D8
		public ILiveSetUiT AsILiveSetUi()
		{
			return this.As<ILiveSetUiT>();
		}

		// Token: 0x0602C9F1 RID: 182769 RVA: 0x006196E0 File Offset: 0x006178E0
		public static IActionParams_Union_1Union FromILiveSetUi(ILiveSetUiT _ilivesetui)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ILiveSetUi,
				Value = _ilivesetui
			};
		}

		// Token: 0x0602C9F2 RID: 182770 RVA: 0x006196F9 File Offset: 0x006178F9
		public ILiveSetDanmakuT AsILiveSetDanmaku()
		{
			return this.As<ILiveSetDanmakuT>();
		}

		// Token: 0x0602C9F3 RID: 182771 RVA: 0x00619701 File Offset: 0x00617901
		public static IActionParams_Union_1Union FromILiveSetDanmaku(ILiveSetDanmakuT _ilivesetdanmaku)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ILiveSetDanmaku,
				Value = _ilivesetdanmaku
			};
		}

		// Token: 0x0602C9F4 RID: 182772 RVA: 0x0061971A File Offset: 0x0061791A
		public ILiveSetParamT AsILiveSetParam()
		{
			return this.As<ILiveSetParamT>();
		}

		// Token: 0x0602C9F5 RID: 182773 RVA: 0x00619722 File Offset: 0x00617922
		public static IActionParams_Union_1Union FromILiveSetParam(ILiveSetParamT _ilivesetparam)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ILiveSetParam,
				Value = _ilivesetparam
			};
		}

		// Token: 0x0602C9F6 RID: 182774 RVA: 0x0061973B File Offset: 0x0061793B
		public ILiveSetScT AsILiveSetSc()
		{
			return this.As<ILiveSetScT>();
		}

		// Token: 0x0602C9F7 RID: 182775 RVA: 0x00619743 File Offset: 0x00617943
		public static IActionParams_Union_1Union FromILiveSetSc(ILiveSetScT _ilivesetsc)
		{
			return new IActionParams_Union_1Union
			{
				Type = IActionParams_Union_1.ILiveSetSc,
				Value = _ilivesetsc
			};
		}

		// Token: 0x0602C9F8 RID: 182776 RVA: 0x0061975C File Offset: 0x0061795C
		public static int Pack(FlatBufferBuilder builder, IActionParams_Union_1Union _o)
		{
			switch (_o.Type)
			{
			case IActionParams_Union_1.IEnterOrbitalCamera:
				return IEnterOrbitalCamera.Pack(builder, _o.AsIEnterOrbitalCamera()).Value;
			case IActionParams_Union_1.IExitOrbitalCamera:
				return IExitOrbitalCamera.Pack(builder, _o.AsIExitOrbitalCamera()).Value;
			case IActionParams_Union_1.IEnableSplineMoveModel:
				return IEnableSplineMoveModel.Pack(builder, _o.AsIEnableSplineMoveModel()).Value;
			case IActionParams_Union_1.IEnableActor:
				return IEnableActor.Pack(builder, _o.AsIEnableActor()).Value;
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
			case IActionParams_Union_1.ISendBattleTag:
				return ISendBattleTag.Pack(builder, _o.AsISendBattleTag()).Value;
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
			case IActionParams_Union_1.IFollowShooterLeisureInteract:
				return IFollowShooterLeisureInteract.Pack(builder, _o.AsIFollowShooterLeisureInteract()).Value;
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
			case IActionParams_Union_1.ISeasonWeatherSetRotationLock:
				return ISeasonWeatherSetRotationLock.Pack(builder, _o.AsISeasonWeatherSetRotationLock()).Value;
			case IActionParams_Union_1.ISeasonWeatherChangeTo:
				return ISeasonWeatherChangeTo.Pack(builder, _o.AsISeasonWeatherChangeTo()).Value;
			case IActionParams_Union_1.ISeasonWeatherUnlockSpecial:
				return ISeasonWeatherUnlockSpecial.Pack(builder, _o.AsISeasonWeatherUnlockSpecial()).Value;
			case IActionParams_Union_1.IHandBookModifySystemProgress:
				return IHandBookModifySystemProgress.Pack(builder, _o.AsIHandBookModifySystemProgress()).Value;
			case IActionParams_Union_1.IClientExecEntityPrefabAction:
				return IClientExecEntityPrefabAction.Pack(builder, _o.AsIClientExecEntityPrefabAction()).Value;
			case IActionParams_Union_1.ILiveSetUi:
				return ILiveSetUi.Pack(builder, _o.AsILiveSetUi()).Value;
			case IActionParams_Union_1.ILiveSetDanmaku:
				return ILiveSetDanmaku.Pack(builder, _o.AsILiveSetDanmaku()).Value;
			case IActionParams_Union_1.ILiveSetParam:
				return ILiveSetParam.Pack(builder, _o.AsILiveSetParam()).Value;
			case IActionParams_Union_1.ILiveSetSc:
				return ILiveSetSc.Pack(builder, _o.AsILiveSetSc()).Value;
			default:
				return 0;
			}
		}
	}
}
