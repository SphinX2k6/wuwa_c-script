using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001072 RID: 4210
	public struct RoverRogueBless : IFlatbufferObject
	{
		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600CCFD RID: 52477 RVA: 0x0030453A File Offset: 0x0030273A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCFE RID: 52478 RVA: 0x00304547 File Offset: 0x00302747
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x00304550 File Offset: 0x00302750
		public static RoverRogueBless GetRootAsRoverRogueBless(ByteBuffer _bb)
		{
			return RoverRogueBless.GetRootAsRoverRogueBless(_bb, default(RoverRogueBless));
		}

		// Token: 0x0600CD00 RID: 52480 RVA: 0x0030456C File Offset: 0x0030276C
		public static RoverRogueBless GetRootAsRoverRogueBless(ByteBuffer _bb, RoverRogueBless obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x00304589 File Offset: 0x00302789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD02 RID: 52482 RVA: 0x00304598 File Offset: 0x00302798
		public RoverRogueBless __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600CD03 RID: 52483 RVA: 0x003045A8 File Offset: 0x003027A8
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

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600CD04 RID: 52484 RVA: 0x003045E4 File Offset: 0x003027E4
		public int BlessRoleId
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

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x00304620 File Offset: 0x00302820
		public int SlotId
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

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x0030465C File Offset: 0x0030285C
		public int Quality
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

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600CD07 RID: 52487 RVA: 0x0030469C File Offset: 0x0030289C
		public int Level
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x003046DC File Offset: 0x003028DC
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

		// Token: 0x0600CD09 RID: 52489 RVA: 0x00304714 File Offset: 0x00302914
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x00304724 File Offset: 0x00302924
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x0030473C File Offset: 0x0030293C
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

		// Token: 0x0600CD0C RID: 52492 RVA: 0x00304774 File Offset: 0x00302974
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x00304784 File Offset: 0x00302984
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x0030479C File Offset: 0x0030299C
		public string Params(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600CD0F RID: 52495 RVA: 0x003047D8 File Offset: 0x003029D8
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600CD10 RID: 52496 RVA: 0x00304804 File Offset: 0x00302A04
		public string AdditionText
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

		// Token: 0x0600CD11 RID: 52497 RVA: 0x0030483C File Offset: 0x00302A3C
		public Span<byte> GetAdditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x0030484C File Offset: 0x00302A4C
		public byte[] GetAdditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x00304864 File Offset: 0x00302A64
		public string AdditionParams(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x003048A0 File Offset: 0x00302AA0
		public int AdditionParamsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600CD15 RID: 52501 RVA: 0x003048CC File Offset: 0x00302ACC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x00304904 File Offset: 0x00302B04
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x00304914 File Offset: 0x00302B14
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x0030492C File Offset: 0x00302B2C
		public int NextBlessId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600CD19 RID: 52505 RVA: 0x0030496C File Offset: 0x00302B6C
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x003049AC File Offset: 0x00302BAC
		public string TriggerRoleInfo
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x003049E4 File Offset: 0x00302BE4
		public Span<byte> GetTriggerRoleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x003049F4 File Offset: 0x00302BF4
		public byte[] GetTriggerRoleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x00304A0C File Offset: 0x00302C0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AdditionParamsIter()或GetAdditionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AdditionParams()
		{
			return this.AdditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x00304A19 File Offset: 0x00302C19
		[NullableContext(1)]
		public readonly IEnumerable<string> AdditionParamsIter()
		{
			RoverRogueBless.<AdditionParamsIter>d__49 <AdditionParamsIter>d__ = new RoverRogueBless.<AdditionParamsIter>d__49(-2);
			<AdditionParamsIter>d__.<>3__<>4__this = this;
			return <AdditionParamsIter>d__;
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x00304A2E File Offset: 0x00302C2E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x00304A3B File Offset: 0x00302C3B
		[NullableContext(1)]
		public readonly IEnumerable<string> ParamsIter()
		{
			RoverRogueBless.<ParamsIter>d__51 <ParamsIter>d__ = new RoverRogueBless.<ParamsIter>d__51(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0400517B RID: 20859
		private Table __p;
	}
}
