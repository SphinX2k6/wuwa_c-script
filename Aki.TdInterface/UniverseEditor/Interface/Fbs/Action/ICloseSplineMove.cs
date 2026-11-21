using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAA RID: 27306
	public struct ICloseSplineMove : IFlatbufferObject
	{
		// Token: 0x1700C891 RID: 51345
		// (get) Token: 0x0602EDE0 RID: 191968 RVA: 0x00662C98 File Offset: 0x00660E98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDE1 RID: 191969 RVA: 0x00662CA5 File Offset: 0x00660EA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDE2 RID: 191970 RVA: 0x00662CAC File Offset: 0x00660EAC
		public static ICloseSplineMove GetRootAsICloseSplineMove(ByteBuffer _bb)
		{
			return ICloseSplineMove.GetRootAsICloseSplineMove(_bb, default(ICloseSplineMove));
		}

		// Token: 0x0602EDE3 RID: 191971 RVA: 0x00662CC8 File Offset: 0x00660EC8
		public static ICloseSplineMove GetRootAsICloseSplineMove(ByteBuffer _bb, ICloseSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDE4 RID: 191972 RVA: 0x00662CE5 File Offset: 0x00660EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDE5 RID: 191973 RVA: 0x00662CF4 File Offset: 0x00660EF4
		public ICloseSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C892 RID: 51346
		// (get) Token: 0x0602EDE6 RID: 191974 RVA: 0x00662D04 File Offset: 0x00660F04
		public ESplineMoveConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveConfigType.Open;
				}
				return (ESplineMoveConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C893 RID: 51347
		// (get) Token: 0x0602EDE7 RID: 191975 RVA: 0x00662D40 File Offset: 0x00660F40
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EDE8 RID: 191976 RVA: 0x00662D7C File Offset: 0x00660F7C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EDE9 RID: 191977 RVA: 0x00662DC0 File Offset: 0x00660FC0
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602EDEA RID: 191978 RVA: 0x00662DDC File Offset: 0x00660FDC
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602EDEB RID: 191979 RVA: 0x00662DF8 File Offset: 0x00660FF8
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602EDEC RID: 191980 RVA: 0x00662E14 File Offset: 0x00661014
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602EDED RID: 191981 RVA: 0x00662E30 File Offset: 0x00661030
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700C894 RID: 51348
		// (get) Token: 0x0602EDEE RID: 191982 RVA: 0x00662E4C File Offset: 0x0066104C
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EDEF RID: 191983 RVA: 0x00662E89 File Offset: 0x00661089
		public static Offset<ICloseSplineMove> CreateICloseSplineMove(FlatBufferBuilder builder, ESplineMoveConfigType Type = ESplineMoveConfigType.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			ICloseSplineMove.AddSplineEntityId(builder, SplineEntityId);
			ICloseSplineMove.AddTarget(builder, TargetOffset);
			ICloseSplineMove.AddTargetType(builder, Target_type);
			ICloseSplineMove.AddType(builder, Type);
			return ICloseSplineMove.EndICloseSplineMove(builder);
		}

		// Token: 0x0602EDF0 RID: 191984 RVA: 0x00662EB5 File Offset: 0x006610B5
		public static void StartICloseSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EDF1 RID: 191985 RVA: 0x00662EBE File Offset: 0x006610BE
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDF2 RID: 191986 RVA: 0x00662EC9 File Offset: 0x006610C9
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602EDF3 RID: 191987 RVA: 0x00662ED4 File Offset: 0x006610D4
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602EDF4 RID: 191988 RVA: 0x00662EDF File Offset: 0x006610DF
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0602EDF5 RID: 191989 RVA: 0x00662EEA File Offset: 0x006610EA
		public static Offset<ICloseSplineMove> EndICloseSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSplineMove>(builder.EndTable());
		}

		// Token: 0x0602EDF6 RID: 191990 RVA: 0x00662EF8 File Offset: 0x006610F8
		public ICloseSplineMoveT UnPack()
		{
			ICloseSplineMoveT closeSplineMoveT = new ICloseSplineMoveT();
			this.UnPackTo(closeSplineMoveT);
			return closeSplineMoveT;
		}

		// Token: 0x0602EDF7 RID: 191991 RVA: 0x00662F14 File Offset: 0x00661114
		public void UnPackTo(ICloseSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0602EDF8 RID: 191992 RVA: 0x0066309C File Offset: 0x0066129C
		public static Offset<ICloseSplineMove> Pack(FlatBufferBuilder builder, ICloseSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICloseSplineMove>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return ICloseSplineMove.CreateICloseSplineMove(builder, _o.Type, target_type, targetOffset, _o.SplineEntityId);
		}

		// Token: 0x04011845 RID: 71749
		private Table __p;
	}
}
