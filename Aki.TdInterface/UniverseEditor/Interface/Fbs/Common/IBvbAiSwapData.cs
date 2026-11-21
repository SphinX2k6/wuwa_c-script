using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006377 RID: 25463
	public struct IBvbAiSwapData : IFlatbufferObject
	{
		// Token: 0x1700BC54 RID: 48212
		// (get) Token: 0x0602B3BC RID: 177084 RVA: 0x005E54B4 File Offset: 0x005E36B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B3BD RID: 177085 RVA: 0x005E54C1 File Offset: 0x005E36C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B3BE RID: 177086 RVA: 0x005E54C8 File Offset: 0x005E36C8
		public static IBvbAiSwapData GetRootAsIBvbAiSwapData(ByteBuffer _bb)
		{
			return IBvbAiSwapData.GetRootAsIBvbAiSwapData(_bb, default(IBvbAiSwapData));
		}

		// Token: 0x0602B3BF RID: 177087 RVA: 0x005E54E4 File Offset: 0x005E36E4
		public static IBvbAiSwapData GetRootAsIBvbAiSwapData(ByteBuffer _bb, IBvbAiSwapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B3C0 RID: 177088 RVA: 0x005E5501 File Offset: 0x005E3701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B3C1 RID: 177089 RVA: 0x005E5510 File Offset: 0x005E3710
		public IBvbAiSwapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC55 RID: 48213
		// (get) Token: 0x0602B3C2 RID: 177090 RVA: 0x005E5520 File Offset: 0x005E3720
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

		// Token: 0x1700BC56 RID: 48214
		// (get) Token: 0x0602B3C3 RID: 177091 RVA: 0x005E555C File Offset: 0x005E375C
		public TVarRef BoardCard1Type
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

		// Token: 0x0602B3C4 RID: 177092 RVA: 0x005E5598 File Offset: 0x005E3798
		public TTable? BoardCard1<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B3C5 RID: 177093 RVA: 0x005E55DC File Offset: 0x005E37DC
		public IConstVarRef BoardCard1AsIConstVarRef()
		{
			return this.BoardCard1<IConstVarRef>().Value;
		}

		// Token: 0x0602B3C6 RID: 177094 RVA: 0x005E55F8 File Offset: 0x005E37F8
		public IGlobalVarRef BoardCard1AsIGlobalVarRef()
		{
			return this.BoardCard1<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B3C7 RID: 177095 RVA: 0x005E5614 File Offset: 0x005E3814
		public IOtherVarRef BoardCard1AsIOtherVarRef()
		{
			return this.BoardCard1<IOtherVarRef>().Value;
		}

		// Token: 0x0602B3C8 RID: 177096 RVA: 0x005E5630 File Offset: 0x005E3830
		public ISelfVarRef BoardCard1AsISelfVarRef()
		{
			return this.BoardCard1<ISelfVarRef>().Value;
		}

		// Token: 0x0602B3C9 RID: 177097 RVA: 0x005E564C File Offset: 0x005E384C
		public ISystemVarRef BoardCard1AsISystemVarRef()
		{
			return this.BoardCard1<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC57 RID: 48215
		// (get) Token: 0x0602B3CA RID: 177098 RVA: 0x005E5668 File Offset: 0x005E3868
		public TVarRef BoardCard2Type
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

		// Token: 0x0602B3CB RID: 177099 RVA: 0x005E56A8 File Offset: 0x005E38A8
		public TTable? BoardCard2<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B3CC RID: 177100 RVA: 0x005E56F0 File Offset: 0x005E38F0
		public IConstVarRef BoardCard2AsIConstVarRef()
		{
			return this.BoardCard2<IConstVarRef>().Value;
		}

		// Token: 0x0602B3CD RID: 177101 RVA: 0x005E570C File Offset: 0x005E390C
		public IGlobalVarRef BoardCard2AsIGlobalVarRef()
		{
			return this.BoardCard2<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B3CE RID: 177102 RVA: 0x005E5728 File Offset: 0x005E3928
		public IOtherVarRef BoardCard2AsIOtherVarRef()
		{
			return this.BoardCard2<IOtherVarRef>().Value;
		}

		// Token: 0x0602B3CF RID: 177103 RVA: 0x005E5744 File Offset: 0x005E3944
		public ISelfVarRef BoardCard2AsISelfVarRef()
		{
			return this.BoardCard2<ISelfVarRef>().Value;
		}

		// Token: 0x0602B3D0 RID: 177104 RVA: 0x005E5760 File Offset: 0x005E3960
		public ISystemVarRef BoardCard2AsISystemVarRef()
		{
			return this.BoardCard2<ISystemVarRef>().Value;
		}

		// Token: 0x0602B3D1 RID: 177105 RVA: 0x005E577B File Offset: 0x005E397B
		public static Offset<IBvbAiSwapData> CreateIBvbAiSwapData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard1_type = TVarRef.NONE, int BoardCard1Offset = 0, TVarRef BoardCard2_type = TVarRef.NONE, int BoardCard2Offset = 0)
		{
			builder.StartTable(5);
			IBvbAiSwapData.AddBoardCard2(builder, BoardCard2Offset);
			IBvbAiSwapData.AddBoardCard1(builder, BoardCard1Offset);
			IBvbAiSwapData.AddBoardCard2Type(builder, BoardCard2_type);
			IBvbAiSwapData.AddBoardCard1Type(builder, BoardCard1_type);
			IBvbAiSwapData.AddType(builder, Type);
			return IBvbAiSwapData.EndIBvbAiSwapData(builder);
		}

		// Token: 0x0602B3D2 RID: 177106 RVA: 0x005E57AF File Offset: 0x005E39AF
		public static void StartIBvbAiSwapData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B3D3 RID: 177107 RVA: 0x005E57B8 File Offset: 0x005E39B8
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B3D4 RID: 177108 RVA: 0x005E57C3 File Offset: 0x005E39C3
		public static void AddBoardCard1Type(FlatBufferBuilder builder, TVarRef boardCard1Type)
		{
			builder.AddByte(1, (byte)boardCard1Type, 0);
		}

		// Token: 0x0602B3D5 RID: 177109 RVA: 0x005E57CE File Offset: 0x005E39CE
		public static void AddBoardCard1(FlatBufferBuilder builder, int boardCard1Offset)
		{
			builder.AddOffset(2, boardCard1Offset, 0);
		}

		// Token: 0x0602B3D6 RID: 177110 RVA: 0x005E57D9 File Offset: 0x005E39D9
		public static void AddBoardCard2Type(FlatBufferBuilder builder, TVarRef boardCard2Type)
		{
			builder.AddByte(3, (byte)boardCard2Type, 0);
		}

		// Token: 0x0602B3D7 RID: 177111 RVA: 0x005E57E4 File Offset: 0x005E39E4
		public static void AddBoardCard2(FlatBufferBuilder builder, int boardCard2Offset)
		{
			builder.AddOffset(4, boardCard2Offset, 0);
		}

		// Token: 0x0602B3D8 RID: 177112 RVA: 0x005E57EF File Offset: 0x005E39EF
		public static Offset<IBvbAiSwapData> EndIBvbAiSwapData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiSwapData>(builder.EndTable());
		}

		// Token: 0x0602B3D9 RID: 177113 RVA: 0x005E57FC File Offset: 0x005E39FC
		public IBvbAiSwapDataT UnPack()
		{
			IBvbAiSwapDataT bvbAiSwapDataT = new IBvbAiSwapDataT();
			this.UnPackTo(bvbAiSwapDataT);
			return bvbAiSwapDataT;
		}

		// Token: 0x0602B3DA RID: 177114 RVA: 0x005E5818 File Offset: 0x005E3A18
		public void UnPackTo(IBvbAiSwapDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCard1 = new TVarRefUnion();
			_o.BoardCard1.Type = this.BoardCard1Type;
			switch (this.BoardCard1Type)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IConstVarRef>() != null) ? this.BoardCard1<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IGlobalVarRef>() != null) ? this.BoardCard1<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<IOtherVarRef>() != null) ? this.BoardCard1<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<ISelfVarRef>() != null) ? this.BoardCard1<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCard1.Value = ((this.BoardCard1<ISystemVarRef>() != null) ? this.BoardCard1<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardCard2 = new TVarRefUnion();
			_o.BoardCard2.Type = this.BoardCard2Type;
			switch (this.BoardCard2Type)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IConstVarRef>() != null) ? this.BoardCard2<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IGlobalVarRef>() != null) ? this.BoardCard2<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<IOtherVarRef>() != null) ? this.BoardCard2<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<ISelfVarRef>() != null) ? this.BoardCard2<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCard2.Value = ((this.BoardCard2<ISystemVarRef>() != null) ? this.BoardCard2<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B3DB RID: 177115 RVA: 0x005E5AE4 File Offset: 0x005E3CE4
		public static Offset<IBvbAiSwapData> Pack(FlatBufferBuilder builder, IBvbAiSwapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiSwapData>);
			}
			TVarRef boardCard1_type = (_o.BoardCard1 == null) ? TVarRef.NONE : _o.BoardCard1.Type;
			int boardCard1Offset = (_o.BoardCard1 == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard1);
			TVarRef boardCard2_type = (_o.BoardCard2 == null) ? TVarRef.NONE : _o.BoardCard2.Type;
			int boardCard2Offset = (_o.BoardCard2 == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard2);
			return IBvbAiSwapData.CreateIBvbAiSwapData(builder, _o.Type, boardCard1_type, boardCard1Offset, boardCard2_type, boardCard2Offset);
		}

		// Token: 0x04010448 RID: 66632
		private Table __p;
	}
}
