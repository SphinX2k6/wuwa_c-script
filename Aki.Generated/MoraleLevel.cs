using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0B RID: 3851
	public struct MoraleLevel : IFlatbufferObject
	{
		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06009C45 RID: 40005 RVA: 0x002A79F5 File Offset: 0x002A5BF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x002A7A02 File Offset: 0x002A5C02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x002A7A0C File Offset: 0x002A5C0C
		public static MoraleLevel GetRootAsMoraleLevel(ByteBuffer _bb)
		{
			return MoraleLevel.GetRootAsMoraleLevel(_bb, default(MoraleLevel));
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x002A7A28 File Offset: 0x002A5C28
		public static MoraleLevel GetRootAsMoraleLevel(ByteBuffer _bb, MoraleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x002A7A45 File Offset: 0x002A5C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x002A7A54 File Offset: 0x002A5C54
		public MoraleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06009C4B RID: 40011 RVA: 0x002A7A64 File Offset: 0x002A5C64
		public int Level
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

		// Token: 0x06009C4C RID: 40012 RVA: 0x002A7AA0 File Offset: 0x002A5CA0
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06009C4D RID: 40013 RVA: 0x002A7AE0 File Offset: 0x002A5CE0
		public int BuffIdsLength
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

		// Token: 0x06009C4E RID: 40014 RVA: 0x002A7B0B File Offset: 0x002A5D0B
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x002A7B1A File Offset: 0x002A5D1A
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x002A7B31 File Offset: 0x002A5D31
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x002A7B39 File Offset: 0x002A5D39
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			MoraleLevel.<BuffIdsIter>d__16 <BuffIdsIter>d__ = new MoraleLevel.<BuffIdsIter>d__16(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040054B0 RID: 21680
		private Table __p;
	}
}
