using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0C RID: 28428
	public struct IRoverRogueRoomFinish : IFlatbufferObject
	{
		// Token: 0x1700D35F RID: 54111
		// (get) Token: 0x0603239C RID: 205724 RVA: 0x006C9295 File Offset: 0x006C7495
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603239D RID: 205725 RVA: 0x006C92A2 File Offset: 0x006C74A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603239E RID: 205726 RVA: 0x006C92AC File Offset: 0x006C74AC
		public static IRoverRogueRoomFinish GetRootAsIRoverRogueRoomFinish(ByteBuffer _bb)
		{
			return IRoverRogueRoomFinish.GetRootAsIRoverRogueRoomFinish(_bb, default(IRoverRogueRoomFinish));
		}

		// Token: 0x0603239F RID: 205727 RVA: 0x006C92C8 File Offset: 0x006C74C8
		public static IRoverRogueRoomFinish GetRootAsIRoverRogueRoomFinish(ByteBuffer _bb, IRoverRogueRoomFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323A0 RID: 205728 RVA: 0x006C92E5 File Offset: 0x006C74E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323A1 RID: 205729 RVA: 0x006C92F4 File Offset: 0x006C74F4
		public IRoverRogueRoomFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060323A2 RID: 205730 RVA: 0x006C9304 File Offset: 0x006C7504
		public static void StartIRoverRogueRoomFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060323A3 RID: 205731 RVA: 0x006C930D File Offset: 0x006C750D
		public static Offset<IRoverRogueRoomFinish> EndIRoverRogueRoomFinish(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueRoomFinish>(builder.EndTable());
		}

		// Token: 0x060323A4 RID: 205732 RVA: 0x006C931C File Offset: 0x006C751C
		public IRoverRogueRoomFinishT UnPack()
		{
			IRoverRogueRoomFinishT roverRogueRoomFinishT = new IRoverRogueRoomFinishT();
			this.UnPackTo(roverRogueRoomFinishT);
			return roverRogueRoomFinishT;
		}

		// Token: 0x060323A5 RID: 205733 RVA: 0x006C9337 File Offset: 0x006C7537
		public void UnPackTo(IRoverRogueRoomFinishT _o)
		{
		}

		// Token: 0x060323A6 RID: 205734 RVA: 0x006C933C File Offset: 0x006C753C
		public static Offset<IRoverRogueRoomFinish> Pack(FlatBufferBuilder builder, IRoverRogueRoomFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueRoomFinish>);
			}
			IRoverRogueRoomFinish.StartIRoverRogueRoomFinish(builder);
			return IRoverRogueRoomFinish.EndIRoverRogueRoomFinish(builder);
		}

		// Token: 0x040118F9 RID: 71929
		private Table __p;
	}
}
