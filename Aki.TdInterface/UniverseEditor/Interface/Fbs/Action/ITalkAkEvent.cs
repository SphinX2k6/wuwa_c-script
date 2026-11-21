using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A64 RID: 31332
	public struct ITalkAkEvent : IFlatbufferObject
	{
		// Token: 0x1700E585 RID: 58757
		// (get) Token: 0x0603738A RID: 226186 RVA: 0x0076035E File Offset: 0x0075E55E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603738B RID: 226187 RVA: 0x0076036B File Offset: 0x0075E56B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603738C RID: 226188 RVA: 0x00760374 File Offset: 0x0075E574
		public static ITalkAkEvent GetRootAsITalkAkEvent(ByteBuffer _bb)
		{
			return ITalkAkEvent.GetRootAsITalkAkEvent(_bb, default(ITalkAkEvent));
		}

		// Token: 0x0603738D RID: 226189 RVA: 0x00760390 File Offset: 0x0075E590
		public static ITalkAkEvent GetRootAsITalkAkEvent(ByteBuffer _bb, ITalkAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603738E RID: 226190 RVA: 0x007603AD File Offset: 0x0075E5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603738F RID: 226191 RVA: 0x007603BC File Offset: 0x0075E5BC
		public ITalkAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06037390 RID: 226192 RVA: 0x007603CC File Offset: 0x0075E5CC
		public static void StartITalkAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06037391 RID: 226193 RVA: 0x007603D5 File Offset: 0x0075E5D5
		public static Offset<ITalkAkEvent> EndITalkAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<ITalkAkEvent>(builder.EndTable());
		}

		// Token: 0x06037392 RID: 226194 RVA: 0x007603E4 File Offset: 0x0075E5E4
		public ITalkAkEventT UnPack()
		{
			ITalkAkEventT talkAkEventT = new ITalkAkEventT();
			this.UnPackTo(talkAkEventT);
			return talkAkEventT;
		}

		// Token: 0x06037393 RID: 226195 RVA: 0x007603FF File Offset: 0x0075E5FF
		public void UnPackTo(ITalkAkEventT _o)
		{
		}

		// Token: 0x06037394 RID: 226196 RVA: 0x00760404 File Offset: 0x0075E604
		public static Offset<ITalkAkEvent> Pack(FlatBufferBuilder builder, ITalkAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkAkEvent>);
			}
			ITalkAkEvent.StartITalkAkEvent(builder);
			return ITalkAkEvent.EndITalkAkEvent(builder);
		}

		// Token: 0x04012DA0 RID: 77216
		private Table __p;
	}
}
