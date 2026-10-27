using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D26 RID: 3366
	public struct HeadIcon : IFlatbufferObject
	{
		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06007E35 RID: 32309 RVA: 0x002536C9 File Offset: 0x002518C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x002536D6 File Offset: 0x002518D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x002536E0 File Offset: 0x002518E0
		public static HeadIcon GetRootAsHeadIcon(ByteBuffer _bb)
		{
			return HeadIcon.GetRootAsHeadIcon(_bb, default(HeadIcon));
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x002536FC File Offset: 0x002518FC
		public static HeadIcon GetRootAsHeadIcon(ByteBuffer _bb, HeadIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x00253719 File Offset: 0x00251919
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x00253728 File Offset: 0x00251928
		public HeadIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x00253738 File Offset: 0x00251938
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

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06007E3C RID: 32316 RVA: 0x00253774 File Offset: 0x00251974
		public string IconPath
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

		// Token: 0x06007E3D RID: 32317 RVA: 0x002537AB File Offset: 0x002519AB
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x002537BA File Offset: 0x002519BA
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007E3F RID: 32319 RVA: 0x002537D4 File Offset: 0x002519D4
		public string BigIconPath
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

		// Token: 0x06007E40 RID: 32320 RVA: 0x0025380B File Offset: 0x00251A0B
		public Span<byte> GetBigIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x0025381A File Offset: 0x00251A1A
		public byte[] GetBigIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D9E RID: 19870
		private Table __p;
	}
}
