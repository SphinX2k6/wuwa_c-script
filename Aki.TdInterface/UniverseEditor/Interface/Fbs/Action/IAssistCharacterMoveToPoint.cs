using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006197 RID: 24983
	public struct IAssistCharacterMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700BA3A RID: 47674
		// (get) Token: 0x0602B07A RID: 176250 RVA: 0x005EF636 File Offset: 0x005ED836
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B07B RID: 176251 RVA: 0x005EF643 File Offset: 0x005ED843
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B07C RID: 176252 RVA: 0x005EF64C File Offset: 0x005ED84C
		public static IAssistCharacterMoveToPoint GetRootAsIAssistCharacterMoveToPoint(ByteBuffer _bb)
		{
			return IAssistCharacterMoveToPoint.GetRootAsIAssistCharacterMoveToPoint(_bb, default(IAssistCharacterMoveToPoint));
		}

		// Token: 0x0602B07D RID: 176253 RVA: 0x005EF668 File Offset: 0x005ED868
		public static IAssistCharacterMoveToPoint GetRootAsIAssistCharacterMoveToPoint(ByteBuffer _bb, IAssistCharacterMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B07E RID: 176254 RVA: 0x005EF685 File Offset: 0x005ED885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B07F RID: 176255 RVA: 0x005EF694 File Offset: 0x005ED894
		public IAssistCharacterMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA3B RID: 47675
		// (get) Token: 0x0602B080 RID: 176256 RVA: 0x005EF6A4 File Offset: 0x005ED8A4
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

		// Token: 0x1700BA3C RID: 47676
		// (get) Token: 0x0602B081 RID: 176257 RVA: 0x005EF6E0 File Offset: 0x005ED8E0
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

		// Token: 0x1700BA3D RID: 47677
		// (get) Token: 0x0602B082 RID: 176258 RVA: 0x005EF71C File Offset: 0x005ED91C
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

		// Token: 0x0602B083 RID: 176259 RVA: 0x005EF758 File Offset: 0x005ED958
		public TTable? MoveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B084 RID: 176260 RVA: 0x005EF7A0 File Offset: 0x005ED9A0
		public IAssistCharacterNavigationMove MoveTypeAsIAssistCharacterNavigationMove()
		{
			return this.MoveType<IAssistCharacterNavigationMove>().Value;
		}

		// Token: 0x0602B085 RID: 176261 RVA: 0x005EF7BC File Offset: 0x005ED9BC
		public IAssistCharacterSplineMove MoveTypeAsIAssistCharacterSplineMove()
		{
			return this.MoveType<IAssistCharacterSplineMove>().Value;
		}

		// Token: 0x0602B086 RID: 176262 RVA: 0x005EF7D7 File Offset: 0x005ED9D7
		public static Offset<IAssistCharacterMoveToPoint> CreateIAssistCharacterMoveToPoint(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int AssistCharacterId = 0, TAssistCharacterMoveType MoveType_type = TAssistCharacterMoveType.NONE, int MoveTypeOffset = 0)
		{
			builder.StartTable(4);
			IAssistCharacterMoveToPoint.AddMoveType(builder, MoveTypeOffset);
			IAssistCharacterMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAssistCharacterMoveToPoint.AddMoveTypeType(builder, MoveType_type);
			IAssistCharacterMoveToPoint.AddType(builder, Type);
			return IAssistCharacterMoveToPoint.EndIAssistCharacterMoveToPoint(builder);
		}

		// Token: 0x0602B087 RID: 176263 RVA: 0x005EF803 File Offset: 0x005EDA03
		public static void StartIAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B088 RID: 176264 RVA: 0x005EF80C File Offset: 0x005EDA0C
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B089 RID: 176265 RVA: 0x005EF817 File Offset: 0x005EDA17
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602B08A RID: 176266 RVA: 0x005EF822 File Offset: 0x005EDA22
		public static void AddMoveTypeType(FlatBufferBuilder builder, TAssistCharacterMoveType moveTypeType)
		{
			builder.AddByte(2, (byte)moveTypeType, 0);
		}

		// Token: 0x0602B08B RID: 176267 RVA: 0x005EF82D File Offset: 0x005EDA2D
		public static void AddMoveType(FlatBufferBuilder builder, int moveTypeOffset)
		{
			builder.AddOffset(3, moveTypeOffset, 0);
		}

		// Token: 0x0602B08C RID: 176268 RVA: 0x005EF838 File Offset: 0x005EDA38
		public static Offset<IAssistCharacterMoveToPoint> EndIAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602B08D RID: 176269 RVA: 0x005EF848 File Offset: 0x005EDA48
		public IAssistCharacterMoveToPointT UnPack()
		{
			IAssistCharacterMoveToPointT assistCharacterMoveToPointT = new IAssistCharacterMoveToPointT();
			this.UnPackTo(assistCharacterMoveToPointT);
			return assistCharacterMoveToPointT;
		}

		// Token: 0x0602B08E RID: 176270 RVA: 0x005EF864 File Offset: 0x005EDA64
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

		// Token: 0x0602B08F RID: 176271 RVA: 0x005EF920 File Offset: 0x005EDB20
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

		// Token: 0x040106A6 RID: 67238
		private Table __p;
	}
}
