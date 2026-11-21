using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5F RID: 3935
	public struct MusicGameData : IFlatbufferObject
	{
		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x002B8765 File Offset: 0x002B6965
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x002B8772 File Offset: 0x002B6972
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x002B877C File Offset: 0x002B697C
		public static MusicGameData GetRootAsMusicGameData(ByteBuffer _bb)
		{
			return MusicGameData.GetRootAsMusicGameData(_bb, default(MusicGameData));
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x002B8798 File Offset: 0x002B6998
		public static MusicGameData GetRootAsMusicGameData(ByteBuffer _bb, MusicGameData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x002B87B5 File Offset: 0x002B69B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x002B87C4 File Offset: 0x002B69C4
		public MusicGameData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x002B87D4 File Offset: 0x002B69D4
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

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600A406 RID: 41990 RVA: 0x002B8810 File Offset: 0x002B6A10
		public float BgmOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x002B8850 File Offset: 0x002B6A50
		public string Data
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

		// Token: 0x0600A408 RID: 41992 RVA: 0x002B8887 File Offset: 0x002B6A87
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x002B8896 File Offset: 0x002B6A96
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400550D RID: 21773
		private Table __p;
	}
}
