using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A4 RID: 4260
	public struct SheriffQuestionCsv : IFlatbufferObject
	{
		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600D153 RID: 53587 RVA: 0x0030DD10 File Offset: 0x0030BF10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D154 RID: 53588 RVA: 0x0030DD1D File Offset: 0x0030BF1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D155 RID: 53589 RVA: 0x0030DD24 File Offset: 0x0030BF24
		public static SheriffQuestionCsv GetRootAsSheriffQuestionCsv(ByteBuffer _bb)
		{
			return SheriffQuestionCsv.GetRootAsSheriffQuestionCsv(_bb, default(SheriffQuestionCsv));
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x0030DD40 File Offset: 0x0030BF40
		public static SheriffQuestionCsv GetRootAsSheriffQuestionCsv(ByteBuffer _bb, SheriffQuestionCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x0030DD5D File Offset: 0x0030BF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x0030DD6C File Offset: 0x0030BF6C
		public SheriffQuestionCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600D159 RID: 53593 RVA: 0x0030DD7C File Offset: 0x0030BF7C
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

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600D15A RID: 53594 RVA: 0x0030DDB8 File Offset: 0x0030BFB8
		public string QuestionDesc
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

		// Token: 0x0600D15B RID: 53595 RVA: 0x0030DDEF File Offset: 0x0030BFEF
		public Span<byte> GetQuestionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x0030DDFE File Offset: 0x0030BFFE
		public byte[] GetQuestionDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x0030DE18 File Offset: 0x0030C018
		public string EnterFlowStateId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600D15E RID: 53598 RVA: 0x0030DE54 File Offset: 0x0030C054
		public int EnterFlowStateIdLength
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

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600D15F RID: 53599 RVA: 0x0030DE80 File Offset: 0x0030C080
		public int NeedClueCount
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

		// Token: 0x0600D160 RID: 53600 RVA: 0x0030DEC0 File Offset: 0x0030C0C0
		public string FailResultDesc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600D161 RID: 53601 RVA: 0x0030DEFC File Offset: 0x0030C0FC
		public int FailResultDescLength
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

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600D162 RID: 53602 RVA: 0x0030DF28 File Offset: 0x0030C128
		public int SoftPityCount
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

		// Token: 0x0600D163 RID: 53603 RVA: 0x0030DF68 File Offset: 0x0030C168
		public int SoftPityClueIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600D164 RID: 53604 RVA: 0x0030DFA8 File Offset: 0x0030C1A8
		public int SoftPityClueIdsLength
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

		// Token: 0x0600D165 RID: 53605 RVA: 0x0030DFD4 File Offset: 0x0030C1D4
		public Span<int> GetSoftPityClueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D166 RID: 53606 RVA: 0x0030DFE4 File Offset: 0x0030C1E4
		public int[] GetSoftPityClueIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600D167 RID: 53607 RVA: 0x0030DFFC File Offset: 0x0030C1FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnterFlowStateIdIter()或GetEnterFlowStateIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EnterFlowStateId()
		{
			return this.EnterFlowStateIdIter().ToArray<string>();
		}

		// Token: 0x0600D168 RID: 53608 RVA: 0x0030E009 File Offset: 0x0030C209
		[NullableContext(1)]
		public readonly IEnumerable<string> EnterFlowStateIdIter()
		{
			SheriffQuestionCsv.<EnterFlowStateIdIter>d__30 <EnterFlowStateIdIter>d__ = new SheriffQuestionCsv.<EnterFlowStateIdIter>d__30(-2);
			<EnterFlowStateIdIter>d__.<>3__<>4__this = this;
			return <EnterFlowStateIdIter>d__;
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x0030E01E File Offset: 0x0030C21E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FailResultDescIter()或GetFailResultDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FailResultDesc()
		{
			return this.FailResultDescIter().ToArray<string>();
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x0030E02B File Offset: 0x0030C22B
		[NullableContext(1)]
		public readonly IEnumerable<string> FailResultDescIter()
		{
			SheriffQuestionCsv.<FailResultDescIter>d__32 <FailResultDescIter>d__ = new SheriffQuestionCsv.<FailResultDescIter>d__32(-2);
			<FailResultDescIter>d__.<>3__<>4__this = this;
			return <FailResultDescIter>d__;
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x0030E040 File Offset: 0x0030C240
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SoftPityClueIdsIter()或GetSoftPityClueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SoftPityClueIds()
		{
			SheriffQuestionCsv sheriffQuestionCsv = this;
			return sheriffQuestionCsv.GetSoftPityClueIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x0030E064 File Offset: 0x0030C264
		[NullableContext(1)]
		public readonly IEnumerable<int> SoftPityClueIdsIter()
		{
			SheriffQuestionCsv.<SoftPityClueIdsIter>d__34 <SoftPityClueIdsIter>d__ = new SheriffQuestionCsv.<SoftPityClueIdsIter>d__34(-2);
			<SoftPityClueIdsIter>d__.<>3__<>4__this = this;
			return <SoftPityClueIdsIter>d__;
		}

		// Token: 0x040051B3 RID: 20915
		private Table __p;
	}
}
