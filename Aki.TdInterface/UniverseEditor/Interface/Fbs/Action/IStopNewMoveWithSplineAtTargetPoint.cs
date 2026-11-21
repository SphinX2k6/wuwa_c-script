using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079BC RID: 31164
	public struct IStopNewMoveWithSplineAtTargetPoint : IFlatbufferObject
	{
		// Token: 0x1700E487 RID: 58503
		// (get) Token: 0x06036E86 RID: 224902 RVA: 0x00757CC5 File Offset: 0x00755EC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E87 RID: 224903 RVA: 0x00757CD2 File Offset: 0x00755ED2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E88 RID: 224904 RVA: 0x00757CDC File Offset: 0x00755EDC
		public static IStopNewMoveWithSplineAtTargetPoint GetRootAsIStopNewMoveWithSplineAtTargetPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtTargetPoint.GetRootAsIStopNewMoveWithSplineAtTargetPoint(_bb, default(IStopNewMoveWithSplineAtTargetPoint));
		}

		// Token: 0x06036E89 RID: 224905 RVA: 0x00757CF8 File Offset: 0x00755EF8
		public static IStopNewMoveWithSplineAtTargetPoint GetRootAsIStopNewMoveWithSplineAtTargetPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtTargetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E8A RID: 224906 RVA: 0x00757D15 File Offset: 0x00755F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E8B RID: 224907 RVA: 0x00757D24 File Offset: 0x00755F24
		public IStopNewMoveWithSplineAtTargetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E488 RID: 58504
		// (get) Token: 0x06036E8C RID: 224908 RVA: 0x00757D34 File Offset: 0x00755F34
		public EStopNewMoveWithSplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return (EStopNewMoveWithSplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E489 RID: 58505
		// (get) Token: 0x06036E8D RID: 224909 RVA: 0x00757D70 File Offset: 0x00755F70
		public int PointId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036E8E RID: 224910 RVA: 0x00757DAC File Offset: 0x00755FAC
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> CreateIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos, int PointId = 0)
		{
			builder.StartTable(2);
			IStopNewMoveWithSplineAtTargetPoint.AddPointId(builder, PointId);
			IStopNewMoveWithSplineAtTargetPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtTargetPoint.EndIStopNewMoveWithSplineAtTargetPoint(builder);
		}

		// Token: 0x06036E8F RID: 224911 RVA: 0x00757DC9 File Offset: 0x00755FC9
		public static void StartIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036E90 RID: 224912 RVA: 0x00757DD2 File Offset: 0x00755FD2
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E91 RID: 224913 RVA: 0x00757DDD File Offset: 0x00755FDD
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06036E92 RID: 224914 RVA: 0x00757DE8 File Offset: 0x00755FE8
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> EndIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtTargetPoint>(builder.EndTable());
		}

		// Token: 0x06036E93 RID: 224915 RVA: 0x00757DF8 File Offset: 0x00755FF8
		public IStopNewMoveWithSplineAtTargetPointT UnPack()
		{
			IStopNewMoveWithSplineAtTargetPointT stopNewMoveWithSplineAtTargetPointT = new IStopNewMoveWithSplineAtTargetPointT();
			this.UnPackTo(stopNewMoveWithSplineAtTargetPointT);
			return stopNewMoveWithSplineAtTargetPointT;
		}

		// Token: 0x06036E94 RID: 224916 RVA: 0x00757E13 File Offset: 0x00756013
		public void UnPackTo(IStopNewMoveWithSplineAtTargetPointT _o)
		{
			_o.Type = this.Type;
			_o.PointId = this.PointId;
		}

		// Token: 0x06036E95 RID: 224917 RVA: 0x00757E30 File Offset: 0x00756030
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtTargetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtTargetPoint>);
			}
			return IStopNewMoveWithSplineAtTargetPoint.CreateIStopNewMoveWithSplineAtTargetPoint(builder, _o.Type, _o.PointId);
		}

		// Token: 0x04012CC7 RID: 76999
		private Table __p;
	}
}
