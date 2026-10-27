using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200445B RID: 17499
	public struct IDangoBrawlItem : IFlatbufferObject
	{
		// Token: 0x17007B63 RID: 31587
		// (get) Token: 0x0601A0E8 RID: 106728 RVA: 0x003B9296 File Offset: 0x003B7496
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0E9 RID: 106729 RVA: 0x003B92A3 File Offset: 0x003B74A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0EA RID: 106730 RVA: 0x003B92AC File Offset: 0x003B74AC
		public static IDangoBrawlItem GetRootAsIDangoBrawlItem(ByteBuffer _bb)
		{
			return IDangoBrawlItem.GetRootAsIDangoBrawlItem(_bb, default(IDangoBrawlItem));
		}

		// Token: 0x0601A0EB RID: 106731 RVA: 0x003B92C8 File Offset: 0x003B74C8
		public static IDangoBrawlItem GetRootAsIDangoBrawlItem(ByteBuffer _bb, IDangoBrawlItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0EC RID: 106732 RVA: 0x003B92E5 File Offset: 0x003B74E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0ED RID: 106733 RVA: 0x003B92F4 File Offset: 0x003B74F4
		public IDangoBrawlItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B64 RID: 31588
		// (get) Token: 0x0601A0EE RID: 106734 RVA: 0x003B9304 File Offset: 0x003B7504
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

		// Token: 0x17007B65 RID: 31589
		// (get) Token: 0x0601A0EF RID: 106735 RVA: 0x003B9340 File Offset: 0x003B7540
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

		// Token: 0x17007B66 RID: 31590
		// (get) Token: 0x0601A0F0 RID: 106736 RVA: 0x003B937C File Offset: 0x003B757C
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

		// Token: 0x17007B67 RID: 31591
		// (get) Token: 0x0601A0F1 RID: 106737 RVA: 0x003B93DC File Offset: 0x003B75DC
		public int DataId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B68 RID: 31592
		// (get) Token: 0x0601A0F2 RID: 106738 RVA: 0x003B941C File Offset: 0x003B761C
		public EDangoBrawlDirection Direction
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EDangoBrawlDirection.Up;
				}
				return (EDangoBrawlDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B69 RID: 31593
		// (get) Token: 0x0601A0F3 RID: 106739 RVA: 0x003B945C File Offset: 0x003B765C
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B6A RID: 31594
		// (get) Token: 0x0601A0F4 RID: 106740 RVA: 0x003B949C File Offset: 0x003B769C
		public EDangoBrawlObjectType SubType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return EDangoBrawlObjectType.Bag;
				}
				return (EDangoBrawlObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A0F5 RID: 106741 RVA: 0x003B94DC File Offset: 0x003B76DC
		public static Offset<IDangoBrawlItem> CreateIDangoBrawlItem(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), int DataId = 0, EDangoBrawlDirection Direction = EDangoBrawlDirection.Up, int TemplateId = 0, EDangoBrawlObjectType SubType = EDangoBrawlObjectType.Bag)
		{
			builder.StartTable(7);
			IDangoBrawlItem.AddTemplateId(builder, TemplateId);
			IDangoBrawlItem.AddDataId(builder, DataId);
			IDangoBrawlItem.AddTransform(builder, TransformOffset);
			IDangoBrawlItem.AddId(builder, Id);
			IDangoBrawlItem.AddSubType(builder, SubType);
			IDangoBrawlItem.AddDirection(builder, Direction);
			IDangoBrawlItem.AddType(builder, Type);
			return IDangoBrawlItem.EndIDangoBrawlItem(builder);
		}

		// Token: 0x0601A0F6 RID: 106742 RVA: 0x003B952B File Offset: 0x003B772B
		public static void StartIDangoBrawlItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A0F7 RID: 106743 RVA: 0x003B9534 File Offset: 0x003B7734
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A0F8 RID: 106744 RVA: 0x003B953F File Offset: 0x003B773F
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A0F9 RID: 106745 RVA: 0x003B954A File Offset: 0x003B774A
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A0FA RID: 106746 RVA: 0x003B955A File Offset: 0x003B775A
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(3, dataId, 0);
		}

		// Token: 0x0601A0FB RID: 106747 RVA: 0x003B9565 File Offset: 0x003B7765
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(4, (byte)direction, 0);
		}

		// Token: 0x0601A0FC RID: 106748 RVA: 0x003B9570 File Offset: 0x003B7770
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(5, templateId, 0);
		}

		// Token: 0x0601A0FD RID: 106749 RVA: 0x003B957B File Offset: 0x003B777B
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(6, (byte)subType, 0);
		}

		// Token: 0x0601A0FE RID: 106750 RVA: 0x003B9586 File Offset: 0x003B7786
		public static Offset<IDangoBrawlItem> EndIDangoBrawlItem(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlItem>(builder.EndTable());
		}

		// Token: 0x0601A0FF RID: 106751 RVA: 0x003B9594 File Offset: 0x003B7794
		public IDangoBrawlItemT UnPack()
		{
			IDangoBrawlItemT dangoBrawlItemT = new IDangoBrawlItemT();
			this.UnPackTo(dangoBrawlItemT);
			return dangoBrawlItemT;
		}

		// Token: 0x0601A100 RID: 106752 RVA: 0x003B95B0 File Offset: 0x003B77B0
		public void UnPackTo(IDangoBrawlItemT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.DataId = this.DataId;
			_o.Direction = this.Direction;
			_o.TemplateId = this.TemplateId;
			_o.SubType = this.SubType;
		}

		// Token: 0x0601A101 RID: 106753 RVA: 0x003B9634 File Offset: 0x003B7834
		public static Offset<IDangoBrawlItem> Pack(FlatBufferBuilder builder, IDangoBrawlItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlItem>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlItem.CreateIDangoBrawlItem(builder, _o.Id, _o.Type, transformOffset, _o.DataId, _o.Direction, _o.TemplateId, _o.SubType);
		}

		// Token: 0x0400C437 RID: 50231
		private Table __p;
	}
}
