using System;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02003457 RID: 13399
	public class ClientEntityInfo
	{
		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x060222E1 RID: 140001 RVA: 0x009AE3D1 File Offset: 0x009AC5D1
		public bool IsStreaming
		{
			get
			{
				return this.HasFlag(EClientEntityFlag.Streaming);
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x060222E2 RID: 140002 RVA: 0x009AE3DA File Offset: 0x009AC5DA
		public bool IsClientEntity
		{
			get
			{
				return this.HasFlag(EClientEntityFlag.ClientEntity);
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x060222E3 RID: 140003 RVA: 0x009AE3E3 File Offset: 0x009AC5E3
		public bool IsServerEntity
		{
			get
			{
				return this.HasFlag(EClientEntityFlag.ServerEntity);
			}
		}

		// Token: 0x060222E4 RID: 140004 RVA: 0x009AE3EC File Offset: 0x009AC5EC
		public void SetCreatureDataId(long creatureDataId)
		{
			this.CreatureDataId = creatureDataId;
			if (this.CreatureDataId != 0L)
			{
				this.UpdateFlag(EClientEntityFlag.SetCreatureDataId, false);
				return;
			}
			this.RemoveFlag(EClientEntityFlag.SetCreatureDataId);
		}

		// Token: 0x060222E5 RID: 140005 RVA: 0x009AE40D File Offset: 0x009AC60D
		public void SetEntityId(int entityId)
		{
			this.EntityId = entityId;
		}

		// Token: 0x060222E6 RID: 140006 RVA: 0x009AE416 File Offset: 0x009AC616
		public void UpdateFlag(EClientEntityFlag flag, bool replace = false)
		{
			if (replace)
			{
				this.ClientEntityFlag = flag;
				return;
			}
			this.ClientEntityFlag |= flag;
		}

		// Token: 0x060222E7 RID: 140007 RVA: 0x009AE431 File Offset: 0x009AC631
		public void RemoveFlag(EClientEntityFlag flag)
		{
			this.ClientEntityFlag &= ~flag;
		}

		// Token: 0x060222E8 RID: 140008 RVA: 0x009AE442 File Offset: 0x009AC642
		public bool HasFlag(EClientEntityFlag flag)
		{
			return (this.ClientEntityFlag & flag) > EClientEntityFlag.None;
		}

		// Token: 0x04012D01 RID: 77057
		public EClientEntityFlag ClientEntityFlag;

		// Token: 0x04012D02 RID: 77058
		public long CreatureDataId;

		// Token: 0x04012D03 RID: 77059
		public int PbDataId;

		// Token: 0x04012D04 RID: 77060
		public int EntityId;
	}
}
