using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C1 RID: 4289
	public struct SkillIcon : IFlatbufferObject
	{
		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600D51C RID: 54556 RVA: 0x00317769 File Offset: 0x00315969
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D51D RID: 54557 RVA: 0x00317776 File Offset: 0x00315976
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x00317780 File Offset: 0x00315980
		public static SkillIcon GetRootAsSkillIcon(ByteBuffer _bb)
		{
			return SkillIcon.GetRootAsSkillIcon(_bb, default(SkillIcon));
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x0031779C File Offset: 0x0031599C
		public static SkillIcon GetRootAsSkillIcon(ByteBuffer _bb, SkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D520 RID: 54560 RVA: 0x003177B9 File Offset: 0x003159B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x003177C8 File Offset: 0x003159C8
		public SkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600D522 RID: 54562 RVA: 0x003177D8 File Offset: 0x003159D8
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

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600D523 RID: 54563 RVA: 0x00317814 File Offset: 0x00315A14
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

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600D524 RID: 54564 RVA: 0x00317850 File Offset: 0x00315A50
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

		// Token: 0x0600D525 RID: 54565 RVA: 0x00317887 File Offset: 0x00315A87
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x00317896 File Offset: 0x00315A96
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600D527 RID: 54567 RVA: 0x003178B0 File Offset: 0x00315AB0
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

		// Token: 0x0600D528 RID: 54568 RVA: 0x003178E8 File Offset: 0x00315AE8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D529 RID: 54569 RVA: 0x003178F8 File Offset: 0x00315AF8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040051EA RID: 20970
		private Table __p;
	}
}
