using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DB RID: 29147
	public struct IStopNewMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700D880 RID: 55424
		// (get) Token: 0x06033B2C RID: 211756 RVA: 0x006F5E8E File Offset: 0x006F408E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B2D RID: 211757 RVA: 0x006F5E9B File Offset: 0x006F409B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B2E RID: 211758 RVA: 0x006F5EA4 File Offset: 0x006F40A4
		public static IStopNewMoveWithSpline GetRootAsIStopNewMoveWithSpline(ByteBuffer _bb)
		{
			return IStopNewMoveWithSpline.GetRootAsIStopNewMoveWithSpline(_bb, default(IStopNewMoveWithSpline));
		}

		// Token: 0x06033B2F RID: 211759 RVA: 0x006F5EC0 File Offset: 0x006F40C0
		public static IStopNewMoveWithSpline GetRootAsIStopNewMoveWithSpline(ByteBuffer _bb, IStopNewMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B30 RID: 211760 RVA: 0x006F5EDD File Offset: 0x006F40DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B31 RID: 211761 RVA: 0x006F5EEC File Offset: 0x006F40EC
		public IStopNewMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D881 RID: 55425
		// (get) Token: 0x06033B32 RID: 211762 RVA: 0x006F5EFC File Offset: 0x006F40FC
		public TNewSplineStopTarget StopTargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNewSplineStopTarget.NONE;
				}
				return (TNewSplineStopTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B33 RID: 211763 RVA: 0x006F5F38 File Offset: 0x006F4138
		public TTable? StopTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B34 RID: 211764 RVA: 0x006F5F7C File Offset: 0x006F417C
		public INpcNewSplineStopTarget StopTargetAsINpcNewSplineStopTarget()
		{
			return this.StopTarget<INpcNewSplineStopTarget>().Value;
		}

		// Token: 0x06033B35 RID: 211765 RVA: 0x006F5F98 File Offset: 0x006F4198
		public IPlayerNewSplineStopTarget StopTargetAsIPlayerNewSplineStopTarget()
		{
			return this.StopTarget<IPlayerNewSplineStopTarget>().Value;
		}

		// Token: 0x06033B36 RID: 211766 RVA: 0x006F5FB4 File Offset: 0x006F41B4
		public ISceneNewItemSplineStopTarget StopTargetAsISceneNewItemSplineStopTarget()
		{
			return this.StopTarget<ISceneNewItemSplineStopTarget>().Value;
		}

		// Token: 0x06033B37 RID: 211767 RVA: 0x006F5FD0 File Offset: 0x006F41D0
		public IVehicleNewSplineStopTarget StopTargetAsIVehicleNewSplineStopTarget()
		{
			return this.StopTarget<IVehicleNewSplineStopTarget>().Value;
		}

		// Token: 0x1700D882 RID: 55426
		// (get) Token: 0x06033B38 RID: 211768 RVA: 0x006F5FEC File Offset: 0x006F41EC
		public TStopNewMoveWithSplineType StopTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TStopNewMoveWithSplineType.NONE;
				}
				return (TStopNewMoveWithSplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033B39 RID: 211769 RVA: 0x006F6028 File Offset: 0x006F4228
		public TTable? StopType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033B3A RID: 211770 RVA: 0x006F6070 File Offset: 0x006F4270
		public IStopNewMoveWithSplineAtCurrentPos StopTypeAsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.StopType<IStopNewMoveWithSplineAtCurrentPos>().Value;
		}

		// Token: 0x06033B3B RID: 211771 RVA: 0x006F608C File Offset: 0x006F428C
		public IStopNewMoveWithSplineAtEndPoint StopTypeAsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtEndPoint>().Value;
		}

		// Token: 0x06033B3C RID: 211772 RVA: 0x006F60A8 File Offset: 0x006F42A8
		public IStopNewMoveWithSplineAtStartPoint StopTypeAsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtStartPoint>().Value;
		}

		// Token: 0x06033B3D RID: 211773 RVA: 0x006F60C4 File Offset: 0x006F42C4
		public IStopNewMoveWithSplineAtTargetPoint StopTypeAsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtTargetPoint>().Value;
		}

		// Token: 0x06033B3E RID: 211774 RVA: 0x006F60DF File Offset: 0x006F42DF
		public static Offset<IStopNewMoveWithSpline> CreateIStopNewMoveWithSpline(FlatBufferBuilder builder, TNewSplineStopTarget StopTarget_type = TNewSplineStopTarget.NONE, int StopTargetOffset = 0, TStopNewMoveWithSplineType StopType_type = TStopNewMoveWithSplineType.NONE, int StopTypeOffset = 0)
		{
			builder.StartTable(4);
			IStopNewMoveWithSpline.AddStopType(builder, StopTypeOffset);
			IStopNewMoveWithSpline.AddStopTarget(builder, StopTargetOffset);
			IStopNewMoveWithSpline.AddStopTypeType(builder, StopType_type);
			IStopNewMoveWithSpline.AddStopTargetType(builder, StopTarget_type);
			return IStopNewMoveWithSpline.EndIStopNewMoveWithSpline(builder);
		}

		// Token: 0x06033B3F RID: 211775 RVA: 0x006F610B File Offset: 0x006F430B
		public static void StartIStopNewMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033B40 RID: 211776 RVA: 0x006F6114 File Offset: 0x006F4314
		public static void AddStopTargetType(FlatBufferBuilder builder, TNewSplineStopTarget stopTargetType)
		{
			builder.AddByte(0, (byte)stopTargetType, 0);
		}

		// Token: 0x06033B41 RID: 211777 RVA: 0x006F611F File Offset: 0x006F431F
		public static void AddStopTarget(FlatBufferBuilder builder, int stopTargetOffset)
		{
			builder.AddOffset(1, stopTargetOffset, 0);
		}

		// Token: 0x06033B42 RID: 211778 RVA: 0x006F612A File Offset: 0x006F432A
		public static void AddStopTypeType(FlatBufferBuilder builder, TStopNewMoveWithSplineType stopTypeType)
		{
			builder.AddByte(2, (byte)stopTypeType, 0);
		}

		// Token: 0x06033B43 RID: 211779 RVA: 0x006F6135 File Offset: 0x006F4335
		public static void AddStopType(FlatBufferBuilder builder, int stopTypeOffset)
		{
			builder.AddOffset(3, stopTypeOffset, 0);
		}

		// Token: 0x06033B44 RID: 211780 RVA: 0x006F6140 File Offset: 0x006F4340
		public static Offset<IStopNewMoveWithSpline> EndIStopNewMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06033B45 RID: 211781 RVA: 0x006F6150 File Offset: 0x006F4350
		public IStopNewMoveWithSplineT UnPack()
		{
			IStopNewMoveWithSplineT stopNewMoveWithSplineT = new IStopNewMoveWithSplineT();
			this.UnPackTo(stopNewMoveWithSplineT);
			return stopNewMoveWithSplineT;
		}

		// Token: 0x06033B46 RID: 211782 RVA: 0x006F616C File Offset: 0x006F436C
		public void UnPackTo(IStopNewMoveWithSplineT _o)
		{
			_o.StopTarget = new TNewSplineStopTargetUnion();
			_o.StopTarget.Type = this.StopTargetType;
			switch (this.StopTargetType)
			{
			case TNewSplineStopTarget.INpcNewSplineStopTarget:
				_o.StopTarget.Value = ((this.StopTarget<INpcNewSplineStopTarget>() != null) ? this.StopTarget<INpcNewSplineStopTarget>().Value.UnPack() : null);
				break;
			case TNewSplineStopTarget.IPlayerNewSplineStopTarget:
				_o.StopTarget.Value = ((this.StopTarget<IPlayerNewSplineStopTarget>() != null) ? this.StopTarget<IPlayerNewSplineStopTarget>().Value.UnPack() : null);
				break;
			case TNewSplineStopTarget.ISceneNewItemSplineStopTarget:
				_o.StopTarget.Value = ((this.StopTarget<ISceneNewItemSplineStopTarget>() != null) ? this.StopTarget<ISceneNewItemSplineStopTarget>().Value.UnPack() : null);
				break;
			case TNewSplineStopTarget.IVehicleNewSplineStopTarget:
				_o.StopTarget.Value = ((this.StopTarget<IVehicleNewSplineStopTarget>() != null) ? this.StopTarget<IVehicleNewSplineStopTarget>().Value.UnPack() : null);
				break;
			}
			_o.StopType = new TStopNewMoveWithSplineTypeUnion();
			_o.StopType.Type = this.StopTypeType;
			switch (this.StopTypeType)
			{
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtCurrentPos:
				_o.StopType.Value = ((this.StopType<IStopNewMoveWithSplineAtCurrentPos>() != null) ? this.StopType<IStopNewMoveWithSplineAtCurrentPos>().Value.UnPack() : null);
				return;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtEndPoint:
				_o.StopType.Value = ((this.StopType<IStopNewMoveWithSplineAtEndPoint>() != null) ? this.StopType<IStopNewMoveWithSplineAtEndPoint>().Value.UnPack() : null);
				return;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtStartPoint:
				_o.StopType.Value = ((this.StopType<IStopNewMoveWithSplineAtStartPoint>() != null) ? this.StopType<IStopNewMoveWithSplineAtStartPoint>().Value.UnPack() : null);
				return;
			case TStopNewMoveWithSplineType.IStopNewMoveWithSplineAtTargetPoint:
				_o.StopType.Value = ((this.StopType<IStopNewMoveWithSplineAtTargetPoint>() != null) ? this.StopType<IStopNewMoveWithSplineAtTargetPoint>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033B47 RID: 211783 RVA: 0x006F63B8 File Offset: 0x006F45B8
		public static Offset<IStopNewMoveWithSpline> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSpline>);
			}
			TNewSplineStopTarget stopTarget_type = (_o.StopTarget == null) ? TNewSplineStopTarget.NONE : _o.StopTarget.Type;
			int stopTargetOffset = (_o.StopTarget == null) ? 0 : TNewSplineStopTargetUnion.Pack(builder, _o.StopTarget);
			TStopNewMoveWithSplineType stopType_type = (_o.StopType == null) ? TStopNewMoveWithSplineType.NONE : _o.StopType.Type;
			int stopTypeOffset = (_o.StopType == null) ? 0 : TStopNewMoveWithSplineTypeUnion.Pack(builder, _o.StopType);
			return IStopNewMoveWithSpline.CreateIStopNewMoveWithSpline(builder, stopTarget_type, stopTargetOffset, stopType_type, stopTypeOffset);
		}

		// Token: 0x04011CBC RID: 72892
		private Table __p;
	}
}
