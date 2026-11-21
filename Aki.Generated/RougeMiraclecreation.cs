using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001166 RID: 4454
	public struct RougeMiraclecreation : IFlatbufferObject
	{
		// Token: 0x170034BE RID: 13502
		// (get) Token: 0x0600D3E4 RID: 54244 RVA: 0x00321AB4 File Offset: 0x0031FCB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3E5 RID: 54245 RVA: 0x00321AC1 File Offset: 0x0031FCC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3E6 RID: 54246 RVA: 0x00321AC8 File Offset: 0x0031FCC8
		public static RougeMiraclecreation GetRootAsRougeMiraclecreation(ByteBuffer _bb)
		{
			return RougeMiraclecreation.GetRootAsRougeMiraclecreation(_bb, default(RougeMiraclecreation));
		}

		// Token: 0x0600D3E7 RID: 54247 RVA: 0x00321AE4 File Offset: 0x0031FCE4
		public static RougeMiraclecreation GetRootAsRougeMiraclecreation(ByteBuffer _bb, RougeMiraclecreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x00321B01 File Offset: 0x0031FD01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x00321B10 File Offset: 0x0031FD10
		public RougeMiraclecreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034BF RID: 13503
		// (get) Token: 0x0600D3EA RID: 54250 RVA: 0x00321B20 File Offset: 0x0031FD20
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

		// Token: 0x170034C0 RID: 13504
		// (get) Token: 0x0600D3EB RID: 54251 RVA: 0x00321B5C File Offset: 0x0031FD5C
		public int Category
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

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600D3EC RID: 54252 RVA: 0x00321B98 File Offset: 0x0031FD98
		public int DefaultLevel
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

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600D3ED RID: 54253 RVA: 0x00321BD4 File Offset: 0x0031FDD4
		public int Level
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

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600D3EE RID: 54254 RVA: 0x00321C14 File Offset: 0x0031FE14
		public int MaxLevel
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

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x00321C54 File Offset: 0x0031FE54
		public string Icon
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

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x00321C8C File Offset: 0x0031FE8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D3F1 RID: 54257 RVA: 0x00321C9C File Offset: 0x0031FE9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600D3F2 RID: 54258 RVA: 0x00321CB4 File Offset: 0x0031FEB4
		public string Name
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

		// Token: 0x0600D3F3 RID: 54259 RVA: 0x00321CEC File Offset: 0x0031FEEC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D3F4 RID: 54260 RVA: 0x00321CFC File Offset: 0x0031FEFC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x00321D14 File Offset: 0x0031FF14
		public string BriefDescribe
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

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x00321D4C File Offset: 0x0031FF4C
		public Span<byte> GetBriefDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x00321D5C File Offset: 0x0031FF5C
		public byte[] GetBriefDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x00321D74 File Offset: 0x0031FF74
		public string BriefDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600D3F9 RID: 54265 RVA: 0x00321DB0 File Offset: 0x0031FFB0
		public int BriefDescParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600D3FA RID: 54266 RVA: 0x00321DDC File Offset: 0x0031FFDC
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x00321E14 File Offset: 0x00320014
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x00321E24 File Offset: 0x00320024
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x00321E3C File Offset: 0x0032003C
		public string DescParam(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600D3FE RID: 54270 RVA: 0x00321E78 File Offset: 0x00320078
		public int DescParamLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600D3FF RID: 54271 RVA: 0x00321EA4 File Offset: 0x003200A4
		public string StoryDescribe
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x00321EDC File Offset: 0x003200DC
		public Span<byte> GetStoryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x00321EEC File Offset: 0x003200EC
		public byte[] GetStoryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600D402 RID: 54274 RVA: 0x00321F04 File Offset: 0x00320104
		public int ColorType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x00321F41 File Offset: 0x00320141
		[NullableContext(1)]
		public string[] BriefDescParam()
		{
			return this.BriefDescParamIter().ToArray<string>();
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x00321F4E File Offset: 0x0032014E
		[NullableContext(1)]
		public IEnumerable<string> BriefDescParamIter()
		{
			RougeMiraclecreation.<BriefDescParamIter>d__47 <BriefDescParamIter>d__ = new RougeMiraclecreation.<BriefDescParamIter>d__47(-2);
			<BriefDescParamIter>d__.<>3__<>4__this = this;
			return <BriefDescParamIter>d__;
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x00321F63 File Offset: 0x00320163
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x00321F70 File Offset: 0x00320170
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RougeMiraclecreation.<DescParamIter>d__49 <DescParamIter>d__ = new RougeMiraclecreation.<DescParamIter>d__49(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0400576F RID: 22383
		private Table __p;
	}
}
