using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB5 RID: 27573
	public struct INpcFollowConfig : IFlatbufferObject
	{
		// Token: 0x1700CCF2 RID: 52466
		// (get) Token: 0x06030703 RID: 198403 RVA: 0x00694020 File Offset: 0x00692220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030704 RID: 198404 RVA: 0x0069402D File Offset: 0x0069222D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030705 RID: 198405 RVA: 0x00694034 File Offset: 0x00692234
		public static INpcFollowConfig GetRootAsINpcFollowConfig(ByteBuffer _bb)
		{
			return INpcFollowConfig.GetRootAsINpcFollowConfig(_bb, default(INpcFollowConfig));
		}

		// Token: 0x06030706 RID: 198406 RVA: 0x00694050 File Offset: 0x00692250
		public static INpcFollowConfig GetRootAsINpcFollowConfig(ByteBuffer _bb, INpcFollowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030707 RID: 198407 RVA: 0x0069406D File Offset: 0x0069226D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030708 RID: 198408 RVA: 0x0069407C File Offset: 0x0069227C
		public INpcFollowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCF3 RID: 52467
		// (get) Token: 0x06030709 RID: 198409 RVA: 0x0069408C File Offset: 0x0069228C
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

		// Token: 0x1700CCF4 RID: 52468
		// (get) Token: 0x0603070A RID: 198410 RVA: 0x006940EC File Offset: 0x006922EC
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

		// Token: 0x0603070B RID: 198411 RVA: 0x00694149 File Offset: 0x00692349
		public static Offset<INpcFollowConfig> CreateINpcFollowConfig(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> PerformerWhenEnterOffset = default(Offset<IPerformerRangeBoundaryActionTrigger>), Offset<IPerformerRangeBoundaryActionTrigger> PerformerWhenExitOffset = default(Offset<IPerformerRangeBoundaryActionTrigger>))
		{
			builder.StartTable(2);
			INpcFollowConfig.AddPerformerWhenExit(builder, PerformerWhenExitOffset);
			INpcFollowConfig.AddPerformerWhenEnter(builder, PerformerWhenEnterOffset);
			return INpcFollowConfig.EndINpcFollowConfig(builder);
		}

		// Token: 0x0603070C RID: 198412 RVA: 0x00694166 File Offset: 0x00692366
		public static void StartINpcFollowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603070D RID: 198413 RVA: 0x0069416F File Offset: 0x0069236F
		public static void AddPerformerWhenEnter(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> performerWhenEnterOffset)
		{
			builder.AddOffset(0, performerWhenEnterOffset.Value, 0);
		}

		// Token: 0x0603070E RID: 198414 RVA: 0x0069417F File Offset: 0x0069237F
		public static void AddPerformerWhenExit(FlatBufferBuilder builder, Offset<IPerformerRangeBoundaryActionTrigger> performerWhenExitOffset)
		{
			builder.AddOffset(1, performerWhenExitOffset.Value, 0);
		}

		// Token: 0x0603070F RID: 198415 RVA: 0x0069418F File Offset: 0x0069238F
		public static Offset<INpcFollowConfig> EndINpcFollowConfig(FlatBufferBuilder builder)
		{
			return new Offset<INpcFollowConfig>(builder.EndTable());
		}

		// Token: 0x06030710 RID: 198416 RVA: 0x0069419C File Offset: 0x0069239C
		public INpcFollowConfigT UnPack()
		{
			INpcFollowConfigT npcFollowConfigT = new INpcFollowConfigT();
			this.UnPackTo(npcFollowConfigT);
			return npcFollowConfigT;
		}

		// Token: 0x06030711 RID: 198417 RVA: 0x006941B8 File Offset: 0x006923B8
		public void UnPackTo(INpcFollowConfigT _o)
		{
			_o.PerformerWhenEnter = ((this.PerformerWhenEnter != null) ? this.PerformerWhenEnter.Value.UnPack() : null);
			_o.PerformerWhenExit = ((this.PerformerWhenExit != null) ? this.PerformerWhenExit.Value.UnPack() : null);
		}

		// Token: 0x06030712 RID: 198418 RVA: 0x00694224 File Offset: 0x00692424
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

		// Token: 0x0401148A RID: 70794
		private Table __p;
	}
}
