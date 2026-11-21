using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DE RID: 26590
	public struct IAiAssistCharacterMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700C377 RID: 50039
		// (get) Token: 0x0602D699 RID: 186009 RVA: 0x0063823A File Offset: 0x0063643A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D69A RID: 186010 RVA: 0x00638247 File Offset: 0x00636447
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D69B RID: 186011 RVA: 0x00638250 File Offset: 0x00636450
		public static IAiAssistCharacterMoveToPoint GetRootAsIAiAssistCharacterMoveToPoint(ByteBuffer _bb)
		{
			return IAiAssistCharacterMoveToPoint.GetRootAsIAiAssistCharacterMoveToPoint(_bb, default(IAiAssistCharacterMoveToPoint));
		}

		// Token: 0x0602D69C RID: 186012 RVA: 0x0063826C File Offset: 0x0063646C
		public static IAiAssistCharacterMoveToPoint GetRootAsIAiAssistCharacterMoveToPoint(ByteBuffer _bb, IAiAssistCharacterMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D69D RID: 186013 RVA: 0x00638289 File Offset: 0x00636489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D69E RID: 186014 RVA: 0x00638298 File Offset: 0x00636498
		public IAiAssistCharacterMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C378 RID: 50040
		// (get) Token: 0x0602D69F RID: 186015 RVA: 0x006382A8 File Offset: 0x006364A8
		public EExecBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecBattleActionType.SetBattleTags;
				}
				return (EExecBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C379 RID: 50041
		// (get) Token: 0x0602D6A0 RID: 186016 RVA: 0x006382E4 File Offset: 0x006364E4
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

		// Token: 0x1700C37A RID: 50042
		// (get) Token: 0x0602D6A1 RID: 186017 RVA: 0x00638320 File Offset: 0x00636520
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

		// Token: 0x0602D6A2 RID: 186018 RVA: 0x0063835C File Offset: 0x0063655C
		public TTable? MoveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D6A3 RID: 186019 RVA: 0x006383A4 File Offset: 0x006365A4
		public IAssistCharacterNavigationMove MoveTypeAsIAssistCharacterNavigationMove()
		{
			return this.MoveType<IAssistCharacterNavigationMove>().Value;
		}

		// Token: 0x0602D6A4 RID: 186020 RVA: 0x006383C0 File Offset: 0x006365C0
		public IAssistCharacterSplineMove MoveTypeAsIAssistCharacterSplineMove()
		{
			return this.MoveType<IAssistCharacterSplineMove>().Value;
		}

		// Token: 0x1700C37B RID: 50043
		// (get) Token: 0x0602D6A5 RID: 186021 RVA: 0x006383DC File Offset: 0x006365DC
		public int Timeout
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D6A6 RID: 186022 RVA: 0x00638419 File Offset: 0x00636619
		public static Offset<IAiAssistCharacterMoveToPoint> CreateIAiAssistCharacterMoveToPoint(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, int AssistCharacterId = 0, TAssistCharacterMoveType MoveType_type = TAssistCharacterMoveType.NONE, int MoveTypeOffset = 0, int Timeout = 0)
		{
			builder.StartTable(5);
			IAiAssistCharacterMoveToPoint.AddTimeout(builder, Timeout);
			IAiAssistCharacterMoveToPoint.AddMoveType(builder, MoveTypeOffset);
			IAiAssistCharacterMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAiAssistCharacterMoveToPoint.AddMoveTypeType(builder, MoveType_type);
			IAiAssistCharacterMoveToPoint.AddType(builder, Type);
			return IAiAssistCharacterMoveToPoint.EndIAiAssistCharacterMoveToPoint(builder);
		}

		// Token: 0x0602D6A7 RID: 186023 RVA: 0x0063844D File Offset: 0x0063664D
		public static void StartIAiAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602D6A8 RID: 186024 RVA: 0x00638456 File Offset: 0x00636656
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6A9 RID: 186025 RVA: 0x00638461 File Offset: 0x00636661
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602D6AA RID: 186026 RVA: 0x0063846C File Offset: 0x0063666C
		public static void AddMoveTypeType(FlatBufferBuilder builder, TAssistCharacterMoveType moveTypeType)
		{
			builder.AddByte(2, (byte)moveTypeType, 0);
		}

		// Token: 0x0602D6AB RID: 186027 RVA: 0x00638477 File Offset: 0x00636677
		public static void AddMoveType(FlatBufferBuilder builder, int moveTypeOffset)
		{
			builder.AddOffset(3, moveTypeOffset, 0);
		}

		// Token: 0x0602D6AC RID: 186028 RVA: 0x00638482 File Offset: 0x00636682
		public static void AddTimeout(FlatBufferBuilder builder, int timeout)
		{
			builder.AddInt(4, timeout, 0);
		}

		// Token: 0x0602D6AD RID: 186029 RVA: 0x0063848D File Offset: 0x0063668D
		public static Offset<IAiAssistCharacterMoveToPoint> EndIAiAssistCharacterMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAiAssistCharacterMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602D6AE RID: 186030 RVA: 0x0063849C File Offset: 0x0063669C
		public IAiAssistCharacterMoveToPointT UnPack()
		{
			IAiAssistCharacterMoveToPointT aiAssistCharacterMoveToPointT = new IAiAssistCharacterMoveToPointT();
			this.UnPackTo(aiAssistCharacterMoveToPointT);
			return aiAssistCharacterMoveToPointT;
		}

		// Token: 0x0602D6AF RID: 186031 RVA: 0x006384B8 File Offset: 0x006366B8
		public void UnPackTo(IAiAssistCharacterMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
			_o.MoveType = new TAssistCharacterMoveTypeUnion();
			_o.MoveType.Type = this.MoveTypeType;
			TAssistCharacterMoveType moveTypeType = this.MoveTypeType;
			if (moveTypeType != TAssistCharacterMoveType.IAssistCharacterNavigationMove)
			{
				if (moveTypeType == TAssistCharacterMoveType.IAssistCharacterSplineMove)
				{
					_o.MoveType.Value = ((this.MoveType<IAssistCharacterSplineMove>() != null) ? this.MoveType<IAssistCharacterSplineMove>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveType.Value = ((this.MoveType<IAssistCharacterNavigationMove>() != null) ? this.MoveType<IAssistCharacterNavigationMove>().Value.UnPack() : null);
			}
			_o.Timeout = this.Timeout;
		}

		// Token: 0x0602D6B0 RID: 186032 RVA: 0x00638584 File Offset: 0x00636784
		public static Offset<IAiAssistCharacterMoveToPoint> Pack(FlatBufferBuilder builder, IAiAssistCharacterMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiAssistCharacterMoveToPoint>);
			}
			TAssistCharacterMoveType moveType_type = (_o.MoveType == null) ? TAssistCharacterMoveType.NONE : _o.MoveType.Type;
			int moveTypeOffset = (_o.MoveType == null) ? 0 : TAssistCharacterMoveTypeUnion.Pack(builder, _o.MoveType);
			return IAiAssistCharacterMoveToPoint.CreateIAiAssistCharacterMoveToPoint(builder, _o.Type, _o.AssistCharacterId, moveType_type, moveTypeOffset, _o.Timeout);
		}

		// Token: 0x0401147D RID: 70781
		private Table __p;
	}
}
