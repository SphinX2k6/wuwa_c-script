using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAF RID: 2991
	public struct DaemonHackConfigCsv : IFlatbufferObject
	{
		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06005ABC RID: 23228 RVA: 0x00202A00 File Offset: 0x00200C00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00202A0D File Offset: 0x00200C0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00202A14 File Offset: 0x00200C14
		public static DaemonHackConfigCsv GetRootAsDaemonHackConfigCsv(ByteBuffer _bb)
		{
			return DaemonHackConfigCsv.GetRootAsDaemonHackConfigCsv(_bb, default(DaemonHackConfigCsv));
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x00202A30 File Offset: 0x00200C30
		public static DaemonHackConfigCsv GetRootAsDaemonHackConfigCsv(ByteBuffer _bb, DaemonHackConfigCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x00202A4D File Offset: 0x00200C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00202A5C File Offset: 0x00200C5C
		public DaemonHackConfigCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x00202A6C File Offset: 0x00200C6C
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

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x00202AA8 File Offset: 0x00200CA8
		public string CodeMap
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

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00202ADF File Offset: 0x00200CDF
		public Span<byte> GetCodeMapBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00202AEE File Offset: 0x00200CEE
		public byte[] GetCodeMapArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x00202B08 File Offset: 0x00200D08
		public string CodeMatrix
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

		// Token: 0x06005AC7 RID: 23239 RVA: 0x00202B3F File Offset: 0x00200D3F
		public Span<byte> GetCodeMatrixBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x00202B4E File Offset: 0x00200D4E
		public byte[] GetCodeMatrixArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x00202B68 File Offset: 0x00200D68
		public int CodeBufferSize
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

		// Token: 0x06005ACA RID: 23242 RVA: 0x00202BA8 File Offset: 0x00200DA8
		public string TargetCodes(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06005ACB RID: 23243 RVA: 0x00202BE4 File Offset: 0x00200DE4
		public int TargetCodesLength
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

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00202C10 File Offset: 0x00200E10
		public int CountDown
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x00202C50 File Offset: 0x00200E50
		public int FailThreshold
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

		// Token: 0x06005ACE RID: 23246 RVA: 0x00202C8D File Offset: 0x00200E8D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetCodesIter()或GetTargetCodesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TargetCodes()
		{
			return this.TargetCodesIter().ToArray<string>();
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00202C9A File Offset: 0x00200E9A
		[NullableContext(1)]
		public readonly IEnumerable<string> TargetCodesIter()
		{
			DaemonHackConfigCsv.<TargetCodesIter>d__28 <TargetCodesIter>d__ = new DaemonHackConfigCsv.<TargetCodesIter>d__28(-2);
			<TargetCodesIter>d__.<>3__<>4__this = this;
			return <TargetCodesIter>d__;
		}

		// Token: 0x04004BD2 RID: 19410
		private Table __p;
	}
}
