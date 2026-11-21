using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAA RID: 19114
	public struct IEquipGraduatedWeaponToTeam : IFlatbufferObject
	{
		// Token: 0x170085DF RID: 34271
		// (get) Token: 0x0601CBB6 RID: 117686 RVA: 0x0040CB45 File Offset: 0x0040AD45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBB7 RID: 117687 RVA: 0x0040CB52 File Offset: 0x0040AD52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBB8 RID: 117688 RVA: 0x0040CB5C File Offset: 0x0040AD5C
		public static IEquipGraduatedWeaponToTeam GetRootAsIEquipGraduatedWeaponToTeam(ByteBuffer _bb)
		{
			return IEquipGraduatedWeaponToTeam.GetRootAsIEquipGraduatedWeaponToTeam(_bb, default(IEquipGraduatedWeaponToTeam));
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x0040CB78 File Offset: 0x0040AD78
		public static IEquipGraduatedWeaponToTeam GetRootAsIEquipGraduatedWeaponToTeam(ByteBuffer _bb, IEquipGraduatedWeaponToTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x0040CB95 File Offset: 0x0040AD95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x0040CBA4 File Offset: 0x0040ADA4
		public IEquipGraduatedWeaponToTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085E0 RID: 34272
		// (get) Token: 0x0601CBBC RID: 117692 RVA: 0x0040CBB4 File Offset: 0x0040ADB4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CBBD RID: 117693 RVA: 0x0040CBF0 File Offset: 0x0040ADF0
		public static Offset<IEquipGraduatedWeaponToTeam> CreateIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IEquipGraduatedWeaponToTeam.AddType(builder, Type);
			return IEquipGraduatedWeaponToTeam.EndIEquipGraduatedWeaponToTeam(builder);
		}

		// Token: 0x0601CBBE RID: 117694 RVA: 0x0040CC06 File Offset: 0x0040AE06
		public static void StartIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x0040CC0F File Offset: 0x0040AE0F
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CBC0 RID: 117696 RVA: 0x0040CC1A File Offset: 0x0040AE1A
		public static Offset<IEquipGraduatedWeaponToTeam> EndIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder)
		{
			return new Offset<IEquipGraduatedWeaponToTeam>(builder.EndTable());
		}

		// Token: 0x0601CBC1 RID: 117697 RVA: 0x0040CC28 File Offset: 0x0040AE28
		public IEquipGraduatedWeaponToTeamT UnPack()
		{
			IEquipGraduatedWeaponToTeamT equipGraduatedWeaponToTeamT = new IEquipGraduatedWeaponToTeamT();
			this.UnPackTo(equipGraduatedWeaponToTeamT);
			return equipGraduatedWeaponToTeamT;
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x0040CC43 File Offset: 0x0040AE43
		public void UnPackTo(IEquipGraduatedWeaponToTeamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x0040CC54 File Offset: 0x0040AE54
		public static Offset<IEquipGraduatedWeaponToTeam> Pack(FlatBufferBuilder builder, IEquipGraduatedWeaponToTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEquipGraduatedWeaponToTeam>);
			}
			return IEquipGraduatedWeaponToTeam.CreateIEquipGraduatedWeaponToTeam(builder, _o.Type);
		}

		// Token: 0x0400D1E7 RID: 53735
		private Table __p;
	}
}
