using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765D RID: 30301
	public struct IRoboSoldierSpecialTriggerHookSkill : IFlatbufferObject
	{
		// Token: 0x1700DE7C RID: 56956
		// (get) Token: 0x06035297 RID: 217751 RVA: 0x0072307E File Offset: 0x0072127E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035298 RID: 217752 RVA: 0x0072308B File Offset: 0x0072128B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035299 RID: 217753 RVA: 0x00723094 File Offset: 0x00721294
		public static IRoboSoldierSpecialTriggerHookSkill GetRootAsIRoboSoldierSpecialTriggerHookSkill(ByteBuffer _bb)
		{
			return IRoboSoldierSpecialTriggerHookSkill.GetRootAsIRoboSoldierSpecialTriggerHookSkill(_bb, default(IRoboSoldierSpecialTriggerHookSkill));
		}

		// Token: 0x0603529A RID: 217754 RVA: 0x007230B0 File Offset: 0x007212B0
		public static IRoboSoldierSpecialTriggerHookSkill GetRootAsIRoboSoldierSpecialTriggerHookSkill(ByteBuffer _bb, IRoboSoldierSpecialTriggerHookSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603529B RID: 217755 RVA: 0x007230CD File Offset: 0x007212CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603529C RID: 217756 RVA: 0x007230DC File Offset: 0x007212DC
		public IRoboSoldierSpecialTriggerHookSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE7D RID: 56957
		// (get) Token: 0x0603529D RID: 217757 RVA: 0x007230EC File Offset: 0x007212EC
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

		// Token: 0x1700DE7E RID: 56958
		// (get) Token: 0x0603529E RID: 217758 RVA: 0x00723128 File Offset: 0x00721328
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

		// Token: 0x0603529F RID: 217759 RVA: 0x00723164 File Offset: 0x00721364
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> CreateIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int HookEntityId = 0)
		{
			builder.StartTable(2);
			IRoboSoldierSpecialTriggerHookSkill.AddHookEntityId(builder, HookEntityId);
			IRoboSoldierSpecialTriggerHookSkill.AddType(builder, Type);
			return IRoboSoldierSpecialTriggerHookSkill.EndIRoboSoldierSpecialTriggerHookSkill(builder);
		}

		// Token: 0x060352A0 RID: 217760 RVA: 0x00723181 File Offset: 0x00721381
		public static void StartIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060352A1 RID: 217761 RVA: 0x0072318A File Offset: 0x0072138A
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060352A2 RID: 217762 RVA: 0x00723195 File Offset: 0x00721395
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(1, hookEntityId, 0);
		}

		// Token: 0x060352A3 RID: 217763 RVA: 0x007231A0 File Offset: 0x007213A0
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> EndIRoboSoldierSpecialTriggerHookSkill(FlatBufferBuilder builder)
		{
			return new Offset<IRoboSoldierSpecialTriggerHookSkill>(builder.EndTable());
		}

		// Token: 0x060352A4 RID: 217764 RVA: 0x007231B0 File Offset: 0x007213B0
		public IRoboSoldierSpecialTriggerHookSkillT UnPack()
		{
			IRoboSoldierSpecialTriggerHookSkillT roboSoldierSpecialTriggerHookSkillT = new IRoboSoldierSpecialTriggerHookSkillT();
			this.UnPackTo(roboSoldierSpecialTriggerHookSkillT);
			return roboSoldierSpecialTriggerHookSkillT;
		}

		// Token: 0x060352A5 RID: 217765 RVA: 0x007231CB File Offset: 0x007213CB
		public void UnPackTo(IRoboSoldierSpecialTriggerHookSkillT _o)
		{
			_o.Type = this.Type;
			_o.HookEntityId = this.HookEntityId;
		}

		// Token: 0x060352A6 RID: 217766 RVA: 0x007231E8 File Offset: 0x007213E8
		public static Offset<IRoboSoldierSpecialTriggerHookSkill> Pack(FlatBufferBuilder builder, IRoboSoldierSpecialTriggerHookSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoboSoldierSpecialTriggerHookSkill>);
			}
			return IRoboSoldierSpecialTriggerHookSkill.CreateIRoboSoldierSpecialTriggerHookSkill(builder, _o.Type, _o.HookEntityId);
		}

		// Token: 0x04012854 RID: 75860
		private Table __p;
	}
}
