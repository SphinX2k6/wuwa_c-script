using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6E RID: 3950
	public struct QuestRefMapBlockConfig : IFlatbufferObject
	{
		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600B58F RID: 46479 RVA: 0x002CFC01 File Offset: 0x002CDE01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B590 RID: 46480 RVA: 0x002CFC0E File Offset: 0x002CDE0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x002CFC18 File Offset: 0x002CDE18
		public static QuestRefMapBlockConfig GetRootAsQuestRefMapBlockConfig(ByteBuffer _bb)
		{
			return QuestRefMapBlockConfig.GetRootAsQuestRefMapBlockConfig(_bb, default(QuestRefMapBlockConfig));
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x002CFC34 File Offset: 0x002CDE34
		public static QuestRefMapBlockConfig GetRootAsQuestRefMapBlockConfig(ByteBuffer _bb, QuestRefMapBlockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x002CFC51 File Offset: 0x002CDE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x002CFC60 File Offset: 0x002CDE60
		public QuestRefMapBlockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600B595 RID: 46485 RVA: 0x002CFC70 File Offset: 0x002CDE70
		public int QuestId
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

		// Token: 0x0600B596 RID: 46486 RVA: 0x002CFCAC File Offset: 0x002CDEAC
		public int MapBlockId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600B597 RID: 46487 RVA: 0x002CFCEC File Offset: 0x002CDEEC
		public int MapBlockIdLength
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

		// Token: 0x0600B598 RID: 46488 RVA: 0x002CFD17 File Offset: 0x002CDF17
		public Span<int> GetMapBlockIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x002CFD26 File Offset: 0x002CDF26
		public int[] GetMapBlockIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600B59A RID: 46490 RVA: 0x002CFD40 File Offset: 0x002CDF40
		public string OnlineBranch
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

		// Token: 0x0600B59B RID: 46491 RVA: 0x002CFD77 File Offset: 0x002CDF77
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x002CFD86 File Offset: 0x002CDF86
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x002CFDA0 File Offset: 0x002CDFA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MapBlockIdIter()或GetMapBlockIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MapBlockId()
		{
			QuestRefMapBlockConfig questRefMapBlockConfig = this;
			return questRefMapBlockConfig.GetMapBlockIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x002CFDC4 File Offset: 0x002CDFC4
		[NullableContext(1)]
		public readonly IEnumerable<int> MapBlockIdIter()
		{
			QuestRefMapBlockConfig.<MapBlockIdIter>d__20 <MapBlockIdIter>d__ = new QuestRefMapBlockConfig.<MapBlockIdIter>d__20(-2);
			<MapBlockIdIter>d__.<>3__<>4__this = this;
			return <MapBlockIdIter>d__;
		}

		// Token: 0x0400503C RID: 20540
		private Table __p;
	}
}
