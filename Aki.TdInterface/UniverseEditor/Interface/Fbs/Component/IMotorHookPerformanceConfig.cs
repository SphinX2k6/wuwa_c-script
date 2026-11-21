using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5B RID: 23387
	public struct IMotorHookPerformanceConfig : IFlatbufferObject
	{
		// Token: 0x1700AAC0 RID: 43712
		// (get) Token: 0x060267D4 RID: 157652 RVA: 0x00545620 File Offset: 0x00543820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060267D5 RID: 157653 RVA: 0x0054562D File Offset: 0x0054382D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060267D6 RID: 157654 RVA: 0x00545634 File Offset: 0x00543834
		public static IMotorHookPerformanceConfig GetRootAsIMotorHookPerformanceConfig(ByteBuffer _bb)
		{
			return IMotorHookPerformanceConfig.GetRootAsIMotorHookPerformanceConfig(_bb, default(IMotorHookPerformanceConfig));
		}

		// Token: 0x060267D7 RID: 157655 RVA: 0x00545650 File Offset: 0x00543850
		public static IMotorHookPerformanceConfig GetRootAsIMotorHookPerformanceConfig(ByteBuffer _bb, IMotorHookPerformanceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x0054566D File Offset: 0x0054386D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060267D9 RID: 157657 RVA: 0x0054567C File Offset: 0x0054387C
		public IMotorHookPerformanceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAC1 RID: 43713
		// (get) Token: 0x060267DA RID: 157658 RVA: 0x0054568C File Offset: 0x0054388C
		public long HookEffectBuffId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAC2 RID: 43714
		// (get) Token: 0x060267DB RID: 157659 RVA: 0x005456CC File Offset: 0x005438CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060267DC RID: 157660 RVA: 0x00545708 File Offset: 0x00543908
		public static Offset<IMotorHookPerformanceConfig> CreateIMotorHookPerformanceConfig(FlatBufferBuilder builder, long HookEffectBuffId = 0L, byte NullMask = 0)
		{
			builder.StartTable(2);
			IMotorHookPerformanceConfig.AddHookEffectBuffId(builder, HookEffectBuffId);
			IMotorHookPerformanceConfig.AddNullMask(builder, NullMask);
			return IMotorHookPerformanceConfig.EndIMotorHookPerformanceConfig(builder);
		}

		// Token: 0x060267DD RID: 157661 RVA: 0x00545725 File Offset: 0x00543925
		public static void StartIMotorHookPerformanceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060267DE RID: 157662 RVA: 0x0054572E File Offset: 0x0054392E
		public static void AddHookEffectBuffId(FlatBufferBuilder builder, long hookEffectBuffId)
		{
			builder.AddLong(0, hookEffectBuffId, 0L);
		}

		// Token: 0x060267DF RID: 157663 RVA: 0x0054573A File Offset: 0x0054393A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060267E0 RID: 157664 RVA: 0x00545745 File Offset: 0x00543945
		public static Offset<IMotorHookPerformanceConfig> EndIMotorHookPerformanceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookPerformanceConfig>(builder.EndTable());
		}

		// Token: 0x060267E1 RID: 157665 RVA: 0x00545754 File Offset: 0x00543954
		public IMotorHookPerformanceConfigT UnPack()
		{
			IMotorHookPerformanceConfigT motorHookPerformanceConfigT = new IMotorHookPerformanceConfigT();
			this.UnPackTo(motorHookPerformanceConfigT);
			return motorHookPerformanceConfigT;
		}

		// Token: 0x060267E2 RID: 157666 RVA: 0x0054576F File Offset: 0x0054396F
		public void UnPackTo(IMotorHookPerformanceConfigT _o)
		{
			_o.HookEffectBuffId = this.HookEffectBuffId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060267E3 RID: 157667 RVA: 0x0054578C File Offset: 0x0054398C
		public static Offset<IMotorHookPerformanceConfig> Pack(FlatBufferBuilder builder, IMotorHookPerformanceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookPerformanceConfig>);
			}
			return IMotorHookPerformanceConfig.CreateIMotorHookPerformanceConfig(builder, _o.HookEffectBuffId, _o.NullMask);
		}

		// Token: 0x0400F566 RID: 62822
		private Table __p;
	}
}
