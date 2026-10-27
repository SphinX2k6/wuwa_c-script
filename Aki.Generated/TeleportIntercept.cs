using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111B RID: 4379
	public struct TeleportIntercept : IFlatbufferObject
	{
		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x0032A820 File Offset: 0x00328A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x0032A82D File Offset: 0x00328A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x0032A834 File Offset: 0x00328A34
		public static TeleportIntercept GetRootAsTeleportIntercept(ByteBuffer _bb)
		{
			return TeleportIntercept.GetRootAsTeleportIntercept(_bb, default(TeleportIntercept));
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x0032A850 File Offset: 0x00328A50
		public static TeleportIntercept GetRootAsTeleportIntercept(ByteBuffer _bb, TeleportIntercept obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x0032A86D File Offset: 0x00328A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x0032A87C File Offset: 0x00328A7C
		public TeleportIntercept __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600DD53 RID: 56659 RVA: 0x0032A88C File Offset: 0x00328A8C
		public int InterceptId
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

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600DD54 RID: 56660 RVA: 0x0032A8C8 File Offset: 0x00328AC8
		public int EntityConfigId
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

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x0032A904 File Offset: 0x00328B04
		public int Type
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

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600DD56 RID: 56662 RVA: 0x0032A940 File Offset: 0x00328B40
		public int OptionIndex
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

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x0032A980 File Offset: 0x00328B80
		public int CurInstConfigId
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

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600DD58 RID: 56664 RVA: 0x0032A9C0 File Offset: 0x00328BC0
		public int TargetMapConfigId
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

		// Token: 0x0600DD59 RID: 56665 RVA: 0x0032AA00 File Offset: 0x00328C00
		public int TargetPosition(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600DD5A RID: 56666 RVA: 0x0032AA40 File Offset: 0x00328C40
		public int TargetPositionLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DD5B RID: 56667 RVA: 0x0032AA6C File Offset: 0x00328C6C
		public Span<int> GetTargetPositionBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x0032AA7C File Offset: 0x00328C7C
		public int[] GetTargetPositionArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x0032AA94 File Offset: 0x00328C94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetPositionIter()或GetTargetPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TargetPosition()
		{
			TeleportIntercept teleportIntercept = this;
			return teleportIntercept.GetTargetPositionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DD5E RID: 56670 RVA: 0x0032AAB8 File Offset: 0x00328CB8
		[NullableContext(1)]
		public readonly IEnumerable<int> TargetPositionIter()
		{
			TeleportIntercept.<TargetPositionIter>d__26 <TargetPositionIter>d__ = new TeleportIntercept.<TargetPositionIter>d__26(-2);
			<TargetPositionIter>d__.<>3__<>4__this = this;
			return <TargetPositionIter>d__;
		}

		// Token: 0x04005258 RID: 21080
		private Table __p;
	}
}
