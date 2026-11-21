using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200161E RID: 5662
	public enum ErrorCode
	{
		// Token: 0x0400ACC7 RID: 44231
		[OriginalName("Success")]
		Success,
		// Token: 0x0400ACC8 RID: 44232
		[OriginalName("RequestParamError")]
		RequestParamError,
		// Token: 0x0400ACC9 RID: 44233
		[OriginalName("InternalError")]
		InternalError,
		// Token: 0x0400ACCA RID: 44234
		[OriginalName("UnKnownError")]
		UnKnownError,
		// Token: 0x0400ACCB RID: 44235
		[OriginalName("ServerNotReady")]
		ServerNotReady,
		// Token: 0x0400ACCC RID: 44236
		[OriginalName("ServerFullLoad")]
		ServerFullLoad,
		// Token: 0x0400ACCD RID: 44237
		[OriginalName("InvalidUserId")]
		InvalidUserId,
		// Token: 0x0400ACCE RID: 44238
		[OriginalName("InvalidToken")]
		InvalidToken,
		// Token: 0x0400ACCF RID: 44239
		[OriginalName("InvalidRequest")]
		InvalidRequest,
		// Token: 0x0400ACD0 RID: 44240
		[OriginalName("GmFail")]
		GmFail,
		// Token: 0x0400ACD1 RID: 44241
		[OriginalName("GmParamError")]
		GmParamError,
		// Token: 0x0400ACD2 RID: 44242
		[OriginalName("GmException")]
		GmException,
		// Token: 0x0400ACD3 RID: 44243
		[OriginalName("NotEnableGm")]
		NotEnableGm,
		// Token: 0x0400ACD4 RID: 44244
		[OriginalName("NotElegantName")]
		NotElegantName,
		// Token: 0x0400ACD5 RID: 44245
		[OriginalName("ContainsDirtyWord")]
		ContainsDirtyWord,
		// Token: 0x0400ACD6 RID: 44246
		[OriginalName("DirtyWordServerError")]
		DirtyWordServerError,
		// Token: 0x0400ACD7 RID: 44247
		[OriginalName("DirtyWordServerReturnEmpty")]
		DirtyWordServerReturnEmpty,
		// Token: 0x0400ACD8 RID: 44248
		[OriginalName("DirtyWordCheckException")]
		DirtyWordCheckException,
		// Token: 0x0400ACD9 RID: 44249
		[OriginalName("ComponentNotExist")]
		ComponentNotExist,
		// Token: 0x0400ACDA RID: 44250
		[OriginalName("ServerFullLoadGame")]
		ServerFullLoadGame,
		// Token: 0x0400ACDB RID: 44251
		[OriginalName("ServerFullLoadGate")]
		ServerFullLoadGate,
		// Token: 0x0400ACDC RID: 44252
		[OriginalName("PlayerLoggingInFlag")]
		PlayerLoggingInFlag,
		// Token: 0x0400ACDD RID: 44253
		[OriginalName("GateLoginException")]
		GateLoginException,
		// Token: 0x0400ACDE RID: 44254
		[OriginalName("GateLoginSeverSelectErr")]
		GateLoginSeverSelectErr,
		// Token: 0x0400ACDF RID: 44255
		[OriginalName("GateTokenAccessErr")]
		GateTokenAccessErr,
		// Token: 0x0400ACE0 RID: 44256
		[OriginalName("GateTokenAccessException")]
		GateTokenAccessException,
		// Token: 0x0400ACE1 RID: 44257
		[OriginalName("GateLoginUserIdErr")]
		GateLoginUserIdErr,
		// Token: 0x0400ACE2 RID: 44258
		[OriginalName("GateLoginNodeIdErr")]
		GateLoginNodeIdErr,
		// Token: 0x0400ACE3 RID: 44259
		[OriginalName("GateLoginCreateCharacterErr")]
		GateLoginCreateCharacterErr,
		// Token: 0x0400ACE4 RID: 44260
		[OriginalName("GateCreateCharacterException")]
		GateCreateCharacterException,
		// Token: 0x0400ACE5 RID: 44261
		[OriginalName("GateEnterGameAddressNotFound")]
		GateEnterGameAddressNotFound,
		// Token: 0x0400ACE6 RID: 44262
		[OriginalName("GateEnterGameException")]
		GateEnterGameException,
		// Token: 0x0400ACE7 RID: 44263
		[OriginalName("GateEnterGameCreatePlayerErr")]
		GateEnterGameCreatePlayerErr,
		// Token: 0x0400ACE8 RID: 44264
		[OriginalName("GateEnterGameAddPlayerErr")]
		GateEnterGameAddPlayerErr,
		// Token: 0x0400ACE9 RID: 44265
		[OriginalName("GameGateNodeNotFound")]
		GameGateNodeNotFound,
		// Token: 0x0400ACEA RID: 44266
		[OriginalName("GamePlayerAdminExist")]
		GamePlayerAdminExist,
		// Token: 0x0400ACEB RID: 44267
		[OriginalName("GameReloginGateNodeNotFound")]
		GameReloginGateNodeNotFound,
		// Token: 0x0400ACEC RID: 44268
		[OriginalName("GameReloginPlayerNotFound")]
		GameReloginPlayerNotFound,
		// Token: 0x0400ACED RID: 44269
		[OriginalName("ServerNotOpen")]
		ServerNotOpen,
		// Token: 0x0400ACEE RID: 44270
		[OriginalName("ServerMaintenance")]
		ServerMaintenance,
		// Token: 0x0400ACEF RID: 44271
		[OriginalName("InvalidLoginType")]
		InvalidLoginType,
		// Token: 0x0400ACF0 RID: 44272
		[OriginalName("InvalidGateway")]
		InvalidGateway,
		// Token: 0x0400ACF1 RID: 44273
		[OriginalName("SDKServerError")]
		SdkserverError,
		// Token: 0x0400ACF2 RID: 44274
		[OriginalName("TokenNotAuthrized")]
		TokenNotAuthrized,
		// Token: 0x0400ACF3 RID: 44275
		[OriginalName("HadBan")]
		HadBan,
		// Token: 0x0400ACF4 RID: 44276
		[OriginalName("NotInUserIdWhiteList")]
		NotInUserIdWhiteList,
		// Token: 0x0400ACF5 RID: 44277
		[OriginalName("NoHealthyGamesvr")]
		NoHealthyGamesvr,
		// Token: 0x0400ACF6 RID: 44278
		[OriginalName("NoHealthyGateway")]
		NoHealthyGateway,
		// Token: 0x0400ACF7 RID: 44279
		[OriginalName("GarFailed")]
		GarFailed,
		// Token: 0x0400ACF8 RID: 44280
		[OriginalName("GarSdkCheckFail")]
		GarSdkCheckFail,
		// Token: 0x0400ACF9 RID: 44281
		[OriginalName("GarNoneUserInfo")]
		GarNoneUserInfo,
		// Token: 0x0400ACFA RID: 44282
		[OriginalName("GarQueryUserInfoError")]
		GarQueryUserInfoError,
		// Token: 0x0400ACFB RID: 44283
		[OriginalName("GarNoRegion")]
		GarNoRegion,
		// Token: 0x0400ACFC RID: 44284
		[OriginalName("InternalExceptionCode")]
		InternalExceptionCode,
		// Token: 0x0400ACFD RID: 44285
		[OriginalName("DecodeExceptionCode")]
		DecodeExceptionCode,
		// Token: 0x0400ACFE RID: 44286
		[OriginalName("EncodeExceptionCode")]
		EncodeExceptionCode,
		// Token: 0x0400ACFF RID: 44287
		[OriginalName("InvalidRequestExceptionCode")]
		InvalidRequestExceptionCode,
		// Token: 0x0400AD00 RID: 44288
		[OriginalName("MessageOutOfLimitExceptionCode")]
		MessageOutOfLimitExceptionCode,
		// Token: 0x0400AD01 RID: 44289
		[OriginalName("MessageNoHandler")]
		MessageNoHandler,
		// Token: 0x0400AD02 RID: 44290
		[OriginalName("EncryptionNoCreate")]
		EncryptionNoCreate,
		// Token: 0x0400AD03 RID: 44291
		[OriginalName("DecryptFail")]
		DecryptFail,
		// Token: 0x0400AD04 RID: 44292
		[OriginalName("PlayerNotInTheScene")]
		PlayerNotInTheScene,
		// Token: 0x0400AD05 RID: 44293
		[OriginalName("NonReentrantExceptionCode")]
		NonReentrantExceptionCode,
		// Token: 0x0400AD06 RID: 44294
		[OriginalName("PlayerLoggedOut")]
		PlayerLoggedOut,
		// Token: 0x0400AD07 RID: 44295
		[OriginalName("MsgFunctionClose")]
		MsgFunctionClose,
		// Token: 0x0400AD08 RID: 44296
		[OriginalName("SeqNoError")]
		SeqNoError,
		// Token: 0x0400AD09 RID: 44297
		[OriginalName("InvalidMessageType")]
		InvalidMessageType,
		// Token: 0x0400AD0A RID: 44298
		[OriginalName("InvalidMessageHeader")]
		InvalidMessageHeader,
		// Token: 0x0400AD0B RID: 44299
		[OriginalName("InvalidSeqNo")]
		InvalidSeqNo,
		// Token: 0x0400AD0C RID: 44300
		[OriginalName("InvalidMessageId")]
		InvalidMessageId,
		// Token: 0x0400AD0D RID: 44301
		[OriginalName("ProtobufDecodeFailed")]
		ProtobufDecodeFailed,
		// Token: 0x0400AD0E RID: 44302
		[OriginalName("ErrProtoSeedCheck")]
		ErrProtoSeedCheck,
		// Token: 0x0400AD0F RID: 44303
		[OriginalName("MessageCouldNotBeRouted")]
		MessageCouldNotBeRouted,
		// Token: 0x0400AD10 RID: 44304
		[OriginalName("ErrPlayerLogined")]
		ErrPlayerLogined,
		// Token: 0x0400AD11 RID: 44305
		[OriginalName("ClosedRegister")]
		ClosedRegister = 100000,
		// Token: 0x0400AD12 RID: 44306
		[OriginalName("RegisterOutOfLimit")]
		RegisterOutOfLimit,
		// Token: 0x0400AD13 RID: 44307
		[OriginalName("HaveNoCharacter")]
		HaveNoCharacter,
		// Token: 0x0400AD14 RID: 44308
		[OriginalName("InvalidCharacterName")]
		InvalidCharacterName,
		// Token: 0x0400AD15 RID: 44309
		[OriginalName("CreateCharacterFailed")]
		CreateCharacterFailed,
		// Token: 0x0400AD16 RID: 44310
		[OriginalName("CreateCharacterDuplicateKey")]
		CreateCharacterDuplicateKey,
		// Token: 0x0400AD17 RID: 44311
		[OriginalName("PlayerAlreadyLogin")]
		PlayerAlreadyLogin,
		// Token: 0x0400AD18 RID: 44312
		[OriginalName("PlayerLoggingIn")]
		PlayerLoggingIn,
		// Token: 0x0400AD19 RID: 44313
		[OriginalName("ErrLoginGWReconnecting")]
		ErrLoginGwreconnecting,
		// Token: 0x0400AD1A RID: 44314
		[OriginalName("LoginRetry")]
		LoginRetry,
		// Token: 0x0400AD1B RID: 44315
		[OriginalName("QueryPlayerDataFailed")]
		QueryPlayerDataFailed,
		// Token: 0x0400AD1C RID: 44316
		[OriginalName("CheckPlayerDataFailed")]
		CheckPlayerDataFailed,
		// Token: 0x0400AD1D RID: 44317
		[OriginalName("CheckPlayerDataFailedDebug")]
		CheckPlayerDataFailedDebug,
		// Token: 0x0400AD1E RID: 44318
		[OriginalName("LogoutUnknownError")]
		LogoutUnknownError,
		// Token: 0x0400AD1F RID: 44319
		[OriginalName("AccountLoggedInElsewhere")]
		AccountLoggedInElsewhere,
		// Token: 0x0400AD20 RID: 44320
		[OriginalName("AccountIsBlocked")]
		AccountIsBlocked,
		// Token: 0x0400AD21 RID: 44321
		[OriginalName("DataOverflow")]
		DataOverflow,
		// Token: 0x0400AD22 RID: 44322
		[OriginalName("AccountBeKick")]
		AccountBeKick,
		// Token: 0x0400AD23 RID: 44323
		[OriginalName("AppVersionNotMatch")]
		AppVersionNotMatch,
		// Token: 0x0400AD24 RID: 44324
		[OriginalName("LauncherVersionIsTooLow")]
		LauncherVersionIsTooLow,
		// Token: 0x0400AD25 RID: 44325
		[OriginalName("ResourceVersionIsTooLow")]
		ResourceVersionIsTooLow,
		// Token: 0x0400AD26 RID: 44326
		[OriginalName("CloseConnection")]
		CloseConnection,
		// Token: 0x0400AD27 RID: 44327
		[OriginalName("ErrAcquirePlayerLockFailed")]
		ErrAcquirePlayerLockFailed,
		// Token: 0x0400AD28 RID: 44328
		[OriginalName("ErrPlayerLoggingOut")]
		ErrPlayerLoggingOut,
		// Token: 0x0400AD29 RID: 44329
		[OriginalName("MessageChecksumFailed")]
		MessageChecksumFailed,
		// Token: 0x0400AD2A RID: 44330
		[OriginalName("LoginTimeout")]
		LoginTimeout,
		// Token: 0x0400AD2B RID: 44331
		[OriginalName("ErrWeaponDefault")]
		ErrWeaponDefault = 200000,
		// Token: 0x0400AD2C RID: 44332
		[OriginalName("ErrWeaponLevelLimit")]
		ErrWeaponLevelLimit,
		// Token: 0x0400AD2D RID: 44333
		[OriginalName("ErrWeaponBreachLimit")]
		ErrWeaponBreachLimit,
		// Token: 0x0400AD2E RID: 44334
		[OriginalName("ErrWeaponConsumeInvalid")]
		ErrWeaponConsumeInvalid,
		// Token: 0x0400AD2F RID: 44335
		[OriginalName("ErrWeaponPkgFull")]
		ErrWeaponPkgFull,
		// Token: 0x0400AD30 RID: 44336
		[OriginalName("ErrRoleNoConfig")]
		ErrRoleNoConfig,
		// Token: 0x0400AD31 RID: 44337
		[OriginalName("ErrRoleIsActive")]
		ErrRoleIsActive,
		// Token: 0x0400AD32 RID: 44338
		[OriginalName("ErrRoleNotActive")]
		ErrRoleNotActive,
		// Token: 0x0400AD33 RID: 44339
		[OriginalName("ErrRoleOverNotEnough")]
		ErrRoleOverNotEnough,
		// Token: 0x0400AD34 RID: 44340
		[OriginalName("ErrRoleLevelNotEnough")]
		ErrRoleLevelNotEnough,
		// Token: 0x0400AD35 RID: 44341
		[OriginalName("ErrRoleException")]
		ErrRoleException,
		// Token: 0x0400AD36 RID: 44342
		[OriginalName("ErrRoleNotExchange")]
		ErrRoleNotExchange,
		// Token: 0x0400AD37 RID: 44343
		[OriginalName("ErrRoleResonNotActive")]
		ErrRoleResonNotActive,
		// Token: 0x0400AD38 RID: 44344
		[OriginalName("ErrRoleResonIsActive")]
		ErrRoleResonIsActive,
		// Token: 0x0400AD39 RID: 44345
		[OriginalName("ErrRoleConfigNotRight")]
		ErrRoleConfigNotRight,
		// Token: 0x0400AD3A RID: 44346
		[OriginalName("ErrRoleLevelMax")]
		ErrRoleLevelMax,
		// Token: 0x0400AD3B RID: 44347
		[OriginalName("ErrRolePerResonNotActive")]
		ErrRolePerResonNotActive,
		// Token: 0x0400AD3C RID: 44348
		[OriginalName("ErrRoleConditionNotFind")]
		ErrRoleConditionNotFind,
		// Token: 0x0400AD3D RID: 44349
		[OriginalName("ErrRoleConditionNoEnough")]
		ErrRoleConditionNoEnough,
		// Token: 0x0400AD3E RID: 44350
		[OriginalName("ErrRoleInvalidNameLength")]
		ErrRoleInvalidNameLength,
		// Token: 0x0400AD3F RID: 44351
		[OriginalName("ErrRoleExpInvalid")]
		ErrRoleExpInvalid,
		// Token: 0x0400AD40 RID: 44352
		[OriginalName("ErrRoleActiveNeedNoEnough")]
		ErrRoleActiveNeedNoEnough,
		// Token: 0x0400AD41 RID: 44353
		[OriginalName("ErrRoleResonMaxLevel")]
		ErrRoleResonMaxLevel,
		// Token: 0x0400AD42 RID: 44354
		[OriginalName("ErrRoleProtoError")]
		ErrRoleProtoError,
		// Token: 0x0400AD43 RID: 44355
		[OriginalName("ErrRoleItemListEmpty")]
		ErrRoleItemListEmpty,
		// Token: 0x0400AD44 RID: 44356
		[OriginalName("ErrRoleItemListCountOutRange")]
		ErrRoleItemListCountOutRange,
		// Token: 0x0400AD45 RID: 44357
		[OriginalName("ErrRoleItemExpError")]
		ErrRoleItemExpError,
		// Token: 0x0400AD46 RID: 44358
		[OriginalName("ErrRolePhantPosError")]
		ErrRolePhantPosError,
		// Token: 0x0400AD47 RID: 44359
		[OriginalName("ErrRolePhantSameError")]
		ErrRolePhantSameError,
		// Token: 0x0400AD48 RID: 44360
		[OriginalName("ErrRolePhantEmptyError")]
		ErrRolePhantEmptyError,
		// Token: 0x0400AD49 RID: 44361
		[OriginalName("ErrRoleItemListNoEnough")]
		ErrRoleItemListNoEnough,
		// Token: 0x0400AD4A RID: 44362
		[OriginalName("ErrRoleGetSkillByIdFailed")]
		ErrRoleGetSkillByIdFailed,
		// Token: 0x0400AD4B RID: 44363
		[OriginalName("ErrRoleFavorLevelNotEnough")]
		ErrRoleFavorLevelNotEnough,
		// Token: 0x0400AD4C RID: 44364
		[OriginalName("ErrRolSkillNodeType")]
		ErrRolSkillNodeType,
		// Token: 0x0400AD4D RID: 44365
		[OriginalName("ErrRolSkillNodeTypeActive")]
		ErrRolSkillNodeTypeActive,
		// Token: 0x0400AD4E RID: 44366
		[OriginalName("ErrRolSkillNodeTypeUlock")]
		ErrRolSkillNodeTypeUlock,
		// Token: 0x0400AD4F RID: 44367
		[OriginalName("ErrRolSkillPointsNotEnough")]
		ErrRolSkillPointsNotEnough,
		// Token: 0x0400AD50 RID: 44368
		[OriginalName("ErrTrialRoleExist")]
		ErrTrialRoleExist,
		// Token: 0x0400AD51 RID: 44369
		[OriginalName("ErrTrialRoleNotExist")]
		ErrTrialRoleNotExist,
		// Token: 0x0400AD52 RID: 44370
		[OriginalName("ErrTrialRoleRegionDataExist")]
		ErrTrialRoleRegionDataExist,
		// Token: 0x0400AD53 RID: 44371
		[OriginalName("ErrTrialRoleBtObjDataExist")]
		ErrTrialRoleBtObjDataExist,
		// Token: 0x0400AD54 RID: 44372
		[OriginalName("ErrTrialRoleRegionExist")]
		ErrTrialRoleRegionExist,
		// Token: 0x0400AD55 RID: 44373
		[OriginalName("ErrTrialRoleRegionNotExist")]
		ErrTrialRoleRegionNotExist,
		// Token: 0x0400AD56 RID: 44374
		[OriginalName("ErrLoadEquipDefault")]
		ErrLoadEquipDefault,
		// Token: 0x0400AD57 RID: 44375
		[OriginalName("ErrLoadEquipInvalidPos")]
		ErrLoadEquipInvalidPos,
		// Token: 0x0400AD58 RID: 44376
		[OriginalName("ErrLoadEquipInvalidRole")]
		ErrLoadEquipInvalidRole,
		// Token: 0x0400AD59 RID: 44377
		[OriginalName("ErrLoadEquipRoleConfig")]
		ErrLoadEquipRoleConfig,
		// Token: 0x0400AD5A RID: 44378
		[OriginalName("ErrPhantomIdNotExist")]
		ErrPhantomIdNotExist,
		// Token: 0x0400AD5B RID: 44379
		[OriginalName("ErrPhantomNotExist")]
		ErrPhantomNotExist,
		// Token: 0x0400AD5C RID: 44380
		[OriginalName("ErrPhantomLvupMax")]
		ErrPhantomLvupMax,
		// Token: 0x0400AD5D RID: 44381
		[OriginalName("ErrPhantomLvupMismatchItemId")]
		ErrPhantomLvupMismatchItemId,
		// Token: 0x0400AD5E RID: 44382
		[OriginalName("ErrPhantomLvupNoItem")]
		ErrPhantomLvupNoItem,
		// Token: 0x0400AD5F RID: 44383
		[OriginalName("ErrPhantomLvupLimit")]
		ErrPhantomLvupLimit,
		// Token: 0x0400AD60 RID: 44384
		[OriginalName("ErrPhantomItemType")]
		ErrPhantomItemType,
		// Token: 0x0400AD61 RID: 44385
		[OriginalName("ErrPhantomInvalidPos")]
		ErrPhantomInvalidPos,
		// Token: 0x0400AD62 RID: 44386
		[OriginalName("ErrPhantomConfigNotFound")]
		ErrPhantomConfigNotFound,
		// Token: 0x0400AD63 RID: 44387
		[OriginalName("ErrPhantomItemNotExist")]
		ErrPhantomItemNotExist,
		// Token: 0x0400AD64 RID: 44388
		[OriginalName("ErrPhantomPropNotExist")]
		ErrPhantomPropNotExist,
		// Token: 0x0400AD65 RID: 44389
		[OriginalName("ErrPhantomQaulityNotExist")]
		ErrPhantomQaulityNotExist,
		// Token: 0x0400AD66 RID: 44390
		[OriginalName("ErrPhantomBreachNotExist")]
		ErrPhantomBreachNotExist,
		// Token: 0x0400AD67 RID: 44391
		[OriginalName("ErrPhantomLevelNotEnough")]
		ErrPhantomLevelNotEnough,
		// Token: 0x0400AD68 RID: 44392
		[OriginalName("ErrPhantomExpItemNotExist")]
		ErrPhantomExpItemNotExist,
		// Token: 0x0400AD69 RID: 44393
		[OriginalName("ErrPhantomSubPropRandomErr")]
		ErrPhantomSubPropRandomErr,
		// Token: 0x0400AD6A RID: 44394
		[OriginalName("ErrPhantomSubPropNotEnough")]
		ErrPhantomSubPropNotEnough,
		// Token: 0x0400AD6B RID: 44395
		[OriginalName("ErrPhantomSubPropGenDupicate")]
		ErrPhantomSubPropGenDupicate,
		// Token: 0x0400AD6C RID: 44396
		[OriginalName("ErrPhantomSubStrengthenPropNotExist")]
		ErrPhantomSubStrengthenPropNotExist,
		// Token: 0x0400AD6D RID: 44397
		[OriginalName("ErrPhantomLevelConfigNotExist")]
		ErrPhantomLevelConfigNotExist,
		// Token: 0x0400AD6E RID: 44398
		[OriginalName("ErrPhantomLevelUpConsumeItemNotEnough")]
		ErrPhantomLevelUpConsumeItemNotEnough,
		// Token: 0x0400AD6F RID: 44399
		[OriginalName("ErrPhantomLevelUpMaterialLock")]
		ErrPhantomLevelUpMaterialLock,
		// Token: 0x0400AD70 RID: 44400
		[OriginalName("ErrPhantomLevelUpConsumeItemErr")]
		ErrPhantomLevelUpConsumeItemErr,
		// Token: 0x0400AD71 RID: 44401
		[OriginalName("ErrPhantomLevelUpRepeatItem")]
		ErrPhantomLevelUpRepeatItem,
		// Token: 0x0400AD72 RID: 44402
		[OriginalName("ErrPhantomMainPropNotExist")]
		ErrPhantomMainPropNotExist,
		// Token: 0x0400AD73 RID: 44403
		[OriginalName("ErrPhantomGrowthNotExist")]
		ErrPhantomGrowthNotExist,
		// Token: 0x0400AD74 RID: 44404
		[OriginalName("ErrPhantomBreachItemCount")]
		ErrPhantomBreachItemCount,
		// Token: 0x0400AD75 RID: 44405
		[OriginalName("ErrPhantomBreachRepeatItem")]
		ErrPhantomBreachRepeatItem,
		// Token: 0x0400AD76 RID: 44406
		[OriginalName("ErrPhantomDecomposeEquiped")]
		ErrPhantomDecomposeEquiped,
		// Token: 0x0400AD77 RID: 44407
		[OriginalName("ErrPhantomDecomposeFail")]
		ErrPhantomDecomposeFail,
		// Token: 0x0400AD78 RID: 44408
		[OriginalName("ErrPhantomBreachBindItem")]
		ErrPhantomBreachBindItem,
		// Token: 0x0400AD79 RID: 44409
		[OriginalName("ErrPhantomBreachErrItem")]
		ErrPhantomBreachErrItem,
		// Token: 0x0400AD7A RID: 44410
		[OriginalName("ErrPhantomRecommendNoData")]
		ErrPhantomRecommendNoData,
		// Token: 0x0400AD7B RID: 44411
		[OriginalName("ErrPhantomCannotTakeOff")]
		ErrPhantomCannotTakeOff,
		// Token: 0x0400AD7C RID: 44412
		[OriginalName("ErrPhantomCannotReplace")]
		ErrPhantomCannotReplace,
		// Token: 0x0400AD7D RID: 44413
		[OriginalName("ErrVisionSkillFavoriteTypeLimit")]
		ErrVisionSkillFavoriteTypeLimit,
		// Token: 0x0400AD7E RID: 44414
		[OriginalName("ErrVisionSkillFavoriteCountLimit")]
		ErrVisionSkillFavoriteCountLimit,
		// Token: 0x0400AD7F RID: 44415
		[OriginalName("ErrVisionSkillCfgNotFound")]
		ErrVisionSkillCfgNotFound,
		// Token: 0x0400AD80 RID: 44416
		[OriginalName("ErrVisionSkillNotFound")]
		ErrVisionSkillNotFound,
		// Token: 0x0400AD81 RID: 44417
		[OriginalName("ErrVisionSkillLevelUpMax")]
		ErrVisionSkillLevelUpMax,
		// Token: 0x0400AD82 RID: 44418
		[OriginalName("ErrVisionSkillLevelUpLimit")]
		ErrVisionSkillLevelUpLimit,
		// Token: 0x0400AD83 RID: 44419
		[OriginalName("ErrVisionSkillSlotNotFound")]
		ErrVisionSkillSlotNotFound,
		// Token: 0x0400AD84 RID: 44420
		[OriginalName("ErrVisionSkillEquipTypeLimit")]
		ErrVisionSkillEquipTypeLimit,
		// Token: 0x0400AD85 RID: 44421
		[OriginalName("ErrVisionSkillUnEquipLimit")]
		ErrVisionSkillUnEquipLimit,
		// Token: 0x0400AD86 RID: 44422
		[OriginalName("ErrVisionSkillGemCfgNotFound")]
		ErrVisionSkillGemCfgNotFound,
		// Token: 0x0400AD87 RID: 44423
		[OriginalName("ErrVisionSkillEquipLimit")]
		ErrVisionSkillEquipLimit,
		// Token: 0x0400AD88 RID: 44424
		[OriginalName("ErrVisionSkillGemLimit")]
		ErrVisionSkillGemLimit,
		// Token: 0x0400AD89 RID: 44425
		[OriginalName("ErrVisionSkillOperFail")]
		ErrVisionSkillOperFail,
		// Token: 0x0400AD8A RID: 44426
		[OriginalName("ErrVisionSkillSlotEquipLimit")]
		ErrVisionSkillSlotEquipLimit,
		// Token: 0x0400AD8B RID: 44427
		[OriginalName("ErrExploreSkillRouletteRepeat")]
		ErrExploreSkillRouletteRepeat,
		// Token: 0x0400AD8C RID: 44428
		[OriginalName("ErrItemCfgNotFound")]
		ErrItemCfgNotFound,
		// Token: 0x0400AD8D RID: 44429
		[OriginalName("ErrItemNotFound")]
		ErrItemNotFound,
		// Token: 0x0400AD8E RID: 44430
		[OriginalName("ErrItemNotEnough")]
		ErrItemNotEnough,
		// Token: 0x0400AD8F RID: 44431
		[OriginalName("ErrItemDecomposeLimit")]
		ErrItemDecomposeLimit,
		// Token: 0x0400AD90 RID: 44432
		[OriginalName("ErrItemUseLevelLimit")]
		ErrItemUseLevelLimit,
		// Token: 0x0400AD91 RID: 44433
		[OriginalName("ErrItemLockLimit")]
		ErrItemLockLimit,
		// Token: 0x0400AD92 RID: 44434
		[OriginalName("ErrItemInvalidParams")]
		ErrItemInvalidParams,
		// Token: 0x0400AD93 RID: 44435
		[OriginalName("ErrItemDecomposeFail")]
		ErrItemDecomposeFail,
		// Token: 0x0400AD94 RID: 44436
		[OriginalName("ErrItemUseFail")]
		ErrItemUseFail,
		// Token: 0x0400AD95 RID: 44437
		[OriginalName("ErrExchangeRewardCostItemNotEnough")]
		ErrExchangeRewardCostItemNotEnough,
		// Token: 0x0400AD96 RID: 44438
		[OriginalName("ExchangeRewardSuccess")]
		ExchangeRewardSuccess,
		// Token: 0x0400AD97 RID: 44439
		[OriginalName("ErrPkgCapacityNotEnough")]
		ErrPkgCapacityNotEnough,
		// Token: 0x0400AD98 RID: 44440
		[OriginalName("ErrGiftOptionalCount")]
		ErrGiftOptionalCount,
		// Token: 0x0400AD99 RID: 44441
		[OriginalName("ErrGiftOptionalNotExists")]
		ErrGiftOptionalNotExists,
		// Token: 0x0400AD9A RID: 44442
		[OriginalName("ErrGiftNotExists")]
		ErrGiftNotExists,
		// Token: 0x0400AD9B RID: 44443
		[OriginalName("ErrItemCount")]
		ErrItemCount,
		// Token: 0x0400AD9C RID: 44444
		[OriginalName("ErrItemIdNotContain")]
		ErrItemIdNotContain,
		// Token: 0x0400AD9D RID: 44445
		[OriginalName("ErrItemTypeNotContain")]
		ErrItemTypeNotContain,
		// Token: 0x0400AD9E RID: 44446
		[OriginalName("ErrCalabashMaxLevel")]
		ErrCalabashMaxLevel,
		// Token: 0x0400AD9F RID: 44447
		[OriginalName("ErrCalabashConfig")]
		ErrCalabashConfig,
		// Token: 0x0400ADA0 RID: 44448
		[OriginalName("ErrCalabashLevelUp")]
		ErrCalabashLevelUp,
		// Token: 0x0400ADA1 RID: 44449
		[OriginalName("ErrCalabashExp")]
		ErrCalabashExp,
		// Token: 0x0400ADA2 RID: 44450
		[OriginalName("ErrCalabashDevelopNoReward")]
		ErrCalabashDevelopNoReward,
		// Token: 0x0400ADA3 RID: 44451
		[OriginalName("ErrCalabashMonsterNotFound")]
		ErrCalabashMonsterNotFound,
		// Token: 0x0400ADA4 RID: 44452
		[OriginalName("PropRewardTips")]
		PropRewardTips,
		// Token: 0x0400ADA5 RID: 44453
		[OriginalName("ErrEnergyMaxCharge")]
		ErrEnergyMaxCharge,
		// Token: 0x0400ADA6 RID: 44454
		[OriginalName("ErrStateCanotTeleport")]
		ErrStateCanotTeleport,
		// Token: 0x0400ADA7 RID: 44455
		[OriginalName("ErrStateCannotEnterInst")]
		ErrStateCannotEnterInst,
		// Token: 0x0400ADA8 RID: 44456
		[OriginalName("ErrStateCannotOnline")]
		ErrStateCannotOnline,
		// Token: 0x0400ADA9 RID: 44457
		[OriginalName("ErrStateCannotChangeFormation")]
		ErrStateCannotChangeFormation,
		// Token: 0x0400ADAA RID: 44458
		[OriginalName("ErrReportPlayerCountLimit")]
		ErrReportPlayerCountLimit,
		// Token: 0x0400ADAB RID: 44459
		[OriginalName("ErrReportPlayerReasonNotFound")]
		ErrReportPlayerReasonNotFound,
		// Token: 0x0400ADAC RID: 44460
		[OriginalName("ErrReportMessageLengthLimit")]
		ErrReportMessageLengthLimit,
		// Token: 0x0400ADAD RID: 44461
		[OriginalName("ErrCookingToolFixed")]
		ErrCookingToolFixed,
		// Token: 0x0400ADAE RID: 44462
		[OriginalName("ErrCookingFormulaNotFound")]
		ErrCookingFormulaNotFound,
		// Token: 0x0400ADAF RID: 44463
		[OriginalName("ErrCookingCount")]
		ErrCookingCount,
		// Token: 0x0400ADB0 RID: 44464
		[OriginalName("ErrCookingProcessNotFound")]
		ErrCookingProcessNotFound,
		// Token: 0x0400ADB1 RID: 44465
		[OriginalName("ErrCookingLevelNotFound")]
		ErrCookingLevelNotFound,
		// Token: 0x0400ADB2 RID: 44466
		[OriginalName("ErrCookingLevelLimt")]
		ErrCookingLevelLimt,
		// Token: 0x0400ADB3 RID: 44467
		[OriginalName("ErrCookingInteractiveNotFound")]
		ErrCookingInteractiveNotFound,
		// Token: 0x0400ADB4 RID: 44468
		[OriginalName("ErrCookingFuncNotOpen")]
		ErrCookingFuncNotOpen,
		// Token: 0x0400ADB5 RID: 44469
		[OriginalName("ErrChallengeNotFound")]
		ErrChallengeNotFound,
		// Token: 0x0400ADB6 RID: 44470
		[OriginalName("ErrChallengeNoTeam")]
		ErrChallengeNoTeam,
		// Token: 0x0400ADB7 RID: 44471
		[OriginalName("ErrChallengeTeamLimit")]
		ErrChallengeTeamLimit,
		// Token: 0x0400ADB8 RID: 44472
		[OriginalName("ErrChallengeTeamMemLimit")]
		ErrChallengeTeamMemLimit,
		// Token: 0x0400ADB9 RID: 44473
		[OriginalName("ErrChallengeChangeFormation")]
		ErrChallengeChangeFormation,
		// Token: 0x0400ADBA RID: 44474
		[OriginalName("ErrChallengeFunNotOpen")]
		ErrChallengeFunNotOpen,
		// Token: 0x0400ADBB RID: 44475
		[OriginalName("ErrChallengeSeasonUpdate")]
		ErrChallengeSeasonUpdate,
		// Token: 0x0400ADBC RID: 44476
		[OriginalName("ErrChallengeLockRoleLimit")]
		ErrChallengeLockRoleLimit,
		// Token: 0x0400ADBD RID: 44477
		[OriginalName("ErrChallengeRoleLocked")]
		ErrChallengeRoleLocked,
		// Token: 0x0400ADBE RID: 44478
		[OriginalName("ErrChallengeNoRoleAlive")]
		ErrChallengeNoRoleAlive,
		// Token: 0x0400ADBF RID: 44479
		[OriginalName("ErrChallengeFormationEmpty")]
		ErrChallengeFormationEmpty,
		// Token: 0x0400ADC0 RID: 44480
		[OriginalName("ErrCycleChallengeNoRoleAlive")]
		ErrCycleChallengeNoRoleAlive,
		// Token: 0x0400ADC1 RID: 44481
		[OriginalName("ErrCycleChallengeFormationEmpty")]
		ErrCycleChallengeFormationEmpty,
		// Token: 0x0400ADC2 RID: 44482
		[OriginalName("ErrInfluenceLocked")]
		ErrInfluenceLocked,
		// Token: 0x0400ADC3 RID: 44483
		[OriginalName("ErrInfluenceRewardNotFound")]
		ErrInfluenceRewardNotFound,
		// Token: 0x0400ADC4 RID: 44484
		[OriginalName("ErrInfluenceConfigNotFound")]
		ErrInfluenceConfigNotFound,
		// Token: 0x0400ADC5 RID: 44485
		[OriginalName("ErrReputationLimit")]
		ErrReputationLimit,
		// Token: 0x0400ADC6 RID: 44486
		[OriginalName("ErrInfluenceRewardFailed")]
		ErrInfluenceRewardFailed,
		// Token: 0x0400ADC7 RID: 44487
		[OriginalName("ErrInfluenceFunNotOpen")]
		ErrInfluenceFunNotOpen,
		// Token: 0x0400ADC8 RID: 44488
		[OriginalName("ErrForgeFuncNotOpen")]
		ErrForgeFuncNotOpen,
		// Token: 0x0400ADC9 RID: 44489
		[OriginalName("ErrForgeCountLimit")]
		ErrForgeCountLimit,
		// Token: 0x0400ADCA RID: 44490
		[OriginalName("ErrForgeLocked")]
		ErrForgeLocked,
		// Token: 0x0400ADCB RID: 44491
		[OriginalName("ErrForgeConfigNotFound")]
		ErrForgeConfigNotFound,
		// Token: 0x0400ADCC RID: 44492
		[OriginalName("ErrForgeUnlocked")]
		ErrForgeUnlocked,
		// Token: 0x0400ADCD RID: 44493
		[OriginalName("ErrSynthesisFuncNotOpen")]
		ErrSynthesisFuncNotOpen,
		// Token: 0x0400ADCE RID: 44494
		[OriginalName("ErrSynthesisConfigNotFound")]
		ErrSynthesisConfigNotFound,
		// Token: 0x0400ADCF RID: 44495
		[OriginalName("ErrSynthesisCountLimit")]
		ErrSynthesisCountLimit,
		// Token: 0x0400ADD0 RID: 44496
		[OriginalName("ErrSynthesisLocked")]
		ErrSynthesisLocked,
		// Token: 0x0400ADD1 RID: 44497
		[OriginalName("ErrSynthesisLevelNotFound")]
		ErrSynthesisLevelNotFound,
		// Token: 0x0400ADD2 RID: 44498
		[OriginalName("ErrSynthesisLevelLimit")]
		ErrSynthesisLevelLimit,
		// Token: 0x0400ADD3 RID: 44499
		[OriginalName("ErrSynthesisCannotUnlock")]
		ErrSynthesisCannotUnlock,
		// Token: 0x0400ADD4 RID: 44500
		[OriginalName("ErrSynthesisUnlocked")]
		ErrSynthesisUnlocked,
		// Token: 0x0400ADD5 RID: 44501
		[OriginalName("ErrTrialRoleCannotMatch")]
		ErrTrialRoleCannotMatch,
		// Token: 0x0400ADD6 RID: 44502
		[OriginalName("ErrPhantomFormationTeleport")]
		ErrPhantomFormationTeleport,
		// Token: 0x0400ADD7 RID: 44503
		[OriginalName("ErrPhantomFormationEnterInst")]
		ErrPhantomFormationEnterInst,
		// Token: 0x0400ADD8 RID: 44504
		[OriginalName("ErrPhantomFormationMultiPlay")]
		ErrPhantomFormationMultiPlay,
		// Token: 0x0400ADD9 RID: 44505
		[OriginalName("ErrPhantomFormationAdvice")]
		ErrPhantomFormationAdvice,
		// Token: 0x0400ADDA RID: 44506
		[OriginalName("ErrPhantomFormationChangeFormation")]
		ErrPhantomFormationChangeFormation,
		// Token: 0x0400ADDB RID: 44507
		[OriginalName("ErrPhantomFormationRepeat")]
		ErrPhantomFormationRepeat,
		// Token: 0x0400ADDC RID: 44508
		[OriginalName("ErrPhantomFormationChangeFailed")]
		ErrPhantomFormationChangeFailed,
		// Token: 0x0400ADDD RID: 44509
		[OriginalName("ErrRoleChangeRoleCreateFailed")]
		ErrRoleChangeRoleCreateFailed,
		// Token: 0x0400ADDE RID: 44510
		[OriginalName("ErrRoleChangeRoleUpdateCreateFailed")]
		ErrRoleChangeRoleUpdateCreateFailed,
		// Token: 0x0400ADDF RID: 44511
		[OriginalName("ErrRoleChangeRoleNotUnlock")]
		ErrRoleChangeRoleNotUnlock,
		// Token: 0x0400ADE0 RID: 44512
		[OriginalName("ErrRoleChangeMultiPlay")]
		ErrRoleChangeMultiPlay,
		// Token: 0x0400ADE1 RID: 44513
		[OriginalName("ErrRoleChangeInst")]
		ErrRoleChangeInst,
		// Token: 0x0400ADE2 RID: 44514
		[OriginalName("ErrRoleChangeElementFunc")]
		ErrRoleChangeElementFunc,
		// Token: 0x0400ADE3 RID: 44515
		[OriginalName("ErrPhantomFormationCannotJoin")]
		ErrPhantomFormationCannotJoin,
		// Token: 0x0400ADE4 RID: 44516
		[OriginalName("ErrPhantomFormationHost")]
		ErrPhantomFormationHost,
		// Token: 0x0400ADE5 RID: 44517
		[OriginalName("ErrRoleChangeShowAllRole")]
		ErrRoleChangeShowAllRole,
		// Token: 0x0400ADE6 RID: 44518
		[OriginalName("ErrInteractBoardEntityNotFound")]
		ErrInteractBoardEntityNotFound,
		// Token: 0x0400ADE7 RID: 44519
		[OriginalName("ErrInteractBoardRange")]
		ErrInteractBoardRange,
		// Token: 0x0400ADE8 RID: 44520
		[OriginalName("ErrInteractBoardSystemNotFound")]
		ErrInteractBoardSystemNotFound,
		// Token: 0x0400ADE9 RID: 44521
		[OriginalName("ErrInteractBoardEntityConfig")]
		ErrInteractBoardEntityConfig,
		// Token: 0x0400ADEA RID: 44522
		[OriginalName("ErrInteractEntranceNotFound")]
		ErrInteractEntranceNotFound,
		// Token: 0x0400ADEB RID: 44523
		[OriginalName("ErrInteractEntranceNotMatch")]
		ErrInteractEntranceNotMatch,
		// Token: 0x0400ADEC RID: 44524
		[OriginalName("ErrItemMaxUseCount")]
		ErrItemMaxUseCount,
		// Token: 0x0400ADED RID: 44525
		[OriginalName("ErrFuncNotExist")]
		ErrFuncNotExist,
		// Token: 0x0400ADEE RID: 44526
		[OriginalName("ErrPhantomChangeInBattle")]
		ErrPhantomChangeInBattle,
		// Token: 0x0400ADEF RID: 44527
		[OriginalName("ErrItemCanNotDestroy")]
		ErrItemCanNotDestroy,
		// Token: 0x0400ADF0 RID: 44528
		[OriginalName("ErrPhantomEquipSourceCost")]
		ErrPhantomEquipSourceCost,
		// Token: 0x0400ADF1 RID: 44529
		[OriginalName("ErrPhantomEquipTargetCost")]
		ErrPhantomEquipTargetCost,
		// Token: 0x0400ADF2 RID: 44530
		[OriginalName("ErrPhantomEquipDuplicate")]
		ErrPhantomEquipDuplicate,
		// Token: 0x0400ADF3 RID: 44531
		[OriginalName("ErrPhantomAutoEquipFromOther")]
		ErrPhantomAutoEquipFromOther,
		// Token: 0x0400ADF4 RID: 44532
		[OriginalName("ErrPhantomConsumeItemCount")]
		ErrPhantomConsumeItemCount,
		// Token: 0x0400ADF5 RID: 44533
		[OriginalName("ErrPhantomConsumeItemDuplicate")]
		ErrPhantomConsumeItemDuplicate,
		// Token: 0x0400ADF6 RID: 44534
		[OriginalName("ErrPhantomConsumeItemIncrDuplicate")]
		ErrPhantomConsumeItemIncrDuplicate,
		// Token: 0x0400ADF7 RID: 44535
		[OriginalName("ErrPhantomConsumeItem")]
		ErrPhantomConsumeItem,
		// Token: 0x0400ADF8 RID: 44536
		[OriginalName("ErrPhantomConsumeNoExp")]
		ErrPhantomConsumeNoExp,
		// Token: 0x0400ADF9 RID: 44537
		[OriginalName("ErrPhantomBreachPos")]
		ErrPhantomBreachPos,
		// Token: 0x0400ADFA RID: 44538
		[OriginalName("ErrPhantomBreachSuspend")]
		ErrPhantomBreachSuspend,
		// Token: 0x0400ADFB RID: 44539
		[OriginalName("ErrPhantomBreachQuality")]
		ErrPhantomBreachQuality,
		// Token: 0x0400ADFC RID: 44540
		[OriginalName("ErrPhantomBreachExp")]
		ErrPhantomBreachExp,
		// Token: 0x0400ADFD RID: 44541
		[OriginalName("ErrPhantomBreachConsumeItem")]
		ErrPhantomBreachConsumeItem,
		// Token: 0x0400ADFE RID: 44542
		[OriginalName("ErrPhantomBreachNoSuspend")]
		ErrPhantomBreachNoSuspend,
		// Token: 0x0400ADFF RID: 44543
		[OriginalName("ErrPhantomSpecialSkillRole")]
		ErrPhantomSpecialSkillRole,
		// Token: 0x0400AE00 RID: 44544
		[OriginalName("ErrPhantomNotEquip")]
		ErrPhantomNotEquip,
		// Token: 0x0400AE01 RID: 44545
		[OriginalName("ErrPhantomSpecilSkillPos")]
		ErrPhantomSpecilSkillPos,
		// Token: 0x0400AE02 RID: 44546
		[OriginalName("ErrPhantomSubPropPlanConfig")]
		ErrPhantomSubPropPlanConfig,
		// Token: 0x0400AE03 RID: 44547
		[OriginalName("ErrPhantomMainPropGenFail")]
		ErrPhantomMainPropGenFail,
		// Token: 0x0400AE04 RID: 44548
		[OriginalName("ErrLivenessFuncNotOpen")]
		ErrLivenessFuncNotOpen,
		// Token: 0x0400AE05 RID: 44549
		[OriginalName("ErrLivenessTaskNotFound")]
		ErrLivenessTaskNotFound,
		// Token: 0x0400AE06 RID: 44550
		[OriginalName("ErrLivenessTaskDataNotFound")]
		ErrLivenessTaskDataNotFound,
		// Token: 0x0400AE07 RID: 44551
		[OriginalName("ErrLivenessTaskNotFinish")]
		ErrLivenessTaskNotFinish,
		// Token: 0x0400AE08 RID: 44552
		[OriginalName("ErrLivenessTaskRewarded")]
		ErrLivenessTaskRewarded,
		// Token: 0x0400AE09 RID: 44553
		[OriginalName("ErrLivenessRewardNotFound")]
		ErrLivenessRewardNotFound,
		// Token: 0x0400AE0A RID: 44554
		[OriginalName("ErrLivenessGoalNotReach")]
		ErrLivenessGoalNotReach,
		// Token: 0x0400AE0B RID: 44555
		[OriginalName("ErrLivenessRewardParam")]
		ErrLivenessRewardParam,
		// Token: 0x0400AE0C RID: 44556
		[OriginalName("ErrLivenessTaskRewardParam")]
		ErrLivenessTaskRewardParam,
		// Token: 0x0400AE0D RID: 44557
		[OriginalName("ErrWeaponLevelUpComsumeCount")]
		ErrWeaponLevelUpComsumeCount,
		// Token: 0x0400AE0E RID: 44558
		[OriginalName("ErrWeaponConsumeSelf")]
		ErrWeaponConsumeSelf,
		// Token: 0x0400AE0F RID: 44559
		[OriginalName("ErrWeaponConsumeItemNotFound")]
		ErrWeaponConsumeItemNotFound,
		// Token: 0x0400AE10 RID: 44560
		[OriginalName("ErrWeaponConsumeItemIdNotFound")]
		ErrWeaponConsumeItemIdNotFound,
		// Token: 0x0400AE11 RID: 44561
		[OriginalName("ErrWeaponLocked")]
		ErrWeaponLocked,
		// Token: 0x0400AE12 RID: 44562
		[OriginalName("ErrWeaponConsumeDuplicate")]
		ErrWeaponConsumeDuplicate,
		// Token: 0x0400AE13 RID: 44563
		[OriginalName("ErrWeaponEquiped")]
		ErrWeaponEquiped,
		// Token: 0x0400AE14 RID: 44564
		[OriginalName("ErrWeaponLevelUpItemDuplicate")]
		ErrWeaponLevelUpItemDuplicate,
		// Token: 0x0400AE15 RID: 44565
		[OriginalName("ErrWeaponLevelUpNoExp")]
		ErrWeaponLevelUpNoExp,
		// Token: 0x0400AE16 RID: 44566
		[OriginalName("ErrWeaponLevelUpLevel")]
		ErrWeaponLevelUpLevel,
		// Token: 0x0400AE17 RID: 44567
		[OriginalName("ErrPhantomMainPropNotMatch")]
		ErrPhantomMainPropNotMatch,
		// Token: 0x0400AE18 RID: 44568
		[OriginalName("ErrPhantomSubPropNotMatch")]
		ErrPhantomSubPropNotMatch,
		// Token: 0x0400AE19 RID: 44569
		[OriginalName("ErrPhantomEquiped")]
		ErrPhantomEquiped,
		// Token: 0x0400AE1A RID: 44570
		[OriginalName("ErrAdviceNotInit")]
		ErrAdviceNotInit,
		// Token: 0x0400AE1B RID: 44571
		[OriginalName("ErrTowerChallengeNotOpen")]
		ErrTowerChallengeNotOpen,
		// Token: 0x0400AE1C RID: 44572
		[OriginalName("ErrTowerNotInChallenge")]
		ErrTowerNotInChallenge,
		// Token: 0x0400AE1D RID: 44573
		[OriginalName("ErrTowerConfigNotFound")]
		ErrTowerConfigNotFound,
		// Token: 0x0400AE1E RID: 44574
		[OriginalName("ErrTowerChallengeNotInOpenTime")]
		ErrTowerChallengeNotInOpenTime,
		// Token: 0x0400AE1F RID: 44575
		[OriginalName("ErrTowerInChallenge")]
		ErrTowerInChallenge,
		// Token: 0x0400AE20 RID: 44576
		[OriginalName("ErrTowerFormationCount")]
		ErrTowerFormationCount,
		// Token: 0x0400AE21 RID: 44577
		[OriginalName("ErrTowerFormationRoleDuplicate")]
		ErrTowerFormationRoleDuplicate,
		// Token: 0x0400AE22 RID: 44578
		[OriginalName("ErrTowerRoleCost")]
		ErrTowerRoleCost,
		// Token: 0x0400AE23 RID: 44579
		[OriginalName("ErrTowerDifficultyNotClear")]
		ErrTowerDifficultyNotClear,
		// Token: 0x0400AE24 RID: 44580
		[OriginalName("ErrTowerFloorNotClear")]
		ErrTowerFloorNotClear,
		// Token: 0x0400AE25 RID: 44581
		[OriginalName("ErrTowerAreaNotClear")]
		ErrTowerAreaNotClear,
		// Token: 0x0400AE26 RID: 44582
		[OriginalName("ErrTowerRecommendNotSettle")]
		ErrTowerRecommendNotSettle,
		// Token: 0x0400AE27 RID: 44583
		[OriginalName("ErrTowerRewardNotFound")]
		ErrTowerRewardNotFound,
		// Token: 0x0400AE28 RID: 44584
		[OriginalName("ErrTowerNoReward")]
		ErrTowerNoReward,
		// Token: 0x0400AE29 RID: 44585
		[OriginalName("ErrTowerRewarded")]
		ErrTowerRewarded,
		// Token: 0x0400AE2A RID: 44586
		[OriginalName("ErrTowerRewardTarget")]
		ErrTowerRewardTarget,
		// Token: 0x0400AE2B RID: 44587
		[OriginalName("ErrTowerSeasonUpdate")]
		ErrTowerSeasonUpdate,
		// Token: 0x0400AE2C RID: 44588
		[OriginalName("ErrLordGymConfigNotFound")]
		ErrLordGymConfigNotFound,
		// Token: 0x0400AE2D RID: 44589
		[OriginalName("ErrLordGymNotInPlay")]
		ErrLordGymNotInPlay,
		// Token: 0x0400AE2E RID: 44590
		[OriginalName("ErrLordGymLock")]
		ErrLordGymLock,
		// Token: 0x0400AE2F RID: 44591
		[OriginalName("ErrLordGymBtTreeNotFound")]
		ErrLordGymBtTreeNotFound,
		// Token: 0x0400AE30 RID: 44592
		[OriginalName("ErrRoleSexFuncNotOpen")]
		ErrRoleSexFuncNotOpen,
		// Token: 0x0400AE31 RID: 44593
		[OriginalName("ErrPhantomSubPropLocked")]
		ErrPhantomSubPropLocked,
		// Token: 0x0400AE32 RID: 44594
		[OriginalName("ErrPhantomIdentifyNoCost")]
		ErrPhantomIdentifyNoCost,
		// Token: 0x0400AE33 RID: 44595
		[OriginalName("ErrGiftPackType")]
		ErrGiftPackType,
		// Token: 0x0400AE34 RID: 44596
		[OriginalName("ErrGiftPackUseLimit")]
		ErrGiftPackUseLimit,
		// Token: 0x0400AE35 RID: 44597
		[OriginalName("ErrCdKeyNotEnable")]
		ErrCdKeyNotEnable,
		// Token: 0x0400AE36 RID: 44598
		[OriginalName("ErrCdKeyRequestCount")]
		ErrCdKeyRequestCount,
		// Token: 0x0400AE37 RID: 44599
		[OriginalName("ErrCdKeyRequestErr")]
		ErrCdKeyRequestErr,
		// Token: 0x0400AE38 RID: 44600
		[OriginalName("ErrCdKeyRequestDataErr")]
		ErrCdKeyRequestDataErr,
		// Token: 0x0400AE39 RID: 44601
		[OriginalName("ErrCdKeyException")]
		ErrCdKeyException,
		// Token: 0x0400AE3A RID: 44602
		[OriginalName("ErrCdKeyProcessCount")]
		ErrCdKeyProcessCount,
		// Token: 0x0400AE3B RID: 44603
		[OriginalName("ErrCdKeyNotFound")]
		ErrCdKeyNotFound,
		// Token: 0x0400AE3C RID: 44604
		[OriginalName("ErrCdKeyBatchNotFound")]
		ErrCdKeyBatchNotFound,
		// Token: 0x0400AE3D RID: 44605
		[OriginalName("ErrCdKeyNotInValidTime")]
		ErrCdKeyNotInValidTime,
		// Token: 0x0400AE3E RID: 44606
		[OriginalName("ErrCdKeyBatchMaxCount")]
		ErrCdKeyBatchMaxCount,
		// Token: 0x0400AE3F RID: 44607
		[OriginalName("ErrCdKeyEachPlayerMaxCount")]
		ErrCdKeyEachPlayerMaxCount,
		// Token: 0x0400AE40 RID: 44608
		[OriginalName("ErrCdKeyGroupCount")]
		ErrCdKeyGroupCount,
		// Token: 0x0400AE41 RID: 44609
		[OriginalName("ErrCdKeyCondition")]
		ErrCdKeyCondition,
		// Token: 0x0400AE42 RID: 44610
		[OriginalName("ErrCdKeyAddCountFail")]
		ErrCdKeyAddCountFail,
		// Token: 0x0400AE43 RID: 44611
		[OriginalName("ErrCdKeyLength")]
		ErrCdKeyLength,
		// Token: 0x0400AE44 RID: 44612
		[OriginalName("ErrCdKeyCharacter")]
		ErrCdKeyCharacter,
		// Token: 0x0400AE45 RID: 44613
		[OriginalName("ErrGiftPackRandomErr")]
		ErrGiftPackRandomErr,
		// Token: 0x0400AE46 RID: 44614
		[OriginalName("ErrReconnectUserWhiteList")]
		ErrReconnectUserWhiteList,
		// Token: 0x0400AE47 RID: 44615
		[OriginalName("ErrReconnectChannelWhiteList")]
		ErrReconnectChannelWhiteList,
		// Token: 0x0400AE48 RID: 44616
		[OriginalName("ErrReconnectIpInvalid")]
		ErrReconnectIpInvalid,
		// Token: 0x0400AE49 RID: 44617
		[OriginalName("ErrReconnectIpWhiteList")]
		ErrReconnectIpWhiteList,
		// Token: 0x0400AE4A RID: 44618
		[OriginalName("ErrCdKeyExpire")]
		ErrCdKeyExpire,
		// Token: 0x0400AE4B RID: 44619
		[OriginalName("ErrWeaponResonLevelLimit")]
		ErrWeaponResonLevelLimit,
		// Token: 0x0400AE4C RID: 44620
		[OriginalName("ErrWeaponConfigNotFound")]
		ErrWeaponConfigNotFound,
		// Token: 0x0400AE4D RID: 44621
		[OriginalName("ErrWeaponResonConfigNotFound")]
		ErrWeaponResonConfigNotFound,
		// Token: 0x0400AE4E RID: 44622
		[OriginalName("ErrWeaponResonConsumeItem")]
		ErrWeaponResonConsumeItem,
		// Token: 0x0400AE4F RID: 44623
		[OriginalName("ErrWeaponResonConsumeGold")]
		ErrWeaponResonConsumeGold,
		// Token: 0x0400AE50 RID: 44624
		[OriginalName("ErrDestroyItemDuplicate")]
		ErrDestroyItemDuplicate,
		// Token: 0x0400AE51 RID: 44625
		[OriginalName("ErrDestroyWeapon")]
		ErrDestroyWeapon,
		// Token: 0x0400AE52 RID: 44626
		[OriginalName("ErrCannotDestroyItem")]
		ErrCannotDestroyItem,
		// Token: 0x0400AE53 RID: 44627
		[OriginalName("ErrCannotDestroyPhantom")]
		ErrCannotDestroyPhantom,
		// Token: 0x0400AE54 RID: 44628
		[OriginalName("ErrCannotDestroyWeaponForm")]
		ErrCannotDestroyWeaponForm,
		// Token: 0x0400AE55 RID: 44629
		[OriginalName("ErrCannotDestroyItemUnknown")]
		ErrCannotDestroyItemUnknown,
		// Token: 0x0400AE56 RID: 44630
		[OriginalName("ErrWeaponConsumeQuality")]
		ErrWeaponConsumeQuality,
		// Token: 0x0400AE57 RID: 44631
		[OriginalName("ErrPhantomSkinChangeCd")]
		ErrPhantomSkinChangeCd,
		// Token: 0x0400AE58 RID: 44632
		[OriginalName("ErrPhantomSkinUnlock")]
		ErrPhantomSkinUnlock,
		// Token: 0x0400AE59 RID: 44633
		[OriginalName("ErrPhantomSkinMatch")]
		ErrPhantomSkinMatch,
		// Token: 0x0400AE5A RID: 44634
		[OriginalName("ErrLoginGameTainted")]
		ErrLoginGameTainted,
		// Token: 0x0400AE5B RID: 44635
		[OriginalName("ErrCookLimitCount")]
		ErrCookLimitCount,
		// Token: 0x0400AE5C RID: 44636
		[OriginalName("ErrCookLimitTime")]
		ErrCookLimitTime,
		// Token: 0x0400AE5D RID: 44637
		[OriginalName("ErrForgeLimitCount")]
		ErrForgeLimitCount,
		// Token: 0x0400AE5E RID: 44638
		[OriginalName("ErrForgeLimitTime")]
		ErrForgeLimitTime,
		// Token: 0x0400AE5F RID: 44639
		[OriginalName("ErrSynthesisLimitCount")]
		ErrSynthesisLimitCount,
		// Token: 0x0400AE60 RID: 44640
		[OriginalName("ErrSynthesisLimitTime")]
		ErrSynthesisLimitTime,
		// Token: 0x0400AE61 RID: 44641
		[OriginalName("ErrLoginIpBan")]
		ErrLoginIpBan,
		// Token: 0x0400AE62 RID: 44642
		[OriginalName("ErrLoginDeviceBan")]
		ErrLoginDeviceBan,
		// Token: 0x0400AE63 RID: 44643
		[OriginalName("ErrRoleNameEmpty")]
		ErrRoleNameEmpty,
		// Token: 0x0400AE64 RID: 44644
		[OriginalName("ErrAdviceLength")]
		ErrAdviceLength,
		// Token: 0x0400AE65 RID: 44645
		[OriginalName("ErrPhantomRefiningCount")]
		ErrPhantomRefiningCount,
		// Token: 0x0400AE66 RID: 44646
		[OriginalName("ErrPhantomRefiningScore")]
		ErrPhantomRefiningScore,
		// Token: 0x0400AE67 RID: 44647
		[OriginalName("ErrPhantomRefiningTotalScore")]
		ErrPhantomRefiningTotalScore,
		// Token: 0x0400AE68 RID: 44648
		[OriginalName("ErrPhantomRefiningDeveloped")]
		ErrPhantomRefiningDeveloped,
		// Token: 0x0400AE69 RID: 44649
		[OriginalName("ErrPhotoMemoryCollectConfig")]
		ErrPhotoMemoryCollectConfig,
		// Token: 0x0400AE6A RID: 44650
		[OriginalName("ErrPhotoMemoryFuncNotOpen")]
		ErrPhotoMemoryFuncNotOpen,
		// Token: 0x0400AE6B RID: 44651
		[OriginalName("ErrPhotoMemoryCollectLock")]
		ErrPhotoMemoryCollectLock,
		// Token: 0x0400AE6C RID: 44652
		[OriginalName("ErrPhotoMemoryCollectRewarded")]
		ErrPhotoMemoryCollectRewarded,
		// Token: 0x0400AE6D RID: 44653
		[OriginalName("ErrRoleCount")]
		ErrRoleCount,
		// Token: 0x0400AE6E RID: 44654
		[OriginalName("ErrCookFormulaUnlocked")]
		ErrCookFormulaUnlocked,
		// Token: 0x0400AE6F RID: 44655
		[OriginalName("ErrForgeFormulaUnlocked")]
		ErrForgeFormulaUnlocked,
		// Token: 0x0400AE70 RID: 44656
		[OriginalName("ErrSynthesisFormulaUnlocked")]
		ErrSynthesisFormulaUnlocked,
		// Token: 0x0400AE71 RID: 44657
		[OriginalName("ErrCookFormulaBuyCount")]
		ErrCookFormulaBuyCount,
		// Token: 0x0400AE72 RID: 44658
		[OriginalName("ErrForgeFormulaBuyCount")]
		ErrForgeFormulaBuyCount,
		// Token: 0x0400AE73 RID: 44659
		[OriginalName("ErrSynthesisFormulaBuyCount")]
		ErrSynthesisFormulaBuyCount,
		// Token: 0x0400AE74 RID: 44660
		[OriginalName("ErrCdKeyDailyVerifyCount")]
		ErrCdKeyDailyVerifyCount,
		// Token: 0x0400AE75 RID: 44661
		[OriginalName("ErrLongShanTaskNotFound")]
		ErrLongShanTaskNotFound,
		// Token: 0x0400AE76 RID: 44662
		[OriginalName("ErrLongShanActivityClosed")]
		ErrLongShanActivityClosed,
		// Token: 0x0400AE77 RID: 44663
		[OriginalName("ErrLongShanTaskNotAccept")]
		ErrLongShanTaskNotAccept,
		// Token: 0x0400AE78 RID: 44664
		[OriginalName("ErrLongShanTaskNotComplete")]
		ErrLongShanTaskNotComplete,
		// Token: 0x0400AE79 RID: 44665
		[OriginalName("ErrLongShanTaskRewarded")]
		ErrLongShanTaskRewarded,
		// Token: 0x0400AE7A RID: 44666
		[OriginalName("ErrTowerDefenceRewardParamErr")]
		ErrTowerDefenceRewardParamErr,
		// Token: 0x0400AE7B RID: 44667
		[OriginalName("ErrTowerDefenceInstanceNotFound")]
		ErrTowerDefenceInstanceNotFound,
		// Token: 0x0400AE7C RID: 44668
		[OriginalName("ErrTowerDefenceActivityNotOpen")]
		ErrTowerDefenceActivityNotOpen,
		// Token: 0x0400AE7D RID: 44669
		[OriginalName("ErrTowerDefenceActivityDataNotFound")]
		ErrTowerDefenceActivityDataNotFound,
		// Token: 0x0400AE7E RID: 44670
		[OriginalName("ErrTowerDefenceInstDataNotFound")]
		ErrTowerDefenceInstDataNotFound,
		// Token: 0x0400AE7F RID: 44671
		[OriginalName("ErrTowerDefenceInstRewarded")]
		ErrTowerDefenceInstRewarded,
		// Token: 0x0400AE80 RID: 44672
		[OriginalName("ErrTowerDefenceInstScoreNotEnough")]
		ErrTowerDefenceInstScoreNotEnough,
		// Token: 0x0400AE81 RID: 44673
		[OriginalName("ErrTowerDefenceScoreRewarded")]
		ErrTowerDefenceScoreRewarded,
		// Token: 0x0400AE82 RID: 44674
		[OriginalName("ErrTowerDefenceScoreRewardNotEnough")]
		ErrTowerDefenceScoreRewardNotEnough,
		// Token: 0x0400AE83 RID: 44675
		[OriginalName("ErrTowerDefenceScoreRewardNotFound")]
		ErrTowerDefenceScoreRewardNotFound,
		// Token: 0x0400AE84 RID: 44676
		[OriginalName("ErrTowerDefenceInstBuffNotEnable")]
		ErrTowerDefenceInstBuffNotEnable,
		// Token: 0x0400AE85 RID: 44677
		[OriginalName("ErrTowerDefencePhantomDuplicate")]
		ErrTowerDefencePhantomDuplicate,
		// Token: 0x0400AE86 RID: 44678
		[OriginalName("ErrTowerDefencePhantomNotSelect")]
		ErrTowerDefencePhantomNotSelect,
		// Token: 0x0400AE87 RID: 44679
		[OriginalName("ErrorTowerDefenceInstNotOpen")]
		ErrorTowerDefenceInstNotOpen,
		// Token: 0x0400AE88 RID: 44680
		[OriginalName("ErrorTowerDefenceInstCondition")]
		ErrorTowerDefenceInstCondition,
		// Token: 0x0400AE89 RID: 44681
		[OriginalName("ErrNameModifyCd")]
		ErrNameModifyCd,
		// Token: 0x0400AE8A RID: 44682
		[OriginalName("ErrNameVerifying")]
		ErrNameVerifying,
		// Token: 0x0400AE8B RID: 44683
		[OriginalName("ErrTimePointRewardActivityConfigNotFound")]
		ErrTimePointRewardActivityConfigNotFound,
		// Token: 0x0400AE8C RID: 44684
		[OriginalName("ErrTimePointRewardActivityNotOpen")]
		ErrTimePointRewardActivityNotOpen,
		// Token: 0x0400AE8D RID: 44685
		[OriginalName("ErrTimePointRewardActivityRewarded")]
		ErrTimePointRewardActivityRewarded,
		// Token: 0x0400AE8E RID: 44686
		[OriginalName("ErrTimePointRewardActivityTime")]
		ErrTimePointRewardActivityTime,
		// Token: 0x0400AE8F RID: 44687
		[OriginalName("ErrCDKeyVerifying")]
		ErrCdkeyVerifying,
		// Token: 0x0400AE90 RID: 44688
		[OriginalName("ErrorTowerDefenceInstLocked")]
		ErrorTowerDefenceInstLocked,
		// Token: 0x0400AE91 RID: 44689
		[OriginalName("ErrTrackMoonEntrustLocked")]
		ErrTrackMoonEntrustLocked,
		// Token: 0x0400AE92 RID: 44690
		[OriginalName("ErrTrackMoonRoleLocked")]
		ErrTrackMoonRoleLocked,
		// Token: 0x0400AE93 RID: 44691
		[OriginalName("ErrTrackMoonBuildLocked")]
		ErrTrackMoonBuildLocked,
		// Token: 0x0400AE94 RID: 44692
		[OriginalName("ErrTrackMoonBuildEntity")]
		ErrTrackMoonBuildEntity,
		// Token: 0x0400AE95 RID: 44693
		[OriginalName("ErrCopyUserRequestErr")]
		ErrCopyUserRequestErr,
		// Token: 0x0400AE96 RID: 44694
		[OriginalName("ErrCopyUserInserting")]
		ErrCopyUserInserting,
		// Token: 0x0400AE97 RID: 44695
		[OriginalName("ErrCopyUserErr")]
		ErrCopyUserErr,
		// Token: 0x0400AE98 RID: 44696
		[OriginalName("ErrCopyUserDataErr")]
		ErrCopyUserDataErr,
		// Token: 0x0400AE99 RID: 44697
		[OriginalName("ErrCopyUserInsertErr")]
		ErrCopyUserInsertErr,
		// Token: 0x0400AE9A RID: 44698
		[OriginalName("ErrCopyUserInsertFailed")]
		ErrCopyUserInsertFailed,
		// Token: 0x0400AE9B RID: 44699
		[OriginalName("ErrRiskHarvestBuffGroupNotFound")]
		ErrRiskHarvestBuffGroupNotFound,
		// Token: 0x0400AE9C RID: 44700
		[OriginalName("ErrRiskHarvestActivityClosePlay")]
		ErrRiskHarvestActivityClosePlay,
		// Token: 0x0400AE9D RID: 44701
		[OriginalName("ErrRiskHarvestModeChangeClosePlay")]
		ErrRiskHarvestModeChangeClosePlay,
		// Token: 0x0400AE9E RID: 44702
		[OriginalName("ErrRiskHarvestLeaveClosePlay")]
		ErrRiskHarvestLeaveClosePlay,
		// Token: 0x0400AE9F RID: 44703
		[OriginalName("ErrRiskHarvestInstNotFound")]
		ErrRiskHarvestInstNotFound,
		// Token: 0x0400AEA0 RID: 44704
		[OriginalName("ErrRiskHarvestActivityNotOpen")]
		ErrRiskHarvestActivityNotOpen,
		// Token: 0x0400AEA1 RID: 44705
		[OriginalName("ErrRiskHarvestInstDataNotFound")]
		ErrRiskHarvestInstDataNotFound,
		// Token: 0x0400AEA2 RID: 44706
		[OriginalName("ErrRiskHarvestInstRewarded")]
		ErrRiskHarvestInstRewarded,
		// Token: 0x0400AEA3 RID: 44707
		[OriginalName("ErrRiskHarvestInstNotPass")]
		ErrRiskHarvestInstNotPass,
		// Token: 0x0400AEA4 RID: 44708
		[OriginalName("ErrRiskHarvestScoreRewardNotFound")]
		ErrRiskHarvestScoreRewardNotFound,
		// Token: 0x0400AEA5 RID: 44709
		[OriginalName("ErrRiskHarvestScoreRewarded")]
		ErrRiskHarvestScoreRewarded,
		// Token: 0x0400AEA6 RID: 44710
		[OriginalName("ErrRiskHarvestScoreNotEnough")]
		ErrRiskHarvestScoreNotEnough,
		// Token: 0x0400AEA7 RID: 44711
		[OriginalName("ErrRiskHarvestRoleTrial")]
		ErrRiskHarvestRoleTrial,
		// Token: 0x0400AEA8 RID: 44712
		[OriginalName("ErrRiskHarvestMatching")]
		ErrRiskHarvestMatching,
		// Token: 0x0400AEA9 RID: 44713
		[OriginalName("ErrRiskHarvestNotDefaultWorld")]
		ErrRiskHarvestNotDefaultWorld,
		// Token: 0x0400AEAA RID: 44714
		[OriginalName("ErrRiskHarvestMultiMode")]
		ErrRiskHarvestMultiMode,
		// Token: 0x0400AEAB RID: 44715
		[OriginalName("ErrRiskHarvestInstLocked")]
		ErrRiskHarvestInstLocked,
		// Token: 0x0400AEAC RID: 44716
		[OriginalName("ErrRiskHarvestInstTeleportEntityNotFound")]
		ErrRiskHarvestInstTeleportEntityNotFound,
		// Token: 0x0400AEAD RID: 44717
		[OriginalName("ErrRiskHarvestInstOpen")]
		ErrRiskHarvestInstOpen,
		// Token: 0x0400AEAE RID: 44718
		[OriginalName("ErrRiskHarvestPlayOpenFailed")]
		ErrRiskHarvestPlayOpenFailed,
		// Token: 0x0400AEAF RID: 44719
		[OriginalName("ErrRiskHarvestPlayDataNotFound")]
		ErrRiskHarvestPlayDataNotFound,
		// Token: 0x0400AEB0 RID: 44720
		[OriginalName("ErrRiskHarvestBuffNoReward")]
		ErrRiskHarvestBuffNoReward,
		// Token: 0x0400AEB1 RID: 44721
		[OriginalName("ErrRiskHarvestBuffRewarded")]
		ErrRiskHarvestBuffRewarded,
		// Token: 0x0400AEB2 RID: 44722
		[OriginalName("ErrRiskHarvestBuffLocked")]
		ErrRiskHarvestBuffLocked,
		// Token: 0x0400AEB3 RID: 44723
		[OriginalName("ErrRiskHarvestBuffCountRewardNotFound")]
		ErrRiskHarvestBuffCountRewardNotFound,
		// Token: 0x0400AEB4 RID: 44724
		[OriginalName("ErrRiskHarvestBuffCountRewarded")]
		ErrRiskHarvestBuffCountRewarded,
		// Token: 0x0400AEB5 RID: 44725
		[OriginalName("ErrRiskHarvestBuffCountNotEnough")]
		ErrRiskHarvestBuffCountNotEnough,
		// Token: 0x0400AEB6 RID: 44726
		[OriginalName("ErrRiskHarvestInstScoreNotEnough")]
		ErrRiskHarvestInstScoreNotEnough,
		// Token: 0x0400AEB7 RID: 44727
		[OriginalName("ErrItemDisuseLimit")]
		ErrItemDisuseLimit,
		// Token: 0x0400AEB8 RID: 44728
		[OriginalName("ErrItemDisuseFunc")]
		ErrItemDisuseFunc,
		// Token: 0x0400AEB9 RID: 44729
		[OriginalName("ErrPhantomRefiningMaxCount")]
		ErrPhantomRefiningMaxCount,
		// Token: 0x0400AEBA RID: 44730
		[OriginalName("ErrPhantomRefiningDulplicate")]
		ErrPhantomRefiningDulplicate,
		// Token: 0x0400AEBB RID: 44731
		[OriginalName("ErrPhantomNotNormal")]
		ErrPhantomNotNormal,
		// Token: 0x0400AEBC RID: 44732
		[OriginalName("ErrGetSelfPsnOnlineId")]
		ErrGetSelfPsnOnlineId,
		// Token: 0x0400AEBD RID: 44733
		[OriginalName("ErrGetPsnUserPlayerErr")]
		ErrGetPsnUserPlayerErr,
		// Token: 0x0400AEBE RID: 44734
		[OriginalName("ErrTowerDefenceHostLeave")]
		ErrTowerDefenceHostLeave,
		// Token: 0x0400AEBF RID: 44735
		[OriginalName("ErrRiskHarvestNotInInst")]
		ErrRiskHarvestNotInInst,
		// Token: 0x0400AEC0 RID: 44736
		[OriginalName("ErrEnterInstTypeErr")]
		ErrEnterInstTypeErr,
		// Token: 0x0400AEC1 RID: 44737
		[OriginalName("ErrInputSettingCount")]
		ErrInputSettingCount,
		// Token: 0x0400AEC2 RID: 44738
		[OriginalName("ErrInputSettingDeviceType")]
		ErrInputSettingDeviceType,
		// Token: 0x0400AEC3 RID: 44739
		[OriginalName("ErrInputSettingActionCount")]
		ErrInputSettingActionCount,
		// Token: 0x0400AEC4 RID: 44740
		[OriginalName("ErrInputSettingAxisCount")]
		ErrInputSettingAxisCount,
		// Token: 0x0400AEC5 RID: 44741
		[OriginalName("ErrInputCombinationActionCount")]
		ErrInputCombinationActionCount,
		// Token: 0x0400AEC6 RID: 44742
		[OriginalName("ErrInputCombinationAxisCount")]
		ErrInputCombinationAxisCount,
		// Token: 0x0400AEC7 RID: 44743
		[OriginalName("ErrInputSettingActionName")]
		ErrInputSettingActionName,
		// Token: 0x0400AEC8 RID: 44744
		[OriginalName("ErrInputSettingAxisName")]
		ErrInputSettingAxisName,
		// Token: 0x0400AEC9 RID: 44745
		[OriginalName("ErrInputCombinationActionName")]
		ErrInputCombinationActionName,
		// Token: 0x0400AECA RID: 44746
		[OriginalName("ErrInputCombinationAxisName")]
		ErrInputCombinationAxisName,
		// Token: 0x0400AECB RID: 44747
		[OriginalName("ErrInputActionKeyNameLength")]
		ErrInputActionKeyNameLength,
		// Token: 0x0400AECC RID: 44748
		[OriginalName("ErrInputActionKeyLength")]
		ErrInputActionKeyLength,
		// Token: 0x0400AECD RID: 44749
		[OriginalName("ErrInputAxisKeyNameLength")]
		ErrInputAxisKeyNameLength,
		// Token: 0x0400AECE RID: 44750
		[OriginalName("ErrInputAxisKeyLength")]
		ErrInputAxisKeyLength,
		// Token: 0x0400AECF RID: 44751
		[OriginalName("ErrInputCombinationActionKeyNameLength")]
		ErrInputCombinationActionKeyNameLength,
		// Token: 0x0400AED0 RID: 44752
		[OriginalName("ErrInputCombinationActionKeyLength")]
		ErrInputCombinationActionKeyLength,
		// Token: 0x0400AED1 RID: 44753
		[OriginalName("ErrInputCombinationActionKeyListLength")]
		ErrInputCombinationActionKeyListLength,
		// Token: 0x0400AED2 RID: 44754
		[OriginalName("ErrInputCombinationAxisKeyNameLength")]
		ErrInputCombinationAxisKeyNameLength,
		// Token: 0x0400AED3 RID: 44755
		[OriginalName("ErrInputCombinationAxisKeyLength")]
		ErrInputCombinationAxisKeyLength,
		// Token: 0x0400AED4 RID: 44756
		[OriginalName("ErrInputCombinationAxisKeyListLength")]
		ErrInputCombinationAxisKeyListLength,
		// Token: 0x0400AED5 RID: 44757
		[OriginalName("ErrInputDeviceSubTypeLength")]
		ErrInputDeviceSubTypeLength,
		// Token: 0x0400AED6 RID: 44758
		[OriginalName("ErrPSNAccountBlocked")]
		ErrPsnaccountBlocked,
		// Token: 0x0400AED7 RID: 44759
		[OriginalName("ErrRoleNameInvalid")]
		ErrRoleNameInvalid,
		// Token: 0x0400AED8 RID: 44760
		[OriginalName("ErrMailBindRewardNotBind")]
		ErrMailBindRewardNotBind,
		// Token: 0x0400AED9 RID: 44761
		[OriginalName("ErrMailBindRewarded")]
		ErrMailBindRewarded,
		// Token: 0x0400AEDA RID: 44762
		[OriginalName("ErrInputSettingNull")]
		ErrInputSettingNull,
		// Token: 0x0400AEDB RID: 44763
		[OriginalName("ErrMultiInstExchangeCountErr")]
		ErrMultiInstExchangeCountErr,
		// Token: 0x0400AEDC RID: 44764
		[OriginalName("ErrMultiInstExchangeFirstPass")]
		ErrMultiInstExchangeFirstPass,
		// Token: 0x0400AEDD RID: 44765
		[OriginalName("ErrMultiInstExchangeActivity")]
		ErrMultiInstExchangeActivity,
		// Token: 0x0400AEDE RID: 44766
		[OriginalName("ErrMultiInstExchangeFuncNotOpen")]
		ErrMultiInstExchangeFuncNotOpen,
		// Token: 0x0400AEDF RID: 44767
		[OriginalName("ErrMultiInstExchangeTypeErr")]
		ErrMultiInstExchangeTypeErr,
		// Token: 0x0400AEE0 RID: 44768
		[OriginalName("ErrMultiInstExchangeLevelTypeErr")]
		ErrMultiInstExchangeLevelTypeErr,
		// Token: 0x0400AEE1 RID: 44769
		[OriginalName("ErrRoleSkinLocked")]
		ErrRoleSkinLocked,
		// Token: 0x0400AEE2 RID: 44770
		[OriginalName("ErrRoleSkinConfig")]
		ErrRoleSkinConfig,
		// Token: 0x0400AEE3 RID: 44771
		[OriginalName("ErrRoleSkinNotMatch")]
		ErrRoleSkinNotMatch,
		// Token: 0x0400AEE4 RID: 44772
		[OriginalName("ErrRoleSkinWeaponNotSuit")]
		ErrRoleSkinWeaponNotSuit,
		// Token: 0x0400AEE5 RID: 44773
		[OriginalName("ErrSdkLoginResetByPeer")]
		ErrSdkLoginResetByPeer,
		// Token: 0x0400AEE6 RID: 44774
		[OriginalName("ErrSdkLoginHttpRequestException")]
		ErrSdkLoginHttpRequestException,
		// Token: 0x0400AEE7 RID: 44775
		[OriginalName("ErrSdkLoginTaskTimeout")]
		ErrSdkLoginTaskTimeout,
		// Token: 0x0400AEE8 RID: 44776
		[OriginalName("ErrSdkLoginTaskCanceled")]
		ErrSdkLoginTaskCanceled,
		// Token: 0x0400AEE9 RID: 44777
		[OriginalName("ErrSexChangeCd")]
		ErrSexChangeCd,
		// Token: 0x0400AEEA RID: 44778
		[OriginalName("ErrSexChangeLogout")]
		ErrSexChangeLogout,
		// Token: 0x0400AEEB RID: 44779
		[OriginalName("ErrSexChangeTrialActive")]
		ErrSexChangeTrialActive,
		// Token: 0x0400AEEC RID: 44780
		[OriginalName("ErrLobbyListRequestLimit")]
		ErrLobbyListRequestLimit,
		// Token: 0x0400AEED RID: 44781
		[OriginalName("ErrLobbyQueryPlayerRequestLimit")]
		ErrLobbyQueryPlayerRequestLimit,
		// Token: 0x0400AEEE RID: 44782
		[OriginalName("ErrPlayerBasicInfoRequestLimit")]
		ErrPlayerBasicInfoRequestLimit,
		// Token: 0x0400AEEF RID: 44783
		[OriginalName("ErrBlockPlayerRequestLimit")]
		ErrBlockPlayerRequestLimit,
		// Token: 0x0400AEF0 RID: 44784
		[OriginalName("ErrPsnPlayerInfoRequestLimit")]
		ErrPsnPlayerInfoRequestLimit,
		// Token: 0x0400AEF1 RID: 44785
		[OriginalName("ErrFishingPosInvalidX")]
		ErrFishingPosInvalidX,
		// Token: 0x0400AEF2 RID: 44786
		[OriginalName("ErrFishingPosInvalidY")]
		ErrFishingPosInvalidY,
		// Token: 0x0400AEF3 RID: 44787
		[OriginalName("ErrFishingPosOverlap")]
		ErrFishingPosOverlap,
		// Token: 0x0400AEF4 RID: 44788
		[OriginalName("ErrFishingParamLengthCabinLeft")]
		ErrFishingParamLengthCabinLeft,
		// Token: 0x0400AEF5 RID: 44789
		[OriginalName("ErrFishingParamLengthCabinRight")]
		ErrFishingParamLengthCabinRight,
		// Token: 0x0400AEF6 RID: 44790
		[OriginalName("ErrFishingCabinNotOpen")]
		ErrFishingCabinNotOpen,
		// Token: 0x0400AEF7 RID: 44791
		[OriginalName("ErrFishingCabinNotFound")]
		ErrFishingCabinNotFound,
		// Token: 0x0400AEF8 RID: 44792
		[OriginalName("ErrFishingCountNotMatch")]
		ErrFishingCountNotMatch,
		// Token: 0x0400AEF9 RID: 44793
		[OriginalName("ErrFishingDuplicate")]
		ErrFishingDuplicate,
		// Token: 0x0400AEFA RID: 44794
		[OriginalName("ErrFishingRemoveItemErr")]
		ErrFishingRemoveItemErr,
		// Token: 0x0400AEFB RID: 44795
		[OriginalName("ErrFishingItemNotFound")]
		ErrFishingItemNotFound,
		// Token: 0x0400AEFC RID: 44796
		[OriginalName("ErrFishingCountNotMatchRequest")]
		ErrFishingCountNotMatchRequest,
		// Token: 0x0400AEFD RID: 44797
		[OriginalName("ErrFishingCountNotMatchCabin")]
		ErrFishingCountNotMatchCabin,
		// Token: 0x0400AEFE RID: 44798
		[OriginalName("ErrFishingHandInNotMatch")]
		ErrFishingHandInNotMatch,
		// Token: 0x0400AEFF RID: 44799
		[OriginalName("ErrFishingQuickSellNoItem")]
		ErrFishingQuickSellNoItem,
		// Token: 0x0400AF00 RID: 44800
		[OriginalName("ErrFishingNoQuickSell")]
		ErrFishingNoQuickSell,
		// Token: 0x0400AF01 RID: 44801
		[OriginalName("ErrFishingQuickSellConfig")]
		ErrFishingQuickSellConfig,
		// Token: 0x0400AF02 RID: 44802
		[OriginalName("ErrFishingQuickSellNotFilled")]
		ErrFishingQuickSellNotFilled,
		// Token: 0x0400AF03 RID: 44803
		[OriginalName("ErrFishingQuickSellItemErr")]
		ErrFishingQuickSellItemErr,
		// Token: 0x0400AF04 RID: 44804
		[OriginalName("ErrFishingNoSellItem")]
		ErrFishingNoSellItem,
		// Token: 0x0400AF05 RID: 44805
		[OriginalName("ErrFishingCanNotSell")]
		ErrFishingCanNotSell,
		// Token: 0x0400AF06 RID: 44806
		[OriginalName("ErrFishingItemConfigNotFound")]
		ErrFishingItemConfigNotFound,
		// Token: 0x0400AF07 RID: 44807
		[OriginalName("ErrFishingSellItemDuplicate")]
		ErrFishingSellItemDuplicate,
		// Token: 0x0400AF08 RID: 44808
		[OriginalName("ErrFishingPriceCalFailed")]
		ErrFishingPriceCalFailed,
		// Token: 0x0400AF09 RID: 44809
		[OriginalName("ErrFishingSellCount")]
		ErrFishingSellCount,
		// Token: 0x0400AF0A RID: 44810
		[OriginalName("ErrFishingPointNotOpen")]
		ErrFishingPointNotOpen,
		// Token: 0x0400AF0B RID: 44811
		[OriginalName("ErrFishingPointConfig")]
		ErrFishingPointConfig,
		// Token: 0x0400AF0C RID: 44812
		[OriginalName("ErrFishingPointCount")]
		ErrFishingPointCount,
		// Token: 0x0400AF0D RID: 44813
		[OriginalName("ErrFishingTempCabinMax")]
		ErrFishingTempCabinMax,
		// Token: 0x0400AF0E RID: 44814
		[OriginalName("ErrFishingPointGenFail")]
		ErrFishingPointGenFail,
		// Token: 0x0400AF0F RID: 44815
		[OriginalName("ErrFishingTechLevel")]
		ErrFishingTechLevel,
		// Token: 0x0400AF10 RID: 44816
		[OriginalName("ErrFishingPreNodeLock")]
		ErrFishingPreNodeLock,
		// Token: 0x0400AF11 RID: 44817
		[OriginalName("ErrFishingTechLock")]
		ErrFishingTechLock,
		// Token: 0x0400AF12 RID: 44818
		[OriginalName("ErrFishingTechConfig")]
		ErrFishingTechConfig,
		// Token: 0x0400AF13 RID: 44819
		[OriginalName("ErrFishingLevelMax")]
		ErrFishingLevelMax,
		// Token: 0x0400AF14 RID: 44820
		[OriginalName("ErrFishingSkinConfig")]
		ErrFishingSkinConfig,
		// Token: 0x0400AF15 RID: 44821
		[OriginalName("ErrFishingPortConfig")]
		ErrFishingPortConfig,
		// Token: 0x0400AF16 RID: 44822
		[OriginalName("ErrFishingEntrustConfig")]
		ErrFishingEntrustConfig,
		// Token: 0x0400AF17 RID: 44823
		[OriginalName("ErrFishingEntrustNotAccepted")]
		ErrFishingEntrustNotAccepted,
		// Token: 0x0400AF18 RID: 44824
		[OriginalName("ErrFishingEntrustNotFound")]
		ErrFishingEntrustNotFound,
		// Token: 0x0400AF19 RID: 44825
		[OriginalName("ErrFishingEntrustDestination")]
		ErrFishingEntrustDestination,
		// Token: 0x0400AF1A RID: 44826
		[OriginalName("ErrFishingEntrustItemNotEnough")]
		ErrFishingEntrustItemNotEnough,
		// Token: 0x0400AF1B RID: 44827
		[OriginalName("ErrFishingEntrustItemTotalNotMatch")]
		ErrFishingEntrustItemTotalNotMatch,
		// Token: 0x0400AF1C RID: 44828
		[OriginalName("ErrFishingEntrustDumplicate")]
		ErrFishingEntrustDumplicate,
		// Token: 0x0400AF1D RID: 44829
		[OriginalName("ErrFishingEntrustEmptyItem")]
		ErrFishingEntrustEmptyItem,
		// Token: 0x0400AF1E RID: 44830
		[OriginalName("ErrFishingEntrustItemNotMatch")]
		ErrFishingEntrustItemNotMatch,
		// Token: 0x0400AF1F RID: 44831
		[OriginalName("ErrFishingEntrustRefreshInitial")]
		ErrFishingEntrustRefreshInitial,
		// Token: 0x0400AF20 RID: 44832
		[OriginalName("ErrFishingEntrustRefreshPrice")]
		ErrFishingEntrustRefreshPrice,
		// Token: 0x0400AF21 RID: 44833
		[OriginalName("ErrFishingEntrustNotAcceptable")]
		ErrFishingEntrustNotAcceptable,
		// Token: 0x0400AF22 RID: 44834
		[OriginalName("ErrFishingNotInBigWorld")]
		ErrFishingNotInBigWorld,
		// Token: 0x0400AF23 RID: 44835
		[OriginalName("ErrFishingMultiMode")]
		ErrFishingMultiMode,
		// Token: 0x0400AF24 RID: 44836
		[OriginalName("ErrFishingNotOwner")]
		ErrFishingNotOwner,
		// Token: 0x0400AF25 RID: 44837
		[OriginalName("ErrFishingSkinLock")]
		ErrFishingSkinLock,
		// Token: 0x0400AF26 RID: 44838
		[OriginalName("ErrFishingPortLock")]
		ErrFishingPortLock,
		// Token: 0x0400AF27 RID: 44839
		[OriginalName("ErrFishingCageLock")]
		ErrFishingCageLock,
		// Token: 0x0400AF28 RID: 44840
		[OriginalName("ErrFishingCageConfig")]
		ErrFishingCageConfig,
		// Token: 0x0400AF29 RID: 44841
		[OriginalName("ErrFishingHandInConfig")]
		ErrFishingHandInConfig,
		// Token: 0x0400AF2A RID: 44842
		[OriginalName("ErrFishingHandInCountNotMatch")]
		ErrFishingHandInCountNotMatch,
		// Token: 0x0400AF2B RID: 44843
		[OriginalName("ErrFishingTempPointData")]
		ErrFishingTempPointData,
		// Token: 0x0400AF2C RID: 44844
		[OriginalName("ErrFishingTempPointConfig")]
		ErrFishingTempPointConfig,
		// Token: 0x0400AF2D RID: 44845
		[OriginalName("ErrFishingBombItem")]
		ErrFishingBombItem,
		// Token: 0x0400AF2E RID: 44846
		[OriginalName("ErrFishingBombNoPoint")]
		ErrFishingBombNoPoint,
		// Token: 0x0400AF2F RID: 44847
		[OriginalName("ErrFishingBaitArea")]
		ErrFishingBaitArea,
		// Token: 0x0400AF30 RID: 44848
		[OriginalName("ErrFishingNotSailing")]
		ErrFishingNotSailing,
		// Token: 0x0400AF31 RID: 44849
		[OriginalName("ErrFishingInPort")]
		ErrFishingInPort,
		// Token: 0x0400AF32 RID: 44850
		[OriginalName("ErrFishingInShip")]
		ErrFishingInShip,
		// Token: 0x0400AF33 RID: 44851
		[OriginalName("ErrFishingIllustratedRewardNotFound")]
		ErrFishingIllustratedRewardNotFound,
		// Token: 0x0400AF34 RID: 44852
		[OriginalName("ErrFishingIllustratedRewarded")]
		ErrFishingIllustratedRewarded,
		// Token: 0x0400AF35 RID: 44853
		[OriginalName("ErrFishingIllustratedCondition")]
		ErrFishingIllustratedCondition,
		// Token: 0x0400AF36 RID: 44854
		[OriginalName("ErrFishingTechOutputNotFound")]
		ErrFishingTechOutputNotFound,
		// Token: 0x0400AF37 RID: 44855
		[OriginalName("ErrFishingShipNotFound")]
		ErrFishingShipNotFound,
		// Token: 0x0400AF38 RID: 44856
		[OriginalName("ErrFishingPortTech")]
		ErrFishingPortTech,
		// Token: 0x0400AF39 RID: 44857
		[OriginalName("ErrFishingRemoveFuncNotOpen")]
		ErrFishingRemoveFuncNotOpen,
		// Token: 0x0400AF3A RID: 44858
		[OriginalName("ErrFishingIllustratedFuncNotOpen")]
		ErrFishingIllustratedFuncNotOpen,
		// Token: 0x0400AF3B RID: 44859
		[OriginalName("ErrFishingSellFuncNotOpen")]
		ErrFishingSellFuncNotOpen,
		// Token: 0x0400AF3C RID: 44860
		[OriginalName("ErrFishingTechFuncNotOpen")]
		ErrFishingTechFuncNotOpen,
		// Token: 0x0400AF3D RID: 44861
		[OriginalName("ErrFishingEntrustHandInQuickSell")]
		ErrFishingEntrustHandInQuickSell,
		// Token: 0x0400AF3E RID: 44862
		[OriginalName("ErrActivityPreOpenLock")]
		ErrActivityPreOpenLock,
		// Token: 0x0400AF3F RID: 44863
		[OriginalName("ErrActivityShowLock")]
		ErrActivityShowLock,
		// Token: 0x0400AF40 RID: 44864
		[OriginalName("ErrShopGoodsVisibleCondition")]
		ErrShopGoodsVisibleCondition,
		// Token: 0x0400AF41 RID: 44865
		[OriginalName("ErrShopGoodsDisableCondition")]
		ErrShopGoodsDisableCondition,
		// Token: 0x0400AF42 RID: 44866
		[OriginalName("ErrFishingEntrustRefreshFail")]
		ErrFishingEntrustRefreshFail,
		// Token: 0x0400AF43 RID: 44867
		[OriginalName("ErrPlayerDataVersion")]
		ErrPlayerDataVersion,
		// Token: 0x0400AF44 RID: 44868
		[OriginalName("ErrBrokenCircuitRejected")]
		ErrBrokenCircuitRejected,
		// Token: 0x0400AF45 RID: 44869
		[OriginalName("ErrRateLimiterRejected")]
		ErrRateLimiterRejected,
		// Token: 0x0400AF46 RID: 44870
		[OriginalName("ErrTimeoutRejected")]
		ErrTimeoutRejected,
		// Token: 0x0400AF47 RID: 44871
		[OriginalName("ErrLoginEnvironment")]
		ErrLoginEnvironment,
		// Token: 0x0400AF48 RID: 44872
		[OriginalName("ErrLoginUserEmpty")]
		ErrLoginUserEmpty,
		// Token: 0x0400AF49 RID: 44873
		[OriginalName("ErrOldGameNodeLogoutFail")]
		ErrOldGameNodeLogoutFail,
		// Token: 0x0400AF4A RID: 44874
		[OriginalName("ErrOldGameNodeLogoutOffline")]
		ErrOldGameNodeLogoutOffline,
		// Token: 0x0400AF4B RID: 44875
		[OriginalName("ErrReloginBranchNameNotMatch")]
		ErrReloginBranchNameNotMatch,
		// Token: 0x0400AF4C RID: 44876
		[OriginalName("ErrReLoginFightDataInConsistent")]
		ErrReLoginFightDataInConsistent,
		// Token: 0x0400AF4D RID: 44877
		[OriginalName("ErrCreatePlayerData")]
		ErrCreatePlayerData,
		// Token: 0x0400AF4E RID: 44878
		[OriginalName("ErrReLoginPlayerLoggingOut")]
		ErrReLoginPlayerLoggingOut,
		// Token: 0x0400AF4F RID: 44879
		[OriginalName("ErrAccountLoggedInElsewhere")]
		ErrAccountLoggedInElsewhere,
		// Token: 0x0400AF50 RID: 44880
		[OriginalName("ErrTowerChallengeTeleportLocked")]
		ErrTowerChallengeTeleportLocked = 200551,
		// Token: 0x0400AF51 RID: 44881
		[OriginalName("ErrTowerDefenceGroupConfig")]
		ErrTowerDefenceGroupConfig,
		// Token: 0x0400AF52 RID: 44882
		[OriginalName("ErrTowerDefencePreInstNotPass")]
		ErrTowerDefencePreInstNotPass,
		// Token: 0x0400AF53 RID: 44883
		[OriginalName("ErrTowerDefenceRankCd")]
		ErrTowerDefenceRankCd,
		// Token: 0x0400AF54 RID: 44884
		[OriginalName("ErrFishingFixItemNotEnough")]
		ErrFishingFixItemNotEnough = 200549,
		// Token: 0x0400AF55 RID: 44885
		[OriginalName("ErrFishingEntrustUpdateItemNotEnough")]
		ErrFishingEntrustUpdateItemNotEnough,
		// Token: 0x0400AF56 RID: 44886
		[OriginalName("ErrTowerDefenceGroupActivityC")]
		ErrTowerDefenceGroupActivityC = 200555,
		// Token: 0x0400AF57 RID: 44887
		[OriginalName("ErrTowerDefenceGroupActivity")]
		ErrTowerDefenceGroupActivity,
		// Token: 0x0400AF58 RID: 44888
		[OriginalName("ErrAbyssComNotFound")]
		ErrAbyssComNotFound,
		// Token: 0x0400AF59 RID: 44889
		[OriginalName("ErrAbyssInstConfig")]
		ErrAbyssInstConfig,
		// Token: 0x0400AF5A RID: 44890
		[OriginalName("ErrAbyssRoomConfig")]
		ErrAbyssRoomConfig,
		// Token: 0x0400AF5B RID: 44891
		[OriginalName("ErrAbyssEnterCtx")]
		ErrAbyssEnterCtx,
		// Token: 0x0400AF5C RID: 44892
		[OriginalName("ErrAbyssActivityNotOpen")]
		ErrAbyssActivityNotOpen,
		// Token: 0x0400AF5D RID: 44893
		[OriginalName("ErrAbyssRewardConfig")]
		ErrAbyssRewardConfig,
		// Token: 0x0400AF5E RID: 44894
		[OriginalName("ErrAbyssRewardNotOpen")]
		ErrAbyssRewardNotOpen,
		// Token: 0x0400AF5F RID: 44895
		[OriginalName("ErrAbyssRewardClosed")]
		ErrAbyssRewardClosed,
		// Token: 0x0400AF60 RID: 44896
		[OriginalName("ErrAbyssRewarded")]
		ErrAbyssRewarded,
		// Token: 0x0400AF61 RID: 44897
		[OriginalName("ErrAbyssRewardCondition")]
		ErrAbyssRewardCondition,
		// Token: 0x0400AF62 RID: 44898
		[OriginalName("ErrAbyssLastActionNotFinish")]
		ErrAbyssLastActionNotFinish,
		// Token: 0x0400AF63 RID: 44899
		[OriginalName("ErrAbyssNextRoomNotFound")]
		ErrAbyssNextRoomNotFound,
		// Token: 0x0400AF64 RID: 44900
		[OriginalName("ErrAbyssRoleNotEquip")]
		ErrAbyssRoleNotEquip,
		// Token: 0x0400AF65 RID: 44901
		[OriginalName("ErrAbyssEquipRoleNotExist")]
		ErrAbyssEquipRoleNotExist,
		// Token: 0x0400AF66 RID: 44902
		[OriginalName("ErrAbyssEquipRoleDuplicate")]
		ErrAbyssEquipRoleDuplicate,
		// Token: 0x0400AF67 RID: 44903
		[OriginalName("ErrAbyssRoomNoBox")]
		ErrAbyssRoomNoBox,
		// Token: 0x0400AF68 RID: 44904
		[OriginalName("ErrAbyssRewardPlayerCount")]
		ErrAbyssRewardPlayerCount,
		// Token: 0x0400AF69 RID: 44905
		[OriginalName("ErrAbyssRewardBoxEntityIncId")]
		ErrAbyssRewardBoxEntityIncId,
		// Token: 0x0400AF6A RID: 44906
		[OriginalName("ErrAbyssBoxRewarded")]
		ErrAbyssBoxRewarded,
		// Token: 0x0400AF6B RID: 44907
		[OriginalName("ErrAbyssBoxNotBelong")]
		ErrAbyssBoxNotBelong,
		// Token: 0x0400AF6C RID: 44908
		[OriginalName("ErrAbyssBoxConfigNotFound")]
		ErrAbyssBoxConfigNotFound,
		// Token: 0x0400AF6D RID: 44909
		[OriginalName("ErrAbyssBoxDropFailed")]
		ErrAbyssBoxDropFailed,
		// Token: 0x0400AF6E RID: 44910
		[OriginalName("ErrAbyssChallengeLocked")]
		ErrAbyssChallengeLocked,
		// Token: 0x0400AF6F RID: 44911
		[OriginalName("ErrAbyssChallengeNoConsume")]
		ErrAbyssChallengeNoConsume,
		// Token: 0x0400AF70 RID: 44912
		[OriginalName("ErrAbyssChallengeUnlockItem")]
		ErrAbyssChallengeUnlockItem,
		// Token: 0x0400AF71 RID: 44913
		[OriginalName("ErrAbyssLikePlayerNotInScene")]
		ErrAbyssLikePlayerNotInScene,
		// Token: 0x0400AF72 RID: 44914
		[OriginalName("ErrAbyssLikeDuplicate")]
		ErrAbyssLikeDuplicate,
		// Token: 0x0400AF73 RID: 44915
		[OriginalName("ErrAbyssRoleItemNotFound")]
		ErrAbyssRoleItemNotFound,
		// Token: 0x0400AF74 RID: 44916
		[OriginalName("ErrAbyssRoleConfig")]
		ErrAbyssRoleConfig,
		// Token: 0x0400AF75 RID: 44917
		[OriginalName("ErrAbyssRoleLevelConfig")]
		ErrAbyssRoleLevelConfig,
		// Token: 0x0400AF76 RID: 44918
		[OriginalName("ErrAbyssRoleMaxPluginCount")]
		ErrAbyssRoleMaxPluginCount,
		// Token: 0x0400AF77 RID: 44919
		[OriginalName("ErrAbyssRoleLevelMaxPlugin")]
		ErrAbyssRoleLevelMaxPlugin,
		// Token: 0x0400AF78 RID: 44920
		[OriginalName("ErrAbyssPutOnDuplicate")]
		ErrAbyssPutOnDuplicate,
		// Token: 0x0400AF79 RID: 44921
		[OriginalName("ErrAbyssEquipOldRoleFailed")]
		ErrAbyssEquipOldRoleFailed,
		// Token: 0x0400AF7A RID: 44922
		[OriginalName("ErrAbyssSysthesisMaxCount")]
		ErrAbyssSysthesisMaxCount,
		// Token: 0x0400AF7B RID: 44923
		[OriginalName("ErrAbyssSysthesisItemDuplicate")]
		ErrAbyssSysthesisItemDuplicate,
		// Token: 0x0400AF7C RID: 44924
		[OriginalName("ErrAbyssPluginItemNotFound")]
		ErrAbyssPluginItemNotFound,
		// Token: 0x0400AF7D RID: 44925
		[OriginalName("ErrAbyssPluginItemLocked")]
		ErrAbyssPluginItemLocked,
		// Token: 0x0400AF7E RID: 44926
		[OriginalName("ErrAbyssPluginConfigNotFound")]
		ErrAbyssPluginConfigNotFound,
		// Token: 0x0400AF7F RID: 44927
		[OriginalName("ErrAbyssPluginEquipped")]
		ErrAbyssPluginEquipped,
		// Token: 0x0400AF80 RID: 44928
		[OriginalName("ErrAbyssQuialityConfig")]
		ErrAbyssQuialityConfig,
		// Token: 0x0400AF81 RID: 44929
		[OriginalName("ErrAbyssSysthesisConsumeItemDuplicate")]
		ErrAbyssSysthesisConsumeItemDuplicate,
		// Token: 0x0400AF82 RID: 44930
		[OriginalName("ErrAbyssRankListCd")]
		ErrAbyssRankListCd,
		// Token: 0x0400AF83 RID: 44931
		[OriginalName("ErrAbyssRoleUpLevel")]
		ErrAbyssRoleUpLevel,
		// Token: 0x0400AF84 RID: 44932
		[OriginalName("ErrAbyssRoleUpItem")]
		ErrAbyssRoleUpItem,
		// Token: 0x0400AF85 RID: 44933
		[OriginalName("ErrAbyssRoleUpNoComsume")]
		ErrAbyssRoleUpNoComsume,
		// Token: 0x0400AF86 RID: 44934
		[OriginalName("ErrAbyssPreChallengeNotPass")]
		ErrAbyssPreChallengeNotPass,
		// Token: 0x0400AF87 RID: 44935
		[OriginalName("ErrAbyssSlotConfig")]
		ErrAbyssSlotConfig,
		// Token: 0x0400AF88 RID: 44936
		[OriginalName("ErrAbyssSlotNotMatch")]
		ErrAbyssSlotNotMatch,
		// Token: 0x0400AF89 RID: 44937
		[OriginalName("ErrAbyssInstUnlockTime")]
		ErrAbyssInstUnlockTime,
		// Token: 0x0400AF8A RID: 44938
		[OriginalName("ErrAbyssSettled")]
		ErrAbyssSettled,
		// Token: 0x0400AF8B RID: 44939
		[OriginalName("ErrFormationTrailGender")]
		ErrFormationTrailGender,
		// Token: 0x0400AF8C RID: 44940
		[OriginalName("ErrLongShanStageLocked")]
		ErrLongShanStageLocked,
		// Token: 0x0400AF8D RID: 44941
		[OriginalName("ErrAbyssRewardIdRepeated")]
		ErrAbyssRewardIdRepeated,
		// Token: 0x0400AF8E RID: 44942
		[OriginalName("ErrAbyssRewardCount")]
		ErrAbyssRewardCount,
		// Token: 0x0400AF8F RID: 44943
		[OriginalName("ErrOtherPlayerCondition")]
		ErrOtherPlayerCondition,
		// Token: 0x0400AF90 RID: 44944
		[OriginalName("ErrAbyssItemSkillBelongTo")]
		ErrAbyssItemSkillBelongTo,
		// Token: 0x0400AF91 RID: 44945
		[OriginalName("ErrLongShanScoreRewardCount")]
		ErrLongShanScoreRewardCount,
		// Token: 0x0400AF92 RID: 44946
		[OriginalName("ErrLongShanScoreRewardDuplicate")]
		ErrLongShanScoreRewardDuplicate,
		// Token: 0x0400AF93 RID: 44947
		[OriginalName("ErrLongShanScoreRewardConfig")]
		ErrLongShanScoreRewardConfig,
		// Token: 0x0400AF94 RID: 44948
		[OriginalName("ErrLongShanScoreRewardActivity")]
		ErrLongShanScoreRewardActivity,
		// Token: 0x0400AF95 RID: 44949
		[OriginalName("ErrLongShanScoreRewarded")]
		ErrLongShanScoreRewarded,
		// Token: 0x0400AF96 RID: 44950
		[OriginalName("ErrLongShanScoreNotEnough")]
		ErrLongShanScoreNotEnough,
		// Token: 0x0400AF97 RID: 44951
		[OriginalName("ErrAbyssDuplicatePassive")]
		ErrAbyssDuplicatePassive,
		// Token: 0x0400AF98 RID: 44952
		[OriginalName("ErrActivityLifePointChallengeNotFound")]
		ErrActivityLifePointChallengeNotFound,
		// Token: 0x0400AF99 RID: 44953
		[OriginalName("ErrActivityLifePointNotOpen")]
		ErrActivityLifePointNotOpen,
		// Token: 0x0400AF9A RID: 44954
		[OriginalName("ErrActivityLifePointPreLocked")]
		ErrActivityLifePointPreLocked,
		// Token: 0x0400AF9B RID: 44955
		[OriginalName("ErrPhantomSettingRuleDuplicate")]
		ErrPhantomSettingRuleDuplicate,
		// Token: 0x0400AF9C RID: 44956
		[OriginalName("ErrPhantomSettingRuleNotFound")]
		ErrPhantomSettingRuleNotFound,
		// Token: 0x0400AF9D RID: 44957
		[OriginalName("ErrPhantomSettingEmpty")]
		ErrPhantomSettingEmpty,
		// Token: 0x0400AF9E RID: 44958
		[OriginalName("ErrPhantomSettingType")]
		ErrPhantomSettingType,
		// Token: 0x0400AF9F RID: 44959
		[OriginalName("ErrPhantomSettingNameLength")]
		ErrPhantomSettingNameLength,
		// Token: 0x0400AFA0 RID: 44960
		[OriginalName("ErrPhantomSettingNull")]
		ErrPhantomSettingNull,
		// Token: 0x0400AFA1 RID: 44961
		[OriginalName("ErrPhantomSettingIndexRange")]
		ErrPhantomSettingIndexRange,
		// Token: 0x0400AFA2 RID: 44962
		[OriginalName("ErrPhantomRuleIndexRange")]
		ErrPhantomRuleIndexRange,
		// Token: 0x0400AFA3 RID: 44963
		[OriginalName("ErrPhantomRuleCount")]
		ErrPhantomRuleCount,
		// Token: 0x0400AFA4 RID: 44964
		[OriginalName("ErrPhantomBathchOperCount")]
		ErrPhantomBathchOperCount,
		// Token: 0x0400AFA5 RID: 44965
		[OriginalName("ErrPhantomBathchType")]
		ErrPhantomBathchType,
		// Token: 0x0400AFA6 RID: 44966
		[OriginalName("ErrMobileSettingRequestParam")]
		ErrMobileSettingRequestParam,
		// Token: 0x0400AFA7 RID: 44967
		[OriginalName("ErrMobileSettingParamDuplicate")]
		ErrMobileSettingParamDuplicate,
		// Token: 0x0400AFA8 RID: 44968
		[OriginalName("ErrCommonUiSettingRequestParam")]
		ErrCommonUiSettingRequestParam,
		// Token: 0x0400AFA9 RID: 44969
		[OriginalName("ErrCommonUiSettingParamDuplicate")]
		ErrCommonUiSettingParamDuplicate,
		// Token: 0x0400AFAA RID: 44970
		[OriginalName("ErrCommonUiSettingConfig")]
		ErrCommonUiSettingConfig,
		// Token: 0x0400AFAB RID: 44971
		[OriginalName("ErrActivityNotOpenTip")]
		ErrActivityNotOpenTip,
		// Token: 0x0400AFAC RID: 44972
		[OriginalName("ErrLineCrossChallengeNotFound")]
		ErrLineCrossChallengeNotFound,
		// Token: 0x0400AFAD RID: 44973
		[OriginalName("ErrActivitylineCrossNotOpen")]
		ErrActivitylineCrossNotOpen,
		// Token: 0x0400AFAE RID: 44974
		[OriginalName("ErrActivitylineCrossPreLocked")]
		ErrActivitylineCrossPreLocked,
		// Token: 0x0400AFAF RID: 44975
		[OriginalName("ErrPhantomSettingFuncNotOpen")]
		ErrPhantomSettingFuncNotOpen,
		// Token: 0x0400AFB0 RID: 44976
		[OriginalName("ErrTowerSeasonConfig")]
		ErrTowerSeasonConfig,
		// Token: 0x0400AFB1 RID: 44977
		[OriginalName("ErrAccountDeactivation")]
		ErrAccountDeactivation,
		// Token: 0x0400AFB2 RID: 44978
		[OriginalName("ErrPlayerAccountDeactivation")]
		ErrPlayerAccountDeactivation,
		// Token: 0x0400AFB3 RID: 44979
		[OriginalName("ErrPlayerSkinChange")]
		ErrPlayerSkinChange,
		// Token: 0x0400AFB4 RID: 44980
		[OriginalName("ErrTrapDefenseNotMulti")]
		ErrTrapDefenseNotMulti,
		// Token: 0x0400AFB5 RID: 44981
		[OriginalName("ErrNotInTrapDefenseInst")]
		ErrNotInTrapDefenseInst,
		// Token: 0x0400AFB6 RID: 44982
		[OriginalName("ErrBossRushTaskNoConfig")]
		ErrBossRushTaskNoConfig,
		// Token: 0x0400AFB7 RID: 44983
		[OriginalName("ErrBossRushRequestActivityNotMatch")]
		ErrBossRushRequestActivityNotMatch,
		// Token: 0x0400AFB8 RID: 44984
		[OriginalName("ErrPhantomBatchPolishCount")]
		ErrPhantomBatchPolishCount,
		// Token: 0x0400AFB9 RID: 44985
		[OriginalName("ErrPhantomBatchPolishDuplicate")]
		ErrPhantomBatchPolishDuplicate,
		// Token: 0x0400AFBA RID: 44986
		[OriginalName("ErrPhantomBatchPolishPropNotMatch")]
		ErrPhantomBatchPolishPropNotMatch,
		// Token: 0x0400AFBB RID: 44987
		[OriginalName("ErrPhantomBatchPolishNoValidItem")]
		ErrPhantomBatchPolishNoValidItem,
		// Token: 0x0400AFBC RID: 44988
		[OriginalName("ErrLoginEmptyToken")]
		ErrLoginEmptyToken,
		// Token: 0x0400AFBD RID: 44989
		[OriginalName("ErrPhantomVicePolishLimit")]
		ErrPhantomVicePolishLimit,
		// Token: 0x0400AFBE RID: 44990
		[OriginalName("ErrPhantomVicePolishParam")]
		ErrPhantomVicePolishParam,
		// Token: 0x0400AFBF RID: 44991
		[OriginalName("ErrPhantomVicePolishItemPropLimit")]
		ErrPhantomVicePolishItemPropLimit,
		// Token: 0x0400AFC0 RID: 44992
		[OriginalName("ErrPhantomVicePolishItemLevelLimit")]
		ErrPhantomVicePolishItemLevelLimit,
		// Token: 0x0400AFC1 RID: 44993
		[OriginalName("ErrPhantomVicePolishParamDuplicate")]
		ErrPhantomVicePolishParamDuplicate,
		// Token: 0x0400AFC2 RID: 44994
		[OriginalName("ErrPhantomVicePolishPropGen")]
		ErrPhantomVicePolishPropGen,
		// Token: 0x0400AFC3 RID: 44995
		[OriginalName("ErrPhantomVicePolishNoneProp")]
		ErrPhantomVicePolishNoneProp,
		// Token: 0x0400AFC4 RID: 44996
		[OriginalName("ErrSkinRewardNotFound")]
		ErrSkinRewardNotFound,
		// Token: 0x0400AFC5 RID: 44997
		[OriginalName("ErrSkinRewardState")]
		ErrSkinRewardState,
		// Token: 0x0400AFC6 RID: 44998
		[OriginalName("ErrTowerForbidRechallenge")]
		ErrTowerForbidRechallenge,
		// Token: 0x0400AFC7 RID: 44999
		[OriginalName("ErrInputSettingActoinType")]
		ErrInputSettingActoinType,
		// Token: 0x0400AFC8 RID: 45000
		[OriginalName("ErrCreateCharacterGender")]
		ErrCreateCharacterGender,
		// Token: 0x0400AFC9 RID: 45001
		[OriginalName("ErrSkillBranchRoleValid")]
		ErrSkillBranchRoleValid,
		// Token: 0x0400AFCA RID: 45002
		[OriginalName("ErrSkillBranchNotValid")]
		ErrSkillBranchNotValid,
		// Token: 0x0400AFCB RID: 45003
		[OriginalName("ErrTrailRoleSkillBranchNotValid")]
		ErrTrailRoleSkillBranchNotValid,
		// Token: 0x0400AFCC RID: 45004
		[OriginalName("ErrRoleDevConfigVersion")]
		ErrRoleDevConfigVersion,
		// Token: 0x0400AFCD RID: 45005
		[OriginalName("ErrRoleDevConfigVersionTime")]
		ErrRoleDevConfigVersionTime,
		// Token: 0x0400AFCE RID: 45006
		[OriginalName("ErrRoleDevConfigNoUpdate")]
		ErrRoleDevConfigNoUpdate,
		// Token: 0x0400AFCF RID: 45007
		[OriginalName("ErrMotorDevelopRequestParam")]
		ErrMotorDevelopRequestParam,
		// Token: 0x0400AFD0 RID: 45008
		[OriginalName("ErrMotorDevelopParamDuplicate")]
		ErrMotorDevelopParamDuplicate,
		// Token: 0x0400AFD1 RID: 45009
		[OriginalName("ErrMotorDevelopTaskNotFound")]
		ErrMotorDevelopTaskNotFound,
		// Token: 0x0400AFD2 RID: 45010
		[OriginalName("ErrMotorDevelopActivityNotOpen")]
		ErrMotorDevelopActivityNotOpen,
		// Token: 0x0400AFD3 RID: 45011
		[OriginalName("ErrMotorDevelopTaskNotComplete")]
		ErrMotorDevelopTaskNotComplete,
		// Token: 0x0400AFD4 RID: 45012
		[OriginalName("ErrPhantomVicePolishNoAck")]
		ErrPhantomVicePolishNoAck,
		// Token: 0x0400AFD5 RID: 45013
		[OriginalName("ErrClientStorageSystemCount")]
		ErrClientStorageSystemCount,
		// Token: 0x0400AFD6 RID: 45014
		[OriginalName("ErrClientStorageSystemDuplicate")]
		ErrClientStorageSystemDuplicate,
		// Token: 0x0400AFD7 RID: 45015
		[OriginalName("ErrClientStorageSystem")]
		ErrClientStorageSystem,
		// Token: 0x0400AFD8 RID: 45016
		[OriginalName("ErrClientStorageStringLength")]
		ErrClientStorageStringLength,
		// Token: 0x0400AFD9 RID: 45017
		[OriginalName("ErrClientStorageType")]
		ErrClientStorageType,
		// Token: 0x0400AFDA RID: 45018
		[OriginalName("ErrClientStorageCapacity")]
		ErrClientStorageCapacity,
		// Token: 0x0400AFDB RID: 45019
		[OriginalName("ErrClientStorageSystemTypeErr")]
		ErrClientStorageSystemTypeErr,
		// Token: 0x0400AFDC RID: 45020
		[OriginalName("ErrXboxRegionNotFound")]
		ErrXboxRegionNotFound,
		// Token: 0x0400AFDD RID: 45021
		[OriginalName("ErrNotXboxChannelId")]
		ErrNotXboxChannelId,
		// Token: 0x0400AFDE RID: 45022
		[OriginalName("ErrXboxRegionSet")]
		ErrXboxRegionSet,
		// Token: 0x0400AFDF RID: 45023
		[OriginalName("ErrXboxRegionSetException")]
		ErrXboxRegionSetException,
		// Token: 0x0400AFE0 RID: 45024
		[OriginalName("ErrXboxRegionGetException")]
		ErrXboxRegionGetException,
		// Token: 0x0400AFE1 RID: 45025
		[OriginalName("ErrXboxRegionGetFailed")]
		ErrXboxRegionGetFailed,
		// Token: 0x0400AFE2 RID: 45026
		[OriginalName("ErrQuestBranchPageNotFound")]
		ErrQuestBranchPageNotFound,
		// Token: 0x0400AFE3 RID: 45027
		[OriginalName("ErrQuestBranchQuestState")]
		ErrQuestBranchQuestState,
		// Token: 0x0400AFE4 RID: 45028
		[OriginalName("ErrQuestBranchComplete")]
		ErrQuestBranchComplete,
		// Token: 0x0400AFE5 RID: 45029
		[OriginalName("ErrQuestBranchNotComplete")]
		ErrQuestBranchNotComplete,
		// Token: 0x0400AFE6 RID: 45030
		[OriginalName("ErrFightFormationNameChangeCd")]
		ErrFightFormationNameChangeCd,
		// Token: 0x0400AFE7 RID: 45031
		[OriginalName("ErrFightFormationNameLength")]
		ErrFightFormationNameLength,
		// Token: 0x0400AFE8 RID: 45032
		[OriginalName("ErrRoleSkillLevel")]
		ErrRoleSkillLevel,
		// Token: 0x0400AFE9 RID: 45033
		[OriginalName("ErrQuestBranchConfig")]
		ErrQuestBranchConfig,
		// Token: 0x0400AFEA RID: 45034
		[OriginalName("ErrConditionStateRequestParam")]
		ErrConditionStateRequestParam,
		// Token: 0x0400AFEB RID: 45035
		[OriginalName("ErrConditionStateRequestModule")]
		ErrConditionStateRequestModule,
		// Token: 0x0400AFEC RID: 45036
		[OriginalName("ErrPolishPhantomStackKey")]
		ErrPolishPhantomStackKey,
		// Token: 0x0400AFED RID: 45037
		[OriginalName("ErrSplitPhantomStackKey")]
		ErrSplitPhantomStackKey,
		// Token: 0x0400AFEE RID: 45038
		[OriginalName("ErrConsumePhantomStackKey")]
		ErrConsumePhantomStackKey,
		// Token: 0x0400AFEF RID: 45039
		[OriginalName("ErrBatchPolishPhantomStackKey")]
		ErrBatchPolishPhantomStackKey,
		// Token: 0x0400AFF0 RID: 45040
		[OriginalName("ErrPhantomMaxStackCount")]
		ErrPhantomMaxStackCount,
		// Token: 0x0400AFF1 RID: 45041
		[OriginalName("ErrReturnPhantomStackKey")]
		ErrReturnPhantomStackKey,
		// Token: 0x0400AFF2 RID: 45042
		[OriginalName("ErrRefiningPhantomStackKey")]
		ErrRefiningPhantomStackKey,
		// Token: 0x0400AFF3 RID: 45043
		[OriginalName("ErrPhantomPkgFull")]
		ErrPhantomPkgFull,
		// Token: 0x0400AFF4 RID: 45044
		[OriginalName("ErrMapDefault")]
		ErrMapDefault = 300000,
		// Token: 0x0400AFF5 RID: 45045
		[OriginalName("ErrMapMarkNumLimit")]
		ErrMapMarkNumLimit,
		// Token: 0x0400AFF6 RID: 45046
		[OriginalName("ErrMapNoFogConfig")]
		ErrMapNoFogConfig,
		// Token: 0x0400AFF7 RID: 45047
		[OriginalName("ErrMapFogAlreadyUnlock")]
		ErrMapFogAlreadyUnlock,
		// Token: 0x0400AFF8 RID: 45048
		[OriginalName("ErrFormationEmpty")]
		ErrFormationEmpty,
		// Token: 0x0400AFF9 RID: 45049
		[OriginalName("ErrFormationUnknown")]
		ErrFormationUnknown,
		// Token: 0x0400AFFA RID: 45050
		[OriginalName("ErrFormationDead")]
		ErrFormationDead,
		// Token: 0x0400AFFB RID: 45051
		[OriginalName("ErrFormationRoleRepeat")]
		ErrFormationRoleRepeat,
		// Token: 0x0400AFFC RID: 45052
		[OriginalName("ErrFormationRoleNotActive")]
		ErrFormationRoleNotActive,
		// Token: 0x0400AFFD RID: 45053
		[OriginalName("ErrFormationRoleIndexOut")]
		ErrFormationRoleIndexOut,
		// Token: 0x0400AFFE RID: 45054
		[OriginalName("ErrFormationRoleCountOut")]
		ErrFormationRoleCountOut,
		// Token: 0x0400AFFF RID: 45055
		[OriginalName("ErrFightFormationRoleNotExist")]
		ErrFightFormationRoleNotExist,
		// Token: 0x0400B000 RID: 45056
		[OriginalName("ErrFightFormationRoleIdNotMatch")]
		ErrFightFormationRoleIdNotMatch,
		// Token: 0x0400B001 RID: 45057
		[OriginalName("ErrFightFormationRoleCountNotMatch")]
		ErrFightFormationRoleCountNotMatch,
		// Token: 0x0400B002 RID: 45058
		[OriginalName("ErrFightFormationRoleCareerNotMatch")]
		ErrFightFormationRoleCareerNotMatch,
		// Token: 0x0400B003 RID: 45059
		[OriginalName("ErrFightFormationRoleElementNotMatch")]
		ErrFightFormationRoleElementNotMatch,
		// Token: 0x0400B004 RID: 45060
		[OriginalName("ErrFightFormationCannotTrial")]
		ErrFightFormationCannotTrial,
		// Token: 0x0400B005 RID: 45061
		[OriginalName("ErrFightFormationTrialRoleNotMatch")]
		ErrFightFormationTrialRoleNotMatch,
		// Token: 0x0400B006 RID: 45062
		[OriginalName("ErrFormationOverSize")]
		ErrFormationOverSize,
		// Token: 0x0400B007 RID: 45063
		[OriginalName("ErrSwitchRoleIsDead")]
		ErrSwitchRoleIsDead,
		// Token: 0x0400B008 RID: 45064
		[OriginalName("ErrUpdateFormationCurRoleIsDead")]
		ErrUpdateFormationCurRoleIsDead,
		// Token: 0x0400B009 RID: 45065
		[OriginalName("ErrUpdateFormationRoleIdsIsNull")]
		ErrUpdateFormationRoleIdsIsNull,
		// Token: 0x0400B00A RID: 45066
		[OriginalName("ErrFormationIdOutOfRange")]
		ErrFormationIdOutOfRange,
		// Token: 0x0400B00B RID: 45067
		[OriginalName("ErrCanNotCancelCurFormation")]
		ErrCanNotCancelCurFormation,
		// Token: 0x0400B00C RID: 45068
		[OriginalName("ErrCurRoleNotInFormationRoleIds")]
		ErrCurRoleNotInFormationRoleIds,
		// Token: 0x0400B00D RID: 45069
		[OriginalName("ErrUpateFormationNotInSingleWorld")]
		ErrUpateFormationNotInSingleWorld,
		// Token: 0x0400B00E RID: 45070
		[OriginalName("ErrSwitchRoleTypeSignleWorld")]
		ErrSwitchRoleTypeSignleWorld,
		// Token: 0x0400B00F RID: 45071
		[OriginalName("ErrSwitchRoleTypeMultiWorld")]
		ErrSwitchRoleTypeMultiWorld,
		// Token: 0x0400B010 RID: 45072
		[OriginalName("ErrSwitchRoleTypeFbInstance")]
		ErrSwitchRoleTypeFbInstance,
		// Token: 0x0400B011 RID: 45073
		[OriginalName("ErrSwitchRoleTypeUndefine")]
		ErrSwitchRoleTypeUndefine,
		// Token: 0x0400B012 RID: 45074
		[OriginalName("ErrSingWorldCanNotUpdateFightRoles")]
		ErrSingWorldCanNotUpdateFightRoles,
		// Token: 0x0400B013 RID: 45075
		[OriginalName("ErrUpdateFightRolesIsNull")]
		ErrUpdateFightRolesIsNull,
		// Token: 0x0400B014 RID: 45076
		[OriginalName("ErrUpdateFightRolesCurIdNotExist")]
		ErrUpdateFightRolesCurIdNotExist,
		// Token: 0x0400B015 RID: 45077
		[OriginalName("ErrInStroyCharacterCanNotSwitchRole")]
		ErrInStroyCharacterCanNotSwitchRole,
		// Token: 0x0400B016 RID: 45078
		[OriginalName("ErrSwitchRoleNotInFightRoles")]
		ErrSwitchRoleNotInFightRoles,
		// Token: 0x0400B017 RID: 45079
		[OriginalName("ErrCanNotSwitchRepeat")]
		ErrCanNotSwitchRepeat,
		// Token: 0x0400B018 RID: 45080
		[OriginalName("ErrSwitchRoleEntityIdNotExist")]
		ErrSwitchRoleEntityIdNotExist,
		// Token: 0x0400B019 RID: 45081
		[OriginalName("ErrSwitchRoleEntityNotExist")]
		ErrSwitchRoleEntityNotExist,
		// Token: 0x0400B01A RID: 45082
		[OriginalName("ErrSitchRoleEntityIsDead")]
		ErrSitchRoleEntityIsDead,
		// Token: 0x0400B01B RID: 45083
		[OriginalName("ErrorTeamOperaFail")]
		ErrorTeamOperaFail,
		// Token: 0x0400B01C RID: 45084
		[OriginalName("ErrorPlayerAlreadyHaveTeam")]
		ErrorPlayerAlreadyHaveTeam,
		// Token: 0x0400B01D RID: 45085
		[OriginalName("ErrorTeamInviteContentInvalid")]
		ErrorTeamInviteContentInvalid,
		// Token: 0x0400B01E RID: 45086
		[OriginalName("ErrorPlayerInBanTime")]
		ErrorPlayerInBanTime,
		// Token: 0x0400B01F RID: 45087
		[OriginalName("ErrorPlayerInInviteCd")]
		ErrorPlayerInInviteCd,
		// Token: 0x0400B020 RID: 45088
		[OriginalName("ErrorPlayerAlreadyInTeam")]
		ErrorPlayerAlreadyInTeam,
		// Token: 0x0400B021 RID: 45089
		[OriginalName("ErrorKickOutPermissionNotEnough")]
		ErrorKickOutPermissionNotEnough,
		// Token: 0x0400B022 RID: 45090
		[OriginalName("ErrorTeamIsFull")]
		ErrorTeamIsFull,
		// Token: 0x0400B023 RID: 45091
		[OriginalName("ErrorTeamServiceNotReady")]
		ErrorTeamServiceNotReady,
		// Token: 0x0400B024 RID: 45092
		[OriginalName("ErrorTeamPlayerJoinRepeat")]
		ErrorTeamPlayerJoinRepeat,
		// Token: 0x0400B025 RID: 45093
		[OriginalName("ErrorPlayerNotInTeam")]
		ErrorPlayerNotInTeam,
		// Token: 0x0400B026 RID: 45094
		[OriginalName("ErrorInvitePlayerNotExist")]
		ErrorInvitePlayerNotExist,
		// Token: 0x0400B027 RID: 45095
		[OriginalName("ErrorKickPlayerNotInTeam")]
		ErrorKickPlayerNotInTeam,
		// Token: 0x0400B028 RID: 45096
		[OriginalName("ErrorDismissPermissionNotEnough")]
		ErrorDismissPermissionNotEnough,
		// Token: 0x0400B029 RID: 45097
		[OriginalName("ErrorTeamRoleIdNotActive")]
		ErrorTeamRoleIdNotActive,
		// Token: 0x0400B02A RID: 45098
		[OriginalName("ErrorTeamRoleIdRepeat")]
		ErrorTeamRoleIdRepeat,
		// Token: 0x0400B02B RID: 45099
		[OriginalName("ErrorJoinOtherWorldOtherNotExist")]
		ErrorJoinOtherWorldOtherNotExist,
		// Token: 0x0400B02C RID: 45100
		[OriginalName("ErrorJoinOtherWorldOtherNotInScene")]
		ErrorJoinOtherWorldOtherNotInScene,
		// Token: 0x0400B02D RID: 45101
		[OriginalName("ErrorJoinOtherWorldSceneNotExist")]
		ErrorJoinOtherWorldSceneNotExist,
		// Token: 0x0400B02E RID: 45102
		[OriginalName("ErrorTeamNotExist")]
		ErrorTeamNotExist,
		// Token: 0x0400B02F RID: 45103
		[OriginalName("ErrRewardCfgNotFound")]
		ErrRewardCfgNotFound,
		// Token: 0x0400B030 RID: 45104
		[OriginalName("ErrTeleportIdNotExist")]
		ErrTeleportIdNotExist,
		// Token: 0x0400B031 RID: 45105
		[OriginalName("ErrTeleportIdNotActivate")]
		ErrTeleportIdNotActivate,
		// Token: 0x0400B032 RID: 45106
		[OriginalName("ErrTeleportCreatureIdNotExist")]
		ErrTeleportCreatureIdNotExist,
		// Token: 0x0400B033 RID: 45107
		[OriginalName("ErrTeleportIdAlreadyActivate")]
		ErrTeleportIdAlreadyActivate,
		// Token: 0x0400B034 RID: 45108
		[OriginalName("ErrTeleportGmGetPlayerFailed")]
		ErrTeleportGmGetPlayerFailed,
		// Token: 0x0400B035 RID: 45109
		[OriginalName("ErrTeleportGmGetCreatureGenCfgFailed")]
		ErrTeleportGmGetCreatureGenCfgFailed,
		// Token: 0x0400B036 RID: 45110
		[OriginalName("ErrTgmNotExitst")]
		ErrTgmNotExitst,
		// Token: 0x0400B037 RID: 45111
		[OriginalName("ErrTgmNotPlayer")]
		ErrTgmNotPlayer,
		// Token: 0x0400B038 RID: 45112
		[OriginalName("ErrTgmNotGenCfg")]
		ErrTgmNotGenCfg,
		// Token: 0x0400B039 RID: 45113
		[OriginalName("ErrTgmInsId")]
		ErrTgmInsId,
		// Token: 0x0400B03A RID: 45114
		[OriginalName("ErrTeleportEntityNotExist")]
		ErrTeleportEntityNotExist,
		// Token: 0x0400B03B RID: 45115
		[OriginalName("ErrTeleportComponentNotExist")]
		ErrTeleportComponentNotExist,
		// Token: 0x0400B03C RID: 45116
		[OriginalName("ErrTeleportComponentNotMatch")]
		ErrTeleportComponentNotMatch,
		// Token: 0x0400B03D RID: 45117
		[OriginalName("ErrAreaEnterRepeated")]
		ErrAreaEnterRepeated,
		// Token: 0x0400B03E RID: 45118
		[OriginalName("ErrAreaIdNotExist")]
		ErrAreaIdNotExist,
		// Token: 0x0400B03F RID: 45119
		[OriginalName("ErrAreaIdNoNeedRecord")]
		ErrAreaIdNoNeedRecord,
		// Token: 0x0400B040 RID: 45120
		[OriginalName("ErrPlayerIsNotDead")]
		ErrPlayerIsNotDead,
		// Token: 0x0400B041 RID: 45121
		[OriginalName("ErrPlayerCanNotRevive")]
		ErrPlayerCanNotRevive,
		// Token: 0x0400B042 RID: 45122
		[OriginalName("ErrPlayerReviveCountReachMax")]
		ErrPlayerReviveCountReachMax,
		// Token: 0x0400B043 RID: 45123
		[OriginalName("ErrPlayerReviveDelayNotReach")]
		ErrPlayerReviveDelayNotReach,
		// Token: 0x0400B044 RID: 45124
		[OriginalName("ErrAutoReviveNotRequest")]
		ErrAutoReviveNotRequest,
		// Token: 0x0400B045 RID: 45125
		[OriginalName("ErrReviveRegionExisted")]
		ErrReviveRegionExisted,
		// Token: 0x0400B046 RID: 45126
		[OriginalName("ErrReviveRegionNotExisted")]
		ErrReviveRegionNotExisted,
		// Token: 0x0400B047 RID: 45127
		[OriginalName("ErrReviveRegionConfigNotExist")]
		ErrReviveRegionConfigNotExist,
		// Token: 0x0400B048 RID: 45128
		[OriginalName("ErrCanNotUseItemRevive")]
		ErrCanNotUseItemRevive,
		// Token: 0x0400B049 RID: 45129
		[OriginalName("ErrIsMatching")]
		ErrIsMatching,
		// Token: 0x0400B04A RID: 45130
		[OriginalName("ErrNotInMatcing")]
		ErrNotInMatcing,
		// Token: 0x0400B04B RID: 45131
		[OriginalName("ErrMatchPoolNotExist")]
		ErrMatchPoolNotExist,
		// Token: 0x0400B04C RID: 45132
		[OriginalName("ErrNotFindMatchResult")]
		ErrNotFindMatchResult,
		// Token: 0x0400B04D RID: 45133
		[OriginalName("ErrConfirmResultRepeat")]
		ErrConfirmResultRepeat,
		// Token: 0x0400B04E RID: 45134
		[OriginalName("ErrAlreadyHaveFbTeam")]
		ErrAlreadyHaveFbTeam,
		// Token: 0x0400B04F RID: 45135
		[OriginalName("ErrFbTeamNotExist")]
		ErrFbTeamNotExist,
		// Token: 0x0400B050 RID: 45136
		[OriginalName("ErrPlayerNotInFbTeam")]
		ErrPlayerNotInFbTeam,
		// Token: 0x0400B051 RID: 45137
		[OriginalName("ErrHostCanNotReady")]
		ErrHostCanNotReady,
		// Token: 0x0400B052 RID: 45138
		[OriginalName("ErrChangeReadyRepeat")]
		ErrChangeReadyRepeat,
		// Token: 0x0400B053 RID: 45139
		[OriginalName("ErrFbTeamHaveSameRole")]
		ErrFbTeamHaveSameRole,
		// Token: 0x0400B054 RID: 45140
		[OriginalName("ErrReadyStateCanNotChangeRole")]
		ErrReadyStateCanNotChangeRole,
		// Token: 0x0400B055 RID: 45141
		[OriginalName("ErrChangeSameRole")]
		ErrChangeSameRole,
		// Token: 0x0400B056 RID: 45142
		[OriginalName("ErrNotHaveKickPermission")]
		ErrNotHaveKickPermission,
		// Token: 0x0400B057 RID: 45143
		[OriginalName("ErrBeKickNotInFbTeam")]
		ErrBeKickNotInFbTeam,
		// Token: 0x0400B058 RID: 45144
		[OriginalName("ErrNotHaveFightPermission")]
		ErrNotHaveFightPermission,
		// Token: 0x0400B059 RID: 45145
		[OriginalName("ErrFbTeamNotAllReady")]
		ErrFbTeamNotAllReady,
		// Token: 0x0400B05A RID: 45146
		[OriginalName("ErrFbInstIdNotExist")]
		ErrFbInstIdNotExist,
		// Token: 0x0400B05B RID: 45147
		[OriginalName("ErrFbMatchRoleNotMatch")]
		ErrFbMatchRoleNotMatch,
		// Token: 0x0400B05C RID: 45148
		[OriginalName("ErrSingleInstCanNotMatch")]
		ErrSingleInstCanNotMatch,
		// Token: 0x0400B05D RID: 45149
		[OriginalName("ErrWaitOtherEnterSceneForbidMatch")]
		ErrWaitOtherEnterSceneForbidMatch,
		// Token: 0x0400B05E RID: 45150
		[OriginalName("ErrIsEnteringOtherSceneForbidMatch")]
		ErrIsEnteringOtherSceneForbidMatch,
		// Token: 0x0400B05F RID: 45151
		[OriginalName("InstPlayBtObjNotFound")]
		InstPlayBtObjNotFound,
		// Token: 0x0400B060 RID: 45152
		[OriginalName("InstPlayNotSuccess")]
		InstPlayNotSuccess,
		// Token: 0x0400B061 RID: 45153
		[OriginalName("InstPlayAlreadyGetReward")]
		InstPlayAlreadyGetReward,
		// Token: 0x0400B062 RID: 45154
		[OriginalName("InstPlayExchangeRewardFail")]
		InstPlayExchangeRewardFail,
		// Token: 0x0400B063 RID: 45155
		[OriginalName("InstPlaySetterRepeat")]
		InstPlaySetterRepeat,
		// Token: 0x0400B064 RID: 45156
		[OriginalName("InstEntranceNotUnlock")]
		InstEntranceNotUnlock,
		// Token: 0x0400B065 RID: 45157
		[OriginalName("InstEntranceNotOpen")]
		InstEntranceNotOpen,
		// Token: 0x0400B066 RID: 45158
		[OriginalName("EnterInstLevelNotEnough")]
		EnterInstLevelNotEnough,
		// Token: 0x0400B067 RID: 45159
		[OriginalName("EnterInstWorldLevelNotEnough")]
		EnterInstWorldLevelNotEnough,
		// Token: 0x0400B068 RID: 45160
		[OriginalName("EnterInstQuestNotEnough")]
		EnterInstQuestNotEnough,
		// Token: 0x0400B069 RID: 45161
		[OriginalName("ErrForbidEnterInstInMatch")]
		ErrForbidEnterInstInMatch,
		// Token: 0x0400B06A RID: 45162
		[OriginalName("ErrForbidEnterInstInEnteringOtherWorld")]
		ErrForbidEnterInstInEnteringOtherWorld,
		// Token: 0x0400B06B RID: 45163
		[OriginalName("ErrForbidEnterInstInWaitingOtherEnterWorld")]
		ErrForbidEnterInstInWaitingOtherEnterWorld,
		// Token: 0x0400B06C RID: 45164
		[OriginalName("ErrEnterInstTypeNotMatch")]
		ErrEnterInstTypeNotMatch,
		// Token: 0x0400B06D RID: 45165
		[OriginalName("ErrNotHaveGetRewardCount")]
		ErrNotHaveGetRewardCount,
		// Token: 0x0400B06E RID: 45166
		[OriginalName("ErrInMatching")]
		ErrInMatching,
		// Token: 0x0400B06F RID: 45167
		[OriginalName("ErrNotInMatching")]
		ErrNotInMatching,
		// Token: 0x0400B070 RID: 45168
		[OriginalName("ErrNotFindValidMatchServer")]
		ErrNotFindValidMatchServer,
		// Token: 0x0400B071 RID: 45169
		[OriginalName("ErrNotFindMatchServerPrx")]
		ErrNotFindMatchServerPrx,
		// Token: 0x0400B072 RID: 45170
		[OriginalName("ErrNotHaveMatchTeamInfo")]
		ErrNotHaveMatchTeamInfo,
		// Token: 0x0400B073 RID: 45171
		[OriginalName("ErrAlreadyConfirmMatchResult")]
		ErrAlreadyConfirmMatchResult,
		// Token: 0x0400B074 RID: 45172
		[OriginalName("ErrMatchTeamNotInReadyState")]
		ErrMatchTeamNotInReadyState,
		// Token: 0x0400B075 RID: 45173
		[OriginalName("ErrMatchRoleNotActive")]
		ErrMatchRoleNotActive,
		// Token: 0x0400B076 RID: 45174
		[OriginalName("ErrMatchReadyRepeat")]
		ErrMatchReadyRepeat,
		// Token: 0x0400B077 RID: 45175
		[OriginalName("ErrMatchPlayerNotReady")]
		ErrMatchPlayerNotReady,
		// Token: 0x0400B078 RID: 45176
		[OriginalName("ErrMatchNotHostCanNotKick")]
		ErrMatchNotHostCanNotKick,
		// Token: 0x0400B079 RID: 45177
		[OriginalName("ErrMatchNotHostCanNotSetMatching")]
		ErrMatchNotHostCanNotSetMatching,
		// Token: 0x0400B07A RID: 45178
		[OriginalName("ErrSetMatchFlagRepeat")]
		ErrSetMatchFlagRepeat,
		// Token: 0x0400B07B RID: 45179
		[OriginalName("ErrPlayerNotInMatchTeam")]
		ErrPlayerNotInMatchTeam,
		// Token: 0x0400B07C RID: 45180
		[OriginalName("ErrGetMatchPoolFail")]
		ErrGetMatchPoolFail,
		// Token: 0x0400B07D RID: 45181
		[OriginalName("ErrPlayerInMatchPool")]
		ErrPlayerInMatchPool,
		// Token: 0x0400B07E RID: 45182
		[OriginalName("ErrPlayerNotInMatchPool")]
		ErrPlayerNotInMatchPool,
		// Token: 0x0400B07F RID: 45183
		[OriginalName("ErrPlayerInMatchTeamCanNotCancel")]
		ErrPlayerInMatchTeamCanNotCancel,
		// Token: 0x0400B080 RID: 45184
		[OriginalName("ErrPlayerIsConfirmResult")]
		ErrPlayerIsConfirmResult,
		// Token: 0x0400B081 RID: 45185
		[OriginalName("ErrNotFindMatchTeam")]
		ErrNotFindMatchTeam,
		// Token: 0x0400B082 RID: 45186
		[OriginalName("ErrPlayerIsReadyCanNotChangeRole")]
		ErrPlayerIsReadyCanNotChangeRole,
		// Token: 0x0400B083 RID: 45187
		[OriginalName("ErrNotHostCanNotSetMultRoles")]
		ErrNotHostCanNotSetMultRoles,
		// Token: 0x0400B084 RID: 45188
		[OriginalName("ErrCanNotSetRepeatRole")]
		ErrCanNotSetRepeatRole,
		// Token: 0x0400B085 RID: 45189
		[OriginalName("ErrPlayerNotReadyCanNotCancel")]
		ErrPlayerNotReadyCanNotCancel,
		// Token: 0x0400B086 RID: 45190
		[OriginalName("ErrRoleRepeatCanNotReady")]
		ErrRoleRepeatCanNotReady,
		// Token: 0x0400B087 RID: 45191
		[OriginalName("ErrBeKickNotInMatchTeam")]
		ErrBeKickNotInMatchTeam,
		// Token: 0x0400B088 RID: 45192
		[OriginalName("ErrNotHostCanNotKick")]
		ErrNotHostCanNotKick,
		// Token: 0x0400B089 RID: 45193
		[OriginalName("ErrNotHostCanNotSetTeamState")]
		ErrNotHostCanNotSetTeamState,
		// Token: 0x0400B08A RID: 45194
		[OriginalName("ErrTeamMatchingCanNotStartInst")]
		ErrTeamMatchingCanNotStartInst,
		// Token: 0x0400B08B RID: 45195
		[OriginalName("ErrMatchTeamHavePlayerNotReady")]
		ErrMatchTeamHavePlayerNotReady,
		// Token: 0x0400B08C RID: 45196
		[OriginalName("ErrNotHostCanNotEnterInst")]
		ErrNotHostCanNotEnterInst,
		// Token: 0x0400B08D RID: 45197
		[OriginalName("ErrMatchTeamIsNotEnterInstState")]
		ErrMatchTeamIsNotEnterInstState,
		// Token: 0x0400B08E RID: 45198
		[OriginalName("ErrMatchInstIdNotExist")]
		ErrMatchInstIdNotExist,
		// Token: 0x0400B08F RID: 45199
		[OriginalName("ErrSingleInstanceCanNotMatch")]
		ErrSingleInstanceCanNotMatch,
		// Token: 0x0400B090 RID: 45200
		[OriginalName("ErrOnlineStateCanNotMatch")]
		ErrOnlineStateCanNotMatch,
		// Token: 0x0400B091 RID: 45201
		[OriginalName("ErrTeamHaveSameRoleCanNotBegin")]
		ErrTeamHaveSameRoleCanNotBegin,
		// Token: 0x0400B092 RID: 45202
		[OriginalName("ErrNotJoinChatChannel")]
		ErrNotJoinChatChannel,
		// Token: 0x0400B093 RID: 45203
		[OriginalName("ErrChatChannelNotFound")]
		ErrChatChannelNotFound,
		// Token: 0x0400B094 RID: 45204
		[OriginalName("ErrChatChannelTypeNotMatch")]
		ErrChatChannelTypeNotMatch,
		// Token: 0x0400B095 RID: 45205
		[OriginalName("ErrChatContentTooLong")]
		ErrChatContentTooLong,
		// Token: 0x0400B096 RID: 45206
		[OriginalName("ErrFightRoleIsAllDied")]
		ErrFightRoleIsAllDied,
		// Token: 0x0400B097 RID: 45207
		[OriginalName("ErrLoadingSceneIdNotMatch")]
		ErrLoadingSceneIdNotMatch,
		// Token: 0x0400B098 RID: 45208
		[OriginalName("ErrLoadingPlayerNotInScene")]
		ErrLoadingPlayerNotInScene,
		// Token: 0x0400B099 RID: 45209
		[OriginalName("ErrPlayerIsSceneLoadingCanNotBeKick")]
		ErrPlayerIsSceneLoadingCanNotBeKick,
		// Token: 0x0400B09A RID: 45210
		[OriginalName("ErrTeamPlayerIsSceneLoadingCanNotDissolve")]
		ErrTeamPlayerIsSceneLoadingCanNotDissolve,
		// Token: 0x0400B09B RID: 45211
		[OriginalName("ErrIsSceneLoadingCanNotDissolve")]
		ErrIsSceneLoadingCanNotDissolve,
		// Token: 0x0400B09C RID: 45212
		[OriginalName("ErrSceneLoadingCanNotEnterInst")]
		ErrSceneLoadingCanNotEnterInst,
		// Token: 0x0400B09D RID: 45213
		[OriginalName("ErrActivateResetPointNotEntity")]
		ErrActivateResetPointNotEntity,
		// Token: 0x0400B09E RID: 45214
		[OriginalName("ErrHostIsLoadingScene")]
		ErrHostIsLoadingScene,
		// Token: 0x0400B09F RID: 45215
		[OriginalName("ErrHostIsLoadingSceneCanNotApply")]
		ErrHostIsLoadingSceneCanNotApply,
		// Token: 0x0400B0A0 RID: 45216
		[OriginalName("ErrIsLoadingSceneCanNotAcceptApply")]
		ErrIsLoadingSceneCanNotAcceptApply,
		// Token: 0x0400B0A1 RID: 45217
		[OriginalName("ErrNotFindHostWorldScene")]
		ErrNotFindHostWorldScene,
		// Token: 0x0400B0A2 RID: 45218
		[OriginalName("ErrCanNotRepeatCreateNeedSaveScene")]
		ErrCanNotRepeatCreateNeedSaveScene,
		// Token: 0x0400B0A3 RID: 45219
		[OriginalName("DeadStateCanNotAgreeOherEnter")]
		DeadStateCanNotAgreeOherEnter,
		// Token: 0x0400B0A4 RID: 45220
		[OriginalName("HostIsDeadStateCanNotEnter")]
		HostIsDeadStateCanNotEnter,
		// Token: 0x0400B0A5 RID: 45221
		[OriginalName("ErrSceneIsLoadingCanNotLeave")]
		ErrSceneIsLoadingCanNotLeave,
		// Token: 0x0400B0A6 RID: 45222
		[OriginalName("ErrInstCanNotReChallenge")]
		ErrInstCanNotReChallenge,
		// Token: 0x0400B0A7 RID: 45223
		[OriginalName("ErrInstMemberNotEnoughCanNotReChallenge")]
		ErrInstMemberNotEnoughCanNotReChallenge,
		// Token: 0x0400B0A8 RID: 45224
		[OriginalName("ErrInstHavePlayerLeaveCanNotReChallenge")]
		ErrInstHavePlayerLeaveCanNotReChallenge,
		// Token: 0x0400B0A9 RID: 45225
		[OriginalName("ErrInstHavePlayerNotDeadCanNotReChallenge")]
		ErrInstHavePlayerNotDeadCanNotReChallenge,
		// Token: 0x0400B0AA RID: 45226
		[OriginalName("ErrInstNotSettleCanNotReChallenge")]
		ErrInstNotSettleCanNotReChallenge,
		// Token: 0x0400B0AB RID: 45227
		[OriginalName("ErrInstCanNotRepetApplyRechallenge")]
		ErrInstCanNotRepetApplyRechallenge,
		// Token: 0x0400B0AC RID: 45228
		[OriginalName("ErrInstCanNotRepetReceiveRechallenge")]
		ErrInstCanNotRepetReceiveRechallenge,
		// Token: 0x0400B0AD RID: 45229
		[OriginalName("ErrInstOwnerCanIniviteRechallenge")]
		ErrInstOwnerCanIniviteRechallenge,
		// Token: 0x0400B0AE RID: 45230
		[OriginalName("ErrInstOwnerCanNotReceiveRechallenge")]
		ErrInstOwnerCanNotReceiveRechallenge,
		// Token: 0x0400B0AF RID: 45231
		[OriginalName("ErrPlayerIsLogoutCanNotCreateScene")]
		ErrPlayerIsLogoutCanNotCreateScene,
		// Token: 0x0400B0B0 RID: 45232
		[OriginalName("ErrPlayerIsCreatingScene")]
		ErrPlayerIsCreatingScene,
		// Token: 0x0400B0B1 RID: 45233
		[OriginalName("ErrPlayerCreateSceneFail")]
		ErrPlayerCreateSceneFail,
		// Token: 0x0400B0B2 RID: 45234
		[OriginalName("ErrBigWorldCanNotReset")]
		ErrBigWorldCanNotReset,
		// Token: 0x0400B0B3 RID: 45235
		[OriginalName("ErrMultiGameModeCanNotReset")]
		ErrMultiGameModeCanNotReset,
		// Token: 0x0400B0B4 RID: 45236
		[OriginalName("ErrIsEnterSceneApplyingCanNotDoRepeate")]
		ErrIsEnterSceneApplyingCanNotDoRepeate,
		// Token: 0x0400B0B5 RID: 45237
		[OriginalName("ErrIsQueryLobbyFriendDetailCanNotDoRepeate")]
		ErrIsQueryLobbyFriendDetailCanNotDoRepeate,
		// Token: 0x0400B0B6 RID: 45238
		[OriginalName("ErrIsQueryLobbyPlayerDetailCanNotDoRepeate")]
		ErrIsQueryLobbyPlayerDetailCanNotDoRepeate,
		// Token: 0x0400B0B7 RID: 45239
		[OriginalName("ErrPlayerIsLoadingCanNotDoTeleport")]
		ErrPlayerIsLoadingCanNotDoTeleport,
		// Token: 0x0400B0B8 RID: 45240
		[OriginalName("ErrPlayerIsTeleportCanNotDoTeleport")]
		ErrPlayerIsTeleportCanNotDoTeleport,
		// Token: 0x0400B0B9 RID: 45241
		[OriginalName("ErrTeleportPositionIllegal")]
		ErrTeleportPositionIllegal,
		// Token: 0x0400B0BA RID: 45242
		[OriginalName("ErrPlayerIsLoadingCanNotRevive")]
		ErrPlayerIsLoadingCanNotRevive,
		// Token: 0x0400B0BB RID: 45243
		[OriginalName("ErrPlayerIsTeleportCanNotRevive")]
		ErrPlayerIsTeleportCanNotRevive,
		// Token: 0x0400B0BC RID: 45244
		[OriginalName("ErrPlayerIsInTeleportCanNotBeKick")]
		ErrPlayerIsInTeleportCanNotBeKick,
		// Token: 0x0400B0BD RID: 45245
		[OriginalName("ErrTeamPlayerIsInTeleportCanNotDissolve")]
		ErrTeamPlayerIsInTeleportCanNotDissolve,
		// Token: 0x0400B0BE RID: 45246
		[OriginalName("ErrHostIsInTeleportCanNotApply")]
		ErrHostIsInTeleportCanNotApply,
		// Token: 0x0400B0BF RID: 45247
		[OriginalName("ErrIsInTeleportCanNotAcceptApply")]
		ErrIsInTeleportCanNotAcceptApply,
		// Token: 0x0400B0C0 RID: 45248
		[OriginalName("ErrStrNotIllegal")]
		ErrStrNotIllegal = 400000,
		// Token: 0x0400B0C1 RID: 45249
		[OriginalName("ErrBasicInfoPhotoUnlocked")]
		ErrBasicInfoPhotoUnlocked,
		// Token: 0x0400B0C2 RID: 45250
		[OriginalName("ErrBasicInfoFrameUnlocked")]
		ErrBasicInfoFrameUnlocked,
		// Token: 0x0400B0C3 RID: 45251
		[OriginalName("ErrCanNotGetSelfBasicInfo")]
		ErrCanNotGetSelfBasicInfo,
		// Token: 0x0400B0C4 RID: 45252
		[OriginalName("ErrMailNotExist")]
		ErrMailNotExist,
		// Token: 0x0400B0C5 RID: 45253
		[OriginalName("ErrMailAlreadyRead")]
		ErrMailAlreadyRead,
		// Token: 0x0400B0C6 RID: 45254
		[OriginalName("ErrNoMailCanGet")]
		ErrNoMailCanGet,
		// Token: 0x0400B0C7 RID: 45255
		[OriginalName("ErrMailNoAttachment")]
		ErrMailNoAttachment,
		// Token: 0x0400B0C8 RID: 45256
		[OriginalName("ErrMailAttachmentIsGet")]
		ErrMailAttachmentIsGet,
		// Token: 0x0400B0C9 RID: 45257
		[OriginalName("ErrMailAttachmentNotGet")]
		ErrMailAttachmentNotGet,
		// Token: 0x0400B0CA RID: 45258
		[OriginalName("ErrMailNotRead")]
		ErrMailNotRead,
		// Token: 0x0400B0CB RID: 45259
		[OriginalName("ErrNoMailCanDelete")]
		ErrNoMailCanDelete,
		// Token: 0x0400B0CC RID: 45260
		[OriginalName("ErrMailItemBagFull")]
		ErrMailItemBagFull,
		// Token: 0x0400B0CD RID: 45261
		[OriginalName("ErrMailFuncNotOpen")]
		ErrMailFuncNotOpen,
		// Token: 0x0400B0CE RID: 45262
		[OriginalName("ErrMailOverSize")]
		ErrMailOverSize,
		// Token: 0x0400B0CF RID: 45263
		[OriginalName("ErrMailTakeLimit")]
		ErrMailTakeLimit,
		// Token: 0x0400B0D0 RID: 45264
		[OriginalName("ErrMailAttachmentItemInvalidCount")]
		ErrMailAttachmentItemInvalidCount,
		// Token: 0x0400B0D1 RID: 45265
		[OriginalName("ErrMailAttachmentItemNoConf")]
		ErrMailAttachmentItemNoConf,
		// Token: 0x0400B0D2 RID: 45266
		[OriginalName("ErrMailNoConf")]
		ErrMailNoConf,
		// Token: 0x0400B0D3 RID: 45267
		[OriginalName("ErrShopIdNotExit")]
		ErrShopIdNotExit,
		// Token: 0x0400B0D4 RID: 45268
		[OriginalName("ErrShopInfoExist")]
		ErrShopInfoExist,
		// Token: 0x0400B0D5 RID: 45269
		[OriginalName("ErrShopTimeLimit")]
		ErrShopTimeLimit,
		// Token: 0x0400B0D6 RID: 45270
		[OriginalName("ErrShopMoneyId")]
		ErrShopMoneyId,
		// Token: 0x0400B0D7 RID: 45271
		[OriginalName("ErrShopNumLimit")]
		ErrShopNumLimit,
		// Token: 0x0400B0D8 RID: 45272
		[OriginalName("ErrShopCondLimit")]
		ErrShopCondLimit,
		// Token: 0x0400B0D9 RID: 45273
		[OriginalName("ErrShopBankNoExit")]
		ErrShopBankNoExit,
		// Token: 0x0400B0DA RID: 45274
		[OriginalName("ErrShopNoShow")]
		ErrShopNoShow,
		// Token: 0x0400B0DB RID: 45275
		[OriginalName("ErrShopVersion")]
		ErrShopVersion,
		// Token: 0x0400B0DC RID: 45276
		[OriginalName("ErrShopIlligalParam")]
		ErrShopIlligalParam,
		// Token: 0x0400B0DD RID: 45277
		[OriginalName("ErrDragonPoolConf")]
		ErrDragonPoolConf,
		// Token: 0x0400B0DE RID: 45278
		[OriginalName("ErrFullLevel")]
		ErrFullLevel,
		// Token: 0x0400B0DF RID: 45279
		[OriginalName("ErrItemConf")]
		ErrItemConf,
		// Token: 0x0400B0E0 RID: 45280
		[OriginalName("ErrNotEnoughItem")]
		ErrNotEnoughItem,
		// Token: 0x0400B0E1 RID: 45281
		[OriginalName("NotMingSuTi")]
		NotMingSuTi,
		// Token: 0x0400B0E2 RID: 45282
		[OriginalName("HadFinishMingSuTi")]
		HadFinishMingSuTi,
		// Token: 0x0400B0E3 RID: 45283
		[OriginalName("MingSuCallEntityFail")]
		MingSuCallEntityFail,
		// Token: 0x0400B0E4 RID: 45284
		[OriginalName("ErrDragonPoolFuncNotOpen")]
		ErrDragonPoolFuncNotOpen,
		// Token: 0x0400B0E5 RID: 45285
		[OriginalName("ErrWorldLevelHadDown")]
		ErrWorldLevelHadDown,
		// Token: 0x0400B0E6 RID: 45286
		[OriginalName("ErrWorldLevelNotDown")]
		ErrWorldLevelNotDown,
		// Token: 0x0400B0E7 RID: 45287
		[OriginalName("ErrWorldLevelMin")]
		ErrWorldLevelMin,
		// Token: 0x0400B0E8 RID: 45288
		[OriginalName("ErrWorldLevelCd")]
		ErrWorldLevelCd,
		// Token: 0x0400B0E9 RID: 45289
		[OriginalName("ErrIsBlockedPlayer")]
		ErrIsBlockedPlayer,
		// Token: 0x0400B0EA RID: 45290
		[OriginalName("ErrIsNotBlockedPlayer")]
		ErrIsNotBlockedPlayer,
		// Token: 0x0400B0EB RID: 45291
		[OriginalName("ErrBlockListCountMax")]
		ErrBlockListCountMax,
		// Token: 0x0400B0EC RID: 45292
		[OriginalName("ErrYouAreBlocked")]
		ErrYouAreBlocked,
		// Token: 0x0400B0ED RID: 45293
		[OriginalName("ErrAlreadyOnFriendList")]
		ErrAlreadyOnFriendList,
		// Token: 0x0400B0EE RID: 45294
		[OriginalName("ErrNotOnFriendList")]
		ErrNotOnFriendList,
		// Token: 0x0400B0EF RID: 45295
		[OriginalName("ErrAlreadyOnFriendApplyList")]
		ErrAlreadyOnFriendApplyList,
		// Token: 0x0400B0F0 RID: 45296
		[OriginalName("ErrFriendApplyNotExists")]
		ErrFriendApplyNotExists,
		// Token: 0x0400B0F1 RID: 45297
		[OriginalName("ErrFriendListCountMax")]
		ErrFriendListCountMax,
		// Token: 0x0400B0F2 RID: 45298
		[OriginalName("ErrInitiatorFriendListCountMax")]
		ErrInitiatorFriendListCountMax,
		// Token: 0x0400B0F3 RID: 45299
		[OriginalName("ErrReceiverApplyListCountMax")]
		ErrReceiverApplyListCountMax,
		// Token: 0x0400B0F4 RID: 45300
		[OriginalName("ErrCanNotFriendApplySendToSelf")]
		ErrCanNotFriendApplySendToSelf,
		// Token: 0x0400B0F5 RID: 45301
		[OriginalName("ErrFriendApplySended")]
		ErrFriendApplySended,
		// Token: 0x0400B0F6 RID: 45302
		[OriginalName("ErrFriendRemarkLengthLimit")]
		ErrFriendRemarkLengthLimit,
		// Token: 0x0400B0F7 RID: 45303
		[OriginalName("ErrFriendApplyRequestLimit")]
		ErrFriendApplyRequestLimit,
		// Token: 0x0400B0F8 RID: 45304
		[OriginalName("ErrFriendRequestEmpty")]
		ErrFriendRequestEmpty,
		// Token: 0x0400B0F9 RID: 45305
		[OriginalName("ErrFriendRequestOverSize")]
		ErrFriendRequestOverSize,
		// Token: 0x0400B0FA RID: 45306
		[OriginalName("ErrPayShopNotExists")]
		ErrPayShopNotExists,
		// Token: 0x0400B0FB RID: 45307
		[OriginalName("ErrPayShopDisabled")]
		ErrPayShopDisabled,
		// Token: 0x0400B0FC RID: 45308
		[OriginalName("ErrPayShopGoodsNotExists")]
		ErrPayShopGoodsNotExists,
		// Token: 0x0400B0FD RID: 45309
		[OriginalName("ErrPayShopGoodsDisabled")]
		ErrPayShopGoodsDisabled,
		// Token: 0x0400B0FE RID: 45310
		[OriginalName("ErrPayShopGoodsLocked")]
		ErrPayShopGoodsLocked,
		// Token: 0x0400B0FF RID: 45311
		[OriginalName("ErrPayShopGoodsOutSellTime")]
		ErrPayShopGoodsOutSellTime,
		// Token: 0x0400B100 RID: 45312
		[OriginalName("ErrPayShopGoodsBuyLimit")]
		ErrPayShopGoodsBuyLimit,
		// Token: 0x0400B101 RID: 45313
		[OriginalName("ErrPayShopDataChanged")]
		ErrPayShopDataChanged,
		// Token: 0x0400B102 RID: 45314
		[OriginalName("ErrPayShopIllegalBuyCount")]
		ErrPayShopIllegalBuyCount,
		// Token: 0x0400B103 RID: 45315
		[OriginalName("ErrPayShopIsDirect")]
		ErrPayShopIsDirect,
		// Token: 0x0400B104 RID: 45316
		[OriginalName("ErrPayShopIsNotDirect")]
		ErrPayShopIsNotDirect,
		// Token: 0x0400B105 RID: 45317
		[OriginalName("ErrPayShopTabDisabled")]
		ErrPayShopTabDisabled,
		// Token: 0x0400B106 RID: 45318
		[OriginalName("ErrMonthCardWithoutValidity")]
		ErrMonthCardWithoutValidity,
		// Token: 0x0400B107 RID: 45319
		[OriginalName("ErrMonthCardUpdateConfNotExist")]
		ErrMonthCardUpdateConfNotExist,
		// Token: 0x0400B108 RID: 45320
		[OriginalName("ErrMonthCardDaysMax")]
		ErrMonthCardDaysMax,
		// Token: 0x0400B109 RID: 45321
		[OriginalName("ErrMonthCardRewardGot")]
		ErrMonthCardRewardGot,
		// Token: 0x0400B10A RID: 45322
		[OriginalName("ErrMonthCardConfNotExist")]
		ErrMonthCardConfNotExist,
		// Token: 0x0400B10B RID: 45323
		[OriginalName("ErrIsNotSpecialItem")]
		ErrIsNotSpecialItem,
		// Token: 0x0400B10C RID: 45324
		[OriginalName("ErrNoEquipSpecialItem")]
		ErrNoEquipSpecialItem,
		// Token: 0x0400B10D RID: 45325
		[OriginalName("ErrNoValidBattlePass")]
		ErrNoValidBattlePass,
		// Token: 0x0400B10E RID: 45326
		[OriginalName("ErrBattlePassRewardNotFound")]
		ErrBattlePassRewardNotFound,
		// Token: 0x0400B10F RID: 45327
		[OriginalName("ErrBattlePassNotPaid")]
		ErrBattlePassNotPaid,
		// Token: 0x0400B110 RID: 45328
		[OriginalName("ErrBattlePassIsPaid")]
		ErrBattlePassIsPaid,
		// Token: 0x0400B111 RID: 45329
		[OriginalName("ErrBattlePassRewardLocked")]
		ErrBattlePassRewardLocked,
		// Token: 0x0400B112 RID: 45330
		[OriginalName("ErrBattlePassRewardTaken")]
		ErrBattlePassRewardTaken,
		// Token: 0x0400B113 RID: 45331
		[OriginalName("ErrBattlePassCanNotRepeatActive")]
		ErrBattlePassCanNotRepeatActive,
		// Token: 0x0400B114 RID: 45332
		[OriginalName("BattlePassNoRecurringReward")]
		BattlePassNoRecurringReward,
		// Token: 0x0400B115 RID: 45333
		[OriginalName("ErrBattlePassIsAdvanced")]
		ErrBattlePassIsAdvanced,
		// Token: 0x0400B116 RID: 45334
		[OriginalName("ErrBattlePassTaskNotFound")]
		ErrBattlePassTaskNotFound,
		// Token: 0x0400B117 RID: 45335
		[OriginalName("ErrBattlePassTaskNotFinished")]
		ErrBattlePassTaskNotFinished,
		// Token: 0x0400B118 RID: 45336
		[OriginalName("ErrBattlePassTaskTaken")]
		ErrBattlePassTaskTaken,
		// Token: 0x0400B119 RID: 45337
		[OriginalName("ErrBattlePassExpIsFull")]
		ErrBattlePassExpIsFull,
		// Token: 0x0400B11A RID: 45338
		[OriginalName("ErrAdviceNotFound")]
		ErrAdviceNotFound,
		// Token: 0x0400B11B RID: 45339
		[OriginalName("ErrConjunctionCanNotWord")]
		ErrConjunctionCanNotWord,
		// Token: 0x0400B11C RID: 45340
		[OriginalName("ErrAdviceTextNotExists")]
		ErrAdviceTextNotExists,
		// Token: 0x0400B11D RID: 45341
		[OriginalName("ErrAdviceWordNotExists")]
		ErrAdviceWordNotExists,
		// Token: 0x0400B11E RID: 45342
		[OriginalName("ErrAdviceTemplateNotExists")]
		ErrAdviceTemplateNotExists,
		// Token: 0x0400B11F RID: 45343
		[OriginalName("ErrAdviceCellCalcException")]
		ErrAdviceCellCalcException,
		// Token: 0x0400B120 RID: 45344
		[OriginalName("ErrIsNotAdviceEntity")]
		ErrIsNotAdviceEntity,
		// Token: 0x0400B121 RID: 45345
		[OriginalName("ErrAdviceCreateLimit")]
		ErrAdviceCreateLimit,
		// Token: 0x0400B122 RID: 45346
		[OriginalName("ErrAdviceContentCanNotEmpty")]
		ErrAdviceContentCanNotEmpty,
		// Token: 0x0400B123 RID: 45347
		[OriginalName("ErrAdviceEntityNotFount")]
		ErrAdviceEntityNotFount,
		// Token: 0x0400B124 RID: 45348
		[OriginalName("ErrAdviceVoteLimit")]
		ErrAdviceVoteLimit,
		// Token: 0x0400B125 RID: 45349
		[OriginalName("ErrAdviceIsVoteUp")]
		ErrAdviceIsVoteUp,
		// Token: 0x0400B126 RID: 45350
		[OriginalName("ErrAdviceIsVoteDown")]
		ErrAdviceIsVoteDown,
		// Token: 0x0400B127 RID: 45351
		[OriginalName("ErrNoAdviceItem")]
		ErrNoAdviceItem,
		// Token: 0x0400B128 RID: 45352
		[OriginalName("ErrAdviceCreateNotOpen")]
		ErrAdviceCreateNotOpen,
		// Token: 0x0400B129 RID: 45353
		[OriginalName("ErrAdviceCanNotCreateByVisitor")]
		ErrAdviceCanNotCreateByVisitor,
		// Token: 0x0400B12A RID: 45354
		[OriginalName("ErrAdviceSetingIsShow")]
		ErrAdviceSetingIsShow,
		// Token: 0x0400B12B RID: 45355
		[OriginalName("ErrAdviceSetingIsNoShow")]
		ErrAdviceSetingIsNoShow,
		// Token: 0x0400B12C RID: 45356
		[OriginalName("ErrAdviceUpMaxValue")]
		ErrAdviceUpMaxValue,
		// Token: 0x0400B12D RID: 45357
		[OriginalName("ErrAdviceDownMaxValue")]
		ErrAdviceDownMaxValue,
		// Token: 0x0400B12E RID: 45358
		[OriginalName("ProtoVersionCheckFail")]
		ProtoVersionCheckFail,
		// Token: 0x0400B12F RID: 45359
		[OriginalName("ProtoMd5CheckFail")]
		ProtoMd5CheckFail,
		// Token: 0x0400B130 RID: 45360
		[OriginalName("ConfigVersionCheckFail")]
		ConfigVersionCheckFail,
		// Token: 0x0400B131 RID: 45361
		[OriginalName("ConfigMd5CheckFail")]
		ConfigMd5CheckFail,
		// Token: 0x0400B132 RID: 45362
		[OriginalName("ErrInvalidMonthCardDays")]
		ErrInvalidMonthCardDays,
		// Token: 0x0400B133 RID: 45363
		[OriginalName("ErrMonthCardExtendedDaysMax")]
		ErrMonthCardExtendedDaysMax,
		// Token: 0x0400B134 RID: 45364
		[OriginalName("ErrMobileButtonNoCfg")]
		ErrMobileButtonNoCfg,
		// Token: 0x0400B135 RID: 45365
		[OriginalName("ErrMoneyWrongPayCount")]
		ErrMoneyWrongPayCount,
		// Token: 0x0400B136 RID: 45366
		[OriginalName("ErrMailTextSenderNotFound")]
		ErrMailTextSenderNotFound,
		// Token: 0x0400B137 RID: 45367
		[OriginalName("ErrMailTextTitleNotFound")]
		ErrMailTextTitleNotFound,
		// Token: 0x0400B138 RID: 45368
		[OriginalName("ErrMailTextContentNotFound")]
		ErrMailTextContentNotFound,
		// Token: 0x0400B139 RID: 45369
		[OriginalName("ErrAdviceIsNotVoteUp")]
		ErrAdviceIsNotVoteUp,
		// Token: 0x0400B13A RID: 45370
		[OriginalName("ErrParkourChallengeNoConf")]
		ErrParkourChallengeNoConf,
		// Token: 0x0400B13B RID: 45371
		[OriginalName("ErrParkourLocationNoConf")]
		ErrParkourLocationNoConf,
		// Token: 0x0400B13C RID: 45372
		[OriginalName("ErrParkourChallengeNotOpen")]
		ErrParkourChallengeNotOpen,
		// Token: 0x0400B13D RID: 45373
		[OriginalName("ErrParkourChallengeNoData")]
		ErrParkourChallengeNoData,
		// Token: 0x0400B13E RID: 45374
		[OriginalName("ErrParkourChallengeTaken")]
		ErrParkourChallengeTaken,
		// Token: 0x0400B13F RID: 45375
		[OriginalName("ErrParkourChallengeUnderscore")]
		ErrParkourChallengeUnderscore,
		// Token: 0x0400B140 RID: 45376
		[OriginalName("ErrParkourChallengeScoreNoConf")]
		ErrParkourChallengeScoreNoConf,
		// Token: 0x0400B141 RID: 45377
		[OriginalName("ErrParkourTakeFail")]
		ErrParkourTakeFail,
		// Token: 0x0400B142 RID: 45378
		[OriginalName("ErrShopIllegalBuyCount")]
		ErrShopIllegalBuyCount,
		// Token: 0x0400B143 RID: 45379
		[OriginalName("ErrQuestErrTaskId")]
		ErrQuestErrTaskId = 500000,
		// Token: 0x0400B144 RID: 45380
		[OriginalName("ErrQuestErrStepId")]
		ErrQuestErrStepId,
		// Token: 0x0400B145 RID: 45381
		[OriginalName("ErrQuestErrTaskBag")]
		ErrQuestErrTaskBag,
		// Token: 0x0400B146 RID: 45382
		[OriginalName("ErrQuestStepStatusNotCanAccept")]
		ErrQuestStepStatusNotCanAccept,
		// Token: 0x0400B147 RID: 45383
		[OriginalName("ErrQuestStepStatusNotCanCommit")]
		ErrQuestStepStatusNotCanCommit,
		// Token: 0x0400B148 RID: 45384
		[OriginalName("ErrQuestStepConf")]
		ErrQuestStepConf,
		// Token: 0x0400B149 RID: 45385
		[OriginalName("ErrQuestStepData")]
		ErrQuestStepData,
		// Token: 0x0400B14A RID: 45386
		[OriginalName("ErrQuestCanNotAccept")]
		ErrQuestCanNotAccept,
		// Token: 0x0400B14B RID: 45387
		[OriginalName("ErrAreaQuestDelegationBoardRequest")]
		ErrAreaQuestDelegationBoardRequest,
		// Token: 0x0400B14C RID: 45388
		[OriginalName("ErrAreaQuestAreaIdErr")]
		ErrAreaQuestAreaIdErr,
		// Token: 0x0400B14D RID: 45389
		[OriginalName("ErrAreaQuestExpired")]
		ErrAreaQuestExpired,
		// Token: 0x0400B14E RID: 45390
		[OriginalName("ErrDevoteLevel")]
		ErrDevoteLevel,
		// Token: 0x0400B14F RID: 45391
		[OriginalName("ErrDevoteRewardReceived")]
		ErrDevoteRewardReceived,
		// Token: 0x0400B150 RID: 45392
		[OriginalName("ErrQuestNotFinish")]
		ErrQuestNotFinish,
		// Token: 0x0400B151 RID: 45393
		[OriginalName("ErrDevoteId")]
		ErrDevoteId,
		// Token: 0x0400B152 RID: 45394
		[OriginalName("ErrAreaQuestLimit")]
		ErrAreaQuestLimit,
		// Token: 0x0400B153 RID: 45395
		[OriginalName("ErrQuestNodeNotActive")]
		ErrQuestNodeNotActive,
		// Token: 0x0400B154 RID: 45396
		[OriginalName("ErrQuestNotActiveId")]
		ErrQuestNotActiveId,
		// Token: 0x0400B155 RID: 45397
		[OriginalName("ErrQuestNodeNotFound")]
		ErrQuestNodeNotFound,
		// Token: 0x0400B156 RID: 45398
		[OriginalName("ErrQuestComNotFound")]
		ErrQuestComNotFound,
		// Token: 0x0400B157 RID: 45399
		[OriginalName("ErrQuestTraceType")]
		ErrQuestTraceType,
		// Token: 0x0400B158 RID: 45400
		[OriginalName("ErrQuestNotProgress")]
		ErrQuestNotProgress,
		// Token: 0x0400B159 RID: 45401
		[OriginalName("ErrQuestNoCombatState")]
		ErrQuestNoCombatState,
		// Token: 0x0400B15A RID: 45402
		[OriginalName("ErrQuestNodeData")]
		ErrQuestNodeData,
		// Token: 0x0400B15B RID: 45403
		[OriginalName("ErrQuestNotChildQuestNode")]
		ErrQuestNotChildQuestNode,
		// Token: 0x0400B15C RID: 45404
		[OriginalName("ErrQuestNotClientSubmit")]
		ErrQuestNotClientSubmit,
		// Token: 0x0400B15D RID: 45405
		[OriginalName("ErrQuestAccepted")]
		ErrQuestAccepted,
		// Token: 0x0400B15E RID: 45406
		[OriginalName("ErrResourceOccupation")]
		ErrResourceOccupation,
		// Token: 0x0400B15F RID: 45407
		[OriginalName("ErrRequestOccupationType")]
		ErrRequestOccupationType,
		// Token: 0x0400B160 RID: 45408
		[OriginalName("ErrNotFoundOccupation")]
		ErrNotFoundOccupation,
		// Token: 0x0400B161 RID: 45409
		[OriginalName("ErrNotOnlineQuestAccept")]
		ErrNotOnlineQuestAccept,
		// Token: 0x0400B162 RID: 45410
		[OriginalName("ErrQuestDestroy")]
		ErrQuestDestroy,
		// Token: 0x0400B163 RID: 45411
		[OriginalName("ErrTreeNodeNotFind")]
		ErrTreeNodeNotFind,
		// Token: 0x0400B164 RID: 45412
		[OriginalName("ErrTreeNodeNotActive")]
		ErrTreeNodeNotActive,
		// Token: 0x0400B165 RID: 45413
		[OriginalName("ErrIsNotChildQuestNode")]
		ErrIsNotChildQuestNode,
		// Token: 0x0400B166 RID: 45414
		[OriginalName("ErrChildQuestConditionCanNotSubmit")]
		ErrChildQuestConditionCanNotSubmit,
		// Token: 0x0400B167 RID: 45415
		[OriginalName("ErrNodeNotFindAction")]
		ErrNodeNotFindAction,
		// Token: 0x0400B168 RID: 45416
		[OriginalName("ErrNodeActionIsFinish")]
		ErrNodeActionIsFinish,
		// Token: 0x0400B169 RID: 45417
		[OriginalName("ErrNodeActionGetItemIsNotQuestItem")]
		ErrNodeActionGetItemIsNotQuestItem,
		// Token: 0x0400B16A RID: 45418
		[OriginalName("ErrNodeActionGetItemHasNotFreeSize")]
		ErrNodeActionGetItemHasNotFreeSize,
		// Token: 0x0400B16B RID: 45419
		[OriginalName("ErrInvalidBtType")]
		ErrInvalidBtType,
		// Token: 0x0400B16C RID: 45420
		[OriginalName("ErrTimerNotFind")]
		ErrTimerNotFind,
		// Token: 0x0400B16D RID: 45421
		[OriginalName("ErrPreCondition")]
		ErrPreCondition,
		// Token: 0x0400B16E RID: 45422
		[OriginalName("ErrHandIdItemData")]
		ErrHandIdItemData,
		// Token: 0x0400B16F RID: 45423
		[OriginalName("ErrTreeNotFailedNode")]
		ErrTreeNotFailedNode,
		// Token: 0x0400B170 RID: 45424
		[OriginalName("ErrTreeNotFailConf")]
		ErrTreeNotFailConf,
		// Token: 0x0400B171 RID: 45425
		[OriginalName("ErrTreeNotGiveUpConf")]
		ErrTreeNotGiveUpConf,
		// Token: 0x0400B172 RID: 45426
		[OriginalName("ErrTreeNotRollback")]
		ErrTreeNotRollback,
		// Token: 0x0400B173 RID: 45427
		[OriginalName("ErrNodeNotFindNpcId")]
		ErrNodeNotFindNpcId,
		// Token: 0x0400B174 RID: 45428
		[OriginalName("ErrNotRollbackPermission")]
		ErrNotRollbackPermission,
		// Token: 0x0400B175 RID: 45429
		[OriginalName("ErrNotRollbackRepeat")]
		ErrNotRollbackRepeat,
		// Token: 0x0400B176 RID: 45430
		[OriginalName("ErrTreeSuspend")]
		ErrTreeSuspend,
		// Token: 0x0400B177 RID: 45431
		[OriginalName("ErrPlayerNotInQuestMap")]
		ErrPlayerNotInQuestMap,
		// Token: 0x0400B178 RID: 45432
		[OriginalName("ErrSaveNewNotRollback")]
		ErrSaveNewNotRollback,
		// Token: 0x0400B179 RID: 45433
		[OriginalName("ErrUiPlayType")]
		ErrUiPlayType,
		// Token: 0x0400B17A RID: 45434
		[OriginalName("ErrOccupationTime")]
		ErrOccupationTime,
		// Token: 0x0400B17B RID: 45435
		[OriginalName("ErrReleaseTime")]
		ErrReleaseTime,
		// Token: 0x0400B17C RID: 45436
		[OriginalName("ErrActionSetTime")]
		ErrActionSetTime,
		// Token: 0x0400B17D RID: 45437
		[OriginalName("ErrForcedOccupationResource")]
		ErrForcedOccupationResource,
		// Token: 0x0400B17E RID: 45438
		[OriginalName("ErrAddPlayBubble")]
		ErrAddPlayBubble,
		// Token: 0x0400B17F RID: 45439
		[OriginalName("ErrDisableSwitchOccupation")]
		ErrDisableSwitchOccupation,
		// Token: 0x0400B180 RID: 45440
		[OriginalName("ErrOpenSystemBoardResultFail")]
		ErrOpenSystemBoardResultFail,
		// Token: 0x0400B181 RID: 45441
		[OriginalName("ErrEntityNoInhaledComponent")]
		ErrEntityNoInhaledComponent,
		// Token: 0x0400B182 RID: 45442
		[OriginalName("ErrEntityInhaledStrength")]
		ErrEntityInhaledStrength,
		// Token: 0x0400B183 RID: 45443
		[OriginalName("ErrDisableSwitchGender")]
		ErrDisableSwitchGender,
		// Token: 0x0400B184 RID: 45444
		[OriginalName("ErrTapeDefault")]
		ErrTapeDefault = 600000,
		// Token: 0x0400B185 RID: 45445
		[OriginalName("ErrTapeInvalidPos")]
		ErrTapeInvalidPos,
		// Token: 0x0400B186 RID: 45446
		[OriginalName("ErrTapeIsNotActiveRole")]
		ErrTapeIsNotActiveRole,
		// Token: 0x0400B187 RID: 45447
		[OriginalName("ErrTapeItemTypeFail")]
		ErrTapeItemTypeFail,
		// Token: 0x0400B188 RID: 45448
		[OriginalName("ErrTapeNotExistTapeItem")]
		ErrTapeNotExistTapeItem,
		// Token: 0x0400B189 RID: 45449
		[OriginalName("ErrTapeNotExistTapeConfig")]
		ErrTapeNotExistTapeConfig,
		// Token: 0x0400B18A RID: 45450
		[OriginalName("ErrTapeNotExistTapeProps")]
		ErrTapeNotExistTapeProps,
		// Token: 0x0400B18B RID: 45451
		[OriginalName("ErrTapeHasTakeOnTape")]
		ErrTapeHasTakeOnTape,
		// Token: 0x0400B18C RID: 45452
		[OriginalName("ErrTapeHasNotTakeOnTape")]
		ErrTapeHasNotTakeOnTape,
		// Token: 0x0400B18D RID: 45453
		[OriginalName("ErrTapeNotExistTapeQualityConfig")]
		ErrTapeNotExistTapeQualityConfig,
		// Token: 0x0400B18E RID: 45454
		[OriginalName("ErrTapeNotExistLevelUpExpConfig")]
		ErrTapeNotExistLevelUpExpConfig,
		// Token: 0x0400B18F RID: 45455
		[OriginalName("ErrTapeInvalidLevelUpExpValue")]
		ErrTapeInvalidLevelUpExpValue,
		// Token: 0x0400B190 RID: 45456
		[OriginalName("ErrTapeNotExistExpDecayRatioConfig")]
		ErrTapeNotExistExpDecayRatioConfig,
		// Token: 0x0400B191 RID: 45457
		[OriginalName("ErrTapeLevelUpEqualItem")]
		ErrTapeLevelUpEqualItem,
		// Token: 0x0400B192 RID: 45458
		[OriginalName("ErrTapeLevelUpRepeatItem")]
		ErrTapeLevelUpRepeatItem,
		// Token: 0x0400B193 RID: 45459
		[OriginalName("ErrTapeLevelUpInvalidExpItemNum")]
		ErrTapeLevelUpInvalidExpItemNum,
		// Token: 0x0400B194 RID: 45460
		[OriginalName("ErrTapeLevelUpInvalidExpRate")]
		ErrTapeLevelUpInvalidExpRate,
		// Token: 0x0400B195 RID: 45461
		[OriginalName("ErrTapeLevelUpInvalidAddExp")]
		ErrTapeLevelUpInvalidAddExp,
		// Token: 0x0400B196 RID: 45462
		[OriginalName("ErrTapeLevelUpMaxLevel")]
		ErrTapeLevelUpMaxLevel,
		// Token: 0x0400B197 RID: 45463
		[OriginalName("ErrTapeLevelUpConsumeItemNotEnough")]
		ErrTapeLevelUpConsumeItemNotEnough,
		// Token: 0x0400B198 RID: 45464
		[OriginalName("ErrTapeLevelUpMaterialLock")]
		ErrTapeLevelUpMaterialLock,
		// Token: 0x0400B199 RID: 45465
		[OriginalName("ErrTapeTransferEqualItem")]
		ErrTapeTransferEqualItem,
		// Token: 0x0400B19A RID: 45466
		[OriginalName("ErrTapeTransferQualityNotEqual")]
		ErrTapeTransferQualityNotEqual,
		// Token: 0x0400B19B RID: 45467
		[OriginalName("ErrTapeTransferSuitNotEqual")]
		ErrTapeTransferSuitNotEqual,
		// Token: 0x0400B19C RID: 45468
		[OriginalName("ErrTapeTransferMaterialLock")]
		ErrTapeTransferMaterialLock,
		// Token: 0x0400B19D RID: 45469
		[OriginalName("ErrTapeTransferMaterialEquipped")]
		ErrTapeTransferMaterialEquipped,
		// Token: 0x0400B19E RID: 45470
		[OriginalName("ErrTapeNotExistTransferPropNumConfig")]
		ErrTapeNotExistTransferPropNumConfig,
		// Token: 0x0400B19F RID: 45471
		[OriginalName("ErrTapeTransferPropNumIsMax")]
		ErrTapeTransferPropNumIsMax,
		// Token: 0x0400B1A0 RID: 45472
		[OriginalName("ErrTapeTransferRandomSubPropFail")]
		ErrTapeTransferRandomSubPropFail,
		// Token: 0x0400B1A1 RID: 45473
		[OriginalName("ErrTapeResetTransferHasNotProp")]
		ErrTapeResetTransferHasNotProp,
		// Token: 0x0400B1A2 RID: 45474
		[OriginalName("ErrTapeResetTransferMaterialNotEnough")]
		ErrTapeResetTransferMaterialNotEnough,
		// Token: 0x0400B1A3 RID: 45475
		[OriginalName("ErrTapeNotExistTapeExpItem")]
		ErrTapeNotExistTapeExpItem,
		// Token: 0x0400B1A4 RID: 45476
		[OriginalName("ErrTapeNotExistTapeExpItemConfig")]
		ErrTapeNotExistTapeExpItemConfig,
		// Token: 0x0400B1A5 RID: 45477
		[OriginalName("ErrCollectEntityNotExist")]
		ErrCollectEntityNotExist,
		// Token: 0x0400B1A6 RID: 45478
		[OriginalName("ErrCollectInvalidEntityMainType")]
		ErrCollectInvalidEntityMainType,
		// Token: 0x0400B1A7 RID: 45479
		[OriginalName("ErrRunningLevelPlayNotFind")]
		ErrRunningLevelPlayNotFind,
		// Token: 0x0400B1A8 RID: 45480
		[OriginalName("ErrLevelPlayInteractionEntity")]
		ErrLevelPlayInteractionEntity,
		// Token: 0x0400B1A9 RID: 45481
		[OriginalName("ErrLevelPlayNotExistByConfId")]
		ErrLevelPlayNotExistByConfId,
		// Token: 0x0400B1AA RID: 45482
		[OriginalName("ErrLevelPlayNotCreate")]
		ErrLevelPlayNotCreate,
		// Token: 0x0400B1AB RID: 45483
		[OriginalName("ErrLevelPlayRewarded")]
		ErrLevelPlayRewarded,
		// Token: 0x0400B1AC RID: 45484
		[OriginalName("ErrLevelPlayInteractionType")]
		ErrLevelPlayInteractionType,
		// Token: 0x0400B1AD RID: 45485
		[OriginalName("ErrLevelPlayNotPlayer")]
		ErrLevelPlayNotPlayer,
		// Token: 0x0400B1AE RID: 45486
		[OriginalName("ErrLevelPlayNotComplete")]
		ErrLevelPlayNotComplete,
		// Token: 0x0400B1AF RID: 45487
		[OriginalName("ErrLevelPlayRewardFail")]
		ErrLevelPlayRewardFail,
		// Token: 0x0400B1B0 RID: 45488
		[OriginalName("ErrLevelPlayNotWaitState")]
		ErrLevelPlayNotWaitState,
		// Token: 0x0400B1B1 RID: 45489
		[OriginalName("ErrLevelPlayAction")]
		ErrLevelPlayAction,
		// Token: 0x0400B1B2 RID: 45490
		[OriginalName("ErrLevelPlayGetRewardLimit")]
		ErrLevelPlayGetRewardLimit,
		// Token: 0x0400B1B3 RID: 45491
		[OriginalName("ErrFlowNotExist")]
		ErrFlowNotExist,
		// Token: 0x0400B1B4 RID: 45492
		[OriginalName("ErrFlowHaveNotActionWait")]
		ErrFlowHaveNotActionWait,
		// Token: 0x0400B1B5 RID: 45493
		[OriginalName("ErrFlowHaveNotTalkWait")]
		ErrFlowHaveNotTalkWait,
		// Token: 0x0400B1B6 RID: 45494
		[OriginalName("ErrFlowHaveNotOptionWait")]
		ErrFlowHaveNotOptionWait,
		// Token: 0x0400B1B7 RID: 45495
		[OriginalName("ErrFlowInvalidOptionId")]
		ErrFlowInvalidOptionId,
		// Token: 0x0400B1B8 RID: 45496
		[OriginalName("ErrInteractFlowCanNotPlay")]
		ErrInteractFlowCanNotPlay,
		// Token: 0x0400B1B9 RID: 45497
		[OriginalName("ErrInteractInvalidFlowState")]
		ErrInteractInvalidFlowState,
		// Token: 0x0400B1BA RID: 45498
		[OriginalName("ErrInteractOptionOwnerIsNotFlowOwner")]
		ErrInteractOptionOwnerIsNotFlowOwner,
		// Token: 0x0400B1BB RID: 45499
		[OriginalName("ErrInteractOptionOwnerIsNotActionOwner")]
		ErrInteractOptionOwnerIsNotActionOwner,
		// Token: 0x0400B1BC RID: 45500
		[OriginalName("ErrActionOwnerIsNotEntity")]
		ErrActionOwnerIsNotEntity,
		// Token: 0x0400B1BD RID: 45501
		[OriginalName("ErrActionOwnerNotFound")]
		ErrActionOwnerNotFound,
		// Token: 0x0400B1BE RID: 45502
		[OriginalName("ErrActionSceneNotFound")]
		ErrActionSceneNotFound,
		// Token: 0x0400B1BF RID: 45503
		[OriginalName("ErrActionGroupNotFound")]
		ErrActionGroupNotFound,
		// Token: 0x0400B1C0 RID: 45504
		[OriginalName("ErrFinishClientActionFail")]
		ErrFinishClientActionFail,
		// Token: 0x0400B1C1 RID: 45505
		[OriginalName("ErrActionHostPlayerNotFound")]
		ErrActionHostPlayerNotFound,
		// Token: 0x0400B1C2 RID: 45506
		[OriginalName("ErrActionFail")]
		ErrActionFail,
		// Token: 0x0400B1C3 RID: 45507
		[OriginalName("ErrActionPlayerNotFound")]
		ErrActionPlayerNotFound,
		// Token: 0x0400B1C4 RID: 45508
		[OriginalName("ErrInteractMultiGameMode")]
		ErrInteractMultiGameMode,
		// Token: 0x0400B1C5 RID: 45509
		[OriginalName("ErrInteractAddFlowFail")]
		ErrInteractAddFlowFail,
		// Token: 0x0400B1C6 RID: 45510
		[OriginalName("ErrBehaviorTreeOwnerNotFound")]
		ErrBehaviorTreeOwnerNotFound,
		// Token: 0x0400B1C7 RID: 45511
		[OriginalName("ErrBehaviorTreeNotFound")]
		ErrBehaviorTreeNotFound,
		// Token: 0x0400B1C8 RID: 45512
		[OriginalName("ErrBehaviorTreePending")]
		ErrBehaviorTreePending,
		// Token: 0x0400B1C9 RID: 45513
		[OriginalName("ErrBehaviorTreeTimerTypeNotFound")]
		ErrBehaviorTreeTimerTypeNotFound,
		// Token: 0x0400B1CA RID: 45514
		[OriginalName("ErrBehaviorTreeStopTimerFail")]
		ErrBehaviorTreeStopTimerFail,
		// Token: 0x0400B1CB RID: 45515
		[OriginalName("ErrBehaviorTreeTimerCompNotFound")]
		ErrBehaviorTreeTimerCompNotFound,
		// Token: 0x0400B1CC RID: 45516
		[OriginalName("ErrInteractCd")]
		ErrInteractCd,
		// Token: 0x0400B1CD RID: 45517
		[OriginalName("ErrInteractRange")]
		ErrInteractRange,
		// Token: 0x0400B1CE RID: 45518
		[OriginalName("ErrDropPickRange")]
		ErrDropPickRange,
		// Token: 0x0400B1CF RID: 45519
		[OriginalName("ErrBtTmpItemContextNotExist")]
		ErrBtTmpItemContextNotExist,
		// Token: 0x0400B1D0 RID: 45520
		[OriginalName("ErrBtTmpItemBtObjNotExist")]
		ErrBtTmpItemBtObjNotExist,
		// Token: 0x0400B1D1 RID: 45521
		[OriginalName("ErrPlayerBigWorldNotExist")]
		ErrPlayerBigWorldNotExist,
		// Token: 0x0400B1D2 RID: 45522
		[OriginalName("ErrRoleEntityNotExist")]
		ErrRoleEntityNotExist,
		// Token: 0x0400B1D3 RID: 45523
		[OriginalName("ErrAddFlowFail")]
		ErrAddFlowFail,
		// Token: 0x0400B1D4 RID: 45524
		[OriginalName("ErrInteracting")]
		ErrInteracting,
		// Token: 0x0400B1D5 RID: 45525
		[OriginalName("ErrInteractCollectBagFull")]
		ErrInteractCollectBagFull,
		// Token: 0x0400B1D6 RID: 45526
		[OriginalName("ErrBtObjIsNotInstPlay")]
		ErrBtObjIsNotInstPlay,
		// Token: 0x0400B1D7 RID: 45527
		[OriginalName("ErrReviveConfigNotExist")]
		ErrReviveConfigNotExist,
		// Token: 0x0400B1D8 RID: 45528
		[OriginalName("ErrFinishFlowFail")]
		ErrFinishFlowFail,
		// Token: 0x0400B1D9 RID: 45529
		[OriginalName("ErrFlowActionFail")]
		ErrFlowActionFail,
		// Token: 0x0400B1DA RID: 45530
		[OriginalName("ErrGmSubmitChildQuestNodeMaxDepth")]
		ErrGmSubmitChildQuestNodeMaxDepth,
		// Token: 0x0400B1DB RID: 45531
		[OriginalName("ErrGmSubmitChildQuestNodeIsNotProgress")]
		ErrGmSubmitChildQuestNodeIsNotProgress,
		// Token: 0x0400B1DC RID: 45532
		[OriginalName("ErrEntityPatrolComponentNotExist")]
		ErrEntityPatrolComponentNotExist,
		// Token: 0x0400B1DD RID: 45533
		[OriginalName("ErrInteractIsNotParticipant")]
		ErrInteractIsNotParticipant,
		// Token: 0x0400B1DE RID: 45534
		[OriginalName("ErrVisionEntityInteractFail")]
		ErrVisionEntityInteractFail,
		// Token: 0x0400B1DF RID: 45535
		[OriginalName("ErrMaxDropTimes")]
		ErrMaxDropTimes,
		// Token: 0x0400B1E0 RID: 45536
		[OriginalName("ErrStateEntityMultiHang")]
		ErrStateEntityMultiHang,
		// Token: 0x0400B1E1 RID: 45537
		[OriginalName("ErrPlayerLoading")]
		ErrPlayerLoading,
		// Token: 0x0400B1E2 RID: 45538
		[OriginalName("ErrPlayerTeleporting")]
		ErrPlayerTeleporting,
		// Token: 0x0400B1E3 RID: 45539
		[OriginalName("ErrInteractBtPending")]
		ErrInteractBtPending,
		// Token: 0x0400B1E4 RID: 45540
		[OriginalName("ErrInteractDead")]
		ErrInteractDead,
		// Token: 0x0400B1E5 RID: 45541
		[OriginalName("ErrMultiHangEntity")]
		ErrMultiHangEntity,
		// Token: 0x0400B1E6 RID: 45542
		[OriginalName("ErrRenjuCanNotResetWhenComplete")]
		ErrRenjuCanNotResetWhenComplete,
		// Token: 0x0400B1E7 RID: 45543
		[OriginalName("ErrRenjuCanNotMove")]
		ErrRenjuCanNotMove,
		// Token: 0x0400B1E8 RID: 45544
		[OriginalName("ErrEntityNotFound")]
		ErrEntityNotFound,
		// Token: 0x0400B1E9 RID: 45545
		[OriginalName("ErrSceneHostPlayerNotMatch")]
		ErrSceneHostPlayerNotMatch,
		// Token: 0x0400B1EA RID: 45546
		[OriginalName("ErrVehicleComponentNotFound")]
		ErrVehicleComponentNotFound,
		// Token: 0x0400B1EB RID: 45547
		[OriginalName("ErrVehicleSeatNotFound")]
		ErrVehicleSeatNotFound,
		// Token: 0x0400B1EC RID: 45548
		[OriginalName("ErrVehicleGettingOn")]
		ErrVehicleGettingOn,
		// Token: 0x0400B1ED RID: 45549
		[OriginalName("ErrPortalEntityNotFound")]
		ErrPortalEntityNotFound,
		// Token: 0x0400B1EE RID: 45550
		[OriginalName("ErrPortalCompNotFound")]
		ErrPortalCompNotFound,
		// Token: 0x0400B1EF RID: 45551
		[OriginalName("ErrPortalTeleportPosNotEqual")]
		ErrPortalTeleportPosNotEqual,
		// Token: 0x0400B1F0 RID: 45552
		[OriginalName("ErrPlayerNotInVehicle")]
		ErrPlayerNotInVehicle,
		// Token: 0x0400B1F1 RID: 45553
		[OriginalName("ErrVehiclePassengerRoleExist")]
		ErrVehiclePassengerRoleExist,
		// Token: 0x0400B1F2 RID: 45554
		[OriginalName("ErrCreateVehiclePassengerEntityFail")]
		ErrCreateVehiclePassengerEntityFail,
		// Token: 0x0400B1F3 RID: 45555
		[OriginalName("ErrVehiclePassengerNotFound")]
		ErrVehiclePassengerNotFound,
		// Token: 0x0400B1F4 RID: 45556
		[OriginalName("ErrCanNotMovePlacement")]
		ErrCanNotMovePlacement,
		// Token: 0x0400B1F5 RID: 45557
		[OriginalName("ErrGmSetLimitTeleportDungeon")]
		ErrGmSetLimitTeleportDungeon,
		// Token: 0x0400B1F6 RID: 45558
		[OriginalName("ErrMaxSetTagIdDepth")]
		ErrMaxSetTagIdDepth,
		// Token: 0x0400B1F7 RID: 45559
		[OriginalName("ErrBeforeSetStateTagId")]
		ErrBeforeSetStateTagId,
		// Token: 0x0400B1F8 RID: 45560
		[OriginalName("ErrSetStateTagIdLock")]
		ErrSetStateTagIdLock,
		// Token: 0x0400B1F9 RID: 45561
		[OriginalName("ErrDangoMonopolyActivityDataNotFound")]
		ErrDangoMonopolyActivityDataNotFound,
		// Token: 0x0400B1FA RID: 45562
		[OriginalName("ErrDangoMonopolyReqTaskRewardMax")]
		ErrDangoMonopolyReqTaskRewardMax,
		// Token: 0x0400B1FB RID: 45563
		[OriginalName("ErrDangoMonopolyTaskConfigNotFound")]
		ErrDangoMonopolyTaskConfigNotFound,
		// Token: 0x0400B1FC RID: 45564
		[OriginalName("ErrDangoMonopolyTaskNotCompleted")]
		ErrDangoMonopolyTaskNotCompleted,
		// Token: 0x0400B1FD RID: 45565
		[OriginalName("ErrDangoMonopolyTaskRewardHasGet")]
		ErrDangoMonopolyTaskRewardHasGet,
		// Token: 0x0400B1FE RID: 45566
		[OriginalName("ErrDangoMonopolyBoardConfigNotFound")]
		ErrDangoMonopolyBoardConfigNotFound,
		// Token: 0x0400B1FF RID: 45567
		[OriginalName("ErrDangoMonopolyGridRewardNotGet")]
		ErrDangoMonopolyGridRewardNotGet,
		// Token: 0x0400B200 RID: 45568
		[OriginalName("ErrDangoMonopolyHasNotDiceItem")]
		ErrDangoMonopolyHasNotDiceItem,
		// Token: 0x0400B201 RID: 45569
		[OriginalName("ErrDangoMonopolyHasNotGridReward")]
		ErrDangoMonopolyHasNotGridReward,
		// Token: 0x0400B202 RID: 45570
		[OriginalName("ErrDangoMonopolyGridConfigNotFound")]
		ErrDangoMonopolyGridConfigNotFound,
		// Token: 0x0400B203 RID: 45571
		[OriginalName("ErrDangoMonopolyReqBoardRewardMax")]
		ErrDangoMonopolyReqBoardRewardMax,
		// Token: 0x0400B204 RID: 45572
		[OriginalName("ErrDangoMonopolyBoardNotCompleted")]
		ErrDangoMonopolyBoardNotCompleted,
		// Token: 0x0400B205 RID: 45573
		[OriginalName("ErrDangoMonopolyBoardRewardHasGet")]
		ErrDangoMonopolyBoardRewardHasGet,
		// Token: 0x0400B206 RID: 45574
		[OriginalName("ErrDangoMonopolyActivityConfigNotFound")]
		ErrDangoMonopolyActivityConfigNotFound,
		// Token: 0x0400B207 RID: 45575
		[OriginalName("ErrDangoMonopolyBoardLock")]
		ErrDangoMonopolyBoardLock,
		// Token: 0x0400B208 RID: 45576
		[OriginalName("ErrChangeEntityStateActionEntityNotFound")]
		ErrChangeEntityStateActionEntityNotFound,
		// Token: 0x0400B209 RID: 45577
		[OriginalName("ErrDangoMonopolyDiceNumInvalid")]
		ErrDangoMonopolyDiceNumInvalid,
		// Token: 0x0400B20A RID: 45578
		[OriginalName("ErrDangoMonopolyBoardCompleted")]
		ErrDangoMonopolyBoardCompleted,
		// Token: 0x0400B20B RID: 45579
		[OriginalName("ErrLevelSequenceFrameEventCompNotFound")]
		ErrLevelSequenceFrameEventCompNotFound,
		// Token: 0x0400B20C RID: 45580
		[OriginalName("ErrLevelSequenceFrameEventDataNotFound")]
		ErrLevelSequenceFrameEventDataNotFound,
		// Token: 0x0400B20D RID: 45581
		[OriginalName("ErrLevelSequenceFrameEventSectionsNotFound")]
		ErrLevelSequenceFrameEventSectionsNotFound,
		// Token: 0x0400B20E RID: 45582
		[OriginalName("ErrActionCtxInvalid")]
		ErrActionCtxInvalid,
		// Token: 0x0400B20F RID: 45583
		[OriginalName("ErrActionOwnerInvalid")]
		ErrActionOwnerInvalid,
		// Token: 0x0400B210 RID: 45584
		[OriginalName("ErrGlobalFixCfgNotFound")]
		ErrGlobalFixCfgNotFound,
		// Token: 0x0400B211 RID: 45585
		[OriginalName("ErrActionGetItemIsNotQuestItem")]
		ErrActionGetItemIsNotQuestItem,
		// Token: 0x0400B212 RID: 45586
		[OriginalName("ErrGlobalFixExecuteCountMax")]
		ErrGlobalFixExecuteCountMax,
		// Token: 0x0400B213 RID: 45587
		[OriginalName("ErrActionGroupCreateTooFrequently")]
		ErrActionGroupCreateTooFrequently,
		// Token: 0x0400B214 RID: 45588
		[OriginalName("ErrActionGroupParallelTooMuch")]
		ErrActionGroupParallelTooMuch,
		// Token: 0x0400B215 RID: 45589
		[OriginalName("ErrCanNotRemoveLastTrialRole")]
		ErrCanNotRemoveLastTrialRole,
		// Token: 0x0400B216 RID: 45590
		[OriginalName("ErrEntityIsNotActivateState")]
		ErrEntityIsNotActivateState,
		// Token: 0x0400B217 RID: 45591
		[OriginalName("ErrRestoreTrialRoleNotInRegion")]
		ErrRestoreTrialRoleNotInRegion,
		// Token: 0x0400B218 RID: 45592
		[OriginalName("ErrRemoveTrialRoleNotExist")]
		ErrRemoveTrialRoleNotExist,
		// Token: 0x0400B219 RID: 45593
		[OriginalName("ErrRemoveLastTrialRole")]
		ErrRemoveLastTrialRole,
		// Token: 0x0400B21A RID: 45594
		[OriginalName("ErrSaveNodeDeActiveTrialRoleEmpty")]
		ErrSaveNodeDeActiveTrialRoleEmpty,
		// Token: 0x0400B21B RID: 45595
		[OriginalName("ErrNewHandInItemTypeInvalid")]
		ErrNewHandInItemTypeInvalid,
		// Token: 0x0400B21C RID: 45596
		[OriginalName("ErrIGameObjectHostIsNotIPlayer")]
		ErrIgameObjectHostIsNotIplayer,
		// Token: 0x0400B21D RID: 45597
		[OriginalName("ErrSceneWorldNotExist")]
		ErrSceneWorldNotExist = 700000,
		// Token: 0x0400B21E RID: 45598
		[OriginalName("ErrPlayerNotInScene")]
		ErrPlayerNotInScene,
		// Token: 0x0400B21F RID: 45599
		[OriginalName("ErrDropEntityNotExist")]
		ErrDropEntityNotExist,
		// Token: 0x0400B220 RID: 45600
		[OriginalName("ErrDropComponentNotExist")]
		ErrDropComponentNotExist,
		// Token: 0x0400B221 RID: 45601
		[OriginalName("ErrDropOwnerError")]
		ErrDropOwnerError,
		// Token: 0x0400B222 RID: 45602
		[OriginalName("ErrPlayerAlreadyInScene")]
		ErrPlayerAlreadyInScene,
		// Token: 0x0400B223 RID: 45603
		[OriginalName("ErrSceneIdParseError")]
		ErrSceneIdParseError,
		// Token: 0x0400B224 RID: 45604
		[OriginalName("ErrJoinSceneIdNotExist")]
		ErrJoinSceneIdNotExist,
		// Token: 0x0400B225 RID: 45605
		[OriginalName("ErrSceneInviteFail")]
		ErrSceneInviteFail,
		// Token: 0x0400B226 RID: 45606
		[OriginalName("ErrSceneInvitePlayerNotExist")]
		ErrSceneInvitePlayerNotExist,
		// Token: 0x0400B227 RID: 45607
		[OriginalName("ErrSceneInviteTokenInvalid")]
		ErrSceneInviteTokenInvalid,
		// Token: 0x0400B228 RID: 45608
		[OriginalName("ErrSceneInviterNotExist")]
		ErrSceneInviterNotExist,
		// Token: 0x0400B229 RID: 45609
		[OriginalName("ErrSceneInviteeIdNotMatch")]
		ErrSceneInviteeIdNotMatch,
		// Token: 0x0400B22A RID: 45610
		[OriginalName("ErrSceneTeamIsFull")]
		ErrSceneTeamIsFull,
		// Token: 0x0400B22B RID: 45611
		[OriginalName("ErrScenePlayerIsInTeam")]
		ErrScenePlayerIsInTeam,
		// Token: 0x0400B22C RID: 45612
		[OriginalName("ErrSceneInviteerIsInPlayeInst")]
		ErrSceneInviteerIsInPlayeInst,
		// Token: 0x0400B22D RID: 45613
		[OriginalName("ErrBeKickerNotInScene")]
		ErrBeKickerNotInScene,
		// Token: 0x0400B22E RID: 45614
		[OriginalName("ErrorCanNotSceneKickSelf")]
		ErrorCanNotSceneKickSelf,
		// Token: 0x0400B22F RID: 45615
		[OriginalName("ErrCanNotKickOtherInPlayInst")]
		ErrCanNotKickOtherInPlayInst,
		// Token: 0x0400B230 RID: 45616
		[OriginalName("ErrCanNotKickOtherWhoIsInPlayInst")]
		ErrCanNotKickOtherWhoIsInPlayInst,
		// Token: 0x0400B231 RID: 45617
		[OriginalName("ErrNoSceneKickPermission")]
		ErrNoSceneKickPermission,
		// Token: 0x0400B232 RID: 45618
		[OriginalName("ErrInviterIsInOtherScene")]
		ErrInviterIsInOtherScene,
		// Token: 0x0400B233 RID: 45619
		[OriginalName("ErrInOtherSceneCanNotInvite")]
		ErrInOtherSceneCanNotInvite,
		// Token: 0x0400B234 RID: 45620
		[OriginalName("ErrSceneBackSceneFlagError")]
		ErrSceneBackSceneFlagError,
		// Token: 0x0400B235 RID: 45621
		[OriginalName("ErrLeaveSceneIdNotMatch")]
		ErrLeaveSceneIdNotMatch,
		// Token: 0x0400B236 RID: 45622
		[OriginalName("ErrPrewarTeamAlreadyExist")]
		ErrPrewarTeamAlreadyExist,
		// Token: 0x0400B237 RID: 45623
		[OriginalName("ErrPrewarTeamNotExist")]
		ErrPrewarTeamNotExist,
		// Token: 0x0400B238 RID: 45624
		[OriginalName("ErrCreatePrewarTeamPermissionNotEnough")]
		ErrCreatePrewarTeamPermissionNotEnough,
		// Token: 0x0400B239 RID: 45625
		[OriginalName("ErrPrewarTeamInvitePermissionNotEnough")]
		ErrPrewarTeamInvitePermissionNotEnough,
		// Token: 0x0400B23A RID: 45626
		[OriginalName("ErrPrewarBeInviterNotInScene")]
		ErrPrewarBeInviterNotInScene,
		// Token: 0x0400B23B RID: 45627
		[OriginalName("ErrPrewarBeInviterInInstance")]
		ErrPrewarBeInviterInInstance,
		// Token: 0x0400B23C RID: 45628
		[OriginalName("ErrPlayerAlreadyInPrewarTeam")]
		ErrPlayerAlreadyInPrewarTeam,
		// Token: 0x0400B23D RID: 45629
		[OriginalName("ErrPlayerNotInPrewarTeam")]
		ErrPlayerNotInPrewarTeam,
		// Token: 0x0400B23E RID: 45630
		[OriginalName("ErrPlayerSetPrewarReadyStateRepeat")]
		ErrPlayerSetPrewarReadyStateRepeat,
		// Token: 0x0400B23F RID: 45631
		[OriginalName("ErrPrewarTeamBeKickerNotInScene")]
		ErrPrewarTeamBeKickerNotInScene,
		// Token: 0x0400B240 RID: 45632
		[OriginalName("ErrPrewarTeamKickPermissionNotEnough")]
		ErrPrewarTeamKickPermissionNotEnough,
		// Token: 0x0400B241 RID: 45633
		[OriginalName("ErrPrewarIniviteTooFrequently")]
		ErrPrewarIniviteTooFrequently,
		// Token: 0x0400B242 RID: 45634
		[OriginalName("ErrPrewarJoinInstanceIdNotMatch")]
		ErrPrewarJoinInstanceIdNotMatch,
		// Token: 0x0400B243 RID: 45635
		[OriginalName("ErrPrewarCaptainCanNotLeave")]
		ErrPrewarCaptainCanNotLeave,
		// Token: 0x0400B244 RID: 45636
		[OriginalName("ErrPrewarReadyStateCanNotChangeRole")]
		ErrPrewarReadyStateCanNotChangeRole,
		// Token: 0x0400B245 RID: 45637
		[OriginalName("ErrScenePrewarTeamHavePlayerNotReady")]
		ErrScenePrewarTeamHavePlayerNotReady,
		// Token: 0x0400B246 RID: 45638
		[OriginalName("ErrAlreadyInMultiScene")]
		ErrAlreadyInMultiScene,
		// Token: 0x0400B247 RID: 45639
		[OriginalName("ErrOnlyCaptainCanDissolvePrewarTeam")]
		ErrOnlyCaptainCanDissolvePrewarTeam,
		// Token: 0x0400B248 RID: 45640
		[OriginalName("ErrMultiChangeRoleIndexInvalid")]
		ErrMultiChangeRoleIndexInvalid,
		// Token: 0x0400B249 RID: 45641
		[OriginalName("ErrMultiCanNotChangeOtherRole")]
		ErrMultiCanNotChangeOtherRole,
		// Token: 0x0400B24A RID: 45642
		[OriginalName("ErrMultiChangeRoleEntityNorExist")]
		ErrMultiChangeRoleEntityNorExist,
		// Token: 0x0400B24B RID: 45643
		[OriginalName("ErrSceneCanNotUseThisFunc")]
		ErrSceneCanNotUseThisFunc,
		// Token: 0x0400B24C RID: 45644
		[OriginalName("ErrSceneCanNotUseThisItem")]
		ErrSceneCanNotUseThisItem,
		// Token: 0x0400B24D RID: 45645
		[OriginalName("ErrSceneFightRoleIdRepeat")]
		ErrSceneFightRoleIdRepeat,
		// Token: 0x0400B24E RID: 45646
		[OriginalName("ErrShieldAddEntityNotExist")]
		ErrShieldAddEntityNotExist,
		// Token: 0x0400B24F RID: 45647
		[OriginalName("ErrShieldAddShieldIdExisted")]
		ErrShieldAddShieldIdExisted,
		// Token: 0x0400B250 RID: 45648
		[OriginalName("ErrShieldChangeEntityNotExist")]
		ErrShieldChangeEntityNotExist,
		// Token: 0x0400B251 RID: 45649
		[OriginalName("ErrShieldChangeShieldIdNotExist")]
		ErrShieldChangeShieldIdNotExist,
		// Token: 0x0400B252 RID: 45650
		[OriginalName("ErrShieldRemoveEntityNotExist")]
		ErrShieldRemoveEntityNotExist,
		// Token: 0x0400B253 RID: 45651
		[OriginalName("ErrShieldRemoveShieldIdNotExist")]
		ErrShieldRemoveShieldIdNotExist,
		// Token: 0x0400B254 RID: 45652
		[OriginalName("ErrHardnessModeChangedEntityNotExist")]
		ErrHardnessModeChangedEntityNotExist,
		// Token: 0x0400B255 RID: 45653
		[OriginalName("ErrSceneEntityNotExist")]
		ErrSceneEntityNotExist,
		// Token: 0x0400B256 RID: 45654
		[OriginalName("ErrSceneEntityNotHavePartData")]
		ErrSceneEntityNotHavePartData,
		// Token: 0x0400B257 RID: 45655
		[OriginalName("ErrsceneEntityNotHavePartId")]
		ErrsceneEntityNotHavePartId,
		// Token: 0x0400B258 RID: 45656
		[OriginalName("ErrChangeControlRoleRepeat")]
		ErrChangeControlRoleRepeat,
		// Token: 0x0400B259 RID: 45657
		[OriginalName("ErrVisionSkillCallEntityFail")]
		ErrVisionSkillCallEntityFail,
		// Token: 0x0400B25A RID: 45658
		[OriginalName("ErrSceneDataLoadError")]
		ErrSceneDataLoadError,
		// Token: 0x0400B25B RID: 45659
		[OriginalName("ErrCreatureDataError")]
		ErrCreatureDataError,
		// Token: 0x0400B25C RID: 45660
		[OriginalName("ErrCreatureGenIsExist")]
		ErrCreatureGenIsExist,
		// Token: 0x0400B25D RID: 45661
		[OriginalName("ErrCreatureGenIsNotExist")]
		ErrCreatureGenIsNotExist,
		// Token: 0x0400B25E RID: 45662
		[OriginalName("ErrCreatureGenIsControlByOther")]
		ErrCreatureGenIsControlByOther,
		// Token: 0x0400B25F RID: 45663
		[OriginalName("ErrCreatureGenNotHaveControlPerm")]
		ErrCreatureGenNotHaveControlPerm,
		// Token: 0x0400B260 RID: 45664
		[OriginalName("ErrCreatureReachMaxCount")]
		ErrCreatureReachMaxCount,
		// Token: 0x0400B261 RID: 45665
		[OriginalName("ErrCreatureConditionNotMatch")]
		ErrCreatureConditionNotMatch,
		// Token: 0x0400B262 RID: 45666
		[OriginalName("ErrCreatureTimeIntervalError")]
		ErrCreatureTimeIntervalError,
		// Token: 0x0400B263 RID: 45667
		[OriginalName("ErrCreatureCfgNotExist")]
		ErrCreatureCfgNotExist,
		// Token: 0x0400B264 RID: 45668
		[OriginalName("ErrCreatureEntityIsNotValidity")]
		ErrCreatureEntityIsNotValidity,
		// Token: 0x0400B265 RID: 45669
		[OriginalName("ErrUniqueEntityCanNotCreateTwice")]
		ErrUniqueEntityCanNotCreateTwice,
		// Token: 0x0400B266 RID: 45670
		[OriginalName("ErrRoleNotHaveVisionSkill")]
		ErrRoleNotHaveVisionSkill,
		// Token: 0x0400B267 RID: 45671
		[OriginalName("ErrHitGearEntityNotExist")]
		ErrHitGearEntityNotExist,
		// Token: 0x0400B268 RID: 45672
		[OriginalName("ErrHitGearHaveNotEntityConfig")]
		ErrHitGearHaveNotEntityConfig,
		// Token: 0x0400B269 RID: 45673
		[OriginalName("ErrHitGearHaveNotGearConfig")]
		ErrHitGearHaveNotGearConfig,
		// Token: 0x0400B26A RID: 45674
		[OriginalName("ErrHitGearHaveNotGameplayConfig")]
		ErrHitGearHaveNotGameplayConfig,
		// Token: 0x0400B26B RID: 45675
		[OriginalName("ErrHitGearHaveNotStepConfig")]
		ErrHitGearHaveNotStepConfig,
		// Token: 0x0400B26C RID: 45676
		[OriginalName("ErrHitGearHaveEntityCommonTag")]
		ErrHitGearHaveEntityCommonTag,
		// Token: 0x0400B26D RID: 45677
		[OriginalName("ErrHitGearEntityFunctionTypeFail")]
		ErrHitGearEntityFunctionTypeFail,
		// Token: 0x0400B26E RID: 45678
		[OriginalName("ErrHitGearAcceptStepFail")]
		ErrHitGearAcceptStepFail,
		// Token: 0x0400B26F RID: 45679
		[OriginalName("ErrCreateInstanceNotContainEntrance")]
		ErrCreateInstanceNotContainEntrance,
		// Token: 0x0400B270 RID: 45680
		[OriginalName("ErrCreateInstanceHaveNotEntranceConfig")]
		ErrCreateInstanceHaveNotEntranceConfig,
		// Token: 0x0400B271 RID: 45681
		[OriginalName("ErrCreateInstanceEntranceLock")]
		ErrCreateInstanceEntranceLock,
		// Token: 0x0400B272 RID: 45682
		[OriginalName("ErrCreateInstanceHaveNotConfig")]
		ErrCreateInstanceHaveNotConfig,
		// Token: 0x0400B273 RID: 45683
		[OriginalName("ErrCreateInstanceEnterCountNotEnough")]
		ErrCreateInstanceEnterCountNotEnough,
		// Token: 0x0400B274 RID: 45684
		[OriginalName("ErrCreateInstanceConditionNotMatch")]
		ErrCreateInstanceConditionNotMatch,
		// Token: 0x0400B275 RID: 45685
		[OriginalName("ErrEnterCountRequestHaveNotConfig")]
		ErrEnterCountRequestHaveNotConfig,
		// Token: 0x0400B276 RID: 45686
		[OriginalName("ErrUnlockInstanceEntranceHaveNotConfig")]
		ErrUnlockInstanceEntranceHaveNotConfig,
		// Token: 0x0400B277 RID: 45687
		[OriginalName("ErrUnlockInstanceEntranceNotNeedUnlock")]
		ErrUnlockInstanceEntranceNotNeedUnlock,
		// Token: 0x0400B278 RID: 45688
		[OriginalName("ErrUnlockInstanceEntranceUnlocked")]
		ErrUnlockInstanceEntranceUnlocked,
		// Token: 0x0400B279 RID: 45689
		[OriginalName("ErrUnlockInstanceEntranceCondiitonNotMatch")]
		ErrUnlockInstanceEntranceCondiitonNotMatch,
		// Token: 0x0400B27A RID: 45690
		[OriginalName("ErrEnterSceneGameplayRequestHaveNotConfig")]
		ErrEnterSceneGameplayRequestHaveNotConfig,
		// Token: 0x0400B27B RID: 45691
		[OriginalName("ErrEnterSceneGameplayRequestAccepted")]
		ErrEnterSceneGameplayRequestAccepted,
		// Token: 0x0400B27C RID: 45692
		[OriginalName("ErrEnterSceneGameplayRequestAcceptFail")]
		ErrEnterSceneGameplayRequestAcceptFail,
		// Token: 0x0400B27D RID: 45693
		[OriginalName("ErrStoryCharacterCreatFail")]
		ErrStoryCharacterCreatFail,
		// Token: 0x0400B27E RID: 45694
		[OriginalName("ErrStoryCharacterCreatRepeat")]
		ErrStoryCharacterCreatRepeat,
		// Token: 0x0400B27F RID: 45695
		[OriginalName("ErrStoryCharacterNotExist")]
		ErrStoryCharacterNotExist,
		// Token: 0x0400B280 RID: 45696
		[OriginalName("ErrCheckGearEntityNotExist")]
		ErrCheckGearEntityNotExist,
		// Token: 0x0400B281 RID: 45697
		[OriginalName("ErrCheckGearType")]
		ErrCheckGearType,
		// Token: 0x0400B282 RID: 45698
		[OriginalName("ErrCheckGearNotEntityConfig")]
		ErrCheckGearNotEntityConfig,
		// Token: 0x0400B283 RID: 45699
		[OriginalName("ErrCheckGearActive")]
		ErrCheckGearActive,
		// Token: 0x0400B284 RID: 45700
		[OriginalName("ErrCheckGearInactive")]
		ErrCheckGearInactive,
		// Token: 0x0400B285 RID: 45701
		[OriginalName("ErrTargetGearGroupEntityNotExist")]
		ErrTargetGearGroupEntityNotExist,
		// Token: 0x0400B286 RID: 45702
		[OriginalName("ErrTargetGearGroupConfigNotExist")]
		ErrTargetGearGroupConfigNotExist,
		// Token: 0x0400B287 RID: 45703
		[OriginalName("ErrTargetGearEntityNotExist")]
		ErrTargetGearEntityNotExist,
		// Token: 0x0400B288 RID: 45704
		[OriginalName("ErrTargetGearConfigNotExist")]
		ErrTargetGearConfigNotExist,
		// Token: 0x0400B289 RID: 45705
		[OriginalName("ErrTargetGearStartTypeIsNotHit")]
		ErrTargetGearStartTypeIsNotHit,
		// Token: 0x0400B28A RID: 45706
		[OriginalName("ErrTargetGearStartTypeIsNotAction")]
		ErrTargetGearStartTypeIsNotAction,
		// Token: 0x0400B28B RID: 45707
		[OriginalName("ErrTargetGearStarted")]
		ErrTargetGearStarted,
		// Token: 0x0400B28C RID: 45708
		[OriginalName("ErrTargetGearFinished")]
		ErrTargetGearFinished,
		// Token: 0x0400B28D RID: 45709
		[OriginalName("ErrTargetGearIsNotInCreatedConsole")]
		ErrTargetGearIsNotInCreatedConsole,
		// Token: 0x0400B28E RID: 45710
		[OriginalName("ErrTargetGearGroupEntityIsNotAllInit")]
		ErrTargetGearGroupEntityIsNotAllInit,
		// Token: 0x0400B28F RID: 45711
		[OriginalName("ErrLanternCatNotExit")]
		ErrLanternCatNotExit,
		// Token: 0x0400B290 RID: 45712
		[OriginalName("ErrLanternCatConfNotExit")]
		ErrLanternCatConfNotExit,
		// Token: 0x0400B291 RID: 45713
		[OriginalName("ErrLanternCatType")]
		ErrLanternCatType,
		// Token: 0x0400B292 RID: 45714
		[OriginalName("ErrLanternActived")]
		ErrLanternActived,
		// Token: 0x0400B293 RID: 45715
		[OriginalName("ErrLanternTargetNotExit")]
		ErrLanternTargetNotExit,
		// Token: 0x0400B294 RID: 45716
		[OriginalName("ErrCaptureFail")]
		ErrCaptureFail,
		// Token: 0x0400B295 RID: 45717
		[OriginalName("ErrDyingFail")]
		ErrDyingFail,
		// Token: 0x0400B296 RID: 45718
		[OriginalName("ErrThrowDamageEntityNotExit")]
		ErrThrowDamageEntityNotExit,
		// Token: 0x0400B297 RID: 45719
		[OriginalName("ErrThrowDamageCalculateId")]
		ErrThrowDamageCalculateId,
		// Token: 0x0400B298 RID: 45720
		[OriginalName("ErrThrowDamageIdNotExit")]
		ErrThrowDamageIdNotExit,
		// Token: 0x0400B299 RID: 45721
		[OriginalName("ErrThrowDamageRoleIdConf")]
		ErrThrowDamageRoleIdConf,
		// Token: 0x0400B29A RID: 45722
		[OriginalName("ErrThrowDamageTypeNotExit")]
		ErrThrowDamageTypeNotExit,
		// Token: 0x0400B29B RID: 45723
		[OriginalName("InstIdNotExist")]
		InstIdNotExist,
		// Token: 0x0400B29C RID: 45724
		[OriginalName("ErrControlObjectEntityNotExist")]
		ErrControlObjectEntityNotExist,
		// Token: 0x0400B29D RID: 45725
		[OriginalName("ErrControlObjectConfigNotExist")]
		ErrControlObjectConfigNotExist,
		// Token: 0x0400B29E RID: 45726
		[OriginalName("ErrControlGroupConfigNotExist")]
		ErrControlGroupConfigNotExist,
		// Token: 0x0400B29F RID: 45727
		[OriginalName("ErrControlObjectLocked")]
		ErrControlObjectLocked,
		// Token: 0x0400B2A0 RID: 45728
		[OriginalName("ErrControlGroupLocked")]
		ErrControlGroupLocked,
		// Token: 0x0400B2A1 RID: 45729
		[OriginalName("ErrControlCanNotPutTarget")]
		ErrControlCanNotPutTarget,
		// Token: 0x0400B2A2 RID: 45730
		[OriginalName("ErrControlTargetOccupied")]
		ErrControlTargetOccupied,
		// Token: 0x0400B2A3 RID: 45731
		[OriginalName("ErrControlObjectCatching")]
		ErrControlObjectCatching,
		// Token: 0x0400B2A4 RID: 45732
		[OriginalName("ErrControlObjectNotCatching")]
		ErrControlObjectNotCatching,
		// Token: 0x0400B2A5 RID: 45733
		[OriginalName("ErrControlObjectOtherCatching")]
		ErrControlObjectOtherCatching,
		// Token: 0x0400B2A6 RID: 45734
		[OriginalName("ErrEntityPositionIllegal")]
		ErrEntityPositionIllegal,
		// Token: 0x0400B2A7 RID: 45735
		[OriginalName("ErrTreasureBoxNot")]
		ErrTreasureBoxNot,
		// Token: 0x0400B2A8 RID: 45736
		[OriginalName("ErrTreasureBoxNotInit")]
		ErrTreasureBoxNotInit,
		// Token: 0x0400B2A9 RID: 45737
		[OriginalName("ErrTreasureBoxNotConfig")]
		ErrTreasureBoxNotConfig,
		// Token: 0x0400B2AA RID: 45738
		[OriginalName("ErrTreasureBoxHadReward")]
		ErrTreasureBoxHadReward,
		// Token: 0x0400B2AB RID: 45739
		[OriginalName("ErrTreasureBoxNotInteraction")]
		ErrTreasureBoxNotInteraction,
		// Token: 0x0400B2AC RID: 45740
		[OriginalName("ErrTreasureBoxNotDropId")]
		ErrTreasureBoxNotDropId,
		// Token: 0x0400B2AD RID: 45741
		[OriginalName("ErrTreasureBoxDropErr")]
		ErrTreasureBoxDropErr,
		// Token: 0x0400B2AE RID: 45742
		[OriginalName("ErrTreasureBoxNotExist")]
		ErrTreasureBoxNotExist,
		// Token: 0x0400B2AF RID: 45743
		[OriginalName("ErrTreasureBoxInvalidTag")]
		ErrTreasureBoxInvalidTag,
		// Token: 0x0400B2B0 RID: 45744
		[OriginalName("ErrTreasureBoxHadTag")]
		ErrTreasureBoxHadTag,
		// Token: 0x0400B2B1 RID: 45745
		[OriginalName("ErrTreasureBoxNotTag")]
		ErrTreasureBoxNotTag,
		// Token: 0x0400B2B2 RID: 45746
		[OriginalName("ErrSneakGameNotOpen")]
		ErrSneakGameNotOpen,
		// Token: 0x0400B2B3 RID: 45747
		[OriginalName("ErrSneakFinishRepeat")]
		ErrSneakFinishRepeat,
		// Token: 0x0400B2B4 RID: 45748
		[OriginalName("ErrClientControlDamage")]
		ErrClientControlDamage,
		// Token: 0x0400B2B5 RID: 45749
		[OriginalName("ErrSceneDataSaveFail")]
		ErrSceneDataSaveFail,
		// Token: 0x0400B2B6 RID: 45750
		[OriginalName("NotInFbInstance")]
		NotInFbInstance,
		// Token: 0x0400B2B7 RID: 45751
		[OriginalName("GMErrCanNotCreateWorldInst")]
		GmerrCanNotCreateWorldInst,
		// Token: 0x0400B2B8 RID: 45752
		[OriginalName("GMErrPlayerAlreadyInFbInst")]
		GmerrPlayerAlreadyInFbInst,
		// Token: 0x0400B2B9 RID: 45753
		[OriginalName("GMErrTagetInstanceIsNotMulti")]
		GmerrTagetInstanceIsNotMulti,
		// Token: 0x0400B2BA RID: 45754
		[OriginalName("GMErrPlayerNotFound")]
		GmerrPlayerNotFound,
		// Token: 0x0400B2BB RID: 45755
		[OriginalName("ErrEntityFlowTooMuch")]
		ErrEntityFlowTooMuch,
		// Token: 0x0400B2BC RID: 45756
		[OriginalName("GmErrIsWalkable")]
		GmErrIsWalkable,
		// Token: 0x0400B2BD RID: 45757
		[OriginalName("GmErrIsNotWalkable")]
		GmErrIsNotWalkable,
		// Token: 0x0400B2BE RID: 45758
		[OriginalName("GmErrNoNavmesh")]
		GmErrNoNavmesh,
		// Token: 0x0400B2BF RID: 45759
		[OriginalName("ErrBigWorldInstIdNotExist")]
		ErrBigWorldInstIdNotExist,
		// Token: 0x0400B2C0 RID: 45760
		[OriginalName("ErrInstIdNotBigWorld")]
		ErrInstIdNotBigWorld,
		// Token: 0x0400B2C1 RID: 45761
		[OriginalName("ErrInInstanceNotSwitchBigWorld")]
		ErrInInstanceNotSwitchBigWorld,
		// Token: 0x0400B2C2 RID: 45762
		[OriginalName("ErrAlreadyInThisBigWorld")]
		ErrAlreadyInThisBigWorld,
		// Token: 0x0400B2C3 RID: 45763
		[OriginalName("ErrNoPermissionGetTreasureBox")]
		ErrNoPermissionGetTreasureBox,
		// Token: 0x0400B2C4 RID: 45764
		[OriginalName("ErrCreateBigWorldRepeat")]
		ErrCreateBigWorldRepeat,
		// Token: 0x0400B2C5 RID: 45765
		[OriginalName("DebugErrInstIdNotExist")]
		DebugErrInstIdNotExist,
		// Token: 0x0400B2C6 RID: 45766
		[OriginalName("ErrSceneAiStopped")]
		ErrSceneAiStopped,
		// Token: 0x0400B2C7 RID: 45767
		[OriginalName("ErrGlobalEntityConfigNotExist")]
		ErrGlobalEntityConfigNotExist,
		// Token: 0x0400B2C8 RID: 45768
		[OriginalName("ErrSceneFixedConfigNotExist")]
		ErrSceneFixedConfigNotExist,
		// Token: 0x0400B2C9 RID: 45769
		[OriginalName("ErrSceneFixedEntityNotFound")]
		ErrSceneFixedEntityNotFound,
		// Token: 0x0400B2CA RID: 45770
		[OriginalName("ErrSceneGlobalEntityNotFount")]
		ErrSceneGlobalEntityNotFount,
		// Token: 0x0400B2CB RID: 45771
		[OriginalName("ErrEntityNotHaveVarComponent")]
		ErrEntityNotHaveVarComponent,
		// Token: 0x0400B2CC RID: 45772
		[OriginalName("ErrEntityVarNameNotExist")]
		ErrEntityVarNameNotExist,
		// Token: 0x0400B2CD RID: 45773
		[OriginalName("ErrEntityVarTypeError")]
		ErrEntityVarTypeError,
		// Token: 0x0400B2CE RID: 45774
		[OriginalName("ErrEntityConfigNotOffer")]
		ErrEntityConfigNotOffer,
		// Token: 0x0400B2CF RID: 45775
		[OriginalName("ErrConfigTypeNotGloabl")]
		ErrConfigTypeNotGloabl,
		// Token: 0x0400B2D0 RID: 45776
		[OriginalName("ErrConfigTypeNotSceneFixed")]
		ErrConfigTypeNotSceneFixed,
		// Token: 0x0400B2D1 RID: 45777
		[OriginalName("ErrConfigTypeNotCharacter")]
		ErrConfigTypeNotCharacter,
		// Token: 0x0400B2D2 RID: 45778
		[OriginalName("ErrEntityPosNotOffer")]
		ErrEntityPosNotOffer,
		// Token: 0x0400B2D3 RID: 45779
		[OriginalName("ErrSceneCellPosNotFount")]
		ErrSceneCellPosNotFount,
		// Token: 0x0400B2D4 RID: 45780
		[OriginalName("ErrEntityCongigNotInSleep")]
		ErrEntityCongigNotInSleep,
		// Token: 0x0400B2D5 RID: 45781
		[OriginalName("ErrSummonCfgNotFound")]
		ErrSummonCfgNotFound,
		// Token: 0x0400B2D6 RID: 45782
		[OriginalName("ErrSummonAddEntityFail")]
		ErrSummonAddEntityFail,
		// Token: 0x0400B2D7 RID: 45783
		[OriginalName("ErrSummonMaxCount")]
		ErrSummonMaxCount,
		// Token: 0x0400B2D8 RID: 45784
		[OriginalName("ErrSummonMaxGenerations")]
		ErrSummonMaxGenerations,
		// Token: 0x0400B2D9 RID: 45785
		[OriginalName("ErrSummonEntityIdAlreadyExist")]
		ErrSummonEntityIdAlreadyExist,
		// Token: 0x0400B2DA RID: 45786
		[OriginalName("ErrSummonerEntityType")]
		ErrSummonerEntityType,
		// Token: 0x0400B2DB RID: 45787
		[OriginalName("ErrEntityStatusIsNotDead")]
		ErrEntityStatusIsNotDead,
		// Token: 0x0400B2DC RID: 45788
		[OriginalName("ErrEntityNotHaveAttributeComp")]
		ErrEntityNotHaveAttributeComp,
		// Token: 0x0400B2DD RID: 45789
		[OriginalName("ErrEntityDbData")]
		ErrEntityDbData,
		// Token: 0x0400B2DE RID: 45790
		[OriginalName("ErrSceneFixedEntityCreated")]
		ErrSceneFixedEntityCreated,
		// Token: 0x0400B2DF RID: 45791
		[OriginalName("ErrInvalidAwakeEntityContext")]
		ErrInvalidAwakeEntityContext,
		// Token: 0x0400B2E0 RID: 45792
		[OriginalName("ErrTriggerComponentNotExist")]
		ErrTriggerComponentNotExist,
		// Token: 0x0400B2E1 RID: 45793
		[OriginalName("ErrTriggerComponentMaxCount")]
		ErrTriggerComponentMaxCount,
		// Token: 0x0400B2E2 RID: 45794
		[OriginalName("ErrNotSelfRole")]
		ErrNotSelfRole,
		// Token: 0x0400B2E3 RID: 45795
		[OriginalName("ErrNoControlRights")]
		ErrNoControlRights,
		// Token: 0x0400B2E4 RID: 45796
		[OriginalName("ErrEntityHaveNotEntityOwner")]
		ErrEntityHaveNotEntityOwner,
		// Token: 0x0400B2E5 RID: 45797
		[OriginalName("ErrEntityOwnerNotMatch")]
		ErrEntityOwnerNotMatch,
		// Token: 0x0400B2E6 RID: 45798
		[OriginalName("ErrCreateSceneFixedEntitiesEmpty")]
		ErrCreateSceneFixedEntitiesEmpty,
		// Token: 0x0400B2E7 RID: 45799
		[OriginalName("ErrInteractComponentNotExist")]
		ErrInteractComponentNotExist,
		// Token: 0x0400B2E8 RID: 45800
		[OriginalName("ErrInteractOptionIndexInvalid")]
		ErrInteractOptionIndexInvalid,
		// Token: 0x0400B2E9 RID: 45801
		[OriginalName("ErrOnlineInteractNoPermission")]
		ErrOnlineInteractNoPermission,
		// Token: 0x0400B2EA RID: 45802
		[OriginalName("ErrOnlineInteractNotOpen")]
		ErrOnlineInteractNotOpen,
		// Token: 0x0400B2EB RID: 45803
		[OriginalName("ErrAwakeEntityNoPermission")]
		ErrAwakeEntityNoPermission,
		// Token: 0x0400B2EC RID: 45804
		[OriginalName("ErrCannotUseSkillStatus")]
		ErrCannotUseSkillStatus,
		// Token: 0x0400B2ED RID: 45805
		[OriginalName("ErrInteractOptionGuidInvalid")]
		ErrInteractOptionGuidInvalid,
		// Token: 0x0400B2EE RID: 45806
		[OriginalName("ErrAddInteractOptionFail")]
		ErrAddInteractOptionFail,
		// Token: 0x0400B2EF RID: 45807
		[OriginalName("ErrRemoveInteractOptionFail")]
		ErrRemoveInteractOptionFail,
		// Token: 0x0400B2F0 RID: 45808
		[OriginalName("ErrInteractOptionOwnerNotFound")]
		ErrInteractOptionOwnerNotFound,
		// Token: 0x0400B2F1 RID: 45809
		[OriginalName("ErrSummonPlayerId")]
		ErrSummonPlayerId,
		// Token: 0x0400B2F2 RID: 45810
		[OriginalName("ErrSummonTemplateCfgNotFound")]
		ErrSummonTemplateCfgNotFound,
		// Token: 0x0400B2F3 RID: 45811
		[OriginalName("ErrAttributeComponent")]
		ErrAttributeComponent,
		// Token: 0x0400B2F4 RID: 45812
		[OriginalName("ErrAnimFsmComponent")]
		ErrAnimFsmComponent,
		// Token: 0x0400B2F5 RID: 45813
		[OriginalName("ErrStateComponent")]
		ErrStateComponent,
		// Token: 0x0400B2F6 RID: 45814
		[OriginalName("ErrBattleComponent")]
		ErrBattleComponent,
		// Token: 0x0400B2F7 RID: 45815
		[OriginalName("ErrPartComponent")]
		ErrPartComponent,
		// Token: 0x0400B2F8 RID: 45816
		[OriginalName("ErrAiControlComponent")]
		ErrAiControlComponent,
		// Token: 0x0400B2F9 RID: 45817
		[OriginalName("ErrSummonsComponent")]
		ErrSummonsComponent,
		// Token: 0x0400B2FA RID: 45818
		[OriginalName("ErrAiBlackboardComponent")]
		ErrAiBlackboardComponent,
		// Token: 0x0400B2FB RID: 45819
		[OriginalName("ErrSetVarInvalidContext")]
		ErrSetVarInvalidContext,
		// Token: 0x0400B2FC RID: 45820
		[OriginalName("ErrSetVarInvalidVarRefPb")]
		ErrSetVarInvalidVarRefPb,
		// Token: 0x0400B2FD RID: 45821
		[OriginalName("ErrSetVarGetRightVarDefineFail")]
		ErrSetVarGetRightVarDefineFail,
		// Token: 0x0400B2FE RID: 45822
		[OriginalName("ErrSetVarSetLeftVarDefineFail")]
		ErrSetVarSetLeftVarDefineFail,
		// Token: 0x0400B2FF RID: 45823
		[OriginalName("ErrCalcVarInvalidContext")]
		ErrCalcVarInvalidContext,
		// Token: 0x0400B300 RID: 45824
		[OriginalName("ErrCalcVarInvalidVarRef")]
		ErrCalcVarInvalidVarRef,
		// Token: 0x0400B301 RID: 45825
		[OriginalName("ErrCalcVarGetVarDefineFail")]
		ErrCalcVarGetVarDefineFail,
		// Token: 0x0400B302 RID: 45826
		[OriginalName("ErrCalcVarInvalidVarType")]
		ErrCalcVarInvalidVarType,
		// Token: 0x0400B303 RID: 45827
		[OriginalName("ErrCalcVarInvalidOp")]
		ErrCalcVarInvalidOp,
		// Token: 0x0400B304 RID: 45828
		[OriginalName("ErrCalcVarSetResultFail")]
		ErrCalcVarSetResultFail,
		// Token: 0x0400B305 RID: 45829
		[OriginalName("ErrActionEntityNoExist")]
		ErrActionEntityNoExist,
		// Token: 0x0400B306 RID: 45830
		[OriginalName("ErrActionNoInteractConfig")]
		ErrActionNoInteractConfig,
		// Token: 0x0400B307 RID: 45831
		[OriginalName("ErrActionIdNoExist")]
		ErrActionIdNoExist,
		// Token: 0x0400B308 RID: 45832
		[OriginalName("ErrActionBtObjNoExist")]
		ErrActionBtObjNoExist,
		// Token: 0x0400B309 RID: 45833
		[OriginalName("ErrActionNodeNoExist")]
		ErrActionNodeNoExist,
		// Token: 0x0400B30A RID: 45834
		[OriginalName("ErrActionNoChildQuest")]
		ErrActionNoChildQuest,
		// Token: 0x0400B30B RID: 45835
		[OriginalName("ErrActionParams")]
		ErrActionParams,
		// Token: 0x0400B30C RID: 45836
		[OriginalName("ErrActionNotEntityContext")]
		ErrActionNotEntityContext,
		// Token: 0x0400B30D RID: 45837
		[OriginalName("ErrActionExecutorNotFind")]
		ErrActionExecutorNotFind,
		// Token: 0x0400B30E RID: 45838
		[OriginalName("ErrActionSessionNotFind")]
		ErrActionSessionNotFind,
		// Token: 0x0400B30F RID: 45839
		[OriginalName("ErrActionCreateSessionIdFail")]
		ErrActionCreateSessionIdFail,
		// Token: 0x0400B310 RID: 45840
		[OriginalName("ErrActionPathConvertFail")]
		ErrActionPathConvertFail,
		// Token: 0x0400B311 RID: 45841
		[OriginalName("ErrActionConfigNotFind")]
		ErrActionConfigNotFind,
		// Token: 0x0400B312 RID: 45842
		[OriginalName("ErrActionHaveNotHandler")]
		ErrActionHaveNotHandler,
		// Token: 0x0400B313 RID: 45843
		[OriginalName("ErrActionInternalError")]
		ErrActionInternalError,
		// Token: 0x0400B314 RID: 45844
		[OriginalName("ErrActionInvalidIndex")]
		ErrActionInvalidIndex,
		// Token: 0x0400B315 RID: 45845
		[OriginalName("ErrActionIsNotServer")]
		ErrActionIsNotServer,
		// Token: 0x0400B316 RID: 45846
		[OriginalName("ErrActionRemainActionNotFinish")]
		ErrActionRemainActionNotFinish,
		// Token: 0x0400B317 RID: 45847
		[OriginalName("ErrActionExecutorIsNotBlackbard")]
		ErrActionExecutorIsNotBlackbard,
		// Token: 0x0400B318 RID: 45848
		[OriginalName("ErrContinuityActionNotFinish")]
		ErrContinuityActionNotFinish,
		// Token: 0x0400B319 RID: 45849
		[OriginalName("ErrActionIsNotContinuity")]
		ErrActionIsNotContinuity,
		// Token: 0x0400B31A RID: 45850
		[OriginalName("ErrResetLocationEntityNotExist")]
		ErrResetLocationEntityNotExist,
		// Token: 0x0400B31B RID: 45851
		[OriginalName("ErrEntityPosAbnormalNotExists")]
		ErrEntityPosAbnormalNotExists,
		// Token: 0x0400B31C RID: 45852
		[OriginalName("ErrGmRemoveEntityNotExists")]
		ErrGmRemoveEntityNotExists,
		// Token: 0x0400B31D RID: 45853
		[OriginalName("ErrDrownEntityNotExists")]
		ErrDrownEntityNotExists,
		// Token: 0x0400B31E RID: 45854
		[OriginalName("ErrTargetGearNotExists")]
		ErrTargetGearNotExists,
		// Token: 0x0400B31F RID: 45855
		[OriginalName("ErrOutofBattleEntityNotExists")]
		ErrOutofBattleEntityNotExists,
		// Token: 0x0400B320 RID: 45856
		[OriginalName("ErrOrderAddBuffEntityNotExists")]
		ErrOrderAddBuffEntityNotExists,
		// Token: 0x0400B321 RID: 45857
		[OriginalName("ErrOrderRemoveBuffEntityNotExists")]
		ErrOrderRemoveBuffEntityNotExists,
		// Token: 0x0400B322 RID: 45858
		[OriginalName("ErrActivateBuffEntityNotExists")]
		ErrActivateBuffEntityNotExists,
		// Token: 0x0400B323 RID: 45859
		[OriginalName("ErrToughCalcExtraRatioChangeEntityNotExists")]
		ErrToughCalcExtraRatioChangeEntityNotExists,
		// Token: 0x0400B324 RID: 45860
		[OriginalName("ErrAdsorbEntityNotExist")]
		ErrAdsorbEntityNotExist,
		// Token: 0x0400B325 RID: 45861
		[OriginalName("ErrAdsorbCondNotMeet")]
		ErrAdsorbCondNotMeet,
		// Token: 0x0400B326 RID: 45862
		[OriginalName("ErrTimelineTrackMultiGameForbid")]
		ErrTimelineTrackMultiGameForbid,
		// Token: 0x0400B327 RID: 45863
		[OriginalName("ErrTimelineTraceEntityNotExists")]
		ErrTimelineTraceEntityNotExists,
		// Token: 0x0400B328 RID: 45864
		[OriginalName("ErrTimelineTraceComponentNotExists")]
		ErrTimelineTraceComponentNotExists,
		// Token: 0x0400B329 RID: 45865
		[OriginalName("ErrTimelineTraceGroupIndex")]
		ErrTimelineTraceGroupIndex,
		// Token: 0x0400B32A RID: 45866
		[OriginalName("ErrTimelineTraceFinish")]
		ErrTimelineTraceFinish,
		// Token: 0x0400B32B RID: 45867
		[OriginalName("ErrTimelineTraceCondition")]
		ErrTimelineTraceCondition,
		// Token: 0x0400B32C RID: 45868
		[OriginalName("ErrTimelineTraceTargetEmpty")]
		ErrTimelineTraceTargetEmpty,
		// Token: 0x0400B32D RID: 45869
		[OriginalName("ErrTimelineTraceControl")]
		ErrTimelineTraceControl,
		// Token: 0x0400B32E RID: 45870
		[OriginalName("ErrTimelineTraceFinishCondition")]
		ErrTimelineTraceFinishCondition,
		// Token: 0x0400B32F RID: 45871
		[OriginalName("ErrTimelineTraceNotInControl")]
		ErrTimelineTraceNotInControl,
		// Token: 0x0400B330 RID: 45872
		[OriginalName("ErrForbidEnterInstance")]
		ErrForbidEnterInstance,
		// Token: 0x0400B331 RID: 45873
		[OriginalName("ErrForbitEnterBigWorld")]
		ErrForbitEnterBigWorld,
		// Token: 0x0400B332 RID: 45874
		[OriginalName("ErrPrefabIncIdExist")]
		ErrPrefabIncIdExist,
		// Token: 0x0400B333 RID: 45875
		[OriginalName("ErrPrefabIdExist")]
		ErrPrefabIdExist,
		// Token: 0x0400B334 RID: 45876
		[OriginalName("ErrPrefabNumberIsZero")]
		ErrPrefabNumberIsZero,
		// Token: 0x0400B335 RID: 45877
		[OriginalName("ErrPrefabEntityIsExist")]
		ErrPrefabEntityIsExist,
		// Token: 0x0400B336 RID: 45878
		[OriginalName("ErrPrefabTreasureBox")]
		ErrPrefabTreasureBox,
		// Token: 0x0400B337 RID: 45879
		[OriginalName("ErrPrefabActionCreate")]
		ErrPrefabActionCreate,
		// Token: 0x0400B338 RID: 45880
		[OriginalName("ErrPrefabVarNoExist")]
		ErrPrefabVarNoExist,
		// Token: 0x0400B339 RID: 45881
		[OriginalName("ErrClientOnlyEntityCantCreate")]
		ErrClientOnlyEntityCantCreate,
		// Token: 0x0400B33A RID: 45882
		[OriginalName("ErrTimelineTraceActionRun")]
		ErrTimelineTraceActionRun,
		// Token: 0x0400B33B RID: 45883
		[OriginalName("ErrGmActivateTeleportSceneNotExist")]
		ErrGmActivateTeleportSceneNotExist,
		// Token: 0x0400B33C RID: 45884
		[OriginalName("ErrGmCreateInstSceneHasExist")]
		ErrGmCreateInstSceneHasExist,
		// Token: 0x0400B33D RID: 45885
		[OriginalName("ErrVfxNpcNotExist")]
		ErrVfxNpcNotExist,
		// Token: 0x0400B33E RID: 45886
		[OriginalName("ErrVfxNpcIsNotVfxNpc")]
		ErrVfxNpcIsNotVfxNpc,
		// Token: 0x0400B33F RID: 45887
		[OriginalName("ErrBlackboardLimit")]
		ErrBlackboardLimit,
		// Token: 0x0400B340 RID: 45888
		[OriginalName("ErrBlackboardArrayLimit")]
		ErrBlackboardArrayLimit,
		// Token: 0x0400B341 RID: 45889
		[OriginalName("ErrBlackboardStringLimit")]
		ErrBlackboardStringLimit,
		// Token: 0x0400B342 RID: 45890
		[OriginalName("ErrReconnectGWGetGatePlayerFailed")]
		ErrReconnectGwgetGatePlayerFailed = 800000,
		// Token: 0x0400B343 RID: 45891
		[OriginalName("ErrGWReconnectGWInvalidPlayerState")]
		ErrGwreconnectGwinvalidPlayerState,
		// Token: 0x0400B344 RID: 45892
		[OriginalName("ErrGWReconnectGWVerifyTokenFailed")]
		ErrGwreconnectGwverifyTokenFailed,
		// Token: 0x0400B345 RID: 45893
		[OriginalName("ErrGWReconnectGWBackOnlineAsyncFailed")]
		ErrGwreconnectGwbackOnlineAsyncFailed,
		// Token: 0x0400B346 RID: 45894
		[OriginalName("ErrGWReconnectGWBackOnlineAsyncException")]
		ErrGwreconnectGwbackOnlineAsyncException,
		// Token: 0x0400B347 RID: 45895
		[OriginalName("ErrReconnectGwclientLatestSeqNoNotHit")]
		ErrReconnectGwclientLatestSeqNoNotHit,
		// Token: 0x0400B348 RID: 45896
		[OriginalName("ErrGWReconnectConfirmGetPlayerFailed")]
		ErrGwreconnectConfirmGetPlayerFailed,
		// Token: 0x0400B349 RID: 45897
		[OriginalName("ErrAttrChangeHandleInvalidClientAction")]
		ErrAttrChangeHandleInvalidClientAction,
		// Token: 0x0400B34A RID: 45898
		[OriginalName("ErrThrowDamageReqGetStateComponentFailed")]
		ErrThrowDamageReqGetStateComponentFailed,
		// Token: 0x0400B34B RID: 45899
		[OriginalName("ErrThrowDamageReqEntityIsAlreadyDead")]
		ErrThrowDamageReqEntityIsAlreadyDead,
		// Token: 0x0400B34C RID: 45900
		[OriginalName("ErrAnimalDieRequestForceSetDieError")]
		ErrAnimalDieRequestForceSetDieError,
		// Token: 0x0400B34D RID: 45901
		[OriginalName("ErrCollectEntityForceSetEntityDieError")]
		ErrCollectEntityForceSetEntityDieError,
		// Token: 0x0400B34E RID: 45902
		[OriginalName("ErrMonsterBoomForceSetDieError")]
		ErrMonsterBoomForceSetDieError,
		// Token: 0x0400B34F RID: 45903
		[OriginalName("ErrAttrChangeReqReplaceAttrListFailed")]
		ErrAttrChangeReqReplaceAttrListFailed,
		// Token: 0x0400B350 RID: 45904
		[OriginalName("ErrReconnectInvalidOperation")]
		ErrReconnectInvalidOperation,
		// Token: 0x0400B351 RID: 45905
		[OriginalName("ErrReconnectGwNodeTainted")]
		ErrReconnectGwNodeTainted,
		// Token: 0x0400B352 RID: 45906
		[OriginalName("ErrFavorRoleNotFound")]
		ErrFavorRoleNotFound = 900000,
		// Token: 0x0400B353 RID: 45907
		[OriginalName("ErrFavorConfNotFound")]
		ErrFavorConfNotFound,
		// Token: 0x0400B354 RID: 45908
		[OriginalName("ErrFavorQuestNotFound")]
		ErrFavorQuestNotFound,
		// Token: 0x0400B355 RID: 45909
		[OriginalName("ErrFavorLevelRewardLimit")]
		ErrFavorLevelRewardLimit,
		// Token: 0x0400B356 RID: 45910
		[OriginalName("ErrFavorQuestAcceptLimit")]
		ErrFavorQuestAcceptLimit,
		// Token: 0x0400B357 RID: 45911
		[OriginalName("ErrFavorItemLocked")]
		ErrFavorItemLocked,
		// Token: 0x0400B358 RID: 45912
		[OriginalName("ErrFavorItemHasUnLocked")]
		ErrFavorItemHasUnLocked,
		// Token: 0x0400B359 RID: 45913
		[OriginalName("ErrElevatorEntityNotExit")]
		ErrElevatorEntityNotExit,
		// Token: 0x0400B35A RID: 45914
		[OriginalName("ErrElevatorConfigNotExit")]
		ErrElevatorConfigNotExit,
		// Token: 0x0400B35B RID: 45915
		[OriginalName("ErrElevatorLocked")]
		ErrElevatorLocked,
		// Token: 0x0400B35C RID: 45916
		[OriginalName("ErrElevatorIsNotReverse")]
		ErrElevatorIsNotReverse,
		// Token: 0x0400B35D RID: 45917
		[OriginalName("ErrElevatorIsNotForward")]
		ErrElevatorIsNotForward,
		// Token: 0x0400B35E RID: 45918
		[OriginalName("ErrElevatorIsNotStart")]
		ErrElevatorIsNotStart,
		// Token: 0x0400B35F RID: 45919
		[OriginalName("ErrElevatorIsNotEnd")]
		ErrElevatorIsNotEnd,
		// Token: 0x0400B360 RID: 45920
		[OriginalName("ErrElevatorFloorError")]
		ErrElevatorFloorError,
		// Token: 0x0400B361 RID: 45921
		[OriginalName("ErrHostRefuse")]
		ErrHostRefuse,
		// Token: 0x0400B362 RID: 45922
		[OriginalName("ErrHostOffline")]
		ErrHostOffline,
		// Token: 0x0400B363 RID: 45923
		[OriginalName("ErrHostHasOnline")]
		ErrHostHasOnline,
		// Token: 0x0400B364 RID: 45924
		[OriginalName("ErrHostPlayerMax")]
		ErrHostPlayerMax,
		// Token: 0x0400B365 RID: 45925
		[OriginalName("ErrHostRefuseStrangers")]
		ErrHostRefuseStrangers,
		// Token: 0x0400B366 RID: 45926
		[OriginalName("ErrHostForbidJoin")]
		ErrHostForbidJoin,
		// Token: 0x0400B367 RID: 45927
		[OriginalName("ErrHostTemporarilyForbidJoin")]
		ErrHostTemporarilyForbidJoin,
		// Token: 0x0400B368 RID: 45928
		[OriginalName("ErrSlaveInBlockList")]
		ErrSlaveInBlockList,
		// Token: 0x0400B369 RID: 45929
		[OriginalName("ErrExceedJoinLevelDiff")]
		ErrExceedJoinLevelDiff,
		// Token: 0x0400B36A RID: 45930
		[OriginalName("ErrHostNotOpenOnlineFunc")]
		ErrHostNotOpenOnlineFunc,
		// Token: 0x0400B36B RID: 45931
		[OriginalName("ErrHostInOtherPlayer")]
		ErrHostInOtherPlayer,
		// Token: 0x0400B36C RID: 45932
		[OriginalName("ErrHostInForbidOnlineQuest")]
		ErrHostInForbidOnlineQuest,
		// Token: 0x0400B36D RID: 45933
		[OriginalName("ErrSlaveHasOnline")]
		ErrSlaveHasOnline,
		// Token: 0x0400B36E RID: 45934
		[OriginalName("ErrSlaveInForbidOnlineQuest")]
		ErrSlaveInForbidOnlineQuest,
		// Token: 0x0400B36F RID: 45935
		[OriginalName("ErrSlaveNotOpenOnlineFunc")]
		ErrSlaveNotOpenOnlineFunc,
		// Token: 0x0400B370 RID: 45936
		[OriginalName("ErrSlaveApplyRepeated")]
		ErrSlaveApplyRepeated,
		// Token: 0x0400B371 RID: 45937
		[OriginalName("ErrSlaveTryApplySelf")]
		ErrSlaveTryApplySelf,
		// Token: 0x0400B372 RID: 45938
		[OriginalName("ErrLobbyTryQuerySelf")]
		ErrLobbyTryQuerySelf,
		// Token: 0x0400B373 RID: 45939
		[OriginalName("ErrSlaveRequestExpired")]
		ErrSlaveRequestExpired,
		// Token: 0x0400B374 RID: 45940
		[OriginalName("ErrEnterringOtherScene")]
		ErrEnterringOtherScene,
		// Token: 0x0400B375 RID: 45941
		[OriginalName("ErrWaitingOtherJoin")]
		ErrWaitingOtherJoin,
		// Token: 0x0400B376 RID: 45942
		[OriginalName("ErrWaitListFull")]
		ErrWaitListFull,
		// Token: 0x0400B377 RID: 45943
		[OriginalName("ErrAlreayInWaitEnterList")]
		ErrAlreayInWaitEnterList,
		// Token: 0x0400B378 RID: 45944
		[OriginalName("ErrHostNotInBigWorld")]
		ErrHostNotInBigWorld,
		// Token: 0x0400B379 RID: 45945
		[OriginalName("ErrPlayerNotInBigWorld")]
		ErrPlayerNotInBigWorld,
		// Token: 0x0400B37A RID: 45946
		[OriginalName("ErrPlayerNotInWaitList")]
		ErrPlayerNotInWaitList,
		// Token: 0x0400B37B RID: 45947
		[OriginalName("ErrForbidOperaInMatching")]
		ErrForbidOperaInMatching,
		// Token: 0x0400B37C RID: 45948
		[OriginalName("ErrLobbyNotFoundPlayer")]
		ErrLobbyNotFoundPlayer,
		// Token: 0x0400B37D RID: 45949
		[OriginalName("ErrRoleTrailCannotOnline")]
		ErrRoleTrailCannotOnline,
		// Token: 0x0400B37E RID: 45950
		[OriginalName("ErrHostRoleTrail")]
		ErrHostRoleTrail,
		// Token: 0x0400B37F RID: 45951
		[OriginalName("ErrInMatchingCanNotJoinOther")]
		ErrInMatchingCanNotJoinOther,
		// Token: 0x0400B380 RID: 45952
		[OriginalName("ErrInMatchCanNotBeApply")]
		ErrInMatchCanNotBeApply,
		// Token: 0x0400B381 RID: 45953
		[OriginalName("ErrInMatchCanNotAcceptApply")]
		ErrInMatchCanNotAcceptApply,
		// Token: 0x0400B382 RID: 45954
		[OriginalName("ErrSlaveInFlow")]
		ErrSlaveInFlow,
		// Token: 0x0400B383 RID: 45955
		[OriginalName("ErrHostInFlow")]
		ErrHostInFlow,
		// Token: 0x0400B384 RID: 45956
		[OriginalName("ErrAchievementNotClinet")]
		ErrAchievementNotClinet,
		// Token: 0x0400B385 RID: 45957
		[OriginalName("ErrTriggerConditionNotMet")]
		ErrTriggerConditionNotMet,
		// Token: 0x0400B386 RID: 45958
		[OriginalName("ErrNpcTraceNotConf")]
		ErrNpcTraceNotConf,
		// Token: 0x0400B387 RID: 45959
		[OriginalName("ErrBuffProducerConfNotFound")]
		ErrBuffProducerConfNotFound,
		// Token: 0x0400B388 RID: 45960
		[OriginalName("ErrBuffProducerHasDone")]
		ErrBuffProducerHasDone,
		// Token: 0x0400B389 RID: 45961
		[OriginalName("ErrBuffConsumerConfNotFound")]
		ErrBuffConsumerConfNotFound,
		// Token: 0x0400B38A RID: 45962
		[OriginalName("ErrBuffConsumerBuffNotFound")]
		ErrBuffConsumerBuffNotFound,
		// Token: 0x0400B38B RID: 45963
		[OriginalName("ErrBuffConsumerEntityNotFound")]
		ErrBuffConsumerEntityNotFound,
		// Token: 0x0400B38C RID: 45964
		[OriginalName("ErrItemPosInvaild")]
		ErrItemPosInvaild,
		// Token: 0x0400B38D RID: 45965
		[OriginalName("ErrItemIdInvaild")]
		ErrItemIdInvaild,
		// Token: 0x0400B38E RID: 45966
		[OriginalName("ErrRouletteFuncIdInvaild")]
		ErrRouletteFuncIdInvaild,
		// Token: 0x0400B38F RID: 45967
		[OriginalName("ErrStateIsRunning")]
		ErrStateIsRunning,
		// Token: 0x0400B390 RID: 45968
		[OriginalName("ErrSceneEntityNotFind")]
		ErrSceneEntityNotFind,
		// Token: 0x0400B391 RID: 45969
		[OriginalName("ErrActionPlayersIsEmpty")]
		ErrActionPlayersIsEmpty,
		// Token: 0x0400B392 RID: 45970
		[OriginalName("ErrFireBulletNoLauncher")]
		ErrFireBulletNoLauncher,
		// Token: 0x0400B393 RID: 45971
		[OriginalName("ErrFireBulletNoTarget")]
		ErrFireBulletNoTarget,
		// Token: 0x0400B394 RID: 45972
		[OriginalName("ErrTurntableConfigNotFound")]
		ErrTurntableConfigNotFound,
		// Token: 0x0400B395 RID: 45973
		[OriginalName("ErrTurntableActivityNotOpen")]
		ErrTurntableActivityNotOpen,
		// Token: 0x0400B396 RID: 45974
		[OriginalName("ErrTurntableActivityIsFinish")]
		ErrTurntableActivityIsFinish,
		// Token: 0x0400B397 RID: 45975
		[OriginalName("ErrTurntableActivityQuestNotFinish")]
		ErrTurntableActivityQuestNotFinish,
		// Token: 0x0400B398 RID: 45976
		[OriginalName("ErrTurntableActivityRoundConfigNotFound")]
		ErrTurntableActivityRoundConfigNotFound,
		// Token: 0x0400B399 RID: 45977
		[OriginalName("ErrEnrichmentAreaIsEmpty")]
		ErrEnrichmentAreaIsEmpty,
		// Token: 0x0400B39A RID: 45978
		[OriginalName("ErrEnrichmentAreaNotFind")]
		ErrEnrichmentAreaNotFind,
		// Token: 0x0400B39B RID: 45979
		[OriginalName("ErrEnrichmentAreaInCD")]
		ErrEnrichmentAreaInCd,
		// Token: 0x0400B39C RID: 45980
		[OriginalName("ErrEnrichmentAreaInFog")]
		ErrEnrichmentAreaInFog,
		// Token: 0x0400B39D RID: 45981
		[OriginalName("ErrEntityWalkingPoint")]
		ErrEntityWalkingPoint,
		// Token: 0x0400B39E RID: 45982
		[OriginalName("ErrServerConfigReload")]
		ErrServerConfigReload,
		// Token: 0x0400B39F RID: 45983
		[OriginalName("ErrAreaCheckFailed")]
		ErrAreaCheckFailed,
		// Token: 0x0400B3A0 RID: 45984
		[OriginalName("ErrHostSceneBlockSplitFail")]
		ErrHostSceneBlockSplitFail,
		// Token: 0x0400B3A1 RID: 45985
		[OriginalName("ErrSlaveSceneBlockSplitFail")]
		ErrSlaveSceneBlockSplitFail,
		// Token: 0x0400B3A2 RID: 45986
		[OriginalName("ErrHookLockBatchCollectMaxCount")]
		ErrHookLockBatchCollectMaxCount,
		// Token: 0x0400B3A3 RID: 45987
		[OriginalName("ErrHookLockBatchCollectFail")]
		ErrHookLockBatchCollectFail,
		// Token: 0x0400B3A4 RID: 45988
		[OriginalName("ErrEntityPackIdErr")]
		ErrEntityPackIdErr,
		// Token: 0x0400B3A5 RID: 45989
		[OriginalName("ErrEntityInQuickHackSkill")]
		ErrEntityInQuickHackSkill,
		// Token: 0x0400B3A6 RID: 45990
		[OriginalName("ErrEntityQuickHackSkillNoAction")]
		ErrEntityQuickHackSkillNoAction,
		// Token: 0x0400B3A7 RID: 45991
		[OriginalName("ErrVehicleInPhantomFormation")]
		ErrVehicleInPhantomFormation,
		// Token: 0x0400B3A8 RID: 45992
		[OriginalName("ErrGiantSystemNotOpen")]
		ErrGiantSystemNotOpen,
		// Token: 0x0400B3A9 RID: 45993
		[OriginalName("ErrGiantEcoIsLock")]
		ErrGiantEcoIsLock,
		// Token: 0x0400B3AA RID: 45994
		[OriginalName("ErrGiantItemInvaild")]
		ErrGiantItemInvaild,
		// Token: 0x0400B3AB RID: 45995
		[OriginalName("ErrGiantItemNotEnough")]
		ErrGiantItemNotEnough,
		// Token: 0x0400B3AC RID: 45996
		[OriginalName("ErrGiantItemNotMatch")]
		ErrGiantItemNotMatch,
		// Token: 0x0400B3AD RID: 45997
		[OriginalName("ErrGiantMaxLevel")]
		ErrGiantMaxLevel,
		// Token: 0x0400B3AE RID: 45998
		[OriginalName("ErrGiantMaxLevelDropLimit")]
		ErrGiantMaxLevelDropLimit,
		// Token: 0x0400B3AF RID: 45999
		[OriginalName("ErrGiantNotMaxLevel")]
		ErrGiantNotMaxLevel,
		// Token: 0x0400B3B0 RID: 46000
		[OriginalName("ErrGiantActivityReward")]
		ErrGiantActivityReward,
		// Token: 0x0400B3B1 RID: 46001
		[OriginalName("ErrGiantActivityNodeNotActive")]
		ErrGiantActivityNodeNotActive,
		// Token: 0x0400B3B2 RID: 46002
		[OriginalName("ErrLoopTeleportVolumeConfig")]
		ErrLoopTeleportVolumeConfig,
		// Token: 0x0400B3B3 RID: 46003
		[OriginalName("ErrLoopTeleportVolumeCondition")]
		ErrLoopTeleportVolumeCondition,
		// Token: 0x0400B3B4 RID: 46004
		[OriginalName("ErrBuffItemConfig")]
		ErrBuffItemConfig = 1000000,
		// Token: 0x0400B3B5 RID: 46005
		[OriginalName("ErrBuffItemNotShare")]
		ErrBuffItemNotShare,
		// Token: 0x0400B3B6 RID: 46006
		[OriginalName("ErrBuffItemShareRoleId")]
		ErrBuffItemShareRoleId,
		// Token: 0x0400B3B7 RID: 46007
		[OriginalName("ErrBuffItemRoleIdNotExist")]
		ErrBuffItemRoleIdNotExist,
		// Token: 0x0400B3B8 RID: 46008
		[OriginalName("ErrBuffItemNotEnough")]
		ErrBuffItemNotEnough,
		// Token: 0x0400B3B9 RID: 46009
		[OriginalName("ErrBuffItemMultiUse")]
		ErrBuffItemMultiUse,
		// Token: 0x0400B3BA RID: 46010
		[OriginalName("ErrBuffItemCdLimit")]
		ErrBuffItemCdLimit,
		// Token: 0x0400B3BB RID: 46011
		[OriginalName("ErrBuffItemNumZero")]
		ErrBuffItemNumZero,
		// Token: 0x0400B3BC RID: 46012
		[OriginalName("ErrBuffItemNotPlayer")]
		ErrBuffItemNotPlayer,
		// Token: 0x0400B3BD RID: 46013
		[OriginalName("ErrSceneItemNotExit")]
		ErrSceneItemNotExit,
		// Token: 0x0400B3BE RID: 46014
		[OriginalName("ErrSceneItemType")]
		ErrSceneItemType,
		// Token: 0x0400B3BF RID: 46015
		[OriginalName("ErrSceneItemOperate")]
		ErrSceneItemOperate,
		// Token: 0x0400B3C0 RID: 46016
		[OriginalName("ErrSceneItemState")]
		ErrSceneItemState,
		// Token: 0x0400B3C1 RID: 46017
		[OriginalName("ErrStateEntityNoExit")]
		ErrStateEntityNoExit,
		// Token: 0x0400B3C2 RID: 46018
		[OriginalName("ErrStateEntityNotTagComp")]
		ErrStateEntityNotTagComp,
		// Token: 0x0400B3C3 RID: 46019
		[OriginalName("ErrStateEntityTypeNotExit")]
		ErrStateEntityTypeNotExit,
		// Token: 0x0400B3C4 RID: 46020
		[OriginalName("ErrStateEntityStateNotExit")]
		ErrStateEntityStateNotExit,
		// Token: 0x0400B3C5 RID: 46021
		[OriginalName("ErrStateEntityNotConfig")]
		ErrStateEntityNotConfig,
		// Token: 0x0400B3C6 RID: 46022
		[OriginalName("ErrStateEntityStateType")]
		ErrStateEntityStateType,
		// Token: 0x0400B3C7 RID: 46023
		[OriginalName("ErrStateEntityStateNoChange")]
		ErrStateEntityStateNoChange,
		// Token: 0x0400B3C8 RID: 46024
		[OriginalName("ErrStateEntitySilent")]
		ErrStateEntitySilent,
		// Token: 0x0400B3C9 RID: 46025
		[OriginalName("ErrStateEntityComplete")]
		ErrStateEntityComplete,
		// Token: 0x0400B3CA RID: 46026
		[OriginalName("ErrStateEntityLock")]
		ErrStateEntityLock,
		// Token: 0x0400B3CB RID: 46027
		[OriginalName("ErrStateEntityNotBorn")]
		ErrStateEntityNotBorn,
		// Token: 0x0400B3CC RID: 46028
		[OriginalName("ErrStateNameNoExit")]
		ErrStateNameNoExit,
		// Token: 0x0400B3CD RID: 46029
		[OriginalName("ErrStateInBorn")]
		ErrStateInBorn,
		// Token: 0x0400B3CE RID: 46030
		[OriginalName("ErrStateCondition")]
		ErrStateCondition,
		// Token: 0x0400B3CF RID: 46031
		[OriginalName("ErrStateNotOwner")]
		ErrStateNotOwner,
		// Token: 0x0400B3D0 RID: 46032
		[OriginalName("ErrChangeSelfStateObjNotEntity")]
		ErrChangeSelfStateObjNotEntity,
		// Token: 0x0400B3D1 RID: 46033
		[OriginalName("ErrFoundationNotExists")]
		ErrFoundationNotExists,
		// Token: 0x0400B3D2 RID: 46034
		[OriginalName("ErrTeleControlNotExists")]
		ErrTeleControlNotExists,
		// Token: 0x0400B3D3 RID: 46035
		[OriginalName("ErrFoundationNotComponent")]
		ErrFoundationNotComponent,
		// Token: 0x0400B3D4 RID: 46036
		[OriginalName("ErrFoundationActived")]
		ErrFoundationActived,
		// Token: 0x0400B3D5 RID: 46037
		[OriginalName("ErrFoundationUnActived")]
		ErrFoundationUnActived,
		// Token: 0x0400B3D6 RID: 46038
		[OriginalName("ErrFoundationNotMatch")]
		ErrFoundationNotMatch,
		// Token: 0x0400B3D7 RID: 46039
		[OriginalName("ErrFoundationNotInRange")]
		ErrFoundationNotInRange,
		// Token: 0x0400B3D8 RID: 46040
		[OriginalName("ErrFoundationNotStateId")]
		ErrFoundationNotStateId,
		// Token: 0x0400B3D9 RID: 46041
		[OriginalName("ErrGravityGearNotExists")]
		ErrGravityGearNotExists,
		// Token: 0x0400B3DA RID: 46042
		[OriginalName("ErrGravityGearNotConfig")]
		ErrGravityGearNotConfig,
		// Token: 0x0400B3DB RID: 46043
		[OriginalName("ErrGravityGearForbidReset")]
		ErrGravityGearForbidReset,
		// Token: 0x0400B3DC RID: 46044
		[OriginalName("ErrFollowTrackEntityNoExist")]
		ErrFollowTrackEntityNoExist,
		// Token: 0x0400B3DD RID: 46045
		[OriginalName("ErrFollowTrackNotComp")]
		ErrFollowTrackNotComp,
		// Token: 0x0400B3DE RID: 46046
		[OriginalName("ErrFollowTrackNotFoundationId")]
		ErrFollowTrackNotFoundationId,
		// Token: 0x0400B3DF RID: 46047
		[OriginalName("ErrFollowTrackNotFoundation")]
		ErrFollowTrackNotFoundation,
		// Token: 0x0400B3E0 RID: 46048
		[OriginalName("ErrFollowTrackActiveed")]
		ErrFollowTrackActiveed,
		// Token: 0x0400B3E1 RID: 46049
		[OriginalName("ErrThrowPlayerNotExit")]
		ErrThrowPlayerNotExit,
		// Token: 0x0400B3E2 RID: 46050
		[OriginalName("ErrAnimalEntityNotExist")]
		ErrAnimalEntityNotExist,
		// Token: 0x0400B3E3 RID: 46051
		[OriginalName("ErrNotAnimalEntity")]
		ErrNotAnimalEntity,
		// Token: 0x0400B3E4 RID: 46052
		[OriginalName("ErrSneakBtObjNotExist")]
		ErrSneakBtObjNotExist,
		// Token: 0x0400B3E5 RID: 46053
		[OriginalName("ErrSneakNodeIdNotExist")]
		ErrSneakNodeIdNotExist,
		// Token: 0x0400B3E6 RID: 46054
		[OriginalName("ErrSneakNotFailedNode")]
		ErrSneakNotFailedNode,
		// Token: 0x0400B3E7 RID: 46055
		[OriginalName("ErrSneakNotTime")]
		ErrSneakNotTime,
		// Token: 0x0400B3E8 RID: 46056
		[OriginalName("ErrSneakTime")]
		ErrSneakTime,
		// Token: 0x0400B3E9 RID: 46057
		[OriginalName("ErrInSneak")]
		ErrInSneak,
		// Token: 0x0400B3EA RID: 46058
		[OriginalName("ErrNotInSneak")]
		ErrNotInSneak,
		// Token: 0x0400B3EB RID: 46059
		[OriginalName("ErrBeControlledEntityNotExist")]
		ErrBeControlledEntityNotExist,
		// Token: 0x0400B3EC RID: 46060
		[OriginalName("ErrNotBeControlledEntity")]
		ErrNotBeControlledEntity,
		// Token: 0x0400B3ED RID: 46061
		[OriginalName("ErrNotBeControlledPlayer")]
		ErrNotBeControlledPlayer,
		// Token: 0x0400B3EE RID: 46062
		[OriginalName("ErrNotBeControlledNotPlayer")]
		ErrNotBeControlledNotPlayer,
		// Token: 0x0400B3EF RID: 46063
		[OriginalName("ErrBeControlledShowEntityNotExist")]
		ErrBeControlledShowEntityNotExist,
		// Token: 0x0400B3F0 RID: 46064
		[OriginalName("ErrNotBeControlledShowEntity")]
		ErrNotBeControlledShowEntity,
		// Token: 0x0400B3F1 RID: 46065
		[OriginalName("ErrNotBeControlledShowPlayer")]
		ErrNotBeControlledShowPlayer,
		// Token: 0x0400B3F2 RID: 46066
		[OriginalName("ErrBeControlledShowNoChange")]
		ErrBeControlledShowNoChange,
		// Token: 0x0400B3F3 RID: 46067
		[OriginalName("ErrGravityGearCondition")]
		ErrGravityGearCondition,
		// Token: 0x0400B3F4 RID: 46068
		[OriginalName("ErrChairEntityNoExist")]
		ErrChairEntityNoExist,
		// Token: 0x0400B3F5 RID: 46069
		[OriginalName("ErrChairSitDownErr")]
		ErrChairSitDownErr,
		// Token: 0x0400B3F6 RID: 46070
		[OriginalName("ErrChairEntity")]
		ErrChairEntity,
		// Token: 0x0400B3F7 RID: 46071
		[OriginalName("ErrPlayerAlreadySit")]
		ErrPlayerAlreadySit,
		// Token: 0x0400B3F8 RID: 46072
		[OriginalName("ErrChairNotStateConfig")]
		ErrChairNotStateConfig,
		// Token: 0x0400B3F9 RID: 46073
		[OriginalName("ErrSneakBtObjIncId")]
		ErrSneakBtObjIncId,
		// Token: 0x0400B3FA RID: 46074
		[OriginalName("ErrTimelineMove")]
		ErrTimelineMove,
		// Token: 0x0400B3FB RID: 46075
		[OriginalName("ErrBeControlledConfig")]
		ErrBeControlledConfig,
		// Token: 0x0400B3FC RID: 46076
		[OriginalName("ErrBeControlledThrow")]
		ErrBeControlledThrow,
		// Token: 0x0400B3FD RID: 46077
		[OriginalName("ErrBeControlledTimeNull")]
		ErrBeControlledTimeNull,
		// Token: 0x0400B3FE RID: 46078
		[OriginalName("ErrTriggerEnterActionEffective")]
		ErrTriggerEnterActionEffective,
		// Token: 0x0400B3FF RID: 46079
		[OriginalName("ErrTriggerLeaveActionEffective")]
		ErrTriggerLeaveActionEffective,
		// Token: 0x0400B400 RID: 46080
		[OriginalName("ErrTriggerLastActionStateError")]
		ErrTriggerLastActionStateError,
		// Token: 0x0400B401 RID: 46081
		[OriginalName("GuideGroupInfoIsNull")]
		GuideGroupInfoIsNull = 1100000,
		// Token: 0x0400B402 RID: 46082
		[OriginalName("GuideStateError")]
		GuideStateError,
		// Token: 0x0400B403 RID: 46083
		[OriginalName("GuideConfigNotFind")]
		GuideConfigNotFind,
		// Token: 0x0400B404 RID: 46084
		[OriginalName("GuideNoEnough")]
		GuideNoEnough,
		// Token: 0x0400B405 RID: 46085
		[OriginalName("GuideIsFinish")]
		GuideIsFinish,
		// Token: 0x0400B406 RID: 46086
		[OriginalName("GuidePerIsNotFinish")]
		GuidePerIsNotFinish,
		// Token: 0x0400B407 RID: 46087
		[OriginalName("GuideNoCondition")]
		GuideNoCondition,
		// Token: 0x0400B408 RID: 46088
		[OriginalName("GuideNoCurGroup")]
		GuideNoCurGroup,
		// Token: 0x0400B409 RID: 46089
		[OriginalName("GuideIsServerMonitor")]
		GuideIsServerMonitor,
		// Token: 0x0400B40A RID: 46090
		[OriginalName("GuideNoPending")]
		GuideNoPending,
		// Token: 0x0400B40B RID: 46091
		[OriginalName("GuideStepRepeat")]
		GuideStepRepeat,
		// Token: 0x0400B40C RID: 46092
		[OriginalName("GuideGroupNoClient")]
		GuideGroupNoClient,
		// Token: 0x0400B40D RID: 46093
		[OriginalName("GuideGroupDoing")]
		GuideGroupDoing,
		// Token: 0x0400B40E RID: 46094
		[OriginalName("GuideGroupIsNotRepeat")]
		GuideGroupIsNotRepeat,
		// Token: 0x0400B40F RID: 46095
		[OriginalName("GuideTutorialConfigNotFind")]
		GuideTutorialConfigNotFind,
		// Token: 0x0400B410 RID: 46096
		[OriginalName("GuideTutorialIsUnlock")]
		GuideTutorialIsUnlock,
		// Token: 0x0400B411 RID: 46097
		[OriginalName("GuideTutorialNotUnlock")]
		GuideTutorialNotUnlock,
		// Token: 0x0400B412 RID: 46098
		[OriginalName("GuideTutorialIsReceive")]
		GuideTutorialIsReceive,
		// Token: 0x0400B413 RID: 46099
		[OriginalName("GuideTutorialAwardConfigNotFind")]
		GuideTutorialAwardConfigNotFind,
		// Token: 0x0400B414 RID: 46100
		[OriginalName("GuideTutorialAwardError")]
		GuideTutorialAwardError,
		// Token: 0x0400B415 RID: 46101
		[OriginalName("GuideGroupIdNoMatch")]
		GuideGroupIdNoMatch,
		// Token: 0x0400B416 RID: 46102
		[OriginalName("ErrRequestTypeNotExist")]
		ErrRequestTypeNotExist,
		// Token: 0x0400B417 RID: 46103
		[OriginalName("ErrIllustratedEntryLock")]
		ErrIllustratedEntryLock,
		// Token: 0x0400B418 RID: 46104
		[OriginalName("ErrIllustratedEntryBanUnlock")]
		ErrIllustratedEntryBanUnlock,
		// Token: 0x0400B419 RID: 46105
		[OriginalName("ErrRequestTypeMax")]
		ErrRequestTypeMax,
		// Token: 0x0400B41A RID: 46106
		[OriginalName("AchievementEntryNotExist")]
		AchievementEntryNotExist,
		// Token: 0x0400B41B RID: 46107
		[OriginalName("AchievementEntryNotFinish")]
		AchievementEntryNotFinish,
		// Token: 0x0400B41C RID: 46108
		[OriginalName("AchievementEntryIsReceive")]
		AchievementEntryIsReceive,
		// Token: 0x0400B41D RID: 46109
		[OriginalName("AchievementEntryNoConfig")]
		AchievementEntryNoConfig,
		// Token: 0x0400B41E RID: 46110
		[OriginalName("AchievementEntryNotOpen")]
		AchievementEntryNotOpen,
		// Token: 0x0400B41F RID: 46111
		[OriginalName("AchievementGroupEntryNotExist")]
		AchievementGroupEntryNotExist,
		// Token: 0x0400B420 RID: 46112
		[OriginalName("AchievementGroupEntryNotFinish")]
		AchievementGroupEntryNotFinish,
		// Token: 0x0400B421 RID: 46113
		[OriginalName("AchievementGroupEntryIsReceive")]
		AchievementGroupEntryIsReceive,
		// Token: 0x0400B422 RID: 46114
		[OriginalName("AchievementGroupEntryNoConfig")]
		AchievementGroupEntryNoConfig,
		// Token: 0x0400B423 RID: 46115
		[OriginalName("AchievementGroupEntryNotOpen")]
		AchievementGroupEntryNotOpen,
		// Token: 0x0400B424 RID: 46116
		[OriginalName("SilentAreaNotConfig")]
		SilentAreaNotConfig,
		// Token: 0x0400B425 RID: 46117
		[OriginalName("SilentAreaNotUnlock")]
		SilentAreaNotUnlock,
		// Token: 0x0400B426 RID: 46118
		[OriginalName("SilentAreaNotFinish")]
		SilentAreaNotFinish,
		// Token: 0x0400B427 RID: 46119
		[OriginalName("SilentAreaReceive")]
		SilentAreaReceive,
		// Token: 0x0400B428 RID: 46120
		[OriginalName("AchievementEntryIsFinish")]
		AchievementEntryIsFinish,
		// Token: 0x0400B429 RID: 46121
		[OriginalName("AchievementEntryNeedCondition")]
		AchievementEntryNeedCondition,
		// Token: 0x0400B42A RID: 46122
		[OriginalName("AchievementSceneNotFind")]
		AchievementSceneNotFind,
		// Token: 0x0400B42B RID: 46123
		[OriginalName("BirthdayIsSetting")]
		BirthdayIsSetting,
		// Token: 0x0400B42C RID: 46124
		[OriginalName("BirthdayInValid")]
		BirthdayInValid,
		// Token: 0x0400B42D RID: 46125
		[OriginalName("RoleShowListMaxCount")]
		RoleShowListMaxCount,
		// Token: 0x0400B42E RID: 46126
		[OriginalName("RoleShowListHasRepeatId")]
		RoleShowListHasRepeatId,
		// Token: 0x0400B42F RID: 46127
		[OriginalName("RoleShowListHasInValidId")]
		RoleShowListHasInValidId,
		// Token: 0x0400B430 RID: 46128
		[OriginalName("CardShowListMaxCount")]
		CardShowListMaxCount,
		// Token: 0x0400B431 RID: 46129
		[OriginalName("CardShowListHasRepeatId")]
		CardShowListHasRepeatId,
		// Token: 0x0400B432 RID: 46130
		[OriginalName("CardShowListHasInValidId")]
		CardShowListHasInValidId,
		// Token: 0x0400B433 RID: 46131
		[OriginalName("CardRepeatSet")]
		CardRepeatSet,
		// Token: 0x0400B434 RID: 46132
		[OriginalName("CardIsInValidId")]
		CardIsInValidId,
		// Token: 0x0400B435 RID: 46133
		[OriginalName("CardIsRead")]
		CardIsRead,
		// Token: 0x0400B436 RID: 46134
		[OriginalName("RoleShowListEmpty")]
		RoleShowListEmpty,
		// Token: 0x0400B437 RID: 46135
		[OriginalName("SettingNotFind")]
		SettingNotFind,
		// Token: 0x0400B438 RID: 46136
		[OriginalName("RogueRoadConfigNotFind")]
		RogueRoadConfigNotFind,
		// Token: 0x0400B439 RID: 46137
		[OriginalName("RollRogueRoomError")]
		RollRogueRoomError,
		// Token: 0x0400B43A RID: 46138
		[OriginalName("RollRogueBuffError")]
		RollRogueBuffError,
		// Token: 0x0400B43B RID: 46139
		[OriginalName("GetRogueRoomIdsError")]
		GetRogueRoomIdsError,
		// Token: 0x0400B43C RID: 46140
		[OriginalName("GetRoguePortalEntityNotFind")]
		GetRoguePortalEntityNotFind,
		// Token: 0x0400B43D RID: 46141
		[OriginalName("GetRoguePortalLocationNotFind")]
		GetRoguePortalLocationNotFind,
		// Token: 0x0400B43E RID: 46142
		[OriginalName("HttpTimeout")]
		HttpTimeout,
		// Token: 0x0400B43F RID: 46143
		[OriginalName("HttpResultUndefine")]
		HttpResultUndefine,
		// Token: 0x0400B440 RID: 46144
		[OriginalName("ConvGateTimeout")]
		ConvGateTimeout,
		// Token: 0x0400B441 RID: 46145
		[OriginalName("ProtoKeyTimeout")]
		ProtoKeyTimeout,
		// Token: 0x0400B442 RID: 46146
		[OriginalName("LoginReqTimeout")]
		LoginReqTimeout,
		// Token: 0x0400B443 RID: 46147
		[OriginalName("EnterGameTimeout")]
		EnterGameTimeout,
		// Token: 0x0400B444 RID: 46148
		[OriginalName("ReReconvReqTimeout")]
		ReReconvReqTimeout,
		// Token: 0x0400B445 RID: 46149
		[OriginalName("RecvSeqNoNotHit")]
		RecvSeqNoNotHit,
		// Token: 0x0400B446 RID: 46150
		[OriginalName("AchievementFuncNotOpen")]
		AchievementFuncNotOpen,
		// Token: 0x0400B447 RID: 46151
		[OriginalName("RoguelikeInstComponentNotFind")]
		RoguelikeInstComponentNotFind,
		// Token: 0x0400B448 RID: 46152
		[OriginalName("RogueCurRoomDataIsNull")]
		RogueCurRoomDataIsNull,
		// Token: 0x0400B449 RID: 46153
		[OriginalName("LevelPlayComponentNotFind")]
		LevelPlayComponentNotFind,
		// Token: 0x0400B44A RID: 46154
		[OriginalName("OpenLevelPlayFail")]
		OpenLevelPlayFail,
		// Token: 0x0400B44B RID: 46155
		[OriginalName("CloseLevelPlayFail")]
		CloseLevelPlayFail,
		// Token: 0x0400B44C RID: 46156
		[OriginalName("RogueRoomConfigNotFind")]
		RogueRoomConfigNotFind,
		// Token: 0x0400B44D RID: 46157
		[OriginalName("RogueRoomTypeNotRight")]
		RogueRoomTypeNotRight,
		// Token: 0x0400B44E RID: 46158
		[OriginalName("RogueRoomTypeNotConfig")]
		RogueRoomTypeNotConfig,
		// Token: 0x0400B44F RID: 46159
		[OriginalName("RogueRoomSubLevelNotFind")]
		RogueRoomSubLevelNotFind,
		// Token: 0x0400B450 RID: 46160
		[OriginalName("SelectNextRoomIsValid")]
		SelectNextRoomIsValid,
		// Token: 0x0400B451 RID: 46161
		[OriginalName("RogueGainPackageFail")]
		RogueGainPackageFail,
		// Token: 0x0400B452 RID: 46162
		[OriginalName("RogueGainListIsNull")]
		RogueGainListIsNull,
		// Token: 0x0400B453 RID: 46163
		[OriginalName("RogueGainIdValid")]
		RogueGainIdValid,
		// Token: 0x0400B454 RID: 46164
		[OriginalName("QulityListCountNotRight")]
		QulityListCountNotRight,
		// Token: 0x0400B455 RID: 46165
		[OriginalName("RandomResultCountNotRight")]
		RandomResultCountNotRight,
		// Token: 0x0400B456 RID: 46166
		[OriginalName("GuaranteeRogueBuffInValid")]
		GuaranteeRogueBuffInValid,
		// Token: 0x0400B457 RID: 46167
		[OriginalName("RoleBuffPoolNotFind")]
		RoleBuffPoolNotFind,
		// Token: 0x0400B458 RID: 46168
		[OriginalName("NotValidBuff")]
		NotValidBuff,
		// Token: 0x0400B459 RID: 46169
		[OriginalName("NotValidPhantom")]
		NotValidPhantom,
		// Token: 0x0400B45A RID: 46170
		[OriginalName("RandomPhantomFail")]
		RandomPhantomFail,
		// Token: 0x0400B45B RID: 46171
		[OriginalName("NotValidRole")]
		NotValidRole,
		// Token: 0x0400B45C RID: 46172
		[OriginalName("RandomRoleFail")]
		RandomRoleFail,
		// Token: 0x0400B45D RID: 46173
		[OriginalName("RogueRoadNotFind")]
		RogueRoadNotFind,
		// Token: 0x0400B45E RID: 46174
		[OriginalName("ResultCountNotMatch")]
		ResultCountNotMatch,
		// Token: 0x0400B45F RID: 46175
		[OriginalName("InValidRoomCountNotMatch")]
		InValidRoomCountNotMatch,
		// Token: 0x0400B460 RID: 46176
		[OriginalName("GuaranteeRogueRoomInValid")]
		GuaranteeRogueRoomInValid,
		// Token: 0x0400B461 RID: 46177
		[OriginalName("InstIdNotMatchLevelPlayId")]
		InstIdNotMatchLevelPlayId,
		// Token: 0x0400B462 RID: 46178
		[OriginalName("GetRoomBornPositionFail")]
		GetRoomBornPositionFail,
		// Token: 0x0400B463 RID: 46179
		[OriginalName("RoguePortalDataNotClean")]
		RoguePortalDataNotClean,
		// Token: 0x0400B464 RID: 46180
		[OriginalName("RoguePortalRoomDataNotFind")]
		RoguePortalRoomDataNotFind,
		// Token: 0x0400B465 RID: 46181
		[OriginalName("RogueSelectRoomFail")]
		RogueSelectRoomFail,
		// Token: 0x0400B466 RID: 46182
		[OriginalName("RogueProgressDataIsEmpty")]
		RogueProgressDataIsEmpty,
		// Token: 0x0400B467 RID: 46183
		[OriginalName("RogueGainTypeIsValid")]
		RogueGainTypeIsValid,
		// Token: 0x0400B468 RID: 46184
		[OriginalName("RougeNotOpen")]
		RougeNotOpen,
		// Token: 0x0400B469 RID: 46185
		[OriginalName("RougeInstIdIsValid")]
		RougeInstIdIsValid,
		// Token: 0x0400B46A RID: 46186
		[OriginalName("RogueRoleListCountNotRight")]
		RogueRoleListCountNotRight,
		// Token: 0x0400B46B RID: 46187
		[OriginalName("RogueMainRoleConfigNotFind")]
		RogueMainRoleConfigNotFind,
		// Token: 0x0400B46C RID: 46188
		[OriginalName("RogueGainDataDictError")]
		RogueGainDataDictError,
		// Token: 0x0400B46D RID: 46189
		[OriginalName("RogueDiscountedBuffConfigNotFind")]
		RogueDiscountedBuffConfigNotFind,
		// Token: 0x0400B46E RID: 46190
		[OriginalName("RogueDiscountedRoomTypeConfigNotFind")]
		RogueDiscountedRoomTypeConfigNotFind,
		// Token: 0x0400B46F RID: 46191
		[OriginalName("RogueDiscountedShopConfigNotFind")]
		RogueDiscountedShopConfigNotFind,
		// Token: 0x0400B470 RID: 46192
		[OriginalName("RogueDiscountedCalculateFail")]
		RogueDiscountedCalculateFail,
		// Token: 0x0400B471 RID: 46193
		[OriginalName("RogueMoneyNotEnough")]
		RogueMoneyNotEnough,
		// Token: 0x0400B472 RID: 46194
		[OriginalName("RougeShopRefreshTimeEmpyt")]
		RougeShopRefreshTimeEmpyt,
		// Token: 0x0400B473 RID: 46195
		[OriginalName("RougeCurRoomNotFinish")]
		RougeCurRoomNotFinish,
		// Token: 0x0400B474 RID: 46196
		[OriginalName("PlayerDataRepairErrorDebug")]
		PlayerDataRepairErrorDebug,
		// Token: 0x0400B475 RID: 46197
		[OriginalName("PlayerDataRepairError")]
		PlayerDataRepairError,
		// Token: 0x0400B476 RID: 46198
		[OriginalName("CreateCharacterReqTimeout")]
		CreateCharacterReqTimeout,
		// Token: 0x0400B477 RID: 46199
		[OriginalName("SignActivityNotOpen")]
		SignActivityNotOpen,
		// Token: 0x0400B478 RID: 46200
		[OriginalName("SignActivityNoConfig")]
		SignActivityNoConfig,
		// Token: 0x0400B479 RID: 46201
		[OriginalName("SignActivityIndexValid")]
		SignActivityIndexValid,
		// Token: 0x0400B47A RID: 46202
		[OriginalName("SignActivityNoData")]
		SignActivityNoData,
		// Token: 0x0400B47B RID: 46203
		[OriginalName("SignActivityStateNotRight")]
		SignActivityStateNotRight,
		// Token: 0x0400B47C RID: 46204
		[OriginalName("RogueSeasonDataNull")]
		RogueSeasonDataNull,
		// Token: 0x0400B47D RID: 46205
		[OriginalName("RogueSeasonConfigNotFind")]
		RogueSeasonConfigNotFind,
		// Token: 0x0400B47E RID: 46206
		[OriginalName("RogueTokenConfigNotFind")]
		RogueTokenConfigNotFind,
		// Token: 0x0400B47F RID: 46207
		[OriginalName("RogueTokenStatusVaild")]
		RogueTokenStatusVaild,
		// Token: 0x0400B480 RID: 46208
		[OriginalName("RogueSeasonRewardConfigNotFind")]
		RogueSeasonRewardConfigNotFind,
		// Token: 0x0400B481 RID: 46209
		[OriginalName("RogueSeasonRewardIsReceive")]
		RogueSeasonRewardIsReceive,
		// Token: 0x0400B482 RID: 46210
		[OriginalName("RougeSeasonPointNotEnough")]
		RougeSeasonPointNotEnough,
		// Token: 0x0400B483 RID: 46211
		[OriginalName("RougeRoomDataError")]
		RougeRoomDataError,
		// Token: 0x0400B484 RID: 46212
		[OriginalName("RogueGainDataError")]
		RogueGainDataError,
		// Token: 0x0400B485 RID: 46213
		[OriginalName("RogueRoleIdsError")]
		RogueRoleIdsError,
		// Token: 0x0400B486 RID: 46214
		[OriginalName("RogueRogueRoomRouteError")]
		RogueRogueRoomRouteError,
		// Token: 0x0400B487 RID: 46215
		[OriginalName("RogueGetCurRoomLevelPlayError")]
		RogueGetCurRoomLevelPlayError,
		// Token: 0x0400B488 RID: 46216
		[OriginalName("RogueTalentTreeConfigNotFind")]
		RogueTalentTreeConfigNotFind,
		// Token: 0x0400B489 RID: 46217
		[OriginalName("RogueTalentTreeConditionNotMet")]
		RogueTalentTreeConditionNotMet,
		// Token: 0x0400B48A RID: 46218
		[OriginalName("RogueTalentTreePerNodeLock")]
		RogueTalentTreePerNodeLock,
		// Token: 0x0400B48B RID: 46219
		[OriginalName("RogueTalentTreeNodeMaxLevel")]
		RogueTalentTreeNodeMaxLevel,
		// Token: 0x0400B48C RID: 46220
		[OriginalName("RogueTalentTreeConsumeNoEnough")]
		RogueTalentTreeConsumeNoEnough,
		// Token: 0x0400B48D RID: 46221
		[OriginalName("RogueRoadRandomRoleBuffError")]
		RogueRoadRandomRoleBuffError,
		// Token: 0x0400B48E RID: 46222
		[OriginalName("ActivityFuncNotOpen")]
		ActivityFuncNotOpen,
		// Token: 0x0400B48F RID: 46223
		[OriginalName("RogueGuideInstNotSupport")]
		RogueGuideInstNotSupport,
		// Token: 0x0400B490 RID: 46224
		[OriginalName("ErrPayReceiptCannotRefundClose")]
		ErrPayReceiptCannotRefundClose,
		// Token: 0x0400B491 RID: 46225
		[OriginalName("ErrPayReceiptRefundCloseFail")]
		ErrPayReceiptRefundCloseFail,
		// Token: 0x0400B492 RID: 46226
		[OriginalName("PayRefundOverdueBan")]
		PayRefundOverdueBan,
		// Token: 0x0400B493 RID: 46227
		[OriginalName("UnknowChannelId")]
		UnknowChannelId,
		// Token: 0x0400B494 RID: 46228
		[OriginalName("LoginServerNotFind")]
		LoginServerNotFind,
		// Token: 0x0400B495 RID: 46229
		[OriginalName("OldGameNodeLogoutFail")]
		OldGameNodeLogoutFail,
		// Token: 0x0400B496 RID: 46230
		[OriginalName("LoginHandleSwitchError")]
		LoginHandleSwitchError,
		// Token: 0x0400B497 RID: 46231
		[OriginalName("NoAvailableLoginService")]
		NoAvailableLoginService,
		// Token: 0x0400B498 RID: 46232
		[OriginalName("ServerIsClosing")]
		ServerIsClosing,
		// Token: 0x0400B499 RID: 46233
		[OriginalName("AddPlayerRecordFail")]
		AddPlayerRecordFail,
		// Token: 0x0400B49A RID: 46234
		[OriginalName("FindGatewayFail")]
		FindGatewayFail,
		// Token: 0x0400B49B RID: 46235
		[OriginalName("CommonFightRolesInfoError")]
		CommonFightRolesInfoError,
		// Token: 0x0400B49C RID: 46236
		[OriginalName("CurRoleEntityNotFind")]
		CurRoleEntityNotFind,
		// Token: 0x0400B49D RID: 46237
		[OriginalName("ScenePlayerInfoNotFind")]
		ScenePlayerInfoNotFind,
		// Token: 0x0400B49E RID: 46238
		[OriginalName("IncrAdviceVoteError")]
		IncrAdviceVoteError,
		// Token: 0x0400B49F RID: 46239
		[OriginalName("InsertAdviceError")]
		InsertAdviceError,
		// Token: 0x0400B4A0 RID: 46240
		[OriginalName("UpdateAdviceError")]
		UpdateAdviceError,
		// Token: 0x0400B4A1 RID: 46241
		[OriginalName("DeleteAdviceError")]
		DeleteAdviceError,
		// Token: 0x0400B4A2 RID: 46242
		[OriginalName("EntityNoInWater")]
		EntityNoInWater,
		// Token: 0x0400B4A3 RID: 46243
		[OriginalName("AttributeComponentNotFind")]
		AttributeComponentNotFind,
		// Token: 0x0400B4A4 RID: 46244
		[OriginalName("TryAddItemDataFail")]
		TryAddItemDataFail,
		// Token: 0x0400B4A5 RID: 46245
		[OriginalName("ItemConfigTypeNotRight")]
		ItemConfigTypeNotRight,
		// Token: 0x0400B4A6 RID: 46246
		[OriginalName("ItemLogicNotFind")]
		ItemLogicNotFind,
		// Token: 0x0400B4A7 RID: 46247
		[OriginalName("RemoveItemLogicNotFind")]
		RemoveItemLogicNotFind,
		// Token: 0x0400B4A8 RID: 46248
		[OriginalName("AddItemLogicNotFind")]
		AddItemLogicNotFind,
		// Token: 0x0400B4A9 RID: 46249
		[OriginalName("AddItemFail")]
		AddItemFail,
		// Token: 0x0400B4AA RID: 46250
		[OriginalName("UpdatePlayerARemarkFail")]
		UpdatePlayerAremarkFail,
		// Token: 0x0400B4AB RID: 46251
		[OriginalName("DeleteFriendApplyFail")]
		DeleteFriendApplyFail,
		// Token: 0x0400B4AC RID: 46252
		[OriginalName("DeleteFriendshipFail")]
		DeleteFriendshipFail,
		// Token: 0x0400B4AD RID: 46253
		[OriginalName("WorldTeamIsNull")]
		WorldTeamIsNull,
		// Token: 0x0400B4AE RID: 46254
		[OriginalName("TeamCountNotRight")]
		TeamCountNotRight,
		// Token: 0x0400B4AF RID: 46255
		[OriginalName("AddCalabashExpFail")]
		AddCalabashExpFail,
		// Token: 0x0400B4B0 RID: 46256
		[OriginalName("SendRequestToSdkFail")]
		SendRequestToSdkFail,
		// Token: 0x0400B4B1 RID: 46257
		[OriginalName("DirtyWordErrorCode")]
		DirtyWordErrorCode,
		// Token: 0x0400B4B2 RID: 46258
		[OriginalName("HarvestActivityNotOpen")]
		HarvestActivityNotOpen,
		// Token: 0x0400B4B3 RID: 46259
		[OriginalName("HarvestActivityPointReceived")]
		HarvestActivityPointReceived,
		// Token: 0x0400B4B4 RID: 46260
		[OriginalName("HarvestActivityPointNotConfig")]
		HarvestActivityPointNotConfig,
		// Token: 0x0400B4B5 RID: 46261
		[OriginalName("HarvestActivityPointNotEnough")]
		HarvestActivityPointNotEnough,
		// Token: 0x0400B4B6 RID: 46262
		[OriginalName("HarvestActivityLevelNoData")]
		HarvestActivityLevelNoData,
		// Token: 0x0400B4B7 RID: 46263
		[OriginalName("HarvestActivityLevelReceived")]
		HarvestActivityLevelReceived,
		// Token: 0x0400B4B8 RID: 46264
		[OriginalName("HarvestActivityLevelNotConfig")]
		HarvestActivityLevelNotConfig,
		// Token: 0x0400B4B9 RID: 46265
		[OriginalName("HarvestActivityLevelNotEnough")]
		HarvestActivityLevelNotEnough,
		// Token: 0x0400B4BA RID: 46266
		[OriginalName("HarvestActivityLevelDiffNotConfig")]
		HarvestActivityLevelDiffNotConfig,
		// Token: 0x0400B4BB RID: 46267
		[OriginalName("RoguelikeEventConfigNotFind")]
		RoguelikeEventConfigNotFind,
		// Token: 0x0400B4BC RID: 46268
		[OriginalName("RoguelikeEventIndexError")]
		RoguelikeEventIndexError,
		// Token: 0x0400B4BD RID: 46269
		[OriginalName("RoguelikeInstConfigNotFind")]
		RoguelikeInstConfigNotFind,
		// Token: 0x0400B4BE RID: 46270
		[OriginalName("RoguelikeMainRoleError")]
		RoguelikeMainRoleError,
		// Token: 0x0400B4BF RID: 46271
		[OriginalName("RoguelikeEventIsEmpty")]
		RoguelikeEventIsEmpty,
		// Token: 0x0400B4C0 RID: 46272
		[OriginalName("RoguelikeEventRandomError")]
		RoguelikeEventRandomError,
		// Token: 0x0400B4C1 RID: 46273
		[OriginalName("RoguelikeEventRandomEmpty")]
		RoguelikeEventRandomEmpty,
		// Token: 0x0400B4C2 RID: 46274
		[OriginalName("PhantomCollectActivityNotOpen")]
		PhantomCollectActivityNotOpen,
		// Token: 0x0400B4C3 RID: 46275
		[OriginalName("PhantomCollectActivitynNotConfig")]
		PhantomCollectActivitynNotConfig,
		// Token: 0x0400B4C4 RID: 46276
		[OriginalName("PhantomCollectActivitynNoData")]
		PhantomCollectActivitynNoData,
		// Token: 0x0400B4C5 RID: 46277
		[OriginalName("PhantomCollectActivityReceived")]
		PhantomCollectActivityReceived,
		// Token: 0x0400B4C6 RID: 46278
		[OriginalName("HarvestInstIdInValid")]
		HarvestInstIdInValid,
		// Token: 0x0400B4C7 RID: 46279
		[OriginalName("HarvestVarNotExist")]
		HarvestVarNotExist,
		// Token: 0x0400B4C8 RID: 46280
		[OriginalName("HarvestResultCacheNotExist")]
		HarvestResultCacheNotExist,
		// Token: 0x0400B4C9 RID: 46281
		[OriginalName("HarvestInstNotOpen")]
		HarvestInstNotOpen,
		// Token: 0x0400B4CA RID: 46282
		[OriginalName("HarvestActivityLimitDataNotFind")]
		HarvestActivityLimitDataNotFind,
		// Token: 0x0400B4CB RID: 46283
		[OriginalName("HarvestDiffConfigNotFind")]
		HarvestDiffConfigNotFind,
		// Token: 0x0400B4CC RID: 46284
		[OriginalName("HarvestActivityDiffConfigNotFind")]
		HarvestActivityDiffConfigNotFind,
		// Token: 0x0400B4CD RID: 46285
		[OriginalName("ErrIllustratedConfigNotFind")]
		ErrIllustratedConfigNotFind,
		// Token: 0x0400B4CE RID: 46286
		[OriginalName("CharacterAlreadyCreated")]
		CharacterAlreadyCreated,
		// Token: 0x0400B4CF RID: 46287
		[OriginalName("SdkHelperInternalError")]
		SdkHelperInternalError,
		// Token: 0x0400B4D0 RID: 46288
		[OriginalName("GameServiceControllerInternalError")]
		GameServiceControllerInternalError,
		// Token: 0x0400B4D1 RID: 46289
		[OriginalName("DoGetCacheInfoInternalError")]
		DoGetCacheInfoInternalError,
		// Token: 0x0400B4D2 RID: 46290
		[OriginalName("DoGetCacheInfosInternalError")]
		DoGetCacheInfosInternalError,
		// Token: 0x0400B4D3 RID: 46291
		[OriginalName("DeleteFriendLoadedInternalError")]
		DeleteFriendLoadedInternalError,
		// Token: 0x0400B4D4 RID: 46292
		[OriginalName("UpdateFriendRemarkInternalError")]
		UpdateFriendRemarkInternalError,
		// Token: 0x0400B4D5 RID: 46293
		[OriginalName("CheckApplyRequestInternalError")]
		CheckApplyRequestInternalError,
		// Token: 0x0400B4D6 RID: 46294
		[OriginalName("OnReLoginInternalError")]
		OnReLoginInternalError,
		// Token: 0x0400B4D7 RID: 46295
		[OriginalName("CreateCharacterRequestInternalError")]
		CreateCharacterRequestInternalError,
		// Token: 0x0400B4D8 RID: 46296
		[OriginalName("LoginRequestInternalError")]
		LoginRequestInternalError,
		// Token: 0x0400B4D9 RID: 46297
		[OriginalName("LoginRequestInternalError2")]
		LoginRequestInternalError2,
		// Token: 0x0400B4DA RID: 46298
		[OriginalName("EnterGameRequestInternalError")]
		EnterGameRequestInternalError,
		// Token: 0x0400B4DB RID: 46299
		[OriginalName("ReconnectRequestInternalError")]
		ReconnectRequestInternalError,
		// Token: 0x0400B4DC RID: 46300
		[OriginalName("ReconnectRequestInternalError2")]
		ReconnectRequestInternalError2,
		// Token: 0x0400B4DD RID: 46301
		[OriginalName("SwitchNodeInternalError")]
		SwitchNodeInternalError,
		// Token: 0x0400B4DE RID: 46302
		[OriginalName("InnerLoginInternalError")]
		InnerLoginInternalError,
		// Token: 0x0400B4DF RID: 46303
		[OriginalName("AccessTokenInternalError")]
		AccessTokenInternalError,
		// Token: 0x0400B4E0 RID: 46304
		[OriginalName("CreateCharacterInternalError")]
		CreateCharacterInternalError,
		// Token: 0x0400B4E1 RID: 46305
		[OriginalName("RogueSeasonNotValid")]
		RogueSeasonNotValid,
		// Token: 0x0400B4E2 RID: 46306
		[OriginalName("RogueCurRoleNotFind")]
		RogueCurRoleNotFind,
		// Token: 0x0400B4E3 RID: 46307
		[OriginalName("RogueSeasonNotMatch")]
		RogueSeasonNotMatch,
		// Token: 0x0400B4E4 RID: 46308
		[OriginalName("RogueGainLogicNotFind")]
		RogueGainLogicNotFind,
		// Token: 0x0400B4E5 RID: 46309
		[OriginalName("RogueBuffConfigNotFind")]
		RogueBuffConfigNotFind,
		// Token: 0x0400B4E6 RID: 46310
		[OriginalName("RoguePhantomNotConfig")]
		RoguePhantomNotConfig,
		// Token: 0x0400B4E7 RID: 46311
		[OriginalName("RogueRoleNotConfig")]
		RogueRoleNotConfig,
		// Token: 0x0400B4E8 RID: 46312
		[OriginalName("RoguePopularSlotConfigNotFind")]
		RoguePopularSlotConfigNotFind,
		// Token: 0x0400B4E9 RID: 46313
		[OriginalName("RoguePopularCountIsMax")]
		RoguePopularCountIsMax,
		// Token: 0x0400B4EA RID: 46314
		[OriginalName("RoguePopularConfigNotFind")]
		RoguePopularConfigNotFind,
		// Token: 0x0400B4EB RID: 46315
		[OriginalName("RogueRoleNotOpen")]
		RogueRoleNotOpen,
		// Token: 0x0400B4EC RID: 46316
		[OriginalName("RogueGuideInstError")]
		RogueGuideInstError,
		// Token: 0x0400B4ED RID: 46317
		[OriginalName("RogueMainRoleChange")]
		RogueMainRoleChange,
		// Token: 0x0400B4EE RID: 46318
		[OriginalName("RogueShopConfigNull")]
		RogueShopConfigNull,
		// Token: 0x0400B4EF RID: 46319
		[OriginalName("RogueGainIsSelect")]
		RogueGainIsSelect,
		// Token: 0x0400B4F0 RID: 46320
		[OriginalName("RogueGainNoRefresh")]
		RogueGainNoRefresh,
		// Token: 0x0400B4F1 RID: 46321
		[OriginalName("RogueRefreshCostNotFind")]
		RogueRefreshCostNotFind,
		// Token: 0x0400B4F2 RID: 46322
		[OriginalName("RogueNotMaxLayer")]
		RogueNotMaxLayer,
		// Token: 0x0400B4F3 RID: 46323
		[OriginalName("RogueRoomSubLevelNotFind2")]
		RogueRoomSubLevelNotFind2,
		// Token: 0x0400B4F4 RID: 46324
		[OriginalName("RoguePopularSlotArgConfigNotFind")]
		RoguePopularSlotArgConfigNotFind,
		// Token: 0x0400B4F5 RID: 46325
		[OriginalName("RogueInstSeasonNotMatch")]
		RogueInstSeasonNotMatch,
		// Token: 0x0400B4F6 RID: 46326
		[OriginalName("RogueSeasonTalentTreeNotFind")]
		RogueSeasonTalentTreeNotFind,
		// Token: 0x0400B4F7 RID: 46327
		[OriginalName("RogueGainOptionsNotFind")]
		RogueGainOptionsNotFind,
		// Token: 0x0400B4F8 RID: 46328
		[OriginalName("RogueGainIsSell")]
		RogueGainIsSell,
		// Token: 0x0400B4F9 RID: 46329
		[OriginalName("RogueMiracleCreationConfNotFind")]
		RogueMiracleCreationConfNotFind,
		// Token: 0x0400B4FA RID: 46330
		[OriginalName("RogueGainPackageError")]
		RogueGainPackageError,
		// Token: 0x0400B4FB RID: 46331
		[OriginalName("RogueTrialRoleIdsCountNotRight")]
		RogueTrialRoleIdsCountNotRight,
		// Token: 0x0400B4FC RID: 46332
		[OriginalName("RogueVarNotExist")]
		RogueVarNotExist,
		// Token: 0x0400B4FD RID: 46333
		[OriginalName("RougeWhiteCatConfigNotFind")]
		RougeWhiteCatConfigNotFind,
		// Token: 0x0400B4FE RID: 46334
		[OriginalName("RougeWhiteCatNotOpen")]
		RougeWhiteCatNotOpen,
		// Token: 0x0400B4FF RID: 46335
		[OriginalName("RougeWhiteCatLimitedTime")]
		RougeWhiteCatLimitedTime,
		// Token: 0x0400B500 RID: 46336
		[OriginalName("RougeWhiteCatRewardLock")]
		RougeWhiteCatRewardLock,
		// Token: 0x0400B501 RID: 46337
		[OriginalName("RougeWhiteCatRewardIsReceive")]
		RougeWhiteCatRewardIsReceive,
		// Token: 0x0400B502 RID: 46338
		[OriginalName("RougeWhiteCatRewardIndexErr")]
		RougeWhiteCatRewardIndexErr,
		// Token: 0x0400B503 RID: 46339
		[OriginalName("RougeWhiteCatInstIndexErr")]
		RougeWhiteCatInstIndexErr,
		// Token: 0x0400B504 RID: 46340
		[OriginalName("RougeWhiteCatInstLock")]
		RougeWhiteCatInstLock,
		// Token: 0x0400B505 RID: 46341
		[OriginalName("RougeWhiteCatBossRewardIndexErr")]
		RougeWhiteCatBossRewardIndexErr,
		// Token: 0x0400B506 RID: 46342
		[OriginalName("RougeWhiteCatBossRewardLock")]
		RougeWhiteCatBossRewardLock,
		// Token: 0x0400B507 RID: 46343
		[OriginalName("RougeWhiteCatBossRewardIsReceive")]
		RougeWhiteCatBossRewardIsReceive,
		// Token: 0x0400B508 RID: 46344
		[OriginalName("RougeWhiteCatLevelPlayIndexErr")]
		RougeWhiteCatLevelPlayIndexErr,
		// Token: 0x0400B509 RID: 46345
		[OriginalName("RougeWhiteCatLevelPlayLock")]
		RougeWhiteCatLevelPlayLock,
		// Token: 0x0400B50A RID: 46346
		[OriginalName("RougeWhiteCatLevelPlayIsReceive")]
		RougeWhiteCatLevelPlayIsReceive,
		// Token: 0x0400B50B RID: 46347
		[OriginalName("ResourceVersionTooLow")]
		ResourceVersionTooLow,
		// Token: 0x0400B50C RID: 46348
		[OriginalName("RogueLimitTimeRewardConfigNotFind")]
		RogueLimitTimeRewardConfigNotFind,
		// Token: 0x0400B50D RID: 46349
		[OriginalName("RogueWhiteCatLimitedTimeOut")]
		RogueWhiteCatLimitedTimeOut,
		// Token: 0x0400B50E RID: 46350
		[OriginalName("RougeWhiteCatLimitedRewardLock")]
		RougeWhiteCatLimitedRewardLock,
		// Token: 0x0400B50F RID: 46351
		[OriginalName("RougeWhiteCatLimitedRewardIsReceive")]
		RougeWhiteCatLimitedRewardIsReceive,
		// Token: 0x0400B510 RID: 46352
		[OriginalName("RougeWhiteCatBlackFlowerNoCount")]
		RougeWhiteCatBlackFlowerNoCount,
		// Token: 0x0400B511 RID: 46353
		[OriginalName("RogueInstCountNotRight")]
		RogueInstCountNotRight,
		// Token: 0x0400B512 RID: 46354
		[OriginalName("RogueInstFightFormationNotConfig")]
		RogueInstFightFormationNotConfig,
		// Token: 0x0400B513 RID: 46355
		[OriginalName("RogueTrialRoleNotValid")]
		RogueTrialRoleNotValid,
		// Token: 0x0400B514 RID: 46356
		[OriginalName("RogueRoleNotValid")]
		RogueRoleNotValid,
		// Token: 0x0400B515 RID: 46357
		[OriginalName("ErrorBlackFlowerEntityNotRight")]
		ErrorBlackFlowerEntityNotRight,
		// Token: 0x0400B516 RID: 46358
		[OriginalName("ErrorBlackFlowerStatus")]
		ErrorBlackFlowerStatus,
		// Token: 0x0400B517 RID: 46359
		[OriginalName("ErrorBlackFlowerCanNotReward")]
		ErrorBlackFlowerCanNotReward,
		// Token: 0x0400B518 RID: 46360
		[OriginalName("ErrorBlackFlowerRewardFail")]
		ErrorBlackFlowerRewardFail,
		// Token: 0x0400B519 RID: 46361
		[OriginalName("ErrorPhantomUnlockError")]
		ErrorPhantomUnlockError,
		// Token: 0x0400B51A RID: 46362
		[OriginalName("ErrorPhantomSwitchError")]
		ErrorPhantomSwitchError,
		// Token: 0x0400B51B RID: 46363
		[OriginalName("ActivityConfigNotFind")]
		ActivityConfigNotFind,
		// Token: 0x0400B51C RID: 46364
		[OriginalName("ActivityNotOpen")]
		ActivityNotOpen,
		// Token: 0x0400B51D RID: 46365
		[OriginalName("DirectTrainActivityConfigNotFind")]
		DirectTrainActivityConfigNotFind,
		// Token: 0x0400B51E RID: 46366
		[OriginalName("ActivityTypeNotFind")]
		ActivityTypeNotFind,
		// Token: 0x0400B51F RID: 46367
		[OriginalName("SetGlobalVarFail")]
		SetGlobalVarFail,
		// Token: 0x0400B520 RID: 46368
		[OriginalName("ErrMultigame")]
		ErrMultigame,
		// Token: 0x0400B521 RID: 46369
		[OriginalName("RogueWeeklyCycleNoFind")]
		RogueWeeklyCycleNoFind,
		// Token: 0x0400B522 RID: 46370
		[OriginalName("RogueWeeklyCycleIdNotMatch")]
		RogueWeeklyCycleIdNotMatch,
		// Token: 0x0400B523 RID: 46371
		[OriginalName("RogueWeeklyCycleInstIdNotMatch")]
		RogueWeeklyCycleInstIdNotMatch,
		// Token: 0x0400B524 RID: 46372
		[OriginalName("RogueWeeklyCycleSexNotMatch")]
		RogueWeeklyCycleSexNotMatch,
		// Token: 0x0400B525 RID: 46373
		[OriginalName("RogueWeeklyCycleActivityIdNotMatch")]
		RogueWeeklyCycleActivityIdNotMatch,
		// Token: 0x0400B526 RID: 46374
		[OriginalName("RogueWeeklyCycleAwardNotFind")]
		RogueWeeklyCycleAwardNotFind,
		// Token: 0x0400B527 RID: 46375
		[OriginalName("RogueWeeklyCycleAwardStateNotMatch")]
		RogueWeeklyCycleAwardStateNotMatch,
		// Token: 0x0400B528 RID: 46376
		[OriginalName("RogueWeeklyInstResultFail")]
		RogueWeeklyInstResultFail,
		// Token: 0x0400B529 RID: 46377
		[OriginalName("RogueWeeklyGoldNoEnough")]
		RogueWeeklyGoldNoEnough,
		// Token: 0x0400B52A RID: 46378
		[OriginalName("HasRogueProgressCanNotChangeSex")]
		HasRogueProgressCanNotChangeSex,
		// Token: 0x0400B52B RID: 46379
		[OriginalName("RogueWeeklyWorldLevelNotMatch")]
		RogueWeeklyWorldLevelNotMatch,
		// Token: 0x0400B52C RID: 46380
		[OriginalName("ResourceVersionIsTooLowWithTips")]
		ResourceVersionIsTooLowWithTips,
		// Token: 0x0400B52D RID: 46381
		[OriginalName("RogueResInstIdNotMatch")]
		RogueResInstIdNotMatch,
		// Token: 0x0400B52E RID: 46382
		[OriginalName("RogueResInstGridConfigNotFind")]
		RogueResInstGridConfigNotFind,
		// Token: 0x0400B52F RID: 46383
		[OriginalName("RogueResInBossInst")]
		RogueResInBossInst,
		// Token: 0x0400B530 RID: 46384
		[OriginalName("RogueResCurGridIsNull")]
		RogueResCurGridIsNull,
		// Token: 0x0400B531 RID: 46385
		[OriginalName("RogueResPathCountFail")]
		RogueResPathCountFail,
		// Token: 0x0400B532 RID: 46386
		[OriginalName("RogueResPathRepeat")]
		RogueResPathRepeat,
		// Token: 0x0400B533 RID: 46387
		[OriginalName("RogueResPathGridNoNear")]
		RogueResPathGridNoNear,
		// Token: 0x0400B534 RID: 46388
		[OriginalName("RogueResPathGridNoValid")]
		RogueResPathGridNoValid,
		// Token: 0x0400B535 RID: 46389
		[OriginalName("RogueResPathGridNoVision")]
		RogueResPathGridNoVision,
		// Token: 0x0400B536 RID: 46390
		[OriginalName("RogueResPathGridBlock")]
		RogueResPathGridBlock,
		// Token: 0x0400B537 RID: 46391
		[OriginalName("RogueResPlayerBanMove")]
		RogueResPlayerBanMove,
		// Token: 0x0400B538 RID: 46392
		[OriginalName("RogueResHasOp")]
		RogueResHasOp,
		// Token: 0x0400B539 RID: 46393
		[OriginalName("RogueResTrialRoleNotFind")]
		RogueResTrialRoleNotFind,
		// Token: 0x0400B53A RID: 46394
		[OriginalName("RogueResTrialRoleNoValid")]
		RogueResTrialRoleNoValid,
		// Token: 0x0400B53B RID: 46395
		[OriginalName("RogueResThemeConfNotFind")]
		RogueResThemeConfNotFind,
		// Token: 0x0400B53C RID: 46396
		[OriginalName("RogueResCrossInstDataIsNull")]
		RogueResCrossInstDataIsNull,
		// Token: 0x0400B53D RID: 46397
		[OriginalName("RogueResOpEmpty")]
		RogueResOpEmpty,
		// Token: 0x0400B53E RID: 46398
		[OriginalName("RogueResOpNotMatch")]
		RogueResOpNotMatch,
		// Token: 0x0400B53F RID: 46399
		[OriginalName("RogueResCollectionConfNotFind")]
		RogueResCollectionConfNotFind,
		// Token: 0x0400B540 RID: 46400
		[OriginalName("RogueResCollectionStateErr")]
		RogueResCollectionStateErr,
		// Token: 0x0400B541 RID: 46401
		[OriginalName("RogueResEndingAwardConfNotFind")]
		RogueResEndingAwardConfNotFind,
		// Token: 0x0400B542 RID: 46402
		[OriginalName("RogueResEndingAwardIsReceived")]
		RogueResEndingAwardIsReceived,
		// Token: 0x0400B543 RID: 46403
		[OriginalName("RogueResEndingAwardNotFinish")]
		RogueResEndingAwardNotFinish,
		// Token: 0x0400B544 RID: 46404
		[OriginalName("RogueResTalentConfNotFind")]
		RogueResTalentConfNotFind,
		// Token: 0x0400B545 RID: 46405
		[OriginalName("RogueResTaskConfNotFind")]
		RogueResTaskConfNotFind,
		// Token: 0x0400B546 RID: 46406
		[OriginalName("RogueResTaskDatanotFind")]
		RogueResTaskDatanotFind,
		// Token: 0x0400B547 RID: 46407
		[OriginalName("RogueResTaskAwardIsReceived")]
		RogueResTaskAwardIsReceived,
		// Token: 0x0400B548 RID: 46408
		[OriginalName("RogueResTaskAwardNotFinish")]
		RogueResTaskAwardNotFinish,
		// Token: 0x0400B549 RID: 46409
		[OriginalName("RogueResEffectConfNoFind")]
		RogueResEffectConfNoFind,
		// Token: 0x0400B54A RID: 46410
		[OriginalName("RogueResOptionNoRestCount")]
		RogueResOptionNoRestCount,
		// Token: 0x0400B54B RID: 46411
		[OriginalName("RogueResOptionCantMulti")]
		RogueResOptionCantMulti,
		// Token: 0x0400B54C RID: 46412
		[OriginalName("RogueResOptionRepeat")]
		RogueResOptionRepeat,
		// Token: 0x0400B54D RID: 46413
		[OriginalName("RogueResOptionCantGiveUp")]
		RogueResOptionCantGiveUp,
		// Token: 0x0400B54E RID: 46414
		[OriginalName("RogueResOptionCantRefresh")]
		RogueResOptionCantRefresh,
		// Token: 0x0400B54F RID: 46415
		[OriginalName("RogueResOptionIndexNoValid")]
		RogueResOptionIndexNoValid,
		// Token: 0x0400B550 RID: 46416
		[OriginalName("RogueResOptionTypeError")]
		RogueResOptionTypeError,
		// Token: 0x0400B551 RID: 46417
		[OriginalName("RogueResOptionIsSelect")]
		RogueResOptionIsSelect,
		// Token: 0x0400B552 RID: 46418
		[OriginalName("RogueResCollectionIndexMax")]
		RogueResCollectionIndexMax,
		// Token: 0x0400B553 RID: 46419
		[OriginalName("RogueResCollectionDropConfigNoFind")]
		RogueResCollectionDropConfigNoFind,
		// Token: 0x0400B554 RID: 46420
		[OriginalName("RogueResNoBaseGainLogic")]
		RogueResNoBaseGainLogic,
		// Token: 0x0400B555 RID: 46421
		[OriginalName("RogueResGridAwardNoConf")]
		RogueResGridAwardNoConf,
		// Token: 0x0400B556 RID: 46422
		[OriginalName("RogueResBornPositionNoConf")]
		RogueResBornPositionNoConf,
		// Token: 0x0400B557 RID: 46423
		[OriginalName("RogueResEffectExecFail")]
		RogueResEffectExecFail,
		// Token: 0x0400B558 RID: 46424
		[OriginalName("RogueResOptionFinish")]
		RogueResOptionFinish,
		// Token: 0x0400B559 RID: 46425
		[OriginalName("RogueResOpTypeErr")]
		RogueResOpTypeErr,
		// Token: 0x0400B55A RID: 46426
		[OriginalName("RogueResGridEventNoConf")]
		RogueResGridEventNoConf,
		// Token: 0x0400B55B RID: 46427
		[OriginalName("RogueResGridEventStepNoConf")]
		RogueResGridEventStepNoConf,
		// Token: 0x0400B55C RID: 46428
		[OriginalName("RogueResStepOptionNoValid")]
		RogueResStepOptionNoValid,
		// Token: 0x0400B55D RID: 46429
		[OriginalName("RogueResGridEventNoData")]
		RogueResGridEventNoData,
		// Token: 0x0400B55E RID: 46430
		[OriginalName("RogueResSelectIndexNoValid")]
		RogueResSelectIndexNoValid,
		// Token: 0x0400B55F RID: 46431
		[OriginalName("RogueResGotoNextRoomNoData")]
		RogueResGotoNextRoomNoData,
		// Token: 0x0400B560 RID: 46432
		[OriginalName("RogueResSelectOpNoData")]
		RogueResSelectOpNoData,
		// Token: 0x0400B561 RID: 46433
		[OriginalName("RogueResBranchTaskNoConf")]
		RogueResBranchTaskNoConf,
		// Token: 0x0400B562 RID: 46434
		[OriginalName("RogueResBranchTaskNoData")]
		RogueResBranchTaskNoData,
		// Token: 0x0400B563 RID: 46435
		[OriginalName("RogueResBranchTaskIsReceive")]
		RogueResBranchTaskIsReceive,
		// Token: 0x0400B564 RID: 46436
		[OriginalName("RogueResBranchTaskNoFinish")]
		RogueResBranchTaskNoFinish,
		// Token: 0x0400B565 RID: 46437
		[OriginalName("RogueResTokenShopPriceErr")]
		RogueResTokenShopPriceErr,
		// Token: 0x0400B566 RID: 46438
		[OriginalName("RogueResTaskTypeErr")]
		RogueResTaskTypeErr,
		// Token: 0x0400B567 RID: 46439
		[OriginalName("RogueRandomNoPoolName")]
		RogueRandomNoPoolName,
		// Token: 0x0400B568 RID: 46440
		[OriginalName("RogueRandomNoHit")]
		RogueRandomNoHit,
		// Token: 0x0400B569 RID: 46441
		[OriginalName("RogueRandomNoValidResult")]
		RogueRandomNoValidResult,
		// Token: 0x0400B56A RID: 46442
		[OriginalName("RogueResFormationIdNoValid")]
		RogueResFormationIdNoValid,
		// Token: 0x0400B56B RID: 46443
		[OriginalName("RogueResFormationRoleCountErr")]
		RogueResFormationRoleCountErr,
		// Token: 0x0400B56C RID: 46444
		[OriginalName("RogueResRandomNoShopGoods")]
		RogueResRandomNoShopGoods,
		// Token: 0x0400B56D RID: 46445
		[OriginalName("RogueResRandomShopGoodsNoEnough")]
		RogueResRandomShopGoodsNoEnough,
		// Token: 0x0400B56E RID: 46446
		[OriginalName("RogueResFormationRoleNoValid")]
		RogueResFormationRoleNoValid,
		// Token: 0x0400B56F RID: 46447
		[OriginalName("RogueResFormationNoData")]
		RogueResFormationNoData,
		// Token: 0x0400B570 RID: 46448
		[OriginalName("RogueResGainRoleNoFind")]
		RogueResGainRoleNoFind,
		// Token: 0x0400B571 RID: 46449
		[OriginalName("RogueResGainRoleLvNoConf")]
		RogueResGainRoleLvNoConf,
		// Token: 0x0400B572 RID: 46450
		[OriginalName("RogueResGainRoleLvNoLv")]
		RogueResGainRoleLvNoLv,
		// Token: 0x0400B573 RID: 46451
		[OriginalName("RogueResGainRoleNoBuffPool")]
		RogueResGainRoleNoBuffPool,
		// Token: 0x0400B574 RID: 46452
		[OriginalName("RogueResGainRoleNoMaxlv")]
		RogueResGainRoleNoMaxlv,
		// Token: 0x0400B575 RID: 46453
		[OriginalName("RogueResGainRoleRollEffectNoValid")]
		RogueResGainRoleRollEffectNoValid,
		// Token: 0x0400B576 RID: 46454
		[OriginalName("RogueResGainRoleRollRetNoMatch")]
		RogueResGainRoleRollRetNoMatch,
		// Token: 0x0400B577 RID: 46455
		[OriginalName("RogueResGainRoleShopNoConf")]
		RogueResGainRoleShopNoConf,
		// Token: 0x0400B578 RID: 46456
		[OriginalName("RogueResGainRoleRollEmpty")]
		RogueResGainRoleRollEmpty,
		// Token: 0x0400B579 RID: 46457
		[OriginalName("RogueResGainRoleBondNoValid")]
		RogueResGainRoleBondNoValid,
		// Token: 0x0400B57A RID: 46458
		[OriginalName("RogueResRoleBuffGuaranteeFail")]
		RogueResRoleBuffGuaranteeFail,
		// Token: 0x0400B57B RID: 46459
		[OriginalName("RogueResRoleBuffNoMore")]
		RogueResRoleBuffNoMore,
		// Token: 0x0400B57C RID: 46460
		[OriginalName("RogueResRoleBuffRandomFail")]
		RogueResRoleBuffRandomFail,
		// Token: 0x0400B57D RID: 46461
		[OriginalName("RogueRoleShopRollFail")]
		RogueRoleShopRollFail,
		// Token: 0x0400B57E RID: 46462
		[OriginalName("RogueResGridRangeTrigger")]
		RogueResGridRangeTrigger,
		// Token: 0x0400B57F RID: 46463
		[OriginalName("RogueResCurGridTrigger")]
		RogueResCurGridTrigger,
		// Token: 0x0400B580 RID: 46464
		[OriginalName("RogueResEventTypeErr")]
		RogueResEventTypeErr,
		// Token: 0x0400B581 RID: 46465
		[OriginalName("RogueResEventOpNoData")]
		RogueResEventOpNoData,
		// Token: 0x0400B582 RID: 46466
		[OriginalName("RogueResGridNoConf")]
		RogueResGridNoConf,
		// Token: 0x0400B583 RID: 46467
		[OriginalName("RogueResEffectExceFail")]
		RogueResEffectExceFail,
		// Token: 0x0400B584 RID: 46468
		[OriginalName("RogueResNoInBattle")]
		RogueResNoInBattle,
		// Token: 0x0400B585 RID: 46469
		[OriginalName("RogueResStepCondLock")]
		RogueResStepCondLock,
		// Token: 0x0400B586 RID: 46470
		[OriginalName("RogueResGridEventOpNotFind")]
		RogueResGridEventOpNotFind,
		// Token: 0x0400B587 RID: 46471
		[OriginalName("RogueNoLastInstData")]
		RogueNoLastInstData,
		// Token: 0x0400B588 RID: 46472
		[OriginalName("RogueNoRollBuffBondLinkOp")]
		RogueNoRollBuffBondLinkOp,
		// Token: 0x0400B589 RID: 46473
		[OriginalName("RogueTokenCantRepeat")]
		RogueTokenCantRepeat,
		// Token: 0x0400B58A RID: 46474
		[OriginalName("RogueFailCountMax")]
		RogueFailCountMax,
		// Token: 0x0400B58B RID: 46475
		[OriginalName("RogueResRoleMaxLv")]
		RogueResRoleMaxLv,
		// Token: 0x0400B58C RID: 46476
		[OriginalName("RogueResPerInstNoPass")]
		RogueResPerInstNoPass,
		// Token: 0x0400B58D RID: 46477
		[OriginalName("RogueResCreateInstCacheErr")]
		RogueResCreateInstCacheErr,
		// Token: 0x0400B58E RID: 46478
		[OriginalName("LordGymRepeatChallenge")]
		LordGymRepeatChallenge,
		// Token: 0x0400B58F RID: 46479
		[OriginalName("NewbieCarnivalNoLicense")]
		NewbieCarnivalNoLicense,
		// Token: 0x0400B590 RID: 46480
		[OriginalName("NewbieCarnivalParamNoConf")]
		NewbieCarnivalParamNoConf,
		// Token: 0x0400B591 RID: 46481
		[OriginalName("NewbieCarnivalNoRoleId")]
		NewbieCarnivalNoRoleId,
		// Token: 0x0400B592 RID: 46482
		[OriginalName("NewbieCarnivalNoData")]
		NewbieCarnivalNoData,
		// Token: 0x0400B593 RID: 46483
		[OriginalName("NewbieCarnivalTaskNoConf")]
		NewbieCarnivalTaskNoConf,
		// Token: 0x0400B594 RID: 46484
		[OriginalName("NewbieCarnivalTaskTaken")]
		NewbieCarnivalTaskTaken,
		// Token: 0x0400B595 RID: 46485
		[OriginalName("NewbieCarnivalTaskRunning")]
		NewbieCarnivalTaskRunning,
		// Token: 0x0400B596 RID: 46486
		[OriginalName("ErrShopFixeNotExist")]
		ErrShopFixeNotExist,
		// Token: 0x0400B597 RID: 46487
		[OriginalName("ErrShopBankNoExist")]
		ErrShopBankNoExist,
		// Token: 0x0400B598 RID: 46488
		[OriginalName("ErrShopBankNoMatch")]
		ErrShopBankNoMatch,
		// Token: 0x0400B599 RID: 46489
		[OriginalName("ErrPayShopBuyCountOverFlow")]
		ErrPayShopBuyCountOverFlow,
		// Token: 0x0400B59A RID: 46490
		[OriginalName("ErrShopBuyCountOverFlow")]
		ErrShopBuyCountOverFlow,
		// Token: 0x0400B59B RID: 46491
		[OriginalName("EnergyOverFlow")]
		EnergyOverFlow,
		// Token: 0x0400B59C RID: 46492
		[OriginalName("EnergyNotEnough")]
		EnergyNotEnough,
		// Token: 0x0400B59D RID: 46493
		[OriginalName("StoreEnergyNotEnough")]
		StoreEnergyNotEnough,
		// Token: 0x0400B59E RID: 46494
		[OriginalName("ErrPayShopBuyLimitCondition")]
		ErrPayShopBuyLimitCondition,
		// Token: 0x0400B59F RID: 46495
		[OriginalName("ErrPayShopEchoItemOver2")]
		ErrPayShopEchoItemOver2,
		// Token: 0x0400B5A0 RID: 46496
		[OriginalName("ErrPayShopEchoItemOver3")]
		ErrPayShopEchoItemOver3,
		// Token: 0x0400B5A1 RID: 46497
		[OriginalName("ErrPayShopEchoItemOver4")]
		ErrPayShopEchoItemOver4,
		// Token: 0x0400B5A2 RID: 46498
		[OriginalName("CreateReceiptCoreParamError")]
		CreateReceiptCoreParamError,
		// Token: 0x0400B5A3 RID: 46499
		[OriginalName("ReceiptsDealCloseCoreParamError")]
		ReceiptsDealCloseCoreParamError,
		// Token: 0x0400B5A4 RID: 46500
		[OriginalName("ReceiptsRefundCloseCoreParamError")]
		ReceiptsRefundCloseCoreParamError,
		// Token: 0x0400B5A5 RID: 46501
		[OriginalName("CreateReceiptCoreException")]
		CreateReceiptCoreException,
		// Token: 0x0400B5A6 RID: 46502
		[OriginalName("ReceiptsDealCloseCoreException")]
		ReceiptsDealCloseCoreException,
		// Token: 0x0400B5A7 RID: 46503
		[OriginalName("ReceiptsRefundCloseCoreFail")]
		ReceiptsRefundCloseCoreFail,
		// Token: 0x0400B5A8 RID: 46504
		[OriginalName("ReceiptsRefundCloseCoreException")]
		ReceiptsRefundCloseCoreException,
		// Token: 0x0400B5A9 RID: 46505
		[OriginalName("ErrPayConfigClientCantBuy")]
		ErrPayConfigClientCantBuy,
		// Token: 0x0400B5AA RID: 46506
		[OriginalName("RecyclePersonalGiftNoData")]
		RecyclePersonalGiftNoData,
		// Token: 0x0400B5AB RID: 46507
		[OriginalName("ErrPersonalGiftBuyLimit")]
		ErrPersonalGiftBuyLimit,
		// Token: 0x0400B5AC RID: 46508
		[OriginalName("CreateReceiptNoConf")]
		CreateReceiptNoConf,
		// Token: 0x0400B5AD RID: 46509
		[OriginalName("CreateReceiptFail")]
		CreateReceiptFail,
		// Token: 0x0400B5AE RID: 46510
		[OriginalName("ReceiptDealCloseNoData")]
		ReceiptDealCloseNoData,
		// Token: 0x0400B5AF RID: 46511
		[OriginalName("ReceiptDealClosePlayerIdUnMatch")]
		ReceiptDealClosePlayerIdUnMatch,
		// Token: 0x0400B5B0 RID: 46512
		[OriginalName("ReceiptCannotDealClose")]
		ReceiptCannotDealClose,
		// Token: 0x0400B5B1 RID: 46513
		[OriginalName("ReceiptDealCloseFail")]
		ReceiptDealCloseFail,
		// Token: 0x0400B5B2 RID: 46514
		[OriginalName("ReceiptRefundCloseNoData")]
		ReceiptRefundCloseNoData,
		// Token: 0x0400B5B3 RID: 46515
		[OriginalName("ReceiptRefundClosePlayerIdUnMatch")]
		ReceiptRefundClosePlayerIdUnMatch,
		// Token: 0x0400B5B4 RID: 46516
		[OriginalName("ReceiptCannotRefundClose")]
		ReceiptCannotRefundClose,
		// Token: 0x0400B5B5 RID: 46517
		[OriginalName("ReceiptRefundCloseFail")]
		ReceiptRefundCloseFail,
		// Token: 0x0400B5B6 RID: 46518
		[OriginalName("ReceiptRefundNoData")]
		ReceiptRefundNoData,
		// Token: 0x0400B5B7 RID: 46519
		[OriginalName("CreateReceiptParamError")]
		CreateReceiptParamError,
		// Token: 0x0400B5B8 RID: 46520
		[OriginalName("CreateReceiptException")]
		CreateReceiptException,
		// Token: 0x0400B5B9 RID: 46521
		[OriginalName("ReceiptsDealCloseParamError")]
		ReceiptsDealCloseParamError,
		// Token: 0x0400B5BA RID: 46522
		[OriginalName("ReceiptsDealCloseException")]
		ReceiptsDealCloseException,
		// Token: 0x0400B5BB RID: 46523
		[OriginalName("ReceiptRefundCloseParamError")]
		ReceiptRefundCloseParamError,
		// Token: 0x0400B5BC RID: 46524
		[OriginalName("ReceiptRefundCloseException")]
		ReceiptRefundCloseException,
		// Token: 0x0400B5BD RID: 46525
		[OriginalName("ReceiptRefundParamError")]
		ReceiptRefundParamError,
		// Token: 0x0400B5BE RID: 46526
		[OriginalName("UpdateRogueWeeklyArtifactsFail")]
		UpdateRogueWeeklyArtifactsFail,
		// Token: 0x0400B5BF RID: 46527
		[OriginalName("RogueWeeklyArtifactsEmpty")]
		RogueWeeklyArtifactsEmpty,
		// Token: 0x0400B5C0 RID: 46528
		[OriginalName("RogueWeeklyArtifactsIndexErr")]
		RogueWeeklyArtifactsIndexErr,
		// Token: 0x0400B5C1 RID: 46529
		[OriginalName("RogueResSkipBattleLvNoEnough")]
		RogueResSkipBattleLvNoEnough,
		// Token: 0x0400B5C2 RID: 46530
		[OriginalName("RogueResCanNotSkipBattle")]
		RogueResCanNotSkipBattle,
		// Token: 0x0400B5C3 RID: 46531
		[OriginalName("RogueResRandomGridNoConf")]
		RogueResRandomGridNoConf,
		// Token: 0x0400B5C4 RID: 46532
		[OriginalName("StrangerHostCount")]
		StrangerHostCount,
		// Token: 0x0400B5C5 RID: 46533
		[OriginalName("SurvivorsNotInitOp")]
		SurvivorsNotInitOp,
		// Token: 0x0400B5C6 RID: 46534
		[OriginalName("SurvivorsNotSelectOp")]
		SurvivorsNotSelectOp,
		// Token: 0x0400B5C7 RID: 46535
		[OriginalName("SurvivorsNoRoleAndWeapon")]
		SurvivorsNoRoleAndWeapon,
		// Token: 0x0400B5C8 RID: 46536
		[OriginalName("SurvivorsRandomEmpty")]
		SurvivorsRandomEmpty,
		// Token: 0x0400B5C9 RID: 46537
		[OriginalName("SurvivorsOptionEmpty")]
		SurvivorsOptionEmpty,
		// Token: 0x0400B5CA RID: 46538
		[OriginalName("SurvivorsSelectEmpty")]
		SurvivorsSelectEmpty,
		// Token: 0x0400B5CB RID: 46539
		[OriginalName("SurvivorsRandomGuaranteedEmpty")]
		SurvivorsRandomGuaranteedEmpty,
		// Token: 0x0400B5CC RID: 46540
		[OriginalName("SurvivorsLevelNoConf")]
		SurvivorsLevelNoConf,
		// Token: 0x0400B5CD RID: 46541
		[OriginalName("SurvivorsWeaponPoolEmpty")]
		SurvivorsWeaponPoolEmpty,
		// Token: 0x0400B5CE RID: 46542
		[OriginalName("SurvivorsWeaponEmpty")]
		SurvivorsWeaponEmpty,
		// Token: 0x0400B5CF RID: 46543
		[OriginalName("SurvivorsGoldNoEnough")]
		SurvivorsGoldNoEnough,
		// Token: 0x0400B5D0 RID: 46544
		[OriginalName("SurvivorsWeaponMax")]
		SurvivorsWeaponMax,
		// Token: 0x0400B5D1 RID: 46545
		[OriginalName("SurvivorsNoSupportGiveUp")]
		SurvivorsNoSupportGiveUp,
		// Token: 0x0400B5D2 RID: 46546
		[OriginalName("SurvivorsNoRestSelectCount")]
		SurvivorsNoRestSelectCount,
		// Token: 0x0400B5D3 RID: 46547
		[OriginalName("SurvivorsNoSupportMultiSelect")]
		SurvivorsNoSupportMultiSelect,
		// Token: 0x0400B5D4 RID: 46548
		[OriginalName("SurvivorsRepeatSelect")]
		SurvivorsRepeatSelect,
		// Token: 0x0400B5D5 RID: 46549
		[OriginalName("SurvivorsComponentNoFind")]
		SurvivorsComponentNoFind,
		// Token: 0x0400B5D6 RID: 46550
		[OriginalName("SurvivorsOpNotFind")]
		SurvivorsOpNotFind,
		// Token: 0x0400B5D7 RID: 46551
		[OriginalName("SurvivorsSelectErr")]
		SurvivorsSelectErr,
		// Token: 0x0400B5D8 RID: 46552
		[OriginalName("SurvivorsNoVar")]
		SurvivorsNoVar,
		// Token: 0x0400B5D9 RID: 46553
		[OriginalName("SurvivorsInstIdErr")]
		SurvivorsInstIdErr,
		// Token: 0x0400B5DA RID: 46554
		[OriginalName("SurvivorsInstLock")]
		SurvivorsInstLock,
		// Token: 0x0400B5DB RID: 46555
		[OriginalName("SurvivorsInstNotTime")]
		SurvivorsInstNotTime,
		// Token: 0x0400B5DC RID: 46556
		[OriginalName("SurvivorsInstNoEndlessMode")]
		SurvivorsInstNoEndlessMode,
		// Token: 0x0400B5DD RID: 46557
		[OriginalName("SurvivorsNeedContinue")]
		SurvivorsNeedContinue,
		// Token: 0x0400B5DE RID: 46558
		[OriginalName("SurvivorsLevelCantUseRole")]
		SurvivorsLevelCantUseRole,
		// Token: 0x0400B5DF RID: 46559
		[OriginalName("SurvivorsLevelCantUseWeapon")]
		SurvivorsLevelCantUseWeapon,
		// Token: 0x0400B5E0 RID: 46560
		[OriginalName("SurvivorsRoleNoMatch")]
		SurvivorsRoleNoMatch,
		// Token: 0x0400B5E1 RID: 46561
		[OriginalName("SurvivorsStepErr1")]
		SurvivorsStepErr1,
		// Token: 0x0400B5E2 RID: 46562
		[OriginalName("SurvivorsStepErr2")]
		SurvivorsStepErr2,
		// Token: 0x0400B5E3 RID: 46563
		[OriginalName("SurvivorsStepErr3")]
		SurvivorsStepErr3,
		// Token: 0x0400B5E4 RID: 46564
		[OriginalName("SurvivorsCantBuy")]
		SurvivorsCantBuy,
		// Token: 0x0400B5E5 RID: 46565
		[OriginalName("SurvivorsRoleLvNoConf")]
		SurvivorsRoleLvNoConf,
		// Token: 0x0400B5E6 RID: 46566
		[OriginalName("SurvivorsWeaponLvNoConf")]
		SurvivorsWeaponLvNoConf,
		// Token: 0x0400B5E7 RID: 46567
		[OriginalName("SurvivorsRoleNoFind")]
		SurvivorsRoleNoFind,
		// Token: 0x0400B5E8 RID: 46568
		[OriginalName("SurvivorsWaponNoFind")]
		SurvivorsWaponNoFind,
		// Token: 0x0400B5E9 RID: 46569
		[OriginalName("SurvivorsItemNoFind")]
		SurvivorsItemNoFind,
		// Token: 0x0400B5EA RID: 46570
		[OriginalName("SurvivorsRoleLvMax")]
		SurvivorsRoleLvMax,
		// Token: 0x0400B5EB RID: 46571
		[OriginalName("SurvivorsWeaponLvMax")]
		SurvivorsWeaponLvMax,
		// Token: 0x0400B5EC RID: 46572
		[OriginalName("SurvivorsRefreshOpFail")]
		SurvivorsRefreshOpFail,
		// Token: 0x0400B5ED RID: 46573
		[OriginalName("SurvivorsWeightEmpty")]
		SurvivorsWeightEmpty,
		// Token: 0x0400B5EE RID: 46574
		[OriginalName("SurvivorsActivityNoData")]
		SurvivorsActivityNoData,
		// Token: 0x0400B5EF RID: 46575
		[OriginalName("SurvivorsRefreshCostFail")]
		SurvivorsRefreshCostFail,
		// Token: 0x0400B5F0 RID: 46576
		[OriginalName("SurvivorsNoLastInstData")]
		SurvivorsNoLastInstData,
		// Token: 0x0400B5F1 RID: 46577
		[OriginalName("SurvivorsActivityNoConf")]
		SurvivorsActivityNoConf,
		// Token: 0x0400B5F2 RID: 46578
		[OriginalName("SurvivorsTalentNoConf")]
		SurvivorsTalentNoConf,
		// Token: 0x0400B5F3 RID: 46579
		[OriginalName("SurvivorsTaskCountMax")]
		SurvivorsTaskCountMax,
		// Token: 0x0400B5F4 RID: 46580
		[OriginalName("SurvivorsTaskNoConf")]
		SurvivorsTaskNoConf,
		// Token: 0x0400B5F5 RID: 46581
		[OriginalName("SurvivorsTaskCantReward")]
		SurvivorsTaskCantReward,
		// Token: 0x0400B5F6 RID: 46582
		[OriginalName("SurvivorsTaskRepeat")]
		SurvivorsTaskRepeat,
		// Token: 0x0400B5F7 RID: 46583
		[OriginalName("SurvivorsTaskEmpty")]
		SurvivorsTaskEmpty,
		// Token: 0x0400B5F8 RID: 46584
		[OriginalName("SurvivorsAllLock")]
		SurvivorsAllLock,
		// Token: 0x0400B5F9 RID: 46585
		[OriginalName("RogueResNoGlobalConf")]
		RogueResNoGlobalConf,
		// Token: 0x0400B5FA RID: 46586
		[OriginalName("SurvivorsNeedPassNormalMode")]
		SurvivorsNeedPassNormalMode = 1100506,
		// Token: 0x0400B5FB RID: 46587
		[OriginalName("SurvivorsOptionIsSelect")]
		SurvivorsOptionIsSelect,
		// Token: 0x0400B5FC RID: 46588
		[OriginalName("SurvivorsTalentTreeConditionNotMet")]
		SurvivorsTalentTreeConditionNotMet,
		// Token: 0x0400B5FD RID: 46589
		[OriginalName("SurvivorsTalentTreePerNodeLock")]
		SurvivorsTalentTreePerNodeLock,
		// Token: 0x0400B5FE RID: 46590
		[OriginalName("SurvivorsTalentTreeNodeMaxLevel")]
		SurvivorsTalentTreeNodeMaxLevel,
		// Token: 0x0400B5FF RID: 46591
		[OriginalName("SurvivorsTalentTreeConsumeNoEnough")]
		SurvivorsTalentTreeConsumeNoEnough,
		// Token: 0x0400B600 RID: 46592
		[OriginalName("ShortMessageNoConf")]
		ShortMessageNoConf,
		// Token: 0x0400B601 RID: 46593
		[OriginalName("ShortMessageOptionNoConf")]
		ShortMessageOptionNoConf,
		// Token: 0x0400B602 RID: 46594
		[OriginalName("ShortMessageNoData")]
		ShortMessageNoData,
		// Token: 0x0400B603 RID: 46595
		[OriginalName("ShortMessageNoData2")]
		ShortMessageNoData2,
		// Token: 0x0400B604 RID: 46596
		[OriginalName("ShortMessageIsRead")]
		ShortMessageIsRead,
		// Token: 0x0400B605 RID: 46597
		[OriginalName("ShortMessageNoMatch")]
		ShortMessageNoMatch,
		// Token: 0x0400B606 RID: 46598
		[OriginalName("ShortMessageNoReply")]
		ShortMessageNoReply,
		// Token: 0x0400B607 RID: 46599
		[OriginalName("ShortMessageIsReply")]
		ShortMessageIsReply,
		// Token: 0x0400B608 RID: 46600
		[OriginalName("ShortMessageNoReward")]
		ShortMessageNoReward,
		// Token: 0x0400B609 RID: 46601
		[OriginalName("ShortMessageIsReward")]
		ShortMessageIsReward,
		// Token: 0x0400B60A RID: 46602
		[OriginalName("ShortMessageNoFinish")]
		ShortMessageNoFinish,
		// Token: 0x0400B60B RID: 46603
		[OriginalName("ErrorPhantomCollectMax")]
		ErrorPhantomCollectMax,
		// Token: 0x0400B60C RID: 46604
		[OriginalName("ErrorPhantomCollectRepeated")]
		ErrorPhantomCollectRepeated,
		// Token: 0x0400B60D RID: 46605
		[OriginalName("ErrorPhantomCollectLock")]
		ErrorPhantomCollectLock,
		// Token: 0x0400B60E RID: 46606
		[OriginalName("ErrorNoSceneComp")]
		ErrorNoSceneComp,
		// Token: 0x0400B60F RID: 46607
		[OriginalName("ErrorNewTowerIsInChallenge")]
		ErrorNewTowerIsInChallenge,
		// Token: 0x0400B610 RID: 46608
		[OriginalName("ErrorNewTowerIsNoChallenge")]
		ErrorNewTowerIsNoChallenge,
		// Token: 0x0400B611 RID: 46609
		[OriginalName("ErrorNewTowerLevelIdNotMatch")]
		ErrorNewTowerLevelIdNotMatch,
		// Token: 0x0400B612 RID: 46610
		[OriginalName("ErrorNewTowerLevelNoConf")]
		ErrorNewTowerLevelNoConf,
		// Token: 0x0400B613 RID: 46611
		[OriginalName("ErrorNewTowerCycleNoConf")]
		ErrorNewTowerCycleNoConf,
		// Token: 0x0400B614 RID: 46612
		[OriginalName("ErrorNewTowerLevelNoData")]
		ErrorNewTowerLevelNoData,
		// Token: 0x0400B615 RID: 46613
		[OriginalName("ErrorNewTowerNoTeamCache")]
		ErrorNewTowerNoTeamCache,
		// Token: 0x0400B616 RID: 46614
		[OriginalName("ErrorNewTowerNoIndexTeamCache")]
		ErrorNewTowerNoIndexTeamCache,
		// Token: 0x0400B617 RID: 46615
		[OriginalName("ErrorNewTowerScoreRewardMax")]
		ErrorNewTowerScoreRewardMax,
		// Token: 0x0400B618 RID: 46616
		[OriginalName("ErrorNewTowerScoreNoConf")]
		ErrorNewTowerScoreNoConf,
		// Token: 0x0400B619 RID: 46617
		[OriginalName("ErrorNewTowerScoreRepeat")]
		ErrorNewTowerScoreRepeat,
		// Token: 0x0400B61A RID: 46618
		[OriginalName("ErrorNewTowerScoreEmpty")]
		ErrorNewTowerScoreEmpty,
		// Token: 0x0400B61B RID: 46619
		[OriginalName("ErrorNewTowerCycleNoInTime")]
		ErrorNewTowerCycleNoInTime,
		// Token: 0x0400B61C RID: 46620
		[OriginalName("ErrorNewTowerCurCycleNoConf")]
		ErrorNewTowerCurCycleNoConf,
		// Token: 0x0400B61D RID: 46621
		[OriginalName("ErrorNewTowerCycleNoLevel")]
		ErrorNewTowerCycleNoLevel,
		// Token: 0x0400B61E RID: 46622
		[OriginalName("ErrorNewTowerTeamIndexErr")]
		ErrorNewTowerTeamIndexErr,
		// Token: 0x0400B61F RID: 46623
		[OriginalName("ErrorNewTowerTeamMax")]
		ErrorNewTowerTeamMax,
		// Token: 0x0400B620 RID: 46624
		[OriginalName("ErrorNewTowerBuffMax")]
		ErrorNewTowerBuffMax,
		// Token: 0x0400B621 RID: 46625
		[OriginalName("ErrorNewTowerBuffRepeat")]
		ErrorNewTowerBuffRepeat,
		// Token: 0x0400B622 RID: 46626
		[OriginalName("ErrorNewTowerRoleRepeat")]
		ErrorNewTowerRoleRepeat,
		// Token: 0x0400B623 RID: 46627
		[OriginalName("ErrorNewTowerRoleEmpty")]
		ErrorNewTowerRoleEmpty,
		// Token: 0x0400B624 RID: 46628
		[OriginalName("ErrorNewTowerRoleNoMatch")]
		ErrorNewTowerRoleNoMatch,
		// Token: 0x0400B625 RID: 46629
		[OriginalName("ErrorNewTowerRoleMax")]
		ErrorNewTowerRoleMax,
		// Token: 0x0400B626 RID: 46630
		[OriginalName("ErrorNewTowerBuffNoMatch")]
		ErrorNewTowerBuffNoMatch,
		// Token: 0x0400B627 RID: 46631
		[OriginalName("ErrorNewTowerRoleNoEnergy")]
		ErrorNewTowerRoleNoEnergy,
		// Token: 0x0400B628 RID: 46632
		[OriginalName("ErrorNewTowerWaveNoInfo")]
		ErrorNewTowerWaveNoInfo,
		// Token: 0x0400B629 RID: 46633
		[OriginalName("ErrorNewTowerWaveFinish")]
		ErrorNewTowerWaveFinish,
		// Token: 0x0400B62A RID: 46634
		[OriginalName("ErrorShortMessageNoOpen")]
		ErrorShortMessageNoOpen,
		// Token: 0x0400B62B RID: 46635
		[OriginalName("ErrorShortMessageOptionMax")]
		ErrorShortMessageOptionMax,
		// Token: 0x0400B62C RID: 46636
		[OriginalName("ErrorShortMessageBubbleNoData")]
		ErrorShortMessageBubbleNoData,
		// Token: 0x0400B62D RID: 46637
		[OriginalName("ErrorShortMessageBubbleNoConf")]
		ErrorShortMessageBubbleNoConf,
		// Token: 0x0400B62E RID: 46638
		[OriginalName("ErrorShortMessageChatBgNoData")]
		ErrorShortMessageChatBgNoData,
		// Token: 0x0400B62F RID: 46639
		[OriginalName("ErrorShortMessageChatBgNoConf")]
		ErrorShortMessageChatBgNoConf,
		// Token: 0x0400B630 RID: 46640
		[OriginalName("ErrorNewTowerInstStateErr")]
		ErrorNewTowerInstStateErr,
		// Token: 0x0400B631 RID: 46641
		[OriginalName("ErrorNewTowerRoleWeaponPhantom")]
		ErrorNewTowerRoleWeaponPhantom,
		// Token: 0x0400B632 RID: 46642
		[OriginalName("ErrorNewTowerNoTeamData")]
		ErrorNewTowerNoTeamData,
		// Token: 0x0400B633 RID: 46643
		[OriginalName("ErrorNewTowerNoCacheSet")]
		ErrorNewTowerNoCacheSet,
		// Token: 0x0400B634 RID: 46644
		[OriginalName("ErrorNewTowerRoleWeaponNoMatch")]
		ErrorNewTowerRoleWeaponNoMatch,
		// Token: 0x0400B635 RID: 46645
		[OriginalName("ErrorNewTowerRolePhantomNoMatch")]
		ErrorNewTowerRolePhantomNoMatch,
		// Token: 0x0400B636 RID: 46646
		[OriginalName("ShortMessageOptionNoConf2")]
		ShortMessageOptionNoConf2,
		// Token: 0x0400B637 RID: 46647
		[OriginalName("ShortMessageOptionNoConf3")]
		ShortMessageOptionNoConf3,
		// Token: 0x0400B638 RID: 46648
		[OriginalName("ErrorNewTowerEntityNoFind")]
		ErrorNewTowerEntityNoFind,
		// Token: 0x0400B639 RID: 46649
		[OriginalName("ErrorNewTowerSeasonAwardNoConf")]
		ErrorNewTowerSeasonAwardNoConf,
		// Token: 0x0400B63A RID: 46650
		[OriginalName("ErrorNewTowerSeasonNoConf")]
		ErrorNewTowerSeasonNoConf,
		// Token: 0x0400B63B RID: 46651
		[OriginalName("ErrorNewTowerSeasonNotOpen")]
		ErrorNewTowerSeasonNotOpen,
		// Token: 0x0400B63C RID: 46652
		[OriginalName("ErrorNewTowerSeasonAwardRepeat")]
		ErrorNewTowerSeasonAwardRepeat,
		// Token: 0x0400B63D RID: 46653
		[OriginalName("ErrorNewTowerSeasonAwardEmpty")]
		ErrorNewTowerSeasonAwardEmpty,
		// Token: 0x0400B63E RID: 46654
		[OriginalName("NewTowerNoLastCycleIdReview")]
		NewTowerNoLastCycleIdReview,
		// Token: 0x0400B63F RID: 46655
		[OriginalName("NewTowerNoActivityData")]
		NewTowerNoActivityData,
		// Token: 0x0400B640 RID: 46656
		[OriginalName("NewTowerNoHistoryData")]
		NewTowerNoHistoryData,
		// Token: 0x0400B641 RID: 46657
		[OriginalName("ErrorNewTowerSeasonAwardTimeout")]
		ErrorNewTowerSeasonAwardTimeout,
		// Token: 0x0400B642 RID: 46658
		[OriginalName("RogueInstConfNoFind")]
		RogueInstConfNoFind,
		// Token: 0x0400B643 RID: 46659
		[OriginalName("RoguePhantomLock")]
		RoguePhantomLock,
		// Token: 0x0400B644 RID: 46660
		[OriginalName("RogueRoleLock")]
		RogueRoleLock,
		// Token: 0x0400B645 RID: 46661
		[OriginalName("RogueHotEntryLock")]
		RogueHotEntryLock,
		// Token: 0x0400B646 RID: 46662
		[OriginalName("KurotatoNoActivityData")]
		KurotatoNoActivityData,
		// Token: 0x0400B647 RID: 46663
		[OriginalName("KurotatoNoActivityConf")]
		KurotatoNoActivityConf,
		// Token: 0x0400B648 RID: 46664
		[OriginalName("KurotatoTaskLenghMax")]
		KurotatoTaskLenghMax,
		// Token: 0x0400B649 RID: 46665
		[OriginalName("KurotatoTaskNoConf")]
		KurotatoTaskNoConf,
		// Token: 0x0400B64A RID: 46666
		[OriginalName("KurotatoTaskNoFinish")]
		KurotatoTaskNoFinish,
		// Token: 0x0400B64B RID: 46667
		[OriginalName("KurotatoTaskIsAward")]
		KurotatoTaskIsAward,
		// Token: 0x0400B64C RID: 46668
		[OriginalName("KurotatoTaskRepeat")]
		KurotatoTaskRepeat,
		// Token: 0x0400B64D RID: 46669
		[OriginalName("KurotatoTaskZero")]
		KurotatoTaskZero,
		// Token: 0x0400B64E RID: 46670
		[OriginalName("KurotatoCanNotSaveRole")]
		KurotatoCanNotSaveRole,
		// Token: 0x0400B64F RID: 46671
		[OriginalName("KurotatoIsSaveRole")]
		KurotatoIsSaveRole,
		// Token: 0x0400B650 RID: 46672
		[OriginalName("KurotatoIsInInst")]
		KurotatoIsInInst,
		// Token: 0x0400B651 RID: 46673
		[OriginalName("KurotatoNoLevelData")]
		KurotatoNoLevelData,
		// Token: 0x0400B652 RID: 46674
		[OriginalName("KurotatoNoRoleData")]
		KurotatoNoRoleData,
		// Token: 0x0400B653 RID: 46675
		[OriginalName("KurotatoNoRecord")]
		KurotatoNoRecord,
		// Token: 0x0400B654 RID: 46676
		[OriginalName("KurotatoHasRecord")]
		KurotatoHasRecord,
		// Token: 0x0400B655 RID: 46677
		[OriginalName("KurotatoRoleNoRecord")]
		KurotatoRoleNoRecord,
		// Token: 0x0400B656 RID: 46678
		[OriginalName("KurotatoRecordLevelNotMatch")]
		KurotatoRecordLevelNotMatch,
		// Token: 0x0400B657 RID: 46679
		[OriginalName("KurotatoRoleNotMatch")]
		KurotatoRoleNotMatch,
		// Token: 0x0400B658 RID: 46680
		[OriginalName("HasRoguelikeProgressCanNotChangeSex")]
		HasRoguelikeProgressCanNotChangeSex,
		// Token: 0x0400B659 RID: 46681
		[OriginalName("WeeklyFrameNoData")]
		WeeklyFrameNoData,
		// Token: 0x0400B65A RID: 46682
		[OriginalName("WeeklyFrameScoreAwardMax")]
		WeeklyFrameScoreAwardMax,
		// Token: 0x0400B65B RID: 46683
		[OriginalName("WeeklyFrameNotInTime")]
		WeeklyFrameNotInTime,
		// Token: 0x0400B65C RID: 46684
		[OriginalName("WeeklyFrameNoConf")]
		WeeklyFrameNoConf,
		// Token: 0x0400B65D RID: 46685
		[OriginalName("WeeklyFrameScoreAwardNoConf")]
		WeeklyFrameScoreAwardNoConf,
		// Token: 0x0400B65E RID: 46686
		[OriginalName("WeeklyFrameScoreAwardGroupNotMatch")]
		WeeklyFrameScoreAwardGroupNotMatch,
		// Token: 0x0400B65F RID: 46687
		[OriginalName("WeeklyFrameScoreAwardNotFinish")]
		WeeklyFrameScoreAwardNotFinish,
		// Token: 0x0400B660 RID: 46688
		[OriginalName("WeeklyFrameScoreAwardTaken")]
		WeeklyFrameScoreAwardTaken,
		// Token: 0x0400B661 RID: 46689
		[OriginalName("WeeklyFrameScoreAwardRepeat")]
		WeeklyFrameScoreAwardRepeat,
		// Token: 0x0400B662 RID: 46690
		[OriginalName("WeeklyFrameScoreAwardZero")]
		WeeklyFrameScoreAwardZero,
		// Token: 0x0400B663 RID: 46691
		[OriginalName("KurotatoItemLock")]
		KurotatoItemLock,
		// Token: 0x0400B664 RID: 46692
		[OriginalName("KurotatoWeaponLock")]
		KurotatoWeaponLock,
		// Token: 0x0400B665 RID: 46693
		[OriginalName("KurotatoLevelNotOpen")]
		KurotatoLevelNotOpen,
		// Token: 0x0400B666 RID: 46694
		[OriginalName("HasTempRogueArchive")]
		HasTempRogueArchive,
		// Token: 0x0400B667 RID: 46695
		[OriginalName("NoTempRogueArchive")]
		NoTempRogueArchive,
		// Token: 0x0400B668 RID: 46696
		[OriginalName("RogueArchiveSlotErr")]
		RogueArchiveSlotErr,
		// Token: 0x0400B669 RID: 46697
		[OriginalName("NoRogueTowerTrial")]
		NoRogueTowerTrial,
		// Token: 0x0400B66A RID: 46698
		[OriginalName("RogueTowerTrialInstNoConf")]
		RogueTowerTrialInstNoConf,
		// Token: 0x0400B66B RID: 46699
		[OriginalName("RogueTowerTrialNoConf")]
		RogueTowerTrialNoConf,
		// Token: 0x0400B66C RID: 46700
		[OriginalName("RogueTowerTrialInstNoData")]
		RogueTowerTrialInstNoData,
		// Token: 0x0400B66D RID: 46701
		[OriginalName("RogueTowerTrialInstInChallenge")]
		RogueTowerTrialInstInChallenge,
		// Token: 0x0400B66E RID: 46702
		[OriginalName("RogueTowerTrialInstBossErr")]
		RogueTowerTrialInstBossErr,
		// Token: 0x0400B66F RID: 46703
		[OriginalName("NoRogueArchive")]
		NoRogueArchive,
		// Token: 0x0400B670 RID: 46704
		[OriginalName("RogueArchiveInvalid")]
		RogueArchiveInvalid,
		// Token: 0x0400B671 RID: 46705
		[OriginalName("KurotatoStepErr1")]
		KurotatoStepErr1,
		// Token: 0x0400B672 RID: 46706
		[OriginalName("KurotatoStepErr2")]
		KurotatoStepErr2,
		// Token: 0x0400B673 RID: 46707
		[OriginalName("ErrorNewTowerAwardCantGet")]
		ErrorNewTowerAwardCantGet,
		// Token: 0x0400B674 RID: 46708
		[OriginalName("KurotatoShopProductIsBought")]
		KurotatoShopProductIsBought,
		// Token: 0x0400B675 RID: 46709
		[OriginalName("KurotatoShopProductAllLock")]
		KurotatoShopProductAllLock,
		// Token: 0x0400B676 RID: 46710
		[OriginalName("ErrorShortMessageChatThemeNoData")]
		ErrorShortMessageChatThemeNoData,
		// Token: 0x0400B677 RID: 46711
		[OriginalName("ErrorShortMessageChatThemeNoConf")]
		ErrorShortMessageChatThemeNoConf,
		// Token: 0x0400B678 RID: 46712
		[OriginalName("ErrorShortMessageChatCharmNoData")]
		ErrorShortMessageChatCharmNoData,
		// Token: 0x0400B679 RID: 46713
		[OriginalName("ErrorShortMessageChatCharmNoConf")]
		ErrorShortMessageChatCharmNoConf,
		// Token: 0x0400B67A RID: 46714
		[OriginalName("RogueResLimitedRoles")]
		RogueResLimitedRoles = 1100505,
		// Token: 0x0400B67B RID: 46715
		[OriginalName("RoleTowerNoActivityData")]
		RoleTowerNoActivityData = 1100634,
		// Token: 0x0400B67C RID: 46716
		[OriginalName("RoleTowerNoActivityConf")]
		RoleTowerNoActivityConf,
		// Token: 0x0400B67D RID: 46717
		[OriginalName("RoleTowerTaskLengthMax")]
		RoleTowerTaskLengthMax,
		// Token: 0x0400B67E RID: 46718
		[OriginalName("RoleTowerTaskNoConf")]
		RoleTowerTaskNoConf,
		// Token: 0x0400B67F RID: 46719
		[OriginalName("RoleTowerTaskNoFinish")]
		RoleTowerTaskNoFinish,
		// Token: 0x0400B680 RID: 46720
		[OriginalName("RoleTowerTaskIsAward")]
		RoleTowerTaskIsAward,
		// Token: 0x0400B681 RID: 46721
		[OriginalName("RoleTowerTaskRepeat")]
		RoleTowerTaskRepeat,
		// Token: 0x0400B682 RID: 46722
		[OriginalName("RoleTowerTaskZero")]
		RoleTowerTaskZero,
		// Token: 0x0400B683 RID: 46723
		[OriginalName("RoleTowerNotInLimitTime")]
		RoleTowerNotInLimitTime,
		// Token: 0x0400B684 RID: 46724
		[OriginalName("RoleTowerContextEmpty")]
		RoleTowerContextEmpty,
		// Token: 0x0400B685 RID: 46725
		[OriginalName("RoleTowerMultiModeNotSupported")]
		RoleTowerMultiModeNotSupported,
		// Token: 0x0400B686 RID: 46726
		[OriginalName("RoleTowerLevelConfigNotExist")]
		RoleTowerLevelConfigNotExist,
		// Token: 0x0400B687 RID: 46727
		[OriginalName("RoleTowerLevelNotOpen")]
		RoleTowerLevelNotOpen,
		// Token: 0x0400B688 RID: 46728
		[OriginalName("RoleTowerNoLevelData")]
		RoleTowerNoLevelData,
		// Token: 0x0400B689 RID: 46729
		[OriginalName("RoleTowerNoRecord")]
		RoleTowerNoRecord,
		// Token: 0x0400B68A RID: 46730
		[OriginalName("RoleTowerRecordLevelNotMatch")]
		RoleTowerRecordLevelNotMatch,
		// Token: 0x0400B68B RID: 46731
		[OriginalName("RoleTowerRoleCountInvalid")]
		RoleTowerRoleCountInvalid,
		// Token: 0x0400B68C RID: 46732
		[OriginalName("RoleTowerRoleNotMatch")]
		RoleTowerRoleNotMatch,
		// Token: 0x0400B68D RID: 46733
		[OriginalName("RoleTowerRoleRepeat")]
		RoleTowerRoleRepeat,
		// Token: 0x0400B68E RID: 46734
		[OriginalName("RoleTowerRoleEnergyNotEnough")]
		RoleTowerRoleEnergyNotEnough,
		// Token: 0x0400B68F RID: 46735
		[OriginalName("RoleTowerStageConfigNotExist")]
		RoleTowerStageConfigNotExist,
		// Token: 0x0400B690 RID: 46736
		[OriginalName("RoleTowerTokenConfigNotExist")]
		RoleTowerTokenConfigNotExist,
		// Token: 0x0400B691 RID: 46737
		[OriginalName("RoleTowerTokenActivityNotMatch")]
		RoleTowerTokenActivityNotMatch,
		// Token: 0x0400B692 RID: 46738
		[OriginalName("RoleTowerConsumeItemNotInProgress")]
		RoleTowerConsumeItemNotInProgress = 1100666,
		// Token: 0x0400B693 RID: 46739
		[OriginalName("RoleTowerConsumeItemNotUsable")]
		RoleTowerConsumeItemNotUsable,
		// Token: 0x0400B694 RID: 46740
		[OriginalName("RoleTowerConsumeItemNotEnough")]
		RoleTowerConsumeItemNotEnough,
		// Token: 0x0400B695 RID: 46741
		[OriginalName("RoleTowerRankRequestInCd")]
		RoleTowerRankRequestInCd,
		// Token: 0x0400B696 RID: 46742
		[OriginalName("RoleTowerPrepareStepTypeMismatch")]
		RoleTowerPrepareStepTypeMismatch,
		// Token: 0x0400B697 RID: 46743
		[OriginalName("RoleTowerPrepareStepAlreadyFinished")]
		RoleTowerPrepareStepAlreadyFinished,
		// Token: 0x0400B698 RID: 46744
		[OriginalName("RoleTowerSettleStepTypeMismatch")]
		RoleTowerSettleStepTypeMismatch,
		// Token: 0x0400B699 RID: 46745
		[OriginalName("RoleTowerTeamUpgradeStepTypeMismatch")]
		RoleTowerTeamUpgradeStepTypeMismatch,
		// Token: 0x0400B69A RID: 46746
		[OriginalName("RoleTowerLoadSubLevelStepTypeMismatch")]
		RoleTowerLoadSubLevelStepTypeMismatch,
		// Token: 0x0400B69B RID: 46747
		[OriginalName("RoleTowerUnsupportedStepRequest")]
		RoleTowerUnsupportedStepRequest,
		// Token: 0x0400B69C RID: 46748
		[OriginalName("RoleTowerRequestRepeated")]
		RoleTowerRequestRepeated,
		// Token: 0x0400B69D RID: 46749
		[OriginalName("RoleTowerRankEntranceClosed")]
		RoleTowerRankEntranceClosed = 1100687,
		// Token: 0x0400B69E RID: 46750
		[OriginalName("ErrChatNotFriendNorOnline")]
		ErrChatNotFriendNorOnline = 1200000,
		// Token: 0x0400B69F RID: 46751
		[OriginalName("ErrChatContentFilterFailed")]
		ErrChatContentFilterFailed,
		// Token: 0x0400B6A0 RID: 46752
		[OriginalName("ErrChatLockState")]
		ErrChatLockState,
		// Token: 0x0400B6A1 RID: 46753
		[OriginalName("ErrChatEmojiNotValid")]
		ErrChatEmojiNotValid,
		// Token: 0x0400B6A2 RID: 46754
		[OriginalName("ErrChatSendTooFast")]
		ErrChatSendTooFast,
		// Token: 0x0400B6A3 RID: 46755
		[OriginalName("ErrChatMuteNotValidId")]
		ErrChatMuteNotValidId,
		// Token: 0x0400B6A4 RID: 46756
		[OriginalName("ErrBanChatDefault")]
		ErrBanChatDefault,
		// Token: 0x0400B6A5 RID: 46757
		[OriginalName("ErrRoleQuestFuncNotOpen")]
		ErrRoleQuestFuncNotOpen,
		// Token: 0x0400B6A6 RID: 46758
		[OriginalName("ErrRoleQuestMaxCount")]
		ErrRoleQuestMaxCount,
		// Token: 0x0400B6A7 RID: 46759
		[OriginalName("ErrRoleQuestUnlockPointNotEnough")]
		ErrRoleQuestUnlockPointNotEnough,
		// Token: 0x0400B6A8 RID: 46760
		[OriginalName("ErrDailyQuestNotFoundArea")]
		ErrDailyQuestNotFoundArea,
		// Token: 0x0400B6A9 RID: 46761
		[OriginalName("ErrDailyQuestNotFoundInfluence")]
		ErrDailyQuestNotFoundInfluence,
		// Token: 0x0400B6AA RID: 46762
		[OriginalName("ErrDailyQuestRewardAlreadyGet")]
		ErrDailyQuestRewardAlreadyGet,
		// Token: 0x0400B6AB RID: 46763
		[OriginalName("ErrDailyQuestDataError")]
		ErrDailyQuestDataError,
		// Token: 0x0400B6AC RID: 46764
		[OriginalName("ErrDailyQuestCantGetReward")]
		ErrDailyQuestCantGetReward,
		// Token: 0x0400B6AD RID: 46765
		[OriginalName("ErrEntityBuffProducerStateError")]
		ErrEntityBuffProducerStateError,
		// Token: 0x0400B6AE RID: 46766
		[OriginalName("ErrEntityBuffProducerNotFound")]
		ErrEntityBuffProducerNotFound,
		// Token: 0x0400B6AF RID: 46767
		[OriginalName("ErrVoiceRemainChangeRoleNotInFormation")]
		ErrVoiceRemainChangeRoleNotInFormation,
		// Token: 0x0400B6B0 RID: 46768
		[OriginalName("ErrVoiceRemainChangeRoleNotAlive")]
		ErrVoiceRemainChangeRoleNotAlive,
		// Token: 0x0400B6B1 RID: 46769
		[OriginalName("ErrApplyEffectFail")]
		ErrApplyEffectFail = 1300000,
		// Token: 0x0400B6B2 RID: 46770
		[OriginalName("ErrOutofBattleTargetNotMonster")]
		ErrOutofBattleTargetNotMonster,
		// Token: 0x0400B6B3 RID: 46771
		[OriginalName("ErrMonsterBoomEntityNotExists")]
		ErrMonsterBoomEntityNotExists,
		// Token: 0x0400B6B4 RID: 46772
		[OriginalName("ErrMonsterBoomNotMonster")]
		ErrMonsterBoomNotMonster,
		// Token: 0x0400B6B5 RID: 46773
		[OriginalName("ErrMonsterBoomIsDead")]
		ErrMonsterBoomIsDead,
		// Token: 0x0400B6B6 RID: 46774
		[OriginalName("ErrAnimationStateSpecialFuncException")]
		ErrAnimationStateSpecialFuncException,
		// Token: 0x0400B6B7 RID: 46775
		[OriginalName("ErrPayConfigNotFound")]
		ErrPayConfigNotFound = 1400000,
		// Token: 0x0400B6B8 RID: 46776
		[OriginalName("ErrPayCreateReceiptFail")]
		ErrPayCreateReceiptFail,
		// Token: 0x0400B6B9 RID: 46777
		[OriginalName("ErrPayReceiptNotFound")]
		ErrPayReceiptNotFound,
		// Token: 0x0400B6BA RID: 46778
		[OriginalName("ErrPayReceiptPlayerIdUnMatch")]
		ErrPayReceiptPlayerIdUnMatch,
		// Token: 0x0400B6BB RID: 46779
		[OriginalName("ErrPayReceiptCannotDealClose")]
		ErrPayReceiptCannotDealClose,
		// Token: 0x0400B6BC RID: 46780
		[OriginalName("ErrPayReceiptDealCloseFail")]
		ErrPayReceiptDealCloseFail,
		// Token: 0x0400B6BD RID: 46781
		[OriginalName("ErrPayNotEnable")]
		ErrPayNotEnable,
		// Token: 0x0400B6BE RID: 46782
		[OriginalName("ErrPayDataChanged")]
		ErrPayDataChanged,
		// Token: 0x0400B6BF RID: 46783
		[OriginalName("ErrPayUpdateReceiptFail")]
		ErrPayUpdateReceiptFail,
		// Token: 0x0400B6C0 RID: 46784
		[OriginalName("ErrGachaConfigNotFound")]
		ErrGachaConfigNotFound,
		// Token: 0x0400B6C1 RID: 46785
		[OriginalName("ErrGachaRuleGroupConfigNotFound")]
		ErrGachaRuleGroupConfigNotFound,
		// Token: 0x0400B6C2 RID: 46786
		[OriginalName("ErrGachaRulesNotFound")]
		ErrGachaRulesNotFound,
		// Token: 0x0400B6C3 RID: 46787
		[OriginalName("ErrGachaTypeKnowns")]
		ErrGachaTypeKnowns,
		// Token: 0x0400B6C4 RID: 46788
		[OriginalName("ErrGachaDailyTimesLimit")]
		ErrGachaDailyTimesLimit,
		// Token: 0x0400B6C5 RID: 46789
		[OriginalName("ErrGachaTotalTimesLimit")]
		ErrGachaTotalTimesLimit,
		// Token: 0x0400B6C6 RID: 46790
		[OriginalName("ErrGachaDailyTotalTimesLimit")]
		ErrGachaDailyTotalTimesLimit,
		// Token: 0x0400B6C7 RID: 46791
		[OriginalName("ErrGachaIsNotOpen")]
		ErrGachaIsNotOpen,
		// Token: 0x0400B6C8 RID: 46792
		[OriginalName("ErrGachaIsNotInOpenTime")]
		ErrGachaIsNotInOpenTime,
		// Token: 0x0400B6C9 RID: 46793
		[OriginalName("ErrGachaFuncIsNotOpen")]
		ErrGachaFuncIsNotOpen,
		// Token: 0x0400B6CA RID: 46794
		[OriginalName("ErrItemExchageConfigNotFound")]
		ErrItemExchageConfigNotFound,
		// Token: 0x0400B6CB RID: 46795
		[OriginalName("ErrItemExchageDailyTimesLimit")]
		ErrItemExchageDailyTimesLimit,
		// Token: 0x0400B6CC RID: 46796
		[OriginalName("ErrItemExchangeTotalTimesLimit")]
		ErrItemExchangeTotalTimesLimit,
		// Token: 0x0400B6CD RID: 46797
		[OriginalName("ErrGachaLimitNotFound")]
		ErrGachaLimitNotFound,
		// Token: 0x0400B6CE RID: 46798
		[OriginalName("ErrGachaLimitsEmpty")]
		ErrGachaLimitsEmpty,
		// Token: 0x0400B6CF RID: 46799
		[OriginalName("ErrTextServerTimeout")]
		ErrTextServerTimeout,
		// Token: 0x0400B6D0 RID: 46800
		[OriginalName("ErrTextServerResFail")]
		ErrTextServerResFail,
		// Token: 0x0400B6D1 RID: 46801
		[OriginalName("ErrTextServerResEmpty")]
		ErrTextServerResEmpty,
		// Token: 0x0400B6D2 RID: 46802
		[OriginalName("ErrTextServerResException")]
		ErrTextServerResException,
		// Token: 0x0400B6D3 RID: 46803
		[OriginalName("ErrItemExchageParamError")]
		ErrItemExchageParamError,
		// Token: 0x0400B6D4 RID: 46804
		[OriginalName("ErrBattlePassFuncIsNotOpen")]
		ErrBattlePassFuncIsNotOpen,
		// Token: 0x0400B6D5 RID: 46805
		[OriginalName("ErrPayShopFuncIsNotOpen")]
		ErrPayShopFuncIsNotOpen,
		// Token: 0x0400B6D6 RID: 46806
		[OriginalName("ErrGachaPoolConfigNotFound")]
		ErrGachaPoolConfigNotFound,
		// Token: 0x0400B6D7 RID: 46807
		[OriginalName("ErrGachaPoolIsNotOpen")]
		ErrGachaPoolIsNotOpen,
		// Token: 0x0400B6D8 RID: 46808
		[OriginalName("ErrGachaPoolIsNotInOpenTime")]
		ErrGachaPoolIsNotInOpenTime,
		// Token: 0x0400B6D9 RID: 46809
		[OriginalName("ErrGachaPoolLimitNotFound")]
		ErrGachaPoolLimitNotFound,
		// Token: 0x0400B6DA RID: 46810
		[OriginalName("ErrGachaPoolNotBelongToGacha")]
		ErrGachaPoolNotBelongToGacha,
		// Token: 0x0400B6DB RID: 46811
		[OriginalName("ErrGachaUsePoolIdNotSet")]
		ErrGachaUsePoolIdNotSet,
		// Token: 0x0400B6DC RID: 46812
		[OriginalName("ErrGachaTimesNonsupport")]
		ErrGachaTimesNonsupport,
		// Token: 0x0400B6DD RID: 46813
		[OriginalName("ErrGachaFrontRuleGroupNotFinish")]
		ErrGachaFrontRuleGroupNotFinish,
		// Token: 0x0400B6DE RID: 46814
		[OriginalName("ErrGachaRuleGroupFinish")]
		ErrGachaRuleGroupFinish,
		// Token: 0x0400B6DF RID: 46815
		[OriginalName("ErrPayGiftBuyLimit")]
		ErrPayGiftBuyLimit,
		// Token: 0x0400B6E0 RID: 46816
		[OriginalName("ErrPayGiftTypeUnknown")]
		ErrPayGiftTypeUnknown,
		// Token: 0x0400B6E1 RID: 46817
		[OriginalName("ErrPayGiftNotInSellTime")]
		ErrPayGiftNotInSellTime,
		// Token: 0x0400B6E2 RID: 46818
		[OriginalName("ErrBattlePassBuyLevelLimit")]
		ErrBattlePassBuyLevelLimit,
		// Token: 0x0400B6E3 RID: 46819
		[OriginalName("ErrBattlePassBuyLevelError")]
		ErrBattlePassBuyLevelError,
		// Token: 0x0400B6E4 RID: 46820
		[OriginalName("ErrJsFileNotFound")]
		ErrJsFileNotFound,
		// Token: 0x0400B6E5 RID: 46821
		[OriginalName("ErrPayReceiptIsRefunded")]
		ErrPayReceiptIsRefunded,
		// Token: 0x0400B6E6 RID: 46822
		[OriginalName("ErrPayReceiptIsNotPay")]
		ErrPayReceiptIsNotPay,
		// Token: 0x0400B6E7 RID: 46823
		[OriginalName("ErrPayReceiptRefundFail")]
		ErrPayReceiptRefundFail,
		// Token: 0x0400B6E8 RID: 46824
		[OriginalName("ErrPayGiftLocked")]
		ErrPayGiftLocked,
		// Token: 0x0400B6E9 RID: 46825
		[OriginalName("ErrPayGiftBuyConditionLimit")]
		ErrPayGiftBuyConditionLimit,
		// Token: 0x0400B6EA RID: 46826
		[OriginalName("ErrMapMarkConfigIdNotExist")]
		ErrMapMarkConfigIdNotExist,
		// Token: 0x0400B6EB RID: 46827
		[OriginalName("ErrTreasureSlotMarkNotExist")]
		ErrTreasureSlotMarkNotExist,
		// Token: 0x0400B6EC RID: 46828
		[OriginalName("ErrTreasureBoxMarkNotExist")]
		ErrTreasureBoxMarkNotExist,
		// Token: 0x0400B6ED RID: 46829
		[OriginalName("ErrTreasureSlotMarkExist")]
		ErrTreasureSlotMarkExist,
		// Token: 0x0400B6EE RID: 46830
		[OriginalName("ErrMapMarkTypeNotCustom")]
		ErrMapMarkTypeNotCustom,
		// Token: 0x0400B6EF RID: 46831
		[OriginalName("ErrPayShopIsNotOpen")]
		ErrPayShopIsNotOpen,
		// Token: 0x0400B6F0 RID: 46832
		[OriginalName("ErrConsumptiveActivityNotOpen")]
		ErrConsumptiveActivityNotOpen,
		// Token: 0x0400B6F1 RID: 46833
		[OriginalName("ErrConsumptiveTaskNotFound")]
		ErrConsumptiveTaskNotFound,
		// Token: 0x0400B6F2 RID: 46834
		[OriginalName("ErrConsumptiveTaskNotFinish")]
		ErrConsumptiveTaskNotFinish,
		// Token: 0x0400B6F3 RID: 46835
		[OriginalName("ErrConsumptiveTaskRewarded")]
		ErrConsumptiveTaskRewarded,
		// Token: 0x0400B6F4 RID: 46836
		[OriginalName("ErrConsumptiveActivityNotFound")]
		ErrConsumptiveActivityNotFound,
		// Token: 0x0400B6F5 RID: 46837
		[OriginalName("ErrPayGiftPersonalNoPermission")]
		ErrPayGiftPersonalNoPermission,
		// Token: 0x0400B6F6 RID: 46838
		[OriginalName("ErrPayGiftPersonalPermissionExpired")]
		ErrPayGiftPersonalPermissionExpired,
		// Token: 0x0400B6F7 RID: 46839
		[OriginalName("ErrPayGiftNotPersonal")]
		ErrPayGiftNotPersonal,
		// Token: 0x0400B6F8 RID: 46840
		[OriginalName("ErrPayGiftPersonalPermissionExist")]
		ErrPayGiftPersonalPermissionExist,
		// Token: 0x0400B6F9 RID: 46841
		[OriginalName("ErrCouponId")]
		ErrCouponId,
		// Token: 0x0400B6FA RID: 46842
		[OriginalName("ErrCouponConfigNotFound")]
		ErrCouponConfigNotFound,
		// Token: 0x0400B6FB RID: 46843
		[OriginalName("ErrCouponNotEnough")]
		ErrCouponNotEnough,
		// Token: 0x0400B6FC RID: 46844
		[OriginalName("ErrCouponTargetItemNotFound")]
		ErrCouponTargetItemNotFound,
		// Token: 0x0400B6FD RID: 46845
		[OriginalName("ErrCouponTargetItemCount")]
		ErrCouponTargetItemCount,
		// Token: 0x0400B6FE RID: 46846
		[OriginalName("ErrGachaTypeNotPersonal")]
		ErrGachaTypeNotPersonal,
		// Token: 0x0400B6FF RID: 46847
		[OriginalName("ErrGachaPersonalPermissionExist")]
		ErrGachaPersonalPermissionExist,
		// Token: 0x0400B700 RID: 46848
		[OriginalName("ErrGachaPersonalNoPermission")]
		ErrGachaPersonalNoPermission,
		// Token: 0x0400B701 RID: 46849
		[OriginalName("ErrGachaPersonalPermissionExpired")]
		ErrGachaPersonalPermissionExpired,
		// Token: 0x0400B702 RID: 46850
		[OriginalName("ErrPayGiftVersionConfigNotFound")]
		ErrPayGiftVersionConfigNotFound,
		// Token: 0x0400B703 RID: 46851
		[OriginalName("ErrPayGiftSelfDefineVersionError")]
		ErrPayGiftSelfDefineVersionError,
		// Token: 0x0400B704 RID: 46852
		[OriginalName("ErrInfoDisplayId")]
		ErrInfoDisplayId = 1500000,
		// Token: 0x0400B705 RID: 46853
		[OriginalName("ErrItemAlreadyInCd")]
		ErrItemAlreadyInCd,
		// Token: 0x0400B706 RID: 46854
		[OriginalName("ErrCantFinAdventureConfig")]
		ErrCantFinAdventureConfig,
		// Token: 0x0400B707 RID: 46855
		[OriginalName("ErrAdventureRewardReceived")]
		ErrAdventureRewardReceived,
		// Token: 0x0400B708 RID: 46856
		[OriginalName("ErrAdventureTaskCache")]
		ErrAdventureTaskCache,
		// Token: 0x0400B709 RID: 46857
		[OriginalName("ErrAdventureState")]
		ErrAdventureState,
		// Token: 0x0400B70A RID: 46858
		[OriginalName("ErrAdventureRewardOrder")]
		ErrAdventureRewardOrder,
		// Token: 0x0400B70B RID: 46859
		[OriginalName("ErrAdventureChapterState")]
		ErrAdventureChapterState,
		// Token: 0x0400B70C RID: 46860
		[OriginalName("ErrCantDetectRepeat")]
		ErrCantDetectRepeat,
		// Token: 0x0400B70D RID: 46861
		[OriginalName("ErrNotInCurrentFollowList")]
		ErrNotInCurrentFollowList,
		// Token: 0x0400B70E RID: 46862
		[OriginalName("ErrCantDetectOtherDetectionType")]
		ErrCantDetectOtherDetectionType,
		// Token: 0x0400B70F RID: 46863
		[OriginalName("ErrNotSelectCurrentDetectionId")]
		ErrNotSelectCurrentDetectionId,
		// Token: 0x0400B710 RID: 46864
		[OriginalName("ErrDetectionConfigNotFound")]
		ErrDetectionConfigNotFound,
		// Token: 0x0400B711 RID: 46865
		[OriginalName("ErrDetectionListCantBeEmpty")]
		ErrDetectionListCantBeEmpty,
		// Token: 0x0400B712 RID: 46866
		[OriginalName("ErrCantFindAnyDetectionTarget")]
		ErrCantFindAnyDetectionTarget,
		// Token: 0x0400B713 RID: 46867
		[OriginalName("ErrCantFindTurntableComponentEntity")]
		ErrCantFindTurntableComponentEntity,
		// Token: 0x0400B714 RID: 46868
		[OriginalName("ErrHaveNoTurntableControlComponent")]
		ErrHaveNoTurntableControlComponent,
		// Token: 0x0400B715 RID: 46869
		[OriginalName("ErrCantFindLevitationMagnetComponentEntity")]
		ErrCantFindLevitationMagnetComponentEntity,
		// Token: 0x0400B716 RID: 46870
		[OriginalName("ErrHaveNoLevitaionMagnetComponent")]
		ErrHaveNoLevitaionMagnetComponent,
		// Token: 0x0400B717 RID: 46871
		[OriginalName("ErrCantFindBoardEntity")]
		ErrCantFindBoardEntity,
		// Token: 0x0400B718 RID: 46872
		[OriginalName("ErrCantFindPlacementEntity")]
		ErrCantFindPlacementEntity,
		// Token: 0x0400B719 RID: 46873
		[OriginalName("ErrHaveNoPlacementComponent")]
		ErrHaveNoPlacementComponent,
		// Token: 0x0400B71A RID: 46874
		[OriginalName("ErrCantFindBoardEntityComponent")]
		ErrCantFindBoardEntityComponent,
		// Token: 0x0400B71B RID: 46875
		[OriginalName("ErrBoardHaveNoAnyPlacement")]
		ErrBoardHaveNoAnyPlacement,
		// Token: 0x0400B71C RID: 46876
		[OriginalName("ErrBoardNotActiveAllGrid")]
		ErrBoardNotActiveAllGrid,
		// Token: 0x0400B71D RID: 46877
		[OriginalName("ErrNeedBeControlledBefore")]
		ErrNeedBeControlledBefore,
		// Token: 0x0400B71E RID: 46878
		[OriginalName("ErrPlaceFailOfAlreadyOnBoard")]
		ErrPlaceFailOfAlreadyOnBoard,
		// Token: 0x0400B71F RID: 46879
		[OriginalName("ErrInvalidBoardPosition")]
		ErrInvalidBoardPosition,
		// Token: 0x0400B720 RID: 46880
		[OriginalName("ErrNeedRemoveControlRelation")]
		ErrNeedRemoveControlRelation,
		// Token: 0x0400B721 RID: 46881
		[OriginalName("ErrNotOccupyOnBoard")]
		ErrNotOccupyOnBoard,
		// Token: 0x0400B722 RID: 46882
		[OriginalName("ErrHaveNoFillRule")]
		ErrHaveNoFillRule,
		// Token: 0x0400B723 RID: 46883
		[OriginalName("ErrGridPosAlreadyOccupied")]
		ErrGridPosAlreadyOccupied,
		// Token: 0x0400B724 RID: 46884
		[OriginalName("ErrHaveNoJigsawFoundationConfig")]
		ErrHaveNoJigsawFoundationConfig,
		// Token: 0x0400B725 RID: 46885
		[OriginalName("ErrInvalidGridPos")]
		ErrInvalidGridPos,
		// Token: 0x0400B726 RID: 46886
		[OriginalName("ErrGridPosAlreadyActive")]
		ErrGridPosAlreadyActive,
		// Token: 0x0400B727 RID: 46887
		[OriginalName("ErrCantPlaceItemOnBoard")]
		ErrCantPlaceItemOnBoard,
		// Token: 0x0400B728 RID: 46888
		[OriginalName("ErrNeedJigsawFoundationComponentWhenBeControlled")]
		ErrNeedJigsawFoundationComponentWhenBeControlled,
		// Token: 0x0400B729 RID: 46889
		[OriginalName("ErrHaveNoBoardComponentConfig")]
		ErrHaveNoBoardComponentConfig,
		// Token: 0x0400B72A RID: 46890
		[OriginalName("ErrNeedJigsawItemComponentWhenBeControlled")]
		ErrNeedJigsawItemComponentWhenBeControlled,
		// Token: 0x0400B72B RID: 46891
		[OriginalName("ErrCantFindOriginBoardEntity")]
		ErrCantFindOriginBoardEntity,
		// Token: 0x0400B72C RID: 46892
		[OriginalName("ErrDistanceNotInRangeBetweenEntity")]
		ErrDistanceNotInRangeBetweenEntity,
		// Token: 0x0400B72D RID: 46893
		[OriginalName("ErrJigsawFoundationIsAlreadySilent")]
		ErrJigsawFoundationIsAlreadySilent,
		// Token: 0x0400B72E RID: 46894
		[OriginalName("ErrCrystalEntityNotFound")]
		ErrCrystalEntityNotFound,
		// Token: 0x0400B72F RID: 46895
		[OriginalName("ErrGachaBoardEntityNotFound")]
		ErrGachaBoardEntityNotFound,
		// Token: 0x0400B730 RID: 46896
		[OriginalName("ErrNotCrystalEntity")]
		ErrNotCrystalEntity,
		// Token: 0x0400B731 RID: 46897
		[OriginalName("ErrNotGachaFoundationEntity")]
		ErrNotGachaFoundationEntity,
		// Token: 0x0400B732 RID: 46898
		[OriginalName("ErrGachaHoleIsFull")]
		ErrGachaHoleIsFull,
		// Token: 0x0400B733 RID: 46899
		[OriginalName("ErrJigsawItemSilent")]
		ErrJigsawItemSilent,
		// Token: 0x0400B734 RID: 46900
		[OriginalName("ErrThrowDamageConfigNotExists")]
		ErrThrowDamageConfigNotExists,
		// Token: 0x0400B735 RID: 46901
		[OriginalName("ErrThrowDamageComponetNotExists")]
		ErrThrowDamageComponetNotExists,
		// Token: 0x0400B736 RID: 46902
		[OriginalName("ErrEggNotMatchEggFoundation")]
		ErrEggNotMatchEggFoundation,
		// Token: 0x0400B737 RID: 46903
		[OriginalName("ProgressBarEntityNotFound")]
		ProgressBarEntityNotFound,
		// Token: 0x0400B738 RID: 46904
		[OriginalName("NotProgressBarEntity")]
		NotProgressBarEntity,
		// Token: 0x0400B739 RID: 46905
		[OriginalName("ProgressBarIsSilent")]
		ProgressBarIsSilent,
		// Token: 0x0400B73A RID: 46906
		[OriginalName("ScenePlayerInfoNotFound")]
		ScenePlayerInfoNotFound,
		// Token: 0x0400B73B RID: 46907
		[OriginalName("PlayerNotInAnyScene")]
		PlayerNotInAnyScene,
		// Token: 0x0400B73C RID: 46908
		[OriginalName("TeleportNotInValidDistance")]
		TeleportNotInValidDistance,
		// Token: 0x0400B73D RID: 46909
		[OriginalName("AddMapMarkInfoLackOfTeleportParam")]
		AddMapMarkInfoLackOfTeleportParam,
		// Token: 0x0400B73E RID: 46910
		[OriginalName("TemporaryTeleportNotExists")]
		TemporaryTeleportNotExists,
		// Token: 0x0400B73F RID: 46911
		[OriginalName("ErrNotHostPlayer")]
		ErrNotHostPlayer,
		// Token: 0x0400B740 RID: 46912
		[OriginalName("ErrMarkIdNotExists")]
		ErrMarkIdNotExists,
		// Token: 0x0400B741 RID: 46913
		[OriginalName("ErrCantUpdateTemporaryTeleportMarkInfo")]
		ErrCantUpdateTemporaryTeleportMarkInfo,
		// Token: 0x0400B742 RID: 46914
		[OriginalName("NotHostCantAddTemporaty")]
		NotHostCantAddTemporaty,
		// Token: 0x0400B743 RID: 46915
		[OriginalName("TemporaryTeleportPosIsNotWalkable")]
		TemporaryTeleportPosIsNotWalkable,
		// Token: 0x0400B744 RID: 46916
		[OriginalName("BadTemporaryTeleportConfig")]
		BadTemporaryTeleportConfig,
		// Token: 0x0400B745 RID: 46917
		[OriginalName("HaveNoTemporaryTeleportComponent")]
		HaveNoTemporaryTeleportComponent,
		// Token: 0x0400B746 RID: 46918
		[OriginalName("ErrCantDetectAtInvalidPoint")]
		ErrCantDetectAtInvalidPoint,
		// Token: 0x0400B747 RID: 46919
		[OriginalName("ErrNotDetectionTreasureBoxBefore")]
		ErrNotDetectionTreasureBoxBefore,
		// Token: 0x0400B748 RID: 46920
		[OriginalName("ErrJigsawFoundationIsCompleteCantModifyGridState")]
		ErrJigsawFoundationIsCompleteCantModifyGridState,
		// Token: 0x0400B749 RID: 46921
		[OriginalName("GridIsActiveCantSwitchState")]
		GridIsActiveCantSwitchState,
		// Token: 0x0400B74A RID: 46922
		[OriginalName("GridIsOccupiedCantSwitchState")]
		GridIsOccupiedCantSwitchState,
		// Token: 0x0400B74B RID: 46923
		[OriginalName("ErrHaveNoBaseInfoComponent")]
		ErrHaveNoBaseInfoComponent,
		// Token: 0x0400B74C RID: 46924
		[OriginalName("ErrHaveNoParentEntity")]
		ErrHaveNoParentEntity,
		// Token: 0x0400B74D RID: 46925
		[OriginalName("NotRelationEntity")]
		NotRelationEntity,
		// Token: 0x0400B74E RID: 46926
		[OriginalName("ErrLevelPlayNotRunning")]
		ErrLevelPlayNotRunning,
		// Token: 0x0400B74F RID: 46927
		[OriginalName("ErrStateCantChangeWhenLifeCycleDestroy")]
		ErrStateCantChangeWhenLifeCycleDestroy,
		// Token: 0x0400B750 RID: 46928
		[OriginalName("ErrRangeEntityIdNotFoundWhenForbidTempTeleport")]
		ErrRangeEntityIdNotFoundWhenForbidTempTeleport,
		// Token: 0x0400B751 RID: 46929
		[OriginalName("TemporaryTeleportIsForbidden")]
		TemporaryTeleportIsForbidden,
		// Token: 0x0400B752 RID: 46930
		[OriginalName("ErrGravityGearIsComplete")]
		ErrGravityGearIsComplete,
		// Token: 0x0400B753 RID: 46931
		[OriginalName("ErrInvalidRoleWhenUpdatePassiveSkill")]
		ErrInvalidRoleWhenUpdatePassiveSkill,
		// Token: 0x0400B754 RID: 46932
		[OriginalName("ErrInvalidRolePassiveSkillId")]
		ErrInvalidRolePassiveSkillId,
		// Token: 0x0400B755 RID: 46933
		[OriginalName("ErrPassiveSkillNotAddBuff")]
		ErrPassiveSkillNotAddBuff,
		// Token: 0x0400B756 RID: 46934
		[OriginalName("ErrPassiveSkillCantSpecifyBuff")]
		ErrPassiveSkillCantSpecifyBuff,
		// Token: 0x0400B757 RID: 46935
		[OriginalName("ErrPassiveSkillAddBuffFail")]
		ErrPassiveSkillAddBuffFail,
		// Token: 0x0400B758 RID: 46936
		[OriginalName("ErrPassiveSkillAddBulletFail")]
		ErrPassiveSkillAddBulletFail,
		// Token: 0x0400B759 RID: 46937
		[OriginalName("ErrBuffCreatePassiveSkillFail")]
		ErrBuffCreatePassiveSkillFail,
		// Token: 0x0400B75A RID: 46938
		[OriginalName("ErrInvalidPreContext")]
		ErrInvalidPreContext,
		// Token: 0x0400B75B RID: 46939
		[OriginalName("ErrBadPassiveSkillId")]
		ErrBadPassiveSkillId,
		// Token: 0x0400B75C RID: 46940
		[OriginalName("ErrPassiveSkillComponentNotFound")]
		ErrPassiveSkillComponentNotFound,
		// Token: 0x0400B75D RID: 46941
		[OriginalName("ErrRepeatePassiveSkill")]
		ErrRepeatePassiveSkill,
		// Token: 0x0400B75E RID: 46942
		[OriginalName("ErrBadPassiveSkillTriggerType")]
		ErrBadPassiveSkillTriggerType,
		// Token: 0x0400B75F RID: 46943
		[OriginalName("ErrAddPassiveSkillFailOfEntityNotFound")]
		ErrAddPassiveSkillFailOfEntityNotFound,
		// Token: 0x0400B760 RID: 46944
		[OriginalName("ErrEntityNotClientControlWhenAddPassiveSkill")]
		ErrEntityNotClientControlWhenAddPassiveSkill,
		// Token: 0x0400B761 RID: 46945
		[OriginalName("ErrEntityNotClientControlWhenRemovePassiveSkill")]
		ErrEntityNotClientControlWhenRemovePassiveSkill,
		// Token: 0x0400B762 RID: 46946
		[OriginalName("ErrPassiveSkillNotFoundWhenRemovePassiveSkill")]
		ErrPassiveSkillNotFoundWhenRemovePassiveSkill,
		// Token: 0x0400B763 RID: 46947
		[OriginalName("ErrRepeatedBattleContext")]
		ErrRepeatedBattleContext,
		// Token: 0x0400B764 RID: 46948
		[OriginalName("ErrPassiveSkillAddSkillFail")]
		ErrPassiveSkillAddSkillFail,
		// Token: 0x0400B765 RID: 46949
		[OriginalName("ErrCombatSendPackAbnormal")]
		ErrCombatSendPackAbnormal,
		// Token: 0x0400B766 RID: 46950
		[OriginalName("ErrContextCheckFail")]
		ErrContextCheckFail,
		// Token: 0x0400B767 RID: 46951
		[OriginalName("ErrFsmComponentNotFound")]
		ErrFsmComponentNotFound,
		// Token: 0x0400B768 RID: 46952
		[OriginalName("ErrFsmCreateContextFail")]
		ErrFsmCreateContextFail,
		// Token: 0x0400B769 RID: 46953
		[OriginalName("ErrFsmStateBehaviorPreMessageCantBeZero")]
		ErrFsmStateBehaviorPreMessageCantBeZero,
		// Token: 0x0400B76A RID: 46954
		[OriginalName("ErrFsmBehaviorCheckBattleContextFail")]
		ErrFsmBehaviorCheckBattleContextFail,
		// Token: 0x0400B76B RID: 46955
		[OriginalName("ErrFsmPlayMontageLackPreMessage")]
		ErrFsmPlayMontageLackPreMessage,
		// Token: 0x0400B76C RID: 46956
		[OriginalName("ErrFsmPlayMontageCheckContextFail")]
		ErrFsmPlayMontageCheckContextFail,
		// Token: 0x0400B76D RID: 46957
		[OriginalName("ErrFsmPlayMontageConfigCheckFail")]
		ErrFsmPlayMontageConfigCheckFail,
		// Token: 0x0400B76E RID: 46958
		[OriginalName("ErrSkillFlowNotExist")]
		ErrSkillFlowNotExist,
		// Token: 0x0400B76F RID: 46959
		[OriginalName("ErrGetReportDataOverLimit")]
		ErrGetReportDataOverLimit,
		// Token: 0x0400B770 RID: 46960
		[OriginalName("ErrGetReportDataTooFast")]
		ErrGetReportDataTooFast,
		// Token: 0x0400B771 RID: 46961
		[OriginalName("ErrNotInAnyScene")]
		ErrNotInAnyScene,
		// Token: 0x0400B772 RID: 46962
		[OriginalName("ErrAceLogDataNotFound")]
		ErrAceLogDataNotFound,
		// Token: 0x0400B773 RID: 46963
		[OriginalName("ErrAceLogDataRepeatReport")]
		ErrAceLogDataRepeatReport,
		// Token: 0x0400B774 RID: 46964
		[OriginalName("ErrAceInvalidLogId")]
		ErrAceInvalidLogId,
		// Token: 0x0400B775 RID: 46965
		[OriginalName("ErrAceSceneGlobalObjNotFound")]
		ErrAceSceneGlobalObjNotFound,
		// Token: 0x0400B776 RID: 46966
		[OriginalName("ErrAceBadParam")]
		ErrAceBadParam,
		// Token: 0x0400B777 RID: 46967
		[OriginalName("ErrS2CConfirmIdNotExists")]
		ErrS2CconfirmIdNotExists,
		// Token: 0x0400B778 RID: 46968
		[OriginalName("ErrPassiveSkillConfigNotFound")]
		ErrPassiveSkillConfigNotFound,
		// Token: 0x0400B779 RID: 46969
		[OriginalName("ErrNotBehaviorController")]
		ErrNotBehaviorController,
		// Token: 0x0400B77A RID: 46970
		[OriginalName("ErrPlayMontageFail")]
		ErrPlayMontageFail,
		// Token: 0x0400B77B RID: 46971
		[OriginalName("ErrFightDataInConsistent")]
		ErrFightDataInConsistent,
		// Token: 0x0400B77C RID: 46972
		[OriginalName("ErrNotInAoiSight")]
		ErrNotInAoiSight,
		// Token: 0x0400B77D RID: 46973
		[OriginalName("ErrPassiveSkillNotOwner")]
		ErrPassiveSkillNotOwner,
		// Token: 0x0400B77E RID: 46974
		[OriginalName("ErrReportStartFirstly")]
		ErrReportStartFirstly,
		// Token: 0x0400B77F RID: 46975
		[OriginalName("ErrBattleEntityNotFound")]
		ErrBattleEntityNotFound,
		// Token: 0x0400B780 RID: 46976
		[OriginalName("ErrBattleCampNotDefined")]
		ErrBattleCampNotDefined,
		// Token: 0x0400B781 RID: 46977
		[OriginalName("ErrOtherInternalError")]
		ErrOtherInternalError,
		// Token: 0x0400B782 RID: 46978
		[OriginalName("ErrHaventBattleComponent")]
		ErrHaventBattleComponent,
		// Token: 0x0400B783 RID: 46979
		[OriginalName("ErrLackCombinePartInfoParam")]
		ErrLackCombinePartInfoParam,
		// Token: 0x0400B784 RID: 46980
		[OriginalName("ErrCombinerEntityNotExists")]
		ErrCombinerEntityNotExists,
		// Token: 0x0400B785 RID: 46981
		[OriginalName("ErrTargetEntityNotExists")]
		ErrTargetEntityNotExists,
		// Token: 0x0400B786 RID: 46982
		[OriginalName("ErrTargetPartNotExists")]
		ErrTargetPartNotExists,
		// Token: 0x0400B787 RID: 46983
		[OriginalName("ErrCombineComponentNotExists")]
		ErrCombineComponentNotExists,
		// Token: 0x0400B788 RID: 46984
		[OriginalName("ErrAlreadyCombineToOtherEntity")]
		ErrAlreadyCombineToOtherEntity,
		// Token: 0x0400B789 RID: 46985
		[OriginalName("ErrLackCombinerOffsetPos")]
		ErrLackCombinerOffsetPos,
		// Token: 0x0400B78A RID: 46986
		[OriginalName("ErrLackCombinerOffsetRotate")]
		ErrLackCombinerOffsetRotate,
		// Token: 0x0400B78B RID: 46987
		[OriginalName("ErrCombineEntityNotFound")]
		ErrCombineEntityNotFound,
		// Token: 0x0400B78C RID: 46988
		[OriginalName("ErrDissolveCheckBattleContextFail")]
		ErrDissolveCheckBattleContextFail,
		// Token: 0x0400B78D RID: 46989
		[OriginalName("ErrRepeatedRole")]
		ErrRepeatedRole,
		// Token: 0x0400B78E RID: 46990
		[OriginalName("ErrNotStateMachineBehavior")]
		ErrNotStateMachineBehavior,
		// Token: 0x0400B78F RID: 46991
		[OriginalName("ErrDiscardMsgWhenChangeSceneMultiMode")]
		ErrDiscardMsgWhenChangeSceneMultiMode = 1500140,
		// Token: 0x0400B790 RID: 46992
		[OriginalName("ErrMayOccurDbAbnormal")]
		ErrMayOccurDbAbnormal = 1500139,
		// Token: 0x0400B791 RID: 46993
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfFsmGroupConfigNotExists")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfFsmGroupConfigNotExists = 1500141,
		// Token: 0x0400B792 RID: 46994
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfConfigNotExists")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfConfigNotExists,
		// Token: 0x0400B793 RID: 46995
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageFail")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageFail,
		// Token: 0x0400B794 RID: 46996
		[OriginalName("ErrFsmActionCheckFsmPlayMontageFail")]
		ErrFsmActionCheckFsmPlayMontageFail,
		// Token: 0x0400B795 RID: 46997
		[OriginalName("ErrFsmActionCheckSkillFail")]
		ErrFsmActionCheckSkillFail,
		// Token: 0x0400B796 RID: 46998
		[OriginalName("ErrFsmActionCheckBufflFail")]
		ErrFsmActionCheckBufflFail,
		// Token: 0x0400B797 RID: 46999
		[OriginalName("ErrFsmPlayMontageCheckAnParamError")]
		ErrFsmPlayMontageCheckAnParamError,
		// Token: 0x0400B798 RID: 47000
		[OriginalName("ErrFsmPlayMontageCheckAnMontageConfigNotFound")]
		ErrFsmPlayMontageCheckAnMontageConfigNotFound,
		// Token: 0x0400B799 RID: 47001
		[OriginalName("ErrFsmPlayMontageCheckAnMontageFail")]
		ErrFsmPlayMontageCheckAnMontageFail,
		// Token: 0x0400B79A RID: 47002
		[OriginalName("ErrMontageConfigNotFound")]
		ErrMontageConfigNotFound,
		// Token: 0x0400B79B RID: 47003
		[OriginalName("ErrANConfigNotFound")]
		ErrAnconfigNotFound,
		// Token: 0x0400B79C RID: 47004
		[OriginalName("ErrBulletConfigNotFound")]
		ErrBulletConfigNotFound,
		// Token: 0x0400B79D RID: 47005
		[OriginalName("ErrFsmVersion")]
		ErrFsmVersion,
		// Token: 0x0400B79E RID: 47006
		[OriginalName("ErrUpdateFightRoleRepeated")]
		ErrUpdateFightRoleRepeated,
		// Token: 0x0400B79F RID: 47007
		[OriginalName("TrialRoleEntityOverLimit")]
		TrialRoleEntityOverLimit,
		// Token: 0x0400B7A0 RID: 47008
		[OriginalName("ErrHaveNoRoleInfos")]
		ErrHaveNoRoleInfos,
		// Token: 0x0400B7A1 RID: 47009
		[OriginalName("ErrTeamHaveNoAnyRoles")]
		ErrTeamHaveNoAnyRoles,
		// Token: 0x0400B7A2 RID: 47010
		[OriginalName("ErrSkillMontageNotNormalMontage")]
		ErrSkillMontageNotNormalMontage,
		// Token: 0x0400B7A3 RID: 47011
		[OriginalName("ErrMontageContextConfigNotFound")]
		ErrMontageContextConfigNotFound,
		// Token: 0x0400B7A4 RID: 47012
		[OriginalName("ErrMontageContextCheckAnFail")]
		ErrMontageContextCheckAnFail,
		// Token: 0x0400B7A5 RID: 47013
		[OriginalName("ErrLivingStatusContextCheckPlayMontageContextFail")]
		ErrLivingStatusContextCheckPlayMontageContextFail,
		// Token: 0x0400B7A6 RID: 47014
		[OriginalName("ErrContextHaveNoFsmGroupConfig")]
		ErrContextHaveNoFsmGroupConfig,
		// Token: 0x0400B7A7 RID: 47015
		[OriginalName("ErrLivingStatusContextFsmGroupConfigNotFound")]
		ErrLivingStatusContextFsmGroupConfigNotFound,
		// Token: 0x0400B7A8 RID: 47016
		[OriginalName("ErrFsmActionCheckPlayEntityMontageFail")]
		ErrFsmActionCheckPlayEntityMontageFail,
		// Token: 0x0400B7A9 RID: 47017
		[OriginalName("ErrMontageContext1CheckPlayEntityMontageFail")]
		ErrMontageContext1CheckPlayEntityMontageFail,
		// Token: 0x0400B7AA RID: 47018
		[OriginalName("ErrSkillGAHaveNoModifyCommonEnemyPro")]
		ErrSkillGahaveNoModifyCommonEnemyPro,
		// Token: 0x0400B7AB RID: 47019
		[OriginalName("ErrNotSummonEntity")]
		ErrNotSummonEntity,
		// Token: 0x0400B7AC RID: 47020
		[OriginalName("ErrSkillGAHaveNoTagId")]
		ErrSkillGahaveNoTagId,
		// Token: 0x0400B7AD RID: 47021
		[OriginalName("ErrCombatSkillGAHandleGetEntityFailed")]
		ErrCombatSkillGahandleGetEntityFailed = 1600000,
		// Token: 0x0400B7AE RID: 47022
		[OriginalName("ErrCombatMaterialHandleGetEntityFailed")]
		ErrCombatMaterialHandleGetEntityFailed,
		// Token: 0x0400B7AF RID: 47023
		[OriginalName("ErrCombatParticleHandleGetEntityFailed")]
		ErrCombatParticleHandleGetEntityFailed,
		// Token: 0x0400B7B0 RID: 47024
		[OriginalName("ErrCombatPartLifeChangeEntityNotExisted")]
		ErrCombatPartLifeChangeEntityNotExisted,
		// Token: 0x0400B7B1 RID: 47025
		[OriginalName("ErrCombatCreateBulletTargetNotExisted")]
		ErrCombatCreateBulletTargetNotExisted,
		// Token: 0x0400B7B2 RID: 47026
		[OriginalName("ErrCombatDeleteBulletTargetNotExisted")]
		ErrCombatDeleteBulletTargetNotExisted,
		// Token: 0x0400B7B3 RID: 47027
		[OriginalName("ErrCombatDeleteBulletGetEntityFailed")]
		ErrCombatDeleteBulletGetEntityFailed,
		// Token: 0x0400B7B4 RID: 47028
		[OriginalName("ErrCombatBulletTargetNoExist")]
		ErrCombatBulletTargetNoExist,
		// Token: 0x0400B7B5 RID: 47029
		[OriginalName("ErrPartEntityNotExisted")]
		ErrPartEntityNotExisted,
		// Token: 0x0400B7B6 RID: 47030
		[OriginalName("ErrNoAiControlRights")]
		ErrNoAiControlRights,
		// Token: 0x0400B7B7 RID: 47031
		[OriginalName("ErrAiHateComponent")]
		ErrAiHateComponent,
		// Token: 0x0400B7B8 RID: 47032
		[OriginalName("ErrSummonerPlayerControl")]
		ErrSummonerPlayerControl,
		// Token: 0x0400B7B9 RID: 47033
		[OriginalName("ErrConfDamageNotFound")]
		ErrConfDamageNotFound,
		// Token: 0x0400B7BA RID: 47034
		[OriginalName("ErrProcessDamageFailed")]
		ErrProcessDamageFailed,
		// Token: 0x0400B7BB RID: 47035
		[OriginalName("ErrInjuryFreeLandingTag")]
		ErrInjuryFreeLandingTag,
		// Token: 0x0400B7BC RID: 47036
		[OriginalName("ErrNotFindActiveGameplayEffect")]
		ErrNotFindActiveGameplayEffect,
		// Token: 0x0400B7BD RID: 47037
		[OriginalName("NotClientControlBuff")]
		NotClientControlBuff,
		// Token: 0x0400B7BE RID: 47038
		[OriginalName("ErrBuffNoEffectConf")]
		ErrBuffNoEffectConf,
		// Token: 0x0400B7BF RID: 47039
		[OriginalName("ErrBuffCannotCreateBullet")]
		ErrBuffCannotCreateBullet,
		// Token: 0x0400B7C0 RID: 47040
		[OriginalName("ErrBuffCannotCreateBuff")]
		ErrBuffCannotCreateBuff,
		// Token: 0x0400B7C1 RID: 47041
		[OriginalName("ErrNoBuffConf")]
		ErrNoBuffConf,
		// Token: 0x0400B7C2 RID: 47042
		[OriginalName("ErrStoppedAi")]
		ErrStoppedAi,
		// Token: 0x0400B7C3 RID: 47043
		[OriginalName("ErrEntityIsNotAlive")]
		ErrEntityIsNotAlive,
		// Token: 0x0400B7C4 RID: 47044
		[OriginalName("ErrSummonCannotSwitchAiControl")]
		ErrSummonCannotSwitchAiControl,
		// Token: 0x0400B7C5 RID: 47045
		[OriginalName("ErrAiControlNotChange")]
		ErrAiControlNotChange,
		// Token: 0x0400B7C6 RID: 47046
		[OriginalName("ErrPlayerCannotControlEntity")]
		ErrPlayerCannotControlEntity,
		// Token: 0x0400B7C7 RID: 47047
		[OriginalName("ErrNotFoundBuffEffect")]
		ErrNotFoundBuffEffect,
		// Token: 0x0400B7C8 RID: 47048
		[OriginalName("ErrBuffEffectAuthority")]
		ErrBuffEffectAuthority,
		// Token: 0x0400B7C9 RID: 47049
		[OriginalName("ErrConcomitantDestroy")]
		ErrConcomitantDestroy,
		// Token: 0x0400B7CA RID: 47050
		[OriginalName("ErrPlayerFollowersComponent")]
		ErrPlayerFollowersComponent,
		// Token: 0x0400B7CB RID: 47051
		[OriginalName("ErrBuffComponentNotExist")]
		ErrBuffComponentNotExist,
		// Token: 0x0400B7CC RID: 47052
		[OriginalName("ErrOrderApplyBuffFailed")]
		ErrOrderApplyBuffFailed,
		// Token: 0x0400B7CD RID: 47053
		[OriginalName("ErrPlayerBuff")]
		ErrPlayerBuff,
		// Token: 0x0400B7CE RID: 47054
		[OriginalName("ErrFindPathNoEndPos")]
		ErrFindPathNoEndPos,
		// Token: 0x0400B7CF RID: 47055
		[OriginalName("ErrNotGetCurRole")]
		ErrNotGetCurRole,
		// Token: 0x0400B7D0 RID: 47056
		[OriginalName("ErrFindPathFailed")]
		ErrFindPathFailed,
		// Token: 0x0400B7D1 RID: 47057
		[OriginalName("ErrEntityFsmMachineNotExist")]
		ErrEntityFsmMachineNotExist = 1700000,
		// Token: 0x0400B7D2 RID: 47058
		[OriginalName("ErrEntityFsmStateIncorrect")]
		ErrEntityFsmStateIncorrect,
		// Token: 0x0400B7D3 RID: 47059
		[OriginalName("ErrIsNotAiControler")]
		ErrIsNotAiControler,
		// Token: 0x0400B7D4 RID: 47060
		[OriginalName("ErrIEntityFsmCantTransit")]
		ErrIentityFsmCantTransit,
		// Token: 0x0400B7D5 RID: 47061
		[OriginalName("ErrIEntityFsmTransitCondition")]
		ErrIentityFsmTransitCondition,
		// Token: 0x0400B7D6 RID: 47062
		[OriginalName("ErrIEntityFsmTransitToState")]
		ErrIentityFsmTransitToState,
		// Token: 0x0400B7D7 RID: 47063
		[OriginalName("ErrIEntityFsmConfirmNotExist")]
		ErrIentityFsmConfirmNotExist,
		// Token: 0x0400B7D8 RID: 47064
		[OriginalName("ErrIEntityFsmConfirmNotWait")]
		ErrIentityFsmConfirmNotWait,
		// Token: 0x0400B7D9 RID: 47065
		[OriginalName("ErrITest")]
		ErrItest,
		// Token: 0x0400B7DA RID: 47066
		[OriginalName("ErrITest1")]
		ErrItest1,
		// Token: 0x0400B7DB RID: 47067
		[OriginalName("ErrITest2")]
		ErrItest2,
		// Token: 0x0400B7DC RID: 47068
		[OriginalName("ErrIEntityFsmCondCantPass")]
		ErrIentityFsmCondCantPass,
		// Token: 0x0400B7DD RID: 47069
		[OriginalName("ErrIEntityFsmActionParamType")]
		ErrIentityFsmActionParamType,
		// Token: 0x0400B7DE RID: 47070
		[OriginalName("ErrIEntityFsmActionParam")]
		ErrIentityFsmActionParam,
		// Token: 0x0400B7DF RID: 47071
		[OriginalName("ErrIEntityFsmActionExecuted")]
		ErrIentityFsmActionExecuted,
		// Token: 0x0400B7E0 RID: 47072
		[OriginalName("ErrIEntityFsmActionNotMatchState")]
		ErrIentityFsmActionNotMatchState,
		// Token: 0x0400B7E1 RID: 47073
		[OriginalName("ErrSkillNotExecuting")]
		ErrSkillNotExecuting,
		// Token: 0x0400B7E2 RID: 47074
		[OriginalName("ErrExecuteSkillNotMatch")]
		ErrExecuteSkillNotMatch,
		// Token: 0x0400B7E3 RID: 47075
		[OriginalName("ErrBlueprintPinNotSupport")]
		ErrBlueprintPinNotSupport,
		// Token: 0x0400B7E4 RID: 47076
		[OriginalName("ErrBlueprintPinNotMontage")]
		ErrBlueprintPinNotMontage,
		// Token: 0x0400B7E5 RID: 47077
		[OriginalName("ErrBlueprintPinMontageIndex")]
		ErrBlueprintPinMontageIndex,
		// Token: 0x0400B7E6 RID: 47078
		[OriginalName("ErrConfSkillNotExist")]
		ErrConfSkillNotExist,
		// Token: 0x0400B7E7 RID: 47079
		[OriginalName("ErrSkillGANotExist")]
		ErrSkillGanotExist,
		// Token: 0x0400B7E8 RID: 47080
		[OriginalName("ErrSkillGAHaveNoBuff")]
		ErrSkillGahaveNoBuff,
		// Token: 0x0400B7E9 RID: 47081
		[OriginalName("ErrSkillGAHaveNoBuffId")]
		ErrSkillGahaveNoBuffId,
		// Token: 0x0400B7EA RID: 47082
		[OriginalName("ErrSkillGAHaveNoBullet")]
		ErrSkillGahaveNoBullet,
		// Token: 0x0400B7EB RID: 47083
		[OriginalName("ErrSkillGAHaveNoBulletId")]
		ErrSkillGahaveNoBulletId,
		// Token: 0x0400B7EC RID: 47084
		[OriginalName("ErrMontageNotMatchSkill")]
		ErrMontageNotMatchSkill,
		// Token: 0x0400B7ED RID: 47085
		[OriginalName("ErrMontageIndexError")]
		ErrMontageIndexError,
		// Token: 0x0400B7EE RID: 47086
		[OriginalName("ErrVisiionSkillNotEquip")]
		ErrVisiionSkillNotEquip,
		// Token: 0x0400B7EF RID: 47087
		[OriginalName("ErrSkillCD")]
		ErrSkillCd,
		// Token: 0x0400B7F0 RID: 47088
		[OriginalName("ErrHaveNoBattleContext")]
		ErrHaveNoBattleContext,
		// Token: 0x0400B7F1 RID: 47089
		[OriginalName("ErrContextFsmActionOnce")]
		ErrContextFsmActionOnce,
		// Token: 0x0400B7F2 RID: 47090
		[OriginalName("ErrPlayMontageButNoSkill")]
		ErrPlayMontageButNoSkill,
		// Token: 0x0400B7F3 RID: 47091
		[OriginalName("ErrMontageNotExist")]
		ErrMontageNotExist,
		// Token: 0x0400B7F4 RID: 47092
		[OriginalName("ErrMontageNotContainBuff")]
		ErrMontageNotContainBuff,
		// Token: 0x0400B7F5 RID: 47093
		[OriginalName("ErrMontageNotContainBullet")]
		ErrMontageNotContainBullet,
		// Token: 0x0400B7F6 RID: 47094
		[OriginalName("ErrMontageCantBring")]
		ErrMontageCantBring,
		// Token: 0x0400B7F7 RID: 47095
		[OriginalName("ErrSkillInfoParamError")]
		ErrSkillInfoParamError,
		// Token: 0x0400B7F8 RID: 47096
		[OriginalName("ErrNoWorldTeam")]
		ErrNoWorldTeam = 1800000,
		// Token: 0x0400B7F9 RID: 47097
		[OriginalName("ErrWorldTeamNoMember")]
		ErrWorldTeamNoMember,
		// Token: 0x0400B7FA RID: 47098
		[OriginalName("ErrNoHostIs")]
		ErrNoHostIs,
		// Token: 0x0400B7FB RID: 47099
		[OriginalName("ErrNoInstId")]
		ErrNoInstId,
		// Token: 0x0400B7FC RID: 47100
		[OriginalName("ErrNoTeamInfo")]
		ErrNoTeamInfo,
		// Token: 0x0400B7FD RID: 47101
		[OriginalName("ErrHostNoTeamInfo")]
		ErrHostNoTeamInfo,
		// Token: 0x0400B7FE RID: 47102
		[OriginalName("ErrHasInMatchTeam")]
		ErrHasInMatchTeam,
		// Token: 0x0400B7FF RID: 47103
		[OriginalName("ErrNotInMatchTeam")]
		ErrNotInMatchTeam,
		// Token: 0x0400B800 RID: 47104
		[OriginalName("ErrHostIsParam")]
		ErrHostIsParam,
		// Token: 0x0400B801 RID: 47105
		[OriginalName("ErrMatchModeIParam")]
		ErrMatchModeIparam,
		// Token: 0x0400B802 RID: 47106
		[OriginalName("ErrMatchTeamFull")]
		ErrMatchTeamFull,
		// Token: 0x0400B803 RID: 47107
		[OriginalName("ErrLocalTeamCanNotOpt")]
		ErrLocalTeamCanNotOpt,
		// Token: 0x0400B804 RID: 47108
		[OriginalName("ErrHostInLocalTeam")]
		ErrHostInLocalTeam,
		// Token: 0x0400B805 RID: 47109
		[OriginalName("ErrNoMatchNodeId")]
		ErrNoMatchNodeId,
		// Token: 0x0400B806 RID: 47110
		[OriginalName("ErrPlayerSceneIsNull")]
		ErrPlayerSceneIsNull,
		// Token: 0x0400B807 RID: 47111
		[OriginalName("ErrPlayerSceneRolesNull")]
		ErrPlayerSceneRolesNull,
		// Token: 0x0400B808 RID: 47112
		[OriginalName("ErrInvalidMatchState")]
		ErrInvalidMatchState,
		// Token: 0x0400B809 RID: 47113
		[OriginalName("ErrRepeatedMatchState")]
		ErrRepeatedMatchState,
		// Token: 0x0400B80A RID: 47114
		[OriginalName("ErrApplyrPlayerInMatchNotEnterMatchTeam")]
		ErrApplyrPlayerInMatchNotEnterMatchTeam,
		// Token: 0x0400B80B RID: 47115
		[OriginalName("ErrOtherVersionLowNoOperate")]
		ErrOtherVersionLowNoOperate,
		// Token: 0x0400B80C RID: 47116
		[OriginalName("ErrPlayerVersionLowNeedUpdate")]
		ErrPlayerVersionLowNeedUpdate,
		// Token: 0x0400B80D RID: 47117
		[OriginalName("ErrMultiGameModeNoWorldLevelDown")]
		ErrMultiGameModeNoWorldLevelDown,
		// Token: 0x0400B80E RID: 47118
		[OriginalName("ErrMultiGameModeNoWorldLevelRegain")]
		ErrMultiGameModeNoWorldLevelRegain,
		// Token: 0x0400B80F RID: 47119
		[OriginalName("ErrOtherHasOnline")]
		ErrOtherHasOnline,
		// Token: 0x0400B810 RID: 47120
		[OriginalName("SwitchRoleNotInCurrentFormation")]
		SwitchRoleNotInCurrentFormation,
		// Token: 0x0400B811 RID: 47121
		[OriginalName("ErrNoChangeRoles")]
		ErrNoChangeRoles,
		// Token: 0x0400B812 RID: 47122
		[OriginalName("ErrExploreSkillPullGiantMultiGame")]
		ErrExploreSkillPullGiantMultiGame,
		// Token: 0x0400B813 RID: 47123
		[OriginalName("ErrExploreSkillPullGiantNotExist")]
		ErrExploreSkillPullGiantNotExist,
		// Token: 0x0400B814 RID: 47124
		[OriginalName("ErrHttpRpcParam")]
		ErrHttpRpcParam,
		// Token: 0x0400B815 RID: 47125
		[OriginalName("ErrPlayerNotInGameNode")]
		ErrPlayerNotInGameNode,
		// Token: 0x0400B816 RID: 47126
		[OriginalName("ErrApplyJoinPlayerCurRoleIsDead")]
		ErrApplyJoinPlayerCurRoleIsDead,
		// Token: 0x0400B817 RID: 47127
		[OriginalName("ErrPlayerCurRoleIsDeadNoJoin")]
		ErrPlayerCurRoleIsDeadNoJoin,
		// Token: 0x0400B818 RID: 47128
		[OriginalName("ErrPlayerCurRoleIsDead")]
		ErrPlayerCurRoleIsDead,
		// Token: 0x0400B819 RID: 47129
		[OriginalName("ErrSwitchMultiverse")]
		ErrSwitchMultiverse,
		// Token: 0x0400B81A RID: 47130
		[OriginalName("ErrSwitchNode")]
		ErrSwitchNode,
		// Token: 0x0400B81B RID: 47131
		[OriginalName("ErrMatchConfirmPlayerDead")]
		ErrMatchConfirmPlayerDead,
		// Token: 0x0400B81C RID: 47132
		[OriginalName("ErrCheckPublicResourceVersionLower")]
		ErrCheckPublicResourceVersionLower,
		// Token: 0x0400B81D RID: 47133
		[OriginalName("ErrCheckPublicResourceVersionHigher")]
		ErrCheckPublicResourceVersionHigher,
		// Token: 0x0400B81E RID: 47134
		[OriginalName("ErrCheckPublicResourceClientVersionErr")]
		ErrCheckPublicResourceClientVersionErr,
		// Token: 0x0400B81F RID: 47135
		[OriginalName("ErrCheckPublicResourceServerVersionErr")]
		ErrCheckPublicResourceServerVersionErr,
		// Token: 0x0400B820 RID: 47136
		[OriginalName("ErrCheckPublicResourceClientVersionParamErr")]
		ErrCheckPublicResourceClientVersionParamErr,
		// Token: 0x0400B821 RID: 47137
		[OriginalName("ErrCheckClientVersionNeedUpdate")]
		ErrCheckClientVersionNeedUpdate,
		// Token: 0x0400B822 RID: 47138
		[OriginalName("ErrBranchNameNotMatch")]
		ErrBranchNameNotMatch,
		// Token: 0x0400B823 RID: 47139
		[OriginalName("ErrMatchRpcAlready")]
		ErrMatchRpcAlready,
		// Token: 0x0400B824 RID: 47140
		[OriginalName("ErrOtherPlayerEnterHost")]
		ErrOtherPlayerEnterHost,
		// Token: 0x0400B825 RID: 47141
		[OriginalName("ErrPlayerEnterHost")]
		ErrPlayerEnterHost,
		// Token: 0x0400B826 RID: 47142
		[OriginalName("ErrLevelPlayChangeSprotModeInMutile")]
		ErrLevelPlayChangeSprotModeInMutile,
		// Token: 0x0400B827 RID: 47143
		[OriginalName("ErrMatchingNotInvite")]
		ErrMatchingNotInvite,
		// Token: 0x0400B828 RID: 47144
		[OriginalName("ErrEnableFunctionFB")]
		ErrEnableFunctionFb,
		// Token: 0x0400B829 RID: 47145
		[OriginalName("ErrMatchSelectTrialRole")]
		ErrMatchSelectTrialRole,
		// Token: 0x0400B82A RID: 47146
		[OriginalName("ErrNoFindLastBigScene")]
		ErrNoFindLastBigScene,
		// Token: 0x0400B82B RID: 47147
		[OriginalName("ErrExploreSkillCustomMultiGame")]
		ErrExploreSkillCustomMultiGame,
		// Token: 0x0400B82C RID: 47148
		[OriginalName("ErrExploreSkillCustomNotExist")]
		ErrExploreSkillCustomNotExist,
		// Token: 0x0400B82D RID: 47149
		[OriginalName("ErrMatchInviteMemberDead")]
		ErrMatchInviteMemberDead,
		// Token: 0x0400B82E RID: 47150
		[OriginalName("ErrMatchAcceptInviteMemberDead")]
		ErrMatchAcceptInviteMemberDead,
		// Token: 0x0400B82F RID: 47151
		[OriginalName("ErrNoFishBoat")]
		ErrNoFishBoat,
		// Token: 0x0400B830 RID: 47152
		[OriginalName("ErrTemplateNotExists")]
		ErrTemplateNotExists,
		// Token: 0x0400B831 RID: 47153
		[OriginalName("ErrDisableSubLevels")]
		ErrDisableSubLevels = 1800058,
		// Token: 0x0400B832 RID: 47154
		[OriginalName("ErrSubLevelsClientNoPermission")]
		ErrSubLevelsClientNoPermission,
		// Token: 0x0400B833 RID: 47155
		[OriginalName("ErrExploreSkillCustomNoActions")]
		ErrExploreSkillCustomNoActions = 1800057,
		// Token: 0x0400B834 RID: 47156
		[OriginalName("ErrMatchClientVersion")]
		ErrMatchClientVersion = 1800060,
		// Token: 0x0400B835 RID: 47157
		[OriginalName("ErrCurNodeIsTainted")]
		ErrCurNodeIsTainted,
		// Token: 0x0400B836 RID: 47158
		[OriginalName("ErrTeamMateNodeIsTainted")]
		ErrTeamMateNodeIsTainted,
		// Token: 0x0400B837 RID: 47159
		[OriginalName("ErrMapFuctionNotOpen")]
		ErrMapFuctionNotOpen,
		// Token: 0x0400B838 RID: 47160
		[OriginalName("ErrNotSceneOwner")]
		ErrNotSceneOwner,
		// Token: 0x0400B839 RID: 47161
		[OriginalName("ErrLevelPlayUiListIsNull")]
		ErrLevelPlayUiListIsNull,
		// Token: 0x0400B83A RID: 47162
		[OriginalName("ErrOpenLevelPlayNotClientUi")]
		ErrOpenLevelPlayNotClientUi,
		// Token: 0x0400B83B RID: 47163
		[OriginalName("ErrOpenLevelPlayFailed")]
		ErrOpenLevelPlayFailed,
		// Token: 0x0400B83C RID: 47164
		[OriginalName("ErrBlackSwordChallengeId")]
		ErrBlackSwordChallengeId,
		// Token: 0x0400B83D RID: 47165
		[OriginalName("ErrCalabashLevelRequest")]
		ErrCalabashLevelRequest = 1900000,
		// Token: 0x0400B83E RID: 47166
		[OriginalName("ErrCalabashLevelRewardDone")]
		ErrCalabashLevelRewardDone,
		// Token: 0x0400B83F RID: 47167
		[OriginalName("ErrCalabashLevelConfig")]
		ErrCalabashLevelConfig,
		// Token: 0x0400B840 RID: 47168
		[OriginalName("ErrSkillTreeActiveConsume")]
		ErrSkillTreeActiveConsume,
		// Token: 0x0400B841 RID: 47169
		[OriginalName("ErrLoadFriendData")]
		ErrLoadFriendData,
		// Token: 0x0400B842 RID: 47170
		[OriginalName("ErrNoLoadPrivateChatData")]
		ErrNoLoadPrivateChatData,
		// Token: 0x0400B843 RID: 47171
		[OriginalName("ErrNotInWolrd")]
		ErrNotInWolrd,
		// Token: 0x0400B844 RID: 47172
		[OriginalName("ErrNotInGround")]
		ErrNotInGround,
		// Token: 0x0400B845 RID: 47173
		[OriginalName("ErrInFighting")]
		ErrInFighting,
		// Token: 0x0400B846 RID: 47174
		[OriginalName("ErrNotHaveCountryAccess")]
		ErrNotHaveCountryAccess,
		// Token: 0x0400B847 RID: 47175
		[OriginalName("ErrSkillIsEffect")]
		ErrSkillIsEffect,
		// Token: 0x0400B848 RID: 47176
		[OriginalName("ErrNoSoundBox")]
		ErrNoSoundBox,
		// Token: 0x0400B849 RID: 47177
		[OriginalName("ErrConsumeNotEnough")]
		ErrConsumeNotEnough,
		// Token: 0x0400B84A RID: 47178
		[OriginalName("ErrExploreSkillCountLimit")]
		ErrExploreSkillCountLimit,
		// Token: 0x0400B84B RID: 47179
		[OriginalName("ErrLegalAreaNoTreasureBox")]
		ErrLegalAreaNoTreasureBox,
		// Token: 0x0400B84C RID: 47180
		[OriginalName("ErrTreasureBoxAllActive")]
		ErrTreasureBoxAllActive,
		// Token: 0x0400B84D RID: 47181
		[OriginalName("ExploreProgressNoCountry")]
		ExploreProgressNoCountry,
		// Token: 0x0400B84E RID: 47182
		[OriginalName("ExploreProgressNoScoreCfg")]
		ExploreProgressNoScoreCfg,
		// Token: 0x0400B84F RID: 47183
		[OriginalName("ExploreProgressLackProgress")]
		ExploreProgressLackProgress,
		// Token: 0x0400B850 RID: 47184
		[OriginalName("ExploreProgressRewardDone")]
		ExploreProgressRewardDone,
		// Token: 0x0400B851 RID: 47185
		[OriginalName("ExploreProgressNoArea")]
		ExploreProgressNoArea,
		// Token: 0x0400B852 RID: 47186
		[OriginalName("ExploreToolNotConfirm")]
		ExploreToolNotConfirm,
		// Token: 0x0400B853 RID: 47187
		[OriginalName("ExploreToolNotOpen")]
		ExploreToolNotOpen,
		// Token: 0x0400B854 RID: 47188
		[OriginalName("ErrTreasureBoxPlaceFail")]
		ErrTreasureBoxPlaceFail,
		// Token: 0x0400B855 RID: 47189
		[OriginalName("ErrTreasureBoxData")]
		ErrTreasureBoxData,
		// Token: 0x0400B856 RID: 47190
		[OriginalName("ErrPayShopBuyCondition")]
		ErrPayShopBuyCondition,
		// Token: 0x0400B857 RID: 47191
		[OriginalName("ErrGatherActivityData")]
		ErrGatherActivityData,
		// Token: 0x0400B858 RID: 47192
		[OriginalName("ErrGatherTaskNoFinish")]
		ErrGatherTaskNoFinish,
		// Token: 0x0400B859 RID: 47193
		[OriginalName("ErrHadGatherReward")]
		ErrHadGatherReward,
		// Token: 0x0400B85A RID: 47194
		[OriginalName("ErrHadGetSharedReward")]
		ErrHadGetSharedReward,
		// Token: 0x0400B85B RID: 47195
		[OriginalName("ErrSharedPlat")]
		ErrSharedPlat,
		// Token: 0x0400B85C RID: 47196
		[OriginalName("ErrTowerTargetComplete")]
		ErrTowerTargetComplete,
		// Token: 0x0400B85D RID: 47197
		[OriginalName("ErrTowerGuideRewardHad")]
		ErrTowerGuideRewardHad,
		// Token: 0x0400B85E RID: 47198
		[OriginalName("ErrTowerGuideNoOpen")]
		ErrTowerGuideNoOpen,
		// Token: 0x0400B85F RID: 47199
		[OriginalName("ErrTowerGuideConfig")]
		ErrTowerGuideConfig,
		// Token: 0x0400B860 RID: 47200
		[OriginalName("ErrNewBieCourseConfig")]
		ErrNewBieCourseConfig,
		// Token: 0x0400B861 RID: 47201
		[OriginalName("ErrNewBieCourseRewardHad")]
		ErrNewBieCourseRewardHad,
		// Token: 0x0400B862 RID: 47202
		[OriginalName("ErrNewBieCourseLevel")]
		ErrNewBieCourseLevel,
		// Token: 0x0400B863 RID: 47203
		[OriginalName("ErrDetectionTargetSilence")]
		ErrDetectionTargetSilence,
		// Token: 0x0400B864 RID: 47204
		[OriginalName("ErrRoleTrialNotInit")]
		ErrRoleTrialNotInit,
		// Token: 0x0400B865 RID: 47205
		[OriginalName("ErrRoleTrialNoFinish")]
		ErrRoleTrialNoFinish,
		// Token: 0x0400B866 RID: 47206
		[OriginalName("ErrRoleTrialReward")]
		ErrRoleTrialReward,
		// Token: 0x0400B867 RID: 47207
		[OriginalName("ErrRoleTrialRewardDone")]
		ErrRoleTrialRewardDone,
		// Token: 0x0400B868 RID: 47208
		[OriginalName("ErrAdventureTaskReward")]
		ErrAdventureTaskReward,
		// Token: 0x0400B869 RID: 47209
		[OriginalName("ErrChapterReward")]
		ErrChapterReward,
		// Token: 0x0400B86A RID: 47210
		[OriginalName("ErrSilentFirstPassStatus")]
		ErrSilentFirstPassStatus,
		// Token: 0x0400B86B RID: 47211
		[OriginalName("ErrSilentFirstPassReward")]
		ErrSilentFirstPassReward,
		// Token: 0x0400B86C RID: 47212
		[OriginalName("ErrPayShopEchoRole")]
		ErrPayShopEchoRole,
		// Token: 0x0400B86D RID: 47213
		[OriginalName("ErrPayShopEchoItemOver")]
		ErrPayShopEchoItemOver,
		// Token: 0x0400B86E RID: 47214
		[OriginalName("ErrDailyAdventureActivityInit")]
		ErrDailyAdventureActivityInit,
		// Token: 0x0400B86F RID: 47215
		[OriginalName("ErrDailyAdventureActivityPtEnough")]
		ErrDailyAdventureActivityPtEnough,
		// Token: 0x0400B870 RID: 47216
		[OriginalName("ErrDailyAdventureActivityRewardDone")]
		ErrDailyAdventureActivityRewardDone,
		// Token: 0x0400B871 RID: 47217
		[OriginalName("ErrDailyAdventureActivityRewardTake")]
		ErrDailyAdventureActivityRewardTake,
		// Token: 0x0400B872 RID: 47218
		[OriginalName("ErrDailyAdventureActivityTaskDone")]
		ErrDailyAdventureActivityTaskDone,
		// Token: 0x0400B873 RID: 47219
		[OriginalName("ErrRoleTrialTimeOut")]
		ErrRoleTrialTimeOut,
		// Token: 0x0400B874 RID: 47220
		[OriginalName("ErrFriendRemarkNull")]
		ErrFriendRemarkNull,
		// Token: 0x0400B875 RID: 47221
		[OriginalName("ErrTrackMoonRoleUnLock")]
		ErrTrackMoonRoleUnLock,
		// Token: 0x0400B876 RID: 47222
		[OriginalName("ErrTrackMoonTrigger")]
		ErrTrackMoonTrigger,
		// Token: 0x0400B877 RID: 47223
		[OriginalName("ErrTrackMoonBuildingUnLock")]
		ErrTrackMoonBuildingUnLock,
		// Token: 0x0400B878 RID: 47224
		[OriginalName("ErrTrackMoonBuildingCurve")]
		ErrTrackMoonBuildingCurve,
		// Token: 0x0400B879 RID: 47225
		[OriginalName("ErrTrackMoonBuildingLock")]
		ErrTrackMoonBuildingLock,
		// Token: 0x0400B87A RID: 47226
		[OriginalName("ErrMoonEntrustCfg")]
		ErrMoonEntrustCfg,
		// Token: 0x0400B87B RID: 47227
		[OriginalName("ErrMoonRoleCfg")]
		ErrMoonRoleCfg,
		// Token: 0x0400B87C RID: 47228
		[OriginalName("ErrMoonRoleTrailCurve")]
		ErrMoonRoleTrailCurve,
		// Token: 0x0400B87D RID: 47229
		[OriginalName("ErrMoonBuildingCfg")]
		ErrMoonBuildingCfg,
		// Token: 0x0400B87E RID: 47230
		[OriginalName("ErrMoonItemConsume")]
		ErrMoonItemConsume,
		// Token: 0x0400B87F RID: 47231
		[OriginalName("ErrDirtyWordDeserialize")]
		ErrDirtyWordDeserialize,
		// Token: 0x0400B880 RID: 47232
		[OriginalName("ErrMoonTargetNoFinish")]
		ErrMoonTargetNoFinish,
		// Token: 0x0400B881 RID: 47233
		[OriginalName("ErrMoonActivityReward")]
		ErrMoonActivityReward,
		// Token: 0x0400B882 RID: 47234
		[OriginalName("ErrMoonActivityOpen")]
		ErrMoonActivityOpen,
		// Token: 0x0400B883 RID: 47235
		[OriginalName("ErrCircumDoReward")]
		ErrCircumDoReward,
		// Token: 0x0400B884 RID: 47236
		[OriginalName("ErrRetrunRewardCfg")]
		ErrRetrunRewardCfg,
		// Token: 0x0400B885 RID: 47237
		[OriginalName("ErrRetrunRewardLevel")]
		ErrRetrunRewardLevel,
		// Token: 0x0400B886 RID: 47238
		[OriginalName("ErrRetrunHaddone")]
		ErrRetrunHaddone,
		// Token: 0x0400B887 RID: 47239
		[OriginalName("ErrSignRewardCfg")]
		ErrSignRewardCfg,
		// Token: 0x0400B888 RID: 47240
		[OriginalName("ErrCircumSignHadRwd")]
		ErrCircumSignHadRwd,
		// Token: 0x0400B889 RID: 47241
		[OriginalName("ErrCircumNoSign")]
		ErrCircumNoSign,
		// Token: 0x0400B88A RID: 47242
		[OriginalName("ErrScoreRewardCfg")]
		ErrScoreRewardCfg,
		// Token: 0x0400B88B RID: 47243
		[OriginalName("ErrCircumScoreHadRwd")]
		ErrCircumScoreHadRwd,
		// Token: 0x0400B88C RID: 47244
		[OriginalName("ErrCircumScoreLack")]
		ErrCircumScoreLack,
		// Token: 0x0400B88D RID: 47245
		[OriginalName("ErrCircumTaskNoFinish")]
		ErrCircumTaskNoFinish,
		// Token: 0x0400B88E RID: 47246
		[OriginalName("LoginServiceInvalidToken")]
		LoginServiceInvalidToken,
		// Token: 0x0400B88F RID: 47247
		[OriginalName("LoginFusing")]
		LoginFusing,
		// Token: 0x0400B890 RID: 47248
		[OriginalName("LoginRateLimiterRejected")]
		LoginRateLimiterRejected,
		// Token: 0x0400B891 RID: 47249
		[OriginalName("LoginTimeoutRejected")]
		LoginTimeoutRejected,
		// Token: 0x0400B892 RID: 47250
		[OriginalName("AccountInputErr")]
		AccountInputErr,
		// Token: 0x0400B893 RID: 47251
		[OriginalName("DevInvalidLoginType")]
		DevInvalidLoginType,
		// Token: 0x0400B894 RID: 47252
		[OriginalName("GARInvalidLoginType")]
		GarinvalidLoginType,
		// Token: 0x0400B895 RID: 47253
		[OriginalName("GARDevInvalidLoginType")]
		GardevInvalidLoginType,
		// Token: 0x0400B896 RID: 47254
		[OriginalName("SdkserverTimeOut")]
		SdkserverTimeOut,
		// Token: 0x0400B897 RID: 47255
		[OriginalName("ReconnectInvalidOperation")]
		ReconnectInvalidOperation,
		// Token: 0x0400B898 RID: 47256
		[OriginalName("PbMessageAppVersionNotMatch")]
		PbMessageAppVersionNotMatch,
		// Token: 0x0400B899 RID: 47257
		[OriginalName("ErrPluginReconnectIpWhiteList")]
		ErrPluginReconnectIpWhiteList,
		// Token: 0x0400B89A RID: 47258
		[OriginalName("NotInUserIdWhiteListWithChannel")]
		NotInUserIdWhiteListWithChannel,
		// Token: 0x0400B89B RID: 47259
		[OriginalName("ErrPluginReconnectChannelWhiteList")]
		ErrPluginReconnectChannelWhiteList,
		// Token: 0x0400B89C RID: 47260
		[OriginalName("PluginPlayerLoggingIn")]
		PluginPlayerLoggingIn,
		// Token: 0x0400B89D RID: 47261
		[OriginalName("LoginFusing2")]
		LoginFusing2,
		// Token: 0x0400B89E RID: 47262
		[OriginalName("SoundBoxExploreFull")]
		SoundBoxExploreFull,
		// Token: 0x0400B89F RID: 47263
		[OriginalName("ErrMoonEntrustNoData")]
		ErrMoonEntrustNoData,
		// Token: 0x0400B8A0 RID: 47264
		[OriginalName("ErrMoonMoneyNotEnough")]
		ErrMoonMoneyNotEnough,
		// Token: 0x0400B8A1 RID: 47265
		[OriginalName("ErrCircumFluenceTimeIn")]
		ErrCircumFluenceTimeIn,
		// Token: 0x0400B8A2 RID: 47266
		[OriginalName("DragonPoolRewardWayErr")]
		DragonPoolRewardWayErr,
		// Token: 0x0400B8A3 RID: 47267
		[OriginalName("DragonPoolNoHandIn")]
		DragonPoolNoHandIn,
		// Token: 0x0400B8A4 RID: 47268
		[OriginalName("WeaponSkinNoEquiped")]
		WeaponSkinNoEquiped,
		// Token: 0x0400B8A5 RID: 47269
		[OriginalName("WeaponSkinDataErr")]
		WeaponSkinDataErr,
		// Token: 0x0400B8A6 RID: 47270
		[OriginalName("WeaponSkinUnLockErr")]
		WeaponSkinUnLockErr,
		// Token: 0x0400B8A7 RID: 47271
		[OriginalName("WeaponSkinEquipDone")]
		WeaponSkinEquipDone,
		// Token: 0x0400B8A8 RID: 47272
		[OriginalName("WeaponSkinTypeErr")]
		WeaponSkinTypeErr,
		// Token: 0x0400B8A9 RID: 47273
		[OriginalName("FriendOfflineMsgErr")]
		FriendOfflineMsgErr,
		// Token: 0x0400B8AA RID: 47274
		[OriginalName("FindSpringSignConfigErr")]
		FindSpringSignConfigErr,
		// Token: 0x0400B8AB RID: 47275
		[OriginalName("SpringSignDataErr")]
		SpringSignDataErr,
		// Token: 0x0400B8AC RID: 47276
		[OriginalName("SpringSignRewardDone")]
		SpringSignRewardDone,
		// Token: 0x0400B8AD RID: 47277
		[OriginalName("SpringSignRewardGetErr")]
		SpringSignRewardGetErr,
		// Token: 0x0400B8AE RID: 47278
		[OriginalName("SpringSignNoOpen")]
		SpringSignNoOpen,
		// Token: 0x0400B8AF RID: 47279
		[OriginalName("SpringSignNoTask")]
		SpringSignNoTask,
		// Token: 0x0400B8B0 RID: 47280
		[OriginalName("SpringSignInviteNum")]
		SpringSignInviteNum,
		// Token: 0x0400B8B1 RID: 47281
		[OriginalName("SpringSignRolePool")]
		SpringSignRolePool,
		// Token: 0x0400B8B2 RID: 47282
		[OriginalName("SpringSignDrawPoolNull")]
		SpringSignDrawPoolNull,
		// Token: 0x0400B8B3 RID: 47283
		[OriginalName("FarmGoldActivityNotOpen")]
		FarmGoldActivityNotOpen,
		// Token: 0x0400B8B4 RID: 47284
		[OriginalName("FarmGoldActivityPointReceived")]
		FarmGoldActivityPointReceived,
		// Token: 0x0400B8B5 RID: 47285
		[OriginalName("FarmGoldActivityPointNotConfig")]
		FarmGoldActivityPointNotConfig,
		// Token: 0x0400B8B6 RID: 47286
		[OriginalName("FarmGoldActivityPointNotEnough")]
		FarmGoldActivityPointNotEnough,
		// Token: 0x0400B8B7 RID: 47287
		[OriginalName("FarmGoldActivityLevelNoData")]
		FarmGoldActivityLevelNoData,
		// Token: 0x0400B8B8 RID: 47288
		[OriginalName("FarmGoldActivityLevelReceived")]
		FarmGoldActivityLevelReceived,
		// Token: 0x0400B8B9 RID: 47289
		[OriginalName("FarmGoldActivityLevelNotConfig")]
		FarmGoldActivityLevelNotConfig,
		// Token: 0x0400B8BA RID: 47290
		[OriginalName("FarmGoldActivityLevelDiffNotConfig")]
		FarmGoldActivityLevelDiffNotConfig,
		// Token: 0x0400B8BB RID: 47291
		[OriginalName("FarmGoldInstIdInValid")]
		FarmGoldInstIdInValid,
		// Token: 0x0400B8BC RID: 47292
		[OriginalName("FarmGoldVarNotExist")]
		FarmGoldVarNotExist,
		// Token: 0x0400B8BD RID: 47293
		[OriginalName("FarmGoldResultCacheNotExist")]
		FarmGoldResultCacheNotExist,
		// Token: 0x0400B8BE RID: 47294
		[OriginalName("FarmGoldInstNotOpen")]
		FarmGoldInstNotOpen,
		// Token: 0x0400B8BF RID: 47295
		[OriginalName("FarmGoldActivityLimitDataNotFind")]
		FarmGoldActivityLimitDataNotFind,
		// Token: 0x0400B8C0 RID: 47296
		[OriginalName("MapTravelDataErr")]
		MapTravelDataErr,
		// Token: 0x0400B8C1 RID: 47297
		[OriginalName("MapTravelConfigErr")]
		MapTravelConfigErr,
		// Token: 0x0400B8C2 RID: 47298
		[OriginalName("MapTravelCannotReward")]
		MapTravelCannotReward,
		// Token: 0x0400B8C3 RID: 47299
		[OriginalName("MapTravelRewardGet")]
		MapTravelRewardGet,
		// Token: 0x0400B8C4 RID: 47300
		[OriginalName("MapTravelMaxLevel")]
		MapTravelMaxLevel,
		// Token: 0x0400B8C5 RID: 47301
		[OriginalName("MapTravelLackExp")]
		MapTravelLackExp,
		// Token: 0x0400B8C6 RID: 47302
		[OriginalName("FarmGoldLevelNotOpen")]
		FarmGoldLevelNotOpen,
		// Token: 0x0400B8C7 RID: 47303
		[OriginalName("MapTravelAreaLock")]
		MapTravelAreaLock,
		// Token: 0x0400B8C8 RID: 47304
		[OriginalName("MapTravelAreaConfigErr")]
		MapTravelAreaConfigErr,
		// Token: 0x0400B8C9 RID: 47305
		[OriginalName("SlashAndTowerCacheErr")]
		SlashAndTowerCacheErr = 1900142,
		// Token: 0x0400B8CA RID: 47306
		[OriginalName("SlashAndTowerConfigErr")]
		SlashAndTowerConfigErr,
		// Token: 0x0400B8CB RID: 47307
		[OriginalName("SlashAndTowerDataErr")]
		SlashAndTowerDataErr,
		// Token: 0x0400B8CC RID: 47308
		[OriginalName("SlashAndTowerReceivedLevelAward")]
		SlashAndTowerReceivedLevelAward,
		// Token: 0x0400B8CD RID: 47309
		[OriginalName("SlashAndTowerNotReward")]
		SlashAndTowerNotReward,
		// Token: 0x0400B8CE RID: 47310
		[OriginalName("SlashAndTowerRoleNum")]
		SlashAndTowerRoleNum,
		// Token: 0x0400B8CF RID: 47311
		[OriginalName("SlashAndTowerBuffNum")]
		SlashAndTowerBuffNum,
		// Token: 0x0400B8D0 RID: 47312
		[OriginalName("SlashAndTowerBuffConfig")]
		SlashAndTowerBuffConfig,
		// Token: 0x0400B8D1 RID: 47313
		[OriginalName("SlashAndTowerBuffAccess")]
		SlashAndTowerBuffAccess,
		// Token: 0x0400B8D2 RID: 47314
		[OriginalName("SlashAndTowerRoleSame")]
		SlashAndTowerRoleSame,
		// Token: 0x0400B8D3 RID: 47315
		[OriginalName("SlashAndTowerSeasonErr")]
		SlashAndTowerSeasonErr,
		// Token: 0x0400B8D4 RID: 47316
		[OriginalName("SlashAndTowerBuffLack")]
		SlashAndTowerBuffLack,
		// Token: 0x0400B8D5 RID: 47317
		[OriginalName("MapTravelLevelUpCfgErr")]
		MapTravelLevelUpCfgErr = 1900140,
		// Token: 0x0400B8D6 RID: 47318
		[OriginalName("MapTravelLevelCfgErr")]
		MapTravelLevelCfgErr,
		// Token: 0x0400B8D7 RID: 47319
		[OriginalName("TeamParkOurTaskCfgErr")]
		TeamParkOurTaskCfgErr = 1900154,
		// Token: 0x0400B8D8 RID: 47320
		[OriginalName("TeamParkOurDataErr")]
		TeamParkOurDataErr,
		// Token: 0x0400B8D9 RID: 47321
		[OriginalName("TeamParkOurCfgNoMatch")]
		TeamParkOurCfgNoMatch,
		// Token: 0x0400B8DA RID: 47322
		[OriginalName("TeamParkOurTaskDoing")]
		TeamParkOurTaskDoing,
		// Token: 0x0400B8DB RID: 47323
		[OriginalName("TeamParkOurTaskTaken")]
		TeamParkOurTaskTaken,
		// Token: 0x0400B8DC RID: 47324
		[OriginalName("TeamParkOurLevelLock")]
		TeamParkOurLevelLock,
		// Token: 0x0400B8DD RID: 47325
		[OriginalName("TeamParkOurFindNoLevel")]
		TeamParkOurFindNoLevel,
		// Token: 0x0400B8DE RID: 47326
		[OriginalName("SlashAndTowerRewardErr")]
		SlashAndTowerRewardErr,
		// Token: 0x0400B8DF RID: 47327
		[OriginalName("SlashAndTowerBuffSeasonErr")]
		SlashAndTowerBuffSeasonErr,
		// Token: 0x0400B8E0 RID: 47328
		[OriginalName("SlashAndTowerNotOpen")]
		SlashAndTowerNotOpen,
		// Token: 0x0400B8E1 RID: 47329
		[OriginalName("SlashAndTowerSeasonToCfgErr")]
		SlashAndTowerSeasonToCfgErr,
		// Token: 0x0400B8E2 RID: 47330
		[OriginalName("SlashAndTowerSeasonNoUpdate")]
		SlashAndTowerSeasonNoUpdate,
		// Token: 0x0400B8E3 RID: 47331
		[OriginalName("SlashAndTowerFirstNoPass")]
		SlashAndTowerFirstNoPass,
		// Token: 0x0400B8E4 RID: 47332
		[OriginalName("SlashAndTowerLevelErr")]
		SlashAndTowerLevelErr,
		// Token: 0x0400B8E5 RID: 47333
		[OriginalName("TeamParkMemberErr")]
		TeamParkMemberErr,
		// Token: 0x0400B8E6 RID: 47334
		[OriginalName("AvignonNotOpen")]
		AvignonNotOpen = 1900172,
		// Token: 0x0400B8E7 RID: 47335
		[OriginalName("AvignonNotConfig")]
		AvignonNotConfig,
		// Token: 0x0400B8E8 RID: 47336
		[OriginalName("AvignonTaskNotFinish")]
		AvignonTaskNotFinish,
		// Token: 0x0400B8E9 RID: 47337
		[OriginalName("AvignonTaskNotData")]
		AvignonTaskNotData,
		// Token: 0x0400B8EA RID: 47338
		[OriginalName("AvignonHadReward")]
		AvignonHadReward,
		// Token: 0x0400B8EB RID: 47339
		[OriginalName("SlashAndTowerTeamErr")]
		SlashAndTowerTeamErr = 1900169,
		// Token: 0x0400B8EC RID: 47340
		[OriginalName("SlashAndTowerBuffErr")]
		SlashAndTowerBuffErr,
		// Token: 0x0400B8ED RID: 47341
		[OriginalName("SeasonTowerNoMatch")]
		SeasonTowerNoMatch,
		// Token: 0x0400B8EE RID: 47342
		[OriginalName("TeamParkOurMemberErr")]
		TeamParkOurMemberErr = 1900177,
		// Token: 0x0400B8EF RID: 47343
		[OriginalName("BattlePassRewardDone")]
		BattlePassRewardDone,
		// Token: 0x0400B8F0 RID: 47344
		[OriginalName("SlashAndTowerAwardCfgErr")]
		SlashAndTowerAwardCfgErr,
		// Token: 0x0400B8F1 RID: 47345
		[OriginalName("NoFlySkinItem")]
		NoFlySkinItem,
		// Token: 0x0400B8F2 RID: 47346
		[OriginalName("FlySkinHadWear")]
		FlySkinHadWear,
		// Token: 0x0400B8F3 RID: 47347
		[OriginalName("NoOldFlySkinItem")]
		NoOldFlySkinItem,
		// Token: 0x0400B8F4 RID: 47348
		[OriginalName("OldFlySkinNoWear")]
		OldFlySkinNoWear,
		// Token: 0x0400B8F5 RID: 47349
		[OriginalName("RoleWearNoFlySkin")]
		RoleWearNoFlySkin,
		// Token: 0x0400B8F6 RID: 47350
		[OriginalName("FlySkinParaGliderNoOpen")]
		FlySkinParaGliderNoOpen,
		// Token: 0x0400B8F7 RID: 47351
		[OriginalName("FlySkinSoaringWingNoOpen")]
		FlySkinSoaringWingNoOpen,
		// Token: 0x0400B8F8 RID: 47352
		[OriginalName("NoRoleWearFlySkinSucc")]
		NoRoleWearFlySkinSucc,
		// Token: 0x0400B8F9 RID: 47353
		[OriginalName("FlySkinItemNoConfig")]
		FlySkinItemNoConfig,
		// Token: 0x0400B8FA RID: 47354
		[OriginalName("SlashAndTowerLevelSettle")]
		SlashAndTowerLevelSettle,
		// Token: 0x0400B8FB RID: 47355
		[OriginalName("FlySkinTypeErr")]
		FlySkinTypeErr,
		// Token: 0x0400B8FC RID: 47356
		[OriginalName("FlySkinTrialRole")]
		FlySkinTrialRole,
		// Token: 0x0400B8FD RID: 47357
		[OriginalName("RegreeNotOpen")]
		RegreeNotOpen,
		// Token: 0x0400B8FE RID: 47358
		[OriginalName("RegressNoConfig")]
		RegressNoConfig,
		// Token: 0x0400B8FF RID: 47359
		[OriginalName("RegressWrongId")]
		RegressWrongId,
		// Token: 0x0400B900 RID: 47360
		[OriginalName("NoRegressRoundData")]
		NoRegressRoundData,
		// Token: 0x0400B901 RID: 47361
		[OriginalName("NotInRegress")]
		NotInRegress,
		// Token: 0x0400B902 RID: 47362
		[OriginalName("AskRewardNoFinish")]
		AskRewardNoFinish,
		// Token: 0x0400B903 RID: 47363
		[OriginalName("BirthdayNotArrived")]
		BirthdayNotArrived,
		// Token: 0x0400B904 RID: 47364
		[OriginalName("BirthdayRoleInvalid")]
		BirthdayRoleInvalid,
		// Token: 0x0400B905 RID: 47365
		[OriginalName("BirthdayNoCfg")]
		BirthdayNoCfg,
		// Token: 0x0400B906 RID: 47366
		[OriginalName("HadBirthDayReward")]
		HadBirthDayReward,
		// Token: 0x0400B907 RID: 47367
		[OriginalName("BirthdayNoReset")]
		BirthdayNoReset,
		// Token: 0x0400B908 RID: 47368
		[OriginalName("BirthDayRewardTimeInvalid")]
		BirthDayRewardTimeInvalid,
		// Token: 0x0400B909 RID: 47369
		[OriginalName("BirthdayMustNowYear")]
		BirthdayMustNowYear,
		// Token: 0x0400B90A RID: 47370
		[OriginalName("BirthDayNotOpen")]
		BirthDayNotOpen,
		// Token: 0x0400B90B RID: 47371
		[OriginalName("BirthDayRewardNotFinish")]
		BirthDayRewardNotFinish,
		// Token: 0x0400B90C RID: 47372
		[OriginalName("BirthdayRoleDone")]
		BirthdayRoleDone,
		// Token: 0x0400B90D RID: 47373
		[OriginalName("MoraleNoRewardGet")]
		MoraleNoRewardGet,
		// Token: 0x0400B90E RID: 47374
		[OriginalName("FloroNoRanchData")]
		FloroNoRanchData,
		// Token: 0x0400B90F RID: 47375
		[OriginalName("FloroNoRanchTech")]
		FloroNoRanchTech,
		// Token: 0x0400B910 RID: 47376
		[OriginalName("FloroTechUnLock")]
		FloroTechUnLock,
		// Token: 0x0400B911 RID: 47377
		[OriginalName("FloroPreNodeLock")]
		FloroPreNodeLock,
		// Token: 0x0400B912 RID: 47378
		[OriginalName("FloroTechPoint")]
		FloroTechPoint,
		// Token: 0x0400B913 RID: 47379
		[OriginalName("FloroNoFindActivityTask")]
		FloroNoFindActivityTask,
		// Token: 0x0400B914 RID: 47380
		[OriginalName("FloroNoFindTaskCfg")]
		FloroNoFindTaskCfg,
		// Token: 0x0400B915 RID: 47381
		[OriginalName("FloroTaskIsRunning")]
		FloroTaskIsRunning,
		// Token: 0x0400B916 RID: 47382
		[OriginalName("FloroTaskInValidTime")]
		FloroTaskInValidTime,
		// Token: 0x0400B917 RID: 47383
		[OriginalName("FloroRewardDone")]
		FloroRewardDone,
		// Token: 0x0400B918 RID: 47384
		[OriginalName("FloroMilestoneNoFind")]
		FloroMilestoneNoFind,
		// Token: 0x0400B919 RID: 47385
		[OriginalName("FloroDropNoFind")]
		FloroDropNoFind,
		// Token: 0x0400B91A RID: 47386
		[OriginalName("FloroNoReward")]
		FloroNoReward,
		// Token: 0x0400B91B RID: 47387
		[OriginalName("FloroActivityParamErr")]
		FloroActivityParamErr,
		// Token: 0x0400B91C RID: 47388
		[OriginalName("ConditionTimeOut")]
		ConditionTimeOut,
		// Token: 0x0400B91D RID: 47389
		[OriginalName("ConditionModuleErr")]
		ConditionModuleErr,
		// Token: 0x0400B91E RID: 47390
		[OriginalName("ConditionGroupIdErr")]
		ConditionGroupIdErr,
		// Token: 0x0400B91F RID: 47391
		[OriginalName("ConditionRegisterFail")]
		ConditionRegisterFail,
		// Token: 0x0400B920 RID: 47392
		[OriginalName("FloroRanchSetAgain")]
		FloroRanchSetAgain,
		// Token: 0x0400B921 RID: 47393
		[OriginalName("MoonPhaseNoOpen")]
		MoonPhaseNoOpen,
		// Token: 0x0400B922 RID: 47394
		[OriginalName("MoonPhaseNoCount")]
		MoonPhaseNoCount,
		// Token: 0x0400B923 RID: 47395
		[OriginalName("ErrRandomDone")]
		ErrRandomDone,
		// Token: 0x0400B924 RID: 47396
		[OriginalName("PhaseMoonRandomErr")]
		PhaseMoonRandomErr,
		// Token: 0x0400B925 RID: 47397
		[OriginalName("PhaseMoonCfgErr")]
		PhaseMoonCfgErr,
		// Token: 0x0400B926 RID: 47398
		[OriginalName("MoonLabelErr")]
		MoonLabelErr,
		// Token: 0x0400B927 RID: 47399
		[OriginalName("MoonPhaseRewardErr")]
		MoonPhaseRewardErr,
		// Token: 0x0400B928 RID: 47400
		[OriginalName("MoonPhaseRewardDone")]
		MoonPhaseRewardDone,
		// Token: 0x0400B929 RID: 47401
		[OriginalName("PhaseMoonItemErr")]
		PhaseMoonItemErr,
		// Token: 0x0400B92A RID: 47402
		[OriginalName("MoonPhaseBuffFail")]
		MoonPhaseBuffFail,
		// Token: 0x0400B92B RID: 47403
		[OriginalName("CoopRoleMaxLevelErr")]
		CoopRoleMaxLevelErr,
		// Token: 0x0400B92C RID: 47404
		[OriginalName("CoopRoleNoUnLock")]
		CoopRoleNoUnLock,
		// Token: 0x0400B92D RID: 47405
		[OriginalName("CoopRoleSpRewradErr")]
		CoopRoleSpRewradErr,
		// Token: 0x0400B92E RID: 47406
		[OriginalName("CoopRoleRewardErr")]
		CoopRoleRewardErr,
		// Token: 0x0400B92F RID: 47407
		[OriginalName("NoRewardCanGain")]
		NoRewardCanGain,
		// Token: 0x0400B930 RID: 47408
		[OriginalName("CoopRoleDataErr")]
		CoopRoleDataErr,
		// Token: 0x0400B931 RID: 47409
		[OriginalName("CoopIdErr")]
		CoopIdErr,
		// Token: 0x0400B932 RID: 47410
		[OriginalName("MotorcycleMotorIpErr")]
		MotorcycleMotorIpErr,
		// Token: 0x0400B933 RID: 47411
		[OriginalName("MotorcycleRewardEmpty")]
		MotorcycleRewardEmpty,
		// Token: 0x0400B934 RID: 47412
		[OriginalName("RoadBookNotData")]
		RoadBookNotData,
		// Token: 0x0400B935 RID: 47413
		[OriginalName("RoadBookNotInOpen")]
		RoadBookNotInOpen,
		// Token: 0x0400B936 RID: 47414
		[OriginalName("RoadBookTaskCannotReward")]
		RoadBookTaskCannotReward,
		// Token: 0x0400B937 RID: 47415
		[OriginalName("RoadBookRewardHad")]
		RoadBookRewardHad,
		// Token: 0x0400B938 RID: 47416
		[OriginalName("RoadBookOverMaxLevel")]
		RoadBookOverMaxLevel,
		// Token: 0x0400B939 RID: 47417
		[OriginalName("RoadBookCfgErr")]
		RoadBookCfgErr,
		// Token: 0x0400B93A RID: 47418
		[OriginalName("RoadBookTaskLock")]
		RoadBookTaskLock,
		// Token: 0x0400B93B RID: 47419
		[OriginalName("RoadBookChallengeScoreErr")]
		RoadBookChallengeScoreErr,
		// Token: 0x0400B93C RID: 47420
		[OriginalName("RoadBookDuplicateReward")]
		RoadBookDuplicateReward,
		// Token: 0x0400B93D RID: 47421
		[OriginalName("RoadBookNoRewardGet")]
		RoadBookNoRewardGet,
		// Token: 0x0400B93E RID: 47422
		[OriginalName("GuessJokerLevelErr")]
		GuessJokerLevelErr,
		// Token: 0x0400B93F RID: 47423
		[OriginalName("GuessJokerNotInScene")]
		GuessJokerNotInScene,
		// Token: 0x0400B940 RID: 47424
		[OriginalName("GuessJokerNotGameObj")]
		GuessJokerNotGameObj,
		// Token: 0x0400B941 RID: 47425
		[OriginalName("GuessJokerPlayCardErr")]
		GuessJokerPlayCardErr,
		// Token: 0x0400B942 RID: 47426
		[OriginalName("GuessJokerActionPhaseErr")]
		GuessJokerActionPhaseErr,
		// Token: 0x0400B943 RID: 47427
		[OriginalName("GuessJokerDeckErr")]
		GuessJokerDeckErr,
		// Token: 0x0400B944 RID: 47428
		[OriginalName("GuessJokerNoHandCard")]
		GuessJokerNoHandCard,
		// Token: 0x0400B945 RID: 47429
		[OriginalName("GuessJokerBanCard")]
		GuessJokerBanCard,
		// Token: 0x0400B946 RID: 47430
		[OriginalName("GuessJokerOnlyPair")]
		GuessJokerOnlyPair,
		// Token: 0x0400B947 RID: 47431
		[OriginalName("GuessJokerPairAll")]
		GuessJokerPairAll,
		// Token: 0x0400B948 RID: 47432
		[OriginalName("GuessJokerCardRefuse")]
		GuessJokerCardRefuse,
		// Token: 0x0400B949 RID: 47433
		[OriginalName("GuessJokerDrawCardErr")]
		GuessJokerDrawCardErr,
		// Token: 0x0400B94A RID: 47434
		[OriginalName("JokerSkillTriggerFail")]
		JokerSkillTriggerFail,
		// Token: 0x0400B94B RID: 47435
		[OriginalName("JokerSkillNoConfig")]
		JokerSkillNoConfig,
		// Token: 0x0400B94C RID: 47436
		[OriginalName("JokerSkillOwnerErr")]
		JokerSkillOwnerErr,
		// Token: 0x0400B94D RID: 47437
		[OriginalName("GuessJokerPlayCardOver")]
		GuessJokerPlayCardOver,
		// Token: 0x0400B94E RID: 47438
		[OriginalName("GuessJokerPlayCardAgain")]
		GuessJokerPlayCardAgain,
		// Token: 0x0400B94F RID: 47439
		[OriginalName("JokerGuessLevelLock")]
		JokerGuessLevelLock,
		// Token: 0x0400B950 RID: 47440
		[OriginalName("JokerGuessPreLevelLock")]
		JokerGuessPreLevelLock,
		// Token: 0x0400B951 RID: 47441
		[OriginalName("GuessJokerInitErr")]
		GuessJokerInitErr,
		// Token: 0x0400B952 RID: 47442
		[OriginalName("NoDrinkRequireListConfig")]
		NoDrinkRequireListConfig,
		// Token: 0x0400B953 RID: 47443
		[OriginalName("DrinkBaseCountError")]
		DrinkBaseCountError,
		// Token: 0x0400B954 RID: 47444
		[OriginalName("DrinkBaseNoConfig")]
		DrinkBaseNoConfig,
		// Token: 0x0400B955 RID: 47445
		[OriginalName("DrinkBatchingCountErr")]
		DrinkBatchingCountErr,
		// Token: 0x0400B956 RID: 47446
		[OriginalName("DrinkBatchingConfigErr")]
		DrinkBatchingConfigErr,
		// Token: 0x0400B957 RID: 47447
		[OriginalName("DrinkOrnaNoConfig")]
		DrinkOrnaNoConfig,
		// Token: 0x0400B958 RID: 47448
		[OriginalName("DrinkRoleLikeNoConfig")]
		DrinkRoleLikeNoConfig,
		// Token: 0x0400B959 RID: 47449
		[OriginalName("DrinkLikePointErr")]
		DrinkLikePointErr,
		// Token: 0x0400B95A RID: 47450
		[OriginalName("GuessJokerScriptPlayErr")]
		GuessJokerScriptPlayErr,
		// Token: 0x0400B95B RID: 47451
		[OriginalName("GuessJokerScriptDrawErr")]
		GuessJokerScriptDrawErr,
		// Token: 0x0400B95C RID: 47452
		[OriginalName("GuessJokerNoPlayerWait")]
		GuessJokerNoPlayerWait,
		// Token: 0x0400B95D RID: 47453
		[OriginalName("GuessJokerSkillUseOver")]
		GuessJokerSkillUseOver,
		// Token: 0x0400B95E RID: 47454
		[OriginalName("DrinkBatchingRepeate")]
		DrinkBatchingRepeate,
		// Token: 0x0400B95F RID: 47455
		[OriginalName("SpringFestivalNoReward")]
		SpringFestivalNoReward,
		// Token: 0x0400B960 RID: 47456
		[OriginalName("SpringFestivalDropNoFind")]
		SpringFestivalDropNoFind,
		// Token: 0x0400B961 RID: 47457
		[OriginalName("SpringFestivalTaskRunning")]
		SpringFestivalTaskRunning,
		// Token: 0x0400B962 RID: 47458
		[OriginalName("SpringFestivalHadReward")]
		SpringFestivalHadReward,
		// Token: 0x0400B963 RID: 47459
		[OriginalName("SpringFestivalActivityIdErr")]
		SpringFestivalActivityIdErr,
		// Token: 0x0400B964 RID: 47460
		[OriginalName("SpringFestivalTaskFindErr")]
		SpringFestivalTaskFindErr,
		// Token: 0x0400B965 RID: 47461
		[OriginalName("SpringFestivalNoActivityCfg")]
		SpringFestivalNoActivityCfg,
		// Token: 0x0400B966 RID: 47462
		[OriginalName("SpringFestivalParamCountErr")]
		SpringFestivalParamCountErr,
		// Token: 0x0400B967 RID: 47463
		[OriginalName("SpringFestivalParamAgainErr")]
		SpringFestivalParamAgainErr,
		// Token: 0x0400B968 RID: 47464
		[OriginalName("PayShopGoodsIdRepeatErr")]
		PayShopGoodsIdRepeatErr,
		// Token: 0x0400B969 RID: 47465
		[OriginalName("PayShopBindActivityErr")]
		PayShopBindActivityErr,
		// Token: 0x0400B96A RID: 47466
		[OriginalName("PayShopActivityFromErr")]
		PayShopActivityFromErr,
		// Token: 0x0400B96B RID: 47467
		[OriginalName("PayShopFromErr")]
		PayShopFromErr,
		// Token: 0x0400B96C RID: 47468
		[OriginalName("ErrPayShopGoodsTypeCountOverFlow")]
		ErrPayShopGoodsTypeCountOverFlow,
		// Token: 0x0400B96D RID: 47469
		[OriginalName("ErrPayShopTotalCountOverFlow")]
		ErrPayShopTotalCountOverFlow,
		// Token: 0x0400B96E RID: 47470
		[OriginalName("ErrRegressDevelopTask")]
		ErrRegressDevelopTask,
		// Token: 0x0400B96F RID: 47471
		[OriginalName("ErrRegressVersion")]
		ErrRegressVersion,
		// Token: 0x0400B970 RID: 47472
		[OriginalName("DrinksLevelLock")]
		DrinksLevelLock,
		// Token: 0x0400B971 RID: 47473
		[OriginalName("DrinksRoleInviteErr")]
		DrinksRoleInviteErr,
		// Token: 0x0400B972 RID: 47474
		[OriginalName("DrinksNoRoleData")]
		DrinksNoRoleData,
		// Token: 0x0400B973 RID: 47475
		[OriginalName("GuessJokerTraceOver")]
		GuessJokerTraceOver,
		// Token: 0x0400B974 RID: 47476
		[OriginalName("GuessJokerDataErr")]
		GuessJokerDataErr,
		// Token: 0x0400B975 RID: 47477
		[OriginalName("GuessJokerTaskRunning")]
		GuessJokerTaskRunning,
		// Token: 0x0400B976 RID: 47478
		[OriginalName("GuessJokerTaskDone")]
		GuessJokerTaskDone,
		// Token: 0x0400B977 RID: 47479
		[OriginalName("DrinksRewardTaskRunning")]
		DrinksRewardTaskRunning,
		// Token: 0x0400B978 RID: 47480
		[OriginalName("DrinksRewardTaskDone")]
		DrinksRewardTaskDone,
		// Token: 0x0400B979 RID: 47481
		[OriginalName("CoopReqLenthOver")]
		CoopReqLenthOver,
		// Token: 0x0400B97A RID: 47482
		[OriginalName("CoopRewardIdErr")]
		CoopRewardIdErr,
		// Token: 0x0400B97B RID: 47483
		[OriginalName("CoopRewardConfigNotFind")]
		CoopRewardConfigNotFind,
		// Token: 0x0400B97C RID: 47484
		[OriginalName("CoopRewardDiff")]
		CoopRewardDiff,
		// Token: 0x0400B97D RID: 47485
		[OriginalName("CoopActivityDataErr")]
		CoopActivityDataErr,
		// Token: 0x0400B97E RID: 47486
		[OriginalName("CoopRewardDone")]
		CoopRewardDone,
		// Token: 0x0400B97F RID: 47487
		[OriginalName("CoopRewardNoFinish")]
		CoopRewardNoFinish,
		// Token: 0x0400B980 RID: 47488
		[OriginalName("CoopItemDropErr")]
		CoopItemDropErr,
		// Token: 0x0400B981 RID: 47489
		[OriginalName("CoopItemDropErr2")]
		CoopItemDropErr2,
		// Token: 0x0400B982 RID: 47490
		[OriginalName("PinballParamLimitOver")]
		PinballParamLimitOver,
		// Token: 0x0400B983 RID: 47491
		[OriginalName("PinballTaskConfigLoss")]
		PinballTaskConfigLoss,
		// Token: 0x0400B984 RID: 47492
		[OriginalName("PinballActivityErr")]
		PinballActivityErr,
		// Token: 0x0400B985 RID: 47493
		[OriginalName("PinballActivityHadReward")]
		PinballActivityHadReward,
		// Token: 0x0400B986 RID: 47494
		[OriginalName("PinballActivityTaskRunning")]
		PinballActivityTaskRunning,
		// Token: 0x0400B987 RID: 47495
		[OriginalName("PinballActivityTaskDropNoFind")]
		PinballActivityTaskDropNoFind,
		// Token: 0x0400B988 RID: 47496
		[OriginalName("PinballActivityTaskParamAgainErr")]
		PinballActivityTaskParamAgainErr,
		// Token: 0x0400B989 RID: 47497
		[OriginalName("PinballActivityTaskNoReward")]
		PinballActivityTaskNoReward,
		// Token: 0x0400B98A RID: 47498
		[OriginalName("PinballRoleAddLevelErr")]
		PinballRoleAddLevelErr,
		// Token: 0x0400B98B RID: 47499
		[OriginalName("PinballRoleConfigLoss")]
		PinballRoleConfigLoss,
		// Token: 0x0400B98C RID: 47500
		[OriginalName("PinballRoleDataLoss")]
		PinballRoleDataLoss,
		// Token: 0x0400B98D RID: 47501
		[OriginalName("PinballRoleDataMaxLvLoss")]
		PinballRoleDataMaxLvLoss,
		// Token: 0x0400B98E RID: 47502
		[OriginalName("PinballRoleMaxLvErr")]
		PinballRoleMaxLvErr,
		// Token: 0x0400B98F RID: 47503
		[OriginalName("PinballActivityConfigLoss")]
		PinballActivityConfigLoss,
		// Token: 0x0400B990 RID: 47504
		[OriginalName("PinballRoleExpItemLack")]
		PinballRoleExpItemLack,
		// Token: 0x0400B991 RID: 47505
		[OriginalName("PinballWeaponIsTrail")]
		PinballWeaponIsTrail,
		// Token: 0x0400B992 RID: 47506
		[OriginalName("PinballWeaponNoExist")]
		PinballWeaponNoExist,
		// Token: 0x0400B993 RID: 47507
		[OriginalName("PinballWeaponConfigNoExist")]
		PinballWeaponConfigNoExist,
		// Token: 0x0400B994 RID: 47508
		[OriginalName("PinballRoleNoExist")]
		PinballRoleNoExist,
		// Token: 0x0400B995 RID: 47509
		[OriginalName("PinballRoleConfigNoExist")]
		PinballRoleConfigNoExist,
		// Token: 0x0400B996 RID: 47510
		[OriginalName("PinballWeaponRoleMismatch")]
		PinballWeaponRoleMismatch,
		// Token: 0x0400B997 RID: 47511
		[OriginalName("PinballPersonWeaponChangeErr")]
		PinballPersonWeaponChangeErr,
		// Token: 0x0400B998 RID: 47512
		[OriginalName("PinballWearRepeat")]
		PinballWearRepeat,
		// Token: 0x0400B999 RID: 47513
		[OriginalName("PinballWeaponOverLimit")]
		PinballWeaponOverLimit,
		// Token: 0x0400B99A RID: 47514
		[OriginalName("PinballWeaponRepeat")]
		PinballWeaponRepeat,
		// Token: 0x0400B99B RID: 47515
		[OriginalName("PinballWeaponLock")]
		PinballWeaponLock,
		// Token: 0x0400B99C RID: 47516
		[OriginalName("PinballWeaponIsEquip")]
		PinballWeaponIsEquip,
		// Token: 0x0400B99D RID: 47517
		[OriginalName("PinballWeaponNoDel")]
		PinballWeaponNoDel,
		// Token: 0x0400B99E RID: 47518
		[OriginalName("ActivityRewardParamOver")]
		ActivityRewardParamOver,
		// Token: 0x0400B99F RID: 47519
		[OriginalName("ActivityNotSame")]
		ActivityNotSame,
		// Token: 0x0400B9A0 RID: 47520
		[OriginalName("ActivityRewardDropErr")]
		ActivityRewardDropErr,
		// Token: 0x0400B9A1 RID: 47521
		[OriginalName("ActivityNoRewardCanGet")]
		ActivityNoRewardCanGet,
		// Token: 0x0400B9A2 RID: 47522
		[OriginalName("ActivityTaskTimeErr")]
		ActivityTaskTimeErr,
		// Token: 0x0400B9A3 RID: 47523
		[OriginalName("ActivityTaskRewardRepeat")]
		ActivityTaskRewardRepeat,
		// Token: 0x0400B9A4 RID: 47524
		[OriginalName("ActivityDataNotFind")]
		ActivityDataNotFind,
		// Token: 0x0400B9A5 RID: 47525
		[OriginalName("PinballWeaponInitErr")]
		PinballWeaponInitErr,
		// Token: 0x0400B9A6 RID: 47526
		[OriginalName("PinballNoFriend")]
		PinballNoFriend,
		// Token: 0x0400B9A7 RID: 47527
		[OriginalName("PinballTowerRankCd")]
		PinballTowerRankCd,
		// Token: 0x0400B9A8 RID: 47528
		[OriginalName("PinballRankDataEmpty")]
		PinballRankDataEmpty,
		// Token: 0x0400B9A9 RID: 47529
		[OriginalName("PinballLevelLock")]
		PinballLevelLock,
		// Token: 0x0400B9AA RID: 47530
		[OriginalName("PinballDailyInstErr")]
		PinballDailyInstErr,
		// Token: 0x0400B9AB RID: 47531
		[OriginalName("PinballRoleNotOpen")]
		PinballRoleNotOpen,
		// Token: 0x0400B9AC RID: 47532
		[OriginalName("PinballDailyNotOpen")]
		PinballDailyNotOpen,
		// Token: 0x0400B9AD RID: 47533
		[OriginalName("PinballWeaponPersonMismatch")]
		PinballWeaponPersonMismatch,
		// Token: 0x0400B9AE RID: 47534
		[OriginalName("NoRoleVoiceDataSet")]
		NoRoleVoiceDataSet,
		// Token: 0x0400B9AF RID: 47535
		[OriginalName("RoleVoiceSettingParamOver")]
		RoleVoiceSettingParamOver,
		// Token: 0x0400B9B0 RID: 47536
		[OriginalName("RoleVoiceParamRepeat")]
		RoleVoiceParamRepeat,
		// Token: 0x0400B9B1 RID: 47537
		[OriginalName("PlayerUsingSkill")]
		PlayerUsingSkill,
		// Token: 0x0400B9B2 RID: 47538
		[OriginalName("PlayerClimbing")]
		PlayerClimbing,
		// Token: 0x0400B9B3 RID: 47539
		[OriginalName("PlayerInWater")]
		PlayerInWater,
		// Token: 0x0400B9B4 RID: 47540
		[OriginalName("PlayerInAir")]
		PlayerInAir,
		// Token: 0x0400B9B5 RID: 47541
		[OriginalName("OnlineMotorLevelLock")]
		OnlineMotorLevelLock,
		// Token: 0x0400B9B6 RID: 47542
		[OriginalName("OnlineMotorMemberErr")]
		OnlineMotorMemberErr,
		// Token: 0x0400B9B7 RID: 47543
		[OriginalName("OnlineMotorMemberActivityClose")]
		OnlineMotorMemberActivityClose,
		// Token: 0x0400B9B8 RID: 47544
		[OriginalName("RealmBetweenOverMaxLevel")]
		RealmBetweenOverMaxLevel,
		// Token: 0x0400B9B9 RID: 47545
		[OriginalName("ActivityTaskLock")]
		ActivityTaskLock,
		// Token: 0x0400B9BA RID: 47546
		[OriginalName("ErrRecallItemBagItemTypeNotSupport")]
		ErrRecallItemBagItemTypeNotSupport,
		// Token: 0x0400B9BB RID: 47547
		[OriginalName("ErrRecallItemBagFull")]
		ErrRecallItemBagFull,
		// Token: 0x0400B9BC RID: 47548
		[OriginalName("ActivityPlayingCanNotDissolve")]
		ActivityPlayingCanNotDissolve,
		// Token: 0x0400B9BD RID: 47549
		[OriginalName("ErrRecallActionNotSupport")]
		ErrRecallActionNotSupport,
		// Token: 0x0400B9BE RID: 47550
		[OriginalName("ErrAdventureSilentCtxNull")]
		ErrAdventureSilentCtxNull,
		// Token: 0x0400B9BF RID: 47551
		[OriginalName("ErrAdventureSilentId")]
		ErrAdventureSilentId,
		// Token: 0x0400B9C0 RID: 47552
		[OriginalName("RoverRogueTalentAlreadyUnlock")]
		RoverRogueTalentAlreadyUnlock,
		// Token: 0x0400B9C1 RID: 47553
		[OriginalName("RoverRoguePreTalentNotUnlock")]
		RoverRoguePreTalentNotUnlock,
		// Token: 0x0400B9C2 RID: 47554
		[OriginalName("RoverRogueTalentConditionNotFinish")]
		RoverRogueTalentConditionNotFinish,
		// Token: 0x0400B9C3 RID: 47555
		[OriginalName("ErrMailFavoriteCannotDelete")]
		ErrMailFavoriteCannotDelete,
		// Token: 0x0400B9C4 RID: 47556
		[OriginalName("ErrMailFavoriteNeedRead")]
		ErrMailFavoriteNeedRead,
		// Token: 0x0400B9C5 RID: 47557
		[OriginalName("ErrMailFavoriteNeedTake")]
		ErrMailFavoriteNeedTake,
		// Token: 0x0400B9C6 RID: 47558
		[OriginalName("ErrMailFavoriteFull")]
		ErrMailFavoriteFull,
		// Token: 0x0400B9C7 RID: 47559
		[OriginalName("ErrPhantomItemUse")]
		ErrPhantomItemUse,
		// Token: 0x0400B9C8 RID: 47560
		[OriginalName("ErrRoleTrailItemUse")]
		ErrRoleTrailItemUse,
		// Token: 0x0400B9C9 RID: 47561
		[OriginalName("ErrInFlowItemUse")]
		ErrInFlowItemUse,
		// Token: 0x0400B9CA RID: 47562
		[OriginalName("ErrInVehicleItemUse")]
		ErrInVehicleItemUse,
		// Token: 0x0400B9CB RID: 47563
		[OriginalName("ErrZitherNoMainRoleInFormation")]
		ErrZitherNoMainRoleInFormation,
		// Token: 0x0400B9CC RID: 47564
		[OriginalName("ErrTrialFollowShooterItemUse")]
		ErrTrialFollowShooterItemUse,
		// Token: 0x0400B9CD RID: 47565
		[OriginalName("ErrMainRoleVoiceRoleId")]
		ErrMainRoleVoiceRoleId,
		// Token: 0x0400B9CE RID: 47566
		[OriginalName("ErrTrackMoonNotInRecall")]
		ErrTrackMoonNotInRecall,
		// Token: 0x0400B9CF RID: 47567
		[OriginalName("MatchThreeRoleLock")]
		MatchThreeRoleLock,
		// Token: 0x0400B9D0 RID: 47568
		[OriginalName("ErrMatchThreeScoreInvalid")]
		ErrMatchThreeScoreInvalid,
		// Token: 0x0400B9D1 RID: 47569
		[OriginalName("ErrMatchThreeHourGlassInvalid")]
		ErrMatchThreeHourGlassInvalid,
		// Token: 0x0400B9D2 RID: 47570
		[OriginalName("ErrMatchThreeBottleInvalid")]
		ErrMatchThreeBottleInvalid,
		// Token: 0x0400B9D3 RID: 47571
		[OriginalName("ErrMatchThreeRecordTypeMismatch")]
		ErrMatchThreeRecordTypeMismatch,
		// Token: 0x0400B9D4 RID: 47572
		[OriginalName("CameraModeNotOpen")]
		CameraModeNotOpen,
		// Token: 0x0400B9D5 RID: 47573
		[OriginalName("ErrItemUseBanned")]
		ErrItemUseBanned,
		// Token: 0x0400B9D6 RID: 47574
		[OriginalName("ErrItemUseMainRoleDead")]
		ErrItemUseMainRoleDead,
		// Token: 0x0400B9D7 RID: 47575
		[OriginalName("ErrWaitingOtherJoinBanUse")]
		ErrWaitingOtherJoinBanUse,
		// Token: 0x0400B9D8 RID: 47576
		[OriginalName("ErrPhantomSelfPortrait")]
		ErrPhantomSelfPortrait,
		// Token: 0x0400B9D9 RID: 47577
		[OriginalName("ErrRoleTrailSelfPortrait")]
		ErrRoleTrailSelfPortrait,
		// Token: 0x0400B9DA RID: 47578
		[OriginalName("ErrPlayerStateSelfPortrait")]
		ErrPlayerStateSelfPortrait,
		// Token: 0x0400B9DB RID: 47579
		[OriginalName("ErrMainRoleDeadSelfPortrait")]
		ErrMainRoleDeadSelfPortrait,
		// Token: 0x0400B9DC RID: 47580
		[OriginalName("ErrInFlowSelfPortrait")]
		ErrInFlowSelfPortrait,
		// Token: 0x0400B9DD RID: 47581
		[OriginalName("ErrInVehicleSelfPortrait")]
		ErrInVehicleSelfPortrait,
		// Token: 0x0400B9DE RID: 47582
		[OriginalName("ErrMainRoleActiveSelfPortrait")]
		ErrMainRoleActiveSelfPortrait,
		// Token: 0x0400B9DF RID: 47583
		[OriginalName("ErrZitherItemUse")]
		ErrZitherItemUse,
		// Token: 0x0400B9E0 RID: 47584
		[OriginalName("InTeleportItemUse")]
		InTeleportItemUse,
		// Token: 0x0400B9E1 RID: 47585
		[OriginalName("IsMatchingItemUse")]
		IsMatchingItemUse,
		// Token: 0x0400B9E2 RID: 47586
		[OriginalName("InTeleportSelfPortrait")]
		InTeleportSelfPortrait,
		// Token: 0x0400B9E3 RID: 47587
		[OriginalName("IsMatchingSelfPortrait")]
		IsMatchingSelfPortrait,
		// Token: 0x0400B9E4 RID: 47588
		[OriginalName("ErrRecallItemUseFail")]
		ErrRecallItemUseFail = 1900460,
		// Token: 0x0400B9E5 RID: 47589
		[OriginalName("ErrRecallItemUseTypeNotSupport")]
		ErrRecallItemUseTypeNotSupport,
		// Token: 0x0400B9E6 RID: 47590
		[OriginalName("ErrRecallItemTypeNotSupport")]
		ErrRecallItemTypeNotSupport,
		// Token: 0x0400B9E7 RID: 47591
		[OriginalName("ErrRecallItemCountInvalid")]
		ErrRecallItemCountInvalid,
		// Token: 0x0400B9E8 RID: 47592
		[OriginalName("ErrRecallItemCanNotUse")]
		ErrRecallItemCanNotUse,
		// Token: 0x0400B9E9 RID: 47593
		[OriginalName("ErrWaitingOtherJoinSelfPortrait")]
		ErrWaitingOtherJoinSelfPortrait = 1900467,
		// Token: 0x0400B9EA RID: 47594
		[OriginalName("ErrDoCommonRewardConfigError")]
		ErrDoCommonRewardConfigError = 2000000,
		// Token: 0x0400B9EB RID: 47595
		[OriginalName("InstPlayNotSettle")]
		InstPlayNotSettle,
		// Token: 0x0400B9EC RID: 47596
		[OriginalName("InstPlayNotFinishExecute")]
		InstPlayNotFinishExecute,
		// Token: 0x0400B9ED RID: 47597
		[OriginalName("ErrResetItemEntityNotContain")]
		ErrResetItemEntityNotContain,
		// Token: 0x0400B9EE RID: 47598
		[OriginalName("InstPlayExchangeRewardNotExist")]
		InstPlayExchangeRewardNotExist,
		// Token: 0x0400B9EF RID: 47599
		[OriginalName("MapConfigNull")]
		MapConfigNull,
		// Token: 0x0400B9F0 RID: 47600
		[OriginalName("MapConfigError")]
		MapConfigError,
		// Token: 0x0400B9F1 RID: 47601
		[OriginalName("InstPlayComponentNotExist")]
		InstPlayComponentNotExist,
		// Token: 0x0400B9F2 RID: 47602
		[OriginalName("InstTeleportResetPlayerDead")]
		InstTeleportResetPlayerDead,
		// Token: 0x0400B9F3 RID: 47603
		[OriginalName("DrownEndTeleportInBigWorld")]
		DrownEndTeleportInBigWorld,
		// Token: 0x0400B9F4 RID: 47604
		[OriginalName("ErrFightTrialRoleRoldIdsError")]
		ErrFightTrialRoleRoldIdsError,
		// Token: 0x0400B9F5 RID: 47605
		[OriginalName("ErrFightTrialRoleFromationError")]
		ErrFightTrialRoleFromationError,
		// Token: 0x0400B9F6 RID: 47606
		[OriginalName("ErrInstSaveFail")]
		ErrInstSaveFail,
		// Token: 0x0400B9F7 RID: 47607
		[OriginalName("ErrActiveFoundationControlPlayerError")]
		ErrActiveFoundationControlPlayerError,
		// Token: 0x0400B9F8 RID: 47608
		[OriginalName("ErrActiveFoundationOccupation")]
		ErrActiveFoundationOccupation,
		// Token: 0x0400B9F9 RID: 47609
		[OriginalName("ErrSingleInstanceCanNotOnline")]
		ErrSingleInstanceCanNotOnline,
		// Token: 0x0400B9FA RID: 47610
		[OriginalName("ErrInstanceRechallengeLimit")]
		ErrInstanceRechallengeLimit,
		// Token: 0x0400B9FB RID: 47611
		[OriginalName("ErrTargetSame")]
		ErrTargetSame,
		// Token: 0x0400B9FC RID: 47612
		[OriginalName("ErrAttachTargetType")]
		ErrAttachTargetType,
		// Token: 0x0400B9FD RID: 47613
		[OriginalName("ErrAttachInfoNull")]
		ErrAttachInfoNull,
		// Token: 0x0400B9FE RID: 47614
		[OriginalName("ErrLevelPlayChallengeFail")]
		ErrLevelPlayChallengeFail,
		// Token: 0x0400B9FF RID: 47615
		[OriginalName("ErrGMTip")]
		ErrGmtip,
		// Token: 0x0400BA00 RID: 47616
		[OriginalName("ErrPosSenderEntityNoExist")]
		ErrPosSenderEntityNoExist,
		// Token: 0x0400BA01 RID: 47617
		[OriginalName("ErrPosSenderComponentNoExist")]
		ErrPosSenderComponentNoExist,
		// Token: 0x0400BA02 RID: 47618
		[OriginalName("ErrPosSenderParamError")]
		ErrPosSenderParamError,
		// Token: 0x0400BA03 RID: 47619
		[OriginalName("ErrPosSenderRemoveSenderNotSame")]
		ErrPosSenderRemoveSenderNotSame,
		// Token: 0x0400BA04 RID: 47620
		[OriginalName("ErrConnectorEntityNoExist")]
		ErrConnectorEntityNoExist,
		// Token: 0x0400BA05 RID: 47621
		[OriginalName("ErrConnectorCompNoExist")]
		ErrConnectorCompNoExist,
		// Token: 0x0400BA06 RID: 47622
		[OriginalName("ErrConnectorPreIdError")]
		ErrConnectorPreIdError,
		// Token: 0x0400BA07 RID: 47623
		[OriginalName("ErrConnectorCompleteState")]
		ErrConnectorCompleteState,
		// Token: 0x0400BA08 RID: 47624
		[OriginalName("ErrConnectorActiveStateError")]
		ErrConnectorActiveStateError,
		// Token: 0x0400BA09 RID: 47625
		[OriginalName("ErrConnectorMatchErro")]
		ErrConnectorMatchErro,
		// Token: 0x0400BA0A RID: 47626
		[OriginalName("ErrActiveControlOccupation")]
		ErrActiveControlOccupation,
		// Token: 0x0400BA0B RID: 47627
		[OriginalName("ErrPortalCreatorActive")]
		ErrPortalCreatorActive,
		// Token: 0x0400BA0C RID: 47628
		[OriginalName("ErrComponentNull")]
		ErrComponentNull,
		// Token: 0x0400BA0D RID: 47629
		[OriginalName("ErrPortalCreatorConfigError")]
		ErrPortalCreatorConfigError,
		// Token: 0x0400BA0E RID: 47630
		[OriginalName("ErrPortalCreatorCreateFail")]
		ErrPortalCreatorCreateFail,
		// Token: 0x0400BA0F RID: 47631
		[OriginalName("ErrTrialRoleEnterInst")]
		ErrTrialRoleEnterInst,
		// Token: 0x0400BA10 RID: 47632
		[OriginalName("ErrNpcInVehicle")]
		ErrNpcInVehicle,
		// Token: 0x0400BA11 RID: 47633
		[OriginalName("ErrSceneItemBBNotChange")]
		ErrSceneItemBbnotChange,
		// Token: 0x0400BA12 RID: 47634
		[OriginalName("ErrInitMatchNotSuccess")]
		ErrInitMatchNotSuccess,
		// Token: 0x0400BA13 RID: 47635
		[OriginalName("ErrFightFormationSameRoleError")]
		ErrFightFormationSameRoleError,
		// Token: 0x0400BA14 RID: 47636
		[OriginalName("ErrFightMainRoleConflict")]
		ErrFightMainRoleConflict,
		// Token: 0x0400BA15 RID: 47637
		[OriginalName("ErrVehicleItemConfigError")]
		ErrVehicleItemConfigError,
		// Token: 0x0400BA16 RID: 47638
		[OriginalName("ErrVehicleCreateError")]
		ErrVehicleCreateError,
		// Token: 0x0400BA17 RID: 47639
		[OriginalName("ErrVehicleEntityTypeError")]
		ErrVehicleEntityTypeError,
		// Token: 0x0400BA18 RID: 47640
		[OriginalName("ErrInstanceActivityExpire")]
		ErrInstanceActivityExpire,
		// Token: 0x0400BA19 RID: 47641
		[OriginalName("ErrSlashAndTowerLevelUnlock")]
		ErrSlashAndTowerLevelUnlock,
		// Token: 0x0400BA1A RID: 47642
		[OriginalName("ErrInstLevelUnlock")]
		ErrInstLevelUnlock,
		// Token: 0x0400BA1B RID: 47643
		[OriginalName("ErrEnterInstConfigError")]
		ErrEnterInstConfigError,
		// Token: 0x0400BA1C RID: 47644
		[OriginalName("ErrMoveWithSplineConfigError")]
		ErrMoveWithSplineConfigError,
		// Token: 0x0400BA1D RID: 47645
		[OriginalName("ErrMoveWithSplineIdError")]
		ErrMoveWithSplineIdError,
		// Token: 0x0400BA1E RID: 47646
		[OriginalName("ErrMoveWithSplineStop")]
		ErrMoveWithSplineStop,
		// Token: 0x0400BA1F RID: 47647
		[OriginalName("ErrMoveWithSplineEntityConfigError")]
		ErrMoveWithSplineEntityConfigError,
		// Token: 0x0400BA20 RID: 47648
		[OriginalName("ErrMoveWithSplineControlPlayerError")]
		ErrMoveWithSplineControlPlayerError,
		// Token: 0x0400BA21 RID: 47649
		[OriginalName("ErrLeaveSceneStarted")]
		ErrLeaveSceneStarted,
		// Token: 0x0400BA22 RID: 47650
		[OriginalName("ErrInstTeleportInstLimit")]
		ErrInstTeleportInstLimit,
		// Token: 0x0400BA23 RID: 47651
		[OriginalName("ErrGetOnVehicleNotInAoiSight")]
		ErrGetOnVehicleNotInAoiSight,
		// Token: 0x0400BA24 RID: 47652
		[OriginalName("ErrHoldHandCharacterNotCurrent")]
		ErrHoldHandCharacterNotCurrent,
		// Token: 0x0400BA25 RID: 47653
		[OriginalName("ErrEnterInstPreInstNotComplete")]
		ErrEnterInstPreInstNotComplete,
		// Token: 0x0400BA26 RID: 47654
		[OriginalName("ErrSetSystemVarError")]
		ErrSetSystemVarError,
		// Token: 0x0400BA27 RID: 47655
		[OriginalName("ErrSetVarPermission")]
		ErrSetVarPermission,
		// Token: 0x0400BA28 RID: 47656
		[OriginalName("ErrSetVarCtxError")]
		ErrSetVarCtxError,
		// Token: 0x0400BA29 RID: 47657
		[OriginalName("ErrSetVarGameCtxSceneError")]
		ErrSetVarGameCtxSceneError,
		// Token: 0x0400BA2A RID: 47658
		[OriginalName("ErrSetVarNotPublic")]
		ErrSetVarNotPublic,
		// Token: 0x0400BA2B RID: 47659
		[OriginalName("ErrSetVarComponent")]
		ErrSetVarComponent,
		// Token: 0x0400BA2C RID: 47660
		[OriginalName("ErrSetVarTargetNull")]
		ErrSetVarTargetNull,
		// Token: 0x0400BA2D RID: 47661
		[OriginalName("ErrVehicleNotMotor")]
		ErrVehicleNotMotor,
		// Token: 0x0400BA2E RID: 47662
		[OriginalName("ErrVehicleFormationError")]
		ErrVehicleFormationError,
		// Token: 0x0400BA2F RID: 47663
		[OriginalName("ErrShareRideConflict")]
		ErrShareRideConflict,
		// Token: 0x0400BA30 RID: 47664
		[OriginalName("ErrShareRideNotExist")]
		ErrShareRideNotExist,
		// Token: 0x0400BA31 RID: 47665
		[OriginalName("ErrNotInShareRide")]
		ErrNotInShareRide,
		// Token: 0x0400BA32 RID: 47666
		[OriginalName("ErrNotInVehicle")]
		ErrNotInVehicle,
		// Token: 0x0400BA33 RID: 47667
		[OriginalName("ErrSceneRoadGraphNotExist")]
		ErrSceneRoadGraphNotExist,
		// Token: 0x0400BA34 RID: 47668
		[OriginalName("ErrVehicleFlowRewardMax")]
		ErrVehicleFlowRewardMax,
		// Token: 0x0400BA35 RID: 47669
		[OriginalName("ErrGetOnVehicleFailInFlow")]
		ErrGetOnVehicleFailInFlow,
		// Token: 0x0400BA36 RID: 47670
		[OriginalName("ErrGetOnPlayerVechielGravityDifferent")]
		ErrGetOnPlayerVechielGravityDifferent,
		// Token: 0x0400BA37 RID: 47671
		[OriginalName("ErrChangeFightState")]
		ErrChangeFightState = 2100000,
		// Token: 0x0400BA38 RID: 47672
		[OriginalName("ErrAddFragileFail")]
		ErrAddFragileFail,
		// Token: 0x0400BA39 RID: 47673
		[OriginalName("ErrStoreEnergyClose")]
		ErrStoreEnergyClose,
		// Token: 0x0400BA3A RID: 47674
		[OriginalName("ErrAttrOverMax")]
		ErrAttrOverMax,
		// Token: 0x0400BA3B RID: 47675
		[OriginalName("ErrBattleVersion")]
		ErrBattleVersion,
		// Token: 0x0400BA3C RID: 47676
		[OriginalName("ErrGmkillEntityNotValid")]
		ErrGmkillEntityNotValid = 2200000,
		// Token: 0x0400BA3D RID: 47677
		[OriginalName("ErrSplineConfigNotExist")]
		ErrSplineConfigNotExist,
		// Token: 0x0400BA3E RID: 47678
		[OriginalName("BossRushActivityNotOpen")]
		BossRushActivityNotOpen,
		// Token: 0x0400BA3F RID: 47679
		[OriginalName("BossRushActivityScoreRewardNotExist")]
		BossRushActivityScoreRewardNotExist,
		// Token: 0x0400BA40 RID: 47680
		[OriginalName("BossRushActivityLevelRewardNotExist")]
		BossRushActivityLevelRewardNotExist,
		// Token: 0x0400BA41 RID: 47681
		[OriginalName("BossRushActivityScoreNotEnough")]
		BossRushActivityScoreNotEnough,
		// Token: 0x0400BA42 RID: 47682
		[OriginalName("BossRushActivityLevelNotPass")]
		BossRushActivityLevelNotPass,
		// Token: 0x0400BA43 RID: 47683
		[OriginalName("BossRushActivityRewardClaimed")]
		BossRushActivityRewardClaimed,
		// Token: 0x0400BA44 RID: 47684
		[OriginalName("BossRushActivityBuffSelectionNotValid")]
		BossRushActivityBuffSelectionNotValid,
		// Token: 0x0400BA45 RID: 47685
		[OriginalName("BossRushActivityConfigNotExist")]
		BossRushActivityConfigNotExist,
		// Token: 0x0400BA46 RID: 47686
		[OriginalName("BossRushActivityCharacterSelectionNotValid")]
		BossRushActivityCharacterSelectionNotValid,
		// Token: 0x0400BA47 RID: 47687
		[OriginalName("BossRushActivityComponentNotExist")]
		BossRushActivityComponentNotExist,
		// Token: 0x0400BA48 RID: 47688
		[OriginalName("BossRushActivityCharacterSelectionEmpty")]
		BossRushActivityCharacterSelectionEmpty,
		// Token: 0x0400BA49 RID: 47689
		[OriginalName("BossRushActivityBuffSelectionEmpty")]
		BossRushActivityBuffSelectionEmpty,
		// Token: 0x0400BA4A RID: 47690
		[OriginalName("BossRushActivityLevelNotOpen")]
		BossRushActivityLevelNotOpen,
		// Token: 0x0400BA4B RID: 47691
		[OriginalName("InRangeEntityDuplicate")]
		InRangeEntityDuplicate,
		// Token: 0x0400BA4C RID: 47692
		[OriginalName("InRangeEntityNotExist")]
		InRangeEntityNotExist,
		// Token: 0x0400BA4D RID: 47693
		[OriginalName("NpcPerformComponentNotExist")]
		NpcPerformComponentNotExist,
		// Token: 0x0400BA4E RID: 47694
		[OriginalName("NpcPerformStateNotInit")]
		NpcPerformStateNotInit,
		// Token: 0x0400BA4F RID: 47695
		[OriginalName("NpcPerformActionTargetEntityNotExist")]
		NpcPerformActionTargetEntityNotExist,
		// Token: 0x0400BA50 RID: 47696
		[OriginalName("ActionQueueTypeNotExist")]
		ActionQueueTypeNotExist,
		// Token: 0x0400BA51 RID: 47697
		[OriginalName("ActionQueueCtxTypeNotExist")]
		ActionQueueCtxTypeNotExist,
		// Token: 0x0400BA52 RID: 47698
		[OriginalName("ExecuteQueueOwnerHasAction")]
		ExecuteQueueOwnerHasAction,
		// Token: 0x0400BA53 RID: 47699
		[OriginalName("ActionQueueExceedMaxCount")]
		ActionQueueExceedMaxCount,
		// Token: 0x0400BA54 RID: 47700
		[OriginalName("ActionQueueStartActionGroupFail")]
		ActionQueueStartActionGroupFail,
		// Token: 0x0400BA55 RID: 47701
		[OriginalName("ActionQueueComponentNotExist")]
		ActionQueueComponentNotExist,
		// Token: 0x0400BA56 RID: 47702
		[OriginalName("ActionQueueNotInit")]
		ActionQueueNotInit,
		// Token: 0x0400BA57 RID: 47703
		[OriginalName("ChangeBatchEntitiesStateError")]
		ChangeBatchEntitiesStateError,
		// Token: 0x0400BA58 RID: 47704
		[OriginalName("EnableNearbyTrackingTargetEntityNotExist")]
		EnableNearbyTrackingTargetEntityNotExist,
		// Token: 0x0400BA59 RID: 47705
		[OriginalName("EnableNearbyTrackingSelfNotEntity")]
		EnableNearbyTrackingSelfNotEntity,
		// Token: 0x0400BA5A RID: 47706
		[OriginalName("EnableNearbyTrackingSelfComponentNotExist")]
		EnableNearbyTrackingSelfComponentNotExist,
		// Token: 0x0400BA5B RID: 47707
		[OriginalName("SetTeleControlEntityNotExist")]
		SetTeleControlEntityNotExist,
		// Token: 0x0400BA5C RID: 47708
		[OriginalName("SetTeleControlTypeNotExist")]
		SetTeleControlTypeNotExist,
		// Token: 0x0400BA5D RID: 47709
		[OriginalName("SetTeleControlComponentNotExist")]
		SetTeleControlComponentNotExist,
		// Token: 0x0400BA5E RID: 47710
		[OriginalName("SetTeleControlCoordEntityNotExist")]
		SetTeleControlCoordEntityNotExist,
		// Token: 0x0400BA5F RID: 47711
		[OriginalName("SceneItemAttributeIdNotInType")]
		SceneItemAttributeIdNotInType,
		// Token: 0x0400BA60 RID: 47712
		[OriginalName("SceneItemAttributeIdNotExist")]
		SceneItemAttributeIdNotExist,
		// Token: 0x0400BA61 RID: 47713
		[OriginalName("ModifySceneItemAttributeEntityNotExist")]
		ModifySceneItemAttributeEntityNotExist,
		// Token: 0x0400BA62 RID: 47714
		[OriginalName("AddSceneItemAttributeTagDuplicate")]
		AddSceneItemAttributeTagDuplicate,
		// Token: 0x0400BA63 RID: 47715
		[OriginalName("RemoveSceneItemAttributeTagNotExist")]
		RemoveSceneItemAttributeTagNotExist,
		// Token: 0x0400BA64 RID: 47716
		[OriginalName("AttributeEntityLock")]
		AttributeEntityLock,
		// Token: 0x0400BA65 RID: 47717
		[OriginalName("AttributeEntitySilent")]
		AttributeEntitySilent,
		// Token: 0x0400BA66 RID: 47718
		[OriginalName("ModifySceneItemAttributeTagNotExist")]
		ModifySceneItemAttributeTagNotExist,
		// Token: 0x0400BA67 RID: 47719
		[OriginalName("ErrEnterInstCtx")]
		ErrEnterInstCtx,
		// Token: 0x0400BA68 RID: 47720
		[OriginalName("ErrEnterInstBlackboardValueNotExist")]
		ErrEnterInstBlackboardValueNotExist,
		// Token: 0x0400BA69 RID: 47721
		[OriginalName("TriggerLocked")]
		TriggerLocked,
		// Token: 0x0400BA6A RID: 47722
		[OriginalName("TriggerIgnore")]
		TriggerIgnore,
		// Token: 0x0400BA6B RID: 47723
		[OriginalName("TriggerEntityNull")]
		TriggerEntityNull,
		// Token: 0x0400BA6C RID: 47724
		[OriginalName("TriggerEntityNotMatch")]
		TriggerEntityNotMatch,
		// Token: 0x0400BA6D RID: 47725
		[OriginalName("TriggerMatchCountNotMet")]
		TriggerMatchCountNotMet,
		// Token: 0x0400BA6E RID: 47726
		[OriginalName("TriggerActionEmpty")]
		TriggerActionEmpty,
		// Token: 0x0400BA6F RID: 47727
		[OriginalName("ExceedMaxTriggerCount")]
		ExceedMaxTriggerCount,
		// Token: 0x0400BA70 RID: 47728
		[OriginalName("TriggerAlreadyLeaveWhenEnterCondFail")]
		TriggerAlreadyLeaveWhenEnterCondFail,
		// Token: 0x0400BA71 RID: 47729
		[OriginalName("TriggerLeaveConfigEmpty")]
		TriggerLeaveConfigEmpty,
		// Token: 0x0400BA72 RID: 47730
		[OriginalName("TriggerConditionNotMet")]
		TriggerConditionNotMet,
		// Token: 0x0400BA73 RID: 47731
		[OriginalName("TriggerRangeRationalityFail")]
		TriggerRangeRationalityFail,
		// Token: 0x0400BA74 RID: 47732
		[OriginalName("TrampleEntityNotMatch")]
		TrampleEntityNotMatch,
		// Token: 0x0400BA75 RID: 47733
		[OriginalName("TrampleConditionNotMet")]
		TrampleConditionNotMet,
		// Token: 0x0400BA76 RID: 47734
		[OriginalName("TrampleMatchCountNotMet")]
		TrampleMatchCountNotMet,
		// Token: 0x0400BA77 RID: 47735
		[OriginalName("HasDestroySelfActionInQueue")]
		HasDestroySelfActionInQueue,
		// Token: 0x0400BA78 RID: 47736
		[OriginalName("EntityWillDestroy")]
		EntityWillDestroy,
		// Token: 0x0400BA79 RID: 47737
		[OriginalName("AddInRangePlayerDuplicate")]
		AddInRangePlayerDuplicate,
		// Token: 0x0400BA7A RID: 47738
		[OriginalName("AddInRangeEntityDuplicate")]
		AddInRangeEntityDuplicate,
		// Token: 0x0400BA7B RID: 47739
		[OriginalName("RemoveInRangePlayerNotExist")]
		RemoveInRangePlayerNotExist,
		// Token: 0x0400BA7C RID: 47740
		[OriginalName("RemoveInRangeEntityNotExist")]
		RemoveInRangeEntityNotExist,
		// Token: 0x0400BA7D RID: 47741
		[OriginalName("GravityDirectionNoChange")]
		GravityDirectionNoChange = 2200072,
		// Token: 0x0400BA7E RID: 47742
		[OriginalName("HookExitWayNotExist")]
		HookExitWayNotExist = 2200065,
		// Token: 0x0400BA7F RID: 47743
		[OriginalName("HookLockPointLocked")]
		HookLockPointLocked,
		// Token: 0x0400BA80 RID: 47744
		[OriginalName("HookLockAddPlayerDuplicate")]
		HookLockAddPlayerDuplicate,
		// Token: 0x0400BA81 RID: 47745
		[OriginalName("HookLockRemovePlayerNotExist")]
		HookLockRemovePlayerNotExist,
		// Token: 0x0400BA82 RID: 47746
		[OriginalName("KiteHookLockPointOnlyOnePlayer")]
		KiteHookLockPointOnlyOnePlayer,
		// Token: 0x0400BA83 RID: 47747
		[OriginalName("EffectAreaAddBuffFail")]
		EffectAreaAddBuffFail = 2200073,
		// Token: 0x0400BA84 RID: 47748
		[OriginalName("ErrGravityInteractNoPermission")]
		ErrGravityInteractNoPermission,
		// Token: 0x0400BA85 RID: 47749
		[OriginalName("PlayerNotInAnyGravityRegion")]
		PlayerNotInAnyGravityRegion,
		// Token: 0x0400BA86 RID: 47750
		[OriginalName("ErrSceneEntityAlreadyExist")]
		ErrSceneEntityAlreadyExist = 2200070,
		// Token: 0x0400BA87 RID: 47751
		[OriginalName("PlayerLeaveGravityRegionInAbnormalGravity")]
		PlayerLeaveGravityRegionInAbnormalGravity = 2200076,
		// Token: 0x0400BA88 RID: 47752
		[OriginalName("HookLockPointConditionNotMet")]
		HookLockPointConditionNotMet = 2200071,
		// Token: 0x0400BA89 RID: 47753
		[OriginalName("PlayerInAbnormalGravity")]
		PlayerInAbnormalGravity = 2200077,
		// Token: 0x0400BA8A RID: 47754
		[OriginalName("GravityFlipIndexNoChange")]
		GravityFlipIndexNoChange,
		// Token: 0x0400BA8B RID: 47755
		[OriginalName("GravityFlipIndexNotExist")]
		GravityFlipIndexNotExist,
		// Token: 0x0400BA8C RID: 47756
		[OriginalName("GravityFlipTypeNoChange")]
		GravityFlipTypeNoChange,
		// Token: 0x0400BA8D RID: 47757
		[OriginalName("GravityFlipTypeNotExist")]
		GravityFlipTypeNotExist,
		// Token: 0x0400BA8E RID: 47758
		[OriginalName("GravityFlipNotUpdateToTargetDirection")]
		GravityFlipNotUpdateToTargetDirection,
		// Token: 0x0400BA8F RID: 47759
		[OriginalName("ReliablePosNotInGravityRegion")]
		ReliablePosNotInGravityRegion,
		// Token: 0x0400BA90 RID: 47760
		[OriginalName("TargetPosNotInGravityRegion")]
		TargetPosNotInGravityRegion,
		// Token: 0x0400BA91 RID: 47761
		[OriginalName("PlayerCurGravityDirectionNotInOptions")]
		PlayerCurGravityDirectionNotInOptions,
		// Token: 0x0400BA92 RID: 47762
		[OriginalName("WaterfallClimbingParticipatorCountErr")]
		WaterfallClimbingParticipatorCountErr,
		// Token: 0x0400BA93 RID: 47763
		[OriginalName("WaterfallClimbingParticipatorNoVehicle")]
		WaterfallClimbingParticipatorNoVehicle,
		// Token: 0x0400BA94 RID: 47764
		[OriginalName("WaterfallClimbingVehicleNoPassenger")]
		WaterfallClimbingVehicleNoPassenger,
		// Token: 0x0400BA95 RID: 47765
		[OriginalName("WaterfallClimbingPlayerNotInPassenger")]
		WaterfallClimbingPlayerNotInPassenger,
		// Token: 0x0400BA96 RID: 47766
		[OriginalName("ErrVehicleEntityNotExist")]
		ErrVehicleEntityNotExist,
		// Token: 0x0400BA97 RID: 47767
		[OriginalName("GravityFlipLocked")]
		GravityFlipLocked,
		// Token: 0x0400BA98 RID: 47768
		[OriginalName("ClientActionSkipped")]
		ClientActionSkipped,
		// Token: 0x0400BA99 RID: 47769
		[OriginalName("AbnormalGravityCannotAddTemporary")]
		AbnormalGravityCannotAddTemporary,
		// Token: 0x0400BA9A RID: 47770
		[OriginalName("ErrReliablePosEntityNotExist")]
		ErrReliablePosEntityNotExist,
		// Token: 0x0400BA9B RID: 47771
		[OriginalName("UpdateReliablePosGravityDirNotMatch")]
		UpdateReliablePosGravityDirNotMatch,
		// Token: 0x0400BA9C RID: 47772
		[OriginalName("UpdateReliablePosNotWalkable")]
		UpdateReliablePosNotWalkable,
		// Token: 0x0400BA9D RID: 47773
		[OriginalName("UpdateReliablePosSelfNotEntity")]
		UpdateReliablePosSelfNotEntity,
		// Token: 0x0400BA9E RID: 47774
		[OriginalName("GravityDirectionHasNaN")]
		GravityDirectionHasNaN,
		// Token: 0x0400BA9F RID: 47775
		[OriginalName("ErrHostInAbnormalGravity")]
		ErrHostInAbnormalGravity,
		// Token: 0x0400BAA0 RID: 47776
		[OriginalName("MultiModeCannotTeleport")]
		MultiModeCannotTeleport,
		// Token: 0x0400BAA1 RID: 47777
		[OriginalName("NotTrapDefenseInst")]
		NotTrapDefenseInst,
		// Token: 0x0400BAA2 RID: 47778
		[OriginalName("GridCellCreateFuncNotFound")]
		GridCellCreateFuncNotFound,
		// Token: 0x0400BAA3 RID: 47779
		[OriginalName("GridSystemNotExist")]
		GridSystemNotExist,
		// Token: 0x0400BAA4 RID: 47780
		[OriginalName("ErrGridCellType")]
		ErrGridCellType,
		// Token: 0x0400BAA5 RID: 47781
		[OriginalName("GridCellDirectionNotSpecified")]
		GridCellDirectionNotSpecified,
		// Token: 0x0400BAA6 RID: 47782
		[OriginalName("NotGridObjectEntity")]
		NotGridObjectEntity,
		// Token: 0x0400BAA7 RID: 47783
		[OriginalName("GridNotExist")]
		GridNotExist,
		// Token: 0x0400BAA8 RID: 47784
		[OriginalName("GridCellNotExist")]
		GridCellNotExist,
		// Token: 0x0400BAA9 RID: 47785
		[OriginalName("GridCellAlreadyOccupied")]
		GridCellAlreadyOccupied,
		// Token: 0x0400BAAA RID: 47786
		[OriginalName("GridCellDisabled")]
		GridCellDisabled,
		// Token: 0x0400BAAB RID: 47787
		[OriginalName("GridCellPositionNotValid")]
		GridCellPositionNotValid,
		// Token: 0x0400BAAC RID: 47788
		[OriginalName("SimpleCombatEntityNotMonster")]
		SimpleCombatEntityNotMonster,
		// Token: 0x0400BAAD RID: 47789
		[OriginalName("GridObjectEntityNotFound")]
		GridObjectEntityNotFound,
		// Token: 0x0400BAAE RID: 47790
		[OriginalName("NotLowMemoryPlatform")]
		NotLowMemoryPlatform,
		// Token: 0x0400BAAF RID: 47791
		[OriginalName("ErrLowMemorySwitchingScene")]
		ErrLowMemorySwitchingScene,
		// Token: 0x0400BAB0 RID: 47792
		[OriginalName("SimpleCombatEntityBuffNotExist")]
		SimpleCombatEntityBuffNotExist,
		// Token: 0x0400BAB1 RID: 47793
		[OriginalName("SimpleCombatEntityBuffDuplicate")]
		SimpleCombatEntityBuffDuplicate,
		// Token: 0x0400BAB2 RID: 47794
		[OriginalName("TrapDefenseRandomBdFail")]
		TrapDefenseRandomBdFail,
		// Token: 0x0400BAB3 RID: 47795
		[OriginalName("TrapDefenseBdConfigNotExist")]
		TrapDefenseBdConfigNotExist,
		// Token: 0x0400BAB4 RID: 47796
		[OriginalName("TrapDefenseBdGroupConfigOfBdNotExist")]
		TrapDefenseBdGroupConfigOfBdNotExist,
		// Token: 0x0400BAB5 RID: 47797
		[OriginalName("TrapDefenseRandomQualityFail")]
		TrapDefenseRandomQualityFail,
		// Token: 0x0400BAB6 RID: 47798
		[OriginalName("TrapDefenseRandomBdGroupFail")]
		TrapDefenseRandomBdGroupFail,
		// Token: 0x0400BAB7 RID: 47799
		[OriginalName("TrapDefenseBdGroupPoolEmpty")]
		TrapDefenseBdGroupPoolEmpty,
		// Token: 0x0400BAB8 RID: 47800
		[OriginalName("TrapDefenseNoAvailableBd")]
		TrapDefenseNoAvailableBd,
		// Token: 0x0400BAB9 RID: 47801
		[OriginalName("TrapDefenseNoAvailableQuality")]
		TrapDefenseNoAvailableQuality,
		// Token: 0x0400BABA RID: 47802
		[OriginalName("TrapDefenseDrawActionConfigNotExist")]
		TrapDefenseDrawActionConfigNotExist,
		// Token: 0x0400BABB RID: 47803
		[OriginalName("TrapDefenseInstConfigNotExist")]
		TrapDefenseInstConfigNotExist,
		// Token: 0x0400BABC RID: 47804
		[OriginalName("TrapDefenseWaveConfigNotExist")]
		TrapDefenseWaveConfigNotExist,
		// Token: 0x0400BABD RID: 47805
		[OriginalName("TrapDefenseSpawnMonsterWaveConfigNotExist")]
		TrapDefenseSpawnMonsterWaveConfigNotExist,
		// Token: 0x0400BABE RID: 47806
		[OriginalName("TrapDefenseMonsterConfigNotExist")]
		TrapDefenseMonsterConfigNotExist,
		// Token: 0x0400BABF RID: 47807
		[OriginalName("TrapDefenseMonsterDataDuplicate")]
		TrapDefenseMonsterDataDuplicate,
		// Token: 0x0400BAC0 RID: 47808
		[OriginalName("TrapDefenseTrapConfigNotExist")]
		TrapDefenseTrapConfigNotExist,
		// Token: 0x0400BAC1 RID: 47809
		[OriginalName("TrapDefenseTrapEntityNotFound")]
		TrapDefenseTrapEntityNotFound,
		// Token: 0x0400BAC2 RID: 47810
		[OriginalName("TrapDefenseNotPreviewStep")]
		TrapDefenseNotPreviewStep,
		// Token: 0x0400BAC3 RID: 47811
		[OriginalName("TrapDefenseBdGroupConfigNotExist")]
		TrapDefenseBdGroupConfigNotExist,
		// Token: 0x0400BAC4 RID: 47812
		[OriginalName("TrapDefenseBdPoolEmpty")]
		TrapDefenseBdPoolEmpty,
		// Token: 0x0400BAC5 RID: 47813
		[OriginalName("TrapDefenseQualityPoolEmpty")]
		TrapDefenseQualityPoolEmpty,
		// Token: 0x0400BAC6 RID: 47814
		[OriginalName("ErrTrapDefenseRequestParam")]
		ErrTrapDefenseRequestParam,
		// Token: 0x0400BAC7 RID: 47815
		[OriginalName("ErrTrapDefenseRequestParamDuplicate")]
		ErrTrapDefenseRequestParamDuplicate,
		// Token: 0x0400BAC8 RID: 47816
		[OriginalName("ErrTrapDefenseRewardConfig")]
		ErrTrapDefenseRewardConfig,
		// Token: 0x0400BAC9 RID: 47817
		[OriginalName("ErrTrapDefenseRewardTime")]
		ErrTrapDefenseRewardTime,
		// Token: 0x0400BACA RID: 47818
		[OriginalName("ErrTrapDefenseRewardReceived")]
		ErrTrapDefenseRewardReceived,
		// Token: 0x0400BACB RID: 47819
		[OriginalName("ErrTrapDefenseRewardNotComplete")]
		ErrTrapDefenseRewardNotComplete,
		// Token: 0x0400BACC RID: 47820
		[OriginalName("ErrTrapDefenseSceneErr")]
		ErrTrapDefenseSceneErr,
		// Token: 0x0400BACD RID: 47821
		[OriginalName("ErrTrapDefenseContextEmpty")]
		ErrTrapDefenseContextEmpty,
		// Token: 0x0400BACE RID: 47822
		[OriginalName("ErrTrapDefenseChallengeConfig")]
		ErrTrapDefenseChallengeConfig,
		// Token: 0x0400BACF RID: 47823
		[OriginalName("ErrTrapDefenseChallengeNotOpen")]
		ErrTrapDefenseChallengeNotOpen,
		// Token: 0x0400BAD0 RID: 47824
		[OriginalName("ErrTrapDefenseBuildingLock")]
		ErrTrapDefenseBuildingLock,
		// Token: 0x0400BAD1 RID: 47825
		[OriginalName("ErrTrapDefenseAuxiliaryLock")]
		ErrTrapDefenseAuxiliaryLock,
		// Token: 0x0400BAD2 RID: 47826
		[OriginalName("ErrTrapDefenseSlotCount")]
		ErrTrapDefenseSlotCount,
		// Token: 0x0400BAD3 RID: 47827
		[OriginalName("ErrTrapDefenseSlotBuildingDuplicate")]
		ErrTrapDefenseSlotBuildingDuplicate,
		// Token: 0x0400BAD4 RID: 47828
		[OriginalName("ErrTrapDefenseSlotDuplicate")]
		ErrTrapDefenseSlotDuplicate,
		// Token: 0x0400BAD5 RID: 47829
		[OriginalName("ErrTrapDefenseBuildingConfig")]
		ErrTrapDefenseBuildingConfig,
		// Token: 0x0400BAD6 RID: 47830
		[OriginalName("ErrTrapDefenseAuxiliaryConfig")]
		ErrTrapDefenseAuxiliaryConfig,
		// Token: 0x0400BAD7 RID: 47831
		[OriginalName("ErrTrapDefenseSlotAuxiliaryDuplicate")]
		ErrTrapDefenseSlotAuxiliaryDuplicate,
		// Token: 0x0400BAD8 RID: 47832
		[OriginalName("ErrTrapDefenseForceBuilding")]
		ErrTrapDefenseForceBuilding,
		// Token: 0x0400BAD9 RID: 47833
		[OriginalName("ErrTrapDefenseForceAuxiliary")]
		ErrTrapDefenseForceAuxiliary,
		// Token: 0x0400BADA RID: 47834
		[OriginalName("ErrTrapDefenseBuildingLevelConfig")]
		ErrTrapDefenseBuildingLevelConfig,
		// Token: 0x0400BADB RID: 47835
		[OriginalName("ErrTrapDefenseBuildingMaxLevel")]
		ErrTrapDefenseBuildingMaxLevel,
		// Token: 0x0400BADC RID: 47836
		[OriginalName("ErrTrapDefenseActivityConfig")]
		ErrTrapDefenseActivityConfig,
		// Token: 0x0400BADD RID: 47837
		[OriginalName("ErrTrapDefenseAuxiliaryLevelConfig")]
		ErrTrapDefenseAuxiliaryLevelConfig,
		// Token: 0x0400BADE RID: 47838
		[OriginalName("ErrTrapDefenseAuxiliaryMaxLevel")]
		ErrTrapDefenseAuxiliaryMaxLevel,
		// Token: 0x0400BADF RID: 47839
		[OriginalName("ErrTrapDefenseAuxiliaryBranch")]
		ErrTrapDefenseAuxiliaryBranch,
		// Token: 0x0400BAE0 RID: 47840
		[OriginalName("ErrTrapDefenseBuildingBranch")]
		ErrTrapDefenseBuildingBranch,
		// Token: 0x0400BAE1 RID: 47841
		[OriginalName("ErrTrapDefenseAuxiliaryReset")]
		ErrTrapDefenseAuxiliaryReset,
		// Token: 0x0400BAE2 RID: 47842
		[OriginalName("ErrTrapDefenseBuildingReset")]
		ErrTrapDefenseBuildingReset,
		// Token: 0x0400BAE3 RID: 47843
		[OriginalName("ErrTrapDefenseTechConfig")]
		ErrTrapDefenseTechConfig,
		// Token: 0x0400BAE4 RID: 47844
		[OriginalName("ErrTrapDefenseTechUnlock")]
		ErrTrapDefenseTechUnlock,
		// Token: 0x0400BAE5 RID: 47845
		[OriginalName("ErrTrapDefenseTechPreNodeConfig")]
		ErrTrapDefenseTechPreNodeConfig,
		// Token: 0x0400BAE6 RID: 47846
		[OriginalName("ErrTrapDefenseTechPreNodeLock")]
		ErrTrapDefenseTechPreNodeLock,
		// Token: 0x0400BAE7 RID: 47847
		[OriginalName("ErrTrapDefenseTechCostNotEnough")]
		ErrTrapDefenseTechCostNotEnough,
		// Token: 0x0400BAE8 RID: 47848
		[OriginalName("TrapDefenseItemConfigNotExist")]
		TrapDefenseItemConfigNotExist,
		// Token: 0x0400BAE9 RID: 47849
		[OriginalName("TrapDefenseItemExceedCarryLimit")]
		TrapDefenseItemExceedCarryLimit,
		// Token: 0x0400BAEA RID: 47850
		[OriginalName("TrapDefenseItemNotEnough")]
		TrapDefenseItemNotEnough,
		// Token: 0x0400BAEB RID: 47851
		[OriginalName("TrapDefenseBuyShopBdGroupNotExist")]
		TrapDefenseBuyShopBdGroupNotExist,
		// Token: 0x0400BAEC RID: 47852
		[OriginalName("TrapDefenseBuyShopItemNotExist")]
		TrapDefenseBuyShopItemNotExist,
		// Token: 0x0400BAED RID: 47853
		[OriginalName("TrapDefenseGoldNotEnough")]
		TrapDefenseGoldNotEnough,
		// Token: 0x0400BAEE RID: 47854
		[OriginalName("TrapDefensePayGoldFail")]
		TrapDefensePayGoldFail,
		// Token: 0x0400BAEF RID: 47855
		[OriginalName("TrapDefenseBuyShopItemNotEnough")]
		TrapDefenseBuyShopItemNotEnough,
		// Token: 0x0400BAF0 RID: 47856
		[OriginalName("TrapDefenseShopDataNotExist")]
		TrapDefenseShopDataNotExist,
		// Token: 0x0400BAF1 RID: 47857
		[OriginalName("TrapDefenseShopConfigNotExist")]
		TrapDefenseShopConfigNotExist,
		// Token: 0x0400BAF2 RID: 47858
		[OriginalName("TrapDefenseShopRefreshCountNotEnough")]
		TrapDefenseShopRefreshCountNotEnough,
		// Token: 0x0400BAF3 RID: 47859
		[OriginalName("TrapDefenseGoldenCoinConfigNotExist")]
		TrapDefenseGoldenCoinConfigNotExist,
		// Token: 0x0400BAF4 RID: 47860
		[OriginalName("TrapDefenseNotGoldenCoinEntity")]
		TrapDefenseNotGoldenCoinEntity,
		// Token: 0x0400BAF5 RID: 47861
		[OriginalName("TrapDefenseNotMonsterEntity")]
		TrapDefenseNotMonsterEntity,
		// Token: 0x0400BAF6 RID: 47862
		[OriginalName("TrapDefenseNotBuildingEntity")]
		TrapDefenseNotBuildingEntity,
		// Token: 0x0400BAF7 RID: 47863
		[OriginalName("TrapDefenseVarCannotUnderZero")]
		TrapDefenseVarCannotUnderZero,
		// Token: 0x0400BAF8 RID: 47864
		[OriginalName("TrapDefenseVarTypeNotExist")]
		TrapDefenseVarTypeNotExist,
		// Token: 0x0400BAF9 RID: 47865
		[OriginalName("TrapDefenseBuyShopBdGroupSold")]
		TrapDefenseBuyShopBdGroupSold,
		// Token: 0x0400BAFA RID: 47866
		[OriginalName("TrapDefenseTrapAmountExceedLimit")]
		TrapDefenseTrapAmountExceedLimit,
		// Token: 0x0400BAFB RID: 47867
		[OriginalName("TrapDefenseNotRewardStep")]
		TrapDefenseNotRewardStep,
		// Token: 0x0400BAFC RID: 47868
		[OriginalName("TrapDefenseBdDrawDataNotExist")]
		TrapDefenseBdDrawDataNotExist,
		// Token: 0x0400BAFD RID: 47869
		[OriginalName("TrapDefenseBdDrawRefreshCountNotEnough")]
		TrapDefenseBdDrawRefreshCountNotEnough,
		// Token: 0x0400BAFE RID: 47870
		[OriginalName("TrapDefenseSpecialCellConfigNotExist")]
		TrapDefenseSpecialCellConfigNotExist,
		// Token: 0x0400BAFF RID: 47871
		[OriginalName("TrapDefenseSpecialCellCertainLevelConfigNotExist")]
		TrapDefenseSpecialCellCertainLevelConfigNotExist,
		// Token: 0x0400BB00 RID: 47872
		[OriginalName("ErrActionTargetEntityNotExist")]
		ErrActionTargetEntityNotExist,
		// Token: 0x0400BB01 RID: 47873
		[OriginalName("TrapDefenseCleanerNotEnough")]
		TrapDefenseCleanerNotEnough,
		// Token: 0x0400BB02 RID: 47874
		[OriginalName("TrapDefenseItemConfigError")]
		TrapDefenseItemConfigError,
		// Token: 0x0400BB03 RID: 47875
		[OriginalName("TrapDefenseSpecialCellTypeNotSame")]
		TrapDefenseSpecialCellTypeNotSame,
		// Token: 0x0400BB04 RID: 47876
		[OriginalName("TrapDefenseCellNotSpecialCell")]
		TrapDefenseCellNotSpecialCell,
		// Token: 0x0400BB05 RID: 47877
		[OriginalName("TrapDefenseExceedMaxTrapCount")]
		TrapDefenseExceedMaxTrapCount,
		// Token: 0x0400BB06 RID: 47878
		[OriginalName("GridSystemCannotGetWorldGridPos")]
		GridSystemCannotGetWorldGridPos,
		// Token: 0x0400BB07 RID: 47879
		[OriginalName("TrapDefenseTrapCannotSelfDestruct")]
		TrapDefenseTrapCannotSelfDestruct,
		// Token: 0x0400BB08 RID: 47880
		[OriginalName("TrapDefenseBdDrawResultEmpty")]
		TrapDefenseBdDrawResultEmpty,
		// Token: 0x0400BB09 RID: 47881
		[OriginalName("TrapDefenseBdGroupMaxLevel")]
		TrapDefenseBdGroupMaxLevel,
		// Token: 0x0400BB0A RID: 47882
		[OriginalName("TrapDefenseCannotDeductHealth")]
		TrapDefenseCannotDeductHealth,
		// Token: 0x0400BB0B RID: 47883
		[OriginalName("SimpleCombatBuffConfigNotExist")]
		SimpleCombatBuffConfigNotExist,
		// Token: 0x0400BB0C RID: 47884
		[OriginalName("SimpleCombatSubTypeNotExist")]
		SimpleCombatSubTypeNotExist,
		// Token: 0x0400BB0D RID: 47885
		[OriginalName("TrapDefenseBdGroupDisabled")]
		TrapDefenseBdGroupDisabled,
		// Token: 0x0400BB0E RID: 47886
		[OriginalName("TrapDefenseMonsterDisabled")]
		TrapDefenseMonsterDisabled,
		// Token: 0x0400BB0F RID: 47887
		[OriginalName("TrapDefenseGainExceedLimit")]
		TrapDefenseGainExceedLimit,
		// Token: 0x0400BB10 RID: 47888
		[OriginalName("OnlyOneRollBlockCanBeActivated")]
		OnlyOneRollBlockCanBeActivated,
		// Token: 0x0400BB11 RID: 47889
		[OriginalName("RollBlockGroupConfigNotExist")]
		RollBlockGroupConfigNotExist,
		// Token: 0x0400BB12 RID: 47890
		[OriginalName("RollBlockDifficultyConfigNotExist")]
		RollBlockDifficultyConfigNotExist,
		// Token: 0x0400BB13 RID: 47891
		[OriginalName("RollBlockNextDifficultyConfigNotExist")]
		RollBlockNextDifficultyConfigNotExist,
		// Token: 0x0400BB14 RID: 47892
		[OriginalName("RollBlockGamePlayIdNotExist")]
		RollBlockGamePlayIdNotExist,
		// Token: 0x0400BB15 RID: 47893
		[OriginalName("RollBlockGamePlayNotExist")]
		RollBlockGamePlayNotExist,
		// Token: 0x0400BB16 RID: 47894
		[OriginalName("RollBlockMovementEntityNotExist")]
		RollBlockMovementEntityNotExist,
		// Token: 0x0400BB17 RID: 47895
		[OriginalName("RollBlockMovementEntityNotBlock")]
		RollBlockMovementEntityNotBlock,
		// Token: 0x0400BB18 RID: 47896
		[OriginalName("RollBlockMainControlPlayerNotExist")]
		RollBlockMainControlPlayerNotExist,
		// Token: 0x0400BB19 RID: 47897
		[OriginalName("RollBlockEntityNotMoving")]
		RollBlockEntityNotMoving,
		// Token: 0x0400BB1A RID: 47898
		[OriginalName("RollBlockNoGridAfterRoll")]
		RollBlockNoGridAfterRoll,
		// Token: 0x0400BB1B RID: 47899
		[OriginalName("RollBlockTemplateConfigNotExist")]
		RollBlockTemplateConfigNotExist,
		// Token: 0x0400BB1C RID: 47900
		[OriginalName("RollBlockNotMainControlPlayer")]
		RollBlockNotMainControlPlayer,
		// Token: 0x0400BB1D RID: 47901
		[OriginalName("RollBlockEntityNotExist")]
		RollBlockEntityNotExist,
		// Token: 0x0400BB1E RID: 47902
		[OriginalName("RollBlockBlockWillChangeState")]
		RollBlockBlockWillChangeState,
		// Token: 0x0400BB1F RID: 47903
		[OriginalName("RollBlockBlockStateNoChange")]
		RollBlockBlockStateNoChange,
		// Token: 0x0400BB20 RID: 47904
		[OriginalName("RollBlockMainControlBlockNotExist")]
		RollBlockMainControlBlockNotExist,
		// Token: 0x0400BB21 RID: 47905
		[OriginalName("RollBlockDifficultyDataNotExist")]
		RollBlockDifficultyDataNotExist,
		// Token: 0x0400BB22 RID: 47906
		[OriginalName("RollBlockPositionNoFloor")]
		RollBlockPositionNoFloor,
		// Token: 0x0400BB23 RID: 47907
		[OriginalName("RollBlockPositionItemCannotPass")]
		RollBlockPositionItemCannotPass,
		// Token: 0x0400BB24 RID: 47908
		[OriginalName("RollBlockPositionBlockCannotPass")]
		RollBlockPositionBlockCannotPass,
		// Token: 0x0400BB25 RID: 47909
		[OriginalName("RollBlockInputCannotMove")]
		RollBlockInputCannotMove,
		// Token: 0x0400BB26 RID: 47910
		[OriginalName("RollBlockPositionFloorCannotPass")]
		RollBlockPositionFloorCannotPass,
		// Token: 0x0400BB27 RID: 47911
		[OriginalName("RollBlockHintAlreadyActive")]
		RollBlockHintAlreadyActive,
		// Token: 0x0400BB28 RID: 47912
		[OriginalName("RollBlockHintBlockNotExist")]
		RollBlockHintBlockNotExist,
		// Token: 0x0400BB29 RID: 47913
		[OriginalName("RollBlockHintEmpty")]
		RollBlockHintEmpty,
		// Token: 0x0400BB2A RID: 47914
		[OriginalName("RollBlockAlreadyRewarded")]
		RollBlockAlreadyRewarded,
		// Token: 0x0400BB2B RID: 47915
		[OriginalName("RollBlockDifficultyNotPassed")]
		RollBlockDifficultyNotPassed,
		// Token: 0x0400BB2C RID: 47916
		[OriginalName("RollBlockHintStepNotExecuting")]
		RollBlockHintStepNotExecuting,
		// Token: 0x0400BB2D RID: 47917
		[OriginalName("RollBlockCurDifficultyConfigNotExist")]
		RollBlockCurDifficultyConfigNotExist,
		// Token: 0x0400BB2E RID: 47918
		[OriginalName("RollBlockHintStepExecuting")]
		RollBlockHintStepExecuting,
		// Token: 0x0400BB2F RID: 47919
		[OriginalName("RollBlockChildQuestGamePlayActived")]
		RollBlockChildQuestGamePlayActived,
		// Token: 0x0400BB30 RID: 47920
		[OriginalName("RollBlockOnlyOneControllableBlock")]
		RollBlockOnlyOneControllableBlock,
		// Token: 0x0400BB31 RID: 47921
		[OriginalName("RollBlockGamePlayStateNoChange")]
		RollBlockGamePlayStateNoChange,
		// Token: 0x0400BB32 RID: 47922
		[OriginalName("RollBlockGamePlayCannotReady")]
		RollBlockGamePlayCannotReady,
		// Token: 0x0400BB33 RID: 47923
		[OriginalName("RollBlockGamePlayNotReady")]
		RollBlockGamePlayNotReady,
		// Token: 0x0400BB34 RID: 47924
		[OriginalName("RollBlockSendResetTooFrequently")]
		RollBlockSendResetTooFrequently,
		// Token: 0x0400BB35 RID: 47925
		[OriginalName("EasterEggIdNotExist")]
		EasterEggIdNotExist,
		// Token: 0x0400BB36 RID: 47926
		[OriginalName("TargetSceneNotBigWorldInst")]
		TargetSceneNotBigWorldInst,
		// Token: 0x0400BB37 RID: 47927
		[OriginalName("EnterBigWorldInstCtxNotImplemented")]
		EnterBigWorldInstCtxNotImplemented,
		// Token: 0x0400BB38 RID: 47928
		[OriginalName("EasterEggOwnerTypeNotImplemented")]
		EasterEggOwnerTypeNotImplemented,
		// Token: 0x0400BB39 RID: 47929
		[OriginalName("RollBlockCannotReset")]
		RollBlockCannotReset,
		// Token: 0x0400BB3A RID: 47930
		[OriginalName("CurSceneNotBigWorld")]
		CurSceneNotBigWorld,
		// Token: 0x0400BB3B RID: 47931
		[OriginalName("KurotatoCharacterConfigNotExist")]
		KurotatoCharacterConfigNotExist,
		// Token: 0x0400BB3C RID: 47932
		[OriginalName("KurotatoLevelInfoNotExist")]
		KurotatoLevelInfoNotExist,
		// Token: 0x0400BB3D RID: 47933
		[OriginalName("KurotatoUpgradeRewardStepNotActive")]
		KurotatoUpgradeRewardStepNotActive,
		// Token: 0x0400BB3E RID: 47934
		[OriginalName("KurotatoUpgradeRewardItemNotFound")]
		KurotatoUpgradeRewardItemNotFound,
		// Token: 0x0400BB3F RID: 47935
		[OriginalName("KurotatoUpgradeRewardDataNotExist")]
		KurotatoUpgradeRewardDataNotExist,
		// Token: 0x0400BB40 RID: 47936
		[OriginalName("KurotatoActivityConfigNotExist")]
		KurotatoActivityConfigNotExist,
		// Token: 0x0400BB41 RID: 47937
		[OriginalName("KurotatoWeaponConfigNotExist")]
		KurotatoWeaponConfigNotExist,
		// Token: 0x0400BB42 RID: 47938
		[OriginalName("KurotatoWeaponNotExist")]
		KurotatoWeaponNotExist,
		// Token: 0x0400BB43 RID: 47939
		[OriginalName("KurotatoItemConfigNotExist")]
		KurotatoItemConfigNotExist,
		// Token: 0x0400BB44 RID: 47940
		[OriginalName("KurotatoItemNotExist")]
		KurotatoItemNotExist,
		// Token: 0x0400BB45 RID: 47941
		[OriginalName("KurotatoChestRewardStepNotActive")]
		KurotatoChestRewardStepNotActive,
		// Token: 0x0400BB46 RID: 47942
		[OriginalName("KurotatoChestRewardItemNotExist")]
		KurotatoChestRewardItemNotExist,
		// Token: 0x0400BB47 RID: 47943
		[OriginalName("KurotatoEffectConfigNotExist")]
		KurotatoEffectConfigNotExist,
		// Token: 0x0400BB48 RID: 47944
		[OriginalName("KurotatoEffectNotExist")]
		KurotatoEffectNotExist,
		// Token: 0x0400BB49 RID: 47945
		[OriginalName("KurotatoDrawConfigNotExist")]
		KurotatoDrawConfigNotExist,
		// Token: 0x0400BB4A RID: 47946
		[OriginalName("KurotatoPropertyConfigNotExist")]
		KurotatoPropertyConfigNotExist,
		// Token: 0x0400BB4B RID: 47947
		[OriginalName("KurotatoPropertyNotInSimpleCombatDefine")]
		KurotatoPropertyNotInSimpleCombatDefine,
		// Token: 0x0400BB4C RID: 47948
		[OriginalName("KurotatoShopStepNotActive")]
		KurotatoShopStepNotActive,
		// Token: 0x0400BB4D RID: 47949
		[OriginalName("KurotatoShopProductNotFound")]
		KurotatoShopProductNotFound,
		// Token: 0x0400BB4E RID: 47950
		[OriginalName("KurotatoShopGoldNotEnough")]
		KurotatoShopGoldNotEnough,
		// Token: 0x0400BB4F RID: 47951
		[OriginalName("KurotatoVarNameNotExist")]
		KurotatoVarNameNotExist,
		// Token: 0x0400BB50 RID: 47952
		[OriginalName("KurotatoVarNotExist")]
		KurotatoVarNotExist,
		// Token: 0x0400BB51 RID: 47953
		[OriginalName("KurotatoRoleLevelConfigNotExist")]
		KurotatoRoleLevelConfigNotExist,
		// Token: 0x0400BB52 RID: 47954
		[OriginalName("KurotatoCharacterEntityNotExist")]
		KurotatoCharacterEntityNotExist,
		// Token: 0x0400BB53 RID: 47955
		[OriginalName("KurotatoGoldNotEnough")]
		KurotatoGoldNotEnough,
		// Token: 0x0400BB54 RID: 47956
		[OriginalName("KurotatoMonsterConfigNotExist")]
		KurotatoMonsterConfigNotExist,
		// Token: 0x0400BB55 RID: 47957
		[OriginalName("KurotatoMultiModeNotSupported")]
		KurotatoMultiModeNotSupported,
		// Token: 0x0400BB56 RID: 47958
		[OriginalName("KurotatoLevelConfigNotExist")]
		KurotatoLevelConfigNotExist,
		// Token: 0x0400BB57 RID: 47959
		[OriginalName("KurotatoDropInfoNotExist")]
		KurotatoDropInfoNotExist,
		// Token: 0x0400BB58 RID: 47960
		[OriginalName("KurotatoDropConfigNotExist")]
		KurotatoDropConfigNotExist,
		// Token: 0x0400BB59 RID: 47961
		[OriginalName("KurotatoWaveConfigNotExist")]
		KurotatoWaveConfigNotExist,
		// Token: 0x0400BB5A RID: 47962
		[OriginalName("KurotatoWeaponCountReachLimit")]
		KurotatoWeaponCountReachLimit,
		// Token: 0x0400BB5B RID: 47963
		[OriginalName("KurotatoWeaponRefineNotEnoughSameQuality")]
		KurotatoWeaponRefineNotEnoughSameQuality,
		// Token: 0x0400BB5C RID: 47964
		[OriginalName("KurotatoItemStackFull")]
		KurotatoItemStackFull,
		// Token: 0x0400BB5D RID: 47965
		[OriginalName("KurotatoCharacterUpgradeConfigNotExist")]
		KurotatoCharacterUpgradeConfigNotExist,
		// Token: 0x0400BB5E RID: 47966
		[OriginalName("KurotatoUpgradeRewardDrawIdNotExist")]
		KurotatoUpgradeRewardDrawIdNotExist,
		// Token: 0x0400BB5F RID: 47967
		[OriginalName("KurotatoDrawResultEmpty")]
		KurotatoDrawResultEmpty,
		// Token: 0x0400BB60 RID: 47968
		[OriginalName("KurotatoLuckPropertyNotExist")]
		KurotatoLuckPropertyNotExist,
		// Token: 0x0400BB61 RID: 47969
		[OriginalName("KurotatoGoldGainPropertyNotExist")]
		KurotatoGoldGainPropertyNotExist,
		// Token: 0x0400BB62 RID: 47970
		[OriginalName("KurotatoCharacterAlreadyExist")]
		KurotatoCharacterAlreadyExist,
		// Token: 0x0400BB63 RID: 47971
		[OriginalName("KurotatoCombatStepNotActive")]
		KurotatoCombatStepNotActive,
		// Token: 0x0400BB64 RID: 47972
		[OriginalName("KurotatoNotInSpecialWave")]
		KurotatoNotInSpecialWave,
		// Token: 0x0400BB65 RID: 47973
		[OriginalName("KurotatoWeaponCountReachMin")]
		KurotatoWeaponCountReachMin,
		// Token: 0x0400BB66 RID: 47974
		[OriginalName("KurotatoNotSupportedProductType")]
		KurotatoNotSupportedProductType,
		// Token: 0x0400BB67 RID: 47975
		[OriginalName("KurotatoStructureConfigNotExist")]
		KurotatoStructureConfigNotExist,
		// Token: 0x0400BB68 RID: 47976
		[OriginalName("KurotatoStructureCannotCreate")]
		KurotatoStructureCannotCreate,
		// Token: 0x0400BB69 RID: 47977
		[OriginalName("NotQaAccountWithHIddenServer")]
		NotQaAccountWithHiddenServer = 2300000,
		// Token: 0x0400BB6A RID: 47978
		[OriginalName("DisabledFuncInHIddenServer")]
		DisabledFuncInHiddenServer,
		// Token: 0x0400BB6B RID: 47979
		[OriginalName("ErrActionExecutorFinishConditionNotSport")]
		ErrActionExecutorFinishConditionNotSport = 2400000,
		// Token: 0x0400BB6C RID: 47980
		[OriginalName("ErrAlreadyInSwitchNode")]
		ErrAlreadyInSwitchNode,
		// Token: 0x0400BB6D RID: 47981
		[OriginalName("ErrCornActivityId")]
		ErrCornActivityId = 2500000,
		// Token: 0x0400BB6E RID: 47982
		[OriginalName("ErrCornActivityNoOpen")]
		ErrCornActivityNoOpen,
		// Token: 0x0400BB6F RID: 47983
		[OriginalName("ErrCornNoActivityData")]
		ErrCornNoActivityData,
		// Token: 0x0400BB70 RID: 47984
		[OriginalName("NoPlayIdCorniceReward")]
		NoPlayIdCorniceReward,
		// Token: 0x0400BB71 RID: 47985
		[OriginalName("ActivityNoOpenCorniceReward")]
		ActivityNoOpenCorniceReward,
		// Token: 0x0400BB72 RID: 47986
		[OriginalName("ScoreLimitCorniceReward")]
		ScoreLimitCorniceReward,
		// Token: 0x0400BB73 RID: 47987
		[OriginalName("RewardedCorniceReward")]
		RewardedCorniceReward,
		// Token: 0x0400BB74 RID: 47988
		[OriginalName("NoUnlockCorniceReward")]
		NoUnlockCorniceReward,
		// Token: 0x0400BB75 RID: 47989
		[OriginalName("NoScoreCorniceReward")]
		NoScoreCorniceReward,
		// Token: 0x0400BB76 RID: 47990
		[OriginalName("TrackMoonPhaseNoConfig")]
		TrackMoonPhaseNoConfig,
		// Token: 0x0400BB77 RID: 47991
		[OriginalName("TrackMoonPhaseActivityNoOpen")]
		TrackMoonPhaseActivityNoOpen,
		// Token: 0x0400BB78 RID: 47992
		[OriginalName("TrackMoonPhaseNoPolulary")]
		TrackMoonPhaseNoPolulary,
		// Token: 0x0400BB79 RID: 47993
		[OriginalName("TrackMoonPhaseNoData")]
		TrackMoonPhaseNoData,
		// Token: 0x0400BB7A RID: 47994
		[OriginalName("TrackMoonPhaseRewarded")]
		TrackMoonPhaseRewarded,
		// Token: 0x0400BB7B RID: 47995
		[OriginalName("TrackMoonPhaseDataNoConfig")]
		TrackMoonPhaseDataNoConfig,
		// Token: 0x0400BB7C RID: 47996
		[OriginalName("TrackMoonPhaseDataNoOpen")]
		TrackMoonPhaseDataNoOpen,
		// Token: 0x0400BB7D RID: 47997
		[OriginalName("TrackMoonPhaseDataNoData")]
		TrackMoonPhaseDataNoData,
		// Token: 0x0400BB7E RID: 47998
		[OriginalName("BCTRewardNoTConfig")]
		BctrewardNoTconfig,
		// Token: 0x0400BB7F RID: 47999
		[OriginalName("BCTRewardNoOpenActivity")]
		BctrewardNoOpenActivity,
		// Token: 0x0400BB80 RID: 48000
		[OriginalName("BCTRewardNoData")]
		BctrewardNoData,
		// Token: 0x0400BB81 RID: 48001
		[OriginalName("BCTRewardNoUnlock")]
		BctrewardNoUnlock,
		// Token: 0x0400BB82 RID: 48002
		[OriginalName("BCTRewardNoComplete")]
		BctrewardNoComplete,
		// Token: 0x0400BB83 RID: 48003
		[OriginalName("BCARewardNoRConfig")]
		BcarewardNoRconfig,
		// Token: 0x0400BB84 RID: 48004
		[OriginalName("BCARewardNoOpenActivity")]
		BcarewardNoOpenActivity,
		// Token: 0x0400BB85 RID: 48005
		[OriginalName("BCARewardNoData")]
		BcarewardNoData,
		// Token: 0x0400BB86 RID: 48006
		[OriginalName("BCARewardNoActive")]
		BcarewardNoActive,
		// Token: 0x0400BB87 RID: 48007
		[OriginalName("BCARewarded")]
		Bcarewarded,
		// Token: 0x0400BB88 RID: 48008
		[OriginalName("BCARewardNoActiveReward")]
		BcarewardNoActiveReward,
		// Token: 0x0400BB89 RID: 48009
		[OriginalName("CornTranNoPlayConfig")]
		CornTranNoPlayConfig,
		// Token: 0x0400BB8A RID: 48010
		[OriginalName("CornTranNoOpenPlay")]
		CornTranNoOpenPlay,
		// Token: 0x0400BB8B RID: 48011
		[OriginalName("CornTranNoOpenActivity")]
		CornTranNoOpenActivity,
		// Token: 0x0400BB8C RID: 48012
		[OriginalName("CornTranNoEntityConfig")]
		CornTranNoEntityConfig,
		// Token: 0x0400BB8D RID: 48013
		[OriginalName("BCARewardRepeatRewardId")]
		BcarewardRepeatRewardId,
		// Token: 0x0400BB8E RID: 48014
		[OriginalName("BCARewardDifferActivityId")]
		BcarewardDifferActivityId,
		// Token: 0x0400BB8F RID: 48015
		[OriginalName("BCTRewardNoActivity")]
		BctrewardNoActivity,
		// Token: 0x0400BB90 RID: 48016
		[OriginalName("BCTRewardIllegalRewardNum")]
		BctrewardIllegalRewardNum,
		// Token: 0x0400BB91 RID: 48017
		[OriginalName("BCTRewardNoUnlockStage")]
		BctrewardNoUnlockStage,
		// Token: 0x0400BB92 RID: 48018
		[OriginalName("PreheatSignNodeNoConfig")]
		PreheatSignNodeNoConfig,
		// Token: 0x0400BB93 RID: 48019
		[OriginalName("PreheatSignNodeNoData")]
		PreheatSignNodeNoData,
		// Token: 0x0400BB94 RID: 48020
		[OriginalName("PreheatSignActivityOnOpen")]
		PreheatSignActivityOnOpen,
		// Token: 0x0400BB95 RID: 48021
		[OriginalName("PreheatSignNodeNoUnlock")]
		PreheatSignNodeNoUnlock,
		// Token: 0x0400BB96 RID: 48022
		[OriginalName("PreheatSignNodeNoRewardStatus")]
		PreheatSignNodeNoRewardStatus,
		// Token: 0x0400BB97 RID: 48023
		[OriginalName("PreheatSignNodeNoAnswer")]
		PreheatSignNodeNoAnswer,
		// Token: 0x0400BB98 RID: 48024
		[OriginalName("ScratchCardNoRoundConfig")]
		ScratchCardNoRoundConfig,
		// Token: 0x0400BB99 RID: 48025
		[OriginalName("ScratchCardNoActivityConfig")]
		ScratchCardNoActivityConfig,
		// Token: 0x0400BB9A RID: 48026
		[OriginalName("ScratchCardNoDbData")]
		ScratchCardNoDbData,
		// Token: 0x0400BB9B RID: 48027
		[OriginalName("ScratchCardIllegalIndex")]
		ScratchCardIllegalIndex,
		// Token: 0x0400BB9C RID: 48028
		[OriginalName("ScratchCardIndexRewarded")]
		ScratchCardIndexRewarded,
		// Token: 0x0400BB9D RID: 48029
		[OriginalName("ScratchCardNoTime")]
		ScratchCardNoTime,
		// Token: 0x0400BB9E RID: 48030
		[OriginalName("ScratchCardNoRandomReward")]
		ScratchCardNoRandomReward,
		// Token: 0x0400BB9F RID: 48031
		[OriginalName("ScratchCardRoundNoUnlock")]
		ScratchCardRoundNoUnlock,
		// Token: 0x0400BBA0 RID: 48032
		[OriginalName("BossRushPlayerNoSceneData")]
		BossRushPlayerNoSceneData,
		// Token: 0x0400BBA1 RID: 48033
		[OriginalName("BossRushPlayerCanNoChooseBuff")]
		BossRushPlayerCanNoChooseBuff,
		// Token: 0x0400BBA2 RID: 48034
		[OriginalName("BossRushPlayerIllegalIndex")]
		BossRushPlayerIllegalIndex,
		// Token: 0x0400BBA3 RID: 48035
		[OriginalName("BossRushHadSameBuffId")]
		BossRushHadSameBuffId,
		// Token: 0x0400BBA4 RID: 48036
		[OriginalName("BossRushBuffCountLimit")]
		BossRushBuffCountLimit,
		// Token: 0x0400BBA5 RID: 48037
		[OriginalName("BossRushBuffIllegal")]
		BossRushBuffIllegal,
		// Token: 0x0400BBA6 RID: 48038
		[OriginalName("BossRushBuffNoConfig")]
		BossRushBuffNoConfig,
		// Token: 0x0400BBA7 RID: 48039
		[OriginalName("ScratchCardActivityNoOpen")]
		ScratchCardActivityNoOpen,
		// Token: 0x0400BBA8 RID: 48040
		[OriginalName("MowToweNoLevelConfig")]
		MowToweNoLevelConfig,
		// Token: 0x0400BBA9 RID: 48041
		[OriginalName("MowTowerActivityNoOpen")]
		MowTowerActivityNoOpen,
		// Token: 0x0400BBAA RID: 48042
		[OriginalName("MowToweNoCacheData")]
		MowToweNoCacheData,
		// Token: 0x0400BBAB RID: 48043
		[OriginalName("MowTowerNoPassFirstInst")]
		MowTowerNoPassFirstInst,
		// Token: 0x0400BBAC RID: 48044
		[OriginalName("MowTowerLevelsIdError")]
		MowTowerLevelsIdError,
		// Token: 0x0400BBAD RID: 48045
		[OriginalName("MowTowerRoleIdError")]
		MowTowerRoleIdError,
		// Token: 0x0400BBAE RID: 48046
		[OriginalName("MowTowerBuffIdError")]
		MowTowerBuffIdError,
		// Token: 0x0400BBAF RID: 48047
		[OriginalName("MowTowerNoComponent")]
		MowTowerNoComponent,
		// Token: 0x0400BBB0 RID: 48048
		[OriginalName("MowTowerHadSameRole")]
		MowTowerHadSameRole,
		// Token: 0x0400BBB1 RID: 48049
		[OriginalName("MowTowerBuffCountError")]
		MowTowerBuffCountError,
		// Token: 0x0400BBB2 RID: 48050
		[OriginalName("MowTowerNoFirstInst")]
		MowTowerNoFirstInst,
		// Token: 0x0400BBB3 RID: 48051
		[OriginalName("MowTowerNoActivityData")]
		MowTowerNoActivityData,
		// Token: 0x0400BBB4 RID: 48052
		[OriginalName("MowTowerScoreLimit")]
		MowTowerScoreLimit,
		// Token: 0x0400BBB5 RID: 48053
		[OriginalName("MowTowerScoreRewarded")]
		MowTowerScoreRewarded,
		// Token: 0x0400BBB6 RID: 48054
		[OriginalName("MowTowerScoreRewardConfig")]
		MowTowerScoreRewardConfig,
		// Token: 0x0400BBB7 RID: 48055
		[OriginalName("MowTowerNoInScene")]
		MowTowerNoInScene,
		// Token: 0x0400BBB8 RID: 48056
		[OriginalName("MowTowerNoRewardConfig")]
		MowTowerNoRewardConfig,
		// Token: 0x0400BBB9 RID: 48057
		[OriginalName("MaterialReplaceNoTargetConfig")]
		MaterialReplaceNoTargetConfig,
		// Token: 0x0400BBBA RID: 48058
		[OriginalName("MaterialReplaceNoConsumeConfig")]
		MaterialReplaceNoConsumeConfig,
		// Token: 0x0400BBBB RID: 48059
		[OriginalName("MaterialReplaceNoSameGroup")]
		MaterialReplaceNoSameGroup,
		// Token: 0x0400BBBC RID: 48060
		[OriginalName("MaterialReplaceErrConsumeNum")]
		MaterialReplaceErrConsumeNum,
		// Token: 0x0400BBBD RID: 48061
		[OriginalName("ErrRoleSkinTrialNotInit")]
		ErrRoleSkinTrialNotInit,
		// Token: 0x0400BBBE RID: 48062
		[OriginalName("ErrRoleSkinTrialNoFinish")]
		ErrRoleSkinTrialNoFinish,
		// Token: 0x0400BBBF RID: 48063
		[OriginalName("ErrRoleSkinTrialReward")]
		ErrRoleSkinTrialReward,
		// Token: 0x0400BBC0 RID: 48064
		[OriginalName("ErrRoleSkinTrialRewardDone")]
		ErrRoleSkinTrialRewardDone,
		// Token: 0x0400BBC1 RID: 48065
		[OriginalName("ErrRoleSkinTrialTimeOut")]
		ErrRoleSkinTrialTimeOut,
		// Token: 0x0400BBC2 RID: 48066
		[OriginalName("PhantomEquipGroupNoEquipPhantom")]
		PhantomEquipGroupNoEquipPhantom,
		// Token: 0x0400BBC3 RID: 48067
		[OriginalName("PhantomEquipGroupCountLimit")]
		PhantomEquipGroupCountLimit,
		// Token: 0x0400BBC4 RID: 48068
		[OriginalName("PhantomEquipGroupHadInTop")]
		PhantomEquipGroupHadInTop,
		// Token: 0x0400BBC5 RID: 48069
		[OriginalName("PhantomEquipGroupNameEmpty")]
		PhantomEquipGroupNameEmpty,
		// Token: 0x0400BBC6 RID: 48070
		[OriginalName("PhantomEquipGroupNameCountLimiy")]
		PhantomEquipGroupNameCountLimiy,
		// Token: 0x0400BBC7 RID: 48071
		[OriginalName("PhantomRecommendFuncNoOpen")]
		PhantomRecommendFuncNoOpen,
		// Token: 0x0400BBC8 RID: 48072
		[OriginalName("BossRushTaskNoFinish")]
		BossRushTaskNoFinish,
		// Token: 0x0400BBC9 RID: 48073
		[OriginalName("PhantomGroupUseSame")]
		PhantomGroupUseSame,
		// Token: 0x0400BBCA RID: 48074
		[OriginalName("PhantomGroupFunNoOpen")]
		PhantomGroupFunNoOpen,
		// Token: 0x0400BBCB RID: 48075
		[OriginalName("NoFishingActivityConfig")]
		NoFishingActivityConfig,
		// Token: 0x0400BBCC RID: 48076
		[OriginalName("NoInFishingActivityTime")]
		NoInFishingActivityTime,
		// Token: 0x0400BBCD RID: 48077
		[OriginalName("FishingActivityCanNoReward")]
		FishingActivityCanNoReward,
		// Token: 0x0400BBCE RID: 48078
		[OriginalName("NoFishingActivityMileConfig")]
		NoFishingActivityMileConfig,
		// Token: 0x0400BBCF RID: 48079
		[OriginalName("FishingActivitySameMileId")]
		FishingActivitySameMileId,
		// Token: 0x0400BBD0 RID: 48080
		[OriginalName("FishingActivityRewarded")]
		FishingActivityRewarded,
		// Token: 0x0400BBD1 RID: 48081
		[OriginalName("PlayerTitleFuncNoOpen")]
		PlayerTitleFuncNoOpen,
		// Token: 0x0400BBD2 RID: 48082
		[OriginalName("PlayerTitleHadUndress")]
		PlayerTitleHadUndress,
		// Token: 0x0400BBD3 RID: 48083
		[OriginalName("PlayerTitleHadDress")]
		PlayerTitleHadDress,
		// Token: 0x0400BBD4 RID: 48084
		[OriginalName("PlayerTitleNoUnlock")]
		PlayerTitleNoUnlock,
		// Token: 0x0400BBD5 RID: 48085
		[OriginalName("BabelTowerActivityNoOpen")]
		BabelTowerActivityNoOpen,
		// Token: 0x0400BBD6 RID: 48086
		[OriginalName("BabelTowerLevelNoOpen")]
		BabelTowerLevelNoOpen,
		// Token: 0x0400BBD7 RID: 48087
		[OriginalName("BabelTowerDeEffectNoFind")]
		BabelTowerDeEffectNoFind,
		// Token: 0x0400BBD8 RID: 48088
		[OriginalName("BabelTowerDeEffectCanNoChoose")]
		BabelTowerDeEffectCanNoChoose,
		// Token: 0x0400BBD9 RID: 48089
		[OriginalName("BabelTowerDeEffectMutex")]
		BabelTowerDeEffectMutex,
		// Token: 0x0400BBDA RID: 48090
		[OriginalName("BabelTowerNoDailyTask")]
		BabelTowerNoDailyTask,
		// Token: 0x0400BBDB RID: 48091
		[OriginalName("BabelTowerTaskNoComplete")]
		BabelTowerTaskNoComplete,
		// Token: 0x0400BBDC RID: 48092
		[OriginalName("BabelTowerTaskRewarded")]
		BabelTowerTaskRewarded,
		// Token: 0x0400BBDD RID: 48093
		[OriginalName("BabelTowerRoleLimit")]
		BabelTowerRoleLimit,
		// Token: 0x0400BBDE RID: 48094
		[OriginalName("BabelTowerNoBuffConfig")]
		BabelTowerNoBuffConfig,
		// Token: 0x0400BBDF RID: 48095
		[OriginalName("BabelTowerBuffCanNoChoose")]
		BabelTowerBuffCanNoChoose,
		// Token: 0x0400BBE0 RID: 48096
		[OriginalName("BabelTowerBuffNumIllegal")]
		BabelTowerBuffNumIllegal,
		// Token: 0x0400BBE1 RID: 48097
		[OriginalName("BabelTowerBuffChooseCountLimit")]
		BabelTowerBuffChooseCountLimit,
		// Token: 0x0400BBE2 RID: 48098
		[OriginalName("NoBabelTowerInsComponent")]
		NoBabelTowerInsComponent,
		// Token: 0x0400BBE3 RID: 48099
		[OriginalName("BabelTowerNoSelectBuff")]
		BabelTowerNoSelectBuff,
		// Token: 0x0400BBE4 RID: 48100
		[OriginalName("PhantomPolishFuncNoOpen")]
		PhantomPolishFuncNoOpen,
		// Token: 0x0400BBE5 RID: 48101
		[OriginalName("PhantomPolishHadLevelUp")]
		PhantomPolishHadLevelUp,
		// Token: 0x0400BBE6 RID: 48102
		[OriginalName("PhantomPolishQualityLimit")]
		PhantomPolishQualityLimit,
		// Token: 0x0400BBE7 RID: 48103
		[OriginalName("PhantomPolishSamePro")]
		PhantomPolishSamePro,
		// Token: 0x0400BBE8 RID: 48104
		[OriginalName("ExploreActivityNoOpen")]
		ExploreActivityNoOpen,
		// Token: 0x0400BBE9 RID: 48105
		[OriginalName("ExploreActivityTaskNoFinish")]
		ExploreActivityTaskNoFinish,
		// Token: 0x0400BBEA RID: 48106
		[OriginalName("ExploreActivityTaskRewarded")]
		ExploreActivityTaskRewarded,
		// Token: 0x0400BBEB RID: 48107
		[OriginalName("BabelTowerDeTermNoUnlock")]
		BabelTowerDeTermNoUnlock,
		// Token: 0x0400BBEC RID: 48108
		[OriginalName("BabelTowerBuffNoUnlock")]
		BabelTowerBuffNoUnlock,
		// Token: 0x0400BBED RID: 48109
		[OriginalName("BabelTowerIsNoDifficult")]
		BabelTowerIsNoDifficult,
		// Token: 0x0400BBEE RID: 48110
		[OriginalName("PlayerTitleNoConfig")]
		PlayerTitleNoConfig,
		// Token: 0x0400BBEF RID: 48111
		[OriginalName("PlayerFixIndexIllegal")]
		PlayerFixIndexIllegal,
		// Token: 0x0400BBF0 RID: 48112
		[OriginalName("PlayerFixHadFlag")]
		PlayerFixHadFlag,
		// Token: 0x0400BBF1 RID: 48113
		[OriginalName("PlayerFixFrontNoFlag")]
		PlayerFixFrontNoFlag,
		// Token: 0x0400BBF2 RID: 48114
		[OriginalName("BabelTowerNoSelectRoles")]
		BabelTowerNoSelectRoles,
		// Token: 0x0400BBF3 RID: 48115
		[OriginalName("PhBaErrSelectNum")]
		PhBaErrSelectNum,
		// Token: 0x0400BBF4 RID: 48116
		[OriginalName("PhBaErrSelectTarget")]
		PhBaErrSelectTarget,
		// Token: 0x0400BBF5 RID: 48117
		[OriginalName("PhBaNoFighterLogic")]
		PhBaNoFighterLogic,
		// Token: 0x0400BBF6 RID: 48118
		[OriginalName("PhBaNoChallengeConf")]
		PhBaNoChallengeConf,
		// Token: 0x0400BBF7 RID: 48119
		[OriginalName("PhBaSlotIllegal")]
		PhBaSlotIllegal,
		// Token: 0x0400BBF8 RID: 48120
		[OriginalName("PhBaNoEvolveNum")]
		PhBaNoEvolveNum,
		// Token: 0x0400BBF9 RID: 48121
		[OriginalName("PhBaNoFighter")]
		PhBaNoFighter,
		// Token: 0x0400BBFA RID: 48122
		[OriginalName("PhBaNoHandCard")]
		PhBaNoHandCard,
		// Token: 0x0400BBFB RID: 48123
		[OriginalName("PhBaNoCardConf")]
		PhBaNoCardConf,
		// Token: 0x0400BBFC RID: 48124
		[OriginalName("PhBaNoCardEvolveCountInValid")]
		PhBaNoCardEvolveCountInValid,
		// Token: 0x0400BBFD RID: 48125
		[OriginalName("PhBaErrCostNoMatch")]
		PhBaErrCostNoMatch,
		// Token: 0x0400BBFE RID: 48126
		[OriginalName("PhBaNoCardRoleConf")]
		PhBaNoCardRoleConf,
		// Token: 0x0400BBFF RID: 48127
		[OriginalName("PhBaNoContainSkill")]
		PhBaNoContainSkill,
		// Token: 0x0400BC00 RID: 48128
		[OriginalName("PhBaNoSkillConf")]
		PhBaNoSkillConf,
		// Token: 0x0400BC01 RID: 48129
		[OriginalName("PhBaNoCardCanNoUse")]
		PhBaNoCardCanNoUse,
		// Token: 0x0400BC02 RID: 48130
		[OriginalName("PhBaIsWaitClient")]
		PhBaIsWaitClient,
		// Token: 0x0400BC03 RID: 48131
		[OriginalName("PhBaNoDeployRound")]
		PhBaNoDeployRound,
		// Token: 0x0400BC04 RID: 48132
		[OriginalName("PhBaNoClientParam")]
		PhBaNoClientParam,
		// Token: 0x0400BC05 RID: 48133
		[OriginalName("PhBaNoClientParamMatch")]
		PhBaNoClientParamMatch,
		// Token: 0x0400BC06 RID: 48134
		[OriginalName("PhBaErrSelectCardNum")]
		PhBaErrSelectCardNum,
		// Token: 0x0400BC07 RID: 48135
		[OriginalName("PhBaErrSelectReplace")]
		PhBaErrSelectReplace,
		// Token: 0x0400BC08 RID: 48136
		[OriginalName("PhBaErrPreStep")]
		PhBaErrPreStep,
		// Token: 0x0400BC09 RID: 48137
		[OriginalName("PhBaCanNoSelect")]
		PhBaCanNoSelect,
		// Token: 0x0400BC0A RID: 48138
		[OriginalName("PhBaConditionLimit")]
		PhBaConditionLimit,
		// Token: 0x0400BC0B RID: 48139
		[OriginalName("PhBaNoOwnerFighter")]
		PhBaNoOwnerFighter,
		// Token: 0x0400BC0C RID: 48140
		[OriginalName("PhBaNoTriggerFighter")]
		PhBaNoTriggerFighter,
		// Token: 0x0400BC0D RID: 48141
		[OriginalName("PhBaSelectParamNull")]
		PhBaSelectParamNull,
		// Token: 0x0400BC0E RID: 48142
		[OriginalName("PhBaNoBuffData")]
		PhBaNoBuffData,
		// Token: 0x0400BC0F RID: 48143
		[OriginalName("PhBaNoBuffConf")]
		PhBaNoBuffConf,
		// Token: 0x0400BC10 RID: 48144
		[OriginalName("PhBaErrCardGroupIndex")]
		PhBaErrCardGroupIndex,
		// Token: 0x0400BC11 RID: 48145
		[OriginalName("PhBaCardRoleUnlock")]
		PhBaCardRoleUnlock,
		// Token: 0x0400BC12 RID: 48146
		[OriginalName("PhBaNoCardGroupConf")]
		PhBaNoCardGroupConf,
		// Token: 0x0400BC13 RID: 48147
		[OriginalName("PhBaSloFull")]
		PhBaSloFull,
		// Token: 0x0400BC14 RID: 48148
		[OriginalName("PhBaHandCardEmpty")]
		PhBaHandCardEmpty,
		// Token: 0x0400BC15 RID: 48149
		[OriginalName("PbSelectCardNotFound")]
		PbSelectCardNotFound,
		// Token: 0x0400BC16 RID: 48150
		[OriginalName("PbSelectCardCount")]
		PbSelectCardCount,
		// Token: 0x0400BC17 RID: 48151
		[OriginalName("PbNoNpcFighter")]
		PbNoNpcFighter,
		// Token: 0x0400BC18 RID: 48152
		[OriginalName("PbNoPlayerFighter")]
		PbNoPlayerFighter,
		// Token: 0x0400BC19 RID: 48153
		[OriginalName("PbBTEventDataIllegal")]
		PbBteventDataIllegal,
		// Token: 0x0400BC1A RID: 48154
		[OriginalName("PbNoCardFighter")]
		PbNoCardFighter,
		// Token: 0x0400BC1B RID: 48155
		[OriginalName("PbNoHandCardVarData")]
		PbNoHandCardVarData,
		// Token: 0x0400BC1C RID: 48156
		[OriginalName("PbNoPosVarData")]
		PbNoPosVarData,
		// Token: 0x0400BC1D RID: 48157
		[OriginalName("PbNoHandCard")]
		PbNoHandCard,
		// Token: 0x0400BC1E RID: 48158
		[OriginalName("PbNoCardFighterVarData")]
		PbNoCardFighterVarData,
		// Token: 0x0400BC1F RID: 48159
		[OriginalName("PbNoNpcConfig")]
		PbNoNpcConfig,
		// Token: 0x0400BC20 RID: 48160
		[OriginalName("PbNoCostPoint")]
		PbNoCostPoint,
		// Token: 0x0400BC21 RID: 48161
		[OriginalName("PbNoActiveSkill")]
		PbNoActiveSkill,
		// Token: 0x0400BC22 RID: 48162
		[OriginalName("PbErrSelectTargets")]
		PbErrSelectTargets,
		// Token: 0x0400BC23 RID: 48163
		[OriginalName("PbErrHadFighter")]
		PbErrHadFighter,
		// Token: 0x0400BC24 RID: 48164
		[OriginalName("PbErrCardUnmovable")]
		PbErrCardUnmovable,
		// Token: 0x0400BC25 RID: 48165
		[OriginalName("PbNoCanSelectTarget")]
		PbNoCanSelectTarget,
		// Token: 0x0400BC26 RID: 48166
		[OriginalName("PbCanNotOpOtherUnit")]
		PbCanNotOpOtherUnit,
		// Token: 0x0400BC27 RID: 48167
		[OriginalName("PbCanNoBeEvolve")]
		PbCanNoBeEvolve,
		// Token: 0x0400BC28 RID: 48168
		[OriginalName("PbKeyCostCanNotOp")]
		PbKeyCostCanNotOp,
		// Token: 0x0400BC29 RID: 48169
		[OriginalName("PbNoReChallenge")]
		PbNoReChallenge,
		// Token: 0x0400BC2A RID: 48170
		[OriginalName("PbFuncNoOpen")]
		PbFuncNoOpen,
		// Token: 0x0400BC2B RID: 48171
		[OriginalName("PbNoRequestReChallenge")]
		PbNoRequestReChallenge,
		// Token: 0x0400BC2C RID: 48172
		[OriginalName("PbNoSameSlotIndex")]
		PbNoSameSlotIndex,
		// Token: 0x0400BC2D RID: 48173
		[OriginalName("PhBaHaCardEmpty")]
		PhBaHaCardEmpty,
		// Token: 0x0400BC2E RID: 48174
		[OriginalName("PhBaPassedChallenge")]
		PhBaPassedChallenge,
		// Token: 0x0400BC2F RID: 48175
		[OriginalName("FunPlayNoConfig")]
		FunPlayNoConfig,
		// Token: 0x0400BC30 RID: 48176
		[OriginalName("FunPlayNoFinish")]
		FunPlayNoFinish,
		// Token: 0x0400BC31 RID: 48177
		[OriginalName("FunPlayHadRewarded")]
		FunPlayHadRewarded,
		// Token: 0x0400BC32 RID: 48178
		[OriginalName("PbCardSkillCountLimit")]
		PbCardSkillCountLimit,
		// Token: 0x0400BC33 RID: 48179
		[OriginalName("BabelRoleIsSelected")]
		BabelRoleIsSelected = 2500248,
		// Token: 0x0400BC34 RID: 48180
		[OriginalName("BabelNoTalentConfig")]
		BabelNoTalentConfig,
		// Token: 0x0400BC35 RID: 48181
		[OriginalName("BabelInnerCanNoOpe")]
		BabelInnerCanNoOpe,
		// Token: 0x0400BC36 RID: 48182
		[OriginalName("BabelTalentIsLearned")]
		BabelTalentIsLearned,
		// Token: 0x0400BC37 RID: 48183
		[OriginalName("BabelTalentNoFinish")]
		BabelTalentNoFinish,
		// Token: 0x0400BC38 RID: 48184
		[OriginalName("BabelNoActivityConfig")]
		BabelNoActivityConfig,
		// Token: 0x0400BC39 RID: 48185
		[OriginalName("BabelRankListInCd")]
		BabelRankListInCd,
		// Token: 0x0400BC3A RID: 48186
		[OriginalName("FunPlayDayNoOpen")]
		FunPlayDayNoOpen,
		// Token: 0x0400BC3B RID: 48187
		[OriginalName("CheckShopConditionFail")]
		CheckShopConditionFail = 2500262,
		// Token: 0x0400BC3C RID: 48188
		[OriginalName("HonamiStoryBagUpdateRepeat")]
		HonamiStoryBagUpdateRepeat,
		// Token: 0x0400BC3D RID: 48189
		[OriginalName("HonamiStoryBagNoConfig")]
		HonamiStoryBagNoConfig,
		// Token: 0x0400BC3E RID: 48190
		[OriginalName("HonamiStoryNormalAddItemErr")]
		HonamiStoryNormalAddItemErr,
		// Token: 0x0400BC3F RID: 48191
		[OriginalName("HonamiStoryNoBagDb")]
		HonamiStoryNoBagDb,
		// Token: 0x0400BC40 RID: 48192
		[OriginalName("HonamiStoryUpdateItemSizeIllegal")]
		HonamiStoryUpdateItemSizeIllegal,
		// Token: 0x0400BC41 RID: 48193
		[OriginalName("HonamiStoryItemUpdateRepeat")]
		HonamiStoryItemUpdateRepeat,
		// Token: 0x0400BC42 RID: 48194
		[OriginalName("HonamiStoryBagHadItem")]
		HonamiStoryBagHadItem,
		// Token: 0x0400BC43 RID: 48195
		[OriginalName("HonamiStoryBagPosIllegal")]
		HonamiStoryBagPosIllegal,
		// Token: 0x0400BC44 RID: 48196
		[OriginalName("HonamiStoryItemUpdateTypeErr")]
		HonamiStoryItemUpdateTypeErr,
		// Token: 0x0400BC45 RID: 48197
		[OriginalName("HonamiStoryBagNoHadItem")]
		HonamiStoryBagNoHadItem,
		// Token: 0x0400BC46 RID: 48198
		[OriginalName("HonamiStoryDropItemNoEntityId")]
		HonamiStoryDropItemNoEntityId,
		// Token: 0x0400BC47 RID: 48199
		[OriginalName("HonamiStoryDropItemNoEntity")]
		HonamiStoryDropItemNoEntity,
		// Token: 0x0400BC48 RID: 48200
		[OriginalName("HonamiStoryNoDropEntity")]
		HonamiStoryNoDropEntity,
		// Token: 0x0400BC49 RID: 48201
		[OriginalName("HonamiStoryDropNoItemDb")]
		HonamiStoryDropNoItemDb,
		// Token: 0x0400BC4A RID: 48202
		[OriginalName("HonamiStoryItemNoBalance")]
		HonamiStoryItemNoBalance,
		// Token: 0x0400BC4B RID: 48203
		[OriginalName("HonamiStoryNoUpdateItem")]
		HonamiStoryNoUpdateItem,
		// Token: 0x0400BC4C RID: 48204
		[OriginalName("HonamiStoryCheckMarkNoItemConfig")]
		HonamiStoryCheckMarkNoItemConfig,
		// Token: 0x0400BC4D RID: 48205
		[OriginalName("HonamiStoryCheckMarkOverSize")]
		HonamiStoryCheckMarkOverSize,
		// Token: 0x0400BC4E RID: 48206
		[OriginalName("HonamiStoryCheckWideOverSize")]
		HonamiStoryCheckWideOverSize,
		// Token: 0x0400BC4F RID: 48207
		[OriginalName("HonamiStoryCheckMarkRepeat")]
		HonamiStoryCheckMarkRepeat,
		// Token: 0x0400BC50 RID: 48208
		[OriginalName("HonamiStoryActivityNoSame")]
		HonamiStoryActivityNoSame,
		// Token: 0x0400BC51 RID: 48209
		[OriginalName("HonamiStoryNoEquipRackData")]
		HonamiStoryNoEquipRackData,
		// Token: 0x0400BC52 RID: 48210
		[OriginalName("HonamiStoryNoEquipType")]
		HonamiStoryNoEquipType,
		// Token: 0x0400BC53 RID: 48211
		[OriginalName("HonamiStoryNoEquipConfig")]
		HonamiStoryNoEquipConfig,
		// Token: 0x0400BC54 RID: 48212
		[OriginalName("HonamiStoryNoEquipTypeNoMatch")]
		HonamiStoryNoEquipTypeNoMatch,
		// Token: 0x0400BC55 RID: 48213
		[OriginalName("HonamiStoryActivityIdErr")]
		HonamiStoryActivityIdErr,
		// Token: 0x0400BC56 RID: 48214
		[OriginalName("HonamiStoryInnerCanNoModifyRole")]
		HonamiStoryInnerCanNoModifyRole,
		// Token: 0x0400BC57 RID: 48215
		[OriginalName("HonamiStoryRoleNoValid")]
		HonamiStoryRoleNoValid,
		// Token: 0x0400BC58 RID: 48216
		[OriginalName("HonamiStoryNoChallengeConfig")]
		HonamiStoryNoChallengeConfig,
		// Token: 0x0400BC59 RID: 48217
		[OriginalName("NoHonamiStoryInstType")]
		NoHonamiStoryInstType,
		// Token: 0x0400BC5A RID: 48218
		[OriginalName("HonamiStoryNoItemConfig")]
		HonamiStoryNoItemConfig,
		// Token: 0x0400BC5B RID: 48219
		[OriginalName("HonamiStoryPickDistanceErr")]
		HonamiStoryPickDistanceErr,
		// Token: 0x0400BC5C RID: 48220
		[OriginalName("HonamiStoryNoDressWeapon")]
		HonamiStoryNoDressWeapon,
		// Token: 0x0400BC5D RID: 48221
		[OriginalName("HonamiStoryNoWeaponConfig")]
		HonamiStoryNoWeaponConfig,
		// Token: 0x0400BC5E RID: 48222
		[OriginalName("HonamiStoryWeaponPluginPosErr")]
		HonamiStoryWeaponPluginPosErr,
		// Token: 0x0400BC5F RID: 48223
		[OriginalName("HonamiStoryWeaponPluginTypeNoMatch")]
		HonamiStoryWeaponPluginTypeNoMatch,
		// Token: 0x0400BC60 RID: 48224
		[OriginalName("HonamiStoryWareHouseOverSize")]
		HonamiStoryWareHouseOverSize,
		// Token: 0x0400BC61 RID: 48225
		[OriginalName("HonamiStoryNoOpenSafeBag")]
		HonamiStoryNoOpenSafeBag,
		// Token: 0x0400BC62 RID: 48226
		[OriginalName("HonamiStoryNoOpenSafeBagItem")]
		HonamiStoryNoOpenSafeBagItem,
		// Token: 0x0400BC63 RID: 48227
		[OriginalName("HonamiStoryBagTypeNoMatch")]
		HonamiStoryBagTypeNoMatch,
		// Token: 0x0400BC64 RID: 48228
		[OriginalName("HonamiStoryWeaponPluginNoUnDress")]
		HonamiStoryWeaponPluginNoUnDress,
		// Token: 0x0400BC65 RID: 48229
		[OriginalName("HonamiStoryChangeItemPosSame")]
		HonamiStoryChangeItemPosSame,
		// Token: 0x0400BC66 RID: 48230
		[OriginalName("HonamiStoryEquipPosError")]
		HonamiStoryEquipPosError,
		// Token: 0x0400BC67 RID: 48231
		[OriginalName("HonamiStoryEquipPosRepeat")]
		HonamiStoryEquipPosRepeat,
		// Token: 0x0400BC68 RID: 48232
		[OriginalName("HonamiStoryOriPosErr")]
		HonamiStoryOriPosErr,
		// Token: 0x0400BC69 RID: 48233
		[OriginalName("HonamiStoryInstCanNoOpe")]
		HonamiStoryInstCanNoOpe,
		// Token: 0x0400BC6A RID: 48234
		[OriginalName("HonamiStoryIsRewarded")]
		HonamiStoryIsRewarded,
		// Token: 0x0400BC6B RID: 48235
		[OriginalName("HonamiStoryNoFinish")]
		HonamiStoryNoFinish,
		// Token: 0x0400BC6C RID: 48236
		[OriginalName("HonamiStoryNoConfig")]
		HonamiStoryNoConfig,
		// Token: 0x0400BC6D RID: 48237
		[OriginalName("HonamiStoryHadActivateTalent")]
		HonamiStoryHadActivateTalent,
		// Token: 0x0400BC6E RID: 48238
		[OriginalName("HonamiStoryIsUnlocked")]
		HonamiStoryIsUnlocked,
		// Token: 0x0400BC6F RID: 48239
		[OriginalName("HonamiStoryItemCanNoSell")]
		HonamiStoryItemCanNoSell,
		// Token: 0x0400BC70 RID: 48240
		[OriginalName("HonamiStoryRewardRepeat")]
		HonamiStoryRewardRepeat,
		// Token: 0x0400BC71 RID: 48241
		[OriginalName("HonamiStoryInstHadFinish")]
		HonamiStoryInstHadFinish,
		// Token: 0x0400BC72 RID: 48242
		[OriginalName("HonamiStoryLifeSupportFullLevel")]
		HonamiStoryLifeSupportFullLevel,
		// Token: 0x0400BC73 RID: 48243
		[OriginalName("HonamiStoryDangerLevelIllegal")]
		HonamiStoryDangerLevelIllegal,
		// Token: 0x0400BC74 RID: 48244
		[OriginalName("HonamiStoryWeaponHadDress")]
		HonamiStoryWeaponHadDress,
		// Token: 0x0400BC75 RID: 48245
		[OriginalName("HonamiStoryItemIsLock")]
		HonamiStoryItemIsLock,
		// Token: 0x0400BC76 RID: 48246
		[OriginalName("HonamiStoryFunNoOpen")]
		HonamiStoryFunNoOpen,
		// Token: 0x0400BC77 RID: 48247
		[OriginalName("HonamiStoryHadSafeLeave")]
		HonamiStoryHadSafeLeave,
		// Token: 0x0400BC78 RID: 48248
		[OriginalName("HonamiStoryInTop")]
		HonamiStoryInTop,
		// Token: 0x0400BC79 RID: 48249
		[OriginalName("HonamiStoryAreaNoUnlock")]
		HonamiStoryAreaNoUnlock,
		// Token: 0x0400BC7A RID: 48250
		[OriginalName("HonamiStoryPreSlotUnlock")]
		HonamiStoryPreSlotUnlock,
		// Token: 0x0400BC7B RID: 48251
		[OriginalName("TotalTopUpNoActivityConfig")]
		TotalTopUpNoActivityConfig,
		// Token: 0x0400BC7C RID: 48252
		[OriginalName("TotalTopUpNoFinish")]
		TotalTopUpNoFinish,
		// Token: 0x0400BC7D RID: 48253
		[OriginalName("TotalTopUpRewarded")]
		TotalTopUpRewarded,
		// Token: 0x0400BC7E RID: 48254
		[OriginalName("TotalTopUpRoleFullChain")]
		TotalTopUpRoleFullChain,
		// Token: 0x0400BC7F RID: 48255
		[OriginalName("WeekCardUseRepeat")]
		WeekCardUseRepeat,
		// Token: 0x0400BC80 RID: 48256
		[OriginalName("WeekCardNoConfig")]
		WeekCardNoConfig,
		// Token: 0x0400BC81 RID: 48257
		[OriginalName("WeekCardNoActive")]
		WeekCardNoActive,
		// Token: 0x0400BC82 RID: 48258
		[OriginalName("WeekCardCanNoReward")]
		WeekCardCanNoReward,
		// Token: 0x0400BC83 RID: 48259
		[OriginalName("WeekCardRewarded")]
		WeekCardRewarded,
		// Token: 0x0400BC84 RID: 48260
		[OriginalName("WeekCardNoEffect")]
		WeekCardNoEffect,
		// Token: 0x0400BC85 RID: 48261
		[OriginalName("FlagChallengeTaskNoFinish")]
		FlagChallengeTaskNoFinish,
		// Token: 0x0400BC86 RID: 48262
		[OriginalName("FlagChallengeNoConfig")]
		FlagChallengeNoConfig,
		// Token: 0x0400BC87 RID: 48263
		[OriginalName("FlagChallengeTaskRewarded")]
		FlagChallengeTaskRewarded,
		// Token: 0x0400BC88 RID: 48264
		[OriginalName("FlagChallengeRewardRepeat")]
		FlagChallengeRewardRepeat,
		// Token: 0x0400BC89 RID: 48265
		[OriginalName("FlagChallengeNoUnlock")]
		FlagChallengeNoUnlock,
		// Token: 0x0400BC8A RID: 48266
		[OriginalName("FeiXuePreheatNoFinish")]
		FeiXuePreheatNoFinish,
		// Token: 0x0400BC8B RID: 48267
		[OriginalName("FeiXuePreheatNoConfig")]
		FeiXuePreheatNoConfig,
		// Token: 0x0400BC8C RID: 48268
		[OriginalName("FeiXuePreheatRewarded")]
		FeiXuePreheatRewarded,
		// Token: 0x0400BC8D RID: 48269
		[OriginalName("FeiXuePreheatRewardRepeat")]
		FeiXuePreheatRewardRepeat,
		// Token: 0x0400BC8E RID: 48270
		[OriginalName("ErrOrnamentConfig")]
		ErrOrnamentConfig,
		// Token: 0x0400BC8F RID: 48271
		[OriginalName("ErrOrnamentLocked")]
		ErrOrnamentLocked,
		// Token: 0x0400BC90 RID: 48272
		[OriginalName("ErrOrnamentDressed")]
		ErrOrnamentDressed,
		// Token: 0x0400BC91 RID: 48273
		[OriginalName("ErrOrnamentCanNoDress")]
		ErrOrnamentCanNoDress,
		// Token: 0x0400BC92 RID: 48274
		[OriginalName("ErrOrnamentNoDress")]
		ErrOrnamentNoDress,
		// Token: 0x0400BC93 RID: 48275
		[OriginalName("BossPilingTaskNoFinish")]
		BossPilingTaskNoFinish,
		// Token: 0x0400BC94 RID: 48276
		[OriginalName("BossPilingNoConfig")]
		BossPilingNoConfig,
		// Token: 0x0400BC95 RID: 48277
		[OriginalName("BossPilingTaskRewarded")]
		BossPilingTaskRewarded,
		// Token: 0x0400BC96 RID: 48278
		[OriginalName("BossPilingRewardRepeat")]
		BossPilingRewardRepeat,
		// Token: 0x0400BC97 RID: 48279
		[OriginalName("BossPilingNoUnlock")]
		BossPilingNoUnlock,
		// Token: 0x0400BC98 RID: 48280
		[OriginalName("FlagChallengePassed")]
		FlagChallengePassed,
		// Token: 0x0400BC99 RID: 48281
		[OriginalName("BossPilingFirstNoFinish")]
		BossPilingFirstNoFinish,
		// Token: 0x0400BC9A RID: 48282
		[OriginalName("BossPilingRoleErr")]
		BossPilingRoleErr,
		// Token: 0x0400BC9B RID: 48283
		[OriginalName("GachaAccumulateNoConfig")]
		GachaAccumulateNoConfig,
		// Token: 0x0400BC9C RID: 48284
		[OriginalName("GachaAccumulateNoInTime")]
		GachaAccumulateNoInTime,
		// Token: 0x0400BC9D RID: 48285
		[OriginalName("GachaAccumulateRewarded")]
		GachaAccumulateRewarded,
		// Token: 0x0400BC9E RID: 48286
		[OriginalName("GachaAccumulateNoFinish")]
		GachaAccumulateNoFinish,
		// Token: 0x0400BC9F RID: 48287
		[OriginalName("GachaAccumulateErrSelectParam")]
		GachaAccumulateErrSelectParam,
		// Token: 0x0400BCA0 RID: 48288
		[OriginalName("RequestParamRepeat")]
		RequestParamRepeat,
		// Token: 0x0400BCA1 RID: 48289
		[OriginalName("BossPilingActivityNoOpen")]
		BossPilingActivityNoOpen,
		// Token: 0x0400BCA2 RID: 48290
		[OriginalName("BossPilingErrMultiGame")]
		BossPilingErrMultiGame,
		// Token: 0x0400BCA3 RID: 48291
		[OriginalName("SheriffNoConfig")]
		SheriffNoConfig,
		// Token: 0x0400BCA4 RID: 48292
		[OriginalName("SheriffActivityNoOpen")]
		SheriffActivityNoOpen,
		// Token: 0x0400BCA5 RID: 48293
		[OriginalName("SheriffFuncNotOpen")]
		SheriffFuncNotOpen,
		// Token: 0x0400BCA6 RID: 48294
		[OriginalName("SheriffClueNotUnlock")]
		SheriffClueNotUnlock,
		// Token: 0x0400BCA7 RID: 48295
		[OriginalName("SheriffEndingAlreadyFinish")]
		SheriffEndingAlreadyFinish,
		// Token: 0x0400BCA8 RID: 48296
		[OriginalName("ErrGiftResonantChainOptionalLimit")]
		ErrGiftResonantChainOptionalLimit,
		// Token: 0x0400BCA9 RID: 48297
		[OriginalName("DangoBrawlNoConfig")]
		DangoBrawlNoConfig,
		// Token: 0x0400BCAA RID: 48298
		[OriginalName("DangoBrawlErrMultiGame")]
		DangoBrawlErrMultiGame,
		// Token: 0x0400BCAB RID: 48299
		[OriginalName("DangoBrawlRoleErr")]
		DangoBrawlRoleErr,
		// Token: 0x0400BCAC RID: 48300
		[OriginalName("DangoBrawlNoComponent")]
		DangoBrawlNoComponent,
		// Token: 0x0400BCAD RID: 48301
		[OriginalName("DangoBrawlSceneStateErr")]
		DangoBrawlSceneStateErr,
		// Token: 0x0400BCAE RID: 48302
		[OriginalName("DangoBrawlCoinNotEnough")]
		DangoBrawlCoinNotEnough,
		// Token: 0x0400BCAF RID: 48303
		[OriginalName("DangoBrawlShopSlotErr")]
		DangoBrawlShopSlotErr,
		// Token: 0x0400BCB0 RID: 48304
		[OriginalName("DangoBrawlBagOpTypeErr")]
		DangoBrawlBagOpTypeErr,
		// Token: 0x0400BCB1 RID: 48305
		[OriginalName("DangoBrawlBagItemNotFound")]
		DangoBrawlBagItemNotFound,
		// Token: 0x0400BCB2 RID: 48306
		[OriginalName("DangoBrawlBagSlotErr")]
		DangoBrawlBagSlotErr,
		// Token: 0x0400BCB3 RID: 48307
		[OriginalName("DangoBrawlBagSlotOccupied")]
		DangoBrawlBagSlotOccupied,
		// Token: 0x0400BCB4 RID: 48308
		[OriginalName("DangoBrawlBagOpDuplicateUid")]
		DangoBrawlBagOpDuplicateUid,
		// Token: 0x0400BCB5 RID: 48309
		[OriginalName("DangoBrawlComposeNoRecipe")]
		DangoBrawlComposeNoRecipe,
		// Token: 0x0400BCB6 RID: 48310
		[OriginalName("DangoBrawlSpeItemLimit")]
		DangoBrawlSpeItemLimit,
		// Token: 0x0400BCB7 RID: 48311
		[OriginalName("DangoBrawlCostOverLimit")]
		DangoBrawlCostOverLimit,
		// Token: 0x0400BCB8 RID: 48312
		[OriginalName("DangoBrawlBenchFull")]
		DangoBrawlBenchFull,
		// Token: 0x0400BCB9 RID: 48313
		[OriginalName("CreateCharacterNoContext")]
		CreateCharacterNoContext,
		// Token: 0x0400BCBA RID: 48314
		[OriginalName("CreateCharacterStateErr")]
		CreateCharacterStateErr,
		// Token: 0x0400BCBB RID: 48315
		[OriginalName("CreateCharacterFlagErr")]
		CreateCharacterFlagErr,
		// Token: 0x0400BCBC RID: 48316
		[OriginalName("ErrAlertAreaId")]
		ErrAlertAreaId = 2600000,
		// Token: 0x0400BCBD RID: 48317
		[OriginalName("ErrAlertAreaEnable")]
		ErrAlertAreaEnable,
		// Token: 0x0400BCBE RID: 48318
		[OriginalName("ErrAlertAreaDisable")]
		ErrAlertAreaDisable,
		// Token: 0x0400BCBF RID: 48319
		[OriginalName("ErrAlertUiEnable")]
		ErrAlertUiEnable,
		// Token: 0x0400BCC0 RID: 48320
		[OriginalName("ErrAlertUiDisable")]
		ErrAlertUiDisable,
		// Token: 0x0400BCC1 RID: 48321
		[OriginalName("ErrAlertUiVisible")]
		ErrAlertUiVisible,
		// Token: 0x0400BCC2 RID: 48322
		[OriginalName("ErrAlertUiInvisible")]
		ErrAlertUiInvisible,
		// Token: 0x0400BCC3 RID: 48323
		[OriginalName("ErrAlertValueError")]
		ErrAlertValueError,
		// Token: 0x0400BCC4 RID: 48324
		[OriginalName("ErrAlertSetAlertValueType")]
		ErrAlertSetAlertValueType,
		// Token: 0x0400BCC5 RID: 48325
		[OriginalName("LevelPlayReportConfigNotExist")]
		LevelPlayReportConfigNotExist,
		// Token: 0x0400BCC6 RID: 48326
		[OriginalName("LevelPlayReportTypeError")]
		LevelPlayReportTypeError,
		// Token: 0x0400BCC7 RID: 48327
		[OriginalName("LevelPlayReportVarsEmpty")]
		LevelPlayReportVarsEmpty,
		// Token: 0x0400BCC8 RID: 48328
		[OriginalName("LevelPlayReportPlayVarsError")]
		LevelPlayReportPlayVarsError,
		// Token: 0x0400BCC9 RID: 48329
		[OriginalName("CameraAlertHasAlert")]
		CameraAlertHasAlert,
		// Token: 0x0400BCCA RID: 48330
		[OriginalName("CameraAlertHasNotAlert")]
		CameraAlertHasNotAlert,
		// Token: 0x0400BCCB RID: 48331
		[OriginalName("CameraAlertTagIdNotExist")]
		CameraAlertTagIdNotExist,
		// Token: 0x0400BCCC RID: 48332
		[OriginalName("LevelPlayConfigNotExist")]
		LevelPlayConfigNotExist,
		// Token: 0x0400BCCD RID: 48333
		[OriginalName("LevelPlayRepeateInstId")]
		LevelPlayRepeateInstId,
		// Token: 0x0400BCCE RID: 48334
		[OriginalName("LevelPlayNotBelongInst")]
		LevelPlayNotBelongInst,
		// Token: 0x0400BCCF RID: 48335
		[OriginalName("LevelPlayIdsNotExist")]
		LevelPlayIdsNotExist,
		// Token: 0x0400BCD0 RID: 48336
		[OriginalName("LevelPlayInstCountError")]
		LevelPlayInstCountError,
		// Token: 0x0400BCD1 RID: 48337
		[OriginalName("LevelPlayCountError")]
		LevelPlayCountError,
		// Token: 0x0400BCD2 RID: 48338
		[OriginalName("TimerHasPause")]
		TimerHasPause,
		// Token: 0x0400BCD3 RID: 48339
		[OriginalName("TimerHasNotPause")]
		TimerHasNotPause,
		// Token: 0x0400BCD4 RID: 48340
		[OriginalName("TimerHasFinish")]
		TimerHasFinish,
		// Token: 0x0400BCD5 RID: 48341
		[OriginalName("CanNotContinueInst")]
		CanNotContinueInst,
		// Token: 0x0400BCD6 RID: 48342
		[OriginalName("ChapterNotExist")]
		ChapterNotExist,
		// Token: 0x0400BCD7 RID: 48343
		[OriginalName("ChapterResultHasFinish")]
		ChapterResultHasFinish,
		// Token: 0x0400BCD8 RID: 48344
		[OriginalName("ChapterResultNotFinish")]
		ChapterResultNotFinish,
		// Token: 0x0400BCD9 RID: 48345
		[OriginalName("ChapterResultRewardCanNotTake")]
		ChapterResultRewardCanNotTake,
		// Token: 0x0400BCDA RID: 48346
		[OriginalName("ChoiceHasUnlock")]
		ChoiceHasUnlock,
		// Token: 0x0400BCDB RID: 48347
		[OriginalName("ChoiceNotUnlock")]
		ChoiceNotUnlock,
		// Token: 0x0400BCDC RID: 48348
		[OriginalName("ChapterResultNotExist")]
		ChapterResultNotExist,
		// Token: 0x0400BCDD RID: 48349
		[OriginalName("ChapterResultRewardHasTake")]
		ChapterResultRewardHasTake,
		// Token: 0x0400BCDE RID: 48350
		[OriginalName("ChoiceNotExist")]
		ChoiceNotExist,
		// Token: 0x0400BCDF RID: 48351
		[OriginalName("InspirationNotEnough")]
		InspirationNotEnough,
		// Token: 0x0400BCE0 RID: 48352
		[OriginalName("ActivityRewardCanNotTake")]
		ActivityRewardCanNotTake,
		// Token: 0x0400BCE1 RID: 48353
		[OriginalName("ActivityResultNotExist")]
		ActivityResultNotExist,
		// Token: 0x0400BCE2 RID: 48354
		[OriginalName("ScheduleRewardNotExist")]
		ScheduleRewardNotExist,
		// Token: 0x0400BCE3 RID: 48355
		[OriginalName("ScheduleRewardHasTake")]
		ScheduleRewardHasTake,
		// Token: 0x0400BCE4 RID: 48356
		[OriginalName("ScheduleRewardCanNotTake")]
		ScheduleRewardCanNotTake,
		// Token: 0x0400BCE5 RID: 48357
		[OriginalName("ActivityRewardHasTake")]
		ActivityRewardHasTake,
		// Token: 0x0400BCE6 RID: 48358
		[OriginalName("QuestWaitConfirmResource")]
		QuestWaitConfirmResource,
		// Token: 0x0400BCE7 RID: 48359
		[OriginalName("HasGuest")]
		HasGuest,
		// Token: 0x0400BCE8 RID: 48360
		[OriginalName("QuestConfigNotExist")]
		QuestConfigNotExist,
		// Token: 0x0400BCE9 RID: 48361
		[OriginalName("QuestDataNotExist")]
		QuestDataNotExist,
		// Token: 0x0400BCEA RID: 48362
		[OriginalName("ErrorQuestState")]
		ErrorQuestState,
		// Token: 0x0400BCEB RID: 48363
		[OriginalName("QuestCanNotSetFocus")]
		QuestCanNotSetFocus,
		// Token: 0x0400BCEC RID: 48364
		[OriginalName("ErrorQuestNotFocus")]
		ErrorQuestNotFocus,
		// Token: 0x0400BCED RID: 48365
		[OriginalName("QuestIncDicNotExist")]
		QuestIncDicNotExist,
		// Token: 0x0400BCEE RID: 48366
		[OriginalName("QuestFocusWaitAccept")]
		QuestFocusWaitAccept,
		// Token: 0x0400BCEF RID: 48367
		[OriginalName("ErrQuestResourceState")]
		ErrQuestResourceState,
		// Token: 0x0400BCF0 RID: 48368
		[OriginalName("NoNeedDownloadQuestResource")]
		NoNeedDownloadQuestResource,
		// Token: 0x0400BCF1 RID: 48369
		[OriginalName("HasFinishQuestResource")]
		HasFinishQuestResource,
		// Token: 0x0400BCF2 RID: 48370
		[OriginalName("ErrInteracTreeSuspend")]
		ErrInteracTreeSuspend,
		// Token: 0x0400BCF3 RID: 48371
		[OriginalName("InQuestFocusMode")]
		InQuestFocusMode,
		// Token: 0x0400BCF4 RID: 48372
		[OriginalName("MultiModeCannotSetQuestFocus")]
		MultiModeCannotSetQuestFocus,
		// Token: 0x0400BCF5 RID: 48373
		[OriginalName("MultiModeCannotCancelQuestFocus")]
		MultiModeCannotCancelQuestFocus,
		// Token: 0x0400BCF6 RID: 48374
		[OriginalName("InstanceCannotSetQuestFocus")]
		InstanceCannotSetQuestFocus,
		// Token: 0x0400BCF7 RID: 48375
		[OriginalName("InstanceCannotCancelQuestFocus")]
		InstanceCannotCancelQuestFocus,
		// Token: 0x0400BCF8 RID: 48376
		[OriginalName("QuestFocusModeCannotAcceptQuest")]
		QuestFocusModeCannotAcceptQuest,
		// Token: 0x0400BCF9 RID: 48377
		[OriginalName("ErrorNotFocusWaitQuest")]
		ErrorNotFocusWaitQuest,
		// Token: 0x0400BCFA RID: 48378
		[OriginalName("ErrorBanInteractEntity")]
		ErrorBanInteractEntity,
		// Token: 0x0400BCFB RID: 48379
		[OriginalName("DisabledFocusMode")]
		DisabledFocusMode,
		// Token: 0x0400BCFC RID: 48380
		[OriginalName("ErrorNotVaildGlobalSetting")]
		ErrorNotVaildGlobalSetting,
		// Token: 0x0400BCFD RID: 48381
		[OriginalName("ErrorSameGlobalSetting")]
		ErrorSameGlobalSetting,
		// Token: 0x0400BCFE RID: 48382
		[OriginalName("ErrorNotVaildBtObjSetting")]
		ErrorNotVaildBtObjSetting,
		// Token: 0x0400BCFF RID: 48383
		[OriginalName("ErrorSameBtObjSetting")]
		ErrorSameBtObjSetting,
		// Token: 0x0400BD00 RID: 48384
		[OriginalName("CopyUserLoginInvalidToken")]
		CopyUserLoginInvalidToken,
		// Token: 0x0400BD01 RID: 48385
		[OriginalName("LoginInvalidToken")]
		LoginInvalidToken,
		// Token: 0x0400BD02 RID: 48386
		[OriginalName("AccessInvalidToken")]
		AccessInvalidToken,
		// Token: 0x0400BD03 RID: 48387
		[OriginalName("ErrNotAtomicProcessChildQuest")]
		ErrNotAtomicProcessChildQuest,
		// Token: 0x0400BD04 RID: 48388
		[OriginalName("ErrNotAtomicProcessStoveCoreFall")]
		ErrNotAtomicProcessStoveCoreFall,
		// Token: 0x0400BD05 RID: 48389
		[OriginalName("ErrSplineEntityIdNotExist")]
		ErrSplineEntityIdNotExist,
		// Token: 0x0400BD06 RID: 48390
		[OriginalName("ErrSplineEntityNotExist")]
		ErrSplineEntityNotExist,
		// Token: 0x0400BD07 RID: 48391
		[OriginalName("MotorFightInstNotLevelConfig")]
		MotorFightInstNotLevelConfig,
		// Token: 0x0400BD08 RID: 48392
		[OriginalName("MotorFightSubLevelNotFind")]
		MotorFightSubLevelNotFind,
		// Token: 0x0400BD09 RID: 48393
		[OriginalName("MotorFightNextSubLevelNotExist")]
		MotorFightNextSubLevelNotExist,
		// Token: 0x0400BD0A RID: 48394
		[OriginalName("MotorFightErrorSubLevel")]
		MotorFightErrorSubLevel,
		// Token: 0x0400BD0B RID: 48395
		[OriginalName("MotorFightHasEnterSubLevel")]
		MotorFightHasEnterSubLevel,
		// Token: 0x0400BD0C RID: 48396
		[OriginalName("MotorFightCurSubLevelNotKillFinish")]
		MotorFightCurSubLevelNotKillFinish,
		// Token: 0x0400BD0D RID: 48397
		[OriginalName("MotorFightHasNotEnterSubLevel")]
		MotorFightHasNotEnterSubLevel,
		// Token: 0x0400BD0E RID: 48398
		[OriginalName("MotorFightCusSubLevelHasNotKillFinish")]
		MotorFightCusSubLevelHasNotKillFinish,
		// Token: 0x0400BD0F RID: 48399
		[OriginalName("MotorFightCurWaveNotFound")]
		MotorFightCurWaveNotFound,
		// Token: 0x0400BD10 RID: 48400
		[OriginalName("MotorFightErrorKillParams")]
		MotorFightErrorKillParams,
		// Token: 0x0400BD11 RID: 48401
		[OriginalName("MotorFighttExceedRefreshMonster")]
		MotorFighttExceedRefreshMonster,
		// Token: 0x0400BD12 RID: 48402
		[OriginalName("MotorFighttExceedRefreshBoss")]
		MotorFighttExceedRefreshBoss,
		// Token: 0x0400BD13 RID: 48403
		[OriginalName("MotorFightNotKillBoss")]
		MotorFightNotKillBoss,
		// Token: 0x0400BD14 RID: 48404
		[OriginalName("MotorFightBossDropCollectionHasSelect")]
		MotorFightBossDropCollectionHasSelect,
		// Token: 0x0400BD15 RID: 48405
		[OriginalName("MotorFightSelectPosCollectionNotExist")]
		MotorFightSelectPosCollectionNotExist,
		// Token: 0x0400BD16 RID: 48406
		[OriginalName("MotorFightCollectionConfigNotExist")]
		MotorFightCollectionConfigNotExist,
		// Token: 0x0400BD17 RID: 48407
		[OriginalName("MotorFightWaveGroupNotExist")]
		MotorFightWaveGroupNotExist,
		// Token: 0x0400BD18 RID: 48408
		[OriginalName("MotorFightBossMustKilled")]
		MotorFightBossMustKilled,
		// Token: 0x0400BD19 RID: 48409
		[OriginalName("MotorFightBossNotExist")]
		MotorFightBossNotExist,
		// Token: 0x0400BD1A RID: 48410
		[OriginalName("MotorFightSelectBuffGateNotExist")]
		MotorFightSelectBuffGateNotExist,
		// Token: 0x0400BD1B RID: 48411
		[OriginalName("MotorFightCurSubLevelCollectionNoSelectFinish")]
		MotorFightCurSubLevelCollectionNoSelectFinish,
		// Token: 0x0400BD1C RID: 48412
		[OriginalName("MotorFightSubLevelConfigNotFind")]
		MotorFightSubLevelConfigNotFind,
		// Token: 0x0400BD1D RID: 48413
		[OriginalName("MotorFightSubLevelIndexError")]
		MotorFightSubLevelIndexError,
		// Token: 0x0400BD1E RID: 48414
		[OriginalName("MotorFightBossHasKilled")]
		MotorFightBossHasKilled,
		// Token: 0x0400BD1F RID: 48415
		[OriginalName("MotorFightBossHasNotRefreshTimes")]
		MotorFightBossHasNotRefreshTimes,
		// Token: 0x0400BD20 RID: 48416
		[OriginalName("MotorFightBossDropCollectionError")]
		MotorFightBossDropCollectionError,
		// Token: 0x0400BD21 RID: 48417
		[OriginalName("MotorFightHasNotKillBossInfo")]
		MotorFightHasNotKillBossInfo,
		// Token: 0x0400BD22 RID: 48418
		[OriginalName("MotorFightIsLastBoss")]
		MotorFightIsLastBoss,
		// Token: 0x0400BD23 RID: 48419
		[OriginalName("MotorFightBuffGateHasSelect")]
		MotorFightBuffGateHasSelect,
		// Token: 0x0400BD24 RID: 48420
		[OriginalName("MotorFightSubLevelStateError")]
		MotorFightSubLevelStateError,
		// Token: 0x0400BD25 RID: 48421
		[OriginalName("MotorFightSubLevelNotFound")]
		MotorFightSubLevelNotFound,
		// Token: 0x0400BD26 RID: 48422
		[OriginalName("MotorFightHasGameOver")]
		MotorFightHasGameOver,
		// Token: 0x0400BD27 RID: 48423
		[OriginalName("MotorFightCurWaveNotExist")]
		MotorFightCurWaveNotExist,
		// Token: 0x0400BD28 RID: 48424
		[OriginalName("MotorFightCurWaveNotKillFinish")]
		MotorFightCurWaveNotKillFinish,
		// Token: 0x0400BD29 RID: 48425
		[OriginalName("SpecificInstDbDataLoading")]
		SpecificInstDbDataLoading,
		// Token: 0x0400BD2A RID: 48426
		[OriginalName("SpecificInstDbDataLoadError")]
		SpecificInstDbDataLoadError,
		// Token: 0x0400BD2B RID: 48427
		[OriginalName("RecallConfigNotExist")]
		RecallConfigNotExist,
		// Token: 0x0400BD2C RID: 48428
		[OriginalName("QuestNotFinish")]
		QuestNotFinish,
		// Token: 0x0400BD2D RID: 48429
		[OriginalName("HasInRecallScene")]
		HasInRecallScene,
		// Token: 0x0400BD2E RID: 48430
		[OriginalName("EntityConfigNotFound")]
		EntityConfigNotFound,
		// Token: 0x0400BD2F RID: 48431
		[OriginalName("InstConfigNotFound")]
		InstConfigNotFound,
		// Token: 0x0400BD30 RID: 48432
		[OriginalName("FastReturnPosTypeNotSupport")]
		FastReturnPosTypeNotSupport,
		// Token: 0x0400BD31 RID: 48433
		[OriginalName("FastReturnPosConfigError")]
		FastReturnPosConfigError,
		// Token: 0x0400BD32 RID: 48434
		[OriginalName("TrackCustomBoardIsNull")]
		TrackCustomBoardIsNull,
		// Token: 0x0400BD33 RID: 48435
		[OriginalName("BtNodeConfigNotExist")]
		BtNodeConfigNotExist,
		// Token: 0x0400BD34 RID: 48436
		[OriginalName("BtNodeObjNotExist")]
		BtNodeObjNotExist,
		// Token: 0x0400BD35 RID: 48437
		[OriginalName("LevelPlayNotExist")]
		LevelPlayNotExist,
		// Token: 0x0400BD36 RID: 48438
		[OriginalName("LevelPlayDbDataNotExist")]
		LevelPlayDbDataNotExist,
		// Token: 0x0400BD37 RID: 48439
		[OriginalName("NotInRecallInst")]
		NotInRecallInst,
		// Token: 0x0400BD38 RID: 48440
		[OriginalName("SpecificRecallInfoNotExist")]
		SpecificRecallInfoNotExist,
		// Token: 0x0400BD39 RID: 48441
		[OriginalName("ElementalTypeNotMatch")]
		ElementalTypeNotMatch,
		// Token: 0x0400BD3A RID: 48442
		[OriginalName("ElementalMatchTypeIsEmpty")]
		ElementalMatchTypeIsEmpty,
		// Token: 0x0400BD3B RID: 48443
		[OriginalName("ErrComponentConfigNotExist")]
		ErrComponentConfigNotExist,
		// Token: 0x0400BD3C RID: 48444
		[OriginalName("ErrHasHandCasketCore")]
		ErrHasHandCasketCore,
		// Token: 0x0400BD3D RID: 48445
		[OriginalName("ErrNotHandCasketCore")]
		ErrNotHandCasketCore,
		// Token: 0x0400BD3E RID: 48446
		[OriginalName("ErrFoundationHasCore")]
		ErrFoundationHasCore,
		// Token: 0x0400BD3F RID: 48447
		[OriginalName("ErrFoundationHasNotCore")]
		ErrFoundationHasNotCore,
		// Token: 0x0400BD40 RID: 48448
		[OriginalName("ErrFoundationInteractCondNotMatch")]
		ErrFoundationInteractCondNotMatch,
		// Token: 0x0400BD41 RID: 48449
		[OriginalName("ErrElementalTypeNotMatch")]
		ErrElementalTypeNotMatch,
		// Token: 0x0400BD42 RID: 48450
		[OriginalName("ErrElementalHolderNotEnable")]
		ErrElementalHolderNotEnable,
		// Token: 0x0400BD43 RID: 48451
		[OriginalName("ElementalBoxNotInFoundation")]
		ElementalBoxNotInFoundation,
		// Token: 0x0400BD44 RID: 48452
		[OriginalName("ErrElementalBoxConfigNotExist")]
		ErrElementalBoxConfigNotExist,
		// Token: 0x0400BD45 RID: 48453
		[OriginalName("ErrMultigameQuestRecall")]
		ErrMultigameQuestRecall,
		// Token: 0x0400BD46 RID: 48454
		[OriginalName("ErrActionGetItemHasNotFreeSize")]
		ErrActionGetItemHasNotFreeSize,
		// Token: 0x0400BD47 RID: 48455
		[OriginalName("ErrInForceClosedArea")]
		ErrInForceClosedArea,
		// Token: 0x0400BD48 RID: 48456
		[OriginalName("DetailRecallInfoNotExist")]
		DetailRecallInfoNotExist,
		// Token: 0x0400BD49 RID: 48457
		[OriginalName("RecallDungeonIdNotExist")]
		RecallDungeonIdNotExist,
		// Token: 0x0400BD4A RID: 48458
		[OriginalName("ErrorCodeIdCreateRuleChange2")]
		IdCreateRuleChange2 = 2700001,
		// Token: 0x0400BD4B RID: 48459
		[OriginalName("RacingBetsActivityIdErr")]
		RacingBetsActivityIdErr,
		// Token: 0x0400BD4C RID: 48460
		[OriginalName("RacingBetsActivityDataErr")]
		RacingBetsActivityDataErr,
		// Token: 0x0400BD4D RID: 48461
		[OriginalName("RacingBetsRewardConfErr")]
		RacingBetsRewardConfErr,
		// Token: 0x0400BD4E RID: 48462
		[OriginalName("RacingBetsTaskIdNotExist")]
		RacingBetsTaskIdNotExist,
		// Token: 0x0400BD4F RID: 48463
		[OriginalName("RacingBetsTaskRewarded")]
		RacingBetsTaskRewarded,
		// Token: 0x0400BD50 RID: 48464
		[OriginalName("RacingBetsTaskUndone")]
		RacingBetsTaskUndone,
		// Token: 0x0400BD51 RID: 48465
		[OriginalName("RacingBetsTaskRewardFail")]
		RacingBetsTaskRewardFail,
		// Token: 0x0400BD52 RID: 48466
		[OriginalName("RacingBetsSeasonConfErr")]
		RacingBetsSeasonConfErr,
		// Token: 0x0400BD53 RID: 48467
		[OriginalName("RacingBetsLegMatchIdNotExist")]
		RacingBetsLegMatchIdNotExist,
		// Token: 0x0400BD54 RID: 48468
		[OriginalName("RacingBetsOddsTimesErr")]
		RacingBetsOddsTimesErr,
		// Token: 0x0400BD55 RID: 48469
		[OriginalName("RacingBetsOddsVersionErr")]
		RacingBetsOddsVersionErr,
		// Token: 0x0400BD56 RID: 48470
		[OriginalName("RacingBetsOddsVersionCodeErr")]
		RacingBetsOddsVersionCodeErr,
		// Token: 0x0400BD57 RID: 48471
		[OriginalName("RacingBetsOddsConfErr")]
		RacingBetsOddsConfErr,
		// Token: 0x0400BD58 RID: 48472
		[OriginalName("RacingBetsOddsDangoErr")]
		RacingBetsOddsDangoErr,
		// Token: 0x0400BD59 RID: 48473
		[OriginalName("RacingBetsOddsDangoConfErr")]
		RacingBetsOddsDangoConfErr,
		// Token: 0x0400BD5A RID: 48474
		[OriginalName("RacingBetsOddsTimeErr")]
		RacingBetsOddsTimeErr,
		// Token: 0x0400BD5B RID: 48475
		[OriginalName("RacingBetsOddsRetry")]
		RacingBetsOddsRetry,
		// Token: 0x0400BD5C RID: 48476
		[OriginalName("RacingBetsCostFundsErr")]
		RacingBetsCostFundsErr,
		// Token: 0x0400BD5D RID: 48477
		[OriginalName("RacingBetsGearTimesLimit")]
		RacingBetsGearTimesLimit,
		// Token: 0x0400BD5E RID: 48478
		[OriginalName("RacingBetsGearInfoErr")]
		RacingBetsGearInfoErr,
		// Token: 0x0400BD5F RID: 48479
		[OriginalName("RacingBetsGearRefundParamErr")]
		RacingBetsGearRefundParamErr,
		// Token: 0x0400BD60 RID: 48480
		[OriginalName("RacingBetsGearRefundFail")]
		RacingBetsGearRefundFail,
		// Token: 0x0400BD61 RID: 48481
		[OriginalName("RacingBetsGearNotRefund")]
		RacingBetsGearNotRefund,
		// Token: 0x0400BD62 RID: 48482
		[OriginalName("RacingBetsActivityConfErr")]
		RacingBetsActivityConfErr,
		// Token: 0x0400BD63 RID: 48483
		[OriginalName("RacingBetsOddsFundsLack")]
		RacingBetsOddsFundsLack,
		// Token: 0x0400BD64 RID: 48484
		[OriginalName("RacingBetsOddsLack")]
		RacingBetsOddsLack,
		// Token: 0x0400BD65 RID: 48485
		[OriginalName("RacingBetsGroupNotExist")]
		RacingBetsGroupNotExist,
		// Token: 0x0400BD66 RID: 48486
		[OriginalName("RacingBetsGroupConfNotExist")]
		RacingBetsGroupConfNotExist,
		// Token: 0x0400BD67 RID: 48487
		[OriginalName("RacingBetsGroupConfError")]
		RacingBetsGroupConfError,
		// Token: 0x0400BD68 RID: 48488
		[OriginalName("RacingBetsNotInInst")]
		RacingBetsNotInInst,
		// Token: 0x0400BD69 RID: 48489
		[OriginalName("RacingBetsFundsNotEnough")]
		RacingBetsFundsNotEnough,
		// Token: 0x0400BD6A RID: 48490
		[OriginalName("RacingBetsFundsCalcErr")]
		RacingBetsFundsCalcErr,
		// Token: 0x0400BD6B RID: 48491
		[OriginalName("RacingBetsLegMatchNotOpen")]
		RacingBetsLegMatchNotOpen,
		// Token: 0x0400BD6C RID: 48492
		[OriginalName("RacingBetsDangoActionTypeErr")]
		RacingBetsDangoActionTypeErr,
		// Token: 0x0400BD6D RID: 48493
		[OriginalName("RacingBetsDangoMatchParamErr")]
		RacingBetsDangoMatchParamErr,
		// Token: 0x0400BD6E RID: 48494
		[OriginalName("RacingBetsInstSubTypeErr")]
		RacingBetsInstSubTypeErr,
		// Token: 0x0400BD6F RID: 48495
		[OriginalName("RacingBetsEntityErr")]
		RacingBetsEntityErr,
		// Token: 0x0400BD70 RID: 48496
		[OriginalName("RacingBetsLegMatchIdErr")]
		RacingBetsLegMatchIdErr,
		// Token: 0x0400BD71 RID: 48497
		[OriginalName("RacingBetsBulletScreenTableNotExist")]
		RacingBetsBulletScreenTableNotExist,
		// Token: 0x0400BD72 RID: 48498
		[OriginalName("RacingBetsBulletScreenIdErr")]
		RacingBetsBulletScreenIdErr,
		// Token: 0x0400BD73 RID: 48499
		[OriginalName("RacingBetsBulletActionIndexNotExist")]
		RacingBetsBulletActionIndexNotExist,
		// Token: 0x0400BD74 RID: 48500
		[OriginalName("RacingBetsBulletScreenLegMatchNotExist")]
		RacingBetsBulletScreenLegMatchNotExist,
		// Token: 0x0400BD75 RID: 48501
		[OriginalName("RacingBetsBulletNotFundOpenRankCurTime")]
		RacingBetsBulletNotFundOpenRankCurTime,
		// Token: 0x0400BD76 RID: 48502
		[OriginalName("RacingBetsBulletGetRankErr")]
		RacingBetsBulletGetRankErr,
		// Token: 0x0400BD77 RID: 48503
		[OriginalName("RacingBetsBulletCD")]
		RacingBetsBulletCd,
		// Token: 0x0400BD78 RID: 48504
		[OriginalName("ActivityLinkageActivityIdConfErr")]
		ActivityLinkageActivityIdConfErr,
		// Token: 0x0400BD79 RID: 48505
		[OriginalName("ActivityLinkageConfErr")]
		ActivityLinkageConfErr,
		// Token: 0x0400BD7A RID: 48506
		[OriginalName("ActivityLinkageRewardErr")]
		ActivityLinkageRewardErr,
		// Token: 0x0400BD7B RID: 48507
		[OriginalName("ActivityLinkageDataErr")]
		ActivityLinkageDataErr,
		// Token: 0x0400BD7C RID: 48508
		[OriginalName("ActivityLinkageConfIndexErr")]
		ActivityLinkageConfIndexErr,
		// Token: 0x0400BD7D RID: 48509
		[OriginalName("ActivityLinkageRewardStatusErr")]
		ActivityLinkageRewardStatusErr,
		// Token: 0x0400BD7E RID: 48510
		[OriginalName("ActivityLinkagePageTimeErr")]
		ActivityLinkagePageTimeErr,
		// Token: 0x0400BD7F RID: 48511
		[OriginalName("RacingBetsdynamicOddsConfErr")]
		RacingBetsdynamicOddsConfErr,
		// Token: 0x0400BD80 RID: 48512
		[OriginalName("RacingBetsdynamicOddsProportionErr")]
		RacingBetsdynamicOddsProportionErr,
		// Token: 0x0400BD81 RID: 48513
		[OriginalName("RacingBetsDangoDataNotExist")]
		RacingBetsDangoDataNotExist,
		// Token: 0x0400BD82 RID: 48514
		[OriginalName("RacingBetsMatchDataErr")]
		RacingBetsMatchDataErr,
		// Token: 0x0400BD83 RID: 48515
		[OriginalName("RacingBetsMatchRoundTimeErr")]
		RacingBetsMatchRoundTimeErr,
		// Token: 0x0400BD84 RID: 48516
		[OriginalName("RacingBetsNotGear")]
		RacingBetsNotGear,
		// Token: 0x0400BD85 RID: 48517
		[OriginalName("RacingBetsLegSettle")]
		RacingBetsLegSettle,
		// Token: 0x0400BD86 RID: 48518
		[OriginalName("RacingBetsRankNotOpen")]
		RacingBetsRankNotOpen,
		// Token: 0x0400BD87 RID: 48519
		[OriginalName("RacingBetsActionIndexErr")]
		RacingBetsActionIndexErr,
		// Token: 0x0400BD88 RID: 48520
		[OriginalName("RacingBetsMatchRoundNotFund")]
		RacingBetsMatchRoundNotFund,
		// Token: 0x0400BD89 RID: 48521
		[OriginalName("RacingBetsDangoConfNotExist")]
		RacingBetsDangoConfNotExist,
		// Token: 0x0400BD8A RID: 48522
		[OriginalName("RacingBetsDangoTemplateConfNotExist")]
		RacingBetsDangoTemplateConfNotExist,
		// Token: 0x0400BD8B RID: 48523
		[OriginalName("RacingBetsDangoEntityCreateFail")]
		RacingBetsDangoEntityCreateFail,
		// Token: 0x0400BD8C RID: 48524
		[OriginalName("RacingBetsLegMatchConfNotExist")]
		RacingBetsLegMatchConfNotExist,
		// Token: 0x0400BD8D RID: 48525
		[OriginalName("PhantomBattleCardUnlocked")]
		PhantomBattleCardUnlocked,
		// Token: 0x0400BD8E RID: 48526
		[OriginalName("PhantomBattleActDataNotExist")]
		PhantomBattleActDataNotExist,
		// Token: 0x0400BD8F RID: 48527
		[OriginalName("RacingBetsLegNextOddsErr")]
		RacingBetsLegNextOddsErr,
		// Token: 0x0400BD90 RID: 48528
		[OriginalName("RacingBetsRankNotExist")]
		RacingBetsRankNotExist,
		// Token: 0x0400BD91 RID: 48529
		[OriginalName("RacingBetsPlayerNotExistInRank")]
		RacingBetsPlayerNotExistInRank,
		// Token: 0x0400BD92 RID: 48530
		[OriginalName("PhantomBattleCardTableNotExist")]
		PhantomBattleCardTableNotExist,
		// Token: 0x0400BD93 RID: 48531
		[OriginalName("PhantomBattleCardNumLimit")]
		PhantomBattleCardNumLimit,
		// Token: 0x0400BD94 RID: 48532
		[OriginalName("PhantomBattleActTableNotExist")]
		PhantomBattleActTableNotExist,
		// Token: 0x0400BD95 RID: 48533
		[OriginalName("PhantomBattleCardGroupLimit")]
		PhantomBattleCardGroupLimit,
		// Token: 0x0400BD96 RID: 48534
		[OriginalName("PhantomBattleGroupLimit")]
		PhantomBattleGroupLimit,
		// Token: 0x0400BD97 RID: 48535
		[OriginalName("PhantomBattleMainCostLimit")]
		PhantomBattleMainCostLimit,
		// Token: 0x0400BD98 RID: 48536
		[OriginalName("PhantomBattleCardLocked")]
		PhantomBattleCardLocked,
		// Token: 0x0400BD99 RID: 48537
		[OriginalName("PhantomBattleGroupNameLimit")]
		PhantomBattleGroupNameLimit,
		// Token: 0x0400BD9A RID: 48538
		[OriginalName("PhantomBattleGroupNotExist")]
		PhantomBattleGroupNotExist,
		// Token: 0x0400BD9B RID: 48539
		[OriginalName("PhantomBattleRomoveReason")]
		PhantomBattleRomoveReason,
		// Token: 0x0400BD9C RID: 48540
		[OriginalName("RacingBetsBulletIdErr")]
		RacingBetsBulletIdErr,
		// Token: 0x0400BD9D RID: 48541
		[OriginalName("RacingBetsPlayerDataNotExist")]
		RacingBetsPlayerDataNotExist,
		// Token: 0x0400BD9E RID: 48542
		[OriginalName("RacingBetsTaskDataNotExist")]
		RacingBetsTaskDataNotExist,
		// Token: 0x0400BD9F RID: 48543
		[OriginalName("PhantomBattleGroupElementLimit")]
		PhantomBattleGroupElementLimit,
		// Token: 0x0400BDA0 RID: 48544
		[OriginalName("PhantomBattleOutLookUped")]
		PhantomBattleOutLookUped,
		// Token: 0x0400BDA1 RID: 48545
		[OriginalName("PhantomBattleTaskConfNotExist")]
		PhantomBattleTaskConfNotExist,
		// Token: 0x0400BDA2 RID: 48546
		[OriginalName("PhantomBattleConditionDataErr")]
		PhantomBattleConditionDataErr,
		// Token: 0x0400BDA3 RID: 48547
		[OriginalName("PhantomBattleConditionConfNotExist")]
		PhantomBattleConditionConfNotExist,
		// Token: 0x0400BDA4 RID: 48548
		[OriginalName("PhantomBattleConditionGroupConfNotExist")]
		PhantomBattleConditionGroupConfNotExist,
		// Token: 0x0400BDA5 RID: 48549
		[OriginalName("PhantomBattleTaskStutas")]
		PhantomBattleTaskStutas,
		// Token: 0x0400BDA6 RID: 48550
		[OriginalName("PhantomBattleTaskReward")]
		PhantomBattleTaskReward,
		// Token: 0x0400BDA7 RID: 48551
		[OriginalName("PhantomBattleTaskNotFinish")]
		PhantomBattleTaskNotFinish,
		// Token: 0x0400BDA8 RID: 48552
		[OriginalName("PhantomBattleTaskProgressErr")]
		PhantomBattleTaskProgressErr,
		// Token: 0x0400BDA9 RID: 48553
		[OriginalName("PhantomBattleBadgeUnlocked")]
		PhantomBattleBadgeUnlocked,
		// Token: 0x0400BDAA RID: 48554
		[OriginalName("PhantomBattleLevelConfNotExist")]
		PhantomBattleLevelConfNotExist,
		// Token: 0x0400BDAB RID: 48555
		[OriginalName("PhantomBattBadgeRewardConfNotExist")]
		PhantomBattBadgeRewardConfNotExist,
		// Token: 0x0400BDAC RID: 48556
		[OriginalName("PhantomBattCardRewardConfNotExist")]
		PhantomBattCardRewardConfNotExist,
		// Token: 0x0400BDAD RID: 48557
		[OriginalName("PhantomBattBadgeUnlockNotEnough")]
		PhantomBattBadgeUnlockNotEnough,
		// Token: 0x0400BDAE RID: 48558
		[OriginalName("PhantomBattBadgeConfErr")]
		PhantomBattBadgeConfErr,
		// Token: 0x0400BDAF RID: 48559
		[OriginalName("PhantomBattBadgeRewardErr")]
		PhantomBattBadgeRewardErr,
		// Token: 0x0400BDB0 RID: 48560
		[OriginalName("PhantomBattleLevelRewardConfNotExist")]
		PhantomBattleLevelRewardConfNotExist,
		// Token: 0x0400BDB1 RID: 48561
		[OriginalName("PhantomBattCardUnlockNotEnough")]
		PhantomBattCardUnlockNotEnough,
		// Token: 0x0400BDB2 RID: 48562
		[OriginalName("PhantomBattCardRewardConfErr")]
		PhantomBattCardRewardConfErr,
		// Token: 0x0400BDB3 RID: 48563
		[OriginalName("PhantomBattLvNotEnough")]
		PhantomBattLvNotEnough,
		// Token: 0x0400BDB4 RID: 48564
		[OriginalName("PhantomBattLvRewardConfErr")]
		PhantomBattLvRewardConfErr,
		// Token: 0x0400BDB5 RID: 48565
		[OriginalName("PhantomBattCardRewardErr")]
		PhantomBattCardRewardErr,
		// Token: 0x0400BDB6 RID: 48566
		[OriginalName("PhantomBattLvRewardErr")]
		PhantomBattLvRewardErr,
		// Token: 0x0400BDB7 RID: 48567
		[OriginalName("PhantomBattLvRewardConfNotExist")]
		PhantomBattLvRewardConfNotExist,
		// Token: 0x0400BDB8 RID: 48568
		[OriginalName("PhantomBattRoleLock")]
		PhantomBattRoleLock,
		// Token: 0x0400BDB9 RID: 48569
		[OriginalName("PhantomBattRoleReward")]
		PhantomBattRoleReward,
		// Token: 0x0400BDBA RID: 48570
		[OriginalName("PhantomBattRoleRewardErr")]
		PhantomBattRoleRewardErr,
		// Token: 0x0400BDBB RID: 48571
		[OriginalName("PhantomBattPassRewardErr")]
		PhantomBattPassRewardErr,
		// Token: 0x0400BDBC RID: 48572
		[OriginalName("PhantomBattFirstPassRewardErr")]
		PhantomBattFirstPassRewardErr,
		// Token: 0x0400BDBD RID: 48573
		[OriginalName("PhantomBattleChallengeConfNotFind")]
		PhantomBattleChallengeConfNotFind,
		// Token: 0x0400BDBE RID: 48574
		[OriginalName("PhantomBattleChallengeOpenLimit")]
		PhantomBattleChallengeOpenLimit,
		// Token: 0x0400BDBF RID: 48575
		[OriginalName("PhantomBattleParamLimit")]
		PhantomBattleParamLimit,
		// Token: 0x0400BDC0 RID: 48576
		[OriginalName("PhantomBattleParamRepeat")]
		PhantomBattleParamRepeat,
		// Token: 0x0400BDC1 RID: 48577
		[OriginalName("PhantomBattleFuncOpenChallengeRepeat")]
		PhantomBattleFuncOpenChallengeRepeat,
		// Token: 0x0400BDC2 RID: 48578
		[OriginalName("PhantomBattleFuncOpenCardGroup")]
		PhantomBattleFuncOpenCardGroup,
		// Token: 0x0400BDC3 RID: 48579
		[OriginalName("PhantomBattleFuncOpenCard")]
		PhantomBattleFuncOpenCard,
		// Token: 0x0400BDC4 RID: 48580
		[OriginalName("PhantomBattleFuncOpenCardOutlookUp")]
		PhantomBattleFuncOpenCardOutlookUp,
		// Token: 0x0400BDC5 RID: 48581
		[OriginalName("PhantomBattleCardNotAllowBuy")]
		PhantomBattleCardNotAllowBuy,
		// Token: 0x0400BDC6 RID: 48582
		[OriginalName("FloroRanchHasUnSettleIns")]
		FloroRanchHasUnSettleIns,
		// Token: 0x0400BDC7 RID: 48583
		[OriginalName("FloroRanchSubInsConfNotExist")]
		FloroRanchSubInsConfNotExist,
		// Token: 0x0400BDC8 RID: 48584
		[OriginalName("FloroRanchRacesLimit")]
		FloroRanchRacesLimit,
		// Token: 0x0400BDC9 RID: 48585
		[OriginalName("FloroRanchBaseTerrainLimit")]
		FloroRanchBaseTerrainLimit,
		// Token: 0x0400BDCA RID: 48586
		[OriginalName("FloroRanchBaseCardLimit")]
		FloroRanchBaseCardLimit,
		// Token: 0x0400BDCB RID: 48587
		[OriginalName("FloroRanchRaceRepeat")]
		FloroRanchRaceRepeat,
		// Token: 0x0400BDCC RID: 48588
		[OriginalName("FloroRanchGamePlayNotExist")]
		FloroRanchGamePlayNotExist,
		// Token: 0x0400BDCD RID: 48589
		[OriginalName("FloroRanchGamePlayGachaNotExist")]
		FloroRanchGamePlayGachaNotExist,
		// Token: 0x0400BDCE RID: 48590
		[OriginalName("FloroRanchCardNotExistInGacha")]
		FloroRanchCardNotExistInGacha,
		// Token: 0x0400BDCF RID: 48591
		[OriginalName("FloroRanchPhantomCreateFail")]
		FloroRanchPhantomCreateFail,
		// Token: 0x0400BDD0 RID: 48592
		[OriginalName("FloroRanchTributeCoinLimit")]
		FloroRanchTributeCoinLimit,
		// Token: 0x0400BDD1 RID: 48593
		[OriginalName("FloroRanchRaceNotEnough")]
		FloroRanchRaceNotEnough,
		// Token: 0x0400BDD2 RID: 48594
		[OriginalName("FloroRanchStageNotSettle")]
		FloroRanchStageNotSettle,
		// Token: 0x0400BDD3 RID: 48595
		[OriginalName("FloroRanchActivitysNotFind")]
		FloroRanchActivitysNotFind,
		// Token: 0x0400BDD4 RID: 48596
		[OriginalName("FloroRanchGamePlayShopNotExist")]
		FloroRanchGamePlayShopNotExist,
		// Token: 0x0400BDD5 RID: 48597
		[OriginalName("FloroRanchGamePlayShopItemNotExist")]
		FloroRanchGamePlayShopItemNotExist,
		// Token: 0x0400BDD6 RID: 48598
		[OriginalName("FloroRanchDiamondNotEnough")]
		FloroRanchDiamondNotEnough,
		// Token: 0x0400BDD7 RID: 48599
		[OriginalName("FloroRanchCardTableNotExist")]
		FloroRanchCardTableNotExist,
		// Token: 0x0400BDD8 RID: 48600
		[OriginalName("FloroRanchToyTableNotExist")]
		FloroRanchToyTableNotExist,
		// Token: 0x0400BDD9 RID: 48601
		[OriginalName("FloroRanchTerrainTableNotExist")]
		FloroRanchTerrainTableNotExist,
		// Token: 0x0400BDDA RID: 48602
		[OriginalName("FloroRanchToyNumLimit")]
		FloroRanchToyNumLimit,
		// Token: 0x0400BDDB RID: 48603
		[OriginalName("FloroRanchNotEnoughToyIndex")]
		FloroRanchNotEnoughToyIndex,
		// Token: 0x0400BDDC RID: 48604
		[OriginalName("FloroRanchToyCreateFail")]
		FloroRanchToyCreateFail,
		// Token: 0x0400BDDD RID: 48605
		[OriginalName("FloroRanchCardGroupTableNotExist")]
		FloroRanchCardGroupTableNotExist,
		// Token: 0x0400BDDE RID: 48606
		[OriginalName("FloroRanchCardGroupNotExist")]
		FloroRanchCardGroupNotExist,
		// Token: 0x0400BDDF RID: 48607
		[OriginalName("FloroRanchBuffTableNotExist")]
		FloroRanchBuffTableNotExist,
		// Token: 0x0400BDE0 RID: 48608
		[OriginalName("FloroRanchRemoveUnitNotExist")]
		FloroRanchRemoveUnitNotExist,
		// Token: 0x0400BDE1 RID: 48609
		[OriginalName("PhantomBattleCardMaxLimit")]
		PhantomBattleCardMaxLimit,
		// Token: 0x0400BDE2 RID: 48610
		[OriginalName("FloroRanchRefreshTableNotExist")]
		FloroRanchRefreshTableNotExist,
		// Token: 0x0400BDE3 RID: 48611
		[OriginalName("FloroRanchPlayTaskNotExist")]
		FloroRanchPlayTaskNotExist,
		// Token: 0x0400BDE4 RID: 48612
		[OriginalName("FloroRanchSkillTableNotExist")]
		FloroRanchSkillTableNotExist,
		// Token: 0x0400BDE5 RID: 48613
		[OriginalName("FloroRanchSkillUseTimesLimit")]
		FloroRanchSkillUseTimesLimit,
		// Token: 0x0400BDE6 RID: 48614
		[OriginalName("FloroRanchSkillLogicNotExist")]
		FloroRanchSkillLogicNotExist,
		// Token: 0x0400BDE7 RID: 48615
		[OriginalName("FloroRanchSkillLogicErr")]
		FloroRanchSkillLogicErr,
		// Token: 0x0400BDE8 RID: 48616
		[OriginalName("FloroRanchSkillLogicFail")]
		FloroRanchSkillLogicFail,
		// Token: 0x0400BDE9 RID: 48617
		[OriginalName("PhantomBattleNameLimitConfErr")]
		PhantomBattleNameLimitConfErr,
		// Token: 0x0400BDEA RID: 48618
		[OriginalName("FloroRanchNotEnableUnlimitedMode")]
		FloroRanchNotEnableUnlimitedMode,
		// Token: 0x0400BDEB RID: 48619
		[OriginalName("PhantomBattleLimitTime")]
		PhantomBattleLimitTime,
		// Token: 0x0400BDEC RID: 48620
		[OriginalName("FloroRanchToyWeightConfErr")]
		FloroRanchToyWeightConfErr,
		// Token: 0x0400BDED RID: 48621
		[OriginalName("FloroRanchAnimalNumLimit")]
		FloroRanchAnimalNumLimit,
		// Token: 0x0400BDEE RID: 48622
		[OriginalName("FloroRanchRaceTableNotFind")]
		FloroRanchRaceTableNotFind,
		// Token: 0x0400BDEF RID: 48623
		[OriginalName("FloroRanchRaceLock")]
		FloroRanchRaceLock,
		// Token: 0x0400BDF0 RID: 48624
		[OriginalName("FloroRanchSkillLock")]
		FloroRanchSkillLock,
		// Token: 0x0400BDF1 RID: 48625
		[OriginalName("FloroRanchSubInsLock")]
		FloroRanchSubInsLock,
		// Token: 0x0400BDF2 RID: 48626
		[OriginalName("RoleSelfBgmUnableOperate")]
		RoleSelfBgmUnableOperate,
		// Token: 0x0400BDF3 RID: 48627
		[OriginalName("RoleSelfBgmFlyTableNotExist")]
		RoleSelfBgmFlyTableNotExist,
		// Token: 0x0400BDF4 RID: 48628
		[OriginalName("RoleSelfBgmUnableOp")]
		RoleSelfBgmUnableOp,
		// Token: 0x0400BDF5 RID: 48629
		[OriginalName("FloroRanchInsLock")]
		FloroRanchInsLock,
		// Token: 0x0400BDF6 RID: 48630
		[OriginalName("FloroRanchInsConfNotFind")]
		FloroRanchInsConfNotFind,
		// Token: 0x0400BDF7 RID: 48631
		[OriginalName("FloroRanchInsIdNotFind")]
		FloroRanchInsIdNotFind,
		// Token: 0x0400BDF8 RID: 48632
		[OriginalName("FloroRanchInsRaceNotInReq")]
		FloroRanchInsRaceNotInReq,
		// Token: 0x0400BDF9 RID: 48633
		[OriginalName("FloroRanchUnEnableTribute")]
		FloroRanchUnEnableTribute,
		// Token: 0x0400BDFA RID: 48634
		[OriginalName("FloroRanchIsMulti")]
		FloroRanchIsMulti,
		// Token: 0x0400BDFB RID: 48635
		[OriginalName("ButtonLockParamLimit")]
		ButtonLockParamLimit,
		// Token: 0x0400BDFC RID: 48636
		[OriginalName("ButtonLockParamRepeat")]
		ButtonLockParamRepeat,
		// Token: 0x0400BDFD RID: 48637
		[OriginalName("PhantomBattlePlayerCardGroupBuildErr")]
		PhantomBattlePlayerCardGroupBuildErr,
		// Token: 0x0400BDFE RID: 48638
		[OriginalName("PhantomBattleNpcCardGroupBuildErr")]
		PhantomBattleNpcCardGroupBuildErr,
		// Token: 0x0400BDFF RID: 48639
		[OriginalName("PhantomBattleNpcRecordLoadFail")]
		PhantomBattleNpcRecordLoadFail,
		// Token: 0x0400BE00 RID: 48640
		[OriginalName("PhantomBattleCardTypeErr")]
		PhantomBattleCardTypeErr,
		// Token: 0x0400BE01 RID: 48641
		[OriginalName("PhantomBattleActTypeErr")]
		PhantomBattleActTypeErr,
		// Token: 0x0400BE02 RID: 48642
		[OriginalName("PhantomNoDurableSkill")]
		PhantomNoDurableSkill,
		// Token: 0x0400BE03 RID: 48643
		[OriginalName("PhantomBattleAreaCardNumLimit")]
		PhantomBattleAreaCardNumLimit,
		// Token: 0x0400BE04 RID: 48644
		[OriginalName("PhantomBattleItemCardNumLimit")]
		PhantomBattleItemCardNumLimit,
		// Token: 0x0400BE05 RID: 48645
		[OriginalName("PhantomBattleCallTaskNumErr")]
		PhantomBattleCallTaskNumErr,
		// Token: 0x0400BE06 RID: 48646
		[OriginalName("PhantomBattleNotCanSoltIndex")]
		PhantomBattleNotCanSoltIndex,
		// Token: 0x0400BE07 RID: 48647
		[OriginalName("PhantomBattleSoltMaxLimit")]
		PhantomBattleSoltMaxLimit,
		// Token: 0x0400BE08 RID: 48648
		[OriginalName("PhantomBattleTaskIdErr")]
		PhantomBattleTaskIdErr,
		// Token: 0x0400BE09 RID: 48649
		[OriginalName("PhantomBattleActIdErr")]
		PhantomBattleActIdErr,
		// Token: 0x0400BE0A RID: 48650
		[OriginalName("PhantomBattleConditionParamErr")]
		PhantomBattleConditionParamErr,
		// Token: 0x0400BE0B RID: 48651
		[OriginalName("PhantomBattleAreaCardConfigErr")]
		PhantomBattleAreaCardConfigErr,
		// Token: 0x0400BE0C RID: 48652
		[OriginalName("PhantomBattleAreaLock")]
		PhantomBattleAreaLock,
		// Token: 0x0400BE0D RID: 48653
		[OriginalName("PhantomBattleGuideActTableNotExist")]
		PhantomBattleGuideActTableNotExist,
		// Token: 0x0400BE0E RID: 48654
		[OriginalName("NewPlayerSupportTaskConfNotExist")]
		NewPlayerSupportTaskConfNotExist,
		// Token: 0x0400BE0F RID: 48655
		[OriginalName("NewPlayerSupportTaskRewardIndex")]
		NewPlayerSupportTaskRewardIndex,
		// Token: 0x0400BE10 RID: 48656
		[OriginalName("NewPlayerSupportTaskParamLimit")]
		NewPlayerSupportTaskParamLimit,
		// Token: 0x0400BE11 RID: 48657
		[OriginalName("NewPlayerSupportTaskParamRepeat")]
		NewPlayerSupportTaskParamRepeat,
		// Token: 0x0400BE12 RID: 48658
		[OriginalName("NewPlayerSupportTaskReward")]
		NewPlayerSupportTaskReward,
		// Token: 0x0400BE13 RID: 48659
		[OriginalName("NewPlayerSupportTaskNotFinish")]
		NewPlayerSupportTaskNotFinish,
		// Token: 0x0400BE14 RID: 48660
		[OriginalName("NewPlayerSupportDataNotEixst")]
		NewPlayerSupportDataNotEixst,
		// Token: 0x0400BE15 RID: 48661
		[OriginalName("NewPlayerSupportNotFindTrialRole")]
		NewPlayerSupportNotFindTrialRole,
		// Token: 0x0400BE16 RID: 48662
		[OriginalName("NewPlayerSupportRoleLock")]
		NewPlayerSupportRoleLock,
		// Token: 0x0400BE17 RID: 48663
		[OriginalName("NewPlayerSupportWorldLvErr")]
		NewPlayerSupportWorldLvErr,
		// Token: 0x0400BE18 RID: 48664
		[OriginalName("NewPlayerSupportRolePageErr")]
		NewPlayerSupportRolePageErr,
		// Token: 0x0400BE19 RID: 48665
		[OriginalName("NewTrialRoleActivityRoleCheckErr")]
		NewTrialRoleActivityRoleCheckErr,
		// Token: 0x0400BE1A RID: 48666
		[OriginalName("NewTrialRoleActivityInsNotFind")]
		NewTrialRoleActivityInsNotFind,
		// Token: 0x0400BE1B RID: 48667
		[OriginalName("NewTrialRoleActivityInsUnableUse")]
		NewTrialRoleActivityInsUnableUse,
		// Token: 0x0400BE1C RID: 48668
		[OriginalName("NewTrialRoleActivityLogicNotFind")]
		NewTrialRoleActivityLogicNotFind,
		// Token: 0x0400BE1D RID: 48669
		[OriginalName("NewTrialRoleActivityDelegateNotFind")]
		NewTrialRoleActivityDelegateNotFind,
		// Token: 0x0400BE1E RID: 48670
		[OriginalName("RegressNotFindTrialRole")]
		RegressNotFindTrialRole,
		// Token: 0x0400BE1F RID: 48671
		[OriginalName("RegressNotFindActivityTrialRole")]
		RegressNotFindActivityTrialRole,
		// Token: 0x0400BE20 RID: 48672
		[OriginalName("RegressDisposableReward")]
		RegressDisposableReward,
		// Token: 0x0400BE21 RID: 48673
		[OriginalName("RegressDisposableRewardConfigNotFind")]
		RegressDisposableRewardConfigNotFind,
		// Token: 0x0400BE22 RID: 48674
		[OriginalName("RegressPayBonusLimit")]
		RegressPayBonusLimit,
		// Token: 0x0400BE23 RID: 48675
		[OriginalName("GachaRoleDevelopInsNotOpen")]
		GachaRoleDevelopInsNotOpen,
		// Token: 0x0400BE24 RID: 48676
		[OriginalName("PhantomBattleNoComponent")]
		PhantomBattleNoComponent,
		// Token: 0x0400BE25 RID: 48677
		[OriginalName("PhantomBattleUnableSkip")]
		PhantomBattleUnableSkip,
		// Token: 0x0400BE26 RID: 48678
		[OriginalName("RegressMaxBonusItemNum")]
		RegressMaxBonusItemNum,
		// Token: 0x0400BE27 RID: 48679
		[OriginalName("RegressBonusRewardNoConfig")]
		RegressBonusRewardNoConfig,
		// Token: 0x0400BE28 RID: 48680
		[OriginalName("RegressBonusBuyLvLimit")]
		RegressBonusBuyLvLimit,
		// Token: 0x0400BE29 RID: 48681
		[OriginalName("PhantomBattleCallCardLimt")]
		PhantomBattleCallCardLimt,
		// Token: 0x0400BE2A RID: 48682
		[OriginalName("PhantomBattleCallItemLimt")]
		PhantomBattleCallItemLimt,
		// Token: 0x0400BE2B RID: 48683
		[OriginalName("GachaRoleDevelopInsLimit")]
		GachaRoleDevelopInsLimit,
		// Token: 0x0400BE2C RID: 48684
		[OriginalName("GachaRolesilentAreaIdNotFind")]
		GachaRolesilentAreaIdNotFind,
		// Token: 0x0400BE2D RID: 48685
		[OriginalName("GachaRolesilentAreaUnlock")]
		GachaRolesilentAreaUnlock,
		// Token: 0x0400BE2E RID: 48686
		[OriginalName("NewTrialRoleActivityNotFindTrialRoleConf")]
		NewTrialRoleActivityNotFindTrialRoleConf,
		// Token: 0x0400BE2F RID: 48687
		[OriginalName("PhantomBattleSkipErr")]
		PhantomBattleSkipErr,
		// Token: 0x0400BE30 RID: 48688
		[OriginalName("NewTrialRoleGachaRoleDevelopNotFind")]
		NewTrialRoleGachaRoleDevelopNotFind,
		// Token: 0x0400BE31 RID: 48689
		[OriginalName("RegressTrialRoleLock")]
		RegressTrialRoleLock,
		// Token: 0x0400BE32 RID: 48690
		[OriginalName("NewPlayerSupportTrialRoleLock")]
		NewPlayerSupportTrialRoleLock,
		// Token: 0x0400BE33 RID: 48691
		[OriginalName("PhantomBattleCopyCardLimit")]
		PhantomBattleCopyCardLimit,
		// Token: 0x0400BE34 RID: 48692
		[OriginalName("RegressTrialNoCanRewardTask")]
		RegressTrialNoCanRewardTask,
		// Token: 0x0400BE35 RID: 48693
		[OriginalName("NewPlayerSupportNoCanRewardTask")]
		NewPlayerSupportNoCanRewardTask,
		// Token: 0x0400BE36 RID: 48694
		[OriginalName("FarmGoldPointReqLimit")]
		FarmGoldPointReqLimit,
		// Token: 0x0400BE37 RID: 48695
		[OriginalName("FarmGoldPointReqErr")]
		FarmGoldPointReqErr,
		// Token: 0x0400BE38 RID: 48696
		[OriginalName("FarmGoldPointReqRe")]
		FarmGoldPointReqRe,
		// Token: 0x0400BE39 RID: 48697
		[OriginalName("FarmGoldLevelReqLimit")]
		FarmGoldLevelReqLimit,
		// Token: 0x0400BE3A RID: 48698
		[OriginalName("FarmGoldLevelReqErr")]
		FarmGoldLevelReqErr,
		// Token: 0x0400BE3B RID: 48699
		[OriginalName("FarmGoldLevelReqRe")]
		FarmGoldLevelReqRe,
		// Token: 0x0400BE3C RID: 48700
		[OriginalName("FarmGoldPointRewardDropErr")]
		FarmGoldPointRewardDropErr,
		// Token: 0x0400BE3D RID: 48701
		[OriginalName("FarmGoldLevelRewardDropErr")]
		FarmGoldLevelRewardDropErr,
		// Token: 0x0400BE3E RID: 48702
		[OriginalName("NewTrialRoleInCurTeam")]
		NewTrialRoleInCurTeam,
		// Token: 0x0400BE3F RID: 48703
		[OriginalName("RegressEndTimeErr")]
		RegressEndTimeErr,
		// Token: 0x0400BE40 RID: 48704
		[OriginalName("NewTrialRoleMatchingUnableTrial")]
		NewTrialRoleMatchingUnableTrial,
		// Token: 0x0400BE41 RID: 48705
		[OriginalName("PhBaFindCd")]
		PhBaFindCd,
		// Token: 0x0400BE42 RID: 48706
		[OriginalName("PhBaTargetPlanNotExist")]
		PhBaTargetPlanNotExist,
		// Token: 0x0400BE43 RID: 48707
		[OriginalName("PhBaPlanUploadErr")]
		PhBaPlanUploadErr,
		// Token: 0x0400BE44 RID: 48708
		[OriginalName("PhBaPlanErr")]
		PhBaPlanErr,
		// Token: 0x0400BE45 RID: 48709
		[OriginalName("PhBaSaveCd")]
		PhBaSaveCd,
		// Token: 0x0400BE46 RID: 48710
		[OriginalName("PhBaAttrNotInCost")]
		PhBaAttrNotInCost,
		// Token: 0x0400BE47 RID: 48711
		[OriginalName("PhBaCostMainPropNotExist")]
		PhBaCostMainPropNotExist,
		// Token: 0x0400BE48 RID: 48712
		[OriginalName("PhBaFetterGroupLimit")]
		PhBaFetterGroupLimit,
		// Token: 0x0400BE49 RID: 48713
		[OriginalName("PhBaAttrTypeLimit")]
		PhBaAttrTypeLimit,
		// Token: 0x0400BE4A RID: 48714
		[OriginalName("PhBaCostTypeNumLimit")]
		PhBaCostTypeNumLimit,
		// Token: 0x0400BE4B RID: 48715
		[OriginalName("PhBaCodeLimit")]
		PhBaCodeLimit,
		// Token: 0x0400BE4C RID: 48716
		[OriginalName("PhBaCodeIllegal")]
		PhBaCodeIllegal,
		// Token: 0x0400BE4D RID: 48717
		[OriginalName("PhBaCurUsePlanNotExist")]
		PhBaCurUsePlanNotExist,
		// Token: 0x0400BE4E RID: 48718
		[OriginalName("PhBaTargetSuitNotExist")]
		PhBaTargetSuitNotExist,
		// Token: 0x0400BE4F RID: 48719
		[OriginalName("PhBaPlanFuncNotOpen")]
		PhBaPlanFuncNotOpen,
		// Token: 0x0400BE50 RID: 48720
		[OriginalName("InsUnableMultiEnter")]
		InsUnableMultiEnter,
		// Token: 0x0400BE51 RID: 48721
		[OriginalName("PhBaPlanSuitCountErr")]
		PhBaPlanSuitCountErr,
		// Token: 0x0400BE52 RID: 48722
		[OriginalName("PhBaPlanTargetSuitNotExist")]
		PhBaPlanTargetSuitNotExist,
		// Token: 0x0400BE53 RID: 48723
		[OriginalName("NewTrialRoleNumLimit")]
		NewTrialRoleNumLimit,
		// Token: 0x0400BE54 RID: 48724
		[OriginalName("PhBaPlanCostTypeRepeat")]
		PhBaPlanCostTypeRepeat,
		// Token: 0x0400BE55 RID: 48725
		[OriginalName("PhBaPlanSuitIdRepeat")]
		PhBaPlanSuitIdRepeat,
		// Token: 0x0400BE56 RID: 48726
		[OriginalName("RacingBetsNotFindOrderListDango")]
		RacingBetsNotFindOrderListDango,
		// Token: 0x0400BE57 RID: 48727
		[OriginalName("PhBaPlanBatchOperEnumErr")]
		PhBaPlanBatchOperEnumErr,
		// Token: 0x0400BE58 RID: 48728
		[OriginalName("PhBaPlanRemotePlanNotExist")]
		PhBaPlanRemotePlanNotExist,
		// Token: 0x0400BE59 RID: 48729
		[OriginalName("H5ViewActivityNotFindDb")]
		H5ViewActivityNotFindDb,
		// Token: 0x0400BE5A RID: 48730
		[OriginalName("ForoRanchWeekInsNotFind")]
		ForoRanchWeekInsNotFind,
		// Token: 0x0400BE5B RID: 48731
		[OriginalName("PhBaPlanCodeCreateErr")]
		PhBaPlanCodeCreateErr,
		// Token: 0x0400BE5C RID: 48732
		[OriginalName("RacingBetsOddsDangoIllegal")]
		RacingBetsOddsDangoIllegal,
		// Token: 0x0400BE5D RID: 48733
		[OriginalName("ForoRanchNotCurEvent")]
		ForoRanchNotCurEvent,
		// Token: 0x0400BE5E RID: 48734
		[OriginalName("ForoRanchEventIncIdErr")]
		ForoRanchEventIncIdErr,
		// Token: 0x0400BE5F RID: 48735
		[OriginalName("ForoRanchEventChoiceErr")]
		ForoRanchEventChoiceErr,
		// Token: 0x0400BE60 RID: 48736
		[OriginalName("ForoRanchEventSubChoicesConfNotExist")]
		ForoRanchEventSubChoicesConfNotExist,
		// Token: 0x0400BE61 RID: 48737
		[OriginalName("ForoRanchEventChoicesConfNotExist")]
		ForoRanchEventChoicesConfNotExist,
		// Token: 0x0400BE62 RID: 48738
		[OriginalName("ForoRanchSubInsIdNoActivityId")]
		ForoRanchSubInsIdNoActivityId,
		// Token: 0x0400BE63 RID: 48739
		[OriginalName("ForoRanchGetSubWeekInsErr")]
		ForoRanchGetSubWeekInsErr,
		// Token: 0x0400BE64 RID: 48740
		[OriginalName("ForoRanchSubInsNotOpen")]
		ForoRanchSubInsNotOpen,
		// Token: 0x0400BE65 RID: 48741
		[OriginalName("ForoRanchVoidToyNotEnough")]
		ForoRanchVoidToyNotEnough,
		// Token: 0x0400BE66 RID: 48742
		[OriginalName("ForoRanchToyNotEnough")]
		ForoRanchToyNotEnough,
		// Token: 0x0400BE67 RID: 48743
		[OriginalName("RoverRogueInsNotExist")]
		RoverRogueInsNotExist,
		// Token: 0x0400BE68 RID: 48744
		[OriginalName("RoverRogueCompCreateFail")]
		RoverRogueCompCreateFail,
		// Token: 0x0400BE69 RID: 48745
		[OriginalName("RoverRogueNotFindRoomConf")]
		RoverRogueNotFindRoomConf,
		// Token: 0x0400BE6A RID: 48746
		[OriginalName("RoverRogueNotFindBornEntityId")]
		RoverRogueNotFindBornEntityId,
		// Token: 0x0400BE6B RID: 48747
		[OriginalName("RoverRogueLootLock")]
		RoverRogueLootLock,
		// Token: 0x0400BE6C RID: 48748
		[OriginalName("RoverRogueComponentNotFind")]
		RoverRogueComponentNotFind,
		// Token: 0x0400BE6D RID: 48749
		[OriginalName("RoverRogueGetNextRoomFail")]
		RoverRogueGetNextRoomFail,
		// Token: 0x0400BE6E RID: 48750
		[OriginalName("RoverRogueExitNumLess")]
		RoverRogueExitNumLess,
		// Token: 0x0400BE6F RID: 48751
		[OriginalName("RoverRogueExitEntityConfNotFind")]
		RoverRogueExitEntityConfNotFind,
		// Token: 0x0400BE70 RID: 48752
		[OriginalName("RoverRogueCreateExitEntityFail")]
		RoverRogueCreateExitEntityFail,
		// Token: 0x0400BE71 RID: 48753
		[OriginalName("RoverRogueNotFindRoomTypeConf")]
		RoverRogueNotFindRoomTypeConf,
		// Token: 0x0400BE72 RID: 48754
		[OriginalName("RoverRoguePortalEntityNotFind")]
		RoverRoguePortalEntityNotFind,
		// Token: 0x0400BE73 RID: 48755
		[OriginalName("RoverRogueNotFindEntityLogic")]
		RoverRogueNotFindEntityLogic,
		// Token: 0x0400BE74 RID: 48756
		[OriginalName("RoverRogueInsCtxNotExist")]
		RoverRogueInsCtxNotExist,
		// Token: 0x0400BE75 RID: 48757
		[OriginalName("RoverRogueRoleConfNotExist")]
		RoverRogueRoleConfNotExist,
		// Token: 0x0400BE76 RID: 48758
		[OriginalName("RoverRogueGainDataTypeErr")]
		RoverRogueGainDataTypeErr,
		// Token: 0x0400BE77 RID: 48759
		[OriginalName("RoverRogueGainActiveErr")]
		RoverRogueGainActiveErr,
		// Token: 0x0400BE78 RID: 48760
		[OriginalName("RoverRogueRewardDbNotExist")]
		RoverRogueRewardDbNotExist,
		// Token: 0x0400BE79 RID: 48761
		[OriginalName("RoverRogueGainSelectNotExist")]
		RoverRogueGainSelectNotExist,
		// Token: 0x0400BE7A RID: 48762
		[OriginalName("RoverRogueGainTagChangeErr")]
		RoverRogueGainTagChangeErr,
		// Token: 0x0400BE7B RID: 48763
		[OriginalName("RoverRogueGainLogicNotFind")]
		RoverRogueGainLogicNotFind,
		// Token: 0x0400BE7C RID: 48764
		[OriginalName("RoverRogueGainLogicErr")]
		RoverRogueGainLogicErr,
		// Token: 0x0400BE7D RID: 48765
		[OriginalName("ForoRanchWeeklyCanNotMilestone")]
		ForoRanchWeeklyCanNotMilestone,
		// Token: 0x0400BE7E RID: 48766
		[OriginalName("RoverRogueRewardDbToken")]
		RoverRogueRewardDbToken,
		// Token: 0x0400BE7F RID: 48767
		[OriginalName("RoverRogueRoleTypeConfNotExist")]
		RoverRogueRoleTypeConfNotExist,
		// Token: 0x0400BE80 RID: 48768
		[OriginalName("RoverRogueRoomRewardNotInit")]
		RoverRogueRoomRewardNotInit,
		// Token: 0x0400BE81 RID: 48769
		[OriginalName("RoverRogueRoomTaskNotExist")]
		RoverRogueRoomTaskNotExist,
		// Token: 0x0400BE82 RID: 48770
		[OriginalName("RoverRogueRoomBlessGroupTaskNotExist")]
		RoverRogueRoomBlessGroupTaskNotExist,
		// Token: 0x0400BE83 RID: 48771
		[OriginalName("RoverRogueRoomTaskTypeErr")]
		RoverRogueRoomTaskTypeErr,
		// Token: 0x0400BE84 RID: 48772
		[OriginalName("RoverRogueRoomTaskParamErr")]
		RoverRogueRoomTaskParamErr,
		// Token: 0x0400BE85 RID: 48773
		[OriginalName("RoverRogueRoomTaskIsToken")]
		RoverRogueRoomTaskIsToken,
		// Token: 0x0400BE86 RID: 48774
		[OriginalName("RoverRogueNotCompletedInsErr")]
		RoverRogueNotCompletedInsErr,
		// Token: 0x0400BE87 RID: 48775
		[OriginalName("RoverRogueNotFindRoomRewardConf")]
		RoverRogueNotFindRoomRewardConf,
		// Token: 0x0400BE88 RID: 48776
		[OriginalName("RoverRogueRoomNotFinish")]
		RoverRogueRoomNotFinish,
		// Token: 0x0400BE89 RID: 48777
		[OriginalName("RoverRogueRoomRewardNotActivate")]
		RoverRogueRoomRewardNotActivate,
		// Token: 0x0400BE8A RID: 48778
		[OriginalName("RoverRogueRoomRewardCache")]
		RoverRogueRoomRewardCache,
		// Token: 0x0400BE8B RID: 48779
		[OriginalName("RoverRogueRoleListErr")]
		RoverRogueRoleListErr,
		// Token: 0x0400BE8C RID: 48780
		[OriginalName("RoverRogueRoleTypeErr")]
		RoverRogueRoleTypeErr,
		// Token: 0x0400BE8D RID: 48781
		[OriginalName("RoverRogueNotFindActConf")]
		RoverRogueNotFindActConf,
		// Token: 0x0400BE8E RID: 48782
		[OriginalName("RoverRogueLootNumLimit")]
		RoverRogueLootNumLimit,
		// Token: 0x0400BE8F RID: 48783
		[OriginalName("RoverRogueNotFindBlessRoleConf")]
		RoverRogueNotFindBlessRoleConf,
		// Token: 0x0400BE90 RID: 48784
		[OriginalName("RoverRogueNotFindBollToPortal")]
		RoverRogueNotFindBollToPortal,
		// Token: 0x0400BE91 RID: 48785
		[OriginalName("RoverRogueNotFindBollNotExist")]
		RoverRogueNotFindBollNotExist,
		// Token: 0x0400BE92 RID: 48786
		[OriginalName("RoverRogueNotFindRoomRoadConf")]
		RoverRogueNotFindRoomRoadConf,
		// Token: 0x0400BE93 RID: 48787
		[OriginalName("RoverRogueNotFindChaosConf")]
		RoverRogueNotFindChaosConf,
		// Token: 0x0400BE94 RID: 48788
		[OriginalName("RoverRogueChaosExitNotEnough")]
		RoverRogueChaosExitNotEnough,
		// Token: 0x0400BE95 RID: 48789
		[OriginalName("RoverRoguePosNotFind")]
		RoverRoguePosNotFind,
		// Token: 0x0400BE96 RID: 48790
		[OriginalName("RoverRogueChangeSameLoot")]
		RoverRogueChangeSameLoot,
		// Token: 0x0400BE97 RID: 48791
		[OriginalName("GateUdpPortNotExist")]
		GateUdpPortNotExist = 2800000,
		// Token: 0x0400BE98 RID: 48792
		[OriginalName("GateKcpGetConvFail")]
		GateKcpGetConvFail,
		// Token: 0x0400BE99 RID: 48793
		[OriginalName("ErrScreenActionExecutorNotFind")]
		ErrScreenActionExecutorNotFind = 2900000,
		// Token: 0x0400BE9A RID: 48794
		[OriginalName("ErrScreenActionInfoNotFind")]
		ErrScreenActionInfoNotFind,
		// Token: 0x0400BE9B RID: 48795
		[OriginalName("ErrScreenActionTypeNotMatch")]
		ErrScreenActionTypeNotMatch,
		// Token: 0x0400BE9C RID: 48796
		[OriginalName("ErrScreenActionNotFadeInScreen")]
		ErrScreenActionNotFadeInScreen,
		// Token: 0x0400BE9D RID: 48797
		[OriginalName("ErrScreenActionNotFadeOutScreen")]
		ErrScreenActionNotFadeOutScreen,
		// Token: 0x0400BE9E RID: 48798
		[OriginalName("ErrSceneItemSequenceFrameRegister")]
		ErrSceneItemSequenceFrameRegister,
		// Token: 0x0400BE9F RID: 48799
		[OriginalName("ErrSceneItemSequenceFrameComponentConfig")]
		ErrSceneItemSequenceFrameComponentConfig,
		// Token: 0x0400BEA0 RID: 48800
		[OriginalName("ErrSceneItemSequenceFrameComponent")]
		ErrSceneItemSequenceFrameComponent,
		// Token: 0x0400BEA1 RID: 48801
		[OriginalName("ErrSceneItemSequenceFrame")]
		ErrSceneItemSequenceFrame,
		// Token: 0x0400BEA2 RID: 48802
		[OriginalName("ErrSceneItemSequenceFrameMatchEventCbType")]
		ErrSceneItemSequenceFrameMatchEventCbType,
		// Token: 0x0400BEA3 RID: 48803
		[OriginalName("ErrSceneItemSequenceFrameNeedServerAction")]
		ErrSceneItemSequenceFrameNeedServerAction,
		// Token: 0x0400BEA4 RID: 48804
		[OriginalName("ErrSceneItemSequenceFrameUnAnsEvent")]
		ErrSceneItemSequenceFrameUnAnsEvent,
		// Token: 0x0400BEA5 RID: 48805
		[OriginalName("ErrSceneBlockSplitNotBlock")]
		ErrSceneBlockSplitNotBlock = 2900027,
		// Token: 0x0400BEA6 RID: 48806
		[OriginalName("ErrSunSpiritCollectOverNum")]
		ErrSunSpiritCollectOverNum = 2900012,
		// Token: 0x0400BEA7 RID: 48807
		[OriginalName("ErrSunSpiritInteractAction")]
		ErrSunSpiritInteractAction,
		// Token: 0x0400BEA8 RID: 48808
		[OriginalName("ErrSunSpiritGetComponentConfig")]
		ErrSunSpiritGetComponentConfig,
		// Token: 0x0400BEA9 RID: 48809
		[OriginalName("ErrSunSpiritEntityRemove")]
		ErrSunSpiritEntityRemove,
		// Token: 0x0400BEAA RID: 48810
		[OriginalName("ErrSunSpiritRepeateAdd")]
		ErrSunSpiritRepeateAdd,
		// Token: 0x0400BEAB RID: 48811
		[OriginalName("ErrSunSpiritNumUnEnough")]
		ErrSunSpiritNumUnEnough,
		// Token: 0x0400BEAC RID: 48812
		[OriginalName("ErrSunSpiritEnableEntityHistoryUse")]
		ErrSunSpiritEnableEntityHistoryUse,
		// Token: 0x0400BEAD RID: 48813
		[OriginalName("ErrSunSpiritGetPlayerTempOccupySunSpiritInfo")]
		ErrSunSpiritGetPlayerTempOccupySunSpiritInfo,
		// Token: 0x0400BEAE RID: 48814
		[OriginalName("ErrSunSpiritActionExecutorNotFind")]
		ErrSunSpiritActionExecutorNotFind,
		// Token: 0x0400BEAF RID: 48815
		[OriginalName("ErrSunSpiritActionInfoNotFind")]
		ErrSunSpiritActionInfoNotFind,
		// Token: 0x0400BEB0 RID: 48816
		[OriginalName("ErrSunSpiritActionIndexNotMatch")]
		ErrSunSpiritActionIndexNotMatch,
		// Token: 0x0400BEB1 RID: 48817
		[OriginalName("ErrSunSpiritActionTypeNotMatch")]
		ErrSunSpiritActionTypeNotMatch,
		// Token: 0x0400BEB2 RID: 48818
		[OriginalName("ErrSunSpiritActionParamOperationType")]
		ErrSunSpiritActionParamOperationType,
		// Token: 0x0400BEB3 RID: 48819
		[OriginalName("ErrSunSpiritAreaConfig")]
		ErrSunSpiritAreaConfig,
		// Token: 0x0400BEB4 RID: 48820
		[OriginalName("ErrSunSpiritNotHostPlayer")]
		ErrSunSpiritNotHostPlayer,
		// Token: 0x0400BEB5 RID: 48821
		[OriginalName("ErrResourcePackageSdkCheck")]
		ErrResourcePackageSdkCheck = 2900028,
		// Token: 0x0400BEB6 RID: 48822
		[OriginalName("ErrResourcePackageFuncClose")]
		ErrResourcePackageFuncClose,
		// Token: 0x0400BEB7 RID: 48823
		[OriginalName("ErrResourcePackageRedisWrite")]
		ErrResourcePackageRedisWrite,
		// Token: 0x0400BEB8 RID: 48824
		[OriginalName("ErrResourcePackageInvalidToken")]
		ErrResourcePackageInvalidToken,
		// Token: 0x0400BEB9 RID: 48825
		[OriginalName("ErrResourcePackageRateLimiterCircuit")]
		ErrResourcePackageRateLimiterCircuit,
		// Token: 0x0400BEBA RID: 48826
		[OriginalName("ErrResourcePackageRateLimiterRejected")]
		ErrResourcePackageRateLimiterRejected,
		// Token: 0x0400BEBB RID: 48827
		[OriginalName("ErrResourcePackageException")]
		ErrResourcePackageException,
		// Token: 0x0400BEBC RID: 48828
		[OriginalName("ErrResourcePackageTimeoutRejected")]
		ErrResourcePackageTimeoutRejected,
		// Token: 0x0400BEBD RID: 48829
		[OriginalName("ErrAvoidBlockGetInstComponent")]
		ErrAvoidBlockGetInstComponent,
		// Token: 0x0400BEBE RID: 48830
		[OriginalName("ErrLoadCalabashDefault")]
		ErrLoadCalabashDefault = 3000000,
		// Token: 0x0400BEBF RID: 48831
		[OriginalName("CalabashSkinUnLockErr")]
		CalabashSkinUnLockErr,
		// Token: 0x0400BEC0 RID: 48832
		[OriginalName("RepeqtedRequest")]
		RepeqtedRequest,
		// Token: 0x0400BEC1 RID: 48833
		[OriginalName("ErrSynthesisBatchItemNotSupport")]
		ErrSynthesisBatchItemNotSupport,
		// Token: 0x0400BEC2 RID: 48834
		[OriginalName("ErrSynthesisBatchItemDeadLoop")]
		ErrSynthesisBatchItemDeadLoop,
		// Token: 0x0400BEC3 RID: 48835
		[OriginalName("ErrSynthesisBatchItemCntNotMatch")]
		ErrSynthesisBatchItemCntNotMatch,
		// Token: 0x0400BEC4 RID: 48836
		[OriginalName("ErrSynthesisBatchItemReapeat")]
		ErrSynthesisBatchItemReapeat,
		// Token: 0x0400BEC5 RID: 48837
		[OriginalName("ErrBatchSynthesisCoinOverflow")]
		ErrBatchSynthesisCoinOverflow,
		// Token: 0x0400BEC6 RID: 48838
		[OriginalName("ErrPhantomSkinNotExist")]
		ErrPhantomSkinNotExist,
		// Token: 0x0400BEC7 RID: 48839
		[OriginalName("ErrPhantomSkinNotUnlock")]
		ErrPhantomSkinNotUnlock,
		// Token: 0x0400BEC8 RID: 48840
		[OriginalName("ErrPhantomInteractionNotUnlock")]
		ErrPhantomInteractionNotUnlock,
		// Token: 0x0400BEC9 RID: 48841
		[OriginalName("ErrIllustratedNotUnlock")]
		ErrIllustratedNotUnlock,
		// Token: 0x0400BECA RID: 48842
		[OriginalName("ErrPhantomInteractionEquipCountNotMatch")]
		ErrPhantomInteractionEquipCountNotMatch,
		// Token: 0x0400BECB RID: 48843
		[OriginalName("ErrPhantomInteractionConfigNotFind")]
		ErrPhantomInteractionConfigNotFind,
		// Token: 0x0400BECC RID: 48844
		[OriginalName("ErrPhantomSkinRepeatOperation")]
		ErrPhantomSkinRepeatOperation = 3000044,
		// Token: 0x0400BECD RID: 48845
		[OriginalName("ErrPhantomInteractionNotShowable")]
		ErrPhantomInteractionNotShowable,
		// Token: 0x0400BECE RID: 48846
		[OriginalName("ErrArtemisNodeNoConfig")]
		ErrArtemisNodeNoConfig = 3000014,
		// Token: 0x0400BECF RID: 48847
		[OriginalName("ErrArtemisActivityNotOpen")]
		ErrArtemisActivityNotOpen,
		// Token: 0x0400BED0 RID: 48848
		[OriginalName("ErrArtemisNodeNoData")]
		ErrArtemisNodeNoData,
		// Token: 0x0400BED1 RID: 48849
		[OriginalName("ErrArtemisNodeNoUnlock")]
		ErrArtemisNodeNoUnlock,
		// Token: 0x0400BED2 RID: 48850
		[OriginalName("ErrArtemisNodeNotRewardStatus")]
		ErrArtemisNodeNotRewardStatus,
		// Token: 0x0400BED3 RID: 48851
		[OriginalName("ErrArtemisNodeAlreadyFixed")]
		ErrArtemisNodeAlreadyFixed,
		// Token: 0x0400BED4 RID: 48852
		[OriginalName("ErrArtemisNodeAlreadyFinished")]
		ErrArtemisNodeAlreadyFinished,
		// Token: 0x0400BED5 RID: 48853
		[OriginalName("ErrArtemisState")]
		ErrArtemisState,
		// Token: 0x0400BED6 RID: 48854
		[OriginalName("ErrArtemisInvalidUpdate")]
		ErrArtemisInvalidUpdate,
		// Token: 0x0400BED7 RID: 48855
		[OriginalName("ErrIndexOutOfRange")]
		ErrIndexOutOfRange,
		// Token: 0x0400BED8 RID: 48856
		[OriginalName("ErrArtemisActivityNotExist")]
		ErrArtemisActivityNotExist,
		// Token: 0x0400BED9 RID: 48857
		[OriginalName("MotorParkourLevelNoOpen")]
		MotorParkourLevelNoOpen,
		// Token: 0x0400BEDA RID: 48858
		[OriginalName("MotorParkourNoConfig")]
		MotorParkourNoConfig,
		// Token: 0x0400BEDB RID: 48859
		[OriginalName("MotorParkourInstComponentNotExist")]
		MotorParkourInstComponentNotExist,
		// Token: 0x0400BEDC RID: 48860
		[OriginalName("MotorParkourGetTimeRecordFailed")]
		MotorParkourGetTimeRecordFailed,
		// Token: 0x0400BEDD RID: 48861
		[OriginalName("ErrMotorParkourLevelRewardIndexLengthError")]
		ErrMotorParkourLevelRewardIndexLengthError,
		// Token: 0x0400BEDE RID: 48862
		[OriginalName("ErrMotorParkourActivityDataNotExist")]
		ErrMotorParkourActivityDataNotExist,
		// Token: 0x0400BEDF RID: 48863
		[OriginalName("ErrMotorParkourLevelRewardIndexInvalid")]
		ErrMotorParkourLevelRewardIndexInvalid,
		// Token: 0x0400BEE0 RID: 48864
		[OriginalName("ErrMotorParkourRecordCfgNotExist")]
		ErrMotorParkourRecordCfgNotExist,
		// Token: 0x0400BEE1 RID: 48865
		[OriginalName("ErrMotorParkourGetRewardStatusFail")]
		ErrMotorParkourGetRewardStatusFail,
		// Token: 0x0400BEE2 RID: 48866
		[OriginalName("ErrMotorParkourRewardNotAvailable")]
		ErrMotorParkourRewardNotAvailable,
		// Token: 0x0400BEE3 RID: 48867
		[OriginalName("ErrMotorParkourLevelRewardIndexDuplicate")]
		ErrMotorParkourLevelRewardIndexDuplicate,
		// Token: 0x0400BEE4 RID: 48868
		[OriginalName("ErrMotorParkourRewardCfgNotExist")]
		ErrMotorParkourRewardCfgNotExist = 3000043,
		// Token: 0x0400BEE5 RID: 48869
		[OriginalName("ErrMotorParkourLevelInfoFailed")]
		ErrMotorParkourLevelInfoFailed = 3000046,
		// Token: 0x0400BEE6 RID: 48870
		[OriginalName("ErrMotorParkourPreLevelNotComplete")]
		ErrMotorParkourPreLevelNotComplete = 3000073,
		// Token: 0x0400BEE7 RID: 48871
		[OriginalName("ErrAreaTerminalPinFull")]
		ErrAreaTerminalPinFull = 3000036,
		// Token: 0x0400BEE8 RID: 48872
		[OriginalName("ErrAreaTerminalPinExist")]
		ErrAreaTerminalPinExist,
		// Token: 0x0400BEE9 RID: 48873
		[OriginalName("ErrAreaTerminalPinNotExist")]
		ErrAreaTerminalPinNotExist,
		// Token: 0x0400BEEA RID: 48874
		[OriginalName("ErrAreaTerminalParamError")]
		ErrAreaTerminalParamError,
		// Token: 0x0400BEEB RID: 48875
		[OriginalName("ErrActivityLock")]
		ErrActivityLock,
		// Token: 0x0400BEEC RID: 48876
		[OriginalName("ErrFuncLock")]
		ErrFuncLock,
		// Token: 0x0400BEED RID: 48877
		[OriginalName("ErrNoAreaTerminalCfg")]
		ErrNoAreaTerminalCfg,
		// Token: 0x0400BEEE RID: 48878
		[OriginalName("ErrSpringFestivalActivityConfigNotFound")]
		ErrSpringFestivalActivityConfigNotFound = 3000068,
		// Token: 0x0400BEEF RID: 48879
		[OriginalName("ErrSpringFestivalActivityDataNotFound")]
		ErrSpringFestivalActivityDataNotFound,
		// Token: 0x0400BEF0 RID: 48880
		[OriginalName("ErrSpringFestivalComponentNotFound")]
		ErrSpringFestivalComponentNotFound,
		// Token: 0x0400BEF1 RID: 48881
		[OriginalName("ErrSpringFestivalRuntimeInfoNotFound")]
		ErrSpringFestivalRuntimeInfoNotFound,
		// Token: 0x0400BEF2 RID: 48882
		[OriginalName("ErrMultiModeCanNotRequest")]
		ErrMultiModeCanNotRequest = 3000083,
		// Token: 0x0400BEF3 RID: 48883
		[OriginalName("ErrSpringFestivalActivityNotOpen")]
		ErrSpringFestivalActivityNotOpen,
		// Token: 0x0400BEF4 RID: 48884
		[OriginalName("ErrSpringFestivalFuncNotExist")]
		ErrSpringFestivalFuncNotExist = 3000100,
		// Token: 0x0400BEF5 RID: 48885
		[OriginalName("ErrSpringFestivalFuncLock")]
		ErrSpringFestivalFuncLock,
		// Token: 0x0400BEF6 RID: 48886
		[OriginalName("ErrSpringFestivalActivityIdNotMatch")]
		ErrSpringFestivalActivityIdNotMatch = 3000103,
		// Token: 0x0400BEF7 RID: 48887
		[OriginalName("ErrFurnitureDiyActivityConfigNotFound")]
		ErrFurnitureDiyActivityConfigNotFound = 3000047,
		// Token: 0x0400BEF8 RID: 48888
		[OriginalName("ErrFurnitureAreaIdNotExistInActivity")]
		ErrFurnitureAreaIdNotExistInActivity,
		// Token: 0x0400BEF9 RID: 48889
		[OriginalName("ErrFurnitureAreaConfigNotFound")]
		ErrFurnitureAreaConfigNotFound,
		// Token: 0x0400BEFA RID: 48890
		[OriginalName("ErrFurnitureDiyActivityDataNotFound")]
		ErrFurnitureDiyActivityDataNotFound,
		// Token: 0x0400BEFB RID: 48891
		[OriginalName("ErrFurnitureSlotConfigNotExist")]
		ErrFurnitureSlotConfigNotExist,
		// Token: 0x0400BEFC RID: 48892
		[OriginalName("ErrFurnitureConfigNotExist")]
		ErrFurnitureConfigNotExist,
		// Token: 0x0400BEFD RID: 48893
		[OriginalName("ErrFurnitureNotAvailable")]
		ErrFurnitureNotAvailable,
		// Token: 0x0400BEFE RID: 48894
		[OriginalName("ErrFurnitureAreaDataNotFound")]
		ErrFurnitureAreaDataNotFound,
		// Token: 0x0400BEFF RID: 48895
		[OriginalName("ErrSpecificFurnitureCount")]
		ErrSpecificFurnitureCount,
		// Token: 0x0400BF00 RID: 48896
		[OriginalName("ErrFurnitureSlotNotSupportChildTag")]
		ErrFurnitureSlotNotSupportChildTag,
		// Token: 0x0400BF01 RID: 48897
		[OriginalName("ErrFurnitureSlotNotSupportFurniture")]
		ErrFurnitureSlotNotSupportFurniture,
		// Token: 0x0400BF02 RID: 48898
		[OriginalName("ErrFurnitureDiyComponentNotFound")]
		ErrFurnitureDiyComponentNotFound,
		// Token: 0x0400BF03 RID: 48899
		[OriginalName("ErrNotFurnitureSlotConfig")]
		ErrNotFurnitureSlotConfig,
		// Token: 0x0400BF04 RID: 48900
		[OriginalName("ErrFurnitureSlotConfigSlotCountError")]
		ErrFurnitureSlotConfigSlotCountError,
		// Token: 0x0400BF05 RID: 48901
		[OriginalName("ErrFurnitureSlotSubFurnitureCount")]
		ErrFurnitureSlotSubFurnitureCount,
		// Token: 0x0400BF06 RID: 48902
		[OriginalName("ErrFurnitureEntityConfigNotFound")]
		ErrFurnitureEntityConfigNotFound,
		// Token: 0x0400BF07 RID: 48903
		[OriginalName("ErrEntityCreateFailed")]
		ErrEntityCreateFailed,
		// Token: 0x0400BF08 RID: 48904
		[OriginalName("ErrFurnitureUnloadSubFurnitureNotEmpty")]
		ErrFurnitureUnloadSubFurnitureNotEmpty,
		// Token: 0x0400BF09 RID: 48905
		[OriginalName("ErrEntitiesNull")]
		ErrEntitiesNull,
		// Token: 0x0400BF0A RID: 48906
		[OriginalName("ErrConvertShortIdToFurnitureIdFailed")]
		ErrConvertShortIdToFurnitureIdFailed,
		// Token: 0x0400BF0B RID: 48907
		[OriginalName("ErrFurnitureSlotDuplicateInRequest")]
		ErrFurnitureSlotDuplicateInRequest,
		// Token: 0x0400BF0C RID: 48908
		[OriginalName("ErrFurnitureSlotNotBelongToArea")]
		ErrFurnitureSlotNotBelongToArea = 3000106,
		// Token: 0x0400BF0D RID: 48909
		[OriginalName("ErrSpringFestivalFurnitureHadUnlock")]
		ErrSpringFestivalFurnitureHadUnlock = 3000117,
		// Token: 0x0400BF0E RID: 48910
		[OriginalName("ErrExploreDegreeTypeNotFound")]
		ErrExploreDegreeTypeNotFound = 3000072,
		// Token: 0x0400BF0F RID: 48911
		[OriginalName("ErrActivityBrochureCfgNotFound")]
		ErrActivityBrochureCfgNotFound = 3000074,
		// Token: 0x0400BF10 RID: 48912
		[OriginalName("ErrBrochureRewardRequestEmptyBookItems")]
		ErrBrochureRewardRequestEmptyBookItems,
		// Token: 0x0400BF11 RID: 48913
		[OriginalName("ErrBrochureCfgNotFound")]
		ErrBrochureCfgNotFound,
		// Token: 0x0400BF12 RID: 48914
		[OriginalName("ErrBrochureNotBelongToActivity")]
		ErrBrochureNotBelongToActivity,
		// Token: 0x0400BF13 RID: 48915
		[OriginalName("ErrBrochureNotUnlock")]
		ErrBrochureNotUnlock,
		// Token: 0x0400BF14 RID: 48916
		[OriginalName("ErrBrochureRewardRequestDuplicateBookItem")]
		ErrBrochureRewardRequestDuplicateBookItem,
		// Token: 0x0400BF15 RID: 48917
		[OriginalName("ErrBookItemCfgNotFound")]
		ErrBookItemCfgNotFound,
		// Token: 0x0400BF16 RID: 48918
		[OriginalName("ErrBookItemNotFinish")]
		ErrBookItemNotFinish,
		// Token: 0x0400BF17 RID: 48919
		[OriginalName("ErrBookItemAlreadyRewarded")]
		ErrBookItemAlreadyRewarded,
		// Token: 0x0400BF18 RID: 48920
		[OriginalName("ErrBrochureRewardTimeInvalid")]
		ErrBrochureRewardTimeInvalid = 3000091,
		// Token: 0x0400BF19 RID: 48921
		[OriginalName("ErrBookItemNotBelongToBrochure")]
		ErrBookItemNotBelongToBrochure = 3000104,
		// Token: 0x0400BF1A RID: 48922
		[OriginalName("ErrExhibitionComponentCfgNotExist")]
		ErrExhibitionComponentCfgNotExist = 3000085,
		// Token: 0x0400BF1B RID: 48923
		[OriginalName("ErrItemTypeNotMatchExhibitType")]
		ErrItemTypeNotMatchExhibitType,
		// Token: 0x0400BF1C RID: 48924
		[OriginalName("ErrExhibitConfigTypeInvalid")]
		ErrExhibitConfigTypeInvalid,
		// Token: 0x0400BF1D RID: 48925
		[OriginalName("ErrExhibitionComponentNotExist")]
		ErrExhibitionComponentNotExist,
		// Token: 0x0400BF1E RID: 48926
		[OriginalName("ErrExhibitionPhantomNotExist")]
		ErrExhibitionPhantomNotExist,
		// Token: 0x0400BF1F RID: 48927
		[OriginalName("ErrRepeatedEntity")]
		ErrRepeatedEntity = 3000092,
		// Token: 0x0400BF20 RID: 48928
		[OriginalName("ErrPhonographMusicNotExist")]
		ErrPhonographMusicNotExist,
		// Token: 0x0400BF21 RID: 48929
		[OriginalName("ErrMusicNotUnlocked")]
		ErrMusicNotUnlocked = 3000102,
		// Token: 0x0400BF22 RID: 48930
		[OriginalName("ErrInstanceConfigNotFound")]
		ErrInstanceConfigNotFound = 3000090,
		// Token: 0x0400BF23 RID: 48931
		[OriginalName("ErrInvalidEnterContextCase")]
		ErrInvalidEnterContextCase = 3000094,
		// Token: 0x0400BF24 RID: 48932
		[OriginalName("ErrTetrisLevelInfoDuplicate")]
		ErrTetrisLevelInfoDuplicate,
		// Token: 0x0400BF25 RID: 48933
		[OriginalName("ErrTetrisActivityDataNotFound")]
		ErrTetrisActivityDataNotFound,
		// Token: 0x0400BF26 RID: 48934
		[OriginalName("ErrTetrisLevelConfigNotExist")]
		ErrTetrisLevelConfigNotExist,
		// Token: 0x0400BF27 RID: 48935
		[OriginalName("ErrTetrisLevelRewardDuplicate")]
		ErrTetrisLevelRewardDuplicate,
		// Token: 0x0400BF28 RID: 48936
		[OriginalName("ErrTetrisLevelStateInvalid")]
		ErrTetrisLevelStateInvalid,
		// Token: 0x0400BF29 RID: 48937
		[OriginalName("ErrActivityNotMatchTetrisLevel")]
		ErrActivityNotMatchTetrisLevel = 3000118,
		// Token: 0x0400BF2A RID: 48938
		[OriginalName("ErrTetrisTargetScoreIdNotExist")]
		ErrTetrisTargetScoreIdNotExist,
		// Token: 0x0400BF2B RID: 48939
		[OriginalName("ErrTetrisLevelHasRewarded")]
		ErrTetrisLevelHasRewarded,
		// Token: 0x0400BF2C RID: 48940
		[OriginalName("ErrTetrisLevelNotFinished")]
		ErrTetrisLevelNotFinished,
		// Token: 0x0400BF2D RID: 48941
		[OriginalName("ErrTetrisLevelDifficultyIndexInvalid")]
		ErrTetrisLevelDifficultyIndexInvalid = 3000126,
		// Token: 0x0400BF2E RID: 48942
		[OriginalName("ErrTetrisTargetScoreCountNotMatch")]
		ErrTetrisTargetScoreCountNotMatch,
		// Token: 0x0400BF2F RID: 48943
		[OriginalName("ErrTetrisScoreInvalid")]
		ErrTetrisScoreInvalid,
		// Token: 0x0400BF30 RID: 48944
		[OriginalName("ErrGetVarDefine")]
		ErrGetVarDefine,
		// Token: 0x0400BF31 RID: 48945
		[OriginalName("ErrDataPersistenceTetrisBoardGame")]
		ErrDataPersistenceTetrisBoardGame,
		// Token: 0x0400BF32 RID: 48946
		[OriginalName("ErrTetrisTargetScoreNotEnough")]
		ErrTetrisTargetScoreNotEnough,
		// Token: 0x0400BF33 RID: 48947
		[OriginalName("ErrTetrisConfigInvalid")]
		ErrTetrisConfigInvalid,
		// Token: 0x0400BF34 RID: 48948
		[OriginalName("ErrTetrisPreLevelNotFinished")]
		ErrTetrisPreLevelNotFinished = 3000137,
		// Token: 0x0400BF35 RID: 48949
		[OriginalName("wlf_test")]
		WlfTest = 3000105,
		// Token: 0x0400BF36 RID: 48950
		[OriginalName("DropCatchNoConfig")]
		DropCatchNoConfig = 3000107,
		// Token: 0x0400BF37 RID: 48951
		[OriginalName("DropCatchLevelNotOpen")]
		DropCatchLevelNotOpen,
		// Token: 0x0400BF38 RID: 48952
		[OriginalName("ErrDropCatchLevelRewardIndexLengthError")]
		ErrDropCatchLevelRewardIndexLengthError,
		// Token: 0x0400BF39 RID: 48953
		[OriginalName("ErrDropCatchActivityDataNotExist")]
		ErrDropCatchActivityDataNotExist,
		// Token: 0x0400BF3A RID: 48954
		[OriginalName("ErrDropCatchLevelRewardIndexDuplicate")]
		ErrDropCatchLevelRewardIndexDuplicate,
		// Token: 0x0400BF3B RID: 48955
		[OriginalName("ErrDropCatchLevelRewardIndexInvalid")]
		ErrDropCatchLevelRewardIndexInvalid,
		// Token: 0x0400BF3C RID: 48956
		[OriginalName("ErrDropCatchRewardCfgNotExist")]
		ErrDropCatchRewardCfgNotExist,
		// Token: 0x0400BF3D RID: 48957
		[OriginalName("ErrDropCatchRewardNotAvailable")]
		ErrDropCatchRewardNotAvailable,
		// Token: 0x0400BF3E RID: 48958
		[OriginalName("ErrDropCatchLevelInfoFailed")]
		ErrDropCatchLevelInfoFailed,
		// Token: 0x0400BF3F RID: 48959
		[OriginalName("ErrDropCatchLevelScoreInvalid")]
		ErrDropCatchLevelScoreInvalid,
		// Token: 0x0400BF40 RID: 48960
		[OriginalName("ErrDropCatchEntityComponentNotExist")]
		ErrDropCatchEntityComponentNotExist = 3000122,
		// Token: 0x0400BF41 RID: 48961
		[OriginalName("ErrDropCatchComponentNotExist")]
		ErrDropCatchComponentNotExist,
		// Token: 0x0400BF42 RID: 48962
		[OriginalName("ErrDropCatchRewardCfgNotActivity")]
		ErrDropCatchRewardCfgNotActivity,
		// Token: 0x0400BF43 RID: 48963
		[OriginalName("ErrDropCatchDataNotExist")]
		ErrDropCatchDataNotExist,
		// Token: 0x0400BF44 RID: 48964
		[OriginalName("ErrGetSelfXboxOnlineId")]
		ErrGetSelfXboxOnlineId = 3000133,
		// Token: 0x0400BF45 RID: 48965
		[OriginalName("ErrXboxPlayerInfoRequestLimit")]
		ErrXboxPlayerInfoRequestLimit,
		// Token: 0x0400BF46 RID: 48966
		[OriginalName("ErrGetXboxUserPlayerErr")]
		ErrGetXboxUserPlayerErr,
		// Token: 0x0400BF47 RID: 48967
		[OriginalName("ErrXboxAccountBlocked")]
		ErrXboxAccountBlocked,
		// Token: 0x0400BF48 RID: 48968
		[OriginalName("InfrV2LevelCfgNotFound")]
		InfrV2LevelCfgNotFound = 3000138,
		// Token: 0x0400BF49 RID: 48969
		[OriginalName("InfrV2ShopPhaseCfgNotFound")]
		InfrV2ShopPhaseCfgNotFound,
		// Token: 0x0400BF4A RID: 48970
		[OriginalName("InfrV2ShopGoodsCfgNotFound")]
		InfrV2ShopGoodsCfgNotFound,
		// Token: 0x0400BF4B RID: 48971
		[OriginalName("InfrV2FireAddExpNegative")]
		InfrV2FireAddExpNegative,
		// Token: 0x0400BF4C RID: 48972
		[OriginalName("InfrV2FireAlreadyMaxLevel")]
		InfrV2FireAlreadyMaxLevel,
		// Token: 0x0400BF4D RID: 48973
		[OriginalName("InfrV2FireConditionNotMet")]
		InfrV2FireConditionNotMet,
		// Token: 0x0400BF4E RID: 48974
		[OriginalName("InfrV2FireExpNotEnough")]
		InfrV2FireExpNotEnough,
		// Token: 0x0400BF4F RID: 48975
		[OriginalName("InfrV2TreeNotInProgress")]
		InfrV2TreeNotInProgress,
		// Token: 0x0400BF50 RID: 48976
		[OriginalName("InfrV2FireLevelNotInProgress")]
		InfrV2FireLevelNotInProgress,
		// Token: 0x0400BF51 RID: 48977
		[OriginalName("InfrV2TreeConditionNotMet")]
		InfrV2TreeConditionNotMet,
		// Token: 0x0400BF52 RID: 48978
		[OriginalName("InfrV2NotOpen")]
		InfrV2NotOpen,
		// Token: 0x0400BF53 RID: 48979
		[OriginalName("InfrV2TreeBuildCfgNotFound")]
		InfrV2TreeBuildCfgNotFound,
		// Token: 0x0400BF54 RID: 48980
		[OriginalName("InfrV2TreeCannotTrace")]
		InfrV2TreeCannotTrace,
		// Token: 0x0400BF55 RID: 48981
		[OriginalName("InfrV2TreeSwitchTraceInMulti")]
		InfrV2TreeSwitchTraceInMulti,
		// Token: 0x0400BF56 RID: 48982
		[OriginalName("InfrV2TaskFindErr")]
		InfrV2TaskFindErr,
		// Token: 0x0400BF57 RID: 48983
		[OriginalName("InfrV2HadReward")]
		InfrV2HadReward,
		// Token: 0x0400BF58 RID: 48984
		[OriginalName("InfrV2TaskRunning")]
		InfrV2TaskRunning,
		// Token: 0x0400BF59 RID: 48985
		[OriginalName("InfrV2DropNoFind")]
		InfrV2DropNoFind,
		// Token: 0x0400BF5A RID: 48986
		[OriginalName("InfrV2ParamAgainErr")]
		InfrV2ParamAgainErr,
		// Token: 0x0400BF5B RID: 48987
		[OriginalName("InfrV2NoReward")]
		InfrV2NoReward,
		// Token: 0x0400BF5C RID: 48988
		[OriginalName("InfrV2ParamCountErr")]
		InfrV2ParamCountErr,
		// Token: 0x0400BF5D RID: 48989
		[OriginalName("SlashAndTowerParamErr")]
		SlashAndTowerParamErr,
		// Token: 0x0400BF5E RID: 48990
		[OriginalName("RogueWeeklyParamErr")]
		RogueWeeklyParamErr,
		// Token: 0x0400BF5F RID: 48991
		[OriginalName("ErrMatchRoleChangeSkillBranchCountNotEqualRoleCount")]
		ErrMatchRoleChangeSkillBranchCountNotEqualRoleCount,
		// Token: 0x0400BF60 RID: 48992
		[OriginalName("ErrActivityPreQuestNotFinished")]
		ErrActivityPreQuestNotFinished,
		// Token: 0x0400BF61 RID: 48993
		[OriginalName("ErrInstNotEdgeRunnerLordGym")]
		ErrInstNotEdgeRunnerLordGym,
		// Token: 0x0400BF62 RID: 48994
		[OriginalName("ErrEdgeRunnerLordGymConfigNotExist")]
		ErrEdgeRunnerLordGymConfigNotExist,
		// Token: 0x0400BF63 RID: 48995
		[OriginalName("ErrEdgeRunnerDbDataNotExist")]
		ErrEdgeRunnerDbDataNotExist,
		// Token: 0x0400BF64 RID: 48996
		[OriginalName("ErrEdgeRunnerPreLordGymNotPassed")]
		ErrEdgeRunnerPreLordGymNotPassed,
		// Token: 0x0400BF65 RID: 48997
		[OriginalName("EdgeRunnerParamCountErr")]
		EdgeRunnerParamCountErr,
		// Token: 0x0400BF66 RID: 48998
		[OriginalName("EdgeRunnerDropNoFind")]
		EdgeRunnerDropNoFind,
		// Token: 0x0400BF67 RID: 48999
		[OriginalName("EdgeRunnerNoReward")]
		EdgeRunnerNoReward,
		// Token: 0x0400BF68 RID: 49000
		[OriginalName("EdgeRunnerTaskFindErr")]
		EdgeRunnerTaskFindErr,
		// Token: 0x0400BF69 RID: 49001
		[OriginalName("EdgeRunnerActivityIdErr")]
		EdgeRunnerActivityIdErr,
		// Token: 0x0400BF6A RID: 49002
		[OriginalName("EdgeRunnerHadReward")]
		EdgeRunnerHadReward,
		// Token: 0x0400BF6B RID: 49003
		[OriginalName("EdgeRunnerTaskRunning")]
		EdgeRunnerTaskRunning,
		// Token: 0x0400BF6C RID: 49004
		[OriginalName("EdgeRunnerParamAgainErr")]
		EdgeRunnerParamAgainErr,
		// Token: 0x0400BF6D RID: 49005
		[OriginalName("ErrEdgeRunnerActivityConfigNotFound")]
		ErrEdgeRunnerActivityConfigNotFound,
		// Token: 0x0400BF6E RID: 49006
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockConfigNotFound")]
		ErrEdgeRunnerActivityFuncUnlockConfigNotFound,
		// Token: 0x0400BF6F RID: 49007
		[OriginalName("ErrEdgeRunnerActivityFuncAlreadyUnlock")]
		ErrEdgeRunnerActivityFuncAlreadyUnlock,
		// Token: 0x0400BF70 RID: 49008
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockConditionNotReached")]
		ErrEdgeRunnerActivityFuncUnlockConditionNotReached,
		// Token: 0x0400BF71 RID: 49009
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockFailed")]
		ErrEdgeRunnerActivityFuncUnlockFailed,
		// Token: 0x0400BF72 RID: 49010
		[OriginalName("ErrEdgeRunnerLordGymLevelVarNotExist")]
		ErrEdgeRunnerLordGymLevelVarNotExist = 3000187,
		// Token: 0x0400BF73 RID: 49011
		[OriginalName("EdgeRunnerLordGymRepeatChallenge")]
		EdgeRunnerLordGymRepeatChallenge,
		// Token: 0x0400BF74 RID: 49012
		[OriginalName("ErrEdgeRunnerLordGymBtTreeNotFound")]
		ErrEdgeRunnerLordGymBtTreeNotFound,
		// Token: 0x0400BF75 RID: 49013
		[OriginalName("ErrEdgeRunnerLordGymNotInPlay")]
		ErrEdgeRunnerLordGymNotInPlay,
		// Token: 0x0400BF76 RID: 49014
		[OriginalName("ErrGolemCrackLevelConfigNotExist")]
		ErrGolemCrackLevelConfigNotExist = 3000180,
		// Token: 0x0400BF77 RID: 49015
		[OriginalName("ErrActivityNotMatchGolemCrackLevel")]
		ErrActivityNotMatchGolemCrackLevel,
		// Token: 0x0400BF78 RID: 49016
		[OriginalName("ErrGolemCrackActivityDataNotFound")]
		ErrGolemCrackActivityDataNotFound,
		// Token: 0x0400BF79 RID: 49017
		[OriginalName("ErrGolemCrackPreLevelNotFinished")]
		ErrGolemCrackPreLevelNotFinished,
		// Token: 0x0400BF7A RID: 49018
		[OriginalName("ErrGolemCrackLevelRewardDuplicate")]
		ErrGolemCrackLevelRewardDuplicate,
		// Token: 0x0400BF7B RID: 49019
		[OriginalName("ErrGolemCrackPreLevelLocked")]
		ErrGolemCrackPreLevelLocked = 3000186,
		// Token: 0x0400BF7C RID: 49020
		[OriginalName("ErrPhantomRecommendConfigNotFound")]
		ErrPhantomRecommendConfigNotFound = 3000185,
		// Token: 0x0400BF7D RID: 49021
		[OriginalName("ErrXboxGiftNotEnable")]
		ErrXboxGiftNotEnable = 3000191,
		// Token: 0x0400BF7E RID: 49022
		[OriginalName("ErrXboxGiftDbError")]
		ErrXboxGiftDbError,
		// Token: 0x0400BF7F RID: 49023
		[OriginalName("ErrXboxGiftAlreadyClaimed")]
		ErrXboxGiftAlreadyClaimed,
		// Token: 0x0400BF80 RID: 49024
		[OriginalName("ErrXboxGiftNotXboxUser")]
		ErrXboxGiftNotXboxUser,
		// Token: 0x0400BF81 RID: 49025
		[OriginalName("ErrXboxGiftRequestErr")]
		ErrXboxGiftRequestErr,
		// Token: 0x0400BF82 RID: 49026
		[OriginalName("ErrXboxGiftRequestDataErr")]
		ErrXboxGiftRequestDataErr,
		// Token: 0x0400BF83 RID: 49027
		[OriginalName("ErrXboxGiftNotFound")]
		ErrXboxGiftNotFound,
		// Token: 0x0400BF84 RID: 49028
		[OriginalName("ErrXboxGiftException")]
		ErrXboxGiftException,
		// Token: 0x0400BF85 RID: 49029
		[OriginalName("ErrXboxGiftHttpError")]
		ErrXboxGiftHttpError,
		// Token: 0x0400BF86 RID: 49030
		[OriginalName("ErrXboxGiftXstsTokenInvalid")]
		ErrXboxGiftXstsTokenInvalid = 3000201,
		// Token: 0x0400BF87 RID: 49031
		[OriginalName("ErrXboxGiftXstsTokenMismatch")]
		ErrXboxGiftXstsTokenMismatch,
		// Token: 0x0400BF88 RID: 49032
		[OriginalName("DangoBrawlActivityNotExist")]
		DangoBrawlActivityNotExist = 3000200,
		// Token: 0x0400BF89 RID: 49033
		[OriginalName("DangoBrawlParamCountErr")]
		DangoBrawlParamCountErr = 3000218,
		// Token: 0x0400BF8A RID: 49034
		[OriginalName("DangoBrawlTaskFindErr")]
		DangoBrawlTaskFindErr,
		// Token: 0x0400BF8B RID: 49035
		[OriginalName("DangoBrawlActivityIdErr")]
		DangoBrawlActivityIdErr,
		// Token: 0x0400BF8C RID: 49036
		[OriginalName("DangoBrawlHadReward")]
		DangoBrawlHadReward,
		// Token: 0x0400BF8D RID: 49037
		[OriginalName("DangoBrawlTaskRunning")]
		DangoBrawlTaskRunning,
		// Token: 0x0400BF8E RID: 49038
		[OriginalName("DangoBrawlDropNoFind")]
		DangoBrawlDropNoFind,
		// Token: 0x0400BF8F RID: 49039
		[OriginalName("DangoBrawlParamAgainErr")]
		DangoBrawlParamAgainErr,
		// Token: 0x0400BF90 RID: 49040
		[OriginalName("DangoBrawlNoReward")]
		DangoBrawlNoReward,
		// Token: 0x0400BF91 RID: 49041
		[OriginalName("DangoBrawlPreChallengeNotPass")]
		DangoBrawlPreChallengeNotPass,
		// Token: 0x0400BF92 RID: 49042
		[OriginalName("DangoBrawlWinError")]
		DangoBrawlWinError,
		// Token: 0x0400BF93 RID: 49043
		[OriginalName("QingXiaoParamCountErr")]
		QingXiaoParamCountErr = 3000203,
		// Token: 0x0400BF94 RID: 49044
		[OriginalName("QingXiaoTaskFindErr")]
		QingXiaoTaskFindErr,
		// Token: 0x0400BF95 RID: 49045
		[OriginalName("QingXiaoActivityIdErr")]
		QingXiaoActivityIdErr,
		// Token: 0x0400BF96 RID: 49046
		[OriginalName("QingXiaoHadReward")]
		QingXiaoHadReward,
		// Token: 0x0400BF97 RID: 49047
		[OriginalName("QingXiaoTaskRunning")]
		QingXiaoTaskRunning,
		// Token: 0x0400BF98 RID: 49048
		[OriginalName("QingXiaoDropNoFind")]
		QingXiaoDropNoFind,
		// Token: 0x0400BF99 RID: 49049
		[OriginalName("QingXiaoParamAgainErr")]
		QingXiaoParamAgainErr,
		// Token: 0x0400BF9A RID: 49050
		[OriginalName("QingXiaoNoReward")]
		QingXiaoNoReward,
		// Token: 0x0400BF9B RID: 49051
		[OriginalName("ErrVersionSignInNotOpen")]
		ErrVersionSignInNotOpen,
		// Token: 0x0400BF9C RID: 49052
		[OriginalName("ErrVersionSignInNoData")]
		ErrVersionSignInNoData,
		// Token: 0x0400BF9D RID: 49053
		[OriginalName("ErrVersionSignInRewardNotExist")]
		ErrVersionSignInRewardNotExist,
		// Token: 0x0400BF9E RID: 49054
		[OriginalName("ErrVersionSignInRewardAlreadyTaken")]
		ErrVersionSignInRewardAlreadyTaken,
		// Token: 0x0400BF9F RID: 49055
		[OriginalName("ErrVersionSignInDaysNotEnough")]
		ErrVersionSignInDaysNotEnough,
		// Token: 0x0400BFA0 RID: 49056
		[OriginalName("ErrVersionSignInParamError")]
		ErrVersionSignInParamError,
		// Token: 0x0400BFA1 RID: 49057
		[OriginalName("ErrTimePointRewardActivityConditionNotFinish")]
		ErrTimePointRewardActivityConditionNotFinish,
		// Token: 0x0400BFA2 RID: 49058
		[OriginalName("MaterialReplaceTargetMismatch")]
		MaterialReplaceTargetMismatch = 3000228,
		// Token: 0x0400BFA3 RID: 49059
		[OriginalName("MaterialReplaceNoExchangeParamConfig")]
		MaterialReplaceNoExchangeParamConfig,
		// Token: 0x0400BFA4 RID: 49060
		[OriginalName("ErrMotorParkourNotFound")]
		ErrMotorParkourNotFound,
		// Token: 0x0400BFA5 RID: 49061
		[OriginalName("ErrTetrisLevelDropIdNotExist")]
		ErrTetrisLevelDropIdNotExist,
		// Token: 0x0400BFA6 RID: 49062
		[OriginalName("PhotoFightLevelNotFound")]
		PhotoFightLevelNotFound = 3100000,
		// Token: 0x0400BFA7 RID: 49063
		[OriginalName("PhotoFightActivityNotOpen")]
		PhotoFightActivityNotOpen,
		// Token: 0x0400BFA8 RID: 49064
		[OriginalName("PhotoFightSceneComponentInfoLost")]
		PhotoFightSceneComponentInfoLost,
		// Token: 0x0400BFA9 RID: 49065
		[OriginalName("PhotoFightGroupNotFound")]
		PhotoFightGroupNotFound,
		// Token: 0x0400BFAA RID: 49066
		[OriginalName("PhotoFightLevelNotOpen")]
		PhotoFightLevelNotOpen,
		// Token: 0x0400BFAB RID: 49067
		[OriginalName("PhotoFightPreInstNotCleared")]
		PhotoFightPreInstNotCleared,
		// Token: 0x0400BFAC RID: 49068
		[OriginalName("PhotoFightSceneComponentLost")]
		PhotoFightSceneComponentLost,
		// Token: 0x0400BFAD RID: 49069
		[OriginalName("PhotoFightTargetStatusHigher")]
		PhotoFightTargetStatusHigher,
		// Token: 0x0400BFAE RID: 49070
		[OriginalName("PhotoFightNoTargetRole")]
		PhotoFightNoTargetRole,
		// Token: 0x0400BFAF RID: 49071
		[OriginalName("PhotoFightRoleInvalid")]
		PhotoFightRoleInvalid,
		// Token: 0x0400BFB0 RID: 49072
		[OriginalName("PhotoFightRewardCfgNotFound")]
		PhotoFightRewardCfgNotFound,
		// Token: 0x0400BFB1 RID: 49073
		[OriginalName("PhotoFightRewardInvalidInput")]
		PhotoFightRewardInvalidInput,
		// Token: 0x0400BFB2 RID: 49074
		[OriginalName("PhotoFightAlreadyRewarded")]
		PhotoFightAlreadyRewarded,
		// Token: 0x0400BFB3 RID: 49075
		[OriginalName("PhotoFightCannotRewarded")]
		PhotoFightCannotRewarded = 3100081,
		// Token: 0x0400BFB4 RID: 49076
		[OriginalName("PhotoFightInvalidInstType")]
		PhotoFightInvalidInstType = 3100306,
		// Token: 0x0400BFB5 RID: 49077
		[OriginalName("WuWuKujiQuestNotFound")]
		WuWuKujiQuestNotFound = 3100013,
		// Token: 0x0400BFB6 RID: 49078
		[OriginalName("WuWuKujiQuestNotOpenDay")]
		WuWuKujiQuestNotOpenDay,
		// Token: 0x0400BFB7 RID: 49079
		[OriginalName("WuWuKujiQuestAllFinished")]
		WuWuKujiQuestAllFinished,
		// Token: 0x0400BFB8 RID: 49080
		[OriginalName("WuWuKujiActivityNotOpen")]
		WuWuKujiActivityNotOpen,
		// Token: 0x0400BFB9 RID: 49081
		[OriginalName("WuWuKujiPreGuideNotFinished")]
		WuWuKujiPreGuideNotFinished,
		// Token: 0x0400BFBA RID: 49082
		[OriginalName("WuWuKujiPreQuestNotFinished")]
		WuWuKujiPreQuestNotFinished,
		// Token: 0x0400BFBB RID: 49083
		[OriginalName("WuWuKujiActivityConfigNotFound")]
		WuWuKujiActivityConfigNotFound,
		// Token: 0x0400BFBC RID: 49084
		[OriginalName("WuWuKujiTrickTypeInvalid")]
		WuWuKujiTrickTypeInvalid,
		// Token: 0x0400BFBD RID: 49085
		[OriginalName("WuWuKujiNoAvailableTrick")]
		WuWuKujiNoAvailableTrick,
		// Token: 0x0400BFBE RID: 49086
		[OriginalName("WuWuKujiAwardGroupCfgNotFound")]
		WuWuKujiAwardGroupCfgNotFound,
		// Token: 0x0400BFBF RID: 49087
		[OriginalName("WuWuKujiNoAvailableGroup")]
		WuWuKujiNoAvailableGroup,
		// Token: 0x0400BFC0 RID: 49088
		[OriginalName("WuWuKujiGroupRewardTimesExceededMax")]
		WuWuKujiGroupRewardTimesExceededMax,
		// Token: 0x0400BFC1 RID: 49089
		[OriginalName("WuWuKujiGroupRemainTimesError")]
		WuWuKujiGroupRemainTimesError,
		// Token: 0x0400BFC2 RID: 49090
		[OriginalName("WeatherCtlInvalidInMulti")]
		WeatherCtlInvalidInMulti,
		// Token: 0x0400BFC3 RID: 49091
		[OriginalName("WeatherCtlMapDataNotFound")]
		WeatherCtlMapDataNotFound,
		// Token: 0x0400BFC4 RID: 49092
		[OriginalName("WeatherCtlSwitchCfgNotFound")]
		WeatherCtlSwitchCfgNotFound,
		// Token: 0x0400BFC5 RID: 49093
		[OriginalName("WeatherCtlSwitchLocked")]
		WeatherCtlSwitchLocked,
		// Token: 0x0400BFC6 RID: 49094
		[OriginalName("WeatherCtlAreaWeatherLocked")]
		WeatherCtlAreaWeatherLocked,
		// Token: 0x0400BFC7 RID: 49095
		[OriginalName("WeatherCtlAreaDateLocked")]
		WeatherCtlAreaDateLocked,
		// Token: 0x0400BFC8 RID: 49096
		[OriginalName("WeatherCtlAddHourNoNegative")]
		WeatherCtlAddHourNoNegative,
		// Token: 0x0400BFC9 RID: 49097
		[OriginalName("WeatherCtlInMulti")]
		WeatherCtlInMulti = 3100052,
		// Token: 0x0400BFCA RID: 49098
		[OriginalName("WeatherCtlInBattle")]
		WeatherCtlInBattle,
		// Token: 0x0400BFCB RID: 49099
		[OriginalName("WeatherCtlInQuest")]
		WeatherCtlInQuest,
		// Token: 0x0400BFCC RID: 49100
		[OriginalName("WeatherCtlNotInBigWorld")]
		WeatherCtlNotInBigWorld = 3100082,
		// Token: 0x0400BFCD RID: 49101
		[OriginalName("WeatherCtlNotOpen")]
		WeatherCtlNotOpen = 3100162,
		// Token: 0x0400BFCE RID: 49102
		[OriginalName("InfrArchiveTaskCfgNotFound")]
		InfrArchiveTaskCfgNotFound = 3100033,
		// Token: 0x0400BFCF RID: 49103
		[OriginalName("InfrLevelCfgNotFound")]
		InfrLevelCfgNotFound,
		// Token: 0x0400BFD0 RID: 49104
		[OriginalName("InfrShopPhaseCfgNotFound")]
		InfrShopPhaseCfgNotFound,
		// Token: 0x0400BFD1 RID: 49105
		[OriginalName("InfrShopGoodsCfgNotFound")]
		InfrShopGoodsCfgNotFound,
		// Token: 0x0400BFD2 RID: 49106
		[OriginalName("InfrFireAddExpNegative")]
		InfrFireAddExpNegative,
		// Token: 0x0400BFD3 RID: 49107
		[OriginalName("InfrFireAlreadyMaxLevel")]
		InfrFireAlreadyMaxLevel,
		// Token: 0x0400BFD4 RID: 49108
		[OriginalName("InfrFireConditionNotMet")]
		InfrFireConditionNotMet,
		// Token: 0x0400BFD5 RID: 49109
		[OriginalName("InfrRoadBuildCfgNotFound")]
		InfrRoadBuildCfgNotFound,
		// Token: 0x0400BFD6 RID: 49110
		[OriginalName("InfrRoadCannotTrace")]
		InfrRoadCannotTrace,
		// Token: 0x0400BFD7 RID: 49111
		[OriginalName("InfrFireShopGoodsNotFound")]
		InfrFireShopGoodsNotFound,
		// Token: 0x0400BFD8 RID: 49112
		[OriginalName("InfrFireShopPhaseNotUnlocked")]
		InfrFireShopPhaseNotUnlocked,
		// Token: 0x0400BFD9 RID: 49113
		[OriginalName("InfrFireShopBuyLimitExceeded")]
		InfrFireShopBuyLimitExceeded,
		// Token: 0x0400BFDA RID: 49114
		[OriginalName("InfrFireShopBuyTimesInvalid")]
		InfrFireShopBuyTimesInvalid,
		// Token: 0x0400BFDB RID: 49115
		[OriginalName("InfrArchiveTaskInvalidInput")]
		InfrArchiveTaskInvalidInput,
		// Token: 0x0400BFDC RID: 49116
		[OriginalName("InfrArchiveTaskCannotRewarded")]
		InfrArchiveTaskCannotRewarded,
		// Token: 0x0400BFDD RID: 49117
		[OriginalName("InfrFireExpNotEnough")]
		InfrFireExpNotEnough,
		// Token: 0x0400BFDE RID: 49118
		[OriginalName("InfrRoadNotInProgress")]
		InfrRoadNotInProgress,
		// Token: 0x0400BFDF RID: 49119
		[OriginalName("InfrFireLevelNotInProgress")]
		InfrFireLevelNotInProgress,
		// Token: 0x0400BFE0 RID: 49120
		[OriginalName("InfrRoadConditionNotMet")]
		InfrRoadConditionNotMet,
		// Token: 0x0400BFE1 RID: 49121
		[OriginalName("InfrNotOpen")]
		InfrNotOpen = 3100073,
		// Token: 0x0400BFE2 RID: 49122
		[OriginalName("InfrPhoneTaskInvalidInput")]
		InfrPhoneTaskInvalidInput = 3100083,
		// Token: 0x0400BFE3 RID: 49123
		[OriginalName("InfrPhoneTaskCannotRewarded")]
		InfrPhoneTaskCannotRewarded,
		// Token: 0x0400BFE4 RID: 49124
		[OriginalName("InfrPhoneTaskCfgNotFound")]
		InfrPhoneTaskCfgNotFound,
		// Token: 0x0400BFE5 RID: 49125
		[OriginalName("InfrRoadSwitchTraceInMulti")]
		InfrRoadSwitchTraceInMulti = 3100173,
		// Token: 0x0400BFE6 RID: 49126
		[OriginalName("InfrThemeActivityTaskNotFound")]
		InfrThemeActivityTaskNotFound = 3100074,
		// Token: 0x0400BFE7 RID: 49127
		[OriginalName("InfrThemeActivityTaskRewarded")]
		InfrThemeActivityTaskRewarded,
		// Token: 0x0400BFE8 RID: 49128
		[OriginalName("InfrThemeActivityTaskNotComplete")]
		InfrThemeActivityTaskNotComplete,
		// Token: 0x0400BFE9 RID: 49129
		[OriginalName("InfrThemeActivityInputInvalid")]
		InfrThemeActivityInputInvalid,
		// Token: 0x0400BFEA RID: 49130
		[OriginalName("InfrThemeActivityIdMisMatch")]
		InfrThemeActivityIdMisMatch = 3100094,
		// Token: 0x0400BFEB RID: 49131
		[OriginalName("InfrThemeActivityTaskCannotRewarded")]
		InfrThemeActivityTaskCannotRewarded = 3100078,
		// Token: 0x0400BFEC RID: 49132
		[OriginalName("MotorTechPreNodeLock")]
		MotorTechPreNodeLock = 3100055,
		// Token: 0x0400BFED RID: 49133
		[OriginalName("MotorTechPreNotUpgraded")]
		MotorTechPreNotUpgraded,
		// Token: 0x0400BFEE RID: 49134
		[OriginalName("MotorTechLevelLower")]
		MotorTechLevelLower,
		// Token: 0x0400BFEF RID: 49135
		[OriginalName("MotorTechNotUnlocked")]
		MotorTechNotUnlocked,
		// Token: 0x0400BFF0 RID: 49136
		[OriginalName("MotorTechLevelMax")]
		MotorTechLevelMax,
		// Token: 0x0400BFF1 RID: 49137
		[OriginalName("MotorTechCfgNotFound")]
		MotorTechCfgNotFound,
		// Token: 0x0400BFF2 RID: 49138
		[OriginalName("MotorLvlConfigNotFound")]
		MotorLvlConfigNotFound,
		// Token: 0x0400BFF3 RID: 49139
		[OriginalName("MotorFuncNotOpen")]
		MotorFuncNotOpen,
		// Token: 0x0400BFF4 RID: 49140
		[OriginalName("MotorTaskCannotRewarded")]
		MotorTaskCannotRewarded,
		// Token: 0x0400BFF5 RID: 49141
		[OriginalName("MotorTaskInvalidParam")]
		MotorTaskInvalidParam,
		// Token: 0x0400BFF6 RID: 49142
		[OriginalName("MotorTaskCfgNotFound")]
		MotorTaskCfgNotFound,
		// Token: 0x0400BFF7 RID: 49143
		[OriginalName("MotorTechTreeCfgNotFound")]
		MotorTechTreeCfgNotFound,
		// Token: 0x0400BFF8 RID: 49144
		[OriginalName("MotorTechTreeLocked")]
		MotorTechTreeLocked,
		// Token: 0x0400BFF9 RID: 49145
		[OriginalName("MotorPlayerUsingSkill")]
		MotorPlayerUsingSkill,
		// Token: 0x0400BFFA RID: 49146
		[OriginalName("MotorPlayerClimbing")]
		MotorPlayerClimbing,
		// Token: 0x0400BFFB RID: 49147
		[OriginalName("MotorPlayerInWater")]
		MotorPlayerInWater,
		// Token: 0x0400BFFC RID: 49148
		[OriginalName("MotorPlayerInAir")]
		MotorPlayerInAir,
		// Token: 0x0400BFFD RID: 49149
		[OriginalName("MotorPlayerOnMotor")]
		MotorPlayerOnMotor,
		// Token: 0x0400BFFE RID: 49150
		[OriginalName("MotorTaskNotInOneTree")]
		MotorTaskNotInOneTree = 3100079,
		// Token: 0x0400BFFF RID: 49151
		[OriginalName("MotorExpInvalid")]
		MotorExpInvalid,
		// Token: 0x0400C000 RID: 49152
		[OriginalName("MotorOutlookLocked")]
		MotorOutlookLocked = 3100086,
		// Token: 0x0400C001 RID: 49153
		[OriginalName("MotorFrameCfgNotFound")]
		MotorFrameCfgNotFound,
		// Token: 0x0400C002 RID: 49154
		[OriginalName("MotorStickerCfgNotFound")]
		MotorStickerCfgNotFound,
		// Token: 0x0400C003 RID: 49155
		[OriginalName("MotorOutlookBanInRegion")]
		MotorOutlookBanInRegion,
		// Token: 0x0400C004 RID: 49156
		[OriginalName("MotorOutlookConflict")]
		MotorOutlookConflict,
		// Token: 0x0400C005 RID: 49157
		[OriginalName("MotorStickerPartCountError")]
		MotorStickerPartCountError,
		// Token: 0x0400C006 RID: 49158
		[OriginalName("MotorStickerPartIdError")]
		MotorStickerPartIdError,
		// Token: 0x0400C007 RID: 49159
		[OriginalName("MotorOutlookNotOwned")]
		MotorOutlookNotOwned,
		// Token: 0x0400C008 RID: 49160
		[OriginalName("MotorOutlookNotShow")]
		MotorOutlookNotShow = 3100320,
		// Token: 0x0400C009 RID: 49161
		[OriginalName("MotorLevelRewardAllClaimed")]
		MotorLevelRewardAllClaimed = 3100159,
		// Token: 0x0400C00A RID: 49162
		[OriginalName("PlayerNotInMotorArea")]
		PlayerNotInMotorArea,
		// Token: 0x0400C00B RID: 49163
		[OriginalName("MotorDecorationsCfgNotFound")]
		MotorDecorationsCfgNotFound = 3100164,
		// Token: 0x0400C00C RID: 49164
		[OriginalName("MotorDecorationsPartCountError")]
		MotorDecorationsPartCountError,
		// Token: 0x0400C00D RID: 49165
		[OriginalName("MotorDecorationsPartIdError")]
		MotorDecorationsPartIdError,
		// Token: 0x0400C00E RID: 49166
		[OriginalName("MotorTechTreeInCd")]
		MotorTechTreeInCd = 3100175,
		// Token: 0x0400C00F RID: 49167
		[OriginalName("ArrowSwordLevelCfgNotFound")]
		ArrowSwordLevelCfgNotFound = 3100095,
		// Token: 0x0400C010 RID: 49168
		[OriginalName("ArrowSwordTalentCfgNotFound")]
		ArrowSwordTalentCfgNotFound,
		// Token: 0x0400C011 RID: 49169
		[OriginalName("ArrowSwordTaskCfgNotFound")]
		ArrowSwordTaskCfgNotFound,
		// Token: 0x0400C012 RID: 49170
		[OriginalName("ArrowSwordItemCfgNotFound")]
		ArrowSwordItemCfgNotFound,
		// Token: 0x0400C013 RID: 49171
		[OriginalName("ArrowSwordRoleCfgNotFound")]
		ArrowSwordRoleCfgNotFound,
		// Token: 0x0400C014 RID: 49172
		[OriginalName("ArrowSwordPreNotCleared")]
		ArrowSwordPreNotCleared,
		// Token: 0x0400C015 RID: 49173
		[OriginalName("ArrowSwordActivityTypeNotMatch")]
		ArrowSwordActivityTypeNotMatch,
		// Token: 0x0400C016 RID: 49174
		[OriginalName("ArrowSwordTaskStatusHigher")]
		ArrowSwordTaskStatusHigher,
		// Token: 0x0400C017 RID: 49175
		[OriginalName("ArrowSwordInvalidInput")]
		ArrowSwordInvalidInput,
		// Token: 0x0400C018 RID: 49176
		[OriginalName("ArrowSwordDataOwnerErr")]
		ArrowSwordDataOwnerErr,
		// Token: 0x0400C019 RID: 49177
		[OriginalName("ArrowSwordActivityIdMisMatch")]
		ArrowSwordActivityIdMisMatch,
		// Token: 0x0400C01A RID: 49178
		[OriginalName("ArrowSwordTalentLocked")]
		ArrowSwordTalentLocked,
		// Token: 0x0400C01B RID: 49179
		[OriginalName("ArrowSwordTalentAlreadyInUse")]
		ArrowSwordTalentAlreadyInUse,
		// Token: 0x0400C01C RID: 49180
		[OriginalName("ArrowSwordTalentPreNodeNotInUse")]
		ArrowSwordTalentPreNodeNotInUse,
		// Token: 0x0400C01D RID: 49181
		[OriginalName("ArrowSwordActivityCfgNotFound")]
		ArrowSwordActivityCfgNotFound,
		// Token: 0x0400C01E RID: 49182
		[OriginalName("ArrowSwordTalentNotInUse")]
		ArrowSwordTalentNotInUse,
		// Token: 0x0400C01F RID: 49183
		[OriginalName("ArrowSwordActivityNotOpen")]
		ArrowSwordActivityNotOpen,
		// Token: 0x0400C020 RID: 49184
		[OriginalName("ArrowSwordActivityEnd")]
		ArrowSwordActivityEnd,
		// Token: 0x0400C021 RID: 49185
		[OriginalName("ArrowSwordComponentNoFind")]
		ArrowSwordComponentNoFind,
		// Token: 0x0400C022 RID: 49186
		[OriginalName("ArrowSwordSaveDataLost")]
		ArrowSwordSaveDataLost,
		// Token: 0x0400C023 RID: 49187
		[OriginalName("ArrowSwordRoleNotUnlock")]
		ArrowSwordRoleNotUnlock,
		// Token: 0x0400C024 RID: 49188
		[OriginalName("ArrowSwordRankListCd")]
		ArrowSwordRankListCd,
		// Token: 0x0400C025 RID: 49189
		[OriginalName("ArrowSwordComponentInstLost")]
		ArrowSwordComponentInstLost,
		// Token: 0x0400C026 RID: 49190
		[OriginalName("ArrowSwordInstNotInProgress")]
		ArrowSwordInstNotInProgress,
		// Token: 0x0400C027 RID: 49191
		[OriginalName("ArrowSwordInstNotInitialized")]
		ArrowSwordInstNotInitialized,
		// Token: 0x0400C028 RID: 49192
		[OriginalName("ArrowSwordHaveUnfinishedInst")]
		ArrowSwordHaveUnfinishedInst,
		// Token: 0x0400C029 RID: 49193
		[OriginalName("MotorFightLevelCfgNotFound")]
		MotorFightLevelCfgNotFound,
		// Token: 0x0400C02A RID: 49194
		[OriginalName("MotorFightTalentCfgNotFound")]
		MotorFightTalentCfgNotFound,
		// Token: 0x0400C02B RID: 49195
		[OriginalName("MotorFightTaskCfgNotFound")]
		MotorFightTaskCfgNotFound,
		// Token: 0x0400C02C RID: 49196
		[OriginalName("MotorFightItemCfgNotFound")]
		MotorFightItemCfgNotFound,
		// Token: 0x0400C02D RID: 49197
		[OriginalName("MotorFightRoleCfgNotFound")]
		MotorFightRoleCfgNotFound,
		// Token: 0x0400C02E RID: 49198
		[OriginalName("MotorFightPreNotCleared")]
		MotorFightPreNotCleared,
		// Token: 0x0400C02F RID: 49199
		[OriginalName("MotorFightActivityTypeNotMatch")]
		MotorFightActivityTypeNotMatch,
		// Token: 0x0400C030 RID: 49200
		[OriginalName("MotorFightTaskStatusHigher")]
		MotorFightTaskStatusHigher,
		// Token: 0x0400C031 RID: 49201
		[OriginalName("MotorFightInvalidInput")]
		MotorFightInvalidInput,
		// Token: 0x0400C032 RID: 49202
		[OriginalName("MotorFightDataOwnerErr")]
		MotorFightDataOwnerErr,
		// Token: 0x0400C033 RID: 49203
		[OriginalName("MotorFightActivityIdMisMatch")]
		MotorFightActivityIdMisMatch,
		// Token: 0x0400C034 RID: 49204
		[OriginalName("MotorFightTalentLocked")]
		MotorFightTalentLocked,
		// Token: 0x0400C035 RID: 49205
		[OriginalName("MotorFightTalentAlreadyInUse")]
		MotorFightTalentAlreadyInUse,
		// Token: 0x0400C036 RID: 49206
		[OriginalName("MotorFightTalentPreNodeNotInUse")]
		MotorFightTalentPreNodeNotInUse,
		// Token: 0x0400C037 RID: 49207
		[OriginalName("MotorFightActivityCfgNotFound")]
		MotorFightActivityCfgNotFound,
		// Token: 0x0400C038 RID: 49208
		[OriginalName("MotorFightTalentNotInUse")]
		MotorFightTalentNotInUse,
		// Token: 0x0400C039 RID: 49209
		[OriginalName("MotorFightActivityNotOpen")]
		MotorFightActivityNotOpen,
		// Token: 0x0400C03A RID: 49210
		[OriginalName("MotorFightActivityEnd")]
		MotorFightActivityEnd,
		// Token: 0x0400C03B RID: 49211
		[OriginalName("MotorFightComponentNoFind")]
		MotorFightComponentNoFind,
		// Token: 0x0400C03C RID: 49212
		[OriginalName("MotorFightSaveDataLost")]
		MotorFightSaveDataLost,
		// Token: 0x0400C03D RID: 49213
		[OriginalName("MotorFightRoleNotUnlock")]
		MotorFightRoleNotUnlock,
		// Token: 0x0400C03E RID: 49214
		[OriginalName("MotorFightRankListCd")]
		MotorFightRankListCd,
		// Token: 0x0400C03F RID: 49215
		[OriginalName("MotorFightComponentInstLost")]
		MotorFightComponentInstLost,
		// Token: 0x0400C040 RID: 49216
		[OriginalName("MotorFightInstNotInProgress")]
		MotorFightInstNotInProgress,
		// Token: 0x0400C041 RID: 49217
		[OriginalName("MotorFightInstNotInitialized")]
		MotorFightInstNotInitialized,
		// Token: 0x0400C042 RID: 49218
		[OriginalName("MotorFightHaveUnfinishedInst")]
		MotorFightHaveUnfinishedInst,
		// Token: 0x0400C043 RID: 49219
		[OriginalName("MotorFightAlreadySettle")]
		MotorFightAlreadySettle,
		// Token: 0x0400C044 RID: 49220
		[OriginalName("MotorFightNoInfiniteLevel")]
		MotorFightNoInfiniteLevel = 3100161,
		// Token: 0x0400C045 RID: 49221
		[OriginalName("MotorFightNoRoundData")]
		MotorFightNoRoundData = 3100163,
		// Token: 0x0400C046 RID: 49222
		[OriginalName("MotorFightLevelNotOpen")]
		MotorFightLevelNotOpen = 3100170,
		// Token: 0x0400C047 RID: 49223
		[OriginalName("MotorFightFirstClearRewardFail")]
		MotorFightFirstClearRewardFail,
		// Token: 0x0400C048 RID: 49224
		[OriginalName("MotorFightSettleResultNull")]
		MotorFightSettleResultNull,
		// Token: 0x0400C049 RID: 49225
		[OriginalName("EncircleChallengeCfgNotFound")]
		EncircleChallengeCfgNotFound = 3100148,
		// Token: 0x0400C04A RID: 49226
		[OriginalName("EncircleChallengeNotOpen")]
		EncircleChallengeNotOpen,
		// Token: 0x0400C04B RID: 49227
		[OriginalName("EncirclePreChallengeNotPass")]
		EncirclePreChallengeNotPass,
		// Token: 0x0400C04C RID: 49228
		[OriginalName("EncircleChallengeStepErr")]
		EncircleChallengeStepErr,
		// Token: 0x0400C04D RID: 49229
		[OriginalName("EncircleActivityTypeNotMatch")]
		EncircleActivityTypeNotMatch = 3100174,
		// Token: 0x0400C04E RID: 49230
		[OriginalName("EncircleChallengeNotStart")]
		EncircleChallengeNotStart = 3100177,
		// Token: 0x0400C04F RID: 49231
		[OriginalName("EncircleMultiGame")]
		EncircleMultiGame = 3100179,
		// Token: 0x0400C050 RID: 49232
		[OriginalName("EncircleActivityNotOpen")]
		EncircleActivityNotOpen = 3100206,
		// Token: 0x0400C051 RID: 49233
		[OriginalName("FetterGroupNotExist")]
		FetterGroupNotExist = 3100152,
		// Token: 0x0400C052 RID: 49234
		[OriginalName("DirectRefiningQualityErr")]
		DirectRefiningQualityErr,
		// Token: 0x0400C053 RID: 49235
		[OriginalName("FetterGroupConfigErr")]
		FetterGroupConfigErr,
		// Token: 0x0400C054 RID: 49236
		[OriginalName("FetterGroupDirectRefineLocked")]
		FetterGroupDirectRefineLocked,
		// Token: 0x0400C055 RID: 49237
		[OriginalName("PhantomDirectRefiningFetterNotFound")]
		PhantomDirectRefiningFetterNotFound,
		// Token: 0x0400C056 RID: 49238
		[OriginalName("PhantomDirectRefiningWeekTimesLimit")]
		PhantomDirectRefiningWeekTimesLimit,
		// Token: 0x0400C057 RID: 49239
		[OriginalName("PhantomMonsterConfNotFound")]
		PhantomMonsterConfNotFound,
		// Token: 0x0400C058 RID: 49240
		[OriginalName("GivebackScoreCannotReward")]
		GivebackScoreCannotReward = 3100167,
		// Token: 0x0400C059 RID: 49241
		[OriginalName("GivebackScoreCfgNotFound")]
		GivebackScoreCfgNotFound,
		// Token: 0x0400C05A RID: 49242
		[OriginalName("GivebackNotOpen")]
		GivebackNotOpen,
		// Token: 0x0400C05B RID: 49243
		[OriginalName("GivebackInvalidInput")]
		GivebackInvalidInput = 3100176,
		// Token: 0x0400C05C RID: 49244
		[OriginalName("GivebackParseDataError")]
		GivebackParseDataError = 3100178,
		// Token: 0x0400C05D RID: 49245
		[OriginalName("RhythmNotInLimitTime")]
		RhythmNotInLimitTime = 3100180,
		// Token: 0x0400C05E RID: 49246
		[OriginalName("RhythmTaskCfgNotFound")]
		RhythmTaskCfgNotFound,
		// Token: 0x0400C05F RID: 49247
		[OriginalName("RhythmActivityCfgNotFound")]
		RhythmActivityCfgNotFound,
		// Token: 0x0400C060 RID: 49248
		[OriginalName("RhythmPlanetCfgNotFound")]
		RhythmPlanetCfgNotFound,
		// Token: 0x0400C061 RID: 49249
		[OriginalName("RhythmLevelCfgNotFound")]
		RhythmLevelCfgNotFound,
		// Token: 0x0400C062 RID: 49250
		[OriginalName("RhythmSubLevelCfgNotFound")]
		RhythmSubLevelCfgNotFound,
		// Token: 0x0400C063 RID: 49251
		[OriginalName("RhythmRoleCfgNotFound")]
		RhythmRoleCfgNotFound = 3100190,
		// Token: 0x0400C064 RID: 49252
		[OriginalName("RhythmInputInvalid")]
		RhythmInputInvalid = 3100186,
		// Token: 0x0400C065 RID: 49253
		[OriginalName("RhythmActivityDataNotExist")]
		RhythmActivityDataNotExist,
		// Token: 0x0400C066 RID: 49254
		[OriginalName("RhythmTaskCannotReward")]
		RhythmTaskCannotReward,
		// Token: 0x0400C067 RID: 49255
		[OriginalName("RhythmInMulti")]
		RhythmInMulti,
		// Token: 0x0400C068 RID: 49256
		[OriginalName("RhythmSubLevelNotOpen")]
		RhythmSubLevelNotOpen = 3100191,
		// Token: 0x0400C069 RID: 49257
		[OriginalName("RhythmPreSubLevelNotCompleted")]
		RhythmPreSubLevelNotCompleted,
		// Token: 0x0400C06A RID: 49258
		[OriginalName("RhythmLevelNotOpen")]
		RhythmLevelNotOpen,
		// Token: 0x0400C06B RID: 49259
		[OriginalName("RhythmPlanetNotOpen")]
		RhythmPlanetNotOpen,
		// Token: 0x0400C06C RID: 49260
		[OriginalName("RhythmRoleLock")]
		RhythmRoleLock,
		// Token: 0x0400C06D RID: 49261
		[OriginalName("RhythmActivityIdMisMatch")]
		RhythmActivityIdMisMatch,
		// Token: 0x0400C06E RID: 49262
		[OriginalName("RhythmInvalidPayload")]
		RhythmInvalidPayload,
		// Token: 0x0400C06F RID: 49263
		[OriginalName("RhythmActivityTypeNotMatch")]
		RhythmActivityTypeNotMatch,
		// Token: 0x0400C070 RID: 49264
		[OriginalName("RhythmNoPartnerRoleId")]
		RhythmNoPartnerRoleId,
		// Token: 0x0400C071 RID: 49265
		[OriginalName("RhythmGetRankInCd")]
		RhythmGetRankInCd,
		// Token: 0x0400C072 RID: 49266
		[OriginalName("RhythmInstNotMatch")]
		RhythmInstNotMatch,
		// Token: 0x0400C073 RID: 49267
		[OriginalName("RhythmActivityEnd")]
		RhythmActivityEnd,
		// Token: 0x0400C074 RID: 49268
		[OriginalName("RhythmPartnerNotSet")]
		RhythmPartnerNotSet,
		// Token: 0x0400C075 RID: 49269
		[OriginalName("RhythmStartInfoLost")]
		RhythmStartInfoLost,
		// Token: 0x0400C076 RID: 49270
		[OriginalName("RhythmSubLevelNotMatch")]
		RhythmSubLevelNotMatch,
		// Token: 0x0400C077 RID: 49271
		[OriginalName("PinballLevelCfgNotFound")]
		PinballLevelCfgNotFound = 3100207,
		// Token: 0x0400C078 RID: 49272
		[OriginalName("PinballActivityNotOpen")]
		PinballActivityNotOpen,
		// Token: 0x0400C079 RID: 49273
		[OriginalName("PinballTrialLevelNotUseRole")]
		PinballTrialLevelNotUseRole,
		// Token: 0x0400C07A RID: 49274
		[OriginalName("PinballRoleCountInvalid")]
		PinballRoleCountInvalid,
		// Token: 0x0400C07B RID: 49275
		[OriginalName("PinballRoleNotOwn")]
		PinballRoleNotOwn,
		// Token: 0x0400C07C RID: 49276
		[OriginalName("PinballSceneNotExists")]
		PinballSceneNotExists,
		// Token: 0x0400C07D RID: 49277
		[OriginalName("PinballComponentNotExists")]
		PinballComponentNotExists,
		// Token: 0x0400C07E RID: 49278
		[OriginalName("PinballEnterCtxInvalid")]
		PinballEnterCtxInvalid,
		// Token: 0x0400C07F RID: 49279
		[OriginalName("PinballCompStateInvalid")]
		PinballCompStateInvalid,
		// Token: 0x0400C080 RID: 49280
		[OriginalName("PinballGameAlreadySettled")]
		PinballGameAlreadySettled,
		// Token: 0x0400C081 RID: 49281
		[OriginalName("PinballBonusScoreNotFull")]
		PinballBonusScoreNotFull,
		// Token: 0x0400C082 RID: 49282
		[OriginalName("PinballLevelTypeInvalid")]
		PinballLevelTypeInvalid,
		// Token: 0x0400C083 RID: 49283
		[OriginalName("PinballAlreadySettled")]
		PinballAlreadySettled,
		// Token: 0x0400C084 RID: 49284
		[OriginalName("PinballNoReviveTimesLeft")]
		PinballNoReviveTimesLeft,
		// Token: 0x0400C085 RID: 49285
		[OriginalName("PinballCompStateChangeReasonInvalid")]
		PinballCompStateChangeReasonInvalid,
		// Token: 0x0400C086 RID: 49286
		[OriginalName("PinballSettlePayloadInvalid")]
		PinballSettlePayloadInvalid,
		// Token: 0x0400C087 RID: 49287
		[OriginalName("PinballRoleCfgNotFound")]
		PinballRoleCfgNotFound,
		// Token: 0x0400C088 RID: 49288
		[OriginalName("PinballTemplateEntityConfigNotFound")]
		PinballTemplateEntityConfigNotFound,
		// Token: 0x0400C089 RID: 49289
		[OriginalName("PinballLevelNotBonus")]
		PinballLevelNotBonus,
		// Token: 0x0400C08A RID: 49290
		[OriginalName("PinballLevelTargetCondTypeNotSupport")]
		PinballLevelTargetCondTypeNotSupport,
		// Token: 0x0400C08B RID: 49291
		[OriginalName("PinballEffectCfgNotFound")]
		PinballEffectCfgNotFound,
		// Token: 0x0400C08C RID: 49292
		[OriginalName("PinballEffectHandlerNotFound")]
		PinballEffectHandlerNotFound,
		// Token: 0x0400C08D RID: 49293
		[OriginalName("PinballTrialLevelEnterWithRoles")]
		PinballTrialLevelEnterWithRoles,
		// Token: 0x0400C08E RID: 49294
		[OriginalName("PinballBtObjNotExists")]
		PinballBtObjNotExists,
		// Token: 0x0400C08F RID: 49295
		[OriginalName("PinballLevelEnterWithNoRole")]
		PinballLevelEnterWithNoRole,
		// Token: 0x0400C090 RID: 49296
		[OriginalName("PinballRoleLevelCfgNotFound")]
		PinballRoleLevelCfgNotFound = 3100238,
		// Token: 0x0400C091 RID: 49297
		[OriginalName("PinballDailyConfigInvalid")]
		PinballDailyConfigInvalid,
		// Token: 0x0400C092 RID: 49298
		[OriginalName("MotorOutlookPresetNameInvalid")]
		MotorOutlookPresetNameInvalid = 3100232,
		// Token: 0x0400C093 RID: 49299
		[OriginalName("MotorOutlookPresetNotOwn")]
		MotorOutlookPresetNotOwn,
		// Token: 0x0400C094 RID: 49300
		[OriginalName("MotorOutlookPresetMax")]
		MotorOutlookPresetMax,
		// Token: 0x0400C095 RID: 49301
		[OriginalName("MotorOutlookPresetNotExist")]
		MotorOutlookPresetNotExist,
		// Token: 0x0400C096 RID: 49302
		[OriginalName("MotorOutlookPresetInputInvalid")]
		MotorOutlookPresetInputInvalid,
		// Token: 0x0400C097 RID: 49303
		[OriginalName("MotorOutlookPresetIdInvalid")]
		MotorOutlookPresetIdInvalid,
		// Token: 0x0400C098 RID: 49304
		[OriginalName("MotorSkinCfgNotFound")]
		MotorSkinCfgNotFound = 3100243,
		// Token: 0x0400C099 RID: 49305
		[OriginalName("MotorSkinNotEditable")]
		MotorSkinNotEditable,
		// Token: 0x0400C09A RID: 49306
		[OriginalName("MotorSceneCfgNotFound")]
		MotorSceneCfgNotFound = 3100289,
		// Token: 0x0400C09B RID: 49307
		[OriginalName("CdkGiftCdkBatchAlreadyGot")]
		CdkGiftCdkBatchAlreadyGot = 3100240,
		// Token: 0x0400C09C RID: 49308
		[OriginalName("CdkGiftCdkPayGiftAlreadyBought")]
		CdkGiftCdkPayGiftAlreadyBought,
		// Token: 0x0400C09D RID: 49309
		[OriginalName("CdkGiftCdkPayGiftTypeErr")]
		CdkGiftCdkPayGiftTypeErr,
		// Token: 0x0400C09E RID: 49310
		[OriginalName("CdkGiftCdkPayGiftOldVersion")]
		CdkGiftCdkPayGiftOldVersion = 3100287,
		// Token: 0x0400C09F RID: 49311
		[OriginalName("NewBieMainlineActivityNotOpen")]
		NewBieMainlineActivityNotOpen = 3100245,
		// Token: 0x0400C0A0 RID: 49312
		[OriginalName("NewBieMainlineActivityEnd")]
		NewBieMainlineActivityEnd,
		// Token: 0x0400C0A1 RID: 49313
		[OriginalName("NewBieMainlineInvalidInput")]
		NewBieMainlineInvalidInput,
		// Token: 0x0400C0A2 RID: 49314
		[OriginalName("NewBieMainlineRewardActivityMismatch")]
		NewBieMainlineRewardActivityMismatch,
		// Token: 0x0400C0A3 RID: 49315
		[OriginalName("NewBieMainlineTabTaskCfgNotFound")]
		NewBieMainlineTabTaskCfgNotFound,
		// Token: 0x0400C0A4 RID: 49316
		[OriginalName("NewBieMainlineTabRewardCfgNotFound")]
		NewBieMainlineTabRewardCfgNotFound,
		// Token: 0x0400C0A5 RID: 49317
		[OriginalName("NewBieMainlineRewardAlreadyTaken")]
		NewBieMainlineRewardAlreadyTaken,
		// Token: 0x0400C0A6 RID: 49318
		[OriginalName("NewBieMainlineScoreNotEnough")]
		NewBieMainlineScoreNotEnough,
		// Token: 0x0400C0A7 RID: 49319
		[OriginalName("NewBieMainlineRewardDropFail")]
		NewBieMainlineRewardDropFail,
		// Token: 0x0400C0A8 RID: 49320
		[OriginalName("NewBieAdventureActivityNotOpen")]
		NewBieAdventureActivityNotOpen,
		// Token: 0x0400C0A9 RID: 49321
		[OriginalName("NewBieAdventureActivityCfgNotFound")]
		NewBieAdventureActivityCfgNotFound,
		// Token: 0x0400C0AA RID: 49322
		[OriginalName("NewBieAdventureActivityEnd")]
		NewBieAdventureActivityEnd,
		// Token: 0x0400C0AB RID: 49323
		[OriginalName("NewBieAdventureInvalidInput")]
		NewBieAdventureInvalidInput,
		// Token: 0x0400C0AC RID: 49324
		[OriginalName("NewBieAdventureChapterV2CfgNotFound")]
		NewBieAdventureChapterV2CfgNotFound,
		// Token: 0x0400C0AD RID: 49325
		[OriginalName("NewBieAdventureTaskV2CfgNotFound")]
		NewBieAdventureTaskV2CfgNotFound,
		// Token: 0x0400C0AE RID: 49326
		[OriginalName("NewBieAdventureV2RewardAlreadyTaken")]
		NewBieAdventureV2RewardAlreadyTaken,
		// Token: 0x0400C0AF RID: 49327
		[OriginalName("NewBieAdventureV2RewardDropFail")]
		NewBieAdventureV2RewardDropFail,
		// Token: 0x0400C0B0 RID: 49328
		[OriginalName("NewBieAdventureV2ChapterLocked")]
		NewBieAdventureV2ChapterLocked,
		// Token: 0x0400C0B1 RID: 49329
		[OriginalName("NewBieAdventureV2ChapterRewardNotReady")]
		NewBieAdventureV2ChapterRewardNotReady,
		// Token: 0x0400C0B2 RID: 49330
		[OriginalName("NewBieAdventureV2NoTaskConfig")]
		NewBieAdventureV2NoTaskConfig,
		// Token: 0x0400C0B3 RID: 49331
		[OriginalName("NewBieAdventureV2RoleNotSet")]
		NewBieAdventureV2RoleNotSet,
		// Token: 0x0400C0B4 RID: 49332
		[OriginalName("NewBieAdventureV2RoleInvalid")]
		NewBieAdventureV2RoleInvalid,
		// Token: 0x0400C0B5 RID: 49333
		[OriginalName("NewBieAdventureV2TasksCrossChapter")]
		NewBieAdventureV2TasksCrossChapter,
		// Token: 0x0400C0B6 RID: 49334
		[OriginalName("NewBieAdventureV2TaskNotComplete")]
		NewBieAdventureV2TaskNotComplete,
		// Token: 0x0400C0B7 RID: 49335
		[OriginalName("GeneralDailyResetCronNotFound")]
		GeneralDailyResetCronNotFound,
		// Token: 0x0400C0B8 RID: 49336
		[OriginalName("ActivitySignConfigNotFound")]
		ActivitySignConfigNotFound,
		// Token: 0x0400C0B9 RID: 49337
		[OriginalName("SignActivityFreeDropNoConfig")]
		SignActivityFreeDropNoConfig,
		// Token: 0x0400C0BA RID: 49338
		[OriginalName("SignActivityFreeDropAlreadyTaken")]
		SignActivityFreeDropAlreadyTaken,
		// Token: 0x0400C0BB RID: 49339
		[OriginalName("NewBieV2NoLicense")]
		NewBieV2NoLicense,
		// Token: 0x0400C0BC RID: 49340
		[OriginalName("NewBieV1NoLicense")]
		NewBieV1NoLicense,
		// Token: 0x0400C0BD RID: 49341
		[OriginalName("WeekCardPersonalNoPermission")]
		WeekCardPersonalNoPermission,
		// Token: 0x0400C0BE RID: 49342
		[OriginalName("WeekCardPersonalPermissionExpired")]
		WeekCardPersonalPermissionExpired,
		// Token: 0x0400C0BF RID: 49343
		[OriginalName("WeekCardNotPersonal")]
		WeekCardNotPersonal,
		// Token: 0x0400C0C0 RID: 49344
		[OriginalName("WeekCardInputErr")]
		WeekCardInputErr = 3100286,
		// Token: 0x0400C0C1 RID: 49345
		[OriginalName("WeekCardRecycleNoPermission")]
		WeekCardRecycleNoPermission = 3100278,
		// Token: 0x0400C0C2 RID: 49346
		[OriginalName("NewPlayerSupportSameParent")]
		NewPlayerSupportSameParent = 3100323,
		// Token: 0x0400C0C3 RID: 49347
		[OriginalName("NewBieCourseV2ActivityNotOpen")]
		NewBieCourseV2ActivityNotOpen = 3100279,
		// Token: 0x0400C0C4 RID: 49348
		[OriginalName("NewBieCourseV2ActivityCfgNotFound")]
		NewBieCourseV2ActivityCfgNotFound,
		// Token: 0x0400C0C5 RID: 49349
		[OriginalName("NewBieCourseV2ActivityEnd")]
		NewBieCourseV2ActivityEnd,
		// Token: 0x0400C0C6 RID: 49350
		[OriginalName("NewBieCourseV2InvalidInput")]
		NewBieCourseV2InvalidInput,
		// Token: 0x0400C0C7 RID: 49351
		[OriginalName("NewBieCourseV2CfgNotFound")]
		NewBieCourseV2CfgNotFound,
		// Token: 0x0400C0C8 RID: 49352
		[OriginalName("NewBieCourseV2LevelNotEnough")]
		NewBieCourseV2LevelNotEnough,
		// Token: 0x0400C0C9 RID: 49353
		[OriginalName("NewBieCourseV2RewardAlreadyTaken")]
		NewBieCourseV2RewardAlreadyTaken,
		// Token: 0x0400C0CA RID: 49354
		[OriginalName("SolarSchoolInputInvalid")]
		SolarSchoolInputInvalid = 3100324,
		// Token: 0x0400C0CB RID: 49355
		[OriginalName("SolarSchoolTaskCfgNotFound")]
		SolarSchoolTaskCfgNotFound,
		// Token: 0x0400C0CC RID: 49356
		[OriginalName("SolarSchoolTaskCannotReward")]
		SolarSchoolTaskCannotReward,
		// Token: 0x0400C0CD RID: 49357
		[OriginalName("SolarSchoolActivityDataNotExist")]
		SolarSchoolActivityDataNotExist,
		// Token: 0x0400C0CE RID: 49358
		[OriginalName("SolarSchoolNotInLimitTime")]
		SolarSchoolNotInLimitTime,
		// Token: 0x0400C0CF RID: 49359
		[OriginalName("SolarSchoolActivityTypeNotMatch")]
		SolarSchoolActivityTypeNotMatch,
		// Token: 0x0400C0D0 RID: 49360
		[OriginalName("SolarSchoolActivityEnd")]
		SolarSchoolActivityEnd,
		// Token: 0x0400C0D1 RID: 49361
		[OriginalName("SolarSchoolActivityCfgNotFound")]
		SolarSchoolActivityCfgNotFound,
		// Token: 0x0400C0D2 RID: 49362
		[OriginalName("SolarSchoolGalleryCfgNotFound")]
		SolarSchoolGalleryCfgNotFound,
		// Token: 0x0400C0D3 RID: 49363
		[OriginalName("SolarSchoolGalleryLock")]
		SolarSchoolGalleryLock,
		// Token: 0x0400C0D4 RID: 49364
		[OriginalName("SolarSchoolGalleryCannotReward")]
		SolarSchoolGalleryCannotReward,
		// Token: 0x0400C0D5 RID: 49365
		[OriginalName("SolarSchoolSaveInvalid")]
		SolarSchoolSaveInvalid,
		// Token: 0x0400C0D6 RID: 49366
		[OriginalName("SolarSchoolSaveReasonInvalid")]
		SolarSchoolSaveReasonInvalid,
		// Token: 0x0400C0D7 RID: 49367
		[OriginalName("SolarSchoolSaveSlotInvalid")]
		SolarSchoolSaveSlotInvalid,
		// Token: 0x0400C0D8 RID: 49368
		[OriginalName("SolarSchoolSaveSlotNotFound")]
		SolarSchoolSaveSlotNotFound,
		// Token: 0x0400C0D9 RID: 49369
		[OriginalName("SolarSchoolSaveDataCorrupted")]
		SolarSchoolSaveDataCorrupted,
		// Token: 0x0400C0DA RID: 49370
		[OriginalName("SolarSchoolInProgressNotInitialized")]
		SolarSchoolInProgressNotInitialized,
		// Token: 0x0400C0DB RID: 49371
		[OriginalName("SolarSchoolBatchSyncCountInvalid")]
		SolarSchoolBatchSyncCountInvalid,
		// Token: 0x0400C0DC RID: 49372
		[OriginalName("SolarSchoolSyncTypeInvalid")]
		SolarSchoolSyncTypeInvalid,
		// Token: 0x0400C0DD RID: 49373
		[OriginalName("SolarSchoolSyncPayloadMismatch")]
		SolarSchoolSyncPayloadMismatch,
		// Token: 0x0400C0DE RID: 49374
		[OriginalName("SolarSchoolGameCfgNotFound")]
		SolarSchoolGameCfgNotFound,
		// Token: 0x0400C0DF RID: 49375
		[OriginalName("SolarSchoolDuplicateInput")]
		SolarSchoolDuplicateInput,
		// Token: 0x0400C0E0 RID: 49376
		[OriginalName("SolarSchoolNotUnlocked")]
		SolarSchoolNotUnlocked,
		// Token: 0x0400C0E1 RID: 49377
		[OriginalName("SolarSchoolAlreadyUnlocked")]
		SolarSchoolAlreadyUnlocked,
		// Token: 0x0400C0E2 RID: 49378
		[OriginalName("SolarSchoolAlreadyCompleted")]
		SolarSchoolAlreadyCompleted,
		// Token: 0x0400C0E3 RID: 49379
		[OriginalName("SolarSchoolNpcFavorLevelNotIncreased")]
		SolarSchoolNpcFavorLevelNotIncreased,
		// Token: 0x0400C0E4 RID: 49380
		[OriginalName("SolarSchoolValueOutOfRange")]
		SolarSchoolValueOutOfRange,
		// Token: 0x0400C0E5 RID: 49381
		[OriginalName("SolarSchoolItemInsufficient")]
		SolarSchoolItemInsufficient,
		// Token: 0x0400C0E6 RID: 49382
		[OriginalName("SolarSchoolItemStackLimitExceeded")]
		SolarSchoolItemStackLimitExceeded,
		// Token: 0x0400C0E7 RID: 49383
		[OriginalName("SolarSchoolShopGoodsInvalid")]
		SolarSchoolShopGoodsInvalid,
		// Token: 0x0400C0E8 RID: 49384
		[OriginalName("SolarSchoolShopBuyLimitExceeded")]
		SolarSchoolShopBuyLimitExceeded,
		// Token: 0x0400C0E9 RID: 49385
		[OriginalName("SolarSchoolEndingCfgNotFound")]
		SolarSchoolEndingCfgNotFound,
		// Token: 0x0400C0EA RID: 49386
		[OriginalName("SolarSchoolActivityIdNotMatch")]
		SolarSchoolActivityIdNotMatch,
		// Token: 0x0400C0EB RID: 49387
		[OriginalName("SolarSchoolLimitAccNotEnough")]
		SolarSchoolLimitAccNotEnough = 3100358,
		// Token: 0x0400C0EC RID: 49388
		[OriginalName("SolarSchoolLimitAccAlreadyRewarded")]
		SolarSchoolLimitAccAlreadyRewarded,
		// Token: 0x0400C0ED RID: 49389
		[OriginalName("SolarSchoolQuestNotSavable")]
		SolarSchoolQuestNotSavable = 3100371,
		// Token: 0x0400C0EE RID: 49390
		[OriginalName("SolarSchoolRewardedBitInvalid")]
		SolarSchoolRewardedBitInvalid,
		// Token: 0x0400C0EF RID: 49391
		[OriginalName("SolarSchoolSaveVersionInvalid")]
		SolarSchoolSaveVersionInvalid = 3100378,
		// Token: 0x0400C0F0 RID: 49392
		[OriginalName("SolarSchoolShopRecordInvalid")]
		SolarSchoolShopRecordInvalid,
		// Token: 0x0400C0F1 RID: 49393
		[OriginalName("SolarSchoolSummaryInvalid")]
		SolarSchoolSummaryInvalid,
		// Token: 0x0400C0F2 RID: 49394
		[OriginalName("SolarSchoolInfluenceLevelInvalid")]
		SolarSchoolInfluenceLevelInvalid = 3100386,
		// Token: 0x0400C0F3 RID: 49395
		[OriginalName("SolarSchoolGiftCountInvalid")]
		SolarSchoolGiftCountInvalid,
		// Token: 0x0400C0F4 RID: 49396
		[OriginalName("SolarSchoolInMultiGame")]
		SolarSchoolInMultiGame = 3100416,
		// Token: 0x0400C0F5 RID: 49397
		[OriginalName("SolarSchoolAttrCfgNotFound")]
		SolarSchoolAttrCfgNotFound = 3100419,
		// Token: 0x0400C0F6 RID: 49398
		[OriginalName("SolarSchoolRoleCfgNotFound")]
		SolarSchoolRoleCfgNotFound,
		// Token: 0x0400C0F7 RID: 49399
		[OriginalName("SolarSchoolInfluenceCfgNotFound")]
		SolarSchoolInfluenceCfgNotFound,
		// Token: 0x0400C0F8 RID: 49400
		[OriginalName("SolarSchoolBehaviorCfgNotFound")]
		SolarSchoolBehaviorCfgNotFound,
		// Token: 0x0400C0F9 RID: 49401
		[OriginalName("SolarSchoolExamCfgNotFound")]
		SolarSchoolExamCfgNotFound,
		// Token: 0x0400C0FA RID: 49402
		[OriginalName("SolarSchoolItemCfgNotFound")]
		SolarSchoolItemCfgNotFound,
		// Token: 0x0400C0FB RID: 49403
		[OriginalName("SolarSchoolShopCfgNotFound")]
		SolarSchoolShopCfgNotFound,
		// Token: 0x0400C0FC RID: 49404
		[OriginalName("SolarSchoolShopGoodsCfgNotFound")]
		SolarSchoolShopGoodsCfgNotFound,
		// Token: 0x0400C0FD RID: 49405
		[OriginalName("SolarSchoolQuestCfgNotFound")]
		SolarSchoolQuestCfgNotFound,
		// Token: 0x0400C0FE RID: 49406
		[OriginalName("SolarSchoolQuestRewardCfgNotFound")]
		SolarSchoolQuestRewardCfgNotFound,
		// Token: 0x0400C0FF RID: 49407
		[OriginalName("SolarSchoolQuestNodeCfgNotFound")]
		SolarSchoolQuestNodeCfgNotFound,
		// Token: 0x0400C100 RID: 49408
		[OriginalName("SolarSchoolTraceIdNotMatch")]
		SolarSchoolTraceIdNotMatch = 3100463,
		// Token: 0x0400C101 RID: 49409
		[OriginalName("SolarSchoolGameDayBackward")]
		SolarSchoolGameDayBackward,
		// Token: 0x0400C102 RID: 49410
		[OriginalName("SolarSchoolGameDayExceedMax")]
		SolarSchoolGameDayExceedMax,
		// Token: 0x0400C103 RID: 49411
		[OriginalName("SolarSchoolGameDaySkipInvalid")]
		SolarSchoolGameDaySkipInvalid,
		// Token: 0x0400C104 RID: 49412
		[OriginalName("SolarSchoolSyncCountExceeded")]
		SolarSchoolSyncCountExceeded,
		// Token: 0x0400C105 RID: 49413
		[OriginalName("SolarSchoolAttrGainExceeded")]
		SolarSchoolAttrGainExceeded,
		// Token: 0x0400C106 RID: 49414
		[OriginalName("SolarSchoolItemDailyMaxExceeded")]
		SolarSchoolItemDailyMaxExceeded,
		// Token: 0x0400C107 RID: 49415
		[OriginalName("SolarSchoolSpecialItemCannotCost")]
		SolarSchoolSpecialItemCannotCost,
		// Token: 0x0400C108 RID: 49416
		[OriginalName("SolarSchoolSaveCycleCountNotMatch")]
		SolarSchoolSaveCycleCountNotMatch,
		// Token: 0x0400C109 RID: 49417
		[OriginalName("SolarSchoolSaveGameDayNotMatch")]
		SolarSchoolSaveGameDayNotMatch,
		// Token: 0x0400C10A RID: 49418
		[OriginalName("SolarSchoolSaveAttrNotMatch")]
		SolarSchoolSaveAttrNotMatch,
		// Token: 0x0400C10B RID: 49419
		[OriginalName("SolarSchoolSaveItemNotMatch")]
		SolarSchoolSaveItemNotMatch,
		// Token: 0x0400C10C RID: 49420
		[OriginalName("SolarSchoolSaveGotItemBitNotMatch")]
		SolarSchoolSaveGotItemBitNotMatch,
		// Token: 0x0400C10D RID: 49421
		[OriginalName("SolarSchoolNewCycleAttrInvalid")]
		SolarSchoolNewCycleAttrInvalid,
		// Token: 0x0400C10E RID: 49422
		[OriginalName("SolarSchoolNewCycleItemInvalid")]
		SolarSchoolNewCycleItemInvalid,
		// Token: 0x0400C10F RID: 49423
		[OriginalName("SolarSchoolPreviewAttrNotMatch")]
		SolarSchoolPreviewAttrNotMatch,
		// Token: 0x0400C110 RID: 49424
		[OriginalName("SolarSchoolAttrAddCostInvalid")]
		SolarSchoolAttrAddCostInvalid,
		// Token: 0x0400C111 RID: 49425
		[OriginalName("SolarSchoolAttrDuplicate")]
		SolarSchoolAttrDuplicate,
		// Token: 0x0400C112 RID: 49426
		[OriginalName("SolarSchoolAttrFinalCfgNotFound")]
		SolarSchoolAttrFinalCfgNotFound,
		// Token: 0x0400C113 RID: 49427
		[OriginalName("SolarSchoolAttrFinalOutOfRange")]
		SolarSchoolAttrFinalOutOfRange,
		// Token: 0x0400C114 RID: 49428
		[OriginalName("SolarSchoolMoneyAddExceeded")]
		SolarSchoolMoneyAddExceeded,
		// Token: 0x0400C115 RID: 49429
		[OriginalName("SolarSchoolClientResVersionTooLow")]
		SolarSchoolClientResVersionTooLow,
		// Token: 0x0400C116 RID: 49430
		[OriginalName("SolarSchoolParamCfgNotFound")]
		SolarSchoolParamCfgNotFound,
		// Token: 0x0400C117 RID: 49431
		[OriginalName("ErrNotGetFightInfoDtType")]
		ErrNotGetFightInfoDtType = 3200000,
		// Token: 0x0400C118 RID: 49432
		[OriginalName("ErrFightInfoDtType")]
		ErrFightInfoDtType,
		// Token: 0x0400C119 RID: 49433
		[OriginalName("ErrSetFightInfoDtType")]
		ErrSetFightInfoDtType,
		// Token: 0x0400C11A RID: 49434
		[OriginalName("ErrChangeDtTypeParamError")]
		ErrChangeDtTypeParamError,
		// Token: 0x0400C11B RID: 49435
		[OriginalName("ErrCurSceneNotMatch")]
		ErrCurSceneNotMatch = 3300000,
		// Token: 0x0400C11C RID: 49436
		[OriginalName("ErrTargetNotForDeadEye")]
		ErrTargetNotForDeadEye,
		// Token: 0x0400C11D RID: 49437
		[OriginalName("ErrDeadEyeCount")]
		ErrDeadEyeCount,
		// Token: 0x0400C11E RID: 49438
		[OriginalName("ErrNoMoveEvent")]
		ErrNoMoveEvent,
		// Token: 0x0400C11F RID: 49439
		[OriginalName("ErrEntityTypeNotSupport")]
		ErrEntityTypeNotSupport,
		// Token: 0x0400C120 RID: 49440
		[OriginalName("ErrExploreSkillNoActions")]
		ErrExploreSkillNoActions,
		// Token: 0x0400C121 RID: 49441
		[OriginalName("ErrExploreSkillActionMultiGame")]
		ErrExploreSkillActionMultiGame,
		// Token: 0x0400C122 RID: 49442
		[OriginalName("ErrExploreSkillActionNotExist")]
		ErrExploreSkillActionNotExist,
		// Token: 0x0400C123 RID: 49443
		[OriginalName("ErrMonsterNotGameplayTagComp")]
		ErrMonsterNotGameplayTagComp,
		// Token: 0x0400C124 RID: 49444
		[OriginalName("ErrDecalEffectNotFound")]
		ErrDecalEffectNotFound,
		// Token: 0x0400C125 RID: 49445
		[OriginalName("ErrEntityNotInCurMap")]
		ErrEntityNotInCurMap,
		// Token: 0x0400C126 RID: 49446
		[OriginalName("ErrEntityNotInCurScene")]
		ErrEntityNotInCurScene,
		// Token: 0x0400C127 RID: 49447
		[OriginalName("ErrEntityNotForNpcTimeSchedule")]
		ErrEntityNotForNpcTimeSchedule,
		// Token: 0x0400C128 RID: 49448
		[OriginalName("ErrEntityNotInAnySchedule")]
		ErrEntityNotInAnySchedule,
		// Token: 0x0400C129 RID: 49449
		[OriginalName("ErrSplineConfigNotFound")]
		ErrSplineConfigNotFound,
		// Token: 0x0400C12A RID: 49450
		[OriginalName("ErrSplineIdxOutofBound")]
		ErrSplineIdxOutofBound,
		// Token: 0x0400C12B RID: 49451
		[OriginalName("ErrPositionConfig")]
		ErrPositionConfig,
		// Token: 0x0400C12C RID: 49452
		[OriginalName("ErrSplineNotForTimeSchedule")]
		ErrSplineNotForTimeSchedule,
		// Token: 0x0400C12D RID: 49453
		[OriginalName("ErrHostPlayerNotSame")]
		ErrHostPlayerNotSame,
		// Token: 0x0400C12E RID: 49454
		[OriginalName("ErrInteractType")]
		ErrInteractType,
		// Token: 0x0400C12F RID: 49455
		[OriginalName("ErrEntityAlreadyDie")]
		ErrEntityAlreadyDie,
		// Token: 0x0400C130 RID: 49456
		[OriginalName("ErrEntityAlreadyDestroyed")]
		ErrEntityAlreadyDestroyed,
		// Token: 0x0400C131 RID: 49457
		[OriginalName("ErrRequestLimitExceeded")]
		ErrRequestLimitExceeded,
		// Token: 0x0400C132 RID: 49458
		[OriginalName("ErrOptionOutofBound")]
		ErrOptionOutofBound,
		// Token: 0x0400C133 RID: 49459
		[OriginalName("ErrHoldHandInvalidActionType")]
		ErrHoldHandInvalidActionType,
		// Token: 0x0400C134 RID: 49460
		[OriginalName("ErrMultiPreconditionChainError")]
		ErrMultiPreconditionChainError,
		// Token: 0x0400C135 RID: 49461
		[OriginalName("ErrBlackScreenIllegalSource")]
		ErrBlackScreenIllegalSource = 3400000,
		// Token: 0x0400C136 RID: 49462
		[OriginalName("ErrBeamReceiveEntityNotConfig")]
		ErrBeamReceiveEntityNotConfig,
		// Token: 0x0400C137 RID: 49463
		[OriginalName("ErrBeamReceiveCondition")]
		ErrBeamReceiveCondition,
		// Token: 0x0400C138 RID: 49464
		[OriginalName("ErrBeamReceiveEntityNotConfig2")]
		ErrBeamReceiveEntityNotConfig2,
		// Token: 0x0400C139 RID: 49465
		[OriginalName("ErrFlowerPollutionNotConfig")]
		ErrFlowerPollutionNotConfig,
		// Token: 0x0400C13A RID: 49466
		[OriginalName("ErrorFlowerPollutionState")]
		ErrorFlowerPollutionState,
		// Token: 0x0400C13B RID: 49467
		[OriginalName("ErrDollGarbTimeOut")]
		ErrDollGarbTimeOut,
		// Token: 0x0400C13C RID: 49468
		[OriginalName("ErrGrabMachineEntityNotConfig")]
		ErrGrabMachineEntityNotConfig,
		// Token: 0x0400C13D RID: 49469
		[OriginalName("ErrGrabItemNotInConfig")]
		ErrGrabItemNotInConfig,
		// Token: 0x0400C13E RID: 49470
		[OriginalName("ErrItemHasBeenClipped")]
		ErrItemHasBeenClipped,
		// Token: 0x0400C13F RID: 49471
		[OriginalName("ErrDollGrabNoCsvConfig")]
		ErrDollGrabNoCsvConfig,
		// Token: 0x0400C140 RID: 49472
		[OriginalName("ErrPlayerNotStartedPlaying")]
		ErrPlayerNotStartedPlaying,
		// Token: 0x0400C141 RID: 49473
		[OriginalName("ErrGrabShowcaseEntityNotConfig")]
		ErrGrabShowcaseEntityNotConfig,
		// Token: 0x0400C142 RID: 49474
		[OriginalName("ErrPlayerBagNotDoll")]
		ErrPlayerBagNotDoll,
		// Token: 0x0400C143 RID: 49475
		[OriginalName("ErrDollIsDelivered")]
		ErrDollIsDelivered,
		// Token: 0x0400C144 RID: 49476
		[OriginalName("ErrPlayerAlreadyPlaying")]
		ErrPlayerAlreadyPlaying,
		// Token: 0x0400C145 RID: 49477
		[OriginalName("ErrGrabItemTypeMismatch")]
		ErrGrabItemTypeMismatch,
		// Token: 0x0400C146 RID: 49478
		[OriginalName("ErrDollGrabAlreadyPaused")]
		ErrDollGrabAlreadyPaused,
		// Token: 0x0400C147 RID: 49479
		[OriginalName("ErrDollGrabNotPaused")]
		ErrDollGrabNotPaused,
		// Token: 0x0400C148 RID: 49480
		[OriginalName("ErrDollMachineDropReward")]
		ErrDollMachineDropReward
	}
}
