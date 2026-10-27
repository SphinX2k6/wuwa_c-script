using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007067 RID: 28775
	public struct ISetResetPosition : IFlatbufferObject
	{
		// Token: 0x1700D5DF RID: 54751
		// (get) Token: 0x06032F2A RID: 208682 RVA: 0x006DF8CE File Offset: 0x006DDACE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032F2B RID: 208683 RVA: 0x006DF8DB File Offset: 0x006DDADB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032F2C RID: 208684 RVA: 0x006DF8E4 File Offset: 0x006DDAE4
		public static ISetResetPosition GetRootAsISetResetPosition(ByteBuffer _bb)
		{
			return ISetResetPosition.GetRootAsISetResetPosition(_bb, default(ISetResetPosition));
		}

		// Token: 0x06032F2D RID: 208685 RVA: 0x006DF900 File Offset: 0x006DDB00
		public static ISetResetPosition GetRootAsISetResetPosition(ByteBuffer _bb, ISetResetPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032F2E RID: 208686 RVA: 0x006DF91D File Offset: 0x006DDB1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032F2F RID: 208687 RVA: 0x006DF92C File Offset: 0x006DDB2C
		public ISetResetPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5E0 RID: 54752
		// (get) Token: 0x06032F30 RID: 208688 RVA: 0x006DF93C File Offset: 0x006DDB3C
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

		// Token: 0x1700D5E1 RID: 54753
		// (get) Token: 0x06032F31 RID: 208689 RVA: 0x006DF978 File Offset: 0x006DDB78
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

		// Token: 0x1700D5E2 RID: 54754
		// (get) Token: 0x06032F32 RID: 208690 RVA: 0x006DF9B4 File Offset: 0x006DDBB4
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

		// Token: 0x06032F33 RID: 208691 RVA: 0x006DF9F0 File Offset: 0x006DDBF0
		public static Offset<ISetResetPosition> CreateISetResetPosition(FlatBufferBuilder builder, ESetTeleControlType Type = ESetTeleControlType.OpenGravity, int EntityId = 0, int PositionEntityId = 0)
		{
			builder.StartTable(3);
			ISetResetPosition.AddPositionEntityId(builder, PositionEntityId);
			ISetResetPosition.AddEntityId(builder, EntityId);
			ISetResetPosition.AddType(builder, Type);
			return ISetResetPosition.EndISetResetPosition(builder);
		}

		// Token: 0x06032F34 RID: 208692 RVA: 0x006DFA14 File Offset: 0x006DDC14
		public static void StartISetResetPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032F35 RID: 208693 RVA: 0x006DFA1D File Offset: 0x006DDC1D
		public static void AddType(FlatBufferBuilder builder, ESetTeleControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032F36 RID: 208694 RVA: 0x006DFA28 File Offset: 0x006DDC28
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06032F37 RID: 208695 RVA: 0x006DFA33 File Offset: 0x006DDC33
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x06032F38 RID: 208696 RVA: 0x006DFA3E File Offset: 0x006DDC3E
		public static Offset<ISetResetPosition> EndISetResetPosition(FlatBufferBuilder builder)
		{
			return new Offset<ISetResetPosition>(builder.EndTable());
		}

		// Token: 0x06032F39 RID: 208697 RVA: 0x006DFA4C File Offset: 0x006DDC4C
		public ISetResetPositionT UnPack()
		{
			ISetResetPositionT setResetPositionT = new ISetResetPositionT();
			this.UnPackTo(setResetPositionT);
			return setResetPositionT;
		}

		// Token: 0x06032F3A RID: 208698 RVA: 0x006DFA67 File Offset: 0x006DDC67
		public void UnPackTo(ISetResetPositionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x06032F3B RID: 208699 RVA: 0x006DFA90 File Offset: 0x006DDC90
		public static Offset<ISetResetPosition> Pack(FlatBufferBuilder builder, ISetResetPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetResetPosition>);
			}
			return ISetResetPosition.CreateISetResetPosition(builder, _o.Type, _o.EntityId, _o.PositionEntityId);
		}

		// Token: 0x04011ACA RID: 72394
		private Table __p;
	}
}
