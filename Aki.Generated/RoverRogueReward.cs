using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001082 RID: 4226
	public struct RoverRogueReward : IFlatbufferObject
	{
		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600CEA3 RID: 52899 RVA: 0x00307E38 File Offset: 0x00306038
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x00307E45 File Offset: 0x00306045
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x00307E4C File Offset: 0x0030604C
		public static RoverRogueReward GetRootAsRoverRogueReward(ByteBuffer _bb)
		{
			return RoverRogueReward.GetRootAsRoverRogueReward(_bb, default(RoverRogueReward));
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x00307E68 File Offset: 0x00306068
		public static RoverRogueReward GetRootAsRoverRogueReward(ByteBuffer _bb, RoverRogueReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x00307E85 File Offset: 0x00306085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x00307E94 File Offset: 0x00306094
		public RoverRogueReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600CEA9 RID: 52905 RVA: 0x00307EA4 File Offset: 0x003060A4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x00307EE0 File Offset: 0x003060E0
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x00307F1C File Offset: 0x0030611C
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600CEAC RID: 52908 RVA: 0x00307F58 File Offset: 0x00306158
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x00307F90 File Offset: 0x00306190
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x00307FA0 File Offset: 0x003061A0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600CEAF RID: 52911 RVA: 0x00307FB8 File Offset: 0x003061B8
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400518D RID: 20877
		private Table __p;
	}
}
