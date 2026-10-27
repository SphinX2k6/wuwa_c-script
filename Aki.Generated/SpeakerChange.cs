using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DC RID: 4316
	public struct SpeakerChange : IFlatbufferObject
	{
		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600D7B3 RID: 55219 RVA: 0x0031D8F1 File Offset: 0x0031BAF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x0031D8FE File Offset: 0x0031BAFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x0031D908 File Offset: 0x0031BB08
		public static SpeakerChange GetRootAsSpeakerChange(ByteBuffer _bb)
		{
			return SpeakerChange.GetRootAsSpeakerChange(_bb, default(SpeakerChange));
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x0031D924 File Offset: 0x0031BB24
		public static SpeakerChange GetRootAsSpeakerChange(ByteBuffer _bb, SpeakerChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x0031D941 File Offset: 0x0031BB41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x0031D950 File Offset: 0x0031BB50
		public SpeakerChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x0031D960 File Offset: 0x0031BB60
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

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600D7BA RID: 55226 RVA: 0x0031D99C File Offset: 0x0031BB9C
		public int PartnerBefore
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

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x0031D9D8 File Offset: 0x0031BBD8
		public int ImageId
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

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600D7BC RID: 55228 RVA: 0x0031DA14 File Offset: 0x0031BC14
		public int SpeakerBefore
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

		// Token: 0x0400520F RID: 21007
		private Table __p;
	}
}
