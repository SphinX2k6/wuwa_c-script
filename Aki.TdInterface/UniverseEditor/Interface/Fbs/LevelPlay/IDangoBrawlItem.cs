using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C3 RID: 18627
	public struct IDangoBrawlItem : IFlatbufferObject
	{
		// Token: 0x170081A2 RID: 33186
		// (get) Token: 0x0601B8B9 RID: 112825 RVA: 0x003E54A2 File Offset: 0x003E36A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B8BA RID: 112826 RVA: 0x003E54AF File Offset: 0x003E36AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B8BB RID: 112827 RVA: 0x003E54B8 File Offset: 0x003E36B8
		public static IDangoBrawlItem GetRootAsIDangoBrawlItem(ByteBuffer _bb)
		{
			return IDangoBrawlItem.GetRootAsIDangoBrawlItem(_bb, default(IDangoBrawlItem));
		}

		// Token: 0x0601B8BC RID: 112828 RVA: 0x003E54D4 File Offset: 0x003E36D4
		public static IDangoBrawlItem GetRootAsIDangoBrawlItem(ByteBuffer _bb, IDangoBrawlItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B8BD RID: 112829 RVA: 0x003E54F1 File Offset: 0x003E36F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B8BE RID: 112830 RVA: 0x003E5500 File Offset: 0x003E3700
		public IDangoBrawlItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081A3 RID: 33187
		// (get) Token: 0x0601B8BF RID: 112831 RVA: 0x003E5510 File Offset: 0x003E3710
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

		// Token: 0x170081A4 RID: 33188
		// (get) Token: 0x0601B8C0 RID: 112832 RVA: 0x003E554C File Offset: 0x003E374C
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

		// Token: 0x170081A5 RID: 33189
		// (get) Token: 0x0601B8C1 RID: 112833 RVA: 0x003E5588 File Offset: 0x003E3788
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

		// Token: 0x170081A6 RID: 33190
		// (get) Token: 0x0601B8C2 RID: 112834 RVA: 0x003E55E8 File Offset: 0x003E37E8
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

		// Token: 0x170081A7 RID: 33191
		// (get) Token: 0x0601B8C3 RID: 112835 RVA: 0x003E5628 File Offset: 0x003E3828
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

		// Token: 0x170081A8 RID: 33192
		// (get) Token: 0x0601B8C4 RID: 112836 RVA: 0x003E5668 File Offset: 0x003E3868
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

		// Token: 0x170081A9 RID: 33193
		// (get) Token: 0x0601B8C5 RID: 112837 RVA: 0x003E56A8 File Offset: 0x003E38A8
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

		// Token: 0x0601B8C6 RID: 112838 RVA: 0x003E56E8 File Offset: 0x003E38E8
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

		// Token: 0x0601B8C7 RID: 112839 RVA: 0x003E5737 File Offset: 0x003E3937
		public static void StartIDangoBrawlItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B8C8 RID: 112840 RVA: 0x003E5740 File Offset: 0x003E3940
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B8C9 RID: 112841 RVA: 0x003E574B File Offset: 0x003E394B
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601B8CA RID: 112842 RVA: 0x003E5756 File Offset: 0x003E3956
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601B8CB RID: 112843 RVA: 0x003E5766 File Offset: 0x003E3966
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(3, dataId, 0);
		}

		// Token: 0x0601B8CC RID: 112844 RVA: 0x003E5771 File Offset: 0x003E3971
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(4, (byte)direction, 0);
		}

		// Token: 0x0601B8CD RID: 112845 RVA: 0x003E577C File Offset: 0x003E397C
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(5, templateId, 0);
		}

		// Token: 0x0601B8CE RID: 112846 RVA: 0x003E5787 File Offset: 0x003E3987
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(6, (byte)subType, 0);
		}

		// Token: 0x0601B8CF RID: 112847 RVA: 0x003E5792 File Offset: 0x003E3992
		public static Offset<IDangoBrawlItem> EndIDangoBrawlItem(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlItem>(builder.EndTable());
		}

		// Token: 0x0601B8D0 RID: 112848 RVA: 0x003E57A0 File Offset: 0x003E39A0
		public IDangoBrawlItemT UnPack()
		{
			IDangoBrawlItemT dangoBrawlItemT = new IDangoBrawlItemT();
			this.UnPackTo(dangoBrawlItemT);
			return dangoBrawlItemT;
		}

		// Token: 0x0601B8D1 RID: 112849 RVA: 0x003E57BC File Offset: 0x003E39BC
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

		// Token: 0x0601B8D2 RID: 112850 RVA: 0x003E5840 File Offset: 0x003E3A40
		public static Offset<IDangoBrawlItem> Pack(FlatBufferBuilder builder, IDangoBrawlItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlItem>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlItem.CreateIDangoBrawlItem(builder, _o.Id, _o.Type, transformOffset, _o.DataId, _o.Direction, _o.TemplateId, _o.SubType);
		}

		// Token: 0x0400CE65 RID: 52837
		private Table __p;
	}
}
