using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E62 RID: 24162
	public struct IRenderTrajectoryConfig : IFlatbufferObject
	{
		// Token: 0x1700B22B RID: 45611
		// (get) Token: 0x06028653 RID: 165459 RVA: 0x0058601D File Offset: 0x0058421D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028654 RID: 165460 RVA: 0x0058602A File Offset: 0x0058422A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028655 RID: 165461 RVA: 0x00586034 File Offset: 0x00584234
		public static IRenderTrajectoryConfig GetRootAsIRenderTrajectoryConfig(ByteBuffer _bb)
		{
			return IRenderTrajectoryConfig.GetRootAsIRenderTrajectoryConfig(_bb, default(IRenderTrajectoryConfig));
		}

		// Token: 0x06028656 RID: 165462 RVA: 0x00586050 File Offset: 0x00584250
		public static IRenderTrajectoryConfig GetRootAsIRenderTrajectoryConfig(ByteBuffer _bb, IRenderTrajectoryConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028657 RID: 165463 RVA: 0x0058606D File Offset: 0x0058426D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028658 RID: 165464 RVA: 0x0058607C File Offset: 0x0058427C
		public IRenderTrajectoryConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B22C RID: 45612
		// (get) Token: 0x06028659 RID: 165465 RVA: 0x0058608C File Offset: 0x0058428C
		public float Time
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B22D RID: 45613
		// (get) Token: 0x0602865A RID: 165466 RVA: 0x005860CC File Offset: 0x005842CC
		public string Effect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602865B RID: 165467 RVA: 0x00586103 File Offset: 0x00584303
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602865C RID: 165468 RVA: 0x00586112 File Offset: 0x00584312
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602865D RID: 165469 RVA: 0x00586120 File Offset: 0x00584320
		public static Offset<IRenderTrajectoryConfig> CreateIRenderTrajectoryConfig(FlatBufferBuilder builder, float Time = 0f, StringOffset EffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRenderTrajectoryConfig.AddEffect(builder, EffectOffset);
			IRenderTrajectoryConfig.AddTime(builder, Time);
			return IRenderTrajectoryConfig.EndIRenderTrajectoryConfig(builder);
		}

		// Token: 0x0602865E RID: 165470 RVA: 0x0058613D File Offset: 0x0058433D
		public static void StartIRenderTrajectoryConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602865F RID: 165471 RVA: 0x00586146 File Offset: 0x00584346
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(0, time, 0.0);
		}

		// Token: 0x06028660 RID: 165472 RVA: 0x00586159 File Offset: 0x00584359
		public static void AddEffect(FlatBufferBuilder builder, StringOffset effectOffset)
		{
			builder.AddOffset(1, effectOffset.Value, 0);
		}

		// Token: 0x06028661 RID: 165473 RVA: 0x00586169 File Offset: 0x00584369
		public static Offset<IRenderTrajectoryConfig> EndIRenderTrajectoryConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRenderTrajectoryConfig>(builder.EndTable());
		}

		// Token: 0x06028662 RID: 165474 RVA: 0x00586178 File Offset: 0x00584378
		public IRenderTrajectoryConfigT UnPack()
		{
			IRenderTrajectoryConfigT renderTrajectoryConfigT = new IRenderTrajectoryConfigT();
			this.UnPackTo(renderTrajectoryConfigT);
			return renderTrajectoryConfigT;
		}

		// Token: 0x06028663 RID: 165475 RVA: 0x00586193 File Offset: 0x00584393
		public void UnPackTo(IRenderTrajectoryConfigT _o)
		{
			_o.Time = this.Time;
			_o.Effect = this.Effect;
		}

		// Token: 0x06028664 RID: 165476 RVA: 0x005861B0 File Offset: 0x005843B0
		public static Offset<IRenderTrajectoryConfig> Pack(FlatBufferBuilder builder, IRenderTrajectoryConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderTrajectoryConfig>);
			}
			StringOffset effectOffset = (_o.Effect == null) ? default(StringOffset) : builder.CreateString(_o.Effect);
			return IRenderTrajectoryConfig.CreateIRenderTrajectoryConfig(builder, _o.Time, effectOffset);
		}

		// Token: 0x0400FA74 RID: 64116
		private Table __p;
	}
}
