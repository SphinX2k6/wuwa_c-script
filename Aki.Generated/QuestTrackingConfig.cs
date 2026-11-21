using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001061 RID: 4193
	public struct QuestTrackingConfig : IFlatbufferObject
	{
		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x002EE96D File Offset: 0x002ECB6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x002EE97A File Offset: 0x002ECB7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x002EE984 File Offset: 0x002ECB84
		public static QuestTrackingConfig GetRootAsQuestTrackingConfig(ByteBuffer _bb)
		{
			return QuestTrackingConfig.GetRootAsQuestTrackingConfig(_bb, default(QuestTrackingConfig));
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x002EE9A0 File Offset: 0x002ECBA0
		public static QuestTrackingConfig GetRootAsQuestTrackingConfig(ByteBuffer _bb, QuestTrackingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x002EE9BD File Offset: 0x002ECBBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x002EE9CC File Offset: 0x002ECBCC
		public QuestTrackingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x002EE9DC File Offset: 0x002ECBDC
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

		// Token: 0x0600BCDD RID: 48349 RVA: 0x002EEA18 File Offset: 0x002ECC18
		public int PreQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600BCDE RID: 48350 RVA: 0x002EEA58 File Offset: 0x002ECC58
		public int PreQuestIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x002EEA83 File Offset: 0x002ECC83
		public Span<int> GetPreQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x002EEA92 File Offset: 0x002ECC92
		public int[] GetPreQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600BCE1 RID: 48353 RVA: 0x002EEAAC File Offset: 0x002ECCAC
		public int TrackQuestId
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

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600BCE2 RID: 48354 RVA: 0x002EEAE8 File Offset: 0x002ECCE8
		public string Desc
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

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x002EEB20 File Offset: 0x002ECD20
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x002EEB30 File Offset: 0x002ECD30
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x002EEB48 File Offset: 0x002ECD48
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x002EEB85 File Offset: 0x002ECD85
		[NullableContext(1)]
		public int[] PreQuestIds()
		{
			return this.GetPreQuestIdsArray();
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x002EEB8D File Offset: 0x002ECD8D
		[NullableContext(1)]
		public IEnumerable<int> PreQuestIdsIter()
		{
			QuestTrackingConfig.<PreQuestIdsIter>d__24 <PreQuestIdsIter>d__ = new QuestTrackingConfig.<PreQuestIdsIter>d__24(-2);
			<PreQuestIdsIter>d__.<>3__<>4__this = this;
			return <PreQuestIdsIter>d__;
		}

		// Token: 0x0400562F RID: 22063
		private Table __p;
	}
}
