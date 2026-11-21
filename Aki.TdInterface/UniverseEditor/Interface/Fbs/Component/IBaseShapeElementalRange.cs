using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005421 RID: 21537
	public struct IBaseShapeElementalRange : IFlatbufferObject
	{
		// Token: 0x170098D1 RID: 39121
		// (get) Token: 0x06021BCD RID: 138189 RVA: 0x004A69C5 File Offset: 0x004A4BC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021BCE RID: 138190 RVA: 0x004A69D2 File Offset: 0x004A4BD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021BCF RID: 138191 RVA: 0x004A69DC File Offset: 0x004A4BDC
		public static IBaseShapeElementalRange GetRootAsIBaseShapeElementalRange(ByteBuffer _bb)
		{
			return IBaseShapeElementalRange.GetRootAsIBaseShapeElementalRange(_bb, default(IBaseShapeElementalRange));
		}

		// Token: 0x06021BD0 RID: 138192 RVA: 0x004A69F8 File Offset: 0x004A4BF8
		public static IBaseShapeElementalRange GetRootAsIBaseShapeElementalRange(ByteBuffer _bb, IBaseShapeElementalRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021BD1 RID: 138193 RVA: 0x004A6A15 File Offset: 0x004A4C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021BD2 RID: 138194 RVA: 0x004A6A24 File Offset: 0x004A4C24
		public IBaseShapeElementalRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098D2 RID: 39122
		// (get) Token: 0x06021BD3 RID: 138195 RVA: 0x004A6A34 File Offset: 0x004A4C34
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

		// Token: 0x170098D3 RID: 39123
		// (get) Token: 0x06021BD4 RID: 138196 RVA: 0x004A6A70 File Offset: 0x004A4C70
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

		// Token: 0x06021BD5 RID: 138197 RVA: 0x004A6AAC File Offset: 0x004A4CAC
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021BD6 RID: 138198 RVA: 0x004A6AF0 File Offset: 0x004A4CF0
		public IActorCollisionTriggerShape ShapeAsIActorCollisionTriggerShape()
		{
			return this.Shape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06021BD7 RID: 138199 RVA: 0x004A6B0C File Offset: 0x004A4D0C
		public IActorRefVolume ShapeAsIActorRefVolume()
		{
			return this.Shape<IActorRefVolume>().Value;
		}

		// Token: 0x06021BD8 RID: 138200 RVA: 0x004A6B28 File Offset: 0x004A4D28
		public IBoxTriggerShape ShapeAsIBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x06021BD9 RID: 138201 RVA: 0x004A6B44 File Offset: 0x004A4D44
		public ICombinationTriggerShape ShapeAsICombinationTriggerShape()
		{
			return this.Shape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06021BDA RID: 138202 RVA: 0x004A6B60 File Offset: 0x004A4D60
		public IConeTriggerShape ShapeAsIConeTriggerShape()
		{
			return this.Shape<IConeTriggerShape>().Value;
		}

		// Token: 0x06021BDB RID: 138203 RVA: 0x004A6B7C File Offset: 0x004A4D7C
		public ICylinderTriggerShape ShapeAsICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06021BDC RID: 138204 RVA: 0x004A6B98 File Offset: 0x004A4D98
		public IHollowCylinderTriggerShape ShapeAsIHollowCylinderTriggerShape()
		{
			return this.Shape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06021BDD RID: 138205 RVA: 0x004A6BB4 File Offset: 0x004A4DB4
		public IHollowSphereTriggerShape ShapeAsIHollowSphereTriggerShape()
		{
			return this.Shape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06021BDE RID: 138206 RVA: 0x004A6BD0 File Offset: 0x004A4DD0
		public ISphereTriggerShape ShapeAsISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x06021BDF RID: 138207 RVA: 0x004A6BEC File Offset: 0x004A4DEC
		public ISpotlightTriggerShape ShapeAsISpotlightTriggerShape()
		{
			return this.Shape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06021BE0 RID: 138208 RVA: 0x004A6C08 File Offset: 0x004A4E08
		public IVolumeTriggerShape ShapeAsIVolumeTriggerShape()
		{
			return this.Shape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x06021BE1 RID: 138209 RVA: 0x004A6C23 File Offset: 0x004A4E23
		public static Offset<IBaseShapeElementalRange> CreateIBaseShapeElementalRange(FlatBufferBuilder builder, EElementalRangeType Type = EElementalRangeType.BaseShape, TTriggerShape Shape_type = TTriggerShape.NONE, int ShapeOffset = 0)
		{
			builder.StartTable(3);
			IBaseShapeElementalRange.AddShape(builder, ShapeOffset);
			IBaseShapeElementalRange.AddShapeType(builder, Shape_type);
			IBaseShapeElementalRange.AddType(builder, Type);
			return IBaseShapeElementalRange.EndIBaseShapeElementalRange(builder);
		}

		// Token: 0x06021BE2 RID: 138210 RVA: 0x004A6C47 File Offset: 0x004A4E47
		public static void StartIBaseShapeElementalRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021BE3 RID: 138211 RVA: 0x004A6C50 File Offset: 0x004A4E50
		public static void AddType(FlatBufferBuilder builder, EElementalRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021BE4 RID: 138212 RVA: 0x004A6C5B File Offset: 0x004A4E5B
		public static void AddShapeType(FlatBufferBuilder builder, TTriggerShape shapeType)
		{
			builder.AddByte(1, (byte)shapeType, 0);
		}

		// Token: 0x06021BE5 RID: 138213 RVA: 0x004A6C66 File Offset: 0x004A4E66
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(2, shapeOffset, 0);
		}

		// Token: 0x06021BE6 RID: 138214 RVA: 0x004A6C71 File Offset: 0x004A4E71
		public static Offset<IBaseShapeElementalRange> EndIBaseShapeElementalRange(FlatBufferBuilder builder)
		{
			return new Offset<IBaseShapeElementalRange>(builder.EndTable());
		}

		// Token: 0x06021BE7 RID: 138215 RVA: 0x004A6C80 File Offset: 0x004A4E80
		public IBaseShapeElementalRangeT UnPack()
		{
			IBaseShapeElementalRangeT baseShapeElementalRangeT = new IBaseShapeElementalRangeT();
			this.UnPackTo(baseShapeElementalRangeT);
			return baseShapeElementalRangeT;
		}

		// Token: 0x06021BE8 RID: 138216 RVA: 0x004A6C9C File Offset: 0x004A4E9C
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

		// Token: 0x06021BE9 RID: 138217 RVA: 0x004A6F70 File Offset: 0x004A5170
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

		// Token: 0x0400E8CA RID: 59594
		private Table __p;
	}
}
