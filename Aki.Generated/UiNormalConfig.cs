using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001184 RID: 4484
	public struct UiNormalConfig : IFlatbufferObject
	{
		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600E642 RID: 58946 RVA: 0x0033EB60 File Offset: 0x0033CD60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x0033EB6D File Offset: 0x0033CD6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x0033EB74 File Offset: 0x0033CD74
		public static UiNormalConfig GetRootAsUiNormalConfig(ByteBuffer _bb)
		{
			return UiNormalConfig.GetRootAsUiNormalConfig(_bb, default(UiNormalConfig));
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x0033EB90 File Offset: 0x0033CD90
		public static UiNormalConfig GetRootAsUiNormalConfig(ByteBuffer _bb, UiNormalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x0033EBAD File Offset: 0x0033CDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x0033EBBC File Offset: 0x0033CDBC
		public UiNormalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600E648 RID: 58952 RVA: 0x0033EBCC File Offset: 0x0033CDCC
		public string ViewName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x0033EC03 File Offset: 0x0033CE03
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x0033EC12 File Offset: 0x0033CE12
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600E64B RID: 58955 RVA: 0x0033EC2C File Offset: 0x0033CE2C
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052CD RID: 21197
		private Table __p;
	}
}
