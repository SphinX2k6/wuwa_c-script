using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015AC RID: 5548
	public enum ErrorCode
	{
		// Token: 0x0400A848 RID: 43080
		[OriginalName("Success")]
		Success,
		// Token: 0x0400A849 RID: 43081
		[OriginalName("RequestParamError")]
		RequestParamError,
		// Token: 0x0400A84A RID: 43082
		[OriginalName("InternalError")]
		InternalError,
		// Token: 0x0400A84B RID: 43083
		[OriginalName("UnKnownError")]
		UnKnownError,
		// Token: 0x0400A84C RID: 43084
		[OriginalName("ServerNotReady")]
		ServerNotReady,
		// Token: 0x0400A84D RID: 43085
		[OriginalName("ServerFullLoad")]
		ServerFullLoad,
		// Token: 0x0400A84E RID: 43086
		[OriginalName("InvalidUserId")]
		InvalidUserId,
		// Token: 0x0400A84F RID: 43087
		[OriginalName("InvalidToken")]
		InvalidToken,
		// Token: 0x0400A850 RID: 43088
		[OriginalName("InvalidRequest")]
		InvalidRequest,
		// Token: 0x0400A851 RID: 43089
		[OriginalName("GmFail")]
		GmFail,
		// Token: 0x0400A852 RID: 43090
		[OriginalName("GmParamError")]
		GmParamError,
		// Token: 0x0400A853 RID: 43091
		[OriginalName("GmException")]
		GmException,
		// Token: 0x0400A854 RID: 43092
		[OriginalName("NotEnableGm")]
		NotEnableGm,
		// Token: 0x0400A855 RID: 43093
		[OriginalName("NotElegantName")]
		NotElegantName,
		// Token: 0x0400A856 RID: 43094
		[OriginalName("ContainsDirtyWord")]
		ContainsDirtyWord,
		// Token: 0x0400A857 RID: 43095
		[OriginalName("DirtyWordServerError")]
		DirtyWordServerError,
		// Token: 0x0400A858 RID: 43096
		[OriginalName("DirtyWordServerReturnEmpty")]
		DirtyWordServerReturnEmpty,
		// Token: 0x0400A859 RID: 43097
		[OriginalName("DirtyWordCheckException")]
		DirtyWordCheckException,
		// Token: 0x0400A85A RID: 43098
		[OriginalName("ComponentNotExist")]
		ComponentNotExist,
		// Token: 0x0400A85B RID: 43099
		[OriginalName("ServerFullLoadGame")]
		ServerFullLoadGame,
		// Token: 0x0400A85C RID: 43100
		[OriginalName("ServerFullLoadGate")]
		ServerFullLoadGate,
		// Token: 0x0400A85D RID: 43101
		[OriginalName("PlayerLoggingInFlag")]
		PlayerLoggingInFlag,
		// Token: 0x0400A85E RID: 43102
		[OriginalName("GateLoginException")]
		GateLoginException,
		// Token: 0x0400A85F RID: 43103
		[OriginalName("GateLoginSeverSelectErr")]
		GateLoginSeverSelectErr,
		// Token: 0x0400A860 RID: 43104
		[OriginalName("GateTokenAccessErr")]
		GateTokenAccessErr,
		// Token: 0x0400A861 RID: 43105
		[OriginalName("GateTokenAccessException")]
		GateTokenAccessException,
		// Token: 0x0400A862 RID: 43106
		[OriginalName("GateLoginUserIdErr")]
		GateLoginUserIdErr,
		// Token: 0x0400A863 RID: 43107
		[OriginalName("GateLoginNodeIdErr")]
		GateLoginNodeIdErr,
		// Token: 0x0400A864 RID: 43108
		[OriginalName("GateLoginCreateCharacterErr")]
		GateLoginCreateCharacterErr,
		// Token: 0x0400A865 RID: 43109
		[OriginalName("GateCreateCharacterException")]
		GateCreateCharacterException,
		// Token: 0x0400A866 RID: 43110
		[OriginalName("GateEnterGameAddressNotFound")]
		GateEnterGameAddressNotFound,
		// Token: 0x0400A867 RID: 43111
		[OriginalName("GateEnterGameException")]
		GateEnterGameException,
		// Token: 0x0400A868 RID: 43112
		[OriginalName("GateEnterGameCreatePlayerErr")]
		GateEnterGameCreatePlayerErr,
		// Token: 0x0400A869 RID: 43113
		[OriginalName("GateEnterGameAddPlayerErr")]
		GateEnterGameAddPlayerErr,
		// Token: 0x0400A86A RID: 43114
		[OriginalName("GameGateNodeNotFound")]
		GameGateNodeNotFound,
		// Token: 0x0400A86B RID: 43115
		[OriginalName("GamePlayerAdminExist")]
		GamePlayerAdminExist,
		// Token: 0x0400A86C RID: 43116
		[OriginalName("GameReloginGateNodeNotFound")]
		GameReloginGateNodeNotFound,
		// Token: 0x0400A86D RID: 43117
		[OriginalName("GameReloginPlayerNotFound")]
		GameReloginPlayerNotFound,
		// Token: 0x0400A86E RID: 43118
		[OriginalName("ServerNotOpen")]
		ServerNotOpen,
		// Token: 0x0400A86F RID: 43119
		[OriginalName("ServerMaintenance")]
		ServerMaintenance,
		// Token: 0x0400A870 RID: 43120
		[OriginalName("InvalidLoginType")]
		InvalidLoginType,
		// Token: 0x0400A871 RID: 43121
		[OriginalName("InvalidGateway")]
		InvalidGateway,
		// Token: 0x0400A872 RID: 43122
		[OriginalName("SDKServerError")]
		SdkserverError,
		// Token: 0x0400A873 RID: 43123
		[OriginalName("TokenNotAuthrized")]
		TokenNotAuthrized,
		// Token: 0x0400A874 RID: 43124
		[OriginalName("HadBan")]
		HadBan,
		// Token: 0x0400A875 RID: 43125
		[OriginalName("NotInUserIdWhiteList")]
		NotInUserIdWhiteList,
		// Token: 0x0400A876 RID: 43126
		[OriginalName("NoHealthyGamesvr")]
		NoHealthyGamesvr,
		// Token: 0x0400A877 RID: 43127
		[OriginalName("NoHealthyGateway")]
		NoHealthyGateway,
		// Token: 0x0400A878 RID: 43128
		[OriginalName("GarFailed")]
		GarFailed,
		// Token: 0x0400A879 RID: 43129
		[OriginalName("GarSdkCheckFail")]
		GarSdkCheckFail,
		// Token: 0x0400A87A RID: 43130
		[OriginalName("GarNoneUserInfo")]
		GarNoneUserInfo,
		// Token: 0x0400A87B RID: 43131
		[OriginalName("GarQueryUserInfoError")]
		GarQueryUserInfoError,
		// Token: 0x0400A87C RID: 43132
		[OriginalName("GarNoRegion")]
		GarNoRegion,
		// Token: 0x0400A87D RID: 43133
		[OriginalName("InternalExceptionCode")]
		InternalExceptionCode,
		// Token: 0x0400A87E RID: 43134
		[OriginalName("DecodeExceptionCode")]
		DecodeExceptionCode,
		// Token: 0x0400A87F RID: 43135
		[OriginalName("EncodeExceptionCode")]
		EncodeExceptionCode,
		// Token: 0x0400A880 RID: 43136
		[OriginalName("InvalidRequestExceptionCode")]
		InvalidRequestExceptionCode,
		// Token: 0x0400A881 RID: 43137
		[OriginalName("MessageOutOfLimitExceptionCode")]
		MessageOutOfLimitExceptionCode,
		// Token: 0x0400A882 RID: 43138
		[OriginalName("MessageNoHandler")]
		MessageNoHandler,
		// Token: 0x0400A883 RID: 43139
		[OriginalName("EncryptionNoCreate")]
		EncryptionNoCreate,
		// Token: 0x0400A884 RID: 43140
		[OriginalName("DecryptFail")]
		DecryptFail,
		// Token: 0x0400A885 RID: 43141
		[OriginalName("PlayerNotInTheScene")]
		PlayerNotInTheScene,
		// Token: 0x0400A886 RID: 43142
		[OriginalName("NonReentrantExceptionCode")]
		NonReentrantExceptionCode,
		// Token: 0x0400A887 RID: 43143
		[OriginalName("PlayerLoggedOut")]
		PlayerLoggedOut,
		// Token: 0x0400A888 RID: 43144
		[OriginalName("MsgFunctionClose")]
		MsgFunctionClose,
		// Token: 0x0400A889 RID: 43145
		[OriginalName("SeqNoError")]
		SeqNoError,
		// Token: 0x0400A88A RID: 43146
		[OriginalName("InvalidMessageType")]
		InvalidMessageType,
		// Token: 0x0400A88B RID: 43147
		[OriginalName("InvalidMessageHeader")]
		InvalidMessageHeader,
		// Token: 0x0400A88C RID: 43148
		[OriginalName("InvalidSeqNo")]
		InvalidSeqNo,
		// Token: 0x0400A88D RID: 43149
		[OriginalName("InvalidMessageId")]
		InvalidMessageId,
		// Token: 0x0400A88E RID: 43150
		[OriginalName("ProtobufDecodeFailed")]
		ProtobufDecodeFailed,
		// Token: 0x0400A88F RID: 43151
		[OriginalName("ErrProtoSeedCheck")]
		ErrProtoSeedCheck,
		// Token: 0x0400A890 RID: 43152
		[OriginalName("MessageCouldNotBeRouted")]
		MessageCouldNotBeRouted,
		// Token: 0x0400A891 RID: 43153
		[OriginalName("ErrPlayerLogined")]
		ErrPlayerLogined,
		// Token: 0x0400A892 RID: 43154
		[OriginalName("ClosedRegister")]
		ClosedRegister = 100000,
		// Token: 0x0400A893 RID: 43155
		[OriginalName("RegisterOutOfLimit")]
		RegisterOutOfLimit,
		// Token: 0x0400A894 RID: 43156
		[OriginalName("HaveNoCharacter")]
		HaveNoCharacter,
		// Token: 0x0400A895 RID: 43157
		[OriginalName("InvalidCharacterName")]
		InvalidCharacterName,
		// Token: 0x0400A896 RID: 43158
		[OriginalName("CreateCharacterFailed")]
		CreateCharacterFailed,
		// Token: 0x0400A897 RID: 43159
		[OriginalName("CreateCharacterDuplicateKey")]
		CreateCharacterDuplicateKey,
		// Token: 0x0400A898 RID: 43160
		[OriginalName("PlayerAlreadyLogin")]
		PlayerAlreadyLogin,
		// Token: 0x0400A899 RID: 43161
		[OriginalName("PlayerLoggingIn")]
		PlayerLoggingIn,
		// Token: 0x0400A89A RID: 43162
		[OriginalName("ErrLoginGWReconnecting")]
		ErrLoginGwreconnecting,
		// Token: 0x0400A89B RID: 43163
		[OriginalName("LoginRetry")]
		LoginRetry,
		// Token: 0x0400A89C RID: 43164
		[OriginalName("QueryPlayerDataFailed")]
		QueryPlayerDataFailed,
		// Token: 0x0400A89D RID: 43165
		[OriginalName("CheckPlayerDataFailed")]
		CheckPlayerDataFailed,
		// Token: 0x0400A89E RID: 43166
		[OriginalName("CheckPlayerDataFailedDebug")]
		CheckPlayerDataFailedDebug,
		// Token: 0x0400A89F RID: 43167
		[OriginalName("LogoutUnknownError")]
		LogoutUnknownError,
		// Token: 0x0400A8A0 RID: 43168
		[OriginalName("AccountLoggedInElsewhere")]
		AccountLoggedInElsewhere,
		// Token: 0x0400A8A1 RID: 43169
		[OriginalName("AccountIsBlocked")]
		AccountIsBlocked,
		// Token: 0x0400A8A2 RID: 43170
		[OriginalName("DataOverflow")]
		DataOverflow,
		// Token: 0x0400A8A3 RID: 43171
		[OriginalName("AccountBeKick")]
		AccountBeKick,
		// Token: 0x0400A8A4 RID: 43172
		[OriginalName("AppVersionNotMatch")]
		AppVersionNotMatch,
		// Token: 0x0400A8A5 RID: 43173
		[OriginalName("LauncherVersionIsTooLow")]
		LauncherVersionIsTooLow,
		// Token: 0x0400A8A6 RID: 43174
		[OriginalName("ResourceVersionIsTooLow")]
		ResourceVersionIsTooLow,
		// Token: 0x0400A8A7 RID: 43175
		[OriginalName("CloseConnection")]
		CloseConnection,
		// Token: 0x0400A8A8 RID: 43176
		[OriginalName("ErrAcquirePlayerLockFailed")]
		ErrAcquirePlayerLockFailed,
		// Token: 0x0400A8A9 RID: 43177
		[OriginalName("ErrPlayerLoggingOut")]
		ErrPlayerLoggingOut,
		// Token: 0x0400A8AA RID: 43178
		[OriginalName("MessageChecksumFailed")]
		MessageChecksumFailed,
		// Token: 0x0400A8AB RID: 43179
		[OriginalName("LoginTimeout")]
		LoginTimeout,
		// Token: 0x0400A8AC RID: 43180
		[OriginalName("ErrWeaponDefault")]
		ErrWeaponDefault = 200000,
		// Token: 0x0400A8AD RID: 43181
		[OriginalName("ErrWeaponLevelLimit")]
		ErrWeaponLevelLimit,
		// Token: 0x0400A8AE RID: 43182
		[OriginalName("ErrWeaponBreachLimit")]
		ErrWeaponBreachLimit,
		// Token: 0x0400A8AF RID: 43183
		[OriginalName("ErrWeaponConsumeInvalid")]
		ErrWeaponConsumeInvalid,
		// Token: 0x0400A8B0 RID: 43184
		[OriginalName("ErrWeaponPkgFull")]
		ErrWeaponPkgFull,
		// Token: 0x0400A8B1 RID: 43185
		[OriginalName("ErrRoleNoConfig")]
		ErrRoleNoConfig,
		// Token: 0x0400A8B2 RID: 43186
		[OriginalName("ErrRoleIsActive")]
		ErrRoleIsActive,
		// Token: 0x0400A8B3 RID: 43187
		[OriginalName("ErrRoleNotActive")]
		ErrRoleNotActive,
		// Token: 0x0400A8B4 RID: 43188
		[OriginalName("ErrRoleOverNotEnough")]
		ErrRoleOverNotEnough,
		// Token: 0x0400A8B5 RID: 43189
		[OriginalName("ErrRoleLevelNotEnough")]
		ErrRoleLevelNotEnough,
		// Token: 0x0400A8B6 RID: 43190
		[OriginalName("ErrRoleException")]
		ErrRoleException,
		// Token: 0x0400A8B7 RID: 43191
		[OriginalName("ErrRoleNotExchange")]
		ErrRoleNotExchange,
		// Token: 0x0400A8B8 RID: 43192
		[OriginalName("ErrRoleResonNotActive")]
		ErrRoleResonNotActive,
		// Token: 0x0400A8B9 RID: 43193
		[OriginalName("ErrRoleResonIsActive")]
		ErrRoleResonIsActive,
		// Token: 0x0400A8BA RID: 43194
		[OriginalName("ErrRoleConfigNotRight")]
		ErrRoleConfigNotRight,
		// Token: 0x0400A8BB RID: 43195
		[OriginalName("ErrRoleLevelMax")]
		ErrRoleLevelMax,
		// Token: 0x0400A8BC RID: 43196
		[OriginalName("ErrRolePerResonNotActive")]
		ErrRolePerResonNotActive,
		// Token: 0x0400A8BD RID: 43197
		[OriginalName("ErrRoleConditionNotFind")]
		ErrRoleConditionNotFind,
		// Token: 0x0400A8BE RID: 43198
		[OriginalName("ErrRoleConditionNoEnough")]
		ErrRoleConditionNoEnough,
		// Token: 0x0400A8BF RID: 43199
		[OriginalName("ErrRoleInvalidNameLength")]
		ErrRoleInvalidNameLength,
		// Token: 0x0400A8C0 RID: 43200
		[OriginalName("ErrRoleExpInvalid")]
		ErrRoleExpInvalid,
		// Token: 0x0400A8C1 RID: 43201
		[OriginalName("ErrRoleActiveNeedNoEnough")]
		ErrRoleActiveNeedNoEnough,
		// Token: 0x0400A8C2 RID: 43202
		[OriginalName("ErrRoleResonMaxLevel")]
		ErrRoleResonMaxLevel,
		// Token: 0x0400A8C3 RID: 43203
		[OriginalName("ErrRoleProtoError")]
		ErrRoleProtoError,
		// Token: 0x0400A8C4 RID: 43204
		[OriginalName("ErrRoleItemListEmpty")]
		ErrRoleItemListEmpty,
		// Token: 0x0400A8C5 RID: 43205
		[OriginalName("ErrRoleItemListCountOutRange")]
		ErrRoleItemListCountOutRange,
		// Token: 0x0400A8C6 RID: 43206
		[OriginalName("ErrRoleItemExpError")]
		ErrRoleItemExpError,
		// Token: 0x0400A8C7 RID: 43207
		[OriginalName("ErrRolePhantPosError")]
		ErrRolePhantPosError,
		// Token: 0x0400A8C8 RID: 43208
		[OriginalName("ErrRolePhantSameError")]
		ErrRolePhantSameError,
		// Token: 0x0400A8C9 RID: 43209
		[OriginalName("ErrRolePhantEmptyError")]
		ErrRolePhantEmptyError,
		// Token: 0x0400A8CA RID: 43210
		[OriginalName("ErrRoleItemListNoEnough")]
		ErrRoleItemListNoEnough,
		// Token: 0x0400A8CB RID: 43211
		[OriginalName("ErrRoleGetSkillByIdFailed")]
		ErrRoleGetSkillByIdFailed,
		// Token: 0x0400A8CC RID: 43212
		[OriginalName("ErrRoleFavorLevelNotEnough")]
		ErrRoleFavorLevelNotEnough,
		// Token: 0x0400A8CD RID: 43213
		[OriginalName("ErrRolSkillNodeType")]
		ErrRolSkillNodeType,
		// Token: 0x0400A8CE RID: 43214
		[OriginalName("ErrRolSkillNodeTypeActive")]
		ErrRolSkillNodeTypeActive,
		// Token: 0x0400A8CF RID: 43215
		[OriginalName("ErrRolSkillNodeTypeUlock")]
		ErrRolSkillNodeTypeUlock,
		// Token: 0x0400A8D0 RID: 43216
		[OriginalName("ErrRolSkillPointsNotEnough")]
		ErrRolSkillPointsNotEnough,
		// Token: 0x0400A8D1 RID: 43217
		[OriginalName("ErrTrialRoleExist")]
		ErrTrialRoleExist,
		// Token: 0x0400A8D2 RID: 43218
		[OriginalName("ErrTrialRoleNotExist")]
		ErrTrialRoleNotExist,
		// Token: 0x0400A8D3 RID: 43219
		[OriginalName("ErrTrialRoleRegionDataExist")]
		ErrTrialRoleRegionDataExist,
		// Token: 0x0400A8D4 RID: 43220
		[OriginalName("ErrTrialRoleBtObjDataExist")]
		ErrTrialRoleBtObjDataExist,
		// Token: 0x0400A8D5 RID: 43221
		[OriginalName("ErrTrialRoleRegionExist")]
		ErrTrialRoleRegionExist,
		// Token: 0x0400A8D6 RID: 43222
		[OriginalName("ErrTrialRoleRegionNotExist")]
		ErrTrialRoleRegionNotExist,
		// Token: 0x0400A8D7 RID: 43223
		[OriginalName("ErrLoadEquipDefault")]
		ErrLoadEquipDefault,
		// Token: 0x0400A8D8 RID: 43224
		[OriginalName("ErrLoadEquipInvalidPos")]
		ErrLoadEquipInvalidPos,
		// Token: 0x0400A8D9 RID: 43225
		[OriginalName("ErrLoadEquipInvalidRole")]
		ErrLoadEquipInvalidRole,
		// Token: 0x0400A8DA RID: 43226
		[OriginalName("ErrLoadEquipRoleConfig")]
		ErrLoadEquipRoleConfig,
		// Token: 0x0400A8DB RID: 43227
		[OriginalName("ErrPhantomIdNotExist")]
		ErrPhantomIdNotExist,
		// Token: 0x0400A8DC RID: 43228
		[OriginalName("ErrPhantomNotExist")]
		ErrPhantomNotExist,
		// Token: 0x0400A8DD RID: 43229
		[OriginalName("ErrPhantomLvupMax")]
		ErrPhantomLvupMax,
		// Token: 0x0400A8DE RID: 43230
		[OriginalName("ErrPhantomLvupMismatchItemId")]
		ErrPhantomLvupMismatchItemId,
		// Token: 0x0400A8DF RID: 43231
		[OriginalName("ErrPhantomLvupNoItem")]
		ErrPhantomLvupNoItem,
		// Token: 0x0400A8E0 RID: 43232
		[OriginalName("ErrPhantomLvupLimit")]
		ErrPhantomLvupLimit,
		// Token: 0x0400A8E1 RID: 43233
		[OriginalName("ErrPhantomItemType")]
		ErrPhantomItemType,
		// Token: 0x0400A8E2 RID: 43234
		[OriginalName("ErrPhantomInvalidPos")]
		ErrPhantomInvalidPos,
		// Token: 0x0400A8E3 RID: 43235
		[OriginalName("ErrPhantomConfigNotFound")]
		ErrPhantomConfigNotFound,
		// Token: 0x0400A8E4 RID: 43236
		[OriginalName("ErrPhantomItemNotExist")]
		ErrPhantomItemNotExist,
		// Token: 0x0400A8E5 RID: 43237
		[OriginalName("ErrPhantomPropNotExist")]
		ErrPhantomPropNotExist,
		// Token: 0x0400A8E6 RID: 43238
		[OriginalName("ErrPhantomQaulityNotExist")]
		ErrPhantomQaulityNotExist,
		// Token: 0x0400A8E7 RID: 43239
		[OriginalName("ErrPhantomBreachNotExist")]
		ErrPhantomBreachNotExist,
		// Token: 0x0400A8E8 RID: 43240
		[OriginalName("ErrPhantomLevelNotEnough")]
		ErrPhantomLevelNotEnough,
		// Token: 0x0400A8E9 RID: 43241
		[OriginalName("ErrPhantomExpItemNotExist")]
		ErrPhantomExpItemNotExist,
		// Token: 0x0400A8EA RID: 43242
		[OriginalName("ErrPhantomSubPropRandomErr")]
		ErrPhantomSubPropRandomErr,
		// Token: 0x0400A8EB RID: 43243
		[OriginalName("ErrPhantomSubPropNotEnough")]
		ErrPhantomSubPropNotEnough,
		// Token: 0x0400A8EC RID: 43244
		[OriginalName("ErrPhantomSubPropGenDupicate")]
		ErrPhantomSubPropGenDupicate,
		// Token: 0x0400A8ED RID: 43245
		[OriginalName("ErrPhantomSubStrengthenPropNotExist")]
		ErrPhantomSubStrengthenPropNotExist,
		// Token: 0x0400A8EE RID: 43246
		[OriginalName("ErrPhantomLevelConfigNotExist")]
		ErrPhantomLevelConfigNotExist,
		// Token: 0x0400A8EF RID: 43247
		[OriginalName("ErrPhantomLevelUpConsumeItemNotEnough")]
		ErrPhantomLevelUpConsumeItemNotEnough,
		// Token: 0x0400A8F0 RID: 43248
		[OriginalName("ErrPhantomLevelUpMaterialLock")]
		ErrPhantomLevelUpMaterialLock,
		// Token: 0x0400A8F1 RID: 43249
		[OriginalName("ErrPhantomLevelUpConsumeItemErr")]
		ErrPhantomLevelUpConsumeItemErr,
		// Token: 0x0400A8F2 RID: 43250
		[OriginalName("ErrPhantomLevelUpRepeatItem")]
		ErrPhantomLevelUpRepeatItem,
		// Token: 0x0400A8F3 RID: 43251
		[OriginalName("ErrPhantomMainPropNotExist")]
		ErrPhantomMainPropNotExist,
		// Token: 0x0400A8F4 RID: 43252
		[OriginalName("ErrPhantomGrowthNotExist")]
		ErrPhantomGrowthNotExist,
		// Token: 0x0400A8F5 RID: 43253
		[OriginalName("ErrPhantomBreachItemCount")]
		ErrPhantomBreachItemCount,
		// Token: 0x0400A8F6 RID: 43254
		[OriginalName("ErrPhantomBreachRepeatItem")]
		ErrPhantomBreachRepeatItem,
		// Token: 0x0400A8F7 RID: 43255
		[OriginalName("ErrPhantomDecomposeEquiped")]
		ErrPhantomDecomposeEquiped,
		// Token: 0x0400A8F8 RID: 43256
		[OriginalName("ErrPhantomDecomposeFail")]
		ErrPhantomDecomposeFail,
		// Token: 0x0400A8F9 RID: 43257
		[OriginalName("ErrPhantomBreachBindItem")]
		ErrPhantomBreachBindItem,
		// Token: 0x0400A8FA RID: 43258
		[OriginalName("ErrPhantomBreachErrItem")]
		ErrPhantomBreachErrItem,
		// Token: 0x0400A8FB RID: 43259
		[OriginalName("ErrPhantomRecommendNoData")]
		ErrPhantomRecommendNoData,
		// Token: 0x0400A8FC RID: 43260
		[OriginalName("ErrPhantomCannotTakeOff")]
		ErrPhantomCannotTakeOff,
		// Token: 0x0400A8FD RID: 43261
		[OriginalName("ErrPhantomCannotReplace")]
		ErrPhantomCannotReplace,
		// Token: 0x0400A8FE RID: 43262
		[OriginalName("ErrVisionSkillFavoriteTypeLimit")]
		ErrVisionSkillFavoriteTypeLimit,
		// Token: 0x0400A8FF RID: 43263
		[OriginalName("ErrVisionSkillFavoriteCountLimit")]
		ErrVisionSkillFavoriteCountLimit,
		// Token: 0x0400A900 RID: 43264
		[OriginalName("ErrVisionSkillCfgNotFound")]
		ErrVisionSkillCfgNotFound,
		// Token: 0x0400A901 RID: 43265
		[OriginalName("ErrVisionSkillNotFound")]
		ErrVisionSkillNotFound,
		// Token: 0x0400A902 RID: 43266
		[OriginalName("ErrVisionSkillLevelUpMax")]
		ErrVisionSkillLevelUpMax,
		// Token: 0x0400A903 RID: 43267
		[OriginalName("ErrVisionSkillLevelUpLimit")]
		ErrVisionSkillLevelUpLimit,
		// Token: 0x0400A904 RID: 43268
		[OriginalName("ErrVisionSkillSlotNotFound")]
		ErrVisionSkillSlotNotFound,
		// Token: 0x0400A905 RID: 43269
		[OriginalName("ErrVisionSkillEquipTypeLimit")]
		ErrVisionSkillEquipTypeLimit,
		// Token: 0x0400A906 RID: 43270
		[OriginalName("ErrVisionSkillUnEquipLimit")]
		ErrVisionSkillUnEquipLimit,
		// Token: 0x0400A907 RID: 43271
		[OriginalName("ErrVisionSkillGemCfgNotFound")]
		ErrVisionSkillGemCfgNotFound,
		// Token: 0x0400A908 RID: 43272
		[OriginalName("ErrVisionSkillEquipLimit")]
		ErrVisionSkillEquipLimit,
		// Token: 0x0400A909 RID: 43273
		[OriginalName("ErrVisionSkillGemLimit")]
		ErrVisionSkillGemLimit,
		// Token: 0x0400A90A RID: 43274
		[OriginalName("ErrVisionSkillOperFail")]
		ErrVisionSkillOperFail,
		// Token: 0x0400A90B RID: 43275
		[OriginalName("ErrVisionSkillSlotEquipLimit")]
		ErrVisionSkillSlotEquipLimit,
		// Token: 0x0400A90C RID: 43276
		[OriginalName("ErrExploreSkillRouletteRepeat")]
		ErrExploreSkillRouletteRepeat,
		// Token: 0x0400A90D RID: 43277
		[OriginalName("ErrItemCfgNotFound")]
		ErrItemCfgNotFound,
		// Token: 0x0400A90E RID: 43278
		[OriginalName("ErrItemNotFound")]
		ErrItemNotFound,
		// Token: 0x0400A90F RID: 43279
		[OriginalName("ErrItemNotEnough")]
		ErrItemNotEnough,
		// Token: 0x0400A910 RID: 43280
		[OriginalName("ErrItemDecomposeLimit")]
		ErrItemDecomposeLimit,
		// Token: 0x0400A911 RID: 43281
		[OriginalName("ErrItemUseLevelLimit")]
		ErrItemUseLevelLimit,
		// Token: 0x0400A912 RID: 43282
		[OriginalName("ErrItemLockLimit")]
		ErrItemLockLimit,
		// Token: 0x0400A913 RID: 43283
		[OriginalName("ErrItemInvalidParams")]
		ErrItemInvalidParams,
		// Token: 0x0400A914 RID: 43284
		[OriginalName("ErrItemDecomposeFail")]
		ErrItemDecomposeFail,
		// Token: 0x0400A915 RID: 43285
		[OriginalName("ErrItemUseFail")]
		ErrItemUseFail,
		// Token: 0x0400A916 RID: 43286
		[OriginalName("ErrExchangeRewardCostItemNotEnough")]
		ErrExchangeRewardCostItemNotEnough,
		// Token: 0x0400A917 RID: 43287
		[OriginalName("ExchangeRewardSuccess")]
		ExchangeRewardSuccess,
		// Token: 0x0400A918 RID: 43288
		[OriginalName("ErrPkgCapacityNotEnough")]
		ErrPkgCapacityNotEnough,
		// Token: 0x0400A919 RID: 43289
		[OriginalName("ErrGiftOptionalCount")]
		ErrGiftOptionalCount,
		// Token: 0x0400A91A RID: 43290
		[OriginalName("ErrGiftOptionalNotExists")]
		ErrGiftOptionalNotExists,
		// Token: 0x0400A91B RID: 43291
		[OriginalName("ErrGiftNotExists")]
		ErrGiftNotExists,
		// Token: 0x0400A91C RID: 43292
		[OriginalName("ErrItemCount")]
		ErrItemCount,
		// Token: 0x0400A91D RID: 43293
		[OriginalName("ErrItemIdNotContain")]
		ErrItemIdNotContain,
		// Token: 0x0400A91E RID: 43294
		[OriginalName("ErrItemTypeNotContain")]
		ErrItemTypeNotContain,
		// Token: 0x0400A91F RID: 43295
		[OriginalName("ErrCalabashMaxLevel")]
		ErrCalabashMaxLevel,
		// Token: 0x0400A920 RID: 43296
		[OriginalName("ErrCalabashConfig")]
		ErrCalabashConfig,
		// Token: 0x0400A921 RID: 43297
		[OriginalName("ErrCalabashLevelUp")]
		ErrCalabashLevelUp,
		// Token: 0x0400A922 RID: 43298
		[OriginalName("ErrCalabashExp")]
		ErrCalabashExp,
		// Token: 0x0400A923 RID: 43299
		[OriginalName("ErrCalabashDevelopNoReward")]
		ErrCalabashDevelopNoReward,
		// Token: 0x0400A924 RID: 43300
		[OriginalName("ErrCalabashMonsterNotFound")]
		ErrCalabashMonsterNotFound,
		// Token: 0x0400A925 RID: 43301
		[OriginalName("PropRewardTips")]
		PropRewardTips,
		// Token: 0x0400A926 RID: 43302
		[OriginalName("ErrEnergyMaxCharge")]
		ErrEnergyMaxCharge,
		// Token: 0x0400A927 RID: 43303
		[OriginalName("ErrStateCanotTeleport")]
		ErrStateCanotTeleport,
		// Token: 0x0400A928 RID: 43304
		[OriginalName("ErrStateCannotEnterInst")]
		ErrStateCannotEnterInst,
		// Token: 0x0400A929 RID: 43305
		[OriginalName("ErrStateCannotOnline")]
		ErrStateCannotOnline,
		// Token: 0x0400A92A RID: 43306
		[OriginalName("ErrStateCannotChangeFormation")]
		ErrStateCannotChangeFormation,
		// Token: 0x0400A92B RID: 43307
		[OriginalName("ErrReportPlayerCountLimit")]
		ErrReportPlayerCountLimit,
		// Token: 0x0400A92C RID: 43308
		[OriginalName("ErrReportPlayerReasonNotFound")]
		ErrReportPlayerReasonNotFound,
		// Token: 0x0400A92D RID: 43309
		[OriginalName("ErrReportMessageLengthLimit")]
		ErrReportMessageLengthLimit,
		// Token: 0x0400A92E RID: 43310
		[OriginalName("ErrCookingToolFixed")]
		ErrCookingToolFixed,
		// Token: 0x0400A92F RID: 43311
		[OriginalName("ErrCookingFormulaNotFound")]
		ErrCookingFormulaNotFound,
		// Token: 0x0400A930 RID: 43312
		[OriginalName("ErrCookingCount")]
		ErrCookingCount,
		// Token: 0x0400A931 RID: 43313
		[OriginalName("ErrCookingProcessNotFound")]
		ErrCookingProcessNotFound,
		// Token: 0x0400A932 RID: 43314
		[OriginalName("ErrCookingLevelNotFound")]
		ErrCookingLevelNotFound,
		// Token: 0x0400A933 RID: 43315
		[OriginalName("ErrCookingLevelLimt")]
		ErrCookingLevelLimt,
		// Token: 0x0400A934 RID: 43316
		[OriginalName("ErrCookingInteractiveNotFound")]
		ErrCookingInteractiveNotFound,
		// Token: 0x0400A935 RID: 43317
		[OriginalName("ErrCookingFuncNotOpen")]
		ErrCookingFuncNotOpen,
		// Token: 0x0400A936 RID: 43318
		[OriginalName("ErrChallengeNotFound")]
		ErrChallengeNotFound,
		// Token: 0x0400A937 RID: 43319
		[OriginalName("ErrChallengeNoTeam")]
		ErrChallengeNoTeam,
		// Token: 0x0400A938 RID: 43320
		[OriginalName("ErrChallengeTeamLimit")]
		ErrChallengeTeamLimit,
		// Token: 0x0400A939 RID: 43321
		[OriginalName("ErrChallengeTeamMemLimit")]
		ErrChallengeTeamMemLimit,
		// Token: 0x0400A93A RID: 43322
		[OriginalName("ErrChallengeChangeFormation")]
		ErrChallengeChangeFormation,
		// Token: 0x0400A93B RID: 43323
		[OriginalName("ErrChallengeFunNotOpen")]
		ErrChallengeFunNotOpen,
		// Token: 0x0400A93C RID: 43324
		[OriginalName("ErrChallengeSeasonUpdate")]
		ErrChallengeSeasonUpdate,
		// Token: 0x0400A93D RID: 43325
		[OriginalName("ErrChallengeLockRoleLimit")]
		ErrChallengeLockRoleLimit,
		// Token: 0x0400A93E RID: 43326
		[OriginalName("ErrChallengeRoleLocked")]
		ErrChallengeRoleLocked,
		// Token: 0x0400A93F RID: 43327
		[OriginalName("ErrChallengeNoRoleAlive")]
		ErrChallengeNoRoleAlive,
		// Token: 0x0400A940 RID: 43328
		[OriginalName("ErrChallengeFormationEmpty")]
		ErrChallengeFormationEmpty,
		// Token: 0x0400A941 RID: 43329
		[OriginalName("ErrCycleChallengeNoRoleAlive")]
		ErrCycleChallengeNoRoleAlive,
		// Token: 0x0400A942 RID: 43330
		[OriginalName("ErrCycleChallengeFormationEmpty")]
		ErrCycleChallengeFormationEmpty,
		// Token: 0x0400A943 RID: 43331
		[OriginalName("ErrInfluenceLocked")]
		ErrInfluenceLocked,
		// Token: 0x0400A944 RID: 43332
		[OriginalName("ErrInfluenceRewardNotFound")]
		ErrInfluenceRewardNotFound,
		// Token: 0x0400A945 RID: 43333
		[OriginalName("ErrInfluenceConfigNotFound")]
		ErrInfluenceConfigNotFound,
		// Token: 0x0400A946 RID: 43334
		[OriginalName("ErrReputationLimit")]
		ErrReputationLimit,
		// Token: 0x0400A947 RID: 43335
		[OriginalName("ErrInfluenceRewardFailed")]
		ErrInfluenceRewardFailed,
		// Token: 0x0400A948 RID: 43336
		[OriginalName("ErrInfluenceFunNotOpen")]
		ErrInfluenceFunNotOpen,
		// Token: 0x0400A949 RID: 43337
		[OriginalName("ErrForgeFuncNotOpen")]
		ErrForgeFuncNotOpen,
		// Token: 0x0400A94A RID: 43338
		[OriginalName("ErrForgeCountLimit")]
		ErrForgeCountLimit,
		// Token: 0x0400A94B RID: 43339
		[OriginalName("ErrForgeLocked")]
		ErrForgeLocked,
		// Token: 0x0400A94C RID: 43340
		[OriginalName("ErrForgeConfigNotFound")]
		ErrForgeConfigNotFound,
		// Token: 0x0400A94D RID: 43341
		[OriginalName("ErrForgeUnlocked")]
		ErrForgeUnlocked,
		// Token: 0x0400A94E RID: 43342
		[OriginalName("ErrSynthesisFuncNotOpen")]
		ErrSynthesisFuncNotOpen,
		// Token: 0x0400A94F RID: 43343
		[OriginalName("ErrSynthesisConfigNotFound")]
		ErrSynthesisConfigNotFound,
		// Token: 0x0400A950 RID: 43344
		[OriginalName("ErrSynthesisCountLimit")]
		ErrSynthesisCountLimit,
		// Token: 0x0400A951 RID: 43345
		[OriginalName("ErrSynthesisLocked")]
		ErrSynthesisLocked,
		// Token: 0x0400A952 RID: 43346
		[OriginalName("ErrSynthesisLevelNotFound")]
		ErrSynthesisLevelNotFound,
		// Token: 0x0400A953 RID: 43347
		[OriginalName("ErrSynthesisLevelLimit")]
		ErrSynthesisLevelLimit,
		// Token: 0x0400A954 RID: 43348
		[OriginalName("ErrSynthesisCannotUnlock")]
		ErrSynthesisCannotUnlock,
		// Token: 0x0400A955 RID: 43349
		[OriginalName("ErrSynthesisUnlocked")]
		ErrSynthesisUnlocked,
		// Token: 0x0400A956 RID: 43350
		[OriginalName("ErrTrialRoleCannotMatch")]
		ErrTrialRoleCannotMatch,
		// Token: 0x0400A957 RID: 43351
		[OriginalName("ErrPhantomFormationTeleport")]
		ErrPhantomFormationTeleport,
		// Token: 0x0400A958 RID: 43352
		[OriginalName("ErrPhantomFormationEnterInst")]
		ErrPhantomFormationEnterInst,
		// Token: 0x0400A959 RID: 43353
		[OriginalName("ErrPhantomFormationMultiPlay")]
		ErrPhantomFormationMultiPlay,
		// Token: 0x0400A95A RID: 43354
		[OriginalName("ErrPhantomFormationAdvice")]
		ErrPhantomFormationAdvice,
		// Token: 0x0400A95B RID: 43355
		[OriginalName("ErrPhantomFormationChangeFormation")]
		ErrPhantomFormationChangeFormation,
		// Token: 0x0400A95C RID: 43356
		[OriginalName("ErrPhantomFormationRepeat")]
		ErrPhantomFormationRepeat,
		// Token: 0x0400A95D RID: 43357
		[OriginalName("ErrPhantomFormationChangeFailed")]
		ErrPhantomFormationChangeFailed,
		// Token: 0x0400A95E RID: 43358
		[OriginalName("ErrRoleChangeRoleCreateFailed")]
		ErrRoleChangeRoleCreateFailed,
		// Token: 0x0400A95F RID: 43359
		[OriginalName("ErrRoleChangeRoleUpdateCreateFailed")]
		ErrRoleChangeRoleUpdateCreateFailed,
		// Token: 0x0400A960 RID: 43360
		[OriginalName("ErrRoleChangeRoleNotUnlock")]
		ErrRoleChangeRoleNotUnlock,
		// Token: 0x0400A961 RID: 43361
		[OriginalName("ErrRoleChangeMultiPlay")]
		ErrRoleChangeMultiPlay,
		// Token: 0x0400A962 RID: 43362
		[OriginalName("ErrRoleChangeInst")]
		ErrRoleChangeInst,
		// Token: 0x0400A963 RID: 43363
		[OriginalName("ErrRoleChangeElementFunc")]
		ErrRoleChangeElementFunc,
		// Token: 0x0400A964 RID: 43364
		[OriginalName("ErrPhantomFormationCannotJoin")]
		ErrPhantomFormationCannotJoin,
		// Token: 0x0400A965 RID: 43365
		[OriginalName("ErrPhantomFormationHost")]
		ErrPhantomFormationHost,
		// Token: 0x0400A966 RID: 43366
		[OriginalName("ErrRoleChangeShowAllRole")]
		ErrRoleChangeShowAllRole,
		// Token: 0x0400A967 RID: 43367
		[OriginalName("ErrInteractBoardEntityNotFound")]
		ErrInteractBoardEntityNotFound,
		// Token: 0x0400A968 RID: 43368
		[OriginalName("ErrInteractBoardRange")]
		ErrInteractBoardRange,
		// Token: 0x0400A969 RID: 43369
		[OriginalName("ErrInteractBoardSystemNotFound")]
		ErrInteractBoardSystemNotFound,
		// Token: 0x0400A96A RID: 43370
		[OriginalName("ErrInteractBoardEntityConfig")]
		ErrInteractBoardEntityConfig,
		// Token: 0x0400A96B RID: 43371
		[OriginalName("ErrInteractEntranceNotFound")]
		ErrInteractEntranceNotFound,
		// Token: 0x0400A96C RID: 43372
		[OriginalName("ErrInteractEntranceNotMatch")]
		ErrInteractEntranceNotMatch,
		// Token: 0x0400A96D RID: 43373
		[OriginalName("ErrItemMaxUseCount")]
		ErrItemMaxUseCount,
		// Token: 0x0400A96E RID: 43374
		[OriginalName("ErrFuncNotExist")]
		ErrFuncNotExist,
		// Token: 0x0400A96F RID: 43375
		[OriginalName("ErrPhantomChangeInBattle")]
		ErrPhantomChangeInBattle,
		// Token: 0x0400A970 RID: 43376
		[OriginalName("ErrItemCanNotDestroy")]
		ErrItemCanNotDestroy,
		// Token: 0x0400A971 RID: 43377
		[OriginalName("ErrPhantomEquipSourceCost")]
		ErrPhantomEquipSourceCost,
		// Token: 0x0400A972 RID: 43378
		[OriginalName("ErrPhantomEquipTargetCost")]
		ErrPhantomEquipTargetCost,
		// Token: 0x0400A973 RID: 43379
		[OriginalName("ErrPhantomEquipDuplicate")]
		ErrPhantomEquipDuplicate,
		// Token: 0x0400A974 RID: 43380
		[OriginalName("ErrPhantomAutoEquipFromOther")]
		ErrPhantomAutoEquipFromOther,
		// Token: 0x0400A975 RID: 43381
		[OriginalName("ErrPhantomConsumeItemCount")]
		ErrPhantomConsumeItemCount,
		// Token: 0x0400A976 RID: 43382
		[OriginalName("ErrPhantomConsumeItemDuplicate")]
		ErrPhantomConsumeItemDuplicate,
		// Token: 0x0400A977 RID: 43383
		[OriginalName("ErrPhantomConsumeItemIncrDuplicate")]
		ErrPhantomConsumeItemIncrDuplicate,
		// Token: 0x0400A978 RID: 43384
		[OriginalName("ErrPhantomConsumeItem")]
		ErrPhantomConsumeItem,
		// Token: 0x0400A979 RID: 43385
		[OriginalName("ErrPhantomConsumeNoExp")]
		ErrPhantomConsumeNoExp,
		// Token: 0x0400A97A RID: 43386
		[OriginalName("ErrPhantomBreachPos")]
		ErrPhantomBreachPos,
		// Token: 0x0400A97B RID: 43387
		[OriginalName("ErrPhantomBreachSuspend")]
		ErrPhantomBreachSuspend,
		// Token: 0x0400A97C RID: 43388
		[OriginalName("ErrPhantomBreachQuality")]
		ErrPhantomBreachQuality,
		// Token: 0x0400A97D RID: 43389
		[OriginalName("ErrPhantomBreachExp")]
		ErrPhantomBreachExp,
		// Token: 0x0400A97E RID: 43390
		[OriginalName("ErrPhantomBreachConsumeItem")]
		ErrPhantomBreachConsumeItem,
		// Token: 0x0400A97F RID: 43391
		[OriginalName("ErrPhantomBreachNoSuspend")]
		ErrPhantomBreachNoSuspend,
		// Token: 0x0400A980 RID: 43392
		[OriginalName("ErrPhantomSpecialSkillRole")]
		ErrPhantomSpecialSkillRole,
		// Token: 0x0400A981 RID: 43393
		[OriginalName("ErrPhantomNotEquip")]
		ErrPhantomNotEquip,
		// Token: 0x0400A982 RID: 43394
		[OriginalName("ErrPhantomSpecilSkillPos")]
		ErrPhantomSpecilSkillPos,
		// Token: 0x0400A983 RID: 43395
		[OriginalName("ErrPhantomSubPropPlanConfig")]
		ErrPhantomSubPropPlanConfig,
		// Token: 0x0400A984 RID: 43396
		[OriginalName("ErrPhantomMainPropGenFail")]
		ErrPhantomMainPropGenFail,
		// Token: 0x0400A985 RID: 43397
		[OriginalName("ErrLivenessFuncNotOpen")]
		ErrLivenessFuncNotOpen,
		// Token: 0x0400A986 RID: 43398
		[OriginalName("ErrLivenessTaskNotFound")]
		ErrLivenessTaskNotFound,
		// Token: 0x0400A987 RID: 43399
		[OriginalName("ErrLivenessTaskDataNotFound")]
		ErrLivenessTaskDataNotFound,
		// Token: 0x0400A988 RID: 43400
		[OriginalName("ErrLivenessTaskNotFinish")]
		ErrLivenessTaskNotFinish,
		// Token: 0x0400A989 RID: 43401
		[OriginalName("ErrLivenessTaskRewarded")]
		ErrLivenessTaskRewarded,
		// Token: 0x0400A98A RID: 43402
		[OriginalName("ErrLivenessRewardNotFound")]
		ErrLivenessRewardNotFound,
		// Token: 0x0400A98B RID: 43403
		[OriginalName("ErrLivenessGoalNotReach")]
		ErrLivenessGoalNotReach,
		// Token: 0x0400A98C RID: 43404
		[OriginalName("ErrLivenessRewardParam")]
		ErrLivenessRewardParam,
		// Token: 0x0400A98D RID: 43405
		[OriginalName("ErrLivenessTaskRewardParam")]
		ErrLivenessTaskRewardParam,
		// Token: 0x0400A98E RID: 43406
		[OriginalName("ErrWeaponLevelUpComsumeCount")]
		ErrWeaponLevelUpComsumeCount,
		// Token: 0x0400A98F RID: 43407
		[OriginalName("ErrWeaponConsumeSelf")]
		ErrWeaponConsumeSelf,
		// Token: 0x0400A990 RID: 43408
		[OriginalName("ErrWeaponConsumeItemNotFound")]
		ErrWeaponConsumeItemNotFound,
		// Token: 0x0400A991 RID: 43409
		[OriginalName("ErrWeaponConsumeItemIdNotFound")]
		ErrWeaponConsumeItemIdNotFound,
		// Token: 0x0400A992 RID: 43410
		[OriginalName("ErrWeaponLocked")]
		ErrWeaponLocked,
		// Token: 0x0400A993 RID: 43411
		[OriginalName("ErrWeaponConsumeDuplicate")]
		ErrWeaponConsumeDuplicate,
		// Token: 0x0400A994 RID: 43412
		[OriginalName("ErrWeaponEquiped")]
		ErrWeaponEquiped,
		// Token: 0x0400A995 RID: 43413
		[OriginalName("ErrWeaponLevelUpItemDuplicate")]
		ErrWeaponLevelUpItemDuplicate,
		// Token: 0x0400A996 RID: 43414
		[OriginalName("ErrWeaponLevelUpNoExp")]
		ErrWeaponLevelUpNoExp,
		// Token: 0x0400A997 RID: 43415
		[OriginalName("ErrWeaponLevelUpLevel")]
		ErrWeaponLevelUpLevel,
		// Token: 0x0400A998 RID: 43416
		[OriginalName("ErrPhantomMainPropNotMatch")]
		ErrPhantomMainPropNotMatch,
		// Token: 0x0400A999 RID: 43417
		[OriginalName("ErrPhantomSubPropNotMatch")]
		ErrPhantomSubPropNotMatch,
		// Token: 0x0400A99A RID: 43418
		[OriginalName("ErrPhantomEquiped")]
		ErrPhantomEquiped,
		// Token: 0x0400A99B RID: 43419
		[OriginalName("ErrAdviceNotInit")]
		ErrAdviceNotInit,
		// Token: 0x0400A99C RID: 43420
		[OriginalName("ErrTowerChallengeNotOpen")]
		ErrTowerChallengeNotOpen,
		// Token: 0x0400A99D RID: 43421
		[OriginalName("ErrTowerNotInChallenge")]
		ErrTowerNotInChallenge,
		// Token: 0x0400A99E RID: 43422
		[OriginalName("ErrTowerConfigNotFound")]
		ErrTowerConfigNotFound,
		// Token: 0x0400A99F RID: 43423
		[OriginalName("ErrTowerChallengeNotInOpenTime")]
		ErrTowerChallengeNotInOpenTime,
		// Token: 0x0400A9A0 RID: 43424
		[OriginalName("ErrTowerInChallenge")]
		ErrTowerInChallenge,
		// Token: 0x0400A9A1 RID: 43425
		[OriginalName("ErrTowerFormationCount")]
		ErrTowerFormationCount,
		// Token: 0x0400A9A2 RID: 43426
		[OriginalName("ErrTowerFormationRoleDuplicate")]
		ErrTowerFormationRoleDuplicate,
		// Token: 0x0400A9A3 RID: 43427
		[OriginalName("ErrTowerRoleCost")]
		ErrTowerRoleCost,
		// Token: 0x0400A9A4 RID: 43428
		[OriginalName("ErrTowerDifficultyNotClear")]
		ErrTowerDifficultyNotClear,
		// Token: 0x0400A9A5 RID: 43429
		[OriginalName("ErrTowerFloorNotClear")]
		ErrTowerFloorNotClear,
		// Token: 0x0400A9A6 RID: 43430
		[OriginalName("ErrTowerAreaNotClear")]
		ErrTowerAreaNotClear,
		// Token: 0x0400A9A7 RID: 43431
		[OriginalName("ErrTowerRecommendNotSettle")]
		ErrTowerRecommendNotSettle,
		// Token: 0x0400A9A8 RID: 43432
		[OriginalName("ErrTowerRewardNotFound")]
		ErrTowerRewardNotFound,
		// Token: 0x0400A9A9 RID: 43433
		[OriginalName("ErrTowerNoReward")]
		ErrTowerNoReward,
		// Token: 0x0400A9AA RID: 43434
		[OriginalName("ErrTowerRewarded")]
		ErrTowerRewarded,
		// Token: 0x0400A9AB RID: 43435
		[OriginalName("ErrTowerRewardTarget")]
		ErrTowerRewardTarget,
		// Token: 0x0400A9AC RID: 43436
		[OriginalName("ErrTowerSeasonUpdate")]
		ErrTowerSeasonUpdate,
		// Token: 0x0400A9AD RID: 43437
		[OriginalName("ErrLordGymConfigNotFound")]
		ErrLordGymConfigNotFound,
		// Token: 0x0400A9AE RID: 43438
		[OriginalName("ErrLordGymNotInPlay")]
		ErrLordGymNotInPlay,
		// Token: 0x0400A9AF RID: 43439
		[OriginalName("ErrLordGymLock")]
		ErrLordGymLock,
		// Token: 0x0400A9B0 RID: 43440
		[OriginalName("ErrLordGymBtTreeNotFound")]
		ErrLordGymBtTreeNotFound,
		// Token: 0x0400A9B1 RID: 43441
		[OriginalName("ErrRoleSexFuncNotOpen")]
		ErrRoleSexFuncNotOpen,
		// Token: 0x0400A9B2 RID: 43442
		[OriginalName("ErrPhantomSubPropLocked")]
		ErrPhantomSubPropLocked,
		// Token: 0x0400A9B3 RID: 43443
		[OriginalName("ErrPhantomIdentifyNoCost")]
		ErrPhantomIdentifyNoCost,
		// Token: 0x0400A9B4 RID: 43444
		[OriginalName("ErrGiftPackType")]
		ErrGiftPackType,
		// Token: 0x0400A9B5 RID: 43445
		[OriginalName("ErrGiftPackUseLimit")]
		ErrGiftPackUseLimit,
		// Token: 0x0400A9B6 RID: 43446
		[OriginalName("ErrCdKeyNotEnable")]
		ErrCdKeyNotEnable,
		// Token: 0x0400A9B7 RID: 43447
		[OriginalName("ErrCdKeyRequestCount")]
		ErrCdKeyRequestCount,
		// Token: 0x0400A9B8 RID: 43448
		[OriginalName("ErrCdKeyRequestErr")]
		ErrCdKeyRequestErr,
		// Token: 0x0400A9B9 RID: 43449
		[OriginalName("ErrCdKeyRequestDataErr")]
		ErrCdKeyRequestDataErr,
		// Token: 0x0400A9BA RID: 43450
		[OriginalName("ErrCdKeyException")]
		ErrCdKeyException,
		// Token: 0x0400A9BB RID: 43451
		[OriginalName("ErrCdKeyProcessCount")]
		ErrCdKeyProcessCount,
		// Token: 0x0400A9BC RID: 43452
		[OriginalName("ErrCdKeyNotFound")]
		ErrCdKeyNotFound,
		// Token: 0x0400A9BD RID: 43453
		[OriginalName("ErrCdKeyBatchNotFound")]
		ErrCdKeyBatchNotFound,
		// Token: 0x0400A9BE RID: 43454
		[OriginalName("ErrCdKeyNotInValidTime")]
		ErrCdKeyNotInValidTime,
		// Token: 0x0400A9BF RID: 43455
		[OriginalName("ErrCdKeyBatchMaxCount")]
		ErrCdKeyBatchMaxCount,
		// Token: 0x0400A9C0 RID: 43456
		[OriginalName("ErrCdKeyEachPlayerMaxCount")]
		ErrCdKeyEachPlayerMaxCount,
		// Token: 0x0400A9C1 RID: 43457
		[OriginalName("ErrCdKeyGroupCount")]
		ErrCdKeyGroupCount,
		// Token: 0x0400A9C2 RID: 43458
		[OriginalName("ErrCdKeyCondition")]
		ErrCdKeyCondition,
		// Token: 0x0400A9C3 RID: 43459
		[OriginalName("ErrCdKeyAddCountFail")]
		ErrCdKeyAddCountFail,
		// Token: 0x0400A9C4 RID: 43460
		[OriginalName("ErrCdKeyLength")]
		ErrCdKeyLength,
		// Token: 0x0400A9C5 RID: 43461
		[OriginalName("ErrCdKeyCharacter")]
		ErrCdKeyCharacter,
		// Token: 0x0400A9C6 RID: 43462
		[OriginalName("ErrGiftPackRandomErr")]
		ErrGiftPackRandomErr,
		// Token: 0x0400A9C7 RID: 43463
		[OriginalName("ErrReconnectUserWhiteList")]
		ErrReconnectUserWhiteList,
		// Token: 0x0400A9C8 RID: 43464
		[OriginalName("ErrReconnectChannelWhiteList")]
		ErrReconnectChannelWhiteList,
		// Token: 0x0400A9C9 RID: 43465
		[OriginalName("ErrReconnectIpInvalid")]
		ErrReconnectIpInvalid,
		// Token: 0x0400A9CA RID: 43466
		[OriginalName("ErrReconnectIpWhiteList")]
		ErrReconnectIpWhiteList,
		// Token: 0x0400A9CB RID: 43467
		[OriginalName("ErrCdKeyExpire")]
		ErrCdKeyExpire,
		// Token: 0x0400A9CC RID: 43468
		[OriginalName("ErrWeaponResonLevelLimit")]
		ErrWeaponResonLevelLimit,
		// Token: 0x0400A9CD RID: 43469
		[OriginalName("ErrWeaponConfigNotFound")]
		ErrWeaponConfigNotFound,
		// Token: 0x0400A9CE RID: 43470
		[OriginalName("ErrWeaponResonConfigNotFound")]
		ErrWeaponResonConfigNotFound,
		// Token: 0x0400A9CF RID: 43471
		[OriginalName("ErrWeaponResonConsumeItem")]
		ErrWeaponResonConsumeItem,
		// Token: 0x0400A9D0 RID: 43472
		[OriginalName("ErrWeaponResonConsumeGold")]
		ErrWeaponResonConsumeGold,
		// Token: 0x0400A9D1 RID: 43473
		[OriginalName("ErrDestroyItemDuplicate")]
		ErrDestroyItemDuplicate,
		// Token: 0x0400A9D2 RID: 43474
		[OriginalName("ErrDestroyWeapon")]
		ErrDestroyWeapon,
		// Token: 0x0400A9D3 RID: 43475
		[OriginalName("ErrCannotDestroyItem")]
		ErrCannotDestroyItem,
		// Token: 0x0400A9D4 RID: 43476
		[OriginalName("ErrCannotDestroyPhantom")]
		ErrCannotDestroyPhantom,
		// Token: 0x0400A9D5 RID: 43477
		[OriginalName("ErrCannotDestroyWeaponForm")]
		ErrCannotDestroyWeaponForm,
		// Token: 0x0400A9D6 RID: 43478
		[OriginalName("ErrCannotDestroyItemUnknown")]
		ErrCannotDestroyItemUnknown,
		// Token: 0x0400A9D7 RID: 43479
		[OriginalName("ErrWeaponConsumeQuality")]
		ErrWeaponConsumeQuality,
		// Token: 0x0400A9D8 RID: 43480
		[OriginalName("ErrPhantomSkinChangeCd")]
		ErrPhantomSkinChangeCd,
		// Token: 0x0400A9D9 RID: 43481
		[OriginalName("ErrPhantomSkinUnlock")]
		ErrPhantomSkinUnlock,
		// Token: 0x0400A9DA RID: 43482
		[OriginalName("ErrPhantomSkinMatch")]
		ErrPhantomSkinMatch,
		// Token: 0x0400A9DB RID: 43483
		[OriginalName("ErrLoginGameTainted")]
		ErrLoginGameTainted,
		// Token: 0x0400A9DC RID: 43484
		[OriginalName("ErrCookLimitCount")]
		ErrCookLimitCount,
		// Token: 0x0400A9DD RID: 43485
		[OriginalName("ErrCookLimitTime")]
		ErrCookLimitTime,
		// Token: 0x0400A9DE RID: 43486
		[OriginalName("ErrForgeLimitCount")]
		ErrForgeLimitCount,
		// Token: 0x0400A9DF RID: 43487
		[OriginalName("ErrForgeLimitTime")]
		ErrForgeLimitTime,
		// Token: 0x0400A9E0 RID: 43488
		[OriginalName("ErrSynthesisLimitCount")]
		ErrSynthesisLimitCount,
		// Token: 0x0400A9E1 RID: 43489
		[OriginalName("ErrSynthesisLimitTime")]
		ErrSynthesisLimitTime,
		// Token: 0x0400A9E2 RID: 43490
		[OriginalName("ErrLoginIpBan")]
		ErrLoginIpBan,
		// Token: 0x0400A9E3 RID: 43491
		[OriginalName("ErrLoginDeviceBan")]
		ErrLoginDeviceBan,
		// Token: 0x0400A9E4 RID: 43492
		[OriginalName("ErrRoleNameEmpty")]
		ErrRoleNameEmpty,
		// Token: 0x0400A9E5 RID: 43493
		[OriginalName("ErrAdviceLength")]
		ErrAdviceLength,
		// Token: 0x0400A9E6 RID: 43494
		[OriginalName("ErrPhantomRefiningCount")]
		ErrPhantomRefiningCount,
		// Token: 0x0400A9E7 RID: 43495
		[OriginalName("ErrPhantomRefiningScore")]
		ErrPhantomRefiningScore,
		// Token: 0x0400A9E8 RID: 43496
		[OriginalName("ErrPhantomRefiningTotalScore")]
		ErrPhantomRefiningTotalScore,
		// Token: 0x0400A9E9 RID: 43497
		[OriginalName("ErrPhantomRefiningDeveloped")]
		ErrPhantomRefiningDeveloped,
		// Token: 0x0400A9EA RID: 43498
		[OriginalName("ErrPhotoMemoryCollectConfig")]
		ErrPhotoMemoryCollectConfig,
		// Token: 0x0400A9EB RID: 43499
		[OriginalName("ErrPhotoMemoryFuncNotOpen")]
		ErrPhotoMemoryFuncNotOpen,
		// Token: 0x0400A9EC RID: 43500
		[OriginalName("ErrPhotoMemoryCollectLock")]
		ErrPhotoMemoryCollectLock,
		// Token: 0x0400A9ED RID: 43501
		[OriginalName("ErrPhotoMemoryCollectRewarded")]
		ErrPhotoMemoryCollectRewarded,
		// Token: 0x0400A9EE RID: 43502
		[OriginalName("ErrRoleCount")]
		ErrRoleCount,
		// Token: 0x0400A9EF RID: 43503
		[OriginalName("ErrCookFormulaUnlocked")]
		ErrCookFormulaUnlocked,
		// Token: 0x0400A9F0 RID: 43504
		[OriginalName("ErrForgeFormulaUnlocked")]
		ErrForgeFormulaUnlocked,
		// Token: 0x0400A9F1 RID: 43505
		[OriginalName("ErrSynthesisFormulaUnlocked")]
		ErrSynthesisFormulaUnlocked,
		// Token: 0x0400A9F2 RID: 43506
		[OriginalName("ErrCookFormulaBuyCount")]
		ErrCookFormulaBuyCount,
		// Token: 0x0400A9F3 RID: 43507
		[OriginalName("ErrForgeFormulaBuyCount")]
		ErrForgeFormulaBuyCount,
		// Token: 0x0400A9F4 RID: 43508
		[OriginalName("ErrSynthesisFormulaBuyCount")]
		ErrSynthesisFormulaBuyCount,
		// Token: 0x0400A9F5 RID: 43509
		[OriginalName("ErrCdKeyDailyVerifyCount")]
		ErrCdKeyDailyVerifyCount,
		// Token: 0x0400A9F6 RID: 43510
		[OriginalName("ErrLongShanTaskNotFound")]
		ErrLongShanTaskNotFound,
		// Token: 0x0400A9F7 RID: 43511
		[OriginalName("ErrLongShanActivityClosed")]
		ErrLongShanActivityClosed,
		// Token: 0x0400A9F8 RID: 43512
		[OriginalName("ErrLongShanTaskNotAccept")]
		ErrLongShanTaskNotAccept,
		// Token: 0x0400A9F9 RID: 43513
		[OriginalName("ErrLongShanTaskNotComplete")]
		ErrLongShanTaskNotComplete,
		// Token: 0x0400A9FA RID: 43514
		[OriginalName("ErrLongShanTaskRewarded")]
		ErrLongShanTaskRewarded,
		// Token: 0x0400A9FB RID: 43515
		[OriginalName("ErrTowerDefenceRewardParamErr")]
		ErrTowerDefenceRewardParamErr,
		// Token: 0x0400A9FC RID: 43516
		[OriginalName("ErrTowerDefenceInstanceNotFound")]
		ErrTowerDefenceInstanceNotFound,
		// Token: 0x0400A9FD RID: 43517
		[OriginalName("ErrTowerDefenceActivityNotOpen")]
		ErrTowerDefenceActivityNotOpen,
		// Token: 0x0400A9FE RID: 43518
		[OriginalName("ErrTowerDefenceActivityDataNotFound")]
		ErrTowerDefenceActivityDataNotFound,
		// Token: 0x0400A9FF RID: 43519
		[OriginalName("ErrTowerDefenceInstDataNotFound")]
		ErrTowerDefenceInstDataNotFound,
		// Token: 0x0400AA00 RID: 43520
		[OriginalName("ErrTowerDefenceInstRewarded")]
		ErrTowerDefenceInstRewarded,
		// Token: 0x0400AA01 RID: 43521
		[OriginalName("ErrTowerDefenceInstScoreNotEnough")]
		ErrTowerDefenceInstScoreNotEnough,
		// Token: 0x0400AA02 RID: 43522
		[OriginalName("ErrTowerDefenceScoreRewarded")]
		ErrTowerDefenceScoreRewarded,
		// Token: 0x0400AA03 RID: 43523
		[OriginalName("ErrTowerDefenceScoreRewardNotEnough")]
		ErrTowerDefenceScoreRewardNotEnough,
		// Token: 0x0400AA04 RID: 43524
		[OriginalName("ErrTowerDefenceScoreRewardNotFound")]
		ErrTowerDefenceScoreRewardNotFound,
		// Token: 0x0400AA05 RID: 43525
		[OriginalName("ErrTowerDefenceInstBuffNotEnable")]
		ErrTowerDefenceInstBuffNotEnable,
		// Token: 0x0400AA06 RID: 43526
		[OriginalName("ErrTowerDefencePhantomDuplicate")]
		ErrTowerDefencePhantomDuplicate,
		// Token: 0x0400AA07 RID: 43527
		[OriginalName("ErrTowerDefencePhantomNotSelect")]
		ErrTowerDefencePhantomNotSelect,
		// Token: 0x0400AA08 RID: 43528
		[OriginalName("ErrorTowerDefenceInstNotOpen")]
		ErrorTowerDefenceInstNotOpen,
		// Token: 0x0400AA09 RID: 43529
		[OriginalName("ErrorTowerDefenceInstCondition")]
		ErrorTowerDefenceInstCondition,
		// Token: 0x0400AA0A RID: 43530
		[OriginalName("ErrNameModifyCd")]
		ErrNameModifyCd,
		// Token: 0x0400AA0B RID: 43531
		[OriginalName("ErrNameVerifying")]
		ErrNameVerifying,
		// Token: 0x0400AA0C RID: 43532
		[OriginalName("ErrTimePointRewardActivityConfigNotFound")]
		ErrTimePointRewardActivityConfigNotFound,
		// Token: 0x0400AA0D RID: 43533
		[OriginalName("ErrTimePointRewardActivityNotOpen")]
		ErrTimePointRewardActivityNotOpen,
		// Token: 0x0400AA0E RID: 43534
		[OriginalName("ErrTimePointRewardActivityRewarded")]
		ErrTimePointRewardActivityRewarded,
		// Token: 0x0400AA0F RID: 43535
		[OriginalName("ErrTimePointRewardActivityTime")]
		ErrTimePointRewardActivityTime,
		// Token: 0x0400AA10 RID: 43536
		[OriginalName("ErrCDKeyVerifying")]
		ErrCdkeyVerifying,
		// Token: 0x0400AA11 RID: 43537
		[OriginalName("ErrorTowerDefenceInstLocked")]
		ErrorTowerDefenceInstLocked,
		// Token: 0x0400AA12 RID: 43538
		[OriginalName("ErrTrackMoonEntrustLocked")]
		ErrTrackMoonEntrustLocked,
		// Token: 0x0400AA13 RID: 43539
		[OriginalName("ErrTrackMoonRoleLocked")]
		ErrTrackMoonRoleLocked,
		// Token: 0x0400AA14 RID: 43540
		[OriginalName("ErrTrackMoonBuildLocked")]
		ErrTrackMoonBuildLocked,
		// Token: 0x0400AA15 RID: 43541
		[OriginalName("ErrTrackMoonBuildEntity")]
		ErrTrackMoonBuildEntity,
		// Token: 0x0400AA16 RID: 43542
		[OriginalName("ErrCopyUserRequestErr")]
		ErrCopyUserRequestErr,
		// Token: 0x0400AA17 RID: 43543
		[OriginalName("ErrCopyUserInserting")]
		ErrCopyUserInserting,
		// Token: 0x0400AA18 RID: 43544
		[OriginalName("ErrCopyUserErr")]
		ErrCopyUserErr,
		// Token: 0x0400AA19 RID: 43545
		[OriginalName("ErrCopyUserDataErr")]
		ErrCopyUserDataErr,
		// Token: 0x0400AA1A RID: 43546
		[OriginalName("ErrCopyUserInsertErr")]
		ErrCopyUserInsertErr,
		// Token: 0x0400AA1B RID: 43547
		[OriginalName("ErrCopyUserInsertFailed")]
		ErrCopyUserInsertFailed,
		// Token: 0x0400AA1C RID: 43548
		[OriginalName("ErrRiskHarvestBuffGroupNotFound")]
		ErrRiskHarvestBuffGroupNotFound,
		// Token: 0x0400AA1D RID: 43549
		[OriginalName("ErrRiskHarvestActivityClosePlay")]
		ErrRiskHarvestActivityClosePlay,
		// Token: 0x0400AA1E RID: 43550
		[OriginalName("ErrRiskHarvestModeChangeClosePlay")]
		ErrRiskHarvestModeChangeClosePlay,
		// Token: 0x0400AA1F RID: 43551
		[OriginalName("ErrRiskHarvestLeaveClosePlay")]
		ErrRiskHarvestLeaveClosePlay,
		// Token: 0x0400AA20 RID: 43552
		[OriginalName("ErrRiskHarvestInstNotFound")]
		ErrRiskHarvestInstNotFound,
		// Token: 0x0400AA21 RID: 43553
		[OriginalName("ErrRiskHarvestActivityNotOpen")]
		ErrRiskHarvestActivityNotOpen,
		// Token: 0x0400AA22 RID: 43554
		[OriginalName("ErrRiskHarvestInstDataNotFound")]
		ErrRiskHarvestInstDataNotFound,
		// Token: 0x0400AA23 RID: 43555
		[OriginalName("ErrRiskHarvestInstRewarded")]
		ErrRiskHarvestInstRewarded,
		// Token: 0x0400AA24 RID: 43556
		[OriginalName("ErrRiskHarvestInstNotPass")]
		ErrRiskHarvestInstNotPass,
		// Token: 0x0400AA25 RID: 43557
		[OriginalName("ErrRiskHarvestScoreRewardNotFound")]
		ErrRiskHarvestScoreRewardNotFound,
		// Token: 0x0400AA26 RID: 43558
		[OriginalName("ErrRiskHarvestScoreRewarded")]
		ErrRiskHarvestScoreRewarded,
		// Token: 0x0400AA27 RID: 43559
		[OriginalName("ErrRiskHarvestScoreNotEnough")]
		ErrRiskHarvestScoreNotEnough,
		// Token: 0x0400AA28 RID: 43560
		[OriginalName("ErrRiskHarvestRoleTrial")]
		ErrRiskHarvestRoleTrial,
		// Token: 0x0400AA29 RID: 43561
		[OriginalName("ErrRiskHarvestMatching")]
		ErrRiskHarvestMatching,
		// Token: 0x0400AA2A RID: 43562
		[OriginalName("ErrRiskHarvestNotDefaultWorld")]
		ErrRiskHarvestNotDefaultWorld,
		// Token: 0x0400AA2B RID: 43563
		[OriginalName("ErrRiskHarvestMultiMode")]
		ErrRiskHarvestMultiMode,
		// Token: 0x0400AA2C RID: 43564
		[OriginalName("ErrRiskHarvestInstLocked")]
		ErrRiskHarvestInstLocked,
		// Token: 0x0400AA2D RID: 43565
		[OriginalName("ErrRiskHarvestInstTeleportEntityNotFound")]
		ErrRiskHarvestInstTeleportEntityNotFound,
		// Token: 0x0400AA2E RID: 43566
		[OriginalName("ErrRiskHarvestInstOpen")]
		ErrRiskHarvestInstOpen,
		// Token: 0x0400AA2F RID: 43567
		[OriginalName("ErrRiskHarvestPlayOpenFailed")]
		ErrRiskHarvestPlayOpenFailed,
		// Token: 0x0400AA30 RID: 43568
		[OriginalName("ErrRiskHarvestPlayDataNotFound")]
		ErrRiskHarvestPlayDataNotFound,
		// Token: 0x0400AA31 RID: 43569
		[OriginalName("ErrRiskHarvestBuffNoReward")]
		ErrRiskHarvestBuffNoReward,
		// Token: 0x0400AA32 RID: 43570
		[OriginalName("ErrRiskHarvestBuffRewarded")]
		ErrRiskHarvestBuffRewarded,
		// Token: 0x0400AA33 RID: 43571
		[OriginalName("ErrRiskHarvestBuffLocked")]
		ErrRiskHarvestBuffLocked,
		// Token: 0x0400AA34 RID: 43572
		[OriginalName("ErrRiskHarvestBuffCountRewardNotFound")]
		ErrRiskHarvestBuffCountRewardNotFound,
		// Token: 0x0400AA35 RID: 43573
		[OriginalName("ErrRiskHarvestBuffCountRewarded")]
		ErrRiskHarvestBuffCountRewarded,
		// Token: 0x0400AA36 RID: 43574
		[OriginalName("ErrRiskHarvestBuffCountNotEnough")]
		ErrRiskHarvestBuffCountNotEnough,
		// Token: 0x0400AA37 RID: 43575
		[OriginalName("ErrRiskHarvestInstScoreNotEnough")]
		ErrRiskHarvestInstScoreNotEnough,
		// Token: 0x0400AA38 RID: 43576
		[OriginalName("ErrItemDisuseLimit")]
		ErrItemDisuseLimit,
		// Token: 0x0400AA39 RID: 43577
		[OriginalName("ErrItemDisuseFunc")]
		ErrItemDisuseFunc,
		// Token: 0x0400AA3A RID: 43578
		[OriginalName("ErrPhantomRefiningMaxCount")]
		ErrPhantomRefiningMaxCount,
		// Token: 0x0400AA3B RID: 43579
		[OriginalName("ErrPhantomRefiningDulplicate")]
		ErrPhantomRefiningDulplicate,
		// Token: 0x0400AA3C RID: 43580
		[OriginalName("ErrPhantomNotNormal")]
		ErrPhantomNotNormal,
		// Token: 0x0400AA3D RID: 43581
		[OriginalName("ErrGetSelfPsnOnlineId")]
		ErrGetSelfPsnOnlineId,
		// Token: 0x0400AA3E RID: 43582
		[OriginalName("ErrGetPsnUserPlayerErr")]
		ErrGetPsnUserPlayerErr,
		// Token: 0x0400AA3F RID: 43583
		[OriginalName("ErrTowerDefenceHostLeave")]
		ErrTowerDefenceHostLeave,
		// Token: 0x0400AA40 RID: 43584
		[OriginalName("ErrRiskHarvestNotInInst")]
		ErrRiskHarvestNotInInst,
		// Token: 0x0400AA41 RID: 43585
		[OriginalName("ErrEnterInstTypeErr")]
		ErrEnterInstTypeErr,
		// Token: 0x0400AA42 RID: 43586
		[OriginalName("ErrInputSettingCount")]
		ErrInputSettingCount,
		// Token: 0x0400AA43 RID: 43587
		[OriginalName("ErrInputSettingDeviceType")]
		ErrInputSettingDeviceType,
		// Token: 0x0400AA44 RID: 43588
		[OriginalName("ErrInputSettingActionCount")]
		ErrInputSettingActionCount,
		// Token: 0x0400AA45 RID: 43589
		[OriginalName("ErrInputSettingAxisCount")]
		ErrInputSettingAxisCount,
		// Token: 0x0400AA46 RID: 43590
		[OriginalName("ErrInputCombinationActionCount")]
		ErrInputCombinationActionCount,
		// Token: 0x0400AA47 RID: 43591
		[OriginalName("ErrInputCombinationAxisCount")]
		ErrInputCombinationAxisCount,
		// Token: 0x0400AA48 RID: 43592
		[OriginalName("ErrInputSettingActionName")]
		ErrInputSettingActionName,
		// Token: 0x0400AA49 RID: 43593
		[OriginalName("ErrInputSettingAxisName")]
		ErrInputSettingAxisName,
		// Token: 0x0400AA4A RID: 43594
		[OriginalName("ErrInputCombinationActionName")]
		ErrInputCombinationActionName,
		// Token: 0x0400AA4B RID: 43595
		[OriginalName("ErrInputCombinationAxisName")]
		ErrInputCombinationAxisName,
		// Token: 0x0400AA4C RID: 43596
		[OriginalName("ErrInputActionKeyNameLength")]
		ErrInputActionKeyNameLength,
		// Token: 0x0400AA4D RID: 43597
		[OriginalName("ErrInputActionKeyLength")]
		ErrInputActionKeyLength,
		// Token: 0x0400AA4E RID: 43598
		[OriginalName("ErrInputAxisKeyNameLength")]
		ErrInputAxisKeyNameLength,
		// Token: 0x0400AA4F RID: 43599
		[OriginalName("ErrInputAxisKeyLength")]
		ErrInputAxisKeyLength,
		// Token: 0x0400AA50 RID: 43600
		[OriginalName("ErrInputCombinationActionKeyNameLength")]
		ErrInputCombinationActionKeyNameLength,
		// Token: 0x0400AA51 RID: 43601
		[OriginalName("ErrInputCombinationActionKeyLength")]
		ErrInputCombinationActionKeyLength,
		// Token: 0x0400AA52 RID: 43602
		[OriginalName("ErrInputCombinationActionKeyListLength")]
		ErrInputCombinationActionKeyListLength,
		// Token: 0x0400AA53 RID: 43603
		[OriginalName("ErrInputCombinationAxisKeyNameLength")]
		ErrInputCombinationAxisKeyNameLength,
		// Token: 0x0400AA54 RID: 43604
		[OriginalName("ErrInputCombinationAxisKeyLength")]
		ErrInputCombinationAxisKeyLength,
		// Token: 0x0400AA55 RID: 43605
		[OriginalName("ErrInputCombinationAxisKeyListLength")]
		ErrInputCombinationAxisKeyListLength,
		// Token: 0x0400AA56 RID: 43606
		[OriginalName("ErrInputDeviceSubTypeLength")]
		ErrInputDeviceSubTypeLength,
		// Token: 0x0400AA57 RID: 43607
		[OriginalName("ErrPSNAccountBlocked")]
		ErrPsnaccountBlocked,
		// Token: 0x0400AA58 RID: 43608
		[OriginalName("ErrRoleNameInvalid")]
		ErrRoleNameInvalid,
		// Token: 0x0400AA59 RID: 43609
		[OriginalName("ErrMailBindRewardNotBind")]
		ErrMailBindRewardNotBind,
		// Token: 0x0400AA5A RID: 43610
		[OriginalName("ErrMailBindRewarded")]
		ErrMailBindRewarded,
		// Token: 0x0400AA5B RID: 43611
		[OriginalName("ErrInputSettingNull")]
		ErrInputSettingNull,
		// Token: 0x0400AA5C RID: 43612
		[OriginalName("ErrMultiInstExchangeCountErr")]
		ErrMultiInstExchangeCountErr,
		// Token: 0x0400AA5D RID: 43613
		[OriginalName("ErrMultiInstExchangeFirstPass")]
		ErrMultiInstExchangeFirstPass,
		// Token: 0x0400AA5E RID: 43614
		[OriginalName("ErrMultiInstExchangeActivity")]
		ErrMultiInstExchangeActivity,
		// Token: 0x0400AA5F RID: 43615
		[OriginalName("ErrMultiInstExchangeFuncNotOpen")]
		ErrMultiInstExchangeFuncNotOpen,
		// Token: 0x0400AA60 RID: 43616
		[OriginalName("ErrMultiInstExchangeTypeErr")]
		ErrMultiInstExchangeTypeErr,
		// Token: 0x0400AA61 RID: 43617
		[OriginalName("ErrMultiInstExchangeLevelTypeErr")]
		ErrMultiInstExchangeLevelTypeErr,
		// Token: 0x0400AA62 RID: 43618
		[OriginalName("ErrRoleSkinLocked")]
		ErrRoleSkinLocked,
		// Token: 0x0400AA63 RID: 43619
		[OriginalName("ErrRoleSkinConfig")]
		ErrRoleSkinConfig,
		// Token: 0x0400AA64 RID: 43620
		[OriginalName("ErrRoleSkinNotMatch")]
		ErrRoleSkinNotMatch,
		// Token: 0x0400AA65 RID: 43621
		[OriginalName("ErrRoleSkinWeaponNotSuit")]
		ErrRoleSkinWeaponNotSuit,
		// Token: 0x0400AA66 RID: 43622
		[OriginalName("ErrSdkLoginResetByPeer")]
		ErrSdkLoginResetByPeer,
		// Token: 0x0400AA67 RID: 43623
		[OriginalName("ErrSdkLoginHttpRequestException")]
		ErrSdkLoginHttpRequestException,
		// Token: 0x0400AA68 RID: 43624
		[OriginalName("ErrSdkLoginTaskTimeout")]
		ErrSdkLoginTaskTimeout,
		// Token: 0x0400AA69 RID: 43625
		[OriginalName("ErrSdkLoginTaskCanceled")]
		ErrSdkLoginTaskCanceled,
		// Token: 0x0400AA6A RID: 43626
		[OriginalName("ErrSexChangeCd")]
		ErrSexChangeCd,
		// Token: 0x0400AA6B RID: 43627
		[OriginalName("ErrSexChangeLogout")]
		ErrSexChangeLogout,
		// Token: 0x0400AA6C RID: 43628
		[OriginalName("ErrSexChangeTrialActive")]
		ErrSexChangeTrialActive,
		// Token: 0x0400AA6D RID: 43629
		[OriginalName("ErrLobbyListRequestLimit")]
		ErrLobbyListRequestLimit,
		// Token: 0x0400AA6E RID: 43630
		[OriginalName("ErrLobbyQueryPlayerRequestLimit")]
		ErrLobbyQueryPlayerRequestLimit,
		// Token: 0x0400AA6F RID: 43631
		[OriginalName("ErrPlayerBasicInfoRequestLimit")]
		ErrPlayerBasicInfoRequestLimit,
		// Token: 0x0400AA70 RID: 43632
		[OriginalName("ErrBlockPlayerRequestLimit")]
		ErrBlockPlayerRequestLimit,
		// Token: 0x0400AA71 RID: 43633
		[OriginalName("ErrPsnPlayerInfoRequestLimit")]
		ErrPsnPlayerInfoRequestLimit,
		// Token: 0x0400AA72 RID: 43634
		[OriginalName("ErrFishingPosInvalidX")]
		ErrFishingPosInvalidX,
		// Token: 0x0400AA73 RID: 43635
		[OriginalName("ErrFishingPosInvalidY")]
		ErrFishingPosInvalidY,
		// Token: 0x0400AA74 RID: 43636
		[OriginalName("ErrFishingPosOverlap")]
		ErrFishingPosOverlap,
		// Token: 0x0400AA75 RID: 43637
		[OriginalName("ErrFishingParamLengthCabinLeft")]
		ErrFishingParamLengthCabinLeft,
		// Token: 0x0400AA76 RID: 43638
		[OriginalName("ErrFishingParamLengthCabinRight")]
		ErrFishingParamLengthCabinRight,
		// Token: 0x0400AA77 RID: 43639
		[OriginalName("ErrFishingCabinNotOpen")]
		ErrFishingCabinNotOpen,
		// Token: 0x0400AA78 RID: 43640
		[OriginalName("ErrFishingCabinNotFound")]
		ErrFishingCabinNotFound,
		// Token: 0x0400AA79 RID: 43641
		[OriginalName("ErrFishingCountNotMatch")]
		ErrFishingCountNotMatch,
		// Token: 0x0400AA7A RID: 43642
		[OriginalName("ErrFishingDuplicate")]
		ErrFishingDuplicate,
		// Token: 0x0400AA7B RID: 43643
		[OriginalName("ErrFishingRemoveItemErr")]
		ErrFishingRemoveItemErr,
		// Token: 0x0400AA7C RID: 43644
		[OriginalName("ErrFishingItemNotFound")]
		ErrFishingItemNotFound,
		// Token: 0x0400AA7D RID: 43645
		[OriginalName("ErrFishingCountNotMatchRequest")]
		ErrFishingCountNotMatchRequest,
		// Token: 0x0400AA7E RID: 43646
		[OriginalName("ErrFishingCountNotMatchCabin")]
		ErrFishingCountNotMatchCabin,
		// Token: 0x0400AA7F RID: 43647
		[OriginalName("ErrFishingHandInNotMatch")]
		ErrFishingHandInNotMatch,
		// Token: 0x0400AA80 RID: 43648
		[OriginalName("ErrFishingQuickSellNoItem")]
		ErrFishingQuickSellNoItem,
		// Token: 0x0400AA81 RID: 43649
		[OriginalName("ErrFishingNoQuickSell")]
		ErrFishingNoQuickSell,
		// Token: 0x0400AA82 RID: 43650
		[OriginalName("ErrFishingQuickSellConfig")]
		ErrFishingQuickSellConfig,
		// Token: 0x0400AA83 RID: 43651
		[OriginalName("ErrFishingQuickSellNotFilled")]
		ErrFishingQuickSellNotFilled,
		// Token: 0x0400AA84 RID: 43652
		[OriginalName("ErrFishingQuickSellItemErr")]
		ErrFishingQuickSellItemErr,
		// Token: 0x0400AA85 RID: 43653
		[OriginalName("ErrFishingNoSellItem")]
		ErrFishingNoSellItem,
		// Token: 0x0400AA86 RID: 43654
		[OriginalName("ErrFishingCanNotSell")]
		ErrFishingCanNotSell,
		// Token: 0x0400AA87 RID: 43655
		[OriginalName("ErrFishingItemConfigNotFound")]
		ErrFishingItemConfigNotFound,
		// Token: 0x0400AA88 RID: 43656
		[OriginalName("ErrFishingSellItemDuplicate")]
		ErrFishingSellItemDuplicate,
		// Token: 0x0400AA89 RID: 43657
		[OriginalName("ErrFishingPriceCalFailed")]
		ErrFishingPriceCalFailed,
		// Token: 0x0400AA8A RID: 43658
		[OriginalName("ErrFishingSellCount")]
		ErrFishingSellCount,
		// Token: 0x0400AA8B RID: 43659
		[OriginalName("ErrFishingPointNotOpen")]
		ErrFishingPointNotOpen,
		// Token: 0x0400AA8C RID: 43660
		[OriginalName("ErrFishingPointConfig")]
		ErrFishingPointConfig,
		// Token: 0x0400AA8D RID: 43661
		[OriginalName("ErrFishingPointCount")]
		ErrFishingPointCount,
		// Token: 0x0400AA8E RID: 43662
		[OriginalName("ErrFishingTempCabinMax")]
		ErrFishingTempCabinMax,
		// Token: 0x0400AA8F RID: 43663
		[OriginalName("ErrFishingPointGenFail")]
		ErrFishingPointGenFail,
		// Token: 0x0400AA90 RID: 43664
		[OriginalName("ErrFishingTechLevel")]
		ErrFishingTechLevel,
		// Token: 0x0400AA91 RID: 43665
		[OriginalName("ErrFishingPreNodeLock")]
		ErrFishingPreNodeLock,
		// Token: 0x0400AA92 RID: 43666
		[OriginalName("ErrFishingTechLock")]
		ErrFishingTechLock,
		// Token: 0x0400AA93 RID: 43667
		[OriginalName("ErrFishingTechConfig")]
		ErrFishingTechConfig,
		// Token: 0x0400AA94 RID: 43668
		[OriginalName("ErrFishingLevelMax")]
		ErrFishingLevelMax,
		// Token: 0x0400AA95 RID: 43669
		[OriginalName("ErrFishingSkinConfig")]
		ErrFishingSkinConfig,
		// Token: 0x0400AA96 RID: 43670
		[OriginalName("ErrFishingPortConfig")]
		ErrFishingPortConfig,
		// Token: 0x0400AA97 RID: 43671
		[OriginalName("ErrFishingEntrustConfig")]
		ErrFishingEntrustConfig,
		// Token: 0x0400AA98 RID: 43672
		[OriginalName("ErrFishingEntrustNotAccepted")]
		ErrFishingEntrustNotAccepted,
		// Token: 0x0400AA99 RID: 43673
		[OriginalName("ErrFishingEntrustNotFound")]
		ErrFishingEntrustNotFound,
		// Token: 0x0400AA9A RID: 43674
		[OriginalName("ErrFishingEntrustDestination")]
		ErrFishingEntrustDestination,
		// Token: 0x0400AA9B RID: 43675
		[OriginalName("ErrFishingEntrustItemNotEnough")]
		ErrFishingEntrustItemNotEnough,
		// Token: 0x0400AA9C RID: 43676
		[OriginalName("ErrFishingEntrustItemTotalNotMatch")]
		ErrFishingEntrustItemTotalNotMatch,
		// Token: 0x0400AA9D RID: 43677
		[OriginalName("ErrFishingEntrustDumplicate")]
		ErrFishingEntrustDumplicate,
		// Token: 0x0400AA9E RID: 43678
		[OriginalName("ErrFishingEntrustEmptyItem")]
		ErrFishingEntrustEmptyItem,
		// Token: 0x0400AA9F RID: 43679
		[OriginalName("ErrFishingEntrustItemNotMatch")]
		ErrFishingEntrustItemNotMatch,
		// Token: 0x0400AAA0 RID: 43680
		[OriginalName("ErrFishingEntrustRefreshInitial")]
		ErrFishingEntrustRefreshInitial,
		// Token: 0x0400AAA1 RID: 43681
		[OriginalName("ErrFishingEntrustRefreshPrice")]
		ErrFishingEntrustRefreshPrice,
		// Token: 0x0400AAA2 RID: 43682
		[OriginalName("ErrFishingEntrustNotAcceptable")]
		ErrFishingEntrustNotAcceptable,
		// Token: 0x0400AAA3 RID: 43683
		[OriginalName("ErrFishingNotInBigWorld")]
		ErrFishingNotInBigWorld,
		// Token: 0x0400AAA4 RID: 43684
		[OriginalName("ErrFishingMultiMode")]
		ErrFishingMultiMode,
		// Token: 0x0400AAA5 RID: 43685
		[OriginalName("ErrFishingNotOwner")]
		ErrFishingNotOwner,
		// Token: 0x0400AAA6 RID: 43686
		[OriginalName("ErrFishingSkinLock")]
		ErrFishingSkinLock,
		// Token: 0x0400AAA7 RID: 43687
		[OriginalName("ErrFishingPortLock")]
		ErrFishingPortLock,
		// Token: 0x0400AAA8 RID: 43688
		[OriginalName("ErrFishingCageLock")]
		ErrFishingCageLock,
		// Token: 0x0400AAA9 RID: 43689
		[OriginalName("ErrFishingCageConfig")]
		ErrFishingCageConfig,
		// Token: 0x0400AAAA RID: 43690
		[OriginalName("ErrFishingHandInConfig")]
		ErrFishingHandInConfig,
		// Token: 0x0400AAAB RID: 43691
		[OriginalName("ErrFishingHandInCountNotMatch")]
		ErrFishingHandInCountNotMatch,
		// Token: 0x0400AAAC RID: 43692
		[OriginalName("ErrFishingTempPointData")]
		ErrFishingTempPointData,
		// Token: 0x0400AAAD RID: 43693
		[OriginalName("ErrFishingTempPointConfig")]
		ErrFishingTempPointConfig,
		// Token: 0x0400AAAE RID: 43694
		[OriginalName("ErrFishingBombItem")]
		ErrFishingBombItem,
		// Token: 0x0400AAAF RID: 43695
		[OriginalName("ErrFishingBombNoPoint")]
		ErrFishingBombNoPoint,
		// Token: 0x0400AAB0 RID: 43696
		[OriginalName("ErrFishingBaitArea")]
		ErrFishingBaitArea,
		// Token: 0x0400AAB1 RID: 43697
		[OriginalName("ErrFishingNotSailing")]
		ErrFishingNotSailing,
		// Token: 0x0400AAB2 RID: 43698
		[OriginalName("ErrFishingInPort")]
		ErrFishingInPort,
		// Token: 0x0400AAB3 RID: 43699
		[OriginalName("ErrFishingInShip")]
		ErrFishingInShip,
		// Token: 0x0400AAB4 RID: 43700
		[OriginalName("ErrFishingIllustratedRewardNotFound")]
		ErrFishingIllustratedRewardNotFound,
		// Token: 0x0400AAB5 RID: 43701
		[OriginalName("ErrFishingIllustratedRewarded")]
		ErrFishingIllustratedRewarded,
		// Token: 0x0400AAB6 RID: 43702
		[OriginalName("ErrFishingIllustratedCondition")]
		ErrFishingIllustratedCondition,
		// Token: 0x0400AAB7 RID: 43703
		[OriginalName("ErrFishingTechOutputNotFound")]
		ErrFishingTechOutputNotFound,
		// Token: 0x0400AAB8 RID: 43704
		[OriginalName("ErrFishingShipNotFound")]
		ErrFishingShipNotFound,
		// Token: 0x0400AAB9 RID: 43705
		[OriginalName("ErrFishingPortTech")]
		ErrFishingPortTech,
		// Token: 0x0400AABA RID: 43706
		[OriginalName("ErrFishingRemoveFuncNotOpen")]
		ErrFishingRemoveFuncNotOpen,
		// Token: 0x0400AABB RID: 43707
		[OriginalName("ErrFishingIllustratedFuncNotOpen")]
		ErrFishingIllustratedFuncNotOpen,
		// Token: 0x0400AABC RID: 43708
		[OriginalName("ErrFishingSellFuncNotOpen")]
		ErrFishingSellFuncNotOpen,
		// Token: 0x0400AABD RID: 43709
		[OriginalName("ErrFishingTechFuncNotOpen")]
		ErrFishingTechFuncNotOpen,
		// Token: 0x0400AABE RID: 43710
		[OriginalName("ErrFishingEntrustHandInQuickSell")]
		ErrFishingEntrustHandInQuickSell,
		// Token: 0x0400AABF RID: 43711
		[OriginalName("ErrActivityPreOpenLock")]
		ErrActivityPreOpenLock,
		// Token: 0x0400AAC0 RID: 43712
		[OriginalName("ErrActivityShowLock")]
		ErrActivityShowLock,
		// Token: 0x0400AAC1 RID: 43713
		[OriginalName("ErrShopGoodsVisibleCondition")]
		ErrShopGoodsVisibleCondition,
		// Token: 0x0400AAC2 RID: 43714
		[OriginalName("ErrShopGoodsDisableCondition")]
		ErrShopGoodsDisableCondition,
		// Token: 0x0400AAC3 RID: 43715
		[OriginalName("ErrFishingEntrustRefreshFail")]
		ErrFishingEntrustRefreshFail,
		// Token: 0x0400AAC4 RID: 43716
		[OriginalName("ErrPlayerDataVersion")]
		ErrPlayerDataVersion,
		// Token: 0x0400AAC5 RID: 43717
		[OriginalName("ErrBrokenCircuitRejected")]
		ErrBrokenCircuitRejected,
		// Token: 0x0400AAC6 RID: 43718
		[OriginalName("ErrRateLimiterRejected")]
		ErrRateLimiterRejected,
		// Token: 0x0400AAC7 RID: 43719
		[OriginalName("ErrTimeoutRejected")]
		ErrTimeoutRejected,
		// Token: 0x0400AAC8 RID: 43720
		[OriginalName("ErrLoginEnvironment")]
		ErrLoginEnvironment,
		// Token: 0x0400AAC9 RID: 43721
		[OriginalName("ErrLoginUserEmpty")]
		ErrLoginUserEmpty,
		// Token: 0x0400AACA RID: 43722
		[OriginalName("ErrOldGameNodeLogoutFail")]
		ErrOldGameNodeLogoutFail,
		// Token: 0x0400AACB RID: 43723
		[OriginalName("ErrOldGameNodeLogoutOffline")]
		ErrOldGameNodeLogoutOffline,
		// Token: 0x0400AACC RID: 43724
		[OriginalName("ErrReloginBranchNameNotMatch")]
		ErrReloginBranchNameNotMatch,
		// Token: 0x0400AACD RID: 43725
		[OriginalName("ErrReLoginFightDataInConsistent")]
		ErrReLoginFightDataInConsistent,
		// Token: 0x0400AACE RID: 43726
		[OriginalName("ErrCreatePlayerData")]
		ErrCreatePlayerData,
		// Token: 0x0400AACF RID: 43727
		[OriginalName("ErrReLoginPlayerLoggingOut")]
		ErrReLoginPlayerLoggingOut,
		// Token: 0x0400AAD0 RID: 43728
		[OriginalName("ErrAccountLoggedInElsewhere")]
		ErrAccountLoggedInElsewhere,
		// Token: 0x0400AAD1 RID: 43729
		[OriginalName("ErrTowerChallengeTeleportLocked")]
		ErrTowerChallengeTeleportLocked = 200551,
		// Token: 0x0400AAD2 RID: 43730
		[OriginalName("ErrTowerDefenceGroupConfig")]
		ErrTowerDefenceGroupConfig,
		// Token: 0x0400AAD3 RID: 43731
		[OriginalName("ErrTowerDefencePreInstNotPass")]
		ErrTowerDefencePreInstNotPass,
		// Token: 0x0400AAD4 RID: 43732
		[OriginalName("ErrTowerDefenceRankCd")]
		ErrTowerDefenceRankCd,
		// Token: 0x0400AAD5 RID: 43733
		[OriginalName("ErrFishingFixItemNotEnough")]
		ErrFishingFixItemNotEnough = 200549,
		// Token: 0x0400AAD6 RID: 43734
		[OriginalName("ErrFishingEntrustUpdateItemNotEnough")]
		ErrFishingEntrustUpdateItemNotEnough,
		// Token: 0x0400AAD7 RID: 43735
		[OriginalName("ErrTowerDefenceGroupActivityC")]
		ErrTowerDefenceGroupActivityC = 200555,
		// Token: 0x0400AAD8 RID: 43736
		[OriginalName("ErrTowerDefenceGroupActivity")]
		ErrTowerDefenceGroupActivity,
		// Token: 0x0400AAD9 RID: 43737
		[OriginalName("ErrAbyssComNotFound")]
		ErrAbyssComNotFound,
		// Token: 0x0400AADA RID: 43738
		[OriginalName("ErrAbyssInstConfig")]
		ErrAbyssInstConfig,
		// Token: 0x0400AADB RID: 43739
		[OriginalName("ErrAbyssRoomConfig")]
		ErrAbyssRoomConfig,
		// Token: 0x0400AADC RID: 43740
		[OriginalName("ErrAbyssEnterCtx")]
		ErrAbyssEnterCtx,
		// Token: 0x0400AADD RID: 43741
		[OriginalName("ErrAbyssActivityNotOpen")]
		ErrAbyssActivityNotOpen,
		// Token: 0x0400AADE RID: 43742
		[OriginalName("ErrAbyssRewardConfig")]
		ErrAbyssRewardConfig,
		// Token: 0x0400AADF RID: 43743
		[OriginalName("ErrAbyssRewardNotOpen")]
		ErrAbyssRewardNotOpen,
		// Token: 0x0400AAE0 RID: 43744
		[OriginalName("ErrAbyssRewardClosed")]
		ErrAbyssRewardClosed,
		// Token: 0x0400AAE1 RID: 43745
		[OriginalName("ErrAbyssRewarded")]
		ErrAbyssRewarded,
		// Token: 0x0400AAE2 RID: 43746
		[OriginalName("ErrAbyssRewardCondition")]
		ErrAbyssRewardCondition,
		// Token: 0x0400AAE3 RID: 43747
		[OriginalName("ErrAbyssLastActionNotFinish")]
		ErrAbyssLastActionNotFinish,
		// Token: 0x0400AAE4 RID: 43748
		[OriginalName("ErrAbyssNextRoomNotFound")]
		ErrAbyssNextRoomNotFound,
		// Token: 0x0400AAE5 RID: 43749
		[OriginalName("ErrAbyssRoleNotEquip")]
		ErrAbyssRoleNotEquip,
		// Token: 0x0400AAE6 RID: 43750
		[OriginalName("ErrAbyssEquipRoleNotExist")]
		ErrAbyssEquipRoleNotExist,
		// Token: 0x0400AAE7 RID: 43751
		[OriginalName("ErrAbyssEquipRoleDuplicate")]
		ErrAbyssEquipRoleDuplicate,
		// Token: 0x0400AAE8 RID: 43752
		[OriginalName("ErrAbyssRoomNoBox")]
		ErrAbyssRoomNoBox,
		// Token: 0x0400AAE9 RID: 43753
		[OriginalName("ErrAbyssRewardPlayerCount")]
		ErrAbyssRewardPlayerCount,
		// Token: 0x0400AAEA RID: 43754
		[OriginalName("ErrAbyssRewardBoxEntityIncId")]
		ErrAbyssRewardBoxEntityIncId,
		// Token: 0x0400AAEB RID: 43755
		[OriginalName("ErrAbyssBoxRewarded")]
		ErrAbyssBoxRewarded,
		// Token: 0x0400AAEC RID: 43756
		[OriginalName("ErrAbyssBoxNotBelong")]
		ErrAbyssBoxNotBelong,
		// Token: 0x0400AAED RID: 43757
		[OriginalName("ErrAbyssBoxConfigNotFound")]
		ErrAbyssBoxConfigNotFound,
		// Token: 0x0400AAEE RID: 43758
		[OriginalName("ErrAbyssBoxDropFailed")]
		ErrAbyssBoxDropFailed,
		// Token: 0x0400AAEF RID: 43759
		[OriginalName("ErrAbyssChallengeLocked")]
		ErrAbyssChallengeLocked,
		// Token: 0x0400AAF0 RID: 43760
		[OriginalName("ErrAbyssChallengeNoConsume")]
		ErrAbyssChallengeNoConsume,
		// Token: 0x0400AAF1 RID: 43761
		[OriginalName("ErrAbyssChallengeUnlockItem")]
		ErrAbyssChallengeUnlockItem,
		// Token: 0x0400AAF2 RID: 43762
		[OriginalName("ErrAbyssLikePlayerNotInScene")]
		ErrAbyssLikePlayerNotInScene,
		// Token: 0x0400AAF3 RID: 43763
		[OriginalName("ErrAbyssLikeDuplicate")]
		ErrAbyssLikeDuplicate,
		// Token: 0x0400AAF4 RID: 43764
		[OriginalName("ErrAbyssRoleItemNotFound")]
		ErrAbyssRoleItemNotFound,
		// Token: 0x0400AAF5 RID: 43765
		[OriginalName("ErrAbyssRoleConfig")]
		ErrAbyssRoleConfig,
		// Token: 0x0400AAF6 RID: 43766
		[OriginalName("ErrAbyssRoleLevelConfig")]
		ErrAbyssRoleLevelConfig,
		// Token: 0x0400AAF7 RID: 43767
		[OriginalName("ErrAbyssRoleMaxPluginCount")]
		ErrAbyssRoleMaxPluginCount,
		// Token: 0x0400AAF8 RID: 43768
		[OriginalName("ErrAbyssRoleLevelMaxPlugin")]
		ErrAbyssRoleLevelMaxPlugin,
		// Token: 0x0400AAF9 RID: 43769
		[OriginalName("ErrAbyssPutOnDuplicate")]
		ErrAbyssPutOnDuplicate,
		// Token: 0x0400AAFA RID: 43770
		[OriginalName("ErrAbyssEquipOldRoleFailed")]
		ErrAbyssEquipOldRoleFailed,
		// Token: 0x0400AAFB RID: 43771
		[OriginalName("ErrAbyssSysthesisMaxCount")]
		ErrAbyssSysthesisMaxCount,
		// Token: 0x0400AAFC RID: 43772
		[OriginalName("ErrAbyssSysthesisItemDuplicate")]
		ErrAbyssSysthesisItemDuplicate,
		// Token: 0x0400AAFD RID: 43773
		[OriginalName("ErrAbyssPluginItemNotFound")]
		ErrAbyssPluginItemNotFound,
		// Token: 0x0400AAFE RID: 43774
		[OriginalName("ErrAbyssPluginItemLocked")]
		ErrAbyssPluginItemLocked,
		// Token: 0x0400AAFF RID: 43775
		[OriginalName("ErrAbyssPluginConfigNotFound")]
		ErrAbyssPluginConfigNotFound,
		// Token: 0x0400AB00 RID: 43776
		[OriginalName("ErrAbyssPluginEquipped")]
		ErrAbyssPluginEquipped,
		// Token: 0x0400AB01 RID: 43777
		[OriginalName("ErrAbyssQuialityConfig")]
		ErrAbyssQuialityConfig,
		// Token: 0x0400AB02 RID: 43778
		[OriginalName("ErrAbyssSysthesisConsumeItemDuplicate")]
		ErrAbyssSysthesisConsumeItemDuplicate,
		// Token: 0x0400AB03 RID: 43779
		[OriginalName("ErrAbyssRankListCd")]
		ErrAbyssRankListCd,
		// Token: 0x0400AB04 RID: 43780
		[OriginalName("ErrAbyssRoleUpLevel")]
		ErrAbyssRoleUpLevel,
		// Token: 0x0400AB05 RID: 43781
		[OriginalName("ErrAbyssRoleUpItem")]
		ErrAbyssRoleUpItem,
		// Token: 0x0400AB06 RID: 43782
		[OriginalName("ErrAbyssRoleUpNoComsume")]
		ErrAbyssRoleUpNoComsume,
		// Token: 0x0400AB07 RID: 43783
		[OriginalName("ErrAbyssPreChallengeNotPass")]
		ErrAbyssPreChallengeNotPass,
		// Token: 0x0400AB08 RID: 43784
		[OriginalName("ErrAbyssSlotConfig")]
		ErrAbyssSlotConfig,
		// Token: 0x0400AB09 RID: 43785
		[OriginalName("ErrAbyssSlotNotMatch")]
		ErrAbyssSlotNotMatch,
		// Token: 0x0400AB0A RID: 43786
		[OriginalName("ErrAbyssInstUnlockTime")]
		ErrAbyssInstUnlockTime,
		// Token: 0x0400AB0B RID: 43787
		[OriginalName("ErrAbyssSettled")]
		ErrAbyssSettled,
		// Token: 0x0400AB0C RID: 43788
		[OriginalName("ErrFormationTrailGender")]
		ErrFormationTrailGender,
		// Token: 0x0400AB0D RID: 43789
		[OriginalName("ErrLongShanStageLocked")]
		ErrLongShanStageLocked,
		// Token: 0x0400AB0E RID: 43790
		[OriginalName("ErrAbyssRewardIdRepeated")]
		ErrAbyssRewardIdRepeated,
		// Token: 0x0400AB0F RID: 43791
		[OriginalName("ErrAbyssRewardCount")]
		ErrAbyssRewardCount,
		// Token: 0x0400AB10 RID: 43792
		[OriginalName("ErrOtherPlayerCondition")]
		ErrOtherPlayerCondition,
		// Token: 0x0400AB11 RID: 43793
		[OriginalName("ErrAbyssItemSkillBelongTo")]
		ErrAbyssItemSkillBelongTo,
		// Token: 0x0400AB12 RID: 43794
		[OriginalName("ErrLongShanScoreRewardCount")]
		ErrLongShanScoreRewardCount,
		// Token: 0x0400AB13 RID: 43795
		[OriginalName("ErrLongShanScoreRewardDuplicate")]
		ErrLongShanScoreRewardDuplicate,
		// Token: 0x0400AB14 RID: 43796
		[OriginalName("ErrLongShanScoreRewardConfig")]
		ErrLongShanScoreRewardConfig,
		// Token: 0x0400AB15 RID: 43797
		[OriginalName("ErrLongShanScoreRewardActivity")]
		ErrLongShanScoreRewardActivity,
		// Token: 0x0400AB16 RID: 43798
		[OriginalName("ErrLongShanScoreRewarded")]
		ErrLongShanScoreRewarded,
		// Token: 0x0400AB17 RID: 43799
		[OriginalName("ErrLongShanScoreNotEnough")]
		ErrLongShanScoreNotEnough,
		// Token: 0x0400AB18 RID: 43800
		[OriginalName("ErrAbyssDuplicatePassive")]
		ErrAbyssDuplicatePassive,
		// Token: 0x0400AB19 RID: 43801
		[OriginalName("ErrActivityLifePointChallengeNotFound")]
		ErrActivityLifePointChallengeNotFound,
		// Token: 0x0400AB1A RID: 43802
		[OriginalName("ErrActivityLifePointNotOpen")]
		ErrActivityLifePointNotOpen,
		// Token: 0x0400AB1B RID: 43803
		[OriginalName("ErrActivityLifePointPreLocked")]
		ErrActivityLifePointPreLocked,
		// Token: 0x0400AB1C RID: 43804
		[OriginalName("ErrPhantomSettingRuleDuplicate")]
		ErrPhantomSettingRuleDuplicate,
		// Token: 0x0400AB1D RID: 43805
		[OriginalName("ErrPhantomSettingRuleNotFound")]
		ErrPhantomSettingRuleNotFound,
		// Token: 0x0400AB1E RID: 43806
		[OriginalName("ErrPhantomSettingEmpty")]
		ErrPhantomSettingEmpty,
		// Token: 0x0400AB1F RID: 43807
		[OriginalName("ErrPhantomSettingType")]
		ErrPhantomSettingType,
		// Token: 0x0400AB20 RID: 43808
		[OriginalName("ErrPhantomSettingNameLength")]
		ErrPhantomSettingNameLength,
		// Token: 0x0400AB21 RID: 43809
		[OriginalName("ErrPhantomSettingNull")]
		ErrPhantomSettingNull,
		// Token: 0x0400AB22 RID: 43810
		[OriginalName("ErrPhantomSettingIndexRange")]
		ErrPhantomSettingIndexRange,
		// Token: 0x0400AB23 RID: 43811
		[OriginalName("ErrPhantomRuleIndexRange")]
		ErrPhantomRuleIndexRange,
		// Token: 0x0400AB24 RID: 43812
		[OriginalName("ErrPhantomRuleCount")]
		ErrPhantomRuleCount,
		// Token: 0x0400AB25 RID: 43813
		[OriginalName("ErrPhantomBathchOperCount")]
		ErrPhantomBathchOperCount,
		// Token: 0x0400AB26 RID: 43814
		[OriginalName("ErrPhantomBathchType")]
		ErrPhantomBathchType,
		// Token: 0x0400AB27 RID: 43815
		[OriginalName("ErrMobileSettingRequestParam")]
		ErrMobileSettingRequestParam,
		// Token: 0x0400AB28 RID: 43816
		[OriginalName("ErrMobileSettingParamDuplicate")]
		ErrMobileSettingParamDuplicate,
		// Token: 0x0400AB29 RID: 43817
		[OriginalName("ErrCommonUiSettingRequestParam")]
		ErrCommonUiSettingRequestParam,
		// Token: 0x0400AB2A RID: 43818
		[OriginalName("ErrCommonUiSettingParamDuplicate")]
		ErrCommonUiSettingParamDuplicate,
		// Token: 0x0400AB2B RID: 43819
		[OriginalName("ErrCommonUiSettingConfig")]
		ErrCommonUiSettingConfig,
		// Token: 0x0400AB2C RID: 43820
		[OriginalName("ErrActivityNotOpenTip")]
		ErrActivityNotOpenTip,
		// Token: 0x0400AB2D RID: 43821
		[OriginalName("ErrLineCrossChallengeNotFound")]
		ErrLineCrossChallengeNotFound,
		// Token: 0x0400AB2E RID: 43822
		[OriginalName("ErrActivitylineCrossNotOpen")]
		ErrActivitylineCrossNotOpen,
		// Token: 0x0400AB2F RID: 43823
		[OriginalName("ErrActivitylineCrossPreLocked")]
		ErrActivitylineCrossPreLocked,
		// Token: 0x0400AB30 RID: 43824
		[OriginalName("ErrPhantomSettingFuncNotOpen")]
		ErrPhantomSettingFuncNotOpen,
		// Token: 0x0400AB31 RID: 43825
		[OriginalName("ErrTowerSeasonConfig")]
		ErrTowerSeasonConfig,
		// Token: 0x0400AB32 RID: 43826
		[OriginalName("ErrAccountDeactivation")]
		ErrAccountDeactivation,
		// Token: 0x0400AB33 RID: 43827
		[OriginalName("ErrPlayerAccountDeactivation")]
		ErrPlayerAccountDeactivation,
		// Token: 0x0400AB34 RID: 43828
		[OriginalName("ErrPlayerSkinChange")]
		ErrPlayerSkinChange,
		// Token: 0x0400AB35 RID: 43829
		[OriginalName("ErrTrapDefenseNotMulti")]
		ErrTrapDefenseNotMulti,
		// Token: 0x0400AB36 RID: 43830
		[OriginalName("ErrNotInTrapDefenseInst")]
		ErrNotInTrapDefenseInst,
		// Token: 0x0400AB37 RID: 43831
		[OriginalName("ErrBossRushTaskNoConfig")]
		ErrBossRushTaskNoConfig,
		// Token: 0x0400AB38 RID: 43832
		[OriginalName("ErrBossRushRequestActivityNotMatch")]
		ErrBossRushRequestActivityNotMatch,
		// Token: 0x0400AB39 RID: 43833
		[OriginalName("ErrPhantomBatchPolishCount")]
		ErrPhantomBatchPolishCount,
		// Token: 0x0400AB3A RID: 43834
		[OriginalName("ErrPhantomBatchPolishDuplicate")]
		ErrPhantomBatchPolishDuplicate,
		// Token: 0x0400AB3B RID: 43835
		[OriginalName("ErrPhantomBatchPolishPropNotMatch")]
		ErrPhantomBatchPolishPropNotMatch,
		// Token: 0x0400AB3C RID: 43836
		[OriginalName("ErrPhantomBatchPolishNoValidItem")]
		ErrPhantomBatchPolishNoValidItem,
		// Token: 0x0400AB3D RID: 43837
		[OriginalName("ErrLoginEmptyToken")]
		ErrLoginEmptyToken,
		// Token: 0x0400AB3E RID: 43838
		[OriginalName("ErrPhantomVicePolishLimit")]
		ErrPhantomVicePolishLimit,
		// Token: 0x0400AB3F RID: 43839
		[OriginalName("ErrPhantomVicePolishParam")]
		ErrPhantomVicePolishParam,
		// Token: 0x0400AB40 RID: 43840
		[OriginalName("ErrPhantomVicePolishItemPropLimit")]
		ErrPhantomVicePolishItemPropLimit,
		// Token: 0x0400AB41 RID: 43841
		[OriginalName("ErrPhantomVicePolishItemLevelLimit")]
		ErrPhantomVicePolishItemLevelLimit,
		// Token: 0x0400AB42 RID: 43842
		[OriginalName("ErrPhantomVicePolishParamDuplicate")]
		ErrPhantomVicePolishParamDuplicate,
		// Token: 0x0400AB43 RID: 43843
		[OriginalName("ErrPhantomVicePolishPropGen")]
		ErrPhantomVicePolishPropGen,
		// Token: 0x0400AB44 RID: 43844
		[OriginalName("ErrPhantomVicePolishNoneProp")]
		ErrPhantomVicePolishNoneProp,
		// Token: 0x0400AB45 RID: 43845
		[OriginalName("ErrSkinRewardNotFound")]
		ErrSkinRewardNotFound,
		// Token: 0x0400AB46 RID: 43846
		[OriginalName("ErrSkinRewardState")]
		ErrSkinRewardState,
		// Token: 0x0400AB47 RID: 43847
		[OriginalName("ErrTowerForbidRechallenge")]
		ErrTowerForbidRechallenge,
		// Token: 0x0400AB48 RID: 43848
		[OriginalName("ErrInputSettingActoinType")]
		ErrInputSettingActoinType,
		// Token: 0x0400AB49 RID: 43849
		[OriginalName("ErrCreateCharacterGender")]
		ErrCreateCharacterGender,
		// Token: 0x0400AB4A RID: 43850
		[OriginalName("ErrSkillBranchRoleValid")]
		ErrSkillBranchRoleValid,
		// Token: 0x0400AB4B RID: 43851
		[OriginalName("ErrSkillBranchNotValid")]
		ErrSkillBranchNotValid,
		// Token: 0x0400AB4C RID: 43852
		[OriginalName("ErrTrailRoleSkillBranchNotValid")]
		ErrTrailRoleSkillBranchNotValid,
		// Token: 0x0400AB4D RID: 43853
		[OriginalName("ErrRoleDevConfigVersion")]
		ErrRoleDevConfigVersion,
		// Token: 0x0400AB4E RID: 43854
		[OriginalName("ErrRoleDevConfigVersionTime")]
		ErrRoleDevConfigVersionTime,
		// Token: 0x0400AB4F RID: 43855
		[OriginalName("ErrRoleDevConfigNoUpdate")]
		ErrRoleDevConfigNoUpdate,
		// Token: 0x0400AB50 RID: 43856
		[OriginalName("ErrMotorDevelopRequestParam")]
		ErrMotorDevelopRequestParam,
		// Token: 0x0400AB51 RID: 43857
		[OriginalName("ErrMotorDevelopParamDuplicate")]
		ErrMotorDevelopParamDuplicate,
		// Token: 0x0400AB52 RID: 43858
		[OriginalName("ErrMotorDevelopTaskNotFound")]
		ErrMotorDevelopTaskNotFound,
		// Token: 0x0400AB53 RID: 43859
		[OriginalName("ErrMotorDevelopActivityNotOpen")]
		ErrMotorDevelopActivityNotOpen,
		// Token: 0x0400AB54 RID: 43860
		[OriginalName("ErrMotorDevelopTaskNotComplete")]
		ErrMotorDevelopTaskNotComplete,
		// Token: 0x0400AB55 RID: 43861
		[OriginalName("ErrPhantomVicePolishNoAck")]
		ErrPhantomVicePolishNoAck,
		// Token: 0x0400AB56 RID: 43862
		[OriginalName("ErrClientStorageSystemCount")]
		ErrClientStorageSystemCount,
		// Token: 0x0400AB57 RID: 43863
		[OriginalName("ErrClientStorageSystemDuplicate")]
		ErrClientStorageSystemDuplicate,
		// Token: 0x0400AB58 RID: 43864
		[OriginalName("ErrClientStorageSystem")]
		ErrClientStorageSystem,
		// Token: 0x0400AB59 RID: 43865
		[OriginalName("ErrClientStorageStringLength")]
		ErrClientStorageStringLength,
		// Token: 0x0400AB5A RID: 43866
		[OriginalName("ErrClientStorageType")]
		ErrClientStorageType,
		// Token: 0x0400AB5B RID: 43867
		[OriginalName("ErrClientStorageCapacity")]
		ErrClientStorageCapacity,
		// Token: 0x0400AB5C RID: 43868
		[OriginalName("ErrClientStorageSystemTypeErr")]
		ErrClientStorageSystemTypeErr,
		// Token: 0x0400AB5D RID: 43869
		[OriginalName("ErrXboxRegionNotFound")]
		ErrXboxRegionNotFound,
		// Token: 0x0400AB5E RID: 43870
		[OriginalName("ErrNotXboxChannelId")]
		ErrNotXboxChannelId,
		// Token: 0x0400AB5F RID: 43871
		[OriginalName("ErrXboxRegionSet")]
		ErrXboxRegionSet,
		// Token: 0x0400AB60 RID: 43872
		[OriginalName("ErrXboxRegionSetException")]
		ErrXboxRegionSetException,
		// Token: 0x0400AB61 RID: 43873
		[OriginalName("ErrXboxRegionGetException")]
		ErrXboxRegionGetException,
		// Token: 0x0400AB62 RID: 43874
		[OriginalName("ErrXboxRegionGetFailed")]
		ErrXboxRegionGetFailed,
		// Token: 0x0400AB63 RID: 43875
		[OriginalName("ErrQuestBranchPageNotFound")]
		ErrQuestBranchPageNotFound,
		// Token: 0x0400AB64 RID: 43876
		[OriginalName("ErrQuestBranchQuestState")]
		ErrQuestBranchQuestState,
		// Token: 0x0400AB65 RID: 43877
		[OriginalName("ErrQuestBranchComplete")]
		ErrQuestBranchComplete,
		// Token: 0x0400AB66 RID: 43878
		[OriginalName("ErrQuestBranchNotComplete")]
		ErrQuestBranchNotComplete,
		// Token: 0x0400AB67 RID: 43879
		[OriginalName("ErrFightFormationNameChangeCd")]
		ErrFightFormationNameChangeCd,
		// Token: 0x0400AB68 RID: 43880
		[OriginalName("ErrFightFormationNameLength")]
		ErrFightFormationNameLength,
		// Token: 0x0400AB69 RID: 43881
		[OriginalName("ErrRoleSkillLevel")]
		ErrRoleSkillLevel,
		// Token: 0x0400AB6A RID: 43882
		[OriginalName("ErrQuestBranchConfig")]
		ErrQuestBranchConfig,
		// Token: 0x0400AB6B RID: 43883
		[OriginalName("ErrConditionStateRequestParam")]
		ErrConditionStateRequestParam,
		// Token: 0x0400AB6C RID: 43884
		[OriginalName("ErrConditionStateRequestModule")]
		ErrConditionStateRequestModule,
		// Token: 0x0400AB6D RID: 43885
		[OriginalName("ErrPolishPhantomStackKey")]
		ErrPolishPhantomStackKey,
		// Token: 0x0400AB6E RID: 43886
		[OriginalName("ErrSplitPhantomStackKey")]
		ErrSplitPhantomStackKey,
		// Token: 0x0400AB6F RID: 43887
		[OriginalName("ErrConsumePhantomStackKey")]
		ErrConsumePhantomStackKey,
		// Token: 0x0400AB70 RID: 43888
		[OriginalName("ErrBatchPolishPhantomStackKey")]
		ErrBatchPolishPhantomStackKey,
		// Token: 0x0400AB71 RID: 43889
		[OriginalName("ErrPhantomMaxStackCount")]
		ErrPhantomMaxStackCount,
		// Token: 0x0400AB72 RID: 43890
		[OriginalName("ErrReturnPhantomStackKey")]
		ErrReturnPhantomStackKey,
		// Token: 0x0400AB73 RID: 43891
		[OriginalName("ErrRefiningPhantomStackKey")]
		ErrRefiningPhantomStackKey,
		// Token: 0x0400AB74 RID: 43892
		[OriginalName("ErrPhantomPkgFull")]
		ErrPhantomPkgFull,
		// Token: 0x0400AB75 RID: 43893
		[OriginalName("ErrMapDefault")]
		ErrMapDefault = 300000,
		// Token: 0x0400AB76 RID: 43894
		[OriginalName("ErrMapMarkNumLimit")]
		ErrMapMarkNumLimit,
		// Token: 0x0400AB77 RID: 43895
		[OriginalName("ErrMapNoFogConfig")]
		ErrMapNoFogConfig,
		// Token: 0x0400AB78 RID: 43896
		[OriginalName("ErrMapFogAlreadyUnlock")]
		ErrMapFogAlreadyUnlock,
		// Token: 0x0400AB79 RID: 43897
		[OriginalName("ErrFormationEmpty")]
		ErrFormationEmpty,
		// Token: 0x0400AB7A RID: 43898
		[OriginalName("ErrFormationUnknown")]
		ErrFormationUnknown,
		// Token: 0x0400AB7B RID: 43899
		[OriginalName("ErrFormationDead")]
		ErrFormationDead,
		// Token: 0x0400AB7C RID: 43900
		[OriginalName("ErrFormationRoleRepeat")]
		ErrFormationRoleRepeat,
		// Token: 0x0400AB7D RID: 43901
		[OriginalName("ErrFormationRoleNotActive")]
		ErrFormationRoleNotActive,
		// Token: 0x0400AB7E RID: 43902
		[OriginalName("ErrFormationRoleIndexOut")]
		ErrFormationRoleIndexOut,
		// Token: 0x0400AB7F RID: 43903
		[OriginalName("ErrFormationRoleCountOut")]
		ErrFormationRoleCountOut,
		// Token: 0x0400AB80 RID: 43904
		[OriginalName("ErrFightFormationRoleNotExist")]
		ErrFightFormationRoleNotExist,
		// Token: 0x0400AB81 RID: 43905
		[OriginalName("ErrFightFormationRoleIdNotMatch")]
		ErrFightFormationRoleIdNotMatch,
		// Token: 0x0400AB82 RID: 43906
		[OriginalName("ErrFightFormationRoleCountNotMatch")]
		ErrFightFormationRoleCountNotMatch,
		// Token: 0x0400AB83 RID: 43907
		[OriginalName("ErrFightFormationRoleCareerNotMatch")]
		ErrFightFormationRoleCareerNotMatch,
		// Token: 0x0400AB84 RID: 43908
		[OriginalName("ErrFightFormationRoleElementNotMatch")]
		ErrFightFormationRoleElementNotMatch,
		// Token: 0x0400AB85 RID: 43909
		[OriginalName("ErrFightFormationCannotTrial")]
		ErrFightFormationCannotTrial,
		// Token: 0x0400AB86 RID: 43910
		[OriginalName("ErrFightFormationTrialRoleNotMatch")]
		ErrFightFormationTrialRoleNotMatch,
		// Token: 0x0400AB87 RID: 43911
		[OriginalName("ErrFormationOverSize")]
		ErrFormationOverSize,
		// Token: 0x0400AB88 RID: 43912
		[OriginalName("ErrSwitchRoleIsDead")]
		ErrSwitchRoleIsDead,
		// Token: 0x0400AB89 RID: 43913
		[OriginalName("ErrUpdateFormationCurRoleIsDead")]
		ErrUpdateFormationCurRoleIsDead,
		// Token: 0x0400AB8A RID: 43914
		[OriginalName("ErrUpdateFormationRoleIdsIsNull")]
		ErrUpdateFormationRoleIdsIsNull,
		// Token: 0x0400AB8B RID: 43915
		[OriginalName("ErrFormationIdOutOfRange")]
		ErrFormationIdOutOfRange,
		// Token: 0x0400AB8C RID: 43916
		[OriginalName("ErrCanNotCancelCurFormation")]
		ErrCanNotCancelCurFormation,
		// Token: 0x0400AB8D RID: 43917
		[OriginalName("ErrCurRoleNotInFormationRoleIds")]
		ErrCurRoleNotInFormationRoleIds,
		// Token: 0x0400AB8E RID: 43918
		[OriginalName("ErrUpateFormationNotInSingleWorld")]
		ErrUpateFormationNotInSingleWorld,
		// Token: 0x0400AB8F RID: 43919
		[OriginalName("ErrSwitchRoleTypeSignleWorld")]
		ErrSwitchRoleTypeSignleWorld,
		// Token: 0x0400AB90 RID: 43920
		[OriginalName("ErrSwitchRoleTypeMultiWorld")]
		ErrSwitchRoleTypeMultiWorld,
		// Token: 0x0400AB91 RID: 43921
		[OriginalName("ErrSwitchRoleTypeFbInstance")]
		ErrSwitchRoleTypeFbInstance,
		// Token: 0x0400AB92 RID: 43922
		[OriginalName("ErrSwitchRoleTypeUndefine")]
		ErrSwitchRoleTypeUndefine,
		// Token: 0x0400AB93 RID: 43923
		[OriginalName("ErrSingWorldCanNotUpdateFightRoles")]
		ErrSingWorldCanNotUpdateFightRoles,
		// Token: 0x0400AB94 RID: 43924
		[OriginalName("ErrUpdateFightRolesIsNull")]
		ErrUpdateFightRolesIsNull,
		// Token: 0x0400AB95 RID: 43925
		[OriginalName("ErrUpdateFightRolesCurIdNotExist")]
		ErrUpdateFightRolesCurIdNotExist,
		// Token: 0x0400AB96 RID: 43926
		[OriginalName("ErrInStroyCharacterCanNotSwitchRole")]
		ErrInStroyCharacterCanNotSwitchRole,
		// Token: 0x0400AB97 RID: 43927
		[OriginalName("ErrSwitchRoleNotInFightRoles")]
		ErrSwitchRoleNotInFightRoles,
		// Token: 0x0400AB98 RID: 43928
		[OriginalName("ErrCanNotSwitchRepeat")]
		ErrCanNotSwitchRepeat,
		// Token: 0x0400AB99 RID: 43929
		[OriginalName("ErrSwitchRoleEntityIdNotExist")]
		ErrSwitchRoleEntityIdNotExist,
		// Token: 0x0400AB9A RID: 43930
		[OriginalName("ErrSwitchRoleEntityNotExist")]
		ErrSwitchRoleEntityNotExist,
		// Token: 0x0400AB9B RID: 43931
		[OriginalName("ErrSitchRoleEntityIsDead")]
		ErrSitchRoleEntityIsDead,
		// Token: 0x0400AB9C RID: 43932
		[OriginalName("ErrorTeamOperaFail")]
		ErrorTeamOperaFail,
		// Token: 0x0400AB9D RID: 43933
		[OriginalName("ErrorPlayerAlreadyHaveTeam")]
		ErrorPlayerAlreadyHaveTeam,
		// Token: 0x0400AB9E RID: 43934
		[OriginalName("ErrorTeamInviteContentInvalid")]
		ErrorTeamInviteContentInvalid,
		// Token: 0x0400AB9F RID: 43935
		[OriginalName("ErrorPlayerInBanTime")]
		ErrorPlayerInBanTime,
		// Token: 0x0400ABA0 RID: 43936
		[OriginalName("ErrorPlayerInInviteCd")]
		ErrorPlayerInInviteCd,
		// Token: 0x0400ABA1 RID: 43937
		[OriginalName("ErrorPlayerAlreadyInTeam")]
		ErrorPlayerAlreadyInTeam,
		// Token: 0x0400ABA2 RID: 43938
		[OriginalName("ErrorKickOutPermissionNotEnough")]
		ErrorKickOutPermissionNotEnough,
		// Token: 0x0400ABA3 RID: 43939
		[OriginalName("ErrorTeamIsFull")]
		ErrorTeamIsFull,
		// Token: 0x0400ABA4 RID: 43940
		[OriginalName("ErrorTeamServiceNotReady")]
		ErrorTeamServiceNotReady,
		// Token: 0x0400ABA5 RID: 43941
		[OriginalName("ErrorTeamPlayerJoinRepeat")]
		ErrorTeamPlayerJoinRepeat,
		// Token: 0x0400ABA6 RID: 43942
		[OriginalName("ErrorPlayerNotInTeam")]
		ErrorPlayerNotInTeam,
		// Token: 0x0400ABA7 RID: 43943
		[OriginalName("ErrorInvitePlayerNotExist")]
		ErrorInvitePlayerNotExist,
		// Token: 0x0400ABA8 RID: 43944
		[OriginalName("ErrorKickPlayerNotInTeam")]
		ErrorKickPlayerNotInTeam,
		// Token: 0x0400ABA9 RID: 43945
		[OriginalName("ErrorDismissPermissionNotEnough")]
		ErrorDismissPermissionNotEnough,
		// Token: 0x0400ABAA RID: 43946
		[OriginalName("ErrorTeamRoleIdNotActive")]
		ErrorTeamRoleIdNotActive,
		// Token: 0x0400ABAB RID: 43947
		[OriginalName("ErrorTeamRoleIdRepeat")]
		ErrorTeamRoleIdRepeat,
		// Token: 0x0400ABAC RID: 43948
		[OriginalName("ErrorJoinOtherWorldOtherNotExist")]
		ErrorJoinOtherWorldOtherNotExist,
		// Token: 0x0400ABAD RID: 43949
		[OriginalName("ErrorJoinOtherWorldOtherNotInScene")]
		ErrorJoinOtherWorldOtherNotInScene,
		// Token: 0x0400ABAE RID: 43950
		[OriginalName("ErrorJoinOtherWorldSceneNotExist")]
		ErrorJoinOtherWorldSceneNotExist,
		// Token: 0x0400ABAF RID: 43951
		[OriginalName("ErrorTeamNotExist")]
		ErrorTeamNotExist,
		// Token: 0x0400ABB0 RID: 43952
		[OriginalName("ErrRewardCfgNotFound")]
		ErrRewardCfgNotFound,
		// Token: 0x0400ABB1 RID: 43953
		[OriginalName("ErrTeleportIdNotExist")]
		ErrTeleportIdNotExist,
		// Token: 0x0400ABB2 RID: 43954
		[OriginalName("ErrTeleportIdNotActivate")]
		ErrTeleportIdNotActivate,
		// Token: 0x0400ABB3 RID: 43955
		[OriginalName("ErrTeleportCreatureIdNotExist")]
		ErrTeleportCreatureIdNotExist,
		// Token: 0x0400ABB4 RID: 43956
		[OriginalName("ErrTeleportIdAlreadyActivate")]
		ErrTeleportIdAlreadyActivate,
		// Token: 0x0400ABB5 RID: 43957
		[OriginalName("ErrTeleportGmGetPlayerFailed")]
		ErrTeleportGmGetPlayerFailed,
		// Token: 0x0400ABB6 RID: 43958
		[OriginalName("ErrTeleportGmGetCreatureGenCfgFailed")]
		ErrTeleportGmGetCreatureGenCfgFailed,
		// Token: 0x0400ABB7 RID: 43959
		[OriginalName("ErrTgmNotExitst")]
		ErrTgmNotExitst,
		// Token: 0x0400ABB8 RID: 43960
		[OriginalName("ErrTgmNotPlayer")]
		ErrTgmNotPlayer,
		// Token: 0x0400ABB9 RID: 43961
		[OriginalName("ErrTgmNotGenCfg")]
		ErrTgmNotGenCfg,
		// Token: 0x0400ABBA RID: 43962
		[OriginalName("ErrTgmInsId")]
		ErrTgmInsId,
		// Token: 0x0400ABBB RID: 43963
		[OriginalName("ErrTeleportEntityNotExist")]
		ErrTeleportEntityNotExist,
		// Token: 0x0400ABBC RID: 43964
		[OriginalName("ErrTeleportComponentNotExist")]
		ErrTeleportComponentNotExist,
		// Token: 0x0400ABBD RID: 43965
		[OriginalName("ErrTeleportComponentNotMatch")]
		ErrTeleportComponentNotMatch,
		// Token: 0x0400ABBE RID: 43966
		[OriginalName("ErrAreaEnterRepeated")]
		ErrAreaEnterRepeated,
		// Token: 0x0400ABBF RID: 43967
		[OriginalName("ErrAreaIdNotExist")]
		ErrAreaIdNotExist,
		// Token: 0x0400ABC0 RID: 43968
		[OriginalName("ErrAreaIdNoNeedRecord")]
		ErrAreaIdNoNeedRecord,
		// Token: 0x0400ABC1 RID: 43969
		[OriginalName("ErrPlayerIsNotDead")]
		ErrPlayerIsNotDead,
		// Token: 0x0400ABC2 RID: 43970
		[OriginalName("ErrPlayerCanNotRevive")]
		ErrPlayerCanNotRevive,
		// Token: 0x0400ABC3 RID: 43971
		[OriginalName("ErrPlayerReviveCountReachMax")]
		ErrPlayerReviveCountReachMax,
		// Token: 0x0400ABC4 RID: 43972
		[OriginalName("ErrPlayerReviveDelayNotReach")]
		ErrPlayerReviveDelayNotReach,
		// Token: 0x0400ABC5 RID: 43973
		[OriginalName("ErrAutoReviveNotRequest")]
		ErrAutoReviveNotRequest,
		// Token: 0x0400ABC6 RID: 43974
		[OriginalName("ErrReviveRegionExisted")]
		ErrReviveRegionExisted,
		// Token: 0x0400ABC7 RID: 43975
		[OriginalName("ErrReviveRegionNotExisted")]
		ErrReviveRegionNotExisted,
		// Token: 0x0400ABC8 RID: 43976
		[OriginalName("ErrReviveRegionConfigNotExist")]
		ErrReviveRegionConfigNotExist,
		// Token: 0x0400ABC9 RID: 43977
		[OriginalName("ErrCanNotUseItemRevive")]
		ErrCanNotUseItemRevive,
		// Token: 0x0400ABCA RID: 43978
		[OriginalName("ErrIsMatching")]
		ErrIsMatching,
		// Token: 0x0400ABCB RID: 43979
		[OriginalName("ErrNotInMatcing")]
		ErrNotInMatcing,
		// Token: 0x0400ABCC RID: 43980
		[OriginalName("ErrMatchPoolNotExist")]
		ErrMatchPoolNotExist,
		// Token: 0x0400ABCD RID: 43981
		[OriginalName("ErrNotFindMatchResult")]
		ErrNotFindMatchResult,
		// Token: 0x0400ABCE RID: 43982
		[OriginalName("ErrConfirmResultRepeat")]
		ErrConfirmResultRepeat,
		// Token: 0x0400ABCF RID: 43983
		[OriginalName("ErrAlreadyHaveFbTeam")]
		ErrAlreadyHaveFbTeam,
		// Token: 0x0400ABD0 RID: 43984
		[OriginalName("ErrFbTeamNotExist")]
		ErrFbTeamNotExist,
		// Token: 0x0400ABD1 RID: 43985
		[OriginalName("ErrPlayerNotInFbTeam")]
		ErrPlayerNotInFbTeam,
		// Token: 0x0400ABD2 RID: 43986
		[OriginalName("ErrHostCanNotReady")]
		ErrHostCanNotReady,
		// Token: 0x0400ABD3 RID: 43987
		[OriginalName("ErrChangeReadyRepeat")]
		ErrChangeReadyRepeat,
		// Token: 0x0400ABD4 RID: 43988
		[OriginalName("ErrFbTeamHaveSameRole")]
		ErrFbTeamHaveSameRole,
		// Token: 0x0400ABD5 RID: 43989
		[OriginalName("ErrReadyStateCanNotChangeRole")]
		ErrReadyStateCanNotChangeRole,
		// Token: 0x0400ABD6 RID: 43990
		[OriginalName("ErrChangeSameRole")]
		ErrChangeSameRole,
		// Token: 0x0400ABD7 RID: 43991
		[OriginalName("ErrNotHaveKickPermission")]
		ErrNotHaveKickPermission,
		// Token: 0x0400ABD8 RID: 43992
		[OriginalName("ErrBeKickNotInFbTeam")]
		ErrBeKickNotInFbTeam,
		// Token: 0x0400ABD9 RID: 43993
		[OriginalName("ErrNotHaveFightPermission")]
		ErrNotHaveFightPermission,
		// Token: 0x0400ABDA RID: 43994
		[OriginalName("ErrFbTeamNotAllReady")]
		ErrFbTeamNotAllReady,
		// Token: 0x0400ABDB RID: 43995
		[OriginalName("ErrFbInstIdNotExist")]
		ErrFbInstIdNotExist,
		// Token: 0x0400ABDC RID: 43996
		[OriginalName("ErrFbMatchRoleNotMatch")]
		ErrFbMatchRoleNotMatch,
		// Token: 0x0400ABDD RID: 43997
		[OriginalName("ErrSingleInstCanNotMatch")]
		ErrSingleInstCanNotMatch,
		// Token: 0x0400ABDE RID: 43998
		[OriginalName("ErrWaitOtherEnterSceneForbidMatch")]
		ErrWaitOtherEnterSceneForbidMatch,
		// Token: 0x0400ABDF RID: 43999
		[OriginalName("ErrIsEnteringOtherSceneForbidMatch")]
		ErrIsEnteringOtherSceneForbidMatch,
		// Token: 0x0400ABE0 RID: 44000
		[OriginalName("InstPlayBtObjNotFound")]
		InstPlayBtObjNotFound,
		// Token: 0x0400ABE1 RID: 44001
		[OriginalName("InstPlayNotSuccess")]
		InstPlayNotSuccess,
		// Token: 0x0400ABE2 RID: 44002
		[OriginalName("InstPlayAlreadyGetReward")]
		InstPlayAlreadyGetReward,
		// Token: 0x0400ABE3 RID: 44003
		[OriginalName("InstPlayExchangeRewardFail")]
		InstPlayExchangeRewardFail,
		// Token: 0x0400ABE4 RID: 44004
		[OriginalName("InstPlaySetterRepeat")]
		InstPlaySetterRepeat,
		// Token: 0x0400ABE5 RID: 44005
		[OriginalName("InstEntranceNotUnlock")]
		InstEntranceNotUnlock,
		// Token: 0x0400ABE6 RID: 44006
		[OriginalName("InstEntranceNotOpen")]
		InstEntranceNotOpen,
		// Token: 0x0400ABE7 RID: 44007
		[OriginalName("EnterInstLevelNotEnough")]
		EnterInstLevelNotEnough,
		// Token: 0x0400ABE8 RID: 44008
		[OriginalName("EnterInstWorldLevelNotEnough")]
		EnterInstWorldLevelNotEnough,
		// Token: 0x0400ABE9 RID: 44009
		[OriginalName("EnterInstQuestNotEnough")]
		EnterInstQuestNotEnough,
		// Token: 0x0400ABEA RID: 44010
		[OriginalName("ErrForbidEnterInstInMatch")]
		ErrForbidEnterInstInMatch,
		// Token: 0x0400ABEB RID: 44011
		[OriginalName("ErrForbidEnterInstInEnteringOtherWorld")]
		ErrForbidEnterInstInEnteringOtherWorld,
		// Token: 0x0400ABEC RID: 44012
		[OriginalName("ErrForbidEnterInstInWaitingOtherEnterWorld")]
		ErrForbidEnterInstInWaitingOtherEnterWorld,
		// Token: 0x0400ABED RID: 44013
		[OriginalName("ErrEnterInstTypeNotMatch")]
		ErrEnterInstTypeNotMatch,
		// Token: 0x0400ABEE RID: 44014
		[OriginalName("ErrNotHaveGetRewardCount")]
		ErrNotHaveGetRewardCount,
		// Token: 0x0400ABEF RID: 44015
		[OriginalName("ErrInMatching")]
		ErrInMatching,
		// Token: 0x0400ABF0 RID: 44016
		[OriginalName("ErrNotInMatching")]
		ErrNotInMatching,
		// Token: 0x0400ABF1 RID: 44017
		[OriginalName("ErrNotFindValidMatchServer")]
		ErrNotFindValidMatchServer,
		// Token: 0x0400ABF2 RID: 44018
		[OriginalName("ErrNotFindMatchServerPrx")]
		ErrNotFindMatchServerPrx,
		// Token: 0x0400ABF3 RID: 44019
		[OriginalName("ErrNotHaveMatchTeamInfo")]
		ErrNotHaveMatchTeamInfo,
		// Token: 0x0400ABF4 RID: 44020
		[OriginalName("ErrAlreadyConfirmMatchResult")]
		ErrAlreadyConfirmMatchResult,
		// Token: 0x0400ABF5 RID: 44021
		[OriginalName("ErrMatchTeamNotInReadyState")]
		ErrMatchTeamNotInReadyState,
		// Token: 0x0400ABF6 RID: 44022
		[OriginalName("ErrMatchRoleNotActive")]
		ErrMatchRoleNotActive,
		// Token: 0x0400ABF7 RID: 44023
		[OriginalName("ErrMatchReadyRepeat")]
		ErrMatchReadyRepeat,
		// Token: 0x0400ABF8 RID: 44024
		[OriginalName("ErrMatchPlayerNotReady")]
		ErrMatchPlayerNotReady,
		// Token: 0x0400ABF9 RID: 44025
		[OriginalName("ErrMatchNotHostCanNotKick")]
		ErrMatchNotHostCanNotKick,
		// Token: 0x0400ABFA RID: 44026
		[OriginalName("ErrMatchNotHostCanNotSetMatching")]
		ErrMatchNotHostCanNotSetMatching,
		// Token: 0x0400ABFB RID: 44027
		[OriginalName("ErrSetMatchFlagRepeat")]
		ErrSetMatchFlagRepeat,
		// Token: 0x0400ABFC RID: 44028
		[OriginalName("ErrPlayerNotInMatchTeam")]
		ErrPlayerNotInMatchTeam,
		// Token: 0x0400ABFD RID: 44029
		[OriginalName("ErrGetMatchPoolFail")]
		ErrGetMatchPoolFail,
		// Token: 0x0400ABFE RID: 44030
		[OriginalName("ErrPlayerInMatchPool")]
		ErrPlayerInMatchPool,
		// Token: 0x0400ABFF RID: 44031
		[OriginalName("ErrPlayerNotInMatchPool")]
		ErrPlayerNotInMatchPool,
		// Token: 0x0400AC00 RID: 44032
		[OriginalName("ErrPlayerInMatchTeamCanNotCancel")]
		ErrPlayerInMatchTeamCanNotCancel,
		// Token: 0x0400AC01 RID: 44033
		[OriginalName("ErrPlayerIsConfirmResult")]
		ErrPlayerIsConfirmResult,
		// Token: 0x0400AC02 RID: 44034
		[OriginalName("ErrNotFindMatchTeam")]
		ErrNotFindMatchTeam,
		// Token: 0x0400AC03 RID: 44035
		[OriginalName("ErrPlayerIsReadyCanNotChangeRole")]
		ErrPlayerIsReadyCanNotChangeRole,
		// Token: 0x0400AC04 RID: 44036
		[OriginalName("ErrNotHostCanNotSetMultRoles")]
		ErrNotHostCanNotSetMultRoles,
		// Token: 0x0400AC05 RID: 44037
		[OriginalName("ErrCanNotSetRepeatRole")]
		ErrCanNotSetRepeatRole,
		// Token: 0x0400AC06 RID: 44038
		[OriginalName("ErrPlayerNotReadyCanNotCancel")]
		ErrPlayerNotReadyCanNotCancel,
		// Token: 0x0400AC07 RID: 44039
		[OriginalName("ErrRoleRepeatCanNotReady")]
		ErrRoleRepeatCanNotReady,
		// Token: 0x0400AC08 RID: 44040
		[OriginalName("ErrBeKickNotInMatchTeam")]
		ErrBeKickNotInMatchTeam,
		// Token: 0x0400AC09 RID: 44041
		[OriginalName("ErrNotHostCanNotKick")]
		ErrNotHostCanNotKick,
		// Token: 0x0400AC0A RID: 44042
		[OriginalName("ErrNotHostCanNotSetTeamState")]
		ErrNotHostCanNotSetTeamState,
		// Token: 0x0400AC0B RID: 44043
		[OriginalName("ErrTeamMatchingCanNotStartInst")]
		ErrTeamMatchingCanNotStartInst,
		// Token: 0x0400AC0C RID: 44044
		[OriginalName("ErrMatchTeamHavePlayerNotReady")]
		ErrMatchTeamHavePlayerNotReady,
		// Token: 0x0400AC0D RID: 44045
		[OriginalName("ErrNotHostCanNotEnterInst")]
		ErrNotHostCanNotEnterInst,
		// Token: 0x0400AC0E RID: 44046
		[OriginalName("ErrMatchTeamIsNotEnterInstState")]
		ErrMatchTeamIsNotEnterInstState,
		// Token: 0x0400AC0F RID: 44047
		[OriginalName("ErrMatchInstIdNotExist")]
		ErrMatchInstIdNotExist,
		// Token: 0x0400AC10 RID: 44048
		[OriginalName("ErrSingleInstanceCanNotMatch")]
		ErrSingleInstanceCanNotMatch,
		// Token: 0x0400AC11 RID: 44049
		[OriginalName("ErrOnlineStateCanNotMatch")]
		ErrOnlineStateCanNotMatch,
		// Token: 0x0400AC12 RID: 44050
		[OriginalName("ErrTeamHaveSameRoleCanNotBegin")]
		ErrTeamHaveSameRoleCanNotBegin,
		// Token: 0x0400AC13 RID: 44051
		[OriginalName("ErrNotJoinChatChannel")]
		ErrNotJoinChatChannel,
		// Token: 0x0400AC14 RID: 44052
		[OriginalName("ErrChatChannelNotFound")]
		ErrChatChannelNotFound,
		// Token: 0x0400AC15 RID: 44053
		[OriginalName("ErrChatChannelTypeNotMatch")]
		ErrChatChannelTypeNotMatch,
		// Token: 0x0400AC16 RID: 44054
		[OriginalName("ErrChatContentTooLong")]
		ErrChatContentTooLong,
		// Token: 0x0400AC17 RID: 44055
		[OriginalName("ErrFightRoleIsAllDied")]
		ErrFightRoleIsAllDied,
		// Token: 0x0400AC18 RID: 44056
		[OriginalName("ErrLoadingSceneIdNotMatch")]
		ErrLoadingSceneIdNotMatch,
		// Token: 0x0400AC19 RID: 44057
		[OriginalName("ErrLoadingPlayerNotInScene")]
		ErrLoadingPlayerNotInScene,
		// Token: 0x0400AC1A RID: 44058
		[OriginalName("ErrPlayerIsSceneLoadingCanNotBeKick")]
		ErrPlayerIsSceneLoadingCanNotBeKick,
		// Token: 0x0400AC1B RID: 44059
		[OriginalName("ErrTeamPlayerIsSceneLoadingCanNotDissolve")]
		ErrTeamPlayerIsSceneLoadingCanNotDissolve,
		// Token: 0x0400AC1C RID: 44060
		[OriginalName("ErrIsSceneLoadingCanNotDissolve")]
		ErrIsSceneLoadingCanNotDissolve,
		// Token: 0x0400AC1D RID: 44061
		[OriginalName("ErrSceneLoadingCanNotEnterInst")]
		ErrSceneLoadingCanNotEnterInst,
		// Token: 0x0400AC1E RID: 44062
		[OriginalName("ErrActivateResetPointNotEntity")]
		ErrActivateResetPointNotEntity,
		// Token: 0x0400AC1F RID: 44063
		[OriginalName("ErrHostIsLoadingScene")]
		ErrHostIsLoadingScene,
		// Token: 0x0400AC20 RID: 44064
		[OriginalName("ErrHostIsLoadingSceneCanNotApply")]
		ErrHostIsLoadingSceneCanNotApply,
		// Token: 0x0400AC21 RID: 44065
		[OriginalName("ErrIsLoadingSceneCanNotAcceptApply")]
		ErrIsLoadingSceneCanNotAcceptApply,
		// Token: 0x0400AC22 RID: 44066
		[OriginalName("ErrNotFindHostWorldScene")]
		ErrNotFindHostWorldScene,
		// Token: 0x0400AC23 RID: 44067
		[OriginalName("ErrCanNotRepeatCreateNeedSaveScene")]
		ErrCanNotRepeatCreateNeedSaveScene,
		// Token: 0x0400AC24 RID: 44068
		[OriginalName("DeadStateCanNotAgreeOherEnter")]
		DeadStateCanNotAgreeOherEnter,
		// Token: 0x0400AC25 RID: 44069
		[OriginalName("HostIsDeadStateCanNotEnter")]
		HostIsDeadStateCanNotEnter,
		// Token: 0x0400AC26 RID: 44070
		[OriginalName("ErrSceneIsLoadingCanNotLeave")]
		ErrSceneIsLoadingCanNotLeave,
		// Token: 0x0400AC27 RID: 44071
		[OriginalName("ErrInstCanNotReChallenge")]
		ErrInstCanNotReChallenge,
		// Token: 0x0400AC28 RID: 44072
		[OriginalName("ErrInstMemberNotEnoughCanNotReChallenge")]
		ErrInstMemberNotEnoughCanNotReChallenge,
		// Token: 0x0400AC29 RID: 44073
		[OriginalName("ErrInstHavePlayerLeaveCanNotReChallenge")]
		ErrInstHavePlayerLeaveCanNotReChallenge,
		// Token: 0x0400AC2A RID: 44074
		[OriginalName("ErrInstHavePlayerNotDeadCanNotReChallenge")]
		ErrInstHavePlayerNotDeadCanNotReChallenge,
		// Token: 0x0400AC2B RID: 44075
		[OriginalName("ErrInstNotSettleCanNotReChallenge")]
		ErrInstNotSettleCanNotReChallenge,
		// Token: 0x0400AC2C RID: 44076
		[OriginalName("ErrInstCanNotRepetApplyRechallenge")]
		ErrInstCanNotRepetApplyRechallenge,
		// Token: 0x0400AC2D RID: 44077
		[OriginalName("ErrInstCanNotRepetReceiveRechallenge")]
		ErrInstCanNotRepetReceiveRechallenge,
		// Token: 0x0400AC2E RID: 44078
		[OriginalName("ErrInstOwnerCanIniviteRechallenge")]
		ErrInstOwnerCanIniviteRechallenge,
		// Token: 0x0400AC2F RID: 44079
		[OriginalName("ErrInstOwnerCanNotReceiveRechallenge")]
		ErrInstOwnerCanNotReceiveRechallenge,
		// Token: 0x0400AC30 RID: 44080
		[OriginalName("ErrPlayerIsLogoutCanNotCreateScene")]
		ErrPlayerIsLogoutCanNotCreateScene,
		// Token: 0x0400AC31 RID: 44081
		[OriginalName("ErrPlayerIsCreatingScene")]
		ErrPlayerIsCreatingScene,
		// Token: 0x0400AC32 RID: 44082
		[OriginalName("ErrPlayerCreateSceneFail")]
		ErrPlayerCreateSceneFail,
		// Token: 0x0400AC33 RID: 44083
		[OriginalName("ErrBigWorldCanNotReset")]
		ErrBigWorldCanNotReset,
		// Token: 0x0400AC34 RID: 44084
		[OriginalName("ErrMultiGameModeCanNotReset")]
		ErrMultiGameModeCanNotReset,
		// Token: 0x0400AC35 RID: 44085
		[OriginalName("ErrIsEnterSceneApplyingCanNotDoRepeate")]
		ErrIsEnterSceneApplyingCanNotDoRepeate,
		// Token: 0x0400AC36 RID: 44086
		[OriginalName("ErrIsQueryLobbyFriendDetailCanNotDoRepeate")]
		ErrIsQueryLobbyFriendDetailCanNotDoRepeate,
		// Token: 0x0400AC37 RID: 44087
		[OriginalName("ErrIsQueryLobbyPlayerDetailCanNotDoRepeate")]
		ErrIsQueryLobbyPlayerDetailCanNotDoRepeate,
		// Token: 0x0400AC38 RID: 44088
		[OriginalName("ErrPlayerIsLoadingCanNotDoTeleport")]
		ErrPlayerIsLoadingCanNotDoTeleport,
		// Token: 0x0400AC39 RID: 44089
		[OriginalName("ErrPlayerIsTeleportCanNotDoTeleport")]
		ErrPlayerIsTeleportCanNotDoTeleport,
		// Token: 0x0400AC3A RID: 44090
		[OriginalName("ErrTeleportPositionIllegal")]
		ErrTeleportPositionIllegal,
		// Token: 0x0400AC3B RID: 44091
		[OriginalName("ErrPlayerIsLoadingCanNotRevive")]
		ErrPlayerIsLoadingCanNotRevive,
		// Token: 0x0400AC3C RID: 44092
		[OriginalName("ErrPlayerIsTeleportCanNotRevive")]
		ErrPlayerIsTeleportCanNotRevive,
		// Token: 0x0400AC3D RID: 44093
		[OriginalName("ErrPlayerIsInTeleportCanNotBeKick")]
		ErrPlayerIsInTeleportCanNotBeKick,
		// Token: 0x0400AC3E RID: 44094
		[OriginalName("ErrTeamPlayerIsInTeleportCanNotDissolve")]
		ErrTeamPlayerIsInTeleportCanNotDissolve,
		// Token: 0x0400AC3F RID: 44095
		[OriginalName("ErrHostIsInTeleportCanNotApply")]
		ErrHostIsInTeleportCanNotApply,
		// Token: 0x0400AC40 RID: 44096
		[OriginalName("ErrIsInTeleportCanNotAcceptApply")]
		ErrIsInTeleportCanNotAcceptApply,
		// Token: 0x0400AC41 RID: 44097
		[OriginalName("ErrStrNotIllegal")]
		ErrStrNotIllegal = 400000,
		// Token: 0x0400AC42 RID: 44098
		[OriginalName("ErrBasicInfoPhotoUnlocked")]
		ErrBasicInfoPhotoUnlocked,
		// Token: 0x0400AC43 RID: 44099
		[OriginalName("ErrBasicInfoFrameUnlocked")]
		ErrBasicInfoFrameUnlocked,
		// Token: 0x0400AC44 RID: 44100
		[OriginalName("ErrCanNotGetSelfBasicInfo")]
		ErrCanNotGetSelfBasicInfo,
		// Token: 0x0400AC45 RID: 44101
		[OriginalName("ErrMailNotExist")]
		ErrMailNotExist,
		// Token: 0x0400AC46 RID: 44102
		[OriginalName("ErrMailAlreadyRead")]
		ErrMailAlreadyRead,
		// Token: 0x0400AC47 RID: 44103
		[OriginalName("ErrNoMailCanGet")]
		ErrNoMailCanGet,
		// Token: 0x0400AC48 RID: 44104
		[OriginalName("ErrMailNoAttachment")]
		ErrMailNoAttachment,
		// Token: 0x0400AC49 RID: 44105
		[OriginalName("ErrMailAttachmentIsGet")]
		ErrMailAttachmentIsGet,
		// Token: 0x0400AC4A RID: 44106
		[OriginalName("ErrMailAttachmentNotGet")]
		ErrMailAttachmentNotGet,
		// Token: 0x0400AC4B RID: 44107
		[OriginalName("ErrMailNotRead")]
		ErrMailNotRead,
		// Token: 0x0400AC4C RID: 44108
		[OriginalName("ErrNoMailCanDelete")]
		ErrNoMailCanDelete,
		// Token: 0x0400AC4D RID: 44109
		[OriginalName("ErrMailItemBagFull")]
		ErrMailItemBagFull,
		// Token: 0x0400AC4E RID: 44110
		[OriginalName("ErrMailFuncNotOpen")]
		ErrMailFuncNotOpen,
		// Token: 0x0400AC4F RID: 44111
		[OriginalName("ErrMailOverSize")]
		ErrMailOverSize,
		// Token: 0x0400AC50 RID: 44112
		[OriginalName("ErrMailTakeLimit")]
		ErrMailTakeLimit,
		// Token: 0x0400AC51 RID: 44113
		[OriginalName("ErrMailAttachmentItemInvalidCount")]
		ErrMailAttachmentItemInvalidCount,
		// Token: 0x0400AC52 RID: 44114
		[OriginalName("ErrMailAttachmentItemNoConf")]
		ErrMailAttachmentItemNoConf,
		// Token: 0x0400AC53 RID: 44115
		[OriginalName("ErrMailNoConf")]
		ErrMailNoConf,
		// Token: 0x0400AC54 RID: 44116
		[OriginalName("ErrShopIdNotExit")]
		ErrShopIdNotExit,
		// Token: 0x0400AC55 RID: 44117
		[OriginalName("ErrShopInfoExist")]
		ErrShopInfoExist,
		// Token: 0x0400AC56 RID: 44118
		[OriginalName("ErrShopTimeLimit")]
		ErrShopTimeLimit,
		// Token: 0x0400AC57 RID: 44119
		[OriginalName("ErrShopMoneyId")]
		ErrShopMoneyId,
		// Token: 0x0400AC58 RID: 44120
		[OriginalName("ErrShopNumLimit")]
		ErrShopNumLimit,
		// Token: 0x0400AC59 RID: 44121
		[OriginalName("ErrShopCondLimit")]
		ErrShopCondLimit,
		// Token: 0x0400AC5A RID: 44122
		[OriginalName("ErrShopBankNoExit")]
		ErrShopBankNoExit,
		// Token: 0x0400AC5B RID: 44123
		[OriginalName("ErrShopNoShow")]
		ErrShopNoShow,
		// Token: 0x0400AC5C RID: 44124
		[OriginalName("ErrShopVersion")]
		ErrShopVersion,
		// Token: 0x0400AC5D RID: 44125
		[OriginalName("ErrShopIlligalParam")]
		ErrShopIlligalParam,
		// Token: 0x0400AC5E RID: 44126
		[OriginalName("ErrDragonPoolConf")]
		ErrDragonPoolConf,
		// Token: 0x0400AC5F RID: 44127
		[OriginalName("ErrFullLevel")]
		ErrFullLevel,
		// Token: 0x0400AC60 RID: 44128
		[OriginalName("ErrItemConf")]
		ErrItemConf,
		// Token: 0x0400AC61 RID: 44129
		[OriginalName("ErrNotEnoughItem")]
		ErrNotEnoughItem,
		// Token: 0x0400AC62 RID: 44130
		[OriginalName("NotMingSuTi")]
		NotMingSuTi,
		// Token: 0x0400AC63 RID: 44131
		[OriginalName("HadFinishMingSuTi")]
		HadFinishMingSuTi,
		// Token: 0x0400AC64 RID: 44132
		[OriginalName("MingSuCallEntityFail")]
		MingSuCallEntityFail,
		// Token: 0x0400AC65 RID: 44133
		[OriginalName("ErrDragonPoolFuncNotOpen")]
		ErrDragonPoolFuncNotOpen,
		// Token: 0x0400AC66 RID: 44134
		[OriginalName("ErrWorldLevelHadDown")]
		ErrWorldLevelHadDown,
		// Token: 0x0400AC67 RID: 44135
		[OriginalName("ErrWorldLevelNotDown")]
		ErrWorldLevelNotDown,
		// Token: 0x0400AC68 RID: 44136
		[OriginalName("ErrWorldLevelMin")]
		ErrWorldLevelMin,
		// Token: 0x0400AC69 RID: 44137
		[OriginalName("ErrWorldLevelCd")]
		ErrWorldLevelCd,
		// Token: 0x0400AC6A RID: 44138
		[OriginalName("ErrIsBlockedPlayer")]
		ErrIsBlockedPlayer,
		// Token: 0x0400AC6B RID: 44139
		[OriginalName("ErrIsNotBlockedPlayer")]
		ErrIsNotBlockedPlayer,
		// Token: 0x0400AC6C RID: 44140
		[OriginalName("ErrBlockListCountMax")]
		ErrBlockListCountMax,
		// Token: 0x0400AC6D RID: 44141
		[OriginalName("ErrYouAreBlocked")]
		ErrYouAreBlocked,
		// Token: 0x0400AC6E RID: 44142
		[OriginalName("ErrAlreadyOnFriendList")]
		ErrAlreadyOnFriendList,
		// Token: 0x0400AC6F RID: 44143
		[OriginalName("ErrNotOnFriendList")]
		ErrNotOnFriendList,
		// Token: 0x0400AC70 RID: 44144
		[OriginalName("ErrAlreadyOnFriendApplyList")]
		ErrAlreadyOnFriendApplyList,
		// Token: 0x0400AC71 RID: 44145
		[OriginalName("ErrFriendApplyNotExists")]
		ErrFriendApplyNotExists,
		// Token: 0x0400AC72 RID: 44146
		[OriginalName("ErrFriendListCountMax")]
		ErrFriendListCountMax,
		// Token: 0x0400AC73 RID: 44147
		[OriginalName("ErrInitiatorFriendListCountMax")]
		ErrInitiatorFriendListCountMax,
		// Token: 0x0400AC74 RID: 44148
		[OriginalName("ErrReceiverApplyListCountMax")]
		ErrReceiverApplyListCountMax,
		// Token: 0x0400AC75 RID: 44149
		[OriginalName("ErrCanNotFriendApplySendToSelf")]
		ErrCanNotFriendApplySendToSelf,
		// Token: 0x0400AC76 RID: 44150
		[OriginalName("ErrFriendApplySended")]
		ErrFriendApplySended,
		// Token: 0x0400AC77 RID: 44151
		[OriginalName("ErrFriendRemarkLengthLimit")]
		ErrFriendRemarkLengthLimit,
		// Token: 0x0400AC78 RID: 44152
		[OriginalName("ErrFriendApplyRequestLimit")]
		ErrFriendApplyRequestLimit,
		// Token: 0x0400AC79 RID: 44153
		[OriginalName("ErrFriendRequestEmpty")]
		ErrFriendRequestEmpty,
		// Token: 0x0400AC7A RID: 44154
		[OriginalName("ErrFriendRequestOverSize")]
		ErrFriendRequestOverSize,
		// Token: 0x0400AC7B RID: 44155
		[OriginalName("ErrPayShopNotExists")]
		ErrPayShopNotExists,
		// Token: 0x0400AC7C RID: 44156
		[OriginalName("ErrPayShopDisabled")]
		ErrPayShopDisabled,
		// Token: 0x0400AC7D RID: 44157
		[OriginalName("ErrPayShopGoodsNotExists")]
		ErrPayShopGoodsNotExists,
		// Token: 0x0400AC7E RID: 44158
		[OriginalName("ErrPayShopGoodsDisabled")]
		ErrPayShopGoodsDisabled,
		// Token: 0x0400AC7F RID: 44159
		[OriginalName("ErrPayShopGoodsLocked")]
		ErrPayShopGoodsLocked,
		// Token: 0x0400AC80 RID: 44160
		[OriginalName("ErrPayShopGoodsOutSellTime")]
		ErrPayShopGoodsOutSellTime,
		// Token: 0x0400AC81 RID: 44161
		[OriginalName("ErrPayShopGoodsBuyLimit")]
		ErrPayShopGoodsBuyLimit,
		// Token: 0x0400AC82 RID: 44162
		[OriginalName("ErrPayShopDataChanged")]
		ErrPayShopDataChanged,
		// Token: 0x0400AC83 RID: 44163
		[OriginalName("ErrPayShopIllegalBuyCount")]
		ErrPayShopIllegalBuyCount,
		// Token: 0x0400AC84 RID: 44164
		[OriginalName("ErrPayShopIsDirect")]
		ErrPayShopIsDirect,
		// Token: 0x0400AC85 RID: 44165
		[OriginalName("ErrPayShopIsNotDirect")]
		ErrPayShopIsNotDirect,
		// Token: 0x0400AC86 RID: 44166
		[OriginalName("ErrPayShopTabDisabled")]
		ErrPayShopTabDisabled,
		// Token: 0x0400AC87 RID: 44167
		[OriginalName("ErrMonthCardWithoutValidity")]
		ErrMonthCardWithoutValidity,
		// Token: 0x0400AC88 RID: 44168
		[OriginalName("ErrMonthCardUpdateConfNotExist")]
		ErrMonthCardUpdateConfNotExist,
		// Token: 0x0400AC89 RID: 44169
		[OriginalName("ErrMonthCardDaysMax")]
		ErrMonthCardDaysMax,
		// Token: 0x0400AC8A RID: 44170
		[OriginalName("ErrMonthCardRewardGot")]
		ErrMonthCardRewardGot,
		// Token: 0x0400AC8B RID: 44171
		[OriginalName("ErrMonthCardConfNotExist")]
		ErrMonthCardConfNotExist,
		// Token: 0x0400AC8C RID: 44172
		[OriginalName("ErrIsNotSpecialItem")]
		ErrIsNotSpecialItem,
		// Token: 0x0400AC8D RID: 44173
		[OriginalName("ErrNoEquipSpecialItem")]
		ErrNoEquipSpecialItem,
		// Token: 0x0400AC8E RID: 44174
		[OriginalName("ErrNoValidBattlePass")]
		ErrNoValidBattlePass,
		// Token: 0x0400AC8F RID: 44175
		[OriginalName("ErrBattlePassRewardNotFound")]
		ErrBattlePassRewardNotFound,
		// Token: 0x0400AC90 RID: 44176
		[OriginalName("ErrBattlePassNotPaid")]
		ErrBattlePassNotPaid,
		// Token: 0x0400AC91 RID: 44177
		[OriginalName("ErrBattlePassIsPaid")]
		ErrBattlePassIsPaid,
		// Token: 0x0400AC92 RID: 44178
		[OriginalName("ErrBattlePassRewardLocked")]
		ErrBattlePassRewardLocked,
		// Token: 0x0400AC93 RID: 44179
		[OriginalName("ErrBattlePassRewardTaken")]
		ErrBattlePassRewardTaken,
		// Token: 0x0400AC94 RID: 44180
		[OriginalName("ErrBattlePassCanNotRepeatActive")]
		ErrBattlePassCanNotRepeatActive,
		// Token: 0x0400AC95 RID: 44181
		[OriginalName("BattlePassNoRecurringReward")]
		BattlePassNoRecurringReward,
		// Token: 0x0400AC96 RID: 44182
		[OriginalName("ErrBattlePassIsAdvanced")]
		ErrBattlePassIsAdvanced,
		// Token: 0x0400AC97 RID: 44183
		[OriginalName("ErrBattlePassTaskNotFound")]
		ErrBattlePassTaskNotFound,
		// Token: 0x0400AC98 RID: 44184
		[OriginalName("ErrBattlePassTaskNotFinished")]
		ErrBattlePassTaskNotFinished,
		// Token: 0x0400AC99 RID: 44185
		[OriginalName("ErrBattlePassTaskTaken")]
		ErrBattlePassTaskTaken,
		// Token: 0x0400AC9A RID: 44186
		[OriginalName("ErrBattlePassExpIsFull")]
		ErrBattlePassExpIsFull,
		// Token: 0x0400AC9B RID: 44187
		[OriginalName("ErrAdviceNotFound")]
		ErrAdviceNotFound,
		// Token: 0x0400AC9C RID: 44188
		[OriginalName("ErrConjunctionCanNotWord")]
		ErrConjunctionCanNotWord,
		// Token: 0x0400AC9D RID: 44189
		[OriginalName("ErrAdviceTextNotExists")]
		ErrAdviceTextNotExists,
		// Token: 0x0400AC9E RID: 44190
		[OriginalName("ErrAdviceWordNotExists")]
		ErrAdviceWordNotExists,
		// Token: 0x0400AC9F RID: 44191
		[OriginalName("ErrAdviceTemplateNotExists")]
		ErrAdviceTemplateNotExists,
		// Token: 0x0400ACA0 RID: 44192
		[OriginalName("ErrAdviceCellCalcException")]
		ErrAdviceCellCalcException,
		// Token: 0x0400ACA1 RID: 44193
		[OriginalName("ErrIsNotAdviceEntity")]
		ErrIsNotAdviceEntity,
		// Token: 0x0400ACA2 RID: 44194
		[OriginalName("ErrAdviceCreateLimit")]
		ErrAdviceCreateLimit,
		// Token: 0x0400ACA3 RID: 44195
		[OriginalName("ErrAdviceContentCanNotEmpty")]
		ErrAdviceContentCanNotEmpty,
		// Token: 0x0400ACA4 RID: 44196
		[OriginalName("ErrAdviceEntityNotFount")]
		ErrAdviceEntityNotFount,
		// Token: 0x0400ACA5 RID: 44197
		[OriginalName("ErrAdviceVoteLimit")]
		ErrAdviceVoteLimit,
		// Token: 0x0400ACA6 RID: 44198
		[OriginalName("ErrAdviceIsVoteUp")]
		ErrAdviceIsVoteUp,
		// Token: 0x0400ACA7 RID: 44199
		[OriginalName("ErrAdviceIsVoteDown")]
		ErrAdviceIsVoteDown,
		// Token: 0x0400ACA8 RID: 44200
		[OriginalName("ErrNoAdviceItem")]
		ErrNoAdviceItem,
		// Token: 0x0400ACA9 RID: 44201
		[OriginalName("ErrAdviceCreateNotOpen")]
		ErrAdviceCreateNotOpen,
		// Token: 0x0400ACAA RID: 44202
		[OriginalName("ErrAdviceCanNotCreateByVisitor")]
		ErrAdviceCanNotCreateByVisitor,
		// Token: 0x0400ACAB RID: 44203
		[OriginalName("ErrAdviceSetingIsShow")]
		ErrAdviceSetingIsShow,
		// Token: 0x0400ACAC RID: 44204
		[OriginalName("ErrAdviceSetingIsNoShow")]
		ErrAdviceSetingIsNoShow,
		// Token: 0x0400ACAD RID: 44205
		[OriginalName("ErrAdviceUpMaxValue")]
		ErrAdviceUpMaxValue,
		// Token: 0x0400ACAE RID: 44206
		[OriginalName("ErrAdviceDownMaxValue")]
		ErrAdviceDownMaxValue,
		// Token: 0x0400ACAF RID: 44207
		[OriginalName("ProtoVersionCheckFail")]
		ProtoVersionCheckFail,
		// Token: 0x0400ACB0 RID: 44208
		[OriginalName("ProtoMd5CheckFail")]
		ProtoMd5CheckFail,
		// Token: 0x0400ACB1 RID: 44209
		[OriginalName("ConfigVersionCheckFail")]
		ConfigVersionCheckFail,
		// Token: 0x0400ACB2 RID: 44210
		[OriginalName("ConfigMd5CheckFail")]
		ConfigMd5CheckFail,
		// Token: 0x0400ACB3 RID: 44211
		[OriginalName("ErrInvalidMonthCardDays")]
		ErrInvalidMonthCardDays,
		// Token: 0x0400ACB4 RID: 44212
		[OriginalName("ErrMonthCardExtendedDaysMax")]
		ErrMonthCardExtendedDaysMax,
		// Token: 0x0400ACB5 RID: 44213
		[OriginalName("ErrMobileButtonNoCfg")]
		ErrMobileButtonNoCfg,
		// Token: 0x0400ACB6 RID: 44214
		[OriginalName("ErrMoneyWrongPayCount")]
		ErrMoneyWrongPayCount,
		// Token: 0x0400ACB7 RID: 44215
		[OriginalName("ErrMailTextSenderNotFound")]
		ErrMailTextSenderNotFound,
		// Token: 0x0400ACB8 RID: 44216
		[OriginalName("ErrMailTextTitleNotFound")]
		ErrMailTextTitleNotFound,
		// Token: 0x0400ACB9 RID: 44217
		[OriginalName("ErrMailTextContentNotFound")]
		ErrMailTextContentNotFound,
		// Token: 0x0400ACBA RID: 44218
		[OriginalName("ErrAdviceIsNotVoteUp")]
		ErrAdviceIsNotVoteUp,
		// Token: 0x0400ACBB RID: 44219
		[OriginalName("ErrParkourChallengeNoConf")]
		ErrParkourChallengeNoConf,
		// Token: 0x0400ACBC RID: 44220
		[OriginalName("ErrParkourLocationNoConf")]
		ErrParkourLocationNoConf,
		// Token: 0x0400ACBD RID: 44221
		[OriginalName("ErrParkourChallengeNotOpen")]
		ErrParkourChallengeNotOpen,
		// Token: 0x0400ACBE RID: 44222
		[OriginalName("ErrParkourChallengeNoData")]
		ErrParkourChallengeNoData,
		// Token: 0x0400ACBF RID: 44223
		[OriginalName("ErrParkourChallengeTaken")]
		ErrParkourChallengeTaken,
		// Token: 0x0400ACC0 RID: 44224
		[OriginalName("ErrParkourChallengeUnderscore")]
		ErrParkourChallengeUnderscore,
		// Token: 0x0400ACC1 RID: 44225
		[OriginalName("ErrParkourChallengeScoreNoConf")]
		ErrParkourChallengeScoreNoConf,
		// Token: 0x0400ACC2 RID: 44226
		[OriginalName("ErrParkourTakeFail")]
		ErrParkourTakeFail,
		// Token: 0x0400ACC3 RID: 44227
		[OriginalName("ErrShopIllegalBuyCount")]
		ErrShopIllegalBuyCount,
		// Token: 0x0400ACC4 RID: 44228
		[OriginalName("ErrQuestErrTaskId")]
		ErrQuestErrTaskId = 500000,
		// Token: 0x0400ACC5 RID: 44229
		[OriginalName("ErrQuestErrStepId")]
		ErrQuestErrStepId,
		// Token: 0x0400ACC6 RID: 44230
		[OriginalName("ErrQuestErrTaskBag")]
		ErrQuestErrTaskBag,
		// Token: 0x0400ACC7 RID: 44231
		[OriginalName("ErrQuestStepStatusNotCanAccept")]
		ErrQuestStepStatusNotCanAccept,
		// Token: 0x0400ACC8 RID: 44232
		[OriginalName("ErrQuestStepStatusNotCanCommit")]
		ErrQuestStepStatusNotCanCommit,
		// Token: 0x0400ACC9 RID: 44233
		[OriginalName("ErrQuestStepConf")]
		ErrQuestStepConf,
		// Token: 0x0400ACCA RID: 44234
		[OriginalName("ErrQuestStepData")]
		ErrQuestStepData,
		// Token: 0x0400ACCB RID: 44235
		[OriginalName("ErrQuestCanNotAccept")]
		ErrQuestCanNotAccept,
		// Token: 0x0400ACCC RID: 44236
		[OriginalName("ErrAreaQuestDelegationBoardRequest")]
		ErrAreaQuestDelegationBoardRequest,
		// Token: 0x0400ACCD RID: 44237
		[OriginalName("ErrAreaQuestAreaIdErr")]
		ErrAreaQuestAreaIdErr,
		// Token: 0x0400ACCE RID: 44238
		[OriginalName("ErrAreaQuestExpired")]
		ErrAreaQuestExpired,
		// Token: 0x0400ACCF RID: 44239
		[OriginalName("ErrDevoteLevel")]
		ErrDevoteLevel,
		// Token: 0x0400ACD0 RID: 44240
		[OriginalName("ErrDevoteRewardReceived")]
		ErrDevoteRewardReceived,
		// Token: 0x0400ACD1 RID: 44241
		[OriginalName("ErrQuestNotFinish")]
		ErrQuestNotFinish,
		// Token: 0x0400ACD2 RID: 44242
		[OriginalName("ErrDevoteId")]
		ErrDevoteId,
		// Token: 0x0400ACD3 RID: 44243
		[OriginalName("ErrAreaQuestLimit")]
		ErrAreaQuestLimit,
		// Token: 0x0400ACD4 RID: 44244
		[OriginalName("ErrQuestNodeNotActive")]
		ErrQuestNodeNotActive,
		// Token: 0x0400ACD5 RID: 44245
		[OriginalName("ErrQuestNotActiveId")]
		ErrQuestNotActiveId,
		// Token: 0x0400ACD6 RID: 44246
		[OriginalName("ErrQuestNodeNotFound")]
		ErrQuestNodeNotFound,
		// Token: 0x0400ACD7 RID: 44247
		[OriginalName("ErrQuestComNotFound")]
		ErrQuestComNotFound,
		// Token: 0x0400ACD8 RID: 44248
		[OriginalName("ErrQuestTraceType")]
		ErrQuestTraceType,
		// Token: 0x0400ACD9 RID: 44249
		[OriginalName("ErrQuestNotProgress")]
		ErrQuestNotProgress,
		// Token: 0x0400ACDA RID: 44250
		[OriginalName("ErrQuestNoCombatState")]
		ErrQuestNoCombatState,
		// Token: 0x0400ACDB RID: 44251
		[OriginalName("ErrQuestNodeData")]
		ErrQuestNodeData,
		// Token: 0x0400ACDC RID: 44252
		[OriginalName("ErrQuestNotChildQuestNode")]
		ErrQuestNotChildQuestNode,
		// Token: 0x0400ACDD RID: 44253
		[OriginalName("ErrQuestNotClientSubmit")]
		ErrQuestNotClientSubmit,
		// Token: 0x0400ACDE RID: 44254
		[OriginalName("ErrQuestAccepted")]
		ErrQuestAccepted,
		// Token: 0x0400ACDF RID: 44255
		[OriginalName("ErrResourceOccupation")]
		ErrResourceOccupation,
		// Token: 0x0400ACE0 RID: 44256
		[OriginalName("ErrRequestOccupationType")]
		ErrRequestOccupationType,
		// Token: 0x0400ACE1 RID: 44257
		[OriginalName("ErrNotFoundOccupation")]
		ErrNotFoundOccupation,
		// Token: 0x0400ACE2 RID: 44258
		[OriginalName("ErrNotOnlineQuestAccept")]
		ErrNotOnlineQuestAccept,
		// Token: 0x0400ACE3 RID: 44259
		[OriginalName("ErrQuestDestroy")]
		ErrQuestDestroy,
		// Token: 0x0400ACE4 RID: 44260
		[OriginalName("ErrTreeNodeNotFind")]
		ErrTreeNodeNotFind,
		// Token: 0x0400ACE5 RID: 44261
		[OriginalName("ErrTreeNodeNotActive")]
		ErrTreeNodeNotActive,
		// Token: 0x0400ACE6 RID: 44262
		[OriginalName("ErrIsNotChildQuestNode")]
		ErrIsNotChildQuestNode,
		// Token: 0x0400ACE7 RID: 44263
		[OriginalName("ErrChildQuestConditionCanNotSubmit")]
		ErrChildQuestConditionCanNotSubmit,
		// Token: 0x0400ACE8 RID: 44264
		[OriginalName("ErrNodeNotFindAction")]
		ErrNodeNotFindAction,
		// Token: 0x0400ACE9 RID: 44265
		[OriginalName("ErrNodeActionIsFinish")]
		ErrNodeActionIsFinish,
		// Token: 0x0400ACEA RID: 44266
		[OriginalName("ErrNodeActionGetItemIsNotQuestItem")]
		ErrNodeActionGetItemIsNotQuestItem,
		// Token: 0x0400ACEB RID: 44267
		[OriginalName("ErrNodeActionGetItemHasNotFreeSize")]
		ErrNodeActionGetItemHasNotFreeSize,
		// Token: 0x0400ACEC RID: 44268
		[OriginalName("ErrInvalidBtType")]
		ErrInvalidBtType,
		// Token: 0x0400ACED RID: 44269
		[OriginalName("ErrTimerNotFind")]
		ErrTimerNotFind,
		// Token: 0x0400ACEE RID: 44270
		[OriginalName("ErrPreCondition")]
		ErrPreCondition,
		// Token: 0x0400ACEF RID: 44271
		[OriginalName("ErrHandIdItemData")]
		ErrHandIdItemData,
		// Token: 0x0400ACF0 RID: 44272
		[OriginalName("ErrTreeNotFailedNode")]
		ErrTreeNotFailedNode,
		// Token: 0x0400ACF1 RID: 44273
		[OriginalName("ErrTreeNotFailConf")]
		ErrTreeNotFailConf,
		// Token: 0x0400ACF2 RID: 44274
		[OriginalName("ErrTreeNotGiveUpConf")]
		ErrTreeNotGiveUpConf,
		// Token: 0x0400ACF3 RID: 44275
		[OriginalName("ErrTreeNotRollback")]
		ErrTreeNotRollback,
		// Token: 0x0400ACF4 RID: 44276
		[OriginalName("ErrNodeNotFindNpcId")]
		ErrNodeNotFindNpcId,
		// Token: 0x0400ACF5 RID: 44277
		[OriginalName("ErrNotRollbackPermission")]
		ErrNotRollbackPermission,
		// Token: 0x0400ACF6 RID: 44278
		[OriginalName("ErrNotRollbackRepeat")]
		ErrNotRollbackRepeat,
		// Token: 0x0400ACF7 RID: 44279
		[OriginalName("ErrTreeSuspend")]
		ErrTreeSuspend,
		// Token: 0x0400ACF8 RID: 44280
		[OriginalName("ErrPlayerNotInQuestMap")]
		ErrPlayerNotInQuestMap,
		// Token: 0x0400ACF9 RID: 44281
		[OriginalName("ErrSaveNewNotRollback")]
		ErrSaveNewNotRollback,
		// Token: 0x0400ACFA RID: 44282
		[OriginalName("ErrUiPlayType")]
		ErrUiPlayType,
		// Token: 0x0400ACFB RID: 44283
		[OriginalName("ErrOccupationTime")]
		ErrOccupationTime,
		// Token: 0x0400ACFC RID: 44284
		[OriginalName("ErrReleaseTime")]
		ErrReleaseTime,
		// Token: 0x0400ACFD RID: 44285
		[OriginalName("ErrActionSetTime")]
		ErrActionSetTime,
		// Token: 0x0400ACFE RID: 44286
		[OriginalName("ErrForcedOccupationResource")]
		ErrForcedOccupationResource,
		// Token: 0x0400ACFF RID: 44287
		[OriginalName("ErrAddPlayBubble")]
		ErrAddPlayBubble,
		// Token: 0x0400AD00 RID: 44288
		[OriginalName("ErrDisableSwitchOccupation")]
		ErrDisableSwitchOccupation,
		// Token: 0x0400AD01 RID: 44289
		[OriginalName("ErrOpenSystemBoardResultFail")]
		ErrOpenSystemBoardResultFail,
		// Token: 0x0400AD02 RID: 44290
		[OriginalName("ErrEntityNoInhaledComponent")]
		ErrEntityNoInhaledComponent,
		// Token: 0x0400AD03 RID: 44291
		[OriginalName("ErrEntityInhaledStrength")]
		ErrEntityInhaledStrength,
		// Token: 0x0400AD04 RID: 44292
		[OriginalName("ErrDisableSwitchGender")]
		ErrDisableSwitchGender,
		// Token: 0x0400AD05 RID: 44293
		[OriginalName("ErrTapeDefault")]
		ErrTapeDefault = 600000,
		// Token: 0x0400AD06 RID: 44294
		[OriginalName("ErrTapeInvalidPos")]
		ErrTapeInvalidPos,
		// Token: 0x0400AD07 RID: 44295
		[OriginalName("ErrTapeIsNotActiveRole")]
		ErrTapeIsNotActiveRole,
		// Token: 0x0400AD08 RID: 44296
		[OriginalName("ErrTapeItemTypeFail")]
		ErrTapeItemTypeFail,
		// Token: 0x0400AD09 RID: 44297
		[OriginalName("ErrTapeNotExistTapeItem")]
		ErrTapeNotExistTapeItem,
		// Token: 0x0400AD0A RID: 44298
		[OriginalName("ErrTapeNotExistTapeConfig")]
		ErrTapeNotExistTapeConfig,
		// Token: 0x0400AD0B RID: 44299
		[OriginalName("ErrTapeNotExistTapeProps")]
		ErrTapeNotExistTapeProps,
		// Token: 0x0400AD0C RID: 44300
		[OriginalName("ErrTapeHasTakeOnTape")]
		ErrTapeHasTakeOnTape,
		// Token: 0x0400AD0D RID: 44301
		[OriginalName("ErrTapeHasNotTakeOnTape")]
		ErrTapeHasNotTakeOnTape,
		// Token: 0x0400AD0E RID: 44302
		[OriginalName("ErrTapeNotExistTapeQualityConfig")]
		ErrTapeNotExistTapeQualityConfig,
		// Token: 0x0400AD0F RID: 44303
		[OriginalName("ErrTapeNotExistLevelUpExpConfig")]
		ErrTapeNotExistLevelUpExpConfig,
		// Token: 0x0400AD10 RID: 44304
		[OriginalName("ErrTapeInvalidLevelUpExpValue")]
		ErrTapeInvalidLevelUpExpValue,
		// Token: 0x0400AD11 RID: 44305
		[OriginalName("ErrTapeNotExistExpDecayRatioConfig")]
		ErrTapeNotExistExpDecayRatioConfig,
		// Token: 0x0400AD12 RID: 44306
		[OriginalName("ErrTapeLevelUpEqualItem")]
		ErrTapeLevelUpEqualItem,
		// Token: 0x0400AD13 RID: 44307
		[OriginalName("ErrTapeLevelUpRepeatItem")]
		ErrTapeLevelUpRepeatItem,
		// Token: 0x0400AD14 RID: 44308
		[OriginalName("ErrTapeLevelUpInvalidExpItemNum")]
		ErrTapeLevelUpInvalidExpItemNum,
		// Token: 0x0400AD15 RID: 44309
		[OriginalName("ErrTapeLevelUpInvalidExpRate")]
		ErrTapeLevelUpInvalidExpRate,
		// Token: 0x0400AD16 RID: 44310
		[OriginalName("ErrTapeLevelUpInvalidAddExp")]
		ErrTapeLevelUpInvalidAddExp,
		// Token: 0x0400AD17 RID: 44311
		[OriginalName("ErrTapeLevelUpMaxLevel")]
		ErrTapeLevelUpMaxLevel,
		// Token: 0x0400AD18 RID: 44312
		[OriginalName("ErrTapeLevelUpConsumeItemNotEnough")]
		ErrTapeLevelUpConsumeItemNotEnough,
		// Token: 0x0400AD19 RID: 44313
		[OriginalName("ErrTapeLevelUpMaterialLock")]
		ErrTapeLevelUpMaterialLock,
		// Token: 0x0400AD1A RID: 44314
		[OriginalName("ErrTapeTransferEqualItem")]
		ErrTapeTransferEqualItem,
		// Token: 0x0400AD1B RID: 44315
		[OriginalName("ErrTapeTransferQualityNotEqual")]
		ErrTapeTransferQualityNotEqual,
		// Token: 0x0400AD1C RID: 44316
		[OriginalName("ErrTapeTransferSuitNotEqual")]
		ErrTapeTransferSuitNotEqual,
		// Token: 0x0400AD1D RID: 44317
		[OriginalName("ErrTapeTransferMaterialLock")]
		ErrTapeTransferMaterialLock,
		// Token: 0x0400AD1E RID: 44318
		[OriginalName("ErrTapeTransferMaterialEquipped")]
		ErrTapeTransferMaterialEquipped,
		// Token: 0x0400AD1F RID: 44319
		[OriginalName("ErrTapeNotExistTransferPropNumConfig")]
		ErrTapeNotExistTransferPropNumConfig,
		// Token: 0x0400AD20 RID: 44320
		[OriginalName("ErrTapeTransferPropNumIsMax")]
		ErrTapeTransferPropNumIsMax,
		// Token: 0x0400AD21 RID: 44321
		[OriginalName("ErrTapeTransferRandomSubPropFail")]
		ErrTapeTransferRandomSubPropFail,
		// Token: 0x0400AD22 RID: 44322
		[OriginalName("ErrTapeResetTransferHasNotProp")]
		ErrTapeResetTransferHasNotProp,
		// Token: 0x0400AD23 RID: 44323
		[OriginalName("ErrTapeResetTransferMaterialNotEnough")]
		ErrTapeResetTransferMaterialNotEnough,
		// Token: 0x0400AD24 RID: 44324
		[OriginalName("ErrTapeNotExistTapeExpItem")]
		ErrTapeNotExistTapeExpItem,
		// Token: 0x0400AD25 RID: 44325
		[OriginalName("ErrTapeNotExistTapeExpItemConfig")]
		ErrTapeNotExistTapeExpItemConfig,
		// Token: 0x0400AD26 RID: 44326
		[OriginalName("ErrCollectEntityNotExist")]
		ErrCollectEntityNotExist,
		// Token: 0x0400AD27 RID: 44327
		[OriginalName("ErrCollectInvalidEntityMainType")]
		ErrCollectInvalidEntityMainType,
		// Token: 0x0400AD28 RID: 44328
		[OriginalName("ErrRunningLevelPlayNotFind")]
		ErrRunningLevelPlayNotFind,
		// Token: 0x0400AD29 RID: 44329
		[OriginalName("ErrLevelPlayInteractionEntity")]
		ErrLevelPlayInteractionEntity,
		// Token: 0x0400AD2A RID: 44330
		[OriginalName("ErrLevelPlayNotExistByConfId")]
		ErrLevelPlayNotExistByConfId,
		// Token: 0x0400AD2B RID: 44331
		[OriginalName("ErrLevelPlayNotCreate")]
		ErrLevelPlayNotCreate,
		// Token: 0x0400AD2C RID: 44332
		[OriginalName("ErrLevelPlayRewarded")]
		ErrLevelPlayRewarded,
		// Token: 0x0400AD2D RID: 44333
		[OriginalName("ErrLevelPlayInteractionType")]
		ErrLevelPlayInteractionType,
		// Token: 0x0400AD2E RID: 44334
		[OriginalName("ErrLevelPlayNotPlayer")]
		ErrLevelPlayNotPlayer,
		// Token: 0x0400AD2F RID: 44335
		[OriginalName("ErrLevelPlayNotComplete")]
		ErrLevelPlayNotComplete,
		// Token: 0x0400AD30 RID: 44336
		[OriginalName("ErrLevelPlayRewardFail")]
		ErrLevelPlayRewardFail,
		// Token: 0x0400AD31 RID: 44337
		[OriginalName("ErrLevelPlayNotWaitState")]
		ErrLevelPlayNotWaitState,
		// Token: 0x0400AD32 RID: 44338
		[OriginalName("ErrLevelPlayAction")]
		ErrLevelPlayAction,
		// Token: 0x0400AD33 RID: 44339
		[OriginalName("ErrLevelPlayGetRewardLimit")]
		ErrLevelPlayGetRewardLimit,
		// Token: 0x0400AD34 RID: 44340
		[OriginalName("ErrFlowNotExist")]
		ErrFlowNotExist,
		// Token: 0x0400AD35 RID: 44341
		[OriginalName("ErrFlowHaveNotActionWait")]
		ErrFlowHaveNotActionWait,
		// Token: 0x0400AD36 RID: 44342
		[OriginalName("ErrFlowHaveNotTalkWait")]
		ErrFlowHaveNotTalkWait,
		// Token: 0x0400AD37 RID: 44343
		[OriginalName("ErrFlowHaveNotOptionWait")]
		ErrFlowHaveNotOptionWait,
		// Token: 0x0400AD38 RID: 44344
		[OriginalName("ErrFlowInvalidOptionId")]
		ErrFlowInvalidOptionId,
		// Token: 0x0400AD39 RID: 44345
		[OriginalName("ErrInteractFlowCanNotPlay")]
		ErrInteractFlowCanNotPlay,
		// Token: 0x0400AD3A RID: 44346
		[OriginalName("ErrInteractInvalidFlowState")]
		ErrInteractInvalidFlowState,
		// Token: 0x0400AD3B RID: 44347
		[OriginalName("ErrInteractOptionOwnerIsNotFlowOwner")]
		ErrInteractOptionOwnerIsNotFlowOwner,
		// Token: 0x0400AD3C RID: 44348
		[OriginalName("ErrInteractOptionOwnerIsNotActionOwner")]
		ErrInteractOptionOwnerIsNotActionOwner,
		// Token: 0x0400AD3D RID: 44349
		[OriginalName("ErrActionOwnerIsNotEntity")]
		ErrActionOwnerIsNotEntity,
		// Token: 0x0400AD3E RID: 44350
		[OriginalName("ErrActionOwnerNotFound")]
		ErrActionOwnerNotFound,
		// Token: 0x0400AD3F RID: 44351
		[OriginalName("ErrActionSceneNotFound")]
		ErrActionSceneNotFound,
		// Token: 0x0400AD40 RID: 44352
		[OriginalName("ErrActionGroupNotFound")]
		ErrActionGroupNotFound,
		// Token: 0x0400AD41 RID: 44353
		[OriginalName("ErrFinishClientActionFail")]
		ErrFinishClientActionFail,
		// Token: 0x0400AD42 RID: 44354
		[OriginalName("ErrActionHostPlayerNotFound")]
		ErrActionHostPlayerNotFound,
		// Token: 0x0400AD43 RID: 44355
		[OriginalName("ErrActionFail")]
		ErrActionFail,
		// Token: 0x0400AD44 RID: 44356
		[OriginalName("ErrActionPlayerNotFound")]
		ErrActionPlayerNotFound,
		// Token: 0x0400AD45 RID: 44357
		[OriginalName("ErrInteractMultiGameMode")]
		ErrInteractMultiGameMode,
		// Token: 0x0400AD46 RID: 44358
		[OriginalName("ErrInteractAddFlowFail")]
		ErrInteractAddFlowFail,
		// Token: 0x0400AD47 RID: 44359
		[OriginalName("ErrBehaviorTreeOwnerNotFound")]
		ErrBehaviorTreeOwnerNotFound,
		// Token: 0x0400AD48 RID: 44360
		[OriginalName("ErrBehaviorTreeNotFound")]
		ErrBehaviorTreeNotFound,
		// Token: 0x0400AD49 RID: 44361
		[OriginalName("ErrBehaviorTreePending")]
		ErrBehaviorTreePending,
		// Token: 0x0400AD4A RID: 44362
		[OriginalName("ErrBehaviorTreeTimerTypeNotFound")]
		ErrBehaviorTreeTimerTypeNotFound,
		// Token: 0x0400AD4B RID: 44363
		[OriginalName("ErrBehaviorTreeStopTimerFail")]
		ErrBehaviorTreeStopTimerFail,
		// Token: 0x0400AD4C RID: 44364
		[OriginalName("ErrBehaviorTreeTimerCompNotFound")]
		ErrBehaviorTreeTimerCompNotFound,
		// Token: 0x0400AD4D RID: 44365
		[OriginalName("ErrInteractCd")]
		ErrInteractCd,
		// Token: 0x0400AD4E RID: 44366
		[OriginalName("ErrInteractRange")]
		ErrInteractRange,
		// Token: 0x0400AD4F RID: 44367
		[OriginalName("ErrDropPickRange")]
		ErrDropPickRange,
		// Token: 0x0400AD50 RID: 44368
		[OriginalName("ErrBtTmpItemContextNotExist")]
		ErrBtTmpItemContextNotExist,
		// Token: 0x0400AD51 RID: 44369
		[OriginalName("ErrBtTmpItemBtObjNotExist")]
		ErrBtTmpItemBtObjNotExist,
		// Token: 0x0400AD52 RID: 44370
		[OriginalName("ErrPlayerBigWorldNotExist")]
		ErrPlayerBigWorldNotExist,
		// Token: 0x0400AD53 RID: 44371
		[OriginalName("ErrRoleEntityNotExist")]
		ErrRoleEntityNotExist,
		// Token: 0x0400AD54 RID: 44372
		[OriginalName("ErrAddFlowFail")]
		ErrAddFlowFail,
		// Token: 0x0400AD55 RID: 44373
		[OriginalName("ErrInteracting")]
		ErrInteracting,
		// Token: 0x0400AD56 RID: 44374
		[OriginalName("ErrInteractCollectBagFull")]
		ErrInteractCollectBagFull,
		// Token: 0x0400AD57 RID: 44375
		[OriginalName("ErrBtObjIsNotInstPlay")]
		ErrBtObjIsNotInstPlay,
		// Token: 0x0400AD58 RID: 44376
		[OriginalName("ErrReviveConfigNotExist")]
		ErrReviveConfigNotExist,
		// Token: 0x0400AD59 RID: 44377
		[OriginalName("ErrFinishFlowFail")]
		ErrFinishFlowFail,
		// Token: 0x0400AD5A RID: 44378
		[OriginalName("ErrFlowActionFail")]
		ErrFlowActionFail,
		// Token: 0x0400AD5B RID: 44379
		[OriginalName("ErrGmSubmitChildQuestNodeMaxDepth")]
		ErrGmSubmitChildQuestNodeMaxDepth,
		// Token: 0x0400AD5C RID: 44380
		[OriginalName("ErrGmSubmitChildQuestNodeIsNotProgress")]
		ErrGmSubmitChildQuestNodeIsNotProgress,
		// Token: 0x0400AD5D RID: 44381
		[OriginalName("ErrEntityPatrolComponentNotExist")]
		ErrEntityPatrolComponentNotExist,
		// Token: 0x0400AD5E RID: 44382
		[OriginalName("ErrInteractIsNotParticipant")]
		ErrInteractIsNotParticipant,
		// Token: 0x0400AD5F RID: 44383
		[OriginalName("ErrVisionEntityInteractFail")]
		ErrVisionEntityInteractFail,
		// Token: 0x0400AD60 RID: 44384
		[OriginalName("ErrMaxDropTimes")]
		ErrMaxDropTimes,
		// Token: 0x0400AD61 RID: 44385
		[OriginalName("ErrStateEntityMultiHang")]
		ErrStateEntityMultiHang,
		// Token: 0x0400AD62 RID: 44386
		[OriginalName("ErrPlayerLoading")]
		ErrPlayerLoading,
		// Token: 0x0400AD63 RID: 44387
		[OriginalName("ErrPlayerTeleporting")]
		ErrPlayerTeleporting,
		// Token: 0x0400AD64 RID: 44388
		[OriginalName("ErrInteractBtPending")]
		ErrInteractBtPending,
		// Token: 0x0400AD65 RID: 44389
		[OriginalName("ErrInteractDead")]
		ErrInteractDead,
		// Token: 0x0400AD66 RID: 44390
		[OriginalName("ErrMultiHangEntity")]
		ErrMultiHangEntity,
		// Token: 0x0400AD67 RID: 44391
		[OriginalName("ErrRenjuCanNotResetWhenComplete")]
		ErrRenjuCanNotResetWhenComplete,
		// Token: 0x0400AD68 RID: 44392
		[OriginalName("ErrRenjuCanNotMove")]
		ErrRenjuCanNotMove,
		// Token: 0x0400AD69 RID: 44393
		[OriginalName("ErrEntityNotFound")]
		ErrEntityNotFound,
		// Token: 0x0400AD6A RID: 44394
		[OriginalName("ErrSceneHostPlayerNotMatch")]
		ErrSceneHostPlayerNotMatch,
		// Token: 0x0400AD6B RID: 44395
		[OriginalName("ErrVehicleComponentNotFound")]
		ErrVehicleComponentNotFound,
		// Token: 0x0400AD6C RID: 44396
		[OriginalName("ErrVehicleSeatNotFound")]
		ErrVehicleSeatNotFound,
		// Token: 0x0400AD6D RID: 44397
		[OriginalName("ErrVehicleGettingOn")]
		ErrVehicleGettingOn,
		// Token: 0x0400AD6E RID: 44398
		[OriginalName("ErrPortalEntityNotFound")]
		ErrPortalEntityNotFound,
		// Token: 0x0400AD6F RID: 44399
		[OriginalName("ErrPortalCompNotFound")]
		ErrPortalCompNotFound,
		// Token: 0x0400AD70 RID: 44400
		[OriginalName("ErrPortalTeleportPosNotEqual")]
		ErrPortalTeleportPosNotEqual,
		// Token: 0x0400AD71 RID: 44401
		[OriginalName("ErrPlayerNotInVehicle")]
		ErrPlayerNotInVehicle,
		// Token: 0x0400AD72 RID: 44402
		[OriginalName("ErrVehiclePassengerRoleExist")]
		ErrVehiclePassengerRoleExist,
		// Token: 0x0400AD73 RID: 44403
		[OriginalName("ErrCreateVehiclePassengerEntityFail")]
		ErrCreateVehiclePassengerEntityFail,
		// Token: 0x0400AD74 RID: 44404
		[OriginalName("ErrVehiclePassengerNotFound")]
		ErrVehiclePassengerNotFound,
		// Token: 0x0400AD75 RID: 44405
		[OriginalName("ErrCanNotMovePlacement")]
		ErrCanNotMovePlacement,
		// Token: 0x0400AD76 RID: 44406
		[OriginalName("ErrGmSetLimitTeleportDungeon")]
		ErrGmSetLimitTeleportDungeon,
		// Token: 0x0400AD77 RID: 44407
		[OriginalName("ErrMaxSetTagIdDepth")]
		ErrMaxSetTagIdDepth,
		// Token: 0x0400AD78 RID: 44408
		[OriginalName("ErrBeforeSetStateTagId")]
		ErrBeforeSetStateTagId,
		// Token: 0x0400AD79 RID: 44409
		[OriginalName("ErrSetStateTagIdLock")]
		ErrSetStateTagIdLock,
		// Token: 0x0400AD7A RID: 44410
		[OriginalName("ErrDangoMonopolyActivityDataNotFound")]
		ErrDangoMonopolyActivityDataNotFound,
		// Token: 0x0400AD7B RID: 44411
		[OriginalName("ErrDangoMonopolyReqTaskRewardMax")]
		ErrDangoMonopolyReqTaskRewardMax,
		// Token: 0x0400AD7C RID: 44412
		[OriginalName("ErrDangoMonopolyTaskConfigNotFound")]
		ErrDangoMonopolyTaskConfigNotFound,
		// Token: 0x0400AD7D RID: 44413
		[OriginalName("ErrDangoMonopolyTaskNotCompleted")]
		ErrDangoMonopolyTaskNotCompleted,
		// Token: 0x0400AD7E RID: 44414
		[OriginalName("ErrDangoMonopolyTaskRewardHasGet")]
		ErrDangoMonopolyTaskRewardHasGet,
		// Token: 0x0400AD7F RID: 44415
		[OriginalName("ErrDangoMonopolyBoardConfigNotFound")]
		ErrDangoMonopolyBoardConfigNotFound,
		// Token: 0x0400AD80 RID: 44416
		[OriginalName("ErrDangoMonopolyGridRewardNotGet")]
		ErrDangoMonopolyGridRewardNotGet,
		// Token: 0x0400AD81 RID: 44417
		[OriginalName("ErrDangoMonopolyHasNotDiceItem")]
		ErrDangoMonopolyHasNotDiceItem,
		// Token: 0x0400AD82 RID: 44418
		[OriginalName("ErrDangoMonopolyHasNotGridReward")]
		ErrDangoMonopolyHasNotGridReward,
		// Token: 0x0400AD83 RID: 44419
		[OriginalName("ErrDangoMonopolyGridConfigNotFound")]
		ErrDangoMonopolyGridConfigNotFound,
		// Token: 0x0400AD84 RID: 44420
		[OriginalName("ErrDangoMonopolyReqBoardRewardMax")]
		ErrDangoMonopolyReqBoardRewardMax,
		// Token: 0x0400AD85 RID: 44421
		[OriginalName("ErrDangoMonopolyBoardNotCompleted")]
		ErrDangoMonopolyBoardNotCompleted,
		// Token: 0x0400AD86 RID: 44422
		[OriginalName("ErrDangoMonopolyBoardRewardHasGet")]
		ErrDangoMonopolyBoardRewardHasGet,
		// Token: 0x0400AD87 RID: 44423
		[OriginalName("ErrDangoMonopolyActivityConfigNotFound")]
		ErrDangoMonopolyActivityConfigNotFound,
		// Token: 0x0400AD88 RID: 44424
		[OriginalName("ErrDangoMonopolyBoardLock")]
		ErrDangoMonopolyBoardLock,
		// Token: 0x0400AD89 RID: 44425
		[OriginalName("ErrChangeEntityStateActionEntityNotFound")]
		ErrChangeEntityStateActionEntityNotFound,
		// Token: 0x0400AD8A RID: 44426
		[OriginalName("ErrDangoMonopolyDiceNumInvalid")]
		ErrDangoMonopolyDiceNumInvalid,
		// Token: 0x0400AD8B RID: 44427
		[OriginalName("ErrDangoMonopolyBoardCompleted")]
		ErrDangoMonopolyBoardCompleted,
		// Token: 0x0400AD8C RID: 44428
		[OriginalName("ErrLevelSequenceFrameEventCompNotFound")]
		ErrLevelSequenceFrameEventCompNotFound,
		// Token: 0x0400AD8D RID: 44429
		[OriginalName("ErrLevelSequenceFrameEventDataNotFound")]
		ErrLevelSequenceFrameEventDataNotFound,
		// Token: 0x0400AD8E RID: 44430
		[OriginalName("ErrLevelSequenceFrameEventSectionsNotFound")]
		ErrLevelSequenceFrameEventSectionsNotFound,
		// Token: 0x0400AD8F RID: 44431
		[OriginalName("ErrActionCtxInvalid")]
		ErrActionCtxInvalid,
		// Token: 0x0400AD90 RID: 44432
		[OriginalName("ErrActionOwnerInvalid")]
		ErrActionOwnerInvalid,
		// Token: 0x0400AD91 RID: 44433
		[OriginalName("ErrGlobalFixCfgNotFound")]
		ErrGlobalFixCfgNotFound,
		// Token: 0x0400AD92 RID: 44434
		[OriginalName("ErrActionGetItemIsNotQuestItem")]
		ErrActionGetItemIsNotQuestItem,
		// Token: 0x0400AD93 RID: 44435
		[OriginalName("ErrGlobalFixExecuteCountMax")]
		ErrGlobalFixExecuteCountMax,
		// Token: 0x0400AD94 RID: 44436
		[OriginalName("ErrActionGroupCreateTooFrequently")]
		ErrActionGroupCreateTooFrequently,
		// Token: 0x0400AD95 RID: 44437
		[OriginalName("ErrActionGroupParallelTooMuch")]
		ErrActionGroupParallelTooMuch,
		// Token: 0x0400AD96 RID: 44438
		[OriginalName("ErrCanNotRemoveLastTrialRole")]
		ErrCanNotRemoveLastTrialRole,
		// Token: 0x0400AD97 RID: 44439
		[OriginalName("ErrEntityIsNotActivateState")]
		ErrEntityIsNotActivateState,
		// Token: 0x0400AD98 RID: 44440
		[OriginalName("ErrRestoreTrialRoleNotInRegion")]
		ErrRestoreTrialRoleNotInRegion,
		// Token: 0x0400AD99 RID: 44441
		[OriginalName("ErrRemoveTrialRoleNotExist")]
		ErrRemoveTrialRoleNotExist,
		// Token: 0x0400AD9A RID: 44442
		[OriginalName("ErrRemoveLastTrialRole")]
		ErrRemoveLastTrialRole,
		// Token: 0x0400AD9B RID: 44443
		[OriginalName("ErrSaveNodeDeActiveTrialRoleEmpty")]
		ErrSaveNodeDeActiveTrialRoleEmpty,
		// Token: 0x0400AD9C RID: 44444
		[OriginalName("ErrNewHandInItemTypeInvalid")]
		ErrNewHandInItemTypeInvalid,
		// Token: 0x0400AD9D RID: 44445
		[OriginalName("ErrIGameObjectHostIsNotIPlayer")]
		ErrIgameObjectHostIsNotIplayer,
		// Token: 0x0400AD9E RID: 44446
		[OriginalName("ErrSceneWorldNotExist")]
		ErrSceneWorldNotExist = 700000,
		// Token: 0x0400AD9F RID: 44447
		[OriginalName("ErrPlayerNotInScene")]
		ErrPlayerNotInScene,
		// Token: 0x0400ADA0 RID: 44448
		[OriginalName("ErrDropEntityNotExist")]
		ErrDropEntityNotExist,
		// Token: 0x0400ADA1 RID: 44449
		[OriginalName("ErrDropComponentNotExist")]
		ErrDropComponentNotExist,
		// Token: 0x0400ADA2 RID: 44450
		[OriginalName("ErrDropOwnerError")]
		ErrDropOwnerError,
		// Token: 0x0400ADA3 RID: 44451
		[OriginalName("ErrPlayerAlreadyInScene")]
		ErrPlayerAlreadyInScene,
		// Token: 0x0400ADA4 RID: 44452
		[OriginalName("ErrSceneIdParseError")]
		ErrSceneIdParseError,
		// Token: 0x0400ADA5 RID: 44453
		[OriginalName("ErrJoinSceneIdNotExist")]
		ErrJoinSceneIdNotExist,
		// Token: 0x0400ADA6 RID: 44454
		[OriginalName("ErrSceneInviteFail")]
		ErrSceneInviteFail,
		// Token: 0x0400ADA7 RID: 44455
		[OriginalName("ErrSceneInvitePlayerNotExist")]
		ErrSceneInvitePlayerNotExist,
		// Token: 0x0400ADA8 RID: 44456
		[OriginalName("ErrSceneInviteTokenInvalid")]
		ErrSceneInviteTokenInvalid,
		// Token: 0x0400ADA9 RID: 44457
		[OriginalName("ErrSceneInviterNotExist")]
		ErrSceneInviterNotExist,
		// Token: 0x0400ADAA RID: 44458
		[OriginalName("ErrSceneInviteeIdNotMatch")]
		ErrSceneInviteeIdNotMatch,
		// Token: 0x0400ADAB RID: 44459
		[OriginalName("ErrSceneTeamIsFull")]
		ErrSceneTeamIsFull,
		// Token: 0x0400ADAC RID: 44460
		[OriginalName("ErrScenePlayerIsInTeam")]
		ErrScenePlayerIsInTeam,
		// Token: 0x0400ADAD RID: 44461
		[OriginalName("ErrSceneInviteerIsInPlayeInst")]
		ErrSceneInviteerIsInPlayeInst,
		// Token: 0x0400ADAE RID: 44462
		[OriginalName("ErrBeKickerNotInScene")]
		ErrBeKickerNotInScene,
		// Token: 0x0400ADAF RID: 44463
		[OriginalName("ErrorCanNotSceneKickSelf")]
		ErrorCanNotSceneKickSelf,
		// Token: 0x0400ADB0 RID: 44464
		[OriginalName("ErrCanNotKickOtherInPlayInst")]
		ErrCanNotKickOtherInPlayInst,
		// Token: 0x0400ADB1 RID: 44465
		[OriginalName("ErrCanNotKickOtherWhoIsInPlayInst")]
		ErrCanNotKickOtherWhoIsInPlayInst,
		// Token: 0x0400ADB2 RID: 44466
		[OriginalName("ErrNoSceneKickPermission")]
		ErrNoSceneKickPermission,
		// Token: 0x0400ADB3 RID: 44467
		[OriginalName("ErrInviterIsInOtherScene")]
		ErrInviterIsInOtherScene,
		// Token: 0x0400ADB4 RID: 44468
		[OriginalName("ErrInOtherSceneCanNotInvite")]
		ErrInOtherSceneCanNotInvite,
		// Token: 0x0400ADB5 RID: 44469
		[OriginalName("ErrSceneBackSceneFlagError")]
		ErrSceneBackSceneFlagError,
		// Token: 0x0400ADB6 RID: 44470
		[OriginalName("ErrLeaveSceneIdNotMatch")]
		ErrLeaveSceneIdNotMatch,
		// Token: 0x0400ADB7 RID: 44471
		[OriginalName("ErrPrewarTeamAlreadyExist")]
		ErrPrewarTeamAlreadyExist,
		// Token: 0x0400ADB8 RID: 44472
		[OriginalName("ErrPrewarTeamNotExist")]
		ErrPrewarTeamNotExist,
		// Token: 0x0400ADB9 RID: 44473
		[OriginalName("ErrCreatePrewarTeamPermissionNotEnough")]
		ErrCreatePrewarTeamPermissionNotEnough,
		// Token: 0x0400ADBA RID: 44474
		[OriginalName("ErrPrewarTeamInvitePermissionNotEnough")]
		ErrPrewarTeamInvitePermissionNotEnough,
		// Token: 0x0400ADBB RID: 44475
		[OriginalName("ErrPrewarBeInviterNotInScene")]
		ErrPrewarBeInviterNotInScene,
		// Token: 0x0400ADBC RID: 44476
		[OriginalName("ErrPrewarBeInviterInInstance")]
		ErrPrewarBeInviterInInstance,
		// Token: 0x0400ADBD RID: 44477
		[OriginalName("ErrPlayerAlreadyInPrewarTeam")]
		ErrPlayerAlreadyInPrewarTeam,
		// Token: 0x0400ADBE RID: 44478
		[OriginalName("ErrPlayerNotInPrewarTeam")]
		ErrPlayerNotInPrewarTeam,
		// Token: 0x0400ADBF RID: 44479
		[OriginalName("ErrPlayerSetPrewarReadyStateRepeat")]
		ErrPlayerSetPrewarReadyStateRepeat,
		// Token: 0x0400ADC0 RID: 44480
		[OriginalName("ErrPrewarTeamBeKickerNotInScene")]
		ErrPrewarTeamBeKickerNotInScene,
		// Token: 0x0400ADC1 RID: 44481
		[OriginalName("ErrPrewarTeamKickPermissionNotEnough")]
		ErrPrewarTeamKickPermissionNotEnough,
		// Token: 0x0400ADC2 RID: 44482
		[OriginalName("ErrPrewarIniviteTooFrequently")]
		ErrPrewarIniviteTooFrequently,
		// Token: 0x0400ADC3 RID: 44483
		[OriginalName("ErrPrewarJoinInstanceIdNotMatch")]
		ErrPrewarJoinInstanceIdNotMatch,
		// Token: 0x0400ADC4 RID: 44484
		[OriginalName("ErrPrewarCaptainCanNotLeave")]
		ErrPrewarCaptainCanNotLeave,
		// Token: 0x0400ADC5 RID: 44485
		[OriginalName("ErrPrewarReadyStateCanNotChangeRole")]
		ErrPrewarReadyStateCanNotChangeRole,
		// Token: 0x0400ADC6 RID: 44486
		[OriginalName("ErrScenePrewarTeamHavePlayerNotReady")]
		ErrScenePrewarTeamHavePlayerNotReady,
		// Token: 0x0400ADC7 RID: 44487
		[OriginalName("ErrAlreadyInMultiScene")]
		ErrAlreadyInMultiScene,
		// Token: 0x0400ADC8 RID: 44488
		[OriginalName("ErrOnlyCaptainCanDissolvePrewarTeam")]
		ErrOnlyCaptainCanDissolvePrewarTeam,
		// Token: 0x0400ADC9 RID: 44489
		[OriginalName("ErrMultiChangeRoleIndexInvalid")]
		ErrMultiChangeRoleIndexInvalid,
		// Token: 0x0400ADCA RID: 44490
		[OriginalName("ErrMultiCanNotChangeOtherRole")]
		ErrMultiCanNotChangeOtherRole,
		// Token: 0x0400ADCB RID: 44491
		[OriginalName("ErrMultiChangeRoleEntityNorExist")]
		ErrMultiChangeRoleEntityNorExist,
		// Token: 0x0400ADCC RID: 44492
		[OriginalName("ErrSceneCanNotUseThisFunc")]
		ErrSceneCanNotUseThisFunc,
		// Token: 0x0400ADCD RID: 44493
		[OriginalName("ErrSceneCanNotUseThisItem")]
		ErrSceneCanNotUseThisItem,
		// Token: 0x0400ADCE RID: 44494
		[OriginalName("ErrSceneFightRoleIdRepeat")]
		ErrSceneFightRoleIdRepeat,
		// Token: 0x0400ADCF RID: 44495
		[OriginalName("ErrShieldAddEntityNotExist")]
		ErrShieldAddEntityNotExist,
		// Token: 0x0400ADD0 RID: 44496
		[OriginalName("ErrShieldAddShieldIdExisted")]
		ErrShieldAddShieldIdExisted,
		// Token: 0x0400ADD1 RID: 44497
		[OriginalName("ErrShieldChangeEntityNotExist")]
		ErrShieldChangeEntityNotExist,
		// Token: 0x0400ADD2 RID: 44498
		[OriginalName("ErrShieldChangeShieldIdNotExist")]
		ErrShieldChangeShieldIdNotExist,
		// Token: 0x0400ADD3 RID: 44499
		[OriginalName("ErrShieldRemoveEntityNotExist")]
		ErrShieldRemoveEntityNotExist,
		// Token: 0x0400ADD4 RID: 44500
		[OriginalName("ErrShieldRemoveShieldIdNotExist")]
		ErrShieldRemoveShieldIdNotExist,
		// Token: 0x0400ADD5 RID: 44501
		[OriginalName("ErrHardnessModeChangedEntityNotExist")]
		ErrHardnessModeChangedEntityNotExist,
		// Token: 0x0400ADD6 RID: 44502
		[OriginalName("ErrSceneEntityNotExist")]
		ErrSceneEntityNotExist,
		// Token: 0x0400ADD7 RID: 44503
		[OriginalName("ErrSceneEntityNotHavePartData")]
		ErrSceneEntityNotHavePartData,
		// Token: 0x0400ADD8 RID: 44504
		[OriginalName("ErrsceneEntityNotHavePartId")]
		ErrsceneEntityNotHavePartId,
		// Token: 0x0400ADD9 RID: 44505
		[OriginalName("ErrChangeControlRoleRepeat")]
		ErrChangeControlRoleRepeat,
		// Token: 0x0400ADDA RID: 44506
		[OriginalName("ErrVisionSkillCallEntityFail")]
		ErrVisionSkillCallEntityFail,
		// Token: 0x0400ADDB RID: 44507
		[OriginalName("ErrSceneDataLoadError")]
		ErrSceneDataLoadError,
		// Token: 0x0400ADDC RID: 44508
		[OriginalName("ErrCreatureDataError")]
		ErrCreatureDataError,
		// Token: 0x0400ADDD RID: 44509
		[OriginalName("ErrCreatureGenIsExist")]
		ErrCreatureGenIsExist,
		// Token: 0x0400ADDE RID: 44510
		[OriginalName("ErrCreatureGenIsNotExist")]
		ErrCreatureGenIsNotExist,
		// Token: 0x0400ADDF RID: 44511
		[OriginalName("ErrCreatureGenIsControlByOther")]
		ErrCreatureGenIsControlByOther,
		// Token: 0x0400ADE0 RID: 44512
		[OriginalName("ErrCreatureGenNotHaveControlPerm")]
		ErrCreatureGenNotHaveControlPerm,
		// Token: 0x0400ADE1 RID: 44513
		[OriginalName("ErrCreatureReachMaxCount")]
		ErrCreatureReachMaxCount,
		// Token: 0x0400ADE2 RID: 44514
		[OriginalName("ErrCreatureConditionNotMatch")]
		ErrCreatureConditionNotMatch,
		// Token: 0x0400ADE3 RID: 44515
		[OriginalName("ErrCreatureTimeIntervalError")]
		ErrCreatureTimeIntervalError,
		// Token: 0x0400ADE4 RID: 44516
		[OriginalName("ErrCreatureCfgNotExist")]
		ErrCreatureCfgNotExist,
		// Token: 0x0400ADE5 RID: 44517
		[OriginalName("ErrCreatureEntityIsNotValidity")]
		ErrCreatureEntityIsNotValidity,
		// Token: 0x0400ADE6 RID: 44518
		[OriginalName("ErrUniqueEntityCanNotCreateTwice")]
		ErrUniqueEntityCanNotCreateTwice,
		// Token: 0x0400ADE7 RID: 44519
		[OriginalName("ErrRoleNotHaveVisionSkill")]
		ErrRoleNotHaveVisionSkill,
		// Token: 0x0400ADE8 RID: 44520
		[OriginalName("ErrHitGearEntityNotExist")]
		ErrHitGearEntityNotExist,
		// Token: 0x0400ADE9 RID: 44521
		[OriginalName("ErrHitGearHaveNotEntityConfig")]
		ErrHitGearHaveNotEntityConfig,
		// Token: 0x0400ADEA RID: 44522
		[OriginalName("ErrHitGearHaveNotGearConfig")]
		ErrHitGearHaveNotGearConfig,
		// Token: 0x0400ADEB RID: 44523
		[OriginalName("ErrHitGearHaveNotGameplayConfig")]
		ErrHitGearHaveNotGameplayConfig,
		// Token: 0x0400ADEC RID: 44524
		[OriginalName("ErrHitGearHaveNotStepConfig")]
		ErrHitGearHaveNotStepConfig,
		// Token: 0x0400ADED RID: 44525
		[OriginalName("ErrHitGearHaveEntityCommonTag")]
		ErrHitGearHaveEntityCommonTag,
		// Token: 0x0400ADEE RID: 44526
		[OriginalName("ErrHitGearEntityFunctionTypeFail")]
		ErrHitGearEntityFunctionTypeFail,
		// Token: 0x0400ADEF RID: 44527
		[OriginalName("ErrHitGearAcceptStepFail")]
		ErrHitGearAcceptStepFail,
		// Token: 0x0400ADF0 RID: 44528
		[OriginalName("ErrCreateInstanceNotContainEntrance")]
		ErrCreateInstanceNotContainEntrance,
		// Token: 0x0400ADF1 RID: 44529
		[OriginalName("ErrCreateInstanceHaveNotEntranceConfig")]
		ErrCreateInstanceHaveNotEntranceConfig,
		// Token: 0x0400ADF2 RID: 44530
		[OriginalName("ErrCreateInstanceEntranceLock")]
		ErrCreateInstanceEntranceLock,
		// Token: 0x0400ADF3 RID: 44531
		[OriginalName("ErrCreateInstanceHaveNotConfig")]
		ErrCreateInstanceHaveNotConfig,
		// Token: 0x0400ADF4 RID: 44532
		[OriginalName("ErrCreateInstanceEnterCountNotEnough")]
		ErrCreateInstanceEnterCountNotEnough,
		// Token: 0x0400ADF5 RID: 44533
		[OriginalName("ErrCreateInstanceConditionNotMatch")]
		ErrCreateInstanceConditionNotMatch,
		// Token: 0x0400ADF6 RID: 44534
		[OriginalName("ErrEnterCountRequestHaveNotConfig")]
		ErrEnterCountRequestHaveNotConfig,
		// Token: 0x0400ADF7 RID: 44535
		[OriginalName("ErrUnlockInstanceEntranceHaveNotConfig")]
		ErrUnlockInstanceEntranceHaveNotConfig,
		// Token: 0x0400ADF8 RID: 44536
		[OriginalName("ErrUnlockInstanceEntranceNotNeedUnlock")]
		ErrUnlockInstanceEntranceNotNeedUnlock,
		// Token: 0x0400ADF9 RID: 44537
		[OriginalName("ErrUnlockInstanceEntranceUnlocked")]
		ErrUnlockInstanceEntranceUnlocked,
		// Token: 0x0400ADFA RID: 44538
		[OriginalName("ErrUnlockInstanceEntranceCondiitonNotMatch")]
		ErrUnlockInstanceEntranceCondiitonNotMatch,
		// Token: 0x0400ADFB RID: 44539
		[OriginalName("ErrEnterSceneGameplayRequestHaveNotConfig")]
		ErrEnterSceneGameplayRequestHaveNotConfig,
		// Token: 0x0400ADFC RID: 44540
		[OriginalName("ErrEnterSceneGameplayRequestAccepted")]
		ErrEnterSceneGameplayRequestAccepted,
		// Token: 0x0400ADFD RID: 44541
		[OriginalName("ErrEnterSceneGameplayRequestAcceptFail")]
		ErrEnterSceneGameplayRequestAcceptFail,
		// Token: 0x0400ADFE RID: 44542
		[OriginalName("ErrStoryCharacterCreatFail")]
		ErrStoryCharacterCreatFail,
		// Token: 0x0400ADFF RID: 44543
		[OriginalName("ErrStoryCharacterCreatRepeat")]
		ErrStoryCharacterCreatRepeat,
		// Token: 0x0400AE00 RID: 44544
		[OriginalName("ErrStoryCharacterNotExist")]
		ErrStoryCharacterNotExist,
		// Token: 0x0400AE01 RID: 44545
		[OriginalName("ErrCheckGearEntityNotExist")]
		ErrCheckGearEntityNotExist,
		// Token: 0x0400AE02 RID: 44546
		[OriginalName("ErrCheckGearType")]
		ErrCheckGearType,
		// Token: 0x0400AE03 RID: 44547
		[OriginalName("ErrCheckGearNotEntityConfig")]
		ErrCheckGearNotEntityConfig,
		// Token: 0x0400AE04 RID: 44548
		[OriginalName("ErrCheckGearActive")]
		ErrCheckGearActive,
		// Token: 0x0400AE05 RID: 44549
		[OriginalName("ErrCheckGearInactive")]
		ErrCheckGearInactive,
		// Token: 0x0400AE06 RID: 44550
		[OriginalName("ErrTargetGearGroupEntityNotExist")]
		ErrTargetGearGroupEntityNotExist,
		// Token: 0x0400AE07 RID: 44551
		[OriginalName("ErrTargetGearGroupConfigNotExist")]
		ErrTargetGearGroupConfigNotExist,
		// Token: 0x0400AE08 RID: 44552
		[OriginalName("ErrTargetGearEntityNotExist")]
		ErrTargetGearEntityNotExist,
		// Token: 0x0400AE09 RID: 44553
		[OriginalName("ErrTargetGearConfigNotExist")]
		ErrTargetGearConfigNotExist,
		// Token: 0x0400AE0A RID: 44554
		[OriginalName("ErrTargetGearStartTypeIsNotHit")]
		ErrTargetGearStartTypeIsNotHit,
		// Token: 0x0400AE0B RID: 44555
		[OriginalName("ErrTargetGearStartTypeIsNotAction")]
		ErrTargetGearStartTypeIsNotAction,
		// Token: 0x0400AE0C RID: 44556
		[OriginalName("ErrTargetGearStarted")]
		ErrTargetGearStarted,
		// Token: 0x0400AE0D RID: 44557
		[OriginalName("ErrTargetGearFinished")]
		ErrTargetGearFinished,
		// Token: 0x0400AE0E RID: 44558
		[OriginalName("ErrTargetGearIsNotInCreatedConsole")]
		ErrTargetGearIsNotInCreatedConsole,
		// Token: 0x0400AE0F RID: 44559
		[OriginalName("ErrTargetGearGroupEntityIsNotAllInit")]
		ErrTargetGearGroupEntityIsNotAllInit,
		// Token: 0x0400AE10 RID: 44560
		[OriginalName("ErrLanternCatNotExit")]
		ErrLanternCatNotExit,
		// Token: 0x0400AE11 RID: 44561
		[OriginalName("ErrLanternCatConfNotExit")]
		ErrLanternCatConfNotExit,
		// Token: 0x0400AE12 RID: 44562
		[OriginalName("ErrLanternCatType")]
		ErrLanternCatType,
		// Token: 0x0400AE13 RID: 44563
		[OriginalName("ErrLanternActived")]
		ErrLanternActived,
		// Token: 0x0400AE14 RID: 44564
		[OriginalName("ErrLanternTargetNotExit")]
		ErrLanternTargetNotExit,
		// Token: 0x0400AE15 RID: 44565
		[OriginalName("ErrCaptureFail")]
		ErrCaptureFail,
		// Token: 0x0400AE16 RID: 44566
		[OriginalName("ErrDyingFail")]
		ErrDyingFail,
		// Token: 0x0400AE17 RID: 44567
		[OriginalName("ErrThrowDamageEntityNotExit")]
		ErrThrowDamageEntityNotExit,
		// Token: 0x0400AE18 RID: 44568
		[OriginalName("ErrThrowDamageCalculateId")]
		ErrThrowDamageCalculateId,
		// Token: 0x0400AE19 RID: 44569
		[OriginalName("ErrThrowDamageIdNotExit")]
		ErrThrowDamageIdNotExit,
		// Token: 0x0400AE1A RID: 44570
		[OriginalName("ErrThrowDamageRoleIdConf")]
		ErrThrowDamageRoleIdConf,
		// Token: 0x0400AE1B RID: 44571
		[OriginalName("ErrThrowDamageTypeNotExit")]
		ErrThrowDamageTypeNotExit,
		// Token: 0x0400AE1C RID: 44572
		[OriginalName("InstIdNotExist")]
		InstIdNotExist,
		// Token: 0x0400AE1D RID: 44573
		[OriginalName("ErrControlObjectEntityNotExist")]
		ErrControlObjectEntityNotExist,
		// Token: 0x0400AE1E RID: 44574
		[OriginalName("ErrControlObjectConfigNotExist")]
		ErrControlObjectConfigNotExist,
		// Token: 0x0400AE1F RID: 44575
		[OriginalName("ErrControlGroupConfigNotExist")]
		ErrControlGroupConfigNotExist,
		// Token: 0x0400AE20 RID: 44576
		[OriginalName("ErrControlObjectLocked")]
		ErrControlObjectLocked,
		// Token: 0x0400AE21 RID: 44577
		[OriginalName("ErrControlGroupLocked")]
		ErrControlGroupLocked,
		// Token: 0x0400AE22 RID: 44578
		[OriginalName("ErrControlCanNotPutTarget")]
		ErrControlCanNotPutTarget,
		// Token: 0x0400AE23 RID: 44579
		[OriginalName("ErrControlTargetOccupied")]
		ErrControlTargetOccupied,
		// Token: 0x0400AE24 RID: 44580
		[OriginalName("ErrControlObjectCatching")]
		ErrControlObjectCatching,
		// Token: 0x0400AE25 RID: 44581
		[OriginalName("ErrControlObjectNotCatching")]
		ErrControlObjectNotCatching,
		// Token: 0x0400AE26 RID: 44582
		[OriginalName("ErrControlObjectOtherCatching")]
		ErrControlObjectOtherCatching,
		// Token: 0x0400AE27 RID: 44583
		[OriginalName("ErrEntityPositionIllegal")]
		ErrEntityPositionIllegal,
		// Token: 0x0400AE28 RID: 44584
		[OriginalName("ErrTreasureBoxNot")]
		ErrTreasureBoxNot,
		// Token: 0x0400AE29 RID: 44585
		[OriginalName("ErrTreasureBoxNotInit")]
		ErrTreasureBoxNotInit,
		// Token: 0x0400AE2A RID: 44586
		[OriginalName("ErrTreasureBoxNotConfig")]
		ErrTreasureBoxNotConfig,
		// Token: 0x0400AE2B RID: 44587
		[OriginalName("ErrTreasureBoxHadReward")]
		ErrTreasureBoxHadReward,
		// Token: 0x0400AE2C RID: 44588
		[OriginalName("ErrTreasureBoxNotInteraction")]
		ErrTreasureBoxNotInteraction,
		// Token: 0x0400AE2D RID: 44589
		[OriginalName("ErrTreasureBoxNotDropId")]
		ErrTreasureBoxNotDropId,
		// Token: 0x0400AE2E RID: 44590
		[OriginalName("ErrTreasureBoxDropErr")]
		ErrTreasureBoxDropErr,
		// Token: 0x0400AE2F RID: 44591
		[OriginalName("ErrTreasureBoxNotExist")]
		ErrTreasureBoxNotExist,
		// Token: 0x0400AE30 RID: 44592
		[OriginalName("ErrTreasureBoxInvalidTag")]
		ErrTreasureBoxInvalidTag,
		// Token: 0x0400AE31 RID: 44593
		[OriginalName("ErrTreasureBoxHadTag")]
		ErrTreasureBoxHadTag,
		// Token: 0x0400AE32 RID: 44594
		[OriginalName("ErrTreasureBoxNotTag")]
		ErrTreasureBoxNotTag,
		// Token: 0x0400AE33 RID: 44595
		[OriginalName("ErrSneakGameNotOpen")]
		ErrSneakGameNotOpen,
		// Token: 0x0400AE34 RID: 44596
		[OriginalName("ErrSneakFinishRepeat")]
		ErrSneakFinishRepeat,
		// Token: 0x0400AE35 RID: 44597
		[OriginalName("ErrClientControlDamage")]
		ErrClientControlDamage,
		// Token: 0x0400AE36 RID: 44598
		[OriginalName("ErrSceneDataSaveFail")]
		ErrSceneDataSaveFail,
		// Token: 0x0400AE37 RID: 44599
		[OriginalName("NotInFbInstance")]
		NotInFbInstance,
		// Token: 0x0400AE38 RID: 44600
		[OriginalName("GMErrCanNotCreateWorldInst")]
		GmerrCanNotCreateWorldInst,
		// Token: 0x0400AE39 RID: 44601
		[OriginalName("GMErrPlayerAlreadyInFbInst")]
		GmerrPlayerAlreadyInFbInst,
		// Token: 0x0400AE3A RID: 44602
		[OriginalName("GMErrTagetInstanceIsNotMulti")]
		GmerrTagetInstanceIsNotMulti,
		// Token: 0x0400AE3B RID: 44603
		[OriginalName("GMErrPlayerNotFound")]
		GmerrPlayerNotFound,
		// Token: 0x0400AE3C RID: 44604
		[OriginalName("ErrEntityFlowTooMuch")]
		ErrEntityFlowTooMuch,
		// Token: 0x0400AE3D RID: 44605
		[OriginalName("GmErrIsWalkable")]
		GmErrIsWalkable,
		// Token: 0x0400AE3E RID: 44606
		[OriginalName("GmErrIsNotWalkable")]
		GmErrIsNotWalkable,
		// Token: 0x0400AE3F RID: 44607
		[OriginalName("GmErrNoNavmesh")]
		GmErrNoNavmesh,
		// Token: 0x0400AE40 RID: 44608
		[OriginalName("ErrBigWorldInstIdNotExist")]
		ErrBigWorldInstIdNotExist,
		// Token: 0x0400AE41 RID: 44609
		[OriginalName("ErrInstIdNotBigWorld")]
		ErrInstIdNotBigWorld,
		// Token: 0x0400AE42 RID: 44610
		[OriginalName("ErrInInstanceNotSwitchBigWorld")]
		ErrInInstanceNotSwitchBigWorld,
		// Token: 0x0400AE43 RID: 44611
		[OriginalName("ErrAlreadyInThisBigWorld")]
		ErrAlreadyInThisBigWorld,
		// Token: 0x0400AE44 RID: 44612
		[OriginalName("ErrNoPermissionGetTreasureBox")]
		ErrNoPermissionGetTreasureBox,
		// Token: 0x0400AE45 RID: 44613
		[OriginalName("ErrCreateBigWorldRepeat")]
		ErrCreateBigWorldRepeat,
		// Token: 0x0400AE46 RID: 44614
		[OriginalName("DebugErrInstIdNotExist")]
		DebugErrInstIdNotExist,
		// Token: 0x0400AE47 RID: 44615
		[OriginalName("ErrSceneAiStopped")]
		ErrSceneAiStopped,
		// Token: 0x0400AE48 RID: 44616
		[OriginalName("ErrGlobalEntityConfigNotExist")]
		ErrGlobalEntityConfigNotExist,
		// Token: 0x0400AE49 RID: 44617
		[OriginalName("ErrSceneFixedConfigNotExist")]
		ErrSceneFixedConfigNotExist,
		// Token: 0x0400AE4A RID: 44618
		[OriginalName("ErrSceneFixedEntityNotFound")]
		ErrSceneFixedEntityNotFound,
		// Token: 0x0400AE4B RID: 44619
		[OriginalName("ErrSceneGlobalEntityNotFount")]
		ErrSceneGlobalEntityNotFount,
		// Token: 0x0400AE4C RID: 44620
		[OriginalName("ErrEntityNotHaveVarComponent")]
		ErrEntityNotHaveVarComponent,
		// Token: 0x0400AE4D RID: 44621
		[OriginalName("ErrEntityVarNameNotExist")]
		ErrEntityVarNameNotExist,
		// Token: 0x0400AE4E RID: 44622
		[OriginalName("ErrEntityVarTypeError")]
		ErrEntityVarTypeError,
		// Token: 0x0400AE4F RID: 44623
		[OriginalName("ErrEntityConfigNotOffer")]
		ErrEntityConfigNotOffer,
		// Token: 0x0400AE50 RID: 44624
		[OriginalName("ErrConfigTypeNotGloabl")]
		ErrConfigTypeNotGloabl,
		// Token: 0x0400AE51 RID: 44625
		[OriginalName("ErrConfigTypeNotSceneFixed")]
		ErrConfigTypeNotSceneFixed,
		// Token: 0x0400AE52 RID: 44626
		[OriginalName("ErrConfigTypeNotCharacter")]
		ErrConfigTypeNotCharacter,
		// Token: 0x0400AE53 RID: 44627
		[OriginalName("ErrEntityPosNotOffer")]
		ErrEntityPosNotOffer,
		// Token: 0x0400AE54 RID: 44628
		[OriginalName("ErrSceneCellPosNotFount")]
		ErrSceneCellPosNotFount,
		// Token: 0x0400AE55 RID: 44629
		[OriginalName("ErrEntityCongigNotInSleep")]
		ErrEntityCongigNotInSleep,
		// Token: 0x0400AE56 RID: 44630
		[OriginalName("ErrSummonCfgNotFound")]
		ErrSummonCfgNotFound,
		// Token: 0x0400AE57 RID: 44631
		[OriginalName("ErrSummonAddEntityFail")]
		ErrSummonAddEntityFail,
		// Token: 0x0400AE58 RID: 44632
		[OriginalName("ErrSummonMaxCount")]
		ErrSummonMaxCount,
		// Token: 0x0400AE59 RID: 44633
		[OriginalName("ErrSummonMaxGenerations")]
		ErrSummonMaxGenerations,
		// Token: 0x0400AE5A RID: 44634
		[OriginalName("ErrSummonEntityIdAlreadyExist")]
		ErrSummonEntityIdAlreadyExist,
		// Token: 0x0400AE5B RID: 44635
		[OriginalName("ErrSummonerEntityType")]
		ErrSummonerEntityType,
		// Token: 0x0400AE5C RID: 44636
		[OriginalName("ErrEntityStatusIsNotDead")]
		ErrEntityStatusIsNotDead,
		// Token: 0x0400AE5D RID: 44637
		[OriginalName("ErrEntityNotHaveAttributeComp")]
		ErrEntityNotHaveAttributeComp,
		// Token: 0x0400AE5E RID: 44638
		[OriginalName("ErrEntityDbData")]
		ErrEntityDbData,
		// Token: 0x0400AE5F RID: 44639
		[OriginalName("ErrSceneFixedEntityCreated")]
		ErrSceneFixedEntityCreated,
		// Token: 0x0400AE60 RID: 44640
		[OriginalName("ErrInvalidAwakeEntityContext")]
		ErrInvalidAwakeEntityContext,
		// Token: 0x0400AE61 RID: 44641
		[OriginalName("ErrTriggerComponentNotExist")]
		ErrTriggerComponentNotExist,
		// Token: 0x0400AE62 RID: 44642
		[OriginalName("ErrTriggerComponentMaxCount")]
		ErrTriggerComponentMaxCount,
		// Token: 0x0400AE63 RID: 44643
		[OriginalName("ErrNotSelfRole")]
		ErrNotSelfRole,
		// Token: 0x0400AE64 RID: 44644
		[OriginalName("ErrNoControlRights")]
		ErrNoControlRights,
		// Token: 0x0400AE65 RID: 44645
		[OriginalName("ErrEntityHaveNotEntityOwner")]
		ErrEntityHaveNotEntityOwner,
		// Token: 0x0400AE66 RID: 44646
		[OriginalName("ErrEntityOwnerNotMatch")]
		ErrEntityOwnerNotMatch,
		// Token: 0x0400AE67 RID: 44647
		[OriginalName("ErrCreateSceneFixedEntitiesEmpty")]
		ErrCreateSceneFixedEntitiesEmpty,
		// Token: 0x0400AE68 RID: 44648
		[OriginalName("ErrInteractComponentNotExist")]
		ErrInteractComponentNotExist,
		// Token: 0x0400AE69 RID: 44649
		[OriginalName("ErrInteractOptionIndexInvalid")]
		ErrInteractOptionIndexInvalid,
		// Token: 0x0400AE6A RID: 44650
		[OriginalName("ErrOnlineInteractNoPermission")]
		ErrOnlineInteractNoPermission,
		// Token: 0x0400AE6B RID: 44651
		[OriginalName("ErrOnlineInteractNotOpen")]
		ErrOnlineInteractNotOpen,
		// Token: 0x0400AE6C RID: 44652
		[OriginalName("ErrAwakeEntityNoPermission")]
		ErrAwakeEntityNoPermission,
		// Token: 0x0400AE6D RID: 44653
		[OriginalName("ErrCannotUseSkillStatus")]
		ErrCannotUseSkillStatus,
		// Token: 0x0400AE6E RID: 44654
		[OriginalName("ErrInteractOptionGuidInvalid")]
		ErrInteractOptionGuidInvalid,
		// Token: 0x0400AE6F RID: 44655
		[OriginalName("ErrAddInteractOptionFail")]
		ErrAddInteractOptionFail,
		// Token: 0x0400AE70 RID: 44656
		[OriginalName("ErrRemoveInteractOptionFail")]
		ErrRemoveInteractOptionFail,
		// Token: 0x0400AE71 RID: 44657
		[OriginalName("ErrInteractOptionOwnerNotFound")]
		ErrInteractOptionOwnerNotFound,
		// Token: 0x0400AE72 RID: 44658
		[OriginalName("ErrSummonPlayerId")]
		ErrSummonPlayerId,
		// Token: 0x0400AE73 RID: 44659
		[OriginalName("ErrSummonTemplateCfgNotFound")]
		ErrSummonTemplateCfgNotFound,
		// Token: 0x0400AE74 RID: 44660
		[OriginalName("ErrAttributeComponent")]
		ErrAttributeComponent,
		// Token: 0x0400AE75 RID: 44661
		[OriginalName("ErrAnimFsmComponent")]
		ErrAnimFsmComponent,
		// Token: 0x0400AE76 RID: 44662
		[OriginalName("ErrStateComponent")]
		ErrStateComponent,
		// Token: 0x0400AE77 RID: 44663
		[OriginalName("ErrBattleComponent")]
		ErrBattleComponent,
		// Token: 0x0400AE78 RID: 44664
		[OriginalName("ErrPartComponent")]
		ErrPartComponent,
		// Token: 0x0400AE79 RID: 44665
		[OriginalName("ErrAiControlComponent")]
		ErrAiControlComponent,
		// Token: 0x0400AE7A RID: 44666
		[OriginalName("ErrSummonsComponent")]
		ErrSummonsComponent,
		// Token: 0x0400AE7B RID: 44667
		[OriginalName("ErrAiBlackboardComponent")]
		ErrAiBlackboardComponent,
		// Token: 0x0400AE7C RID: 44668
		[OriginalName("ErrSetVarInvalidContext")]
		ErrSetVarInvalidContext,
		// Token: 0x0400AE7D RID: 44669
		[OriginalName("ErrSetVarInvalidVarRefPb")]
		ErrSetVarInvalidVarRefPb,
		// Token: 0x0400AE7E RID: 44670
		[OriginalName("ErrSetVarGetRightVarDefineFail")]
		ErrSetVarGetRightVarDefineFail,
		// Token: 0x0400AE7F RID: 44671
		[OriginalName("ErrSetVarSetLeftVarDefineFail")]
		ErrSetVarSetLeftVarDefineFail,
		// Token: 0x0400AE80 RID: 44672
		[OriginalName("ErrCalcVarInvalidContext")]
		ErrCalcVarInvalidContext,
		// Token: 0x0400AE81 RID: 44673
		[OriginalName("ErrCalcVarInvalidVarRef")]
		ErrCalcVarInvalidVarRef,
		// Token: 0x0400AE82 RID: 44674
		[OriginalName("ErrCalcVarGetVarDefineFail")]
		ErrCalcVarGetVarDefineFail,
		// Token: 0x0400AE83 RID: 44675
		[OriginalName("ErrCalcVarInvalidVarType")]
		ErrCalcVarInvalidVarType,
		// Token: 0x0400AE84 RID: 44676
		[OriginalName("ErrCalcVarInvalidOp")]
		ErrCalcVarInvalidOp,
		// Token: 0x0400AE85 RID: 44677
		[OriginalName("ErrCalcVarSetResultFail")]
		ErrCalcVarSetResultFail,
		// Token: 0x0400AE86 RID: 44678
		[OriginalName("ErrActionEntityNoExist")]
		ErrActionEntityNoExist,
		// Token: 0x0400AE87 RID: 44679
		[OriginalName("ErrActionNoInteractConfig")]
		ErrActionNoInteractConfig,
		// Token: 0x0400AE88 RID: 44680
		[OriginalName("ErrActionIdNoExist")]
		ErrActionIdNoExist,
		// Token: 0x0400AE89 RID: 44681
		[OriginalName("ErrActionBtObjNoExist")]
		ErrActionBtObjNoExist,
		// Token: 0x0400AE8A RID: 44682
		[OriginalName("ErrActionNodeNoExist")]
		ErrActionNodeNoExist,
		// Token: 0x0400AE8B RID: 44683
		[OriginalName("ErrActionNoChildQuest")]
		ErrActionNoChildQuest,
		// Token: 0x0400AE8C RID: 44684
		[OriginalName("ErrActionParams")]
		ErrActionParams,
		// Token: 0x0400AE8D RID: 44685
		[OriginalName("ErrActionNotEntityContext")]
		ErrActionNotEntityContext,
		// Token: 0x0400AE8E RID: 44686
		[OriginalName("ErrActionExecutorNotFind")]
		ErrActionExecutorNotFind,
		// Token: 0x0400AE8F RID: 44687
		[OriginalName("ErrActionSessionNotFind")]
		ErrActionSessionNotFind,
		// Token: 0x0400AE90 RID: 44688
		[OriginalName("ErrActionCreateSessionIdFail")]
		ErrActionCreateSessionIdFail,
		// Token: 0x0400AE91 RID: 44689
		[OriginalName("ErrActionPathConvertFail")]
		ErrActionPathConvertFail,
		// Token: 0x0400AE92 RID: 44690
		[OriginalName("ErrActionConfigNotFind")]
		ErrActionConfigNotFind,
		// Token: 0x0400AE93 RID: 44691
		[OriginalName("ErrActionHaveNotHandler")]
		ErrActionHaveNotHandler,
		// Token: 0x0400AE94 RID: 44692
		[OriginalName("ErrActionInternalError")]
		ErrActionInternalError,
		// Token: 0x0400AE95 RID: 44693
		[OriginalName("ErrActionInvalidIndex")]
		ErrActionInvalidIndex,
		// Token: 0x0400AE96 RID: 44694
		[OriginalName("ErrActionIsNotServer")]
		ErrActionIsNotServer,
		// Token: 0x0400AE97 RID: 44695
		[OriginalName("ErrActionRemainActionNotFinish")]
		ErrActionRemainActionNotFinish,
		// Token: 0x0400AE98 RID: 44696
		[OriginalName("ErrActionExecutorIsNotBlackbard")]
		ErrActionExecutorIsNotBlackbard,
		// Token: 0x0400AE99 RID: 44697
		[OriginalName("ErrContinuityActionNotFinish")]
		ErrContinuityActionNotFinish,
		// Token: 0x0400AE9A RID: 44698
		[OriginalName("ErrActionIsNotContinuity")]
		ErrActionIsNotContinuity,
		// Token: 0x0400AE9B RID: 44699
		[OriginalName("ErrResetLocationEntityNotExist")]
		ErrResetLocationEntityNotExist,
		// Token: 0x0400AE9C RID: 44700
		[OriginalName("ErrEntityPosAbnormalNotExists")]
		ErrEntityPosAbnormalNotExists,
		// Token: 0x0400AE9D RID: 44701
		[OriginalName("ErrGmRemoveEntityNotExists")]
		ErrGmRemoveEntityNotExists,
		// Token: 0x0400AE9E RID: 44702
		[OriginalName("ErrDrownEntityNotExists")]
		ErrDrownEntityNotExists,
		// Token: 0x0400AE9F RID: 44703
		[OriginalName("ErrTargetGearNotExists")]
		ErrTargetGearNotExists,
		// Token: 0x0400AEA0 RID: 44704
		[OriginalName("ErrOutofBattleEntityNotExists")]
		ErrOutofBattleEntityNotExists,
		// Token: 0x0400AEA1 RID: 44705
		[OriginalName("ErrOrderAddBuffEntityNotExists")]
		ErrOrderAddBuffEntityNotExists,
		// Token: 0x0400AEA2 RID: 44706
		[OriginalName("ErrOrderRemoveBuffEntityNotExists")]
		ErrOrderRemoveBuffEntityNotExists,
		// Token: 0x0400AEA3 RID: 44707
		[OriginalName("ErrActivateBuffEntityNotExists")]
		ErrActivateBuffEntityNotExists,
		// Token: 0x0400AEA4 RID: 44708
		[OriginalName("ErrToughCalcExtraRatioChangeEntityNotExists")]
		ErrToughCalcExtraRatioChangeEntityNotExists,
		// Token: 0x0400AEA5 RID: 44709
		[OriginalName("ErrAdsorbEntityNotExist")]
		ErrAdsorbEntityNotExist,
		// Token: 0x0400AEA6 RID: 44710
		[OriginalName("ErrAdsorbCondNotMeet")]
		ErrAdsorbCondNotMeet,
		// Token: 0x0400AEA7 RID: 44711
		[OriginalName("ErrTimelineTrackMultiGameForbid")]
		ErrTimelineTrackMultiGameForbid,
		// Token: 0x0400AEA8 RID: 44712
		[OriginalName("ErrTimelineTraceEntityNotExists")]
		ErrTimelineTraceEntityNotExists,
		// Token: 0x0400AEA9 RID: 44713
		[OriginalName("ErrTimelineTraceComponentNotExists")]
		ErrTimelineTraceComponentNotExists,
		// Token: 0x0400AEAA RID: 44714
		[OriginalName("ErrTimelineTraceGroupIndex")]
		ErrTimelineTraceGroupIndex,
		// Token: 0x0400AEAB RID: 44715
		[OriginalName("ErrTimelineTraceFinish")]
		ErrTimelineTraceFinish,
		// Token: 0x0400AEAC RID: 44716
		[OriginalName("ErrTimelineTraceCondition")]
		ErrTimelineTraceCondition,
		// Token: 0x0400AEAD RID: 44717
		[OriginalName("ErrTimelineTraceTargetEmpty")]
		ErrTimelineTraceTargetEmpty,
		// Token: 0x0400AEAE RID: 44718
		[OriginalName("ErrTimelineTraceControl")]
		ErrTimelineTraceControl,
		// Token: 0x0400AEAF RID: 44719
		[OriginalName("ErrTimelineTraceFinishCondition")]
		ErrTimelineTraceFinishCondition,
		// Token: 0x0400AEB0 RID: 44720
		[OriginalName("ErrTimelineTraceNotInControl")]
		ErrTimelineTraceNotInControl,
		// Token: 0x0400AEB1 RID: 44721
		[OriginalName("ErrForbidEnterInstance")]
		ErrForbidEnterInstance,
		// Token: 0x0400AEB2 RID: 44722
		[OriginalName("ErrForbitEnterBigWorld")]
		ErrForbitEnterBigWorld,
		// Token: 0x0400AEB3 RID: 44723
		[OriginalName("ErrPrefabIncIdExist")]
		ErrPrefabIncIdExist,
		// Token: 0x0400AEB4 RID: 44724
		[OriginalName("ErrPrefabIdExist")]
		ErrPrefabIdExist,
		// Token: 0x0400AEB5 RID: 44725
		[OriginalName("ErrPrefabNumberIsZero")]
		ErrPrefabNumberIsZero,
		// Token: 0x0400AEB6 RID: 44726
		[OriginalName("ErrPrefabEntityIsExist")]
		ErrPrefabEntityIsExist,
		// Token: 0x0400AEB7 RID: 44727
		[OriginalName("ErrPrefabTreasureBox")]
		ErrPrefabTreasureBox,
		// Token: 0x0400AEB8 RID: 44728
		[OriginalName("ErrPrefabActionCreate")]
		ErrPrefabActionCreate,
		// Token: 0x0400AEB9 RID: 44729
		[OriginalName("ErrPrefabVarNoExist")]
		ErrPrefabVarNoExist,
		// Token: 0x0400AEBA RID: 44730
		[OriginalName("ErrClientOnlyEntityCantCreate")]
		ErrClientOnlyEntityCantCreate,
		// Token: 0x0400AEBB RID: 44731
		[OriginalName("ErrTimelineTraceActionRun")]
		ErrTimelineTraceActionRun,
		// Token: 0x0400AEBC RID: 44732
		[OriginalName("ErrGmActivateTeleportSceneNotExist")]
		ErrGmActivateTeleportSceneNotExist,
		// Token: 0x0400AEBD RID: 44733
		[OriginalName("ErrGmCreateInstSceneHasExist")]
		ErrGmCreateInstSceneHasExist,
		// Token: 0x0400AEBE RID: 44734
		[OriginalName("ErrVfxNpcNotExist")]
		ErrVfxNpcNotExist,
		// Token: 0x0400AEBF RID: 44735
		[OriginalName("ErrVfxNpcIsNotVfxNpc")]
		ErrVfxNpcIsNotVfxNpc,
		// Token: 0x0400AEC0 RID: 44736
		[OriginalName("ErrBlackboardLimit")]
		ErrBlackboardLimit,
		// Token: 0x0400AEC1 RID: 44737
		[OriginalName("ErrBlackboardArrayLimit")]
		ErrBlackboardArrayLimit,
		// Token: 0x0400AEC2 RID: 44738
		[OriginalName("ErrBlackboardStringLimit")]
		ErrBlackboardStringLimit,
		// Token: 0x0400AEC3 RID: 44739
		[OriginalName("ErrReconnectGWGetGatePlayerFailed")]
		ErrReconnectGwgetGatePlayerFailed = 800000,
		// Token: 0x0400AEC4 RID: 44740
		[OriginalName("ErrGWReconnectGWInvalidPlayerState")]
		ErrGwreconnectGwinvalidPlayerState,
		// Token: 0x0400AEC5 RID: 44741
		[OriginalName("ErrGWReconnectGWVerifyTokenFailed")]
		ErrGwreconnectGwverifyTokenFailed,
		// Token: 0x0400AEC6 RID: 44742
		[OriginalName("ErrGWReconnectGWBackOnlineAsyncFailed")]
		ErrGwreconnectGwbackOnlineAsyncFailed,
		// Token: 0x0400AEC7 RID: 44743
		[OriginalName("ErrGWReconnectGWBackOnlineAsyncException")]
		ErrGwreconnectGwbackOnlineAsyncException,
		// Token: 0x0400AEC8 RID: 44744
		[OriginalName("ErrReconnectGwclientLatestSeqNoNotHit")]
		ErrReconnectGwclientLatestSeqNoNotHit,
		// Token: 0x0400AEC9 RID: 44745
		[OriginalName("ErrGWReconnectConfirmGetPlayerFailed")]
		ErrGwreconnectConfirmGetPlayerFailed,
		// Token: 0x0400AECA RID: 44746
		[OriginalName("ErrAttrChangeHandleInvalidClientAction")]
		ErrAttrChangeHandleInvalidClientAction,
		// Token: 0x0400AECB RID: 44747
		[OriginalName("ErrThrowDamageReqGetStateComponentFailed")]
		ErrThrowDamageReqGetStateComponentFailed,
		// Token: 0x0400AECC RID: 44748
		[OriginalName("ErrThrowDamageReqEntityIsAlreadyDead")]
		ErrThrowDamageReqEntityIsAlreadyDead,
		// Token: 0x0400AECD RID: 44749
		[OriginalName("ErrAnimalDieRequestForceSetDieError")]
		ErrAnimalDieRequestForceSetDieError,
		// Token: 0x0400AECE RID: 44750
		[OriginalName("ErrCollectEntityForceSetEntityDieError")]
		ErrCollectEntityForceSetEntityDieError,
		// Token: 0x0400AECF RID: 44751
		[OriginalName("ErrMonsterBoomForceSetDieError")]
		ErrMonsterBoomForceSetDieError,
		// Token: 0x0400AED0 RID: 44752
		[OriginalName("ErrAttrChangeReqReplaceAttrListFailed")]
		ErrAttrChangeReqReplaceAttrListFailed,
		// Token: 0x0400AED1 RID: 44753
		[OriginalName("ErrReconnectInvalidOperation")]
		ErrReconnectInvalidOperation,
		// Token: 0x0400AED2 RID: 44754
		[OriginalName("ErrReconnectGwNodeTainted")]
		ErrReconnectGwNodeTainted,
		// Token: 0x0400AED3 RID: 44755
		[OriginalName("ErrFavorRoleNotFound")]
		ErrFavorRoleNotFound = 900000,
		// Token: 0x0400AED4 RID: 44756
		[OriginalName("ErrFavorConfNotFound")]
		ErrFavorConfNotFound,
		// Token: 0x0400AED5 RID: 44757
		[OriginalName("ErrFavorQuestNotFound")]
		ErrFavorQuestNotFound,
		// Token: 0x0400AED6 RID: 44758
		[OriginalName("ErrFavorLevelRewardLimit")]
		ErrFavorLevelRewardLimit,
		// Token: 0x0400AED7 RID: 44759
		[OriginalName("ErrFavorQuestAcceptLimit")]
		ErrFavorQuestAcceptLimit,
		// Token: 0x0400AED8 RID: 44760
		[OriginalName("ErrFavorItemLocked")]
		ErrFavorItemLocked,
		// Token: 0x0400AED9 RID: 44761
		[OriginalName("ErrFavorItemHasUnLocked")]
		ErrFavorItemHasUnLocked,
		// Token: 0x0400AEDA RID: 44762
		[OriginalName("ErrElevatorEntityNotExit")]
		ErrElevatorEntityNotExit,
		// Token: 0x0400AEDB RID: 44763
		[OriginalName("ErrElevatorConfigNotExit")]
		ErrElevatorConfigNotExit,
		// Token: 0x0400AEDC RID: 44764
		[OriginalName("ErrElevatorLocked")]
		ErrElevatorLocked,
		// Token: 0x0400AEDD RID: 44765
		[OriginalName("ErrElevatorIsNotReverse")]
		ErrElevatorIsNotReverse,
		// Token: 0x0400AEDE RID: 44766
		[OriginalName("ErrElevatorIsNotForward")]
		ErrElevatorIsNotForward,
		// Token: 0x0400AEDF RID: 44767
		[OriginalName("ErrElevatorIsNotStart")]
		ErrElevatorIsNotStart,
		// Token: 0x0400AEE0 RID: 44768
		[OriginalName("ErrElevatorIsNotEnd")]
		ErrElevatorIsNotEnd,
		// Token: 0x0400AEE1 RID: 44769
		[OriginalName("ErrElevatorFloorError")]
		ErrElevatorFloorError,
		// Token: 0x0400AEE2 RID: 44770
		[OriginalName("ErrHostRefuse")]
		ErrHostRefuse,
		// Token: 0x0400AEE3 RID: 44771
		[OriginalName("ErrHostOffline")]
		ErrHostOffline,
		// Token: 0x0400AEE4 RID: 44772
		[OriginalName("ErrHostHasOnline")]
		ErrHostHasOnline,
		// Token: 0x0400AEE5 RID: 44773
		[OriginalName("ErrHostPlayerMax")]
		ErrHostPlayerMax,
		// Token: 0x0400AEE6 RID: 44774
		[OriginalName("ErrHostRefuseStrangers")]
		ErrHostRefuseStrangers,
		// Token: 0x0400AEE7 RID: 44775
		[OriginalName("ErrHostForbidJoin")]
		ErrHostForbidJoin,
		// Token: 0x0400AEE8 RID: 44776
		[OriginalName("ErrHostTemporarilyForbidJoin")]
		ErrHostTemporarilyForbidJoin,
		// Token: 0x0400AEE9 RID: 44777
		[OriginalName("ErrSlaveInBlockList")]
		ErrSlaveInBlockList,
		// Token: 0x0400AEEA RID: 44778
		[OriginalName("ErrExceedJoinLevelDiff")]
		ErrExceedJoinLevelDiff,
		// Token: 0x0400AEEB RID: 44779
		[OriginalName("ErrHostNotOpenOnlineFunc")]
		ErrHostNotOpenOnlineFunc,
		// Token: 0x0400AEEC RID: 44780
		[OriginalName("ErrHostInOtherPlayer")]
		ErrHostInOtherPlayer,
		// Token: 0x0400AEED RID: 44781
		[OriginalName("ErrHostInForbidOnlineQuest")]
		ErrHostInForbidOnlineQuest,
		// Token: 0x0400AEEE RID: 44782
		[OriginalName("ErrSlaveHasOnline")]
		ErrSlaveHasOnline,
		// Token: 0x0400AEEF RID: 44783
		[OriginalName("ErrSlaveInForbidOnlineQuest")]
		ErrSlaveInForbidOnlineQuest,
		// Token: 0x0400AEF0 RID: 44784
		[OriginalName("ErrSlaveNotOpenOnlineFunc")]
		ErrSlaveNotOpenOnlineFunc,
		// Token: 0x0400AEF1 RID: 44785
		[OriginalName("ErrSlaveApplyRepeated")]
		ErrSlaveApplyRepeated,
		// Token: 0x0400AEF2 RID: 44786
		[OriginalName("ErrSlaveTryApplySelf")]
		ErrSlaveTryApplySelf,
		// Token: 0x0400AEF3 RID: 44787
		[OriginalName("ErrLobbyTryQuerySelf")]
		ErrLobbyTryQuerySelf,
		// Token: 0x0400AEF4 RID: 44788
		[OriginalName("ErrSlaveRequestExpired")]
		ErrSlaveRequestExpired,
		// Token: 0x0400AEF5 RID: 44789
		[OriginalName("ErrEnterringOtherScene")]
		ErrEnterringOtherScene,
		// Token: 0x0400AEF6 RID: 44790
		[OriginalName("ErrWaitingOtherJoin")]
		ErrWaitingOtherJoin,
		// Token: 0x0400AEF7 RID: 44791
		[OriginalName("ErrWaitListFull")]
		ErrWaitListFull,
		// Token: 0x0400AEF8 RID: 44792
		[OriginalName("ErrAlreayInWaitEnterList")]
		ErrAlreayInWaitEnterList,
		// Token: 0x0400AEF9 RID: 44793
		[OriginalName("ErrHostNotInBigWorld")]
		ErrHostNotInBigWorld,
		// Token: 0x0400AEFA RID: 44794
		[OriginalName("ErrPlayerNotInBigWorld")]
		ErrPlayerNotInBigWorld,
		// Token: 0x0400AEFB RID: 44795
		[OriginalName("ErrPlayerNotInWaitList")]
		ErrPlayerNotInWaitList,
		// Token: 0x0400AEFC RID: 44796
		[OriginalName("ErrForbidOperaInMatching")]
		ErrForbidOperaInMatching,
		// Token: 0x0400AEFD RID: 44797
		[OriginalName("ErrLobbyNotFoundPlayer")]
		ErrLobbyNotFoundPlayer,
		// Token: 0x0400AEFE RID: 44798
		[OriginalName("ErrRoleTrailCannotOnline")]
		ErrRoleTrailCannotOnline,
		// Token: 0x0400AEFF RID: 44799
		[OriginalName("ErrHostRoleTrail")]
		ErrHostRoleTrail,
		// Token: 0x0400AF00 RID: 44800
		[OriginalName("ErrInMatchingCanNotJoinOther")]
		ErrInMatchingCanNotJoinOther,
		// Token: 0x0400AF01 RID: 44801
		[OriginalName("ErrInMatchCanNotBeApply")]
		ErrInMatchCanNotBeApply,
		// Token: 0x0400AF02 RID: 44802
		[OriginalName("ErrInMatchCanNotAcceptApply")]
		ErrInMatchCanNotAcceptApply,
		// Token: 0x0400AF03 RID: 44803
		[OriginalName("ErrSlaveInFlow")]
		ErrSlaveInFlow,
		// Token: 0x0400AF04 RID: 44804
		[OriginalName("ErrHostInFlow")]
		ErrHostInFlow,
		// Token: 0x0400AF05 RID: 44805
		[OriginalName("ErrAchievementNotClinet")]
		ErrAchievementNotClinet,
		// Token: 0x0400AF06 RID: 44806
		[OriginalName("ErrTriggerConditionNotMet")]
		ErrTriggerConditionNotMet,
		// Token: 0x0400AF07 RID: 44807
		[OriginalName("ErrNpcTraceNotConf")]
		ErrNpcTraceNotConf,
		// Token: 0x0400AF08 RID: 44808
		[OriginalName("ErrBuffProducerConfNotFound")]
		ErrBuffProducerConfNotFound,
		// Token: 0x0400AF09 RID: 44809
		[OriginalName("ErrBuffProducerHasDone")]
		ErrBuffProducerHasDone,
		// Token: 0x0400AF0A RID: 44810
		[OriginalName("ErrBuffConsumerConfNotFound")]
		ErrBuffConsumerConfNotFound,
		// Token: 0x0400AF0B RID: 44811
		[OriginalName("ErrBuffConsumerBuffNotFound")]
		ErrBuffConsumerBuffNotFound,
		// Token: 0x0400AF0C RID: 44812
		[OriginalName("ErrBuffConsumerEntityNotFound")]
		ErrBuffConsumerEntityNotFound,
		// Token: 0x0400AF0D RID: 44813
		[OriginalName("ErrItemPosInvaild")]
		ErrItemPosInvaild,
		// Token: 0x0400AF0E RID: 44814
		[OriginalName("ErrItemIdInvaild")]
		ErrItemIdInvaild,
		// Token: 0x0400AF0F RID: 44815
		[OriginalName("ErrRouletteFuncIdInvaild")]
		ErrRouletteFuncIdInvaild,
		// Token: 0x0400AF10 RID: 44816
		[OriginalName("ErrStateIsRunning")]
		ErrStateIsRunning,
		// Token: 0x0400AF11 RID: 44817
		[OriginalName("ErrSceneEntityNotFind")]
		ErrSceneEntityNotFind,
		// Token: 0x0400AF12 RID: 44818
		[OriginalName("ErrActionPlayersIsEmpty")]
		ErrActionPlayersIsEmpty,
		// Token: 0x0400AF13 RID: 44819
		[OriginalName("ErrFireBulletNoLauncher")]
		ErrFireBulletNoLauncher,
		// Token: 0x0400AF14 RID: 44820
		[OriginalName("ErrFireBulletNoTarget")]
		ErrFireBulletNoTarget,
		// Token: 0x0400AF15 RID: 44821
		[OriginalName("ErrTurntableConfigNotFound")]
		ErrTurntableConfigNotFound,
		// Token: 0x0400AF16 RID: 44822
		[OriginalName("ErrTurntableActivityNotOpen")]
		ErrTurntableActivityNotOpen,
		// Token: 0x0400AF17 RID: 44823
		[OriginalName("ErrTurntableActivityIsFinish")]
		ErrTurntableActivityIsFinish,
		// Token: 0x0400AF18 RID: 44824
		[OriginalName("ErrTurntableActivityQuestNotFinish")]
		ErrTurntableActivityQuestNotFinish,
		// Token: 0x0400AF19 RID: 44825
		[OriginalName("ErrTurntableActivityRoundConfigNotFound")]
		ErrTurntableActivityRoundConfigNotFound,
		// Token: 0x0400AF1A RID: 44826
		[OriginalName("ErrEnrichmentAreaIsEmpty")]
		ErrEnrichmentAreaIsEmpty,
		// Token: 0x0400AF1B RID: 44827
		[OriginalName("ErrEnrichmentAreaNotFind")]
		ErrEnrichmentAreaNotFind,
		// Token: 0x0400AF1C RID: 44828
		[OriginalName("ErrEnrichmentAreaInCD")]
		ErrEnrichmentAreaInCd,
		// Token: 0x0400AF1D RID: 44829
		[OriginalName("ErrEnrichmentAreaInFog")]
		ErrEnrichmentAreaInFog,
		// Token: 0x0400AF1E RID: 44830
		[OriginalName("ErrEntityWalkingPoint")]
		ErrEntityWalkingPoint,
		// Token: 0x0400AF1F RID: 44831
		[OriginalName("ErrServerConfigReload")]
		ErrServerConfigReload,
		// Token: 0x0400AF20 RID: 44832
		[OriginalName("ErrAreaCheckFailed")]
		ErrAreaCheckFailed,
		// Token: 0x0400AF21 RID: 44833
		[OriginalName("ErrHostSceneBlockSplitFail")]
		ErrHostSceneBlockSplitFail,
		// Token: 0x0400AF22 RID: 44834
		[OriginalName("ErrSlaveSceneBlockSplitFail")]
		ErrSlaveSceneBlockSplitFail,
		// Token: 0x0400AF23 RID: 44835
		[OriginalName("ErrHookLockBatchCollectMaxCount")]
		ErrHookLockBatchCollectMaxCount,
		// Token: 0x0400AF24 RID: 44836
		[OriginalName("ErrHookLockBatchCollectFail")]
		ErrHookLockBatchCollectFail,
		// Token: 0x0400AF25 RID: 44837
		[OriginalName("ErrEntityPackIdErr")]
		ErrEntityPackIdErr,
		// Token: 0x0400AF26 RID: 44838
		[OriginalName("ErrEntityInQuickHackSkill")]
		ErrEntityInQuickHackSkill,
		// Token: 0x0400AF27 RID: 44839
		[OriginalName("ErrEntityQuickHackSkillNoAction")]
		ErrEntityQuickHackSkillNoAction,
		// Token: 0x0400AF28 RID: 44840
		[OriginalName("ErrVehicleInPhantomFormation")]
		ErrVehicleInPhantomFormation,
		// Token: 0x0400AF29 RID: 44841
		[OriginalName("ErrGiantSystemNotOpen")]
		ErrGiantSystemNotOpen,
		// Token: 0x0400AF2A RID: 44842
		[OriginalName("ErrGiantEcoIsLock")]
		ErrGiantEcoIsLock,
		// Token: 0x0400AF2B RID: 44843
		[OriginalName("ErrGiantItemInvaild")]
		ErrGiantItemInvaild,
		// Token: 0x0400AF2C RID: 44844
		[OriginalName("ErrGiantItemNotEnough")]
		ErrGiantItemNotEnough,
		// Token: 0x0400AF2D RID: 44845
		[OriginalName("ErrGiantItemNotMatch")]
		ErrGiantItemNotMatch,
		// Token: 0x0400AF2E RID: 44846
		[OriginalName("ErrGiantMaxLevel")]
		ErrGiantMaxLevel,
		// Token: 0x0400AF2F RID: 44847
		[OriginalName("ErrGiantMaxLevelDropLimit")]
		ErrGiantMaxLevelDropLimit,
		// Token: 0x0400AF30 RID: 44848
		[OriginalName("ErrGiantNotMaxLevel")]
		ErrGiantNotMaxLevel,
		// Token: 0x0400AF31 RID: 44849
		[OriginalName("ErrGiantActivityReward")]
		ErrGiantActivityReward,
		// Token: 0x0400AF32 RID: 44850
		[OriginalName("ErrGiantActivityNodeNotActive")]
		ErrGiantActivityNodeNotActive,
		// Token: 0x0400AF33 RID: 44851
		[OriginalName("ErrLoopTeleportVolumeConfig")]
		ErrLoopTeleportVolumeConfig,
		// Token: 0x0400AF34 RID: 44852
		[OriginalName("ErrLoopTeleportVolumeCondition")]
		ErrLoopTeleportVolumeCondition,
		// Token: 0x0400AF35 RID: 44853
		[OriginalName("ErrBuffItemConfig")]
		ErrBuffItemConfig = 1000000,
		// Token: 0x0400AF36 RID: 44854
		[OriginalName("ErrBuffItemNotShare")]
		ErrBuffItemNotShare,
		// Token: 0x0400AF37 RID: 44855
		[OriginalName("ErrBuffItemShareRoleId")]
		ErrBuffItemShareRoleId,
		// Token: 0x0400AF38 RID: 44856
		[OriginalName("ErrBuffItemRoleIdNotExist")]
		ErrBuffItemRoleIdNotExist,
		// Token: 0x0400AF39 RID: 44857
		[OriginalName("ErrBuffItemNotEnough")]
		ErrBuffItemNotEnough,
		// Token: 0x0400AF3A RID: 44858
		[OriginalName("ErrBuffItemMultiUse")]
		ErrBuffItemMultiUse,
		// Token: 0x0400AF3B RID: 44859
		[OriginalName("ErrBuffItemCdLimit")]
		ErrBuffItemCdLimit,
		// Token: 0x0400AF3C RID: 44860
		[OriginalName("ErrBuffItemNumZero")]
		ErrBuffItemNumZero,
		// Token: 0x0400AF3D RID: 44861
		[OriginalName("ErrBuffItemNotPlayer")]
		ErrBuffItemNotPlayer,
		// Token: 0x0400AF3E RID: 44862
		[OriginalName("ErrSceneItemNotExit")]
		ErrSceneItemNotExit,
		// Token: 0x0400AF3F RID: 44863
		[OriginalName("ErrSceneItemType")]
		ErrSceneItemType,
		// Token: 0x0400AF40 RID: 44864
		[OriginalName("ErrSceneItemOperate")]
		ErrSceneItemOperate,
		// Token: 0x0400AF41 RID: 44865
		[OriginalName("ErrSceneItemState")]
		ErrSceneItemState,
		// Token: 0x0400AF42 RID: 44866
		[OriginalName("ErrStateEntityNoExit")]
		ErrStateEntityNoExit,
		// Token: 0x0400AF43 RID: 44867
		[OriginalName("ErrStateEntityNotTagComp")]
		ErrStateEntityNotTagComp,
		// Token: 0x0400AF44 RID: 44868
		[OriginalName("ErrStateEntityTypeNotExit")]
		ErrStateEntityTypeNotExit,
		// Token: 0x0400AF45 RID: 44869
		[OriginalName("ErrStateEntityStateNotExit")]
		ErrStateEntityStateNotExit,
		// Token: 0x0400AF46 RID: 44870
		[OriginalName("ErrStateEntityNotConfig")]
		ErrStateEntityNotConfig,
		// Token: 0x0400AF47 RID: 44871
		[OriginalName("ErrStateEntityStateType")]
		ErrStateEntityStateType,
		// Token: 0x0400AF48 RID: 44872
		[OriginalName("ErrStateEntityStateNoChange")]
		ErrStateEntityStateNoChange,
		// Token: 0x0400AF49 RID: 44873
		[OriginalName("ErrStateEntitySilent")]
		ErrStateEntitySilent,
		// Token: 0x0400AF4A RID: 44874
		[OriginalName("ErrStateEntityComplete")]
		ErrStateEntityComplete,
		// Token: 0x0400AF4B RID: 44875
		[OriginalName("ErrStateEntityLock")]
		ErrStateEntityLock,
		// Token: 0x0400AF4C RID: 44876
		[OriginalName("ErrStateEntityNotBorn")]
		ErrStateEntityNotBorn,
		// Token: 0x0400AF4D RID: 44877
		[OriginalName("ErrStateNameNoExit")]
		ErrStateNameNoExit,
		// Token: 0x0400AF4E RID: 44878
		[OriginalName("ErrStateInBorn")]
		ErrStateInBorn,
		// Token: 0x0400AF4F RID: 44879
		[OriginalName("ErrStateCondition")]
		ErrStateCondition,
		// Token: 0x0400AF50 RID: 44880
		[OriginalName("ErrStateNotOwner")]
		ErrStateNotOwner,
		// Token: 0x0400AF51 RID: 44881
		[OriginalName("ErrChangeSelfStateObjNotEntity")]
		ErrChangeSelfStateObjNotEntity,
		// Token: 0x0400AF52 RID: 44882
		[OriginalName("ErrFoundationNotExists")]
		ErrFoundationNotExists,
		// Token: 0x0400AF53 RID: 44883
		[OriginalName("ErrTeleControlNotExists")]
		ErrTeleControlNotExists,
		// Token: 0x0400AF54 RID: 44884
		[OriginalName("ErrFoundationNotComponent")]
		ErrFoundationNotComponent,
		// Token: 0x0400AF55 RID: 44885
		[OriginalName("ErrFoundationActived")]
		ErrFoundationActived,
		// Token: 0x0400AF56 RID: 44886
		[OriginalName("ErrFoundationUnActived")]
		ErrFoundationUnActived,
		// Token: 0x0400AF57 RID: 44887
		[OriginalName("ErrFoundationNotMatch")]
		ErrFoundationNotMatch,
		// Token: 0x0400AF58 RID: 44888
		[OriginalName("ErrFoundationNotInRange")]
		ErrFoundationNotInRange,
		// Token: 0x0400AF59 RID: 44889
		[OriginalName("ErrFoundationNotStateId")]
		ErrFoundationNotStateId,
		// Token: 0x0400AF5A RID: 44890
		[OriginalName("ErrGravityGearNotExists")]
		ErrGravityGearNotExists,
		// Token: 0x0400AF5B RID: 44891
		[OriginalName("ErrGravityGearNotConfig")]
		ErrGravityGearNotConfig,
		// Token: 0x0400AF5C RID: 44892
		[OriginalName("ErrGravityGearForbidReset")]
		ErrGravityGearForbidReset,
		// Token: 0x0400AF5D RID: 44893
		[OriginalName("ErrFollowTrackEntityNoExist")]
		ErrFollowTrackEntityNoExist,
		// Token: 0x0400AF5E RID: 44894
		[OriginalName("ErrFollowTrackNotComp")]
		ErrFollowTrackNotComp,
		// Token: 0x0400AF5F RID: 44895
		[OriginalName("ErrFollowTrackNotFoundationId")]
		ErrFollowTrackNotFoundationId,
		// Token: 0x0400AF60 RID: 44896
		[OriginalName("ErrFollowTrackNotFoundation")]
		ErrFollowTrackNotFoundation,
		// Token: 0x0400AF61 RID: 44897
		[OriginalName("ErrFollowTrackActiveed")]
		ErrFollowTrackActiveed,
		// Token: 0x0400AF62 RID: 44898
		[OriginalName("ErrThrowPlayerNotExit")]
		ErrThrowPlayerNotExit,
		// Token: 0x0400AF63 RID: 44899
		[OriginalName("ErrAnimalEntityNotExist")]
		ErrAnimalEntityNotExist,
		// Token: 0x0400AF64 RID: 44900
		[OriginalName("ErrNotAnimalEntity")]
		ErrNotAnimalEntity,
		// Token: 0x0400AF65 RID: 44901
		[OriginalName("ErrSneakBtObjNotExist")]
		ErrSneakBtObjNotExist,
		// Token: 0x0400AF66 RID: 44902
		[OriginalName("ErrSneakNodeIdNotExist")]
		ErrSneakNodeIdNotExist,
		// Token: 0x0400AF67 RID: 44903
		[OriginalName("ErrSneakNotFailedNode")]
		ErrSneakNotFailedNode,
		// Token: 0x0400AF68 RID: 44904
		[OriginalName("ErrSneakNotTime")]
		ErrSneakNotTime,
		// Token: 0x0400AF69 RID: 44905
		[OriginalName("ErrSneakTime")]
		ErrSneakTime,
		// Token: 0x0400AF6A RID: 44906
		[OriginalName("ErrInSneak")]
		ErrInSneak,
		// Token: 0x0400AF6B RID: 44907
		[OriginalName("ErrNotInSneak")]
		ErrNotInSneak,
		// Token: 0x0400AF6C RID: 44908
		[OriginalName("ErrBeControlledEntityNotExist")]
		ErrBeControlledEntityNotExist,
		// Token: 0x0400AF6D RID: 44909
		[OriginalName("ErrNotBeControlledEntity")]
		ErrNotBeControlledEntity,
		// Token: 0x0400AF6E RID: 44910
		[OriginalName("ErrNotBeControlledPlayer")]
		ErrNotBeControlledPlayer,
		// Token: 0x0400AF6F RID: 44911
		[OriginalName("ErrNotBeControlledNotPlayer")]
		ErrNotBeControlledNotPlayer,
		// Token: 0x0400AF70 RID: 44912
		[OriginalName("ErrBeControlledShowEntityNotExist")]
		ErrBeControlledShowEntityNotExist,
		// Token: 0x0400AF71 RID: 44913
		[OriginalName("ErrNotBeControlledShowEntity")]
		ErrNotBeControlledShowEntity,
		// Token: 0x0400AF72 RID: 44914
		[OriginalName("ErrNotBeControlledShowPlayer")]
		ErrNotBeControlledShowPlayer,
		// Token: 0x0400AF73 RID: 44915
		[OriginalName("ErrBeControlledShowNoChange")]
		ErrBeControlledShowNoChange,
		// Token: 0x0400AF74 RID: 44916
		[OriginalName("ErrGravityGearCondition")]
		ErrGravityGearCondition,
		// Token: 0x0400AF75 RID: 44917
		[OriginalName("ErrChairEntityNoExist")]
		ErrChairEntityNoExist,
		// Token: 0x0400AF76 RID: 44918
		[OriginalName("ErrChairSitDownErr")]
		ErrChairSitDownErr,
		// Token: 0x0400AF77 RID: 44919
		[OriginalName("ErrChairEntity")]
		ErrChairEntity,
		// Token: 0x0400AF78 RID: 44920
		[OriginalName("ErrPlayerAlreadySit")]
		ErrPlayerAlreadySit,
		// Token: 0x0400AF79 RID: 44921
		[OriginalName("ErrChairNotStateConfig")]
		ErrChairNotStateConfig,
		// Token: 0x0400AF7A RID: 44922
		[OriginalName("ErrSneakBtObjIncId")]
		ErrSneakBtObjIncId,
		// Token: 0x0400AF7B RID: 44923
		[OriginalName("ErrTimelineMove")]
		ErrTimelineMove,
		// Token: 0x0400AF7C RID: 44924
		[OriginalName("ErrBeControlledConfig")]
		ErrBeControlledConfig,
		// Token: 0x0400AF7D RID: 44925
		[OriginalName("ErrBeControlledThrow")]
		ErrBeControlledThrow,
		// Token: 0x0400AF7E RID: 44926
		[OriginalName("ErrBeControlledTimeNull")]
		ErrBeControlledTimeNull,
		// Token: 0x0400AF7F RID: 44927
		[OriginalName("ErrTriggerEnterActionEffective")]
		ErrTriggerEnterActionEffective,
		// Token: 0x0400AF80 RID: 44928
		[OriginalName("ErrTriggerLeaveActionEffective")]
		ErrTriggerLeaveActionEffective,
		// Token: 0x0400AF81 RID: 44929
		[OriginalName("ErrTriggerLastActionStateError")]
		ErrTriggerLastActionStateError,
		// Token: 0x0400AF82 RID: 44930
		[OriginalName("GuideGroupInfoIsNull")]
		GuideGroupInfoIsNull = 1100000,
		// Token: 0x0400AF83 RID: 44931
		[OriginalName("GuideStateError")]
		GuideStateError,
		// Token: 0x0400AF84 RID: 44932
		[OriginalName("GuideConfigNotFind")]
		GuideConfigNotFind,
		// Token: 0x0400AF85 RID: 44933
		[OriginalName("GuideNoEnough")]
		GuideNoEnough,
		// Token: 0x0400AF86 RID: 44934
		[OriginalName("GuideIsFinish")]
		GuideIsFinish,
		// Token: 0x0400AF87 RID: 44935
		[OriginalName("GuidePerIsNotFinish")]
		GuidePerIsNotFinish,
		// Token: 0x0400AF88 RID: 44936
		[OriginalName("GuideNoCondition")]
		GuideNoCondition,
		// Token: 0x0400AF89 RID: 44937
		[OriginalName("GuideNoCurGroup")]
		GuideNoCurGroup,
		// Token: 0x0400AF8A RID: 44938
		[OriginalName("GuideIsServerMonitor")]
		GuideIsServerMonitor,
		// Token: 0x0400AF8B RID: 44939
		[OriginalName("GuideNoPending")]
		GuideNoPending,
		// Token: 0x0400AF8C RID: 44940
		[OriginalName("GuideStepRepeat")]
		GuideStepRepeat,
		// Token: 0x0400AF8D RID: 44941
		[OriginalName("GuideGroupNoClient")]
		GuideGroupNoClient,
		// Token: 0x0400AF8E RID: 44942
		[OriginalName("GuideGroupDoing")]
		GuideGroupDoing,
		// Token: 0x0400AF8F RID: 44943
		[OriginalName("GuideGroupIsNotRepeat")]
		GuideGroupIsNotRepeat,
		// Token: 0x0400AF90 RID: 44944
		[OriginalName("GuideTutorialConfigNotFind")]
		GuideTutorialConfigNotFind,
		// Token: 0x0400AF91 RID: 44945
		[OriginalName("GuideTutorialIsUnlock")]
		GuideTutorialIsUnlock,
		// Token: 0x0400AF92 RID: 44946
		[OriginalName("GuideTutorialNotUnlock")]
		GuideTutorialNotUnlock,
		// Token: 0x0400AF93 RID: 44947
		[OriginalName("GuideTutorialIsReceive")]
		GuideTutorialIsReceive,
		// Token: 0x0400AF94 RID: 44948
		[OriginalName("GuideTutorialAwardConfigNotFind")]
		GuideTutorialAwardConfigNotFind,
		// Token: 0x0400AF95 RID: 44949
		[OriginalName("GuideTutorialAwardError")]
		GuideTutorialAwardError,
		// Token: 0x0400AF96 RID: 44950
		[OriginalName("GuideGroupIdNoMatch")]
		GuideGroupIdNoMatch,
		// Token: 0x0400AF97 RID: 44951
		[OriginalName("ErrRequestTypeNotExist")]
		ErrRequestTypeNotExist,
		// Token: 0x0400AF98 RID: 44952
		[OriginalName("ErrIllustratedEntryLock")]
		ErrIllustratedEntryLock,
		// Token: 0x0400AF99 RID: 44953
		[OriginalName("ErrIllustratedEntryBanUnlock")]
		ErrIllustratedEntryBanUnlock,
		// Token: 0x0400AF9A RID: 44954
		[OriginalName("ErrRequestTypeMax")]
		ErrRequestTypeMax,
		// Token: 0x0400AF9B RID: 44955
		[OriginalName("AchievementEntryNotExist")]
		AchievementEntryNotExist,
		// Token: 0x0400AF9C RID: 44956
		[OriginalName("AchievementEntryNotFinish")]
		AchievementEntryNotFinish,
		// Token: 0x0400AF9D RID: 44957
		[OriginalName("AchievementEntryIsReceive")]
		AchievementEntryIsReceive,
		// Token: 0x0400AF9E RID: 44958
		[OriginalName("AchievementEntryNoConfig")]
		AchievementEntryNoConfig,
		// Token: 0x0400AF9F RID: 44959
		[OriginalName("AchievementEntryNotOpen")]
		AchievementEntryNotOpen,
		// Token: 0x0400AFA0 RID: 44960
		[OriginalName("AchievementGroupEntryNotExist")]
		AchievementGroupEntryNotExist,
		// Token: 0x0400AFA1 RID: 44961
		[OriginalName("AchievementGroupEntryNotFinish")]
		AchievementGroupEntryNotFinish,
		// Token: 0x0400AFA2 RID: 44962
		[OriginalName("AchievementGroupEntryIsReceive")]
		AchievementGroupEntryIsReceive,
		// Token: 0x0400AFA3 RID: 44963
		[OriginalName("AchievementGroupEntryNoConfig")]
		AchievementGroupEntryNoConfig,
		// Token: 0x0400AFA4 RID: 44964
		[OriginalName("AchievementGroupEntryNotOpen")]
		AchievementGroupEntryNotOpen,
		// Token: 0x0400AFA5 RID: 44965
		[OriginalName("SilentAreaNotConfig")]
		SilentAreaNotConfig,
		// Token: 0x0400AFA6 RID: 44966
		[OriginalName("SilentAreaNotUnlock")]
		SilentAreaNotUnlock,
		// Token: 0x0400AFA7 RID: 44967
		[OriginalName("SilentAreaNotFinish")]
		SilentAreaNotFinish,
		// Token: 0x0400AFA8 RID: 44968
		[OriginalName("SilentAreaReceive")]
		SilentAreaReceive,
		// Token: 0x0400AFA9 RID: 44969
		[OriginalName("AchievementEntryIsFinish")]
		AchievementEntryIsFinish,
		// Token: 0x0400AFAA RID: 44970
		[OriginalName("AchievementEntryNeedCondition")]
		AchievementEntryNeedCondition,
		// Token: 0x0400AFAB RID: 44971
		[OriginalName("AchievementSceneNotFind")]
		AchievementSceneNotFind,
		// Token: 0x0400AFAC RID: 44972
		[OriginalName("BirthdayIsSetting")]
		BirthdayIsSetting,
		// Token: 0x0400AFAD RID: 44973
		[OriginalName("BirthdayInValid")]
		BirthdayInValid,
		// Token: 0x0400AFAE RID: 44974
		[OriginalName("RoleShowListMaxCount")]
		RoleShowListMaxCount,
		// Token: 0x0400AFAF RID: 44975
		[OriginalName("RoleShowListHasRepeatId")]
		RoleShowListHasRepeatId,
		// Token: 0x0400AFB0 RID: 44976
		[OriginalName("RoleShowListHasInValidId")]
		RoleShowListHasInValidId,
		// Token: 0x0400AFB1 RID: 44977
		[OriginalName("CardShowListMaxCount")]
		CardShowListMaxCount,
		// Token: 0x0400AFB2 RID: 44978
		[OriginalName("CardShowListHasRepeatId")]
		CardShowListHasRepeatId,
		// Token: 0x0400AFB3 RID: 44979
		[OriginalName("CardShowListHasInValidId")]
		CardShowListHasInValidId,
		// Token: 0x0400AFB4 RID: 44980
		[OriginalName("CardRepeatSet")]
		CardRepeatSet,
		// Token: 0x0400AFB5 RID: 44981
		[OriginalName("CardIsInValidId")]
		CardIsInValidId,
		// Token: 0x0400AFB6 RID: 44982
		[OriginalName("CardIsRead")]
		CardIsRead,
		// Token: 0x0400AFB7 RID: 44983
		[OriginalName("RoleShowListEmpty")]
		RoleShowListEmpty,
		// Token: 0x0400AFB8 RID: 44984
		[OriginalName("SettingNotFind")]
		SettingNotFind,
		// Token: 0x0400AFB9 RID: 44985
		[OriginalName("RogueRoadConfigNotFind")]
		RogueRoadConfigNotFind,
		// Token: 0x0400AFBA RID: 44986
		[OriginalName("RollRogueRoomError")]
		RollRogueRoomError,
		// Token: 0x0400AFBB RID: 44987
		[OriginalName("RollRogueBuffError")]
		RollRogueBuffError,
		// Token: 0x0400AFBC RID: 44988
		[OriginalName("GetRogueRoomIdsError")]
		GetRogueRoomIdsError,
		// Token: 0x0400AFBD RID: 44989
		[OriginalName("GetRoguePortalEntityNotFind")]
		GetRoguePortalEntityNotFind,
		// Token: 0x0400AFBE RID: 44990
		[OriginalName("GetRoguePortalLocationNotFind")]
		GetRoguePortalLocationNotFind,
		// Token: 0x0400AFBF RID: 44991
		[OriginalName("HttpTimeout")]
		HttpTimeout,
		// Token: 0x0400AFC0 RID: 44992
		[OriginalName("HttpResultUndefine")]
		HttpResultUndefine,
		// Token: 0x0400AFC1 RID: 44993
		[OriginalName("ConvGateTimeout")]
		ConvGateTimeout,
		// Token: 0x0400AFC2 RID: 44994
		[OriginalName("ProtoKeyTimeout")]
		ProtoKeyTimeout,
		// Token: 0x0400AFC3 RID: 44995
		[OriginalName("LoginReqTimeout")]
		LoginReqTimeout,
		// Token: 0x0400AFC4 RID: 44996
		[OriginalName("EnterGameTimeout")]
		EnterGameTimeout,
		// Token: 0x0400AFC5 RID: 44997
		[OriginalName("ReReconvReqTimeout")]
		ReReconvReqTimeout,
		// Token: 0x0400AFC6 RID: 44998
		[OriginalName("RecvSeqNoNotHit")]
		RecvSeqNoNotHit,
		// Token: 0x0400AFC7 RID: 44999
		[OriginalName("AchievementFuncNotOpen")]
		AchievementFuncNotOpen,
		// Token: 0x0400AFC8 RID: 45000
		[OriginalName("RoguelikeInstComponentNotFind")]
		RoguelikeInstComponentNotFind,
		// Token: 0x0400AFC9 RID: 45001
		[OriginalName("RogueCurRoomDataIsNull")]
		RogueCurRoomDataIsNull,
		// Token: 0x0400AFCA RID: 45002
		[OriginalName("LevelPlayComponentNotFind")]
		LevelPlayComponentNotFind,
		// Token: 0x0400AFCB RID: 45003
		[OriginalName("OpenLevelPlayFail")]
		OpenLevelPlayFail,
		// Token: 0x0400AFCC RID: 45004
		[OriginalName("CloseLevelPlayFail")]
		CloseLevelPlayFail,
		// Token: 0x0400AFCD RID: 45005
		[OriginalName("RogueRoomConfigNotFind")]
		RogueRoomConfigNotFind,
		// Token: 0x0400AFCE RID: 45006
		[OriginalName("RogueRoomTypeNotRight")]
		RogueRoomTypeNotRight,
		// Token: 0x0400AFCF RID: 45007
		[OriginalName("RogueRoomTypeNotConfig")]
		RogueRoomTypeNotConfig,
		// Token: 0x0400AFD0 RID: 45008
		[OriginalName("RogueRoomSubLevelNotFind")]
		RogueRoomSubLevelNotFind,
		// Token: 0x0400AFD1 RID: 45009
		[OriginalName("SelectNextRoomIsValid")]
		SelectNextRoomIsValid,
		// Token: 0x0400AFD2 RID: 45010
		[OriginalName("RogueGainPackageFail")]
		RogueGainPackageFail,
		// Token: 0x0400AFD3 RID: 45011
		[OriginalName("RogueGainListIsNull")]
		RogueGainListIsNull,
		// Token: 0x0400AFD4 RID: 45012
		[OriginalName("RogueGainIdValid")]
		RogueGainIdValid,
		// Token: 0x0400AFD5 RID: 45013
		[OriginalName("QulityListCountNotRight")]
		QulityListCountNotRight,
		// Token: 0x0400AFD6 RID: 45014
		[OriginalName("RandomResultCountNotRight")]
		RandomResultCountNotRight,
		// Token: 0x0400AFD7 RID: 45015
		[OriginalName("GuaranteeRogueBuffInValid")]
		GuaranteeRogueBuffInValid,
		// Token: 0x0400AFD8 RID: 45016
		[OriginalName("RoleBuffPoolNotFind")]
		RoleBuffPoolNotFind,
		// Token: 0x0400AFD9 RID: 45017
		[OriginalName("NotValidBuff")]
		NotValidBuff,
		// Token: 0x0400AFDA RID: 45018
		[OriginalName("NotValidPhantom")]
		NotValidPhantom,
		// Token: 0x0400AFDB RID: 45019
		[OriginalName("RandomPhantomFail")]
		RandomPhantomFail,
		// Token: 0x0400AFDC RID: 45020
		[OriginalName("NotValidRole")]
		NotValidRole,
		// Token: 0x0400AFDD RID: 45021
		[OriginalName("RandomRoleFail")]
		RandomRoleFail,
		// Token: 0x0400AFDE RID: 45022
		[OriginalName("RogueRoadNotFind")]
		RogueRoadNotFind,
		// Token: 0x0400AFDF RID: 45023
		[OriginalName("ResultCountNotMatch")]
		ResultCountNotMatch,
		// Token: 0x0400AFE0 RID: 45024
		[OriginalName("InValidRoomCountNotMatch")]
		InValidRoomCountNotMatch,
		// Token: 0x0400AFE1 RID: 45025
		[OriginalName("GuaranteeRogueRoomInValid")]
		GuaranteeRogueRoomInValid,
		// Token: 0x0400AFE2 RID: 45026
		[OriginalName("InstIdNotMatchLevelPlayId")]
		InstIdNotMatchLevelPlayId,
		// Token: 0x0400AFE3 RID: 45027
		[OriginalName("GetRoomBornPositionFail")]
		GetRoomBornPositionFail,
		// Token: 0x0400AFE4 RID: 45028
		[OriginalName("RoguePortalDataNotClean")]
		RoguePortalDataNotClean,
		// Token: 0x0400AFE5 RID: 45029
		[OriginalName("RoguePortalRoomDataNotFind")]
		RoguePortalRoomDataNotFind,
		// Token: 0x0400AFE6 RID: 45030
		[OriginalName("RogueSelectRoomFail")]
		RogueSelectRoomFail,
		// Token: 0x0400AFE7 RID: 45031
		[OriginalName("RogueProgressDataIsEmpty")]
		RogueProgressDataIsEmpty,
		// Token: 0x0400AFE8 RID: 45032
		[OriginalName("RogueGainTypeIsValid")]
		RogueGainTypeIsValid,
		// Token: 0x0400AFE9 RID: 45033
		[OriginalName("RougeNotOpen")]
		RougeNotOpen,
		// Token: 0x0400AFEA RID: 45034
		[OriginalName("RougeInstIdIsValid")]
		RougeInstIdIsValid,
		// Token: 0x0400AFEB RID: 45035
		[OriginalName("RogueRoleListCountNotRight")]
		RogueRoleListCountNotRight,
		// Token: 0x0400AFEC RID: 45036
		[OriginalName("RogueMainRoleConfigNotFind")]
		RogueMainRoleConfigNotFind,
		// Token: 0x0400AFED RID: 45037
		[OriginalName("RogueGainDataDictError")]
		RogueGainDataDictError,
		// Token: 0x0400AFEE RID: 45038
		[OriginalName("RogueDiscountedBuffConfigNotFind")]
		RogueDiscountedBuffConfigNotFind,
		// Token: 0x0400AFEF RID: 45039
		[OriginalName("RogueDiscountedRoomTypeConfigNotFind")]
		RogueDiscountedRoomTypeConfigNotFind,
		// Token: 0x0400AFF0 RID: 45040
		[OriginalName("RogueDiscountedShopConfigNotFind")]
		RogueDiscountedShopConfigNotFind,
		// Token: 0x0400AFF1 RID: 45041
		[OriginalName("RogueDiscountedCalculateFail")]
		RogueDiscountedCalculateFail,
		// Token: 0x0400AFF2 RID: 45042
		[OriginalName("RogueMoneyNotEnough")]
		RogueMoneyNotEnough,
		// Token: 0x0400AFF3 RID: 45043
		[OriginalName("RougeShopRefreshTimeEmpyt")]
		RougeShopRefreshTimeEmpyt,
		// Token: 0x0400AFF4 RID: 45044
		[OriginalName("RougeCurRoomNotFinish")]
		RougeCurRoomNotFinish,
		// Token: 0x0400AFF5 RID: 45045
		[OriginalName("PlayerDataRepairErrorDebug")]
		PlayerDataRepairErrorDebug,
		// Token: 0x0400AFF6 RID: 45046
		[OriginalName("PlayerDataRepairError")]
		PlayerDataRepairError,
		// Token: 0x0400AFF7 RID: 45047
		[OriginalName("CreateCharacterReqTimeout")]
		CreateCharacterReqTimeout,
		// Token: 0x0400AFF8 RID: 45048
		[OriginalName("SignActivityNotOpen")]
		SignActivityNotOpen,
		// Token: 0x0400AFF9 RID: 45049
		[OriginalName("SignActivityNoConfig")]
		SignActivityNoConfig,
		// Token: 0x0400AFFA RID: 45050
		[OriginalName("SignActivityIndexValid")]
		SignActivityIndexValid,
		// Token: 0x0400AFFB RID: 45051
		[OriginalName("SignActivityNoData")]
		SignActivityNoData,
		// Token: 0x0400AFFC RID: 45052
		[OriginalName("SignActivityStateNotRight")]
		SignActivityStateNotRight,
		// Token: 0x0400AFFD RID: 45053
		[OriginalName("RogueSeasonDataNull")]
		RogueSeasonDataNull,
		// Token: 0x0400AFFE RID: 45054
		[OriginalName("RogueSeasonConfigNotFind")]
		RogueSeasonConfigNotFind,
		// Token: 0x0400AFFF RID: 45055
		[OriginalName("RogueTokenConfigNotFind")]
		RogueTokenConfigNotFind,
		// Token: 0x0400B000 RID: 45056
		[OriginalName("RogueTokenStatusVaild")]
		RogueTokenStatusVaild,
		// Token: 0x0400B001 RID: 45057
		[OriginalName("RogueSeasonRewardConfigNotFind")]
		RogueSeasonRewardConfigNotFind,
		// Token: 0x0400B002 RID: 45058
		[OriginalName("RogueSeasonRewardIsReceive")]
		RogueSeasonRewardIsReceive,
		// Token: 0x0400B003 RID: 45059
		[OriginalName("RougeSeasonPointNotEnough")]
		RougeSeasonPointNotEnough,
		// Token: 0x0400B004 RID: 45060
		[OriginalName("RougeRoomDataError")]
		RougeRoomDataError,
		// Token: 0x0400B005 RID: 45061
		[OriginalName("RogueGainDataError")]
		RogueGainDataError,
		// Token: 0x0400B006 RID: 45062
		[OriginalName("RogueRoleIdsError")]
		RogueRoleIdsError,
		// Token: 0x0400B007 RID: 45063
		[OriginalName("RogueRogueRoomRouteError")]
		RogueRogueRoomRouteError,
		// Token: 0x0400B008 RID: 45064
		[OriginalName("RogueGetCurRoomLevelPlayError")]
		RogueGetCurRoomLevelPlayError,
		// Token: 0x0400B009 RID: 45065
		[OriginalName("RogueTalentTreeConfigNotFind")]
		RogueTalentTreeConfigNotFind,
		// Token: 0x0400B00A RID: 45066
		[OriginalName("RogueTalentTreeConditionNotMet")]
		RogueTalentTreeConditionNotMet,
		// Token: 0x0400B00B RID: 45067
		[OriginalName("RogueTalentTreePerNodeLock")]
		RogueTalentTreePerNodeLock,
		// Token: 0x0400B00C RID: 45068
		[OriginalName("RogueTalentTreeNodeMaxLevel")]
		RogueTalentTreeNodeMaxLevel,
		// Token: 0x0400B00D RID: 45069
		[OriginalName("RogueTalentTreeConsumeNoEnough")]
		RogueTalentTreeConsumeNoEnough,
		// Token: 0x0400B00E RID: 45070
		[OriginalName("RogueRoadRandomRoleBuffError")]
		RogueRoadRandomRoleBuffError,
		// Token: 0x0400B00F RID: 45071
		[OriginalName("ActivityFuncNotOpen")]
		ActivityFuncNotOpen,
		// Token: 0x0400B010 RID: 45072
		[OriginalName("RogueGuideInstNotSupport")]
		RogueGuideInstNotSupport,
		// Token: 0x0400B011 RID: 45073
		[OriginalName("ErrPayReceiptCannotRefundClose")]
		ErrPayReceiptCannotRefundClose,
		// Token: 0x0400B012 RID: 45074
		[OriginalName("ErrPayReceiptRefundCloseFail")]
		ErrPayReceiptRefundCloseFail,
		// Token: 0x0400B013 RID: 45075
		[OriginalName("PayRefundOverdueBan")]
		PayRefundOverdueBan,
		// Token: 0x0400B014 RID: 45076
		[OriginalName("UnknowChannelId")]
		UnknowChannelId,
		// Token: 0x0400B015 RID: 45077
		[OriginalName("LoginServerNotFind")]
		LoginServerNotFind,
		// Token: 0x0400B016 RID: 45078
		[OriginalName("OldGameNodeLogoutFail")]
		OldGameNodeLogoutFail,
		// Token: 0x0400B017 RID: 45079
		[OriginalName("LoginHandleSwitchError")]
		LoginHandleSwitchError,
		// Token: 0x0400B018 RID: 45080
		[OriginalName("NoAvailableLoginService")]
		NoAvailableLoginService,
		// Token: 0x0400B019 RID: 45081
		[OriginalName("ServerIsClosing")]
		ServerIsClosing,
		// Token: 0x0400B01A RID: 45082
		[OriginalName("AddPlayerRecordFail")]
		AddPlayerRecordFail,
		// Token: 0x0400B01B RID: 45083
		[OriginalName("FindGatewayFail")]
		FindGatewayFail,
		// Token: 0x0400B01C RID: 45084
		[OriginalName("CommonFightRolesInfoError")]
		CommonFightRolesInfoError,
		// Token: 0x0400B01D RID: 45085
		[OriginalName("CurRoleEntityNotFind")]
		CurRoleEntityNotFind,
		// Token: 0x0400B01E RID: 45086
		[OriginalName("ScenePlayerInfoNotFind")]
		ScenePlayerInfoNotFind,
		// Token: 0x0400B01F RID: 45087
		[OriginalName("IncrAdviceVoteError")]
		IncrAdviceVoteError,
		// Token: 0x0400B020 RID: 45088
		[OriginalName("InsertAdviceError")]
		InsertAdviceError,
		// Token: 0x0400B021 RID: 45089
		[OriginalName("UpdateAdviceError")]
		UpdateAdviceError,
		// Token: 0x0400B022 RID: 45090
		[OriginalName("DeleteAdviceError")]
		DeleteAdviceError,
		// Token: 0x0400B023 RID: 45091
		[OriginalName("EntityNoInWater")]
		EntityNoInWater,
		// Token: 0x0400B024 RID: 45092
		[OriginalName("AttributeComponentNotFind")]
		AttributeComponentNotFind,
		// Token: 0x0400B025 RID: 45093
		[OriginalName("TryAddItemDataFail")]
		TryAddItemDataFail,
		// Token: 0x0400B026 RID: 45094
		[OriginalName("ItemConfigTypeNotRight")]
		ItemConfigTypeNotRight,
		// Token: 0x0400B027 RID: 45095
		[OriginalName("ItemLogicNotFind")]
		ItemLogicNotFind,
		// Token: 0x0400B028 RID: 45096
		[OriginalName("RemoveItemLogicNotFind")]
		RemoveItemLogicNotFind,
		// Token: 0x0400B029 RID: 45097
		[OriginalName("AddItemLogicNotFind")]
		AddItemLogicNotFind,
		// Token: 0x0400B02A RID: 45098
		[OriginalName("AddItemFail")]
		AddItemFail,
		// Token: 0x0400B02B RID: 45099
		[OriginalName("UpdatePlayerARemarkFail")]
		UpdatePlayerAremarkFail,
		// Token: 0x0400B02C RID: 45100
		[OriginalName("DeleteFriendApplyFail")]
		DeleteFriendApplyFail,
		// Token: 0x0400B02D RID: 45101
		[OriginalName("DeleteFriendshipFail")]
		DeleteFriendshipFail,
		// Token: 0x0400B02E RID: 45102
		[OriginalName("WorldTeamIsNull")]
		WorldTeamIsNull,
		// Token: 0x0400B02F RID: 45103
		[OriginalName("TeamCountNotRight")]
		TeamCountNotRight,
		// Token: 0x0400B030 RID: 45104
		[OriginalName("AddCalabashExpFail")]
		AddCalabashExpFail,
		// Token: 0x0400B031 RID: 45105
		[OriginalName("SendRequestToSdkFail")]
		SendRequestToSdkFail,
		// Token: 0x0400B032 RID: 45106
		[OriginalName("DirtyWordErrorCode")]
		DirtyWordErrorCode,
		// Token: 0x0400B033 RID: 45107
		[OriginalName("HarvestActivityNotOpen")]
		HarvestActivityNotOpen,
		// Token: 0x0400B034 RID: 45108
		[OriginalName("HarvestActivityPointReceived")]
		HarvestActivityPointReceived,
		// Token: 0x0400B035 RID: 45109
		[OriginalName("HarvestActivityPointNotConfig")]
		HarvestActivityPointNotConfig,
		// Token: 0x0400B036 RID: 45110
		[OriginalName("HarvestActivityPointNotEnough")]
		HarvestActivityPointNotEnough,
		// Token: 0x0400B037 RID: 45111
		[OriginalName("HarvestActivityLevelNoData")]
		HarvestActivityLevelNoData,
		// Token: 0x0400B038 RID: 45112
		[OriginalName("HarvestActivityLevelReceived")]
		HarvestActivityLevelReceived,
		// Token: 0x0400B039 RID: 45113
		[OriginalName("HarvestActivityLevelNotConfig")]
		HarvestActivityLevelNotConfig,
		// Token: 0x0400B03A RID: 45114
		[OriginalName("HarvestActivityLevelNotEnough")]
		HarvestActivityLevelNotEnough,
		// Token: 0x0400B03B RID: 45115
		[OriginalName("HarvestActivityLevelDiffNotConfig")]
		HarvestActivityLevelDiffNotConfig,
		// Token: 0x0400B03C RID: 45116
		[OriginalName("RoguelikeEventConfigNotFind")]
		RoguelikeEventConfigNotFind,
		// Token: 0x0400B03D RID: 45117
		[OriginalName("RoguelikeEventIndexError")]
		RoguelikeEventIndexError,
		// Token: 0x0400B03E RID: 45118
		[OriginalName("RoguelikeInstConfigNotFind")]
		RoguelikeInstConfigNotFind,
		// Token: 0x0400B03F RID: 45119
		[OriginalName("RoguelikeMainRoleError")]
		RoguelikeMainRoleError,
		// Token: 0x0400B040 RID: 45120
		[OriginalName("RoguelikeEventIsEmpty")]
		RoguelikeEventIsEmpty,
		// Token: 0x0400B041 RID: 45121
		[OriginalName("RoguelikeEventRandomError")]
		RoguelikeEventRandomError,
		// Token: 0x0400B042 RID: 45122
		[OriginalName("RoguelikeEventRandomEmpty")]
		RoguelikeEventRandomEmpty,
		// Token: 0x0400B043 RID: 45123
		[OriginalName("PhantomCollectActivityNotOpen")]
		PhantomCollectActivityNotOpen,
		// Token: 0x0400B044 RID: 45124
		[OriginalName("PhantomCollectActivitynNotConfig")]
		PhantomCollectActivitynNotConfig,
		// Token: 0x0400B045 RID: 45125
		[OriginalName("PhantomCollectActivitynNoData")]
		PhantomCollectActivitynNoData,
		// Token: 0x0400B046 RID: 45126
		[OriginalName("PhantomCollectActivityReceived")]
		PhantomCollectActivityReceived,
		// Token: 0x0400B047 RID: 45127
		[OriginalName("HarvestInstIdInValid")]
		HarvestInstIdInValid,
		// Token: 0x0400B048 RID: 45128
		[OriginalName("HarvestVarNotExist")]
		HarvestVarNotExist,
		// Token: 0x0400B049 RID: 45129
		[OriginalName("HarvestResultCacheNotExist")]
		HarvestResultCacheNotExist,
		// Token: 0x0400B04A RID: 45130
		[OriginalName("HarvestInstNotOpen")]
		HarvestInstNotOpen,
		// Token: 0x0400B04B RID: 45131
		[OriginalName("HarvestActivityLimitDataNotFind")]
		HarvestActivityLimitDataNotFind,
		// Token: 0x0400B04C RID: 45132
		[OriginalName("HarvestDiffConfigNotFind")]
		HarvestDiffConfigNotFind,
		// Token: 0x0400B04D RID: 45133
		[OriginalName("HarvestActivityDiffConfigNotFind")]
		HarvestActivityDiffConfigNotFind,
		// Token: 0x0400B04E RID: 45134
		[OriginalName("ErrIllustratedConfigNotFind")]
		ErrIllustratedConfigNotFind,
		// Token: 0x0400B04F RID: 45135
		[OriginalName("CharacterAlreadyCreated")]
		CharacterAlreadyCreated,
		// Token: 0x0400B050 RID: 45136
		[OriginalName("SdkHelperInternalError")]
		SdkHelperInternalError,
		// Token: 0x0400B051 RID: 45137
		[OriginalName("GameServiceControllerInternalError")]
		GameServiceControllerInternalError,
		// Token: 0x0400B052 RID: 45138
		[OriginalName("DoGetCacheInfoInternalError")]
		DoGetCacheInfoInternalError,
		// Token: 0x0400B053 RID: 45139
		[OriginalName("DoGetCacheInfosInternalError")]
		DoGetCacheInfosInternalError,
		// Token: 0x0400B054 RID: 45140
		[OriginalName("DeleteFriendLoadedInternalError")]
		DeleteFriendLoadedInternalError,
		// Token: 0x0400B055 RID: 45141
		[OriginalName("UpdateFriendRemarkInternalError")]
		UpdateFriendRemarkInternalError,
		// Token: 0x0400B056 RID: 45142
		[OriginalName("CheckApplyRequestInternalError")]
		CheckApplyRequestInternalError,
		// Token: 0x0400B057 RID: 45143
		[OriginalName("OnReLoginInternalError")]
		OnReLoginInternalError,
		// Token: 0x0400B058 RID: 45144
		[OriginalName("CreateCharacterRequestInternalError")]
		CreateCharacterRequestInternalError,
		// Token: 0x0400B059 RID: 45145
		[OriginalName("LoginRequestInternalError")]
		LoginRequestInternalError,
		// Token: 0x0400B05A RID: 45146
		[OriginalName("LoginRequestInternalError2")]
		LoginRequestInternalError2,
		// Token: 0x0400B05B RID: 45147
		[OriginalName("EnterGameRequestInternalError")]
		EnterGameRequestInternalError,
		// Token: 0x0400B05C RID: 45148
		[OriginalName("ReconnectRequestInternalError")]
		ReconnectRequestInternalError,
		// Token: 0x0400B05D RID: 45149
		[OriginalName("ReconnectRequestInternalError2")]
		ReconnectRequestInternalError2,
		// Token: 0x0400B05E RID: 45150
		[OriginalName("SwitchNodeInternalError")]
		SwitchNodeInternalError,
		// Token: 0x0400B05F RID: 45151
		[OriginalName("InnerLoginInternalError")]
		InnerLoginInternalError,
		// Token: 0x0400B060 RID: 45152
		[OriginalName("AccessTokenInternalError")]
		AccessTokenInternalError,
		// Token: 0x0400B061 RID: 45153
		[OriginalName("CreateCharacterInternalError")]
		CreateCharacterInternalError,
		// Token: 0x0400B062 RID: 45154
		[OriginalName("RogueSeasonNotValid")]
		RogueSeasonNotValid,
		// Token: 0x0400B063 RID: 45155
		[OriginalName("RogueCurRoleNotFind")]
		RogueCurRoleNotFind,
		// Token: 0x0400B064 RID: 45156
		[OriginalName("RogueSeasonNotMatch")]
		RogueSeasonNotMatch,
		// Token: 0x0400B065 RID: 45157
		[OriginalName("RogueGainLogicNotFind")]
		RogueGainLogicNotFind,
		// Token: 0x0400B066 RID: 45158
		[OriginalName("RogueBuffConfigNotFind")]
		RogueBuffConfigNotFind,
		// Token: 0x0400B067 RID: 45159
		[OriginalName("RoguePhantomNotConfig")]
		RoguePhantomNotConfig,
		// Token: 0x0400B068 RID: 45160
		[OriginalName("RogueRoleNotConfig")]
		RogueRoleNotConfig,
		// Token: 0x0400B069 RID: 45161
		[OriginalName("RoguePopularSlotConfigNotFind")]
		RoguePopularSlotConfigNotFind,
		// Token: 0x0400B06A RID: 45162
		[OriginalName("RoguePopularCountIsMax")]
		RoguePopularCountIsMax,
		// Token: 0x0400B06B RID: 45163
		[OriginalName("RoguePopularConfigNotFind")]
		RoguePopularConfigNotFind,
		// Token: 0x0400B06C RID: 45164
		[OriginalName("RogueRoleNotOpen")]
		RogueRoleNotOpen,
		// Token: 0x0400B06D RID: 45165
		[OriginalName("RogueGuideInstError")]
		RogueGuideInstError,
		// Token: 0x0400B06E RID: 45166
		[OriginalName("RogueMainRoleChange")]
		RogueMainRoleChange,
		// Token: 0x0400B06F RID: 45167
		[OriginalName("RogueShopConfigNull")]
		RogueShopConfigNull,
		// Token: 0x0400B070 RID: 45168
		[OriginalName("RogueGainIsSelect")]
		RogueGainIsSelect,
		// Token: 0x0400B071 RID: 45169
		[OriginalName("RogueGainNoRefresh")]
		RogueGainNoRefresh,
		// Token: 0x0400B072 RID: 45170
		[OriginalName("RogueRefreshCostNotFind")]
		RogueRefreshCostNotFind,
		// Token: 0x0400B073 RID: 45171
		[OriginalName("RogueNotMaxLayer")]
		RogueNotMaxLayer,
		// Token: 0x0400B074 RID: 45172
		[OriginalName("RogueRoomSubLevelNotFind2")]
		RogueRoomSubLevelNotFind2,
		// Token: 0x0400B075 RID: 45173
		[OriginalName("RoguePopularSlotArgConfigNotFind")]
		RoguePopularSlotArgConfigNotFind,
		// Token: 0x0400B076 RID: 45174
		[OriginalName("RogueInstSeasonNotMatch")]
		RogueInstSeasonNotMatch,
		// Token: 0x0400B077 RID: 45175
		[OriginalName("RogueSeasonTalentTreeNotFind")]
		RogueSeasonTalentTreeNotFind,
		// Token: 0x0400B078 RID: 45176
		[OriginalName("RogueGainOptionsNotFind")]
		RogueGainOptionsNotFind,
		// Token: 0x0400B079 RID: 45177
		[OriginalName("RogueGainIsSell")]
		RogueGainIsSell,
		// Token: 0x0400B07A RID: 45178
		[OriginalName("RogueMiracleCreationConfNotFind")]
		RogueMiracleCreationConfNotFind,
		// Token: 0x0400B07B RID: 45179
		[OriginalName("RogueGainPackageError")]
		RogueGainPackageError,
		// Token: 0x0400B07C RID: 45180
		[OriginalName("RogueTrialRoleIdsCountNotRight")]
		RogueTrialRoleIdsCountNotRight,
		// Token: 0x0400B07D RID: 45181
		[OriginalName("RogueVarNotExist")]
		RogueVarNotExist,
		// Token: 0x0400B07E RID: 45182
		[OriginalName("RougeWhiteCatConfigNotFind")]
		RougeWhiteCatConfigNotFind,
		// Token: 0x0400B07F RID: 45183
		[OriginalName("RougeWhiteCatNotOpen")]
		RougeWhiteCatNotOpen,
		// Token: 0x0400B080 RID: 45184
		[OriginalName("RougeWhiteCatLimitedTime")]
		RougeWhiteCatLimitedTime,
		// Token: 0x0400B081 RID: 45185
		[OriginalName("RougeWhiteCatRewardLock")]
		RougeWhiteCatRewardLock,
		// Token: 0x0400B082 RID: 45186
		[OriginalName("RougeWhiteCatRewardIsReceive")]
		RougeWhiteCatRewardIsReceive,
		// Token: 0x0400B083 RID: 45187
		[OriginalName("RougeWhiteCatRewardIndexErr")]
		RougeWhiteCatRewardIndexErr,
		// Token: 0x0400B084 RID: 45188
		[OriginalName("RougeWhiteCatInstIndexErr")]
		RougeWhiteCatInstIndexErr,
		// Token: 0x0400B085 RID: 45189
		[OriginalName("RougeWhiteCatInstLock")]
		RougeWhiteCatInstLock,
		// Token: 0x0400B086 RID: 45190
		[OriginalName("RougeWhiteCatBossRewardIndexErr")]
		RougeWhiteCatBossRewardIndexErr,
		// Token: 0x0400B087 RID: 45191
		[OriginalName("RougeWhiteCatBossRewardLock")]
		RougeWhiteCatBossRewardLock,
		// Token: 0x0400B088 RID: 45192
		[OriginalName("RougeWhiteCatBossRewardIsReceive")]
		RougeWhiteCatBossRewardIsReceive,
		// Token: 0x0400B089 RID: 45193
		[OriginalName("RougeWhiteCatLevelPlayIndexErr")]
		RougeWhiteCatLevelPlayIndexErr,
		// Token: 0x0400B08A RID: 45194
		[OriginalName("RougeWhiteCatLevelPlayLock")]
		RougeWhiteCatLevelPlayLock,
		// Token: 0x0400B08B RID: 45195
		[OriginalName("RougeWhiteCatLevelPlayIsReceive")]
		RougeWhiteCatLevelPlayIsReceive,
		// Token: 0x0400B08C RID: 45196
		[OriginalName("ResourceVersionTooLow")]
		ResourceVersionTooLow,
		// Token: 0x0400B08D RID: 45197
		[OriginalName("RogueLimitTimeRewardConfigNotFind")]
		RogueLimitTimeRewardConfigNotFind,
		// Token: 0x0400B08E RID: 45198
		[OriginalName("RogueWhiteCatLimitedTimeOut")]
		RogueWhiteCatLimitedTimeOut,
		// Token: 0x0400B08F RID: 45199
		[OriginalName("RougeWhiteCatLimitedRewardLock")]
		RougeWhiteCatLimitedRewardLock,
		// Token: 0x0400B090 RID: 45200
		[OriginalName("RougeWhiteCatLimitedRewardIsReceive")]
		RougeWhiteCatLimitedRewardIsReceive,
		// Token: 0x0400B091 RID: 45201
		[OriginalName("RougeWhiteCatBlackFlowerNoCount")]
		RougeWhiteCatBlackFlowerNoCount,
		// Token: 0x0400B092 RID: 45202
		[OriginalName("RogueInstCountNotRight")]
		RogueInstCountNotRight,
		// Token: 0x0400B093 RID: 45203
		[OriginalName("RogueInstFightFormationNotConfig")]
		RogueInstFightFormationNotConfig,
		// Token: 0x0400B094 RID: 45204
		[OriginalName("RogueTrialRoleNotValid")]
		RogueTrialRoleNotValid,
		// Token: 0x0400B095 RID: 45205
		[OriginalName("RogueRoleNotValid")]
		RogueRoleNotValid,
		// Token: 0x0400B096 RID: 45206
		[OriginalName("ErrorBlackFlowerEntityNotRight")]
		ErrorBlackFlowerEntityNotRight,
		// Token: 0x0400B097 RID: 45207
		[OriginalName("ErrorBlackFlowerStatus")]
		ErrorBlackFlowerStatus,
		// Token: 0x0400B098 RID: 45208
		[OriginalName("ErrorBlackFlowerCanNotReward")]
		ErrorBlackFlowerCanNotReward,
		// Token: 0x0400B099 RID: 45209
		[OriginalName("ErrorBlackFlowerRewardFail")]
		ErrorBlackFlowerRewardFail,
		// Token: 0x0400B09A RID: 45210
		[OriginalName("ErrorPhantomUnlockError")]
		ErrorPhantomUnlockError,
		// Token: 0x0400B09B RID: 45211
		[OriginalName("ErrorPhantomSwitchError")]
		ErrorPhantomSwitchError,
		// Token: 0x0400B09C RID: 45212
		[OriginalName("ActivityConfigNotFind")]
		ActivityConfigNotFind,
		// Token: 0x0400B09D RID: 45213
		[OriginalName("ActivityNotOpen")]
		ActivityNotOpen,
		// Token: 0x0400B09E RID: 45214
		[OriginalName("DirectTrainActivityConfigNotFind")]
		DirectTrainActivityConfigNotFind,
		// Token: 0x0400B09F RID: 45215
		[OriginalName("ActivityTypeNotFind")]
		ActivityTypeNotFind,
		// Token: 0x0400B0A0 RID: 45216
		[OriginalName("SetGlobalVarFail")]
		SetGlobalVarFail,
		// Token: 0x0400B0A1 RID: 45217
		[OriginalName("ErrMultigame")]
		ErrMultigame,
		// Token: 0x0400B0A2 RID: 45218
		[OriginalName("RogueWeeklyCycleNoFind")]
		RogueWeeklyCycleNoFind,
		// Token: 0x0400B0A3 RID: 45219
		[OriginalName("RogueWeeklyCycleIdNotMatch")]
		RogueWeeklyCycleIdNotMatch,
		// Token: 0x0400B0A4 RID: 45220
		[OriginalName("RogueWeeklyCycleInstIdNotMatch")]
		RogueWeeklyCycleInstIdNotMatch,
		// Token: 0x0400B0A5 RID: 45221
		[OriginalName("RogueWeeklyCycleSexNotMatch")]
		RogueWeeklyCycleSexNotMatch,
		// Token: 0x0400B0A6 RID: 45222
		[OriginalName("RogueWeeklyCycleActivityIdNotMatch")]
		RogueWeeklyCycleActivityIdNotMatch,
		// Token: 0x0400B0A7 RID: 45223
		[OriginalName("RogueWeeklyCycleAwardNotFind")]
		RogueWeeklyCycleAwardNotFind,
		// Token: 0x0400B0A8 RID: 45224
		[OriginalName("RogueWeeklyCycleAwardStateNotMatch")]
		RogueWeeklyCycleAwardStateNotMatch,
		// Token: 0x0400B0A9 RID: 45225
		[OriginalName("RogueWeeklyInstResultFail")]
		RogueWeeklyInstResultFail,
		// Token: 0x0400B0AA RID: 45226
		[OriginalName("RogueWeeklyGoldNoEnough")]
		RogueWeeklyGoldNoEnough,
		// Token: 0x0400B0AB RID: 45227
		[OriginalName("HasRogueProgressCanNotChangeSex")]
		HasRogueProgressCanNotChangeSex,
		// Token: 0x0400B0AC RID: 45228
		[OriginalName("RogueWeeklyWorldLevelNotMatch")]
		RogueWeeklyWorldLevelNotMatch,
		// Token: 0x0400B0AD RID: 45229
		[OriginalName("ResourceVersionIsTooLowWithTips")]
		ResourceVersionIsTooLowWithTips,
		// Token: 0x0400B0AE RID: 45230
		[OriginalName("RogueResInstIdNotMatch")]
		RogueResInstIdNotMatch,
		// Token: 0x0400B0AF RID: 45231
		[OriginalName("RogueResInstGridConfigNotFind")]
		RogueResInstGridConfigNotFind,
		// Token: 0x0400B0B0 RID: 45232
		[OriginalName("RogueResInBossInst")]
		RogueResInBossInst,
		// Token: 0x0400B0B1 RID: 45233
		[OriginalName("RogueResCurGridIsNull")]
		RogueResCurGridIsNull,
		// Token: 0x0400B0B2 RID: 45234
		[OriginalName("RogueResPathCountFail")]
		RogueResPathCountFail,
		// Token: 0x0400B0B3 RID: 45235
		[OriginalName("RogueResPathRepeat")]
		RogueResPathRepeat,
		// Token: 0x0400B0B4 RID: 45236
		[OriginalName("RogueResPathGridNoNear")]
		RogueResPathGridNoNear,
		// Token: 0x0400B0B5 RID: 45237
		[OriginalName("RogueResPathGridNoValid")]
		RogueResPathGridNoValid,
		// Token: 0x0400B0B6 RID: 45238
		[OriginalName("RogueResPathGridNoVision")]
		RogueResPathGridNoVision,
		// Token: 0x0400B0B7 RID: 45239
		[OriginalName("RogueResPathGridBlock")]
		RogueResPathGridBlock,
		// Token: 0x0400B0B8 RID: 45240
		[OriginalName("RogueResPlayerBanMove")]
		RogueResPlayerBanMove,
		// Token: 0x0400B0B9 RID: 45241
		[OriginalName("RogueResHasOp")]
		RogueResHasOp,
		// Token: 0x0400B0BA RID: 45242
		[OriginalName("RogueResTrialRoleNotFind")]
		RogueResTrialRoleNotFind,
		// Token: 0x0400B0BB RID: 45243
		[OriginalName("RogueResTrialRoleNoValid")]
		RogueResTrialRoleNoValid,
		// Token: 0x0400B0BC RID: 45244
		[OriginalName("RogueResThemeConfNotFind")]
		RogueResThemeConfNotFind,
		// Token: 0x0400B0BD RID: 45245
		[OriginalName("RogueResCrossInstDataIsNull")]
		RogueResCrossInstDataIsNull,
		// Token: 0x0400B0BE RID: 45246
		[OriginalName("RogueResOpEmpty")]
		RogueResOpEmpty,
		// Token: 0x0400B0BF RID: 45247
		[OriginalName("RogueResOpNotMatch")]
		RogueResOpNotMatch,
		// Token: 0x0400B0C0 RID: 45248
		[OriginalName("RogueResCollectionConfNotFind")]
		RogueResCollectionConfNotFind,
		// Token: 0x0400B0C1 RID: 45249
		[OriginalName("RogueResCollectionStateErr")]
		RogueResCollectionStateErr,
		// Token: 0x0400B0C2 RID: 45250
		[OriginalName("RogueResEndingAwardConfNotFind")]
		RogueResEndingAwardConfNotFind,
		// Token: 0x0400B0C3 RID: 45251
		[OriginalName("RogueResEndingAwardIsReceived")]
		RogueResEndingAwardIsReceived,
		// Token: 0x0400B0C4 RID: 45252
		[OriginalName("RogueResEndingAwardNotFinish")]
		RogueResEndingAwardNotFinish,
		// Token: 0x0400B0C5 RID: 45253
		[OriginalName("RogueResTalentConfNotFind")]
		RogueResTalentConfNotFind,
		// Token: 0x0400B0C6 RID: 45254
		[OriginalName("RogueResTaskConfNotFind")]
		RogueResTaskConfNotFind,
		// Token: 0x0400B0C7 RID: 45255
		[OriginalName("RogueResTaskDatanotFind")]
		RogueResTaskDatanotFind,
		// Token: 0x0400B0C8 RID: 45256
		[OriginalName("RogueResTaskAwardIsReceived")]
		RogueResTaskAwardIsReceived,
		// Token: 0x0400B0C9 RID: 45257
		[OriginalName("RogueResTaskAwardNotFinish")]
		RogueResTaskAwardNotFinish,
		// Token: 0x0400B0CA RID: 45258
		[OriginalName("RogueResEffectConfNoFind")]
		RogueResEffectConfNoFind,
		// Token: 0x0400B0CB RID: 45259
		[OriginalName("RogueResOptionNoRestCount")]
		RogueResOptionNoRestCount,
		// Token: 0x0400B0CC RID: 45260
		[OriginalName("RogueResOptionCantMulti")]
		RogueResOptionCantMulti,
		// Token: 0x0400B0CD RID: 45261
		[OriginalName("RogueResOptionRepeat")]
		RogueResOptionRepeat,
		// Token: 0x0400B0CE RID: 45262
		[OriginalName("RogueResOptionCantGiveUp")]
		RogueResOptionCantGiveUp,
		// Token: 0x0400B0CF RID: 45263
		[OriginalName("RogueResOptionCantRefresh")]
		RogueResOptionCantRefresh,
		// Token: 0x0400B0D0 RID: 45264
		[OriginalName("RogueResOptionIndexNoValid")]
		RogueResOptionIndexNoValid,
		// Token: 0x0400B0D1 RID: 45265
		[OriginalName("RogueResOptionTypeError")]
		RogueResOptionTypeError,
		// Token: 0x0400B0D2 RID: 45266
		[OriginalName("RogueResOptionIsSelect")]
		RogueResOptionIsSelect,
		// Token: 0x0400B0D3 RID: 45267
		[OriginalName("RogueResCollectionIndexMax")]
		RogueResCollectionIndexMax,
		// Token: 0x0400B0D4 RID: 45268
		[OriginalName("RogueResCollectionDropConfigNoFind")]
		RogueResCollectionDropConfigNoFind,
		// Token: 0x0400B0D5 RID: 45269
		[OriginalName("RogueResNoBaseGainLogic")]
		RogueResNoBaseGainLogic,
		// Token: 0x0400B0D6 RID: 45270
		[OriginalName("RogueResGridAwardNoConf")]
		RogueResGridAwardNoConf,
		// Token: 0x0400B0D7 RID: 45271
		[OriginalName("RogueResBornPositionNoConf")]
		RogueResBornPositionNoConf,
		// Token: 0x0400B0D8 RID: 45272
		[OriginalName("RogueResEffectExecFail")]
		RogueResEffectExecFail,
		// Token: 0x0400B0D9 RID: 45273
		[OriginalName("RogueResOptionFinish")]
		RogueResOptionFinish,
		// Token: 0x0400B0DA RID: 45274
		[OriginalName("RogueResOpTypeErr")]
		RogueResOpTypeErr,
		// Token: 0x0400B0DB RID: 45275
		[OriginalName("RogueResGridEventNoConf")]
		RogueResGridEventNoConf,
		// Token: 0x0400B0DC RID: 45276
		[OriginalName("RogueResGridEventStepNoConf")]
		RogueResGridEventStepNoConf,
		// Token: 0x0400B0DD RID: 45277
		[OriginalName("RogueResStepOptionNoValid")]
		RogueResStepOptionNoValid,
		// Token: 0x0400B0DE RID: 45278
		[OriginalName("RogueResGridEventNoData")]
		RogueResGridEventNoData,
		// Token: 0x0400B0DF RID: 45279
		[OriginalName("RogueResSelectIndexNoValid")]
		RogueResSelectIndexNoValid,
		// Token: 0x0400B0E0 RID: 45280
		[OriginalName("RogueResGotoNextRoomNoData")]
		RogueResGotoNextRoomNoData,
		// Token: 0x0400B0E1 RID: 45281
		[OriginalName("RogueResSelectOpNoData")]
		RogueResSelectOpNoData,
		// Token: 0x0400B0E2 RID: 45282
		[OriginalName("RogueResBranchTaskNoConf")]
		RogueResBranchTaskNoConf,
		// Token: 0x0400B0E3 RID: 45283
		[OriginalName("RogueResBranchTaskNoData")]
		RogueResBranchTaskNoData,
		// Token: 0x0400B0E4 RID: 45284
		[OriginalName("RogueResBranchTaskIsReceive")]
		RogueResBranchTaskIsReceive,
		// Token: 0x0400B0E5 RID: 45285
		[OriginalName("RogueResBranchTaskNoFinish")]
		RogueResBranchTaskNoFinish,
		// Token: 0x0400B0E6 RID: 45286
		[OriginalName("RogueResTokenShopPriceErr")]
		RogueResTokenShopPriceErr,
		// Token: 0x0400B0E7 RID: 45287
		[OriginalName("RogueResTaskTypeErr")]
		RogueResTaskTypeErr,
		// Token: 0x0400B0E8 RID: 45288
		[OriginalName("RogueRandomNoPoolName")]
		RogueRandomNoPoolName,
		// Token: 0x0400B0E9 RID: 45289
		[OriginalName("RogueRandomNoHit")]
		RogueRandomNoHit,
		// Token: 0x0400B0EA RID: 45290
		[OriginalName("RogueRandomNoValidResult")]
		RogueRandomNoValidResult,
		// Token: 0x0400B0EB RID: 45291
		[OriginalName("RogueResFormationIdNoValid")]
		RogueResFormationIdNoValid,
		// Token: 0x0400B0EC RID: 45292
		[OriginalName("RogueResFormationRoleCountErr")]
		RogueResFormationRoleCountErr,
		// Token: 0x0400B0ED RID: 45293
		[OriginalName("RogueResRandomNoShopGoods")]
		RogueResRandomNoShopGoods,
		// Token: 0x0400B0EE RID: 45294
		[OriginalName("RogueResRandomShopGoodsNoEnough")]
		RogueResRandomShopGoodsNoEnough,
		// Token: 0x0400B0EF RID: 45295
		[OriginalName("RogueResFormationRoleNoValid")]
		RogueResFormationRoleNoValid,
		// Token: 0x0400B0F0 RID: 45296
		[OriginalName("RogueResFormationNoData")]
		RogueResFormationNoData,
		// Token: 0x0400B0F1 RID: 45297
		[OriginalName("RogueResGainRoleNoFind")]
		RogueResGainRoleNoFind,
		// Token: 0x0400B0F2 RID: 45298
		[OriginalName("RogueResGainRoleLvNoConf")]
		RogueResGainRoleLvNoConf,
		// Token: 0x0400B0F3 RID: 45299
		[OriginalName("RogueResGainRoleLvNoLv")]
		RogueResGainRoleLvNoLv,
		// Token: 0x0400B0F4 RID: 45300
		[OriginalName("RogueResGainRoleNoBuffPool")]
		RogueResGainRoleNoBuffPool,
		// Token: 0x0400B0F5 RID: 45301
		[OriginalName("RogueResGainRoleNoMaxlv")]
		RogueResGainRoleNoMaxlv,
		// Token: 0x0400B0F6 RID: 45302
		[OriginalName("RogueResGainRoleRollEffectNoValid")]
		RogueResGainRoleRollEffectNoValid,
		// Token: 0x0400B0F7 RID: 45303
		[OriginalName("RogueResGainRoleRollRetNoMatch")]
		RogueResGainRoleRollRetNoMatch,
		// Token: 0x0400B0F8 RID: 45304
		[OriginalName("RogueResGainRoleShopNoConf")]
		RogueResGainRoleShopNoConf,
		// Token: 0x0400B0F9 RID: 45305
		[OriginalName("RogueResGainRoleRollEmpty")]
		RogueResGainRoleRollEmpty,
		// Token: 0x0400B0FA RID: 45306
		[OriginalName("RogueResGainRoleBondNoValid")]
		RogueResGainRoleBondNoValid,
		// Token: 0x0400B0FB RID: 45307
		[OriginalName("RogueResRoleBuffGuaranteeFail")]
		RogueResRoleBuffGuaranteeFail,
		// Token: 0x0400B0FC RID: 45308
		[OriginalName("RogueResRoleBuffNoMore")]
		RogueResRoleBuffNoMore,
		// Token: 0x0400B0FD RID: 45309
		[OriginalName("RogueResRoleBuffRandomFail")]
		RogueResRoleBuffRandomFail,
		// Token: 0x0400B0FE RID: 45310
		[OriginalName("RogueRoleShopRollFail")]
		RogueRoleShopRollFail,
		// Token: 0x0400B0FF RID: 45311
		[OriginalName("RogueResGridRangeTrigger")]
		RogueResGridRangeTrigger,
		// Token: 0x0400B100 RID: 45312
		[OriginalName("RogueResCurGridTrigger")]
		RogueResCurGridTrigger,
		// Token: 0x0400B101 RID: 45313
		[OriginalName("RogueResEventTypeErr")]
		RogueResEventTypeErr,
		// Token: 0x0400B102 RID: 45314
		[OriginalName("RogueResEventOpNoData")]
		RogueResEventOpNoData,
		// Token: 0x0400B103 RID: 45315
		[OriginalName("RogueResGridNoConf")]
		RogueResGridNoConf,
		// Token: 0x0400B104 RID: 45316
		[OriginalName("RogueResEffectExceFail")]
		RogueResEffectExceFail,
		// Token: 0x0400B105 RID: 45317
		[OriginalName("RogueResNoInBattle")]
		RogueResNoInBattle,
		// Token: 0x0400B106 RID: 45318
		[OriginalName("RogueResStepCondLock")]
		RogueResStepCondLock,
		// Token: 0x0400B107 RID: 45319
		[OriginalName("RogueResGridEventOpNotFind")]
		RogueResGridEventOpNotFind,
		// Token: 0x0400B108 RID: 45320
		[OriginalName("RogueNoLastInstData")]
		RogueNoLastInstData,
		// Token: 0x0400B109 RID: 45321
		[OriginalName("RogueNoRollBuffBondLinkOp")]
		RogueNoRollBuffBondLinkOp,
		// Token: 0x0400B10A RID: 45322
		[OriginalName("RogueTokenCantRepeat")]
		RogueTokenCantRepeat,
		// Token: 0x0400B10B RID: 45323
		[OriginalName("RogueFailCountMax")]
		RogueFailCountMax,
		// Token: 0x0400B10C RID: 45324
		[OriginalName("RogueResRoleMaxLv")]
		RogueResRoleMaxLv,
		// Token: 0x0400B10D RID: 45325
		[OriginalName("RogueResPerInstNoPass")]
		RogueResPerInstNoPass,
		// Token: 0x0400B10E RID: 45326
		[OriginalName("RogueResCreateInstCacheErr")]
		RogueResCreateInstCacheErr,
		// Token: 0x0400B10F RID: 45327
		[OriginalName("LordGymRepeatChallenge")]
		LordGymRepeatChallenge,
		// Token: 0x0400B110 RID: 45328
		[OriginalName("NewbieCarnivalNoLicense")]
		NewbieCarnivalNoLicense,
		// Token: 0x0400B111 RID: 45329
		[OriginalName("NewbieCarnivalParamNoConf")]
		NewbieCarnivalParamNoConf,
		// Token: 0x0400B112 RID: 45330
		[OriginalName("NewbieCarnivalNoRoleId")]
		NewbieCarnivalNoRoleId,
		// Token: 0x0400B113 RID: 45331
		[OriginalName("NewbieCarnivalNoData")]
		NewbieCarnivalNoData,
		// Token: 0x0400B114 RID: 45332
		[OriginalName("NewbieCarnivalTaskNoConf")]
		NewbieCarnivalTaskNoConf,
		// Token: 0x0400B115 RID: 45333
		[OriginalName("NewbieCarnivalTaskTaken")]
		NewbieCarnivalTaskTaken,
		// Token: 0x0400B116 RID: 45334
		[OriginalName("NewbieCarnivalTaskRunning")]
		NewbieCarnivalTaskRunning,
		// Token: 0x0400B117 RID: 45335
		[OriginalName("ErrShopFixeNotExist")]
		ErrShopFixeNotExist,
		// Token: 0x0400B118 RID: 45336
		[OriginalName("ErrShopBankNoExist")]
		ErrShopBankNoExist,
		// Token: 0x0400B119 RID: 45337
		[OriginalName("ErrShopBankNoMatch")]
		ErrShopBankNoMatch,
		// Token: 0x0400B11A RID: 45338
		[OriginalName("ErrPayShopBuyCountOverFlow")]
		ErrPayShopBuyCountOverFlow,
		// Token: 0x0400B11B RID: 45339
		[OriginalName("ErrShopBuyCountOverFlow")]
		ErrShopBuyCountOverFlow,
		// Token: 0x0400B11C RID: 45340
		[OriginalName("EnergyOverFlow")]
		EnergyOverFlow,
		// Token: 0x0400B11D RID: 45341
		[OriginalName("EnergyNotEnough")]
		EnergyNotEnough,
		// Token: 0x0400B11E RID: 45342
		[OriginalName("StoreEnergyNotEnough")]
		StoreEnergyNotEnough,
		// Token: 0x0400B11F RID: 45343
		[OriginalName("ErrPayShopBuyLimitCondition")]
		ErrPayShopBuyLimitCondition,
		// Token: 0x0400B120 RID: 45344
		[OriginalName("ErrPayShopEchoItemOver2")]
		ErrPayShopEchoItemOver2,
		// Token: 0x0400B121 RID: 45345
		[OriginalName("ErrPayShopEchoItemOver3")]
		ErrPayShopEchoItemOver3,
		// Token: 0x0400B122 RID: 45346
		[OriginalName("ErrPayShopEchoItemOver4")]
		ErrPayShopEchoItemOver4,
		// Token: 0x0400B123 RID: 45347
		[OriginalName("CreateReceiptCoreParamError")]
		CreateReceiptCoreParamError,
		// Token: 0x0400B124 RID: 45348
		[OriginalName("ReceiptsDealCloseCoreParamError")]
		ReceiptsDealCloseCoreParamError,
		// Token: 0x0400B125 RID: 45349
		[OriginalName("ReceiptsRefundCloseCoreParamError")]
		ReceiptsRefundCloseCoreParamError,
		// Token: 0x0400B126 RID: 45350
		[OriginalName("CreateReceiptCoreException")]
		CreateReceiptCoreException,
		// Token: 0x0400B127 RID: 45351
		[OriginalName("ReceiptsDealCloseCoreException")]
		ReceiptsDealCloseCoreException,
		// Token: 0x0400B128 RID: 45352
		[OriginalName("ReceiptsRefundCloseCoreFail")]
		ReceiptsRefundCloseCoreFail,
		// Token: 0x0400B129 RID: 45353
		[OriginalName("ReceiptsRefundCloseCoreException")]
		ReceiptsRefundCloseCoreException,
		// Token: 0x0400B12A RID: 45354
		[OriginalName("ErrPayConfigClientCantBuy")]
		ErrPayConfigClientCantBuy,
		// Token: 0x0400B12B RID: 45355
		[OriginalName("RecyclePersonalGiftNoData")]
		RecyclePersonalGiftNoData,
		// Token: 0x0400B12C RID: 45356
		[OriginalName("ErrPersonalGiftBuyLimit")]
		ErrPersonalGiftBuyLimit,
		// Token: 0x0400B12D RID: 45357
		[OriginalName("CreateReceiptNoConf")]
		CreateReceiptNoConf,
		// Token: 0x0400B12E RID: 45358
		[OriginalName("CreateReceiptFail")]
		CreateReceiptFail,
		// Token: 0x0400B12F RID: 45359
		[OriginalName("ReceiptDealCloseNoData")]
		ReceiptDealCloseNoData,
		// Token: 0x0400B130 RID: 45360
		[OriginalName("ReceiptDealClosePlayerIdUnMatch")]
		ReceiptDealClosePlayerIdUnMatch,
		// Token: 0x0400B131 RID: 45361
		[OriginalName("ReceiptCannotDealClose")]
		ReceiptCannotDealClose,
		// Token: 0x0400B132 RID: 45362
		[OriginalName("ReceiptDealCloseFail")]
		ReceiptDealCloseFail,
		// Token: 0x0400B133 RID: 45363
		[OriginalName("ReceiptRefundCloseNoData")]
		ReceiptRefundCloseNoData,
		// Token: 0x0400B134 RID: 45364
		[OriginalName("ReceiptRefundClosePlayerIdUnMatch")]
		ReceiptRefundClosePlayerIdUnMatch,
		// Token: 0x0400B135 RID: 45365
		[OriginalName("ReceiptCannotRefundClose")]
		ReceiptCannotRefundClose,
		// Token: 0x0400B136 RID: 45366
		[OriginalName("ReceiptRefundCloseFail")]
		ReceiptRefundCloseFail,
		// Token: 0x0400B137 RID: 45367
		[OriginalName("ReceiptRefundNoData")]
		ReceiptRefundNoData,
		// Token: 0x0400B138 RID: 45368
		[OriginalName("CreateReceiptParamError")]
		CreateReceiptParamError,
		// Token: 0x0400B139 RID: 45369
		[OriginalName("CreateReceiptException")]
		CreateReceiptException,
		// Token: 0x0400B13A RID: 45370
		[OriginalName("ReceiptsDealCloseParamError")]
		ReceiptsDealCloseParamError,
		// Token: 0x0400B13B RID: 45371
		[OriginalName("ReceiptsDealCloseException")]
		ReceiptsDealCloseException,
		// Token: 0x0400B13C RID: 45372
		[OriginalName("ReceiptRefundCloseParamError")]
		ReceiptRefundCloseParamError,
		// Token: 0x0400B13D RID: 45373
		[OriginalName("ReceiptRefundCloseException")]
		ReceiptRefundCloseException,
		// Token: 0x0400B13E RID: 45374
		[OriginalName("ReceiptRefundParamError")]
		ReceiptRefundParamError,
		// Token: 0x0400B13F RID: 45375
		[OriginalName("UpdateRogueWeeklyArtifactsFail")]
		UpdateRogueWeeklyArtifactsFail,
		// Token: 0x0400B140 RID: 45376
		[OriginalName("RogueWeeklyArtifactsEmpty")]
		RogueWeeklyArtifactsEmpty,
		// Token: 0x0400B141 RID: 45377
		[OriginalName("RogueWeeklyArtifactsIndexErr")]
		RogueWeeklyArtifactsIndexErr,
		// Token: 0x0400B142 RID: 45378
		[OriginalName("RogueResSkipBattleLvNoEnough")]
		RogueResSkipBattleLvNoEnough,
		// Token: 0x0400B143 RID: 45379
		[OriginalName("RogueResCanNotSkipBattle")]
		RogueResCanNotSkipBattle,
		// Token: 0x0400B144 RID: 45380
		[OriginalName("RogueResRandomGridNoConf")]
		RogueResRandomGridNoConf,
		// Token: 0x0400B145 RID: 45381
		[OriginalName("StrangerHostCount")]
		StrangerHostCount,
		// Token: 0x0400B146 RID: 45382
		[OriginalName("SurvivorsNotInitOp")]
		SurvivorsNotInitOp,
		// Token: 0x0400B147 RID: 45383
		[OriginalName("SurvivorsNotSelectOp")]
		SurvivorsNotSelectOp,
		// Token: 0x0400B148 RID: 45384
		[OriginalName("SurvivorsNoRoleAndWeapon")]
		SurvivorsNoRoleAndWeapon,
		// Token: 0x0400B149 RID: 45385
		[OriginalName("SurvivorsRandomEmpty")]
		SurvivorsRandomEmpty,
		// Token: 0x0400B14A RID: 45386
		[OriginalName("SurvivorsOptionEmpty")]
		SurvivorsOptionEmpty,
		// Token: 0x0400B14B RID: 45387
		[OriginalName("SurvivorsSelectEmpty")]
		SurvivorsSelectEmpty,
		// Token: 0x0400B14C RID: 45388
		[OriginalName("SurvivorsRandomGuaranteedEmpty")]
		SurvivorsRandomGuaranteedEmpty,
		// Token: 0x0400B14D RID: 45389
		[OriginalName("SurvivorsLevelNoConf")]
		SurvivorsLevelNoConf,
		// Token: 0x0400B14E RID: 45390
		[OriginalName("SurvivorsWeaponPoolEmpty")]
		SurvivorsWeaponPoolEmpty,
		// Token: 0x0400B14F RID: 45391
		[OriginalName("SurvivorsWeaponEmpty")]
		SurvivorsWeaponEmpty,
		// Token: 0x0400B150 RID: 45392
		[OriginalName("SurvivorsGoldNoEnough")]
		SurvivorsGoldNoEnough,
		// Token: 0x0400B151 RID: 45393
		[OriginalName("SurvivorsWeaponMax")]
		SurvivorsWeaponMax,
		// Token: 0x0400B152 RID: 45394
		[OriginalName("SurvivorsNoSupportGiveUp")]
		SurvivorsNoSupportGiveUp,
		// Token: 0x0400B153 RID: 45395
		[OriginalName("SurvivorsNoRestSelectCount")]
		SurvivorsNoRestSelectCount,
		// Token: 0x0400B154 RID: 45396
		[OriginalName("SurvivorsNoSupportMultiSelect")]
		SurvivorsNoSupportMultiSelect,
		// Token: 0x0400B155 RID: 45397
		[OriginalName("SurvivorsRepeatSelect")]
		SurvivorsRepeatSelect,
		// Token: 0x0400B156 RID: 45398
		[OriginalName("SurvivorsComponentNoFind")]
		SurvivorsComponentNoFind,
		// Token: 0x0400B157 RID: 45399
		[OriginalName("SurvivorsOpNotFind")]
		SurvivorsOpNotFind,
		// Token: 0x0400B158 RID: 45400
		[OriginalName("SurvivorsSelectErr")]
		SurvivorsSelectErr,
		// Token: 0x0400B159 RID: 45401
		[OriginalName("SurvivorsNoVar")]
		SurvivorsNoVar,
		// Token: 0x0400B15A RID: 45402
		[OriginalName("SurvivorsInstIdErr")]
		SurvivorsInstIdErr,
		// Token: 0x0400B15B RID: 45403
		[OriginalName("SurvivorsInstLock")]
		SurvivorsInstLock,
		// Token: 0x0400B15C RID: 45404
		[OriginalName("SurvivorsInstNotTime")]
		SurvivorsInstNotTime,
		// Token: 0x0400B15D RID: 45405
		[OriginalName("SurvivorsInstNoEndlessMode")]
		SurvivorsInstNoEndlessMode,
		// Token: 0x0400B15E RID: 45406
		[OriginalName("SurvivorsNeedContinue")]
		SurvivorsNeedContinue,
		// Token: 0x0400B15F RID: 45407
		[OriginalName("SurvivorsLevelCantUseRole")]
		SurvivorsLevelCantUseRole,
		// Token: 0x0400B160 RID: 45408
		[OriginalName("SurvivorsLevelCantUseWeapon")]
		SurvivorsLevelCantUseWeapon,
		// Token: 0x0400B161 RID: 45409
		[OriginalName("SurvivorsRoleNoMatch")]
		SurvivorsRoleNoMatch,
		// Token: 0x0400B162 RID: 45410
		[OriginalName("SurvivorsStepErr1")]
		SurvivorsStepErr1,
		// Token: 0x0400B163 RID: 45411
		[OriginalName("SurvivorsStepErr2")]
		SurvivorsStepErr2,
		// Token: 0x0400B164 RID: 45412
		[OriginalName("SurvivorsStepErr3")]
		SurvivorsStepErr3,
		// Token: 0x0400B165 RID: 45413
		[OriginalName("SurvivorsCantBuy")]
		SurvivorsCantBuy,
		// Token: 0x0400B166 RID: 45414
		[OriginalName("SurvivorsRoleLvNoConf")]
		SurvivorsRoleLvNoConf,
		// Token: 0x0400B167 RID: 45415
		[OriginalName("SurvivorsWeaponLvNoConf")]
		SurvivorsWeaponLvNoConf,
		// Token: 0x0400B168 RID: 45416
		[OriginalName("SurvivorsRoleNoFind")]
		SurvivorsRoleNoFind,
		// Token: 0x0400B169 RID: 45417
		[OriginalName("SurvivorsWaponNoFind")]
		SurvivorsWaponNoFind,
		// Token: 0x0400B16A RID: 45418
		[OriginalName("SurvivorsItemNoFind")]
		SurvivorsItemNoFind,
		// Token: 0x0400B16B RID: 45419
		[OriginalName("SurvivorsRoleLvMax")]
		SurvivorsRoleLvMax,
		// Token: 0x0400B16C RID: 45420
		[OriginalName("SurvivorsWeaponLvMax")]
		SurvivorsWeaponLvMax,
		// Token: 0x0400B16D RID: 45421
		[OriginalName("SurvivorsRefreshOpFail")]
		SurvivorsRefreshOpFail,
		// Token: 0x0400B16E RID: 45422
		[OriginalName("SurvivorsWeightEmpty")]
		SurvivorsWeightEmpty,
		// Token: 0x0400B16F RID: 45423
		[OriginalName("SurvivorsActivityNoData")]
		SurvivorsActivityNoData,
		// Token: 0x0400B170 RID: 45424
		[OriginalName("SurvivorsRefreshCostFail")]
		SurvivorsRefreshCostFail,
		// Token: 0x0400B171 RID: 45425
		[OriginalName("SurvivorsNoLastInstData")]
		SurvivorsNoLastInstData,
		// Token: 0x0400B172 RID: 45426
		[OriginalName("SurvivorsActivityNoConf")]
		SurvivorsActivityNoConf,
		// Token: 0x0400B173 RID: 45427
		[OriginalName("SurvivorsTalentNoConf")]
		SurvivorsTalentNoConf,
		// Token: 0x0400B174 RID: 45428
		[OriginalName("SurvivorsTaskCountMax")]
		SurvivorsTaskCountMax,
		// Token: 0x0400B175 RID: 45429
		[OriginalName("SurvivorsTaskNoConf")]
		SurvivorsTaskNoConf,
		// Token: 0x0400B176 RID: 45430
		[OriginalName("SurvivorsTaskCantReward")]
		SurvivorsTaskCantReward,
		// Token: 0x0400B177 RID: 45431
		[OriginalName("SurvivorsTaskRepeat")]
		SurvivorsTaskRepeat,
		// Token: 0x0400B178 RID: 45432
		[OriginalName("SurvivorsTaskEmpty")]
		SurvivorsTaskEmpty,
		// Token: 0x0400B179 RID: 45433
		[OriginalName("SurvivorsAllLock")]
		SurvivorsAllLock,
		// Token: 0x0400B17A RID: 45434
		[OriginalName("RogueResNoGlobalConf")]
		RogueResNoGlobalConf,
		// Token: 0x0400B17B RID: 45435
		[OriginalName("SurvivorsNeedPassNormalMode")]
		SurvivorsNeedPassNormalMode = 1100506,
		// Token: 0x0400B17C RID: 45436
		[OriginalName("SurvivorsOptionIsSelect")]
		SurvivorsOptionIsSelect,
		// Token: 0x0400B17D RID: 45437
		[OriginalName("SurvivorsTalentTreeConditionNotMet")]
		SurvivorsTalentTreeConditionNotMet,
		// Token: 0x0400B17E RID: 45438
		[OriginalName("SurvivorsTalentTreePerNodeLock")]
		SurvivorsTalentTreePerNodeLock,
		// Token: 0x0400B17F RID: 45439
		[OriginalName("SurvivorsTalentTreeNodeMaxLevel")]
		SurvivorsTalentTreeNodeMaxLevel,
		// Token: 0x0400B180 RID: 45440
		[OriginalName("SurvivorsTalentTreeConsumeNoEnough")]
		SurvivorsTalentTreeConsumeNoEnough,
		// Token: 0x0400B181 RID: 45441
		[OriginalName("ShortMessageNoConf")]
		ShortMessageNoConf,
		// Token: 0x0400B182 RID: 45442
		[OriginalName("ShortMessageOptionNoConf")]
		ShortMessageOptionNoConf,
		// Token: 0x0400B183 RID: 45443
		[OriginalName("ShortMessageNoData")]
		ShortMessageNoData,
		// Token: 0x0400B184 RID: 45444
		[OriginalName("ShortMessageNoData2")]
		ShortMessageNoData2,
		// Token: 0x0400B185 RID: 45445
		[OriginalName("ShortMessageIsRead")]
		ShortMessageIsRead,
		// Token: 0x0400B186 RID: 45446
		[OriginalName("ShortMessageNoMatch")]
		ShortMessageNoMatch,
		// Token: 0x0400B187 RID: 45447
		[OriginalName("ShortMessageNoReply")]
		ShortMessageNoReply,
		// Token: 0x0400B188 RID: 45448
		[OriginalName("ShortMessageIsReply")]
		ShortMessageIsReply,
		// Token: 0x0400B189 RID: 45449
		[OriginalName("ShortMessageNoReward")]
		ShortMessageNoReward,
		// Token: 0x0400B18A RID: 45450
		[OriginalName("ShortMessageIsReward")]
		ShortMessageIsReward,
		// Token: 0x0400B18B RID: 45451
		[OriginalName("ShortMessageNoFinish")]
		ShortMessageNoFinish,
		// Token: 0x0400B18C RID: 45452
		[OriginalName("ErrorPhantomCollectMax")]
		ErrorPhantomCollectMax,
		// Token: 0x0400B18D RID: 45453
		[OriginalName("ErrorPhantomCollectRepeated")]
		ErrorPhantomCollectRepeated,
		// Token: 0x0400B18E RID: 45454
		[OriginalName("ErrorPhantomCollectLock")]
		ErrorPhantomCollectLock,
		// Token: 0x0400B18F RID: 45455
		[OriginalName("ErrorNoSceneComp")]
		ErrorNoSceneComp,
		// Token: 0x0400B190 RID: 45456
		[OriginalName("ErrorNewTowerIsInChallenge")]
		ErrorNewTowerIsInChallenge,
		// Token: 0x0400B191 RID: 45457
		[OriginalName("ErrorNewTowerIsNoChallenge")]
		ErrorNewTowerIsNoChallenge,
		// Token: 0x0400B192 RID: 45458
		[OriginalName("ErrorNewTowerLevelIdNotMatch")]
		ErrorNewTowerLevelIdNotMatch,
		// Token: 0x0400B193 RID: 45459
		[OriginalName("ErrorNewTowerLevelNoConf")]
		ErrorNewTowerLevelNoConf,
		// Token: 0x0400B194 RID: 45460
		[OriginalName("ErrorNewTowerCycleNoConf")]
		ErrorNewTowerCycleNoConf,
		// Token: 0x0400B195 RID: 45461
		[OriginalName("ErrorNewTowerLevelNoData")]
		ErrorNewTowerLevelNoData,
		// Token: 0x0400B196 RID: 45462
		[OriginalName("ErrorNewTowerNoTeamCache")]
		ErrorNewTowerNoTeamCache,
		// Token: 0x0400B197 RID: 45463
		[OriginalName("ErrorNewTowerNoIndexTeamCache")]
		ErrorNewTowerNoIndexTeamCache,
		// Token: 0x0400B198 RID: 45464
		[OriginalName("ErrorNewTowerScoreRewardMax")]
		ErrorNewTowerScoreRewardMax,
		// Token: 0x0400B199 RID: 45465
		[OriginalName("ErrorNewTowerScoreNoConf")]
		ErrorNewTowerScoreNoConf,
		// Token: 0x0400B19A RID: 45466
		[OriginalName("ErrorNewTowerScoreRepeat")]
		ErrorNewTowerScoreRepeat,
		// Token: 0x0400B19B RID: 45467
		[OriginalName("ErrorNewTowerScoreEmpty")]
		ErrorNewTowerScoreEmpty,
		// Token: 0x0400B19C RID: 45468
		[OriginalName("ErrorNewTowerCycleNoInTime")]
		ErrorNewTowerCycleNoInTime,
		// Token: 0x0400B19D RID: 45469
		[OriginalName("ErrorNewTowerCurCycleNoConf")]
		ErrorNewTowerCurCycleNoConf,
		// Token: 0x0400B19E RID: 45470
		[OriginalName("ErrorNewTowerCycleNoLevel")]
		ErrorNewTowerCycleNoLevel,
		// Token: 0x0400B19F RID: 45471
		[OriginalName("ErrorNewTowerTeamIndexErr")]
		ErrorNewTowerTeamIndexErr,
		// Token: 0x0400B1A0 RID: 45472
		[OriginalName("ErrorNewTowerTeamMax")]
		ErrorNewTowerTeamMax,
		// Token: 0x0400B1A1 RID: 45473
		[OriginalName("ErrorNewTowerBuffMax")]
		ErrorNewTowerBuffMax,
		// Token: 0x0400B1A2 RID: 45474
		[OriginalName("ErrorNewTowerBuffRepeat")]
		ErrorNewTowerBuffRepeat,
		// Token: 0x0400B1A3 RID: 45475
		[OriginalName("ErrorNewTowerRoleRepeat")]
		ErrorNewTowerRoleRepeat,
		// Token: 0x0400B1A4 RID: 45476
		[OriginalName("ErrorNewTowerRoleEmpty")]
		ErrorNewTowerRoleEmpty,
		// Token: 0x0400B1A5 RID: 45477
		[OriginalName("ErrorNewTowerRoleNoMatch")]
		ErrorNewTowerRoleNoMatch,
		// Token: 0x0400B1A6 RID: 45478
		[OriginalName("ErrorNewTowerRoleMax")]
		ErrorNewTowerRoleMax,
		// Token: 0x0400B1A7 RID: 45479
		[OriginalName("ErrorNewTowerBuffNoMatch")]
		ErrorNewTowerBuffNoMatch,
		// Token: 0x0400B1A8 RID: 45480
		[OriginalName("ErrorNewTowerRoleNoEnergy")]
		ErrorNewTowerRoleNoEnergy,
		// Token: 0x0400B1A9 RID: 45481
		[OriginalName("ErrorNewTowerWaveNoInfo")]
		ErrorNewTowerWaveNoInfo,
		// Token: 0x0400B1AA RID: 45482
		[OriginalName("ErrorNewTowerWaveFinish")]
		ErrorNewTowerWaveFinish,
		// Token: 0x0400B1AB RID: 45483
		[OriginalName("ErrorShortMessageNoOpen")]
		ErrorShortMessageNoOpen,
		// Token: 0x0400B1AC RID: 45484
		[OriginalName("ErrorShortMessageOptionMax")]
		ErrorShortMessageOptionMax,
		// Token: 0x0400B1AD RID: 45485
		[OriginalName("ErrorShortMessageBubbleNoData")]
		ErrorShortMessageBubbleNoData,
		// Token: 0x0400B1AE RID: 45486
		[OriginalName("ErrorShortMessageBubbleNoConf")]
		ErrorShortMessageBubbleNoConf,
		// Token: 0x0400B1AF RID: 45487
		[OriginalName("ErrorShortMessageChatBgNoData")]
		ErrorShortMessageChatBgNoData,
		// Token: 0x0400B1B0 RID: 45488
		[OriginalName("ErrorShortMessageChatBgNoConf")]
		ErrorShortMessageChatBgNoConf,
		// Token: 0x0400B1B1 RID: 45489
		[OriginalName("ErrorNewTowerInstStateErr")]
		ErrorNewTowerInstStateErr,
		// Token: 0x0400B1B2 RID: 45490
		[OriginalName("ErrorNewTowerRoleWeaponPhantom")]
		ErrorNewTowerRoleWeaponPhantom,
		// Token: 0x0400B1B3 RID: 45491
		[OriginalName("ErrorNewTowerNoTeamData")]
		ErrorNewTowerNoTeamData,
		// Token: 0x0400B1B4 RID: 45492
		[OriginalName("ErrorNewTowerNoCacheSet")]
		ErrorNewTowerNoCacheSet,
		// Token: 0x0400B1B5 RID: 45493
		[OriginalName("ErrorNewTowerRoleWeaponNoMatch")]
		ErrorNewTowerRoleWeaponNoMatch,
		// Token: 0x0400B1B6 RID: 45494
		[OriginalName("ErrorNewTowerRolePhantomNoMatch")]
		ErrorNewTowerRolePhantomNoMatch,
		// Token: 0x0400B1B7 RID: 45495
		[OriginalName("ShortMessageOptionNoConf2")]
		ShortMessageOptionNoConf2,
		// Token: 0x0400B1B8 RID: 45496
		[OriginalName("ShortMessageOptionNoConf3")]
		ShortMessageOptionNoConf3,
		// Token: 0x0400B1B9 RID: 45497
		[OriginalName("ErrorNewTowerEntityNoFind")]
		ErrorNewTowerEntityNoFind,
		// Token: 0x0400B1BA RID: 45498
		[OriginalName("ErrorNewTowerSeasonAwardNoConf")]
		ErrorNewTowerSeasonAwardNoConf,
		// Token: 0x0400B1BB RID: 45499
		[OriginalName("ErrorNewTowerSeasonNoConf")]
		ErrorNewTowerSeasonNoConf,
		// Token: 0x0400B1BC RID: 45500
		[OriginalName("ErrorNewTowerSeasonNotOpen")]
		ErrorNewTowerSeasonNotOpen,
		// Token: 0x0400B1BD RID: 45501
		[OriginalName("ErrorNewTowerSeasonAwardRepeat")]
		ErrorNewTowerSeasonAwardRepeat,
		// Token: 0x0400B1BE RID: 45502
		[OriginalName("ErrorNewTowerSeasonAwardEmpty")]
		ErrorNewTowerSeasonAwardEmpty,
		// Token: 0x0400B1BF RID: 45503
		[OriginalName("NewTowerNoLastCycleIdReview")]
		NewTowerNoLastCycleIdReview,
		// Token: 0x0400B1C0 RID: 45504
		[OriginalName("NewTowerNoActivityData")]
		NewTowerNoActivityData,
		// Token: 0x0400B1C1 RID: 45505
		[OriginalName("NewTowerNoHistoryData")]
		NewTowerNoHistoryData,
		// Token: 0x0400B1C2 RID: 45506
		[OriginalName("ErrorNewTowerSeasonAwardTimeout")]
		ErrorNewTowerSeasonAwardTimeout,
		// Token: 0x0400B1C3 RID: 45507
		[OriginalName("RogueInstConfNoFind")]
		RogueInstConfNoFind,
		// Token: 0x0400B1C4 RID: 45508
		[OriginalName("RoguePhantomLock")]
		RoguePhantomLock,
		// Token: 0x0400B1C5 RID: 45509
		[OriginalName("RogueRoleLock")]
		RogueRoleLock,
		// Token: 0x0400B1C6 RID: 45510
		[OriginalName("RogueHotEntryLock")]
		RogueHotEntryLock,
		// Token: 0x0400B1C7 RID: 45511
		[OriginalName("KurotatoNoActivityData")]
		KurotatoNoActivityData,
		// Token: 0x0400B1C8 RID: 45512
		[OriginalName("KurotatoNoActivityConf")]
		KurotatoNoActivityConf,
		// Token: 0x0400B1C9 RID: 45513
		[OriginalName("KurotatoTaskLenghMax")]
		KurotatoTaskLenghMax,
		// Token: 0x0400B1CA RID: 45514
		[OriginalName("KurotatoTaskNoConf")]
		KurotatoTaskNoConf,
		// Token: 0x0400B1CB RID: 45515
		[OriginalName("KurotatoTaskNoFinish")]
		KurotatoTaskNoFinish,
		// Token: 0x0400B1CC RID: 45516
		[OriginalName("KurotatoTaskIsAward")]
		KurotatoTaskIsAward,
		// Token: 0x0400B1CD RID: 45517
		[OriginalName("KurotatoTaskRepeat")]
		KurotatoTaskRepeat,
		// Token: 0x0400B1CE RID: 45518
		[OriginalName("KurotatoTaskZero")]
		KurotatoTaskZero,
		// Token: 0x0400B1CF RID: 45519
		[OriginalName("KurotatoCanNotSaveRole")]
		KurotatoCanNotSaveRole,
		// Token: 0x0400B1D0 RID: 45520
		[OriginalName("KurotatoIsSaveRole")]
		KurotatoIsSaveRole,
		// Token: 0x0400B1D1 RID: 45521
		[OriginalName("KurotatoIsInInst")]
		KurotatoIsInInst,
		// Token: 0x0400B1D2 RID: 45522
		[OriginalName("KurotatoNoLevelData")]
		KurotatoNoLevelData,
		// Token: 0x0400B1D3 RID: 45523
		[OriginalName("KurotatoNoRoleData")]
		KurotatoNoRoleData,
		// Token: 0x0400B1D4 RID: 45524
		[OriginalName("KurotatoNoRecord")]
		KurotatoNoRecord,
		// Token: 0x0400B1D5 RID: 45525
		[OriginalName("KurotatoHasRecord")]
		KurotatoHasRecord,
		// Token: 0x0400B1D6 RID: 45526
		[OriginalName("KurotatoRoleNoRecord")]
		KurotatoRoleNoRecord,
		// Token: 0x0400B1D7 RID: 45527
		[OriginalName("KurotatoRecordLevelNotMatch")]
		KurotatoRecordLevelNotMatch,
		// Token: 0x0400B1D8 RID: 45528
		[OriginalName("KurotatoRoleNotMatch")]
		KurotatoRoleNotMatch,
		// Token: 0x0400B1D9 RID: 45529
		[OriginalName("HasRoguelikeProgressCanNotChangeSex")]
		HasRoguelikeProgressCanNotChangeSex,
		// Token: 0x0400B1DA RID: 45530
		[OriginalName("WeeklyFrameNoData")]
		WeeklyFrameNoData,
		// Token: 0x0400B1DB RID: 45531
		[OriginalName("WeeklyFrameScoreAwardMax")]
		WeeklyFrameScoreAwardMax,
		// Token: 0x0400B1DC RID: 45532
		[OriginalName("WeeklyFrameNotInTime")]
		WeeklyFrameNotInTime,
		// Token: 0x0400B1DD RID: 45533
		[OriginalName("WeeklyFrameNoConf")]
		WeeklyFrameNoConf,
		// Token: 0x0400B1DE RID: 45534
		[OriginalName("WeeklyFrameScoreAwardNoConf")]
		WeeklyFrameScoreAwardNoConf,
		// Token: 0x0400B1DF RID: 45535
		[OriginalName("WeeklyFrameScoreAwardGroupNotMatch")]
		WeeklyFrameScoreAwardGroupNotMatch,
		// Token: 0x0400B1E0 RID: 45536
		[OriginalName("WeeklyFrameScoreAwardNotFinish")]
		WeeklyFrameScoreAwardNotFinish,
		// Token: 0x0400B1E1 RID: 45537
		[OriginalName("WeeklyFrameScoreAwardTaken")]
		WeeklyFrameScoreAwardTaken,
		// Token: 0x0400B1E2 RID: 45538
		[OriginalName("WeeklyFrameScoreAwardRepeat")]
		WeeklyFrameScoreAwardRepeat,
		// Token: 0x0400B1E3 RID: 45539
		[OriginalName("WeeklyFrameScoreAwardZero")]
		WeeklyFrameScoreAwardZero,
		// Token: 0x0400B1E4 RID: 45540
		[OriginalName("KurotatoItemLock")]
		KurotatoItemLock,
		// Token: 0x0400B1E5 RID: 45541
		[OriginalName("KurotatoWeaponLock")]
		KurotatoWeaponLock,
		// Token: 0x0400B1E6 RID: 45542
		[OriginalName("KurotatoLevelNotOpen")]
		KurotatoLevelNotOpen,
		// Token: 0x0400B1E7 RID: 45543
		[OriginalName("HasTempRogueArchive")]
		HasTempRogueArchive,
		// Token: 0x0400B1E8 RID: 45544
		[OriginalName("NoTempRogueArchive")]
		NoTempRogueArchive,
		// Token: 0x0400B1E9 RID: 45545
		[OriginalName("RogueArchiveSlotErr")]
		RogueArchiveSlotErr,
		// Token: 0x0400B1EA RID: 45546
		[OriginalName("NoRogueTowerTrial")]
		NoRogueTowerTrial,
		// Token: 0x0400B1EB RID: 45547
		[OriginalName("RogueTowerTrialInstNoConf")]
		RogueTowerTrialInstNoConf,
		// Token: 0x0400B1EC RID: 45548
		[OriginalName("RogueTowerTrialNoConf")]
		RogueTowerTrialNoConf,
		// Token: 0x0400B1ED RID: 45549
		[OriginalName("RogueTowerTrialInstNoData")]
		RogueTowerTrialInstNoData,
		// Token: 0x0400B1EE RID: 45550
		[OriginalName("RogueTowerTrialInstInChallenge")]
		RogueTowerTrialInstInChallenge,
		// Token: 0x0400B1EF RID: 45551
		[OriginalName("RogueTowerTrialInstBossErr")]
		RogueTowerTrialInstBossErr,
		// Token: 0x0400B1F0 RID: 45552
		[OriginalName("NoRogueArchive")]
		NoRogueArchive,
		// Token: 0x0400B1F1 RID: 45553
		[OriginalName("RogueArchiveInvalid")]
		RogueArchiveInvalid,
		// Token: 0x0400B1F2 RID: 45554
		[OriginalName("KurotatoStepErr1")]
		KurotatoStepErr1,
		// Token: 0x0400B1F3 RID: 45555
		[OriginalName("KurotatoStepErr2")]
		KurotatoStepErr2,
		// Token: 0x0400B1F4 RID: 45556
		[OriginalName("ErrorNewTowerAwardCantGet")]
		ErrorNewTowerAwardCantGet,
		// Token: 0x0400B1F5 RID: 45557
		[OriginalName("KurotatoShopProductIsBought")]
		KurotatoShopProductIsBought,
		// Token: 0x0400B1F6 RID: 45558
		[OriginalName("KurotatoShopProductAllLock")]
		KurotatoShopProductAllLock,
		// Token: 0x0400B1F7 RID: 45559
		[OriginalName("ErrorShortMessageChatThemeNoData")]
		ErrorShortMessageChatThemeNoData,
		// Token: 0x0400B1F8 RID: 45560
		[OriginalName("ErrorShortMessageChatThemeNoConf")]
		ErrorShortMessageChatThemeNoConf,
		// Token: 0x0400B1F9 RID: 45561
		[OriginalName("ErrorShortMessageChatCharmNoData")]
		ErrorShortMessageChatCharmNoData,
		// Token: 0x0400B1FA RID: 45562
		[OriginalName("ErrorShortMessageChatCharmNoConf")]
		ErrorShortMessageChatCharmNoConf,
		// Token: 0x0400B1FB RID: 45563
		[OriginalName("RogueResLimitedRoles")]
		RogueResLimitedRoles = 1100505,
		// Token: 0x0400B1FC RID: 45564
		[OriginalName("ErrChatNotFriendNorOnline")]
		ErrChatNotFriendNorOnline = 1200000,
		// Token: 0x0400B1FD RID: 45565
		[OriginalName("ErrChatContentFilterFailed")]
		ErrChatContentFilterFailed,
		// Token: 0x0400B1FE RID: 45566
		[OriginalName("ErrChatLockState")]
		ErrChatLockState,
		// Token: 0x0400B1FF RID: 45567
		[OriginalName("ErrChatEmojiNotValid")]
		ErrChatEmojiNotValid,
		// Token: 0x0400B200 RID: 45568
		[OriginalName("ErrChatSendTooFast")]
		ErrChatSendTooFast,
		// Token: 0x0400B201 RID: 45569
		[OriginalName("ErrChatMuteNotValidId")]
		ErrChatMuteNotValidId,
		// Token: 0x0400B202 RID: 45570
		[OriginalName("ErrBanChatDefault")]
		ErrBanChatDefault,
		// Token: 0x0400B203 RID: 45571
		[OriginalName("ErrRoleQuestFuncNotOpen")]
		ErrRoleQuestFuncNotOpen,
		// Token: 0x0400B204 RID: 45572
		[OriginalName("ErrRoleQuestMaxCount")]
		ErrRoleQuestMaxCount,
		// Token: 0x0400B205 RID: 45573
		[OriginalName("ErrRoleQuestUnlockPointNotEnough")]
		ErrRoleQuestUnlockPointNotEnough,
		// Token: 0x0400B206 RID: 45574
		[OriginalName("ErrDailyQuestNotFoundArea")]
		ErrDailyQuestNotFoundArea,
		// Token: 0x0400B207 RID: 45575
		[OriginalName("ErrDailyQuestNotFoundInfluence")]
		ErrDailyQuestNotFoundInfluence,
		// Token: 0x0400B208 RID: 45576
		[OriginalName("ErrDailyQuestRewardAlreadyGet")]
		ErrDailyQuestRewardAlreadyGet,
		// Token: 0x0400B209 RID: 45577
		[OriginalName("ErrDailyQuestDataError")]
		ErrDailyQuestDataError,
		// Token: 0x0400B20A RID: 45578
		[OriginalName("ErrDailyQuestCantGetReward")]
		ErrDailyQuestCantGetReward,
		// Token: 0x0400B20B RID: 45579
		[OriginalName("ErrEntityBuffProducerStateError")]
		ErrEntityBuffProducerStateError,
		// Token: 0x0400B20C RID: 45580
		[OriginalName("ErrEntityBuffProducerNotFound")]
		ErrEntityBuffProducerNotFound,
		// Token: 0x0400B20D RID: 45581
		[OriginalName("ErrVoiceRemainChangeRoleNotInFormation")]
		ErrVoiceRemainChangeRoleNotInFormation,
		// Token: 0x0400B20E RID: 45582
		[OriginalName("ErrVoiceRemainChangeRoleNotAlive")]
		ErrVoiceRemainChangeRoleNotAlive,
		// Token: 0x0400B20F RID: 45583
		[OriginalName("ErrApplyEffectFail")]
		ErrApplyEffectFail = 1300000,
		// Token: 0x0400B210 RID: 45584
		[OriginalName("ErrOutofBattleTargetNotMonster")]
		ErrOutofBattleTargetNotMonster,
		// Token: 0x0400B211 RID: 45585
		[OriginalName("ErrMonsterBoomEntityNotExists")]
		ErrMonsterBoomEntityNotExists,
		// Token: 0x0400B212 RID: 45586
		[OriginalName("ErrMonsterBoomNotMonster")]
		ErrMonsterBoomNotMonster,
		// Token: 0x0400B213 RID: 45587
		[OriginalName("ErrMonsterBoomIsDead")]
		ErrMonsterBoomIsDead,
		// Token: 0x0400B214 RID: 45588
		[OriginalName("ErrAnimationStateSpecialFuncException")]
		ErrAnimationStateSpecialFuncException,
		// Token: 0x0400B215 RID: 45589
		[OriginalName("ErrPayConfigNotFound")]
		ErrPayConfigNotFound = 1400000,
		// Token: 0x0400B216 RID: 45590
		[OriginalName("ErrPayCreateReceiptFail")]
		ErrPayCreateReceiptFail,
		// Token: 0x0400B217 RID: 45591
		[OriginalName("ErrPayReceiptNotFound")]
		ErrPayReceiptNotFound,
		// Token: 0x0400B218 RID: 45592
		[OriginalName("ErrPayReceiptPlayerIdUnMatch")]
		ErrPayReceiptPlayerIdUnMatch,
		// Token: 0x0400B219 RID: 45593
		[OriginalName("ErrPayReceiptCannotDealClose")]
		ErrPayReceiptCannotDealClose,
		// Token: 0x0400B21A RID: 45594
		[OriginalName("ErrPayReceiptDealCloseFail")]
		ErrPayReceiptDealCloseFail,
		// Token: 0x0400B21B RID: 45595
		[OriginalName("ErrPayNotEnable")]
		ErrPayNotEnable,
		// Token: 0x0400B21C RID: 45596
		[OriginalName("ErrPayDataChanged")]
		ErrPayDataChanged,
		// Token: 0x0400B21D RID: 45597
		[OriginalName("ErrPayUpdateReceiptFail")]
		ErrPayUpdateReceiptFail,
		// Token: 0x0400B21E RID: 45598
		[OriginalName("ErrGachaConfigNotFound")]
		ErrGachaConfigNotFound,
		// Token: 0x0400B21F RID: 45599
		[OriginalName("ErrGachaRuleGroupConfigNotFound")]
		ErrGachaRuleGroupConfigNotFound,
		// Token: 0x0400B220 RID: 45600
		[OriginalName("ErrGachaRulesNotFound")]
		ErrGachaRulesNotFound,
		// Token: 0x0400B221 RID: 45601
		[OriginalName("ErrGachaTypeKnowns")]
		ErrGachaTypeKnowns,
		// Token: 0x0400B222 RID: 45602
		[OriginalName("ErrGachaDailyTimesLimit")]
		ErrGachaDailyTimesLimit,
		// Token: 0x0400B223 RID: 45603
		[OriginalName("ErrGachaTotalTimesLimit")]
		ErrGachaTotalTimesLimit,
		// Token: 0x0400B224 RID: 45604
		[OriginalName("ErrGachaDailyTotalTimesLimit")]
		ErrGachaDailyTotalTimesLimit,
		// Token: 0x0400B225 RID: 45605
		[OriginalName("ErrGachaIsNotOpen")]
		ErrGachaIsNotOpen,
		// Token: 0x0400B226 RID: 45606
		[OriginalName("ErrGachaIsNotInOpenTime")]
		ErrGachaIsNotInOpenTime,
		// Token: 0x0400B227 RID: 45607
		[OriginalName("ErrGachaFuncIsNotOpen")]
		ErrGachaFuncIsNotOpen,
		// Token: 0x0400B228 RID: 45608
		[OriginalName("ErrItemExchageConfigNotFound")]
		ErrItemExchageConfigNotFound,
		// Token: 0x0400B229 RID: 45609
		[OriginalName("ErrItemExchageDailyTimesLimit")]
		ErrItemExchageDailyTimesLimit,
		// Token: 0x0400B22A RID: 45610
		[OriginalName("ErrItemExchangeTotalTimesLimit")]
		ErrItemExchangeTotalTimesLimit,
		// Token: 0x0400B22B RID: 45611
		[OriginalName("ErrGachaLimitNotFound")]
		ErrGachaLimitNotFound,
		// Token: 0x0400B22C RID: 45612
		[OriginalName("ErrGachaLimitsEmpty")]
		ErrGachaLimitsEmpty,
		// Token: 0x0400B22D RID: 45613
		[OriginalName("ErrTextServerTimeout")]
		ErrTextServerTimeout,
		// Token: 0x0400B22E RID: 45614
		[OriginalName("ErrTextServerResFail")]
		ErrTextServerResFail,
		// Token: 0x0400B22F RID: 45615
		[OriginalName("ErrTextServerResEmpty")]
		ErrTextServerResEmpty,
		// Token: 0x0400B230 RID: 45616
		[OriginalName("ErrTextServerResException")]
		ErrTextServerResException,
		// Token: 0x0400B231 RID: 45617
		[OriginalName("ErrItemExchageParamError")]
		ErrItemExchageParamError,
		// Token: 0x0400B232 RID: 45618
		[OriginalName("ErrBattlePassFuncIsNotOpen")]
		ErrBattlePassFuncIsNotOpen,
		// Token: 0x0400B233 RID: 45619
		[OriginalName("ErrPayShopFuncIsNotOpen")]
		ErrPayShopFuncIsNotOpen,
		// Token: 0x0400B234 RID: 45620
		[OriginalName("ErrGachaPoolConfigNotFound")]
		ErrGachaPoolConfigNotFound,
		// Token: 0x0400B235 RID: 45621
		[OriginalName("ErrGachaPoolIsNotOpen")]
		ErrGachaPoolIsNotOpen,
		// Token: 0x0400B236 RID: 45622
		[OriginalName("ErrGachaPoolIsNotInOpenTime")]
		ErrGachaPoolIsNotInOpenTime,
		// Token: 0x0400B237 RID: 45623
		[OriginalName("ErrGachaPoolLimitNotFound")]
		ErrGachaPoolLimitNotFound,
		// Token: 0x0400B238 RID: 45624
		[OriginalName("ErrGachaPoolNotBelongToGacha")]
		ErrGachaPoolNotBelongToGacha,
		// Token: 0x0400B239 RID: 45625
		[OriginalName("ErrGachaUsePoolIdNotSet")]
		ErrGachaUsePoolIdNotSet,
		// Token: 0x0400B23A RID: 45626
		[OriginalName("ErrGachaTimesNonsupport")]
		ErrGachaTimesNonsupport,
		// Token: 0x0400B23B RID: 45627
		[OriginalName("ErrGachaFrontRuleGroupNotFinish")]
		ErrGachaFrontRuleGroupNotFinish,
		// Token: 0x0400B23C RID: 45628
		[OriginalName("ErrGachaRuleGroupFinish")]
		ErrGachaRuleGroupFinish,
		// Token: 0x0400B23D RID: 45629
		[OriginalName("ErrPayGiftBuyLimit")]
		ErrPayGiftBuyLimit,
		// Token: 0x0400B23E RID: 45630
		[OriginalName("ErrPayGiftTypeUnknown")]
		ErrPayGiftTypeUnknown,
		// Token: 0x0400B23F RID: 45631
		[OriginalName("ErrPayGiftNotInSellTime")]
		ErrPayGiftNotInSellTime,
		// Token: 0x0400B240 RID: 45632
		[OriginalName("ErrBattlePassBuyLevelLimit")]
		ErrBattlePassBuyLevelLimit,
		// Token: 0x0400B241 RID: 45633
		[OriginalName("ErrBattlePassBuyLevelError")]
		ErrBattlePassBuyLevelError,
		// Token: 0x0400B242 RID: 45634
		[OriginalName("ErrJsFileNotFound")]
		ErrJsFileNotFound,
		// Token: 0x0400B243 RID: 45635
		[OriginalName("ErrPayReceiptIsRefunded")]
		ErrPayReceiptIsRefunded,
		// Token: 0x0400B244 RID: 45636
		[OriginalName("ErrPayReceiptIsNotPay")]
		ErrPayReceiptIsNotPay,
		// Token: 0x0400B245 RID: 45637
		[OriginalName("ErrPayReceiptRefundFail")]
		ErrPayReceiptRefundFail,
		// Token: 0x0400B246 RID: 45638
		[OriginalName("ErrPayGiftLocked")]
		ErrPayGiftLocked,
		// Token: 0x0400B247 RID: 45639
		[OriginalName("ErrPayGiftBuyConditionLimit")]
		ErrPayGiftBuyConditionLimit,
		// Token: 0x0400B248 RID: 45640
		[OriginalName("ErrMapMarkConfigIdNotExist")]
		ErrMapMarkConfigIdNotExist,
		// Token: 0x0400B249 RID: 45641
		[OriginalName("ErrTreasureSlotMarkNotExist")]
		ErrTreasureSlotMarkNotExist,
		// Token: 0x0400B24A RID: 45642
		[OriginalName("ErrTreasureBoxMarkNotExist")]
		ErrTreasureBoxMarkNotExist,
		// Token: 0x0400B24B RID: 45643
		[OriginalName("ErrTreasureSlotMarkExist")]
		ErrTreasureSlotMarkExist,
		// Token: 0x0400B24C RID: 45644
		[OriginalName("ErrMapMarkTypeNotCustom")]
		ErrMapMarkTypeNotCustom,
		// Token: 0x0400B24D RID: 45645
		[OriginalName("ErrPayShopIsNotOpen")]
		ErrPayShopIsNotOpen,
		// Token: 0x0400B24E RID: 45646
		[OriginalName("ErrConsumptiveActivityNotOpen")]
		ErrConsumptiveActivityNotOpen,
		// Token: 0x0400B24F RID: 45647
		[OriginalName("ErrConsumptiveTaskNotFound")]
		ErrConsumptiveTaskNotFound,
		// Token: 0x0400B250 RID: 45648
		[OriginalName("ErrConsumptiveTaskNotFinish")]
		ErrConsumptiveTaskNotFinish,
		// Token: 0x0400B251 RID: 45649
		[OriginalName("ErrConsumptiveTaskRewarded")]
		ErrConsumptiveTaskRewarded,
		// Token: 0x0400B252 RID: 45650
		[OriginalName("ErrConsumptiveActivityNotFound")]
		ErrConsumptiveActivityNotFound,
		// Token: 0x0400B253 RID: 45651
		[OriginalName("ErrPayGiftPersonalNoPermission")]
		ErrPayGiftPersonalNoPermission,
		// Token: 0x0400B254 RID: 45652
		[OriginalName("ErrPayGiftPersonalPermissionExpired")]
		ErrPayGiftPersonalPermissionExpired,
		// Token: 0x0400B255 RID: 45653
		[OriginalName("ErrPayGiftNotPersonal")]
		ErrPayGiftNotPersonal,
		// Token: 0x0400B256 RID: 45654
		[OriginalName("ErrPayGiftPersonalPermissionExist")]
		ErrPayGiftPersonalPermissionExist,
		// Token: 0x0400B257 RID: 45655
		[OriginalName("ErrCouponId")]
		ErrCouponId,
		// Token: 0x0400B258 RID: 45656
		[OriginalName("ErrCouponConfigNotFound")]
		ErrCouponConfigNotFound,
		// Token: 0x0400B259 RID: 45657
		[OriginalName("ErrCouponNotEnough")]
		ErrCouponNotEnough,
		// Token: 0x0400B25A RID: 45658
		[OriginalName("ErrCouponTargetItemNotFound")]
		ErrCouponTargetItemNotFound,
		// Token: 0x0400B25B RID: 45659
		[OriginalName("ErrCouponTargetItemCount")]
		ErrCouponTargetItemCount,
		// Token: 0x0400B25C RID: 45660
		[OriginalName("ErrGachaTypeNotPersonal")]
		ErrGachaTypeNotPersonal,
		// Token: 0x0400B25D RID: 45661
		[OriginalName("ErrGachaPersonalPermissionExist")]
		ErrGachaPersonalPermissionExist,
		// Token: 0x0400B25E RID: 45662
		[OriginalName("ErrGachaPersonalNoPermission")]
		ErrGachaPersonalNoPermission,
		// Token: 0x0400B25F RID: 45663
		[OriginalName("ErrGachaPersonalPermissionExpired")]
		ErrGachaPersonalPermissionExpired,
		// Token: 0x0400B260 RID: 45664
		[OriginalName("ErrPayGiftVersionConfigNotFound")]
		ErrPayGiftVersionConfigNotFound,
		// Token: 0x0400B261 RID: 45665
		[OriginalName("ErrPayGiftSelfDefineVersionError")]
		ErrPayGiftSelfDefineVersionError,
		// Token: 0x0400B262 RID: 45666
		[OriginalName("ErrInfoDisplayId")]
		ErrInfoDisplayId = 1500000,
		// Token: 0x0400B263 RID: 45667
		[OriginalName("ErrItemAlreadyInCd")]
		ErrItemAlreadyInCd,
		// Token: 0x0400B264 RID: 45668
		[OriginalName("ErrCantFinAdventureConfig")]
		ErrCantFinAdventureConfig,
		// Token: 0x0400B265 RID: 45669
		[OriginalName("ErrAdventureRewardReceived")]
		ErrAdventureRewardReceived,
		// Token: 0x0400B266 RID: 45670
		[OriginalName("ErrAdventureTaskCache")]
		ErrAdventureTaskCache,
		// Token: 0x0400B267 RID: 45671
		[OriginalName("ErrAdventureState")]
		ErrAdventureState,
		// Token: 0x0400B268 RID: 45672
		[OriginalName("ErrAdventureRewardOrder")]
		ErrAdventureRewardOrder,
		// Token: 0x0400B269 RID: 45673
		[OriginalName("ErrAdventureChapterState")]
		ErrAdventureChapterState,
		// Token: 0x0400B26A RID: 45674
		[OriginalName("ErrCantDetectRepeat")]
		ErrCantDetectRepeat,
		// Token: 0x0400B26B RID: 45675
		[OriginalName("ErrNotInCurrentFollowList")]
		ErrNotInCurrentFollowList,
		// Token: 0x0400B26C RID: 45676
		[OriginalName("ErrCantDetectOtherDetectionType")]
		ErrCantDetectOtherDetectionType,
		// Token: 0x0400B26D RID: 45677
		[OriginalName("ErrNotSelectCurrentDetectionId")]
		ErrNotSelectCurrentDetectionId,
		// Token: 0x0400B26E RID: 45678
		[OriginalName("ErrDetectionConfigNotFound")]
		ErrDetectionConfigNotFound,
		// Token: 0x0400B26F RID: 45679
		[OriginalName("ErrDetectionListCantBeEmpty")]
		ErrDetectionListCantBeEmpty,
		// Token: 0x0400B270 RID: 45680
		[OriginalName("ErrCantFindAnyDetectionTarget")]
		ErrCantFindAnyDetectionTarget,
		// Token: 0x0400B271 RID: 45681
		[OriginalName("ErrCantFindTurntableComponentEntity")]
		ErrCantFindTurntableComponentEntity,
		// Token: 0x0400B272 RID: 45682
		[OriginalName("ErrHaveNoTurntableControlComponent")]
		ErrHaveNoTurntableControlComponent,
		// Token: 0x0400B273 RID: 45683
		[OriginalName("ErrCantFindLevitationMagnetComponentEntity")]
		ErrCantFindLevitationMagnetComponentEntity,
		// Token: 0x0400B274 RID: 45684
		[OriginalName("ErrHaveNoLevitaionMagnetComponent")]
		ErrHaveNoLevitaionMagnetComponent,
		// Token: 0x0400B275 RID: 45685
		[OriginalName("ErrCantFindBoardEntity")]
		ErrCantFindBoardEntity,
		// Token: 0x0400B276 RID: 45686
		[OriginalName("ErrCantFindPlacementEntity")]
		ErrCantFindPlacementEntity,
		// Token: 0x0400B277 RID: 45687
		[OriginalName("ErrHaveNoPlacementComponent")]
		ErrHaveNoPlacementComponent,
		// Token: 0x0400B278 RID: 45688
		[OriginalName("ErrCantFindBoardEntityComponent")]
		ErrCantFindBoardEntityComponent,
		// Token: 0x0400B279 RID: 45689
		[OriginalName("ErrBoardHaveNoAnyPlacement")]
		ErrBoardHaveNoAnyPlacement,
		// Token: 0x0400B27A RID: 45690
		[OriginalName("ErrBoardNotActiveAllGrid")]
		ErrBoardNotActiveAllGrid,
		// Token: 0x0400B27B RID: 45691
		[OriginalName("ErrNeedBeControlledBefore")]
		ErrNeedBeControlledBefore,
		// Token: 0x0400B27C RID: 45692
		[OriginalName("ErrPlaceFailOfAlreadyOnBoard")]
		ErrPlaceFailOfAlreadyOnBoard,
		// Token: 0x0400B27D RID: 45693
		[OriginalName("ErrInvalidBoardPosition")]
		ErrInvalidBoardPosition,
		// Token: 0x0400B27E RID: 45694
		[OriginalName("ErrNeedRemoveControlRelation")]
		ErrNeedRemoveControlRelation,
		// Token: 0x0400B27F RID: 45695
		[OriginalName("ErrNotOccupyOnBoard")]
		ErrNotOccupyOnBoard,
		// Token: 0x0400B280 RID: 45696
		[OriginalName("ErrHaveNoFillRule")]
		ErrHaveNoFillRule,
		// Token: 0x0400B281 RID: 45697
		[OriginalName("ErrGridPosAlreadyOccupied")]
		ErrGridPosAlreadyOccupied,
		// Token: 0x0400B282 RID: 45698
		[OriginalName("ErrHaveNoJigsawFoundationConfig")]
		ErrHaveNoJigsawFoundationConfig,
		// Token: 0x0400B283 RID: 45699
		[OriginalName("ErrInvalidGridPos")]
		ErrInvalidGridPos,
		// Token: 0x0400B284 RID: 45700
		[OriginalName("ErrGridPosAlreadyActive")]
		ErrGridPosAlreadyActive,
		// Token: 0x0400B285 RID: 45701
		[OriginalName("ErrCantPlaceItemOnBoard")]
		ErrCantPlaceItemOnBoard,
		// Token: 0x0400B286 RID: 45702
		[OriginalName("ErrNeedJigsawFoundationComponentWhenBeControlled")]
		ErrNeedJigsawFoundationComponentWhenBeControlled,
		// Token: 0x0400B287 RID: 45703
		[OriginalName("ErrHaveNoBoardComponentConfig")]
		ErrHaveNoBoardComponentConfig,
		// Token: 0x0400B288 RID: 45704
		[OriginalName("ErrNeedJigsawItemComponentWhenBeControlled")]
		ErrNeedJigsawItemComponentWhenBeControlled,
		// Token: 0x0400B289 RID: 45705
		[OriginalName("ErrCantFindOriginBoardEntity")]
		ErrCantFindOriginBoardEntity,
		// Token: 0x0400B28A RID: 45706
		[OriginalName("ErrDistanceNotInRangeBetweenEntity")]
		ErrDistanceNotInRangeBetweenEntity,
		// Token: 0x0400B28B RID: 45707
		[OriginalName("ErrJigsawFoundationIsAlreadySilent")]
		ErrJigsawFoundationIsAlreadySilent,
		// Token: 0x0400B28C RID: 45708
		[OriginalName("ErrCrystalEntityNotFound")]
		ErrCrystalEntityNotFound,
		// Token: 0x0400B28D RID: 45709
		[OriginalName("ErrGachaBoardEntityNotFound")]
		ErrGachaBoardEntityNotFound,
		// Token: 0x0400B28E RID: 45710
		[OriginalName("ErrNotCrystalEntity")]
		ErrNotCrystalEntity,
		// Token: 0x0400B28F RID: 45711
		[OriginalName("ErrNotGachaFoundationEntity")]
		ErrNotGachaFoundationEntity,
		// Token: 0x0400B290 RID: 45712
		[OriginalName("ErrGachaHoleIsFull")]
		ErrGachaHoleIsFull,
		// Token: 0x0400B291 RID: 45713
		[OriginalName("ErrJigsawItemSilent")]
		ErrJigsawItemSilent,
		// Token: 0x0400B292 RID: 45714
		[OriginalName("ErrThrowDamageConfigNotExists")]
		ErrThrowDamageConfigNotExists,
		// Token: 0x0400B293 RID: 45715
		[OriginalName("ErrThrowDamageComponetNotExists")]
		ErrThrowDamageComponetNotExists,
		// Token: 0x0400B294 RID: 45716
		[OriginalName("ErrEggNotMatchEggFoundation")]
		ErrEggNotMatchEggFoundation,
		// Token: 0x0400B295 RID: 45717
		[OriginalName("ProgressBarEntityNotFound")]
		ProgressBarEntityNotFound,
		// Token: 0x0400B296 RID: 45718
		[OriginalName("NotProgressBarEntity")]
		NotProgressBarEntity,
		// Token: 0x0400B297 RID: 45719
		[OriginalName("ProgressBarIsSilent")]
		ProgressBarIsSilent,
		// Token: 0x0400B298 RID: 45720
		[OriginalName("ScenePlayerInfoNotFound")]
		ScenePlayerInfoNotFound,
		// Token: 0x0400B299 RID: 45721
		[OriginalName("PlayerNotInAnyScene")]
		PlayerNotInAnyScene,
		// Token: 0x0400B29A RID: 45722
		[OriginalName("TeleportNotInValidDistance")]
		TeleportNotInValidDistance,
		// Token: 0x0400B29B RID: 45723
		[OriginalName("AddMapMarkInfoLackOfTeleportParam")]
		AddMapMarkInfoLackOfTeleportParam,
		// Token: 0x0400B29C RID: 45724
		[OriginalName("TemporaryTeleportNotExists")]
		TemporaryTeleportNotExists,
		// Token: 0x0400B29D RID: 45725
		[OriginalName("ErrNotHostPlayer")]
		ErrNotHostPlayer,
		// Token: 0x0400B29E RID: 45726
		[OriginalName("ErrMarkIdNotExists")]
		ErrMarkIdNotExists,
		// Token: 0x0400B29F RID: 45727
		[OriginalName("ErrCantUpdateTemporaryTeleportMarkInfo")]
		ErrCantUpdateTemporaryTeleportMarkInfo,
		// Token: 0x0400B2A0 RID: 45728
		[OriginalName("NotHostCantAddTemporaty")]
		NotHostCantAddTemporaty,
		// Token: 0x0400B2A1 RID: 45729
		[OriginalName("TemporaryTeleportPosIsNotWalkable")]
		TemporaryTeleportPosIsNotWalkable,
		// Token: 0x0400B2A2 RID: 45730
		[OriginalName("BadTemporaryTeleportConfig")]
		BadTemporaryTeleportConfig,
		// Token: 0x0400B2A3 RID: 45731
		[OriginalName("HaveNoTemporaryTeleportComponent")]
		HaveNoTemporaryTeleportComponent,
		// Token: 0x0400B2A4 RID: 45732
		[OriginalName("ErrCantDetectAtInvalidPoint")]
		ErrCantDetectAtInvalidPoint,
		// Token: 0x0400B2A5 RID: 45733
		[OriginalName("ErrNotDetectionTreasureBoxBefore")]
		ErrNotDetectionTreasureBoxBefore,
		// Token: 0x0400B2A6 RID: 45734
		[OriginalName("ErrJigsawFoundationIsCompleteCantModifyGridState")]
		ErrJigsawFoundationIsCompleteCantModifyGridState,
		// Token: 0x0400B2A7 RID: 45735
		[OriginalName("GridIsActiveCantSwitchState")]
		GridIsActiveCantSwitchState,
		// Token: 0x0400B2A8 RID: 45736
		[OriginalName("GridIsOccupiedCantSwitchState")]
		GridIsOccupiedCantSwitchState,
		// Token: 0x0400B2A9 RID: 45737
		[OriginalName("ErrHaveNoBaseInfoComponent")]
		ErrHaveNoBaseInfoComponent,
		// Token: 0x0400B2AA RID: 45738
		[OriginalName("ErrHaveNoParentEntity")]
		ErrHaveNoParentEntity,
		// Token: 0x0400B2AB RID: 45739
		[OriginalName("NotRelationEntity")]
		NotRelationEntity,
		// Token: 0x0400B2AC RID: 45740
		[OriginalName("ErrLevelPlayNotRunning")]
		ErrLevelPlayNotRunning,
		// Token: 0x0400B2AD RID: 45741
		[OriginalName("ErrStateCantChangeWhenLifeCycleDestroy")]
		ErrStateCantChangeWhenLifeCycleDestroy,
		// Token: 0x0400B2AE RID: 45742
		[OriginalName("ErrRangeEntityIdNotFoundWhenForbidTempTeleport")]
		ErrRangeEntityIdNotFoundWhenForbidTempTeleport,
		// Token: 0x0400B2AF RID: 45743
		[OriginalName("TemporaryTeleportIsForbidden")]
		TemporaryTeleportIsForbidden,
		// Token: 0x0400B2B0 RID: 45744
		[OriginalName("ErrGravityGearIsComplete")]
		ErrGravityGearIsComplete,
		// Token: 0x0400B2B1 RID: 45745
		[OriginalName("ErrInvalidRoleWhenUpdatePassiveSkill")]
		ErrInvalidRoleWhenUpdatePassiveSkill,
		// Token: 0x0400B2B2 RID: 45746
		[OriginalName("ErrInvalidRolePassiveSkillId")]
		ErrInvalidRolePassiveSkillId,
		// Token: 0x0400B2B3 RID: 45747
		[OriginalName("ErrPassiveSkillNotAddBuff")]
		ErrPassiveSkillNotAddBuff,
		// Token: 0x0400B2B4 RID: 45748
		[OriginalName("ErrPassiveSkillCantSpecifyBuff")]
		ErrPassiveSkillCantSpecifyBuff,
		// Token: 0x0400B2B5 RID: 45749
		[OriginalName("ErrPassiveSkillAddBuffFail")]
		ErrPassiveSkillAddBuffFail,
		// Token: 0x0400B2B6 RID: 45750
		[OriginalName("ErrPassiveSkillAddBulletFail")]
		ErrPassiveSkillAddBulletFail,
		// Token: 0x0400B2B7 RID: 45751
		[OriginalName("ErrBuffCreatePassiveSkillFail")]
		ErrBuffCreatePassiveSkillFail,
		// Token: 0x0400B2B8 RID: 45752
		[OriginalName("ErrInvalidPreContext")]
		ErrInvalidPreContext,
		// Token: 0x0400B2B9 RID: 45753
		[OriginalName("ErrBadPassiveSkillId")]
		ErrBadPassiveSkillId,
		// Token: 0x0400B2BA RID: 45754
		[OriginalName("ErrPassiveSkillComponentNotFound")]
		ErrPassiveSkillComponentNotFound,
		// Token: 0x0400B2BB RID: 45755
		[OriginalName("ErrRepeatePassiveSkill")]
		ErrRepeatePassiveSkill,
		// Token: 0x0400B2BC RID: 45756
		[OriginalName("ErrBadPassiveSkillTriggerType")]
		ErrBadPassiveSkillTriggerType,
		// Token: 0x0400B2BD RID: 45757
		[OriginalName("ErrAddPassiveSkillFailOfEntityNotFound")]
		ErrAddPassiveSkillFailOfEntityNotFound,
		// Token: 0x0400B2BE RID: 45758
		[OriginalName("ErrEntityNotClientControlWhenAddPassiveSkill")]
		ErrEntityNotClientControlWhenAddPassiveSkill,
		// Token: 0x0400B2BF RID: 45759
		[OriginalName("ErrEntityNotClientControlWhenRemovePassiveSkill")]
		ErrEntityNotClientControlWhenRemovePassiveSkill,
		// Token: 0x0400B2C0 RID: 45760
		[OriginalName("ErrPassiveSkillNotFoundWhenRemovePassiveSkill")]
		ErrPassiveSkillNotFoundWhenRemovePassiveSkill,
		// Token: 0x0400B2C1 RID: 45761
		[OriginalName("ErrRepeatedBattleContext")]
		ErrRepeatedBattleContext,
		// Token: 0x0400B2C2 RID: 45762
		[OriginalName("ErrPassiveSkillAddSkillFail")]
		ErrPassiveSkillAddSkillFail,
		// Token: 0x0400B2C3 RID: 45763
		[OriginalName("ErrCombatSendPackAbnormal")]
		ErrCombatSendPackAbnormal,
		// Token: 0x0400B2C4 RID: 45764
		[OriginalName("ErrContextCheckFail")]
		ErrContextCheckFail,
		// Token: 0x0400B2C5 RID: 45765
		[OriginalName("ErrFsmComponentNotFound")]
		ErrFsmComponentNotFound,
		// Token: 0x0400B2C6 RID: 45766
		[OriginalName("ErrFsmCreateContextFail")]
		ErrFsmCreateContextFail,
		// Token: 0x0400B2C7 RID: 45767
		[OriginalName("ErrFsmStateBehaviorPreMessageCantBeZero")]
		ErrFsmStateBehaviorPreMessageCantBeZero,
		// Token: 0x0400B2C8 RID: 45768
		[OriginalName("ErrFsmBehaviorCheckBattleContextFail")]
		ErrFsmBehaviorCheckBattleContextFail,
		// Token: 0x0400B2C9 RID: 45769
		[OriginalName("ErrFsmPlayMontageLackPreMessage")]
		ErrFsmPlayMontageLackPreMessage,
		// Token: 0x0400B2CA RID: 45770
		[OriginalName("ErrFsmPlayMontageCheckContextFail")]
		ErrFsmPlayMontageCheckContextFail,
		// Token: 0x0400B2CB RID: 45771
		[OriginalName("ErrFsmPlayMontageConfigCheckFail")]
		ErrFsmPlayMontageConfigCheckFail,
		// Token: 0x0400B2CC RID: 45772
		[OriginalName("ErrSkillFlowNotExist")]
		ErrSkillFlowNotExist,
		// Token: 0x0400B2CD RID: 45773
		[OriginalName("ErrGetReportDataOverLimit")]
		ErrGetReportDataOverLimit,
		// Token: 0x0400B2CE RID: 45774
		[OriginalName("ErrGetReportDataTooFast")]
		ErrGetReportDataTooFast,
		// Token: 0x0400B2CF RID: 45775
		[OriginalName("ErrNotInAnyScene")]
		ErrNotInAnyScene,
		// Token: 0x0400B2D0 RID: 45776
		[OriginalName("ErrAceLogDataNotFound")]
		ErrAceLogDataNotFound,
		// Token: 0x0400B2D1 RID: 45777
		[OriginalName("ErrAceLogDataRepeatReport")]
		ErrAceLogDataRepeatReport,
		// Token: 0x0400B2D2 RID: 45778
		[OriginalName("ErrAceInvalidLogId")]
		ErrAceInvalidLogId,
		// Token: 0x0400B2D3 RID: 45779
		[OriginalName("ErrAceSceneGlobalObjNotFound")]
		ErrAceSceneGlobalObjNotFound,
		// Token: 0x0400B2D4 RID: 45780
		[OriginalName("ErrAceBadParam")]
		ErrAceBadParam,
		// Token: 0x0400B2D5 RID: 45781
		[OriginalName("ErrS2CConfirmIdNotExists")]
		ErrS2CconfirmIdNotExists,
		// Token: 0x0400B2D6 RID: 45782
		[OriginalName("ErrPassiveSkillConfigNotFound")]
		ErrPassiveSkillConfigNotFound,
		// Token: 0x0400B2D7 RID: 45783
		[OriginalName("ErrNotBehaviorController")]
		ErrNotBehaviorController,
		// Token: 0x0400B2D8 RID: 45784
		[OriginalName("ErrPlayMontageFail")]
		ErrPlayMontageFail,
		// Token: 0x0400B2D9 RID: 45785
		[OriginalName("ErrFightDataInConsistent")]
		ErrFightDataInConsistent,
		// Token: 0x0400B2DA RID: 45786
		[OriginalName("ErrNotInAoiSight")]
		ErrNotInAoiSight,
		// Token: 0x0400B2DB RID: 45787
		[OriginalName("ErrPassiveSkillNotOwner")]
		ErrPassiveSkillNotOwner,
		// Token: 0x0400B2DC RID: 45788
		[OriginalName("ErrReportStartFirstly")]
		ErrReportStartFirstly,
		// Token: 0x0400B2DD RID: 45789
		[OriginalName("ErrBattleEntityNotFound")]
		ErrBattleEntityNotFound,
		// Token: 0x0400B2DE RID: 45790
		[OriginalName("ErrBattleCampNotDefined")]
		ErrBattleCampNotDefined,
		// Token: 0x0400B2DF RID: 45791
		[OriginalName("ErrOtherInternalError")]
		ErrOtherInternalError,
		// Token: 0x0400B2E0 RID: 45792
		[OriginalName("ErrHaventBattleComponent")]
		ErrHaventBattleComponent,
		// Token: 0x0400B2E1 RID: 45793
		[OriginalName("ErrLackCombinePartInfoParam")]
		ErrLackCombinePartInfoParam,
		// Token: 0x0400B2E2 RID: 45794
		[OriginalName("ErrCombinerEntityNotExists")]
		ErrCombinerEntityNotExists,
		// Token: 0x0400B2E3 RID: 45795
		[OriginalName("ErrTargetEntityNotExists")]
		ErrTargetEntityNotExists,
		// Token: 0x0400B2E4 RID: 45796
		[OriginalName("ErrTargetPartNotExists")]
		ErrTargetPartNotExists,
		// Token: 0x0400B2E5 RID: 45797
		[OriginalName("ErrCombineComponentNotExists")]
		ErrCombineComponentNotExists,
		// Token: 0x0400B2E6 RID: 45798
		[OriginalName("ErrAlreadyCombineToOtherEntity")]
		ErrAlreadyCombineToOtherEntity,
		// Token: 0x0400B2E7 RID: 45799
		[OriginalName("ErrLackCombinerOffsetPos")]
		ErrLackCombinerOffsetPos,
		// Token: 0x0400B2E8 RID: 45800
		[OriginalName("ErrLackCombinerOffsetRotate")]
		ErrLackCombinerOffsetRotate,
		// Token: 0x0400B2E9 RID: 45801
		[OriginalName("ErrCombineEntityNotFound")]
		ErrCombineEntityNotFound,
		// Token: 0x0400B2EA RID: 45802
		[OriginalName("ErrDissolveCheckBattleContextFail")]
		ErrDissolveCheckBattleContextFail,
		// Token: 0x0400B2EB RID: 45803
		[OriginalName("ErrRepeatedRole")]
		ErrRepeatedRole,
		// Token: 0x0400B2EC RID: 45804
		[OriginalName("ErrNotStateMachineBehavior")]
		ErrNotStateMachineBehavior,
		// Token: 0x0400B2ED RID: 45805
		[OriginalName("ErrDiscardMsgWhenChangeSceneMultiMode")]
		ErrDiscardMsgWhenChangeSceneMultiMode = 1500140,
		// Token: 0x0400B2EE RID: 45806
		[OriginalName("ErrMayOccurDbAbnormal")]
		ErrMayOccurDbAbnormal = 1500139,
		// Token: 0x0400B2EF RID: 45807
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfFsmGroupConfigNotExists")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfFsmGroupConfigNotExists = 1500141,
		// Token: 0x0400B2F0 RID: 45808
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfConfigNotExists")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageOfConfigNotExists,
		// Token: 0x0400B2F1 RID: 45809
		[OriginalName("ErrEntityLivingStatusNotifyCheckFsmPlayMontageFail")]
		ErrEntityLivingStatusNotifyCheckFsmPlayMontageFail,
		// Token: 0x0400B2F2 RID: 45810
		[OriginalName("ErrFsmActionCheckFsmPlayMontageFail")]
		ErrFsmActionCheckFsmPlayMontageFail,
		// Token: 0x0400B2F3 RID: 45811
		[OriginalName("ErrFsmActionCheckSkillFail")]
		ErrFsmActionCheckSkillFail,
		// Token: 0x0400B2F4 RID: 45812
		[OriginalName("ErrFsmActionCheckBufflFail")]
		ErrFsmActionCheckBufflFail,
		// Token: 0x0400B2F5 RID: 45813
		[OriginalName("ErrFsmPlayMontageCheckAnParamError")]
		ErrFsmPlayMontageCheckAnParamError,
		// Token: 0x0400B2F6 RID: 45814
		[OriginalName("ErrFsmPlayMontageCheckAnMontageConfigNotFound")]
		ErrFsmPlayMontageCheckAnMontageConfigNotFound,
		// Token: 0x0400B2F7 RID: 45815
		[OriginalName("ErrFsmPlayMontageCheckAnMontageFail")]
		ErrFsmPlayMontageCheckAnMontageFail,
		// Token: 0x0400B2F8 RID: 45816
		[OriginalName("ErrMontageConfigNotFound")]
		ErrMontageConfigNotFound,
		// Token: 0x0400B2F9 RID: 45817
		[OriginalName("ErrANConfigNotFound")]
		ErrAnconfigNotFound,
		// Token: 0x0400B2FA RID: 45818
		[OriginalName("ErrBulletConfigNotFound")]
		ErrBulletConfigNotFound,
		// Token: 0x0400B2FB RID: 45819
		[OriginalName("ErrFsmVersion")]
		ErrFsmVersion,
		// Token: 0x0400B2FC RID: 45820
		[OriginalName("ErrUpdateFightRoleRepeated")]
		ErrUpdateFightRoleRepeated,
		// Token: 0x0400B2FD RID: 45821
		[OriginalName("TrialRoleEntityOverLimit")]
		TrialRoleEntityOverLimit,
		// Token: 0x0400B2FE RID: 45822
		[OriginalName("ErrHaveNoRoleInfos")]
		ErrHaveNoRoleInfos,
		// Token: 0x0400B2FF RID: 45823
		[OriginalName("ErrTeamHaveNoAnyRoles")]
		ErrTeamHaveNoAnyRoles,
		// Token: 0x0400B300 RID: 45824
		[OriginalName("ErrSkillMontageNotNormalMontage")]
		ErrSkillMontageNotNormalMontage,
		// Token: 0x0400B301 RID: 45825
		[OriginalName("ErrMontageContextConfigNotFound")]
		ErrMontageContextConfigNotFound,
		// Token: 0x0400B302 RID: 45826
		[OriginalName("ErrMontageContextCheckAnFail")]
		ErrMontageContextCheckAnFail,
		// Token: 0x0400B303 RID: 45827
		[OriginalName("ErrLivingStatusContextCheckPlayMontageContextFail")]
		ErrLivingStatusContextCheckPlayMontageContextFail,
		// Token: 0x0400B304 RID: 45828
		[OriginalName("ErrContextHaveNoFsmGroupConfig")]
		ErrContextHaveNoFsmGroupConfig,
		// Token: 0x0400B305 RID: 45829
		[OriginalName("ErrLivingStatusContextFsmGroupConfigNotFound")]
		ErrLivingStatusContextFsmGroupConfigNotFound,
		// Token: 0x0400B306 RID: 45830
		[OriginalName("ErrFsmActionCheckPlayEntityMontageFail")]
		ErrFsmActionCheckPlayEntityMontageFail,
		// Token: 0x0400B307 RID: 45831
		[OriginalName("ErrMontageContext1CheckPlayEntityMontageFail")]
		ErrMontageContext1CheckPlayEntityMontageFail,
		// Token: 0x0400B308 RID: 45832
		[OriginalName("ErrSkillGAHaveNoModifyCommonEnemyPro")]
		ErrSkillGahaveNoModifyCommonEnemyPro,
		// Token: 0x0400B309 RID: 45833
		[OriginalName("ErrNotSummonEntity")]
		ErrNotSummonEntity,
		// Token: 0x0400B30A RID: 45834
		[OriginalName("ErrSkillGAHaveNoTagId")]
		ErrSkillGahaveNoTagId,
		// Token: 0x0400B30B RID: 45835
		[OriginalName("ErrCombatSkillGAHandleGetEntityFailed")]
		ErrCombatSkillGahandleGetEntityFailed = 1600000,
		// Token: 0x0400B30C RID: 45836
		[OriginalName("ErrCombatMaterialHandleGetEntityFailed")]
		ErrCombatMaterialHandleGetEntityFailed,
		// Token: 0x0400B30D RID: 45837
		[OriginalName("ErrCombatParticleHandleGetEntityFailed")]
		ErrCombatParticleHandleGetEntityFailed,
		// Token: 0x0400B30E RID: 45838
		[OriginalName("ErrCombatPartLifeChangeEntityNotExisted")]
		ErrCombatPartLifeChangeEntityNotExisted,
		// Token: 0x0400B30F RID: 45839
		[OriginalName("ErrCombatCreateBulletTargetNotExisted")]
		ErrCombatCreateBulletTargetNotExisted,
		// Token: 0x0400B310 RID: 45840
		[OriginalName("ErrCombatDeleteBulletTargetNotExisted")]
		ErrCombatDeleteBulletTargetNotExisted,
		// Token: 0x0400B311 RID: 45841
		[OriginalName("ErrCombatDeleteBulletGetEntityFailed")]
		ErrCombatDeleteBulletGetEntityFailed,
		// Token: 0x0400B312 RID: 45842
		[OriginalName("ErrCombatBulletTargetNoExist")]
		ErrCombatBulletTargetNoExist,
		// Token: 0x0400B313 RID: 45843
		[OriginalName("ErrPartEntityNotExisted")]
		ErrPartEntityNotExisted,
		// Token: 0x0400B314 RID: 45844
		[OriginalName("ErrNoAiControlRights")]
		ErrNoAiControlRights,
		// Token: 0x0400B315 RID: 45845
		[OriginalName("ErrAiHateComponent")]
		ErrAiHateComponent,
		// Token: 0x0400B316 RID: 45846
		[OriginalName("ErrSummonerPlayerControl")]
		ErrSummonerPlayerControl,
		// Token: 0x0400B317 RID: 45847
		[OriginalName("ErrConfDamageNotFound")]
		ErrConfDamageNotFound,
		// Token: 0x0400B318 RID: 45848
		[OriginalName("ErrProcessDamageFailed")]
		ErrProcessDamageFailed,
		// Token: 0x0400B319 RID: 45849
		[OriginalName("ErrInjuryFreeLandingTag")]
		ErrInjuryFreeLandingTag,
		// Token: 0x0400B31A RID: 45850
		[OriginalName("ErrNotFindActiveGameplayEffect")]
		ErrNotFindActiveGameplayEffect,
		// Token: 0x0400B31B RID: 45851
		[OriginalName("NotClientControlBuff")]
		NotClientControlBuff,
		// Token: 0x0400B31C RID: 45852
		[OriginalName("ErrBuffNoEffectConf")]
		ErrBuffNoEffectConf,
		// Token: 0x0400B31D RID: 45853
		[OriginalName("ErrBuffCannotCreateBullet")]
		ErrBuffCannotCreateBullet,
		// Token: 0x0400B31E RID: 45854
		[OriginalName("ErrBuffCannotCreateBuff")]
		ErrBuffCannotCreateBuff,
		// Token: 0x0400B31F RID: 45855
		[OriginalName("ErrNoBuffConf")]
		ErrNoBuffConf,
		// Token: 0x0400B320 RID: 45856
		[OriginalName("ErrStoppedAi")]
		ErrStoppedAi,
		// Token: 0x0400B321 RID: 45857
		[OriginalName("ErrEntityIsNotAlive")]
		ErrEntityIsNotAlive,
		// Token: 0x0400B322 RID: 45858
		[OriginalName("ErrSummonCannotSwitchAiControl")]
		ErrSummonCannotSwitchAiControl,
		// Token: 0x0400B323 RID: 45859
		[OriginalName("ErrAiControlNotChange")]
		ErrAiControlNotChange,
		// Token: 0x0400B324 RID: 45860
		[OriginalName("ErrPlayerCannotControlEntity")]
		ErrPlayerCannotControlEntity,
		// Token: 0x0400B325 RID: 45861
		[OriginalName("ErrNotFoundBuffEffect")]
		ErrNotFoundBuffEffect,
		// Token: 0x0400B326 RID: 45862
		[OriginalName("ErrBuffEffectAuthority")]
		ErrBuffEffectAuthority,
		// Token: 0x0400B327 RID: 45863
		[OriginalName("ErrConcomitantDestroy")]
		ErrConcomitantDestroy,
		// Token: 0x0400B328 RID: 45864
		[OriginalName("ErrPlayerFollowersComponent")]
		ErrPlayerFollowersComponent,
		// Token: 0x0400B329 RID: 45865
		[OriginalName("ErrBuffComponentNotExist")]
		ErrBuffComponentNotExist,
		// Token: 0x0400B32A RID: 45866
		[OriginalName("ErrOrderApplyBuffFailed")]
		ErrOrderApplyBuffFailed,
		// Token: 0x0400B32B RID: 45867
		[OriginalName("ErrPlayerBuff")]
		ErrPlayerBuff,
		// Token: 0x0400B32C RID: 45868
		[OriginalName("ErrFindPathNoEndPos")]
		ErrFindPathNoEndPos,
		// Token: 0x0400B32D RID: 45869
		[OriginalName("ErrNotGetCurRole")]
		ErrNotGetCurRole,
		// Token: 0x0400B32E RID: 45870
		[OriginalName("ErrFindPathFailed")]
		ErrFindPathFailed,
		// Token: 0x0400B32F RID: 45871
		[OriginalName("ErrEntityFsmMachineNotExist")]
		ErrEntityFsmMachineNotExist = 1700000,
		// Token: 0x0400B330 RID: 45872
		[OriginalName("ErrEntityFsmStateIncorrect")]
		ErrEntityFsmStateIncorrect,
		// Token: 0x0400B331 RID: 45873
		[OriginalName("ErrIsNotAiControler")]
		ErrIsNotAiControler,
		// Token: 0x0400B332 RID: 45874
		[OriginalName("ErrIEntityFsmCantTransit")]
		ErrIentityFsmCantTransit,
		// Token: 0x0400B333 RID: 45875
		[OriginalName("ErrIEntityFsmTransitCondition")]
		ErrIentityFsmTransitCondition,
		// Token: 0x0400B334 RID: 45876
		[OriginalName("ErrIEntityFsmTransitToState")]
		ErrIentityFsmTransitToState,
		// Token: 0x0400B335 RID: 45877
		[OriginalName("ErrIEntityFsmConfirmNotExist")]
		ErrIentityFsmConfirmNotExist,
		// Token: 0x0400B336 RID: 45878
		[OriginalName("ErrIEntityFsmConfirmNotWait")]
		ErrIentityFsmConfirmNotWait,
		// Token: 0x0400B337 RID: 45879
		[OriginalName("ErrITest")]
		ErrItest,
		// Token: 0x0400B338 RID: 45880
		[OriginalName("ErrITest1")]
		ErrItest1,
		// Token: 0x0400B339 RID: 45881
		[OriginalName("ErrITest2")]
		ErrItest2,
		// Token: 0x0400B33A RID: 45882
		[OriginalName("ErrIEntityFsmCondCantPass")]
		ErrIentityFsmCondCantPass,
		// Token: 0x0400B33B RID: 45883
		[OriginalName("ErrIEntityFsmActionParamType")]
		ErrIentityFsmActionParamType,
		// Token: 0x0400B33C RID: 45884
		[OriginalName("ErrIEntityFsmActionParam")]
		ErrIentityFsmActionParam,
		// Token: 0x0400B33D RID: 45885
		[OriginalName("ErrIEntityFsmActionExecuted")]
		ErrIentityFsmActionExecuted,
		// Token: 0x0400B33E RID: 45886
		[OriginalName("ErrIEntityFsmActionNotMatchState")]
		ErrIentityFsmActionNotMatchState,
		// Token: 0x0400B33F RID: 45887
		[OriginalName("ErrSkillNotExecuting")]
		ErrSkillNotExecuting,
		// Token: 0x0400B340 RID: 45888
		[OriginalName("ErrExecuteSkillNotMatch")]
		ErrExecuteSkillNotMatch,
		// Token: 0x0400B341 RID: 45889
		[OriginalName("ErrBlueprintPinNotSupport")]
		ErrBlueprintPinNotSupport,
		// Token: 0x0400B342 RID: 45890
		[OriginalName("ErrBlueprintPinNotMontage")]
		ErrBlueprintPinNotMontage,
		// Token: 0x0400B343 RID: 45891
		[OriginalName("ErrBlueprintPinMontageIndex")]
		ErrBlueprintPinMontageIndex,
		// Token: 0x0400B344 RID: 45892
		[OriginalName("ErrConfSkillNotExist")]
		ErrConfSkillNotExist,
		// Token: 0x0400B345 RID: 45893
		[OriginalName("ErrSkillGANotExist")]
		ErrSkillGanotExist,
		// Token: 0x0400B346 RID: 45894
		[OriginalName("ErrSkillGAHaveNoBuff")]
		ErrSkillGahaveNoBuff,
		// Token: 0x0400B347 RID: 45895
		[OriginalName("ErrSkillGAHaveNoBuffId")]
		ErrSkillGahaveNoBuffId,
		// Token: 0x0400B348 RID: 45896
		[OriginalName("ErrSkillGAHaveNoBullet")]
		ErrSkillGahaveNoBullet,
		// Token: 0x0400B349 RID: 45897
		[OriginalName("ErrSkillGAHaveNoBulletId")]
		ErrSkillGahaveNoBulletId,
		// Token: 0x0400B34A RID: 45898
		[OriginalName("ErrMontageNotMatchSkill")]
		ErrMontageNotMatchSkill,
		// Token: 0x0400B34B RID: 45899
		[OriginalName("ErrMontageIndexError")]
		ErrMontageIndexError,
		// Token: 0x0400B34C RID: 45900
		[OriginalName("ErrVisiionSkillNotEquip")]
		ErrVisiionSkillNotEquip,
		// Token: 0x0400B34D RID: 45901
		[OriginalName("ErrSkillCD")]
		ErrSkillCd,
		// Token: 0x0400B34E RID: 45902
		[OriginalName("ErrHaveNoBattleContext")]
		ErrHaveNoBattleContext,
		// Token: 0x0400B34F RID: 45903
		[OriginalName("ErrContextFsmActionOnce")]
		ErrContextFsmActionOnce,
		// Token: 0x0400B350 RID: 45904
		[OriginalName("ErrPlayMontageButNoSkill")]
		ErrPlayMontageButNoSkill,
		// Token: 0x0400B351 RID: 45905
		[OriginalName("ErrMontageNotExist")]
		ErrMontageNotExist,
		// Token: 0x0400B352 RID: 45906
		[OriginalName("ErrMontageNotContainBuff")]
		ErrMontageNotContainBuff,
		// Token: 0x0400B353 RID: 45907
		[OriginalName("ErrMontageNotContainBullet")]
		ErrMontageNotContainBullet,
		// Token: 0x0400B354 RID: 45908
		[OriginalName("ErrMontageCantBring")]
		ErrMontageCantBring,
		// Token: 0x0400B355 RID: 45909
		[OriginalName("ErrSkillInfoParamError")]
		ErrSkillInfoParamError,
		// Token: 0x0400B356 RID: 45910
		[OriginalName("ErrNoWorldTeam")]
		ErrNoWorldTeam = 1800000,
		// Token: 0x0400B357 RID: 45911
		[OriginalName("ErrWorldTeamNoMember")]
		ErrWorldTeamNoMember,
		// Token: 0x0400B358 RID: 45912
		[OriginalName("ErrNoHostIs")]
		ErrNoHostIs,
		// Token: 0x0400B359 RID: 45913
		[OriginalName("ErrNoInstId")]
		ErrNoInstId,
		// Token: 0x0400B35A RID: 45914
		[OriginalName("ErrNoTeamInfo")]
		ErrNoTeamInfo,
		// Token: 0x0400B35B RID: 45915
		[OriginalName("ErrHostNoTeamInfo")]
		ErrHostNoTeamInfo,
		// Token: 0x0400B35C RID: 45916
		[OriginalName("ErrHasInMatchTeam")]
		ErrHasInMatchTeam,
		// Token: 0x0400B35D RID: 45917
		[OriginalName("ErrNotInMatchTeam")]
		ErrNotInMatchTeam,
		// Token: 0x0400B35E RID: 45918
		[OriginalName("ErrHostIsParam")]
		ErrHostIsParam,
		// Token: 0x0400B35F RID: 45919
		[OriginalName("ErrMatchModeIParam")]
		ErrMatchModeIparam,
		// Token: 0x0400B360 RID: 45920
		[OriginalName("ErrMatchTeamFull")]
		ErrMatchTeamFull,
		// Token: 0x0400B361 RID: 45921
		[OriginalName("ErrLocalTeamCanNotOpt")]
		ErrLocalTeamCanNotOpt,
		// Token: 0x0400B362 RID: 45922
		[OriginalName("ErrHostInLocalTeam")]
		ErrHostInLocalTeam,
		// Token: 0x0400B363 RID: 45923
		[OriginalName("ErrNoMatchNodeId")]
		ErrNoMatchNodeId,
		// Token: 0x0400B364 RID: 45924
		[OriginalName("ErrPlayerSceneIsNull")]
		ErrPlayerSceneIsNull,
		// Token: 0x0400B365 RID: 45925
		[OriginalName("ErrPlayerSceneRolesNull")]
		ErrPlayerSceneRolesNull,
		// Token: 0x0400B366 RID: 45926
		[OriginalName("ErrInvalidMatchState")]
		ErrInvalidMatchState,
		// Token: 0x0400B367 RID: 45927
		[OriginalName("ErrRepeatedMatchState")]
		ErrRepeatedMatchState,
		// Token: 0x0400B368 RID: 45928
		[OriginalName("ErrApplyrPlayerInMatchNotEnterMatchTeam")]
		ErrApplyrPlayerInMatchNotEnterMatchTeam,
		// Token: 0x0400B369 RID: 45929
		[OriginalName("ErrOtherVersionLowNoOperate")]
		ErrOtherVersionLowNoOperate,
		// Token: 0x0400B36A RID: 45930
		[OriginalName("ErrPlayerVersionLowNeedUpdate")]
		ErrPlayerVersionLowNeedUpdate,
		// Token: 0x0400B36B RID: 45931
		[OriginalName("ErrMultiGameModeNoWorldLevelDown")]
		ErrMultiGameModeNoWorldLevelDown,
		// Token: 0x0400B36C RID: 45932
		[OriginalName("ErrMultiGameModeNoWorldLevelRegain")]
		ErrMultiGameModeNoWorldLevelRegain,
		// Token: 0x0400B36D RID: 45933
		[OriginalName("ErrOtherHasOnline")]
		ErrOtherHasOnline,
		// Token: 0x0400B36E RID: 45934
		[OriginalName("SwitchRoleNotInCurrentFormation")]
		SwitchRoleNotInCurrentFormation,
		// Token: 0x0400B36F RID: 45935
		[OriginalName("ErrNoChangeRoles")]
		ErrNoChangeRoles,
		// Token: 0x0400B370 RID: 45936
		[OriginalName("ErrExploreSkillPullGiantMultiGame")]
		ErrExploreSkillPullGiantMultiGame,
		// Token: 0x0400B371 RID: 45937
		[OriginalName("ErrExploreSkillPullGiantNotExist")]
		ErrExploreSkillPullGiantNotExist,
		// Token: 0x0400B372 RID: 45938
		[OriginalName("ErrHttpRpcParam")]
		ErrHttpRpcParam,
		// Token: 0x0400B373 RID: 45939
		[OriginalName("ErrPlayerNotInGameNode")]
		ErrPlayerNotInGameNode,
		// Token: 0x0400B374 RID: 45940
		[OriginalName("ErrApplyJoinPlayerCurRoleIsDead")]
		ErrApplyJoinPlayerCurRoleIsDead,
		// Token: 0x0400B375 RID: 45941
		[OriginalName("ErrPlayerCurRoleIsDeadNoJoin")]
		ErrPlayerCurRoleIsDeadNoJoin,
		// Token: 0x0400B376 RID: 45942
		[OriginalName("ErrPlayerCurRoleIsDead")]
		ErrPlayerCurRoleIsDead,
		// Token: 0x0400B377 RID: 45943
		[OriginalName("ErrSwitchMultiverse")]
		ErrSwitchMultiverse,
		// Token: 0x0400B378 RID: 45944
		[OriginalName("ErrSwitchNode")]
		ErrSwitchNode,
		// Token: 0x0400B379 RID: 45945
		[OriginalName("ErrMatchConfirmPlayerDead")]
		ErrMatchConfirmPlayerDead,
		// Token: 0x0400B37A RID: 45946
		[OriginalName("ErrCheckPublicResourceVersionLower")]
		ErrCheckPublicResourceVersionLower,
		// Token: 0x0400B37B RID: 45947
		[OriginalName("ErrCheckPublicResourceVersionHigher")]
		ErrCheckPublicResourceVersionHigher,
		// Token: 0x0400B37C RID: 45948
		[OriginalName("ErrCheckPublicResourceClientVersionErr")]
		ErrCheckPublicResourceClientVersionErr,
		// Token: 0x0400B37D RID: 45949
		[OriginalName("ErrCheckPublicResourceServerVersionErr")]
		ErrCheckPublicResourceServerVersionErr,
		// Token: 0x0400B37E RID: 45950
		[OriginalName("ErrCheckPublicResourceClientVersionParamErr")]
		ErrCheckPublicResourceClientVersionParamErr,
		// Token: 0x0400B37F RID: 45951
		[OriginalName("ErrCheckClientVersionNeedUpdate")]
		ErrCheckClientVersionNeedUpdate,
		// Token: 0x0400B380 RID: 45952
		[OriginalName("ErrBranchNameNotMatch")]
		ErrBranchNameNotMatch,
		// Token: 0x0400B381 RID: 45953
		[OriginalName("ErrMatchRpcAlready")]
		ErrMatchRpcAlready,
		// Token: 0x0400B382 RID: 45954
		[OriginalName("ErrOtherPlayerEnterHost")]
		ErrOtherPlayerEnterHost,
		// Token: 0x0400B383 RID: 45955
		[OriginalName("ErrPlayerEnterHost")]
		ErrPlayerEnterHost,
		// Token: 0x0400B384 RID: 45956
		[OriginalName("ErrLevelPlayChangeSprotModeInMutile")]
		ErrLevelPlayChangeSprotModeInMutile,
		// Token: 0x0400B385 RID: 45957
		[OriginalName("ErrMatchingNotInvite")]
		ErrMatchingNotInvite,
		// Token: 0x0400B386 RID: 45958
		[OriginalName("ErrEnableFunctionFB")]
		ErrEnableFunctionFb,
		// Token: 0x0400B387 RID: 45959
		[OriginalName("ErrMatchSelectTrialRole")]
		ErrMatchSelectTrialRole,
		// Token: 0x0400B388 RID: 45960
		[OriginalName("ErrNoFindLastBigScene")]
		ErrNoFindLastBigScene,
		// Token: 0x0400B389 RID: 45961
		[OriginalName("ErrExploreSkillCustomMultiGame")]
		ErrExploreSkillCustomMultiGame,
		// Token: 0x0400B38A RID: 45962
		[OriginalName("ErrExploreSkillCustomNotExist")]
		ErrExploreSkillCustomNotExist,
		// Token: 0x0400B38B RID: 45963
		[OriginalName("ErrMatchInviteMemberDead")]
		ErrMatchInviteMemberDead,
		// Token: 0x0400B38C RID: 45964
		[OriginalName("ErrMatchAcceptInviteMemberDead")]
		ErrMatchAcceptInviteMemberDead,
		// Token: 0x0400B38D RID: 45965
		[OriginalName("ErrNoFishBoat")]
		ErrNoFishBoat,
		// Token: 0x0400B38E RID: 45966
		[OriginalName("ErrTemplateNotExists")]
		ErrTemplateNotExists,
		// Token: 0x0400B38F RID: 45967
		[OriginalName("ErrDisableSubLevels")]
		ErrDisableSubLevels = 1800058,
		// Token: 0x0400B390 RID: 45968
		[OriginalName("ErrSubLevelsClientNoPermission")]
		ErrSubLevelsClientNoPermission,
		// Token: 0x0400B391 RID: 45969
		[OriginalName("ErrExploreSkillCustomNoActions")]
		ErrExploreSkillCustomNoActions = 1800057,
		// Token: 0x0400B392 RID: 45970
		[OriginalName("ErrMatchClientVersion")]
		ErrMatchClientVersion = 1800060,
		// Token: 0x0400B393 RID: 45971
		[OriginalName("ErrCurNodeIsTainted")]
		ErrCurNodeIsTainted,
		// Token: 0x0400B394 RID: 45972
		[OriginalName("ErrTeamMateNodeIsTainted")]
		ErrTeamMateNodeIsTainted,
		// Token: 0x0400B395 RID: 45973
		[OriginalName("ErrMapFuctionNotOpen")]
		ErrMapFuctionNotOpen,
		// Token: 0x0400B396 RID: 45974
		[OriginalName("ErrNotSceneOwner")]
		ErrNotSceneOwner,
		// Token: 0x0400B397 RID: 45975
		[OriginalName("ErrLevelPlayUiListIsNull")]
		ErrLevelPlayUiListIsNull,
		// Token: 0x0400B398 RID: 45976
		[OriginalName("ErrOpenLevelPlayNotClientUi")]
		ErrOpenLevelPlayNotClientUi,
		// Token: 0x0400B399 RID: 45977
		[OriginalName("ErrOpenLevelPlayFailed")]
		ErrOpenLevelPlayFailed,
		// Token: 0x0400B39A RID: 45978
		[OriginalName("ErrBlackSwordChallengeId")]
		ErrBlackSwordChallengeId,
		// Token: 0x0400B39B RID: 45979
		[OriginalName("ErrCalabashLevelRequest")]
		ErrCalabashLevelRequest = 1900000,
		// Token: 0x0400B39C RID: 45980
		[OriginalName("ErrCalabashLevelRewardDone")]
		ErrCalabashLevelRewardDone,
		// Token: 0x0400B39D RID: 45981
		[OriginalName("ErrCalabashLevelConfig")]
		ErrCalabashLevelConfig,
		// Token: 0x0400B39E RID: 45982
		[OriginalName("ErrSkillTreeActiveConsume")]
		ErrSkillTreeActiveConsume,
		// Token: 0x0400B39F RID: 45983
		[OriginalName("ErrLoadFriendData")]
		ErrLoadFriendData,
		// Token: 0x0400B3A0 RID: 45984
		[OriginalName("ErrNoLoadPrivateChatData")]
		ErrNoLoadPrivateChatData,
		// Token: 0x0400B3A1 RID: 45985
		[OriginalName("ErrNotInWolrd")]
		ErrNotInWolrd,
		// Token: 0x0400B3A2 RID: 45986
		[OriginalName("ErrNotInGround")]
		ErrNotInGround,
		// Token: 0x0400B3A3 RID: 45987
		[OriginalName("ErrInFighting")]
		ErrInFighting,
		// Token: 0x0400B3A4 RID: 45988
		[OriginalName("ErrNotHaveCountryAccess")]
		ErrNotHaveCountryAccess,
		// Token: 0x0400B3A5 RID: 45989
		[OriginalName("ErrSkillIsEffect")]
		ErrSkillIsEffect,
		// Token: 0x0400B3A6 RID: 45990
		[OriginalName("ErrNoSoundBox")]
		ErrNoSoundBox,
		// Token: 0x0400B3A7 RID: 45991
		[OriginalName("ErrConsumeNotEnough")]
		ErrConsumeNotEnough,
		// Token: 0x0400B3A8 RID: 45992
		[OriginalName("ErrExploreSkillCountLimit")]
		ErrExploreSkillCountLimit,
		// Token: 0x0400B3A9 RID: 45993
		[OriginalName("ErrLegalAreaNoTreasureBox")]
		ErrLegalAreaNoTreasureBox,
		// Token: 0x0400B3AA RID: 45994
		[OriginalName("ErrTreasureBoxAllActive")]
		ErrTreasureBoxAllActive,
		// Token: 0x0400B3AB RID: 45995
		[OriginalName("ExploreProgressNoCountry")]
		ExploreProgressNoCountry,
		// Token: 0x0400B3AC RID: 45996
		[OriginalName("ExploreProgressNoScoreCfg")]
		ExploreProgressNoScoreCfg,
		// Token: 0x0400B3AD RID: 45997
		[OriginalName("ExploreProgressLackProgress")]
		ExploreProgressLackProgress,
		// Token: 0x0400B3AE RID: 45998
		[OriginalName("ExploreProgressRewardDone")]
		ExploreProgressRewardDone,
		// Token: 0x0400B3AF RID: 45999
		[OriginalName("ExploreProgressNoArea")]
		ExploreProgressNoArea,
		// Token: 0x0400B3B0 RID: 46000
		[OriginalName("ExploreToolNotConfirm")]
		ExploreToolNotConfirm,
		// Token: 0x0400B3B1 RID: 46001
		[OriginalName("ExploreToolNotOpen")]
		ExploreToolNotOpen,
		// Token: 0x0400B3B2 RID: 46002
		[OriginalName("ErrTreasureBoxPlaceFail")]
		ErrTreasureBoxPlaceFail,
		// Token: 0x0400B3B3 RID: 46003
		[OriginalName("ErrTreasureBoxData")]
		ErrTreasureBoxData,
		// Token: 0x0400B3B4 RID: 46004
		[OriginalName("ErrPayShopBuyCondition")]
		ErrPayShopBuyCondition,
		// Token: 0x0400B3B5 RID: 46005
		[OriginalName("ErrGatherActivityData")]
		ErrGatherActivityData,
		// Token: 0x0400B3B6 RID: 46006
		[OriginalName("ErrGatherTaskNoFinish")]
		ErrGatherTaskNoFinish,
		// Token: 0x0400B3B7 RID: 46007
		[OriginalName("ErrHadGatherReward")]
		ErrHadGatherReward,
		// Token: 0x0400B3B8 RID: 46008
		[OriginalName("ErrHadGetSharedReward")]
		ErrHadGetSharedReward,
		// Token: 0x0400B3B9 RID: 46009
		[OriginalName("ErrSharedPlat")]
		ErrSharedPlat,
		// Token: 0x0400B3BA RID: 46010
		[OriginalName("ErrTowerTargetComplete")]
		ErrTowerTargetComplete,
		// Token: 0x0400B3BB RID: 46011
		[OriginalName("ErrTowerGuideRewardHad")]
		ErrTowerGuideRewardHad,
		// Token: 0x0400B3BC RID: 46012
		[OriginalName("ErrTowerGuideNoOpen")]
		ErrTowerGuideNoOpen,
		// Token: 0x0400B3BD RID: 46013
		[OriginalName("ErrTowerGuideConfig")]
		ErrTowerGuideConfig,
		// Token: 0x0400B3BE RID: 46014
		[OriginalName("ErrNewBieCourseConfig")]
		ErrNewBieCourseConfig,
		// Token: 0x0400B3BF RID: 46015
		[OriginalName("ErrNewBieCourseRewardHad")]
		ErrNewBieCourseRewardHad,
		// Token: 0x0400B3C0 RID: 46016
		[OriginalName("ErrNewBieCourseLevel")]
		ErrNewBieCourseLevel,
		// Token: 0x0400B3C1 RID: 46017
		[OriginalName("ErrDetectionTargetSilence")]
		ErrDetectionTargetSilence,
		// Token: 0x0400B3C2 RID: 46018
		[OriginalName("ErrRoleTrialNotInit")]
		ErrRoleTrialNotInit,
		// Token: 0x0400B3C3 RID: 46019
		[OriginalName("ErrRoleTrialNoFinish")]
		ErrRoleTrialNoFinish,
		// Token: 0x0400B3C4 RID: 46020
		[OriginalName("ErrRoleTrialReward")]
		ErrRoleTrialReward,
		// Token: 0x0400B3C5 RID: 46021
		[OriginalName("ErrRoleTrialRewardDone")]
		ErrRoleTrialRewardDone,
		// Token: 0x0400B3C6 RID: 46022
		[OriginalName("ErrAdventureTaskReward")]
		ErrAdventureTaskReward,
		// Token: 0x0400B3C7 RID: 46023
		[OriginalName("ErrChapterReward")]
		ErrChapterReward,
		// Token: 0x0400B3C8 RID: 46024
		[OriginalName("ErrSilentFirstPassStatus")]
		ErrSilentFirstPassStatus,
		// Token: 0x0400B3C9 RID: 46025
		[OriginalName("ErrSilentFirstPassReward")]
		ErrSilentFirstPassReward,
		// Token: 0x0400B3CA RID: 46026
		[OriginalName("ErrPayShopEchoRole")]
		ErrPayShopEchoRole,
		// Token: 0x0400B3CB RID: 46027
		[OriginalName("ErrPayShopEchoItemOver")]
		ErrPayShopEchoItemOver,
		// Token: 0x0400B3CC RID: 46028
		[OriginalName("ErrDailyAdventureActivityInit")]
		ErrDailyAdventureActivityInit,
		// Token: 0x0400B3CD RID: 46029
		[OriginalName("ErrDailyAdventureActivityPtEnough")]
		ErrDailyAdventureActivityPtEnough,
		// Token: 0x0400B3CE RID: 46030
		[OriginalName("ErrDailyAdventureActivityRewardDone")]
		ErrDailyAdventureActivityRewardDone,
		// Token: 0x0400B3CF RID: 46031
		[OriginalName("ErrDailyAdventureActivityRewardTake")]
		ErrDailyAdventureActivityRewardTake,
		// Token: 0x0400B3D0 RID: 46032
		[OriginalName("ErrDailyAdventureActivityTaskDone")]
		ErrDailyAdventureActivityTaskDone,
		// Token: 0x0400B3D1 RID: 46033
		[OriginalName("ErrRoleTrialTimeOut")]
		ErrRoleTrialTimeOut,
		// Token: 0x0400B3D2 RID: 46034
		[OriginalName("ErrFriendRemarkNull")]
		ErrFriendRemarkNull,
		// Token: 0x0400B3D3 RID: 46035
		[OriginalName("ErrTrackMoonRoleUnLock")]
		ErrTrackMoonRoleUnLock,
		// Token: 0x0400B3D4 RID: 46036
		[OriginalName("ErrTrackMoonTrigger")]
		ErrTrackMoonTrigger,
		// Token: 0x0400B3D5 RID: 46037
		[OriginalName("ErrTrackMoonBuildingUnLock")]
		ErrTrackMoonBuildingUnLock,
		// Token: 0x0400B3D6 RID: 46038
		[OriginalName("ErrTrackMoonBuildingCurve")]
		ErrTrackMoonBuildingCurve,
		// Token: 0x0400B3D7 RID: 46039
		[OriginalName("ErrTrackMoonBuildingLock")]
		ErrTrackMoonBuildingLock,
		// Token: 0x0400B3D8 RID: 46040
		[OriginalName("ErrMoonEntrustCfg")]
		ErrMoonEntrustCfg,
		// Token: 0x0400B3D9 RID: 46041
		[OriginalName("ErrMoonRoleCfg")]
		ErrMoonRoleCfg,
		// Token: 0x0400B3DA RID: 46042
		[OriginalName("ErrMoonRoleTrailCurve")]
		ErrMoonRoleTrailCurve,
		// Token: 0x0400B3DB RID: 46043
		[OriginalName("ErrMoonBuildingCfg")]
		ErrMoonBuildingCfg,
		// Token: 0x0400B3DC RID: 46044
		[OriginalName("ErrMoonItemConsume")]
		ErrMoonItemConsume,
		// Token: 0x0400B3DD RID: 46045
		[OriginalName("ErrDirtyWordDeserialize")]
		ErrDirtyWordDeserialize,
		// Token: 0x0400B3DE RID: 46046
		[OriginalName("ErrMoonTargetNoFinish")]
		ErrMoonTargetNoFinish,
		// Token: 0x0400B3DF RID: 46047
		[OriginalName("ErrMoonActivityReward")]
		ErrMoonActivityReward,
		// Token: 0x0400B3E0 RID: 46048
		[OriginalName("ErrMoonActivityOpen")]
		ErrMoonActivityOpen,
		// Token: 0x0400B3E1 RID: 46049
		[OriginalName("ErrCircumDoReward")]
		ErrCircumDoReward,
		// Token: 0x0400B3E2 RID: 46050
		[OriginalName("ErrRetrunRewardCfg")]
		ErrRetrunRewardCfg,
		// Token: 0x0400B3E3 RID: 46051
		[OriginalName("ErrRetrunRewardLevel")]
		ErrRetrunRewardLevel,
		// Token: 0x0400B3E4 RID: 46052
		[OriginalName("ErrRetrunHaddone")]
		ErrRetrunHaddone,
		// Token: 0x0400B3E5 RID: 46053
		[OriginalName("ErrSignRewardCfg")]
		ErrSignRewardCfg,
		// Token: 0x0400B3E6 RID: 46054
		[OriginalName("ErrCircumSignHadRwd")]
		ErrCircumSignHadRwd,
		// Token: 0x0400B3E7 RID: 46055
		[OriginalName("ErrCircumNoSign")]
		ErrCircumNoSign,
		// Token: 0x0400B3E8 RID: 46056
		[OriginalName("ErrScoreRewardCfg")]
		ErrScoreRewardCfg,
		// Token: 0x0400B3E9 RID: 46057
		[OriginalName("ErrCircumScoreHadRwd")]
		ErrCircumScoreHadRwd,
		// Token: 0x0400B3EA RID: 46058
		[OriginalName("ErrCircumScoreLack")]
		ErrCircumScoreLack,
		// Token: 0x0400B3EB RID: 46059
		[OriginalName("ErrCircumTaskNoFinish")]
		ErrCircumTaskNoFinish,
		// Token: 0x0400B3EC RID: 46060
		[OriginalName("LoginServiceInvalidToken")]
		LoginServiceInvalidToken,
		// Token: 0x0400B3ED RID: 46061
		[OriginalName("LoginFusing")]
		LoginFusing,
		// Token: 0x0400B3EE RID: 46062
		[OriginalName("LoginRateLimiterRejected")]
		LoginRateLimiterRejected,
		// Token: 0x0400B3EF RID: 46063
		[OriginalName("LoginTimeoutRejected")]
		LoginTimeoutRejected,
		// Token: 0x0400B3F0 RID: 46064
		[OriginalName("AccountInputErr")]
		AccountInputErr,
		// Token: 0x0400B3F1 RID: 46065
		[OriginalName("DevInvalidLoginType")]
		DevInvalidLoginType,
		// Token: 0x0400B3F2 RID: 46066
		[OriginalName("GARInvalidLoginType")]
		GarinvalidLoginType,
		// Token: 0x0400B3F3 RID: 46067
		[OriginalName("GARDevInvalidLoginType")]
		GardevInvalidLoginType,
		// Token: 0x0400B3F4 RID: 46068
		[OriginalName("SdkserverTimeOut")]
		SdkserverTimeOut,
		// Token: 0x0400B3F5 RID: 46069
		[OriginalName("ReconnectInvalidOperation")]
		ReconnectInvalidOperation,
		// Token: 0x0400B3F6 RID: 46070
		[OriginalName("PbMessageAppVersionNotMatch")]
		PbMessageAppVersionNotMatch,
		// Token: 0x0400B3F7 RID: 46071
		[OriginalName("ErrPluginReconnectIpWhiteList")]
		ErrPluginReconnectIpWhiteList,
		// Token: 0x0400B3F8 RID: 46072
		[OriginalName("NotInUserIdWhiteListWithChannel")]
		NotInUserIdWhiteListWithChannel,
		// Token: 0x0400B3F9 RID: 46073
		[OriginalName("ErrPluginReconnectChannelWhiteList")]
		ErrPluginReconnectChannelWhiteList,
		// Token: 0x0400B3FA RID: 46074
		[OriginalName("PluginPlayerLoggingIn")]
		PluginPlayerLoggingIn,
		// Token: 0x0400B3FB RID: 46075
		[OriginalName("LoginFusing2")]
		LoginFusing2,
		// Token: 0x0400B3FC RID: 46076
		[OriginalName("SoundBoxExploreFull")]
		SoundBoxExploreFull,
		// Token: 0x0400B3FD RID: 46077
		[OriginalName("ErrMoonEntrustNoData")]
		ErrMoonEntrustNoData,
		// Token: 0x0400B3FE RID: 46078
		[OriginalName("ErrMoonMoneyNotEnough")]
		ErrMoonMoneyNotEnough,
		// Token: 0x0400B3FF RID: 46079
		[OriginalName("ErrCircumFluenceTimeIn")]
		ErrCircumFluenceTimeIn,
		// Token: 0x0400B400 RID: 46080
		[OriginalName("DragonPoolRewardWayErr")]
		DragonPoolRewardWayErr,
		// Token: 0x0400B401 RID: 46081
		[OriginalName("DragonPoolNoHandIn")]
		DragonPoolNoHandIn,
		// Token: 0x0400B402 RID: 46082
		[OriginalName("WeaponSkinNoEquiped")]
		WeaponSkinNoEquiped,
		// Token: 0x0400B403 RID: 46083
		[OriginalName("WeaponSkinDataErr")]
		WeaponSkinDataErr,
		// Token: 0x0400B404 RID: 46084
		[OriginalName("WeaponSkinUnLockErr")]
		WeaponSkinUnLockErr,
		// Token: 0x0400B405 RID: 46085
		[OriginalName("WeaponSkinEquipDone")]
		WeaponSkinEquipDone,
		// Token: 0x0400B406 RID: 46086
		[OriginalName("WeaponSkinTypeErr")]
		WeaponSkinTypeErr,
		// Token: 0x0400B407 RID: 46087
		[OriginalName("FriendOfflineMsgErr")]
		FriendOfflineMsgErr,
		// Token: 0x0400B408 RID: 46088
		[OriginalName("FindSpringSignConfigErr")]
		FindSpringSignConfigErr,
		// Token: 0x0400B409 RID: 46089
		[OriginalName("SpringSignDataErr")]
		SpringSignDataErr,
		// Token: 0x0400B40A RID: 46090
		[OriginalName("SpringSignRewardDone")]
		SpringSignRewardDone,
		// Token: 0x0400B40B RID: 46091
		[OriginalName("SpringSignRewardGetErr")]
		SpringSignRewardGetErr,
		// Token: 0x0400B40C RID: 46092
		[OriginalName("SpringSignNoOpen")]
		SpringSignNoOpen,
		// Token: 0x0400B40D RID: 46093
		[OriginalName("SpringSignNoTask")]
		SpringSignNoTask,
		// Token: 0x0400B40E RID: 46094
		[OriginalName("SpringSignInviteNum")]
		SpringSignInviteNum,
		// Token: 0x0400B40F RID: 46095
		[OriginalName("SpringSignRolePool")]
		SpringSignRolePool,
		// Token: 0x0400B410 RID: 46096
		[OriginalName("SpringSignDrawPoolNull")]
		SpringSignDrawPoolNull,
		// Token: 0x0400B411 RID: 46097
		[OriginalName("FarmGoldActivityNotOpen")]
		FarmGoldActivityNotOpen,
		// Token: 0x0400B412 RID: 46098
		[OriginalName("FarmGoldActivityPointReceived")]
		FarmGoldActivityPointReceived,
		// Token: 0x0400B413 RID: 46099
		[OriginalName("FarmGoldActivityPointNotConfig")]
		FarmGoldActivityPointNotConfig,
		// Token: 0x0400B414 RID: 46100
		[OriginalName("FarmGoldActivityPointNotEnough")]
		FarmGoldActivityPointNotEnough,
		// Token: 0x0400B415 RID: 46101
		[OriginalName("FarmGoldActivityLevelNoData")]
		FarmGoldActivityLevelNoData,
		// Token: 0x0400B416 RID: 46102
		[OriginalName("FarmGoldActivityLevelReceived")]
		FarmGoldActivityLevelReceived,
		// Token: 0x0400B417 RID: 46103
		[OriginalName("FarmGoldActivityLevelNotConfig")]
		FarmGoldActivityLevelNotConfig,
		// Token: 0x0400B418 RID: 46104
		[OriginalName("FarmGoldActivityLevelDiffNotConfig")]
		FarmGoldActivityLevelDiffNotConfig,
		// Token: 0x0400B419 RID: 46105
		[OriginalName("FarmGoldInstIdInValid")]
		FarmGoldInstIdInValid,
		// Token: 0x0400B41A RID: 46106
		[OriginalName("FarmGoldVarNotExist")]
		FarmGoldVarNotExist,
		// Token: 0x0400B41B RID: 46107
		[OriginalName("FarmGoldResultCacheNotExist")]
		FarmGoldResultCacheNotExist,
		// Token: 0x0400B41C RID: 46108
		[OriginalName("FarmGoldInstNotOpen")]
		FarmGoldInstNotOpen,
		// Token: 0x0400B41D RID: 46109
		[OriginalName("FarmGoldActivityLimitDataNotFind")]
		FarmGoldActivityLimitDataNotFind,
		// Token: 0x0400B41E RID: 46110
		[OriginalName("MapTravelDataErr")]
		MapTravelDataErr,
		// Token: 0x0400B41F RID: 46111
		[OriginalName("MapTravelConfigErr")]
		MapTravelConfigErr,
		// Token: 0x0400B420 RID: 46112
		[OriginalName("MapTravelCannotReward")]
		MapTravelCannotReward,
		// Token: 0x0400B421 RID: 46113
		[OriginalName("MapTravelRewardGet")]
		MapTravelRewardGet,
		// Token: 0x0400B422 RID: 46114
		[OriginalName("MapTravelMaxLevel")]
		MapTravelMaxLevel,
		// Token: 0x0400B423 RID: 46115
		[OriginalName("MapTravelLackExp")]
		MapTravelLackExp,
		// Token: 0x0400B424 RID: 46116
		[OriginalName("FarmGoldLevelNotOpen")]
		FarmGoldLevelNotOpen,
		// Token: 0x0400B425 RID: 46117
		[OriginalName("MapTravelAreaLock")]
		MapTravelAreaLock,
		// Token: 0x0400B426 RID: 46118
		[OriginalName("MapTravelAreaConfigErr")]
		MapTravelAreaConfigErr,
		// Token: 0x0400B427 RID: 46119
		[OriginalName("SlashAndTowerCacheErr")]
		SlashAndTowerCacheErr = 1900142,
		// Token: 0x0400B428 RID: 46120
		[OriginalName("SlashAndTowerConfigErr")]
		SlashAndTowerConfigErr,
		// Token: 0x0400B429 RID: 46121
		[OriginalName("SlashAndTowerDataErr")]
		SlashAndTowerDataErr,
		// Token: 0x0400B42A RID: 46122
		[OriginalName("SlashAndTowerReceivedLevelAward")]
		SlashAndTowerReceivedLevelAward,
		// Token: 0x0400B42B RID: 46123
		[OriginalName("SlashAndTowerNotReward")]
		SlashAndTowerNotReward,
		// Token: 0x0400B42C RID: 46124
		[OriginalName("SlashAndTowerRoleNum")]
		SlashAndTowerRoleNum,
		// Token: 0x0400B42D RID: 46125
		[OriginalName("SlashAndTowerBuffNum")]
		SlashAndTowerBuffNum,
		// Token: 0x0400B42E RID: 46126
		[OriginalName("SlashAndTowerBuffConfig")]
		SlashAndTowerBuffConfig,
		// Token: 0x0400B42F RID: 46127
		[OriginalName("SlashAndTowerBuffAccess")]
		SlashAndTowerBuffAccess,
		// Token: 0x0400B430 RID: 46128
		[OriginalName("SlashAndTowerRoleSame")]
		SlashAndTowerRoleSame,
		// Token: 0x0400B431 RID: 46129
		[OriginalName("SlashAndTowerSeasonErr")]
		SlashAndTowerSeasonErr,
		// Token: 0x0400B432 RID: 46130
		[OriginalName("SlashAndTowerBuffLack")]
		SlashAndTowerBuffLack,
		// Token: 0x0400B433 RID: 46131
		[OriginalName("MapTravelLevelUpCfgErr")]
		MapTravelLevelUpCfgErr = 1900140,
		// Token: 0x0400B434 RID: 46132
		[OriginalName("MapTravelLevelCfgErr")]
		MapTravelLevelCfgErr,
		// Token: 0x0400B435 RID: 46133
		[OriginalName("TeamParkOurTaskCfgErr")]
		TeamParkOurTaskCfgErr = 1900154,
		// Token: 0x0400B436 RID: 46134
		[OriginalName("TeamParkOurDataErr")]
		TeamParkOurDataErr,
		// Token: 0x0400B437 RID: 46135
		[OriginalName("TeamParkOurCfgNoMatch")]
		TeamParkOurCfgNoMatch,
		// Token: 0x0400B438 RID: 46136
		[OriginalName("TeamParkOurTaskDoing")]
		TeamParkOurTaskDoing,
		// Token: 0x0400B439 RID: 46137
		[OriginalName("TeamParkOurTaskTaken")]
		TeamParkOurTaskTaken,
		// Token: 0x0400B43A RID: 46138
		[OriginalName("TeamParkOurLevelLock")]
		TeamParkOurLevelLock,
		// Token: 0x0400B43B RID: 46139
		[OriginalName("TeamParkOurFindNoLevel")]
		TeamParkOurFindNoLevel,
		// Token: 0x0400B43C RID: 46140
		[OriginalName("SlashAndTowerRewardErr")]
		SlashAndTowerRewardErr,
		// Token: 0x0400B43D RID: 46141
		[OriginalName("SlashAndTowerBuffSeasonErr")]
		SlashAndTowerBuffSeasonErr,
		// Token: 0x0400B43E RID: 46142
		[OriginalName("SlashAndTowerNotOpen")]
		SlashAndTowerNotOpen,
		// Token: 0x0400B43F RID: 46143
		[OriginalName("SlashAndTowerSeasonToCfgErr")]
		SlashAndTowerSeasonToCfgErr,
		// Token: 0x0400B440 RID: 46144
		[OriginalName("SlashAndTowerSeasonNoUpdate")]
		SlashAndTowerSeasonNoUpdate,
		// Token: 0x0400B441 RID: 46145
		[OriginalName("SlashAndTowerFirstNoPass")]
		SlashAndTowerFirstNoPass,
		// Token: 0x0400B442 RID: 46146
		[OriginalName("SlashAndTowerLevelErr")]
		SlashAndTowerLevelErr,
		// Token: 0x0400B443 RID: 46147
		[OriginalName("TeamParkMemberErr")]
		TeamParkMemberErr,
		// Token: 0x0400B444 RID: 46148
		[OriginalName("AvignonNotOpen")]
		AvignonNotOpen = 1900172,
		// Token: 0x0400B445 RID: 46149
		[OriginalName("AvignonNotConfig")]
		AvignonNotConfig,
		// Token: 0x0400B446 RID: 46150
		[OriginalName("AvignonTaskNotFinish")]
		AvignonTaskNotFinish,
		// Token: 0x0400B447 RID: 46151
		[OriginalName("AvignonTaskNotData")]
		AvignonTaskNotData,
		// Token: 0x0400B448 RID: 46152
		[OriginalName("AvignonHadReward")]
		AvignonHadReward,
		// Token: 0x0400B449 RID: 46153
		[OriginalName("SlashAndTowerTeamErr")]
		SlashAndTowerTeamErr = 1900169,
		// Token: 0x0400B44A RID: 46154
		[OriginalName("SlashAndTowerBuffErr")]
		SlashAndTowerBuffErr,
		// Token: 0x0400B44B RID: 46155
		[OriginalName("SeasonTowerNoMatch")]
		SeasonTowerNoMatch,
		// Token: 0x0400B44C RID: 46156
		[OriginalName("TeamParkOurMemberErr")]
		TeamParkOurMemberErr = 1900177,
		// Token: 0x0400B44D RID: 46157
		[OriginalName("BattlePassRewardDone")]
		BattlePassRewardDone,
		// Token: 0x0400B44E RID: 46158
		[OriginalName("SlashAndTowerAwardCfgErr")]
		SlashAndTowerAwardCfgErr,
		// Token: 0x0400B44F RID: 46159
		[OriginalName("NoFlySkinItem")]
		NoFlySkinItem,
		// Token: 0x0400B450 RID: 46160
		[OriginalName("FlySkinHadWear")]
		FlySkinHadWear,
		// Token: 0x0400B451 RID: 46161
		[OriginalName("NoOldFlySkinItem")]
		NoOldFlySkinItem,
		// Token: 0x0400B452 RID: 46162
		[OriginalName("OldFlySkinNoWear")]
		OldFlySkinNoWear,
		// Token: 0x0400B453 RID: 46163
		[OriginalName("RoleWearNoFlySkin")]
		RoleWearNoFlySkin,
		// Token: 0x0400B454 RID: 46164
		[OriginalName("FlySkinParaGliderNoOpen")]
		FlySkinParaGliderNoOpen,
		// Token: 0x0400B455 RID: 46165
		[OriginalName("FlySkinSoaringWingNoOpen")]
		FlySkinSoaringWingNoOpen,
		// Token: 0x0400B456 RID: 46166
		[OriginalName("NoRoleWearFlySkinSucc")]
		NoRoleWearFlySkinSucc,
		// Token: 0x0400B457 RID: 46167
		[OriginalName("FlySkinItemNoConfig")]
		FlySkinItemNoConfig,
		// Token: 0x0400B458 RID: 46168
		[OriginalName("SlashAndTowerLevelSettle")]
		SlashAndTowerLevelSettle,
		// Token: 0x0400B459 RID: 46169
		[OriginalName("FlySkinTypeErr")]
		FlySkinTypeErr,
		// Token: 0x0400B45A RID: 46170
		[OriginalName("FlySkinTrialRole")]
		FlySkinTrialRole,
		// Token: 0x0400B45B RID: 46171
		[OriginalName("RegreeNotOpen")]
		RegreeNotOpen,
		// Token: 0x0400B45C RID: 46172
		[OriginalName("RegressNoConfig")]
		RegressNoConfig,
		// Token: 0x0400B45D RID: 46173
		[OriginalName("RegressWrongId")]
		RegressWrongId,
		// Token: 0x0400B45E RID: 46174
		[OriginalName("NoRegressRoundData")]
		NoRegressRoundData,
		// Token: 0x0400B45F RID: 46175
		[OriginalName("NotInRegress")]
		NotInRegress,
		// Token: 0x0400B460 RID: 46176
		[OriginalName("AskRewardNoFinish")]
		AskRewardNoFinish,
		// Token: 0x0400B461 RID: 46177
		[OriginalName("BirthdayNotArrived")]
		BirthdayNotArrived,
		// Token: 0x0400B462 RID: 46178
		[OriginalName("BirthdayRoleInvalid")]
		BirthdayRoleInvalid,
		// Token: 0x0400B463 RID: 46179
		[OriginalName("BirthdayNoCfg")]
		BirthdayNoCfg,
		// Token: 0x0400B464 RID: 46180
		[OriginalName("HadBirthDayReward")]
		HadBirthDayReward,
		// Token: 0x0400B465 RID: 46181
		[OriginalName("BirthdayNoReset")]
		BirthdayNoReset,
		// Token: 0x0400B466 RID: 46182
		[OriginalName("BirthDayRewardTimeInvalid")]
		BirthDayRewardTimeInvalid,
		// Token: 0x0400B467 RID: 46183
		[OriginalName("BirthdayMustNowYear")]
		BirthdayMustNowYear,
		// Token: 0x0400B468 RID: 46184
		[OriginalName("BirthDayNotOpen")]
		BirthDayNotOpen,
		// Token: 0x0400B469 RID: 46185
		[OriginalName("BirthDayRewardNotFinish")]
		BirthDayRewardNotFinish,
		// Token: 0x0400B46A RID: 46186
		[OriginalName("BirthdayRoleDone")]
		BirthdayRoleDone,
		// Token: 0x0400B46B RID: 46187
		[OriginalName("MoraleNoRewardGet")]
		MoraleNoRewardGet,
		// Token: 0x0400B46C RID: 46188
		[OriginalName("FloroNoRanchData")]
		FloroNoRanchData,
		// Token: 0x0400B46D RID: 46189
		[OriginalName("FloroNoRanchTech")]
		FloroNoRanchTech,
		// Token: 0x0400B46E RID: 46190
		[OriginalName("FloroTechUnLock")]
		FloroTechUnLock,
		// Token: 0x0400B46F RID: 46191
		[OriginalName("FloroPreNodeLock")]
		FloroPreNodeLock,
		// Token: 0x0400B470 RID: 46192
		[OriginalName("FloroTechPoint")]
		FloroTechPoint,
		// Token: 0x0400B471 RID: 46193
		[OriginalName("FloroNoFindActivityTask")]
		FloroNoFindActivityTask,
		// Token: 0x0400B472 RID: 46194
		[OriginalName("FloroNoFindTaskCfg")]
		FloroNoFindTaskCfg,
		// Token: 0x0400B473 RID: 46195
		[OriginalName("FloroTaskIsRunning")]
		FloroTaskIsRunning,
		// Token: 0x0400B474 RID: 46196
		[OriginalName("FloroTaskInValidTime")]
		FloroTaskInValidTime,
		// Token: 0x0400B475 RID: 46197
		[OriginalName("FloroRewardDone")]
		FloroRewardDone,
		// Token: 0x0400B476 RID: 46198
		[OriginalName("FloroMilestoneNoFind")]
		FloroMilestoneNoFind,
		// Token: 0x0400B477 RID: 46199
		[OriginalName("FloroDropNoFind")]
		FloroDropNoFind,
		// Token: 0x0400B478 RID: 46200
		[OriginalName("FloroNoReward")]
		FloroNoReward,
		// Token: 0x0400B479 RID: 46201
		[OriginalName("FloroActivityParamErr")]
		FloroActivityParamErr,
		// Token: 0x0400B47A RID: 46202
		[OriginalName("ConditionTimeOut")]
		ConditionTimeOut,
		// Token: 0x0400B47B RID: 46203
		[OriginalName("ConditionModuleErr")]
		ConditionModuleErr,
		// Token: 0x0400B47C RID: 46204
		[OriginalName("ConditionGroupIdErr")]
		ConditionGroupIdErr,
		// Token: 0x0400B47D RID: 46205
		[OriginalName("ConditionRegisterFail")]
		ConditionRegisterFail,
		// Token: 0x0400B47E RID: 46206
		[OriginalName("FloroRanchSetAgain")]
		FloroRanchSetAgain,
		// Token: 0x0400B47F RID: 46207
		[OriginalName("MoonPhaseNoOpen")]
		MoonPhaseNoOpen,
		// Token: 0x0400B480 RID: 46208
		[OriginalName("MoonPhaseNoCount")]
		MoonPhaseNoCount,
		// Token: 0x0400B481 RID: 46209
		[OriginalName("ErrRandomDone")]
		ErrRandomDone,
		// Token: 0x0400B482 RID: 46210
		[OriginalName("PhaseMoonRandomErr")]
		PhaseMoonRandomErr,
		// Token: 0x0400B483 RID: 46211
		[OriginalName("PhaseMoonCfgErr")]
		PhaseMoonCfgErr,
		// Token: 0x0400B484 RID: 46212
		[OriginalName("MoonLabelErr")]
		MoonLabelErr,
		// Token: 0x0400B485 RID: 46213
		[OriginalName("MoonPhaseRewardErr")]
		MoonPhaseRewardErr,
		// Token: 0x0400B486 RID: 46214
		[OriginalName("MoonPhaseRewardDone")]
		MoonPhaseRewardDone,
		// Token: 0x0400B487 RID: 46215
		[OriginalName("PhaseMoonItemErr")]
		PhaseMoonItemErr,
		// Token: 0x0400B488 RID: 46216
		[OriginalName("MoonPhaseBuffFail")]
		MoonPhaseBuffFail,
		// Token: 0x0400B489 RID: 46217
		[OriginalName("CoopRoleMaxLevelErr")]
		CoopRoleMaxLevelErr,
		// Token: 0x0400B48A RID: 46218
		[OriginalName("CoopRoleNoUnLock")]
		CoopRoleNoUnLock,
		// Token: 0x0400B48B RID: 46219
		[OriginalName("CoopRoleSpRewradErr")]
		CoopRoleSpRewradErr,
		// Token: 0x0400B48C RID: 46220
		[OriginalName("CoopRoleRewardErr")]
		CoopRoleRewardErr,
		// Token: 0x0400B48D RID: 46221
		[OriginalName("NoRewardCanGain")]
		NoRewardCanGain,
		// Token: 0x0400B48E RID: 46222
		[OriginalName("CoopRoleDataErr")]
		CoopRoleDataErr,
		// Token: 0x0400B48F RID: 46223
		[OriginalName("CoopIdErr")]
		CoopIdErr,
		// Token: 0x0400B490 RID: 46224
		[OriginalName("MotorcycleMotorIpErr")]
		MotorcycleMotorIpErr,
		// Token: 0x0400B491 RID: 46225
		[OriginalName("MotorcycleRewardEmpty")]
		MotorcycleRewardEmpty,
		// Token: 0x0400B492 RID: 46226
		[OriginalName("RoadBookNotData")]
		RoadBookNotData,
		// Token: 0x0400B493 RID: 46227
		[OriginalName("RoadBookNotInOpen")]
		RoadBookNotInOpen,
		// Token: 0x0400B494 RID: 46228
		[OriginalName("RoadBookTaskCannotReward")]
		RoadBookTaskCannotReward,
		// Token: 0x0400B495 RID: 46229
		[OriginalName("RoadBookRewardHad")]
		RoadBookRewardHad,
		// Token: 0x0400B496 RID: 46230
		[OriginalName("RoadBookOverMaxLevel")]
		RoadBookOverMaxLevel,
		// Token: 0x0400B497 RID: 46231
		[OriginalName("RoadBookCfgErr")]
		RoadBookCfgErr,
		// Token: 0x0400B498 RID: 46232
		[OriginalName("RoadBookTaskLock")]
		RoadBookTaskLock,
		// Token: 0x0400B499 RID: 46233
		[OriginalName("RoadBookChallengeScoreErr")]
		RoadBookChallengeScoreErr,
		// Token: 0x0400B49A RID: 46234
		[OriginalName("RoadBookDuplicateReward")]
		RoadBookDuplicateReward,
		// Token: 0x0400B49B RID: 46235
		[OriginalName("RoadBookNoRewardGet")]
		RoadBookNoRewardGet,
		// Token: 0x0400B49C RID: 46236
		[OriginalName("GuessJokerLevelErr")]
		GuessJokerLevelErr,
		// Token: 0x0400B49D RID: 46237
		[OriginalName("GuessJokerNotInScene")]
		GuessJokerNotInScene,
		// Token: 0x0400B49E RID: 46238
		[OriginalName("GuessJokerNotGameObj")]
		GuessJokerNotGameObj,
		// Token: 0x0400B49F RID: 46239
		[OriginalName("GuessJokerPlayCardErr")]
		GuessJokerPlayCardErr,
		// Token: 0x0400B4A0 RID: 46240
		[OriginalName("GuessJokerActionPhaseErr")]
		GuessJokerActionPhaseErr,
		// Token: 0x0400B4A1 RID: 46241
		[OriginalName("GuessJokerDeckErr")]
		GuessJokerDeckErr,
		// Token: 0x0400B4A2 RID: 46242
		[OriginalName("GuessJokerNoHandCard")]
		GuessJokerNoHandCard,
		// Token: 0x0400B4A3 RID: 46243
		[OriginalName("GuessJokerBanCard")]
		GuessJokerBanCard,
		// Token: 0x0400B4A4 RID: 46244
		[OriginalName("GuessJokerOnlyPair")]
		GuessJokerOnlyPair,
		// Token: 0x0400B4A5 RID: 46245
		[OriginalName("GuessJokerPairAll")]
		GuessJokerPairAll,
		// Token: 0x0400B4A6 RID: 46246
		[OriginalName("GuessJokerCardRefuse")]
		GuessJokerCardRefuse,
		// Token: 0x0400B4A7 RID: 46247
		[OriginalName("GuessJokerDrawCardErr")]
		GuessJokerDrawCardErr,
		// Token: 0x0400B4A8 RID: 46248
		[OriginalName("JokerSkillTriggerFail")]
		JokerSkillTriggerFail,
		// Token: 0x0400B4A9 RID: 46249
		[OriginalName("JokerSkillNoConfig")]
		JokerSkillNoConfig,
		// Token: 0x0400B4AA RID: 46250
		[OriginalName("JokerSkillOwnerErr")]
		JokerSkillOwnerErr,
		// Token: 0x0400B4AB RID: 46251
		[OriginalName("GuessJokerPlayCardOver")]
		GuessJokerPlayCardOver,
		// Token: 0x0400B4AC RID: 46252
		[OriginalName("GuessJokerPlayCardAgain")]
		GuessJokerPlayCardAgain,
		// Token: 0x0400B4AD RID: 46253
		[OriginalName("JokerGuessLevelLock")]
		JokerGuessLevelLock,
		// Token: 0x0400B4AE RID: 46254
		[OriginalName("JokerGuessPreLevelLock")]
		JokerGuessPreLevelLock,
		// Token: 0x0400B4AF RID: 46255
		[OriginalName("GuessJokerInitErr")]
		GuessJokerInitErr,
		// Token: 0x0400B4B0 RID: 46256
		[OriginalName("NoDrinkRequireListConfig")]
		NoDrinkRequireListConfig,
		// Token: 0x0400B4B1 RID: 46257
		[OriginalName("DrinkBaseCountError")]
		DrinkBaseCountError,
		// Token: 0x0400B4B2 RID: 46258
		[OriginalName("DrinkBaseNoConfig")]
		DrinkBaseNoConfig,
		// Token: 0x0400B4B3 RID: 46259
		[OriginalName("DrinkBatchingCountErr")]
		DrinkBatchingCountErr,
		// Token: 0x0400B4B4 RID: 46260
		[OriginalName("DrinkBatchingConfigErr")]
		DrinkBatchingConfigErr,
		// Token: 0x0400B4B5 RID: 46261
		[OriginalName("DrinkOrnaNoConfig")]
		DrinkOrnaNoConfig,
		// Token: 0x0400B4B6 RID: 46262
		[OriginalName("DrinkRoleLikeNoConfig")]
		DrinkRoleLikeNoConfig,
		// Token: 0x0400B4B7 RID: 46263
		[OriginalName("DrinkLikePointErr")]
		DrinkLikePointErr,
		// Token: 0x0400B4B8 RID: 46264
		[OriginalName("GuessJokerScriptPlayErr")]
		GuessJokerScriptPlayErr,
		// Token: 0x0400B4B9 RID: 46265
		[OriginalName("GuessJokerScriptDrawErr")]
		GuessJokerScriptDrawErr,
		// Token: 0x0400B4BA RID: 46266
		[OriginalName("GuessJokerNoPlayerWait")]
		GuessJokerNoPlayerWait,
		// Token: 0x0400B4BB RID: 46267
		[OriginalName("GuessJokerSkillUseOver")]
		GuessJokerSkillUseOver,
		// Token: 0x0400B4BC RID: 46268
		[OriginalName("DrinkBatchingRepeate")]
		DrinkBatchingRepeate,
		// Token: 0x0400B4BD RID: 46269
		[OriginalName("SpringFestivalNoReward")]
		SpringFestivalNoReward,
		// Token: 0x0400B4BE RID: 46270
		[OriginalName("SpringFestivalDropNoFind")]
		SpringFestivalDropNoFind,
		// Token: 0x0400B4BF RID: 46271
		[OriginalName("SpringFestivalTaskRunning")]
		SpringFestivalTaskRunning,
		// Token: 0x0400B4C0 RID: 46272
		[OriginalName("SpringFestivalHadReward")]
		SpringFestivalHadReward,
		// Token: 0x0400B4C1 RID: 46273
		[OriginalName("SpringFestivalActivityIdErr")]
		SpringFestivalActivityIdErr,
		// Token: 0x0400B4C2 RID: 46274
		[OriginalName("SpringFestivalTaskFindErr")]
		SpringFestivalTaskFindErr,
		// Token: 0x0400B4C3 RID: 46275
		[OriginalName("SpringFestivalNoActivityCfg")]
		SpringFestivalNoActivityCfg,
		// Token: 0x0400B4C4 RID: 46276
		[OriginalName("SpringFestivalParamCountErr")]
		SpringFestivalParamCountErr,
		// Token: 0x0400B4C5 RID: 46277
		[OriginalName("SpringFestivalParamAgainErr")]
		SpringFestivalParamAgainErr,
		// Token: 0x0400B4C6 RID: 46278
		[OriginalName("PayShopGoodsIdRepeatErr")]
		PayShopGoodsIdRepeatErr,
		// Token: 0x0400B4C7 RID: 46279
		[OriginalName("PayShopBindActivityErr")]
		PayShopBindActivityErr,
		// Token: 0x0400B4C8 RID: 46280
		[OriginalName("PayShopActivityFromErr")]
		PayShopActivityFromErr,
		// Token: 0x0400B4C9 RID: 46281
		[OriginalName("PayShopFromErr")]
		PayShopFromErr,
		// Token: 0x0400B4CA RID: 46282
		[OriginalName("ErrPayShopGoodsTypeCountOverFlow")]
		ErrPayShopGoodsTypeCountOverFlow,
		// Token: 0x0400B4CB RID: 46283
		[OriginalName("ErrPayShopTotalCountOverFlow")]
		ErrPayShopTotalCountOverFlow,
		// Token: 0x0400B4CC RID: 46284
		[OriginalName("ErrRegressDevelopTask")]
		ErrRegressDevelopTask,
		// Token: 0x0400B4CD RID: 46285
		[OriginalName("ErrRegressVersion")]
		ErrRegressVersion,
		// Token: 0x0400B4CE RID: 46286
		[OriginalName("DrinksLevelLock")]
		DrinksLevelLock,
		// Token: 0x0400B4CF RID: 46287
		[OriginalName("DrinksRoleInviteErr")]
		DrinksRoleInviteErr,
		// Token: 0x0400B4D0 RID: 46288
		[OriginalName("DrinksNoRoleData")]
		DrinksNoRoleData,
		// Token: 0x0400B4D1 RID: 46289
		[OriginalName("GuessJokerTraceOver")]
		GuessJokerTraceOver,
		// Token: 0x0400B4D2 RID: 46290
		[OriginalName("GuessJokerDataErr")]
		GuessJokerDataErr,
		// Token: 0x0400B4D3 RID: 46291
		[OriginalName("GuessJokerTaskRunning")]
		GuessJokerTaskRunning,
		// Token: 0x0400B4D4 RID: 46292
		[OriginalName("GuessJokerTaskDone")]
		GuessJokerTaskDone,
		// Token: 0x0400B4D5 RID: 46293
		[OriginalName("DrinksRewardTaskRunning")]
		DrinksRewardTaskRunning,
		// Token: 0x0400B4D6 RID: 46294
		[OriginalName("DrinksRewardTaskDone")]
		DrinksRewardTaskDone,
		// Token: 0x0400B4D7 RID: 46295
		[OriginalName("CoopReqLenthOver")]
		CoopReqLenthOver,
		// Token: 0x0400B4D8 RID: 46296
		[OriginalName("CoopRewardIdErr")]
		CoopRewardIdErr,
		// Token: 0x0400B4D9 RID: 46297
		[OriginalName("CoopRewardConfigNotFind")]
		CoopRewardConfigNotFind,
		// Token: 0x0400B4DA RID: 46298
		[OriginalName("CoopRewardDiff")]
		CoopRewardDiff,
		// Token: 0x0400B4DB RID: 46299
		[OriginalName("CoopActivityDataErr")]
		CoopActivityDataErr,
		// Token: 0x0400B4DC RID: 46300
		[OriginalName("CoopRewardDone")]
		CoopRewardDone,
		// Token: 0x0400B4DD RID: 46301
		[OriginalName("CoopRewardNoFinish")]
		CoopRewardNoFinish,
		// Token: 0x0400B4DE RID: 46302
		[OriginalName("CoopItemDropErr")]
		CoopItemDropErr,
		// Token: 0x0400B4DF RID: 46303
		[OriginalName("CoopItemDropErr2")]
		CoopItemDropErr2,
		// Token: 0x0400B4E0 RID: 46304
		[OriginalName("PinballParamLimitOver")]
		PinballParamLimitOver,
		// Token: 0x0400B4E1 RID: 46305
		[OriginalName("PinballTaskConfigLoss")]
		PinballTaskConfigLoss,
		// Token: 0x0400B4E2 RID: 46306
		[OriginalName("PinballActivityErr")]
		PinballActivityErr,
		// Token: 0x0400B4E3 RID: 46307
		[OriginalName("PinballActivityHadReward")]
		PinballActivityHadReward,
		// Token: 0x0400B4E4 RID: 46308
		[OriginalName("PinballActivityTaskRunning")]
		PinballActivityTaskRunning,
		// Token: 0x0400B4E5 RID: 46309
		[OriginalName("PinballActivityTaskDropNoFind")]
		PinballActivityTaskDropNoFind,
		// Token: 0x0400B4E6 RID: 46310
		[OriginalName("PinballActivityTaskParamAgainErr")]
		PinballActivityTaskParamAgainErr,
		// Token: 0x0400B4E7 RID: 46311
		[OriginalName("PinballActivityTaskNoReward")]
		PinballActivityTaskNoReward,
		// Token: 0x0400B4E8 RID: 46312
		[OriginalName("PinballRoleAddLevelErr")]
		PinballRoleAddLevelErr,
		// Token: 0x0400B4E9 RID: 46313
		[OriginalName("PinballRoleConfigLoss")]
		PinballRoleConfigLoss,
		// Token: 0x0400B4EA RID: 46314
		[OriginalName("PinballRoleDataLoss")]
		PinballRoleDataLoss,
		// Token: 0x0400B4EB RID: 46315
		[OriginalName("PinballRoleDataMaxLvLoss")]
		PinballRoleDataMaxLvLoss,
		// Token: 0x0400B4EC RID: 46316
		[OriginalName("PinballRoleMaxLvErr")]
		PinballRoleMaxLvErr,
		// Token: 0x0400B4ED RID: 46317
		[OriginalName("PinballActivityConfigLoss")]
		PinballActivityConfigLoss,
		// Token: 0x0400B4EE RID: 46318
		[OriginalName("PinballRoleExpItemLack")]
		PinballRoleExpItemLack,
		// Token: 0x0400B4EF RID: 46319
		[OriginalName("PinballWeaponIsTrail")]
		PinballWeaponIsTrail,
		// Token: 0x0400B4F0 RID: 46320
		[OriginalName("PinballWeaponNoExist")]
		PinballWeaponNoExist,
		// Token: 0x0400B4F1 RID: 46321
		[OriginalName("PinballWeaponConfigNoExist")]
		PinballWeaponConfigNoExist,
		// Token: 0x0400B4F2 RID: 46322
		[OriginalName("PinballRoleNoExist")]
		PinballRoleNoExist,
		// Token: 0x0400B4F3 RID: 46323
		[OriginalName("PinballRoleConfigNoExist")]
		PinballRoleConfigNoExist,
		// Token: 0x0400B4F4 RID: 46324
		[OriginalName("PinballWeaponRoleMismatch")]
		PinballWeaponRoleMismatch,
		// Token: 0x0400B4F5 RID: 46325
		[OriginalName("PinballPersonWeaponChangeErr")]
		PinballPersonWeaponChangeErr,
		// Token: 0x0400B4F6 RID: 46326
		[OriginalName("PinballWearRepeat")]
		PinballWearRepeat,
		// Token: 0x0400B4F7 RID: 46327
		[OriginalName("PinballWeaponOverLimit")]
		PinballWeaponOverLimit,
		// Token: 0x0400B4F8 RID: 46328
		[OriginalName("PinballWeaponRepeat")]
		PinballWeaponRepeat,
		// Token: 0x0400B4F9 RID: 46329
		[OriginalName("PinballWeaponLock")]
		PinballWeaponLock,
		// Token: 0x0400B4FA RID: 46330
		[OriginalName("PinballWeaponIsEquip")]
		PinballWeaponIsEquip,
		// Token: 0x0400B4FB RID: 46331
		[OriginalName("PinballWeaponNoDel")]
		PinballWeaponNoDel,
		// Token: 0x0400B4FC RID: 46332
		[OriginalName("ActivityRewardParamOver")]
		ActivityRewardParamOver,
		// Token: 0x0400B4FD RID: 46333
		[OriginalName("ActivityNotSame")]
		ActivityNotSame,
		// Token: 0x0400B4FE RID: 46334
		[OriginalName("ActivityRewardDropErr")]
		ActivityRewardDropErr,
		// Token: 0x0400B4FF RID: 46335
		[OriginalName("ActivityNoRewardCanGet")]
		ActivityNoRewardCanGet,
		// Token: 0x0400B500 RID: 46336
		[OriginalName("ActivityTaskTimeErr")]
		ActivityTaskTimeErr,
		// Token: 0x0400B501 RID: 46337
		[OriginalName("ActivityTaskRewardRepeat")]
		ActivityTaskRewardRepeat,
		// Token: 0x0400B502 RID: 46338
		[OriginalName("ActivityDataNotFind")]
		ActivityDataNotFind,
		// Token: 0x0400B503 RID: 46339
		[OriginalName("PinballWeaponInitErr")]
		PinballWeaponInitErr,
		// Token: 0x0400B504 RID: 46340
		[OriginalName("PinballNoFriend")]
		PinballNoFriend,
		// Token: 0x0400B505 RID: 46341
		[OriginalName("PinballTowerRankCd")]
		PinballTowerRankCd,
		// Token: 0x0400B506 RID: 46342
		[OriginalName("PinballRankDataEmpty")]
		PinballRankDataEmpty,
		// Token: 0x0400B507 RID: 46343
		[OriginalName("PinballLevelLock")]
		PinballLevelLock,
		// Token: 0x0400B508 RID: 46344
		[OriginalName("PinballDailyInstErr")]
		PinballDailyInstErr,
		// Token: 0x0400B509 RID: 46345
		[OriginalName("PinballRoleNotOpen")]
		PinballRoleNotOpen,
		// Token: 0x0400B50A RID: 46346
		[OriginalName("PinballDailyNotOpen")]
		PinballDailyNotOpen,
		// Token: 0x0400B50B RID: 46347
		[OriginalName("PinballWeaponPersonMismatch")]
		PinballWeaponPersonMismatch,
		// Token: 0x0400B50C RID: 46348
		[OriginalName("NoRoleVoiceDataSet")]
		NoRoleVoiceDataSet,
		// Token: 0x0400B50D RID: 46349
		[OriginalName("RoleVoiceSettingParamOver")]
		RoleVoiceSettingParamOver,
		// Token: 0x0400B50E RID: 46350
		[OriginalName("RoleVoiceParamRepeat")]
		RoleVoiceParamRepeat,
		// Token: 0x0400B50F RID: 46351
		[OriginalName("PlayerUsingSkill")]
		PlayerUsingSkill,
		// Token: 0x0400B510 RID: 46352
		[OriginalName("PlayerClimbing")]
		PlayerClimbing,
		// Token: 0x0400B511 RID: 46353
		[OriginalName("PlayerInWater")]
		PlayerInWater,
		// Token: 0x0400B512 RID: 46354
		[OriginalName("PlayerInAir")]
		PlayerInAir,
		// Token: 0x0400B513 RID: 46355
		[OriginalName("OnlineMotorLevelLock")]
		OnlineMotorLevelLock,
		// Token: 0x0400B514 RID: 46356
		[OriginalName("OnlineMotorMemberErr")]
		OnlineMotorMemberErr,
		// Token: 0x0400B515 RID: 46357
		[OriginalName("OnlineMotorMemberActivityClose")]
		OnlineMotorMemberActivityClose,
		// Token: 0x0400B516 RID: 46358
		[OriginalName("RealmBetweenOverMaxLevel")]
		RealmBetweenOverMaxLevel,
		// Token: 0x0400B517 RID: 46359
		[OriginalName("ActivityTaskLock")]
		ActivityTaskLock,
		// Token: 0x0400B518 RID: 46360
		[OriginalName("ErrRecallItemBagItemTypeNotSupport")]
		ErrRecallItemBagItemTypeNotSupport,
		// Token: 0x0400B519 RID: 46361
		[OriginalName("ErrRecallItemBagFull")]
		ErrRecallItemBagFull,
		// Token: 0x0400B51A RID: 46362
		[OriginalName("ActivityPlayingCanNotDissolve")]
		ActivityPlayingCanNotDissolve,
		// Token: 0x0400B51B RID: 46363
		[OriginalName("ErrRecallActionNotSupport")]
		ErrRecallActionNotSupport,
		// Token: 0x0400B51C RID: 46364
		[OriginalName("ErrAdventureSilentCtxNull")]
		ErrAdventureSilentCtxNull,
		// Token: 0x0400B51D RID: 46365
		[OriginalName("ErrAdventureSilentId")]
		ErrAdventureSilentId,
		// Token: 0x0400B51E RID: 46366
		[OriginalName("RoverRogueTalentAlreadyUnlock")]
		RoverRogueTalentAlreadyUnlock,
		// Token: 0x0400B51F RID: 46367
		[OriginalName("RoverRoguePreTalentNotUnlock")]
		RoverRoguePreTalentNotUnlock,
		// Token: 0x0400B520 RID: 46368
		[OriginalName("RoverRogueTalentConditionNotFinish")]
		RoverRogueTalentConditionNotFinish,
		// Token: 0x0400B521 RID: 46369
		[OriginalName("ErrMailFavoriteCannotDelete")]
		ErrMailFavoriteCannotDelete,
		// Token: 0x0400B522 RID: 46370
		[OriginalName("ErrMailFavoriteNeedRead")]
		ErrMailFavoriteNeedRead,
		// Token: 0x0400B523 RID: 46371
		[OriginalName("ErrMailFavoriteNeedTake")]
		ErrMailFavoriteNeedTake,
		// Token: 0x0400B524 RID: 46372
		[OriginalName("ErrMailFavoriteFull")]
		ErrMailFavoriteFull,
		// Token: 0x0400B525 RID: 46373
		[OriginalName("ErrPhantomItemUse")]
		ErrPhantomItemUse,
		// Token: 0x0400B526 RID: 46374
		[OriginalName("ErrRoleTrailItemUse")]
		ErrRoleTrailItemUse,
		// Token: 0x0400B527 RID: 46375
		[OriginalName("ErrInFlowItemUse")]
		ErrInFlowItemUse,
		// Token: 0x0400B528 RID: 46376
		[OriginalName("ErrInVehicleItemUse")]
		ErrInVehicleItemUse,
		// Token: 0x0400B529 RID: 46377
		[OriginalName("ErrZitherNoMainRoleInFormation")]
		ErrZitherNoMainRoleInFormation,
		// Token: 0x0400B52A RID: 46378
		[OriginalName("ErrTrialFollowShooterItemUse")]
		ErrTrialFollowShooterItemUse,
		// Token: 0x0400B52B RID: 46379
		[OriginalName("ErrMainRoleVoiceRoleId")]
		ErrMainRoleVoiceRoleId,
		// Token: 0x0400B52C RID: 46380
		[OriginalName("ErrTrackMoonNotInRecall")]
		ErrTrackMoonNotInRecall,
		// Token: 0x0400B52D RID: 46381
		[OriginalName("MatchThreeRoleLock")]
		MatchThreeRoleLock,
		// Token: 0x0400B52E RID: 46382
		[OriginalName("ErrMatchThreeScoreInvalid")]
		ErrMatchThreeScoreInvalid,
		// Token: 0x0400B52F RID: 46383
		[OriginalName("ErrMatchThreeHourGlassInvalid")]
		ErrMatchThreeHourGlassInvalid,
		// Token: 0x0400B530 RID: 46384
		[OriginalName("ErrMatchThreeBottleInvalid")]
		ErrMatchThreeBottleInvalid,
		// Token: 0x0400B531 RID: 46385
		[OriginalName("ErrMatchThreeRecordTypeMismatch")]
		ErrMatchThreeRecordTypeMismatch,
		// Token: 0x0400B532 RID: 46386
		[OriginalName("CameraModeNotOpen")]
		CameraModeNotOpen,
		// Token: 0x0400B533 RID: 46387
		[OriginalName("ErrItemUseBanned")]
		ErrItemUseBanned,
		// Token: 0x0400B534 RID: 46388
		[OriginalName("ErrItemUseMainRoleDead")]
		ErrItemUseMainRoleDead,
		// Token: 0x0400B535 RID: 46389
		[OriginalName("ErrWaitingOtherJoinBanUse")]
		ErrWaitingOtherJoinBanUse,
		// Token: 0x0400B536 RID: 46390
		[OriginalName("ErrPhantomSelfPortrait")]
		ErrPhantomSelfPortrait,
		// Token: 0x0400B537 RID: 46391
		[OriginalName("ErrRoleTrailSelfPortrait")]
		ErrRoleTrailSelfPortrait,
		// Token: 0x0400B538 RID: 46392
		[OriginalName("ErrPlayerStateSelfPortrait")]
		ErrPlayerStateSelfPortrait,
		// Token: 0x0400B539 RID: 46393
		[OriginalName("ErrMainRoleDeadSelfPortrait")]
		ErrMainRoleDeadSelfPortrait,
		// Token: 0x0400B53A RID: 46394
		[OriginalName("ErrInFlowSelfPortrait")]
		ErrInFlowSelfPortrait,
		// Token: 0x0400B53B RID: 46395
		[OriginalName("ErrInVehicleSelfPortrait")]
		ErrInVehicleSelfPortrait,
		// Token: 0x0400B53C RID: 46396
		[OriginalName("ErrMainRoleActiveSelfPortrait")]
		ErrMainRoleActiveSelfPortrait,
		// Token: 0x0400B53D RID: 46397
		[OriginalName("ErrZitherItemUse")]
		ErrZitherItemUse,
		// Token: 0x0400B53E RID: 46398
		[OriginalName("InTeleportItemUse")]
		InTeleportItemUse,
		// Token: 0x0400B53F RID: 46399
		[OriginalName("IsMatchingItemUse")]
		IsMatchingItemUse,
		// Token: 0x0400B540 RID: 46400
		[OriginalName("InTeleportSelfPortrait")]
		InTeleportSelfPortrait,
		// Token: 0x0400B541 RID: 46401
		[OriginalName("IsMatchingSelfPortrait")]
		IsMatchingSelfPortrait,
		// Token: 0x0400B542 RID: 46402
		[OriginalName("ErrRecallItemUseFail")]
		ErrRecallItemUseFail = 1900460,
		// Token: 0x0400B543 RID: 46403
		[OriginalName("ErrRecallItemUseTypeNotSupport")]
		ErrRecallItemUseTypeNotSupport,
		// Token: 0x0400B544 RID: 46404
		[OriginalName("ErrRecallItemTypeNotSupport")]
		ErrRecallItemTypeNotSupport,
		// Token: 0x0400B545 RID: 46405
		[OriginalName("ErrRecallItemCountInvalid")]
		ErrRecallItemCountInvalid,
		// Token: 0x0400B546 RID: 46406
		[OriginalName("ErrRecallItemCanNotUse")]
		ErrRecallItemCanNotUse,
		// Token: 0x0400B547 RID: 46407
		[OriginalName("ErrWaitingOtherJoinSelfPortrait")]
		ErrWaitingOtherJoinSelfPortrait = 1900467,
		// Token: 0x0400B548 RID: 46408
		[OriginalName("ErrDoCommonRewardConfigError")]
		ErrDoCommonRewardConfigError = 2000000,
		// Token: 0x0400B549 RID: 46409
		[OriginalName("InstPlayNotSettle")]
		InstPlayNotSettle,
		// Token: 0x0400B54A RID: 46410
		[OriginalName("InstPlayNotFinishExecute")]
		InstPlayNotFinishExecute,
		// Token: 0x0400B54B RID: 46411
		[OriginalName("ErrResetItemEntityNotContain")]
		ErrResetItemEntityNotContain,
		// Token: 0x0400B54C RID: 46412
		[OriginalName("InstPlayExchangeRewardNotExist")]
		InstPlayExchangeRewardNotExist,
		// Token: 0x0400B54D RID: 46413
		[OriginalName("MapConfigNull")]
		MapConfigNull,
		// Token: 0x0400B54E RID: 46414
		[OriginalName("MapConfigError")]
		MapConfigError,
		// Token: 0x0400B54F RID: 46415
		[OriginalName("InstPlayComponentNotExist")]
		InstPlayComponentNotExist,
		// Token: 0x0400B550 RID: 46416
		[OriginalName("InstTeleportResetPlayerDead")]
		InstTeleportResetPlayerDead,
		// Token: 0x0400B551 RID: 46417
		[OriginalName("DrownEndTeleportInBigWorld")]
		DrownEndTeleportInBigWorld,
		// Token: 0x0400B552 RID: 46418
		[OriginalName("ErrFightTrialRoleRoldIdsError")]
		ErrFightTrialRoleRoldIdsError,
		// Token: 0x0400B553 RID: 46419
		[OriginalName("ErrFightTrialRoleFromationError")]
		ErrFightTrialRoleFromationError,
		// Token: 0x0400B554 RID: 46420
		[OriginalName("ErrInstSaveFail")]
		ErrInstSaveFail,
		// Token: 0x0400B555 RID: 46421
		[OriginalName("ErrActiveFoundationControlPlayerError")]
		ErrActiveFoundationControlPlayerError,
		// Token: 0x0400B556 RID: 46422
		[OriginalName("ErrActiveFoundationOccupation")]
		ErrActiveFoundationOccupation,
		// Token: 0x0400B557 RID: 46423
		[OriginalName("ErrSingleInstanceCanNotOnline")]
		ErrSingleInstanceCanNotOnline,
		// Token: 0x0400B558 RID: 46424
		[OriginalName("ErrInstanceRechallengeLimit")]
		ErrInstanceRechallengeLimit,
		// Token: 0x0400B559 RID: 46425
		[OriginalName("ErrTargetSame")]
		ErrTargetSame,
		// Token: 0x0400B55A RID: 46426
		[OriginalName("ErrAttachTargetType")]
		ErrAttachTargetType,
		// Token: 0x0400B55B RID: 46427
		[OriginalName("ErrAttachInfoNull")]
		ErrAttachInfoNull,
		// Token: 0x0400B55C RID: 46428
		[OriginalName("ErrLevelPlayChallengeFail")]
		ErrLevelPlayChallengeFail,
		// Token: 0x0400B55D RID: 46429
		[OriginalName("ErrGMTip")]
		ErrGmtip,
		// Token: 0x0400B55E RID: 46430
		[OriginalName("ErrPosSenderEntityNoExist")]
		ErrPosSenderEntityNoExist,
		// Token: 0x0400B55F RID: 46431
		[OriginalName("ErrPosSenderComponentNoExist")]
		ErrPosSenderComponentNoExist,
		// Token: 0x0400B560 RID: 46432
		[OriginalName("ErrPosSenderParamError")]
		ErrPosSenderParamError,
		// Token: 0x0400B561 RID: 46433
		[OriginalName("ErrPosSenderRemoveSenderNotSame")]
		ErrPosSenderRemoveSenderNotSame,
		// Token: 0x0400B562 RID: 46434
		[OriginalName("ErrConnectorEntityNoExist")]
		ErrConnectorEntityNoExist,
		// Token: 0x0400B563 RID: 46435
		[OriginalName("ErrConnectorCompNoExist")]
		ErrConnectorCompNoExist,
		// Token: 0x0400B564 RID: 46436
		[OriginalName("ErrConnectorPreIdError")]
		ErrConnectorPreIdError,
		// Token: 0x0400B565 RID: 46437
		[OriginalName("ErrConnectorCompleteState")]
		ErrConnectorCompleteState,
		// Token: 0x0400B566 RID: 46438
		[OriginalName("ErrConnectorActiveStateError")]
		ErrConnectorActiveStateError,
		// Token: 0x0400B567 RID: 46439
		[OriginalName("ErrConnectorMatchErro")]
		ErrConnectorMatchErro,
		// Token: 0x0400B568 RID: 46440
		[OriginalName("ErrActiveControlOccupation")]
		ErrActiveControlOccupation,
		// Token: 0x0400B569 RID: 46441
		[OriginalName("ErrPortalCreatorActive")]
		ErrPortalCreatorActive,
		// Token: 0x0400B56A RID: 46442
		[OriginalName("ErrComponentNull")]
		ErrComponentNull,
		// Token: 0x0400B56B RID: 46443
		[OriginalName("ErrPortalCreatorConfigError")]
		ErrPortalCreatorConfigError,
		// Token: 0x0400B56C RID: 46444
		[OriginalName("ErrPortalCreatorCreateFail")]
		ErrPortalCreatorCreateFail,
		// Token: 0x0400B56D RID: 46445
		[OriginalName("ErrTrialRoleEnterInst")]
		ErrTrialRoleEnterInst,
		// Token: 0x0400B56E RID: 46446
		[OriginalName("ErrNpcInVehicle")]
		ErrNpcInVehicle,
		// Token: 0x0400B56F RID: 46447
		[OriginalName("ErrSceneItemBBNotChange")]
		ErrSceneItemBbnotChange,
		// Token: 0x0400B570 RID: 46448
		[OriginalName("ErrInitMatchNotSuccess")]
		ErrInitMatchNotSuccess,
		// Token: 0x0400B571 RID: 46449
		[OriginalName("ErrFightFormationSameRoleError")]
		ErrFightFormationSameRoleError,
		// Token: 0x0400B572 RID: 46450
		[OriginalName("ErrFightMainRoleConflict")]
		ErrFightMainRoleConflict,
		// Token: 0x0400B573 RID: 46451
		[OriginalName("ErrVehicleItemConfigError")]
		ErrVehicleItemConfigError,
		// Token: 0x0400B574 RID: 46452
		[OriginalName("ErrVehicleCreateError")]
		ErrVehicleCreateError,
		// Token: 0x0400B575 RID: 46453
		[OriginalName("ErrVehicleEntityTypeError")]
		ErrVehicleEntityTypeError,
		// Token: 0x0400B576 RID: 46454
		[OriginalName("ErrInstanceActivityExpire")]
		ErrInstanceActivityExpire,
		// Token: 0x0400B577 RID: 46455
		[OriginalName("ErrSlashAndTowerLevelUnlock")]
		ErrSlashAndTowerLevelUnlock,
		// Token: 0x0400B578 RID: 46456
		[OriginalName("ErrInstLevelUnlock")]
		ErrInstLevelUnlock,
		// Token: 0x0400B579 RID: 46457
		[OriginalName("ErrEnterInstConfigError")]
		ErrEnterInstConfigError,
		// Token: 0x0400B57A RID: 46458
		[OriginalName("ErrMoveWithSplineConfigError")]
		ErrMoveWithSplineConfigError,
		// Token: 0x0400B57B RID: 46459
		[OriginalName("ErrMoveWithSplineIdError")]
		ErrMoveWithSplineIdError,
		// Token: 0x0400B57C RID: 46460
		[OriginalName("ErrMoveWithSplineStop")]
		ErrMoveWithSplineStop,
		// Token: 0x0400B57D RID: 46461
		[OriginalName("ErrMoveWithSplineEntityConfigError")]
		ErrMoveWithSplineEntityConfigError,
		// Token: 0x0400B57E RID: 46462
		[OriginalName("ErrMoveWithSplineControlPlayerError")]
		ErrMoveWithSplineControlPlayerError,
		// Token: 0x0400B57F RID: 46463
		[OriginalName("ErrLeaveSceneStarted")]
		ErrLeaveSceneStarted,
		// Token: 0x0400B580 RID: 46464
		[OriginalName("ErrInstTeleportInstLimit")]
		ErrInstTeleportInstLimit,
		// Token: 0x0400B581 RID: 46465
		[OriginalName("ErrGetOnVehicleNotInAoiSight")]
		ErrGetOnVehicleNotInAoiSight,
		// Token: 0x0400B582 RID: 46466
		[OriginalName("ErrHoldHandCharacterNotCurrent")]
		ErrHoldHandCharacterNotCurrent,
		// Token: 0x0400B583 RID: 46467
		[OriginalName("ErrEnterInstPreInstNotComplete")]
		ErrEnterInstPreInstNotComplete,
		// Token: 0x0400B584 RID: 46468
		[OriginalName("ErrSetSystemVarError")]
		ErrSetSystemVarError,
		// Token: 0x0400B585 RID: 46469
		[OriginalName("ErrSetVarPermission")]
		ErrSetVarPermission,
		// Token: 0x0400B586 RID: 46470
		[OriginalName("ErrSetVarCtxError")]
		ErrSetVarCtxError,
		// Token: 0x0400B587 RID: 46471
		[OriginalName("ErrSetVarGameCtxSceneError")]
		ErrSetVarGameCtxSceneError,
		// Token: 0x0400B588 RID: 46472
		[OriginalName("ErrSetVarNotPublic")]
		ErrSetVarNotPublic,
		// Token: 0x0400B589 RID: 46473
		[OriginalName("ErrSetVarComponent")]
		ErrSetVarComponent,
		// Token: 0x0400B58A RID: 46474
		[OriginalName("ErrSetVarTargetNull")]
		ErrSetVarTargetNull,
		// Token: 0x0400B58B RID: 46475
		[OriginalName("ErrVehicleNotMotor")]
		ErrVehicleNotMotor,
		// Token: 0x0400B58C RID: 46476
		[OriginalName("ErrVehicleFormationError")]
		ErrVehicleFormationError,
		// Token: 0x0400B58D RID: 46477
		[OriginalName("ErrShareRideConflict")]
		ErrShareRideConflict,
		// Token: 0x0400B58E RID: 46478
		[OriginalName("ErrShareRideNotExist")]
		ErrShareRideNotExist,
		// Token: 0x0400B58F RID: 46479
		[OriginalName("ErrNotInShareRide")]
		ErrNotInShareRide,
		// Token: 0x0400B590 RID: 46480
		[OriginalName("ErrNotInVehicle")]
		ErrNotInVehicle,
		// Token: 0x0400B591 RID: 46481
		[OriginalName("ErrSceneRoadGraphNotExist")]
		ErrSceneRoadGraphNotExist,
		// Token: 0x0400B592 RID: 46482
		[OriginalName("ErrVehicleFlowRewardMax")]
		ErrVehicleFlowRewardMax,
		// Token: 0x0400B593 RID: 46483
		[OriginalName("ErrGetOnVehicleFailInFlow")]
		ErrGetOnVehicleFailInFlow,
		// Token: 0x0400B594 RID: 46484
		[OriginalName("ErrGetOnPlayerVechielGravityDifferent")]
		ErrGetOnPlayerVechielGravityDifferent,
		// Token: 0x0400B595 RID: 46485
		[OriginalName("ErrChangeFightState")]
		ErrChangeFightState = 2100000,
		// Token: 0x0400B596 RID: 46486
		[OriginalName("ErrAddFragileFail")]
		ErrAddFragileFail,
		// Token: 0x0400B597 RID: 46487
		[OriginalName("ErrStoreEnergyClose")]
		ErrStoreEnergyClose,
		// Token: 0x0400B598 RID: 46488
		[OriginalName("ErrAttrOverMax")]
		ErrAttrOverMax,
		// Token: 0x0400B599 RID: 46489
		[OriginalName("ErrBattleVersion")]
		ErrBattleVersion,
		// Token: 0x0400B59A RID: 46490
		[OriginalName("ErrGmkillEntityNotValid")]
		ErrGmkillEntityNotValid = 2200000,
		// Token: 0x0400B59B RID: 46491
		[OriginalName("ErrSplineConfigNotExist")]
		ErrSplineConfigNotExist,
		// Token: 0x0400B59C RID: 46492
		[OriginalName("BossRushActivityNotOpen")]
		BossRushActivityNotOpen,
		// Token: 0x0400B59D RID: 46493
		[OriginalName("BossRushActivityScoreRewardNotExist")]
		BossRushActivityScoreRewardNotExist,
		// Token: 0x0400B59E RID: 46494
		[OriginalName("BossRushActivityLevelRewardNotExist")]
		BossRushActivityLevelRewardNotExist,
		// Token: 0x0400B59F RID: 46495
		[OriginalName("BossRushActivityScoreNotEnough")]
		BossRushActivityScoreNotEnough,
		// Token: 0x0400B5A0 RID: 46496
		[OriginalName("BossRushActivityLevelNotPass")]
		BossRushActivityLevelNotPass,
		// Token: 0x0400B5A1 RID: 46497
		[OriginalName("BossRushActivityRewardClaimed")]
		BossRushActivityRewardClaimed,
		// Token: 0x0400B5A2 RID: 46498
		[OriginalName("BossRushActivityBuffSelectionNotValid")]
		BossRushActivityBuffSelectionNotValid,
		// Token: 0x0400B5A3 RID: 46499
		[OriginalName("BossRushActivityConfigNotExist")]
		BossRushActivityConfigNotExist,
		// Token: 0x0400B5A4 RID: 46500
		[OriginalName("BossRushActivityCharacterSelectionNotValid")]
		BossRushActivityCharacterSelectionNotValid,
		// Token: 0x0400B5A5 RID: 46501
		[OriginalName("BossRushActivityComponentNotExist")]
		BossRushActivityComponentNotExist,
		// Token: 0x0400B5A6 RID: 46502
		[OriginalName("BossRushActivityCharacterSelectionEmpty")]
		BossRushActivityCharacterSelectionEmpty,
		// Token: 0x0400B5A7 RID: 46503
		[OriginalName("BossRushActivityBuffSelectionEmpty")]
		BossRushActivityBuffSelectionEmpty,
		// Token: 0x0400B5A8 RID: 46504
		[OriginalName("BossRushActivityLevelNotOpen")]
		BossRushActivityLevelNotOpen,
		// Token: 0x0400B5A9 RID: 46505
		[OriginalName("InRangeEntityDuplicate")]
		InRangeEntityDuplicate,
		// Token: 0x0400B5AA RID: 46506
		[OriginalName("InRangeEntityNotExist")]
		InRangeEntityNotExist,
		// Token: 0x0400B5AB RID: 46507
		[OriginalName("NpcPerformComponentNotExist")]
		NpcPerformComponentNotExist,
		// Token: 0x0400B5AC RID: 46508
		[OriginalName("NpcPerformStateNotInit")]
		NpcPerformStateNotInit,
		// Token: 0x0400B5AD RID: 46509
		[OriginalName("NpcPerformActionTargetEntityNotExist")]
		NpcPerformActionTargetEntityNotExist,
		// Token: 0x0400B5AE RID: 46510
		[OriginalName("ActionQueueTypeNotExist")]
		ActionQueueTypeNotExist,
		// Token: 0x0400B5AF RID: 46511
		[OriginalName("ActionQueueCtxTypeNotExist")]
		ActionQueueCtxTypeNotExist,
		// Token: 0x0400B5B0 RID: 46512
		[OriginalName("ExecuteQueueOwnerHasAction")]
		ExecuteQueueOwnerHasAction,
		// Token: 0x0400B5B1 RID: 46513
		[OriginalName("ActionQueueExceedMaxCount")]
		ActionQueueExceedMaxCount,
		// Token: 0x0400B5B2 RID: 46514
		[OriginalName("ActionQueueStartActionGroupFail")]
		ActionQueueStartActionGroupFail,
		// Token: 0x0400B5B3 RID: 46515
		[OriginalName("ActionQueueComponentNotExist")]
		ActionQueueComponentNotExist,
		// Token: 0x0400B5B4 RID: 46516
		[OriginalName("ActionQueueNotInit")]
		ActionQueueNotInit,
		// Token: 0x0400B5B5 RID: 46517
		[OriginalName("ChangeBatchEntitiesStateError")]
		ChangeBatchEntitiesStateError,
		// Token: 0x0400B5B6 RID: 46518
		[OriginalName("EnableNearbyTrackingTargetEntityNotExist")]
		EnableNearbyTrackingTargetEntityNotExist,
		// Token: 0x0400B5B7 RID: 46519
		[OriginalName("EnableNearbyTrackingSelfNotEntity")]
		EnableNearbyTrackingSelfNotEntity,
		// Token: 0x0400B5B8 RID: 46520
		[OriginalName("EnableNearbyTrackingSelfComponentNotExist")]
		EnableNearbyTrackingSelfComponentNotExist,
		// Token: 0x0400B5B9 RID: 46521
		[OriginalName("SetTeleControlEntityNotExist")]
		SetTeleControlEntityNotExist,
		// Token: 0x0400B5BA RID: 46522
		[OriginalName("SetTeleControlTypeNotExist")]
		SetTeleControlTypeNotExist,
		// Token: 0x0400B5BB RID: 46523
		[OriginalName("SetTeleControlComponentNotExist")]
		SetTeleControlComponentNotExist,
		// Token: 0x0400B5BC RID: 46524
		[OriginalName("SetTeleControlCoordEntityNotExist")]
		SetTeleControlCoordEntityNotExist,
		// Token: 0x0400B5BD RID: 46525
		[OriginalName("SceneItemAttributeIdNotInType")]
		SceneItemAttributeIdNotInType,
		// Token: 0x0400B5BE RID: 46526
		[OriginalName("SceneItemAttributeIdNotExist")]
		SceneItemAttributeIdNotExist,
		// Token: 0x0400B5BF RID: 46527
		[OriginalName("ModifySceneItemAttributeEntityNotExist")]
		ModifySceneItemAttributeEntityNotExist,
		// Token: 0x0400B5C0 RID: 46528
		[OriginalName("AddSceneItemAttributeTagDuplicate")]
		AddSceneItemAttributeTagDuplicate,
		// Token: 0x0400B5C1 RID: 46529
		[OriginalName("RemoveSceneItemAttributeTagNotExist")]
		RemoveSceneItemAttributeTagNotExist,
		// Token: 0x0400B5C2 RID: 46530
		[OriginalName("AttributeEntityLock")]
		AttributeEntityLock,
		// Token: 0x0400B5C3 RID: 46531
		[OriginalName("AttributeEntitySilent")]
		AttributeEntitySilent,
		// Token: 0x0400B5C4 RID: 46532
		[OriginalName("ModifySceneItemAttributeTagNotExist")]
		ModifySceneItemAttributeTagNotExist,
		// Token: 0x0400B5C5 RID: 46533
		[OriginalName("ErrEnterInstCtx")]
		ErrEnterInstCtx,
		// Token: 0x0400B5C6 RID: 46534
		[OriginalName("ErrEnterInstBlackboardValueNotExist")]
		ErrEnterInstBlackboardValueNotExist,
		// Token: 0x0400B5C7 RID: 46535
		[OriginalName("TriggerLocked")]
		TriggerLocked,
		// Token: 0x0400B5C8 RID: 46536
		[OriginalName("TriggerIgnore")]
		TriggerIgnore,
		// Token: 0x0400B5C9 RID: 46537
		[OriginalName("TriggerEntityNull")]
		TriggerEntityNull,
		// Token: 0x0400B5CA RID: 46538
		[OriginalName("TriggerEntityNotMatch")]
		TriggerEntityNotMatch,
		// Token: 0x0400B5CB RID: 46539
		[OriginalName("TriggerMatchCountNotMet")]
		TriggerMatchCountNotMet,
		// Token: 0x0400B5CC RID: 46540
		[OriginalName("TriggerActionEmpty")]
		TriggerActionEmpty,
		// Token: 0x0400B5CD RID: 46541
		[OriginalName("ExceedMaxTriggerCount")]
		ExceedMaxTriggerCount,
		// Token: 0x0400B5CE RID: 46542
		[OriginalName("TriggerAlreadyLeaveWhenEnterCondFail")]
		TriggerAlreadyLeaveWhenEnterCondFail,
		// Token: 0x0400B5CF RID: 46543
		[OriginalName("TriggerLeaveConfigEmpty")]
		TriggerLeaveConfigEmpty,
		// Token: 0x0400B5D0 RID: 46544
		[OriginalName("TriggerConditionNotMet")]
		TriggerConditionNotMet,
		// Token: 0x0400B5D1 RID: 46545
		[OriginalName("TriggerRangeRationalityFail")]
		TriggerRangeRationalityFail,
		// Token: 0x0400B5D2 RID: 46546
		[OriginalName("TrampleEntityNotMatch")]
		TrampleEntityNotMatch,
		// Token: 0x0400B5D3 RID: 46547
		[OriginalName("TrampleConditionNotMet")]
		TrampleConditionNotMet,
		// Token: 0x0400B5D4 RID: 46548
		[OriginalName("TrampleMatchCountNotMet")]
		TrampleMatchCountNotMet,
		// Token: 0x0400B5D5 RID: 46549
		[OriginalName("HasDestroySelfActionInQueue")]
		HasDestroySelfActionInQueue,
		// Token: 0x0400B5D6 RID: 46550
		[OriginalName("EntityWillDestroy")]
		EntityWillDestroy,
		// Token: 0x0400B5D7 RID: 46551
		[OriginalName("AddInRangePlayerDuplicate")]
		AddInRangePlayerDuplicate,
		// Token: 0x0400B5D8 RID: 46552
		[OriginalName("AddInRangeEntityDuplicate")]
		AddInRangeEntityDuplicate,
		// Token: 0x0400B5D9 RID: 46553
		[OriginalName("RemoveInRangePlayerNotExist")]
		RemoveInRangePlayerNotExist,
		// Token: 0x0400B5DA RID: 46554
		[OriginalName("RemoveInRangeEntityNotExist")]
		RemoveInRangeEntityNotExist,
		// Token: 0x0400B5DB RID: 46555
		[OriginalName("GravityDirectionNoChange")]
		GravityDirectionNoChange = 2200072,
		// Token: 0x0400B5DC RID: 46556
		[OriginalName("HookExitWayNotExist")]
		HookExitWayNotExist = 2200065,
		// Token: 0x0400B5DD RID: 46557
		[OriginalName("HookLockPointLocked")]
		HookLockPointLocked,
		// Token: 0x0400B5DE RID: 46558
		[OriginalName("HookLockAddPlayerDuplicate")]
		HookLockAddPlayerDuplicate,
		// Token: 0x0400B5DF RID: 46559
		[OriginalName("HookLockRemovePlayerNotExist")]
		HookLockRemovePlayerNotExist,
		// Token: 0x0400B5E0 RID: 46560
		[OriginalName("KiteHookLockPointOnlyOnePlayer")]
		KiteHookLockPointOnlyOnePlayer,
		// Token: 0x0400B5E1 RID: 46561
		[OriginalName("EffectAreaAddBuffFail")]
		EffectAreaAddBuffFail = 2200073,
		// Token: 0x0400B5E2 RID: 46562
		[OriginalName("ErrGravityInteractNoPermission")]
		ErrGravityInteractNoPermission,
		// Token: 0x0400B5E3 RID: 46563
		[OriginalName("PlayerNotInAnyGravityRegion")]
		PlayerNotInAnyGravityRegion,
		// Token: 0x0400B5E4 RID: 46564
		[OriginalName("ErrSceneEntityAlreadyExist")]
		ErrSceneEntityAlreadyExist = 2200070,
		// Token: 0x0400B5E5 RID: 46565
		[OriginalName("PlayerLeaveGravityRegionInAbnormalGravity")]
		PlayerLeaveGravityRegionInAbnormalGravity = 2200076,
		// Token: 0x0400B5E6 RID: 46566
		[OriginalName("HookLockPointConditionNotMet")]
		HookLockPointConditionNotMet = 2200071,
		// Token: 0x0400B5E7 RID: 46567
		[OriginalName("PlayerInAbnormalGravity")]
		PlayerInAbnormalGravity = 2200077,
		// Token: 0x0400B5E8 RID: 46568
		[OriginalName("GravityFlipIndexNoChange")]
		GravityFlipIndexNoChange,
		// Token: 0x0400B5E9 RID: 46569
		[OriginalName("GravityFlipIndexNotExist")]
		GravityFlipIndexNotExist,
		// Token: 0x0400B5EA RID: 46570
		[OriginalName("GravityFlipTypeNoChange")]
		GravityFlipTypeNoChange,
		// Token: 0x0400B5EB RID: 46571
		[OriginalName("GravityFlipTypeNotExist")]
		GravityFlipTypeNotExist,
		// Token: 0x0400B5EC RID: 46572
		[OriginalName("GravityFlipNotUpdateToTargetDirection")]
		GravityFlipNotUpdateToTargetDirection,
		// Token: 0x0400B5ED RID: 46573
		[OriginalName("ReliablePosNotInGravityRegion")]
		ReliablePosNotInGravityRegion,
		// Token: 0x0400B5EE RID: 46574
		[OriginalName("TargetPosNotInGravityRegion")]
		TargetPosNotInGravityRegion,
		// Token: 0x0400B5EF RID: 46575
		[OriginalName("PlayerCurGravityDirectionNotInOptions")]
		PlayerCurGravityDirectionNotInOptions,
		// Token: 0x0400B5F0 RID: 46576
		[OriginalName("WaterfallClimbingParticipatorCountErr")]
		WaterfallClimbingParticipatorCountErr,
		// Token: 0x0400B5F1 RID: 46577
		[OriginalName("WaterfallClimbingParticipatorNoVehicle")]
		WaterfallClimbingParticipatorNoVehicle,
		// Token: 0x0400B5F2 RID: 46578
		[OriginalName("WaterfallClimbingVehicleNoPassenger")]
		WaterfallClimbingVehicleNoPassenger,
		// Token: 0x0400B5F3 RID: 46579
		[OriginalName("WaterfallClimbingPlayerNotInPassenger")]
		WaterfallClimbingPlayerNotInPassenger,
		// Token: 0x0400B5F4 RID: 46580
		[OriginalName("ErrVehicleEntityNotExist")]
		ErrVehicleEntityNotExist,
		// Token: 0x0400B5F5 RID: 46581
		[OriginalName("GravityFlipLocked")]
		GravityFlipLocked,
		// Token: 0x0400B5F6 RID: 46582
		[OriginalName("ClientActionSkipped")]
		ClientActionSkipped,
		// Token: 0x0400B5F7 RID: 46583
		[OriginalName("AbnormalGravityCannotAddTemporary")]
		AbnormalGravityCannotAddTemporary,
		// Token: 0x0400B5F8 RID: 46584
		[OriginalName("ErrReliablePosEntityNotExist")]
		ErrReliablePosEntityNotExist,
		// Token: 0x0400B5F9 RID: 46585
		[OriginalName("UpdateReliablePosGravityDirNotMatch")]
		UpdateReliablePosGravityDirNotMatch,
		// Token: 0x0400B5FA RID: 46586
		[OriginalName("UpdateReliablePosNotWalkable")]
		UpdateReliablePosNotWalkable,
		// Token: 0x0400B5FB RID: 46587
		[OriginalName("UpdateReliablePosSelfNotEntity")]
		UpdateReliablePosSelfNotEntity,
		// Token: 0x0400B5FC RID: 46588
		[OriginalName("GravityDirectionHasNaN")]
		GravityDirectionHasNaN,
		// Token: 0x0400B5FD RID: 46589
		[OriginalName("ErrHostInAbnormalGravity")]
		ErrHostInAbnormalGravity,
		// Token: 0x0400B5FE RID: 46590
		[OriginalName("MultiModeCannotTeleport")]
		MultiModeCannotTeleport,
		// Token: 0x0400B5FF RID: 46591
		[OriginalName("NotTrapDefenseInst")]
		NotTrapDefenseInst,
		// Token: 0x0400B600 RID: 46592
		[OriginalName("GridCellCreateFuncNotFound")]
		GridCellCreateFuncNotFound,
		// Token: 0x0400B601 RID: 46593
		[OriginalName("GridSystemNotExist")]
		GridSystemNotExist,
		// Token: 0x0400B602 RID: 46594
		[OriginalName("ErrGridCellType")]
		ErrGridCellType,
		// Token: 0x0400B603 RID: 46595
		[OriginalName("GridCellDirectionNotSpecified")]
		GridCellDirectionNotSpecified,
		// Token: 0x0400B604 RID: 46596
		[OriginalName("NotGridObjectEntity")]
		NotGridObjectEntity,
		// Token: 0x0400B605 RID: 46597
		[OriginalName("GridNotExist")]
		GridNotExist,
		// Token: 0x0400B606 RID: 46598
		[OriginalName("GridCellNotExist")]
		GridCellNotExist,
		// Token: 0x0400B607 RID: 46599
		[OriginalName("GridCellAlreadyOccupied")]
		GridCellAlreadyOccupied,
		// Token: 0x0400B608 RID: 46600
		[OriginalName("GridCellDisabled")]
		GridCellDisabled,
		// Token: 0x0400B609 RID: 46601
		[OriginalName("GridCellPositionNotValid")]
		GridCellPositionNotValid,
		// Token: 0x0400B60A RID: 46602
		[OriginalName("SimpleCombatEntityNotMonster")]
		SimpleCombatEntityNotMonster,
		// Token: 0x0400B60B RID: 46603
		[OriginalName("GridObjectEntityNotFound")]
		GridObjectEntityNotFound,
		// Token: 0x0400B60C RID: 46604
		[OriginalName("NotLowMemoryPlatform")]
		NotLowMemoryPlatform,
		// Token: 0x0400B60D RID: 46605
		[OriginalName("ErrLowMemorySwitchingScene")]
		ErrLowMemorySwitchingScene,
		// Token: 0x0400B60E RID: 46606
		[OriginalName("SimpleCombatEntityBuffNotExist")]
		SimpleCombatEntityBuffNotExist,
		// Token: 0x0400B60F RID: 46607
		[OriginalName("SimpleCombatEntityBuffDuplicate")]
		SimpleCombatEntityBuffDuplicate,
		// Token: 0x0400B610 RID: 46608
		[OriginalName("TrapDefenseRandomBdFail")]
		TrapDefenseRandomBdFail,
		// Token: 0x0400B611 RID: 46609
		[OriginalName("TrapDefenseBdConfigNotExist")]
		TrapDefenseBdConfigNotExist,
		// Token: 0x0400B612 RID: 46610
		[OriginalName("TrapDefenseBdGroupConfigOfBdNotExist")]
		TrapDefenseBdGroupConfigOfBdNotExist,
		// Token: 0x0400B613 RID: 46611
		[OriginalName("TrapDefenseRandomQualityFail")]
		TrapDefenseRandomQualityFail,
		// Token: 0x0400B614 RID: 46612
		[OriginalName("TrapDefenseRandomBdGroupFail")]
		TrapDefenseRandomBdGroupFail,
		// Token: 0x0400B615 RID: 46613
		[OriginalName("TrapDefenseBdGroupPoolEmpty")]
		TrapDefenseBdGroupPoolEmpty,
		// Token: 0x0400B616 RID: 46614
		[OriginalName("TrapDefenseNoAvailableBd")]
		TrapDefenseNoAvailableBd,
		// Token: 0x0400B617 RID: 46615
		[OriginalName("TrapDefenseNoAvailableQuality")]
		TrapDefenseNoAvailableQuality,
		// Token: 0x0400B618 RID: 46616
		[OriginalName("TrapDefenseDrawActionConfigNotExist")]
		TrapDefenseDrawActionConfigNotExist,
		// Token: 0x0400B619 RID: 46617
		[OriginalName("TrapDefenseInstConfigNotExist")]
		TrapDefenseInstConfigNotExist,
		// Token: 0x0400B61A RID: 46618
		[OriginalName("TrapDefenseWaveConfigNotExist")]
		TrapDefenseWaveConfigNotExist,
		// Token: 0x0400B61B RID: 46619
		[OriginalName("TrapDefenseSpawnMonsterWaveConfigNotExist")]
		TrapDefenseSpawnMonsterWaveConfigNotExist,
		// Token: 0x0400B61C RID: 46620
		[OriginalName("TrapDefenseMonsterConfigNotExist")]
		TrapDefenseMonsterConfigNotExist,
		// Token: 0x0400B61D RID: 46621
		[OriginalName("TrapDefenseMonsterDataDuplicate")]
		TrapDefenseMonsterDataDuplicate,
		// Token: 0x0400B61E RID: 46622
		[OriginalName("TrapDefenseTrapConfigNotExist")]
		TrapDefenseTrapConfigNotExist,
		// Token: 0x0400B61F RID: 46623
		[OriginalName("TrapDefenseTrapEntityNotFound")]
		TrapDefenseTrapEntityNotFound,
		// Token: 0x0400B620 RID: 46624
		[OriginalName("TrapDefenseNotPreviewStep")]
		TrapDefenseNotPreviewStep,
		// Token: 0x0400B621 RID: 46625
		[OriginalName("TrapDefenseBdGroupConfigNotExist")]
		TrapDefenseBdGroupConfigNotExist,
		// Token: 0x0400B622 RID: 46626
		[OriginalName("TrapDefenseBdPoolEmpty")]
		TrapDefenseBdPoolEmpty,
		// Token: 0x0400B623 RID: 46627
		[OriginalName("TrapDefenseQualityPoolEmpty")]
		TrapDefenseQualityPoolEmpty,
		// Token: 0x0400B624 RID: 46628
		[OriginalName("ErrTrapDefenseRequestParam")]
		ErrTrapDefenseRequestParam,
		// Token: 0x0400B625 RID: 46629
		[OriginalName("ErrTrapDefenseRequestParamDuplicate")]
		ErrTrapDefenseRequestParamDuplicate,
		// Token: 0x0400B626 RID: 46630
		[OriginalName("ErrTrapDefenseRewardConfig")]
		ErrTrapDefenseRewardConfig,
		// Token: 0x0400B627 RID: 46631
		[OriginalName("ErrTrapDefenseRewardTime")]
		ErrTrapDefenseRewardTime,
		// Token: 0x0400B628 RID: 46632
		[OriginalName("ErrTrapDefenseRewardReceived")]
		ErrTrapDefenseRewardReceived,
		// Token: 0x0400B629 RID: 46633
		[OriginalName("ErrTrapDefenseRewardNotComplete")]
		ErrTrapDefenseRewardNotComplete,
		// Token: 0x0400B62A RID: 46634
		[OriginalName("ErrTrapDefenseSceneErr")]
		ErrTrapDefenseSceneErr,
		// Token: 0x0400B62B RID: 46635
		[OriginalName("ErrTrapDefenseContextEmpty")]
		ErrTrapDefenseContextEmpty,
		// Token: 0x0400B62C RID: 46636
		[OriginalName("ErrTrapDefenseChallengeConfig")]
		ErrTrapDefenseChallengeConfig,
		// Token: 0x0400B62D RID: 46637
		[OriginalName("ErrTrapDefenseChallengeNotOpen")]
		ErrTrapDefenseChallengeNotOpen,
		// Token: 0x0400B62E RID: 46638
		[OriginalName("ErrTrapDefenseBuildingLock")]
		ErrTrapDefenseBuildingLock,
		// Token: 0x0400B62F RID: 46639
		[OriginalName("ErrTrapDefenseAuxiliaryLock")]
		ErrTrapDefenseAuxiliaryLock,
		// Token: 0x0400B630 RID: 46640
		[OriginalName("ErrTrapDefenseSlotCount")]
		ErrTrapDefenseSlotCount,
		// Token: 0x0400B631 RID: 46641
		[OriginalName("ErrTrapDefenseSlotBuildingDuplicate")]
		ErrTrapDefenseSlotBuildingDuplicate,
		// Token: 0x0400B632 RID: 46642
		[OriginalName("ErrTrapDefenseSlotDuplicate")]
		ErrTrapDefenseSlotDuplicate,
		// Token: 0x0400B633 RID: 46643
		[OriginalName("ErrTrapDefenseBuildingConfig")]
		ErrTrapDefenseBuildingConfig,
		// Token: 0x0400B634 RID: 46644
		[OriginalName("ErrTrapDefenseAuxiliaryConfig")]
		ErrTrapDefenseAuxiliaryConfig,
		// Token: 0x0400B635 RID: 46645
		[OriginalName("ErrTrapDefenseSlotAuxiliaryDuplicate")]
		ErrTrapDefenseSlotAuxiliaryDuplicate,
		// Token: 0x0400B636 RID: 46646
		[OriginalName("ErrTrapDefenseForceBuilding")]
		ErrTrapDefenseForceBuilding,
		// Token: 0x0400B637 RID: 46647
		[OriginalName("ErrTrapDefenseForceAuxiliary")]
		ErrTrapDefenseForceAuxiliary,
		// Token: 0x0400B638 RID: 46648
		[OriginalName("ErrTrapDefenseBuildingLevelConfig")]
		ErrTrapDefenseBuildingLevelConfig,
		// Token: 0x0400B639 RID: 46649
		[OriginalName("ErrTrapDefenseBuildingMaxLevel")]
		ErrTrapDefenseBuildingMaxLevel,
		// Token: 0x0400B63A RID: 46650
		[OriginalName("ErrTrapDefenseActivityConfig")]
		ErrTrapDefenseActivityConfig,
		// Token: 0x0400B63B RID: 46651
		[OriginalName("ErrTrapDefenseAuxiliaryLevelConfig")]
		ErrTrapDefenseAuxiliaryLevelConfig,
		// Token: 0x0400B63C RID: 46652
		[OriginalName("ErrTrapDefenseAuxiliaryMaxLevel")]
		ErrTrapDefenseAuxiliaryMaxLevel,
		// Token: 0x0400B63D RID: 46653
		[OriginalName("ErrTrapDefenseAuxiliaryBranch")]
		ErrTrapDefenseAuxiliaryBranch,
		// Token: 0x0400B63E RID: 46654
		[OriginalName("ErrTrapDefenseBuildingBranch")]
		ErrTrapDefenseBuildingBranch,
		// Token: 0x0400B63F RID: 46655
		[OriginalName("ErrTrapDefenseAuxiliaryReset")]
		ErrTrapDefenseAuxiliaryReset,
		// Token: 0x0400B640 RID: 46656
		[OriginalName("ErrTrapDefenseBuildingReset")]
		ErrTrapDefenseBuildingReset,
		// Token: 0x0400B641 RID: 46657
		[OriginalName("ErrTrapDefenseTechConfig")]
		ErrTrapDefenseTechConfig,
		// Token: 0x0400B642 RID: 46658
		[OriginalName("ErrTrapDefenseTechUnlock")]
		ErrTrapDefenseTechUnlock,
		// Token: 0x0400B643 RID: 46659
		[OriginalName("ErrTrapDefenseTechPreNodeConfig")]
		ErrTrapDefenseTechPreNodeConfig,
		// Token: 0x0400B644 RID: 46660
		[OriginalName("ErrTrapDefenseTechPreNodeLock")]
		ErrTrapDefenseTechPreNodeLock,
		// Token: 0x0400B645 RID: 46661
		[OriginalName("ErrTrapDefenseTechCostNotEnough")]
		ErrTrapDefenseTechCostNotEnough,
		// Token: 0x0400B646 RID: 46662
		[OriginalName("TrapDefenseItemConfigNotExist")]
		TrapDefenseItemConfigNotExist,
		// Token: 0x0400B647 RID: 46663
		[OriginalName("TrapDefenseItemExceedCarryLimit")]
		TrapDefenseItemExceedCarryLimit,
		// Token: 0x0400B648 RID: 46664
		[OriginalName("TrapDefenseItemNotEnough")]
		TrapDefenseItemNotEnough,
		// Token: 0x0400B649 RID: 46665
		[OriginalName("TrapDefenseBuyShopBdGroupNotExist")]
		TrapDefenseBuyShopBdGroupNotExist,
		// Token: 0x0400B64A RID: 46666
		[OriginalName("TrapDefenseBuyShopItemNotExist")]
		TrapDefenseBuyShopItemNotExist,
		// Token: 0x0400B64B RID: 46667
		[OriginalName("TrapDefenseGoldNotEnough")]
		TrapDefenseGoldNotEnough,
		// Token: 0x0400B64C RID: 46668
		[OriginalName("TrapDefensePayGoldFail")]
		TrapDefensePayGoldFail,
		// Token: 0x0400B64D RID: 46669
		[OriginalName("TrapDefenseBuyShopItemNotEnough")]
		TrapDefenseBuyShopItemNotEnough,
		// Token: 0x0400B64E RID: 46670
		[OriginalName("TrapDefenseShopDataNotExist")]
		TrapDefenseShopDataNotExist,
		// Token: 0x0400B64F RID: 46671
		[OriginalName("TrapDefenseShopConfigNotExist")]
		TrapDefenseShopConfigNotExist,
		// Token: 0x0400B650 RID: 46672
		[OriginalName("TrapDefenseShopRefreshCountNotEnough")]
		TrapDefenseShopRefreshCountNotEnough,
		// Token: 0x0400B651 RID: 46673
		[OriginalName("TrapDefenseGoldenCoinConfigNotExist")]
		TrapDefenseGoldenCoinConfigNotExist,
		// Token: 0x0400B652 RID: 46674
		[OriginalName("TrapDefenseNotGoldenCoinEntity")]
		TrapDefenseNotGoldenCoinEntity,
		// Token: 0x0400B653 RID: 46675
		[OriginalName("TrapDefenseNotMonsterEntity")]
		TrapDefenseNotMonsterEntity,
		// Token: 0x0400B654 RID: 46676
		[OriginalName("TrapDefenseNotBuildingEntity")]
		TrapDefenseNotBuildingEntity,
		// Token: 0x0400B655 RID: 46677
		[OriginalName("TrapDefenseVarCannotUnderZero")]
		TrapDefenseVarCannotUnderZero,
		// Token: 0x0400B656 RID: 46678
		[OriginalName("TrapDefenseVarTypeNotExist")]
		TrapDefenseVarTypeNotExist,
		// Token: 0x0400B657 RID: 46679
		[OriginalName("TrapDefenseBuyShopBdGroupSold")]
		TrapDefenseBuyShopBdGroupSold,
		// Token: 0x0400B658 RID: 46680
		[OriginalName("TrapDefenseTrapAmountExceedLimit")]
		TrapDefenseTrapAmountExceedLimit,
		// Token: 0x0400B659 RID: 46681
		[OriginalName("TrapDefenseNotRewardStep")]
		TrapDefenseNotRewardStep,
		// Token: 0x0400B65A RID: 46682
		[OriginalName("TrapDefenseBdDrawDataNotExist")]
		TrapDefenseBdDrawDataNotExist,
		// Token: 0x0400B65B RID: 46683
		[OriginalName("TrapDefenseBdDrawRefreshCountNotEnough")]
		TrapDefenseBdDrawRefreshCountNotEnough,
		// Token: 0x0400B65C RID: 46684
		[OriginalName("TrapDefenseSpecialCellConfigNotExist")]
		TrapDefenseSpecialCellConfigNotExist,
		// Token: 0x0400B65D RID: 46685
		[OriginalName("TrapDefenseSpecialCellCertainLevelConfigNotExist")]
		TrapDefenseSpecialCellCertainLevelConfigNotExist,
		// Token: 0x0400B65E RID: 46686
		[OriginalName("ErrActionTargetEntityNotExist")]
		ErrActionTargetEntityNotExist,
		// Token: 0x0400B65F RID: 46687
		[OriginalName("TrapDefenseCleanerNotEnough")]
		TrapDefenseCleanerNotEnough,
		// Token: 0x0400B660 RID: 46688
		[OriginalName("TrapDefenseItemConfigError")]
		TrapDefenseItemConfigError,
		// Token: 0x0400B661 RID: 46689
		[OriginalName("TrapDefenseSpecialCellTypeNotSame")]
		TrapDefenseSpecialCellTypeNotSame,
		// Token: 0x0400B662 RID: 46690
		[OriginalName("TrapDefenseCellNotSpecialCell")]
		TrapDefenseCellNotSpecialCell,
		// Token: 0x0400B663 RID: 46691
		[OriginalName("TrapDefenseExceedMaxTrapCount")]
		TrapDefenseExceedMaxTrapCount,
		// Token: 0x0400B664 RID: 46692
		[OriginalName("GridSystemCannotGetWorldGridPos")]
		GridSystemCannotGetWorldGridPos,
		// Token: 0x0400B665 RID: 46693
		[OriginalName("TrapDefenseTrapCannotSelfDestruct")]
		TrapDefenseTrapCannotSelfDestruct,
		// Token: 0x0400B666 RID: 46694
		[OriginalName("TrapDefenseBdDrawResultEmpty")]
		TrapDefenseBdDrawResultEmpty,
		// Token: 0x0400B667 RID: 46695
		[OriginalName("TrapDefenseBdGroupMaxLevel")]
		TrapDefenseBdGroupMaxLevel,
		// Token: 0x0400B668 RID: 46696
		[OriginalName("TrapDefenseCannotDeductHealth")]
		TrapDefenseCannotDeductHealth,
		// Token: 0x0400B669 RID: 46697
		[OriginalName("SimpleCombatBuffConfigNotExist")]
		SimpleCombatBuffConfigNotExist,
		// Token: 0x0400B66A RID: 46698
		[OriginalName("SimpleCombatSubTypeNotExist")]
		SimpleCombatSubTypeNotExist,
		// Token: 0x0400B66B RID: 46699
		[OriginalName("TrapDefenseBdGroupDisabled")]
		TrapDefenseBdGroupDisabled,
		// Token: 0x0400B66C RID: 46700
		[OriginalName("TrapDefenseMonsterDisabled")]
		TrapDefenseMonsterDisabled,
		// Token: 0x0400B66D RID: 46701
		[OriginalName("TrapDefenseGainExceedLimit")]
		TrapDefenseGainExceedLimit,
		// Token: 0x0400B66E RID: 46702
		[OriginalName("OnlyOneRollBlockCanBeActivated")]
		OnlyOneRollBlockCanBeActivated,
		// Token: 0x0400B66F RID: 46703
		[OriginalName("RollBlockGroupConfigNotExist")]
		RollBlockGroupConfigNotExist,
		// Token: 0x0400B670 RID: 46704
		[OriginalName("RollBlockDifficultyConfigNotExist")]
		RollBlockDifficultyConfigNotExist,
		// Token: 0x0400B671 RID: 46705
		[OriginalName("RollBlockNextDifficultyConfigNotExist")]
		RollBlockNextDifficultyConfigNotExist,
		// Token: 0x0400B672 RID: 46706
		[OriginalName("RollBlockGamePlayIdNotExist")]
		RollBlockGamePlayIdNotExist,
		// Token: 0x0400B673 RID: 46707
		[OriginalName("RollBlockGamePlayNotExist")]
		RollBlockGamePlayNotExist,
		// Token: 0x0400B674 RID: 46708
		[OriginalName("RollBlockMovementEntityNotExist")]
		RollBlockMovementEntityNotExist,
		// Token: 0x0400B675 RID: 46709
		[OriginalName("RollBlockMovementEntityNotBlock")]
		RollBlockMovementEntityNotBlock,
		// Token: 0x0400B676 RID: 46710
		[OriginalName("RollBlockMainControlPlayerNotExist")]
		RollBlockMainControlPlayerNotExist,
		// Token: 0x0400B677 RID: 46711
		[OriginalName("RollBlockEntityNotMoving")]
		RollBlockEntityNotMoving,
		// Token: 0x0400B678 RID: 46712
		[OriginalName("RollBlockNoGridAfterRoll")]
		RollBlockNoGridAfterRoll,
		// Token: 0x0400B679 RID: 46713
		[OriginalName("RollBlockTemplateConfigNotExist")]
		RollBlockTemplateConfigNotExist,
		// Token: 0x0400B67A RID: 46714
		[OriginalName("RollBlockNotMainControlPlayer")]
		RollBlockNotMainControlPlayer,
		// Token: 0x0400B67B RID: 46715
		[OriginalName("RollBlockEntityNotExist")]
		RollBlockEntityNotExist,
		// Token: 0x0400B67C RID: 46716
		[OriginalName("RollBlockBlockWillChangeState")]
		RollBlockBlockWillChangeState,
		// Token: 0x0400B67D RID: 46717
		[OriginalName("RollBlockBlockStateNoChange")]
		RollBlockBlockStateNoChange,
		// Token: 0x0400B67E RID: 46718
		[OriginalName("RollBlockMainControlBlockNotExist")]
		RollBlockMainControlBlockNotExist,
		// Token: 0x0400B67F RID: 46719
		[OriginalName("RollBlockDifficultyDataNotExist")]
		RollBlockDifficultyDataNotExist,
		// Token: 0x0400B680 RID: 46720
		[OriginalName("RollBlockPositionNoFloor")]
		RollBlockPositionNoFloor,
		// Token: 0x0400B681 RID: 46721
		[OriginalName("RollBlockPositionItemCannotPass")]
		RollBlockPositionItemCannotPass,
		// Token: 0x0400B682 RID: 46722
		[OriginalName("RollBlockPositionBlockCannotPass")]
		RollBlockPositionBlockCannotPass,
		// Token: 0x0400B683 RID: 46723
		[OriginalName("RollBlockInputCannotMove")]
		RollBlockInputCannotMove,
		// Token: 0x0400B684 RID: 46724
		[OriginalName("RollBlockPositionFloorCannotPass")]
		RollBlockPositionFloorCannotPass,
		// Token: 0x0400B685 RID: 46725
		[OriginalName("RollBlockHintAlreadyActive")]
		RollBlockHintAlreadyActive,
		// Token: 0x0400B686 RID: 46726
		[OriginalName("RollBlockHintBlockNotExist")]
		RollBlockHintBlockNotExist,
		// Token: 0x0400B687 RID: 46727
		[OriginalName("RollBlockHintEmpty")]
		RollBlockHintEmpty,
		// Token: 0x0400B688 RID: 46728
		[OriginalName("RollBlockAlreadyRewarded")]
		RollBlockAlreadyRewarded,
		// Token: 0x0400B689 RID: 46729
		[OriginalName("RollBlockDifficultyNotPassed")]
		RollBlockDifficultyNotPassed,
		// Token: 0x0400B68A RID: 46730
		[OriginalName("RollBlockHintStepNotExecuting")]
		RollBlockHintStepNotExecuting,
		// Token: 0x0400B68B RID: 46731
		[OriginalName("RollBlockCurDifficultyConfigNotExist")]
		RollBlockCurDifficultyConfigNotExist,
		// Token: 0x0400B68C RID: 46732
		[OriginalName("RollBlockHintStepExecuting")]
		RollBlockHintStepExecuting,
		// Token: 0x0400B68D RID: 46733
		[OriginalName("RollBlockChildQuestGamePlayActived")]
		RollBlockChildQuestGamePlayActived,
		// Token: 0x0400B68E RID: 46734
		[OriginalName("RollBlockOnlyOneControllableBlock")]
		RollBlockOnlyOneControllableBlock,
		// Token: 0x0400B68F RID: 46735
		[OriginalName("RollBlockGamePlayStateNoChange")]
		RollBlockGamePlayStateNoChange,
		// Token: 0x0400B690 RID: 46736
		[OriginalName("RollBlockGamePlayCannotReady")]
		RollBlockGamePlayCannotReady,
		// Token: 0x0400B691 RID: 46737
		[OriginalName("RollBlockGamePlayNotReady")]
		RollBlockGamePlayNotReady,
		// Token: 0x0400B692 RID: 46738
		[OriginalName("RollBlockSendResetTooFrequently")]
		RollBlockSendResetTooFrequently,
		// Token: 0x0400B693 RID: 46739
		[OriginalName("EasterEggIdNotExist")]
		EasterEggIdNotExist,
		// Token: 0x0400B694 RID: 46740
		[OriginalName("TargetSceneNotBigWorldInst")]
		TargetSceneNotBigWorldInst,
		// Token: 0x0400B695 RID: 46741
		[OriginalName("EnterBigWorldInstCtxNotImplemented")]
		EnterBigWorldInstCtxNotImplemented,
		// Token: 0x0400B696 RID: 46742
		[OriginalName("EasterEggOwnerTypeNotImplemented")]
		EasterEggOwnerTypeNotImplemented,
		// Token: 0x0400B697 RID: 46743
		[OriginalName("RollBlockCannotReset")]
		RollBlockCannotReset,
		// Token: 0x0400B698 RID: 46744
		[OriginalName("CurSceneNotBigWorld")]
		CurSceneNotBigWorld,
		// Token: 0x0400B699 RID: 46745
		[OriginalName("KurotatoCharacterConfigNotExist")]
		KurotatoCharacterConfigNotExist,
		// Token: 0x0400B69A RID: 46746
		[OriginalName("KurotatoLevelInfoNotExist")]
		KurotatoLevelInfoNotExist,
		// Token: 0x0400B69B RID: 46747
		[OriginalName("KurotatoUpgradeRewardStepNotActive")]
		KurotatoUpgradeRewardStepNotActive,
		// Token: 0x0400B69C RID: 46748
		[OriginalName("KurotatoUpgradeRewardItemNotFound")]
		KurotatoUpgradeRewardItemNotFound,
		// Token: 0x0400B69D RID: 46749
		[OriginalName("KurotatoUpgradeRewardDataNotExist")]
		KurotatoUpgradeRewardDataNotExist,
		// Token: 0x0400B69E RID: 46750
		[OriginalName("KurotatoActivityConfigNotExist")]
		KurotatoActivityConfigNotExist,
		// Token: 0x0400B69F RID: 46751
		[OriginalName("KurotatoWeaponConfigNotExist")]
		KurotatoWeaponConfigNotExist,
		// Token: 0x0400B6A0 RID: 46752
		[OriginalName("KurotatoWeaponNotExist")]
		KurotatoWeaponNotExist,
		// Token: 0x0400B6A1 RID: 46753
		[OriginalName("KurotatoItemConfigNotExist")]
		KurotatoItemConfigNotExist,
		// Token: 0x0400B6A2 RID: 46754
		[OriginalName("KurotatoItemNotExist")]
		KurotatoItemNotExist,
		// Token: 0x0400B6A3 RID: 46755
		[OriginalName("KurotatoChestRewardStepNotActive")]
		KurotatoChestRewardStepNotActive,
		// Token: 0x0400B6A4 RID: 46756
		[OriginalName("KurotatoChestRewardItemNotExist")]
		KurotatoChestRewardItemNotExist,
		// Token: 0x0400B6A5 RID: 46757
		[OriginalName("KurotatoEffectConfigNotExist")]
		KurotatoEffectConfigNotExist,
		// Token: 0x0400B6A6 RID: 46758
		[OriginalName("KurotatoEffectNotExist")]
		KurotatoEffectNotExist,
		// Token: 0x0400B6A7 RID: 46759
		[OriginalName("KurotatoDrawConfigNotExist")]
		KurotatoDrawConfigNotExist,
		// Token: 0x0400B6A8 RID: 46760
		[OriginalName("KurotatoPropertyConfigNotExist")]
		KurotatoPropertyConfigNotExist,
		// Token: 0x0400B6A9 RID: 46761
		[OriginalName("KurotatoPropertyNotInSimpleCombatDefine")]
		KurotatoPropertyNotInSimpleCombatDefine,
		// Token: 0x0400B6AA RID: 46762
		[OriginalName("KurotatoShopStepNotActive")]
		KurotatoShopStepNotActive,
		// Token: 0x0400B6AB RID: 46763
		[OriginalName("KurotatoShopProductNotFound")]
		KurotatoShopProductNotFound,
		// Token: 0x0400B6AC RID: 46764
		[OriginalName("KurotatoShopGoldNotEnough")]
		KurotatoShopGoldNotEnough,
		// Token: 0x0400B6AD RID: 46765
		[OriginalName("KurotatoVarNameNotExist")]
		KurotatoVarNameNotExist,
		// Token: 0x0400B6AE RID: 46766
		[OriginalName("KurotatoVarNotExist")]
		KurotatoVarNotExist,
		// Token: 0x0400B6AF RID: 46767
		[OriginalName("KurotatoRoleLevelConfigNotExist")]
		KurotatoRoleLevelConfigNotExist,
		// Token: 0x0400B6B0 RID: 46768
		[OriginalName("KurotatoCharacterEntityNotExist")]
		KurotatoCharacterEntityNotExist,
		// Token: 0x0400B6B1 RID: 46769
		[OriginalName("KurotatoGoldNotEnough")]
		KurotatoGoldNotEnough,
		// Token: 0x0400B6B2 RID: 46770
		[OriginalName("KurotatoMonsterConfigNotExist")]
		KurotatoMonsterConfigNotExist,
		// Token: 0x0400B6B3 RID: 46771
		[OriginalName("KurotatoMultiModeNotSupported")]
		KurotatoMultiModeNotSupported,
		// Token: 0x0400B6B4 RID: 46772
		[OriginalName("KurotatoLevelConfigNotExist")]
		KurotatoLevelConfigNotExist,
		// Token: 0x0400B6B5 RID: 46773
		[OriginalName("KurotatoDropInfoNotExist")]
		KurotatoDropInfoNotExist,
		// Token: 0x0400B6B6 RID: 46774
		[OriginalName("KurotatoDropConfigNotExist")]
		KurotatoDropConfigNotExist,
		// Token: 0x0400B6B7 RID: 46775
		[OriginalName("KurotatoWaveConfigNotExist")]
		KurotatoWaveConfigNotExist,
		// Token: 0x0400B6B8 RID: 46776
		[OriginalName("KurotatoWeaponCountReachLimit")]
		KurotatoWeaponCountReachLimit,
		// Token: 0x0400B6B9 RID: 46777
		[OriginalName("KurotatoWeaponRefineNotEnoughSameQuality")]
		KurotatoWeaponRefineNotEnoughSameQuality,
		// Token: 0x0400B6BA RID: 46778
		[OriginalName("KurotatoItemStackFull")]
		KurotatoItemStackFull,
		// Token: 0x0400B6BB RID: 46779
		[OriginalName("KurotatoCharacterUpgradeConfigNotExist")]
		KurotatoCharacterUpgradeConfigNotExist,
		// Token: 0x0400B6BC RID: 46780
		[OriginalName("KurotatoUpgradeRewardDrawIdNotExist")]
		KurotatoUpgradeRewardDrawIdNotExist,
		// Token: 0x0400B6BD RID: 46781
		[OriginalName("KurotatoDrawResultEmpty")]
		KurotatoDrawResultEmpty,
		// Token: 0x0400B6BE RID: 46782
		[OriginalName("KurotatoLuckPropertyNotExist")]
		KurotatoLuckPropertyNotExist,
		// Token: 0x0400B6BF RID: 46783
		[OriginalName("KurotatoGoldGainPropertyNotExist")]
		KurotatoGoldGainPropertyNotExist,
		// Token: 0x0400B6C0 RID: 46784
		[OriginalName("KurotatoCharacterAlreadyExist")]
		KurotatoCharacterAlreadyExist,
		// Token: 0x0400B6C1 RID: 46785
		[OriginalName("KurotatoCombatStepNotActive")]
		KurotatoCombatStepNotActive,
		// Token: 0x0400B6C2 RID: 46786
		[OriginalName("KurotatoNotInSpecialWave")]
		KurotatoNotInSpecialWave,
		// Token: 0x0400B6C3 RID: 46787
		[OriginalName("KurotatoWeaponCountReachMin")]
		KurotatoWeaponCountReachMin,
		// Token: 0x0400B6C4 RID: 46788
		[OriginalName("KurotatoNotSupportedProductType")]
		KurotatoNotSupportedProductType,
		// Token: 0x0400B6C5 RID: 46789
		[OriginalName("KurotatoStructureConfigNotExist")]
		KurotatoStructureConfigNotExist,
		// Token: 0x0400B6C6 RID: 46790
		[OriginalName("KurotatoStructureCannotCreate")]
		KurotatoStructureCannotCreate,
		// Token: 0x0400B6C7 RID: 46791
		[OriginalName("NotQaAccountWithHIddenServer")]
		NotQaAccountWithHiddenServer = 2300000,
		// Token: 0x0400B6C8 RID: 46792
		[OriginalName("DisabledFuncInHIddenServer")]
		DisabledFuncInHiddenServer,
		// Token: 0x0400B6C9 RID: 46793
		[OriginalName("ErrActionExecutorFinishConditionNotSport")]
		ErrActionExecutorFinishConditionNotSport = 2400000,
		// Token: 0x0400B6CA RID: 46794
		[OriginalName("ErrAlreadyInSwitchNode")]
		ErrAlreadyInSwitchNode,
		// Token: 0x0400B6CB RID: 46795
		[OriginalName("ErrCornActivityId")]
		ErrCornActivityId = 2500000,
		// Token: 0x0400B6CC RID: 46796
		[OriginalName("ErrCornActivityNoOpen")]
		ErrCornActivityNoOpen,
		// Token: 0x0400B6CD RID: 46797
		[OriginalName("ErrCornNoActivityData")]
		ErrCornNoActivityData,
		// Token: 0x0400B6CE RID: 46798
		[OriginalName("NoPlayIdCorniceReward")]
		NoPlayIdCorniceReward,
		// Token: 0x0400B6CF RID: 46799
		[OriginalName("ActivityNoOpenCorniceReward")]
		ActivityNoOpenCorniceReward,
		// Token: 0x0400B6D0 RID: 46800
		[OriginalName("ScoreLimitCorniceReward")]
		ScoreLimitCorniceReward,
		// Token: 0x0400B6D1 RID: 46801
		[OriginalName("RewardedCorniceReward")]
		RewardedCorniceReward,
		// Token: 0x0400B6D2 RID: 46802
		[OriginalName("NoUnlockCorniceReward")]
		NoUnlockCorniceReward,
		// Token: 0x0400B6D3 RID: 46803
		[OriginalName("NoScoreCorniceReward")]
		NoScoreCorniceReward,
		// Token: 0x0400B6D4 RID: 46804
		[OriginalName("TrackMoonPhaseNoConfig")]
		TrackMoonPhaseNoConfig,
		// Token: 0x0400B6D5 RID: 46805
		[OriginalName("TrackMoonPhaseActivityNoOpen")]
		TrackMoonPhaseActivityNoOpen,
		// Token: 0x0400B6D6 RID: 46806
		[OriginalName("TrackMoonPhaseNoPolulary")]
		TrackMoonPhaseNoPolulary,
		// Token: 0x0400B6D7 RID: 46807
		[OriginalName("TrackMoonPhaseNoData")]
		TrackMoonPhaseNoData,
		// Token: 0x0400B6D8 RID: 46808
		[OriginalName("TrackMoonPhaseRewarded")]
		TrackMoonPhaseRewarded,
		// Token: 0x0400B6D9 RID: 46809
		[OriginalName("TrackMoonPhaseDataNoConfig")]
		TrackMoonPhaseDataNoConfig,
		// Token: 0x0400B6DA RID: 46810
		[OriginalName("TrackMoonPhaseDataNoOpen")]
		TrackMoonPhaseDataNoOpen,
		// Token: 0x0400B6DB RID: 46811
		[OriginalName("TrackMoonPhaseDataNoData")]
		TrackMoonPhaseDataNoData,
		// Token: 0x0400B6DC RID: 46812
		[OriginalName("BCTRewardNoTConfig")]
		BctrewardNoTconfig,
		// Token: 0x0400B6DD RID: 46813
		[OriginalName("BCTRewardNoOpenActivity")]
		BctrewardNoOpenActivity,
		// Token: 0x0400B6DE RID: 46814
		[OriginalName("BCTRewardNoData")]
		BctrewardNoData,
		// Token: 0x0400B6DF RID: 46815
		[OriginalName("BCTRewardNoUnlock")]
		BctrewardNoUnlock,
		// Token: 0x0400B6E0 RID: 46816
		[OriginalName("BCTRewardNoComplete")]
		BctrewardNoComplete,
		// Token: 0x0400B6E1 RID: 46817
		[OriginalName("BCARewardNoRConfig")]
		BcarewardNoRconfig,
		// Token: 0x0400B6E2 RID: 46818
		[OriginalName("BCARewardNoOpenActivity")]
		BcarewardNoOpenActivity,
		// Token: 0x0400B6E3 RID: 46819
		[OriginalName("BCARewardNoData")]
		BcarewardNoData,
		// Token: 0x0400B6E4 RID: 46820
		[OriginalName("BCARewardNoActive")]
		BcarewardNoActive,
		// Token: 0x0400B6E5 RID: 46821
		[OriginalName("BCARewarded")]
		Bcarewarded,
		// Token: 0x0400B6E6 RID: 46822
		[OriginalName("BCARewardNoActiveReward")]
		BcarewardNoActiveReward,
		// Token: 0x0400B6E7 RID: 46823
		[OriginalName("CornTranNoPlayConfig")]
		CornTranNoPlayConfig,
		// Token: 0x0400B6E8 RID: 46824
		[OriginalName("CornTranNoOpenPlay")]
		CornTranNoOpenPlay,
		// Token: 0x0400B6E9 RID: 46825
		[OriginalName("CornTranNoOpenActivity")]
		CornTranNoOpenActivity,
		// Token: 0x0400B6EA RID: 46826
		[OriginalName("CornTranNoEntityConfig")]
		CornTranNoEntityConfig,
		// Token: 0x0400B6EB RID: 46827
		[OriginalName("BCARewardRepeatRewardId")]
		BcarewardRepeatRewardId,
		// Token: 0x0400B6EC RID: 46828
		[OriginalName("BCARewardDifferActivityId")]
		BcarewardDifferActivityId,
		// Token: 0x0400B6ED RID: 46829
		[OriginalName("BCTRewardNoActivity")]
		BctrewardNoActivity,
		// Token: 0x0400B6EE RID: 46830
		[OriginalName("BCTRewardIllegalRewardNum")]
		BctrewardIllegalRewardNum,
		// Token: 0x0400B6EF RID: 46831
		[OriginalName("BCTRewardNoUnlockStage")]
		BctrewardNoUnlockStage,
		// Token: 0x0400B6F0 RID: 46832
		[OriginalName("PreheatSignNodeNoConfig")]
		PreheatSignNodeNoConfig,
		// Token: 0x0400B6F1 RID: 46833
		[OriginalName("PreheatSignNodeNoData")]
		PreheatSignNodeNoData,
		// Token: 0x0400B6F2 RID: 46834
		[OriginalName("PreheatSignActivityOnOpen")]
		PreheatSignActivityOnOpen,
		// Token: 0x0400B6F3 RID: 46835
		[OriginalName("PreheatSignNodeNoUnlock")]
		PreheatSignNodeNoUnlock,
		// Token: 0x0400B6F4 RID: 46836
		[OriginalName("PreheatSignNodeNoRewardStatus")]
		PreheatSignNodeNoRewardStatus,
		// Token: 0x0400B6F5 RID: 46837
		[OriginalName("PreheatSignNodeNoAnswer")]
		PreheatSignNodeNoAnswer,
		// Token: 0x0400B6F6 RID: 46838
		[OriginalName("ScratchCardNoRoundConfig")]
		ScratchCardNoRoundConfig,
		// Token: 0x0400B6F7 RID: 46839
		[OriginalName("ScratchCardNoActivityConfig")]
		ScratchCardNoActivityConfig,
		// Token: 0x0400B6F8 RID: 46840
		[OriginalName("ScratchCardNoDbData")]
		ScratchCardNoDbData,
		// Token: 0x0400B6F9 RID: 46841
		[OriginalName("ScratchCardIllegalIndex")]
		ScratchCardIllegalIndex,
		// Token: 0x0400B6FA RID: 46842
		[OriginalName("ScratchCardIndexRewarded")]
		ScratchCardIndexRewarded,
		// Token: 0x0400B6FB RID: 46843
		[OriginalName("ScratchCardNoTime")]
		ScratchCardNoTime,
		// Token: 0x0400B6FC RID: 46844
		[OriginalName("ScratchCardNoRandomReward")]
		ScratchCardNoRandomReward,
		// Token: 0x0400B6FD RID: 46845
		[OriginalName("ScratchCardRoundNoUnlock")]
		ScratchCardRoundNoUnlock,
		// Token: 0x0400B6FE RID: 46846
		[OriginalName("BossRushPlayerNoSceneData")]
		BossRushPlayerNoSceneData,
		// Token: 0x0400B6FF RID: 46847
		[OriginalName("BossRushPlayerCanNoChooseBuff")]
		BossRushPlayerCanNoChooseBuff,
		// Token: 0x0400B700 RID: 46848
		[OriginalName("BossRushPlayerIllegalIndex")]
		BossRushPlayerIllegalIndex,
		// Token: 0x0400B701 RID: 46849
		[OriginalName("BossRushHadSameBuffId")]
		BossRushHadSameBuffId,
		// Token: 0x0400B702 RID: 46850
		[OriginalName("BossRushBuffCountLimit")]
		BossRushBuffCountLimit,
		// Token: 0x0400B703 RID: 46851
		[OriginalName("BossRushBuffIllegal")]
		BossRushBuffIllegal,
		// Token: 0x0400B704 RID: 46852
		[OriginalName("BossRushBuffNoConfig")]
		BossRushBuffNoConfig,
		// Token: 0x0400B705 RID: 46853
		[OriginalName("ScratchCardActivityNoOpen")]
		ScratchCardActivityNoOpen,
		// Token: 0x0400B706 RID: 46854
		[OriginalName("MowToweNoLevelConfig")]
		MowToweNoLevelConfig,
		// Token: 0x0400B707 RID: 46855
		[OriginalName("MowTowerActivityNoOpen")]
		MowTowerActivityNoOpen,
		// Token: 0x0400B708 RID: 46856
		[OriginalName("MowToweNoCacheData")]
		MowToweNoCacheData,
		// Token: 0x0400B709 RID: 46857
		[OriginalName("MowTowerNoPassFirstInst")]
		MowTowerNoPassFirstInst,
		// Token: 0x0400B70A RID: 46858
		[OriginalName("MowTowerLevelsIdError")]
		MowTowerLevelsIdError,
		// Token: 0x0400B70B RID: 46859
		[OriginalName("MowTowerRoleIdError")]
		MowTowerRoleIdError,
		// Token: 0x0400B70C RID: 46860
		[OriginalName("MowTowerBuffIdError")]
		MowTowerBuffIdError,
		// Token: 0x0400B70D RID: 46861
		[OriginalName("MowTowerNoComponent")]
		MowTowerNoComponent,
		// Token: 0x0400B70E RID: 46862
		[OriginalName("MowTowerHadSameRole")]
		MowTowerHadSameRole,
		// Token: 0x0400B70F RID: 46863
		[OriginalName("MowTowerBuffCountError")]
		MowTowerBuffCountError,
		// Token: 0x0400B710 RID: 46864
		[OriginalName("MowTowerNoFirstInst")]
		MowTowerNoFirstInst,
		// Token: 0x0400B711 RID: 46865
		[OriginalName("MowTowerNoActivityData")]
		MowTowerNoActivityData,
		// Token: 0x0400B712 RID: 46866
		[OriginalName("MowTowerScoreLimit")]
		MowTowerScoreLimit,
		// Token: 0x0400B713 RID: 46867
		[OriginalName("MowTowerScoreRewarded")]
		MowTowerScoreRewarded,
		// Token: 0x0400B714 RID: 46868
		[OriginalName("MowTowerScoreRewardConfig")]
		MowTowerScoreRewardConfig,
		// Token: 0x0400B715 RID: 46869
		[OriginalName("MowTowerNoInScene")]
		MowTowerNoInScene,
		// Token: 0x0400B716 RID: 46870
		[OriginalName("MowTowerNoRewardConfig")]
		MowTowerNoRewardConfig,
		// Token: 0x0400B717 RID: 46871
		[OriginalName("MaterialReplaceNoTargetConfig")]
		MaterialReplaceNoTargetConfig,
		// Token: 0x0400B718 RID: 46872
		[OriginalName("MaterialReplaceNoConsumeConfig")]
		MaterialReplaceNoConsumeConfig,
		// Token: 0x0400B719 RID: 46873
		[OriginalName("MaterialReplaceNoSameGroup")]
		MaterialReplaceNoSameGroup,
		// Token: 0x0400B71A RID: 46874
		[OriginalName("MaterialReplaceErrConsumeNum")]
		MaterialReplaceErrConsumeNum,
		// Token: 0x0400B71B RID: 46875
		[OriginalName("ErrRoleSkinTrialNotInit")]
		ErrRoleSkinTrialNotInit,
		// Token: 0x0400B71C RID: 46876
		[OriginalName("ErrRoleSkinTrialNoFinish")]
		ErrRoleSkinTrialNoFinish,
		// Token: 0x0400B71D RID: 46877
		[OriginalName("ErrRoleSkinTrialReward")]
		ErrRoleSkinTrialReward,
		// Token: 0x0400B71E RID: 46878
		[OriginalName("ErrRoleSkinTrialRewardDone")]
		ErrRoleSkinTrialRewardDone,
		// Token: 0x0400B71F RID: 46879
		[OriginalName("ErrRoleSkinTrialTimeOut")]
		ErrRoleSkinTrialTimeOut,
		// Token: 0x0400B720 RID: 46880
		[OriginalName("PhantomEquipGroupNoEquipPhantom")]
		PhantomEquipGroupNoEquipPhantom,
		// Token: 0x0400B721 RID: 46881
		[OriginalName("PhantomEquipGroupCountLimit")]
		PhantomEquipGroupCountLimit,
		// Token: 0x0400B722 RID: 46882
		[OriginalName("PhantomEquipGroupHadInTop")]
		PhantomEquipGroupHadInTop,
		// Token: 0x0400B723 RID: 46883
		[OriginalName("PhantomEquipGroupNameEmpty")]
		PhantomEquipGroupNameEmpty,
		// Token: 0x0400B724 RID: 46884
		[OriginalName("PhantomEquipGroupNameCountLimiy")]
		PhantomEquipGroupNameCountLimiy,
		// Token: 0x0400B725 RID: 46885
		[OriginalName("PhantomRecommendFuncNoOpen")]
		PhantomRecommendFuncNoOpen,
		// Token: 0x0400B726 RID: 46886
		[OriginalName("BossRushTaskNoFinish")]
		BossRushTaskNoFinish,
		// Token: 0x0400B727 RID: 46887
		[OriginalName("PhantomGroupUseSame")]
		PhantomGroupUseSame,
		// Token: 0x0400B728 RID: 46888
		[OriginalName("PhantomGroupFunNoOpen")]
		PhantomGroupFunNoOpen,
		// Token: 0x0400B729 RID: 46889
		[OriginalName("NoFishingActivityConfig")]
		NoFishingActivityConfig,
		// Token: 0x0400B72A RID: 46890
		[OriginalName("NoInFishingActivityTime")]
		NoInFishingActivityTime,
		// Token: 0x0400B72B RID: 46891
		[OriginalName("FishingActivityCanNoReward")]
		FishingActivityCanNoReward,
		// Token: 0x0400B72C RID: 46892
		[OriginalName("NoFishingActivityMileConfig")]
		NoFishingActivityMileConfig,
		// Token: 0x0400B72D RID: 46893
		[OriginalName("FishingActivitySameMileId")]
		FishingActivitySameMileId,
		// Token: 0x0400B72E RID: 46894
		[OriginalName("FishingActivityRewarded")]
		FishingActivityRewarded,
		// Token: 0x0400B72F RID: 46895
		[OriginalName("PlayerTitleFuncNoOpen")]
		PlayerTitleFuncNoOpen,
		// Token: 0x0400B730 RID: 46896
		[OriginalName("PlayerTitleHadUndress")]
		PlayerTitleHadUndress,
		// Token: 0x0400B731 RID: 46897
		[OriginalName("PlayerTitleHadDress")]
		PlayerTitleHadDress,
		// Token: 0x0400B732 RID: 46898
		[OriginalName("PlayerTitleNoUnlock")]
		PlayerTitleNoUnlock,
		// Token: 0x0400B733 RID: 46899
		[OriginalName("BabelTowerActivityNoOpen")]
		BabelTowerActivityNoOpen,
		// Token: 0x0400B734 RID: 46900
		[OriginalName("BabelTowerLevelNoOpen")]
		BabelTowerLevelNoOpen,
		// Token: 0x0400B735 RID: 46901
		[OriginalName("BabelTowerDeEffectNoFind")]
		BabelTowerDeEffectNoFind,
		// Token: 0x0400B736 RID: 46902
		[OriginalName("BabelTowerDeEffectCanNoChoose")]
		BabelTowerDeEffectCanNoChoose,
		// Token: 0x0400B737 RID: 46903
		[OriginalName("BabelTowerDeEffectMutex")]
		BabelTowerDeEffectMutex,
		// Token: 0x0400B738 RID: 46904
		[OriginalName("BabelTowerNoDailyTask")]
		BabelTowerNoDailyTask,
		// Token: 0x0400B739 RID: 46905
		[OriginalName("BabelTowerTaskNoComplete")]
		BabelTowerTaskNoComplete,
		// Token: 0x0400B73A RID: 46906
		[OriginalName("BabelTowerTaskRewarded")]
		BabelTowerTaskRewarded,
		// Token: 0x0400B73B RID: 46907
		[OriginalName("BabelTowerRoleLimit")]
		BabelTowerRoleLimit,
		// Token: 0x0400B73C RID: 46908
		[OriginalName("BabelTowerNoBuffConfig")]
		BabelTowerNoBuffConfig,
		// Token: 0x0400B73D RID: 46909
		[OriginalName("BabelTowerBuffCanNoChoose")]
		BabelTowerBuffCanNoChoose,
		// Token: 0x0400B73E RID: 46910
		[OriginalName("BabelTowerBuffNumIllegal")]
		BabelTowerBuffNumIllegal,
		// Token: 0x0400B73F RID: 46911
		[OriginalName("BabelTowerBuffChooseCountLimit")]
		BabelTowerBuffChooseCountLimit,
		// Token: 0x0400B740 RID: 46912
		[OriginalName("NoBabelTowerInsComponent")]
		NoBabelTowerInsComponent,
		// Token: 0x0400B741 RID: 46913
		[OriginalName("BabelTowerNoSelectBuff")]
		BabelTowerNoSelectBuff,
		// Token: 0x0400B742 RID: 46914
		[OriginalName("PhantomPolishFuncNoOpen")]
		PhantomPolishFuncNoOpen,
		// Token: 0x0400B743 RID: 46915
		[OriginalName("PhantomPolishHadLevelUp")]
		PhantomPolishHadLevelUp,
		// Token: 0x0400B744 RID: 46916
		[OriginalName("PhantomPolishQualityLimit")]
		PhantomPolishQualityLimit,
		// Token: 0x0400B745 RID: 46917
		[OriginalName("PhantomPolishSamePro")]
		PhantomPolishSamePro,
		// Token: 0x0400B746 RID: 46918
		[OriginalName("ExploreActivityNoOpen")]
		ExploreActivityNoOpen,
		// Token: 0x0400B747 RID: 46919
		[OriginalName("ExploreActivityTaskNoFinish")]
		ExploreActivityTaskNoFinish,
		// Token: 0x0400B748 RID: 46920
		[OriginalName("ExploreActivityTaskRewarded")]
		ExploreActivityTaskRewarded,
		// Token: 0x0400B749 RID: 46921
		[OriginalName("BabelTowerDeTermNoUnlock")]
		BabelTowerDeTermNoUnlock,
		// Token: 0x0400B74A RID: 46922
		[OriginalName("BabelTowerBuffNoUnlock")]
		BabelTowerBuffNoUnlock,
		// Token: 0x0400B74B RID: 46923
		[OriginalName("BabelTowerIsNoDifficult")]
		BabelTowerIsNoDifficult,
		// Token: 0x0400B74C RID: 46924
		[OriginalName("PlayerTitleNoConfig")]
		PlayerTitleNoConfig,
		// Token: 0x0400B74D RID: 46925
		[OriginalName("PlayerFixIndexIllegal")]
		PlayerFixIndexIllegal,
		// Token: 0x0400B74E RID: 46926
		[OriginalName("PlayerFixHadFlag")]
		PlayerFixHadFlag,
		// Token: 0x0400B74F RID: 46927
		[OriginalName("PlayerFixFrontNoFlag")]
		PlayerFixFrontNoFlag,
		// Token: 0x0400B750 RID: 46928
		[OriginalName("BabelTowerNoSelectRoles")]
		BabelTowerNoSelectRoles,
		// Token: 0x0400B751 RID: 46929
		[OriginalName("PhBaErrSelectNum")]
		PhBaErrSelectNum,
		// Token: 0x0400B752 RID: 46930
		[OriginalName("PhBaErrSelectTarget")]
		PhBaErrSelectTarget,
		// Token: 0x0400B753 RID: 46931
		[OriginalName("PhBaNoFighterLogic")]
		PhBaNoFighterLogic,
		// Token: 0x0400B754 RID: 46932
		[OriginalName("PhBaNoChallengeConf")]
		PhBaNoChallengeConf,
		// Token: 0x0400B755 RID: 46933
		[OriginalName("PhBaSlotIllegal")]
		PhBaSlotIllegal,
		// Token: 0x0400B756 RID: 46934
		[OriginalName("PhBaNoEvolveNum")]
		PhBaNoEvolveNum,
		// Token: 0x0400B757 RID: 46935
		[OriginalName("PhBaNoFighter")]
		PhBaNoFighter,
		// Token: 0x0400B758 RID: 46936
		[OriginalName("PhBaNoHandCard")]
		PhBaNoHandCard,
		// Token: 0x0400B759 RID: 46937
		[OriginalName("PhBaNoCardConf")]
		PhBaNoCardConf,
		// Token: 0x0400B75A RID: 46938
		[OriginalName("PhBaNoCardEvolveCountInValid")]
		PhBaNoCardEvolveCountInValid,
		// Token: 0x0400B75B RID: 46939
		[OriginalName("PhBaErrCostNoMatch")]
		PhBaErrCostNoMatch,
		// Token: 0x0400B75C RID: 46940
		[OriginalName("PhBaNoCardRoleConf")]
		PhBaNoCardRoleConf,
		// Token: 0x0400B75D RID: 46941
		[OriginalName("PhBaNoContainSkill")]
		PhBaNoContainSkill,
		// Token: 0x0400B75E RID: 46942
		[OriginalName("PhBaNoSkillConf")]
		PhBaNoSkillConf,
		// Token: 0x0400B75F RID: 46943
		[OriginalName("PhBaNoCardCanNoUse")]
		PhBaNoCardCanNoUse,
		// Token: 0x0400B760 RID: 46944
		[OriginalName("PhBaIsWaitClient")]
		PhBaIsWaitClient,
		// Token: 0x0400B761 RID: 46945
		[OriginalName("PhBaNoDeployRound")]
		PhBaNoDeployRound,
		// Token: 0x0400B762 RID: 46946
		[OriginalName("PhBaNoClientParam")]
		PhBaNoClientParam,
		// Token: 0x0400B763 RID: 46947
		[OriginalName("PhBaNoClientParamMatch")]
		PhBaNoClientParamMatch,
		// Token: 0x0400B764 RID: 46948
		[OriginalName("PhBaErrSelectCardNum")]
		PhBaErrSelectCardNum,
		// Token: 0x0400B765 RID: 46949
		[OriginalName("PhBaErrSelectReplace")]
		PhBaErrSelectReplace,
		// Token: 0x0400B766 RID: 46950
		[OriginalName("PhBaErrPreStep")]
		PhBaErrPreStep,
		// Token: 0x0400B767 RID: 46951
		[OriginalName("PhBaCanNoSelect")]
		PhBaCanNoSelect,
		// Token: 0x0400B768 RID: 46952
		[OriginalName("PhBaConditionLimit")]
		PhBaConditionLimit,
		// Token: 0x0400B769 RID: 46953
		[OriginalName("PhBaNoOwnerFighter")]
		PhBaNoOwnerFighter,
		// Token: 0x0400B76A RID: 46954
		[OriginalName("PhBaNoTriggerFighter")]
		PhBaNoTriggerFighter,
		// Token: 0x0400B76B RID: 46955
		[OriginalName("PhBaSelectParamNull")]
		PhBaSelectParamNull,
		// Token: 0x0400B76C RID: 46956
		[OriginalName("PhBaNoBuffData")]
		PhBaNoBuffData,
		// Token: 0x0400B76D RID: 46957
		[OriginalName("PhBaNoBuffConf")]
		PhBaNoBuffConf,
		// Token: 0x0400B76E RID: 46958
		[OriginalName("PhBaErrCardGroupIndex")]
		PhBaErrCardGroupIndex,
		// Token: 0x0400B76F RID: 46959
		[OriginalName("PhBaCardRoleUnlock")]
		PhBaCardRoleUnlock,
		// Token: 0x0400B770 RID: 46960
		[OriginalName("PhBaNoCardGroupConf")]
		PhBaNoCardGroupConf,
		// Token: 0x0400B771 RID: 46961
		[OriginalName("PhBaSloFull")]
		PhBaSloFull,
		// Token: 0x0400B772 RID: 46962
		[OriginalName("PhBaHandCardEmpty")]
		PhBaHandCardEmpty,
		// Token: 0x0400B773 RID: 46963
		[OriginalName("PbSelectCardNotFound")]
		PbSelectCardNotFound,
		// Token: 0x0400B774 RID: 46964
		[OriginalName("PbSelectCardCount")]
		PbSelectCardCount,
		// Token: 0x0400B775 RID: 46965
		[OriginalName("PbNoNpcFighter")]
		PbNoNpcFighter,
		// Token: 0x0400B776 RID: 46966
		[OriginalName("PbNoPlayerFighter")]
		PbNoPlayerFighter,
		// Token: 0x0400B777 RID: 46967
		[OriginalName("PbBTEventDataIllegal")]
		PbBteventDataIllegal,
		// Token: 0x0400B778 RID: 46968
		[OriginalName("PbNoCardFighter")]
		PbNoCardFighter,
		// Token: 0x0400B779 RID: 46969
		[OriginalName("PbNoHandCardVarData")]
		PbNoHandCardVarData,
		// Token: 0x0400B77A RID: 46970
		[OriginalName("PbNoPosVarData")]
		PbNoPosVarData,
		// Token: 0x0400B77B RID: 46971
		[OriginalName("PbNoHandCard")]
		PbNoHandCard,
		// Token: 0x0400B77C RID: 46972
		[OriginalName("PbNoCardFighterVarData")]
		PbNoCardFighterVarData,
		// Token: 0x0400B77D RID: 46973
		[OriginalName("PbNoNpcConfig")]
		PbNoNpcConfig,
		// Token: 0x0400B77E RID: 46974
		[OriginalName("PbNoCostPoint")]
		PbNoCostPoint,
		// Token: 0x0400B77F RID: 46975
		[OriginalName("PbNoActiveSkill")]
		PbNoActiveSkill,
		// Token: 0x0400B780 RID: 46976
		[OriginalName("PbErrSelectTargets")]
		PbErrSelectTargets,
		// Token: 0x0400B781 RID: 46977
		[OriginalName("PbErrHadFighter")]
		PbErrHadFighter,
		// Token: 0x0400B782 RID: 46978
		[OriginalName("PbErrCardUnmovable")]
		PbErrCardUnmovable,
		// Token: 0x0400B783 RID: 46979
		[OriginalName("PbNoCanSelectTarget")]
		PbNoCanSelectTarget,
		// Token: 0x0400B784 RID: 46980
		[OriginalName("PbCanNotOpOtherUnit")]
		PbCanNotOpOtherUnit,
		// Token: 0x0400B785 RID: 46981
		[OriginalName("PbCanNoBeEvolve")]
		PbCanNoBeEvolve,
		// Token: 0x0400B786 RID: 46982
		[OriginalName("PbKeyCostCanNotOp")]
		PbKeyCostCanNotOp,
		// Token: 0x0400B787 RID: 46983
		[OriginalName("PbNoReChallenge")]
		PbNoReChallenge,
		// Token: 0x0400B788 RID: 46984
		[OriginalName("PbFuncNoOpen")]
		PbFuncNoOpen,
		// Token: 0x0400B789 RID: 46985
		[OriginalName("PbNoRequestReChallenge")]
		PbNoRequestReChallenge,
		// Token: 0x0400B78A RID: 46986
		[OriginalName("PbNoSameSlotIndex")]
		PbNoSameSlotIndex,
		// Token: 0x0400B78B RID: 46987
		[OriginalName("PhBaHaCardEmpty")]
		PhBaHaCardEmpty,
		// Token: 0x0400B78C RID: 46988
		[OriginalName("PhBaPassedChallenge")]
		PhBaPassedChallenge,
		// Token: 0x0400B78D RID: 46989
		[OriginalName("FunPlayNoConfig")]
		FunPlayNoConfig,
		// Token: 0x0400B78E RID: 46990
		[OriginalName("FunPlayNoFinish")]
		FunPlayNoFinish,
		// Token: 0x0400B78F RID: 46991
		[OriginalName("FunPlayHadRewarded")]
		FunPlayHadRewarded,
		// Token: 0x0400B790 RID: 46992
		[OriginalName("PbCardSkillCountLimit")]
		PbCardSkillCountLimit,
		// Token: 0x0400B791 RID: 46993
		[OriginalName("BabelRoleIsSelected")]
		BabelRoleIsSelected = 2500248,
		// Token: 0x0400B792 RID: 46994
		[OriginalName("BabelNoTalentConfig")]
		BabelNoTalentConfig,
		// Token: 0x0400B793 RID: 46995
		[OriginalName("BabelInnerCanNoOpe")]
		BabelInnerCanNoOpe,
		// Token: 0x0400B794 RID: 46996
		[OriginalName("BabelTalentIsLearned")]
		BabelTalentIsLearned,
		// Token: 0x0400B795 RID: 46997
		[OriginalName("BabelTalentNoFinish")]
		BabelTalentNoFinish,
		// Token: 0x0400B796 RID: 46998
		[OriginalName("BabelNoActivityConfig")]
		BabelNoActivityConfig,
		// Token: 0x0400B797 RID: 46999
		[OriginalName("BabelRankListInCd")]
		BabelRankListInCd,
		// Token: 0x0400B798 RID: 47000
		[OriginalName("FunPlayDayNoOpen")]
		FunPlayDayNoOpen,
		// Token: 0x0400B799 RID: 47001
		[OriginalName("CheckShopConditionFail")]
		CheckShopConditionFail = 2500262,
		// Token: 0x0400B79A RID: 47002
		[OriginalName("HonamiStoryBagUpdateRepeat")]
		HonamiStoryBagUpdateRepeat,
		// Token: 0x0400B79B RID: 47003
		[OriginalName("HonamiStoryBagNoConfig")]
		HonamiStoryBagNoConfig,
		// Token: 0x0400B79C RID: 47004
		[OriginalName("HonamiStoryNormalAddItemErr")]
		HonamiStoryNormalAddItemErr,
		// Token: 0x0400B79D RID: 47005
		[OriginalName("HonamiStoryNoBagDb")]
		HonamiStoryNoBagDb,
		// Token: 0x0400B79E RID: 47006
		[OriginalName("HonamiStoryUpdateItemSizeIllegal")]
		HonamiStoryUpdateItemSizeIllegal,
		// Token: 0x0400B79F RID: 47007
		[OriginalName("HonamiStoryItemUpdateRepeat")]
		HonamiStoryItemUpdateRepeat,
		// Token: 0x0400B7A0 RID: 47008
		[OriginalName("HonamiStoryBagHadItem")]
		HonamiStoryBagHadItem,
		// Token: 0x0400B7A1 RID: 47009
		[OriginalName("HonamiStoryBagPosIllegal")]
		HonamiStoryBagPosIllegal,
		// Token: 0x0400B7A2 RID: 47010
		[OriginalName("HonamiStoryItemUpdateTypeErr")]
		HonamiStoryItemUpdateTypeErr,
		// Token: 0x0400B7A3 RID: 47011
		[OriginalName("HonamiStoryBagNoHadItem")]
		HonamiStoryBagNoHadItem,
		// Token: 0x0400B7A4 RID: 47012
		[OriginalName("HonamiStoryDropItemNoEntityId")]
		HonamiStoryDropItemNoEntityId,
		// Token: 0x0400B7A5 RID: 47013
		[OriginalName("HonamiStoryDropItemNoEntity")]
		HonamiStoryDropItemNoEntity,
		// Token: 0x0400B7A6 RID: 47014
		[OriginalName("HonamiStoryNoDropEntity")]
		HonamiStoryNoDropEntity,
		// Token: 0x0400B7A7 RID: 47015
		[OriginalName("HonamiStoryDropNoItemDb")]
		HonamiStoryDropNoItemDb,
		// Token: 0x0400B7A8 RID: 47016
		[OriginalName("HonamiStoryItemNoBalance")]
		HonamiStoryItemNoBalance,
		// Token: 0x0400B7A9 RID: 47017
		[OriginalName("HonamiStoryNoUpdateItem")]
		HonamiStoryNoUpdateItem,
		// Token: 0x0400B7AA RID: 47018
		[OriginalName("HonamiStoryCheckMarkNoItemConfig")]
		HonamiStoryCheckMarkNoItemConfig,
		// Token: 0x0400B7AB RID: 47019
		[OriginalName("HonamiStoryCheckMarkOverSize")]
		HonamiStoryCheckMarkOverSize,
		// Token: 0x0400B7AC RID: 47020
		[OriginalName("HonamiStoryCheckWideOverSize")]
		HonamiStoryCheckWideOverSize,
		// Token: 0x0400B7AD RID: 47021
		[OriginalName("HonamiStoryCheckMarkRepeat")]
		HonamiStoryCheckMarkRepeat,
		// Token: 0x0400B7AE RID: 47022
		[OriginalName("HonamiStoryActivityNoSame")]
		HonamiStoryActivityNoSame,
		// Token: 0x0400B7AF RID: 47023
		[OriginalName("HonamiStoryNoEquipRackData")]
		HonamiStoryNoEquipRackData,
		// Token: 0x0400B7B0 RID: 47024
		[OriginalName("HonamiStoryNoEquipType")]
		HonamiStoryNoEquipType,
		// Token: 0x0400B7B1 RID: 47025
		[OriginalName("HonamiStoryNoEquipConfig")]
		HonamiStoryNoEquipConfig,
		// Token: 0x0400B7B2 RID: 47026
		[OriginalName("HonamiStoryNoEquipTypeNoMatch")]
		HonamiStoryNoEquipTypeNoMatch,
		// Token: 0x0400B7B3 RID: 47027
		[OriginalName("HonamiStoryActivityIdErr")]
		HonamiStoryActivityIdErr,
		// Token: 0x0400B7B4 RID: 47028
		[OriginalName("HonamiStoryInnerCanNoModifyRole")]
		HonamiStoryInnerCanNoModifyRole,
		// Token: 0x0400B7B5 RID: 47029
		[OriginalName("HonamiStoryRoleNoValid")]
		HonamiStoryRoleNoValid,
		// Token: 0x0400B7B6 RID: 47030
		[OriginalName("HonamiStoryNoChallengeConfig")]
		HonamiStoryNoChallengeConfig,
		// Token: 0x0400B7B7 RID: 47031
		[OriginalName("NoHonamiStoryInstType")]
		NoHonamiStoryInstType,
		// Token: 0x0400B7B8 RID: 47032
		[OriginalName("HonamiStoryNoItemConfig")]
		HonamiStoryNoItemConfig,
		// Token: 0x0400B7B9 RID: 47033
		[OriginalName("HonamiStoryPickDistanceErr")]
		HonamiStoryPickDistanceErr,
		// Token: 0x0400B7BA RID: 47034
		[OriginalName("HonamiStoryNoDressWeapon")]
		HonamiStoryNoDressWeapon,
		// Token: 0x0400B7BB RID: 47035
		[OriginalName("HonamiStoryNoWeaponConfig")]
		HonamiStoryNoWeaponConfig,
		// Token: 0x0400B7BC RID: 47036
		[OriginalName("HonamiStoryWeaponPluginPosErr")]
		HonamiStoryWeaponPluginPosErr,
		// Token: 0x0400B7BD RID: 47037
		[OriginalName("HonamiStoryWeaponPluginTypeNoMatch")]
		HonamiStoryWeaponPluginTypeNoMatch,
		// Token: 0x0400B7BE RID: 47038
		[OriginalName("HonamiStoryWareHouseOverSize")]
		HonamiStoryWareHouseOverSize,
		// Token: 0x0400B7BF RID: 47039
		[OriginalName("HonamiStoryNoOpenSafeBag")]
		HonamiStoryNoOpenSafeBag,
		// Token: 0x0400B7C0 RID: 47040
		[OriginalName("HonamiStoryNoOpenSafeBagItem")]
		HonamiStoryNoOpenSafeBagItem,
		// Token: 0x0400B7C1 RID: 47041
		[OriginalName("HonamiStoryBagTypeNoMatch")]
		HonamiStoryBagTypeNoMatch,
		// Token: 0x0400B7C2 RID: 47042
		[OriginalName("HonamiStoryWeaponPluginNoUnDress")]
		HonamiStoryWeaponPluginNoUnDress,
		// Token: 0x0400B7C3 RID: 47043
		[OriginalName("HonamiStoryChangeItemPosSame")]
		HonamiStoryChangeItemPosSame,
		// Token: 0x0400B7C4 RID: 47044
		[OriginalName("HonamiStoryEquipPosError")]
		HonamiStoryEquipPosError,
		// Token: 0x0400B7C5 RID: 47045
		[OriginalName("HonamiStoryEquipPosRepeat")]
		HonamiStoryEquipPosRepeat,
		// Token: 0x0400B7C6 RID: 47046
		[OriginalName("HonamiStoryOriPosErr")]
		HonamiStoryOriPosErr,
		// Token: 0x0400B7C7 RID: 47047
		[OriginalName("HonamiStoryInstCanNoOpe")]
		HonamiStoryInstCanNoOpe,
		// Token: 0x0400B7C8 RID: 47048
		[OriginalName("HonamiStoryIsRewarded")]
		HonamiStoryIsRewarded,
		// Token: 0x0400B7C9 RID: 47049
		[OriginalName("HonamiStoryNoFinish")]
		HonamiStoryNoFinish,
		// Token: 0x0400B7CA RID: 47050
		[OriginalName("HonamiStoryNoConfig")]
		HonamiStoryNoConfig,
		// Token: 0x0400B7CB RID: 47051
		[OriginalName("HonamiStoryHadActivateTalent")]
		HonamiStoryHadActivateTalent,
		// Token: 0x0400B7CC RID: 47052
		[OriginalName("HonamiStoryIsUnlocked")]
		HonamiStoryIsUnlocked,
		// Token: 0x0400B7CD RID: 47053
		[OriginalName("HonamiStoryItemCanNoSell")]
		HonamiStoryItemCanNoSell,
		// Token: 0x0400B7CE RID: 47054
		[OriginalName("HonamiStoryRewardRepeat")]
		HonamiStoryRewardRepeat,
		// Token: 0x0400B7CF RID: 47055
		[OriginalName("HonamiStoryInstHadFinish")]
		HonamiStoryInstHadFinish,
		// Token: 0x0400B7D0 RID: 47056
		[OriginalName("HonamiStoryLifeSupportFullLevel")]
		HonamiStoryLifeSupportFullLevel,
		// Token: 0x0400B7D1 RID: 47057
		[OriginalName("HonamiStoryDangerLevelIllegal")]
		HonamiStoryDangerLevelIllegal,
		// Token: 0x0400B7D2 RID: 47058
		[OriginalName("HonamiStoryWeaponHadDress")]
		HonamiStoryWeaponHadDress,
		// Token: 0x0400B7D3 RID: 47059
		[OriginalName("HonamiStoryItemIsLock")]
		HonamiStoryItemIsLock,
		// Token: 0x0400B7D4 RID: 47060
		[OriginalName("HonamiStoryFunNoOpen")]
		HonamiStoryFunNoOpen,
		// Token: 0x0400B7D5 RID: 47061
		[OriginalName("HonamiStoryHadSafeLeave")]
		HonamiStoryHadSafeLeave,
		// Token: 0x0400B7D6 RID: 47062
		[OriginalName("HonamiStoryInTop")]
		HonamiStoryInTop,
		// Token: 0x0400B7D7 RID: 47063
		[OriginalName("HonamiStoryAreaNoUnlock")]
		HonamiStoryAreaNoUnlock,
		// Token: 0x0400B7D8 RID: 47064
		[OriginalName("HonamiStoryPreSlotUnlock")]
		HonamiStoryPreSlotUnlock,
		// Token: 0x0400B7D9 RID: 47065
		[OriginalName("TotalTopUpNoActivityConfig")]
		TotalTopUpNoActivityConfig,
		// Token: 0x0400B7DA RID: 47066
		[OriginalName("TotalTopUpNoFinish")]
		TotalTopUpNoFinish,
		// Token: 0x0400B7DB RID: 47067
		[OriginalName("TotalTopUpRewarded")]
		TotalTopUpRewarded,
		// Token: 0x0400B7DC RID: 47068
		[OriginalName("TotalTopUpRoleFullChain")]
		TotalTopUpRoleFullChain,
		// Token: 0x0400B7DD RID: 47069
		[OriginalName("WeekCardUseRepeat")]
		WeekCardUseRepeat,
		// Token: 0x0400B7DE RID: 47070
		[OriginalName("WeekCardNoConfig")]
		WeekCardNoConfig,
		// Token: 0x0400B7DF RID: 47071
		[OriginalName("WeekCardNoActive")]
		WeekCardNoActive,
		// Token: 0x0400B7E0 RID: 47072
		[OriginalName("WeekCardCanNoReward")]
		WeekCardCanNoReward,
		// Token: 0x0400B7E1 RID: 47073
		[OriginalName("WeekCardRewarded")]
		WeekCardRewarded,
		// Token: 0x0400B7E2 RID: 47074
		[OriginalName("WeekCardNoEffect")]
		WeekCardNoEffect,
		// Token: 0x0400B7E3 RID: 47075
		[OriginalName("FlagChallengeTaskNoFinish")]
		FlagChallengeTaskNoFinish,
		// Token: 0x0400B7E4 RID: 47076
		[OriginalName("FlagChallengeNoConfig")]
		FlagChallengeNoConfig,
		// Token: 0x0400B7E5 RID: 47077
		[OriginalName("FlagChallengeTaskRewarded")]
		FlagChallengeTaskRewarded,
		// Token: 0x0400B7E6 RID: 47078
		[OriginalName("FlagChallengeRewardRepeat")]
		FlagChallengeRewardRepeat,
		// Token: 0x0400B7E7 RID: 47079
		[OriginalName("FlagChallengeNoUnlock")]
		FlagChallengeNoUnlock,
		// Token: 0x0400B7E8 RID: 47080
		[OriginalName("FeiXuePreheatNoFinish")]
		FeiXuePreheatNoFinish,
		// Token: 0x0400B7E9 RID: 47081
		[OriginalName("FeiXuePreheatNoConfig")]
		FeiXuePreheatNoConfig,
		// Token: 0x0400B7EA RID: 47082
		[OriginalName("FeiXuePreheatRewarded")]
		FeiXuePreheatRewarded,
		// Token: 0x0400B7EB RID: 47083
		[OriginalName("FeiXuePreheatRewardRepeat")]
		FeiXuePreheatRewardRepeat,
		// Token: 0x0400B7EC RID: 47084
		[OriginalName("ErrOrnamentConfig")]
		ErrOrnamentConfig,
		// Token: 0x0400B7ED RID: 47085
		[OriginalName("ErrOrnamentLocked")]
		ErrOrnamentLocked,
		// Token: 0x0400B7EE RID: 47086
		[OriginalName("ErrOrnamentDressed")]
		ErrOrnamentDressed,
		// Token: 0x0400B7EF RID: 47087
		[OriginalName("ErrOrnamentCanNoDress")]
		ErrOrnamentCanNoDress,
		// Token: 0x0400B7F0 RID: 47088
		[OriginalName("ErrOrnamentNoDress")]
		ErrOrnamentNoDress,
		// Token: 0x0400B7F1 RID: 47089
		[OriginalName("BossPilingTaskNoFinish")]
		BossPilingTaskNoFinish,
		// Token: 0x0400B7F2 RID: 47090
		[OriginalName("BossPilingNoConfig")]
		BossPilingNoConfig,
		// Token: 0x0400B7F3 RID: 47091
		[OriginalName("BossPilingTaskRewarded")]
		BossPilingTaskRewarded,
		// Token: 0x0400B7F4 RID: 47092
		[OriginalName("BossPilingRewardRepeat")]
		BossPilingRewardRepeat,
		// Token: 0x0400B7F5 RID: 47093
		[OriginalName("BossPilingNoUnlock")]
		BossPilingNoUnlock,
		// Token: 0x0400B7F6 RID: 47094
		[OriginalName("FlagChallengePassed")]
		FlagChallengePassed,
		// Token: 0x0400B7F7 RID: 47095
		[OriginalName("BossPilingFirstNoFinish")]
		BossPilingFirstNoFinish,
		// Token: 0x0400B7F8 RID: 47096
		[OriginalName("BossPilingRoleErr")]
		BossPilingRoleErr,
		// Token: 0x0400B7F9 RID: 47097
		[OriginalName("GachaAccumulateNoConfig")]
		GachaAccumulateNoConfig,
		// Token: 0x0400B7FA RID: 47098
		[OriginalName("GachaAccumulateNoInTime")]
		GachaAccumulateNoInTime,
		// Token: 0x0400B7FB RID: 47099
		[OriginalName("GachaAccumulateRewarded")]
		GachaAccumulateRewarded,
		// Token: 0x0400B7FC RID: 47100
		[OriginalName("GachaAccumulateNoFinish")]
		GachaAccumulateNoFinish,
		// Token: 0x0400B7FD RID: 47101
		[OriginalName("GachaAccumulateErrSelectParam")]
		GachaAccumulateErrSelectParam,
		// Token: 0x0400B7FE RID: 47102
		[OriginalName("RequestParamRepeat")]
		RequestParamRepeat,
		// Token: 0x0400B7FF RID: 47103
		[OriginalName("BossPilingActivityNoOpen")]
		BossPilingActivityNoOpen,
		// Token: 0x0400B800 RID: 47104
		[OriginalName("BossPilingErrMultiGame")]
		BossPilingErrMultiGame,
		// Token: 0x0400B801 RID: 47105
		[OriginalName("SheriffNoConfig")]
		SheriffNoConfig,
		// Token: 0x0400B802 RID: 47106
		[OriginalName("SheriffActivityNoOpen")]
		SheriffActivityNoOpen,
		// Token: 0x0400B803 RID: 47107
		[OriginalName("SheriffFuncNotOpen")]
		SheriffFuncNotOpen,
		// Token: 0x0400B804 RID: 47108
		[OriginalName("SheriffClueNotUnlock")]
		SheriffClueNotUnlock,
		// Token: 0x0400B805 RID: 47109
		[OriginalName("SheriffEndingAlreadyFinish")]
		SheriffEndingAlreadyFinish,
		// Token: 0x0400B806 RID: 47110
		[OriginalName("ErrGiftResonantChainOptionalLimit")]
		ErrGiftResonantChainOptionalLimit,
		// Token: 0x0400B807 RID: 47111
		[OriginalName("DangoBrawlNoConfig")]
		DangoBrawlNoConfig,
		// Token: 0x0400B808 RID: 47112
		[OriginalName("DangoBrawlErrMultiGame")]
		DangoBrawlErrMultiGame,
		// Token: 0x0400B809 RID: 47113
		[OriginalName("DangoBrawlRoleErr")]
		DangoBrawlRoleErr,
		// Token: 0x0400B80A RID: 47114
		[OriginalName("DangoBrawlNoComponent")]
		DangoBrawlNoComponent,
		// Token: 0x0400B80B RID: 47115
		[OriginalName("DangoBrawlSceneStateErr")]
		DangoBrawlSceneStateErr,
		// Token: 0x0400B80C RID: 47116
		[OriginalName("DangoBrawlCoinNotEnough")]
		DangoBrawlCoinNotEnough,
		// Token: 0x0400B80D RID: 47117
		[OriginalName("DangoBrawlShopSlotErr")]
		DangoBrawlShopSlotErr,
		// Token: 0x0400B80E RID: 47118
		[OriginalName("DangoBrawlBagOpTypeErr")]
		DangoBrawlBagOpTypeErr,
		// Token: 0x0400B80F RID: 47119
		[OriginalName("DangoBrawlBagItemNotFound")]
		DangoBrawlBagItemNotFound,
		// Token: 0x0400B810 RID: 47120
		[OriginalName("DangoBrawlBagSlotErr")]
		DangoBrawlBagSlotErr,
		// Token: 0x0400B811 RID: 47121
		[OriginalName("DangoBrawlBagSlotOccupied")]
		DangoBrawlBagSlotOccupied,
		// Token: 0x0400B812 RID: 47122
		[OriginalName("DangoBrawlBagOpDuplicateUid")]
		DangoBrawlBagOpDuplicateUid,
		// Token: 0x0400B813 RID: 47123
		[OriginalName("DangoBrawlComposeNoRecipe")]
		DangoBrawlComposeNoRecipe,
		// Token: 0x0400B814 RID: 47124
		[OriginalName("DangoBrawlSpeItemLimit")]
		DangoBrawlSpeItemLimit,
		// Token: 0x0400B815 RID: 47125
		[OriginalName("DangoBrawlCostOverLimit")]
		DangoBrawlCostOverLimit,
		// Token: 0x0400B816 RID: 47126
		[OriginalName("DangoBrawlBenchFull")]
		DangoBrawlBenchFull,
		// Token: 0x0400B817 RID: 47127
		[OriginalName("CreateCharacterNoContext")]
		CreateCharacterNoContext,
		// Token: 0x0400B818 RID: 47128
		[OriginalName("CreateCharacterStateErr")]
		CreateCharacterStateErr,
		// Token: 0x0400B819 RID: 47129
		[OriginalName("CreateCharacterFlagErr")]
		CreateCharacterFlagErr,
		// Token: 0x0400B81A RID: 47130
		[OriginalName("ErrAlertAreaId")]
		ErrAlertAreaId = 2600000,
		// Token: 0x0400B81B RID: 47131
		[OriginalName("ErrAlertAreaEnable")]
		ErrAlertAreaEnable,
		// Token: 0x0400B81C RID: 47132
		[OriginalName("ErrAlertAreaDisable")]
		ErrAlertAreaDisable,
		// Token: 0x0400B81D RID: 47133
		[OriginalName("ErrAlertUiEnable")]
		ErrAlertUiEnable,
		// Token: 0x0400B81E RID: 47134
		[OriginalName("ErrAlertUiDisable")]
		ErrAlertUiDisable,
		// Token: 0x0400B81F RID: 47135
		[OriginalName("ErrAlertUiVisible")]
		ErrAlertUiVisible,
		// Token: 0x0400B820 RID: 47136
		[OriginalName("ErrAlertUiInvisible")]
		ErrAlertUiInvisible,
		// Token: 0x0400B821 RID: 47137
		[OriginalName("ErrAlertValueError")]
		ErrAlertValueError,
		// Token: 0x0400B822 RID: 47138
		[OriginalName("ErrAlertSetAlertValueType")]
		ErrAlertSetAlertValueType,
		// Token: 0x0400B823 RID: 47139
		[OriginalName("LevelPlayReportConfigNotExist")]
		LevelPlayReportConfigNotExist,
		// Token: 0x0400B824 RID: 47140
		[OriginalName("LevelPlayReportTypeError")]
		LevelPlayReportTypeError,
		// Token: 0x0400B825 RID: 47141
		[OriginalName("LevelPlayReportVarsEmpty")]
		LevelPlayReportVarsEmpty,
		// Token: 0x0400B826 RID: 47142
		[OriginalName("LevelPlayReportPlayVarsError")]
		LevelPlayReportPlayVarsError,
		// Token: 0x0400B827 RID: 47143
		[OriginalName("CameraAlertHasAlert")]
		CameraAlertHasAlert,
		// Token: 0x0400B828 RID: 47144
		[OriginalName("CameraAlertHasNotAlert")]
		CameraAlertHasNotAlert,
		// Token: 0x0400B829 RID: 47145
		[OriginalName("CameraAlertTagIdNotExist")]
		CameraAlertTagIdNotExist,
		// Token: 0x0400B82A RID: 47146
		[OriginalName("LevelPlayConfigNotExist")]
		LevelPlayConfigNotExist,
		// Token: 0x0400B82B RID: 47147
		[OriginalName("LevelPlayRepeateInstId")]
		LevelPlayRepeateInstId,
		// Token: 0x0400B82C RID: 47148
		[OriginalName("LevelPlayNotBelongInst")]
		LevelPlayNotBelongInst,
		// Token: 0x0400B82D RID: 47149
		[OriginalName("LevelPlayIdsNotExist")]
		LevelPlayIdsNotExist,
		// Token: 0x0400B82E RID: 47150
		[OriginalName("LevelPlayInstCountError")]
		LevelPlayInstCountError,
		// Token: 0x0400B82F RID: 47151
		[OriginalName("LevelPlayCountError")]
		LevelPlayCountError,
		// Token: 0x0400B830 RID: 47152
		[OriginalName("TimerHasPause")]
		TimerHasPause,
		// Token: 0x0400B831 RID: 47153
		[OriginalName("TimerHasNotPause")]
		TimerHasNotPause,
		// Token: 0x0400B832 RID: 47154
		[OriginalName("TimerHasFinish")]
		TimerHasFinish,
		// Token: 0x0400B833 RID: 47155
		[OriginalName("CanNotContinueInst")]
		CanNotContinueInst,
		// Token: 0x0400B834 RID: 47156
		[OriginalName("ChapterNotExist")]
		ChapterNotExist,
		// Token: 0x0400B835 RID: 47157
		[OriginalName("ChapterResultHasFinish")]
		ChapterResultHasFinish,
		// Token: 0x0400B836 RID: 47158
		[OriginalName("ChapterResultNotFinish")]
		ChapterResultNotFinish,
		// Token: 0x0400B837 RID: 47159
		[OriginalName("ChapterResultRewardCanNotTake")]
		ChapterResultRewardCanNotTake,
		// Token: 0x0400B838 RID: 47160
		[OriginalName("ChoiceHasUnlock")]
		ChoiceHasUnlock,
		// Token: 0x0400B839 RID: 47161
		[OriginalName("ChoiceNotUnlock")]
		ChoiceNotUnlock,
		// Token: 0x0400B83A RID: 47162
		[OriginalName("ChapterResultNotExist")]
		ChapterResultNotExist,
		// Token: 0x0400B83B RID: 47163
		[OriginalName("ChapterResultRewardHasTake")]
		ChapterResultRewardHasTake,
		// Token: 0x0400B83C RID: 47164
		[OriginalName("ChoiceNotExist")]
		ChoiceNotExist,
		// Token: 0x0400B83D RID: 47165
		[OriginalName("InspirationNotEnough")]
		InspirationNotEnough,
		// Token: 0x0400B83E RID: 47166
		[OriginalName("ActivityRewardCanNotTake")]
		ActivityRewardCanNotTake,
		// Token: 0x0400B83F RID: 47167
		[OriginalName("ActivityResultNotExist")]
		ActivityResultNotExist,
		// Token: 0x0400B840 RID: 47168
		[OriginalName("ScheduleRewardNotExist")]
		ScheduleRewardNotExist,
		// Token: 0x0400B841 RID: 47169
		[OriginalName("ScheduleRewardHasTake")]
		ScheduleRewardHasTake,
		// Token: 0x0400B842 RID: 47170
		[OriginalName("ScheduleRewardCanNotTake")]
		ScheduleRewardCanNotTake,
		// Token: 0x0400B843 RID: 47171
		[OriginalName("ActivityRewardHasTake")]
		ActivityRewardHasTake,
		// Token: 0x0400B844 RID: 47172
		[OriginalName("QuestWaitConfirmResource")]
		QuestWaitConfirmResource,
		// Token: 0x0400B845 RID: 47173
		[OriginalName("HasGuest")]
		HasGuest,
		// Token: 0x0400B846 RID: 47174
		[OriginalName("QuestConfigNotExist")]
		QuestConfigNotExist,
		// Token: 0x0400B847 RID: 47175
		[OriginalName("QuestDataNotExist")]
		QuestDataNotExist,
		// Token: 0x0400B848 RID: 47176
		[OriginalName("ErrorQuestState")]
		ErrorQuestState,
		// Token: 0x0400B849 RID: 47177
		[OriginalName("QuestCanNotSetFocus")]
		QuestCanNotSetFocus,
		// Token: 0x0400B84A RID: 47178
		[OriginalName("ErrorQuestNotFocus")]
		ErrorQuestNotFocus,
		// Token: 0x0400B84B RID: 47179
		[OriginalName("QuestIncDicNotExist")]
		QuestIncDicNotExist,
		// Token: 0x0400B84C RID: 47180
		[OriginalName("QuestFocusWaitAccept")]
		QuestFocusWaitAccept,
		// Token: 0x0400B84D RID: 47181
		[OriginalName("ErrQuestResourceState")]
		ErrQuestResourceState,
		// Token: 0x0400B84E RID: 47182
		[OriginalName("NoNeedDownloadQuestResource")]
		NoNeedDownloadQuestResource,
		// Token: 0x0400B84F RID: 47183
		[OriginalName("HasFinishQuestResource")]
		HasFinishQuestResource,
		// Token: 0x0400B850 RID: 47184
		[OriginalName("ErrInteracTreeSuspend")]
		ErrInteracTreeSuspend,
		// Token: 0x0400B851 RID: 47185
		[OriginalName("InQuestFocusMode")]
		InQuestFocusMode,
		// Token: 0x0400B852 RID: 47186
		[OriginalName("MultiModeCannotSetQuestFocus")]
		MultiModeCannotSetQuestFocus,
		// Token: 0x0400B853 RID: 47187
		[OriginalName("MultiModeCannotCancelQuestFocus")]
		MultiModeCannotCancelQuestFocus,
		// Token: 0x0400B854 RID: 47188
		[OriginalName("InstanceCannotSetQuestFocus")]
		InstanceCannotSetQuestFocus,
		// Token: 0x0400B855 RID: 47189
		[OriginalName("InstanceCannotCancelQuestFocus")]
		InstanceCannotCancelQuestFocus,
		// Token: 0x0400B856 RID: 47190
		[OriginalName("QuestFocusModeCannotAcceptQuest")]
		QuestFocusModeCannotAcceptQuest,
		// Token: 0x0400B857 RID: 47191
		[OriginalName("ErrorNotFocusWaitQuest")]
		ErrorNotFocusWaitQuest,
		// Token: 0x0400B858 RID: 47192
		[OriginalName("ErrorBanInteractEntity")]
		ErrorBanInteractEntity,
		// Token: 0x0400B859 RID: 47193
		[OriginalName("DisabledFocusMode")]
		DisabledFocusMode,
		// Token: 0x0400B85A RID: 47194
		[OriginalName("ErrorNotVaildGlobalSetting")]
		ErrorNotVaildGlobalSetting,
		// Token: 0x0400B85B RID: 47195
		[OriginalName("ErrorSameGlobalSetting")]
		ErrorSameGlobalSetting,
		// Token: 0x0400B85C RID: 47196
		[OriginalName("ErrorNotVaildBtObjSetting")]
		ErrorNotVaildBtObjSetting,
		// Token: 0x0400B85D RID: 47197
		[OriginalName("ErrorSameBtObjSetting")]
		ErrorSameBtObjSetting,
		// Token: 0x0400B85E RID: 47198
		[OriginalName("CopyUserLoginInvalidToken")]
		CopyUserLoginInvalidToken,
		// Token: 0x0400B85F RID: 47199
		[OriginalName("LoginInvalidToken")]
		LoginInvalidToken,
		// Token: 0x0400B860 RID: 47200
		[OriginalName("AccessInvalidToken")]
		AccessInvalidToken,
		// Token: 0x0400B861 RID: 47201
		[OriginalName("ErrNotAtomicProcessChildQuest")]
		ErrNotAtomicProcessChildQuest,
		// Token: 0x0400B862 RID: 47202
		[OriginalName("ErrNotAtomicProcessStoveCoreFall")]
		ErrNotAtomicProcessStoveCoreFall,
		// Token: 0x0400B863 RID: 47203
		[OriginalName("ErrSplineEntityIdNotExist")]
		ErrSplineEntityIdNotExist,
		// Token: 0x0400B864 RID: 47204
		[OriginalName("ErrSplineEntityNotExist")]
		ErrSplineEntityNotExist,
		// Token: 0x0400B865 RID: 47205
		[OriginalName("MotorFightInstNotLevelConfig")]
		MotorFightInstNotLevelConfig,
		// Token: 0x0400B866 RID: 47206
		[OriginalName("MotorFightSubLevelNotFind")]
		MotorFightSubLevelNotFind,
		// Token: 0x0400B867 RID: 47207
		[OriginalName("MotorFightNextSubLevelNotExist")]
		MotorFightNextSubLevelNotExist,
		// Token: 0x0400B868 RID: 47208
		[OriginalName("MotorFightErrorSubLevel")]
		MotorFightErrorSubLevel,
		// Token: 0x0400B869 RID: 47209
		[OriginalName("MotorFightHasEnterSubLevel")]
		MotorFightHasEnterSubLevel,
		// Token: 0x0400B86A RID: 47210
		[OriginalName("MotorFightCurSubLevelNotKillFinish")]
		MotorFightCurSubLevelNotKillFinish,
		// Token: 0x0400B86B RID: 47211
		[OriginalName("MotorFightHasNotEnterSubLevel")]
		MotorFightHasNotEnterSubLevel,
		// Token: 0x0400B86C RID: 47212
		[OriginalName("MotorFightCusSubLevelHasNotKillFinish")]
		MotorFightCusSubLevelHasNotKillFinish,
		// Token: 0x0400B86D RID: 47213
		[OriginalName("MotorFightCurWaveNotFound")]
		MotorFightCurWaveNotFound,
		// Token: 0x0400B86E RID: 47214
		[OriginalName("MotorFightErrorKillParams")]
		MotorFightErrorKillParams,
		// Token: 0x0400B86F RID: 47215
		[OriginalName("MotorFighttExceedRefreshMonster")]
		MotorFighttExceedRefreshMonster,
		// Token: 0x0400B870 RID: 47216
		[OriginalName("MotorFighttExceedRefreshBoss")]
		MotorFighttExceedRefreshBoss,
		// Token: 0x0400B871 RID: 47217
		[OriginalName("MotorFightNotKillBoss")]
		MotorFightNotKillBoss,
		// Token: 0x0400B872 RID: 47218
		[OriginalName("MotorFightBossDropCollectionHasSelect")]
		MotorFightBossDropCollectionHasSelect,
		// Token: 0x0400B873 RID: 47219
		[OriginalName("MotorFightSelectPosCollectionNotExist")]
		MotorFightSelectPosCollectionNotExist,
		// Token: 0x0400B874 RID: 47220
		[OriginalName("MotorFightCollectionConfigNotExist")]
		MotorFightCollectionConfigNotExist,
		// Token: 0x0400B875 RID: 47221
		[OriginalName("MotorFightWaveGroupNotExist")]
		MotorFightWaveGroupNotExist,
		// Token: 0x0400B876 RID: 47222
		[OriginalName("MotorFightBossMustKilled")]
		MotorFightBossMustKilled,
		// Token: 0x0400B877 RID: 47223
		[OriginalName("MotorFightBossNotExist")]
		MotorFightBossNotExist,
		// Token: 0x0400B878 RID: 47224
		[OriginalName("MotorFightSelectBuffGateNotExist")]
		MotorFightSelectBuffGateNotExist,
		// Token: 0x0400B879 RID: 47225
		[OriginalName("MotorFightCurSubLevelCollectionNoSelectFinish")]
		MotorFightCurSubLevelCollectionNoSelectFinish,
		// Token: 0x0400B87A RID: 47226
		[OriginalName("MotorFightSubLevelConfigNotFind")]
		MotorFightSubLevelConfigNotFind,
		// Token: 0x0400B87B RID: 47227
		[OriginalName("MotorFightSubLevelIndexError")]
		MotorFightSubLevelIndexError,
		// Token: 0x0400B87C RID: 47228
		[OriginalName("MotorFightBossHasKilled")]
		MotorFightBossHasKilled,
		// Token: 0x0400B87D RID: 47229
		[OriginalName("MotorFightBossHasNotRefreshTimes")]
		MotorFightBossHasNotRefreshTimes,
		// Token: 0x0400B87E RID: 47230
		[OriginalName("MotorFightBossDropCollectionError")]
		MotorFightBossDropCollectionError,
		// Token: 0x0400B87F RID: 47231
		[OriginalName("MotorFightHasNotKillBossInfo")]
		MotorFightHasNotKillBossInfo,
		// Token: 0x0400B880 RID: 47232
		[OriginalName("MotorFightIsLastBoss")]
		MotorFightIsLastBoss,
		// Token: 0x0400B881 RID: 47233
		[OriginalName("MotorFightBuffGateHasSelect")]
		MotorFightBuffGateHasSelect,
		// Token: 0x0400B882 RID: 47234
		[OriginalName("MotorFightSubLevelStateError")]
		MotorFightSubLevelStateError,
		// Token: 0x0400B883 RID: 47235
		[OriginalName("MotorFightSubLevelNotFound")]
		MotorFightSubLevelNotFound,
		// Token: 0x0400B884 RID: 47236
		[OriginalName("MotorFightHasGameOver")]
		MotorFightHasGameOver,
		// Token: 0x0400B885 RID: 47237
		[OriginalName("MotorFightCurWaveNotExist")]
		MotorFightCurWaveNotExist,
		// Token: 0x0400B886 RID: 47238
		[OriginalName("MotorFightCurWaveNotKillFinish")]
		MotorFightCurWaveNotKillFinish,
		// Token: 0x0400B887 RID: 47239
		[OriginalName("SpecificInstDbDataLoading")]
		SpecificInstDbDataLoading,
		// Token: 0x0400B888 RID: 47240
		[OriginalName("SpecificInstDbDataLoadError")]
		SpecificInstDbDataLoadError,
		// Token: 0x0400B889 RID: 47241
		[OriginalName("RecallConfigNotExist")]
		RecallConfigNotExist,
		// Token: 0x0400B88A RID: 47242
		[OriginalName("QuestNotFinish")]
		QuestNotFinish,
		// Token: 0x0400B88B RID: 47243
		[OriginalName("HasInRecallScene")]
		HasInRecallScene,
		// Token: 0x0400B88C RID: 47244
		[OriginalName("EntityConfigNotFound")]
		EntityConfigNotFound,
		// Token: 0x0400B88D RID: 47245
		[OriginalName("InstConfigNotFound")]
		InstConfigNotFound,
		// Token: 0x0400B88E RID: 47246
		[OriginalName("FastReturnPosTypeNotSupport")]
		FastReturnPosTypeNotSupport,
		// Token: 0x0400B88F RID: 47247
		[OriginalName("FastReturnPosConfigError")]
		FastReturnPosConfigError,
		// Token: 0x0400B890 RID: 47248
		[OriginalName("TrackCustomBoardIsNull")]
		TrackCustomBoardIsNull,
		// Token: 0x0400B891 RID: 47249
		[OriginalName("BtNodeConfigNotExist")]
		BtNodeConfigNotExist,
		// Token: 0x0400B892 RID: 47250
		[OriginalName("BtNodeObjNotExist")]
		BtNodeObjNotExist,
		// Token: 0x0400B893 RID: 47251
		[OriginalName("LevelPlayNotExist")]
		LevelPlayNotExist,
		// Token: 0x0400B894 RID: 47252
		[OriginalName("LevelPlayDbDataNotExist")]
		LevelPlayDbDataNotExist,
		// Token: 0x0400B895 RID: 47253
		[OriginalName("NotInRecallInst")]
		NotInRecallInst,
		// Token: 0x0400B896 RID: 47254
		[OriginalName("SpecificRecallInfoNotExist")]
		SpecificRecallInfoNotExist,
		// Token: 0x0400B897 RID: 47255
		[OriginalName("ElementalTypeNotMatch")]
		ElementalTypeNotMatch,
		// Token: 0x0400B898 RID: 47256
		[OriginalName("ElementalMatchTypeIsEmpty")]
		ElementalMatchTypeIsEmpty,
		// Token: 0x0400B899 RID: 47257
		[OriginalName("ErrComponentConfigNotExist")]
		ErrComponentConfigNotExist,
		// Token: 0x0400B89A RID: 47258
		[OriginalName("ErrHasHandCasketCore")]
		ErrHasHandCasketCore,
		// Token: 0x0400B89B RID: 47259
		[OriginalName("ErrNotHandCasketCore")]
		ErrNotHandCasketCore,
		// Token: 0x0400B89C RID: 47260
		[OriginalName("ErrFoundationHasCore")]
		ErrFoundationHasCore,
		// Token: 0x0400B89D RID: 47261
		[OriginalName("ErrFoundationHasNotCore")]
		ErrFoundationHasNotCore,
		// Token: 0x0400B89E RID: 47262
		[OriginalName("ErrFoundationInteractCondNotMatch")]
		ErrFoundationInteractCondNotMatch,
		// Token: 0x0400B89F RID: 47263
		[OriginalName("ErrElementalTypeNotMatch")]
		ErrElementalTypeNotMatch,
		// Token: 0x0400B8A0 RID: 47264
		[OriginalName("ErrElementalHolderNotEnable")]
		ErrElementalHolderNotEnable,
		// Token: 0x0400B8A1 RID: 47265
		[OriginalName("ElementalBoxNotInFoundation")]
		ElementalBoxNotInFoundation,
		// Token: 0x0400B8A2 RID: 47266
		[OriginalName("ErrElementalBoxConfigNotExist")]
		ErrElementalBoxConfigNotExist,
		// Token: 0x0400B8A3 RID: 47267
		[OriginalName("ErrMultigameQuestRecall")]
		ErrMultigameQuestRecall,
		// Token: 0x0400B8A4 RID: 47268
		[OriginalName("ErrActionGetItemHasNotFreeSize")]
		ErrActionGetItemHasNotFreeSize,
		// Token: 0x0400B8A5 RID: 47269
		[OriginalName("ErrorCodeIdCreateRuleChange2")]
		IdCreateRuleChange2 = 2700001,
		// Token: 0x0400B8A6 RID: 47270
		[OriginalName("RacingBetsActivityIdErr")]
		RacingBetsActivityIdErr,
		// Token: 0x0400B8A7 RID: 47271
		[OriginalName("RacingBetsActivityDataErr")]
		RacingBetsActivityDataErr,
		// Token: 0x0400B8A8 RID: 47272
		[OriginalName("RacingBetsRewardConfErr")]
		RacingBetsRewardConfErr,
		// Token: 0x0400B8A9 RID: 47273
		[OriginalName("RacingBetsTaskIdNotExist")]
		RacingBetsTaskIdNotExist,
		// Token: 0x0400B8AA RID: 47274
		[OriginalName("RacingBetsTaskRewarded")]
		RacingBetsTaskRewarded,
		// Token: 0x0400B8AB RID: 47275
		[OriginalName("RacingBetsTaskUndone")]
		RacingBetsTaskUndone,
		// Token: 0x0400B8AC RID: 47276
		[OriginalName("RacingBetsTaskRewardFail")]
		RacingBetsTaskRewardFail,
		// Token: 0x0400B8AD RID: 47277
		[OriginalName("RacingBetsSeasonConfErr")]
		RacingBetsSeasonConfErr,
		// Token: 0x0400B8AE RID: 47278
		[OriginalName("RacingBetsLegMatchIdNotExist")]
		RacingBetsLegMatchIdNotExist,
		// Token: 0x0400B8AF RID: 47279
		[OriginalName("RacingBetsOddsTimesErr")]
		RacingBetsOddsTimesErr,
		// Token: 0x0400B8B0 RID: 47280
		[OriginalName("RacingBetsOddsVersionErr")]
		RacingBetsOddsVersionErr,
		// Token: 0x0400B8B1 RID: 47281
		[OriginalName("RacingBetsOddsVersionCodeErr")]
		RacingBetsOddsVersionCodeErr,
		// Token: 0x0400B8B2 RID: 47282
		[OriginalName("RacingBetsOddsConfErr")]
		RacingBetsOddsConfErr,
		// Token: 0x0400B8B3 RID: 47283
		[OriginalName("RacingBetsOddsDangoErr")]
		RacingBetsOddsDangoErr,
		// Token: 0x0400B8B4 RID: 47284
		[OriginalName("RacingBetsOddsDangoConfErr")]
		RacingBetsOddsDangoConfErr,
		// Token: 0x0400B8B5 RID: 47285
		[OriginalName("RacingBetsOddsTimeErr")]
		RacingBetsOddsTimeErr,
		// Token: 0x0400B8B6 RID: 47286
		[OriginalName("RacingBetsOddsRetry")]
		RacingBetsOddsRetry,
		// Token: 0x0400B8B7 RID: 47287
		[OriginalName("RacingBetsCostFundsErr")]
		RacingBetsCostFundsErr,
		// Token: 0x0400B8B8 RID: 47288
		[OriginalName("RacingBetsGearTimesLimit")]
		RacingBetsGearTimesLimit,
		// Token: 0x0400B8B9 RID: 47289
		[OriginalName("RacingBetsGearInfoErr")]
		RacingBetsGearInfoErr,
		// Token: 0x0400B8BA RID: 47290
		[OriginalName("RacingBetsGearRefundParamErr")]
		RacingBetsGearRefundParamErr,
		// Token: 0x0400B8BB RID: 47291
		[OriginalName("RacingBetsGearRefundFail")]
		RacingBetsGearRefundFail,
		// Token: 0x0400B8BC RID: 47292
		[OriginalName("RacingBetsGearNotRefund")]
		RacingBetsGearNotRefund,
		// Token: 0x0400B8BD RID: 47293
		[OriginalName("RacingBetsActivityConfErr")]
		RacingBetsActivityConfErr,
		// Token: 0x0400B8BE RID: 47294
		[OriginalName("RacingBetsOddsFundsLack")]
		RacingBetsOddsFundsLack,
		// Token: 0x0400B8BF RID: 47295
		[OriginalName("RacingBetsOddsLack")]
		RacingBetsOddsLack,
		// Token: 0x0400B8C0 RID: 47296
		[OriginalName("RacingBetsGroupNotExist")]
		RacingBetsGroupNotExist,
		// Token: 0x0400B8C1 RID: 47297
		[OriginalName("RacingBetsGroupConfNotExist")]
		RacingBetsGroupConfNotExist,
		// Token: 0x0400B8C2 RID: 47298
		[OriginalName("RacingBetsGroupConfError")]
		RacingBetsGroupConfError,
		// Token: 0x0400B8C3 RID: 47299
		[OriginalName("RacingBetsNotInInst")]
		RacingBetsNotInInst,
		// Token: 0x0400B8C4 RID: 47300
		[OriginalName("RacingBetsFundsNotEnough")]
		RacingBetsFundsNotEnough,
		// Token: 0x0400B8C5 RID: 47301
		[OriginalName("RacingBetsFundsCalcErr")]
		RacingBetsFundsCalcErr,
		// Token: 0x0400B8C6 RID: 47302
		[OriginalName("RacingBetsLegMatchNotOpen")]
		RacingBetsLegMatchNotOpen,
		// Token: 0x0400B8C7 RID: 47303
		[OriginalName("RacingBetsDangoActionTypeErr")]
		RacingBetsDangoActionTypeErr,
		// Token: 0x0400B8C8 RID: 47304
		[OriginalName("RacingBetsDangoMatchParamErr")]
		RacingBetsDangoMatchParamErr,
		// Token: 0x0400B8C9 RID: 47305
		[OriginalName("RacingBetsInstSubTypeErr")]
		RacingBetsInstSubTypeErr,
		// Token: 0x0400B8CA RID: 47306
		[OriginalName("RacingBetsEntityErr")]
		RacingBetsEntityErr,
		// Token: 0x0400B8CB RID: 47307
		[OriginalName("RacingBetsLegMatchIdErr")]
		RacingBetsLegMatchIdErr,
		// Token: 0x0400B8CC RID: 47308
		[OriginalName("RacingBetsBulletScreenTableNotExist")]
		RacingBetsBulletScreenTableNotExist,
		// Token: 0x0400B8CD RID: 47309
		[OriginalName("RacingBetsBulletScreenIdErr")]
		RacingBetsBulletScreenIdErr,
		// Token: 0x0400B8CE RID: 47310
		[OriginalName("RacingBetsBulletActionIndexNotExist")]
		RacingBetsBulletActionIndexNotExist,
		// Token: 0x0400B8CF RID: 47311
		[OriginalName("RacingBetsBulletScreenLegMatchNotExist")]
		RacingBetsBulletScreenLegMatchNotExist,
		// Token: 0x0400B8D0 RID: 47312
		[OriginalName("RacingBetsBulletNotFundOpenRankCurTime")]
		RacingBetsBulletNotFundOpenRankCurTime,
		// Token: 0x0400B8D1 RID: 47313
		[OriginalName("RacingBetsBulletGetRankErr")]
		RacingBetsBulletGetRankErr,
		// Token: 0x0400B8D2 RID: 47314
		[OriginalName("RacingBetsBulletCD")]
		RacingBetsBulletCd,
		// Token: 0x0400B8D3 RID: 47315
		[OriginalName("ActivityLinkageActivityIdConfErr")]
		ActivityLinkageActivityIdConfErr,
		// Token: 0x0400B8D4 RID: 47316
		[OriginalName("ActivityLinkageConfErr")]
		ActivityLinkageConfErr,
		// Token: 0x0400B8D5 RID: 47317
		[OriginalName("ActivityLinkageRewardErr")]
		ActivityLinkageRewardErr,
		// Token: 0x0400B8D6 RID: 47318
		[OriginalName("ActivityLinkageDataErr")]
		ActivityLinkageDataErr,
		// Token: 0x0400B8D7 RID: 47319
		[OriginalName("ActivityLinkageConfIndexErr")]
		ActivityLinkageConfIndexErr,
		// Token: 0x0400B8D8 RID: 47320
		[OriginalName("ActivityLinkageRewardStatusErr")]
		ActivityLinkageRewardStatusErr,
		// Token: 0x0400B8D9 RID: 47321
		[OriginalName("ActivityLinkagePageTimeErr")]
		ActivityLinkagePageTimeErr,
		// Token: 0x0400B8DA RID: 47322
		[OriginalName("RacingBetsdynamicOddsConfErr")]
		RacingBetsdynamicOddsConfErr,
		// Token: 0x0400B8DB RID: 47323
		[OriginalName("RacingBetsdynamicOddsProportionErr")]
		RacingBetsdynamicOddsProportionErr,
		// Token: 0x0400B8DC RID: 47324
		[OriginalName("RacingBetsDangoDataNotExist")]
		RacingBetsDangoDataNotExist,
		// Token: 0x0400B8DD RID: 47325
		[OriginalName("RacingBetsMatchDataErr")]
		RacingBetsMatchDataErr,
		// Token: 0x0400B8DE RID: 47326
		[OriginalName("RacingBetsMatchRoundTimeErr")]
		RacingBetsMatchRoundTimeErr,
		// Token: 0x0400B8DF RID: 47327
		[OriginalName("RacingBetsNotGear")]
		RacingBetsNotGear,
		// Token: 0x0400B8E0 RID: 47328
		[OriginalName("RacingBetsLegSettle")]
		RacingBetsLegSettle,
		// Token: 0x0400B8E1 RID: 47329
		[OriginalName("RacingBetsRankNotOpen")]
		RacingBetsRankNotOpen,
		// Token: 0x0400B8E2 RID: 47330
		[OriginalName("RacingBetsActionIndexErr")]
		RacingBetsActionIndexErr,
		// Token: 0x0400B8E3 RID: 47331
		[OriginalName("RacingBetsMatchRoundNotFund")]
		RacingBetsMatchRoundNotFund,
		// Token: 0x0400B8E4 RID: 47332
		[OriginalName("RacingBetsDangoConfNotExist")]
		RacingBetsDangoConfNotExist,
		// Token: 0x0400B8E5 RID: 47333
		[OriginalName("RacingBetsDangoTemplateConfNotExist")]
		RacingBetsDangoTemplateConfNotExist,
		// Token: 0x0400B8E6 RID: 47334
		[OriginalName("RacingBetsDangoEntityCreateFail")]
		RacingBetsDangoEntityCreateFail,
		// Token: 0x0400B8E7 RID: 47335
		[OriginalName("RacingBetsLegMatchConfNotExist")]
		RacingBetsLegMatchConfNotExist,
		// Token: 0x0400B8E8 RID: 47336
		[OriginalName("PhantomBattleCardUnlocked")]
		PhantomBattleCardUnlocked,
		// Token: 0x0400B8E9 RID: 47337
		[OriginalName("PhantomBattleActDataNotExist")]
		PhantomBattleActDataNotExist,
		// Token: 0x0400B8EA RID: 47338
		[OriginalName("RacingBetsLegNextOddsErr")]
		RacingBetsLegNextOddsErr,
		// Token: 0x0400B8EB RID: 47339
		[OriginalName("RacingBetsRankNotExist")]
		RacingBetsRankNotExist,
		// Token: 0x0400B8EC RID: 47340
		[OriginalName("RacingBetsPlayerNotExistInRank")]
		RacingBetsPlayerNotExistInRank,
		// Token: 0x0400B8ED RID: 47341
		[OriginalName("PhantomBattleCardTableNotExist")]
		PhantomBattleCardTableNotExist,
		// Token: 0x0400B8EE RID: 47342
		[OriginalName("PhantomBattleCardNumLimit")]
		PhantomBattleCardNumLimit,
		// Token: 0x0400B8EF RID: 47343
		[OriginalName("PhantomBattleActTableNotExist")]
		PhantomBattleActTableNotExist,
		// Token: 0x0400B8F0 RID: 47344
		[OriginalName("PhantomBattleCardGroupLimit")]
		PhantomBattleCardGroupLimit,
		// Token: 0x0400B8F1 RID: 47345
		[OriginalName("PhantomBattleGroupLimit")]
		PhantomBattleGroupLimit,
		// Token: 0x0400B8F2 RID: 47346
		[OriginalName("PhantomBattleMainCostLimit")]
		PhantomBattleMainCostLimit,
		// Token: 0x0400B8F3 RID: 47347
		[OriginalName("PhantomBattleCardLocked")]
		PhantomBattleCardLocked,
		// Token: 0x0400B8F4 RID: 47348
		[OriginalName("PhantomBattleGroupNameLimit")]
		PhantomBattleGroupNameLimit,
		// Token: 0x0400B8F5 RID: 47349
		[OriginalName("PhantomBattleGroupNotExist")]
		PhantomBattleGroupNotExist,
		// Token: 0x0400B8F6 RID: 47350
		[OriginalName("PhantomBattleRomoveReason")]
		PhantomBattleRomoveReason,
		// Token: 0x0400B8F7 RID: 47351
		[OriginalName("RacingBetsBulletIdErr")]
		RacingBetsBulletIdErr,
		// Token: 0x0400B8F8 RID: 47352
		[OriginalName("RacingBetsPlayerDataNotExist")]
		RacingBetsPlayerDataNotExist,
		// Token: 0x0400B8F9 RID: 47353
		[OriginalName("RacingBetsTaskDataNotExist")]
		RacingBetsTaskDataNotExist,
		// Token: 0x0400B8FA RID: 47354
		[OriginalName("PhantomBattleGroupElementLimit")]
		PhantomBattleGroupElementLimit,
		// Token: 0x0400B8FB RID: 47355
		[OriginalName("PhantomBattleOutLookUped")]
		PhantomBattleOutLookUped,
		// Token: 0x0400B8FC RID: 47356
		[OriginalName("PhantomBattleTaskConfNotExist")]
		PhantomBattleTaskConfNotExist,
		// Token: 0x0400B8FD RID: 47357
		[OriginalName("PhantomBattleConditionDataErr")]
		PhantomBattleConditionDataErr,
		// Token: 0x0400B8FE RID: 47358
		[OriginalName("PhantomBattleConditionConfNotExist")]
		PhantomBattleConditionConfNotExist,
		// Token: 0x0400B8FF RID: 47359
		[OriginalName("PhantomBattleConditionGroupConfNotExist")]
		PhantomBattleConditionGroupConfNotExist,
		// Token: 0x0400B900 RID: 47360
		[OriginalName("PhantomBattleTaskStutas")]
		PhantomBattleTaskStutas,
		// Token: 0x0400B901 RID: 47361
		[OriginalName("PhantomBattleTaskReward")]
		PhantomBattleTaskReward,
		// Token: 0x0400B902 RID: 47362
		[OriginalName("PhantomBattleTaskNotFinish")]
		PhantomBattleTaskNotFinish,
		// Token: 0x0400B903 RID: 47363
		[OriginalName("PhantomBattleTaskProgressErr")]
		PhantomBattleTaskProgressErr,
		// Token: 0x0400B904 RID: 47364
		[OriginalName("PhantomBattleBadgeUnlocked")]
		PhantomBattleBadgeUnlocked,
		// Token: 0x0400B905 RID: 47365
		[OriginalName("PhantomBattleLevelConfNotExist")]
		PhantomBattleLevelConfNotExist,
		// Token: 0x0400B906 RID: 47366
		[OriginalName("PhantomBattBadgeRewardConfNotExist")]
		PhantomBattBadgeRewardConfNotExist,
		// Token: 0x0400B907 RID: 47367
		[OriginalName("PhantomBattCardRewardConfNotExist")]
		PhantomBattCardRewardConfNotExist,
		// Token: 0x0400B908 RID: 47368
		[OriginalName("PhantomBattBadgeUnlockNotEnough")]
		PhantomBattBadgeUnlockNotEnough,
		// Token: 0x0400B909 RID: 47369
		[OriginalName("PhantomBattBadgeConfErr")]
		PhantomBattBadgeConfErr,
		// Token: 0x0400B90A RID: 47370
		[OriginalName("PhantomBattBadgeRewardErr")]
		PhantomBattBadgeRewardErr,
		// Token: 0x0400B90B RID: 47371
		[OriginalName("PhantomBattleLevelRewardConfNotExist")]
		PhantomBattleLevelRewardConfNotExist,
		// Token: 0x0400B90C RID: 47372
		[OriginalName("PhantomBattCardUnlockNotEnough")]
		PhantomBattCardUnlockNotEnough,
		// Token: 0x0400B90D RID: 47373
		[OriginalName("PhantomBattCardRewardConfErr")]
		PhantomBattCardRewardConfErr,
		// Token: 0x0400B90E RID: 47374
		[OriginalName("PhantomBattLvNotEnough")]
		PhantomBattLvNotEnough,
		// Token: 0x0400B90F RID: 47375
		[OriginalName("PhantomBattLvRewardConfErr")]
		PhantomBattLvRewardConfErr,
		// Token: 0x0400B910 RID: 47376
		[OriginalName("PhantomBattCardRewardErr")]
		PhantomBattCardRewardErr,
		// Token: 0x0400B911 RID: 47377
		[OriginalName("PhantomBattLvRewardErr")]
		PhantomBattLvRewardErr,
		// Token: 0x0400B912 RID: 47378
		[OriginalName("PhantomBattLvRewardConfNotExist")]
		PhantomBattLvRewardConfNotExist,
		// Token: 0x0400B913 RID: 47379
		[OriginalName("PhantomBattRoleLock")]
		PhantomBattRoleLock,
		// Token: 0x0400B914 RID: 47380
		[OriginalName("PhantomBattRoleReward")]
		PhantomBattRoleReward,
		// Token: 0x0400B915 RID: 47381
		[OriginalName("PhantomBattRoleRewardErr")]
		PhantomBattRoleRewardErr,
		// Token: 0x0400B916 RID: 47382
		[OriginalName("PhantomBattPassRewardErr")]
		PhantomBattPassRewardErr,
		// Token: 0x0400B917 RID: 47383
		[OriginalName("PhantomBattFirstPassRewardErr")]
		PhantomBattFirstPassRewardErr,
		// Token: 0x0400B918 RID: 47384
		[OriginalName("PhantomBattleChallengeConfNotFind")]
		PhantomBattleChallengeConfNotFind,
		// Token: 0x0400B919 RID: 47385
		[OriginalName("PhantomBattleChallengeOpenLimit")]
		PhantomBattleChallengeOpenLimit,
		// Token: 0x0400B91A RID: 47386
		[OriginalName("PhantomBattleParamLimit")]
		PhantomBattleParamLimit,
		// Token: 0x0400B91B RID: 47387
		[OriginalName("PhantomBattleParamRepeat")]
		PhantomBattleParamRepeat,
		// Token: 0x0400B91C RID: 47388
		[OriginalName("PhantomBattleFuncOpenChallengeRepeat")]
		PhantomBattleFuncOpenChallengeRepeat,
		// Token: 0x0400B91D RID: 47389
		[OriginalName("PhantomBattleFuncOpenCardGroup")]
		PhantomBattleFuncOpenCardGroup,
		// Token: 0x0400B91E RID: 47390
		[OriginalName("PhantomBattleFuncOpenCard")]
		PhantomBattleFuncOpenCard,
		// Token: 0x0400B91F RID: 47391
		[OriginalName("PhantomBattleFuncOpenCardOutlookUp")]
		PhantomBattleFuncOpenCardOutlookUp,
		// Token: 0x0400B920 RID: 47392
		[OriginalName("PhantomBattleCardNotAllowBuy")]
		PhantomBattleCardNotAllowBuy,
		// Token: 0x0400B921 RID: 47393
		[OriginalName("FloroRanchHasUnSettleIns")]
		FloroRanchHasUnSettleIns,
		// Token: 0x0400B922 RID: 47394
		[OriginalName("FloroRanchSubInsConfNotExist")]
		FloroRanchSubInsConfNotExist,
		// Token: 0x0400B923 RID: 47395
		[OriginalName("FloroRanchRacesLimit")]
		FloroRanchRacesLimit,
		// Token: 0x0400B924 RID: 47396
		[OriginalName("FloroRanchBaseTerrainLimit")]
		FloroRanchBaseTerrainLimit,
		// Token: 0x0400B925 RID: 47397
		[OriginalName("FloroRanchBaseCardLimit")]
		FloroRanchBaseCardLimit,
		// Token: 0x0400B926 RID: 47398
		[OriginalName("FloroRanchRaceRepeat")]
		FloroRanchRaceRepeat,
		// Token: 0x0400B927 RID: 47399
		[OriginalName("FloroRanchGamePlayNotExist")]
		FloroRanchGamePlayNotExist,
		// Token: 0x0400B928 RID: 47400
		[OriginalName("FloroRanchGamePlayGachaNotExist")]
		FloroRanchGamePlayGachaNotExist,
		// Token: 0x0400B929 RID: 47401
		[OriginalName("FloroRanchCardNotExistInGacha")]
		FloroRanchCardNotExistInGacha,
		// Token: 0x0400B92A RID: 47402
		[OriginalName("FloroRanchPhantomCreateFail")]
		FloroRanchPhantomCreateFail,
		// Token: 0x0400B92B RID: 47403
		[OriginalName("FloroRanchTributeCoinLimit")]
		FloroRanchTributeCoinLimit,
		// Token: 0x0400B92C RID: 47404
		[OriginalName("FloroRanchRaceNotEnough")]
		FloroRanchRaceNotEnough,
		// Token: 0x0400B92D RID: 47405
		[OriginalName("FloroRanchStageNotSettle")]
		FloroRanchStageNotSettle,
		// Token: 0x0400B92E RID: 47406
		[OriginalName("FloroRanchActivitysNotFind")]
		FloroRanchActivitysNotFind,
		// Token: 0x0400B92F RID: 47407
		[OriginalName("FloroRanchGamePlayShopNotExist")]
		FloroRanchGamePlayShopNotExist,
		// Token: 0x0400B930 RID: 47408
		[OriginalName("FloroRanchGamePlayShopItemNotExist")]
		FloroRanchGamePlayShopItemNotExist,
		// Token: 0x0400B931 RID: 47409
		[OriginalName("FloroRanchDiamondNotEnough")]
		FloroRanchDiamondNotEnough,
		// Token: 0x0400B932 RID: 47410
		[OriginalName("FloroRanchCardTableNotExist")]
		FloroRanchCardTableNotExist,
		// Token: 0x0400B933 RID: 47411
		[OriginalName("FloroRanchToyTableNotExist")]
		FloroRanchToyTableNotExist,
		// Token: 0x0400B934 RID: 47412
		[OriginalName("FloroRanchTerrainTableNotExist")]
		FloroRanchTerrainTableNotExist,
		// Token: 0x0400B935 RID: 47413
		[OriginalName("FloroRanchToyNumLimit")]
		FloroRanchToyNumLimit,
		// Token: 0x0400B936 RID: 47414
		[OriginalName("FloroRanchNotEnoughToyIndex")]
		FloroRanchNotEnoughToyIndex,
		// Token: 0x0400B937 RID: 47415
		[OriginalName("FloroRanchToyCreateFail")]
		FloroRanchToyCreateFail,
		// Token: 0x0400B938 RID: 47416
		[OriginalName("FloroRanchCardGroupTableNotExist")]
		FloroRanchCardGroupTableNotExist,
		// Token: 0x0400B939 RID: 47417
		[OriginalName("FloroRanchCardGroupNotExist")]
		FloroRanchCardGroupNotExist,
		// Token: 0x0400B93A RID: 47418
		[OriginalName("FloroRanchBuffTableNotExist")]
		FloroRanchBuffTableNotExist,
		// Token: 0x0400B93B RID: 47419
		[OriginalName("FloroRanchRemoveUnitNotExist")]
		FloroRanchRemoveUnitNotExist,
		// Token: 0x0400B93C RID: 47420
		[OriginalName("PhantomBattleCardMaxLimit")]
		PhantomBattleCardMaxLimit,
		// Token: 0x0400B93D RID: 47421
		[OriginalName("FloroRanchRefreshTableNotExist")]
		FloroRanchRefreshTableNotExist,
		// Token: 0x0400B93E RID: 47422
		[OriginalName("FloroRanchPlayTaskNotExist")]
		FloroRanchPlayTaskNotExist,
		// Token: 0x0400B93F RID: 47423
		[OriginalName("FloroRanchSkillTableNotExist")]
		FloroRanchSkillTableNotExist,
		// Token: 0x0400B940 RID: 47424
		[OriginalName("FloroRanchSkillUseTimesLimit")]
		FloroRanchSkillUseTimesLimit,
		// Token: 0x0400B941 RID: 47425
		[OriginalName("FloroRanchSkillLogicNotExist")]
		FloroRanchSkillLogicNotExist,
		// Token: 0x0400B942 RID: 47426
		[OriginalName("FloroRanchSkillLogicErr")]
		FloroRanchSkillLogicErr,
		// Token: 0x0400B943 RID: 47427
		[OriginalName("FloroRanchSkillLogicFail")]
		FloroRanchSkillLogicFail,
		// Token: 0x0400B944 RID: 47428
		[OriginalName("PhantomBattleNameLimitConfErr")]
		PhantomBattleNameLimitConfErr,
		// Token: 0x0400B945 RID: 47429
		[OriginalName("FloroRanchNotEnableUnlimitedMode")]
		FloroRanchNotEnableUnlimitedMode,
		// Token: 0x0400B946 RID: 47430
		[OriginalName("PhantomBattleLimitTime")]
		PhantomBattleLimitTime,
		// Token: 0x0400B947 RID: 47431
		[OriginalName("FloroRanchToyWeightConfErr")]
		FloroRanchToyWeightConfErr,
		// Token: 0x0400B948 RID: 47432
		[OriginalName("FloroRanchAnimalNumLimit")]
		FloroRanchAnimalNumLimit,
		// Token: 0x0400B949 RID: 47433
		[OriginalName("FloroRanchRaceTableNotFind")]
		FloroRanchRaceTableNotFind,
		// Token: 0x0400B94A RID: 47434
		[OriginalName("FloroRanchRaceLock")]
		FloroRanchRaceLock,
		// Token: 0x0400B94B RID: 47435
		[OriginalName("FloroRanchSkillLock")]
		FloroRanchSkillLock,
		// Token: 0x0400B94C RID: 47436
		[OriginalName("FloroRanchSubInsLock")]
		FloroRanchSubInsLock,
		// Token: 0x0400B94D RID: 47437
		[OriginalName("RoleSelfBgmUnableOperate")]
		RoleSelfBgmUnableOperate,
		// Token: 0x0400B94E RID: 47438
		[OriginalName("RoleSelfBgmFlyTableNotExist")]
		RoleSelfBgmFlyTableNotExist,
		// Token: 0x0400B94F RID: 47439
		[OriginalName("RoleSelfBgmUnableOp")]
		RoleSelfBgmUnableOp,
		// Token: 0x0400B950 RID: 47440
		[OriginalName("FloroRanchInsLock")]
		FloroRanchInsLock,
		// Token: 0x0400B951 RID: 47441
		[OriginalName("FloroRanchInsConfNotFind")]
		FloroRanchInsConfNotFind,
		// Token: 0x0400B952 RID: 47442
		[OriginalName("FloroRanchInsIdNotFind")]
		FloroRanchInsIdNotFind,
		// Token: 0x0400B953 RID: 47443
		[OriginalName("FloroRanchInsRaceNotInReq")]
		FloroRanchInsRaceNotInReq,
		// Token: 0x0400B954 RID: 47444
		[OriginalName("FloroRanchUnEnableTribute")]
		FloroRanchUnEnableTribute,
		// Token: 0x0400B955 RID: 47445
		[OriginalName("FloroRanchIsMulti")]
		FloroRanchIsMulti,
		// Token: 0x0400B956 RID: 47446
		[OriginalName("ButtonLockParamLimit")]
		ButtonLockParamLimit,
		// Token: 0x0400B957 RID: 47447
		[OriginalName("ButtonLockParamRepeat")]
		ButtonLockParamRepeat,
		// Token: 0x0400B958 RID: 47448
		[OriginalName("PhantomBattlePlayerCardGroupBuildErr")]
		PhantomBattlePlayerCardGroupBuildErr,
		// Token: 0x0400B959 RID: 47449
		[OriginalName("PhantomBattleNpcCardGroupBuildErr")]
		PhantomBattleNpcCardGroupBuildErr,
		// Token: 0x0400B95A RID: 47450
		[OriginalName("PhantomBattleNpcRecordLoadFail")]
		PhantomBattleNpcRecordLoadFail,
		// Token: 0x0400B95B RID: 47451
		[OriginalName("PhantomBattleCardTypeErr")]
		PhantomBattleCardTypeErr,
		// Token: 0x0400B95C RID: 47452
		[OriginalName("PhantomBattleActTypeErr")]
		PhantomBattleActTypeErr,
		// Token: 0x0400B95D RID: 47453
		[OriginalName("PhantomNoDurableSkill")]
		PhantomNoDurableSkill,
		// Token: 0x0400B95E RID: 47454
		[OriginalName("PhantomBattleAreaCardNumLimit")]
		PhantomBattleAreaCardNumLimit,
		// Token: 0x0400B95F RID: 47455
		[OriginalName("PhantomBattleItemCardNumLimit")]
		PhantomBattleItemCardNumLimit,
		// Token: 0x0400B960 RID: 47456
		[OriginalName("PhantomBattleCallTaskNumErr")]
		PhantomBattleCallTaskNumErr,
		// Token: 0x0400B961 RID: 47457
		[OriginalName("PhantomBattleNotCanSoltIndex")]
		PhantomBattleNotCanSoltIndex,
		// Token: 0x0400B962 RID: 47458
		[OriginalName("PhantomBattleSoltMaxLimit")]
		PhantomBattleSoltMaxLimit,
		// Token: 0x0400B963 RID: 47459
		[OriginalName("PhantomBattleTaskIdErr")]
		PhantomBattleTaskIdErr,
		// Token: 0x0400B964 RID: 47460
		[OriginalName("PhantomBattleActIdErr")]
		PhantomBattleActIdErr,
		// Token: 0x0400B965 RID: 47461
		[OriginalName("PhantomBattleConditionParamErr")]
		PhantomBattleConditionParamErr,
		// Token: 0x0400B966 RID: 47462
		[OriginalName("PhantomBattleAreaCardConfigErr")]
		PhantomBattleAreaCardConfigErr,
		// Token: 0x0400B967 RID: 47463
		[OriginalName("PhantomBattleAreaLock")]
		PhantomBattleAreaLock,
		// Token: 0x0400B968 RID: 47464
		[OriginalName("PhantomBattleGuideActTableNotExist")]
		PhantomBattleGuideActTableNotExist,
		// Token: 0x0400B969 RID: 47465
		[OriginalName("NewPlayerSupportTaskConfNotExist")]
		NewPlayerSupportTaskConfNotExist,
		// Token: 0x0400B96A RID: 47466
		[OriginalName("NewPlayerSupportTaskRewardIndex")]
		NewPlayerSupportTaskRewardIndex,
		// Token: 0x0400B96B RID: 47467
		[OriginalName("NewPlayerSupportTaskParamLimit")]
		NewPlayerSupportTaskParamLimit,
		// Token: 0x0400B96C RID: 47468
		[OriginalName("NewPlayerSupportTaskParamRepeat")]
		NewPlayerSupportTaskParamRepeat,
		// Token: 0x0400B96D RID: 47469
		[OriginalName("NewPlayerSupportTaskReward")]
		NewPlayerSupportTaskReward,
		// Token: 0x0400B96E RID: 47470
		[OriginalName("NewPlayerSupportTaskNotFinish")]
		NewPlayerSupportTaskNotFinish,
		// Token: 0x0400B96F RID: 47471
		[OriginalName("NewPlayerSupportDataNotEixst")]
		NewPlayerSupportDataNotEixst,
		// Token: 0x0400B970 RID: 47472
		[OriginalName("NewPlayerSupportNotFindTrialRole")]
		NewPlayerSupportNotFindTrialRole,
		// Token: 0x0400B971 RID: 47473
		[OriginalName("NewPlayerSupportRoleLock")]
		NewPlayerSupportRoleLock,
		// Token: 0x0400B972 RID: 47474
		[OriginalName("NewPlayerSupportWorldLvErr")]
		NewPlayerSupportWorldLvErr,
		// Token: 0x0400B973 RID: 47475
		[OriginalName("NewPlayerSupportRolePageErr")]
		NewPlayerSupportRolePageErr,
		// Token: 0x0400B974 RID: 47476
		[OriginalName("NewTrialRoleActivityRoleCheckErr")]
		NewTrialRoleActivityRoleCheckErr,
		// Token: 0x0400B975 RID: 47477
		[OriginalName("NewTrialRoleActivityInsNotFind")]
		NewTrialRoleActivityInsNotFind,
		// Token: 0x0400B976 RID: 47478
		[OriginalName("NewTrialRoleActivityInsUnableUse")]
		NewTrialRoleActivityInsUnableUse,
		// Token: 0x0400B977 RID: 47479
		[OriginalName("NewTrialRoleActivityLogicNotFind")]
		NewTrialRoleActivityLogicNotFind,
		// Token: 0x0400B978 RID: 47480
		[OriginalName("NewTrialRoleActivityDelegateNotFind")]
		NewTrialRoleActivityDelegateNotFind,
		// Token: 0x0400B979 RID: 47481
		[OriginalName("RegressNotFindTrialRole")]
		RegressNotFindTrialRole,
		// Token: 0x0400B97A RID: 47482
		[OriginalName("RegressNotFindActivityTrialRole")]
		RegressNotFindActivityTrialRole,
		// Token: 0x0400B97B RID: 47483
		[OriginalName("RegressDisposableReward")]
		RegressDisposableReward,
		// Token: 0x0400B97C RID: 47484
		[OriginalName("RegressDisposableRewardConfigNotFind")]
		RegressDisposableRewardConfigNotFind,
		// Token: 0x0400B97D RID: 47485
		[OriginalName("RegressPayBonusLimit")]
		RegressPayBonusLimit,
		// Token: 0x0400B97E RID: 47486
		[OriginalName("GachaRoleDevelopInsNotOpen")]
		GachaRoleDevelopInsNotOpen,
		// Token: 0x0400B97F RID: 47487
		[OriginalName("PhantomBattleNoComponent")]
		PhantomBattleNoComponent,
		// Token: 0x0400B980 RID: 47488
		[OriginalName("PhantomBattleUnableSkip")]
		PhantomBattleUnableSkip,
		// Token: 0x0400B981 RID: 47489
		[OriginalName("RegressMaxBonusItemNum")]
		RegressMaxBonusItemNum,
		// Token: 0x0400B982 RID: 47490
		[OriginalName("RegressBonusRewardNoConfig")]
		RegressBonusRewardNoConfig,
		// Token: 0x0400B983 RID: 47491
		[OriginalName("RegressBonusBuyLvLimit")]
		RegressBonusBuyLvLimit,
		// Token: 0x0400B984 RID: 47492
		[OriginalName("PhantomBattleCallCardLimt")]
		PhantomBattleCallCardLimt,
		// Token: 0x0400B985 RID: 47493
		[OriginalName("PhantomBattleCallItemLimt")]
		PhantomBattleCallItemLimt,
		// Token: 0x0400B986 RID: 47494
		[OriginalName("GachaRoleDevelopInsLimit")]
		GachaRoleDevelopInsLimit,
		// Token: 0x0400B987 RID: 47495
		[OriginalName("GachaRolesilentAreaIdNotFind")]
		GachaRolesilentAreaIdNotFind,
		// Token: 0x0400B988 RID: 47496
		[OriginalName("GachaRolesilentAreaUnlock")]
		GachaRolesilentAreaUnlock,
		// Token: 0x0400B989 RID: 47497
		[OriginalName("NewTrialRoleActivityNotFindTrialRoleConf")]
		NewTrialRoleActivityNotFindTrialRoleConf,
		// Token: 0x0400B98A RID: 47498
		[OriginalName("PhantomBattleSkipErr")]
		PhantomBattleSkipErr,
		// Token: 0x0400B98B RID: 47499
		[OriginalName("NewTrialRoleGachaRoleDevelopNotFind")]
		NewTrialRoleGachaRoleDevelopNotFind,
		// Token: 0x0400B98C RID: 47500
		[OriginalName("RegressTrialRoleLock")]
		RegressTrialRoleLock,
		// Token: 0x0400B98D RID: 47501
		[OriginalName("NewPlayerSupportTrialRoleLock")]
		NewPlayerSupportTrialRoleLock,
		// Token: 0x0400B98E RID: 47502
		[OriginalName("PhantomBattleCopyCardLimit")]
		PhantomBattleCopyCardLimit,
		// Token: 0x0400B98F RID: 47503
		[OriginalName("RegressTrialNoCanRewardTask")]
		RegressTrialNoCanRewardTask,
		// Token: 0x0400B990 RID: 47504
		[OriginalName("NewPlayerSupportNoCanRewardTask")]
		NewPlayerSupportNoCanRewardTask,
		// Token: 0x0400B991 RID: 47505
		[OriginalName("FarmGoldPointReqLimit")]
		FarmGoldPointReqLimit,
		// Token: 0x0400B992 RID: 47506
		[OriginalName("FarmGoldPointReqErr")]
		FarmGoldPointReqErr,
		// Token: 0x0400B993 RID: 47507
		[OriginalName("FarmGoldPointReqRe")]
		FarmGoldPointReqRe,
		// Token: 0x0400B994 RID: 47508
		[OriginalName("FarmGoldLevelReqLimit")]
		FarmGoldLevelReqLimit,
		// Token: 0x0400B995 RID: 47509
		[OriginalName("FarmGoldLevelReqErr")]
		FarmGoldLevelReqErr,
		// Token: 0x0400B996 RID: 47510
		[OriginalName("FarmGoldLevelReqRe")]
		FarmGoldLevelReqRe,
		// Token: 0x0400B997 RID: 47511
		[OriginalName("FarmGoldPointRewardDropErr")]
		FarmGoldPointRewardDropErr,
		// Token: 0x0400B998 RID: 47512
		[OriginalName("FarmGoldLevelRewardDropErr")]
		FarmGoldLevelRewardDropErr,
		// Token: 0x0400B999 RID: 47513
		[OriginalName("NewTrialRoleInCurTeam")]
		NewTrialRoleInCurTeam,
		// Token: 0x0400B99A RID: 47514
		[OriginalName("RegressEndTimeErr")]
		RegressEndTimeErr,
		// Token: 0x0400B99B RID: 47515
		[OriginalName("NewTrialRoleMatchingUnableTrial")]
		NewTrialRoleMatchingUnableTrial,
		// Token: 0x0400B99C RID: 47516
		[OriginalName("PhBaFindCd")]
		PhBaFindCd,
		// Token: 0x0400B99D RID: 47517
		[OriginalName("PhBaTargetPlanNotExist")]
		PhBaTargetPlanNotExist,
		// Token: 0x0400B99E RID: 47518
		[OriginalName("PhBaPlanUploadErr")]
		PhBaPlanUploadErr,
		// Token: 0x0400B99F RID: 47519
		[OriginalName("PhBaPlanErr")]
		PhBaPlanErr,
		// Token: 0x0400B9A0 RID: 47520
		[OriginalName("PhBaSaveCd")]
		PhBaSaveCd,
		// Token: 0x0400B9A1 RID: 47521
		[OriginalName("PhBaAttrNotInCost")]
		PhBaAttrNotInCost,
		// Token: 0x0400B9A2 RID: 47522
		[OriginalName("PhBaCostMainPropNotExist")]
		PhBaCostMainPropNotExist,
		// Token: 0x0400B9A3 RID: 47523
		[OriginalName("PhBaFetterGroupLimit")]
		PhBaFetterGroupLimit,
		// Token: 0x0400B9A4 RID: 47524
		[OriginalName("PhBaAttrTypeLimit")]
		PhBaAttrTypeLimit,
		// Token: 0x0400B9A5 RID: 47525
		[OriginalName("PhBaCostTypeNumLimit")]
		PhBaCostTypeNumLimit,
		// Token: 0x0400B9A6 RID: 47526
		[OriginalName("PhBaCodeLimit")]
		PhBaCodeLimit,
		// Token: 0x0400B9A7 RID: 47527
		[OriginalName("PhBaCodeIllegal")]
		PhBaCodeIllegal,
		// Token: 0x0400B9A8 RID: 47528
		[OriginalName("PhBaCurUsePlanNotExist")]
		PhBaCurUsePlanNotExist,
		// Token: 0x0400B9A9 RID: 47529
		[OriginalName("PhBaTargetSuitNotExist")]
		PhBaTargetSuitNotExist,
		// Token: 0x0400B9AA RID: 47530
		[OriginalName("PhBaPlanFuncNotOpen")]
		PhBaPlanFuncNotOpen,
		// Token: 0x0400B9AB RID: 47531
		[OriginalName("InsUnableMultiEnter")]
		InsUnableMultiEnter,
		// Token: 0x0400B9AC RID: 47532
		[OriginalName("PhBaPlanSuitCountErr")]
		PhBaPlanSuitCountErr,
		// Token: 0x0400B9AD RID: 47533
		[OriginalName("PhBaPlanTargetSuitNotExist")]
		PhBaPlanTargetSuitNotExist,
		// Token: 0x0400B9AE RID: 47534
		[OriginalName("NewTrialRoleNumLimit")]
		NewTrialRoleNumLimit,
		// Token: 0x0400B9AF RID: 47535
		[OriginalName("PhBaPlanCostTypeRepeat")]
		PhBaPlanCostTypeRepeat,
		// Token: 0x0400B9B0 RID: 47536
		[OriginalName("PhBaPlanSuitIdRepeat")]
		PhBaPlanSuitIdRepeat,
		// Token: 0x0400B9B1 RID: 47537
		[OriginalName("RacingBetsNotFindOrderListDango")]
		RacingBetsNotFindOrderListDango,
		// Token: 0x0400B9B2 RID: 47538
		[OriginalName("PhBaPlanBatchOperEnumErr")]
		PhBaPlanBatchOperEnumErr,
		// Token: 0x0400B9B3 RID: 47539
		[OriginalName("PhBaPlanRemotePlanNotExist")]
		PhBaPlanRemotePlanNotExist,
		// Token: 0x0400B9B4 RID: 47540
		[OriginalName("H5ViewActivityNotFindDb")]
		H5ViewActivityNotFindDb,
		// Token: 0x0400B9B5 RID: 47541
		[OriginalName("ForoRanchWeekInsNotFind")]
		ForoRanchWeekInsNotFind,
		// Token: 0x0400B9B6 RID: 47542
		[OriginalName("PhBaPlanCodeCreateErr")]
		PhBaPlanCodeCreateErr,
		// Token: 0x0400B9B7 RID: 47543
		[OriginalName("RacingBetsOddsDangoIllegal")]
		RacingBetsOddsDangoIllegal,
		// Token: 0x0400B9B8 RID: 47544
		[OriginalName("ForoRanchNotCurEvent")]
		ForoRanchNotCurEvent,
		// Token: 0x0400B9B9 RID: 47545
		[OriginalName("ForoRanchEventIncIdErr")]
		ForoRanchEventIncIdErr,
		// Token: 0x0400B9BA RID: 47546
		[OriginalName("ForoRanchEventChoiceErr")]
		ForoRanchEventChoiceErr,
		// Token: 0x0400B9BB RID: 47547
		[OriginalName("ForoRanchEventSubChoicesConfNotExist")]
		ForoRanchEventSubChoicesConfNotExist,
		// Token: 0x0400B9BC RID: 47548
		[OriginalName("ForoRanchEventChoicesConfNotExist")]
		ForoRanchEventChoicesConfNotExist,
		// Token: 0x0400B9BD RID: 47549
		[OriginalName("ForoRanchSubInsIdNoActivityId")]
		ForoRanchSubInsIdNoActivityId,
		// Token: 0x0400B9BE RID: 47550
		[OriginalName("ForoRanchGetSubWeekInsErr")]
		ForoRanchGetSubWeekInsErr,
		// Token: 0x0400B9BF RID: 47551
		[OriginalName("ForoRanchSubInsNotOpen")]
		ForoRanchSubInsNotOpen,
		// Token: 0x0400B9C0 RID: 47552
		[OriginalName("ForoRanchVoidToyNotEnough")]
		ForoRanchVoidToyNotEnough,
		// Token: 0x0400B9C1 RID: 47553
		[OriginalName("ForoRanchToyNotEnough")]
		ForoRanchToyNotEnough,
		// Token: 0x0400B9C2 RID: 47554
		[OriginalName("RoverRogueInsNotExist")]
		RoverRogueInsNotExist,
		// Token: 0x0400B9C3 RID: 47555
		[OriginalName("RoverRogueCompCreateFail")]
		RoverRogueCompCreateFail,
		// Token: 0x0400B9C4 RID: 47556
		[OriginalName("RoverRogueNotFindRoomConf")]
		RoverRogueNotFindRoomConf,
		// Token: 0x0400B9C5 RID: 47557
		[OriginalName("RoverRogueNotFindBornEntityId")]
		RoverRogueNotFindBornEntityId,
		// Token: 0x0400B9C6 RID: 47558
		[OriginalName("RoverRogueLootLock")]
		RoverRogueLootLock,
		// Token: 0x0400B9C7 RID: 47559
		[OriginalName("RoverRogueComponentNotFind")]
		RoverRogueComponentNotFind,
		// Token: 0x0400B9C8 RID: 47560
		[OriginalName("RoverRogueGetNextRoomFail")]
		RoverRogueGetNextRoomFail,
		// Token: 0x0400B9C9 RID: 47561
		[OriginalName("RoverRogueExitNumLess")]
		RoverRogueExitNumLess,
		// Token: 0x0400B9CA RID: 47562
		[OriginalName("RoverRogueExitEntityConfNotFind")]
		RoverRogueExitEntityConfNotFind,
		// Token: 0x0400B9CB RID: 47563
		[OriginalName("RoverRogueCreateExitEntityFail")]
		RoverRogueCreateExitEntityFail,
		// Token: 0x0400B9CC RID: 47564
		[OriginalName("RoverRogueNotFindRoomTypeConf")]
		RoverRogueNotFindRoomTypeConf,
		// Token: 0x0400B9CD RID: 47565
		[OriginalName("RoverRoguePortalEntityNotFind")]
		RoverRoguePortalEntityNotFind,
		// Token: 0x0400B9CE RID: 47566
		[OriginalName("RoverRogueNotFindEntityLogic")]
		RoverRogueNotFindEntityLogic,
		// Token: 0x0400B9CF RID: 47567
		[OriginalName("RoverRogueInsCtxNotExist")]
		RoverRogueInsCtxNotExist,
		// Token: 0x0400B9D0 RID: 47568
		[OriginalName("RoverRogueRoleConfNotExist")]
		RoverRogueRoleConfNotExist,
		// Token: 0x0400B9D1 RID: 47569
		[OriginalName("RoverRogueGainDataTypeErr")]
		RoverRogueGainDataTypeErr,
		// Token: 0x0400B9D2 RID: 47570
		[OriginalName("RoverRogueGainActiveErr")]
		RoverRogueGainActiveErr,
		// Token: 0x0400B9D3 RID: 47571
		[OriginalName("RoverRogueRewardDbNotExist")]
		RoverRogueRewardDbNotExist,
		// Token: 0x0400B9D4 RID: 47572
		[OriginalName("RoverRogueGainSelectNotExist")]
		RoverRogueGainSelectNotExist,
		// Token: 0x0400B9D5 RID: 47573
		[OriginalName("RoverRogueGainTagChangeErr")]
		RoverRogueGainTagChangeErr,
		// Token: 0x0400B9D6 RID: 47574
		[OriginalName("RoverRogueGainLogicNotFind")]
		RoverRogueGainLogicNotFind,
		// Token: 0x0400B9D7 RID: 47575
		[OriginalName("RoverRogueGainLogicErr")]
		RoverRogueGainLogicErr,
		// Token: 0x0400B9D8 RID: 47576
		[OriginalName("ForoRanchWeeklyCanNotMilestone")]
		ForoRanchWeeklyCanNotMilestone,
		// Token: 0x0400B9D9 RID: 47577
		[OriginalName("RoverRogueRewardDbToken")]
		RoverRogueRewardDbToken,
		// Token: 0x0400B9DA RID: 47578
		[OriginalName("RoverRogueRoleTypeConfNotExist")]
		RoverRogueRoleTypeConfNotExist,
		// Token: 0x0400B9DB RID: 47579
		[OriginalName("RoverRogueRoomRewardNotInit")]
		RoverRogueRoomRewardNotInit,
		// Token: 0x0400B9DC RID: 47580
		[OriginalName("RoverRogueRoomTaskNotExist")]
		RoverRogueRoomTaskNotExist,
		// Token: 0x0400B9DD RID: 47581
		[OriginalName("RoverRogueRoomBlessGroupTaskNotExist")]
		RoverRogueRoomBlessGroupTaskNotExist,
		// Token: 0x0400B9DE RID: 47582
		[OriginalName("RoverRogueRoomTaskTypeErr")]
		RoverRogueRoomTaskTypeErr,
		// Token: 0x0400B9DF RID: 47583
		[OriginalName("RoverRogueRoomTaskParamErr")]
		RoverRogueRoomTaskParamErr,
		// Token: 0x0400B9E0 RID: 47584
		[OriginalName("RoverRogueRoomTaskIsToken")]
		RoverRogueRoomTaskIsToken,
		// Token: 0x0400B9E1 RID: 47585
		[OriginalName("RoverRogueNotCompletedInsErr")]
		RoverRogueNotCompletedInsErr,
		// Token: 0x0400B9E2 RID: 47586
		[OriginalName("RoverRogueNotFindRoomRewardConf")]
		RoverRogueNotFindRoomRewardConf,
		// Token: 0x0400B9E3 RID: 47587
		[OriginalName("RoverRogueRoomNotFinish")]
		RoverRogueRoomNotFinish,
		// Token: 0x0400B9E4 RID: 47588
		[OriginalName("RoverRogueRoomRewardNotActivate")]
		RoverRogueRoomRewardNotActivate,
		// Token: 0x0400B9E5 RID: 47589
		[OriginalName("RoverRogueRoomRewardCache")]
		RoverRogueRoomRewardCache,
		// Token: 0x0400B9E6 RID: 47590
		[OriginalName("RoverRogueRoleListErr")]
		RoverRogueRoleListErr,
		// Token: 0x0400B9E7 RID: 47591
		[OriginalName("RoverRogueRoleTypeErr")]
		RoverRogueRoleTypeErr,
		// Token: 0x0400B9E8 RID: 47592
		[OriginalName("RoverRogueNotFindActConf")]
		RoverRogueNotFindActConf,
		// Token: 0x0400B9E9 RID: 47593
		[OriginalName("RoverRogueLootNumLimit")]
		RoverRogueLootNumLimit,
		// Token: 0x0400B9EA RID: 47594
		[OriginalName("RoverRogueNotFindBlessRoleConf")]
		RoverRogueNotFindBlessRoleConf,
		// Token: 0x0400B9EB RID: 47595
		[OriginalName("RoverRogueNotFindBollToPortal")]
		RoverRogueNotFindBollToPortal,
		// Token: 0x0400B9EC RID: 47596
		[OriginalName("RoverRogueNotFindBollNotExist")]
		RoverRogueNotFindBollNotExist,
		// Token: 0x0400B9ED RID: 47597
		[OriginalName("RoverRogueNotFindRoomRoadConf")]
		RoverRogueNotFindRoomRoadConf,
		// Token: 0x0400B9EE RID: 47598
		[OriginalName("RoverRogueNotFindChaosConf")]
		RoverRogueNotFindChaosConf,
		// Token: 0x0400B9EF RID: 47599
		[OriginalName("RoverRogueChaosExitNotEnough")]
		RoverRogueChaosExitNotEnough,
		// Token: 0x0400B9F0 RID: 47600
		[OriginalName("RoverRoguePosNotFind")]
		RoverRoguePosNotFind,
		// Token: 0x0400B9F1 RID: 47601
		[OriginalName("RoverRogueChangeSameLoot")]
		RoverRogueChangeSameLoot,
		// Token: 0x0400B9F2 RID: 47602
		[OriginalName("GateUdpPortNotExist")]
		GateUdpPortNotExist = 2800000,
		// Token: 0x0400B9F3 RID: 47603
		[OriginalName("GateKcpGetConvFail")]
		GateKcpGetConvFail,
		// Token: 0x0400B9F4 RID: 47604
		[OriginalName("ErrScreenActionExecutorNotFind")]
		ErrScreenActionExecutorNotFind = 2900000,
		// Token: 0x0400B9F5 RID: 47605
		[OriginalName("ErrScreenActionInfoNotFind")]
		ErrScreenActionInfoNotFind,
		// Token: 0x0400B9F6 RID: 47606
		[OriginalName("ErrScreenActionTypeNotMatch")]
		ErrScreenActionTypeNotMatch,
		// Token: 0x0400B9F7 RID: 47607
		[OriginalName("ErrScreenActionNotFadeInScreen")]
		ErrScreenActionNotFadeInScreen,
		// Token: 0x0400B9F8 RID: 47608
		[OriginalName("ErrScreenActionNotFadeOutScreen")]
		ErrScreenActionNotFadeOutScreen,
		// Token: 0x0400B9F9 RID: 47609
		[OriginalName("ErrSceneItemSequenceFrameRegister")]
		ErrSceneItemSequenceFrameRegister,
		// Token: 0x0400B9FA RID: 47610
		[OriginalName("ErrSceneItemSequenceFrameComponentConfig")]
		ErrSceneItemSequenceFrameComponentConfig,
		// Token: 0x0400B9FB RID: 47611
		[OriginalName("ErrSceneItemSequenceFrameComponent")]
		ErrSceneItemSequenceFrameComponent,
		// Token: 0x0400B9FC RID: 47612
		[OriginalName("ErrSceneItemSequenceFrame")]
		ErrSceneItemSequenceFrame,
		// Token: 0x0400B9FD RID: 47613
		[OriginalName("ErrSceneItemSequenceFrameMatchEventCbType")]
		ErrSceneItemSequenceFrameMatchEventCbType,
		// Token: 0x0400B9FE RID: 47614
		[OriginalName("ErrSceneItemSequenceFrameNeedServerAction")]
		ErrSceneItemSequenceFrameNeedServerAction,
		// Token: 0x0400B9FF RID: 47615
		[OriginalName("ErrSceneItemSequenceFrameUnAnsEvent")]
		ErrSceneItemSequenceFrameUnAnsEvent,
		// Token: 0x0400BA00 RID: 47616
		[OriginalName("ErrSceneBlockSplitNotBlock")]
		ErrSceneBlockSplitNotBlock = 2900027,
		// Token: 0x0400BA01 RID: 47617
		[OriginalName("ErrSunSpiritCollectOverNum")]
		ErrSunSpiritCollectOverNum = 2900012,
		// Token: 0x0400BA02 RID: 47618
		[OriginalName("ErrSunSpiritInteractAction")]
		ErrSunSpiritInteractAction,
		// Token: 0x0400BA03 RID: 47619
		[OriginalName("ErrSunSpiritGetComponentConfig")]
		ErrSunSpiritGetComponentConfig,
		// Token: 0x0400BA04 RID: 47620
		[OriginalName("ErrSunSpiritEntityRemove")]
		ErrSunSpiritEntityRemove,
		// Token: 0x0400BA05 RID: 47621
		[OriginalName("ErrSunSpiritRepeateAdd")]
		ErrSunSpiritRepeateAdd,
		// Token: 0x0400BA06 RID: 47622
		[OriginalName("ErrSunSpiritNumUnEnough")]
		ErrSunSpiritNumUnEnough,
		// Token: 0x0400BA07 RID: 47623
		[OriginalName("ErrSunSpiritEnableEntityHistoryUse")]
		ErrSunSpiritEnableEntityHistoryUse,
		// Token: 0x0400BA08 RID: 47624
		[OriginalName("ErrSunSpiritGetPlayerTempOccupySunSpiritInfo")]
		ErrSunSpiritGetPlayerTempOccupySunSpiritInfo,
		// Token: 0x0400BA09 RID: 47625
		[OriginalName("ErrSunSpiritActionExecutorNotFind")]
		ErrSunSpiritActionExecutorNotFind,
		// Token: 0x0400BA0A RID: 47626
		[OriginalName("ErrSunSpiritActionInfoNotFind")]
		ErrSunSpiritActionInfoNotFind,
		// Token: 0x0400BA0B RID: 47627
		[OriginalName("ErrSunSpiritActionIndexNotMatch")]
		ErrSunSpiritActionIndexNotMatch,
		// Token: 0x0400BA0C RID: 47628
		[OriginalName("ErrSunSpiritActionTypeNotMatch")]
		ErrSunSpiritActionTypeNotMatch,
		// Token: 0x0400BA0D RID: 47629
		[OriginalName("ErrSunSpiritActionParamOperationType")]
		ErrSunSpiritActionParamOperationType,
		// Token: 0x0400BA0E RID: 47630
		[OriginalName("ErrSunSpiritAreaConfig")]
		ErrSunSpiritAreaConfig,
		// Token: 0x0400BA0F RID: 47631
		[OriginalName("ErrSunSpiritNotHostPlayer")]
		ErrSunSpiritNotHostPlayer,
		// Token: 0x0400BA10 RID: 47632
		[OriginalName("ErrResourcePackageSdkCheck")]
		ErrResourcePackageSdkCheck = 2900028,
		// Token: 0x0400BA11 RID: 47633
		[OriginalName("ErrResourcePackageFuncClose")]
		ErrResourcePackageFuncClose,
		// Token: 0x0400BA12 RID: 47634
		[OriginalName("ErrResourcePackageRedisWrite")]
		ErrResourcePackageRedisWrite,
		// Token: 0x0400BA13 RID: 47635
		[OriginalName("ErrResourcePackageInvalidToken")]
		ErrResourcePackageInvalidToken,
		// Token: 0x0400BA14 RID: 47636
		[OriginalName("ErrResourcePackageRateLimiterCircuit")]
		ErrResourcePackageRateLimiterCircuit,
		// Token: 0x0400BA15 RID: 47637
		[OriginalName("ErrResourcePackageRateLimiterRejected")]
		ErrResourcePackageRateLimiterRejected,
		// Token: 0x0400BA16 RID: 47638
		[OriginalName("ErrResourcePackageException")]
		ErrResourcePackageException,
		// Token: 0x0400BA17 RID: 47639
		[OriginalName("ErrResourcePackageTimeoutRejected")]
		ErrResourcePackageTimeoutRejected,
		// Token: 0x0400BA18 RID: 47640
		[OriginalName("ErrAvoidBlockGetInstComponent")]
		ErrAvoidBlockGetInstComponent,
		// Token: 0x0400BA19 RID: 47641
		[OriginalName("ErrLoadCalabashDefault")]
		ErrLoadCalabashDefault = 3000000,
		// Token: 0x0400BA1A RID: 47642
		[OriginalName("CalabashSkinUnLockErr")]
		CalabashSkinUnLockErr,
		// Token: 0x0400BA1B RID: 47643
		[OriginalName("RepeqtedRequest")]
		RepeqtedRequest,
		// Token: 0x0400BA1C RID: 47644
		[OriginalName("ErrSynthesisBatchItemNotSupport")]
		ErrSynthesisBatchItemNotSupport,
		// Token: 0x0400BA1D RID: 47645
		[OriginalName("ErrSynthesisBatchItemDeadLoop")]
		ErrSynthesisBatchItemDeadLoop,
		// Token: 0x0400BA1E RID: 47646
		[OriginalName("ErrSynthesisBatchItemCntNotMatch")]
		ErrSynthesisBatchItemCntNotMatch,
		// Token: 0x0400BA1F RID: 47647
		[OriginalName("ErrSynthesisBatchItemReapeat")]
		ErrSynthesisBatchItemReapeat,
		// Token: 0x0400BA20 RID: 47648
		[OriginalName("ErrBatchSynthesisCoinOverflow")]
		ErrBatchSynthesisCoinOverflow,
		// Token: 0x0400BA21 RID: 47649
		[OriginalName("ErrPhantomSkinNotExist")]
		ErrPhantomSkinNotExist,
		// Token: 0x0400BA22 RID: 47650
		[OriginalName("ErrPhantomSkinNotUnlock")]
		ErrPhantomSkinNotUnlock,
		// Token: 0x0400BA23 RID: 47651
		[OriginalName("ErrPhantomInteractionNotUnlock")]
		ErrPhantomInteractionNotUnlock,
		// Token: 0x0400BA24 RID: 47652
		[OriginalName("ErrIllustratedNotUnlock")]
		ErrIllustratedNotUnlock,
		// Token: 0x0400BA25 RID: 47653
		[OriginalName("ErrPhantomInteractionEquipCountNotMatch")]
		ErrPhantomInteractionEquipCountNotMatch,
		// Token: 0x0400BA26 RID: 47654
		[OriginalName("ErrPhantomInteractionConfigNotFind")]
		ErrPhantomInteractionConfigNotFind,
		// Token: 0x0400BA27 RID: 47655
		[OriginalName("ErrPhantomSkinRepeatOperation")]
		ErrPhantomSkinRepeatOperation = 3000044,
		// Token: 0x0400BA28 RID: 47656
		[OriginalName("ErrPhantomInteractionNotShowable")]
		ErrPhantomInteractionNotShowable,
		// Token: 0x0400BA29 RID: 47657
		[OriginalName("ErrArtemisNodeNoConfig")]
		ErrArtemisNodeNoConfig = 3000014,
		// Token: 0x0400BA2A RID: 47658
		[OriginalName("ErrArtemisActivityNotOpen")]
		ErrArtemisActivityNotOpen,
		// Token: 0x0400BA2B RID: 47659
		[OriginalName("ErrArtemisNodeNoData")]
		ErrArtemisNodeNoData,
		// Token: 0x0400BA2C RID: 47660
		[OriginalName("ErrArtemisNodeNoUnlock")]
		ErrArtemisNodeNoUnlock,
		// Token: 0x0400BA2D RID: 47661
		[OriginalName("ErrArtemisNodeNotRewardStatus")]
		ErrArtemisNodeNotRewardStatus,
		// Token: 0x0400BA2E RID: 47662
		[OriginalName("ErrArtemisNodeAlreadyFixed")]
		ErrArtemisNodeAlreadyFixed,
		// Token: 0x0400BA2F RID: 47663
		[OriginalName("ErrArtemisNodeAlreadyFinished")]
		ErrArtemisNodeAlreadyFinished,
		// Token: 0x0400BA30 RID: 47664
		[OriginalName("ErrArtemisState")]
		ErrArtemisState,
		// Token: 0x0400BA31 RID: 47665
		[OriginalName("ErrArtemisInvalidUpdate")]
		ErrArtemisInvalidUpdate,
		// Token: 0x0400BA32 RID: 47666
		[OriginalName("ErrIndexOutOfRange")]
		ErrIndexOutOfRange,
		// Token: 0x0400BA33 RID: 47667
		[OriginalName("ErrArtemisActivityNotExist")]
		ErrArtemisActivityNotExist,
		// Token: 0x0400BA34 RID: 47668
		[OriginalName("MotorParkourLevelNoOpen")]
		MotorParkourLevelNoOpen,
		// Token: 0x0400BA35 RID: 47669
		[OriginalName("MotorParkourNoConfig")]
		MotorParkourNoConfig,
		// Token: 0x0400BA36 RID: 47670
		[OriginalName("MotorParkourInstComponentNotExist")]
		MotorParkourInstComponentNotExist,
		// Token: 0x0400BA37 RID: 47671
		[OriginalName("MotorParkourGetTimeRecordFailed")]
		MotorParkourGetTimeRecordFailed,
		// Token: 0x0400BA38 RID: 47672
		[OriginalName("ErrMotorParkourLevelRewardIndexLengthError")]
		ErrMotorParkourLevelRewardIndexLengthError,
		// Token: 0x0400BA39 RID: 47673
		[OriginalName("ErrMotorParkourActivityDataNotExist")]
		ErrMotorParkourActivityDataNotExist,
		// Token: 0x0400BA3A RID: 47674
		[OriginalName("ErrMotorParkourLevelRewardIndexInvalid")]
		ErrMotorParkourLevelRewardIndexInvalid,
		// Token: 0x0400BA3B RID: 47675
		[OriginalName("ErrMotorParkourRecordCfgNotExist")]
		ErrMotorParkourRecordCfgNotExist,
		// Token: 0x0400BA3C RID: 47676
		[OriginalName("ErrMotorParkourGetRewardStatusFail")]
		ErrMotorParkourGetRewardStatusFail,
		// Token: 0x0400BA3D RID: 47677
		[OriginalName("ErrMotorParkourRewardNotAvailable")]
		ErrMotorParkourRewardNotAvailable,
		// Token: 0x0400BA3E RID: 47678
		[OriginalName("ErrMotorParkourLevelRewardIndexDuplicate")]
		ErrMotorParkourLevelRewardIndexDuplicate,
		// Token: 0x0400BA3F RID: 47679
		[OriginalName("ErrMotorParkourRewardCfgNotExist")]
		ErrMotorParkourRewardCfgNotExist = 3000043,
		// Token: 0x0400BA40 RID: 47680
		[OriginalName("ErrMotorParkourLevelInfoFailed")]
		ErrMotorParkourLevelInfoFailed = 3000046,
		// Token: 0x0400BA41 RID: 47681
		[OriginalName("ErrMotorParkourPreLevelNotComplete")]
		ErrMotorParkourPreLevelNotComplete = 3000073,
		// Token: 0x0400BA42 RID: 47682
		[OriginalName("ErrAreaTerminalPinFull")]
		ErrAreaTerminalPinFull = 3000036,
		// Token: 0x0400BA43 RID: 47683
		[OriginalName("ErrAreaTerminalPinExist")]
		ErrAreaTerminalPinExist,
		// Token: 0x0400BA44 RID: 47684
		[OriginalName("ErrAreaTerminalPinNotExist")]
		ErrAreaTerminalPinNotExist,
		// Token: 0x0400BA45 RID: 47685
		[OriginalName("ErrAreaTerminalParamError")]
		ErrAreaTerminalParamError,
		// Token: 0x0400BA46 RID: 47686
		[OriginalName("ErrActivityLock")]
		ErrActivityLock,
		// Token: 0x0400BA47 RID: 47687
		[OriginalName("ErrFuncLock")]
		ErrFuncLock,
		// Token: 0x0400BA48 RID: 47688
		[OriginalName("ErrNoAreaTerminalCfg")]
		ErrNoAreaTerminalCfg,
		// Token: 0x0400BA49 RID: 47689
		[OriginalName("ErrSpringFestivalActivityConfigNotFound")]
		ErrSpringFestivalActivityConfigNotFound = 3000068,
		// Token: 0x0400BA4A RID: 47690
		[OriginalName("ErrSpringFestivalActivityDataNotFound")]
		ErrSpringFestivalActivityDataNotFound,
		// Token: 0x0400BA4B RID: 47691
		[OriginalName("ErrSpringFestivalComponentNotFound")]
		ErrSpringFestivalComponentNotFound,
		// Token: 0x0400BA4C RID: 47692
		[OriginalName("ErrSpringFestivalRuntimeInfoNotFound")]
		ErrSpringFestivalRuntimeInfoNotFound,
		// Token: 0x0400BA4D RID: 47693
		[OriginalName("ErrMultiModeCanNotRequest")]
		ErrMultiModeCanNotRequest = 3000083,
		// Token: 0x0400BA4E RID: 47694
		[OriginalName("ErrSpringFestivalActivityNotOpen")]
		ErrSpringFestivalActivityNotOpen,
		// Token: 0x0400BA4F RID: 47695
		[OriginalName("ErrSpringFestivalFuncNotExist")]
		ErrSpringFestivalFuncNotExist = 3000100,
		// Token: 0x0400BA50 RID: 47696
		[OriginalName("ErrSpringFestivalFuncLock")]
		ErrSpringFestivalFuncLock,
		// Token: 0x0400BA51 RID: 47697
		[OriginalName("ErrSpringFestivalActivityIdNotMatch")]
		ErrSpringFestivalActivityIdNotMatch = 3000103,
		// Token: 0x0400BA52 RID: 47698
		[OriginalName("ErrFurnitureDiyActivityConfigNotFound")]
		ErrFurnitureDiyActivityConfigNotFound = 3000047,
		// Token: 0x0400BA53 RID: 47699
		[OriginalName("ErrFurnitureAreaIdNotExistInActivity")]
		ErrFurnitureAreaIdNotExistInActivity,
		// Token: 0x0400BA54 RID: 47700
		[OriginalName("ErrFurnitureAreaConfigNotFound")]
		ErrFurnitureAreaConfigNotFound,
		// Token: 0x0400BA55 RID: 47701
		[OriginalName("ErrFurnitureDiyActivityDataNotFound")]
		ErrFurnitureDiyActivityDataNotFound,
		// Token: 0x0400BA56 RID: 47702
		[OriginalName("ErrFurnitureSlotConfigNotExist")]
		ErrFurnitureSlotConfigNotExist,
		// Token: 0x0400BA57 RID: 47703
		[OriginalName("ErrFurnitureConfigNotExist")]
		ErrFurnitureConfigNotExist,
		// Token: 0x0400BA58 RID: 47704
		[OriginalName("ErrFurnitureNotAvailable")]
		ErrFurnitureNotAvailable,
		// Token: 0x0400BA59 RID: 47705
		[OriginalName("ErrFurnitureAreaDataNotFound")]
		ErrFurnitureAreaDataNotFound,
		// Token: 0x0400BA5A RID: 47706
		[OriginalName("ErrSpecificFurnitureCount")]
		ErrSpecificFurnitureCount,
		// Token: 0x0400BA5B RID: 47707
		[OriginalName("ErrFurnitureSlotNotSupportChildTag")]
		ErrFurnitureSlotNotSupportChildTag,
		// Token: 0x0400BA5C RID: 47708
		[OriginalName("ErrFurnitureSlotNotSupportFurniture")]
		ErrFurnitureSlotNotSupportFurniture,
		// Token: 0x0400BA5D RID: 47709
		[OriginalName("ErrFurnitureDiyComponentNotFound")]
		ErrFurnitureDiyComponentNotFound,
		// Token: 0x0400BA5E RID: 47710
		[OriginalName("ErrNotFurnitureSlotConfig")]
		ErrNotFurnitureSlotConfig,
		// Token: 0x0400BA5F RID: 47711
		[OriginalName("ErrFurnitureSlotConfigSlotCountError")]
		ErrFurnitureSlotConfigSlotCountError,
		// Token: 0x0400BA60 RID: 47712
		[OriginalName("ErrFurnitureSlotSubFurnitureCount")]
		ErrFurnitureSlotSubFurnitureCount,
		// Token: 0x0400BA61 RID: 47713
		[OriginalName("ErrFurnitureEntityConfigNotFound")]
		ErrFurnitureEntityConfigNotFound,
		// Token: 0x0400BA62 RID: 47714
		[OriginalName("ErrEntityCreateFailed")]
		ErrEntityCreateFailed,
		// Token: 0x0400BA63 RID: 47715
		[OriginalName("ErrFurnitureUnloadSubFurnitureNotEmpty")]
		ErrFurnitureUnloadSubFurnitureNotEmpty,
		// Token: 0x0400BA64 RID: 47716
		[OriginalName("ErrEntitiesNull")]
		ErrEntitiesNull,
		// Token: 0x0400BA65 RID: 47717
		[OriginalName("ErrConvertShortIdToFurnitureIdFailed")]
		ErrConvertShortIdToFurnitureIdFailed,
		// Token: 0x0400BA66 RID: 47718
		[OriginalName("ErrFurnitureSlotDuplicateInRequest")]
		ErrFurnitureSlotDuplicateInRequest,
		// Token: 0x0400BA67 RID: 47719
		[OriginalName("ErrFurnitureSlotNotBelongToArea")]
		ErrFurnitureSlotNotBelongToArea = 3000106,
		// Token: 0x0400BA68 RID: 47720
		[OriginalName("ErrSpringFestivalFurnitureHadUnlock")]
		ErrSpringFestivalFurnitureHadUnlock = 3000117,
		// Token: 0x0400BA69 RID: 47721
		[OriginalName("ErrExploreDegreeTypeNotFound")]
		ErrExploreDegreeTypeNotFound = 3000072,
		// Token: 0x0400BA6A RID: 47722
		[OriginalName("ErrActivityBrochureCfgNotFound")]
		ErrActivityBrochureCfgNotFound = 3000074,
		// Token: 0x0400BA6B RID: 47723
		[OriginalName("ErrBrochureRewardRequestEmptyBookItems")]
		ErrBrochureRewardRequestEmptyBookItems,
		// Token: 0x0400BA6C RID: 47724
		[OriginalName("ErrBrochureCfgNotFound")]
		ErrBrochureCfgNotFound,
		// Token: 0x0400BA6D RID: 47725
		[OriginalName("ErrBrochureNotBelongToActivity")]
		ErrBrochureNotBelongToActivity,
		// Token: 0x0400BA6E RID: 47726
		[OriginalName("ErrBrochureNotUnlock")]
		ErrBrochureNotUnlock,
		// Token: 0x0400BA6F RID: 47727
		[OriginalName("ErrBrochureRewardRequestDuplicateBookItem")]
		ErrBrochureRewardRequestDuplicateBookItem,
		// Token: 0x0400BA70 RID: 47728
		[OriginalName("ErrBookItemCfgNotFound")]
		ErrBookItemCfgNotFound,
		// Token: 0x0400BA71 RID: 47729
		[OriginalName("ErrBookItemNotFinish")]
		ErrBookItemNotFinish,
		// Token: 0x0400BA72 RID: 47730
		[OriginalName("ErrBookItemAlreadyRewarded")]
		ErrBookItemAlreadyRewarded,
		// Token: 0x0400BA73 RID: 47731
		[OriginalName("ErrBrochureRewardTimeInvalid")]
		ErrBrochureRewardTimeInvalid = 3000091,
		// Token: 0x0400BA74 RID: 47732
		[OriginalName("ErrBookItemNotBelongToBrochure")]
		ErrBookItemNotBelongToBrochure = 3000104,
		// Token: 0x0400BA75 RID: 47733
		[OriginalName("ErrExhibitionComponentCfgNotExist")]
		ErrExhibitionComponentCfgNotExist = 3000085,
		// Token: 0x0400BA76 RID: 47734
		[OriginalName("ErrItemTypeNotMatchExhibitType")]
		ErrItemTypeNotMatchExhibitType,
		// Token: 0x0400BA77 RID: 47735
		[OriginalName("ErrExhibitConfigTypeInvalid")]
		ErrExhibitConfigTypeInvalid,
		// Token: 0x0400BA78 RID: 47736
		[OriginalName("ErrExhibitionComponentNotExist")]
		ErrExhibitionComponentNotExist,
		// Token: 0x0400BA79 RID: 47737
		[OriginalName("ErrExhibitionPhantomNotExist")]
		ErrExhibitionPhantomNotExist,
		// Token: 0x0400BA7A RID: 47738
		[OriginalName("ErrRepeatedEntity")]
		ErrRepeatedEntity = 3000092,
		// Token: 0x0400BA7B RID: 47739
		[OriginalName("ErrPhonographMusicNotExist")]
		ErrPhonographMusicNotExist,
		// Token: 0x0400BA7C RID: 47740
		[OriginalName("ErrMusicNotUnlocked")]
		ErrMusicNotUnlocked = 3000102,
		// Token: 0x0400BA7D RID: 47741
		[OriginalName("ErrInstanceConfigNotFound")]
		ErrInstanceConfigNotFound = 3000090,
		// Token: 0x0400BA7E RID: 47742
		[OriginalName("ErrInvalidEnterContextCase")]
		ErrInvalidEnterContextCase = 3000094,
		// Token: 0x0400BA7F RID: 47743
		[OriginalName("ErrTetrisLevelInfoDuplicate")]
		ErrTetrisLevelInfoDuplicate,
		// Token: 0x0400BA80 RID: 47744
		[OriginalName("ErrTetrisActivityDataNotFound")]
		ErrTetrisActivityDataNotFound,
		// Token: 0x0400BA81 RID: 47745
		[OriginalName("ErrTetrisLevelConfigNotExist")]
		ErrTetrisLevelConfigNotExist,
		// Token: 0x0400BA82 RID: 47746
		[OriginalName("ErrTetrisLevelRewardDuplicate")]
		ErrTetrisLevelRewardDuplicate,
		// Token: 0x0400BA83 RID: 47747
		[OriginalName("ErrTetrisLevelStateInvalid")]
		ErrTetrisLevelStateInvalid,
		// Token: 0x0400BA84 RID: 47748
		[OriginalName("ErrActivityNotMatchTetrisLevel")]
		ErrActivityNotMatchTetrisLevel = 3000118,
		// Token: 0x0400BA85 RID: 47749
		[OriginalName("ErrTetrisTargetScoreIdNotExist")]
		ErrTetrisTargetScoreIdNotExist,
		// Token: 0x0400BA86 RID: 47750
		[OriginalName("ErrTetrisLevelHasRewarded")]
		ErrTetrisLevelHasRewarded,
		// Token: 0x0400BA87 RID: 47751
		[OriginalName("ErrTetrisLevelNotFinished")]
		ErrTetrisLevelNotFinished,
		// Token: 0x0400BA88 RID: 47752
		[OriginalName("ErrTetrisLevelDifficultyIndexInvalid")]
		ErrTetrisLevelDifficultyIndexInvalid = 3000126,
		// Token: 0x0400BA89 RID: 47753
		[OriginalName("ErrTetrisTargetScoreCountNotMatch")]
		ErrTetrisTargetScoreCountNotMatch,
		// Token: 0x0400BA8A RID: 47754
		[OriginalName("ErrTetrisScoreInvalid")]
		ErrTetrisScoreInvalid,
		// Token: 0x0400BA8B RID: 47755
		[OriginalName("ErrGetVarDefine")]
		ErrGetVarDefine,
		// Token: 0x0400BA8C RID: 47756
		[OriginalName("ErrDataPersistenceTetrisBoardGame")]
		ErrDataPersistenceTetrisBoardGame,
		// Token: 0x0400BA8D RID: 47757
		[OriginalName("ErrTetrisTargetScoreNotEnough")]
		ErrTetrisTargetScoreNotEnough,
		// Token: 0x0400BA8E RID: 47758
		[OriginalName("ErrTetrisConfigInvalid")]
		ErrTetrisConfigInvalid,
		// Token: 0x0400BA8F RID: 47759
		[OriginalName("ErrTetrisPreLevelNotFinished")]
		ErrTetrisPreLevelNotFinished = 3000137,
		// Token: 0x0400BA90 RID: 47760
		[OriginalName("wlf_test")]
		WlfTest = 3000105,
		// Token: 0x0400BA91 RID: 47761
		[OriginalName("DropCatchNoConfig")]
		DropCatchNoConfig = 3000107,
		// Token: 0x0400BA92 RID: 47762
		[OriginalName("DropCatchLevelNotOpen")]
		DropCatchLevelNotOpen,
		// Token: 0x0400BA93 RID: 47763
		[OriginalName("ErrDropCatchLevelRewardIndexLengthError")]
		ErrDropCatchLevelRewardIndexLengthError,
		// Token: 0x0400BA94 RID: 47764
		[OriginalName("ErrDropCatchActivityDataNotExist")]
		ErrDropCatchActivityDataNotExist,
		// Token: 0x0400BA95 RID: 47765
		[OriginalName("ErrDropCatchLevelRewardIndexDuplicate")]
		ErrDropCatchLevelRewardIndexDuplicate,
		// Token: 0x0400BA96 RID: 47766
		[OriginalName("ErrDropCatchLevelRewardIndexInvalid")]
		ErrDropCatchLevelRewardIndexInvalid,
		// Token: 0x0400BA97 RID: 47767
		[OriginalName("ErrDropCatchRewardCfgNotExist")]
		ErrDropCatchRewardCfgNotExist,
		// Token: 0x0400BA98 RID: 47768
		[OriginalName("ErrDropCatchRewardNotAvailable")]
		ErrDropCatchRewardNotAvailable,
		// Token: 0x0400BA99 RID: 47769
		[OriginalName("ErrDropCatchLevelInfoFailed")]
		ErrDropCatchLevelInfoFailed,
		// Token: 0x0400BA9A RID: 47770
		[OriginalName("ErrDropCatchLevelScoreInvalid")]
		ErrDropCatchLevelScoreInvalid,
		// Token: 0x0400BA9B RID: 47771
		[OriginalName("ErrDropCatchEntityComponentNotExist")]
		ErrDropCatchEntityComponentNotExist = 3000122,
		// Token: 0x0400BA9C RID: 47772
		[OriginalName("ErrDropCatchComponentNotExist")]
		ErrDropCatchComponentNotExist,
		// Token: 0x0400BA9D RID: 47773
		[OriginalName("ErrDropCatchRewardCfgNotActivity")]
		ErrDropCatchRewardCfgNotActivity,
		// Token: 0x0400BA9E RID: 47774
		[OriginalName("ErrDropCatchDataNotExist")]
		ErrDropCatchDataNotExist,
		// Token: 0x0400BA9F RID: 47775
		[OriginalName("ErrGetSelfXboxOnlineId")]
		ErrGetSelfXboxOnlineId = 3000133,
		// Token: 0x0400BAA0 RID: 47776
		[OriginalName("ErrXboxPlayerInfoRequestLimit")]
		ErrXboxPlayerInfoRequestLimit,
		// Token: 0x0400BAA1 RID: 47777
		[OriginalName("ErrGetXboxUserPlayerErr")]
		ErrGetXboxUserPlayerErr,
		// Token: 0x0400BAA2 RID: 47778
		[OriginalName("ErrXboxAccountBlocked")]
		ErrXboxAccountBlocked,
		// Token: 0x0400BAA3 RID: 47779
		[OriginalName("InfrV2LevelCfgNotFound")]
		InfrV2LevelCfgNotFound = 3000138,
		// Token: 0x0400BAA4 RID: 47780
		[OriginalName("InfrV2ShopPhaseCfgNotFound")]
		InfrV2ShopPhaseCfgNotFound,
		// Token: 0x0400BAA5 RID: 47781
		[OriginalName("InfrV2ShopGoodsCfgNotFound")]
		InfrV2ShopGoodsCfgNotFound,
		// Token: 0x0400BAA6 RID: 47782
		[OriginalName("InfrV2FireAddExpNegative")]
		InfrV2FireAddExpNegative,
		// Token: 0x0400BAA7 RID: 47783
		[OriginalName("InfrV2FireAlreadyMaxLevel")]
		InfrV2FireAlreadyMaxLevel,
		// Token: 0x0400BAA8 RID: 47784
		[OriginalName("InfrV2FireConditionNotMet")]
		InfrV2FireConditionNotMet,
		// Token: 0x0400BAA9 RID: 47785
		[OriginalName("InfrV2FireExpNotEnough")]
		InfrV2FireExpNotEnough,
		// Token: 0x0400BAAA RID: 47786
		[OriginalName("InfrV2TreeNotInProgress")]
		InfrV2TreeNotInProgress,
		// Token: 0x0400BAAB RID: 47787
		[OriginalName("InfrV2FireLevelNotInProgress")]
		InfrV2FireLevelNotInProgress,
		// Token: 0x0400BAAC RID: 47788
		[OriginalName("InfrV2TreeConditionNotMet")]
		InfrV2TreeConditionNotMet,
		// Token: 0x0400BAAD RID: 47789
		[OriginalName("InfrV2NotOpen")]
		InfrV2NotOpen,
		// Token: 0x0400BAAE RID: 47790
		[OriginalName("InfrV2TreeBuildCfgNotFound")]
		InfrV2TreeBuildCfgNotFound,
		// Token: 0x0400BAAF RID: 47791
		[OriginalName("InfrV2TreeCannotTrace")]
		InfrV2TreeCannotTrace,
		// Token: 0x0400BAB0 RID: 47792
		[OriginalName("InfrV2TreeSwitchTraceInMulti")]
		InfrV2TreeSwitchTraceInMulti,
		// Token: 0x0400BAB1 RID: 47793
		[OriginalName("InfrV2TaskFindErr")]
		InfrV2TaskFindErr,
		// Token: 0x0400BAB2 RID: 47794
		[OriginalName("InfrV2HadReward")]
		InfrV2HadReward,
		// Token: 0x0400BAB3 RID: 47795
		[OriginalName("InfrV2TaskRunning")]
		InfrV2TaskRunning,
		// Token: 0x0400BAB4 RID: 47796
		[OriginalName("InfrV2DropNoFind")]
		InfrV2DropNoFind,
		// Token: 0x0400BAB5 RID: 47797
		[OriginalName("InfrV2ParamAgainErr")]
		InfrV2ParamAgainErr,
		// Token: 0x0400BAB6 RID: 47798
		[OriginalName("InfrV2NoReward")]
		InfrV2NoReward,
		// Token: 0x0400BAB7 RID: 47799
		[OriginalName("InfrV2ParamCountErr")]
		InfrV2ParamCountErr,
		// Token: 0x0400BAB8 RID: 47800
		[OriginalName("SlashAndTowerParamErr")]
		SlashAndTowerParamErr,
		// Token: 0x0400BAB9 RID: 47801
		[OriginalName("RogueWeeklyParamErr")]
		RogueWeeklyParamErr,
		// Token: 0x0400BABA RID: 47802
		[OriginalName("ErrMatchRoleChangeSkillBranchCountNotEqualRoleCount")]
		ErrMatchRoleChangeSkillBranchCountNotEqualRoleCount,
		// Token: 0x0400BABB RID: 47803
		[OriginalName("ErrActivityPreQuestNotFinished")]
		ErrActivityPreQuestNotFinished,
		// Token: 0x0400BABC RID: 47804
		[OriginalName("ErrInstNotEdgeRunnerLordGym")]
		ErrInstNotEdgeRunnerLordGym,
		// Token: 0x0400BABD RID: 47805
		[OriginalName("ErrEdgeRunnerLordGymConfigNotExist")]
		ErrEdgeRunnerLordGymConfigNotExist,
		// Token: 0x0400BABE RID: 47806
		[OriginalName("ErrEdgeRunnerDbDataNotExist")]
		ErrEdgeRunnerDbDataNotExist,
		// Token: 0x0400BABF RID: 47807
		[OriginalName("ErrEdgeRunnerPreLordGymNotPassed")]
		ErrEdgeRunnerPreLordGymNotPassed,
		// Token: 0x0400BAC0 RID: 47808
		[OriginalName("EdgeRunnerParamCountErr")]
		EdgeRunnerParamCountErr,
		// Token: 0x0400BAC1 RID: 47809
		[OriginalName("EdgeRunnerDropNoFind")]
		EdgeRunnerDropNoFind,
		// Token: 0x0400BAC2 RID: 47810
		[OriginalName("EdgeRunnerNoReward")]
		EdgeRunnerNoReward,
		// Token: 0x0400BAC3 RID: 47811
		[OriginalName("EdgeRunnerTaskFindErr")]
		EdgeRunnerTaskFindErr,
		// Token: 0x0400BAC4 RID: 47812
		[OriginalName("EdgeRunnerActivityIdErr")]
		EdgeRunnerActivityIdErr,
		// Token: 0x0400BAC5 RID: 47813
		[OriginalName("EdgeRunnerHadReward")]
		EdgeRunnerHadReward,
		// Token: 0x0400BAC6 RID: 47814
		[OriginalName("EdgeRunnerTaskRunning")]
		EdgeRunnerTaskRunning,
		// Token: 0x0400BAC7 RID: 47815
		[OriginalName("EdgeRunnerParamAgainErr")]
		EdgeRunnerParamAgainErr,
		// Token: 0x0400BAC8 RID: 47816
		[OriginalName("ErrEdgeRunnerActivityConfigNotFound")]
		ErrEdgeRunnerActivityConfigNotFound,
		// Token: 0x0400BAC9 RID: 47817
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockConfigNotFound")]
		ErrEdgeRunnerActivityFuncUnlockConfigNotFound,
		// Token: 0x0400BACA RID: 47818
		[OriginalName("ErrEdgeRunnerActivityFuncAlreadyUnlock")]
		ErrEdgeRunnerActivityFuncAlreadyUnlock,
		// Token: 0x0400BACB RID: 47819
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockConditionNotReached")]
		ErrEdgeRunnerActivityFuncUnlockConditionNotReached,
		// Token: 0x0400BACC RID: 47820
		[OriginalName("ErrEdgeRunnerActivityFuncUnlockFailed")]
		ErrEdgeRunnerActivityFuncUnlockFailed,
		// Token: 0x0400BACD RID: 47821
		[OriginalName("ErrEdgeRunnerLordGymLevelVarNotExist")]
		ErrEdgeRunnerLordGymLevelVarNotExist = 3000187,
		// Token: 0x0400BACE RID: 47822
		[OriginalName("EdgeRunnerLordGymRepeatChallenge")]
		EdgeRunnerLordGymRepeatChallenge,
		// Token: 0x0400BACF RID: 47823
		[OriginalName("ErrEdgeRunnerLordGymBtTreeNotFound")]
		ErrEdgeRunnerLordGymBtTreeNotFound,
		// Token: 0x0400BAD0 RID: 47824
		[OriginalName("ErrEdgeRunnerLordGymNotInPlay")]
		ErrEdgeRunnerLordGymNotInPlay,
		// Token: 0x0400BAD1 RID: 47825
		[OriginalName("ErrGolemCrackLevelConfigNotExist")]
		ErrGolemCrackLevelConfigNotExist = 3000180,
		// Token: 0x0400BAD2 RID: 47826
		[OriginalName("ErrActivityNotMatchGolemCrackLevel")]
		ErrActivityNotMatchGolemCrackLevel,
		// Token: 0x0400BAD3 RID: 47827
		[OriginalName("ErrGolemCrackActivityDataNotFound")]
		ErrGolemCrackActivityDataNotFound,
		// Token: 0x0400BAD4 RID: 47828
		[OriginalName("ErrGolemCrackPreLevelNotFinished")]
		ErrGolemCrackPreLevelNotFinished,
		// Token: 0x0400BAD5 RID: 47829
		[OriginalName("ErrGolemCrackLevelRewardDuplicate")]
		ErrGolemCrackLevelRewardDuplicate,
		// Token: 0x0400BAD6 RID: 47830
		[OriginalName("ErrGolemCrackPreLevelLocked")]
		ErrGolemCrackPreLevelLocked = 3000186,
		// Token: 0x0400BAD7 RID: 47831
		[OriginalName("ErrPhantomRecommendConfigNotFound")]
		ErrPhantomRecommendConfigNotFound = 3000185,
		// Token: 0x0400BAD8 RID: 47832
		[OriginalName("ErrXboxGiftNotEnable")]
		ErrXboxGiftNotEnable = 3000191,
		// Token: 0x0400BAD9 RID: 47833
		[OriginalName("ErrXboxGiftDbError")]
		ErrXboxGiftDbError,
		// Token: 0x0400BADA RID: 47834
		[OriginalName("ErrXboxGiftAlreadyClaimed")]
		ErrXboxGiftAlreadyClaimed,
		// Token: 0x0400BADB RID: 47835
		[OriginalName("ErrXboxGiftNotXboxUser")]
		ErrXboxGiftNotXboxUser,
		// Token: 0x0400BADC RID: 47836
		[OriginalName("ErrXboxGiftRequestErr")]
		ErrXboxGiftRequestErr,
		// Token: 0x0400BADD RID: 47837
		[OriginalName("ErrXboxGiftRequestDataErr")]
		ErrXboxGiftRequestDataErr,
		// Token: 0x0400BADE RID: 47838
		[OriginalName("ErrXboxGiftNotFound")]
		ErrXboxGiftNotFound,
		// Token: 0x0400BADF RID: 47839
		[OriginalName("ErrXboxGiftException")]
		ErrXboxGiftException,
		// Token: 0x0400BAE0 RID: 47840
		[OriginalName("ErrXboxGiftHttpError")]
		ErrXboxGiftHttpError,
		// Token: 0x0400BAE1 RID: 47841
		[OriginalName("ErrXboxGiftXstsTokenInvalid")]
		ErrXboxGiftXstsTokenInvalid = 3000201,
		// Token: 0x0400BAE2 RID: 47842
		[OriginalName("ErrXboxGiftXstsTokenMismatch")]
		ErrXboxGiftXstsTokenMismatch,
		// Token: 0x0400BAE3 RID: 47843
		[OriginalName("DangoBrawlActivityNotExist")]
		DangoBrawlActivityNotExist = 3000200,
		// Token: 0x0400BAE4 RID: 47844
		[OriginalName("DangoBrawlParamCountErr")]
		DangoBrawlParamCountErr = 3000218,
		// Token: 0x0400BAE5 RID: 47845
		[OriginalName("DangoBrawlTaskFindErr")]
		DangoBrawlTaskFindErr,
		// Token: 0x0400BAE6 RID: 47846
		[OriginalName("DangoBrawlActivityIdErr")]
		DangoBrawlActivityIdErr,
		// Token: 0x0400BAE7 RID: 47847
		[OriginalName("DangoBrawlHadReward")]
		DangoBrawlHadReward,
		// Token: 0x0400BAE8 RID: 47848
		[OriginalName("DangoBrawlTaskRunning")]
		DangoBrawlTaskRunning,
		// Token: 0x0400BAE9 RID: 47849
		[OriginalName("DangoBrawlDropNoFind")]
		DangoBrawlDropNoFind,
		// Token: 0x0400BAEA RID: 47850
		[OriginalName("DangoBrawlParamAgainErr")]
		DangoBrawlParamAgainErr,
		// Token: 0x0400BAEB RID: 47851
		[OriginalName("DangoBrawlNoReward")]
		DangoBrawlNoReward,
		// Token: 0x0400BAEC RID: 47852
		[OriginalName("DangoBrawlPreChallengeNotPass")]
		DangoBrawlPreChallengeNotPass,
		// Token: 0x0400BAED RID: 47853
		[OriginalName("DangoBrawlWinError")]
		DangoBrawlWinError,
		// Token: 0x0400BAEE RID: 47854
		[OriginalName("QingXiaoParamCountErr")]
		QingXiaoParamCountErr = 3000203,
		// Token: 0x0400BAEF RID: 47855
		[OriginalName("QingXiaoTaskFindErr")]
		QingXiaoTaskFindErr,
		// Token: 0x0400BAF0 RID: 47856
		[OriginalName("QingXiaoActivityIdErr")]
		QingXiaoActivityIdErr,
		// Token: 0x0400BAF1 RID: 47857
		[OriginalName("QingXiaoHadReward")]
		QingXiaoHadReward,
		// Token: 0x0400BAF2 RID: 47858
		[OriginalName("QingXiaoTaskRunning")]
		QingXiaoTaskRunning,
		// Token: 0x0400BAF3 RID: 47859
		[OriginalName("QingXiaoDropNoFind")]
		QingXiaoDropNoFind,
		// Token: 0x0400BAF4 RID: 47860
		[OriginalName("QingXiaoParamAgainErr")]
		QingXiaoParamAgainErr,
		// Token: 0x0400BAF5 RID: 47861
		[OriginalName("QingXiaoNoReward")]
		QingXiaoNoReward,
		// Token: 0x0400BAF6 RID: 47862
		[OriginalName("ErrVersionSignInNotOpen")]
		ErrVersionSignInNotOpen,
		// Token: 0x0400BAF7 RID: 47863
		[OriginalName("ErrVersionSignInNoData")]
		ErrVersionSignInNoData,
		// Token: 0x0400BAF8 RID: 47864
		[OriginalName("ErrVersionSignInRewardNotExist")]
		ErrVersionSignInRewardNotExist,
		// Token: 0x0400BAF9 RID: 47865
		[OriginalName("ErrVersionSignInRewardAlreadyTaken")]
		ErrVersionSignInRewardAlreadyTaken,
		// Token: 0x0400BAFA RID: 47866
		[OriginalName("ErrVersionSignInDaysNotEnough")]
		ErrVersionSignInDaysNotEnough,
		// Token: 0x0400BAFB RID: 47867
		[OriginalName("ErrVersionSignInParamError")]
		ErrVersionSignInParamError,
		// Token: 0x0400BAFC RID: 47868
		[OriginalName("ErrTimePointRewardActivityConditionNotFinish")]
		ErrTimePointRewardActivityConditionNotFinish,
		// Token: 0x0400BAFD RID: 47869
		[OriginalName("MaterialReplaceTargetMismatch")]
		MaterialReplaceTargetMismatch = 3000228,
		// Token: 0x0400BAFE RID: 47870
		[OriginalName("MaterialReplaceNoExchangeParamConfig")]
		MaterialReplaceNoExchangeParamConfig,
		// Token: 0x0400BAFF RID: 47871
		[OriginalName("ErrMotorParkourNotFound")]
		ErrMotorParkourNotFound,
		// Token: 0x0400BB00 RID: 47872
		[OriginalName("PhotoFightLevelNotFound")]
		PhotoFightLevelNotFound = 3100000,
		// Token: 0x0400BB01 RID: 47873
		[OriginalName("PhotoFightActivityNotOpen")]
		PhotoFightActivityNotOpen,
		// Token: 0x0400BB02 RID: 47874
		[OriginalName("PhotoFightSceneComponentInfoLost")]
		PhotoFightSceneComponentInfoLost,
		// Token: 0x0400BB03 RID: 47875
		[OriginalName("PhotoFightGroupNotFound")]
		PhotoFightGroupNotFound,
		// Token: 0x0400BB04 RID: 47876
		[OriginalName("PhotoFightLevelNotOpen")]
		PhotoFightLevelNotOpen,
		// Token: 0x0400BB05 RID: 47877
		[OriginalName("PhotoFightPreInstNotCleared")]
		PhotoFightPreInstNotCleared,
		// Token: 0x0400BB06 RID: 47878
		[OriginalName("PhotoFightSceneComponentLost")]
		PhotoFightSceneComponentLost,
		// Token: 0x0400BB07 RID: 47879
		[OriginalName("PhotoFightTargetStatusHigher")]
		PhotoFightTargetStatusHigher,
		// Token: 0x0400BB08 RID: 47880
		[OriginalName("PhotoFightNoTargetRole")]
		PhotoFightNoTargetRole,
		// Token: 0x0400BB09 RID: 47881
		[OriginalName("PhotoFightRoleInvalid")]
		PhotoFightRoleInvalid,
		// Token: 0x0400BB0A RID: 47882
		[OriginalName("PhotoFightRewardCfgNotFound")]
		PhotoFightRewardCfgNotFound,
		// Token: 0x0400BB0B RID: 47883
		[OriginalName("PhotoFightRewardInvalidInput")]
		PhotoFightRewardInvalidInput,
		// Token: 0x0400BB0C RID: 47884
		[OriginalName("PhotoFightAlreadyRewarded")]
		PhotoFightAlreadyRewarded,
		// Token: 0x0400BB0D RID: 47885
		[OriginalName("PhotoFightCannotRewarded")]
		PhotoFightCannotRewarded = 3100081,
		// Token: 0x0400BB0E RID: 47886
		[OriginalName("PhotoFightInvalidInstType")]
		PhotoFightInvalidInstType = 3100306,
		// Token: 0x0400BB0F RID: 47887
		[OriginalName("WuWuKujiQuestNotFound")]
		WuWuKujiQuestNotFound = 3100013,
		// Token: 0x0400BB10 RID: 47888
		[OriginalName("WuWuKujiQuestNotOpenDay")]
		WuWuKujiQuestNotOpenDay,
		// Token: 0x0400BB11 RID: 47889
		[OriginalName("WuWuKujiQuestAllFinished")]
		WuWuKujiQuestAllFinished,
		// Token: 0x0400BB12 RID: 47890
		[OriginalName("WuWuKujiActivityNotOpen")]
		WuWuKujiActivityNotOpen,
		// Token: 0x0400BB13 RID: 47891
		[OriginalName("WuWuKujiPreGuideNotFinished")]
		WuWuKujiPreGuideNotFinished,
		// Token: 0x0400BB14 RID: 47892
		[OriginalName("WuWuKujiPreQuestNotFinished")]
		WuWuKujiPreQuestNotFinished,
		// Token: 0x0400BB15 RID: 47893
		[OriginalName("WuWuKujiActivityConfigNotFound")]
		WuWuKujiActivityConfigNotFound,
		// Token: 0x0400BB16 RID: 47894
		[OriginalName("WuWuKujiTrickTypeInvalid")]
		WuWuKujiTrickTypeInvalid,
		// Token: 0x0400BB17 RID: 47895
		[OriginalName("WuWuKujiNoAvailableTrick")]
		WuWuKujiNoAvailableTrick,
		// Token: 0x0400BB18 RID: 47896
		[OriginalName("WuWuKujiAwardGroupCfgNotFound")]
		WuWuKujiAwardGroupCfgNotFound,
		// Token: 0x0400BB19 RID: 47897
		[OriginalName("WuWuKujiNoAvailableGroup")]
		WuWuKujiNoAvailableGroup,
		// Token: 0x0400BB1A RID: 47898
		[OriginalName("WuWuKujiGroupRewardTimesExceededMax")]
		WuWuKujiGroupRewardTimesExceededMax,
		// Token: 0x0400BB1B RID: 47899
		[OriginalName("WuWuKujiGroupRemainTimesError")]
		WuWuKujiGroupRemainTimesError,
		// Token: 0x0400BB1C RID: 47900
		[OriginalName("WeatherCtlInvalidInMulti")]
		WeatherCtlInvalidInMulti,
		// Token: 0x0400BB1D RID: 47901
		[OriginalName("WeatherCtlMapDataNotFound")]
		WeatherCtlMapDataNotFound,
		// Token: 0x0400BB1E RID: 47902
		[OriginalName("WeatherCtlSwitchCfgNotFound")]
		WeatherCtlSwitchCfgNotFound,
		// Token: 0x0400BB1F RID: 47903
		[OriginalName("WeatherCtlSwitchLocked")]
		WeatherCtlSwitchLocked,
		// Token: 0x0400BB20 RID: 47904
		[OriginalName("WeatherCtlAreaWeatherLocked")]
		WeatherCtlAreaWeatherLocked,
		// Token: 0x0400BB21 RID: 47905
		[OriginalName("WeatherCtlAreaDateLocked")]
		WeatherCtlAreaDateLocked,
		// Token: 0x0400BB22 RID: 47906
		[OriginalName("WeatherCtlAddHourNoNegative")]
		WeatherCtlAddHourNoNegative,
		// Token: 0x0400BB23 RID: 47907
		[OriginalName("WeatherCtlInMulti")]
		WeatherCtlInMulti = 3100052,
		// Token: 0x0400BB24 RID: 47908
		[OriginalName("WeatherCtlInBattle")]
		WeatherCtlInBattle,
		// Token: 0x0400BB25 RID: 47909
		[OriginalName("WeatherCtlInQuest")]
		WeatherCtlInQuest,
		// Token: 0x0400BB26 RID: 47910
		[OriginalName("WeatherCtlNotInBigWorld")]
		WeatherCtlNotInBigWorld = 3100082,
		// Token: 0x0400BB27 RID: 47911
		[OriginalName("WeatherCtlNotOpen")]
		WeatherCtlNotOpen = 3100162,
		// Token: 0x0400BB28 RID: 47912
		[OriginalName("InfrArchiveTaskCfgNotFound")]
		InfrArchiveTaskCfgNotFound = 3100033,
		// Token: 0x0400BB29 RID: 47913
		[OriginalName("InfrLevelCfgNotFound")]
		InfrLevelCfgNotFound,
		// Token: 0x0400BB2A RID: 47914
		[OriginalName("InfrShopPhaseCfgNotFound")]
		InfrShopPhaseCfgNotFound,
		// Token: 0x0400BB2B RID: 47915
		[OriginalName("InfrShopGoodsCfgNotFound")]
		InfrShopGoodsCfgNotFound,
		// Token: 0x0400BB2C RID: 47916
		[OriginalName("InfrFireAddExpNegative")]
		InfrFireAddExpNegative,
		// Token: 0x0400BB2D RID: 47917
		[OriginalName("InfrFireAlreadyMaxLevel")]
		InfrFireAlreadyMaxLevel,
		// Token: 0x0400BB2E RID: 47918
		[OriginalName("InfrFireConditionNotMet")]
		InfrFireConditionNotMet,
		// Token: 0x0400BB2F RID: 47919
		[OriginalName("InfrRoadBuildCfgNotFound")]
		InfrRoadBuildCfgNotFound,
		// Token: 0x0400BB30 RID: 47920
		[OriginalName("InfrRoadCannotTrace")]
		InfrRoadCannotTrace,
		// Token: 0x0400BB31 RID: 47921
		[OriginalName("InfrFireShopGoodsNotFound")]
		InfrFireShopGoodsNotFound,
		// Token: 0x0400BB32 RID: 47922
		[OriginalName("InfrFireShopPhaseNotUnlocked")]
		InfrFireShopPhaseNotUnlocked,
		// Token: 0x0400BB33 RID: 47923
		[OriginalName("InfrFireShopBuyLimitExceeded")]
		InfrFireShopBuyLimitExceeded,
		// Token: 0x0400BB34 RID: 47924
		[OriginalName("InfrFireShopBuyTimesInvalid")]
		InfrFireShopBuyTimesInvalid,
		// Token: 0x0400BB35 RID: 47925
		[OriginalName("InfrArchiveTaskInvalidInput")]
		InfrArchiveTaskInvalidInput,
		// Token: 0x0400BB36 RID: 47926
		[OriginalName("InfrArchiveTaskCannotRewarded")]
		InfrArchiveTaskCannotRewarded,
		// Token: 0x0400BB37 RID: 47927
		[OriginalName("InfrFireExpNotEnough")]
		InfrFireExpNotEnough,
		// Token: 0x0400BB38 RID: 47928
		[OriginalName("InfrRoadNotInProgress")]
		InfrRoadNotInProgress,
		// Token: 0x0400BB39 RID: 47929
		[OriginalName("InfrFireLevelNotInProgress")]
		InfrFireLevelNotInProgress,
		// Token: 0x0400BB3A RID: 47930
		[OriginalName("InfrRoadConditionNotMet")]
		InfrRoadConditionNotMet,
		// Token: 0x0400BB3B RID: 47931
		[OriginalName("InfrNotOpen")]
		InfrNotOpen = 3100073,
		// Token: 0x0400BB3C RID: 47932
		[OriginalName("InfrPhoneTaskInvalidInput")]
		InfrPhoneTaskInvalidInput = 3100083,
		// Token: 0x0400BB3D RID: 47933
		[OriginalName("InfrPhoneTaskCannotRewarded")]
		InfrPhoneTaskCannotRewarded,
		// Token: 0x0400BB3E RID: 47934
		[OriginalName("InfrPhoneTaskCfgNotFound")]
		InfrPhoneTaskCfgNotFound,
		// Token: 0x0400BB3F RID: 47935
		[OriginalName("InfrRoadSwitchTraceInMulti")]
		InfrRoadSwitchTraceInMulti = 3100173,
		// Token: 0x0400BB40 RID: 47936
		[OriginalName("InfrThemeActivityTaskNotFound")]
		InfrThemeActivityTaskNotFound = 3100074,
		// Token: 0x0400BB41 RID: 47937
		[OriginalName("InfrThemeActivityTaskRewarded")]
		InfrThemeActivityTaskRewarded,
		// Token: 0x0400BB42 RID: 47938
		[OriginalName("InfrThemeActivityTaskNotComplete")]
		InfrThemeActivityTaskNotComplete,
		// Token: 0x0400BB43 RID: 47939
		[OriginalName("InfrThemeActivityInputInvalid")]
		InfrThemeActivityInputInvalid,
		// Token: 0x0400BB44 RID: 47940
		[OriginalName("InfrThemeActivityIdMisMatch")]
		InfrThemeActivityIdMisMatch = 3100094,
		// Token: 0x0400BB45 RID: 47941
		[OriginalName("InfrThemeActivityTaskCannotRewarded")]
		InfrThemeActivityTaskCannotRewarded = 3100078,
		// Token: 0x0400BB46 RID: 47942
		[OriginalName("MotorTechPreNodeLock")]
		MotorTechPreNodeLock = 3100055,
		// Token: 0x0400BB47 RID: 47943
		[OriginalName("MotorTechPreNotUpgraded")]
		MotorTechPreNotUpgraded,
		// Token: 0x0400BB48 RID: 47944
		[OriginalName("MotorTechLevelLower")]
		MotorTechLevelLower,
		// Token: 0x0400BB49 RID: 47945
		[OriginalName("MotorTechNotUnlocked")]
		MotorTechNotUnlocked,
		// Token: 0x0400BB4A RID: 47946
		[OriginalName("MotorTechLevelMax")]
		MotorTechLevelMax,
		// Token: 0x0400BB4B RID: 47947
		[OriginalName("MotorTechCfgNotFound")]
		MotorTechCfgNotFound,
		// Token: 0x0400BB4C RID: 47948
		[OriginalName("MotorLvlConfigNotFound")]
		MotorLvlConfigNotFound,
		// Token: 0x0400BB4D RID: 47949
		[OriginalName("MotorFuncNotOpen")]
		MotorFuncNotOpen,
		// Token: 0x0400BB4E RID: 47950
		[OriginalName("MotorTaskCannotRewarded")]
		MotorTaskCannotRewarded,
		// Token: 0x0400BB4F RID: 47951
		[OriginalName("MotorTaskInvalidParam")]
		MotorTaskInvalidParam,
		// Token: 0x0400BB50 RID: 47952
		[OriginalName("MotorTaskCfgNotFound")]
		MotorTaskCfgNotFound,
		// Token: 0x0400BB51 RID: 47953
		[OriginalName("MotorTechTreeCfgNotFound")]
		MotorTechTreeCfgNotFound,
		// Token: 0x0400BB52 RID: 47954
		[OriginalName("MotorTechTreeLocked")]
		MotorTechTreeLocked,
		// Token: 0x0400BB53 RID: 47955
		[OriginalName("MotorPlayerUsingSkill")]
		MotorPlayerUsingSkill,
		// Token: 0x0400BB54 RID: 47956
		[OriginalName("MotorPlayerClimbing")]
		MotorPlayerClimbing,
		// Token: 0x0400BB55 RID: 47957
		[OriginalName("MotorPlayerInWater")]
		MotorPlayerInWater,
		// Token: 0x0400BB56 RID: 47958
		[OriginalName("MotorPlayerInAir")]
		MotorPlayerInAir,
		// Token: 0x0400BB57 RID: 47959
		[OriginalName("MotorPlayerOnMotor")]
		MotorPlayerOnMotor,
		// Token: 0x0400BB58 RID: 47960
		[OriginalName("MotorTaskNotInOneTree")]
		MotorTaskNotInOneTree = 3100079,
		// Token: 0x0400BB59 RID: 47961
		[OriginalName("MotorExpInvalid")]
		MotorExpInvalid,
		// Token: 0x0400BB5A RID: 47962
		[OriginalName("MotorOutlookLocked")]
		MotorOutlookLocked = 3100086,
		// Token: 0x0400BB5B RID: 47963
		[OriginalName("MotorFrameCfgNotFound")]
		MotorFrameCfgNotFound,
		// Token: 0x0400BB5C RID: 47964
		[OriginalName("MotorStickerCfgNotFound")]
		MotorStickerCfgNotFound,
		// Token: 0x0400BB5D RID: 47965
		[OriginalName("MotorOutlookBanInRegion")]
		MotorOutlookBanInRegion,
		// Token: 0x0400BB5E RID: 47966
		[OriginalName("MotorOutlookConflict")]
		MotorOutlookConflict,
		// Token: 0x0400BB5F RID: 47967
		[OriginalName("MotorStickerPartCountError")]
		MotorStickerPartCountError,
		// Token: 0x0400BB60 RID: 47968
		[OriginalName("MotorStickerPartIdError")]
		MotorStickerPartIdError,
		// Token: 0x0400BB61 RID: 47969
		[OriginalName("MotorOutlookNotOwned")]
		MotorOutlookNotOwned,
		// Token: 0x0400BB62 RID: 47970
		[OriginalName("MotorOutlookNotShow")]
		MotorOutlookNotShow = 3100320,
		// Token: 0x0400BB63 RID: 47971
		[OriginalName("MotorLevelRewardAllClaimed")]
		MotorLevelRewardAllClaimed = 3100159,
		// Token: 0x0400BB64 RID: 47972
		[OriginalName("PlayerNotInMotorArea")]
		PlayerNotInMotorArea,
		// Token: 0x0400BB65 RID: 47973
		[OriginalName("MotorDecorationsCfgNotFound")]
		MotorDecorationsCfgNotFound = 3100164,
		// Token: 0x0400BB66 RID: 47974
		[OriginalName("MotorDecorationsPartCountError")]
		MotorDecorationsPartCountError,
		// Token: 0x0400BB67 RID: 47975
		[OriginalName("MotorDecorationsPartIdError")]
		MotorDecorationsPartIdError,
		// Token: 0x0400BB68 RID: 47976
		[OriginalName("MotorTechTreeInCd")]
		MotorTechTreeInCd = 3100175,
		// Token: 0x0400BB69 RID: 47977
		[OriginalName("ArrowSwordLevelCfgNotFound")]
		ArrowSwordLevelCfgNotFound = 3100095,
		// Token: 0x0400BB6A RID: 47978
		[OriginalName("ArrowSwordTalentCfgNotFound")]
		ArrowSwordTalentCfgNotFound,
		// Token: 0x0400BB6B RID: 47979
		[OriginalName("ArrowSwordTaskCfgNotFound")]
		ArrowSwordTaskCfgNotFound,
		// Token: 0x0400BB6C RID: 47980
		[OriginalName("ArrowSwordItemCfgNotFound")]
		ArrowSwordItemCfgNotFound,
		// Token: 0x0400BB6D RID: 47981
		[OriginalName("ArrowSwordRoleCfgNotFound")]
		ArrowSwordRoleCfgNotFound,
		// Token: 0x0400BB6E RID: 47982
		[OriginalName("ArrowSwordPreNotCleared")]
		ArrowSwordPreNotCleared,
		// Token: 0x0400BB6F RID: 47983
		[OriginalName("ArrowSwordActivityTypeNotMatch")]
		ArrowSwordActivityTypeNotMatch,
		// Token: 0x0400BB70 RID: 47984
		[OriginalName("ArrowSwordTaskStatusHigher")]
		ArrowSwordTaskStatusHigher,
		// Token: 0x0400BB71 RID: 47985
		[OriginalName("ArrowSwordInvalidInput")]
		ArrowSwordInvalidInput,
		// Token: 0x0400BB72 RID: 47986
		[OriginalName("ArrowSwordDataOwnerErr")]
		ArrowSwordDataOwnerErr,
		// Token: 0x0400BB73 RID: 47987
		[OriginalName("ArrowSwordActivityIdMisMatch")]
		ArrowSwordActivityIdMisMatch,
		// Token: 0x0400BB74 RID: 47988
		[OriginalName("ArrowSwordTalentLocked")]
		ArrowSwordTalentLocked,
		// Token: 0x0400BB75 RID: 47989
		[OriginalName("ArrowSwordTalentAlreadyInUse")]
		ArrowSwordTalentAlreadyInUse,
		// Token: 0x0400BB76 RID: 47990
		[OriginalName("ArrowSwordTalentPreNodeNotInUse")]
		ArrowSwordTalentPreNodeNotInUse,
		// Token: 0x0400BB77 RID: 47991
		[OriginalName("ArrowSwordActivityCfgNotFound")]
		ArrowSwordActivityCfgNotFound,
		// Token: 0x0400BB78 RID: 47992
		[OriginalName("ArrowSwordTalentNotInUse")]
		ArrowSwordTalentNotInUse,
		// Token: 0x0400BB79 RID: 47993
		[OriginalName("ArrowSwordActivityNotOpen")]
		ArrowSwordActivityNotOpen,
		// Token: 0x0400BB7A RID: 47994
		[OriginalName("ArrowSwordActivityEnd")]
		ArrowSwordActivityEnd,
		// Token: 0x0400BB7B RID: 47995
		[OriginalName("ArrowSwordComponentNoFind")]
		ArrowSwordComponentNoFind,
		// Token: 0x0400BB7C RID: 47996
		[OriginalName("ArrowSwordSaveDataLost")]
		ArrowSwordSaveDataLost,
		// Token: 0x0400BB7D RID: 47997
		[OriginalName("ArrowSwordRoleNotUnlock")]
		ArrowSwordRoleNotUnlock,
		// Token: 0x0400BB7E RID: 47998
		[OriginalName("ArrowSwordRankListCd")]
		ArrowSwordRankListCd,
		// Token: 0x0400BB7F RID: 47999
		[OriginalName("ArrowSwordComponentInstLost")]
		ArrowSwordComponentInstLost,
		// Token: 0x0400BB80 RID: 48000
		[OriginalName("ArrowSwordInstNotInProgress")]
		ArrowSwordInstNotInProgress,
		// Token: 0x0400BB81 RID: 48001
		[OriginalName("ArrowSwordInstNotInitialized")]
		ArrowSwordInstNotInitialized,
		// Token: 0x0400BB82 RID: 48002
		[OriginalName("ArrowSwordHaveUnfinishedInst")]
		ArrowSwordHaveUnfinishedInst,
		// Token: 0x0400BB83 RID: 48003
		[OriginalName("MotorFightLevelCfgNotFound")]
		MotorFightLevelCfgNotFound,
		// Token: 0x0400BB84 RID: 48004
		[OriginalName("MotorFightTalentCfgNotFound")]
		MotorFightTalentCfgNotFound,
		// Token: 0x0400BB85 RID: 48005
		[OriginalName("MotorFightTaskCfgNotFound")]
		MotorFightTaskCfgNotFound,
		// Token: 0x0400BB86 RID: 48006
		[OriginalName("MotorFightItemCfgNotFound")]
		MotorFightItemCfgNotFound,
		// Token: 0x0400BB87 RID: 48007
		[OriginalName("MotorFightRoleCfgNotFound")]
		MotorFightRoleCfgNotFound,
		// Token: 0x0400BB88 RID: 48008
		[OriginalName("MotorFightPreNotCleared")]
		MotorFightPreNotCleared,
		// Token: 0x0400BB89 RID: 48009
		[OriginalName("MotorFightActivityTypeNotMatch")]
		MotorFightActivityTypeNotMatch,
		// Token: 0x0400BB8A RID: 48010
		[OriginalName("MotorFightTaskStatusHigher")]
		MotorFightTaskStatusHigher,
		// Token: 0x0400BB8B RID: 48011
		[OriginalName("MotorFightInvalidInput")]
		MotorFightInvalidInput,
		// Token: 0x0400BB8C RID: 48012
		[OriginalName("MotorFightDataOwnerErr")]
		MotorFightDataOwnerErr,
		// Token: 0x0400BB8D RID: 48013
		[OriginalName("MotorFightActivityIdMisMatch")]
		MotorFightActivityIdMisMatch,
		// Token: 0x0400BB8E RID: 48014
		[OriginalName("MotorFightTalentLocked")]
		MotorFightTalentLocked,
		// Token: 0x0400BB8F RID: 48015
		[OriginalName("MotorFightTalentAlreadyInUse")]
		MotorFightTalentAlreadyInUse,
		// Token: 0x0400BB90 RID: 48016
		[OriginalName("MotorFightTalentPreNodeNotInUse")]
		MotorFightTalentPreNodeNotInUse,
		// Token: 0x0400BB91 RID: 48017
		[OriginalName("MotorFightActivityCfgNotFound")]
		MotorFightActivityCfgNotFound,
		// Token: 0x0400BB92 RID: 48018
		[OriginalName("MotorFightTalentNotInUse")]
		MotorFightTalentNotInUse,
		// Token: 0x0400BB93 RID: 48019
		[OriginalName("MotorFightActivityNotOpen")]
		MotorFightActivityNotOpen,
		// Token: 0x0400BB94 RID: 48020
		[OriginalName("MotorFightActivityEnd")]
		MotorFightActivityEnd,
		// Token: 0x0400BB95 RID: 48021
		[OriginalName("MotorFightComponentNoFind")]
		MotorFightComponentNoFind,
		// Token: 0x0400BB96 RID: 48022
		[OriginalName("MotorFightSaveDataLost")]
		MotorFightSaveDataLost,
		// Token: 0x0400BB97 RID: 48023
		[OriginalName("MotorFightRoleNotUnlock")]
		MotorFightRoleNotUnlock,
		// Token: 0x0400BB98 RID: 48024
		[OriginalName("MotorFightRankListCd")]
		MotorFightRankListCd,
		// Token: 0x0400BB99 RID: 48025
		[OriginalName("MotorFightComponentInstLost")]
		MotorFightComponentInstLost,
		// Token: 0x0400BB9A RID: 48026
		[OriginalName("MotorFightInstNotInProgress")]
		MotorFightInstNotInProgress,
		// Token: 0x0400BB9B RID: 48027
		[OriginalName("MotorFightInstNotInitialized")]
		MotorFightInstNotInitialized,
		// Token: 0x0400BB9C RID: 48028
		[OriginalName("MotorFightHaveUnfinishedInst")]
		MotorFightHaveUnfinishedInst,
		// Token: 0x0400BB9D RID: 48029
		[OriginalName("MotorFightAlreadySettle")]
		MotorFightAlreadySettle,
		// Token: 0x0400BB9E RID: 48030
		[OriginalName("MotorFightNoInfiniteLevel")]
		MotorFightNoInfiniteLevel = 3100161,
		// Token: 0x0400BB9F RID: 48031
		[OriginalName("MotorFightNoRoundData")]
		MotorFightNoRoundData = 3100163,
		// Token: 0x0400BBA0 RID: 48032
		[OriginalName("MotorFightLevelNotOpen")]
		MotorFightLevelNotOpen = 3100170,
		// Token: 0x0400BBA1 RID: 48033
		[OriginalName("MotorFightFirstClearRewardFail")]
		MotorFightFirstClearRewardFail,
		// Token: 0x0400BBA2 RID: 48034
		[OriginalName("MotorFightSettleResultNull")]
		MotorFightSettleResultNull,
		// Token: 0x0400BBA3 RID: 48035
		[OriginalName("EncircleChallengeCfgNotFound")]
		EncircleChallengeCfgNotFound = 3100148,
		// Token: 0x0400BBA4 RID: 48036
		[OriginalName("EncircleChallengeNotOpen")]
		EncircleChallengeNotOpen,
		// Token: 0x0400BBA5 RID: 48037
		[OriginalName("EncirclePreChallengeNotPass")]
		EncirclePreChallengeNotPass,
		// Token: 0x0400BBA6 RID: 48038
		[OriginalName("EncircleChallengeStepErr")]
		EncircleChallengeStepErr,
		// Token: 0x0400BBA7 RID: 48039
		[OriginalName("EncircleActivityTypeNotMatch")]
		EncircleActivityTypeNotMatch = 3100174,
		// Token: 0x0400BBA8 RID: 48040
		[OriginalName("EncircleChallengeNotStart")]
		EncircleChallengeNotStart = 3100177,
		// Token: 0x0400BBA9 RID: 48041
		[OriginalName("EncircleMultiGame")]
		EncircleMultiGame = 3100179,
		// Token: 0x0400BBAA RID: 48042
		[OriginalName("EncircleActivityNotOpen")]
		EncircleActivityNotOpen = 3100206,
		// Token: 0x0400BBAB RID: 48043
		[OriginalName("FetterGroupNotExist")]
		FetterGroupNotExist = 3100152,
		// Token: 0x0400BBAC RID: 48044
		[OriginalName("DirectRefiningQualityErr")]
		DirectRefiningQualityErr,
		// Token: 0x0400BBAD RID: 48045
		[OriginalName("FetterGroupConfigErr")]
		FetterGroupConfigErr,
		// Token: 0x0400BBAE RID: 48046
		[OriginalName("FetterGroupDirectRefineLocked")]
		FetterGroupDirectRefineLocked,
		// Token: 0x0400BBAF RID: 48047
		[OriginalName("PhantomDirectRefiningFetterNotFound")]
		PhantomDirectRefiningFetterNotFound,
		// Token: 0x0400BBB0 RID: 48048
		[OriginalName("PhantomDirectRefiningWeekTimesLimit")]
		PhantomDirectRefiningWeekTimesLimit,
		// Token: 0x0400BBB1 RID: 48049
		[OriginalName("PhantomMonsterConfNotFound")]
		PhantomMonsterConfNotFound,
		// Token: 0x0400BBB2 RID: 48050
		[OriginalName("GivebackScoreCannotReward")]
		GivebackScoreCannotReward = 3100167,
		// Token: 0x0400BBB3 RID: 48051
		[OriginalName("GivebackScoreCfgNotFound")]
		GivebackScoreCfgNotFound,
		// Token: 0x0400BBB4 RID: 48052
		[OriginalName("GivebackNotOpen")]
		GivebackNotOpen,
		// Token: 0x0400BBB5 RID: 48053
		[OriginalName("GivebackInvalidInput")]
		GivebackInvalidInput = 3100176,
		// Token: 0x0400BBB6 RID: 48054
		[OriginalName("GivebackParseDataError")]
		GivebackParseDataError = 3100178,
		// Token: 0x0400BBB7 RID: 48055
		[OriginalName("RhythmNotInLimitTime")]
		RhythmNotInLimitTime = 3100180,
		// Token: 0x0400BBB8 RID: 48056
		[OriginalName("RhythmTaskCfgNotFound")]
		RhythmTaskCfgNotFound,
		// Token: 0x0400BBB9 RID: 48057
		[OriginalName("RhythmActivityCfgNotFound")]
		RhythmActivityCfgNotFound,
		// Token: 0x0400BBBA RID: 48058
		[OriginalName("RhythmPlanetCfgNotFound")]
		RhythmPlanetCfgNotFound,
		// Token: 0x0400BBBB RID: 48059
		[OriginalName("RhythmLevelCfgNotFound")]
		RhythmLevelCfgNotFound,
		// Token: 0x0400BBBC RID: 48060
		[OriginalName("RhythmSubLevelCfgNotFound")]
		RhythmSubLevelCfgNotFound,
		// Token: 0x0400BBBD RID: 48061
		[OriginalName("RhythmRoleCfgNotFound")]
		RhythmRoleCfgNotFound = 3100190,
		// Token: 0x0400BBBE RID: 48062
		[OriginalName("RhythmInputInvalid")]
		RhythmInputInvalid = 3100186,
		// Token: 0x0400BBBF RID: 48063
		[OriginalName("RhythmActivityDataNotExist")]
		RhythmActivityDataNotExist,
		// Token: 0x0400BBC0 RID: 48064
		[OriginalName("RhythmTaskCannotReward")]
		RhythmTaskCannotReward,
		// Token: 0x0400BBC1 RID: 48065
		[OriginalName("RhythmInMulti")]
		RhythmInMulti,
		// Token: 0x0400BBC2 RID: 48066
		[OriginalName("RhythmSubLevelNotOpen")]
		RhythmSubLevelNotOpen = 3100191,
		// Token: 0x0400BBC3 RID: 48067
		[OriginalName("RhythmPreSubLevelNotCompleted")]
		RhythmPreSubLevelNotCompleted,
		// Token: 0x0400BBC4 RID: 48068
		[OriginalName("RhythmLevelNotOpen")]
		RhythmLevelNotOpen,
		// Token: 0x0400BBC5 RID: 48069
		[OriginalName("RhythmPlanetNotOpen")]
		RhythmPlanetNotOpen,
		// Token: 0x0400BBC6 RID: 48070
		[OriginalName("RhythmRoleLock")]
		RhythmRoleLock,
		// Token: 0x0400BBC7 RID: 48071
		[OriginalName("RhythmActivityIdMisMatch")]
		RhythmActivityIdMisMatch,
		// Token: 0x0400BBC8 RID: 48072
		[OriginalName("RhythmInvalidPayload")]
		RhythmInvalidPayload,
		// Token: 0x0400BBC9 RID: 48073
		[OriginalName("RhythmActivityTypeNotMatch")]
		RhythmActivityTypeNotMatch,
		// Token: 0x0400BBCA RID: 48074
		[OriginalName("RhythmNoPartnerRoleId")]
		RhythmNoPartnerRoleId,
		// Token: 0x0400BBCB RID: 48075
		[OriginalName("RhythmGetRankInCd")]
		RhythmGetRankInCd,
		// Token: 0x0400BBCC RID: 48076
		[OriginalName("RhythmInstNotMatch")]
		RhythmInstNotMatch,
		// Token: 0x0400BBCD RID: 48077
		[OriginalName("RhythmActivityEnd")]
		RhythmActivityEnd,
		// Token: 0x0400BBCE RID: 48078
		[OriginalName("RhythmPartnerNotSet")]
		RhythmPartnerNotSet,
		// Token: 0x0400BBCF RID: 48079
		[OriginalName("RhythmStartInfoLost")]
		RhythmStartInfoLost,
		// Token: 0x0400BBD0 RID: 48080
		[OriginalName("RhythmSubLevelNotMatch")]
		RhythmSubLevelNotMatch,
		// Token: 0x0400BBD1 RID: 48081
		[OriginalName("PinballLevelCfgNotFound")]
		PinballLevelCfgNotFound = 3100207,
		// Token: 0x0400BBD2 RID: 48082
		[OriginalName("PinballActivityNotOpen")]
		PinballActivityNotOpen,
		// Token: 0x0400BBD3 RID: 48083
		[OriginalName("PinballTrialLevelNotUseRole")]
		PinballTrialLevelNotUseRole,
		// Token: 0x0400BBD4 RID: 48084
		[OriginalName("PinballRoleCountInvalid")]
		PinballRoleCountInvalid,
		// Token: 0x0400BBD5 RID: 48085
		[OriginalName("PinballRoleNotOwn")]
		PinballRoleNotOwn,
		// Token: 0x0400BBD6 RID: 48086
		[OriginalName("PinballSceneNotExists")]
		PinballSceneNotExists,
		// Token: 0x0400BBD7 RID: 48087
		[OriginalName("PinballComponentNotExists")]
		PinballComponentNotExists,
		// Token: 0x0400BBD8 RID: 48088
		[OriginalName("PinballEnterCtxInvalid")]
		PinballEnterCtxInvalid,
		// Token: 0x0400BBD9 RID: 48089
		[OriginalName("PinballCompStateInvalid")]
		PinballCompStateInvalid,
		// Token: 0x0400BBDA RID: 48090
		[OriginalName("PinballGameAlreadySettled")]
		PinballGameAlreadySettled,
		// Token: 0x0400BBDB RID: 48091
		[OriginalName("PinballBonusScoreNotFull")]
		PinballBonusScoreNotFull,
		// Token: 0x0400BBDC RID: 48092
		[OriginalName("PinballLevelTypeInvalid")]
		PinballLevelTypeInvalid,
		// Token: 0x0400BBDD RID: 48093
		[OriginalName("PinballAlreadySettled")]
		PinballAlreadySettled,
		// Token: 0x0400BBDE RID: 48094
		[OriginalName("PinballNoReviveTimesLeft")]
		PinballNoReviveTimesLeft,
		// Token: 0x0400BBDF RID: 48095
		[OriginalName("PinballCompStateChangeReasonInvalid")]
		PinballCompStateChangeReasonInvalid,
		// Token: 0x0400BBE0 RID: 48096
		[OriginalName("PinballSettlePayloadInvalid")]
		PinballSettlePayloadInvalid,
		// Token: 0x0400BBE1 RID: 48097
		[OriginalName("PinballRoleCfgNotFound")]
		PinballRoleCfgNotFound,
		// Token: 0x0400BBE2 RID: 48098
		[OriginalName("PinballTemplateEntityConfigNotFound")]
		PinballTemplateEntityConfigNotFound,
		// Token: 0x0400BBE3 RID: 48099
		[OriginalName("PinballLevelNotBonus")]
		PinballLevelNotBonus,
		// Token: 0x0400BBE4 RID: 48100
		[OriginalName("PinballLevelTargetCondTypeNotSupport")]
		PinballLevelTargetCondTypeNotSupport,
		// Token: 0x0400BBE5 RID: 48101
		[OriginalName("PinballEffectCfgNotFound")]
		PinballEffectCfgNotFound,
		// Token: 0x0400BBE6 RID: 48102
		[OriginalName("PinballEffectHandlerNotFound")]
		PinballEffectHandlerNotFound,
		// Token: 0x0400BBE7 RID: 48103
		[OriginalName("PinballTrialLevelEnterWithRoles")]
		PinballTrialLevelEnterWithRoles,
		// Token: 0x0400BBE8 RID: 48104
		[OriginalName("PinballBtObjNotExists")]
		PinballBtObjNotExists,
		// Token: 0x0400BBE9 RID: 48105
		[OriginalName("PinballLevelEnterWithNoRole")]
		PinballLevelEnterWithNoRole,
		// Token: 0x0400BBEA RID: 48106
		[OriginalName("PinballRoleLevelCfgNotFound")]
		PinballRoleLevelCfgNotFound = 3100238,
		// Token: 0x0400BBEB RID: 48107
		[OriginalName("PinballDailyConfigInvalid")]
		PinballDailyConfigInvalid,
		// Token: 0x0400BBEC RID: 48108
		[OriginalName("MotorOutlookPresetNameInvalid")]
		MotorOutlookPresetNameInvalid = 3100232,
		// Token: 0x0400BBED RID: 48109
		[OriginalName("MotorOutlookPresetNotOwn")]
		MotorOutlookPresetNotOwn,
		// Token: 0x0400BBEE RID: 48110
		[OriginalName("MotorOutlookPresetMax")]
		MotorOutlookPresetMax,
		// Token: 0x0400BBEF RID: 48111
		[OriginalName("MotorOutlookPresetNotExist")]
		MotorOutlookPresetNotExist,
		// Token: 0x0400BBF0 RID: 48112
		[OriginalName("MotorOutlookPresetInputInvalid")]
		MotorOutlookPresetInputInvalid,
		// Token: 0x0400BBF1 RID: 48113
		[OriginalName("MotorOutlookPresetIdInvalid")]
		MotorOutlookPresetIdInvalid,
		// Token: 0x0400BBF2 RID: 48114
		[OriginalName("MotorSkinCfgNotFound")]
		MotorSkinCfgNotFound = 3100243,
		// Token: 0x0400BBF3 RID: 48115
		[OriginalName("MotorSkinNotEditable")]
		MotorSkinNotEditable,
		// Token: 0x0400BBF4 RID: 48116
		[OriginalName("MotorSceneCfgNotFound")]
		MotorSceneCfgNotFound = 3100289,
		// Token: 0x0400BBF5 RID: 48117
		[OriginalName("CdkGiftCdkBatchAlreadyGot")]
		CdkGiftCdkBatchAlreadyGot = 3100240,
		// Token: 0x0400BBF6 RID: 48118
		[OriginalName("CdkGiftCdkPayGiftAlreadyBought")]
		CdkGiftCdkPayGiftAlreadyBought,
		// Token: 0x0400BBF7 RID: 48119
		[OriginalName("CdkGiftCdkPayGiftTypeErr")]
		CdkGiftCdkPayGiftTypeErr,
		// Token: 0x0400BBF8 RID: 48120
		[OriginalName("CdkGiftCdkPayGiftOldVersion")]
		CdkGiftCdkPayGiftOldVersion = 3100287,
		// Token: 0x0400BBF9 RID: 48121
		[OriginalName("NewBieMainlineActivityNotOpen")]
		NewBieMainlineActivityNotOpen = 3100245,
		// Token: 0x0400BBFA RID: 48122
		[OriginalName("NewBieMainlineActivityEnd")]
		NewBieMainlineActivityEnd,
		// Token: 0x0400BBFB RID: 48123
		[OriginalName("NewBieMainlineInvalidInput")]
		NewBieMainlineInvalidInput,
		// Token: 0x0400BBFC RID: 48124
		[OriginalName("NewBieMainlineRewardActivityMismatch")]
		NewBieMainlineRewardActivityMismatch,
		// Token: 0x0400BBFD RID: 48125
		[OriginalName("NewBieMainlineTabTaskCfgNotFound")]
		NewBieMainlineTabTaskCfgNotFound,
		// Token: 0x0400BBFE RID: 48126
		[OriginalName("NewBieMainlineTabRewardCfgNotFound")]
		NewBieMainlineTabRewardCfgNotFound,
		// Token: 0x0400BBFF RID: 48127
		[OriginalName("NewBieMainlineRewardAlreadyTaken")]
		NewBieMainlineRewardAlreadyTaken,
		// Token: 0x0400BC00 RID: 48128
		[OriginalName("NewBieMainlineScoreNotEnough")]
		NewBieMainlineScoreNotEnough,
		// Token: 0x0400BC01 RID: 48129
		[OriginalName("NewBieMainlineRewardDropFail")]
		NewBieMainlineRewardDropFail,
		// Token: 0x0400BC02 RID: 48130
		[OriginalName("NewBieAdventureActivityNotOpen")]
		NewBieAdventureActivityNotOpen,
		// Token: 0x0400BC03 RID: 48131
		[OriginalName("NewBieAdventureActivityCfgNotFound")]
		NewBieAdventureActivityCfgNotFound,
		// Token: 0x0400BC04 RID: 48132
		[OriginalName("NewBieAdventureActivityEnd")]
		NewBieAdventureActivityEnd,
		// Token: 0x0400BC05 RID: 48133
		[OriginalName("NewBieAdventureInvalidInput")]
		NewBieAdventureInvalidInput,
		// Token: 0x0400BC06 RID: 48134
		[OriginalName("NewBieAdventureChapterV2CfgNotFound")]
		NewBieAdventureChapterV2CfgNotFound,
		// Token: 0x0400BC07 RID: 48135
		[OriginalName("NewBieAdventureTaskV2CfgNotFound")]
		NewBieAdventureTaskV2CfgNotFound,
		// Token: 0x0400BC08 RID: 48136
		[OriginalName("NewBieAdventureV2RewardAlreadyTaken")]
		NewBieAdventureV2RewardAlreadyTaken,
		// Token: 0x0400BC09 RID: 48137
		[OriginalName("NewBieAdventureV2RewardDropFail")]
		NewBieAdventureV2RewardDropFail,
		// Token: 0x0400BC0A RID: 48138
		[OriginalName("NewBieAdventureV2ChapterLocked")]
		NewBieAdventureV2ChapterLocked,
		// Token: 0x0400BC0B RID: 48139
		[OriginalName("NewBieAdventureV2ChapterRewardNotReady")]
		NewBieAdventureV2ChapterRewardNotReady,
		// Token: 0x0400BC0C RID: 48140
		[OriginalName("NewBieAdventureV2NoTaskConfig")]
		NewBieAdventureV2NoTaskConfig,
		// Token: 0x0400BC0D RID: 48141
		[OriginalName("NewBieAdventureV2RoleNotSet")]
		NewBieAdventureV2RoleNotSet,
		// Token: 0x0400BC0E RID: 48142
		[OriginalName("NewBieAdventureV2RoleInvalid")]
		NewBieAdventureV2RoleInvalid,
		// Token: 0x0400BC0F RID: 48143
		[OriginalName("NewBieAdventureV2TasksCrossChapter")]
		NewBieAdventureV2TasksCrossChapter,
		// Token: 0x0400BC10 RID: 48144
		[OriginalName("NewBieAdventureV2TaskNotComplete")]
		NewBieAdventureV2TaskNotComplete,
		// Token: 0x0400BC11 RID: 48145
		[OriginalName("GeneralDailyResetCronNotFound")]
		GeneralDailyResetCronNotFound,
		// Token: 0x0400BC12 RID: 48146
		[OriginalName("ActivitySignConfigNotFound")]
		ActivitySignConfigNotFound,
		// Token: 0x0400BC13 RID: 48147
		[OriginalName("SignActivityFreeDropNoConfig")]
		SignActivityFreeDropNoConfig,
		// Token: 0x0400BC14 RID: 48148
		[OriginalName("SignActivityFreeDropAlreadyTaken")]
		SignActivityFreeDropAlreadyTaken,
		// Token: 0x0400BC15 RID: 48149
		[OriginalName("NewBieV2NoLicense")]
		NewBieV2NoLicense,
		// Token: 0x0400BC16 RID: 48150
		[OriginalName("NewBieV1NoLicense")]
		NewBieV1NoLicense,
		// Token: 0x0400BC17 RID: 48151
		[OriginalName("WeekCardPersonalNoPermission")]
		WeekCardPersonalNoPermission,
		// Token: 0x0400BC18 RID: 48152
		[OriginalName("WeekCardPersonalPermissionExpired")]
		WeekCardPersonalPermissionExpired,
		// Token: 0x0400BC19 RID: 48153
		[OriginalName("WeekCardNotPersonal")]
		WeekCardNotPersonal,
		// Token: 0x0400BC1A RID: 48154
		[OriginalName("WeekCardInputErr")]
		WeekCardInputErr = 3100286,
		// Token: 0x0400BC1B RID: 48155
		[OriginalName("WeekCardRecycleNoPermission")]
		WeekCardRecycleNoPermission = 3100278,
		// Token: 0x0400BC1C RID: 48156
		[OriginalName("NewPlayerSupportSameParent")]
		NewPlayerSupportSameParent = 3100323,
		// Token: 0x0400BC1D RID: 48157
		[OriginalName("NewBieCourseV2ActivityNotOpen")]
		NewBieCourseV2ActivityNotOpen = 3100279,
		// Token: 0x0400BC1E RID: 48158
		[OriginalName("NewBieCourseV2ActivityCfgNotFound")]
		NewBieCourseV2ActivityCfgNotFound,
		// Token: 0x0400BC1F RID: 48159
		[OriginalName("NewBieCourseV2ActivityEnd")]
		NewBieCourseV2ActivityEnd,
		// Token: 0x0400BC20 RID: 48160
		[OriginalName("NewBieCourseV2InvalidInput")]
		NewBieCourseV2InvalidInput,
		// Token: 0x0400BC21 RID: 48161
		[OriginalName("NewBieCourseV2CfgNotFound")]
		NewBieCourseV2CfgNotFound,
		// Token: 0x0400BC22 RID: 48162
		[OriginalName("NewBieCourseV2LevelNotEnough")]
		NewBieCourseV2LevelNotEnough,
		// Token: 0x0400BC23 RID: 48163
		[OriginalName("NewBieCourseV2RewardAlreadyTaken")]
		NewBieCourseV2RewardAlreadyTaken,
		// Token: 0x0400BC24 RID: 48164
		[OriginalName("ErrNotGetFightInfoDtType")]
		ErrNotGetFightInfoDtType = 3200000,
		// Token: 0x0400BC25 RID: 48165
		[OriginalName("ErrFightInfoDtType")]
		ErrFightInfoDtType,
		// Token: 0x0400BC26 RID: 48166
		[OriginalName("ErrSetFightInfoDtType")]
		ErrSetFightInfoDtType,
		// Token: 0x0400BC27 RID: 48167
		[OriginalName("ErrChangeDtTypeParamError")]
		ErrChangeDtTypeParamError,
		// Token: 0x0400BC28 RID: 48168
		[OriginalName("ErrCurSceneNotMatch")]
		ErrCurSceneNotMatch = 3300000,
		// Token: 0x0400BC29 RID: 48169
		[OriginalName("ErrTargetNotForDeadEye")]
		ErrTargetNotForDeadEye,
		// Token: 0x0400BC2A RID: 48170
		[OriginalName("ErrDeadEyeCount")]
		ErrDeadEyeCount,
		// Token: 0x0400BC2B RID: 48171
		[OriginalName("ErrNoMoveEvent")]
		ErrNoMoveEvent,
		// Token: 0x0400BC2C RID: 48172
		[OriginalName("ErrEntityTypeNotSupport")]
		ErrEntityTypeNotSupport,
		// Token: 0x0400BC2D RID: 48173
		[OriginalName("ErrExploreSkillNoActions")]
		ErrExploreSkillNoActions,
		// Token: 0x0400BC2E RID: 48174
		[OriginalName("ErrExploreSkillActionMultiGame")]
		ErrExploreSkillActionMultiGame,
		// Token: 0x0400BC2F RID: 48175
		[OriginalName("ErrExploreSkillActionNotExist")]
		ErrExploreSkillActionNotExist,
		// Token: 0x0400BC30 RID: 48176
		[OriginalName("ErrMonsterNotGameplayTagComp")]
		ErrMonsterNotGameplayTagComp,
		// Token: 0x0400BC31 RID: 48177
		[OriginalName("ErrDecalEffectNotFound")]
		ErrDecalEffectNotFound,
		// Token: 0x0400BC32 RID: 48178
		[OriginalName("ErrEntityNotInCurMap")]
		ErrEntityNotInCurMap,
		// Token: 0x0400BC33 RID: 48179
		[OriginalName("ErrEntityNotInCurScene")]
		ErrEntityNotInCurScene,
		// Token: 0x0400BC34 RID: 48180
		[OriginalName("ErrEntityNotForNpcTimeSchedule")]
		ErrEntityNotForNpcTimeSchedule,
		// Token: 0x0400BC35 RID: 48181
		[OriginalName("ErrEntityNotInAnySchedule")]
		ErrEntityNotInAnySchedule,
		// Token: 0x0400BC36 RID: 48182
		[OriginalName("ErrSplineConfigNotFound")]
		ErrSplineConfigNotFound,
		// Token: 0x0400BC37 RID: 48183
		[OriginalName("ErrSplineIdxOutofBound")]
		ErrSplineIdxOutofBound,
		// Token: 0x0400BC38 RID: 48184
		[OriginalName("ErrPositionConfig")]
		ErrPositionConfig,
		// Token: 0x0400BC39 RID: 48185
		[OriginalName("ErrSplineNotForTimeSchedule")]
		ErrSplineNotForTimeSchedule,
		// Token: 0x0400BC3A RID: 48186
		[OriginalName("ErrHostPlayerNotSame")]
		ErrHostPlayerNotSame,
		// Token: 0x0400BC3B RID: 48187
		[OriginalName("ErrInteractType")]
		ErrInteractType,
		// Token: 0x0400BC3C RID: 48188
		[OriginalName("ErrEntityAlreadyDie")]
		ErrEntityAlreadyDie,
		// Token: 0x0400BC3D RID: 48189
		[OriginalName("ErrEntityAlreadyDestroyed")]
		ErrEntityAlreadyDestroyed,
		// Token: 0x0400BC3E RID: 48190
		[OriginalName("ErrRequestLimitExceeded")]
		ErrRequestLimitExceeded,
		// Token: 0x0400BC3F RID: 48191
		[OriginalName("ErrOptionOutofBound")]
		ErrOptionOutofBound,
		// Token: 0x0400BC40 RID: 48192
		[OriginalName("ErrHoldHandInvalidActionType")]
		ErrHoldHandInvalidActionType,
		// Token: 0x0400BC41 RID: 48193
		[OriginalName("ErrMultiPreconditionChainError")]
		ErrMultiPreconditionChainError,
		// Token: 0x0400BC42 RID: 48194
		[OriginalName("ErrBlackScreenIllegalSource")]
		ErrBlackScreenIllegalSource = 3400000,
		// Token: 0x0400BC43 RID: 48195
		[OriginalName("ErrBeamReceiveEntityNotConfig")]
		ErrBeamReceiveEntityNotConfig,
		// Token: 0x0400BC44 RID: 48196
		[OriginalName("ErrBeamReceiveCondition")]
		ErrBeamReceiveCondition,
		// Token: 0x0400BC45 RID: 48197
		[OriginalName("ErrBeamReceiveEntityNotConfig2")]
		ErrBeamReceiveEntityNotConfig2,
		// Token: 0x0400BC46 RID: 48198
		[OriginalName("ErrFlowerPollutionNotConfig")]
		ErrFlowerPollutionNotConfig,
		// Token: 0x0400BC47 RID: 48199
		[OriginalName("ErrorFlowerPollutionState")]
		ErrorFlowerPollutionState,
		// Token: 0x0400BC48 RID: 48200
		[OriginalName("ErrDollGarbTimeOut")]
		ErrDollGarbTimeOut,
		// Token: 0x0400BC49 RID: 48201
		[OriginalName("ErrGrabMachineEntityNotConfig")]
		ErrGrabMachineEntityNotConfig,
		// Token: 0x0400BC4A RID: 48202
		[OriginalName("ErrGrabItemNotInConfig")]
		ErrGrabItemNotInConfig,
		// Token: 0x0400BC4B RID: 48203
		[OriginalName("ErrItemHasBeenClipped")]
		ErrItemHasBeenClipped,
		// Token: 0x0400BC4C RID: 48204
		[OriginalName("ErrDollGrabNoCsvConfig")]
		ErrDollGrabNoCsvConfig,
		// Token: 0x0400BC4D RID: 48205
		[OriginalName("ErrPlayerNotStartedPlaying")]
		ErrPlayerNotStartedPlaying,
		// Token: 0x0400BC4E RID: 48206
		[OriginalName("ErrGrabShowcaseEntityNotConfig")]
		ErrGrabShowcaseEntityNotConfig,
		// Token: 0x0400BC4F RID: 48207
		[OriginalName("ErrPlayerBagNotDoll")]
		ErrPlayerBagNotDoll,
		// Token: 0x0400BC50 RID: 48208
		[OriginalName("ErrDollIsDelivered")]
		ErrDollIsDelivered,
		// Token: 0x0400BC51 RID: 48209
		[OriginalName("ErrPlayerAlreadyPlaying")]
		ErrPlayerAlreadyPlaying,
		// Token: 0x0400BC52 RID: 48210
		[OriginalName("ErrGrabItemTypeMismatch")]
		ErrGrabItemTypeMismatch,
		// Token: 0x0400BC53 RID: 48211
		[OriginalName("ErrDollGrabAlreadyPaused")]
		ErrDollGrabAlreadyPaused,
		// Token: 0x0400BC54 RID: 48212
		[OriginalName("ErrDollGrabNotPaused")]
		ErrDollGrabNotPaused,
		// Token: 0x0400BC55 RID: 48213
		[OriginalName("ErrDollMachineDropReward")]
		ErrDollMachineDropReward
	}
}
