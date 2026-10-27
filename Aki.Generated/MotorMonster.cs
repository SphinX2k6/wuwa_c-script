using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5D RID: 3677
	public struct MotorMonster : IFlatbufferObject
	{
		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06009AF1 RID: 39665 RVA: 0x00294C2A File Offset: 0x00292E2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x00294C37 File Offset: 0x00292E37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x00294C40 File Offset: 0x00292E40
		public static MotorMonster GetRootAsMotorMonster(ByteBuffer _bb)
		{
			return MotorMonster.GetRootAsMotorMonster(_bb, default(MotorMonster));
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x00294C5C File Offset: 0x00292E5C
		public static MotorMonster GetRootAsMotorMonster(ByteBuffer _bb, MotorMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x00294C79 File Offset: 0x00292E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x00294C88 File Offset: 0x00292E88
		public MotorMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x00294C98 File Offset: 0x00292E98
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

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06009AF8 RID: 39672 RVA: 0x00294CD4 File Offset: 0x00292ED4
		public int MonsterTemptId
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

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x00294D10 File Offset: 0x00292F10
		public int AttrConfig
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

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06009AFA RID: 39674 RVA: 0x00294D4C File Offset: 0x00292F4C
		public int Height
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

		// Token: 0x06009AFB RID: 39675 RVA: 0x00294D8C File Offset: 0x00292F8C
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06009AFC RID: 39676 RVA: 0x00294DCC File Offset: 0x00292FCC
		public int BornBuffLength
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

		// Token: 0x06009AFD RID: 39677 RVA: 0x00294DF8 File Offset: 0x00292FF8
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x00294E08 File Offset: 0x00293008
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x00294E20 File Offset: 0x00293020
		public int SplineId
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

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06009B00 RID: 39680 RVA: 0x00294E60 File Offset: 0x00293060
		public string Desc
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

		// Token: 0x06009B01 RID: 39681 RVA: 0x00294E98 File Offset: 0x00293098
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00294EA8 File Offset: 0x002930A8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x00294EC0 File Offset: 0x002930C0
		public string TextureIcon
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

		// Token: 0x06009B04 RID: 39684 RVA: 0x00294EF8 File Offset: 0x002930F8
		public Span<byte> GetTextureIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x00294F08 File Offset: 0x00293108
		public byte[] GetTextureIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x00294F20 File Offset: 0x00293120
		public int MonsterGroup
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

		// Token: 0x06009B07 RID: 39687 RVA: 0x00294F60 File Offset: 0x00293160
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffIter()或GetBornBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornBuff()
		{
			MotorMonster motorMonster = this;
			return motorMonster.GetBornBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x00294F84 File Offset: 0x00293184
		[NullableContext(1)]
		public readonly IEnumerable<int> BornBuffIter()
		{
			MotorMonster.<BornBuffIter>d__34 <BornBuffIter>d__ = new MotorMonster.<BornBuffIter>d__34(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x04004F09 RID: 20233
		private Table __p;
	}
}
