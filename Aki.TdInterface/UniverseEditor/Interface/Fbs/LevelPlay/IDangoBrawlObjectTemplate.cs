using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004461 RID: 17505
	public struct IDangoBrawlObjectTemplate : IFlatbufferObject
	{
		// Token: 0x17007B81 RID: 31617
		// (get) Token: 0x0601A13C RID: 106812 RVA: 0x003B9D4E File Offset: 0x003B7F4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A13D RID: 106813 RVA: 0x003B9D5B File Offset: 0x003B7F5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A13E RID: 106814 RVA: 0x003B9D64 File Offset: 0x003B7F64
		public static IDangoBrawlObjectTemplate GetRootAsIDangoBrawlObjectTemplate(ByteBuffer _bb)
		{
			return IDangoBrawlObjectTemplate.GetRootAsIDangoBrawlObjectTemplate(_bb, default(IDangoBrawlObjectTemplate));
		}

		// Token: 0x0601A13F RID: 106815 RVA: 0x003B9D80 File Offset: 0x003B7F80
		public static IDangoBrawlObjectTemplate GetRootAsIDangoBrawlObjectTemplate(ByteBuffer _bb, IDangoBrawlObjectTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A140 RID: 106816 RVA: 0x003B9D9D File Offset: 0x003B7F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A141 RID: 106817 RVA: 0x003B9DAC File Offset: 0x003B7FAC
		public IDangoBrawlObjectTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B82 RID: 31618
		// (get) Token: 0x0601A142 RID: 106818 RVA: 0x003B9DBC File Offset: 0x003B7FBC
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

		// Token: 0x17007B83 RID: 31619
		// (get) Token: 0x0601A143 RID: 106819 RVA: 0x003B9DF8 File Offset: 0x003B7FF8
		public EDangoBrawlObjectType SubType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDangoBrawlObjectType.Bag;
				}
				return (EDangoBrawlObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B84 RID: 31620
		// (get) Token: 0x0601A144 RID: 106820 RVA: 0x003B9E34 File Offset: 0x003B8034
		public int DataId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B85 RID: 31621
		// (get) Token: 0x0601A145 RID: 106821 RVA: 0x003B9E70 File Offset: 0x003B8070
		public IVector2? LinkCenterOffset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A146 RID: 106822 RVA: 0x003B9ED0 File Offset: 0x003B80D0
		public IIntVector2? ShapeCells(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IIntVector2?(default(IIntVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B86 RID: 31622
		// (get) Token: 0x0601A147 RID: 106823 RVA: 0x003B9F34 File Offset: 0x003B8134
		public int ShapeCellsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601A148 RID: 106824 RVA: 0x003B9F60 File Offset: 0x003B8160
		public IIntVector2? StarCells(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IIntVector2?(default(IIntVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B87 RID: 31623
		// (get) Token: 0x0601A149 RID: 106825 RVA: 0x003B9FC4 File Offset: 0x003B81C4
		public int StarCellsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007B88 RID: 31624
		// (get) Token: 0x0601A14A RID: 106826 RVA: 0x003B9FF0 File Offset: 0x003B81F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A14B RID: 106827 RVA: 0x003BA030 File Offset: 0x003B8230
		public static Offset<IDangoBrawlObjectTemplate> CreateIDangoBrawlObjectTemplate(FlatBufferBuilder builder, int Id = 0, EDangoBrawlObjectType SubType = EDangoBrawlObjectType.Bag, int DataId = 0, Offset<IVector2> LinkCenterOffsetOffset = default(Offset<IVector2>), VectorOffset ShapeCellsOffset = default(VectorOffset), VectorOffset StarCellsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IDangoBrawlObjectTemplate.AddStarCells(builder, StarCellsOffset);
			IDangoBrawlObjectTemplate.AddShapeCells(builder, ShapeCellsOffset);
			IDangoBrawlObjectTemplate.AddLinkCenterOffset(builder, LinkCenterOffsetOffset);
			IDangoBrawlObjectTemplate.AddDataId(builder, DataId);
			IDangoBrawlObjectTemplate.AddId(builder, Id);
			IDangoBrawlObjectTemplate.AddNullMask(builder, NullMask);
			IDangoBrawlObjectTemplate.AddSubType(builder, SubType);
			return IDangoBrawlObjectTemplate.EndIDangoBrawlObjectTemplate(builder);
		}

		// Token: 0x0601A14C RID: 106828 RVA: 0x003BA07F File Offset: 0x003B827F
		public static void StartIDangoBrawlObjectTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601A14D RID: 106829 RVA: 0x003BA088 File Offset: 0x003B8288
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A14E RID: 106830 RVA: 0x003BA093 File Offset: 0x003B8293
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(1, (byte)subType, 0);
		}

		// Token: 0x0601A14F RID: 106831 RVA: 0x003BA09E File Offset: 0x003B829E
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(2, dataId, 0);
		}

		// Token: 0x0601A150 RID: 106832 RVA: 0x003BA0A9 File Offset: 0x003B82A9
		public static void AddLinkCenterOffset(FlatBufferBuilder builder, Offset<IVector2> linkCenterOffsetOffset)
		{
			builder.AddOffset(3, linkCenterOffsetOffset.Value, 0);
		}

		// Token: 0x0601A151 RID: 106833 RVA: 0x003BA0B9 File Offset: 0x003B82B9
		public static void AddShapeCells(FlatBufferBuilder builder, VectorOffset shapeCellsOffset)
		{
			builder.AddOffset(4, shapeCellsOffset.Value, 0);
		}

		// Token: 0x0601A152 RID: 106834 RVA: 0x003BA0CC File Offset: 0x003B82CC
		public static VectorOffset CreateShapeCellsVector(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A153 RID: 106835 RVA: 0x003BA10C File Offset: 0x003B830C
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A154 RID: 106836 RVA: 0x003BA126 File Offset: 0x003B8326
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IIntVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A155 RID: 106837 RVA: 0x003BA144 File Offset: 0x003B8344
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IIntVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A156 RID: 106838 RVA: 0x003BA15D File Offset: 0x003B835D
		public static void StartShapeCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A157 RID: 106839 RVA: 0x003BA168 File Offset: 0x003B8368
		public static void AddStarCells(FlatBufferBuilder builder, VectorOffset starCellsOffset)
		{
			builder.AddOffset(5, starCellsOffset.Value, 0);
		}

		// Token: 0x0601A158 RID: 106840 RVA: 0x003BA178 File Offset: 0x003B8378
		public static VectorOffset CreateStarCellsVector(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A159 RID: 106841 RVA: 0x003BA1B8 File Offset: 0x003B83B8
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A15A RID: 106842 RVA: 0x003BA1D2 File Offset: 0x003B83D2
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IIntVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A15B RID: 106843 RVA: 0x003BA1F0 File Offset: 0x003B83F0
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IIntVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A15C RID: 106844 RVA: 0x003BA209 File Offset: 0x003B8409
		public static void StartStarCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A15D RID: 106845 RVA: 0x003BA214 File Offset: 0x003B8414
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601A15E RID: 106846 RVA: 0x003BA21F File Offset: 0x003B841F
		public static Offset<IDangoBrawlObjectTemplate> EndIDangoBrawlObjectTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlObjectTemplate>(builder.EndTable());
		}

		// Token: 0x0601A15F RID: 106847 RVA: 0x003BA22C File Offset: 0x003B842C
		public IDangoBrawlObjectTemplateT UnPack()
		{
			IDangoBrawlObjectTemplateT dangoBrawlObjectTemplateT = new IDangoBrawlObjectTemplateT();
			this.UnPackTo(dangoBrawlObjectTemplateT);
			return dangoBrawlObjectTemplateT;
		}

		// Token: 0x0601A160 RID: 106848 RVA: 0x003BA248 File Offset: 0x003B8448
		public void UnPackTo(IDangoBrawlObjectTemplateT _o)
		{
			_o.Id = this.Id;
			_o.SubType = this.SubType;
			_o.DataId = this.DataId;
			_o.LinkCenterOffset = ((this.LinkCenterOffset != null) ? this.LinkCenterOffset.Value.UnPack() : null);
			_o.ShapeCells = new List<IIntVector2T>();
			for (int i = 0; i < this.ShapeCellsLength; i++)
			{
				_o.ShapeCells.Add((this.ShapeCells(i) != null) ? this.ShapeCells(i).Value.UnPack() : null);
			}
			_o.StarCells = new List<IIntVector2T>();
			for (int j = 0; j < this.StarCellsLength; j++)
			{
				_o.StarCells.Add((this.StarCells(j) != null) ? this.StarCells(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A161 RID: 106849 RVA: 0x003BA360 File Offset: 0x003B8560
		public static Offset<IDangoBrawlObjectTemplate> Pack(FlatBufferBuilder builder, IDangoBrawlObjectTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoBrawlObjectTemplate>);
			}
			Offset<IVector2> linkCenterOffsetOffset = (_o.LinkCenterOffset == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.LinkCenterOffset);
			VectorOffset shapeCellsOffset = default(VectorOffset);
			if (_o.ShapeCells != null)
			{
				Offset<IIntVector2>[] array = new Offset<IIntVector2>[_o.ShapeCells.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IIntVector2.Pack(builder, _o.ShapeCells[i]);
				}
				shapeCellsOffset = IDangoBrawlObjectTemplate.CreateShapeCellsVector(builder, array);
			}
			VectorOffset starCellsOffset = default(VectorOffset);
			if (_o.StarCells != null)
			{
				Offset<IIntVector2>[] array2 = new Offset<IIntVector2>[_o.StarCells.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IIntVector2.Pack(builder, _o.StarCells[j]);
				}
				starCellsOffset = IDangoBrawlObjectTemplate.CreateStarCellsVector(builder, array2);
			}
			return IDangoBrawlObjectTemplate.CreateIDangoBrawlObjectTemplate(builder, _o.Id, _o.SubType, _o.DataId, linkCenterOffsetOffset, shapeCellsOffset, starCellsOffset, _o.NullMask);
		}

		// Token: 0x0400C447 RID: 50247
		private Table __p;
	}
}
