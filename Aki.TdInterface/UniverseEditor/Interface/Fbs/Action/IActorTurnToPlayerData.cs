using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006769 RID: 26473
	public struct IActorTurnToPlayerData : IFlatbufferObject
	{
		// Token: 0x1700C07B RID: 49275
		// (get) Token: 0x0602CDE6 RID: 183782 RVA: 0x00622ABE File Offset: 0x00620CBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDE7 RID: 183783 RVA: 0x00622ACB File Offset: 0x00620CCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDE8 RID: 183784 RVA: 0x00622AD4 File Offset: 0x00620CD4
		public static IActorTurnToPlayerData GetRootAsIActorTurnToPlayerData(ByteBuffer _bb)
		{
			return IActorTurnToPlayerData.GetRootAsIActorTurnToPlayerData(_bb, default(IActorTurnToPlayerData));
		}

		// Token: 0x0602CDE9 RID: 183785 RVA: 0x00622AF0 File Offset: 0x00620CF0
		public static IActorTurnToPlayerData GetRootAsIActorTurnToPlayerData(ByteBuffer _bb, IActorTurnToPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDEA RID: 183786 RVA: 0x00622B0D File Offset: 0x00620D0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDEB RID: 183787 RVA: 0x00622B1C File Offset: 0x00620D1C
		public IActorTurnToPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C07C RID: 49276
		// (get) Token: 0x0602CDEC RID: 183788 RVA: 0x00622B2C File Offset: 0x00620D2C
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

		// Token: 0x0602CDED RID: 183789 RVA: 0x00622B68 File Offset: 0x00620D68
		public static Offset<IActorTurnToPlayerData> CreateIActorTurnToPlayerData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToPlayerData.AddType(builder, Type);
			return IActorTurnToPlayerData.EndIActorTurnToPlayerData(builder);
		}

		// Token: 0x0602CDEE RID: 183790 RVA: 0x00622B7E File Offset: 0x00620D7E
		public static void StartIActorTurnToPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CDEF RID: 183791 RVA: 0x00622B87 File Offset: 0x00620D87
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDF0 RID: 183792 RVA: 0x00622B92 File Offset: 0x00620D92
		public static Offset<IActorTurnToPlayerData> EndIActorTurnToPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToPlayerData>(builder.EndTable());
		}

		// Token: 0x0602CDF1 RID: 183793 RVA: 0x00622BA0 File Offset: 0x00620DA0
		public IActorTurnToPlayerDataT UnPack()
		{
			IActorTurnToPlayerDataT actorTurnToPlayerDataT = new IActorTurnToPlayerDataT();
			this.UnPackTo(actorTurnToPlayerDataT);
			return actorTurnToPlayerDataT;
		}

		// Token: 0x0602CDF2 RID: 183794 RVA: 0x00622BBB File Offset: 0x00620DBB
		public void UnPackTo(IActorTurnToPlayerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CDF3 RID: 183795 RVA: 0x00622BCC File Offset: 0x00620DCC
		public static Offset<IActorTurnToPlayerData> Pack(FlatBufferBuilder builder, IActorTurnToPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToPlayerData>);
			}
			return IActorTurnToPlayerData.CreateIActorTurnToPlayerData(builder, _o.Type);
		}

		// Token: 0x040112D6 RID: 70358
		private Table __p;
	}
}
