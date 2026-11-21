using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AA6 RID: 31398
	public struct ITalkItemAvgRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700E782 RID: 59266
		// (get) Token: 0x06037AED RID: 228077 RVA: 0x0077651F File Offset: 0x0077471F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037AEE RID: 228078 RVA: 0x0077652C File Offset: 0x0077472C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037AEF RID: 228079 RVA: 0x00776534 File Offset: 0x00774734
		public static ITalkItemAvgRoleConfig GetRootAsITalkItemAvgRoleConfig(ByteBuffer _bb)
		{
			return ITalkItemAvgRoleConfig.GetRootAsITalkItemAvgRoleConfig(_bb, default(ITalkItemAvgRoleConfig));
		}

		// Token: 0x06037AF0 RID: 228080 RVA: 0x00776550 File Offset: 0x00774750
		public static ITalkItemAvgRoleConfig GetRootAsITalkItemAvgRoleConfig(ByteBuffer _bb, ITalkItemAvgRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037AF1 RID: 228081 RVA: 0x0077656D File Offset: 0x0077476D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037AF2 RID: 228082 RVA: 0x0077657C File Offset: 0x0077477C
		public ITalkItemAvgRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E783 RID: 59267
		// (get) Token: 0x06037AF3 RID: 228083 RVA: 0x0077658C File Offset: 0x0077478C
		public EAvgVisualEffect VisualEffect
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAvgVisualEffect.Default;
				}
				return (EAvgVisualEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E784 RID: 59268
		// (get) Token: 0x06037AF4 RID: 228084 RVA: 0x007765C8 File Offset: 0x007747C8
		public EAvgRoleAnimationType AnimationType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return (EAvgRoleAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E785 RID: 59269
		// (get) Token: 0x06037AF5 RID: 228085 RVA: 0x00776604 File Offset: 0x00774804
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E786 RID: 59270
		// (get) Token: 0x06037AF6 RID: 228086 RVA: 0x00776644 File Offset: 0x00774844
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037AF7 RID: 228087 RVA: 0x00776681 File Offset: 0x00774881
		public static Offset<ITalkItemAvgRoleConfig> CreateITalkItemAvgRoleConfig(FlatBufferBuilder builder, EAvgVisualEffect VisualEffect = EAvgVisualEffect.Default, EAvgRoleAnimationType AnimationType = EAvgRoleAnimationType.Idle, bool IsAnimationLoop = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkItemAvgRoleConfig.AddNullMask(builder, NullMask);
			ITalkItemAvgRoleConfig.AddIsAnimationLoop(builder, IsAnimationLoop);
			ITalkItemAvgRoleConfig.AddAnimationType(builder, AnimationType);
			ITalkItemAvgRoleConfig.AddVisualEffect(builder, VisualEffect);
			return ITalkItemAvgRoleConfig.EndITalkItemAvgRoleConfig(builder);
		}

		// Token: 0x06037AF8 RID: 228088 RVA: 0x007766AD File Offset: 0x007748AD
		public static void StartITalkItemAvgRoleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06037AF9 RID: 228089 RVA: 0x007766B6 File Offset: 0x007748B6
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(0, (byte)visualEffect, 0);
		}

		// Token: 0x06037AFA RID: 228090 RVA: 0x007766C1 File Offset: 0x007748C1
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(1, (byte)animationType, 0);
		}

		// Token: 0x06037AFB RID: 228091 RVA: 0x007766CC File Offset: 0x007748CC
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(2, isAnimationLoop, false);
		}

		// Token: 0x06037AFC RID: 228092 RVA: 0x007766D7 File Offset: 0x007748D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06037AFD RID: 228093 RVA: 0x007766E2 File Offset: 0x007748E2
		public static Offset<ITalkItemAvgRoleConfig> EndITalkItemAvgRoleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemAvgRoleConfig>(builder.EndTable());
		}

		// Token: 0x06037AFE RID: 228094 RVA: 0x007766F0 File Offset: 0x007748F0
		public ITalkItemAvgRoleConfigT UnPack()
		{
			ITalkItemAvgRoleConfigT talkItemAvgRoleConfigT = new ITalkItemAvgRoleConfigT();
			this.UnPackTo(talkItemAvgRoleConfigT);
			return talkItemAvgRoleConfigT;
		}

		// Token: 0x06037AFF RID: 228095 RVA: 0x0077670B File Offset: 0x0077490B
		public void UnPackTo(ITalkItemAvgRoleConfigT _o)
		{
			_o.VisualEffect = this.VisualEffect;
			_o.AnimationType = this.AnimationType;
			_o.IsAnimationLoop = this.IsAnimationLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06037B00 RID: 228096 RVA: 0x00776740 File Offset: 0x00774940
		public static Offset<ITalkItemAvgRoleConfig> Pack(FlatBufferBuilder builder, ITalkItemAvgRoleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemAvgRoleConfig>);
			}
			return ITalkItemAvgRoleConfig.CreateITalkItemAvgRoleConfig(builder, _o.VisualEffect, _o.AnimationType, _o.IsAnimationLoop, _o.NullMask);
		}

		// Token: 0x04012EB9 RID: 77497
		private Table __p;
	}
}
