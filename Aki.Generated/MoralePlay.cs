using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F10 RID: 3856
	public struct MoralePlay : IFlatbufferObject
	{
		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06009C87 RID: 40071 RVA: 0x002A8239 File Offset: 0x002A6439
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x002A8246 File Offset: 0x002A6446
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x002A8250 File Offset: 0x002A6450
		public static MoralePlay GetRootAsMoralePlay(ByteBuffer _bb)
		{
			return MoralePlay.GetRootAsMoralePlay(_bb, default(MoralePlay));
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x002A826C File Offset: 0x002A646C
		public static MoralePlay GetRootAsMoralePlay(ByteBuffer _bb, MoralePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x002A8289 File Offset: 0x002A6489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x002A8298 File Offset: 0x002A6498
		public MoralePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x002A82A8 File Offset: 0x002A64A8
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

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06009C8E RID: 40078 RVA: 0x002A82E4 File Offset: 0x002A64E4
		public int BattleScoreId
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

		// Token: 0x06009C8F RID: 40079 RVA: 0x002A8320 File Offset: 0x002A6520
		public int ExpItemId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06009C90 RID: 40080 RVA: 0x002A8360 File Offset: 0x002A6560
		public int ExpItemIdLength
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

		// Token: 0x06009C91 RID: 40081 RVA: 0x002A838B File Offset: 0x002A658B
		public Span<int> GetExpItemIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x002A839A File Offset: 0x002A659A
		public int[] GetExpItemIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x002A83B1 File Offset: 0x002A65B1
		[NullableContext(1)]
		public int[] ExpItemId()
		{
			return this.GetExpItemIdArray();
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x002A83B9 File Offset: 0x002A65B9
		[NullableContext(1)]
		public IEnumerable<int> ExpItemIdIter()
		{
			MoralePlay.<ExpItemIdIter>d__18 <ExpItemIdIter>d__ = new MoralePlay.<ExpItemIdIter>d__18(-2);
			<ExpItemIdIter>d__.<>3__<>4__this = this;
			return <ExpItemIdIter>d__;
		}

		// Token: 0x040054B5 RID: 21685
		private Table __p;
	}
}
