using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD6 RID: 19670
	public struct ISpecifyRoleWeaponLevel : IFlatbufferObject
	{
		// Token: 0x17008EC1 RID: 36545
		// (get) Token: 0x0601F35B RID: 127835 RVA: 0x0045B2C0 File Offset: 0x004594C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F35C RID: 127836 RVA: 0x0045B2CD File Offset: 0x004594CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F35D RID: 127837 RVA: 0x0045B2D4 File Offset: 0x004594D4
		public static ISpecifyRoleWeaponLevel GetRootAsISpecifyRoleWeaponLevel(ByteBuffer _bb)
		{
			return ISpecifyRoleWeaponLevel.GetRootAsISpecifyRoleWeaponLevel(_bb, default(ISpecifyRoleWeaponLevel));
		}

		// Token: 0x0601F35E RID: 127838 RVA: 0x0045B2F0 File Offset: 0x004594F0
		public static ISpecifyRoleWeaponLevel GetRootAsISpecifyRoleWeaponLevel(ByteBuffer _bb, ISpecifyRoleWeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F35F RID: 127839 RVA: 0x0045B30D File Offset: 0x0045950D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F360 RID: 127840 RVA: 0x0045B31C File Offset: 0x0045951C
		public ISpecifyRoleWeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EC2 RID: 36546
		// (get) Token: 0x0601F361 RID: 127841 RVA: 0x0045B32C File Offset: 0x0045952C
		public EWeaponLevelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWeaponLevelType.SpecifyRole;
				}
				return (EWeaponLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EC3 RID: 36547
		// (get) Token: 0x0601F362 RID: 127842 RVA: 0x0045B368 File Offset: 0x00459568
		public int Index
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

		// Token: 0x17008EC4 RID: 36548
		// (get) Token: 0x0601F363 RID: 127843 RVA: 0x0045B3A4 File Offset: 0x004595A4
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EC5 RID: 36549
		// (get) Token: 0x0601F364 RID: 127844 RVA: 0x0045B3E0 File Offset: 0x004595E0
		public int Level
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F365 RID: 127845 RVA: 0x0045B41D File Offset: 0x0045961D
		public static Offset<ISpecifyRoleWeaponLevel> CreateISpecifyRoleWeaponLevel(FlatBufferBuilder builder, EWeaponLevelType Type = EWeaponLevelType.SpecifyRole, int Index = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ISpecifyRoleWeaponLevel.AddLevel(builder, Level);
			ISpecifyRoleWeaponLevel.AddIndex(builder, Index);
			ISpecifyRoleWeaponLevel.AddCompare(builder, Compare);
			ISpecifyRoleWeaponLevel.AddType(builder, Type);
			return ISpecifyRoleWeaponLevel.EndISpecifyRoleWeaponLevel(builder);
		}

		// Token: 0x0601F366 RID: 127846 RVA: 0x0045B449 File Offset: 0x00459649
		public static void StartISpecifyRoleWeaponLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F367 RID: 127847 RVA: 0x0045B452 File Offset: 0x00459652
		public static void AddType(FlatBufferBuilder builder, EWeaponLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F368 RID: 127848 RVA: 0x0045B45D File Offset: 0x0045965D
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x0601F369 RID: 127849 RVA: 0x0045B468 File Offset: 0x00459668
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F36A RID: 127850 RVA: 0x0045B473 File Offset: 0x00459673
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601F36B RID: 127851 RVA: 0x0045B47E File Offset: 0x0045967E
		public static Offset<ISpecifyRoleWeaponLevel> EndISpecifyRoleWeaponLevel(FlatBufferBuilder builder)
		{
			return new Offset<ISpecifyRoleWeaponLevel>(builder.EndTable());
		}

		// Token: 0x0601F36C RID: 127852 RVA: 0x0045B48C File Offset: 0x0045968C
		public ISpecifyRoleWeaponLevelT UnPack()
		{
			ISpecifyRoleWeaponLevelT specifyRoleWeaponLevelT = new ISpecifyRoleWeaponLevelT();
			this.UnPackTo(specifyRoleWeaponLevelT);
			return specifyRoleWeaponLevelT;
		}

		// Token: 0x0601F36D RID: 127853 RVA: 0x0045B4A7 File Offset: 0x004596A7
		public void UnPackTo(ISpecifyRoleWeaponLevelT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F36E RID: 127854 RVA: 0x0045B4DC File Offset: 0x004596DC
		public static Offset<ISpecifyRoleWeaponLevel> Pack(FlatBufferBuilder builder, ISpecifyRoleWeaponLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecifyRoleWeaponLevel>);
			}
			return ISpecifyRoleWeaponLevel.CreateISpecifyRoleWeaponLevel(builder, _o.Type, _o.Index, _o.Compare, _o.Level);
		}

		// Token: 0x0400D6A2 RID: 54946
		private Table __p;
	}
}
