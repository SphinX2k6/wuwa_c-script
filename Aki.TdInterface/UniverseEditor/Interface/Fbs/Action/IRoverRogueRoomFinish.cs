using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007693 RID: 30355
	public struct IRoverRogueRoomFinish : IFlatbufferObject
	{
		// Token: 0x1700DEBB RID: 57019
		// (get) Token: 0x060353F4 RID: 218100 RVA: 0x007251FD File Offset: 0x007233FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060353F5 RID: 218101 RVA: 0x0072520A File Offset: 0x0072340A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060353F6 RID: 218102 RVA: 0x00725214 File Offset: 0x00723414
		public static IRoverRogueRoomFinish GetRootAsIRoverRogueRoomFinish(ByteBuffer _bb)
		{
			return IRoverRogueRoomFinish.GetRootAsIRoverRogueRoomFinish(_bb, default(IRoverRogueRoomFinish));
		}

		// Token: 0x060353F7 RID: 218103 RVA: 0x00725230 File Offset: 0x00723430
		public static IRoverRogueRoomFinish GetRootAsIRoverRogueRoomFinish(ByteBuffer _bb, IRoverRogueRoomFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060353F8 RID: 218104 RVA: 0x0072524D File Offset: 0x0072344D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060353F9 RID: 218105 RVA: 0x0072525C File Offset: 0x0072345C
		public IRoverRogueRoomFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060353FA RID: 218106 RVA: 0x0072526C File Offset: 0x0072346C
		public static void StartIRoverRogueRoomFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060353FB RID: 218107 RVA: 0x00725275 File Offset: 0x00723475
		public static Offset<IRoverRogueRoomFinish> EndIRoverRogueRoomFinish(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueRoomFinish>(builder.EndTable());
		}

		// Token: 0x060353FC RID: 218108 RVA: 0x00725284 File Offset: 0x00723484
		public IRoverRogueRoomFinishT UnPack()
		{
			IRoverRogueRoomFinishT roverRogueRoomFinishT = new IRoverRogueRoomFinishT();
			this.UnPackTo(roverRogueRoomFinishT);
			return roverRogueRoomFinishT;
		}

		// Token: 0x060353FD RID: 218109 RVA: 0x0072529F File Offset: 0x0072349F
		public void UnPackTo(IRoverRogueRoomFinishT _o)
		{
		}

		// Token: 0x060353FE RID: 218110 RVA: 0x007252A4 File Offset: 0x007234A4
		public static Offset<IRoverRogueRoomFinish> Pack(FlatBufferBuilder builder, IRoverRogueRoomFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueRoomFinish>);
			}
			IRoverRogueRoomFinish.StartIRoverRogueRoomFinish(builder);
			return IRoverRogueRoomFinish.EndIRoverRogueRoomFinish(builder);
		}

		// Token: 0x04012881 RID: 75905
		private Table __p;
	}
}
