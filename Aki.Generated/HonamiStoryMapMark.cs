using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E23 RID: 3619
	public struct HonamiStoryMapMark : IFlatbufferObject
	{
		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x00276C68 File Offset: 0x00274E68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x00276C75 File Offset: 0x00274E75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00276C7C File Offset: 0x00274E7C
		public static HonamiStoryMapMark GetRootAsHonamiStoryMapMark(ByteBuffer _bb)
		{
			return HonamiStoryMapMark.GetRootAsHonamiStoryMapMark(_bb, default(HonamiStoryMapMark));
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00276C98 File Offset: 0x00274E98
		public static HonamiStoryMapMark GetRootAsHonamiStoryMapMark(ByteBuffer _bb, HonamiStoryMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00276CB5 File Offset: 0x00274EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00276CC4 File Offset: 0x00274EC4
		public HonamiStoryMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06008673 RID: 34419 RVA: 0x00276CD4 File Offset: 0x00274ED4
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

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06008674 RID: 34420 RVA: 0x00276D10 File Offset: 0x00274F10
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

		// Token: 0x06008675 RID: 34421 RVA: 0x00276D47 File Offset: 0x00274F47
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00276D56 File Offset: 0x00274F56
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06008677 RID: 34423 RVA: 0x00276D70 File Offset: 0x00274F70
		public string Description
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

		// Token: 0x06008678 RID: 34424 RVA: 0x00276DA7 File Offset: 0x00274FA7
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x00276DB6 File Offset: 0x00274FB6
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x0600867A RID: 34426 RVA: 0x00276DD0 File Offset: 0x00274FD0
		public string IconResourceId
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

		// Token: 0x0600867B RID: 34427 RVA: 0x00276E08 File Offset: 0x00275008
		public Span<byte> GetIconResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00276E18 File Offset: 0x00275018
		public byte[] GetIconResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600867D RID: 34429 RVA: 0x00276E30 File Offset: 0x00275030
		public string MarkIconResourceId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x00276E68 File Offset: 0x00275068
		public Span<byte> GetMarkIconResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x00276E78 File Offset: 0x00275078
		public byte[] GetMarkIconResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400539E RID: 21406
		private Table __p;
	}
}
