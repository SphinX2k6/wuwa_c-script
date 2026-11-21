using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B0 RID: 31152
	public struct IStopNewMoveWithSpline : IFlatbufferObject
	{
		// Token: 0x1700E479 RID: 58489
		// (get) Token: 0x06036E2E RID: 224814 RVA: 0x007571EE File Offset: 0x007553EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E2F RID: 224815 RVA: 0x007571FB File Offset: 0x007553FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E30 RID: 224816 RVA: 0x00757204 File Offset: 0x00755404
		public static IStopNewMoveWithSpline GetRootAsIStopNewMoveWithSpline(ByteBuffer _bb)
		{
			return IStopNewMoveWithSpline.GetRootAsIStopNewMoveWithSpline(_bb, default(IStopNewMoveWithSpline));
		}

		// Token: 0x06036E31 RID: 224817 RVA: 0x00757220 File Offset: 0x00755420
		public static IStopNewMoveWithSpline GetRootAsIStopNewMoveWithSpline(ByteBuffer _bb, IStopNewMoveWithSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E32 RID: 224818 RVA: 0x0075723D File Offset: 0x0075543D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E33 RID: 224819 RVA: 0x0075724C File Offset: 0x0075544C
		public IStopNewMoveWithSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E47A RID: 58490
		// (get) Token: 0x06036E34 RID: 224820 RVA: 0x0075725C File Offset: 0x0075545C
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

		// Token: 0x06036E35 RID: 224821 RVA: 0x00757298 File Offset: 0x00755498
		public TTable? StopTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036E36 RID: 224822 RVA: 0x007572DC File Offset: 0x007554DC
		public INpcNewSplineStopTarget StopTargetAsINpcNewSplineStopTarget()
		{
			return this.StopTarget<INpcNewSplineStopTarget>().Value;
		}

		// Token: 0x06036E37 RID: 224823 RVA: 0x007572F8 File Offset: 0x007554F8
		public IPlayerNewSplineStopTarget StopTargetAsIPlayerNewSplineStopTarget()
		{
			return this.StopTarget<IPlayerNewSplineStopTarget>().Value;
		}

		// Token: 0x06036E38 RID: 224824 RVA: 0x00757314 File Offset: 0x00755514
		public ISceneNewItemSplineStopTarget StopTargetAsISceneNewItemSplineStopTarget()
		{
			return this.StopTarget<ISceneNewItemSplineStopTarget>().Value;
		}

		// Token: 0x06036E39 RID: 224825 RVA: 0x00757330 File Offset: 0x00755530
		public IVehicleNewSplineStopTarget StopTargetAsIVehicleNewSplineStopTarget()
		{
			return this.StopTarget<IVehicleNewSplineStopTarget>().Value;
		}

		// Token: 0x1700E47B RID: 58491
		// (get) Token: 0x06036E3A RID: 224826 RVA: 0x0075734C File Offset: 0x0075554C
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

		// Token: 0x06036E3B RID: 224827 RVA: 0x00757388 File Offset: 0x00755588
		public TTable? StopType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036E3C RID: 224828 RVA: 0x007573D0 File Offset: 0x007555D0
		public IStopNewMoveWithSplineAtCurrentPos StopTypeAsIStopNewMoveWithSplineAtCurrentPos()
		{
			return this.StopType<IStopNewMoveWithSplineAtCurrentPos>().Value;
		}

		// Token: 0x06036E3D RID: 224829 RVA: 0x007573EC File Offset: 0x007555EC
		public IStopNewMoveWithSplineAtEndPoint StopTypeAsIStopNewMoveWithSplineAtEndPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtEndPoint>().Value;
		}

		// Token: 0x06036E3E RID: 224830 RVA: 0x00757408 File Offset: 0x00755608
		public IStopNewMoveWithSplineAtStartPoint StopTypeAsIStopNewMoveWithSplineAtStartPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtStartPoint>().Value;
		}

		// Token: 0x06036E3F RID: 224831 RVA: 0x00757424 File Offset: 0x00755624
		public IStopNewMoveWithSplineAtTargetPoint StopTypeAsIStopNewMoveWithSplineAtTargetPoint()
		{
			return this.StopType<IStopNewMoveWithSplineAtTargetPoint>().Value;
		}

		// Token: 0x06036E40 RID: 224832 RVA: 0x0075743F File Offset: 0x0075563F
		public static Offset<IStopNewMoveWithSpline> CreateIStopNewMoveWithSpline(FlatBufferBuilder builder, TNewSplineStopTarget StopTarget_type = TNewSplineStopTarget.NONE, int StopTargetOffset = 0, TStopNewMoveWithSplineType StopType_type = TStopNewMoveWithSplineType.NONE, int StopTypeOffset = 0)
		{
			builder.StartTable(4);
			IStopNewMoveWithSpline.AddStopType(builder, StopTypeOffset);
			IStopNewMoveWithSpline.AddStopTarget(builder, StopTargetOffset);
			IStopNewMoveWithSpline.AddStopTypeType(builder, StopType_type);
			IStopNewMoveWithSpline.AddStopTargetType(builder, StopTarget_type);
			return IStopNewMoveWithSpline.EndIStopNewMoveWithSpline(builder);
		}

		// Token: 0x06036E41 RID: 224833 RVA: 0x0075746B File Offset: 0x0075566B
		public static void StartIStopNewMoveWithSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036E42 RID: 224834 RVA: 0x00757474 File Offset: 0x00755674
		public static void AddStopTargetType(FlatBufferBuilder builder, TNewSplineStopTarget stopTargetType)
		{
			builder.AddByte(0, (byte)stopTargetType, 0);
		}

		// Token: 0x06036E43 RID: 224835 RVA: 0x0075747F File Offset: 0x0075567F
		public static void AddStopTarget(FlatBufferBuilder builder, int stopTargetOffset)
		{
			builder.AddOffset(1, stopTargetOffset, 0);
		}

		// Token: 0x06036E44 RID: 224836 RVA: 0x0075748A File Offset: 0x0075568A
		public static void AddStopTypeType(FlatBufferBuilder builder, TStopNewMoveWithSplineType stopTypeType)
		{
			builder.AddByte(2, (byte)stopTypeType, 0);
		}

		// Token: 0x06036E45 RID: 224837 RVA: 0x00757495 File Offset: 0x00755695
		public static void AddStopType(FlatBufferBuilder builder, int stopTypeOffset)
		{
			builder.AddOffset(3, stopTypeOffset, 0);
		}

		// Token: 0x06036E46 RID: 224838 RVA: 0x007574A0 File Offset: 0x007556A0
		public static Offset<IStopNewMoveWithSpline> EndIStopNewMoveWithSpline(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSpline>(builder.EndTable());
		}

		// Token: 0x06036E47 RID: 224839 RVA: 0x007574B0 File Offset: 0x007556B0
		public IStopNewMoveWithSplineT UnPack()
		{
			IStopNewMoveWithSplineT stopNewMoveWithSplineT = new IStopNewMoveWithSplineT();
			this.UnPackTo(stopNewMoveWithSplineT);
			return stopNewMoveWithSplineT;
		}

		// Token: 0x06036E48 RID: 224840 RVA: 0x007574CC File Offset: 0x007556CC
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

		// Token: 0x06036E49 RID: 224841 RVA: 0x00757718 File Offset: 0x00755918
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

		// Token: 0x04012CBE RID: 76990
		private Table __p;
	}
}
