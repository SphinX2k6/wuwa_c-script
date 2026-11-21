using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8F RID: 31887
	public struct ITurntableConnectorUiGameplay : IFlatbufferObject
	{
		// Token: 0x1700EEC8 RID: 61128
		// (get) Token: 0x06039823 RID: 235555 RVA: 0x007C3406 File Offset: 0x007C1606
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039824 RID: 235556 RVA: 0x007C3413 File Offset: 0x007C1613
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039825 RID: 235557 RVA: 0x007C341C File Offset: 0x007C161C
		public static ITurntableConnectorUiGameplay GetRootAsITurntableConnectorUiGameplay(ByteBuffer _bb)
		{
			return ITurntableConnectorUiGameplay.GetRootAsITurntableConnectorUiGameplay(_bb, default(ITurntableConnectorUiGameplay));
		}

		// Token: 0x06039826 RID: 235558 RVA: 0x007C3438 File Offset: 0x007C1638
		public static ITurntableConnectorUiGameplay GetRootAsITurntableConnectorUiGameplay(ByteBuffer _bb, ITurntableConnectorUiGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039827 RID: 235559 RVA: 0x007C3455 File Offset: 0x007C1655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039828 RID: 235560 RVA: 0x007C3464 File Offset: 0x007C1664
		public ITurntableConnectorUiGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEC9 RID: 61129
		// (get) Token: 0x06039829 RID: 235561 RVA: 0x007C3474 File Offset: 0x007C1674
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EECA RID: 61130
		// (get) Token: 0x0603982A RID: 235562 RVA: 0x007C34B0 File Offset: 0x007C16B0
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

		// Token: 0x0603982B RID: 235563 RVA: 0x007C34EC File Offset: 0x007C16EC
		public static Offset<ITurntableConnectorUiGameplay> CreateITurntableConnectorUiGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int EntityId = 0)
		{
			builder.StartTable(2);
			ITurntableConnectorUiGameplay.AddEntityId(builder, EntityId);
			ITurntableConnectorUiGameplay.AddType(builder, Type);
			return ITurntableConnectorUiGameplay.EndITurntableConnectorUiGameplay(builder);
		}

		// Token: 0x0603982C RID: 235564 RVA: 0x007C3509 File Offset: 0x007C1709
		public static void StartITurntableConnectorUiGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603982D RID: 235565 RVA: 0x007C3512 File Offset: 0x007C1712
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603982E RID: 235566 RVA: 0x007C351D File Offset: 0x007C171D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0603982F RID: 235567 RVA: 0x007C3528 File Offset: 0x007C1728
		public static Offset<ITurntableConnectorUiGameplay> EndITurntableConnectorUiGameplay(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorUiGameplay>(builder.EndTable());
		}

		// Token: 0x06039830 RID: 235568 RVA: 0x007C3538 File Offset: 0x007C1738
		public ITurntableConnectorUiGameplayT UnPack()
		{
			ITurntableConnectorUiGameplayT turntableConnectorUiGameplayT = new ITurntableConnectorUiGameplayT();
			this.UnPackTo(turntableConnectorUiGameplayT);
			return turntableConnectorUiGameplayT;
		}

		// Token: 0x06039831 RID: 235569 RVA: 0x007C3553 File Offset: 0x007C1753
		public void UnPackTo(ITurntableConnectorUiGameplayT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06039832 RID: 235570 RVA: 0x007C3570 File Offset: 0x007C1770
		public static Offset<ITurntableConnectorUiGameplay> Pack(FlatBufferBuilder builder, ITurntableConnectorUiGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorUiGameplay>);
			}
			return ITurntableConnectorUiGameplay.CreateITurntableConnectorUiGameplay(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04013362 RID: 78690
		private Table __p;
	}
}
