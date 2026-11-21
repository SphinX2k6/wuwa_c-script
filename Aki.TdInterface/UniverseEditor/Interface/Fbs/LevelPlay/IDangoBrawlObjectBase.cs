using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C6 RID: 18630
	public struct IDangoBrawlObjectBase : IFlatbufferObject
	{
		// Token: 0x170081B1 RID: 33201
		// (get) Token: 0x0601B8E3 RID: 112867 RVA: 0x003E59FE File Offset: 0x003E3BFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8E4 RID: 112868 RVA: 0x003E5A0B File Offset: 0x003E3C0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8E5 RID: 112869 RVA: 0x003E5A14 File Offset: 0x003E3C14
		public static IDangoBrawlObjectBase GetRootAsIDangoBrawlObjectBase(ByteBuffer _bb)
		{
			return IDangoBrawlObjectBase.GetRootAsIDangoBrawlObjectBase(_bb, default(IDangoBrawlObjectBase));
		}

		// Token: 0x0601B8E6 RID: 112870 RVA: 0x003E5A30 File Offset: 0x003E3C30
		public static IDangoBrawlObjectBase GetRootAsIDangoBrawlObjectBase(ByteBuffer _bb, IDangoBrawlObjectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8E7 RID: 112871 RVA: 0x003E5A4D File Offset: 0x003E3C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8E8 RID: 112872 RVA: 0x003E5A5C File Offset: 0x003E3C5C
		public IDangoBrawlObjectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081B2 RID: 33202
		// (get) Token: 0x0601B8E9 RID: 112873 RVA: 0x003E5A6C File Offset: 0x003E3C6C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081B3 RID: 33203
		// (get) Token: 0x0601B8EA RID: 112874 RVA: 0x003E5AA8 File Offset: 0x003E3CA8
		public ETwoDimensionLevelType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETwoDimensionLevelType.Marble;
				}
				return (ETwoDimensionLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081B4 RID: 33204
		// (get) Token: 0x0601B8EB RID: 112875 RVA: 0x003E5AE4 File Offset: 0x003E3CE4
		public ITwoDimensionTransform? Transform
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITwoDimensionTransform?(default(ITwoDimensionTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081B5 RID: 33205
		// (get) Token: 0x0601B8EC RID: 112876 RVA: 0x003E5B44 File Offset: 0x003E3D44
		public EDangoBrawlObjectType SubType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EDangoBrawlObjectType.Bag;
				}
				return (EDangoBrawlObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081B6 RID: 33206
		// (get) Token: 0x0601B8ED RID: 112877 RVA: 0x003E5B84 File Offset: 0x003E3D84
		public int DataId
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

		// Token: 0x170081B7 RID: 33207
		// (get) Token: 0x0601B8EE RID: 112878 RVA: 0x003E5BC4 File Offset: 0x003E3DC4
		public EDangoBrawlDirection Direction
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EDangoBrawlDirection.Up;
				}
				return (EDangoBrawlDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081B8 RID: 33208
		// (get) Token: 0x0601B8EF RID: 112879 RVA: 0x003E5C04 File Offset: 0x003E3E04
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B8F0 RID: 112880 RVA: 0x003E5C44 File Offset: 0x003E3E44
		public static Offset<IDangoBrawlObjectBase> CreateIDangoBrawlObjectBase(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EDangoBrawlObjectType SubType = EDangoBrawlObjectType.Bag, int DataId = 0, EDangoBrawlDirection Direction = EDangoBrawlDirection.Up, int TemplateId = 0)
		{
			builder.StartTable(7);
			IDangoBrawlObjectBase.AddTemplateId(builder, TemplateId);
			IDangoBrawlObjectBase.AddDataId(builder, DataId);
			IDangoBrawlObjectBase.AddTransform(builder, TransformOffset);
			IDangoBrawlObjectBase.AddId(builder, Id);
			IDangoBrawlObjectBase.AddDirection(builder, Direction);
			IDangoBrawlObjectBase.AddSubType(builder, SubType);
			IDangoBrawlObjectBase.AddType(builder, Type);
			return IDangoBrawlObjectBase.EndIDangoBrawlObjectBase(builder);
		}

		// Token: 0x0601B8F1 RID: 112881 RVA: 0x003E5C93 File Offset: 0x003E3E93
		public static void StartIDangoBrawlObjectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B8F2 RID: 112882 RVA: 0x003E5C9C File Offset: 0x003E3E9C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B8F3 RID: 112883 RVA: 0x003E5CA7 File Offset: 0x003E3EA7
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601B8F4 RID: 112884 RVA: 0x003E5CB2 File Offset: 0x003E3EB2
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601B8F5 RID: 112885 RVA: 0x003E5CC2 File Offset: 0x003E3EC2
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601B8F6 RID: 112886 RVA: 0x003E5CCD File Offset: 0x003E3ECD
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(4, dataId, 0);
		}

		// Token: 0x0601B8F7 RID: 112887 RVA: 0x003E5CD8 File Offset: 0x003E3ED8
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x0601B8F8 RID: 112888 RVA: 0x003E5CE3 File Offset: 0x003E3EE3
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(6, templateId, 0);
		}

		// Token: 0x0601B8F9 RID: 112889 RVA: 0x003E5CEE File Offset: 0x003E3EEE
		public static Offset<IDangoBrawlObjectBase> EndIDangoBrawlObjectBase(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlObjectBase>(builder.EndTable());
		}

		// Token: 0x0601B8FA RID: 112890 RVA: 0x003E5CFC File Offset: 0x003E3EFC
		public IDangoBrawlObjectBaseT UnPack()
		{
			IDangoBrawlObjectBaseT dangoBrawlObjectBaseT = new IDangoBrawlObjectBaseT();
			this.UnPackTo(dangoBrawlObjectBaseT);
			return dangoBrawlObjectBaseT;
		}

		// Token: 0x0601B8FB RID: 112891 RVA: 0x003E5D18 File Offset: 0x003E3F18
		public void UnPackTo(IDangoBrawlObjectBaseT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
			_o.DataId = this.DataId;
			_o.Direction = this.Direction;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0601B8FC RID: 112892 RVA: 0x003E5D9C File Offset: 0x003E3F9C
		public static Offset<IDangoBrawlObjectBase> Pack(FlatBufferBuilder builder, IDangoBrawlObjectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlObjectBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlObjectBase.CreateIDangoBrawlObjectBase(builder, _o.Id, _o.Type, transformOffset, _o.SubType, _o.DataId, _o.Direction, _o.TemplateId);
		}

		// Token: 0x0400CE6D RID: 52845
		private Table __p;
	}
}
