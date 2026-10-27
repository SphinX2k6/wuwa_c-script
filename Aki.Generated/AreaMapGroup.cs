using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B04 RID: 2820
	public struct AreaMapGroup : IFlatbufferObject
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x001D7D51 File Offset: 0x001D5F51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x001D7D5E File Offset: 0x001D5F5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x001D7D68 File Offset: 0x001D5F68
		public static AreaMapGroup GetRootAsAreaMapGroup(ByteBuffer _bb)
		{
			return AreaMapGroup.GetRootAsAreaMapGroup(_bb, default(AreaMapGroup));
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x001D7D84 File Offset: 0x001D5F84
		public static AreaMapGroup GetRootAsAreaMapGroup(ByteBuffer _bb, AreaMapGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x001D7DA1 File Offset: 0x001D5FA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x001D7DB0 File Offset: 0x001D5FB0
		public AreaMapGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x001D7DC0 File Offset: 0x001D5FC0
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

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x001D7DFC File Offset: 0x001D5FFC
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x001D7E38 File Offset: 0x001D6038
		public PosRectangle? BlockBorder(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new PosRectangle?(default(PosRectangle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x001D7E98 File Offset: 0x001D6098
		public int BlockBorderLength
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

		// Token: 0x060048A2 RID: 18594 RVA: 0x001D7EC4 File Offset: 0x001D60C4
		public int InstanceDungeon(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x001D7F04 File Offset: 0x001D6104
		public int InstanceDungeonLength
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

		// Token: 0x060048A4 RID: 18596 RVA: 0x001D7F30 File Offset: 0x001D6130
		public Span<int> GetInstanceDungeonBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x001D7F40 File Offset: 0x001D6140
		public int[] GetInstanceDungeonArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x001D7F58 File Offset: 0x001D6158
		public int UnlockCondition
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

		// Token: 0x060048A7 RID: 18599 RVA: 0x001D7F95 File Offset: 0x001D6195
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlockBorderIter()或GetBlockBorderBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly PosRectangle[] BlockBorder()
		{
			return this.BlockBorderIter().ToArray<PosRectangle>();
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x001D7FA2 File Offset: 0x001D61A2
		[NullableContext(1)]
		public readonly IEnumerable<PosRectangle> BlockBorderIter()
		{
			AreaMapGroup.<BlockBorderIter>d__23 <BlockBorderIter>d__ = new AreaMapGroup.<BlockBorderIter>d__23(-2);
			<BlockBorderIter>d__.<>3__<>4__this = this;
			return <BlockBorderIter>d__;
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x001D7FB8 File Offset: 0x001D61B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstanceDungeonIter()或GetInstanceDungeonBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InstanceDungeon()
		{
			AreaMapGroup areaMapGroup = this;
			return areaMapGroup.GetInstanceDungeonArray() ?? Array.Empty<int>();
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x001D7FDC File Offset: 0x001D61DC
		[NullableContext(1)]
		public readonly IEnumerable<int> InstanceDungeonIter()
		{
			AreaMapGroup.<InstanceDungeonIter>d__25 <InstanceDungeonIter>d__ = new AreaMapGroup.<InstanceDungeonIter>d__25(-2);
			<InstanceDungeonIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonIter>d__;
		}

		// Token: 0x04004AE9 RID: 19177
		private Table __p;
	}
}
