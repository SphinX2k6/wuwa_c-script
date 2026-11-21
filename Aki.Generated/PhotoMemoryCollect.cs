using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF6 RID: 4086
	public struct PhotoMemoryCollect : IFlatbufferObject
	{
		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600B28F RID: 45711 RVA: 0x002D8AFC File Offset: 0x002D6CFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x002D8B09 File Offset: 0x002D6D09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x002D8B10 File Offset: 0x002D6D10
		public static PhotoMemoryCollect GetRootAsPhotoMemoryCollect(ByteBuffer _bb)
		{
			return PhotoMemoryCollect.GetRootAsPhotoMemoryCollect(_bb, default(PhotoMemoryCollect));
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x002D8B2C File Offset: 0x002D6D2C
		public static PhotoMemoryCollect GetRootAsPhotoMemoryCollect(ByteBuffer _bb, PhotoMemoryCollect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x002D8B49 File Offset: 0x002D6D49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x002D8B58 File Offset: 0x002D6D58
		public PhotoMemoryCollect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700289C RID: 10396
		// (get) Token: 0x0600B295 RID: 45717 RVA: 0x002D8B68 File Offset: 0x002D6D68
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

		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600B296 RID: 45718 RVA: 0x002D8BA4 File Offset: 0x002D6DA4
		public int TopicID
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

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600B297 RID: 45719 RVA: 0x002D8BE0 File Offset: 0x002D6DE0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600B298 RID: 45720 RVA: 0x002D8C1C File Offset: 0x002D6E1C
		public int Rank
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600B299 RID: 45721 RVA: 0x002D8C5C File Offset: 0x002D6E5C
		public string ThemeBg
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

		// Token: 0x0600B29A RID: 45722 RVA: 0x002D8C94 File Offset: 0x002D6E94
		public Span<byte> GetThemeBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x002D8CA4 File Offset: 0x002D6EA4
		public byte[] GetThemeBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600B29C RID: 45724 RVA: 0x002D8CBC File Offset: 0x002D6EBC
		public string BgResourceM
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x002D8CF4 File Offset: 0x002D6EF4
		public Span<byte> GetBgResourceMBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x002D8D04 File Offset: 0x002D6F04
		public byte[] GetBgResourceMArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600B29F RID: 45727 RVA: 0x002D8D1C File Offset: 0x002D6F1C
		public string BgResourceF
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

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x002D8D54 File Offset: 0x002D6F54
		public Span<byte> GetBgResourceFBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x002D8D64 File Offset: 0x002D6F64
		public byte[] GetBgResourceFArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x002D8D7C File Offset: 0x002D6F7C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x002D8DB4 File Offset: 0x002D6FB4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x002D8DC4 File Offset: 0x002D6FC4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600B2A5 RID: 45733 RVA: 0x002D8DDC File Offset: 0x002D6FDC
		public string TipsDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x002D8E14 File Offset: 0x002D7014
		public Span<byte> GetTipsDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002D8E24 File Offset: 0x002D7024
		public byte[] GetTipsDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x002D8E3C File Offset: 0x002D703C
		public int ClueId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600B2A9 RID: 45737 RVA: 0x002D8E7C File Offset: 0x002D707C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x002D8EB4 File Offset: 0x002D70B4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x002D8EC4 File Offset: 0x002D70C4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x002D8EDC File Offset: 0x002D70DC
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x002D8F1C File Offset: 0x002D711C
		public int TraceEntityId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028A9 RID: 10409
		// (get) Token: 0x0600B2AE RID: 45742 RVA: 0x002D8F5C File Offset: 0x002D715C
		public int TrackMapId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028AA RID: 10410
		// (get) Token: 0x0600B2AF RID: 45743 RVA: 0x002D8F9C File Offset: 0x002D719C
		public int TraceMarkId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028AB RID: 10411
		// (get) Token: 0x0600B2B0 RID: 45744 RVA: 0x002D8FDC File Offset: 0x002D71DC
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x002D901C File Offset: 0x002D721C
		public int QuestIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028AC RID: 10412
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x002D905C File Offset: 0x002D725C
		public int QuestIdListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x002D9088 File Offset: 0x002D7288
		public Span<int> GetQuestIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x002D9098 File Offset: 0x002D7298
		public int[] GetQuestIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x002D90B0 File Offset: 0x002D72B0
		[NullableContext(1)]
		public int[] QuestIdList()
		{
			return this.GetQuestIdListArray();
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x002D90B8 File Offset: 0x002D72B8
		[NullableContext(1)]
		public IEnumerable<int> QuestIdListIter()
		{
			PhotoMemoryCollect.<QuestIdListIter>d__58 <QuestIdListIter>d__ = new PhotoMemoryCollect.<QuestIdListIter>d__58(-2);
			<QuestIdListIter>d__.<>3__<>4__this = this;
			return <QuestIdListIter>d__;
		}

		// Token: 0x040055BE RID: 21950
		private Table __p;
	}
}
