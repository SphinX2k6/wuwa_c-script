using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAD RID: 23469
	public struct IWuWaGoGridData : IFlatbufferObject
	{
		// Token: 0x1700B153 RID: 45395
		// (get) Token: 0x06028307 RID: 164615 RVA: 0x00585CF3 File Offset: 0x00583EF3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028308 RID: 164616 RVA: 0x00585D00 File Offset: 0x00583F00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028309 RID: 164617 RVA: 0x00585D08 File Offset: 0x00583F08
		public static IWuWaGoGridData GetRootAsIWuWaGoGridData(ByteBuffer _bb)
		{
			return IWuWaGoGridData.GetRootAsIWuWaGoGridData(_bb, default(IWuWaGoGridData));
		}

		// Token: 0x0602830A RID: 164618 RVA: 0x00585D24 File Offset: 0x00583F24
		public static IWuWaGoGridData GetRootAsIWuWaGoGridData(ByteBuffer _bb, IWuWaGoGridData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602830B RID: 164619 RVA: 0x00585D41 File Offset: 0x00583F41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602830C RID: 164620 RVA: 0x00585D50 File Offset: 0x00583F50
		public IWuWaGoGridData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B154 RID: 45396
		// (get) Token: 0x0602830D RID: 164621 RVA: 0x00585D60 File Offset: 0x00583F60
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

		// Token: 0x1700B155 RID: 45397
		// (get) Token: 0x0602830E RID: 164622 RVA: 0x00585D9C File Offset: 0x00583F9C
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

		// Token: 0x1700B156 RID: 45398
		// (get) Token: 0x0602830F RID: 164623 RVA: 0x00585DFC File Offset: 0x00583FFC
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

		// Token: 0x1700B157 RID: 45399
		// (get) Token: 0x06028310 RID: 164624 RVA: 0x00585E5C File Offset: 0x0058405C
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

		// Token: 0x1700B158 RID: 45400
		// (get) Token: 0x06028311 RID: 164625 RVA: 0x00585EB0 File Offset: 0x005840B0
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

		// Token: 0x06028312 RID: 164626 RVA: 0x00585F0E File Offset: 0x0058410E
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

		// Token: 0x06028313 RID: 164627 RVA: 0x00585F48 File Offset: 0x00584148
		public static void StartIWuWaGoGridData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028314 RID: 164628 RVA: 0x00585F51 File Offset: 0x00584151
		public static void AddGridShape(FlatBufferBuilder builder, EGridShape gridShape)
		{
			builder.AddByte(0, (byte)gridShape, 0);
		}

		// Token: 0x06028315 RID: 164629 RVA: 0x00585F5C File Offset: 0x0058415C
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06028316 RID: 164630 RVA: 0x00585F6C File Offset: 0x0058416C
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x06028317 RID: 164631 RVA: 0x00585F7C File Offset: 0x0058417C
		public static void AddGridLinkData(FlatBufferBuilder builder, Offset<IWuWaGoGridLinkData> gridLinkDataOffset)
		{
			builder.AddStruct(3, gridLinkDataOffset.Value, 0);
		}

		// Token: 0x06028318 RID: 164632 RVA: 0x00585F8C File Offset: 0x0058418C
		public static void AddAttachedGridCenter(FlatBufferBuilder builder, Offset<IVectorInfo> attachedGridCenterOffset)
		{
			builder.AddOffset(4, attachedGridCenterOffset.Value, 0);
		}

		// Token: 0x06028319 RID: 164633 RVA: 0x00585F9C File Offset: 0x0058419C
		public static Offset<IWuWaGoGridData> EndIWuWaGoGridData(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoGridData>(builder.EndTable());
		}

		// Token: 0x0602831A RID: 164634 RVA: 0x00585FAC File Offset: 0x005841AC
		public IWuWaGoGridDataT UnPack()
		{
			IWuWaGoGridDataT wuWaGoGridDataT = new IWuWaGoGridDataT();
			this.UnPackTo(wuWaGoGridDataT);
			return wuWaGoGridDataT;
		}

		// Token: 0x0602831B RID: 164635 RVA: 0x00585FC8 File Offset: 0x005841C8
		public void UnPackTo(IWuWaGoGridDataT _o)
		{
			_o.GridShape = this.GridShape;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.GridLinkData = ((this.GridLinkData != null) ? this.GridLinkData.Value.UnPack() : null);
			_o.AttachedGridCenter = ((this.AttachedGridCenter != null) ? this.AttachedGridCenter.Value.UnPack() : null);
		}

		// Token: 0x0602831C RID: 164636 RVA: 0x005860A0 File Offset: 0x005842A0
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

		// Token: 0x0400F31F RID: 62239
		private Table __p;
	}
}
