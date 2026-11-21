using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200636E RID: 25454
	public struct IBvbAiGetBestSwapData : IFlatbufferObject
	{
		// Token: 0x1700BC41 RID: 48193
		// (get) Token: 0x0602B34F RID: 176975 RVA: 0x005E40D0 File Offset: 0x005E22D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B350 RID: 176976 RVA: 0x005E40DD File Offset: 0x005E22DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B351 RID: 176977 RVA: 0x005E40E4 File Offset: 0x005E22E4
		public static IBvbAiGetBestSwapData GetRootAsIBvbAiGetBestSwapData(ByteBuffer _bb)
		{
			return IBvbAiGetBestSwapData.GetRootAsIBvbAiGetBestSwapData(_bb, default(IBvbAiGetBestSwapData));
		}

		// Token: 0x0602B352 RID: 176978 RVA: 0x005E4100 File Offset: 0x005E2300
		public static IBvbAiGetBestSwapData GetRootAsIBvbAiGetBestSwapData(ByteBuffer _bb, IBvbAiGetBestSwapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B353 RID: 176979 RVA: 0x005E411D File Offset: 0x005E231D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B354 RID: 176980 RVA: 0x005E412C File Offset: 0x005E232C
		public IBvbAiGetBestSwapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC42 RID: 48194
		// (get) Token: 0x0602B355 RID: 176981 RVA: 0x005E413C File Offset: 0x005E233C
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

		// Token: 0x1700BC43 RID: 48195
		// (get) Token: 0x0602B356 RID: 176982 RVA: 0x005E4178 File Offset: 0x005E2378
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

		// Token: 0x0602B357 RID: 176983 RVA: 0x005E41B4 File Offset: 0x005E23B4
		public TTable? BoardCard1Stored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B358 RID: 176984 RVA: 0x005E41F8 File Offset: 0x005E23F8
		public IConstVarRef BoardCard1StoredAsIConstVarRef()
		{
			return this.BoardCard1Stored<IConstVarRef>().Value;
		}

		// Token: 0x0602B359 RID: 176985 RVA: 0x005E4214 File Offset: 0x005E2414
		public IGlobalVarRef BoardCard1StoredAsIGlobalVarRef()
		{
			return this.BoardCard1Stored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B35A RID: 176986 RVA: 0x005E4230 File Offset: 0x005E2430
		public IOtherVarRef BoardCard1StoredAsIOtherVarRef()
		{
			return this.BoardCard1Stored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B35B RID: 176987 RVA: 0x005E424C File Offset: 0x005E244C
		public ISelfVarRef BoardCard1StoredAsISelfVarRef()
		{
			return this.BoardCard1Stored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B35C RID: 176988 RVA: 0x005E4268 File Offset: 0x005E2468
		public ISystemVarRef BoardCard1StoredAsISystemVarRef()
		{
			return this.BoardCard1Stored<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC44 RID: 48196
		// (get) Token: 0x0602B35D RID: 176989 RVA: 0x005E4284 File Offset: 0x005E2484
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

		// Token: 0x0602B35E RID: 176990 RVA: 0x005E42C4 File Offset: 0x005E24C4
		public TTable? BoardCard2Stored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B35F RID: 176991 RVA: 0x005E430C File Offset: 0x005E250C
		public IConstVarRef BoardCard2StoredAsIConstVarRef()
		{
			return this.BoardCard2Stored<IConstVarRef>().Value;
		}

		// Token: 0x0602B360 RID: 176992 RVA: 0x005E4328 File Offset: 0x005E2528
		public IGlobalVarRef BoardCard2StoredAsIGlobalVarRef()
		{
			return this.BoardCard2Stored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B361 RID: 176993 RVA: 0x005E4344 File Offset: 0x005E2544
		public IOtherVarRef BoardCard2StoredAsIOtherVarRef()
		{
			return this.BoardCard2Stored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B362 RID: 176994 RVA: 0x005E4360 File Offset: 0x005E2560
		public ISelfVarRef BoardCard2StoredAsISelfVarRef()
		{
			return this.BoardCard2Stored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B363 RID: 176995 RVA: 0x005E437C File Offset: 0x005E257C
		public ISystemVarRef BoardCard2StoredAsISystemVarRef()
		{
			return this.BoardCard2Stored<ISystemVarRef>().Value;
		}

		// Token: 0x0602B364 RID: 176996 RVA: 0x005E4397 File Offset: 0x005E2597
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

		// Token: 0x0602B365 RID: 176997 RVA: 0x005E43CB File Offset: 0x005E25CB
		public static void StartIBvbAiGetBestSwapData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B366 RID: 176998 RVA: 0x005E43D4 File Offset: 0x005E25D4
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B367 RID: 176999 RVA: 0x005E43DF File Offset: 0x005E25DF
		public static void AddBoardCard1StoredType(FlatBufferBuilder builder, TVarRef boardCard1StoredType)
		{
			builder.AddByte(1, (byte)boardCard1StoredType, 0);
		}

		// Token: 0x0602B368 RID: 177000 RVA: 0x005E43EA File Offset: 0x005E25EA
		public static void AddBoardCard1Stored(FlatBufferBuilder builder, int boardCard1StoredOffset)
		{
			builder.AddOffset(2, boardCard1StoredOffset, 0);
		}

		// Token: 0x0602B369 RID: 177001 RVA: 0x005E43F5 File Offset: 0x005E25F5
		public static void AddBoardCard2StoredType(FlatBufferBuilder builder, TVarRef boardCard2StoredType)
		{
			builder.AddByte(3, (byte)boardCard2StoredType, 0);
		}

		// Token: 0x0602B36A RID: 177002 RVA: 0x005E4400 File Offset: 0x005E2600
		public static void AddBoardCard2Stored(FlatBufferBuilder builder, int boardCard2StoredOffset)
		{
			builder.AddOffset(4, boardCard2StoredOffset, 0);
		}

		// Token: 0x0602B36B RID: 177003 RVA: 0x005E440B File Offset: 0x005E260B
		public static Offset<IBvbAiGetBestSwapData> EndIBvbAiGetBestSwapData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestSwapData>(builder.EndTable());
		}

		// Token: 0x0602B36C RID: 177004 RVA: 0x005E4418 File Offset: 0x005E2618
		public IBvbAiGetBestSwapDataT UnPack()
		{
			IBvbAiGetBestSwapDataT bvbAiGetBestSwapDataT = new IBvbAiGetBestSwapDataT();
			this.UnPackTo(bvbAiGetBestSwapDataT);
			return bvbAiGetBestSwapDataT;
		}

		// Token: 0x0602B36D RID: 177005 RVA: 0x005E4434 File Offset: 0x005E2634
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

		// Token: 0x0602B36E RID: 177006 RVA: 0x005E4700 File Offset: 0x005E2900
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

		// Token: 0x0401043D RID: 66621
		private Table __p;
	}
}
