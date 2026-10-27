using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EEF RID: 20207
	public struct IBaseShapeElementalRange : IFlatbufferObject
	{
		// Token: 0x1700914F RID: 37199
		// (get) Token: 0x0601FE5D RID: 130653 RVA: 0x00470631 File Offset: 0x0046E831
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE5E RID: 130654 RVA: 0x0047063E File Offset: 0x0046E83E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE5F RID: 130655 RVA: 0x00470648 File Offset: 0x0046E848
		public static IBaseShapeElementalRange GetRootAsIBaseShapeElementalRange(ByteBuffer _bb)
		{
			return IBaseShapeElementalRange.GetRootAsIBaseShapeElementalRange(_bb, default(IBaseShapeElementalRange));
		}

		// Token: 0x0601FE60 RID: 130656 RVA: 0x00470664 File Offset: 0x0046E864
		public static IBaseShapeElementalRange GetRootAsIBaseShapeElementalRange(ByteBuffer _bb, IBaseShapeElementalRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE61 RID: 130657 RVA: 0x00470681 File Offset: 0x0046E881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE62 RID: 130658 RVA: 0x00470690 File Offset: 0x0046E890
		public IBaseShapeElementalRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009150 RID: 37200
		// (get) Token: 0x0601FE63 RID: 130659 RVA: 0x004706A0 File Offset: 0x0046E8A0
		public EElementalRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalRangeType.BaseShape;
				}
				return (EElementalRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009151 RID: 37201
		// (get) Token: 0x0601FE64 RID: 130660 RVA: 0x004706DC File Offset: 0x0046E8DC
		public TTriggerShape ShapeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FE65 RID: 130661 RVA: 0x00470718 File Offset: 0x0046E918
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FE66 RID: 130662 RVA: 0x0047075C File Offset: 0x0046E95C
		public IActorCollisionTriggerShape ShapeAsIActorCollisionTriggerShape()
		{
			return this.Shape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x0601FE67 RID: 130663 RVA: 0x00470778 File Offset: 0x0046E978
		public IActorRefVolume ShapeAsIActorRefVolume()
		{
			return this.Shape<IActorRefVolume>().Value;
		}

		// Token: 0x0601FE68 RID: 130664 RVA: 0x00470794 File Offset: 0x0046E994
		public IBoxTriggerShape ShapeAsIBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x0601FE69 RID: 130665 RVA: 0x004707B0 File Offset: 0x0046E9B0
		public ICombinationTriggerShape ShapeAsICombinationTriggerShape()
		{
			return this.Shape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x0601FE6A RID: 130666 RVA: 0x004707CC File Offset: 0x0046E9CC
		public IConeTriggerShape ShapeAsIConeTriggerShape()
		{
			return this.Shape<IConeTriggerShape>().Value;
		}

		// Token: 0x0601FE6B RID: 130667 RVA: 0x004707E8 File Offset: 0x0046E9E8
		public ICylinderTriggerShape ShapeAsICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x0601FE6C RID: 130668 RVA: 0x00470804 File Offset: 0x0046EA04
		public IHollowCylinderTriggerShape ShapeAsIHollowCylinderTriggerShape()
		{
			return this.Shape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x0601FE6D RID: 130669 RVA: 0x00470820 File Offset: 0x0046EA20
		public IHollowSphereTriggerShape ShapeAsIHollowSphereTriggerShape()
		{
			return this.Shape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x0601FE6E RID: 130670 RVA: 0x0047083C File Offset: 0x0046EA3C
		public ISphereTriggerShape ShapeAsISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x0601FE6F RID: 130671 RVA: 0x00470858 File Offset: 0x0046EA58
		public ISpotlightTriggerShape ShapeAsISpotlightTriggerShape()
		{
			return this.Shape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x0601FE70 RID: 130672 RVA: 0x00470874 File Offset: 0x0046EA74
		public IVolumeTriggerShape ShapeAsIVolumeTriggerShape()
		{
			return this.Shape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x0601FE71 RID: 130673 RVA: 0x0047088F File Offset: 0x0046EA8F
		public static Offset<IBaseShapeElementalRange> CreateIBaseShapeElementalRange(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape, TTriggerShape Shape_type = TTriggerShape.NONE, int ShapeOffset = 0)
		{
			builder.StartTable(3);
			IBaseShapeElementalRange.AddShape(builder, ShapeOffset);
			IBaseShapeElementalRange.AddShapeType(builder, Shape_type);
			IBaseShapeElementalRange.AddType(builder, Type);
			return IBaseShapeElementalRange.EndIBaseShapeElementalRange(builder);
		}

		// Token: 0x0601FE72 RID: 130674 RVA: 0x004708B3 File Offset: 0x0046EAB3
		public static void StartIBaseShapeElementalRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FE73 RID: 130675 RVA: 0x004708BC File Offset: 0x0046EABC
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE74 RID: 130676 RVA: 0x004708C7 File Offset: 0x0046EAC7
		public static void AddShapeType(FlatBufferBuilder builder, TTriggerShape shapeType)
		{
			builder.AddByte(1, (byte)shapeType, 0);
		}

		// Token: 0x0601FE75 RID: 130677 RVA: 0x004708D2 File Offset: 0x0046EAD2
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(2, shapeOffset, 0);
		}

		// Token: 0x0601FE76 RID: 130678 RVA: 0x004708DD File Offset: 0x0046EADD
		public static Offset<IBaseShapeElementalRange> EndIBaseShapeElementalRange(FlatBufferBuilder builder)
		{
			return new Offset<IBaseShapeElementalRange>(builder.EndTable());
		}

		// Token: 0x0601FE77 RID: 130679 RVA: 0x004708EC File Offset: 0x0046EAEC
		public IBaseShapeElementalRangeT UnPack()
		{
			IBaseShapeElementalRangeT baseShapeElementalRangeT = new IBaseShapeElementalRangeT();
			this.UnPackTo(baseShapeElementalRangeT);
			return baseShapeElementalRangeT;
		}

		// Token: 0x0601FE78 RID: 130680 RVA: 0x00470908 File Offset: 0x0046EB08
		public void UnPackTo(IBaseShapeElementalRangeT _o)
		{
			_o.Type = this.Type;
			_o.Shape = new TTriggerShapeUnion();
			_o.Shape.Type = this.ShapeType;
			switch (this.ShapeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.Shape.Value = ((this.Shape<IActorCollisionTriggerShape>() != null) ? this.Shape<IActorCollisionTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IActorRefVolume:
				_o.Shape.Value = ((this.Shape<IActorRefVolume>() != null) ? this.Shape<IActorRefVolume>().Value.UnPack() : null);
				return;
			case TTriggerShape.IBoxTriggerShape:
				_o.Shape.Value = ((this.Shape<IBoxTriggerShape>() != null) ? this.Shape<IBoxTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICombinationTriggerShape:
				_o.Shape.Value = ((this.Shape<ICombinationTriggerShape>() != null) ? this.Shape<ICombinationTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IConeTriggerShape:
				_o.Shape.Value = ((this.Shape<IConeTriggerShape>() != null) ? this.Shape<IConeTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICylinderTriggerShape:
				_o.Shape.Value = ((this.Shape<ICylinderTriggerShape>() != null) ? this.Shape<ICylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.Shape.Value = ((this.Shape<IHollowCylinderTriggerShape>() != null) ? this.Shape<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.Shape.Value = ((this.Shape<IHollowSphereTriggerShape>() != null) ? this.Shape<IHollowSphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISphereTriggerShape:
				_o.Shape.Value = ((this.Shape<ISphereTriggerShape>() != null) ? this.Shape<ISphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.Shape.Value = ((this.Shape<ISpotlightTriggerShape>() != null) ? this.Shape<ISpotlightTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IVolumeTriggerShape:
				_o.Shape.Value = ((this.Shape<IVolumeTriggerShape>() != null) ? this.Shape<IVolumeTriggerShape>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601FE79 RID: 130681 RVA: 0x00470BDC File Offset: 0x0046EDDC
		public static Offset<IBaseShapeElementalRange> Pack(FlatBufferBuilder builder, IBaseShapeElementalRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseShapeElementalRange>);
			}
			TTriggerShape shape_type = (_o.Shape == null) ? TTriggerShape.NONE : _o.Shape.Type;
			int shapeOffset = (_o.Shape == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.Shape);
			return IBaseShapeElementalRange.CreateIBaseShapeElementalRange(builder, _o.Type, shape_type, shapeOffset);
		}

		// Token: 0x0400DD1B RID: 56603
		private Table __p;
	}
}
