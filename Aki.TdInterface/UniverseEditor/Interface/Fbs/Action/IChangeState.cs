using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006994 RID: 27028
	public struct IChangeState : IFlatbufferObject
	{
		// Token: 0x1700C6FA RID: 50938
		// (get) Token: 0x0602E5C6 RID: 189894 RVA: 0x00654068 File Offset: 0x00652268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5C7 RID: 189895 RVA: 0x00654075 File Offset: 0x00652275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5C8 RID: 189896 RVA: 0x0065407C File Offset: 0x0065227C
		public static IChangeState GetRootAsIChangeState(ByteBuffer _bb)
		{
			return IChangeState.GetRootAsIChangeState(_bb, default(IChangeState));
		}

		// Token: 0x0602E5C9 RID: 189897 RVA: 0x00654098 File Offset: 0x00652298
		public static IChangeState GetRootAsIChangeState(ByteBuffer _bb, IChangeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5CA RID: 189898 RVA: 0x006540B5 File Offset: 0x006522B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5CB RID: 189899 RVA: 0x006540C4 File Offset: 0x006522C4
		public IChangeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6FB RID: 50939
		// (get) Token: 0x0602E5CC RID: 189900 RVA: 0x006540D4 File Offset: 0x006522D4
		public int StateId
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

		// Token: 0x0602E5CD RID: 189901 RVA: 0x00654110 File Offset: 0x00652310
		public static Offset<IChangeState> CreateIChangeState(FlatBufferBuilder builder, int StateId = 0)
		{
			builder.StartTable(1);
			IChangeState.AddStateId(builder, StateId);
			return IChangeState.EndIChangeState(builder);
		}

		// Token: 0x0602E5CE RID: 189902 RVA: 0x00654126 File Offset: 0x00652326
		public static void StartIChangeState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E5CF RID: 189903 RVA: 0x0065412F File Offset: 0x0065232F
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x0602E5D0 RID: 189904 RVA: 0x0065413A File Offset: 0x0065233A
		public static Offset<IChangeState> EndIChangeState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeState>(builder.EndTable());
		}

		// Token: 0x0602E5D1 RID: 189905 RVA: 0x00654148 File Offset: 0x00652348
		public IChangeStateT UnPack()
		{
			IChangeStateT changeStateT = new IChangeStateT();
			this.UnPackTo(changeStateT);
			return changeStateT;
		}

		// Token: 0x0602E5D2 RID: 189906 RVA: 0x00654163 File Offset: 0x00652363
		public void UnPackTo(IChangeStateT _o)
		{
			_o.StateId = this.StateId;
		}

		// Token: 0x0602E5D3 RID: 189907 RVA: 0x00654174 File Offset: 0x00652374
		public static Offset<IChangeState> Pack(FlatBufferBuilder builder, IChangeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeState>);
			}
			return IChangeState.CreateIChangeState(builder, _o.StateId);
		}

		// Token: 0x040116FB RID: 71419
		private Table __p;
	}
}
