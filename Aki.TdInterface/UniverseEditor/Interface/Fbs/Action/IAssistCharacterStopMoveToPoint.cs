using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A6 RID: 24998
	public struct IAssistCharacterStopMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700BA52 RID: 47698
		// (get) Token: 0x0602B0E8 RID: 176360 RVA: 0x005F021A File Offset: 0x005EE41A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B0E9 RID: 176361 RVA: 0x005F0227 File Offset: 0x005EE427
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B0EA RID: 176362 RVA: 0x005F0230 File Offset: 0x005EE430
		public static IAssistCharacterStopMoveToPoint GetRootAsIAssistCharacterStopMoveToPoint(ByteBuffer _bb)
		{
			return IAssistCharacterStopMoveToPoint.GetRootAsIAssistCharacterStopMoveToPoint(_bb, default(IAssistCharacterStopMoveToPoint));
		}

		// Token: 0x0602B0EB RID: 176363 RVA: 0x005F024C File Offset: 0x005EE44C
		public static IAssistCharacterStopMoveToPoint GetRootAsIAssistCharacterStopMoveToPoint(ByteBuffer _bb, IAssistCharacterStopMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B0EC RID: 176364 RVA: 0x005F0269 File Offset: 0x005EE469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B0ED RID: 176365 RVA: 0x005F0278 File Offset: 0x005EE478
		public IAssistCharacterStopMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA53 RID: 47699
		// (get) Token: 0x0602B0EE RID: 176366 RVA: 0x005F0288 File Offset: 0x005EE488
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

		// Token: 0x1700BA54 RID: 47700
		// (get) Token: 0x0602B0EF RID: 176367 RVA: 0x005F02C4 File Offset: 0x005EE4C4
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

		// Token: 0x0602B0F0 RID: 176368 RVA: 0x005F0300 File Offset: 0x005EE500
		public static Offset<IAssistCharacterStopMoveToPoint> CreateIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int AssistCharacterId = 0)
		{
			builder.StartTable(2);
			IAssistCharacterStopMoveToPoint.AddAssistCharacterId(builder, AssistCharacterId);
			IAssistCharacterStopMoveToPoint.AddType(builder, Type);
			return IAssistCharacterStopMoveToPoint.EndIAssistCharacterStopMoveToPoint(builder);
		}

		// Token: 0x0602B0F1 RID: 176369 RVA: 0x005F031D File Offset: 0x005EE51D
		public static void StartIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B0F2 RID: 176370 RVA: 0x005F0326 File Offset: 0x005EE526
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B0F3 RID: 176371 RVA: 0x005F0331 File Offset: 0x005EE531
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x0602B0F4 RID: 176372 RVA: 0x005F033C File Offset: 0x005EE53C
		public static Offset<IAssistCharacterStopMoveToPoint> EndIAssistCharacterStopMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterStopMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602B0F5 RID: 176373 RVA: 0x005F034C File Offset: 0x005EE54C
		public IAssistCharacterStopMoveToPointT UnPack()
		{
			IAssistCharacterStopMoveToPointT assistCharacterStopMoveToPointT = new IAssistCharacterStopMoveToPointT();
			this.UnPackTo(assistCharacterStopMoveToPointT);
			return assistCharacterStopMoveToPointT;
		}

		// Token: 0x0602B0F6 RID: 176374 RVA: 0x005F0367 File Offset: 0x005EE567
		public void UnPackTo(IAssistCharacterStopMoveToPointT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
		}

		// Token: 0x0602B0F7 RID: 176375 RVA: 0x005F0384 File Offset: 0x005EE584
		public static Offset<IAssistCharacterStopMoveToPoint> Pack(FlatBufferBuilder builder, IAssistCharacterStopMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterStopMoveToPoint>);
			}
			return IAssistCharacterStopMoveToPoint.CreateIAssistCharacterStopMoveToPoint(builder, _o.Type, _o.AssistCharacterId);
		}

		// Token: 0x040106BA RID: 67258
		private Table __p;
	}
}
