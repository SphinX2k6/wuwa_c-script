using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D37 RID: 23863
	public struct IBvbAiGetBestSwapData : IFlatbufferObject
	{
		// Token: 0x1700B2E0 RID: 45792
		// (get) Token: 0x06028CE5 RID: 167141 RVA: 0x0059B660 File Offset: 0x00599860
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028CE6 RID: 167142 RVA: 0x0059B66D File Offset: 0x0059986D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028CE7 RID: 167143 RVA: 0x0059B674 File Offset: 0x00599874
		public static IBvbAiGetBestSwapData GetRootAsIBvbAiGetBestSwapData(ByteBuffer _bb)
		{
			return IBvbAiGetBestSwapData.GetRootAsIBvbAiGetBestSwapData(_bb, default(IBvbAiGetBestSwapData));
		}

		// Token: 0x06028CE8 RID: 167144 RVA: 0x0059B690 File Offset: 0x00599890
		public static IBvbAiGetBestSwapData GetRootAsIBvbAiGetBestSwapData(ByteBuffer _bb, IBvbAiGetBestSwapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028CE9 RID: 167145 RVA: 0x0059B6AD File Offset: 0x005998AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028CEA RID: 167146 RVA: 0x0059B6BC File Offset: 0x005998BC
		public IBvbAiGetBestSwapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2E1 RID: 45793
		// (get) Token: 0x06028CEB RID: 167147 RVA: 0x0059B6CC File Offset: 0x005998CC
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

		// Token: 0x1700B2E2 RID: 45794
		// (get) Token: 0x06028CEC RID: 167148 RVA: 0x0059B708 File Offset: 0x00599908
		public TVarRef BoardCard1StoredType
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

		// Token: 0x06028CED RID: 167149 RVA: 0x0059B744 File Offset: 0x00599944
		public TTable? BoardCard1Stored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028CEE RID: 167150 RVA: 0x0059B788 File Offset: 0x00599988
		public IConstVarRef BoardCard1StoredAsIConstVarRef()
		{
			return this.BoardCard1Stored<IConstVarRef>().Value;
		}

		// Token: 0x06028CEF RID: 167151 RVA: 0x0059B7A4 File Offset: 0x005999A4
		public IGlobalVarRef BoardCard1StoredAsIGlobalVarRef()
		{
			return this.BoardCard1Stored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CF0 RID: 167152 RVA: 0x0059B7C0 File Offset: 0x005999C0
		public IOtherVarRef BoardCard1StoredAsIOtherVarRef()
		{
			return this.BoardCard1Stored<IOtherVarRef>().Value;
		}

		// Token: 0x06028CF1 RID: 167153 RVA: 0x0059B7DC File Offset: 0x005999DC
		public ISelfVarRef BoardCard1StoredAsISelfVarRef()
		{
			return this.BoardCard1Stored<ISelfVarRef>().Value;
		}

		// Token: 0x06028CF2 RID: 167154 RVA: 0x0059B7F8 File Offset: 0x005999F8
		public ISystemVarRef BoardCard1StoredAsISystemVarRef()
		{
			return this.BoardCard1Stored<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2E3 RID: 45795
		// (get) Token: 0x06028CF3 RID: 167155 RVA: 0x0059B814 File Offset: 0x00599A14
		public TVarRef BoardCard2StoredType
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

		// Token: 0x06028CF4 RID: 167156 RVA: 0x0059B854 File Offset: 0x00599A54
		public TTable? BoardCard2Stored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028CF5 RID: 167157 RVA: 0x0059B89C File Offset: 0x00599A9C
		public IConstVarRef BoardCard2StoredAsIConstVarRef()
		{
			return this.BoardCard2Stored<IConstVarRef>().Value;
		}

		// Token: 0x06028CF6 RID: 167158 RVA: 0x0059B8B8 File Offset: 0x00599AB8
		public IGlobalVarRef BoardCard2StoredAsIGlobalVarRef()
		{
			return this.BoardCard2Stored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CF7 RID: 167159 RVA: 0x0059B8D4 File Offset: 0x00599AD4
		public IOtherVarRef BoardCard2StoredAsIOtherVarRef()
		{
			return this.BoardCard2Stored<IOtherVarRef>().Value;
		}

		// Token: 0x06028CF8 RID: 167160 RVA: 0x0059B8F0 File Offset: 0x00599AF0
		public ISelfVarRef BoardCard2StoredAsISelfVarRef()
		{
			return this.BoardCard2Stored<ISelfVarRef>().Value;
		}

		// Token: 0x06028CF9 RID: 167161 RVA: 0x0059B90C File Offset: 0x00599B0C
		public ISystemVarRef BoardCard2StoredAsISystemVarRef()
		{
			return this.BoardCard2Stored<ISystemVarRef>().Value;
		}

		// Token: 0x06028CFA RID: 167162 RVA: 0x0059B927 File Offset: 0x00599B27
		public static Offset<IBvbAiGetBestSwapData> CreateIBvbAiGetBestSwapData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCard1Stored_type = TVarRef.NONE, int BoardCard1StoredOffset = 0, TVarRef BoardCard2Stored_type = TVarRef.NONE, int BoardCard2StoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestSwapData.AddBoardCard2Stored(builder, BoardCard2StoredOffset);
			IBvbAiGetBestSwapData.AddBoardCard1Stored(builder, BoardCard1StoredOffset);
			IBvbAiGetBestSwapData.AddBoardCard2StoredType(builder, BoardCard2Stored_type);
			IBvbAiGetBestSwapData.AddBoardCard1StoredType(builder, BoardCard1Stored_type);
			IBvbAiGetBestSwapData.AddType(builder, Type);
			return IBvbAiGetBestSwapData.EndIBvbAiGetBestSwapData(builder);
		}

		// Token: 0x06028CFB RID: 167163 RVA: 0x0059B95B File Offset: 0x00599B5B
		public static void StartIBvbAiGetBestSwapData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028CFC RID: 167164 RVA: 0x0059B964 File Offset: 0x00599B64
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028CFD RID: 167165 RVA: 0x0059B96F File Offset: 0x00599B6F
		public static void AddBoardCard1StoredType(FlatBufferBuilder builder, TVarRef boardCard1StoredType)
		{
			builder.AddByte(1, (byte)boardCard1StoredType, 0);
		}

		// Token: 0x06028CFE RID: 167166 RVA: 0x0059B97A File Offset: 0x00599B7A
		public static void AddBoardCard1Stored(FlatBufferBuilder builder, int boardCard1StoredOffset)
		{
			builder.AddOffset(2, boardCard1StoredOffset, 0);
		}

		// Token: 0x06028CFF RID: 167167 RVA: 0x0059B985 File Offset: 0x00599B85
		public static void AddBoardCard2StoredType(FlatBufferBuilder builder, TVarRef boardCard2StoredType)
		{
			builder.AddByte(3, (byte)boardCard2StoredType, 0);
		}

		// Token: 0x06028D00 RID: 167168 RVA: 0x0059B990 File Offset: 0x00599B90
		public static void AddBoardCard2Stored(FlatBufferBuilder builder, int boardCard2StoredOffset)
		{
			builder.AddOffset(4, boardCard2StoredOffset, 0);
		}

		// Token: 0x06028D01 RID: 167169 RVA: 0x0059B99B File Offset: 0x00599B9B
		public static Offset<IBvbAiGetBestSwapData> EndIBvbAiGetBestSwapData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestSwapData>(builder.EndTable());
		}

		// Token: 0x06028D02 RID: 167170 RVA: 0x0059B9A8 File Offset: 0x00599BA8
		public IBvbAiGetBestSwapDataT UnPack()
		{
			IBvbAiGetBestSwapDataT bvbAiGetBestSwapDataT = new IBvbAiGetBestSwapDataT();
			this.UnPackTo(bvbAiGetBestSwapDataT);
			return bvbAiGetBestSwapDataT;
		}

		// Token: 0x06028D03 RID: 167171 RVA: 0x0059B9C4 File Offset: 0x00599BC4
		public void UnPackTo(IBvbAiGetBestSwapDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCard1Stored = new TVarRefUnion();
			_o.BoardCard1Stored.Type = this.BoardCard1StoredType;
			switch (this.BoardCard1StoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard1Stored.Value = ((this.BoardCard1Stored<IConstVarRef>() != null) ? this.BoardCard1Stored<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard1Stored.Value = ((this.BoardCard1Stored<IGlobalVarRef>() != null) ? this.BoardCard1Stored<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCard1Stored.Value = ((this.BoardCard1Stored<IOtherVarRef>() != null) ? this.BoardCard1Stored<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCard1Stored.Value = ((this.BoardCard1Stored<ISelfVarRef>() != null) ? this.BoardCard1Stored<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCard1Stored.Value = ((this.BoardCard1Stored<ISystemVarRef>() != null) ? this.BoardCard1Stored<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardCard2Stored = new TVarRefUnion();
			_o.BoardCard2Stored.Type = this.BoardCard2StoredType;
			switch (this.BoardCard2StoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCard2Stored.Value = ((this.BoardCard2Stored<IConstVarRef>() != null) ? this.BoardCard2Stored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCard2Stored.Value = ((this.BoardCard2Stored<IGlobalVarRef>() != null) ? this.BoardCard2Stored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCard2Stored.Value = ((this.BoardCard2Stored<IOtherVarRef>() != null) ? this.BoardCard2Stored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCard2Stored.Value = ((this.BoardCard2Stored<ISelfVarRef>() != null) ? this.BoardCard2Stored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCard2Stored.Value = ((this.BoardCard2Stored<ISystemVarRef>() != null) ? this.BoardCard2Stored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028D04 RID: 167172 RVA: 0x0059BC90 File Offset: 0x00599E90
		public static Offset<IBvbAiGetBestSwapData> Pack(FlatBufferBuilder builder, IBvbAiGetBestSwapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestSwapData>);
			}
			TVarRef boardCard1Stored_type = (_o.BoardCard1Stored == null) ? TVarRef.NONE : _o.BoardCard1Stored.Type;
			int boardCard1StoredOffset = (_o.BoardCard1Stored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard1Stored);
			TVarRef boardCard2Stored_type = (_o.BoardCard2Stored == null) ? TVarRef.NONE : _o.BoardCard2Stored.Type;
			int boardCard2StoredOffset = (_o.BoardCard2Stored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCard2Stored);
			return IBvbAiGetBestSwapData.CreateIBvbAiGetBestSwapData(builder, _o.Type, boardCard1Stored_type, boardCard1StoredOffset, boardCard2Stored_type, boardCard2StoredOffset);
		}

		// Token: 0x0400F6EB RID: 63211
		private Table __p;
	}
}
