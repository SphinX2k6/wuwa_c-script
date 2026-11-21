using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006814 RID: 26644
	public struct IAssistCharacterStopMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700C3D5 RID: 50133
		// (get) Token: 0x0602D82F RID: 186415 RVA: 0x0063AC8E File Offset: 0x00638E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D830 RID: 186416 RVA: 0x0063AC9B File Offset: 0x00638E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D831 RID: 186417 RVA: 0x0063ACA4 File Offset: 0x00638EA4
		public static IAssistCharacterStopMoveToPoint GetRootAsIAssistCharacterStopMoveToPoint(ByteBuffer _bb)
		{
			return IAssistCharacterStopMoveToPoint.GetRootAsIAssistCharacterStopMoveToPoint(_bb, default(IAssistCharacterStopMoveToPoint));
		}

		// Token: 0x0602D832 RID: 186418 RVA: 0x0063ACC0 File Offset: 0x00638EC0
		public static IAssistCharacterStopMoveToPoint GetRootAsIAssistCharacterStopMoveToPoint(ByteBuffer _bb, IAssistCharacterStopMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D833 RID: 186419 RVA: 0x0063ACDD File Offset: 0x00638EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D834 RID: 186420 RVA: 0x0063ACEC File Offset: 0x00638EEC
		public IAssistCharacterStopMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3D6 RID: 50134
		// (get) Token: 0x0602D835 RID: 186421 RVA: 0x0063ACFC File Offset: 0x00638EFC
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

		// Token: 0x1700C3D7 RID: 50135
		// (get) Token: 0x0602D836 RID: 186422 RVA: 0x0063AD38 File Offset: 0x00638F38
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

		// Token: 0x0602D837 RID: 186423 RVA: 0x0063AD74 File Offset: 0x00638F74
		public static Offset<IAssistCharacterStopMoveToPoint> CreateIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int AssistCharacterId = 0)
		{
			builder.StartTable(2);
			IAssistCharacterStopMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAssistCharacterStopMoveToPoint.AddType(builder, Type);
			return IAssistCharacterStopMoveToPoint.EndIAssistCharacterStopMoveToPoint(builder);
		}

		// Token: 0x0602D838 RID: 186424 RVA: 0x0063AD91 File Offset: 0x00638F91
		public static void StartIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D839 RID: 186425 RVA: 0x0063AD9A File Offset: 0x00638F9A
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D83A RID: 186426 RVA: 0x0063ADA5 File Offset: 0x00638FA5
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602D83B RID: 186427 RVA: 0x0063ADB0 File Offset: 0x00638FB0
		public static Offset<IAssistCharacterStopMoveToPoint> EndIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterStopMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602D83C RID: 186428 RVA: 0x0063ADC0 File Offset: 0x00638FC0
		public IAssistCharacterStopMoveToPointT UnPack()
		{
			IAssistCharacterStopMoveToPointT assistCharacterStopMoveToPointT = new IAssistCharacterStopMoveToPointT();
			this.UnPackTo(assistCharacterStopMoveToPointT);
			return assistCharacterStopMoveToPointT;
		}

		// Token: 0x0602D83D RID: 186429 RVA: 0x0063ADDB File Offset: 0x00638FDB
		public void UnPackTo(IAssistCharacterStopMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
		}

		// Token: 0x0602D83E RID: 186430 RVA: 0x0063ADF8 File Offset: 0x00638FF8
		public static Offset<IAssistCharacterStopMoveToPoint> Pack(FlatBufferBuilder builder, IAssistCharacterStopMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterStopMoveToPoint>);
			}
			return IAssistCharacterStopMoveToPoint.CreateIAssistCharacterStopMoveToPoint(builder, _o.Type, _o.AssistCharacterId);
		}

		// Token: 0x040114CC RID: 70860
		private Table __p;
	}
}
