using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114D RID: 4429
	public struct TrackMoonTargetType : IFlatbufferObject
	{
		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600E117 RID: 57623 RVA: 0x0033302D File Offset: 0x0033122D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x0033303A File Offset: 0x0033123A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x00333044 File Offset: 0x00331244
		public static TrackMoonTargetType GetRootAsTrackMoonTargetType(ByteBuffer _bb)
		{
			return TrackMoonTargetType.GetRootAsTrackMoonTargetType(_bb, default(TrackMoonTargetType));
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x00333060 File Offset: 0x00331260
		public static TrackMoonTargetType GetRootAsTrackMoonTargetType(ByteBuffer _bb, TrackMoonTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x0033307D File Offset: 0x0033127D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x0033308C File Offset: 0x0033128C
		public TrackMoonTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600E11D RID: 57629 RVA: 0x0033309C File Offset: 0x0033129C
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

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600E11E RID: 57630 RVA: 0x003330D8 File Offset: 0x003312D8
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

		// Token: 0x0600E11F RID: 57631 RVA: 0x0033310F File Offset: 0x0033130F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E120 RID: 57632 RVA: 0x0033311E File Offset: 0x0033131E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005292 RID: 21138
		private Table __p;
	}
}
