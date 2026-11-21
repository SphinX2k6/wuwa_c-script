using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024FC RID: 9468
public class LevelBuffSetWalkableFloorAngle : LevelBuffBase
{
	// Token: 0x0601770A RID: 96010 RVA: 0x006E9F1A File Offset: 0x006E811A
	[NullableContext(1)]
	public LevelBuffSetWalkableFloorAngle(Entity entity, long buffId, string[] @params, float param1, float param2) : base(entity, buffId, @params, param1, param2)
	{
	}

	// Token: 0x0601770B RID: 96011 RVA: 0x006E9F2C File Offset: 0x006E812C
	public override void OnCreated()
	{
		UCharacterMovementComponent characterMovement = this.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement;
		this.OriginalWalkableFloorAngle = characterMovement.WalkableFloorAngle;
		float walkableFloorAngle;
		if (!float.TryParse(this.Params[0], out walkableFloorAngle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "LevelBuffSetWalkableFloorAngle玩法效果缺少参数";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Buff", this.BuffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		characterMovement.SetWalkableFloorAngle(walkableFloorAngle);
	}

	// Token: 0x0601770C RID: 96012 RVA: 0x006E9FA0 File Offset: 0x006E81A0
	public override void OnRemoved(bool bPremature)
	{
		this.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement.SetWalkableFloorAngle(this.OriginalWalkableFloorAngle);
	}

	// Token: 0x0400C745 RID: 51013
	private float OriginalWalkableFloorAngle;
}
