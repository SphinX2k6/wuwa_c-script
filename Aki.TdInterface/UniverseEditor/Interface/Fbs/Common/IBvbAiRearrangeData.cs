using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006371 RID: 25457
	public struct IBvbAiRearrangeData : IFlatbufferObject
	{
		// Token: 0x1700BC48 RID: 48200
		// (get) Token: 0x0602B377 RID: 177015 RVA: 0x005E487C File Offset: 0x005E2A7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B378 RID: 177016 RVA: 0x005E4889 File Offset: 0x005E2A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B379 RID: 177017 RVA: 0x005E4890 File Offset: 0x005E2A90
		public static IBvbAiRearrangeData GetRootAsIBvbAiRearrangeData(ByteBuffer _bb)
		{
			return IBvbAiRearrangeData.GetRootAsIBvbAiRearrangeData(_bb, default(IBvbAiRearrangeData));
		}

		// Token: 0x0602B37A RID: 177018 RVA: 0x005E48AC File Offset: 0x005E2AAC
		public static IBvbAiRearrangeData GetRootAsIBvbAiRearrangeData(ByteBuffer _bb, IBvbAiRearrangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B37B RID: 177019 RVA: 0x005E48C9 File Offset: 0x005E2AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B37C RID: 177020 RVA: 0x005E48D8 File Offset: 0x005E2AD8
		public IBvbAiRearrangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC49 RID: 48201
		// (get) Token: 0x0602B37D RID: 177021 RVA: 0x005E48E8 File Offset: 0x005E2AE8
		public EBvbEventName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC4A RID: 48202
		// (get) Token: 0x0602B37E RID: 177022 RVA: 0x005E4924 File Offset: 0x005E2B24
		public TVarRef BoardCardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B37F RID: 177023 RVA: 0x005E4960 File Offset: 0x005E2B60
		public TTable? BoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B380 RID: 177024 RVA: 0x005E49A4 File Offset: 0x005E2BA4
		public IConstVarRef BoardCardAsIConstVarRef()
		{
			return this.BoardCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B381 RID: 177025 RVA: 0x005E49C0 File Offset: 0x005E2BC0
		public IGlobalVarRef BoardCardAsIGlobalVarRef()
		{
			return this.BoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B382 RID: 177026 RVA: 0x005E49DC File Offset: 0x005E2BDC
		public IOtherVarRef BoardCardAsIOtherVarRef()
		{
			return this.BoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B383 RID: 177027 RVA: 0x005E49F8 File Offset: 0x005E2BF8
		public ISelfVarRef BoardCardAsISelfVarRef()
		{
			return this.BoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B384 RID: 177028 RVA: 0x005E4A14 File Offset: 0x005E2C14
		public ISystemVarRef BoardCardAsISystemVarRef()
		{
			return this.BoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC4B RID: 48203
		// (get) Token: 0x0602B385 RID: 177029 RVA: 0x005E4A30 File Offset: 0x005E2C30
		public TVarRef BoardPosType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B386 RID: 177030 RVA: 0x005E4A70 File Offset: 0x005E2C70
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B387 RID: 177031 RVA: 0x005E4AB8 File Offset: 0x005E2CB8
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x0602B388 RID: 177032 RVA: 0x005E4AD4 File Offset: 0x005E2CD4
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B389 RID: 177033 RVA: 0x005E4AF0 File Offset: 0x005E2CF0
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x0602B38A RID: 177034 RVA: 0x005E4B0C File Offset: 0x005E2D0C
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x0602B38B RID: 177035 RVA: 0x005E4B28 File Offset: 0x005E2D28
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x0602B38C RID: 177036 RVA: 0x005E4B43 File Offset: 0x005E2D43
		public static Offset<IBvbAiRearrangeData> CreateIBvbAiRearrangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard_type = TVarRef.NONE, int BoardCardOffset = 0, TVarRef BoardPos_type = TVarRef.NONE, int BoardPosOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiRearrangeData.AddBoardPos(builder, BoardPosOffset);
			IBvbAiRearrangeData.AddBoardCard(builder, BoardCardOffset);
			IBvbAiRearrangeData.AddBoardPosType(builder, BoardPos_type);
			IBvbAiRearrangeData.AddBoardCardType(builder, BoardCard_type);
			IBvbAiRearrangeData.AddType(builder, Type);
			return IBvbAiRearrangeData.EndIBvbAiRearrangeData(builder);
		}

		// Token: 0x0602B38D RID: 177037 RVA: 0x005E4B77 File Offset: 0x005E2D77
		public static void StartIBvbAiRearrangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B38E RID: 177038 RVA: 0x005E4B80 File Offset: 0x005E2D80
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B38F RID: 177039 RVA: 0x005E4B8B File Offset: 0x005E2D8B
		public static void AddBoardCardType(FlatBufferBuilder builder, TVarRef boardCardType)
		{
			builder.AddByte(1, (byte)boardCardType, 0);
		}

		// Token: 0x0602B390 RID: 177040 RVA: 0x005E4B96 File Offset: 0x005E2D96
		public static void AddBoardCard(FlatBufferBuilder builder, int boardCardOffset)
		{
			builder.AddOffset(2, boardCardOffset, 0);
		}

		// Token: 0x0602B391 RID: 177041 RVA: 0x005E4BA1 File Offset: 0x005E2DA1
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x0602B392 RID: 177042 RVA: 0x005E4BAC File Offset: 0x005E2DAC
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x0602B393 RID: 177043 RVA: 0x005E4BB7 File Offset: 0x005E2DB7
		public static Offset<IBvbAiRearrangeData> EndIBvbAiRearrangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiRearrangeData>(builder.EndTable());
		}

		// Token: 0x0602B394 RID: 177044 RVA: 0x005E4BC4 File Offset: 0x005E2DC4
		public IBvbAiRearrangeDataT UnPack()
		{
			IBvbAiRearrangeDataT bvbAiRearrangeDataT = new IBvbAiRearrangeDataT();
			this.UnPackTo(bvbAiRearrangeDataT);
			return bvbAiRearrangeDataT;
		}

		// Token: 0x0602B395 RID: 177045 RVA: 0x005E4BE0 File Offset: 0x005E2DE0
		public void UnPackTo(IBvbAiRearrangeDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCard = new TVarRefUnion();
			_o.BoardCard.Type = this.BoardCardType;
			switch (this.BoardCardType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IConstVarRef>() != null) ? this.BoardCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IGlobalVarRef>() != null) ? this.BoardCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCard.Value = ((this.BoardCard<IOtherVarRef>() != null) ? this.BoardCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISelfVarRef>() != null) ? this.BoardCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCard.Value = ((this.BoardCard<ISystemVarRef>() != null) ? this.BoardCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardPos = new TVarRefUnion();
			_o.BoardPos.Type = this.BoardPosType;
			switch (this.BoardPosType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IConstVarRef>() != null) ? this.BoardPos<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IGlobalVarRef>() != null) ? this.BoardPos<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IOtherVarRef>() != null) ? this.BoardPos<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISelfVarRef>() != null) ? this.BoardPos<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISystemVarRef>() != null) ? this.BoardPos<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B396 RID: 177046 RVA: 0x005E4EAC File Offset: 0x005E30AC
		public static Offset<IBvbAiRearrangeData> Pack(FlatBufferBuilder builder, IBvbAiRearrangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiRearrangeData>);
			}
			TVarRef boardCard_type = (_o.BoardCard == null) ? TVarRef.NONE : _o.BoardCard.Type;
			int boardCardOffset = (_o.BoardCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard);
			TVarRef boardPos_type = (_o.BoardPos == null) ? TVarRef.NONE : _o.BoardPos.Type;
			int boardPosOffset = (_o.BoardPos == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPos);
			return IBvbAiRearrangeData.CreateIBvbAiRearrangeData(builder, _o.Type, boardCard_type, boardCardOffset, boardPos_type, boardPosOffset);
		}

		// Token: 0x04010441 RID: 66625
		private Table __p;
	}
}
