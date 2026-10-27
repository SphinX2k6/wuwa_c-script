using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006101 RID: 24833
	public struct IActorTurnToEmptyData : IFlatbufferObject
	{
		// Token: 0x1700B708 RID: 46856
		// (get) Token: 0x0602A6DD RID: 173789 RVA: 0x005D879E File Offset: 0x005D699E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6DE RID: 173790 RVA: 0x005D87AB File Offset: 0x005D69AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6DF RID: 173791 RVA: 0x005D87B4 File Offset: 0x005D69B4
		public static IActorTurnToEmptyData GetRootAsIActorTurnToEmptyData(ByteBuffer _bb)
		{
			return IActorTurnToEmptyData.GetRootAsIActorTurnToEmptyData(_bb, default(IActorTurnToEmptyData));
		}

		// Token: 0x0602A6E0 RID: 173792 RVA: 0x005D87D0 File Offset: 0x005D69D0
		public static IActorTurnToEmptyData GetRootAsIActorTurnToEmptyData(ByteBuffer _bb, IActorTurnToEmptyData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6E1 RID: 173793 RVA: 0x005D87ED File Offset: 0x005D69ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6E2 RID: 173794 RVA: 0x005D87FC File Offset: 0x005D69FC
		public IActorTurnToEmptyData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B709 RID: 46857
		// (get) Token: 0x0602A6E3 RID: 173795 RVA: 0x005D880C File Offset: 0x005D6A0C
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

		// Token: 0x0602A6E4 RID: 173796 RVA: 0x005D8848 File Offset: 0x005D6A48
		public static Offset<IActorTurnToEmptyData> CreateIActorTurnToEmptyData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToEmptyData.AddType(builder, Type);
			return IActorTurnToEmptyData.EndIActorTurnToEmptyData(builder);
		}

		// Token: 0x0602A6E5 RID: 173797 RVA: 0x005D885E File Offset: 0x005D6A5E
		public static void StartIActorTurnToEmptyData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A6E6 RID: 173798 RVA: 0x005D8867 File Offset: 0x005D6A67
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A6E7 RID: 173799 RVA: 0x005D8872 File Offset: 0x005D6A72
		public static Offset<IActorTurnToEmptyData> EndIActorTurnToEmptyData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToEmptyData>(builder.EndTable());
		}

		// Token: 0x0602A6E8 RID: 173800 RVA: 0x005D8880 File Offset: 0x005D6A80
		public IActorTurnToEmptyDataT UnPack()
		{
			IActorTurnToEmptyDataT actorTurnToEmptyDataT = new IActorTurnToEmptyDataT();
			this.UnPackTo(actorTurnToEmptyDataT);
			return actorTurnToEmptyDataT;
		}

		// Token: 0x0602A6E9 RID: 173801 RVA: 0x005D889B File Offset: 0x005D6A9B
		public void UnPackTo(IActorTurnToEmptyDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A6EA RID: 173802 RVA: 0x005D88AC File Offset: 0x005D6AAC
		public static Offset<IActorTurnToEmptyData> Pack(FlatBufferBuilder builder, IActorTurnToEmptyDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToEmptyData>);
			}
			return IActorTurnToEmptyData.CreateIActorTurnToEmptyData(builder, _o.Type);
		}

		// Token: 0x040104CD RID: 66765
		private Table __p;
	}
}
