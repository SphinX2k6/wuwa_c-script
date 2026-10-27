using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001113 RID: 4371
	public struct SynthesisSkill : IFlatbufferObject
	{
		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600DCB2 RID: 56498 RVA: 0x00329205 File Offset: 0x00327405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x00329212 File Offset: 0x00327412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x0032921C File Offset: 0x0032741C
		public static SynthesisSkill GetRootAsSynthesisSkill(ByteBuffer _bb)
		{
			return SynthesisSkill.GetRootAsSynthesisSkill(_bb, default(SynthesisSkill));
		}

		// Token: 0x0600DCB5 RID: 56501 RVA: 0x00329238 File Offset: 0x00327438
		public static SynthesisSkill GetRootAsSynthesisSkill(ByteBuffer _bb, SynthesisSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCB6 RID: 56502 RVA: 0x00329255 File Offset: 0x00327455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCB7 RID: 56503 RVA: 0x00329264 File Offset: 0x00327464
		public SynthesisSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x00329274 File Offset: 0x00327474
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

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x003292B0 File Offset: 0x003274B0
		public int ExtraItemId
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

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x003292EC File Offset: 0x003274EC
		public int EffectiveProbability
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

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600DCBB RID: 56507 RVA: 0x00329328 File Offset: 0x00327528
		public int Typeld
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

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00329368 File Offset: 0x00327568
		public int SkillDescription
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

		// Token: 0x04005250 RID: 21072
		private Table __p;
	}
}
