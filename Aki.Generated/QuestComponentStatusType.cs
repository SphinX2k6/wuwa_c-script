using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F69 RID: 3945
	public struct QuestComponentStatusType : IFlatbufferObject
	{
		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600B53B RID: 46395 RVA: 0x002CF208 File Offset: 0x002CD408
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x002CF215 File Offset: 0x002CD415
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x002CF21C File Offset: 0x002CD41C
		public static QuestComponentStatusType GetRootAsQuestComponentStatusType(ByteBuffer _bb)
		{
			return QuestComponentStatusType.GetRootAsQuestComponentStatusType(_bb, default(QuestComponentStatusType));
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x002CF238 File Offset: 0x002CD438
		public static QuestComponentStatusType GetRootAsQuestComponentStatusType(ByteBuffer _bb, QuestComponentStatusType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x002CF255 File Offset: 0x002CD455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x002CF264 File Offset: 0x002CD464
		public QuestComponentStatusType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600B541 RID: 46401 RVA: 0x002CF274 File Offset: 0x002CD474
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

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600B542 RID: 46402 RVA: 0x002CF2B0 File Offset: 0x002CD4B0
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

		// Token: 0x0600B543 RID: 46403 RVA: 0x002CF2E7 File Offset: 0x002CD4E7
		public Span<byte> GetStatusIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x002CF2F6 File Offset: 0x002CD4F6
		public byte[] GetStatusIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600B545 RID: 46405 RVA: 0x002CF310 File Offset: 0x002CD510
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

		// Token: 0x0600B546 RID: 46406 RVA: 0x002CF347 File Offset: 0x002CD547
		public Span<byte> GetStatusPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x002CF356 File Offset: 0x002CD556
		public byte[] GetStatusPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005037 RID: 20535
		private Table __p;
	}
}
