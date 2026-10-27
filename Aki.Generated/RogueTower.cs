using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001026 RID: 4134
	public struct RogueTower : IFlatbufferObject
	{
		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600C55C RID: 50524 RVA: 0x002F2F15 File Offset: 0x002F1115
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C55D RID: 50525 RVA: 0x002F2F22 File Offset: 0x002F1122
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C55E RID: 50526 RVA: 0x002F2F2C File Offset: 0x002F112C
		public static RogueTower GetRootAsRogueTower(ByteBuffer _bb)
		{
			return RogueTower.GetRootAsRogueTower(_bb, default(RogueTower));
		}

		// Token: 0x0600C55F RID: 50527 RVA: 0x002F2F48 File Offset: 0x002F1148
		public static RogueTower GetRootAsRogueTower(ByteBuffer _bb, RogueTower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C560 RID: 50528 RVA: 0x002F2F65 File Offset: 0x002F1165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C561 RID: 50529 RVA: 0x002F2F74 File Offset: 0x002F1174
		public RogueTower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600C562 RID: 50530 RVA: 0x002F2F84 File Offset: 0x002F1184
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

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600C563 RID: 50531 RVA: 0x002F2FC0 File Offset: 0x002F11C0
		public int InstId
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

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600C564 RID: 50532 RVA: 0x002F2FFC File Offset: 0x002F11FC
		public int SortId
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

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600C565 RID: 50533 RVA: 0x002F3038 File Offset: 0x002F1238
		public int MaxLevel
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

		// Token: 0x0600C566 RID: 50534 RVA: 0x002F3078 File Offset: 0x002F1278
		public int Buffs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600C567 RID: 50535 RVA: 0x002F30B8 File Offset: 0x002F12B8
		public int BuffsLength
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

		// Token: 0x0600C568 RID: 50536 RVA: 0x002F30E4 File Offset: 0x002F12E4
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C569 RID: 50537 RVA: 0x002F30F4 File Offset: 0x002F12F4
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x002F310C File Offset: 0x002F130C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x002F3144 File Offset: 0x002F1344
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x002F3154 File Offset: 0x002F1354
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600C56D RID: 50541 RVA: 0x002F316C File Offset: 0x002F136C
		public string Stand
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C56E RID: 50542 RVA: 0x002F31A4 File Offset: 0x002F13A4
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x002F31B4 File Offset: 0x002F13B4
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600C570 RID: 50544 RVA: 0x002F31CC File Offset: 0x002F13CC
		public string PreviewIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C571 RID: 50545 RVA: 0x002F3204 File Offset: 0x002F1404
		public Span<byte> GetPreviewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C572 RID: 50546 RVA: 0x002F3214 File Offset: 0x002F1414
		public byte[] GetPreviewIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x002F322C File Offset: 0x002F142C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffsIter()或GetBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Buffs()
		{
			RogueTower rogueTower = this;
			return rogueTower.GetBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x002F3250 File Offset: 0x002F1450
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffsIter()
		{
			RogueTower.<BuffsIter>d__34 <BuffsIter>d__ = new RogueTower.<BuffsIter>d__34(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04005119 RID: 20761
		private Table __p;
	}
}
