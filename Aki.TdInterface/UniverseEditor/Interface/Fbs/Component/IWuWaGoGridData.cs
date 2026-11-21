using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C3 RID: 25027
	public struct IWuWaGoGridData : IFlatbufferObject
	{
		// Token: 0x1700BA9B RID: 47771
		// (get) Token: 0x0602A8CB RID: 174283 RVA: 0x005CD783 File Offset: 0x005CB983
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A8CC RID: 174284 RVA: 0x005CD790 File Offset: 0x005CB990
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A8CD RID: 174285 RVA: 0x005CD798 File Offset: 0x005CB998
		public static IWuWaGoGridData GetRootAsIWuWaGoGridData(ByteBuffer _bb)
		{
			return IWuWaGoGridData.GetRootAsIWuWaGoGridData(_bb, default(IWuWaGoGridData));
		}

		// Token: 0x0602A8CE RID: 174286 RVA: 0x005CD7B4 File Offset: 0x005CB9B4
		public static IWuWaGoGridData GetRootAsIWuWaGoGridData(ByteBuffer _bb, IWuWaGoGridData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A8CF RID: 174287 RVA: 0x005CD7D1 File Offset: 0x005CB9D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A8D0 RID: 174288 RVA: 0x005CD7E0 File Offset: 0x005CB9E0
		public IWuWaGoGridData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA9C RID: 47772
		// (get) Token: 0x0602A8D1 RID: 174289 RVA: 0x005CD7F0 File Offset: 0x005CB9F0
		public EGridShape GridShape
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGridShape.Vertical;
				}
				return (EGridShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA9D RID: 47773
		// (get) Token: 0x0602A8D2 RID: 174290 RVA: 0x005CD82C File Offset: 0x005CBA2C
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BA9E RID: 47774
		// (get) Token: 0x0602A8D3 RID: 174291 RVA: 0x005CD88C File Offset: 0x005CBA8C
		public IVectorInfo? Rotation
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

		// Token: 0x1700BA9F RID: 47775
		// (get) Token: 0x0602A8D4 RID: 174292 RVA: 0x005CD8EC File Offset: 0x005CBAEC
		public IWuWaGoGridLinkData? GridLinkData
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IWuWaGoGridLinkData?(default(IWuWaGoGridLinkData).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x1700BAA0 RID: 47776
		// (get) Token: 0x0602A8D5 RID: 174293 RVA: 0x005CD940 File Offset: 0x005CBB40
		public IVectorInfo? AttachedGridCenter
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A8D6 RID: 174294 RVA: 0x005CD99E File Offset: 0x005CBB9E
		public static Offset<IWuWaGoGridData> CreateIWuWaGoGridData(FlatBufferBuilder builder, EGridShape GridShape = EGridShape.Vertical, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), IWuWaGoGridLinkDataT GridLinkData = null, Offset<IVectorInfo> AttachedGridCenterOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			IWuWaGoGridData.AddAttachedGridCenter(builder, AttachedGridCenterOffset);
			IWuWaGoGridData.AddGridLinkData(builder, IWuWaGoGridLinkData.Pack(builder, GridLinkData));
			IWuWaGoGridData.AddRotation(builder, RotationOffset);
			IWuWaGoGridData.AddPosition(builder, PositionOffset);
			IWuWaGoGridData.AddGridShape(builder, GridShape);
			return IWuWaGoGridData.EndIWuWaGoGridData(builder);
		}

		// Token: 0x0602A8D7 RID: 174295 RVA: 0x005CD9D8 File Offset: 0x005CBBD8
		public static void StartIWuWaGoGridData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A8D8 RID: 174296 RVA: 0x005CD9E1 File Offset: 0x005CBBE1
		public static void AddGridShape(FlatBufferBuilder builder, EGridShape gridShape)
		{
			builder.AddByte(0, (byte)gridShape, 0);
		}

		// Token: 0x0602A8D9 RID: 174297 RVA: 0x005CD9EC File Offset: 0x005CBBEC
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x0602A8DA RID: 174298 RVA: 0x005CD9FC File Offset: 0x005CBBFC
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x0602A8DB RID: 174299 RVA: 0x005CDA0C File Offset: 0x005CBC0C
		public static void AddGridLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> gridLinkDataOffset)
		{
			builder.AddStruct(3, gridLinkDataOffset.Value, 0);
		}

		// Token: 0x0602A8DC RID: 174300 RVA: 0x005CDA1C File Offset: 0x005CBC1C
		public static void AddAttachedGridCenter(FlatBufferBuilder builder, Offset<IVectorInfo> attachedGridCenterOffset)
		{
			builder.AddOffset(4, attachedGridCenterOffset.Value, 0);
		}

		// Token: 0x0602A8DD RID: 174301 RVA: 0x005CDA2C File Offset: 0x005CBC2C
		public static Offset<IWuWaGoGridData> EndIWuWaGoGridData(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGridData>(builder.EndTable());
		}

		// Token: 0x0602A8DE RID: 174302 RVA: 0x005CDA3C File Offset: 0x005CBC3C
		public IWuWaGoGridDataT UnPack()
		{
			IWuWaGoGridDataT wuWaGoGridDataT = new IWuWaGoGridDataT();
			this.UnPackTo(wuWaGoGridDataT);
			return wuWaGoGridDataT;
		}

		// Token: 0x0602A8DF RID: 174303 RVA: 0x005CDA58 File Offset: 0x005CBC58
		public void UnPackTo(IWuWaGoGridDataT _o)
		{
			_o.GridShape = this.GridShape;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.GridLinkData = ((this.GridLinkData != null) ? this.GridLinkData.Value.UnPack() : null);
			_o.AttachedGridCenter = ((this.AttachedGridCenter != null) ? this.AttachedGridCenter.Value.UnPack() : null);
		}

		// Token: 0x0602A8E0 RID: 174304 RVA: 0x005CDB30 File Offset: 0x005CBD30
		public static Offset<IWuWaGoGridData> Pack(FlatBufferBuilder builder, IWuWaGoGridDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGridData>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			Offset<IVectorInfo> attachedGridCenterOffset = (_o.AttachedGridCenter == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.AttachedGridCenter);
			return IWuWaGoGridData.CreateIWuWaGoGridData(builder, _o.GridShape, positionOffset, rotationOffset, _o.GridLinkData, attachedGridCenterOffset);
		}

		// Token: 0x04010025 RID: 65573
		private Table __p;
	}
}
