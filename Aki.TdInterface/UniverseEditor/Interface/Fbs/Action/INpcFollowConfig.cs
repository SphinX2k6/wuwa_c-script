using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007301 RID: 29441
	public struct INpcFollowConfig : IFlatbufferObject
	{
		// Token: 0x1700D7DE RID: 55262
		// (get) Token: 0x0603357D RID: 210301 RVA: 0x006EC9C0 File Offset: 0x006EABC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603357E RID: 210302 RVA: 0x006EC9CD File Offset: 0x006EABCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603357F RID: 210303 RVA: 0x006EC9D4 File Offset: 0x006EABD4
		public static INpcFollowConfig GetRootAsINpcFollowConfig(ByteBuffer _bb)
		{
			return INpcFollowConfig.GetRootAsINpcFollowConfig(_bb, default(INpcFollowConfig));
		}

		// Token: 0x06033580 RID: 210304 RVA: 0x006EC9F0 File Offset: 0x006EABF0
		public static INpcFollowConfig GetRootAsINpcFollowConfig(ByteBuffer _bb, INpcFollowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033581 RID: 210305 RVA: 0x006ECA0D File Offset: 0x006EAC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033582 RID: 210306 RVA: 0x006ECA1C File Offset: 0x006EAC1C
		public INpcFollowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7DF RID: 55263
		// (get) Token: 0x06033583 RID: 210307 RVA: 0x006ECA2C File Offset: 0x006EAC2C
		public IPerformerRangeBoundaryActionTrigger? PerformerWhenEnter
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPerformerRangeBoundaryActionTrigger?(default(IPerformerRangeBoundaryActionTrigger).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D7E0 RID: 55264
		// (get) Token: 0x06033584 RID: 210308 RVA: 0x006ECA8C File Offset: 0x006EAC8C
		public IPerformerRangeBoundaryActionTrigger? PerformerWhenExit
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPerformerRangeBoundaryActionTrigger?(default(IPerformerRangeBoundaryActionTrigger).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06033585 RID: 210309 RVA: 0x006ECAE9 File Offset: 0x006EACE9
		public static Offset<INpcFollowConfig> CreateINpcFollowConfig(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> PerformerWhenEnterOffset = default(Offset<IPerformerRangeBoundaryActionTrigger>), Offset<IPerformerRangeBoundaryActionTrigger> PerformerWhenExitOffset = default(Offset<IPerformerRangeBoundaryActionTrigger>))
		{
			builder.StartTable(2);
			INpcFollowConfig.AddPerformerWhenExit(builder, PerformerWhenExitOffset);
			INpcFollowConfig.AddPerformerWhenEnter(builder, PerformerWhenEnterOffset);
			return INpcFollowConfig.EndINpcFollowConfig(builder);
		}

		// Token: 0x06033586 RID: 210310 RVA: 0x006ECB06 File Offset: 0x006EAD06
		public static void StartINpcFollowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033587 RID: 210311 RVA: 0x006ECB0F File Offset: 0x006EAD0F
		public static void AddPerformerWhenEnter(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> performerWhenEnterOffset)
		{
			builder.AddOffset(0, performerWhenEnterOffset.Value, 0);
		}

		// Token: 0x06033588 RID: 210312 RVA: 0x006ECB1F File Offset: 0x006EAD1F
		public static void AddPerformerWhenExit(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> performerWhenExitOffset)
		{
			builder.AddOffset(1, performerWhenExitOffset.Value, 0);
		}

		// Token: 0x06033589 RID: 210313 RVA: 0x006ECB2F File Offset: 0x006EAD2F
		public static Offset<INpcFollowConfig> EndINpcFollowConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcFollowConfig>(builder.EndTable());
		}

		// Token: 0x0603358A RID: 210314 RVA: 0x006ECB3C File Offset: 0x006EAD3C
		public INpcFollowConfigT UnPack()
		{
			INpcFollowConfigT npcFollowConfigT = new INpcFollowConfigT();
			this.UnPackTo(npcFollowConfigT);
			return npcFollowConfigT;
		}

		// Token: 0x0603358B RID: 210315 RVA: 0x006ECB58 File Offset: 0x006EAD58
		public void UnPackTo(INpcFollowConfigT _o)
		{
			_o.PerformerWhenEnter = ((this.PerformerWhenEnter != null) ? this.PerformerWhenEnter.Value.UnPack() : null);
			_o.PerformerWhenExit = ((this.PerformerWhenExit != null) ? this.PerformerWhenExit.Value.UnPack() : null);
		}

		// Token: 0x0603358C RID: 210316 RVA: 0x006ECBC4 File Offset: 0x006EADC4
		public static Offset<INpcFollowConfig> Pack(FlatBufferBuilder builder, INpcFollowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcFollowConfig>);
			}
			Offset<IPerformerRangeBoundaryActionTrigger> performerWhenEnterOffset = (_o.PerformerWhenEnter == null) ? default(Offset<IPerformerRangeBoundaryActionTrigger>) : IPerformerRangeBoundaryActionTrigger.Pack(builder, _o.PerformerWhenEnter);
			Offset<IPerformerRangeBoundaryActionTrigger> performerWhenExitOffset = (_o.PerformerWhenExit == null) ? default(Offset<IPerformerRangeBoundaryActionTrigger>) : IPerformerRangeBoundaryActionTrigger.Pack(builder, _o.PerformerWhenExit);
			return INpcFollowConfig.CreateINpcFollowConfig(builder, performerWhenEnterOffset, performerWhenExitOffset);
		}

		// Token: 0x040123BC RID: 74684
		private Table __p;
	}
}
