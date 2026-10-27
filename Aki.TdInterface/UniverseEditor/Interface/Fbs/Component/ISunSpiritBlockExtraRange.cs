using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F2 RID: 23026
	public struct ISunSpiritBlockExtraRange : IFlatbufferObject
	{
		// Token: 0x1700ACFE RID: 44286
		// (get) Token: 0x0602712E RID: 160046 RVA: 0x00560365 File Offset: 0x0055E565
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602712F RID: 160047 RVA: 0x00560372 File Offset: 0x0055E572
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027130 RID: 160048 RVA: 0x0056037C File Offset: 0x0055E57C
		public static ISunSpiritBlockExtraRange GetRootAsISunSpiritBlockExtraRange(ByteBuffer _bb)
		{
			return ISunSpiritBlockExtraRange.GetRootAsISunSpiritBlockExtraRange(_bb, default(ISunSpiritBlockExtraRange));
		}

		// Token: 0x06027131 RID: 160049 RVA: 0x00560398 File Offset: 0x0055E598
		public static ISunSpiritBlockExtraRange GetRootAsISunSpiritBlockExtraRange(ByteBuffer _bb, ISunSpiritBlockExtraRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027132 RID: 160050 RVA: 0x005603B5 File Offset: 0x0055E5B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027133 RID: 160051 RVA: 0x005603C4 File Offset: 0x0055E5C4
		public ISunSpiritBlockExtraRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACFF RID: 44287
		// (get) Token: 0x06027134 RID: 160052 RVA: 0x005603D4 File Offset: 0x0055E5D4
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

		// Token: 0x1700AD00 RID: 44288
		// (get) Token: 0x06027135 RID: 160053 RVA: 0x00560410 File Offset: 0x0055E610
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

		// Token: 0x06027136 RID: 160054 RVA: 0x0056046D File Offset: 0x0055E66D
		public static Offset<ISunSpiritBlockExtraRange> CreateISunSpiritBlockExtraRange(FlatBufferBuilder builder, EExtraRangeType Type = EExtraRangeType.SunSpiritBlock, Offset<ICylinderTriggerShape> CylinderRangeOffset = default(Offset<ICylinderTriggerShape>))
		{
			builder.StartTable(2);
			ISunSpiritBlockExtraRange.AddCylinderRange(builder, CylinderRangeOffset);
			ISunSpiritBlockExtraRange.AddType(builder, Type);
			return ISunSpiritBlockExtraRange.EndISunSpiritBlockExtraRange(builder);
		}

		// Token: 0x06027137 RID: 160055 RVA: 0x0056048A File Offset: 0x0055E68A
		public static void StartISunSpiritBlockExtraRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027138 RID: 160056 RVA: 0x00560493 File Offset: 0x0055E693
		public static void AddType(FlatBufferBuilder builder, EExtraRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027139 RID: 160057 RVA: 0x0056049E File Offset: 0x0055E69E
		public static void AddCylinderRange(FlatBufferBuilder builder, Offset<ICylinderTriggerShape> cylinderRangeOffset)
		{
			builder.AddOffset(1, cylinderRangeOffset.Value, 0);
		}

		// Token: 0x0602713A RID: 160058 RVA: 0x005604AE File Offset: 0x0055E6AE
		public static Offset<ISunSpiritBlockExtraRange> EndISunSpiritBlockExtraRange(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritBlockExtraRange>(builder.EndTable());
		}

		// Token: 0x0602713B RID: 160059 RVA: 0x005604BC File Offset: 0x0055E6BC
		public ISunSpiritBlockExtraRangeT UnPack()
		{
			ISunSpiritBlockExtraRangeT sunSpiritBlockExtraRangeT = new ISunSpiritBlockExtraRangeT();
			this.UnPackTo(sunSpiritBlockExtraRangeT);
			return sunSpiritBlockExtraRangeT;
		}

		// Token: 0x0602713C RID: 160060 RVA: 0x005604D8 File Offset: 0x0055E6D8
		public void UnPackTo(ISunSpiritBlockExtraRangeT _o)
		{
			_o.Type = this.Type;
			_o.CylinderRange = ((this.CylinderRange != null) ? this.CylinderRange.Value.UnPack() : null);
		}

		// Token: 0x0602713D RID: 160061 RVA: 0x00560520 File Offset: 0x0055E720
		public static Offset<ISunSpiritBlockExtraRange> Pack(FlatBufferBuilder builder, ISunSpiritBlockExtraRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritBlockExtraRange>);
			}
			Offset<ICylinderTriggerShape> cylinderRangeOffset = (_o.CylinderRange == null) ? default(Offset<ICylinderTriggerShape>) : ICylinderTriggerShape.Pack(builder, _o.CylinderRange);
			return ISunSpiritBlockExtraRange.CreateISunSpiritBlockExtraRange(builder, _o.Type, cylinderRangeOffset);
		}

		// Token: 0x0400F02D RID: 61485
		private Table __p;
	}
}
