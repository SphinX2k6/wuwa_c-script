using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C62 RID: 27746
	public struct IDisableSectionalSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700CB77 RID: 52087
		// (get) Token: 0x0602FC88 RID: 195720 RVA: 0x00681F41 File Offset: 0x00680141
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC89 RID: 195721 RVA: 0x00681F4E File Offset: 0x0068014E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC8A RID: 195722 RVA: 0x00681F58 File Offset: 0x00680158
		public static IDisableSectionalSkillOperation GetRootAsIDisableSectionalSkillOperation(ByteBuffer _bb)
		{
			return IDisableSectionalSkillOperation.GetRootAsIDisableSectionalSkillOperation(_bb, default(IDisableSectionalSkillOperation));
		}

		// Token: 0x0602FC8B RID: 195723 RVA: 0x00681F74 File Offset: 0x00680174
		public static IDisableSectionalSkillOperation GetRootAsIDisableSectionalSkillOperation(ByteBuffer _bb, IDisableSectionalSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC8C RID: 195724 RVA: 0x00681F91 File Offset: 0x00680191
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC8D RID: 195725 RVA: 0x00681FA0 File Offset: 0x006801A0
		public IDisableSectionalSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB78 RID: 52088
		// (get) Token: 0x0602FC8E RID: 195726 RVA: 0x00681FB0 File Offset: 0x006801B0
		public ESkillOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkillOperationType.Enable;
				}
				return (ESkillOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB79 RID: 52089
		// (get) Token: 0x0602FC8F RID: 195727 RVA: 0x00681FEC File Offset: 0x006801EC
		public EDisplayModeInSkillOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInSkillOp.Ashen;
				}
				return (EDisplayModeInSkillOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB7A RID: 52090
		// (get) Token: 0x0602FC90 RID: 195728 RVA: 0x00682028 File Offset: 0x00680228
		public IDisableExploreSkill? DisableExploreSkill
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDisableExploreSkill?(default(IDisableExploreSkill).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB7B RID: 52091
		// (get) Token: 0x0602FC91 RID: 195729 RVA: 0x00682088 File Offset: 0x00680288
		public bool DisableSkillWheel
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB7C RID: 52092
		// (get) Token: 0x0602FC92 RID: 195730 RVA: 0x006820C8 File Offset: 0x006802C8
		public IDisableBattleSkillOptions? DisableBattleSkill
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IDisableBattleSkillOptions?(default(IDisableBattleSkillOptions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CB7D RID: 52093
		// (get) Token: 0x0602FC93 RID: 195731 RVA: 0x00682128 File Offset: 0x00680328
		public bool DisableSwitchRole
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB7E RID: 52094
		// (get) Token: 0x0602FC94 RID: 195732 RVA: 0x00682168 File Offset: 0x00680368
		public ETeamDisplayModeInSkillOp TeamDisplayMode
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ETeamDisplayModeInSkillOp.Normal;
				}
				return (ETeamDisplayModeInSkillOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB7F RID: 52095
		// (get) Token: 0x0602FC95 RID: 195733 RVA: 0x006821A8 File Offset: 0x006803A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FC96 RID: 195734 RVA: 0x006821E8 File Offset: 0x006803E8
		public static Offset<IDisableSectionalSkillOperation> CreateIDisableSectionalSkillOperation(FlatBufferBuilder builder, ESkillOperationType Type = ESkillOperationType.Enable, EDisplayModeInSkillOp DisplayMode = EDisplayModeInSkillOp.Ashen, Offset<IDisableExploreSkill> DisableExploreSkillOffset = default(Offset<IDisableExploreSkill>), bool DisableSkillWheel = false, Offset<IDisableBattleSkillOptions> DisableBattleSkillOffset = default(Offset<IDisableBattleSkillOptions>), bool DisableSwitchRole = false, ETeamDisplayModeInSkillOp TeamDisplayMode = ETeamDisplayModeInSkillOp.Normal, byte NullMask = 0)
		{
			builder.StartTable(8);
			IDisableSectionalSkillOperation.AddDisableBattleSkill(builder, DisableBattleSkillOffset);
			IDisableSectionalSkillOperation.AddDisableExploreSkill(builder, DisableExploreSkillOffset);
			IDisableSectionalSkillOperation.AddNullMask(builder, NullMask);
			IDisableSectionalSkillOperation.AddTeamDisplayMode(builder, TeamDisplayMode);
			IDisableSectionalSkillOperation.AddDisableSwitchRole(builder, DisableSwitchRole);
			IDisableSectionalSkillOperation.AddDisableSkillWheel(builder, DisableSkillWheel);
			IDisableSectionalSkillOperation.AddDisplayMode(builder, DisplayMode);
			IDisableSectionalSkillOperation.AddType(builder, Type);
			return IDisableSectionalSkillOperation.EndIDisableSectionalSkillOperation(builder);
		}

		// Token: 0x0602FC97 RID: 195735 RVA: 0x0068223F File Offset: 0x0068043F
		public static void StartIDisableSectionalSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602FC98 RID: 195736 RVA: 0x00682248 File Offset: 0x00680448
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC99 RID: 195737 RVA: 0x00682253 File Offset: 0x00680453
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInSkillOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602FC9A RID: 195738 RVA: 0x0068225E File Offset: 0x0068045E
		public static void AddDisableExploreSkill(FlatBufferBuilder builder, Offset<IDisableExploreSkill> disableExploreSkillOffset)
		{
			builder.AddOffset(2, disableExploreSkillOffset.Value, 0);
		}

		// Token: 0x0602FC9B RID: 195739 RVA: 0x0068226E File Offset: 0x0068046E
		public static void AddDisableSkillWheel(FlatBufferBuilder builder, bool disableSkillWheel)
		{
			builder.AddBool(3, disableSkillWheel, false);
		}

		// Token: 0x0602FC9C RID: 195740 RVA: 0x00682279 File Offset: 0x00680479
		public static void AddDisableBattleSkill(FlatBufferBuilder builder, Offset<IDisableBattleSkillOptions> disableBattleSkillOffset)
		{
			builder.AddOffset(4, disableBattleSkillOffset.Value, 0);
		}

		// Token: 0x0602FC9D RID: 195741 RVA: 0x00682289 File Offset: 0x00680489
		public static void AddDisableSwitchRole(FlatBufferBuilder builder, bool disableSwitchRole)
		{
			builder.AddBool(5, disableSwitchRole, false);
		}

		// Token: 0x0602FC9E RID: 195742 RVA: 0x00682294 File Offset: 0x00680494
		public static void AddTeamDisplayMode(FlatBufferBuilder builder, ETeamDisplayModeInSkillOp teamDisplayMode)
		{
			builder.AddByte(6, (byte)teamDisplayMode, 0);
		}

		// Token: 0x0602FC9F RID: 195743 RVA: 0x0068229F File Offset: 0x0068049F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602FCA0 RID: 195744 RVA: 0x006822AA File Offset: 0x006804AA
		public static Offset<IDisableSectionalSkillOperation> EndIDisableSectionalSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSectionalSkillOperation>(builder.EndTable());
		}

		// Token: 0x0602FCA1 RID: 195745 RVA: 0x006822B8 File Offset: 0x006804B8
		public IDisableSectionalSkillOperationT UnPack()
		{
			IDisableSectionalSkillOperationT disableSectionalSkillOperationT = new IDisableSectionalSkillOperationT();
			this.UnPackTo(disableSectionalSkillOperationT);
			return disableSectionalSkillOperationT;
		}

		// Token: 0x0602FCA2 RID: 195746 RVA: 0x006822D4 File Offset: 0x006804D4
		public void UnPackTo(IDisableSectionalSkillOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.DisableExploreSkill = ((this.DisableExploreSkill != null) ? this.DisableExploreSkill.Value.UnPack() : null);
			_o.DisableSkillWheel = this.DisableSkillWheel;
			_o.DisableBattleSkill = ((this.DisableBattleSkill != null) ? this.DisableBattleSkill.Value.UnPack() : null);
			_o.DisableSwitchRole = this.DisableSwitchRole;
			_o.TeamDisplayMode = this.TeamDisplayMode;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FCA3 RID: 195747 RVA: 0x00682388 File Offset: 0x00680588
		public static Offset<IDisableSectionalSkillOperation> Pack(FlatBufferBuilder builder, IDisableSectionalSkillOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableSectionalSkillOperation>);
			}
			Offset<IDisableExploreSkill> disableExploreSkillOffset = (_o.DisableExploreSkill == null) ? default(Offset<IDisableExploreSkill>) : IDisableExploreSkill.Pack(builder, _o.DisableExploreSkill);
			Offset<IDisableBattleSkillOptions> disableBattleSkillOffset = (_o.DisableBattleSkill == null) ? default(Offset<IDisableBattleSkillOptions>) : IDisableBattleSkillOptions.Pack(builder, _o.DisableBattleSkill);
			return IDisableSectionalSkillOperation.CreateIDisableSectionalSkillOperation(builder, _o.Type, _o.DisplayMode, disableExploreSkillOffset, _o.DisableSkillWheel, disableBattleSkillOffset, _o.DisableSwitchRole, _o.TeamDisplayMode, _o.NullMask);
		}

		// Token: 0x04011A88 RID: 72328
		private Table __p;
	}
}
