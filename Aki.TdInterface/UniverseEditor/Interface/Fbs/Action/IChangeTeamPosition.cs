using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699A RID: 27034
	public struct IChangeTeamPosition : IFlatbufferObject
	{
		// Token: 0x1700C704 RID: 50948
		// (get) Token: 0x0602E5F4 RID: 189940 RVA: 0x00654496 File Offset: 0x00652696
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E5F5 RID: 189941 RVA: 0x006544A3 File Offset: 0x006526A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E5F6 RID: 189942 RVA: 0x006544AC File Offset: 0x006526AC
		public static IChangeTeamPosition GetRootAsIChangeTeamPosition(ByteBuffer _bb)
		{
			return IChangeTeamPosition.GetRootAsIChangeTeamPosition(_bb, default(IChangeTeamPosition));
		}

		// Token: 0x0602E5F7 RID: 189943 RVA: 0x006544C8 File Offset: 0x006526C8
		public static IChangeTeamPosition GetRootAsIChangeTeamPosition(ByteBuffer _bb, IChangeTeamPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E5F8 RID: 189944 RVA: 0x006544E5 File Offset: 0x006526E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E5F9 RID: 189945 RVA: 0x006544F4 File Offset: 0x006526F4
		public IChangeTeamPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C705 RID: 50949
		// (get) Token: 0x0602E5FA RID: 189946 RVA: 0x00654504 File Offset: 0x00652704
		public int PositionId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C706 RID: 50950
		// (get) Token: 0x0602E5FB RID: 189947 RVA: 0x00654540 File Offset: 0x00652740
		public TTeamType TeamTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTeamType.NONE;
				}
				return (TTeamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E5FC RID: 189948 RVA: 0x0065457C File Offset: 0x0065277C
		public TTable? TeamType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E5FD RID: 189949 RVA: 0x006545C0 File Offset: 0x006527C0
		public IBattleTeam TeamTypeAsIBattleTeam()
		{
			return this.TeamType<IBattleTeam>().Value;
		}

		// Token: 0x0602E5FE RID: 189950 RVA: 0x006545DC File Offset: 0x006527DC
		public ICurrentTeam TeamTypeAsICurrentTeam()
		{
			return this.TeamType<ICurrentTeam>().Value;
		}

		// Token: 0x0602E5FF RID: 189951 RVA: 0x006545F8 File Offset: 0x006527F8
		public IFlowTeam TeamTypeAsIFlowTeam()
		{
			return this.TeamType<IFlowTeam>().Value;
		}

		// Token: 0x0602E600 RID: 189952 RVA: 0x00654613 File Offset: 0x00652813
		public static Offset<IChangeTeamPosition> CreateIChangeTeamPosition(FlatBufferBuilder builder, int PositionId = 0, TTeamType TeamType_type = TTeamType.NONE, int TeamTypeOffset = 0)
		{
			builder.StartTable(3);
			IChangeTeamPosition.AddTeamType(builder, TeamTypeOffset);
			IChangeTeamPosition.AddPositionId(builder, PositionId);
			IChangeTeamPosition.AddTeamTypeType(builder, TeamType_type);
			return IChangeTeamPosition.EndIChangeTeamPosition(builder);
		}

		// Token: 0x0602E601 RID: 189953 RVA: 0x00654637 File Offset: 0x00652837
		public static void StartIChangeTeamPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E602 RID: 189954 RVA: 0x00654640 File Offset: 0x00652840
		public static void AddPositionId(FlatBufferBuilder builder, int positionId)
		{
			builder.AddInt(0, positionId, 0);
		}

		// Token: 0x0602E603 RID: 189955 RVA: 0x0065464B File Offset: 0x0065284B
		public static void AddTeamTypeType(FlatBufferBuilder builder, TTeamType teamTypeType)
		{
			builder.AddByte(1, (byte)teamTypeType, 0);
		}

		// Token: 0x0602E604 RID: 189956 RVA: 0x00654656 File Offset: 0x00652856
		public static void AddTeamType(FlatBufferBuilder builder, int teamTypeOffset)
		{
			builder.AddOffset(2, teamTypeOffset, 0);
		}

		// Token: 0x0602E605 RID: 189957 RVA: 0x00654661 File Offset: 0x00652861
		public static Offset<IChangeTeamPosition> EndIChangeTeamPosition(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTeamPosition>(builder.EndTable());
		}

		// Token: 0x0602E606 RID: 189958 RVA: 0x00654670 File Offset: 0x00652870
		public IChangeTeamPositionT UnPack()
		{
			IChangeTeamPositionT changeTeamPositionT = new IChangeTeamPositionT();
			this.UnPackTo(changeTeamPositionT);
			return changeTeamPositionT;
		}

		// Token: 0x0602E607 RID: 189959 RVA: 0x0065468C File Offset: 0x0065288C
		public void UnPackTo(IChangeTeamPositionT _o)
		{
			_o.PositionId = this.PositionId;
			_o.TeamType = new TTeamTypeUnion();
			_o.TeamType.Type = this.TeamTypeType;
			switch (this.TeamTypeType)
			{
			case TTeamType.IBattleTeam:
				_o.TeamType.Value = ((this.TeamType<IBattleTeam>() != null) ? this.TeamType<IBattleTeam>().Value.UnPack() : null);
				return;
			case TTeamType.ICurrentTeam:
				_o.TeamType.Value = ((this.TeamType<ICurrentTeam>() != null) ? this.TeamType<ICurrentTeam>().Value.UnPack() : null);
				return;
			case TTeamType.IFlowTeam:
				_o.TeamType.Value = ((this.TeamType<IFlowTeam>() != null) ? this.TeamType<IFlowTeam>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602E608 RID: 189960 RVA: 0x00654780 File Offset: 0x00652980
		public static Offset<IChangeTeamPosition> Pack(FlatBufferBuilder builder, IChangeTeamPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTeamPosition>);
			}
			TTeamType teamType_type = (_o.TeamType == null) ? TTeamType.NONE : _o.TeamType.Type;
			int teamTypeOffset = (_o.TeamType == null) ? 0 : TTeamTypeUnion.Pack(builder, _o.TeamType);
			return IChangeTeamPosition.CreateIChangeTeamPosition(builder, _o.PositionId, teamType_type, teamTypeOffset);
		}

		// Token: 0x04011701 RID: 71425
		private Table __p;
	}
}
