using System;
using UnrealEngine;

// Token: 0x02000070 RID: 112
public static class KuroCollisionChannel
{
	// Token: 0x0400032F RID: 815
	public static readonly ECollisionChannel WorldStatic = ECollisionChannel.ECC_WorldStatic;

	// Token: 0x04000330 RID: 816
	public static readonly ECollisionChannel WorldDynamic = ECollisionChannel.ECC_WorldDynamic;

	// Token: 0x04000331 RID: 817
	public static readonly ECollisionChannel Pawn = ECollisionChannel.ECC_Pawn;

	// Token: 0x04000332 RID: 818
	public static readonly ECollisionChannel Visibility = ECollisionChannel.ECC_Visibility;

	// Token: 0x04000333 RID: 819
	public static readonly ECollisionChannel Camera = ECollisionChannel.ECC_Camera;

	// Token: 0x04000334 RID: 820
	public static readonly ECollisionChannel PhysicsBody = ECollisionChannel.ECC_PhysicsBody;

	// Token: 0x04000335 RID: 821
	public static readonly ECollisionChannel Vehicle = ECollisionChannel.ECC_Vehicle;

	// Token: 0x04000336 RID: 822
	public static readonly ECollisionChannel Destructible = ECollisionChannel.ECC_Destructible;

	// Token: 0x04000337 RID: 823
	public static readonly ECollisionChannel StraightWall_Deprecated = ECollisionChannel.ECC_GameTraceChannel1;

	// Token: 0x04000338 RID: 824
	public static readonly ECollisionChannel Water = ECollisionChannel.ECC_GameTraceChannel2;

	// Token: 0x04000339 RID: 825
	public static readonly ECollisionChannel Climb = ECollisionChannel.ECC_GameTraceChannel3;

	// Token: 0x0400033A RID: 826
	public static readonly ECollisionChannel IkGround = ECollisionChannel.ECC_GameTraceChannel4;

	// Token: 0x0400033B RID: 827
	public static readonly ECollisionChannel PawnPlayer = ECollisionChannel.ECC_GameTraceChannel5;

	// Token: 0x0400033C RID: 828
	public static readonly ECollisionChannel Bullet = ECollisionChannel.ECC_GameTraceChannel6;

	// Token: 0x0400033D RID: 829
	public static readonly ECollisionChannel CanBeObserved_Deprecated = ECollisionChannel.ECC_GameTraceChannel7;

	// Token: 0x0400033E RID: 830
	public static readonly ECollisionChannel PawnMonster = ECollisionChannel.ECC_GameTraceChannel8;

	// Token: 0x0400033F RID: 831
	public static readonly ECollisionChannel Lgui = ECollisionChannel.ECC_GameTraceChannel9;

	// Token: 0x04000340 RID: 832
	public static readonly ECollisionChannel WorldStaticIgnoreBullet = ECollisionChannel.ECC_GameTraceChannel10;

	// Token: 0x04000341 RID: 833
	public static readonly ECollisionChannel KuroTrigger = ECollisionChannel.ECC_GameTraceChannel11;

	// Token: 0x04000342 RID: 834
	public static readonly ECollisionChannel AirFloor = ECollisionChannel.ECC_GameTraceChannel12;

	// Token: 0x04000343 RID: 835
	public static readonly ECollisionChannel AcrossBlock = ECollisionChannel.ECC_GameTraceChannel13;

	// Token: 0x04000344 RID: 836
	public static readonly ECollisionChannel VoiceBlock = ECollisionChannel.ECC_GameTraceChannel14;

	// Token: 0x04000345 RID: 837
	public static readonly ECollisionChannel HitItem = ECollisionChannel.ECC_GameTraceChannel15;

	// Token: 0x04000346 RID: 838
	public static readonly ECollisionChannel BulletSpecial = ECollisionChannel.ECC_GameTraceChannel16;

	// Token: 0x04000347 RID: 839
	public static readonly ECollisionChannel KuroWater = ECollisionChannel.ECC_GameTraceChannel18;
}
