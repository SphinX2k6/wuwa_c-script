using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9C RID: 3996
	public struct RealmBetweenPhantomGain : IFlatbufferObject
	{
		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600B964 RID: 47460 RVA: 0x002D8340 File Offset: 0x002D6540
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x002D834D File Offset: 0x002D654D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x002D8354 File Offset: 0x002D6554
		public static RealmBetweenPhantomGain GetRootAsRealmBetweenPhantomGain(ByteBuffer _bb)
		{
			return RealmBetweenPhantomGain.GetRootAsRealmBetweenPhantomGain(_bb, default(RealmBetweenPhantomGain));
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x002D8370 File Offset: 0x002D6570
		public static RealmBetweenPhantomGain GetRootAsRealmBetweenPhantomGain(ByteBuffer _bb, RealmBetweenPhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x002D838D File Offset: 0x002D658D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x002D839C File Offset: 0x002D659C
		public RealmBetweenPhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0600B96A RID: 47466 RVA: 0x002D83AC File Offset: 0x002D65AC
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

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0600B96B RID: 47467 RVA: 0x002D83E8 File Offset: 0x002D65E8
		public int MonsterInfoId
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

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0600B96C RID: 47468 RVA: 0x002D8424 File Offset: 0x002D6624
		public int ActivityId
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

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x002D8460 File Offset: 0x002D6660
		public int UnLockReward
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600B96E RID: 47470 RVA: 0x002D84A0 File Offset: 0x002D66A0
		public int Sort
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

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0600B96F RID: 47471 RVA: 0x002D84E0 File Offset: 0x002D66E0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x002D8518 File Offset: 0x002D6718
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x002D8528 File Offset: 0x002D6728
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600B972 RID: 47474 RVA: 0x002D8540 File Offset: 0x002D6740
		public string TexPhantom
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x002D8578 File Offset: 0x002D6778
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x002D8588 File Offset: 0x002D6788
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400506C RID: 20588
		private Table __p;
	}
}
