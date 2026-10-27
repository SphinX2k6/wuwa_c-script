using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC3 RID: 4035
	public struct RhythmShipAction : IFlatbufferObject
	{
		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x002DF515 File Offset: 0x002DD715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x002DF522 File Offset: 0x002DD722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x002DF52C File Offset: 0x002DD72C
		public static RhythmShipAction GetRootAsRhythmShipAction(ByteBuffer _bb)
		{
			return RhythmShipAction.GetRootAsRhythmShipAction(_bb, default(RhythmShipAction));
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x002DF548 File Offset: 0x002DD748
		public static RhythmShipAction GetRootAsRhythmShipAction(ByteBuffer _bb, RhythmShipAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x002DF565 File Offset: 0x002DD765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x002DF574 File Offset: 0x002DD774
		public RhythmShipAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x002DF584 File Offset: 0x002DD784
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

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600BC96 RID: 48278 RVA: 0x002DF5C0 File Offset: 0x002DD7C0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BC97 RID: 48279 RVA: 0x002DF5F7 File Offset: 0x002DD7F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x002DF606 File Offset: 0x002DD806
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x002DF620 File Offset: 0x002DD820
		public string Icon
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

		// Token: 0x0600BC9A RID: 48282 RVA: 0x002DF657 File Offset: 0x002DD857
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x002DF666 File Offset: 0x002DD866
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400509D RID: 20637
		private Table __p;
	}
}
