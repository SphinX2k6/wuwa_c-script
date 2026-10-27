using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F32 RID: 3890
	public struct PinballMonsterSkillDisplay : IFlatbufferObject
	{
		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600AF91 RID: 44945 RVA: 0x002C33A8 File Offset: 0x002C15A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x002C33B5 File Offset: 0x002C15B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x002C33BC File Offset: 0x002C15BC
		public static PinballMonsterSkillDisplay GetRootAsPinballMonsterSkillDisplay(ByteBuffer _bb)
		{
			return PinballMonsterSkillDisplay.GetRootAsPinballMonsterSkillDisplay(_bb, default(PinballMonsterSkillDisplay));
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x002C33D8 File Offset: 0x002C15D8
		public static PinballMonsterSkillDisplay GetRootAsPinballMonsterSkillDisplay(ByteBuffer _bb, PinballMonsterSkillDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x002C33F5 File Offset: 0x002C15F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x002C3404 File Offset: 0x002C1604
		public PinballMonsterSkillDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600AF97 RID: 44951 RVA: 0x002C3414 File Offset: 0x002C1614
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

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600AF98 RID: 44952 RVA: 0x002C3450 File Offset: 0x002C1650
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

		// Token: 0x0600AF99 RID: 44953 RVA: 0x002C3487 File Offset: 0x002C1687
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x002C3496 File Offset: 0x002C1696
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600AF9B RID: 44955 RVA: 0x002C34B0 File Offset: 0x002C16B0
		public string Desc
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

		// Token: 0x0600AF9C RID: 44956 RVA: 0x002C34E7 File Offset: 0x002C16E7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AF9D RID: 44957 RVA: 0x002C34F6 File Offset: 0x002C16F6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x002C3510 File Offset: 0x002C1710
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF9F RID: 44959 RVA: 0x002C3548 File Offset: 0x002C1748
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AFA0 RID: 44960 RVA: 0x002C3558 File Offset: 0x002C1758
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600AFA1 RID: 44961 RVA: 0x002C3570 File Offset: 0x002C1770
		public string VideoPath
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

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x002C35A8 File Offset: 0x002C17A8
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x002C35B8 File Offset: 0x002C17B8
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FFC RID: 20476
		private Table __p;
	}
}
