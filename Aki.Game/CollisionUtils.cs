using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002A1D RID: 10781
[NullableContext(1)]
[Nullable(0)]
public class CollisionUtils : Singleton
{
	// Token: 0x0601B294 RID: 111252 RVA: 0x008558D7 File Offset: 0x00853AD7
	public FCollisionResponseContainer GetCollisionResponseContainer()
	{
		if (this.CollisionResponseContainerRef == null)
		{
			this.CollisionResponseContainerRef = new FCollisionResponseContainer();
		}
		UKismetSystemLibrary.SetAllChannels(ref this.CollisionResponseContainerRef, ECollisionResponse.ECR_Ignore);
		return this.CollisionResponseContainerRef;
	}

	// Token: 0x0601B295 RID: 111253 RVA: 0x00855908 File Offset: 0x00853B08
	public void SetCollisionResponseToPawn(UCapsuleComponent capsule, EPawnChannel pawnChannel, ECollisionResponse newResponse)
	{
		List<ECollisionChannel> list = new List<ECollisionChannel>();
		if (pawnChannel == EPawnChannel.All)
		{
			list.Add(KuroCollisionChannel.Pawn);
			list.Add(KuroCollisionChannel.PawnPlayer);
			list.Add(KuroCollisionChannel.PawnMonster);
		}
		else if (pawnChannel == EPawnChannel.Pawn)
		{
			list.Add(KuroCollisionChannel.Pawn);
		}
		else if (pawnChannel == EPawnChannel.PawnPlayer)
		{
			list.Add(KuroCollisionChannel.PawnPlayer);
		}
		else if (pawnChannel == EPawnChannel.PawnMonster)
		{
			list.Add(KuroCollisionChannel.PawnMonster);
		}
		foreach (ECollisionChannel channel in list)
		{
			capsule.SetCollisionResponseToChannel(channel, newResponse);
		}
	}

	// Token: 0x17002C52 RID: 11346
	// (get) Token: 0x0601B296 RID: 111254 RVA: 0x008559B4 File Offset: 0x00853BB4
	public static CollisionUtils Instance
	{
		get
		{
			if (CollisionUtils._instance == null)
			{
				CollisionUtils._instance = new CollisionUtils();
				CollisionUtils._instance.OnInit();
			}
			return CollisionUtils._instance;
		}
	}

	// Token: 0x0601B297 RID: 111255 RVA: 0x008559D7 File Offset: 0x00853BD7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B298 RID: 111256 RVA: 0x008559D9 File Offset: 0x00853BD9
	public static void ResetStaticDefaultValue()
	{
		CollisionUtils instance = CollisionUtils._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CollisionUtils._instance = null;
	}

	// Token: 0x0601B299 RID: 111257 RVA: 0x008559F2 File Offset: 0x00853BF2
	static CollisionUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CollisionUtils.CreateStaticDefaultValue), new Action(CollisionUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0400EC00 RID: 60416
	[Nullable(2)]
	private FCollisionResponseContainer CollisionResponseContainerRef;

	// Token: 0x0400EC01 RID: 60417
	[Nullable(2)]
	private static CollisionUtils _instance;
}
