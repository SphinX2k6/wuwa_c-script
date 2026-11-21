using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F68 RID: 3944
	public struct NewbieMainActTab : IFlatbufferObject
	{
		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x0600A493 RID: 42131 RVA: 0x002B99E9 File Offset: 0x002B7BE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x002B99F6 File Offset: 0x002B7BF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x002B9A00 File Offset: 0x002B7C00
		public static NewbieMainActTab GetRootAsNewbieMainActTab(ByteBuffer _bb)
		{
			return NewbieMainActTab.GetRootAsNewbieMainActTab(_bb, default(NewbieMainActTab));
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x002B9A1C File Offset: 0x002B7C1C
		public static NewbieMainActTab GetRootAsNewbieMainActTab(ByteBuffer _bb, NewbieMainActTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x002B9A39 File Offset: 0x002B7C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x002B9A48 File Offset: 0x002B7C48
		public NewbieMainActTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x0600A499 RID: 42137 RVA: 0x002B9A58 File Offset: 0x002B7C58
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

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x0600A49A RID: 42138 RVA: 0x002B9A94 File Offset: 0x002B7C94
		public int ActivityId
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

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x0600A49B RID: 42139 RVA: 0x002B9AD0 File Offset: 0x002B7CD0
		public string TitleText
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

		// Token: 0x0600A49C RID: 42140 RVA: 0x002B9B07 File Offset: 0x002B7D07
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x002B9B16 File Offset: 0x002B7D16
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0600A49E RID: 42142 RVA: 0x002B9B30 File Offset: 0x002B7D30
		public string TitleIcon
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

		// Token: 0x0600A49F RID: 42143 RVA: 0x002B9B68 File Offset: 0x002B7D68
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x002B9B78 File Offset: 0x002B7D78
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x002B9B90 File Offset: 0x002B7D90
		public string MaleTaskTexture
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

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x002B9BC8 File Offset: 0x002B7DC8
		public Span<byte> GetMaleTaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x002B9BD8 File Offset: 0x002B7DD8
		public byte[] GetMaleTaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0600A4A4 RID: 42148 RVA: 0x002B9BF0 File Offset: 0x002B7DF0
		public string FemaleTaskTexture
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

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x002B9C28 File Offset: 0x002B7E28
		public Span<byte> GetFemaleTaskTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x002B9C38 File Offset: 0x002B7E38
		public byte[] GetFemaleTaskTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x002B9C50 File Offset: 0x002B7E50
		public int DirectTrainActivityId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x0600A4A8 RID: 42152 RVA: 0x002B9C90 File Offset: 0x002B7E90
		public bool IsEnd
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x002B9CD0 File Offset: 0x002B7ED0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005516 RID: 21782
		private Table __p;
	}
}
