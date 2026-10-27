using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200606B RID: 24683
	public struct IAcceptCurrentQuest : IFlatbufferObject
	{
		// Token: 0x1700B5E6 RID: 46566
		// (get) Token: 0x06029CBF RID: 171199 RVA: 0x005BC342 File Offset: 0x005BA542
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CC0 RID: 171200 RVA: 0x005BC34F File Offset: 0x005BA54F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CC1 RID: 171201 RVA: 0x005BC358 File Offset: 0x005BA558
		public static IAcceptCurrentQuest GetRootAsIAcceptCurrentQuest(ByteBuffer _bb)
		{
			return IAcceptCurrentQuest.GetRootAsIAcceptCurrentQuest(_bb, default(IAcceptCurrentQuest));
		}

		// Token: 0x06029CC2 RID: 171202 RVA: 0x005BC374 File Offset: 0x005BA574
		public static IAcceptCurrentQuest GetRootAsIAcceptCurrentQuest(ByteBuffer _bb, IAcceptCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CC3 RID: 171203 RVA: 0x005BC391 File Offset: 0x005BA591
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CC4 RID: 171204 RVA: 0x005BC3A0 File Offset: 0x005BA5A0
		public IAcceptCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029CC5 RID: 171205 RVA: 0x005BC3B0 File Offset: 0x005BA5B0
		public static void StartIAcceptCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06029CC6 RID: 171206 RVA: 0x005BC3B9 File Offset: 0x005BA5B9
		public static Offset<IAcceptCurrentQuest> EndIAcceptCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptCurrentQuest>(builder.EndTable());
		}

		// Token: 0x06029CC7 RID: 171207 RVA: 0x005BC3C8 File Offset: 0x005BA5C8
		public IAcceptCurrentQuestT UnPack()
		{
			IAcceptCurrentQuestT acceptCurrentQuestT = new IAcceptCurrentQuestT();
			this.UnPackTo(acceptCurrentQuestT);
			return acceptCurrentQuestT;
		}

		// Token: 0x06029CC8 RID: 171208 RVA: 0x005BC3E3 File Offset: 0x005BA5E3
		public void UnPackTo(IAcceptCurrentQuestT _o)
		{
		}

		// Token: 0x06029CC9 RID: 171209 RVA: 0x005BC3E8 File Offset: 0x005BA5E8
		public static Offset<IAcceptCurrentQuest> Pack(FlatBufferBuilder builder, IAcceptCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptCurrentQuest>);
			}
			IAcceptCurrentQuest.StartIAcceptCurrentQuest(builder);
			return IAcceptCurrentQuest.EndIAcceptCurrentQuest(builder);
		}

		// Token: 0x04010230 RID: 66096
		private Table __p;
	}
}
