using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110F RID: 4367
	public struct RogueTowerBuff : IFlatbufferObject
	{
		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x0030F211 File Offset: 0x0030D411
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x0030F21E File Offset: 0x0030D41E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x0030F228 File Offset: 0x0030D428
		public static RogueTowerBuff GetRootAsRogueTowerBuff(ByteBuffer _bb)
		{
			return RogueTowerBuff.GetRootAsRogueTowerBuff(_bb, default(RogueTowerBuff));
		}

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x0030F244 File Offset: 0x0030D444
		public static RogueTowerBuff GetRootAsRogueTowerBuff(ByteBuffer _bb, RogueTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x0030F261 File Offset: 0x0030D461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBC4 RID: 52164 RVA: 0x0030F270 File Offset: 0x0030D470
		public RogueTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600CBC5 RID: 52165 RVA: 0x0030F280 File Offset: 0x0030D480
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

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600CBC6 RID: 52166 RVA: 0x0030F2BC File Offset: 0x0030D4BC
		public string Icon
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

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x0030F2F3 File Offset: 0x0030D4F3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x0030F302 File Offset: 0x0030D502
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600CBC9 RID: 52169 RVA: 0x0030F31C File Offset: 0x0030D51C
		public string Name
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

		// Token: 0x0600CBCA RID: 52170 RVA: 0x0030F353 File Offset: 0x0030D553
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x0030F362 File Offset: 0x0030D562
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600CBCC RID: 52172 RVA: 0x0030F37C File Offset: 0x0030D57C
		public string Describe
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

		// Token: 0x0600CBCD RID: 52173 RVA: 0x0030F3B4 File Offset: 0x0030D5B4
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CBCE RID: 52174 RVA: 0x0030F3C4 File Offset: 0x0030D5C4
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBCF RID: 52175 RVA: 0x0030F3DC File Offset: 0x0030D5DC
		public string DescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600CBD0 RID: 52176 RVA: 0x0030F418 File Offset: 0x0030D618
		public int DescParamLength
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

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600CBD1 RID: 52177 RVA: 0x0030F444 File Offset: 0x0030D644
		public string BriefDesc
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

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x0030F47C File Offset: 0x0030D67C
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x0030F48C File Offset: 0x0030D68C
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x0030F4A4 File Offset: 0x0030D6A4
		public string BriefDescParam(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600CBD5 RID: 52181 RVA: 0x0030F4E0 File Offset: 0x0030D6E0
		public int BriefDescParamLength
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

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x0030F50C File Offset: 0x0030D70C
		[NullableContext(1)]
		public string[] BriefDescParam()
		{
			return this.BriefDescParamIter().ToArray<string>();
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x0030F519 File Offset: 0x0030D719
		[NullableContext(1)]
		public IEnumerable<string> BriefDescParamIter()
		{
			RogueTowerBuff.<BriefDescParamIter>d__33 <BriefDescParamIter>d__ = new RogueTowerBuff.<BriefDescParamIter>d__33(-2);
			<BriefDescParamIter>d__.<>3__<>4__this = this;
			return <BriefDescParamIter>d__;
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x0030F52E File Offset: 0x0030D72E
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x0030F53B File Offset: 0x0030D73B
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			RogueTowerBuff.<DescParamIter>d__35 <DescParamIter>d__ = new RogueTowerBuff.<DescParamIter>d__35(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x04005702 RID: 22274
		private Table __p;
	}
}
