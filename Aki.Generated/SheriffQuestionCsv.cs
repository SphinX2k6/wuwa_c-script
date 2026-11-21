using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119F RID: 4511
	public struct SheriffQuestionCsv : IFlatbufferObject
	{
		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600D929 RID: 55593 RVA: 0x0032D258 File Offset: 0x0032B458
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D92A RID: 55594 RVA: 0x0032D265 File Offset: 0x0032B465
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x0032D26C File Offset: 0x0032B46C
		public static SheriffQuestionCsv GetRootAsSheriffQuestionCsv(ByteBuffer _bb)
		{
			return SheriffQuestionCsv.GetRootAsSheriffQuestionCsv(_bb, default(SheriffQuestionCsv));
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x0032D288 File Offset: 0x0032B488
		public static SheriffQuestionCsv GetRootAsSheriffQuestionCsv(ByteBuffer _bb, SheriffQuestionCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D92D RID: 55597 RVA: 0x0032D2A5 File Offset: 0x0032B4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D92E RID: 55598 RVA: 0x0032D2B4 File Offset: 0x0032B4B4
		public SheriffQuestionCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600D92F RID: 55599 RVA: 0x0032D2C4 File Offset: 0x0032B4C4
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

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600D930 RID: 55600 RVA: 0x0032D300 File Offset: 0x0032B500
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

		// Token: 0x0600D931 RID: 55601 RVA: 0x0032D337 File Offset: 0x0032B537
		public Span<byte> GetQuestionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D932 RID: 55602 RVA: 0x0032D346 File Offset: 0x0032B546
		public byte[] GetQuestionDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D933 RID: 55603 RVA: 0x0032D360 File Offset: 0x0032B560
		public string EnterFlowStateId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600D934 RID: 55604 RVA: 0x0032D39C File Offset: 0x0032B59C
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

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600D935 RID: 55605 RVA: 0x0032D3C8 File Offset: 0x0032B5C8
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

		// Token: 0x0600D936 RID: 55606 RVA: 0x0032D408 File Offset: 0x0032B608
		public string FailResultDesc(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600D937 RID: 55607 RVA: 0x0032D444 File Offset: 0x0032B644
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

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600D938 RID: 55608 RVA: 0x0032D470 File Offset: 0x0032B670
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

		// Token: 0x0600D939 RID: 55609 RVA: 0x0032D4B0 File Offset: 0x0032B6B0
		public int SoftPityClueIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600D93A RID: 55610 RVA: 0x0032D4F0 File Offset: 0x0032B6F0
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

		// Token: 0x0600D93B RID: 55611 RVA: 0x0032D51C File Offset: 0x0032B71C
		public Span<int> GetSoftPityClueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x0032D52C File Offset: 0x0032B72C
		public int[] GetSoftPityClueIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600D93D RID: 55613 RVA: 0x0032D544 File Offset: 0x0032B744
		[NullableContext(1)]
		public string[] EnterFlowStateId()
		{
			return this.EnterFlowStateIdIter().ToArray<string>();
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x0032D551 File Offset: 0x0032B751
		[NullableContext(1)]
		public IEnumerable<string> EnterFlowStateIdIter()
		{
			SheriffQuestionCsv.<EnterFlowStateIdIter>d__30 <EnterFlowStateIdIter>d__ = new SheriffQuestionCsv.<EnterFlowStateIdIter>d__30(-2);
			<EnterFlowStateIdIter>d__.<>3__<>4__this = this;
			return <EnterFlowStateIdIter>d__;
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x0032D566 File Offset: 0x0032B766
		[NullableContext(1)]
		public string[] FailResultDesc()
		{
			return this.FailResultDescIter().ToArray<string>();
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x0032D573 File Offset: 0x0032B773
		[NullableContext(1)]
		public IEnumerable<string> FailResultDescIter()
		{
			SheriffQuestionCsv.<FailResultDescIter>d__32 <FailResultDescIter>d__ = new SheriffQuestionCsv.<FailResultDescIter>d__32(-2);
			<FailResultDescIter>d__.<>3__<>4__this = this;
			return <FailResultDescIter>d__;
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x0032D588 File Offset: 0x0032B788
		[NullableContext(1)]
		public int[] SoftPityClueIds()
		{
			return this.GetSoftPityClueIdsArray();
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x0032D590 File Offset: 0x0032B790
		[NullableContext(1)]
		public IEnumerable<int> SoftPityClueIdsIter()
		{
			SheriffQuestionCsv.<SoftPityClueIdsIter>d__34 <SoftPityClueIdsIter>d__ = new SheriffQuestionCsv.<SoftPityClueIdsIter>d__34(-2);
			<SoftPityClueIdsIter>d__.<>3__<>4__this = this;
			return <SoftPityClueIdsIter>d__;
		}

		// Token: 0x040057B2 RID: 22450
		private Table __p;
	}
}
