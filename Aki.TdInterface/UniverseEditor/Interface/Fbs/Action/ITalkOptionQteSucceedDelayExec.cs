using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B24 RID: 31524
	public struct ITalkOptionQteSucceedDelayExec : IFlatbufferObject
	{
		// Token: 0x1700EC19 RID: 60441
		// (get) Token: 0x06038C2D RID: 232493 RVA: 0x007AD2A1 File Offset: 0x007AB4A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C2E RID: 232494 RVA: 0x007AD2AE File Offset: 0x007AB4AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C2F RID: 232495 RVA: 0x007AD2B8 File Offset: 0x007AB4B8
		public static ITalkOptionQteSucceedDelayExec GetRootAsITalkOptionQteSucceedDelayExec(ByteBuffer _bb)
		{
			return ITalkOptionQteSucceedDelayExec.GetRootAsITalkOptionQteSucceedDelayExec(_bb, default(ITalkOptionQteSucceedDelayExec));
		}

		// Token: 0x06038C30 RID: 232496 RVA: 0x007AD2D4 File Offset: 0x007AB4D4
		public static ITalkOptionQteSucceedDelayExec GetRootAsITalkOptionQteSucceedDelayExec(ByteBuffer _bb, ITalkOptionQteSucceedDelayExec obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C31 RID: 232497 RVA: 0x007AD2F1 File Offset: 0x007AB4F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C32 RID: 232498 RVA: 0x007AD300 File Offset: 0x007AB500
		public ITalkOptionQteSucceedDelayExec __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC1A RID: 60442
		// (get) Token: 0x06038C33 RID: 232499 RVA: 0x007AD310 File Offset: 0x007AB510
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038C34 RID: 232500 RVA: 0x007AD34C File Offset: 0x007AB54C
		public static Offset<ITalkOptionQteSucceedDelayExec> CreateITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed)
		{
			builder.StartTable(1);
			ITalkOptionQteSucceedDelayExec.AddType(builder, Type);
			return ITalkOptionQteSucceedDelayExec.EndITalkOptionQteSucceedDelayExec(builder);
		}

		// Token: 0x06038C35 RID: 232501 RVA: 0x007AD362 File Offset: 0x007AB562
		public static void StartITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038C36 RID: 232502 RVA: 0x007AD36B File Offset: 0x007AB56B
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C37 RID: 232503 RVA: 0x007AD376 File Offset: 0x007AB576
		public static Offset<ITalkOptionQteSucceedDelayExec> EndITalkOptionQteSucceedDelayExec(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionQteSucceedDelayExec>(builder.EndTable());
		}

		// Token: 0x06038C38 RID: 232504 RVA: 0x007AD384 File Offset: 0x007AB584
		public ITalkOptionQteSucceedDelayExecT UnPack()
		{
			ITalkOptionQteSucceedDelayExecT talkOptionQteSucceedDelayExecT = new ITalkOptionQteSucceedDelayExecT();
			this.UnPackTo(talkOptionQteSucceedDelayExecT);
			return talkOptionQteSucceedDelayExecT;
		}

		// Token: 0x06038C39 RID: 232505 RVA: 0x007AD39F File Offset: 0x007AB59F
		public void UnPackTo(ITalkOptionQteSucceedDelayExecT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038C3A RID: 232506 RVA: 0x007AD3B0 File Offset: 0x007AB5B0
		public static Offset<ITalkOptionQteSucceedDelayExec> Pack(FlatBufferBuilder builder, ITalkOptionQteSucceedDelayExecT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionQteSucceedDelayExec>);
			}
			return ITalkOptionQteSucceedDelayExec.CreateITalkOptionQteSucceedDelayExec(builder, _o.Type);
		}

		// Token: 0x0401314A RID: 78154
		private Table __p;
	}
}
