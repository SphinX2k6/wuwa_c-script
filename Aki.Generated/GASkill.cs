using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD5 RID: 3541
	public struct GASkill : IFlatbufferObject
	{
		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00267EE1 File Offset: 0x002660E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x00267EEE File Offset: 0x002660EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00267EF8 File Offset: 0x002660F8
		public static GASkill GetRootAsGASkill(ByteBuffer _bb)
		{
			return GASkill.GetRootAsGASkill(_bb, default(GASkill));
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x00267F14 File Offset: 0x00266114
		public static GASkill GetRootAsGASkill(ByteBuffer _bb, GASkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x00267F31 File Offset: 0x00266131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x00267F40 File Offset: 0x00266140
		public GASkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x00267F50 File Offset: 0x00266150
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

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06007FB5 RID: 32693 RVA: 0x00267F8C File Offset: 0x0026618C
		public int ConfigId
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

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x00267FC8 File Offset: 0x002661C8
		public int SkillId
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

		// Token: 0x06007FB7 RID: 32695 RVA: 0x00268004 File Offset: 0x00266204
		public int MontageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x00268044 File Offset: 0x00266244
		public int MontageIdLength
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

		// Token: 0x06007FB9 RID: 32697 RVA: 0x00268070 File Offset: 0x00266270
		public Span<int> GetMontageIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x00268080 File Offset: 0x00266280
		public int[] GetMontageIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x00268098 File Offset: 0x00266298
		[NullableContext(1)]
		public int[] MontageId()
		{
			return this.GetMontageIdArray();
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x002680A0 File Offset: 0x002662A0
		[NullableContext(1)]
		public IEnumerable<int> MontageIdIter()
		{
			GASkill.<MontageIdIter>d__20 <MontageIdIter>d__ = new GASkill.<MontageIdIter>d__20(-2);
			<MontageIdIter>d__.<>3__<>4__this = this;
			return <MontageIdIter>d__;
		}

		// Token: 0x04005346 RID: 21318
		private Table __p;
	}
}
