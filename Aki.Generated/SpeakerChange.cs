using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001212 RID: 4626
	public struct SpeakerChange : IFlatbufferObject
	{
		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600E4FE RID: 58622 RVA: 0x00348F65 File Offset: 0x00347165
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4FF RID: 58623 RVA: 0x00348F72 File Offset: 0x00347172
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00348F7C File Offset: 0x0034717C
		public static SpeakerChange GetRootAsSpeakerChange(ByteBuffer _bb)
		{
			return SpeakerChange.GetRootAsSpeakerChange(_bb, default(SpeakerChange));
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00348F98 File Offset: 0x00347198
		public static SpeakerChange GetRootAsSpeakerChange(ByteBuffer _bb, SpeakerChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00348FB5 File Offset: 0x003471B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00348FC4 File Offset: 0x003471C4
		public SpeakerChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600E504 RID: 58628 RVA: 0x00348FD4 File Offset: 0x003471D4
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

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600E505 RID: 58629 RVA: 0x00349010 File Offset: 0x00347210
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

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600E506 RID: 58630 RVA: 0x0034904C File Offset: 0x0034724C
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

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600E507 RID: 58631 RVA: 0x00349088 File Offset: 0x00347288
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

		// Token: 0x04005852 RID: 22610
		private Table __p;
	}
}
