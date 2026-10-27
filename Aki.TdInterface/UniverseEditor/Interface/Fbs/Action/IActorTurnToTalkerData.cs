using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610D RID: 24845
	public struct IActorTurnToTalkerData : IFlatbufferObject
	{
		// Token: 0x1700B718 RID: 46872
		// (get) Token: 0x0602A72D RID: 173869 RVA: 0x005D8F1C File Offset: 0x005D711C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A72E RID: 173870 RVA: 0x005D8F29 File Offset: 0x005D7129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A72F RID: 173871 RVA: 0x005D8F30 File Offset: 0x005D7130
		public static IActorTurnToTalkerData GetRootAsIActorTurnToTalkerData(ByteBuffer _bb)
		{
			return IActorTurnToTalkerData.GetRootAsIActorTurnToTalkerData(_bb, default(IActorTurnToTalkerData));
		}

		// Token: 0x0602A730 RID: 173872 RVA: 0x005D8F4C File Offset: 0x005D714C
		public static IActorTurnToTalkerData GetRootAsIActorTurnToTalkerData(ByteBuffer _bb, IActorTurnToTalkerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A731 RID: 173873 RVA: 0x005D8F69 File Offset: 0x005D7169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A732 RID: 173874 RVA: 0x005D8F78 File Offset: 0x005D7178
		public IActorTurnToTalkerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B719 RID: 46873
		// (get) Token: 0x0602A733 RID: 173875 RVA: 0x005D8F88 File Offset: 0x005D7188
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

		// Token: 0x0602A734 RID: 173876 RVA: 0x005D8FC4 File Offset: 0x005D71C4
		public static Offset<IActorTurnToTalkerData> CreateIActorTurnToTalkerData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker)
		{
			builder.StartTable(1);
			IActorTurnToTalkerData.AddType(builder, Type);
			return IActorTurnToTalkerData.EndIActorTurnToTalkerData(builder);
		}

		// Token: 0x0602A735 RID: 173877 RVA: 0x005D8FDA File Offset: 0x005D71DA
		public static void StartIActorTurnToTalkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A736 RID: 173878 RVA: 0x005D8FE3 File Offset: 0x005D71E3
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A737 RID: 173879 RVA: 0x005D8FEE File Offset: 0x005D71EE
		public static Offset<IActorTurnToTalkerData> EndIActorTurnToTalkerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToTalkerData>(builder.EndTable());
		}

		// Token: 0x0602A738 RID: 173880 RVA: 0x005D8FFC File Offset: 0x005D71FC
		public IActorTurnToTalkerDataT UnPack()
		{
			IActorTurnToTalkerDataT actorTurnToTalkerDataT = new IActorTurnToTalkerDataT();
			this.UnPackTo(actorTurnToTalkerDataT);
			return actorTurnToTalkerDataT;
		}

		// Token: 0x0602A739 RID: 173881 RVA: 0x005D9017 File Offset: 0x005D7217
		public void UnPackTo(IActorTurnToTalkerDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A73A RID: 173882 RVA: 0x005D9028 File Offset: 0x005D7228
		public static Offset<IActorTurnToTalkerData> Pack(FlatBufferBuilder builder, IActorTurnToTalkerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToTalkerData>);
			}
			return IActorTurnToTalkerData.CreateIActorTurnToTalkerData(builder, _o.Type);
		}

		// Token: 0x040104D7 RID: 66775
		private Table __p;
	}
}
