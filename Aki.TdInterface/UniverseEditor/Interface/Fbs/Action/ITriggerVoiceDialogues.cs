using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007490 RID: 29840
	public struct ITriggerVoiceDialogues : IFlatbufferObject
	{
		// Token: 0x1700E283 RID: 57987
		// (get) Token: 0x060363A4 RID: 222116 RVA: 0x0075F379 File Offset: 0x0075D579
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060363A5 RID: 222117 RVA: 0x0075F386 File Offset: 0x0075D586
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060363A6 RID: 222118 RVA: 0x0075F390 File Offset: 0x0075D590
		public static ITriggerVoiceDialogues GetRootAsITriggerVoiceDialogues(ByteBuffer _bb)
		{
			return ITriggerVoiceDialogues.GetRootAsITriggerVoiceDialogues(_bb, default(ITriggerVoiceDialogues));
		}

		// Token: 0x060363A7 RID: 222119 RVA: 0x0075F3AC File Offset: 0x0075D5AC
		public static ITriggerVoiceDialogues GetRootAsITriggerVoiceDialogues(ByteBuffer _bb, ITriggerVoiceDialogues obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060363A8 RID: 222120 RVA: 0x0075F3C9 File Offset: 0x0075D5C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060363A9 RID: 222121 RVA: 0x0075F3D8 File Offset: 0x0075D5D8
		public ITriggerVoiceDialogues __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E284 RID: 57988
		// (get) Token: 0x060363AA RID: 222122 RVA: 0x0075F3E8 File Offset: 0x0075D5E8
		public EInteractEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return (EInteractEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E285 RID: 57989
		// (get) Token: 0x060363AB RID: 222123 RVA: 0x0075F424 File Offset: 0x0075D624
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E286 RID: 57990
		// (get) Token: 0x060363AC RID: 222124 RVA: 0x0075F464 File Offset: 0x0075D664
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E287 RID: 57991
		// (get) Token: 0x060363AD RID: 222125 RVA: 0x0075F4C4 File Offset: 0x0075D6C4
		public bool ShowTalker
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E288 RID: 57992
		// (get) Token: 0x060363AE RID: 222126 RVA: 0x0075F504 File Offset: 0x0075D704
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060363AF RID: 222127 RVA: 0x0075F541 File Offset: 0x0075D741
		public static Offset<ITriggerVoiceDialogues> CreateITriggerVoiceDialogues(FlatBufferBuilder builder, EInteractEffectType Type = EInteractEffectType.ModifyTipText, float DelayTime = 0f, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), bool ShowTalker = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggerVoiceDialogues.AddFlow(builder, FlowOffset);
			ITriggerVoiceDialogues.AddDelayTime(builder, DelayTime);
			ITriggerVoiceDialogues.AddNullMask(builder, NullMask);
			ITriggerVoiceDialogues.AddShowTalker(builder, ShowTalker);
			ITriggerVoiceDialogues.AddType(builder, Type);
			return ITriggerVoiceDialogues.EndITriggerVoiceDialogues(builder);
		}

		// Token: 0x060363B0 RID: 222128 RVA: 0x0075F575 File Offset: 0x0075D775
		public static void StartITriggerVoiceDialogues(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060363B1 RID: 222129 RVA: 0x0075F57E File Offset: 0x0075D77E
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060363B2 RID: 222130 RVA: 0x0075F589 File Offset: 0x0075D789
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060363B3 RID: 222131 RVA: 0x0075F59C File Offset: 0x0075D79C
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x060363B4 RID: 222132 RVA: 0x0075F5AC File Offset: 0x0075D7AC
		public static void AddShowTalker(FlatBufferBuilder builder, bool showTalker)
		{
			builder.AddBool(3, showTalker, false);
		}

		// Token: 0x060363B5 RID: 222133 RVA: 0x0075F5B7 File Offset: 0x0075D7B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060363B6 RID: 222134 RVA: 0x0075F5C2 File Offset: 0x0075D7C2
		public static Offset<ITriggerVoiceDialogues> EndITriggerVoiceDialogues(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerVoiceDialogues>(builder.EndTable());
		}

		// Token: 0x060363B7 RID: 222135 RVA: 0x0075F5D0 File Offset: 0x0075D7D0
		public ITriggerVoiceDialoguesT UnPack()
		{
			ITriggerVoiceDialoguesT triggerVoiceDialoguesT = new ITriggerVoiceDialoguesT();
			this.UnPackTo(triggerVoiceDialoguesT);
			return triggerVoiceDialoguesT;
		}

		// Token: 0x060363B8 RID: 222136 RVA: 0x0075F5EC File Offset: 0x0075D7EC
		public void UnPackTo(ITriggerVoiceDialoguesT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.ShowTalker = this.ShowTalker;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060363B9 RID: 222137 RVA: 0x0075F658 File Offset: 0x0075D858
		public static Offset<ITriggerVoiceDialogues> Pack(FlatBufferBuilder builder, ITriggerVoiceDialoguesT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerVoiceDialogues>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return ITriggerVoiceDialogues.CreateITriggerVoiceDialogues(builder, _o.Type, _o.DelayTime, flowOffset, _o.ShowTalker, _o.NullMask);
		}

		// Token: 0x04012325 RID: 74533
		private Table __p;
	}
}
