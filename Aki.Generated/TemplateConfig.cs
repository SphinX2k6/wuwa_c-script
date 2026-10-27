using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111D RID: 4381
	public struct TemplateConfig : IFlatbufferObject
	{
		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600DD6C RID: 56684 RVA: 0x0032AC35 File Offset: 0x00328E35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x0032AC42 File Offset: 0x00328E42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x0032AC4C File Offset: 0x00328E4C
		public static TemplateConfig GetRootAsTemplateConfig(ByteBuffer _bb)
		{
			return TemplateConfig.GetRootAsTemplateConfig(_bb, default(TemplateConfig));
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x0032AC68 File Offset: 0x00328E68
		public static TemplateConfig GetRootAsTemplateConfig(ByteBuffer _bb, TemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x0032AC85 File Offset: 0x00328E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x0032AC94 File Offset: 0x00328E94
		public TemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600DD72 RID: 56690 RVA: 0x0032ACA4 File Offset: 0x00328EA4
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

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x0032ACE0 File Offset: 0x00328EE0
		public string BlueprintType
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

		// Token: 0x0600DD74 RID: 56692 RVA: 0x0032AD17 File Offset: 0x00328F17
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DD75 RID: 56693 RVA: 0x0032AD26 File Offset: 0x00328F26
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600DD76 RID: 56694 RVA: 0x0032AD40 File Offset: 0x00328F40
		public string Name
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

		// Token: 0x0600DD77 RID: 56695 RVA: 0x0032AD77 File Offset: 0x00328F77
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x0032AD86 File Offset: 0x00328F86
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x0032ADA0 File Offset: 0x00328FA0
		public string ComponentsData
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

		// Token: 0x0600DD7A RID: 56698 RVA: 0x0032ADD8 File Offset: 0x00328FD8
		public Span<byte> GetComponentsDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x0032ADE8 File Offset: 0x00328FE8
		public byte[] GetComponentsDataArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525A RID: 21082
		private Table __p;
	}
}
