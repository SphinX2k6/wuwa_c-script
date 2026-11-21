using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CAF RID: 19631
	public struct ICustomShapeAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x17008B1C RID: 35612
		// (get) Token: 0x0601E1DA RID: 123354 RVA: 0x004381D7 File Offset: 0x004363D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E1DB RID: 123355 RVA: 0x004381E4 File Offset: 0x004363E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E1DC RID: 123356 RVA: 0x004381EC File Offset: 0x004363EC
		public static ICustomShapeAreaConflictSelector GetRootAsICustomShapeAreaConflictSelector(ByteBuffer _bb)
		{
			return ICustomShapeAreaConflictSelector.GetRootAsICustomShapeAreaConflictSelector(_bb, default(ICustomShapeAreaConflictSelector));
		}

		// Token: 0x0601E1DD RID: 123357 RVA: 0x00438208 File Offset: 0x00436408
		public static ICustomShapeAreaConflictSelector GetRootAsICustomShapeAreaConflictSelector(ByteBuffer _bb, ICustomShapeAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E1DE RID: 123358 RVA: 0x00438225 File Offset: 0x00436425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E1DF RID: 123359 RVA: 0x00438234 File Offset: 0x00436434
		public ICustomShapeAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B1D RID: 35613
		// (get) Token: 0x0601E1E0 RID: 123360 RVA: 0x00438244 File Offset: 0x00436444
		public EAreaConflictSelector Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAreaConflictSelector.Quest;
				}
				return (EAreaConflictSelector)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B1E RID: 35614
		// (get) Token: 0x0601E1E1 RID: 123361 RVA: 0x00438280 File Offset: 0x00436480
		public TAreaConflictCheckTriggerShape ShapeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TAreaConflictCheckTriggerShape.NONE;
				}
				return (TAreaConflictCheckTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E1E2 RID: 123362 RVA: 0x004382BC File Offset: 0x004364BC
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E1E3 RID: 123363 RVA: 0x00438300 File Offset: 0x00436500
		public IBoxTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x0601E1E4 RID: 123364 RVA: 0x0043831C File Offset: 0x0043651C
		public ICylinderTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x0601E1E5 RID: 123365 RVA: 0x00438338 File Offset: 0x00436538
		public ISphereTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x17008B1F RID: 35615
		// (get) Token: 0x0601E1E6 RID: 123366 RVA: 0x00438354 File Offset: 0x00436554
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601E1E7 RID: 123367 RVA: 0x004383B2 File Offset: 0x004365B2
		public static Offset<ICustomShapeAreaConflictSelector> CreateICustomShapeAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, TAreaConflictCheckTriggerShape Shape_type = TAreaConflictCheckTriggerShape.NONE, int ShapeOffset = 0, Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			ICustomShapeAreaConflictSelector.AddRotator(builder, RotatorOffset);
			ICustomShapeAreaConflictSelector.AddShape(builder, ShapeOffset);
			ICustomShapeAreaConflictSelector.AddShapeType(builder, Shape_type);
			ICustomShapeAreaConflictSelector.AddType(builder, Type);
			return ICustomShapeAreaConflictSelector.EndICustomShapeAreaConflictSelector(builder);
		}

		// Token: 0x0601E1E8 RID: 123368 RVA: 0x004383DE File Offset: 0x004365DE
		public static void StartICustomShapeAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E1E9 RID: 123369 RVA: 0x004383E7 File Offset: 0x004365E7
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E1EA RID: 123370 RVA: 0x004383F2 File Offset: 0x004365F2
		public static void AddShapeType(FlatBufferBuilder builder, TAreaConflictCheckTriggerShape shapeType)
		{
			builder.AddByte(1, (byte)shapeType, 0);
		}

		// Token: 0x0601E1EB RID: 123371 RVA: 0x004383FD File Offset: 0x004365FD
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(2, shapeOffset, 0);
		}

		// Token: 0x0601E1EC RID: 123372 RVA: 0x00438408 File Offset: 0x00436608
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x0601E1ED RID: 123373 RVA: 0x00438418 File Offset: 0x00436618
		public static Offset<ICustomShapeAreaConflictSelector> EndICustomShapeAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<ICustomShapeAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601E1EE RID: 123374 RVA: 0x00438428 File Offset: 0x00436628
		public ICustomShapeAreaConflictSelectorT UnPack()
		{
			ICustomShapeAreaConflictSelectorT customShapeAreaConflictSelectorT = new ICustomShapeAreaConflictSelectorT();
			this.UnPackTo(customShapeAreaConflictSelectorT);
			return customShapeAreaConflictSelectorT;
		}

		// Token: 0x0601E1EF RID: 123375 RVA: 0x00438444 File Offset: 0x00436644
		public void UnPackTo(ICustomShapeAreaConflictSelectorT _o)
		{
			_o.Type = this.Type;
			_o.Shape = new TAreaConflictCheckTriggerShapeUnion();
			_o.Shape.Type = this.ShapeType;
			switch (this.ShapeType)
			{
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape:
				_o.Shape.Value = ((this.Shape<IBoxTriggerShape>() != null) ? this.Shape<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape:
				_o.Shape.Value = ((this.Shape<ICylinderTriggerShape>() != null) ? this.Shape<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TAreaConflictCheckTriggerShape.Aki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape:
				_o.Shape.Value = ((this.Shape<ISphereTriggerShape>() != null) ? this.Shape<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x0601E1F0 RID: 123376 RVA: 0x00438570 File Offset: 0x00436770
		public static Offset<ICustomShapeAreaConflictSelector> Pack(FlatBufferBuilder builder, ICustomShapeAreaConflictSelectorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomShapeAreaConflictSelector>);
			}
			TAreaConflictCheckTriggerShape shape_type = (_o.Shape == null) ? TAreaConflictCheckTriggerShape.NONE : _o.Shape.Type;
			int shapeOffset = (_o.Shape == null) ? 0 : TAreaConflictCheckTriggerShapeUnion.Pack(builder, _o.Shape);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return ICustomShapeAreaConflictSelector.CreateICustomShapeAreaConflictSelector(builder, _o.Type, shape_type, shapeOffset, rotatorOffset);
		}

		// Token: 0x0400D7B4 RID: 55220
		private Table __p;
	}
}
