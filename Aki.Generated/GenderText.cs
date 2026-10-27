using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF2 RID: 3314
	public struct GenderText : IFlatbufferObject
	{
		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x00249A36 File Offset: 0x00247C36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x00249A43 File Offset: 0x00247C43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00249A4C File Offset: 0x00247C4C
		public static GenderText GetRootAsGenderText(ByteBuffer _bb)
		{
			return GenderText.GetRootAsGenderText(_bb, default(GenderText));
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00249A68 File Offset: 0x00247C68
		public static GenderText GetRootAsGenderText(ByteBuffer _bb, GenderText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x00249A85 File Offset: 0x00247C85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00249A94 File Offset: 0x00247C94
		public GenderText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x00249AA4 File Offset: 0x00247CA4
		public string MaleText
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x00249ADB File Offset: 0x00247CDB
		public Span<byte> GetMaleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00249AEA File Offset: 0x00247CEA
		public byte[] GetMaleTextArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x060079CA RID: 31178 RVA: 0x00249B04 File Offset: 0x00247D04
		public string FemaleText
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

		// Token: 0x060079CB RID: 31179 RVA: 0x00249B3B File Offset: 0x00247D3B
		public Span<byte> GetFemaleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00249B4A File Offset: 0x00247D4A
		public byte[] GetFemaleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D65 RID: 19813
		private Table __p;
	}
}
