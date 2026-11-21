using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C1A RID: 31770
	public struct ITraceSpline : IFlatbufferObject
	{
		// Token: 0x1700EDDB RID: 60891
		// (get) Token: 0x06039413 RID: 234515 RVA: 0x007BB9C2 File Offset: 0x007B9BC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039414 RID: 234516 RVA: 0x007BB9CF File Offset: 0x007B9BCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039415 RID: 234517 RVA: 0x007BB9D8 File Offset: 0x007B9BD8
		public static ITraceSpline GetRootAsITraceSpline(ByteBuffer _bb)
		{
			return ITraceSpline.GetRootAsITraceSpline(_bb, default(ITraceSpline));
		}

		// Token: 0x06039416 RID: 234518 RVA: 0x007BB9F4 File Offset: 0x007B9BF4
		public static ITraceSpline GetRootAsITraceSpline(ByteBuffer _bb, ITraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039417 RID: 234519 RVA: 0x007BBA11 File Offset: 0x007B9C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039418 RID: 234520 RVA: 0x007BBA20 File Offset: 0x007B9C20
		public ITraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDDC RID: 60892
		// (get) Token: 0x06039419 RID: 234521 RVA: 0x007BBA30 File Offset: 0x007B9C30
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603941A RID: 234522 RVA: 0x007BBA67 File Offset: 0x007B9C67
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603941B RID: 234523 RVA: 0x007BBA76 File Offset: 0x007B9C76
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700EDDD RID: 60893
		// (get) Token: 0x0603941C RID: 234524 RVA: 0x007BBA84 File Offset: 0x007B9C84
		public int Duration
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

		// Token: 0x1700EDDE RID: 60894
		// (get) Token: 0x0603941D RID: 234525 RVA: 0x007BBAC0 File Offset: 0x007B9CC0
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603941E RID: 234526 RVA: 0x007BBAFC File Offset: 0x007B9CFC
		public static Offset<ITraceSpline> CreateITraceSpline(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), int Duration = 0, int SplineEntityId = 0)
		{
			builder.StartTable(3);
			ITraceSpline.AddSplineEntityId(builder, SplineEntityId);
			ITraceSpline.AddDuration(builder, Duration);
			ITraceSpline.AddEffectPath(builder, EffectPathOffset);
			return ITraceSpline.EndITraceSpline(builder);
		}

		// Token: 0x0603941F RID: 234527 RVA: 0x007BBB20 File Offset: 0x007B9D20
		public static void StartITraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039420 RID: 234528 RVA: 0x007BBB29 File Offset: 0x007B9D29
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06039421 RID: 234529 RVA: 0x007BBB39 File Offset: 0x007B9D39
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(1, duration, 0);
		}

		// Token: 0x06039422 RID: 234530 RVA: 0x007BBB44 File Offset: 0x007B9D44
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06039423 RID: 234531 RVA: 0x007BBB4F File Offset: 0x007B9D4F
		public static Offset<ITraceSpline> EndITraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITraceSpline>(builder.EndTable());
		}

		// Token: 0x06039424 RID: 234532 RVA: 0x007BBB5C File Offset: 0x007B9D5C
		public ITraceSplineT UnPack()
		{
			ITraceSplineT traceSplineT = new ITraceSplineT();
			this.UnPackTo(traceSplineT);
			return traceSplineT;
		}

		// Token: 0x06039425 RID: 234533 RVA: 0x007BBB77 File Offset: 0x007B9D77
		public void UnPackTo(ITraceSplineT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.Duration = this.Duration;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x06039426 RID: 234534 RVA: 0x007BBBA0 File Offset: 0x007B9DA0
		public static Offset<ITraceSpline> Pack(FlatBufferBuilder builder, ITraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceSpline>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return ITraceSpline.CreateITraceSpline(builder, effectPathOffset, _o.Duration, _o.SplineEntityId);
		}

		// Token: 0x040132C1 RID: 78529
		private Table __p;
	}
}
