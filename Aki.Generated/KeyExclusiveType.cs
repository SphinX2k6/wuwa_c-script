using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D88 RID: 3464
	public struct KeyExclusiveType : IFlatbufferObject
	{
		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06008730 RID: 34608 RVA: 0x00267D8F File Offset: 0x00265F8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x00267D9C File Offset: 0x00265F9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00267DA4 File Offset: 0x00265FA4
		public static KeyExclusiveType GetRootAsKeyExclusiveType(ByteBuffer _bb)
		{
			return KeyExclusiveType.GetRootAsKeyExclusiveType(_bb, default(KeyExclusiveType));
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00267DC0 File Offset: 0x00265FC0
		public static KeyExclusiveType GetRootAsKeyExclusiveType(ByteBuffer _bb, KeyExclusiveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00267DDD File Offset: 0x00265FDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00267DEC File Offset: 0x00265FEC
		public KeyExclusiveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x00267DFC File Offset: 0x00265FFC
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

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06008737 RID: 34615 RVA: 0x00267E38 File Offset: 0x00266038
		public string Name
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

		// Token: 0x06008738 RID: 34616 RVA: 0x00267E6F File Offset: 0x0026606F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x00267E7E File Offset: 0x0026607E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00267E98 File Offset: 0x00266098
		public string IconSpritePath
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

		// Token: 0x0600873B RID: 34619 RVA: 0x00267ECF File Offset: 0x002660CF
		public Span<byte> GetIconSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x00267EDE File Offset: 0x002660DE
		public byte[] GetIconSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E14 RID: 19988
		private Table __p;
	}
}
