using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200638C RID: 25484
	[NullableContext(1)]
	[Nullable(0)]
	public class MovementStateConfig
	{
		// Token: 0x0603DC18 RID: 252952 RVA: 0x011E7CD0 File Offset: 0x011E5ED0
		public void SetConfig(SFloatingMovementState movementStateConfig)
		{
			this.Mode = movementStateConfig.Mode;
			this.MovementTagList.Clear();
			int num = movementStateConfig.MovementTagList.GameplayTags.Num();
			for (int i = 0; i < num; i++)
			{
				this.MovementTagList.Add(movementStateConfig.MovementTagList.GameplayTags.Get(i).TagId());
			}
			this.BannedMovementTagList.Clear();
			int num2 = movementStateConfig.BannedMovementTagList.GameplayTags.Num();
			for (int j = 0; j < num2; j++)
			{
				this.BannedMovementTagList.Add(movementStateConfig.BannedMovementTagList.GameplayTags.Get(j).TagId());
			}
			this.MoveTagList.Clear();
			int num3 = movementStateConfig.MoveTagList.GameplayTags.Num();
			for (int k = 0; k < num3; k++)
			{
				this.MoveTagList.Add(movementStateConfig.MoveTagList.GameplayTags.Get(k).TagId());
			}
			this.StandTagList.Clear();
			int num4 = movementStateConfig.StandTagList.GameplayTags.Num();
			for (int l = 0; l < num4; l++)
			{
				this.StandTagList.Add(movementStateConfig.StandTagList.GameplayTags.Get(l).TagId());
			}
		}

		// Token: 0x04020C35 RID: 134197
		public EFloatingMovementType Mode;

		// Token: 0x04020C36 RID: 134198
		public List<int> MovementTagList = new List<int>();

		// Token: 0x04020C37 RID: 134199
		public List<int> BannedMovementTagList = new List<int>();

		// Token: 0x04020C38 RID: 134200
		public List<int> MoveTagList = new List<int>();

		// Token: 0x04020C39 RID: 134201
		public List<int> StandTagList = new List<int>();
	}
}
