using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F9 RID: 25337
	public struct IChangeFightTeam : IFlatbufferObject
	{
		// Token: 0x1700BD1A RID: 48410
		// (get) Token: 0x0602BCD1 RID: 179409 RVA: 0x006063D6 File Offset: 0x006045D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCD2 RID: 179410 RVA: 0x006063E3 File Offset: 0x006045E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCD3 RID: 179411 RVA: 0x006063EC File Offset: 0x006045EC
		public static IChangeFightTeam GetRootAsIChangeFightTeam(ByteBuffer _bb)
		{
			return IChangeFightTeam.GetRootAsIChangeFightTeam(_bb, default(IChangeFightTeam));
		}

		// Token: 0x0602BCD4 RID: 179412 RVA: 0x00606408 File Offset: 0x00604608
		public static IChangeFightTeam GetRootAsIChangeFightTeam(ByteBuffer _bb, IChangeFightTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCD5 RID: 179413 RVA: 0x00606425 File Offset: 0x00604625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCD6 RID: 179414 RVA: 0x00606434 File Offset: 0x00604634
		public IChangeFightTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD1B RID: 48411
		// (get) Token: 0x0602BCD7 RID: 179415 RVA: 0x00606444 File Offset: 0x00604644
		public int TeamIndex
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

		// Token: 0x1700BD1C RID: 48412
		// (get) Token: 0x0602BCD8 RID: 179416 RVA: 0x00606480 File Offset: 0x00604680
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BCD9 RID: 179417 RVA: 0x006064BC File Offset: 0x006046BC
		public static Offset<IChangeFightTeam> CreateIChangeFightTeam(FlatBufferBuilder builder, int TeamIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IChangeFightTeam.AddTeamIndex(builder, TeamIndex);
			IChangeFightTeam.AddNullMask(builder, NullMask);
			return IChangeFightTeam.EndIChangeFightTeam(builder);
		}

		// Token: 0x0602BCDA RID: 179418 RVA: 0x006064D9 File Offset: 0x006046D9
		public static void StartIChangeFightTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BCDB RID: 179419 RVA: 0x006064E2 File Offset: 0x006046E2
		public static void AddTeamIndex(FlatBufferBuilder builder, int teamIndex)
		{
			builder.AddInt(0, teamIndex, 0);
		}

		// Token: 0x0602BCDC RID: 179420 RVA: 0x006064ED File Offset: 0x006046ED
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602BCDD RID: 179421 RVA: 0x006064F8 File Offset: 0x006046F8
		public static Offset<IChangeFightTeam> EndIChangeFightTeam(FlatBufferBuilder builder)
		{
			return new Offset<IChangeFightTeam>(builder.EndTable());
		}

		// Token: 0x0602BCDE RID: 179422 RVA: 0x00606508 File Offset: 0x00604708
		public IChangeFightTeamT UnPack()
		{
			IChangeFightTeamT changeFightTeamT = new IChangeFightTeamT();
			this.UnPackTo(changeFightTeamT);
			return changeFightTeamT;
		}

		// Token: 0x0602BCDF RID: 179423 RVA: 0x00606523 File Offset: 0x00604723
		public void UnPackTo(IChangeFightTeamT _o)
		{
			_o.TeamIndex = this.TeamIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BCE0 RID: 179424 RVA: 0x00606540 File Offset: 0x00604740
		public static Offset<IChangeFightTeam> Pack(FlatBufferBuilder builder, IChangeFightTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeFightTeam>);
			}
			return IChangeFightTeam.CreateIChangeFightTeam(builder, _o.TeamIndex, _o.NullMask);
		}

		// Token: 0x040108B3 RID: 67763
		private Table __p;
	}
}
