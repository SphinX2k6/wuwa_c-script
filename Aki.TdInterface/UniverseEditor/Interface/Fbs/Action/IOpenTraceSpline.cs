using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C45 RID: 27717
	public struct IOpenTraceSpline : IFlatbufferObject
	{
		// Token: 0x1700CE68 RID: 52840
		// (get) Token: 0x06030D28 RID: 199976 RVA: 0x006A1D21 File Offset: 0x0069FF21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D29 RID: 199977 RVA: 0x006A1D2E File Offset: 0x0069FF2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D2A RID: 199978 RVA: 0x006A1D38 File Offset: 0x0069FF38
		public static IOpenTraceSpline GetRootAsIOpenTraceSpline(ByteBuffer _bb)
		{
			return IOpenTraceSpline.GetRootAsIOpenTraceSpline(_bb, default(IOpenTraceSpline));
		}

		// Token: 0x06030D2B RID: 199979 RVA: 0x006A1D54 File Offset: 0x0069FF54
		public static IOpenTraceSpline GetRootAsIOpenTraceSpline(ByteBuffer _bb, IOpenTraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D2C RID: 199980 RVA: 0x006A1D71 File Offset: 0x0069FF71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D2D RID: 199981 RVA: 0x006A1D80 File Offset: 0x0069FF80
		public IOpenTraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE69 RID: 52841
		// (get) Token: 0x06030D2E RID: 199982 RVA: 0x006A1D90 File Offset: 0x0069FF90
		public ETraceSplineOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETraceSplineOptionType.Open;
				}
				return (ETraceSplineOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CE6A RID: 52842
		// (get) Token: 0x06030D2F RID: 199983 RVA: 0x006A1DCC File Offset: 0x0069FFCC
		public int SplineEntityId
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

		// Token: 0x1700CE6B RID: 52843
		// (get) Token: 0x06030D30 RID: 199984 RVA: 0x006A1E08 File Offset: 0x006A0008
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030D31 RID: 199985 RVA: 0x006A1E48 File Offset: 0x006A0048
		public static Offset<IOpenTraceSpline> CreateIOpenTraceSpline(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open, int SplineEntityId = 0, float Duration = 0f)
		{
			builder.StartTable(3);
			IOpenTraceSpline.AddDuration(builder, Duration);
			IOpenTraceSpline.AddSplineEntityId(builder, SplineEntityId);
			IOpenTraceSpline.AddType(builder, Type);
			return IOpenTraceSpline.EndIOpenTraceSpline(builder);
		}

		// Token: 0x06030D32 RID: 199986 RVA: 0x006A1E6C File Offset: 0x006A006C
		public static void StartIOpenTraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030D33 RID: 199987 RVA: 0x006A1E75 File Offset: 0x006A0075
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030D34 RID: 199988 RVA: 0x006A1E80 File Offset: 0x006A0080
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06030D35 RID: 199989 RVA: 0x006A1E8B File Offset: 0x006A008B
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06030D36 RID: 199990 RVA: 0x006A1E9E File Offset: 0x006A009E
		public static Offset<IOpenTraceSpline> EndIOpenTraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<IOpenTraceSpline>(builder.EndTable());
		}

		// Token: 0x06030D37 RID: 199991 RVA: 0x006A1EAC File Offset: 0x006A00AC
		public IOpenTraceSplineT UnPack()
		{
			IOpenTraceSplineT openTraceSplineT = new IOpenTraceSplineT();
			this.UnPackTo(openTraceSplineT);
			return openTraceSplineT;
		}

		// Token: 0x06030D38 RID: 199992 RVA: 0x006A1EC7 File Offset: 0x006A00C7
		public void UnPackTo(IOpenTraceSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.Duration = this.Duration;
		}

		// Token: 0x06030D39 RID: 199993 RVA: 0x006A1EF0 File Offset: 0x006A00F0
		public static Offset<IOpenTraceSpline> Pack(FlatBufferBuilder builder, IOpenTraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenTraceSpline>);
			}
			return IOpenTraceSpline.CreateIOpenTraceSpline(builder, _o.Type, _o.SplineEntityId, _o.Duration);
		}

		// Token: 0x04011581 RID: 71041
		private Table __p;
	}
}
