using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D85 RID: 28037
	public struct IExecClientBattleAction : IFlatbufferObject
	{
		// Token: 0x1700CDA9 RID: 52649
		// (get) Token: 0x06030622 RID: 198178 RVA: 0x00693155 File Offset: 0x00691355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030623 RID: 198179 RVA: 0x00693162 File Offset: 0x00691362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030624 RID: 198180 RVA: 0x0069316C File Offset: 0x0069136C
		public static IExecClientBattleAction GetRootAsIExecClientBattleAction(ByteBuffer _bb)
		{
			return IExecClientBattleAction.GetRootAsIExecClientBattleAction(_bb, default(IExecClientBattleAction));
		}

		// Token: 0x06030625 RID: 198181 RVA: 0x00693188 File Offset: 0x00691388
		public static IExecClientBattleAction GetRootAsIExecClientBattleAction(ByteBuffer _bb, IExecClientBattleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030626 RID: 198182 RVA: 0x006931A5 File Offset: 0x006913A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030627 RID: 198183 RVA: 0x006931B4 File Offset: 0x006913B4
		public IExecClientBattleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDAA RID: 52650
		// (get) Token: 0x06030628 RID: 198184 RVA: 0x006931C4 File Offset: 0x006913C4
		public TExecClientBattleOption ClientBattleOptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TExecClientBattleOption.NONE;
				}
				return (TExecClientBattleOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030629 RID: 198185 RVA: 0x00693200 File Offset: 0x00691400
		public TTable? ClientBattleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603062A RID: 198186 RVA: 0x00693244 File Offset: 0x00691444
		public IAssistCharacterMoveToPoint ClientBattleOptionAsIAssistCharacterMoveToPoint()
		{
			return this.ClientBattleOption<IAssistCharacterMoveToPoint>().Value;
		}

		// Token: 0x0603062B RID: 198187 RVA: 0x00693260 File Offset: 0x00691460
		public IAssistCharacterStopMoveToPoint ClientBattleOptionAsIAssistCharacterStopMoveToPoint()
		{
			return this.ClientBattleOption<IAssistCharacterStopMoveToPoint>().Value;
		}

		// Token: 0x0603062C RID: 198188 RVA: 0x0069327C File Offset: 0x0069147C
		public IChangeAnimalEmotionBubble ClientBattleOptionAsIChangeAnimalEmotionBubble()
		{
			return this.ClientBattleOption<IChangeAnimalEmotionBubble>().Value;
		}

		// Token: 0x0603062D RID: 198189 RVA: 0x00693298 File Offset: 0x00691498
		public IClientGroupAiCommunicate ClientBattleOptionAsIClientGroupAiCommunicate()
		{
			return this.ClientBattleOption<IClientGroupAiCommunicate>().Value;
		}

		// Token: 0x0603062E RID: 198190 RVA: 0x006932B4 File Offset: 0x006914B4
		public IClientSendTagEventToControlCharacter ClientBattleOptionAsIClientSendTagEventToControlCharacter()
		{
			return this.ClientBattleOption<IClientSendTagEventToControlCharacter>().Value;
		}

		// Token: 0x0603062F RID: 198191 RVA: 0x006932D0 File Offset: 0x006914D0
		public IFollowShooterSkillSkill ClientBattleOptionAsIFollowShooterSkillSkill()
		{
			return this.ClientBattleOption<IFollowShooterSkillSkill>().Value;
		}

		// Token: 0x06030630 RID: 198192 RVA: 0x006932EC File Offset: 0x006914EC
		public IMechExecute ClientBattleOptionAsIMechExecute()
		{
			return this.ClientBattleOption<IMechExecute>().Value;
		}

		// Token: 0x06030631 RID: 198193 RVA: 0x00693308 File Offset: 0x00691508
		public IMonsterNpcInteract ClientBattleOptionAsIMonsterNpcInteract()
		{
			return this.ClientBattleOption<IMonsterNpcInteract>().Value;
		}

		// Token: 0x06030632 RID: 198194 RVA: 0x00693324 File Offset: 0x00691524
		public IRoboSoldierSpecialTriggerHookSkill ClientBattleOptionAsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.ClientBattleOption<IRoboSoldierSpecialTriggerHookSkill>().Value;
		}

		// Token: 0x06030633 RID: 198195 RVA: 0x00693340 File Offset: 0x00691540
		public ITriggerHookPointSkill ClientBattleOptionAsITriggerHookPointSkill()
		{
			return this.ClientBattleOption<ITriggerHookPointSkill>().Value;
		}

		// Token: 0x06030634 RID: 198196 RVA: 0x0069335C File Offset: 0x0069155C
		public ITriggerMotorSkill ClientBattleOptionAsITriggerMotorSkill()
		{
			return this.ClientBattleOption<ITriggerMotorSkill>().Value;
		}

		// Token: 0x06030635 RID: 198197 RVA: 0x00693377 File Offset: 0x00691577
		public static Offset<IExecClientBattleAction> CreateIExecClientBattleAction(FlatBufferBuilder builder, TExecClientBattleOption ClientBattleOption_type = TExecClientBattleOption.NONE, int ClientBattleOptionOffset = 0)
		{
			builder.StartTable(2);
			IExecClientBattleAction.AddClientBattleOption(builder, ClientBattleOptionOffset);
			IExecClientBattleAction.AddClientBattleOptionType(builder, ClientBattleOption_type);
			return IExecClientBattleAction.EndIExecClientBattleAction(builder);
		}

		// Token: 0x06030636 RID: 198198 RVA: 0x00693394 File Offset: 0x00691594
		public static void StartIExecClientBattleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030637 RID: 198199 RVA: 0x0069339D File Offset: 0x0069159D
		public static void AddClientBattleOptionType(FlatBufferBuilder builder, TExecClientBattleOption clientBattleOptionType)
		{
			builder.AddByte(0, (byte)clientBattleOptionType, 0);
		}

		// Token: 0x06030638 RID: 198200 RVA: 0x006933A8 File Offset: 0x006915A8
		public static void AddClientBattleOption(FlatBufferBuilder builder, int clientBattleOptionOffset)
		{
			builder.AddOffset(1, clientBattleOptionOffset, 0);
		}

		// Token: 0x06030639 RID: 198201 RVA: 0x006933B3 File Offset: 0x006915B3
		public static Offset<IExecClientBattleAction> EndIExecClientBattleAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientBattleAction>(builder.EndTable());
		}

		// Token: 0x0603063A RID: 198202 RVA: 0x006933C0 File Offset: 0x006915C0
		public IExecClientBattleActionT UnPack()
		{
			IExecClientBattleActionT execClientBattleActionT = new IExecClientBattleActionT();
			this.UnPackTo(execClientBattleActionT);
			return execClientBattleActionT;
		}

		// Token: 0x0603063B RID: 198203 RVA: 0x006933DC File Offset: 0x006915DC
		public void UnPackTo(IExecClientBattleActionT _o)
		{
			_o.ClientBattleOption = new TExecClientBattleOptionUnion();
			_o.ClientBattleOption.Type = this.ClientBattleOptionType;
			switch (this.ClientBattleOptionType)
			{
			case TExecClientBattleOption.IAssistCharacterMoveToPoint:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IAssistCharacterMoveToPoint>() != null) ? this.ClientBattleOption<IAssistCharacterMoveToPoint>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IAssistCharacterStopMoveToPoint:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IAssistCharacterStopMoveToPoint>() != null) ? this.ClientBattleOption<IAssistCharacterStopMoveToPoint>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IChangeAnimalEmotionBubble:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IChangeAnimalEmotionBubble>() != null) ? this.ClientBattleOption<IChangeAnimalEmotionBubble>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IClientGroupAiCommunicate:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IClientGroupAiCommunicate>() != null) ? this.ClientBattleOption<IClientGroupAiCommunicate>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IClientSendTagEventToControlCharacter:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IClientSendTagEventToControlCharacter>() != null) ? this.ClientBattleOption<IClientSendTagEventToControlCharacter>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IFollowShooterSkillSkill:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IFollowShooterSkillSkill>() != null) ? this.ClientBattleOption<IFollowShooterSkillSkill>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IMechExecute:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IMechExecute>() != null) ? this.ClientBattleOption<IMechExecute>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IMonsterNpcInteract:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IMonsterNpcInteract>() != null) ? this.ClientBattleOption<IMonsterNpcInteract>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.IRoboSoldierSpecialTriggerHookSkill:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<IRoboSoldierSpecialTriggerHookSkill>() != null) ? this.ClientBattleOption<IRoboSoldierSpecialTriggerHookSkill>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.ITriggerHookPointSkill:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<ITriggerHookPointSkill>() != null) ? this.ClientBattleOption<ITriggerHookPointSkill>().Value.UnPack() : null);
				return;
			case TExecClientBattleOption.ITriggerMotorSkill:
				_o.ClientBattleOption.Value = ((this.ClientBattleOption<ITriggerMotorSkill>() != null) ? this.ClientBattleOption<ITriggerMotorSkill>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603063C RID: 198204 RVA: 0x006936A4 File Offset: 0x006918A4
		public static Offset<IExecClientBattleAction> Pack(FlatBufferBuilder builder, IExecClientBattleActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecClientBattleAction>);
			}
			TExecClientBattleOption clientBattleOption_type = (_o.ClientBattleOption == null) ? TExecClientBattleOption.NONE : _o.ClientBattleOption.Type;
			int clientBattleOptionOffset = (_o.ClientBattleOption == null) ? 0 : TExecClientBattleOptionUnion.Pack(builder, _o.ClientBattleOption);
			return IExecClientBattleAction.CreateIExecClientBattleAction(builder, clientBattleOption_type, clientBattleOptionOffset);
		}

		// Token: 0x04011C13 RID: 72723
		private Table __p;
	}
}
