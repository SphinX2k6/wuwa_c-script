using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610A RID: 24842
	public struct IActorTurnToPositionData : IFlatbufferObject
	{
		// Token: 0x1700B713 RID: 46867
		// (get) Token: 0x0602A717 RID: 173847 RVA: 0x005D8C8D File Offset: 0x005D6E8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A718 RID: 173848 RVA: 0x005D8C9A File Offset: 0x005D6E9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A719 RID: 173849 RVA: 0x005D8CA4 File Offset: 0x005D6EA4
		public static IActorTurnToPositionData GetRootAsIActorTurnToPositionData(ByteBuffer _bb)
		{
			return IActorTurnToPositionData.GetRootAsIActorTurnToPositionData(_bb, default(IActorTurnToPositionData));
		}

		// Token: 0x0602A71A RID: 173850 RVA: 0x005D8CC0 File Offset: 0x005D6EC0
		public static IActorTurnToPositionData GetRootAsIActorTurnToPositionData(ByteBuffer _bb, IActorTurnToPositionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A71B RID: 173851 RVA: 0x005D8CDD File Offset: 0x005D6EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A71C RID: 173852 RVA: 0x005D8CEC File Offset: 0x005D6EEC
		public IActorTurnToPositionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B714 RID: 46868
		// (get) Token: 0x0602A71D RID: 173853 RVA: 0x005D8CFC File Offset: 0x005D6EFC
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

		// Token: 0x1700B715 RID: 46869
		// (get) Token: 0x0602A71E RID: 173854 RVA: 0x005D8D38 File Offset: 0x005D6F38
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A71F RID: 173855 RVA: 0x005D8D95 File Offset: 0x005D6F95
		public static Offset<IActorTurnToPositionData> CreateIActorTurnToPositionData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IActorTurnToPositionData.AddPos(builder, PosOffset);
			IActorTurnToPositionData.AddType(builder, Type);
			return IActorTurnToPositionData.EndIActorTurnToPositionData(builder);
		}

		// Token: 0x0602A720 RID: 173856 RVA: 0x005D8DB2 File Offset: 0x005D6FB2
		public static void StartIActorTurnToPositionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A721 RID: 173857 RVA: 0x005D8DBB File Offset: 0x005D6FBB
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A722 RID: 173858 RVA: 0x005D8DC6 File Offset: 0x005D6FC6
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602A723 RID: 173859 RVA: 0x005D8DD6 File Offset: 0x005D6FD6
		public static Offset<IActorTurnToPositionData> EndIActorTurnToPositionData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToPositionData>(builder.EndTable());
		}

		// Token: 0x0602A724 RID: 173860 RVA: 0x005D8DE4 File Offset: 0x005D6FE4
		public IActorTurnToPositionDataT UnPack()
		{
			IActorTurnToPositionDataT actorTurnToPositionDataT = new IActorTurnToPositionDataT();
			this.UnPackTo(actorTurnToPositionDataT);
			return actorTurnToPositionDataT;
		}

		// Token: 0x0602A725 RID: 173861 RVA: 0x005D8E00 File Offset: 0x005D7000
		public void UnPackTo(IActorTurnToPositionDataT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602A726 RID: 173862 RVA: 0x005D8E48 File Offset: 0x005D7048
		public static Offset<IActorTurnToPositionData> Pack(FlatBufferBuilder builder, IActorTurnToPositionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToPositionData>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IActorTurnToPositionData.CreateIActorTurnToPositionData(builder, _o.Type, posOffset);
		}

		// Token: 0x040104D4 RID: 66772
		private Table __p;
	}
}
