using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC2 RID: 3266
	public struct Flow : IFlatbufferObject
	{
		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600754D RID: 30029 RVA: 0x0023FAD1 File Offset: 0x0023DCD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0023FADE File Offset: 0x0023DCDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0023FAE8 File Offset: 0x0023DCE8
		public static Flow GetRootAsFlow(ByteBuffer _bb)
		{
			return Flow.GetRootAsFlow(_bb, default(Flow));
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0023FB04 File Offset: 0x0023DD04
		public static Flow GetRootAsFlow(ByteBuffer _bb, Flow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x0023FB21 File Offset: 0x0023DD21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x0023FB30 File Offset: 0x0023DD30
		public Flow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x0023FB40 File Offset: 0x0023DD40
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x0023FB77 File Offset: 0x0023DD77
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x0023FB86 File Offset: 0x0023DD86
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x0023FBA0 File Offset: 0x0023DDA0
		public int DungeonId
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

		// Token: 0x06007557 RID: 30039 RVA: 0x0023FBDC File Offset: 0x0023DDDC
		public int States(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x0023FC1C File Offset: 0x0023DE1C
		public int StatesLength
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

		// Token: 0x06007559 RID: 30041 RVA: 0x0023FC47 File Offset: 0x0023DE47
		public Span<int> GetStatesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x0023FC56 File Offset: 0x0023DE56
		public int[] GetStatesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x0023FC70 File Offset: 0x0023DE70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StatesIter()或GetStatesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] States()
		{
			Flow flow = this;
			return flow.GetStatesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x0023FC94 File Offset: 0x0023DE94
		[NullableContext(1)]
		public readonly IEnumerable<int> StatesIter()
		{
			Flow.<StatesIter>d__20 <StatesIter>d__ = new Flow.<StatesIter>d__20(-2);
			<StatesIter>d__.<>3__<>4__this = this;
			return <StatesIter>d__;
		}

		// Token: 0x04004D32 RID: 19762
		private Table __p;
	}
}
