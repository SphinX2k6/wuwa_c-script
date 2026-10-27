using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4F RID: 3663
	public struct MotorFightTalent : IFlatbufferObject
	{
		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06009965 RID: 39269 RVA: 0x00291355 File Offset: 0x0028F555
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00291362 File Offset: 0x0028F562
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x0029136C File Offset: 0x0028F56C
		public static MotorFightTalent GetRootAsMotorFightTalent(ByteBuffer _bb)
		{
			return MotorFightTalent.GetRootAsMotorFightTalent(_bb, default(MotorFightTalent));
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00291388 File Offset: 0x0028F588
		public static MotorFightTalent GetRootAsMotorFightTalent(ByteBuffer _bb, MotorFightTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x002913A5 File Offset: 0x0028F5A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x002913B4 File Offset: 0x0028F5B4
		public MotorFightTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x002913C4 File Offset: 0x0028F5C4
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

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x00291400 File Offset: 0x0028F600
		public int ActivityId
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

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600996D RID: 39277 RVA: 0x0029143C File Offset: 0x0028F63C
		public int UnlockCondition
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

		// Token: 0x0600996E RID: 39278 RVA: 0x00291478 File Offset: 0x0028F678
		public int PreNode(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600996F RID: 39279 RVA: 0x002914B8 File Offset: 0x0028F6B8
		public int PreNodeLength
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

		// Token: 0x06009970 RID: 39280 RVA: 0x002914E4 File Offset: 0x0028F6E4
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x002914F4 File Offset: 0x0028F6F4
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x0029150C File Offset: 0x0028F70C
		public int Consume
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

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06009973 RID: 39283 RVA: 0x0029154C File Offset: 0x0028F74C
		public int Effect
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

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06009974 RID: 39284 RVA: 0x0029158C File Offset: 0x0028F78C
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

		// Token: 0x06009975 RID: 39285 RVA: 0x002915C4 File Offset: 0x0028F7C4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x002915D4 File Offset: 0x0028F7D4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06009977 RID: 39287 RVA: 0x002915EC File Offset: 0x0028F7EC
		public string Desc
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

		// Token: 0x06009978 RID: 39288 RVA: 0x00291624 File Offset: 0x0028F824
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00291634 File Offset: 0x0028F834
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x0029164C File Offset: 0x0028F84C
		public string DescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x00291688 File Offset: 0x0028F888
		public int DescParamLength
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

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600997C RID: 39292 RVA: 0x002916B4 File Offset: 0x0028F8B4
		public int Column
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600997D RID: 39293 RVA: 0x002916F4 File Offset: 0x0028F8F4
		public int Row
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x0600997E RID: 39294 RVA: 0x00291734 File Offset: 0x0028F934
		public string Icon
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

		// Token: 0x0600997F RID: 39295 RVA: 0x0029176C File Offset: 0x0028F96C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x0029177C File Offset: 0x0028F97C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x00291794 File Offset: 0x0028F994
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x002917A1 File Offset: 0x0028F9A1
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			MotorFightTalent.<DescParamIter>d__43 <DescParamIter>d__ = new MotorFightTalent.<DescParamIter>d__43(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x002917B8 File Offset: 0x0028F9B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			MotorFightTalent motorFightTalent = this;
			return motorFightTalent.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x002917DC File Offset: 0x0028F9DC
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			MotorFightTalent.<PreNodeIter>d__45 <PreNodeIter>d__ = new MotorFightTalent.<PreNodeIter>d__45(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x04004EF8 RID: 20216
		private Table __p;
	}
}
