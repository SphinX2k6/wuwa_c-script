using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051D2 RID: 20946
	public struct ISpecifyRoleWeaponLevel : IFlatbufferObject
	{
		// Token: 0x170095FA RID: 38394
		// (get) Token: 0x06020F9F RID: 135071 RVA: 0x0048F1B8 File Offset: 0x0048D3B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020FA0 RID: 135072 RVA: 0x0048F1C5 File Offset: 0x0048D3C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020FA1 RID: 135073 RVA: 0x0048F1CC File Offset: 0x0048D3CC
		public static ISpecifyRoleWeaponLevel GetRootAsISpecifyRoleWeaponLevel(ByteBuffer _bb)
		{
			return ISpecifyRoleWeaponLevel.GetRootAsISpecifyRoleWeaponLevel(_bb, default(ISpecifyRoleWeaponLevel));
		}

		// Token: 0x06020FA2 RID: 135074 RVA: 0x0048F1E8 File Offset: 0x0048D3E8
		public static ISpecifyRoleWeaponLevel GetRootAsISpecifyRoleWeaponLevel(ByteBuffer _bb, ISpecifyRoleWeaponLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020FA3 RID: 135075 RVA: 0x0048F205 File Offset: 0x0048D405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020FA4 RID: 135076 RVA: 0x0048F214 File Offset: 0x0048D414
		public ISpecifyRoleWeaponLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095FB RID: 38395
		// (get) Token: 0x06020FA5 RID: 135077 RVA: 0x0048F224 File Offset: 0x0048D424
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

		// Token: 0x170095FC RID: 38396
		// (get) Token: 0x06020FA6 RID: 135078 RVA: 0x0048F260 File Offset: 0x0048D460
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

		// Token: 0x170095FD RID: 38397
		// (get) Token: 0x06020FA7 RID: 135079 RVA: 0x0048F29C File Offset: 0x0048D49C
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

		// Token: 0x170095FE RID: 38398
		// (get) Token: 0x06020FA8 RID: 135080 RVA: 0x0048F2D8 File Offset: 0x0048D4D8
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

		// Token: 0x06020FA9 RID: 135081 RVA: 0x0048F315 File Offset: 0x0048D515
		public static Offset<ISpecifyRoleWeaponLevel> CreateISpecifyRoleWeaponLevel(FlatBufferBuilder builder, EWeaponLevelType Type = EWeaponLevelType.SpecifyRole, int Index = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ISpecifyRoleWeaponLevel.AddLevel(builder, Level);
			ISpecifyRoleWeaponLevel.AddIndex(builder, Index);
			ISpecifyRoleWeaponLevel.AddCompare(builder, Compare);
			ISpecifyRoleWeaponLevel.AddType(builder, Type);
			return ISpecifyRoleWeaponLevel.EndISpecifyRoleWeaponLevel(builder);
		}

		// Token: 0x06020FAA RID: 135082 RVA: 0x0048F341 File Offset: 0x0048D541
		public static void StartISpecifyRoleWeaponLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020FAB RID: 135083 RVA: 0x0048F34A File Offset: 0x0048D54A
		public static void AddType(FlatBufferBuilder builder, EWeaponLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020FAC RID: 135084 RVA: 0x0048F355 File Offset: 0x0048D555
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06020FAD RID: 135085 RVA: 0x0048F360 File Offset: 0x0048D560
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020FAE RID: 135086 RVA: 0x0048F36B File Offset: 0x0048D56B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x06020FAF RID: 135087 RVA: 0x0048F376 File Offset: 0x0048D576
		public static Offset<ISpecifyRoleWeaponLevel> EndISpecifyRoleWeaponLevel(FlatBufferBuilder builder)
		{
			return new Offset<ISpecifyRoleWeaponLevel>(builder.EndTable());
		}

		// Token: 0x06020FB0 RID: 135088 RVA: 0x0048F384 File Offset: 0x0048D584
		public ISpecifyRoleWeaponLevelT UnPack()
		{
			ISpecifyRoleWeaponLevelT specifyRoleWeaponLevelT = new ISpecifyRoleWeaponLevelT();
			this.UnPackTo(specifyRoleWeaponLevelT);
			return specifyRoleWeaponLevelT;
		}

		// Token: 0x06020FB1 RID: 135089 RVA: 0x0048F39F File Offset: 0x0048D59F
		public void UnPackTo(ISpecifyRoleWeaponLevelT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x06020FB2 RID: 135090 RVA: 0x0048F3D4 File Offset: 0x0048D5D4
		public static Offset<ISpecifyRoleWeaponLevel> Pack(FlatBufferBuilder builder, ISpecifyRoleWeaponLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecifyRoleWeaponLevel>);
			}
			return ISpecifyRoleWeaponLevel.CreateISpecifyRoleWeaponLevel(builder, _o.Type, _o.Index, _o.Compare, _o.Level);
		}

		// Token: 0x0400E1CF RID: 57807
		private Table __p;
	}
}
