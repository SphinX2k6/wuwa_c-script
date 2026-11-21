using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001283 RID: 4739
	public struct TrackMoonTargetType : IFlatbufferObject
	{
		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600EE85 RID: 61061 RVA: 0x0035E419 File Offset: 0x0035C619
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE86 RID: 61062 RVA: 0x0035E426 File Offset: 0x0035C626
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x0035E430 File Offset: 0x0035C630
		public static TrackMoonTargetType GetRootAsTrackMoonTargetType(ByteBuffer _bb)
		{
			return TrackMoonTargetType.GetRootAsTrackMoonTargetType(_bb, default(TrackMoonTargetType));
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x0035E44C File Offset: 0x0035C64C
		public static TrackMoonTargetType GetRootAsTrackMoonTargetType(ByteBuffer _bb, TrackMoonTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE89 RID: 61065 RVA: 0x0035E469 File Offset: 0x0035C669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE8A RID: 61066 RVA: 0x0035E478 File Offset: 0x0035C678
		public TrackMoonTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x0035E488 File Offset: 0x0035C688
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

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600EE8C RID: 61068 RVA: 0x0035E4C4 File Offset: 0x0035C6C4
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

		// Token: 0x0600EE8D RID: 61069 RVA: 0x0035E4FB File Offset: 0x0035C6FB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EE8E RID: 61070 RVA: 0x0035E50A File Offset: 0x0035C70A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058D5 RID: 22741
		private Table __p;
	}
}
