using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6C RID: 3948
	public struct QuestNodeData : IFlatbufferObject
	{
		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600B573 RID: 46451 RVA: 0x002CF8FD File Offset: 0x002CDAFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x002CF90A File Offset: 0x002CDB0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x002CF914 File Offset: 0x002CDB14
		public static QuestNodeData GetRootAsQuestNodeData(ByteBuffer _bb)
		{
			return QuestNodeData.GetRootAsQuestNodeData(_bb, default(QuestNodeData));
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x002CF930 File Offset: 0x002CDB30
		public static QuestNodeData GetRootAsQuestNodeData(ByteBuffer _bb, QuestNodeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x002CF94D File Offset: 0x002CDB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x002CF95C File Offset: 0x002CDB5C
		public QuestNodeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600B579 RID: 46457 RVA: 0x002CF96C File Offset: 0x002CDB6C
		public string Key
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

		// Token: 0x0600B57A RID: 46458 RVA: 0x002CF9A3 File Offset: 0x002CDBA3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x002CF9B2 File Offset: 0x002CDBB2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600B57C RID: 46460 RVA: 0x002CF9CC File Offset: 0x002CDBCC
		public string Data
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

		// Token: 0x0600B57D RID: 46461 RVA: 0x002CFA03 File Offset: 0x002CDC03
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x002CFA12 File Offset: 0x002CDC12
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400503A RID: 20538
		private Table __p;
	}
}
