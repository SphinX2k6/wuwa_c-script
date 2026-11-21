using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200636B RID: 25451
	public struct IBvbAiGetBestReplaceData : IFlatbufferObject
	{
		// Token: 0x1700BC3A RID: 48186
		// (get) Token: 0x0602B327 RID: 176935 RVA: 0x005E3924 File Offset: 0x005E1B24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B328 RID: 176936 RVA: 0x005E3931 File Offset: 0x005E1B31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B329 RID: 176937 RVA: 0x005E3938 File Offset: 0x005E1B38
		public static IBvbAiGetBestReplaceData GetRootAsIBvbAiGetBestReplaceData(ByteBuffer _bb)
		{
			return IBvbAiGetBestReplaceData.GetRootAsIBvbAiGetBestReplaceData(_bb, default(IBvbAiGetBestReplaceData));
		}

		// Token: 0x0602B32A RID: 176938 RVA: 0x005E3954 File Offset: 0x005E1B54
		public static IBvbAiGetBestReplaceData GetRootAsIBvbAiGetBestReplaceData(ByteBuffer _bb, IBvbAiGetBestReplaceData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B32B RID: 176939 RVA: 0x005E3971 File Offset: 0x005E1B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B32C RID: 176940 RVA: 0x005E3980 File Offset: 0x005E1B80
		public IBvbAiGetBestReplaceData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC3B RID: 48187
		// (get) Token: 0x0602B32D RID: 176941 RVA: 0x005E3990 File Offset: 0x005E1B90
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

		// Token: 0x1700BC3C RID: 48188
		// (get) Token: 0x0602B32E RID: 176942 RVA: 0x005E39CC File Offset: 0x005E1BCC
		public TVarRef HandCardType
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

		// Token: 0x0602B32F RID: 176943 RVA: 0x005E3A08 File Offset: 0x005E1C08
		public TTable? HandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B330 RID: 176944 RVA: 0x005E3A4C File Offset: 0x005E1C4C
		public IConstVarRef HandCardAsIConstVarRef()
		{
			return this.HandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B331 RID: 176945 RVA: 0x005E3A68 File Offset: 0x005E1C68
		public IGlobalVarRef HandCardAsIGlobalVarRef()
		{
			return this.HandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B332 RID: 176946 RVA: 0x005E3A84 File Offset: 0x005E1C84
		public IOtherVarRef HandCardAsIOtherVarRef()
		{
			return this.HandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B333 RID: 176947 RVA: 0x005E3AA0 File Offset: 0x005E1CA0
		public ISelfVarRef HandCardAsISelfVarRef()
		{
			return this.HandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B334 RID: 176948 RVA: 0x005E3ABC File Offset: 0x005E1CBC
		public ISystemVarRef HandCardAsISystemVarRef()
		{
			return this.HandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BC3D RID: 48189
		// (get) Token: 0x0602B335 RID: 176949 RVA: 0x005E3AD8 File Offset: 0x005E1CD8
		public TVarRef BoardCardStoredType
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

		// Token: 0x0602B336 RID: 176950 RVA: 0x005E3B18 File Offset: 0x005E1D18
		public TTable? BoardCardStored<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B337 RID: 176951 RVA: 0x005E3B60 File Offset: 0x005E1D60
		public IConstVarRef BoardCardStoredAsIConstVarRef()
		{
			return this.BoardCardStored<IConstVarRef>().Value;
		}

		// Token: 0x0602B338 RID: 176952 RVA: 0x005E3B7C File Offset: 0x005E1D7C
		public IGlobalVarRef BoardCardStoredAsIGlobalVarRef()
		{
			return this.BoardCardStored<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B339 RID: 176953 RVA: 0x005E3B98 File Offset: 0x005E1D98
		public IOtherVarRef BoardCardStoredAsIOtherVarRef()
		{
			return this.BoardCardStored<IOtherVarRef>().Value;
		}

		// Token: 0x0602B33A RID: 176954 RVA: 0x005E3BB4 File Offset: 0x005E1DB4
		public ISelfVarRef BoardCardStoredAsISelfVarRef()
		{
			return this.BoardCardStored<ISelfVarRef>().Value;
		}

		// Token: 0x0602B33B RID: 176955 RVA: 0x005E3BD0 File Offset: 0x005E1DD0
		public ISystemVarRef BoardCardStoredAsISystemVarRef()
		{
			return this.BoardCardStored<ISystemVarRef>().Value;
		}

		// Token: 0x0602B33C RID: 176956 RVA: 0x005E3BEB File Offset: 0x005E1DEB
		public static Offset<IBvbAiGetBestReplaceData> CreateIBvbAiGetBestReplaceData(FlatBufferBuilder builder, EBvbEventName Type = EBvbEventName.AIEvolution, TVarRef HandCard_type = TVarRef.NONE, int HandCardOffset = 0, TVarRef BoardCardStored_type = TVarRef.NONE, int BoardCardStoredOffset = 0)
		{
			builder.StartTable(5);
			IBvbAiGetBestReplaceData.AddBoardCardStored(builder, BoardCardStoredOffset);
			IBvbAiGetBestReplaceData.AddHandCard(builder, HandCardOffset);
			IBvbAiGetBestReplaceData.AddBoardCardStoredType(builder, BoardCardStored_type);
			IBvbAiGetBestReplaceData.AddHandCardType(builder, HandCard_type);
			IBvbAiGetBestReplaceData.AddType(builder, Type);
			return IBvbAiGetBestReplaceData.EndIBvbAiGetBestReplaceData(builder);
		}

		// Token: 0x0602B33D RID: 176957 RVA: 0x005E3C1F File Offset: 0x005E1E1F
		public static void StartIBvbAiGetBestReplaceData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B33E RID: 176958 RVA: 0x005E3C28 File Offset: 0x005E1E28
		public static void AddType(FlatBufferBuilder builder, EBvbEventName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B33F RID: 176959 RVA: 0x005E3C33 File Offset: 0x005E1E33
		public static void AddHandCardType(FlatBufferBuilder builder, TVarRef handCardType)
		{
			builder.AddByte(1, (byte)handCardType, 0);
		}

		// Token: 0x0602B340 RID: 176960 RVA: 0x005E3C3E File Offset: 0x005E1E3E
		public static void AddHandCard(FlatBufferBuilder builder, int handCardOffset)
		{
			builder.AddOffset(2, handCardOffset, 0);
		}

		// Token: 0x0602B341 RID: 176961 RVA: 0x005E3C49 File Offset: 0x005E1E49
		public static void AddBoardCardStoredType(FlatBufferBuilder builder, TVarRef boardCardStoredType)
		{
			builder.AddByte(3, (byte)boardCardStoredType, 0);
		}

		// Token: 0x0602B342 RID: 176962 RVA: 0x005E3C54 File Offset: 0x005E1E54
		public static void AddBoardCardStored(FlatBufferBuilder builder, int boardCardStoredOffset)
		{
			builder.AddOffset(4, boardCardStoredOffset, 0);
		}

		// Token: 0x0602B343 RID: 176963 RVA: 0x005E3C5F File Offset: 0x005E1E5F
		public static Offset<IBvbAiGetBestReplaceData> EndIBvbAiGetBestReplaceData(FlatBufferBuilder builder)
		{
			return new Offset<IBvbAiGetBestReplaceData>(builder.EndTable());
		}

		// Token: 0x0602B344 RID: 176964 RVA: 0x005E3C6C File Offset: 0x005E1E6C
		public IBvbAiGetBestReplaceDataT UnPack()
		{
			IBvbAiGetBestReplaceDataT bvbAiGetBestReplaceDataT = new IBvbAiGetBestReplaceDataT();
			this.UnPackTo(bvbAiGetBestReplaceDataT);
			return bvbAiGetBestReplaceDataT;
		}

		// Token: 0x0602B345 RID: 176965 RVA: 0x005E3C88 File Offset: 0x005E1E88
		public void UnPackTo(IBvbAiGetBestReplaceDataT _o)
		{
			_o.Type = this.Type;
			_o.HandCard = new TVarRefUnion();
			_o.HandCard.Type = this.HandCardType;
			switch (this.HandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.HandCard.Value = ((this.HandCard<IConstVarRef>() != null) ? this.HandCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.HandCard.Value = ((this.HandCard<IGlobalVarRef>() != null) ? this.HandCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.HandCard.Value = ((this.HandCard<IOtherVarRef>() != null) ? this.HandCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.HandCard.Value = ((this.HandCard<ISelfVarRef>() != null) ? this.HandCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.HandCard.Value = ((this.HandCard<ISystemVarRef>() != null) ? this.HandCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardCardStored = new TVarRefUnion();
			_o.BoardCardStored.Type = this.BoardCardStoredType;
			switch (this.BoardCardStoredType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IConstVarRef>() != null) ? this.BoardCardStored<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IGlobalVarRef>() != null) ? this.BoardCardStored<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<IOtherVarRef>() != null) ? this.BoardCardStored<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISelfVarRef>() != null) ? this.BoardCardStored<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardCardStored.Value = ((this.BoardCardStored<ISystemVarRef>() != null) ? this.BoardCardStored<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B346 RID: 176966 RVA: 0x005E3F54 File Offset: 0x005E2154
		public static Offset<IBvbAiGetBestReplaceData> Pack(FlatBufferBuilder builder, IBvbAiGetBestReplaceDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbAiGetBestReplaceData>);
			}
			TVarRef handCard_type = (_o.HandCard == null) ? TVarRef.NONE : _o.HandCard.Type;
			int handCardOffset = (_o.HandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.HandCard);
			TVarRef boardCardStored_type = (_o.BoardCardStored == null) ? TVarRef.NONE : _o.BoardCardStored.Type;
			int boardCardStoredOffset = (_o.BoardCardStored == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardCardStored);
			return IBvbAiGetBestReplaceData.CreateIBvbAiGetBestReplaceData(builder, _o.Type, handCard_type, handCardOffset, boardCardStored_type, boardCardStoredOffset);
		}

		// Token: 0x04010439 RID: 66617
		private Table __p;
	}
}
