using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EE RID: 29678
	public struct IPerformerAiMoveToPlayer : IFlatbufferObject
	{
		// Token: 0x1700DA02 RID: 55810
		// (get) Token: 0x06033EAC RID: 212652 RVA: 0x006FFFFA File Offset: 0x006FE1FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033EAD RID: 212653 RVA: 0x00700007 File Offset: 0x006FE207
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033EAE RID: 212654 RVA: 0x00700010 File Offset: 0x006FE210
		public static IPerformerAiMoveToPlayer GetRootAsIPerformerAiMoveToPlayer(ByteBuffer _bb)
		{
			return IPerformerAiMoveToPlayer.GetRootAsIPerformerAiMoveToPlayer(_bb, default(IPerformerAiMoveToPlayer));
		}

		// Token: 0x06033EAF RID: 212655 RVA: 0x0070002C File Offset: 0x006FE22C
		public static IPerformerAiMoveToPlayer GetRootAsIPerformerAiMoveToPlayer(ByteBuffer _bb, IPerformerAiMoveToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033EB0 RID: 212656 RVA: 0x00700049 File Offset: 0x006FE249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033EB1 RID: 212657 RVA: 0x00700058 File Offset: 0x006FE258
		public IPerformerAiMoveToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA03 RID: 55811
		// (get) Token: 0x06033EB2 RID: 212658 RVA: 0x00700068 File Offset: 0x006FE268
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033EB3 RID: 212659 RVA: 0x007000A4 File Offset: 0x006FE2A4
		public static Offset<IPerformerAiMoveToPlayer> CreateIPerformerAiMoveToPlayer(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position)
		{
			builder.StartTable(1);
			IPerformerAiMoveToPlayer.AddType(builder, Type);
			return IPerformerAiMoveToPlayer.EndIPerformerAiMoveToPlayer(builder);
		}

		// Token: 0x06033EB4 RID: 212660 RVA: 0x007000BA File Offset: 0x006FE2BA
		public static void StartIPerformerAiMoveToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033EB5 RID: 212661 RVA: 0x007000C3 File Offset: 0x006FE2C3
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033EB6 RID: 212662 RVA: 0x007000CE File Offset: 0x006FE2CE
		public static Offset<IPerformerAiMoveToPlayer> EndIPerformerAiMoveToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveToPlayer>(builder.EndTable());
		}

		// Token: 0x06033EB7 RID: 212663 RVA: 0x007000DC File Offset: 0x006FE2DC
		public IPerformerAiMoveToPlayerT UnPack()
		{
			IPerformerAiMoveToPlayerT performerAiMoveToPlayerT = new IPerformerAiMoveToPlayerT();
			this.UnPackTo(performerAiMoveToPlayerT);
			return performerAiMoveToPlayerT;
		}

		// Token: 0x06033EB8 RID: 212664 RVA: 0x007000F7 File Offset: 0x006FE2F7
		public void UnPackTo(IPerformerAiMoveToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033EB9 RID: 212665 RVA: 0x00700108 File Offset: 0x006FE308
		public static Offset<IPerformerAiMoveToPlayer> Pack(FlatBufferBuilder builder, IPerformerAiMoveToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveToPlayer>);
			}
			return IPerformerAiMoveToPlayer.CreateIPerformerAiMoveToPlayer(builder, _o.Type);
		}

		// Token: 0x04012534 RID: 75060
		private Table __p;
	}
}
