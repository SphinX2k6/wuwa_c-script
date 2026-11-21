using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ACE RID: 19150
	public struct IGmRoguelikeStartInGm : IFlatbufferObject
	{
		// Token: 0x1700862E RID: 34350
		// (get) Token: 0x0601CD5A RID: 118106 RVA: 0x0040F98A File Offset: 0x0040DB8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CD5B RID: 118107 RVA: 0x0040F997 File Offset: 0x0040DB97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CD5C RID: 118108 RVA: 0x0040F9A0 File Offset: 0x0040DBA0
		public static IGmRoguelikeStartInGm GetRootAsIGmRoguelikeStartInGm(ByteBuffer _bb)
		{
			return IGmRoguelikeStartInGm.GetRootAsIGmRoguelikeStartInGm(_bb, default(IGmRoguelikeStartInGm));
		}

		// Token: 0x0601CD5D RID: 118109 RVA: 0x0040F9BC File Offset: 0x0040DBBC
		public static IGmRoguelikeStartInGm GetRootAsIGmRoguelikeStartInGm(ByteBuffer _bb, IGmRoguelikeStartInGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CD5E RID: 118110 RVA: 0x0040F9D9 File Offset: 0x0040DBD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CD5F RID: 118111 RVA: 0x0040F9E8 File Offset: 0x0040DBE8
		public IGmRoguelikeStartInGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700862F RID: 34351
		// (get) Token: 0x0601CD60 RID: 118112 RVA: 0x0040F9F8 File Offset: 0x0040DBF8
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

		// Token: 0x17008630 RID: 34352
		// (get) Token: 0x0601CD61 RID: 118113 RVA: 0x0040FA34 File Offset: 0x0040DC34
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

		// Token: 0x17008631 RID: 34353
		// (get) Token: 0x0601CD62 RID: 118114 RVA: 0x0040FA70 File Offset: 0x0040DC70
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

		// Token: 0x17008632 RID: 34354
		// (get) Token: 0x0601CD63 RID: 118115 RVA: 0x0040FAAC File Offset: 0x0040DCAC
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

		// Token: 0x17008633 RID: 34355
		// (get) Token: 0x0601CD64 RID: 118116 RVA: 0x0040FAEC File Offset: 0x0040DCEC
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

		// Token: 0x0601CD65 RID: 118117 RVA: 0x0040FB29 File Offset: 0x0040DD29
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

		// Token: 0x0601CD66 RID: 118118 RVA: 0x0040FB5D File Offset: 0x0040DD5D
		public static void StartIGmRoguelikeStartInGm(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601CD67 RID: 118119 RVA: 0x0040FB66 File Offset: 0x0040DD66
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CD68 RID: 118120 RVA: 0x0040FB71 File Offset: 0x0040DD71
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601CD69 RID: 118121 RVA: 0x0040FB7C File Offset: 0x0040DD7C
		public static void AddSeasonId(FlatBufferBuilder builder, int seasonId)
		{
			builder.AddInt(2, seasonId, 0);
		}

		// Token: 0x0601CD6A RID: 118122 RVA: 0x0040FB87 File Offset: 0x0040DD87
		public static void AddInherit(FlatBufferBuilder builder, int inherit)
		{
			builder.AddInt(3, inherit, 0);
		}

		// Token: 0x0601CD6B RID: 118123 RVA: 0x0040FB92 File Offset: 0x0040DD92
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(4, roleId, 0);
		}

		// Token: 0x0601CD6C RID: 118124 RVA: 0x0040FB9D File Offset: 0x0040DD9D
		public static Offset<IGmRoguelikeStartInGm> EndIGmRoguelikeStartInGm(FlatBufferBuilder builder)
		{
			return new Offset<IGmRoguelikeStartInGm>(builder.EndTable());
		}

		// Token: 0x0601CD6D RID: 118125 RVA: 0x0040FBAC File Offset: 0x0040DDAC
		public IGmRoguelikeStartInGmT UnPack()
		{
			IGmRoguelikeStartInGmT gmRoguelikeStartInGmT = new IGmRoguelikeStartInGmT();
			this.UnPackTo(gmRoguelikeStartInGmT);
			return gmRoguelikeStartInGmT;
		}

		// Token: 0x0601CD6E RID: 118126 RVA: 0x0040FBC7 File Offset: 0x0040DDC7
		public void UnPackTo(IGmRoguelikeStartInGmT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.SeasonId = this.SeasonId;
			_o.Inherit = this.Inherit;
			_o.RoleId = this.RoleId;
		}

		// Token: 0x0601CD6F RID: 118127 RVA: 0x0040FC08 File Offset: 0x0040DE08
		public static Offset<IGmRoguelikeStartInGm> Pack(FlatBufferBuilder builder, IGmRoguelikeStartInGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmRoguelikeStartInGm>);
			}
			return IGmRoguelikeStartInGm.CreateIGmRoguelikeStartInGm(builder, _o.Type, _o.DungeonId, _o.SeasonId, _o.Inherit, _o.RoleId);
		}

		// Token: 0x0400D250 RID: 53840
		private Table __p;
	}
}
