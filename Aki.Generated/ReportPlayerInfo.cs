using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A0 RID: 4256
	public struct ReportPlayerInfo : IFlatbufferObject
	{
		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600C1DB RID: 49627 RVA: 0x002F9AFE File Offset: 0x002F7CFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x002F9B0B File Offset: 0x002F7D0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x002F9B14 File Offset: 0x002F7D14
		public static ReportPlayerInfo GetRootAsReportPlayerInfo(ByteBuffer _bb)
		{
			return ReportPlayerInfo.GetRootAsReportPlayerInfo(_bb, default(ReportPlayerInfo));
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x002F9B30 File Offset: 0x002F7D30
		public static ReportPlayerInfo GetRootAsReportPlayerInfo(ByteBuffer _bb, ReportPlayerInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x002F9B4D File Offset: 0x002F7D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x002F9B5C File Offset: 0x002F7D5C
		public ReportPlayerInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x002F9B6C File Offset: 0x002F7D6C
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

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600C1E2 RID: 49634 RVA: 0x002F9BA8 File Offset: 0x002F7DA8
		public string Reason
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

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x002F9BDF File Offset: 0x002F7DDF
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x002F9BEE File Offset: 0x002F7DEE
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005679 RID: 22137
		private Table __p;
	}
}
