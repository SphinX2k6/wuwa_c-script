using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E0 RID: 4576
	public struct SkillDescribeStruct : IFlatbufferObject
	{
		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0600EB6D RID: 60269 RVA: 0x0034A429 File Offset: 0x00348629
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x0034A436 File Offset: 0x00348636
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x0034A440 File Offset: 0x00348640
		public static SkillDescribeStruct GetRootAsSkillDescribeStruct(ByteBuffer _bb)
		{
			return SkillDescribeStruct.GetRootAsSkillDescribeStruct(_bb, default(SkillDescribeStruct));
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x0034A45C File Offset: 0x0034865C
		public static SkillDescribeStruct GetRootAsSkillDescribeStruct(ByteBuffer _bb, SkillDescribeStruct obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x0034A479 File Offset: 0x00348679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x0034A488 File Offset: 0x00348688
		public SkillDescribeStruct __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x0600EB73 RID: 60275 RVA: 0x0034A498 File Offset: 0x00348698
		public string Title
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

		// Token: 0x0600EB74 RID: 60276 RVA: 0x0034A4CF File Offset: 0x003486CF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EB75 RID: 60277 RVA: 0x0034A4DE File Offset: 0x003486DE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x0600EB76 RID: 60278 RVA: 0x0034A4F8 File Offset: 0x003486F8
		public string Content
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

		// Token: 0x0600EB77 RID: 60279 RVA: 0x0034A52F File Offset: 0x0034872F
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x0034A53E File Offset: 0x0034873E
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005359 RID: 21337
		private Table __p;
	}
}
