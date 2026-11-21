using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDE RID: 3038
	public struct AreaMapGroup : IFlatbufferObject
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x001F759D File Offset: 0x001F579D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x001F75AA File Offset: 0x001F57AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x001F75B4 File Offset: 0x001F57B4
		public static AreaMapGroup GetRootAsAreaMapGroup(ByteBuffer _bb)
		{
			return AreaMapGroup.GetRootAsAreaMapGroup(_bb, default(AreaMapGroup));
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x001F75D0 File Offset: 0x001F57D0
		public static AreaMapGroup GetRootAsAreaMapGroup(ByteBuffer _bb, AreaMapGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x001F75ED File Offset: 0x001F57ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x001F75FC File Offset: 0x001F57FC
		public AreaMapGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x001F760C File Offset: 0x001F580C
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x001F7648 File Offset: 0x001F5848
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x001F7684 File Offset: 0x001F5884
		public PosRectangle? BlockBorder(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new PosRectangle?(default(PosRectangle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06004DE8 RID: 19944 RVA: 0x001F76E4 File Offset: 0x001F58E4
		public int BlockBorderLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x001F7710 File Offset: 0x001F5910
		public int InstanceDungeon(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x001F7750 File Offset: 0x001F5950
		public int InstanceDungeonLength
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

		// Token: 0x06004DEB RID: 19947 RVA: 0x001F777C File Offset: 0x001F597C
		public Span<int> GetInstanceDungeonBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x001F778C File Offset: 0x001F598C
		public int[] GetInstanceDungeonArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06004DED RID: 19949 RVA: 0x001F77A4 File Offset: 0x001F59A4
		public int UnlockCondition
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

		// Token: 0x06004DEE RID: 19950 RVA: 0x001F77E1 File Offset: 0x001F59E1
		[NullableContext(1)]
		public PosRectangle[] BlockBorder()
		{
			return this.BlockBorderIter().ToArray<PosRectangle>();
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x001F77EE File Offset: 0x001F59EE
		[NullableContext(1)]
		public IEnumerable<PosRectangle> BlockBorderIter()
		{
			AreaMapGroup.<BlockBorderIter>d__23 <BlockBorderIter>d__ = new AreaMapGroup.<BlockBorderIter>d__23(-2);
			<BlockBorderIter>d__.<>3__<>4__this = this;
			return <BlockBorderIter>d__;
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x001F7803 File Offset: 0x001F5A03
		[NullableContext(1)]
		public int[] InstanceDungeon()
		{
			return this.GetInstanceDungeonArray();
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x001F780B File Offset: 0x001F5A0B
		[NullableContext(1)]
		public IEnumerable<int> InstanceDungeonIter()
		{
			AreaMapGroup.<InstanceDungeonIter>d__25 <InstanceDungeonIter>d__ = new AreaMapGroup.<InstanceDungeonIter>d__25(-2);
			<InstanceDungeonIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonIter>d__;
		}

		// Token: 0x040050C3 RID: 20675
		private Table __p;
	}
}
