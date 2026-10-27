using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114A RID: 4426
	public struct TrackMoonMemory : IFlatbufferObject
	{
		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x00332B28 File Offset: 0x00330D28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0F2 RID: 57586 RVA: 0x00332B35 File Offset: 0x00330D35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x00332B3C File Offset: 0x00330D3C
		public static TrackMoonMemory GetRootAsTrackMoonMemory(ByteBuffer _bb)
		{
			return TrackMoonMemory.GetRootAsTrackMoonMemory(_bb, default(TrackMoonMemory));
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x00332B58 File Offset: 0x00330D58
		public static TrackMoonMemory GetRootAsTrackMoonMemory(ByteBuffer _bb, TrackMoonMemory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x00332B75 File Offset: 0x00330D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0F6 RID: 57590 RVA: 0x00332B84 File Offset: 0x00330D84
		public TrackMoonMemory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600E0F7 RID: 57591 RVA: 0x00332B94 File Offset: 0x00330D94
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

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x00332BD0 File Offset: 0x00330DD0
		public int Classify
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

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600E0F9 RID: 57593 RVA: 0x00332C0C File Offset: 0x00330E0C
		public string Title
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

		// Token: 0x0600E0FA RID: 57594 RVA: 0x00332C43 File Offset: 0x00330E43
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E0FB RID: 57595 RVA: 0x00332C52 File Offset: 0x00330E52
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600E0FC RID: 57596 RVA: 0x00332C6C File Offset: 0x00330E6C
		public string IconPath
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

		// Token: 0x0600E0FD RID: 57597 RVA: 0x00332CA4 File Offset: 0x00330EA4
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x00332CB4 File Offset: 0x00330EB4
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0600E0FF RID: 57599 RVA: 0x00332CCC File Offset: 0x00330ECC
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400528F RID: 21135
		private Table __p;
	}
}
