using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F02 RID: 3842
	public struct MonsterSizeId : IFlatbufferObject
	{
		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x002A672D File Offset: 0x002A492D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x002A673A File Offset: 0x002A493A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x002A6744 File Offset: 0x002A4944
		public static MonsterSizeId GetRootAsMonsterSizeId(ByteBuffer _bb)
		{
			return MonsterSizeId.GetRootAsMonsterSizeId(_bb, default(MonsterSizeId));
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x002A6760 File Offset: 0x002A4960
		public static MonsterSizeId GetRootAsMonsterSizeId(ByteBuffer _bb, MonsterSizeId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x002A677D File Offset: 0x002A497D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x002A678C File Offset: 0x002A498C
		public MonsterSizeId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x002A679C File Offset: 0x002A499C
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

		// Token: 0x06009BB5 RID: 39861 RVA: 0x002A67D8 File Offset: 0x002A49D8
		public string MonsterSizeTag(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06009BB6 RID: 39862 RVA: 0x002A6814 File Offset: 0x002A4A14
		public int MonsterSizeTagLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x002A683F File Offset: 0x002A4A3F
		[NullableContext(1)]
		public string[] MonsterSizeTag()
		{
			return this.MonsterSizeTagIter().ToArray<string>();
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x002A684C File Offset: 0x002A4A4C
		[NullableContext(1)]
		public IEnumerable<string> MonsterSizeTagIter()
		{
			MonsterSizeId.<MonsterSizeTagIter>d__14 <MonsterSizeTagIter>d__ = new MonsterSizeId.<MonsterSizeTagIter>d__14(-2);
			<MonsterSizeTagIter>d__.<>3__<>4__this = this;
			return <MonsterSizeTagIter>d__;
		}

		// Token: 0x040054A7 RID: 21671
		private Table __p;
	}
}
