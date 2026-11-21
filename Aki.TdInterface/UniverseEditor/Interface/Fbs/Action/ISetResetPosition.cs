using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007833 RID: 30771
	public struct ISetResetPosition : IFlatbufferObject
	{
		// Token: 0x1700E1C2 RID: 57794
		// (get) Token: 0x060361CB RID: 221643 RVA: 0x0073FE82 File Offset: 0x0073E082
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361CC RID: 221644 RVA: 0x0073FE8F File Offset: 0x0073E08F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361CD RID: 221645 RVA: 0x0073FE98 File Offset: 0x0073E098
		public static ISetResetPosition GetRootAsISetResetPosition(ByteBuffer _bb)
		{
			return ISetResetPosition.GetRootAsISetResetPosition(_bb, default(ISetResetPosition));
		}

		// Token: 0x060361CE RID: 221646 RVA: 0x0073FEB4 File Offset: 0x0073E0B4
		public static ISetResetPosition GetRootAsISetResetPosition(ByteBuffer _bb, ISetResetPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361CF RID: 221647 RVA: 0x0073FED1 File Offset: 0x0073E0D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361D0 RID: 221648 RVA: 0x0073FEE0 File Offset: 0x0073E0E0
		public ISetResetPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1C3 RID: 57795
		// (get) Token: 0x060361D1 RID: 221649 RVA: 0x0073FEF0 File Offset: 0x0073E0F0
		public ESetTeleControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return (ESetTeleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1C4 RID: 57796
		// (get) Token: 0x060361D2 RID: 221650 RVA: 0x0073FF2C File Offset: 0x0073E12C
		public int EntityId
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

		// Token: 0x1700E1C5 RID: 57797
		// (get) Token: 0x060361D3 RID: 221651 RVA: 0x0073FF68 File Offset: 0x0073E168
		public int PositionEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060361D4 RID: 221652 RVA: 0x0073FFA4 File Offset: 0x0073E1A4
		public static Offset<ISetResetPosition> CreateISetResetPosition(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0, int PositionEntityId = 0)
		{
			builder.StartTable(3);
			ISetResetPosition.AddPositionEntityId(builder, PositionEntityId);
			ISetResetPosition.AddEntityId(builder, EntityId);
			ISetResetPosition.AddType(builder, Type);
			return ISetResetPosition.EndISetResetPosition(builder);
		}

		// Token: 0x060361D5 RID: 221653 RVA: 0x0073FFC8 File Offset: 0x0073E1C8
		public static void StartISetResetPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060361D6 RID: 221654 RVA: 0x0073FFD1 File Offset: 0x0073E1D1
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060361D7 RID: 221655 RVA: 0x0073FFDC File Offset: 0x0073E1DC
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060361D8 RID: 221656 RVA: 0x0073FFE7 File Offset: 0x0073E1E7
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x060361D9 RID: 221657 RVA: 0x0073FFF2 File Offset: 0x0073E1F2
		public static Offset<ISetResetPosition> EndISetResetPosition(FlatBufferBuilder builder)
		{
			return new Offset<ISetResetPosition>(builder.EndTable());
		}

		// Token: 0x060361DA RID: 221658 RVA: 0x00740000 File Offset: 0x0073E200
		public ISetResetPositionT UnPack()
		{
			ISetResetPositionT setResetPositionT = new ISetResetPositionT();
			this.UnPackTo(setResetPositionT);
			return setResetPositionT;
		}

		// Token: 0x060361DB RID: 221659 RVA: 0x0074001B File Offset: 0x0073E21B
		public void UnPackTo(ISetResetPositionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x060361DC RID: 221660 RVA: 0x00740044 File Offset: 0x0073E244
		public static Offset<ISetResetPosition> Pack(FlatBufferBuilder builder, ISetResetPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetResetPosition>);
			}
			return ISetResetPosition.CreateISetResetPosition(builder, _o.Type, _o.EntityId, _o.PositionEntityId);
		}

		// Token: 0x04012AB8 RID: 76472
		private Table __p;
	}
}
