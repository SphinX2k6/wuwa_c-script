using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FFF RID: 24575
	public struct ISunSpiritBlockExtraRange : IFlatbufferObject
	{
		// Token: 0x1700B636 RID: 46646
		// (get) Token: 0x060296A6 RID: 169638 RVA: 0x005A7329 File Offset: 0x005A5529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060296A7 RID: 169639 RVA: 0x005A7336 File Offset: 0x005A5536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060296A8 RID: 169640 RVA: 0x005A7340 File Offset: 0x005A5540
		public static ISunSpiritBlockExtraRange GetRootAsISunSpiritBlockExtraRange(ByteBuffer _bb)
		{
			return ISunSpiritBlockExtraRange.GetRootAsISunSpiritBlockExtraRange(_bb, default(ISunSpiritBlockExtraRange));
		}

		// Token: 0x060296A9 RID: 169641 RVA: 0x005A735C File Offset: 0x005A555C
		public static ISunSpiritBlockExtraRange GetRootAsISunSpiritBlockExtraRange(ByteBuffer _bb, ISunSpiritBlockExtraRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296AA RID: 169642 RVA: 0x005A7379 File Offset: 0x005A5579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296AB RID: 169643 RVA: 0x005A7388 File Offset: 0x005A5588
		public ISunSpiritBlockExtraRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B637 RID: 46647
		// (get) Token: 0x060296AC RID: 169644 RVA: 0x005A7398 File Offset: 0x005A5598
		public EExtraRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExtraRangeType.SunSpiritBlock;
				}
				return (EExtraRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B638 RID: 46648
		// (get) Token: 0x060296AD RID: 169645 RVA: 0x005A73D4 File Offset: 0x005A55D4
		public ICylinderTriggerShape? CylinderRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICylinderTriggerShape?(default(ICylinderTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060296AE RID: 169646 RVA: 0x005A7431 File Offset: 0x005A5631
		public static Offset<ISunSpiritBlockExtraRange> CreateISunSpiritBlockExtraRange(FlatBufferBuilder builder, EExtraRangeType Type = EExtraRangeType.SunSpiritBlock, Offset<ICylinderTriggerShape> CylinderRangeOffset = default(Offset<ICylinderTriggerShape>))
		{
			builder.StartTable(2);
			ISunSpiritBlockExtraRange.AddCylinderRange(builder, CylinderRangeOffset);
			ISunSpiritBlockExtraRange.AddType(builder, Type);
			return ISunSpiritBlockExtraRange.EndISunSpiritBlockExtraRange(builder);
		}

		// Token: 0x060296AF RID: 169647 RVA: 0x005A744E File Offset: 0x005A564E
		public static void StartISunSpiritBlockExtraRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060296B0 RID: 169648 RVA: 0x005A7457 File Offset: 0x005A5657
		public static void AddType(FlatBufferBuilder builder, EExtraRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060296B1 RID: 169649 RVA: 0x005A7462 File Offset: 0x005A5662
		public static void AddCylinderRange(FlatBufferBuilder builder, Offset<ICylinderTriggerShape> cylinderRangeOffset)
		{
			builder.AddOffset(1, cylinderRangeOffset.Value, 0);
		}

		// Token: 0x060296B2 RID: 169650 RVA: 0x005A7472 File Offset: 0x005A5672
		public static Offset<ISunSpiritBlockExtraRange> EndISunSpiritBlockExtraRange(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritBlockExtraRange>(builder.EndTable());
		}

		// Token: 0x060296B3 RID: 169651 RVA: 0x005A7480 File Offset: 0x005A5680
		public ISunSpiritBlockExtraRangeT UnPack()
		{
			ISunSpiritBlockExtraRangeT sunSpiritBlockExtraRangeT = new ISunSpiritBlockExtraRangeT();
			this.UnPackTo(sunSpiritBlockExtraRangeT);
			return sunSpiritBlockExtraRangeT;
		}

		// Token: 0x060296B4 RID: 169652 RVA: 0x005A749C File Offset: 0x005A569C
		public void UnPackTo(ISunSpiritBlockExtraRangeT _o)
		{
			_o.Type = this.Type;
			_o.CylinderRange = ((this.CylinderRange != null) ? this.CylinderRange.Value.UnPack() : null);
		}

		// Token: 0x060296B5 RID: 169653 RVA: 0x005A74E4 File Offset: 0x005A56E4
		public static Offset<ISunSpiritBlockExtraRange> Pack(FlatBufferBuilder builder, ISunSpiritBlockExtraRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritBlockExtraRange>);
			}
			Offset<ICylinderTriggerShape> cylinderRangeOffset = (_o.CylinderRange == null) ? default(Offset<ICylinderTriggerShape>) : ICylinderTriggerShape.Pack(builder, _o.CylinderRange);
			return ISunSpiritBlockExtraRange.CreateISunSpiritBlockExtraRange(builder, _o.Type, cylinderRangeOffset);
		}

		// Token: 0x0400FD24 RID: 64804
		private Table __p;
	}
}
