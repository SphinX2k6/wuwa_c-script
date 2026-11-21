using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001050 RID: 4176
	public struct QuestComponentStatusType : IFlatbufferObject
	{
		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0600BB78 RID: 47992 RVA: 0x002EBE24 File Offset: 0x002EA024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x002EBE31 File Offset: 0x002EA031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB7A RID: 47994 RVA: 0x002EBE38 File Offset: 0x002EA038
		public static QuestComponentStatusType GetRootAsQuestComponentStatusType(ByteBuffer _bb)
		{
			return QuestComponentStatusType.GetRootAsQuestComponentStatusType(_bb, default(QuestComponentStatusType));
		}

		// Token: 0x0600BB7B RID: 47995 RVA: 0x002EBE54 File Offset: 0x002EA054
		public static QuestComponentStatusType GetRootAsQuestComponentStatusType(ByteBuffer _bb, QuestComponentStatusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB7C RID: 47996 RVA: 0x002EBE71 File Offset: 0x002EA071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB7D RID: 47997 RVA: 0x002EBE80 File Offset: 0x002EA080
		public QuestComponentStatusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x002EBE90 File Offset: 0x002EA090
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

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600BB7F RID: 47999 RVA: 0x002EBECC File Offset: 0x002EA0CC
		public string StatusIcon
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

		// Token: 0x0600BB80 RID: 48000 RVA: 0x002EBF03 File Offset: 0x002EA103
		public Span<byte> GetStatusIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x002EBF12 File Offset: 0x002EA112
		public byte[] GetStatusIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x002EBF2C File Offset: 0x002EA12C
		public string StatusPrefab
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

		// Token: 0x0600BB83 RID: 48003 RVA: 0x002EBF63 File Offset: 0x002EA163
		public Span<byte> GetStatusPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x002EBF72 File Offset: 0x002EA172
		public byte[] GetStatusPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400561E RID: 22046
		private Table __p;
	}
}
