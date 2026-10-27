using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118F RID: 4495
	public struct VideoQte : IFlatbufferObject
	{
		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x0600E73D RID: 59197 RVA: 0x00340F25 File Offset: 0x0033F125
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x00340F32 File Offset: 0x0033F132
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E73F RID: 59199 RVA: 0x00340F3C File Offset: 0x0033F13C
		public static VideoQte GetRootAsVideoQte(ByteBuffer _bb)
		{
			return VideoQte.GetRootAsVideoQte(_bb, default(VideoQte));
		}

		// Token: 0x0600E740 RID: 59200 RVA: 0x00340F58 File Offset: 0x0033F158
		public static VideoQte GetRootAsVideoQte(ByteBuffer _bb, VideoQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E741 RID: 59201 RVA: 0x00340F75 File Offset: 0x0033F175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x00340F84 File Offset: 0x0033F184
		public VideoQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x0600E743 RID: 59203 RVA: 0x00340F94 File Offset: 0x0033F194
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

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0600E744 RID: 59204 RVA: 0x00340FD0 File Offset: 0x0033F1D0
		public string CgName
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

		// Token: 0x0600E745 RID: 59205 RVA: 0x00341007 File Offset: 0x0033F207
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x00341016 File Offset: 0x0033F216
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0600E747 RID: 59207 RVA: 0x00341030 File Offset: 0x0033F230
		public int QteId
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

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x0600E748 RID: 59208 RVA: 0x0034106C File Offset: 0x0033F26C
		public int ShowMoment
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

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0600E749 RID: 59209 RVA: 0x003410AC File Offset: 0x0033F2AC
		public int ShowMomentEn
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

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x0600E74A RID: 59210 RVA: 0x003410EC File Offset: 0x0033F2EC
		public int ShowMomentKo
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600E74B RID: 59211 RVA: 0x0034112C File Offset: 0x0033F32C
		public int ShowMomentJa
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052D9 RID: 21209
		private Table __p;
	}
}
