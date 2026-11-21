using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E56 RID: 24150
	public struct IRenderSpecifiedRangeComponent : IFlatbufferObject
	{
		// Token: 0x1700B218 RID: 45592
		// (get) Token: 0x060285F0 RID: 165360 RVA: 0x00585416 File Offset: 0x00583616
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060285F1 RID: 165361 RVA: 0x00585423 File Offset: 0x00583623
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060285F2 RID: 165362 RVA: 0x0058542C File Offset: 0x0058362C
		public static IRenderSpecifiedRangeComponent GetRootAsIRenderSpecifiedRangeComponent(ByteBuffer _bb)
		{
			return IRenderSpecifiedRangeComponent.GetRootAsIRenderSpecifiedRangeComponent(_bb, default(IRenderSpecifiedRangeComponent));
		}

		// Token: 0x060285F3 RID: 165363 RVA: 0x00585448 File Offset: 0x00583648
		public static IRenderSpecifiedRangeComponent GetRootAsIRenderSpecifiedRangeComponent(ByteBuffer _bb, IRenderSpecifiedRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060285F4 RID: 165364 RVA: 0x00585465 File Offset: 0x00583665
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060285F5 RID: 165365 RVA: 0x00585474 File Offset: 0x00583674
		public IRenderSpecifiedRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B219 RID: 45593
		// (get) Token: 0x060285F6 RID: 165366 RVA: 0x00585484 File Offset: 0x00583684
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B21A RID: 45594
		// (get) Token: 0x060285F7 RID: 165367 RVA: 0x005854C4 File Offset: 0x005836C4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B21B RID: 45595
		// (get) Token: 0x060285F8 RID: 165368 RVA: 0x00585524 File Offset: 0x00583724
		public TRenderSpecifiedRangeConfig RenderConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRenderSpecifiedRangeConfig.NONE;
				}
				return (TRenderSpecifiedRangeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060285F9 RID: 165369 RVA: 0x00585560 File Offset: 0x00583760
		public TTable? RenderConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060285FA RID: 165370 RVA: 0x005855A8 File Offset: 0x005837A8
		public IRenderBeforeYourEyesSceneReveal RenderConfigAsIRenderBeforeYourEyesSceneReveal()
		{
			return this.RenderConfig<IRenderBeforeYourEyesSceneReveal>().Value;
		}

		// Token: 0x060285FB RID: 165371 RVA: 0x005855C4 File Offset: 0x005837C4
		public IRenderBookPage RenderConfigAsIRenderBookPage()
		{
			return this.RenderConfig<IRenderBookPage>().Value;
		}

		// Token: 0x060285FC RID: 165372 RVA: 0x005855E0 File Offset: 0x005837E0
		public IRenderFlowerBridge RenderConfigAsIRenderFlowerBridge()
		{
			return this.RenderConfig<IRenderFlowerBridge>().Value;
		}

		// Token: 0x060285FD RID: 165373 RVA: 0x005855FC File Offset: 0x005837FC
		public IRenderFogBarrier RenderConfigAsIRenderFogBarrier()
		{
			return this.RenderConfig<IRenderFogBarrier>().Value;
		}

		// Token: 0x060285FE RID: 165374 RVA: 0x00585618 File Offset: 0x00583818
		public IRenderQuantumFollowShooter RenderConfigAsIRenderQuantumFollowShooter()
		{
			return this.RenderConfig<IRenderQuantumFollowShooter>().Value;
		}

		// Token: 0x1700B21C RID: 45596
		// (get) Token: 0x060285FF RID: 165375 RVA: 0x00585634 File Offset: 0x00583834
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

		// Token: 0x06028600 RID: 165376 RVA: 0x00585671 File Offset: 0x00583871
		public static Offset<IRenderSpecifiedRangeComponent> CreateIRenderSpecifiedRangeComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TRenderSpecifiedRangeConfig RenderConfig_type = TRenderSpecifiedRangeConfig.NONE, int RenderConfigOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IRenderSpecifiedRangeComponent.AddRenderConfig(builder, RenderConfigOffset);
			IRenderSpecifiedRangeComponent.AddCondition(builder, ConditionOffset);
			IRenderSpecifiedRangeComponent.AddNullMask(builder, NullMask);
			IRenderSpecifiedRangeComponent.AddRenderConfigType(builder, RenderConfig_type);
			IRenderSpecifiedRangeComponent.AddDisabled(builder, Disabled);
			return IRenderSpecifiedRangeComponent.EndIRenderSpecifiedRangeComponent(builder);
		}

		// Token: 0x06028601 RID: 165377 RVA: 0x005856A5 File Offset: 0x005838A5
		public static void StartIRenderSpecifiedRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028602 RID: 165378 RVA: 0x005856AE File Offset: 0x005838AE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028603 RID: 165379 RVA: 0x005856B9 File Offset: 0x005838B9
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06028604 RID: 165380 RVA: 0x005856C9 File Offset: 0x005838C9
		public static void AddRenderConfigType(FlatBufferBuilder builder, TRenderSpecifiedRangeConfig renderConfigType)
		{
			builder.AddByte(2, (byte)renderConfigType, 0);
		}

		// Token: 0x06028605 RID: 165381 RVA: 0x005856D4 File Offset: 0x005838D4
		public static void AddRenderConfig(FlatBufferBuilder builder, int renderConfigOffset)
		{
			builder.AddOffset(3, renderConfigOffset, 0);
		}

		// Token: 0x06028606 RID: 165382 RVA: 0x005856DF File Offset: 0x005838DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06028607 RID: 165383 RVA: 0x005856EA File Offset: 0x005838EA
		public static Offset<IRenderSpecifiedRangeComponent> EndIRenderSpecifiedRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRenderSpecifiedRangeComponent>(builder.EndTable());
		}

		// Token: 0x06028608 RID: 165384 RVA: 0x005856F8 File Offset: 0x005838F8
		public IRenderSpecifiedRangeComponentT UnPack()
		{
			IRenderSpecifiedRangeComponentT renderSpecifiedRangeComponentT = new IRenderSpecifiedRangeComponentT();
			this.UnPackTo(renderSpecifiedRangeComponentT);
			return renderSpecifiedRangeComponentT;
		}

		// Token: 0x06028609 RID: 165385 RVA: 0x00585714 File Offset: 0x00583914
		public void UnPackTo(IRenderSpecifiedRangeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.RenderConfig = new TRenderSpecifiedRangeConfigUnion();
			_o.RenderConfig.Type = this.RenderConfigType;
			switch (this.RenderConfigType)
			{
			case TRenderSpecifiedRangeConfig.IRenderBeforeYourEyesSceneReveal:
				_o.RenderConfig.Value = ((this.RenderConfig<IRenderBeforeYourEyesSceneReveal>() != null) ? this.RenderConfig<IRenderBeforeYourEyesSceneReveal>().Value.UnPack() : null);
				break;
			case TRenderSpecifiedRangeConfig.IRenderBookPage:
				_o.RenderConfig.Value = ((this.RenderConfig<IRenderBookPage>() != null) ? this.RenderConfig<IRenderBookPage>().Value.UnPack() : null);
				break;
			case TRenderSpecifiedRangeConfig.IRenderFlowerBridge:
				_o.RenderConfig.Value = ((this.RenderConfig<IRenderFlowerBridge>() != null) ? this.RenderConfig<IRenderFlowerBridge>().Value.UnPack() : null);
				break;
			case TRenderSpecifiedRangeConfig.IRenderFogBarrier:
				_o.RenderConfig.Value = ((this.RenderConfig<IRenderFogBarrier>() != null) ? this.RenderConfig<IRenderFogBarrier>().Value.UnPack() : null);
				break;
			case TRenderSpecifiedRangeConfig.IRenderQuantumFollowShooter:
				_o.RenderConfig.Value = ((this.RenderConfig<IRenderQuantumFollowShooter>() != null) ? this.RenderConfig<IRenderQuantumFollowShooter>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602860A RID: 165386 RVA: 0x005858CC File Offset: 0x00583ACC
		public static Offset<IRenderSpecifiedRangeComponent> Pack(FlatBufferBuilder builder, IRenderSpecifiedRangeComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderSpecifiedRangeComponent>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TRenderSpecifiedRangeConfig renderConfig_type = (_o.RenderConfig == null) ? TRenderSpecifiedRangeConfig.NONE : _o.RenderConfig.Type;
			int renderConfigOffset = (_o.RenderConfig == null) ? 0 : TRenderSpecifiedRangeConfigUnion.Pack(builder, _o.RenderConfig);
			return IRenderSpecifiedRangeComponent.CreateIRenderSpecifiedRangeComponent(builder, _o.Disabled, conditionOffset, renderConfig_type, renderConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FA60 RID: 64096
		private Table __p;
	}
}
