using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060DA RID: 24794
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeChooseData
	{
		// Token: 0x0603EAEF RID: 256751 RVA: 0x00F23B30 File Offset: 0x00F21D30
		public RoverlikeChooseData(RoverRogueChooseData proto)
		{
			this.BindId = proto.BindId;
			this.Type = proto.Type;
			this.Layer = proto.Layer;
			this.IsSelect = proto.IsSelect;
			this.MaxTime = proto.MaxTime;
			this.UseTime = proto.UseTime;
			this.RefreshCost = proto.RefreshCost;
			this.Entries = new List<RoverlikeGainEntry>();
			if (proto.Entries != null)
			{
				foreach (RoverRogueGainEntry proto2 in proto.Entries)
				{
					this.Entries.Add(new RoverlikeGainEntry(proto2));
				}
			}
		}

		// Token: 0x0603EAF0 RID: 256752 RVA: 0x00F23C00 File Offset: 0x00F21E00
		public bool EnableRefresh()
		{
			return this.MaxTime > 0;
		}

		// Token: 0x0603EAF1 RID: 256753 RVA: 0x00F23C0B File Offset: 0x00F21E0B
		public bool HasRefreshTime()
		{
			return this.UseTime < this.MaxTime;
		}

		// Token: 0x0603EAF2 RID: 256754 RVA: 0x00F23C1B File Offset: 0x00F21E1B
		public bool HasRefreshCost()
		{
			return RoverlikeModel.Instance.Gold >= this.RefreshCost;
		}

		// Token: 0x0603EAF3 RID: 256755 RVA: 0x00F23C32 File Offset: 0x00F21E32
		public bool CanRefresh()
		{
			return this.EnableRefresh() && this.UseTime < this.MaxTime && RoverlikeModel.Instance.Gold >= this.RefreshCost;
		}

		// Token: 0x04020C44 RID: 134212
		public int BindId;

		// Token: 0x04020C45 RID: 134213
		public int SubViewIncId;

		// Token: 0x04020C46 RID: 134214
		public RoverRogueGainOperateType Type;

		// Token: 0x04020C47 RID: 134215
		public int Layer;

		// Token: 0x04020C48 RID: 134216
		public bool IsSelect;

		// Token: 0x04020C49 RID: 134217
		public int MaxTime;

		// Token: 0x04020C4A RID: 134218
		public int UseTime;

		// Token: 0x04020C4B RID: 134219
		public int RefreshCost;

		// Token: 0x04020C4C RID: 134220
		public List<RoverlikeGainEntry> Entries = new List<RoverlikeGainEntry>();
	}
}
