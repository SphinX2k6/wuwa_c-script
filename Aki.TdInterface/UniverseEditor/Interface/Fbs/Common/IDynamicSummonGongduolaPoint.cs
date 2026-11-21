using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CE RID: 25550
	public struct IDynamicSummonGongduolaPoint : IFlatbufferObject
	{
		// Token: 0x1700BCC7 RID: 48327
		// (get) Token: 0x0602B65A RID: 177754 RVA: 0x005EA143 File Offset: 0x005E8343
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B65B RID: 177755 RVA: 0x005EA150 File Offset: 0x005E8350
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B65C RID: 177756 RVA: 0x005EA158 File Offset: 0x005E8358
		public static IDynamicSummonGongduolaPoint GetRootAsIDynamicSummonGongduolaPoint(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaPoint.GetRootAsIDynamicSummonGongduolaPoint(_bb, default(IDynamicSummonGongduolaPoint));
		}

		// Token: 0x0602B65D RID: 177757 RVA: 0x005EA174 File Offset: 0x005E8374
		public static IDynamicSummonGongduolaPoint GetRootAsIDynamicSummonGongduolaPoint(ByteBuffer _bb, IDynamicSummonGongduolaPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B65E RID: 177758 RVA: 0x005EA191 File Offset: 0x005E8391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B65F RID: 177759 RVA: 0x005EA1A0 File Offset: 0x005E83A0
		public IDynamicSummonGongduolaPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCC8 RID: 48328
		// (get) Token: 0x0602B660 RID: 177760 RVA: 0x005EA1B0 File Offset: 0x005E83B0
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

		// Token: 0x1700BCC9 RID: 48329
		// (get) Token: 0x0602B661 RID: 177761 RVA: 0x005EA1EC File Offset: 0x005E83EC
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

		// Token: 0x0602B662 RID: 177762 RVA: 0x005EA223 File Offset: 0x005E8423
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B663 RID: 177763 RVA: 0x005EA232 File Offset: 0x005E8432
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BCCA RID: 48330
		// (get) Token: 0x0602B664 RID: 177764 RVA: 0x005EA240 File Offset: 0x005E8440
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

		// Token: 0x1700BCCB RID: 48331
		// (get) Token: 0x0602B665 RID: 177765 RVA: 0x005EA2A0 File Offset: 0x005E84A0
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

		// Token: 0x1700BCCC RID: 48332
		// (get) Token: 0x0602B666 RID: 177766 RVA: 0x005EA300 File Offset: 0x005E8500
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

		// Token: 0x0602B667 RID: 177767 RVA: 0x005EA33D File Offset: 0x005E853D
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

		// Token: 0x0602B668 RID: 177768 RVA: 0x005EA371 File Offset: 0x005E8571
		public static void StartIDynamicSummonGongduolaPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B669 RID: 177769 RVA: 0x005EA37A File Offset: 0x005E857A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602B66A RID: 177770 RVA: 0x005EA385 File Offset: 0x005E8585
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		// Token: 0x0602B66B RID: 177771 RVA: 0x005EA395 File Offset: 0x005E8595
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(2, positionOffset.Value, 0);
		}

		// Token: 0x0602B66C RID: 177772 RVA: 0x005EA3A5 File Offset: 0x005E85A5
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(3, rotationOffset.Value, 0);
		}

		// Token: 0x0602B66D RID: 177773 RVA: 0x005EA3B5 File Offset: 0x005E85B5
		public static void AddGravity(FlatBufferBuilder builder, EWorldAxisType gravity)
		{
			builder.AddByte(4, (byte)gravity, 0);
		}

		// Token: 0x0602B66E RID: 177774 RVA: 0x005EA3C0 File Offset: 0x005E85C0
		public static Offset<IDynamicSummonGongduolaPoint> EndIDynamicSummonGongduolaPoint(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaPoint>(builder.EndTable());
		}

		// Token: 0x0602B66F RID: 177775 RVA: 0x005EA3D0 File Offset: 0x005E85D0
		public IDynamicSummonGongduolaPointT UnPack()
		{
			IDynamicSummonGongduolaPointT dynamicSummonGongduolaPointT = new IDynamicSummonGongduolaPointT();
			this.UnPackTo(dynamicSummonGongduolaPointT);
			return dynamicSummonGongduolaPointT;
		}

		// Token: 0x0602B670 RID: 177776 RVA: 0x005EA3EC File Offset: 0x005E85EC
		public void UnPackTo(IDynamicSummonGongduolaPointT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Gravity = this.Gravity;
		}

		// Token: 0x0602B671 RID: 177777 RVA: 0x005EA47C File Offset: 0x005E867C
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

		// Token: 0x040104BD RID: 66749
		private Table __p;
	}
}
