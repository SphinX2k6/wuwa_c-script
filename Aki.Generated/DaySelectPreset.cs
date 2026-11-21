using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC5 RID: 3269
	public struct DaySelectPreset : IFlatbufferObject
	{
		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x00230848 File Offset: 0x0022EA48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x00230855 File Offset: 0x0022EA55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x0023085C File Offset: 0x0022EA5C
		public static DaySelectPreset GetRootAsDaySelectPreset(ByteBuffer _bb)
		{
			return DaySelectPreset.GetRootAsDaySelectPreset(_bb, default(DaySelectPreset));
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00230878 File Offset: 0x0022EA78
		public static DaySelectPreset GetRootAsDaySelectPreset(ByteBuffer _bb, DaySelectPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x00230895 File Offset: 0x0022EA95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x002308A4 File Offset: 0x0022EAA4
		public DaySelectPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x002308B4 File Offset: 0x0022EAB4
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x002308F0 File Offset: 0x0022EAF0
		public string Title
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

		// Token: 0x06006709 RID: 26377 RVA: 0x00230927 File Offset: 0x0022EB27
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x00230936 File Offset: 0x0022EB36
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x00230950 File Offset: 0x0022EB50
		public int ChangeDayNum
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

		// Token: 0x040051F2 RID: 20978
		private Table __p;
	}
}
