using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C0 RID: 18624
	public struct IDangoBrawlBag : IFlatbufferObject
	{
		// Token: 0x17008193 RID: 33171
		// (get) Token: 0x0601B88F RID: 112783 RVA: 0x003E4F48 File Offset: 0x003E3148
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B890 RID: 112784 RVA: 0x003E4F55 File Offset: 0x003E3155
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B891 RID: 112785 RVA: 0x003E4F5C File Offset: 0x003E315C
		public static IDangoBrawlBag GetRootAsIDangoBrawlBag(ByteBuffer _bb)
		{
			return IDangoBrawlBag.GetRootAsIDangoBrawlBag(_bb, default(IDangoBrawlBag));
		}

		// Token: 0x0601B892 RID: 112786 RVA: 0x003E4F78 File Offset: 0x003E3178
		public static IDangoBrawlBag GetRootAsIDangoBrawlBag(ByteBuffer _bb, IDangoBrawlBag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B893 RID: 112787 RVA: 0x003E4F95 File Offset: 0x003E3195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B894 RID: 112788 RVA: 0x003E4FA4 File Offset: 0x003E31A4
		public IDangoBrawlBag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008194 RID: 33172
		// (get) Token: 0x0601B895 RID: 112789 RVA: 0x003E4FB4 File Offset: 0x003E31B4
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

		// Token: 0x17008195 RID: 33173
		// (get) Token: 0x0601B896 RID: 112790 RVA: 0x003E4FF0 File Offset: 0x003E31F0
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

		// Token: 0x17008196 RID: 33174
		// (get) Token: 0x0601B897 RID: 112791 RVA: 0x003E502C File Offset: 0x003E322C
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

		// Token: 0x17008197 RID: 33175
		// (get) Token: 0x0601B898 RID: 112792 RVA: 0x003E508C File Offset: 0x003E328C
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

		// Token: 0x17008198 RID: 33176
		// (get) Token: 0x0601B899 RID: 112793 RVA: 0x003E50CC File Offset: 0x003E32CC
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

		// Token: 0x17008199 RID: 33177
		// (get) Token: 0x0601B89A RID: 112794 RVA: 0x003E510C File Offset: 0x003E330C
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

		// Token: 0x1700819A RID: 33178
		// (get) Token: 0x0601B89B RID: 112795 RVA: 0x003E514C File Offset: 0x003E334C
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

		// Token: 0x0601B89C RID: 112796 RVA: 0x003E518C File Offset: 0x003E338C
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

		// Token: 0x0601B89D RID: 112797 RVA: 0x003E51DB File Offset: 0x003E33DB
		public static void StartIDangoBrawlBag(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B89E RID: 112798 RVA: 0x003E51E4 File Offset: 0x003E33E4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x003E51EF File Offset: 0x003E33EF
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x003E51FA File Offset: 0x003E33FA
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x003E520A File Offset: 0x003E340A
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(3, dataId, 0);
		}

		// Token: 0x0601B8A2 RID: 112802 RVA: 0x003E5215 File Offset: 0x003E3415
		public static void AddDirection(FlatBufferBuilder builder, EDangoBrawlDirection direction)
		{
			builder.AddByte(4, (byte)direction, 0);
		}

		// Token: 0x0601B8A3 RID: 112803 RVA: 0x003E5220 File Offset: 0x003E3420
		public static void AddTemplateId(FlatBufferBuilder builder, int templateId)
		{
			builder.AddInt(5, templateId, 0);
		}

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x003E522B File Offset: 0x003E342B
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(6, (byte)subType, 0);
		}

		// Token: 0x0601B8A5 RID: 112805 RVA: 0x003E5236 File Offset: 0x003E3436
		public static Offset<IDangoBrawlBag> EndIDangoBrawlBag(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlBag>(builder.EndTable());
		}

		// Token: 0x0601B8A6 RID: 112806 RVA: 0x003E5244 File Offset: 0x003E3444
		public IDangoBrawlBagT UnPack()
		{
			IDangoBrawlBagT dangoBrawlBagT = new IDangoBrawlBagT();
			this.UnPackTo(dangoBrawlBagT);
			return dangoBrawlBagT;
		}

		// Token: 0x0601B8A7 RID: 112807 RVA: 0x003E5260 File Offset: 0x003E3460
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

		// Token: 0x0601B8A8 RID: 112808 RVA: 0x003E52E4 File Offset: 0x003E34E4
		public static Offset<IDangoBrawlBag> Pack(FlatBufferBuilder builder, IDangoBrawlBagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlBag>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IDangoBrawlBag.CreateIDangoBrawlBag(builder, _o.Id, _o.Type, transformOffset, _o.DataId, _o.Direction, _o.TemplateId, _o.SubType);
		}

		// Token: 0x0400CE5D RID: 52829
		private Table __p;
	}
}
