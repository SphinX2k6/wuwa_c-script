using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F42 RID: 3906
	public struct MotorMonster : IFlatbufferObject
	{
		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600A111 RID: 41233 RVA: 0x002B25F6 File Offset: 0x002B07F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x002B2603 File Offset: 0x002B0803
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x002B260C File Offset: 0x002B080C
		public static MotorMonster GetRootAsMotorMonster(ByteBuffer _bb)
		{
			return MotorMonster.GetRootAsMotorMonster(_bb, default(MotorMonster));
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x002B2628 File Offset: 0x002B0828
		public static MotorMonster GetRootAsMotorMonster(ByteBuffer _bb, MotorMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x002B2645 File Offset: 0x002B0845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x002B2654 File Offset: 0x002B0854
		public MotorMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600A117 RID: 41239 RVA: 0x002B2664 File Offset: 0x002B0864
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

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x002B26A0 File Offset: 0x002B08A0
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

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x002B26DC File Offset: 0x002B08DC
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

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x002B2718 File Offset: 0x002B0918
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

		// Token: 0x0600A11B RID: 41243 RVA: 0x002B2758 File Offset: 0x002B0958
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x002B2798 File Offset: 0x002B0998
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

		// Token: 0x0600A11D RID: 41245 RVA: 0x002B27C4 File Offset: 0x002B09C4
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x002B27D4 File Offset: 0x002B09D4
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600A11F RID: 41247 RVA: 0x002B27EC File Offset: 0x002B09EC
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

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x002B282C File Offset: 0x002B0A2C
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

		// Token: 0x0600A121 RID: 41249 RVA: 0x002B2864 File Offset: 0x002B0A64
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x002B2874 File Offset: 0x002B0A74
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0600A123 RID: 41251 RVA: 0x002B288C File Offset: 0x002B0A8C
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

		// Token: 0x0600A124 RID: 41252 RVA: 0x002B28C4 File Offset: 0x002B0AC4
		public Span<byte> GetTextureIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x002B28D4 File Offset: 0x002B0AD4
		public byte[] GetTextureIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x002B28EC File Offset: 0x002B0AEC
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

		// Token: 0x0600A127 RID: 41255 RVA: 0x002B2929 File Offset: 0x002B0B29
		[NullableContext(1)]
		public int[] BornBuff()
		{
			return this.GetBornBuffArray();
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x002B2931 File Offset: 0x002B0B31
		[NullableContext(1)]
		public IEnumerable<int> BornBuffIter()
		{
			MotorMonster.<BornBuffIter>d__34 <BornBuffIter>d__ = new MotorMonster.<BornBuffIter>d__34(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x040054EE RID: 21742
		private Table __p;
	}
}
