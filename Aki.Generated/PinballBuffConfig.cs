using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F23 RID: 3875
	public struct PinballBuffConfig : IFlatbufferObject
	{
		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600AE24 RID: 44580 RVA: 0x002BFF94 File Offset: 0x002BE194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x002BFFA1 File Offset: 0x002BE1A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x002BFFA8 File Offset: 0x002BE1A8
		public static PinballBuffConfig GetRootAsPinballBuffConfig(ByteBuffer _bb)
		{
			return PinballBuffConfig.GetRootAsPinballBuffConfig(_bb, default(PinballBuffConfig));
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x002BFFC4 File Offset: 0x002BE1C4
		public static PinballBuffConfig GetRootAsPinballBuffConfig(ByteBuffer _bb, PinballBuffConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x002BFFE1 File Offset: 0x002BE1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x002BFFF0 File Offset: 0x002BE1F0
		public PinballBuffConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600AE2A RID: 44586 RVA: 0x002C0000 File Offset: 0x002BE200
		public int BuffId
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

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x002C003C File Offset: 0x002BE23C
		public int Sort
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

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600AE2C RID: 44588 RVA: 0x002C0078 File Offset: 0x002BE278
		public string BuffIcon
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

		// Token: 0x0600AE2D RID: 44589 RVA: 0x002C00AF File Offset: 0x002BE2AF
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x002C00BE File Offset: 0x002BE2BE
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600AE2F RID: 44591 RVA: 0x002C00D8 File Offset: 0x002BE2D8
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x002C0110 File Offset: 0x002BE310
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x002C0120 File Offset: 0x002BE320
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600AE32 RID: 44594 RVA: 0x002C0138 File Offset: 0x002BE338
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x002C0170 File Offset: 0x002BE370
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x002C0180 File Offset: 0x002BE380
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x002C0198 File Offset: 0x002BE398
		public string BuffParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600AE36 RID: 44598 RVA: 0x002C01D4 File Offset: 0x002BE3D4
		public int BuffParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x002C0200 File Offset: 0x002BE400
		public int BuffType
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

		// Token: 0x0600AE38 RID: 44600 RVA: 0x002C023D File Offset: 0x002BE43D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffParamIter()或GetBuffParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffParam()
		{
			return this.BuffParamIter().ToArray<string>();
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x002C024A File Offset: 0x002BE44A
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffParamIter()
		{
			PinballBuffConfig.<BuffParamIter>d__30 <BuffParamIter>d__ = new PinballBuffConfig.<BuffParamIter>d__30(-2);
			<BuffParamIter>d__.<>3__<>4__this = this;
			return <BuffParamIter>d__;
		}

		// Token: 0x04004FEC RID: 20460
		private Table __p;
	}
}
