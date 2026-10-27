using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1F RID: 3615
	public struct MontageData : IFlatbufferObject
	{
		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x060095A7 RID: 38311 RVA: 0x00288CF4 File Offset: 0x00286EF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x00288D01 File Offset: 0x00286F01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x00288D08 File Offset: 0x00286F08
		public static MontageData GetRootAsMontageData(ByteBuffer _bb)
		{
			return MontageData.GetRootAsMontageData(_bb, default(MontageData));
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x00288D24 File Offset: 0x00286F24
		public static MontageData GetRootAsMontageData(ByteBuffer _bb, MontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x00288D41 File Offset: 0x00286F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x00288D50 File Offset: 0x00286F50
		public MontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x060095AD RID: 38317 RVA: 0x00288D60 File Offset: 0x00286F60
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

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x060095AE RID: 38318 RVA: 0x00288D9C File Offset: 0x00286F9C
		public string ActionMontage
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

		// Token: 0x060095AF RID: 38319 RVA: 0x00288DD3 File Offset: 0x00286FD3
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x00288DE2 File Offset: 0x00286FE2
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x060095B1 RID: 38321 RVA: 0x00288DFC File Offset: 0x00286FFC
		public string ExpressionMontage
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

		// Token: 0x060095B2 RID: 38322 RVA: 0x00288E33 File Offset: 0x00287033
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x00288E42 File Offset: 0x00287042
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x060095B4 RID: 38324 RVA: 0x00288E5C File Offset: 0x0028705C
		public string MouthSequence
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

		// Token: 0x060095B5 RID: 38325 RVA: 0x00288E94 File Offset: 0x00287094
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00288EA4 File Offset: 0x002870A4
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EC4 RID: 20164
		private Table __p;
	}
}
