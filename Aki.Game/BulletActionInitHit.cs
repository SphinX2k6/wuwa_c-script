using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002D91 RID: 11665
[NullableContext(1)]
[Nullable(0)]
public class BulletActionInitHit : BulletActionBase
{
	// Token: 0x0601880E RID: 100366 RVA: 0x0063DF48 File Offset: 0x0063C148
	public BulletActionInitHit(EBulletAction type) : base(type)
	{
	}

	// Token: 0x0601880F RID: 100367 RVA: 0x0063DF54 File Offset: 0x0063C154
	protected unsafe override void OnExecute()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		this.BulletInfo.CountByParent = bulletDataMain.Base.ShareCounter;
		if (this.BulletInfo.CountByParent)
		{
			BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(this.BulletInfo.ParentEntityId);
			if (bulletEntityById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "子弹勾选了共享父子弹次数，但是生成时没有父子弹";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletEntityId", this.BulletInfo.BulletEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BulletRowName", this.BulletInfo.BulletRowName);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				BulletInfo bulletInfo = bulletEntityById.GetBulletInfo();
				if (bulletInfo != null)
				{
					this.BulletInfo.ParentBulletInfo = bulletInfo;
					bulletInfo.NeedNotifyChildrenWhenDestroy = true;
					if (bulletInfo.ChildEntityIds == null)
					{
						bulletInfo.ChildEntityIds = new List<int>();
					}
					bulletInfo.ChildEntityIds.Add(this.BulletInfo.BulletEntityId);
				}
			}
		}
		if (bulletDataMain.Base.DaHitTypePreset != FName.NAME_None)
		{
			this.BulletInfo.BulletCamp = bulletDataMain.Base.BulletCamp.Value;
		}
		else
		{
			this.BulletInfo.BulletCamp = BulletActionInitHit.campNumbers[bulletDataMain.Base.HitType];
		}
		this.InitIgnoreChannels();
	}

	// Token: 0x06018810 RID: 100368 RVA: 0x0063E0B8 File Offset: 0x0063C2B8
	private void InitIgnoreChannels()
	{
		ECollisionChannel attackerCollisionChannel = this.GetAttackerCollisionChannel();
		if (attackerCollisionChannel == KuroCollisionChannel.Pawn)
		{
			return;
		}
		BulletCollisionInfo collisionInfo = this.BulletInfo.CollisionInfo;
		if ((this.BulletInfo.BulletCamp & 4) == 0)
		{
			ECollisionChannel ecollisionChannel = KuroCollisionChannel.PawnPlayer + (int)KuroCollisionChannel.PawnMonster - (int)attackerCollisionChannel;
			collisionInfo.IgnoreChannels.Add(ecollisionChannel);
			collisionInfo.IgnoreQueries.Add(BulletActionInitHit.CollisionChannelToObjectTypeQueryMap[ecollisionChannel]);
		}
		if ((this.BulletInfo.BulletCamp & 3) == 0)
		{
			collisionInfo.IgnoreChannels.Add(attackerCollisionChannel);
			collisionInfo.IgnoreQueries.Add(BulletActionInitHit.CollisionChannelToObjectTypeQueryMap[attackerCollisionChannel]);
		}
		if (this.BulletInfo.BulletCamp == 1)
		{
			ECollisionChannel pawn = KuroCollisionChannel.Pawn;
			collisionInfo.IgnoreChannels.Add(pawn);
			collisionInfo.IgnoreQueries.Add(BulletActionInitHit.CollisionChannelToObjectTypeQueryMap[pawn]);
		}
	}

	// Token: 0x06018811 RID: 100369 RVA: 0x0063E18D File Offset: 0x0063C38D
	private ECollisionChannel GetAttackerCollisionChannel()
	{
		if (this.BulletInfo.AttackerCamp == ECamp.Player)
		{
			return KuroCollisionChannel.PawnPlayer;
		}
		if (this.BulletInfo.AttackerCamp == ECamp.Monster)
		{
			return KuroCollisionChannel.PawnMonster;
		}
		return KuroCollisionChannel.Pawn;
	}

	// Token: 0x0400B5BE RID: 46526
	public const int SELF_NUMBER = 1;

	// Token: 0x0400B5BF RID: 46527
	public const int FRIEND_NUMBER = 2;

	// Token: 0x0400B5C0 RID: 46528
	public const int TEAM_NUMBER = 3;

	// Token: 0x0400B5C1 RID: 46529
	public const int ENEMY_NUMBER = 4;

	// Token: 0x0400B5C2 RID: 46530
	public const int PLAYER_GROUP_NUMBER = 11;

	// Token: 0x0400B5C3 RID: 46531
	[StaticVariableRuleIgnore]
	private static readonly int[] campNumbers = new int[]
	{
		1,
		2,
		4,
		3,
		11
	};

	// Token: 0x0400B5C4 RID: 46532
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECollisionChannel, EObjectTypeQuery> CollisionChannelToObjectTypeQueryMap = new Dictionary<ECollisionChannel, EObjectTypeQuery>
	{
		{
			KuroCollisionChannel.Pawn,
			KuroObjectTypeQuery.Pawn
		},
		{
			KuroCollisionChannel.PawnPlayer,
			KuroObjectTypeQuery.PawnPlayer
		},
		{
			KuroCollisionChannel.PawnMonster,
			KuroObjectTypeQuery.PawnMonster
		}
	};
}
