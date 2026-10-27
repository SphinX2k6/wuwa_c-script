using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004527 RID: 17703
	public struct IMarbleSpawnPoint : IFlatbufferObject
	{
		// Token: 0x17007D8C RID: 32140
		// (get) Token: 0x0601A9D9 RID: 109017 RVA: 0x003CC9F7 File Offset: 0x003CABF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9DA RID: 109018 RVA: 0x003CCA04 File Offset: 0x003CAC04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9DB RID: 109019 RVA: 0x003CCA0C File Offset: 0x003CAC0C
		public static IMarbleSpawnPoint GetRootAsIMarbleSpawnPoint(ByteBuffer _bb)
		{
			return IMarbleSpawnPoint.GetRootAsIMarbleSpawnPoint(_bb, default(IMarbleSpawnPoint));
		}

		// Token: 0x0601A9DC RID: 109020 RVA: 0x003CCA28 File Offset: 0x003CAC28
		public static IMarbleSpawnPoint GetRootAsIMarbleSpawnPoint(ByteBuffer _bb, IMarbleSpawnPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9DD RID: 109021 RVA: 0x003CCA45 File Offset: 0x003CAC45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9DE RID: 109022 RVA: 0x003CCA54 File Offset: 0x003CAC54
		public IMarbleSpawnPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D8D RID: 32141
		// (get) Token: 0x0601A9DF RID: 109023 RVA: 0x003CCA64 File Offset: 0x003CAC64
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

		// Token: 0x17007D8E RID: 32142
		// (get) Token: 0x0601A9E0 RID: 109024 RVA: 0x003CCAA0 File Offset: 0x003CACA0
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

		// Token: 0x17007D8F RID: 32143
		// (get) Token: 0x0601A9E1 RID: 109025 RVA: 0x003CCADC File Offset: 0x003CACDC
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

		// Token: 0x17007D90 RID: 32144
		// (get) Token: 0x0601A9E2 RID: 109026 RVA: 0x003CCB3C File Offset: 0x003CAD3C
		public EMarbleItemType SubType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMarbleItemType.CommonItem;
				}
				return (EMarbleItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A9E3 RID: 109027 RVA: 0x003CCB79 File Offset: 0x003CAD79
		public static Offset<IMarbleSpawnPoint> CreateIMarbleSpawnPoint(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EMarbleItemType SubType = EMarbleItemType.CommonItem)
		{
			builder.StartTable(4);
			IMarbleSpawnPoint.AddTransform(builder, TransformOffset);
			IMarbleSpawnPoint.AddId(builder, Id);
			IMarbleSpawnPoint.AddSubType(builder, SubType);
			IMarbleSpawnPoint.AddType(builder, Type);
			return IMarbleSpawnPoint.EndIMarbleSpawnPoint(builder);
		}

		// Token: 0x0601A9E4 RID: 109028 RVA: 0x003CCBA5 File Offset: 0x003CADA5
		public static void StartIMarbleSpawnPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A9E5 RID: 109029 RVA: 0x003CCBAE File Offset: 0x003CADAE
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A9E6 RID: 109030 RVA: 0x003CCBB9 File Offset: 0x003CADB9
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601A9E7 RID: 109031 RVA: 0x003CCBC4 File Offset: 0x003CADC4
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601A9E8 RID: 109032 RVA: 0x003CCBD4 File Offset: 0x003CADD4
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601A9E9 RID: 109033 RVA: 0x003CCBDF File Offset: 0x003CADDF
		public static Offset<IMarbleSpawnPoint> EndIMarbleSpawnPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleSpawnPoint>(builder.EndTable());
		}

		// Token: 0x0601A9EA RID: 109034 RVA: 0x003CCBEC File Offset: 0x003CADEC
		public IMarbleSpawnPointT UnPack()
		{
			IMarbleSpawnPointT marbleSpawnPointT = new IMarbleSpawnPointT();
			this.UnPackTo(marbleSpawnPointT);
			return marbleSpawnPointT;
		}

		// Token: 0x0601A9EB RID: 109035 RVA: 0x003CCC08 File Offset: 0x003CAE08
		public void UnPackTo(IMarbleSpawnPointT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
		}

		// Token: 0x0601A9EC RID: 109036 RVA: 0x003CCC68 File Offset: 0x003CAE68
		public static Offset<IMarbleSpawnPoint> Pack(FlatBufferBuilder builder, IMarbleSpawnPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleSpawnPoint>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleSpawnPoint.CreateIMarbleSpawnPoint(builder, _o.Id, _o.Type, transformOffset, _o.SubType);
		}

		// Token: 0x0400C5A9 RID: 50601
		private Table __p;
	}
}
