using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F84 RID: 3972
	public struct OccupationConfig : IFlatbufferObject
	{
		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x002BF4DD File Offset: 0x002BD6DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x002BF4EA File Offset: 0x002BD6EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x002BF4F4 File Offset: 0x002BD6F4
		public static OccupationConfig GetRootAsOccupationConfig(ByteBuffer _bb)
		{
			return OccupationConfig.GetRootAsOccupationConfig(_bb, default(OccupationConfig));
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x002BF510 File Offset: 0x002BD710
		public static OccupationConfig GetRootAsOccupationConfig(ByteBuffer _bb, OccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x002BF52D File Offset: 0x002BD72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x002BF53C File Offset: 0x002BD73C
		public OccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x002BF54C File Offset: 0x002BD74C
		public string Id
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

		// Token: 0x0600A736 RID: 42806 RVA: 0x002BF583 File Offset: 0x002BD783
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x002BF592 File Offset: 0x002BD792
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x0600A738 RID: 42808 RVA: 0x002BF5AC File Offset: 0x002BD7AC
		public string OccupationType
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

		// Token: 0x0600A739 RID: 42809 RVA: 0x002BF5E3 File Offset: 0x002BD7E3
		public Span<byte> GetOccupationTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x002BF5F2 File Offset: 0x002BD7F2
		public byte[] GetOccupationTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x002BF60C File Offset: 0x002BD80C
		public int NameStringKey
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

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600A73C RID: 42812 RVA: 0x002BF648 File Offset: 0x002BD848
		public int Name
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

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x002BF688 File Offset: 0x002BD888
		public string OccupationData
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

		// Token: 0x0600A73E RID: 42814 RVA: 0x002BF6C0 File Offset: 0x002BD8C0
		public Span<byte> GetOccupationDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x002BF6D0 File Offset: 0x002BD8D0
		public byte[] GetOccupationDataArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005538 RID: 21816
		private Table __p;
	}
}
