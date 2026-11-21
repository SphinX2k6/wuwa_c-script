using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE8 RID: 4072
	public struct PhonographMusic : IFlatbufferObject
	{
		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600B128 RID: 45352 RVA: 0x002D5874 File Offset: 0x002D3A74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x002D5881 File Offset: 0x002D3A81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x002D5888 File Offset: 0x002D3A88
		public static PhonographMusic GetRootAsPhonographMusic(ByteBuffer _bb)
		{
			return PhonographMusic.GetRootAsPhonographMusic(_bb, default(PhonographMusic));
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x002D58A4 File Offset: 0x002D3AA4
		public static PhonographMusic GetRootAsPhonographMusic(ByteBuffer _bb, PhonographMusic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x002D58C1 File Offset: 0x002D3AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x002D58D0 File Offset: 0x002D3AD0
		public PhonographMusic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600B12E RID: 45358 RVA: 0x002D58E0 File Offset: 0x002D3AE0
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

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600B12F RID: 45359 RVA: 0x002D591C File Offset: 0x002D3B1C
		public int ItemId
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

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600B130 RID: 45360 RVA: 0x002D5958 File Offset: 0x002D3B58
		public string MusicEvent
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

		// Token: 0x0600B131 RID: 45361 RVA: 0x002D598F File Offset: 0x002D3B8F
		public Span<byte> GetMusicEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x002D599E File Offset: 0x002D3B9E
		public byte[] GetMusicEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x002D59B8 File Offset: 0x002D3BB8
		public int Album(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600B134 RID: 45364 RVA: 0x002D59F8 File Offset: 0x002D3BF8
		public int AlbumLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x002D5A24 File Offset: 0x002D3C24
		public Span<int> GetAlbumBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x002D5A34 File Offset: 0x002D3C34
		public int[] GetAlbumArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600B137 RID: 45367 RVA: 0x002D5A4C File Offset: 0x002D3C4C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600B138 RID: 45368 RVA: 0x002D5A8C File Offset: 0x002D3C8C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x002D5AC4 File Offset: 0x002D3CC4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x002D5AD4 File Offset: 0x002D3CD4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x002D5AEC File Offset: 0x002D3CEC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x002D5B24 File Offset: 0x002D3D24
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x002D5B34 File Offset: 0x002D3D34
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600B13E RID: 45374 RVA: 0x002D5B4C File Offset: 0x002D3D4C
		public string UnlockConditionText
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x002D5B84 File Offset: 0x002D3D84
		public Span<byte> GetUnlockConditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x002D5B94 File Offset: 0x002D3D94
		public byte[] GetUnlockConditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x002D5BAC File Offset: 0x002D3DAC
		[NullableContext(1)]
		public int[] Album()
		{
			return this.GetAlbumArray();
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x002D5BB4 File Offset: 0x002D3DB4
		[NullableContext(1)]
		public IEnumerable<int> AlbumIter()
		{
			PhonographMusic.<AlbumIter>d__36 <AlbumIter>d__ = new PhonographMusic.<AlbumIter>d__36(-2);
			<AlbumIter>d__.<>3__<>4__this = this;
			return <AlbumIter>d__;
		}

		// Token: 0x040055B0 RID: 21936
		private Table __p;
	}
}
