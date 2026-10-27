using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065F1 RID: 26097
	public struct IDisableSectionalSkillOperation : IFlatbufferObject
	{
		// Token: 0x1700C1D9 RID: 49625
		// (get) Token: 0x0602D4B7 RID: 185527 RVA: 0x006353D9 File Offset: 0x006335D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D4B8 RID: 185528 RVA: 0x006353E6 File Offset: 0x006335E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D4B9 RID: 185529 RVA: 0x006353F0 File Offset: 0x006335F0
		public static IDisableSectionalSkillOperation GetRootAsIDisableSectionalSkillOperation(ByteBuffer _bb)
		{
			return IDisableSectionalSkillOperation.GetRootAsIDisableSectionalSkillOperation(_bb, default(IDisableSectionalSkillOperation));
		}

		// Token: 0x0602D4BA RID: 185530 RVA: 0x0063540C File Offset: 0x0063360C
		public static IDisableSectionalSkillOperation GetRootAsIDisableSectionalSkillOperation(ByteBuffer _bb, IDisableSectionalSkillOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D4BB RID: 185531 RVA: 0x00635429 File Offset: 0x00633629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D4BC RID: 185532 RVA: 0x00635438 File Offset: 0x00633638
		public IDisableSectionalSkillOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1DA RID: 49626
		// (get) Token: 0x0602D4BD RID: 185533 RVA: 0x00635448 File Offset: 0x00633648
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

		// Token: 0x1700C1DB RID: 49627
		// (get) Token: 0x0602D4BE RID: 185534 RVA: 0x00635484 File Offset: 0x00633684
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

		// Token: 0x1700C1DC RID: 49628
		// (get) Token: 0x0602D4BF RID: 185535 RVA: 0x006354C0 File Offset: 0x006336C0
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

		// Token: 0x1700C1DD RID: 49629
		// (get) Token: 0x0602D4C0 RID: 185536 RVA: 0x00635520 File Offset: 0x00633720
		public bool DisableSkillWheel
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1DE RID: 49630
		// (get) Token: 0x0602D4C1 RID: 185537 RVA: 0x00635560 File Offset: 0x00633760
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

		// Token: 0x1700C1DF RID: 49631
		// (get) Token: 0x0602D4C2 RID: 185538 RVA: 0x006355C0 File Offset: 0x006337C0
		public bool DisableSwitchRole
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1E0 RID: 49632
		// (get) Token: 0x0602D4C3 RID: 185539 RVA: 0x00635600 File Offset: 0x00633800
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

		// Token: 0x1700C1E1 RID: 49633
		// (get) Token: 0x0602D4C4 RID: 185540 RVA: 0x00635640 File Offset: 0x00633840
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

		// Token: 0x0602D4C5 RID: 185541 RVA: 0x00635680 File Offset: 0x00633880
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

		// Token: 0x0602D4C6 RID: 185542 RVA: 0x006356D7 File Offset: 0x006338D7
		public static void StartIDisableSectionalSkillOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602D4C7 RID: 185543 RVA: 0x006356E0 File Offset: 0x006338E0
		public static void AddType(FlatBufferBuilder builder, ESkillOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D4C8 RID: 185544 RVA: 0x006356EB File Offset: 0x006338EB
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInSkillOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602D4C9 RID: 185545 RVA: 0x006356F6 File Offset: 0x006338F6
		public static void AddDisableExploreSkill(FlatBufferBuilder builder, Offset<IDisableExploreSkill> disableExploreSkillOffset)
		{
			builder.AddOffset(2, disableExploreSkillOffset.Value, 0);
		}

		// Token: 0x0602D4CA RID: 185546 RVA: 0x00635706 File Offset: 0x00633906
		public static void AddDisableSkillWheel(FlatBufferBuilder builder, bool disableSkillWheel)
		{
			builder.AddBool(3, disableSkillWheel, false);
		}

		// Token: 0x0602D4CB RID: 185547 RVA: 0x00635711 File Offset: 0x00633911
		public static void AddDisableBattleSkill(FlatBufferBuilder builder, Offset<IDisableBattleSkillOptions> disableBattleSkillOffset)
		{
			builder.AddOffset(4, disableBattleSkillOffset.Value, 0);
		}

		// Token: 0x0602D4CC RID: 185548 RVA: 0x00635721 File Offset: 0x00633921
		public static void AddDisableSwitchRole(FlatBufferBuilder builder, bool disableSwitchRole)
		{
			builder.AddBool(5, disableSwitchRole, false);
		}

		// Token: 0x0602D4CD RID: 185549 RVA: 0x0063572C File Offset: 0x0063392C
		public static void AddTeamDisplayMode(FlatBufferBuilder builder, ETeamDisplayModeInSkillOp teamDisplayMode)
		{
			builder.AddByte(6, (byte)teamDisplayMode, 0);
		}

		// Token: 0x0602D4CE RID: 185550 RVA: 0x00635737 File Offset: 0x00633937
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602D4CF RID: 185551 RVA: 0x00635742 File Offset: 0x00633942
		public static Offset<IDisableSectionalSkillOperation> EndIDisableSectionalSkillOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSectionalSkillOperation>(builder.EndTable());
		}

		// Token: 0x0602D4D0 RID: 185552 RVA: 0x00635750 File Offset: 0x00633950
		public IDisableSectionalSkillOperationT UnPack()
		{
			IDisableSectionalSkillOperationT disableSectionalSkillOperationT = new IDisableSectionalSkillOperationT();
			this.UnPackTo(disableSectionalSkillOperationT);
			return disableSectionalSkillOperationT;
		}

		// Token: 0x0602D4D1 RID: 185553 RVA: 0x0063576C File Offset: 0x0063396C
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

		// Token: 0x0602D4D2 RID: 185554 RVA: 0x00635820 File Offset: 0x00633A20
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

		// Token: 0x04010C6D RID: 68717
		private Table __p;
	}
}
