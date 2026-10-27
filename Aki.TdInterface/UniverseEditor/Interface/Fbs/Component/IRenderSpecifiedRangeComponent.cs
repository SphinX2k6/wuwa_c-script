using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584C RID: 22604
	public struct IRenderSpecifiedRangeComponent : IFlatbufferObject
	{
		// Token: 0x1700A8ED RID: 43245
		// (get) Token: 0x060260A9 RID: 155817 RVA: 0x0053EBB2 File Offset: 0x0053CDB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060260AA RID: 155818 RVA: 0x0053EBBF File Offset: 0x0053CDBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060260AB RID: 155819 RVA: 0x0053EBC8 File Offset: 0x0053CDC8
		public static IRenderSpecifiedRangeComponent GetRootAsIRenderSpecifiedRangeComponent(ByteBuffer _bb)
		{
			return IRenderSpecifiedRangeComponent.GetRootAsIRenderSpecifiedRangeComponent(_bb, default(IRenderSpecifiedRangeComponent));
		}

		// Token: 0x060260AC RID: 155820 RVA: 0x0053EBE4 File Offset: 0x0053CDE4
		public static IRenderSpecifiedRangeComponent GetRootAsIRenderSpecifiedRangeComponent(ByteBuffer _bb, IRenderSpecifiedRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260AD RID: 155821 RVA: 0x0053EC01 File Offset: 0x0053CE01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260AE RID: 155822 RVA: 0x0053EC10 File Offset: 0x0053CE10
		public IRenderSpecifiedRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8EE RID: 43246
		// (get) Token: 0x060260AF RID: 155823 RVA: 0x0053EC20 File Offset: 0x0053CE20
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A8EF RID: 43247
		// (get) Token: 0x060260B0 RID: 155824 RVA: 0x0053EC60 File Offset: 0x0053CE60
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

		// Token: 0x1700A8F0 RID: 43248
		// (get) Token: 0x060260B1 RID: 155825 RVA: 0x0053ECC0 File Offset: 0x0053CEC0
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

		// Token: 0x060260B2 RID: 155826 RVA: 0x0053ECFC File Offset: 0x0053CEFC
		public TTable? RenderConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060260B3 RID: 155827 RVA: 0x0053ED44 File Offset: 0x0053CF44
		public IRenderBookPage RenderConfigAsIRenderBookPage()
		{
			return this.RenderConfig<IRenderBookPage>().Value;
		}

		// Token: 0x060260B4 RID: 155828 RVA: 0x0053ED60 File Offset: 0x0053CF60
		public IRenderFlowerBridge RenderConfigAsIRenderFlowerBridge()
		{
			return this.RenderConfig<IRenderFlowerBridge>().Value;
		}

		// Token: 0x060260B5 RID: 155829 RVA: 0x0053ED7C File Offset: 0x0053CF7C
		public IRenderFogBarrier RenderConfigAsIRenderFogBarrier()
		{
			return this.RenderConfig<IRenderFogBarrier>().Value;
		}

		// Token: 0x060260B6 RID: 155830 RVA: 0x0053ED98 File Offset: 0x0053CF98
		public IRenderQuantumFollowShooter RenderConfigAsIRenderQuantumFollowShooter()
		{
			return this.RenderConfig<IRenderQuantumFollowShooter>().Value;
		}

		// Token: 0x1700A8F1 RID: 43249
		// (get) Token: 0x060260B7 RID: 155831 RVA: 0x0053EDB4 File Offset: 0x0053CFB4
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

		// Token: 0x060260B8 RID: 155832 RVA: 0x0053EDF1 File Offset: 0x0053CFF1
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

		// Token: 0x060260B9 RID: 155833 RVA: 0x0053EE25 File Offset: 0x0053D025
		public static void StartIRenderSpecifiedRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060260BA RID: 155834 RVA: 0x0053EE2E File Offset: 0x0053D02E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x0053EE39 File Offset: 0x0053D039
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x0053EE49 File Offset: 0x0053D049
		public static void AddRenderConfigType(FlatBufferBuilder builder, TRenderSpecifiedRangeConfig renderConfigType)
		{
			builder.AddByte(2, (byte)renderConfigType, 0);
		}

		// Token: 0x060260BD RID: 155837 RVA: 0x0053EE54 File Offset: 0x0053D054
		public static void AddRenderConfig(FlatBufferBuilder builder, int renderConfigOffset)
		{
			builder.AddOffset(3, renderConfigOffset, 0);
		}

		// Token: 0x060260BE RID: 155838 RVA: 0x0053EE5F File Offset: 0x0053D05F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060260BF RID: 155839 RVA: 0x0053EE6A File Offset: 0x0053D06A
		public static Offset<IRenderSpecifiedRangeComponent> EndIRenderSpecifiedRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRenderSpecifiedRangeComponent>(builder.EndTable());
		}

		// Token: 0x060260C0 RID: 155840 RVA: 0x0053EE78 File Offset: 0x0053D078
		public IRenderSpecifiedRangeComponentT UnPack()
		{
			IRenderSpecifiedRangeComponentT renderSpecifiedRangeComponentT = new IRenderSpecifiedRangeComponentT();
			this.UnPackTo(renderSpecifiedRangeComponentT);
			return renderSpecifiedRangeComponentT;
		}

		// Token: 0x060260C1 RID: 155841 RVA: 0x0053EE94 File Offset: 0x0053D094
		public void UnPackTo(IRenderSpecifiedRangeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.RenderConfig = new TRenderSpecifiedRangeConfigUnion();
			_o.RenderConfig.Type = this.RenderConfigType;
			switch (this.RenderConfigType)
			{
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

		// Token: 0x060260C2 RID: 155842 RVA: 0x0053F00C File Offset: 0x0053D20C
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

		// Token: 0x0400ED71 RID: 60785
		private Table __p;
	}
}
