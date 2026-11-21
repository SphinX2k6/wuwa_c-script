using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE6 RID: 4070
	public struct PhoneTipShowList : IFlatbufferObject
	{
		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600B106 RID: 45318 RVA: 0x002D5475 File Offset: 0x002D3675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x002D5482 File Offset: 0x002D3682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x002D548C File Offset: 0x002D368C
		public static PhoneTipShowList GetRootAsPhoneTipShowList(ByteBuffer _bb)
		{
			return PhoneTipShowList.GetRootAsPhoneTipShowList(_bb, default(PhoneTipShowList));
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x002D54A8 File Offset: 0x002D36A8
		public static PhoneTipShowList GetRootAsPhoneTipShowList(ByteBuffer _bb, PhoneTipShowList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x002D54C5 File Offset: 0x002D36C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B10B RID: 45323 RVA: 0x002D54D4 File Offset: 0x002D36D4
		public PhoneTipShowList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600B10C RID: 45324 RVA: 0x002D54E4 File Offset: 0x002D36E4
		public int DungeonSubType
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

		// Token: 0x0600B10D RID: 45325 RVA: 0x002D5520 File Offset: 0x002D3720
		public int WorldDungeonSubTypeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600B10E RID: 45326 RVA: 0x002D5560 File Offset: 0x002D3760
		public int WorldDungeonSubTypeListLength
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

		// Token: 0x0600B10F RID: 45327 RVA: 0x002D558B File Offset: 0x002D378B
		public Span<int> GetWorldDungeonSubTypeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x002D559A File Offset: 0x002D379A
		public int[] GetWorldDungeonSubTypeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x002D55B1 File Offset: 0x002D37B1
		[NullableContext(1)]
		public int[] WorldDungeonSubTypeList()
		{
			return this.GetWorldDungeonSubTypeListArray();
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x002D55B9 File Offset: 0x002D37B9
		[NullableContext(1)]
		public IEnumerable<int> WorldDungeonSubTypeListIter()
		{
			PhoneTipShowList.<WorldDungeonSubTypeListIter>d__16 <WorldDungeonSubTypeListIter>d__ = new PhoneTipShowList.<WorldDungeonSubTypeListIter>d__16(-2);
			<WorldDungeonSubTypeListIter>d__.<>3__<>4__this = this;
			return <WorldDungeonSubTypeListIter>d__;
		}

		// Token: 0x040055AE RID: 21934
		private Table __p;
	}
}
