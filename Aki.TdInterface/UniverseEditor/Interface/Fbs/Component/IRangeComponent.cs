using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E03 RID: 24067
	public struct IRangeComponent : IFlatbufferObject
	{
		// Token: 0x1700B167 RID: 45415
		// (get) Token: 0x060282E2 RID: 164578 RVA: 0x0057EBA8 File Offset: 0x0057CDA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282E3 RID: 164579 RVA: 0x0057EBB5 File Offset: 0x0057CDB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282E4 RID: 164580 RVA: 0x0057EBBC File Offset: 0x0057CDBC
		public static IRangeComponent GetRootAsIRangeComponent(ByteBuffer _bb)
		{
			return IRangeComponent.GetRootAsIRangeComponent(_bb, default(IRangeComponent));
		}

		// Token: 0x060282E5 RID: 164581 RVA: 0x0057EBD8 File Offset: 0x0057CDD8
		public static IRangeComponent GetRootAsIRangeComponent(ByteBuffer _bb, IRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282E6 RID: 164582 RVA: 0x0057EBF5 File Offset: 0x0057CDF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282E7 RID: 164583 RVA: 0x0057EC04 File Offset: 0x0057CE04
		public IRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B168 RID: 45416
		// (get) Token: 0x060282E8 RID: 164584 RVA: 0x0057EC14 File Offset: 0x0057CE14
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060282E9 RID: 164585 RVA: 0x0057EC54 File Offset: 0x0057CE54
		public ISetRangeActorCollisionResponseToChannels? SetRangeActorCollisionResponseToChannels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels?(default(ISetRangeActorCollisionResponseToChannels).__assign(this.__p.__vector(num) + j * 2, this.__p.bb));
		}

		// Token: 0x1700B169 RID: 45417
		// (get) Token: 0x060282EA RID: 164586 RVA: 0x0057ECAC File Offset: 0x0057CEAC
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

		// Token: 0x1700B16A RID: 45418
		// (get) Token: 0x060282EB RID: 164587 RVA: 0x0057ECD8 File Offset: 0x0057CED8
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

		// Token: 0x060282EC RID: 164588 RVA: 0x0057ED14 File Offset: 0x0057CF14
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060282ED RID: 164589 RVA: 0x0057ED5C File Offset: 0x0057CF5C
		public IActorCollisionTriggerShape ShapeAsIActorCollisionTriggerShape()
		{
			return this.Shape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060282EE RID: 164590 RVA: 0x0057ED78 File Offset: 0x0057CF78
		public IActorRefVolume ShapeAsIActorRefVolume()
		{
			return this.Shape<IActorRefVolume>().Value;
		}

		// Token: 0x060282EF RID: 164591 RVA: 0x0057ED94 File Offset: 0x0057CF94
		public IBoxTriggerShape ShapeAsIBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x060282F0 RID: 164592 RVA: 0x0057EDB0 File Offset: 0x0057CFB0
		public ICombinationTriggerShape ShapeAsICombinationTriggerShape()
		{
			return this.Shape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060282F1 RID: 164593 RVA: 0x0057EDCC File Offset: 0x0057CFCC
		public IConeTriggerShape ShapeAsIConeTriggerShape()
		{
			return this.Shape<IConeTriggerShape>().Value;
		}

		// Token: 0x060282F2 RID: 164594 RVA: 0x0057EDE8 File Offset: 0x0057CFE8
		public ICylinderTriggerShape ShapeAsICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060282F3 RID: 164595 RVA: 0x0057EE04 File Offset: 0x0057D004
		public IHollowCylinderTriggerShape ShapeAsIHollowCylinderTriggerShape()
		{
			return this.Shape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060282F4 RID: 164596 RVA: 0x0057EE20 File Offset: 0x0057D020
		public IHollowSphereTriggerShape ShapeAsIHollowSphereTriggerShape()
		{
			return this.Shape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060282F5 RID: 164597 RVA: 0x0057EE3C File Offset: 0x0057D03C
		public ISphereTriggerShape ShapeAsISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x060282F6 RID: 164598 RVA: 0x0057EE58 File Offset: 0x0057D058
		public ISpotlightTriggerShape ShapeAsISpotlightTriggerShape()
		{
			return this.Shape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060282F7 RID: 164599 RVA: 0x0057EE74 File Offset: 0x0057D074
		public IVolumeTriggerShape ShapeAsIVolumeTriggerShape()
		{
			return this.Shape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700B16B RID: 45419
		// (get) Token: 0x060282F8 RID: 164600 RVA: 0x0057EE90 File Offset: 0x0057D090
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

		// Token: 0x1700B16C RID: 45420
		// (get) Token: 0x060282F9 RID: 164601 RVA: 0x0057EED0 File Offset: 0x0057D0D0
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

		// Token: 0x060282FA RID: 164602 RVA: 0x0057EF0D File Offset: 0x0057D10D
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

		// Token: 0x060282FB RID: 164603 RVA: 0x0057EF49 File Offset: 0x0057D149
		public static void StartIRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060282FC RID: 164604 RVA: 0x0057EF52 File Offset: 0x0057D152
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060282FD RID: 164605 RVA: 0x0057EF5D File Offset: 0x0057D15D
		public static void AddSetRangeActorCollisionResponseToChannels(FlatBufferBuilder builder, VectorOffset setRangeActorCollisionResponseToChannelsOffset)
		{
			builder.AddOffset(1, setRangeActorCollisionResponseToChannelsOffset.Value, 0);
		}

		// Token: 0x060282FE RID: 164606 RVA: 0x0057EF6D File Offset: 0x0057D16D
		public static void StartSetRangeActorCollisionResponseToChannelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 1);
		}

		// Token: 0x060282FF RID: 164607 RVA: 0x0057EF78 File Offset: 0x0057D178
		public static void AddShapeType(FlatBufferBuilder builder, TTriggerShape shapeType)
		{
			builder.AddByte(2, (byte)shapeType, 0);
		}

		// Token: 0x06028300 RID: 164608 RVA: 0x0057EF83 File Offset: 0x0057D183
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(3, shapeOffset, 0);
		}

		// Token: 0x06028301 RID: 164609 RVA: 0x0057EF8E File Offset: 0x0057D18E
		public static void AddExtraRange(FlatBufferBuilder builder, int extraRange)
		{
			builder.AddInt(4, extraRange, 0);
		}

		// Token: 0x06028302 RID: 164610 RVA: 0x0057EF99 File Offset: 0x0057D199
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06028303 RID: 164611 RVA: 0x0057EFA4 File Offset: 0x0057D1A4
		public static Offset<IRangeComponent> EndIRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRangeComponent>(builder.EndTable());
		}

		// Token: 0x06028304 RID: 164612 RVA: 0x0057EFB4 File Offset: 0x0057D1B4
		public IRangeComponentT UnPack()
		{
			IRangeComponentT rangeComponentT = new IRangeComponentT();
			this.UnPackTo(rangeComponentT);
			return rangeComponentT;
		}

		// Token: 0x06028305 RID: 164613 RVA: 0x0057EFD0 File Offset: 0x0057D1D0
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

		// Token: 0x06028306 RID: 164614 RVA: 0x0057F338 File Offset: 0x0057D538
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

		// Token: 0x0400F9DF RID: 63967
		private Table __p;
	}
}
