using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0F RID: 2831
	public struct Audio : IFlatbufferObject
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600499E RID: 18846 RVA: 0x001DA341 File Offset: 0x001D8541
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x001DA34E File Offset: 0x001D854E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001DA358 File Offset: 0x001D8558
		public static Audio GetRootAsAudio(ByteBuffer _bb)
		{
			return Audio.GetRootAsAudio(_bb, default(Audio));
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x001DA374 File Offset: 0x001D8574
		public static Audio GetRootAsAudio(ByteBuffer _bb, Audio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x001DA391 File Offset: 0x001D8591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x001DA3A0 File Offset: 0x001D85A0
		public Audio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x001DA3B0 File Offset: 0x001D85B0
		public string Id
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

		// Token: 0x060049A5 RID: 18853 RVA: 0x001DA3E7 File Offset: 0x001D85E7
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x001DA3F6 File Offset: 0x001D85F6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x001DA410 File Offset: 0x001D8610
		public string Path
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

		// Token: 0x060049A8 RID: 18856 RVA: 0x001DA447 File Offset: 0x001D8647
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x001DA456 File Offset: 0x001D8656
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AF7 RID: 19191
		private Table __p;
	}
}
