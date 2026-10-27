using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C00 RID: 27648
	public struct IOpenGlobalTimeScale : IFlatbufferObject
	{
		// Token: 0x1700CD98 RID: 52632
		// (get) Token: 0x060309AC RID: 199084 RVA: 0x0069915C File Offset: 0x0069735C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309AD RID: 199085 RVA: 0x00699169 File Offset: 0x00697369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309AE RID: 199086 RVA: 0x00699170 File Offset: 0x00697370
		public static IOpenGlobalTimeScale GetRootAsIOpenGlobalTimeScale(ByteBuffer _bb)
		{
			return IOpenGlobalTimeScale.GetRootAsIOpenGlobalTimeScale(_bb, default(IOpenGlobalTimeScale));
		}

		// Token: 0x060309AF RID: 199087 RVA: 0x0069918C File Offset: 0x0069738C
		public static IOpenGlobalTimeScale GetRootAsIOpenGlobalTimeScale(ByteBuffer _bb, IOpenGlobalTimeScale obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309B0 RID: 199088 RVA: 0x006991A9 File Offset: 0x006973A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309B1 RID: 199089 RVA: 0x006991B8 File Offset: 0x006973B8
		public IOpenGlobalTimeScale __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD99 RID: 52633
		// (get) Token: 0x060309B2 RID: 199090 RVA: 0x006991C8 File Offset: 0x006973C8
		public ESetTimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetTimeScaleType.Open;
				}
				return (ESetTimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD9A RID: 52634
		// (get) Token: 0x060309B3 RID: 199091 RVA: 0x00699204 File Offset: 0x00697404
		public float TimeScale
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

		// Token: 0x1700CD9B RID: 52635
		// (get) Token: 0x060309B4 RID: 199092 RVA: 0x00699244 File Offset: 0x00697444
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

		// Token: 0x060309B5 RID: 199093 RVA: 0x00699284 File Offset: 0x00697484
		public static Offset<IOpenGlobalTimeScale> CreateIOpenGlobalTimeScale(FlatBufferBuilder builder, ESetTimeScaleType Type = ESetTimeScaleType.Open, float TimeScale = 0f, float Duration = 0f)
		{
			builder.StartTable(3);
			IOpenGlobalTimeScale.AddDuration(builder, Duration);
			IOpenGlobalTimeScale.AddTimeScale(builder, TimeScale);
			IOpenGlobalTimeScale.AddType(builder, Type);
			return IOpenGlobalTimeScale.EndIOpenGlobalTimeScale(builder);
		}

		// Token: 0x060309B6 RID: 199094 RVA: 0x006992A8 File Offset: 0x006974A8
		public static void StartIOpenGlobalTimeScale(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060309B7 RID: 199095 RVA: 0x006992B1 File Offset: 0x006974B1
		public static void AddType(FlatBufferBuilder builder, ESetTimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309B8 RID: 199096 RVA: 0x006992BC File Offset: 0x006974BC
		public static void AddTimeScale(FlatBufferBuilder builder, float timeScale)
		{
			builder.AddFloat(1, timeScale, 0.0);
		}

		// Token: 0x060309B9 RID: 199097 RVA: 0x006992CF File Offset: 0x006974CF
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x060309BA RID: 199098 RVA: 0x006992E2 File Offset: 0x006974E2
		public static Offset<IOpenGlobalTimeScale> EndIOpenGlobalTimeScale(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGlobalTimeScale>(builder.EndTable());
		}

		// Token: 0x060309BB RID: 199099 RVA: 0x006992F0 File Offset: 0x006974F0
		public IOpenGlobalTimeScaleT UnPack()
		{
			IOpenGlobalTimeScaleT openGlobalTimeScaleT = new IOpenGlobalTimeScaleT();
			this.UnPackTo(openGlobalTimeScaleT);
			return openGlobalTimeScaleT;
		}

		// Token: 0x060309BC RID: 199100 RVA: 0x0069930B File Offset: 0x0069750B
		public void UnPackTo(IOpenGlobalTimeScaleT _o)
		{
			_o.Type = this.Type;
			_o.TimeScale = this.TimeScale;
			_o.Duration = this.Duration;
		}

		// Token: 0x060309BD RID: 199101 RVA: 0x00699334 File Offset: 0x00697534
		public static Offset<IOpenGlobalTimeScale> Pack(FlatBufferBuilder builder, IOpenGlobalTimeScaleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGlobalTimeScale>);
			}
			return IOpenGlobalTimeScale.CreateIOpenGlobalTimeScale(builder, _o.Type, _o.TimeScale, _o.Duration);
		}

		// Token: 0x040114FC RID: 70908
		private Table __p;
	}
}
