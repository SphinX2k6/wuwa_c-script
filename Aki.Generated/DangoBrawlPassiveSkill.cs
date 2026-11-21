using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAD RID: 3245
	public struct DangoBrawlPassiveSkill : IFlatbufferObject
	{
		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x0022BA31 File Offset: 0x00229C31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x0022BA3E File Offset: 0x00229C3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x0022BA48 File Offset: 0x00229C48
		public static DangoBrawlPassiveSkill GetRootAsDangoBrawlPassiveSkill(ByteBuffer _bb)
		{
			return DangoBrawlPassiveSkill.GetRootAsDangoBrawlPassiveSkill(_bb, default(DangoBrawlPassiveSkill));
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x0022BA64 File Offset: 0x00229C64
		public static DangoBrawlPassiveSkill GetRootAsDangoBrawlPassiveSkill(ByteBuffer _bb, DangoBrawlPassiveSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x0022BA81 File Offset: 0x00229C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0022BA90 File Offset: 0x00229C90
		public DangoBrawlPassiveSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x0022BAA0 File Offset: 0x00229CA0
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060064C8 RID: 25800 RVA: 0x0022BADC File Offset: 0x00229CDC
		public bool IsOnly
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x0022BB1C File Offset: 0x00229D1C
		public int PlayEffectId
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

		// Token: 0x040051D7 RID: 20951
		private Table __p;
	}
}
