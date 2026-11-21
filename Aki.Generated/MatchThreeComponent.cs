using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDF RID: 3807
	public struct MatchThreeComponent : IFlatbufferObject
	{
		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x0029F854 File Offset: 0x0029DA54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x0029F861 File Offset: 0x0029DA61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0029F868 File Offset: 0x0029DA68
		public static MatchThreeComponent GetRootAsMatchThreeComponent(ByteBuffer _bb)
		{
			return MatchThreeComponent.GetRootAsMatchThreeComponent(_bb, default(MatchThreeComponent));
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x0029F884 File Offset: 0x0029DA84
		public static MatchThreeComponent GetRootAsMatchThreeComponent(ByteBuffer _bb, MatchThreeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x0029F8A1 File Offset: 0x0029DAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x0029F8B0 File Offset: 0x0029DAB0
		public MatchThreeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x0029F8C0 File Offset: 0x0029DAC0
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06009888 RID: 39048 RVA: 0x0029F8FC File Offset: 0x0029DAFC
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

		// Token: 0x06009889 RID: 39049 RVA: 0x0029F938 File Offset: 0x0029DB38
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x0029F978 File Offset: 0x0029DB78
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

		// Token: 0x0600988B RID: 39051 RVA: 0x0029F9A3 File Offset: 0x0029DBA3
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x0029F9B2 File Offset: 0x0029DBB2
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x0029F9C9 File Offset: 0x0029DBC9
		[NullableContext(1)]
		public int[] Params()
		{
			return this.GetParamsArray();
		}

		// Token: 0x0600988E RID: 39054 RVA: 0x0029F9D1 File Offset: 0x0029DBD1
		[NullableContext(1)]
		public IEnumerable<int> ParamsIter()
		{
			MatchThreeComponent.<ParamsIter>d__18 <ParamsIter>d__ = new MatchThreeComponent.<ParamsIter>d__18(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0400547F RID: 21631
		private Table __p;
	}
}
