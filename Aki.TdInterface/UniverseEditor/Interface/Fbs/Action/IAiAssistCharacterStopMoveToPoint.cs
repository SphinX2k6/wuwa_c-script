using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E1 RID: 26593
	public struct IAiAssistCharacterStopMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700C380 RID: 50048
		// (get) Token: 0x0602D6BB RID: 186043 RVA: 0x006386D4 File Offset: 0x006368D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D6BC RID: 186044 RVA: 0x006386E1 File Offset: 0x006368E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D6BD RID: 186045 RVA: 0x006386E8 File Offset: 0x006368E8
		public static IAiAssistCharacterStopMoveToPoint GetRootAsIAiAssistCharacterStopMoveToPoint(ByteBuffer _bb)
		{
			return IAiAssistCharacterStopMoveToPoint.GetRootAsIAiAssistCharacterStopMoveToPoint(_bb, default(IAiAssistCharacterStopMoveToPoint));
		}

		// Token: 0x0602D6BE RID: 186046 RVA: 0x00638704 File Offset: 0x00636904
		public static IAiAssistCharacterStopMoveToPoint GetRootAsIAiAssistCharacterStopMoveToPoint(ByteBuffer _bb, IAiAssistCharacterStopMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D6BF RID: 186047 RVA: 0x00638721 File Offset: 0x00636921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D6C0 RID: 186048 RVA: 0x00638730 File Offset: 0x00636930
		public IAiAssistCharacterStopMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C381 RID: 50049
		// (get) Token: 0x0602D6C1 RID: 186049 RVA: 0x00638740 File Offset: 0x00636940
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

		// Token: 0x1700C382 RID: 50050
		// (get) Token: 0x0602D6C2 RID: 186050 RVA: 0x0063877C File Offset: 0x0063697C
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

		// Token: 0x0602D6C3 RID: 186051 RVA: 0x006387B8 File Offset: 0x006369B8
		public static Offset<IAiAssistCharacterStopMoveToPoint> CreateIAiAssistCharacterStopMoveToPoint(FlatBufferBuilder builder, EExecBattleActionType Type = EExecBattleActionType.SetBattleTags, int AssistCharacterId = 0)
		{
			builder.StartTable(2);
			IAiAssistCharacterStopMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAiAssistCharacterStopMoveToPoint.AddType(builder, Type);
			return IAiAssistCharacterStopMoveToPoint.EndIAiAssistCharacterStopMoveToPoint(builder);
		}

		// Token: 0x0602D6C4 RID: 186052 RVA: 0x006387D5 File Offset: 0x006369D5
		public static void StartIAiAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D6C5 RID: 186053 RVA: 0x006387DE File Offset: 0x006369DE
		public static void AddType(FlatBufferBuilder builder, EExecBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D6C6 RID: 186054 RVA: 0x006387E9 File Offset: 0x006369E9
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602D6C7 RID: 186055 RVA: 0x006387F4 File Offset: 0x006369F4
		public static Offset<IAiAssistCharacterStopMoveToPoint> EndIAiAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAiAssistCharacterStopMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602D6C8 RID: 186056 RVA: 0x00638804 File Offset: 0x00636A04
		public IAiAssistCharacterStopMoveToPointT UnPack()
		{
			IAiAssistCharacterStopMoveToPointT aiAssistCharacterStopMoveToPointT = new IAiAssistCharacterStopMoveToPointT();
			this.UnPackTo(aiAssistCharacterStopMoveToPointT);
			return aiAssistCharacterStopMoveToPointT;
		}

		// Token: 0x0602D6C9 RID: 186057 RVA: 0x0063881F File Offset: 0x00636A1F
		public void UnPackTo(IAiAssistCharacterStopMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
		}

		// Token: 0x0602D6CA RID: 186058 RVA: 0x0063883C File Offset: 0x00636A3C
		public static Offset<IAiAssistCharacterStopMoveToPoint> Pack(FlatBufferBuilder builder, IAiAssistCharacterStopMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiAssistCharacterStopMoveToPoint>);
			}
			return IAiAssistCharacterStopMoveToPoint.CreateIAiAssistCharacterStopMoveToPoint(builder, _o.Type, _o.AssistCharacterId);
		}

		// Token: 0x04011482 RID: 70786
		private Table __p;
	}
}
