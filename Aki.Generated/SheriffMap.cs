using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119C RID: 4508
	public struct SheriffMap : IFlatbufferObject
	{
		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600D8D9 RID: 55513 RVA: 0x0032C62D File Offset: 0x0032A82D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x0032C63A File Offset: 0x0032A83A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x0032C644 File Offset: 0x0032A844
		public static SheriffMap GetRootAsSheriffMap(ByteBuffer _bb)
		{
			return SheriffMap.GetRootAsSheriffMap(_bb, default(SheriffMap));
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x0032C660 File Offset: 0x0032A860
		public static SheriffMap GetRootAsSheriffMap(ByteBuffer _bb, SheriffMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x0032C67D File Offset: 0x0032A87D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x0032C68C File Offset: 0x0032A88C
		public SheriffMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600D8DF RID: 55519 RVA: 0x0032C69C File Offset: 0x0032A89C
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600D8E0 RID: 55520 RVA: 0x0032C6D8 File Offset: 0x0032A8D8
		public int MapId
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x0032C714 File Offset: 0x0032A914
		public string MapName
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

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x0032C74B File Offset: 0x0032A94B
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x0032C75A File Offset: 0x0032A95A
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600D8E4 RID: 55524 RVA: 0x0032C774 File Offset: 0x0032A974
		public int BigMapDefaultScale
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600D8E5 RID: 55525 RVA: 0x0032C7B4 File Offset: 0x0032A9B4
		public int BigMapMinScale
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

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600D8E6 RID: 55526 RVA: 0x0032C7F4 File Offset: 0x0032A9F4
		public int BigMapMaxScale
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

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600D8E7 RID: 55527 RVA: 0x0032C834 File Offset: 0x0032AA34
		public int QuestMapDefaultScale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x0032C874 File Offset: 0x0032AA74
		public int QuestMapMinScale
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600D8E9 RID: 55529 RVA: 0x0032C8B4 File Offset: 0x0032AAB4
		public int QuestMapMaxScale
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D8EA RID: 55530 RVA: 0x0032C8F4 File Offset: 0x0032AAF4
		public string TileRange(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600D8EB RID: 55531 RVA: 0x0032C930 File Offset: 0x0032AB30
		public int TileRangeLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x0032C95C File Offset: 0x0032AB5C
		public int UnlockFogs(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600D8ED RID: 55533 RVA: 0x0032C99C File Offset: 0x0032AB9C
		public int UnlockFogsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x0032C9C8 File Offset: 0x0032ABC8
		public Span<int> GetUnlockFogsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x0032C9D8 File Offset: 0x0032ABD8
		public int[] GetUnlockFogsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x0032C9F0 File Offset: 0x0032ABF0
		public int ExtraMarkIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x0032CA30 File Offset: 0x0032AC30
		public int ExtraMarkIdsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x0032CA5C File Offset: 0x0032AC5C
		public Span<int> GetExtraMarkIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x0032CA6C File Offset: 0x0032AC6C
		public int[] GetExtraMarkIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x0032CA84 File Offset: 0x0032AC84
		[NullableContext(1)]
		public int[] ExtraMarkIds()
		{
			return this.GetExtraMarkIdsArray();
		}

		// Token: 0x0600D8F5 RID: 55541 RVA: 0x0032CA8C File Offset: 0x0032AC8C
		[NullableContext(1)]
		public IEnumerable<int> ExtraMarkIdsIter()
		{
			SheriffMap.<ExtraMarkIdsIter>d__42 <ExtraMarkIdsIter>d__ = new SheriffMap.<ExtraMarkIdsIter>d__42(-2);
			<ExtraMarkIdsIter>d__.<>3__<>4__this = this;
			return <ExtraMarkIdsIter>d__;
		}

		// Token: 0x0600D8F6 RID: 55542 RVA: 0x0032CAA1 File Offset: 0x0032ACA1
		[NullableContext(1)]
		public string[] TileRange()
		{
			return this.TileRangeIter().ToArray<string>();
		}

		// Token: 0x0600D8F7 RID: 55543 RVA: 0x0032CAAE File Offset: 0x0032ACAE
		[NullableContext(1)]
		public IEnumerable<string> TileRangeIter()
		{
			SheriffMap.<TileRangeIter>d__44 <TileRangeIter>d__ = new SheriffMap.<TileRangeIter>d__44(-2);
			<TileRangeIter>d__.<>3__<>4__this = this;
			return <TileRangeIter>d__;
		}

		// Token: 0x0600D8F8 RID: 55544 RVA: 0x0032CAC3 File Offset: 0x0032ACC3
		[NullableContext(1)]
		public int[] UnlockFogs()
		{
			return this.GetUnlockFogsArray();
		}

		// Token: 0x0600D8F9 RID: 55545 RVA: 0x0032CACB File Offset: 0x0032ACCB
		[NullableContext(1)]
		public IEnumerable<int> UnlockFogsIter()
		{
			SheriffMap.<UnlockFogsIter>d__46 <UnlockFogsIter>d__ = new SheriffMap.<UnlockFogsIter>d__46(-2);
			<UnlockFogsIter>d__.<>3__<>4__this = this;
			return <UnlockFogsIter>d__;
		}

		// Token: 0x040057AE RID: 22446
		private Table __p;
	}
}
