using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001215 RID: 4629
	public struct SpecialFormation : IFlatbufferObject
	{
		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600E51E RID: 58654 RVA: 0x003493AC File Offset: 0x003475AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E51F RID: 58655 RVA: 0x003493B9 File Offset: 0x003475B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E520 RID: 58656 RVA: 0x003493C0 File Offset: 0x003475C0
		public static SpecialFormation GetRootAsSpecialFormation(ByteBuffer _bb)
		{
			return SpecialFormation.GetRootAsSpecialFormation(_bb, default(SpecialFormation));
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x003493DC File Offset: 0x003475DC
		public static SpecialFormation GetRootAsSpecialFormation(ByteBuffer _bb, SpecialFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E522 RID: 58658 RVA: 0x003493F9 File Offset: 0x003475F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E523 RID: 58659 RVA: 0x00349408 File Offset: 0x00347608
		public SpecialFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600E524 RID: 58660 RVA: 0x00349418 File Offset: 0x00347618
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

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600E525 RID: 58661 RVA: 0x00349454 File Offset: 0x00347654
		public int Type
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

		// Token: 0x0600E526 RID: 58662 RVA: 0x00349490 File Offset: 0x00347690
		public int CharacterId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x003494D0 File Offset: 0x003476D0
		public int CharacterIdLength
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

		// Token: 0x0600E528 RID: 58664 RVA: 0x003494FB File Offset: 0x003476FB
		public Span<int> GetCharacterIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x0034950A File Offset: 0x0034770A
		public int[] GetCharacterIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x00349521 File Offset: 0x00347721
		[NullableContext(1)]
		public int[] CharacterId()
		{
			return this.GetCharacterIdArray();
		}

		// Token: 0x0600E52B RID: 58667 RVA: 0x00349529 File Offset: 0x00347729
		[NullableContext(1)]
		public IEnumerable<int> CharacterIdIter()
		{
			SpecialFormation.<CharacterIdIter>d__18 <CharacterIdIter>d__ = new SpecialFormation.<CharacterIdIter>d__18(-2);
			<CharacterIdIter>d__.<>3__<>4__this = this;
			return <CharacterIdIter>d__;
		}

		// Token: 0x04005855 RID: 22613
		private Table __p;
	}
}
