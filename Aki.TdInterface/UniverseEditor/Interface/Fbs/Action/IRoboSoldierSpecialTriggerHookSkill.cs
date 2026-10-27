using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED9 RID: 28377
	public struct IRoboSoldierSpecialTriggerHookSkill : IFlatbufferObject
	{
		// Token: 0x1700D325 RID: 54053
		// (get) Token: 0x06032257 RID: 205399 RVA: 0x006C734A File Offset: 0x006C554A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032258 RID: 205400 RVA: 0x006C7357 File Offset: 0x006C5557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032259 RID: 205401 RVA: 0x006C7360 File Offset: 0x006C5560
		public static IRoboSoldierSpecialTriggerHookSkill GetRootAsIRoboSoldierSpecialTriggerHookSkill(ByteBuffer _bb)
		{
			return IRoboSoldierSpecialTriggerHookSkill.GetRootAsIRoboSoldierSpecialTriggerHookSkill(_bb, default(IRoboSoldierSpecialTriggerHookSkill));
		}

		// Token: 0x0603225A RID: 205402 RVA: 0x006C737C File Offset: 0x006C557C
		public static IRoboSoldierSpecialTriggerHookSkill GetRootAsIRoboSoldierSpecialTriggerHookSkill(ByteBuffer _bb, IRoboSoldierSpecialTriggerHookSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603225B RID: 205403 RVA: 0x006C7399 File Offset: 0x006C5599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603225C RID: 205404 RVA: 0x006C73A8 File Offset: 0x006C55A8
		public IRoboSoldierSpecialTriggerHookSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D326 RID: 54054
		// (get) Token: 0x0603225D RID: 205405 RVA: 0x006C73B8 File Offset: 0x006C55B8
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D327 RID: 54055
		// (get) Token: 0x0603225E RID: 205406 RVA: 0x006C73F4 File Offset: 0x006C55F4
		public int HookEntityId
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

		// Token: 0x0603225F RID: 205407 RVA: 0x006C7430 File Offset: 0x006C5630
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> CreateIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int HookEntityId = 0)
		{
			builder.StartTable(2);
			IRoboSoldierSpecialTriggerHookSkill.AddHookEntityId(builder, HookEntityId);
			IRoboSoldierSpecialTriggerHookSkill.AddType(builder, Type);
			return IRoboSoldierSpecialTriggerHookSkill.EndIRoboSoldierSpecialTriggerHookSkill(builder);
		}

		// Token: 0x06032260 RID: 205408 RVA: 0x006C744D File Offset: 0x006C564D
		public static void StartIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032261 RID: 205409 RVA: 0x006C7456 File Offset: 0x006C5656
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032262 RID: 205410 RVA: 0x006C7461 File Offset: 0x006C5661
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(1, hookEntityId, 0);
		}

		// Token: 0x06032263 RID: 205411 RVA: 0x006C746C File Offset: 0x006C566C
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> EndIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder)
		{
			return new Offset<IRoboSoldierSpecialTriggerHookSkill>(builder.EndTable());
		}

		// Token: 0x06032264 RID: 205412 RVA: 0x006C747C File Offset: 0x006C567C
		public IRoboSoldierSpecialTriggerHookSkillT UnPack()
		{
			IRoboSoldierSpecialTriggerHookSkillT roboSoldierSpecialTriggerHookSkillT = new IRoboSoldierSpecialTriggerHookSkillT();
			this.UnPackTo(roboSoldierSpecialTriggerHookSkillT);
			return roboSoldierSpecialTriggerHookSkillT;
		}

		// Token: 0x06032265 RID: 205413 RVA: 0x006C7497 File Offset: 0x006C5697
		public void UnPackTo(IRoboSoldierSpecialTriggerHookSkillT _o)
		{
			_o.Type = this.Type;
			_o.HookEntityId = this.HookEntityId;
		}

		// Token: 0x06032266 RID: 205414 RVA: 0x006C74B4 File Offset: 0x006C56B4
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> Pack(FlatBufferBuilder builder, IRoboSoldierSpecialTriggerHookSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoboSoldierSpecialTriggerHookSkill>);
			}
			return IRoboSoldierSpecialTriggerHookSkill.CreateIRoboSoldierSpecialTriggerHookSkill(builder, _o.Type, _o.HookEntityId);
		}

		// Token: 0x040118CF RID: 71887
		private Table __p;
	}
}
