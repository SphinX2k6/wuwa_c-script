using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D2B RID: 32043
	public struct IVehicleTeam : IFlatbufferObject
	{
		// Token: 0x1700EFDA RID: 61402
		// (get) Token: 0x06039D92 RID: 236946 RVA: 0x007CE119 File Offset: 0x007CC319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D93 RID: 236947 RVA: 0x007CE126 File Offset: 0x007CC326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D94 RID: 236948 RVA: 0x007CE130 File Offset: 0x007CC330
		public static IVehicleTeam GetRootAsIVehicleTeam(ByteBuffer _bb)
		{
			return IVehicleTeam.GetRootAsIVehicleTeam(_bb, default(IVehicleTeam));
		}

		// Token: 0x06039D95 RID: 236949 RVA: 0x007CE14C File Offset: 0x007CC34C
		public static IVehicleTeam GetRootAsIVehicleTeam(ByteBuffer _bb, IVehicleTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D96 RID: 236950 RVA: 0x007CE169 File Offset: 0x007CC369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D97 RID: 236951 RVA: 0x007CE178 File Offset: 0x007CC378
		public IVehicleTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFDB RID: 61403
		// (get) Token: 0x06039D98 RID: 236952 RVA: 0x007CE188 File Offset: 0x007CC388
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

		// Token: 0x1700EFDC RID: 61404
		// (get) Token: 0x06039D99 RID: 236953 RVA: 0x007CE1C4 File Offset: 0x007CC3C4
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

		// Token: 0x06039D9A RID: 236954 RVA: 0x007CE200 File Offset: 0x007CC400
		public static Offset<IVehicleTeam> CreateIVehicleTeam(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int TeamId = 0)
		{
			builder.StartTable(2);
			IVehicleTeam.AddTeamId(builder, TeamId);
			IVehicleTeam.AddType(builder, Type);
			return IVehicleTeam.EndIVehicleTeam(builder);
		}

		// Token: 0x06039D9B RID: 236955 RVA: 0x007CE21D File Offset: 0x007CC41D
		public static void StartIVehicleTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039D9C RID: 236956 RVA: 0x007CE226 File Offset: 0x007CC426
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039D9D RID: 236957 RVA: 0x007CE231 File Offset: 0x007CC431
		public static void AddTeamId(FlatBufferBuilder builder, int teamId)
		{
			builder.AddInt(1, teamId, 0);
		}

		// Token: 0x06039D9E RID: 236958 RVA: 0x007CE23C File Offset: 0x007CC43C
		public static Offset<IVehicleTeam> EndIVehicleTeam(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleTeam>(builder.EndTable());
		}

		// Token: 0x06039D9F RID: 236959 RVA: 0x007CE24C File Offset: 0x007CC44C
		public IVehicleTeamT UnPack()
		{
			IVehicleTeamT vehicleTeamT = new IVehicleTeamT();
			this.UnPackTo(vehicleTeamT);
			return vehicleTeamT;
		}

		// Token: 0x06039DA0 RID: 236960 RVA: 0x007CE267 File Offset: 0x007CC467
		public void UnPackTo(IVehicleTeamT _o)
		{
			_o.Type = this.Type;
			_o.TeamId = this.TeamId;
		}

		// Token: 0x06039DA1 RID: 236961 RVA: 0x007CE284 File Offset: 0x007CC484
		public static Offset<IVehicleTeam> Pack(FlatBufferBuilder builder, IVehicleTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleTeam>);
			}
			return IVehicleTeam.CreateIVehicleTeam(builder, _o.Type, _o.TeamId);
		}

		// Token: 0x04013459 RID: 78937
		private Table __p;
	}
}
