using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFC RID: 3580
	public struct MatchThreeEnviroment : IFlatbufferObject
	{
		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x00281CB9 File Offset: 0x0027FEB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00281CC6 File Offset: 0x0027FEC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00281CD0 File Offset: 0x0027FED0
		public static MatchThreeEnviroment GetRootAsMatchThreeEnviroment(ByteBuffer _bb)
		{
			return MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(_bb, default(MatchThreeEnviroment));
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00281CEC File Offset: 0x0027FEEC
		public static MatchThreeEnviroment GetRootAsMatchThreeEnviroment(ByteBuffer _bb, MatchThreeEnviroment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00281D09 File Offset: 0x0027FF09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x00281D18 File Offset: 0x0027FF18
		public MatchThreeEnviroment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x00281D28 File Offset: 0x0027FF28
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

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600928C RID: 37516 RVA: 0x00281D64 File Offset: 0x0027FF64
		public int Type
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

		// Token: 0x0600928D RID: 37517 RVA: 0x00281DA0 File Offset: 0x0027FFA0
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600928E RID: 37518 RVA: 0x00281DE0 File Offset: 0x0027FFE0
		public int ParamsLength
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

		// Token: 0x0600928F RID: 37519 RVA: 0x00281E0B File Offset: 0x0028000B
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x00281E1A File Offset: 0x0028001A
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06009291 RID: 37521 RVA: 0x00281E34 File Offset: 0x00280034
		public string Tip
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

		// Token: 0x06009292 RID: 37522 RVA: 0x00281E6C File Offset: 0x0028006C
		public Span<byte> GetTipBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00281E7C File Offset: 0x0028007C
		public byte[] GetTipArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x00281E94 File Offset: 0x00280094
		public string Name
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

		// Token: 0x06009295 RID: 37525 RVA: 0x00281ECC File Offset: 0x002800CC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x00281EDC File Offset: 0x002800DC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x00281EF4 File Offset: 0x002800F4
		public string Description
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

		// Token: 0x06009298 RID: 37528 RVA: 0x00281F2C File Offset: 0x0028012C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x00281F3C File Offset: 0x0028013C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x00281F54 File Offset: 0x00280154
		public string Comment
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

		// Token: 0x0600929B RID: 37531 RVA: 0x00281F8C File Offset: 0x0028018C
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600929C RID: 37532 RVA: 0x00281F9C File Offset: 0x0028019C
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600929D RID: 37533 RVA: 0x00281FB4 File Offset: 0x002801B4
		public int SortId
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

		// Token: 0x0600929E RID: 37534 RVA: 0x00281FF4 File Offset: 0x002801F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			MatchThreeEnviroment matchThreeEnviroment = this;
			return matchThreeEnviroment.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600929F RID: 37535 RVA: 0x00282018 File Offset: 0x00280218
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			MatchThreeEnviroment.<ParamsIter>d__36 <ParamsIter>d__ = new MatchThreeEnviroment.<ParamsIter>d__36(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004E9C RID: 20124
		private Table __p;
	}
}
