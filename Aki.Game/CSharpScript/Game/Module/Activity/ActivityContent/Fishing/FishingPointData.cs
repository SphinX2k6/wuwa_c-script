using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A2 RID: 26018
	public class FishingPointData
	{
		// Token: 0x060413D1 RID: 267217 RVA: 0x00FCEEF8 File Offset: 0x00FCD0F8
		[NullableContext(1)]
		public void Refresh(OneFishPointInfo data)
		{
			this.Id = data.Id;
			this.PbEntityId = data.EntityConfigId;
			this.GamePlayId = data.GamePlayId;
			this.CurrentCount = data.CurCount;
			if (this.CurrentCount == 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.FishingPointFinish, this.Id);
			}
			this.MaxCount = data.MaxCount;
			this.LastUpdateTime = data.LastUpdateTime;
			this.NextUpdateTime = data.NextUpdateTime;
			this.Interacted = data.Interacted;
		}

		// Token: 0x060413D2 RID: 267218 RVA: 0x00FCEF83 File Offset: 0x00FCD183
		public bool IsValid()
		{
			return (double)this.NextUpdateTime >= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x04021F5C RID: 139100
		public int Id;

		// Token: 0x04021F5D RID: 139101
		public int PbEntityId;

		// Token: 0x04021F5E RID: 139102
		public int SceneId;

		// Token: 0x04021F5F RID: 139103
		public int GamePlayId;

		// Token: 0x04021F60 RID: 139104
		public int CurrentCount;

		// Token: 0x04021F61 RID: 139105
		public int MaxCount;

		// Token: 0x04021F62 RID: 139106
		public long LastUpdateTime;

		// Token: 0x04021F63 RID: 139107
		public long NextUpdateTime;

		// Token: 0x04021F64 RID: 139108
		public bool Interacted;
	}
}
