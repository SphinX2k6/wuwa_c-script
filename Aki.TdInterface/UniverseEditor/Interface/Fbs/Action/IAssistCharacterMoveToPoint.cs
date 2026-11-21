using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006802 RID: 26626
	public struct IAssistCharacterMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700C3B8 RID: 50104
		// (get) Token: 0x0602D7AB RID: 186283 RVA: 0x00639EAA File Offset: 0x006380AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7AC RID: 186284 RVA: 0x00639EB7 File Offset: 0x006380B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7AD RID: 186285 RVA: 0x00639EC0 File Offset: 0x006380C0
		public static IAssistCharacterMoveToPoint GetRootAsIAssistCharacterMoveToPoint(ByteBuffer _bb)
		{
			return IAssistCharacterMoveToPoint.GetRootAsIAssistCharacterMoveToPoint(_bb, default(IAssistCharacterMoveToPoint));
		}

		// Token: 0x0602D7AE RID: 186286 RVA: 0x00639EDC File Offset: 0x006380DC
		public static IAssistCharacterMoveToPoint GetRootAsIAssistCharacterMoveToPoint(ByteBuffer _bb, IAssistCharacterMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7AF RID: 186287 RVA: 0x00639EF9 File Offset: 0x006380F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7B0 RID: 186288 RVA: 0x00639F08 File Offset: 0x00638108
		public IAssistCharacterMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3B9 RID: 50105
		// (get) Token: 0x0602D7B1 RID: 186289 RVA: 0x00639F18 File Offset: 0x00638118
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3BA RID: 50106
		// (get) Token: 0x0602D7B2 RID: 186290 RVA: 0x00639F54 File Offset: 0x00638154
		public int AssistCharacterId
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

		// Token: 0x1700C3BB RID: 50107
		// (get) Token: 0x0602D7B3 RID: 186291 RVA: 0x00639F90 File Offset: 0x00638190
		public TAssistCharacterMoveType MoveTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TAssistCharacterMoveType.NONE;
				}
				return (TAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D7B4 RID: 186292 RVA: 0x00639FCC File Offset: 0x006381CC
		public TTable? MoveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D7B5 RID: 186293 RVA: 0x0063A014 File Offset: 0x00638214
		public IAssistCharacterNavigationMove MoveTypeAsIAssistCharacterNavigationMove()
		{
			return this.MoveType<IAssistCharacterNavigationMove>().Value;
		}

		// Token: 0x0602D7B6 RID: 186294 RVA: 0x0063A030 File Offset: 0x00638230
		public IAssistCharacterSplineMove MoveTypeAsIAssistCharacterSplineMove()
		{
			return this.MoveType<IAssistCharacterSplineMove>().Value;
		}

		// Token: 0x0602D7B7 RID: 186295 RVA: 0x0063A04B File Offset: 0x0063824B
		public static Offset<IAssistCharacterMoveToPoint> CreateIAssistCharacterMoveToPoint(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int AssistCharacterId = 0, TAssistCharacterMoveType MoveType_type = TAssistCharacterMoveType.NONE, int MoveTypeOffset = 0)
		{
			builder.StartTable(4);
			IAssistCharacterMoveToPoint.AddMoveType(builder, MoveTypeOffset);
			IAssistCharacterMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAssistCharacterMoveToPoint.AddMoveTypeType(builder, MoveType_type);
			IAssistCharacterMoveToPoint.AddType(builder, Type);
			return IAssistCharacterMoveToPoint.EndIAssistCharacterMoveToPoint(builder);
		}

		// Token: 0x0602D7B8 RID: 186296 RVA: 0x0063A077 File Offset: 0x00638277
		public static void StartIAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D7B9 RID: 186297 RVA: 0x0063A080 File Offset: 0x00638280
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7BA RID: 186298 RVA: 0x0063A08B File Offset: 0x0063828B
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602D7BB RID: 186299 RVA: 0x0063A096 File Offset: 0x00638296
		public static void AddMoveTypeType(FlatBufferBuilder builder, TAssistCharacterMoveType moveTypeType)
		{
			builder.AddByte(2, (byte)moveTypeType, 0);
		}

		// Token: 0x0602D7BC RID: 186300 RVA: 0x0063A0A1 File Offset: 0x006382A1
		public static void AddMoveType(FlatBufferBuilder builder, int moveTypeOffset)
		{
			builder.AddOffset(3, moveTypeOffset, 0);
		}

		// Token: 0x0602D7BD RID: 186301 RVA: 0x0063A0AC File Offset: 0x006382AC
		public static Offset<IAssistCharacterMoveToPoint> EndIAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602D7BE RID: 186302 RVA: 0x0063A0BC File Offset: 0x006382BC
		public IAssistCharacterMoveToPointT UnPack()
		{
			IAssistCharacterMoveToPointT assistCharacterMoveToPointT = new IAssistCharacterMoveToPointT();
			this.UnPackTo(assistCharacterMoveToPointT);
			return assistCharacterMoveToPointT;
		}

		// Token: 0x0602D7BF RID: 186303 RVA: 0x0063A0D8 File Offset: 0x006382D8
		public void UnPackTo(IAssistCharacterMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
			_o.MoveType = new TAssistCharacterMoveTypeUnion();
			_o.MoveType.Type = this.MoveTypeType;
			TAssistCharacterMoveType moveTypeType = this.MoveTypeType;
			if (moveTypeType == TAssistCharacterMoveType.IAssistCharacterNavigationMove)
			{
				_o.MoveType.Value = ((this.MoveType<IAssistCharacterNavigationMove>() != null) ? this.MoveType<IAssistCharacterNavigationMove>().Value.UnPack() : null);
				return;
			}
			if (moveTypeType != TAssistCharacterMoveType.IAssistCharacterSplineMove)
			{
				return;
			}
			_o.MoveType.Value = ((this.MoveType<IAssistCharacterSplineMove>() != null) ? this.MoveType<IAssistCharacterSplineMove>().Value.UnPack() : null);
		}

		// Token: 0x0602D7C0 RID: 186304 RVA: 0x0063A194 File Offset: 0x00638394
		public static Offset<IAssistCharacterMoveToPoint> Pack(FlatBufferBuilder builder, IAssistCharacterMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterMoveToPoint>);
			}
			TAssistCharacterMoveType moveType_type = (_o.MoveType == null) ? TAssistCharacterMoveType.NONE : _o.MoveType.Type;
			int moveTypeOffset = (_o.MoveType == null) ? 0 : TAssistCharacterMoveTypeUnion.Pack(builder, _o.MoveType);
			return IAssistCharacterMoveToPoint.CreateIAssistCharacterMoveToPoint(builder, _o.Type, _o.AssistCharacterId, moveType_type, moveTypeOffset);
		}

		// Token: 0x040114B5 RID: 70837
		private Table __p;
	}
}
