using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D31 RID: 23857
	public struct IBvbAiGetBestRearrangeData : IFlatbufferObject
	{
		// Token: 0x1700B2D2 RID: 45778
		// (get) Token: 0x06028C95 RID: 167061 RVA: 0x0059A708 File Offset: 0x00598908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C96 RID: 167062 RVA: 0x0059A715 File Offset: 0x00598915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C97 RID: 167063 RVA: 0x0059A71C File Offset: 0x0059891C
		public static IBvbAiGetBestRearrangeData GetRootAsIBvbAiGetBestRearrangeData(ByteBuffer _bb)
		{
			return IBvbAiGetBestRearrangeData.GetRootAsIBvbAiGetBestRearrangeData(_bb, default(IBvbAiGetBestRearrangeData));
		}

		// Token: 0x06028C98 RID: 167064 RVA: 0x0059A738 File Offset: 0x00598938
		public static IBvbAiGetBestRearrangeData GetRootAsIBvbAiGetBestRearrangeData(ByteBuffer _bb, IBvbAiGetBestRearrangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C99 RID: 167065 RVA: 0x0059A755 File Offset: 0x00598955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C9A RID: 167066 RVA: 0x0059A764 File Offset: 0x00598964
		public IBvbAiGetBestRearrangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2D3 RID: 45779
		// (get) Token: 0x06028C9B RID: 167067 RVA: 0x0059A774 File Offset: 0x00598974
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

		// Token: 0x1700B2D4 RID: 45780
		// (get) Token: 0x06028C9C RID: 167068 RVA: 0x0059A7B0 File Offset: 0x005989B0
		public TVarRef BoardCardStoredType
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

		// Token: 0x06028C9D RID: 167069 RVA: 0x0059A7EC File Offset: 0x005989EC
		public TTable? BoardCardStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028C9E RID: 167070 RVA: 0x0059A830 File Offset: 0x00598A30
		public IConstVarRef BoardCardStoredAsIConstVarRef()
		{
			return this.BoardCardStored<IConstVarRef>().Value;
		}

		// Token: 0x06028C9F RID: 167071 RVA: 0x0059A84C File Offset: 0x00598A4C
		public IGlobalVarRef BoardCardStoredAsIGlobalVarRef()
		{
			return this.BoardCardStored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CA0 RID: 167072 RVA: 0x0059A868 File Offset: 0x00598A68
		public IOtherVarRef BoardCardStoredAsIOtherVarRef()
		{
			return this.BoardCardStored<IOtherVarRef>().Value;
		}

		// Token: 0x06028CA1 RID: 167073 RVA: 0x0059A884 File Offset: 0x00598A84
		public ISelfVarRef BoardCardStoredAsISelfVarRef()
		{
			return this.BoardCardStored<ISelfVarRef>().Value;
		}

		// Token: 0x06028CA2 RID: 167074 RVA: 0x0059A8A0 File Offset: 0x00598AA0
		public ISystemVarRef BoardCardStoredAsISystemVarRef()
		{
			return this.BoardCardStored<ISystemVarRef>().Value;
		}

		// Token: 0x1700B2D5 RID: 45781
		// (get) Token: 0x06028CA3 RID: 167075 RVA: 0x0059A8BC File Offset: 0x00598ABC
		public TVarRef BoardPosStoredType
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

		// Token: 0x06028CA4 RID: 167076 RVA: 0x0059A8FC File Offset: 0x00598AFC
		public TTable? BoardPosStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028CA5 RID: 167077 RVA: 0x0059A944 File Offset: 0x00598B44
		public IConstVarRef BoardPosStoredAsIConstVarRef()
		{
			return this.BoardPosStored<IConstVarRef>().Value;
		}

		// Token: 0x06028CA6 RID: 167078 RVA: 0x0059A960 File Offset: 0x00598B60
		public IGlobalVarRef BoardPosStoredAsIGlobalVarRef()
		{
			return this.BoardPosStored<IGlobalVarRef>().Value;
		}

		// Token: 0x06028CA7 RID: 167079 RVA: 0x0059A97C File Offset: 0x00598B7C
		public IOtherVarRef BoardPosStoredAsIOtherVarRef()
		{
			return this.BoardPosStored<IOtherVarRef>().Value;
		}

		// Token: 0x06028CA8 RID: 167080 RVA: 0x0059A998 File Offset: 0x00598B98
		public ISelfVarRef BoardPosStoredAsISelfVarRef()
		{
			return this.BoardPosStored<ISelfVarRef>().Value;
		}

		// Token: 0x06028CA9 RID: 167081 RVA: 0x0059A9B4 File Offset: 0x00598BB4
		public ISystemVarRef BoardPosStoredAsISystemVarRef()
		{
			return this.BoardPosStored<ISystemVarRef>().Value;
		}

		// Token: 0x06028CAA RID: 167082 RVA: 0x0059A9CF File Offset: 0x00598BCF
		public static Offset<IBvbAiGetBestRearrangeData> CreateIBvbAiGetBestRearrangeData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef BoardCardStored_type = TVarRef.NONE, int BoardCardStoredOffset = 0, TVarRef BoardPosStored_type = TVarRef.NONE, int BoardPosStoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestRearrangeData.AddBoardPosStored(builder, BoardPosStoredOffset);
			IBvbAiGetBestRearrangeData.AddBoardCardStored(builder, BoardCardStoredOffset);
			IBvbAiGetBestRearrangeData.AddBoardPosStoredType(builder, BoardPosStored_type);
			IBvbAiGetBestRearrangeData.AddBoardCardStoredType(builder, BoardCardStored_type);
			IBvbAiGetBestRearrangeData.AddType(builder, Type);
			return IBvbAiGetBestRearrangeData.EndIBvbAiGetBestRearrangeData(builder);
		}

		// Token: 0x06028CAB RID: 167083 RVA: 0x0059AA03 File Offset: 0x00598C03
		public static void StartIBvbAiGetBestRearrangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028CAC RID: 167084 RVA: 0x0059AA0C File Offset: 0x00598C0C
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028CAD RID: 167085 RVA: 0x0059AA17 File Offset: 0x00598C17
		public static void AddBoardCardStoredType(FlatBufferBuilder builder, TVarRef boardCardStoredType)
		{
			builder.AddByte(1, (byte)boardCardStoredType, 0);
		}

		// Token: 0x06028CAE RID: 167086 RVA: 0x0059AA22 File Offset: 0x00598C22
		public static void AddBoardCardStored(FlatBufferBuilder builder, int boardCardStoredOffset)
		{
			builder.AddOffset(2, boardCardStoredOffset, 0);
		}

		// Token: 0x06028CAF RID: 167087 RVA: 0x0059AA2D File Offset: 0x00598C2D
		public static void AddBoardPosStoredType(FlatBufferBuilder builder, TVarRef boardPosStoredType)
		{
			builder.AddByte(3, (byte)boardPosStoredType, 0);
		}

		// Token: 0x06028CB0 RID: 167088 RVA: 0x0059AA38 File Offset: 0x00598C38
		public static void AddBoardPosStored(FlatBufferBuilder builder, int boardPosStoredOffset)
		{
			builder.AddOffset(4, boardPosStoredOffset, 0);
		}

		// Token: 0x06028CB1 RID: 167089 RVA: 0x0059AA43 File Offset: 0x00598C43
		public static Offset<IBvbAiGetBestRearrangeData> EndIBvbAiGetBestRearrangeData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestRearrangeData>(builder.EndTable());
		}

		// Token: 0x06028CB2 RID: 167090 RVA: 0x0059AA50 File Offset: 0x00598C50
		public IBvbAiGetBestRearrangeDataT UnPack()
		{
			IBvbAiGetBestRearrangeDataT bvbAiGetBestRearrangeDataT = new IBvbAiGetBestRearrangeDataT();
			this.UnPackTo(bvbAiGetBestRearrangeDataT);
			return bvbAiGetBestRearrangeDataT;
		}

		// Token: 0x06028CB3 RID: 167091 RVA: 0x0059AA6C File Offset: 0x00598C6C
		public void UnPackTo(IBvbAiGetBestRearrangeDataT _o)
		{
			_o.Type = this.Type;
			_o.BoardCardStored = new TVarRefUnion();
			_o.BoardCardStored.Type = this.BoardCardStoredType;
			switch (this.BoardCardStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IConstVarRef>() != null) ? this.BoardCardStored<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IGlobalVarRef>() != null) ? this.BoardCardStored<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IOtherVarRef>() != null) ? this.BoardCardStored<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISelfVarRef>() != null) ? this.BoardCardStored<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISystemVarRef>() != null) ? this.BoardCardStored<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardPosStored = new TVarRefUnion();
			_o.BoardPosStored.Type = this.BoardPosStoredType;
			switch (this.BoardPosStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IConstVarRef>() != null) ? this.BoardPosStored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IGlobalVarRef>() != null) ? this.BoardPosStored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<IOtherVarRef>() != null) ? this.BoardPosStored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISelfVarRef>() != null) ? this.BoardPosStored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPosStored.Value = ((this.BoardPosStored<ISystemVarRef>() != null) ? this.BoardPosStored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028CB4 RID: 167092 RVA: 0x0059AD38 File Offset: 0x00598F38
		public static Offset<IBvbAiGetBestRearrangeData> Pack(FlatBufferBuilder builder, IBvbAiGetBestRearrangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestRearrangeData>);
			}
			TVarRef boardCardStored_type = (_o.BoardCardStored == null) ? TVarRef.NONE : _o.BoardCardStored.Type;
			int boardCardStoredOffset = (_o.BoardCardStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCardStored);
			TVarRef boardPosStored_type = (_o.BoardPosStored == null) ? TVarRef.NONE : _o.BoardPosStored.Type;
			int boardPosStoredOffset = (_o.BoardPosStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPosStored);
			return IBvbAiGetBestRearrangeData.CreateIBvbAiGetBestRearrangeData(builder, _o.Type, boardCardStored_type, boardCardStoredOffset, boardPosStored_type, boardPosStoredOffset);
		}

		// Token: 0x0400F6E3 RID: 63203
		private Table __p;
	}
}
