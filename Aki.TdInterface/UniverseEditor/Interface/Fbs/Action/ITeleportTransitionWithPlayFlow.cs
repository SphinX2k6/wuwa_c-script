using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BE RID: 29630
	public struct ITeleportTransitionWithPlayFlow : IFlatbufferObject
	{
		// Token: 0x1700E0FF RID: 57599
		// (get) Token: 0x06035CDA RID: 220378 RVA: 0x00752AB0 File Offset: 0x00750CB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035CDB RID: 220379 RVA: 0x00752ABD File Offset: 0x00750CBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035CDC RID: 220380 RVA: 0x00752AC4 File Offset: 0x00750CC4
		public static ITeleportTransitionWithPlayFlow GetRootAsITeleportTransitionWithPlayFlow(ByteBuffer _bb)
		{
			return ITeleportTransitionWithPlayFlow.GetRootAsITeleportTransitionWithPlayFlow(_bb, default(ITeleportTransitionWithPlayFlow));
		}

		// Token: 0x06035CDD RID: 220381 RVA: 0x00752AE0 File Offset: 0x00750CE0
		public static ITeleportTransitionWithPlayFlow GetRootAsITeleportTransitionWithPlayFlow(ByteBuffer _bb, ITeleportTransitionWithPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035CDE RID: 220382 RVA: 0x00752AFD File Offset: 0x00750CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035CDF RID: 220383 RVA: 0x00752B0C File Offset: 0x00750D0C
		public ITeleportTransitionWithPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E100 RID: 57600
		// (get) Token: 0x06035CE0 RID: 220384 RVA: 0x00752B1C File Offset: 0x00750D1C
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

		// Token: 0x1700E101 RID: 57601
		// (get) Token: 0x06035CE1 RID: 220385 RVA: 0x00752B58 File Offset: 0x00750D58
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

		// Token: 0x1700E102 RID: 57602
		// (get) Token: 0x06035CE2 RID: 220386 RVA: 0x00752BB8 File Offset: 0x00750DB8
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

		// Token: 0x1700E103 RID: 57603
		// (get) Token: 0x06035CE3 RID: 220387 RVA: 0x00752C18 File Offset: 0x00750E18
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

		// Token: 0x06035CE4 RID: 220388 RVA: 0x00752C76 File Offset: 0x00750E76
		public static Offset<ITeleportTransitionWithPlayFlow> CreateITeleportTransitionWithPlayFlow(FlatBufferBuilder builder, ETeleportTransitionType Type = ETeleportTransitionType.PlayMp4, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			ITeleportTransitionWithPlayFlow.AddFadeOutEffect(builder, FadeOutEffectOffset);
			ITeleportTransitionWithPlayFlow.AddFadeInEffect(builder, FadeInEffectOffset);
			ITeleportTransitionWithPlayFlow.AddFlow(builder, FlowOffset);
			ITeleportTransitionWithPlayFlow.AddType(builder, Type);
			return ITeleportTransitionWithPlayFlow.EndITeleportTransitionWithPlayFlow(builder);
		}

		// Token: 0x06035CE5 RID: 220389 RVA: 0x00752CA2 File Offset: 0x00750EA2
		public static void StartITeleportTransitionWithPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035CE6 RID: 220390 RVA: 0x00752CAB File Offset: 0x00750EAB
		public static void AddType(FlatBufferBuilder builder, ETeleportTransitionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035CE7 RID: 220391 RVA: 0x00752CB6 File Offset: 0x00750EB6
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06035CE8 RID: 220392 RVA: 0x00752CC6 File Offset: 0x00750EC6
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x06035CE9 RID: 220393 RVA: 0x00752CD6 File Offset: 0x00750ED6
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x06035CEA RID: 220394 RVA: 0x00752CE6 File Offset: 0x00750EE6
		public static Offset<ITeleportTransitionWithPlayFlow> EndITeleportTransitionWithPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportTransitionWithPlayFlow>(builder.EndTable());
		}

		// Token: 0x06035CEB RID: 220395 RVA: 0x00752CF4 File Offset: 0x00750EF4
		public ITeleportTransitionWithPlayFlowT UnPack()
		{
			ITeleportTransitionWithPlayFlowT teleportTransitionWithPlayFlowT = new ITeleportTransitionWithPlayFlowT();
			this.UnPackTo(teleportTransitionWithPlayFlowT);
			return teleportTransitionWithPlayFlowT;
		}

		// Token: 0x06035CEC RID: 220396 RVA: 0x00752D10 File Offset: 0x00750F10
		public void UnPackTo(ITeleportTransitionWithPlayFlowT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x06035CED RID: 220397 RVA: 0x00752DBC File Offset: 0x00750FBC
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

		// Token: 0x040121FE RID: 74238
		private Table __p;
	}
}
