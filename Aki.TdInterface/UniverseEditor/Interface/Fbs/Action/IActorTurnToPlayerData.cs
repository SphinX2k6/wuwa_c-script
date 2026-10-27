using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006107 RID: 24839
	public struct IActorTurnToPlayerData : IFlatbufferObject
	{
		// Token: 0x1700B710 RID: 46864
		// (get) Token: 0x0602A705 RID: 173829 RVA: 0x005D8B16 File Offset: 0x005D6D16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A706 RID: 173830 RVA: 0x005D8B23 File Offset: 0x005D6D23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A707 RID: 173831 RVA: 0x005D8B2C File Offset: 0x005D6D2C
		public static IActorTurnToPlayerData GetRootAsIActorTurnToPlayerData(ByteBuffer _bb)
		{
			return IActorTurnToPlayerData.GetRootAsIActorTurnToPlayerData(_bb, default(IActorTurnToPlayerData));
		}

		// Token: 0x0602A708 RID: 173832 RVA: 0x005D8B48 File Offset: 0x005D6D48
		public static IActorTurnToPlayerData GetRootAsIActorTurnToPlayerData(ByteBuffer _bb, IActorTurnToPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A709 RID: 173833 RVA: 0x005D8B65 File Offset: 0x005D6D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A70A RID: 173834 RVA: 0x005D8B74 File Offset: 0x005D6D74
		public IActorTurnToPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B711 RID: 46865
		// (get) Token: 0x0602A70B RID: 173835 RVA: 0x005D8B84 File Offset: 0x005D6D84
		public EActorTurnToMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorTurnToMode.Talker;
				}
				return (EActorTurnToMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A70C RID: 173836 RVA: 0x005D8BC0 File Offset: 0x005D6DC0
		public static Offset<IActorTurnToPlayerData> CreateIActorTurnToPlayerData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToPlayerData.AddType(builder, Type);
			return IActorTurnToPlayerData.EndIActorTurnToPlayerData(builder);
		}

		// Token: 0x0602A70D RID: 173837 RVA: 0x005D8BD6 File Offset: 0x005D6DD6
		public static void StartIActorTurnToPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A70E RID: 173838 RVA: 0x005D8BDF File Offset: 0x005D6DDF
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A70F RID: 173839 RVA: 0x005D8BEA File Offset: 0x005D6DEA
		public static Offset<IActorTurnToPlayerData> EndIActorTurnToPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToPlayerData>(builder.EndTable());
		}

		// Token: 0x0602A710 RID: 173840 RVA: 0x005D8BF8 File Offset: 0x005D6DF8
		public IActorTurnToPlayerDataT UnPack()
		{
			IActorTurnToPlayerDataT actorTurnToPlayerDataT = new IActorTurnToPlayerDataT();
			this.UnPackTo(actorTurnToPlayerDataT);
			return actorTurnToPlayerDataT;
		}

		// Token: 0x0602A711 RID: 173841 RVA: 0x005D8C13 File Offset: 0x005D6E13
		public void UnPackTo(IActorTurnToPlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A712 RID: 173842 RVA: 0x005D8C24 File Offset: 0x005D6E24
		public static Offset<IActorTurnToPlayerData> Pack(FlatBufferBuilder builder, IActorTurnToPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToPlayerData>);
			}
			return IActorTurnToPlayerData.CreateIActorTurnToPlayerData(builder, _o.Type);
		}

		// Token: 0x040104D2 RID: 66770
		private Table __p;
	}
}
