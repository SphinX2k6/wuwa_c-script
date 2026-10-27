using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004458 RID: 17496
	public struct IDangoBrawlBag : IFlatbufferObject
	{
		// Token: 0x17007B54 RID: 31572
		// (get) Token: 0x0601A0BE RID: 106686 RVA: 0x003B8D3C File Offset: 0x003B6F3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0BF RID: 106687 RVA: 0x003B8D49 File Offset: 0x003B6F49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0C0 RID: 106688 RVA: 0x003B8D50 File Offset: 0x003B6F50
		public static IDangoBrawlBag GetRootAsIDangoBrawlBag(ByteBuffer _bb)
		{
			return IDangoBrawlBag.GetRootAsIDangoBrawlBag(_bb, default(IDangoBrawlBag));
		}

		// Token: 0x0601A0C1 RID: 106689 RVA: 0x003B8D6C File Offset: 0x003B6F6C
		public static IDangoBrawlBag GetRootAsIDangoBrawlBag(ByteBuffer _bb, IDangoBrawlBag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0C2 RID: 106690 RVA: 0x003B8D89 File Offset: 0x003B6F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0C3 RID: 106691 RVA: 0x003B8D98 File Offset: 0x003B6F98
		public IDangoBrawlBag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B55 RID: 31573
		// (get) Token: 0x0601A0C4 RID: 106692 RVA: 0x003B8DA8 File Offset: 0x003B6FA8
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

		// Token: 0x17007B56 RID: 31574
		// (get) Token: 0x0601A0C5 RID: 106693 RVA: 0x003B8DE4 File Offset: 0x003B6FE4
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

		// Token: 0x17007B57 RID: 31575
		// (get) Token: 0x0601A0C6 RID: 106694 RVA: 0x003B8E20 File Offset: 0x003B7020
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

		// Token: 0x17007B58 RID: 31576
		// (get) Token: 0x0601A0C7 RID: 106695 RVA: 0x003B8E80 File Offset: 0x003B7080
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

		// Token: 0x17007B59 RID: 31577
		// (get) Token: 0x0601A0C8 RID: 106696 RVA: 0x003B8EC0 File Offset: 0x003B70C0
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

		// Token: 0x17007B5A RID: 31578
		// (get) Token: 0x0601A0C9 RID: 106697 RVA: 0x003B8F00 File Offset: 0x003B7100
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

		// Token: 0x17007B5B RID: 31579
		// (get) Token: 0x0601A0CA RID: 106698 RVA: 0x003B8F40 File Offset: 0x003B7140
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

		// Token: 0x0601A0CB RID: 106699 RVA: 0x003B8F80 File Offset: 0x003B7180
		public static Offset<IDangoBrawlBag> CreateIDangoBrawlBag(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), int DataId = 0, EDangoBrawlDirection Direction = EDangoBrawlDirection.Up, int TemplateId = 0, EDangoBrawlObjectType SubType = EDangoBrawlObjectType.Bag)
		{
			builder.StartTable(7);
			IDangoBrawlBag.AddTemplateId(builder, TemplateId);
			IDangoBrawlBag.AddDataId(builder, DataId);
			IDangoBrawlBag.AddTransform(builder, TransformOffset);
			IDangoBrawlBag.AddId(builder, Id);
			IDangoBrawlBag.AddSubType(builder, SubType);
			IDangoBrawlBag.AddDirection(builder, Direction);
			IDangoBrawlBag.AddType(builder, Type);
			return IDangoBrawlBag.EndIDangoBrawlBag(builder);
		}

		// Token: 0x0601A0CC RID: 106700 RVA: 0x003B8FCF File Offset: 0x003B71CF
		public static void StartIDangoBrawlBag(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A0CD RID: 106701 RVA: 0x003B8FD8 File Offset: 0x003B71D8
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A0CE RID: 106702 RVA: 0x003B8FE3 File Offset: 0x003B71E3
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A0CF RID: 106703 RVA: 0x003B8FEE File Offset: 0x003B71EE
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A0D0 RID: 106704 RVA: 0x003B8FFE File Offset: 0x003B71FE
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(3, dataId, 0);
		}

		// Token: 0x0601A0D1 RID: 106705 RVA: 0x003B9009 File Offset: 0x003B7209
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(4, (byte)direction, 0);
		}

		// Token: 0x0601A0D2 RID: 106706 RVA: 0x003B9014 File Offset: 0x003B7214
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(5, templateId, 0);
		}

		// Token: 0x0601A0D3 RID: 106707 RVA: 0x003B901F File Offset: 0x003B721F
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(6, (byte)subType, 0);
		}

		// Token: 0x0601A0D4 RID: 106708 RVA: 0x003B902A File Offset: 0x003B722A
		public static Offset<IDangoBrawlBag> EndIDangoBrawlBag(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlBag>(builder.EndTable());
		}

		// Token: 0x0601A0D5 RID: 106709 RVA: 0x003B9038 File Offset: 0x003B7238
		public IDangoBrawlBagT UnPack()
		{
			IDangoBrawlBagT dangoBrawlBagT = new IDangoBrawlBagT();
			this.UnPackTo(dangoBrawlBagT);
			return dangoBrawlBagT;
		}

		// Token: 0x0601A0D6 RID: 106710 RVA: 0x003B9054 File Offset: 0x003B7254
		public void UnPackTo(IDangoBrawlBagT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.DataId = this.DataId;
			_o.Direction = this.Direction;
			_o.TemplateId = this.TemplateId;
			_o.SubType = this.SubType;
		}

		// Token: 0x0601A0D7 RID: 106711 RVA: 0x003B90D8 File Offset: 0x003B72D8
		public static Offset<IDangoBrawlBag> Pack(FlatBufferBuilder builder, IDangoBrawlBagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlBag>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlBag.CreateIDangoBrawlBag(builder, _o.Id, _o.Type, transformOffset, _o.DataId, _o.Direction, _o.TemplateId, _o.SubType);
		}

		// Token: 0x0400C42F RID: 50223
		private Table __p;
	}
}
