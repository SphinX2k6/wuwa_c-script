using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFF RID: 23807
	public struct IPatrolPositionRefreshAtNearestSplinePointToPlayer : IFlatbufferObject
	{
		// Token: 0x1700AEEF RID: 44783
		// (get) Token: 0x0602789C RID: 161948 RVA: 0x00568D2D File Offset: 0x00566F2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602789D RID: 161949 RVA: 0x00568D3A File Offset: 0x00566F3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602789E RID: 161950 RVA: 0x00568D44 File Offset: 0x00566F44
		public static IPatrolPositionRefreshAtNearestSplinePointToPlayer GetRootAsIPatrolPositionRefreshAtNearestSplinePointToPlayer(ByteBuffer _bb)
		{
			return IPatrolPositionRefreshAtNearestSplinePointToPlayer.GetRootAsIPatrolPositionRefreshAtNearestSplinePointToPlayer(_bb, default(IPatrolPositionRefreshAtNearestSplinePointToPlayer));
		}

		// Token: 0x0602789F RID: 161951 RVA: 0x00568D60 File Offset: 0x00566F60
		public static IPatrolPositionRefreshAtNearestSplinePointToPlayer GetRootAsIPatrolPositionRefreshAtNearestSplinePointToPlayer(ByteBuffer _bb, IPatrolPositionRefreshAtNearestSplinePointToPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278A0 RID: 161952 RVA: 0x00568D7D File Offset: 0x00566F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278A1 RID: 161953 RVA: 0x00568D8C File Offset: 0x00566F8C
		public IPatrolPositionRefreshAtNearestSplinePointToPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEF0 RID: 44784
		// (get) Token: 0x060278A2 RID: 161954 RVA: 0x00568D9C File Offset: 0x00566F9C
		public EPatrolPositionRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolPositionRefreshType.NearestSplinePointToPlayer;
				}
				return (EPatrolPositionRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060278A3 RID: 161955 RVA: 0x00568DD8 File Offset: 0x00566FD8
		public static Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> CreateIPatrolPositionRefreshAtNearestSplinePointToPlayer(FlatBufferBuilder builder, EPatrolPositionRefreshType Type = EPatrolPositionRefreshType.NearestSplinePointToPlayer)
		{
			builder.StartTable(1);
			IPatrolPositionRefreshAtNearestSplinePointToPlayer.AddType(builder, Type);
			return IPatrolPositionRefreshAtNearestSplinePointToPlayer.EndIPatrolPositionRefreshAtNearestSplinePointToPlayer(builder);
		}

		// Token: 0x060278A4 RID: 161956 RVA: 0x00568DEE File Offset: 0x00566FEE
		public static void StartIPatrolPositionRefreshAtNearestSplinePointToPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278A5 RID: 161957 RVA: 0x00568DF7 File Offset: 0x00566FF7
		public static void AddType(FlatBufferBuilder builder, EPatrolPositionRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278A6 RID: 161958 RVA: 0x00568E02 File Offset: 0x00567002
		public static Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> EndIPatrolPositionRefreshAtNearestSplinePointToPlayer(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer>(builder.EndTable());
		}

		// Token: 0x060278A7 RID: 161959 RVA: 0x00568E10 File Offset: 0x00567010
		public IPatrolPositionRefreshAtNearestSplinePointToPlayerT UnPack()
		{
			IPatrolPositionRefreshAtNearestSplinePointToPlayerT patrolPositionRefreshAtNearestSplinePointToPlayerT = new IPatrolPositionRefreshAtNearestSplinePointToPlayerT();
			this.UnPackTo(patrolPositionRefreshAtNearestSplinePointToPlayerT);
			return patrolPositionRefreshAtNearestSplinePointToPlayerT;
		}

		// Token: 0x060278A8 RID: 161960 RVA: 0x00568E2B File Offset: 0x0056702B
		public void UnPackTo(IPatrolPositionRefreshAtNearestSplinePointToPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278A9 RID: 161961 RVA: 0x00568E3C File Offset: 0x0056703C
		public static Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshAtNearestSplinePointToPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefreshAtNearestSplinePointToPlayer>);
			}
			return IPatrolPositionRefreshAtNearestSplinePointToPlayer.CreateIPatrolPositionRefreshAtNearestSplinePointToPlayer(builder, _o.Type);
		}

		// Token: 0x0400F83B RID: 63547
		private Table __p;
	}
}
