using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C17 RID: 31767
	public struct ITraceCurrentQuest : IFlatbufferObject
	{
		// Token: 0x1700EDDA RID: 60890
		// (get) Token: 0x06039406 RID: 234502 RVA: 0x007BB8DA File Offset: 0x007B9ADA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039407 RID: 234503 RVA: 0x007BB8E7 File Offset: 0x007B9AE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039408 RID: 234504 RVA: 0x007BB8F0 File Offset: 0x007B9AF0
		public static ITraceCurrentQuest GetRootAsITraceCurrentQuest(ByteBuffer _bb)
		{
			return ITraceCurrentQuest.GetRootAsITraceCurrentQuest(_bb, default(ITraceCurrentQuest));
		}

		// Token: 0x06039409 RID: 234505 RVA: 0x007BB90C File Offset: 0x007B9B0C
		public static ITraceCurrentQuest GetRootAsITraceCurrentQuest(ByteBuffer _bb, ITraceCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603940A RID: 234506 RVA: 0x007BB929 File Offset: 0x007B9B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603940B RID: 234507 RVA: 0x007BB938 File Offset: 0x007B9B38
		public ITraceCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603940C RID: 234508 RVA: 0x007BB948 File Offset: 0x007B9B48
		public static void StartITraceCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603940D RID: 234509 RVA: 0x007BB951 File Offset: 0x007B9B51
		public static Offset<ITraceCurrentQuest> EndITraceCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<ITraceCurrentQuest>(builder.EndTable());
		}

		// Token: 0x0603940E RID: 234510 RVA: 0x007BB960 File Offset: 0x007B9B60
		public ITraceCurrentQuestT UnPack()
		{
			ITraceCurrentQuestT traceCurrentQuestT = new ITraceCurrentQuestT();
			this.UnPackTo(traceCurrentQuestT);
			return traceCurrentQuestT;
		}

		// Token: 0x0603940F RID: 234511 RVA: 0x007BB97B File Offset: 0x007B9B7B
		public void UnPackTo(ITraceCurrentQuestT _o)
		{
		}

		// Token: 0x06039410 RID: 234512 RVA: 0x007BB980 File Offset: 0x007B9B80
		public static Offset<ITraceCurrentQuest> Pack(FlatBufferBuilder builder, ITraceCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceCurrentQuest>);
			}
			ITraceCurrentQuest.StartITraceCurrentQuest(builder);
			return ITraceCurrentQuest.EndITraceCurrentQuest(builder);
		}

		// Token: 0x040132C0 RID: 78528
		private Table __p;
	}
}
