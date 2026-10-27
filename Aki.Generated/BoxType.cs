using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4C RID: 2892
	public struct BoxType : IFlatbufferObject
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06004F7B RID: 20347 RVA: 0x001E84F5 File Offset: 0x001E66F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x001E8502 File Offset: 0x001E6702
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x001E850C File Offset: 0x001E670C
		public static BoxType GetRootAsBoxType(ByteBuffer _bb)
		{
			return BoxType.GetRootAsBoxType(_bb, default(BoxType));
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x001E8528 File Offset: 0x001E6728
		public static BoxType GetRootAsBoxType(ByteBuffer _bb, BoxType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x001E8545 File Offset: 0x001E6745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x001E8554 File Offset: 0x001E6754
		public BoxType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x001E8564 File Offset: 0x001E6764
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x001E85A0 File Offset: 0x001E67A0
		public string Mark
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

		// Token: 0x06004F83 RID: 20355 RVA: 0x001E85D7 File Offset: 0x001E67D7
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x001E85E6 File Offset: 0x001E67E6
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x001E8600 File Offset: 0x001E6800
		public int StartState
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

		// Token: 0x06004F86 RID: 20358 RVA: 0x001E863C File Offset: 0x001E683C
		public int IdleState(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x001E867C File Offset: 0x001E687C
		public int IdleStateLength
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

		// Token: 0x06004F88 RID: 20360 RVA: 0x001E86A8 File Offset: 0x001E68A8
		public Span<int> GetIdleStateBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x001E86B8 File Offset: 0x001E68B8
		public int[] GetIdleStateArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x001E86D0 File Offset: 0x001E68D0
		public int IdleStartState(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x001E8710 File Offset: 0x001E6910
		public int IdleStartStateLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x001E873C File Offset: 0x001E693C
		public Span<int> GetIdleStartStateBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x001E874C File Offset: 0x001E694C
		public int[] GetIdleStartStateArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x001E8764 File Offset: 0x001E6964
		public int DeathState
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x001E87A4 File Offset: 0x001E69A4
		public float OpenTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x001E87E8 File Offset: 0x001E69E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IdleStartStateIter()或GetIdleStartStateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IdleStartState()
		{
			BoxType boxType = this;
			return boxType.GetIdleStartStateArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x001E880C File Offset: 0x001E6A0C
		[NullableContext(1)]
		public readonly IEnumerable<int> IdleStartStateIter()
		{
			BoxType.<IdleStartStateIter>d__31 <IdleStartStateIter>d__ = new BoxType.<IdleStartStateIter>d__31(-2);
			<IdleStartStateIter>d__.<>3__<>4__this = this;
			return <IdleStartStateIter>d__;
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x001E8824 File Offset: 0x001E6A24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IdleStateIter()或GetIdleStateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IdleState()
		{
			BoxType boxType = this;
			return boxType.GetIdleStateArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x001E8848 File Offset: 0x001E6A48
		[NullableContext(1)]
		public readonly IEnumerable<int> IdleStateIter()
		{
			BoxType.<IdleStateIter>d__33 <IdleStateIter>d__ = new BoxType.<IdleStateIter>d__33(-2);
			<IdleStateIter>d__.<>3__<>4__this = this;
			return <IdleStateIter>d__;
		}

		// Token: 0x04004B47 RID: 19271
		private Table __p;
	}
}
