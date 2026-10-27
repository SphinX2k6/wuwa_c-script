using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B15 RID: 2837
	public struct AvignonTask : IFlatbufferObject
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x001DAE11 File Offset: 0x001D9011
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001DAE1E File Offset: 0x001D901E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x001DAE28 File Offset: 0x001D9028
		public static AvignonTask GetRootAsAvignonTask(ByteBuffer _bb)
		{
			return AvignonTask.GetRootAsAvignonTask(_bb, default(AvignonTask));
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x001DAE44 File Offset: 0x001D9044
		public static AvignonTask GetRootAsAvignonTask(ByteBuffer _bb, AvignonTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001DAE61 File Offset: 0x001D9061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x001DAE70 File Offset: 0x001D9070
		public AvignonTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x001DAE80 File Offset: 0x001D9080
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x001DAEBC File Offset: 0x001D90BC
		public int Step
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x001DAEF8 File Offset: 0x001D90F8
		public string TaskName
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

		// Token: 0x06004A00 RID: 18944 RVA: 0x001DAF2F File Offset: 0x001D912F
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x001DAF3E File Offset: 0x001D913E
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06004A02 RID: 18946 RVA: 0x001DAF58 File Offset: 0x001D9158
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x001DAF98 File Offset: 0x001D9198
		public int JumpId
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

		// Token: 0x04004AFD RID: 19197
		private Table __p;
	}
}
