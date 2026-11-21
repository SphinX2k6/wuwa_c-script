using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AB RID: 4267
	public struct RhythmShipAction : IFlatbufferObject
	{
		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600C2D9 RID: 49881 RVA: 0x002FBBB6 File Offset: 0x002F9DB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x002FBBC3 File Offset: 0x002F9DC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x002FBBCC File Offset: 0x002F9DCC
		public static RhythmShipAction GetRootAsRhythmShipAction(ByteBuffer _bb)
		{
			return RhythmShipAction.GetRootAsRhythmShipAction(_bb, default(RhythmShipAction));
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x002FBBE8 File Offset: 0x002F9DE8
		public static RhythmShipAction GetRootAsRhythmShipAction(ByteBuffer _bb, RhythmShipAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x002FBC05 File Offset: 0x002F9E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x002FBC14 File Offset: 0x002F9E14
		public RhythmShipAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600C2DF RID: 49887 RVA: 0x002FBC24 File Offset: 0x002F9E24
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

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600C2E0 RID: 49888 RVA: 0x002FBC60 File Offset: 0x002F9E60
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

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x002FBC97 File Offset: 0x002F9E97
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C2E2 RID: 49890 RVA: 0x002FBCA6 File Offset: 0x002F9EA6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600C2E3 RID: 49891 RVA: 0x002FBCC0 File Offset: 0x002F9EC0
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

		// Token: 0x0600C2E4 RID: 49892 RVA: 0x002FBCF7 File Offset: 0x002F9EF7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x002FBD06 File Offset: 0x002F9F06
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005685 RID: 22149
		private Table __p;
	}
}
