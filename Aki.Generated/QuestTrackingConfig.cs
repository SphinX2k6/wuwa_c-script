using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7A RID: 3962
	public struct QuestTrackingConfig : IFlatbufferObject
	{
		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600B699 RID: 46745 RVA: 0x002D1E2D File Offset: 0x002D002D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x002D1E3A File Offset: 0x002D003A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x002D1E44 File Offset: 0x002D0044
		public static QuestTrackingConfig GetRootAsQuestTrackingConfig(ByteBuffer _bb)
		{
			return QuestTrackingConfig.GetRootAsQuestTrackingConfig(_bb, default(QuestTrackingConfig));
		}

		// Token: 0x0600B69C RID: 46748 RVA: 0x002D1E60 File Offset: 0x002D0060
		public static QuestTrackingConfig GetRootAsQuestTrackingConfig(ByteBuffer _bb, QuestTrackingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x002D1E7D File Offset: 0x002D007D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x002D1E8C File Offset: 0x002D008C
		public QuestTrackingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600B69F RID: 46751 RVA: 0x002D1E9C File Offset: 0x002D009C
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

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x002D1ED8 File Offset: 0x002D00D8
		public int PreQuestIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x002D1F18 File Offset: 0x002D0118
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

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x002D1F43 File Offset: 0x002D0143
		public Span<int> GetPreQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x002D1F52 File Offset: 0x002D0152
		public int[] GetPreQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0600B6A4 RID: 46756 RVA: 0x002D1F6C File Offset: 0x002D016C
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

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0600B6A5 RID: 46757 RVA: 0x002D1FA8 File Offset: 0x002D01A8
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

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x002D1FE0 File Offset: 0x002D01E0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x002D1FF0 File Offset: 0x002D01F0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0600B6A8 RID: 46760 RVA: 0x002D2008 File Offset: 0x002D0208
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

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x002D2048 File Offset: 0x002D0248
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreQuestIdsIter()或GetPreQuestIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreQuestIds()
		{
			QuestTrackingConfig questTrackingConfig = this;
			return questTrackingConfig.GetPreQuestIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x002D206C File Offset: 0x002D026C
		[NullableContext(1)]
		public readonly IEnumerable<int> PreQuestIdsIter()
		{
			QuestTrackingConfig.<PreQuestIdsIter>d__24 <PreQuestIdsIter>d__ = new QuestTrackingConfig.<PreQuestIdsIter>d__24(-2);
			<PreQuestIdsIter>d__.<>3__<>4__this = this;
			return <PreQuestIdsIter>d__;
		}

		// Token: 0x04005048 RID: 20552
		private Table __p;
	}
}
