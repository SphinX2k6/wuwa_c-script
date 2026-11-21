using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F1 RID: 4849
	public struct DicIntString : IFlatbufferObject
	{
		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x0600F78E RID: 63374 RVA: 0x0037249A File Offset: 0x0037069A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x003724A7 File Offset: 0x003706A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x003724B0 File Offset: 0x003706B0
		public static DicIntString GetRootAsDicIntString(ByteBuffer _bb)
		{
			return DicIntString.GetRootAsDicIntString(_bb, default(DicIntString));
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x003724CC File Offset: 0x003706CC
		public static DicIntString GetRootAsDicIntString(ByteBuffer _bb, DicIntString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x003724E9 File Offset: 0x003706E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x003724F8 File Offset: 0x003706F8
		public DicIntString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0600F794 RID: 63380 RVA: 0x00372508 File Offset: 0x00370708
		public int Key
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

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0600F795 RID: 63381 RVA: 0x00372544 File Offset: 0x00370744
		public string Value
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

		// Token: 0x0600F796 RID: 63382 RVA: 0x0037257B File Offset: 0x0037077B
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F797 RID: 63383 RVA: 0x0037258A File Offset: 0x0037078A
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400594F RID: 22863
		private Table __p;
	}
}
