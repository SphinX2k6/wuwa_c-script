using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007424 RID: 29732
	public struct ITraceCurrentQuest : IFlatbufferObject
	{
		// Token: 0x1700E1BD RID: 57789
		// (get) Token: 0x0603601D RID: 221213 RVA: 0x00758BAE File Offset: 0x00756DAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603601E RID: 221214 RVA: 0x00758BBB File Offset: 0x00756DBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603601F RID: 221215 RVA: 0x00758BC4 File Offset: 0x00756DC4
		public static ITraceCurrentQuest GetRootAsITraceCurrentQuest(ByteBuffer _bb)
		{
			return ITraceCurrentQuest.GetRootAsITraceCurrentQuest(_bb, default(ITraceCurrentQuest));
		}

		// Token: 0x06036020 RID: 221216 RVA: 0x00758BE0 File Offset: 0x00756DE0
		public static ITraceCurrentQuest GetRootAsITraceCurrentQuest(ByteBuffer _bb, ITraceCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036021 RID: 221217 RVA: 0x00758BFD File Offset: 0x00756DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036022 RID: 221218 RVA: 0x00758C0C File Offset: 0x00756E0C
		public ITraceCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036023 RID: 221219 RVA: 0x00758C1C File Offset: 0x00756E1C
		public static void StartITraceCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06036024 RID: 221220 RVA: 0x00758C25 File Offset: 0x00756E25
		public static Offset<ITraceCurrentQuest> EndITraceCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<ITraceCurrentQuest>(builder.EndTable());
		}

		// Token: 0x06036025 RID: 221221 RVA: 0x00758C34 File Offset: 0x00756E34
		public ITraceCurrentQuestT UnPack()
		{
			ITraceCurrentQuestT traceCurrentQuestT = new ITraceCurrentQuestT();
			this.UnPackTo(traceCurrentQuestT);
			return traceCurrentQuestT;
		}

		// Token: 0x06036026 RID: 221222 RVA: 0x00758C4F File Offset: 0x00756E4F
		public void UnPackTo(ITraceCurrentQuestT _o)
		{
		}

		// Token: 0x06036027 RID: 221223 RVA: 0x00758C54 File Offset: 0x00756E54
		public static Offset<ITraceCurrentQuest> Pack(FlatBufferBuilder builder, ITraceCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceCurrentQuest>);
			}
			ITraceCurrentQuest.StartITraceCurrentQuest(builder);
			return ITraceCurrentQuest.EndITraceCurrentQuest(builder);
		}

		// Token: 0x04012299 RID: 74393
		private Table __p;
	}
}
