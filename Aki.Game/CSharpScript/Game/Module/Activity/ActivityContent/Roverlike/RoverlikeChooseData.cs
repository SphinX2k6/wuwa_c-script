using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005058 RID: 20568
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeChooseData
	{
		// Token: 0x060337B3 RID: 210867 RVA: 0x00E6A920 File Offset: 0x00E68B20
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

		// Token: 0x060337B4 RID: 210868 RVA: 0x00E6A9F0 File Offset: 0x00E68BF0
		public bool EnableRefresh()
		{
			return this.MaxTime > 0;
		}

		// Token: 0x060337B5 RID: 210869 RVA: 0x00E6A9FB File Offset: 0x00E68BFB
		public bool HasRefreshTime()
		{
			return this.UseTime < this.MaxTime;
		}

		// Token: 0x060337B6 RID: 210870 RVA: 0x00E6AA0B File Offset: 0x00E68C0B
		public bool HasRefreshCost()
		{
			return RoverlikeModel.Instance.Gold >= this.RefreshCost;
		}

		// Token: 0x060337B7 RID: 210871 RVA: 0x00E6AA22 File Offset: 0x00E68C22
		public bool CanRefresh()
		{
			return this.EnableRefresh() && this.UseTime < this.MaxTime && RoverlikeModel.Instance.Gold >= this.RefreshCost;
		}

		// Token: 0x0401B571 RID: 111985
		public int BindId;

		// Token: 0x0401B572 RID: 111986
		public int SubViewIncId;

		// Token: 0x0401B573 RID: 111987
		public RoverRogueGainOperateType Type;

		// Token: 0x0401B574 RID: 111988
		public int Layer;

		// Token: 0x0401B575 RID: 111989
		public bool IsSelect;

		// Token: 0x0401B576 RID: 111990
		public int MaxTime;

		// Token: 0x0401B577 RID: 111991
		public int UseTime;

		// Token: 0x0401B578 RID: 111992
		public int RefreshCost;

		// Token: 0x0401B579 RID: 111993
		public List<RoverlikeGainEntry> Entries = new List<RoverlikeGainEntry>();
	}
}
