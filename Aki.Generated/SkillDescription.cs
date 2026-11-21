using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B9 RID: 4537
	public struct SkillDescription : IFlatbufferObject
	{
		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600DC78 RID: 56440 RVA: 0x00335450 File Offset: 0x00333650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x0033545D File Offset: 0x0033365D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00335464 File Offset: 0x00333664
		public static SkillDescription GetRootAsSkillDescription(ByteBuffer _bb)
		{
			return SkillDescription.GetRootAsSkillDescription(_bb, default(SkillDescription));
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00335480 File Offset: 0x00333680
		public static SkillDescription GetRootAsSkillDescription(ByteBuffer _bb, SkillDescription obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x0033549D File Offset: 0x0033369D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x003354AC File Offset: 0x003336AC
		public SkillDescription __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600DC7E RID: 56446 RVA: 0x003354BC File Offset: 0x003336BC
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

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x003354F8 File Offset: 0x003336F8
		public int SkillLevelGroupId
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

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600DC80 RID: 56448 RVA: 0x00335534 File Offset: 0x00333734
		public string AttributeName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC81 RID: 56449 RVA: 0x0033556B File Offset: 0x0033376B
		public Span<byte> GetAttributeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DC82 RID: 56450 RVA: 0x0033557A File Offset: 0x0033377A
		public byte[] GetAttributeNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC83 RID: 56451 RVA: 0x00335594 File Offset: 0x00333794
		public StringArray? SkillDetailNum(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600DC84 RID: 56452 RVA: 0x003355F8 File Offset: 0x003337F8
		public int SkillDetailNumLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x00335624 File Offset: 0x00333824
		public string Description
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC86 RID: 56454 RVA: 0x0033565C File Offset: 0x0033385C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DC87 RID: 56455 RVA: 0x0033566C File Offset: 0x0033386C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x00335684 File Offset: 0x00333884
		public int Order
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

		// Token: 0x0600DC89 RID: 56457 RVA: 0x003356C1 File Offset: 0x003338C1
		[NullableContext(1)]
		public StringArray[] SkillDetailNum()
		{
			return this.SkillDetailNumIter().ToArray<StringArray>();
		}

		// Token: 0x0600DC8A RID: 56458 RVA: 0x003356CE File Offset: 0x003338CE
		[NullableContext(1)]
		public IEnumerable<StringArray> SkillDetailNumIter()
		{
			SkillDescription.<SkillDetailNumIter>d__26 <SkillDetailNumIter>d__ = new SkillDescription.<SkillDetailNumIter>d__26(-2);
			<SkillDetailNumIter>d__.<>3__<>4__this = this;
			return <SkillDetailNumIter>d__;
		}

		// Token: 0x040057E2 RID: 22498
		private Table __p;
	}
}
