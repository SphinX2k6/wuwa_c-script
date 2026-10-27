using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE6 RID: 4070
	public struct RoguelikeEffect : IFlatbufferObject
	{
		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600BFB6 RID: 49078 RVA: 0x002E65D6 File Offset: 0x002E47D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x002E65E3 File Offset: 0x002E47E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x002E65EC File Offset: 0x002E47EC
		public static RoguelikeEffect GetRootAsRoguelikeEffect(ByteBuffer _bb)
		{
			return RoguelikeEffect.GetRootAsRoguelikeEffect(_bb, default(RoguelikeEffect));
		}

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x002E6608 File Offset: 0x002E4808
		public static RoguelikeEffect GetRootAsRoguelikeEffect(ByteBuffer _bb, RoguelikeEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x002E6625 File Offset: 0x002E4825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BFBB RID: 49083 RVA: 0x002E6634 File Offset: 0x002E4834
		public RoguelikeEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600BFBC RID: 49084 RVA: 0x002E6644 File Offset: 0x002E4844
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

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0600BFBD RID: 49085 RVA: 0x002E6680 File Offset: 0x002E4880
		public int DescIntParam
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

		// Token: 0x040050C5 RID: 20677
		private Table __p;
	}
}
