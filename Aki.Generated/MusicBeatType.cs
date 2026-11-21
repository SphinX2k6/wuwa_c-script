using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5E RID: 3934
	public struct MusicBeatType : IFlatbufferObject
	{
		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x0600A3EA RID: 41962 RVA: 0x002B8528 File Offset: 0x002B6728
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x002B8535 File Offset: 0x002B6735
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x002B853C File Offset: 0x002B673C
		public static MusicBeatType GetRootAsMusicBeatType(ByteBuffer _bb)
		{
			return MusicBeatType.GetRootAsMusicBeatType(_bb, default(MusicBeatType));
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x002B8558 File Offset: 0x002B6758
		public static MusicBeatType GetRootAsMusicBeatType(ByteBuffer _bb, MusicBeatType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x002B8575 File Offset: 0x002B6775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x002B8584 File Offset: 0x002B6784
		public MusicBeatType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x002B8594 File Offset: 0x002B6794
		public string BeatType
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

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x002B85CB File Offset: 0x002B67CB
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x002B85DA File Offset: 0x002B67DA
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x002B85F4 File Offset: 0x002B67F4
		public string MusicType
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

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x002B862B File Offset: 0x002B682B
		public Span<byte> GetMusicTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x002B863A File Offset: 0x002B683A
		public byte[] GetMusicTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600A3F6 RID: 41974 RVA: 0x002B8654 File Offset: 0x002B6854
		public string BeatConfigType
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

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x002B868B File Offset: 0x002B688B
		public Span<byte> GetBeatConfigTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x002B869A File Offset: 0x002B689A
		public byte[] GetBeatConfigTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x002B86B4 File Offset: 0x002B68B4
		public int BeatConfig(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600A3FA RID: 41978 RVA: 0x002B86F4 File Offset: 0x002B68F4
		public int BeatConfigLength
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

		// Token: 0x0600A3FB RID: 41979 RVA: 0x002B8720 File Offset: 0x002B6920
		public Span<int> GetBeatConfigBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x002B8730 File Offset: 0x002B6930
		public int[] GetBeatConfigArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x002B8748 File Offset: 0x002B6948
		[NullableContext(1)]
		public int[] BeatConfig()
		{
			return this.GetBeatConfigArray();
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x002B8750 File Offset: 0x002B6950
		[NullableContext(1)]
		public IEnumerable<int> BeatConfigIter()
		{
			MusicBeatType.<BeatConfigIter>d__26 <BeatConfigIter>d__ = new MusicBeatType.<BeatConfigIter>d__26(-2);
			<BeatConfigIter>d__.<>3__<>4__this = this;
			return <BeatConfigIter>d__;
		}

		// Token: 0x0400550C RID: 21772
		private Table __p;
	}
}
