using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060DB RID: 24795
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeGainEntry
	{
		// Token: 0x17009129 RID: 37161
		// (get) Token: 0x0603EAF4 RID: 256756 RVA: 0x00F23C63 File Offset: 0x00F21E63
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

		// Token: 0x0603EAF5 RID: 256757 RVA: 0x00F23C76 File Offset: 0x00F21E76
		public RoverlikeGainEntry()
		{
		}

		// Token: 0x0603EAF6 RID: 256758 RVA: 0x00F23C7E File Offset: 0x00F21E7E
		public RoverlikeGainEntry(RoverRogueGainEntry proto)
		{
			this.Type = proto.Type;
			this.ConfigId = proto.ConfigId;
			this.IncId = proto.IncId;
			this.ItemRemainingRoomsInternal = proto.ItemRemainingRooms;
		}

		// Token: 0x0603EAF7 RID: 256759 RVA: 0x00F23CB6 File Offset: 0x00F21EB6
		public static RoverlikeGainEntry Create(RoverRogueGainDataType type, int configId)
		{
			return new RoverlikeGainEntry
			{
				Type = type,
				ConfigId = configId
			};
		}

		// Token: 0x04020C4D RID: 134221
		public RoverRogueGainDataType Type;

		// Token: 0x04020C4E RID: 134222
		public int ConfigId;

		// Token: 0x04020C4F RID: 134223
		public int IncId;

		// Token: 0x04020C50 RID: 134224
		protected int ItemRemainingRoomsInternal;
	}
}
