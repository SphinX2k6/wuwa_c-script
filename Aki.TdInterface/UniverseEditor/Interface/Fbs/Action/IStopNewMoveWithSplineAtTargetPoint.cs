using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E7 RID: 29159
	public struct IStopNewMoveWithSplineAtTargetPoint : IFlatbufferObject
	{
		// Token: 0x1700D88E RID: 55438
		// (get) Token: 0x06033B84 RID: 211844 RVA: 0x006F6965 File Offset: 0x006F4B65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B85 RID: 211845 RVA: 0x006F6972 File Offset: 0x006F4B72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B86 RID: 211846 RVA: 0x006F697C File Offset: 0x006F4B7C
		public static IStopNewMoveWithSplineAtTargetPoint GetRootAsIStopNewMoveWithSplineAtTargetPoint(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtTargetPoint.GetRootAsIStopNewMoveWithSplineAtTargetPoint(_bb, default(IStopNewMoveWithSplineAtTargetPoint));
		}

		// Token: 0x06033B87 RID: 211847 RVA: 0x006F6998 File Offset: 0x006F4B98
		public static IStopNewMoveWithSplineAtTargetPoint GetRootAsIStopNewMoveWithSplineAtTargetPoint(ByteBuffer _bb, IStopNewMoveWithSplineAtTargetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B88 RID: 211848 RVA: 0x006F69B5 File Offset: 0x006F4BB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B89 RID: 211849 RVA: 0x006F69C4 File Offset: 0x006F4BC4
		public IStopNewMoveWithSplineAtTargetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D88F RID: 55439
		// (get) Token: 0x06033B8A RID: 211850 RVA: 0x006F69D4 File Offset: 0x006F4BD4
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

		// Token: 0x1700D890 RID: 55440
		// (get) Token: 0x06033B8B RID: 211851 RVA: 0x006F6A10 File Offset: 0x006F4C10
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

		// Token: 0x06033B8C RID: 211852 RVA: 0x006F6A4C File Offset: 0x006F4C4C
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> CreateIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos, int PointId = 0)
		{
			builder.StartTable(2);
			IStopNewMoveWithSplineAtTargetPoint.AddPointId(builder, PointId);
			IStopNewMoveWithSplineAtTargetPoint.AddType(builder, Type);
			return IStopNewMoveWithSplineAtTargetPoint.EndIStopNewMoveWithSplineAtTargetPoint(builder);
		}

		// Token: 0x06033B8D RID: 211853 RVA: 0x006F6A69 File Offset: 0x006F4C69
		public static void StartIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033B8E RID: 211854 RVA: 0x006F6A72 File Offset: 0x006F4C72
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B8F RID: 211855 RVA: 0x006F6A7D File Offset: 0x006F4C7D
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06033B90 RID: 211856 RVA: 0x006F6A88 File Offset: 0x006F4C88
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> EndIStopNewMoveWithSplineAtTargetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtTargetPoint>(builder.EndTable());
		}

		// Token: 0x06033B91 RID: 211857 RVA: 0x006F6A98 File Offset: 0x006F4C98
		public IStopNewMoveWithSplineAtTargetPointT UnPack()
		{
			IStopNewMoveWithSplineAtTargetPointT stopNewMoveWithSplineAtTargetPointT = new IStopNewMoveWithSplineAtTargetPointT();
			this.UnPackTo(stopNewMoveWithSplineAtTargetPointT);
			return stopNewMoveWithSplineAtTargetPointT;
		}

		// Token: 0x06033B92 RID: 211858 RVA: 0x006F6AB3 File Offset: 0x006F4CB3
		public void UnPackTo(IStopNewMoveWithSplineAtTargetPointT _o)
		{
			_o.Type = this.Type;
			_o.PointId = this.PointId;
		}

		// Token: 0x06033B93 RID: 211859 RVA: 0x006F6AD0 File Offset: 0x006F4CD0
		public static Offset<IStopNewMoveWithSplineAtTargetPoint> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtTargetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtTargetPoint>);
			}
			return IStopNewMoveWithSplineAtTargetPoint.CreateIStopNewMoveWithSplineAtTargetPoint(builder, _o.Type, _o.PointId);
		}

		// Token: 0x04011CC5 RID: 72901
		private Table __p;
	}
}
