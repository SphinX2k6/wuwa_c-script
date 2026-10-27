using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB8 RID: 4024
	public struct ReportPlayerInfo : IFlatbufferObject
	{
		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600BB91 RID: 48017 RVA: 0x002DD36E File Offset: 0x002DB56E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB92 RID: 48018 RVA: 0x002DD37B File Offset: 0x002DB57B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x002DD384 File Offset: 0x002DB584
		public static ReportPlayerInfo GetRootAsReportPlayerInfo(ByteBuffer _bb)
		{
			return ReportPlayerInfo.GetRootAsReportPlayerInfo(_bb, default(ReportPlayerInfo));
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x002DD3A0 File Offset: 0x002DB5A0
		public static ReportPlayerInfo GetRootAsReportPlayerInfo(ByteBuffer _bb, ReportPlayerInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x002DD3BD File Offset: 0x002DB5BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x002DD3CC File Offset: 0x002DB5CC
		public ReportPlayerInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600BB97 RID: 48023 RVA: 0x002DD3DC File Offset: 0x002DB5DC
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

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600BB98 RID: 48024 RVA: 0x002DD418 File Offset: 0x002DB618
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

		// Token: 0x0600BB99 RID: 48025 RVA: 0x002DD44F File Offset: 0x002DB64F
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x002DD45E File Offset: 0x002DB65E
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005091 RID: 20625
		private Table __p;
	}
}
