using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9F RID: 28575
	public struct ISetAreaState : IFlatbufferObject
	{
		// Token: 0x1700D439 RID: 54329
		// (get) Token: 0x06032803 RID: 206851 RVA: 0x006D0F14 File Offset: 0x006CF114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032804 RID: 206852 RVA: 0x006D0F21 File Offset: 0x006CF121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032805 RID: 206853 RVA: 0x006D0F28 File Offset: 0x006CF128
		public static ISetAreaState GetRootAsISetAreaState(ByteBuffer _bb)
		{
			return ISetAreaState.GetRootAsISetAreaState(_bb, default(ISetAreaState));
		}

		// Token: 0x06032806 RID: 206854 RVA: 0x006D0F44 File Offset: 0x006CF144
		public static ISetAreaState GetRootAsISetAreaState(ByteBuffer _bb, ISetAreaState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032807 RID: 206855 RVA: 0x006D0F61 File Offset: 0x006CF161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032808 RID: 206856 RVA: 0x006D0F70 File Offset: 0x006CF170
		public ISetAreaState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D43A RID: 54330
		// (get) Token: 0x06032809 RID: 206857 RVA: 0x006D0F80 File Offset: 0x006CF180
		public int AreaId
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

		// Token: 0x1700D43B RID: 54331
		// (get) Token: 0x0603280A RID: 206858 RVA: 0x006D0FBC File Offset: 0x006CF1BC
		public int State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603280B RID: 206859 RVA: 0x006D0FF8 File Offset: 0x006CF1F8
		public static Offset<ISetAreaState> CreateISetAreaState(FlatBufferBuilder builder, int AreaId = 0, int State = 0)
		{
			builder.StartTable(2);
			ISetAreaState.AddState(builder, State);
			ISetAreaState.AddAreaId(builder, AreaId);
			return ISetAreaState.EndISetAreaState(builder);
		}

		// Token: 0x0603280C RID: 206860 RVA: 0x006D1015 File Offset: 0x006CF215
		public static void StartISetAreaState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603280D RID: 206861 RVA: 0x006D101E File Offset: 0x006CF21E
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(0, areaId, 0);
		}

		// Token: 0x0603280E RID: 206862 RVA: 0x006D1029 File Offset: 0x006CF229
		public static void AddState(FlatBufferBuilder builder, int state)
		{
			builder.AddInt(1, state, 0);
		}

		// Token: 0x0603280F RID: 206863 RVA: 0x006D1034 File Offset: 0x006CF234
		public static Offset<ISetAreaState> EndISetAreaState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaState>(builder.EndTable());
		}

		// Token: 0x06032810 RID: 206864 RVA: 0x006D1044 File Offset: 0x006CF244
		public ISetAreaStateT UnPack()
		{
			ISetAreaStateT setAreaStateT = new ISetAreaStateT();
			this.UnPackTo(setAreaStateT);
			return setAreaStateT;
		}

		// Token: 0x06032811 RID: 206865 RVA: 0x006D105F File Offset: 0x006CF25F
		public void UnPackTo(ISetAreaStateT _o)
		{
			_o.AreaId = this.AreaId;
			_o.State = this.State;
		}

		// Token: 0x06032812 RID: 206866 RVA: 0x006D107C File Offset: 0x006CF27C
		public static Offset<ISetAreaState> Pack(FlatBufferBuilder builder, ISetAreaStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaState>);
			}
			return ISetAreaState.CreateISetAreaState(builder, _o.AreaId, _o.State);
		}

		// Token: 0x040119A3 RID: 72099
		private Table __p;
	}
}
