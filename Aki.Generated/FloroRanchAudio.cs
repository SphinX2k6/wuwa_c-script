using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D84 RID: 3460
	public struct FloroRanchAudio : IFlatbufferObject
	{
		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x00257BD9 File Offset: 0x00255DD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x00257BE6 File Offset: 0x00255DE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00257BF0 File Offset: 0x00255DF0
		public static FloroRanchAudio GetRootAsFloroRanchAudio(ByteBuffer _bb)
		{
			return FloroRanchAudio.GetRootAsFloroRanchAudio(_bb, default(FloroRanchAudio));
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x00257C0C File Offset: 0x00255E0C
		public static FloroRanchAudio GetRootAsFloroRanchAudio(ByteBuffer _bb, FloroRanchAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x00257C29 File Offset: 0x00255E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x00257C38 File Offset: 0x00255E38
		public FloroRanchAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x00257C48 File Offset: 0x00255E48
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

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06007875 RID: 30837 RVA: 0x00257C84 File Offset: 0x00255E84
		public int CharacterType
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

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x00257CC0 File Offset: 0x00255EC0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x00257CFC File Offset: 0x00255EFC
		public string Text
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

		// Token: 0x06007878 RID: 30840 RVA: 0x00257D34 File Offset: 0x00255F34
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00257D44 File Offset: 0x00255F44
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x00257D5C File Offset: 0x00255F5C
		public string AudioEvent
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

		// Token: 0x0600787B RID: 30843 RVA: 0x00257D94 File Offset: 0x00255F94
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00257DA4 File Offset: 0x00255FA4
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052E2 RID: 21218
		private Table __p;
	}
}
