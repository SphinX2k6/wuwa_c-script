using System;

// Token: 0x02000086 RID: 134
[Flags]
public enum EEntityTypeQuery
{
	// Token: 0x040003CC RID: 972
	NormalEntity = 1,
	// Token: 0x040003CD RID: 973
	NormalEntityAlwaysTick = 2,
	// Token: 0x040003CE RID: 974
	NormalEntityAlwaysTickWhitoutNotRenderedGroup = 4,
	// Token: 0x040003CF RID: 975
	MoveSceneItem = 8,
	// Token: 0x040003D0 RID: 976
	SimpleNPC = 16,
	// Token: 0x040003D1 RID: 977
	NormalNPC = 32,
	// Token: 0x040003D2 RID: 978
	PasserbyNPC = 64,
	// Token: 0x040003D3 RID: 979
	Monster = 64,
	// Token: 0x040003D4 RID: 980
	Animal = 64,
	// Token: 0x040003D5 RID: 981
	Boss = 128,
	// Token: 0x040003D6 RID: 982
	Team = 256,
	// Token: 0x040003D7 RID: 983
	MasterRole = 256,
	// Token: 0x040003D8 RID: 984
	MasterRoleDerivedMonster = 256,
	// Token: 0x040003D9 RID: 985
	Vision = 256,
	// Token: 0x040003DA RID: 986
	SceneItem = 15,
	// Token: 0x040003DB RID: 987
	Player = 256,
	// Token: 0x040003DC RID: 988
	Character = 496,
	// Token: 0x040003DD RID: 989
	SceneItemOrCharacter = 511,
	// Token: 0x040003DE RID: 990
	All = 511,
	// Token: 0x040003DF RID: 991
	Custom = 512,
	// Token: 0x040003E0 RID: 992
	MaxIndex = 9
}
