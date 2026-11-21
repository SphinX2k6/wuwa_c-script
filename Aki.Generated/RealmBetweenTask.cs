using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001084 RID: 4228
	public struct RealmBetweenTask : IFlatbufferObject
	{
		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x002F4DB8 File Offset: 0x002F2FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x002F4DC5 File Offset: 0x002F2FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x002F4DCC File Offset: 0x002F2FCC
		public static RealmBetweenTask GetRootAsRealmBetweenTask(ByteBuffer _bb)
		{
			return RealmBetweenTask.GetRootAsRealmBetweenTask(_bb, default(RealmBetweenTask));
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x002F4DE8 File Offset: 0x002F2FE8
		public static RealmBetweenTask GetRootAsRealmBetweenTask(ByteBuffer _bb, RealmBetweenTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x002F4E05 File Offset: 0x002F3005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x002F4E14 File Offset: 0x002F3014
		public RealmBetweenTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600BFB8 RID: 49080 RVA: 0x002F4E24 File Offset: 0x002F3024
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

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600BFB9 RID: 49081 RVA: 0x002F4E60 File Offset: 0x002F3060
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

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600BFBA RID: 49082 RVA: 0x002F4E9C File Offset: 0x002F309C
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

		// Token: 0x0600BFBB RID: 49083 RVA: 0x002F4ED3 File Offset: 0x002F30D3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x002F4EE2 File Offset: 0x002F30E2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0600BFBD RID: 49085 RVA: 0x002F4EFC File Offset: 0x002F30FC
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

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0600BFBE RID: 49086 RVA: 0x002F4F3C File Offset: 0x002F313C
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

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600BFBF RID: 49087 RVA: 0x002F4F7C File Offset: 0x002F317C
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

		// Token: 0x04005654 RID: 22100
		private Table __p;
	}
}
