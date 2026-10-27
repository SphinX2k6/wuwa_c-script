using System;

// Token: 0x02000084 RID: 132
[Flags]
public enum EEntityTypeQuery
{
	// Token: 0x040003BE RID: 958
	NormalEntity = 1,
	// Token: 0x040003BF RID: 959
	NormalEntityAlwaysTick = 2,
	// Token: 0x040003C0 RID: 960
	NormalEntityAlwaysTickWhitoutNotRenderedGroup = 4,
	// Token: 0x040003C1 RID: 961
	MoveSceneItem = 8,
	// Token: 0x040003C2 RID: 962
	SimpleNPC = 16,
	// Token: 0x040003C3 RID: 963
	NormalNPC = 32,
	// Token: 0x040003C4 RID: 964
	PasserbyNPC = 64,
	// Token: 0x040003C5 RID: 965
	Monster = 64,
	// Token: 0x040003C6 RID: 966
	Animal = 64,
	// Token: 0x040003C7 RID: 967
	Boss = 128,
	// Token: 0x040003C8 RID: 968
	Team = 256,
	// Token: 0x040003C9 RID: 969
	MasterRole = 256,
	// Token: 0x040003CA RID: 970
	MasterRoleDerivedMonster = 256,
	// Token: 0x040003CB RID: 971
	Vision = 256,
	// Token: 0x040003CC RID: 972
	SceneItem = 15,
	// Token: 0x040003CD RID: 973
	Player = 256,
	// Token: 0x040003CE RID: 974
	Character = 496,
	// Token: 0x040003CF RID: 975
	SceneItemOrCharacter = 511,
	// Token: 0x040003D0 RID: 976
	All = 511,
	// Token: 0x040003D1 RID: 977
	Custom = 512,
	// Token: 0x040003D2 RID: 978
	MaxIndex = 9
}
