using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001159 RID: 4441
	public struct TrapDefenseBdBuff : IFlatbufferObject
	{
		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x0600E29D RID: 58013 RVA: 0x00336774 File Offset: 0x00334974
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x00336781 File Offset: 0x00334981
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x00336788 File Offset: 0x00334988
		public static TrapDefenseBdBuff GetRootAsTrapDefenseBdBuff(ByteBuffer _bb)
		{
			return TrapDefenseBdBuff.GetRootAsTrapDefenseBdBuff(_bb, default(TrapDefenseBdBuff));
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x003367A4 File Offset: 0x003349A4
		public static TrapDefenseBdBuff GetRootAsTrapDefenseBdBuff(ByteBuffer _bb, TrapDefenseBdBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x003367C1 File Offset: 0x003349C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x003367D0 File Offset: 0x003349D0
		public TrapDefenseBdBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x003367E0 File Offset: 0x003349E0
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

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x0600E2A4 RID: 58020 RVA: 0x0033681C File Offset: 0x00334A1C
		public int Level
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

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x00336858 File Offset: 0x00334A58
		public int GroupId
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

		// Token: 0x0600E2A6 RID: 58022 RVA: 0x00336894 File Offset: 0x00334A94
		public int Gainings(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x003368D4 File Offset: 0x00334AD4
		public int GainingsLength
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

		// Token: 0x0600E2A8 RID: 58024 RVA: 0x00336900 File Offset: 0x00334B00
		public Span<int> GetGainingsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x00336910 File Offset: 0x00334B10
		public int[] GetGainingsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600E2AA RID: 58026 RVA: 0x00336928 File Offset: 0x00334B28
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

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00336960 File Offset: 0x00334B60
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E2AC RID: 58028 RVA: 0x00336970 File Offset: 0x00334B70
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x00336988 File Offset: 0x00334B88
		public string Desc
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

		// Token: 0x0600E2AE RID: 58030 RVA: 0x003369C0 File Offset: 0x00334BC0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E2AF RID: 58031 RVA: 0x003369D0 File Offset: 0x00334BD0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E2B0 RID: 58032 RVA: 0x003369E8 File Offset: 0x00334BE8
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x00336A24 File Offset: 0x00334C24
		public int DescArgsLength
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

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600E2B2 RID: 58034 RVA: 0x00336A50 File Offset: 0x00334C50
		public string Icon
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

		// Token: 0x0600E2B3 RID: 58035 RVA: 0x00336A88 File Offset: 0x00334C88
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E2B4 RID: 58036 RVA: 0x00336A98 File Offset: 0x00334C98
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x00336AB0 File Offset: 0x00334CB0
		public string SubIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x00336AE8 File Offset: 0x00334CE8
		public Span<byte> GetSubIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x00336AF8 File Offset: 0x00334CF8
		public byte[] GetSubIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E2B8 RID: 58040 RVA: 0x00336B10 File Offset: 0x00334D10
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x00336B1D File Offset: 0x00334D1D
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			TrapDefenseBdBuff.<DescArgsIter>d__39 <DescArgsIter>d__ = new TrapDefenseBdBuff.<DescArgsIter>d__39(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x00336B34 File Offset: 0x00334D34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GainingsIter()或GetGainingsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Gainings()
		{
			TrapDefenseBdBuff trapDefenseBdBuff = this;
			return trapDefenseBdBuff.GetGainingsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x00336B58 File Offset: 0x00334D58
		[NullableContext(1)]
		public readonly IEnumerable<int> GainingsIter()
		{
			TrapDefenseBdBuff.<GainingsIter>d__41 <GainingsIter>d__ = new TrapDefenseBdBuff.<GainingsIter>d__41(-2);
			<GainingsIter>d__.<>3__<>4__this = this;
			return <GainingsIter>d__;
		}

		// Token: 0x0400529E RID: 21150
		private Table __p;
	}
}
