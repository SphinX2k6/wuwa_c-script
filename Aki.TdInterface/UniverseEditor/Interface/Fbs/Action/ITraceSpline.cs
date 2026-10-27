using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007427 RID: 29735
	public struct ITraceSpline : IFlatbufferObject
	{
		// Token: 0x1700E1BE RID: 57790
		// (get) Token: 0x0603602A RID: 221226 RVA: 0x00758C96 File Offset: 0x00756E96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603602B RID: 221227 RVA: 0x00758CA3 File Offset: 0x00756EA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603602C RID: 221228 RVA: 0x00758CAC File Offset: 0x00756EAC
		public static ITraceSpline GetRootAsITraceSpline(ByteBuffer _bb)
		{
			return ITraceSpline.GetRootAsITraceSpline(_bb, default(ITraceSpline));
		}

		// Token: 0x0603602D RID: 221229 RVA: 0x00758CC8 File Offset: 0x00756EC8
		public static ITraceSpline GetRootAsITraceSpline(ByteBuffer _bb, ITraceSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603602E RID: 221230 RVA: 0x00758CE5 File Offset: 0x00756EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603602F RID: 221231 RVA: 0x00758CF4 File Offset: 0x00756EF4
		public ITraceSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1BF RID: 57791
		// (get) Token: 0x06036030 RID: 221232 RVA: 0x00758D04 File Offset: 0x00756F04
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

		// Token: 0x06036031 RID: 221233 RVA: 0x00758D3B File Offset: 0x00756F3B
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036032 RID: 221234 RVA: 0x00758D4A File Offset: 0x00756F4A
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E1C0 RID: 57792
		// (get) Token: 0x06036033 RID: 221235 RVA: 0x00758D58 File Offset: 0x00756F58
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

		// Token: 0x1700E1C1 RID: 57793
		// (get) Token: 0x06036034 RID: 221236 RVA: 0x00758D94 File Offset: 0x00756F94
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

		// Token: 0x06036035 RID: 221237 RVA: 0x00758DD0 File Offset: 0x00756FD0
		public static Offset<ITraceSpline> CreateITraceSpline(FlatBufferBuilder builder, StringOffset EffectPathOffset = default(StringOffset), int Duration = 0, int SplineEntityId = 0)
		{
			builder.StartTable(3);
			ITraceSpline.AddSplineEntityId(builder, SplineEntityId);
			ITraceSpline.AddDuration(builder, Duration);
			ITraceSpline.AddEffectPath(builder, EffectPathOffset);
			return ITraceSpline.EndITraceSpline(builder);
		}

		// Token: 0x06036036 RID: 221238 RVA: 0x00758DF4 File Offset: 0x00756FF4
		public static void StartITraceSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036037 RID: 221239 RVA: 0x00758DFD File Offset: 0x00756FFD
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(0, effectPathOffset.Value, 0);
		}

		// Token: 0x06036038 RID: 221240 RVA: 0x00758E0D File Offset: 0x0075700D
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(1, duration, 0);
		}

		// Token: 0x06036039 RID: 221241 RVA: 0x00758E18 File Offset: 0x00757018
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x0603603A RID: 221242 RVA: 0x00758E23 File Offset: 0x00757023
		public static Offset<ITraceSpline> EndITraceSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITraceSpline>(builder.EndTable());
		}

		// Token: 0x0603603B RID: 221243 RVA: 0x00758E30 File Offset: 0x00757030
		public ITraceSplineT UnPack()
		{
			ITraceSplineT traceSplineT = new ITraceSplineT();
			this.UnPackTo(traceSplineT);
			return traceSplineT;
		}

		// Token: 0x0603603C RID: 221244 RVA: 0x00758E4B File Offset: 0x0075704B
		public void UnPackTo(ITraceSplineT _o)
		{
			_o.EffectPath = this.EffectPath;
			_o.Duration = this.Duration;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x0603603D RID: 221245 RVA: 0x00758E74 File Offset: 0x00757074
		public static Offset<ITraceSpline> Pack(FlatBufferBuilder builder, ITraceSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceSpline>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			return ITraceSpline.CreateITraceSpline(builder, effectPathOffset, _o.Duration, _o.SplineEntityId);
		}

		// Token: 0x0401229A RID: 74394
		private Table __p;
	}
}
