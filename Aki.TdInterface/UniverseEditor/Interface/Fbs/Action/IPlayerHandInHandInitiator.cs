using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746E RID: 29806
	public struct IPlayerHandInHandInitiator : IFlatbufferObject
	{
		// Token: 0x1700DAFF RID: 56063
		// (get) Token: 0x060342DB RID: 213723 RVA: 0x00707824 File Offset: 0x00705A24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060342DC RID: 213724 RVA: 0x00707831 File Offset: 0x00705A31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060342DD RID: 213725 RVA: 0x00707838 File Offset: 0x00705A38
		public static IPlayerHandInHandInitiator GetRootAsIPlayerHandInHandInitiator(ByteBuffer _bb)
		{
			return IPlayerHandInHandInitiator.GetRootAsIPlayerHandInHandInitiator(_bb, default(IPlayerHandInHandInitiator));
		}

		// Token: 0x060342DE RID: 213726 RVA: 0x00707854 File Offset: 0x00705A54
		public static IPlayerHandInHandInitiator GetRootAsIPlayerHandInHandInitiator(ByteBuffer _bb, IPlayerHandInHandInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060342DF RID: 213727 RVA: 0x00707871 File Offset: 0x00705A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060342E0 RID: 213728 RVA: 0x00707880 File Offset: 0x00705A80
		public IPlayerHandInHandInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB00 RID: 56064
		// (get) Token: 0x060342E1 RID: 213729 RVA: 0x00707890 File Offset: 0x00705A90
		public EHandInHandInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInHandInitiatorType.Player;
				}
				return (EHandInHandInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060342E2 RID: 213730 RVA: 0x007078CC File Offset: 0x00705ACC
		public static Offset<IPlayerHandInHandInitiator> CreateIPlayerHandInHandInitiator(FlatBufferBuilder builder, EHandInHandInitiatorType Type = EHandInHandInitiatorType.Player)
		{
			builder.StartTable(1);
			IPlayerHandInHandInitiator.AddType(builder, Type);
			return IPlayerHandInHandInitiator.EndIPlayerHandInHandInitiator(builder);
		}

		// Token: 0x060342E3 RID: 213731 RVA: 0x007078E2 File Offset: 0x00705AE2
		public static void StartIPlayerHandInHandInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060342E4 RID: 213732 RVA: 0x007078EB File Offset: 0x00705AEB
		public static void AddType(FlatBufferBuilder builder, EHandInHandInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060342E5 RID: 213733 RVA: 0x007078F6 File Offset: 0x00705AF6
		public static Offset<IPlayerHandInHandInitiator> EndIPlayerHandInHandInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerHandInHandInitiator>(builder.EndTable());
		}

		// Token: 0x060342E6 RID: 213734 RVA: 0x00707904 File Offset: 0x00705B04
		public IPlayerHandInHandInitiatorT UnPack()
		{
			IPlayerHandInHandInitiatorT playerHandInHandInitiatorT = new IPlayerHandInHandInitiatorT();
			this.UnPackTo(playerHandInHandInitiatorT);
			return playerHandInHandInitiatorT;
		}

		// Token: 0x060342E7 RID: 213735 RVA: 0x0070791F File Offset: 0x00705B1F
		public void UnPackTo(IPlayerHandInHandInitiatorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060342E8 RID: 213736 RVA: 0x00707930 File Offset: 0x00705B30
		public static Offset<IPlayerHandInHandInitiator> Pack(FlatBufferBuilder builder, IPlayerHandInHandInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerHandInHandInitiator>);
			}
			return IPlayerHandInHandInitiator.CreateIPlayerHandInHandInitiator(builder, _o.Type);
		}

		// Token: 0x040125EB RID: 75243
		private Table __p;
	}
}
