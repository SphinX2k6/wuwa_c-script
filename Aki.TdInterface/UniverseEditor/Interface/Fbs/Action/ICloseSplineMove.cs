using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006436 RID: 25654
	public struct ICloseSplineMove : IFlatbufferObject
	{
		// Token: 0x1700BF05 RID: 48901
		// (get) Token: 0x0602C65B RID: 181851 RVA: 0x00617654 File Offset: 0x00615854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C65C RID: 181852 RVA: 0x00617661 File Offset: 0x00615861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C65D RID: 181853 RVA: 0x00617668 File Offset: 0x00615868
		public static ICloseSplineMove GetRootAsICloseSplineMove(ByteBuffer _bb)
		{
			return ICloseSplineMove.GetRootAsICloseSplineMove(_bb, default(ICloseSplineMove));
		}

		// Token: 0x0602C65E RID: 181854 RVA: 0x00617684 File Offset: 0x00615884
		public static ICloseSplineMove GetRootAsICloseSplineMove(ByteBuffer _bb, ICloseSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C65F RID: 181855 RVA: 0x006176A1 File Offset: 0x006158A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C660 RID: 181856 RVA: 0x006176B0 File Offset: 0x006158B0
		public ICloseSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF06 RID: 48902
		// (get) Token: 0x0602C661 RID: 181857 RVA: 0x006176C0 File Offset: 0x006158C0
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

		// Token: 0x1700BF07 RID: 48903
		// (get) Token: 0x0602C662 RID: 181858 RVA: 0x006176FC File Offset: 0x006158FC
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

		// Token: 0x0602C663 RID: 181859 RVA: 0x00617738 File Offset: 0x00615938
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C664 RID: 181860 RVA: 0x0061777C File Offset: 0x0061597C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602C665 RID: 181861 RVA: 0x00617798 File Offset: 0x00615998
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602C666 RID: 181862 RVA: 0x006177B4 File Offset: 0x006159B4
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602C667 RID: 181863 RVA: 0x006177D0 File Offset: 0x006159D0
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602C668 RID: 181864 RVA: 0x006177EC File Offset: 0x006159EC
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700BF08 RID: 48904
		// (get) Token: 0x0602C669 RID: 181865 RVA: 0x00617808 File Offset: 0x00615A08
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

		// Token: 0x0602C66A RID: 181866 RVA: 0x00617845 File Offset: 0x00615A45
		public static Offset<ICloseSplineMove> CreateICloseSplineMove(FlatBufferBuilder builder, ESplineMoveConfigType Type = ESplineMoveConfigType.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			ICloseSplineMove.AddSplineEntityId(builder, SplineEntityId);
			ICloseSplineMove.AddTarget(builder, TargetOffset);
			ICloseSplineMove.AddTargetType(builder, Target_type);
			ICloseSplineMove.AddType(builder, Type);
			return ICloseSplineMove.EndICloseSplineMove(builder);
		}

		// Token: 0x0602C66B RID: 181867 RVA: 0x00617871 File Offset: 0x00615A71
		public static void StartICloseSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C66C RID: 181868 RVA: 0x0061787A File Offset: 0x00615A7A
		public static void AddType(FlatBufferBuilder builder, ESplineMoveConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C66D RID: 181869 RVA: 0x00617885 File Offset: 0x00615A85
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602C66E RID: 181870 RVA: 0x00617890 File Offset: 0x00615A90
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602C66F RID: 181871 RVA: 0x0061789B File Offset: 0x00615A9B
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x0602C670 RID: 181872 RVA: 0x006178A6 File Offset: 0x00615AA6
		public static Offset<ICloseSplineMove> EndICloseSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<ICloseSplineMove>(builder.EndTable());
		}

		// Token: 0x0602C671 RID: 181873 RVA: 0x006178B4 File Offset: 0x00615AB4
		public ICloseSplineMoveT UnPack()
		{
			ICloseSplineMoveT closeSplineMoveT = new ICloseSplineMoveT();
			this.UnPackTo(closeSplineMoveT);
			return closeSplineMoveT;
		}

		// Token: 0x0602C672 RID: 181874 RVA: 0x006178D0 File Offset: 0x00615AD0
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

		// Token: 0x0602C673 RID: 181875 RVA: 0x00617A58 File Offset: 0x00615C58
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

		// Token: 0x04010A28 RID: 68136
		private Table __p;
	}
}
