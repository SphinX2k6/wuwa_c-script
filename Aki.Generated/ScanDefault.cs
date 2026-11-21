using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001187 RID: 4487
	public struct ScanDefault : IFlatbufferObject
	{
		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600D760 RID: 55136 RVA: 0x003294FF File Offset: 0x003276FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D761 RID: 55137 RVA: 0x0032950C File Offset: 0x0032770C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x00329514 File Offset: 0x00327714
		public static ScanDefault GetRootAsScanDefault(ByteBuffer _bb)
		{
			return ScanDefault.GetRootAsScanDefault(_bb, default(ScanDefault));
		}

		// Token: 0x0600D763 RID: 55139 RVA: 0x00329530 File Offset: 0x00327730
		public static ScanDefault GetRootAsScanDefault(ByteBuffer _bb, ScanDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D764 RID: 55140 RVA: 0x0032954D File Offset: 0x0032774D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x0032955C File Offset: 0x0032775C
		public ScanDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600D766 RID: 55142 RVA: 0x0032956C File Offset: 0x0032776C
		public int UId
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600D767 RID: 55143 RVA: 0x003295A8 File Offset: 0x003277A8
		public string EntityType
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

		// Token: 0x0600D768 RID: 55144 RVA: 0x003295DF File Offset: 0x003277DF
		public Span<byte> GetEntityTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x003295EE File Offset: 0x003277EE
		public byte[] GetEntityTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600D76A RID: 55146 RVA: 0x00329608 File Offset: 0x00327808
		public int ScanId
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

		// Token: 0x04005798 RID: 22424
		private Table __p;
	}
}
