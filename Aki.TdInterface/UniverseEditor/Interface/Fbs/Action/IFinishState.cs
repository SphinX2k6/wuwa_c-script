using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AA RID: 26538
	public struct IFinishState : IFlatbufferObject
	{
		// Token: 0x1700C4FA RID: 50426
		// (get) Token: 0x0602E2E4 RID: 189156 RVA: 0x0064E97D File Offset: 0x0064CB7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2E5 RID: 189157 RVA: 0x0064E98A File Offset: 0x0064CB8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2E6 RID: 189158 RVA: 0x0064E994 File Offset: 0x0064CB94
		public static IFinishState GetRootAsIFinishState(ByteBuffer _bb)
		{
			return IFinishState.GetRootAsIFinishState(_bb, default(IFinishState));
		}

		// Token: 0x0602E2E7 RID: 189159 RVA: 0x0064E9B0 File Offset: 0x0064CBB0
		public static IFinishState GetRootAsIFinishState(ByteBuffer _bb, IFinishState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2E8 RID: 189160 RVA: 0x0064E9CD File Offset: 0x0064CBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2E9 RID: 189161 RVA: 0x0064E9DC File Offset: 0x0064CBDC
		public IFinishState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E2EA RID: 189162 RVA: 0x0064E9EC File Offset: 0x0064CBEC
		public static void StartIFinishState(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E2EB RID: 189163 RVA: 0x0064E9F5 File Offset: 0x0064CBF5
		public static Offset<IFinishState> EndIFinishState(FlatBufferBuilder builder)
		{
			return new Offset<IFinishState>(builder.EndTable());
		}

		// Token: 0x0602E2EC RID: 189164 RVA: 0x0064EA04 File Offset: 0x0064CC04
		public IFinishStateT UnPack()
		{
			IFinishStateT finishStateT = new IFinishStateT();
			this.UnPackTo(finishStateT);
			return finishStateT;
		}

		// Token: 0x0602E2ED RID: 189165 RVA: 0x0064EA1F File Offset: 0x0064CC1F
		public void UnPackTo(IFinishStateT _o)
		{
		}

		// Token: 0x0602E2EE RID: 189166 RVA: 0x0064EA24 File Offset: 0x0064CC24
		public static Offset<IFinishState> Pack(FlatBufferBuilder builder, IFinishStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishState>);
			}
			IFinishState.StartIFinishState(builder);
			return IFinishState.EndIFinishState(builder);
		}

		// Token: 0x04010EB8 RID: 69304
		private Table __p;
	}
}
