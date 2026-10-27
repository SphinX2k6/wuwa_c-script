using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020034A9 RID: 13481
[NullableContext(1)]
[Nullable(0)]
public class CollisionUtils : Singleton
{
	// Token: 0x0601D597 RID: 120215 RVA: 0x0082E6CF File Offset: 0x0082C8CF
	public FCollisionResponseContainer GetCollisionResponseContainer()
	{
		if (this.CollisionResponseContainerRef == null)
		{
			this.CollisionResponseContainerRef = new FCollisionResponseContainer();
		}
		UKismetSystemLibrary.SetAllChannels(ref this.CollisionResponseContainerRef, ECollisionResponse.ECR_Ignore);
		return this.CollisionResponseContainerRef;
	}

	// Token: 0x0601D598 RID: 120216 RVA: 0x0082E700 File Offset: 0x0082C900
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

	// Token: 0x170028BA RID: 10426
	// (get) Token: 0x0601D599 RID: 120217 RVA: 0x0082E7AC File Offset: 0x0082C9AC
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

	// Token: 0x0601D59A RID: 120218 RVA: 0x0082E7CF File Offset: 0x0082C9CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D59B RID: 120219 RVA: 0x0082E7D1 File Offset: 0x0082C9D1
	public static void ResetStaticDefaultValue()
	{
		CollisionUtils instance = CollisionUtils._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CollisionUtils._instance = null;
	}

	// Token: 0x0601D59C RID: 120220 RVA: 0x0082E7EA File Offset: 0x0082C9EA
	static CollisionUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CollisionUtils.CreateStaticDefaultValue), new Action(CollisionUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0400E74C RID: 59212
	[Nullable(2)]
	private FCollisionResponseContainer CollisionResponseContainerRef;

	// Token: 0x0400E74D RID: 59213
	[Nullable(2)]
	private static CollisionUtils _instance;
}
