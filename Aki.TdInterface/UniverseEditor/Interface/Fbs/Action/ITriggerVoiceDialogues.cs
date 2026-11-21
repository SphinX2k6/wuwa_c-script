using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C83 RID: 31875
	public struct ITriggerVoiceDialogues : IFlatbufferObject
	{
		// Token: 0x1700EEA2 RID: 61090
		// (get) Token: 0x06039791 RID: 235409 RVA: 0x007C2135 File Offset: 0x007C0335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039792 RID: 235410 RVA: 0x007C2142 File Offset: 0x007C0342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039793 RID: 235411 RVA: 0x007C214C File Offset: 0x007C034C
		public static ITriggerVoiceDialogues GetRootAsITriggerVoiceDialogues(ByteBuffer _bb)
		{
			return ITriggerVoiceDialogues.GetRootAsITriggerVoiceDialogues(_bb, default(ITriggerVoiceDialogues));
		}

		// Token: 0x06039794 RID: 235412 RVA: 0x007C2168 File Offset: 0x007C0368
		public static ITriggerVoiceDialogues GetRootAsITriggerVoiceDialogues(ByteBuffer _bb, ITriggerVoiceDialogues obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039795 RID: 235413 RVA: 0x007C2185 File Offset: 0x007C0385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039796 RID: 235414 RVA: 0x007C2194 File Offset: 0x007C0394
		public ITriggerVoiceDialogues __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EEA3 RID: 61091
		// (get) Token: 0x06039797 RID: 235415 RVA: 0x007C21A4 File Offset: 0x007C03A4
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

		// Token: 0x1700EEA4 RID: 61092
		// (get) Token: 0x06039798 RID: 235416 RVA: 0x007C21E0 File Offset: 0x007C03E0
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

		// Token: 0x1700EEA5 RID: 61093
		// (get) Token: 0x06039799 RID: 235417 RVA: 0x007C2220 File Offset: 0x007C0420
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

		// Token: 0x1700EEA6 RID: 61094
		// (get) Token: 0x0603979A RID: 235418 RVA: 0x007C2280 File Offset: 0x007C0480
		public bool ShowTalker
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EEA7 RID: 61095
		// (get) Token: 0x0603979B RID: 235419 RVA: 0x007C22C0 File Offset: 0x007C04C0
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

		// Token: 0x0603979C RID: 235420 RVA: 0x007C22FD File Offset: 0x007C04FD
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

		// Token: 0x0603979D RID: 235421 RVA: 0x007C2331 File Offset: 0x007C0531
		public static void StartITriggerVoiceDialogues(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603979E RID: 235422 RVA: 0x007C233A File Offset: 0x007C053A
		public static void AddType(FlatBufferBuilder builder, EInteractEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603979F RID: 235423 RVA: 0x007C2345 File Offset: 0x007C0545
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x060397A0 RID: 235424 RVA: 0x007C2358 File Offset: 0x007C0558
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x060397A1 RID: 235425 RVA: 0x007C2368 File Offset: 0x007C0568
		public static void AddShowTalker(FlatBufferBuilder builder, bool showTalker)
		{
			builder.AddBool(3, showTalker, false);
		}

		// Token: 0x060397A2 RID: 235426 RVA: 0x007C2373 File Offset: 0x007C0573
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060397A3 RID: 235427 RVA: 0x007C237E File Offset: 0x007C057E
		public static Offset<ITriggerVoiceDialogues> EndITriggerVoiceDialogues(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerVoiceDialogues>(builder.EndTable());
		}

		// Token: 0x060397A4 RID: 235428 RVA: 0x007C238C File Offset: 0x007C058C
		public ITriggerVoiceDialoguesT UnPack()
		{
			ITriggerVoiceDialoguesT triggerVoiceDialoguesT = new ITriggerVoiceDialoguesT();
			this.UnPackTo(triggerVoiceDialoguesT);
			return triggerVoiceDialoguesT;
		}

		// Token: 0x060397A5 RID: 235429 RVA: 0x007C23A8 File Offset: 0x007C05A8
		public void UnPackTo(ITriggerVoiceDialoguesT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.ShowTalker = this.ShowTalker;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060397A6 RID: 235430 RVA: 0x007C2414 File Offset: 0x007C0614
		public static Offset<ITriggerVoiceDialogues> Pack(FlatBufferBuilder builder, ITriggerVoiceDialoguesT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerVoiceDialogues>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return ITriggerVoiceDialogues.CreateITriggerVoiceDialogues(builder, _o.Type, _o.DelayTime, flowOffset, _o.ShowTalker, _o.NullMask);
		}

		// Token: 0x0401334D RID: 78669
		private Table __p;
	}
}
