using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE9 RID: 3049
	public struct Audio : IFlatbufferObject
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x001F9A76 File Offset: 0x001F7C76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x001F9A83 File Offset: 0x001F7C83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x001F9A8C File Offset: 0x001F7C8C
		public static Audio GetRootAsAudio(ByteBuffer _bb)
		{
			return Audio.GetRootAsAudio(_bb, default(Audio));
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x001F9AA8 File Offset: 0x001F7CA8
		public static Audio GetRootAsAudio(ByteBuffer _bb, Audio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x001F9AC5 File Offset: 0x001F7CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x001F9AD4 File Offset: 0x001F7CD4
		public Audio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x001F9AE4 File Offset: 0x001F7CE4
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

		// Token: 0x06004EEC RID: 20204 RVA: 0x001F9B1B File Offset: 0x001F7D1B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x001F9B2A File Offset: 0x001F7D2A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x001F9B44 File Offset: 0x001F7D44
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

		// Token: 0x06004EEF RID: 20207 RVA: 0x001F9B7B File Offset: 0x001F7D7B
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x001F9B8A File Offset: 0x001F7D8A
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040050D1 RID: 20689
		private Table __p;
	}
}
