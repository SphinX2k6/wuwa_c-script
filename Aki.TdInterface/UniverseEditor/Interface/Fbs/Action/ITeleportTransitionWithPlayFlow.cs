using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA5 RID: 31653
	public struct ITeleportTransitionWithPlayFlow : IFlatbufferObject
	{
		// Token: 0x1700ED0F RID: 60687
		// (get) Token: 0x06039075 RID: 233589 RVA: 0x007B4FF0 File Offset: 0x007B31F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039076 RID: 233590 RVA: 0x007B4FFD File Offset: 0x007B31FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039077 RID: 233591 RVA: 0x007B5004 File Offset: 0x007B3204
		public static ITeleportTransitionWithPlayFlow GetRootAsITeleportTransitionWithPlayFlow(ByteBuffer _bb)
		{
			return ITeleportTransitionWithPlayFlow.GetRootAsITeleportTransitionWithPlayFlow(_bb, default(ITeleportTransitionWithPlayFlow));
		}

		// Token: 0x06039078 RID: 233592 RVA: 0x007B5020 File Offset: 0x007B3220
		public static ITeleportTransitionWithPlayFlow GetRootAsITeleportTransitionWithPlayFlow(ByteBuffer _bb, ITeleportTransitionWithPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039079 RID: 233593 RVA: 0x007B503D File Offset: 0x007B323D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603907A RID: 233594 RVA: 0x007B504C File Offset: 0x007B324C
		public ITeleportTransitionWithPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED10 RID: 60688
		// (get) Token: 0x0603907B RID: 233595 RVA: 0x007B505C File Offset: 0x007B325C
		public ETeleportTransitionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return (ETeleportTransitionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ED11 RID: 60689
		// (get) Token: 0x0603907C RID: 233596 RVA: 0x007B5098 File Offset: 0x007B3298
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ED12 RID: 60690
		// (get) Token: 0x0603907D RID: 233597 RVA: 0x007B50F8 File Offset: 0x007B32F8
		public IFadeBackgroundFadeInEffect? FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeInEffect?(default(IFadeBackgroundFadeInEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700ED13 RID: 60691
		// (get) Token: 0x0603907E RID: 233598 RVA: 0x007B5158 File Offset: 0x007B3358
		public IFadeBackgroundFadeOutEffect? FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeOutEffect?(default(IFadeBackgroundFadeOutEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603907F RID: 233599 RVA: 0x007B51B6 File Offset: 0x007B33B6
		public static Offset<ITeleportTransitionWithPlayFlow> CreateITeleportTransitionWithPlayFlow(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			ITeleportTransitionWithPlayFlow.AddFadeOutEffect(builder, FadeOutEffectOffset);
			ITeleportTransitionWithPlayFlow.AddFadeInEffect(builder, FadeInEffectOffset);
			ITeleportTransitionWithPlayFlow.AddFlow(builder, FlowOffset);
			ITeleportTransitionWithPlayFlow.AddType(builder, Type);
			return ITeleportTransitionWithPlayFlow.EndITeleportTransitionWithPlayFlow(builder);
		}

		// Token: 0x06039080 RID: 233600 RVA: 0x007B51E2 File Offset: 0x007B33E2
		public static void StartITeleportTransitionWithPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039081 RID: 233601 RVA: 0x007B51EB File Offset: 0x007B33EB
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039082 RID: 233602 RVA: 0x007B51F6 File Offset: 0x007B33F6
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06039083 RID: 233603 RVA: 0x007B5206 File Offset: 0x007B3406
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x06039084 RID: 233604 RVA: 0x007B5216 File Offset: 0x007B3416
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x06039085 RID: 233605 RVA: 0x007B5226 File Offset: 0x007B3426
		public static Offset<ITeleportTransitionWithPlayFlow> EndITeleportTransitionWithPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithPlayFlow>(builder.EndTable());
		}

		// Token: 0x06039086 RID: 233606 RVA: 0x007B5234 File Offset: 0x007B3434
		public ITeleportTransitionWithPlayFlowT UnPack()
		{
			ITeleportTransitionWithPlayFlowT teleportTransitionWithPlayFlowT = new ITeleportTransitionWithPlayFlowT();
			this.UnPackTo(teleportTransitionWithPlayFlowT);
			return teleportTransitionWithPlayFlowT;
		}

		// Token: 0x06039087 RID: 233607 RVA: 0x007B5250 File Offset: 0x007B3450
		public void UnPackTo(ITeleportTransitionWithPlayFlowT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x06039088 RID: 233608 RVA: 0x007B52FC File Offset: 0x007B34FC
		public static Offset<ITeleportTransitionWithPlayFlow> Pack(FlatBufferBuilder builder, ITeleportTransitionWithPlayFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportTransitionWithPlayFlow>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset = (_o.FadeInEffect == null) ? default(Offset<IFadeBackgroundFadeInEffect>) : IFadeBackgroundFadeInEffect.Pack(builder, _o.FadeInEffect);
			Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset = (_o.FadeOutEffect == null) ? default(Offset<IFadeBackgroundFadeOutEffect>) : IFadeBackgroundFadeOutEffect.Pack(builder, _o.FadeOutEffect);
			return ITeleportTransitionWithPlayFlow.CreateITeleportTransitionWithPlayFlow(builder, _o.Type, flowOffset, fadeInEffectOffset, fadeOutEffectOffset);
		}

		// Token: 0x04013217 RID: 78359
		private Table __p;
	}
}
