using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540D RID: 21517
	public struct IInhaledItemComponent : IFlatbufferObject
	{
		// Token: 0x17009E4C RID: 40524
		// (get) Token: 0x06023561 RID: 144737 RVA: 0x004E419D File Offset: 0x004E239D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023562 RID: 144738 RVA: 0x004E41AA File Offset: 0x004E23AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023563 RID: 144739 RVA: 0x004E41B4 File Offset: 0x004E23B4
		public static IInhaledItemComponent GetRootAsIInhaledItemComponent(ByteBuffer _bb)
		{
			return IInhaledItemComponent.GetRootAsIInhaledItemComponent(_bb, default(IInhaledItemComponent));
		}

		// Token: 0x06023564 RID: 144740 RVA: 0x004E41D0 File Offset: 0x004E23D0
		public static IInhaledItemComponent GetRootAsIInhaledItemComponent(ByteBuffer _bb, IInhaledItemComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023565 RID: 144741 RVA: 0x004E41ED File Offset: 0x004E23ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023566 RID: 144742 RVA: 0x004E41FC File Offset: 0x004E23FC
		public IInhaledItemComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E4D RID: 40525
		// (get) Token: 0x06023567 RID: 144743 RVA: 0x004E420C File Offset: 0x004E240C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E4E RID: 40526
		// (get) Token: 0x06023568 RID: 144744 RVA: 0x004E424C File Offset: 0x004E244C
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

		// Token: 0x17009E4F RID: 40527
		// (get) Token: 0x06023569 RID: 144745 RVA: 0x004E4288 File Offset: 0x004E2488
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

		// Token: 0x17009E50 RID: 40528
		// (get) Token: 0x0602356A RID: 144746 RVA: 0x004E42C4 File Offset: 0x004E24C4
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

		// Token: 0x17009E51 RID: 40529
		// (get) Token: 0x0602356B RID: 144747 RVA: 0x004E4324 File Offset: 0x004E2524
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

		// Token: 0x0602356C RID: 144748 RVA: 0x004E4364 File Offset: 0x004E2564
		public TTable? InhaledPerResult<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602356D RID: 144749 RVA: 0x004E43AC File Offset: 0x004E25AC
		public IInhaledChangeSelfState InhaledPerResultAsIInhaledChangeSelfState()
		{
			return this.InhaledPerResult<IInhaledChangeSelfState>().Value;
		}

		// Token: 0x0602356E RID: 144750 RVA: 0x004E43C8 File Offset: 0x004E25C8
		public IInhaledDestroySelf InhaledPerResultAsIInhaledDestroySelf()
		{
			return this.InhaledPerResult<IInhaledDestroySelf>().Value;
		}

		// Token: 0x17009E52 RID: 40530
		// (get) Token: 0x0602356F RID: 144751 RVA: 0x004E43E4 File Offset: 0x004E25E4
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

		// Token: 0x06023570 RID: 144752 RVA: 0x004E4424 File Offset: 0x004E2624
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

		// Token: 0x06023571 RID: 144753 RVA: 0x004E4473 File Offset: 0x004E2673
		public static void StartIInhaledItemComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023572 RID: 144754 RVA: 0x004E447C File Offset: 0x004E267C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023573 RID: 144755 RVA: 0x004E4487 File Offset: 0x004E2687
		public static void AddInhaledStrength(FlatBufferBuilder builder, int inhaledStrength)
		{
			builder.AddInt(1, inhaledStrength, 0);
		}

		// Token: 0x06023574 RID: 144756 RVA: 0x004E4492 File Offset: 0x004E2692
		public static void AddInhaledInterruptionRecoveryTime(FlatBufferBuilder builder, int inhaledInterruptionRecoveryTime)
		{
			builder.AddInt(2, inhaledInterruptionRecoveryTime, 0);
		}

		// Token: 0x06023575 RID: 144757 RVA: 0x004E449D File Offset: 0x004E269D
		public static void AddInhaledPerformance(FlatBufferBuilder builder, Offset<IInhaledPerformance> inhaledPerformanceOffset)
		{
			builder.AddOffset(3, inhaledPerformanceOffset.Value, 0);
		}

		// Token: 0x06023576 RID: 144758 RVA: 0x004E44AD File Offset: 0x004E26AD
		public static void AddInhaledPerResultType(FlatBufferBuilder builder, TInhaledPerResultType inhaledPerResultType)
		{
			builder.AddByte(4, (byte)inhaledPerResultType, 0);
		}

		// Token: 0x06023577 RID: 144759 RVA: 0x004E44B8 File Offset: 0x004E26B8
		public static void AddInhaledPerResult(FlatBufferBuilder builder, int inhaledPerResultOffset)
		{
			builder.AddOffset(5, inhaledPerResultOffset, 0);
		}

		// Token: 0x06023578 RID: 144760 RVA: 0x004E44C3 File Offset: 0x004E26C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023579 RID: 144761 RVA: 0x004E44CE File Offset: 0x004E26CE
		public static Offset<IInhaledItemComponent> EndIInhaledItemComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInhaledItemComponent>(builder.EndTable());
		}

		// Token: 0x0602357A RID: 144762 RVA: 0x004E44DC File Offset: 0x004E26DC
		public IInhaledItemComponentT UnPack()
		{
			IInhaledItemComponentT inhaledItemComponentT = new IInhaledItemComponentT();
			this.UnPackTo(inhaledItemComponentT);
			return inhaledItemComponentT;
		}

		// Token: 0x0602357B RID: 144763 RVA: 0x004E44F8 File Offset: 0x004E26F8
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

		// Token: 0x0602357C RID: 144764 RVA: 0x004E4600 File Offset: 0x004E2800
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

		// Token: 0x0400E653 RID: 58963
		private Table __p;
	}
}
