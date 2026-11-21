using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AC RID: 29612
	public struct IOpenTraceSpline : IFlatbufferObject
	{
		// Token: 0x1700D983 RID: 55683
		// (get) Token: 0x06033C83 RID: 212099 RVA: 0x006FC221 File Offset: 0x006FA421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C84 RID: 212100 RVA: 0x006FC22E File Offset: 0x006FA42E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C85 RID: 212101 RVA: 0x006FC238 File Offset: 0x006FA438
		public static IOpenTraceSpline GetRootAsIOpenTraceSpline(ByteBuffer _bb)
		{
			return IOpenTraceSpline.GetRootAsIOpenTraceSpline(_bb, default(IOpenTraceSpline));
		}

		// Token: 0x06033C86 RID: 212102 RVA: 0x006FC254 File Offset: 0x006FA454
		public static IOpenTraceSpline GetRootAsIOpenTraceSpline(ByteBuffer _bb, IOpenTraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C87 RID: 212103 RVA: 0x006FC271 File Offset: 0x006FA471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C88 RID: 212104 RVA: 0x006FC280 File Offset: 0x006FA480
		public IOpenTraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D984 RID: 55684
		// (get) Token: 0x06033C89 RID: 212105 RVA: 0x006FC290 File Offset: 0x006FA490
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

		// Token: 0x1700D985 RID: 55685
		// (get) Token: 0x06033C8A RID: 212106 RVA: 0x006FC2CC File Offset: 0x006FA4CC
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

		// Token: 0x1700D986 RID: 55686
		// (get) Token: 0x06033C8B RID: 212107 RVA: 0x006FC308 File Offset: 0x006FA508
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

		// Token: 0x06033C8C RID: 212108 RVA: 0x006FC348 File Offset: 0x006FA548
		public static Offset<IOpenTraceSpline> CreateIOpenTraceSpline(FlatBufferBuilder builder, ETraceSplineOptionType Type = ETraceSplineOptionType.Open, int SplineEntityId = 0, float Duration = 0f)
		{
			builder.StartTable(3);
			IOpenTraceSpline.AddDuration(builder, Duration);
			IOpenTraceSpline.AddSplineEntityId(builder, SplineEntityId);
			IOpenTraceSpline.AddType(builder, Type);
			return IOpenTraceSpline.EndIOpenTraceSpline(builder);
		}

		// Token: 0x06033C8D RID: 212109 RVA: 0x006FC36C File Offset: 0x006FA56C
		public static void StartIOpenTraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033C8E RID: 212110 RVA: 0x006FC375 File Offset: 0x006FA575
		public static void AddType(FlatBufferBuilder builder, ETraceSplineOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C8F RID: 212111 RVA: 0x006FC380 File Offset: 0x006FA580
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06033C90 RID: 212112 RVA: 0x006FC38B File Offset: 0x006FA58B
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06033C91 RID: 212113 RVA: 0x006FC39E File Offset: 0x006FA59E
		public static Offset<IOpenTraceSpline> EndIOpenTraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<IOpenTraceSpline>(builder.EndTable());
		}

		// Token: 0x06033C92 RID: 212114 RVA: 0x006FC3AC File Offset: 0x006FA5AC
		public IOpenTraceSplineT UnPack()
		{
			IOpenTraceSplineT openTraceSplineT = new IOpenTraceSplineT();
			this.UnPackTo(openTraceSplineT);
			return openTraceSplineT;
		}

		// Token: 0x06033C93 RID: 212115 RVA: 0x006FC3C7 File Offset: 0x006FA5C7
		public void UnPackTo(IOpenTraceSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.Duration = this.Duration;
		}

		// Token: 0x06033C94 RID: 212116 RVA: 0x006FC3F0 File Offset: 0x006FA5F0
		public static Offset<IOpenTraceSpline> Pack(FlatBufferBuilder builder, IOpenTraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenTraceSpline>);
			}
			return IOpenTraceSpline.CreateIOpenTraceSpline(builder, _o.Type, _o.SplineEntityId, _o.Duration);
		}

		// Token: 0x040124D9 RID: 74969
		private Table __p;
	}
}
