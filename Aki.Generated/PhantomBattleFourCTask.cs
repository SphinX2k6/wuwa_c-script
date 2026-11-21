using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB6 RID: 4022
	public struct PhantomBattleFourCTask : IFlatbufferObject
	{
		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600AD48 RID: 44360 RVA: 0x002CD176 File Offset: 0x002CB376
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x002CD183 File Offset: 0x002CB383
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x002CD18C File Offset: 0x002CB38C
		public static PhantomBattleFourCTask GetRootAsPhantomBattleFourCTask(ByteBuffer _bb)
		{
			return PhantomBattleFourCTask.GetRootAsPhantomBattleFourCTask(_bb, default(PhantomBattleFourCTask));
		}

		// Token: 0x0600AD4B RID: 44363 RVA: 0x002CD1A8 File Offset: 0x002CB3A8
		public static PhantomBattleFourCTask GetRootAsPhantomBattleFourCTask(ByteBuffer _bb, PhantomBattleFourCTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x002CD1C5 File Offset: 0x002CB3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD4D RID: 44365 RVA: 0x002CD1D4 File Offset: 0x002CB3D4
		public PhantomBattleFourCTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600AD4E RID: 44366 RVA: 0x002CD1E4 File Offset: 0x002CB3E4
		public int CardId
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

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x0600AD4F RID: 44367 RVA: 0x002CD220 File Offset: 0x002CB420
		public string CoreDesc
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

		// Token: 0x0600AD50 RID: 44368 RVA: 0x002CD257 File Offset: 0x002CB457
		public Span<byte> GetCoreDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x002CD266 File Offset: 0x002CB466
		public byte[] GetCoreDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0600AD52 RID: 44370 RVA: 0x002CD280 File Offset: 0x002CB480
		public string TaskDesc
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

		// Token: 0x0600AD53 RID: 44371 RVA: 0x002CD2B7 File Offset: 0x002CB4B7
		public Span<byte> GetTaskDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x002CD2C6 File Offset: 0x002CB4C6
		public byte[] GetTaskDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AD55 RID: 44373 RVA: 0x002CD2E0 File Offset: 0x002CB4E0
		public int ConditionList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x0600AD56 RID: 44374 RVA: 0x002CD320 File Offset: 0x002CB520
		public int ConditionListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AD57 RID: 44375 RVA: 0x002CD34C File Offset: 0x002CB54C
		public Span<int> GetConditionListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x002CD35C File Offset: 0x002CB55C
		public int[] GetConditionListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x002CD374 File Offset: 0x002CB574
		public int TaskDescConditionId
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

		// Token: 0x0600AD5A RID: 44378 RVA: 0x002CD3B1 File Offset: 0x002CB5B1
		[NullableContext(1)]
		public int[] ConditionList()
		{
			return this.GetConditionListArray();
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x002CD3B9 File Offset: 0x002CB5B9
		[NullableContext(1)]
		public IEnumerable<int> ConditionListIter()
		{
			PhantomBattleFourCTask.<ConditionListIter>d__26 <ConditionListIter>d__ = new PhantomBattleFourCTask.<ConditionListIter>d__26(-2);
			<ConditionListIter>d__.<>3__<>4__this = this;
			return <ConditionListIter>d__;
		}

		// Token: 0x04005574 RID: 21876
		private Table __p;
	}
}
