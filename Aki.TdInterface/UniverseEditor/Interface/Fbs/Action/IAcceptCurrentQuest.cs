using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CD RID: 26317
	public struct IAcceptCurrentQuest : IFlatbufferObject
	{
		// Token: 0x1700BF51 RID: 48977
		// (get) Token: 0x0602C373 RID: 181107 RVA: 0x00605826 File Offset: 0x00603A26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C374 RID: 181108 RVA: 0x00605833 File Offset: 0x00603A33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C375 RID: 181109 RVA: 0x0060583C File Offset: 0x00603A3C
		public static IAcceptCurrentQuest GetRootAsIAcceptCurrentQuest(ByteBuffer _bb)
		{
			return IAcceptCurrentQuest.GetRootAsIAcceptCurrentQuest(_bb, default(IAcceptCurrentQuest));
		}

		// Token: 0x0602C376 RID: 181110 RVA: 0x00605858 File Offset: 0x00603A58
		public static IAcceptCurrentQuest GetRootAsIAcceptCurrentQuest(ByteBuffer _bb, IAcceptCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C377 RID: 181111 RVA: 0x00605875 File Offset: 0x00603A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C378 RID: 181112 RVA: 0x00605884 File Offset: 0x00603A84
		public IAcceptCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C379 RID: 181113 RVA: 0x00605894 File Offset: 0x00603A94
		public static void StartIAcceptCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C37A RID: 181114 RVA: 0x0060589D File Offset: 0x00603A9D
		public static Offset<IAcceptCurrentQuest> EndIAcceptCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptCurrentQuest>(builder.EndTable());
		}

		// Token: 0x0602C37B RID: 181115 RVA: 0x006058AC File Offset: 0x00603AAC
		public IAcceptCurrentQuestT UnPack()
		{
			IAcceptCurrentQuestT acceptCurrentQuestT = new IAcceptCurrentQuestT();
			this.UnPackTo(acceptCurrentQuestT);
			return acceptCurrentQuestT;
		}

		// Token: 0x0602C37C RID: 181116 RVA: 0x006058C7 File Offset: 0x00603AC7
		public void UnPackTo(IAcceptCurrentQuestT _o)
		{
		}

		// Token: 0x0602C37D RID: 181117 RVA: 0x006058CC File Offset: 0x00603ACC
		public static Offset<IAcceptCurrentQuest> Pack(FlatBufferBuilder builder, IAcceptCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptCurrentQuest>);
			}
			IAcceptCurrentQuest.StartIAcceptCurrentQuest(builder);
			return IAcceptCurrentQuest.EndIAcceptCurrentQuest(builder);
		}

		// Token: 0x04011025 RID: 69669
		private Table __p;
	}
}
