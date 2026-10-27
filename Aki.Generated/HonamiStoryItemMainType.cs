using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D39 RID: 3385
	public struct HonamiStoryItemMainType : IFlatbufferObject
	{
		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007FD2 RID: 32722 RVA: 0x00257398 File Offset: 0x00255598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x002573A5 File Offset: 0x002555A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x002573AC File Offset: 0x002555AC
		public static HonamiStoryItemMainType GetRootAsHonamiStoryItemMainType(ByteBuffer _bb)
		{
			return HonamiStoryItemMainType.GetRootAsHonamiStoryItemMainType(_bb, default(HonamiStoryItemMainType));
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x002573C8 File Offset: 0x002555C8
		public static HonamiStoryItemMainType GetRootAsHonamiStoryItemMainType(ByteBuffer _bb, HonamiStoryItemMainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x002573E5 File Offset: 0x002555E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x002573F4 File Offset: 0x002555F4
		public HonamiStoryItemMainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x00257404 File Offset: 0x00255604
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

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x00257440 File Offset: 0x00255640
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

		// Token: 0x06007FDA RID: 32730 RVA: 0x00257477 File Offset: 0x00255677
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00257486 File Offset: 0x00255686
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB3 RID: 19891
		private Table __p;
	}
}
