using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007765 RID: 30565
	public struct ISetAreaState : IFlatbufferObject
	{
		// Token: 0x1700E008 RID: 57352
		// (get) Token: 0x06035A53 RID: 219731 RVA: 0x007308CC File Offset: 0x0072EACC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A54 RID: 219732 RVA: 0x007308D9 File Offset: 0x0072EAD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A55 RID: 219733 RVA: 0x007308E0 File Offset: 0x0072EAE0
		public static ISetAreaState GetRootAsISetAreaState(ByteBuffer _bb)
		{
			return ISetAreaState.GetRootAsISetAreaState(_bb, default(ISetAreaState));
		}

		// Token: 0x06035A56 RID: 219734 RVA: 0x007308FC File Offset: 0x0072EAFC
		public static ISetAreaState GetRootAsISetAreaState(ByteBuffer _bb, ISetAreaState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A57 RID: 219735 RVA: 0x00730919 File Offset: 0x0072EB19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A58 RID: 219736 RVA: 0x00730928 File Offset: 0x0072EB28
		public ISetAreaState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E009 RID: 57353
		// (get) Token: 0x06035A59 RID: 219737 RVA: 0x00730938 File Offset: 0x0072EB38
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

		// Token: 0x1700E00A RID: 57354
		// (get) Token: 0x06035A5A RID: 219738 RVA: 0x00730974 File Offset: 0x0072EB74
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

		// Token: 0x06035A5B RID: 219739 RVA: 0x007309B0 File Offset: 0x0072EBB0
		public static Offset<ISetAreaState> CreateISetAreaState(FlatBufferBuilder builder, int AreaId = 0, int State = 0)
		{
			builder.StartTable(2);
			ISetAreaState.AddState(builder, State);
			ISetAreaState.AddAreaId(builder, AreaId);
			return ISetAreaState.EndISetAreaState(builder);
		}

		// Token: 0x06035A5C RID: 219740 RVA: 0x007309CD File Offset: 0x0072EBCD
		public static void StartISetAreaState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035A5D RID: 219741 RVA: 0x007309D6 File Offset: 0x0072EBD6
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(0, areaId, 0);
		}

		// Token: 0x06035A5E RID: 219742 RVA: 0x007309E1 File Offset: 0x0072EBE1
		public static void AddState(FlatBufferBuilder builder, int state)
		{
			builder.AddInt(1, state, 0);
		}

		// Token: 0x06035A5F RID: 219743 RVA: 0x007309EC File Offset: 0x0072EBEC
		public static Offset<ISetAreaState> EndISetAreaState(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaState>(builder.EndTable());
		}

		// Token: 0x06035A60 RID: 219744 RVA: 0x007309FC File Offset: 0x0072EBFC
		public ISetAreaStateT UnPack()
		{
			ISetAreaStateT setAreaStateT = new ISetAreaStateT();
			this.UnPackTo(setAreaStateT);
			return setAreaStateT;
		}

		// Token: 0x06035A61 RID: 219745 RVA: 0x00730A17 File Offset: 0x0072EC17
		public void UnPackTo(ISetAreaStateT _o)
		{
			_o.AreaId = this.AreaId;
			_o.State = this.State;
		}

		// Token: 0x06035A62 RID: 219746 RVA: 0x00730A34 File Offset: 0x0072EC34
		public static Offset<ISetAreaState> Pack(FlatBufferBuilder builder, ISetAreaStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaState>);
			}
			return ISetAreaState.CreateISetAreaState(builder, _o.AreaId, _o.State);
		}

		// Token: 0x04012985 RID: 76165
		private Table __p;
	}
}
