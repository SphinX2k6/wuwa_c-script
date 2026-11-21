using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C2 RID: 4546
	public struct SkillType : IFlatbufferObject
	{
		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600DDA1 RID: 56737 RVA: 0x003381E8 File Offset: 0x003363E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDA2 RID: 56738 RVA: 0x003381F5 File Offset: 0x003363F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDA3 RID: 56739 RVA: 0x003381FC File Offset: 0x003363FC
		public static SkillType GetRootAsSkillType(ByteBuffer _bb)
		{
			return SkillType.GetRootAsSkillType(_bb, default(SkillType));
		}

		// Token: 0x0600DDA4 RID: 56740 RVA: 0x00338218 File Offset: 0x00336418
		public static SkillType GetRootAsSkillType(ByteBuffer _bb, SkillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDA5 RID: 56741 RVA: 0x00338235 File Offset: 0x00336435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDA6 RID: 56742 RVA: 0x00338244 File Offset: 0x00336444
		public SkillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600DDA7 RID: 56743 RVA: 0x00338254 File Offset: 0x00336454
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

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600DDA8 RID: 56744 RVA: 0x00338290 File Offset: 0x00336490
		public string TypeName
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

		// Token: 0x0600DDA9 RID: 56745 RVA: 0x003382C7 File Offset: 0x003364C7
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DDAA RID: 56746 RVA: 0x003382D6 File Offset: 0x003364D6
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040057F4 RID: 22516
		private Table __p;
	}
}
