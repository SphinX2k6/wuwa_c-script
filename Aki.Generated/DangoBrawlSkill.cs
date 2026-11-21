using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB6 RID: 3254
	public struct DangoBrawlSkill : IFlatbufferObject
	{
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x0022E4F8 File Offset: 0x0022C6F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x0022E505 File Offset: 0x0022C705
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x0022E50C File Offset: 0x0022C70C
		public static DangoBrawlSkill GetRootAsDangoBrawlSkill(ByteBuffer _bb)
		{
			return DangoBrawlSkill.GetRootAsDangoBrawlSkill(_bb, default(DangoBrawlSkill));
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x0022E528 File Offset: 0x0022C728
		public static DangoBrawlSkill GetRootAsDangoBrawlSkill(ByteBuffer _bb, DangoBrawlSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x0022E545 File Offset: 0x0022C745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x0022E554 File Offset: 0x0022C754
		public DangoBrawlSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x0022E564 File Offset: 0x0022C764
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x0022E5A0 File Offset: 0x0022C7A0
		public bool IsOnly
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x0022E5E0 File Offset: 0x0022C7E0
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

		// Token: 0x040051E3 RID: 20963
		private Table __p;
	}
}
