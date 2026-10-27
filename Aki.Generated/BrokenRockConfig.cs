using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B50 RID: 2896
	public struct BrokenRockConfig : IFlatbufferObject
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x001E8E75 File Offset: 0x001E7075
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x001E8E82 File Offset: 0x001E7082
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x001E8E8C File Offset: 0x001E708C
		public static BrokenRockConfig GetRootAsBrokenRockConfig(ByteBuffer _bb)
		{
			return BrokenRockConfig.GetRootAsBrokenRockConfig(_bb, default(BrokenRockConfig));
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x001E8EA8 File Offset: 0x001E70A8
		public static BrokenRockConfig GetRootAsBrokenRockConfig(ByteBuffer _bb, BrokenRockConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x001E8EC5 File Offset: 0x001E70C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x001E8ED4 File Offset: 0x001E70D4
		public BrokenRockConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x001E8EE4 File Offset: 0x001E70E4
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06004FCB RID: 20427 RVA: 0x001E8F20 File Offset: 0x001E7120
		public string EntityUid
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

		// Token: 0x06004FCC RID: 20428 RVA: 0x001E8F57 File Offset: 0x001E7157
		public Span<byte> GetEntityUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x001E8F66 File Offset: 0x001E7166
		public byte[] GetEntityUidArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x001E8F80 File Offset: 0x001E7180
		public int Rings(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x001E8FC0 File Offset: 0x001E71C0
		public int RingsLength
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

		// Token: 0x06004FD0 RID: 20432 RVA: 0x001E8FEB File Offset: 0x001E71EB
		public Span<int> GetRingsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x001E8FFA File Offset: 0x001E71FA
		public int[] GetRingsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x001E9014 File Offset: 0x001E7214
		public int ScoreMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x001E9054 File Offset: 0x001E7254
		public int ScoreUp
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

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x001E9094 File Offset: 0x001E7294
		public int ScoreDown
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 20;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x001E90D4 File Offset: 0x001E72D4
		public int GlobalTime
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

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x001E9114 File Offset: 0x001E7314
		public int NormalSkill
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x001E9154 File Offset: 0x001E7354
		public int FinishSkill
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

		// Token: 0x06004FD8 RID: 20440 RVA: 0x001E9194 File Offset: 0x001E7394
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RingsIter()或GetRingsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Rings()
		{
			BrokenRockConfig brokenRockConfig = this;
			return brokenRockConfig.GetRingsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x001E91B8 File Offset: 0x001E73B8
		[NullableContext(1)]
		public readonly IEnumerable<int> RingsIter()
		{
			BrokenRockConfig.<RingsIter>d__32 <RingsIter>d__ = new BrokenRockConfig.<RingsIter>d__32(-2);
			<RingsIter>d__.<>3__<>4__this = this;
			return <RingsIter>d__;
		}

		// Token: 0x04004B4B RID: 19275
		private Table __p;
	}
}
