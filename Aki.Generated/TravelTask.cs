using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012A9 RID: 4777
	public struct TravelTask : IFlatbufferObject
	{
		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0600F27A RID: 62074 RVA: 0x00366C28 File Offset: 0x00364E28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x00366C35 File Offset: 0x00364E35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F27C RID: 62076 RVA: 0x00366C3C File Offset: 0x00364E3C
		public static TravelTask GetRootAsTravelTask(ByteBuffer _bb)
		{
			return TravelTask.GetRootAsTravelTask(_bb, default(TravelTask));
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x00366C58 File Offset: 0x00364E58
		public static TravelTask GetRootAsTravelTask(ByteBuffer _bb, TravelTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x00366C75 File Offset: 0x00364E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F27F RID: 62079 RVA: 0x00366C84 File Offset: 0x00364E84
		public TravelTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x0600F280 RID: 62080 RVA: 0x00366C94 File Offset: 0x00364E94
		public int TaskId
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

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x0600F281 RID: 62081 RVA: 0x00366CD0 File Offset: 0x00364ED0
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

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0600F282 RID: 62082 RVA: 0x00366D0C File Offset: 0x00364F0C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F283 RID: 62083 RVA: 0x00366D43 File Offset: 0x00364F43
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F284 RID: 62084 RVA: 0x00366D52 File Offset: 0x00364F52
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x0600F285 RID: 62085 RVA: 0x00366D6C File Offset: 0x00364F6C
		public int TaskReward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x0600F286 RID: 62086 RVA: 0x00366DAC File Offset: 0x00364FAC
		public int AreaId
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

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x0600F287 RID: 62087 RVA: 0x00366DEC File Offset: 0x00364FEC
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040058FC RID: 22780
		private Table __p;
	}
}
