using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004642 RID: 17986
	public struct IEquipGraduatedWeaponToTeam : IFlatbufferObject
	{
		// Token: 0x17007F9E RID: 32670
		// (get) Token: 0x0601B3E1 RID: 111585 RVA: 0x003E08A9 File Offset: 0x003DEAA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x003E08B6 File Offset: 0x003DEAB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x003E08C0 File Offset: 0x003DEAC0
		public static IEquipGraduatedWeaponToTeam GetRootAsIEquipGraduatedWeaponToTeam(ByteBuffer _bb)
		{
			return IEquipGraduatedWeaponToTeam.GetRootAsIEquipGraduatedWeaponToTeam(_bb, default(IEquipGraduatedWeaponToTeam));
		}

		// Token: 0x0601B3E4 RID: 111588 RVA: 0x003E08DC File Offset: 0x003DEADC
		public static IEquipGraduatedWeaponToTeam GetRootAsIEquipGraduatedWeaponToTeam(ByteBuffer _bb, IEquipGraduatedWeaponToTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B3E5 RID: 111589 RVA: 0x003E08F9 File Offset: 0x003DEAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B3E6 RID: 111590 RVA: 0x003E0908 File Offset: 0x003DEB08
		public IEquipGraduatedWeaponToTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F9F RID: 32671
		// (get) Token: 0x0601B3E7 RID: 111591 RVA: 0x003E0918 File Offset: 0x003DEB18
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

		// Token: 0x0601B3E8 RID: 111592 RVA: 0x003E0954 File Offset: 0x003DEB54
		public static Offset<IEquipGraduatedWeaponToTeam> CreateIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IEquipGraduatedWeaponToTeam.AddType(builder, Type);
			return IEquipGraduatedWeaponToTeam.EndIEquipGraduatedWeaponToTeam(builder);
		}

		// Token: 0x0601B3E9 RID: 111593 RVA: 0x003E096A File Offset: 0x003DEB6A
		public static void StartIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B3EA RID: 111594 RVA: 0x003E0973 File Offset: 0x003DEB73
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B3EB RID: 111595 RVA: 0x003E097E File Offset: 0x003DEB7E
		public static Offset<IEquipGraduatedWeaponToTeam> EndIEquipGraduatedWeaponToTeam(FlatBufferBuilder builder)
		{
			return new Offset<IEquipGraduatedWeaponToTeam>(builder.EndTable());
		}

		// Token: 0x0601B3EC RID: 111596 RVA: 0x003E098C File Offset: 0x003DEB8C
		public IEquipGraduatedWeaponToTeamT UnPack()
		{
			IEquipGraduatedWeaponToTeamT equipGraduatedWeaponToTeamT = new IEquipGraduatedWeaponToTeamT();
			this.UnPackTo(equipGraduatedWeaponToTeamT);
			return equipGraduatedWeaponToTeamT;
		}

		// Token: 0x0601B3ED RID: 111597 RVA: 0x003E09A7 File Offset: 0x003DEBA7
		public void UnPackTo(IEquipGraduatedWeaponToTeamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B3EE RID: 111598 RVA: 0x003E09B8 File Offset: 0x003DEBB8
		public static Offset<IEquipGraduatedWeaponToTeam> Pack(FlatBufferBuilder builder, IEquipGraduatedWeaponToTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEquipGraduatedWeaponToTeam>);
			}
			return IEquipGraduatedWeaponToTeam.CreateIEquipGraduatedWeaponToTeam(builder, _o.Type);
		}

		// Token: 0x0400C7B8 RID: 51128
		private Table __p;
	}
}
