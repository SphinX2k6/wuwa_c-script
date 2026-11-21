using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001017 RID: 4119
	public struct PinballMonsterSkillDisplay : IFlatbufferObject
	{
		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600B5B2 RID: 46514 RVA: 0x002DFD98 File Offset: 0x002DDF98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x002DFDA5 File Offset: 0x002DDFA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x002DFDAC File Offset: 0x002DDFAC
		public static PinballMonsterSkillDisplay GetRootAsPinballMonsterSkillDisplay(ByteBuffer _bb)
		{
			return PinballMonsterSkillDisplay.GetRootAsPinballMonsterSkillDisplay(_bb, default(PinballMonsterSkillDisplay));
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x002DFDC8 File Offset: 0x002DDFC8
		public static PinballMonsterSkillDisplay GetRootAsPinballMonsterSkillDisplay(ByteBuffer _bb, PinballMonsterSkillDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x002DFDE5 File Offset: 0x002DDFE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x002DFDF4 File Offset: 0x002DDFF4
		public PinballMonsterSkillDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x002DFE04 File Offset: 0x002DE004
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

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600B5B9 RID: 46521 RVA: 0x002DFE40 File Offset: 0x002DE040
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

		// Token: 0x0600B5BA RID: 46522 RVA: 0x002DFE77 File Offset: 0x002DE077
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x002DFE86 File Offset: 0x002DE086
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600B5BC RID: 46524 RVA: 0x002DFEA0 File Offset: 0x002DE0A0
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

		// Token: 0x0600B5BD RID: 46525 RVA: 0x002DFED7 File Offset: 0x002DE0D7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x002DFEE6 File Offset: 0x002DE0E6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600B5BF RID: 46527 RVA: 0x002DFF00 File Offset: 0x002DE100
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

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x002DFF38 File Offset: 0x002DE138
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x002DFF48 File Offset: 0x002DE148
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600B5C2 RID: 46530 RVA: 0x002DFF60 File Offset: 0x002DE160
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

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x002DFF98 File Offset: 0x002DE198
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x002DFFA8 File Offset: 0x002DE1A8
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040055E1 RID: 21985
		private Table __p;
	}
}
