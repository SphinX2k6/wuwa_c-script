using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FA8 RID: 12200
public class LevelBuffSetWalkableFloorAngle : LevelBuffBase
{
	// Token: 0x06019DF8 RID: 105976 RVA: 0x006C367E File Offset: 0x006C187E
	[NullableContext(1)]
	public LevelBuffSetWalkableFloorAngle(Entity entity, long buffId, string[] @params, float param1, float param2) : base(entity, buffId, @params, param1, param2)
	{
	}

	// Token: 0x06019DF9 RID: 105977 RVA: 0x006C3690 File Offset: 0x006C1890
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

	// Token: 0x06019DFA RID: 105978 RVA: 0x006C3704 File Offset: 0x006C1904
	public override void OnRemoved(bool bPremature)
	{
		this.Entity.GetComponent<CharacterMoveComponent>().CharacterMovement.SetWalkableFloorAngle(this.OriginalWalkableFloorAngle);
	}

	// Token: 0x0400C39C RID: 50076
	private float OriginalWalkableFloorAngle;
}
