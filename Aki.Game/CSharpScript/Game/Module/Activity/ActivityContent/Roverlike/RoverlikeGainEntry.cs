using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005059 RID: 20569
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGainEntry
	{
		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x060337B8 RID: 210872 RVA: 0x00E6AA53 File Offset: 0x00E68C53
		public int ItemRemainingRooms
		{
			get
			{
				if (this.Type == RoverRogueGainDataType.RoverRogueGainItem)
				{
					return this.ItemRemainingRoomsInternal;
				}
				return 0;
			}
		}

		// Token: 0x060337B9 RID: 210873 RVA: 0x00E6AA66 File Offset: 0x00E68C66
		public RoverlikeGainEntry()
		{
		}

		// Token: 0x060337BA RID: 210874 RVA: 0x00E6AA6E File Offset: 0x00E68C6E
		public RoverlikeGainEntry(RoverRogueGainEntry proto)
		{
			this.Type = proto.Type;
			this.ConfigId = proto.ConfigId;
			this.IncId = proto.IncId;
			this.ItemRemainingRoomsInternal = proto.ItemRemainingRooms;
		}

		// Token: 0x060337BB RID: 210875 RVA: 0x00E6AAA6 File Offset: 0x00E68CA6
		public static RoverlikeGainEntry Create(RoverRogueGainDataType type, int configId)
		{
			return new RoverlikeGainEntry
			{
				Type = type,
				ConfigId = configId
			};
		}

		// Token: 0x0401B57A RID: 111994
		public RoverRogueGainDataType Type;

		// Token: 0x0401B57B RID: 111995
		public int ConfigId;

		// Token: 0x0401B57C RID: 111996
		public int IncId;

		// Token: 0x0401B57D RID: 111997
		protected int ItemRemainingRoomsInternal;
	}
}
