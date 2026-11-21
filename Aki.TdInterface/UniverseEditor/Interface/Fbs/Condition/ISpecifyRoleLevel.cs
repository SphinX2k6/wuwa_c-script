using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051CF RID: 20943
	public struct ISpecifyRoleLevel : IFlatbufferObject
	{
		// Token: 0x170095F1 RID: 38385
		// (get) Token: 0x06020F81 RID: 135041 RVA: 0x0048EE9E File Offset: 0x0048D09E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F82 RID: 135042 RVA: 0x0048EEAB File Offset: 0x0048D0AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F83 RID: 135043 RVA: 0x0048EEB4 File Offset: 0x0048D0B4
		public static ISpecifyRoleLevel GetRootAsISpecifyRoleLevel(ByteBuffer _bb)
		{
			return ISpecifyRoleLevel.GetRootAsISpecifyRoleLevel(_bb, default(ISpecifyRoleLevel));
		}

		// Token: 0x06020F84 RID: 135044 RVA: 0x0048EED0 File Offset: 0x0048D0D0
		public static ISpecifyRoleLevel GetRootAsISpecifyRoleLevel(ByteBuffer _bb, ISpecifyRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F85 RID: 135045 RVA: 0x0048EEED File Offset: 0x0048D0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F86 RID: 135046 RVA: 0x0048EEFC File Offset: 0x0048D0FC
		public ISpecifyRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095F2 RID: 38386
		// (get) Token: 0x06020F87 RID: 135047 RVA: 0x0048EF0C File Offset: 0x0048D10C
		public ERoleLevelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleLevelType.SpecifyRole;
				}
				return (ERoleLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095F3 RID: 38387
		// (get) Token: 0x06020F88 RID: 135048 RVA: 0x0048EF48 File Offset: 0x0048D148
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

		// Token: 0x170095F4 RID: 38388
		// (get) Token: 0x06020F89 RID: 135049 RVA: 0x0048EF84 File Offset: 0x0048D184
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

		// Token: 0x170095F5 RID: 38389
		// (get) Token: 0x06020F8A RID: 135050 RVA: 0x0048EFC0 File Offset: 0x0048D1C0
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

		// Token: 0x06020F8B RID: 135051 RVA: 0x0048EFFD File Offset: 0x0048D1FD
		public static Offset<ISpecifyRoleLevel> CreateISpecifyRoleLevel(FlatBufferBuilder builder, ERoleLevelType Type = ERoleLevelType.SpecifyRole, int Index = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ISpecifyRoleLevel.AddLevel(builder, Level);
			ISpecifyRoleLevel.AddIndex(builder, Index);
			ISpecifyRoleLevel.AddCompare(builder, Compare);
			ISpecifyRoleLevel.AddType(builder, Type);
			return ISpecifyRoleLevel.EndISpecifyRoleLevel(builder);
		}

		// Token: 0x06020F8C RID: 135052 RVA: 0x0048F029 File Offset: 0x0048D229
		public static void StartISpecifyRoleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020F8D RID: 135053 RVA: 0x0048F032 File Offset: 0x0048D232
		public static void AddType(FlatBufferBuilder builder, ERoleLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F8E RID: 135054 RVA: 0x0048F03D File Offset: 0x0048D23D
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06020F8F RID: 135055 RVA: 0x0048F048 File Offset: 0x0048D248
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020F90 RID: 135056 RVA: 0x0048F053 File Offset: 0x0048D253
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x06020F91 RID: 135057 RVA: 0x0048F05E File Offset: 0x0048D25E
		public static Offset<ISpecifyRoleLevel> EndISpecifyRoleLevel(FlatBufferBuilder builder)
		{
			return new Offset<ISpecifyRoleLevel>(builder.EndTable());
		}

		// Token: 0x06020F92 RID: 135058 RVA: 0x0048F06C File Offset: 0x0048D26C
		public ISpecifyRoleLevelT UnPack()
		{
			ISpecifyRoleLevelT specifyRoleLevelT = new ISpecifyRoleLevelT();
			this.UnPackTo(specifyRoleLevelT);
			return specifyRoleLevelT;
		}

		// Token: 0x06020F93 RID: 135059 RVA: 0x0048F087 File Offset: 0x0048D287
		public void UnPackTo(ISpecifyRoleLevelT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x06020F94 RID: 135060 RVA: 0x0048F0BC File Offset: 0x0048D2BC
		public static Offset<ISpecifyRoleLevel> Pack(FlatBufferBuilder builder, ISpecifyRoleLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecifyRoleLevel>);
			}
			return ISpecifyRoleLevel.CreateISpecifyRoleLevel(builder, _o.Type, _o.Index, _o.Compare, _o.Level);
		}

		// Token: 0x0400E1CA RID: 57802
		private Table __p;
	}
}
