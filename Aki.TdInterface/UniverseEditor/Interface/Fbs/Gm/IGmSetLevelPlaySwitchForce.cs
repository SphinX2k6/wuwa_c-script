using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD1 RID: 19153
	public struct IGmSetLevelPlaySwitchForce : IFlatbufferObject
	{
		// Token: 0x17008639 RID: 34361
		// (get) Token: 0x0601CD7C RID: 118140 RVA: 0x0040FD34 File Offset: 0x0040DF34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CD7D RID: 118141 RVA: 0x0040FD41 File Offset: 0x0040DF41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CD7E RID: 118142 RVA: 0x0040FD48 File Offset: 0x0040DF48
		public static IGmSetLevelPlaySwitchForce GetRootAsIGmSetLevelPlaySwitchForce(ByteBuffer _bb)
		{
			return IGmSetLevelPlaySwitchForce.GetRootAsIGmSetLevelPlaySwitchForce(_bb, default(IGmSetLevelPlaySwitchForce));
		}

		// Token: 0x0601CD7F RID: 118143 RVA: 0x0040FD64 File Offset: 0x0040DF64
		public static IGmSetLevelPlaySwitchForce GetRootAsIGmSetLevelPlaySwitchForce(ByteBuffer _bb, IGmSetLevelPlaySwitchForce obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CD80 RID: 118144 RVA: 0x0040FD81 File Offset: 0x0040DF81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CD81 RID: 118145 RVA: 0x0040FD90 File Offset: 0x0040DF90
		public IGmSetLevelPlaySwitchForce __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700863A RID: 34362
		// (get) Token: 0x0601CD82 RID: 118146 RVA: 0x0040FDA0 File Offset: 0x0040DFA0
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

		// Token: 0x1700863B RID: 34363
		// (get) Token: 0x0601CD83 RID: 118147 RVA: 0x0040FDDC File Offset: 0x0040DFDC
		public int LevelPlayId
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

		// Token: 0x1700863C RID: 34364
		// (get) Token: 0x0601CD84 RID: 118148 RVA: 0x0040FE18 File Offset: 0x0040E018
		public bool IsOpen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CD85 RID: 118149 RVA: 0x0040FE57 File Offset: 0x0040E057
		public static Offset<IGmSetLevelPlaySwitchForce> CreateIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, bool IsOpen = false)
		{
			builder.StartTable(3);
			IGmSetLevelPlaySwitchForce.AddLevelPlayId(builder, LevelPlayId);
			IGmSetLevelPlaySwitchForce.AddIsOpen(builder, IsOpen);
			IGmSetLevelPlaySwitchForce.AddType(builder, Type);
			return IGmSetLevelPlaySwitchForce.EndIGmSetLevelPlaySwitchForce(builder);
		}

		// Token: 0x0601CD86 RID: 118150 RVA: 0x0040FE7B File Offset: 0x0040E07B
		public static void StartIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601CD87 RID: 118151 RVA: 0x0040FE84 File Offset: 0x0040E084
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CD88 RID: 118152 RVA: 0x0040FE8F File Offset: 0x0040E08F
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601CD89 RID: 118153 RVA: 0x0040FE9A File Offset: 0x0040E09A
		public static void AddIsOpen(FlatBufferBuilder builder, bool isOpen)
		{
			builder.AddBool(2, isOpen, false);
		}

		// Token: 0x0601CD8A RID: 118154 RVA: 0x0040FEA5 File Offset: 0x0040E0A5
		public static Offset<IGmSetLevelPlaySwitchForce> EndIGmSetLevelPlaySwitchForce(FlatBufferBuilder builder)
		{
			return new Offset<IGmSetLevelPlaySwitchForce>(builder.EndTable());
		}

		// Token: 0x0601CD8B RID: 118155 RVA: 0x0040FEB4 File Offset: 0x0040E0B4
		public IGmSetLevelPlaySwitchForceT UnPack()
		{
			IGmSetLevelPlaySwitchForceT gmSetLevelPlaySwitchForceT = new IGmSetLevelPlaySwitchForceT();
			this.UnPackTo(gmSetLevelPlaySwitchForceT);
			return gmSetLevelPlaySwitchForceT;
		}

		// Token: 0x0601CD8C RID: 118156 RVA: 0x0040FECF File Offset: 0x0040E0CF
		public void UnPackTo(IGmSetLevelPlaySwitchForceT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.IsOpen = this.IsOpen;
		}

		// Token: 0x0601CD8D RID: 118157 RVA: 0x0040FEF8 File Offset: 0x0040E0F8
		public static Offset<IGmSetLevelPlaySwitchForce> Pack(FlatBufferBuilder builder, IGmSetLevelPlaySwitchForceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmSetLevelPlaySwitchForce>);
			}
			return IGmSetLevelPlaySwitchForce.CreateIGmSetLevelPlaySwitchForce(builder, _o.Type, _o.LevelPlayId, _o.IsOpen);
		}

		// Token: 0x0400D256 RID: 53846
		private Table __p;
	}
}
