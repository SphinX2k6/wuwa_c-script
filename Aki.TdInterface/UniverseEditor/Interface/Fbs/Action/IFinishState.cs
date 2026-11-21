using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2A RID: 28202
	public struct IFinishState : IFlatbufferObject
	{
		// Token: 0x1700CEB0 RID: 52912
		// (get) Token: 0x06030B2A RID: 199466 RVA: 0x0069C0C1 File Offset: 0x0069A2C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B2B RID: 199467 RVA: 0x0069C0CE File Offset: 0x0069A2CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B2C RID: 199468 RVA: 0x0069C0D8 File Offset: 0x0069A2D8
		public static IFinishState GetRootAsIFinishState(ByteBuffer _bb)
		{
			return IFinishState.GetRootAsIFinishState(_bb, default(IFinishState));
		}

		// Token: 0x06030B2D RID: 199469 RVA: 0x0069C0F4 File Offset: 0x0069A2F4
		public static IFinishState GetRootAsIFinishState(ByteBuffer _bb, IFinishState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B2E RID: 199470 RVA: 0x0069C111 File Offset: 0x0069A311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B2F RID: 199471 RVA: 0x0069C120 File Offset: 0x0069A320
		public IFinishState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030B30 RID: 199472 RVA: 0x0069C130 File Offset: 0x0069A330
		public static void StartIFinishState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030B31 RID: 199473 RVA: 0x0069C139 File Offset: 0x0069A339
		public static Offset<IFinishState> EndIFinishState(FlatBufferBuilder builder)
		{
			return new Offset<IFinishState>(builder.EndTable());
		}

		// Token: 0x06030B32 RID: 199474 RVA: 0x0069C148 File Offset: 0x0069A348
		public IFinishStateT UnPack()
		{
			IFinishStateT finishStateT = new IFinishStateT();
			this.UnPackTo(finishStateT);
			return finishStateT;
		}

		// Token: 0x06030B33 RID: 199475 RVA: 0x0069C163 File Offset: 0x0069A363
		public void UnPackTo(IFinishStateT _o)
		{
		}

		// Token: 0x06030B34 RID: 199476 RVA: 0x0069C168 File Offset: 0x0069A368
		public static Offset<IFinishState> Pack(FlatBufferBuilder builder, IFinishStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishState>);
			}
			IFinishState.StartIFinishState(builder);
			return IFinishState.EndIFinishState(builder);
		}

		// Token: 0x04011CEA RID: 72938
		private Table __p;
	}
}
