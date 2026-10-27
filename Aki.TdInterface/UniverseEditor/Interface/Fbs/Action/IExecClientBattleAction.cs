using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006705 RID: 26373
	public struct IExecClientBattleAction : IFlatbufferObject
	{
		// Token: 0x1700C3F3 RID: 50163
		// (get) Token: 0x0602DDDF RID: 187871 RVA: 0x00645AAD File Offset: 0x00643CAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDE0 RID: 187872 RVA: 0x00645ABA File Offset: 0x00643CBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDE1 RID: 187873 RVA: 0x00645AC4 File Offset: 0x00643CC4
		public static IExecClientBattleAction GetRootAsIExecClientBattleAction(ByteBuffer _bb)
		{
			return IExecClientBattleAction.GetRootAsIExecClientBattleAction(_bb, default(IExecClientBattleAction));
		}

		// Token: 0x0602DDE2 RID: 187874 RVA: 0x00645AE0 File Offset: 0x00643CE0
		public static IExecClientBattleAction GetRootAsIExecClientBattleAction(ByteBuffer _bb, IExecClientBattleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDE3 RID: 187875 RVA: 0x00645AFD File Offset: 0x00643CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DDE4 RID: 187876 RVA: 0x00645B0C File Offset: 0x00643D0C
		public IExecClientBattleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3F4 RID: 50164
		// (get) Token: 0x0602DDE5 RID: 187877 RVA: 0x00645B1C File Offset: 0x00643D1C
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

		// Token: 0x0602DDE6 RID: 187878 RVA: 0x00645B58 File Offset: 0x00643D58
		public TTable? ClientBattleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DDE7 RID: 187879 RVA: 0x00645B9C File Offset: 0x00643D9C
		public IAssistCharacterMoveToPoint ClientBattleOptionAsIAssistCharacterMoveToPoint()
		{
			return this.ClientBattleOption<IAssistCharacterMoveToPoint>().Value;
		}

		// Token: 0x0602DDE8 RID: 187880 RVA: 0x00645BB8 File Offset: 0x00643DB8
		public IAssistCharacterStopMoveToPoint ClientBattleOptionAsIAssistCharacterStopMoveToPoint()
		{
			return this.ClientBattleOption<IAssistCharacterStopMoveToPoint>().Value;
		}

		// Token: 0x0602DDE9 RID: 187881 RVA: 0x00645BD4 File Offset: 0x00643DD4
		public IChangeAnimalEmotionBubble ClientBattleOptionAsIChangeAnimalEmotionBubble()
		{
			return this.ClientBattleOption<IChangeAnimalEmotionBubble>().Value;
		}

		// Token: 0x0602DDEA RID: 187882 RVA: 0x00645BF0 File Offset: 0x00643DF0
		public IClientGroupAiCommunicate ClientBattleOptionAsIClientGroupAiCommunicate()
		{
			return this.ClientBattleOption<IClientGroupAiCommunicate>().Value;
		}

		// Token: 0x0602DDEB RID: 187883 RVA: 0x00645C0C File Offset: 0x00643E0C
		public IClientSendTagEventToControlCharacter ClientBattleOptionAsIClientSendTagEventToControlCharacter()
		{
			return this.ClientBattleOption<IClientSendTagEventToControlCharacter>().Value;
		}

		// Token: 0x0602DDEC RID: 187884 RVA: 0x00645C28 File Offset: 0x00643E28
		public IFollowShooterSkillSkill ClientBattleOptionAsIFollowShooterSkillSkill()
		{
			return this.ClientBattleOption<IFollowShooterSkillSkill>().Value;
		}

		// Token: 0x0602DDED RID: 187885 RVA: 0x00645C44 File Offset: 0x00643E44
		public IMonsterNpcInteract ClientBattleOptionAsIMonsterNpcInteract()
		{
			return this.ClientBattleOption<IMonsterNpcInteract>().Value;
		}

		// Token: 0x0602DDEE RID: 187886 RVA: 0x00645C60 File Offset: 0x00643E60
		public IRoboSoldierSpecialTriggerHookSkill ClientBattleOptionAsIRoboSoldierSpecialTriggerHookSkill()
		{
			return this.ClientBattleOption<IRoboSoldierSpecialTriggerHookSkill>().Value;
		}

		// Token: 0x0602DDEF RID: 187887 RVA: 0x00645C7C File Offset: 0x00643E7C
		public ITriggerHookPointSkill ClientBattleOptionAsITriggerHookPointSkill()
		{
			return this.ClientBattleOption<ITriggerHookPointSkill>().Value;
		}

		// Token: 0x0602DDF0 RID: 187888 RVA: 0x00645C98 File Offset: 0x00643E98
		public ITriggerMotorSkill ClientBattleOptionAsITriggerMotorSkill()
		{
			return this.ClientBattleOption<ITriggerMotorSkill>().Value;
		}

		// Token: 0x0602DDF1 RID: 187889 RVA: 0x00645CB3 File Offset: 0x00643EB3
		public static Offset<IExecClientBattleAction> CreateIExecClientBattleAction(FlatBufferBuilder builder, TExecClientBattleOption ClientBattleOption_type = TExecClientBattleOption.NONE, int ClientBattleOptionOffset = 0)
		{
			builder.StartTable(2);
			IExecClientBattleAction.AddClientBattleOption(builder, ClientBattleOptionOffset);
			IExecClientBattleAction.AddClientBattleOptionType(builder, ClientBattleOption_type);
			return IExecClientBattleAction.EndIExecClientBattleAction(builder);
		}

		// Token: 0x0602DDF2 RID: 187890 RVA: 0x00645CD0 File Offset: 0x00643ED0
		public static void StartIExecClientBattleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DDF3 RID: 187891 RVA: 0x00645CD9 File Offset: 0x00643ED9
		public static void AddClientBattleOptionType(FlatBufferBuilder builder, TExecClientBattleOption clientBattleOptionType)
		{
			builder.AddByte(0, (byte)clientBattleOptionType, 0);
		}

		// Token: 0x0602DDF4 RID: 187892 RVA: 0x00645CE4 File Offset: 0x00643EE4
		public static void AddClientBattleOption(FlatBufferBuilder builder, int clientBattleOptionOffset)
		{
			builder.AddOffset(1, clientBattleOptionOffset, 0);
		}

		// Token: 0x0602DDF5 RID: 187893 RVA: 0x00645CEF File Offset: 0x00643EEF
		public static Offset<IExecClientBattleAction> EndIExecClientBattleAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecClientBattleAction>(builder.EndTable());
		}

		// Token: 0x0602DDF6 RID: 187894 RVA: 0x00645CFC File Offset: 0x00643EFC
		public IExecClientBattleActionT UnPack()
		{
			IExecClientBattleActionT execClientBattleActionT = new IExecClientBattleActionT();
			this.UnPackTo(execClientBattleActionT);
			return execClientBattleActionT;
		}

		// Token: 0x0602DDF7 RID: 187895 RVA: 0x00645D18 File Offset: 0x00643F18
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

		// Token: 0x0602DDF8 RID: 187896 RVA: 0x00645FA4 File Offset: 0x006441A4
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

		// Token: 0x04010DE2 RID: 69090
		private Table __p;
	}
}
