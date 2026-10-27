using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728F RID: 29327
	public struct ITalkAkEvent : IFlatbufferObject
	{
		// Token: 0x1700D98C RID: 55692
		// (get) Token: 0x06034086 RID: 213126 RVA: 0x006FEFC2 File Offset: 0x006FD1C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034087 RID: 213127 RVA: 0x006FEFCF File Offset: 0x006FD1CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034088 RID: 213128 RVA: 0x006FEFD8 File Offset: 0x006FD1D8
		public static ITalkAkEvent GetRootAsITalkAkEvent(ByteBuffer _bb)
		{
			return ITalkAkEvent.GetRootAsITalkAkEvent(_bb, default(ITalkAkEvent));
		}

		// Token: 0x06034089 RID: 213129 RVA: 0x006FEFF4 File Offset: 0x006FD1F4
		public static ITalkAkEvent GetRootAsITalkAkEvent(ByteBuffer _bb, ITalkAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603408A RID: 213130 RVA: 0x006FF011 File Offset: 0x006FD211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603408B RID: 213131 RVA: 0x006FF020 File Offset: 0x006FD220
		public ITalkAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603408C RID: 213132 RVA: 0x006FF030 File Offset: 0x006FD230
		public static void StartITalkAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603408D RID: 213133 RVA: 0x006FF039 File Offset: 0x006FD239
		public static Offset<ITalkAkEvent> EndITalkAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<ITalkAkEvent>(builder.EndTable());
		}

		// Token: 0x0603408E RID: 213134 RVA: 0x006FF048 File Offset: 0x006FD248
		public ITalkAkEventT UnPack()
		{
			ITalkAkEventT talkAkEventT = new ITalkAkEventT();
			this.UnPackTo(talkAkEventT);
			return talkAkEventT;
		}

		// Token: 0x0603408F RID: 213135 RVA: 0x006FF063 File Offset: 0x006FD263
		public void UnPackTo(ITalkAkEventT _o)
		{
		}

		// Token: 0x06034090 RID: 213136 RVA: 0x006FF068 File Offset: 0x006FD268
		public static Offset<ITalkAkEvent> Pack(FlatBufferBuilder builder, ITalkAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkAkEvent>);
			}
			ITalkAkEvent.StartITalkAkEvent(builder);
			return ITalkAkEvent.EndITalkAkEvent(builder);
		}

		// Token: 0x04011D9D RID: 73117
		private Table __p;
	}
}
