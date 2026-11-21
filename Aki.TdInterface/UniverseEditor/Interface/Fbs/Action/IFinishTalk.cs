using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2D RID: 28205
	public struct IFinishTalk : IFlatbufferObject
	{
		// Token: 0x1700CEB1 RID: 52913
		// (get) Token: 0x06030B37 RID: 199479 RVA: 0x0069C1AA File Offset: 0x0069A3AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B38 RID: 199480 RVA: 0x0069C1B7 File Offset: 0x0069A3B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B39 RID: 199481 RVA: 0x0069C1C0 File Offset: 0x0069A3C0
		public static IFinishTalk GetRootAsIFinishTalk(ByteBuffer _bb)
		{
			return IFinishTalk.GetRootAsIFinishTalk(_bb, default(IFinishTalk));
		}

		// Token: 0x06030B3A RID: 199482 RVA: 0x0069C1DC File Offset: 0x0069A3DC
		public static IFinishTalk GetRootAsIFinishTalk(ByteBuffer _bb, IFinishTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B3B RID: 199483 RVA: 0x0069C1F9 File Offset: 0x0069A3F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B3C RID: 199484 RVA: 0x0069C208 File Offset: 0x0069A408
		public IFinishTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030B3D RID: 199485 RVA: 0x0069C218 File Offset: 0x0069A418
		public static void StartIFinishTalk(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030B3E RID: 199486 RVA: 0x0069C221 File Offset: 0x0069A421
		public static Offset<IFinishTalk> EndIFinishTalk(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTalk>(builder.EndTable());
		}

		// Token: 0x06030B3F RID: 199487 RVA: 0x0069C230 File Offset: 0x0069A430
		public IFinishTalkT UnPack()
		{
			IFinishTalkT finishTalkT = new IFinishTalkT();
			this.UnPackTo(finishTalkT);
			return finishTalkT;
		}

		// Token: 0x06030B40 RID: 199488 RVA: 0x0069C24B File Offset: 0x0069A44B
		public void UnPackTo(IFinishTalkT _o)
		{
		}

		// Token: 0x06030B41 RID: 199489 RVA: 0x0069C250 File Offset: 0x0069A450
		public static Offset<IFinishTalk> Pack(FlatBufferBuilder builder, IFinishTalkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishTalk>);
			}
			IFinishTalk.StartIFinishTalk(builder);
			return IFinishTalk.EndIFinishTalk(builder);
		}

		// Token: 0x04011CEB RID: 72939
		private Table __p;
	}
}
