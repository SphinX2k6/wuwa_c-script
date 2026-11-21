using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696A RID: 26986
	public struct IChangeFightTeam : IFlatbufferObject
	{
		// Token: 0x1700C6A4 RID: 50852
		// (get) Token: 0x0602E43A RID: 189498 RVA: 0x006513E2 File Offset: 0x0064F5E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E43B RID: 189499 RVA: 0x006513EF File Offset: 0x0064F5EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E43C RID: 189500 RVA: 0x006513F8 File Offset: 0x0064F5F8
		public static IChangeFightTeam GetRootAsIChangeFightTeam(ByteBuffer _bb)
		{
			return IChangeFightTeam.GetRootAsIChangeFightTeam(_bb, default(IChangeFightTeam));
		}

		// Token: 0x0602E43D RID: 189501 RVA: 0x00651414 File Offset: 0x0064F614
		public static IChangeFightTeam GetRootAsIChangeFightTeam(ByteBuffer _bb, IChangeFightTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E43E RID: 189502 RVA: 0x00651431 File Offset: 0x0064F631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E43F RID: 189503 RVA: 0x00651440 File Offset: 0x0064F640
		public IChangeFightTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6A5 RID: 50853
		// (get) Token: 0x0602E440 RID: 189504 RVA: 0x00651450 File Offset: 0x0064F650
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

		// Token: 0x1700C6A6 RID: 50854
		// (get) Token: 0x0602E441 RID: 189505 RVA: 0x0065148C File Offset: 0x0064F68C
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

		// Token: 0x0602E442 RID: 189506 RVA: 0x006514C8 File Offset: 0x0064F6C8
		public static Offset<IChangeFightTeam> CreateIChangeFightTeam(FlatBufferBuilder builder, int TeamIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IChangeFightTeam.AddTeamIndex(builder, TeamIndex);
			IChangeFightTeam.AddNullMask(builder, NullMask);
			return IChangeFightTeam.EndIChangeFightTeam(builder);
		}

		// Token: 0x0602E443 RID: 189507 RVA: 0x006514E5 File Offset: 0x0064F6E5
		public static void StartIChangeFightTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E444 RID: 189508 RVA: 0x006514EE File Offset: 0x0064F6EE
		public static void AddTeamIndex(FlatBufferBuilder builder, int teamIndex)
		{
			builder.AddInt(0, teamIndex, 0);
		}

		// Token: 0x0602E445 RID: 189509 RVA: 0x006514F9 File Offset: 0x0064F6F9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602E446 RID: 189510 RVA: 0x00651504 File Offset: 0x0064F704
		public static Offset<IChangeFightTeam> EndIChangeFightTeam(FlatBufferBuilder builder)
		{
			return new Offset<IChangeFightTeam>(builder.EndTable());
		}

		// Token: 0x0602E447 RID: 189511 RVA: 0x00651514 File Offset: 0x0064F714
		public IChangeFightTeamT UnPack()
		{
			IChangeFightTeamT changeFightTeamT = new IChangeFightTeamT();
			this.UnPackTo(changeFightTeamT);
			return changeFightTeamT;
		}

		// Token: 0x0602E448 RID: 189512 RVA: 0x0065152F File Offset: 0x0064F72F
		public void UnPackTo(IChangeFightTeamT _o)
		{
			_o.TeamIndex = this.TeamIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E449 RID: 189513 RVA: 0x0065154C File Offset: 0x0064F74C
		public static Offset<IChangeFightTeam> Pack(FlatBufferBuilder builder, IChangeFightTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeFightTeam>);
			}
			return IChangeFightTeam.CreateIChangeFightTeam(builder, _o.TeamIndex, _o.NullMask);
		}

		// Token: 0x040116C9 RID: 71369
		private Table __p;
	}
}
