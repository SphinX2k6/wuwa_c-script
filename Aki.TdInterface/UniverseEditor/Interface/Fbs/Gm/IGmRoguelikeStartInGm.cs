using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004666 RID: 18022
	public struct IGmRoguelikeStartInGm : IFlatbufferObject
	{
		// Token: 0x17007FED RID: 32749
		// (get) Token: 0x0601B585 RID: 112005 RVA: 0x003E36EE File Offset: 0x003E18EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B586 RID: 112006 RVA: 0x003E36FB File Offset: 0x003E18FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B587 RID: 112007 RVA: 0x003E3704 File Offset: 0x003E1904
		public static IGmRoguelikeStartInGm GetRootAsIGmRoguelikeStartInGm(ByteBuffer _bb)
		{
			return IGmRoguelikeStartInGm.GetRootAsIGmRoguelikeStartInGm(_bb, default(IGmRoguelikeStartInGm));
		}

		// Token: 0x0601B588 RID: 112008 RVA: 0x003E3720 File Offset: 0x003E1920
		public static IGmRoguelikeStartInGm GetRootAsIGmRoguelikeStartInGm(ByteBuffer _bb, IGmRoguelikeStartInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B589 RID: 112009 RVA: 0x003E373D File Offset: 0x003E193D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B58A RID: 112010 RVA: 0x003E374C File Offset: 0x003E194C
		public IGmRoguelikeStartInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FEE RID: 32750
		// (get) Token: 0x0601B58B RID: 112011 RVA: 0x003E375C File Offset: 0x003E195C
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

		// Token: 0x17007FEF RID: 32751
		// (get) Token: 0x0601B58C RID: 112012 RVA: 0x003E3798 File Offset: 0x003E1998
		public int DungeonId
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

		// Token: 0x17007FF0 RID: 32752
		// (get) Token: 0x0601B58D RID: 112013 RVA: 0x003E37D4 File Offset: 0x003E19D4
		public int SeasonId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FF1 RID: 32753
		// (get) Token: 0x0601B58E RID: 112014 RVA: 0x003E3810 File Offset: 0x003E1A10
		public int Inherit
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

		// Token: 0x17007FF2 RID: 32754
		// (get) Token: 0x0601B58F RID: 112015 RVA: 0x003E3850 File Offset: 0x003E1A50
		public int RoleId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B590 RID: 112016 RVA: 0x003E388D File Offset: 0x003E1A8D
		public static Offset<IGmRoguelikeStartInGm> CreateIGmRoguelikeStartInGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int DungeonId = 0, int SeasonId = 0, int Inherit = 0, int RoleId = 0)
		{
			builder.StartTable(5);
			IGmRoguelikeStartInGm.AddRoleId(builder, RoleId);
			IGmRoguelikeStartInGm.AddInherit(builder, Inherit);
			IGmRoguelikeStartInGm.AddSeasonId(builder, SeasonId);
			IGmRoguelikeStartInGm.AddDungeonId(builder, DungeonId);
			IGmRoguelikeStartInGm.AddType(builder, Type);
			return IGmRoguelikeStartInGm.EndIGmRoguelikeStartInGm(builder);
		}

		// Token: 0x0601B591 RID: 112017 RVA: 0x003E38C1 File Offset: 0x003E1AC1
		public static void StartIGmRoguelikeStartInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601B592 RID: 112018 RVA: 0x003E38CA File Offset: 0x003E1ACA
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B593 RID: 112019 RVA: 0x003E38D5 File Offset: 0x003E1AD5
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601B594 RID: 112020 RVA: 0x003E38E0 File Offset: 0x003E1AE0
		public static void AddSeasonId(FlatBufferBuilder builder, int seasonId)
		{
			builder.AddInt(2, seasonId, 0);
		}

		// Token: 0x0601B595 RID: 112021 RVA: 0x003E38EB File Offset: 0x003E1AEB
		public static void AddInherit(FlatBufferBuilder builder, int inherit)
		{
			builder.AddInt(3, inherit, 0);
		}

		// Token: 0x0601B596 RID: 112022 RVA: 0x003E38F6 File Offset: 0x003E1AF6
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(4, roleId, 0);
		}

		// Token: 0x0601B597 RID: 112023 RVA: 0x003E3901 File Offset: 0x003E1B01
		public static Offset<IGmRoguelikeStartInGm> EndIGmRoguelikeStartInGm(FlatBufferBuilder builder)
		{
			return new Offset<IGmRoguelikeStartInGm>(builder.EndTable());
		}

		// Token: 0x0601B598 RID: 112024 RVA: 0x003E3910 File Offset: 0x003E1B10
		public IGmRoguelikeStartInGmT UnPack()
		{
			IGmRoguelikeStartInGmT gmRoguelikeStartInGmT = new IGmRoguelikeStartInGmT();
			this.UnPackTo(gmRoguelikeStartInGmT);
			return gmRoguelikeStartInGmT;
		}

		// Token: 0x0601B599 RID: 112025 RVA: 0x003E392B File Offset: 0x003E1B2B
		public void UnPackTo(IGmRoguelikeStartInGmT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.SeasonId = this.SeasonId;
			_o.Inherit = this.Inherit;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0601B59A RID: 112026 RVA: 0x003E396C File Offset: 0x003E1B6C
		public static Offset<IGmRoguelikeStartInGm> Pack(FlatBufferBuilder builder, IGmRoguelikeStartInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmRoguelikeStartInGm>);
			}
			return IGmRoguelikeStartInGm.CreateIGmRoguelikeStartInGm(builder, _o.Type, _o.DungeonId, _o.SeasonId, _o.Inherit, _o.RoleId);
		}

		// Token: 0x0400C821 RID: 51233
		private Table __p;
	}
}
