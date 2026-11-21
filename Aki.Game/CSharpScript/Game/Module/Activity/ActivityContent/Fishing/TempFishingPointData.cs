using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005521 RID: 21793
	public class TempFishingPointData
	{
		// Token: 0x06036099 RID: 221337 RVA: 0x00F15FA7 File Offset: 0x00F141A7
		[NullableContext(1)]
		public void Refresh(TempFishPointInfo data)
		{
			this.Id = data.ConfigId;
			this.CreatureDataId = data.EntityId;
			this.GamePlayId = data.GamePlayId;
			this.CurrentCount = data.CurCount;
			this.MaxCount = data.MaxCount;
		}

		// Token: 0x0401C896 RID: 116886
		public int Id;

		// Token: 0x0401C897 RID: 116887
		public long CreatureDataId;

		// Token: 0x0401C898 RID: 116888
		public int GamePlayId;

		// Token: 0x0401C899 RID: 116889
		public int SceneId;

		// Token: 0x0401C89A RID: 116890
		public int CurrentCount;

		// Token: 0x0401C89B RID: 116891
		public int MaxCount;
	}
}
