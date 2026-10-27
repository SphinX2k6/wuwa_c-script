using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114C RID: 4428
	public struct TrackMoonTarget : IFlatbufferObject
	{
		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600E10A RID: 57610 RVA: 0x00332E69 File Offset: 0x00331069
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x00332E76 File Offset: 0x00331076
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x00332E80 File Offset: 0x00331080
		public static TrackMoonTarget GetRootAsTrackMoonTarget(ByteBuffer _bb)
		{
			return TrackMoonTarget.GetRootAsTrackMoonTarget(_bb, default(TrackMoonTarget));
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x00332E9C File Offset: 0x0033109C
		public static TrackMoonTarget GetRootAsTrackMoonTarget(ByteBuffer _bb, TrackMoonTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x00332EB9 File Offset: 0x003310B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E10F RID: 57615 RVA: 0x00332EC8 File Offset: 0x003310C8
		public TrackMoonTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600E110 RID: 57616 RVA: 0x00332ED8 File Offset: 0x003310D8
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

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600E111 RID: 57617 RVA: 0x00332F14 File Offset: 0x00331114
		public string TargetName
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

		// Token: 0x0600E112 RID: 57618 RVA: 0x00332F4B File Offset: 0x0033114B
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E113 RID: 57619 RVA: 0x00332F5A File Offset: 0x0033115A
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600E114 RID: 57620 RVA: 0x00332F74 File Offset: 0x00331174
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

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600E115 RID: 57621 RVA: 0x00332FB0 File Offset: 0x003311B0
		public int TargetReward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600E116 RID: 57622 RVA: 0x00332FF0 File Offset: 0x003311F0
		public int TargetFunc
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

		// Token: 0x04005291 RID: 21137
		private Table __p;
	}
}
