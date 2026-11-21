using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFA RID: 3578
	public struct GuideDownLoadQuest : IFlatbufferObject
	{
		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x0600827D RID: 33405 RVA: 0x0026E118 File Offset: 0x0026C318
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600827E RID: 33406 RVA: 0x0026E125 File Offset: 0x0026C325
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0026E12C File Offset: 0x0026C32C
		public static GuideDownLoadQuest GetRootAsGuideDownLoadQuest(ByteBuffer _bb)
		{
			return GuideDownLoadQuest.GetRootAsGuideDownLoadQuest(_bb, default(GuideDownLoadQuest));
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x0026E148 File Offset: 0x0026C348
		public static GuideDownLoadQuest GetRootAsGuideDownLoadQuest(ByteBuffer _bb, GuideDownLoadQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x0026E165 File Offset: 0x0026C365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008282 RID: 33410 RVA: 0x0026E174 File Offset: 0x0026C374
		public GuideDownLoadQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06008283 RID: 33411 RVA: 0x0026E184 File Offset: 0x0026C384
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

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06008284 RID: 33412 RVA: 0x0026E1C0 File Offset: 0x0026C3C0
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

		// Token: 0x06008285 RID: 33413 RVA: 0x0026E1FC File Offset: 0x0026C3FC
		public int SubPackageList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x0026E23C File Offset: 0x0026C43C
		public int SubPackageListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008287 RID: 33415 RVA: 0x0026E267 File Offset: 0x0026C467
		public Span<int> GetSubPackageListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0026E276 File Offset: 0x0026C476
		public int[] GetSubPackageListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x0026E28D File Offset: 0x0026C48D
		[NullableContext(1)]
		public int[] SubPackageList()
		{
			return this.GetSubPackageListArray();
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0026E295 File Offset: 0x0026C495
		[NullableContext(1)]
		public IEnumerable<int> SubPackageListIter()
		{
			GuideDownLoadQuest.<SubPackageListIter>d__18 <SubPackageListIter>d__ = new GuideDownLoadQuest.<SubPackageListIter>d__18(-2);
			<SubPackageListIter>d__.<>3__<>4__this = this;
			return <SubPackageListIter>d__;
		}

		// Token: 0x04005372 RID: 21362
		private Table __p;
	}
}
