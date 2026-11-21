using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBD RID: 3773
	public struct LongPressConfig : IFlatbufferObject
	{
		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x00298BF1 File Offset: 0x00296DF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x00298BFE File Offset: 0x00296DFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x00298C08 File Offset: 0x00296E08
		public static LongPressConfig GetRootAsLongPressConfig(ByteBuffer _bb)
		{
			return LongPressConfig.GetRootAsLongPressConfig(_bb, default(LongPressConfig));
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x00298C24 File Offset: 0x00296E24
		public static LongPressConfig GetRootAsLongPressConfig(ByteBuffer _bb, LongPressConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00298C41 File Offset: 0x00296E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x00298C50 File Offset: 0x00296E50
		public LongPressConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x00298C60 File Offset: 0x00296E60
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

		// Token: 0x06009570 RID: 38256 RVA: 0x00298C9C File Offset: 0x00296E9C
		public int PressTime(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x00298CDC File Offset: 0x00296EDC
		public int PressTimeLength
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

		// Token: 0x06009572 RID: 38258 RVA: 0x00298D07 File Offset: 0x00296F07
		public Span<int> GetPressTimeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x00298D16 File Offset: 0x00296F16
		public int[] GetPressTimeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x00298D30 File Offset: 0x00296F30
		public int TriggerTime(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x00298D70 File Offset: 0x00296F70
		public int TriggerTimeLength
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

		// Token: 0x06009576 RID: 38262 RVA: 0x00298D9B File Offset: 0x00296F9B
		public Span<int> GetTriggerTimeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x00298DAA File Offset: 0x00296FAA
		public int[] GetTriggerTimeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06009578 RID: 38264 RVA: 0x00298DC4 File Offset: 0x00296FC4
		public int AudioIntervalLimit
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

		// Token: 0x06009579 RID: 38265 RVA: 0x00298E01 File Offset: 0x00297001
		[NullableContext(1)]
		public int[] PressTime()
		{
			return this.GetPressTimeArray();
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x00298E09 File Offset: 0x00297009
		[NullableContext(1)]
		public IEnumerable<int> PressTimeIter()
		{
			LongPressConfig.<PressTimeIter>d__23 <PressTimeIter>d__ = new LongPressConfig.<PressTimeIter>d__23(-2);
			<PressTimeIter>d__.<>3__<>4__this = this;
			return <PressTimeIter>d__;
		}

		// Token: 0x0600957B RID: 38267 RVA: 0x00298E1E File Offset: 0x0029701E
		[NullableContext(1)]
		public int[] TriggerTime()
		{
			return this.GetTriggerTimeArray();
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x00298E26 File Offset: 0x00297026
		[NullableContext(1)]
		public IEnumerable<int> TriggerTimeIter()
		{
			LongPressConfig.<TriggerTimeIter>d__25 <TriggerTimeIter>d__ = new LongPressConfig.<TriggerTimeIter>d__25(-2);
			<TriggerTimeIter>d__.<>3__<>4__this = this;
			return <TriggerTimeIter>d__;
		}

		// Token: 0x04005458 RID: 21592
		private Table __p;
	}
}
