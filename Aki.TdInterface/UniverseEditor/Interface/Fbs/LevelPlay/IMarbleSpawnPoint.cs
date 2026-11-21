using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200498F RID: 18831
	public struct IMarbleSpawnPoint : IFlatbufferObject
	{
		// Token: 0x170083CD RID: 33741
		// (get) Token: 0x0601C1AE RID: 115118 RVA: 0x003F8C93 File Offset: 0x003F6E93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1AF RID: 115119 RVA: 0x003F8CA0 File Offset: 0x003F6EA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1B0 RID: 115120 RVA: 0x003F8CA8 File Offset: 0x003F6EA8
		public static IMarbleSpawnPoint GetRootAsIMarbleSpawnPoint(ByteBuffer _bb)
		{
			return IMarbleSpawnPoint.GetRootAsIMarbleSpawnPoint(_bb, default(IMarbleSpawnPoint));
		}

		// Token: 0x0601C1B1 RID: 115121 RVA: 0x003F8CC4 File Offset: 0x003F6EC4
		public static IMarbleSpawnPoint GetRootAsIMarbleSpawnPoint(ByteBuffer _bb, IMarbleSpawnPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1B2 RID: 115122 RVA: 0x003F8CE1 File Offset: 0x003F6EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1B3 RID: 115123 RVA: 0x003F8CF0 File Offset: 0x003F6EF0
		public IMarbleSpawnPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083CE RID: 33742
		// (get) Token: 0x0601C1B4 RID: 115124 RVA: 0x003F8D00 File Offset: 0x003F6F00
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

		// Token: 0x170083CF RID: 33743
		// (get) Token: 0x0601C1B5 RID: 115125 RVA: 0x003F8D3C File Offset: 0x003F6F3C
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

		// Token: 0x170083D0 RID: 33744
		// (get) Token: 0x0601C1B6 RID: 115126 RVA: 0x003F8D78 File Offset: 0x003F6F78
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

		// Token: 0x170083D1 RID: 33745
		// (get) Token: 0x0601C1B7 RID: 115127 RVA: 0x003F8DD8 File Offset: 0x003F6FD8
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

		// Token: 0x0601C1B8 RID: 115128 RVA: 0x003F8E15 File Offset: 0x003F7015
		public static Offset<IMarbleSpawnPoint> CreateIMarbleSpawnPoint(FlatBufferBuilder builder, int Id = 0, ETwoDimensionLevelType Type = ETwoDimensionLevelType.Marble, Offset<ITwoDimensionTransform> TransformOffset = default(Offset<ITwoDimensionTransform>), EMarbleItemType SubType = EMarbleItemType.CommonItem)
		{
			builder.StartTable(4);
			IMarbleSpawnPoint.AddTransform(builder, TransformOffset);
			IMarbleSpawnPoint.AddId(builder, Id);
			IMarbleSpawnPoint.AddSubType(builder, SubType);
			IMarbleSpawnPoint.AddType(builder, Type);
			return IMarbleSpawnPoint.EndIMarbleSpawnPoint(builder);
		}

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x003F8E41 File Offset: 0x003F7041
		public static void StartIMarbleSpawnPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C1BA RID: 115130 RVA: 0x003F8E4A File Offset: 0x003F704A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C1BB RID: 115131 RVA: 0x003F8E55 File Offset: 0x003F7055
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionLevelType type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C1BC RID: 115132 RVA: 0x003F8E60 File Offset: 0x003F7060
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITwoDimensionTransform> transformOffset)
		{
			builder.AddOffset(2, transformOffset.Value, 0);
		}

		// Token: 0x0601C1BD RID: 115133 RVA: 0x003F8E70 File Offset: 0x003F7070
		public static void AddSubType(FlatBufferBuilder builder, EMarbleItemType subType)
		{
			builder.AddByte(3, (byte)subType, 0);
		}

		// Token: 0x0601C1BE RID: 115134 RVA: 0x003F8E7B File Offset: 0x003F707B
		public static Offset<IMarbleSpawnPoint> EndIMarbleSpawnPoint(FlatBufferBuilder builder)
		{
			return new Offset<IMarbleSpawnPoint>(builder.EndTable());
		}

		// Token: 0x0601C1BF RID: 115135 RVA: 0x003F8E88 File Offset: 0x003F7088
		public IMarbleSpawnPointT UnPack()
		{
			IMarbleSpawnPointT marbleSpawnPointT = new IMarbleSpawnPointT();
			this.UnPackTo(marbleSpawnPointT);
			return marbleSpawnPointT;
		}

		// Token: 0x0601C1C0 RID: 115136 RVA: 0x003F8EA4 File Offset: 0x003F70A4
		public void UnPackTo(IMarbleSpawnPointT _o)
		{
			_o.Id = this.Id;
			_o.Type = this.Type;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.SubType = this.SubType;
		}

		// Token: 0x0601C1C1 RID: 115137 RVA: 0x003F8F04 File Offset: 0x003F7104
		public static Offset<IMarbleSpawnPoint> Pack(FlatBufferBuilder builder, IMarbleSpawnPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMarbleSpawnPoint>);
			}
			Offset<ITwoDimensionTransform> transformOffset = (_o.Transform == null) ? default(Offset<ITwoDimensionTransform>) : ITwoDimensionTransform.Pack(builder, _o.Transform);
			return IMarbleSpawnPoint.CreateIMarbleSpawnPoint(builder, _o.Id, _o.Type, transformOffset, _o.SubType);
		}

		// Token: 0x0400CFD8 RID: 53208
		private Table __p;
	}
}
