using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD6 RID: 24022
	public struct IGiantStableValueRegion : IFlatbufferObject
	{
		// Token: 0x1700B3D4 RID: 46036
		// (get) Token: 0x060291DC RID: 168412 RVA: 0x005A4A1F File Offset: 0x005A2C1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291DD RID: 168413 RVA: 0x005A4A2C File Offset: 0x005A2C2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291DE RID: 168414 RVA: 0x005A4A34 File Offset: 0x005A2C34
		public static IGiantStableValueRegion GetRootAsIGiantStableValueRegion(ByteBuffer _bb)
		{
			return IGiantStableValueRegion.GetRootAsIGiantStableValueRegion(_bb, default(IGiantStableValueRegion));
		}

		// Token: 0x060291DF RID: 168415 RVA: 0x005A4A50 File Offset: 0x005A2C50
		public static IGiantStableValueRegion GetRootAsIGiantStableValueRegion(ByteBuffer _bb, IGiantStableValueRegion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291E0 RID: 168416 RVA: 0x005A4A6D File Offset: 0x005A2C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291E1 RID: 168417 RVA: 0x005A4A7C File Offset: 0x005A2C7C
		public IGiantStableValueRegion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3D5 RID: 46037
		// (get) Token: 0x060291E2 RID: 168418 RVA: 0x005A4A8C File Offset: 0x005A2C8C
		public EGiantStableValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantStableValueType.Region;
				}
				return (EGiantStableValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3D6 RID: 46038
		// (get) Token: 0x060291E3 RID: 168419 RVA: 0x005A4AC8 File Offset: 0x005A2CC8
		public EGiantEcoType EcoType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantEcoType.Fire;
				}
				return (EGiantEcoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3D7 RID: 46039
		// (get) Token: 0x060291E4 RID: 168420 RVA: 0x005A4B04 File Offset: 0x005A2D04
		public IGiantStableValueRange? Range
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValueRange?(default(IGiantStableValueRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060291E5 RID: 168421 RVA: 0x005A4B61 File Offset: 0x005A2D61
		public static Offset<IGiantStableValueRegion> CreateIGiantStableValueRegion(FlatBufferBuilder builder, EGiantStableValueType Type = EGiantStableValueType.Region, EGiantEcoType EcoType = EGiantEcoType.Fire, Offset<IGiantStableValueRange> RangeOffset = default(Offset<IGiantStableValueRange>))
		{
			builder.StartTable(3);
			IGiantStableValueRegion.AddRange(builder, RangeOffset);
			IGiantStableValueRegion.AddEcoType(builder, EcoType);
			IGiantStableValueRegion.AddType(builder, Type);
			return IGiantStableValueRegion.EndIGiantStableValueRegion(builder);
		}

		// Token: 0x060291E6 RID: 168422 RVA: 0x005A4B85 File Offset: 0x005A2D85
		public static void StartIGiantStableValueRegion(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060291E7 RID: 168423 RVA: 0x005A4B8E File Offset: 0x005A2D8E
		public static void AddType(FlatBufferBuilder builder, EGiantStableValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060291E8 RID: 168424 RVA: 0x005A4B99 File Offset: 0x005A2D99
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x060291E9 RID: 168425 RVA: 0x005A4BA4 File Offset: 0x005A2DA4
		public static void AddRange(FlatBufferBuilder builder, Offset<IGiantStableValueRange> rangeOffset)
		{
			builder.AddOffset(2, rangeOffset.Value, 0);
		}

		// Token: 0x060291EA RID: 168426 RVA: 0x005A4BB4 File Offset: 0x005A2DB4
		public static Offset<IGiantStableValueRegion> EndIGiantStableValueRegion(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueRegion>(builder.EndTable());
		}

		// Token: 0x060291EB RID: 168427 RVA: 0x005A4BC4 File Offset: 0x005A2DC4
		public IGiantStableValueRegionT UnPack()
		{
			IGiantStableValueRegionT giantStableValueRegionT = new IGiantStableValueRegionT();
			this.UnPackTo(giantStableValueRegionT);
			return giantStableValueRegionT;
		}

		// Token: 0x060291EC RID: 168428 RVA: 0x005A4BE0 File Offset: 0x005A2DE0
		public void UnPackTo(IGiantStableValueRegionT _o)
		{
			_o.Type = this.Type;
			_o.EcoType = this.EcoType;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
		}

		// Token: 0x060291ED RID: 168429 RVA: 0x005A4C34 File Offset: 0x005A2E34
		public static Offset<IGiantStableValueRegion> Pack(FlatBufferBuilder builder, IGiantStableValueRegionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueRegion>);
			}
			Offset<IGiantStableValueRange> rangeOffset = (_o.Range == null) ? default(Offset<IGiantStableValueRange>) : IGiantStableValueRange.Pack(builder, _o.Range);
			return IGiantStableValueRegion.CreateIGiantStableValueRegion(builder, _o.Type, _o.EcoType, rangeOffset);
		}

		// Token: 0x0400F7BC RID: 63420
		private Table __p;
	}
}
