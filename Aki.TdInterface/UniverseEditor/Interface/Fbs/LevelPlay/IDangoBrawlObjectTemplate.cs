using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C9 RID: 18633
	public struct IDangoBrawlObjectTemplate : IFlatbufferObject
	{
		// Token: 0x170081C0 RID: 33216
		// (get) Token: 0x0601B90D RID: 112909 RVA: 0x003E5F5A File Offset: 0x003E415A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B90E RID: 112910 RVA: 0x003E5F67 File Offset: 0x003E4167
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B90F RID: 112911 RVA: 0x003E5F70 File Offset: 0x003E4170
		public static IDangoBrawlObjectTemplate GetRootAsIDangoBrawlObjectTemplate(ByteBuffer _bb)
		{
			return IDangoBrawlObjectTemplate.GetRootAsIDangoBrawlObjectTemplate(_bb, default(IDangoBrawlObjectTemplate));
		}

		// Token: 0x0601B910 RID: 112912 RVA: 0x003E5F8C File Offset: 0x003E418C
		public static IDangoBrawlObjectTemplate GetRootAsIDangoBrawlObjectTemplate(ByteBuffer _bb, IDangoBrawlObjectTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B911 RID: 112913 RVA: 0x003E5FA9 File Offset: 0x003E41A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B912 RID: 112914 RVA: 0x003E5FB8 File Offset: 0x003E41B8
		public IDangoBrawlObjectTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081C1 RID: 33217
		// (get) Token: 0x0601B913 RID: 112915 RVA: 0x003E5FC8 File Offset: 0x003E41C8
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

		// Token: 0x170081C2 RID: 33218
		// (get) Token: 0x0601B914 RID: 112916 RVA: 0x003E6004 File Offset: 0x003E4204
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

		// Token: 0x170081C3 RID: 33219
		// (get) Token: 0x0601B915 RID: 112917 RVA: 0x003E6040 File Offset: 0x003E4240
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

		// Token: 0x170081C4 RID: 33220
		// (get) Token: 0x0601B916 RID: 112918 RVA: 0x003E607C File Offset: 0x003E427C
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

		// Token: 0x0601B917 RID: 112919 RVA: 0x003E60DC File Offset: 0x003E42DC
		public IIntVector2? ShapeCells(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IIntVector2?(default(IIntVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081C5 RID: 33221
		// (get) Token: 0x0601B918 RID: 112920 RVA: 0x003E6140 File Offset: 0x003E4340
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

		// Token: 0x0601B919 RID: 112921 RVA: 0x003E616C File Offset: 0x003E436C
		public IIntVector2? StarCells(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IIntVector2?(default(IIntVector2).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081C6 RID: 33222
		// (get) Token: 0x0601B91A RID: 112922 RVA: 0x003E61D0 File Offset: 0x003E43D0
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

		// Token: 0x170081C7 RID: 33223
		// (get) Token: 0x0601B91B RID: 112923 RVA: 0x003E61FC File Offset: 0x003E43FC
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

		// Token: 0x0601B91C RID: 112924 RVA: 0x003E623C File Offset: 0x003E443C
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

		// Token: 0x0601B91D RID: 112925 RVA: 0x003E628B File Offset: 0x003E448B
		public static void StartIDangoBrawlObjectTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B91E RID: 112926 RVA: 0x003E6294 File Offset: 0x003E4494
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B91F RID: 112927 RVA: 0x003E629F File Offset: 0x003E449F
		public static void AddSubType(FlatBufferBuilder builder, EDangoBrawlObjectType subType)
		{
			builder.AddByte(1, (byte)subType, 0);
		}

		// Token: 0x0601B920 RID: 112928 RVA: 0x003E62AA File Offset: 0x003E44AA
		public static void AddDataId(FlatBufferBuilder builder, int dataId)
		{
			builder.AddInt(2, dataId, 0);
		}

		// Token: 0x0601B921 RID: 112929 RVA: 0x003E62B5 File Offset: 0x003E44B5
		public static void AddLinkCenterOffset(FlatBufferBuilder builder, Offset<IVector2> linkCenterOffsetOffset)
		{
			builder.AddOffset(3, linkCenterOffsetOffset.Value, 0);
		}

		// Token: 0x0601B922 RID: 112930 RVA: 0x003E62C5 File Offset: 0x003E44C5
		public static void AddShapeCells(FlatBufferBuilder builder, VectorOffset shapeCellsOffset)
		{
			builder.AddOffset(4, shapeCellsOffset.Value, 0);
		}

		// Token: 0x0601B923 RID: 112931 RVA: 0x003E62D8 File Offset: 0x003E44D8
		public static VectorOffset CreateShapeCellsVector(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B924 RID: 112932 RVA: 0x003E6318 File Offset: 0x003E4518
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B925 RID: 112933 RVA: 0x003E6332 File Offset: 0x003E4532
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IIntVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B926 RID: 112934 RVA: 0x003E6350 File Offset: 0x003E4550
		public static VectorOffset CreateShapeCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IIntVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B927 RID: 112935 RVA: 0x003E6369 File Offset: 0x003E4569
		public static void StartShapeCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B928 RID: 112936 RVA: 0x003E6374 File Offset: 0x003E4574
		public static void AddStarCells(FlatBufferBuilder builder, VectorOffset starCellsOffset)
		{
			builder.AddOffset(5, starCellsOffset.Value, 0);
		}

		// Token: 0x0601B929 RID: 112937 RVA: 0x003E6384 File Offset: 0x003E4584
		public static VectorOffset CreateStarCellsVector(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B92A RID: 112938 RVA: 0x003E63C4 File Offset: 0x003E45C4
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, Offset<IIntVector2>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B92B RID: 112939 RVA: 0x003E63DE File Offset: 0x003E45DE
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IIntVector2>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IIntVector2>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B92C RID: 112940 RVA: 0x003E63FC File Offset: 0x003E45FC
		public static VectorOffset CreateStarCellsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IIntVector2>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B92D RID: 112941 RVA: 0x003E6415 File Offset: 0x003E4615
		public static void StartStarCellsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B92E RID: 112942 RVA: 0x003E6420 File Offset: 0x003E4620
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0601B92F RID: 112943 RVA: 0x003E642B File Offset: 0x003E462B
		public static Offset<IDangoBrawlObjectTemplate> EndIDangoBrawlObjectTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IDangoBrawlObjectTemplate>(builder.EndTable());
		}

		// Token: 0x0601B930 RID: 112944 RVA: 0x003E6438 File Offset: 0x003E4638
		public IDangoBrawlObjectTemplateT UnPack()
		{
			IDangoBrawlObjectTemplateT dangoBrawlObjectTemplateT = new IDangoBrawlObjectTemplateT();
			this.UnPackTo(dangoBrawlObjectTemplateT);
			return dangoBrawlObjectTemplateT;
		}

		// Token: 0x0601B931 RID: 112945 RVA: 0x003E6454 File Offset: 0x003E4654
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

		// Token: 0x0601B932 RID: 112946 RVA: 0x003E656C File Offset: 0x003E476C
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

		// Token: 0x0400CE75 RID: 52853
		private Table __p;
	}
}
