using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001660 RID: 5728
	public enum SimpleCombatAttributeType
	{
		// Token: 0x0400C2EB RID: 49899
		[OriginalName("KscNone")]
		KscNone,
		// Token: 0x0400C2EC RID: 49900
		[OriginalName("KscLv")]
		KscLv,
		// Token: 0x0400C2ED RID: 49901
		[OriginalName("KscLifeMax")]
		KscLifeMax,
		// Token: 0x0400C2EE RID: 49902
		[OriginalName("KscLife")]
		KscLife,
		// Token: 0x0400C2EF RID: 49903
		[OriginalName("KscShield")]
		KscShield,
		// Token: 0x0400C2F0 RID: 49904
		[OriginalName("KscAtk")]
		KscAtk = 7,
		// Token: 0x0400C2F1 RID: 49905
		[OriginalName("KscCrit")]
		KscCrit,
		// Token: 0x0400C2F2 RID: 49906
		[OriginalName("KscCritDamage")]
		KscCritDamage,
		// Token: 0x0400C2F3 RID: 49907
		[OriginalName("KscDef")]
		KscDef,
		// Token: 0x0400C2F4 RID: 49908
		[OriginalName("KscAtkChange")]
		KscAtkChange,
		// Token: 0x0400C2F5 RID: 49909
		[OriginalName("KscMaxLifeShieldChange")]
		KscMaxLifeShieldChange,
		// Token: 0x0400C2F6 RID: 49910
		[OriginalName("KscBaseLife")]
		KscBaseLife,
		// Token: 0x0400C2F7 RID: 49911
		[OriginalName("KscCritChange")]
		KscCritChange,
		// Token: 0x0400C2F8 RID: 49912
		[OriginalName("KscDamageChange")]
		KscDamageChange,
		// Token: 0x0400C2F9 RID: 49913
		[OriginalName("KscDamageReduce")]
		KscDamageReduce,
		// Token: 0x0400C2FA RID: 49914
		[OriginalName("KscDamageLifeSteal")]
		KscDamageLifeSteal,
		// Token: 0x0400C2FB RID: 49915
		[OriginalName("KscHealBase")]
		KscHealBase,
		// Token: 0x0400C2FC RID: 49916
		[OriginalName("KscDamageReduceCollision")]
		KscDamageReduceCollision,
		// Token: 0x0400C2FD RID: 49917
		[OriginalName("KscDamageAbsorptionCount")]
		KscDamageAbsorptionCount,
		// Token: 0x0400C2FE RID: 49918
		[OriginalName("KscDamageChangePhys")]
		KscDamageChangePhys,
		// Token: 0x0400C2FF RID: 49919
		[OriginalName("KscDamageChangeElement1")]
		KscDamageChangeElement1,
		// Token: 0x0400C300 RID: 49920
		[OriginalName("KscDamageChangeElement2")]
		KscDamageChangeElement2,
		// Token: 0x0400C301 RID: 49921
		[OriginalName("KscDamageChangeElement3")]
		KscDamageChangeElement3,
		// Token: 0x0400C302 RID: 49922
		[OriginalName("KscDamageChangeElement4")]
		KscDamageChangeElement4,
		// Token: 0x0400C303 RID: 49923
		[OriginalName("KscDamageChangeElement5")]
		KscDamageChangeElement5,
		// Token: 0x0400C304 RID: 49924
		[OriginalName("KscDamageChangeElement6")]
		KscDamageChangeElement6,
		// Token: 0x0400C305 RID: 49925
		[OriginalName("KscDamageResistancePhys")]
		KscDamageResistancePhys,
		// Token: 0x0400C306 RID: 49926
		[OriginalName("KscDamageResistanceElement1")]
		KscDamageResistanceElement1,
		// Token: 0x0400C307 RID: 49927
		[OriginalName("KscDamageResistanceElement2")]
		KscDamageResistanceElement2,
		// Token: 0x0400C308 RID: 49928
		[OriginalName("KscDamageResistanceElement3")]
		KscDamageResistanceElement3,
		// Token: 0x0400C309 RID: 49929
		[OriginalName("KscDamageResistanceElement4")]
		KscDamageResistanceElement4,
		// Token: 0x0400C30A RID: 49930
		[OriginalName("KscDamageResistanceElement5")]
		KscDamageResistanceElement5,
		// Token: 0x0400C30B RID: 49931
		[OriginalName("KscDamageResistanceElement6")]
		KscDamageResistanceElement6,
		// Token: 0x0400C30C RID: 49932
		[OriginalName("KscHealChange")]
		KscHealChange,
		// Token: 0x0400C30D RID: 49933
		[OriginalName("KscHealedChange")]
		KscHealedChange,
		// Token: 0x0400C30E RID: 49934
		[OriginalName("KscDamageReducePhys")]
		KscDamageReducePhys,
		// Token: 0x0400C30F RID: 49935
		[OriginalName("KscDamageReduceElement1")]
		KscDamageReduceElement1,
		// Token: 0x0400C310 RID: 49936
		[OriginalName("KscDamageReduceElement2")]
		KscDamageReduceElement2,
		// Token: 0x0400C311 RID: 49937
		[OriginalName("KscDamageReduceElement3")]
		KscDamageReduceElement3,
		// Token: 0x0400C312 RID: 49938
		[OriginalName("KscDamageReduceElement4")]
		KscDamageReduceElement4,
		// Token: 0x0400C313 RID: 49939
		[OriginalName("KscDamageReduceElement5")]
		KscDamageReduceElement5,
		// Token: 0x0400C314 RID: 49940
		[OriginalName("KscDamageReduceElement6")]
		KscDamageReduceElement6,
		// Token: 0x0400C315 RID: 49941
		[OriginalName("KscDamageAmplify1")]
		KscDamageAmplify1,
		// Token: 0x0400C316 RID: 49942
		[OriginalName("KscDamageAmplify2")]
		KscDamageAmplify2,
		// Token: 0x0400C317 RID: 49943
		[OriginalName("KscIgnoreDefRate")]
		KscIgnoreDefRate = 99,
		// Token: 0x0400C318 RID: 49944
		[OriginalName("KscIgnoreDamageResistancePhys")]
		KscIgnoreDamageResistancePhys,
		// Token: 0x0400C319 RID: 49945
		[OriginalName("KscIgnoreDamageResistanceElement1")]
		KscIgnoreDamageResistanceElement1,
		// Token: 0x0400C31A RID: 49946
		[OriginalName("KscIgnoreDamageResistanceElement2")]
		KscIgnoreDamageResistanceElement2,
		// Token: 0x0400C31B RID: 49947
		[OriginalName("KscIgnoreDamageResistanceElement3")]
		KscIgnoreDamageResistanceElement3,
		// Token: 0x0400C31C RID: 49948
		[OriginalName("KscIgnoreDamageResistanceElement4")]
		KscIgnoreDamageResistanceElement4,
		// Token: 0x0400C31D RID: 49949
		[OriginalName("KscIgnoreDamageResistanceElement5")]
		KscIgnoreDamageResistanceElement5,
		// Token: 0x0400C31E RID: 49950
		[OriginalName("KscIgnoreDamageResistanceElement6")]
		KscIgnoreDamageResistanceElement6,
		// Token: 0x0400C31F RID: 49951
		[OriginalName("KscSkillCoolDown")]
		KscSkillCoolDown = 117,
		// Token: 0x0400C320 RID: 49952
		[OriginalName("KscSkillCoolDownChange")]
		KscSkillCoolDownChange,
		// Token: 0x0400C321 RID: 49953
		[OriginalName("KscSkillCoolDownChangeMin")]
		KscSkillCoolDownChangeMin,
		// Token: 0x0400C322 RID: 49954
		[OriginalName("KscCustomProperty1")]
		KscCustomProperty1,
		// Token: 0x0400C323 RID: 49955
		[OriginalName("KscCustomProperty2")]
		KscCustomProperty2,
		// Token: 0x0400C324 RID: 49956
		[OriginalName("KscCustomProperty3")]
		KscCustomProperty3,
		// Token: 0x0400C325 RID: 49957
		[OriginalName("KscCustomProperty4")]
		KscCustomProperty4,
		// Token: 0x0400C326 RID: 49958
		[OriginalName("KscCustomProperty5")]
		KscCustomProperty5,
		// Token: 0x0400C327 RID: 49959
		[OriginalName("KscCustomProperty6")]
		KscCustomProperty6,
		// Token: 0x0400C328 RID: 49960
		[OriginalName("KscCustomProperty7")]
		KscCustomProperty7,
		// Token: 0x0400C329 RID: 49961
		[OriginalName("KscCustomProperty8")]
		KscCustomProperty8,
		// Token: 0x0400C32A RID: 49962
		[OriginalName("KscCustomProperty9")]
		KscCustomProperty9,
		// Token: 0x0400C32B RID: 49963
		[OriginalName("KscCustomProperty10")]
		KscCustomProperty10,
		// Token: 0x0400C32C RID: 49964
		[OriginalName("KscCustomProperty11")]
		KscCustomProperty11,
		// Token: 0x0400C32D RID: 49965
		[OriginalName("KscCustomProperty12")]
		KscCustomProperty12,
		// Token: 0x0400C32E RID: 49966
		[OriginalName("KscCustomProperty13")]
		KscCustomProperty13,
		// Token: 0x0400C32F RID: 49967
		[OriginalName("KscCustomProperty14")]
		KscCustomProperty14,
		// Token: 0x0400C330 RID: 49968
		[OriginalName("KscCustomProperty15")]
		KscCustomProperty15,
		// Token: 0x0400C331 RID: 49969
		[OriginalName("KscCustomProperty16")]
		KscCustomProperty16,
		// Token: 0x0400C332 RID: 49970
		[OriginalName("KscCustomProperty17")]
		KscCustomProperty17,
		// Token: 0x0400C333 RID: 49971
		[OriginalName("KscCustomProperty18")]
		KscCustomProperty18,
		// Token: 0x0400C334 RID: 49972
		[OriginalName("KscCustomProperty19")]
		KscCustomProperty19,
		// Token: 0x0400C335 RID: 49973
		[OriginalName("KscCustomProperty20")]
		KscCustomProperty20,
		// Token: 0x0400C336 RID: 49974
		[OriginalName("KscCustomProperty21")]
		KscCustomProperty21,
		// Token: 0x0400C337 RID: 49975
		[OriginalName("KscCustomProperty22")]
		KscCustomProperty22,
		// Token: 0x0400C338 RID: 49976
		[OriginalName("KscCustomProperty23")]
		KscCustomProperty23,
		// Token: 0x0400C339 RID: 49977
		[OriginalName("KscCustomProperty24")]
		KscCustomProperty24,
		// Token: 0x0400C33A RID: 49978
		[OriginalName("KscCustomProperty25")]
		KscCustomProperty25,
		// Token: 0x0400C33B RID: 49979
		[OriginalName("KscCustomProperty26")]
		KscCustomProperty26,
		// Token: 0x0400C33C RID: 49980
		[OriginalName("KscCustomProperty27")]
		KscCustomProperty27,
		// Token: 0x0400C33D RID: 49981
		[OriginalName("KscCustomProperty28")]
		KscCustomProperty28,
		// Token: 0x0400C33E RID: 49982
		[OriginalName("KscCustomProperty29")]
		KscCustomProperty29,
		// Token: 0x0400C33F RID: 49983
		[OriginalName("KscCustomProperty30")]
		KscCustomProperty30,
		// Token: 0x0400C340 RID: 49984
		[OriginalName("KscCustomProperty31")]
		KscCustomProperty31,
		// Token: 0x0400C341 RID: 49985
		[OriginalName("KscCustomProperty32")]
		KscCustomProperty32,
		// Token: 0x0400C342 RID: 49986
		[OriginalName("KscCustomProperty33")]
		KscCustomProperty33,
		// Token: 0x0400C343 RID: 49987
		[OriginalName("KscCustomProperty34")]
		KscCustomProperty34,
		// Token: 0x0400C344 RID: 49988
		[OriginalName("KscCustomProperty35")]
		KscCustomProperty35,
		// Token: 0x0400C345 RID: 49989
		[OriginalName("KscCustomProperty36")]
		KscCustomProperty36,
		// Token: 0x0400C346 RID: 49990
		[OriginalName("KscCustomProperty37")]
		KscCustomProperty37,
		// Token: 0x0400C347 RID: 49991
		[OriginalName("KscCustomProperty38")]
		KscCustomProperty38,
		// Token: 0x0400C348 RID: 49992
		[OriginalName("KscCustomProperty39")]
		KscCustomProperty39,
		// Token: 0x0400C349 RID: 49993
		[OriginalName("KscCustomProperty40")]
		KscCustomProperty40,
		// Token: 0x0400C34A RID: 49994
		[OriginalName("KscCustomProperty41")]
		KscCustomProperty41,
		// Token: 0x0400C34B RID: 49995
		[OriginalName("KscCustomProperty42")]
		KscCustomProperty42,
		// Token: 0x0400C34C RID: 49996
		[OriginalName("KscCustomProperty43")]
		KscCustomProperty43,
		// Token: 0x0400C34D RID: 49997
		[OriginalName("KscCustomProperty44")]
		KscCustomProperty44,
		// Token: 0x0400C34E RID: 49998
		[OriginalName("KscCustomProperty45")]
		KscCustomProperty45,
		// Token: 0x0400C34F RID: 49999
		[OriginalName("KscCustomProperty46")]
		KscCustomProperty46,
		// Token: 0x0400C350 RID: 50000
		[OriginalName("KscCustomProperty47")]
		KscCustomProperty47,
		// Token: 0x0400C351 RID: 50001
		[OriginalName("KscCustomProperty48")]
		KscCustomProperty48,
		// Token: 0x0400C352 RID: 50002
		[OriginalName("KscCustomProperty49")]
		KscCustomProperty49,
		// Token: 0x0400C353 RID: 50003
		[OriginalName("KscCustomProperty50")]
		KscCustomProperty50,
		// Token: 0x0400C354 RID: 50004
		[OriginalName("KscCustomProperty51")]
		KscCustomProperty51,
		// Token: 0x0400C355 RID: 50005
		[OriginalName("KscCustomProperty52")]
		KscCustomProperty52,
		// Token: 0x0400C356 RID: 50006
		[OriginalName("KscCustomProperty53")]
		KscCustomProperty53,
		// Token: 0x0400C357 RID: 50007
		[OriginalName("KscCustomProperty54")]
		KscCustomProperty54,
		// Token: 0x0400C358 RID: 50008
		[OriginalName("KscCustomProperty55")]
		KscCustomProperty55,
		// Token: 0x0400C359 RID: 50009
		[OriginalName("KscCustomProperty56")]
		KscCustomProperty56,
		// Token: 0x0400C35A RID: 50010
		[OriginalName("KscCustomProperty57")]
		KscCustomProperty57,
		// Token: 0x0400C35B RID: 50011
		[OriginalName("KscCustomProperty58")]
		KscCustomProperty58,
		// Token: 0x0400C35C RID: 50012
		[OriginalName("KscCustomProperty59")]
		KscCustomProperty59,
		// Token: 0x0400C35D RID: 50013
		[OriginalName("KscCustomProperty60")]
		KscCustomProperty60,
		// Token: 0x0400C35E RID: 50014
		[OriginalName("KscCustomProperty61")]
		KscCustomProperty61,
		// Token: 0x0400C35F RID: 50015
		[OriginalName("KscCustomProperty62")]
		KscCustomProperty62,
		// Token: 0x0400C360 RID: 50016
		[OriginalName("KscCustomProperty63")]
		KscCustomProperty63,
		// Token: 0x0400C361 RID: 50017
		[OriginalName("KscCustomProperty64")]
		KscCustomProperty64,
		// Token: 0x0400C362 RID: 50018
		[OriginalName("KscCustomProperty65")]
		KscCustomProperty65,
		// Token: 0x0400C363 RID: 50019
		[OriginalName("KscCustomProperty66")]
		KscCustomProperty66,
		// Token: 0x0400C364 RID: 50020
		[OriginalName("KscCustomProperty67")]
		KscCustomProperty67,
		// Token: 0x0400C365 RID: 50021
		[OriginalName("KscCustomProperty68")]
		KscCustomProperty68,
		// Token: 0x0400C366 RID: 50022
		[OriginalName("KscCustomProperty69")]
		KscCustomProperty69,
		// Token: 0x0400C367 RID: 50023
		[OriginalName("KscCustomProperty70")]
		KscCustomProperty70,
		// Token: 0x0400C368 RID: 50024
		[OriginalName("KscMoveSpeed")]
		KscMoveSpeed,
		// Token: 0x0400C369 RID: 50025
		[OriginalName("KscMoveSpeedAdd")]
		KscMoveSpeedAdd,
		// Token: 0x0400C36A RID: 50026
		[OriginalName("KscMoveSpeedReduce")]
		KscMoveSpeedReduce,
		// Token: 0x0400C36B RID: 50027
		[OriginalName("KscAddBuffDuration")]
		KscAddBuffDuration = 199,
		// Token: 0x0400C36C RID: 50028
		[OriginalName("KscBuffDuration")]
		KscBuffDuration,
		// Token: 0x0400C36D RID: 50029
		[OriginalName("KscSpecialDamageChange1")]
		KscSpecialDamageChange1,
		// Token: 0x0400C36E RID: 50030
		[OriginalName("KscSpecialDamageChange2")]
		KscSpecialDamageChange2,
		// Token: 0x0400C36F RID: 50031
		[OriginalName("KscSpecialDamageChange3")]
		KscSpecialDamageChange3,
		// Token: 0x0400C370 RID: 50032
		[OriginalName("KscSpecialDamageChange4")]
		KscSpecialDamageChange4,
		// Token: 0x0400C371 RID: 50033
		[OriginalName("KscSpecialDamageChange5")]
		KscSpecialDamageChange5,
		// Token: 0x0400C372 RID: 50034
		[OriginalName("KscSpecialDamageChange6")]
		KscSpecialDamageChange6,
		// Token: 0x0400C373 RID: 50035
		[OriginalName("KscSpecialDamageChange7")]
		KscSpecialDamageChange7,
		// Token: 0x0400C374 RID: 50036
		[OriginalName("KscSpecialChange0")]
		KscSpecialChange0 = 210,
		// Token: 0x0400C375 RID: 50037
		[OriginalName("KscSpecialChange1")]
		KscSpecialChange1,
		// Token: 0x0400C376 RID: 50038
		[OriginalName("KscSpecialChange2")]
		KscSpecialChange2,
		// Token: 0x0400C377 RID: 50039
		[OriginalName("KscSpecialChange3")]
		KscSpecialChange3,
		// Token: 0x0400C378 RID: 50040
		[OriginalName("KscSpecialChange4")]
		KscSpecialChange4,
		// Token: 0x0400C379 RID: 50041
		[OriginalName("KscSpecialChange5")]
		KscSpecialChange5,
		// Token: 0x0400C37A RID: 50042
		[OriginalName("KscSpecialChange6")]
		KscSpecialChange6,
		// Token: 0x0400C37B RID: 50043
		[OriginalName("KscSpecialChange7")]
		KscSpecialChange7,
		// Token: 0x0400C37C RID: 50044
		[OriginalName("KscSpecialChange8")]
		KscSpecialChange8,
		// Token: 0x0400C37D RID: 50045
		[OriginalName("KscSpecialChange9")]
		KscSpecialChange9,
		// Token: 0x0400C37E RID: 50046
		[OriginalName("KscAttackSpeed")]
		KscAttackSpeed,
		// Token: 0x0400C37F RID: 50047
		[OriginalName("KscAttackSpeedChange")]
		KscAttackSpeedChange,
		// Token: 0x0400C380 RID: 50048
		[OriginalName("KscAttributeTypeMax")]
		KscAttributeTypeMax = 255
	}
}
