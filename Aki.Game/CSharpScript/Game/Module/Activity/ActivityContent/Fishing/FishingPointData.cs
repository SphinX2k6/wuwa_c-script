using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005520 RID: 21792
	public class FishingPointData
	{
		// Token: 0x06036096 RID: 221334 RVA: 0x00F15EFC File Offset: 0x00F140FC
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

		// Token: 0x06036097 RID: 221335 RVA: 0x00F15F87 File Offset: 0x00F14187
		public bool IsValid()
		{
			return (double)this.NextUpdateTime >= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x0401C88D RID: 116877
		public int Id;

		// Token: 0x0401C88E RID: 116878
		public int PbEntityId;

		// Token: 0x0401C88F RID: 116879
		public int SceneId;

		// Token: 0x0401C890 RID: 116880
		public int GamePlayId;

		// Token: 0x0401C891 RID: 116881
		public int CurrentCount;

		// Token: 0x0401C892 RID: 116882
		public int MaxCount;

		// Token: 0x0401C893 RID: 116883
		public long LastUpdateTime;

		// Token: 0x0401C894 RID: 116884
		public long NextUpdateTime;

		// Token: 0x0401C895 RID: 116885
		public bool Interacted;
	}
}
