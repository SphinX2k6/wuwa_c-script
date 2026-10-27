using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007535 RID: 30005
	public struct IVehicleTeam : IFlatbufferObject
	{
		// Token: 0x1700E3B0 RID: 58288
		// (get) Token: 0x0603697C RID: 223612 RVA: 0x0076AE71 File Offset: 0x00769071
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603697D RID: 223613 RVA: 0x0076AE7E File Offset: 0x0076907E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603697E RID: 223614 RVA: 0x0076AE88 File Offset: 0x00769088
		public static IVehicleTeam GetRootAsIVehicleTeam(ByteBuffer _bb)
		{
			return IVehicleTeam.GetRootAsIVehicleTeam(_bb, default(IVehicleTeam));
		}

		// Token: 0x0603697F RID: 223615 RVA: 0x0076AEA4 File Offset: 0x007690A4
		public static IVehicleTeam GetRootAsIVehicleTeam(ByteBuffer _bb, IVehicleTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036980 RID: 223616 RVA: 0x0076AEC1 File Offset: 0x007690C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036981 RID: 223617 RVA: 0x0076AED0 File Offset: 0x007690D0
		public IVehicleTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3B1 RID: 58289
		// (get) Token: 0x06036982 RID: 223618 RVA: 0x0076AEE0 File Offset: 0x007690E0
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3B2 RID: 58290
		// (get) Token: 0x06036983 RID: 223619 RVA: 0x0076AF1C File Offset: 0x0076911C
		public int TeamId
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

		// Token: 0x06036984 RID: 223620 RVA: 0x0076AF58 File Offset: 0x00769158
		public static Offset<IVehicleTeam> CreateIVehicleTeam(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int TeamId = 0)
		{
			builder.StartTable(2);
			IVehicleTeam.AddTeamId(builder, TeamId);
			IVehicleTeam.AddType(builder, Type);
			return IVehicleTeam.EndIVehicleTeam(builder);
		}

		// Token: 0x06036985 RID: 223621 RVA: 0x0076AF75 File Offset: 0x00769175
		public static void StartIVehicleTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036986 RID: 223622 RVA: 0x0076AF7E File Offset: 0x0076917E
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036987 RID: 223623 RVA: 0x0076AF89 File Offset: 0x00769189
		public static void AddTeamId(FlatBufferBuilder builder, int teamId)
		{
			builder.AddInt(1, teamId, 0);
		}

		// Token: 0x06036988 RID: 223624 RVA: 0x0076AF94 File Offset: 0x00769194
		public static Offset<IVehicleTeam> EndIVehicleTeam(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTeam>(builder.EndTable());
		}

		// Token: 0x06036989 RID: 223625 RVA: 0x0076AFA4 File Offset: 0x007691A4
		public IVehicleTeamT UnPack()
		{
			IVehicleTeamT vehicleTeamT = new IVehicleTeamT();
			this.UnPackTo(vehicleTeamT);
			return vehicleTeamT;
		}

		// Token: 0x0603698A RID: 223626 RVA: 0x0076AFBF File Offset: 0x007691BF
		public void UnPackTo(IVehicleTeamT _o)
		{
			_o.Type = this.Type;
			_o.TeamId = this.TeamId;
		}

		// Token: 0x0603698B RID: 223627 RVA: 0x0076AFDC File Offset: 0x007691DC
		public static Offset<IVehicleTeam> Pack(FlatBufferBuilder builder, IVehicleTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTeam>);
			}
			return IVehicleTeam.CreateIVehicleTeam(builder, _o.Type, _o.TeamId);
		}

		// Token: 0x04012428 RID: 74792
		private Table __p;
	}
}
