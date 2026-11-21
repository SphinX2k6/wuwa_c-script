using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005993 RID: 22931
	public struct IInhaledItemComponent : IFlatbufferObject
	{
		// Token: 0x1700A686 RID: 42630
		// (get) Token: 0x06025619 RID: 153113 RVA: 0x005211C9 File Offset: 0x0051F3C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602561A RID: 153114 RVA: 0x005211D6 File Offset: 0x0051F3D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602561B RID: 153115 RVA: 0x005211E0 File Offset: 0x0051F3E0
		public static IInhaledItemComponent GetRootAsIInhaledItemComponent(ByteBuffer _bb)
		{
			return IInhaledItemComponent.GetRootAsIInhaledItemComponent(_bb, default(IInhaledItemComponent));
		}

		// Token: 0x0602561C RID: 153116 RVA: 0x005211FC File Offset: 0x0051F3FC
		public static IInhaledItemComponent GetRootAsIInhaledItemComponent(ByteBuffer _bb, IInhaledItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602561D RID: 153117 RVA: 0x00521219 File Offset: 0x0051F419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602561E RID: 153118 RVA: 0x00521228 File Offset: 0x0051F428
		public IInhaledItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A687 RID: 42631
		// (get) Token: 0x0602561F RID: 153119 RVA: 0x00521238 File Offset: 0x0051F438
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A688 RID: 42632
		// (get) Token: 0x06025620 RID: 153120 RVA: 0x00521278 File Offset: 0x0051F478
		public int InhaledStrength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A689 RID: 42633
		// (get) Token: 0x06025621 RID: 153121 RVA: 0x005212B4 File Offset: 0x0051F4B4
		public int InhaledInterruptionRecoveryTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A68A RID: 42634
		// (get) Token: 0x06025622 RID: 153122 RVA: 0x005212F0 File Offset: 0x0051F4F0
		public IInhaledPerformance? InhaledPerformance
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IInhaledPerformance?(default(IInhaledPerformance).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A68B RID: 42635
		// (get) Token: 0x06025623 RID: 153123 RVA: 0x00521350 File Offset: 0x0051F550
		public TInhaledPerResultType InhaledPerResultType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TInhaledPerResultType.NONE;
				}
				return (TInhaledPerResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025624 RID: 153124 RVA: 0x00521390 File Offset: 0x0051F590
		public TTable? InhaledPerResult<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025625 RID: 153125 RVA: 0x005213D8 File Offset: 0x0051F5D8
		public IInhaledChangeSelfState InhaledPerResultAsIInhaledChangeSelfState()
		{
			return this.InhaledPerResult<IInhaledChangeSelfState>().Value;
		}

		// Token: 0x06025626 RID: 153126 RVA: 0x005213F4 File Offset: 0x0051F5F4
		public IInhaledDestroySelf InhaledPerResultAsIInhaledDestroySelf()
		{
			return this.InhaledPerResult<IInhaledDestroySelf>().Value;
		}

		// Token: 0x1700A68C RID: 42636
		// (get) Token: 0x06025627 RID: 153127 RVA: 0x00521410 File Offset: 0x0051F610
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025628 RID: 153128 RVA: 0x00521450 File Offset: 0x0051F650
		public static Offset<IInhaledItemComponent> CreateIInhaledItemComponent(FlatBufferBuilder builder, bool Disabled = false, int InhaledStrength = 0, int InhaledInterruptionRecoveryTime = 0, Offset<IInhaledPerformance> InhaledPerformanceOffset = default(Offset<IInhaledPerformance>), TInhaledPerResultType InhaledPerResult_type = TInhaledPerResultType.NONE, int InhaledPerResultOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IInhaledItemComponent.AddInhaledPerResult(builder, InhaledPerResultOffset);
			IInhaledItemComponent.AddInhaledPerformance(builder, InhaledPerformanceOffset);
			IInhaledItemComponent.AddInhaledInterruptionRecoveryTime(builder, InhaledInterruptionRecoveryTime);
			IInhaledItemComponent.AddInhaledStrength(builder, InhaledStrength);
			IInhaledItemComponent.AddNullMask(builder, NullMask);
			IInhaledItemComponent.AddInhaledPerResultType(builder, InhaledPerResult_type);
			IInhaledItemComponent.AddDisabled(builder, Disabled);
			return IInhaledItemComponent.EndIInhaledItemComponent(builder);
		}

		// Token: 0x06025629 RID: 153129 RVA: 0x0052149F File Offset: 0x0051F69F
		public static void StartIInhaledItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602562A RID: 153130 RVA: 0x005214A8 File Offset: 0x0051F6A8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602562B RID: 153131 RVA: 0x005214B3 File Offset: 0x0051F6B3
		public static void AddInhaledStrength(FlatBufferBuilder builder, int inhaledStrength)
		{
			builder.AddInt(1, inhaledStrength, 0);
		}

		// Token: 0x0602562C RID: 153132 RVA: 0x005214BE File Offset: 0x0051F6BE
		public static void AddInhaledInterruptionRecoveryTime(FlatBufferBuilder builder, int inhaledInterruptionRecoveryTime)
		{
			builder.AddInt(2, inhaledInterruptionRecoveryTime, 0);
		}

		// Token: 0x0602562D RID: 153133 RVA: 0x005214C9 File Offset: 0x0051F6C9
		public static void AddInhaledPerformance(FlatBufferBuilder builder, Offset<IInhaledPerformance> inhaledPerformanceOffset)
		{
			builder.AddOffset(3, inhaledPerformanceOffset.Value, 0);
		}

		// Token: 0x0602562E RID: 153134 RVA: 0x005214D9 File Offset: 0x0051F6D9
		public static void AddInhaledPerResultType(FlatBufferBuilder builder, TInhaledPerResultType inhaledPerResultType)
		{
			builder.AddByte(4, (byte)inhaledPerResultType, 0);
		}

		// Token: 0x0602562F RID: 153135 RVA: 0x005214E4 File Offset: 0x0051F6E4
		public static void AddInhaledPerResult(FlatBufferBuilder builder, int inhaledPerResultOffset)
		{
			builder.AddOffset(5, inhaledPerResultOffset, 0);
		}

		// Token: 0x06025630 RID: 153136 RVA: 0x005214EF File Offset: 0x0051F6EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025631 RID: 153137 RVA: 0x005214FA File Offset: 0x0051F6FA
		public static Offset<IInhaledItemComponent> EndIInhaledItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledItemComponent>(builder.EndTable());
		}

		// Token: 0x06025632 RID: 153138 RVA: 0x00521508 File Offset: 0x0051F708
		public IInhaledItemComponentT UnPack()
		{
			IInhaledItemComponentT inhaledItemComponentT = new IInhaledItemComponentT();
			this.UnPackTo(inhaledItemComponentT);
			return inhaledItemComponentT;
		}

		// Token: 0x06025633 RID: 153139 RVA: 0x00521524 File Offset: 0x0051F724
		public void UnPackTo(IInhaledItemComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.InhaledStrength = this.InhaledStrength;
			_o.InhaledInterruptionRecoveryTime = this.InhaledInterruptionRecoveryTime;
			_o.InhaledPerformance = ((this.InhaledPerformance != null) ? this.InhaledPerformance.Value.UnPack() : null);
			_o.InhaledPerResult = new TInhaledPerResultTypeUnion();
			_o.InhaledPerResult.Type = this.InhaledPerResultType;
			TInhaledPerResultType inhaledPerResultType = this.InhaledPerResultType;
			if (inhaledPerResultType != TInhaledPerResultType.IInhaledChangeSelfState)
			{
				if (inhaledPerResultType == TInhaledPerResultType.IInhaledDestroySelf)
				{
					_o.InhaledPerResult.Value = ((this.InhaledPerResult<IInhaledDestroySelf>() != null) ? this.InhaledPerResult<IInhaledDestroySelf>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.InhaledPerResult.Value = ((this.InhaledPerResult<IInhaledChangeSelfState>() != null) ? this.InhaledPerResult<IInhaledChangeSelfState>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025634 RID: 153140 RVA: 0x0052162C File Offset: 0x0051F82C
		public static Offset<IInhaledItemComponent> Pack(FlatBufferBuilder builder, IInhaledItemComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInhaledItemComponent>);
			}
			Offset<IInhaledPerformance> inhaledPerformanceOffset = (_o.InhaledPerformance == null) ? default(Offset<IInhaledPerformance>) : IInhaledPerformance.Pack(builder, _o.InhaledPerformance);
			TInhaledPerResultType inhaledPerResult_type = (_o.InhaledPerResult == null) ? TInhaledPerResultType.NONE : _o.InhaledPerResult.Type;
			int inhaledPerResultOffset = (_o.InhaledPerResult == null) ? 0 : TInhaledPerResultTypeUnion.Pack(builder, _o.InhaledPerResult);
			return IInhaledItemComponent.CreateIInhaledItemComponent(builder, _o.Disabled, _o.InhaledStrength, _o.InhaledInterruptionRecoveryTime, inhaledPerformanceOffset, inhaledPerResult_type, inhaledPerResultOffset, _o.NullMask);
		}

		// Token: 0x0400F284 RID: 62084
		private Table __p;
	}
}
