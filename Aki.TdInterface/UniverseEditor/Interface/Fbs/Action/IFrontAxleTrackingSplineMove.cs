using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F05 RID: 28421
	public struct IFrontAxleTrackingSplineMove : IFlatbufferObject
	{
		// Token: 0x1700D06C RID: 53356
		// (get) Token: 0x060312E1 RID: 201441 RVA: 0x006AA50D File Offset: 0x006A870D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060312E2 RID: 201442 RVA: 0x006AA51A File Offset: 0x006A871A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060312E3 RID: 201443 RVA: 0x006AA524 File Offset: 0x006A8724
		public static IFrontAxleTrackingSplineMove GetRootAsIFrontAxleTrackingSplineMove(ByteBuffer _bb)
		{
			return IFrontAxleTrackingSplineMove.GetRootAsIFrontAxleTrackingSplineMove(_bb, default(IFrontAxleTrackingSplineMove));
		}

		// Token: 0x060312E4 RID: 201444 RVA: 0x006AA540 File Offset: 0x006A8740
		public static IFrontAxleTrackingSplineMove GetRootAsIFrontAxleTrackingSplineMove(ByteBuffer _bb, IFrontAxleTrackingSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060312E5 RID: 201445 RVA: 0x006AA55D File Offset: 0x006A875D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060312E6 RID: 201446 RVA: 0x006AA56C File Offset: 0x006A876C
		public IFrontAxleTrackingSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D06D RID: 53357
		// (get) Token: 0x060312E7 RID: 201447 RVA: 0x006AA57C File Offset: 0x006A877C
		public ENewSplineMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveType.FrontAxleTracking;
				}
				return (ENewSplineMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D06E RID: 53358
		// (get) Token: 0x060312E8 RID: 201448 RVA: 0x006AA5B8 File Offset: 0x006A87B8
		public float EntityAxisLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060312E9 RID: 201449 RVA: 0x006AA5F8 File Offset: 0x006A87F8
		public static Offset<IFrontAxleTrackingSplineMove> CreateIFrontAxleTrackingSplineMove(FlatBufferBuilder builder, ENewSplineMoveType Type = ENewSplineMoveType.FrontAxleTracking, float EntityAxisLength = 0f)
		{
			builder.StartTable(2);
			IFrontAxleTrackingSplineMove.AddEntityAxisLength(builder, EntityAxisLength);
			IFrontAxleTrackingSplineMove.AddType(builder, Type);
			return IFrontAxleTrackingSplineMove.EndIFrontAxleTrackingSplineMove(builder);
		}

		// Token: 0x060312EA RID: 201450 RVA: 0x006AA615 File Offset: 0x006A8815
		public static void StartIFrontAxleTrackingSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060312EB RID: 201451 RVA: 0x006AA61E File Offset: 0x006A881E
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060312EC RID: 201452 RVA: 0x006AA629 File Offset: 0x006A8829
		public static void AddEntityAxisLength(FlatBufferBuilder builder, float entityAxisLength)
		{
			builder.AddFloat(1, entityAxisLength, 0.0);
		}

		// Token: 0x060312ED RID: 201453 RVA: 0x006AA63C File Offset: 0x006A883C
		public static Offset<IFrontAxleTrackingSplineMove> EndIFrontAxleTrackingSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IFrontAxleTrackingSplineMove>(builder.EndTable());
		}

		// Token: 0x060312EE RID: 201454 RVA: 0x006AA64C File Offset: 0x006A884C
		public IFrontAxleTrackingSplineMoveT UnPack()
		{
			IFrontAxleTrackingSplineMoveT frontAxleTrackingSplineMoveT = new IFrontAxleTrackingSplineMoveT();
			this.UnPackTo(frontAxleTrackingSplineMoveT);
			return frontAxleTrackingSplineMoveT;
		}

		// Token: 0x060312EF RID: 201455 RVA: 0x006AA667 File Offset: 0x006A8867
		public void UnPackTo(IFrontAxleTrackingSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.EntityAxisLength = this.EntityAxisLength;
		}

		// Token: 0x060312F0 RID: 201456 RVA: 0x006AA684 File Offset: 0x006A8884
		public static Offset<IFrontAxleTrackingSplineMove> Pack(FlatBufferBuilder builder, IFrontAxleTrackingSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrontAxleTrackingSplineMove>);
			}
			return IFrontAxleTrackingSplineMove.CreateIFrontAxleTrackingSplineMove(builder, _o.Type, _o.EntityAxisLength);
		}

		// Token: 0x04011E0B RID: 73227
		private Table __p;
	}
}
