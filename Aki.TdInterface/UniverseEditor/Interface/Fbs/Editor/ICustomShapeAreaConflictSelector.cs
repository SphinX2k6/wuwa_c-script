using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004847 RID: 18503
	public struct ICustomShapeAreaConflictSelector : IFlatbufferObject
	{
		// Token: 0x170084D1 RID: 34001
		// (get) Token: 0x0601C9DD RID: 117213 RVA: 0x0040B887 File Offset: 0x00409A87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C9DE RID: 117214 RVA: 0x0040B894 File Offset: 0x00409A94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9DF RID: 117215 RVA: 0x0040B89C File Offset: 0x00409A9C
		public static ICustomShapeAreaConflictSelector GetRootAsICustomShapeAreaConflictSelector(ByteBuffer _bb)
		{
			return ICustomShapeAreaConflictSelector.GetRootAsICustomShapeAreaConflictSelector(_bb, default(ICustomShapeAreaConflictSelector));
		}

		// Token: 0x0601C9E0 RID: 117216 RVA: 0x0040B8B8 File Offset: 0x00409AB8
		public static ICustomShapeAreaConflictSelector GetRootAsICustomShapeAreaConflictSelector(ByteBuffer _bb, ICustomShapeAreaConflictSelector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9E1 RID: 117217 RVA: 0x0040B8D5 File Offset: 0x00409AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9E2 RID: 117218 RVA: 0x0040B8E4 File Offset: 0x00409AE4
		public ICustomShapeAreaConflictSelector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084D2 RID: 34002
		// (get) Token: 0x0601C9E3 RID: 117219 RVA: 0x0040B8F4 File Offset: 0x00409AF4
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

		// Token: 0x170084D3 RID: 34003
		// (get) Token: 0x0601C9E4 RID: 117220 RVA: 0x0040B930 File Offset: 0x00409B30
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

		// Token: 0x0601C9E5 RID: 117221 RVA: 0x0040B96C File Offset: 0x00409B6C
		public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C9E6 RID: 117222 RVA: 0x0040B9B0 File Offset: 0x00409BB0
		public IBoxTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_IBoxTriggerShape()
		{
			return this.Shape<IBoxTriggerShape>().Value;
		}

		// Token: 0x0601C9E7 RID: 117223 RVA: 0x0040B9CC File Offset: 0x00409BCC
		public ICylinderTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_ICylinderTriggerShape()
		{
			return this.Shape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x0601C9E8 RID: 117224 RVA: 0x0040B9E8 File Offset: 0x00409BE8
		public ISphereTriggerShape ShapeAsAki_UniverseEditor_Interface_Fbs_Shape_ISphereTriggerShape()
		{
			return this.Shape<ISphereTriggerShape>().Value;
		}

		// Token: 0x170084D4 RID: 34004
		// (get) Token: 0x0601C9E9 RID: 117225 RVA: 0x0040BA04 File Offset: 0x00409C04
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

		// Token: 0x0601C9EA RID: 117226 RVA: 0x0040BA62 File Offset: 0x00409C62
		public static Offset<ICustomShapeAreaConflictSelector> CreateICustomShapeAreaConflictSelector(FlatBufferBuilder builder, EAreaConflictSelector Type = EAreaConflictSelector.Quest, TAreaConflictCheckTriggerShape Shape_type = TAreaConflictCheckTriggerShape.NONE, int ShapeOffset = 0, Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			ICustomShapeAreaConflictSelector.AddRotator(builder, RotatorOffset);
			ICustomShapeAreaConflictSelector.AddShape(builder, ShapeOffset);
			ICustomShapeAreaConflictSelector.AddShapeType(builder, Shape_type);
			ICustomShapeAreaConflictSelector.AddType(builder, Type);
			return ICustomShapeAreaConflictSelector.EndICustomShapeAreaConflictSelector(builder);
		}

		// Token: 0x0601C9EB RID: 117227 RVA: 0x0040BA8E File Offset: 0x00409C8E
		public static void StartICustomShapeAreaConflictSelector(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C9EC RID: 117228 RVA: 0x0040BA97 File Offset: 0x00409C97
		public static void AddType(FlatBufferBuilder builder, EAreaConflictSelector type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C9ED RID: 117229 RVA: 0x0040BAA2 File Offset: 0x00409CA2
		public static void AddShapeType(FlatBufferBuilder builder, TAreaConflictCheckTriggerShape shapeType)
		{
			builder.AddByte(1, (byte)shapeType, 0);
		}

		// Token: 0x0601C9EE RID: 117230 RVA: 0x0040BAAD File Offset: 0x00409CAD
		public static void AddShape(FlatBufferBuilder builder, int shapeOffset)
		{
			builder.AddOffset(2, shapeOffset, 0);
		}

		// Token: 0x0601C9EF RID: 117231 RVA: 0x0040BAB8 File Offset: 0x00409CB8
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x0601C9F0 RID: 117232 RVA: 0x0040BAC8 File Offset: 0x00409CC8
		public static Offset<ICustomShapeAreaConflictSelector> EndICustomShapeAreaConflictSelector(FlatBufferBuilder builder)
		{
			return new Offset<ICustomShapeAreaConflictSelector>(builder.EndTable());
		}

		// Token: 0x0601C9F1 RID: 117233 RVA: 0x0040BAD8 File Offset: 0x00409CD8
		public ICustomShapeAreaConflictSelectorT UnPack()
		{
			ICustomShapeAreaConflictSelectorT customShapeAreaConflictSelectorT = new ICustomShapeAreaConflictSelectorT();
			this.UnPackTo(customShapeAreaConflictSelectorT);
			return customShapeAreaConflictSelectorT;
		}

		// Token: 0x0601C9F2 RID: 117234 RVA: 0x0040BAF4 File Offset: 0x00409CF4
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

		// Token: 0x0601C9F3 RID: 117235 RVA: 0x0040BC20 File Offset: 0x00409E20
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

		// Token: 0x0400CD79 RID: 52601
		private Table __p;
	}
}
