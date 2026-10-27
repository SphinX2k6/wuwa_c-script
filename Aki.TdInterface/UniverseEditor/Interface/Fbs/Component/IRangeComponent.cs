using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FC RID: 22524
	public struct IRangeComponent : IFlatbufferObject
	{
		// Token: 0x1700A843 RID: 43075
		// (get) Token: 0x06025DC2 RID: 155074 RVA: 0x00538A1C File Offset: 0x00536C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025DC3 RID: 155075 RVA: 0x00538A29 File Offset: 0x00536C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025DC4 RID: 155076 RVA: 0x00538A30 File Offset: 0x00536C30
		public static IRangeComponent GetRootAsIRangeComponent(ByteBuffer _bb)
		{
			return IRangeComponent.GetRootAsIRangeComponent(_bb, default(IRangeComponent));
		}

		// Token: 0x06025DC5 RID: 155077 RVA: 0x00538A4C File Offset: 0x00536C4C
		public static IRangeComponent GetRootAsIRangeComponent(ByteBuffer _bb, IRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025DC6 RID: 155078 RVA: 0x00538A69 File Offset: 0x00536C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025DC7 RID: 155079 RVA: 0x00538A78 File Offset: 0x00536C78
		public IRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A844 RID: 43076
		// (get) Token: 0x06025DC8 RID: 155080 RVA: 0x00538A88 File Offset: 0x00536C88
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025DC9 RID: 155081 RVA: 0x00538AC8 File Offset: 0x00536CC8
		public ISetRangeActorCollisionResponseToChannels? SetRangeActorCollisionResponseToChannels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels?(default(ISetRangeActorCollisionResponseToChannels).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700A845 RID: 43077
		// (get) Token: 0x06025DCA RID: 155082 RVA: 0x00538B20 File Offset: 0x00536D20
		public int SetRangeActorCollisionResponseToChannelsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A846 RID: 43078
		// (get) Token: 0x06025DCB RID: 155083 RVA: 0x00538B4C File Offset: 0x00536D4C
		public TTriggerShape ShapeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DCC RID: 155084 RVA: 0x00538B88 File Offset: 0x00536D88
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025DCD RID: 155085 RVA: 0x00538BD0 File Offset: 0x00536DD0
		public IActorCollisionTriggerShape ShapeAsIActorCollisionTriggerShape()
		{
			return this.Shape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06025DCE RID: 155086 RVA: 0x00538BEC File Offset: 0x00536DEC
		public IActorRefVolume ShapeAsIActorRefVolume()
		{
			return this.Shape<IActorRefVolume>().Value;
		}

		// Token: 0x06025DCF RID: 155087 RVA: 0x00538C08 File Offset: 0x00536E08
		public IBoxTriggerShape ShapeAsIBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x06025DD0 RID: 155088 RVA: 0x00538C24 File Offset: 0x00536E24
		public ICombinationTriggerShape ShapeAsICombinationTriggerShape()
		{
			return this.Shape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06025DD1 RID: 155089 RVA: 0x00538C40 File Offset: 0x00536E40
		public IConeTriggerShape ShapeAsIConeTriggerShape()
		{
			return this.Shape<IConeTriggerShape>().Value;
		}

		// Token: 0x06025DD2 RID: 155090 RVA: 0x00538C5C File Offset: 0x00536E5C
		public ICylinderTriggerShape ShapeAsICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06025DD3 RID: 155091 RVA: 0x00538C78 File Offset: 0x00536E78
		public IHollowCylinderTriggerShape ShapeAsIHollowCylinderTriggerShape()
		{
			return this.Shape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06025DD4 RID: 155092 RVA: 0x00538C94 File Offset: 0x00536E94
		public IHollowSphereTriggerShape ShapeAsIHollowSphereTriggerShape()
		{
			return this.Shape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06025DD5 RID: 155093 RVA: 0x00538CB0 File Offset: 0x00536EB0
		public ISphereTriggerShape ShapeAsISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x06025DD6 RID: 155094 RVA: 0x00538CCC File Offset: 0x00536ECC
		public ISpotlightTriggerShape ShapeAsISpotlightTriggerShape()
		{
			return this.Shape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06025DD7 RID: 155095 RVA: 0x00538CE8 File Offset: 0x00536EE8
		public IVolumeTriggerShape ShapeAsIVolumeTriggerShape()
		{
			return this.Shape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700A847 RID: 43079
		// (get) Token: 0x06025DD8 RID: 155096 RVA: 0x00538D04 File Offset: 0x00536F04
		public int ExtraRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A848 RID: 43080
		// (get) Token: 0x06025DD9 RID: 155097 RVA: 0x00538D44 File Offset: 0x00536F44
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025DDA RID: 155098 RVA: 0x00538D81 File Offset: 0x00536F81
		public static Offset<IRangeComponent> CreateIRangeComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset SetRangeActorCollisionResponseToChannelsOffset = default(VectorOffset), TTriggerShape Shape_type = TTriggerShape.NONE, int ShapeOffset = 0, int ExtraRange = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IRangeComponent.AddExtraRange(builder, ExtraRange);
			IRangeComponent.AddShape(builder, ShapeOffset);
			IRangeComponent.AddSetRangeActorCollisionResponseToChannels(builder, SetRangeActorCollisionResponseToChannelsOffset);
			IRangeComponent.AddNullMask(builder, NullMask);
			IRangeComponent.AddShapeType(builder, Shape_type);
			IRangeComponent.AddDisabled(builder, Disabled);
			return IRangeComponent.EndIRangeComponent(builder);
		}

		// Token: 0x06025DDB RID: 155099 RVA: 0x00538DBD File Offset: 0x00536FBD
		public static void StartIRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025DDC RID: 155100 RVA: 0x00538DC6 File Offset: 0x00536FC6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025DDD RID: 155101 RVA: 0x00538DD1 File Offset: 0x00536FD1
		public static void AddSetRangeActorCollisionResponseToChannels(FlatBufferBuilder builder, VectorOffset setRangeActorCollisionResponseToChannelsOffset)
		{
			builder.AddOffset(1, setRangeActorCollisionResponseToChannelsOffset.Value, 0);
		}

		// Token: 0x06025DDE RID: 155102 RVA: 0x00538DE1 File Offset: 0x00536FE1
		public static void StartSetRangeActorCollisionResponseToChannelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x06025DDF RID: 155103 RVA: 0x00538DEC File Offset: 0x00536FEC
		public static void AddShapeType(FlatBufferBuilder builder, TTriggerShape shapeType)
		{
			builder.AddByte(2, (byte)shapeType, 0);
		}

		// Token: 0x06025DE0 RID: 155104 RVA: 0x00538DF7 File Offset: 0x00536FF7
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(3, shapeOffset, 0);
		}

		// Token: 0x06025DE1 RID: 155105 RVA: 0x00538E02 File Offset: 0x00537002
		public static void AddExtraRange(FlatBufferBuilder builder, int extraRange)
		{
			builder.AddInt(4, extraRange, 0);
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x00538E0D File Offset: 0x0053700D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025DE3 RID: 155107 RVA: 0x00538E18 File Offset: 0x00537018
		public static Offset<IRangeComponent> EndIRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRangeComponent>(builder.EndTable());
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x00538E28 File Offset: 0x00537028
		public IRangeComponentT UnPack()
		{
			IRangeComponentT rangeComponentT = new IRangeComponentT();
			this.UnPackTo(rangeComponentT);
			return rangeComponentT;
		}

		// Token: 0x06025DE5 RID: 155109 RVA: 0x00538E44 File Offset: 0x00537044
		public void UnPackTo(IRangeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SetRangeActorCollisionResponseToChannels = new List<ISetRangeActorCollisionResponseToChannelsT>();
			for (int i = 0; i < this.SetRangeActorCollisionResponseToChannelsLength; i++)
			{
				_o.SetRangeActorCollisionResponseToChannels.Add((this.SetRangeActorCollisionResponseToChannels(i) != null) ? this.SetRangeActorCollisionResponseToChannels(i).Value.UnPack() : null);
			}
			_o.Shape = new TTriggerShapeUnion();
			_o.Shape.Type = this.ShapeType;
			switch (this.ShapeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.Shape.Value = ((this.Shape<IActorCollisionTriggerShape>() != null) ? this.Shape<IActorCollisionTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IActorRefVolume:
				_o.Shape.Value = ((this.Shape<IActorRefVolume>() != null) ? this.Shape<IActorRefVolume>().Value.UnPack() : null);
				break;
			case TTriggerShape.IBoxTriggerShape:
				_o.Shape.Value = ((this.Shape<IBoxTriggerShape>() != null) ? this.Shape<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICombinationTriggerShape:
				_o.Shape.Value = ((this.Shape<ICombinationTriggerShape>() != null) ? this.Shape<ICombinationTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IConeTriggerShape:
				_o.Shape.Value = ((this.Shape<IConeTriggerShape>() != null) ? this.Shape<IConeTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICylinderTriggerShape:
				_o.Shape.Value = ((this.Shape<ICylinderTriggerShape>() != null) ? this.Shape<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.Shape.Value = ((this.Shape<IHollowCylinderTriggerShape>() != null) ? this.Shape<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.Shape.Value = ((this.Shape<IHollowSphereTriggerShape>() != null) ? this.Shape<IHollowSphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISphereTriggerShape:
				_o.Shape.Value = ((this.Shape<ISphereTriggerShape>() != null) ? this.Shape<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.Shape.Value = ((this.Shape<ISpotlightTriggerShape>() != null) ? this.Shape<ISpotlightTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IVolumeTriggerShape:
				_o.Shape.Value = ((this.Shape<IVolumeTriggerShape>() != null) ? this.Shape<IVolumeTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.ExtraRange = this.ExtraRange;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025DE6 RID: 155110 RVA: 0x005391AC File Offset: 0x005373AC
		public static Offset<IRangeComponent> Pack(FlatBufferBuilder builder, IRangeComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeComponent>);
			}
			VectorOffset setRangeActorCollisionResponseToChannelsOffset = default(VectorOffset);
			if (_o.SetRangeActorCollisionResponseToChannels != null)
			{
				IRangeComponent.StartSetRangeActorCollisionResponseToChannelsVector(builder, _o.SetRangeActorCollisionResponseToChannels.Count);
				for (int i = _o.SetRangeActorCollisionResponseToChannels.Count - 1; i >= 0; i--)
				{
					ISetRangeActorCollisionResponseToChannels.Pack(builder, _o.SetRangeActorCollisionResponseToChannels[i]);
				}
				setRangeActorCollisionResponseToChannelsOffset = builder.EndVector();
			}
			TTriggerShape shape_type = (_o.Shape == null) ? TTriggerShape.NONE : _o.Shape.Type;
			int shapeOffset = (_o.Shape == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.Shape);
			return IRangeComponent.CreateIRangeComponent(builder, _o.Disabled, setRangeActorCollisionResponseToChannelsOffset, shape_type, shapeOffset, _o.ExtraRange, _o.NullMask);
		}

		// Token: 0x0400ECF4 RID: 60660
		private Table __p;
	}
}
