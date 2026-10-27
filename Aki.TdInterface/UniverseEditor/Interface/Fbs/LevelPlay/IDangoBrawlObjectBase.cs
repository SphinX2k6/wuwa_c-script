using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200445E RID: 17502
	public struct IDangoBrawlObjectBase : IFlatbufferObject
	{
		// Token: 0x17007B72 RID: 31602
		// (get) Token: 0x0601A112 RID: 106770 RVA: 0x003B97F2 File Offset: 0x003B79F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A113 RID: 106771 RVA: 0x003B97FF File Offset: 0x003B79FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A114 RID: 106772 RVA: 0x003B9808 File Offset: 0x003B7A08
		public static IDangoBrawlObjectBase GetRootAsIDangoBrawlObjectBase(ByteBuffer _bb)
		{
			return IDangoBrawlObjectBase.GetRootAsIDangoBrawlObjectBase(_bb, default(IDangoBrawlObjectBase));
		}

		// Token: 0x0601A115 RID: 106773 RVA: 0x003B9824 File Offset: 0x003B7A24
		public static IDangoBrawlObjectBase GetRootAsIDangoBrawlObjectBase(ByteBuffer _bb, IDangoBrawlObjectBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A116 RID: 106774 RVA: 0x003B9841 File Offset: 0x003B7A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A117 RID: 106775 RVA: 0x003B9850 File Offset: 0x003B7A50
		public IDangoBrawlObjectBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B73 RID: 31603
		// (get) Token: 0x0601A118 RID: 106776 RVA: 0x003B9860 File Offset: 0x003B7A60
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

		// Token: 0x17007B74 RID: 31604
		// (get) Token: 0x0601A119 RID: 106777 RVA: 0x003B989C File Offset: 0x003B7A9C
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

		// Token: 0x17007B75 RID: 31605
		// (get) Token: 0x0601A11A RID: 106778 RVA: 0x003B98D8 File Offset: 0x003B7AD8
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

		// Token: 0x17007B76 RID: 31606
		// (get) Token: 0x0601A11B RID: 106779 RVA: 0x003B9938 File Offset: 0x003B7B38
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

		// Token: 0x17007B77 RID: 31607
		// (get) Token: 0x0601A11C RID: 106780 RVA: 0x003B9978 File Offset: 0x003B7B78
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

		// Token: 0x17007B78 RID: 31608
		// (get) Token: 0x0601A11D RID: 106781 RVA: 0x003B99B8 File Offset: 0x003B7BB8
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

		// Token: 0x17007B79 RID: 31609
		// (get) Token: 0x0601A11E RID: 106782 RVA: 0x003B99F8 File Offset: 0x003B7BF8
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

		// Token: 0x0601A11F RID: 106783 RVA: 0x003B9A38 File Offset: 0x003B7C38
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

		// Token: 0x0601A120 RID: 106784 RVA: 0x003B9A87 File Offset: 0x003B7C87
		public static void StartIDangoBrawlObjectBase(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A121 RID: 106785 RVA: 0x003B9A90 File Offset: 0x003B7C90
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A122 RID: 106786 RVA: 0x003B9A9B File Offset: 0x003B7C9B
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A123 RID: 106787 RVA: 0x003B9AA6 File Offset: 0x003B7CA6
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A124 RID: 106788 RVA: 0x003B9AB6 File Offset: 0x003B7CB6
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601A125 RID: 106789 RVA: 0x003B9AC1 File Offset: 0x003B7CC1
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(4, dataId, 0);
		}

		// Token: 0x0601A126 RID: 106790 RVA: 0x003B9ACC File Offset: 0x003B7CCC
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x0601A127 RID: 106791 RVA: 0x003B9AD7 File Offset: 0x003B7CD7
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(6, templateId, 0);
		}

		// Token: 0x0601A128 RID: 106792 RVA: 0x003B9AE2 File Offset: 0x003B7CE2
		public static Offset<IDangoBrawlObjectBase> EndIDangoBrawlObjectBase(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlObjectBase>(builder.EndTable());
		}

		// Token: 0x0601A129 RID: 106793 RVA: 0x003B9AF0 File Offset: 0x003B7CF0
		public IDangoBrawlObjectBaseT UnPack()
		{
			IDangoBrawlObjectBaseT dangoBrawlObjectBaseT = new IDangoBrawlObjectBaseT();
			this.UnPackTo(dangoBrawlObjectBaseT);
			return dangoBrawlObjectBaseT;
		}

		// Token: 0x0601A12A RID: 106794 RVA: 0x003B9B0C File Offset: 0x003B7D0C
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

		// Token: 0x0601A12B RID: 106795 RVA: 0x003B9B90 File Offset: 0x003B7D90
		public static Offset<IDangoBrawlObjectBase> Pack(FlatBufferBuilder builder, IDangoBrawlObjectBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlObjectBase>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlObjectBase.CreateIDangoBrawlObjectBase(builder, _o.Id, _o.Type, transformOffset, _o.SubType, _o.DataId, _o.Direction, _o.TemplateId);
		}

		// Token: 0x0400C43F RID: 50239
		private Table __p;
	}
}
