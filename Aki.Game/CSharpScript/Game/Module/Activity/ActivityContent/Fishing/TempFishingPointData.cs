using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A3 RID: 26019
	public class TempFishingPointData
	{
		// Token: 0x060413D4 RID: 267220 RVA: 0x00FCEFA3 File Offset: 0x00FCD1A3
		[NullableContext(1)]
		public void Refresh(TempFishPointInfo data)
		{
			this.Id = data.ConfigId;
			this.CreatureDataId = data.EntityId;
			this.GamePlayId = data.GamePlayId;
			this.CurrentCount = data.CurCount;
			this.MaxCount = data.MaxCount;
		}

		// Token: 0x04021F65 RID: 139109
		public int Id;

		// Token: 0x04021F66 RID: 139110
		public long CreatureDataId;

		// Token: 0x04021F67 RID: 139111
		public int GamePlayId;

		// Token: 0x04021F68 RID: 139112
		public int SceneId;

		// Token: 0x04021F69 RID: 139113
		public int CurrentCount;

		// Token: 0x04021F6A RID: 139114
		public int MaxCount;
	}
}
