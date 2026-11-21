using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA5 RID: 27557
	public struct IDarkTideSetMapMarkState : IFlatbufferObject
	{
		// Token: 0x1700CA2D RID: 51757
		// (get) Token: 0x0602F6CB RID: 194251 RVA: 0x0067838D File Offset: 0x0067658D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6CC RID: 194252 RVA: 0x0067839A File Offset: 0x0067659A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6CD RID: 194253 RVA: 0x006783A4 File Offset: 0x006765A4
		public static IDarkTideSetMapMarkState GetRootAsIDarkTideSetMapMarkState(ByteBuffer _bb)
		{
			return IDarkTideSetMapMarkState.GetRootAsIDarkTideSetMapMarkState(_bb, default(IDarkTideSetMapMarkState));
		}

		// Token: 0x0602F6CE RID: 194254 RVA: 0x006783C0 File Offset: 0x006765C0
		public static IDarkTideSetMapMarkState GetRootAsIDarkTideSetMapMarkState(ByteBuffer _bb, IDarkTideSetMapMarkState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6CF RID: 194255 RVA: 0x006783DD File Offset: 0x006765DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6D0 RID: 194256 RVA: 0x006783EC File Offset: 0x006765EC
		public IDarkTideSetMapMarkState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA2E RID: 51758
		// (get) Token: 0x0602F6D1 RID: 194257 RVA: 0x006783FC File Offset: 0x006765FC
		public int MapMarkId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA2F RID: 51759
		// (get) Token: 0x0602F6D2 RID: 194258 RVA: 0x00678438 File Offset: 0x00676638
		public EDarkTideMapMarkStateType StateType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDarkTideMapMarkStateType.Hide;
				}
				return (EDarkTideMapMarkStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F6D3 RID: 194259 RVA: 0x00678474 File Offset: 0x00676674
		public static Offset<IDarkTideSetMapMarkState> CreateIDarkTideSetMapMarkState(FlatBufferBuilder builder, int MapMarkId = 0, EDarkTideMapMarkStateType StateType = EDarkTideMapMarkStateType.Hide)
		{
			builder.StartTable(2);
			IDarkTideSetMapMarkState.AddMapMarkId(builder, MapMarkId);
			IDarkTideSetMapMarkState.AddStateType(builder, StateType);
			return IDarkTideSetMapMarkState.EndIDarkTideSetMapMarkState(builder);
		}

		// Token: 0x0602F6D4 RID: 194260 RVA: 0x00678491 File Offset: 0x00676691
		public static void StartIDarkTideSetMapMarkState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F6D5 RID: 194261 RVA: 0x0067849A File Offset: 0x0067669A
		public static void AddMapMarkId(FlatBufferBuilder builder, int mapMarkId)
		{
			builder.AddInt(0, mapMarkId, 0);
		}

		// Token: 0x0602F6D6 RID: 194262 RVA: 0x006784A5 File Offset: 0x006766A5
		public static void AddStateType(FlatBufferBuilder builder, EDarkTideMapMarkStateType stateType)
		{
			builder.AddByte(1, (byte)stateType, 0);
		}

		// Token: 0x0602F6D7 RID: 194263 RVA: 0x006784B0 File Offset: 0x006766B0
		public static Offset<IDarkTideSetMapMarkState> EndIDarkTideSetMapMarkState(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideSetMapMarkState>(builder.EndTable());
		}

		// Token: 0x0602F6D8 RID: 194264 RVA: 0x006784C0 File Offset: 0x006766C0
		public IDarkTideSetMapMarkStateT UnPack()
		{
			IDarkTideSetMapMarkStateT darkTideSetMapMarkStateT = new IDarkTideSetMapMarkStateT();
			this.UnPackTo(darkTideSetMapMarkStateT);
			return darkTideSetMapMarkStateT;
		}

		// Token: 0x0602F6D9 RID: 194265 RVA: 0x006784DB File Offset: 0x006766DB
		public void UnPackTo(IDarkTideSetMapMarkStateT _o)
		{
			_o.MapMarkId = this.MapMarkId;
			_o.StateType = this.StateType;
		}

		// Token: 0x0602F6DA RID: 194266 RVA: 0x006784F8 File Offset: 0x006766F8
		public static Offset<IDarkTideSetMapMarkState> Pack(FlatBufferBuilder builder, IDarkTideSetMapMarkStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideSetMapMarkState>);
			}
			return IDarkTideSetMapMarkState.CreateIDarkTideSetMapMarkState(builder, _o.MapMarkId, _o.StateType);
		}

		// Token: 0x04011997 RID: 72087
		private Table __p;
	}
}
