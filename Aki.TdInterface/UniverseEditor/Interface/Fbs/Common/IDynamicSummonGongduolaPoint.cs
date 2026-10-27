using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D91 RID: 23953
	public struct IDynamicSummonGongduolaPoint : IFlatbufferObject
	{
		// Token: 0x1700B361 RID: 45921
		// (get) Token: 0x06028FD0 RID: 167888 RVA: 0x005A1413 File Offset: 0x0059F613
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FD1 RID: 167889 RVA: 0x005A1420 File Offset: 0x0059F620
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FD2 RID: 167890 RVA: 0x005A1428 File Offset: 0x0059F628
		public static IDynamicSummonGongduolaPoint GetRootAsIDynamicSummonGongduolaPoint(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaPoint.GetRootAsIDynamicSummonGongduolaPoint(_bb, default(IDynamicSummonGongduolaPoint));
		}

		// Token: 0x06028FD3 RID: 167891 RVA: 0x005A1444 File Offset: 0x0059F644
		public static IDynamicSummonGongduolaPoint GetRootAsIDynamicSummonGongduolaPoint(ByteBuffer _bb, IDynamicSummonGongduolaPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FD4 RID: 167892 RVA: 0x005A1461 File Offset: 0x0059F661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FD5 RID: 167893 RVA: 0x005A1470 File Offset: 0x0059F670
		public IDynamicSummonGongduolaPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B362 RID: 45922
		// (get) Token: 0x06028FD6 RID: 167894 RVA: 0x005A1480 File Offset: 0x0059F680
		public int EntityId
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

		// Token: 0x1700B363 RID: 45923
		// (get) Token: 0x06028FD7 RID: 167895 RVA: 0x005A14BC File Offset: 0x0059F6BC
		public string Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028FD8 RID: 167896 RVA: 0x005A14F3 File Offset: 0x0059F6F3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028FD9 RID: 167897 RVA: 0x005A1502 File Offset: 0x0059F702
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B364 RID: 45924
		// (get) Token: 0x06028FDA RID: 167898 RVA: 0x005A1510 File Offset: 0x0059F710
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B365 RID: 45925
		// (get) Token: 0x06028FDB RID: 167899 RVA: 0x005A1570 File Offset: 0x0059F770
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B366 RID: 45926
		// (get) Token: 0x06028FDC RID: 167900 RVA: 0x005A15D0 File Offset: 0x0059F7D0
		public EWorldAxisType Gravity
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EWorldAxisType.PositiveX;
				}
				return (EWorldAxisType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028FDD RID: 167901 RVA: 0x005A160D File Offset: 0x0059F80D
		public static Offset<IDynamicSummonGongduolaPoint> CreateIDynamicSummonGongduolaPoint(FlatBufferBuilder builder, int EntityId = 0, StringOffset IdOffset = default(StringOffset), Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), EWorldAxisType Gravity = EWorldAxisType.PositiveX)
		{
			builder.StartTable(5);
			IDynamicSummonGongduolaPoint.AddRotation(builder, RotationOffset);
			IDynamicSummonGongduolaPoint.AddPosition(builder, PositionOffset);
			IDynamicSummonGongduolaPoint.AddId(builder, IdOffset);
			IDynamicSummonGongduolaPoint.AddEntityId(builder, EntityId);
			IDynamicSummonGongduolaPoint.AddGravity(builder, Gravity);
			return IDynamicSummonGongduolaPoint.EndIDynamicSummonGongduolaPoint(builder);
		}

		// Token: 0x06028FDE RID: 167902 RVA: 0x005A1641 File Offset: 0x0059F841
		public static void StartIDynamicSummonGongduolaPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028FDF RID: 167903 RVA: 0x005A164A File Offset: 0x0059F84A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06028FE0 RID: 167904 RVA: 0x005A1655 File Offset: 0x0059F855
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x06028FE1 RID: 167905 RVA: 0x005A1665 File Offset: 0x0059F865
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x06028FE2 RID: 167906 RVA: 0x005A1675 File Offset: 0x0059F875
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(3, rotationOffset.Value, 0);
		}

		// Token: 0x06028FE3 RID: 167907 RVA: 0x005A1685 File Offset: 0x0059F885
		public static void AddGravity(FlatBufferBuilder builder, EWorldAxisType gravity)
		{
			builder.AddByte(4, (byte)gravity, 0);
		}

		// Token: 0x06028FE4 RID: 167908 RVA: 0x005A1690 File Offset: 0x0059F890
		public static Offset<IDynamicSummonGongduolaPoint> EndIDynamicSummonGongduolaPoint(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaPoint>(builder.EndTable());
		}

		// Token: 0x06028FE5 RID: 167909 RVA: 0x005A16A0 File Offset: 0x0059F8A0
		public IDynamicSummonGongduolaPointT UnPack()
		{
			IDynamicSummonGongduolaPointT dynamicSummonGongduolaPointT = new IDynamicSummonGongduolaPointT();
			this.UnPackTo(dynamicSummonGongduolaPointT);
			return dynamicSummonGongduolaPointT;
		}

		// Token: 0x06028FE6 RID: 167910 RVA: 0x005A16BC File Offset: 0x0059F8BC
		public void UnPackTo(IDynamicSummonGongduolaPointT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Gravity = this.Gravity;
		}

		// Token: 0x06028FE7 RID: 167911 RVA: 0x005A174C File Offset: 0x0059F94C
		public static Offset<IDynamicSummonGongduolaPoint> Pack(FlatBufferBuilder builder, IDynamicSummonGongduolaPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSummonGongduolaPoint>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IDynamicSummonGongduolaPoint.CreateIDynamicSummonGongduolaPoint(builder, _o.EntityId, idOffset, positionOffset, rotationOffset, _o.Gravity);
		}

		// Token: 0x0400F762 RID: 63330
		private Table __p;
	}
}
