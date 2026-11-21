using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BC RID: 4540
	public struct SkillIcon : IFlatbufferObject
	{
		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x0033690A File Offset: 0x00334B0A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x00336917 File Offset: 0x00334B17
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCFB RID: 56571 RVA: 0x00336920 File Offset: 0x00334B20
		public static SkillIcon GetRootAsSkillIcon(ByteBuffer _bb)
		{
			return SkillIcon.GetRootAsSkillIcon(_bb, default(SkillIcon));
		}

		// Token: 0x0600DCFC RID: 56572 RVA: 0x0033693C File Offset: 0x00334B3C
		public static SkillIcon GetRootAsSkillIcon(ByteBuffer _bb, SkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCFD RID: 56573 RVA: 0x00336959 File Offset: 0x00334B59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCFE RID: 56574 RVA: 0x00336968 File Offset: 0x00334B68
		public SkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600DCFF RID: 56575 RVA: 0x00336978 File Offset: 0x00334B78
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

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x003369B4 File Offset: 0x00334BB4
		public int Tag
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

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600DD01 RID: 56577 RVA: 0x003369F0 File Offset: 0x00334BF0
		public string IconPath
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

		// Token: 0x0600DD02 RID: 56578 RVA: 0x00336A27 File Offset: 0x00334C27
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DD03 RID: 56579 RVA: 0x00336A36 File Offset: 0x00334C36
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x00336A50 File Offset: 0x00334C50
		public string Name
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

		// Token: 0x0600DD05 RID: 56581 RVA: 0x00336A88 File Offset: 0x00334C88
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DD06 RID: 56582 RVA: 0x00336A98 File Offset: 0x00334C98
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040057E9 RID: 22505
		private Table __p;
	}
}
