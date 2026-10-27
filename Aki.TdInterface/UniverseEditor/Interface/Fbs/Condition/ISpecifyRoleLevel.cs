using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD3 RID: 19667
	public struct ISpecifyRoleLevel : IFlatbufferObject
	{
		// Token: 0x17008EB8 RID: 36536
		// (get) Token: 0x0601F33D RID: 127805 RVA: 0x0045AFA6 File Offset: 0x004591A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F33E RID: 127806 RVA: 0x0045AFB3 File Offset: 0x004591B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F33F RID: 127807 RVA: 0x0045AFBC File Offset: 0x004591BC
		public static ISpecifyRoleLevel GetRootAsISpecifyRoleLevel(ByteBuffer _bb)
		{
			return ISpecifyRoleLevel.GetRootAsISpecifyRoleLevel(_bb, default(ISpecifyRoleLevel));
		}

		// Token: 0x0601F340 RID: 127808 RVA: 0x0045AFD8 File Offset: 0x004591D8
		public static ISpecifyRoleLevel GetRootAsISpecifyRoleLevel(ByteBuffer _bb, ISpecifyRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F341 RID: 127809 RVA: 0x0045AFF5 File Offset: 0x004591F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F342 RID: 127810 RVA: 0x0045B004 File Offset: 0x00459204
		public ISpecifyRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EB9 RID: 36537
		// (get) Token: 0x0601F343 RID: 127811 RVA: 0x0045B014 File Offset: 0x00459214
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

		// Token: 0x17008EBA RID: 36538
		// (get) Token: 0x0601F344 RID: 127812 RVA: 0x0045B050 File Offset: 0x00459250
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

		// Token: 0x17008EBB RID: 36539
		// (get) Token: 0x0601F345 RID: 127813 RVA: 0x0045B08C File Offset: 0x0045928C
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

		// Token: 0x17008EBC RID: 36540
		// (get) Token: 0x0601F346 RID: 127814 RVA: 0x0045B0C8 File Offset: 0x004592C8
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

		// Token: 0x0601F347 RID: 127815 RVA: 0x0045B105 File Offset: 0x00459305
		public static Offset<ISpecifyRoleLevel> CreateISpecifyRoleLevel(FlatBufferBuilder builder, ERoleLevelType Type = ERoleLevelType.SpecifyRole, int Index = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			ISpecifyRoleLevel.AddLevel(builder, Level);
			ISpecifyRoleLevel.AddIndex(builder, Index);
			ISpecifyRoleLevel.AddCompare(builder, Compare);
			ISpecifyRoleLevel.AddType(builder, Type);
			return ISpecifyRoleLevel.EndISpecifyRoleLevel(builder);
		}

		// Token: 0x0601F348 RID: 127816 RVA: 0x0045B131 File Offset: 0x00459331
		public static void StartISpecifyRoleLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F349 RID: 127817 RVA: 0x0045B13A File Offset: 0x0045933A
		public static void AddType(FlatBufferBuilder builder, ERoleLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F34A RID: 127818 RVA: 0x0045B145 File Offset: 0x00459345
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x0601F34B RID: 127819 RVA: 0x0045B150 File Offset: 0x00459350
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601F34C RID: 127820 RVA: 0x0045B15B File Offset: 0x0045935B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601F34D RID: 127821 RVA: 0x0045B166 File Offset: 0x00459366
		public static Offset<ISpecifyRoleLevel> EndISpecifyRoleLevel(FlatBufferBuilder builder)
		{
			return new Offset<ISpecifyRoleLevel>(builder.EndTable());
		}

		// Token: 0x0601F34E RID: 127822 RVA: 0x0045B174 File Offset: 0x00459374
		public ISpecifyRoleLevelT UnPack()
		{
			ISpecifyRoleLevelT specifyRoleLevelT = new ISpecifyRoleLevelT();
			this.UnPackTo(specifyRoleLevelT);
			return specifyRoleLevelT;
		}

		// Token: 0x0601F34F RID: 127823 RVA: 0x0045B18F File Offset: 0x0045938F
		public void UnPackTo(ISpecifyRoleLevelT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601F350 RID: 127824 RVA: 0x0045B1C4 File Offset: 0x004593C4
		public static Offset<ISpecifyRoleLevel> Pack(FlatBufferBuilder builder, ISpecifyRoleLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecifyRoleLevel>);
			}
			return ISpecifyRoleLevel.CreateISpecifyRoleLevel(builder, _o.Type, _o.Index, _o.Compare, _o.Level);
		}

		// Token: 0x0400D69D RID: 54941
		private Table __p;
	}
}
