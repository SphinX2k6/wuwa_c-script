using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001063 RID: 4195
	public struct QuestTreeCustomJumpConfig : IFlatbufferObject
	{
		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0600BD07 RID: 48391 RVA: 0x002EEF4C File Offset: 0x002ED14C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x002EEF59 File Offset: 0x002ED159
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x002EEF60 File Offset: 0x002ED160
		public static QuestTreeCustomJumpConfig GetRootAsQuestTreeCustomJumpConfig(ByteBuffer _bb)
		{
			return QuestTreeCustomJumpConfig.GetRootAsQuestTreeCustomJumpConfig(_bb, default(QuestTreeCustomJumpConfig));
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x002EEF7C File Offset: 0x002ED17C
		public static QuestTreeCustomJumpConfig GetRootAsQuestTreeCustomJumpConfig(ByteBuffer _bb, QuestTreeCustomJumpConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x002EEF99 File Offset: 0x002ED199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x002EEFA8 File Offset: 0x002ED1A8
		public QuestTreeCustomJumpConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0600BD0D RID: 48397 RVA: 0x002EEFB8 File Offset: 0x002ED1B8
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

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600BD0E RID: 48398 RVA: 0x002EEFF4 File Offset: 0x002ED1F4
		public int QuestId
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

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x002EF030 File Offset: 0x002ED230
		public string PreConditionType
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

		// Token: 0x0600BD10 RID: 48400 RVA: 0x002EF067 File Offset: 0x002ED267
		public Span<byte> GetPreConditionTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x002EF076 File Offset: 0x002ED276
		public byte[] GetPreConditionTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600BD12 RID: 48402 RVA: 0x002EF090 File Offset: 0x002ED290
		public int ConditionIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600BD13 RID: 48403 RVA: 0x002EF0D0 File Offset: 0x002ED2D0
		public string JumpType
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

		// Token: 0x0600BD14 RID: 48404 RVA: 0x002EF108 File Offset: 0x002ED308
		public Span<byte> GetJumpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x002EF118 File Offset: 0x002ED318
		public byte[] GetJumpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600BD16 RID: 48406 RVA: 0x002EF130 File Offset: 0x002ED330
		public int ParamsId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x002EF170 File Offset: 0x002ED370
		public string CustomTextKey
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x002EF1A8 File Offset: 0x002ED3A8
		public Span<byte> GetCustomTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x002EF1B8 File Offset: 0x002ED3B8
		public byte[] GetCustomTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005631 RID: 22065
		private Table __p;
	}
}
